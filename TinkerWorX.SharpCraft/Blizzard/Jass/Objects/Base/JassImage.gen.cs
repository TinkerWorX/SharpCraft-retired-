using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Himage;")]
    [Serializable]
    public partial struct JassImage
    {
        public readonly IntPtr Handle;
        
        public JassImage(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
