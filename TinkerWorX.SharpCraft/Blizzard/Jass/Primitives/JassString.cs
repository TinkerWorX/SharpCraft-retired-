using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("S")]
    [Serializable]
    public struct JassStringRet
    {
        private readonly Int32 Index;

        public JassStringRet(Int32 index)
        {
            this.Index = index;
        }

        // Implicit conversion from JassStringRet to String
        public static implicit operator String(JassStringRet from)
        {
            return GameFunctions.JassStringHandleToString(GameFunctions.JassStringIndexToJassStringHandle(from.Index));
        }

        // Implicit conversion from String to JassStringRet
        public static implicit operator JassStringRet(String from)
        {
            return new JassStringRet(GameFunctions.StringToJassStringIndex(from));
        }

        public override String ToString()
        {
            return ((String)this).ToString();
        }

        public String ToString(IFormatProvider provider)
        {
            return ((String)this).ToString(provider);
        }
    }

    [JassType("S")]
    public struct JassStringArg
    {
        private readonly IntPtr Handle;

        public JassStringArg(IntPtr handle)
        {
            this.Handle = handle;
        }

        // Implicit conversion from JassStringArg to String
        public static implicit operator String(JassStringArg from)
        {
            return GameFunctions.JassStringHandleToString(from.Handle);
        }

        // Implicit conversion from String to JassStringArg
        public static implicit operator JassStringArg(String from)
        {
            return new JassStringArg(GameFunctions.JassStringIndexToJassStringHandle(GameFunctions.StringToJassStringIndex(from)));
        }

        public override String ToString()
        {
            return ((String)this).ToString();
        }

        public String ToString(IFormatProvider provider)
        {
            return ((String)this).ToString(provider);
        }
    }
}
