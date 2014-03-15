using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Blizzard.Types;
using TinkerWorX.Utilities;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    unsafe public static class GameFunctions
    {
        public static Boolean IsReady { get; private set; }

        public static event Action Ready;

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(GameFunctions).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(GameFunctions).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            GameFunctions.CUnit__GetAbility = Utility.PtrAsFunction<CUnit__GetAbilityPrototype>(GameAddresses.CUnit__GetAbility);
            GameFunctions.GetAbilDataCacheNodeFromId = Utility.PtrAsFunction<GetAbilityFromIdPrototype>(GameAddresses.GetAbilDataCacheNodeFromId);
            GameFunctions.CGameUI__Constructor = Utility.PtrAsFunction<CGameUI__ConstructorPrototype>(GameAddresses.CGameUI__Constructor);
            GameFunctions.CGameUI__DisplayChatMessage = Utility.PtrAsFunction<CGameUI__DisplayChatMessagePrototype>(GameAddresses.CGameUI__DisplayChatMessage);
            GameFunctions.Unknown__UpdateMouse = Utility.PtrAsFunction<Unknown__UpdateMousePrototype>(GameAddresses.Unknown__UpdateMouse);
            GameFunctions.Unknown__SetState = Utility.PtrAsFunction<Unknown__SetStatePrototype>(GameAddresses.Unknown__SetState);
            GameFunctions.GetUnitFromHandle = Utility.PtrAsFunction<GetUnitFromHandlePrototype>(GameAddresses.GetUnitFromHandle);
            GameFunctions.GetTriggerFromHandle = Utility.PtrAsFunction<GetTriggerFromHandlePrototype>(GameAddresses.GetTriggerFromHandle);
            GameFunctions.GetDestructableFromHandle = Utility.PtrAsFunction<GetDestructableFromHandlePrototype>(GameAddresses.GetDestructableFromHandle);
            GameFunctions.GetItemFromHandle = Utility.PtrAsFunction<GetItemFromHandlePrototype>(GameAddresses.GetItemFromHandle);
            GameFunctions.StringToJassStringIndexInternal = Utility.PtrAsFunction<StringToJassStringIndexPrototype>(GameAddresses.StringToJassStringIndex);
            GameFunctions.CTriggerWar3__Execute = Utility.PtrAsFunction<CTriggerWar3__ExecutePrototype>(GameAddresses.CTriggerWar3__Execute);
            GameFunctions.JassStringManager__Resize = Utility.PtrAsFunction<JassStringManager__ResizePrototype>(GameAddresses.JassStringManager__Resize);
            GameFunctions.InitNatives = Utility.PtrAsFunction<InitNativesPrototype>(GameAddresses.InitNatives);
            GameFunctions.Jass__Constructor = Utility.PtrAsFunction<Jass__ConstructorPrototype>(GameAddresses.Jass__Constructor);
            GameFunctions.VirtualMachine__RunCode = Utility.PtrAsFunction<VirtualMachine__RunCodePrototype>(GameAddresses.VirtualMachine__RunCode);
            GameFunctions.VirtualMachine__RunFunction = Utility.PtrAsFunction<VirtualMachine__RunFunctionPrototype>(GameAddresses.VirtualMachine__RunFunction);
            GameFunctions.GetThreadLocalStorage = Utility.PtrAsFunction<GetThreadLocalStoragePrototype>(GameAddresses.GetThreadLocalStorage);
            GameFunctions.JassStringHandleToStringInternal = Utility.PtrAsFunction<JassStringHandleToStringPrototype>(GameAddresses.JassStringHandleToString);
            GameFunctions.sub_6F4786B0 = Utility.PtrAsFunction<sub_6F4786B0Prototype>(GameAddresses.sub_6F4786B0);
            GameFunctions.WndProc = Utility.PtrAsFunction<WndProcPrototype>(GameAddresses.WndProc);
            GameFunctions.CSimpleMessageFrame__WriteLine = Utility.PtrAsFunction<CSimpleMessageFrame__WriteLinePrototype>(GameAddresses.CSimpleMessageFrame__WriteLine);

            GameFunctions.IsReady = true;
            GameFunctions.OnReady();
        }

        private static void OnReady()
        {
            if (GameFunctions.Ready != null)
                GameFunctions.Ready();
        }

        /// <summary>
        /// Fetches a certain ability from a unit.
        /// </summary>
        /// <param name="unit">The unit.</param>
        /// <param name="ability">The ability id.</param>
        /// <param name="a3">Unknown</param>
        /// <param name="a4">Unknown</param>
        /// <param name="a5">Unknown</param>
        /// <param name="a6">Unknown</param>
        /// <returns>The ability.</returns>
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate CAbilityPtr CUnit__GetAbilityPrototype(CUnitPtr @this, ObjectIdL ability, Boolean a3, Boolean a4, Boolean a5, Boolean a6);
        public static CUnit__GetAbilityPrototype CUnit__GetAbility;

        // int __fastcall sub_6F265ED0(int a1)
        // We use __thiscall as a cheat for doing a fastcall with only one argument.
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate AbilDataCacheNodePtr GetAbilityFromIdPrototype(ObjectIdL id);
        public static GetAbilityFromIdPrototype GetAbilDataCacheNodeFromId;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr CGameUI__ConstructorPrototype(CGameUIPtr @this);
        public static CGameUI__ConstructorPrototype CGameUI__Constructor;

        /// <summary>
        /// Displays a chat message as sent by a player.
        /// </summary>
        /// <param name="this">The CGameUI instance.</param>
        /// <param name="sender">The player that send the message.</param>
        /// <param name="message">The message sent.</param>
        /// <param name="recipients">The team to receive the message.</param>
        /// <param name="duration">The duration the message should be shown.</param>
        /// <returns>Unknown</returns>
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr CGameUI__DisplayChatMessagePrototype(CGameUIPtr @this, Int32 sender, String message, ChatRecipients recipients, Single duration);
        public static CGameUI__DisplayChatMessagePrototype CGameUI__DisplayChatMessage;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate Boolean Unknown__UpdateMousePrototype(IntPtr @this, Single uiX, Single uiY, IntPtr terrainPtr, IntPtr a4);
        public static Unknown__UpdateMousePrototype Unknown__UpdateMouse;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate Int32 Unknown__SetStatePrototype(IntPtr _this, Boolean endMap, Boolean endEngine);
        public static Unknown__SetStatePrototype Unknown__SetState;

        /// <summary>
        /// Gets a unit from a unit jass handle.
        /// </summary>
        /// <param name="jassUnitHandle">The unit jass handle.</param>
        /// <returns>The unit.</returns>
        /// <remarks>We use __thiscall as a cheat for doing a fastcall with only one argument.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate CUnitPtr GetUnitFromHandlePrototype(IntPtr unitJassHandle);
        public static GetUnitFromHandlePrototype GetUnitFromHandle;

        /// <summary>
        /// Gets a trigger from a trigger jass handle.
        /// </summary>
        /// <param name="triggerHandle">The trigger jass handle.</param>
        /// <returns>The trigger.</returns>
        /// <remarks>We use __thiscall as a cheat for doing a fastcall with only one argument.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate CTriggerWar3Ptr GetTriggerFromHandlePrototype(JassTrigger triggerHandle);
        public static GetTriggerFromHandlePrototype GetTriggerFromHandle;

        /// <summary>
        /// Gets a destructable from a destructable jass handle.
        /// </summary>
        /// <param name="destructableJassHandle">The destructable jass handle.</param>
        /// <returns>The destructable.</returns>
        /// <remarks>We use __thiscall as a cheat for doing a fastcall with only one argument.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate CDestructablePtr GetDestructableFromHandlePrototype(IntPtr destructableJassHandle);
        public static GetDestructableFromHandlePrototype GetDestructableFromHandle;

        /// <summary>
        /// Gets a item from a item jass handle.
        /// </summary>
        /// <param name="itemJassHandle">The item jass handle.</param>
        /// <returns>The item.</returns>
        /// <remarks>We use __thiscall as a cheat for doing a fastcall with only one argument.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate CItemPtr GetItemFromHandlePrototype(IntPtr itemJassHandle);
        public static GetItemFromHandlePrototype GetItemFromHandle;

        /// <summary>
        /// Takes a pointer to a char* and returns a JassStringIndex.
        /// </summary>
        /// <param name="ansiStringPtr">The char* to convert.</param>
        /// <returns>The JassStringIndex</returns>
        /// <remarks>We use __thiscall as a cheat for doing a fastcall with only one argument.</remarks>
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate Int32 StringToJassStringIndexPrototype(IntPtr ansiStringPtr);
        private static StringToJassStringIndexPrototype StringToJassStringIndexInternal;

        public static Int32 StringToJassStringIndex(String s)
        {
            return GameFunctions.StringToJassStringIndexInternal(Marshal.StringToHGlobalAnsi(s));
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate void CTriggerWar3__ExecutePrototype(CTriggerWar3Ptr @this, IntPtr a2);
        public static CTriggerWar3__ExecutePrototype CTriggerWar3__Execute;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr JassStringManager__ResizePrototype(JassStringManager* @this, UInt32 newSize);
        public static JassStringManager__ResizePrototype JassStringManager__Resize;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate Int32 InitNativesPrototype();
        public static InitNativesPrototype InitNatives;

        /// <summary>
        /// This is an argumentless __stdcall. It's used in the BindNative __fastcall workaround.
        /// </summary>
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate void BindNativePrototype();
        public static void BindNative(IntPtr functionPtr, String name, String prototype)
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
                var codePtr = Memory.Alloc(code.Length, MemoryProtection.ExecuteReadWrite);

                writer.Write(Assembly.PushLV, prototype);
                writer.Write(Assembly.MoveEDX, name);
                writer.Write(Assembly.MoveECX, functionPtr);
                writer.Write(Assembly.Call, (UInt32)GameAddresses.BindNative - (UInt32)codePtr - (UInt32)writer.BaseStream.Position - 5u); // -5u is to get back to the start of the call instruction, 5 is the size of the instruction.
                writer.Write(Assembly.Return);

                Marshal.Copy(code, 0, codePtr, code.Length);
                var bindNative = Utility.PtrAsFunction<BindNativePrototype>(codePtr);
                bindNative();
                Memory.Free(codePtr);
            }
        }

        public static void BindNative(Delegate function, String name, String prototype)
        {
            GameFunctions.BindNative(Utility.FunctionAsPtr(function), name, prototype);
        }

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate JassPtr Jass__ConstructorPrototype(JassPtr jass);
        public static Jass__ConstructorPrototype Jass__Constructor;

        //int __thiscall sub_6F45E9D0(int this, int a2, int a3, int a4, int a5)
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate CodeResult VirtualMachine__RunCodePrototype(VirtualMachinePtr virtualMachine, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5);
        public static VirtualMachine__RunCodePrototype VirtualMachine__RunCode;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr VirtualMachine__RunFunctionPrototype(VirtualMachinePtr virtualMachine, String functionName, Int32 a3, Int32 a4, Int32 a5, Int32 a6);
        public static VirtualMachine__RunFunctionPrototype VirtualMachine__RunFunction;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate ThreadLocalStorage* GetThreadLocalStoragePrototype();
        public static GetThreadLocalStoragePrototype GetThreadLocalStorage;

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A cheat for __fastcall when there is only one argument.
        public delegate IntPtr JassStringHandleToStringPrototype(IntPtr stringJassHandle);
        private static JassStringHandleToStringPrototype JassStringHandleToStringInternal;

        public static String JassStringHandleToString(IntPtr stringJassHandle)
        {
            return Memory.PtrAsString(JassStringHandleToStringInternal(stringJassHandle));
        }

        // void* __fastcall sub_6F4786B0(void* a1)
        // We use __thiscall as a cheat for doing a fastcall with only one argument.
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        unsafe public delegate IntPtr sub_6F4786B0Prototype(Int32* a1);
        public static sub_6F4786B0Prototype sub_6F4786B0;

        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        public delegate IntPtr WndProcPrototype(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam);
        public static WndProcPrototype WndProc;

        /// <summary>
        /// Prints a message.
        /// </summary>
        /// <param name="_this">The CSimpleMessageFrame to print the message.</param>
        /// <param name="message">The message.</param>
        /// <param name="color">The base color.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="a5">Unknown</param>
        /// <returns>Unknown</returns>
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        public delegate IntPtr CSimpleMessageFrame__WriteLinePrototype(CSimpleMessageFramePtr @this, String message, ref Color color, Single duration, Int32 a5);
        public static CSimpleMessageFrame__WriteLinePrototype CSimpleMessageFrame__WriteLine;

        #region Utility Functions

        public static IntPtr JassStringIndexToJassStringHandle(Int32 jassStringIndex)
        {
            unsafe
            {
                return (IntPtr)((Int32)Marshal.ReadIntPtr(Marshal.ReadIntPtr(Marshal.ReadIntPtr(Marshal.ReadIntPtr(GameFunctions.GetThreadLocalStorage()->Jass.AsIntPtr(), 0x0C)), 0x2874), 0x0008) + 0x10 * jassStringIndex);
            }
            // the above code may be a bit confusing, but we're essentially doing the following, without needing to
            // find the function every patch, and avoid the convoluted class hierarchy.
            // return Jass->VirtualMachine->StringManager->Table[jassStringIndex];
            // sub_6F6B1CA0 in 1.21b
            // sub_6F459640 in 1.26.0.6401
            // TODO: Future proof this.
        }

        #endregion Utility Functions
    }
}
