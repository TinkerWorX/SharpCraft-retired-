using System;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Game.Core;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hitem;")]
    public struct JassItem
    {
        private readonly IntPtr Handle;

        public JassItem(IntPtr handle)
        {
            this.Handle = handle;
        }

        public CItemPtr ToCItem()
        {
            return CItemPtr.FromHandle(this);
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
