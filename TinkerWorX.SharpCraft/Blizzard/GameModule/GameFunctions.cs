using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Blizzard.Types;
using TinkerWorX.SharpCraft.Utilities;
using TinkerWorX.SharpCraft.Utilities.UnmanagedCalls;
using TinkerWorX.SharpCraft.Windows;

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

            GameFunctions.IsReady = true;
            GameFunctions.OnReady();
        }

        private static void OnReady()
        {
            if (GameFunctions.Ready != null)
                GameFunctions.Ready();
        }

        public static AbilDataCacheNodePtr GetAbilDataCacheNodeFromId(ObjectIdL id)
        {
            return FastCall.Invoke<AbilDataCacheNodePtr>(GameAddresses.GetAbilDataCacheNodeFromId, id);
        }

        public static IntPtr CGameUI__Constructor(CGameUI @this)
        {
            return ThisCall.Invoke<IntPtr>(GameAddresses.CGameUI__Constructor, @this);
        }

        /// <summary>
        /// Displays a chat message as sent by a player.
        /// </summary>
        /// <param name="this">The CGameUI instance.</param>
        /// <param name="sender">The player that send the message.</param>
        /// <param name="message">The message sent.</param>
        /// <param name="recipients">The team to receive the message.</param>
        /// <param name="duration">The duration the message should be shown.</param>
        /// <returns>Unknown</returns>
        public static IntPtr CGameUI__DisplayChatMessage(CGameUI @this, Int32 sender, String message, ChatRecipients recipients, Single duration)
        {
            return ThisCall.Invoke<IntPtr>(GameAddresses.CGameUI__DisplayChatMessage, @this, sender, message, recipients, duration);
        }

        // Constructor: 39A910 found using ".\CWorldFrameWar3.cpp", used three times in one function, initializer style function.
        // CWorldFrameWar3, size = 0x668
        public static Boolean Unknown__UpdateMouse(IntPtr @this, Single uiX, Single uiY, IntPtr terrainPtr, IntPtr a4)
        {
            return ThisCall.Invoke<Boolean>(GameAddresses.Unknown__UpdateMouse, @this, uiX, uiY, terrainPtr, a4);
        }

        // Constructor: 0074F0 found using "e:\\drive1\\temp\\buildwar3x\\war3\\source\\Data.h", 3rd result, constructor style function.
        // Data, size = 0x408
        public static Int32 Unknown__SetState(IntPtr @this, Boolean endMap, Boolean endEngine)
        {
            return ThisCall.Invoke<Int32>(GameAddresses.Unknown__SetState, @this, endMap, endEngine);
        }

        /// <summary>
        /// Gets a trigger from a trigger jass handle.
        /// </summary>
        /// <param name="destructableHandle">The trigger jass handle.</param>
        /// <returns>The trigger.</returns>
        public static CTriggerWar3Ptr GetTriggerFromHandle(IntPtr trigger)
        {
            return FastCall.Invoke<CTriggerWar3Ptr>(GameAddresses.GetTriggerFromHandle, trigger);
        }

        /// <summary>
        /// Gets a trigger from a trigger jass handle.
        /// </summary>
        /// <param name="destructableHandle">The trigger jass handle.</param>
        /// <returns>The trigger.</returns>
        public static CTriggerWar3Ptr GetTriggerFromHandle(JassTrigger trigger)
        {
            return FastCall.Invoke<CTriggerWar3Ptr>(GameAddresses.GetTriggerFromHandle, trigger);
        }

        /// <summary>
        /// Gets a destructable from a destructable jass handle.
        /// </summary>
        /// <param name="destructableJassHandle">The destructable jass handle.</param>
        /// <returns>The destructable.</returns>
        public static CDestructablePtr GetDestructableFromHandle(IntPtr destructable)
        {
            return FastCall.Invoke<CDestructablePtr>(GameAddresses.GetDestructableFromHandle, destructable);
        }

        /// <summary>
        /// Gets a destructable from a destructable jass handle.
        /// </summary>
        /// <param name="destructableJassHandle">The destructable jass handle.</param>
        /// <returns>The destructable.</returns>
        public static CDestructablePtr GetDestructableFromHandle(JassDestructable destructable)
        {
            return FastCall.Invoke<CDestructablePtr>(GameAddresses.GetDestructableFromHandle, destructable);
        }

        /// <summary>
        /// Gets a item from a item jass handle.
        /// </summary>
        /// <param name="itemJassHandle">The item jass handle.</param>
        /// <returns>The item.</returns>
        public static CItemPtr GetItemFromHandle(IntPtr item)
        {
            return FastCall.Invoke<CItemPtr>(GameAddresses.GetItemFromHandle, item);
        }

        /// <summary>
        /// Gets a item from a item jass handle.
        /// </summary>
        /// <param name="itemJassHandle">The item jass handle.</param>
        /// <returns>The item.</returns>
        public static CItemPtr GetItemFromHandle(JassItem item)
        {
            return FastCall.Invoke<CItemPtr>(GameAddresses.GetItemFromHandle, item);
        }

        /// <summary>
        /// Takes a pointer to a char* and returns a RCString reference.
        /// </summary>
        /// <param name="ansiStringPtr">The char* to convert.</param>
        /// <returns>The JassStringIndex</returns>
        public static Int32 StringToJassStringIndex(String str)
        {
            return FastCall.Invoke<Int32>(GameAddresses.StringToJassStringIndex, Memory.StringAsPtr(str));
        }

        public static void CTriggerWar3__ExecutePrototype(CTriggerWar3Ptr @this, IntPtr a2)
        {
            ThisCall.Invoke<IntPtr>(GameAddresses.CTriggerWar3__Execute, @this, a2);
        }

        public static IntPtr JassStringManager__ResizePrototype(JassStringManager* @this, UInt32 newSize)
        {
            return ThisCall.Invoke<IntPtr>(GameAddresses.JassStringManager__Resize, new IntPtr(@this), newSize);
        }

        public static IntPtr InitNatives()
        {
            return StdCall.Invoke<IntPtr>(GameAddresses.InitNatives);
        }

        public static void BindNative(IntPtr function, String name, String prototype)
        {
            FastCall.Invoke<IntPtr>(GameAddresses.BindNative, function, Memory.StringAsPtr(name), Memory.StringAsPtr(prototype));
        }

        public static void BindNative(Delegate function, String name, String prototype)
        {
            FastCall.Invoke<IntPtr>(GameAddresses.BindNative, Utility.FunctionAsPtr(function), Memory.StringAsPtr(name), Memory.StringAsPtr(prototype));
        }

        public static JassPtr Jass__Constructor(JassPtr @this)
        {
            return ThisCall.Invoke<JassPtr>(GameAddresses.Jass__Constructor, @this);
        }

        public static CodeResult VirtualMachine__RunCode(VirtualMachinePtr @this, IntPtr opCode, IntPtr a3, UInt32 opLimit, IntPtr a5)
        {
            return ThisCall.Invoke<CodeResult>(GameAddresses.VirtualMachine__RunCode, @this, opCode, a3, opLimit, a5);
        }

        public static IntPtr VirtualMachine__RunFunction(VirtualMachinePtr @this, String functionName, IntPtr a3, IntPtr a4, IntPtr a5, IntPtr a6)
        {
            return ThisCall.Invoke<IntPtr>(GameAddresses.VirtualMachine__RunFunction, @this, functionName, a3, a4, a5, a6);
        }

        public static ThreadLocalStorage GetThreadLocalStorage()
        {
            return StdCall.Invoke<ThreadLocalStorage>(GameAddresses.GetThreadLocalStorage);
        }

        public static String JassStringHandleToString(IntPtr jassStringHandle)
        {
            return Memory.PtrAsString(FastCall.Invoke<IntPtr>(GameAddresses.JassStringHandleToString, jassStringHandle));
        }

        public static IntPtr sub_6F4786B0(Int32* a1)
        {
            return FastCall.Invoke<IntPtr>(GameAddresses.sub_6F4786B0, new IntPtr(a1));
        }

        public static IntPtr WndProc(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam)
        {
            return StdCall.Invoke<IntPtr>(GameAddresses.WndProc, hWnd, msg, wParam, lParam);
        }

        /// <summary>
        /// Prints a message.
        /// </summary>
        /// <param name="_this">The CSimpleMessageFrame to print the message.</param>
        /// <param name="message">The message.</param>
        /// <param name="color">The base color.</param>
        /// <param name="duration">The duration.</param>
        /// <param name="a5">Unknown</param>
        /// <returns>Unknown</returns>
        public static IntPtr CSimpleMessageFrame__WriteLine(CSimpleMessageFramePtr @this, String message, ref Color color, Single duration, Int32 a5)
        {
            fixed (Color* colorPtr = &color)
                return ThisCall.Invoke<IntPtr>(GameAddresses.CSimpleMessageFrame__WriteLine, @this, message, new IntPtr(colorPtr), duration, a5);
        }

        #region Utility Functions

        public static IntPtr JassStringIndexToJassStringHandle(Int32 jassStringIndex)
        {
            unsafe
            {
                return (IntPtr)((Int32)Marshal.ReadIntPtr(Marshal.ReadIntPtr(Marshal.ReadIntPtr(Marshal.ReadIntPtr(GameFunctions.GetThreadLocalStorage().Jass.AsIntPtr(), 0x0C)), 0x2874), 0x0008) + 0x10 * jassStringIndex);
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
