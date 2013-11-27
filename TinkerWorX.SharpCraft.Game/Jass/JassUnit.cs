using System;
using System.Runtime.InteropServices;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    [JassType("Hunit;")]
    public struct JassUnit
    {
        // native CreateUnit takes player id, integer unitid, real x, real y, real face returns unit
        private delegate JassUnit CreateUnitPrototype(JassPlayer id, JassUnitId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateUnitPrototype _CreateUnit = WarcraftIII.Jass.GetNative("CreateUnit").ToDelegate<CreateUnitPrototype>();

        // native CreateUnitByName takes player whichPlayer, string unitname, real x, real y, real face returns unit
        private delegate JassUnit CreateUnitByNamePrototype(JassPlayer whichPlayer, JassStringArg unitname, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateUnitByNamePrototype _CreateUnitByName = WarcraftIII.Jass.GetNative("CreateUnitByName").ToDelegate<CreateUnitByNamePrototype>();

        // native CreateCorpse takes player whichPlayer, integer unitid, real x, real y, real face returns unit
        private delegate JassUnit CreateCorpsePrototype(JassPlayer whichPlayer, JassUnitId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateCorpsePrototype _CreateCorpse = WarcraftIII.Jass.GetNative("CreateCorpse").ToDelegate<CreateCorpsePrototype>();

        // native KillUnit takes unit whichUnit returns nothing
        private delegate void KillUnitPrototype(JassUnit whichUnit);
        private static KillUnitPrototype _KillUnit = WarcraftIII.Jass.GetNative("KillUnit").ToDelegate<KillUnitPrototype>();

        // native RemoveUnit takes unit whichUnit returns nothing
        private delegate void RemoveUnitPrototype(JassUnit whichUnit);
        private static RemoveUnitPrototype _RemoveUnit = WarcraftIII.Jass.GetNative("RemoveUnit").ToDelegate<RemoveUnitPrototype>();

        // native ShowUnit takes unit whichUnit, boolean show returns nothing
        private delegate void ShowUnitPrototype(JassUnit whichUnit, JassBoolean show);
        private static ShowUnitPrototype _ShowUnit = WarcraftIII.Jass.GetNative("ShowUnit").ToDelegate<ShowUnitPrototype>();

        // native SetUnitX takes unit whichUnit, real newX returns nothing
        private delegate void SetUnitXPrototype(JassUnit whichUnit, JassRealArg newX);
        private static SetUnitXPrototype _SetUnitX = WarcraftIII.Jass.GetNative("SetUnitX").ToDelegate<SetUnitXPrototype>();

        // native SetUnitY takes unit whichUnit, real newY returns nothing
        private delegate void SetUnitYPrototype(JassUnit whichUnit, JassRealArg newY);
        private static SetUnitYPrototype _SetUnitY = WarcraftIII.Jass.GetNative("SetUnitY").ToDelegate<SetUnitYPrototype>();

        // native SetUnitFacing takes unit whichUnit, real facingAngle returns nothing
        private delegate void SetUnitFacingPrototype(JassUnit whichUnit, JassRealArg facingAngle);
        private static SetUnitFacingPrototype _SetUnitFacing = WarcraftIII.Jass.GetNative("SetUnitFacing").ToDelegate<SetUnitFacingPrototype>();

        // native SetUnitState takes unit whichUnit, unitstate whichUnitState, real newVal returns nothing
        private delegate void SetUnitStatePrototype(JassUnit whichUnit, JassUnitState whichUnitState, JassRealArg newVal);
        private static SetUnitStatePrototype _SetUnitState = WarcraftIII.Jass.GetNative("SetUnitState").ToDelegate<SetUnitStatePrototype>();

        // constant native GetUnitX takes unit whichUnit returns real
        private delegate JassRealRet GetUnitXPrototype(JassUnit whichUnit);
        private static GetUnitXPrototype _GetUnitX = WarcraftIII.Jass.GetNative("GetUnitX").ToDelegate<GetUnitXPrototype>();

        // constant native GetUnitY takes unit whichUnit returns real
        private delegate JassRealRet GetUnitYPrototype(JassUnit whichUnit);
        private static GetUnitYPrototype _GetUnitY = WarcraftIII.Jass.GetNative("GetUnitY").ToDelegate<GetUnitYPrototype>();

        // constant native GetUnitFacing takes unit whichUnit returns real
        private delegate JassRealRet GetUnitFacingPrototype(JassUnit whichUnit);
        private static GetUnitFacingPrototype _GetUnitFacing = WarcraftIII.Jass.GetNative("GetUnitFacing").ToDelegate<GetUnitFacingPrototype>();

        // constant native GetUnitState takes unit whichUnit, unitstate whichUnitState returns real
        private delegate JassRealRet GetUnitStatePrototype(JassUnit whichUnit, JassUnitState whichUnitState);
        private static GetUnitStatePrototype _GetUnitState = WarcraftIII.Jass.GetNative("GetUnitState").ToDelegate<GetUnitStatePrototype>();

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
            return _CreateUnit(player, unitId, x, y, facing);
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
            return _CreateUnitByName(player, unitname, x, y, facing);
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
            return _CreateCorpse(player, unitid, x, y, facing);
        }

        private readonly IntPtr Handle;

        public JassUnit(IntPtr handle)
        {
            this.Handle = handle;
        }

        public Single GetX()
        {
            return _GetUnitX(this);
        }

        public void SetX(Single value)
        {
            _SetUnitX(this, value);
        }

        public Single GetY()
        {
            return _GetUnitY(this);
        }

        public void SetY(Single value)
        {
            _SetUnitY(this, value);
        }

        public Single GetFacing()
        {
            return _GetUnitFacing(this);
        }

        public void SetFacing(Single value)
        {
            _SetUnitFacing(this, value);
        }

        public Single GetLife()
        {
            return _GetUnitState(this, JassUnitState.Life);
        }

        public void SetLife(Single value)
        {
            _SetUnitState(this, JassUnitState.Life, value);
        }

        public Single GetMaxLife()
        {
            return _GetUnitState(this, JassUnitState.MaxLife);
        }

        public void SetMaxLife(Single value)
        {
            _SetUnitState(this, JassUnitState.MaxLife, value);
        }

        public Single GetMana()
        {
            return _GetUnitState(this, JassUnitState.Mana);
        }

        public void SetMana(Single value)
        {
            _SetUnitState(this, JassUnitState.Mana, value);
        }

        public Single GetMaxMana()
        {
            return _GetUnitState(this, JassUnitState.MaxMana);
        }

        public void SetMaxMana(Single value)
        {
            _SetUnitState(this, JassUnitState.MaxMana, value);
        }

        public void Kill()
        {
            _KillUnit(this);
        }

        public void Remove()
        {
            _RemoveUnit(this);
        }

        public void Show()
        {
            _ShowUnit(this, true);
        }

        public void Hide()
        {
            _ShowUnit(this, false);
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
