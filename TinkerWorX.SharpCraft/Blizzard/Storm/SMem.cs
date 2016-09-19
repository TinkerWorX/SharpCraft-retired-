using System;
using System.Diagnostics;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.Storm
{
    public unsafe class SMem
    {
        private const string MODULE_NAME = "Storm.dll";

        private static IntPtr ModulePtr
        {
            get
            {
                var module = Kernel32.GetModuleHandle(MODULE_NAME);
                if (module == IntPtr.Zero)
                    module = Kernel32.LoadLibrary(MODULE_NAME);
                return module;
            }
        }

        public static IntPtr InitPtr => Kernel32.GetProcAddress(ModulePtr, new IntPtr(400));

        public static IntPtr AllocPtr => Kernel32.GetProcAddress(ModulePtr, new IntPtr(401));

        public static IntPtr DestroyPtr => Kernel32.GetProcAddress(ModulePtr, new IntPtr(402));

        public static IntPtr FreePtr => Kernel32.GetProcAddress(ModulePtr, new IntPtr(403));

        public static IntPtr GetSizePtr => Kernel32.GetProcAddress(ModulePtr, new IntPtr(404));

        public static IntPtr ReAllocPtr => Kernel32.GetProcAddress(ModulePtr, new IntPtr(405));


        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void InitPrototype();

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void* AllocPrototype([In] int amount, [In] char* filename, [In] int logline, [In] int defaultValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void DestroyPrototype();

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate bool FreePrototype([In] void* location, [In] char* filename, [In] int logline, [In] int defaultValue);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate int GetSizePrototype([In] void* location, [In] char* filename, [In] int logline);

        [UnmanagedFunctionPointer(CallingConvention.Winapi)]
        public delegate void* ReAllocPrototype([In] void* location, [In] int amount, [In] char* filename, [In] int logline, [In] int defaultValue);


        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#400")]
        public static extern void Init();


        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#401")]
        public static extern void* Alloc([In] int amount, [In] char* filename, [In] int logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#401")]
        public static extern void* Alloc([In] int amount, [In] string filename, [In] int logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#401")]
        public static extern void* Alloc([In] int amount, [In] char* filename, [In] LogLine logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#401")]
        public static extern void* Alloc([In] int amount, [In] string filename, [In] LogLine logline, [In] int defaultValue);

        public static void* Alloc(int amount, int defaultValue = 0)
        {
            var stackframe = new StackFrame(1, true);
            return Alloc(amount, stackframe.GetFileName(), stackframe.GetFileLineNumber(), defaultValue);
        }


        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#402")]
        public static extern void Destroy();


        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#403")]
        public static extern bool Free([In] void* location, [In] char* filename, [In] int logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#403")]
        public static extern bool Free([In] void* location, [In] string filename, [In] int logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#403")]
        public static extern bool Free([In] void* location, [In] char* filename, [In] LogLine logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#403")]
        public static extern bool Free([In] void* location, [In] string filename, [In] LogLine logline, [In] int defaultValue);

        public static bool Free(void* location, int defaultValue = 0)
        {
            var stackframe = new StackFrame(1, true);
            return Free(location, stackframe.GetFileName(), stackframe.GetFileLineNumber(), defaultValue);
        }


        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#404")]
        public static extern int GetSize([In] void* location, [In] char* filename, [In] int logline);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#404")]
        public static extern int GetSize([In] void* location, [In] string filename, [In] int logline);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#404")]
        public static extern int GetSize([In] void* location, [In] char* filename, [In] LogLine logline);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#404")]
        public static extern int GetSize([In] void* location, [In] string filename, [In] LogLine logline);

        public static int GetSize(void* location)
        {
            var stackframe = new StackFrame(1, true);
            return GetSize(location, stackframe.GetFileName(), stackframe.GetFileLineNumber());
        }


        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#405")]
        public static extern void* ReAlloc([In] void* location, [In] int amount, [In] char* filename, [In] int logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#405")]
        public static extern void* ReAlloc([In] void* location, [In] int amount, [In] string filename, [In] int logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#405")]
        public static extern void* ReAlloc([In] void* location, [In] int amount, [In] char* filename, [In] LogLine logline, [In] int defaultValue);

        [DllImport("storm.dll", CallingConvention = CallingConvention.Winapi, EntryPoint = "#405")]
        public static extern void* ReAlloc([In] void* location, [In] int amount, [In] string filename, [In] LogLine logline, [In] int defaultValue);

        public static void* ReAlloc(void* location, int amount, int defaultValue = 0)
        {
            var stackframe = new StackFrame(1, true);
            return ReAlloc(location, amount, stackframe.GetFileName(), stackframe.GetFileLineNumber(), defaultValue);
        }

        private SMem() { }
    }

    public enum LogLine : int
    {
        Expression = 0,
        Function = -1,
        Object = -2,
        Handle = -3,
        File = -4
    }
}
