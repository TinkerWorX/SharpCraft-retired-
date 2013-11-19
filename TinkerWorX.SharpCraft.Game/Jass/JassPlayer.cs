using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [Serializable]
    [JassType("Hplayer;")]
    public struct JassPlayer
    {        
        /*

        // constant native GetLocalPlayer takes nothing returns player
        private delegate JassPlayer GetLocalPlayerPrototype();
        private static GetLocalPlayerPrototype _GetLocalPlayer = WarcraftIII.GetNative("GetLocalPlayer").ToDelegate<GetLocalPlayerPrototype>();

        // constant native Player takes integer number returns player
        private delegate JassPlayer PlayerPrototype(JassInteger number);
        private static PlayerPrototype _Player = WarcraftIII.GetNative("Player").ToDelegate<PlayerPrototype>();

        // native GetPlayerName takes player whichPlayer returns string
        private delegate JassStringRet GetPlayerNameDelegate(JassPlayer whichPlayer);
        private static GetPlayerNameDelegate _GetPlayerName = WarcraftIII.GetNative("GetPlayerName").ToDelegate<GetPlayerNameDelegate>();

        // native GetPlayerName takes player whichPlayer returns string
        private delegate void SetPlayerNameDelegate(JassPlayer whichPlayer, JassStringArg name);
        private static SetPlayerNameDelegate _SetPlayerName = WarcraftIII.GetNative("SetPlayerName").ToDelegate<SetPlayerNameDelegate>();

        public static JassPlayer FromLocal()
        {
            return _GetLocalPlayer();
        }

        public static JassPlayer FromIndex(Int32 index)
        {
            return _Player(index);
        }

        */

        public readonly IntPtr Handle;

        public JassPlayer(IntPtr handle)
        {
            this.Handle = handle;
        }

        /*
        
        public String GetName()
        {
            return _GetPlayerName(this);
        }

        public void SetName(String value)
        {
            _SetPlayerName(this, value);
        }
        
        */

        public override String ToString()
        {
            return this.Handle.ToString();
        }

        public String ToString(String format)
        {
            return this.Handle.ToString(format);
        }
    }
}
