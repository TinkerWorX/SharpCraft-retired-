using System;
using TinkerWorX.SharpCraft.Game.Core;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    public partial struct JassItem
    {
        public CItemPtr ToCItem()
        {
            return CItemPtr.FromHandle(this);
        }
    }
}
