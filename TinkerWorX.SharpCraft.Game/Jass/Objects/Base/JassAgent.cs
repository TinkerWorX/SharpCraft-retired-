using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hagent;")]
    public partial struct JassAgent
    {
        public readonly IntPtr Handle;
        
        public JassAgent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
