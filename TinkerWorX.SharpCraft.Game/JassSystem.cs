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
        private delegate JassPtr Jass__ConstructorPrototype(JassPtr jass);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A normal __thiscall function.
        private delegate IntPtr VirtualMachine__RunFunctionPrototype(VirtualMachinePtr vm, String functionName, Int32 a3, Int32 a4, Int32 a5, Int32 a6);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A cheat for __fastcall when there is only one argument.
        private delegate Int32 StringToJassStringIndexPrototype(IntPtr unmanagedStringPtr);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A cheat for __fastcall when there is only one argument.
        private delegate IntPtr JassStringHandleToStringPrototype(IntPtr jassStringHandle);

        //int __thiscall sub_6F45E9D0(int this, int a2, int a3, int a4, int a5)
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate ECodeResult VirtualMachine__RunCodePrototype(VirtualMachinePtr vm, IntPtr opcode, IntPtr a3, UInt32 opLimit, IntPtr a5);

        private JassPtr jass;

        private InitNativesPrototype initNatives;
        private Jass__ConstructorPrototype Jass__Constructor;
        private VirtualMachine__RunFunctionPrototype VirtualMachine__RunFunction;
        private VirtualMachine__RunCodePrototype VirtualMachine__RunCode;
        private StringToJassStringIndexPrototype StringToJassStringIndex;
        private JassStringHandleToStringPrototype JassStringHandleToString;
        private IntPtr bindNativePtr;

        private LocalHook InitNativesLocalHook;
        private LocalHook Jass__ConstructorLocalHook;
        private LocalHook VirtualMachine__RunFunctionLocalHook;
        private LocalHook VirtualMachine__RunCodeLocalHook;

        private List<Native> vanillaNatives = new List<Native>();
        private List<Native> customNatives = new List<Native>();

        public event JassPreConfigEventHandler PreConfig;
        public event JassPostConfigEventHandler PostConfig;
        public event JassPreMainEventHandler PreMain;
        public event JassPostMainEventHandler PostMain;

        public INatives Natives { get; internal set; }

        public JassSystem()
        {
            this.InstallJass__ConstructorHook(WarcraftIII.Module + Settings.Current.Addresses.JassConstructor);
            this.InstallVirtualMachine__RunFunctionHook(WarcraftIII.Module + Settings.Current.Addresses.CallFunction);
            this.InstallVirtualMachine__RunCodeHook(WarcraftIII.Module + 0x0045E9D0);
            this.InstallInitNativesHook(WarcraftIII.Module + Settings.Current.Addresses.InitNatives);
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
                Trace.Write(" - - InitNatives: 0x" + address.ToString("X8") + " . ");

                this.initNatives = (InitNativesPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(InitNativesPrototype));
                Trace.Write("fetched . ");

                this.InitNativesLocalHook = LocalHook.Create(address, new InitNativesPrototype(this.InitNativesHook), null);
                this.InitNativesLocalHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void InstallJass__ConstructorHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - Jass__Constructor: 0x" + address.ToString("X8") + " . ");

                this.Jass__Constructor = (Jass__ConstructorPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(Jass__ConstructorPrototype));
                Trace.Write("fetched . ");

                this.Jass__ConstructorLocalHook = LocalHook.Create(address, new Jass__ConstructorPrototype(this.Jass__ConstructorHook), null);
                this.Jass__ConstructorLocalHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void InstallVirtualMachine__RunFunctionHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - VirtualMachine__RunFunction: 0x" + address.ToString("X8") + " . ");

                this.VirtualMachine__RunFunction = (VirtualMachine__RunFunctionPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(VirtualMachine__RunFunctionPrototype));
                Trace.Write("fetched . ");

                this.VirtualMachine__RunFunctionLocalHook = LocalHook.Create(address, new VirtualMachine__RunFunctionPrototype(this.VirtualMachine__RunFunctionHook), null);
                this.VirtualMachine__RunFunctionLocalHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void InstallVirtualMachine__RunCodeHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - VirtualMachine__RunCode: 0x" + address.ToString("X8") + " . ");

                this.VirtualMachine__RunCode = (VirtualMachine__RunCodePrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(VirtualMachine__RunCodePrototype));
                Trace.Write("fetched . ");

                this.VirtualMachine__RunCodeLocalHook = LocalHook.Create(address, new VirtualMachine__RunCodePrototype(this.VirtualMachine__RunCodeHook), null);
                this.VirtualMachine__RunCodeLocalHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
        }
            catch (Exception e)
        {
                Trace.WriteLine(e.Message);
            }
        }

        private void FetchStringToJassStringIndex(IntPtr address)
        {
            try
            {
                Trace.Write(" - - StringToJassStringIndex: 0x" + address.ToString("X8") + " . ");

                this.StringToJassStringIndex = (StringToJassStringIndexPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(StringToJassStringIndexPrototype));
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

                this.JassStringHandleToString = (JassStringHandleToStringPrototype)Marshal.GetDelegateForFunctionPointer(address, typeof(JassStringHandleToStringPrototype));
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
            var result = this.initNatives();

            foreach (var native in this.customNatives)
            {
                this.BindNative(native.Function, native.Name, native.Prototype);
            }

            return result;
        }

        private JassPtr Jass__ConstructorHook(JassPtr jass)
        {
            var result = this.Jass__Constructor(jass);

            this.jass = result;

            return result;
        }

        unsafe private IntPtr VirtualMachine__RunFunctionHook(VirtualMachinePtr vm, String functionName, Int32 a3, Int32 a4, Int32 a5, Int32 a6)
        {
            var result = IntPtr.Zero;

            switch (functionName)
            {
                case "config":
                    this.OnPreConfig();
                    // TODO: Load up internal war3map.cs file.
                    // var code = Storm.FileReadToEnd(Storm.FileOpenFileEx(IntPtr.Zero, "war3map.cs", 0x00));
                    result = this.callFunction(_this, functionName, a3, a4, a5, a6);
                    this.OnPostConfig();
                    break;

                case "main":
                    this.OnPreMain();
                    result = this.VirtualMachine__RunFunction(vm, functionName, a3, a4, a5, a6);
                    this.OnPostMain();
                    break;

                default:
                    result = this.VirtualMachine__RunFunction(vm, functionName, a3, a4, a5, a6);
                    break;
            }

            return result;
        }

        unsafe private ECodeResult VirtualMachine__RunCodeHook(VirtualMachinePtr vm, IntPtr opcode, IntPtr a3, UInt32 opLimit, IntPtr a5)
        {
            var result = VirtualMachine__RunCode(vm, opcode, a3, opLimit, a5);

            if (Settings.Current.IsDebugging)
            {
                unsafe
                {
                    // -8 is the start of the function declaration op.
                    // -4 is the function id.
                    // -0 is the first instruction in the function.
                    var functionId = WarcraftIII.Memory.Read<Int32>(opcode - 0x04);
                    var functionName = vm.AsUnsafe()->SymbolTable->StringPool->Nodes[functionId]->Value;
                    switch (result)
                    {
                        case ECodeResult.Success: break;
                        case ECodeResult.OpLimit:
                            WarcraftIII.Interface.GameUI.ChatMessage.WriteLine("[System] |cffff0000Error|r: Op limit exceeded in " + functionName, SColor.White, 10.00f);
                            break;
                        case ECodeResult.ThreadPaused: break;
                        case ECodeResult.VariableUninitialized:
                            WarcraftIII.Interface.GameUI.ChatMessage.WriteLine("[System] |cffff0000Error|r: Uninitialized variable read in " + functionName, SColor.White, 10.00f);
                            break;
                        case ECodeResult.DivideByZero:
                            WarcraftIII.Interface.GameUI.ChatMessage.WriteLine("[System] |cffff0000Error|r: Divide by zero in " + functionName, SColor.White, 10.00f);
                            break;
                default:
                            WarcraftIII.Interface.GameUI.ChatMessage.WriteLine("[System] |cffff0000Error|r: Unknown error(" + result + ") in " + functionName, SColor.White, 10.00f);
                    break;
            }
                }
            }

            return result;
        }

        internal Int32 StringToJassStringIndexWrapper(String unmanagedString)
        {
            return this.StringToJassStringIndex(Marshal.StringToHGlobalAnsi(unmanagedString));
        }

        internal String JassStringHandleToStringWrapper(IntPtr jassStringHandle)
        {
            return Marshal.PtrToStringAnsi(this.JassStringHandleToString(jassStringHandle));
        }

        internal IntPtr JassStringIndexToJassStringHandle(Int32 jassStringIndex)
        {
            return (IntPtr)((Int32)Marshal.ReadIntPtr(Marshal.ReadIntPtr(Marshal.ReadIntPtr(Marshal.ReadIntPtr(this.jass.AsIntPtr(), 0x0C)), 0x2874), 0x0008) + 0x10 * jassStringIndex);
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
}
