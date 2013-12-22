using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hsoundtype;")]
    public partial struct JassSoundType
    {
        public readonly IntPtr Handle;
        
        public JassSoundType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
