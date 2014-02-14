using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hforce;")]
    [Serializable]
    public partial struct JassForce
    {
        public readonly IntPtr Handle;
        
        public JassForce(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
