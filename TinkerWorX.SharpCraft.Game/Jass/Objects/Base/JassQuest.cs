using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hquest;")]
    public partial struct JassQuest
    {
        public readonly IntPtr Handle;
        
        public JassQuest(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
