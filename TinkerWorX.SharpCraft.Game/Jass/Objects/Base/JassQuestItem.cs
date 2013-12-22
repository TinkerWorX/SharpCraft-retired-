using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hquestitem;")]
    [Serializable]
    public partial struct JassQuestItem
    {
        public readonly IntPtr Handle;
        
        public JassQuestItem(IntPtr handle)
        {
            this.Handle = handle;
        }
    }
}
