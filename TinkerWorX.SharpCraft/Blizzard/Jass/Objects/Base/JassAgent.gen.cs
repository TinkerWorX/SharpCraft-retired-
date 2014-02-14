using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hagent;")]
    [Serializable]
    public partial struct JassAgent
    {
        public readonly IntPtr Handle;
        
        public JassAgent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
