using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.Utilities;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static class Game
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
                throw new Exception("Attempted to initialize " + typeof(Game).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(Game).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;

            address = GameAddresses.Unknown__SetState;
            Trace.Write("Unknown__SetState: 0x" + address.ToString("X8") + " . ");
            Game.Unknown__SetState = Memory.InstallHook(address, new GameFunctions.Unknown__SetStatePrototype(Game.Unknown__SetStateHook), true, false);
            Trace.WriteLine("hook installed!");
        }

        private static void OnEngineStart()
        {
            if (Game.EngineStart != null)
                Game.EngineStart();
        }

        private static void OnEngineEnd()
        {
            if (Game.EngineEnd != null)
                Game.EngineEnd();
        }

        private static void OnMapStart()
        {
            if (Game.MapStart != null)
                Game.MapStart();
        }

        private static void OnMapEnd()
        {
            if (Game.MapEnd != null)
                Game.MapEnd();
        }

        private static Int32 Unknown__SetStateHook(IntPtr @this, Boolean endMap, Boolean endEngine)
        {
            if (endEngine)
            {
                if (Game.IsInMap)
                {
                    Game.IsInMap = false;
                    Game.OnMapEnd();
                }
                if (Game.IsEngineRunning)
                {
                    Game.IsEngineRunning = false;
                    Game.OnEngineEnd();
                }
            }
            else
            {
                if (endMap)
                {
                    if (Game.IsInMap)
                    {
                        Game.IsInMap = false;
                        Game.OnMapEnd();
                    }
                }
                else
                {
                    if (!Game.IsEngineRunning)
                    {
                        Game.OnEngineStart();
                        Game.IsEngineRunning = true;
                    }

                    if (Game.IsInMap)
                    {
                        Game.OnMapEnd();
                    }
                    Game.OnMapStart();
                    Game.IsInMap = true;
                }
            }

            return Game.Unknown__SetState(@this, endMap, endEngine);
        }
    }
}
