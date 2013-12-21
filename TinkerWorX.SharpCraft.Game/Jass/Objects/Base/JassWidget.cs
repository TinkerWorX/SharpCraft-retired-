using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hwidget;")]
    public partial struct JassWidget
    {
        public readonly IntPtr Handle;
        
        public JassWidget(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
