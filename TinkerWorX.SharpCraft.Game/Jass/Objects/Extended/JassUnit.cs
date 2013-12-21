using System;
using System.Runtime.InteropServices;
using TinkerWorX.SharpCraft.Game.Core;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    public partial struct JassUnit
    {
        /// <summary>
        /// Creates a unit.
        /// </summary>
        /// <param name="player">The owner of the unit.</param>
        /// <param name="unitId">The id of the unit type.</param>
        /// <param name="x">The position of the unit.</param>
        /// <param name="y">The position of the unit.</param>
        /// <param name="facing">The facing of the unit.</param>
        /// <returns>A unit.</returns>
        public static JassUnit Create(JassPlayer player, JassUnitId unitId, Single x, Single y, Single facing)
        {
            return WarcraftIII.Jass.Natives.CreateUnit(player, unitId, x, y, facing);
        }

        /// <summary>
        /// Creates a unit.
        /// </summary>
        /// <param name="player">The owner of the unit.</param>
        /// <param name="unitname">The name of the unit type.</param>
        /// <param name="x">The position of the unit.</param>
        /// <param name="y">The position of the unit.</param>
        /// <param name="facing">The facing of the unit.</param>
        /// <returns>A unit.</returns>
        public static JassUnit Create(JassPlayer player, String unitname, Single x, Single y, Single facing)
        {
            return WarcraftIII.Jass.Natives.CreateUnitByName(player, unitname, x, y, facing);
        }

        /// <summary>
        /// Creates a dead unit.
        /// </summary>
        /// <param name="player">The owner of the unit.</param>
        /// <param name="unitId">The id of the unit type.</param>
        /// <param name="x">The position of the unit.</param>
        /// <param name="y">The position of the unit.</param>
        /// <param name="facing">The facing of the unit.</param>
        /// <returns>A unit.</returns>
        public static JassUnit CreateCorpse(JassPlayer player, JassUnitId unitid, Single x, Single y, Single facing)
        {
            return WarcraftIII.Jass.Natives.CreateCorpse(player, unitid, x, y, facing);
        }

        public CUnitPtr ToCUnit()
        {
            return CUnitPtr.FromHandle(this);
        }

        public Single GetX()
        {
            return WarcraftIII.Jass.Natives.GetUnitX(this);
        }

        public void SetX(Single value)
        {
            WarcraftIII.Jass.Natives.SetUnitX(this, value);
        }

        public Single GetY()
        {
            return WarcraftIII.Jass.Natives.GetUnitY(this);
        }

        public void SetY(Single value)
        {
            WarcraftIII.Jass.Natives.SetUnitY(this, value);
        }

        public Single GetFacing()
        {
            return WarcraftIII.Jass.Natives.GetUnitFacing(this);
        }

        public void SetFacing(Single value)
        {
            WarcraftIII.Jass.Natives.SetUnitFacing(this, value);
        }

        public Single GetLife()
        {
            return WarcraftIII.Jass.Natives.GetUnitState(this, JassUnitState.Life);
        }

        public void SetLife(Single value)
        {
            WarcraftIII.Jass.Natives.SetUnitState(this, JassUnitState.Life, value);
        }

        public Single GetMaxLife()
        {
            return WarcraftIII.Jass.Natives.GetUnitState(this, JassUnitState.MaxLife);
        }

        public void SetMaxLife(Single value)
        {
            WarcraftIII.Jass.Natives.SetUnitState(this, JassUnitState.MaxLife, value);
        }

        public Single GetMana()
        {
            return WarcraftIII.Jass.Natives.GetUnitState(this, JassUnitState.Mana);
        }

        public void SetMana(Single value)
        {
            WarcraftIII.Jass.Natives.SetUnitState(this, JassUnitState.Mana, value);
        }

        public Single GetMaxMana()
        {
            return WarcraftIII.Jass.Natives.GetUnitState(this, JassUnitState.MaxMana);
        }

        public void SetMaxMana(Single value)
        {
            WarcraftIII.Jass.Natives.SetUnitState(this, JassUnitState.MaxMana, value);
        }

        public void Kill()
        {
            WarcraftIII.Jass.Natives.KillUnit(this);
        }

        public void Remove()
        {
            WarcraftIII.Jass.Natives.RemoveUnit(this);
        }

        public void Show()
        {
            WarcraftIII.Jass.Natives.ShowUnit(this, true);
        }

        public void Hide()
        {
            WarcraftIII.Jass.Natives.ShowUnit(this, false);
        }
    }
}
