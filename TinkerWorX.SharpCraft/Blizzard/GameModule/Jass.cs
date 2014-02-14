using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.Utilities;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static class JassMachine
    {
        private static JassPtr jass;

        private static GameFunctions.Jass__ConstructorPrototype Jass__Constructor;

        private static GameFunctions.VirtualMachine__RunFunctionPrototype VirtualMachine__RunFunction;

        private static GameFunctions.VirtualMachine__RunCodePrototype VirtualMachine__RunCode;

        public static event Action PreConfig;

        public static event Action PostConfig;

        public static event Action PreMain;

        public static event Action PostMain;

        public static event JassAPIScriptLoadEventHandler ScriptLoad;

        public static event VirtualMachine__RunCodeCallbackDelegate VirtualMachine__RunCodeCallback;

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(JassMachine).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(JassMachine).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;

            address = GameAddresses.Jass__Constructor;
            Trace.Write(" - Jass__Constructor: 0x" + address.ToString("X8") + " . ");
            JassMachine.Jass__Constructor = Memory.InstallHook(address, new GameFunctions.Jass__ConstructorPrototype(JassMachine.Jass__ConstructorHook), true, false);
            Trace.WriteLine("installed!");

            address = GameAddresses.VirtualMachine__RunFunction;
            Trace.Write(" - VirtualMachine__RunFunction: 0x" + address.ToString("X8") + " . ");
            JassMachine.VirtualMachine__RunFunction = Memory.InstallHook(address, new GameFunctions.VirtualMachine__RunFunctionPrototype(JassMachine.VirtualMachine__RunFunctionHook), true, false);
            Trace.WriteLine("installed!");

            address = GameAddresses.VirtualMachine__RunCode;
            Trace.Write(" - VirtualMachine__RunCode: 0x" + address.ToString("X8") + " . ");
            JassMachine.VirtualMachine__RunCode = Memory.InstallHook(address, new GameFunctions.VirtualMachine__RunCodePrototype(JassMachine.VirtualMachine__RunCodeHook), true, false);
            Trace.WriteLine("installed!");
        }

        private static void OnPreConfig(Boolean inLobby)
        {
            if (JassMachine.PreConfig != null)
                JassMachine.PreConfig();
        }

        private static void OnPostConfig(Boolean inLobby)
        {
            if (JassMachine.PostConfig != null)
                JassMachine.PostConfig();
        }

        private static void OnPreMain()
        {
            if (JassMachine.PreMain != null)
                JassMachine.PreMain();
        }

        private static void OnPostMain()
        {
            if (JassMachine.PostMain != null)
                JassMachine.PostMain();
        }

        private static void OnScriptLoad(String script)
        {
            if (JassMachine.ScriptLoad != null)
                JassMachine.ScriptLoad(script);
        }

        private static void OnRunCodeCallback(VirtualMachinePtr virtualMachine, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5, CodeResult result)
        {
            if (JassMachine.VirtualMachine__RunCodeCallback != null)
                JassMachine.VirtualMachine__RunCodeCallback(virtualMachine, opCode, a3, opLimit, a5, result);
        }

        private static JassPtr Jass__ConstructorHook(JassPtr @this)
        {
            var result = JassMachine.Jass__Constructor(@this);

            JassMachine.jass = result;

            return result;
        }

        unsafe private static IntPtr VirtualMachine__RunFunctionHook(VirtualMachinePtr virtualMachine, String functionName, Int32 a3, Int32 a4, Int32 a5, Int32 a6)
        {
            var result = IntPtr.Zero;

            switch (functionName)
            {
                case "config":
                    var file = Storm.FileOpenFileEx(IntPtr.Zero, "war3map.cs", 0);
                    if (file != IntPtr.Zero)
                    {
                        var script = Storm.FileReadToEnd(file);
                        Storm.FileCloseFile(file);
                        JassMachine.OnScriptLoad(script);
                    }
                    else
                    {
                        JassMachine.OnScriptLoad(null);
                    }
                    JassMachine.OnPreConfig(Game.IsInMap);
                    result = JassMachine.VirtualMachine__RunFunction(virtualMachine, functionName, a3, a4, a5, a6);
                    JassMachine.OnPostConfig(Game.IsInMap);
                    break;

                case "main":
                    JassMachine.OnPreMain();
                    result = JassMachine.VirtualMachine__RunFunction(virtualMachine, functionName, a3, a4, a5, a6);
                    JassMachine.OnPostMain();
                    break;

                default:
                    result = JassMachine.VirtualMachine__RunFunction(virtualMachine, functionName, a3, a4, a5, a6);
                    break;
            }

            return result;
        }

        unsafe private static CodeResult VirtualMachine__RunCodeHook(VirtualMachinePtr virtualMachine, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5)
        {
            var result = VirtualMachine__RunCode(virtualMachine, opCode, a3, opLimit, a5);

            JassMachine.OnRunCodeCallback(virtualMachine, opCode, a3, opLimit, a5, result);

            return result;
        }
    }

    public delegate void JassAPIScriptLoadEventHandler(String script);

    public delegate void VirtualMachine__RunCodeCallbackDelegate(VirtualMachinePtr virtualMachine, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5, CodeResult result);
}
