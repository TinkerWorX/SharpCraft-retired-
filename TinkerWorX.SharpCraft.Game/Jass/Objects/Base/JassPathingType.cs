using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hpathingtype;")]
    public partial struct JassPathingType
    {
        public readonly IntPtr Handle;
        
        public JassPathingType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
