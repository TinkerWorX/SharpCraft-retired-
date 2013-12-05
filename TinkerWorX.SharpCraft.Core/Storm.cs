using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Core
{
    public static class Storm
    {
        [DllImport("storm.dll", EntryPoint = "#265")]
        public static extern Int32 SFileGetFileSize(IntPtr handle, out Int32 fileSizeHigh);

        [DllImport("storm.dll", EntryPoint = "#265")]
        public static extern Int32 SFileGetFileSize(IntPtr handle, Int32 fileSizeHigh = 0);

        [DllImport("storm.dll", EntryPoint = "#268")]
        public static extern Boolean SFileOpenFileEx(IntPtr handle, String filename, Byte mode, out IntPtr result);

        [DllImport("storm.dll", EntryPoint = "#269")]
        public static extern Int32 SFileReadFile(IntPtr handle, IntPtr buffer, Int32 nNumberOfBytesToRead, out Int32 read, Int32 distanceToMoveHigh);

        [DllImport("storm.dll", EntryPoint = "#269")]
        public static extern Int32 SFileReadFile(IntPtr handle, IntPtr buffer, Int32 nNumberOfBytesToRead, Int32 read = 0, Int32 distanceToMoveHigh = 0);

        public static Int32 FileGetFileSize(IntPtr handle)
        {
            return SFileGetFileSize(handle, 0);
        }

        public static IntPtr FileOpenFileEx(IntPtr handle, String filename, Byte mode)
        {
            IntPtr result;
            if (SFileOpenFileEx(handle, filename, mode, out result))
                return result;
            return IntPtr.Zero;
        }

        public static String FileReadToEnd(IntPtr handle)
        {
            Int32 size = SFileGetFileSize(handle);
            var buffer = Marshal.AllocHGlobal(size);
            SFileReadFile(handle, buffer, size);
            return Marshal.PtrToStringAnsi(buffer);
        }
    }
}
