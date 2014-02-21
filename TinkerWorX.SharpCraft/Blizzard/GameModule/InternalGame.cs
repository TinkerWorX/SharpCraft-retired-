using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.Utilities;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static class InternalGame
    {
        private static GameFunctions.Unknown__SetStatePrototype Unknown__SetState;

        public static event Action EngineStart;

        public static event Action EngineEnd;

        public static event Action MapStart;

        public static event Action MapEnd;

        public static Boolean IsEngineRunning { get; private set; }

        public static Boolean IsInMap { get; private set; }

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(InternalGame).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(InternalGame).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;

            address = GameAddresses.Unknown__SetState;
            Trace.Write("Unknown__SetState: 0x" + address.ToString("X8") + " . ");
            InternalGame.Unknown__SetState = Memory.InstallHook(address, new GameFunctions.Unknown__SetStatePrototype(InternalGame.Unknown__SetStateHook), true, false);
            Trace.WriteLine("hook installed!");
        }

        private static void OnEngineStart()
        {
            try
            {
                if (InternalGame.EngineStart != null)
                    InternalGame.EngineStart();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalGame.OnEngineStart!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnEngineEnd()
        {
            try
            {
                if (InternalGame.EngineEnd != null)
                    InternalGame.EngineEnd();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalGame.OnEngineEnd!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnMapStart()
        {
            try
            {
                if (InternalGame.MapStart != null)
                    InternalGame.MapStart();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalGame.OnMapStart!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnMapEnd()
        {
            try
            {
                if (InternalGame.MapEnd != null)
                    InternalGame.MapEnd();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalGame.OnMapEnd!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static Int32 Unknown__SetStateHook(IntPtr @this, Boolean endMap, Boolean endEngine)
        {
            try
            {
                if (endEngine)
                {
                    if (InternalGame.IsInMap)
                    {
                        InternalGame.IsInMap = false;
                        InternalGame.OnMapEnd();
                    }
                    if (InternalGame.IsEngineRunning)
                    {
                        InternalGame.IsEngineRunning = false;
                        InternalGame.OnEngineEnd();
                    }
                }
                else
                {
                    if (endMap)
                    {
                        if (InternalGame.IsInMap)
                        {
                            InternalGame.IsInMap = false;
                            InternalGame.OnMapEnd();
                        }
                    }
                    else
                    {
                        if (!InternalGame.IsEngineRunning)
                        {
                            InternalGame.OnEngineStart();
                            InternalGame.IsEngineRunning = true;
                        }

                        if (InternalGame.IsInMap)
                        {
                            InternalGame.OnMapEnd();
                        }
                        InternalGame.OnMapStart();
                        InternalGame.IsInMap = true;
                    }
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalGame.Unknown__SetStateHook!");
                Trace.WriteLine(e.ToString());
            }

            return InternalGame.Unknown__SetState(@this, endMap, endEngine);
        }
    }
}
