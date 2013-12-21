using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hdialogevent;")]
    public partial struct JassDialogEvent
    {
        public readonly IntPtr Handle;
        
        public JassDialogEvent(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
