using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TinkerWorX.SharpCraft.Core
{
    public delegate Int32 ProcessMessagesDelegate(Int32 code, Int32 wParam, ref Message lParam);

    public static class User32
    {
        [DllImport("user32.dll", SetLastError = true)]
        public static extern IntPtr SetWindowsHookEx(WindowsHookId windowsHookId, ProcessMessagesDelegate function, IntPtr mod, Int32 threadId);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern Int32 UnhookWindowsHookEx(IntPtr hook);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern Int32 CallNextHookEx(IntPtr hook, Int32 code, Int32 wParam, ref Message lParam);

        [DllImport("user32.dll", SetLastError = true)]
        public static extern Boolean TranslateMessage(ref Message message);
    }

    public enum WindowsHookId
    {
        MessageFilter = -1,
        JournalRecord = 0,
        JournalPlayback = 1,
        Keyboard = 2,
        GetMessage = 3,
        CallWindowsProc = 4,
        ComputerBasedTraining = 5,
        SystemMessageFilter = 6,
        Mouse = 7,
        Debug = 9,
        Shell = 10,
        ForegroundIdle = 11,
        CallWindowsProcReturn = 12,
        KeyboardLowLevel = 13,
        MouseLowLevel = 14,
    }

    public enum WindowsMessage
    {
        KeyDown = 0x100,
        KeyUp = 0x101,
        KeyChar = 0x102
    }
}
