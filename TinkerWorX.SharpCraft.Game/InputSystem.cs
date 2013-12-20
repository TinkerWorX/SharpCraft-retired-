using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using EasyHook;
using TinkerWorX.SharpCraft.Core;

namespace TinkerWorX.SharpCraft.Game
{
    public delegate void MouseButtonEventHandler(MouseButton button, MouseButtonState state, Point2 point);

    public delegate void MouseWheelEventHandler(Int32 delta);

    public delegate void KeyboardKeyEventHandler(Int32 key, Char keyChar, KeyboardKeyState state);

    public class InputSystem
    {
        [UnmanagedFunctionPointer(CallingConvention.StdCall)]   //A normal __stdcall function.
        private delegate IntPtr WndProcDelegate(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]  // A normal __thiscall function.
        private delegate Boolean MouseDelegate(IntPtr _this, Single uiX, Single uiY, IntPtr terrainPtr, IntPtr a4);

        private WndProcDelegate wndProc;
        private MouseDelegate mouse;

        private LocalHook wndProcHook;
        private LocalHook mouseHook;

        private const UInt32 WM_KEYDOWN = 0x0100;
        private const UInt32 WM_KEYUP = 0x0101;
        private const UInt32 WM_CHAR = 0x0102;

        private const UInt32 WM_MOUSEMOVE = 0x0200;

        private const UInt32 WM_LBUTTONDOWN = 0x0201;
        private const UInt32 WM_LBUTTONUP = 0x0202;
        private const UInt32 WM_LBUTTONDBLCLK = 0x0203;

        private const UInt32 WM_RBUTTONDOWN = 0x0204;
        private const UInt32 WM_RBUTTONUP = 0x0205;
        private const UInt32 WM_RBUTTONDBLCLK = 0x0206;

        private const UInt32 WM_MBUTTONDOWN = 0x0207;
        private const UInt32 WM_MBUTTONUP = 0x0208;
        private const UInt32 WM_MBUTTONDBLCLK = 0x0209;

        private const UInt32 WM_MOUSEHWHEEL = 0x020A;

        private const UInt32 WM_XBUTTONDOWN = 0x020B;
        private const UInt32 WM_XBUTTONUP = 0x020C;
        private const UInt32 WM_XBUTTONDBLCLK = 0x020D;

        public event MouseButtonEventHandler MouseButton;

        public event MouseWheelEventHandler MouseWheel;

        public event KeyboardKeyEventHandler KeyboardKey;

        public InputSystem()
        {
            this.InstallMouseHook(WarcraftIII.Module + Settings.Current.Addresses.Mouse);
            this.InstallWndProcHook(WarcraftIII.Module + Settings.Current.Addresses.WndProc);
        }

        public Point2 MouseWindow { get; private set; }

        public Boolean IsMouseOverUI { get; private set; }

        public Vector2 MouseUI { get; private set; }

        public Vector3 MouseTerrain { get; private set; }

        internal void OnMouseButton(MouseButton button, MouseButtonState state, Point2 point)
        {
            if (MouseButton != null)
                MouseButton(button, state, point);
        }

        internal void OnMouseWheel(Int32 delta)
        {
            if (MouseWheel != null)
                MouseWheel(delta);
        }

        internal void OnKeyboardKey(Int32 key, Char keyChar, KeyboardKeyState state)
        {
            if (KeyboardKey != null)
                KeyboardKey(key, keyChar, state);
        }

        private Int16 LOWORD(UInt32 dword)
        {
            return (Int16)(dword & 0xFFFF);
        }

        private Int16 HIWORD(UInt32 dword)
        {
            return (Int16)((dword >> 16) & 0xFFFF);
        }

        private void InstallMouseHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - Mouse: 0x" + address.ToString("X8") + " . ");

                this.mouse = (MouseDelegate)Marshal.GetDelegateForFunctionPointer(address, typeof(MouseDelegate));
                Trace.Write("fetched . ");

                this.mouseHook = LocalHook.Create(address, new MouseDelegate(this.MouseHook), null);
                this.mouseHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private void InstallWndProcHook(IntPtr address)
        {
            try
            {
                Trace.Write(" - - WndProc: 0x" + address.ToString("X8") + " . ");

                this.wndProc = (WndProcDelegate)Marshal.GetDelegateForFunctionPointer(address, typeof(WndProcDelegate));
                Trace.Write("fetched . ");

                this.wndProcHook = LocalHook.Create(address, new WndProcDelegate(this.WndProcHook), null);
                this.wndProcHook.ThreadACL.SetExclusiveACL(new[] { 0 });
                Trace.WriteLine("installed!");
            }
            catch (Exception e)
            {
                Trace.WriteLine(e.Message);
            }
        }

        private IntPtr WndProcHook(IntPtr hWnd, UInt32 msg, UInt32 wParam, UInt32 lParam)
        {
            //Trace.WriteLine(String.Format("WndProcHook(..., msg:0x{0}, wParam:{1}, lParam:{2})", msg.ToString("X4"), wParam, lParam));

            switch (msg)
            {
                case WM_KEYDOWN:
                    // only proceed if the 30th bit of lParam is 0 because that means the key wasn't down until now
                    if ((((lParam >> 30) & 1) == 0))
                    {
                        this.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Down);
                        //Trace.WriteLine("WM_KEYDOWN: " + wParam);
                    }
                    break;
                case WM_KEYUP:
                    this.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Up);
                    //Trace.WriteLine("WM_KEYUP: " + wParam);
                    break;
                case WM_CHAR:
                    this.OnKeyboardKey((Int32)wParam, (Char)wParam, KeyboardKeyState.Char);
                    //Trace.WriteLine("WM_CHAR: " + (Char)wParam);
                    break;

                case WM_MOUSEMOVE:
                    this.MouseWindow = new Point2(LOWORD(lParam), HIWORD(lParam));
                    break;

                case WM_LBUTTONDOWN:
                    this.OnMouseButton(Game.MouseButton.Left, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    //Trace.WriteLine("WM_LBUTTONDOWN: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WM_LBUTTONUP:
                    this.OnMouseButton(Game.MouseButton.Left, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    //Trace.WriteLine("WM_LBUTTONUP: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WM_LBUTTONDBLCLK:
                    // This doesn't appear to happen.
                    //Trace.WriteLine("WM_LBUTTONDBLCLK: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;

                case WM_RBUTTONDOWN:
                    this.OnMouseButton(Game.MouseButton.Right, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    //Trace.WriteLine("WM_RBUTTONDOWN: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WM_RBUTTONUP:
                    this.OnMouseButton(Game.MouseButton.Right, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    //Trace.WriteLine("WM_RBUTTONUP: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WM_RBUTTONDBLCLK:
                    // This doesn't appear to happen.
                    //Trace.WriteLine("WM_RBUTTONDBLCLK: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;

                case WM_MBUTTONDOWN:
                    this.OnMouseButton(Game.MouseButton.Middle, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    //Trace.WriteLine("WM_MBUTTONDOWN: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WM_MBUTTONUP:
                    this.OnMouseButton(Game.MouseButton.Middle, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    //Trace.WriteLine("WM_MBUTTONUP: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WM_MBUTTONDBLCLK:
                    // This doesn't appear to happen.
                    //Trace.WriteLine("WM_MBUTTONDBLCLK: " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;

                case WM_XBUTTONDOWN:
                    if (HIWORD(wParam) == 1)
                        this.OnMouseButton(Game.MouseButton.X1, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    if (HIWORD(wParam) == 2)
                        this.OnMouseButton(Game.MouseButton.X2, MouseButtonState.Down, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    //Trace.WriteLine("WM_XBUTTONDOWN: " + HIWORD(wParam) + ": " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WM_XBUTTONUP:
                    if (HIWORD(wParam) == 1)
                        this.OnMouseButton(Game.MouseButton.X1, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    if (HIWORD(wParam) == 2)
                        this.OnMouseButton(Game.MouseButton.X2, MouseButtonState.Up, new Point2(LOWORD(lParam), HIWORD(lParam)));
                    //Trace.WriteLine("WM_XBUTTONUP: " + HIWORD(wParam) + ": " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;
                case WM_XBUTTONDBLCLK:
                    // This doesn't appear to happen.
                    //Trace.WriteLine("WM_XBUTTONDBLCLK: " + HIWORD(wParam) + ": " + String.Format("({0}; {1})", LOWORD(lParam), HIWORD(lParam)));
                    break;

                case WM_MOUSEHWHEEL:
                    this.OnMouseWheel(HIWORD(wParam));
                    //Trace.WriteLine("WM_MOUSEHWHEEL: " + HIWORD(wParam));
                    break;

                default:
                    // The following are the only other messages detected.
                    // WM_SETCURSOR: 0x0020
                    // WM_GETICON:   0x007F
                    // WM_NCHITTEST: 0x0084
                    // Trace.WriteLine(String.Format("WndProcHook(..., msg:0x{0}, wParam:{1}, lParam:{2})", msg.ToString("X4"), wParam, lParam));
                    break;
            }

            return wndProc(hWnd, msg, wParam, lParam);
        }

        private Boolean MouseHook(IntPtr _this, Single uiX, Single uiY, IntPtr terrainPtr, IntPtr a4)
        {
            var result = mouse(_this, uiX, uiY, terrainPtr, a4);

            this.IsMouseOverUI = !result;
            this.MouseUI = new Vector2(uiX, uiY);
            this.MouseTerrain = (Vector3)Marshal.PtrToStructure(terrainPtr, typeof(Vector3));

            return result;
        }
    }

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
