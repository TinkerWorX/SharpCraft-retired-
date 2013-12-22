using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hbutton;")]
    [Serializable]
    public partial struct JassButton
    {
        public readonly IntPtr Handle;
        
        public JassButton(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
