using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using EasyHook;
using TinkerWorX.SharpCraft.Core;
using TinkerWorX.SharpCraft.Game.Core;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.SharpCraft.Game
{
    public delegate void JassPreConfigEventHandler();

    public delegate void JassPostConfigEventHandler();

    public delegate void JassPreMainEventHandler();

    public delegate void JassPostMainEventHandler();

    public class JassSystem
    {
        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]     // A normal __cdecl function.
        private delegate Int32 InitNativesPrototype();

        [UnmanagedFunctionPointer(CallingConvention.Cdecl)]     // An argumentless __cdecl, for use in the __fastcall workaround.
        private delegate void BindNativePrototype();

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A normal __thiscall function.
        private delegate IntPtr CJassConstructorPrototype(IntPtr cJass);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A normal __thiscall function.
        private delegate IntPtr CallFunctionPrototype(IntPtr _this, String functionName, Int32 a3, Int32 a4, Int32 a5, Int32 a6);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A cheat for __fastcall when there is only one argument.
        private delegate Int32 StringToJassStringIndexPrototype(IntPtr stringPtr);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A cheat for __fastcall when there is only one argument.
        private delegate IntPtr JassStringHandleToStringPrototype(IntPtr jassStringHandle);

        //int __thiscall sub_6F45E9D0(int this, int a2, int a3, int a4, int a5)
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate JassError sub_6F45E9D0Prototype(IntPtr cJass, IntPtr a2, IntPtr a3, UInt32 opLimit, IntPtr a5);

        private IntPtr cJassPtr;
        private IntPtr bindNativePtr;

        private InitNativesPrototype initNatives;
        private CJassConstructorPrototype cJassConstructor;
        private CallFunctionPrototype callFunction;
        private sub_6F45E9D0Prototype sub_6F45E9D0;
        private StringToJassStringIndexPrototype stringToJassStringIndex;
        private JassStringHandleToStringPrototype jassStringHandleToString;

        private LocalHook initNativesHook;
        private LocalHook cJassConstructorHook;
        private LocalHook callFunctionHook;
        private LocalHook sub_6F45E9D0Hook;

        private List<Native> vanillaNatives = new List<Native>();
        private List<Native> customNatives = new List<Native>();

        public event JassPreConfigEventHandler PreConfig;
        public event JassPostConfigEventHandler PostConfig;
        public event JassPreMainEventHandler PreMain;
        public event JassPostMainEventHandler PostMain;

        public JassSystem()
        {
            this.InstallInitNativesHook(WarcraftIII.Module + Settings.Current.Addresses.InitNatives);
            this.InstallCJassConstructorHook(WarcraftIII.Module + Settings.Current.Addresses.JassConstructor);
            this.Installsub_6F45E9D0Hook(WarcraftIII.Module + 0x0045E9D0);
            this.FetchStringToJassStringIndex(WarcraftIII.Module + Settings.Current.Addresses.StringToJassStringIndex);
            this.FetchJassStringHandleToString(WarcraftIII.Module + Settings.Current.Addresses.JassStringHandleToString);
            this.bindNativePtr = WarcraftIII.Module + Settings.Current.Addresses.BindNative;

            Trace.Write(" - - Scanning vanilla natives . ");
            var baseAddress = WarcraftIII.Module + Settings.Current.Addresses.InitNatives;
            var offset = 0x05;
            while (Marshal.ReadByte(baseAddress + offset) == 0x68)
            {
                this.vanillaNatives.Add(new Native(baseAddress + offset));
                offset += 0x14;
            }
            Trace.WriteLine("found " + this.vanillaNatives.Count + "!");
        }

        internal void OnPreConfig()
        {
            if (PreConfig != null)
                PreConfig();
        }

        internal void OnPostConfig()
        {
            if (PostConfig != null)
                PostConfig();
        }

        internal void OnPreMain()
        {
            if (PreMain != null)
                PreMain();
        }

        internal void OnPostMain()
        {
            if (PostMain != null)
                PostMain();
        }

        private void InstallInitNativesHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - InitNativesHook: 0x" + address.ToString("X8") + " . ");

                this.initNatives = (InitNativesPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(InitNativesPrototype));
                Trace.Write("fetched . ");

                this.initNativesHook = LocalHook.Create(address, new InitNativesPrototype(this.InitNativesHook), null);
                this.initNativesHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void InstallCJassConstructorHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - CJassConstructorHook: 0x" + address.ToString("X8") + " . ");

                this.cJassConstructor = (CJassConstructorPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(CJassConstructorPrototype));
                Trace.Write("fetched . ");

                this.cJassConstructorHook = LocalHook.Create(address, new CJassConstructorPrototype(this.CJassConstructorHook), null);
                this.cJassConstructorHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void InstallCallFunctionHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - CallFunctionHook: 0x" + address.ToString("X8") + " . ");

                this.callFunction = (CallFunctionPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(CallFunctionPrototype));
                Trace.Write("fetched . ");

                this.callFunctionHook = LocalHook.Create(address, new CallFunctionPrototype(this.CallFunctionHook), null);
                this.callFunctionHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void Installsub_6F45E9D0Hook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - sub_6F45E9D0Hook: 0x" + address.ToString("X8") + " . ");

                this.sub_6F45E9D0 = (sub_6F45E9D0Prototype)Marshal.GetDelegateForFunctionPointer(address, typeof(sub_6F45E9D0Prototype));
                Trace.Write("fetched . ");

                this.sub_6F45E9D0Hook = LocalHook.Create(address, new sub_6F45E9D0Prototype(this.Sub_6F45E9D0Prototype), null);
                this.sub_6F45E9D0Hook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private Int32 InitNatives()
        {
            return this.initNatives();
        }

        private IntPtr CJassConstructor(IntPtr cJass)
        {
            return this.cJassConstructor(cJass);
        }

        private void FetchStringToJassStringIndex(IntPtr address)
        {
            try
            {
                Trace.Write(" - - StringToJassStringIndex: 0x" + address.ToString("X8") + " . ");

                this.stringToJassStringIndex = (StringToJassStringIndexPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(StringToJassStringIndexPrototype));
                Trace.WriteLine("fetched!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void FetchJassStringHandleToString(IntPtr address)
        {
            try
            {
                Trace.Write(" - - JassStringHandleToString: 0x" + address.ToString("X8") + " . ");

                this.jassStringHandleToString = (JassStringHandleToStringPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(JassStringHandleToStringPrototype));
                Trace.WriteLine("fetched!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void BindNative(IntPtr functionPtr, String name, String prototype)
        {
            /* 
             * Manual implementation of a __cdecl function calling a __fastcall function.
             * 1. Allocate Executable memory.
             * 2. Write the function.
             * 3. Call the function.
             * 4. Release allocated memory.
             * TODO: Improve this to a more static function.

             * push, prototype string pointer
             * mov edx, name string pointer
             * mov ecx, function pointer
             * call, BindNative pointer; Remember to calculate the relative offset
             * retn
             */
            var code = new Byte[21];

            using (var writer = new AssemblyWriter(new MemoryStream(code)))
            {
                var codePtr = Kernel32.VirtualAlloc(IntPtr.Zero, code.Length, AllocationType.Commit, MemoryProtection.ExecuteReadWrite);

                writer.Write(Assembly.PushLV, prototype);
                writer.Write(Assembly.MoveEDX, name);
                writer.Write(Assembly.MoveECX, functionPtr);
                writer.Write(Assembly.Call, (UInt32)bindNativePtr - (UInt32)codePtr - (UInt32)writer.BaseStream.Position - 5u); // -5u is to get back to the start of the call instruction, 5 is the size of the instruction.
                writer.Write(Assembly.Return);

                Marshal.Copy(code, 0, codePtr, code.Length);
                var bindNative = (BindNativePrototype)Marshal.GetDelegateForFunctionPointer(codePtr, typeof(BindNativePrototype));
                bindNative();
                Kernel32.VirtualFree(codePtr, code.Length, MemoryFreeType.Release);
            }
        }

        private void BindNative(Delegate function, String name, String prototype)
        {
            BindNative(Marshal.GetFunctionPointerForDelegate(function), name, prototype);
        }

        private Int32 InitNativesHook()
        {
            var result = this.InitNatives();

            foreach (var native in this.customNatives)
            {
                this.BindNative(native.Function, native.Name, native.Prototype);
            }

            return result;
        }

        private IntPtr CJassConstructorHook(IntPtr cJass)
        {
            var result = this.CJassConstructor(cJass);

            this.cJassPtr = result;

            return result;
        }

        private IntPtr CallFunctionHook(IntPtr _this, String functionName, Int32 a3, Int32 a4, Int32 a5, Int32 a6)
        {
            var result = IntPtr.Zero;

            switch (functionName)
            {
                case "config":
                    this.OnPreConfig();
                    result = this.callFunction(_this, functionName, a3, a4, a5, a6);
                    this.OnPostConfig();
                    break;

                case "main":
                    this.OnPreMain();
                    result = this.callFunction(_this, functionName, a3, a4, a5, a6);
                    this.OnPostMain();
                    break;

                default:
                    result = this.callFunction(_this, functionName, a3, a4, a5, a6);
                    break;
            }

            return result;
        }

        private JassError Sub_6F45E9D0Prototype(IntPtr cJass, IntPtr a2, IntPtr a3, UInt32 opLimit, IntPtr a5)
        {
            var result = sub_6F45E9D0(cJass, a2, a3, opLimit, a5);

            if (Settings.Current.IsDebugging)
            {
                switch (result)
                {
                    case JassError.Success: break;
                    case JassError.OpLimit:
                        WarcraftIII.Interface.GameUI.ChatMessage.WriteLine("[System] |cffff0000Error|r: Op limit exceeded!", SColor.White, 10.00f);
                        break;
                    case JassError.VariableUninitialized:
                        WarcraftIII.Interface.GameUI.ChatMessage.WriteLine("[System] |cffff0000Error|r: Uninitialized variable read!", SColor.White, 10.00f);
                        break;
                    case JassError.DivideByZero:
                        WarcraftIII.Interface.GameUI.ChatMessage.WriteLine("[System] |cffff0000Error|r: Divide by zero!", SColor.White, 10.00f);
                        break;
                    default:
                        WarcraftIII.Interface.GameUI.ChatMessage.WriteLine("[System] |cffff0000Error|r: Unknown error: " + result, SColor.White, 10.00f);
                        break;
                }
            }

            return result;
        }


        internal Int32 StringToJassStringIndex(String str)
        {
            return stringToJassStringIndex(Marshal.StringToHGlobalAnsi(str));
        }

        internal String JassStringHandleToString(IntPtr jassStringHandle)
        {
            return Marshal.PtrToStringAnsi(jassStringHandleToString(jassStringHandle));
        }

        internal IntPtr JassStringIndexToJassStringHandle(Int32 jassStringIndex)
        {
            return (IntPtr)((Int32)Marshal.ReadIntPtr(Marshal.ReadIntPtr(Marshal.ReadIntPtr(Marshal.ReadIntPtr(this.cJassPtr, 0x0C)), 0x2874), 0x0008) + 0x10 * jassStringIndex);
            // the above code may be a bit confusing, but we're essentially doing the following, without needing to
            // find the function every patch, and avoid the convoluted class hierarchy.
            // return Jass->VirtualMachine->StringManager->Table[jassStringIndex];
            // TODO: Future proof this.
        }

        private void AddNative(Native native)
        {
            this.customNatives.Add(native);
        }

        public void AddNative(Delegate function, String name, String prototype)
        {
            AddNative(new Native(function, name, prototype));
        }

        public void AddNative(Delegate function, String name)
        {
            JassTypeAttribute attribute;

            var prototype = "(";
            foreach (var parameter in function.Method.GetParameters())
            {
                attribute = (JassTypeAttribute)parameter.ParameterType.GetCustomAttributes(typeof(JassTypeAttribute), true).Single();
                prototype += attribute.TypeString;
            }
            prototype += ")";

            if (function.Method.ReturnType == typeof(void))
            {
                prototype += "V";
            }
            else
            {
                attribute = (JassTypeAttribute)function.Method.ReturnType.GetCustomAttributes(typeof(JassTypeAttribute), true).Single();
                prototype += attribute.TypeString;
            }

            AddNative(function, name, prototype);
        }

        public void AddNative(Delegate function)
        {
            AddNative(function, function.Method.Name);
        }

        public Native GetNative(String name)
        {
            return this.vanillaNatives.FirstOrDefault(native => native.Name == name);
        }
    }

    public enum JassError : int
    {
        Success = 1,
        OpLimit = 2,
        VariableUninitialized = 6,
        DivideByZero = 7,
    }
}
