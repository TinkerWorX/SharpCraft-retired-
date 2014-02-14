using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
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
        public static JassUnit Create(JassPlayer player, JassObjectId unitId, Single x, Single y, Single facing)
        {
            return Natives.CreateUnit(player, unitId, x, y, facing);
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
            return Natives.CreateUnitByName(player, unitname, x, y, facing);
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
        public static JassUnit CreateCorpse(JassPlayer player, JassObjectId unitid, Single x, Single y, Single facing)
        {
            return Natives.CreateCorpse(player, unitid, x, y, facing);
        }

        public CUnitPtr ToCUnit()
        {
            return CUnitPtr.FromHandle(this.Handle);
        }

        public Single GetX()
        {
            return Natives.GetUnitX(this);
        }

        public void SetX(Single value)
        {
            Natives.SetUnitX(this, value);
        }

        public Single GetY()
        {
            return Natives.GetUnitY(this);
        }

        public void SetY(Single value)
        {
            Natives.SetUnitY(this, value);
        }

        public Single GetFacing()
        {
            return Natives.GetUnitFacing(this);
        }

        public void SetFacing(Single value)
        {
            Natives.SetUnitFacing(this, value);
        }

        public Single GetLife()
        {
            return Natives.GetUnitState(this, JassUnitState.Life);
        }

        public void SetLife(Single value)
        {
            Natives.SetUnitState(this, JassUnitState.Life, value);
        }

        public Single GetMaxLife()
        {
            return Natives.GetUnitState(this, JassUnitState.MaxLife);
        }

        public void SetMaxLife(Single value)
        {
            Natives.SetUnitState(this, JassUnitState.MaxLife, value);
        }

        public Single GetMana()
        {
            return Natives.GetUnitState(this, JassUnitState.Mana);
        }

        public void SetMana(Single value)
        {
            Natives.SetUnitState(this, JassUnitState.Mana, value);
        }

        public Single GetMaxMana()
        {
            return Natives.GetUnitState(this, JassUnitState.MaxMana);
        }

        public void SetMaxMana(Single value)
        {
            Natives.SetUnitState(this, JassUnitState.MaxMana, value);
        }

        public void Kill()
        {
            Natives.KillUnit(this);
        }

        public void Remove()
        {
            Natives.RemoveUnit(this);
        }

        public void Show()
        {
            Natives.ShowUnit(this, true);
        }

        public void Hide()
        {
            Natives.ShowUnit(this, false);
        }
    }
}
