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
    internal static class InternalScript
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
                throw new Exception("Attempted to initialize " + typeof(InternalScript).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(InternalScript).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;

            address = GameAddresses.Jass__Constructor;
            Trace.Write(" - Jass__Constructor: 0x" + address.ToString("X8") + " . ");
            InternalScript.Jass__Constructor = Memory.InstallHook(address, new GameFunctions.Jass__ConstructorPrototype(InternalScript.Jass__ConstructorHook), true, false);
            Trace.WriteLine("installed!");

            address = GameAddresses.VirtualMachine__RunFunction;
            Trace.Write(" - VirtualMachine__RunFunction: 0x" + address.ToString("X8") + " . ");
            InternalScript.VirtualMachine__RunFunction = Memory.InstallHook(address, new GameFunctions.VirtualMachine__RunFunctionPrototype(InternalScript.VirtualMachine__RunFunctionHook), true, false);
            Trace.WriteLine("installed!");

            address = GameAddresses.VirtualMachine__RunCode;
            Trace.Write(" - VirtualMachine__RunCode: 0x" + address.ToString("X8") + " . ");
            InternalScript.VirtualMachine__RunCode = Memory.InstallHook(address, new GameFunctions.VirtualMachine__RunCodePrototype(InternalScript.VirtualMachine__RunCodeHook), true, false);
            Trace.WriteLine("installed!");
        }

        private static void OnPreConfig(Boolean inLobby)
        {
            try
            {
                if (InternalScript.PreConfig != null)
                    InternalScript.PreConfig();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.OnPreConfig!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnPostConfig(Boolean inLobby)
        {
            try
            {
                if (InternalScript.PostConfig != null)
                    InternalScript.PostConfig();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.OnPostConfig!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnPreMain()
        {
            try
            {
                if (InternalScript.PreMain != null)
                    InternalScript.PreMain();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.OnPreMain!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnPostMain()
        {
            try
            {
                if (InternalScript.PostMain != null)
                    InternalScript.PostMain();
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.OnPostMain!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnScriptLoad(String script)
        {
            try
            {
                if (InternalScript.ScriptLoad != null)
                    InternalScript.ScriptLoad(script);
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.OnScriptLoad!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnRunCodeCallback(VirtualMachinePtr virtualMachine, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5, CodeResult result)
        {
            try
            {
                if (InternalScript.VirtualMachine__RunCodeCallback != null)
                    InternalScript.VirtualMachine__RunCodeCallback(virtualMachine, opCode, a3, opLimit, a5, result);
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.OnRunCodeCallback!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static JassPtr Jass__ConstructorHook(JassPtr @this)
        {
            var result = InternalScript.Jass__Constructor(@this);

            try
            {
                InternalScript.jass = result;
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.Jass__ConstructorHook!");
                Trace.WriteLine(e.ToString());
            }

            return result;
        }

        unsafe private static IntPtr VirtualMachine__RunFunctionHook(VirtualMachinePtr virtualMachine, String functionName, Int32 a3, Int32 a4, Int32 a5, Int32 a6)
        {
            var result = IntPtr.Zero;

            try
            {
                switch (functionName)
                {
                    case "config":
                        var file = Storm.FileOpenFileEx(IntPtr.Zero, "war3map.cs", 0);
                        if (file != IntPtr.Zero)
                        {
                            var script = Storm.FileReadToEnd(file);
                            Storm.FileCloseFile(file);
                            InternalScript.OnScriptLoad(script);
                        }
                        else
                        {
                            InternalScript.OnScriptLoad(null);
                        }
                        InternalScript.OnPreConfig(InternalGame.IsInMap);
                        result = InternalScript.VirtualMachine__RunFunction(virtualMachine, functionName, a3, a4, a5, a6);
                        InternalScript.OnPostConfig(InternalGame.IsInMap);
                        break;

                    case "main":
                        InternalScript.OnPreMain();
                        result = InternalScript.VirtualMachine__RunFunction(virtualMachine, functionName, a3, a4, a5, a6);
                        InternalScript.OnPostMain();
                        break;

                    default:
                        result = InternalScript.VirtualMachine__RunFunction(virtualMachine, functionName, a3, a4, a5, a6);
                        break;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.VirtualMachine__RunFunctionHook!");
                Trace.WriteLine(e.ToString());
            }

            return result;
        }

        unsafe private static CodeResult VirtualMachine__RunCodeHook(VirtualMachinePtr virtualMachine, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5)
        {
            var result = VirtualMachine__RunCode(virtualMachine, opCode, a3, opLimit, a5);

            try
            {
                InternalScript.OnRunCodeCallback(virtualMachine, opCode, a3, opLimit, a5, result);
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalScript.VirtualMachine__RunFunctionHook!");
                Trace.WriteLine(e.ToString());
            }

            return result;
        }
    }

    public delegate void JassAPIScriptLoadEventHandler(String script);

    public delegate void VirtualMachine__RunCodeCallbackDelegate(VirtualMachinePtr virtualMachine, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5, CodeResult result);
}
