using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    public partial struct JassPlayer
    {
        public static JassPlayer FromLocal()
        {
            return WarcraftIII.Jass.Natives.GetLocalPlayer();
        }

        public static JassPlayer FromIndex(Int32 index)
        {
            return WarcraftIII.Jass.Natives.Player(index);
        }

        public Int32 Index { get { return this.GetIndex(); } }

        public Int32 GetIndex()
        {
            return WarcraftIII.Jass.Natives.GetPlayerId(this);
        }

        public Int32 Team
        {
            get { return this.GetTeam(); }
            set { this.SetTeam(value); }
        }

        public Int32 GetTeam()
        {
            return WarcraftIII.Jass.Natives.GetPlayerTeam(this);
        }

        public void SetTeam(Int32 team)
        {
            WarcraftIII.Jass.Natives.SetPlayerTeam(this, team);
        }

        public Int32 StartLocation
        {
            get { return this.GetStartLocation(); }
            set { this.SetStartLocation(value); }
        }

        public Int32 GetStartLocation()
        {
            return WarcraftIII.Jass.Natives.GetPlayerStartLocation(this);
        }

        public void SetStartLocation(Int32 locationIndex)
        {
            WarcraftIII.Jass.Natives.SetPlayerStartLocation(this, locationIndex);
        }

        public String Name
        {
            get { return this.GetName(); }
            set { this.SetName(value); }
        }

        public String GetName()
        {
            return WarcraftIII.Jass.Natives.GetPlayerName(this);
        }

        public void SetName(String name)
        {
            WarcraftIII.Jass.Natives.SetPlayerName(this, name);
        }
    }
}
