using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hpathingtype;")]
    [Serializable]
    public partial struct JassPathingType
    {
        public readonly IntPtr Handle;
        
        public JassPathingType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
