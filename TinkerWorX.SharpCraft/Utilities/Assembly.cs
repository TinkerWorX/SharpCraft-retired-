using System;
using System.IO;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Utilities
{
    public class AssemblyWriter : IDisposable
    {
        public Stream BaseStream { get; private set; }

        private readonly BinaryWriter writer;

        public AssemblyWriter(Stream stream)
        {
            this.BaseStream = stream;
            this.writer = new BinaryWriter(this.BaseStream);
        }

        public void Dispose()
        {
            this.writer.Close();
        }

        public void Write(Assembly instruction)
        {
            this.writer.Write((Byte)instruction);
        }

        public void Write(Assembly instruction, UInt32 value)
        {
            this.writer.Write((Byte)instruction);
            this.writer.Write(value);
        }

        public void Write(Assembly instruction, Int32 value)
        {
            this.writer.Write((Byte)instruction);
            this.writer.Write(value);
        }

        public void Write(Assembly instruction, IntPtr value)
        {
            this.Write(instruction, (UInt32)value);
        }

        public void Write(Assembly instruction, String value)
        {
            this.Write(instruction, Marshal.StringToHGlobalAnsi(value));
        }
    }

    // http://sparksandflames.com/files/x86InstructionChart.html
    public enum Assembly : byte
    {
        PushEAX = 0x50,
        PushECX = 0x51,
        PushEDX = 0x52,
        PushEBX = 0x53,
        PushESP = 0x54,
        PushEBP = 0x55,
        PushESI = 0x56,
        PushEDI = 0x57,

        PopEAX = 0x58,
        PopECX = 0x59,
        PopEDX = 0x5A,
        PopEBX = 0x5B,
        PopESP = 0x5C,
        PopEBP = 0x5D,
        PopESI = 0x5E,
        PopEDI = 0x5F,

        PushLV = 0x68,

        PushLB = 0x6A,

        MoveECX = 0xB9,
        MoveEDX = 0xBA,

        Return = 0xC3,
        
        Call = 0xE8
    }
}
