using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Halliancetype;")]
    [Serializable]
    public partial struct JassAllianceType
    {
        public readonly IntPtr Handle;
        
        public JassAllianceType(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
