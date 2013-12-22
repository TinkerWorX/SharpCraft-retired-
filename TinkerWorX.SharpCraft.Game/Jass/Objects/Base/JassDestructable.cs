using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hdestructable;")]
    [Serializable]
    public partial struct JassDestructable
    {
        public readonly IntPtr Handle;
        
        public JassDestructable(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
