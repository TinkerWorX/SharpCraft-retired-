using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hplayercolor;")]
    [Serializable]
    public partial struct JassPlayerColor
    {
        public readonly IntPtr Handle;
        
        public JassPlayerColor(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
