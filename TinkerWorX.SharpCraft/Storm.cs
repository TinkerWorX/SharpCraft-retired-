using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    public static class Storm
    {
        [DllImport("storm.dll", EntryPoint = "#253")]
        public static extern Boolean SFileCloseFile(IntPtr handle);

        [DllImport("storm.dll", EntryPoint = "#265")]
        public static extern Int32 SFileGetFileSize(IntPtr handle, out Int32 fileSizeHigh);

        [DllImport("storm.dll", EntryPoint = "#265")]
        public static extern Int32 SFileGetFileSize(IntPtr handle, Int32 fileSizeHigh = 0);

        [DllImport("storm.dll", EntryPoint = "#268")]
        public static extern Boolean SFileOpenFileEx(IntPtr handle, String filename, UInt32 mode, out IntPtr result);

        [DllImport("storm.dll", EntryPoint = "#269")]
        public static extern Int32 SFileReadFile(IntPtr handle, IntPtr buffer, Int32 nNumberOfBytesToRead, out Int32 read, Int32 distanceToMoveHigh = 0);

        [DllImport("storm.dll", EntryPoint = "#269")]
        public static extern Int32 SFileReadFile(IntPtr handle, IntPtr buffer, Int32 nNumberOfBytesToRead, Int32 read = 0, Int32 distanceToMoveHigh = 0);

        [DllImport("storm.dll", EntryPoint = "#401")]
        public static extern IntPtr SMemAlloc(Int32 amount, String logfilename, Int32 logline, Int32 defaultValue);

        [DllImport("storm.dll", EntryPoint = "#403")]
        public static extern Boolean SMemFree(IntPtr location, String logfilename, Int32 logline, Int32 defaultValue);

        public static Boolean FileCloseFile(IntPtr handle)
        {
            return SFileCloseFile(handle);
        }

        public static Int32 FileGetFileSize(IntPtr handle)
        {
            return SFileGetFileSize(handle, 0);
        }

        public static IntPtr FileOpenFileEx(IntPtr handle, String filename, UInt32 mode)
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
            var output = new Byte[size];
            Marshal.Copy(buffer, output, 0, size);
            Marshal.FreeHGlobal(buffer);
            return Encoding.ASCII.GetString(output);
        }

        public static Byte[] FileReadAll(IntPtr handle)
        {
            Int32 size = SFileGetFileSize(handle);
            var buffer = Marshal.AllocHGlobal(size);
            SFileReadFile(handle, buffer, size);
            var output = new Byte[size];
            Marshal.Copy(buffer, output, 0, size);
            Marshal.FreeHGlobal(buffer);
            return output;
        }

        public static IntPtr MemoryAlloc(Int32 size)
        {
            var stackframe = new StackFrame(1, true);
            return Storm.SMemAlloc(size, stackframe.GetFileName(), stackframe.GetFileLineNumber(), 0);
        }

        public static IntPtr MemoryAlloc(Int32 size, Int32 defaultValue)
        {
            var stackframe = new StackFrame(1, true);
            return Storm.SMemAlloc(size, stackframe.GetFileName(), stackframe.GetFileLineNumber(), defaultValue);
        }

        public static void MemoryFree(IntPtr address)
        {
            var stackframe = new StackFrame(1, true);
            Storm.SMemFree(address, stackframe.GetFileName(), stackframe.GetFileLineNumber(), 0);
        }

        public static void MemoryFree(IntPtr address, Int32 defaultValue)
        {
            var stackframe = new StackFrame(1, true);
            Storm.SMemFree(address, stackframe.GetFileName(), stackframe.GetFileLineNumber(), defaultValue);
        }
    }
}
