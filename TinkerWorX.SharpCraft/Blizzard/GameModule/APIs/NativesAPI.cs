using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.APIs
{
    internal partial class NativesAPI : MarshalByRefObject, INativesFullAPI, INativesSafeAPI
    {
        public void Add(Delegate function, String name, String prototype)
        {
            Natives.Add(function, name, prototype);
        }

        public void Add(Delegate function, String name)
        {
            Natives.Add(function, name);
        }

        public void Add(Delegate function)
        {
            Natives.Add(function);
        }
    }
}
