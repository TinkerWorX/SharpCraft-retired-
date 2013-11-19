using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.SharpCraft.Game
{
    public interface IGameAPI
    {
        void AddNative(Delegate function, String name, String prototype);
        void AddNative(Delegate function, String name);
        void AddNative(Delegate function);
        
        // Natives
        JassPlayer GetLocalPlayer();
        void DisplayTextToPlayer(JassPlayer player, Single x, Single y, String message);
    }
}
