using System;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Game.Core;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hdestructable;")]
    public struct JassDestructable
    {
        private readonly IntPtr Handle;

        public JassDestructable(IntPtr handle)
        {
            this.Handle = handle;
        }

        public CDestructablePtr ToCDestructable()
        {
            return CDestructablePtr.FromHandle(this);
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
