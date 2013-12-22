using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hmultiboard;")]
    public partial struct JassMultiboard
    {
        public readonly IntPtr Handle;
        
        public JassMultiboard(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
