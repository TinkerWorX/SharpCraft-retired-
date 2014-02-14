using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces
{
    public unsafe interface IInterfaceFullAPI : IInterfaceSafeAPI
    {
        CGameUI* GameUI { get; }
    }
}
