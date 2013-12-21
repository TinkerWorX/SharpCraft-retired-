using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hracepreference;")]
    public partial struct JassRacePreference
    {
        public readonly IntPtr Handle;
        
        public JassRacePreference(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
