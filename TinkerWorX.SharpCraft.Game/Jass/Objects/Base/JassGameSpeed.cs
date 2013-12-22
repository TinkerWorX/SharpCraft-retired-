using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hgamespeed;")]
    public partial struct JassGameSpeed
    {
        public readonly IntPtr Handle;
        
        public JassGameSpeed(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
