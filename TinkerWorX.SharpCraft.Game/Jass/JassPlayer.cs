using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hplayer;")]
    public struct JassPlayer
    {
        // native SetPlayerTeam takes player whichPlayer, integer whichTeam returns nothing
        private delegate void SetPlayerTeamPrototype(JassPlayer whichPlayer, JassInteger whichTeam);
        private static SetPlayerTeamPrototype _SetPlayerTeam = WarcraftIII.Jass.GetNative("SetPlayerTeam").ToDelegate<SetPlayerTeamPrototype>();

        // native GetPlayerTeam takes player whichPlayer returns integer
        private delegate JassInteger GetPlayerTeamPrototype(JassPlayer whichPlayer);
        private static GetPlayerTeamPrototype _GetPlayerTeam = WarcraftIII.Jass.GetNative("GetPlayerTeam").ToDelegate<GetPlayerTeamPrototype>();

        // native SetPlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
        private delegate void SetPlayerStartLocationPrototype(JassPlayer whichPlayer, JassInteger startLocIndex);
        private static SetPlayerStartLocationPrototype _SetPlayerStartLocation = WarcraftIII.Jass.GetNative("SetPlayerStartLocation").ToDelegate<SetPlayerStartLocationPrototype>();

        // native GetPlayerStartLocation takes player whichPlayer returns integer
        private delegate JassInteger GetPlayerStartLocationPrototype(JassPlayer whichPlayer);
        private static GetPlayerStartLocationPrototype _GetPlayerStartLocation = WarcraftIII.Jass.GetNative("GetPlayerStartLocation").ToDelegate<GetPlayerStartLocationPrototype>();

        // constant native GetLocalPlayer takes nothing returns player
        private delegate JassPlayer GetLocalPlayerPrototype();
        private static GetLocalPlayerPrototype _GetLocalPlayer = WarcraftIII.Jass.GetNative("GetLocalPlayer").ToDelegate<GetLocalPlayerPrototype>();

        // constant native Player takes integer number returns player
        private delegate JassPlayer PlayerPrototype(JassInteger number);
        private static PlayerPrototype _Player = WarcraftIII.Jass.GetNative("Player").ToDelegate<PlayerPrototype>();

        // constant native GetPlayerId takes player whichPlayer returns integer
        private delegate JassInteger GetPlayerIdPrototype(JassPlayer whichPlayer);
        private static GetPlayerIdPrototype _GetPlayerId = WarcraftIII.Jass.GetNative("GetPlayerId").ToDelegate<GetPlayerIdPrototype>();

        // native GetPlayerName takes player whichPlayer returns string
        private delegate JassStringRet GetPlayerNameDelegate(JassPlayer whichPlayer);
        private static GetPlayerNameDelegate _GetPlayerName = WarcraftIII.Jass.GetNative("GetPlayerName").ToDelegate<GetPlayerNameDelegate>();

        // native GetPlayerName takes player whichPlayer returns string
        private delegate void SetPlayerNameDelegate(JassPlayer whichPlayer, JassStringArg name);
        private static SetPlayerNameDelegate _SetPlayerName = WarcraftIII.Jass.GetNative("SetPlayerName").ToDelegate<SetPlayerNameDelegate>();

        public static JassPlayer FromLocal()
        {
            return _GetLocalPlayer();
        }

        public static JassPlayer FromIndex(Int32 index)
        {
            return _Player(index);
        }

        private readonly IntPtr Handle;

        public JassPlayer(IntPtr handle)
        {
            this.Handle = handle;
        }


        public Int32 Index { get { return this.GetIndex(); } }

        public Int32 GetIndex()
        {
            return _GetPlayerId(this);
        }


        public Int32 Team
        {
            get { return this.GetTeam(); }
            set { this.SetTeam(value); }
        }

        public Int32 GetTeam()
        {
            return _GetPlayerTeam(this);
        }

        public void SetTeam(Int32 team)
        {
            _SetPlayerTeam(this, team);
        }


        public Int32 StartLocation
        {
            get { return this.GetStartLocation(); }
            set { this.SetStartLocation(value); }
        }

        public Int32 GetStartLocation()
        {
            return _GetPlayerStartLocation(this);
        }

        public void SetStartLocation(Int32 locationIndex)
        {
            _SetPlayerStartLocation(this, locationIndex);
        }


        public String Name
        {
            get { return this.GetName(); }
            set { this.SetName(value); }
        }

        public String GetName()
        {
            return _GetPlayerName(this);
        }

        public void SetName(String name)
        {
            _SetPlayerName(this, name);
        }


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
