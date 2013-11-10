using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hracepreference;")]
    public struct JassRacePreference
    {
        private readonly IntPtr Handle;

        public JassRacePreference(IntPtr handle)
        {
            this.Handle = handle;
        }

        public override String ToString()
        {
            return this.Handle.ToString();
        }

        public String ToString(String format)
        {
            return this.Handle.ToString(format);
        }
    }
}
