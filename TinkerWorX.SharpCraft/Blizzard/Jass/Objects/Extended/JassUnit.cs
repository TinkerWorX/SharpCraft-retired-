using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Types;
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

        public CUnit ToCUnit()
        {
            return CUnit.FromHandle(this.Handle);
        }


        public void Kill()
        {
            SafeNatives.KillUnit(this);
        }

        public void Remove()
        {
            SafeNatives.RemoveUnit(this);
        }


        public Single GetX()
        {
            return SafeNatives.GetUnitX(this);
        }

        public void SetX(Single value)
        {
            SafeNatives.SetUnitX(this, value);
        }

        public void SetX(Single value, Boolean performChecks)
        {
            if (performChecks)
                SafeNatives.SetUnitPosition(this, value, this.GetY());
            else
                SafeNatives.SetUnitX(this, value);
        }

        public Single X
        {
            get { return this.GetX(); }
            set { this.SetX(value); }
        }


        public Single GetY()
        {
            return SafeNatives.GetUnitY(this);
        }

        public void SetY(Single value)
        {
            SafeNatives.SetUnitY(this, value);
        }

        public void SetY(Single value, Boolean performChecks)
        {
            if (performChecks)
                SafeNatives.SetUnitPosition(this, this.GetX(), value);
            else
                SafeNatives.SetUnitY(this, value);
        }

        public Single Y
        {
            get { return this.GetY(); }
            set { this.SetY(value); }
        }


        public Vector2 GetPosition()
        {
            return new Vector2(this.GetX(), this.GetY());
        }

        public void SetPosition(Vector2 position)
        {
            this.SetX(position.X);
            this.SetY(position.Y);
        }

        public void SetPosition(Vector2 position, Boolean performChecks)
        {
            if (performChecks)
                SafeNatives.SetUnitPosition(this, position.X, position.Y);
            else
            {
                this.SetX(position.X);
                this.SetY(position.Y);
            }
        }


        public Single GetFacing()
        {
            return SafeNatives.GetUnitFacing(this);
        }

        public void SetFacing(Single value)
        {
            SafeNatives.SetUnitFacing(this, value);
        }

        public void SetFacing(Single value, Single duration)
        {
            SafeNatives.SetUnitFacingTimed(this, value, duration);
        }

        public Single Facing
        {
            get { return this.GetFacing(); }
            set { this.SetFacing(value); }
        }


        public Single GetLife()
        {
            return SafeNatives.GetUnitState(this, JassUnitState.Life);
        }

        public void SetLife(Single value)
        {
            SafeNatives.SetUnitState(this, JassUnitState.Life, value);
        }

        public Single Life
        {
            get { return this.GetLife(); }
            set { this.SetLife(value); }
        }


        public Single GetMaxLife()
        {
            return SafeNatives.GetUnitState(this, JassUnitState.MaxLife);
        }

        public void SetMaxLife(Single value)
        {
            SafeNatives.SetUnitState(this, JassUnitState.MaxLife, value);
        }

        public Single MaxLife
        {
            get { return this.GetMaxLife(); }
            set { this.SetMaxLife(value); }
        }


        public Single GetMana()
        {
            return SafeNatives.GetUnitState(this, JassUnitState.Mana);
        }

        public void SetMana(Single value)
        {
            SafeNatives.SetUnitState(this, JassUnitState.Mana, value);
        }

        public Single Mana
        {
            get { return this.GetMana(); }
            set { this.SetMana(value); }
        }


        public Single GetMaxMana()
        {
            return SafeNatives.GetUnitState(this, JassUnitState.MaxMana);
        }

        public void SetMaxMana(Single value)
        {
            SafeNatives.SetUnitState(this, JassUnitState.MaxMana, value);
        }

        public Single MaxMana
        {
            get { return this.GetMaxMana(); }
            set { this.SetMaxMana(value); }
        }


        public void Show()
        {
            SafeNatives.ShowUnit(this, true);
        }

        public void Hide()
        {
            SafeNatives.ShowUnit(this, false);
        }

        /*
            native          SetUnitPositionLoc  takes unit whichUnit, location whichLocation returns nothing
            native          SetUnitMoveSpeed    takes unit whichUnit, real newSpeed returns nothing
            native          SetUnitFlyHeight    takes unit whichUnit, real newHeight, real rate returns nothing
            native          SetUnitTurnSpeed    takes unit whichUnit, real newTurnSpeed returns nothing
            native          SetUnitPropWindow   takes unit whichUnit, real newPropWindowAngle returns nothing
            native          SetUnitAcquireRange takes unit whichUnit, real newAcquireRange returns nothing
            native          SetUnitCreepGuard   takes unit whichUnit, boolean creepGuard returns nothing

            native          GetUnitAcquireRange     takes unit whichUnit returns real
            native          GetUnitTurnSpeed        takes unit whichUnit returns real
            native          GetUnitPropWindow       takes unit whichUnit returns real
            native          GetUnitFlyHeight        takes unit whichUnit returns real

            native          GetUnitDefaultAcquireRange      takes unit whichUnit returns real
            native          GetUnitDefaultTurnSpeed         takes unit whichUnit returns real
            native          GetUnitDefaultPropWindow        takes unit whichUnit returns real
            native          GetUnitDefaultFlyHeight         takes unit whichUnit returns real

            native          SetUnitOwner        takes unit whichUnit, player whichPlayer, boolean changeColor returns nothing
            native          SetUnitColor        takes unit whichUnit, playercolor whichColor returns nothing

            native          SetUnitScale        takes unit whichUnit, real scaleX, real scaleY, real scaleZ returns nothing
            native          SetUnitTimeScale    takes unit whichUnit, real timeScale returns nothing
            native          SetUnitBlendTime    takes unit whichUnit, real blendTime returns nothing
            native          SetUnitVertexColor  takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing

            native          QueueUnitAnimation          takes unit whichUnit, string whichAnimation returns nothing
            native          SetUnitAnimation            takes unit whichUnit, string whichAnimation returns nothing
            native          SetUnitAnimationByIndex     takes unit whichUnit, integer whichAnimation returns nothing
            native          SetUnitAnimationWithRarity  takes unit whichUnit, string whichAnimation, raritycontrol rarity returns nothing
            native          AddUnitAnimationProperties  takes unit whichUnit, string animProperties, boolean add returns nothing

            native          SetUnitLookAt       takes unit whichUnit, string whichBone, unit lookAtTarget, real offsetX, real offsetY, real offsetZ returns nothing
            native          ResetUnitLookAt     takes unit whichUnit returns nothing

            native          SetUnitRescuable    takes unit whichUnit, player byWhichPlayer, boolean flag returns nothing
            native          SetUnitRescueRange  takes unit whichUnit, real range returns nothing

            native          SetHeroStr          takes unit whichHero, integer newStr, boolean permanent returns nothing
            native          SetHeroAgi          takes unit whichHero, integer newAgi, boolean permanent returns nothing
            native          SetHeroInt          takes unit whichHero, integer newInt, boolean permanent returns nothing

            native          GetHeroStr          takes unit whichHero, boolean includeBonuses returns integer
            native          GetHeroAgi          takes unit whichHero, boolean includeBonuses returns integer
            native          GetHeroInt          takes unit whichHero, boolean includeBonuses returns integer

            native          UnitStripHeroLevel  takes unit whichHero, integer howManyLevels returns boolean

            native          GetHeroXP           takes unit whichHero returns integer
            native          SetHeroXP           takes unit whichHero, integer newXpVal,  boolean showEyeCandy returns nothing

            native          GetHeroSkillPoints      takes unit whichHero returns integer
            native          UnitModifySkillPoints   takes unit whichHero, integer skillPointDelta returns boolean

            native          AddHeroXP           takes unit whichHero, integer xpToAdd,   boolean showEyeCandy returns nothing
            native          SetHeroLevel        takes unit whichHero, integer level,  boolean showEyeCandy returns nothing
            constant native GetHeroLevel        takes unit whichHero returns integer
            constant native GetUnitLevel        takes unit whichUnit returns integer
            native          GetHeroProperName   takes unit whichHero returns string
            native          SuspendHeroXP       takes unit whichHero, boolean flag returns nothing
            native          IsSuspendedXP       takes unit whichHero returns boolean
            native          SelectHeroSkill     takes unit whichHero, integer abilcode returns nothing
            native          GetUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
            native          DecUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
            native          IncUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
            native          SetUnitAbilityLevel takes unit whichUnit, integer abilcode, integer level returns integer
            native          ReviveHero          takes unit whichHero, real x, real y, boolean doEyecandy returns boolean
            native          ReviveHeroLoc       takes unit whichHero, location loc, boolean doEyecandy returns boolean
            native          SetUnitExploded     takes unit whichUnit, boolean exploded returns nothing
            native          SetUnitInvulnerable takes unit whichUnit, boolean flag returns nothing
            native          PauseUnit           takes unit whichUnit, boolean flag returns nothing
            native          IsUnitPaused        takes unit whichHero returns boolean
            native          SetUnitPathing      takes unit whichUnit, boolean flag returns nothing

            native          ClearSelection      takes nothing returns nothing
            native          SelectUnit          takes unit whichUnit, boolean flag returns nothing

            native          GetUnitPointValue       takes unit whichUnit returns integer
            native          GetUnitPointValueByType takes integer unitType returns integer
            //native        SetUnitPointValueByType takes integer unitType, integer newPointValue returns nothing

            native          UnitAddItem             takes unit whichUnit, item whichItem returns boolean
            native          UnitAddItemById         takes unit whichUnit, integer itemId returns item
            native          UnitAddItemToSlotById   takes unit whichUnit, integer itemId, integer itemSlot returns boolean
            native          UnitRemoveItem          takes unit whichUnit, item whichItem returns nothing
            native          UnitRemoveItemFromSlot  takes unit whichUnit, integer itemSlot returns item
            native          UnitHasItem             takes unit whichUnit, item whichItem returns boolean
            native          UnitItemInSlot          takes unit whichUnit, integer itemSlot returns item
            native          UnitInventorySize       takes unit whichUnit returns integer

            native          UnitDropItemPoint       takes unit whichUnit, item whichItem, real x, real y returns boolean
            native          UnitDropItemSlot        takes unit whichUnit, item whichItem, integer slot returns boolean
            native          UnitDropItemTarget      takes unit whichUnit, item whichItem, widget target returns boolean

            native          UnitUseItem             takes unit whichUnit, item whichItem returns boolean
            native          UnitUseItemPoint        takes unit whichUnit, item whichItem, real x, real y returns boolean
            native          UnitUseItemTarget       takes unit whichUnit, item whichItem, widget target returns boolean

            constant native GetUnitX            takes unit whichUnit returns real
            constant native GetUnitY            takes unit whichUnit returns real
            constant native GetUnitLoc          takes unit whichUnit returns location
            constant native GetUnitFacing       takes unit whichUnit returns real
            constant native GetUnitMoveSpeed    takes unit whichUnit returns real
            constant native GetUnitDefaultMoveSpeed takes unit whichUnit returns real
            constant native GetUnitState        takes unit whichUnit, unitstate whichUnitState returns real
            constant native GetOwningPlayer     takes unit whichUnit returns player
            constant native GetUnitTypeId       takes unit whichUnit returns integer
            constant native GetUnitRace         takes unit whichUnit returns race
            constant native GetUnitName         takes unit whichUnit returns string
            constant native GetUnitFoodUsed     takes unit whichUnit returns integer
            constant native GetUnitFoodMade     takes unit whichUnit returns integer
            constant native GetFoodMade         takes integer unitId returns integer
            constant native GetFoodUsed         takes integer unitId returns integer
            native          SetUnitUseFood      takes unit whichUnit, boolean useFood returns nothing

            constant native GetUnitRallyPoint           takes unit whichUnit returns location
            constant native GetUnitRallyUnit            takes unit whichUnit returns unit
            constant native GetUnitRallyDestructable    takes unit whichUnit returns destructable

            constant native IsUnitInGroup       takes unit whichUnit, group whichGroup returns boolean
            constant native IsUnitInForce       takes unit whichUnit, force whichForce returns boolean
            constant native IsUnitOwnedByPlayer takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitAlly          takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitEnemy         takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitVisible       takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitDetected      takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitInvisible     takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitFogged        takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitMasked        takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitSelected      takes unit whichUnit, player whichPlayer returns boolean
            constant native IsUnitRace          takes unit whichUnit, race whichRace returns boolean
            constant native IsUnitType          takes unit whichUnit, unittype whichUnitType returns boolean
            constant native IsUnit              takes unit whichUnit, unit whichSpecifiedUnit returns boolean
            constant native IsUnitInRange       takes unit whichUnit, unit otherUnit, real distance returns boolean
            constant native IsUnitInRangeXY     takes unit whichUnit, real x, real y, real distance returns boolean
            constant native IsUnitInRangeLoc    takes unit whichUnit, location whichLocation, real distance returns boolean
            constant native IsUnitHidden        takes unit whichUnit returns boolean
            constant native IsUnitIllusion      takes unit whichUnit returns boolean

            constant native IsUnitInTransport   takes unit whichUnit, unit whichTransport returns boolean
            constant native IsUnitLoaded        takes unit whichUnit returns boolean

            constant native IsHeroUnitId        takes integer unitId returns boolean
            constant native IsUnitIdType        takes integer unitId, unittype whichUnitType returns boolean

            native UnitShareVision              takes unit whichUnit, player whichPlayer, boolean share returns nothing
            native UnitSuspendDecay             takes unit whichUnit, boolean suspend returns nothing
            native UnitAddType                  takes unit whichUnit, unittype whichUnitType returns boolean
            native UnitRemoveType               takes unit whichUnit, unittype whichUnitType returns boolean

            native UnitAddAbility               takes unit whichUnit, integer abilityId returns boolean
            native UnitRemoveAbility            takes unit whichUnit, integer abilityId returns boolean
            native UnitMakeAbilityPermanent     takes unit whichUnit, boolean permanent, integer abilityId returns boolean
            native UnitRemoveBuffs              takes unit whichUnit, boolean removePositive, boolean removeNegative returns nothing
            native UnitRemoveBuffsEx            takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns nothing
            native UnitHasBuffsEx               takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns boolean
            native UnitCountBuffsEx             takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns integer
            native UnitAddSleep                 takes unit whichUnit, boolean add returns nothing
            native UnitCanSleep                 takes unit whichUnit returns boolean
            native UnitAddSleepPerm             takes unit whichUnit, boolean add returns nothing
            native UnitCanSleepPerm             takes unit whichUnit returns boolean
            native UnitIsSleeping               takes unit whichUnit returns boolean
            native UnitWakeUp                   takes unit whichUnit returns nothing
            native UnitApplyTimedLife           takes unit whichUnit, integer buffId, real duration returns nothing
            native UnitIgnoreAlarm              takes unit whichUnit, boolean flag returns boolean
            native UnitIgnoreAlarmToggled       takes unit whichUnit returns boolean
            native UnitResetCooldown            takes unit whichUnit returns nothing
            native UnitSetConstructionProgress  takes unit whichUnit, integer constructionPercentage returns nothing
            native UnitSetUpgradeProgress       takes unit whichUnit, integer upgradePercentage returns nothing
            native UnitPauseTimedLife           takes unit whichUnit, boolean flag returns nothing
            native UnitSetUsesAltIcon           takes unit whichUnit, boolean flag returns nothing

            native UnitDamagePoint              takes unit whichUnit, real delay, real radius, real x, real y, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
            native UnitDamageTarget             takes unit whichUnit, widget target, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean

            native IssueImmediateOrder          takes unit whichUnit, string order returns boolean
            native IssueImmediateOrderById      takes unit whichUnit, integer order returns boolean
            native IssuePointOrder              takes unit whichUnit, string order, real x, real y returns boolean
            native IssuePointOrderLoc           takes unit whichUnit, string order, location whichLocation returns boolean
            native IssuePointOrderById          takes unit whichUnit, integer order, real x, real y returns boolean
            native IssuePointOrderByIdLoc       takes unit whichUnit, integer order, location whichLocation returns boolean
            native IssueTargetOrder             takes unit whichUnit, string order, widget targetWidget returns boolean
            native IssueTargetOrderById         takes unit whichUnit, integer order, widget targetWidget returns boolean
            native IssueInstantPointOrder       takes unit whichUnit, string order, real x, real y, widget instantTargetWidget returns boolean
            native IssueInstantPointOrderById   takes unit whichUnit, integer order, real x, real y, widget instantTargetWidget returns boolean
            native IssueInstantTargetOrder      takes unit whichUnit, string order, widget targetWidget, widget instantTargetWidget returns boolean
            native IssueInstantTargetOrderById  takes unit whichUnit, integer order, widget targetWidget, widget instantTargetWidget returns boolean
            native IssueBuildOrder              takes unit whichPeon, string unitToBuild, real x, real y returns boolean
            native IssueBuildOrderById          takes unit whichPeon, integer unitId, real x, real y returns boolean

            native IssueNeutralImmediateOrder       takes player forWhichPlayer, unit neutralStructure, string unitToBuild returns boolean
            native IssueNeutralImmediateOrderById   takes player forWhichPlayer,unit neutralStructure, integer unitId returns boolean
            native IssueNeutralPointOrder           takes player forWhichPlayer,unit neutralStructure, string unitToBuild, real x, real y returns boolean
            native IssueNeutralPointOrderById       takes player forWhichPlayer,unit neutralStructure, integer unitId, real x, real y returns boolean
            native IssueNeutralTargetOrder          takes player forWhichPlayer,unit neutralStructure, string unitToBuild, widget target returns boolean
            native IssueNeutralTargetOrderById      takes player forWhichPlayer,unit neutralStructure, integer unitId, widget target returns boolean

            native GetUnitCurrentOrder          takes unit whichUnit returns integer

            native SetResourceAmount            takes unit whichUnit, integer amount returns nothing
            native AddResourceAmount            takes unit whichUnit, integer amount returns nothing
            native GetResourceAmount            takes unit whichUnit returns integer

            native WaygateGetDestinationX       takes unit waygate returns real
            native WaygateGetDestinationY       takes unit waygate returns real
            native WaygateSetDestination        takes unit waygate, real x, real y returns nothing
            native WaygateActivate              takes unit waygate, boolean activate returns nothing
            native WaygateIsActive              takes unit waygate returns boolean

            native AddItemToAllStock            takes integer itemId, integer currentStock, integer stockMax returns nothing
            native AddItemToStock               takes unit whichUnit, integer itemId, integer currentStock, integer stockMax returns nothing
            native AddUnitToAllStock            takes integer unitId, integer currentStock, integer stockMax returns nothing
            native AddUnitToStock               takes unit whichUnit, integer unitId, integer currentStock, integer stockMax returns nothing

            native RemoveItemFromAllStock       takes integer itemId returns nothing
            native RemoveItemFromStock          takes unit whichUnit, integer itemId returns nothing
            native RemoveUnitFromAllStock       takes integer unitId returns nothing
            native RemoveUnitFromStock          takes unit whichUnit, integer unitId returns nothing

            native SetAllItemTypeSlots          takes integer slots returns nothing
            native SetAllUnitTypeSlots          takes integer slots returns nothing
            native SetItemTypeSlots             takes unit whichUnit, integer slots returns nothing
            native SetUnitTypeSlots             takes unit whichUnit, integer slots returns nothing

            native GetUnitUserData              takes unit whichUnit returns integer
            native SetUnitUserData              takes unit whichUnit, integer data returns nothing
         */
    }
}
