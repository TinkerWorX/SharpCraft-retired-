using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    public interface IMapPlugin
    {
        void OnMapStart();

        void OnMapEnd();
    }
}
