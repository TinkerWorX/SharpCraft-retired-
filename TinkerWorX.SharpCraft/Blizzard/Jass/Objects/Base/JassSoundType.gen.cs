using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hsoundtype;")]
    [Serializable]
    public partial struct JassSoundType
    {
        public readonly IntPtr Handle;
        
        public JassSoundType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
