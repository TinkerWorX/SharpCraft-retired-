using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Blizzard.Storm
{
    public unsafe class SFile
    {
        [DllImport("storm.dll", EntryPoint = "#253")]
        public static extern bool CloseFile(IntPtr handle);

        [DllImport("storm.dll", EntryPoint = "#265")]
        public static extern int GetFileSize(IntPtr handle, out int fileSizeHigh);

        [DllImport("storm.dll", EntryPoint = "#268")]
        public static extern bool OpenFileEx(IntPtr handle, string filename, uint mode, out IntPtr result);

        [DllImport("storm.dll", EntryPoint = "#269")]
        public static extern int ReadFile(IntPtr handle, IntPtr buffer, int numberOfBytesToRead, out int numberOfBytesRead, int distanceToMoveHigh = 0);

        public static int GetFileSize(IntPtr handle)
        {
            int high;
            return GetFileSize(handle, out high);
        }

        public static long GetFileSizeLong(IntPtr handle)
        {
            int high;
            int low = GetFileSize(handle, out high);
            return unchecked(((long)high << 32 | (uint)low));
        }

        public static IntPtr OpenFileEx(IntPtr handle, string filename, uint mode)
        {
            IntPtr result;
            if (OpenFileEx(handle, filename, mode, out result))
                return result;
            return IntPtr.Zero;
        }

        public static byte[] ReadFileToEnd(IntPtr handle)
        {
            int read;
            int size = GetFileSize(handle);
            var buffer = Marshal.AllocHGlobal(size);
            ReadFile(handle, buffer, size, out read);
            var output = new byte[size];
            Marshal.Copy(buffer, output, 0, size);
            Marshal.FreeHGlobal(buffer);
            return output;
        }

        private SFile() { }
    }
}
