using System;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces
{
    public interface INativesFullAPI : INativesSafeAPI
    {
        void Add(Delegate function, String name, String prototype);

        void Add(Delegate function, String name);

        void Add(Delegate function);
    }
}
