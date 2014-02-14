using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hplayergameresult;")]
    [Serializable]
    public partial struct JassPlayerGameResult
    {
        public readonly IntPtr Handle;
        
        public JassPlayerGameResult(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
