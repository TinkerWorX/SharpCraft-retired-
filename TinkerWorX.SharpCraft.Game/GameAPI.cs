using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.SharpCraft.Game.Jass;

namespace TinkerWorX.SharpCraft.Game
{
    internal class GameAPI : MarshalByRefObject, IGameAPI
    {
        
        public void AddNative(Delegate function, String name, String prototype)
        {
            WarcraftIII.Jass.AddNative(function, name, prototype);
        }

        public void AddNative(Delegate function, String name)
        {
            WarcraftIII.Jass.AddNative(function, name);
        }

        public void AddNative(Delegate function)
        {
            WarcraftIII.Jass.AddNative(function);
        }

        public void test(String text)
        {
            Trace.WriteLine(text);
        }

        // native GetLocalPlayer takes nothing returns player
        private delegate JassPlayer GetLocalPlayerDelegate();
        private GetLocalPlayerDelegate _GetLocalPlayer;
        public JassPlayer GetLocalPlayer()
        {
            if (this._GetLocalPlayer == null)
                this._GetLocalPlayer = WarcraftIII.Jass.GetNative("GetLocalPlayer").ToDelegate<GetLocalPlayerDelegate>();
            return this._GetLocalPlayer();
        }

        // native DisplayTextToPlayer takes player toPlayer, real x, real y, string message returns nothing 
        private delegate void DisplayTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassStringArg message);
        private DisplayTextToPlayerPrototype _DisplayTextToPlayer;
        public void DisplayTextToPlayer(JassPlayer player, Single x, Single y, String message)
        {
            if (this._DisplayTextToPlayer == null)
                this._DisplayTextToPlayer = WarcraftIII.Jass.GetNative("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>();
            this._DisplayTextToPlayer(player, x, y, message);
        }
    }
}
