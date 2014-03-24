using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.FullAPI
{
    public class Interface : MarshalByRefObject
    {
        internal Interface() { }

        public static Single FPS
        {
            get { return InternalInterface.FPS; }
        }

        unsafe public static CGameUIInternal* GameUI
        {
            get { return InternalInterface.GameUI; }
        }
    }
}
