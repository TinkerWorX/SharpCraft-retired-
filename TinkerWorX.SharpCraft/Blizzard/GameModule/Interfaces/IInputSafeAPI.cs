using System;
using TinkerWorX.SharpCraft.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces
{
    public interface IInputSafeAPI
    {
        Point2 MouseWindow { get; }

        Boolean IsMouseOverUI { get; }

        Vector2 MouseUI { get; }

        Vector3 MouseTerrain { get; }

        Boolean BlockChat { get; set; }
    }
}
