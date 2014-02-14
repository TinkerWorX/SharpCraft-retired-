using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows.Forms;

namespace TinkerWorX.Windows
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

        [DllImport("user32.dll")]
        public static extern Boolean SetCursorPos(Int32 X, Int32 Y);
    }
}
