using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hfogmodifier;")]
    public partial struct JassFogModifier
    {
        public readonly IntPtr Handle;
        
        public JassFogModifier(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
