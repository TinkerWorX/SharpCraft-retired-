using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassItem
    {
        public static JassItem Create(JassObjectId itemid, Single x, Single y)
        {
            return Natives.CreateItem(itemid, x, y);
        }

        public CItemPtr ToCItem()
        {
            return CItemPtr.FromHandle(this.Handle);
        }
    }
}
