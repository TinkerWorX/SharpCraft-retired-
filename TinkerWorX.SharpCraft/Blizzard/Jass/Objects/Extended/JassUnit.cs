using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

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
            return SafeNatives.CreateUnit(player, unitId, x, y, facing);
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
            return SafeNatives.CreateUnitByName(player, unitname, x, y, facing);
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
            return SafeNatives.CreateCorpse(player, unitid, x, y, facing);
        }

        public CUnitPtr ToCUnit()
        {
            return CUnitPtr.FromHandle(this.Handle);
        }

        public Single GetX()
        {
            return SafeNatives.GetUnitX(this);
        }

        public void SetX(Single value)
        {
            SafeNatives.SetUnitX(this, value);
        }

        public Single GetY()
        {
            return SafeNatives.GetUnitY(this);
        }

        public void SetY(Single value)
        {
            SafeNatives.SetUnitY(this, value);
        }

        public Single GetFacing()
        {
            return SafeNatives.GetUnitFacing(this);
        }

        public void SetFacing(Single value)
        {
            SafeNatives.SetUnitFacing(this, value);
        }

        public Single GetLife()
        {
            return SafeNatives.GetUnitState(this, JassUnitState.Life);
        }

        public void SetLife(Single value)
        {
            SafeNatives.SetUnitState(this, JassUnitState.Life, value);
        }

        public Single GetMaxLife()
        {
            return SafeNatives.GetUnitState(this, JassUnitState.MaxLife);
        }

        public void SetMaxLife(Single value)
        {
            SafeNatives.SetUnitState(this, JassUnitState.MaxLife, value);
        }

        public Single GetMana()
        {
            return SafeNatives.GetUnitState(this, JassUnitState.Mana);
        }

        public void SetMana(Single value)
        {
            SafeNatives.SetUnitState(this, JassUnitState.Mana, value);
        }

        public Single GetMaxMana()
        {
            return SafeNatives.GetUnitState(this, JassUnitState.MaxMana);
        }

        public void SetMaxMana(Single value)
        {
            SafeNatives.SetUnitState(this, JassUnitState.MaxMana, value);
        }

        public void Kill()
        {
            SafeNatives.KillUnit(this);
        }

        public void Remove()
        {
            SafeNatives.RemoveUnit(this);
        }

        public void Show()
        {
            SafeNatives.ShowUnit(this, true);
        }

        public void Hide()
        {
            SafeNatives.ShowUnit(this, false);
        }
    }
}
