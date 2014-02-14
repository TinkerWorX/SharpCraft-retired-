using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.APIs
{
    internal class JassAPI : MarshalByRefObject, IJassSafeAPI, IJassFullAPI
    {
        public event Action PreConfig
        {
            add { JassMachine.PreConfig += value; }
            remove { JassMachine.PreConfig -= value; }
        }

        public event Action PostConfig
        {
            add { JassMachine.PostConfig += value; }
            remove { JassMachine.PostConfig -= value; }
        }

        public event Action PreMain
        {
            add { JassMachine.PreMain += value; }
            remove { JassMachine.PreMain -= value; }
        }

        public event Action PostMain
        {
            add { JassMachine.PostMain += value; }
            remove { JassMachine.PostMain -= value; }
        }
    }
}
