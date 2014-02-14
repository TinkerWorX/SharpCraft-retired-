using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hrace;")]
    [Serializable]
    public partial struct JassRace
    {
        public readonly IntPtr Handle;
        
        public JassRace(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
