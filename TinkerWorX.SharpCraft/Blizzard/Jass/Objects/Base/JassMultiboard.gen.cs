using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hmultiboard;")]
    [Serializable]
    public partial struct JassMultiboard
    {
        public readonly IntPtr Handle;
        
        public JassMultiboard(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
