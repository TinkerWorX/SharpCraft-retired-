using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;
using TinkerWorX.Utilities;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static class Input
    {
        private static GameFunctions.WndProcPrototype WndProc;

        private static GameFunctions.Unknown__UpdateMousePrototype Unknown__UpdateMouse;

        private static GameFunctions.CGameUI__DisplayChatMessagePrototype CGameUI__DisplayChatMessage;

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
                throw new Exception("Attempted to initialize " + typeof(Input).Name + " before 'game.dll' has been loaded.");

            if (!GameAddresses.IsReady)
                throw new Exception("Attempted to initialize " + typeof(Input).Name + " before " + typeof(GameAddresses).Name + " was ready.");

            var address = IntPtr.Zero;
            
            address = GameAddresses.WndProc;
            Trace.Write("WndProc: 0x" + address.ToString("X8") + " . ");
            Input.WndProc = Memory.InstallHook(address, new GameFunctions.WndProcPrototype(Input.WndProcHook), true, false);
            Trace.WriteLine("hook installed!");

            address = GameAddresses.Unknown__UpdateMouse;
            Trace.Write("Unknown__UpdateMouse: 0x" + address.ToString("X8") + " . ");
            Input.Unknown__UpdateMouse = Memory.InstallHook(address, new GameFunctions.Unknown__UpdateMousePrototype(Input.Unknown__UpdateMouseHook), true, false);
            Trace.WriteLine("hook installed!");

            address = GameAddresses.CGameUI__DisplayChatMessage;
            Trace.Write("CGameUI__DisplayChatMessage: 0x" + address.ToString("X8") + " . ");
            Input.CGameUI__DisplayChatMessage = Memory.InstallHook(address, new GameFunctions.CGameUI__DisplayChatMessagePrototype(Input.CGameUI__DisplayChatMessageHook), true, false);
            Trace.WriteLine("hook installed!");
        }

        private static void OnMouseButton(MouseButton button, MouseButtonState state, Point2 point)
        {
            if (MouseClick != null)
                MouseClick(button, state, point);
        }

        private static void OnMouseWheel(Int32 delta)
        {
            if (MouseWheel != null)
                MouseWheel(delta);
        }

        private static void OnKeyboardKey(Int32 key, Char keyChar, KeyboardKeyState state)
        {
            if (KeyboardKey != null)
                KeyboardKey(key, keyChar, state);
        }

        private static void OnPlayerChat(Int32 sender, String message, ChatRecipients recipients)
        {
            if (Input.PlayerChat != null)
                Input.PlayerChat(sender, message, recipients);
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
            switch ((WindowsMessage)msg)
            {
                case WindowsMessage.KeyDown:
                    // only proceed if the 30th bit of lParam is 0 because that means the key wasn't down until now
                    if ((((lParam >> 30) & 1) == 0))
                    {
                        Input.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Down);
                    }
                    break;
                case WindowsMessage.KeyUp:
                    Input.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Up);
                    break;
                case WindowsMessage.Char:
                    Input.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Char);
                    break;

                case WindowsMessage.MouseMove:
                    Input.MouseWindow = new Point2(LOWORD(lParam), HIWORD(lParam));
                    break;

                case WindowsMessage.LeftButtonDown:
                    Input.OnMouseButton(MouseButton.Left, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WindowsMessage.LeftButtonUp:
                    Input.OnMouseButton(MouseButton.Left, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WindowsMessage.LeftButtonDoubleClick:
                    // This doesn't appear to happen.
                    break;

                case WindowsMessage.RightButtonDown:
                    Input.OnMouseButton(MouseButton.Right, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WindowsMessage.RightButtonUp:
                    Input.OnMouseButton(MouseButton.Right, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WindowsMessage.RightButtonDoubleClick:
                    // This doesn't appear to happen.
                    break;

                case WindowsMessage.MiddleButtonDown:
                    Input.OnMouseButton(MouseButton.Middle, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WindowsMessage.MiddleButtonUp:
                    Input.OnMouseButton(MouseButton.Middle, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WindowsMessage.MiddleButtonDoubleClick:
                    // This doesn't appear to happen.
                    break;

                case WindowsMessage.ExtraButtonDown:
                    if (HIWORD(wParam) == 1)
                        Input.OnMouseButton(MouseButton.X1, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    if (HIWORD(wParam) == 2)
                        Input.OnMouseButton(MouseButton.X2, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WindowsMessage.ExtraButtonUp:
                    if (HIWORD(wParam) == 1)
                        Input.OnMouseButton(MouseButton.X1, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    if (HIWORD(wParam) == 2)
                        Input.OnMouseButton(MouseButton.X2, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WindowsMessage.ExtraButtonDoubleClick:
                    // This doesn't appear to happen.
                    break;

                case WindowsMessage.MouseWheel:
                    Input.OnMouseWheel(HIWORD(wParam));
                    break;

                default:
                    // The following are the only other messages detected.
                    // It's possible we can detect more if we hook war3.exe's wndproc.
                    // WM_SETCURSOR: 0x0020
                    // WM_GETICON:   0x007F
                    // WM_NCHITTEST: 0x0084
                    break;
            }

            return WndProc(hWnd, msg, wParam, lParam);
        }

        private static Boolean Unknown__UpdateMouseHook(IntPtr _this, Single uiX, Single uiY, IntPtr terrainPtr, IntPtr a4)
        {
            var result = Unknown__UpdateMouse(_this, uiX, uiY, terrainPtr, a4);

            Input.IsMouseOverUI = !result;
            Input.MouseUI = new Vector2(uiX, uiY);
            Input.MouseTerrain = Memory.Read<Vector3>(terrainPtr);

            return result;
        }

        private static IntPtr CGameUI__DisplayChatMessageHook(CGameUIPtr _this, Int32 sender, String message, ChatRecipients recipients, Single duration)
        {
            Input.OnPlayerChat(sender, message, recipients);

            if (Input.BlockChat)
                return IntPtr.Zero;

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
