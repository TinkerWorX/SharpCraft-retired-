using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Heffect;")]
    public partial struct JassEffect
    {
        public readonly IntPtr Handle;
        
        public JassEffect(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
