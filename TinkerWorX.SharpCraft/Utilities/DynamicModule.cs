using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

namespace TinkerWorX.SharpCraft.Utilities
{
    public class DynamicModule : DynamicObject
    {
        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr module, String procName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        static extern IntPtr GetProcAddress(IntPtr module, Int32 procOrdinal);

        [DllImport("kernel32.dll", CharSet = CharSet.Ansi, SetLastError = true)]
        public static extern IntPtr GetModuleHandle(String moduleName);

        [DllImport("kernel32", CharSet = CharSet.Ansi, SetLastError = true)]
        static extern IntPtr LoadLibrary(String fileName);

        public DynamicModule(String moduleName)
        {
            this.Module = GetModuleHandle(moduleName);
            if (this.Module == IntPtr.Zero)
                this.Module = LoadLibrary(moduleName);
            if (this.Module == IntPtr.Zero)
                throw new ArgumentException("Could not find the specified module", "module");
        }

        public DynamicModule(IntPtr module)
        {
            this.Module = module;
        }

        public IntPtr Module { private set; get; }

        public override Boolean TryGetMember(GetMemberBinder binder, out Object result)
        {
            Console.WriteLine("TryGetMember");
            if (binder.Name.StartsWith("Ordinal_"))
                result = GetProcAddress(this.Module, Int32.Parse(binder.Name.Replace("Ordinal_", "")));
            else if (binder.Name.StartsWith("Sub_"))
                result = this.Module + Convert.ToInt32(binder.Name.Replace("Sub_", ""), 16);
            else
                result = GetProcAddress(this.Module, binder.Name);
            if ((IntPtr)result != IntPtr.Zero)
                return true;
            return base.TryGetMember(binder, out result);
        }
    }
}
