using System;
using TinkerWorX.SharpCraft.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassPlayer
    {
        public static JassPlayer FromLocal()
        {
            return SafeNatives.GetLocalPlayer();
        }

        public static JassPlayer FromIndex(Int32 index)
        {
            return SafeNatives.Player(index);
        }


        public Int32 GetIndex()
        {
            return SafeNatives.GetPlayerId(this);
        }

        public Int32 Index
        {
            get { return this.GetIndex(); }
        }


        public Int32 GetTeam()
        {
            return SafeNatives.GetPlayerTeam(this);
        }

        public void SetTeam(Int32 team)
        {
            SafeNatives.SetPlayerTeam(this, team);
        }

        public Int32 Team
        {
            get { return this.GetTeam(); }
            set { this.SetTeam(value); }
        }


        public Int32 GetStartLocation()
        {
            return SafeNatives.GetPlayerStartLocation(this);
        }

        public void SetStartLocation(Int32 locationIndex)
        {
            SafeNatives.SetPlayerStartLocation(this, locationIndex);
        }

        public void ForceStartLocation(Int32 locationIndex)
        {
            SafeNatives.ForcePlayerStartLocation(this, locationIndex);
        }

        public Int32 StartLocation
        {
            get { return this.GetStartLocation(); }
            set { this.SetStartLocation(value); }
        }

        public Vector2 StartPosition
        {
            get { return new Vector2(SafeNatives.GetStartLocationX(this.GetStartLocation()), SafeNatives.GetStartLocationY(this.GetStartLocation())); }
        }


        public String GetName()
        {
            return SafeNatives.GetPlayerName(this);
        }

        public void SetName(String name)
        {
            SafeNatives.SetPlayerName(this, name);
        }

        public String Name
        {
            get { return this.GetName(); }
            set { this.SetName(value); }
        }


        public JassPlayerColor GetColor()
        {
            return SafeNatives.GetPlayerColor(this);
        }

        public void SetColor(JassPlayerColor color)
        {
            SafeNatives.SetPlayerColor(this, color);
        }

        public JassPlayerColor Color
        {
            get { return this.GetColor(); }
            set { this.SetColor(value); }
        }


        public JassMapControl GetController()
        {
            return SafeNatives.GetPlayerController(this);
        }

        public void SetController(JassMapControl control)
        {
            SafeNatives.SetPlayerController(this, control);
        }

        public JassMapControl Controller
        {
            get { return this.GetController(); }
            set { this.SetController(value); }
        }


        public Int32 GetTaxRate(JassPlayer other, JassPlayerState resource)
        {
            return SafeNatives.GetPlayerTaxRate(this, other, resource);
        }

        public void SetTaxRate(JassPlayer other, JassPlayerState resource, Int32 rate)
        {
            SafeNatives.SetPlayerTaxRate(this, other, resource, rate);
        }


        public void SetRaceSelectable(Boolean flag)
        {
            SafeNatives.SetPlayerRaceSelectable(this, flag);
        }

        public Boolean GetRaceSelectable()
        {
            return SafeNatives.GetPlayerSelectable(this);
        }

        public Boolean RaceSelectable
        {
            get { return this.GetRaceSelectable(); }
            set { this.SetRaceSelectable(value); }
        }


        public JassPlayerSlotState GetSlotState()
        {
            return SafeNatives.GetPlayerSlotState(this);
        }

        public JassPlayerSlotState SlotState
        {
            get { return this.GetSlotState(); }
        }


        public void SetRacePreference(JassRacePreference preference)
        {
            SafeNatives.SetPlayerRacePreference(this, preference);
        }

        public Boolean IsRacePreferenceSet(JassRacePreference preference)
        {
            return SafeNatives.IsPlayerRacePrefSet(this, preference);
        }


        public void SetAlliance(JassPlayer other, JassAllianceType alliance, Boolean flag)
        {
            SafeNatives.SetPlayerAlliance(this, other, alliance, flag);
        }

        public void SetOnScoreScreen(Boolean flag)
        {
            SafeNatives.SetPlayerOnScoreScreen(this, flag);
        }
    }
}
