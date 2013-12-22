using System;

namespace TinkerWorX.SharpCraft.Game.Jass
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
