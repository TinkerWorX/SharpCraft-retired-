using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;
using System.Linq;
using System.Reflection.Emit;
using System.Runtime.InteropServices;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using Mono.CSharp;
using TinkerWorX.SharpCraft.Blizzard.GameModule;
using TinkerWorX.Utilities;

namespace TinkerWorX.SharpCraft
{
    public partial class DebuggerWindow : Window
    {
        private ConcurrentBagListener listener = new ConcurrentBagListener();

        private Evaluator evaluator;

        public DebuggerWindow(String context, String hackPath)
        {
            this.InitializeComponent();

            Trace.Listeners.Add(this.listener);

            var compilerSettings = new CompilerSettings
            {
                Unsafe = true,
            };
            compilerSettings.AssemblyReferences.Add("System.dll");
            compilerSettings.AssemblyReferences.Add("System.Core.dll");
            compilerSettings.AssemblyReferences.Add(typeof(MessageBox).Assembly.CodeBase); // PresentationFramework.dll
            compilerSettings.AssemblyReferences.Add(Path.Combine(hackPath, "Windows.dll"));
            compilerSettings.AssemblyReferences.Add(Path.Combine(hackPath, "Utilities.dll"));
            compilerSettings.AssemblyReferences.Add(Path.Combine(hackPath, "SharpCraft.dll"));

            var compilerContext = new CompilerContext(compilerSettings, new DebuggerReportPrinter());

            evaluator = new Evaluator(compilerContext);
            evaluator.Compile("using System;");
            evaluator.Compile("using TinkerWorX.Utilities;");
            evaluator.Compile("using TinkerWorX.Windows;");
            evaluator.Compile("using TinkerWorX.SharpCraft;");
            CompositionTarget.Rendering += CompositionTarget_Rendering;
        }

        private void CompositionTarget_Rendering(Object sender, EventArgs e)
        {
            String message;
            while (this.listener.Messages.TryTake(out message))
            {
                this.OutputTextBox.Text += message;
                this.OutputTextBox.ScrollToEnd();
            }
        }

        private void InputTextBox_PreviewKeyDown(Object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                e.Handled = true;
                Object result;
                Boolean result_set;
                this.OutputTextBox.Text += this.InputTextBox.Text + " - " + this.evaluator.Evaluate(this.InputTextBox.Text, out result, out result_set) + " -> ";
                if (result_set)
                    this.OutputTextBox.Text += result + Environment.NewLine;
                else
                    this.OutputTextBox.Text += "No result!" + Environment.NewLine;
                this.OutputTextBox.ScrollToEnd();
                this.InputTextBox.Clear();
            }
        }
    }

    internal class DebuggerReportPrinter : ReportPrinter
    {
        public override void Print(AbstractMessage msg, Boolean showFullPath)
        {
            if (msg.IsWarning)
                Trace.WriteLine("Warning: " + msg.Text);
            else
                Trace.WriteLine("Error: " + msg.Text);

            base.Print(msg, showFullPath);
        }
    }

    public static class StdCall
    {
        private static Dictionary<IntPtr, DynamicMethod> methods = new Dictionary<IntPtr, DynamicMethod>();

        public static TReturned Invoke<TReturned>(IntPtr address, params Object[] parameters) where TReturned : struct
        {
            DynamicMethod method;

            if (!methods.TryGetValue(address, out method))
            {
                var returnType = typeof(TReturned);
                var paramTypes = parameters.Select(o => o.GetType()).ToArray();

                method = new DynamicMethod("StdCall_Invoke_" + address.ToString("X8"), returnType, paramTypes, typeof(StdCall).Module);
                var il = method.GetILGenerator();
                for (var i = 0; i < parameters.Length; i += 1)
                {
                    il.Emit(OpCodes.Ldarg, i);
                }
                il.Emit(OpCodes.Ldc_I4, (Int32)address);
                il.Emit(OpCodes.Conv_I);
                il.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, paramTypes);
                il.Emit(OpCodes.Ret);

                methods.Add(address, method);
            }

            return (TReturned)method.Invoke(null, parameters);
        }
    }

    public static class Cdecl
    {
        private static Dictionary<IntPtr, DynamicMethod> methods = new Dictionary<IntPtr, DynamicMethod>();

        public static TReturned Invoke<TReturned>(IntPtr address, params Object[] parameters) where TReturned : struct
        {
            DynamicMethod method;

            if (!methods.TryGetValue(address, out method))
            {
                var returnType = typeof(TReturned);
                var paramTypes = parameters.Select(o => o.GetType()).ToArray();

                method = new DynamicMethod("Cdecl_Invoke_" + address.ToString("X8"), returnType, paramTypes, typeof(Cdecl).Module);
                var il = method.GetILGenerator();
                for (var i = 0; i < parameters.Length; i += 1)
                {
                    il.Emit(OpCodes.Ldarg, i);
                }
                il.Emit(OpCodes.Ldc_I4, (Int32)address);
                il.Emit(OpCodes.Conv_I);
                il.EmitCalli(OpCodes.Calli, CallingConvention.Cdecl, returnType, paramTypes);
                il.Emit(OpCodes.Ret);

                methods.Add(address, method);
            }

            return (TReturned)method.Invoke(null, parameters);
        }
    }

    public static class ThisCall
    {
        private static Dictionary<IntPtr, DynamicMethod> methods = new Dictionary<IntPtr, DynamicMethod>();

        public static TReturned Invoke<TReturned>(IntPtr address, params Object[] parameters) where TReturned : struct
        {
            DynamicMethod method;

            if (!methods.TryGetValue(address, out method))
            {
                var returnType = typeof(TReturned);
                var paramTypes = parameters.Select(o => o.GetType()).ToArray();

                method = new DynamicMethod("ThisCall_Invoke_" + address.ToString("X8"), returnType, paramTypes, typeof(ThisCall).Module);
                var il = method.GetILGenerator();
                for (var i = 0; i < parameters.Length; i += 1)
                {
                    il.Emit(OpCodes.Ldarg, i);
                }
                il.Emit(OpCodes.Ldc_I4, (Int32)address);
                il.Emit(OpCodes.Conv_I);
                il.EmitCalli(OpCodes.Calli, CallingConvention.ThisCall, returnType, paramTypes);
                il.Emit(OpCodes.Ret);

                methods.Add(address, method);
            }

            return (TReturned)method.Invoke(null, parameters);
        }
    }

    public static class FastCall
    {
        private static Byte[] InvokeFastCallCode = new Byte[]
            {
                0x5A,                           // pop edx
                0x36, 0x87, 0x54, 0x24, 0x08,   // xchg ss:[esp+08],edx
                0x58,                           // pop eax
                0x59,                           // pop ecx
                0xFF, 0xE0                      // jmp eax
            };

        private static GCHandle InvokeFastCallHandle;

        private static Dictionary<IntPtr, DynamicMethod> methods = new Dictionary<IntPtr, DynamicMethod>();

        static FastCall()
        {
            InvokeFastCallHandle = GCHandle.Alloc(InvokeFastCallCode, GCHandleType.Pinned);
            //Make the native method executable
            uint old;
            VirtualProtect(InvokeFastCallHandle.AddrOfPinnedObject(), (IntPtr)InvokeFastCallCode.Length, 0x40, out old);
        }

        public static TReturned Invoke<TReturned>(IntPtr address, params Object[] parameters) where TReturned : struct
        {
            parameters = PrependAddress(parameters, address);

            DynamicMethod method;

            if (!methods.TryGetValue(address, out method))
            {
                var returnType = typeof(TReturned);
                var paramTypes = parameters.Select(o => o.GetType()).ToArray();

                method = new DynamicMethod("FastCall_Invoke_" + address.ToString("X8"), returnType, paramTypes, typeof(FastCall).Module);
                var il = method.GetILGenerator();
                for (var i = 0; i < parameters.Length; i += 1)
                {
                    il.Emit(OpCodes.Ldarg, i);
                }
                il.Emit(OpCodes.Ldc_I4, (Int32)InvokeFastCallHandle.AddrOfPinnedObject());
                il.Emit(OpCodes.Conv_I);
                il.EmitCalli(OpCodes.Calli, CallingConvention.StdCall, returnType, paramTypes);
                il.Emit(OpCodes.Ret);

                methods.Add(address, method);
            }

            return (TReturned)method.Invoke(null, parameters);
        }

        private static Object[] PrependAddress(Object[] input, IntPtr address)
        {
            var newArray = new Object[input.Length + 1];
            newArray[0] = address;
            Array.Copy(input, 0, newArray, 1, input.Length);
            return newArray;
        }

        [DllImport("kernel32.dll", SetLastError = true)]
        static extern bool VirtualProtect(IntPtr address, IntPtr size, UInt32 protect, out UInt32 oldProtect);
    }
}
