using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;
using TinkerWorX.SharpCraft.Utilities;
using TinkerWorX.SharpCraft.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static class InternalInput
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]
        private delegate IntPtr WndProcPrototype(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate Boolean Unknown__UpdateMousePrototype(IntPtr @this, Single uiX, Single uiY, IntPtr terrainPtr, IntPtr a4);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate IntPtr CGameUI__DisplayChatMessagePrototype(CGameUI @this, Int32 sender, String message, ChatRecipients recipients, Single duration);

        private static WndProcPrototype WndProc;

        private static Unknown__UpdateMousePrototype Unknown__UpdateMouse;

        private static CGameUI__DisplayChatMessagePrototype CGameUI__DisplayChatMessage;

        public static event MouseClickEventHandler MouseClick;

        public static event MouseWheelEventHandler MouseWheel;

        public static event KeyboardKeyEventHandler KeyboardKey;

        public static event PlayerChatEventHandler PlayerChat;

        public static Point2 MouseWindow { get; private set; }

        public static Boolean IsMouseOverUI { get; private set; }

        public static Vector2 MouseUI { get; private set; }

        public static Vector3 MouseTerrain { get; private set; }

        public static Boolean BlockChat { get; set; }

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(InternalInput).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(InternalInput).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;

            address = GameAddresses.WndProc;
            Trace.Write("WndProc: 0x" + address.ToString("X8") + " . ");
            InternalInput.WndProc = Memory.InstallHook(address, new WndProcPrototype(InternalInput.WndProcHook), true, false);
            Trace.WriteLine("hook installed!");

            address = GameAddresses.Unknown__UpdateMouse;
            Trace.Write("Unknown__UpdateMouse: 0x" + address.ToString("X8") + " . ");
            InternalInput.Unknown__UpdateMouse = Memory.InstallHook(address, new Unknown__UpdateMousePrototype(InternalInput.Unknown__UpdateMouseHook), true, false);
            Trace.WriteLine("hook installed!");

            address = GameAddresses.CGameUI__DisplayChatMessage;
            Trace.Write("CGameUI__DisplayChatMessage: 0x" + address.ToString("X8") + " . ");
            InternalInput.CGameUI__DisplayChatMessage = Memory.InstallHook(address, new CGameUI__DisplayChatMessagePrototype(InternalInput.CGameUI__DisplayChatMessageHook), true, false);
            Trace.WriteLine("hook installed!");
        }

        private static void OnMouseButton(MouseButton button, MouseButtonState state, Point2 point)
        {
            try
            {
                if (MouseClick != null)
                    MouseClick(button, state, point);
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalInput.OnPlayerChat!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnMouseWheel(Int32 delta)
        {
            try
            {
                if (MouseWheel != null)
                    MouseWheel(delta);
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalInput.OnPlayerChat!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnKeyboardKey(Int32 key, Char keyChar, KeyboardKeyState state)
        {
            try
            {
                if (KeyboardKey != null)
                    KeyboardKey(key, keyChar, state);
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalInput.OnPlayerChat!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static void OnPlayerChat(Int32 sender, String message, ChatRecipients recipients)
        {
            try
            {
                if (InternalInput.PlayerChat != null)
                    InternalInput.PlayerChat(sender, message, recipients);
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalInput.OnPlayerChat!");
                Trace.WriteLine(e.ToString());
            }
        }

        private static Int16 LOWORD(UInt32 dword)
        {
            return (Int16)(dword & 0xFFFF);
        }

        private static Int16 HIWORD(UInt32 dword)
        {
            return (Int16)((dword >> 16) & 0xFFFF);
        }

        private static IntPtr WndProcHook(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam)
        {
            try
            {
                switch ((WindowsMessage)msg)
                {
                    case WindowsMessage.KeyDown:
                        // only proceed if the 30th bit of lParam is 0 because that means the key wasn't down until now
                        if ((((lParam >> 30) & 1) == 0))
                        {
                            InternalInput.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Down);
                        }
                        break;
                    case WindowsMessage.KeyUp:
                        InternalInput.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Up);
                        break;
                    case WindowsMessage.Char:
                        InternalInput.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Char);
                        break;

                    case WindowsMessage.MouseMove:
                        InternalInput.MouseWindow = new Point2(LOWORD(lParam), HIWORD(lParam));
                        break;

                    case WindowsMessage.LeftButtonDown:
                        InternalInput.OnMouseButton(MouseButton.Left, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        break;
                    case WindowsMessage.LeftButtonUp:
                        InternalInput.OnMouseButton(MouseButton.Left, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        break;
                    case WindowsMessage.LeftButtonDoubleClick:
                        // This doesn't appear to happen.
                        break;

                    case WindowsMessage.RightButtonDown:
                        InternalInput.OnMouseButton(MouseButton.Right, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        break;
                    case WindowsMessage.RightButtonUp:
                        InternalInput.OnMouseButton(MouseButton.Right, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        break;
                    case WindowsMessage.RightButtonDoubleClick:
                        // This doesn't appear to happen.
                        break;

                    case WindowsMessage.MiddleButtonDown:
                        InternalInput.OnMouseButton(MouseButton.Middle, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        break;
                    case WindowsMessage.MiddleButtonUp:
                        InternalInput.OnMouseButton(MouseButton.Middle, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        break;
                    case WindowsMessage.MiddleButtonDoubleClick:
                        // This doesn't appear to happen.
                        break;

                    case WindowsMessage.ExtraButtonDown:
                        if (HIWORD(wParam) == 1)
                            InternalInput.OnMouseButton(MouseButton.X1, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        if (HIWORD(wParam) == 2)
                            InternalInput.OnMouseButton(MouseButton.X2, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        break;
                    case WindowsMessage.ExtraButtonUp:
                        if (HIWORD(wParam) == 1)
                            InternalInput.OnMouseButton(MouseButton.X1, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        if (HIWORD(wParam) == 2)
                            InternalInput.OnMouseButton(MouseButton.X2, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                        break;
                    case WindowsMessage.ExtraButtonDoubleClick:
                        // This doesn't appear to happen.
                        break;

                    case WindowsMessage.MouseWheel:
                        InternalInput.OnMouseWheel(HIWORD(wParam));
                        break;

                    default:
                        // The following are the only other messages detected.
                        // It's possible we can detect more if we hook war3.exe's wndproc.
                        // WM_SETCURSOR: 0x0020
                        // WM_GETICON:   0x007F
                        // WM_NCHITTEST: 0x0084
                        break;
                }
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalInput.WndProcHook!");
                Trace.WriteLine(e.ToString());
            }

            return WndProc(hWnd, msg, wParam, lParam);
        }

        private static Boolean Unknown__UpdateMouseHook(IntPtr @this, Single uiX, Single uiY, IntPtr terrainPtr, IntPtr a4)
        {
            Trace.WriteLine("Unknown__UpdateMouseHook @this[0]: " + Memory.Read<IntPtr>(@this).ToString("X8"));

            var result = Unknown__UpdateMouse(@this, uiX, uiY, terrainPtr, a4);

            try
            {
                InternalInput.IsMouseOverUI = !result;
                InternalInput.MouseUI = new Vector2(uiX, uiY);
                InternalInput.MouseTerrain = Memory.Read<Vector3>(terrainPtr);
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalInput.Unknown__UpdateMouseHook!");
                Trace.WriteLine(e.ToString());
            }

            return result;
        }

        private static IntPtr CGameUI__DisplayChatMessageHook(CGameUI _this, Int32 sender, String message, ChatRecipients recipients, Single duration)
        {
            try
            {
                InternalInput.OnPlayerChat(sender, message, recipients);

                if (InternalInput.BlockChat)
                    return IntPtr.Zero;
            }
            catch (Exception e)
            {
                Trace.WriteLine("Unhandled Exception in InternalInput.CGameUI__DisplayChatMessageHook!");
                Trace.WriteLine(e.ToString());
            }

            return CGameUI__DisplayChatMessage(_this, sender, message, recipients, duration);
        }
    }

    public delegate void MouseClickEventHandler(MouseButton button, MouseButtonState state, Point2 point);

    public delegate void MouseWheelEventHandler(Int32 delta);

    public delegate void KeyboardKeyEventHandler(Int32 key, Char keyChar, KeyboardKeyState state);

    public delegate void PlayerChatEventHandler(Int32 sender, String message, ChatRecipients recipients);

    public enum MouseButton
    {
        Left,
        Middle,
        Right,
        X1,
        X2
    }

    public enum MouseButtonState
    {
        Down,
        Up
    }

    public enum KeyboardKeyState
    {
        Down,
        Up,
        Char
    }
}
