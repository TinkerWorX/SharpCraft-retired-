using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Types
{
    unsafe public interface IAgent<T>
    {
        IntPtr AsIntPtr();
        CAgent ToBase();
    }

    unsafe public interface IAgentInternal<T>
    {
        IntPtr AsIntPtr();
        CAgentInternal* ToBase();
    }
}
