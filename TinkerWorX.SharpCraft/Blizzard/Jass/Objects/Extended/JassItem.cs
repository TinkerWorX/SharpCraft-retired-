using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassItem
    {
        public static JassItem Create(JassObjectId itemid, Single x, Single y)
        {
            return SafeNatives.CreateItem(itemid, x, y);
        }

        public CItemPtr ToCItem()
        {
            return CItemPtr.FromHandle(this.Handle);
        }
    }
}
