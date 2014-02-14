using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hdefeatcondition;")]
    [Serializable]
    public partial struct JassDefeatCondition
    {
        public readonly IntPtr Handle;
        
        public JassDefeatCondition(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
