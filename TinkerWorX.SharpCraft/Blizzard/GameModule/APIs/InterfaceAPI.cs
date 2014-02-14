using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.APIs
{
    internal class InterfaceAPI : MarshalByRefObject, IInterfaceSafeAPI, IInterfaceFullAPI
    {
        public Single FPS
        {
            get { return Interface.FPS; }
        }

        unsafe public CGameUI* GameUI
        {
            get { return Interface.GameUI; }
        }
    }
}
