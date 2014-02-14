using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    [JassType("Hwidget;")]
    [Serializable]
    public partial struct JassWidget
    {
        public readonly IntPtr Handle;
        
        public JassWidget(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
