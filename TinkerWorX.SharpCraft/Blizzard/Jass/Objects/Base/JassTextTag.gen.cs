using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Htexttag;")]
    [Serializable]
    public partial struct JassTextTag
    {
        public readonly IntPtr Handle;
        
        public JassTextTag(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
