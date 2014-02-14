using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hgamespeed;")]
    [Serializable]
    public partial struct JassGameSpeed
    {
        public readonly IntPtr Handle;
        
        public JassGameSpeed(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
