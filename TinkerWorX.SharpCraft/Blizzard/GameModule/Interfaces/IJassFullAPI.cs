using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces
{
    public interface IJassFullAPI : IJassSafeAPI
    {
        event Action PreConfig;

        event Action PostConfig;

        event Action PreMain;

        event Action PostMain;
    }
}
