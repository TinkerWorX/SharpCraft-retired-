using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hfogstate;")]
    [Serializable]
    public partial struct JassFogState
    {
        public readonly IntPtr Handle;
        
        public JassFogState(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
