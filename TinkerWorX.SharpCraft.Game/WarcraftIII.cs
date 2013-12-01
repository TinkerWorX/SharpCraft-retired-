using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using EasyHook;
using TinkerWorX.SharpCraft.Core;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.SharpCraft.Game
{
    public delegate void GameStartEventHandler();
    public delegate void GameEndEventHandler();
    public delegate void MapStartEventHandler();
    public delegate void MapEndEventHandler();

    [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A normal __thiscall function.
    internal delegate Int32 GameStatePrototype(IntPtr _this, Boolean endMap, Boolean endGame);

    public static class WarcraftIII
    {
        public static event GameStartEventHandler GameStart;
        public static event GameEndEventHandler GameEnd;
        public static event MapStartEventHandler MapStart;
        public static event MapEndEventHandler MapEnd;

        public static String HackPath { get; internal set; }
        public static String InstallPath { get; internal set; }

        public static IntPtr Module { get; private set; }
        public static ProcessMemory Memory { get; private set; }
        public static InputSystem Input { get; private set; }
        public static JassSystem Jass { get; private set; }
        public static InterfaceSystem Interface { get; private set; }

        private static GameStatePrototype gameState;

        private static LocalHook gameStateHook;

        internal static void Initialize()
        {
            Trace.Write(" - Fetching pointer for game.dll . ");
            WarcraftIII.Module = Kernel32.GetModuleHandle("game.dll");
            Trace.Write("0x" + WarcraftIII.Module.ToString("X8") + " . ");
            Trace.WriteLine("done!");

            Trace.Write(" - Initializing game memory . ");
            WarcraftIII.Memory = ProcessMemory.FromProcess(Process.GetCurrentProcess());
            Trace.WriteLine("done!");

            Trace.WriteLine(" - Initializing input system . . .");
            WarcraftIII.Input = new InputSystem();
            Trace.WriteLine(" - - Done!");

            Trace.WriteLine(" - Initializing interface system . . .");
            WarcraftIII.Interface = new InterfaceSystem();
            Trace.WriteLine(" - - Done!");

            Trace.WriteLine(" - Initializing JASS system . . .");
            WarcraftIII.Jass = new JassSystem();
            Trace.WriteLine("done!");

            Trace.WriteLine(" - Initializing state detection . . .");
            WarcraftIII.InstallGameStateHook(WarcraftIII.Module + Settings.Current.Addresses.GameState);
            Trace.WriteLine(" - - Done!");

            Trace.WriteLine(" - - Done!");
        }

        private static void InstallGameStateHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - GameStateHook: 0x" + address.ToString("X8") + " . ");

                WarcraftIII.gameState = (GameStatePrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(GameStatePrototype));
                Trace.Write("fetched . ");

                WarcraftIII.gameStateHook = LocalHook.Create(address, new GameStatePrototype(WarcraftIII.GameStateHook), null);
                WarcraftIII.gameStateHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        // Wrappers

        private static Int32 GameState(IntPtr _this, Boolean endMap, Boolean endGame)
        {
            return WarcraftIII.gameState(_this, endMap, endGame);
        }

        // Hooks

        private static Boolean gameStarted = false;
        private static Boolean mapStarted = false;
        private static Int32 GameStateHook(IntPtr _this, Boolean endMap, Boolean endGame)
        {
            //Debug.WriteLine("WarcraftIII.GameStateHook(_this:{0}, endMap:{1}, endGame:{2})", new object[] { "0x" + _this.ToString("X8"), endMap, endGame });
            if (endGame)
            {
                if (mapStarted)
                {
                    mapStarted = false;
                    OnMapEnd();
                }
                if (gameStarted)
                {
                    gameStarted = false;
                    OnGameEnd();
                }
            }
            else
            {
                if (endMap)
                {
                    if (mapStarted)
                    {
                        mapStarted = false;
                        OnMapEnd();
                    }
                }
                else
                {
                    if (!gameStarted)
                    {
                        OnGameStart();
                        gameStarted = true;
                    }

                    if (mapStarted)
                    {
                        OnMapEnd();
                    }
                    OnMapStart();
                    mapStarted = true;
                }
            }

            return WarcraftIII.GameState(_this, endMap, endGame);
        }

        // Functions

        private static void OnGameStart()
        {
            if (WarcraftIII.GameStart != null)
                WarcraftIII.GameStart();
        }

        private static void OnGameEnd()
        {
            if (WarcraftIII.GameEnd != null)
                WarcraftIII.GameEnd();
        }

        private static void OnMapStart()
        {
            if (WarcraftIII.MapStart != null)
                WarcraftIII.MapStart();
        }

        private static void OnMapEnd()
        {
            if (WarcraftIII.MapEnd != null)
                WarcraftIII.MapEnd();
        }

        [Obsolete("Warcraft.AddNative has been moved to WarcraftIII.Jass.AddNative. WarcraftIII.AddNative will be removed in version 2.")]
        public static void AddNative(Delegate function, String name, String prototype)
        {
            WarcraftIII.Jass.AddNative(function, name, prototype);
        }

        [Obsolete("Warcraft.AddNative has been moved to WarcraftIII.Jass.AddNative. WarcraftIII.AddNative will be removed in version 2.")]
        public static void AddNative(Delegate function, String name)
        {
            WarcraftIII.Jass.AddNative(function, name);
        }

        [Obsolete("Warcraft.AddNative has been moved to WarcraftIII.Jass.AddNative. WarcraftIII.AddNative will be removed in version 2.")]
        public static void AddNative(Delegate function)
        {
            WarcraftIII.Jass.AddNative(function);
        }

        [Obsolete("Warcraft.AddNative has been moved to WarcraftIII.Jass.AddNative. WarcraftIII.AddNative will be removed in version 2.")]
        public static Native GetNative(String name)
        {
            return WarcraftIII.Jass.GetNative(name);
        }
    }
}
