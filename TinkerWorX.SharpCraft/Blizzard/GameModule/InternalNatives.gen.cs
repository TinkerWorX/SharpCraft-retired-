using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static partial class InternalNatives
    {
        //native ConvertRace takes integer i returns race
        public delegate JassRace ConvertRacePrototype(JassInteger i);
        private static ConvertRacePrototype _ConvertRace;
        public static JassRace ConvertRace(JassInteger i)
        {
            return InternalNatives._ConvertRace(i);
        }
        
        //native ConvertAllianceType takes integer i returns alliancetype
        public delegate JassAllianceType ConvertAllianceTypePrototype(JassInteger i);
        private static ConvertAllianceTypePrototype _ConvertAllianceType;
        public static JassAllianceType ConvertAllianceType(JassInteger i)
        {
            return InternalNatives._ConvertAllianceType(i);
        }
        
        //native ConvertRacePref takes integer i returns racepreference
        public delegate JassRacePreference ConvertRacePrefPrototype(JassInteger i);
        private static ConvertRacePrefPrototype _ConvertRacePref;
        public static JassRacePreference ConvertRacePref(JassInteger i)
        {
            return InternalNatives._ConvertRacePref(i);
        }
        
        //native ConvertIGameState takes integer i returns igamestate
        public delegate JassIGameState ConvertIGameStatePrototype(JassInteger i);
        private static ConvertIGameStatePrototype _ConvertIGameState;
        public static JassIGameState ConvertIGameState(JassInteger i)
        {
            return InternalNatives._ConvertIGameState(i);
        }
        
        //native ConvertFGameState takes integer i returns fgamestate
        public delegate JassFGameState ConvertFGameStatePrototype(JassInteger i);
        private static ConvertFGameStatePrototype _ConvertFGameState;
        public static JassFGameState ConvertFGameState(JassInteger i)
        {
            return InternalNatives._ConvertFGameState(i);
        }
        
        //native ConvertPlayerState takes integer i returns playerstate
        public delegate JassPlayerState ConvertPlayerStatePrototype(JassInteger i);
        private static ConvertPlayerStatePrototype _ConvertPlayerState;
        public static JassPlayerState ConvertPlayerState(JassInteger i)
        {
            return InternalNatives._ConvertPlayerState(i);
        }
        
        //native ConvertPlayerScore takes integer i returns playerscore
        public delegate JassPlayerScore ConvertPlayerScorePrototype(JassInteger i);
        private static ConvertPlayerScorePrototype _ConvertPlayerScore;
        public static JassPlayerScore ConvertPlayerScore(JassInteger i)
        {
            return InternalNatives._ConvertPlayerScore(i);
        }
        
        //native ConvertPlayerGameResult takes integer i returns playergameresult
        public delegate JassPlayerGameResult ConvertPlayerGameResultPrototype(JassInteger i);
        private static ConvertPlayerGameResultPrototype _ConvertPlayerGameResult;
        public static JassPlayerGameResult ConvertPlayerGameResult(JassInteger i)
        {
            return InternalNatives._ConvertPlayerGameResult(i);
        }
        
        //native ConvertUnitState takes integer i returns unitstate
        public delegate JassUnitState ConvertUnitStatePrototype(JassInteger i);
        private static ConvertUnitStatePrototype _ConvertUnitState;
        public static JassUnitState ConvertUnitState(JassInteger i)
        {
            return InternalNatives._ConvertUnitState(i);
        }
        
        //native ConvertAIDifficulty takes integer i returns aidifficulty
        public delegate JassAIDifficulty ConvertAIDifficultyPrototype(JassInteger i);
        private static ConvertAIDifficultyPrototype _ConvertAIDifficulty;
        public static JassAIDifficulty ConvertAIDifficulty(JassInteger i)
        {
            return InternalNatives._ConvertAIDifficulty(i);
        }
        
        //native ConvertGameEvent takes integer i returns gameevent
        public delegate JassGameEvent ConvertGameEventPrototype(JassInteger i);
        private static ConvertGameEventPrototype _ConvertGameEvent;
        public static JassGameEvent ConvertGameEvent(JassInteger i)
        {
            return InternalNatives._ConvertGameEvent(i);
        }
        
        //native ConvertPlayerEvent takes integer i returns playerevent
        public delegate JassPlayerEvent ConvertPlayerEventPrototype(JassInteger i);
        private static ConvertPlayerEventPrototype _ConvertPlayerEvent;
        public static JassPlayerEvent ConvertPlayerEvent(JassInteger i)
        {
            return InternalNatives._ConvertPlayerEvent(i);
        }
        
        //native ConvertPlayerUnitEvent takes integer i returns playerunitevent
        public delegate JassPlayerUnitEvent ConvertPlayerUnitEventPrototype(JassInteger i);
        private static ConvertPlayerUnitEventPrototype _ConvertPlayerUnitEvent;
        public static JassPlayerUnitEvent ConvertPlayerUnitEvent(JassInteger i)
        {
            return InternalNatives._ConvertPlayerUnitEvent(i);
        }
        
        //native ConvertWidgetEvent takes integer i returns widgetevent
        public delegate JassWidgetEvent ConvertWidgetEventPrototype(JassInteger i);
        private static ConvertWidgetEventPrototype _ConvertWidgetEvent;
        public static JassWidgetEvent ConvertWidgetEvent(JassInteger i)
        {
            return InternalNatives._ConvertWidgetEvent(i);
        }
        
        //native ConvertDialogEvent takes integer i returns dialogevent
        public delegate JassDialogEvent ConvertDialogEventPrototype(JassInteger i);
        private static ConvertDialogEventPrototype _ConvertDialogEvent;
        public static JassDialogEvent ConvertDialogEvent(JassInteger i)
        {
            return InternalNatives._ConvertDialogEvent(i);
        }
        
        //native ConvertUnitEvent takes integer i returns unitevent
        public delegate JassUnitEvent ConvertUnitEventPrototype(JassInteger i);
        private static ConvertUnitEventPrototype _ConvertUnitEvent;
        public static JassUnitEvent ConvertUnitEvent(JassInteger i)
        {
            return InternalNatives._ConvertUnitEvent(i);
        }
        
        //native ConvertLimitOp takes integer i returns limitop
        public delegate JassLimitOp ConvertLimitOpPrototype(JassInteger i);
        private static ConvertLimitOpPrototype _ConvertLimitOp;
        public static JassLimitOp ConvertLimitOp(JassInteger i)
        {
            return InternalNatives._ConvertLimitOp(i);
        }
        
        //native ConvertUnitType takes integer i returns unittype
        public delegate JassUnitType ConvertUnitTypePrototype(JassInteger i);
        private static ConvertUnitTypePrototype _ConvertUnitType;
        public static JassUnitType ConvertUnitType(JassInteger i)
        {
            return InternalNatives._ConvertUnitType(i);
        }
        
        //native ConvertGameSpeed takes integer i returns gamespeed
        public delegate JassGameSpeed ConvertGameSpeedPrototype(JassInteger i);
        private static ConvertGameSpeedPrototype _ConvertGameSpeed;
        public static JassGameSpeed ConvertGameSpeed(JassInteger i)
        {
            return InternalNatives._ConvertGameSpeed(i);
        }
        
        //native ConvertPlacement takes integer i returns placement
        public delegate JassPlacement ConvertPlacementPrototype(JassInteger i);
        private static ConvertPlacementPrototype _ConvertPlacement;
        public static JassPlacement ConvertPlacement(JassInteger i)
        {
            return InternalNatives._ConvertPlacement(i);
        }
        
        //native ConvertStartLocPrio takes integer i returns startlocprio
        public delegate JassStartLocationPriority ConvertStartLocPrioPrototype(JassInteger i);
        private static ConvertStartLocPrioPrototype _ConvertStartLocPrio;
        public static JassStartLocationPriority ConvertStartLocPrio(JassInteger i)
        {
            return InternalNatives._ConvertStartLocPrio(i);
        }
        
        //native ConvertGameDifficulty takes integer i returns gamedifficulty
        public delegate JassGameDifficulty ConvertGameDifficultyPrototype(JassInteger i);
        private static ConvertGameDifficultyPrototype _ConvertGameDifficulty;
        public static JassGameDifficulty ConvertGameDifficulty(JassInteger i)
        {
            return InternalNatives._ConvertGameDifficulty(i);
        }
        
        //native ConvertGameType takes integer i returns gametype
        public delegate JassGameType ConvertGameTypePrototype(JassInteger i);
        private static ConvertGameTypePrototype _ConvertGameType;
        public static JassGameType ConvertGameType(JassInteger i)
        {
            return InternalNatives._ConvertGameType(i);
        }
        
        //native ConvertMapFlag takes integer i returns mapflag
        public delegate JassMapFlag ConvertMapFlagPrototype(JassInteger i);
        private static ConvertMapFlagPrototype _ConvertMapFlag;
        public static JassMapFlag ConvertMapFlag(JassInteger i)
        {
            return InternalNatives._ConvertMapFlag(i);
        }
        
        //native ConvertMapVisibility takes integer i returns mapvisibility
        public delegate JassMapVisibility ConvertMapVisibilityPrototype(JassInteger i);
        private static ConvertMapVisibilityPrototype _ConvertMapVisibility;
        public static JassMapVisibility ConvertMapVisibility(JassInteger i)
        {
            return InternalNatives._ConvertMapVisibility(i);
        }
        
        //native ConvertMapSetting takes integer i returns mapsetting
        public delegate JassMapSetting ConvertMapSettingPrototype(JassInteger i);
        private static ConvertMapSettingPrototype _ConvertMapSetting;
        public static JassMapSetting ConvertMapSetting(JassInteger i)
        {
            return InternalNatives._ConvertMapSetting(i);
        }
        
        //native ConvertMapDensity takes integer i returns mapdensity
        public delegate JassMapDensity ConvertMapDensityPrototype(JassInteger i);
        private static ConvertMapDensityPrototype _ConvertMapDensity;
        public static JassMapDensity ConvertMapDensity(JassInteger i)
        {
            return InternalNatives._ConvertMapDensity(i);
        }
        
        //native ConvertMapControl takes integer i returns mapcontrol
        public delegate JassMapControl ConvertMapControlPrototype(JassInteger i);
        private static ConvertMapControlPrototype _ConvertMapControl;
        public static JassMapControl ConvertMapControl(JassInteger i)
        {
            return InternalNatives._ConvertMapControl(i);
        }
        
        //native ConvertPlayerColor takes integer i returns playercolor
        public delegate JassPlayerColor ConvertPlayerColorPrototype(JassInteger i);
        private static ConvertPlayerColorPrototype _ConvertPlayerColor;
        public static JassPlayerColor ConvertPlayerColor(JassInteger i)
        {
            return InternalNatives._ConvertPlayerColor(i);
        }
        
        //native ConvertPlayerSlotState takes integer i returns playerslotstate
        public delegate JassPlayerSlotState ConvertPlayerSlotStatePrototype(JassInteger i);
        private static ConvertPlayerSlotStatePrototype _ConvertPlayerSlotState;
        public static JassPlayerSlotState ConvertPlayerSlotState(JassInteger i)
        {
            return InternalNatives._ConvertPlayerSlotState(i);
        }
        
        //native ConvertVolumeGroup takes integer i returns volumegroup
        public delegate JassVolumeGroup ConvertVolumeGroupPrototype(JassInteger i);
        private static ConvertVolumeGroupPrototype _ConvertVolumeGroup;
        public static JassVolumeGroup ConvertVolumeGroup(JassInteger i)
        {
            return InternalNatives._ConvertVolumeGroup(i);
        }
        
        //native ConvertCameraField takes integer i returns camerafield
        public delegate JassCameraField ConvertCameraFieldPrototype(JassInteger i);
        private static ConvertCameraFieldPrototype _ConvertCameraField;
        public static JassCameraField ConvertCameraField(JassInteger i)
        {
            return InternalNatives._ConvertCameraField(i);
        }
        
        //native ConvertBlendMode takes integer i returns blendmode
        public delegate JassBlendMode ConvertBlendModePrototype(JassInteger i);
        private static ConvertBlendModePrototype _ConvertBlendMode;
        public static JassBlendMode ConvertBlendMode(JassInteger i)
        {
            return InternalNatives._ConvertBlendMode(i);
        }
        
        //native ConvertRarityControl takes integer i returns raritycontrol
        public delegate JassRarityControl ConvertRarityControlPrototype(JassInteger i);
        private static ConvertRarityControlPrototype _ConvertRarityControl;
        public static JassRarityControl ConvertRarityControl(JassInteger i)
        {
            return InternalNatives._ConvertRarityControl(i);
        }
        
        //native ConvertTexMapFlags takes integer i returns texmapflags
        public delegate JassTextureMapFlags ConvertTexMapFlagsPrototype(JassInteger i);
        private static ConvertTexMapFlagsPrototype _ConvertTexMapFlags;
        public static JassTextureMapFlags ConvertTexMapFlags(JassInteger i)
        {
            return InternalNatives._ConvertTexMapFlags(i);
        }
        
        //native ConvertFogState takes integer i returns fogstate
        public delegate JassFogState ConvertFogStatePrototype(JassInteger i);
        private static ConvertFogStatePrototype _ConvertFogState;
        public static JassFogState ConvertFogState(JassInteger i)
        {
            return InternalNatives._ConvertFogState(i);
        }
        
        //native ConvertEffectType takes integer i returns effecttype
        public delegate JassEffectType ConvertEffectTypePrototype(JassInteger i);
        private static ConvertEffectTypePrototype _ConvertEffectType;
        public static JassEffectType ConvertEffectType(JassInteger i)
        {
            return InternalNatives._ConvertEffectType(i);
        }
        
        //native ConvertVersion takes integer i returns version
        public delegate JassVersion ConvertVersionPrototype(JassInteger i);
        private static ConvertVersionPrototype _ConvertVersion;
        public static JassVersion ConvertVersion(JassInteger i)
        {
            return InternalNatives._ConvertVersion(i);
        }
        
        //native ConvertItemType takes integer i returns itemtype
        public delegate JassItemType ConvertItemTypePrototype(JassInteger i);
        private static ConvertItemTypePrototype _ConvertItemType;
        public static JassItemType ConvertItemType(JassInteger i)
        {
            return InternalNatives._ConvertItemType(i);
        }
        
        //native ConvertAttackType takes integer i returns attacktype
        public delegate JassAttackType ConvertAttackTypePrototype(JassInteger i);
        private static ConvertAttackTypePrototype _ConvertAttackType;
        public static JassAttackType ConvertAttackType(JassInteger i)
        {
            return InternalNatives._ConvertAttackType(i);
        }
        
        //native ConvertDamageType takes integer i returns damagetype
        public delegate JassDamageType ConvertDamageTypePrototype(JassInteger i);
        private static ConvertDamageTypePrototype _ConvertDamageType;
        public static JassDamageType ConvertDamageType(JassInteger i)
        {
            return InternalNatives._ConvertDamageType(i);
        }
        
        //native ConvertWeaponType takes integer i returns weapontype
        public delegate JassWeaponType ConvertWeaponTypePrototype(JassInteger i);
        private static ConvertWeaponTypePrototype _ConvertWeaponType;
        public static JassWeaponType ConvertWeaponType(JassInteger i)
        {
            return InternalNatives._ConvertWeaponType(i);
        }
        
        //native ConvertSoundType takes integer i returns soundtype
        public delegate JassSoundType ConvertSoundTypePrototype(JassInteger i);
        private static ConvertSoundTypePrototype _ConvertSoundType;
        public static JassSoundType ConvertSoundType(JassInteger i)
        {
            return InternalNatives._ConvertSoundType(i);
        }
        
        //native ConvertPathingType takes integer i returns pathingtype
        public delegate JassPathingType ConvertPathingTypePrototype(JassInteger i);
        private static ConvertPathingTypePrototype _ConvertPathingType;
        public static JassPathingType ConvertPathingType(JassInteger i)
        {
            return InternalNatives._ConvertPathingType(i);
        }
        
        //native OrderId takes string orderIdString returns integer
        public delegate JassOrder OrderIdPrototype(String orderIdString);
        private static OrderIdPrototype _OrderId;
        public static JassOrder OrderId(String orderIdString)
        {
            return InternalNatives._OrderId(orderIdString);
        }
        
        //native OrderId2String takes integer orderId returns string
        public delegate String OrderId2StringPrototype(JassOrder orderId);
        private static OrderId2StringPrototype _OrderId2String;
        public static String OrderId2String(JassOrder orderId)
        {
            return InternalNatives._OrderId2String(orderId);
        }
        
        //native UnitId takes string unitIdString returns integer
        public delegate JassObjectId UnitIdPrototype(String unitIdString);
        private static UnitIdPrototype _UnitId;
        public static JassObjectId UnitId(String unitIdString)
        {
            return InternalNatives._UnitId(unitIdString);
        }
        
        //native UnitId2String takes integer unitId returns string
        public delegate String UnitId2StringPrototype(JassObjectId unitId);
        private static UnitId2StringPrototype _UnitId2String;
        public static String UnitId2String(JassObjectId unitId)
        {
            return InternalNatives._UnitId2String(unitId);
        }
        
        //native AbilityId takes string abilityIdString returns integer
        public delegate JassObjectId AbilityIdPrototype(String abilityIdString);
        private static AbilityIdPrototype _AbilityId;
        public static JassObjectId AbilityId(String abilityIdString)
        {
            return InternalNatives._AbilityId(abilityIdString);
        }
        
        //native AbilityId2String takes integer abilityId returns string
        public delegate String AbilityId2StringPrototype(JassInteger abilityId);
        private static AbilityId2StringPrototype _AbilityId2String;
        public static String AbilityId2String(JassInteger abilityId)
        {
            return InternalNatives._AbilityId2String(abilityId);
        }
        
        //native GetObjectName takes integer objectId returns string
        public delegate String GetObjectNamePrototype(JassObjectId objectId);
        private static GetObjectNamePrototype _GetObjectName;
        public static String GetObjectName(JassObjectId objectId)
        {
            return InternalNatives._GetObjectName(objectId);
        }
        
        //native Deg2Rad takes real degrees returns real
        public delegate JassRealRet Deg2RadPrototype(JassRealArg degrees);
        private static Deg2RadPrototype _Deg2Rad;
        public static Single Deg2Rad(Single degrees)
        {
            return InternalNatives._Deg2Rad(degrees);
        }
        
        //native Rad2Deg takes real radians returns real
        public delegate JassRealRet Rad2DegPrototype(JassRealArg radians);
        private static Rad2DegPrototype _Rad2Deg;
        public static Single Rad2Deg(Single radians)
        {
            return InternalNatives._Rad2Deg(radians);
        }
        
        //native Sin takes real radians returns real
        public delegate JassRealRet SinPrototype(JassRealArg radians);
        private static SinPrototype _Sin;
        public static Single Sin(Single radians)
        {
            return InternalNatives._Sin(radians);
        }
        
        //native Cos takes real radians returns real
        public delegate JassRealRet CosPrototype(JassRealArg radians);
        private static CosPrototype _Cos;
        public static Single Cos(Single radians)
        {
            return InternalNatives._Cos(radians);
        }
        
        //native Tan takes real radians returns real
        public delegate JassRealRet TanPrototype(JassRealArg radians);
        private static TanPrototype _Tan;
        public static Single Tan(Single radians)
        {
            return InternalNatives._Tan(radians);
        }
        
        //native Asin takes real y returns real
        public delegate JassRealRet AsinPrototype(JassRealArg y);
        private static AsinPrototype _Asin;
        public static Single Asin(Single y)
        {
            return InternalNatives._Asin(y);
        }
        
        //native Acos takes real x returns real
        public delegate JassRealRet AcosPrototype(JassRealArg x);
        private static AcosPrototype _Acos;
        public static Single Acos(Single x)
        {
            return InternalNatives._Acos(x);
        }
        
        //native Atan takes real x returns real
        public delegate JassRealRet AtanPrototype(JassRealArg x);
        private static AtanPrototype _Atan;
        public static Single Atan(Single x)
        {
            return InternalNatives._Atan(x);
        }
        
        //native Atan2 takes real y, real x returns real
        public delegate JassRealRet Atan2Prototype(JassRealArg y, JassRealArg x);
        private static Atan2Prototype _Atan2;
        public static Single Atan2(Single y, Single x)
        {
            return InternalNatives._Atan2(y, x);
        }
        
        //native SquareRoot takes real x returns real
        public delegate JassRealRet SquareRootPrototype(JassRealArg x);
        private static SquareRootPrototype _SquareRoot;
        public static Single SquareRoot(Single x)
        {
            return InternalNatives._SquareRoot(x);
        }
        
        //native Pow takes real x, real power returns real
        public delegate JassRealRet PowPrototype(JassRealArg x, JassRealArg power);
        private static PowPrototype _Pow;
        public static Single Pow(Single x, Single power)
        {
            return InternalNatives._Pow(x, power);
        }
        
        //native I2R takes integer i returns real
        public delegate JassRealRet I2RPrototype(JassInteger i);
        private static I2RPrototype _I2R;
        public static Single I2R(JassInteger i)
        {
            return InternalNatives._I2R(i);
        }
        
        //native R2I takes real r returns integer
        public delegate JassInteger R2IPrototype(JassRealArg r);
        private static R2IPrototype _R2I;
        public static JassInteger R2I(Single r)
        {
            return InternalNatives._R2I(r);
        }
        
        //native I2S takes integer i returns string
        public delegate String I2SPrototype(JassInteger i);
        private static I2SPrototype _I2S;
        public static String I2S(JassInteger i)
        {
            return InternalNatives._I2S(i);
        }
        
        //native R2S takes real r returns string
        public delegate String R2SPrototype(JassRealArg r);
        private static R2SPrototype _R2S;
        public static String R2S(Single r)
        {
            return InternalNatives._R2S(r);
        }
        
        //native R2SW takes real r, integer width, integer precision returns string
        public delegate String R2SWPrototype(JassRealArg r, JassInteger width, JassInteger precision);
        private static R2SWPrototype _R2SW;
        public static String R2SW(Single r, JassInteger width, JassInteger precision)
        {
            return InternalNatives._R2SW(r, width, precision);
        }
        
        //native S2I takes string s returns integer
        public delegate JassInteger S2IPrototype(String s);
        private static S2IPrototype _S2I;
        public static JassInteger S2I(String s)
        {
            return InternalNatives._S2I(s);
        }
        
        //native S2R takes string s returns real
        public delegate JassRealRet S2RPrototype(String s);
        private static S2RPrototype _S2R;
        public static Single S2R(String s)
        {
            return InternalNatives._S2R(s);
        }
        
        //native GetHandleId takes handle h returns integer
        public delegate JassInteger GetHandleIdPrototype(JassHandle h);
        private static GetHandleIdPrototype _GetHandleId;
        public static JassInteger GetHandleId(JassHandle h)
        {
            return InternalNatives._GetHandleId(h);
        }
        
        //native SubString takes string source, integer start, integer end returns string
        public delegate String SubStringPrototype(String source, JassInteger start, JassInteger end);
        private static SubStringPrototype _SubString;
        public static String SubString(String source, JassInteger start, JassInteger end)
        {
            return InternalNatives._SubString(source, start, end);
        }
        
        //native StringLength takes string s returns integer
        public delegate JassInteger StringLengthPrototype(String s);
        private static StringLengthPrototype _StringLength;
        public static JassInteger StringLength(String s)
        {
            return InternalNatives._StringLength(s);
        }
        
        //native StringCase takes string source, boolean upper returns string
        public delegate String StringCasePrototype(String source, JassBoolean upper);
        private static StringCasePrototype _StringCase;
        public static String StringCase(String source, Boolean upper)
        {
            return InternalNatives._StringCase(source, upper);
        }
        
        //native StringHash takes string s returns integer
        public delegate JassInteger StringHashPrototype(String s);
        private static StringHashPrototype _StringHash;
        public static JassInteger StringHash(String s)
        {
            return InternalNatives._StringHash(s);
        }
        
        //native GetLocalizedString takes string source returns string
        public delegate String GetLocalizedStringPrototype(String source);
        private static GetLocalizedStringPrototype _GetLocalizedString;
        public static String GetLocalizedString(String source)
        {
            return InternalNatives._GetLocalizedString(source);
        }
        
        //native GetLocalizedHotkey takes string source returns integer
        public delegate JassInteger GetLocalizedHotkeyPrototype(String source);
        private static GetLocalizedHotkeyPrototype _GetLocalizedHotkey;
        public static JassInteger GetLocalizedHotkey(String source)
        {
            return InternalNatives._GetLocalizedHotkey(source);
        }
        
        //native SetMapName takes string name returns nothing
        public delegate void SetMapNamePrototype(String name);
        private static SetMapNamePrototype _SetMapName;
        public static void SetMapName(String name)
        {
            InternalNatives._SetMapName(name);
        }
        
        //native SetMapDescription takes string description returns nothing
        public delegate void SetMapDescriptionPrototype(String description);
        private static SetMapDescriptionPrototype _SetMapDescription;
        public static void SetMapDescription(String description)
        {
            InternalNatives._SetMapDescription(description);
        }
        
        //native SetTeams takes integer teamcount returns nothing
        public delegate void SetTeamsPrototype(JassInteger teamcount);
        private static SetTeamsPrototype _SetTeams;
        public static void SetTeams(JassInteger teamcount)
        {
            InternalNatives._SetTeams(teamcount);
        }
        
        //native SetPlayers takes integer playercount returns nothing
        public delegate void SetPlayersPrototype(JassInteger playercount);
        private static SetPlayersPrototype _SetPlayers;
        public static void SetPlayers(JassInteger playercount)
        {
            InternalNatives._SetPlayers(playercount);
        }
        
        //native DefineStartLocation takes integer whichStartLoc, real x, real y returns nothing
        public delegate void DefineStartLocationPrototype(JassInteger whichStartLoc, JassRealArg x, JassRealArg y);
        private static DefineStartLocationPrototype _DefineStartLocation;
        public static void DefineStartLocation(JassInteger whichStartLoc, Single x, Single y)
        {
            InternalNatives._DefineStartLocation(whichStartLoc, x, y);
        }
        
        //native DefineStartLocationLoc takes integer whichStartLoc, location whichLocation returns nothing
        public delegate void DefineStartLocationLocPrototype(JassInteger whichStartLoc, JassLocation whichLocation);
        private static DefineStartLocationLocPrototype _DefineStartLocationLoc;
        public static void DefineStartLocationLoc(JassInteger whichStartLoc, JassLocation whichLocation)
        {
            InternalNatives._DefineStartLocationLoc(whichStartLoc, whichLocation);
        }
        
        //native SetStartLocPrioCount takes integer whichStartLoc, integer prioSlotCount returns nothing
        public delegate void SetStartLocPrioCountPrototype(JassInteger whichStartLoc, JassInteger prioSlotCount);
        private static SetStartLocPrioCountPrototype _SetStartLocPrioCount;
        public static void SetStartLocPrioCount(JassInteger whichStartLoc, JassInteger prioSlotCount)
        {
            InternalNatives._SetStartLocPrioCount(whichStartLoc, prioSlotCount);
        }
        
        //native SetStartLocPrio takes integer whichStartLoc, integer prioSlotIndex, integer otherStartLocIndex, startlocprio priority returns nothing
        public delegate void SetStartLocPrioPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority);
        private static SetStartLocPrioPrototype _SetStartLocPrio;
        public static void SetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority)
        {
            InternalNatives._SetStartLocPrio(whichStartLoc, prioSlotIndex, otherStartLocIndex, priority);
        }
        
        //native GetStartLocPrioSlot takes integer whichStartLoc, integer prioSlotIndex returns integer
        public delegate JassInteger GetStartLocPrioSlotPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex);
        private static GetStartLocPrioSlotPrototype _GetStartLocPrioSlot;
        public static JassInteger GetStartLocPrioSlot(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return InternalNatives._GetStartLocPrioSlot(whichStartLoc, prioSlotIndex);
        }
        
        //native GetStartLocPrio takes integer whichStartLoc, integer prioSlotIndex returns startlocprio
        public delegate JassStartLocationPriority GetStartLocPrioPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex);
        private static GetStartLocPrioPrototype _GetStartLocPrio;
        public static JassStartLocationPriority GetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return InternalNatives._GetStartLocPrio(whichStartLoc, prioSlotIndex);
        }
        
        //native SetGameTypeSupported takes gametype whichGameType, boolean value returns nothing
        public delegate void SetGameTypeSupportedPrototype(JassGameType whichGameType, JassBoolean value);
        private static SetGameTypeSupportedPrototype _SetGameTypeSupported;
        public static void SetGameTypeSupported(JassGameType whichGameType, Boolean value)
        {
            InternalNatives._SetGameTypeSupported(whichGameType, value);
        }
        
        //native SetMapFlag takes mapflag whichMapFlag, boolean value returns nothing
        public delegate void SetMapFlagPrototype(JassMapFlag whichMapFlag, JassBoolean value);
        private static SetMapFlagPrototype _SetMapFlag;
        public static void SetMapFlag(JassMapFlag whichMapFlag, Boolean value)
        {
            InternalNatives._SetMapFlag(whichMapFlag, value);
        }
        
        //native SetGamePlacement takes placement whichPlacementType returns nothing
        public delegate void SetGamePlacementPrototype(JassPlacement whichPlacementType);
        private static SetGamePlacementPrototype _SetGamePlacement;
        public static void SetGamePlacement(JassPlacement whichPlacementType)
        {
            InternalNatives._SetGamePlacement(whichPlacementType);
        }
        
        //native SetGameSpeed takes gamespeed whichspeed returns nothing
        public delegate void SetGameSpeedPrototype(JassGameSpeed whichspeed);
        private static SetGameSpeedPrototype _SetGameSpeed;
        public static void SetGameSpeed(JassGameSpeed whichspeed)
        {
            InternalNatives._SetGameSpeed(whichspeed);
        }
        
        //native SetGameDifficulty takes gamedifficulty whichdifficulty returns nothing
        public delegate void SetGameDifficultyPrototype(JassGameDifficulty whichdifficulty);
        private static SetGameDifficultyPrototype _SetGameDifficulty;
        public static void SetGameDifficulty(JassGameDifficulty whichdifficulty)
        {
            InternalNatives._SetGameDifficulty(whichdifficulty);
        }
        
        //native SetResourceDensity takes mapdensity whichdensity returns nothing
        public delegate void SetResourceDensityPrototype(JassMapDensity whichdensity);
        private static SetResourceDensityPrototype _SetResourceDensity;
        public static void SetResourceDensity(JassMapDensity whichdensity)
        {
            InternalNatives._SetResourceDensity(whichdensity);
        }
        
        //native SetCreatureDensity takes mapdensity whichdensity returns nothing
        public delegate void SetCreatureDensityPrototype(JassMapDensity whichdensity);
        private static SetCreatureDensityPrototype _SetCreatureDensity;
        public static void SetCreatureDensity(JassMapDensity whichdensity)
        {
            InternalNatives._SetCreatureDensity(whichdensity);
        }
        
        //native GetTeams takes nothing returns integer
        public delegate JassInteger GetTeamsPrototype();
        private static GetTeamsPrototype _GetTeams;
        public static JassInteger GetTeams()
        {
            return InternalNatives._GetTeams();
        }
        
        //native GetPlayers takes nothing returns integer
        public delegate JassInteger GetPlayersPrototype();
        private static GetPlayersPrototype _GetPlayers;
        public static JassInteger GetPlayers()
        {
            return InternalNatives._GetPlayers();
        }
        
        //native IsGameTypeSupported takes gametype whichGameType returns boolean
        public delegate JassBoolean IsGameTypeSupportedPrototype(JassGameType whichGameType);
        private static IsGameTypeSupportedPrototype _IsGameTypeSupported;
        public static Boolean IsGameTypeSupported(JassGameType whichGameType)
        {
            return InternalNatives._IsGameTypeSupported(whichGameType);
        }
        
        //native GetGameTypeSelected takes nothing returns gametype
        public delegate JassGameType GetGameTypeSelectedPrototype();
        private static GetGameTypeSelectedPrototype _GetGameTypeSelected;
        public static JassGameType GetGameTypeSelected()
        {
            return InternalNatives._GetGameTypeSelected();
        }
        
        //native IsMapFlagSet takes mapflag whichMapFlag returns boolean
        public delegate JassBoolean IsMapFlagSetPrototype(JassMapFlag whichMapFlag);
        private static IsMapFlagSetPrototype _IsMapFlagSet;
        public static Boolean IsMapFlagSet(JassMapFlag whichMapFlag)
        {
            return InternalNatives._IsMapFlagSet(whichMapFlag);
        }
        
        //native GetGamePlacement takes nothing returns placement
        public delegate JassPlacement GetGamePlacementPrototype();
        private static GetGamePlacementPrototype _GetGamePlacement;
        public static JassPlacement GetGamePlacement()
        {
            return InternalNatives._GetGamePlacement();
        }
        
        //native GetGameSpeed takes nothing returns gamespeed
        public delegate JassGameSpeed GetGameSpeedPrototype();
        private static GetGameSpeedPrototype _GetGameSpeed;
        public static JassGameSpeed GetGameSpeed()
        {
            return InternalNatives._GetGameSpeed();
        }
        
        //native GetGameDifficulty takes nothing returns gamedifficulty
        public delegate JassGameDifficulty GetGameDifficultyPrototype();
        private static GetGameDifficultyPrototype _GetGameDifficulty;
        public static JassGameDifficulty GetGameDifficulty()
        {
            return InternalNatives._GetGameDifficulty();
        }
        
        //native GetResourceDensity takes nothing returns mapdensity
        public delegate JassMapDensity GetResourceDensityPrototype();
        private static GetResourceDensityPrototype _GetResourceDensity;
        public static JassMapDensity GetResourceDensity()
        {
            return InternalNatives._GetResourceDensity();
        }
        
        //native GetCreatureDensity takes nothing returns mapdensity
        public delegate JassMapDensity GetCreatureDensityPrototype();
        private static GetCreatureDensityPrototype _GetCreatureDensity;
        public static JassMapDensity GetCreatureDensity()
        {
            return InternalNatives._GetCreatureDensity();
        }
        
        //native GetStartLocationX takes integer whichStartLocation returns real
        public delegate JassRealRet GetStartLocationXPrototype(JassInteger whichStartLocation);
        private static GetStartLocationXPrototype _GetStartLocationX;
        public static Single GetStartLocationX(JassInteger whichStartLocation)
        {
            return InternalNatives._GetStartLocationX(whichStartLocation);
        }
        
        //native GetStartLocationY takes integer whichStartLocation returns real
        public delegate JassRealRet GetStartLocationYPrototype(JassInteger whichStartLocation);
        private static GetStartLocationYPrototype _GetStartLocationY;
        public static Single GetStartLocationY(JassInteger whichStartLocation)
        {
            return InternalNatives._GetStartLocationY(whichStartLocation);
        }
        
        //native GetStartLocationLoc takes integer whichStartLocation returns location
        public delegate JassLocation GetStartLocationLocPrototype(JassInteger whichStartLocation);
        private static GetStartLocationLocPrototype _GetStartLocationLoc;
        public static JassLocation GetStartLocationLoc(JassInteger whichStartLocation)
        {
            return InternalNatives._GetStartLocationLoc(whichStartLocation);
        }
        
        //native SetPlayerTeam takes player whichPlayer, integer whichTeam returns nothing
        public delegate void SetPlayerTeamPrototype(JassPlayer whichPlayer, JassInteger whichTeam);
        private static SetPlayerTeamPrototype _SetPlayerTeam;
        public static void SetPlayerTeam(JassPlayer whichPlayer, JassInteger whichTeam)
        {
            InternalNatives._SetPlayerTeam(whichPlayer, whichTeam);
        }
        
        //native SetPlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
        public delegate void SetPlayerStartLocationPrototype(JassPlayer whichPlayer, JassInteger startLocIndex);
        private static SetPlayerStartLocationPrototype _SetPlayerStartLocation;
        public static void SetPlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            InternalNatives._SetPlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        //native ForcePlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
        public delegate void ForcePlayerStartLocationPrototype(JassPlayer whichPlayer, JassInteger startLocIndex);
        private static ForcePlayerStartLocationPrototype _ForcePlayerStartLocation;
        public static void ForcePlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            InternalNatives._ForcePlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        //native SetPlayerColor takes player whichPlayer, playercolor color returns nothing
        public delegate void SetPlayerColorPrototype(JassPlayer whichPlayer, JassPlayerColor color);
        private static SetPlayerColorPrototype _SetPlayerColor;
        public static void SetPlayerColor(JassPlayer whichPlayer, JassPlayerColor color)
        {
            InternalNatives._SetPlayerColor(whichPlayer, color);
        }
        
        //native SetPlayerAlliance takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, boolean value returns nothing
        public delegate void SetPlayerAlliancePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, JassBoolean value);
        private static SetPlayerAlliancePrototype _SetPlayerAlliance;
        public static void SetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, Boolean value)
        {
            InternalNatives._SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);
        }
        
        //native SetPlayerTaxRate takes player sourcePlayer, player otherPlayer, playerstate whichResource, integer rate returns nothing
        public delegate void SetPlayerTaxRatePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate);
        private static SetPlayerTaxRatePrototype _SetPlayerTaxRate;
        public static void SetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate)
        {
            InternalNatives._SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);
        }
        
        //native SetPlayerRacePreference takes player whichPlayer, racepreference whichRacePreference returns nothing
        public delegate void SetPlayerRacePreferencePrototype(JassPlayer whichPlayer, JassRacePreference whichRacePreference);
        private static SetPlayerRacePreferencePrototype _SetPlayerRacePreference;
        public static void SetPlayerRacePreference(JassPlayer whichPlayer, JassRacePreference whichRacePreference)
        {
            InternalNatives._SetPlayerRacePreference(whichPlayer, whichRacePreference);
        }
        
        //native SetPlayerRaceSelectable takes player whichPlayer, boolean value returns nothing
        public delegate void SetPlayerRaceSelectablePrototype(JassPlayer whichPlayer, JassBoolean value);
        private static SetPlayerRaceSelectablePrototype _SetPlayerRaceSelectable;
        public static void SetPlayerRaceSelectable(JassPlayer whichPlayer, Boolean value)
        {
            InternalNatives._SetPlayerRaceSelectable(whichPlayer, value);
        }
        
        //native SetPlayerController takes player whichPlayer, mapcontrol controlType returns nothing
        public delegate void SetPlayerControllerPrototype(JassPlayer whichPlayer, JassMapControl controlType);
        private static SetPlayerControllerPrototype _SetPlayerController;
        public static void SetPlayerController(JassPlayer whichPlayer, JassMapControl controlType)
        {
            InternalNatives._SetPlayerController(whichPlayer, controlType);
        }
        
        //native SetPlayerName takes player whichPlayer, string name returns nothing
        public delegate void SetPlayerNamePrototype(JassPlayer whichPlayer, String name);
        private static SetPlayerNamePrototype _SetPlayerName;
        public static void SetPlayerName(JassPlayer whichPlayer, String name)
        {
            InternalNatives._SetPlayerName(whichPlayer, name);
        }
        
        //native SetPlayerOnScoreScreen takes player whichPlayer, boolean flag returns nothing
        public delegate void SetPlayerOnScoreScreenPrototype(JassPlayer whichPlayer, JassBoolean flag);
        private static SetPlayerOnScoreScreenPrototype _SetPlayerOnScoreScreen;
        public static void SetPlayerOnScoreScreen(JassPlayer whichPlayer, Boolean flag)
        {
            InternalNatives._SetPlayerOnScoreScreen(whichPlayer, flag);
        }
        
        //native GetPlayerTeam takes player whichPlayer returns integer
        public delegate JassInteger GetPlayerTeamPrototype(JassPlayer whichPlayer);
        private static GetPlayerTeamPrototype _GetPlayerTeam;
        public static JassInteger GetPlayerTeam(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerTeam(whichPlayer);
        }
        
        //native GetPlayerStartLocation takes player whichPlayer returns integer
        public delegate JassInteger GetPlayerStartLocationPrototype(JassPlayer whichPlayer);
        private static GetPlayerStartLocationPrototype _GetPlayerStartLocation;
        public static JassInteger GetPlayerStartLocation(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerStartLocation(whichPlayer);
        }
        
        //native GetPlayerColor takes player whichPlayer returns playercolor
        public delegate JassPlayerColor GetPlayerColorPrototype(JassPlayer whichPlayer);
        private static GetPlayerColorPrototype _GetPlayerColor;
        public static JassPlayerColor GetPlayerColor(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerColor(whichPlayer);
        }
        
        //native GetPlayerSelectable takes player whichPlayer returns boolean
        public delegate JassBoolean GetPlayerSelectablePrototype(JassPlayer whichPlayer);
        private static GetPlayerSelectablePrototype _GetPlayerSelectable;
        public static Boolean GetPlayerSelectable(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerSelectable(whichPlayer);
        }
        
        //native GetPlayerController takes player whichPlayer returns mapcontrol
        public delegate JassMapControl GetPlayerControllerPrototype(JassPlayer whichPlayer);
        private static GetPlayerControllerPrototype _GetPlayerController;
        public static JassMapControl GetPlayerController(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerController(whichPlayer);
        }
        
        //native GetPlayerSlotState takes player whichPlayer returns playerslotstate
        public delegate JassPlayerSlotState GetPlayerSlotStatePrototype(JassPlayer whichPlayer);
        private static GetPlayerSlotStatePrototype _GetPlayerSlotState;
        public static JassPlayerSlotState GetPlayerSlotState(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerSlotState(whichPlayer);
        }
        
        //native GetPlayerTaxRate takes player sourcePlayer, player otherPlayer, playerstate whichResource returns integer
        public delegate JassInteger GetPlayerTaxRatePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource);
        private static GetPlayerTaxRatePrototype _GetPlayerTaxRate;
        public static JassInteger GetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource)
        {
            return InternalNatives._GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);
        }
        
        //native IsPlayerRacePrefSet takes player whichPlayer, racepreference pref returns boolean
        public delegate JassBoolean IsPlayerRacePrefSetPrototype(JassPlayer whichPlayer, JassRacePreference pref);
        private static IsPlayerRacePrefSetPrototype _IsPlayerRacePrefSet;
        public static Boolean IsPlayerRacePrefSet(JassPlayer whichPlayer, JassRacePreference pref)
        {
            return InternalNatives._IsPlayerRacePrefSet(whichPlayer, pref);
        }
        
        //native GetPlayerName takes player whichPlayer returns string
        public delegate String GetPlayerNamePrototype(JassPlayer whichPlayer);
        private static GetPlayerNamePrototype _GetPlayerName;
        public static String GetPlayerName(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerName(whichPlayer);
        }
        
        //native CreateTimer takes nothing returns timer
        public delegate JassTimer CreateTimerPrototype();
        private static CreateTimerPrototype _CreateTimer;
        public static JassTimer CreateTimer()
        {
            return InternalNatives._CreateTimer();
        }
        
        //native DestroyTimer takes timer whichTimer returns nothing
        public delegate void DestroyTimerPrototype(JassTimer whichTimer);
        private static DestroyTimerPrototype _DestroyTimer;
        public static void DestroyTimer(JassTimer whichTimer)
        {
            InternalNatives._DestroyTimer(whichTimer);
        }
        
        //native TimerStart takes timer whichTimer, real timeout, boolean periodic, code handlerFunc returns nothing
        public delegate void TimerStartPrototype(JassTimer whichTimer, JassRealArg timeout, JassBoolean periodic, JassCode handlerFunc);
        private static TimerStartPrototype _TimerStart;
        public static void TimerStart(JassTimer whichTimer, Single timeout, Boolean periodic, JassCode handlerFunc)
        {
            InternalNatives._TimerStart(whichTimer, timeout, periodic, handlerFunc);
        }
        
        //native TimerGetElapsed takes timer whichTimer returns real
        public delegate JassRealRet TimerGetElapsedPrototype(JassTimer whichTimer);
        private static TimerGetElapsedPrototype _TimerGetElapsed;
        public static Single TimerGetElapsed(JassTimer whichTimer)
        {
            return InternalNatives._TimerGetElapsed(whichTimer);
        }
        
        //native TimerGetRemaining takes timer whichTimer returns real
        public delegate JassRealRet TimerGetRemainingPrototype(JassTimer whichTimer);
        private static TimerGetRemainingPrototype _TimerGetRemaining;
        public static Single TimerGetRemaining(JassTimer whichTimer)
        {
            return InternalNatives._TimerGetRemaining(whichTimer);
        }
        
        //native TimerGetTimeout takes timer whichTimer returns real
        public delegate JassRealRet TimerGetTimeoutPrototype(JassTimer whichTimer);
        private static TimerGetTimeoutPrototype _TimerGetTimeout;
        public static Single TimerGetTimeout(JassTimer whichTimer)
        {
            return InternalNatives._TimerGetTimeout(whichTimer);
        }
        
        //native PauseTimer takes timer whichTimer returns nothing
        public delegate void PauseTimerPrototype(JassTimer whichTimer);
        private static PauseTimerPrototype _PauseTimer;
        public static void PauseTimer(JassTimer whichTimer)
        {
            InternalNatives._PauseTimer(whichTimer);
        }
        
        //native ResumeTimer takes timer whichTimer returns nothing
        public delegate void ResumeTimerPrototype(JassTimer whichTimer);
        private static ResumeTimerPrototype _ResumeTimer;
        public static void ResumeTimer(JassTimer whichTimer)
        {
            InternalNatives._ResumeTimer(whichTimer);
        }
        
        //native GetExpiredTimer takes nothing returns timer
        public delegate JassTimer GetExpiredTimerPrototype();
        private static GetExpiredTimerPrototype _GetExpiredTimer;
        public static JassTimer GetExpiredTimer()
        {
            return InternalNatives._GetExpiredTimer();
        }
        
        //native CreateGroup takes nothing returns group
        public delegate JassGroup CreateGroupPrototype();
        private static CreateGroupPrototype _CreateGroup;
        public static JassGroup CreateGroup()
        {
            return InternalNatives._CreateGroup();
        }
        
        //native DestroyGroup takes group whichGroup returns nothing
        public delegate void DestroyGroupPrototype(JassGroup whichGroup);
        private static DestroyGroupPrototype _DestroyGroup;
        public static void DestroyGroup(JassGroup whichGroup)
        {
            InternalNatives._DestroyGroup(whichGroup);
        }
        
        //native GroupAddUnit takes group whichGroup, unit whichUnit returns nothing
        public delegate void GroupAddUnitPrototype(JassGroup whichGroup, JassUnit whichUnit);
        private static GroupAddUnitPrototype _GroupAddUnit;
        public static void GroupAddUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            InternalNatives._GroupAddUnit(whichGroup, whichUnit);
        }
        
        //native GroupRemoveUnit takes group whichGroup, unit whichUnit returns nothing
        public delegate void GroupRemoveUnitPrototype(JassGroup whichGroup, JassUnit whichUnit);
        private static GroupRemoveUnitPrototype _GroupRemoveUnit;
        public static void GroupRemoveUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            InternalNatives._GroupRemoveUnit(whichGroup, whichUnit);
        }
        
        //native GroupClear takes group whichGroup returns nothing
        public delegate void GroupClearPrototype(JassGroup whichGroup);
        private static GroupClearPrototype _GroupClear;
        public static void GroupClear(JassGroup whichGroup)
        {
            InternalNatives._GroupClear(whichGroup);
        }
        
        //native GroupEnumUnitsOfType takes group whichGroup, string unitname, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsOfTypePrototype(JassGroup whichGroup, String unitname, JassBooleanExpression filter);
        private static GroupEnumUnitsOfTypePrototype _GroupEnumUnitsOfType;
        public static void GroupEnumUnitsOfType(JassGroup whichGroup, String unitname, JassBooleanExpression filter)
        {
            InternalNatives._GroupEnumUnitsOfType(whichGroup, unitname, filter);
        }
        
        //native GroupEnumUnitsOfPlayer takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsOfPlayerPrototype(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter);
        private static GroupEnumUnitsOfPlayerPrototype _GroupEnumUnitsOfPlayer;
        public static void GroupEnumUnitsOfPlayer(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives._GroupEnumUnitsOfPlayer(whichGroup, whichPlayer, filter);
        }
        
        //native GroupEnumUnitsOfTypeCounted takes group whichGroup, string unitname, boolexpr filter, integer countLimit returns nothing
        public delegate void GroupEnumUnitsOfTypeCountedPrototype(JassGroup whichGroup, String unitname, JassBooleanExpression filter, JassInteger countLimit);
        private static GroupEnumUnitsOfTypeCountedPrototype _GroupEnumUnitsOfTypeCounted;
        public static void GroupEnumUnitsOfTypeCounted(JassGroup whichGroup, String unitname, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives._GroupEnumUnitsOfTypeCounted(whichGroup, unitname, filter, countLimit);
        }
        
        //native GroupEnumUnitsInRect takes group whichGroup, rect r, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsInRectPrototype(JassGroup whichGroup, JassRect r, JassBooleanExpression filter);
        private static GroupEnumUnitsInRectPrototype _GroupEnumUnitsInRect;
        public static void GroupEnumUnitsInRect(JassGroup whichGroup, JassRect r, JassBooleanExpression filter)
        {
            InternalNatives._GroupEnumUnitsInRect(whichGroup, r, filter);
        }
        
        //native GroupEnumUnitsInRectCounted takes group whichGroup, rect r, boolexpr filter, integer countLimit returns nothing
        public delegate void GroupEnumUnitsInRectCountedPrototype(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit);
        private static GroupEnumUnitsInRectCountedPrototype _GroupEnumUnitsInRectCounted;
        public static void GroupEnumUnitsInRectCounted(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives._GroupEnumUnitsInRectCounted(whichGroup, r, filter, countLimit);
        }
        
        //native GroupEnumUnitsInRange takes group whichGroup, real x, real y, real radius, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsInRangePrototype(JassGroup whichGroup, JassRealArg x, JassRealArg y, JassRealArg radius, JassBooleanExpression filter);
        private static GroupEnumUnitsInRangePrototype _GroupEnumUnitsInRange;
        public static void GroupEnumUnitsInRange(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter)
        {
            InternalNatives._GroupEnumUnitsInRange(whichGroup, x, y, radius, filter);
        }
        
        //native GroupEnumUnitsInRangeOfLoc takes group whichGroup, location whichLocation, real radius, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsInRangeOfLocPrototype(JassGroup whichGroup, JassLocation whichLocation, JassRealArg radius, JassBooleanExpression filter);
        private static GroupEnumUnitsInRangeOfLocPrototype _GroupEnumUnitsInRangeOfLoc;
        public static void GroupEnumUnitsInRangeOfLoc(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter)
        {
            InternalNatives._GroupEnumUnitsInRangeOfLoc(whichGroup, whichLocation, radius, filter);
        }
        
        //native GroupEnumUnitsInRangeCounted takes group whichGroup, real x, real y, real radius, boolexpr filter, integer countLimit returns nothing
        public delegate void GroupEnumUnitsInRangeCountedPrototype(JassGroup whichGroup, JassRealArg x, JassRealArg y, JassRealArg radius, JassBooleanExpression filter, JassInteger countLimit);
        private static GroupEnumUnitsInRangeCountedPrototype _GroupEnumUnitsInRangeCounted;
        public static void GroupEnumUnitsInRangeCounted(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives._GroupEnumUnitsInRangeCounted(whichGroup, x, y, radius, filter, countLimit);
        }
        
        //native GroupEnumUnitsInRangeOfLocCounted takes group whichGroup, location whichLocation, real radius, boolexpr filter, integer countLimit returns nothing
        public delegate void GroupEnumUnitsInRangeOfLocCountedPrototype(JassGroup whichGroup, JassLocation whichLocation, JassRealArg radius, JassBooleanExpression filter, JassInteger countLimit);
        private static GroupEnumUnitsInRangeOfLocCountedPrototype _GroupEnumUnitsInRangeOfLocCounted;
        public static void GroupEnumUnitsInRangeOfLocCounted(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives._GroupEnumUnitsInRangeOfLocCounted(whichGroup, whichLocation, radius, filter, countLimit);
        }
        
        //native GroupEnumUnitsSelected takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsSelectedPrototype(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter);
        private static GroupEnumUnitsSelectedPrototype _GroupEnumUnitsSelected;
        public static void GroupEnumUnitsSelected(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives._GroupEnumUnitsSelected(whichGroup, whichPlayer, filter);
        }
        
        //native GroupImmediateOrder takes group whichGroup, string order returns boolean
        public delegate JassBoolean GroupImmediateOrderPrototype(JassGroup whichGroup, String order);
        private static GroupImmediateOrderPrototype _GroupImmediateOrder;
        public static Boolean GroupImmediateOrder(JassGroup whichGroup, String order)
        {
            return InternalNatives._GroupImmediateOrder(whichGroup, order);
        }
        
        //native GroupImmediateOrderById takes group whichGroup, integer order returns boolean
        public delegate JassBoolean GroupImmediateOrderByIdPrototype(JassGroup whichGroup, JassOrder order);
        private static GroupImmediateOrderByIdPrototype _GroupImmediateOrderById;
        public static Boolean GroupImmediateOrderById(JassGroup whichGroup, JassOrder order)
        {
            return InternalNatives._GroupImmediateOrderById(whichGroup, order);
        }
        
        //native GroupPointOrder takes group whichGroup, string order, real x, real y returns boolean
        public delegate JassBoolean GroupPointOrderPrototype(JassGroup whichGroup, String order, JassRealArg x, JassRealArg y);
        private static GroupPointOrderPrototype _GroupPointOrder;
        public static Boolean GroupPointOrder(JassGroup whichGroup, String order, Single x, Single y)
        {
            return InternalNatives._GroupPointOrder(whichGroup, order, x, y);
        }
        
        //native GroupPointOrderLoc takes group whichGroup, string order, location whichLocation returns boolean
        public delegate JassBoolean GroupPointOrderLocPrototype(JassGroup whichGroup, String order, JassLocation whichLocation);
        private static GroupPointOrderLocPrototype _GroupPointOrderLoc;
        public static Boolean GroupPointOrderLoc(JassGroup whichGroup, String order, JassLocation whichLocation)
        {
            return InternalNatives._GroupPointOrderLoc(whichGroup, order, whichLocation);
        }
        
        //native GroupPointOrderById takes group whichGroup, integer order, real x, real y returns boolean
        public delegate JassBoolean GroupPointOrderByIdPrototype(JassGroup whichGroup, JassOrder order, JassRealArg x, JassRealArg y);
        private static GroupPointOrderByIdPrototype _GroupPointOrderById;
        public static Boolean GroupPointOrderById(JassGroup whichGroup, JassOrder order, Single x, Single y)
        {
            return InternalNatives._GroupPointOrderById(whichGroup, order, x, y);
        }
        
        //native GroupPointOrderByIdLoc takes group whichGroup, integer order, location whichLocation returns boolean
        public delegate JassBoolean GroupPointOrderByIdLocPrototype(JassGroup whichGroup, JassOrder order, JassLocation whichLocation);
        private static GroupPointOrderByIdLocPrototype _GroupPointOrderByIdLoc;
        public static Boolean GroupPointOrderByIdLoc(JassGroup whichGroup, JassOrder order, JassLocation whichLocation)
        {
            return InternalNatives._GroupPointOrderByIdLoc(whichGroup, order, whichLocation);
        }
        
        //native GroupTargetOrder takes group whichGroup, string order, widget targetWidget returns boolean
        public delegate JassBoolean GroupTargetOrderPrototype(JassGroup whichGroup, String order, JassWidget targetWidget);
        private static GroupTargetOrderPrototype _GroupTargetOrder;
        public static Boolean GroupTargetOrder(JassGroup whichGroup, String order, JassWidget targetWidget)
        {
            return InternalNatives._GroupTargetOrder(whichGroup, order, targetWidget);
        }
        
        //native GroupTargetOrderById takes group whichGroup, integer order, widget targetWidget returns boolean
        public delegate JassBoolean GroupTargetOrderByIdPrototype(JassGroup whichGroup, JassOrder order, JassWidget targetWidget);
        private static GroupTargetOrderByIdPrototype _GroupTargetOrderById;
        public static Boolean GroupTargetOrderById(JassGroup whichGroup, JassOrder order, JassWidget targetWidget)
        {
            return InternalNatives._GroupTargetOrderById(whichGroup, order, targetWidget);
        }
        
        //native ForGroup takes group whichGroup, code callback returns nothing
        public delegate void ForGroupPrototype(JassGroup whichGroup, JassCode callback);
        private static ForGroupPrototype _ForGroup;
        public static void ForGroup(JassGroup whichGroup, JassCode callback)
        {
            InternalNatives._ForGroup(whichGroup, callback);
        }
        
        //native FirstOfGroup takes group whichGroup returns unit
        public delegate JassUnit FirstOfGroupPrototype(JassGroup whichGroup);
        private static FirstOfGroupPrototype _FirstOfGroup;
        public static JassUnit FirstOfGroup(JassGroup whichGroup)
        {
            return InternalNatives._FirstOfGroup(whichGroup);
        }
        
        //native CreateForce takes nothing returns force
        public delegate JassForce CreateForcePrototype();
        private static CreateForcePrototype _CreateForce;
        public static JassForce CreateForce()
        {
            return InternalNatives._CreateForce();
        }
        
        //native DestroyForce takes force whichForce returns nothing
        public delegate void DestroyForcePrototype(JassForce whichForce);
        private static DestroyForcePrototype _DestroyForce;
        public static void DestroyForce(JassForce whichForce)
        {
            InternalNatives._DestroyForce(whichForce);
        }
        
        //native ForceAddPlayer takes force whichForce, player whichPlayer returns nothing
        public delegate void ForceAddPlayerPrototype(JassForce whichForce, JassPlayer whichPlayer);
        private static ForceAddPlayerPrototype _ForceAddPlayer;
        public static void ForceAddPlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            InternalNatives._ForceAddPlayer(whichForce, whichPlayer);
        }
        
        //native ForceRemovePlayer takes force whichForce, player whichPlayer returns nothing
        public delegate void ForceRemovePlayerPrototype(JassForce whichForce, JassPlayer whichPlayer);
        private static ForceRemovePlayerPrototype _ForceRemovePlayer;
        public static void ForceRemovePlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            InternalNatives._ForceRemovePlayer(whichForce, whichPlayer);
        }
        
        //native ForceClear takes force whichForce returns nothing
        public delegate void ForceClearPrototype(JassForce whichForce);
        private static ForceClearPrototype _ForceClear;
        public static void ForceClear(JassForce whichForce)
        {
            InternalNatives._ForceClear(whichForce);
        }
        
        //native ForceEnumPlayers takes force whichForce, boolexpr filter returns nothing
        public delegate void ForceEnumPlayersPrototype(JassForce whichForce, JassBooleanExpression filter);
        private static ForceEnumPlayersPrototype _ForceEnumPlayers;
        public static void ForceEnumPlayers(JassForce whichForce, JassBooleanExpression filter)
        {
            InternalNatives._ForceEnumPlayers(whichForce, filter);
        }
        
        //native ForceEnumPlayersCounted takes force whichForce, boolexpr filter, integer countLimit returns nothing
        public delegate void ForceEnumPlayersCountedPrototype(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit);
        private static ForceEnumPlayersCountedPrototype _ForceEnumPlayersCounted;
        public static void ForceEnumPlayersCounted(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives._ForceEnumPlayersCounted(whichForce, filter, countLimit);
        }
        
        //native ForceEnumAllies takes force whichForce, player whichPlayer, boolexpr filter returns nothing
        public delegate void ForceEnumAlliesPrototype(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter);
        private static ForceEnumAlliesPrototype _ForceEnumAllies;
        public static void ForceEnumAllies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives._ForceEnumAllies(whichForce, whichPlayer, filter);
        }
        
        //native ForceEnumEnemies takes force whichForce, player whichPlayer, boolexpr filter returns nothing
        public delegate void ForceEnumEnemiesPrototype(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter);
        private static ForceEnumEnemiesPrototype _ForceEnumEnemies;
        public static void ForceEnumEnemies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives._ForceEnumEnemies(whichForce, whichPlayer, filter);
        }
        
        //native ForForce takes force whichForce, code callback returns nothing
        public delegate void ForForcePrototype(JassForce whichForce, JassCode callback);
        private static ForForcePrototype _ForForce;
        public static void ForForce(JassForce whichForce, JassCode callback)
        {
            InternalNatives._ForForce(whichForce, callback);
        }
        
        //native Rect takes real minx, real miny, real maxx, real maxy returns rect
        public delegate JassRect RectPrototype(JassRealArg minx, JassRealArg miny, JassRealArg maxx, JassRealArg maxy);
        private static RectPrototype _Rect;
        public static JassRect Rect(Single minx, Single miny, Single maxx, Single maxy)
        {
            return InternalNatives._Rect(minx, miny, maxx, maxy);
        }
        
        //native RectFromLoc takes location min, location max returns rect
        public delegate JassRect RectFromLocPrototype(JassLocation min, JassLocation max);
        private static RectFromLocPrototype _RectFromLoc;
        public static JassRect RectFromLoc(JassLocation min, JassLocation max)
        {
            return InternalNatives._RectFromLoc(min, max);
        }
        
        //native RemoveRect takes rect whichRect returns nothing
        public delegate void RemoveRectPrototype(JassRect whichRect);
        private static RemoveRectPrototype _RemoveRect;
        public static void RemoveRect(JassRect whichRect)
        {
            InternalNatives._RemoveRect(whichRect);
        }
        
        //native SetRect takes rect whichRect, real minx, real miny, real maxx, real maxy returns nothing
        public delegate void SetRectPrototype(JassRect whichRect, JassRealArg minx, JassRealArg miny, JassRealArg maxx, JassRealArg maxy);
        private static SetRectPrototype _SetRect;
        public static void SetRect(JassRect whichRect, Single minx, Single miny, Single maxx, Single maxy)
        {
            InternalNatives._SetRect(whichRect, minx, miny, maxx, maxy);
        }
        
        //native SetRectFromLoc takes rect whichRect, location min, location max returns nothing
        public delegate void SetRectFromLocPrototype(JassRect whichRect, JassLocation min, JassLocation max);
        private static SetRectFromLocPrototype _SetRectFromLoc;
        public static void SetRectFromLoc(JassRect whichRect, JassLocation min, JassLocation max)
        {
            InternalNatives._SetRectFromLoc(whichRect, min, max);
        }
        
        //native MoveRectTo takes rect whichRect, real newCenterX, real newCenterY returns nothing
        public delegate void MoveRectToPrototype(JassRect whichRect, JassRealArg newCenterX, JassRealArg newCenterY);
        private static MoveRectToPrototype _MoveRectTo;
        public static void MoveRectTo(JassRect whichRect, Single newCenterX, Single newCenterY)
        {
            InternalNatives._MoveRectTo(whichRect, newCenterX, newCenterY);
        }
        
        //native MoveRectToLoc takes rect whichRect, location newCenterLoc returns nothing
        public delegate void MoveRectToLocPrototype(JassRect whichRect, JassLocation newCenterLoc);
        private static MoveRectToLocPrototype _MoveRectToLoc;
        public static void MoveRectToLoc(JassRect whichRect, JassLocation newCenterLoc)
        {
            InternalNatives._MoveRectToLoc(whichRect, newCenterLoc);
        }
        
        //native GetRectCenterX takes rect whichRect returns real
        public delegate JassRealRet GetRectCenterXPrototype(JassRect whichRect);
        private static GetRectCenterXPrototype _GetRectCenterX;
        public static Single GetRectCenterX(JassRect whichRect)
        {
            return InternalNatives._GetRectCenterX(whichRect);
        }
        
        //native GetRectCenterY takes rect whichRect returns real
        public delegate JassRealRet GetRectCenterYPrototype(JassRect whichRect);
        private static GetRectCenterYPrototype _GetRectCenterY;
        public static Single GetRectCenterY(JassRect whichRect)
        {
            return InternalNatives._GetRectCenterY(whichRect);
        }
        
        //native GetRectMinX takes rect whichRect returns real
        public delegate JassRealRet GetRectMinXPrototype(JassRect whichRect);
        private static GetRectMinXPrototype _GetRectMinX;
        public static Single GetRectMinX(JassRect whichRect)
        {
            return InternalNatives._GetRectMinX(whichRect);
        }
        
        //native GetRectMinY takes rect whichRect returns real
        public delegate JassRealRet GetRectMinYPrototype(JassRect whichRect);
        private static GetRectMinYPrototype _GetRectMinY;
        public static Single GetRectMinY(JassRect whichRect)
        {
            return InternalNatives._GetRectMinY(whichRect);
        }
        
        //native GetRectMaxX takes rect whichRect returns real
        public delegate JassRealRet GetRectMaxXPrototype(JassRect whichRect);
        private static GetRectMaxXPrototype _GetRectMaxX;
        public static Single GetRectMaxX(JassRect whichRect)
        {
            return InternalNatives._GetRectMaxX(whichRect);
        }
        
        //native GetRectMaxY takes rect whichRect returns real
        public delegate JassRealRet GetRectMaxYPrototype(JassRect whichRect);
        private static GetRectMaxYPrototype _GetRectMaxY;
        public static Single GetRectMaxY(JassRect whichRect)
        {
            return InternalNatives._GetRectMaxY(whichRect);
        }
        
        //native CreateRegion takes nothing returns region
        public delegate JassRegion CreateRegionPrototype();
        private static CreateRegionPrototype _CreateRegion;
        public static JassRegion CreateRegion()
        {
            return InternalNatives._CreateRegion();
        }
        
        //native RemoveRegion takes region whichRegion returns nothing
        public delegate void RemoveRegionPrototype(JassRegion whichRegion);
        private static RemoveRegionPrototype _RemoveRegion;
        public static void RemoveRegion(JassRegion whichRegion)
        {
            InternalNatives._RemoveRegion(whichRegion);
        }
        
        //native RegionAddRect takes region whichRegion, rect r returns nothing
        public delegate void RegionAddRectPrototype(JassRegion whichRegion, JassRect r);
        private static RegionAddRectPrototype _RegionAddRect;
        public static void RegionAddRect(JassRegion whichRegion, JassRect r)
        {
            InternalNatives._RegionAddRect(whichRegion, r);
        }
        
        //native RegionClearRect takes region whichRegion, rect r returns nothing
        public delegate void RegionClearRectPrototype(JassRegion whichRegion, JassRect r);
        private static RegionClearRectPrototype _RegionClearRect;
        public static void RegionClearRect(JassRegion whichRegion, JassRect r)
        {
            InternalNatives._RegionClearRect(whichRegion, r);
        }
        
        //native RegionAddCell takes region whichRegion, real x, real y returns nothing
        public delegate void RegionAddCellPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private static RegionAddCellPrototype _RegionAddCell;
        public static void RegionAddCell(JassRegion whichRegion, Single x, Single y)
        {
            InternalNatives._RegionAddCell(whichRegion, x, y);
        }
        
        //native RegionAddCellAtLoc takes region whichRegion, location whichLocation returns nothing
        public delegate void RegionAddCellAtLocPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private static RegionAddCellAtLocPrototype _RegionAddCellAtLoc;
        public static void RegionAddCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            InternalNatives._RegionAddCellAtLoc(whichRegion, whichLocation);
        }
        
        //native RegionClearCell takes region whichRegion, real x, real y returns nothing
        public delegate void RegionClearCellPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private static RegionClearCellPrototype _RegionClearCell;
        public static void RegionClearCell(JassRegion whichRegion, Single x, Single y)
        {
            InternalNatives._RegionClearCell(whichRegion, x, y);
        }
        
        //native RegionClearCellAtLoc takes region whichRegion, location whichLocation returns nothing
        public delegate void RegionClearCellAtLocPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private static RegionClearCellAtLocPrototype _RegionClearCellAtLoc;
        public static void RegionClearCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            InternalNatives._RegionClearCellAtLoc(whichRegion, whichLocation);
        }
        
        //native Location takes real x, real y returns location
        public delegate JassLocation LocationPrototype(JassRealArg x, JassRealArg y);
        private static LocationPrototype _Location;
        public static JassLocation Location(Single x, Single y)
        {
            return InternalNatives._Location(x, y);
        }
        
        //native RemoveLocation takes location whichLocation returns nothing
        public delegate void RemoveLocationPrototype(JassLocation whichLocation);
        private static RemoveLocationPrototype _RemoveLocation;
        public static void RemoveLocation(JassLocation whichLocation)
        {
            InternalNatives._RemoveLocation(whichLocation);
        }
        
        //native MoveLocation takes location whichLocation, real newX, real newY returns nothing
        public delegate void MoveLocationPrototype(JassLocation whichLocation, JassRealArg newX, JassRealArg newY);
        private static MoveLocationPrototype _MoveLocation;
        public static void MoveLocation(JassLocation whichLocation, Single newX, Single newY)
        {
            InternalNatives._MoveLocation(whichLocation, newX, newY);
        }
        
        //native GetLocationX takes location whichLocation returns real
        public delegate JassRealRet GetLocationXPrototype(JassLocation whichLocation);
        private static GetLocationXPrototype _GetLocationX;
        public static Single GetLocationX(JassLocation whichLocation)
        {
            return InternalNatives._GetLocationX(whichLocation);
        }
        
        //native GetLocationY takes location whichLocation returns real
        public delegate JassRealRet GetLocationYPrototype(JassLocation whichLocation);
        private static GetLocationYPrototype _GetLocationY;
        public static Single GetLocationY(JassLocation whichLocation)
        {
            return InternalNatives._GetLocationY(whichLocation);
        }
        
        //native GetLocationZ takes location whichLocation returns real
        public delegate JassRealRet GetLocationZPrototype(JassLocation whichLocation);
        private static GetLocationZPrototype _GetLocationZ;
        public static Single GetLocationZ(JassLocation whichLocation)
        {
            return InternalNatives._GetLocationZ(whichLocation);
        }
        
        //native IsUnitInRegion takes region whichRegion, unit whichUnit returns boolean
        public delegate JassBoolean IsUnitInRegionPrototype(JassRegion whichRegion, JassUnit whichUnit);
        private static IsUnitInRegionPrototype _IsUnitInRegion;
        public static Boolean IsUnitInRegion(JassRegion whichRegion, JassUnit whichUnit)
        {
            return InternalNatives._IsUnitInRegion(whichRegion, whichUnit);
        }
        
        //native IsPointInRegion takes region whichRegion, real x, real y returns boolean
        public delegate JassBoolean IsPointInRegionPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private static IsPointInRegionPrototype _IsPointInRegion;
        public static Boolean IsPointInRegion(JassRegion whichRegion, Single x, Single y)
        {
            return InternalNatives._IsPointInRegion(whichRegion, x, y);
        }
        
        //native IsLocationInRegion takes region whichRegion, location whichLocation returns boolean
        public delegate JassBoolean IsLocationInRegionPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private static IsLocationInRegionPrototype _IsLocationInRegion;
        public static Boolean IsLocationInRegion(JassRegion whichRegion, JassLocation whichLocation)
        {
            return InternalNatives._IsLocationInRegion(whichRegion, whichLocation);
        }
        
        //native GetWorldBounds takes nothing returns rect
        public delegate JassRect GetWorldBoundsPrototype();
        private static GetWorldBoundsPrototype _GetWorldBounds;
        public static JassRect GetWorldBounds()
        {
            return InternalNatives._GetWorldBounds();
        }
        
        //native CreateTrigger takes nothing returns trigger
        public delegate JassTrigger CreateTriggerPrototype();
        private static CreateTriggerPrototype _CreateTrigger;
        public static JassTrigger CreateTrigger()
        {
            return InternalNatives._CreateTrigger();
        }
        
        //native DestroyTrigger takes trigger whichTrigger returns nothing
        public delegate void DestroyTriggerPrototype(JassTrigger whichTrigger);
        private static DestroyTriggerPrototype _DestroyTrigger;
        public static void DestroyTrigger(JassTrigger whichTrigger)
        {
            InternalNatives._DestroyTrigger(whichTrigger);
        }
        
        //native ResetTrigger takes trigger whichTrigger returns nothing
        public delegate void ResetTriggerPrototype(JassTrigger whichTrigger);
        private static ResetTriggerPrototype _ResetTrigger;
        public static void ResetTrigger(JassTrigger whichTrigger)
        {
            InternalNatives._ResetTrigger(whichTrigger);
        }
        
        //native EnableTrigger takes trigger whichTrigger returns nothing
        public delegate void EnableTriggerPrototype(JassTrigger whichTrigger);
        private static EnableTriggerPrototype _EnableTrigger;
        public static void EnableTrigger(JassTrigger whichTrigger)
        {
            InternalNatives._EnableTrigger(whichTrigger);
        }
        
        //native DisableTrigger takes trigger whichTrigger returns nothing
        public delegate void DisableTriggerPrototype(JassTrigger whichTrigger);
        private static DisableTriggerPrototype _DisableTrigger;
        public static void DisableTrigger(JassTrigger whichTrigger)
        {
            InternalNatives._DisableTrigger(whichTrigger);
        }
        
        //native IsTriggerEnabled takes trigger whichTrigger returns boolean
        public delegate JassBoolean IsTriggerEnabledPrototype(JassTrigger whichTrigger);
        private static IsTriggerEnabledPrototype _IsTriggerEnabled;
        public static Boolean IsTriggerEnabled(JassTrigger whichTrigger)
        {
            return InternalNatives._IsTriggerEnabled(whichTrigger);
        }
        
        //native TriggerWaitOnSleeps takes trigger whichTrigger, boolean flag returns nothing
        public delegate void TriggerWaitOnSleepsPrototype(JassTrigger whichTrigger, JassBoolean flag);
        private static TriggerWaitOnSleepsPrototype _TriggerWaitOnSleeps;
        public static void TriggerWaitOnSleeps(JassTrigger whichTrigger, Boolean flag)
        {
            InternalNatives._TriggerWaitOnSleeps(whichTrigger, flag);
        }
        
        //native IsTriggerWaitOnSleeps takes trigger whichTrigger returns boolean
        public delegate JassBoolean IsTriggerWaitOnSleepsPrototype(JassTrigger whichTrigger);
        private static IsTriggerWaitOnSleepsPrototype _IsTriggerWaitOnSleeps;
        public static Boolean IsTriggerWaitOnSleeps(JassTrigger whichTrigger)
        {
            return InternalNatives._IsTriggerWaitOnSleeps(whichTrigger);
        }
        
        //native GetFilterUnit takes nothing returns unit
        public delegate JassUnit GetFilterUnitPrototype();
        private static GetFilterUnitPrototype _GetFilterUnit;
        public static JassUnit GetFilterUnit()
        {
            return InternalNatives._GetFilterUnit();
        }
        
        //native GetEnumUnit takes nothing returns unit
        public delegate JassUnit GetEnumUnitPrototype();
        private static GetEnumUnitPrototype _GetEnumUnit;
        public static JassUnit GetEnumUnit()
        {
            return InternalNatives._GetEnumUnit();
        }
        
        //native GetFilterDestructable takes nothing returns destructable
        public delegate JassDestructable GetFilterDestructablePrototype();
        private static GetFilterDestructablePrototype _GetFilterDestructable;
        public static JassDestructable GetFilterDestructable()
        {
            return InternalNatives._GetFilterDestructable();
        }
        
        //native GetEnumDestructable takes nothing returns destructable
        public delegate JassDestructable GetEnumDestructablePrototype();
        private static GetEnumDestructablePrototype _GetEnumDestructable;
        public static JassDestructable GetEnumDestructable()
        {
            return InternalNatives._GetEnumDestructable();
        }
        
        //native GetFilterItem takes nothing returns item
        public delegate JassItem GetFilterItemPrototype();
        private static GetFilterItemPrototype _GetFilterItem;
        public static JassItem GetFilterItem()
        {
            return InternalNatives._GetFilterItem();
        }
        
        //native GetEnumItem takes nothing returns item
        public delegate JassItem GetEnumItemPrototype();
        private static GetEnumItemPrototype _GetEnumItem;
        public static JassItem GetEnumItem()
        {
            return InternalNatives._GetEnumItem();
        }
        
        //native GetFilterPlayer takes nothing returns player
        public delegate JassPlayer GetFilterPlayerPrototype();
        private static GetFilterPlayerPrototype _GetFilterPlayer;
        public static JassPlayer GetFilterPlayer()
        {
            return InternalNatives._GetFilterPlayer();
        }
        
        //native GetEnumPlayer takes nothing returns player
        public delegate JassPlayer GetEnumPlayerPrototype();
        private static GetEnumPlayerPrototype _GetEnumPlayer;
        public static JassPlayer GetEnumPlayer()
        {
            return InternalNatives._GetEnumPlayer();
        }
        
        //native GetTriggeringTrigger takes nothing returns trigger
        public delegate JassTrigger GetTriggeringTriggerPrototype();
        private static GetTriggeringTriggerPrototype _GetTriggeringTrigger;
        public static JassTrigger GetTriggeringTrigger()
        {
            return InternalNatives._GetTriggeringTrigger();
        }
        
        //native GetTriggerEventId takes nothing returns eventid
        public delegate JassEventIndex GetTriggerEventIdPrototype();
        private static GetTriggerEventIdPrototype _GetTriggerEventId;
        public static JassEventIndex GetTriggerEventId()
        {
            return InternalNatives._GetTriggerEventId();
        }
        
        //native GetTriggerEvalCount takes trigger whichTrigger returns integer
        public delegate JassInteger GetTriggerEvalCountPrototype(JassTrigger whichTrigger);
        private static GetTriggerEvalCountPrototype _GetTriggerEvalCount;
        public static JassInteger GetTriggerEvalCount(JassTrigger whichTrigger)
        {
            return InternalNatives._GetTriggerEvalCount(whichTrigger);
        }
        
        //native GetTriggerExecCount takes trigger whichTrigger returns integer
        public delegate JassInteger GetTriggerExecCountPrototype(JassTrigger whichTrigger);
        private static GetTriggerExecCountPrototype _GetTriggerExecCount;
        public static JassInteger GetTriggerExecCount(JassTrigger whichTrigger)
        {
            return InternalNatives._GetTriggerExecCount(whichTrigger);
        }
        
        //native ExecuteFunc takes string funcName returns nothing
        public delegate void ExecuteFuncPrototype(String funcName);
        private static ExecuteFuncPrototype _ExecuteFunc;
        public static void ExecuteFunc(String funcName)
        {
            InternalNatives._ExecuteFunc(funcName);
        }
        
        //native And takes boolexpr operandA, boolexpr operandB returns boolexpr
        public delegate JassBooleanExpression AndPrototype(JassBooleanExpression operandA, JassBooleanExpression operandB);
        private static AndPrototype _And;
        public static JassBooleanExpression And(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return InternalNatives._And(operandA, operandB);
        }
        
        //native Or takes boolexpr operandA, boolexpr operandB returns boolexpr
        public delegate JassBooleanExpression OrPrototype(JassBooleanExpression operandA, JassBooleanExpression operandB);
        private static OrPrototype _Or;
        public static JassBooleanExpression Or(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return InternalNatives._Or(operandA, operandB);
        }
        
        //native Not takes boolexpr operand returns boolexpr
        public delegate JassBooleanExpression NotPrototype(JassBooleanExpression operand);
        private static NotPrototype _Not;
        public static JassBooleanExpression Not(JassBooleanExpression operand)
        {
            return InternalNatives._Not(operand);
        }
        
        //native Condition takes code func returns conditionfunc
        public delegate JassConditionFunction ConditionPrototype(JassCode func);
        private static ConditionPrototype _Condition;
        public static JassConditionFunction Condition(JassCode func)
        {
            return InternalNatives._Condition(func);
        }
        
        //native DestroyCondition takes conditionfunc c returns nothing
        public delegate void DestroyConditionPrototype(JassConditionFunction c);
        private static DestroyConditionPrototype _DestroyCondition;
        public static void DestroyCondition(JassConditionFunction c)
        {
            InternalNatives._DestroyCondition(c);
        }
        
        //native Filter takes code func returns filterfunc
        public delegate JassFilterFunction FilterPrototype(JassCode func);
        private static FilterPrototype _Filter;
        public static JassFilterFunction Filter(JassCode func)
        {
            return InternalNatives._Filter(func);
        }
        
        //native DestroyFilter takes filterfunc f returns nothing
        public delegate void DestroyFilterPrototype(JassFilterFunction f);
        private static DestroyFilterPrototype _DestroyFilter;
        public static void DestroyFilter(JassFilterFunction f)
        {
            InternalNatives._DestroyFilter(f);
        }
        
        //native DestroyBoolExpr takes boolexpr e returns nothing
        public delegate void DestroyBoolExprPrototype(JassBooleanExpression e);
        private static DestroyBoolExprPrototype _DestroyBoolExpr;
        public static void DestroyBoolExpr(JassBooleanExpression e)
        {
            InternalNatives._DestroyBoolExpr(e);
        }
        
        //native TriggerRegisterVariableEvent takes trigger whichTrigger, string varName, limitop opcode, real limitval returns event
        public delegate JassEvent TriggerRegisterVariableEventPrototype(JassTrigger whichTrigger, String varName, JassLimitOp opcode, JassRealArg limitval);
        private static TriggerRegisterVariableEventPrototype _TriggerRegisterVariableEvent;
        public static JassEvent TriggerRegisterVariableEvent(JassTrigger whichTrigger, String varName, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives._TriggerRegisterVariableEvent(whichTrigger, varName, opcode, limitval);
        }
        
        //native TriggerRegisterTimerEvent takes trigger whichTrigger, real timeout, boolean periodic returns event
        public delegate JassEvent TriggerRegisterTimerEventPrototype(JassTrigger whichTrigger, JassRealArg timeout, JassBoolean periodic);
        private static TriggerRegisterTimerEventPrototype _TriggerRegisterTimerEvent;
        public static JassEvent TriggerRegisterTimerEvent(JassTrigger whichTrigger, Single timeout, Boolean periodic)
        {
            return InternalNatives._TriggerRegisterTimerEvent(whichTrigger, timeout, periodic);
        }
        
        //native TriggerRegisterTimerExpireEvent takes trigger whichTrigger, timer t returns event
        public delegate JassEvent TriggerRegisterTimerExpireEventPrototype(JassTrigger whichTrigger, JassTimer t);
        private static TriggerRegisterTimerExpireEventPrototype _TriggerRegisterTimerExpireEvent;
        public static JassEvent TriggerRegisterTimerExpireEvent(JassTrigger whichTrigger, JassTimer t)
        {
            return InternalNatives._TriggerRegisterTimerExpireEvent(whichTrigger, t);
        }
        
        //native TriggerRegisterGameStateEvent takes trigger whichTrigger, gamestate whichState, limitop opcode, real limitval returns event
        public delegate JassEvent TriggerRegisterGameStateEventPrototype(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, JassRealArg limitval);
        private static TriggerRegisterGameStateEventPrototype _TriggerRegisterGameStateEvent;
        public static JassEvent TriggerRegisterGameStateEvent(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives._TriggerRegisterGameStateEvent(whichTrigger, whichState, opcode, limitval);
        }
        
        //native TriggerRegisterDialogEvent takes trigger whichTrigger, dialog whichDialog returns event
        public delegate JassEvent TriggerRegisterDialogEventPrototype(JassTrigger whichTrigger, JassDialog whichDialog);
        private static TriggerRegisterDialogEventPrototype _TriggerRegisterDialogEvent;
        public static JassEvent TriggerRegisterDialogEvent(JassTrigger whichTrigger, JassDialog whichDialog)
        {
            return InternalNatives._TriggerRegisterDialogEvent(whichTrigger, whichDialog);
        }
        
        //native TriggerRegisterDialogButtonEvent takes trigger whichTrigger, button whichButton returns event
        public delegate JassEvent TriggerRegisterDialogButtonEventPrototype(JassTrigger whichTrigger, JassButton whichButton);
        private static TriggerRegisterDialogButtonEventPrototype _TriggerRegisterDialogButtonEvent;
        public static JassEvent TriggerRegisterDialogButtonEvent(JassTrigger whichTrigger, JassButton whichButton)
        {
            return InternalNatives._TriggerRegisterDialogButtonEvent(whichTrigger, whichButton);
        }
        
        //native GetEventGameState takes nothing returns gamestate
        public delegate JassGameState GetEventGameStatePrototype();
        private static GetEventGameStatePrototype _GetEventGameState;
        public static JassGameState GetEventGameState()
        {
            return InternalNatives._GetEventGameState();
        }
        
        //native TriggerRegisterGameEvent takes trigger whichTrigger, gameevent whichGameEvent returns event
        public delegate JassEvent TriggerRegisterGameEventPrototype(JassTrigger whichTrigger, JassGameEvent whichGameEvent);
        private static TriggerRegisterGameEventPrototype _TriggerRegisterGameEvent;
        public static JassEvent TriggerRegisterGameEvent(JassTrigger whichTrigger, JassGameEvent whichGameEvent)
        {
            return InternalNatives._TriggerRegisterGameEvent(whichTrigger, whichGameEvent);
        }
        
        //native GetWinningPlayer takes nothing returns player
        public delegate JassPlayer GetWinningPlayerPrototype();
        private static GetWinningPlayerPrototype _GetWinningPlayer;
        public static JassPlayer GetWinningPlayer()
        {
            return InternalNatives._GetWinningPlayer();
        }
        
        //native TriggerRegisterEnterRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterEnterRegionPrototype(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter);
        private static TriggerRegisterEnterRegionPrototype _TriggerRegisterEnterRegion;
        public static JassEvent TriggerRegisterEnterRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return InternalNatives._TriggerRegisterEnterRegion(whichTrigger, whichRegion, filter);
        }
        
        //native GetTriggeringRegion takes nothing returns region
        public delegate JassRegion GetTriggeringRegionPrototype();
        private static GetTriggeringRegionPrototype _GetTriggeringRegion;
        public static JassRegion GetTriggeringRegion()
        {
            return InternalNatives._GetTriggeringRegion();
        }
        
        //native GetEnteringUnit takes nothing returns unit
        public delegate JassUnit GetEnteringUnitPrototype();
        private static GetEnteringUnitPrototype _GetEnteringUnit;
        public static JassUnit GetEnteringUnit()
        {
            return InternalNatives._GetEnteringUnit();
        }
        
        //native TriggerRegisterLeaveRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterLeaveRegionPrototype(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter);
        private static TriggerRegisterLeaveRegionPrototype _TriggerRegisterLeaveRegion;
        public static JassEvent TriggerRegisterLeaveRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return InternalNatives._TriggerRegisterLeaveRegion(whichTrigger, whichRegion, filter);
        }
        
        //native GetLeavingUnit takes nothing returns unit
        public delegate JassUnit GetLeavingUnitPrototype();
        private static GetLeavingUnitPrototype _GetLeavingUnit;
        public static JassUnit GetLeavingUnit()
        {
            return InternalNatives._GetLeavingUnit();
        }
        
        //native TriggerRegisterTrackableHitEvent takes trigger whichTrigger, trackable t returns event
        public delegate JassEvent TriggerRegisterTrackableHitEventPrototype(JassTrigger whichTrigger, JassTrackable t);
        private static TriggerRegisterTrackableHitEventPrototype _TriggerRegisterTrackableHitEvent;
        public static JassEvent TriggerRegisterTrackableHitEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return InternalNatives._TriggerRegisterTrackableHitEvent(whichTrigger, t);
        }
        
        //native TriggerRegisterTrackableTrackEvent takes trigger whichTrigger, trackable t returns event
        public delegate JassEvent TriggerRegisterTrackableTrackEventPrototype(JassTrigger whichTrigger, JassTrackable t);
        private static TriggerRegisterTrackableTrackEventPrototype _TriggerRegisterTrackableTrackEvent;
        public static JassEvent TriggerRegisterTrackableTrackEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return InternalNatives._TriggerRegisterTrackableTrackEvent(whichTrigger, t);
        }
        
        //native GetTriggeringTrackable takes nothing returns trackable
        public delegate JassTrackable GetTriggeringTrackablePrototype();
        private static GetTriggeringTrackablePrototype _GetTriggeringTrackable;
        public static JassTrackable GetTriggeringTrackable()
        {
            return InternalNatives._GetTriggeringTrackable();
        }
        
        //native GetClickedButton takes nothing returns button
        public delegate JassButton GetClickedButtonPrototype();
        private static GetClickedButtonPrototype _GetClickedButton;
        public static JassButton GetClickedButton()
        {
            return InternalNatives._GetClickedButton();
        }
        
        //native GetClickedDialog takes nothing returns dialog
        public delegate JassDialog GetClickedDialogPrototype();
        private static GetClickedDialogPrototype _GetClickedDialog;
        public static JassDialog GetClickedDialog()
        {
            return InternalNatives._GetClickedDialog();
        }
        
        //native GetTournamentFinishSoonTimeRemaining takes nothing returns real
        public delegate JassRealRet GetTournamentFinishSoonTimeRemainingPrototype();
        private static GetTournamentFinishSoonTimeRemainingPrototype _GetTournamentFinishSoonTimeRemaining;
        public static Single GetTournamentFinishSoonTimeRemaining()
        {
            return InternalNatives._GetTournamentFinishSoonTimeRemaining();
        }
        
        //native GetTournamentFinishNowRule takes nothing returns integer
        public delegate JassInteger GetTournamentFinishNowRulePrototype();
        private static GetTournamentFinishNowRulePrototype _GetTournamentFinishNowRule;
        public static JassInteger GetTournamentFinishNowRule()
        {
            return InternalNatives._GetTournamentFinishNowRule();
        }
        
        //native GetTournamentFinishNowPlayer takes nothing returns player
        public delegate JassPlayer GetTournamentFinishNowPlayerPrototype();
        private static GetTournamentFinishNowPlayerPrototype _GetTournamentFinishNowPlayer;
        public static JassPlayer GetTournamentFinishNowPlayer()
        {
            return InternalNatives._GetTournamentFinishNowPlayer();
        }
        
        //native GetTournamentScore takes player whichPlayer returns integer
        public delegate JassInteger GetTournamentScorePrototype(JassPlayer whichPlayer);
        private static GetTournamentScorePrototype _GetTournamentScore;
        public static JassInteger GetTournamentScore(JassPlayer whichPlayer)
        {
            return InternalNatives._GetTournamentScore(whichPlayer);
        }
        
        //native GetSaveBasicFilename takes nothing returns string
        public delegate String GetSaveBasicFilenamePrototype();
        private static GetSaveBasicFilenamePrototype _GetSaveBasicFilename;
        public static String GetSaveBasicFilename()
        {
            return InternalNatives._GetSaveBasicFilename();
        }
        
        //native TriggerRegisterPlayerEvent takes trigger whichTrigger, player whichPlayer, playerevent whichPlayerEvent returns event
        public delegate JassEvent TriggerRegisterPlayerEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent);
        private static TriggerRegisterPlayerEventPrototype _TriggerRegisterPlayerEvent;
        public static JassEvent TriggerRegisterPlayerEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent)
        {
            return InternalNatives._TriggerRegisterPlayerEvent(whichTrigger, whichPlayer, whichPlayerEvent);
        }
        
        //native GetTriggerPlayer takes nothing returns player
        public delegate JassPlayer GetTriggerPlayerPrototype();
        private static GetTriggerPlayerPrototype _GetTriggerPlayer;
        public static JassPlayer GetTriggerPlayer()
        {
            return InternalNatives._GetTriggerPlayer();
        }
        
        //native TriggerRegisterPlayerUnitEvent takes trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterPlayerUnitEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter);
        private static TriggerRegisterPlayerUnitEventPrototype _TriggerRegisterPlayerUnitEvent;
        public static JassEvent TriggerRegisterPlayerUnitEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter)
        {
            return InternalNatives._TriggerRegisterPlayerUnitEvent(whichTrigger, whichPlayer, whichPlayerUnitEvent, filter);
        }
        
        //native GetLevelingUnit takes nothing returns unit
        public delegate JassUnit GetLevelingUnitPrototype();
        private static GetLevelingUnitPrototype _GetLevelingUnit;
        public static JassUnit GetLevelingUnit()
        {
            return InternalNatives._GetLevelingUnit();
        }
        
        //native GetLearningUnit takes nothing returns unit
        public delegate JassUnit GetLearningUnitPrototype();
        private static GetLearningUnitPrototype _GetLearningUnit;
        public static JassUnit GetLearningUnit()
        {
            return InternalNatives._GetLearningUnit();
        }
        
        //native GetLearnedSkill takes nothing returns integer
        public delegate JassInteger GetLearnedSkillPrototype();
        private static GetLearnedSkillPrototype _GetLearnedSkill;
        public static JassInteger GetLearnedSkill()
        {
            return InternalNatives._GetLearnedSkill();
        }
        
        //native GetLearnedSkillLevel takes nothing returns integer
        public delegate JassInteger GetLearnedSkillLevelPrototype();
        private static GetLearnedSkillLevelPrototype _GetLearnedSkillLevel;
        public static JassInteger GetLearnedSkillLevel()
        {
            return InternalNatives._GetLearnedSkillLevel();
        }
        
        //native GetRevivableUnit takes nothing returns unit
        public delegate JassUnit GetRevivableUnitPrototype();
        private static GetRevivableUnitPrototype _GetRevivableUnit;
        public static JassUnit GetRevivableUnit()
        {
            return InternalNatives._GetRevivableUnit();
        }
        
        //native GetRevivingUnit takes nothing returns unit
        public delegate JassUnit GetRevivingUnitPrototype();
        private static GetRevivingUnitPrototype _GetRevivingUnit;
        public static JassUnit GetRevivingUnit()
        {
            return InternalNatives._GetRevivingUnit();
        }
        
        //native GetAttacker takes nothing returns unit
        public delegate JassUnit GetAttackerPrototype();
        private static GetAttackerPrototype _GetAttacker;
        public static JassUnit GetAttacker()
        {
            return InternalNatives._GetAttacker();
        }
        
        //native GetRescuer takes nothing returns unit
        public delegate JassUnit GetRescuerPrototype();
        private static GetRescuerPrototype _GetRescuer;
        public static JassUnit GetRescuer()
        {
            return InternalNatives._GetRescuer();
        }
        
        //native GetDyingUnit takes nothing returns unit
        public delegate JassUnit GetDyingUnitPrototype();
        private static GetDyingUnitPrototype _GetDyingUnit;
        public static JassUnit GetDyingUnit()
        {
            return InternalNatives._GetDyingUnit();
        }
        
        //native GetKillingUnit takes nothing returns unit
        public delegate JassUnit GetKillingUnitPrototype();
        private static GetKillingUnitPrototype _GetKillingUnit;
        public static JassUnit GetKillingUnit()
        {
            return InternalNatives._GetKillingUnit();
        }
        
        //native GetDecayingUnit takes nothing returns unit
        public delegate JassUnit GetDecayingUnitPrototype();
        private static GetDecayingUnitPrototype _GetDecayingUnit;
        public static JassUnit GetDecayingUnit()
        {
            return InternalNatives._GetDecayingUnit();
        }
        
        //native GetConstructingStructure takes nothing returns unit
        public delegate JassUnit GetConstructingStructurePrototype();
        private static GetConstructingStructurePrototype _GetConstructingStructure;
        public static JassUnit GetConstructingStructure()
        {
            return InternalNatives._GetConstructingStructure();
        }
        
        //native GetCancelledStructure takes nothing returns unit
        public delegate JassUnit GetCancelledStructurePrototype();
        private static GetCancelledStructurePrototype _GetCancelledStructure;
        public static JassUnit GetCancelledStructure()
        {
            return InternalNatives._GetCancelledStructure();
        }
        
        //native GetConstructedStructure takes nothing returns unit
        public delegate JassUnit GetConstructedStructurePrototype();
        private static GetConstructedStructurePrototype _GetConstructedStructure;
        public static JassUnit GetConstructedStructure()
        {
            return InternalNatives._GetConstructedStructure();
        }
        
        //native GetResearchingUnit takes nothing returns unit
        public delegate JassUnit GetResearchingUnitPrototype();
        private static GetResearchingUnitPrototype _GetResearchingUnit;
        public static JassUnit GetResearchingUnit()
        {
            return InternalNatives._GetResearchingUnit();
        }
        
        //native GetResearched takes nothing returns integer
        public delegate JassInteger GetResearchedPrototype();
        private static GetResearchedPrototype _GetResearched;
        public static JassInteger GetResearched()
        {
            return InternalNatives._GetResearched();
        }
        
        //native GetTrainedUnitType takes nothing returns integer
        public delegate JassInteger GetTrainedUnitTypePrototype();
        private static GetTrainedUnitTypePrototype _GetTrainedUnitType;
        public static JassInteger GetTrainedUnitType()
        {
            return InternalNatives._GetTrainedUnitType();
        }
        
        //native GetTrainedUnit takes nothing returns unit
        public delegate JassUnit GetTrainedUnitPrototype();
        private static GetTrainedUnitPrototype _GetTrainedUnit;
        public static JassUnit GetTrainedUnit()
        {
            return InternalNatives._GetTrainedUnit();
        }
        
        //native GetDetectedUnit takes nothing returns unit
        public delegate JassUnit GetDetectedUnitPrototype();
        private static GetDetectedUnitPrototype _GetDetectedUnit;
        public static JassUnit GetDetectedUnit()
        {
            return InternalNatives._GetDetectedUnit();
        }
        
        //native GetSummoningUnit takes nothing returns unit
        public delegate JassUnit GetSummoningUnitPrototype();
        private static GetSummoningUnitPrototype _GetSummoningUnit;
        public static JassUnit GetSummoningUnit()
        {
            return InternalNatives._GetSummoningUnit();
        }
        
        //native GetSummonedUnit takes nothing returns unit
        public delegate JassUnit GetSummonedUnitPrototype();
        private static GetSummonedUnitPrototype _GetSummonedUnit;
        public static JassUnit GetSummonedUnit()
        {
            return InternalNatives._GetSummonedUnit();
        }
        
        //native GetTransportUnit takes nothing returns unit
        public delegate JassUnit GetTransportUnitPrototype();
        private static GetTransportUnitPrototype _GetTransportUnit;
        public static JassUnit GetTransportUnit()
        {
            return InternalNatives._GetTransportUnit();
        }
        
        //native GetLoadedUnit takes nothing returns unit
        public delegate JassUnit GetLoadedUnitPrototype();
        private static GetLoadedUnitPrototype _GetLoadedUnit;
        public static JassUnit GetLoadedUnit()
        {
            return InternalNatives._GetLoadedUnit();
        }
        
        //native GetSellingUnit takes nothing returns unit
        public delegate JassUnit GetSellingUnitPrototype();
        private static GetSellingUnitPrototype _GetSellingUnit;
        public static JassUnit GetSellingUnit()
        {
            return InternalNatives._GetSellingUnit();
        }
        
        //native GetSoldUnit takes nothing returns unit
        public delegate JassUnit GetSoldUnitPrototype();
        private static GetSoldUnitPrototype _GetSoldUnit;
        public static JassUnit GetSoldUnit()
        {
            return InternalNatives._GetSoldUnit();
        }
        
        //native GetBuyingUnit takes nothing returns unit
        public delegate JassUnit GetBuyingUnitPrototype();
        private static GetBuyingUnitPrototype _GetBuyingUnit;
        public static JassUnit GetBuyingUnit()
        {
            return InternalNatives._GetBuyingUnit();
        }
        
        //native GetSoldItem takes nothing returns item
        public delegate JassItem GetSoldItemPrototype();
        private static GetSoldItemPrototype _GetSoldItem;
        public static JassItem GetSoldItem()
        {
            return InternalNatives._GetSoldItem();
        }
        
        //native GetChangingUnit takes nothing returns unit
        public delegate JassUnit GetChangingUnitPrototype();
        private static GetChangingUnitPrototype _GetChangingUnit;
        public static JassUnit GetChangingUnit()
        {
            return InternalNatives._GetChangingUnit();
        }
        
        //native GetChangingUnitPrevOwner takes nothing returns player
        public delegate JassPlayer GetChangingUnitPrevOwnerPrototype();
        private static GetChangingUnitPrevOwnerPrototype _GetChangingUnitPrevOwner;
        public static JassPlayer GetChangingUnitPrevOwner()
        {
            return InternalNatives._GetChangingUnitPrevOwner();
        }
        
        //native GetManipulatingUnit takes nothing returns unit
        public delegate JassUnit GetManipulatingUnitPrototype();
        private static GetManipulatingUnitPrototype _GetManipulatingUnit;
        public static JassUnit GetManipulatingUnit()
        {
            return InternalNatives._GetManipulatingUnit();
        }
        
        //native GetManipulatedItem takes nothing returns item
        public delegate JassItem GetManipulatedItemPrototype();
        private static GetManipulatedItemPrototype _GetManipulatedItem;
        public static JassItem GetManipulatedItem()
        {
            return InternalNatives._GetManipulatedItem();
        }
        
        //native GetOrderedUnit takes nothing returns unit
        public delegate JassUnit GetOrderedUnitPrototype();
        private static GetOrderedUnitPrototype _GetOrderedUnit;
        public static JassUnit GetOrderedUnit()
        {
            return InternalNatives._GetOrderedUnit();
        }
        
        //native GetIssuedOrderId takes nothing returns integer
        public delegate JassOrder GetIssuedOrderIdPrototype();
        private static GetIssuedOrderIdPrototype _GetIssuedOrderId;
        public static JassOrder GetIssuedOrderId()
        {
            return InternalNatives._GetIssuedOrderId();
        }
        
        //native GetOrderPointX takes nothing returns real
        public delegate JassRealRet GetOrderPointXPrototype();
        private static GetOrderPointXPrototype _GetOrderPointX;
        public static Single GetOrderPointX()
        {
            return InternalNatives._GetOrderPointX();
        }
        
        //native GetOrderPointY takes nothing returns real
        public delegate JassRealRet GetOrderPointYPrototype();
        private static GetOrderPointYPrototype _GetOrderPointY;
        public static Single GetOrderPointY()
        {
            return InternalNatives._GetOrderPointY();
        }
        
        //native GetOrderPointLoc takes nothing returns location
        public delegate JassLocation GetOrderPointLocPrototype();
        private static GetOrderPointLocPrototype _GetOrderPointLoc;
        public static JassLocation GetOrderPointLoc()
        {
            return InternalNatives._GetOrderPointLoc();
        }
        
        //native GetOrderTarget takes nothing returns widget
        public delegate JassWidget GetOrderTargetPrototype();
        private static GetOrderTargetPrototype _GetOrderTarget;
        public static JassWidget GetOrderTarget()
        {
            return InternalNatives._GetOrderTarget();
        }
        
        //native GetOrderTargetDestructable takes nothing returns destructable
        public delegate JassDestructable GetOrderTargetDestructablePrototype();
        private static GetOrderTargetDestructablePrototype _GetOrderTargetDestructable;
        public static JassDestructable GetOrderTargetDestructable()
        {
            return InternalNatives._GetOrderTargetDestructable();
        }
        
        //native GetOrderTargetItem takes nothing returns item
        public delegate JassItem GetOrderTargetItemPrototype();
        private static GetOrderTargetItemPrototype _GetOrderTargetItem;
        public static JassItem GetOrderTargetItem()
        {
            return InternalNatives._GetOrderTargetItem();
        }
        
        //native GetOrderTargetUnit takes nothing returns unit
        public delegate JassUnit GetOrderTargetUnitPrototype();
        private static GetOrderTargetUnitPrototype _GetOrderTargetUnit;
        public static JassUnit GetOrderTargetUnit()
        {
            return InternalNatives._GetOrderTargetUnit();
        }
        
        //native GetSpellAbilityUnit takes nothing returns unit
        public delegate JassUnit GetSpellAbilityUnitPrototype();
        private static GetSpellAbilityUnitPrototype _GetSpellAbilityUnit;
        public static JassUnit GetSpellAbilityUnit()
        {
            return InternalNatives._GetSpellAbilityUnit();
        }
        
        //native GetSpellAbilityId takes nothing returns integer
        public delegate JassObjectId GetSpellAbilityIdPrototype();
        private static GetSpellAbilityIdPrototype _GetSpellAbilityId;
        public static JassObjectId GetSpellAbilityId()
        {
            return InternalNatives._GetSpellAbilityId();
        }
        
        //native GetSpellAbility takes nothing returns ability
        public delegate JassAbility GetSpellAbilityPrototype();
        private static GetSpellAbilityPrototype _GetSpellAbility;
        public static JassAbility GetSpellAbility()
        {
            return InternalNatives._GetSpellAbility();
        }
        
        //native GetSpellTargetLoc takes nothing returns location
        public delegate JassLocation GetSpellTargetLocPrototype();
        private static GetSpellTargetLocPrototype _GetSpellTargetLoc;
        public static JassLocation GetSpellTargetLoc()
        {
            return InternalNatives._GetSpellTargetLoc();
        }
        
        //native GetSpellTargetX takes nothing returns real
        public delegate JassRealRet GetSpellTargetXPrototype();
        private static GetSpellTargetXPrototype _GetSpellTargetX;
        public static Single GetSpellTargetX()
        {
            return InternalNatives._GetSpellTargetX();
        }
        
        //native GetSpellTargetY takes nothing returns real
        public delegate JassRealRet GetSpellTargetYPrototype();
        private static GetSpellTargetYPrototype _GetSpellTargetY;
        public static Single GetSpellTargetY()
        {
            return InternalNatives._GetSpellTargetY();
        }
        
        //native GetSpellTargetDestructable takes nothing returns destructable
        public delegate JassDestructable GetSpellTargetDestructablePrototype();
        private static GetSpellTargetDestructablePrototype _GetSpellTargetDestructable;
        public static JassDestructable GetSpellTargetDestructable()
        {
            return InternalNatives._GetSpellTargetDestructable();
        }
        
        //native GetSpellTargetItem takes nothing returns item
        public delegate JassItem GetSpellTargetItemPrototype();
        private static GetSpellTargetItemPrototype _GetSpellTargetItem;
        public static JassItem GetSpellTargetItem()
        {
            return InternalNatives._GetSpellTargetItem();
        }
        
        //native GetSpellTargetUnit takes nothing returns unit
        public delegate JassUnit GetSpellTargetUnitPrototype();
        private static GetSpellTargetUnitPrototype _GetSpellTargetUnit;
        public static JassUnit GetSpellTargetUnit()
        {
            return InternalNatives._GetSpellTargetUnit();
        }
        
        //native TriggerRegisterPlayerAllianceChange takes trigger whichTrigger, player whichPlayer, alliancetype whichAlliance returns event
        public delegate JassEvent TriggerRegisterPlayerAllianceChangePrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance);
        private static TriggerRegisterPlayerAllianceChangePrototype _TriggerRegisterPlayerAllianceChange;
        public static JassEvent TriggerRegisterPlayerAllianceChange(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance)
        {
            return InternalNatives._TriggerRegisterPlayerAllianceChange(whichTrigger, whichPlayer, whichAlliance);
        }
        
        //native TriggerRegisterPlayerStateEvent takes trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, real limitval returns event
        public delegate JassEvent TriggerRegisterPlayerStateEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, JassRealArg limitval);
        private static TriggerRegisterPlayerStateEventPrototype _TriggerRegisterPlayerStateEvent;
        public static JassEvent TriggerRegisterPlayerStateEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives._TriggerRegisterPlayerStateEvent(whichTrigger, whichPlayer, whichState, opcode, limitval);
        }
        
        //native GetEventPlayerState takes nothing returns playerstate
        public delegate JassPlayerState GetEventPlayerStatePrototype();
        private static GetEventPlayerStatePrototype _GetEventPlayerState;
        public static JassPlayerState GetEventPlayerState()
        {
            return InternalNatives._GetEventPlayerState();
        }
        
        //native TriggerRegisterPlayerChatEvent takes trigger whichTrigger, player whichPlayer, string chatMessageToDetect, boolean exactMatchOnly returns event
        public delegate JassEvent TriggerRegisterPlayerChatEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, String chatMessageToDetect, JassBoolean exactMatchOnly);
        private static TriggerRegisterPlayerChatEventPrototype _TriggerRegisterPlayerChatEvent;
        public static JassEvent TriggerRegisterPlayerChatEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, String chatMessageToDetect, Boolean exactMatchOnly)
        {
            return InternalNatives._TriggerRegisterPlayerChatEvent(whichTrigger, whichPlayer, chatMessageToDetect, exactMatchOnly);
        }
        
        //native GetEventPlayerChatString takes nothing returns string
        public delegate String GetEventPlayerChatStringPrototype();
        private static GetEventPlayerChatStringPrototype _GetEventPlayerChatString;
        public static String GetEventPlayerChatString()
        {
            return InternalNatives._GetEventPlayerChatString();
        }
        
        //native GetEventPlayerChatStringMatched takes nothing returns string
        public delegate String GetEventPlayerChatStringMatchedPrototype();
        private static GetEventPlayerChatStringMatchedPrototype _GetEventPlayerChatStringMatched;
        public static String GetEventPlayerChatStringMatched()
        {
            return InternalNatives._GetEventPlayerChatStringMatched();
        }
        
        //native TriggerRegisterDeathEvent takes trigger whichTrigger, widget whichWidget returns event
        public delegate JassEvent TriggerRegisterDeathEventPrototype(JassTrigger whichTrigger, JassWidget whichWidget);
        private static TriggerRegisterDeathEventPrototype _TriggerRegisterDeathEvent;
        public static JassEvent TriggerRegisterDeathEvent(JassTrigger whichTrigger, JassWidget whichWidget)
        {
            return InternalNatives._TriggerRegisterDeathEvent(whichTrigger, whichWidget);
        }
        
        //native GetTriggerUnit takes nothing returns unit
        public delegate JassUnit GetTriggerUnitPrototype();
        private static GetTriggerUnitPrototype _GetTriggerUnit;
        public static JassUnit GetTriggerUnit()
        {
            return InternalNatives._GetTriggerUnit();
        }
        
        //native TriggerRegisterUnitStateEvent takes trigger whichTrigger, unit whichUnit, unitstate whichState, limitop opcode, real limitval returns event
        public delegate JassEvent TriggerRegisterUnitStateEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, JassRealArg limitval);
        private static TriggerRegisterUnitStateEventPrototype _TriggerRegisterUnitStateEvent;
        public static JassEvent TriggerRegisterUnitStateEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives._TriggerRegisterUnitStateEvent(whichTrigger, whichUnit, whichState, opcode, limitval);
        }
        
        //native GetEventUnitState takes nothing returns unitstate
        public delegate JassUnitState GetEventUnitStatePrototype();
        private static GetEventUnitStatePrototype _GetEventUnitState;
        public static JassUnitState GetEventUnitState()
        {
            return InternalNatives._GetEventUnitState();
        }
        
        //native TriggerRegisterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent returns event
        public delegate JassEvent TriggerRegisterUnitEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent);
        private static TriggerRegisterUnitEventPrototype _TriggerRegisterUnitEvent;
        public static JassEvent TriggerRegisterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent)
        {
            return InternalNatives._TriggerRegisterUnitEvent(whichTrigger, whichUnit, whichEvent);
        }
        
        //native GetEventDamage takes nothing returns real
        public delegate JassRealRet GetEventDamagePrototype();
        private static GetEventDamagePrototype _GetEventDamage;
        public static Single GetEventDamage()
        {
            return InternalNatives._GetEventDamage();
        }
        
        //native GetEventDamageSource takes nothing returns unit
        public delegate JassUnit GetEventDamageSourcePrototype();
        private static GetEventDamageSourcePrototype _GetEventDamageSource;
        public static JassUnit GetEventDamageSource()
        {
            return InternalNatives._GetEventDamageSource();
        }
        
        //native GetEventDetectingPlayer takes nothing returns player
        public delegate JassPlayer GetEventDetectingPlayerPrototype();
        private static GetEventDetectingPlayerPrototype _GetEventDetectingPlayer;
        public static JassPlayer GetEventDetectingPlayer()
        {
            return InternalNatives._GetEventDetectingPlayer();
        }
        
        //native TriggerRegisterFilterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterFilterUnitEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter);
        private static TriggerRegisterFilterUnitEventPrototype _TriggerRegisterFilterUnitEvent;
        public static JassEvent TriggerRegisterFilterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter)
        {
            return InternalNatives._TriggerRegisterFilterUnitEvent(whichTrigger, whichUnit, whichEvent, filter);
        }
        
        //native GetEventTargetUnit takes nothing returns unit
        public delegate JassUnit GetEventTargetUnitPrototype();
        private static GetEventTargetUnitPrototype _GetEventTargetUnit;
        public static JassUnit GetEventTargetUnit()
        {
            return InternalNatives._GetEventTargetUnit();
        }
        
        //native TriggerRegisterUnitInRange takes trigger whichTrigger, unit whichUnit, real range, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterUnitInRangePrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassRealArg range, JassBooleanExpression filter);
        private static TriggerRegisterUnitInRangePrototype _TriggerRegisterUnitInRange;
        public static JassEvent TriggerRegisterUnitInRange(JassTrigger whichTrigger, JassUnit whichUnit, Single range, JassBooleanExpression filter)
        {
            return InternalNatives._TriggerRegisterUnitInRange(whichTrigger, whichUnit, range, filter);
        }
        
        //native TriggerAddCondition takes trigger whichTrigger, boolexpr condition returns triggercondition
        public delegate JassTriggerCondition TriggerAddConditionPrototype(JassTrigger whichTrigger, JassBooleanExpression condition);
        private static TriggerAddConditionPrototype _TriggerAddCondition;
        public static JassTriggerCondition TriggerAddCondition(JassTrigger whichTrigger, JassBooleanExpression condition)
        {
            return InternalNatives._TriggerAddCondition(whichTrigger, condition);
        }
        
        //native TriggerRemoveCondition takes trigger whichTrigger, triggercondition whichCondition returns nothing
        public delegate void TriggerRemoveConditionPrototype(JassTrigger whichTrigger, JassTriggerCondition whichCondition);
        private static TriggerRemoveConditionPrototype _TriggerRemoveCondition;
        public static void TriggerRemoveCondition(JassTrigger whichTrigger, JassTriggerCondition whichCondition)
        {
            InternalNatives._TriggerRemoveCondition(whichTrigger, whichCondition);
        }
        
        //native TriggerClearConditions takes trigger whichTrigger returns nothing
        public delegate void TriggerClearConditionsPrototype(JassTrigger whichTrigger);
        private static TriggerClearConditionsPrototype _TriggerClearConditions;
        public static void TriggerClearConditions(JassTrigger whichTrigger)
        {
            InternalNatives._TriggerClearConditions(whichTrigger);
        }
        
        //native TriggerAddAction takes trigger whichTrigger, code actionFunc returns triggeraction
        public delegate JassTriggerAction TriggerAddActionPrototype(JassTrigger whichTrigger, JassCode actionFunc);
        private static TriggerAddActionPrototype _TriggerAddAction;
        public static JassTriggerAction TriggerAddAction(JassTrigger whichTrigger, JassCode actionFunc)
        {
            return InternalNatives._TriggerAddAction(whichTrigger, actionFunc);
        }
        
        //native TriggerRemoveAction takes trigger whichTrigger, triggeraction whichAction returns nothing
        public delegate void TriggerRemoveActionPrototype(JassTrigger whichTrigger, JassTriggerAction whichAction);
        private static TriggerRemoveActionPrototype _TriggerRemoveAction;
        public static void TriggerRemoveAction(JassTrigger whichTrigger, JassTriggerAction whichAction)
        {
            InternalNatives._TriggerRemoveAction(whichTrigger, whichAction);
        }
        
        //native TriggerClearActions takes trigger whichTrigger returns nothing
        public delegate void TriggerClearActionsPrototype(JassTrigger whichTrigger);
        private static TriggerClearActionsPrototype _TriggerClearActions;
        public static void TriggerClearActions(JassTrigger whichTrigger)
        {
            InternalNatives._TriggerClearActions(whichTrigger);
        }
        
        //native TriggerSleepAction takes real timeout returns nothing
        public delegate void TriggerSleepActionPrototype(JassRealArg timeout);
        private static TriggerSleepActionPrototype _TriggerSleepAction;
        public static void TriggerSleepAction(Single timeout)
        {
            InternalNatives._TriggerSleepAction(timeout);
        }
        
        //native TriggerWaitForSound takes sound s, real offset returns nothing
        public delegate void TriggerWaitForSoundPrototype(JassSound s, JassRealArg offset);
        private static TriggerWaitForSoundPrototype _TriggerWaitForSound;
        public static void TriggerWaitForSound(JassSound s, Single offset)
        {
            InternalNatives._TriggerWaitForSound(s, offset);
        }
        
        //native TriggerEvaluate takes trigger whichTrigger returns boolean
        public delegate JassBoolean TriggerEvaluatePrototype(JassTrigger whichTrigger);
        private static TriggerEvaluatePrototype _TriggerEvaluate;
        public static Boolean TriggerEvaluate(JassTrigger whichTrigger)
        {
            return InternalNatives._TriggerEvaluate(whichTrigger);
        }
        
        //native TriggerExecute takes trigger whichTrigger returns nothing
        public delegate void TriggerExecutePrototype(JassTrigger whichTrigger);
        private static TriggerExecutePrototype _TriggerExecute;
        public static void TriggerExecute(JassTrigger whichTrigger)
        {
            InternalNatives._TriggerExecute(whichTrigger);
        }
        
        //native TriggerExecuteWait takes trigger whichTrigger returns nothing
        public delegate void TriggerExecuteWaitPrototype(JassTrigger whichTrigger);
        private static TriggerExecuteWaitPrototype _TriggerExecuteWait;
        public static void TriggerExecuteWait(JassTrigger whichTrigger)
        {
            InternalNatives._TriggerExecuteWait(whichTrigger);
        }
        
        //native TriggerSyncStart takes nothing returns nothing
        public delegate void TriggerSyncStartPrototype();
        private static TriggerSyncStartPrototype _TriggerSyncStart;
        public static void TriggerSyncStart()
        {
            InternalNatives._TriggerSyncStart();
        }
        
        //native TriggerSyncReady takes nothing returns nothing
        public delegate void TriggerSyncReadyPrototype();
        private static TriggerSyncReadyPrototype _TriggerSyncReady;
        public static void TriggerSyncReady()
        {
            InternalNatives._TriggerSyncReady();
        }
        
        //native GetWidgetLife takes widget whichWidget returns real
        public delegate JassRealRet GetWidgetLifePrototype(JassWidget whichWidget);
        private static GetWidgetLifePrototype _GetWidgetLife;
        public static Single GetWidgetLife(JassWidget whichWidget)
        {
            return InternalNatives._GetWidgetLife(whichWidget);
        }
        
        //native SetWidgetLife takes widget whichWidget, real newLife returns nothing
        public delegate void SetWidgetLifePrototype(JassWidget whichWidget, JassRealArg newLife);
        private static SetWidgetLifePrototype _SetWidgetLife;
        public static void SetWidgetLife(JassWidget whichWidget, Single newLife)
        {
            InternalNatives._SetWidgetLife(whichWidget, newLife);
        }
        
        //native GetWidgetX takes widget whichWidget returns real
        public delegate JassRealRet GetWidgetXPrototype(JassWidget whichWidget);
        private static GetWidgetXPrototype _GetWidgetX;
        public static Single GetWidgetX(JassWidget whichWidget)
        {
            return InternalNatives._GetWidgetX(whichWidget);
        }
        
        //native GetWidgetY takes widget whichWidget returns real
        public delegate JassRealRet GetWidgetYPrototype(JassWidget whichWidget);
        private static GetWidgetYPrototype _GetWidgetY;
        public static Single GetWidgetY(JassWidget whichWidget)
        {
            return InternalNatives._GetWidgetY(whichWidget);
        }
        
        //native GetTriggerWidget takes nothing returns widget
        public delegate JassWidget GetTriggerWidgetPrototype();
        private static GetTriggerWidgetPrototype _GetTriggerWidget;
        public static JassWidget GetTriggerWidget()
        {
            return InternalNatives._GetTriggerWidget();
        }
        
        //native CreateDestructable takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
        public delegate JassDestructable CreateDestructablePrototype(JassObjectId objectid, JassRealArg x, JassRealArg y, JassRealArg face, JassRealArg scale, JassInteger variation);
        private static CreateDestructablePrototype _CreateDestructable;
        public static JassDestructable CreateDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives._CreateDestructable(objectid, x, y, face, scale, variation);
        }
        
        //native CreateDestructableZ takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
        public delegate JassDestructable CreateDestructableZPrototype(JassObjectId objectid, JassRealArg x, JassRealArg y, JassRealArg z, JassRealArg face, JassRealArg scale, JassInteger variation);
        private static CreateDestructableZPrototype _CreateDestructableZ;
        public static JassDestructable CreateDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives._CreateDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        //native CreateDeadDestructable takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
        public delegate JassDestructable CreateDeadDestructablePrototype(JassObjectId objectid, JassRealArg x, JassRealArg y, JassRealArg face, JassRealArg scale, JassInteger variation);
        private static CreateDeadDestructablePrototype _CreateDeadDestructable;
        public static JassDestructable CreateDeadDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives._CreateDeadDestructable(objectid, x, y, face, scale, variation);
        }
        
        //native CreateDeadDestructableZ takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
        public delegate JassDestructable CreateDeadDestructableZPrototype(JassObjectId objectid, JassRealArg x, JassRealArg y, JassRealArg z, JassRealArg face, JassRealArg scale, JassInteger variation);
        private static CreateDeadDestructableZPrototype _CreateDeadDestructableZ;
        public static JassDestructable CreateDeadDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives._CreateDeadDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        //native RemoveDestructable takes destructable d returns nothing
        public delegate void RemoveDestructablePrototype(JassDestructable d);
        private static RemoveDestructablePrototype _RemoveDestructable;
        public static void RemoveDestructable(JassDestructable d)
        {
            InternalNatives._RemoveDestructable(d);
        }
        
        //native KillDestructable takes destructable d returns nothing
        public delegate void KillDestructablePrototype(JassDestructable d);
        private static KillDestructablePrototype _KillDestructable;
        public static void KillDestructable(JassDestructable d)
        {
            InternalNatives._KillDestructable(d);
        }
        
        //native SetDestructableInvulnerable takes destructable d, boolean flag returns nothing
        public delegate void SetDestructableInvulnerablePrototype(JassDestructable d, JassBoolean flag);
        private static SetDestructableInvulnerablePrototype _SetDestructableInvulnerable;
        public static void SetDestructableInvulnerable(JassDestructable d, Boolean flag)
        {
            InternalNatives._SetDestructableInvulnerable(d, flag);
        }
        
        //native IsDestructableInvulnerable takes destructable d returns boolean
        public delegate JassBoolean IsDestructableInvulnerablePrototype(JassDestructable d);
        private static IsDestructableInvulnerablePrototype _IsDestructableInvulnerable;
        public static Boolean IsDestructableInvulnerable(JassDestructable d)
        {
            return InternalNatives._IsDestructableInvulnerable(d);
        }
        
        //native EnumDestructablesInRect takes rect r, boolexpr filter, code actionFunc returns nothing
        public delegate void EnumDestructablesInRectPrototype(JassRect r, JassBooleanExpression filter, JassCode actionFunc);
        private static EnumDestructablesInRectPrototype _EnumDestructablesInRect;
        public static void EnumDestructablesInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            InternalNatives._EnumDestructablesInRect(r, filter, actionFunc);
        }
        
        //native GetDestructableTypeId takes destructable d returns integer
        public delegate JassObjectId GetDestructableTypeIdPrototype(JassDestructable d);
        private static GetDestructableTypeIdPrototype _GetDestructableTypeId;
        public static JassObjectId GetDestructableTypeId(JassDestructable d)
        {
            return InternalNatives._GetDestructableTypeId(d);
        }
        
        //native GetDestructableX takes destructable d returns real
        public delegate JassRealRet GetDestructableXPrototype(JassDestructable d);
        private static GetDestructableXPrototype _GetDestructableX;
        public static Single GetDestructableX(JassDestructable d)
        {
            return InternalNatives._GetDestructableX(d);
        }
        
        //native GetDestructableY takes destructable d returns real
        public delegate JassRealRet GetDestructableYPrototype(JassDestructable d);
        private static GetDestructableYPrototype _GetDestructableY;
        public static Single GetDestructableY(JassDestructable d)
        {
            return InternalNatives._GetDestructableY(d);
        }
        
        //native SetDestructableLife takes destructable d, real life returns nothing
        public delegate void SetDestructableLifePrototype(JassDestructable d, JassRealArg life);
        private static SetDestructableLifePrototype _SetDestructableLife;
        public static void SetDestructableLife(JassDestructable d, Single life)
        {
            InternalNatives._SetDestructableLife(d, life);
        }
        
        //native GetDestructableLife takes destructable d returns real
        public delegate JassRealRet GetDestructableLifePrototype(JassDestructable d);
        private static GetDestructableLifePrototype _GetDestructableLife;
        public static Single GetDestructableLife(JassDestructable d)
        {
            return InternalNatives._GetDestructableLife(d);
        }
        
        //native SetDestructableMaxLife takes destructable d, real max returns nothing
        public delegate void SetDestructableMaxLifePrototype(JassDestructable d, JassRealArg max);
        private static SetDestructableMaxLifePrototype _SetDestructableMaxLife;
        public static void SetDestructableMaxLife(JassDestructable d, Single max)
        {
            InternalNatives._SetDestructableMaxLife(d, max);
        }
        
        //native GetDestructableMaxLife takes destructable d returns real
        public delegate JassRealRet GetDestructableMaxLifePrototype(JassDestructable d);
        private static GetDestructableMaxLifePrototype _GetDestructableMaxLife;
        public static Single GetDestructableMaxLife(JassDestructable d)
        {
            return InternalNatives._GetDestructableMaxLife(d);
        }
        
        //native DestructableRestoreLife takes destructable d, real life, boolean birth returns nothing
        public delegate void DestructableRestoreLifePrototype(JassDestructable d, JassRealArg life, JassBoolean birth);
        private static DestructableRestoreLifePrototype _DestructableRestoreLife;
        public static void DestructableRestoreLife(JassDestructable d, Single life, Boolean birth)
        {
            InternalNatives._DestructableRestoreLife(d, life, birth);
        }
        
        //native QueueDestructableAnimation takes destructable d, string whichAnimation returns nothing
        public delegate void QueueDestructableAnimationPrototype(JassDestructable d, String whichAnimation);
        private static QueueDestructableAnimationPrototype _QueueDestructableAnimation;
        public static void QueueDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            InternalNatives._QueueDestructableAnimation(d, whichAnimation);
        }
        
        //native SetDestructableAnimation takes destructable d, string whichAnimation returns nothing
        public delegate void SetDestructableAnimationPrototype(JassDestructable d, String whichAnimation);
        private static SetDestructableAnimationPrototype _SetDestructableAnimation;
        public static void SetDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            InternalNatives._SetDestructableAnimation(d, whichAnimation);
        }
        
        //native SetDestructableAnimationSpeed takes destructable d, real speedFactor returns nothing
        public delegate void SetDestructableAnimationSpeedPrototype(JassDestructable d, JassRealArg speedFactor);
        private static SetDestructableAnimationSpeedPrototype _SetDestructableAnimationSpeed;
        public static void SetDestructableAnimationSpeed(JassDestructable d, Single speedFactor)
        {
            InternalNatives._SetDestructableAnimationSpeed(d, speedFactor);
        }
        
        //native ShowDestructable takes destructable d, boolean flag returns nothing
        public delegate void ShowDestructablePrototype(JassDestructable d, JassBoolean flag);
        private static ShowDestructablePrototype _ShowDestructable;
        public static void ShowDestructable(JassDestructable d, Boolean flag)
        {
            InternalNatives._ShowDestructable(d, flag);
        }
        
        //native GetDestructableOccluderHeight takes destructable d returns real
        public delegate JassRealRet GetDestructableOccluderHeightPrototype(JassDestructable d);
        private static GetDestructableOccluderHeightPrototype _GetDestructableOccluderHeight;
        public static Single GetDestructableOccluderHeight(JassDestructable d)
        {
            return InternalNatives._GetDestructableOccluderHeight(d);
        }
        
        //native SetDestructableOccluderHeight takes destructable d, real height returns nothing
        public delegate void SetDestructableOccluderHeightPrototype(JassDestructable d, JassRealArg height);
        private static SetDestructableOccluderHeightPrototype _SetDestructableOccluderHeight;
        public static void SetDestructableOccluderHeight(JassDestructable d, Single height)
        {
            InternalNatives._SetDestructableOccluderHeight(d, height);
        }
        
        //native GetDestructableName takes destructable d returns string
        public delegate String GetDestructableNamePrototype(JassDestructable d);
        private static GetDestructableNamePrototype _GetDestructableName;
        public static String GetDestructableName(JassDestructable d)
        {
            return InternalNatives._GetDestructableName(d);
        }
        
        //native GetTriggerDestructable takes nothing returns destructable
        public delegate JassDestructable GetTriggerDestructablePrototype();
        private static GetTriggerDestructablePrototype _GetTriggerDestructable;
        public static JassDestructable GetTriggerDestructable()
        {
            return InternalNatives._GetTriggerDestructable();
        }
        
        //native CreateItem takes integer itemid, real x, real y returns item
        public delegate JassItem CreateItemPrototype(JassObjectId itemid, JassRealArg x, JassRealArg y);
        private static CreateItemPrototype _CreateItem;
        public static JassItem CreateItem(JassObjectId itemid, Single x, Single y)
        {
            return InternalNatives._CreateItem(itemid, x, y);
        }
        
        //native RemoveItem takes item whichItem returns nothing
        public delegate void RemoveItemPrototype(JassItem whichItem);
        private static RemoveItemPrototype _RemoveItem;
        public static void RemoveItem(JassItem whichItem)
        {
            InternalNatives._RemoveItem(whichItem);
        }
        
        //native GetItemPlayer takes item whichItem returns player
        public delegate JassPlayer GetItemPlayerPrototype(JassItem whichItem);
        private static GetItemPlayerPrototype _GetItemPlayer;
        public static JassPlayer GetItemPlayer(JassItem whichItem)
        {
            return InternalNatives._GetItemPlayer(whichItem);
        }
        
        //native GetItemTypeId takes item i returns integer
        public delegate JassObjectId GetItemTypeIdPrototype(JassItem i);
        private static GetItemTypeIdPrototype _GetItemTypeId;
        public static JassObjectId GetItemTypeId(JassItem i)
        {
            return InternalNatives._GetItemTypeId(i);
        }
        
        //native GetItemX takes item i returns real
        public delegate JassRealRet GetItemXPrototype(JassItem i);
        private static GetItemXPrototype _GetItemX;
        public static Single GetItemX(JassItem i)
        {
            return InternalNatives._GetItemX(i);
        }
        
        //native GetItemY takes item i returns real
        public delegate JassRealRet GetItemYPrototype(JassItem i);
        private static GetItemYPrototype _GetItemY;
        public static Single GetItemY(JassItem i)
        {
            return InternalNatives._GetItemY(i);
        }
        
        //native SetItemPosition takes item i, real x, real y returns nothing
        public delegate void SetItemPositionPrototype(JassItem i, JassRealArg x, JassRealArg y);
        private static SetItemPositionPrototype _SetItemPosition;
        public static void SetItemPosition(JassItem i, Single x, Single y)
        {
            InternalNatives._SetItemPosition(i, x, y);
        }
        
        //native SetItemDropOnDeath takes item whichItem, boolean flag returns nothing
        public delegate void SetItemDropOnDeathPrototype(JassItem whichItem, JassBoolean flag);
        private static SetItemDropOnDeathPrototype _SetItemDropOnDeath;
        public static void SetItemDropOnDeath(JassItem whichItem, Boolean flag)
        {
            InternalNatives._SetItemDropOnDeath(whichItem, flag);
        }
        
        //native SetItemDroppable takes item i, boolean flag returns nothing
        public delegate void SetItemDroppablePrototype(JassItem i, JassBoolean flag);
        private static SetItemDroppablePrototype _SetItemDroppable;
        public static void SetItemDroppable(JassItem i, Boolean flag)
        {
            InternalNatives._SetItemDroppable(i, flag);
        }
        
        //native SetItemPawnable takes item i, boolean flag returns nothing
        public delegate void SetItemPawnablePrototype(JassItem i, JassBoolean flag);
        private static SetItemPawnablePrototype _SetItemPawnable;
        public static void SetItemPawnable(JassItem i, Boolean flag)
        {
            InternalNatives._SetItemPawnable(i, flag);
        }
        
        //native SetItemPlayer takes item whichItem, player whichPlayer, boolean changeColor returns nothing
        public delegate void SetItemPlayerPrototype(JassItem whichItem, JassPlayer whichPlayer, JassBoolean changeColor);
        private static SetItemPlayerPrototype _SetItemPlayer;
        public static void SetItemPlayer(JassItem whichItem, JassPlayer whichPlayer, Boolean changeColor)
        {
            InternalNatives._SetItemPlayer(whichItem, whichPlayer, changeColor);
        }
        
        //native SetItemInvulnerable takes item whichItem, boolean flag returns nothing
        public delegate void SetItemInvulnerablePrototype(JassItem whichItem, JassBoolean flag);
        private static SetItemInvulnerablePrototype _SetItemInvulnerable;
        public static void SetItemInvulnerable(JassItem whichItem, Boolean flag)
        {
            InternalNatives._SetItemInvulnerable(whichItem, flag);
        }
        
        //native IsItemInvulnerable takes item whichItem returns boolean
        public delegate JassBoolean IsItemInvulnerablePrototype(JassItem whichItem);
        private static IsItemInvulnerablePrototype _IsItemInvulnerable;
        public static Boolean IsItemInvulnerable(JassItem whichItem)
        {
            return InternalNatives._IsItemInvulnerable(whichItem);
        }
        
        //native SetItemVisible takes item whichItem, boolean show returns nothing
        public delegate void SetItemVisiblePrototype(JassItem whichItem, JassBoolean show);
        private static SetItemVisiblePrototype _SetItemVisible;
        public static void SetItemVisible(JassItem whichItem, Boolean show)
        {
            InternalNatives._SetItemVisible(whichItem, show);
        }
        
        //native IsItemVisible takes item whichItem returns boolean
        public delegate JassBoolean IsItemVisiblePrototype(JassItem whichItem);
        private static IsItemVisiblePrototype _IsItemVisible;
        public static Boolean IsItemVisible(JassItem whichItem)
        {
            return InternalNatives._IsItemVisible(whichItem);
        }
        
        //native IsItemOwned takes item whichItem returns boolean
        public delegate JassBoolean IsItemOwnedPrototype(JassItem whichItem);
        private static IsItemOwnedPrototype _IsItemOwned;
        public static Boolean IsItemOwned(JassItem whichItem)
        {
            return InternalNatives._IsItemOwned(whichItem);
        }
        
        //native IsItemPowerup takes item whichItem returns boolean
        public delegate JassBoolean IsItemPowerupPrototype(JassItem whichItem);
        private static IsItemPowerupPrototype _IsItemPowerup;
        public static Boolean IsItemPowerup(JassItem whichItem)
        {
            return InternalNatives._IsItemPowerup(whichItem);
        }
        
        //native IsItemSellable takes item whichItem returns boolean
        public delegate JassBoolean IsItemSellablePrototype(JassItem whichItem);
        private static IsItemSellablePrototype _IsItemSellable;
        public static Boolean IsItemSellable(JassItem whichItem)
        {
            return InternalNatives._IsItemSellable(whichItem);
        }
        
        //native IsItemPawnable takes item whichItem returns boolean
        public delegate JassBoolean IsItemPawnablePrototype(JassItem whichItem);
        private static IsItemPawnablePrototype _IsItemPawnable;
        public static Boolean IsItemPawnable(JassItem whichItem)
        {
            return InternalNatives._IsItemPawnable(whichItem);
        }
        
        //native IsItemIdPowerup takes integer itemId returns boolean
        public delegate JassBoolean IsItemIdPowerupPrototype(JassObjectId itemId);
        private static IsItemIdPowerupPrototype _IsItemIdPowerup;
        public static Boolean IsItemIdPowerup(JassObjectId itemId)
        {
            return InternalNatives._IsItemIdPowerup(itemId);
        }
        
        //native IsItemIdSellable takes integer itemId returns boolean
        public delegate JassBoolean IsItemIdSellablePrototype(JassObjectId itemId);
        private static IsItemIdSellablePrototype _IsItemIdSellable;
        public static Boolean IsItemIdSellable(JassObjectId itemId)
        {
            return InternalNatives._IsItemIdSellable(itemId);
        }
        
        //native IsItemIdPawnable takes integer itemId returns boolean
        public delegate JassBoolean IsItemIdPawnablePrototype(JassObjectId itemId);
        private static IsItemIdPawnablePrototype _IsItemIdPawnable;
        public static Boolean IsItemIdPawnable(JassObjectId itemId)
        {
            return InternalNatives._IsItemIdPawnable(itemId);
        }
        
        //native EnumItemsInRect takes rect r, boolexpr filter, code actionFunc returns nothing
        public delegate void EnumItemsInRectPrototype(JassRect r, JassBooleanExpression filter, JassCode actionFunc);
        private static EnumItemsInRectPrototype _EnumItemsInRect;
        public static void EnumItemsInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            InternalNatives._EnumItemsInRect(r, filter, actionFunc);
        }
        
        //native GetItemLevel takes item whichItem returns integer
        public delegate JassInteger GetItemLevelPrototype(JassItem whichItem);
        private static GetItemLevelPrototype _GetItemLevel;
        public static JassInteger GetItemLevel(JassItem whichItem)
        {
            return InternalNatives._GetItemLevel(whichItem);
        }
        
        //native GetItemType takes item whichItem returns itemtype
        public delegate JassItemType GetItemTypePrototype(JassItem whichItem);
        private static GetItemTypePrototype _GetItemType;
        public static JassItemType GetItemType(JassItem whichItem)
        {
            return InternalNatives._GetItemType(whichItem);
        }
        
        //native SetItemDropID takes item whichItem, integer unitId returns nothing
        public delegate void SetItemDropIDPrototype(JassItem whichItem, JassObjectId unitId);
        private static SetItemDropIDPrototype _SetItemDropID;
        public static void SetItemDropID(JassItem whichItem, JassObjectId unitId)
        {
            InternalNatives._SetItemDropID(whichItem, unitId);
        }
        
        //native GetItemName takes item whichItem returns string
        public delegate String GetItemNamePrototype(JassItem whichItem);
        private static GetItemNamePrototype _GetItemName;
        public static String GetItemName(JassItem whichItem)
        {
            return InternalNatives._GetItemName(whichItem);
        }
        
        //native GetItemCharges takes item whichItem returns integer
        public delegate JassInteger GetItemChargesPrototype(JassItem whichItem);
        private static GetItemChargesPrototype _GetItemCharges;
        public static JassInteger GetItemCharges(JassItem whichItem)
        {
            return InternalNatives._GetItemCharges(whichItem);
        }
        
        //native SetItemCharges takes item whichItem, integer charges returns nothing
        public delegate void SetItemChargesPrototype(JassItem whichItem, JassInteger charges);
        private static SetItemChargesPrototype _SetItemCharges;
        public static void SetItemCharges(JassItem whichItem, JassInteger charges)
        {
            InternalNatives._SetItemCharges(whichItem, charges);
        }
        
        //native GetItemUserData takes item whichItem returns integer
        public delegate JassInteger GetItemUserDataPrototype(JassItem whichItem);
        private static GetItemUserDataPrototype _GetItemUserData;
        public static JassInteger GetItemUserData(JassItem whichItem)
        {
            return InternalNatives._GetItemUserData(whichItem);
        }
        
        //native SetItemUserData takes item whichItem, integer data returns nothing
        public delegate void SetItemUserDataPrototype(JassItem whichItem, JassInteger data);
        private static SetItemUserDataPrototype _SetItemUserData;
        public static void SetItemUserData(JassItem whichItem, JassInteger data)
        {
            InternalNatives._SetItemUserData(whichItem, data);
        }
        
        //native CreateUnit takes player id, integer unitid, real x, real y, real face returns unit
        public delegate JassUnit CreateUnitPrototype(JassPlayer id, JassObjectId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateUnitPrototype _CreateUnit;
        public static JassUnit CreateUnit(JassPlayer id, JassObjectId unitid, Single x, Single y, Single face)
        {
            return InternalNatives._CreateUnit(id, unitid, x, y, face);
        }
        
        //native CreateUnitByName takes player whichPlayer, string unitname, real x, real y, real face returns unit
        public delegate JassUnit CreateUnitByNamePrototype(JassPlayer whichPlayer, String unitname, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateUnitByNamePrototype _CreateUnitByName;
        public static JassUnit CreateUnitByName(JassPlayer whichPlayer, String unitname, Single x, Single y, Single face)
        {
            return InternalNatives._CreateUnitByName(whichPlayer, unitname, x, y, face);
        }
        
        //native CreateUnitAtLoc takes player id, integer unitid, location whichLocation, real face returns unit
        public delegate JassUnit CreateUnitAtLocPrototype(JassPlayer id, JassObjectId unitid, JassLocation whichLocation, JassRealArg face);
        private static CreateUnitAtLocPrototype _CreateUnitAtLoc;
        public static JassUnit CreateUnitAtLoc(JassPlayer id, JassObjectId unitid, JassLocation whichLocation, Single face)
        {
            return InternalNatives._CreateUnitAtLoc(id, unitid, whichLocation, face);
        }
        
        //native CreateUnitAtLocByName takes player id, string unitname, location whichLocation, real face returns unit
        public delegate JassUnit CreateUnitAtLocByNamePrototype(JassPlayer id, String unitname, JassLocation whichLocation, JassRealArg face);
        private static CreateUnitAtLocByNamePrototype _CreateUnitAtLocByName;
        public static JassUnit CreateUnitAtLocByName(JassPlayer id, String unitname, JassLocation whichLocation, Single face)
        {
            return InternalNatives._CreateUnitAtLocByName(id, unitname, whichLocation, face);
        }
        
        //native CreateCorpse takes player whichPlayer, integer unitid, real x, real y, real face returns unit
        public delegate JassUnit CreateCorpsePrototype(JassPlayer whichPlayer, JassObjectId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateCorpsePrototype _CreateCorpse;
        public static JassUnit CreateCorpse(JassPlayer whichPlayer, JassObjectId unitid, Single x, Single y, Single face)
        {
            return InternalNatives._CreateCorpse(whichPlayer, unitid, x, y, face);
        }
        
        //native KillUnit takes unit whichUnit returns nothing
        public delegate void KillUnitPrototype(JassUnit whichUnit);
        private static KillUnitPrototype _KillUnit;
        public static void KillUnit(JassUnit whichUnit)
        {
            InternalNatives._KillUnit(whichUnit);
        }
        
        //native RemoveUnit takes unit whichUnit returns nothing
        public delegate void RemoveUnitPrototype(JassUnit whichUnit);
        private static RemoveUnitPrototype _RemoveUnit;
        public static void RemoveUnit(JassUnit whichUnit)
        {
            InternalNatives._RemoveUnit(whichUnit);
        }
        
        //native ShowUnit takes unit whichUnit, boolean show returns nothing
        public delegate void ShowUnitPrototype(JassUnit whichUnit, JassBoolean show);
        private static ShowUnitPrototype _ShowUnit;
        public static void ShowUnit(JassUnit whichUnit, Boolean show)
        {
            InternalNatives._ShowUnit(whichUnit, show);
        }
        
        //native SetUnitState takes unit whichUnit, unitstate whichUnitState, real newVal returns nothing
        public delegate void SetUnitStatePrototype(JassUnit whichUnit, JassUnitState whichUnitState, JassRealArg newVal);
        private static SetUnitStatePrototype _SetUnitState;
        public static void SetUnitState(JassUnit whichUnit, JassUnitState whichUnitState, Single newVal)
        {
            InternalNatives._SetUnitState(whichUnit, whichUnitState, newVal);
        }
        
        //native SetUnitX takes unit whichUnit, real newX returns nothing
        public delegate void SetUnitXPrototype(JassUnit whichUnit, JassRealArg newX);
        private static SetUnitXPrototype _SetUnitX;
        public static void SetUnitX(JassUnit whichUnit, Single newX)
        {
            InternalNatives._SetUnitX(whichUnit, newX);
        }
        
        //native SetUnitY takes unit whichUnit, real newY returns nothing
        public delegate void SetUnitYPrototype(JassUnit whichUnit, JassRealArg newY);
        private static SetUnitYPrototype _SetUnitY;
        public static void SetUnitY(JassUnit whichUnit, Single newY)
        {
            InternalNatives._SetUnitY(whichUnit, newY);
        }
        
        //native SetUnitPosition takes unit whichUnit, real newX, real newY returns nothing
        public delegate void SetUnitPositionPrototype(JassUnit whichUnit, JassRealArg newX, JassRealArg newY);
        private static SetUnitPositionPrototype _SetUnitPosition;
        public static void SetUnitPosition(JassUnit whichUnit, Single newX, Single newY)
        {
            InternalNatives._SetUnitPosition(whichUnit, newX, newY);
        }
        
        //native SetUnitPositionLoc takes unit whichUnit, location whichLocation returns nothing
        public delegate void SetUnitPositionLocPrototype(JassUnit whichUnit, JassLocation whichLocation);
        private static SetUnitPositionLocPrototype _SetUnitPositionLoc;
        public static void SetUnitPositionLoc(JassUnit whichUnit, JassLocation whichLocation)
        {
            InternalNatives._SetUnitPositionLoc(whichUnit, whichLocation);
        }
        
        //native SetUnitFacing takes unit whichUnit, real facingAngle returns nothing
        public delegate void SetUnitFacingPrototype(JassUnit whichUnit, JassRealArg facingAngle);
        private static SetUnitFacingPrototype _SetUnitFacing;
        public static void SetUnitFacing(JassUnit whichUnit, Single facingAngle)
        {
            InternalNatives._SetUnitFacing(whichUnit, facingAngle);
        }
        
        //native SetUnitFacingTimed takes unit whichUnit, real facingAngle, real duration returns nothing
        public delegate void SetUnitFacingTimedPrototype(JassUnit whichUnit, JassRealArg facingAngle, JassRealArg duration);
        private static SetUnitFacingTimedPrototype _SetUnitFacingTimed;
        public static void SetUnitFacingTimed(JassUnit whichUnit, Single facingAngle, Single duration)
        {
            InternalNatives._SetUnitFacingTimed(whichUnit, facingAngle, duration);
        }
        
        //native SetUnitMoveSpeed takes unit whichUnit, real newSpeed returns nothing
        public delegate void SetUnitMoveSpeedPrototype(JassUnit whichUnit, JassRealArg newSpeed);
        private static SetUnitMoveSpeedPrototype _SetUnitMoveSpeed;
        public static void SetUnitMoveSpeed(JassUnit whichUnit, Single newSpeed)
        {
            InternalNatives._SetUnitMoveSpeed(whichUnit, newSpeed);
        }
        
        //native SetUnitFlyHeight takes unit whichUnit, real newHeight, real rate returns nothing
        public delegate void SetUnitFlyHeightPrototype(JassUnit whichUnit, JassRealArg newHeight, JassRealArg rate);
        private static SetUnitFlyHeightPrototype _SetUnitFlyHeight;
        public static void SetUnitFlyHeight(JassUnit whichUnit, Single newHeight, Single rate)
        {
            InternalNatives._SetUnitFlyHeight(whichUnit, newHeight, rate);
        }
        
        //native SetUnitTurnSpeed takes unit whichUnit, real newTurnSpeed returns nothing
        public delegate void SetUnitTurnSpeedPrototype(JassUnit whichUnit, JassRealArg newTurnSpeed);
        private static SetUnitTurnSpeedPrototype _SetUnitTurnSpeed;
        public static void SetUnitTurnSpeed(JassUnit whichUnit, Single newTurnSpeed)
        {
            InternalNatives._SetUnitTurnSpeed(whichUnit, newTurnSpeed);
        }
        
        //native SetUnitPropWindow takes unit whichUnit, real newPropWindowAngle returns nothing
        public delegate void SetUnitPropWindowPrototype(JassUnit whichUnit, JassRealArg newPropWindowAngle);
        private static SetUnitPropWindowPrototype _SetUnitPropWindow;
        public static void SetUnitPropWindow(JassUnit whichUnit, Single newPropWindowAngle)
        {
            InternalNatives._SetUnitPropWindow(whichUnit, newPropWindowAngle);
        }
        
        //native SetUnitAcquireRange takes unit whichUnit, real newAcquireRange returns nothing
        public delegate void SetUnitAcquireRangePrototype(JassUnit whichUnit, JassRealArg newAcquireRange);
        private static SetUnitAcquireRangePrototype _SetUnitAcquireRange;
        public static void SetUnitAcquireRange(JassUnit whichUnit, Single newAcquireRange)
        {
            InternalNatives._SetUnitAcquireRange(whichUnit, newAcquireRange);
        }
        
        //native SetUnitCreepGuard takes unit whichUnit, boolean creepGuard returns nothing
        public delegate void SetUnitCreepGuardPrototype(JassUnit whichUnit, JassBoolean creepGuard);
        private static SetUnitCreepGuardPrototype _SetUnitCreepGuard;
        public static void SetUnitCreepGuard(JassUnit whichUnit, Boolean creepGuard)
        {
            InternalNatives._SetUnitCreepGuard(whichUnit, creepGuard);
        }
        
        //native GetUnitAcquireRange takes unit whichUnit returns real
        public delegate JassRealRet GetUnitAcquireRangePrototype(JassUnit whichUnit);
        private static GetUnitAcquireRangePrototype _GetUnitAcquireRange;
        public static Single GetUnitAcquireRange(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitAcquireRange(whichUnit);
        }
        
        //native GetUnitTurnSpeed takes unit whichUnit returns real
        public delegate JassRealRet GetUnitTurnSpeedPrototype(JassUnit whichUnit);
        private static GetUnitTurnSpeedPrototype _GetUnitTurnSpeed;
        public static Single GetUnitTurnSpeed(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitTurnSpeed(whichUnit);
        }
        
        //native GetUnitPropWindow takes unit whichUnit returns real
        public delegate JassRealRet GetUnitPropWindowPrototype(JassUnit whichUnit);
        private static GetUnitPropWindowPrototype _GetUnitPropWindow;
        public static Single GetUnitPropWindow(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitPropWindow(whichUnit);
        }
        
        //native GetUnitFlyHeight takes unit whichUnit returns real
        public delegate JassRealRet GetUnitFlyHeightPrototype(JassUnit whichUnit);
        private static GetUnitFlyHeightPrototype _GetUnitFlyHeight;
        public static Single GetUnitFlyHeight(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitFlyHeight(whichUnit);
        }
        
        //native GetUnitDefaultAcquireRange takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultAcquireRangePrototype(JassUnit whichUnit);
        private static GetUnitDefaultAcquireRangePrototype _GetUnitDefaultAcquireRange;
        public static Single GetUnitDefaultAcquireRange(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitDefaultAcquireRange(whichUnit);
        }
        
        //native GetUnitDefaultTurnSpeed takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultTurnSpeedPrototype(JassUnit whichUnit);
        private static GetUnitDefaultTurnSpeedPrototype _GetUnitDefaultTurnSpeed;
        public static Single GetUnitDefaultTurnSpeed(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitDefaultTurnSpeed(whichUnit);
        }
        
        //native GetUnitDefaultPropWindow takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultPropWindowPrototype(JassUnit whichUnit);
        private static GetUnitDefaultPropWindowPrototype _GetUnitDefaultPropWindow;
        public static Single GetUnitDefaultPropWindow(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitDefaultPropWindow(whichUnit);
        }
        
        //native GetUnitDefaultFlyHeight takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultFlyHeightPrototype(JassUnit whichUnit);
        private static GetUnitDefaultFlyHeightPrototype _GetUnitDefaultFlyHeight;
        public static Single GetUnitDefaultFlyHeight(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitDefaultFlyHeight(whichUnit);
        }
        
        //native SetUnitOwner takes unit whichUnit, player whichPlayer, boolean changeColor returns nothing
        public delegate void SetUnitOwnerPrototype(JassUnit whichUnit, JassPlayer whichPlayer, JassBoolean changeColor);
        private static SetUnitOwnerPrototype _SetUnitOwner;
        public static void SetUnitOwner(JassUnit whichUnit, JassPlayer whichPlayer, Boolean changeColor)
        {
            InternalNatives._SetUnitOwner(whichUnit, whichPlayer, changeColor);
        }
        
        //native SetUnitColor takes unit whichUnit, playercolor whichColor returns nothing
        public delegate void SetUnitColorPrototype(JassUnit whichUnit, JassPlayerColor whichColor);
        private static SetUnitColorPrototype _SetUnitColor;
        public static void SetUnitColor(JassUnit whichUnit, JassPlayerColor whichColor)
        {
            InternalNatives._SetUnitColor(whichUnit, whichColor);
        }
        
        //native SetUnitScale takes unit whichUnit, real scaleX, real scaleY, real scaleZ returns nothing
        public delegate void SetUnitScalePrototype(JassUnit whichUnit, JassRealArg scaleX, JassRealArg scaleY, JassRealArg scaleZ);
        private static SetUnitScalePrototype _SetUnitScale;
        public static void SetUnitScale(JassUnit whichUnit, Single scaleX, Single scaleY, Single scaleZ)
        {
            InternalNatives._SetUnitScale(whichUnit, scaleX, scaleY, scaleZ);
        }
        
        //native SetUnitTimeScale takes unit whichUnit, real timeScale returns nothing
        public delegate void SetUnitTimeScalePrototype(JassUnit whichUnit, JassRealArg timeScale);
        private static SetUnitTimeScalePrototype _SetUnitTimeScale;
        public static void SetUnitTimeScale(JassUnit whichUnit, Single timeScale)
        {
            InternalNatives._SetUnitTimeScale(whichUnit, timeScale);
        }
        
        //native SetUnitBlendTime takes unit whichUnit, real blendTime returns nothing
        public delegate void SetUnitBlendTimePrototype(JassUnit whichUnit, JassRealArg blendTime);
        private static SetUnitBlendTimePrototype _SetUnitBlendTime;
        public static void SetUnitBlendTime(JassUnit whichUnit, Single blendTime)
        {
            InternalNatives._SetUnitBlendTime(whichUnit, blendTime);
        }
        
        //native SetUnitVertexColor takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetUnitVertexColorPrototype(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetUnitVertexColorPrototype _SetUnitVertexColor;
        public static void SetUnitVertexColor(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._SetUnitVertexColor(whichUnit, red, green, blue, alpha);
        }
        
        //native QueueUnitAnimation takes unit whichUnit, string whichAnimation returns nothing
        public delegate void QueueUnitAnimationPrototype(JassUnit whichUnit, String whichAnimation);
        private static QueueUnitAnimationPrototype _QueueUnitAnimation;
        public static void QueueUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            InternalNatives._QueueUnitAnimation(whichUnit, whichAnimation);
        }
        
        //native SetUnitAnimation takes unit whichUnit, string whichAnimation returns nothing
        public delegate void SetUnitAnimationPrototype(JassUnit whichUnit, String whichAnimation);
        private static SetUnitAnimationPrototype _SetUnitAnimation;
        public static void SetUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            InternalNatives._SetUnitAnimation(whichUnit, whichAnimation);
        }
        
        //native SetUnitAnimationByIndex takes unit whichUnit, integer whichAnimation returns nothing
        public delegate void SetUnitAnimationByIndexPrototype(JassUnit whichUnit, JassInteger whichAnimation);
        private static SetUnitAnimationByIndexPrototype _SetUnitAnimationByIndex;
        public static void SetUnitAnimationByIndex(JassUnit whichUnit, JassInteger whichAnimation)
        {
            InternalNatives._SetUnitAnimationByIndex(whichUnit, whichAnimation);
        }
        
        //native SetUnitAnimationWithRarity takes unit whichUnit, string whichAnimation, raritycontrol rarity returns nothing
        public delegate void SetUnitAnimationWithRarityPrototype(JassUnit whichUnit, String whichAnimation, JassRarityControl rarity);
        private static SetUnitAnimationWithRarityPrototype _SetUnitAnimationWithRarity;
        public static void SetUnitAnimationWithRarity(JassUnit whichUnit, String whichAnimation, JassRarityControl rarity)
        {
            InternalNatives._SetUnitAnimationWithRarity(whichUnit, whichAnimation, rarity);
        }
        
        //native AddUnitAnimationProperties takes unit whichUnit, string animProperties, boolean add returns nothing
        public delegate void AddUnitAnimationPropertiesPrototype(JassUnit whichUnit, String animProperties, JassBoolean add);
        private static AddUnitAnimationPropertiesPrototype _AddUnitAnimationProperties;
        public static void AddUnitAnimationProperties(JassUnit whichUnit, String animProperties, Boolean add)
        {
            InternalNatives._AddUnitAnimationProperties(whichUnit, animProperties, add);
        }
        
        //native SetUnitLookAt takes unit whichUnit, string whichBone, unit lookAtTarget, real offsetX, real offsetY, real offsetZ returns nothing
        public delegate void SetUnitLookAtPrototype(JassUnit whichUnit, String whichBone, JassUnit lookAtTarget, JassRealArg offsetX, JassRealArg offsetY, JassRealArg offsetZ);
        private static SetUnitLookAtPrototype _SetUnitLookAt;
        public static void SetUnitLookAt(JassUnit whichUnit, String whichBone, JassUnit lookAtTarget, Single offsetX, Single offsetY, Single offsetZ)
        {
            InternalNatives._SetUnitLookAt(whichUnit, whichBone, lookAtTarget, offsetX, offsetY, offsetZ);
        }
        
        //native ResetUnitLookAt takes unit whichUnit returns nothing
        public delegate void ResetUnitLookAtPrototype(JassUnit whichUnit);
        private static ResetUnitLookAtPrototype _ResetUnitLookAt;
        public static void ResetUnitLookAt(JassUnit whichUnit)
        {
            InternalNatives._ResetUnitLookAt(whichUnit);
        }
        
        //native SetUnitRescuable takes unit whichUnit, player byWhichPlayer, boolean flag returns nothing
        public delegate void SetUnitRescuablePrototype(JassUnit whichUnit, JassPlayer byWhichPlayer, JassBoolean flag);
        private static SetUnitRescuablePrototype _SetUnitRescuable;
        public static void SetUnitRescuable(JassUnit whichUnit, JassPlayer byWhichPlayer, Boolean flag)
        {
            InternalNatives._SetUnitRescuable(whichUnit, byWhichPlayer, flag);
        }
        
        //native SetUnitRescueRange takes unit whichUnit, real range returns nothing
        public delegate void SetUnitRescueRangePrototype(JassUnit whichUnit, JassRealArg range);
        private static SetUnitRescueRangePrototype _SetUnitRescueRange;
        public static void SetUnitRescueRange(JassUnit whichUnit, Single range)
        {
            InternalNatives._SetUnitRescueRange(whichUnit, range);
        }
        
        //native SetHeroStr takes unit whichHero, integer newStr, boolean permanent returns nothing
        public delegate void SetHeroStrPrototype(JassUnit whichHero, JassInteger newStr, JassBoolean permanent);
        private static SetHeroStrPrototype _SetHeroStr;
        public static void SetHeroStr(JassUnit whichHero, JassInteger newStr, Boolean permanent)
        {
            InternalNatives._SetHeroStr(whichHero, newStr, permanent);
        }
        
        //native SetHeroAgi takes unit whichHero, integer newAgi, boolean permanent returns nothing
        public delegate void SetHeroAgiPrototype(JassUnit whichHero, JassInteger newAgi, JassBoolean permanent);
        private static SetHeroAgiPrototype _SetHeroAgi;
        public static void SetHeroAgi(JassUnit whichHero, JassInteger newAgi, Boolean permanent)
        {
            InternalNatives._SetHeroAgi(whichHero, newAgi, permanent);
        }
        
        //native SetHeroInt takes unit whichHero, integer newInt, boolean permanent returns nothing
        public delegate void SetHeroIntPrototype(JassUnit whichHero, JassInteger newInt, JassBoolean permanent);
        private static SetHeroIntPrototype _SetHeroInt;
        public static void SetHeroInt(JassUnit whichHero, JassInteger newInt, Boolean permanent)
        {
            InternalNatives._SetHeroInt(whichHero, newInt, permanent);
        }
        
        //native GetHeroStr takes unit whichHero, boolean includeBonuses returns integer
        public delegate JassInteger GetHeroStrPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private static GetHeroStrPrototype _GetHeroStr;
        public static JassInteger GetHeroStr(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives._GetHeroStr(whichHero, includeBonuses);
        }
        
        //native GetHeroAgi takes unit whichHero, boolean includeBonuses returns integer
        public delegate JassInteger GetHeroAgiPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private static GetHeroAgiPrototype _GetHeroAgi;
        public static JassInteger GetHeroAgi(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives._GetHeroAgi(whichHero, includeBonuses);
        }
        
        //native GetHeroInt takes unit whichHero, boolean includeBonuses returns integer
        public delegate JassInteger GetHeroIntPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private static GetHeroIntPrototype _GetHeroInt;
        public static JassInteger GetHeroInt(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives._GetHeroInt(whichHero, includeBonuses);
        }
        
        //native UnitStripHeroLevel takes unit whichHero, integer howManyLevels returns boolean
        public delegate JassBoolean UnitStripHeroLevelPrototype(JassUnit whichHero, JassInteger howManyLevels);
        private static UnitStripHeroLevelPrototype _UnitStripHeroLevel;
        public static Boolean UnitStripHeroLevel(JassUnit whichHero, JassInteger howManyLevels)
        {
            return InternalNatives._UnitStripHeroLevel(whichHero, howManyLevels);
        }
        
        //native GetHeroXP takes unit whichHero returns integer
        public delegate JassInteger GetHeroXPPrototype(JassUnit whichHero);
        private static GetHeroXPPrototype _GetHeroXP;
        public static JassInteger GetHeroXP(JassUnit whichHero)
        {
            return InternalNatives._GetHeroXP(whichHero);
        }
        
        //native SetHeroXP takes unit whichHero, integer newXpVal, boolean showEyeCandy returns nothing
        public delegate void SetHeroXPPrototype(JassUnit whichHero, JassInteger newXpVal, JassBoolean showEyeCandy);
        private static SetHeroXPPrototype _SetHeroXP;
        public static void SetHeroXP(JassUnit whichHero, JassInteger newXpVal, Boolean showEyeCandy)
        {
            InternalNatives._SetHeroXP(whichHero, newXpVal, showEyeCandy);
        }
        
        //native GetHeroSkillPoints takes unit whichHero returns integer
        public delegate JassInteger GetHeroSkillPointsPrototype(JassUnit whichHero);
        private static GetHeroSkillPointsPrototype _GetHeroSkillPoints;
        public static JassInteger GetHeroSkillPoints(JassUnit whichHero)
        {
            return InternalNatives._GetHeroSkillPoints(whichHero);
        }
        
        //native UnitModifySkillPoints takes unit whichHero, integer skillPointDelta returns boolean
        public delegate JassBoolean UnitModifySkillPointsPrototype(JassUnit whichHero, JassInteger skillPointDelta);
        private static UnitModifySkillPointsPrototype _UnitModifySkillPoints;
        public static Boolean UnitModifySkillPoints(JassUnit whichHero, JassInteger skillPointDelta)
        {
            return InternalNatives._UnitModifySkillPoints(whichHero, skillPointDelta);
        }
        
        //native AddHeroXP takes unit whichHero, integer xpToAdd, boolean showEyeCandy returns nothing
        public delegate void AddHeroXPPrototype(JassUnit whichHero, JassInteger xpToAdd, JassBoolean showEyeCandy);
        private static AddHeroXPPrototype _AddHeroXP;
        public static void AddHeroXP(JassUnit whichHero, JassInteger xpToAdd, Boolean showEyeCandy)
        {
            InternalNatives._AddHeroXP(whichHero, xpToAdd, showEyeCandy);
        }
        
        //native SetHeroLevel takes unit whichHero, integer level, boolean showEyeCandy returns nothing
        public delegate void SetHeroLevelPrototype(JassUnit whichHero, JassInteger level, JassBoolean showEyeCandy);
        private static SetHeroLevelPrototype _SetHeroLevel;
        public static void SetHeroLevel(JassUnit whichHero, JassInteger level, Boolean showEyeCandy)
        {
            InternalNatives._SetHeroLevel(whichHero, level, showEyeCandy);
        }
        
        //native GetHeroLevel takes unit whichHero returns integer
        public delegate JassInteger GetHeroLevelPrototype(JassUnit whichHero);
        private static GetHeroLevelPrototype _GetHeroLevel;
        public static JassInteger GetHeroLevel(JassUnit whichHero)
        {
            return InternalNatives._GetHeroLevel(whichHero);
        }
        
        //native GetUnitLevel takes unit whichUnit returns integer
        public delegate JassInteger GetUnitLevelPrototype(JassUnit whichUnit);
        private static GetUnitLevelPrototype _GetUnitLevel;
        public static JassInteger GetUnitLevel(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitLevel(whichUnit);
        }
        
        //native GetHeroProperName takes unit whichHero returns string
        public delegate String GetHeroProperNamePrototype(JassUnit whichHero);
        private static GetHeroProperNamePrototype _GetHeroProperName;
        public static String GetHeroProperName(JassUnit whichHero)
        {
            return InternalNatives._GetHeroProperName(whichHero);
        }
        
        //native SuspendHeroXP takes unit whichHero, boolean flag returns nothing
        public delegate void SuspendHeroXPPrototype(JassUnit whichHero, JassBoolean flag);
        private static SuspendHeroXPPrototype _SuspendHeroXP;
        public static void SuspendHeroXP(JassUnit whichHero, Boolean flag)
        {
            InternalNatives._SuspendHeroXP(whichHero, flag);
        }
        
        //native IsSuspendedXP takes unit whichHero returns boolean
        public delegate JassBoolean IsSuspendedXPPrototype(JassUnit whichHero);
        private static IsSuspendedXPPrototype _IsSuspendedXP;
        public static Boolean IsSuspendedXP(JassUnit whichHero)
        {
            return InternalNatives._IsSuspendedXP(whichHero);
        }
        
        //native SelectHeroSkill takes unit whichHero, integer abilcode returns nothing
        public delegate void SelectHeroSkillPrototype(JassUnit whichHero, JassObjectId abilcode);
        private static SelectHeroSkillPrototype _SelectHeroSkill;
        public static void SelectHeroSkill(JassUnit whichHero, JassObjectId abilcode)
        {
            InternalNatives._SelectHeroSkill(whichHero, abilcode);
        }
        
        //native GetUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        public delegate JassInteger GetUnitAbilityLevelPrototype(JassUnit whichUnit, JassObjectId abilcode);
        private static GetUnitAbilityLevelPrototype _GetUnitAbilityLevel;
        public static JassInteger GetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives._GetUnitAbilityLevel(whichUnit, abilcode);
        }
        
        //native DecUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        public delegate JassInteger DecUnitAbilityLevelPrototype(JassUnit whichUnit, JassObjectId abilcode);
        private static DecUnitAbilityLevelPrototype _DecUnitAbilityLevel;
        public static JassInteger DecUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives._DecUnitAbilityLevel(whichUnit, abilcode);
        }
        
        //native IncUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        public delegate JassInteger IncUnitAbilityLevelPrototype(JassUnit whichUnit, JassObjectId abilcode);
        private static IncUnitAbilityLevelPrototype _IncUnitAbilityLevel;
        public static JassInteger IncUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives._IncUnitAbilityLevel(whichUnit, abilcode);
        }
        
        //native SetUnitAbilityLevel takes unit whichUnit, integer abilcode, integer level returns integer
        public delegate JassInteger SetUnitAbilityLevelPrototype(JassUnit whichUnit, JassObjectId abilcode, JassInteger level);
        private static SetUnitAbilityLevelPrototype _SetUnitAbilityLevel;
        public static JassInteger SetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode, JassInteger level)
        {
            return InternalNatives._SetUnitAbilityLevel(whichUnit, abilcode, level);
        }
        
        //native ReviveHero takes unit whichHero, real x, real y, boolean doEyecandy returns boolean
        public delegate JassBoolean ReviveHeroPrototype(JassUnit whichHero, JassRealArg x, JassRealArg y, JassBoolean doEyecandy);
        private static ReviveHeroPrototype _ReviveHero;
        public static Boolean ReviveHero(JassUnit whichHero, Single x, Single y, Boolean doEyecandy)
        {
            return InternalNatives._ReviveHero(whichHero, x, y, doEyecandy);
        }
        
        //native ReviveHeroLoc takes unit whichHero, location loc, boolean doEyecandy returns boolean
        public delegate JassBoolean ReviveHeroLocPrototype(JassUnit whichHero, JassLocation loc, JassBoolean doEyecandy);
        private static ReviveHeroLocPrototype _ReviveHeroLoc;
        public static Boolean ReviveHeroLoc(JassUnit whichHero, JassLocation loc, Boolean doEyecandy)
        {
            return InternalNatives._ReviveHeroLoc(whichHero, loc, doEyecandy);
        }
        
        //native SetUnitExploded takes unit whichUnit, boolean exploded returns nothing
        public delegate void SetUnitExplodedPrototype(JassUnit whichUnit, JassBoolean exploded);
        private static SetUnitExplodedPrototype _SetUnitExploded;
        public static void SetUnitExploded(JassUnit whichUnit, Boolean exploded)
        {
            InternalNatives._SetUnitExploded(whichUnit, exploded);
        }
        
        //native SetUnitInvulnerable takes unit whichUnit, boolean flag returns nothing
        public delegate void SetUnitInvulnerablePrototype(JassUnit whichUnit, JassBoolean flag);
        private static SetUnitInvulnerablePrototype _SetUnitInvulnerable;
        public static void SetUnitInvulnerable(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives._SetUnitInvulnerable(whichUnit, flag);
        }
        
        //native PauseUnit takes unit whichUnit, boolean flag returns nothing
        public delegate void PauseUnitPrototype(JassUnit whichUnit, JassBoolean flag);
        private static PauseUnitPrototype _PauseUnit;
        public static void PauseUnit(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives._PauseUnit(whichUnit, flag);
        }
        
        //native IsUnitPaused takes unit whichHero returns boolean
        public delegate JassBoolean IsUnitPausedPrototype(JassUnit whichHero);
        private static IsUnitPausedPrototype _IsUnitPaused;
        public static Boolean IsUnitPaused(JassUnit whichHero)
        {
            return InternalNatives._IsUnitPaused(whichHero);
        }
        
        //native SetUnitPathing takes unit whichUnit, boolean flag returns nothing
        public delegate void SetUnitPathingPrototype(JassUnit whichUnit, JassBoolean flag);
        private static SetUnitPathingPrototype _SetUnitPathing;
        public static void SetUnitPathing(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives._SetUnitPathing(whichUnit, flag);
        }
        
        //native ClearSelection takes nothing returns nothing
        public delegate void ClearSelectionPrototype();
        private static ClearSelectionPrototype _ClearSelection;
        public static void ClearSelection()
        {
            InternalNatives._ClearSelection();
        }
        
        //native SelectUnit takes unit whichUnit, boolean flag returns nothing
        public delegate void SelectUnitPrototype(JassUnit whichUnit, JassBoolean flag);
        private static SelectUnitPrototype _SelectUnit;
        public static void SelectUnit(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives._SelectUnit(whichUnit, flag);
        }
        
        //native GetUnitPointValue takes unit whichUnit returns integer
        public delegate JassInteger GetUnitPointValuePrototype(JassUnit whichUnit);
        private static GetUnitPointValuePrototype _GetUnitPointValue;
        public static JassInteger GetUnitPointValue(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitPointValue(whichUnit);
        }
        
        //native GetUnitPointValueByType takes integer unitType returns integer
        public delegate JassInteger GetUnitPointValueByTypePrototype(JassInteger unitType);
        private static GetUnitPointValueByTypePrototype _GetUnitPointValueByType;
        public static JassInteger GetUnitPointValueByType(JassInteger unitType)
        {
            return InternalNatives._GetUnitPointValueByType(unitType);
        }
        
        //native UnitAddItem takes unit whichUnit, item whichItem returns boolean
        public delegate JassBoolean UnitAddItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private static UnitAddItemPrototype _UnitAddItem;
        public static Boolean UnitAddItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives._UnitAddItem(whichUnit, whichItem);
        }
        
        //native UnitAddItemById takes unit whichUnit, integer itemId returns item
        public delegate JassItem UnitAddItemByIdPrototype(JassUnit whichUnit, JassObjectId itemId);
        private static UnitAddItemByIdPrototype _UnitAddItemById;
        public static JassItem UnitAddItemById(JassUnit whichUnit, JassObjectId itemId)
        {
            return InternalNatives._UnitAddItemById(whichUnit, itemId);
        }
        
        //native UnitAddItemToSlotById takes unit whichUnit, integer itemId, integer itemSlot returns boolean
        public delegate JassBoolean UnitAddItemToSlotByIdPrototype(JassUnit whichUnit, JassObjectId itemId, JassInteger itemSlot);
        private static UnitAddItemToSlotByIdPrototype _UnitAddItemToSlotById;
        public static Boolean UnitAddItemToSlotById(JassUnit whichUnit, JassObjectId itemId, JassInteger itemSlot)
        {
            return InternalNatives._UnitAddItemToSlotById(whichUnit, itemId, itemSlot);
        }
        
        //native UnitRemoveItem takes unit whichUnit, item whichItem returns nothing
        public delegate void UnitRemoveItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private static UnitRemoveItemPrototype _UnitRemoveItem;
        public static void UnitRemoveItem(JassUnit whichUnit, JassItem whichItem)
        {
            InternalNatives._UnitRemoveItem(whichUnit, whichItem);
        }
        
        //native UnitRemoveItemFromSlot takes unit whichUnit, integer itemSlot returns item
        public delegate JassItem UnitRemoveItemFromSlotPrototype(JassUnit whichUnit, JassInteger itemSlot);
        private static UnitRemoveItemFromSlotPrototype _UnitRemoveItemFromSlot;
        public static JassItem UnitRemoveItemFromSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return InternalNatives._UnitRemoveItemFromSlot(whichUnit, itemSlot);
        }
        
        //native UnitHasItem takes unit whichUnit, item whichItem returns boolean
        public delegate JassBoolean UnitHasItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private static UnitHasItemPrototype _UnitHasItem;
        public static Boolean UnitHasItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives._UnitHasItem(whichUnit, whichItem);
        }
        
        //native UnitItemInSlot takes unit whichUnit, integer itemSlot returns item
        public delegate JassItem UnitItemInSlotPrototype(JassUnit whichUnit, JassInteger itemSlot);
        private static UnitItemInSlotPrototype _UnitItemInSlot;
        public static JassItem UnitItemInSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return InternalNatives._UnitItemInSlot(whichUnit, itemSlot);
        }
        
        //native UnitInventorySize takes unit whichUnit returns integer
        public delegate JassInteger UnitInventorySizePrototype(JassUnit whichUnit);
        private static UnitInventorySizePrototype _UnitInventorySize;
        public static JassInteger UnitInventorySize(JassUnit whichUnit)
        {
            return InternalNatives._UnitInventorySize(whichUnit);
        }
        
        //native UnitDropItemPoint takes unit whichUnit, item whichItem, real x, real y returns boolean
        public delegate JassBoolean UnitDropItemPointPrototype(JassUnit whichUnit, JassItem whichItem, JassRealArg x, JassRealArg y);
        private static UnitDropItemPointPrototype _UnitDropItemPoint;
        public static Boolean UnitDropItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return InternalNatives._UnitDropItemPoint(whichUnit, whichItem, x, y);
        }
        
        //native UnitDropItemSlot takes unit whichUnit, item whichItem, integer slot returns boolean
        public delegate JassBoolean UnitDropItemSlotPrototype(JassUnit whichUnit, JassItem whichItem, JassInteger slot);
        private static UnitDropItemSlotPrototype _UnitDropItemSlot;
        public static Boolean UnitDropItemSlot(JassUnit whichUnit, JassItem whichItem, JassInteger slot)
        {
            return InternalNatives._UnitDropItemSlot(whichUnit, whichItem, slot);
        }
        
        //native UnitDropItemTarget takes unit whichUnit, item whichItem, widget target returns boolean
        public delegate JassBoolean UnitDropItemTargetPrototype(JassUnit whichUnit, JassItem whichItem, JassWidget target);
        private static UnitDropItemTargetPrototype _UnitDropItemTarget;
        public static Boolean UnitDropItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return InternalNatives._UnitDropItemTarget(whichUnit, whichItem, target);
        }
        
        //native UnitUseItem takes unit whichUnit, item whichItem returns boolean
        public delegate JassBoolean UnitUseItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private static UnitUseItemPrototype _UnitUseItem;
        public static Boolean UnitUseItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives._UnitUseItem(whichUnit, whichItem);
        }
        
        //native UnitUseItemPoint takes unit whichUnit, item whichItem, real x, real y returns boolean
        public delegate JassBoolean UnitUseItemPointPrototype(JassUnit whichUnit, JassItem whichItem, JassRealArg x, JassRealArg y);
        private static UnitUseItemPointPrototype _UnitUseItemPoint;
        public static Boolean UnitUseItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return InternalNatives._UnitUseItemPoint(whichUnit, whichItem, x, y);
        }
        
        //native UnitUseItemTarget takes unit whichUnit, item whichItem, widget target returns boolean
        public delegate JassBoolean UnitUseItemTargetPrototype(JassUnit whichUnit, JassItem whichItem, JassWidget target);
        private static UnitUseItemTargetPrototype _UnitUseItemTarget;
        public static Boolean UnitUseItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return InternalNatives._UnitUseItemTarget(whichUnit, whichItem, target);
        }
        
        //native GetUnitX takes unit whichUnit returns real
        public delegate JassRealRet GetUnitXPrototype(JassUnit whichUnit);
        private static GetUnitXPrototype _GetUnitX;
        public static Single GetUnitX(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitX(whichUnit);
        }
        
        //native GetUnitY takes unit whichUnit returns real
        public delegate JassRealRet GetUnitYPrototype(JassUnit whichUnit);
        private static GetUnitYPrototype _GetUnitY;
        public static Single GetUnitY(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitY(whichUnit);
        }
        
        //native GetUnitLoc takes unit whichUnit returns location
        public delegate JassLocation GetUnitLocPrototype(JassUnit whichUnit);
        private static GetUnitLocPrototype _GetUnitLoc;
        public static JassLocation GetUnitLoc(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitLoc(whichUnit);
        }
        
        //native GetUnitFacing takes unit whichUnit returns real
        public delegate JassRealRet GetUnitFacingPrototype(JassUnit whichUnit);
        private static GetUnitFacingPrototype _GetUnitFacing;
        public static Single GetUnitFacing(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitFacing(whichUnit);
        }
        
        //native GetUnitMoveSpeed takes unit whichUnit returns real
        public delegate JassRealRet GetUnitMoveSpeedPrototype(JassUnit whichUnit);
        private static GetUnitMoveSpeedPrototype _GetUnitMoveSpeed;
        public static Single GetUnitMoveSpeed(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitMoveSpeed(whichUnit);
        }
        
        //native GetUnitDefaultMoveSpeed takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultMoveSpeedPrototype(JassUnit whichUnit);
        private static GetUnitDefaultMoveSpeedPrototype _GetUnitDefaultMoveSpeed;
        public static Single GetUnitDefaultMoveSpeed(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitDefaultMoveSpeed(whichUnit);
        }
        
        //native GetUnitState takes unit whichUnit, unitstate whichUnitState returns real
        public delegate JassRealRet GetUnitStatePrototype(JassUnit whichUnit, JassUnitState whichUnitState);
        private static GetUnitStatePrototype _GetUnitState;
        public static Single GetUnitState(JassUnit whichUnit, JassUnitState whichUnitState)
        {
            return InternalNatives._GetUnitState(whichUnit, whichUnitState);
        }
        
        //native GetOwningPlayer takes unit whichUnit returns player
        public delegate JassPlayer GetOwningPlayerPrototype(JassUnit whichUnit);
        private static GetOwningPlayerPrototype _GetOwningPlayer;
        public static JassPlayer GetOwningPlayer(JassUnit whichUnit)
        {
            return InternalNatives._GetOwningPlayer(whichUnit);
        }
        
        //native GetUnitTypeId takes unit whichUnit returns integer
        public delegate JassObjectId GetUnitTypeIdPrototype(JassUnit whichUnit);
        private static GetUnitTypeIdPrototype _GetUnitTypeId;
        public static JassObjectId GetUnitTypeId(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitTypeId(whichUnit);
        }
        
        //native GetUnitRace takes unit whichUnit returns race
        public delegate JassRace GetUnitRacePrototype(JassUnit whichUnit);
        private static GetUnitRacePrototype _GetUnitRace;
        public static JassRace GetUnitRace(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitRace(whichUnit);
        }
        
        //native GetUnitName takes unit whichUnit returns string
        public delegate String GetUnitNamePrototype(JassUnit whichUnit);
        private static GetUnitNamePrototype _GetUnitName;
        public static String GetUnitName(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitName(whichUnit);
        }
        
        //native GetUnitFoodUsed takes unit whichUnit returns integer
        public delegate JassInteger GetUnitFoodUsedPrototype(JassUnit whichUnit);
        private static GetUnitFoodUsedPrototype _GetUnitFoodUsed;
        public static JassInteger GetUnitFoodUsed(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitFoodUsed(whichUnit);
        }
        
        //native GetUnitFoodMade takes unit whichUnit returns integer
        public delegate JassInteger GetUnitFoodMadePrototype(JassUnit whichUnit);
        private static GetUnitFoodMadePrototype _GetUnitFoodMade;
        public static JassInteger GetUnitFoodMade(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitFoodMade(whichUnit);
        }
        
        //native GetFoodMade takes integer unitId returns integer
        public delegate JassInteger GetFoodMadePrototype(JassObjectId unitId);
        private static GetFoodMadePrototype _GetFoodMade;
        public static JassInteger GetFoodMade(JassObjectId unitId)
        {
            return InternalNatives._GetFoodMade(unitId);
        }
        
        //native GetFoodUsed takes integer unitId returns integer
        public delegate JassInteger GetFoodUsedPrototype(JassObjectId unitId);
        private static GetFoodUsedPrototype _GetFoodUsed;
        public static JassInteger GetFoodUsed(JassObjectId unitId)
        {
            return InternalNatives._GetFoodUsed(unitId);
        }
        
        //native SetUnitUseFood takes unit whichUnit, boolean useFood returns nothing
        public delegate void SetUnitUseFoodPrototype(JassUnit whichUnit, JassBoolean useFood);
        private static SetUnitUseFoodPrototype _SetUnitUseFood;
        public static void SetUnitUseFood(JassUnit whichUnit, Boolean useFood)
        {
            InternalNatives._SetUnitUseFood(whichUnit, useFood);
        }
        
        //native GetUnitRallyPoint takes unit whichUnit returns location
        public delegate JassLocation GetUnitRallyPointPrototype(JassUnit whichUnit);
        private static GetUnitRallyPointPrototype _GetUnitRallyPoint;
        public static JassLocation GetUnitRallyPoint(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitRallyPoint(whichUnit);
        }
        
        //native GetUnitRallyUnit takes unit whichUnit returns unit
        public delegate JassUnit GetUnitRallyUnitPrototype(JassUnit whichUnit);
        private static GetUnitRallyUnitPrototype _GetUnitRallyUnit;
        public static JassUnit GetUnitRallyUnit(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitRallyUnit(whichUnit);
        }
        
        //native GetUnitRallyDestructable takes unit whichUnit returns destructable
        public delegate JassDestructable GetUnitRallyDestructablePrototype(JassUnit whichUnit);
        private static GetUnitRallyDestructablePrototype _GetUnitRallyDestructable;
        public static JassDestructable GetUnitRallyDestructable(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitRallyDestructable(whichUnit);
        }
        
        //native IsUnitInGroup takes unit whichUnit, group whichGroup returns boolean
        public delegate JassBoolean IsUnitInGroupPrototype(JassUnit whichUnit, JassGroup whichGroup);
        private static IsUnitInGroupPrototype _IsUnitInGroup;
        public static Boolean IsUnitInGroup(JassUnit whichUnit, JassGroup whichGroup)
        {
            return InternalNatives._IsUnitInGroup(whichUnit, whichGroup);
        }
        
        //native IsUnitInForce takes unit whichUnit, force whichForce returns boolean
        public delegate JassBoolean IsUnitInForcePrototype(JassUnit whichUnit, JassForce whichForce);
        private static IsUnitInForcePrototype _IsUnitInForce;
        public static Boolean IsUnitInForce(JassUnit whichUnit, JassForce whichForce)
        {
            return InternalNatives._IsUnitInForce(whichUnit, whichForce);
        }
        
        //native IsUnitOwnedByPlayer takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitOwnedByPlayerPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitOwnedByPlayerPrototype _IsUnitOwnedByPlayer;
        public static Boolean IsUnitOwnedByPlayer(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitOwnedByPlayer(whichUnit, whichPlayer);
        }
        
        //native IsUnitAlly takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitAllyPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitAllyPrototype _IsUnitAlly;
        public static Boolean IsUnitAlly(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitAlly(whichUnit, whichPlayer);
        }
        
        //native IsUnitEnemy takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitEnemyPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitEnemyPrototype _IsUnitEnemy;
        public static Boolean IsUnitEnemy(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitEnemy(whichUnit, whichPlayer);
        }
        
        //native IsUnitVisible takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitVisiblePrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitVisiblePrototype _IsUnitVisible;
        public static Boolean IsUnitVisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitVisible(whichUnit, whichPlayer);
        }
        
        //native IsUnitDetected takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitDetectedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitDetectedPrototype _IsUnitDetected;
        public static Boolean IsUnitDetected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitDetected(whichUnit, whichPlayer);
        }
        
        //native IsUnitInvisible takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitInvisiblePrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitInvisiblePrototype _IsUnitInvisible;
        public static Boolean IsUnitInvisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitInvisible(whichUnit, whichPlayer);
        }
        
        //native IsUnitFogged takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitFoggedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitFoggedPrototype _IsUnitFogged;
        public static Boolean IsUnitFogged(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitFogged(whichUnit, whichPlayer);
        }
        
        //native IsUnitMasked takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitMaskedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitMaskedPrototype _IsUnitMasked;
        public static Boolean IsUnitMasked(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitMasked(whichUnit, whichPlayer);
        }
        
        //native IsUnitSelected takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitSelectedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitSelectedPrototype _IsUnitSelected;
        public static Boolean IsUnitSelected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives._IsUnitSelected(whichUnit, whichPlayer);
        }
        
        //native IsUnitRace takes unit whichUnit, race whichRace returns boolean
        public delegate JassBoolean IsUnitRacePrototype(JassUnit whichUnit, JassRace whichRace);
        private static IsUnitRacePrototype _IsUnitRace;
        public static Boolean IsUnitRace(JassUnit whichUnit, JassRace whichRace)
        {
            return InternalNatives._IsUnitRace(whichUnit, whichRace);
        }
        
        //native IsUnitType takes unit whichUnit, unittype whichUnitType returns boolean
        public delegate JassBoolean IsUnitTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private static IsUnitTypePrototype _IsUnitType;
        public static Boolean IsUnitType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives._IsUnitType(whichUnit, whichUnitType);
        }
        
        //native IsUnit takes unit whichUnit, unit whichSpecifiedUnit returns boolean
        public delegate JassBoolean IsUnitPrototype(JassUnit whichUnit, JassUnit whichSpecifiedUnit);
        private static IsUnitPrototype _IsUnit;
        public static Boolean IsUnit(JassUnit whichUnit, JassUnit whichSpecifiedUnit)
        {
            return InternalNatives._IsUnit(whichUnit, whichSpecifiedUnit);
        }
        
        //native IsUnitInRange takes unit whichUnit, unit otherUnit, real distance returns boolean
        public delegate JassBoolean IsUnitInRangePrototype(JassUnit whichUnit, JassUnit otherUnit, JassRealArg distance);
        private static IsUnitInRangePrototype _IsUnitInRange;
        public static Boolean IsUnitInRange(JassUnit whichUnit, JassUnit otherUnit, Single distance)
        {
            return InternalNatives._IsUnitInRange(whichUnit, otherUnit, distance);
        }
        
        //native IsUnitInRangeXY takes unit whichUnit, real x, real y, real distance returns boolean
        public delegate JassBoolean IsUnitInRangeXYPrototype(JassUnit whichUnit, JassRealArg x, JassRealArg y, JassRealArg distance);
        private static IsUnitInRangeXYPrototype _IsUnitInRangeXY;
        public static Boolean IsUnitInRangeXY(JassUnit whichUnit, Single x, Single y, Single distance)
        {
            return InternalNatives._IsUnitInRangeXY(whichUnit, x, y, distance);
        }
        
        //native IsUnitInRangeLoc takes unit whichUnit, location whichLocation, real distance returns boolean
        public delegate JassBoolean IsUnitInRangeLocPrototype(JassUnit whichUnit, JassLocation whichLocation, JassRealArg distance);
        private static IsUnitInRangeLocPrototype _IsUnitInRangeLoc;
        public static Boolean IsUnitInRangeLoc(JassUnit whichUnit, JassLocation whichLocation, Single distance)
        {
            return InternalNatives._IsUnitInRangeLoc(whichUnit, whichLocation, distance);
        }
        
        //native IsUnitHidden takes unit whichUnit returns boolean
        public delegate JassBoolean IsUnitHiddenPrototype(JassUnit whichUnit);
        private static IsUnitHiddenPrototype _IsUnitHidden;
        public static Boolean IsUnitHidden(JassUnit whichUnit)
        {
            return InternalNatives._IsUnitHidden(whichUnit);
        }
        
        //native IsUnitIllusion takes unit whichUnit returns boolean
        public delegate JassBoolean IsUnitIllusionPrototype(JassUnit whichUnit);
        private static IsUnitIllusionPrototype _IsUnitIllusion;
        public static Boolean IsUnitIllusion(JassUnit whichUnit)
        {
            return InternalNatives._IsUnitIllusion(whichUnit);
        }
        
        //native IsUnitInTransport takes unit whichUnit, unit whichTransport returns boolean
        public delegate JassBoolean IsUnitInTransportPrototype(JassUnit whichUnit, JassUnit whichTransport);
        private static IsUnitInTransportPrototype _IsUnitInTransport;
        public static Boolean IsUnitInTransport(JassUnit whichUnit, JassUnit whichTransport)
        {
            return InternalNatives._IsUnitInTransport(whichUnit, whichTransport);
        }
        
        //native IsUnitLoaded takes unit whichUnit returns boolean
        public delegate JassBoolean IsUnitLoadedPrototype(JassUnit whichUnit);
        private static IsUnitLoadedPrototype _IsUnitLoaded;
        public static Boolean IsUnitLoaded(JassUnit whichUnit)
        {
            return InternalNatives._IsUnitLoaded(whichUnit);
        }
        
        //native IsHeroUnitId takes integer unitId returns boolean
        public delegate JassBoolean IsHeroUnitIdPrototype(JassObjectId unitId);
        private static IsHeroUnitIdPrototype _IsHeroUnitId;
        public static Boolean IsHeroUnitId(JassObjectId unitId)
        {
            return InternalNatives._IsHeroUnitId(unitId);
        }
        
        //native IsUnitIdType takes integer unitId, unittype whichUnitType returns boolean
        public delegate JassBoolean IsUnitIdTypePrototype(JassObjectId unitId, JassUnitType whichUnitType);
        private static IsUnitIdTypePrototype _IsUnitIdType;
        public static Boolean IsUnitIdType(JassObjectId unitId, JassUnitType whichUnitType)
        {
            return InternalNatives._IsUnitIdType(unitId, whichUnitType);
        }
        
        //native UnitShareVision takes unit whichUnit, player whichPlayer, boolean share returns nothing
        public delegate void UnitShareVisionPrototype(JassUnit whichUnit, JassPlayer whichPlayer, JassBoolean share);
        private static UnitShareVisionPrototype _UnitShareVision;
        public static void UnitShareVision(JassUnit whichUnit, JassPlayer whichPlayer, Boolean share)
        {
            InternalNatives._UnitShareVision(whichUnit, whichPlayer, share);
        }
        
        //native UnitSuspendDecay takes unit whichUnit, boolean suspend returns nothing
        public delegate void UnitSuspendDecayPrototype(JassUnit whichUnit, JassBoolean suspend);
        private static UnitSuspendDecayPrototype _UnitSuspendDecay;
        public static void UnitSuspendDecay(JassUnit whichUnit, Boolean suspend)
        {
            InternalNatives._UnitSuspendDecay(whichUnit, suspend);
        }
        
        //native UnitAddType takes unit whichUnit, unittype whichUnitType returns boolean
        public delegate JassBoolean UnitAddTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private static UnitAddTypePrototype _UnitAddType;
        public static Boolean UnitAddType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives._UnitAddType(whichUnit, whichUnitType);
        }
        
        //native UnitRemoveType takes unit whichUnit, unittype whichUnitType returns boolean
        public delegate JassBoolean UnitRemoveTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private static UnitRemoveTypePrototype _UnitRemoveType;
        public static Boolean UnitRemoveType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives._UnitRemoveType(whichUnit, whichUnitType);
        }
        
        //native UnitAddAbility takes unit whichUnit, integer abilityId returns boolean
        public delegate JassBoolean UnitAddAbilityPrototype(JassUnit whichUnit, JassInteger abilityId);
        private static UnitAddAbilityPrototype _UnitAddAbility;
        public static Boolean UnitAddAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return InternalNatives._UnitAddAbility(whichUnit, abilityId);
        }
        
        //native UnitRemoveAbility takes unit whichUnit, integer abilityId returns boolean
        public delegate JassBoolean UnitRemoveAbilityPrototype(JassUnit whichUnit, JassInteger abilityId);
        private static UnitRemoveAbilityPrototype _UnitRemoveAbility;
        public static Boolean UnitRemoveAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return InternalNatives._UnitRemoveAbility(whichUnit, abilityId);
        }
        
        //native UnitMakeAbilityPermanent takes unit whichUnit, boolean permanent, integer abilityId returns boolean
        public delegate JassBoolean UnitMakeAbilityPermanentPrototype(JassUnit whichUnit, JassBoolean permanent, JassInteger abilityId);
        private static UnitMakeAbilityPermanentPrototype _UnitMakeAbilityPermanent;
        public static Boolean UnitMakeAbilityPermanent(JassUnit whichUnit, Boolean permanent, JassInteger abilityId)
        {
            return InternalNatives._UnitMakeAbilityPermanent(whichUnit, permanent, abilityId);
        }
        
        //native UnitRemoveBuffs takes unit whichUnit, boolean removePositive, boolean removeNegative returns nothing
        public delegate void UnitRemoveBuffsPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative);
        private static UnitRemoveBuffsPrototype _UnitRemoveBuffs;
        public static void UnitRemoveBuffs(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative)
        {
            InternalNatives._UnitRemoveBuffs(whichUnit, removePositive, removeNegative);
        }
        
        //native UnitRemoveBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns nothing
        public delegate void UnitRemoveBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private static UnitRemoveBuffsExPrototype _UnitRemoveBuffsEx;
        public static void UnitRemoveBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            InternalNatives._UnitRemoveBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        //native UnitHasBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns boolean
        public delegate JassBoolean UnitHasBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private static UnitHasBuffsExPrototype _UnitHasBuffsEx;
        public static Boolean UnitHasBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return InternalNatives._UnitHasBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        //native UnitCountBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns integer
        public delegate JassInteger UnitCountBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private static UnitCountBuffsExPrototype _UnitCountBuffsEx;
        public static JassInteger UnitCountBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return InternalNatives._UnitCountBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        //native UnitAddSleep takes unit whichUnit, boolean add returns nothing
        public delegate void UnitAddSleepPrototype(JassUnit whichUnit, JassBoolean add);
        private static UnitAddSleepPrototype _UnitAddSleep;
        public static void UnitAddSleep(JassUnit whichUnit, Boolean add)
        {
            InternalNatives._UnitAddSleep(whichUnit, add);
        }
        
        //native UnitCanSleep takes unit whichUnit returns boolean
        public delegate JassBoolean UnitCanSleepPrototype(JassUnit whichUnit);
        private static UnitCanSleepPrototype _UnitCanSleep;
        public static Boolean UnitCanSleep(JassUnit whichUnit)
        {
            return InternalNatives._UnitCanSleep(whichUnit);
        }
        
        //native UnitAddSleepPerm takes unit whichUnit, boolean add returns nothing
        public delegate void UnitAddSleepPermPrototype(JassUnit whichUnit, JassBoolean add);
        private static UnitAddSleepPermPrototype _UnitAddSleepPerm;
        public static void UnitAddSleepPerm(JassUnit whichUnit, Boolean add)
        {
            InternalNatives._UnitAddSleepPerm(whichUnit, add);
        }
        
        //native UnitCanSleepPerm takes unit whichUnit returns boolean
        public delegate JassBoolean UnitCanSleepPermPrototype(JassUnit whichUnit);
        private static UnitCanSleepPermPrototype _UnitCanSleepPerm;
        public static Boolean UnitCanSleepPerm(JassUnit whichUnit)
        {
            return InternalNatives._UnitCanSleepPerm(whichUnit);
        }
        
        //native UnitIsSleeping takes unit whichUnit returns boolean
        public delegate JassBoolean UnitIsSleepingPrototype(JassUnit whichUnit);
        private static UnitIsSleepingPrototype _UnitIsSleeping;
        public static Boolean UnitIsSleeping(JassUnit whichUnit)
        {
            return InternalNatives._UnitIsSleeping(whichUnit);
        }
        
        //native UnitWakeUp takes unit whichUnit returns nothing
        public delegate void UnitWakeUpPrototype(JassUnit whichUnit);
        private static UnitWakeUpPrototype _UnitWakeUp;
        public static void UnitWakeUp(JassUnit whichUnit)
        {
            InternalNatives._UnitWakeUp(whichUnit);
        }
        
        //native UnitApplyTimedLife takes unit whichUnit, integer buffId, real duration returns nothing
        public delegate void UnitApplyTimedLifePrototype(JassUnit whichUnit, JassInteger buffId, JassRealArg duration);
        private static UnitApplyTimedLifePrototype _UnitApplyTimedLife;
        public static void UnitApplyTimedLife(JassUnit whichUnit, JassInteger buffId, Single duration)
        {
            InternalNatives._UnitApplyTimedLife(whichUnit, buffId, duration);
        }
        
        //native UnitIgnoreAlarm takes unit whichUnit, boolean flag returns boolean
        public delegate JassBoolean UnitIgnoreAlarmPrototype(JassUnit whichUnit, JassBoolean flag);
        private static UnitIgnoreAlarmPrototype _UnitIgnoreAlarm;
        public static Boolean UnitIgnoreAlarm(JassUnit whichUnit, Boolean flag)
        {
            return InternalNatives._UnitIgnoreAlarm(whichUnit, flag);
        }
        
        //native UnitIgnoreAlarmToggled takes unit whichUnit returns boolean
        public delegate JassBoolean UnitIgnoreAlarmToggledPrototype(JassUnit whichUnit);
        private static UnitIgnoreAlarmToggledPrototype _UnitIgnoreAlarmToggled;
        public static Boolean UnitIgnoreAlarmToggled(JassUnit whichUnit)
        {
            return InternalNatives._UnitIgnoreAlarmToggled(whichUnit);
        }
        
        //native UnitResetCooldown takes unit whichUnit returns nothing
        public delegate void UnitResetCooldownPrototype(JassUnit whichUnit);
        private static UnitResetCooldownPrototype _UnitResetCooldown;
        public static void UnitResetCooldown(JassUnit whichUnit)
        {
            InternalNatives._UnitResetCooldown(whichUnit);
        }
        
        //native UnitSetConstructionProgress takes unit whichUnit, integer constructionPercentage returns nothing
        public delegate void UnitSetConstructionProgressPrototype(JassUnit whichUnit, JassInteger constructionPercentage);
        private static UnitSetConstructionProgressPrototype _UnitSetConstructionProgress;
        public static void UnitSetConstructionProgress(JassUnit whichUnit, JassInteger constructionPercentage)
        {
            InternalNatives._UnitSetConstructionProgress(whichUnit, constructionPercentage);
        }
        
        //native UnitSetUpgradeProgress takes unit whichUnit, integer upgradePercentage returns nothing
        public delegate void UnitSetUpgradeProgressPrototype(JassUnit whichUnit, JassInteger upgradePercentage);
        private static UnitSetUpgradeProgressPrototype _UnitSetUpgradeProgress;
        public static void UnitSetUpgradeProgress(JassUnit whichUnit, JassInteger upgradePercentage)
        {
            InternalNatives._UnitSetUpgradeProgress(whichUnit, upgradePercentage);
        }
        
        //native UnitPauseTimedLife takes unit whichUnit, boolean flag returns nothing
        public delegate void UnitPauseTimedLifePrototype(JassUnit whichUnit, JassBoolean flag);
        private static UnitPauseTimedLifePrototype _UnitPauseTimedLife;
        public static void UnitPauseTimedLife(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives._UnitPauseTimedLife(whichUnit, flag);
        }
        
        //native UnitSetUsesAltIcon takes unit whichUnit, boolean flag returns nothing
        public delegate void UnitSetUsesAltIconPrototype(JassUnit whichUnit, JassBoolean flag);
        private static UnitSetUsesAltIconPrototype _UnitSetUsesAltIcon;
        public static void UnitSetUsesAltIcon(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives._UnitSetUsesAltIcon(whichUnit, flag);
        }
        
        //native UnitDamagePoint takes unit whichUnit, real delay, real radius, real x, real y, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
        public delegate JassBoolean UnitDamagePointPrototype(JassUnit whichUnit, JassRealArg delay, JassRealArg radius, JassRealArg x, JassRealArg y, JassRealArg amount, JassBoolean attack, JassBoolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType);
        private static UnitDamagePointPrototype _UnitDamagePoint;
        public static Boolean UnitDamagePoint(JassUnit whichUnit, Single delay, Single radius, Single x, Single y, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return InternalNatives._UnitDamagePoint(whichUnit, delay, radius, x, y, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        //native UnitDamageTarget takes unit whichUnit, widget target, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
        public delegate JassBoolean UnitDamageTargetPrototype(JassUnit whichUnit, JassWidget target, JassRealArg amount, JassBoolean attack, JassBoolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType);
        private static UnitDamageTargetPrototype _UnitDamageTarget;
        public static Boolean UnitDamageTarget(JassUnit whichUnit, JassWidget target, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return InternalNatives._UnitDamageTarget(whichUnit, target, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        //native IssueImmediateOrder takes unit whichUnit, string order returns boolean
        public delegate JassBoolean IssueImmediateOrderPrototype(JassUnit whichUnit, String order);
        private static IssueImmediateOrderPrototype _IssueImmediateOrder;
        public static Boolean IssueImmediateOrder(JassUnit whichUnit, String order)
        {
            return InternalNatives._IssueImmediateOrder(whichUnit, order);
        }
        
        //native IssueImmediateOrderById takes unit whichUnit, integer order returns boolean
        public delegate JassBoolean IssueImmediateOrderByIdPrototype(JassUnit whichUnit, JassOrder order);
        private static IssueImmediateOrderByIdPrototype _IssueImmediateOrderById;
        public static Boolean IssueImmediateOrderById(JassUnit whichUnit, JassOrder order)
        {
            return InternalNatives._IssueImmediateOrderById(whichUnit, order);
        }
        
        //native IssuePointOrder takes unit whichUnit, string order, real x, real y returns boolean
        public delegate JassBoolean IssuePointOrderPrototype(JassUnit whichUnit, String order, JassRealArg x, JassRealArg y);
        private static IssuePointOrderPrototype _IssuePointOrder;
        public static Boolean IssuePointOrder(JassUnit whichUnit, String order, Single x, Single y)
        {
            return InternalNatives._IssuePointOrder(whichUnit, order, x, y);
        }
        
        //native IssuePointOrderLoc takes unit whichUnit, string order, location whichLocation returns boolean
        public delegate JassBoolean IssuePointOrderLocPrototype(JassUnit whichUnit, String order, JassLocation whichLocation);
        private static IssuePointOrderLocPrototype _IssuePointOrderLoc;
        public static Boolean IssuePointOrderLoc(JassUnit whichUnit, String order, JassLocation whichLocation)
        {
            return InternalNatives._IssuePointOrderLoc(whichUnit, order, whichLocation);
        }
        
        //native IssuePointOrderById takes unit whichUnit, integer order, real x, real y returns boolean
        public delegate JassBoolean IssuePointOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassRealArg x, JassRealArg y);
        private static IssuePointOrderByIdPrototype _IssuePointOrderById;
        public static Boolean IssuePointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y)
        {
            return InternalNatives._IssuePointOrderById(whichUnit, order, x, y);
        }
        
        //native IssuePointOrderByIdLoc takes unit whichUnit, integer order, location whichLocation returns boolean
        public delegate JassBoolean IssuePointOrderByIdLocPrototype(JassUnit whichUnit, JassOrder order, JassLocation whichLocation);
        private static IssuePointOrderByIdLocPrototype _IssuePointOrderByIdLoc;
        public static Boolean IssuePointOrderByIdLoc(JassUnit whichUnit, JassOrder order, JassLocation whichLocation)
        {
            return InternalNatives._IssuePointOrderByIdLoc(whichUnit, order, whichLocation);
        }
        
        //native IssueTargetOrder takes unit whichUnit, string order, widget targetWidget returns boolean
        public delegate JassBoolean IssueTargetOrderPrototype(JassUnit whichUnit, String order, JassWidget targetWidget);
        private static IssueTargetOrderPrototype _IssueTargetOrder;
        public static Boolean IssueTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget)
        {
            return InternalNatives._IssueTargetOrder(whichUnit, order, targetWidget);
        }
        
        //native IssueTargetOrderById takes unit whichUnit, integer order, widget targetWidget returns boolean
        public delegate JassBoolean IssueTargetOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassWidget targetWidget);
        private static IssueTargetOrderByIdPrototype _IssueTargetOrderById;
        public static Boolean IssueTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget)
        {
            return InternalNatives._IssueTargetOrderById(whichUnit, order, targetWidget);
        }
        
        //native IssueInstantPointOrder takes unit whichUnit, string order, real x, real y, widget instantTargetWidget returns boolean
        public delegate JassBoolean IssueInstantPointOrderPrototype(JassUnit whichUnit, String order, JassRealArg x, JassRealArg y, JassWidget instantTargetWidget);
        private static IssueInstantPointOrderPrototype _IssueInstantPointOrder;
        public static Boolean IssueInstantPointOrder(JassUnit whichUnit, String order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return InternalNatives._IssueInstantPointOrder(whichUnit, order, x, y, instantTargetWidget);
        }
        
        //native IssueInstantPointOrderById takes unit whichUnit, integer order, real x, real y, widget instantTargetWidget returns boolean
        public delegate JassBoolean IssueInstantPointOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassRealArg x, JassRealArg y, JassWidget instantTargetWidget);
        private static IssueInstantPointOrderByIdPrototype _IssueInstantPointOrderById;
        public static Boolean IssueInstantPointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return InternalNatives._IssueInstantPointOrderById(whichUnit, order, x, y, instantTargetWidget);
        }
        
        //native IssueInstantTargetOrder takes unit whichUnit, string order, widget targetWidget, widget instantTargetWidget returns boolean
        public delegate JassBoolean IssueInstantTargetOrderPrototype(JassUnit whichUnit, String order, JassWidget targetWidget, JassWidget instantTargetWidget);
        private static IssueInstantTargetOrderPrototype _IssueInstantTargetOrder;
        public static Boolean IssueInstantTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return InternalNatives._IssueInstantTargetOrder(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        //native IssueInstantTargetOrderById takes unit whichUnit, integer order, widget targetWidget, widget instantTargetWidget returns boolean
        public delegate JassBoolean IssueInstantTargetOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget);
        private static IssueInstantTargetOrderByIdPrototype _IssueInstantTargetOrderById;
        public static Boolean IssueInstantTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return InternalNatives._IssueInstantTargetOrderById(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        //native IssueBuildOrder takes unit whichPeon, string unitToBuild, real x, real y returns boolean
        public delegate JassBoolean IssueBuildOrderPrototype(JassUnit whichPeon, String unitToBuild, JassRealArg x, JassRealArg y);
        private static IssueBuildOrderPrototype _IssueBuildOrder;
        public static Boolean IssueBuildOrder(JassUnit whichPeon, String unitToBuild, Single x, Single y)
        {
            return InternalNatives._IssueBuildOrder(whichPeon, unitToBuild, x, y);
        }
        
        //native IssueBuildOrderById takes unit whichPeon, integer unitId, real x, real y returns boolean
        public delegate JassBoolean IssueBuildOrderByIdPrototype(JassUnit whichPeon, JassObjectId unitId, JassRealArg x, JassRealArg y);
        private static IssueBuildOrderByIdPrototype _IssueBuildOrderById;
        public static Boolean IssueBuildOrderById(JassUnit whichPeon, JassObjectId unitId, Single x, Single y)
        {
            return InternalNatives._IssueBuildOrderById(whichPeon, unitId, x, y);
        }
        
        //native IssueNeutralImmediateOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild returns boolean
        public delegate JassBoolean IssueNeutralImmediateOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild);
        private static IssueNeutralImmediateOrderPrototype _IssueNeutralImmediateOrder;
        public static Boolean IssueNeutralImmediateOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild)
        {
            return InternalNatives._IssueNeutralImmediateOrder(forWhichPlayer, neutralStructure, unitToBuild);
        }
        
        //native IssueNeutralImmediateOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId returns boolean
        public delegate JassBoolean IssueNeutralImmediateOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId);
        private static IssueNeutralImmediateOrderByIdPrototype _IssueNeutralImmediateOrderById;
        public static Boolean IssueNeutralImmediateOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId)
        {
            return InternalNatives._IssueNeutralImmediateOrderById(forWhichPlayer, neutralStructure, unitId);
        }
        
        //native IssueNeutralPointOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild, real x, real y returns boolean
        public delegate JassBoolean IssueNeutralPointOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassRealArg x, JassRealArg y);
        private static IssueNeutralPointOrderPrototype _IssueNeutralPointOrder;
        public static Boolean IssueNeutralPointOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, Single x, Single y)
        {
            return InternalNatives._IssueNeutralPointOrder(forWhichPlayer, neutralStructure, unitToBuild, x, y);
        }
        
        //native IssueNeutralPointOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId, real x, real y returns boolean
        public delegate JassBoolean IssueNeutralPointOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassRealArg x, JassRealArg y);
        private static IssueNeutralPointOrderByIdPrototype _IssueNeutralPointOrderById;
        public static Boolean IssueNeutralPointOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, Single x, Single y)
        {
            return InternalNatives._IssueNeutralPointOrderById(forWhichPlayer, neutralStructure, unitId, x, y);
        }
        
        //native IssueNeutralTargetOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild, widget target returns boolean
        public delegate JassBoolean IssueNeutralTargetOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassWidget target);
        private static IssueNeutralTargetOrderPrototype _IssueNeutralTargetOrder;
        public static Boolean IssueNeutralTargetOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassWidget target)
        {
            return InternalNatives._IssueNeutralTargetOrder(forWhichPlayer, neutralStructure, unitToBuild, target);
        }
        
        //native IssueNeutralTargetOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId, widget target returns boolean
        public delegate JassBoolean IssueNeutralTargetOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassWidget target);
        private static IssueNeutralTargetOrderByIdPrototype _IssueNeutralTargetOrderById;
        public static Boolean IssueNeutralTargetOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassWidget target)
        {
            return InternalNatives._IssueNeutralTargetOrderById(forWhichPlayer, neutralStructure, unitId, target);
        }
        
        //native GetUnitCurrentOrder takes unit whichUnit returns integer
        public delegate JassInteger GetUnitCurrentOrderPrototype(JassUnit whichUnit);
        private static GetUnitCurrentOrderPrototype _GetUnitCurrentOrder;
        public static JassInteger GetUnitCurrentOrder(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitCurrentOrder(whichUnit);
        }
        
        //native SetResourceAmount takes unit whichUnit, integer amount returns nothing
        public delegate void SetResourceAmountPrototype(JassUnit whichUnit, JassInteger amount);
        private static SetResourceAmountPrototype _SetResourceAmount;
        public static void SetResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            InternalNatives._SetResourceAmount(whichUnit, amount);
        }
        
        //native AddResourceAmount takes unit whichUnit, integer amount returns nothing
        public delegate void AddResourceAmountPrototype(JassUnit whichUnit, JassInteger amount);
        private static AddResourceAmountPrototype _AddResourceAmount;
        public static void AddResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            InternalNatives._AddResourceAmount(whichUnit, amount);
        }
        
        //native GetResourceAmount takes unit whichUnit returns integer
        public delegate JassInteger GetResourceAmountPrototype(JassUnit whichUnit);
        private static GetResourceAmountPrototype _GetResourceAmount;
        public static JassInteger GetResourceAmount(JassUnit whichUnit)
        {
            return InternalNatives._GetResourceAmount(whichUnit);
        }
        
        //native WaygateGetDestinationX takes unit waygate returns real
        public delegate JassRealRet WaygateGetDestinationXPrototype(JassUnit waygate);
        private static WaygateGetDestinationXPrototype _WaygateGetDestinationX;
        public static Single WaygateGetDestinationX(JassUnit waygate)
        {
            return InternalNatives._WaygateGetDestinationX(waygate);
        }
        
        //native WaygateGetDestinationY takes unit waygate returns real
        public delegate JassRealRet WaygateGetDestinationYPrototype(JassUnit waygate);
        private static WaygateGetDestinationYPrototype _WaygateGetDestinationY;
        public static Single WaygateGetDestinationY(JassUnit waygate)
        {
            return InternalNatives._WaygateGetDestinationY(waygate);
        }
        
        //native WaygateSetDestination takes unit waygate, real x, real y returns nothing
        public delegate void WaygateSetDestinationPrototype(JassUnit waygate, JassRealArg x, JassRealArg y);
        private static WaygateSetDestinationPrototype _WaygateSetDestination;
        public static void WaygateSetDestination(JassUnit waygate, Single x, Single y)
        {
            InternalNatives._WaygateSetDestination(waygate, x, y);
        }
        
        //native WaygateActivate takes unit waygate, boolean activate returns nothing
        public delegate void WaygateActivatePrototype(JassUnit waygate, JassBoolean activate);
        private static WaygateActivatePrototype _WaygateActivate;
        public static void WaygateActivate(JassUnit waygate, Boolean activate)
        {
            InternalNatives._WaygateActivate(waygate, activate);
        }
        
        //native WaygateIsActive takes unit waygate returns boolean
        public delegate JassBoolean WaygateIsActivePrototype(JassUnit waygate);
        private static WaygateIsActivePrototype _WaygateIsActive;
        public static Boolean WaygateIsActive(JassUnit waygate)
        {
            return InternalNatives._WaygateIsActive(waygate);
        }
        
        //native AddItemToAllStock takes integer itemId, integer currentStock, integer stockMax returns nothing
        public delegate void AddItemToAllStockPrototype(JassObjectId itemId, JassInteger currentStock, JassInteger stockMax);
        private static AddItemToAllStockPrototype _AddItemToAllStock;
        public static void AddItemToAllStock(JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives._AddItemToAllStock(itemId, currentStock, stockMax);
        }
        
        //native AddItemToStock takes unit whichUnit, integer itemId, integer currentStock, integer stockMax returns nothing
        public delegate void AddItemToStockPrototype(JassUnit whichUnit, JassObjectId itemId, JassInteger currentStock, JassInteger stockMax);
        private static AddItemToStockPrototype _AddItemToStock;
        public static void AddItemToStock(JassUnit whichUnit, JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives._AddItemToStock(whichUnit, itemId, currentStock, stockMax);
        }
        
        //native AddUnitToAllStock takes integer unitId, integer currentStock, integer stockMax returns nothing
        public delegate void AddUnitToAllStockPrototype(JassObjectId unitId, JassInteger currentStock, JassInteger stockMax);
        private static AddUnitToAllStockPrototype _AddUnitToAllStock;
        public static void AddUnitToAllStock(JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives._AddUnitToAllStock(unitId, currentStock, stockMax);
        }
        
        //native AddUnitToStock takes unit whichUnit, integer unitId, integer currentStock, integer stockMax returns nothing
        public delegate void AddUnitToStockPrototype(JassUnit whichUnit, JassObjectId unitId, JassInteger currentStock, JassInteger stockMax);
        private static AddUnitToStockPrototype _AddUnitToStock;
        public static void AddUnitToStock(JassUnit whichUnit, JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives._AddUnitToStock(whichUnit, unitId, currentStock, stockMax);
        }
        
        //native RemoveItemFromAllStock takes integer itemId returns nothing
        public delegate void RemoveItemFromAllStockPrototype(JassObjectId itemId);
        private static RemoveItemFromAllStockPrototype _RemoveItemFromAllStock;
        public static void RemoveItemFromAllStock(JassObjectId itemId)
        {
            InternalNatives._RemoveItemFromAllStock(itemId);
        }
        
        //native RemoveItemFromStock takes unit whichUnit, integer itemId returns nothing
        public delegate void RemoveItemFromStockPrototype(JassUnit whichUnit, JassObjectId itemId);
        private static RemoveItemFromStockPrototype _RemoveItemFromStock;
        public static void RemoveItemFromStock(JassUnit whichUnit, JassObjectId itemId)
        {
            InternalNatives._RemoveItemFromStock(whichUnit, itemId);
        }
        
        //native RemoveUnitFromAllStock takes integer unitId returns nothing
        public delegate void RemoveUnitFromAllStockPrototype(JassObjectId unitId);
        private static RemoveUnitFromAllStockPrototype _RemoveUnitFromAllStock;
        public static void RemoveUnitFromAllStock(JassObjectId unitId)
        {
            InternalNatives._RemoveUnitFromAllStock(unitId);
        }
        
        //native RemoveUnitFromStock takes unit whichUnit, integer unitId returns nothing
        public delegate void RemoveUnitFromStockPrototype(JassUnit whichUnit, JassObjectId unitId);
        private static RemoveUnitFromStockPrototype _RemoveUnitFromStock;
        public static void RemoveUnitFromStock(JassUnit whichUnit, JassObjectId unitId)
        {
            InternalNatives._RemoveUnitFromStock(whichUnit, unitId);
        }
        
        //native SetAllItemTypeSlots takes integer slots returns nothing
        public delegate void SetAllItemTypeSlotsPrototype(JassInteger slots);
        private static SetAllItemTypeSlotsPrototype _SetAllItemTypeSlots;
        public static void SetAllItemTypeSlots(JassInteger slots)
        {
            InternalNatives._SetAllItemTypeSlots(slots);
        }
        
        //native SetAllUnitTypeSlots takes integer slots returns nothing
        public delegate void SetAllUnitTypeSlotsPrototype(JassInteger slots);
        private static SetAllUnitTypeSlotsPrototype _SetAllUnitTypeSlots;
        public static void SetAllUnitTypeSlots(JassInteger slots)
        {
            InternalNatives._SetAllUnitTypeSlots(slots);
        }
        
        //native SetItemTypeSlots takes unit whichUnit, integer slots returns nothing
        public delegate void SetItemTypeSlotsPrototype(JassUnit whichUnit, JassInteger slots);
        private static SetItemTypeSlotsPrototype _SetItemTypeSlots;
        public static void SetItemTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            InternalNatives._SetItemTypeSlots(whichUnit, slots);
        }
        
        //native SetUnitTypeSlots takes unit whichUnit, integer slots returns nothing
        public delegate void SetUnitTypeSlotsPrototype(JassUnit whichUnit, JassInteger slots);
        private static SetUnitTypeSlotsPrototype _SetUnitTypeSlots;
        public static void SetUnitTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            InternalNatives._SetUnitTypeSlots(whichUnit, slots);
        }
        
        //native GetUnitUserData takes unit whichUnit returns integer
        public delegate JassInteger GetUnitUserDataPrototype(JassUnit whichUnit);
        private static GetUnitUserDataPrototype _GetUnitUserData;
        public static JassInteger GetUnitUserData(JassUnit whichUnit)
        {
            return InternalNatives._GetUnitUserData(whichUnit);
        }
        
        //native SetUnitUserData takes unit whichUnit, integer data returns nothing
        public delegate void SetUnitUserDataPrototype(JassUnit whichUnit, JassInteger data);
        private static SetUnitUserDataPrototype _SetUnitUserData;
        public static void SetUnitUserData(JassUnit whichUnit, JassInteger data)
        {
            InternalNatives._SetUnitUserData(whichUnit, data);
        }
        
        //native Player takes integer number returns player
        public delegate JassPlayer PlayerPrototype(JassInteger number);
        private static PlayerPrototype _Player;
        public static JassPlayer Player(JassInteger number)
        {
            return InternalNatives._Player(number);
        }
        
        //native GetLocalPlayer takes nothing returns player
        public delegate JassPlayer GetLocalPlayerPrototype();
        private static GetLocalPlayerPrototype _GetLocalPlayer;
        public static JassPlayer GetLocalPlayer()
        {
            return InternalNatives._GetLocalPlayer();
        }
        
        //native IsPlayerAlly takes player whichPlayer, player otherPlayer returns boolean
        public delegate JassBoolean IsPlayerAllyPrototype(JassPlayer whichPlayer, JassPlayer otherPlayer);
        private static IsPlayerAllyPrototype _IsPlayerAlly;
        public static Boolean IsPlayerAlly(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return InternalNatives._IsPlayerAlly(whichPlayer, otherPlayer);
        }
        
        //native IsPlayerEnemy takes player whichPlayer, player otherPlayer returns boolean
        public delegate JassBoolean IsPlayerEnemyPrototype(JassPlayer whichPlayer, JassPlayer otherPlayer);
        private static IsPlayerEnemyPrototype _IsPlayerEnemy;
        public static Boolean IsPlayerEnemy(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return InternalNatives._IsPlayerEnemy(whichPlayer, otherPlayer);
        }
        
        //native IsPlayerInForce takes player whichPlayer, force whichForce returns boolean
        public delegate JassBoolean IsPlayerInForcePrototype(JassPlayer whichPlayer, JassForce whichForce);
        private static IsPlayerInForcePrototype _IsPlayerInForce;
        public static Boolean IsPlayerInForce(JassPlayer whichPlayer, JassForce whichForce)
        {
            return InternalNatives._IsPlayerInForce(whichPlayer, whichForce);
        }
        
        //native IsPlayerObserver takes player whichPlayer returns boolean
        public delegate JassBoolean IsPlayerObserverPrototype(JassPlayer whichPlayer);
        private static IsPlayerObserverPrototype _IsPlayerObserver;
        public static Boolean IsPlayerObserver(JassPlayer whichPlayer)
        {
            return InternalNatives._IsPlayerObserver(whichPlayer);
        }
        
        //native IsVisibleToPlayer takes real x, real y, player whichPlayer returns boolean
        public delegate JassBoolean IsVisibleToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private static IsVisibleToPlayerPrototype _IsVisibleToPlayer;
        public static Boolean IsVisibleToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives._IsVisibleToPlayer(x, y, whichPlayer);
        }
        
        //native IsLocationVisibleToPlayer takes location whichLocation, player whichPlayer returns boolean
        public delegate JassBoolean IsLocationVisibleToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private static IsLocationVisibleToPlayerPrototype _IsLocationVisibleToPlayer;
        public static Boolean IsLocationVisibleToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives._IsLocationVisibleToPlayer(whichLocation, whichPlayer);
        }
        
        //native IsFoggedToPlayer takes real x, real y, player whichPlayer returns boolean
        public delegate JassBoolean IsFoggedToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private static IsFoggedToPlayerPrototype _IsFoggedToPlayer;
        public static Boolean IsFoggedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives._IsFoggedToPlayer(x, y, whichPlayer);
        }
        
        //native IsLocationFoggedToPlayer takes location whichLocation, player whichPlayer returns boolean
        public delegate JassBoolean IsLocationFoggedToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private static IsLocationFoggedToPlayerPrototype _IsLocationFoggedToPlayer;
        public static Boolean IsLocationFoggedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives._IsLocationFoggedToPlayer(whichLocation, whichPlayer);
        }
        
        //native IsMaskedToPlayer takes real x, real y, player whichPlayer returns boolean
        public delegate JassBoolean IsMaskedToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private static IsMaskedToPlayerPrototype _IsMaskedToPlayer;
        public static Boolean IsMaskedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives._IsMaskedToPlayer(x, y, whichPlayer);
        }
        
        //native IsLocationMaskedToPlayer takes location whichLocation, player whichPlayer returns boolean
        public delegate JassBoolean IsLocationMaskedToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private static IsLocationMaskedToPlayerPrototype _IsLocationMaskedToPlayer;
        public static Boolean IsLocationMaskedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives._IsLocationMaskedToPlayer(whichLocation, whichPlayer);
        }
        
        //native GetPlayerRace takes player whichPlayer returns race
        public delegate JassRace GetPlayerRacePrototype(JassPlayer whichPlayer);
        private static GetPlayerRacePrototype _GetPlayerRace;
        public static JassRace GetPlayerRace(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerRace(whichPlayer);
        }
        
        //native GetPlayerId takes player whichPlayer returns integer
        public delegate JassInteger GetPlayerIdPrototype(JassPlayer whichPlayer);
        private static GetPlayerIdPrototype _GetPlayerId;
        public static JassInteger GetPlayerId(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerId(whichPlayer);
        }
        
        //native GetPlayerUnitCount takes player whichPlayer, boolean includeIncomplete returns integer
        public delegate JassInteger GetPlayerUnitCountPrototype(JassPlayer whichPlayer, JassBoolean includeIncomplete);
        private static GetPlayerUnitCountPrototype _GetPlayerUnitCount;
        public static JassInteger GetPlayerUnitCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return InternalNatives._GetPlayerUnitCount(whichPlayer, includeIncomplete);
        }
        
        //native GetPlayerTypedUnitCount takes player whichPlayer, string unitName, boolean includeIncomplete, boolean includeUpgrades returns integer
        public delegate JassInteger GetPlayerTypedUnitCountPrototype(JassPlayer whichPlayer, String unitName, JassBoolean includeIncomplete, JassBoolean includeUpgrades);
        private static GetPlayerTypedUnitCountPrototype _GetPlayerTypedUnitCount;
        public static JassInteger GetPlayerTypedUnitCount(JassPlayer whichPlayer, String unitName, Boolean includeIncomplete, Boolean includeUpgrades)
        {
            return InternalNatives._GetPlayerTypedUnitCount(whichPlayer, unitName, includeIncomplete, includeUpgrades);
        }
        
        //native GetPlayerStructureCount takes player whichPlayer, boolean includeIncomplete returns integer
        public delegate JassInteger GetPlayerStructureCountPrototype(JassPlayer whichPlayer, JassBoolean includeIncomplete);
        private static GetPlayerStructureCountPrototype _GetPlayerStructureCount;
        public static JassInteger GetPlayerStructureCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return InternalNatives._GetPlayerStructureCount(whichPlayer, includeIncomplete);
        }
        
        //native GetPlayerState takes player whichPlayer, playerstate whichPlayerState returns integer
        public delegate JassInteger GetPlayerStatePrototype(JassPlayer whichPlayer, JassPlayerState whichPlayerState);
        private static GetPlayerStatePrototype _GetPlayerState;
        public static JassInteger GetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState)
        {
            return InternalNatives._GetPlayerState(whichPlayer, whichPlayerState);
        }
        
        //native GetPlayerScore takes player whichPlayer, playerscore whichPlayerScore returns integer
        public delegate JassInteger GetPlayerScorePrototype(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore);
        private static GetPlayerScorePrototype _GetPlayerScore;
        public static JassInteger GetPlayerScore(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore)
        {
            return InternalNatives._GetPlayerScore(whichPlayer, whichPlayerScore);
        }
        
        //native GetPlayerAlliance takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting returns boolean
        public delegate JassBoolean GetPlayerAlliancePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting);
        private static GetPlayerAlliancePrototype _GetPlayerAlliance;
        public static Boolean GetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting)
        {
            return InternalNatives._GetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting);
        }
        
        //native GetPlayerHandicap takes player whichPlayer returns real
        public delegate JassRealRet GetPlayerHandicapPrototype(JassPlayer whichPlayer);
        private static GetPlayerHandicapPrototype _GetPlayerHandicap;
        public static Single GetPlayerHandicap(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerHandicap(whichPlayer);
        }
        
        //native GetPlayerHandicapXP takes player whichPlayer returns real
        public delegate JassRealRet GetPlayerHandicapXPPrototype(JassPlayer whichPlayer);
        private static GetPlayerHandicapXPPrototype _GetPlayerHandicapXP;
        public static Single GetPlayerHandicapXP(JassPlayer whichPlayer)
        {
            return InternalNatives._GetPlayerHandicapXP(whichPlayer);
        }
        
        //native SetPlayerHandicap takes player whichPlayer, real handicap returns nothing
        public delegate void SetPlayerHandicapPrototype(JassPlayer whichPlayer, JassRealArg handicap);
        private static SetPlayerHandicapPrototype _SetPlayerHandicap;
        public static void SetPlayerHandicap(JassPlayer whichPlayer, Single handicap)
        {
            InternalNatives._SetPlayerHandicap(whichPlayer, handicap);
        }
        
        //native SetPlayerHandicapXP takes player whichPlayer, real handicap returns nothing
        public delegate void SetPlayerHandicapXPPrototype(JassPlayer whichPlayer, JassRealArg handicap);
        private static SetPlayerHandicapXPPrototype _SetPlayerHandicapXP;
        public static void SetPlayerHandicapXP(JassPlayer whichPlayer, Single handicap)
        {
            InternalNatives._SetPlayerHandicapXP(whichPlayer, handicap);
        }
        
        //native SetPlayerTechMaxAllowed takes player whichPlayer, integer techid, integer maximum returns nothing
        public delegate void SetPlayerTechMaxAllowedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum);
        private static SetPlayerTechMaxAllowedPrototype _SetPlayerTechMaxAllowed;
        public static void SetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum)
        {
            InternalNatives._SetPlayerTechMaxAllowed(whichPlayer, techid, maximum);
        }
        
        //native GetPlayerTechMaxAllowed takes player whichPlayer, integer techid returns integer
        public delegate JassInteger GetPlayerTechMaxAllowedPrototype(JassPlayer whichPlayer, JassInteger techid);
        private static GetPlayerTechMaxAllowedPrototype _GetPlayerTechMaxAllowed;
        public static JassInteger GetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid)
        {
            return InternalNatives._GetPlayerTechMaxAllowed(whichPlayer, techid);
        }
        
        //native AddPlayerTechResearched takes player whichPlayer, integer techid, integer levels returns nothing
        public delegate void AddPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger levels);
        private static AddPlayerTechResearchedPrototype _AddPlayerTechResearched;
        public static void AddPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger levels)
        {
            InternalNatives._AddPlayerTechResearched(whichPlayer, techid, levels);
        }
        
        //native SetPlayerTechResearched takes player whichPlayer, integer techid, integer setToLevel returns nothing
        public delegate void SetPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel);
        private static SetPlayerTechResearchedPrototype _SetPlayerTechResearched;
        public static void SetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel)
        {
            InternalNatives._SetPlayerTechResearched(whichPlayer, techid, setToLevel);
        }
        
        //native GetPlayerTechResearched takes player whichPlayer, integer techid, boolean specificonly returns boolean
        public delegate JassBoolean GetPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassBoolean specificonly);
        private static GetPlayerTechResearchedPrototype _GetPlayerTechResearched;
        public static Boolean GetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return InternalNatives._GetPlayerTechResearched(whichPlayer, techid, specificonly);
        }
        
        //native GetPlayerTechCount takes player whichPlayer, integer techid, boolean specificonly returns integer
        public delegate JassInteger GetPlayerTechCountPrototype(JassPlayer whichPlayer, JassInteger techid, JassBoolean specificonly);
        private static GetPlayerTechCountPrototype _GetPlayerTechCount;
        public static JassInteger GetPlayerTechCount(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return InternalNatives._GetPlayerTechCount(whichPlayer, techid, specificonly);
        }
        
        //native SetPlayerUnitsOwner takes player whichPlayer, integer newOwner returns nothing
        public delegate void SetPlayerUnitsOwnerPrototype(JassPlayer whichPlayer, JassInteger newOwner);
        private static SetPlayerUnitsOwnerPrototype _SetPlayerUnitsOwner;
        public static void SetPlayerUnitsOwner(JassPlayer whichPlayer, JassInteger newOwner)
        {
            InternalNatives._SetPlayerUnitsOwner(whichPlayer, newOwner);
        }
        
        //native CripplePlayer takes player whichPlayer, force toWhichPlayers, boolean flag returns nothing
        public delegate void CripplePlayerPrototype(JassPlayer whichPlayer, JassForce toWhichPlayers, JassBoolean flag);
        private static CripplePlayerPrototype _CripplePlayer;
        public static void CripplePlayer(JassPlayer whichPlayer, JassForce toWhichPlayers, Boolean flag)
        {
            InternalNatives._CripplePlayer(whichPlayer, toWhichPlayers, flag);
        }
        
        //native SetPlayerAbilityAvailable takes player whichPlayer, integer abilid, boolean avail returns nothing
        public delegate void SetPlayerAbilityAvailablePrototype(JassPlayer whichPlayer, JassObjectId abilid, JassBoolean avail);
        private static SetPlayerAbilityAvailablePrototype _SetPlayerAbilityAvailable;
        public static void SetPlayerAbilityAvailable(JassPlayer whichPlayer, JassObjectId abilid, Boolean avail)
        {
            InternalNatives._SetPlayerAbilityAvailable(whichPlayer, abilid, avail);
        }
        
        //native SetPlayerState takes player whichPlayer, playerstate whichPlayerState, integer value returns nothing
        public delegate void SetPlayerStatePrototype(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value);
        private static SetPlayerStatePrototype _SetPlayerState;
        public static void SetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value)
        {
            InternalNatives._SetPlayerState(whichPlayer, whichPlayerState, value);
        }
        
        //native RemovePlayer takes player whichPlayer, playergameresult gameResult returns nothing
        public delegate void RemovePlayerPrototype(JassPlayer whichPlayer, JassPlayerGameResult gameResult);
        private static RemovePlayerPrototype _RemovePlayer;
        public static void RemovePlayer(JassPlayer whichPlayer, JassPlayerGameResult gameResult)
        {
            InternalNatives._RemovePlayer(whichPlayer, gameResult);
        }
        
        //native CachePlayerHeroData takes player whichPlayer returns nothing
        public delegate void CachePlayerHeroDataPrototype(JassPlayer whichPlayer);
        private static CachePlayerHeroDataPrototype _CachePlayerHeroData;
        public static void CachePlayerHeroData(JassPlayer whichPlayer)
        {
            InternalNatives._CachePlayerHeroData(whichPlayer);
        }
        
        //native SetFogStateRect takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision returns nothing
        public delegate void SetFogStateRectPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, JassBoolean useSharedVision);
        private static SetFogStateRectPrototype _SetFogStateRect;
        public static void SetFogStateRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision)
        {
            InternalNatives._SetFogStateRect(forWhichPlayer, whichState, where, useSharedVision);
        }
        
        //native SetFogStateRadius takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision returns nothing
        public delegate void SetFogStateRadiusPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRealArg centerx, JassRealArg centerY, JassRealArg radius, JassBoolean useSharedVision);
        private static SetFogStateRadiusPrototype _SetFogStateRadius;
        public static void SetFogStateRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision)
        {
            InternalNatives._SetFogStateRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision);
        }
        
        //native SetFogStateRadiusLoc takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision returns nothing
        public delegate void SetFogStateRadiusLocPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, JassRealArg radius, JassBoolean useSharedVision);
        private static SetFogStateRadiusLocPrototype _SetFogStateRadiusLoc;
        public static void SetFogStateRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision)
        {
            InternalNatives._SetFogStateRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision);
        }
        
        //native FogMaskEnable takes boolean enable returns nothing
        public delegate void FogMaskEnablePrototype(JassBoolean enable);
        private static FogMaskEnablePrototype _FogMaskEnable;
        public static void FogMaskEnable(Boolean enable)
        {
            InternalNatives._FogMaskEnable(enable);
        }
        
        //native IsFogMaskEnabled takes nothing returns boolean
        public delegate JassBoolean IsFogMaskEnabledPrototype();
        private static IsFogMaskEnabledPrototype _IsFogMaskEnabled;
        public static Boolean IsFogMaskEnabled()
        {
            return InternalNatives._IsFogMaskEnabled();
        }
        
        //native FogEnable takes boolean enable returns nothing
        public delegate void FogEnablePrototype(JassBoolean enable);
        private static FogEnablePrototype _FogEnable;
        public static void FogEnable(Boolean enable)
        {
            InternalNatives._FogEnable(enable);
        }
        
        //native IsFogEnabled takes nothing returns boolean
        public delegate JassBoolean IsFogEnabledPrototype();
        private static IsFogEnabledPrototype _IsFogEnabled;
        public static Boolean IsFogEnabled()
        {
            return InternalNatives._IsFogEnabled();
        }
        
        //native CreateFogModifierRect takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision, boolean afterUnits returns fogmodifier
        public delegate JassFogModifier CreateFogModifierRectPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, JassBoolean useSharedVision, JassBoolean afterUnits);
        private static CreateFogModifierRectPrototype _CreateFogModifierRect;
        public static JassFogModifier CreateFogModifierRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives._CreateFogModifierRect(forWhichPlayer, whichState, where, useSharedVision, afterUnits);
        }
        
        //native CreateFogModifierRadius takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
        public delegate JassFogModifier CreateFogModifierRadiusPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRealArg centerx, JassRealArg centerY, JassRealArg radius, JassBoolean useSharedVision, JassBoolean afterUnits);
        private static CreateFogModifierRadiusPrototype _CreateFogModifierRadius;
        public static JassFogModifier CreateFogModifierRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives._CreateFogModifierRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision, afterUnits);
        }
        
        //native CreateFogModifierRadiusLoc takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
        public delegate JassFogModifier CreateFogModifierRadiusLocPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, JassRealArg radius, JassBoolean useSharedVision, JassBoolean afterUnits);
        private static CreateFogModifierRadiusLocPrototype _CreateFogModifierRadiusLoc;
        public static JassFogModifier CreateFogModifierRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives._CreateFogModifierRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision, afterUnits);
        }
        
        //native DestroyFogModifier takes fogmodifier whichFogModifier returns nothing
        public delegate void DestroyFogModifierPrototype(JassFogModifier whichFogModifier);
        private static DestroyFogModifierPrototype _DestroyFogModifier;
        public static void DestroyFogModifier(JassFogModifier whichFogModifier)
        {
            InternalNatives._DestroyFogModifier(whichFogModifier);
        }
        
        //native FogModifierStart takes fogmodifier whichFogModifier returns nothing
        public delegate void FogModifierStartPrototype(JassFogModifier whichFogModifier);
        private static FogModifierStartPrototype _FogModifierStart;
        public static void FogModifierStart(JassFogModifier whichFogModifier)
        {
            InternalNatives._FogModifierStart(whichFogModifier);
        }
        
        //native FogModifierStop takes fogmodifier whichFogModifier returns nothing
        public delegate void FogModifierStopPrototype(JassFogModifier whichFogModifier);
        private static FogModifierStopPrototype _FogModifierStop;
        public static void FogModifierStop(JassFogModifier whichFogModifier)
        {
            InternalNatives._FogModifierStop(whichFogModifier);
        }
        
        //native VersionGet takes nothing returns version
        public delegate JassVersion VersionGetPrototype();
        private static VersionGetPrototype _VersionGet;
        public static JassVersion VersionGet()
        {
            return InternalNatives._VersionGet();
        }
        
        //native VersionCompatible takes version whichVersion returns boolean
        public delegate JassBoolean VersionCompatiblePrototype(JassVersion whichVersion);
        private static VersionCompatiblePrototype _VersionCompatible;
        public static Boolean VersionCompatible(JassVersion whichVersion)
        {
            return InternalNatives._VersionCompatible(whichVersion);
        }
        
        //native VersionSupported takes version whichVersion returns boolean
        public delegate JassBoolean VersionSupportedPrototype(JassVersion whichVersion);
        private static VersionSupportedPrototype _VersionSupported;
        public static Boolean VersionSupported(JassVersion whichVersion)
        {
            return InternalNatives._VersionSupported(whichVersion);
        }
        
        //native EndGame takes boolean doScoreScreen returns nothing
        public delegate void EndGamePrototype(JassBoolean doScoreScreen);
        private static EndGamePrototype _EndGame;
        public static void EndGame(Boolean doScoreScreen)
        {
            InternalNatives._EndGame(doScoreScreen);
        }
        
        //native ChangeLevel takes string newLevel, boolean doScoreScreen returns nothing
        public delegate void ChangeLevelPrototype(String newLevel, JassBoolean doScoreScreen);
        private static ChangeLevelPrototype _ChangeLevel;
        public static void ChangeLevel(String newLevel, Boolean doScoreScreen)
        {
            InternalNatives._ChangeLevel(newLevel, doScoreScreen);
        }
        
        //native RestartGame takes boolean doScoreScreen returns nothing
        public delegate void RestartGamePrototype(JassBoolean doScoreScreen);
        private static RestartGamePrototype _RestartGame;
        public static void RestartGame(Boolean doScoreScreen)
        {
            InternalNatives._RestartGame(doScoreScreen);
        }
        
        //native ReloadGame takes nothing returns nothing
        public delegate void ReloadGamePrototype();
        private static ReloadGamePrototype _ReloadGame;
        public static void ReloadGame()
        {
            InternalNatives._ReloadGame();
        }
        
        //native SetCampaignMenuRace takes race r returns nothing
        public delegate void SetCampaignMenuRacePrototype(JassRace r);
        private static SetCampaignMenuRacePrototype _SetCampaignMenuRace;
        public static void SetCampaignMenuRace(JassRace r)
        {
            InternalNatives._SetCampaignMenuRace(r);
        }
        
        //native SetCampaignMenuRaceEx takes integer campaignIndex returns nothing
        public delegate void SetCampaignMenuRaceExPrototype(JassInteger campaignIndex);
        private static SetCampaignMenuRaceExPrototype _SetCampaignMenuRaceEx;
        public static void SetCampaignMenuRaceEx(JassInteger campaignIndex)
        {
            InternalNatives._SetCampaignMenuRaceEx(campaignIndex);
        }
        
        //native ForceCampaignSelectScreen takes nothing returns nothing
        public delegate void ForceCampaignSelectScreenPrototype();
        private static ForceCampaignSelectScreenPrototype _ForceCampaignSelectScreen;
        public static void ForceCampaignSelectScreen()
        {
            InternalNatives._ForceCampaignSelectScreen();
        }
        
        //native LoadGame takes string saveFileName, boolean doScoreScreen returns nothing
        public delegate void LoadGamePrototype(String saveFileName, JassBoolean doScoreScreen);
        private static LoadGamePrototype _LoadGame;
        public static void LoadGame(String saveFileName, Boolean doScoreScreen)
        {
            InternalNatives._LoadGame(saveFileName, doScoreScreen);
        }
        
        //native SaveGame takes string saveFileName returns nothing
        public delegate void SaveGamePrototype(String saveFileName);
        private static SaveGamePrototype _SaveGame;
        public static void SaveGame(String saveFileName)
        {
            InternalNatives._SaveGame(saveFileName);
        }
        
        //native RenameSaveDirectory takes string sourceDirName, string destDirName returns boolean
        public delegate JassBoolean RenameSaveDirectoryPrototype(String sourceDirName, String destDirName);
        private static RenameSaveDirectoryPrototype _RenameSaveDirectory;
        public static Boolean RenameSaveDirectory(String sourceDirName, String destDirName)
        {
            return InternalNatives._RenameSaveDirectory(sourceDirName, destDirName);
        }
        
        //native RemoveSaveDirectory takes string sourceDirName returns boolean
        public delegate JassBoolean RemoveSaveDirectoryPrototype(String sourceDirName);
        private static RemoveSaveDirectoryPrototype _RemoveSaveDirectory;
        public static Boolean RemoveSaveDirectory(String sourceDirName)
        {
            return InternalNatives._RemoveSaveDirectory(sourceDirName);
        }
        
        //native CopySaveGame takes string sourceSaveName, string destSaveName returns boolean
        public delegate JassBoolean CopySaveGamePrototype(String sourceSaveName, String destSaveName);
        private static CopySaveGamePrototype _CopySaveGame;
        public static Boolean CopySaveGame(String sourceSaveName, String destSaveName)
        {
            return InternalNatives._CopySaveGame(sourceSaveName, destSaveName);
        }
        
        //native SaveGameExists takes string saveName returns boolean
        public delegate JassBoolean SaveGameExistsPrototype(String saveName);
        private static SaveGameExistsPrototype _SaveGameExists;
        public static Boolean SaveGameExists(String saveName)
        {
            return InternalNatives._SaveGameExists(saveName);
        }
        
        //native SyncSelections takes nothing returns nothing
        public delegate void SyncSelectionsPrototype();
        private static SyncSelectionsPrototype _SyncSelections;
        public static void SyncSelections()
        {
            InternalNatives._SyncSelections();
        }
        
        //native SetFloatGameState takes fgamestate whichFloatGameState, real value returns nothing
        public delegate void SetFloatGameStatePrototype(JassFGameState whichFloatGameState, JassRealArg value);
        private static SetFloatGameStatePrototype _SetFloatGameState;
        public static void SetFloatGameState(JassFGameState whichFloatGameState, Single value)
        {
            InternalNatives._SetFloatGameState(whichFloatGameState, value);
        }
        
        //native GetFloatGameState takes fgamestate whichFloatGameState returns real
        public delegate JassRealRet GetFloatGameStatePrototype(JassFGameState whichFloatGameState);
        private static GetFloatGameStatePrototype _GetFloatGameState;
        public static Single GetFloatGameState(JassFGameState whichFloatGameState)
        {
            return InternalNatives._GetFloatGameState(whichFloatGameState);
        }
        
        //native SetIntegerGameState takes igamestate whichIntegerGameState, integer value returns nothing
        public delegate void SetIntegerGameStatePrototype(JassIGameState whichIntegerGameState, JassInteger value);
        private static SetIntegerGameStatePrototype _SetIntegerGameState;
        public static void SetIntegerGameState(JassIGameState whichIntegerGameState, JassInteger value)
        {
            InternalNatives._SetIntegerGameState(whichIntegerGameState, value);
        }
        
        //native GetIntegerGameState takes igamestate whichIntegerGameState returns integer
        public delegate JassInteger GetIntegerGameStatePrototype(JassIGameState whichIntegerGameState);
        private static GetIntegerGameStatePrototype _GetIntegerGameState;
        public static JassInteger GetIntegerGameState(JassIGameState whichIntegerGameState)
        {
            return InternalNatives._GetIntegerGameState(whichIntegerGameState);
        }
        
        //native SetTutorialCleared takes boolean cleared returns nothing
        public delegate void SetTutorialClearedPrototype(JassBoolean cleared);
        private static SetTutorialClearedPrototype _SetTutorialCleared;
        public static void SetTutorialCleared(Boolean cleared)
        {
            InternalNatives._SetTutorialCleared(cleared);
        }
        
        //native SetMissionAvailable takes integer campaignNumber, integer missionNumber, boolean available returns nothing
        public delegate void SetMissionAvailablePrototype(JassInteger campaignNumber, JassInteger missionNumber, JassBoolean available);
        private static SetMissionAvailablePrototype _SetMissionAvailable;
        public static void SetMissionAvailable(JassInteger campaignNumber, JassInteger missionNumber, Boolean available)
        {
            InternalNatives._SetMissionAvailable(campaignNumber, missionNumber, available);
        }
        
        //native SetCampaignAvailable takes integer campaignNumber, boolean available returns nothing
        public delegate void SetCampaignAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private static SetCampaignAvailablePrototype _SetCampaignAvailable;
        public static void SetCampaignAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives._SetCampaignAvailable(campaignNumber, available);
        }
        
        //native SetOpCinematicAvailable takes integer campaignNumber, boolean available returns nothing
        public delegate void SetOpCinematicAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private static SetOpCinematicAvailablePrototype _SetOpCinematicAvailable;
        public static void SetOpCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives._SetOpCinematicAvailable(campaignNumber, available);
        }
        
        //native SetEdCinematicAvailable takes integer campaignNumber, boolean available returns nothing
        public delegate void SetEdCinematicAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private static SetEdCinematicAvailablePrototype _SetEdCinematicAvailable;
        public static void SetEdCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives._SetEdCinematicAvailable(campaignNumber, available);
        }
        
        //native GetDefaultDifficulty takes nothing returns gamedifficulty
        public delegate JassGameDifficulty GetDefaultDifficultyPrototype();
        private static GetDefaultDifficultyPrototype _GetDefaultDifficulty;
        public static JassGameDifficulty GetDefaultDifficulty()
        {
            return InternalNatives._GetDefaultDifficulty();
        }
        
        //native SetDefaultDifficulty takes gamedifficulty g returns nothing
        public delegate void SetDefaultDifficultyPrototype(JassGameDifficulty g);
        private static SetDefaultDifficultyPrototype _SetDefaultDifficulty;
        public static void SetDefaultDifficulty(JassGameDifficulty g)
        {
            InternalNatives._SetDefaultDifficulty(g);
        }
        
        //native SetCustomCampaignButtonVisible takes integer whichButton, boolean visible returns nothing
        public delegate void SetCustomCampaignButtonVisiblePrototype(JassInteger whichButton, JassBoolean visible);
        private static SetCustomCampaignButtonVisiblePrototype _SetCustomCampaignButtonVisible;
        public static void SetCustomCampaignButtonVisible(JassInteger whichButton, Boolean visible)
        {
            InternalNatives._SetCustomCampaignButtonVisible(whichButton, visible);
        }
        
        //native GetCustomCampaignButtonVisible takes integer whichButton returns boolean
        public delegate JassBoolean GetCustomCampaignButtonVisiblePrototype(JassInteger whichButton);
        private static GetCustomCampaignButtonVisiblePrototype _GetCustomCampaignButtonVisible;
        public static Boolean GetCustomCampaignButtonVisible(JassInteger whichButton)
        {
            return InternalNatives._GetCustomCampaignButtonVisible(whichButton);
        }
        
        //native DoNotSaveReplay takes nothing returns nothing
        public delegate void DoNotSaveReplayPrototype();
        private static DoNotSaveReplayPrototype _DoNotSaveReplay;
        public static void DoNotSaveReplay()
        {
            InternalNatives._DoNotSaveReplay();
        }
        
        //native DialogCreate takes nothing returns dialog
        public delegate JassDialog DialogCreatePrototype();
        private static DialogCreatePrototype _DialogCreate;
        public static JassDialog DialogCreate()
        {
            return InternalNatives._DialogCreate();
        }
        
        //native DialogDestroy takes dialog whichDialog returns nothing
        public delegate void DialogDestroyPrototype(JassDialog whichDialog);
        private static DialogDestroyPrototype _DialogDestroy;
        public static void DialogDestroy(JassDialog whichDialog)
        {
            InternalNatives._DialogDestroy(whichDialog);
        }
        
        //native DialogClear takes dialog whichDialog returns nothing
        public delegate void DialogClearPrototype(JassDialog whichDialog);
        private static DialogClearPrototype _DialogClear;
        public static void DialogClear(JassDialog whichDialog)
        {
            InternalNatives._DialogClear(whichDialog);
        }
        
        //native DialogSetMessage takes dialog whichDialog, string messageText returns nothing
        public delegate void DialogSetMessagePrototype(JassDialog whichDialog, String messageText);
        private static DialogSetMessagePrototype _DialogSetMessage;
        public static void DialogSetMessage(JassDialog whichDialog, String messageText)
        {
            InternalNatives._DialogSetMessage(whichDialog, messageText);
        }
        
        //native DialogAddButton takes dialog whichDialog, string buttonText, integer hotkey returns button
        public delegate JassButton DialogAddButtonPrototype(JassDialog whichDialog, String buttonText, JassInteger hotkey);
        private static DialogAddButtonPrototype _DialogAddButton;
        public static JassButton DialogAddButton(JassDialog whichDialog, String buttonText, JassInteger hotkey)
        {
            return InternalNatives._DialogAddButton(whichDialog, buttonText, hotkey);
        }
        
        //native DialogAddQuitButton takes dialog whichDialog, boolean doScoreScreen, string buttonText, integer hotkey returns button
        public delegate JassButton DialogAddQuitButtonPrototype(JassDialog whichDialog, JassBoolean doScoreScreen, String buttonText, JassInteger hotkey);
        private static DialogAddQuitButtonPrototype _DialogAddQuitButton;
        public static JassButton DialogAddQuitButton(JassDialog whichDialog, Boolean doScoreScreen, String buttonText, JassInteger hotkey)
        {
            return InternalNatives._DialogAddQuitButton(whichDialog, doScoreScreen, buttonText, hotkey);
        }
        
        //native DialogDisplay takes player whichPlayer, dialog whichDialog, boolean flag returns nothing
        public delegate void DialogDisplayPrototype(JassPlayer whichPlayer, JassDialog whichDialog, JassBoolean flag);
        private static DialogDisplayPrototype _DialogDisplay;
        public static void DialogDisplay(JassPlayer whichPlayer, JassDialog whichDialog, Boolean flag)
        {
            InternalNatives._DialogDisplay(whichPlayer, whichDialog, flag);
        }
        
        //native ReloadGameCachesFromDisk takes nothing returns boolean
        public delegate JassBoolean ReloadGameCachesFromDiskPrototype();
        private static ReloadGameCachesFromDiskPrototype _ReloadGameCachesFromDisk;
        public static Boolean ReloadGameCachesFromDisk()
        {
            return InternalNatives._ReloadGameCachesFromDisk();
        }
        
        //native InitGameCache takes string campaignFile returns gamecache
        public delegate JassGameCache InitGameCachePrototype(String campaignFile);
        private static InitGameCachePrototype _InitGameCache;
        public static JassGameCache InitGameCache(String campaignFile)
        {
            return InternalNatives._InitGameCache(campaignFile);
        }
        
        //native SaveGameCache takes gamecache whichCache returns boolean
        public delegate JassBoolean SaveGameCachePrototype(JassGameCache whichCache);
        private static SaveGameCachePrototype _SaveGameCache;
        public static Boolean SaveGameCache(JassGameCache whichCache)
        {
            return InternalNatives._SaveGameCache(whichCache);
        }
        
        //native StoreInteger takes gamecache cache, string missionKey, string key, integer value returns nothing
        public delegate void StoreIntegerPrototype(JassGameCache cache, String missionKey, String key, JassInteger value);
        private static StoreIntegerPrototype _StoreInteger;
        public static void StoreInteger(JassGameCache cache, String missionKey, String key, JassInteger value)
        {
            InternalNatives._StoreInteger(cache, missionKey, key, value);
        }
        
        //native StoreReal takes gamecache cache, string missionKey, string key, real value returns nothing
        public delegate void StoreRealPrototype(JassGameCache cache, String missionKey, String key, JassRealArg value);
        private static StoreRealPrototype _StoreReal;
        public static void StoreReal(JassGameCache cache, String missionKey, String key, Single value)
        {
            InternalNatives._StoreReal(cache, missionKey, key, value);
        }
        
        //native StoreBoolean takes gamecache cache, string missionKey, string key, boolean value returns nothing
        public delegate void StoreBooleanPrototype(JassGameCache cache, String missionKey, String key, JassBoolean value);
        private static StoreBooleanPrototype _StoreBoolean;
        public static void StoreBoolean(JassGameCache cache, String missionKey, String key, Boolean value)
        {
            InternalNatives._StoreBoolean(cache, missionKey, key, value);
        }
        
        //native StoreUnit takes gamecache cache, string missionKey, string key, unit whichUnit returns boolean
        public delegate JassBoolean StoreUnitPrototype(JassGameCache cache, String missionKey, String key, JassUnit whichUnit);
        private static StoreUnitPrototype _StoreUnit;
        public static Boolean StoreUnit(JassGameCache cache, String missionKey, String key, JassUnit whichUnit)
        {
            return InternalNatives._StoreUnit(cache, missionKey, key, whichUnit);
        }
        
        //native StoreString takes gamecache cache, string missionKey, string key, string value returns boolean
        public delegate JassBoolean StoreStringPrototype(JassGameCache cache, String missionKey, String key, String value);
        private static StoreStringPrototype _StoreString;
        public static Boolean StoreString(JassGameCache cache, String missionKey, String key, String value)
        {
            return InternalNatives._StoreString(cache, missionKey, key, value);
        }
        
        //native SyncStoredInteger takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredIntegerPrototype(JassGameCache cache, String missionKey, String key);
        private static SyncStoredIntegerPrototype _SyncStoredInteger;
        public static void SyncStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._SyncStoredInteger(cache, missionKey, key);
        }
        
        //native SyncStoredReal takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredRealPrototype(JassGameCache cache, String missionKey, String key);
        private static SyncStoredRealPrototype _SyncStoredReal;
        public static void SyncStoredReal(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._SyncStoredReal(cache, missionKey, key);
        }
        
        //native SyncStoredBoolean takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredBooleanPrototype(JassGameCache cache, String missionKey, String key);
        private static SyncStoredBooleanPrototype _SyncStoredBoolean;
        public static void SyncStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._SyncStoredBoolean(cache, missionKey, key);
        }
        
        //native SyncStoredUnit takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredUnitPrototype(JassGameCache cache, String missionKey, String key);
        private static SyncStoredUnitPrototype _SyncStoredUnit;
        public static void SyncStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._SyncStoredUnit(cache, missionKey, key);
        }
        
        //native SyncStoredString takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredStringPrototype(JassGameCache cache, String missionKey, String key);
        private static SyncStoredStringPrototype _SyncStoredString;
        public static void SyncStoredString(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._SyncStoredString(cache, missionKey, key);
        }
        
        //native HaveStoredInteger takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredIntegerPrototype(JassGameCache cache, String missionKey, String key);
        private static HaveStoredIntegerPrototype _HaveStoredInteger;
        public static Boolean HaveStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._HaveStoredInteger(cache, missionKey, key);
        }
        
        //native HaveStoredReal takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredRealPrototype(JassGameCache cache, String missionKey, String key);
        private static HaveStoredRealPrototype _HaveStoredReal;
        public static Boolean HaveStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._HaveStoredReal(cache, missionKey, key);
        }
        
        //native HaveStoredBoolean takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredBooleanPrototype(JassGameCache cache, String missionKey, String key);
        private static HaveStoredBooleanPrototype _HaveStoredBoolean;
        public static Boolean HaveStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._HaveStoredBoolean(cache, missionKey, key);
        }
        
        //native HaveStoredUnit takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredUnitPrototype(JassGameCache cache, String missionKey, String key);
        private static HaveStoredUnitPrototype _HaveStoredUnit;
        public static Boolean HaveStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._HaveStoredUnit(cache, missionKey, key);
        }
        
        //native HaveStoredString takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredStringPrototype(JassGameCache cache, String missionKey, String key);
        private static HaveStoredStringPrototype _HaveStoredString;
        public static Boolean HaveStoredString(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._HaveStoredString(cache, missionKey, key);
        }
        
        //native FlushGameCache takes gamecache cache returns nothing
        public delegate void FlushGameCachePrototype(JassGameCache cache);
        private static FlushGameCachePrototype _FlushGameCache;
        public static void FlushGameCache(JassGameCache cache)
        {
            InternalNatives._FlushGameCache(cache);
        }
        
        //native FlushStoredMission takes gamecache cache, string missionKey returns nothing
        public delegate void FlushStoredMissionPrototype(JassGameCache cache, String missionKey);
        private static FlushStoredMissionPrototype _FlushStoredMission;
        public static void FlushStoredMission(JassGameCache cache, String missionKey)
        {
            InternalNatives._FlushStoredMission(cache, missionKey);
        }
        
        //native FlushStoredInteger takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredIntegerPrototype(JassGameCache cache, String missionKey, String key);
        private static FlushStoredIntegerPrototype _FlushStoredInteger;
        public static void FlushStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._FlushStoredInteger(cache, missionKey, key);
        }
        
        //native FlushStoredReal takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredRealPrototype(JassGameCache cache, String missionKey, String key);
        private static FlushStoredRealPrototype _FlushStoredReal;
        public static void FlushStoredReal(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._FlushStoredReal(cache, missionKey, key);
        }
        
        //native FlushStoredBoolean takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredBooleanPrototype(JassGameCache cache, String missionKey, String key);
        private static FlushStoredBooleanPrototype _FlushStoredBoolean;
        public static void FlushStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._FlushStoredBoolean(cache, missionKey, key);
        }
        
        //native FlushStoredUnit takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredUnitPrototype(JassGameCache cache, String missionKey, String key);
        private static FlushStoredUnitPrototype _FlushStoredUnit;
        public static void FlushStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._FlushStoredUnit(cache, missionKey, key);
        }
        
        //native FlushStoredString takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredStringPrototype(JassGameCache cache, String missionKey, String key);
        private static FlushStoredStringPrototype _FlushStoredString;
        public static void FlushStoredString(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives._FlushStoredString(cache, missionKey, key);
        }
        
        //native GetStoredInteger takes gamecache cache, string missionKey, string key returns integer
        public delegate JassInteger GetStoredIntegerPrototype(JassGameCache cache, String missionKey, String key);
        private static GetStoredIntegerPrototype _GetStoredInteger;
        public static JassInteger GetStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._GetStoredInteger(cache, missionKey, key);
        }
        
        //native GetStoredReal takes gamecache cache, string missionKey, string key returns real
        public delegate JassRealRet GetStoredRealPrototype(JassGameCache cache, String missionKey, String key);
        private static GetStoredRealPrototype _GetStoredReal;
        public static Single GetStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._GetStoredReal(cache, missionKey, key);
        }
        
        //native GetStoredBoolean takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean GetStoredBooleanPrototype(JassGameCache cache, String missionKey, String key);
        private static GetStoredBooleanPrototype _GetStoredBoolean;
        public static Boolean GetStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._GetStoredBoolean(cache, missionKey, key);
        }
        
        //native GetStoredString takes gamecache cache, string missionKey, string key returns string
        public delegate String GetStoredStringPrototype(JassGameCache cache, String missionKey, String key);
        private static GetStoredStringPrototype _GetStoredString;
        public static String GetStoredString(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives._GetStoredString(cache, missionKey, key);
        }
        
        //native RestoreUnit takes gamecache cache, string missionKey, string key, player forWhichPlayer, real x, real y, real facing returns unit
        public delegate JassUnit RestoreUnitPrototype(JassGameCache cache, String missionKey, String key, JassPlayer forWhichPlayer, JassRealArg x, JassRealArg y, JassRealArg facing);
        private static RestoreUnitPrototype _RestoreUnit;
        public static JassUnit RestoreUnit(JassGameCache cache, String missionKey, String key, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return InternalNatives._RestoreUnit(cache, missionKey, key, forWhichPlayer, x, y, facing);
        }
        
        //native InitHashtable takes nothing returns hashtable
        public delegate JassHashTable InitHashtablePrototype();
        private static InitHashtablePrototype _InitHashtable;
        public static JassHashTable InitHashtable()
        {
            return InternalNatives._InitHashtable();
        }
        
        //native SaveInteger takes hashtable table, integer parentKey, integer childKey, integer value returns nothing
        public delegate void SaveIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value);
        private static SaveIntegerPrototype _SaveInteger;
        public static void SaveInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value)
        {
            InternalNatives._SaveInteger(table, parentKey, childKey, value);
        }
        
        //native SaveReal takes hashtable table, integer parentKey, integer childKey, real value returns nothing
        public delegate void SaveRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRealArg value);
        private static SaveRealPrototype _SaveReal;
        public static void SaveReal(JassHashTable table, JassInteger parentKey, JassInteger childKey, Single value)
        {
            InternalNatives._SaveReal(table, parentKey, childKey, value);
        }
        
        //native SaveBoolean takes hashtable table, integer parentKey, integer childKey, boolean value returns nothing
        public delegate void SaveBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBoolean value);
        private static SaveBooleanPrototype _SaveBoolean;
        public static void SaveBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey, Boolean value)
        {
            InternalNatives._SaveBoolean(table, parentKey, childKey, value);
        }
        
        //native SaveStr takes hashtable table, integer parentKey, integer childKey, string value returns boolean
        public delegate JassBoolean SaveStrPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, String value);
        private static SaveStrPrototype _SaveStr;
        public static Boolean SaveStr(JassHashTable table, JassInteger parentKey, JassInteger childKey, String value)
        {
            return InternalNatives._SaveStr(table, parentKey, childKey, value);
        }
        
        //native SavePlayerHandle takes hashtable table, integer parentKey, integer childKey, player whichPlayer returns boolean
        public delegate JassBoolean SavePlayerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer);
        private static SavePlayerHandlePrototype _SavePlayerHandle;
        public static Boolean SavePlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer)
        {
            return InternalNatives._SavePlayerHandle(table, parentKey, childKey, whichPlayer);
        }
        
        //native SaveWidgetHandle takes hashtable table, integer parentKey, integer childKey, widget whichWidget returns boolean
        public delegate JassBoolean SaveWidgetHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget);
        private static SaveWidgetHandlePrototype _SaveWidgetHandle;
        public static Boolean SaveWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget)
        {
            return InternalNatives._SaveWidgetHandle(table, parentKey, childKey, whichWidget);
        }
        
        //native SaveDestructableHandle takes hashtable table, integer parentKey, integer childKey, destructable whichDestructable returns boolean
        public delegate JassBoolean SaveDestructableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable);
        private static SaveDestructableHandlePrototype _SaveDestructableHandle;
        public static Boolean SaveDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable)
        {
            return InternalNatives._SaveDestructableHandle(table, parentKey, childKey, whichDestructable);
        }
        
        //native SaveItemHandle takes hashtable table, integer parentKey, integer childKey, item whichItem returns boolean
        public delegate JassBoolean SaveItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem);
        private static SaveItemHandlePrototype _SaveItemHandle;
        public static Boolean SaveItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem)
        {
            return InternalNatives._SaveItemHandle(table, parentKey, childKey, whichItem);
        }
        
        //native SaveUnitHandle takes hashtable table, integer parentKey, integer childKey, unit whichUnit returns boolean
        public delegate JassBoolean SaveUnitHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit);
        private static SaveUnitHandlePrototype _SaveUnitHandle;
        public static Boolean SaveUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit)
        {
            return InternalNatives._SaveUnitHandle(table, parentKey, childKey, whichUnit);
        }
        
        //native SaveAbilityHandle takes hashtable table, integer parentKey, integer childKey, ability whichAbility returns boolean
        public delegate JassBoolean SaveAbilityHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility);
        private static SaveAbilityHandlePrototype _SaveAbilityHandle;
        public static Boolean SaveAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility)
        {
            return InternalNatives._SaveAbilityHandle(table, parentKey, childKey, whichAbility);
        }
        
        //native SaveTimerHandle takes hashtable table, integer parentKey, integer childKey, timer whichTimer returns boolean
        public delegate JassBoolean SaveTimerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer);
        private static SaveTimerHandlePrototype _SaveTimerHandle;
        public static Boolean SaveTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer)
        {
            return InternalNatives._SaveTimerHandle(table, parentKey, childKey, whichTimer);
        }
        
        //native SaveTriggerHandle takes hashtable table, integer parentKey, integer childKey, trigger whichTrigger returns boolean
        public delegate JassBoolean SaveTriggerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger);
        private static SaveTriggerHandlePrototype _SaveTriggerHandle;
        public static Boolean SaveTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger)
        {
            return InternalNatives._SaveTriggerHandle(table, parentKey, childKey, whichTrigger);
        }
        
        //native SaveTriggerConditionHandle takes hashtable table, integer parentKey, integer childKey, triggercondition whichTriggercondition returns boolean
        public delegate JassBoolean SaveTriggerConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition);
        private static SaveTriggerConditionHandlePrototype _SaveTriggerConditionHandle;
        public static Boolean SaveTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition)
        {
            return InternalNatives._SaveTriggerConditionHandle(table, parentKey, childKey, whichTriggercondition);
        }
        
        //native SaveTriggerActionHandle takes hashtable table, integer parentKey, integer childKey, triggeraction whichTriggeraction returns boolean
        public delegate JassBoolean SaveTriggerActionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction);
        private static SaveTriggerActionHandlePrototype _SaveTriggerActionHandle;
        public static Boolean SaveTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction)
        {
            return InternalNatives._SaveTriggerActionHandle(table, parentKey, childKey, whichTriggeraction);
        }
        
        //native SaveTriggerEventHandle takes hashtable table, integer parentKey, integer childKey, event whichEvent returns boolean
        public delegate JassBoolean SaveTriggerEventHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent);
        private static SaveTriggerEventHandlePrototype _SaveTriggerEventHandle;
        public static Boolean SaveTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent)
        {
            return InternalNatives._SaveTriggerEventHandle(table, parentKey, childKey, whichEvent);
        }
        
        //native SaveForceHandle takes hashtable table, integer parentKey, integer childKey, force whichForce returns boolean
        public delegate JassBoolean SaveForceHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce);
        private static SaveForceHandlePrototype _SaveForceHandle;
        public static Boolean SaveForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce)
        {
            return InternalNatives._SaveForceHandle(table, parentKey, childKey, whichForce);
        }
        
        //native SaveGroupHandle takes hashtable table, integer parentKey, integer childKey, group whichGroup returns boolean
        public delegate JassBoolean SaveGroupHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup);
        private static SaveGroupHandlePrototype _SaveGroupHandle;
        public static Boolean SaveGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup)
        {
            return InternalNatives._SaveGroupHandle(table, parentKey, childKey, whichGroup);
        }
        
        //native SaveLocationHandle takes hashtable table, integer parentKey, integer childKey, location whichLocation returns boolean
        public delegate JassBoolean SaveLocationHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation);
        private static SaveLocationHandlePrototype _SaveLocationHandle;
        public static Boolean SaveLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation)
        {
            return InternalNatives._SaveLocationHandle(table, parentKey, childKey, whichLocation);
        }
        
        //native SaveRectHandle takes hashtable table, integer parentKey, integer childKey, rect whichRect returns boolean
        public delegate JassBoolean SaveRectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect);
        private static SaveRectHandlePrototype _SaveRectHandle;
        public static Boolean SaveRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect)
        {
            return InternalNatives._SaveRectHandle(table, parentKey, childKey, whichRect);
        }
        
        //native SaveBooleanExprHandle takes hashtable table, integer parentKey, integer childKey, boolexpr whichBoolexpr returns boolean
        public delegate JassBoolean SaveBooleanExprHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr);
        private static SaveBooleanExprHandlePrototype _SaveBooleanExprHandle;
        public static Boolean SaveBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr)
        {
            return InternalNatives._SaveBooleanExprHandle(table, parentKey, childKey, whichBoolexpr);
        }
        
        //native SaveSoundHandle takes hashtable table, integer parentKey, integer childKey, sound whichSound returns boolean
        public delegate JassBoolean SaveSoundHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound);
        private static SaveSoundHandlePrototype _SaveSoundHandle;
        public static Boolean SaveSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound)
        {
            return InternalNatives._SaveSoundHandle(table, parentKey, childKey, whichSound);
        }
        
        //native SaveEffectHandle takes hashtable table, integer parentKey, integer childKey, effect whichEffect returns boolean
        public delegate JassBoolean SaveEffectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect);
        private static SaveEffectHandlePrototype _SaveEffectHandle;
        public static Boolean SaveEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect)
        {
            return InternalNatives._SaveEffectHandle(table, parentKey, childKey, whichEffect);
        }
        
        //native SaveUnitPoolHandle takes hashtable table, integer parentKey, integer childKey, unitpool whichUnitpool returns boolean
        public delegate JassBoolean SaveUnitPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool);
        private static SaveUnitPoolHandlePrototype _SaveUnitPoolHandle;
        public static Boolean SaveUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool)
        {
            return InternalNatives._SaveUnitPoolHandle(table, parentKey, childKey, whichUnitpool);
        }
        
        //native SaveItemPoolHandle takes hashtable table, integer parentKey, integer childKey, itempool whichItempool returns boolean
        public delegate JassBoolean SaveItemPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool);
        private static SaveItemPoolHandlePrototype _SaveItemPoolHandle;
        public static Boolean SaveItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool)
        {
            return InternalNatives._SaveItemPoolHandle(table, parentKey, childKey, whichItempool);
        }
        
        //native SaveQuestHandle takes hashtable table, integer parentKey, integer childKey, quest whichQuest returns boolean
        public delegate JassBoolean SaveQuestHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest);
        private static SaveQuestHandlePrototype _SaveQuestHandle;
        public static Boolean SaveQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest)
        {
            return InternalNatives._SaveQuestHandle(table, parentKey, childKey, whichQuest);
        }
        
        //native SaveQuestItemHandle takes hashtable table, integer parentKey, integer childKey, questitem whichQuestitem returns boolean
        public delegate JassBoolean SaveQuestItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem);
        private static SaveQuestItemHandlePrototype _SaveQuestItemHandle;
        public static Boolean SaveQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem)
        {
            return InternalNatives._SaveQuestItemHandle(table, parentKey, childKey, whichQuestitem);
        }
        
        //native SaveDefeatConditionHandle takes hashtable table, integer parentKey, integer childKey, defeatcondition whichDefeatcondition returns boolean
        public delegate JassBoolean SaveDefeatConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition);
        private static SaveDefeatConditionHandlePrototype _SaveDefeatConditionHandle;
        public static Boolean SaveDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition)
        {
            return InternalNatives._SaveDefeatConditionHandle(table, parentKey, childKey, whichDefeatcondition);
        }
        
        //native SaveTimerDialogHandle takes hashtable table, integer parentKey, integer childKey, timerdialog whichTimerdialog returns boolean
        public delegate JassBoolean SaveTimerDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog);
        private static SaveTimerDialogHandlePrototype _SaveTimerDialogHandle;
        public static Boolean SaveTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog)
        {
            return InternalNatives._SaveTimerDialogHandle(table, parentKey, childKey, whichTimerdialog);
        }
        
        //native SaveLeaderboardHandle takes hashtable table, integer parentKey, integer childKey, leaderboard whichLeaderboard returns boolean
        public delegate JassBoolean SaveLeaderboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard);
        private static SaveLeaderboardHandlePrototype _SaveLeaderboardHandle;
        public static Boolean SaveLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard)
        {
            return InternalNatives._SaveLeaderboardHandle(table, parentKey, childKey, whichLeaderboard);
        }
        
        //native SaveMultiboardHandle takes hashtable table, integer parentKey, integer childKey, multiboard whichMultiboard returns boolean
        public delegate JassBoolean SaveMultiboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard);
        private static SaveMultiboardHandlePrototype _SaveMultiboardHandle;
        public static Boolean SaveMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard)
        {
            return InternalNatives._SaveMultiboardHandle(table, parentKey, childKey, whichMultiboard);
        }
        
        //native SaveMultiboardItemHandle takes hashtable table, integer parentKey, integer childKey, multiboarditem whichMultiboarditem returns boolean
        public delegate JassBoolean SaveMultiboardItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem);
        private static SaveMultiboardItemHandlePrototype _SaveMultiboardItemHandle;
        public static Boolean SaveMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem)
        {
            return InternalNatives._SaveMultiboardItemHandle(table, parentKey, childKey, whichMultiboarditem);
        }
        
        //native SaveTrackableHandle takes hashtable table, integer parentKey, integer childKey, trackable whichTrackable returns boolean
        public delegate JassBoolean SaveTrackableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable);
        private static SaveTrackableHandlePrototype _SaveTrackableHandle;
        public static Boolean SaveTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable)
        {
            return InternalNatives._SaveTrackableHandle(table, parentKey, childKey, whichTrackable);
        }
        
        //native SaveDialogHandle takes hashtable table, integer parentKey, integer childKey, dialog whichDialog returns boolean
        public delegate JassBoolean SaveDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog);
        private static SaveDialogHandlePrototype _SaveDialogHandle;
        public static Boolean SaveDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog)
        {
            return InternalNatives._SaveDialogHandle(table, parentKey, childKey, whichDialog);
        }
        
        //native SaveButtonHandle takes hashtable table, integer parentKey, integer childKey, button whichButton returns boolean
        public delegate JassBoolean SaveButtonHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton);
        private static SaveButtonHandlePrototype _SaveButtonHandle;
        public static Boolean SaveButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton)
        {
            return InternalNatives._SaveButtonHandle(table, parentKey, childKey, whichButton);
        }
        
        //native SaveTextTagHandle takes hashtable table, integer parentKey, integer childKey, texttag whichTexttag returns boolean
        public delegate JassBoolean SaveTextTagHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag);
        private static SaveTextTagHandlePrototype _SaveTextTagHandle;
        public static Boolean SaveTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag)
        {
            return InternalNatives._SaveTextTagHandle(table, parentKey, childKey, whichTexttag);
        }
        
        //native SaveLightningHandle takes hashtable table, integer parentKey, integer childKey, lightning whichLightning returns boolean
        public delegate JassBoolean SaveLightningHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning);
        private static SaveLightningHandlePrototype _SaveLightningHandle;
        public static Boolean SaveLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning)
        {
            return InternalNatives._SaveLightningHandle(table, parentKey, childKey, whichLightning);
        }
        
        //native SaveImageHandle takes hashtable table, integer parentKey, integer childKey, image whichImage returns boolean
        public delegate JassBoolean SaveImageHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage);
        private static SaveImageHandlePrototype _SaveImageHandle;
        public static Boolean SaveImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage)
        {
            return InternalNatives._SaveImageHandle(table, parentKey, childKey, whichImage);
        }
        
        //native SaveUbersplatHandle takes hashtable table, integer parentKey, integer childKey, ubersplat whichUbersplat returns boolean
        public delegate JassBoolean SaveUbersplatHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat);
        private static SaveUbersplatHandlePrototype _SaveUbersplatHandle;
        public static Boolean SaveUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat)
        {
            return InternalNatives._SaveUbersplatHandle(table, parentKey, childKey, whichUbersplat);
        }
        
        //native SaveRegionHandle takes hashtable table, integer parentKey, integer childKey, region whichRegion returns boolean
        public delegate JassBoolean SaveRegionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion);
        private static SaveRegionHandlePrototype _SaveRegionHandle;
        public static Boolean SaveRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion)
        {
            return InternalNatives._SaveRegionHandle(table, parentKey, childKey, whichRegion);
        }
        
        //native SaveFogStateHandle takes hashtable table, integer parentKey, integer childKey, fogstate whichFogState returns boolean
        public delegate JassBoolean SaveFogStateHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState);
        private static SaveFogStateHandlePrototype _SaveFogStateHandle;
        public static Boolean SaveFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState)
        {
            return InternalNatives._SaveFogStateHandle(table, parentKey, childKey, whichFogState);
        }
        
        //native SaveFogModifierHandle takes hashtable table, integer parentKey, integer childKey, fogmodifier whichFogModifier returns boolean
        public delegate JassBoolean SaveFogModifierHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier);
        private static SaveFogModifierHandlePrototype _SaveFogModifierHandle;
        public static Boolean SaveFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier)
        {
            return InternalNatives._SaveFogModifierHandle(table, parentKey, childKey, whichFogModifier);
        }
        
        //native SaveAgentHandle takes hashtable table, integer parentKey, integer childKey, agent whichAgent returns boolean
        public delegate JassBoolean SaveAgentHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent);
        private static SaveAgentHandlePrototype _SaveAgentHandle;
        public static Boolean SaveAgentHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent)
        {
            return InternalNatives._SaveAgentHandle(table, parentKey, childKey, whichAgent);
        }
        
        //native SaveHashtableHandle takes hashtable table, integer parentKey, integer childKey, hashtable whichHashtable returns boolean
        public delegate JassBoolean SaveHashtableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable);
        private static SaveHashtableHandlePrototype _SaveHashtableHandle;
        public static Boolean SaveHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable)
        {
            return InternalNatives._SaveHashtableHandle(table, parentKey, childKey, whichHashtable);
        }
        
        //native LoadInteger takes hashtable table, integer parentKey, integer childKey returns integer
        public delegate JassInteger LoadIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadIntegerPrototype _LoadInteger;
        public static JassInteger LoadInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadInteger(table, parentKey, childKey);
        }
        
        //native LoadReal takes hashtable table, integer parentKey, integer childKey returns real
        public delegate JassRealRet LoadRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadRealPrototype _LoadReal;
        public static Single LoadReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadReal(table, parentKey, childKey);
        }
        
        //native LoadBoolean takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean LoadBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadBooleanPrototype _LoadBoolean;
        public static Boolean LoadBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadBoolean(table, parentKey, childKey);
        }
        
        //native LoadStr takes hashtable table, integer parentKey, integer childKey returns string
        public delegate String LoadStrPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadStrPrototype _LoadStr;
        public static String LoadStr(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadStr(table, parentKey, childKey);
        }
        
        //native LoadPlayerHandle takes hashtable table, integer parentKey, integer childKey returns player
        public delegate JassPlayer LoadPlayerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadPlayerHandlePrototype _LoadPlayerHandle;
        public static JassPlayer LoadPlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadPlayerHandle(table, parentKey, childKey);
        }
        
        //native LoadWidgetHandle takes hashtable table, integer parentKey, integer childKey returns widget
        public delegate JassWidget LoadWidgetHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadWidgetHandlePrototype _LoadWidgetHandle;
        public static JassWidget LoadWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadWidgetHandle(table, parentKey, childKey);
        }
        
        //native LoadDestructableHandle takes hashtable table, integer parentKey, integer childKey returns destructable
        public delegate JassDestructable LoadDestructableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadDestructableHandlePrototype _LoadDestructableHandle;
        public static JassDestructable LoadDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadDestructableHandle(table, parentKey, childKey);
        }
        
        //native LoadItemHandle takes hashtable table, integer parentKey, integer childKey returns item
        public delegate JassItem LoadItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadItemHandlePrototype _LoadItemHandle;
        public static JassItem LoadItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadItemHandle(table, parentKey, childKey);
        }
        
        //native LoadUnitHandle takes hashtable table, integer parentKey, integer childKey returns unit
        public delegate JassUnit LoadUnitHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadUnitHandlePrototype _LoadUnitHandle;
        public static JassUnit LoadUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadUnitHandle(table, parentKey, childKey);
        }
        
        //native LoadAbilityHandle takes hashtable table, integer parentKey, integer childKey returns ability
        public delegate JassAbility LoadAbilityHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadAbilityHandlePrototype _LoadAbilityHandle;
        public static JassAbility LoadAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadAbilityHandle(table, parentKey, childKey);
        }
        
        //native LoadTimerHandle takes hashtable table, integer parentKey, integer childKey returns timer
        public delegate JassTimer LoadTimerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTimerHandlePrototype _LoadTimerHandle;
        public static JassTimer LoadTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadTimerHandle(table, parentKey, childKey);
        }
        
        //native LoadTriggerHandle takes hashtable table, integer parentKey, integer childKey returns trigger
        public delegate JassTrigger LoadTriggerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTriggerHandlePrototype _LoadTriggerHandle;
        public static JassTrigger LoadTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadTriggerHandle(table, parentKey, childKey);
        }
        
        //native LoadTriggerConditionHandle takes hashtable table, integer parentKey, integer childKey returns triggercondition
        public delegate JassTriggerCondition LoadTriggerConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTriggerConditionHandlePrototype _LoadTriggerConditionHandle;
        public static JassTriggerCondition LoadTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadTriggerConditionHandle(table, parentKey, childKey);
        }
        
        //native LoadTriggerActionHandle takes hashtable table, integer parentKey, integer childKey returns triggeraction
        public delegate JassTriggerAction LoadTriggerActionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTriggerActionHandlePrototype _LoadTriggerActionHandle;
        public static JassTriggerAction LoadTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadTriggerActionHandle(table, parentKey, childKey);
        }
        
        //native LoadTriggerEventHandle takes hashtable table, integer parentKey, integer childKey returns event
        public delegate JassEvent LoadTriggerEventHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTriggerEventHandlePrototype _LoadTriggerEventHandle;
        public static JassEvent LoadTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadTriggerEventHandle(table, parentKey, childKey);
        }
        
        //native LoadForceHandle takes hashtable table, integer parentKey, integer childKey returns force
        public delegate JassForce LoadForceHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadForceHandlePrototype _LoadForceHandle;
        public static JassForce LoadForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadForceHandle(table, parentKey, childKey);
        }
        
        //native LoadGroupHandle takes hashtable table, integer parentKey, integer childKey returns group
        public delegate JassGroup LoadGroupHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadGroupHandlePrototype _LoadGroupHandle;
        public static JassGroup LoadGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadGroupHandle(table, parentKey, childKey);
        }
        
        //native LoadLocationHandle takes hashtable table, integer parentKey, integer childKey returns location
        public delegate JassLocation LoadLocationHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadLocationHandlePrototype _LoadLocationHandle;
        public static JassLocation LoadLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadLocationHandle(table, parentKey, childKey);
        }
        
        //native LoadRectHandle takes hashtable table, integer parentKey, integer childKey returns rect
        public delegate JassRect LoadRectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadRectHandlePrototype _LoadRectHandle;
        public static JassRect LoadRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadRectHandle(table, parentKey, childKey);
        }
        
        //native LoadBooleanExprHandle takes hashtable table, integer parentKey, integer childKey returns boolexpr
        public delegate JassBooleanExpression LoadBooleanExprHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadBooleanExprHandlePrototype _LoadBooleanExprHandle;
        public static JassBooleanExpression LoadBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadBooleanExprHandle(table, parentKey, childKey);
        }
        
        //native LoadSoundHandle takes hashtable table, integer parentKey, integer childKey returns sound
        public delegate JassSound LoadSoundHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadSoundHandlePrototype _LoadSoundHandle;
        public static JassSound LoadSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadSoundHandle(table, parentKey, childKey);
        }
        
        //native LoadEffectHandle takes hashtable table, integer parentKey, integer childKey returns effect
        public delegate JassEffect LoadEffectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadEffectHandlePrototype _LoadEffectHandle;
        public static JassEffect LoadEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadEffectHandle(table, parentKey, childKey);
        }
        
        //native LoadUnitPoolHandle takes hashtable table, integer parentKey, integer childKey returns unitpool
        public delegate JassUnitPool LoadUnitPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadUnitPoolHandlePrototype _LoadUnitPoolHandle;
        public static JassUnitPool LoadUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadUnitPoolHandle(table, parentKey, childKey);
        }
        
        //native LoadItemPoolHandle takes hashtable table, integer parentKey, integer childKey returns itempool
        public delegate JassItemPool LoadItemPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadItemPoolHandlePrototype _LoadItemPoolHandle;
        public static JassItemPool LoadItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadItemPoolHandle(table, parentKey, childKey);
        }
        
        //native LoadQuestHandle takes hashtable table, integer parentKey, integer childKey returns quest
        public delegate JassQuest LoadQuestHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadQuestHandlePrototype _LoadQuestHandle;
        public static JassQuest LoadQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadQuestHandle(table, parentKey, childKey);
        }
        
        //native LoadQuestItemHandle takes hashtable table, integer parentKey, integer childKey returns questitem
        public delegate JassQuestItem LoadQuestItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadQuestItemHandlePrototype _LoadQuestItemHandle;
        public static JassQuestItem LoadQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadQuestItemHandle(table, parentKey, childKey);
        }
        
        //native LoadDefeatConditionHandle takes hashtable table, integer parentKey, integer childKey returns defeatcondition
        public delegate JassDefeatCondition LoadDefeatConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadDefeatConditionHandlePrototype _LoadDefeatConditionHandle;
        public static JassDefeatCondition LoadDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadDefeatConditionHandle(table, parentKey, childKey);
        }
        
        //native LoadTimerDialogHandle takes hashtable table, integer parentKey, integer childKey returns timerdialog
        public delegate JassTimerDialog LoadTimerDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTimerDialogHandlePrototype _LoadTimerDialogHandle;
        public static JassTimerDialog LoadTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadTimerDialogHandle(table, parentKey, childKey);
        }
        
        //native LoadLeaderboardHandle takes hashtable table, integer parentKey, integer childKey returns leaderboard
        public delegate JassLeaderboard LoadLeaderboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadLeaderboardHandlePrototype _LoadLeaderboardHandle;
        public static JassLeaderboard LoadLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadLeaderboardHandle(table, parentKey, childKey);
        }
        
        //native LoadMultiboardHandle takes hashtable table, integer parentKey, integer childKey returns multiboard
        public delegate JassMultiboard LoadMultiboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadMultiboardHandlePrototype _LoadMultiboardHandle;
        public static JassMultiboard LoadMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadMultiboardHandle(table, parentKey, childKey);
        }
        
        //native LoadMultiboardItemHandle takes hashtable table, integer parentKey, integer childKey returns multiboarditem
        public delegate JassMultiboardItem LoadMultiboardItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadMultiboardItemHandlePrototype _LoadMultiboardItemHandle;
        public static JassMultiboardItem LoadMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadMultiboardItemHandle(table, parentKey, childKey);
        }
        
        //native LoadTrackableHandle takes hashtable table, integer parentKey, integer childKey returns trackable
        public delegate JassTrackable LoadTrackableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTrackableHandlePrototype _LoadTrackableHandle;
        public static JassTrackable LoadTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadTrackableHandle(table, parentKey, childKey);
        }
        
        //native LoadDialogHandle takes hashtable table, integer parentKey, integer childKey returns dialog
        public delegate JassDialog LoadDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadDialogHandlePrototype _LoadDialogHandle;
        public static JassDialog LoadDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadDialogHandle(table, parentKey, childKey);
        }
        
        //native LoadButtonHandle takes hashtable table, integer parentKey, integer childKey returns button
        public delegate JassButton LoadButtonHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadButtonHandlePrototype _LoadButtonHandle;
        public static JassButton LoadButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadButtonHandle(table, parentKey, childKey);
        }
        
        //native LoadTextTagHandle takes hashtable table, integer parentKey, integer childKey returns texttag
        public delegate JassTextTag LoadTextTagHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTextTagHandlePrototype _LoadTextTagHandle;
        public static JassTextTag LoadTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadTextTagHandle(table, parentKey, childKey);
        }
        
        //native LoadLightningHandle takes hashtable table, integer parentKey, integer childKey returns lightning
        public delegate JassLightning LoadLightningHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadLightningHandlePrototype _LoadLightningHandle;
        public static JassLightning LoadLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadLightningHandle(table, parentKey, childKey);
        }
        
        //native LoadImageHandle takes hashtable table, integer parentKey, integer childKey returns image
        public delegate JassImage LoadImageHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadImageHandlePrototype _LoadImageHandle;
        public static JassImage LoadImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadImageHandle(table, parentKey, childKey);
        }
        
        //native LoadUbersplatHandle takes hashtable table, integer parentKey, integer childKey returns ubersplat
        public delegate JassUberSplat LoadUbersplatHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadUbersplatHandlePrototype _LoadUbersplatHandle;
        public static JassUberSplat LoadUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadUbersplatHandle(table, parentKey, childKey);
        }
        
        //native LoadRegionHandle takes hashtable table, integer parentKey, integer childKey returns region
        public delegate JassRegion LoadRegionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadRegionHandlePrototype _LoadRegionHandle;
        public static JassRegion LoadRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadRegionHandle(table, parentKey, childKey);
        }
        
        //native LoadFogStateHandle takes hashtable table, integer parentKey, integer childKey returns fogstate
        public delegate JassFogState LoadFogStateHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadFogStateHandlePrototype _LoadFogStateHandle;
        public static JassFogState LoadFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadFogStateHandle(table, parentKey, childKey);
        }
        
        //native LoadFogModifierHandle takes hashtable table, integer parentKey, integer childKey returns fogmodifier
        public delegate JassFogModifier LoadFogModifierHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadFogModifierHandlePrototype _LoadFogModifierHandle;
        public static JassFogModifier LoadFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadFogModifierHandle(table, parentKey, childKey);
        }
        
        //native LoadHashtableHandle takes hashtable table, integer parentKey, integer childKey returns hashtable
        public delegate JassHashTable LoadHashtableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadHashtableHandlePrototype _LoadHashtableHandle;
        public static JassHashTable LoadHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._LoadHashtableHandle(table, parentKey, childKey);
        }
        
        //native HaveSavedInteger takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedIntegerPrototype _HaveSavedInteger;
        public static Boolean HaveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._HaveSavedInteger(table, parentKey, childKey);
        }
        
        //native HaveSavedReal takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedRealPrototype _HaveSavedReal;
        public static Boolean HaveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._HaveSavedReal(table, parentKey, childKey);
        }
        
        //native HaveSavedBoolean takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedBooleanPrototype _HaveSavedBoolean;
        public static Boolean HaveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._HaveSavedBoolean(table, parentKey, childKey);
        }
        
        //native HaveSavedString takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedStringPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedStringPrototype _HaveSavedString;
        public static Boolean HaveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._HaveSavedString(table, parentKey, childKey);
        }
        
        //native HaveSavedHandle takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedHandlePrototype _HaveSavedHandle;
        public static Boolean HaveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives._HaveSavedHandle(table, parentKey, childKey);
        }
        
        //native RemoveSavedInteger takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedIntegerPrototype _RemoveSavedInteger;
        public static void RemoveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives._RemoveSavedInteger(table, parentKey, childKey);
        }
        
        //native RemoveSavedReal takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedRealPrototype _RemoveSavedReal;
        public static void RemoveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives._RemoveSavedReal(table, parentKey, childKey);
        }
        
        //native RemoveSavedBoolean takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedBooleanPrototype _RemoveSavedBoolean;
        public static void RemoveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives._RemoveSavedBoolean(table, parentKey, childKey);
        }
        
        //native RemoveSavedString takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedStringPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedStringPrototype _RemoveSavedString;
        public static void RemoveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives._RemoveSavedString(table, parentKey, childKey);
        }
        
        //native RemoveSavedHandle takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedHandlePrototype _RemoveSavedHandle;
        public static void RemoveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives._RemoveSavedHandle(table, parentKey, childKey);
        }
        
        //native FlushParentHashtable takes hashtable table returns nothing
        public delegate void FlushParentHashtablePrototype(JassHashTable table);
        private static FlushParentHashtablePrototype _FlushParentHashtable;
        public static void FlushParentHashtable(JassHashTable table)
        {
            InternalNatives._FlushParentHashtable(table);
        }
        
        //native FlushChildHashtable takes hashtable table, integer parentKey returns nothing
        public delegate void FlushChildHashtablePrototype(JassHashTable table, JassInteger parentKey);
        private static FlushChildHashtablePrototype _FlushChildHashtable;
        public static void FlushChildHashtable(JassHashTable table, JassInteger parentKey)
        {
            InternalNatives._FlushChildHashtable(table, parentKey);
        }
        
        //native GetRandomInt takes integer lowBound, integer highBound returns integer
        public delegate JassInteger GetRandomIntPrototype(JassInteger lowBound, JassInteger highBound);
        private static GetRandomIntPrototype _GetRandomInt;
        public static JassInteger GetRandomInt(JassInteger lowBound, JassInteger highBound)
        {
            return InternalNatives._GetRandomInt(lowBound, highBound);
        }
        
        //native GetRandomReal takes real lowBound, real highBound returns real
        public delegate JassRealRet GetRandomRealPrototype(JassRealArg lowBound, JassRealArg highBound);
        private static GetRandomRealPrototype _GetRandomReal;
        public static Single GetRandomReal(Single lowBound, Single highBound)
        {
            return InternalNatives._GetRandomReal(lowBound, highBound);
        }
        
        //native CreateUnitPool takes nothing returns unitpool
        public delegate JassUnitPool CreateUnitPoolPrototype();
        private static CreateUnitPoolPrototype _CreateUnitPool;
        public static JassUnitPool CreateUnitPool()
        {
            return InternalNatives._CreateUnitPool();
        }
        
        //native DestroyUnitPool takes unitpool whichPool returns nothing
        public delegate void DestroyUnitPoolPrototype(JassUnitPool whichPool);
        private static DestroyUnitPoolPrototype _DestroyUnitPool;
        public static void DestroyUnitPool(JassUnitPool whichPool)
        {
            InternalNatives._DestroyUnitPool(whichPool);
        }
        
        //native UnitPoolAddUnitType takes unitpool whichPool, integer unitId, real weight returns nothing
        public delegate void UnitPoolAddUnitTypePrototype(JassUnitPool whichPool, JassObjectId unitId, JassRealArg weight);
        private static UnitPoolAddUnitTypePrototype _UnitPoolAddUnitType;
        public static void UnitPoolAddUnitType(JassUnitPool whichPool, JassObjectId unitId, Single weight)
        {
            InternalNatives._UnitPoolAddUnitType(whichPool, unitId, weight);
        }
        
        //native UnitPoolRemoveUnitType takes unitpool whichPool, integer unitId returns nothing
        public delegate void UnitPoolRemoveUnitTypePrototype(JassUnitPool whichPool, JassObjectId unitId);
        private static UnitPoolRemoveUnitTypePrototype _UnitPoolRemoveUnitType;
        public static void UnitPoolRemoveUnitType(JassUnitPool whichPool, JassObjectId unitId)
        {
            InternalNatives._UnitPoolRemoveUnitType(whichPool, unitId);
        }
        
        //native PlaceRandomUnit takes unitpool whichPool, player forWhichPlayer, real x, real y, real facing returns unit
        public delegate JassUnit PlaceRandomUnitPrototype(JassUnitPool whichPool, JassPlayer forWhichPlayer, JassRealArg x, JassRealArg y, JassRealArg facing);
        private static PlaceRandomUnitPrototype _PlaceRandomUnit;
        public static JassUnit PlaceRandomUnit(JassUnitPool whichPool, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return InternalNatives._PlaceRandomUnit(whichPool, forWhichPlayer, x, y, facing);
        }
        
        //native CreateItemPool takes nothing returns itempool
        public delegate JassItemPool CreateItemPoolPrototype();
        private static CreateItemPoolPrototype _CreateItemPool;
        public static JassItemPool CreateItemPool()
        {
            return InternalNatives._CreateItemPool();
        }
        
        //native DestroyItemPool takes itempool whichItemPool returns nothing
        public delegate void DestroyItemPoolPrototype(JassItemPool whichItemPool);
        private static DestroyItemPoolPrototype _DestroyItemPool;
        public static void DestroyItemPool(JassItemPool whichItemPool)
        {
            InternalNatives._DestroyItemPool(whichItemPool);
        }
        
        //native ItemPoolAddItemType takes itempool whichItemPool, integer itemId, real weight returns nothing
        public delegate void ItemPoolAddItemTypePrototype(JassItemPool whichItemPool, JassObjectId itemId, JassRealArg weight);
        private static ItemPoolAddItemTypePrototype _ItemPoolAddItemType;
        public static void ItemPoolAddItemType(JassItemPool whichItemPool, JassObjectId itemId, Single weight)
        {
            InternalNatives._ItemPoolAddItemType(whichItemPool, itemId, weight);
        }
        
        //native ItemPoolRemoveItemType takes itempool whichItemPool, integer itemId returns nothing
        public delegate void ItemPoolRemoveItemTypePrototype(JassItemPool whichItemPool, JassObjectId itemId);
        private static ItemPoolRemoveItemTypePrototype _ItemPoolRemoveItemType;
        public static void ItemPoolRemoveItemType(JassItemPool whichItemPool, JassObjectId itemId)
        {
            InternalNatives._ItemPoolRemoveItemType(whichItemPool, itemId);
        }
        
        //native PlaceRandomItem takes itempool whichItemPool, real x, real y returns item
        public delegate JassItem PlaceRandomItemPrototype(JassItemPool whichItemPool, JassRealArg x, JassRealArg y);
        private static PlaceRandomItemPrototype _PlaceRandomItem;
        public static JassItem PlaceRandomItem(JassItemPool whichItemPool, Single x, Single y)
        {
            return InternalNatives._PlaceRandomItem(whichItemPool, x, y);
        }
        
        //native ChooseRandomCreep takes integer level returns integer
        public delegate JassInteger ChooseRandomCreepPrototype(JassInteger level);
        private static ChooseRandomCreepPrototype _ChooseRandomCreep;
        public static JassInteger ChooseRandomCreep(JassInteger level)
        {
            return InternalNatives._ChooseRandomCreep(level);
        }
        
        //native ChooseRandomNPBuilding takes nothing returns integer
        public delegate JassInteger ChooseRandomNPBuildingPrototype();
        private static ChooseRandomNPBuildingPrototype _ChooseRandomNPBuilding;
        public static JassInteger ChooseRandomNPBuilding()
        {
            return InternalNatives._ChooseRandomNPBuilding();
        }
        
        //native ChooseRandomItem takes integer level returns integer
        public delegate JassInteger ChooseRandomItemPrototype(JassInteger level);
        private static ChooseRandomItemPrototype _ChooseRandomItem;
        public static JassInteger ChooseRandomItem(JassInteger level)
        {
            return InternalNatives._ChooseRandomItem(level);
        }
        
        //native ChooseRandomItemEx takes itemtype whichType, integer level returns integer
        public delegate JassInteger ChooseRandomItemExPrototype(JassItemType whichType, JassInteger level);
        private static ChooseRandomItemExPrototype _ChooseRandomItemEx;
        public static JassInteger ChooseRandomItemEx(JassItemType whichType, JassInteger level)
        {
            return InternalNatives._ChooseRandomItemEx(whichType, level);
        }
        
        //native SetRandomSeed takes integer seed returns nothing
        public delegate void SetRandomSeedPrototype(JassInteger seed);
        private static SetRandomSeedPrototype _SetRandomSeed;
        public static void SetRandomSeed(JassInteger seed)
        {
            InternalNatives._SetRandomSeed(seed);
        }
        
        //native SetTerrainFog takes real a, real b, real c, real d, real e returns nothing
        public delegate void SetTerrainFogPrototype(JassRealArg a, JassRealArg b, JassRealArg c, JassRealArg d, JassRealArg e);
        private static SetTerrainFogPrototype _SetTerrainFog;
        public static void SetTerrainFog(Single a, Single b, Single c, Single d, Single e)
        {
            InternalNatives._SetTerrainFog(a, b, c, d, e);
        }
        
        //native ResetTerrainFog takes nothing returns nothing
        public delegate void ResetTerrainFogPrototype();
        private static ResetTerrainFogPrototype _ResetTerrainFog;
        public static void ResetTerrainFog()
        {
            InternalNatives._ResetTerrainFog();
        }
        
        //native SetUnitFog takes real a, real b, real c, real d, real e returns nothing
        public delegate void SetUnitFogPrototype(JassRealArg a, JassRealArg b, JassRealArg c, JassRealArg d, JassRealArg e);
        private static SetUnitFogPrototype _SetUnitFog;
        public static void SetUnitFog(Single a, Single b, Single c, Single d, Single e)
        {
            InternalNatives._SetUnitFog(a, b, c, d, e);
        }
        
        //native SetTerrainFogEx takes integer style, real zstart, real zend, real density, real red, real green, real blue returns nothing
        public delegate void SetTerrainFogExPrototype(JassInteger style, JassRealArg zstart, JassRealArg zend, JassRealArg density, JassRealArg red, JassRealArg green, JassRealArg blue);
        private static SetTerrainFogExPrototype _SetTerrainFogEx;
        public static void SetTerrainFogEx(JassInteger style, Single zstart, Single zend, Single density, Single red, Single green, Single blue)
        {
            InternalNatives._SetTerrainFogEx(style, zstart, zend, density, red, green, blue);
        }
        
        //native DisplayTextToPlayer takes player toPlayer, real x, real y, string message returns nothing
        public delegate void DisplayTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, String message);
        private static DisplayTextToPlayerPrototype _DisplayTextToPlayer;
        public static void DisplayTextToPlayer(JassPlayer toPlayer, Single x, Single y, String message)
        {
            InternalNatives._DisplayTextToPlayer(toPlayer, x, y, message);
        }
        
        //native DisplayTimedTextToPlayer takes player toPlayer, real x, real y, real duration, string message returns nothing
        public delegate void DisplayTimedTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassRealArg duration, String message);
        private static DisplayTimedTextToPlayerPrototype _DisplayTimedTextToPlayer;
        public static void DisplayTimedTextToPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            InternalNatives._DisplayTimedTextToPlayer(toPlayer, x, y, duration, message);
        }
        
        //native DisplayTimedTextFromPlayer takes player toPlayer, real x, real y, real duration, string message returns nothing
        public delegate void DisplayTimedTextFromPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassRealArg duration, String message);
        private static DisplayTimedTextFromPlayerPrototype _DisplayTimedTextFromPlayer;
        public static void DisplayTimedTextFromPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            InternalNatives._DisplayTimedTextFromPlayer(toPlayer, x, y, duration, message);
        }
        
        //native ClearTextMessages takes nothing returns nothing
        public delegate void ClearTextMessagesPrototype();
        private static ClearTextMessagesPrototype _ClearTextMessages;
        public static void ClearTextMessages()
        {
            InternalNatives._ClearTextMessages();
        }
        
        //native SetDayNightModels takes string terrainDNCFile, string unitDNCFile returns nothing
        public delegate void SetDayNightModelsPrototype(String terrainDNCFile, String unitDNCFile);
        private static SetDayNightModelsPrototype _SetDayNightModels;
        public static void SetDayNightModels(String terrainDNCFile, String unitDNCFile)
        {
            InternalNatives._SetDayNightModels(terrainDNCFile, unitDNCFile);
        }
        
        //native SetSkyModel takes string skyModelFile returns nothing
        public delegate void SetSkyModelPrototype(String skyModelFile);
        private static SetSkyModelPrototype _SetSkyModel;
        public static void SetSkyModel(String skyModelFile)
        {
            InternalNatives._SetSkyModel(skyModelFile);
        }
        
        //native EnableUserControl takes boolean b returns nothing
        public delegate void EnableUserControlPrototype(JassBoolean b);
        private static EnableUserControlPrototype _EnableUserControl;
        public static void EnableUserControl(Boolean b)
        {
            InternalNatives._EnableUserControl(b);
        }
        
        //native EnableUserUI takes boolean b returns nothing
        public delegate void EnableUserUIPrototype(JassBoolean b);
        private static EnableUserUIPrototype _EnableUserUI;
        public static void EnableUserUI(Boolean b)
        {
            InternalNatives._EnableUserUI(b);
        }
        
        //native SuspendTimeOfDay takes boolean b returns nothing
        public delegate void SuspendTimeOfDayPrototype(JassBoolean b);
        private static SuspendTimeOfDayPrototype _SuspendTimeOfDay;
        public static void SuspendTimeOfDay(Boolean b)
        {
            InternalNatives._SuspendTimeOfDay(b);
        }
        
        //native SetTimeOfDayScale takes real r returns nothing
        public delegate void SetTimeOfDayScalePrototype(JassRealArg r);
        private static SetTimeOfDayScalePrototype _SetTimeOfDayScale;
        public static void SetTimeOfDayScale(Single r)
        {
            InternalNatives._SetTimeOfDayScale(r);
        }
        
        //native GetTimeOfDayScale takes nothing returns real
        public delegate JassRealRet GetTimeOfDayScalePrototype();
        private static GetTimeOfDayScalePrototype _GetTimeOfDayScale;
        public static Single GetTimeOfDayScale()
        {
            return InternalNatives._GetTimeOfDayScale();
        }
        
        //native ShowInterface takes boolean flag, real fadeDuration returns nothing
        public delegate void ShowInterfacePrototype(JassBoolean flag, JassRealArg fadeDuration);
        private static ShowInterfacePrototype _ShowInterface;
        public static void ShowInterface(Boolean flag, Single fadeDuration)
        {
            InternalNatives._ShowInterface(flag, fadeDuration);
        }
        
        //native PauseGame takes boolean flag returns nothing
        public delegate void PauseGamePrototype(JassBoolean flag);
        private static PauseGamePrototype _PauseGame;
        public static void PauseGame(Boolean flag)
        {
            InternalNatives._PauseGame(flag);
        }
        
        //native UnitAddIndicator takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void UnitAddIndicatorPrototype(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static UnitAddIndicatorPrototype _UnitAddIndicator;
        public static void UnitAddIndicator(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._UnitAddIndicator(whichUnit, red, green, blue, alpha);
        }
        
        //native AddIndicator takes widget whichWidget, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void AddIndicatorPrototype(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static AddIndicatorPrototype _AddIndicator;
        public static void AddIndicator(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._AddIndicator(whichWidget, red, green, blue, alpha);
        }
        
        //native PingMinimap takes real x, real y, real duration returns nothing
        public delegate void PingMinimapPrototype(JassRealArg x, JassRealArg y, JassRealArg duration);
        private static PingMinimapPrototype _PingMinimap;
        public static void PingMinimap(Single x, Single y, Single duration)
        {
            InternalNatives._PingMinimap(x, y, duration);
        }
        
        //native PingMinimapEx takes real x, real y, real duration, integer red, integer green, integer blue, boolean extraEffects returns nothing
        public delegate void PingMinimapExPrototype(JassRealArg x, JassRealArg y, JassRealArg duration, JassInteger red, JassInteger green, JassInteger blue, JassBoolean extraEffects);
        private static PingMinimapExPrototype _PingMinimapEx;
        public static void PingMinimapEx(Single x, Single y, Single duration, JassInteger red, JassInteger green, JassInteger blue, Boolean extraEffects)
        {
            InternalNatives._PingMinimapEx(x, y, duration, red, green, blue, extraEffects);
        }
        
        //native EnableOcclusion takes boolean flag returns nothing
        public delegate void EnableOcclusionPrototype(JassBoolean flag);
        private static EnableOcclusionPrototype _EnableOcclusion;
        public static void EnableOcclusion(Boolean flag)
        {
            InternalNatives._EnableOcclusion(flag);
        }
        
        //native SetIntroShotText takes string introText returns nothing
        public delegate void SetIntroShotTextPrototype(String introText);
        private static SetIntroShotTextPrototype _SetIntroShotText;
        public static void SetIntroShotText(String introText)
        {
            InternalNatives._SetIntroShotText(introText);
        }
        
        //native SetIntroShotModel takes string introModelPath returns nothing
        public delegate void SetIntroShotModelPrototype(String introModelPath);
        private static SetIntroShotModelPrototype _SetIntroShotModel;
        public static void SetIntroShotModel(String introModelPath)
        {
            InternalNatives._SetIntroShotModel(introModelPath);
        }
        
        //native EnableWorldFogBoundary takes boolean b returns nothing
        public delegate void EnableWorldFogBoundaryPrototype(JassBoolean b);
        private static EnableWorldFogBoundaryPrototype _EnableWorldFogBoundary;
        public static void EnableWorldFogBoundary(Boolean b)
        {
            InternalNatives._EnableWorldFogBoundary(b);
        }
        
        //native PlayModelCinematic takes string modelName returns nothing
        public delegate void PlayModelCinematicPrototype(String modelName);
        private static PlayModelCinematicPrototype _PlayModelCinematic;
        public static void PlayModelCinematic(String modelName)
        {
            InternalNatives._PlayModelCinematic(modelName);
        }
        
        //native PlayCinematic takes string movieName returns nothing
        public delegate void PlayCinematicPrototype(String movieName);
        private static PlayCinematicPrototype _PlayCinematic;
        public static void PlayCinematic(String movieName)
        {
            InternalNatives._PlayCinematic(movieName);
        }
        
        //native ForceUIKey takes string key returns nothing
        public delegate void ForceUIKeyPrototype(String key);
        private static ForceUIKeyPrototype _ForceUIKey;
        public static void ForceUIKey(String key)
        {
            InternalNatives._ForceUIKey(key);
        }
        
        //native ForceUICancel takes nothing returns nothing
        public delegate void ForceUICancelPrototype();
        private static ForceUICancelPrototype _ForceUICancel;
        public static void ForceUICancel()
        {
            InternalNatives._ForceUICancel();
        }
        
        //native DisplayLoadDialog takes nothing returns nothing
        public delegate void DisplayLoadDialogPrototype();
        private static DisplayLoadDialogPrototype _DisplayLoadDialog;
        public static void DisplayLoadDialog()
        {
            InternalNatives._DisplayLoadDialog();
        }
        
        //native SetAltMinimapIcon takes string iconPath returns nothing
        public delegate void SetAltMinimapIconPrototype(String iconPath);
        private static SetAltMinimapIconPrototype _SetAltMinimapIcon;
        public static void SetAltMinimapIcon(String iconPath)
        {
            InternalNatives._SetAltMinimapIcon(iconPath);
        }
        
        //native DisableRestartMission takes boolean flag returns nothing
        public delegate void DisableRestartMissionPrototype(JassBoolean flag);
        private static DisableRestartMissionPrototype _DisableRestartMission;
        public static void DisableRestartMission(Boolean flag)
        {
            InternalNatives._DisableRestartMission(flag);
        }
        
        //native CreateTextTag takes nothing returns texttag
        public delegate JassTextTag CreateTextTagPrototype();
        private static CreateTextTagPrototype _CreateTextTag;
        public static JassTextTag CreateTextTag()
        {
            return InternalNatives._CreateTextTag();
        }
        
        //native DestroyTextTag takes texttag t returns nothing
        public delegate void DestroyTextTagPrototype(JassTextTag t);
        private static DestroyTextTagPrototype _DestroyTextTag;
        public static void DestroyTextTag(JassTextTag t)
        {
            InternalNatives._DestroyTextTag(t);
        }
        
        //native SetTextTagText takes texttag t, string s, real height returns nothing
        public delegate void SetTextTagTextPrototype(JassTextTag t, String s, JassRealArg height);
        private static SetTextTagTextPrototype _SetTextTagText;
        public static void SetTextTagText(JassTextTag t, String s, Single height)
        {
            InternalNatives._SetTextTagText(t, s, height);
        }
        
        //native SetTextTagPos takes texttag t, real x, real y, real heightOffset returns nothing
        public delegate void SetTextTagPosPrototype(JassTextTag t, JassRealArg x, JassRealArg y, JassRealArg heightOffset);
        private static SetTextTagPosPrototype _SetTextTagPos;
        public static void SetTextTagPos(JassTextTag t, Single x, Single y, Single heightOffset)
        {
            InternalNatives._SetTextTagPos(t, x, y, heightOffset);
        }
        
        //native SetTextTagPosUnit takes texttag t, unit whichUnit, real heightOffset returns nothing
        public delegate void SetTextTagPosUnitPrototype(JassTextTag t, JassUnit whichUnit, JassRealArg heightOffset);
        private static SetTextTagPosUnitPrototype _SetTextTagPosUnit;
        public static void SetTextTagPosUnit(JassTextTag t, JassUnit whichUnit, Single heightOffset)
        {
            InternalNatives._SetTextTagPosUnit(t, whichUnit, heightOffset);
        }
        
        //native SetTextTagColor takes texttag t, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetTextTagColorPrototype(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetTextTagColorPrototype _SetTextTagColor;
        public static void SetTextTagColor(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._SetTextTagColor(t, red, green, blue, alpha);
        }
        
        //native SetTextTagVelocity takes texttag t, real xvel, real yvel returns nothing
        public delegate void SetTextTagVelocityPrototype(JassTextTag t, JassRealArg xvel, JassRealArg yvel);
        private static SetTextTagVelocityPrototype _SetTextTagVelocity;
        public static void SetTextTagVelocity(JassTextTag t, Single xvel, Single yvel)
        {
            InternalNatives._SetTextTagVelocity(t, xvel, yvel);
        }
        
        //native SetTextTagVisibility takes texttag t, boolean flag returns nothing
        public delegate void SetTextTagVisibilityPrototype(JassTextTag t, JassBoolean flag);
        private static SetTextTagVisibilityPrototype _SetTextTagVisibility;
        public static void SetTextTagVisibility(JassTextTag t, Boolean flag)
        {
            InternalNatives._SetTextTagVisibility(t, flag);
        }
        
        //native SetTextTagSuspended takes texttag t, boolean flag returns nothing
        public delegate void SetTextTagSuspendedPrototype(JassTextTag t, JassBoolean flag);
        private static SetTextTagSuspendedPrototype _SetTextTagSuspended;
        public static void SetTextTagSuspended(JassTextTag t, Boolean flag)
        {
            InternalNatives._SetTextTagSuspended(t, flag);
        }
        
        //native SetTextTagPermanent takes texttag t, boolean flag returns nothing
        public delegate void SetTextTagPermanentPrototype(JassTextTag t, JassBoolean flag);
        private static SetTextTagPermanentPrototype _SetTextTagPermanent;
        public static void SetTextTagPermanent(JassTextTag t, Boolean flag)
        {
            InternalNatives._SetTextTagPermanent(t, flag);
        }
        
        //native SetTextTagAge takes texttag t, real age returns nothing
        public delegate void SetTextTagAgePrototype(JassTextTag t, JassRealArg age);
        private static SetTextTagAgePrototype _SetTextTagAge;
        public static void SetTextTagAge(JassTextTag t, Single age)
        {
            InternalNatives._SetTextTagAge(t, age);
        }
        
        //native SetTextTagLifespan takes texttag t, real lifespan returns nothing
        public delegate void SetTextTagLifespanPrototype(JassTextTag t, JassRealArg lifespan);
        private static SetTextTagLifespanPrototype _SetTextTagLifespan;
        public static void SetTextTagLifespan(JassTextTag t, Single lifespan)
        {
            InternalNatives._SetTextTagLifespan(t, lifespan);
        }
        
        //native SetTextTagFadepoint takes texttag t, real fadepoint returns nothing
        public delegate void SetTextTagFadepointPrototype(JassTextTag t, JassRealArg fadepoint);
        private static SetTextTagFadepointPrototype _SetTextTagFadepoint;
        public static void SetTextTagFadepoint(JassTextTag t, Single fadepoint)
        {
            InternalNatives._SetTextTagFadepoint(t, fadepoint);
        }
        
        //native SetReservedLocalHeroButtons takes integer reserved returns nothing
        public delegate void SetReservedLocalHeroButtonsPrototype(JassInteger reserved);
        private static SetReservedLocalHeroButtonsPrototype _SetReservedLocalHeroButtons;
        public static void SetReservedLocalHeroButtons(JassInteger reserved)
        {
            InternalNatives._SetReservedLocalHeroButtons(reserved);
        }
        
        //native GetAllyColorFilterState takes nothing returns integer
        public delegate JassInteger GetAllyColorFilterStatePrototype();
        private static GetAllyColorFilterStatePrototype _GetAllyColorFilterState;
        public static JassInteger GetAllyColorFilterState()
        {
            return InternalNatives._GetAllyColorFilterState();
        }
        
        //native SetAllyColorFilterState takes integer state returns nothing
        public delegate void SetAllyColorFilterStatePrototype(JassInteger state);
        private static SetAllyColorFilterStatePrototype _SetAllyColorFilterState;
        public static void SetAllyColorFilterState(JassInteger state)
        {
            InternalNatives._SetAllyColorFilterState(state);
        }
        
        //native GetCreepCampFilterState takes nothing returns boolean
        public delegate JassBoolean GetCreepCampFilterStatePrototype();
        private static GetCreepCampFilterStatePrototype _GetCreepCampFilterState;
        public static Boolean GetCreepCampFilterState()
        {
            return InternalNatives._GetCreepCampFilterState();
        }
        
        //native SetCreepCampFilterState takes boolean state returns nothing
        public delegate void SetCreepCampFilterStatePrototype(JassBoolean state);
        private static SetCreepCampFilterStatePrototype _SetCreepCampFilterState;
        public static void SetCreepCampFilterState(Boolean state)
        {
            InternalNatives._SetCreepCampFilterState(state);
        }
        
        //native EnableMinimapFilterButtons takes boolean enableAlly, boolean enableCreep returns nothing
        public delegate void EnableMinimapFilterButtonsPrototype(JassBoolean enableAlly, JassBoolean enableCreep);
        private static EnableMinimapFilterButtonsPrototype _EnableMinimapFilterButtons;
        public static void EnableMinimapFilterButtons(Boolean enableAlly, Boolean enableCreep)
        {
            InternalNatives._EnableMinimapFilterButtons(enableAlly, enableCreep);
        }
        
        //native EnableDragSelect takes boolean state, boolean ui returns nothing
        public delegate void EnableDragSelectPrototype(JassBoolean state, JassBoolean ui);
        private static EnableDragSelectPrototype _EnableDragSelect;
        public static void EnableDragSelect(Boolean state, Boolean ui)
        {
            InternalNatives._EnableDragSelect(state, ui);
        }
        
        //native EnablePreSelect takes boolean state, boolean ui returns nothing
        public delegate void EnablePreSelectPrototype(JassBoolean state, JassBoolean ui);
        private static EnablePreSelectPrototype _EnablePreSelect;
        public static void EnablePreSelect(Boolean state, Boolean ui)
        {
            InternalNatives._EnablePreSelect(state, ui);
        }
        
        //native EnableSelect takes boolean state, boolean ui returns nothing
        public delegate void EnableSelectPrototype(JassBoolean state, JassBoolean ui);
        private static EnableSelectPrototype _EnableSelect;
        public static void EnableSelect(Boolean state, Boolean ui)
        {
            InternalNatives._EnableSelect(state, ui);
        }
        
        //native CreateTrackable takes string trackableModelPath, real x, real y, real facing returns trackable
        public delegate JassTrackable CreateTrackablePrototype(String trackableModelPath, JassRealArg x, JassRealArg y, JassRealArg facing);
        private static CreateTrackablePrototype _CreateTrackable;
        public static JassTrackable CreateTrackable(String trackableModelPath, Single x, Single y, Single facing)
        {
            return InternalNatives._CreateTrackable(trackableModelPath, x, y, facing);
        }
        
        //native CreateQuest takes nothing returns quest
        public delegate JassQuest CreateQuestPrototype();
        private static CreateQuestPrototype _CreateQuest;
        public static JassQuest CreateQuest()
        {
            return InternalNatives._CreateQuest();
        }
        
        //native DestroyQuest takes quest whichQuest returns nothing
        public delegate void DestroyQuestPrototype(JassQuest whichQuest);
        private static DestroyQuestPrototype _DestroyQuest;
        public static void DestroyQuest(JassQuest whichQuest)
        {
            InternalNatives._DestroyQuest(whichQuest);
        }
        
        //native QuestSetTitle takes quest whichQuest, string title returns nothing
        public delegate void QuestSetTitlePrototype(JassQuest whichQuest, String title);
        private static QuestSetTitlePrototype _QuestSetTitle;
        public static void QuestSetTitle(JassQuest whichQuest, String title)
        {
            InternalNatives._QuestSetTitle(whichQuest, title);
        }
        
        //native QuestSetDescription takes quest whichQuest, string description returns nothing
        public delegate void QuestSetDescriptionPrototype(JassQuest whichQuest, String description);
        private static QuestSetDescriptionPrototype _QuestSetDescription;
        public static void QuestSetDescription(JassQuest whichQuest, String description)
        {
            InternalNatives._QuestSetDescription(whichQuest, description);
        }
        
        //native QuestSetIconPath takes quest whichQuest, string iconPath returns nothing
        public delegate void QuestSetIconPathPrototype(JassQuest whichQuest, String iconPath);
        private static QuestSetIconPathPrototype _QuestSetIconPath;
        public static void QuestSetIconPath(JassQuest whichQuest, String iconPath)
        {
            InternalNatives._QuestSetIconPath(whichQuest, iconPath);
        }
        
        //native QuestSetRequired takes quest whichQuest, boolean required returns nothing
        public delegate void QuestSetRequiredPrototype(JassQuest whichQuest, JassBoolean required);
        private static QuestSetRequiredPrototype _QuestSetRequired;
        public static void QuestSetRequired(JassQuest whichQuest, Boolean required)
        {
            InternalNatives._QuestSetRequired(whichQuest, required);
        }
        
        //native QuestSetCompleted takes quest whichQuest, boolean completed returns nothing
        public delegate void QuestSetCompletedPrototype(JassQuest whichQuest, JassBoolean completed);
        private static QuestSetCompletedPrototype _QuestSetCompleted;
        public static void QuestSetCompleted(JassQuest whichQuest, Boolean completed)
        {
            InternalNatives._QuestSetCompleted(whichQuest, completed);
        }
        
        //native QuestSetDiscovered takes quest whichQuest, boolean discovered returns nothing
        public delegate void QuestSetDiscoveredPrototype(JassQuest whichQuest, JassBoolean discovered);
        private static QuestSetDiscoveredPrototype _QuestSetDiscovered;
        public static void QuestSetDiscovered(JassQuest whichQuest, Boolean discovered)
        {
            InternalNatives._QuestSetDiscovered(whichQuest, discovered);
        }
        
        //native QuestSetFailed takes quest whichQuest, boolean failed returns nothing
        public delegate void QuestSetFailedPrototype(JassQuest whichQuest, JassBoolean failed);
        private static QuestSetFailedPrototype _QuestSetFailed;
        public static void QuestSetFailed(JassQuest whichQuest, Boolean failed)
        {
            InternalNatives._QuestSetFailed(whichQuest, failed);
        }
        
        //native QuestSetEnabled takes quest whichQuest, boolean enabled returns nothing
        public delegate void QuestSetEnabledPrototype(JassQuest whichQuest, JassBoolean enabled);
        private static QuestSetEnabledPrototype _QuestSetEnabled;
        public static void QuestSetEnabled(JassQuest whichQuest, Boolean enabled)
        {
            InternalNatives._QuestSetEnabled(whichQuest, enabled);
        }
        
        //native IsQuestRequired takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestRequiredPrototype(JassQuest whichQuest);
        private static IsQuestRequiredPrototype _IsQuestRequired;
        public static Boolean IsQuestRequired(JassQuest whichQuest)
        {
            return InternalNatives._IsQuestRequired(whichQuest);
        }
        
        //native IsQuestCompleted takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestCompletedPrototype(JassQuest whichQuest);
        private static IsQuestCompletedPrototype _IsQuestCompleted;
        public static Boolean IsQuestCompleted(JassQuest whichQuest)
        {
            return InternalNatives._IsQuestCompleted(whichQuest);
        }
        
        //native IsQuestDiscovered takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestDiscoveredPrototype(JassQuest whichQuest);
        private static IsQuestDiscoveredPrototype _IsQuestDiscovered;
        public static Boolean IsQuestDiscovered(JassQuest whichQuest)
        {
            return InternalNatives._IsQuestDiscovered(whichQuest);
        }
        
        //native IsQuestFailed takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestFailedPrototype(JassQuest whichQuest);
        private static IsQuestFailedPrototype _IsQuestFailed;
        public static Boolean IsQuestFailed(JassQuest whichQuest)
        {
            return InternalNatives._IsQuestFailed(whichQuest);
        }
        
        //native IsQuestEnabled takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestEnabledPrototype(JassQuest whichQuest);
        private static IsQuestEnabledPrototype _IsQuestEnabled;
        public static Boolean IsQuestEnabled(JassQuest whichQuest)
        {
            return InternalNatives._IsQuestEnabled(whichQuest);
        }
        
        //native QuestCreateItem takes quest whichQuest returns questitem
        public delegate JassQuestItem QuestCreateItemPrototype(JassQuest whichQuest);
        private static QuestCreateItemPrototype _QuestCreateItem;
        public static JassQuestItem QuestCreateItem(JassQuest whichQuest)
        {
            return InternalNatives._QuestCreateItem(whichQuest);
        }
        
        //native QuestItemSetDescription takes questitem whichQuestItem, string description returns nothing
        public delegate void QuestItemSetDescriptionPrototype(JassQuestItem whichQuestItem, String description);
        private static QuestItemSetDescriptionPrototype _QuestItemSetDescription;
        public static void QuestItemSetDescription(JassQuestItem whichQuestItem, String description)
        {
            InternalNatives._QuestItemSetDescription(whichQuestItem, description);
        }
        
        //native QuestItemSetCompleted takes questitem whichQuestItem, boolean completed returns nothing
        public delegate void QuestItemSetCompletedPrototype(JassQuestItem whichQuestItem, JassBoolean completed);
        private static QuestItemSetCompletedPrototype _QuestItemSetCompleted;
        public static void QuestItemSetCompleted(JassQuestItem whichQuestItem, Boolean completed)
        {
            InternalNatives._QuestItemSetCompleted(whichQuestItem, completed);
        }
        
        //native IsQuestItemCompleted takes questitem whichQuestItem returns boolean
        public delegate JassBoolean IsQuestItemCompletedPrototype(JassQuestItem whichQuestItem);
        private static IsQuestItemCompletedPrototype _IsQuestItemCompleted;
        public static Boolean IsQuestItemCompleted(JassQuestItem whichQuestItem)
        {
            return InternalNatives._IsQuestItemCompleted(whichQuestItem);
        }
        
        //native CreateDefeatCondition takes nothing returns defeatcondition
        public delegate JassDefeatCondition CreateDefeatConditionPrototype();
        private static CreateDefeatConditionPrototype _CreateDefeatCondition;
        public static JassDefeatCondition CreateDefeatCondition()
        {
            return InternalNatives._CreateDefeatCondition();
        }
        
        //native DestroyDefeatCondition takes defeatcondition whichCondition returns nothing
        public delegate void DestroyDefeatConditionPrototype(JassDefeatCondition whichCondition);
        private static DestroyDefeatConditionPrototype _DestroyDefeatCondition;
        public static void DestroyDefeatCondition(JassDefeatCondition whichCondition)
        {
            InternalNatives._DestroyDefeatCondition(whichCondition);
        }
        
        //native DefeatConditionSetDescription takes defeatcondition whichCondition, string description returns nothing
        public delegate void DefeatConditionSetDescriptionPrototype(JassDefeatCondition whichCondition, String description);
        private static DefeatConditionSetDescriptionPrototype _DefeatConditionSetDescription;
        public static void DefeatConditionSetDescription(JassDefeatCondition whichCondition, String description)
        {
            InternalNatives._DefeatConditionSetDescription(whichCondition, description);
        }
        
        //native FlashQuestDialogButton takes nothing returns nothing
        public delegate void FlashQuestDialogButtonPrototype();
        private static FlashQuestDialogButtonPrototype _FlashQuestDialogButton;
        public static void FlashQuestDialogButton()
        {
            InternalNatives._FlashQuestDialogButton();
        }
        
        //native ForceQuestDialogUpdate takes nothing returns nothing
        public delegate void ForceQuestDialogUpdatePrototype();
        private static ForceQuestDialogUpdatePrototype _ForceQuestDialogUpdate;
        public static void ForceQuestDialogUpdate()
        {
            InternalNatives._ForceQuestDialogUpdate();
        }
        
        //native CreateTimerDialog takes timer t returns timerdialog
        public delegate JassTimerDialog CreateTimerDialogPrototype(JassTimer t);
        private static CreateTimerDialogPrototype _CreateTimerDialog;
        public static JassTimerDialog CreateTimerDialog(JassTimer t)
        {
            return InternalNatives._CreateTimerDialog(t);
        }
        
        //native DestroyTimerDialog takes timerdialog whichDialog returns nothing
        public delegate void DestroyTimerDialogPrototype(JassTimerDialog whichDialog);
        private static DestroyTimerDialogPrototype _DestroyTimerDialog;
        public static void DestroyTimerDialog(JassTimerDialog whichDialog)
        {
            InternalNatives._DestroyTimerDialog(whichDialog);
        }
        
        //native TimerDialogSetTitle takes timerdialog whichDialog, string title returns nothing
        public delegate void TimerDialogSetTitlePrototype(JassTimerDialog whichDialog, String title);
        private static TimerDialogSetTitlePrototype _TimerDialogSetTitle;
        public static void TimerDialogSetTitle(JassTimerDialog whichDialog, String title)
        {
            InternalNatives._TimerDialogSetTitle(whichDialog, title);
        }
        
        //native TimerDialogSetTitleColor takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void TimerDialogSetTitleColorPrototype(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static TimerDialogSetTitleColorPrototype _TimerDialogSetTitleColor;
        public static void TimerDialogSetTitleColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._TimerDialogSetTitleColor(whichDialog, red, green, blue, alpha);
        }
        
        //native TimerDialogSetTimeColor takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void TimerDialogSetTimeColorPrototype(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static TimerDialogSetTimeColorPrototype _TimerDialogSetTimeColor;
        public static void TimerDialogSetTimeColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._TimerDialogSetTimeColor(whichDialog, red, green, blue, alpha);
        }
        
        //native TimerDialogSetSpeed takes timerdialog whichDialog, real speedMultFactor returns nothing
        public delegate void TimerDialogSetSpeedPrototype(JassTimerDialog whichDialog, JassRealArg speedMultFactor);
        private static TimerDialogSetSpeedPrototype _TimerDialogSetSpeed;
        public static void TimerDialogSetSpeed(JassTimerDialog whichDialog, Single speedMultFactor)
        {
            InternalNatives._TimerDialogSetSpeed(whichDialog, speedMultFactor);
        }
        
        //native TimerDialogDisplay takes timerdialog whichDialog, boolean display returns nothing
        public delegate void TimerDialogDisplayPrototype(JassTimerDialog whichDialog, JassBoolean display);
        private static TimerDialogDisplayPrototype _TimerDialogDisplay;
        public static void TimerDialogDisplay(JassTimerDialog whichDialog, Boolean display)
        {
            InternalNatives._TimerDialogDisplay(whichDialog, display);
        }
        
        //native IsTimerDialogDisplayed takes timerdialog whichDialog returns boolean
        public delegate JassBoolean IsTimerDialogDisplayedPrototype(JassTimerDialog whichDialog);
        private static IsTimerDialogDisplayedPrototype _IsTimerDialogDisplayed;
        public static Boolean IsTimerDialogDisplayed(JassTimerDialog whichDialog)
        {
            return InternalNatives._IsTimerDialogDisplayed(whichDialog);
        }
        
        //native TimerDialogSetRealTimeRemaining takes timerdialog whichDialog, real timeRemaining returns nothing
        public delegate void TimerDialogSetRealTimeRemainingPrototype(JassTimerDialog whichDialog, JassRealArg timeRemaining);
        private static TimerDialogSetRealTimeRemainingPrototype _TimerDialogSetRealTimeRemaining;
        public static void TimerDialogSetRealTimeRemaining(JassTimerDialog whichDialog, Single timeRemaining)
        {
            InternalNatives._TimerDialogSetRealTimeRemaining(whichDialog, timeRemaining);
        }
        
        //native CreateLeaderboard takes nothing returns leaderboard
        public delegate JassLeaderboard CreateLeaderboardPrototype();
        private static CreateLeaderboardPrototype _CreateLeaderboard;
        public static JassLeaderboard CreateLeaderboard()
        {
            return InternalNatives._CreateLeaderboard();
        }
        
        //native DestroyLeaderboard takes leaderboard lb returns nothing
        public delegate void DestroyLeaderboardPrototype(JassLeaderboard lb);
        private static DestroyLeaderboardPrototype _DestroyLeaderboard;
        public static void DestroyLeaderboard(JassLeaderboard lb)
        {
            InternalNatives._DestroyLeaderboard(lb);
        }
        
        //native LeaderboardDisplay takes leaderboard lb, boolean show returns nothing
        public delegate void LeaderboardDisplayPrototype(JassLeaderboard lb, JassBoolean show);
        private static LeaderboardDisplayPrototype _LeaderboardDisplay;
        public static void LeaderboardDisplay(JassLeaderboard lb, Boolean show)
        {
            InternalNatives._LeaderboardDisplay(lb, show);
        }
        
        //native IsLeaderboardDisplayed takes leaderboard lb returns boolean
        public delegate JassBoolean IsLeaderboardDisplayedPrototype(JassLeaderboard lb);
        private static IsLeaderboardDisplayedPrototype _IsLeaderboardDisplayed;
        public static Boolean IsLeaderboardDisplayed(JassLeaderboard lb)
        {
            return InternalNatives._IsLeaderboardDisplayed(lb);
        }
        
        //native LeaderboardGetItemCount takes leaderboard lb returns integer
        public delegate JassInteger LeaderboardGetItemCountPrototype(JassLeaderboard lb);
        private static LeaderboardGetItemCountPrototype _LeaderboardGetItemCount;
        public static JassInteger LeaderboardGetItemCount(JassLeaderboard lb)
        {
            return InternalNatives._LeaderboardGetItemCount(lb);
        }
        
        //native LeaderboardSetSizeByItemCount takes leaderboard lb, integer count returns nothing
        public delegate void LeaderboardSetSizeByItemCountPrototype(JassLeaderboard lb, JassInteger count);
        private static LeaderboardSetSizeByItemCountPrototype _LeaderboardSetSizeByItemCount;
        public static void LeaderboardSetSizeByItemCount(JassLeaderboard lb, JassInteger count)
        {
            InternalNatives._LeaderboardSetSizeByItemCount(lb, count);
        }
        
        //native LeaderboardAddItem takes leaderboard lb, string label, integer value, player p returns nothing
        public delegate void LeaderboardAddItemPrototype(JassLeaderboard lb, String label, JassInteger value, JassPlayer p);
        private static LeaderboardAddItemPrototype _LeaderboardAddItem;
        public static void LeaderboardAddItem(JassLeaderboard lb, String label, JassInteger value, JassPlayer p)
        {
            InternalNatives._LeaderboardAddItem(lb, label, value, p);
        }
        
        //native LeaderboardRemoveItem takes leaderboard lb, integer index returns nothing
        public delegate void LeaderboardRemoveItemPrototype(JassLeaderboard lb, JassInteger index);
        private static LeaderboardRemoveItemPrototype _LeaderboardRemoveItem;
        public static void LeaderboardRemoveItem(JassLeaderboard lb, JassInteger index)
        {
            InternalNatives._LeaderboardRemoveItem(lb, index);
        }
        
        //native LeaderboardRemovePlayerItem takes leaderboard lb, player p returns nothing
        public delegate void LeaderboardRemovePlayerItemPrototype(JassLeaderboard lb, JassPlayer p);
        private static LeaderboardRemovePlayerItemPrototype _LeaderboardRemovePlayerItem;
        public static void LeaderboardRemovePlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            InternalNatives._LeaderboardRemovePlayerItem(lb, p);
        }
        
        //native LeaderboardClear takes leaderboard lb returns nothing
        public delegate void LeaderboardClearPrototype(JassLeaderboard lb);
        private static LeaderboardClearPrototype _LeaderboardClear;
        public static void LeaderboardClear(JassLeaderboard lb)
        {
            InternalNatives._LeaderboardClear(lb);
        }
        
        //native LeaderboardSortItemsByValue takes leaderboard lb, boolean ascending returns nothing
        public delegate void LeaderboardSortItemsByValuePrototype(JassLeaderboard lb, JassBoolean ascending);
        private static LeaderboardSortItemsByValuePrototype _LeaderboardSortItemsByValue;
        public static void LeaderboardSortItemsByValue(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives._LeaderboardSortItemsByValue(lb, ascending);
        }
        
        //native LeaderboardSortItemsByPlayer takes leaderboard lb, boolean ascending returns nothing
        public delegate void LeaderboardSortItemsByPlayerPrototype(JassLeaderboard lb, JassBoolean ascending);
        private static LeaderboardSortItemsByPlayerPrototype _LeaderboardSortItemsByPlayer;
        public static void LeaderboardSortItemsByPlayer(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives._LeaderboardSortItemsByPlayer(lb, ascending);
        }
        
        //native LeaderboardSortItemsByLabel takes leaderboard lb, boolean ascending returns nothing
        public delegate void LeaderboardSortItemsByLabelPrototype(JassLeaderboard lb, JassBoolean ascending);
        private static LeaderboardSortItemsByLabelPrototype _LeaderboardSortItemsByLabel;
        public static void LeaderboardSortItemsByLabel(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives._LeaderboardSortItemsByLabel(lb, ascending);
        }
        
        //native LeaderboardHasPlayerItem takes leaderboard lb, player p returns boolean
        public delegate JassBoolean LeaderboardHasPlayerItemPrototype(JassLeaderboard lb, JassPlayer p);
        private static LeaderboardHasPlayerItemPrototype _LeaderboardHasPlayerItem;
        public static Boolean LeaderboardHasPlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            return InternalNatives._LeaderboardHasPlayerItem(lb, p);
        }
        
        //native LeaderboardGetPlayerIndex takes leaderboard lb, player p returns integer
        public delegate JassInteger LeaderboardGetPlayerIndexPrototype(JassLeaderboard lb, JassPlayer p);
        private static LeaderboardGetPlayerIndexPrototype _LeaderboardGetPlayerIndex;
        public static JassInteger LeaderboardGetPlayerIndex(JassLeaderboard lb, JassPlayer p)
        {
            return InternalNatives._LeaderboardGetPlayerIndex(lb, p);
        }
        
        //native LeaderboardSetLabel takes leaderboard lb, string label returns nothing
        public delegate void LeaderboardSetLabelPrototype(JassLeaderboard lb, String label);
        private static LeaderboardSetLabelPrototype _LeaderboardSetLabel;
        public static void LeaderboardSetLabel(JassLeaderboard lb, String label)
        {
            InternalNatives._LeaderboardSetLabel(lb, label);
        }
        
        //native LeaderboardGetLabelText takes leaderboard lb returns string
        public delegate String LeaderboardGetLabelTextPrototype(JassLeaderboard lb);
        private static LeaderboardGetLabelTextPrototype _LeaderboardGetLabelText;
        public static String LeaderboardGetLabelText(JassLeaderboard lb)
        {
            return InternalNatives._LeaderboardGetLabelText(lb);
        }
        
        //native PlayerSetLeaderboard takes player toPlayer, leaderboard lb returns nothing
        public delegate void PlayerSetLeaderboardPrototype(JassPlayer toPlayer, JassLeaderboard lb);
        private static PlayerSetLeaderboardPrototype _PlayerSetLeaderboard;
        public static void PlayerSetLeaderboard(JassPlayer toPlayer, JassLeaderboard lb)
        {
            InternalNatives._PlayerSetLeaderboard(toPlayer, lb);
        }
        
        //native PlayerGetLeaderboard takes player toPlayer returns leaderboard
        public delegate JassLeaderboard PlayerGetLeaderboardPrototype(JassPlayer toPlayer);
        private static PlayerGetLeaderboardPrototype _PlayerGetLeaderboard;
        public static JassLeaderboard PlayerGetLeaderboard(JassPlayer toPlayer)
        {
            return InternalNatives._PlayerGetLeaderboard(toPlayer);
        }
        
        //native LeaderboardSetLabelColor takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void LeaderboardSetLabelColorPrototype(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static LeaderboardSetLabelColorPrototype _LeaderboardSetLabelColor;
        public static void LeaderboardSetLabelColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._LeaderboardSetLabelColor(lb, red, green, blue, alpha);
        }
        
        //native LeaderboardSetValueColor takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void LeaderboardSetValueColorPrototype(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static LeaderboardSetValueColorPrototype _LeaderboardSetValueColor;
        public static void LeaderboardSetValueColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._LeaderboardSetValueColor(lb, red, green, blue, alpha);
        }
        
        //native LeaderboardSetStyle takes leaderboard lb, boolean showLabel, boolean showNames, boolean showValues, boolean showIcons returns nothing
        public delegate void LeaderboardSetStylePrototype(JassLeaderboard lb, JassBoolean showLabel, JassBoolean showNames, JassBoolean showValues, JassBoolean showIcons);
        private static LeaderboardSetStylePrototype _LeaderboardSetStyle;
        public static void LeaderboardSetStyle(JassLeaderboard lb, Boolean showLabel, Boolean showNames, Boolean showValues, Boolean showIcons)
        {
            InternalNatives._LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);
        }
        
        //native LeaderboardSetItemValue takes leaderboard lb, integer whichItem, integer val returns nothing
        public delegate void LeaderboardSetItemValuePrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger val);
        private static LeaderboardSetItemValuePrototype _LeaderboardSetItemValue;
        public static void LeaderboardSetItemValue(JassLeaderboard lb, JassInteger whichItem, JassInteger val)
        {
            InternalNatives._LeaderboardSetItemValue(lb, whichItem, val);
        }
        
        //native LeaderboardSetItemLabel takes leaderboard lb, integer whichItem, string val returns nothing
        public delegate void LeaderboardSetItemLabelPrototype(JassLeaderboard lb, JassInteger whichItem, String val);
        private static LeaderboardSetItemLabelPrototype _LeaderboardSetItemLabel;
        public static void LeaderboardSetItemLabel(JassLeaderboard lb, JassInteger whichItem, String val)
        {
            InternalNatives._LeaderboardSetItemLabel(lb, whichItem, val);
        }
        
        //native LeaderboardSetItemStyle takes leaderboard lb, integer whichItem, boolean showLabel, boolean showValue, boolean showIcon returns nothing
        public delegate void LeaderboardSetItemStylePrototype(JassLeaderboard lb, JassInteger whichItem, JassBoolean showLabel, JassBoolean showValue, JassBoolean showIcon);
        private static LeaderboardSetItemStylePrototype _LeaderboardSetItemStyle;
        public static void LeaderboardSetItemStyle(JassLeaderboard lb, JassInteger whichItem, Boolean showLabel, Boolean showValue, Boolean showIcon)
        {
            InternalNatives._LeaderboardSetItemStyle(lb, whichItem, showLabel, showValue, showIcon);
        }
        
        //native LeaderboardSetItemLabelColor takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void LeaderboardSetItemLabelColorPrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static LeaderboardSetItemLabelColorPrototype _LeaderboardSetItemLabelColor;
        public static void LeaderboardSetItemLabelColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._LeaderboardSetItemLabelColor(lb, whichItem, red, green, blue, alpha);
        }
        
        //native LeaderboardSetItemValueColor takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void LeaderboardSetItemValueColorPrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static LeaderboardSetItemValueColorPrototype _LeaderboardSetItemValueColor;
        public static void LeaderboardSetItemValueColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._LeaderboardSetItemValueColor(lb, whichItem, red, green, blue, alpha);
        }
        
        //native CreateMultiboard takes nothing returns multiboard
        public delegate JassMultiboard CreateMultiboardPrototype();
        private static CreateMultiboardPrototype _CreateMultiboard;
        public static JassMultiboard CreateMultiboard()
        {
            return InternalNatives._CreateMultiboard();
        }
        
        //native DestroyMultiboard takes multiboard lb returns nothing
        public delegate void DestroyMultiboardPrototype(JassMultiboard lb);
        private static DestroyMultiboardPrototype _DestroyMultiboard;
        public static void DestroyMultiboard(JassMultiboard lb)
        {
            InternalNatives._DestroyMultiboard(lb);
        }
        
        //native MultiboardDisplay takes multiboard lb, boolean show returns nothing
        public delegate void MultiboardDisplayPrototype(JassMultiboard lb, JassBoolean show);
        private static MultiboardDisplayPrototype _MultiboardDisplay;
        public static void MultiboardDisplay(JassMultiboard lb, Boolean show)
        {
            InternalNatives._MultiboardDisplay(lb, show);
        }
        
        //native IsMultiboardDisplayed takes multiboard lb returns boolean
        public delegate JassBoolean IsMultiboardDisplayedPrototype(JassMultiboard lb);
        private static IsMultiboardDisplayedPrototype _IsMultiboardDisplayed;
        public static Boolean IsMultiboardDisplayed(JassMultiboard lb)
        {
            return InternalNatives._IsMultiboardDisplayed(lb);
        }
        
        //native MultiboardMinimize takes multiboard lb, boolean minimize returns nothing
        public delegate void MultiboardMinimizePrototype(JassMultiboard lb, JassBoolean minimize);
        private static MultiboardMinimizePrototype _MultiboardMinimize;
        public static void MultiboardMinimize(JassMultiboard lb, Boolean minimize)
        {
            InternalNatives._MultiboardMinimize(lb, minimize);
        }
        
        //native IsMultiboardMinimized takes multiboard lb returns boolean
        public delegate JassBoolean IsMultiboardMinimizedPrototype(JassMultiboard lb);
        private static IsMultiboardMinimizedPrototype _IsMultiboardMinimized;
        public static Boolean IsMultiboardMinimized(JassMultiboard lb)
        {
            return InternalNatives._IsMultiboardMinimized(lb);
        }
        
        //native MultiboardClear takes multiboard lb returns nothing
        public delegate void MultiboardClearPrototype(JassMultiboard lb);
        private static MultiboardClearPrototype _MultiboardClear;
        public static void MultiboardClear(JassMultiboard lb)
        {
            InternalNatives._MultiboardClear(lb);
        }
        
        //native MultiboardSetTitleText takes multiboard lb, string label returns nothing
        public delegate void MultiboardSetTitleTextPrototype(JassMultiboard lb, String label);
        private static MultiboardSetTitleTextPrototype _MultiboardSetTitleText;
        public static void MultiboardSetTitleText(JassMultiboard lb, String label)
        {
            InternalNatives._MultiboardSetTitleText(lb, label);
        }
        
        //native MultiboardGetTitleText takes multiboard lb returns string
        public delegate String MultiboardGetTitleTextPrototype(JassMultiboard lb);
        private static MultiboardGetTitleTextPrototype _MultiboardGetTitleText;
        public static String MultiboardGetTitleText(JassMultiboard lb)
        {
            return InternalNatives._MultiboardGetTitleText(lb);
        }
        
        //native MultiboardSetTitleTextColor takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void MultiboardSetTitleTextColorPrototype(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static MultiboardSetTitleTextColorPrototype _MultiboardSetTitleTextColor;
        public static void MultiboardSetTitleTextColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._MultiboardSetTitleTextColor(lb, red, green, blue, alpha);
        }
        
        //native MultiboardGetRowCount takes multiboard lb returns integer
        public delegate JassInteger MultiboardGetRowCountPrototype(JassMultiboard lb);
        private static MultiboardGetRowCountPrototype _MultiboardGetRowCount;
        public static JassInteger MultiboardGetRowCount(JassMultiboard lb)
        {
            return InternalNatives._MultiboardGetRowCount(lb);
        }
        
        //native MultiboardGetColumnCount takes multiboard lb returns integer
        public delegate JassInteger MultiboardGetColumnCountPrototype(JassMultiboard lb);
        private static MultiboardGetColumnCountPrototype _MultiboardGetColumnCount;
        public static JassInteger MultiboardGetColumnCount(JassMultiboard lb)
        {
            return InternalNatives._MultiboardGetColumnCount(lb);
        }
        
        //native MultiboardSetColumnCount takes multiboard lb, integer count returns nothing
        public delegate void MultiboardSetColumnCountPrototype(JassMultiboard lb, JassInteger count);
        private static MultiboardSetColumnCountPrototype _MultiboardSetColumnCount;
        public static void MultiboardSetColumnCount(JassMultiboard lb, JassInteger count)
        {
            InternalNatives._MultiboardSetColumnCount(lb, count);
        }
        
        //native MultiboardSetRowCount takes multiboard lb, integer count returns nothing
        public delegate void MultiboardSetRowCountPrototype(JassMultiboard lb, JassInteger count);
        private static MultiboardSetRowCountPrototype _MultiboardSetRowCount;
        public static void MultiboardSetRowCount(JassMultiboard lb, JassInteger count)
        {
            InternalNatives._MultiboardSetRowCount(lb, count);
        }
        
        //native MultiboardSetItemsStyle takes multiboard lb, boolean showValues, boolean showIcons returns nothing
        public delegate void MultiboardSetItemsStylePrototype(JassMultiboard lb, JassBoolean showValues, JassBoolean showIcons);
        private static MultiboardSetItemsStylePrototype _MultiboardSetItemsStyle;
        public static void MultiboardSetItemsStyle(JassMultiboard lb, Boolean showValues, Boolean showIcons)
        {
            InternalNatives._MultiboardSetItemsStyle(lb, showValues, showIcons);
        }
        
        //native MultiboardSetItemsValue takes multiboard lb, string value returns nothing
        public delegate void MultiboardSetItemsValuePrototype(JassMultiboard lb, String value);
        private static MultiboardSetItemsValuePrototype _MultiboardSetItemsValue;
        public static void MultiboardSetItemsValue(JassMultiboard lb, String value)
        {
            InternalNatives._MultiboardSetItemsValue(lb, value);
        }
        
        //native MultiboardSetItemsValueColor takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void MultiboardSetItemsValueColorPrototype(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static MultiboardSetItemsValueColorPrototype _MultiboardSetItemsValueColor;
        public static void MultiboardSetItemsValueColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._MultiboardSetItemsValueColor(lb, red, green, blue, alpha);
        }
        
        //native MultiboardSetItemsWidth takes multiboard lb, real width returns nothing
        public delegate void MultiboardSetItemsWidthPrototype(JassMultiboard lb, JassRealArg width);
        private static MultiboardSetItemsWidthPrototype _MultiboardSetItemsWidth;
        public static void MultiboardSetItemsWidth(JassMultiboard lb, Single width)
        {
            InternalNatives._MultiboardSetItemsWidth(lb, width);
        }
        
        //native MultiboardSetItemsIcon takes multiboard lb, string iconPath returns nothing
        public delegate void MultiboardSetItemsIconPrototype(JassMultiboard lb, String iconPath);
        private static MultiboardSetItemsIconPrototype _MultiboardSetItemsIcon;
        public static void MultiboardSetItemsIcon(JassMultiboard lb, String iconPath)
        {
            InternalNatives._MultiboardSetItemsIcon(lb, iconPath);
        }
        
        //native MultiboardGetItem takes multiboard lb, integer row, integer column returns multiboarditem
        public delegate JassMultiboardItem MultiboardGetItemPrototype(JassMultiboard lb, JassInteger row, JassInteger column);
        private static MultiboardGetItemPrototype _MultiboardGetItem;
        public static JassMultiboardItem MultiboardGetItem(JassMultiboard lb, JassInteger row, JassInteger column)
        {
            return InternalNatives._MultiboardGetItem(lb, row, column);
        }
        
        //native MultiboardReleaseItem takes multiboarditem mbi returns nothing
        public delegate void MultiboardReleaseItemPrototype(JassMultiboardItem mbi);
        private static MultiboardReleaseItemPrototype _MultiboardReleaseItem;
        public static void MultiboardReleaseItem(JassMultiboardItem mbi)
        {
            InternalNatives._MultiboardReleaseItem(mbi);
        }
        
        //native MultiboardSetItemStyle takes multiboarditem mbi, boolean showValue, boolean showIcon returns nothing
        public delegate void MultiboardSetItemStylePrototype(JassMultiboardItem mbi, JassBoolean showValue, JassBoolean showIcon);
        private static MultiboardSetItemStylePrototype _MultiboardSetItemStyle;
        public static void MultiboardSetItemStyle(JassMultiboardItem mbi, Boolean showValue, Boolean showIcon)
        {
            InternalNatives._MultiboardSetItemStyle(mbi, showValue, showIcon);
        }
        
        //native MultiboardSetItemValue takes multiboarditem mbi, string val returns nothing
        public delegate void MultiboardSetItemValuePrototype(JassMultiboardItem mbi, String val);
        private static MultiboardSetItemValuePrototype _MultiboardSetItemValue;
        public static void MultiboardSetItemValue(JassMultiboardItem mbi, String val)
        {
            InternalNatives._MultiboardSetItemValue(mbi, val);
        }
        
        //native MultiboardSetItemValueColor takes multiboarditem mbi, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void MultiboardSetItemValueColorPrototype(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static MultiboardSetItemValueColorPrototype _MultiboardSetItemValueColor;
        public static void MultiboardSetItemValueColor(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._MultiboardSetItemValueColor(mbi, red, green, blue, alpha);
        }
        
        //native MultiboardSetItemWidth takes multiboarditem mbi, real width returns nothing
        public delegate void MultiboardSetItemWidthPrototype(JassMultiboardItem mbi, JassRealArg width);
        private static MultiboardSetItemWidthPrototype _MultiboardSetItemWidth;
        public static void MultiboardSetItemWidth(JassMultiboardItem mbi, Single width)
        {
            InternalNatives._MultiboardSetItemWidth(mbi, width);
        }
        
        //native MultiboardSetItemIcon takes multiboarditem mbi, string iconFileName returns nothing
        public delegate void MultiboardSetItemIconPrototype(JassMultiboardItem mbi, String iconFileName);
        private static MultiboardSetItemIconPrototype _MultiboardSetItemIcon;
        public static void MultiboardSetItemIcon(JassMultiboardItem mbi, String iconFileName)
        {
            InternalNatives._MultiboardSetItemIcon(mbi, iconFileName);
        }
        
        //native MultiboardSuppressDisplay takes boolean flag returns nothing
        public delegate void MultiboardSuppressDisplayPrototype(JassBoolean flag);
        private static MultiboardSuppressDisplayPrototype _MultiboardSuppressDisplay;
        public static void MultiboardSuppressDisplay(Boolean flag)
        {
            InternalNatives._MultiboardSuppressDisplay(flag);
        }
        
        //native SetCameraPosition takes real x, real y returns nothing
        public delegate void SetCameraPositionPrototype(JassRealArg x, JassRealArg y);
        private static SetCameraPositionPrototype _SetCameraPosition;
        public static void SetCameraPosition(Single x, Single y)
        {
            InternalNatives._SetCameraPosition(x, y);
        }
        
        //native SetCameraQuickPosition takes real x, real y returns nothing
        public delegate void SetCameraQuickPositionPrototype(JassRealArg x, JassRealArg y);
        private static SetCameraQuickPositionPrototype _SetCameraQuickPosition;
        public static void SetCameraQuickPosition(Single x, Single y)
        {
            InternalNatives._SetCameraQuickPosition(x, y);
        }
        
        //native SetCameraBounds takes real x1, real y1, real x2, real y2, real x3, real y3, real x4, real y4 returns nothing
        public delegate void SetCameraBoundsPrototype(JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2, JassRealArg x3, JassRealArg y3, JassRealArg x4, JassRealArg y4);
        private static SetCameraBoundsPrototype _SetCameraBounds;
        public static void SetCameraBounds(Single x1, Single y1, Single x2, Single y2, Single x3, Single y3, Single x4, Single y4)
        {
            InternalNatives._SetCameraBounds(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        
        //native StopCamera takes nothing returns nothing
        public delegate void StopCameraPrototype();
        private static StopCameraPrototype _StopCamera;
        public static void StopCamera()
        {
            InternalNatives._StopCamera();
        }
        
        //native ResetToGameCamera takes real duration returns nothing
        public delegate void ResetToGameCameraPrototype(JassRealArg duration);
        private static ResetToGameCameraPrototype _ResetToGameCamera;
        public static void ResetToGameCamera(Single duration)
        {
            InternalNatives._ResetToGameCamera(duration);
        }
        
        //native PanCameraTo takes real x, real y returns nothing
        public delegate void PanCameraToPrototype(JassRealArg x, JassRealArg y);
        private static PanCameraToPrototype _PanCameraTo;
        public static void PanCameraTo(Single x, Single y)
        {
            InternalNatives._PanCameraTo(x, y);
        }
        
        //native PanCameraToTimed takes real x, real y, real duration returns nothing
        public delegate void PanCameraToTimedPrototype(JassRealArg x, JassRealArg y, JassRealArg duration);
        private static PanCameraToTimedPrototype _PanCameraToTimed;
        public static void PanCameraToTimed(Single x, Single y, Single duration)
        {
            InternalNatives._PanCameraToTimed(x, y, duration);
        }
        
        //native PanCameraToWithZ takes real x, real y, real zOffsetDest returns nothing
        public delegate void PanCameraToWithZPrototype(JassRealArg x, JassRealArg y, JassRealArg zOffsetDest);
        private static PanCameraToWithZPrototype _PanCameraToWithZ;
        public static void PanCameraToWithZ(Single x, Single y, Single zOffsetDest)
        {
            InternalNatives._PanCameraToWithZ(x, y, zOffsetDest);
        }
        
        //native PanCameraToTimedWithZ takes real x, real y, real zOffsetDest, real duration returns nothing
        public delegate void PanCameraToTimedWithZPrototype(JassRealArg x, JassRealArg y, JassRealArg zOffsetDest, JassRealArg duration);
        private static PanCameraToTimedWithZPrototype _PanCameraToTimedWithZ;
        public static void PanCameraToTimedWithZ(Single x, Single y, Single zOffsetDest, Single duration)
        {
            InternalNatives._PanCameraToTimedWithZ(x, y, zOffsetDest, duration);
        }
        
        //native SetCinematicCamera takes string cameraModelFile returns nothing
        public delegate void SetCinematicCameraPrototype(String cameraModelFile);
        private static SetCinematicCameraPrototype _SetCinematicCamera;
        public static void SetCinematicCamera(String cameraModelFile)
        {
            InternalNatives._SetCinematicCamera(cameraModelFile);
        }
        
        //native SetCameraRotateMode takes real x, real y, real radiansToSweep, real duration returns nothing
        public delegate void SetCameraRotateModePrototype(JassRealArg x, JassRealArg y, JassRealArg radiansToSweep, JassRealArg duration);
        private static SetCameraRotateModePrototype _SetCameraRotateMode;
        public static void SetCameraRotateMode(Single x, Single y, Single radiansToSweep, Single duration)
        {
            InternalNatives._SetCameraRotateMode(x, y, radiansToSweep, duration);
        }
        
        //native SetCameraField takes camerafield whichField, real value, real duration returns nothing
        public delegate void SetCameraFieldPrototype(JassCameraField whichField, JassRealArg value, JassRealArg duration);
        private static SetCameraFieldPrototype _SetCameraField;
        public static void SetCameraField(JassCameraField whichField, Single value, Single duration)
        {
            InternalNatives._SetCameraField(whichField, value, duration);
        }
        
        //native AdjustCameraField takes camerafield whichField, real offset, real duration returns nothing
        public delegate void AdjustCameraFieldPrototype(JassCameraField whichField, JassRealArg offset, JassRealArg duration);
        private static AdjustCameraFieldPrototype _AdjustCameraField;
        public static void AdjustCameraField(JassCameraField whichField, Single offset, Single duration)
        {
            InternalNatives._AdjustCameraField(whichField, offset, duration);
        }
        
        //native SetCameraTargetController takes unit whichUnit, real xoffset, real yoffset, boolean inheritOrientation returns nothing
        public delegate void SetCameraTargetControllerPrototype(JassUnit whichUnit, JassRealArg xoffset, JassRealArg yoffset, JassBoolean inheritOrientation);
        private static SetCameraTargetControllerPrototype _SetCameraTargetController;
        public static void SetCameraTargetController(JassUnit whichUnit, Single xoffset, Single yoffset, Boolean inheritOrientation)
        {
            InternalNatives._SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);
        }
        
        //native SetCameraOrientController takes unit whichUnit, real xoffset, real yoffset returns nothing
        public delegate void SetCameraOrientControllerPrototype(JassUnit whichUnit, JassRealArg xoffset, JassRealArg yoffset);
        private static SetCameraOrientControllerPrototype _SetCameraOrientController;
        public static void SetCameraOrientController(JassUnit whichUnit, Single xoffset, Single yoffset)
        {
            InternalNatives._SetCameraOrientController(whichUnit, xoffset, yoffset);
        }
        
        //native CreateCameraSetup takes nothing returns camerasetup
        public delegate JassCameraSetup CreateCameraSetupPrototype();
        private static CreateCameraSetupPrototype _CreateCameraSetup;
        public static JassCameraSetup CreateCameraSetup()
        {
            return InternalNatives._CreateCameraSetup();
        }
        
        //native CameraSetupSetField takes camerasetup whichSetup, camerafield whichField, real value, real duration returns nothing
        public delegate void CameraSetupSetFieldPrototype(JassCameraSetup whichSetup, JassCameraField whichField, JassRealArg value, JassRealArg duration);
        private static CameraSetupSetFieldPrototype _CameraSetupSetField;
        public static void CameraSetupSetField(JassCameraSetup whichSetup, JassCameraField whichField, Single value, Single duration)
        {
            InternalNatives._CameraSetupSetField(whichSetup, whichField, value, duration);
        }
        
        //native CameraSetupGetField takes camerasetup whichSetup, camerafield whichField returns real
        public delegate JassRealRet CameraSetupGetFieldPrototype(JassCameraSetup whichSetup, JassCameraField whichField);
        private static CameraSetupGetFieldPrototype _CameraSetupGetField;
        public static Single CameraSetupGetField(JassCameraSetup whichSetup, JassCameraField whichField)
        {
            return InternalNatives._CameraSetupGetField(whichSetup, whichField);
        }
        
        //native CameraSetupSetDestPosition takes camerasetup whichSetup, real x, real y, real duration returns nothing
        public delegate void CameraSetupSetDestPositionPrototype(JassCameraSetup whichSetup, JassRealArg x, JassRealArg y, JassRealArg duration);
        private static CameraSetupSetDestPositionPrototype _CameraSetupSetDestPosition;
        public static void CameraSetupSetDestPosition(JassCameraSetup whichSetup, Single x, Single y, Single duration)
        {
            InternalNatives._CameraSetupSetDestPosition(whichSetup, x, y, duration);
        }
        
        //native CameraSetupGetDestPositionLoc takes camerasetup whichSetup returns location
        public delegate JassLocation CameraSetupGetDestPositionLocPrototype(JassCameraSetup whichSetup);
        private static CameraSetupGetDestPositionLocPrototype _CameraSetupGetDestPositionLoc;
        public static JassLocation CameraSetupGetDestPositionLoc(JassCameraSetup whichSetup)
        {
            return InternalNatives._CameraSetupGetDestPositionLoc(whichSetup);
        }
        
        //native CameraSetupGetDestPositionX takes camerasetup whichSetup returns real
        public delegate JassRealRet CameraSetupGetDestPositionXPrototype(JassCameraSetup whichSetup);
        private static CameraSetupGetDestPositionXPrototype _CameraSetupGetDestPositionX;
        public static Single CameraSetupGetDestPositionX(JassCameraSetup whichSetup)
        {
            return InternalNatives._CameraSetupGetDestPositionX(whichSetup);
        }
        
        //native CameraSetupGetDestPositionY takes camerasetup whichSetup returns real
        public delegate JassRealRet CameraSetupGetDestPositionYPrototype(JassCameraSetup whichSetup);
        private static CameraSetupGetDestPositionYPrototype _CameraSetupGetDestPositionY;
        public static Single CameraSetupGetDestPositionY(JassCameraSetup whichSetup)
        {
            return InternalNatives._CameraSetupGetDestPositionY(whichSetup);
        }
        
        //native CameraSetupApply takes camerasetup whichSetup, boolean doPan, boolean panTimed returns nothing
        public delegate void CameraSetupApplyPrototype(JassCameraSetup whichSetup, JassBoolean doPan, JassBoolean panTimed);
        private static CameraSetupApplyPrototype _CameraSetupApply;
        public static void CameraSetupApply(JassCameraSetup whichSetup, Boolean doPan, Boolean panTimed)
        {
            InternalNatives._CameraSetupApply(whichSetup, doPan, panTimed);
        }
        
        //native CameraSetupApplyWithZ takes camerasetup whichSetup, real zDestOffset returns nothing
        public delegate void CameraSetupApplyWithZPrototype(JassCameraSetup whichSetup, JassRealArg zDestOffset);
        private static CameraSetupApplyWithZPrototype _CameraSetupApplyWithZ;
        public static void CameraSetupApplyWithZ(JassCameraSetup whichSetup, Single zDestOffset)
        {
            InternalNatives._CameraSetupApplyWithZ(whichSetup, zDestOffset);
        }
        
        //native CameraSetupApplyForceDuration takes camerasetup whichSetup, boolean doPan, real forceDuration returns nothing
        public delegate void CameraSetupApplyForceDurationPrototype(JassCameraSetup whichSetup, JassBoolean doPan, JassRealArg forceDuration);
        private static CameraSetupApplyForceDurationPrototype _CameraSetupApplyForceDuration;
        public static void CameraSetupApplyForceDuration(JassCameraSetup whichSetup, Boolean doPan, Single forceDuration)
        {
            InternalNatives._CameraSetupApplyForceDuration(whichSetup, doPan, forceDuration);
        }
        
        //native CameraSetupApplyForceDurationWithZ takes camerasetup whichSetup, real zDestOffset, real forceDuration returns nothing
        public delegate void CameraSetupApplyForceDurationWithZPrototype(JassCameraSetup whichSetup, JassRealArg zDestOffset, JassRealArg forceDuration);
        private static CameraSetupApplyForceDurationWithZPrototype _CameraSetupApplyForceDurationWithZ;
        public static void CameraSetupApplyForceDurationWithZ(JassCameraSetup whichSetup, Single zDestOffset, Single forceDuration)
        {
            InternalNatives._CameraSetupApplyForceDurationWithZ(whichSetup, zDestOffset, forceDuration);
        }
        
        //native CameraSetTargetNoise takes real mag, real velocity returns nothing
        public delegate void CameraSetTargetNoisePrototype(JassRealArg mag, JassRealArg velocity);
        private static CameraSetTargetNoisePrototype _CameraSetTargetNoise;
        public static void CameraSetTargetNoise(Single mag, Single velocity)
        {
            InternalNatives._CameraSetTargetNoise(mag, velocity);
        }
        
        //native CameraSetSourceNoise takes real mag, real velocity returns nothing
        public delegate void CameraSetSourceNoisePrototype(JassRealArg mag, JassRealArg velocity);
        private static CameraSetSourceNoisePrototype _CameraSetSourceNoise;
        public static void CameraSetSourceNoise(Single mag, Single velocity)
        {
            InternalNatives._CameraSetSourceNoise(mag, velocity);
        }
        
        //native CameraSetTargetNoiseEx takes real mag, real velocity, boolean vertOnly returns nothing
        public delegate void CameraSetTargetNoiseExPrototype(JassRealArg mag, JassRealArg velocity, JassBoolean vertOnly);
        private static CameraSetTargetNoiseExPrototype _CameraSetTargetNoiseEx;
        public static void CameraSetTargetNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            InternalNatives._CameraSetTargetNoiseEx(mag, velocity, vertOnly);
        }
        
        //native CameraSetSourceNoiseEx takes real mag, real velocity, boolean vertOnly returns nothing
        public delegate void CameraSetSourceNoiseExPrototype(JassRealArg mag, JassRealArg velocity, JassBoolean vertOnly);
        private static CameraSetSourceNoiseExPrototype _CameraSetSourceNoiseEx;
        public static void CameraSetSourceNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            InternalNatives._CameraSetSourceNoiseEx(mag, velocity, vertOnly);
        }
        
        //native CameraSetSmoothingFactor takes real factor returns nothing
        public delegate void CameraSetSmoothingFactorPrototype(JassRealArg factor);
        private static CameraSetSmoothingFactorPrototype _CameraSetSmoothingFactor;
        public static void CameraSetSmoothingFactor(Single factor)
        {
            InternalNatives._CameraSetSmoothingFactor(factor);
        }
        
        //native SetCineFilterTexture takes string filename returns nothing
        public delegate void SetCineFilterTexturePrototype(String filename);
        private static SetCineFilterTexturePrototype _SetCineFilterTexture;
        public static void SetCineFilterTexture(String filename)
        {
            InternalNatives._SetCineFilterTexture(filename);
        }
        
        //native SetCineFilterBlendMode takes blendmode whichMode returns nothing
        public delegate void SetCineFilterBlendModePrototype(JassBlendMode whichMode);
        private static SetCineFilterBlendModePrototype _SetCineFilterBlendMode;
        public static void SetCineFilterBlendMode(JassBlendMode whichMode)
        {
            InternalNatives._SetCineFilterBlendMode(whichMode);
        }
        
        //native SetCineFilterTexMapFlags takes texmapflags whichFlags returns nothing
        public delegate void SetCineFilterTexMapFlagsPrototype(JassTextureMapFlags whichFlags);
        private static SetCineFilterTexMapFlagsPrototype _SetCineFilterTexMapFlags;
        public static void SetCineFilterTexMapFlags(JassTextureMapFlags whichFlags)
        {
            InternalNatives._SetCineFilterTexMapFlags(whichFlags);
        }
        
        //native SetCineFilterStartUV takes real minu, real minv, real maxu, real maxv returns nothing
        public delegate void SetCineFilterStartUVPrototype(JassRealArg minu, JassRealArg minv, JassRealArg maxu, JassRealArg maxv);
        private static SetCineFilterStartUVPrototype _SetCineFilterStartUV;
        public static void SetCineFilterStartUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            InternalNatives._SetCineFilterStartUV(minu, minv, maxu, maxv);
        }
        
        //native SetCineFilterEndUV takes real minu, real minv, real maxu, real maxv returns nothing
        public delegate void SetCineFilterEndUVPrototype(JassRealArg minu, JassRealArg minv, JassRealArg maxu, JassRealArg maxv);
        private static SetCineFilterEndUVPrototype _SetCineFilterEndUV;
        public static void SetCineFilterEndUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            InternalNatives._SetCineFilterEndUV(minu, minv, maxu, maxv);
        }
        
        //native SetCineFilterStartColor takes integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetCineFilterStartColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetCineFilterStartColorPrototype _SetCineFilterStartColor;
        public static void SetCineFilterStartColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._SetCineFilterStartColor(red, green, blue, alpha);
        }
        
        //native SetCineFilterEndColor takes integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetCineFilterEndColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetCineFilterEndColorPrototype _SetCineFilterEndColor;
        public static void SetCineFilterEndColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._SetCineFilterEndColor(red, green, blue, alpha);
        }
        
        //native SetCineFilterDuration takes real duration returns nothing
        public delegate void SetCineFilterDurationPrototype(JassRealArg duration);
        private static SetCineFilterDurationPrototype _SetCineFilterDuration;
        public static void SetCineFilterDuration(Single duration)
        {
            InternalNatives._SetCineFilterDuration(duration);
        }
        
        //native DisplayCineFilter takes boolean flag returns nothing
        public delegate void DisplayCineFilterPrototype(JassBoolean flag);
        private static DisplayCineFilterPrototype _DisplayCineFilter;
        public static void DisplayCineFilter(Boolean flag)
        {
            InternalNatives._DisplayCineFilter(flag);
        }
        
        //native IsCineFilterDisplayed takes nothing returns boolean
        public delegate JassBoolean IsCineFilterDisplayedPrototype();
        private static IsCineFilterDisplayedPrototype _IsCineFilterDisplayed;
        public static Boolean IsCineFilterDisplayed()
        {
            return InternalNatives._IsCineFilterDisplayed();
        }
        
        //native SetCinematicScene takes integer portraitUnitId, playercolor color, string speakerTitle, string text, real sceneDuration, real voiceoverDuration returns nothing
        public delegate void SetCinematicScenePrototype(JassInteger portraitUnitId, JassPlayerColor color, String speakerTitle, String text, JassRealArg sceneDuration, JassRealArg voiceoverDuration);
        private static SetCinematicScenePrototype _SetCinematicScene;
        public static void SetCinematicScene(JassInteger portraitUnitId, JassPlayerColor color, String speakerTitle, String text, Single sceneDuration, Single voiceoverDuration)
        {
            InternalNatives._SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);
        }
        
        //native EndCinematicScene takes nothing returns nothing
        public delegate void EndCinematicScenePrototype();
        private static EndCinematicScenePrototype _EndCinematicScene;
        public static void EndCinematicScene()
        {
            InternalNatives._EndCinematicScene();
        }
        
        //native ForceCinematicSubtitles takes boolean flag returns nothing
        public delegate void ForceCinematicSubtitlesPrototype(JassBoolean flag);
        private static ForceCinematicSubtitlesPrototype _ForceCinematicSubtitles;
        public static void ForceCinematicSubtitles(Boolean flag)
        {
            InternalNatives._ForceCinematicSubtitles(flag);
        }
        
        //native GetCameraMargin takes integer whichMargin returns real
        public delegate JassRealRet GetCameraMarginPrototype(JassInteger whichMargin);
        private static GetCameraMarginPrototype _GetCameraMargin;
        public static Single GetCameraMargin(JassInteger whichMargin)
        {
            return InternalNatives._GetCameraMargin(whichMargin);
        }
        
        //native GetCameraBoundMinX takes nothing returns real
        public delegate JassRealRet GetCameraBoundMinXPrototype();
        private static GetCameraBoundMinXPrototype _GetCameraBoundMinX;
        public static Single GetCameraBoundMinX()
        {
            return InternalNatives._GetCameraBoundMinX();
        }
        
        //native GetCameraBoundMinY takes nothing returns real
        public delegate JassRealRet GetCameraBoundMinYPrototype();
        private static GetCameraBoundMinYPrototype _GetCameraBoundMinY;
        public static Single GetCameraBoundMinY()
        {
            return InternalNatives._GetCameraBoundMinY();
        }
        
        //native GetCameraBoundMaxX takes nothing returns real
        public delegate JassRealRet GetCameraBoundMaxXPrototype();
        private static GetCameraBoundMaxXPrototype _GetCameraBoundMaxX;
        public static Single GetCameraBoundMaxX()
        {
            return InternalNatives._GetCameraBoundMaxX();
        }
        
        //native GetCameraBoundMaxY takes nothing returns real
        public delegate JassRealRet GetCameraBoundMaxYPrototype();
        private static GetCameraBoundMaxYPrototype _GetCameraBoundMaxY;
        public static Single GetCameraBoundMaxY()
        {
            return InternalNatives._GetCameraBoundMaxY();
        }
        
        //native GetCameraField takes camerafield whichField returns real
        public delegate JassRealRet GetCameraFieldPrototype(JassCameraField whichField);
        private static GetCameraFieldPrototype _GetCameraField;
        public static Single GetCameraField(JassCameraField whichField)
        {
            return InternalNatives._GetCameraField(whichField);
        }
        
        //native GetCameraTargetPositionX takes nothing returns real
        public delegate JassRealRet GetCameraTargetPositionXPrototype();
        private static GetCameraTargetPositionXPrototype _GetCameraTargetPositionX;
        public static Single GetCameraTargetPositionX()
        {
            return InternalNatives._GetCameraTargetPositionX();
        }
        
        //native GetCameraTargetPositionY takes nothing returns real
        public delegate JassRealRet GetCameraTargetPositionYPrototype();
        private static GetCameraTargetPositionYPrototype _GetCameraTargetPositionY;
        public static Single GetCameraTargetPositionY()
        {
            return InternalNatives._GetCameraTargetPositionY();
        }
        
        //native GetCameraTargetPositionZ takes nothing returns real
        public delegate JassRealRet GetCameraTargetPositionZPrototype();
        private static GetCameraTargetPositionZPrototype _GetCameraTargetPositionZ;
        public static Single GetCameraTargetPositionZ()
        {
            return InternalNatives._GetCameraTargetPositionZ();
        }
        
        //native GetCameraTargetPositionLoc takes nothing returns location
        public delegate JassLocation GetCameraTargetPositionLocPrototype();
        private static GetCameraTargetPositionLocPrototype _GetCameraTargetPositionLoc;
        public static JassLocation GetCameraTargetPositionLoc()
        {
            return InternalNatives._GetCameraTargetPositionLoc();
        }
        
        //native GetCameraEyePositionX takes nothing returns real
        public delegate JassRealRet GetCameraEyePositionXPrototype();
        private static GetCameraEyePositionXPrototype _GetCameraEyePositionX;
        public static Single GetCameraEyePositionX()
        {
            return InternalNatives._GetCameraEyePositionX();
        }
        
        //native GetCameraEyePositionY takes nothing returns real
        public delegate JassRealRet GetCameraEyePositionYPrototype();
        private static GetCameraEyePositionYPrototype _GetCameraEyePositionY;
        public static Single GetCameraEyePositionY()
        {
            return InternalNatives._GetCameraEyePositionY();
        }
        
        //native GetCameraEyePositionZ takes nothing returns real
        public delegate JassRealRet GetCameraEyePositionZPrototype();
        private static GetCameraEyePositionZPrototype _GetCameraEyePositionZ;
        public static Single GetCameraEyePositionZ()
        {
            return InternalNatives._GetCameraEyePositionZ();
        }
        
        //native GetCameraEyePositionLoc takes nothing returns location
        public delegate JassLocation GetCameraEyePositionLocPrototype();
        private static GetCameraEyePositionLocPrototype _GetCameraEyePositionLoc;
        public static JassLocation GetCameraEyePositionLoc()
        {
            return InternalNatives._GetCameraEyePositionLoc();
        }
        
        //native NewSoundEnvironment takes string environmentName returns nothing
        public delegate void NewSoundEnvironmentPrototype(String environmentName);
        private static NewSoundEnvironmentPrototype _NewSoundEnvironment;
        public static void NewSoundEnvironment(String environmentName)
        {
            InternalNatives._NewSoundEnvironment(environmentName);
        }
        
        //native CreateSound takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string eaxSetting returns sound
        public delegate JassSound CreateSoundPrototype(String fileName, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String eaxSetting);
        private static CreateSoundPrototype _CreateSound;
        public static JassSound CreateSound(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String eaxSetting)
        {
            return InternalNatives._CreateSound(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, eaxSetting);
        }
        
        //native CreateSoundFilenameWithLabel takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string SLKEntryName returns sound
        public delegate JassSound CreateSoundFilenameWithLabelPrototype(String fileName, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String SLKEntryName);
        private static CreateSoundFilenameWithLabelPrototype _CreateSoundFilenameWithLabel;
        public static JassSound CreateSoundFilenameWithLabel(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String SLKEntryName)
        {
            return InternalNatives._CreateSoundFilenameWithLabel(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, SLKEntryName);
        }
        
        //native CreateSoundFromLabel takes string soundLabel, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate returns sound
        public delegate JassSound CreateSoundFromLabelPrototype(String soundLabel, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate);
        private static CreateSoundFromLabelPrototype _CreateSoundFromLabel;
        public static JassSound CreateSoundFromLabel(String soundLabel, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return InternalNatives._CreateSoundFromLabel(soundLabel, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate);
        }
        
        //native CreateMIDISound takes string soundLabel, integer fadeInRate, integer fadeOutRate returns sound
        public delegate JassSound CreateMIDISoundPrototype(String soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate);
        private static CreateMIDISoundPrototype _CreateMIDISound;
        public static JassSound CreateMIDISound(String soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return InternalNatives._CreateMIDISound(soundLabel, fadeInRate, fadeOutRate);
        }
        
        //native SetSoundParamsFromLabel takes sound soundHandle, string soundLabel returns nothing
        public delegate void SetSoundParamsFromLabelPrototype(JassSound soundHandle, String soundLabel);
        private static SetSoundParamsFromLabelPrototype _SetSoundParamsFromLabel;
        public static void SetSoundParamsFromLabel(JassSound soundHandle, String soundLabel)
        {
            InternalNatives._SetSoundParamsFromLabel(soundHandle, soundLabel);
        }
        
        //native SetSoundDistanceCutoff takes sound soundHandle, real cutoff returns nothing
        public delegate void SetSoundDistanceCutoffPrototype(JassSound soundHandle, JassRealArg cutoff);
        private static SetSoundDistanceCutoffPrototype _SetSoundDistanceCutoff;
        public static void SetSoundDistanceCutoff(JassSound soundHandle, Single cutoff)
        {
            InternalNatives._SetSoundDistanceCutoff(soundHandle, cutoff);
        }
        
        //native SetSoundChannel takes sound soundHandle, integer channel returns nothing
        public delegate void SetSoundChannelPrototype(JassSound soundHandle, JassInteger channel);
        private static SetSoundChannelPrototype _SetSoundChannel;
        public static void SetSoundChannel(JassSound soundHandle, JassInteger channel)
        {
            InternalNatives._SetSoundChannel(soundHandle, channel);
        }
        
        //native SetSoundVolume takes sound soundHandle, integer volume returns nothing
        public delegate void SetSoundVolumePrototype(JassSound soundHandle, JassInteger volume);
        private static SetSoundVolumePrototype _SetSoundVolume;
        public static void SetSoundVolume(JassSound soundHandle, JassInteger volume)
        {
            InternalNatives._SetSoundVolume(soundHandle, volume);
        }
        
        //native SetSoundPitch takes sound soundHandle, real pitch returns nothing
        public delegate void SetSoundPitchPrototype(JassSound soundHandle, JassRealArg pitch);
        private static SetSoundPitchPrototype _SetSoundPitch;
        public static void SetSoundPitch(JassSound soundHandle, Single pitch)
        {
            InternalNatives._SetSoundPitch(soundHandle, pitch);
        }
        
        //native SetSoundPlayPosition takes sound soundHandle, integer millisecs returns nothing
        public delegate void SetSoundPlayPositionPrototype(JassSound soundHandle, JassInteger millisecs);
        private static SetSoundPlayPositionPrototype _SetSoundPlayPosition;
        public static void SetSoundPlayPosition(JassSound soundHandle, JassInteger millisecs)
        {
            InternalNatives._SetSoundPlayPosition(soundHandle, millisecs);
        }
        
        //native SetSoundDistances takes sound soundHandle, real minDist, real maxDist returns nothing
        public delegate void SetSoundDistancesPrototype(JassSound soundHandle, JassRealArg minDist, JassRealArg maxDist);
        private static SetSoundDistancesPrototype _SetSoundDistances;
        public static void SetSoundDistances(JassSound soundHandle, Single minDist, Single maxDist)
        {
            InternalNatives._SetSoundDistances(soundHandle, minDist, maxDist);
        }
        
        //native SetSoundConeAngles takes sound soundHandle, real inside, real outside, integer outsideVolume returns nothing
        public delegate void SetSoundConeAnglesPrototype(JassSound soundHandle, JassRealArg inside, JassRealArg outside, JassInteger outsideVolume);
        private static SetSoundConeAnglesPrototype _SetSoundConeAngles;
        public static void SetSoundConeAngles(JassSound soundHandle, Single inside, Single outside, JassInteger outsideVolume)
        {
            InternalNatives._SetSoundConeAngles(soundHandle, inside, outside, outsideVolume);
        }
        
        //native SetSoundConeOrientation takes sound soundHandle, real x, real y, real z returns nothing
        public delegate void SetSoundConeOrientationPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private static SetSoundConeOrientationPrototype _SetSoundConeOrientation;
        public static void SetSoundConeOrientation(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives._SetSoundConeOrientation(soundHandle, x, y, z);
        }
        
        //native SetSoundPosition takes sound soundHandle, real x, real y, real z returns nothing
        public delegate void SetSoundPositionPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private static SetSoundPositionPrototype _SetSoundPosition;
        public static void SetSoundPosition(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives._SetSoundPosition(soundHandle, x, y, z);
        }
        
        //native SetSoundVelocity takes sound soundHandle, real x, real y, real z returns nothing
        public delegate void SetSoundVelocityPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private static SetSoundVelocityPrototype _SetSoundVelocity;
        public static void SetSoundVelocity(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives._SetSoundVelocity(soundHandle, x, y, z);
        }
        
        //native AttachSoundToUnit takes sound soundHandle, unit whichUnit returns nothing
        public delegate void AttachSoundToUnitPrototype(JassSound soundHandle, JassUnit whichUnit);
        private static AttachSoundToUnitPrototype _AttachSoundToUnit;
        public static void AttachSoundToUnit(JassSound soundHandle, JassUnit whichUnit)
        {
            InternalNatives._AttachSoundToUnit(soundHandle, whichUnit);
        }
        
        //native StartSound takes sound soundHandle returns nothing
        public delegate void StartSoundPrototype(JassSound soundHandle);
        private static StartSoundPrototype _StartSound;
        public static void StartSound(JassSound soundHandle)
        {
            InternalNatives._StartSound(soundHandle);
        }
        
        //native StopSound takes sound soundHandle, boolean killWhenDone, boolean fadeOut returns nothing
        public delegate void StopSoundPrototype(JassSound soundHandle, JassBoolean killWhenDone, JassBoolean fadeOut);
        private static StopSoundPrototype _StopSound;
        public static void StopSound(JassSound soundHandle, Boolean killWhenDone, Boolean fadeOut)
        {
            InternalNatives._StopSound(soundHandle, killWhenDone, fadeOut);
        }
        
        //native KillSoundWhenDone takes sound soundHandle returns nothing
        public delegate void KillSoundWhenDonePrototype(JassSound soundHandle);
        private static KillSoundWhenDonePrototype _KillSoundWhenDone;
        public static void KillSoundWhenDone(JassSound soundHandle)
        {
            InternalNatives._KillSoundWhenDone(soundHandle);
        }
        
        //native SetMapMusic takes string musicName, boolean random, integer index returns nothing
        public delegate void SetMapMusicPrototype(String musicName, JassBoolean random, JassInteger index);
        private static SetMapMusicPrototype _SetMapMusic;
        public static void SetMapMusic(String musicName, Boolean random, JassInteger index)
        {
            InternalNatives._SetMapMusic(musicName, random, index);
        }
        
        //native ClearMapMusic takes nothing returns nothing
        public delegate void ClearMapMusicPrototype();
        private static ClearMapMusicPrototype _ClearMapMusic;
        public static void ClearMapMusic()
        {
            InternalNatives._ClearMapMusic();
        }
        
        //native PlayMusic takes string musicName returns nothing
        public delegate void PlayMusicPrototype(String musicName);
        private static PlayMusicPrototype _PlayMusic;
        public static void PlayMusic(String musicName)
        {
            InternalNatives._PlayMusic(musicName);
        }
        
        //native PlayMusicEx takes string musicName, integer frommsecs, integer fadeinmsecs returns nothing
        public delegate void PlayMusicExPrototype(String musicName, JassInteger frommsecs, JassInteger fadeinmsecs);
        private static PlayMusicExPrototype _PlayMusicEx;
        public static void PlayMusicEx(String musicName, JassInteger frommsecs, JassInteger fadeinmsecs)
        {
            InternalNatives._PlayMusicEx(musicName, frommsecs, fadeinmsecs);
        }
        
        //native StopMusic takes boolean fadeOut returns nothing
        public delegate void StopMusicPrototype(JassBoolean fadeOut);
        private static StopMusicPrototype _StopMusic;
        public static void StopMusic(Boolean fadeOut)
        {
            InternalNatives._StopMusic(fadeOut);
        }
        
        //native ResumeMusic takes nothing returns nothing
        public delegate void ResumeMusicPrototype();
        private static ResumeMusicPrototype _ResumeMusic;
        public static void ResumeMusic()
        {
            InternalNatives._ResumeMusic();
        }
        
        //native PlayThematicMusic takes string musicFileName returns nothing
        public delegate void PlayThematicMusicPrototype(String musicFileName);
        private static PlayThematicMusicPrototype _PlayThematicMusic;
        public static void PlayThematicMusic(String musicFileName)
        {
            InternalNatives._PlayThematicMusic(musicFileName);
        }
        
        //native PlayThematicMusicEx takes string musicFileName, integer frommsecs returns nothing
        public delegate void PlayThematicMusicExPrototype(String musicFileName, JassInteger frommsecs);
        private static PlayThematicMusicExPrototype _PlayThematicMusicEx;
        public static void PlayThematicMusicEx(String musicFileName, JassInteger frommsecs)
        {
            InternalNatives._PlayThematicMusicEx(musicFileName, frommsecs);
        }
        
        //native EndThematicMusic takes nothing returns nothing
        public delegate void EndThematicMusicPrototype();
        private static EndThematicMusicPrototype _EndThematicMusic;
        public static void EndThematicMusic()
        {
            InternalNatives._EndThematicMusic();
        }
        
        //native SetMusicVolume takes integer volume returns nothing
        public delegate void SetMusicVolumePrototype(JassInteger volume);
        private static SetMusicVolumePrototype _SetMusicVolume;
        public static void SetMusicVolume(JassInteger volume)
        {
            InternalNatives._SetMusicVolume(volume);
        }
        
        //native SetMusicPlayPosition takes integer millisecs returns nothing
        public delegate void SetMusicPlayPositionPrototype(JassInteger millisecs);
        private static SetMusicPlayPositionPrototype _SetMusicPlayPosition;
        public static void SetMusicPlayPosition(JassInteger millisecs)
        {
            InternalNatives._SetMusicPlayPosition(millisecs);
        }
        
        //native SetThematicMusicPlayPosition takes integer millisecs returns nothing
        public delegate void SetThematicMusicPlayPositionPrototype(JassInteger millisecs);
        private static SetThematicMusicPlayPositionPrototype _SetThematicMusicPlayPosition;
        public static void SetThematicMusicPlayPosition(JassInteger millisecs)
        {
            InternalNatives._SetThematicMusicPlayPosition(millisecs);
        }
        
        //native SetSoundDuration takes sound soundHandle, integer duration returns nothing
        public delegate void SetSoundDurationPrototype(JassSound soundHandle, JassInteger duration);
        private static SetSoundDurationPrototype _SetSoundDuration;
        public static void SetSoundDuration(JassSound soundHandle, JassInteger duration)
        {
            InternalNatives._SetSoundDuration(soundHandle, duration);
        }
        
        //native GetSoundDuration takes sound soundHandle returns integer
        public delegate JassInteger GetSoundDurationPrototype(JassSound soundHandle);
        private static GetSoundDurationPrototype _GetSoundDuration;
        public static JassInteger GetSoundDuration(JassSound soundHandle)
        {
            return InternalNatives._GetSoundDuration(soundHandle);
        }
        
        //native GetSoundFileDuration takes string musicFileName returns integer
        public delegate JassInteger GetSoundFileDurationPrototype(String musicFileName);
        private static GetSoundFileDurationPrototype _GetSoundFileDuration;
        public static JassInteger GetSoundFileDuration(String musicFileName)
        {
            return InternalNatives._GetSoundFileDuration(musicFileName);
        }
        
        //native VolumeGroupSetVolume takes volumegroup vgroup, real scale returns nothing
        public delegate void VolumeGroupSetVolumePrototype(JassVolumeGroup vgroup, JassRealArg scale);
        private static VolumeGroupSetVolumePrototype _VolumeGroupSetVolume;
        public static void VolumeGroupSetVolume(JassVolumeGroup vgroup, Single scale)
        {
            InternalNatives._VolumeGroupSetVolume(vgroup, scale);
        }
        
        //native VolumeGroupReset takes nothing returns nothing
        public delegate void VolumeGroupResetPrototype();
        private static VolumeGroupResetPrototype _VolumeGroupReset;
        public static void VolumeGroupReset()
        {
            InternalNatives._VolumeGroupReset();
        }
        
        //native GetSoundIsPlaying takes sound soundHandle returns boolean
        public delegate JassBoolean GetSoundIsPlayingPrototype(JassSound soundHandle);
        private static GetSoundIsPlayingPrototype _GetSoundIsPlaying;
        public static Boolean GetSoundIsPlaying(JassSound soundHandle)
        {
            return InternalNatives._GetSoundIsPlaying(soundHandle);
        }
        
        //native GetSoundIsLoading takes sound soundHandle returns boolean
        public delegate JassBoolean GetSoundIsLoadingPrototype(JassSound soundHandle);
        private static GetSoundIsLoadingPrototype _GetSoundIsLoading;
        public static Boolean GetSoundIsLoading(JassSound soundHandle)
        {
            return InternalNatives._GetSoundIsLoading(soundHandle);
        }
        
        //native RegisterStackedSound takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
        public delegate void RegisterStackedSoundPrototype(JassSound soundHandle, JassBoolean byPosition, JassRealArg rectwidth, JassRealArg rectheight);
        private static RegisterStackedSoundPrototype _RegisterStackedSound;
        public static void RegisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            InternalNatives._RegisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        //native UnregisterStackedSound takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
        public delegate void UnregisterStackedSoundPrototype(JassSound soundHandle, JassBoolean byPosition, JassRealArg rectwidth, JassRealArg rectheight);
        private static UnregisterStackedSoundPrototype _UnregisterStackedSound;
        public static void UnregisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            InternalNatives._UnregisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        //native AddWeatherEffect takes rect where, integer effectID returns weathereffect
        public delegate JassWeatherEffect AddWeatherEffectPrototype(JassRect where, JassInteger effectID);
        private static AddWeatherEffectPrototype _AddWeatherEffect;
        public static JassWeatherEffect AddWeatherEffect(JassRect where, JassInteger effectID)
        {
            return InternalNatives._AddWeatherEffect(where, effectID);
        }
        
        //native RemoveWeatherEffect takes weathereffect whichEffect returns nothing
        public delegate void RemoveWeatherEffectPrototype(JassWeatherEffect whichEffect);
        private static RemoveWeatherEffectPrototype _RemoveWeatherEffect;
        public static void RemoveWeatherEffect(JassWeatherEffect whichEffect)
        {
            InternalNatives._RemoveWeatherEffect(whichEffect);
        }
        
        //native EnableWeatherEffect takes weathereffect whichEffect, boolean enable returns nothing
        public delegate void EnableWeatherEffectPrototype(JassWeatherEffect whichEffect, JassBoolean enable);
        private static EnableWeatherEffectPrototype _EnableWeatherEffect;
        public static void EnableWeatherEffect(JassWeatherEffect whichEffect, Boolean enable)
        {
            InternalNatives._EnableWeatherEffect(whichEffect, enable);
        }
        
        //native TerrainDeformCrater takes real x, real y, real radius, real depth, integer duration, boolean permanent returns terraindeformation
        public delegate JassTerrainDeformation TerrainDeformCraterPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg depth, JassInteger duration, JassBoolean permanent);
        private static TerrainDeformCraterPrototype _TerrainDeformCrater;
        public static JassTerrainDeformation TerrainDeformCrater(Single x, Single y, Single radius, Single depth, JassInteger duration, Boolean permanent)
        {
            return InternalNatives._TerrainDeformCrater(x, y, radius, depth, duration, permanent);
        }
        
        //native TerrainDeformRipple takes real x, real y, real radius, real depth, integer duration, integer count, real spaceWaves, real timeWaves, real radiusStartPct, boolean limitNeg returns terraindeformation
        public delegate JassTerrainDeformation TerrainDeformRipplePrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg depth, JassInteger duration, JassInteger count, JassRealArg spaceWaves, JassRealArg timeWaves, JassRealArg radiusStartPct, JassBoolean limitNeg);
        private static TerrainDeformRipplePrototype _TerrainDeformRipple;
        public static JassTerrainDeformation TerrainDeformRipple(Single x, Single y, Single radius, Single depth, JassInteger duration, JassInteger count, Single spaceWaves, Single timeWaves, Single radiusStartPct, Boolean limitNeg)
        {
            return InternalNatives._TerrainDeformRipple(x, y, radius, depth, duration, count, spaceWaves, timeWaves, radiusStartPct, limitNeg);
        }
        
        //native TerrainDeformWave takes real x, real y, real dirX, real dirY, real distance, real speed, real radius, real depth, integer trailTime, integer count returns terraindeformation
        public delegate JassTerrainDeformation TerrainDeformWavePrototype(JassRealArg x, JassRealArg y, JassRealArg dirX, JassRealArg dirY, JassRealArg distance, JassRealArg speed, JassRealArg radius, JassRealArg depth, JassInteger trailTime, JassInteger count);
        private static TerrainDeformWavePrototype _TerrainDeformWave;
        public static JassTerrainDeformation TerrainDeformWave(Single x, Single y, Single dirX, Single dirY, Single distance, Single speed, Single radius, Single depth, JassInteger trailTime, JassInteger count)
        {
            return InternalNatives._TerrainDeformWave(x, y, dirX, dirY, distance, speed, radius, depth, trailTime, count);
        }
        
        //native TerrainDeformRandom takes real x, real y, real radius, real minDelta, real maxDelta, integer duration, integer updateInterval returns terraindeformation
        public delegate JassTerrainDeformation TerrainDeformRandomPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg minDelta, JassRealArg maxDelta, JassInteger duration, JassInteger updateInterval);
        private static TerrainDeformRandomPrototype _TerrainDeformRandom;
        public static JassTerrainDeformation TerrainDeformRandom(Single x, Single y, Single radius, Single minDelta, Single maxDelta, JassInteger duration, JassInteger updateInterval)
        {
            return InternalNatives._TerrainDeformRandom(x, y, radius, minDelta, maxDelta, duration, updateInterval);
        }
        
        //native TerrainDeformStop takes terraindeformation deformation, integer duration returns nothing
        public delegate void TerrainDeformStopPrototype(JassTerrainDeformation deformation, JassInteger duration);
        private static TerrainDeformStopPrototype _TerrainDeformStop;
        public static void TerrainDeformStop(JassTerrainDeformation deformation, JassInteger duration)
        {
            InternalNatives._TerrainDeformStop(deformation, duration);
        }
        
        //native TerrainDeformStopAll takes nothing returns nothing
        public delegate void TerrainDeformStopAllPrototype();
        private static TerrainDeformStopAllPrototype _TerrainDeformStopAll;
        public static void TerrainDeformStopAll()
        {
            InternalNatives._TerrainDeformStopAll();
        }
        
        //native AddSpecialEffect takes string modelName, real x, real y returns effect
        public delegate JassEffect AddSpecialEffectPrototype(String modelName, JassRealArg x, JassRealArg y);
        private static AddSpecialEffectPrototype _AddSpecialEffect;
        public static JassEffect AddSpecialEffect(String modelName, Single x, Single y)
        {
            return InternalNatives._AddSpecialEffect(modelName, x, y);
        }
        
        //native AddSpecialEffectLoc takes string modelName, location where returns effect
        public delegate JassEffect AddSpecialEffectLocPrototype(String modelName, JassLocation where);
        private static AddSpecialEffectLocPrototype _AddSpecialEffectLoc;
        public static JassEffect AddSpecialEffectLoc(String modelName, JassLocation where)
        {
            return InternalNatives._AddSpecialEffectLoc(modelName, where);
        }
        
        //native AddSpecialEffectTarget takes string modelName, widget targetWidget, string attachPointName returns effect
        public delegate JassEffect AddSpecialEffectTargetPrototype(String modelName, JassWidget targetWidget, String attachPointName);
        private static AddSpecialEffectTargetPrototype _AddSpecialEffectTarget;
        public static JassEffect AddSpecialEffectTarget(String modelName, JassWidget targetWidget, String attachPointName)
        {
            return InternalNatives._AddSpecialEffectTarget(modelName, targetWidget, attachPointName);
        }
        
        //native DestroyEffect takes effect whichEffect returns nothing
        public delegate void DestroyEffectPrototype(JassEffect whichEffect);
        private static DestroyEffectPrototype _DestroyEffect;
        public static void DestroyEffect(JassEffect whichEffect)
        {
            InternalNatives._DestroyEffect(whichEffect);
        }
        
        //native AddSpellEffect takes string abilityString, effecttype t, real x, real y returns effect
        public delegate JassEffect AddSpellEffectPrototype(String abilityString, JassEffectType t, JassRealArg x, JassRealArg y);
        private static AddSpellEffectPrototype _AddSpellEffect;
        public static JassEffect AddSpellEffect(String abilityString, JassEffectType t, Single x, Single y)
        {
            return InternalNatives._AddSpellEffect(abilityString, t, x, y);
        }
        
        //native AddSpellEffectLoc takes string abilityString, effecttype t, location where returns effect
        public delegate JassEffect AddSpellEffectLocPrototype(String abilityString, JassEffectType t, JassLocation where);
        private static AddSpellEffectLocPrototype _AddSpellEffectLoc;
        public static JassEffect AddSpellEffectLoc(String abilityString, JassEffectType t, JassLocation where)
        {
            return InternalNatives._AddSpellEffectLoc(abilityString, t, where);
        }
        
        //native AddSpellEffectById takes integer abilityId, effecttype t, real x, real y returns effect
        public delegate JassEffect AddSpellEffectByIdPrototype(JassInteger abilityId, JassEffectType t, JassRealArg x, JassRealArg y);
        private static AddSpellEffectByIdPrototype _AddSpellEffectById;
        public static JassEffect AddSpellEffectById(JassInteger abilityId, JassEffectType t, Single x, Single y)
        {
            return InternalNatives._AddSpellEffectById(abilityId, t, x, y);
        }
        
        //native AddSpellEffectByIdLoc takes integer abilityId, effecttype t, location where returns effect
        public delegate JassEffect AddSpellEffectByIdLocPrototype(JassInteger abilityId, JassEffectType t, JassLocation where);
        private static AddSpellEffectByIdLocPrototype _AddSpellEffectByIdLoc;
        public static JassEffect AddSpellEffectByIdLoc(JassInteger abilityId, JassEffectType t, JassLocation where)
        {
            return InternalNatives._AddSpellEffectByIdLoc(abilityId, t, where);
        }
        
        //native AddSpellEffectTarget takes string modelName, effecttype t, widget targetWidget, string attachPoint returns effect
        public delegate JassEffect AddSpellEffectTargetPrototype(String modelName, JassEffectType t, JassWidget targetWidget, String attachPoint);
        private static AddSpellEffectTargetPrototype _AddSpellEffectTarget;
        public static JassEffect AddSpellEffectTarget(String modelName, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return InternalNatives._AddSpellEffectTarget(modelName, t, targetWidget, attachPoint);
        }
        
        //native AddSpellEffectTargetById takes integer abilityId, effecttype t, widget targetWidget, string attachPoint returns effect
        public delegate JassEffect AddSpellEffectTargetByIdPrototype(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, String attachPoint);
        private static AddSpellEffectTargetByIdPrototype _AddSpellEffectTargetById;
        public static JassEffect AddSpellEffectTargetById(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return InternalNatives._AddSpellEffectTargetById(abilityId, t, targetWidget, attachPoint);
        }
        
        //native AddLightning takes string codeName, boolean checkVisibility, real x1, real y1, real x2, real y2 returns lightning
        public delegate JassLightning AddLightningPrototype(String codeName, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2);
        private static AddLightningPrototype _AddLightning;
        public static JassLightning AddLightning(String codeName, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return InternalNatives._AddLightning(codeName, checkVisibility, x1, y1, x2, y2);
        }
        
        //native AddLightningEx takes string codeName, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns lightning
        public delegate JassLightning AddLightningExPrototype(String codeName, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg z1, JassRealArg x2, JassRealArg y2, JassRealArg z2);
        private static AddLightningExPrototype _AddLightningEx;
        public static JassLightning AddLightningEx(String codeName, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return InternalNatives._AddLightningEx(codeName, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        //native DestroyLightning takes lightning whichBolt returns boolean
        public delegate JassBoolean DestroyLightningPrototype(JassLightning whichBolt);
        private static DestroyLightningPrototype _DestroyLightning;
        public static Boolean DestroyLightning(JassLightning whichBolt)
        {
            return InternalNatives._DestroyLightning(whichBolt);
        }
        
        //native MoveLightning takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real x2, real y2 returns boolean
        public delegate JassBoolean MoveLightningPrototype(JassLightning whichBolt, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2);
        private static MoveLightningPrototype _MoveLightning;
        public static Boolean MoveLightning(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return InternalNatives._MoveLightning(whichBolt, checkVisibility, x1, y1, x2, y2);
        }
        
        //native MoveLightningEx takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns boolean
        public delegate JassBoolean MoveLightningExPrototype(JassLightning whichBolt, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg z1, JassRealArg x2, JassRealArg y2, JassRealArg z2);
        private static MoveLightningExPrototype _MoveLightningEx;
        public static Boolean MoveLightningEx(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return InternalNatives._MoveLightningEx(whichBolt, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        //native GetLightningColorA takes lightning whichBolt returns real
        public delegate JassRealRet GetLightningColorAPrototype(JassLightning whichBolt);
        private static GetLightningColorAPrototype _GetLightningColorA;
        public static Single GetLightningColorA(JassLightning whichBolt)
        {
            return InternalNatives._GetLightningColorA(whichBolt);
        }
        
        //native GetLightningColorR takes lightning whichBolt returns real
        public delegate JassRealRet GetLightningColorRPrototype(JassLightning whichBolt);
        private static GetLightningColorRPrototype _GetLightningColorR;
        public static Single GetLightningColorR(JassLightning whichBolt)
        {
            return InternalNatives._GetLightningColorR(whichBolt);
        }
        
        //native GetLightningColorG takes lightning whichBolt returns real
        public delegate JassRealRet GetLightningColorGPrototype(JassLightning whichBolt);
        private static GetLightningColorGPrototype _GetLightningColorG;
        public static Single GetLightningColorG(JassLightning whichBolt)
        {
            return InternalNatives._GetLightningColorG(whichBolt);
        }
        
        //native GetLightningColorB takes lightning whichBolt returns real
        public delegate JassRealRet GetLightningColorBPrototype(JassLightning whichBolt);
        private static GetLightningColorBPrototype _GetLightningColorB;
        public static Single GetLightningColorB(JassLightning whichBolt)
        {
            return InternalNatives._GetLightningColorB(whichBolt);
        }
        
        //native SetLightningColor takes lightning whichBolt, real r, real g, real b, real a returns boolean
        public delegate JassBoolean SetLightningColorPrototype(JassLightning whichBolt, JassRealArg r, JassRealArg g, JassRealArg b, JassRealArg a);
        private static SetLightningColorPrototype _SetLightningColor;
        public static Boolean SetLightningColor(JassLightning whichBolt, Single r, Single g, Single b, Single a)
        {
            return InternalNatives._SetLightningColor(whichBolt, r, g, b, a);
        }
        
        //native GetAbilityEffect takes string abilityString, effecttype t, integer index returns string
        public delegate String GetAbilityEffectPrototype(String abilityString, JassEffectType t, JassInteger index);
        private static GetAbilityEffectPrototype _GetAbilityEffect;
        public static String GetAbilityEffect(String abilityString, JassEffectType t, JassInteger index)
        {
            return InternalNatives._GetAbilityEffect(abilityString, t, index);
        }
        
        //native GetAbilityEffectById takes integer abilityId, effecttype t, integer index returns string
        public delegate String GetAbilityEffectByIdPrototype(JassInteger abilityId, JassEffectType t, JassInteger index);
        private static GetAbilityEffectByIdPrototype _GetAbilityEffectById;
        public static String GetAbilityEffectById(JassInteger abilityId, JassEffectType t, JassInteger index)
        {
            return InternalNatives._GetAbilityEffectById(abilityId, t, index);
        }
        
        //native GetAbilitySound takes string abilityString, soundtype t returns string
        public delegate String GetAbilitySoundPrototype(String abilityString, JassSoundType t);
        private static GetAbilitySoundPrototype _GetAbilitySound;
        public static String GetAbilitySound(String abilityString, JassSoundType t)
        {
            return InternalNatives._GetAbilitySound(abilityString, t);
        }
        
        //native GetAbilitySoundById takes integer abilityId, soundtype t returns string
        public delegate String GetAbilitySoundByIdPrototype(JassInteger abilityId, JassSoundType t);
        private static GetAbilitySoundByIdPrototype _GetAbilitySoundById;
        public static String GetAbilitySoundById(JassInteger abilityId, JassSoundType t)
        {
            return InternalNatives._GetAbilitySoundById(abilityId, t);
        }
        
        //native GetTerrainCliffLevel takes real x, real y returns integer
        public delegate JassInteger GetTerrainCliffLevelPrototype(JassRealArg x, JassRealArg y);
        private static GetTerrainCliffLevelPrototype _GetTerrainCliffLevel;
        public static JassInteger GetTerrainCliffLevel(Single x, Single y)
        {
            return InternalNatives._GetTerrainCliffLevel(x, y);
        }
        
        //native SetWaterBaseColor takes integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetWaterBaseColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetWaterBaseColorPrototype _SetWaterBaseColor;
        public static void SetWaterBaseColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._SetWaterBaseColor(red, green, blue, alpha);
        }
        
        //native SetWaterDeforms takes boolean val returns nothing
        public delegate void SetWaterDeformsPrototype(JassBoolean val);
        private static SetWaterDeformsPrototype _SetWaterDeforms;
        public static void SetWaterDeforms(Boolean val)
        {
            InternalNatives._SetWaterDeforms(val);
        }
        
        //native GetTerrainType takes real x, real y returns integer
        public delegate JassInteger GetTerrainTypePrototype(JassRealArg x, JassRealArg y);
        private static GetTerrainTypePrototype _GetTerrainType;
        public static JassInteger GetTerrainType(Single x, Single y)
        {
            return InternalNatives._GetTerrainType(x, y);
        }
        
        //native GetTerrainVariance takes real x, real y returns integer
        public delegate JassInteger GetTerrainVariancePrototype(JassRealArg x, JassRealArg y);
        private static GetTerrainVariancePrototype _GetTerrainVariance;
        public static JassInteger GetTerrainVariance(Single x, Single y)
        {
            return InternalNatives._GetTerrainVariance(x, y);
        }
        
        //native SetTerrainType takes real x, real y, integer terrainType, integer variation, integer area, integer shape returns nothing
        public delegate void SetTerrainTypePrototype(JassRealArg x, JassRealArg y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape);
        private static SetTerrainTypePrototype _SetTerrainType;
        public static void SetTerrainType(Single x, Single y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape)
        {
            InternalNatives._SetTerrainType(x, y, terrainType, variation, area, shape);
        }
        
        //native IsTerrainPathable takes real x, real y, pathingtype t returns boolean
        public delegate JassBoolean IsTerrainPathablePrototype(JassRealArg x, JassRealArg y, JassPathingType t);
        private static IsTerrainPathablePrototype _IsTerrainPathable;
        public static Boolean IsTerrainPathable(Single x, Single y, JassPathingType t)
        {
            return InternalNatives._IsTerrainPathable(x, y, t);
        }
        
        //native SetTerrainPathable takes real x, real y, pathingtype t, boolean flag returns nothing
        public delegate void SetTerrainPathablePrototype(JassRealArg x, JassRealArg y, JassPathingType t, JassBoolean flag);
        private static SetTerrainPathablePrototype _SetTerrainPathable;
        public static void SetTerrainPathable(Single x, Single y, JassPathingType t, Boolean flag)
        {
            InternalNatives._SetTerrainPathable(x, y, t, flag);
        }
        
        //native CreateImage takes string file, real sizeX, real sizeY, real sizeZ, real posX, real posY, real posZ, real originX, real originY, real originZ, integer imageType returns image
        public delegate JassImage CreateImagePrototype(String file, JassRealArg sizeX, JassRealArg sizeY, JassRealArg sizeZ, JassRealArg posX, JassRealArg posY, JassRealArg posZ, JassRealArg originX, JassRealArg originY, JassRealArg originZ, JassInteger imageType);
        private static CreateImagePrototype _CreateImage;
        public static JassImage CreateImage(String file, Single sizeX, Single sizeY, Single sizeZ, Single posX, Single posY, Single posZ, Single originX, Single originY, Single originZ, JassInteger imageType)
        {
            return InternalNatives._CreateImage(file, sizeX, sizeY, sizeZ, posX, posY, posZ, originX, originY, originZ, imageType);
        }
        
        //native DestroyImage takes image whichImage returns nothing
        public delegate void DestroyImagePrototype(JassImage whichImage);
        private static DestroyImagePrototype _DestroyImage;
        public static void DestroyImage(JassImage whichImage)
        {
            InternalNatives._DestroyImage(whichImage);
        }
        
        //native ShowImage takes image whichImage, boolean flag returns nothing
        public delegate void ShowImagePrototype(JassImage whichImage, JassBoolean flag);
        private static ShowImagePrototype _ShowImage;
        public static void ShowImage(JassImage whichImage, Boolean flag)
        {
            InternalNatives._ShowImage(whichImage, flag);
        }
        
        //native SetImageConstantHeight takes image whichImage, boolean flag, real height returns nothing
        public delegate void SetImageConstantHeightPrototype(JassImage whichImage, JassBoolean flag, JassRealArg height);
        private static SetImageConstantHeightPrototype _SetImageConstantHeight;
        public static void SetImageConstantHeight(JassImage whichImage, Boolean flag, Single height)
        {
            InternalNatives._SetImageConstantHeight(whichImage, flag, height);
        }
        
        //native SetImagePosition takes image whichImage, real x, real y, real z returns nothing
        public delegate void SetImagePositionPrototype(JassImage whichImage, JassRealArg x, JassRealArg y, JassRealArg z);
        private static SetImagePositionPrototype _SetImagePosition;
        public static void SetImagePosition(JassImage whichImage, Single x, Single y, Single z)
        {
            InternalNatives._SetImagePosition(whichImage, x, y, z);
        }
        
        //native SetImageColor takes image whichImage, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetImageColorPrototype(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetImageColorPrototype _SetImageColor;
        public static void SetImageColor(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives._SetImageColor(whichImage, red, green, blue, alpha);
        }
        
        //native SetImageRender takes image whichImage, boolean flag returns nothing
        public delegate void SetImageRenderPrototype(JassImage whichImage, JassBoolean flag);
        private static SetImageRenderPrototype _SetImageRender;
        public static void SetImageRender(JassImage whichImage, Boolean flag)
        {
            InternalNatives._SetImageRender(whichImage, flag);
        }
        
        //native SetImageRenderAlways takes image whichImage, boolean flag returns nothing
        public delegate void SetImageRenderAlwaysPrototype(JassImage whichImage, JassBoolean flag);
        private static SetImageRenderAlwaysPrototype _SetImageRenderAlways;
        public static void SetImageRenderAlways(JassImage whichImage, Boolean flag)
        {
            InternalNatives._SetImageRenderAlways(whichImage, flag);
        }
        
        //native SetImageAboveWater takes image whichImage, boolean flag, boolean useWaterAlpha returns nothing
        public delegate void SetImageAboveWaterPrototype(JassImage whichImage, JassBoolean flag, JassBoolean useWaterAlpha);
        private static SetImageAboveWaterPrototype _SetImageAboveWater;
        public static void SetImageAboveWater(JassImage whichImage, Boolean flag, Boolean useWaterAlpha)
        {
            InternalNatives._SetImageAboveWater(whichImage, flag, useWaterAlpha);
        }
        
        //native SetImageType takes image whichImage, integer imageType returns nothing
        public delegate void SetImageTypePrototype(JassImage whichImage, JassInteger imageType);
        private static SetImageTypePrototype _SetImageType;
        public static void SetImageType(JassImage whichImage, JassInteger imageType)
        {
            InternalNatives._SetImageType(whichImage, imageType);
        }
        
        //native CreateUbersplat takes real x, real y, string name, integer red, integer green, integer blue, integer alpha, boolean forcePaused, boolean noBirthTime returns ubersplat
        public delegate JassUberSplat CreateUbersplatPrototype(JassRealArg x, JassRealArg y, String name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, JassBoolean forcePaused, JassBoolean noBirthTime);
        private static CreateUbersplatPrototype _CreateUbersplat;
        public static JassUberSplat CreateUbersplat(Single x, Single y, String name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, Boolean forcePaused, Boolean noBirthTime)
        {
            return InternalNatives._CreateUbersplat(x, y, name, red, green, blue, alpha, forcePaused, noBirthTime);
        }
        
        //native DestroyUbersplat takes ubersplat whichSplat returns nothing
        public delegate void DestroyUbersplatPrototype(JassUberSplat whichSplat);
        private static DestroyUbersplatPrototype _DestroyUbersplat;
        public static void DestroyUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives._DestroyUbersplat(whichSplat);
        }
        
        //native ResetUbersplat takes ubersplat whichSplat returns nothing
        public delegate void ResetUbersplatPrototype(JassUberSplat whichSplat);
        private static ResetUbersplatPrototype _ResetUbersplat;
        public static void ResetUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives._ResetUbersplat(whichSplat);
        }
        
        //native FinishUbersplat takes ubersplat whichSplat returns nothing
        public delegate void FinishUbersplatPrototype(JassUberSplat whichSplat);
        private static FinishUbersplatPrototype _FinishUbersplat;
        public static void FinishUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives._FinishUbersplat(whichSplat);
        }
        
        //native ShowUbersplat takes ubersplat whichSplat, boolean flag returns nothing
        public delegate void ShowUbersplatPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private static ShowUbersplatPrototype _ShowUbersplat;
        public static void ShowUbersplat(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives._ShowUbersplat(whichSplat, flag);
        }
        
        //native SetUbersplatRender takes ubersplat whichSplat, boolean flag returns nothing
        public delegate void SetUbersplatRenderPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private static SetUbersplatRenderPrototype _SetUbersplatRender;
        public static void SetUbersplatRender(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives._SetUbersplatRender(whichSplat, flag);
        }
        
        //native SetUbersplatRenderAlways takes ubersplat whichSplat, boolean flag returns nothing
        public delegate void SetUbersplatRenderAlwaysPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private static SetUbersplatRenderAlwaysPrototype _SetUbersplatRenderAlways;
        public static void SetUbersplatRenderAlways(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives._SetUbersplatRenderAlways(whichSplat, flag);
        }
        
        //native SetBlight takes player whichPlayer, real x, real y, real radius, boolean addBlight returns nothing
        public delegate void SetBlightPrototype(JassPlayer whichPlayer, JassRealArg x, JassRealArg y, JassRealArg radius, JassBoolean addBlight);
        private static SetBlightPrototype _SetBlight;
        public static void SetBlight(JassPlayer whichPlayer, Single x, Single y, Single radius, Boolean addBlight)
        {
            InternalNatives._SetBlight(whichPlayer, x, y, radius, addBlight);
        }
        
        //native SetBlightRect takes player whichPlayer, rect r, boolean addBlight returns nothing
        public delegate void SetBlightRectPrototype(JassPlayer whichPlayer, JassRect r, JassBoolean addBlight);
        private static SetBlightRectPrototype _SetBlightRect;
        public static void SetBlightRect(JassPlayer whichPlayer, JassRect r, Boolean addBlight)
        {
            InternalNatives._SetBlightRect(whichPlayer, r, addBlight);
        }
        
        //native SetBlightPoint takes player whichPlayer, real x, real y, boolean addBlight returns nothing
        public delegate void SetBlightPointPrototype(JassPlayer whichPlayer, JassRealArg x, JassRealArg y, JassBoolean addBlight);
        private static SetBlightPointPrototype _SetBlightPoint;
        public static void SetBlightPoint(JassPlayer whichPlayer, Single x, Single y, Boolean addBlight)
        {
            InternalNatives._SetBlightPoint(whichPlayer, x, y, addBlight);
        }
        
        //native SetBlightLoc takes player whichPlayer, location whichLocation, real radius, boolean addBlight returns nothing
        public delegate void SetBlightLocPrototype(JassPlayer whichPlayer, JassLocation whichLocation, JassRealArg radius, JassBoolean addBlight);
        private static SetBlightLocPrototype _SetBlightLoc;
        public static void SetBlightLoc(JassPlayer whichPlayer, JassLocation whichLocation, Single radius, Boolean addBlight)
        {
            InternalNatives._SetBlightLoc(whichPlayer, whichLocation, radius, addBlight);
        }
        
        //native CreateBlightedGoldmine takes player id, real x, real y, real face returns unit
        public delegate JassUnit CreateBlightedGoldminePrototype(JassPlayer id, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateBlightedGoldminePrototype _CreateBlightedGoldmine;
        public static JassUnit CreateBlightedGoldmine(JassPlayer id, Single x, Single y, Single face)
        {
            return InternalNatives._CreateBlightedGoldmine(id, x, y, face);
        }
        
        //native IsPointBlighted takes real x, real y returns boolean
        public delegate JassBoolean IsPointBlightedPrototype(JassRealArg x, JassRealArg y);
        private static IsPointBlightedPrototype _IsPointBlighted;
        public static Boolean IsPointBlighted(Single x, Single y)
        {
            return InternalNatives._IsPointBlighted(x, y);
        }
        
        //native SetDoodadAnimation takes real x, real y, real radius, integer doodadID, boolean nearestOnly, string animName, boolean animRandom returns nothing
        public delegate void SetDoodadAnimationPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassObjectId doodadID, JassBoolean nearestOnly, String animName, JassBoolean animRandom);
        private static SetDoodadAnimationPrototype _SetDoodadAnimation;
        public static void SetDoodadAnimation(Single x, Single y, Single radius, JassObjectId doodadID, Boolean nearestOnly, String animName, Boolean animRandom)
        {
            InternalNatives._SetDoodadAnimation(x, y, radius, doodadID, nearestOnly, animName, animRandom);
        }
        
        //native SetDoodadAnimationRect takes rect r, integer doodadID, string animName, boolean animRandom returns nothing
        public delegate void SetDoodadAnimationRectPrototype(JassRect r, JassObjectId doodadID, String animName, JassBoolean animRandom);
        private static SetDoodadAnimationRectPrototype _SetDoodadAnimationRect;
        public static void SetDoodadAnimationRect(JassRect r, JassObjectId doodadID, String animName, Boolean animRandom)
        {
            InternalNatives._SetDoodadAnimationRect(r, doodadID, animName, animRandom);
        }
        
        //native StartMeleeAI takes player num, string script returns nothing
        public delegate void StartMeleeAIPrototype(JassPlayer num, String script);
        private static StartMeleeAIPrototype _StartMeleeAI;
        public static void StartMeleeAI(JassPlayer num, String script)
        {
            InternalNatives._StartMeleeAI(num, script);
        }
        
        //native StartCampaignAI takes player num, string script returns nothing
        public delegate void StartCampaignAIPrototype(JassPlayer num, String script);
        private static StartCampaignAIPrototype _StartCampaignAI;
        public static void StartCampaignAI(JassPlayer num, String script)
        {
            InternalNatives._StartCampaignAI(num, script);
        }
        
        //native CommandAI takes player num, integer command, integer data returns nothing
        public delegate void CommandAIPrototype(JassPlayer num, JassInteger command, JassInteger data);
        private static CommandAIPrototype _CommandAI;
        public static void CommandAI(JassPlayer num, JassInteger command, JassInteger data)
        {
            InternalNatives._CommandAI(num, command, data);
        }
        
        //native PauseCompAI takes player p, boolean pause returns nothing
        public delegate void PauseCompAIPrototype(JassPlayer p, JassBoolean pause);
        private static PauseCompAIPrototype _PauseCompAI;
        public static void PauseCompAI(JassPlayer p, Boolean pause)
        {
            InternalNatives._PauseCompAI(p, pause);
        }
        
        //native GetAIDifficulty takes player num returns aidifficulty
        public delegate JassAIDifficulty GetAIDifficultyPrototype(JassPlayer num);
        private static GetAIDifficultyPrototype _GetAIDifficulty;
        public static JassAIDifficulty GetAIDifficulty(JassPlayer num)
        {
            return InternalNatives._GetAIDifficulty(num);
        }
        
        //native RemoveGuardPosition takes unit hUnit returns nothing
        public delegate void RemoveGuardPositionPrototype(JassUnit hUnit);
        private static RemoveGuardPositionPrototype _RemoveGuardPosition;
        public static void RemoveGuardPosition(JassUnit hUnit)
        {
            InternalNatives._RemoveGuardPosition(hUnit);
        }
        
        //native RecycleGuardPosition takes unit hUnit returns nothing
        public delegate void RecycleGuardPositionPrototype(JassUnit hUnit);
        private static RecycleGuardPositionPrototype _RecycleGuardPosition;
        public static void RecycleGuardPosition(JassUnit hUnit)
        {
            InternalNatives._RecycleGuardPosition(hUnit);
        }
        
        //native RemoveAllGuardPositions takes player num returns nothing
        public delegate void RemoveAllGuardPositionsPrototype(JassPlayer num);
        private static RemoveAllGuardPositionsPrototype _RemoveAllGuardPositions;
        public static void RemoveAllGuardPositions(JassPlayer num)
        {
            InternalNatives._RemoveAllGuardPositions(num);
        }
        
        //native Cheat takes string cheatStr returns nothing
        public delegate void CheatPrototype(String cheatStr);
        private static CheatPrototype _Cheat;
        public static void Cheat(String cheatStr)
        {
            InternalNatives._Cheat(cheatStr);
        }
        
        //native IsNoVictoryCheat takes nothing returns boolean
        public delegate JassBoolean IsNoVictoryCheatPrototype();
        private static IsNoVictoryCheatPrototype _IsNoVictoryCheat;
        public static Boolean IsNoVictoryCheat()
        {
            return InternalNatives._IsNoVictoryCheat();
        }
        
        //native IsNoDefeatCheat takes nothing returns boolean
        public delegate JassBoolean IsNoDefeatCheatPrototype();
        private static IsNoDefeatCheatPrototype _IsNoDefeatCheat;
        public static Boolean IsNoDefeatCheat()
        {
            return InternalNatives._IsNoDefeatCheat();
        }
        
        //native Preload takes string filename returns nothing
        public delegate void PreloadPrototype(String filename);
        private static PreloadPrototype _Preload;
        public static void Preload(String filename)
        {
            InternalNatives._Preload(filename);
        }
        
        //native PreloadEnd takes real timeout returns nothing
        public delegate void PreloadEndPrototype(JassRealArg timeout);
        private static PreloadEndPrototype _PreloadEnd;
        public static void PreloadEnd(Single timeout)
        {
            InternalNatives._PreloadEnd(timeout);
        }
        
        //native PreloadStart takes nothing returns nothing
        public delegate void PreloadStartPrototype();
        private static PreloadStartPrototype _PreloadStart;
        public static void PreloadStart()
        {
            InternalNatives._PreloadStart();
        }
        
        //native PreloadRefresh takes nothing returns nothing
        public delegate void PreloadRefreshPrototype();
        private static PreloadRefreshPrototype _PreloadRefresh;
        public static void PreloadRefresh()
        {
            InternalNatives._PreloadRefresh();
        }
        
        //native PreloadEndEx takes nothing returns nothing
        public delegate void PreloadEndExPrototype();
        private static PreloadEndExPrototype _PreloadEndEx;
        public static void PreloadEndEx()
        {
            InternalNatives._PreloadEndEx();
        }
        
        //native PreloadGenClear takes nothing returns nothing
        public delegate void PreloadGenClearPrototype();
        private static PreloadGenClearPrototype _PreloadGenClear;
        public static void PreloadGenClear()
        {
            InternalNatives._PreloadGenClear();
        }
        
        //native PreloadGenStart takes nothing returns nothing
        public delegate void PreloadGenStartPrototype();
        private static PreloadGenStartPrototype _PreloadGenStart;
        public static void PreloadGenStart()
        {
            InternalNatives._PreloadGenStart();
        }
        
        //native PreloadGenEnd takes string filename returns nothing
        public delegate void PreloadGenEndPrototype(String filename);
        private static PreloadGenEndPrototype _PreloadGenEnd;
        public static void PreloadGenEnd(String filename)
        {
            InternalNatives._PreloadGenEnd(filename);
        }
        
        //native Preloader takes string filename returns nothing
        public delegate void PreloaderPrototype(String filename);
        private static PreloaderPrototype _Preloader;
        public static void Preloader(String filename)
        {
            InternalNatives._Preloader(filename);
        }
        
        private static void GetVanillaNatives()
        {
            InternalNatives._ConvertRace = InternalNatives.Get("ConvertRace").ToDelegate<ConvertRacePrototype>();
            InternalNatives._ConvertAllianceType = InternalNatives.Get("ConvertAllianceType").ToDelegate<ConvertAllianceTypePrototype>();
            InternalNatives._ConvertRacePref = InternalNatives.Get("ConvertRacePref").ToDelegate<ConvertRacePrefPrototype>();
            InternalNatives._ConvertIGameState = InternalNatives.Get("ConvertIGameState").ToDelegate<ConvertIGameStatePrototype>();
            InternalNatives._ConvertFGameState = InternalNatives.Get("ConvertFGameState").ToDelegate<ConvertFGameStatePrototype>();
            InternalNatives._ConvertPlayerState = InternalNatives.Get("ConvertPlayerState").ToDelegate<ConvertPlayerStatePrototype>();
            InternalNatives._ConvertPlayerScore = InternalNatives.Get("ConvertPlayerScore").ToDelegate<ConvertPlayerScorePrototype>();
            InternalNatives._ConvertPlayerGameResult = InternalNatives.Get("ConvertPlayerGameResult").ToDelegate<ConvertPlayerGameResultPrototype>();
            InternalNatives._ConvertUnitState = InternalNatives.Get("ConvertUnitState").ToDelegate<ConvertUnitStatePrototype>();
            InternalNatives._ConvertAIDifficulty = InternalNatives.Get("ConvertAIDifficulty").ToDelegate<ConvertAIDifficultyPrototype>();
            InternalNatives._ConvertGameEvent = InternalNatives.Get("ConvertGameEvent").ToDelegate<ConvertGameEventPrototype>();
            InternalNatives._ConvertPlayerEvent = InternalNatives.Get("ConvertPlayerEvent").ToDelegate<ConvertPlayerEventPrototype>();
            InternalNatives._ConvertPlayerUnitEvent = InternalNatives.Get("ConvertPlayerUnitEvent").ToDelegate<ConvertPlayerUnitEventPrototype>();
            InternalNatives._ConvertWidgetEvent = InternalNatives.Get("ConvertWidgetEvent").ToDelegate<ConvertWidgetEventPrototype>();
            InternalNatives._ConvertDialogEvent = InternalNatives.Get("ConvertDialogEvent").ToDelegate<ConvertDialogEventPrototype>();
            InternalNatives._ConvertUnitEvent = InternalNatives.Get("ConvertUnitEvent").ToDelegate<ConvertUnitEventPrototype>();
            InternalNatives._ConvertLimitOp = InternalNatives.Get("ConvertLimitOp").ToDelegate<ConvertLimitOpPrototype>();
            InternalNatives._ConvertUnitType = InternalNatives.Get("ConvertUnitType").ToDelegate<ConvertUnitTypePrototype>();
            InternalNatives._ConvertGameSpeed = InternalNatives.Get("ConvertGameSpeed").ToDelegate<ConvertGameSpeedPrototype>();
            InternalNatives._ConvertPlacement = InternalNatives.Get("ConvertPlacement").ToDelegate<ConvertPlacementPrototype>();
            InternalNatives._ConvertStartLocPrio = InternalNatives.Get("ConvertStartLocPrio").ToDelegate<ConvertStartLocPrioPrototype>();
            InternalNatives._ConvertGameDifficulty = InternalNatives.Get("ConvertGameDifficulty").ToDelegate<ConvertGameDifficultyPrototype>();
            InternalNatives._ConvertGameType = InternalNatives.Get("ConvertGameType").ToDelegate<ConvertGameTypePrototype>();
            InternalNatives._ConvertMapFlag = InternalNatives.Get("ConvertMapFlag").ToDelegate<ConvertMapFlagPrototype>();
            InternalNatives._ConvertMapVisibility = InternalNatives.Get("ConvertMapVisibility").ToDelegate<ConvertMapVisibilityPrototype>();
            InternalNatives._ConvertMapSetting = InternalNatives.Get("ConvertMapSetting").ToDelegate<ConvertMapSettingPrototype>();
            InternalNatives._ConvertMapDensity = InternalNatives.Get("ConvertMapDensity").ToDelegate<ConvertMapDensityPrototype>();
            InternalNatives._ConvertMapControl = InternalNatives.Get("ConvertMapControl").ToDelegate<ConvertMapControlPrototype>();
            InternalNatives._ConvertPlayerColor = InternalNatives.Get("ConvertPlayerColor").ToDelegate<ConvertPlayerColorPrototype>();
            InternalNatives._ConvertPlayerSlotState = InternalNatives.Get("ConvertPlayerSlotState").ToDelegate<ConvertPlayerSlotStatePrototype>();
            InternalNatives._ConvertVolumeGroup = InternalNatives.Get("ConvertVolumeGroup").ToDelegate<ConvertVolumeGroupPrototype>();
            InternalNatives._ConvertCameraField = InternalNatives.Get("ConvertCameraField").ToDelegate<ConvertCameraFieldPrototype>();
            InternalNatives._ConvertBlendMode = InternalNatives.Get("ConvertBlendMode").ToDelegate<ConvertBlendModePrototype>();
            InternalNatives._ConvertRarityControl = InternalNatives.Get("ConvertRarityControl").ToDelegate<ConvertRarityControlPrototype>();
            InternalNatives._ConvertTexMapFlags = InternalNatives.Get("ConvertTexMapFlags").ToDelegate<ConvertTexMapFlagsPrototype>();
            InternalNatives._ConvertFogState = InternalNatives.Get("ConvertFogState").ToDelegate<ConvertFogStatePrototype>();
            InternalNatives._ConvertEffectType = InternalNatives.Get("ConvertEffectType").ToDelegate<ConvertEffectTypePrototype>();
            InternalNatives._ConvertVersion = InternalNatives.Get("ConvertVersion").ToDelegate<ConvertVersionPrototype>();
            InternalNatives._ConvertItemType = InternalNatives.Get("ConvertItemType").ToDelegate<ConvertItemTypePrototype>();
            InternalNatives._ConvertAttackType = InternalNatives.Get("ConvertAttackType").ToDelegate<ConvertAttackTypePrototype>();
            InternalNatives._ConvertDamageType = InternalNatives.Get("ConvertDamageType").ToDelegate<ConvertDamageTypePrototype>();
            InternalNatives._ConvertWeaponType = InternalNatives.Get("ConvertWeaponType").ToDelegate<ConvertWeaponTypePrototype>();
            InternalNatives._ConvertSoundType = InternalNatives.Get("ConvertSoundType").ToDelegate<ConvertSoundTypePrototype>();
            InternalNatives._ConvertPathingType = InternalNatives.Get("ConvertPathingType").ToDelegate<ConvertPathingTypePrototype>();
            InternalNatives._OrderId = InternalNatives.Get("OrderId").ToDelegate<OrderIdPrototype>();
            InternalNatives._OrderId2String = InternalNatives.Get("OrderId2String").ToDelegate<OrderId2StringPrototype>();
            InternalNatives._UnitId = InternalNatives.Get("UnitId").ToDelegate<UnitIdPrototype>();
            InternalNatives._UnitId2String = InternalNatives.Get("UnitId2String").ToDelegate<UnitId2StringPrototype>();
            InternalNatives._AbilityId = InternalNatives.Get("AbilityId").ToDelegate<AbilityIdPrototype>();
            InternalNatives._AbilityId2String = InternalNatives.Get("AbilityId2String").ToDelegate<AbilityId2StringPrototype>();
            InternalNatives._GetObjectName = InternalNatives.Get("GetObjectName").ToDelegate<GetObjectNamePrototype>();
            InternalNatives._Deg2Rad = InternalNatives.Get("Deg2Rad").ToDelegate<Deg2RadPrototype>();
            InternalNatives._Rad2Deg = InternalNatives.Get("Rad2Deg").ToDelegate<Rad2DegPrototype>();
            InternalNatives._Sin = InternalNatives.Get("Sin").ToDelegate<SinPrototype>();
            InternalNatives._Cos = InternalNatives.Get("Cos").ToDelegate<CosPrototype>();
            InternalNatives._Tan = InternalNatives.Get("Tan").ToDelegate<TanPrototype>();
            InternalNatives._Asin = InternalNatives.Get("Asin").ToDelegate<AsinPrototype>();
            InternalNatives._Acos = InternalNatives.Get("Acos").ToDelegate<AcosPrototype>();
            InternalNatives._Atan = InternalNatives.Get("Atan").ToDelegate<AtanPrototype>();
            InternalNatives._Atan2 = InternalNatives.Get("Atan2").ToDelegate<Atan2Prototype>();
            InternalNatives._SquareRoot = InternalNatives.Get("SquareRoot").ToDelegate<SquareRootPrototype>();
            InternalNatives._Pow = InternalNatives.Get("Pow").ToDelegate<PowPrototype>();
            InternalNatives._I2R = InternalNatives.Get("I2R").ToDelegate<I2RPrototype>();
            InternalNatives._R2I = InternalNatives.Get("R2I").ToDelegate<R2IPrototype>();
            InternalNatives._I2S = InternalNatives.Get("I2S").ToDelegate<I2SPrototype>();
            InternalNatives._R2S = InternalNatives.Get("R2S").ToDelegate<R2SPrototype>();
            InternalNatives._R2SW = InternalNatives.Get("R2SW").ToDelegate<R2SWPrototype>();
            InternalNatives._S2I = InternalNatives.Get("S2I").ToDelegate<S2IPrototype>();
            InternalNatives._S2R = InternalNatives.Get("S2R").ToDelegate<S2RPrototype>();
            InternalNatives._GetHandleId = InternalNatives.Get("GetHandleId").ToDelegate<GetHandleIdPrototype>();
            InternalNatives._SubString = InternalNatives.Get("SubString").ToDelegate<SubStringPrototype>();
            InternalNatives._StringLength = InternalNatives.Get("StringLength").ToDelegate<StringLengthPrototype>();
            InternalNatives._StringCase = InternalNatives.Get("StringCase").ToDelegate<StringCasePrototype>();
            InternalNatives._StringHash = InternalNatives.Get("StringHash").ToDelegate<StringHashPrototype>();
            InternalNatives._GetLocalizedString = InternalNatives.Get("GetLocalizedString").ToDelegate<GetLocalizedStringPrototype>();
            InternalNatives._GetLocalizedHotkey = InternalNatives.Get("GetLocalizedHotkey").ToDelegate<GetLocalizedHotkeyPrototype>();
            InternalNatives._SetMapName = InternalNatives.Get("SetMapName").ToDelegate<SetMapNamePrototype>();
            InternalNatives._SetMapDescription = InternalNatives.Get("SetMapDescription").ToDelegate<SetMapDescriptionPrototype>();
            InternalNatives._SetTeams = InternalNatives.Get("SetTeams").ToDelegate<SetTeamsPrototype>();
            InternalNatives._SetPlayers = InternalNatives.Get("SetPlayers").ToDelegate<SetPlayersPrototype>();
            InternalNatives._DefineStartLocation = InternalNatives.Get("DefineStartLocation").ToDelegate<DefineStartLocationPrototype>();
            InternalNatives._DefineStartLocationLoc = InternalNatives.Get("DefineStartLocationLoc").ToDelegate<DefineStartLocationLocPrototype>();
            InternalNatives._SetStartLocPrioCount = InternalNatives.Get("SetStartLocPrioCount").ToDelegate<SetStartLocPrioCountPrototype>();
            InternalNatives._SetStartLocPrio = InternalNatives.Get("SetStartLocPrio").ToDelegate<SetStartLocPrioPrototype>();
            InternalNatives._GetStartLocPrioSlot = InternalNatives.Get("GetStartLocPrioSlot").ToDelegate<GetStartLocPrioSlotPrototype>();
            InternalNatives._GetStartLocPrio = InternalNatives.Get("GetStartLocPrio").ToDelegate<GetStartLocPrioPrototype>();
            InternalNatives._SetGameTypeSupported = InternalNatives.Get("SetGameTypeSupported").ToDelegate<SetGameTypeSupportedPrototype>();
            InternalNatives._SetMapFlag = InternalNatives.Get("SetMapFlag").ToDelegate<SetMapFlagPrototype>();
            InternalNatives._SetGamePlacement = InternalNatives.Get("SetGamePlacement").ToDelegate<SetGamePlacementPrototype>();
            InternalNatives._SetGameSpeed = InternalNatives.Get("SetGameSpeed").ToDelegate<SetGameSpeedPrototype>();
            InternalNatives._SetGameDifficulty = InternalNatives.Get("SetGameDifficulty").ToDelegate<SetGameDifficultyPrototype>();
            InternalNatives._SetResourceDensity = InternalNatives.Get("SetResourceDensity").ToDelegate<SetResourceDensityPrototype>();
            InternalNatives._SetCreatureDensity = InternalNatives.Get("SetCreatureDensity").ToDelegate<SetCreatureDensityPrototype>();
            InternalNatives._GetTeams = InternalNatives.Get("GetTeams").ToDelegate<GetTeamsPrototype>();
            InternalNatives._GetPlayers = InternalNatives.Get("GetPlayers").ToDelegate<GetPlayersPrototype>();
            InternalNatives._IsGameTypeSupported = InternalNatives.Get("IsGameTypeSupported").ToDelegate<IsGameTypeSupportedPrototype>();
            InternalNatives._GetGameTypeSelected = InternalNatives.Get("GetGameTypeSelected").ToDelegate<GetGameTypeSelectedPrototype>();
            InternalNatives._IsMapFlagSet = InternalNatives.Get("IsMapFlagSet").ToDelegate<IsMapFlagSetPrototype>();
            InternalNatives._GetGamePlacement = InternalNatives.Get("GetGamePlacement").ToDelegate<GetGamePlacementPrototype>();
            InternalNatives._GetGameSpeed = InternalNatives.Get("GetGameSpeed").ToDelegate<GetGameSpeedPrototype>();
            InternalNatives._GetGameDifficulty = InternalNatives.Get("GetGameDifficulty").ToDelegate<GetGameDifficultyPrototype>();
            InternalNatives._GetResourceDensity = InternalNatives.Get("GetResourceDensity").ToDelegate<GetResourceDensityPrototype>();
            InternalNatives._GetCreatureDensity = InternalNatives.Get("GetCreatureDensity").ToDelegate<GetCreatureDensityPrototype>();
            InternalNatives._GetStartLocationX = InternalNatives.Get("GetStartLocationX").ToDelegate<GetStartLocationXPrototype>();
            InternalNatives._GetStartLocationY = InternalNatives.Get("GetStartLocationY").ToDelegate<GetStartLocationYPrototype>();
            InternalNatives._GetStartLocationLoc = InternalNatives.Get("GetStartLocationLoc").ToDelegate<GetStartLocationLocPrototype>();
            InternalNatives._SetPlayerTeam = InternalNatives.Get("SetPlayerTeam").ToDelegate<SetPlayerTeamPrototype>();
            InternalNatives._SetPlayerStartLocation = InternalNatives.Get("SetPlayerStartLocation").ToDelegate<SetPlayerStartLocationPrototype>();
            InternalNatives._ForcePlayerStartLocation = InternalNatives.Get("ForcePlayerStartLocation").ToDelegate<ForcePlayerStartLocationPrototype>();
            InternalNatives._SetPlayerColor = InternalNatives.Get("SetPlayerColor").ToDelegate<SetPlayerColorPrototype>();
            InternalNatives._SetPlayerAlliance = InternalNatives.Get("SetPlayerAlliance").ToDelegate<SetPlayerAlliancePrototype>();
            InternalNatives._SetPlayerTaxRate = InternalNatives.Get("SetPlayerTaxRate").ToDelegate<SetPlayerTaxRatePrototype>();
            InternalNatives._SetPlayerRacePreference = InternalNatives.Get("SetPlayerRacePreference").ToDelegate<SetPlayerRacePreferencePrototype>();
            InternalNatives._SetPlayerRaceSelectable = InternalNatives.Get("SetPlayerRaceSelectable").ToDelegate<SetPlayerRaceSelectablePrototype>();
            InternalNatives._SetPlayerController = InternalNatives.Get("SetPlayerController").ToDelegate<SetPlayerControllerPrototype>();
            InternalNatives._SetPlayerName = InternalNatives.Get("SetPlayerName").ToDelegate<SetPlayerNamePrototype>();
            InternalNatives._SetPlayerOnScoreScreen = InternalNatives.Get("SetPlayerOnScoreScreen").ToDelegate<SetPlayerOnScoreScreenPrototype>();
            InternalNatives._GetPlayerTeam = InternalNatives.Get("GetPlayerTeam").ToDelegate<GetPlayerTeamPrototype>();
            InternalNatives._GetPlayerStartLocation = InternalNatives.Get("GetPlayerStartLocation").ToDelegate<GetPlayerStartLocationPrototype>();
            InternalNatives._GetPlayerColor = InternalNatives.Get("GetPlayerColor").ToDelegate<GetPlayerColorPrototype>();
            InternalNatives._GetPlayerSelectable = InternalNatives.Get("GetPlayerSelectable").ToDelegate<GetPlayerSelectablePrototype>();
            InternalNatives._GetPlayerController = InternalNatives.Get("GetPlayerController").ToDelegate<GetPlayerControllerPrototype>();
            InternalNatives._GetPlayerSlotState = InternalNatives.Get("GetPlayerSlotState").ToDelegate<GetPlayerSlotStatePrototype>();
            InternalNatives._GetPlayerTaxRate = InternalNatives.Get("GetPlayerTaxRate").ToDelegate<GetPlayerTaxRatePrototype>();
            InternalNatives._IsPlayerRacePrefSet = InternalNatives.Get("IsPlayerRacePrefSet").ToDelegate<IsPlayerRacePrefSetPrototype>();
            InternalNatives._GetPlayerName = InternalNatives.Get("GetPlayerName").ToDelegate<GetPlayerNamePrototype>();
            InternalNatives._CreateTimer = InternalNatives.Get("CreateTimer").ToDelegate<CreateTimerPrototype>();
            InternalNatives._DestroyTimer = InternalNatives.Get("DestroyTimer").ToDelegate<DestroyTimerPrototype>();
            InternalNatives._TimerStart = InternalNatives.Get("TimerStart").ToDelegate<TimerStartPrototype>();
            InternalNatives._TimerGetElapsed = InternalNatives.Get("TimerGetElapsed").ToDelegate<TimerGetElapsedPrototype>();
            InternalNatives._TimerGetRemaining = InternalNatives.Get("TimerGetRemaining").ToDelegate<TimerGetRemainingPrototype>();
            InternalNatives._TimerGetTimeout = InternalNatives.Get("TimerGetTimeout").ToDelegate<TimerGetTimeoutPrototype>();
            InternalNatives._PauseTimer = InternalNatives.Get("PauseTimer").ToDelegate<PauseTimerPrototype>();
            InternalNatives._ResumeTimer = InternalNatives.Get("ResumeTimer").ToDelegate<ResumeTimerPrototype>();
            InternalNatives._GetExpiredTimer = InternalNatives.Get("GetExpiredTimer").ToDelegate<GetExpiredTimerPrototype>();
            InternalNatives._CreateGroup = InternalNatives.Get("CreateGroup").ToDelegate<CreateGroupPrototype>();
            InternalNatives._DestroyGroup = InternalNatives.Get("DestroyGroup").ToDelegate<DestroyGroupPrototype>();
            InternalNatives._GroupAddUnit = InternalNatives.Get("GroupAddUnit").ToDelegate<GroupAddUnitPrototype>();
            InternalNatives._GroupRemoveUnit = InternalNatives.Get("GroupRemoveUnit").ToDelegate<GroupRemoveUnitPrototype>();
            InternalNatives._GroupClear = InternalNatives.Get("GroupClear").ToDelegate<GroupClearPrototype>();
            InternalNatives._GroupEnumUnitsOfType = InternalNatives.Get("GroupEnumUnitsOfType").ToDelegate<GroupEnumUnitsOfTypePrototype>();
            InternalNatives._GroupEnumUnitsOfPlayer = InternalNatives.Get("GroupEnumUnitsOfPlayer").ToDelegate<GroupEnumUnitsOfPlayerPrototype>();
            InternalNatives._GroupEnumUnitsOfTypeCounted = InternalNatives.Get("GroupEnumUnitsOfTypeCounted").ToDelegate<GroupEnumUnitsOfTypeCountedPrototype>();
            InternalNatives._GroupEnumUnitsInRect = InternalNatives.Get("GroupEnumUnitsInRect").ToDelegate<GroupEnumUnitsInRectPrototype>();
            InternalNatives._GroupEnumUnitsInRectCounted = InternalNatives.Get("GroupEnumUnitsInRectCounted").ToDelegate<GroupEnumUnitsInRectCountedPrototype>();
            InternalNatives._GroupEnumUnitsInRange = InternalNatives.Get("GroupEnumUnitsInRange").ToDelegate<GroupEnumUnitsInRangePrototype>();
            InternalNatives._GroupEnumUnitsInRangeOfLoc = InternalNatives.Get("GroupEnumUnitsInRangeOfLoc").ToDelegate<GroupEnumUnitsInRangeOfLocPrototype>();
            InternalNatives._GroupEnumUnitsInRangeCounted = InternalNatives.Get("GroupEnumUnitsInRangeCounted").ToDelegate<GroupEnumUnitsInRangeCountedPrototype>();
            InternalNatives._GroupEnumUnitsInRangeOfLocCounted = InternalNatives.Get("GroupEnumUnitsInRangeOfLocCounted").ToDelegate<GroupEnumUnitsInRangeOfLocCountedPrototype>();
            InternalNatives._GroupEnumUnitsSelected = InternalNatives.Get("GroupEnumUnitsSelected").ToDelegate<GroupEnumUnitsSelectedPrototype>();
            InternalNatives._GroupImmediateOrder = InternalNatives.Get("GroupImmediateOrder").ToDelegate<GroupImmediateOrderPrototype>();
            InternalNatives._GroupImmediateOrderById = InternalNatives.Get("GroupImmediateOrderById").ToDelegate<GroupImmediateOrderByIdPrototype>();
            InternalNatives._GroupPointOrder = InternalNatives.Get("GroupPointOrder").ToDelegate<GroupPointOrderPrototype>();
            InternalNatives._GroupPointOrderLoc = InternalNatives.Get("GroupPointOrderLoc").ToDelegate<GroupPointOrderLocPrototype>();
            InternalNatives._GroupPointOrderById = InternalNatives.Get("GroupPointOrderById").ToDelegate<GroupPointOrderByIdPrototype>();
            InternalNatives._GroupPointOrderByIdLoc = InternalNatives.Get("GroupPointOrderByIdLoc").ToDelegate<GroupPointOrderByIdLocPrototype>();
            InternalNatives._GroupTargetOrder = InternalNatives.Get("GroupTargetOrder").ToDelegate<GroupTargetOrderPrototype>();
            InternalNatives._GroupTargetOrderById = InternalNatives.Get("GroupTargetOrderById").ToDelegate<GroupTargetOrderByIdPrototype>();
            InternalNatives._ForGroup = InternalNatives.Get("ForGroup").ToDelegate<ForGroupPrototype>();
            InternalNatives._FirstOfGroup = InternalNatives.Get("FirstOfGroup").ToDelegate<FirstOfGroupPrototype>();
            InternalNatives._CreateForce = InternalNatives.Get("CreateForce").ToDelegate<CreateForcePrototype>();
            InternalNatives._DestroyForce = InternalNatives.Get("DestroyForce").ToDelegate<DestroyForcePrototype>();
            InternalNatives._ForceAddPlayer = InternalNatives.Get("ForceAddPlayer").ToDelegate<ForceAddPlayerPrototype>();
            InternalNatives._ForceRemovePlayer = InternalNatives.Get("ForceRemovePlayer").ToDelegate<ForceRemovePlayerPrototype>();
            InternalNatives._ForceClear = InternalNatives.Get("ForceClear").ToDelegate<ForceClearPrototype>();
            InternalNatives._ForceEnumPlayers = InternalNatives.Get("ForceEnumPlayers").ToDelegate<ForceEnumPlayersPrototype>();
            InternalNatives._ForceEnumPlayersCounted = InternalNatives.Get("ForceEnumPlayersCounted").ToDelegate<ForceEnumPlayersCountedPrototype>();
            InternalNatives._ForceEnumAllies = InternalNatives.Get("ForceEnumAllies").ToDelegate<ForceEnumAlliesPrototype>();
            InternalNatives._ForceEnumEnemies = InternalNatives.Get("ForceEnumEnemies").ToDelegate<ForceEnumEnemiesPrototype>();
            InternalNatives._ForForce = InternalNatives.Get("ForForce").ToDelegate<ForForcePrototype>();
            InternalNatives._Rect = InternalNatives.Get("Rect").ToDelegate<RectPrototype>();
            InternalNatives._RectFromLoc = InternalNatives.Get("RectFromLoc").ToDelegate<RectFromLocPrototype>();
            InternalNatives._RemoveRect = InternalNatives.Get("RemoveRect").ToDelegate<RemoveRectPrototype>();
            InternalNatives._SetRect = InternalNatives.Get("SetRect").ToDelegate<SetRectPrototype>();
            InternalNatives._SetRectFromLoc = InternalNatives.Get("SetRectFromLoc").ToDelegate<SetRectFromLocPrototype>();
            InternalNatives._MoveRectTo = InternalNatives.Get("MoveRectTo").ToDelegate<MoveRectToPrototype>();
            InternalNatives._MoveRectToLoc = InternalNatives.Get("MoveRectToLoc").ToDelegate<MoveRectToLocPrototype>();
            InternalNatives._GetRectCenterX = InternalNatives.Get("GetRectCenterX").ToDelegate<GetRectCenterXPrototype>();
            InternalNatives._GetRectCenterY = InternalNatives.Get("GetRectCenterY").ToDelegate<GetRectCenterYPrototype>();
            InternalNatives._GetRectMinX = InternalNatives.Get("GetRectMinX").ToDelegate<GetRectMinXPrototype>();
            InternalNatives._GetRectMinY = InternalNatives.Get("GetRectMinY").ToDelegate<GetRectMinYPrototype>();
            InternalNatives._GetRectMaxX = InternalNatives.Get("GetRectMaxX").ToDelegate<GetRectMaxXPrototype>();
            InternalNatives._GetRectMaxY = InternalNatives.Get("GetRectMaxY").ToDelegate<GetRectMaxYPrototype>();
            InternalNatives._CreateRegion = InternalNatives.Get("CreateRegion").ToDelegate<CreateRegionPrototype>();
            InternalNatives._RemoveRegion = InternalNatives.Get("RemoveRegion").ToDelegate<RemoveRegionPrototype>();
            InternalNatives._RegionAddRect = InternalNatives.Get("RegionAddRect").ToDelegate<RegionAddRectPrototype>();
            InternalNatives._RegionClearRect = InternalNatives.Get("RegionClearRect").ToDelegate<RegionClearRectPrototype>();
            InternalNatives._RegionAddCell = InternalNatives.Get("RegionAddCell").ToDelegate<RegionAddCellPrototype>();
            InternalNatives._RegionAddCellAtLoc = InternalNatives.Get("RegionAddCellAtLoc").ToDelegate<RegionAddCellAtLocPrototype>();
            InternalNatives._RegionClearCell = InternalNatives.Get("RegionClearCell").ToDelegate<RegionClearCellPrototype>();
            InternalNatives._RegionClearCellAtLoc = InternalNatives.Get("RegionClearCellAtLoc").ToDelegate<RegionClearCellAtLocPrototype>();
            InternalNatives._Location = InternalNatives.Get("Location").ToDelegate<LocationPrototype>();
            InternalNatives._RemoveLocation = InternalNatives.Get("RemoveLocation").ToDelegate<RemoveLocationPrototype>();
            InternalNatives._MoveLocation = InternalNatives.Get("MoveLocation").ToDelegate<MoveLocationPrototype>();
            InternalNatives._GetLocationX = InternalNatives.Get("GetLocationX").ToDelegate<GetLocationXPrototype>();
            InternalNatives._GetLocationY = InternalNatives.Get("GetLocationY").ToDelegate<GetLocationYPrototype>();
            InternalNatives._GetLocationZ = InternalNatives.Get("GetLocationZ").ToDelegate<GetLocationZPrototype>();
            InternalNatives._IsUnitInRegion = InternalNatives.Get("IsUnitInRegion").ToDelegate<IsUnitInRegionPrototype>();
            InternalNatives._IsPointInRegion = InternalNatives.Get("IsPointInRegion").ToDelegate<IsPointInRegionPrototype>();
            InternalNatives._IsLocationInRegion = InternalNatives.Get("IsLocationInRegion").ToDelegate<IsLocationInRegionPrototype>();
            InternalNatives._GetWorldBounds = InternalNatives.Get("GetWorldBounds").ToDelegate<GetWorldBoundsPrototype>();
            InternalNatives._CreateTrigger = InternalNatives.Get("CreateTrigger").ToDelegate<CreateTriggerPrototype>();
            InternalNatives._DestroyTrigger = InternalNatives.Get("DestroyTrigger").ToDelegate<DestroyTriggerPrototype>();
            InternalNatives._ResetTrigger = InternalNatives.Get("ResetTrigger").ToDelegate<ResetTriggerPrototype>();
            InternalNatives._EnableTrigger = InternalNatives.Get("EnableTrigger").ToDelegate<EnableTriggerPrototype>();
            InternalNatives._DisableTrigger = InternalNatives.Get("DisableTrigger").ToDelegate<DisableTriggerPrototype>();
            InternalNatives._IsTriggerEnabled = InternalNatives.Get("IsTriggerEnabled").ToDelegate<IsTriggerEnabledPrototype>();
            InternalNatives._TriggerWaitOnSleeps = InternalNatives.Get("TriggerWaitOnSleeps").ToDelegate<TriggerWaitOnSleepsPrototype>();
            InternalNatives._IsTriggerWaitOnSleeps = InternalNatives.Get("IsTriggerWaitOnSleeps").ToDelegate<IsTriggerWaitOnSleepsPrototype>();
            InternalNatives._GetFilterUnit = InternalNatives.Get("GetFilterUnit").ToDelegate<GetFilterUnitPrototype>();
            InternalNatives._GetEnumUnit = InternalNatives.Get("GetEnumUnit").ToDelegate<GetEnumUnitPrototype>();
            InternalNatives._GetFilterDestructable = InternalNatives.Get("GetFilterDestructable").ToDelegate<GetFilterDestructablePrototype>();
            InternalNatives._GetEnumDestructable = InternalNatives.Get("GetEnumDestructable").ToDelegate<GetEnumDestructablePrototype>();
            InternalNatives._GetFilterItem = InternalNatives.Get("GetFilterItem").ToDelegate<GetFilterItemPrototype>();
            InternalNatives._GetEnumItem = InternalNatives.Get("GetEnumItem").ToDelegate<GetEnumItemPrototype>();
            InternalNatives._GetFilterPlayer = InternalNatives.Get("GetFilterPlayer").ToDelegate<GetFilterPlayerPrototype>();
            InternalNatives._GetEnumPlayer = InternalNatives.Get("GetEnumPlayer").ToDelegate<GetEnumPlayerPrototype>();
            InternalNatives._GetTriggeringTrigger = InternalNatives.Get("GetTriggeringTrigger").ToDelegate<GetTriggeringTriggerPrototype>();
            InternalNatives._GetTriggerEventId = InternalNatives.Get("GetTriggerEventId").ToDelegate<GetTriggerEventIdPrototype>();
            InternalNatives._GetTriggerEvalCount = InternalNatives.Get("GetTriggerEvalCount").ToDelegate<GetTriggerEvalCountPrototype>();
            InternalNatives._GetTriggerExecCount = InternalNatives.Get("GetTriggerExecCount").ToDelegate<GetTriggerExecCountPrototype>();
            InternalNatives._ExecuteFunc = InternalNatives.Get("ExecuteFunc").ToDelegate<ExecuteFuncPrototype>();
            InternalNatives._And = InternalNatives.Get("And").ToDelegate<AndPrototype>();
            InternalNatives._Or = InternalNatives.Get("Or").ToDelegate<OrPrototype>();
            InternalNatives._Not = InternalNatives.Get("Not").ToDelegate<NotPrototype>();
            InternalNatives._Condition = InternalNatives.Get("Condition").ToDelegate<ConditionPrototype>();
            InternalNatives._DestroyCondition = InternalNatives.Get("DestroyCondition").ToDelegate<DestroyConditionPrototype>();
            InternalNatives._Filter = InternalNatives.Get("Filter").ToDelegate<FilterPrototype>();
            InternalNatives._DestroyFilter = InternalNatives.Get("DestroyFilter").ToDelegate<DestroyFilterPrototype>();
            InternalNatives._DestroyBoolExpr = InternalNatives.Get("DestroyBoolExpr").ToDelegate<DestroyBoolExprPrototype>();
            InternalNatives._TriggerRegisterVariableEvent = InternalNatives.Get("TriggerRegisterVariableEvent").ToDelegate<TriggerRegisterVariableEventPrototype>();
            InternalNatives._TriggerRegisterTimerEvent = InternalNatives.Get("TriggerRegisterTimerEvent").ToDelegate<TriggerRegisterTimerEventPrototype>();
            InternalNatives._TriggerRegisterTimerExpireEvent = InternalNatives.Get("TriggerRegisterTimerExpireEvent").ToDelegate<TriggerRegisterTimerExpireEventPrototype>();
            InternalNatives._TriggerRegisterGameStateEvent = InternalNatives.Get("TriggerRegisterGameStateEvent").ToDelegate<TriggerRegisterGameStateEventPrototype>();
            InternalNatives._TriggerRegisterDialogEvent = InternalNatives.Get("TriggerRegisterDialogEvent").ToDelegate<TriggerRegisterDialogEventPrototype>();
            InternalNatives._TriggerRegisterDialogButtonEvent = InternalNatives.Get("TriggerRegisterDialogButtonEvent").ToDelegate<TriggerRegisterDialogButtonEventPrototype>();
            InternalNatives._GetEventGameState = InternalNatives.Get("GetEventGameState").ToDelegate<GetEventGameStatePrototype>();
            InternalNatives._TriggerRegisterGameEvent = InternalNatives.Get("TriggerRegisterGameEvent").ToDelegate<TriggerRegisterGameEventPrototype>();
            InternalNatives._GetWinningPlayer = InternalNatives.Get("GetWinningPlayer").ToDelegate<GetWinningPlayerPrototype>();
            InternalNatives._TriggerRegisterEnterRegion = InternalNatives.Get("TriggerRegisterEnterRegion").ToDelegate<TriggerRegisterEnterRegionPrototype>();
            InternalNatives._GetTriggeringRegion = InternalNatives.Get("GetTriggeringRegion").ToDelegate<GetTriggeringRegionPrototype>();
            InternalNatives._GetEnteringUnit = InternalNatives.Get("GetEnteringUnit").ToDelegate<GetEnteringUnitPrototype>();
            InternalNatives._TriggerRegisterLeaveRegion = InternalNatives.Get("TriggerRegisterLeaveRegion").ToDelegate<TriggerRegisterLeaveRegionPrototype>();
            InternalNatives._GetLeavingUnit = InternalNatives.Get("GetLeavingUnit").ToDelegate<GetLeavingUnitPrototype>();
            InternalNatives._TriggerRegisterTrackableHitEvent = InternalNatives.Get("TriggerRegisterTrackableHitEvent").ToDelegate<TriggerRegisterTrackableHitEventPrototype>();
            InternalNatives._TriggerRegisterTrackableTrackEvent = InternalNatives.Get("TriggerRegisterTrackableTrackEvent").ToDelegate<TriggerRegisterTrackableTrackEventPrototype>();
            InternalNatives._GetTriggeringTrackable = InternalNatives.Get("GetTriggeringTrackable").ToDelegate<GetTriggeringTrackablePrototype>();
            InternalNatives._GetClickedButton = InternalNatives.Get("GetClickedButton").ToDelegate<GetClickedButtonPrototype>();
            InternalNatives._GetClickedDialog = InternalNatives.Get("GetClickedDialog").ToDelegate<GetClickedDialogPrototype>();
            InternalNatives._GetTournamentFinishSoonTimeRemaining = InternalNatives.Get("GetTournamentFinishSoonTimeRemaining").ToDelegate<GetTournamentFinishSoonTimeRemainingPrototype>();
            InternalNatives._GetTournamentFinishNowRule = InternalNatives.Get("GetTournamentFinishNowRule").ToDelegate<GetTournamentFinishNowRulePrototype>();
            InternalNatives._GetTournamentFinishNowPlayer = InternalNatives.Get("GetTournamentFinishNowPlayer").ToDelegate<GetTournamentFinishNowPlayerPrototype>();
            InternalNatives._GetTournamentScore = InternalNatives.Get("GetTournamentScore").ToDelegate<GetTournamentScorePrototype>();
            InternalNatives._GetSaveBasicFilename = InternalNatives.Get("GetSaveBasicFilename").ToDelegate<GetSaveBasicFilenamePrototype>();
            InternalNatives._TriggerRegisterPlayerEvent = InternalNatives.Get("TriggerRegisterPlayerEvent").ToDelegate<TriggerRegisterPlayerEventPrototype>();
            InternalNatives._GetTriggerPlayer = InternalNatives.Get("GetTriggerPlayer").ToDelegate<GetTriggerPlayerPrototype>();
            InternalNatives._TriggerRegisterPlayerUnitEvent = InternalNatives.Get("TriggerRegisterPlayerUnitEvent").ToDelegate<TriggerRegisterPlayerUnitEventPrototype>();
            InternalNatives._GetLevelingUnit = InternalNatives.Get("GetLevelingUnit").ToDelegate<GetLevelingUnitPrototype>();
            InternalNatives._GetLearningUnit = InternalNatives.Get("GetLearningUnit").ToDelegate<GetLearningUnitPrototype>();
            InternalNatives._GetLearnedSkill = InternalNatives.Get("GetLearnedSkill").ToDelegate<GetLearnedSkillPrototype>();
            InternalNatives._GetLearnedSkillLevel = InternalNatives.Get("GetLearnedSkillLevel").ToDelegate<GetLearnedSkillLevelPrototype>();
            InternalNatives._GetRevivableUnit = InternalNatives.Get("GetRevivableUnit").ToDelegate<GetRevivableUnitPrototype>();
            InternalNatives._GetRevivingUnit = InternalNatives.Get("GetRevivingUnit").ToDelegate<GetRevivingUnitPrototype>();
            InternalNatives._GetAttacker = InternalNatives.Get("GetAttacker").ToDelegate<GetAttackerPrototype>();
            InternalNatives._GetRescuer = InternalNatives.Get("GetRescuer").ToDelegate<GetRescuerPrototype>();
            InternalNatives._GetDyingUnit = InternalNatives.Get("GetDyingUnit").ToDelegate<GetDyingUnitPrototype>();
            InternalNatives._GetKillingUnit = InternalNatives.Get("GetKillingUnit").ToDelegate<GetKillingUnitPrototype>();
            InternalNatives._GetDecayingUnit = InternalNatives.Get("GetDecayingUnit").ToDelegate<GetDecayingUnitPrototype>();
            InternalNatives._GetConstructingStructure = InternalNatives.Get("GetConstructingStructure").ToDelegate<GetConstructingStructurePrototype>();
            InternalNatives._GetCancelledStructure = InternalNatives.Get("GetCancelledStructure").ToDelegate<GetCancelledStructurePrototype>();
            InternalNatives._GetConstructedStructure = InternalNatives.Get("GetConstructedStructure").ToDelegate<GetConstructedStructurePrototype>();
            InternalNatives._GetResearchingUnit = InternalNatives.Get("GetResearchingUnit").ToDelegate<GetResearchingUnitPrototype>();
            InternalNatives._GetResearched = InternalNatives.Get("GetResearched").ToDelegate<GetResearchedPrototype>();
            InternalNatives._GetTrainedUnitType = InternalNatives.Get("GetTrainedUnitType").ToDelegate<GetTrainedUnitTypePrototype>();
            InternalNatives._GetTrainedUnit = InternalNatives.Get("GetTrainedUnit").ToDelegate<GetTrainedUnitPrototype>();
            InternalNatives._GetDetectedUnit = InternalNatives.Get("GetDetectedUnit").ToDelegate<GetDetectedUnitPrototype>();
            InternalNatives._GetSummoningUnit = InternalNatives.Get("GetSummoningUnit").ToDelegate<GetSummoningUnitPrototype>();
            InternalNatives._GetSummonedUnit = InternalNatives.Get("GetSummonedUnit").ToDelegate<GetSummonedUnitPrototype>();
            InternalNatives._GetTransportUnit = InternalNatives.Get("GetTransportUnit").ToDelegate<GetTransportUnitPrototype>();
            InternalNatives._GetLoadedUnit = InternalNatives.Get("GetLoadedUnit").ToDelegate<GetLoadedUnitPrototype>();
            InternalNatives._GetSellingUnit = InternalNatives.Get("GetSellingUnit").ToDelegate<GetSellingUnitPrototype>();
            InternalNatives._GetSoldUnit = InternalNatives.Get("GetSoldUnit").ToDelegate<GetSoldUnitPrototype>();
            InternalNatives._GetBuyingUnit = InternalNatives.Get("GetBuyingUnit").ToDelegate<GetBuyingUnitPrototype>();
            InternalNatives._GetSoldItem = InternalNatives.Get("GetSoldItem").ToDelegate<GetSoldItemPrototype>();
            InternalNatives._GetChangingUnit = InternalNatives.Get("GetChangingUnit").ToDelegate<GetChangingUnitPrototype>();
            InternalNatives._GetChangingUnitPrevOwner = InternalNatives.Get("GetChangingUnitPrevOwner").ToDelegate<GetChangingUnitPrevOwnerPrototype>();
            InternalNatives._GetManipulatingUnit = InternalNatives.Get("GetManipulatingUnit").ToDelegate<GetManipulatingUnitPrototype>();
            InternalNatives._GetManipulatedItem = InternalNatives.Get("GetManipulatedItem").ToDelegate<GetManipulatedItemPrototype>();
            InternalNatives._GetOrderedUnit = InternalNatives.Get("GetOrderedUnit").ToDelegate<GetOrderedUnitPrototype>();
            InternalNatives._GetIssuedOrderId = InternalNatives.Get("GetIssuedOrderId").ToDelegate<GetIssuedOrderIdPrototype>();
            InternalNatives._GetOrderPointX = InternalNatives.Get("GetOrderPointX").ToDelegate<GetOrderPointXPrototype>();
            InternalNatives._GetOrderPointY = InternalNatives.Get("GetOrderPointY").ToDelegate<GetOrderPointYPrototype>();
            InternalNatives._GetOrderPointLoc = InternalNatives.Get("GetOrderPointLoc").ToDelegate<GetOrderPointLocPrototype>();
            InternalNatives._GetOrderTarget = InternalNatives.Get("GetOrderTarget").ToDelegate<GetOrderTargetPrototype>();
            InternalNatives._GetOrderTargetDestructable = InternalNatives.Get("GetOrderTargetDestructable").ToDelegate<GetOrderTargetDestructablePrototype>();
            InternalNatives._GetOrderTargetItem = InternalNatives.Get("GetOrderTargetItem").ToDelegate<GetOrderTargetItemPrototype>();
            InternalNatives._GetOrderTargetUnit = InternalNatives.Get("GetOrderTargetUnit").ToDelegate<GetOrderTargetUnitPrototype>();
            InternalNatives._GetSpellAbilityUnit = InternalNatives.Get("GetSpellAbilityUnit").ToDelegate<GetSpellAbilityUnitPrototype>();
            InternalNatives._GetSpellAbilityId = InternalNatives.Get("GetSpellAbilityId").ToDelegate<GetSpellAbilityIdPrototype>();
            InternalNatives._GetSpellAbility = InternalNatives.Get("GetSpellAbility").ToDelegate<GetSpellAbilityPrototype>();
            InternalNatives._GetSpellTargetLoc = InternalNatives.Get("GetSpellTargetLoc").ToDelegate<GetSpellTargetLocPrototype>();
            InternalNatives._GetSpellTargetX = InternalNatives.Get("GetSpellTargetX").ToDelegate<GetSpellTargetXPrototype>();
            InternalNatives._GetSpellTargetY = InternalNatives.Get("GetSpellTargetY").ToDelegate<GetSpellTargetYPrototype>();
            InternalNatives._GetSpellTargetDestructable = InternalNatives.Get("GetSpellTargetDestructable").ToDelegate<GetSpellTargetDestructablePrototype>();
            InternalNatives._GetSpellTargetItem = InternalNatives.Get("GetSpellTargetItem").ToDelegate<GetSpellTargetItemPrototype>();
            InternalNatives._GetSpellTargetUnit = InternalNatives.Get("GetSpellTargetUnit").ToDelegate<GetSpellTargetUnitPrototype>();
            InternalNatives._TriggerRegisterPlayerAllianceChange = InternalNatives.Get("TriggerRegisterPlayerAllianceChange").ToDelegate<TriggerRegisterPlayerAllianceChangePrototype>();
            InternalNatives._TriggerRegisterPlayerStateEvent = InternalNatives.Get("TriggerRegisterPlayerStateEvent").ToDelegate<TriggerRegisterPlayerStateEventPrototype>();
            InternalNatives._GetEventPlayerState = InternalNatives.Get("GetEventPlayerState").ToDelegate<GetEventPlayerStatePrototype>();
            InternalNatives._TriggerRegisterPlayerChatEvent = InternalNatives.Get("TriggerRegisterPlayerChatEvent").ToDelegate<TriggerRegisterPlayerChatEventPrototype>();
            InternalNatives._GetEventPlayerChatString = InternalNatives.Get("GetEventPlayerChatString").ToDelegate<GetEventPlayerChatStringPrototype>();
            InternalNatives._GetEventPlayerChatStringMatched = InternalNatives.Get("GetEventPlayerChatStringMatched").ToDelegate<GetEventPlayerChatStringMatchedPrototype>();
            InternalNatives._TriggerRegisterDeathEvent = InternalNatives.Get("TriggerRegisterDeathEvent").ToDelegate<TriggerRegisterDeathEventPrototype>();
            InternalNatives._GetTriggerUnit = InternalNatives.Get("GetTriggerUnit").ToDelegate<GetTriggerUnitPrototype>();
            InternalNatives._TriggerRegisterUnitStateEvent = InternalNatives.Get("TriggerRegisterUnitStateEvent").ToDelegate<TriggerRegisterUnitStateEventPrototype>();
            InternalNatives._GetEventUnitState = InternalNatives.Get("GetEventUnitState").ToDelegate<GetEventUnitStatePrototype>();
            InternalNatives._TriggerRegisterUnitEvent = InternalNatives.Get("TriggerRegisterUnitEvent").ToDelegate<TriggerRegisterUnitEventPrototype>();
            InternalNatives._GetEventDamage = InternalNatives.Get("GetEventDamage").ToDelegate<GetEventDamagePrototype>();
            InternalNatives._GetEventDamageSource = InternalNatives.Get("GetEventDamageSource").ToDelegate<GetEventDamageSourcePrototype>();
            InternalNatives._GetEventDetectingPlayer = InternalNatives.Get("GetEventDetectingPlayer").ToDelegate<GetEventDetectingPlayerPrototype>();
            InternalNatives._TriggerRegisterFilterUnitEvent = InternalNatives.Get("TriggerRegisterFilterUnitEvent").ToDelegate<TriggerRegisterFilterUnitEventPrototype>();
            InternalNatives._GetEventTargetUnit = InternalNatives.Get("GetEventTargetUnit").ToDelegate<GetEventTargetUnitPrototype>();
            InternalNatives._TriggerRegisterUnitInRange = InternalNatives.Get("TriggerRegisterUnitInRange").ToDelegate<TriggerRegisterUnitInRangePrototype>();
            InternalNatives._TriggerAddCondition = InternalNatives.Get("TriggerAddCondition").ToDelegate<TriggerAddConditionPrototype>();
            InternalNatives._TriggerRemoveCondition = InternalNatives.Get("TriggerRemoveCondition").ToDelegate<TriggerRemoveConditionPrototype>();
            InternalNatives._TriggerClearConditions = InternalNatives.Get("TriggerClearConditions").ToDelegate<TriggerClearConditionsPrototype>();
            InternalNatives._TriggerAddAction = InternalNatives.Get("TriggerAddAction").ToDelegate<TriggerAddActionPrototype>();
            InternalNatives._TriggerRemoveAction = InternalNatives.Get("TriggerRemoveAction").ToDelegate<TriggerRemoveActionPrototype>();
            InternalNatives._TriggerClearActions = InternalNatives.Get("TriggerClearActions").ToDelegate<TriggerClearActionsPrototype>();
            InternalNatives._TriggerSleepAction = InternalNatives.Get("TriggerSleepAction").ToDelegate<TriggerSleepActionPrototype>();
            InternalNatives._TriggerWaitForSound = InternalNatives.Get("TriggerWaitForSound").ToDelegate<TriggerWaitForSoundPrototype>();
            InternalNatives._TriggerEvaluate = InternalNatives.Get("TriggerEvaluate").ToDelegate<TriggerEvaluatePrototype>();
            InternalNatives._TriggerExecute = InternalNatives.Get("TriggerExecute").ToDelegate<TriggerExecutePrototype>();
            InternalNatives._TriggerExecuteWait = InternalNatives.Get("TriggerExecuteWait").ToDelegate<TriggerExecuteWaitPrototype>();
            InternalNatives._TriggerSyncStart = InternalNatives.Get("TriggerSyncStart").ToDelegate<TriggerSyncStartPrototype>();
            InternalNatives._TriggerSyncReady = InternalNatives.Get("TriggerSyncReady").ToDelegate<TriggerSyncReadyPrototype>();
            InternalNatives._GetWidgetLife = InternalNatives.Get("GetWidgetLife").ToDelegate<GetWidgetLifePrototype>();
            InternalNatives._SetWidgetLife = InternalNatives.Get("SetWidgetLife").ToDelegate<SetWidgetLifePrototype>();
            InternalNatives._GetWidgetX = InternalNatives.Get("GetWidgetX").ToDelegate<GetWidgetXPrototype>();
            InternalNatives._GetWidgetY = InternalNatives.Get("GetWidgetY").ToDelegate<GetWidgetYPrototype>();
            InternalNatives._GetTriggerWidget = InternalNatives.Get("GetTriggerWidget").ToDelegate<GetTriggerWidgetPrototype>();
            InternalNatives._CreateDestructable = InternalNatives.Get("CreateDestructable").ToDelegate<CreateDestructablePrototype>();
            InternalNatives._CreateDestructableZ = InternalNatives.Get("CreateDestructableZ").ToDelegate<CreateDestructableZPrototype>();
            InternalNatives._CreateDeadDestructable = InternalNatives.Get("CreateDeadDestructable").ToDelegate<CreateDeadDestructablePrototype>();
            InternalNatives._CreateDeadDestructableZ = InternalNatives.Get("CreateDeadDestructableZ").ToDelegate<CreateDeadDestructableZPrototype>();
            InternalNatives._RemoveDestructable = InternalNatives.Get("RemoveDestructable").ToDelegate<RemoveDestructablePrototype>();
            InternalNatives._KillDestructable = InternalNatives.Get("KillDestructable").ToDelegate<KillDestructablePrototype>();
            InternalNatives._SetDestructableInvulnerable = InternalNatives.Get("SetDestructableInvulnerable").ToDelegate<SetDestructableInvulnerablePrototype>();
            InternalNatives._IsDestructableInvulnerable = InternalNatives.Get("IsDestructableInvulnerable").ToDelegate<IsDestructableInvulnerablePrototype>();
            InternalNatives._EnumDestructablesInRect = InternalNatives.Get("EnumDestructablesInRect").ToDelegate<EnumDestructablesInRectPrototype>();
            InternalNatives._GetDestructableTypeId = InternalNatives.Get("GetDestructableTypeId").ToDelegate<GetDestructableTypeIdPrototype>();
            InternalNatives._GetDestructableX = InternalNatives.Get("GetDestructableX").ToDelegate<GetDestructableXPrototype>();
            InternalNatives._GetDestructableY = InternalNatives.Get("GetDestructableY").ToDelegate<GetDestructableYPrototype>();
            InternalNatives._SetDestructableLife = InternalNatives.Get("SetDestructableLife").ToDelegate<SetDestructableLifePrototype>();
            InternalNatives._GetDestructableLife = InternalNatives.Get("GetDestructableLife").ToDelegate<GetDestructableLifePrototype>();
            InternalNatives._SetDestructableMaxLife = InternalNatives.Get("SetDestructableMaxLife").ToDelegate<SetDestructableMaxLifePrototype>();
            InternalNatives._GetDestructableMaxLife = InternalNatives.Get("GetDestructableMaxLife").ToDelegate<GetDestructableMaxLifePrototype>();
            InternalNatives._DestructableRestoreLife = InternalNatives.Get("DestructableRestoreLife").ToDelegate<DestructableRestoreLifePrototype>();
            InternalNatives._QueueDestructableAnimation = InternalNatives.Get("QueueDestructableAnimation").ToDelegate<QueueDestructableAnimationPrototype>();
            InternalNatives._SetDestructableAnimation = InternalNatives.Get("SetDestructableAnimation").ToDelegate<SetDestructableAnimationPrototype>();
            InternalNatives._SetDestructableAnimationSpeed = InternalNatives.Get("SetDestructableAnimationSpeed").ToDelegate<SetDestructableAnimationSpeedPrototype>();
            InternalNatives._ShowDestructable = InternalNatives.Get("ShowDestructable").ToDelegate<ShowDestructablePrototype>();
            InternalNatives._GetDestructableOccluderHeight = InternalNatives.Get("GetDestructableOccluderHeight").ToDelegate<GetDestructableOccluderHeightPrototype>();
            InternalNatives._SetDestructableOccluderHeight = InternalNatives.Get("SetDestructableOccluderHeight").ToDelegate<SetDestructableOccluderHeightPrototype>();
            InternalNatives._GetDestructableName = InternalNatives.Get("GetDestructableName").ToDelegate<GetDestructableNamePrototype>();
            InternalNatives._GetTriggerDestructable = InternalNatives.Get("GetTriggerDestructable").ToDelegate<GetTriggerDestructablePrototype>();
            InternalNatives._CreateItem = InternalNatives.Get("CreateItem").ToDelegate<CreateItemPrototype>();
            InternalNatives._RemoveItem = InternalNatives.Get("RemoveItem").ToDelegate<RemoveItemPrototype>();
            InternalNatives._GetItemPlayer = InternalNatives.Get("GetItemPlayer").ToDelegate<GetItemPlayerPrototype>();
            InternalNatives._GetItemTypeId = InternalNatives.Get("GetItemTypeId").ToDelegate<GetItemTypeIdPrototype>();
            InternalNatives._GetItemX = InternalNatives.Get("GetItemX").ToDelegate<GetItemXPrototype>();
            InternalNatives._GetItemY = InternalNatives.Get("GetItemY").ToDelegate<GetItemYPrototype>();
            InternalNatives._SetItemPosition = InternalNatives.Get("SetItemPosition").ToDelegate<SetItemPositionPrototype>();
            InternalNatives._SetItemDropOnDeath = InternalNatives.Get("SetItemDropOnDeath").ToDelegate<SetItemDropOnDeathPrototype>();
            InternalNatives._SetItemDroppable = InternalNatives.Get("SetItemDroppable").ToDelegate<SetItemDroppablePrototype>();
            InternalNatives._SetItemPawnable = InternalNatives.Get("SetItemPawnable").ToDelegate<SetItemPawnablePrototype>();
            InternalNatives._SetItemPlayer = InternalNatives.Get("SetItemPlayer").ToDelegate<SetItemPlayerPrototype>();
            InternalNatives._SetItemInvulnerable = InternalNatives.Get("SetItemInvulnerable").ToDelegate<SetItemInvulnerablePrototype>();
            InternalNatives._IsItemInvulnerable = InternalNatives.Get("IsItemInvulnerable").ToDelegate<IsItemInvulnerablePrototype>();
            InternalNatives._SetItemVisible = InternalNatives.Get("SetItemVisible").ToDelegate<SetItemVisiblePrototype>();
            InternalNatives._IsItemVisible = InternalNatives.Get("IsItemVisible").ToDelegate<IsItemVisiblePrototype>();
            InternalNatives._IsItemOwned = InternalNatives.Get("IsItemOwned").ToDelegate<IsItemOwnedPrototype>();
            InternalNatives._IsItemPowerup = InternalNatives.Get("IsItemPowerup").ToDelegate<IsItemPowerupPrototype>();
            InternalNatives._IsItemSellable = InternalNatives.Get("IsItemSellable").ToDelegate<IsItemSellablePrototype>();
            InternalNatives._IsItemPawnable = InternalNatives.Get("IsItemPawnable").ToDelegate<IsItemPawnablePrototype>();
            InternalNatives._IsItemIdPowerup = InternalNatives.Get("IsItemIdPowerup").ToDelegate<IsItemIdPowerupPrototype>();
            InternalNatives._IsItemIdSellable = InternalNatives.Get("IsItemIdSellable").ToDelegate<IsItemIdSellablePrototype>();
            InternalNatives._IsItemIdPawnable = InternalNatives.Get("IsItemIdPawnable").ToDelegate<IsItemIdPawnablePrototype>();
            InternalNatives._EnumItemsInRect = InternalNatives.Get("EnumItemsInRect").ToDelegate<EnumItemsInRectPrototype>();
            InternalNatives._GetItemLevel = InternalNatives.Get("GetItemLevel").ToDelegate<GetItemLevelPrototype>();
            InternalNatives._GetItemType = InternalNatives.Get("GetItemType").ToDelegate<GetItemTypePrototype>();
            InternalNatives._SetItemDropID = InternalNatives.Get("SetItemDropID").ToDelegate<SetItemDropIDPrototype>();
            InternalNatives._GetItemName = InternalNatives.Get("GetItemName").ToDelegate<GetItemNamePrototype>();
            InternalNatives._GetItemCharges = InternalNatives.Get("GetItemCharges").ToDelegate<GetItemChargesPrototype>();
            InternalNatives._SetItemCharges = InternalNatives.Get("SetItemCharges").ToDelegate<SetItemChargesPrototype>();
            InternalNatives._GetItemUserData = InternalNatives.Get("GetItemUserData").ToDelegate<GetItemUserDataPrototype>();
            InternalNatives._SetItemUserData = InternalNatives.Get("SetItemUserData").ToDelegate<SetItemUserDataPrototype>();
            InternalNatives._CreateUnit = InternalNatives.Get("CreateUnit").ToDelegate<CreateUnitPrototype>();
            InternalNatives._CreateUnitByName = InternalNatives.Get("CreateUnitByName").ToDelegate<CreateUnitByNamePrototype>();
            InternalNatives._CreateUnitAtLoc = InternalNatives.Get("CreateUnitAtLoc").ToDelegate<CreateUnitAtLocPrototype>();
            InternalNatives._CreateUnitAtLocByName = InternalNatives.Get("CreateUnitAtLocByName").ToDelegate<CreateUnitAtLocByNamePrototype>();
            InternalNatives._CreateCorpse = InternalNatives.Get("CreateCorpse").ToDelegate<CreateCorpsePrototype>();
            InternalNatives._KillUnit = InternalNatives.Get("KillUnit").ToDelegate<KillUnitPrototype>();
            InternalNatives._RemoveUnit = InternalNatives.Get("RemoveUnit").ToDelegate<RemoveUnitPrototype>();
            InternalNatives._ShowUnit = InternalNatives.Get("ShowUnit").ToDelegate<ShowUnitPrototype>();
            InternalNatives._SetUnitState = InternalNatives.Get("SetUnitState").ToDelegate<SetUnitStatePrototype>();
            InternalNatives._SetUnitX = InternalNatives.Get("SetUnitX").ToDelegate<SetUnitXPrototype>();
            InternalNatives._SetUnitY = InternalNatives.Get("SetUnitY").ToDelegate<SetUnitYPrototype>();
            InternalNatives._SetUnitPosition = InternalNatives.Get("SetUnitPosition").ToDelegate<SetUnitPositionPrototype>();
            InternalNatives._SetUnitPositionLoc = InternalNatives.Get("SetUnitPositionLoc").ToDelegate<SetUnitPositionLocPrototype>();
            InternalNatives._SetUnitFacing = InternalNatives.Get("SetUnitFacing").ToDelegate<SetUnitFacingPrototype>();
            InternalNatives._SetUnitFacingTimed = InternalNatives.Get("SetUnitFacingTimed").ToDelegate<SetUnitFacingTimedPrototype>();
            InternalNatives._SetUnitMoveSpeed = InternalNatives.Get("SetUnitMoveSpeed").ToDelegate<SetUnitMoveSpeedPrototype>();
            InternalNatives._SetUnitFlyHeight = InternalNatives.Get("SetUnitFlyHeight").ToDelegate<SetUnitFlyHeightPrototype>();
            InternalNatives._SetUnitTurnSpeed = InternalNatives.Get("SetUnitTurnSpeed").ToDelegate<SetUnitTurnSpeedPrototype>();
            InternalNatives._SetUnitPropWindow = InternalNatives.Get("SetUnitPropWindow").ToDelegate<SetUnitPropWindowPrototype>();
            InternalNatives._SetUnitAcquireRange = InternalNatives.Get("SetUnitAcquireRange").ToDelegate<SetUnitAcquireRangePrototype>();
            InternalNatives._SetUnitCreepGuard = InternalNatives.Get("SetUnitCreepGuard").ToDelegate<SetUnitCreepGuardPrototype>();
            InternalNatives._GetUnitAcquireRange = InternalNatives.Get("GetUnitAcquireRange").ToDelegate<GetUnitAcquireRangePrototype>();
            InternalNatives._GetUnitTurnSpeed = InternalNatives.Get("GetUnitTurnSpeed").ToDelegate<GetUnitTurnSpeedPrototype>();
            InternalNatives._GetUnitPropWindow = InternalNatives.Get("GetUnitPropWindow").ToDelegate<GetUnitPropWindowPrototype>();
            InternalNatives._GetUnitFlyHeight = InternalNatives.Get("GetUnitFlyHeight").ToDelegate<GetUnitFlyHeightPrototype>();
            InternalNatives._GetUnitDefaultAcquireRange = InternalNatives.Get("GetUnitDefaultAcquireRange").ToDelegate<GetUnitDefaultAcquireRangePrototype>();
            InternalNatives._GetUnitDefaultTurnSpeed = InternalNatives.Get("GetUnitDefaultTurnSpeed").ToDelegate<GetUnitDefaultTurnSpeedPrototype>();
            InternalNatives._GetUnitDefaultPropWindow = InternalNatives.Get("GetUnitDefaultPropWindow").ToDelegate<GetUnitDefaultPropWindowPrototype>();
            InternalNatives._GetUnitDefaultFlyHeight = InternalNatives.Get("GetUnitDefaultFlyHeight").ToDelegate<GetUnitDefaultFlyHeightPrototype>();
            InternalNatives._SetUnitOwner = InternalNatives.Get("SetUnitOwner").ToDelegate<SetUnitOwnerPrototype>();
            InternalNatives._SetUnitColor = InternalNatives.Get("SetUnitColor").ToDelegate<SetUnitColorPrototype>();
            InternalNatives._SetUnitScale = InternalNatives.Get("SetUnitScale").ToDelegate<SetUnitScalePrototype>();
            InternalNatives._SetUnitTimeScale = InternalNatives.Get("SetUnitTimeScale").ToDelegate<SetUnitTimeScalePrototype>();
            InternalNatives._SetUnitBlendTime = InternalNatives.Get("SetUnitBlendTime").ToDelegate<SetUnitBlendTimePrototype>();
            InternalNatives._SetUnitVertexColor = InternalNatives.Get("SetUnitVertexColor").ToDelegate<SetUnitVertexColorPrototype>();
            InternalNatives._QueueUnitAnimation = InternalNatives.Get("QueueUnitAnimation").ToDelegate<QueueUnitAnimationPrototype>();
            InternalNatives._SetUnitAnimation = InternalNatives.Get("SetUnitAnimation").ToDelegate<SetUnitAnimationPrototype>();
            InternalNatives._SetUnitAnimationByIndex = InternalNatives.Get("SetUnitAnimationByIndex").ToDelegate<SetUnitAnimationByIndexPrototype>();
            InternalNatives._SetUnitAnimationWithRarity = InternalNatives.Get("SetUnitAnimationWithRarity").ToDelegate<SetUnitAnimationWithRarityPrototype>();
            InternalNatives._AddUnitAnimationProperties = InternalNatives.Get("AddUnitAnimationProperties").ToDelegate<AddUnitAnimationPropertiesPrototype>();
            InternalNatives._SetUnitLookAt = InternalNatives.Get("SetUnitLookAt").ToDelegate<SetUnitLookAtPrototype>();
            InternalNatives._ResetUnitLookAt = InternalNatives.Get("ResetUnitLookAt").ToDelegate<ResetUnitLookAtPrototype>();
            InternalNatives._SetUnitRescuable = InternalNatives.Get("SetUnitRescuable").ToDelegate<SetUnitRescuablePrototype>();
            InternalNatives._SetUnitRescueRange = InternalNatives.Get("SetUnitRescueRange").ToDelegate<SetUnitRescueRangePrototype>();
            InternalNatives._SetHeroStr = InternalNatives.Get("SetHeroStr").ToDelegate<SetHeroStrPrototype>();
            InternalNatives._SetHeroAgi = InternalNatives.Get("SetHeroAgi").ToDelegate<SetHeroAgiPrototype>();
            InternalNatives._SetHeroInt = InternalNatives.Get("SetHeroInt").ToDelegate<SetHeroIntPrototype>();
            InternalNatives._GetHeroStr = InternalNatives.Get("GetHeroStr").ToDelegate<GetHeroStrPrototype>();
            InternalNatives._GetHeroAgi = InternalNatives.Get("GetHeroAgi").ToDelegate<GetHeroAgiPrototype>();
            InternalNatives._GetHeroInt = InternalNatives.Get("GetHeroInt").ToDelegate<GetHeroIntPrototype>();
            InternalNatives._UnitStripHeroLevel = InternalNatives.Get("UnitStripHeroLevel").ToDelegate<UnitStripHeroLevelPrototype>();
            InternalNatives._GetHeroXP = InternalNatives.Get("GetHeroXP").ToDelegate<GetHeroXPPrototype>();
            InternalNatives._SetHeroXP = InternalNatives.Get("SetHeroXP").ToDelegate<SetHeroXPPrototype>();
            InternalNatives._GetHeroSkillPoints = InternalNatives.Get("GetHeroSkillPoints").ToDelegate<GetHeroSkillPointsPrototype>();
            InternalNatives._UnitModifySkillPoints = InternalNatives.Get("UnitModifySkillPoints").ToDelegate<UnitModifySkillPointsPrototype>();
            InternalNatives._AddHeroXP = InternalNatives.Get("AddHeroXP").ToDelegate<AddHeroXPPrototype>();
            InternalNatives._SetHeroLevel = InternalNatives.Get("SetHeroLevel").ToDelegate<SetHeroLevelPrototype>();
            InternalNatives._GetHeroLevel = InternalNatives.Get("GetHeroLevel").ToDelegate<GetHeroLevelPrototype>();
            InternalNatives._GetUnitLevel = InternalNatives.Get("GetUnitLevel").ToDelegate<GetUnitLevelPrototype>();
            InternalNatives._GetHeroProperName = InternalNatives.Get("GetHeroProperName").ToDelegate<GetHeroProperNamePrototype>();
            InternalNatives._SuspendHeroXP = InternalNatives.Get("SuspendHeroXP").ToDelegate<SuspendHeroXPPrototype>();
            InternalNatives._IsSuspendedXP = InternalNatives.Get("IsSuspendedXP").ToDelegate<IsSuspendedXPPrototype>();
            InternalNatives._SelectHeroSkill = InternalNatives.Get("SelectHeroSkill").ToDelegate<SelectHeroSkillPrototype>();
            InternalNatives._GetUnitAbilityLevel = InternalNatives.Get("GetUnitAbilityLevel").ToDelegate<GetUnitAbilityLevelPrototype>();
            InternalNatives._DecUnitAbilityLevel = InternalNatives.Get("DecUnitAbilityLevel").ToDelegate<DecUnitAbilityLevelPrototype>();
            InternalNatives._IncUnitAbilityLevel = InternalNatives.Get("IncUnitAbilityLevel").ToDelegate<IncUnitAbilityLevelPrototype>();
            InternalNatives._SetUnitAbilityLevel = InternalNatives.Get("SetUnitAbilityLevel").ToDelegate<SetUnitAbilityLevelPrototype>();
            InternalNatives._ReviveHero = InternalNatives.Get("ReviveHero").ToDelegate<ReviveHeroPrototype>();
            InternalNatives._ReviveHeroLoc = InternalNatives.Get("ReviveHeroLoc").ToDelegate<ReviveHeroLocPrototype>();
            InternalNatives._SetUnitExploded = InternalNatives.Get("SetUnitExploded").ToDelegate<SetUnitExplodedPrototype>();
            InternalNatives._SetUnitInvulnerable = InternalNatives.Get("SetUnitInvulnerable").ToDelegate<SetUnitInvulnerablePrototype>();
            InternalNatives._PauseUnit = InternalNatives.Get("PauseUnit").ToDelegate<PauseUnitPrototype>();
            InternalNatives._IsUnitPaused = InternalNatives.Get("IsUnitPaused").ToDelegate<IsUnitPausedPrototype>();
            InternalNatives._SetUnitPathing = InternalNatives.Get("SetUnitPathing").ToDelegate<SetUnitPathingPrototype>();
            InternalNatives._ClearSelection = InternalNatives.Get("ClearSelection").ToDelegate<ClearSelectionPrototype>();
            InternalNatives._SelectUnit = InternalNatives.Get("SelectUnit").ToDelegate<SelectUnitPrototype>();
            InternalNatives._GetUnitPointValue = InternalNatives.Get("GetUnitPointValue").ToDelegate<GetUnitPointValuePrototype>();
            InternalNatives._GetUnitPointValueByType = InternalNatives.Get("GetUnitPointValueByType").ToDelegate<GetUnitPointValueByTypePrototype>();
            InternalNatives._UnitAddItem = InternalNatives.Get("UnitAddItem").ToDelegate<UnitAddItemPrototype>();
            InternalNatives._UnitAddItemById = InternalNatives.Get("UnitAddItemById").ToDelegate<UnitAddItemByIdPrototype>();
            InternalNatives._UnitAddItemToSlotById = InternalNatives.Get("UnitAddItemToSlotById").ToDelegate<UnitAddItemToSlotByIdPrototype>();
            InternalNatives._UnitRemoveItem = InternalNatives.Get("UnitRemoveItem").ToDelegate<UnitRemoveItemPrototype>();
            InternalNatives._UnitRemoveItemFromSlot = InternalNatives.Get("UnitRemoveItemFromSlot").ToDelegate<UnitRemoveItemFromSlotPrototype>();
            InternalNatives._UnitHasItem = InternalNatives.Get("UnitHasItem").ToDelegate<UnitHasItemPrototype>();
            InternalNatives._UnitItemInSlot = InternalNatives.Get("UnitItemInSlot").ToDelegate<UnitItemInSlotPrototype>();
            InternalNatives._UnitInventorySize = InternalNatives.Get("UnitInventorySize").ToDelegate<UnitInventorySizePrototype>();
            InternalNatives._UnitDropItemPoint = InternalNatives.Get("UnitDropItemPoint").ToDelegate<UnitDropItemPointPrototype>();
            InternalNatives._UnitDropItemSlot = InternalNatives.Get("UnitDropItemSlot").ToDelegate<UnitDropItemSlotPrototype>();
            InternalNatives._UnitDropItemTarget = InternalNatives.Get("UnitDropItemTarget").ToDelegate<UnitDropItemTargetPrototype>();
            InternalNatives._UnitUseItem = InternalNatives.Get("UnitUseItem").ToDelegate<UnitUseItemPrototype>();
            InternalNatives._UnitUseItemPoint = InternalNatives.Get("UnitUseItemPoint").ToDelegate<UnitUseItemPointPrototype>();
            InternalNatives._UnitUseItemTarget = InternalNatives.Get("UnitUseItemTarget").ToDelegate<UnitUseItemTargetPrototype>();
            InternalNatives._GetUnitX = InternalNatives.Get("GetUnitX").ToDelegate<GetUnitXPrototype>();
            InternalNatives._GetUnitY = InternalNatives.Get("GetUnitY").ToDelegate<GetUnitYPrototype>();
            InternalNatives._GetUnitLoc = InternalNatives.Get("GetUnitLoc").ToDelegate<GetUnitLocPrototype>();
            InternalNatives._GetUnitFacing = InternalNatives.Get("GetUnitFacing").ToDelegate<GetUnitFacingPrototype>();
            InternalNatives._GetUnitMoveSpeed = InternalNatives.Get("GetUnitMoveSpeed").ToDelegate<GetUnitMoveSpeedPrototype>();
            InternalNatives._GetUnitDefaultMoveSpeed = InternalNatives.Get("GetUnitDefaultMoveSpeed").ToDelegate<GetUnitDefaultMoveSpeedPrototype>();
            InternalNatives._GetUnitState = InternalNatives.Get("GetUnitState").ToDelegate<GetUnitStatePrototype>();
            InternalNatives._GetOwningPlayer = InternalNatives.Get("GetOwningPlayer").ToDelegate<GetOwningPlayerPrototype>();
            InternalNatives._GetUnitTypeId = InternalNatives.Get("GetUnitTypeId").ToDelegate<GetUnitTypeIdPrototype>();
            InternalNatives._GetUnitRace = InternalNatives.Get("GetUnitRace").ToDelegate<GetUnitRacePrototype>();
            InternalNatives._GetUnitName = InternalNatives.Get("GetUnitName").ToDelegate<GetUnitNamePrototype>();
            InternalNatives._GetUnitFoodUsed = InternalNatives.Get("GetUnitFoodUsed").ToDelegate<GetUnitFoodUsedPrototype>();
            InternalNatives._GetUnitFoodMade = InternalNatives.Get("GetUnitFoodMade").ToDelegate<GetUnitFoodMadePrototype>();
            InternalNatives._GetFoodMade = InternalNatives.Get("GetFoodMade").ToDelegate<GetFoodMadePrototype>();
            InternalNatives._GetFoodUsed = InternalNatives.Get("GetFoodUsed").ToDelegate<GetFoodUsedPrototype>();
            InternalNatives._SetUnitUseFood = InternalNatives.Get("SetUnitUseFood").ToDelegate<SetUnitUseFoodPrototype>();
            InternalNatives._GetUnitRallyPoint = InternalNatives.Get("GetUnitRallyPoint").ToDelegate<GetUnitRallyPointPrototype>();
            InternalNatives._GetUnitRallyUnit = InternalNatives.Get("GetUnitRallyUnit").ToDelegate<GetUnitRallyUnitPrototype>();
            InternalNatives._GetUnitRallyDestructable = InternalNatives.Get("GetUnitRallyDestructable").ToDelegate<GetUnitRallyDestructablePrototype>();
            InternalNatives._IsUnitInGroup = InternalNatives.Get("IsUnitInGroup").ToDelegate<IsUnitInGroupPrototype>();
            InternalNatives._IsUnitInForce = InternalNatives.Get("IsUnitInForce").ToDelegate<IsUnitInForcePrototype>();
            InternalNatives._IsUnitOwnedByPlayer = InternalNatives.Get("IsUnitOwnedByPlayer").ToDelegate<IsUnitOwnedByPlayerPrototype>();
            InternalNatives._IsUnitAlly = InternalNatives.Get("IsUnitAlly").ToDelegate<IsUnitAllyPrototype>();
            InternalNatives._IsUnitEnemy = InternalNatives.Get("IsUnitEnemy").ToDelegate<IsUnitEnemyPrototype>();
            InternalNatives._IsUnitVisible = InternalNatives.Get("IsUnitVisible").ToDelegate<IsUnitVisiblePrototype>();
            InternalNatives._IsUnitDetected = InternalNatives.Get("IsUnitDetected").ToDelegate<IsUnitDetectedPrototype>();
            InternalNatives._IsUnitInvisible = InternalNatives.Get("IsUnitInvisible").ToDelegate<IsUnitInvisiblePrototype>();
            InternalNatives._IsUnitFogged = InternalNatives.Get("IsUnitFogged").ToDelegate<IsUnitFoggedPrototype>();
            InternalNatives._IsUnitMasked = InternalNatives.Get("IsUnitMasked").ToDelegate<IsUnitMaskedPrototype>();
            InternalNatives._IsUnitSelected = InternalNatives.Get("IsUnitSelected").ToDelegate<IsUnitSelectedPrototype>();
            InternalNatives._IsUnitRace = InternalNatives.Get("IsUnitRace").ToDelegate<IsUnitRacePrototype>();
            InternalNatives._IsUnitType = InternalNatives.Get("IsUnitType").ToDelegate<IsUnitTypePrototype>();
            InternalNatives._IsUnit = InternalNatives.Get("IsUnit").ToDelegate<IsUnitPrototype>();
            InternalNatives._IsUnitInRange = InternalNatives.Get("IsUnitInRange").ToDelegate<IsUnitInRangePrototype>();
            InternalNatives._IsUnitInRangeXY = InternalNatives.Get("IsUnitInRangeXY").ToDelegate<IsUnitInRangeXYPrototype>();
            InternalNatives._IsUnitInRangeLoc = InternalNatives.Get("IsUnitInRangeLoc").ToDelegate<IsUnitInRangeLocPrototype>();
            InternalNatives._IsUnitHidden = InternalNatives.Get("IsUnitHidden").ToDelegate<IsUnitHiddenPrototype>();
            InternalNatives._IsUnitIllusion = InternalNatives.Get("IsUnitIllusion").ToDelegate<IsUnitIllusionPrototype>();
            InternalNatives._IsUnitInTransport = InternalNatives.Get("IsUnitInTransport").ToDelegate<IsUnitInTransportPrototype>();
            InternalNatives._IsUnitLoaded = InternalNatives.Get("IsUnitLoaded").ToDelegate<IsUnitLoadedPrototype>();
            InternalNatives._IsHeroUnitId = InternalNatives.Get("IsHeroUnitId").ToDelegate<IsHeroUnitIdPrototype>();
            InternalNatives._IsUnitIdType = InternalNatives.Get("IsUnitIdType").ToDelegate<IsUnitIdTypePrototype>();
            InternalNatives._UnitShareVision = InternalNatives.Get("UnitShareVision").ToDelegate<UnitShareVisionPrototype>();
            InternalNatives._UnitSuspendDecay = InternalNatives.Get("UnitSuspendDecay").ToDelegate<UnitSuspendDecayPrototype>();
            InternalNatives._UnitAddType = InternalNatives.Get("UnitAddType").ToDelegate<UnitAddTypePrototype>();
            InternalNatives._UnitRemoveType = InternalNatives.Get("UnitRemoveType").ToDelegate<UnitRemoveTypePrototype>();
            InternalNatives._UnitAddAbility = InternalNatives.Get("UnitAddAbility").ToDelegate<UnitAddAbilityPrototype>();
            InternalNatives._UnitRemoveAbility = InternalNatives.Get("UnitRemoveAbility").ToDelegate<UnitRemoveAbilityPrototype>();
            InternalNatives._UnitMakeAbilityPermanent = InternalNatives.Get("UnitMakeAbilityPermanent").ToDelegate<UnitMakeAbilityPermanentPrototype>();
            InternalNatives._UnitRemoveBuffs = InternalNatives.Get("UnitRemoveBuffs").ToDelegate<UnitRemoveBuffsPrototype>();
            InternalNatives._UnitRemoveBuffsEx = InternalNatives.Get("UnitRemoveBuffsEx").ToDelegate<UnitRemoveBuffsExPrototype>();
            InternalNatives._UnitHasBuffsEx = InternalNatives.Get("UnitHasBuffsEx").ToDelegate<UnitHasBuffsExPrototype>();
            InternalNatives._UnitCountBuffsEx = InternalNatives.Get("UnitCountBuffsEx").ToDelegate<UnitCountBuffsExPrototype>();
            InternalNatives._UnitAddSleep = InternalNatives.Get("UnitAddSleep").ToDelegate<UnitAddSleepPrototype>();
            InternalNatives._UnitCanSleep = InternalNatives.Get("UnitCanSleep").ToDelegate<UnitCanSleepPrototype>();
            InternalNatives._UnitAddSleepPerm = InternalNatives.Get("UnitAddSleepPerm").ToDelegate<UnitAddSleepPermPrototype>();
            InternalNatives._UnitCanSleepPerm = InternalNatives.Get("UnitCanSleepPerm").ToDelegate<UnitCanSleepPermPrototype>();
            InternalNatives._UnitIsSleeping = InternalNatives.Get("UnitIsSleeping").ToDelegate<UnitIsSleepingPrototype>();
            InternalNatives._UnitWakeUp = InternalNatives.Get("UnitWakeUp").ToDelegate<UnitWakeUpPrototype>();
            InternalNatives._UnitApplyTimedLife = InternalNatives.Get("UnitApplyTimedLife").ToDelegate<UnitApplyTimedLifePrototype>();
            InternalNatives._UnitIgnoreAlarm = InternalNatives.Get("UnitIgnoreAlarm").ToDelegate<UnitIgnoreAlarmPrototype>();
            InternalNatives._UnitIgnoreAlarmToggled = InternalNatives.Get("UnitIgnoreAlarmToggled").ToDelegate<UnitIgnoreAlarmToggledPrototype>();
            InternalNatives._UnitResetCooldown = InternalNatives.Get("UnitResetCooldown").ToDelegate<UnitResetCooldownPrototype>();
            InternalNatives._UnitSetConstructionProgress = InternalNatives.Get("UnitSetConstructionProgress").ToDelegate<UnitSetConstructionProgressPrototype>();
            InternalNatives._UnitSetUpgradeProgress = InternalNatives.Get("UnitSetUpgradeProgress").ToDelegate<UnitSetUpgradeProgressPrototype>();
            InternalNatives._UnitPauseTimedLife = InternalNatives.Get("UnitPauseTimedLife").ToDelegate<UnitPauseTimedLifePrototype>();
            InternalNatives._UnitSetUsesAltIcon = InternalNatives.Get("UnitSetUsesAltIcon").ToDelegate<UnitSetUsesAltIconPrototype>();
            InternalNatives._UnitDamagePoint = InternalNatives.Get("UnitDamagePoint").ToDelegate<UnitDamagePointPrototype>();
            InternalNatives._UnitDamageTarget = InternalNatives.Get("UnitDamageTarget").ToDelegate<UnitDamageTargetPrototype>();
            InternalNatives._IssueImmediateOrder = InternalNatives.Get("IssueImmediateOrder").ToDelegate<IssueImmediateOrderPrototype>();
            InternalNatives._IssueImmediateOrderById = InternalNatives.Get("IssueImmediateOrderById").ToDelegate<IssueImmediateOrderByIdPrototype>();
            InternalNatives._IssuePointOrder = InternalNatives.Get("IssuePointOrder").ToDelegate<IssuePointOrderPrototype>();
            InternalNatives._IssuePointOrderLoc = InternalNatives.Get("IssuePointOrderLoc").ToDelegate<IssuePointOrderLocPrototype>();
            InternalNatives._IssuePointOrderById = InternalNatives.Get("IssuePointOrderById").ToDelegate<IssuePointOrderByIdPrototype>();
            InternalNatives._IssuePointOrderByIdLoc = InternalNatives.Get("IssuePointOrderByIdLoc").ToDelegate<IssuePointOrderByIdLocPrototype>();
            InternalNatives._IssueTargetOrder = InternalNatives.Get("IssueTargetOrder").ToDelegate<IssueTargetOrderPrototype>();
            InternalNatives._IssueTargetOrderById = InternalNatives.Get("IssueTargetOrderById").ToDelegate<IssueTargetOrderByIdPrototype>();
            InternalNatives._IssueInstantPointOrder = InternalNatives.Get("IssueInstantPointOrder").ToDelegate<IssueInstantPointOrderPrototype>();
            InternalNatives._IssueInstantPointOrderById = InternalNatives.Get("IssueInstantPointOrderById").ToDelegate<IssueInstantPointOrderByIdPrototype>();
            InternalNatives._IssueInstantTargetOrder = InternalNatives.Get("IssueInstantTargetOrder").ToDelegate<IssueInstantTargetOrderPrototype>();
            InternalNatives._IssueInstantTargetOrderById = InternalNatives.Get("IssueInstantTargetOrderById").ToDelegate<IssueInstantTargetOrderByIdPrototype>();
            InternalNatives._IssueBuildOrder = InternalNatives.Get("IssueBuildOrder").ToDelegate<IssueBuildOrderPrototype>();
            InternalNatives._IssueBuildOrderById = InternalNatives.Get("IssueBuildOrderById").ToDelegate<IssueBuildOrderByIdPrototype>();
            InternalNatives._IssueNeutralImmediateOrder = InternalNatives.Get("IssueNeutralImmediateOrder").ToDelegate<IssueNeutralImmediateOrderPrototype>();
            InternalNatives._IssueNeutralImmediateOrderById = InternalNatives.Get("IssueNeutralImmediateOrderById").ToDelegate<IssueNeutralImmediateOrderByIdPrototype>();
            InternalNatives._IssueNeutralPointOrder = InternalNatives.Get("IssueNeutralPointOrder").ToDelegate<IssueNeutralPointOrderPrototype>();
            InternalNatives._IssueNeutralPointOrderById = InternalNatives.Get("IssueNeutralPointOrderById").ToDelegate<IssueNeutralPointOrderByIdPrototype>();
            InternalNatives._IssueNeutralTargetOrder = InternalNatives.Get("IssueNeutralTargetOrder").ToDelegate<IssueNeutralTargetOrderPrototype>();
            InternalNatives._IssueNeutralTargetOrderById = InternalNatives.Get("IssueNeutralTargetOrderById").ToDelegate<IssueNeutralTargetOrderByIdPrototype>();
            InternalNatives._GetUnitCurrentOrder = InternalNatives.Get("GetUnitCurrentOrder").ToDelegate<GetUnitCurrentOrderPrototype>();
            InternalNatives._SetResourceAmount = InternalNatives.Get("SetResourceAmount").ToDelegate<SetResourceAmountPrototype>();
            InternalNatives._AddResourceAmount = InternalNatives.Get("AddResourceAmount").ToDelegate<AddResourceAmountPrototype>();
            InternalNatives._GetResourceAmount = InternalNatives.Get("GetResourceAmount").ToDelegate<GetResourceAmountPrototype>();
            InternalNatives._WaygateGetDestinationX = InternalNatives.Get("WaygateGetDestinationX").ToDelegate<WaygateGetDestinationXPrototype>();
            InternalNatives._WaygateGetDestinationY = InternalNatives.Get("WaygateGetDestinationY").ToDelegate<WaygateGetDestinationYPrototype>();
            InternalNatives._WaygateSetDestination = InternalNatives.Get("WaygateSetDestination").ToDelegate<WaygateSetDestinationPrototype>();
            InternalNatives._WaygateActivate = InternalNatives.Get("WaygateActivate").ToDelegate<WaygateActivatePrototype>();
            InternalNatives._WaygateIsActive = InternalNatives.Get("WaygateIsActive").ToDelegate<WaygateIsActivePrototype>();
            InternalNatives._AddItemToAllStock = InternalNatives.Get("AddItemToAllStock").ToDelegate<AddItemToAllStockPrototype>();
            InternalNatives._AddItemToStock = InternalNatives.Get("AddItemToStock").ToDelegate<AddItemToStockPrototype>();
            InternalNatives._AddUnitToAllStock = InternalNatives.Get("AddUnitToAllStock").ToDelegate<AddUnitToAllStockPrototype>();
            InternalNatives._AddUnitToStock = InternalNatives.Get("AddUnitToStock").ToDelegate<AddUnitToStockPrototype>();
            InternalNatives._RemoveItemFromAllStock = InternalNatives.Get("RemoveItemFromAllStock").ToDelegate<RemoveItemFromAllStockPrototype>();
            InternalNatives._RemoveItemFromStock = InternalNatives.Get("RemoveItemFromStock").ToDelegate<RemoveItemFromStockPrototype>();
            InternalNatives._RemoveUnitFromAllStock = InternalNatives.Get("RemoveUnitFromAllStock").ToDelegate<RemoveUnitFromAllStockPrototype>();
            InternalNatives._RemoveUnitFromStock = InternalNatives.Get("RemoveUnitFromStock").ToDelegate<RemoveUnitFromStockPrototype>();
            InternalNatives._SetAllItemTypeSlots = InternalNatives.Get("SetAllItemTypeSlots").ToDelegate<SetAllItemTypeSlotsPrototype>();
            InternalNatives._SetAllUnitTypeSlots = InternalNatives.Get("SetAllUnitTypeSlots").ToDelegate<SetAllUnitTypeSlotsPrototype>();
            InternalNatives._SetItemTypeSlots = InternalNatives.Get("SetItemTypeSlots").ToDelegate<SetItemTypeSlotsPrototype>();
            InternalNatives._SetUnitTypeSlots = InternalNatives.Get("SetUnitTypeSlots").ToDelegate<SetUnitTypeSlotsPrototype>();
            InternalNatives._GetUnitUserData = InternalNatives.Get("GetUnitUserData").ToDelegate<GetUnitUserDataPrototype>();
            InternalNatives._SetUnitUserData = InternalNatives.Get("SetUnitUserData").ToDelegate<SetUnitUserDataPrototype>();
            InternalNatives._Player = InternalNatives.Get("Player").ToDelegate<PlayerPrototype>();
            InternalNatives._GetLocalPlayer = InternalNatives.Get("GetLocalPlayer").ToDelegate<GetLocalPlayerPrototype>();
            InternalNatives._IsPlayerAlly = InternalNatives.Get("IsPlayerAlly").ToDelegate<IsPlayerAllyPrototype>();
            InternalNatives._IsPlayerEnemy = InternalNatives.Get("IsPlayerEnemy").ToDelegate<IsPlayerEnemyPrototype>();
            InternalNatives._IsPlayerInForce = InternalNatives.Get("IsPlayerInForce").ToDelegate<IsPlayerInForcePrototype>();
            InternalNatives._IsPlayerObserver = InternalNatives.Get("IsPlayerObserver").ToDelegate<IsPlayerObserverPrototype>();
            InternalNatives._IsVisibleToPlayer = InternalNatives.Get("IsVisibleToPlayer").ToDelegate<IsVisibleToPlayerPrototype>();
            InternalNatives._IsLocationVisibleToPlayer = InternalNatives.Get("IsLocationVisibleToPlayer").ToDelegate<IsLocationVisibleToPlayerPrototype>();
            InternalNatives._IsFoggedToPlayer = InternalNatives.Get("IsFoggedToPlayer").ToDelegate<IsFoggedToPlayerPrototype>();
            InternalNatives._IsLocationFoggedToPlayer = InternalNatives.Get("IsLocationFoggedToPlayer").ToDelegate<IsLocationFoggedToPlayerPrototype>();
            InternalNatives._IsMaskedToPlayer = InternalNatives.Get("IsMaskedToPlayer").ToDelegate<IsMaskedToPlayerPrototype>();
            InternalNatives._IsLocationMaskedToPlayer = InternalNatives.Get("IsLocationMaskedToPlayer").ToDelegate<IsLocationMaskedToPlayerPrototype>();
            InternalNatives._GetPlayerRace = InternalNatives.Get("GetPlayerRace").ToDelegate<GetPlayerRacePrototype>();
            InternalNatives._GetPlayerId = InternalNatives.Get("GetPlayerId").ToDelegate<GetPlayerIdPrototype>();
            InternalNatives._GetPlayerUnitCount = InternalNatives.Get("GetPlayerUnitCount").ToDelegate<GetPlayerUnitCountPrototype>();
            InternalNatives._GetPlayerTypedUnitCount = InternalNatives.Get("GetPlayerTypedUnitCount").ToDelegate<GetPlayerTypedUnitCountPrototype>();
            InternalNatives._GetPlayerStructureCount = InternalNatives.Get("GetPlayerStructureCount").ToDelegate<GetPlayerStructureCountPrototype>();
            InternalNatives._GetPlayerState = InternalNatives.Get("GetPlayerState").ToDelegate<GetPlayerStatePrototype>();
            InternalNatives._GetPlayerScore = InternalNatives.Get("GetPlayerScore").ToDelegate<GetPlayerScorePrototype>();
            InternalNatives._GetPlayerAlliance = InternalNatives.Get("GetPlayerAlliance").ToDelegate<GetPlayerAlliancePrototype>();
            InternalNatives._GetPlayerHandicap = InternalNatives.Get("GetPlayerHandicap").ToDelegate<GetPlayerHandicapPrototype>();
            InternalNatives._GetPlayerHandicapXP = InternalNatives.Get("GetPlayerHandicapXP").ToDelegate<GetPlayerHandicapXPPrototype>();
            InternalNatives._SetPlayerHandicap = InternalNatives.Get("SetPlayerHandicap").ToDelegate<SetPlayerHandicapPrototype>();
            InternalNatives._SetPlayerHandicapXP = InternalNatives.Get("SetPlayerHandicapXP").ToDelegate<SetPlayerHandicapXPPrototype>();
            InternalNatives._SetPlayerTechMaxAllowed = InternalNatives.Get("SetPlayerTechMaxAllowed").ToDelegate<SetPlayerTechMaxAllowedPrototype>();
            InternalNatives._GetPlayerTechMaxAllowed = InternalNatives.Get("GetPlayerTechMaxAllowed").ToDelegate<GetPlayerTechMaxAllowedPrototype>();
            InternalNatives._AddPlayerTechResearched = InternalNatives.Get("AddPlayerTechResearched").ToDelegate<AddPlayerTechResearchedPrototype>();
            InternalNatives._SetPlayerTechResearched = InternalNatives.Get("SetPlayerTechResearched").ToDelegate<SetPlayerTechResearchedPrototype>();
            InternalNatives._GetPlayerTechResearched = InternalNatives.Get("GetPlayerTechResearched").ToDelegate<GetPlayerTechResearchedPrototype>();
            InternalNatives._GetPlayerTechCount = InternalNatives.Get("GetPlayerTechCount").ToDelegate<GetPlayerTechCountPrototype>();
            InternalNatives._SetPlayerUnitsOwner = InternalNatives.Get("SetPlayerUnitsOwner").ToDelegate<SetPlayerUnitsOwnerPrototype>();
            InternalNatives._CripplePlayer = InternalNatives.Get("CripplePlayer").ToDelegate<CripplePlayerPrototype>();
            InternalNatives._SetPlayerAbilityAvailable = InternalNatives.Get("SetPlayerAbilityAvailable").ToDelegate<SetPlayerAbilityAvailablePrototype>();
            InternalNatives._SetPlayerState = InternalNatives.Get("SetPlayerState").ToDelegate<SetPlayerStatePrototype>();
            InternalNatives._RemovePlayer = InternalNatives.Get("RemovePlayer").ToDelegate<RemovePlayerPrototype>();
            InternalNatives._CachePlayerHeroData = InternalNatives.Get("CachePlayerHeroData").ToDelegate<CachePlayerHeroDataPrototype>();
            InternalNatives._SetFogStateRect = InternalNatives.Get("SetFogStateRect").ToDelegate<SetFogStateRectPrototype>();
            InternalNatives._SetFogStateRadius = InternalNatives.Get("SetFogStateRadius").ToDelegate<SetFogStateRadiusPrototype>();
            InternalNatives._SetFogStateRadiusLoc = InternalNatives.Get("SetFogStateRadiusLoc").ToDelegate<SetFogStateRadiusLocPrototype>();
            InternalNatives._FogMaskEnable = InternalNatives.Get("FogMaskEnable").ToDelegate<FogMaskEnablePrototype>();
            InternalNatives._IsFogMaskEnabled = InternalNatives.Get("IsFogMaskEnabled").ToDelegate<IsFogMaskEnabledPrototype>();
            InternalNatives._FogEnable = InternalNatives.Get("FogEnable").ToDelegate<FogEnablePrototype>();
            InternalNatives._IsFogEnabled = InternalNatives.Get("IsFogEnabled").ToDelegate<IsFogEnabledPrototype>();
            InternalNatives._CreateFogModifierRect = InternalNatives.Get("CreateFogModifierRect").ToDelegate<CreateFogModifierRectPrototype>();
            InternalNatives._CreateFogModifierRadius = InternalNatives.Get("CreateFogModifierRadius").ToDelegate<CreateFogModifierRadiusPrototype>();
            InternalNatives._CreateFogModifierRadiusLoc = InternalNatives.Get("CreateFogModifierRadiusLoc").ToDelegate<CreateFogModifierRadiusLocPrototype>();
            InternalNatives._DestroyFogModifier = InternalNatives.Get("DestroyFogModifier").ToDelegate<DestroyFogModifierPrototype>();
            InternalNatives._FogModifierStart = InternalNatives.Get("FogModifierStart").ToDelegate<FogModifierStartPrototype>();
            InternalNatives._FogModifierStop = InternalNatives.Get("FogModifierStop").ToDelegate<FogModifierStopPrototype>();
            InternalNatives._VersionGet = InternalNatives.Get("VersionGet").ToDelegate<VersionGetPrototype>();
            InternalNatives._VersionCompatible = InternalNatives.Get("VersionCompatible").ToDelegate<VersionCompatiblePrototype>();
            InternalNatives._VersionSupported = InternalNatives.Get("VersionSupported").ToDelegate<VersionSupportedPrototype>();
            InternalNatives._EndGame = InternalNatives.Get("EndGame").ToDelegate<EndGamePrototype>();
            InternalNatives._ChangeLevel = InternalNatives.Get("ChangeLevel").ToDelegate<ChangeLevelPrototype>();
            InternalNatives._RestartGame = InternalNatives.Get("RestartGame").ToDelegate<RestartGamePrototype>();
            InternalNatives._ReloadGame = InternalNatives.Get("ReloadGame").ToDelegate<ReloadGamePrototype>();
            InternalNatives._SetCampaignMenuRace = InternalNatives.Get("SetCampaignMenuRace").ToDelegate<SetCampaignMenuRacePrototype>();
            InternalNatives._SetCampaignMenuRaceEx = InternalNatives.Get("SetCampaignMenuRaceEx").ToDelegate<SetCampaignMenuRaceExPrototype>();
            InternalNatives._ForceCampaignSelectScreen = InternalNatives.Get("ForceCampaignSelectScreen").ToDelegate<ForceCampaignSelectScreenPrototype>();
            InternalNatives._LoadGame = InternalNatives.Get("LoadGame").ToDelegate<LoadGamePrototype>();
            InternalNatives._SaveGame = InternalNatives.Get("SaveGame").ToDelegate<SaveGamePrototype>();
            InternalNatives._RenameSaveDirectory = InternalNatives.Get("RenameSaveDirectory").ToDelegate<RenameSaveDirectoryPrototype>();
            InternalNatives._RemoveSaveDirectory = InternalNatives.Get("RemoveSaveDirectory").ToDelegate<RemoveSaveDirectoryPrototype>();
            InternalNatives._CopySaveGame = InternalNatives.Get("CopySaveGame").ToDelegate<CopySaveGamePrototype>();
            InternalNatives._SaveGameExists = InternalNatives.Get("SaveGameExists").ToDelegate<SaveGameExistsPrototype>();
            InternalNatives._SyncSelections = InternalNatives.Get("SyncSelections").ToDelegate<SyncSelectionsPrototype>();
            InternalNatives._SetFloatGameState = InternalNatives.Get("SetFloatGameState").ToDelegate<SetFloatGameStatePrototype>();
            InternalNatives._GetFloatGameState = InternalNatives.Get("GetFloatGameState").ToDelegate<GetFloatGameStatePrototype>();
            InternalNatives._SetIntegerGameState = InternalNatives.Get("SetIntegerGameState").ToDelegate<SetIntegerGameStatePrototype>();
            InternalNatives._GetIntegerGameState = InternalNatives.Get("GetIntegerGameState").ToDelegate<GetIntegerGameStatePrototype>();
            InternalNatives._SetTutorialCleared = InternalNatives.Get("SetTutorialCleared").ToDelegate<SetTutorialClearedPrototype>();
            InternalNatives._SetMissionAvailable = InternalNatives.Get("SetMissionAvailable").ToDelegate<SetMissionAvailablePrototype>();
            InternalNatives._SetCampaignAvailable = InternalNatives.Get("SetCampaignAvailable").ToDelegate<SetCampaignAvailablePrototype>();
            InternalNatives._SetOpCinematicAvailable = InternalNatives.Get("SetOpCinematicAvailable").ToDelegate<SetOpCinematicAvailablePrototype>();
            InternalNatives._SetEdCinematicAvailable = InternalNatives.Get("SetEdCinematicAvailable").ToDelegate<SetEdCinematicAvailablePrototype>();
            InternalNatives._GetDefaultDifficulty = InternalNatives.Get("GetDefaultDifficulty").ToDelegate<GetDefaultDifficultyPrototype>();
            InternalNatives._SetDefaultDifficulty = InternalNatives.Get("SetDefaultDifficulty").ToDelegate<SetDefaultDifficultyPrototype>();
            InternalNatives._SetCustomCampaignButtonVisible = InternalNatives.Get("SetCustomCampaignButtonVisible").ToDelegate<SetCustomCampaignButtonVisiblePrototype>();
            InternalNatives._GetCustomCampaignButtonVisible = InternalNatives.Get("GetCustomCampaignButtonVisible").ToDelegate<GetCustomCampaignButtonVisiblePrototype>();
            InternalNatives._DoNotSaveReplay = InternalNatives.Get("DoNotSaveReplay").ToDelegate<DoNotSaveReplayPrototype>();
            InternalNatives._DialogCreate = InternalNatives.Get("DialogCreate").ToDelegate<DialogCreatePrototype>();
            InternalNatives._DialogDestroy = InternalNatives.Get("DialogDestroy").ToDelegate<DialogDestroyPrototype>();
            InternalNatives._DialogClear = InternalNatives.Get("DialogClear").ToDelegate<DialogClearPrototype>();
            InternalNatives._DialogSetMessage = InternalNatives.Get("DialogSetMessage").ToDelegate<DialogSetMessagePrototype>();
            InternalNatives._DialogAddButton = InternalNatives.Get("DialogAddButton").ToDelegate<DialogAddButtonPrototype>();
            InternalNatives._DialogAddQuitButton = InternalNatives.Get("DialogAddQuitButton").ToDelegate<DialogAddQuitButtonPrototype>();
            InternalNatives._DialogDisplay = InternalNatives.Get("DialogDisplay").ToDelegate<DialogDisplayPrototype>();
            InternalNatives._ReloadGameCachesFromDisk = InternalNatives.Get("ReloadGameCachesFromDisk").ToDelegate<ReloadGameCachesFromDiskPrototype>();
            InternalNatives._InitGameCache = InternalNatives.Get("InitGameCache").ToDelegate<InitGameCachePrototype>();
            InternalNatives._SaveGameCache = InternalNatives.Get("SaveGameCache").ToDelegate<SaveGameCachePrototype>();
            InternalNatives._StoreInteger = InternalNatives.Get("StoreInteger").ToDelegate<StoreIntegerPrototype>();
            InternalNatives._StoreReal = InternalNatives.Get("StoreReal").ToDelegate<StoreRealPrototype>();
            InternalNatives._StoreBoolean = InternalNatives.Get("StoreBoolean").ToDelegate<StoreBooleanPrototype>();
            InternalNatives._StoreUnit = InternalNatives.Get("StoreUnit").ToDelegate<StoreUnitPrototype>();
            InternalNatives._StoreString = InternalNatives.Get("StoreString").ToDelegate<StoreStringPrototype>();
            InternalNatives._SyncStoredInteger = InternalNatives.Get("SyncStoredInteger").ToDelegate<SyncStoredIntegerPrototype>();
            InternalNatives._SyncStoredReal = InternalNatives.Get("SyncStoredReal").ToDelegate<SyncStoredRealPrototype>();
            InternalNatives._SyncStoredBoolean = InternalNatives.Get("SyncStoredBoolean").ToDelegate<SyncStoredBooleanPrototype>();
            InternalNatives._SyncStoredUnit = InternalNatives.Get("SyncStoredUnit").ToDelegate<SyncStoredUnitPrototype>();
            InternalNatives._SyncStoredString = InternalNatives.Get("SyncStoredString").ToDelegate<SyncStoredStringPrototype>();
            InternalNatives._HaveStoredInteger = InternalNatives.Get("HaveStoredInteger").ToDelegate<HaveStoredIntegerPrototype>();
            InternalNatives._HaveStoredReal = InternalNatives.Get("HaveStoredReal").ToDelegate<HaveStoredRealPrototype>();
            InternalNatives._HaveStoredBoolean = InternalNatives.Get("HaveStoredBoolean").ToDelegate<HaveStoredBooleanPrototype>();
            InternalNatives._HaveStoredUnit = InternalNatives.Get("HaveStoredUnit").ToDelegate<HaveStoredUnitPrototype>();
            InternalNatives._HaveStoredString = InternalNatives.Get("HaveStoredString").ToDelegate<HaveStoredStringPrototype>();
            InternalNatives._FlushGameCache = InternalNatives.Get("FlushGameCache").ToDelegate<FlushGameCachePrototype>();
            InternalNatives._FlushStoredMission = InternalNatives.Get("FlushStoredMission").ToDelegate<FlushStoredMissionPrototype>();
            InternalNatives._FlushStoredInteger = InternalNatives.Get("FlushStoredInteger").ToDelegate<FlushStoredIntegerPrototype>();
            InternalNatives._FlushStoredReal = InternalNatives.Get("FlushStoredReal").ToDelegate<FlushStoredRealPrototype>();
            InternalNatives._FlushStoredBoolean = InternalNatives.Get("FlushStoredBoolean").ToDelegate<FlushStoredBooleanPrototype>();
            InternalNatives._FlushStoredUnit = InternalNatives.Get("FlushStoredUnit").ToDelegate<FlushStoredUnitPrototype>();
            InternalNatives._FlushStoredString = InternalNatives.Get("FlushStoredString").ToDelegate<FlushStoredStringPrototype>();
            InternalNatives._GetStoredInteger = InternalNatives.Get("GetStoredInteger").ToDelegate<GetStoredIntegerPrototype>();
            InternalNatives._GetStoredReal = InternalNatives.Get("GetStoredReal").ToDelegate<GetStoredRealPrototype>();
            InternalNatives._GetStoredBoolean = InternalNatives.Get("GetStoredBoolean").ToDelegate<GetStoredBooleanPrototype>();
            InternalNatives._GetStoredString = InternalNatives.Get("GetStoredString").ToDelegate<GetStoredStringPrototype>();
            InternalNatives._RestoreUnit = InternalNatives.Get("RestoreUnit").ToDelegate<RestoreUnitPrototype>();
            InternalNatives._InitHashtable = InternalNatives.Get("InitHashtable").ToDelegate<InitHashtablePrototype>();
            InternalNatives._SaveInteger = InternalNatives.Get("SaveInteger").ToDelegate<SaveIntegerPrototype>();
            InternalNatives._SaveReal = InternalNatives.Get("SaveReal").ToDelegate<SaveRealPrototype>();
            InternalNatives._SaveBoolean = InternalNatives.Get("SaveBoolean").ToDelegate<SaveBooleanPrototype>();
            InternalNatives._SaveStr = InternalNatives.Get("SaveStr").ToDelegate<SaveStrPrototype>();
            InternalNatives._SavePlayerHandle = InternalNatives.Get("SavePlayerHandle").ToDelegate<SavePlayerHandlePrototype>();
            InternalNatives._SaveWidgetHandle = InternalNatives.Get("SaveWidgetHandle").ToDelegate<SaveWidgetHandlePrototype>();
            InternalNatives._SaveDestructableHandle = InternalNatives.Get("SaveDestructableHandle").ToDelegate<SaveDestructableHandlePrototype>();
            InternalNatives._SaveItemHandle = InternalNatives.Get("SaveItemHandle").ToDelegate<SaveItemHandlePrototype>();
            InternalNatives._SaveUnitHandle = InternalNatives.Get("SaveUnitHandle").ToDelegate<SaveUnitHandlePrototype>();
            InternalNatives._SaveAbilityHandle = InternalNatives.Get("SaveAbilityHandle").ToDelegate<SaveAbilityHandlePrototype>();
            InternalNatives._SaveTimerHandle = InternalNatives.Get("SaveTimerHandle").ToDelegate<SaveTimerHandlePrototype>();
            InternalNatives._SaveTriggerHandle = InternalNatives.Get("SaveTriggerHandle").ToDelegate<SaveTriggerHandlePrototype>();
            InternalNatives._SaveTriggerConditionHandle = InternalNatives.Get("SaveTriggerConditionHandle").ToDelegate<SaveTriggerConditionHandlePrototype>();
            InternalNatives._SaveTriggerActionHandle = InternalNatives.Get("SaveTriggerActionHandle").ToDelegate<SaveTriggerActionHandlePrototype>();
            InternalNatives._SaveTriggerEventHandle = InternalNatives.Get("SaveTriggerEventHandle").ToDelegate<SaveTriggerEventHandlePrototype>();
            InternalNatives._SaveForceHandle = InternalNatives.Get("SaveForceHandle").ToDelegate<SaveForceHandlePrototype>();
            InternalNatives._SaveGroupHandle = InternalNatives.Get("SaveGroupHandle").ToDelegate<SaveGroupHandlePrototype>();
            InternalNatives._SaveLocationHandle = InternalNatives.Get("SaveLocationHandle").ToDelegate<SaveLocationHandlePrototype>();
            InternalNatives._SaveRectHandle = InternalNatives.Get("SaveRectHandle").ToDelegate<SaveRectHandlePrototype>();
            InternalNatives._SaveBooleanExprHandle = InternalNatives.Get("SaveBooleanExprHandle").ToDelegate<SaveBooleanExprHandlePrototype>();
            InternalNatives._SaveSoundHandle = InternalNatives.Get("SaveSoundHandle").ToDelegate<SaveSoundHandlePrototype>();
            InternalNatives._SaveEffectHandle = InternalNatives.Get("SaveEffectHandle").ToDelegate<SaveEffectHandlePrototype>();
            InternalNatives._SaveUnitPoolHandle = InternalNatives.Get("SaveUnitPoolHandle").ToDelegate<SaveUnitPoolHandlePrototype>();
            InternalNatives._SaveItemPoolHandle = InternalNatives.Get("SaveItemPoolHandle").ToDelegate<SaveItemPoolHandlePrototype>();
            InternalNatives._SaveQuestHandle = InternalNatives.Get("SaveQuestHandle").ToDelegate<SaveQuestHandlePrototype>();
            InternalNatives._SaveQuestItemHandle = InternalNatives.Get("SaveQuestItemHandle").ToDelegate<SaveQuestItemHandlePrototype>();
            InternalNatives._SaveDefeatConditionHandle = InternalNatives.Get("SaveDefeatConditionHandle").ToDelegate<SaveDefeatConditionHandlePrototype>();
            InternalNatives._SaveTimerDialogHandle = InternalNatives.Get("SaveTimerDialogHandle").ToDelegate<SaveTimerDialogHandlePrototype>();
            InternalNatives._SaveLeaderboardHandle = InternalNatives.Get("SaveLeaderboardHandle").ToDelegate<SaveLeaderboardHandlePrototype>();
            InternalNatives._SaveMultiboardHandle = InternalNatives.Get("SaveMultiboardHandle").ToDelegate<SaveMultiboardHandlePrototype>();
            InternalNatives._SaveMultiboardItemHandle = InternalNatives.Get("SaveMultiboardItemHandle").ToDelegate<SaveMultiboardItemHandlePrototype>();
            InternalNatives._SaveTrackableHandle = InternalNatives.Get("SaveTrackableHandle").ToDelegate<SaveTrackableHandlePrototype>();
            InternalNatives._SaveDialogHandle = InternalNatives.Get("SaveDialogHandle").ToDelegate<SaveDialogHandlePrototype>();
            InternalNatives._SaveButtonHandle = InternalNatives.Get("SaveButtonHandle").ToDelegate<SaveButtonHandlePrototype>();
            InternalNatives._SaveTextTagHandle = InternalNatives.Get("SaveTextTagHandle").ToDelegate<SaveTextTagHandlePrototype>();
            InternalNatives._SaveLightningHandle = InternalNatives.Get("SaveLightningHandle").ToDelegate<SaveLightningHandlePrototype>();
            InternalNatives._SaveImageHandle = InternalNatives.Get("SaveImageHandle").ToDelegate<SaveImageHandlePrototype>();
            InternalNatives._SaveUbersplatHandle = InternalNatives.Get("SaveUbersplatHandle").ToDelegate<SaveUbersplatHandlePrototype>();
            InternalNatives._SaveRegionHandle = InternalNatives.Get("SaveRegionHandle").ToDelegate<SaveRegionHandlePrototype>();
            InternalNatives._SaveFogStateHandle = InternalNatives.Get("SaveFogStateHandle").ToDelegate<SaveFogStateHandlePrototype>();
            InternalNatives._SaveFogModifierHandle = InternalNatives.Get("SaveFogModifierHandle").ToDelegate<SaveFogModifierHandlePrototype>();
            InternalNatives._SaveAgentHandle = InternalNatives.Get("SaveAgentHandle").ToDelegate<SaveAgentHandlePrototype>();
            InternalNatives._SaveHashtableHandle = InternalNatives.Get("SaveHashtableHandle").ToDelegate<SaveHashtableHandlePrototype>();
            InternalNatives._LoadInteger = InternalNatives.Get("LoadInteger").ToDelegate<LoadIntegerPrototype>();
            InternalNatives._LoadReal = InternalNatives.Get("LoadReal").ToDelegate<LoadRealPrototype>();
            InternalNatives._LoadBoolean = InternalNatives.Get("LoadBoolean").ToDelegate<LoadBooleanPrototype>();
            InternalNatives._LoadStr = InternalNatives.Get("LoadStr").ToDelegate<LoadStrPrototype>();
            InternalNatives._LoadPlayerHandle = InternalNatives.Get("LoadPlayerHandle").ToDelegate<LoadPlayerHandlePrototype>();
            InternalNatives._LoadWidgetHandle = InternalNatives.Get("LoadWidgetHandle").ToDelegate<LoadWidgetHandlePrototype>();
            InternalNatives._LoadDestructableHandle = InternalNatives.Get("LoadDestructableHandle").ToDelegate<LoadDestructableHandlePrototype>();
            InternalNatives._LoadItemHandle = InternalNatives.Get("LoadItemHandle").ToDelegate<LoadItemHandlePrototype>();
            InternalNatives._LoadUnitHandle = InternalNatives.Get("LoadUnitHandle").ToDelegate<LoadUnitHandlePrototype>();
            InternalNatives._LoadAbilityHandle = InternalNatives.Get("LoadAbilityHandle").ToDelegate<LoadAbilityHandlePrototype>();
            InternalNatives._LoadTimerHandle = InternalNatives.Get("LoadTimerHandle").ToDelegate<LoadTimerHandlePrototype>();
            InternalNatives._LoadTriggerHandle = InternalNatives.Get("LoadTriggerHandle").ToDelegate<LoadTriggerHandlePrototype>();
            InternalNatives._LoadTriggerConditionHandle = InternalNatives.Get("LoadTriggerConditionHandle").ToDelegate<LoadTriggerConditionHandlePrototype>();
            InternalNatives._LoadTriggerActionHandle = InternalNatives.Get("LoadTriggerActionHandle").ToDelegate<LoadTriggerActionHandlePrototype>();
            InternalNatives._LoadTriggerEventHandle = InternalNatives.Get("LoadTriggerEventHandle").ToDelegate<LoadTriggerEventHandlePrototype>();
            InternalNatives._LoadForceHandle = InternalNatives.Get("LoadForceHandle").ToDelegate<LoadForceHandlePrototype>();
            InternalNatives._LoadGroupHandle = InternalNatives.Get("LoadGroupHandle").ToDelegate<LoadGroupHandlePrototype>();
            InternalNatives._LoadLocationHandle = InternalNatives.Get("LoadLocationHandle").ToDelegate<LoadLocationHandlePrototype>();
            InternalNatives._LoadRectHandle = InternalNatives.Get("LoadRectHandle").ToDelegate<LoadRectHandlePrototype>();
            InternalNatives._LoadBooleanExprHandle = InternalNatives.Get("LoadBooleanExprHandle").ToDelegate<LoadBooleanExprHandlePrototype>();
            InternalNatives._LoadSoundHandle = InternalNatives.Get("LoadSoundHandle").ToDelegate<LoadSoundHandlePrototype>();
            InternalNatives._LoadEffectHandle = InternalNatives.Get("LoadEffectHandle").ToDelegate<LoadEffectHandlePrototype>();
            InternalNatives._LoadUnitPoolHandle = InternalNatives.Get("LoadUnitPoolHandle").ToDelegate<LoadUnitPoolHandlePrototype>();
            InternalNatives._LoadItemPoolHandle = InternalNatives.Get("LoadItemPoolHandle").ToDelegate<LoadItemPoolHandlePrototype>();
            InternalNatives._LoadQuestHandle = InternalNatives.Get("LoadQuestHandle").ToDelegate<LoadQuestHandlePrototype>();
            InternalNatives._LoadQuestItemHandle = InternalNatives.Get("LoadQuestItemHandle").ToDelegate<LoadQuestItemHandlePrototype>();
            InternalNatives._LoadDefeatConditionHandle = InternalNatives.Get("LoadDefeatConditionHandle").ToDelegate<LoadDefeatConditionHandlePrototype>();
            InternalNatives._LoadTimerDialogHandle = InternalNatives.Get("LoadTimerDialogHandle").ToDelegate<LoadTimerDialogHandlePrototype>();
            InternalNatives._LoadLeaderboardHandle = InternalNatives.Get("LoadLeaderboardHandle").ToDelegate<LoadLeaderboardHandlePrototype>();
            InternalNatives._LoadMultiboardHandle = InternalNatives.Get("LoadMultiboardHandle").ToDelegate<LoadMultiboardHandlePrototype>();
            InternalNatives._LoadMultiboardItemHandle = InternalNatives.Get("LoadMultiboardItemHandle").ToDelegate<LoadMultiboardItemHandlePrototype>();
            InternalNatives._LoadTrackableHandle = InternalNatives.Get("LoadTrackableHandle").ToDelegate<LoadTrackableHandlePrototype>();
            InternalNatives._LoadDialogHandle = InternalNatives.Get("LoadDialogHandle").ToDelegate<LoadDialogHandlePrototype>();
            InternalNatives._LoadButtonHandle = InternalNatives.Get("LoadButtonHandle").ToDelegate<LoadButtonHandlePrototype>();
            InternalNatives._LoadTextTagHandle = InternalNatives.Get("LoadTextTagHandle").ToDelegate<LoadTextTagHandlePrototype>();
            InternalNatives._LoadLightningHandle = InternalNatives.Get("LoadLightningHandle").ToDelegate<LoadLightningHandlePrototype>();
            InternalNatives._LoadImageHandle = InternalNatives.Get("LoadImageHandle").ToDelegate<LoadImageHandlePrototype>();
            InternalNatives._LoadUbersplatHandle = InternalNatives.Get("LoadUbersplatHandle").ToDelegate<LoadUbersplatHandlePrototype>();
            InternalNatives._LoadRegionHandle = InternalNatives.Get("LoadRegionHandle").ToDelegate<LoadRegionHandlePrototype>();
            InternalNatives._LoadFogStateHandle = InternalNatives.Get("LoadFogStateHandle").ToDelegate<LoadFogStateHandlePrototype>();
            InternalNatives._LoadFogModifierHandle = InternalNatives.Get("LoadFogModifierHandle").ToDelegate<LoadFogModifierHandlePrototype>();
            InternalNatives._LoadHashtableHandle = InternalNatives.Get("LoadHashtableHandle").ToDelegate<LoadHashtableHandlePrototype>();
            InternalNatives._HaveSavedInteger = InternalNatives.Get("HaveSavedInteger").ToDelegate<HaveSavedIntegerPrototype>();
            InternalNatives._HaveSavedReal = InternalNatives.Get("HaveSavedReal").ToDelegate<HaveSavedRealPrototype>();
            InternalNatives._HaveSavedBoolean = InternalNatives.Get("HaveSavedBoolean").ToDelegate<HaveSavedBooleanPrototype>();
            InternalNatives._HaveSavedString = InternalNatives.Get("HaveSavedString").ToDelegate<HaveSavedStringPrototype>();
            InternalNatives._HaveSavedHandle = InternalNatives.Get("HaveSavedHandle").ToDelegate<HaveSavedHandlePrototype>();
            InternalNatives._RemoveSavedInteger = InternalNatives.Get("RemoveSavedInteger").ToDelegate<RemoveSavedIntegerPrototype>();
            InternalNatives._RemoveSavedReal = InternalNatives.Get("RemoveSavedReal").ToDelegate<RemoveSavedRealPrototype>();
            InternalNatives._RemoveSavedBoolean = InternalNatives.Get("RemoveSavedBoolean").ToDelegate<RemoveSavedBooleanPrototype>();
            InternalNatives._RemoveSavedString = InternalNatives.Get("RemoveSavedString").ToDelegate<RemoveSavedStringPrototype>();
            InternalNatives._RemoveSavedHandle = InternalNatives.Get("RemoveSavedHandle").ToDelegate<RemoveSavedHandlePrototype>();
            InternalNatives._FlushParentHashtable = InternalNatives.Get("FlushParentHashtable").ToDelegate<FlushParentHashtablePrototype>();
            InternalNatives._FlushChildHashtable = InternalNatives.Get("FlushChildHashtable").ToDelegate<FlushChildHashtablePrototype>();
            InternalNatives._GetRandomInt = InternalNatives.Get("GetRandomInt").ToDelegate<GetRandomIntPrototype>();
            InternalNatives._GetRandomReal = InternalNatives.Get("GetRandomReal").ToDelegate<GetRandomRealPrototype>();
            InternalNatives._CreateUnitPool = InternalNatives.Get("CreateUnitPool").ToDelegate<CreateUnitPoolPrototype>();
            InternalNatives._DestroyUnitPool = InternalNatives.Get("DestroyUnitPool").ToDelegate<DestroyUnitPoolPrototype>();
            InternalNatives._UnitPoolAddUnitType = InternalNatives.Get("UnitPoolAddUnitType").ToDelegate<UnitPoolAddUnitTypePrototype>();
            InternalNatives._UnitPoolRemoveUnitType = InternalNatives.Get("UnitPoolRemoveUnitType").ToDelegate<UnitPoolRemoveUnitTypePrototype>();
            InternalNatives._PlaceRandomUnit = InternalNatives.Get("PlaceRandomUnit").ToDelegate<PlaceRandomUnitPrototype>();
            InternalNatives._CreateItemPool = InternalNatives.Get("CreateItemPool").ToDelegate<CreateItemPoolPrototype>();
            InternalNatives._DestroyItemPool = InternalNatives.Get("DestroyItemPool").ToDelegate<DestroyItemPoolPrototype>();
            InternalNatives._ItemPoolAddItemType = InternalNatives.Get("ItemPoolAddItemType").ToDelegate<ItemPoolAddItemTypePrototype>();
            InternalNatives._ItemPoolRemoveItemType = InternalNatives.Get("ItemPoolRemoveItemType").ToDelegate<ItemPoolRemoveItemTypePrototype>();
            InternalNatives._PlaceRandomItem = InternalNatives.Get("PlaceRandomItem").ToDelegate<PlaceRandomItemPrototype>();
            InternalNatives._ChooseRandomCreep = InternalNatives.Get("ChooseRandomCreep").ToDelegate<ChooseRandomCreepPrototype>();
            InternalNatives._ChooseRandomNPBuilding = InternalNatives.Get("ChooseRandomNPBuilding").ToDelegate<ChooseRandomNPBuildingPrototype>();
            InternalNatives._ChooseRandomItem = InternalNatives.Get("ChooseRandomItem").ToDelegate<ChooseRandomItemPrototype>();
            InternalNatives._ChooseRandomItemEx = InternalNatives.Get("ChooseRandomItemEx").ToDelegate<ChooseRandomItemExPrototype>();
            InternalNatives._SetRandomSeed = InternalNatives.Get("SetRandomSeed").ToDelegate<SetRandomSeedPrototype>();
            InternalNatives._SetTerrainFog = InternalNatives.Get("SetTerrainFog").ToDelegate<SetTerrainFogPrototype>();
            InternalNatives._ResetTerrainFog = InternalNatives.Get("ResetTerrainFog").ToDelegate<ResetTerrainFogPrototype>();
            InternalNatives._SetUnitFog = InternalNatives.Get("SetUnitFog").ToDelegate<SetUnitFogPrototype>();
            InternalNatives._SetTerrainFogEx = InternalNatives.Get("SetTerrainFogEx").ToDelegate<SetTerrainFogExPrototype>();
            InternalNatives._DisplayTextToPlayer = InternalNatives.Get("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>();
            InternalNatives._DisplayTimedTextToPlayer = InternalNatives.Get("DisplayTimedTextToPlayer").ToDelegate<DisplayTimedTextToPlayerPrototype>();
            InternalNatives._DisplayTimedTextFromPlayer = InternalNatives.Get("DisplayTimedTextFromPlayer").ToDelegate<DisplayTimedTextFromPlayerPrototype>();
            InternalNatives._ClearTextMessages = InternalNatives.Get("ClearTextMessages").ToDelegate<ClearTextMessagesPrototype>();
            InternalNatives._SetDayNightModels = InternalNatives.Get("SetDayNightModels").ToDelegate<SetDayNightModelsPrototype>();
            InternalNatives._SetSkyModel = InternalNatives.Get("SetSkyModel").ToDelegate<SetSkyModelPrototype>();
            InternalNatives._EnableUserControl = InternalNatives.Get("EnableUserControl").ToDelegate<EnableUserControlPrototype>();
            InternalNatives._EnableUserUI = InternalNatives.Get("EnableUserUI").ToDelegate<EnableUserUIPrototype>();
            InternalNatives._SuspendTimeOfDay = InternalNatives.Get("SuspendTimeOfDay").ToDelegate<SuspendTimeOfDayPrototype>();
            InternalNatives._SetTimeOfDayScale = InternalNatives.Get("SetTimeOfDayScale").ToDelegate<SetTimeOfDayScalePrototype>();
            InternalNatives._GetTimeOfDayScale = InternalNatives.Get("GetTimeOfDayScale").ToDelegate<GetTimeOfDayScalePrototype>();
            InternalNatives._ShowInterface = InternalNatives.Get("ShowInterface").ToDelegate<ShowInterfacePrototype>();
            InternalNatives._PauseGame = InternalNatives.Get("PauseGame").ToDelegate<PauseGamePrototype>();
            InternalNatives._UnitAddIndicator = InternalNatives.Get("UnitAddIndicator").ToDelegate<UnitAddIndicatorPrototype>();
            InternalNatives._AddIndicator = InternalNatives.Get("AddIndicator").ToDelegate<AddIndicatorPrototype>();
            InternalNatives._PingMinimap = InternalNatives.Get("PingMinimap").ToDelegate<PingMinimapPrototype>();
            InternalNatives._PingMinimapEx = InternalNatives.Get("PingMinimapEx").ToDelegate<PingMinimapExPrototype>();
            InternalNatives._EnableOcclusion = InternalNatives.Get("EnableOcclusion").ToDelegate<EnableOcclusionPrototype>();
            InternalNatives._SetIntroShotText = InternalNatives.Get("SetIntroShotText").ToDelegate<SetIntroShotTextPrototype>();
            InternalNatives._SetIntroShotModel = InternalNatives.Get("SetIntroShotModel").ToDelegate<SetIntroShotModelPrototype>();
            InternalNatives._EnableWorldFogBoundary = InternalNatives.Get("EnableWorldFogBoundary").ToDelegate<EnableWorldFogBoundaryPrototype>();
            InternalNatives._PlayModelCinematic = InternalNatives.Get("PlayModelCinematic").ToDelegate<PlayModelCinematicPrototype>();
            InternalNatives._PlayCinematic = InternalNatives.Get("PlayCinematic").ToDelegate<PlayCinematicPrototype>();
            InternalNatives._ForceUIKey = InternalNatives.Get("ForceUIKey").ToDelegate<ForceUIKeyPrototype>();
            InternalNatives._ForceUICancel = InternalNatives.Get("ForceUICancel").ToDelegate<ForceUICancelPrototype>();
            InternalNatives._DisplayLoadDialog = InternalNatives.Get("DisplayLoadDialog").ToDelegate<DisplayLoadDialogPrototype>();
            InternalNatives._SetAltMinimapIcon = InternalNatives.Get("SetAltMinimapIcon").ToDelegate<SetAltMinimapIconPrototype>();
            InternalNatives._DisableRestartMission = InternalNatives.Get("DisableRestartMission").ToDelegate<DisableRestartMissionPrototype>();
            InternalNatives._CreateTextTag = InternalNatives.Get("CreateTextTag").ToDelegate<CreateTextTagPrototype>();
            InternalNatives._DestroyTextTag = InternalNatives.Get("DestroyTextTag").ToDelegate<DestroyTextTagPrototype>();
            InternalNatives._SetTextTagText = InternalNatives.Get("SetTextTagText").ToDelegate<SetTextTagTextPrototype>();
            InternalNatives._SetTextTagPos = InternalNatives.Get("SetTextTagPos").ToDelegate<SetTextTagPosPrototype>();
            InternalNatives._SetTextTagPosUnit = InternalNatives.Get("SetTextTagPosUnit").ToDelegate<SetTextTagPosUnitPrototype>();
            InternalNatives._SetTextTagColor = InternalNatives.Get("SetTextTagColor").ToDelegate<SetTextTagColorPrototype>();
            InternalNatives._SetTextTagVelocity = InternalNatives.Get("SetTextTagVelocity").ToDelegate<SetTextTagVelocityPrototype>();
            InternalNatives._SetTextTagVisibility = InternalNatives.Get("SetTextTagVisibility").ToDelegate<SetTextTagVisibilityPrototype>();
            InternalNatives._SetTextTagSuspended = InternalNatives.Get("SetTextTagSuspended").ToDelegate<SetTextTagSuspendedPrototype>();
            InternalNatives._SetTextTagPermanent = InternalNatives.Get("SetTextTagPermanent").ToDelegate<SetTextTagPermanentPrototype>();
            InternalNatives._SetTextTagAge = InternalNatives.Get("SetTextTagAge").ToDelegate<SetTextTagAgePrototype>();
            InternalNatives._SetTextTagLifespan = InternalNatives.Get("SetTextTagLifespan").ToDelegate<SetTextTagLifespanPrototype>();
            InternalNatives._SetTextTagFadepoint = InternalNatives.Get("SetTextTagFadepoint").ToDelegate<SetTextTagFadepointPrototype>();
            InternalNatives._SetReservedLocalHeroButtons = InternalNatives.Get("SetReservedLocalHeroButtons").ToDelegate<SetReservedLocalHeroButtonsPrototype>();
            InternalNatives._GetAllyColorFilterState = InternalNatives.Get("GetAllyColorFilterState").ToDelegate<GetAllyColorFilterStatePrototype>();
            InternalNatives._SetAllyColorFilterState = InternalNatives.Get("SetAllyColorFilterState").ToDelegate<SetAllyColorFilterStatePrototype>();
            InternalNatives._GetCreepCampFilterState = InternalNatives.Get("GetCreepCampFilterState").ToDelegate<GetCreepCampFilterStatePrototype>();
            InternalNatives._SetCreepCampFilterState = InternalNatives.Get("SetCreepCampFilterState").ToDelegate<SetCreepCampFilterStatePrototype>();
            InternalNatives._EnableMinimapFilterButtons = InternalNatives.Get("EnableMinimapFilterButtons").ToDelegate<EnableMinimapFilterButtonsPrototype>();
            InternalNatives._EnableDragSelect = InternalNatives.Get("EnableDragSelect").ToDelegate<EnableDragSelectPrototype>();
            InternalNatives._EnablePreSelect = InternalNatives.Get("EnablePreSelect").ToDelegate<EnablePreSelectPrototype>();
            InternalNatives._EnableSelect = InternalNatives.Get("EnableSelect").ToDelegate<EnableSelectPrototype>();
            InternalNatives._CreateTrackable = InternalNatives.Get("CreateTrackable").ToDelegate<CreateTrackablePrototype>();
            InternalNatives._CreateQuest = InternalNatives.Get("CreateQuest").ToDelegate<CreateQuestPrototype>();
            InternalNatives._DestroyQuest = InternalNatives.Get("DestroyQuest").ToDelegate<DestroyQuestPrototype>();
            InternalNatives._QuestSetTitle = InternalNatives.Get("QuestSetTitle").ToDelegate<QuestSetTitlePrototype>();
            InternalNatives._QuestSetDescription = InternalNatives.Get("QuestSetDescription").ToDelegate<QuestSetDescriptionPrototype>();
            InternalNatives._QuestSetIconPath = InternalNatives.Get("QuestSetIconPath").ToDelegate<QuestSetIconPathPrototype>();
            InternalNatives._QuestSetRequired = InternalNatives.Get("QuestSetRequired").ToDelegate<QuestSetRequiredPrototype>();
            InternalNatives._QuestSetCompleted = InternalNatives.Get("QuestSetCompleted").ToDelegate<QuestSetCompletedPrototype>();
            InternalNatives._QuestSetDiscovered = InternalNatives.Get("QuestSetDiscovered").ToDelegate<QuestSetDiscoveredPrototype>();
            InternalNatives._QuestSetFailed = InternalNatives.Get("QuestSetFailed").ToDelegate<QuestSetFailedPrototype>();
            InternalNatives._QuestSetEnabled = InternalNatives.Get("QuestSetEnabled").ToDelegate<QuestSetEnabledPrototype>();
            InternalNatives._IsQuestRequired = InternalNatives.Get("IsQuestRequired").ToDelegate<IsQuestRequiredPrototype>();
            InternalNatives._IsQuestCompleted = InternalNatives.Get("IsQuestCompleted").ToDelegate<IsQuestCompletedPrototype>();
            InternalNatives._IsQuestDiscovered = InternalNatives.Get("IsQuestDiscovered").ToDelegate<IsQuestDiscoveredPrototype>();
            InternalNatives._IsQuestFailed = InternalNatives.Get("IsQuestFailed").ToDelegate<IsQuestFailedPrototype>();
            InternalNatives._IsQuestEnabled = InternalNatives.Get("IsQuestEnabled").ToDelegate<IsQuestEnabledPrototype>();
            InternalNatives._QuestCreateItem = InternalNatives.Get("QuestCreateItem").ToDelegate<QuestCreateItemPrototype>();
            InternalNatives._QuestItemSetDescription = InternalNatives.Get("QuestItemSetDescription").ToDelegate<QuestItemSetDescriptionPrototype>();
            InternalNatives._QuestItemSetCompleted = InternalNatives.Get("QuestItemSetCompleted").ToDelegate<QuestItemSetCompletedPrototype>();
            InternalNatives._IsQuestItemCompleted = InternalNatives.Get("IsQuestItemCompleted").ToDelegate<IsQuestItemCompletedPrototype>();
            InternalNatives._CreateDefeatCondition = InternalNatives.Get("CreateDefeatCondition").ToDelegate<CreateDefeatConditionPrototype>();
            InternalNatives._DestroyDefeatCondition = InternalNatives.Get("DestroyDefeatCondition").ToDelegate<DestroyDefeatConditionPrototype>();
            InternalNatives._DefeatConditionSetDescription = InternalNatives.Get("DefeatConditionSetDescription").ToDelegate<DefeatConditionSetDescriptionPrototype>();
            InternalNatives._FlashQuestDialogButton = InternalNatives.Get("FlashQuestDialogButton").ToDelegate<FlashQuestDialogButtonPrototype>();
            InternalNatives._ForceQuestDialogUpdate = InternalNatives.Get("ForceQuestDialogUpdate").ToDelegate<ForceQuestDialogUpdatePrototype>();
            InternalNatives._CreateTimerDialog = InternalNatives.Get("CreateTimerDialog").ToDelegate<CreateTimerDialogPrototype>();
            InternalNatives._DestroyTimerDialog = InternalNatives.Get("DestroyTimerDialog").ToDelegate<DestroyTimerDialogPrototype>();
            InternalNatives._TimerDialogSetTitle = InternalNatives.Get("TimerDialogSetTitle").ToDelegate<TimerDialogSetTitlePrototype>();
            InternalNatives._TimerDialogSetTitleColor = InternalNatives.Get("TimerDialogSetTitleColor").ToDelegate<TimerDialogSetTitleColorPrototype>();
            InternalNatives._TimerDialogSetTimeColor = InternalNatives.Get("TimerDialogSetTimeColor").ToDelegate<TimerDialogSetTimeColorPrototype>();
            InternalNatives._TimerDialogSetSpeed = InternalNatives.Get("TimerDialogSetSpeed").ToDelegate<TimerDialogSetSpeedPrototype>();
            InternalNatives._TimerDialogDisplay = InternalNatives.Get("TimerDialogDisplay").ToDelegate<TimerDialogDisplayPrototype>();
            InternalNatives._IsTimerDialogDisplayed = InternalNatives.Get("IsTimerDialogDisplayed").ToDelegate<IsTimerDialogDisplayedPrototype>();
            InternalNatives._TimerDialogSetRealTimeRemaining = InternalNatives.Get("TimerDialogSetRealTimeRemaining").ToDelegate<TimerDialogSetRealTimeRemainingPrototype>();
            InternalNatives._CreateLeaderboard = InternalNatives.Get("CreateLeaderboard").ToDelegate<CreateLeaderboardPrototype>();
            InternalNatives._DestroyLeaderboard = InternalNatives.Get("DestroyLeaderboard").ToDelegate<DestroyLeaderboardPrototype>();
            InternalNatives._LeaderboardDisplay = InternalNatives.Get("LeaderboardDisplay").ToDelegate<LeaderboardDisplayPrototype>();
            InternalNatives._IsLeaderboardDisplayed = InternalNatives.Get("IsLeaderboardDisplayed").ToDelegate<IsLeaderboardDisplayedPrototype>();
            InternalNatives._LeaderboardGetItemCount = InternalNatives.Get("LeaderboardGetItemCount").ToDelegate<LeaderboardGetItemCountPrototype>();
            InternalNatives._LeaderboardSetSizeByItemCount = InternalNatives.Get("LeaderboardSetSizeByItemCount").ToDelegate<LeaderboardSetSizeByItemCountPrototype>();
            InternalNatives._LeaderboardAddItem = InternalNatives.Get("LeaderboardAddItem").ToDelegate<LeaderboardAddItemPrototype>();
            InternalNatives._LeaderboardRemoveItem = InternalNatives.Get("LeaderboardRemoveItem").ToDelegate<LeaderboardRemoveItemPrototype>();
            InternalNatives._LeaderboardRemovePlayerItem = InternalNatives.Get("LeaderboardRemovePlayerItem").ToDelegate<LeaderboardRemovePlayerItemPrototype>();
            InternalNatives._LeaderboardClear = InternalNatives.Get("LeaderboardClear").ToDelegate<LeaderboardClearPrototype>();
            InternalNatives._LeaderboardSortItemsByValue = InternalNatives.Get("LeaderboardSortItemsByValue").ToDelegate<LeaderboardSortItemsByValuePrototype>();
            InternalNatives._LeaderboardSortItemsByPlayer = InternalNatives.Get("LeaderboardSortItemsByPlayer").ToDelegate<LeaderboardSortItemsByPlayerPrototype>();
            InternalNatives._LeaderboardSortItemsByLabel = InternalNatives.Get("LeaderboardSortItemsByLabel").ToDelegate<LeaderboardSortItemsByLabelPrototype>();
            InternalNatives._LeaderboardHasPlayerItem = InternalNatives.Get("LeaderboardHasPlayerItem").ToDelegate<LeaderboardHasPlayerItemPrototype>();
            InternalNatives._LeaderboardGetPlayerIndex = InternalNatives.Get("LeaderboardGetPlayerIndex").ToDelegate<LeaderboardGetPlayerIndexPrototype>();
            InternalNatives._LeaderboardSetLabel = InternalNatives.Get("LeaderboardSetLabel").ToDelegate<LeaderboardSetLabelPrototype>();
            InternalNatives._LeaderboardGetLabelText = InternalNatives.Get("LeaderboardGetLabelText").ToDelegate<LeaderboardGetLabelTextPrototype>();
            InternalNatives._PlayerSetLeaderboard = InternalNatives.Get("PlayerSetLeaderboard").ToDelegate<PlayerSetLeaderboardPrototype>();
            InternalNatives._PlayerGetLeaderboard = InternalNatives.Get("PlayerGetLeaderboard").ToDelegate<PlayerGetLeaderboardPrototype>();
            InternalNatives._LeaderboardSetLabelColor = InternalNatives.Get("LeaderboardSetLabelColor").ToDelegate<LeaderboardSetLabelColorPrototype>();
            InternalNatives._LeaderboardSetValueColor = InternalNatives.Get("LeaderboardSetValueColor").ToDelegate<LeaderboardSetValueColorPrototype>();
            InternalNatives._LeaderboardSetStyle = InternalNatives.Get("LeaderboardSetStyle").ToDelegate<LeaderboardSetStylePrototype>();
            InternalNatives._LeaderboardSetItemValue = InternalNatives.Get("LeaderboardSetItemValue").ToDelegate<LeaderboardSetItemValuePrototype>();
            InternalNatives._LeaderboardSetItemLabel = InternalNatives.Get("LeaderboardSetItemLabel").ToDelegate<LeaderboardSetItemLabelPrototype>();
            InternalNatives._LeaderboardSetItemStyle = InternalNatives.Get("LeaderboardSetItemStyle").ToDelegate<LeaderboardSetItemStylePrototype>();
            InternalNatives._LeaderboardSetItemLabelColor = InternalNatives.Get("LeaderboardSetItemLabelColor").ToDelegate<LeaderboardSetItemLabelColorPrototype>();
            InternalNatives._LeaderboardSetItemValueColor = InternalNatives.Get("LeaderboardSetItemValueColor").ToDelegate<LeaderboardSetItemValueColorPrototype>();
            InternalNatives._CreateMultiboard = InternalNatives.Get("CreateMultiboard").ToDelegate<CreateMultiboardPrototype>();
            InternalNatives._DestroyMultiboard = InternalNatives.Get("DestroyMultiboard").ToDelegate<DestroyMultiboardPrototype>();
            InternalNatives._MultiboardDisplay = InternalNatives.Get("MultiboardDisplay").ToDelegate<MultiboardDisplayPrototype>();
            InternalNatives._IsMultiboardDisplayed = InternalNatives.Get("IsMultiboardDisplayed").ToDelegate<IsMultiboardDisplayedPrototype>();
            InternalNatives._MultiboardMinimize = InternalNatives.Get("MultiboardMinimize").ToDelegate<MultiboardMinimizePrototype>();
            InternalNatives._IsMultiboardMinimized = InternalNatives.Get("IsMultiboardMinimized").ToDelegate<IsMultiboardMinimizedPrototype>();
            InternalNatives._MultiboardClear = InternalNatives.Get("MultiboardClear").ToDelegate<MultiboardClearPrototype>();
            InternalNatives._MultiboardSetTitleText = InternalNatives.Get("MultiboardSetTitleText").ToDelegate<MultiboardSetTitleTextPrototype>();
            InternalNatives._MultiboardGetTitleText = InternalNatives.Get("MultiboardGetTitleText").ToDelegate<MultiboardGetTitleTextPrototype>();
            InternalNatives._MultiboardSetTitleTextColor = InternalNatives.Get("MultiboardSetTitleTextColor").ToDelegate<MultiboardSetTitleTextColorPrototype>();
            InternalNatives._MultiboardGetRowCount = InternalNatives.Get("MultiboardGetRowCount").ToDelegate<MultiboardGetRowCountPrototype>();
            InternalNatives._MultiboardGetColumnCount = InternalNatives.Get("MultiboardGetColumnCount").ToDelegate<MultiboardGetColumnCountPrototype>();
            InternalNatives._MultiboardSetColumnCount = InternalNatives.Get("MultiboardSetColumnCount").ToDelegate<MultiboardSetColumnCountPrototype>();
            InternalNatives._MultiboardSetRowCount = InternalNatives.Get("MultiboardSetRowCount").ToDelegate<MultiboardSetRowCountPrototype>();
            InternalNatives._MultiboardSetItemsStyle = InternalNatives.Get("MultiboardSetItemsStyle").ToDelegate<MultiboardSetItemsStylePrototype>();
            InternalNatives._MultiboardSetItemsValue = InternalNatives.Get("MultiboardSetItemsValue").ToDelegate<MultiboardSetItemsValuePrototype>();
            InternalNatives._MultiboardSetItemsValueColor = InternalNatives.Get("MultiboardSetItemsValueColor").ToDelegate<MultiboardSetItemsValueColorPrototype>();
            InternalNatives._MultiboardSetItemsWidth = InternalNatives.Get("MultiboardSetItemsWidth").ToDelegate<MultiboardSetItemsWidthPrototype>();
            InternalNatives._MultiboardSetItemsIcon = InternalNatives.Get("MultiboardSetItemsIcon").ToDelegate<MultiboardSetItemsIconPrototype>();
            InternalNatives._MultiboardGetItem = InternalNatives.Get("MultiboardGetItem").ToDelegate<MultiboardGetItemPrototype>();
            InternalNatives._MultiboardReleaseItem = InternalNatives.Get("MultiboardReleaseItem").ToDelegate<MultiboardReleaseItemPrototype>();
            InternalNatives._MultiboardSetItemStyle = InternalNatives.Get("MultiboardSetItemStyle").ToDelegate<MultiboardSetItemStylePrototype>();
            InternalNatives._MultiboardSetItemValue = InternalNatives.Get("MultiboardSetItemValue").ToDelegate<MultiboardSetItemValuePrototype>();
            InternalNatives._MultiboardSetItemValueColor = InternalNatives.Get("MultiboardSetItemValueColor").ToDelegate<MultiboardSetItemValueColorPrototype>();
            InternalNatives._MultiboardSetItemWidth = InternalNatives.Get("MultiboardSetItemWidth").ToDelegate<MultiboardSetItemWidthPrototype>();
            InternalNatives._MultiboardSetItemIcon = InternalNatives.Get("MultiboardSetItemIcon").ToDelegate<MultiboardSetItemIconPrototype>();
            InternalNatives._MultiboardSuppressDisplay = InternalNatives.Get("MultiboardSuppressDisplay").ToDelegate<MultiboardSuppressDisplayPrototype>();
            InternalNatives._SetCameraPosition = InternalNatives.Get("SetCameraPosition").ToDelegate<SetCameraPositionPrototype>();
            InternalNatives._SetCameraQuickPosition = InternalNatives.Get("SetCameraQuickPosition").ToDelegate<SetCameraQuickPositionPrototype>();
            InternalNatives._SetCameraBounds = InternalNatives.Get("SetCameraBounds").ToDelegate<SetCameraBoundsPrototype>();
            InternalNatives._StopCamera = InternalNatives.Get("StopCamera").ToDelegate<StopCameraPrototype>();
            InternalNatives._ResetToGameCamera = InternalNatives.Get("ResetToGameCamera").ToDelegate<ResetToGameCameraPrototype>();
            InternalNatives._PanCameraTo = InternalNatives.Get("PanCameraTo").ToDelegate<PanCameraToPrototype>();
            InternalNatives._PanCameraToTimed = InternalNatives.Get("PanCameraToTimed").ToDelegate<PanCameraToTimedPrototype>();
            InternalNatives._PanCameraToWithZ = InternalNatives.Get("PanCameraToWithZ").ToDelegate<PanCameraToWithZPrototype>();
            InternalNatives._PanCameraToTimedWithZ = InternalNatives.Get("PanCameraToTimedWithZ").ToDelegate<PanCameraToTimedWithZPrototype>();
            InternalNatives._SetCinematicCamera = InternalNatives.Get("SetCinematicCamera").ToDelegate<SetCinematicCameraPrototype>();
            InternalNatives._SetCameraRotateMode = InternalNatives.Get("SetCameraRotateMode").ToDelegate<SetCameraRotateModePrototype>();
            InternalNatives._SetCameraField = InternalNatives.Get("SetCameraField").ToDelegate<SetCameraFieldPrototype>();
            InternalNatives._AdjustCameraField = InternalNatives.Get("AdjustCameraField").ToDelegate<AdjustCameraFieldPrototype>();
            InternalNatives._SetCameraTargetController = InternalNatives.Get("SetCameraTargetController").ToDelegate<SetCameraTargetControllerPrototype>();
            InternalNatives._SetCameraOrientController = InternalNatives.Get("SetCameraOrientController").ToDelegate<SetCameraOrientControllerPrototype>();
            InternalNatives._CreateCameraSetup = InternalNatives.Get("CreateCameraSetup").ToDelegate<CreateCameraSetupPrototype>();
            InternalNatives._CameraSetupSetField = InternalNatives.Get("CameraSetupSetField").ToDelegate<CameraSetupSetFieldPrototype>();
            InternalNatives._CameraSetupGetField = InternalNatives.Get("CameraSetupGetField").ToDelegate<CameraSetupGetFieldPrototype>();
            InternalNatives._CameraSetupSetDestPosition = InternalNatives.Get("CameraSetupSetDestPosition").ToDelegate<CameraSetupSetDestPositionPrototype>();
            InternalNatives._CameraSetupGetDestPositionLoc = InternalNatives.Get("CameraSetupGetDestPositionLoc").ToDelegate<CameraSetupGetDestPositionLocPrototype>();
            InternalNatives._CameraSetupGetDestPositionX = InternalNatives.Get("CameraSetupGetDestPositionX").ToDelegate<CameraSetupGetDestPositionXPrototype>();
            InternalNatives._CameraSetupGetDestPositionY = InternalNatives.Get("CameraSetupGetDestPositionY").ToDelegate<CameraSetupGetDestPositionYPrototype>();
            InternalNatives._CameraSetupApply = InternalNatives.Get("CameraSetupApply").ToDelegate<CameraSetupApplyPrototype>();
            InternalNatives._CameraSetupApplyWithZ = InternalNatives.Get("CameraSetupApplyWithZ").ToDelegate<CameraSetupApplyWithZPrototype>();
            InternalNatives._CameraSetupApplyForceDuration = InternalNatives.Get("CameraSetupApplyForceDuration").ToDelegate<CameraSetupApplyForceDurationPrototype>();
            InternalNatives._CameraSetupApplyForceDurationWithZ = InternalNatives.Get("CameraSetupApplyForceDurationWithZ").ToDelegate<CameraSetupApplyForceDurationWithZPrototype>();
            InternalNatives._CameraSetTargetNoise = InternalNatives.Get("CameraSetTargetNoise").ToDelegate<CameraSetTargetNoisePrototype>();
            InternalNatives._CameraSetSourceNoise = InternalNatives.Get("CameraSetSourceNoise").ToDelegate<CameraSetSourceNoisePrototype>();
            InternalNatives._CameraSetTargetNoiseEx = InternalNatives.Get("CameraSetTargetNoiseEx").ToDelegate<CameraSetTargetNoiseExPrototype>();
            InternalNatives._CameraSetSourceNoiseEx = InternalNatives.Get("CameraSetSourceNoiseEx").ToDelegate<CameraSetSourceNoiseExPrototype>();
            InternalNatives._CameraSetSmoothingFactor = InternalNatives.Get("CameraSetSmoothingFactor").ToDelegate<CameraSetSmoothingFactorPrototype>();
            InternalNatives._SetCineFilterTexture = InternalNatives.Get("SetCineFilterTexture").ToDelegate<SetCineFilterTexturePrototype>();
            InternalNatives._SetCineFilterBlendMode = InternalNatives.Get("SetCineFilterBlendMode").ToDelegate<SetCineFilterBlendModePrototype>();
            InternalNatives._SetCineFilterTexMapFlags = InternalNatives.Get("SetCineFilterTexMapFlags").ToDelegate<SetCineFilterTexMapFlagsPrototype>();
            InternalNatives._SetCineFilterStartUV = InternalNatives.Get("SetCineFilterStartUV").ToDelegate<SetCineFilterStartUVPrototype>();
            InternalNatives._SetCineFilterEndUV = InternalNatives.Get("SetCineFilterEndUV").ToDelegate<SetCineFilterEndUVPrototype>();
            InternalNatives._SetCineFilterStartColor = InternalNatives.Get("SetCineFilterStartColor").ToDelegate<SetCineFilterStartColorPrototype>();
            InternalNatives._SetCineFilterEndColor = InternalNatives.Get("SetCineFilterEndColor").ToDelegate<SetCineFilterEndColorPrototype>();
            InternalNatives._SetCineFilterDuration = InternalNatives.Get("SetCineFilterDuration").ToDelegate<SetCineFilterDurationPrototype>();
            InternalNatives._DisplayCineFilter = InternalNatives.Get("DisplayCineFilter").ToDelegate<DisplayCineFilterPrototype>();
            InternalNatives._IsCineFilterDisplayed = InternalNatives.Get("IsCineFilterDisplayed").ToDelegate<IsCineFilterDisplayedPrototype>();
            InternalNatives._SetCinematicScene = InternalNatives.Get("SetCinematicScene").ToDelegate<SetCinematicScenePrototype>();
            InternalNatives._EndCinematicScene = InternalNatives.Get("EndCinematicScene").ToDelegate<EndCinematicScenePrototype>();
            InternalNatives._ForceCinematicSubtitles = InternalNatives.Get("ForceCinematicSubtitles").ToDelegate<ForceCinematicSubtitlesPrototype>();
            InternalNatives._GetCameraMargin = InternalNatives.Get("GetCameraMargin").ToDelegate<GetCameraMarginPrototype>();
            InternalNatives._GetCameraBoundMinX = InternalNatives.Get("GetCameraBoundMinX").ToDelegate<GetCameraBoundMinXPrototype>();
            InternalNatives._GetCameraBoundMinY = InternalNatives.Get("GetCameraBoundMinY").ToDelegate<GetCameraBoundMinYPrototype>();
            InternalNatives._GetCameraBoundMaxX = InternalNatives.Get("GetCameraBoundMaxX").ToDelegate<GetCameraBoundMaxXPrototype>();
            InternalNatives._GetCameraBoundMaxY = InternalNatives.Get("GetCameraBoundMaxY").ToDelegate<GetCameraBoundMaxYPrototype>();
            InternalNatives._GetCameraField = InternalNatives.Get("GetCameraField").ToDelegate<GetCameraFieldPrototype>();
            InternalNatives._GetCameraTargetPositionX = InternalNatives.Get("GetCameraTargetPositionX").ToDelegate<GetCameraTargetPositionXPrototype>();
            InternalNatives._GetCameraTargetPositionY = InternalNatives.Get("GetCameraTargetPositionY").ToDelegate<GetCameraTargetPositionYPrototype>();
            InternalNatives._GetCameraTargetPositionZ = InternalNatives.Get("GetCameraTargetPositionZ").ToDelegate<GetCameraTargetPositionZPrototype>();
            InternalNatives._GetCameraTargetPositionLoc = InternalNatives.Get("GetCameraTargetPositionLoc").ToDelegate<GetCameraTargetPositionLocPrototype>();
            InternalNatives._GetCameraEyePositionX = InternalNatives.Get("GetCameraEyePositionX").ToDelegate<GetCameraEyePositionXPrototype>();
            InternalNatives._GetCameraEyePositionY = InternalNatives.Get("GetCameraEyePositionY").ToDelegate<GetCameraEyePositionYPrototype>();
            InternalNatives._GetCameraEyePositionZ = InternalNatives.Get("GetCameraEyePositionZ").ToDelegate<GetCameraEyePositionZPrototype>();
            InternalNatives._GetCameraEyePositionLoc = InternalNatives.Get("GetCameraEyePositionLoc").ToDelegate<GetCameraEyePositionLocPrototype>();
            InternalNatives._NewSoundEnvironment = InternalNatives.Get("NewSoundEnvironment").ToDelegate<NewSoundEnvironmentPrototype>();
            InternalNatives._CreateSound = InternalNatives.Get("CreateSound").ToDelegate<CreateSoundPrototype>();
            InternalNatives._CreateSoundFilenameWithLabel = InternalNatives.Get("CreateSoundFilenameWithLabel").ToDelegate<CreateSoundFilenameWithLabelPrototype>();
            InternalNatives._CreateSoundFromLabel = InternalNatives.Get("CreateSoundFromLabel").ToDelegate<CreateSoundFromLabelPrototype>();
            InternalNatives._CreateMIDISound = InternalNatives.Get("CreateMIDISound").ToDelegate<CreateMIDISoundPrototype>();
            InternalNatives._SetSoundParamsFromLabel = InternalNatives.Get("SetSoundParamsFromLabel").ToDelegate<SetSoundParamsFromLabelPrototype>();
            InternalNatives._SetSoundDistanceCutoff = InternalNatives.Get("SetSoundDistanceCutoff").ToDelegate<SetSoundDistanceCutoffPrototype>();
            InternalNatives._SetSoundChannel = InternalNatives.Get("SetSoundChannel").ToDelegate<SetSoundChannelPrototype>();
            InternalNatives._SetSoundVolume = InternalNatives.Get("SetSoundVolume").ToDelegate<SetSoundVolumePrototype>();
            InternalNatives._SetSoundPitch = InternalNatives.Get("SetSoundPitch").ToDelegate<SetSoundPitchPrototype>();
            InternalNatives._SetSoundPlayPosition = InternalNatives.Get("SetSoundPlayPosition").ToDelegate<SetSoundPlayPositionPrototype>();
            InternalNatives._SetSoundDistances = InternalNatives.Get("SetSoundDistances").ToDelegate<SetSoundDistancesPrototype>();
            InternalNatives._SetSoundConeAngles = InternalNatives.Get("SetSoundConeAngles").ToDelegate<SetSoundConeAnglesPrototype>();
            InternalNatives._SetSoundConeOrientation = InternalNatives.Get("SetSoundConeOrientation").ToDelegate<SetSoundConeOrientationPrototype>();
            InternalNatives._SetSoundPosition = InternalNatives.Get("SetSoundPosition").ToDelegate<SetSoundPositionPrototype>();
            InternalNatives._SetSoundVelocity = InternalNatives.Get("SetSoundVelocity").ToDelegate<SetSoundVelocityPrototype>();
            InternalNatives._AttachSoundToUnit = InternalNatives.Get("AttachSoundToUnit").ToDelegate<AttachSoundToUnitPrototype>();
            InternalNatives._StartSound = InternalNatives.Get("StartSound").ToDelegate<StartSoundPrototype>();
            InternalNatives._StopSound = InternalNatives.Get("StopSound").ToDelegate<StopSoundPrototype>();
            InternalNatives._KillSoundWhenDone = InternalNatives.Get("KillSoundWhenDone").ToDelegate<KillSoundWhenDonePrototype>();
            InternalNatives._SetMapMusic = InternalNatives.Get("SetMapMusic").ToDelegate<SetMapMusicPrototype>();
            InternalNatives._ClearMapMusic = InternalNatives.Get("ClearMapMusic").ToDelegate<ClearMapMusicPrototype>();
            InternalNatives._PlayMusic = InternalNatives.Get("PlayMusic").ToDelegate<PlayMusicPrototype>();
            InternalNatives._PlayMusicEx = InternalNatives.Get("PlayMusicEx").ToDelegate<PlayMusicExPrototype>();
            InternalNatives._StopMusic = InternalNatives.Get("StopMusic").ToDelegate<StopMusicPrototype>();
            InternalNatives._ResumeMusic = InternalNatives.Get("ResumeMusic").ToDelegate<ResumeMusicPrototype>();
            InternalNatives._PlayThematicMusic = InternalNatives.Get("PlayThematicMusic").ToDelegate<PlayThematicMusicPrototype>();
            InternalNatives._PlayThematicMusicEx = InternalNatives.Get("PlayThematicMusicEx").ToDelegate<PlayThematicMusicExPrototype>();
            InternalNatives._EndThematicMusic = InternalNatives.Get("EndThematicMusic").ToDelegate<EndThematicMusicPrototype>();
            InternalNatives._SetMusicVolume = InternalNatives.Get("SetMusicVolume").ToDelegate<SetMusicVolumePrototype>();
            InternalNatives._SetMusicPlayPosition = InternalNatives.Get("SetMusicPlayPosition").ToDelegate<SetMusicPlayPositionPrototype>();
            InternalNatives._SetThematicMusicPlayPosition = InternalNatives.Get("SetThematicMusicPlayPosition").ToDelegate<SetThematicMusicPlayPositionPrototype>();
            InternalNatives._SetSoundDuration = InternalNatives.Get("SetSoundDuration").ToDelegate<SetSoundDurationPrototype>();
            InternalNatives._GetSoundDuration = InternalNatives.Get("GetSoundDuration").ToDelegate<GetSoundDurationPrototype>();
            InternalNatives._GetSoundFileDuration = InternalNatives.Get("GetSoundFileDuration").ToDelegate<GetSoundFileDurationPrototype>();
            InternalNatives._VolumeGroupSetVolume = InternalNatives.Get("VolumeGroupSetVolume").ToDelegate<VolumeGroupSetVolumePrototype>();
            InternalNatives._VolumeGroupReset = InternalNatives.Get("VolumeGroupReset").ToDelegate<VolumeGroupResetPrototype>();
            InternalNatives._GetSoundIsPlaying = InternalNatives.Get("GetSoundIsPlaying").ToDelegate<GetSoundIsPlayingPrototype>();
            InternalNatives._GetSoundIsLoading = InternalNatives.Get("GetSoundIsLoading").ToDelegate<GetSoundIsLoadingPrototype>();
            InternalNatives._RegisterStackedSound = InternalNatives.Get("RegisterStackedSound").ToDelegate<RegisterStackedSoundPrototype>();
            InternalNatives._UnregisterStackedSound = InternalNatives.Get("UnregisterStackedSound").ToDelegate<UnregisterStackedSoundPrototype>();
            InternalNatives._AddWeatherEffect = InternalNatives.Get("AddWeatherEffect").ToDelegate<AddWeatherEffectPrototype>();
            InternalNatives._RemoveWeatherEffect = InternalNatives.Get("RemoveWeatherEffect").ToDelegate<RemoveWeatherEffectPrototype>();
            InternalNatives._EnableWeatherEffect = InternalNatives.Get("EnableWeatherEffect").ToDelegate<EnableWeatherEffectPrototype>();
            InternalNatives._TerrainDeformCrater = InternalNatives.Get("TerrainDeformCrater").ToDelegate<TerrainDeformCraterPrototype>();
            InternalNatives._TerrainDeformRipple = InternalNatives.Get("TerrainDeformRipple").ToDelegate<TerrainDeformRipplePrototype>();
            InternalNatives._TerrainDeformWave = InternalNatives.Get("TerrainDeformWave").ToDelegate<TerrainDeformWavePrototype>();
            InternalNatives._TerrainDeformRandom = InternalNatives.Get("TerrainDeformRandom").ToDelegate<TerrainDeformRandomPrototype>();
            InternalNatives._TerrainDeformStop = InternalNatives.Get("TerrainDeformStop").ToDelegate<TerrainDeformStopPrototype>();
            InternalNatives._TerrainDeformStopAll = InternalNatives.Get("TerrainDeformStopAll").ToDelegate<TerrainDeformStopAllPrototype>();
            InternalNatives._AddSpecialEffect = InternalNatives.Get("AddSpecialEffect").ToDelegate<AddSpecialEffectPrototype>();
            InternalNatives._AddSpecialEffectLoc = InternalNatives.Get("AddSpecialEffectLoc").ToDelegate<AddSpecialEffectLocPrototype>();
            InternalNatives._AddSpecialEffectTarget = InternalNatives.Get("AddSpecialEffectTarget").ToDelegate<AddSpecialEffectTargetPrototype>();
            InternalNatives._DestroyEffect = InternalNatives.Get("DestroyEffect").ToDelegate<DestroyEffectPrototype>();
            InternalNatives._AddSpellEffect = InternalNatives.Get("AddSpellEffect").ToDelegate<AddSpellEffectPrototype>();
            InternalNatives._AddSpellEffectLoc = InternalNatives.Get("AddSpellEffectLoc").ToDelegate<AddSpellEffectLocPrototype>();
            InternalNatives._AddSpellEffectById = InternalNatives.Get("AddSpellEffectById").ToDelegate<AddSpellEffectByIdPrototype>();
            InternalNatives._AddSpellEffectByIdLoc = InternalNatives.Get("AddSpellEffectByIdLoc").ToDelegate<AddSpellEffectByIdLocPrototype>();
            InternalNatives._AddSpellEffectTarget = InternalNatives.Get("AddSpellEffectTarget").ToDelegate<AddSpellEffectTargetPrototype>();
            InternalNatives._AddSpellEffectTargetById = InternalNatives.Get("AddSpellEffectTargetById").ToDelegate<AddSpellEffectTargetByIdPrototype>();
            InternalNatives._AddLightning = InternalNatives.Get("AddLightning").ToDelegate<AddLightningPrototype>();
            InternalNatives._AddLightningEx = InternalNatives.Get("AddLightningEx").ToDelegate<AddLightningExPrototype>();
            InternalNatives._DestroyLightning = InternalNatives.Get("DestroyLightning").ToDelegate<DestroyLightningPrototype>();
            InternalNatives._MoveLightning = InternalNatives.Get("MoveLightning").ToDelegate<MoveLightningPrototype>();
            InternalNatives._MoveLightningEx = InternalNatives.Get("MoveLightningEx").ToDelegate<MoveLightningExPrototype>();
            InternalNatives._GetLightningColorA = InternalNatives.Get("GetLightningColorA").ToDelegate<GetLightningColorAPrototype>();
            InternalNatives._GetLightningColorR = InternalNatives.Get("GetLightningColorR").ToDelegate<GetLightningColorRPrototype>();
            InternalNatives._GetLightningColorG = InternalNatives.Get("GetLightningColorG").ToDelegate<GetLightningColorGPrototype>();
            InternalNatives._GetLightningColorB = InternalNatives.Get("GetLightningColorB").ToDelegate<GetLightningColorBPrototype>();
            InternalNatives._SetLightningColor = InternalNatives.Get("SetLightningColor").ToDelegate<SetLightningColorPrototype>();
            InternalNatives._GetAbilityEffect = InternalNatives.Get("GetAbilityEffect").ToDelegate<GetAbilityEffectPrototype>();
            InternalNatives._GetAbilityEffectById = InternalNatives.Get("GetAbilityEffectById").ToDelegate<GetAbilityEffectByIdPrototype>();
            InternalNatives._GetAbilitySound = InternalNatives.Get("GetAbilitySound").ToDelegate<GetAbilitySoundPrototype>();
            InternalNatives._GetAbilitySoundById = InternalNatives.Get("GetAbilitySoundById").ToDelegate<GetAbilitySoundByIdPrototype>();
            InternalNatives._GetTerrainCliffLevel = InternalNatives.Get("GetTerrainCliffLevel").ToDelegate<GetTerrainCliffLevelPrototype>();
            InternalNatives._SetWaterBaseColor = InternalNatives.Get("SetWaterBaseColor").ToDelegate<SetWaterBaseColorPrototype>();
            InternalNatives._SetWaterDeforms = InternalNatives.Get("SetWaterDeforms").ToDelegate<SetWaterDeformsPrototype>();
            InternalNatives._GetTerrainType = InternalNatives.Get("GetTerrainType").ToDelegate<GetTerrainTypePrototype>();
            InternalNatives._GetTerrainVariance = InternalNatives.Get("GetTerrainVariance").ToDelegate<GetTerrainVariancePrototype>();
            InternalNatives._SetTerrainType = InternalNatives.Get("SetTerrainType").ToDelegate<SetTerrainTypePrototype>();
            InternalNatives._IsTerrainPathable = InternalNatives.Get("IsTerrainPathable").ToDelegate<IsTerrainPathablePrototype>();
            InternalNatives._SetTerrainPathable = InternalNatives.Get("SetTerrainPathable").ToDelegate<SetTerrainPathablePrototype>();
            InternalNatives._CreateImage = InternalNatives.Get("CreateImage").ToDelegate<CreateImagePrototype>();
            InternalNatives._DestroyImage = InternalNatives.Get("DestroyImage").ToDelegate<DestroyImagePrototype>();
            InternalNatives._ShowImage = InternalNatives.Get("ShowImage").ToDelegate<ShowImagePrototype>();
            InternalNatives._SetImageConstantHeight = InternalNatives.Get("SetImageConstantHeight").ToDelegate<SetImageConstantHeightPrototype>();
            InternalNatives._SetImagePosition = InternalNatives.Get("SetImagePosition").ToDelegate<SetImagePositionPrototype>();
            InternalNatives._SetImageColor = InternalNatives.Get("SetImageColor").ToDelegate<SetImageColorPrototype>();
            InternalNatives._SetImageRender = InternalNatives.Get("SetImageRender").ToDelegate<SetImageRenderPrototype>();
            InternalNatives._SetImageRenderAlways = InternalNatives.Get("SetImageRenderAlways").ToDelegate<SetImageRenderAlwaysPrototype>();
            InternalNatives._SetImageAboveWater = InternalNatives.Get("SetImageAboveWater").ToDelegate<SetImageAboveWaterPrototype>();
            InternalNatives._SetImageType = InternalNatives.Get("SetImageType").ToDelegate<SetImageTypePrototype>();
            InternalNatives._CreateUbersplat = InternalNatives.Get("CreateUbersplat").ToDelegate<CreateUbersplatPrototype>();
            InternalNatives._DestroyUbersplat = InternalNatives.Get("DestroyUbersplat").ToDelegate<DestroyUbersplatPrototype>();
            InternalNatives._ResetUbersplat = InternalNatives.Get("ResetUbersplat").ToDelegate<ResetUbersplatPrototype>();
            InternalNatives._FinishUbersplat = InternalNatives.Get("FinishUbersplat").ToDelegate<FinishUbersplatPrototype>();
            InternalNatives._ShowUbersplat = InternalNatives.Get("ShowUbersplat").ToDelegate<ShowUbersplatPrototype>();
            InternalNatives._SetUbersplatRender = InternalNatives.Get("SetUbersplatRender").ToDelegate<SetUbersplatRenderPrototype>();
            InternalNatives._SetUbersplatRenderAlways = InternalNatives.Get("SetUbersplatRenderAlways").ToDelegate<SetUbersplatRenderAlwaysPrototype>();
            InternalNatives._SetBlight = InternalNatives.Get("SetBlight").ToDelegate<SetBlightPrototype>();
            InternalNatives._SetBlightRect = InternalNatives.Get("SetBlightRect").ToDelegate<SetBlightRectPrototype>();
            InternalNatives._SetBlightPoint = InternalNatives.Get("SetBlightPoint").ToDelegate<SetBlightPointPrototype>();
            InternalNatives._SetBlightLoc = InternalNatives.Get("SetBlightLoc").ToDelegate<SetBlightLocPrototype>();
            InternalNatives._CreateBlightedGoldmine = InternalNatives.Get("CreateBlightedGoldmine").ToDelegate<CreateBlightedGoldminePrototype>();
            InternalNatives._IsPointBlighted = InternalNatives.Get("IsPointBlighted").ToDelegate<IsPointBlightedPrototype>();
            InternalNatives._SetDoodadAnimation = InternalNatives.Get("SetDoodadAnimation").ToDelegate<SetDoodadAnimationPrototype>();
            InternalNatives._SetDoodadAnimationRect = InternalNatives.Get("SetDoodadAnimationRect").ToDelegate<SetDoodadAnimationRectPrototype>();
            InternalNatives._StartMeleeAI = InternalNatives.Get("StartMeleeAI").ToDelegate<StartMeleeAIPrototype>();
            InternalNatives._StartCampaignAI = InternalNatives.Get("StartCampaignAI").ToDelegate<StartCampaignAIPrototype>();
            InternalNatives._CommandAI = InternalNatives.Get("CommandAI").ToDelegate<CommandAIPrototype>();
            InternalNatives._PauseCompAI = InternalNatives.Get("PauseCompAI").ToDelegate<PauseCompAIPrototype>();
            InternalNatives._GetAIDifficulty = InternalNatives.Get("GetAIDifficulty").ToDelegate<GetAIDifficultyPrototype>();
            InternalNatives._RemoveGuardPosition = InternalNatives.Get("RemoveGuardPosition").ToDelegate<RemoveGuardPositionPrototype>();
            InternalNatives._RecycleGuardPosition = InternalNatives.Get("RecycleGuardPosition").ToDelegate<RecycleGuardPositionPrototype>();
            InternalNatives._RemoveAllGuardPositions = InternalNatives.Get("RemoveAllGuardPositions").ToDelegate<RemoveAllGuardPositionsPrototype>();
            InternalNatives._Cheat = InternalNatives.Get("Cheat").ToDelegate<CheatPrototype>();
            InternalNatives._IsNoVictoryCheat = InternalNatives.Get("IsNoVictoryCheat").ToDelegate<IsNoVictoryCheatPrototype>();
            InternalNatives._IsNoDefeatCheat = InternalNatives.Get("IsNoDefeatCheat").ToDelegate<IsNoDefeatCheatPrototype>();
            InternalNatives._Preload = InternalNatives.Get("Preload").ToDelegate<PreloadPrototype>();
            InternalNatives._PreloadEnd = InternalNatives.Get("PreloadEnd").ToDelegate<PreloadEndPrototype>();
            InternalNatives._PreloadStart = InternalNatives.Get("PreloadStart").ToDelegate<PreloadStartPrototype>();
            InternalNatives._PreloadRefresh = InternalNatives.Get("PreloadRefresh").ToDelegate<PreloadRefreshPrototype>();
            InternalNatives._PreloadEndEx = InternalNatives.Get("PreloadEndEx").ToDelegate<PreloadEndExPrototype>();
            InternalNatives._PreloadGenClear = InternalNatives.Get("PreloadGenClear").ToDelegate<PreloadGenClearPrototype>();
            InternalNatives._PreloadGenStart = InternalNatives.Get("PreloadGenStart").ToDelegate<PreloadGenStartPrototype>();
            InternalNatives._PreloadGenEnd = InternalNatives.Get("PreloadGenEnd").ToDelegate<PreloadGenEndPrototype>();
            InternalNatives._Preloader = InternalNatives.Get("Preloader").ToDelegate<PreloaderPrototype>();
        }
    }
}
