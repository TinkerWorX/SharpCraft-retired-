using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
