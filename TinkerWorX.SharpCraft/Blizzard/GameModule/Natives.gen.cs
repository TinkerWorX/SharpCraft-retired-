using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Interfaces;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static partial class Natives
    {
        //native ConvertRace takes integer i returns race
        public delegate JassRace ConvertRacePrototype(JassInteger i);
        private static ConvertRacePrototype _ConvertRace;
        public static JassRace ConvertRace(JassInteger i)
        {
            return Natives._ConvertRace(i);
        }
        
        //native ConvertAllianceType takes integer i returns alliancetype
        public delegate JassAllianceType ConvertAllianceTypePrototype(JassInteger i);
        private static ConvertAllianceTypePrototype _ConvertAllianceType;
        public static JassAllianceType ConvertAllianceType(JassInteger i)
        {
            return Natives._ConvertAllianceType(i);
        }
        
        //native ConvertRacePref takes integer i returns racepreference
        public delegate JassRacePreference ConvertRacePrefPrototype(JassInteger i);
        private static ConvertRacePrefPrototype _ConvertRacePref;
        public static JassRacePreference ConvertRacePref(JassInteger i)
        {
            return Natives._ConvertRacePref(i);
        }
        
        //native ConvertIGameState takes integer i returns igamestate
        public delegate JassIGameState ConvertIGameStatePrototype(JassInteger i);
        private static ConvertIGameStatePrototype _ConvertIGameState;
        public static JassIGameState ConvertIGameState(JassInteger i)
        {
            return Natives._ConvertIGameState(i);
        }
        
        //native ConvertFGameState takes integer i returns fgamestate
        public delegate JassFGameState ConvertFGameStatePrototype(JassInteger i);
        private static ConvertFGameStatePrototype _ConvertFGameState;
        public static JassFGameState ConvertFGameState(JassInteger i)
        {
            return Natives._ConvertFGameState(i);
        }
        
        //native ConvertPlayerState takes integer i returns playerstate
        public delegate JassPlayerState ConvertPlayerStatePrototype(JassInteger i);
        private static ConvertPlayerStatePrototype _ConvertPlayerState;
        public static JassPlayerState ConvertPlayerState(JassInteger i)
        {
            return Natives._ConvertPlayerState(i);
        }
        
        //native ConvertPlayerScore takes integer i returns playerscore
        public delegate JassPlayerScore ConvertPlayerScorePrototype(JassInteger i);
        private static ConvertPlayerScorePrototype _ConvertPlayerScore;
        public static JassPlayerScore ConvertPlayerScore(JassInteger i)
        {
            return Natives._ConvertPlayerScore(i);
        }
        
        //native ConvertPlayerGameResult takes integer i returns playergameresult
        public delegate JassPlayerGameResult ConvertPlayerGameResultPrototype(JassInteger i);
        private static ConvertPlayerGameResultPrototype _ConvertPlayerGameResult;
        public static JassPlayerGameResult ConvertPlayerGameResult(JassInteger i)
        {
            return Natives._ConvertPlayerGameResult(i);
        }
        
        //native ConvertUnitState takes integer i returns unitstate
        public delegate JassUnitState ConvertUnitStatePrototype(JassInteger i);
        private static ConvertUnitStatePrototype _ConvertUnitState;
        public static JassUnitState ConvertUnitState(JassInteger i)
        {
            return Natives._ConvertUnitState(i);
        }
        
        //native ConvertAIDifficulty takes integer i returns aidifficulty
        public delegate JassAIDifficulty ConvertAIDifficultyPrototype(JassInteger i);
        private static ConvertAIDifficultyPrototype _ConvertAIDifficulty;
        public static JassAIDifficulty ConvertAIDifficulty(JassInteger i)
        {
            return Natives._ConvertAIDifficulty(i);
        }
        
        //native ConvertGameEvent takes integer i returns gameevent
        public delegate JassGameEvent ConvertGameEventPrototype(JassInteger i);
        private static ConvertGameEventPrototype _ConvertGameEvent;
        public static JassGameEvent ConvertGameEvent(JassInteger i)
        {
            return Natives._ConvertGameEvent(i);
        }
        
        //native ConvertPlayerEvent takes integer i returns playerevent
        public delegate JassPlayerEvent ConvertPlayerEventPrototype(JassInteger i);
        private static ConvertPlayerEventPrototype _ConvertPlayerEvent;
        public static JassPlayerEvent ConvertPlayerEvent(JassInteger i)
        {
            return Natives._ConvertPlayerEvent(i);
        }
        
        //native ConvertPlayerUnitEvent takes integer i returns playerunitevent
        public delegate JassPlayerUnitEvent ConvertPlayerUnitEventPrototype(JassInteger i);
        private static ConvertPlayerUnitEventPrototype _ConvertPlayerUnitEvent;
        public static JassPlayerUnitEvent ConvertPlayerUnitEvent(JassInteger i)
        {
            return Natives._ConvertPlayerUnitEvent(i);
        }
        
        //native ConvertWidgetEvent takes integer i returns widgetevent
        public delegate JassWidgetEvent ConvertWidgetEventPrototype(JassInteger i);
        private static ConvertWidgetEventPrototype _ConvertWidgetEvent;
        public static JassWidgetEvent ConvertWidgetEvent(JassInteger i)
        {
            return Natives._ConvertWidgetEvent(i);
        }
        
        //native ConvertDialogEvent takes integer i returns dialogevent
        public delegate JassDialogEvent ConvertDialogEventPrototype(JassInteger i);
        private static ConvertDialogEventPrototype _ConvertDialogEvent;
        public static JassDialogEvent ConvertDialogEvent(JassInteger i)
        {
            return Natives._ConvertDialogEvent(i);
        }
        
        //native ConvertUnitEvent takes integer i returns unitevent
        public delegate JassUnitEvent ConvertUnitEventPrototype(JassInteger i);
        private static ConvertUnitEventPrototype _ConvertUnitEvent;
        public static JassUnitEvent ConvertUnitEvent(JassInteger i)
        {
            return Natives._ConvertUnitEvent(i);
        }
        
        //native ConvertLimitOp takes integer i returns limitop
        public delegate JassLimitOp ConvertLimitOpPrototype(JassInteger i);
        private static ConvertLimitOpPrototype _ConvertLimitOp;
        public static JassLimitOp ConvertLimitOp(JassInteger i)
        {
            return Natives._ConvertLimitOp(i);
        }
        
        //native ConvertUnitType takes integer i returns unittype
        public delegate JassUnitType ConvertUnitTypePrototype(JassInteger i);
        private static ConvertUnitTypePrototype _ConvertUnitType;
        public static JassUnitType ConvertUnitType(JassInteger i)
        {
            return Natives._ConvertUnitType(i);
        }
        
        //native ConvertGameSpeed takes integer i returns gamespeed
        public delegate JassGameSpeed ConvertGameSpeedPrototype(JassInteger i);
        private static ConvertGameSpeedPrototype _ConvertGameSpeed;
        public static JassGameSpeed ConvertGameSpeed(JassInteger i)
        {
            return Natives._ConvertGameSpeed(i);
        }
        
        //native ConvertPlacement takes integer i returns placement
        public delegate JassPlacement ConvertPlacementPrototype(JassInteger i);
        private static ConvertPlacementPrototype _ConvertPlacement;
        public static JassPlacement ConvertPlacement(JassInteger i)
        {
            return Natives._ConvertPlacement(i);
        }
        
        //native ConvertStartLocPrio takes integer i returns startlocprio
        public delegate JassStartLocationPriority ConvertStartLocPrioPrototype(JassInteger i);
        private static ConvertStartLocPrioPrototype _ConvertStartLocPrio;
        public static JassStartLocationPriority ConvertStartLocPrio(JassInteger i)
        {
            return Natives._ConvertStartLocPrio(i);
        }
        
        //native ConvertGameDifficulty takes integer i returns gamedifficulty
        public delegate JassGameDifficulty ConvertGameDifficultyPrototype(JassInteger i);
        private static ConvertGameDifficultyPrototype _ConvertGameDifficulty;
        public static JassGameDifficulty ConvertGameDifficulty(JassInteger i)
        {
            return Natives._ConvertGameDifficulty(i);
        }
        
        //native ConvertGameType takes integer i returns gametype
        public delegate JassGameType ConvertGameTypePrototype(JassInteger i);
        private static ConvertGameTypePrototype _ConvertGameType;
        public static JassGameType ConvertGameType(JassInteger i)
        {
            return Natives._ConvertGameType(i);
        }
        
        //native ConvertMapFlag takes integer i returns mapflag
        public delegate JassMapFlag ConvertMapFlagPrototype(JassInteger i);
        private static ConvertMapFlagPrototype _ConvertMapFlag;
        public static JassMapFlag ConvertMapFlag(JassInteger i)
        {
            return Natives._ConvertMapFlag(i);
        }
        
        //native ConvertMapVisibility takes integer i returns mapvisibility
        public delegate JassMapVisibility ConvertMapVisibilityPrototype(JassInteger i);
        private static ConvertMapVisibilityPrototype _ConvertMapVisibility;
        public static JassMapVisibility ConvertMapVisibility(JassInteger i)
        {
            return Natives._ConvertMapVisibility(i);
        }
        
        //native ConvertMapSetting takes integer i returns mapsetting
        public delegate JassMapSetting ConvertMapSettingPrototype(JassInteger i);
        private static ConvertMapSettingPrototype _ConvertMapSetting;
        public static JassMapSetting ConvertMapSetting(JassInteger i)
        {
            return Natives._ConvertMapSetting(i);
        }
        
        //native ConvertMapDensity takes integer i returns mapdensity
        public delegate JassMapDensity ConvertMapDensityPrototype(JassInteger i);
        private static ConvertMapDensityPrototype _ConvertMapDensity;
        public static JassMapDensity ConvertMapDensity(JassInteger i)
        {
            return Natives._ConvertMapDensity(i);
        }
        
        //native ConvertMapControl takes integer i returns mapcontrol
        public delegate JassMapControl ConvertMapControlPrototype(JassInteger i);
        private static ConvertMapControlPrototype _ConvertMapControl;
        public static JassMapControl ConvertMapControl(JassInteger i)
        {
            return Natives._ConvertMapControl(i);
        }
        
        //native ConvertPlayerColor takes integer i returns playercolor
        public delegate JassPlayerColor ConvertPlayerColorPrototype(JassInteger i);
        private static ConvertPlayerColorPrototype _ConvertPlayerColor;
        public static JassPlayerColor ConvertPlayerColor(JassInteger i)
        {
            return Natives._ConvertPlayerColor(i);
        }
        
        //native ConvertPlayerSlotState takes integer i returns playerslotstate
        public delegate JassPlayerSlotState ConvertPlayerSlotStatePrototype(JassInteger i);
        private static ConvertPlayerSlotStatePrototype _ConvertPlayerSlotState;
        public static JassPlayerSlotState ConvertPlayerSlotState(JassInteger i)
        {
            return Natives._ConvertPlayerSlotState(i);
        }
        
        //native ConvertVolumeGroup takes integer i returns volumegroup
        public delegate JassVolumeGroup ConvertVolumeGroupPrototype(JassInteger i);
        private static ConvertVolumeGroupPrototype _ConvertVolumeGroup;
        public static JassVolumeGroup ConvertVolumeGroup(JassInteger i)
        {
            return Natives._ConvertVolumeGroup(i);
        }
        
        //native ConvertCameraField takes integer i returns camerafield
        public delegate JassCameraField ConvertCameraFieldPrototype(JassInteger i);
        private static ConvertCameraFieldPrototype _ConvertCameraField;
        public static JassCameraField ConvertCameraField(JassInteger i)
        {
            return Natives._ConvertCameraField(i);
        }
        
        //native ConvertBlendMode takes integer i returns blendmode
        public delegate JassBlendMode ConvertBlendModePrototype(JassInteger i);
        private static ConvertBlendModePrototype _ConvertBlendMode;
        public static JassBlendMode ConvertBlendMode(JassInteger i)
        {
            return Natives._ConvertBlendMode(i);
        }
        
        //native ConvertRarityControl takes integer i returns raritycontrol
        public delegate JassRarityControl ConvertRarityControlPrototype(JassInteger i);
        private static ConvertRarityControlPrototype _ConvertRarityControl;
        public static JassRarityControl ConvertRarityControl(JassInteger i)
        {
            return Natives._ConvertRarityControl(i);
        }
        
        //native ConvertTexMapFlags takes integer i returns texmapflags
        public delegate JassTextureMapFlags ConvertTexMapFlagsPrototype(JassInteger i);
        private static ConvertTexMapFlagsPrototype _ConvertTexMapFlags;
        public static JassTextureMapFlags ConvertTexMapFlags(JassInteger i)
        {
            return Natives._ConvertTexMapFlags(i);
        }
        
        //native ConvertFogState takes integer i returns fogstate
        public delegate JassFogState ConvertFogStatePrototype(JassInteger i);
        private static ConvertFogStatePrototype _ConvertFogState;
        public static JassFogState ConvertFogState(JassInteger i)
        {
            return Natives._ConvertFogState(i);
        }
        
        //native ConvertEffectType takes integer i returns effecttype
        public delegate JassEffectType ConvertEffectTypePrototype(JassInteger i);
        private static ConvertEffectTypePrototype _ConvertEffectType;
        public static JassEffectType ConvertEffectType(JassInteger i)
        {
            return Natives._ConvertEffectType(i);
        }
        
        //native ConvertVersion takes integer i returns version
        public delegate JassVersion ConvertVersionPrototype(JassInteger i);
        private static ConvertVersionPrototype _ConvertVersion;
        public static JassVersion ConvertVersion(JassInteger i)
        {
            return Natives._ConvertVersion(i);
        }
        
        //native ConvertItemType takes integer i returns itemtype
        public delegate JassItemType ConvertItemTypePrototype(JassInteger i);
        private static ConvertItemTypePrototype _ConvertItemType;
        public static JassItemType ConvertItemType(JassInteger i)
        {
            return Natives._ConvertItemType(i);
        }
        
        //native ConvertAttackType takes integer i returns attacktype
        public delegate JassAttackType ConvertAttackTypePrototype(JassInteger i);
        private static ConvertAttackTypePrototype _ConvertAttackType;
        public static JassAttackType ConvertAttackType(JassInteger i)
        {
            return Natives._ConvertAttackType(i);
        }
        
        //native ConvertDamageType takes integer i returns damagetype
        public delegate JassDamageType ConvertDamageTypePrototype(JassInteger i);
        private static ConvertDamageTypePrototype _ConvertDamageType;
        public static JassDamageType ConvertDamageType(JassInteger i)
        {
            return Natives._ConvertDamageType(i);
        }
        
        //native ConvertWeaponType takes integer i returns weapontype
        public delegate JassWeaponType ConvertWeaponTypePrototype(JassInteger i);
        private static ConvertWeaponTypePrototype _ConvertWeaponType;
        public static JassWeaponType ConvertWeaponType(JassInteger i)
        {
            return Natives._ConvertWeaponType(i);
        }
        
        //native ConvertSoundType takes integer i returns soundtype
        public delegate JassSoundType ConvertSoundTypePrototype(JassInteger i);
        private static ConvertSoundTypePrototype _ConvertSoundType;
        public static JassSoundType ConvertSoundType(JassInteger i)
        {
            return Natives._ConvertSoundType(i);
        }
        
        //native ConvertPathingType takes integer i returns pathingtype
        public delegate JassPathingType ConvertPathingTypePrototype(JassInteger i);
        private static ConvertPathingTypePrototype _ConvertPathingType;
        public static JassPathingType ConvertPathingType(JassInteger i)
        {
            return Natives._ConvertPathingType(i);
        }
        
        //native OrderId takes string orderIdString returns integer
        public delegate JassOrder OrderIdPrototype(JassStringArg orderIdString);
        private static OrderIdPrototype _OrderId;
        public static JassOrder OrderId(String orderIdString)
        {
            return Natives._OrderId(orderIdString);
        }
        
        //native OrderId2String takes integer orderId returns string
        public delegate JassStringRet OrderId2StringPrototype(JassOrder orderId);
        private static OrderId2StringPrototype _OrderId2String;
        public static String OrderId2String(JassOrder orderId)
        {
            return Natives._OrderId2String(orderId);
        }
        
        //native UnitId takes string unitIdString returns integer
        public delegate JassObjectId UnitIdPrototype(JassStringArg unitIdString);
        private static UnitIdPrototype _UnitId;
        public static JassObjectId UnitId(String unitIdString)
        {
            return Natives._UnitId(unitIdString);
        }
        
        //native UnitId2String takes integer unitId returns string
        public delegate JassStringRet UnitId2StringPrototype(JassObjectId unitId);
        private static UnitId2StringPrototype _UnitId2String;
        public static String UnitId2String(JassObjectId unitId)
        {
            return Natives._UnitId2String(unitId);
        }
        
        //native AbilityId takes string abilityIdString returns integer
        public delegate JassObjectId AbilityIdPrototype(JassStringArg abilityIdString);
        private static AbilityIdPrototype _AbilityId;
        public static JassObjectId AbilityId(String abilityIdString)
        {
            return Natives._AbilityId(abilityIdString);
        }
        
        //native AbilityId2String takes integer abilityId returns string
        public delegate JassStringRet AbilityId2StringPrototype(JassInteger abilityId);
        private static AbilityId2StringPrototype _AbilityId2String;
        public static String AbilityId2String(JassInteger abilityId)
        {
            return Natives._AbilityId2String(abilityId);
        }
        
        //native GetObjectName takes integer objectId returns string
        public delegate JassStringRet GetObjectNamePrototype(JassObjectId objectId);
        private static GetObjectNamePrototype _GetObjectName;
        public static String GetObjectName(JassObjectId objectId)
        {
            return Natives._GetObjectName(objectId);
        }
        
        //native Deg2Rad takes real degrees returns real
        public delegate JassRealRet Deg2RadPrototype(JassRealArg degrees);
        private static Deg2RadPrototype _Deg2Rad;
        public static Single Deg2Rad(Single degrees)
        {
            return Natives._Deg2Rad(degrees);
        }
        
        //native Rad2Deg takes real radians returns real
        public delegate JassRealRet Rad2DegPrototype(JassRealArg radians);
        private static Rad2DegPrototype _Rad2Deg;
        public static Single Rad2Deg(Single radians)
        {
            return Natives._Rad2Deg(radians);
        }
        
        //native Sin takes real radians returns real
        public delegate JassRealRet SinPrototype(JassRealArg radians);
        private static SinPrototype _Sin;
        public static Single Sin(Single radians)
        {
            return Natives._Sin(radians);
        }
        
        //native Cos takes real radians returns real
        public delegate JassRealRet CosPrototype(JassRealArg radians);
        private static CosPrototype _Cos;
        public static Single Cos(Single radians)
        {
            return Natives._Cos(radians);
        }
        
        //native Tan takes real radians returns real
        public delegate JassRealRet TanPrototype(JassRealArg radians);
        private static TanPrototype _Tan;
        public static Single Tan(Single radians)
        {
            return Natives._Tan(radians);
        }
        
        //native Asin takes real y returns real
        public delegate JassRealRet AsinPrototype(JassRealArg y);
        private static AsinPrototype _Asin;
        public static Single Asin(Single y)
        {
            return Natives._Asin(y);
        }
        
        //native Acos takes real x returns real
        public delegate JassRealRet AcosPrototype(JassRealArg x);
        private static AcosPrototype _Acos;
        public static Single Acos(Single x)
        {
            return Natives._Acos(x);
        }
        
        //native Atan takes real x returns real
        public delegate JassRealRet AtanPrototype(JassRealArg x);
        private static AtanPrototype _Atan;
        public static Single Atan(Single x)
        {
            return Natives._Atan(x);
        }
        
        //native Atan2 takes real y, real x returns real
        public delegate JassRealRet Atan2Prototype(JassRealArg y, JassRealArg x);
        private static Atan2Prototype _Atan2;
        public static Single Atan2(Single y, Single x)
        {
            return Natives._Atan2(y, x);
        }
        
        //native SquareRoot takes real x returns real
        public delegate JassRealRet SquareRootPrototype(JassRealArg x);
        private static SquareRootPrototype _SquareRoot;
        public static Single SquareRoot(Single x)
        {
            return Natives._SquareRoot(x);
        }
        
        //native Pow takes real x, real power returns real
        public delegate JassRealRet PowPrototype(JassRealArg x, JassRealArg power);
        private static PowPrototype _Pow;
        public static Single Pow(Single x, Single power)
        {
            return Natives._Pow(x, power);
        }
        
        //native I2R takes integer i returns real
        public delegate JassRealRet I2RPrototype(JassInteger i);
        private static I2RPrototype _I2R;
        public static Single I2R(JassInteger i)
        {
            return Natives._I2R(i);
        }
        
        //native R2I takes real r returns integer
        public delegate JassInteger R2IPrototype(JassRealArg r);
        private static R2IPrototype _R2I;
        public static JassInteger R2I(Single r)
        {
            return Natives._R2I(r);
        }
        
        //native I2S takes integer i returns string
        public delegate JassStringRet I2SPrototype(JassInteger i);
        private static I2SPrototype _I2S;
        public static String I2S(JassInteger i)
        {
            return Natives._I2S(i);
        }
        
        //native R2S takes real r returns string
        public delegate JassStringRet R2SPrototype(JassRealArg r);
        private static R2SPrototype _R2S;
        public static String R2S(Single r)
        {
            return Natives._R2S(r);
        }
        
        //native R2SW takes real r, integer width, integer precision returns string
        public delegate JassStringRet R2SWPrototype(JassRealArg r, JassInteger width, JassInteger precision);
        private static R2SWPrototype _R2SW;
        public static String R2SW(Single r, JassInteger width, JassInteger precision)
        {
            return Natives._R2SW(r, width, precision);
        }
        
        //native S2I takes string s returns integer
        public delegate JassInteger S2IPrototype(JassStringArg s);
        private static S2IPrototype _S2I;
        public static JassInteger S2I(String s)
        {
            return Natives._S2I(s);
        }
        
        //native S2R takes string s returns real
        public delegate JassRealRet S2RPrototype(JassStringArg s);
        private static S2RPrototype _S2R;
        public static Single S2R(String s)
        {
            return Natives._S2R(s);
        }
        
        //native GetHandleId takes handle h returns integer
        public delegate JassInteger GetHandleIdPrototype(JassHandle h);
        private static GetHandleIdPrototype _GetHandleId;
        public static JassInteger GetHandleId(JassHandle h)
        {
            return Natives._GetHandleId(h);
        }
        
        //native SubString takes string source, integer start, integer end returns string
        public delegate JassStringRet SubStringPrototype(JassStringArg source, JassInteger start, JassInteger end);
        private static SubStringPrototype _SubString;
        public static String SubString(String source, JassInteger start, JassInteger end)
        {
            return Natives._SubString(source, start, end);
        }
        
        //native StringLength takes string s returns integer
        public delegate JassInteger StringLengthPrototype(JassStringArg s);
        private static StringLengthPrototype _StringLength;
        public static JassInteger StringLength(String s)
        {
            return Natives._StringLength(s);
        }
        
        //native StringCase takes string source, boolean upper returns string
        public delegate JassStringRet StringCasePrototype(JassStringArg source, JassBoolean upper);
        private static StringCasePrototype _StringCase;
        public static String StringCase(String source, Boolean upper)
        {
            return Natives._StringCase(source, upper);
        }
        
        //native StringHash takes string s returns integer
        public delegate JassInteger StringHashPrototype(JassStringArg s);
        private static StringHashPrototype _StringHash;
        public static JassInteger StringHash(String s)
        {
            return Natives._StringHash(s);
        }
        
        //native GetLocalizedString takes string source returns string
        public delegate JassStringRet GetLocalizedStringPrototype(JassStringArg source);
        private static GetLocalizedStringPrototype _GetLocalizedString;
        public static String GetLocalizedString(String source)
        {
            return Natives._GetLocalizedString(source);
        }
        
        //native GetLocalizedHotkey takes string source returns integer
        public delegate JassInteger GetLocalizedHotkeyPrototype(JassStringArg source);
        private static GetLocalizedHotkeyPrototype _GetLocalizedHotkey;
        public static JassInteger GetLocalizedHotkey(String source)
        {
            return Natives._GetLocalizedHotkey(source);
        }
        
        //native SetMapName takes string name returns nothing
        public delegate void SetMapNamePrototype(JassStringArg name);
        private static SetMapNamePrototype _SetMapName;
        public static void SetMapName(String name)
        {
            Natives._SetMapName(name);
        }
        
        //native SetMapDescription takes string description returns nothing
        public delegate void SetMapDescriptionPrototype(JassStringArg description);
        private static SetMapDescriptionPrototype _SetMapDescription;
        public static void SetMapDescription(String description)
        {
            Natives._SetMapDescription(description);
        }
        
        //native SetTeams takes integer teamcount returns nothing
        public delegate void SetTeamsPrototype(JassInteger teamcount);
        private static SetTeamsPrototype _SetTeams;
        public static void SetTeams(JassInteger teamcount)
        {
            Natives._SetTeams(teamcount);
        }
        
        //native SetPlayers takes integer playercount returns nothing
        public delegate void SetPlayersPrototype(JassInteger playercount);
        private static SetPlayersPrototype _SetPlayers;
        public static void SetPlayers(JassInteger playercount)
        {
            Natives._SetPlayers(playercount);
        }
        
        //native DefineStartLocation takes integer whichStartLoc, real x, real y returns nothing
        public delegate void DefineStartLocationPrototype(JassInteger whichStartLoc, JassRealArg x, JassRealArg y);
        private static DefineStartLocationPrototype _DefineStartLocation;
        public static void DefineStartLocation(JassInteger whichStartLoc, Single x, Single y)
        {
            Natives._DefineStartLocation(whichStartLoc, x, y);
        }
        
        //native DefineStartLocationLoc takes integer whichStartLoc, location whichLocation returns nothing
        public delegate void DefineStartLocationLocPrototype(JassInteger whichStartLoc, JassLocation whichLocation);
        private static DefineStartLocationLocPrototype _DefineStartLocationLoc;
        public static void DefineStartLocationLoc(JassInteger whichStartLoc, JassLocation whichLocation)
        {
            Natives._DefineStartLocationLoc(whichStartLoc, whichLocation);
        }
        
        //native SetStartLocPrioCount takes integer whichStartLoc, integer prioSlotCount returns nothing
        public delegate void SetStartLocPrioCountPrototype(JassInteger whichStartLoc, JassInteger prioSlotCount);
        private static SetStartLocPrioCountPrototype _SetStartLocPrioCount;
        public static void SetStartLocPrioCount(JassInteger whichStartLoc, JassInteger prioSlotCount)
        {
            Natives._SetStartLocPrioCount(whichStartLoc, prioSlotCount);
        }
        
        //native SetStartLocPrio takes integer whichStartLoc, integer prioSlotIndex, integer otherStartLocIndex, startlocprio priority returns nothing
        public delegate void SetStartLocPrioPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority);
        private static SetStartLocPrioPrototype _SetStartLocPrio;
        public static void SetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority)
        {
            Natives._SetStartLocPrio(whichStartLoc, prioSlotIndex, otherStartLocIndex, priority);
        }
        
        //native GetStartLocPrioSlot takes integer whichStartLoc, integer prioSlotIndex returns integer
        public delegate JassInteger GetStartLocPrioSlotPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex);
        private static GetStartLocPrioSlotPrototype _GetStartLocPrioSlot;
        public static JassInteger GetStartLocPrioSlot(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return Natives._GetStartLocPrioSlot(whichStartLoc, prioSlotIndex);
        }
        
        //native GetStartLocPrio takes integer whichStartLoc, integer prioSlotIndex returns startlocprio
        public delegate JassStartLocationPriority GetStartLocPrioPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex);
        private static GetStartLocPrioPrototype _GetStartLocPrio;
        public static JassStartLocationPriority GetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return Natives._GetStartLocPrio(whichStartLoc, prioSlotIndex);
        }
        
        //native SetGameTypeSupported takes gametype whichGameType, boolean value returns nothing
        public delegate void SetGameTypeSupportedPrototype(JassGameType whichGameType, JassBoolean value);
        private static SetGameTypeSupportedPrototype _SetGameTypeSupported;
        public static void SetGameTypeSupported(JassGameType whichGameType, Boolean value)
        {
            Natives._SetGameTypeSupported(whichGameType, value);
        }
        
        //native SetMapFlag takes mapflag whichMapFlag, boolean value returns nothing
        public delegate void SetMapFlagPrototype(JassMapFlag whichMapFlag, JassBoolean value);
        private static SetMapFlagPrototype _SetMapFlag;
        public static void SetMapFlag(JassMapFlag whichMapFlag, Boolean value)
        {
            Natives._SetMapFlag(whichMapFlag, value);
        }
        
        //native SetGamePlacement takes placement whichPlacementType returns nothing
        public delegate void SetGamePlacementPrototype(JassPlacement whichPlacementType);
        private static SetGamePlacementPrototype _SetGamePlacement;
        public static void SetGamePlacement(JassPlacement whichPlacementType)
        {
            Natives._SetGamePlacement(whichPlacementType);
        }
        
        //native SetGameSpeed takes gamespeed whichspeed returns nothing
        public delegate void SetGameSpeedPrototype(JassGameSpeed whichspeed);
        private static SetGameSpeedPrototype _SetGameSpeed;
        public static void SetGameSpeed(JassGameSpeed whichspeed)
        {
            Natives._SetGameSpeed(whichspeed);
        }
        
        //native SetGameDifficulty takes gamedifficulty whichdifficulty returns nothing
        public delegate void SetGameDifficultyPrototype(JassGameDifficulty whichdifficulty);
        private static SetGameDifficultyPrototype _SetGameDifficulty;
        public static void SetGameDifficulty(JassGameDifficulty whichdifficulty)
        {
            Natives._SetGameDifficulty(whichdifficulty);
        }
        
        //native SetResourceDensity takes mapdensity whichdensity returns nothing
        public delegate void SetResourceDensityPrototype(JassMapDensity whichdensity);
        private static SetResourceDensityPrototype _SetResourceDensity;
        public static void SetResourceDensity(JassMapDensity whichdensity)
        {
            Natives._SetResourceDensity(whichdensity);
        }
        
        //native SetCreatureDensity takes mapdensity whichdensity returns nothing
        public delegate void SetCreatureDensityPrototype(JassMapDensity whichdensity);
        private static SetCreatureDensityPrototype _SetCreatureDensity;
        public static void SetCreatureDensity(JassMapDensity whichdensity)
        {
            Natives._SetCreatureDensity(whichdensity);
        }
        
        //native GetTeams takes nothing returns integer
        public delegate JassInteger GetTeamsPrototype();
        private static GetTeamsPrototype _GetTeams;
        public static JassInteger GetTeams()
        {
            return Natives._GetTeams();
        }
        
        //native GetPlayers takes nothing returns integer
        public delegate JassInteger GetPlayersPrototype();
        private static GetPlayersPrototype _GetPlayers;
        public static JassInteger GetPlayers()
        {
            return Natives._GetPlayers();
        }
        
        //native IsGameTypeSupported takes gametype whichGameType returns boolean
        public delegate JassBoolean IsGameTypeSupportedPrototype(JassGameType whichGameType);
        private static IsGameTypeSupportedPrototype _IsGameTypeSupported;
        public static Boolean IsGameTypeSupported(JassGameType whichGameType)
        {
            return Natives._IsGameTypeSupported(whichGameType);
        }
        
        //native GetGameTypeSelected takes nothing returns gametype
        public delegate JassGameType GetGameTypeSelectedPrototype();
        private static GetGameTypeSelectedPrototype _GetGameTypeSelected;
        public static JassGameType GetGameTypeSelected()
        {
            return Natives._GetGameTypeSelected();
        }
        
        //native IsMapFlagSet takes mapflag whichMapFlag returns boolean
        public delegate JassBoolean IsMapFlagSetPrototype(JassMapFlag whichMapFlag);
        private static IsMapFlagSetPrototype _IsMapFlagSet;
        public static Boolean IsMapFlagSet(JassMapFlag whichMapFlag)
        {
            return Natives._IsMapFlagSet(whichMapFlag);
        }
        
        //native GetGamePlacement takes nothing returns placement
        public delegate JassPlacement GetGamePlacementPrototype();
        private static GetGamePlacementPrototype _GetGamePlacement;
        public static JassPlacement GetGamePlacement()
        {
            return Natives._GetGamePlacement();
        }
        
        //native GetGameSpeed takes nothing returns gamespeed
        public delegate JassGameSpeed GetGameSpeedPrototype();
        private static GetGameSpeedPrototype _GetGameSpeed;
        public static JassGameSpeed GetGameSpeed()
        {
            return Natives._GetGameSpeed();
        }
        
        //native GetGameDifficulty takes nothing returns gamedifficulty
        public delegate JassGameDifficulty GetGameDifficultyPrototype();
        private static GetGameDifficultyPrototype _GetGameDifficulty;
        public static JassGameDifficulty GetGameDifficulty()
        {
            return Natives._GetGameDifficulty();
        }
        
        //native GetResourceDensity takes nothing returns mapdensity
        public delegate JassMapDensity GetResourceDensityPrototype();
        private static GetResourceDensityPrototype _GetResourceDensity;
        public static JassMapDensity GetResourceDensity()
        {
            return Natives._GetResourceDensity();
        }
        
        //native GetCreatureDensity takes nothing returns mapdensity
        public delegate JassMapDensity GetCreatureDensityPrototype();
        private static GetCreatureDensityPrototype _GetCreatureDensity;
        public static JassMapDensity GetCreatureDensity()
        {
            return Natives._GetCreatureDensity();
        }
        
        //native GetStartLocationX takes integer whichStartLocation returns real
        public delegate JassRealRet GetStartLocationXPrototype(JassInteger whichStartLocation);
        private static GetStartLocationXPrototype _GetStartLocationX;
        public static Single GetStartLocationX(JassInteger whichStartLocation)
        {
            return Natives._GetStartLocationX(whichStartLocation);
        }
        
        //native GetStartLocationY takes integer whichStartLocation returns real
        public delegate JassRealRet GetStartLocationYPrototype(JassInteger whichStartLocation);
        private static GetStartLocationYPrototype _GetStartLocationY;
        public static Single GetStartLocationY(JassInteger whichStartLocation)
        {
            return Natives._GetStartLocationY(whichStartLocation);
        }
        
        //native GetStartLocationLoc takes integer whichStartLocation returns location
        public delegate JassLocation GetStartLocationLocPrototype(JassInteger whichStartLocation);
        private static GetStartLocationLocPrototype _GetStartLocationLoc;
        public static JassLocation GetStartLocationLoc(JassInteger whichStartLocation)
        {
            return Natives._GetStartLocationLoc(whichStartLocation);
        }
        
        //native SetPlayerTeam takes player whichPlayer, integer whichTeam returns nothing
        public delegate void SetPlayerTeamPrototype(JassPlayer whichPlayer, JassInteger whichTeam);
        private static SetPlayerTeamPrototype _SetPlayerTeam;
        public static void SetPlayerTeam(JassPlayer whichPlayer, JassInteger whichTeam)
        {
            Natives._SetPlayerTeam(whichPlayer, whichTeam);
        }
        
        //native SetPlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
        public delegate void SetPlayerStartLocationPrototype(JassPlayer whichPlayer, JassInteger startLocIndex);
        private static SetPlayerStartLocationPrototype _SetPlayerStartLocation;
        public static void SetPlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            Natives._SetPlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        //native ForcePlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
        public delegate void ForcePlayerStartLocationPrototype(JassPlayer whichPlayer, JassInteger startLocIndex);
        private static ForcePlayerStartLocationPrototype _ForcePlayerStartLocation;
        public static void ForcePlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            Natives._ForcePlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        //native SetPlayerColor takes player whichPlayer, playercolor color returns nothing
        public delegate void SetPlayerColorPrototype(JassPlayer whichPlayer, JassPlayerColor color);
        private static SetPlayerColorPrototype _SetPlayerColor;
        public static void SetPlayerColor(JassPlayer whichPlayer, JassPlayerColor color)
        {
            Natives._SetPlayerColor(whichPlayer, color);
        }
        
        //native SetPlayerAlliance takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, boolean value returns nothing
        public delegate void SetPlayerAlliancePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, JassBoolean value);
        private static SetPlayerAlliancePrototype _SetPlayerAlliance;
        public static void SetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, Boolean value)
        {
            Natives._SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);
        }
        
        //native SetPlayerTaxRate takes player sourcePlayer, player otherPlayer, playerstate whichResource, integer rate returns nothing
        public delegate void SetPlayerTaxRatePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate);
        private static SetPlayerTaxRatePrototype _SetPlayerTaxRate;
        public static void SetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate)
        {
            Natives._SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);
        }
        
        //native SetPlayerRacePreference takes player whichPlayer, racepreference whichRacePreference returns nothing
        public delegate void SetPlayerRacePreferencePrototype(JassPlayer whichPlayer, JassRacePreference whichRacePreference);
        private static SetPlayerRacePreferencePrototype _SetPlayerRacePreference;
        public static void SetPlayerRacePreference(JassPlayer whichPlayer, JassRacePreference whichRacePreference)
        {
            Natives._SetPlayerRacePreference(whichPlayer, whichRacePreference);
        }
        
        //native SetPlayerRaceSelectable takes player whichPlayer, boolean value returns nothing
        public delegate void SetPlayerRaceSelectablePrototype(JassPlayer whichPlayer, JassBoolean value);
        private static SetPlayerRaceSelectablePrototype _SetPlayerRaceSelectable;
        public static void SetPlayerRaceSelectable(JassPlayer whichPlayer, Boolean value)
        {
            Natives._SetPlayerRaceSelectable(whichPlayer, value);
        }
        
        //native SetPlayerController takes player whichPlayer, mapcontrol controlType returns nothing
        public delegate void SetPlayerControllerPrototype(JassPlayer whichPlayer, JassMapControl controlType);
        private static SetPlayerControllerPrototype _SetPlayerController;
        public static void SetPlayerController(JassPlayer whichPlayer, JassMapControl controlType)
        {
            Natives._SetPlayerController(whichPlayer, controlType);
        }
        
        //native SetPlayerName takes player whichPlayer, string name returns nothing
        public delegate void SetPlayerNamePrototype(JassPlayer whichPlayer, JassStringArg name);
        private static SetPlayerNamePrototype _SetPlayerName;
        public static void SetPlayerName(JassPlayer whichPlayer, String name)
        {
            Natives._SetPlayerName(whichPlayer, name);
        }
        
        //native SetPlayerOnScoreScreen takes player whichPlayer, boolean flag returns nothing
        public delegate void SetPlayerOnScoreScreenPrototype(JassPlayer whichPlayer, JassBoolean flag);
        private static SetPlayerOnScoreScreenPrototype _SetPlayerOnScoreScreen;
        public static void SetPlayerOnScoreScreen(JassPlayer whichPlayer, Boolean flag)
        {
            Natives._SetPlayerOnScoreScreen(whichPlayer, flag);
        }
        
        //native GetPlayerTeam takes player whichPlayer returns integer
        public delegate JassInteger GetPlayerTeamPrototype(JassPlayer whichPlayer);
        private static GetPlayerTeamPrototype _GetPlayerTeam;
        public static JassInteger GetPlayerTeam(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerTeam(whichPlayer);
        }
        
        //native GetPlayerStartLocation takes player whichPlayer returns integer
        public delegate JassInteger GetPlayerStartLocationPrototype(JassPlayer whichPlayer);
        private static GetPlayerStartLocationPrototype _GetPlayerStartLocation;
        public static JassInteger GetPlayerStartLocation(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerStartLocation(whichPlayer);
        }
        
        //native GetPlayerColor takes player whichPlayer returns playercolor
        public delegate JassPlayerColor GetPlayerColorPrototype(JassPlayer whichPlayer);
        private static GetPlayerColorPrototype _GetPlayerColor;
        public static JassPlayerColor GetPlayerColor(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerColor(whichPlayer);
        }
        
        //native GetPlayerSelectable takes player whichPlayer returns boolean
        public delegate JassBoolean GetPlayerSelectablePrototype(JassPlayer whichPlayer);
        private static GetPlayerSelectablePrototype _GetPlayerSelectable;
        public static Boolean GetPlayerSelectable(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerSelectable(whichPlayer);
        }
        
        //native GetPlayerController takes player whichPlayer returns mapcontrol
        public delegate JassMapControl GetPlayerControllerPrototype(JassPlayer whichPlayer);
        private static GetPlayerControllerPrototype _GetPlayerController;
        public static JassMapControl GetPlayerController(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerController(whichPlayer);
        }
        
        //native GetPlayerSlotState takes player whichPlayer returns playerslotstate
        public delegate JassPlayerSlotState GetPlayerSlotStatePrototype(JassPlayer whichPlayer);
        private static GetPlayerSlotStatePrototype _GetPlayerSlotState;
        public static JassPlayerSlotState GetPlayerSlotState(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerSlotState(whichPlayer);
        }
        
        //native GetPlayerTaxRate takes player sourcePlayer, player otherPlayer, playerstate whichResource returns integer
        public delegate JassInteger GetPlayerTaxRatePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource);
        private static GetPlayerTaxRatePrototype _GetPlayerTaxRate;
        public static JassInteger GetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource)
        {
            return Natives._GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);
        }
        
        //native IsPlayerRacePrefSet takes player whichPlayer, racepreference pref returns boolean
        public delegate JassBoolean IsPlayerRacePrefSetPrototype(JassPlayer whichPlayer, JassRacePreference pref);
        private static IsPlayerRacePrefSetPrototype _IsPlayerRacePrefSet;
        public static Boolean IsPlayerRacePrefSet(JassPlayer whichPlayer, JassRacePreference pref)
        {
            return Natives._IsPlayerRacePrefSet(whichPlayer, pref);
        }
        
        //native GetPlayerName takes player whichPlayer returns string
        public delegate JassStringRet GetPlayerNamePrototype(JassPlayer whichPlayer);
        private static GetPlayerNamePrototype _GetPlayerName;
        public static String GetPlayerName(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerName(whichPlayer);
        }
        
        //native CreateTimer takes nothing returns timer
        public delegate JassTimer CreateTimerPrototype();
        private static CreateTimerPrototype _CreateTimer;
        public static JassTimer CreateTimer()
        {
            return Natives._CreateTimer();
        }
        
        //native DestroyTimer takes timer whichTimer returns nothing
        public delegate void DestroyTimerPrototype(JassTimer whichTimer);
        private static DestroyTimerPrototype _DestroyTimer;
        public static void DestroyTimer(JassTimer whichTimer)
        {
            Natives._DestroyTimer(whichTimer);
        }
        
        //native TimerStart takes timer whichTimer, real timeout, boolean periodic, code handlerFunc returns nothing
        public delegate void TimerStartPrototype(JassTimer whichTimer, JassRealArg timeout, JassBoolean periodic, JassCode handlerFunc);
        private static TimerStartPrototype _TimerStart;
        public static void TimerStart(JassTimer whichTimer, Single timeout, Boolean periodic, JassCode handlerFunc)
        {
            Natives._TimerStart(whichTimer, timeout, periodic, handlerFunc);
        }
        
        //native TimerGetElapsed takes timer whichTimer returns real
        public delegate JassRealRet TimerGetElapsedPrototype(JassTimer whichTimer);
        private static TimerGetElapsedPrototype _TimerGetElapsed;
        public static Single TimerGetElapsed(JassTimer whichTimer)
        {
            return Natives._TimerGetElapsed(whichTimer);
        }
        
        //native TimerGetRemaining takes timer whichTimer returns real
        public delegate JassRealRet TimerGetRemainingPrototype(JassTimer whichTimer);
        private static TimerGetRemainingPrototype _TimerGetRemaining;
        public static Single TimerGetRemaining(JassTimer whichTimer)
        {
            return Natives._TimerGetRemaining(whichTimer);
        }
        
        //native TimerGetTimeout takes timer whichTimer returns real
        public delegate JassRealRet TimerGetTimeoutPrototype(JassTimer whichTimer);
        private static TimerGetTimeoutPrototype _TimerGetTimeout;
        public static Single TimerGetTimeout(JassTimer whichTimer)
        {
            return Natives._TimerGetTimeout(whichTimer);
        }
        
        //native PauseTimer takes timer whichTimer returns nothing
        public delegate void PauseTimerPrototype(JassTimer whichTimer);
        private static PauseTimerPrototype _PauseTimer;
        public static void PauseTimer(JassTimer whichTimer)
        {
            Natives._PauseTimer(whichTimer);
        }
        
        //native ResumeTimer takes timer whichTimer returns nothing
        public delegate void ResumeTimerPrototype(JassTimer whichTimer);
        private static ResumeTimerPrototype _ResumeTimer;
        public static void ResumeTimer(JassTimer whichTimer)
        {
            Natives._ResumeTimer(whichTimer);
        }
        
        //native GetExpiredTimer takes nothing returns timer
        public delegate JassTimer GetExpiredTimerPrototype();
        private static GetExpiredTimerPrototype _GetExpiredTimer;
        public static JassTimer GetExpiredTimer()
        {
            return Natives._GetExpiredTimer();
        }
        
        //native CreateGroup takes nothing returns group
        public delegate JassGroup CreateGroupPrototype();
        private static CreateGroupPrototype _CreateGroup;
        public static JassGroup CreateGroup()
        {
            return Natives._CreateGroup();
        }
        
        //native DestroyGroup takes group whichGroup returns nothing
        public delegate void DestroyGroupPrototype(JassGroup whichGroup);
        private static DestroyGroupPrototype _DestroyGroup;
        public static void DestroyGroup(JassGroup whichGroup)
        {
            Natives._DestroyGroup(whichGroup);
        }
        
        //native GroupAddUnit takes group whichGroup, unit whichUnit returns nothing
        public delegate void GroupAddUnitPrototype(JassGroup whichGroup, JassUnit whichUnit);
        private static GroupAddUnitPrototype _GroupAddUnit;
        public static void GroupAddUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            Natives._GroupAddUnit(whichGroup, whichUnit);
        }
        
        //native GroupRemoveUnit takes group whichGroup, unit whichUnit returns nothing
        public delegate void GroupRemoveUnitPrototype(JassGroup whichGroup, JassUnit whichUnit);
        private static GroupRemoveUnitPrototype _GroupRemoveUnit;
        public static void GroupRemoveUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            Natives._GroupRemoveUnit(whichGroup, whichUnit);
        }
        
        //native GroupClear takes group whichGroup returns nothing
        public delegate void GroupClearPrototype(JassGroup whichGroup);
        private static GroupClearPrototype _GroupClear;
        public static void GroupClear(JassGroup whichGroup)
        {
            Natives._GroupClear(whichGroup);
        }
        
        //native GroupEnumUnitsOfType takes group whichGroup, string unitname, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsOfTypePrototype(JassGroup whichGroup, JassStringArg unitname, JassBooleanExpression filter);
        private static GroupEnumUnitsOfTypePrototype _GroupEnumUnitsOfType;
        public static void GroupEnumUnitsOfType(JassGroup whichGroup, String unitname, JassBooleanExpression filter)
        {
            Natives._GroupEnumUnitsOfType(whichGroup, unitname, filter);
        }
        
        //native GroupEnumUnitsOfPlayer takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsOfPlayerPrototype(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter);
        private static GroupEnumUnitsOfPlayerPrototype _GroupEnumUnitsOfPlayer;
        public static void GroupEnumUnitsOfPlayer(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives._GroupEnumUnitsOfPlayer(whichGroup, whichPlayer, filter);
        }
        
        //native GroupEnumUnitsOfTypeCounted takes group whichGroup, string unitname, boolexpr filter, integer countLimit returns nothing
        public delegate void GroupEnumUnitsOfTypeCountedPrototype(JassGroup whichGroup, JassStringArg unitname, JassBooleanExpression filter, JassInteger countLimit);
        private static GroupEnumUnitsOfTypeCountedPrototype _GroupEnumUnitsOfTypeCounted;
        public static void GroupEnumUnitsOfTypeCounted(JassGroup whichGroup, String unitname, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives._GroupEnumUnitsOfTypeCounted(whichGroup, unitname, filter, countLimit);
        }
        
        //native GroupEnumUnitsInRect takes group whichGroup, rect r, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsInRectPrototype(JassGroup whichGroup, JassRect r, JassBooleanExpression filter);
        private static GroupEnumUnitsInRectPrototype _GroupEnumUnitsInRect;
        public static void GroupEnumUnitsInRect(JassGroup whichGroup, JassRect r, JassBooleanExpression filter)
        {
            Natives._GroupEnumUnitsInRect(whichGroup, r, filter);
        }
        
        //native GroupEnumUnitsInRectCounted takes group whichGroup, rect r, boolexpr filter, integer countLimit returns nothing
        public delegate void GroupEnumUnitsInRectCountedPrototype(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit);
        private static GroupEnumUnitsInRectCountedPrototype _GroupEnumUnitsInRectCounted;
        public static void GroupEnumUnitsInRectCounted(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives._GroupEnumUnitsInRectCounted(whichGroup, r, filter, countLimit);
        }
        
        //native GroupEnumUnitsInRange takes group whichGroup, real x, real y, real radius, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsInRangePrototype(JassGroup whichGroup, JassRealArg x, JassRealArg y, JassRealArg radius, JassBooleanExpression filter);
        private static GroupEnumUnitsInRangePrototype _GroupEnumUnitsInRange;
        public static void GroupEnumUnitsInRange(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter)
        {
            Natives._GroupEnumUnitsInRange(whichGroup, x, y, radius, filter);
        }
        
        //native GroupEnumUnitsInRangeOfLoc takes group whichGroup, location whichLocation, real radius, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsInRangeOfLocPrototype(JassGroup whichGroup, JassLocation whichLocation, JassRealArg radius, JassBooleanExpression filter);
        private static GroupEnumUnitsInRangeOfLocPrototype _GroupEnumUnitsInRangeOfLoc;
        public static void GroupEnumUnitsInRangeOfLoc(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter)
        {
            Natives._GroupEnumUnitsInRangeOfLoc(whichGroup, whichLocation, radius, filter);
        }
        
        //native GroupEnumUnitsInRangeCounted takes group whichGroup, real x, real y, real radius, boolexpr filter, integer countLimit returns nothing
        public delegate void GroupEnumUnitsInRangeCountedPrototype(JassGroup whichGroup, JassRealArg x, JassRealArg y, JassRealArg radius, JassBooleanExpression filter, JassInteger countLimit);
        private static GroupEnumUnitsInRangeCountedPrototype _GroupEnumUnitsInRangeCounted;
        public static void GroupEnumUnitsInRangeCounted(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives._GroupEnumUnitsInRangeCounted(whichGroup, x, y, radius, filter, countLimit);
        }
        
        //native GroupEnumUnitsInRangeOfLocCounted takes group whichGroup, location whichLocation, real radius, boolexpr filter, integer countLimit returns nothing
        public delegate void GroupEnumUnitsInRangeOfLocCountedPrototype(JassGroup whichGroup, JassLocation whichLocation, JassRealArg radius, JassBooleanExpression filter, JassInteger countLimit);
        private static GroupEnumUnitsInRangeOfLocCountedPrototype _GroupEnumUnitsInRangeOfLocCounted;
        public static void GroupEnumUnitsInRangeOfLocCounted(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives._GroupEnumUnitsInRangeOfLocCounted(whichGroup, whichLocation, radius, filter, countLimit);
        }
        
        //native GroupEnumUnitsSelected takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
        public delegate void GroupEnumUnitsSelectedPrototype(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter);
        private static GroupEnumUnitsSelectedPrototype _GroupEnumUnitsSelected;
        public static void GroupEnumUnitsSelected(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives._GroupEnumUnitsSelected(whichGroup, whichPlayer, filter);
        }
        
        //native GroupImmediateOrder takes group whichGroup, string order returns boolean
        public delegate JassBoolean GroupImmediateOrderPrototype(JassGroup whichGroup, JassStringArg order);
        private static GroupImmediateOrderPrototype _GroupImmediateOrder;
        public static Boolean GroupImmediateOrder(JassGroup whichGroup, String order)
        {
            return Natives._GroupImmediateOrder(whichGroup, order);
        }
        
        //native GroupImmediateOrderById takes group whichGroup, integer order returns boolean
        public delegate JassBoolean GroupImmediateOrderByIdPrototype(JassGroup whichGroup, JassOrder order);
        private static GroupImmediateOrderByIdPrototype _GroupImmediateOrderById;
        public static Boolean GroupImmediateOrderById(JassGroup whichGroup, JassOrder order)
        {
            return Natives._GroupImmediateOrderById(whichGroup, order);
        }
        
        //native GroupPointOrder takes group whichGroup, string order, real x, real y returns boolean
        public delegate JassBoolean GroupPointOrderPrototype(JassGroup whichGroup, JassStringArg order, JassRealArg x, JassRealArg y);
        private static GroupPointOrderPrototype _GroupPointOrder;
        public static Boolean GroupPointOrder(JassGroup whichGroup, String order, Single x, Single y)
        {
            return Natives._GroupPointOrder(whichGroup, order, x, y);
        }
        
        //native GroupPointOrderLoc takes group whichGroup, string order, location whichLocation returns boolean
        public delegate JassBoolean GroupPointOrderLocPrototype(JassGroup whichGroup, JassStringArg order, JassLocation whichLocation);
        private static GroupPointOrderLocPrototype _GroupPointOrderLoc;
        public static Boolean GroupPointOrderLoc(JassGroup whichGroup, String order, JassLocation whichLocation)
        {
            return Natives._GroupPointOrderLoc(whichGroup, order, whichLocation);
        }
        
        //native GroupPointOrderById takes group whichGroup, integer order, real x, real y returns boolean
        public delegate JassBoolean GroupPointOrderByIdPrototype(JassGroup whichGroup, JassOrder order, JassRealArg x, JassRealArg y);
        private static GroupPointOrderByIdPrototype _GroupPointOrderById;
        public static Boolean GroupPointOrderById(JassGroup whichGroup, JassOrder order, Single x, Single y)
        {
            return Natives._GroupPointOrderById(whichGroup, order, x, y);
        }
        
        //native GroupPointOrderByIdLoc takes group whichGroup, integer order, location whichLocation returns boolean
        public delegate JassBoolean GroupPointOrderByIdLocPrototype(JassGroup whichGroup, JassOrder order, JassLocation whichLocation);
        private static GroupPointOrderByIdLocPrototype _GroupPointOrderByIdLoc;
        public static Boolean GroupPointOrderByIdLoc(JassGroup whichGroup, JassOrder order, JassLocation whichLocation)
        {
            return Natives._GroupPointOrderByIdLoc(whichGroup, order, whichLocation);
        }
        
        //native GroupTargetOrder takes group whichGroup, string order, widget targetWidget returns boolean
        public delegate JassBoolean GroupTargetOrderPrototype(JassGroup whichGroup, JassStringArg order, JassWidget targetWidget);
        private static GroupTargetOrderPrototype _GroupTargetOrder;
        public static Boolean GroupTargetOrder(JassGroup whichGroup, String order, JassWidget targetWidget)
        {
            return Natives._GroupTargetOrder(whichGroup, order, targetWidget);
        }
        
        //native GroupTargetOrderById takes group whichGroup, integer order, widget targetWidget returns boolean
        public delegate JassBoolean GroupTargetOrderByIdPrototype(JassGroup whichGroup, JassOrder order, JassWidget targetWidget);
        private static GroupTargetOrderByIdPrototype _GroupTargetOrderById;
        public static Boolean GroupTargetOrderById(JassGroup whichGroup, JassOrder order, JassWidget targetWidget)
        {
            return Natives._GroupTargetOrderById(whichGroup, order, targetWidget);
        }
        
        //native ForGroup takes group whichGroup, code callback returns nothing
        public delegate void ForGroupPrototype(JassGroup whichGroup, JassCode callback);
        private static ForGroupPrototype _ForGroup;
        public static void ForGroup(JassGroup whichGroup, JassCode callback)
        {
            Natives._ForGroup(whichGroup, callback);
        }
        
        //native FirstOfGroup takes group whichGroup returns unit
        public delegate JassUnit FirstOfGroupPrototype(JassGroup whichGroup);
        private static FirstOfGroupPrototype _FirstOfGroup;
        public static JassUnit FirstOfGroup(JassGroup whichGroup)
        {
            return Natives._FirstOfGroup(whichGroup);
        }
        
        //native CreateForce takes nothing returns force
        public delegate JassForce CreateForcePrototype();
        private static CreateForcePrototype _CreateForce;
        public static JassForce CreateForce()
        {
            return Natives._CreateForce();
        }
        
        //native DestroyForce takes force whichForce returns nothing
        public delegate void DestroyForcePrototype(JassForce whichForce);
        private static DestroyForcePrototype _DestroyForce;
        public static void DestroyForce(JassForce whichForce)
        {
            Natives._DestroyForce(whichForce);
        }
        
        //native ForceAddPlayer takes force whichForce, player whichPlayer returns nothing
        public delegate void ForceAddPlayerPrototype(JassForce whichForce, JassPlayer whichPlayer);
        private static ForceAddPlayerPrototype _ForceAddPlayer;
        public static void ForceAddPlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            Natives._ForceAddPlayer(whichForce, whichPlayer);
        }
        
        //native ForceRemovePlayer takes force whichForce, player whichPlayer returns nothing
        public delegate void ForceRemovePlayerPrototype(JassForce whichForce, JassPlayer whichPlayer);
        private static ForceRemovePlayerPrototype _ForceRemovePlayer;
        public static void ForceRemovePlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            Natives._ForceRemovePlayer(whichForce, whichPlayer);
        }
        
        //native ForceClear takes force whichForce returns nothing
        public delegate void ForceClearPrototype(JassForce whichForce);
        private static ForceClearPrototype _ForceClear;
        public static void ForceClear(JassForce whichForce)
        {
            Natives._ForceClear(whichForce);
        }
        
        //native ForceEnumPlayers takes force whichForce, boolexpr filter returns nothing
        public delegate void ForceEnumPlayersPrototype(JassForce whichForce, JassBooleanExpression filter);
        private static ForceEnumPlayersPrototype _ForceEnumPlayers;
        public static void ForceEnumPlayers(JassForce whichForce, JassBooleanExpression filter)
        {
            Natives._ForceEnumPlayers(whichForce, filter);
        }
        
        //native ForceEnumPlayersCounted takes force whichForce, boolexpr filter, integer countLimit returns nothing
        public delegate void ForceEnumPlayersCountedPrototype(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit);
        private static ForceEnumPlayersCountedPrototype _ForceEnumPlayersCounted;
        public static void ForceEnumPlayersCounted(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives._ForceEnumPlayersCounted(whichForce, filter, countLimit);
        }
        
        //native ForceEnumAllies takes force whichForce, player whichPlayer, boolexpr filter returns nothing
        public delegate void ForceEnumAlliesPrototype(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter);
        private static ForceEnumAlliesPrototype _ForceEnumAllies;
        public static void ForceEnumAllies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives._ForceEnumAllies(whichForce, whichPlayer, filter);
        }
        
        //native ForceEnumEnemies takes force whichForce, player whichPlayer, boolexpr filter returns nothing
        public delegate void ForceEnumEnemiesPrototype(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter);
        private static ForceEnumEnemiesPrototype _ForceEnumEnemies;
        public static void ForceEnumEnemies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives._ForceEnumEnemies(whichForce, whichPlayer, filter);
        }
        
        //native ForForce takes force whichForce, code callback returns nothing
        public delegate void ForForcePrototype(JassForce whichForce, JassCode callback);
        private static ForForcePrototype _ForForce;
        public static void ForForce(JassForce whichForce, JassCode callback)
        {
            Natives._ForForce(whichForce, callback);
        }
        
        //native Rect takes real minx, real miny, real maxx, real maxy returns rect
        public delegate JassRect RectPrototype(JassRealArg minx, JassRealArg miny, JassRealArg maxx, JassRealArg maxy);
        private static RectPrototype _Rect;
        public static JassRect Rect(Single minx, Single miny, Single maxx, Single maxy)
        {
            return Natives._Rect(minx, miny, maxx, maxy);
        }
        
        //native RectFromLoc takes location min, location max returns rect
        public delegate JassRect RectFromLocPrototype(JassLocation min, JassLocation max);
        private static RectFromLocPrototype _RectFromLoc;
        public static JassRect RectFromLoc(JassLocation min, JassLocation max)
        {
            return Natives._RectFromLoc(min, max);
        }
        
        //native RemoveRect takes rect whichRect returns nothing
        public delegate void RemoveRectPrototype(JassRect whichRect);
        private static RemoveRectPrototype _RemoveRect;
        public static void RemoveRect(JassRect whichRect)
        {
            Natives._RemoveRect(whichRect);
        }
        
        //native SetRect takes rect whichRect, real minx, real miny, real maxx, real maxy returns nothing
        public delegate void SetRectPrototype(JassRect whichRect, JassRealArg minx, JassRealArg miny, JassRealArg maxx, JassRealArg maxy);
        private static SetRectPrototype _SetRect;
        public static void SetRect(JassRect whichRect, Single minx, Single miny, Single maxx, Single maxy)
        {
            Natives._SetRect(whichRect, minx, miny, maxx, maxy);
        }
        
        //native SetRectFromLoc takes rect whichRect, location min, location max returns nothing
        public delegate void SetRectFromLocPrototype(JassRect whichRect, JassLocation min, JassLocation max);
        private static SetRectFromLocPrototype _SetRectFromLoc;
        public static void SetRectFromLoc(JassRect whichRect, JassLocation min, JassLocation max)
        {
            Natives._SetRectFromLoc(whichRect, min, max);
        }
        
        //native MoveRectTo takes rect whichRect, real newCenterX, real newCenterY returns nothing
        public delegate void MoveRectToPrototype(JassRect whichRect, JassRealArg newCenterX, JassRealArg newCenterY);
        private static MoveRectToPrototype _MoveRectTo;
        public static void MoveRectTo(JassRect whichRect, Single newCenterX, Single newCenterY)
        {
            Natives._MoveRectTo(whichRect, newCenterX, newCenterY);
        }
        
        //native MoveRectToLoc takes rect whichRect, location newCenterLoc returns nothing
        public delegate void MoveRectToLocPrototype(JassRect whichRect, JassLocation newCenterLoc);
        private static MoveRectToLocPrototype _MoveRectToLoc;
        public static void MoveRectToLoc(JassRect whichRect, JassLocation newCenterLoc)
        {
            Natives._MoveRectToLoc(whichRect, newCenterLoc);
        }
        
        //native GetRectCenterX takes rect whichRect returns real
        public delegate JassRealRet GetRectCenterXPrototype(JassRect whichRect);
        private static GetRectCenterXPrototype _GetRectCenterX;
        public static Single GetRectCenterX(JassRect whichRect)
        {
            return Natives._GetRectCenterX(whichRect);
        }
        
        //native GetRectCenterY takes rect whichRect returns real
        public delegate JassRealRet GetRectCenterYPrototype(JassRect whichRect);
        private static GetRectCenterYPrototype _GetRectCenterY;
        public static Single GetRectCenterY(JassRect whichRect)
        {
            return Natives._GetRectCenterY(whichRect);
        }
        
        //native GetRectMinX takes rect whichRect returns real
        public delegate JassRealRet GetRectMinXPrototype(JassRect whichRect);
        private static GetRectMinXPrototype _GetRectMinX;
        public static Single GetRectMinX(JassRect whichRect)
        {
            return Natives._GetRectMinX(whichRect);
        }
        
        //native GetRectMinY takes rect whichRect returns real
        public delegate JassRealRet GetRectMinYPrototype(JassRect whichRect);
        private static GetRectMinYPrototype _GetRectMinY;
        public static Single GetRectMinY(JassRect whichRect)
        {
            return Natives._GetRectMinY(whichRect);
        }
        
        //native GetRectMaxX takes rect whichRect returns real
        public delegate JassRealRet GetRectMaxXPrototype(JassRect whichRect);
        private static GetRectMaxXPrototype _GetRectMaxX;
        public static Single GetRectMaxX(JassRect whichRect)
        {
            return Natives._GetRectMaxX(whichRect);
        }
        
        //native GetRectMaxY takes rect whichRect returns real
        public delegate JassRealRet GetRectMaxYPrototype(JassRect whichRect);
        private static GetRectMaxYPrototype _GetRectMaxY;
        public static Single GetRectMaxY(JassRect whichRect)
        {
            return Natives._GetRectMaxY(whichRect);
        }
        
        //native CreateRegion takes nothing returns region
        public delegate JassRegion CreateRegionPrototype();
        private static CreateRegionPrototype _CreateRegion;
        public static JassRegion CreateRegion()
        {
            return Natives._CreateRegion();
        }
        
        //native RemoveRegion takes region whichRegion returns nothing
        public delegate void RemoveRegionPrototype(JassRegion whichRegion);
        private static RemoveRegionPrototype _RemoveRegion;
        public static void RemoveRegion(JassRegion whichRegion)
        {
            Natives._RemoveRegion(whichRegion);
        }
        
        //native RegionAddRect takes region whichRegion, rect r returns nothing
        public delegate void RegionAddRectPrototype(JassRegion whichRegion, JassRect r);
        private static RegionAddRectPrototype _RegionAddRect;
        public static void RegionAddRect(JassRegion whichRegion, JassRect r)
        {
            Natives._RegionAddRect(whichRegion, r);
        }
        
        //native RegionClearRect takes region whichRegion, rect r returns nothing
        public delegate void RegionClearRectPrototype(JassRegion whichRegion, JassRect r);
        private static RegionClearRectPrototype _RegionClearRect;
        public static void RegionClearRect(JassRegion whichRegion, JassRect r)
        {
            Natives._RegionClearRect(whichRegion, r);
        }
        
        //native RegionAddCell takes region whichRegion, real x, real y returns nothing
        public delegate void RegionAddCellPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private static RegionAddCellPrototype _RegionAddCell;
        public static void RegionAddCell(JassRegion whichRegion, Single x, Single y)
        {
            Natives._RegionAddCell(whichRegion, x, y);
        }
        
        //native RegionAddCellAtLoc takes region whichRegion, location whichLocation returns nothing
        public delegate void RegionAddCellAtLocPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private static RegionAddCellAtLocPrototype _RegionAddCellAtLoc;
        public static void RegionAddCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            Natives._RegionAddCellAtLoc(whichRegion, whichLocation);
        }
        
        //native RegionClearCell takes region whichRegion, real x, real y returns nothing
        public delegate void RegionClearCellPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private static RegionClearCellPrototype _RegionClearCell;
        public static void RegionClearCell(JassRegion whichRegion, Single x, Single y)
        {
            Natives._RegionClearCell(whichRegion, x, y);
        }
        
        //native RegionClearCellAtLoc takes region whichRegion, location whichLocation returns nothing
        public delegate void RegionClearCellAtLocPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private static RegionClearCellAtLocPrototype _RegionClearCellAtLoc;
        public static void RegionClearCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            Natives._RegionClearCellAtLoc(whichRegion, whichLocation);
        }
        
        //native Location takes real x, real y returns location
        public delegate JassLocation LocationPrototype(JassRealArg x, JassRealArg y);
        private static LocationPrototype _Location;
        public static JassLocation Location(Single x, Single y)
        {
            return Natives._Location(x, y);
        }
        
        //native RemoveLocation takes location whichLocation returns nothing
        public delegate void RemoveLocationPrototype(JassLocation whichLocation);
        private static RemoveLocationPrototype _RemoveLocation;
        public static void RemoveLocation(JassLocation whichLocation)
        {
            Natives._RemoveLocation(whichLocation);
        }
        
        //native MoveLocation takes location whichLocation, real newX, real newY returns nothing
        public delegate void MoveLocationPrototype(JassLocation whichLocation, JassRealArg newX, JassRealArg newY);
        private static MoveLocationPrototype _MoveLocation;
        public static void MoveLocation(JassLocation whichLocation, Single newX, Single newY)
        {
            Natives._MoveLocation(whichLocation, newX, newY);
        }
        
        //native GetLocationX takes location whichLocation returns real
        public delegate JassRealRet GetLocationXPrototype(JassLocation whichLocation);
        private static GetLocationXPrototype _GetLocationX;
        public static Single GetLocationX(JassLocation whichLocation)
        {
            return Natives._GetLocationX(whichLocation);
        }
        
        //native GetLocationY takes location whichLocation returns real
        public delegate JassRealRet GetLocationYPrototype(JassLocation whichLocation);
        private static GetLocationYPrototype _GetLocationY;
        public static Single GetLocationY(JassLocation whichLocation)
        {
            return Natives._GetLocationY(whichLocation);
        }
        
        //native GetLocationZ takes location whichLocation returns real
        public delegate JassRealRet GetLocationZPrototype(JassLocation whichLocation);
        private static GetLocationZPrototype _GetLocationZ;
        public static Single GetLocationZ(JassLocation whichLocation)
        {
            return Natives._GetLocationZ(whichLocation);
        }
        
        //native IsUnitInRegion takes region whichRegion, unit whichUnit returns boolean
        public delegate JassBoolean IsUnitInRegionPrototype(JassRegion whichRegion, JassUnit whichUnit);
        private static IsUnitInRegionPrototype _IsUnitInRegion;
        public static Boolean IsUnitInRegion(JassRegion whichRegion, JassUnit whichUnit)
        {
            return Natives._IsUnitInRegion(whichRegion, whichUnit);
        }
        
        //native IsPointInRegion takes region whichRegion, real x, real y returns boolean
        public delegate JassBoolean IsPointInRegionPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private static IsPointInRegionPrototype _IsPointInRegion;
        public static Boolean IsPointInRegion(JassRegion whichRegion, Single x, Single y)
        {
            return Natives._IsPointInRegion(whichRegion, x, y);
        }
        
        //native IsLocationInRegion takes region whichRegion, location whichLocation returns boolean
        public delegate JassBoolean IsLocationInRegionPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private static IsLocationInRegionPrototype _IsLocationInRegion;
        public static Boolean IsLocationInRegion(JassRegion whichRegion, JassLocation whichLocation)
        {
            return Natives._IsLocationInRegion(whichRegion, whichLocation);
        }
        
        //native GetWorldBounds takes nothing returns rect
        public delegate JassRect GetWorldBoundsPrototype();
        private static GetWorldBoundsPrototype _GetWorldBounds;
        public static JassRect GetWorldBounds()
        {
            return Natives._GetWorldBounds();
        }
        
        //native CreateTrigger takes nothing returns trigger
        public delegate JassTrigger CreateTriggerPrototype();
        private static CreateTriggerPrototype _CreateTrigger;
        public static JassTrigger CreateTrigger()
        {
            return Natives._CreateTrigger();
        }
        
        //native DestroyTrigger takes trigger whichTrigger returns nothing
        public delegate void DestroyTriggerPrototype(JassTrigger whichTrigger);
        private static DestroyTriggerPrototype _DestroyTrigger;
        public static void DestroyTrigger(JassTrigger whichTrigger)
        {
            Natives._DestroyTrigger(whichTrigger);
        }
        
        //native ResetTrigger takes trigger whichTrigger returns nothing
        public delegate void ResetTriggerPrototype(JassTrigger whichTrigger);
        private static ResetTriggerPrototype _ResetTrigger;
        public static void ResetTrigger(JassTrigger whichTrigger)
        {
            Natives._ResetTrigger(whichTrigger);
        }
        
        //native EnableTrigger takes trigger whichTrigger returns nothing
        public delegate void EnableTriggerPrototype(JassTrigger whichTrigger);
        private static EnableTriggerPrototype _EnableTrigger;
        public static void EnableTrigger(JassTrigger whichTrigger)
        {
            Natives._EnableTrigger(whichTrigger);
        }
        
        //native DisableTrigger takes trigger whichTrigger returns nothing
        public delegate void DisableTriggerPrototype(JassTrigger whichTrigger);
        private static DisableTriggerPrototype _DisableTrigger;
        public static void DisableTrigger(JassTrigger whichTrigger)
        {
            Natives._DisableTrigger(whichTrigger);
        }
        
        //native IsTriggerEnabled takes trigger whichTrigger returns boolean
        public delegate JassBoolean IsTriggerEnabledPrototype(JassTrigger whichTrigger);
        private static IsTriggerEnabledPrototype _IsTriggerEnabled;
        public static Boolean IsTriggerEnabled(JassTrigger whichTrigger)
        {
            return Natives._IsTriggerEnabled(whichTrigger);
        }
        
        //native TriggerWaitOnSleeps takes trigger whichTrigger, boolean flag returns nothing
        public delegate void TriggerWaitOnSleepsPrototype(JassTrigger whichTrigger, JassBoolean flag);
        private static TriggerWaitOnSleepsPrototype _TriggerWaitOnSleeps;
        public static void TriggerWaitOnSleeps(JassTrigger whichTrigger, Boolean flag)
        {
            Natives._TriggerWaitOnSleeps(whichTrigger, flag);
        }
        
        //native IsTriggerWaitOnSleeps takes trigger whichTrigger returns boolean
        public delegate JassBoolean IsTriggerWaitOnSleepsPrototype(JassTrigger whichTrigger);
        private static IsTriggerWaitOnSleepsPrototype _IsTriggerWaitOnSleeps;
        public static Boolean IsTriggerWaitOnSleeps(JassTrigger whichTrigger)
        {
            return Natives._IsTriggerWaitOnSleeps(whichTrigger);
        }
        
        //native GetFilterUnit takes nothing returns unit
        public delegate JassUnit GetFilterUnitPrototype();
        private static GetFilterUnitPrototype _GetFilterUnit;
        public static JassUnit GetFilterUnit()
        {
            return Natives._GetFilterUnit();
        }
        
        //native GetEnumUnit takes nothing returns unit
        public delegate JassUnit GetEnumUnitPrototype();
        private static GetEnumUnitPrototype _GetEnumUnit;
        public static JassUnit GetEnumUnit()
        {
            return Natives._GetEnumUnit();
        }
        
        //native GetFilterDestructable takes nothing returns destructable
        public delegate JassDestructable GetFilterDestructablePrototype();
        private static GetFilterDestructablePrototype _GetFilterDestructable;
        public static JassDestructable GetFilterDestructable()
        {
            return Natives._GetFilterDestructable();
        }
        
        //native GetEnumDestructable takes nothing returns destructable
        public delegate JassDestructable GetEnumDestructablePrototype();
        private static GetEnumDestructablePrototype _GetEnumDestructable;
        public static JassDestructable GetEnumDestructable()
        {
            return Natives._GetEnumDestructable();
        }
        
        //native GetFilterItem takes nothing returns item
        public delegate JassItem GetFilterItemPrototype();
        private static GetFilterItemPrototype _GetFilterItem;
        public static JassItem GetFilterItem()
        {
            return Natives._GetFilterItem();
        }
        
        //native GetEnumItem takes nothing returns item
        public delegate JassItem GetEnumItemPrototype();
        private static GetEnumItemPrototype _GetEnumItem;
        public static JassItem GetEnumItem()
        {
            return Natives._GetEnumItem();
        }
        
        //native GetFilterPlayer takes nothing returns player
        public delegate JassPlayer GetFilterPlayerPrototype();
        private static GetFilterPlayerPrototype _GetFilterPlayer;
        public static JassPlayer GetFilterPlayer()
        {
            return Natives._GetFilterPlayer();
        }
        
        //native GetEnumPlayer takes nothing returns player
        public delegate JassPlayer GetEnumPlayerPrototype();
        private static GetEnumPlayerPrototype _GetEnumPlayer;
        public static JassPlayer GetEnumPlayer()
        {
            return Natives._GetEnumPlayer();
        }
        
        //native GetTriggeringTrigger takes nothing returns trigger
        public delegate JassTrigger GetTriggeringTriggerPrototype();
        private static GetTriggeringTriggerPrototype _GetTriggeringTrigger;
        public static JassTrigger GetTriggeringTrigger()
        {
            return Natives._GetTriggeringTrigger();
        }
        
        //native GetTriggerEventId takes nothing returns eventid
        public delegate JassEventIndex GetTriggerEventIdPrototype();
        private static GetTriggerEventIdPrototype _GetTriggerEventId;
        public static JassEventIndex GetTriggerEventId()
        {
            return Natives._GetTriggerEventId();
        }
        
        //native GetTriggerEvalCount takes trigger whichTrigger returns integer
        public delegate JassInteger GetTriggerEvalCountPrototype(JassTrigger whichTrigger);
        private static GetTriggerEvalCountPrototype _GetTriggerEvalCount;
        public static JassInteger GetTriggerEvalCount(JassTrigger whichTrigger)
        {
            return Natives._GetTriggerEvalCount(whichTrigger);
        }
        
        //native GetTriggerExecCount takes trigger whichTrigger returns integer
        public delegate JassInteger GetTriggerExecCountPrototype(JassTrigger whichTrigger);
        private static GetTriggerExecCountPrototype _GetTriggerExecCount;
        public static JassInteger GetTriggerExecCount(JassTrigger whichTrigger)
        {
            return Natives._GetTriggerExecCount(whichTrigger);
        }
        
        //native ExecuteFunc takes string funcName returns nothing
        public delegate void ExecuteFuncPrototype(JassStringArg funcName);
        private static ExecuteFuncPrototype _ExecuteFunc;
        public static void ExecuteFunc(String funcName)
        {
            Natives._ExecuteFunc(funcName);
        }
        
        //native And takes boolexpr operandA, boolexpr operandB returns boolexpr
        public delegate JassBooleanExpression AndPrototype(JassBooleanExpression operandA, JassBooleanExpression operandB);
        private static AndPrototype _And;
        public static JassBooleanExpression And(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return Natives._And(operandA, operandB);
        }
        
        //native Or takes boolexpr operandA, boolexpr operandB returns boolexpr
        public delegate JassBooleanExpression OrPrototype(JassBooleanExpression operandA, JassBooleanExpression operandB);
        private static OrPrototype _Or;
        public static JassBooleanExpression Or(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return Natives._Or(operandA, operandB);
        }
        
        //native Not takes boolexpr operand returns boolexpr
        public delegate JassBooleanExpression NotPrototype(JassBooleanExpression operand);
        private static NotPrototype _Not;
        public static JassBooleanExpression Not(JassBooleanExpression operand)
        {
            return Natives._Not(operand);
        }
        
        //native Condition takes code func returns conditionfunc
        public delegate JassConditionFunction ConditionPrototype(JassCode func);
        private static ConditionPrototype _Condition;
        public static JassConditionFunction Condition(JassCode func)
        {
            return Natives._Condition(func);
        }
        
        //native DestroyCondition takes conditionfunc c returns nothing
        public delegate void DestroyConditionPrototype(JassConditionFunction c);
        private static DestroyConditionPrototype _DestroyCondition;
        public static void DestroyCondition(JassConditionFunction c)
        {
            Natives._DestroyCondition(c);
        }
        
        //native Filter takes code func returns filterfunc
        public delegate JassFilterFunction FilterPrototype(JassCode func);
        private static FilterPrototype _Filter;
        public static JassFilterFunction Filter(JassCode func)
        {
            return Natives._Filter(func);
        }
        
        //native DestroyFilter takes filterfunc f returns nothing
        public delegate void DestroyFilterPrototype(JassFilterFunction f);
        private static DestroyFilterPrototype _DestroyFilter;
        public static void DestroyFilter(JassFilterFunction f)
        {
            Natives._DestroyFilter(f);
        }
        
        //native DestroyBoolExpr takes boolexpr e returns nothing
        public delegate void DestroyBoolExprPrototype(JassBooleanExpression e);
        private static DestroyBoolExprPrototype _DestroyBoolExpr;
        public static void DestroyBoolExpr(JassBooleanExpression e)
        {
            Natives._DestroyBoolExpr(e);
        }
        
        //native TriggerRegisterVariableEvent takes trigger whichTrigger, string varName, limitop opcode, real limitval returns event
        public delegate JassEvent TriggerRegisterVariableEventPrototype(JassTrigger whichTrigger, JassStringArg varName, JassLimitOp opcode, JassRealArg limitval);
        private static TriggerRegisterVariableEventPrototype _TriggerRegisterVariableEvent;
        public static JassEvent TriggerRegisterVariableEvent(JassTrigger whichTrigger, String varName, JassLimitOp opcode, Single limitval)
        {
            return Natives._TriggerRegisterVariableEvent(whichTrigger, varName, opcode, limitval);
        }
        
        //native TriggerRegisterTimerEvent takes trigger whichTrigger, real timeout, boolean periodic returns event
        public delegate JassEvent TriggerRegisterTimerEventPrototype(JassTrigger whichTrigger, JassRealArg timeout, JassBoolean periodic);
        private static TriggerRegisterTimerEventPrototype _TriggerRegisterTimerEvent;
        public static JassEvent TriggerRegisterTimerEvent(JassTrigger whichTrigger, Single timeout, Boolean periodic)
        {
            return Natives._TriggerRegisterTimerEvent(whichTrigger, timeout, periodic);
        }
        
        //native TriggerRegisterTimerExpireEvent takes trigger whichTrigger, timer t returns event
        public delegate JassEvent TriggerRegisterTimerExpireEventPrototype(JassTrigger whichTrigger, JassTimer t);
        private static TriggerRegisterTimerExpireEventPrototype _TriggerRegisterTimerExpireEvent;
        public static JassEvent TriggerRegisterTimerExpireEvent(JassTrigger whichTrigger, JassTimer t)
        {
            return Natives._TriggerRegisterTimerExpireEvent(whichTrigger, t);
        }
        
        //native TriggerRegisterGameStateEvent takes trigger whichTrigger, gamestate whichState, limitop opcode, real limitval returns event
        public delegate JassEvent TriggerRegisterGameStateEventPrototype(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, JassRealArg limitval);
        private static TriggerRegisterGameStateEventPrototype _TriggerRegisterGameStateEvent;
        public static JassEvent TriggerRegisterGameStateEvent(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives._TriggerRegisterGameStateEvent(whichTrigger, whichState, opcode, limitval);
        }
        
        //native TriggerRegisterDialogEvent takes trigger whichTrigger, dialog whichDialog returns event
        public delegate JassEvent TriggerRegisterDialogEventPrototype(JassTrigger whichTrigger, JassDialog whichDialog);
        private static TriggerRegisterDialogEventPrototype _TriggerRegisterDialogEvent;
        public static JassEvent TriggerRegisterDialogEvent(JassTrigger whichTrigger, JassDialog whichDialog)
        {
            return Natives._TriggerRegisterDialogEvent(whichTrigger, whichDialog);
        }
        
        //native TriggerRegisterDialogButtonEvent takes trigger whichTrigger, button whichButton returns event
        public delegate JassEvent TriggerRegisterDialogButtonEventPrototype(JassTrigger whichTrigger, JassButton whichButton);
        private static TriggerRegisterDialogButtonEventPrototype _TriggerRegisterDialogButtonEvent;
        public static JassEvent TriggerRegisterDialogButtonEvent(JassTrigger whichTrigger, JassButton whichButton)
        {
            return Natives._TriggerRegisterDialogButtonEvent(whichTrigger, whichButton);
        }
        
        //native GetEventGameState takes nothing returns gamestate
        public delegate JassGameState GetEventGameStatePrototype();
        private static GetEventGameStatePrototype _GetEventGameState;
        public static JassGameState GetEventGameState()
        {
            return Natives._GetEventGameState();
        }
        
        //native TriggerRegisterGameEvent takes trigger whichTrigger, gameevent whichGameEvent returns event
        public delegate JassEvent TriggerRegisterGameEventPrototype(JassTrigger whichTrigger, JassGameEvent whichGameEvent);
        private static TriggerRegisterGameEventPrototype _TriggerRegisterGameEvent;
        public static JassEvent TriggerRegisterGameEvent(JassTrigger whichTrigger, JassGameEvent whichGameEvent)
        {
            return Natives._TriggerRegisterGameEvent(whichTrigger, whichGameEvent);
        }
        
        //native GetWinningPlayer takes nothing returns player
        public delegate JassPlayer GetWinningPlayerPrototype();
        private static GetWinningPlayerPrototype _GetWinningPlayer;
        public static JassPlayer GetWinningPlayer()
        {
            return Natives._GetWinningPlayer();
        }
        
        //native TriggerRegisterEnterRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterEnterRegionPrototype(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter);
        private static TriggerRegisterEnterRegionPrototype _TriggerRegisterEnterRegion;
        public static JassEvent TriggerRegisterEnterRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return Natives._TriggerRegisterEnterRegion(whichTrigger, whichRegion, filter);
        }
        
        //native GetTriggeringRegion takes nothing returns region
        public delegate JassRegion GetTriggeringRegionPrototype();
        private static GetTriggeringRegionPrototype _GetTriggeringRegion;
        public static JassRegion GetTriggeringRegion()
        {
            return Natives._GetTriggeringRegion();
        }
        
        //native GetEnteringUnit takes nothing returns unit
        public delegate JassUnit GetEnteringUnitPrototype();
        private static GetEnteringUnitPrototype _GetEnteringUnit;
        public static JassUnit GetEnteringUnit()
        {
            return Natives._GetEnteringUnit();
        }
        
        //native TriggerRegisterLeaveRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterLeaveRegionPrototype(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter);
        private static TriggerRegisterLeaveRegionPrototype _TriggerRegisterLeaveRegion;
        public static JassEvent TriggerRegisterLeaveRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return Natives._TriggerRegisterLeaveRegion(whichTrigger, whichRegion, filter);
        }
        
        //native GetLeavingUnit takes nothing returns unit
        public delegate JassUnit GetLeavingUnitPrototype();
        private static GetLeavingUnitPrototype _GetLeavingUnit;
        public static JassUnit GetLeavingUnit()
        {
            return Natives._GetLeavingUnit();
        }
        
        //native TriggerRegisterTrackableHitEvent takes trigger whichTrigger, trackable t returns event
        public delegate JassEvent TriggerRegisterTrackableHitEventPrototype(JassTrigger whichTrigger, JassTrackable t);
        private static TriggerRegisterTrackableHitEventPrototype _TriggerRegisterTrackableHitEvent;
        public static JassEvent TriggerRegisterTrackableHitEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return Natives._TriggerRegisterTrackableHitEvent(whichTrigger, t);
        }
        
        //native TriggerRegisterTrackableTrackEvent takes trigger whichTrigger, trackable t returns event
        public delegate JassEvent TriggerRegisterTrackableTrackEventPrototype(JassTrigger whichTrigger, JassTrackable t);
        private static TriggerRegisterTrackableTrackEventPrototype _TriggerRegisterTrackableTrackEvent;
        public static JassEvent TriggerRegisterTrackableTrackEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return Natives._TriggerRegisterTrackableTrackEvent(whichTrigger, t);
        }
        
        //native GetTriggeringTrackable takes nothing returns trackable
        public delegate JassTrackable GetTriggeringTrackablePrototype();
        private static GetTriggeringTrackablePrototype _GetTriggeringTrackable;
        public static JassTrackable GetTriggeringTrackable()
        {
            return Natives._GetTriggeringTrackable();
        }
        
        //native GetClickedButton takes nothing returns button
        public delegate JassButton GetClickedButtonPrototype();
        private static GetClickedButtonPrototype _GetClickedButton;
        public static JassButton GetClickedButton()
        {
            return Natives._GetClickedButton();
        }
        
        //native GetClickedDialog takes nothing returns dialog
        public delegate JassDialog GetClickedDialogPrototype();
        private static GetClickedDialogPrototype _GetClickedDialog;
        public static JassDialog GetClickedDialog()
        {
            return Natives._GetClickedDialog();
        }
        
        //native GetTournamentFinishSoonTimeRemaining takes nothing returns real
        public delegate JassRealRet GetTournamentFinishSoonTimeRemainingPrototype();
        private static GetTournamentFinishSoonTimeRemainingPrototype _GetTournamentFinishSoonTimeRemaining;
        public static Single GetTournamentFinishSoonTimeRemaining()
        {
            return Natives._GetTournamentFinishSoonTimeRemaining();
        }
        
        //native GetTournamentFinishNowRule takes nothing returns integer
        public delegate JassInteger GetTournamentFinishNowRulePrototype();
        private static GetTournamentFinishNowRulePrototype _GetTournamentFinishNowRule;
        public static JassInteger GetTournamentFinishNowRule()
        {
            return Natives._GetTournamentFinishNowRule();
        }
        
        //native GetTournamentFinishNowPlayer takes nothing returns player
        public delegate JassPlayer GetTournamentFinishNowPlayerPrototype();
        private static GetTournamentFinishNowPlayerPrototype _GetTournamentFinishNowPlayer;
        public static JassPlayer GetTournamentFinishNowPlayer()
        {
            return Natives._GetTournamentFinishNowPlayer();
        }
        
        //native GetTournamentScore takes player whichPlayer returns integer
        public delegate JassInteger GetTournamentScorePrototype(JassPlayer whichPlayer);
        private static GetTournamentScorePrototype _GetTournamentScore;
        public static JassInteger GetTournamentScore(JassPlayer whichPlayer)
        {
            return Natives._GetTournamentScore(whichPlayer);
        }
        
        //native GetSaveBasicFilename takes nothing returns string
        public delegate JassStringRet GetSaveBasicFilenamePrototype();
        private static GetSaveBasicFilenamePrototype _GetSaveBasicFilename;
        public static String GetSaveBasicFilename()
        {
            return Natives._GetSaveBasicFilename();
        }
        
        //native TriggerRegisterPlayerEvent takes trigger whichTrigger, player whichPlayer, playerevent whichPlayerEvent returns event
        public delegate JassEvent TriggerRegisterPlayerEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent);
        private static TriggerRegisterPlayerEventPrototype _TriggerRegisterPlayerEvent;
        public static JassEvent TriggerRegisterPlayerEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent)
        {
            return Natives._TriggerRegisterPlayerEvent(whichTrigger, whichPlayer, whichPlayerEvent);
        }
        
        //native GetTriggerPlayer takes nothing returns player
        public delegate JassPlayer GetTriggerPlayerPrototype();
        private static GetTriggerPlayerPrototype _GetTriggerPlayer;
        public static JassPlayer GetTriggerPlayer()
        {
            return Natives._GetTriggerPlayer();
        }
        
        //native TriggerRegisterPlayerUnitEvent takes trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterPlayerUnitEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter);
        private static TriggerRegisterPlayerUnitEventPrototype _TriggerRegisterPlayerUnitEvent;
        public static JassEvent TriggerRegisterPlayerUnitEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter)
        {
            return Natives._TriggerRegisterPlayerUnitEvent(whichTrigger, whichPlayer, whichPlayerUnitEvent, filter);
        }
        
        //native GetLevelingUnit takes nothing returns unit
        public delegate JassUnit GetLevelingUnitPrototype();
        private static GetLevelingUnitPrototype _GetLevelingUnit;
        public static JassUnit GetLevelingUnit()
        {
            return Natives._GetLevelingUnit();
        }
        
        //native GetLearningUnit takes nothing returns unit
        public delegate JassUnit GetLearningUnitPrototype();
        private static GetLearningUnitPrototype _GetLearningUnit;
        public static JassUnit GetLearningUnit()
        {
            return Natives._GetLearningUnit();
        }
        
        //native GetLearnedSkill takes nothing returns integer
        public delegate JassInteger GetLearnedSkillPrototype();
        private static GetLearnedSkillPrototype _GetLearnedSkill;
        public static JassInteger GetLearnedSkill()
        {
            return Natives._GetLearnedSkill();
        }
        
        //native GetLearnedSkillLevel takes nothing returns integer
        public delegate JassInteger GetLearnedSkillLevelPrototype();
        private static GetLearnedSkillLevelPrototype _GetLearnedSkillLevel;
        public static JassInteger GetLearnedSkillLevel()
        {
            return Natives._GetLearnedSkillLevel();
        }
        
        //native GetRevivableUnit takes nothing returns unit
        public delegate JassUnit GetRevivableUnitPrototype();
        private static GetRevivableUnitPrototype _GetRevivableUnit;
        public static JassUnit GetRevivableUnit()
        {
            return Natives._GetRevivableUnit();
        }
        
        //native GetRevivingUnit takes nothing returns unit
        public delegate JassUnit GetRevivingUnitPrototype();
        private static GetRevivingUnitPrototype _GetRevivingUnit;
        public static JassUnit GetRevivingUnit()
        {
            return Natives._GetRevivingUnit();
        }
        
        //native GetAttacker takes nothing returns unit
        public delegate JassUnit GetAttackerPrototype();
        private static GetAttackerPrototype _GetAttacker;
        public static JassUnit GetAttacker()
        {
            return Natives._GetAttacker();
        }
        
        //native GetRescuer takes nothing returns unit
        public delegate JassUnit GetRescuerPrototype();
        private static GetRescuerPrototype _GetRescuer;
        public static JassUnit GetRescuer()
        {
            return Natives._GetRescuer();
        }
        
        //native GetDyingUnit takes nothing returns unit
        public delegate JassUnit GetDyingUnitPrototype();
        private static GetDyingUnitPrototype _GetDyingUnit;
        public static JassUnit GetDyingUnit()
        {
            return Natives._GetDyingUnit();
        }
        
        //native GetKillingUnit takes nothing returns unit
        public delegate JassUnit GetKillingUnitPrototype();
        private static GetKillingUnitPrototype _GetKillingUnit;
        public static JassUnit GetKillingUnit()
        {
            return Natives._GetKillingUnit();
        }
        
        //native GetDecayingUnit takes nothing returns unit
        public delegate JassUnit GetDecayingUnitPrototype();
        private static GetDecayingUnitPrototype _GetDecayingUnit;
        public static JassUnit GetDecayingUnit()
        {
            return Natives._GetDecayingUnit();
        }
        
        //native GetConstructingStructure takes nothing returns unit
        public delegate JassUnit GetConstructingStructurePrototype();
        private static GetConstructingStructurePrototype _GetConstructingStructure;
        public static JassUnit GetConstructingStructure()
        {
            return Natives._GetConstructingStructure();
        }
        
        //native GetCancelledStructure takes nothing returns unit
        public delegate JassUnit GetCancelledStructurePrototype();
        private static GetCancelledStructurePrototype _GetCancelledStructure;
        public static JassUnit GetCancelledStructure()
        {
            return Natives._GetCancelledStructure();
        }
        
        //native GetConstructedStructure takes nothing returns unit
        public delegate JassUnit GetConstructedStructurePrototype();
        private static GetConstructedStructurePrototype _GetConstructedStructure;
        public static JassUnit GetConstructedStructure()
        {
            return Natives._GetConstructedStructure();
        }
        
        //native GetResearchingUnit takes nothing returns unit
        public delegate JassUnit GetResearchingUnitPrototype();
        private static GetResearchingUnitPrototype _GetResearchingUnit;
        public static JassUnit GetResearchingUnit()
        {
            return Natives._GetResearchingUnit();
        }
        
        //native GetResearched takes nothing returns integer
        public delegate JassInteger GetResearchedPrototype();
        private static GetResearchedPrototype _GetResearched;
        public static JassInteger GetResearched()
        {
            return Natives._GetResearched();
        }
        
        //native GetTrainedUnitType takes nothing returns integer
        public delegate JassInteger GetTrainedUnitTypePrototype();
        private static GetTrainedUnitTypePrototype _GetTrainedUnitType;
        public static JassInteger GetTrainedUnitType()
        {
            return Natives._GetTrainedUnitType();
        }
        
        //native GetTrainedUnit takes nothing returns unit
        public delegate JassUnit GetTrainedUnitPrototype();
        private static GetTrainedUnitPrototype _GetTrainedUnit;
        public static JassUnit GetTrainedUnit()
        {
            return Natives._GetTrainedUnit();
        }
        
        //native GetDetectedUnit takes nothing returns unit
        public delegate JassUnit GetDetectedUnitPrototype();
        private static GetDetectedUnitPrototype _GetDetectedUnit;
        public static JassUnit GetDetectedUnit()
        {
            return Natives._GetDetectedUnit();
        }
        
        //native GetSummoningUnit takes nothing returns unit
        public delegate JassUnit GetSummoningUnitPrototype();
        private static GetSummoningUnitPrototype _GetSummoningUnit;
        public static JassUnit GetSummoningUnit()
        {
            return Natives._GetSummoningUnit();
        }
        
        //native GetSummonedUnit takes nothing returns unit
        public delegate JassUnit GetSummonedUnitPrototype();
        private static GetSummonedUnitPrototype _GetSummonedUnit;
        public static JassUnit GetSummonedUnit()
        {
            return Natives._GetSummonedUnit();
        }
        
        //native GetTransportUnit takes nothing returns unit
        public delegate JassUnit GetTransportUnitPrototype();
        private static GetTransportUnitPrototype _GetTransportUnit;
        public static JassUnit GetTransportUnit()
        {
            return Natives._GetTransportUnit();
        }
        
        //native GetLoadedUnit takes nothing returns unit
        public delegate JassUnit GetLoadedUnitPrototype();
        private static GetLoadedUnitPrototype _GetLoadedUnit;
        public static JassUnit GetLoadedUnit()
        {
            return Natives._GetLoadedUnit();
        }
        
        //native GetSellingUnit takes nothing returns unit
        public delegate JassUnit GetSellingUnitPrototype();
        private static GetSellingUnitPrototype _GetSellingUnit;
        public static JassUnit GetSellingUnit()
        {
            return Natives._GetSellingUnit();
        }
        
        //native GetSoldUnit takes nothing returns unit
        public delegate JassUnit GetSoldUnitPrototype();
        private static GetSoldUnitPrototype _GetSoldUnit;
        public static JassUnit GetSoldUnit()
        {
            return Natives._GetSoldUnit();
        }
        
        //native GetBuyingUnit takes nothing returns unit
        public delegate JassUnit GetBuyingUnitPrototype();
        private static GetBuyingUnitPrototype _GetBuyingUnit;
        public static JassUnit GetBuyingUnit()
        {
            return Natives._GetBuyingUnit();
        }
        
        //native GetSoldItem takes nothing returns item
        public delegate JassItem GetSoldItemPrototype();
        private static GetSoldItemPrototype _GetSoldItem;
        public static JassItem GetSoldItem()
        {
            return Natives._GetSoldItem();
        }
        
        //native GetChangingUnit takes nothing returns unit
        public delegate JassUnit GetChangingUnitPrototype();
        private static GetChangingUnitPrototype _GetChangingUnit;
        public static JassUnit GetChangingUnit()
        {
            return Natives._GetChangingUnit();
        }
        
        //native GetChangingUnitPrevOwner takes nothing returns player
        public delegate JassPlayer GetChangingUnitPrevOwnerPrototype();
        private static GetChangingUnitPrevOwnerPrototype _GetChangingUnitPrevOwner;
        public static JassPlayer GetChangingUnitPrevOwner()
        {
            return Natives._GetChangingUnitPrevOwner();
        }
        
        //native GetManipulatingUnit takes nothing returns unit
        public delegate JassUnit GetManipulatingUnitPrototype();
        private static GetManipulatingUnitPrototype _GetManipulatingUnit;
        public static JassUnit GetManipulatingUnit()
        {
            return Natives._GetManipulatingUnit();
        }
        
        //native GetManipulatedItem takes nothing returns item
        public delegate JassItem GetManipulatedItemPrototype();
        private static GetManipulatedItemPrototype _GetManipulatedItem;
        public static JassItem GetManipulatedItem()
        {
            return Natives._GetManipulatedItem();
        }
        
        //native GetOrderedUnit takes nothing returns unit
        public delegate JassUnit GetOrderedUnitPrototype();
        private static GetOrderedUnitPrototype _GetOrderedUnit;
        public static JassUnit GetOrderedUnit()
        {
            return Natives._GetOrderedUnit();
        }
        
        //native GetIssuedOrderId takes nothing returns integer
        public delegate JassOrder GetIssuedOrderIdPrototype();
        private static GetIssuedOrderIdPrototype _GetIssuedOrderId;
        public static JassOrder GetIssuedOrderId()
        {
            return Natives._GetIssuedOrderId();
        }
        
        //native GetOrderPointX takes nothing returns real
        public delegate JassRealRet GetOrderPointXPrototype();
        private static GetOrderPointXPrototype _GetOrderPointX;
        public static Single GetOrderPointX()
        {
            return Natives._GetOrderPointX();
        }
        
        //native GetOrderPointY takes nothing returns real
        public delegate JassRealRet GetOrderPointYPrototype();
        private static GetOrderPointYPrototype _GetOrderPointY;
        public static Single GetOrderPointY()
        {
            return Natives._GetOrderPointY();
        }
        
        //native GetOrderPointLoc takes nothing returns location
        public delegate JassLocation GetOrderPointLocPrototype();
        private static GetOrderPointLocPrototype _GetOrderPointLoc;
        public static JassLocation GetOrderPointLoc()
        {
            return Natives._GetOrderPointLoc();
        }
        
        //native GetOrderTarget takes nothing returns widget
        public delegate JassWidget GetOrderTargetPrototype();
        private static GetOrderTargetPrototype _GetOrderTarget;
        public static JassWidget GetOrderTarget()
        {
            return Natives._GetOrderTarget();
        }
        
        //native GetOrderTargetDestructable takes nothing returns destructable
        public delegate JassDestructable GetOrderTargetDestructablePrototype();
        private static GetOrderTargetDestructablePrototype _GetOrderTargetDestructable;
        public static JassDestructable GetOrderTargetDestructable()
        {
            return Natives._GetOrderTargetDestructable();
        }
        
        //native GetOrderTargetItem takes nothing returns item
        public delegate JassItem GetOrderTargetItemPrototype();
        private static GetOrderTargetItemPrototype _GetOrderTargetItem;
        public static JassItem GetOrderTargetItem()
        {
            return Natives._GetOrderTargetItem();
        }
        
        //native GetOrderTargetUnit takes nothing returns unit
        public delegate JassUnit GetOrderTargetUnitPrototype();
        private static GetOrderTargetUnitPrototype _GetOrderTargetUnit;
        public static JassUnit GetOrderTargetUnit()
        {
            return Natives._GetOrderTargetUnit();
        }
        
        //native GetSpellAbilityUnit takes nothing returns unit
        public delegate JassUnit GetSpellAbilityUnitPrototype();
        private static GetSpellAbilityUnitPrototype _GetSpellAbilityUnit;
        public static JassUnit GetSpellAbilityUnit()
        {
            return Natives._GetSpellAbilityUnit();
        }
        
        //native GetSpellAbilityId takes nothing returns integer
        public delegate JassObjectId GetSpellAbilityIdPrototype();
        private static GetSpellAbilityIdPrototype _GetSpellAbilityId;
        public static JassObjectId GetSpellAbilityId()
        {
            return Natives._GetSpellAbilityId();
        }
        
        //native GetSpellAbility takes nothing returns ability
        public delegate JassAbility GetSpellAbilityPrototype();
        private static GetSpellAbilityPrototype _GetSpellAbility;
        public static JassAbility GetSpellAbility()
        {
            return Natives._GetSpellAbility();
        }
        
        //native GetSpellTargetLoc takes nothing returns location
        public delegate JassLocation GetSpellTargetLocPrototype();
        private static GetSpellTargetLocPrototype _GetSpellTargetLoc;
        public static JassLocation GetSpellTargetLoc()
        {
            return Natives._GetSpellTargetLoc();
        }
        
        //native GetSpellTargetX takes nothing returns real
        public delegate JassRealRet GetSpellTargetXPrototype();
        private static GetSpellTargetXPrototype _GetSpellTargetX;
        public static Single GetSpellTargetX()
        {
            return Natives._GetSpellTargetX();
        }
        
        //native GetSpellTargetY takes nothing returns real
        public delegate JassRealRet GetSpellTargetYPrototype();
        private static GetSpellTargetYPrototype _GetSpellTargetY;
        public static Single GetSpellTargetY()
        {
            return Natives._GetSpellTargetY();
        }
        
        //native GetSpellTargetDestructable takes nothing returns destructable
        public delegate JassDestructable GetSpellTargetDestructablePrototype();
        private static GetSpellTargetDestructablePrototype _GetSpellTargetDestructable;
        public static JassDestructable GetSpellTargetDestructable()
        {
            return Natives._GetSpellTargetDestructable();
        }
        
        //native GetSpellTargetItem takes nothing returns item
        public delegate JassItem GetSpellTargetItemPrototype();
        private static GetSpellTargetItemPrototype _GetSpellTargetItem;
        public static JassItem GetSpellTargetItem()
        {
            return Natives._GetSpellTargetItem();
        }
        
        //native GetSpellTargetUnit takes nothing returns unit
        public delegate JassUnit GetSpellTargetUnitPrototype();
        private static GetSpellTargetUnitPrototype _GetSpellTargetUnit;
        public static JassUnit GetSpellTargetUnit()
        {
            return Natives._GetSpellTargetUnit();
        }
        
        //native TriggerRegisterPlayerAllianceChange takes trigger whichTrigger, player whichPlayer, alliancetype whichAlliance returns event
        public delegate JassEvent TriggerRegisterPlayerAllianceChangePrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance);
        private static TriggerRegisterPlayerAllianceChangePrototype _TriggerRegisterPlayerAllianceChange;
        public static JassEvent TriggerRegisterPlayerAllianceChange(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance)
        {
            return Natives._TriggerRegisterPlayerAllianceChange(whichTrigger, whichPlayer, whichAlliance);
        }
        
        //native TriggerRegisterPlayerStateEvent takes trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, real limitval returns event
        public delegate JassEvent TriggerRegisterPlayerStateEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, JassRealArg limitval);
        private static TriggerRegisterPlayerStateEventPrototype _TriggerRegisterPlayerStateEvent;
        public static JassEvent TriggerRegisterPlayerStateEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives._TriggerRegisterPlayerStateEvent(whichTrigger, whichPlayer, whichState, opcode, limitval);
        }
        
        //native GetEventPlayerState takes nothing returns playerstate
        public delegate JassPlayerState GetEventPlayerStatePrototype();
        private static GetEventPlayerStatePrototype _GetEventPlayerState;
        public static JassPlayerState GetEventPlayerState()
        {
            return Natives._GetEventPlayerState();
        }
        
        //native TriggerRegisterPlayerChatEvent takes trigger whichTrigger, player whichPlayer, string chatMessageToDetect, boolean exactMatchOnly returns event
        public delegate JassEvent TriggerRegisterPlayerChatEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassStringArg chatMessageToDetect, JassBoolean exactMatchOnly);
        private static TriggerRegisterPlayerChatEventPrototype _TriggerRegisterPlayerChatEvent;
        public static JassEvent TriggerRegisterPlayerChatEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, String chatMessageToDetect, Boolean exactMatchOnly)
        {
            return Natives._TriggerRegisterPlayerChatEvent(whichTrigger, whichPlayer, chatMessageToDetect, exactMatchOnly);
        }
        
        //native GetEventPlayerChatString takes nothing returns string
        public delegate JassStringRet GetEventPlayerChatStringPrototype();
        private static GetEventPlayerChatStringPrototype _GetEventPlayerChatString;
        public static String GetEventPlayerChatString()
        {
            return Natives._GetEventPlayerChatString();
        }
        
        //native GetEventPlayerChatStringMatched takes nothing returns string
        public delegate JassStringRet GetEventPlayerChatStringMatchedPrototype();
        private static GetEventPlayerChatStringMatchedPrototype _GetEventPlayerChatStringMatched;
        public static String GetEventPlayerChatStringMatched()
        {
            return Natives._GetEventPlayerChatStringMatched();
        }
        
        //native TriggerRegisterDeathEvent takes trigger whichTrigger, widget whichWidget returns event
        public delegate JassEvent TriggerRegisterDeathEventPrototype(JassTrigger whichTrigger, JassWidget whichWidget);
        private static TriggerRegisterDeathEventPrototype _TriggerRegisterDeathEvent;
        public static JassEvent TriggerRegisterDeathEvent(JassTrigger whichTrigger, JassWidget whichWidget)
        {
            return Natives._TriggerRegisterDeathEvent(whichTrigger, whichWidget);
        }
        
        //native GetTriggerUnit takes nothing returns unit
        public delegate JassUnit GetTriggerUnitPrototype();
        private static GetTriggerUnitPrototype _GetTriggerUnit;
        public static JassUnit GetTriggerUnit()
        {
            return Natives._GetTriggerUnit();
        }
        
        //native TriggerRegisterUnitStateEvent takes trigger whichTrigger, unit whichUnit, unitstate whichState, limitop opcode, real limitval returns event
        public delegate JassEvent TriggerRegisterUnitStateEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, JassRealArg limitval);
        private static TriggerRegisterUnitStateEventPrototype _TriggerRegisterUnitStateEvent;
        public static JassEvent TriggerRegisterUnitStateEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives._TriggerRegisterUnitStateEvent(whichTrigger, whichUnit, whichState, opcode, limitval);
        }
        
        //native GetEventUnitState takes nothing returns unitstate
        public delegate JassUnitState GetEventUnitStatePrototype();
        private static GetEventUnitStatePrototype _GetEventUnitState;
        public static JassUnitState GetEventUnitState()
        {
            return Natives._GetEventUnitState();
        }
        
        //native TriggerRegisterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent returns event
        public delegate JassEvent TriggerRegisterUnitEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent);
        private static TriggerRegisterUnitEventPrototype _TriggerRegisterUnitEvent;
        public static JassEvent TriggerRegisterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent)
        {
            return Natives._TriggerRegisterUnitEvent(whichTrigger, whichUnit, whichEvent);
        }
        
        //native GetEventDamage takes nothing returns real
        public delegate JassRealRet GetEventDamagePrototype();
        private static GetEventDamagePrototype _GetEventDamage;
        public static Single GetEventDamage()
        {
            return Natives._GetEventDamage();
        }
        
        //native GetEventDamageSource takes nothing returns unit
        public delegate JassUnit GetEventDamageSourcePrototype();
        private static GetEventDamageSourcePrototype _GetEventDamageSource;
        public static JassUnit GetEventDamageSource()
        {
            return Natives._GetEventDamageSource();
        }
        
        //native GetEventDetectingPlayer takes nothing returns player
        public delegate JassPlayer GetEventDetectingPlayerPrototype();
        private static GetEventDetectingPlayerPrototype _GetEventDetectingPlayer;
        public static JassPlayer GetEventDetectingPlayer()
        {
            return Natives._GetEventDetectingPlayer();
        }
        
        //native TriggerRegisterFilterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterFilterUnitEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter);
        private static TriggerRegisterFilterUnitEventPrototype _TriggerRegisterFilterUnitEvent;
        public static JassEvent TriggerRegisterFilterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter)
        {
            return Natives._TriggerRegisterFilterUnitEvent(whichTrigger, whichUnit, whichEvent, filter);
        }
        
        //native GetEventTargetUnit takes nothing returns unit
        public delegate JassUnit GetEventTargetUnitPrototype();
        private static GetEventTargetUnitPrototype _GetEventTargetUnit;
        public static JassUnit GetEventTargetUnit()
        {
            return Natives._GetEventTargetUnit();
        }
        
        //native TriggerRegisterUnitInRange takes trigger whichTrigger, unit whichUnit, real range, boolexpr filter returns event
        public delegate JassEvent TriggerRegisterUnitInRangePrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassRealArg range, JassBooleanExpression filter);
        private static TriggerRegisterUnitInRangePrototype _TriggerRegisterUnitInRange;
        public static JassEvent TriggerRegisterUnitInRange(JassTrigger whichTrigger, JassUnit whichUnit, Single range, JassBooleanExpression filter)
        {
            return Natives._TriggerRegisterUnitInRange(whichTrigger, whichUnit, range, filter);
        }
        
        //native TriggerAddCondition takes trigger whichTrigger, boolexpr condition returns triggercondition
        public delegate JassTriggerCondition TriggerAddConditionPrototype(JassTrigger whichTrigger, JassBooleanExpression condition);
        private static TriggerAddConditionPrototype _TriggerAddCondition;
        public static JassTriggerCondition TriggerAddCondition(JassTrigger whichTrigger, JassBooleanExpression condition)
        {
            return Natives._TriggerAddCondition(whichTrigger, condition);
        }
        
        //native TriggerRemoveCondition takes trigger whichTrigger, triggercondition whichCondition returns nothing
        public delegate void TriggerRemoveConditionPrototype(JassTrigger whichTrigger, JassTriggerCondition whichCondition);
        private static TriggerRemoveConditionPrototype _TriggerRemoveCondition;
        public static void TriggerRemoveCondition(JassTrigger whichTrigger, JassTriggerCondition whichCondition)
        {
            Natives._TriggerRemoveCondition(whichTrigger, whichCondition);
        }
        
        //native TriggerClearConditions takes trigger whichTrigger returns nothing
        public delegate void TriggerClearConditionsPrototype(JassTrigger whichTrigger);
        private static TriggerClearConditionsPrototype _TriggerClearConditions;
        public static void TriggerClearConditions(JassTrigger whichTrigger)
        {
            Natives._TriggerClearConditions(whichTrigger);
        }
        
        //native TriggerAddAction takes trigger whichTrigger, code actionFunc returns triggeraction
        public delegate JassTriggerAction TriggerAddActionPrototype(JassTrigger whichTrigger, JassCode actionFunc);
        private static TriggerAddActionPrototype _TriggerAddAction;
        public static JassTriggerAction TriggerAddAction(JassTrigger whichTrigger, JassCode actionFunc)
        {
            return Natives._TriggerAddAction(whichTrigger, actionFunc);
        }
        
        //native TriggerRemoveAction takes trigger whichTrigger, triggeraction whichAction returns nothing
        public delegate void TriggerRemoveActionPrototype(JassTrigger whichTrigger, JassTriggerAction whichAction);
        private static TriggerRemoveActionPrototype _TriggerRemoveAction;
        public static void TriggerRemoveAction(JassTrigger whichTrigger, JassTriggerAction whichAction)
        {
            Natives._TriggerRemoveAction(whichTrigger, whichAction);
        }
        
        //native TriggerClearActions takes trigger whichTrigger returns nothing
        public delegate void TriggerClearActionsPrototype(JassTrigger whichTrigger);
        private static TriggerClearActionsPrototype _TriggerClearActions;
        public static void TriggerClearActions(JassTrigger whichTrigger)
        {
            Natives._TriggerClearActions(whichTrigger);
        }
        
        //native TriggerSleepAction takes real timeout returns nothing
        public delegate void TriggerSleepActionPrototype(JassRealArg timeout);
        private static TriggerSleepActionPrototype _TriggerSleepAction;
        public static void TriggerSleepAction(Single timeout)
        {
            Natives._TriggerSleepAction(timeout);
        }
        
        //native TriggerWaitForSound takes sound s, real offset returns nothing
        public delegate void TriggerWaitForSoundPrototype(JassSound s, JassRealArg offset);
        private static TriggerWaitForSoundPrototype _TriggerWaitForSound;
        public static void TriggerWaitForSound(JassSound s, Single offset)
        {
            Natives._TriggerWaitForSound(s, offset);
        }
        
        //native TriggerEvaluate takes trigger whichTrigger returns boolean
        public delegate JassBoolean TriggerEvaluatePrototype(JassTrigger whichTrigger);
        private static TriggerEvaluatePrototype _TriggerEvaluate;
        public static Boolean TriggerEvaluate(JassTrigger whichTrigger)
        {
            return Natives._TriggerEvaluate(whichTrigger);
        }
        
        //native TriggerExecute takes trigger whichTrigger returns nothing
        public delegate void TriggerExecutePrototype(JassTrigger whichTrigger);
        private static TriggerExecutePrototype _TriggerExecute;
        public static void TriggerExecute(JassTrigger whichTrigger)
        {
            Natives._TriggerExecute(whichTrigger);
        }
        
        //native TriggerExecuteWait takes trigger whichTrigger returns nothing
        public delegate void TriggerExecuteWaitPrototype(JassTrigger whichTrigger);
        private static TriggerExecuteWaitPrototype _TriggerExecuteWait;
        public static void TriggerExecuteWait(JassTrigger whichTrigger)
        {
            Natives._TriggerExecuteWait(whichTrigger);
        }
        
        //native TriggerSyncStart takes nothing returns nothing
        public delegate void TriggerSyncStartPrototype();
        private static TriggerSyncStartPrototype _TriggerSyncStart;
        public static void TriggerSyncStart()
        {
            Natives._TriggerSyncStart();
        }
        
        //native TriggerSyncReady takes nothing returns nothing
        public delegate void TriggerSyncReadyPrototype();
        private static TriggerSyncReadyPrototype _TriggerSyncReady;
        public static void TriggerSyncReady()
        {
            Natives._TriggerSyncReady();
        }
        
        //native GetWidgetLife takes widget whichWidget returns real
        public delegate JassRealRet GetWidgetLifePrototype(JassWidget whichWidget);
        private static GetWidgetLifePrototype _GetWidgetLife;
        public static Single GetWidgetLife(JassWidget whichWidget)
        {
            return Natives._GetWidgetLife(whichWidget);
        }
        
        //native SetWidgetLife takes widget whichWidget, real newLife returns nothing
        public delegate void SetWidgetLifePrototype(JassWidget whichWidget, JassRealArg newLife);
        private static SetWidgetLifePrototype _SetWidgetLife;
        public static void SetWidgetLife(JassWidget whichWidget, Single newLife)
        {
            Natives._SetWidgetLife(whichWidget, newLife);
        }
        
        //native GetWidgetX takes widget whichWidget returns real
        public delegate JassRealRet GetWidgetXPrototype(JassWidget whichWidget);
        private static GetWidgetXPrototype _GetWidgetX;
        public static Single GetWidgetX(JassWidget whichWidget)
        {
            return Natives._GetWidgetX(whichWidget);
        }
        
        //native GetWidgetY takes widget whichWidget returns real
        public delegate JassRealRet GetWidgetYPrototype(JassWidget whichWidget);
        private static GetWidgetYPrototype _GetWidgetY;
        public static Single GetWidgetY(JassWidget whichWidget)
        {
            return Natives._GetWidgetY(whichWidget);
        }
        
        //native GetTriggerWidget takes nothing returns widget
        public delegate JassWidget GetTriggerWidgetPrototype();
        private static GetTriggerWidgetPrototype _GetTriggerWidget;
        public static JassWidget GetTriggerWidget()
        {
            return Natives._GetTriggerWidget();
        }
        
        //native CreateDestructable takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
        public delegate JassDestructable CreateDestructablePrototype(JassObjectId objectid, JassRealArg x, JassRealArg y, JassRealArg face, JassRealArg scale, JassInteger variation);
        private static CreateDestructablePrototype _CreateDestructable;
        public static JassDestructable CreateDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return Natives._CreateDestructable(objectid, x, y, face, scale, variation);
        }
        
        //native CreateDestructableZ takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
        public delegate JassDestructable CreateDestructableZPrototype(JassObjectId objectid, JassRealArg x, JassRealArg y, JassRealArg z, JassRealArg face, JassRealArg scale, JassInteger variation);
        private static CreateDestructableZPrototype _CreateDestructableZ;
        public static JassDestructable CreateDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return Natives._CreateDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        //native CreateDeadDestructable takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
        public delegate JassDestructable CreateDeadDestructablePrototype(JassObjectId objectid, JassRealArg x, JassRealArg y, JassRealArg face, JassRealArg scale, JassInteger variation);
        private static CreateDeadDestructablePrototype _CreateDeadDestructable;
        public static JassDestructable CreateDeadDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return Natives._CreateDeadDestructable(objectid, x, y, face, scale, variation);
        }
        
        //native CreateDeadDestructableZ takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
        public delegate JassDestructable CreateDeadDestructableZPrototype(JassObjectId objectid, JassRealArg x, JassRealArg y, JassRealArg z, JassRealArg face, JassRealArg scale, JassInteger variation);
        private static CreateDeadDestructableZPrototype _CreateDeadDestructableZ;
        public static JassDestructable CreateDeadDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return Natives._CreateDeadDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        //native RemoveDestructable takes destructable d returns nothing
        public delegate void RemoveDestructablePrototype(JassDestructable d);
        private static RemoveDestructablePrototype _RemoveDestructable;
        public static void RemoveDestructable(JassDestructable d)
        {
            Natives._RemoveDestructable(d);
        }
        
        //native KillDestructable takes destructable d returns nothing
        public delegate void KillDestructablePrototype(JassDestructable d);
        private static KillDestructablePrototype _KillDestructable;
        public static void KillDestructable(JassDestructable d)
        {
            Natives._KillDestructable(d);
        }
        
        //native SetDestructableInvulnerable takes destructable d, boolean flag returns nothing
        public delegate void SetDestructableInvulnerablePrototype(JassDestructable d, JassBoolean flag);
        private static SetDestructableInvulnerablePrototype _SetDestructableInvulnerable;
        public static void SetDestructableInvulnerable(JassDestructable d, Boolean flag)
        {
            Natives._SetDestructableInvulnerable(d, flag);
        }
        
        //native IsDestructableInvulnerable takes destructable d returns boolean
        public delegate JassBoolean IsDestructableInvulnerablePrototype(JassDestructable d);
        private static IsDestructableInvulnerablePrototype _IsDestructableInvulnerable;
        public static Boolean IsDestructableInvulnerable(JassDestructable d)
        {
            return Natives._IsDestructableInvulnerable(d);
        }
        
        //native EnumDestructablesInRect takes rect r, boolexpr filter, code actionFunc returns nothing
        public delegate void EnumDestructablesInRectPrototype(JassRect r, JassBooleanExpression filter, JassCode actionFunc);
        private static EnumDestructablesInRectPrototype _EnumDestructablesInRect;
        public static void EnumDestructablesInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            Natives._EnumDestructablesInRect(r, filter, actionFunc);
        }
        
        //native GetDestructableTypeId takes destructable d returns integer
        public delegate JassObjectId GetDestructableTypeIdPrototype(JassDestructable d);
        private static GetDestructableTypeIdPrototype _GetDestructableTypeId;
        public static JassObjectId GetDestructableTypeId(JassDestructable d)
        {
            return Natives._GetDestructableTypeId(d);
        }
        
        //native GetDestructableX takes destructable d returns real
        public delegate JassRealRet GetDestructableXPrototype(JassDestructable d);
        private static GetDestructableXPrototype _GetDestructableX;
        public static Single GetDestructableX(JassDestructable d)
        {
            return Natives._GetDestructableX(d);
        }
        
        //native GetDestructableY takes destructable d returns real
        public delegate JassRealRet GetDestructableYPrototype(JassDestructable d);
        private static GetDestructableYPrototype _GetDestructableY;
        public static Single GetDestructableY(JassDestructable d)
        {
            return Natives._GetDestructableY(d);
        }
        
        //native SetDestructableLife takes destructable d, real life returns nothing
        public delegate void SetDestructableLifePrototype(JassDestructable d, JassRealArg life);
        private static SetDestructableLifePrototype _SetDestructableLife;
        public static void SetDestructableLife(JassDestructable d, Single life)
        {
            Natives._SetDestructableLife(d, life);
        }
        
        //native GetDestructableLife takes destructable d returns real
        public delegate JassRealRet GetDestructableLifePrototype(JassDestructable d);
        private static GetDestructableLifePrototype _GetDestructableLife;
        public static Single GetDestructableLife(JassDestructable d)
        {
            return Natives._GetDestructableLife(d);
        }
        
        //native SetDestructableMaxLife takes destructable d, real max returns nothing
        public delegate void SetDestructableMaxLifePrototype(JassDestructable d, JassRealArg max);
        private static SetDestructableMaxLifePrototype _SetDestructableMaxLife;
        public static void SetDestructableMaxLife(JassDestructable d, Single max)
        {
            Natives._SetDestructableMaxLife(d, max);
        }
        
        //native GetDestructableMaxLife takes destructable d returns real
        public delegate JassRealRet GetDestructableMaxLifePrototype(JassDestructable d);
        private static GetDestructableMaxLifePrototype _GetDestructableMaxLife;
        public static Single GetDestructableMaxLife(JassDestructable d)
        {
            return Natives._GetDestructableMaxLife(d);
        }
        
        //native DestructableRestoreLife takes destructable d, real life, boolean birth returns nothing
        public delegate void DestructableRestoreLifePrototype(JassDestructable d, JassRealArg life, JassBoolean birth);
        private static DestructableRestoreLifePrototype _DestructableRestoreLife;
        public static void DestructableRestoreLife(JassDestructable d, Single life, Boolean birth)
        {
            Natives._DestructableRestoreLife(d, life, birth);
        }
        
        //native QueueDestructableAnimation takes destructable d, string whichAnimation returns nothing
        public delegate void QueueDestructableAnimationPrototype(JassDestructable d, JassStringArg whichAnimation);
        private static QueueDestructableAnimationPrototype _QueueDestructableAnimation;
        public static void QueueDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            Natives._QueueDestructableAnimation(d, whichAnimation);
        }
        
        //native SetDestructableAnimation takes destructable d, string whichAnimation returns nothing
        public delegate void SetDestructableAnimationPrototype(JassDestructable d, JassStringArg whichAnimation);
        private static SetDestructableAnimationPrototype _SetDestructableAnimation;
        public static void SetDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            Natives._SetDestructableAnimation(d, whichAnimation);
        }
        
        //native SetDestructableAnimationSpeed takes destructable d, real speedFactor returns nothing
        public delegate void SetDestructableAnimationSpeedPrototype(JassDestructable d, JassRealArg speedFactor);
        private static SetDestructableAnimationSpeedPrototype _SetDestructableAnimationSpeed;
        public static void SetDestructableAnimationSpeed(JassDestructable d, Single speedFactor)
        {
            Natives._SetDestructableAnimationSpeed(d, speedFactor);
        }
        
        //native ShowDestructable takes destructable d, boolean flag returns nothing
        public delegate void ShowDestructablePrototype(JassDestructable d, JassBoolean flag);
        private static ShowDestructablePrototype _ShowDestructable;
        public static void ShowDestructable(JassDestructable d, Boolean flag)
        {
            Natives._ShowDestructable(d, flag);
        }
        
        //native GetDestructableOccluderHeight takes destructable d returns real
        public delegate JassRealRet GetDestructableOccluderHeightPrototype(JassDestructable d);
        private static GetDestructableOccluderHeightPrototype _GetDestructableOccluderHeight;
        public static Single GetDestructableOccluderHeight(JassDestructable d)
        {
            return Natives._GetDestructableOccluderHeight(d);
        }
        
        //native SetDestructableOccluderHeight takes destructable d, real height returns nothing
        public delegate void SetDestructableOccluderHeightPrototype(JassDestructable d, JassRealArg height);
        private static SetDestructableOccluderHeightPrototype _SetDestructableOccluderHeight;
        public static void SetDestructableOccluderHeight(JassDestructable d, Single height)
        {
            Natives._SetDestructableOccluderHeight(d, height);
        }
        
        //native GetDestructableName takes destructable d returns string
        public delegate JassStringRet GetDestructableNamePrototype(JassDestructable d);
        private static GetDestructableNamePrototype _GetDestructableName;
        public static String GetDestructableName(JassDestructable d)
        {
            return Natives._GetDestructableName(d);
        }
        
        //native GetTriggerDestructable takes nothing returns destructable
        public delegate JassDestructable GetTriggerDestructablePrototype();
        private static GetTriggerDestructablePrototype _GetTriggerDestructable;
        public static JassDestructable GetTriggerDestructable()
        {
            return Natives._GetTriggerDestructable();
        }
        
        //native CreateItem takes integer itemid, real x, real y returns item
        public delegate JassItem CreateItemPrototype(JassObjectId itemid, JassRealArg x, JassRealArg y);
        private static CreateItemPrototype _CreateItem;
        public static JassItem CreateItem(JassObjectId itemid, Single x, Single y)
        {
            return Natives._CreateItem(itemid, x, y);
        }
        
        //native RemoveItem takes item whichItem returns nothing
        public delegate void RemoveItemPrototype(JassItem whichItem);
        private static RemoveItemPrototype _RemoveItem;
        public static void RemoveItem(JassItem whichItem)
        {
            Natives._RemoveItem(whichItem);
        }
        
        //native GetItemPlayer takes item whichItem returns player
        public delegate JassPlayer GetItemPlayerPrototype(JassItem whichItem);
        private static GetItemPlayerPrototype _GetItemPlayer;
        public static JassPlayer GetItemPlayer(JassItem whichItem)
        {
            return Natives._GetItemPlayer(whichItem);
        }
        
        //native GetItemTypeId takes item i returns integer
        public delegate JassObjectId GetItemTypeIdPrototype(JassItem i);
        private static GetItemTypeIdPrototype _GetItemTypeId;
        public static JassObjectId GetItemTypeId(JassItem i)
        {
            return Natives._GetItemTypeId(i);
        }
        
        //native GetItemX takes item i returns real
        public delegate JassRealRet GetItemXPrototype(JassItem i);
        private static GetItemXPrototype _GetItemX;
        public static Single GetItemX(JassItem i)
        {
            return Natives._GetItemX(i);
        }
        
        //native GetItemY takes item i returns real
        public delegate JassRealRet GetItemYPrototype(JassItem i);
        private static GetItemYPrototype _GetItemY;
        public static Single GetItemY(JassItem i)
        {
            return Natives._GetItemY(i);
        }
        
        //native SetItemPosition takes item i, real x, real y returns nothing
        public delegate void SetItemPositionPrototype(JassItem i, JassRealArg x, JassRealArg y);
        private static SetItemPositionPrototype _SetItemPosition;
        public static void SetItemPosition(JassItem i, Single x, Single y)
        {
            Natives._SetItemPosition(i, x, y);
        }
        
        //native SetItemDropOnDeath takes item whichItem, boolean flag returns nothing
        public delegate void SetItemDropOnDeathPrototype(JassItem whichItem, JassBoolean flag);
        private static SetItemDropOnDeathPrototype _SetItemDropOnDeath;
        public static void SetItemDropOnDeath(JassItem whichItem, Boolean flag)
        {
            Natives._SetItemDropOnDeath(whichItem, flag);
        }
        
        //native SetItemDroppable takes item i, boolean flag returns nothing
        public delegate void SetItemDroppablePrototype(JassItem i, JassBoolean flag);
        private static SetItemDroppablePrototype _SetItemDroppable;
        public static void SetItemDroppable(JassItem i, Boolean flag)
        {
            Natives._SetItemDroppable(i, flag);
        }
        
        //native SetItemPawnable takes item i, boolean flag returns nothing
        public delegate void SetItemPawnablePrototype(JassItem i, JassBoolean flag);
        private static SetItemPawnablePrototype _SetItemPawnable;
        public static void SetItemPawnable(JassItem i, Boolean flag)
        {
            Natives._SetItemPawnable(i, flag);
        }
        
        //native SetItemPlayer takes item whichItem, player whichPlayer, boolean changeColor returns nothing
        public delegate void SetItemPlayerPrototype(JassItem whichItem, JassPlayer whichPlayer, JassBoolean changeColor);
        private static SetItemPlayerPrototype _SetItemPlayer;
        public static void SetItemPlayer(JassItem whichItem, JassPlayer whichPlayer, Boolean changeColor)
        {
            Natives._SetItemPlayer(whichItem, whichPlayer, changeColor);
        }
        
        //native SetItemInvulnerable takes item whichItem, boolean flag returns nothing
        public delegate void SetItemInvulnerablePrototype(JassItem whichItem, JassBoolean flag);
        private static SetItemInvulnerablePrototype _SetItemInvulnerable;
        public static void SetItemInvulnerable(JassItem whichItem, Boolean flag)
        {
            Natives._SetItemInvulnerable(whichItem, flag);
        }
        
        //native IsItemInvulnerable takes item whichItem returns boolean
        public delegate JassBoolean IsItemInvulnerablePrototype(JassItem whichItem);
        private static IsItemInvulnerablePrototype _IsItemInvulnerable;
        public static Boolean IsItemInvulnerable(JassItem whichItem)
        {
            return Natives._IsItemInvulnerable(whichItem);
        }
        
        //native SetItemVisible takes item whichItem, boolean show returns nothing
        public delegate void SetItemVisiblePrototype(JassItem whichItem, JassBoolean show);
        private static SetItemVisiblePrototype _SetItemVisible;
        public static void SetItemVisible(JassItem whichItem, Boolean show)
        {
            Natives._SetItemVisible(whichItem, show);
        }
        
        //native IsItemVisible takes item whichItem returns boolean
        public delegate JassBoolean IsItemVisiblePrototype(JassItem whichItem);
        private static IsItemVisiblePrototype _IsItemVisible;
        public static Boolean IsItemVisible(JassItem whichItem)
        {
            return Natives._IsItemVisible(whichItem);
        }
        
        //native IsItemOwned takes item whichItem returns boolean
        public delegate JassBoolean IsItemOwnedPrototype(JassItem whichItem);
        private static IsItemOwnedPrototype _IsItemOwned;
        public static Boolean IsItemOwned(JassItem whichItem)
        {
            return Natives._IsItemOwned(whichItem);
        }
        
        //native IsItemPowerup takes item whichItem returns boolean
        public delegate JassBoolean IsItemPowerupPrototype(JassItem whichItem);
        private static IsItemPowerupPrototype _IsItemPowerup;
        public static Boolean IsItemPowerup(JassItem whichItem)
        {
            return Natives._IsItemPowerup(whichItem);
        }
        
        //native IsItemSellable takes item whichItem returns boolean
        public delegate JassBoolean IsItemSellablePrototype(JassItem whichItem);
        private static IsItemSellablePrototype _IsItemSellable;
        public static Boolean IsItemSellable(JassItem whichItem)
        {
            return Natives._IsItemSellable(whichItem);
        }
        
        //native IsItemPawnable takes item whichItem returns boolean
        public delegate JassBoolean IsItemPawnablePrototype(JassItem whichItem);
        private static IsItemPawnablePrototype _IsItemPawnable;
        public static Boolean IsItemPawnable(JassItem whichItem)
        {
            return Natives._IsItemPawnable(whichItem);
        }
        
        //native IsItemIdPowerup takes integer itemId returns boolean
        public delegate JassBoolean IsItemIdPowerupPrototype(JassObjectId itemId);
        private static IsItemIdPowerupPrototype _IsItemIdPowerup;
        public static Boolean IsItemIdPowerup(JassObjectId itemId)
        {
            return Natives._IsItemIdPowerup(itemId);
        }
        
        //native IsItemIdSellable takes integer itemId returns boolean
        public delegate JassBoolean IsItemIdSellablePrototype(JassObjectId itemId);
        private static IsItemIdSellablePrototype _IsItemIdSellable;
        public static Boolean IsItemIdSellable(JassObjectId itemId)
        {
            return Natives._IsItemIdSellable(itemId);
        }
        
        //native IsItemIdPawnable takes integer itemId returns boolean
        public delegate JassBoolean IsItemIdPawnablePrototype(JassObjectId itemId);
        private static IsItemIdPawnablePrototype _IsItemIdPawnable;
        public static Boolean IsItemIdPawnable(JassObjectId itemId)
        {
            return Natives._IsItemIdPawnable(itemId);
        }
        
        //native EnumItemsInRect takes rect r, boolexpr filter, code actionFunc returns nothing
        public delegate void EnumItemsInRectPrototype(JassRect r, JassBooleanExpression filter, JassCode actionFunc);
        private static EnumItemsInRectPrototype _EnumItemsInRect;
        public static void EnumItemsInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            Natives._EnumItemsInRect(r, filter, actionFunc);
        }
        
        //native GetItemLevel takes item whichItem returns integer
        public delegate JassInteger GetItemLevelPrototype(JassItem whichItem);
        private static GetItemLevelPrototype _GetItemLevel;
        public static JassInteger GetItemLevel(JassItem whichItem)
        {
            return Natives._GetItemLevel(whichItem);
        }
        
        //native GetItemType takes item whichItem returns itemtype
        public delegate JassItemType GetItemTypePrototype(JassItem whichItem);
        private static GetItemTypePrototype _GetItemType;
        public static JassItemType GetItemType(JassItem whichItem)
        {
            return Natives._GetItemType(whichItem);
        }
        
        //native SetItemDropID takes item whichItem, integer unitId returns nothing
        public delegate void SetItemDropIDPrototype(JassItem whichItem, JassObjectId unitId);
        private static SetItemDropIDPrototype _SetItemDropID;
        public static void SetItemDropID(JassItem whichItem, JassObjectId unitId)
        {
            Natives._SetItemDropID(whichItem, unitId);
        }
        
        //native GetItemName takes item whichItem returns string
        public delegate JassStringRet GetItemNamePrototype(JassItem whichItem);
        private static GetItemNamePrototype _GetItemName;
        public static String GetItemName(JassItem whichItem)
        {
            return Natives._GetItemName(whichItem);
        }
        
        //native GetItemCharges takes item whichItem returns integer
        public delegate JassInteger GetItemChargesPrototype(JassItem whichItem);
        private static GetItemChargesPrototype _GetItemCharges;
        public static JassInteger GetItemCharges(JassItem whichItem)
        {
            return Natives._GetItemCharges(whichItem);
        }
        
        //native SetItemCharges takes item whichItem, integer charges returns nothing
        public delegate void SetItemChargesPrototype(JassItem whichItem, JassInteger charges);
        private static SetItemChargesPrototype _SetItemCharges;
        public static void SetItemCharges(JassItem whichItem, JassInteger charges)
        {
            Natives._SetItemCharges(whichItem, charges);
        }
        
        //native GetItemUserData takes item whichItem returns integer
        public delegate JassInteger GetItemUserDataPrototype(JassItem whichItem);
        private static GetItemUserDataPrototype _GetItemUserData;
        public static JassInteger GetItemUserData(JassItem whichItem)
        {
            return Natives._GetItemUserData(whichItem);
        }
        
        //native SetItemUserData takes item whichItem, integer data returns nothing
        public delegate void SetItemUserDataPrototype(JassItem whichItem, JassInteger data);
        private static SetItemUserDataPrototype _SetItemUserData;
        public static void SetItemUserData(JassItem whichItem, JassInteger data)
        {
            Natives._SetItemUserData(whichItem, data);
        }
        
        //native CreateUnit takes player id, integer unitid, real x, real y, real face returns unit
        public delegate JassUnit CreateUnitPrototype(JassPlayer id, JassObjectId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateUnitPrototype _CreateUnit;
        public static JassUnit CreateUnit(JassPlayer id, JassObjectId unitid, Single x, Single y, Single face)
        {
            return Natives._CreateUnit(id, unitid, x, y, face);
        }
        
        //native CreateUnitByName takes player whichPlayer, string unitname, real x, real y, real face returns unit
        public delegate JassUnit CreateUnitByNamePrototype(JassPlayer whichPlayer, JassStringArg unitname, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateUnitByNamePrototype _CreateUnitByName;
        public static JassUnit CreateUnitByName(JassPlayer whichPlayer, String unitname, Single x, Single y, Single face)
        {
            return Natives._CreateUnitByName(whichPlayer, unitname, x, y, face);
        }
        
        //native CreateUnitAtLoc takes player id, integer unitid, location whichLocation, real face returns unit
        public delegate JassUnit CreateUnitAtLocPrototype(JassPlayer id, JassObjectId unitid, JassLocation whichLocation, JassRealArg face);
        private static CreateUnitAtLocPrototype _CreateUnitAtLoc;
        public static JassUnit CreateUnitAtLoc(JassPlayer id, JassObjectId unitid, JassLocation whichLocation, Single face)
        {
            return Natives._CreateUnitAtLoc(id, unitid, whichLocation, face);
        }
        
        //native CreateUnitAtLocByName takes player id, string unitname, location whichLocation, real face returns unit
        public delegate JassUnit CreateUnitAtLocByNamePrototype(JassPlayer id, JassStringArg unitname, JassLocation whichLocation, JassRealArg face);
        private static CreateUnitAtLocByNamePrototype _CreateUnitAtLocByName;
        public static JassUnit CreateUnitAtLocByName(JassPlayer id, String unitname, JassLocation whichLocation, Single face)
        {
            return Natives._CreateUnitAtLocByName(id, unitname, whichLocation, face);
        }
        
        //native CreateCorpse takes player whichPlayer, integer unitid, real x, real y, real face returns unit
        public delegate JassUnit CreateCorpsePrototype(JassPlayer whichPlayer, JassObjectId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateCorpsePrototype _CreateCorpse;
        public static JassUnit CreateCorpse(JassPlayer whichPlayer, JassObjectId unitid, Single x, Single y, Single face)
        {
            return Natives._CreateCorpse(whichPlayer, unitid, x, y, face);
        }
        
        //native KillUnit takes unit whichUnit returns nothing
        public delegate void KillUnitPrototype(JassUnit whichUnit);
        private static KillUnitPrototype _KillUnit;
        public static void KillUnit(JassUnit whichUnit)
        {
            Natives._KillUnit(whichUnit);
        }
        
        //native RemoveUnit takes unit whichUnit returns nothing
        public delegate void RemoveUnitPrototype(JassUnit whichUnit);
        private static RemoveUnitPrototype _RemoveUnit;
        public static void RemoveUnit(JassUnit whichUnit)
        {
            Natives._RemoveUnit(whichUnit);
        }
        
        //native ShowUnit takes unit whichUnit, boolean show returns nothing
        public delegate void ShowUnitPrototype(JassUnit whichUnit, JassBoolean show);
        private static ShowUnitPrototype _ShowUnit;
        public static void ShowUnit(JassUnit whichUnit, Boolean show)
        {
            Natives._ShowUnit(whichUnit, show);
        }
        
        //native SetUnitState takes unit whichUnit, unitstate whichUnitState, real newVal returns nothing
        public delegate void SetUnitStatePrototype(JassUnit whichUnit, JassUnitState whichUnitState, JassRealArg newVal);
        private static SetUnitStatePrototype _SetUnitState;
        public static void SetUnitState(JassUnit whichUnit, JassUnitState whichUnitState, Single newVal)
        {
            Natives._SetUnitState(whichUnit, whichUnitState, newVal);
        }
        
        //native SetUnitX takes unit whichUnit, real newX returns nothing
        public delegate void SetUnitXPrototype(JassUnit whichUnit, JassRealArg newX);
        private static SetUnitXPrototype _SetUnitX;
        public static void SetUnitX(JassUnit whichUnit, Single newX)
        {
            Natives._SetUnitX(whichUnit, newX);
        }
        
        //native SetUnitY takes unit whichUnit, real newY returns nothing
        public delegate void SetUnitYPrototype(JassUnit whichUnit, JassRealArg newY);
        private static SetUnitYPrototype _SetUnitY;
        public static void SetUnitY(JassUnit whichUnit, Single newY)
        {
            Natives._SetUnitY(whichUnit, newY);
        }
        
        //native SetUnitPosition takes unit whichUnit, real newX, real newY returns nothing
        public delegate void SetUnitPositionPrototype(JassUnit whichUnit, JassRealArg newX, JassRealArg newY);
        private static SetUnitPositionPrototype _SetUnitPosition;
        public static void SetUnitPosition(JassUnit whichUnit, Single newX, Single newY)
        {
            Natives._SetUnitPosition(whichUnit, newX, newY);
        }
        
        //native SetUnitPositionLoc takes unit whichUnit, location whichLocation returns nothing
        public delegate void SetUnitPositionLocPrototype(JassUnit whichUnit, JassLocation whichLocation);
        private static SetUnitPositionLocPrototype _SetUnitPositionLoc;
        public static void SetUnitPositionLoc(JassUnit whichUnit, JassLocation whichLocation)
        {
            Natives._SetUnitPositionLoc(whichUnit, whichLocation);
        }
        
        //native SetUnitFacing takes unit whichUnit, real facingAngle returns nothing
        public delegate void SetUnitFacingPrototype(JassUnit whichUnit, JassRealArg facingAngle);
        private static SetUnitFacingPrototype _SetUnitFacing;
        public static void SetUnitFacing(JassUnit whichUnit, Single facingAngle)
        {
            Natives._SetUnitFacing(whichUnit, facingAngle);
        }
        
        //native SetUnitFacingTimed takes unit whichUnit, real facingAngle, real duration returns nothing
        public delegate void SetUnitFacingTimedPrototype(JassUnit whichUnit, JassRealArg facingAngle, JassRealArg duration);
        private static SetUnitFacingTimedPrototype _SetUnitFacingTimed;
        public static void SetUnitFacingTimed(JassUnit whichUnit, Single facingAngle, Single duration)
        {
            Natives._SetUnitFacingTimed(whichUnit, facingAngle, duration);
        }
        
        //native SetUnitMoveSpeed takes unit whichUnit, real newSpeed returns nothing
        public delegate void SetUnitMoveSpeedPrototype(JassUnit whichUnit, JassRealArg newSpeed);
        private static SetUnitMoveSpeedPrototype _SetUnitMoveSpeed;
        public static void SetUnitMoveSpeed(JassUnit whichUnit, Single newSpeed)
        {
            Natives._SetUnitMoveSpeed(whichUnit, newSpeed);
        }
        
        //native SetUnitFlyHeight takes unit whichUnit, real newHeight, real rate returns nothing
        public delegate void SetUnitFlyHeightPrototype(JassUnit whichUnit, JassRealArg newHeight, JassRealArg rate);
        private static SetUnitFlyHeightPrototype _SetUnitFlyHeight;
        public static void SetUnitFlyHeight(JassUnit whichUnit, Single newHeight, Single rate)
        {
            Natives._SetUnitFlyHeight(whichUnit, newHeight, rate);
        }
        
        //native SetUnitTurnSpeed takes unit whichUnit, real newTurnSpeed returns nothing
        public delegate void SetUnitTurnSpeedPrototype(JassUnit whichUnit, JassRealArg newTurnSpeed);
        private static SetUnitTurnSpeedPrototype _SetUnitTurnSpeed;
        public static void SetUnitTurnSpeed(JassUnit whichUnit, Single newTurnSpeed)
        {
            Natives._SetUnitTurnSpeed(whichUnit, newTurnSpeed);
        }
        
        //native SetUnitPropWindow takes unit whichUnit, real newPropWindowAngle returns nothing
        public delegate void SetUnitPropWindowPrototype(JassUnit whichUnit, JassRealArg newPropWindowAngle);
        private static SetUnitPropWindowPrototype _SetUnitPropWindow;
        public static void SetUnitPropWindow(JassUnit whichUnit, Single newPropWindowAngle)
        {
            Natives._SetUnitPropWindow(whichUnit, newPropWindowAngle);
        }
        
        //native SetUnitAcquireRange takes unit whichUnit, real newAcquireRange returns nothing
        public delegate void SetUnitAcquireRangePrototype(JassUnit whichUnit, JassRealArg newAcquireRange);
        private static SetUnitAcquireRangePrototype _SetUnitAcquireRange;
        public static void SetUnitAcquireRange(JassUnit whichUnit, Single newAcquireRange)
        {
            Natives._SetUnitAcquireRange(whichUnit, newAcquireRange);
        }
        
        //native SetUnitCreepGuard takes unit whichUnit, boolean creepGuard returns nothing
        public delegate void SetUnitCreepGuardPrototype(JassUnit whichUnit, JassBoolean creepGuard);
        private static SetUnitCreepGuardPrototype _SetUnitCreepGuard;
        public static void SetUnitCreepGuard(JassUnit whichUnit, Boolean creepGuard)
        {
            Natives._SetUnitCreepGuard(whichUnit, creepGuard);
        }
        
        //native GetUnitAcquireRange takes unit whichUnit returns real
        public delegate JassRealRet GetUnitAcquireRangePrototype(JassUnit whichUnit);
        private static GetUnitAcquireRangePrototype _GetUnitAcquireRange;
        public static Single GetUnitAcquireRange(JassUnit whichUnit)
        {
            return Natives._GetUnitAcquireRange(whichUnit);
        }
        
        //native GetUnitTurnSpeed takes unit whichUnit returns real
        public delegate JassRealRet GetUnitTurnSpeedPrototype(JassUnit whichUnit);
        private static GetUnitTurnSpeedPrototype _GetUnitTurnSpeed;
        public static Single GetUnitTurnSpeed(JassUnit whichUnit)
        {
            return Natives._GetUnitTurnSpeed(whichUnit);
        }
        
        //native GetUnitPropWindow takes unit whichUnit returns real
        public delegate JassRealRet GetUnitPropWindowPrototype(JassUnit whichUnit);
        private static GetUnitPropWindowPrototype _GetUnitPropWindow;
        public static Single GetUnitPropWindow(JassUnit whichUnit)
        {
            return Natives._GetUnitPropWindow(whichUnit);
        }
        
        //native GetUnitFlyHeight takes unit whichUnit returns real
        public delegate JassRealRet GetUnitFlyHeightPrototype(JassUnit whichUnit);
        private static GetUnitFlyHeightPrototype _GetUnitFlyHeight;
        public static Single GetUnitFlyHeight(JassUnit whichUnit)
        {
            return Natives._GetUnitFlyHeight(whichUnit);
        }
        
        //native GetUnitDefaultAcquireRange takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultAcquireRangePrototype(JassUnit whichUnit);
        private static GetUnitDefaultAcquireRangePrototype _GetUnitDefaultAcquireRange;
        public static Single GetUnitDefaultAcquireRange(JassUnit whichUnit)
        {
            return Natives._GetUnitDefaultAcquireRange(whichUnit);
        }
        
        //native GetUnitDefaultTurnSpeed takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultTurnSpeedPrototype(JassUnit whichUnit);
        private static GetUnitDefaultTurnSpeedPrototype _GetUnitDefaultTurnSpeed;
        public static Single GetUnitDefaultTurnSpeed(JassUnit whichUnit)
        {
            return Natives._GetUnitDefaultTurnSpeed(whichUnit);
        }
        
        //native GetUnitDefaultPropWindow takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultPropWindowPrototype(JassUnit whichUnit);
        private static GetUnitDefaultPropWindowPrototype _GetUnitDefaultPropWindow;
        public static Single GetUnitDefaultPropWindow(JassUnit whichUnit)
        {
            return Natives._GetUnitDefaultPropWindow(whichUnit);
        }
        
        //native GetUnitDefaultFlyHeight takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultFlyHeightPrototype(JassUnit whichUnit);
        private static GetUnitDefaultFlyHeightPrototype _GetUnitDefaultFlyHeight;
        public static Single GetUnitDefaultFlyHeight(JassUnit whichUnit)
        {
            return Natives._GetUnitDefaultFlyHeight(whichUnit);
        }
        
        //native SetUnitOwner takes unit whichUnit, player whichPlayer, boolean changeColor returns nothing
        public delegate void SetUnitOwnerPrototype(JassUnit whichUnit, JassPlayer whichPlayer, JassBoolean changeColor);
        private static SetUnitOwnerPrototype _SetUnitOwner;
        public static void SetUnitOwner(JassUnit whichUnit, JassPlayer whichPlayer, Boolean changeColor)
        {
            Natives._SetUnitOwner(whichUnit, whichPlayer, changeColor);
        }
        
        //native SetUnitColor takes unit whichUnit, playercolor whichColor returns nothing
        public delegate void SetUnitColorPrototype(JassUnit whichUnit, JassPlayerColor whichColor);
        private static SetUnitColorPrototype _SetUnitColor;
        public static void SetUnitColor(JassUnit whichUnit, JassPlayerColor whichColor)
        {
            Natives._SetUnitColor(whichUnit, whichColor);
        }
        
        //native SetUnitScale takes unit whichUnit, real scaleX, real scaleY, real scaleZ returns nothing
        public delegate void SetUnitScalePrototype(JassUnit whichUnit, JassRealArg scaleX, JassRealArg scaleY, JassRealArg scaleZ);
        private static SetUnitScalePrototype _SetUnitScale;
        public static void SetUnitScale(JassUnit whichUnit, Single scaleX, Single scaleY, Single scaleZ)
        {
            Natives._SetUnitScale(whichUnit, scaleX, scaleY, scaleZ);
        }
        
        //native SetUnitTimeScale takes unit whichUnit, real timeScale returns nothing
        public delegate void SetUnitTimeScalePrototype(JassUnit whichUnit, JassRealArg timeScale);
        private static SetUnitTimeScalePrototype _SetUnitTimeScale;
        public static void SetUnitTimeScale(JassUnit whichUnit, Single timeScale)
        {
            Natives._SetUnitTimeScale(whichUnit, timeScale);
        }
        
        //native SetUnitBlendTime takes unit whichUnit, real blendTime returns nothing
        public delegate void SetUnitBlendTimePrototype(JassUnit whichUnit, JassRealArg blendTime);
        private static SetUnitBlendTimePrototype _SetUnitBlendTime;
        public static void SetUnitBlendTime(JassUnit whichUnit, Single blendTime)
        {
            Natives._SetUnitBlendTime(whichUnit, blendTime);
        }
        
        //native SetUnitVertexColor takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetUnitVertexColorPrototype(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetUnitVertexColorPrototype _SetUnitVertexColor;
        public static void SetUnitVertexColor(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._SetUnitVertexColor(whichUnit, red, green, blue, alpha);
        }
        
        //native QueueUnitAnimation takes unit whichUnit, string whichAnimation returns nothing
        public delegate void QueueUnitAnimationPrototype(JassUnit whichUnit, JassStringArg whichAnimation);
        private static QueueUnitAnimationPrototype _QueueUnitAnimation;
        public static void QueueUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            Natives._QueueUnitAnimation(whichUnit, whichAnimation);
        }
        
        //native SetUnitAnimation takes unit whichUnit, string whichAnimation returns nothing
        public delegate void SetUnitAnimationPrototype(JassUnit whichUnit, JassStringArg whichAnimation);
        private static SetUnitAnimationPrototype _SetUnitAnimation;
        public static void SetUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            Natives._SetUnitAnimation(whichUnit, whichAnimation);
        }
        
        //native SetUnitAnimationByIndex takes unit whichUnit, integer whichAnimation returns nothing
        public delegate void SetUnitAnimationByIndexPrototype(JassUnit whichUnit, JassInteger whichAnimation);
        private static SetUnitAnimationByIndexPrototype _SetUnitAnimationByIndex;
        public static void SetUnitAnimationByIndex(JassUnit whichUnit, JassInteger whichAnimation)
        {
            Natives._SetUnitAnimationByIndex(whichUnit, whichAnimation);
        }
        
        //native SetUnitAnimationWithRarity takes unit whichUnit, string whichAnimation, raritycontrol rarity returns nothing
        public delegate void SetUnitAnimationWithRarityPrototype(JassUnit whichUnit, JassStringArg whichAnimation, JassRarityControl rarity);
        private static SetUnitAnimationWithRarityPrototype _SetUnitAnimationWithRarity;
        public static void SetUnitAnimationWithRarity(JassUnit whichUnit, String whichAnimation, JassRarityControl rarity)
        {
            Natives._SetUnitAnimationWithRarity(whichUnit, whichAnimation, rarity);
        }
        
        //native AddUnitAnimationProperties takes unit whichUnit, string animProperties, boolean add returns nothing
        public delegate void AddUnitAnimationPropertiesPrototype(JassUnit whichUnit, JassStringArg animProperties, JassBoolean add);
        private static AddUnitAnimationPropertiesPrototype _AddUnitAnimationProperties;
        public static void AddUnitAnimationProperties(JassUnit whichUnit, String animProperties, Boolean add)
        {
            Natives._AddUnitAnimationProperties(whichUnit, animProperties, add);
        }
        
        //native SetUnitLookAt takes unit whichUnit, string whichBone, unit lookAtTarget, real offsetX, real offsetY, real offsetZ returns nothing
        public delegate void SetUnitLookAtPrototype(JassUnit whichUnit, JassStringArg whichBone, JassUnit lookAtTarget, JassRealArg offsetX, JassRealArg offsetY, JassRealArg offsetZ);
        private static SetUnitLookAtPrototype _SetUnitLookAt;
        public static void SetUnitLookAt(JassUnit whichUnit, String whichBone, JassUnit lookAtTarget, Single offsetX, Single offsetY, Single offsetZ)
        {
            Natives._SetUnitLookAt(whichUnit, whichBone, lookAtTarget, offsetX, offsetY, offsetZ);
        }
        
        //native ResetUnitLookAt takes unit whichUnit returns nothing
        public delegate void ResetUnitLookAtPrototype(JassUnit whichUnit);
        private static ResetUnitLookAtPrototype _ResetUnitLookAt;
        public static void ResetUnitLookAt(JassUnit whichUnit)
        {
            Natives._ResetUnitLookAt(whichUnit);
        }
        
        //native SetUnitRescuable takes unit whichUnit, player byWhichPlayer, boolean flag returns nothing
        public delegate void SetUnitRescuablePrototype(JassUnit whichUnit, JassPlayer byWhichPlayer, JassBoolean flag);
        private static SetUnitRescuablePrototype _SetUnitRescuable;
        public static void SetUnitRescuable(JassUnit whichUnit, JassPlayer byWhichPlayer, Boolean flag)
        {
            Natives._SetUnitRescuable(whichUnit, byWhichPlayer, flag);
        }
        
        //native SetUnitRescueRange takes unit whichUnit, real range returns nothing
        public delegate void SetUnitRescueRangePrototype(JassUnit whichUnit, JassRealArg range);
        private static SetUnitRescueRangePrototype _SetUnitRescueRange;
        public static void SetUnitRescueRange(JassUnit whichUnit, Single range)
        {
            Natives._SetUnitRescueRange(whichUnit, range);
        }
        
        //native SetHeroStr takes unit whichHero, integer newStr, boolean permanent returns nothing
        public delegate void SetHeroStrPrototype(JassUnit whichHero, JassInteger newStr, JassBoolean permanent);
        private static SetHeroStrPrototype _SetHeroStr;
        public static void SetHeroStr(JassUnit whichHero, JassInteger newStr, Boolean permanent)
        {
            Natives._SetHeroStr(whichHero, newStr, permanent);
        }
        
        //native SetHeroAgi takes unit whichHero, integer newAgi, boolean permanent returns nothing
        public delegate void SetHeroAgiPrototype(JassUnit whichHero, JassInteger newAgi, JassBoolean permanent);
        private static SetHeroAgiPrototype _SetHeroAgi;
        public static void SetHeroAgi(JassUnit whichHero, JassInteger newAgi, Boolean permanent)
        {
            Natives._SetHeroAgi(whichHero, newAgi, permanent);
        }
        
        //native SetHeroInt takes unit whichHero, integer newInt, boolean permanent returns nothing
        public delegate void SetHeroIntPrototype(JassUnit whichHero, JassInteger newInt, JassBoolean permanent);
        private static SetHeroIntPrototype _SetHeroInt;
        public static void SetHeroInt(JassUnit whichHero, JassInteger newInt, Boolean permanent)
        {
            Natives._SetHeroInt(whichHero, newInt, permanent);
        }
        
        //native GetHeroStr takes unit whichHero, boolean includeBonuses returns integer
        public delegate JassInteger GetHeroStrPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private static GetHeroStrPrototype _GetHeroStr;
        public static JassInteger GetHeroStr(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives._GetHeroStr(whichHero, includeBonuses);
        }
        
        //native GetHeroAgi takes unit whichHero, boolean includeBonuses returns integer
        public delegate JassInteger GetHeroAgiPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private static GetHeroAgiPrototype _GetHeroAgi;
        public static JassInteger GetHeroAgi(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives._GetHeroAgi(whichHero, includeBonuses);
        }
        
        //native GetHeroInt takes unit whichHero, boolean includeBonuses returns integer
        public delegate JassInteger GetHeroIntPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private static GetHeroIntPrototype _GetHeroInt;
        public static JassInteger GetHeroInt(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives._GetHeroInt(whichHero, includeBonuses);
        }
        
        //native UnitStripHeroLevel takes unit whichHero, integer howManyLevels returns boolean
        public delegate JassBoolean UnitStripHeroLevelPrototype(JassUnit whichHero, JassInteger howManyLevels);
        private static UnitStripHeroLevelPrototype _UnitStripHeroLevel;
        public static Boolean UnitStripHeroLevel(JassUnit whichHero, JassInteger howManyLevels)
        {
            return Natives._UnitStripHeroLevel(whichHero, howManyLevels);
        }
        
        //native GetHeroXP takes unit whichHero returns integer
        public delegate JassInteger GetHeroXPPrototype(JassUnit whichHero);
        private static GetHeroXPPrototype _GetHeroXP;
        public static JassInteger GetHeroXP(JassUnit whichHero)
        {
            return Natives._GetHeroXP(whichHero);
        }
        
        //native SetHeroXP takes unit whichHero, integer newXpVal, boolean showEyeCandy returns nothing
        public delegate void SetHeroXPPrototype(JassUnit whichHero, JassInteger newXpVal, JassBoolean showEyeCandy);
        private static SetHeroXPPrototype _SetHeroXP;
        public static void SetHeroXP(JassUnit whichHero, JassInteger newXpVal, Boolean showEyeCandy)
        {
            Natives._SetHeroXP(whichHero, newXpVal, showEyeCandy);
        }
        
        //native GetHeroSkillPoints takes unit whichHero returns integer
        public delegate JassInteger GetHeroSkillPointsPrototype(JassUnit whichHero);
        private static GetHeroSkillPointsPrototype _GetHeroSkillPoints;
        public static JassInteger GetHeroSkillPoints(JassUnit whichHero)
        {
            return Natives._GetHeroSkillPoints(whichHero);
        }
        
        //native UnitModifySkillPoints takes unit whichHero, integer skillPointDelta returns boolean
        public delegate JassBoolean UnitModifySkillPointsPrototype(JassUnit whichHero, JassInteger skillPointDelta);
        private static UnitModifySkillPointsPrototype _UnitModifySkillPoints;
        public static Boolean UnitModifySkillPoints(JassUnit whichHero, JassInteger skillPointDelta)
        {
            return Natives._UnitModifySkillPoints(whichHero, skillPointDelta);
        }
        
        //native AddHeroXP takes unit whichHero, integer xpToAdd, boolean showEyeCandy returns nothing
        public delegate void AddHeroXPPrototype(JassUnit whichHero, JassInteger xpToAdd, JassBoolean showEyeCandy);
        private static AddHeroXPPrototype _AddHeroXP;
        public static void AddHeroXP(JassUnit whichHero, JassInteger xpToAdd, Boolean showEyeCandy)
        {
            Natives._AddHeroXP(whichHero, xpToAdd, showEyeCandy);
        }
        
        //native SetHeroLevel takes unit whichHero, integer level, boolean showEyeCandy returns nothing
        public delegate void SetHeroLevelPrototype(JassUnit whichHero, JassInteger level, JassBoolean showEyeCandy);
        private static SetHeroLevelPrototype _SetHeroLevel;
        public static void SetHeroLevel(JassUnit whichHero, JassInteger level, Boolean showEyeCandy)
        {
            Natives._SetHeroLevel(whichHero, level, showEyeCandy);
        }
        
        //native GetHeroLevel takes unit whichHero returns integer
        public delegate JassInteger GetHeroLevelPrototype(JassUnit whichHero);
        private static GetHeroLevelPrototype _GetHeroLevel;
        public static JassInteger GetHeroLevel(JassUnit whichHero)
        {
            return Natives._GetHeroLevel(whichHero);
        }
        
        //native GetUnitLevel takes unit whichUnit returns integer
        public delegate JassInteger GetUnitLevelPrototype(JassUnit whichUnit);
        private static GetUnitLevelPrototype _GetUnitLevel;
        public static JassInteger GetUnitLevel(JassUnit whichUnit)
        {
            return Natives._GetUnitLevel(whichUnit);
        }
        
        //native GetHeroProperName takes unit whichHero returns string
        public delegate JassStringRet GetHeroProperNamePrototype(JassUnit whichHero);
        private static GetHeroProperNamePrototype _GetHeroProperName;
        public static String GetHeroProperName(JassUnit whichHero)
        {
            return Natives._GetHeroProperName(whichHero);
        }
        
        //native SuspendHeroXP takes unit whichHero, boolean flag returns nothing
        public delegate void SuspendHeroXPPrototype(JassUnit whichHero, JassBoolean flag);
        private static SuspendHeroXPPrototype _SuspendHeroXP;
        public static void SuspendHeroXP(JassUnit whichHero, Boolean flag)
        {
            Natives._SuspendHeroXP(whichHero, flag);
        }
        
        //native IsSuspendedXP takes unit whichHero returns boolean
        public delegate JassBoolean IsSuspendedXPPrototype(JassUnit whichHero);
        private static IsSuspendedXPPrototype _IsSuspendedXP;
        public static Boolean IsSuspendedXP(JassUnit whichHero)
        {
            return Natives._IsSuspendedXP(whichHero);
        }
        
        //native SelectHeroSkill takes unit whichHero, integer abilcode returns nothing
        public delegate void SelectHeroSkillPrototype(JassUnit whichHero, JassObjectId abilcode);
        private static SelectHeroSkillPrototype _SelectHeroSkill;
        public static void SelectHeroSkill(JassUnit whichHero, JassObjectId abilcode)
        {
            Natives._SelectHeroSkill(whichHero, abilcode);
        }
        
        //native GetUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        public delegate JassInteger GetUnitAbilityLevelPrototype(JassUnit whichUnit, JassObjectId abilcode);
        private static GetUnitAbilityLevelPrototype _GetUnitAbilityLevel;
        public static JassInteger GetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives._GetUnitAbilityLevel(whichUnit, abilcode);
        }
        
        //native DecUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        public delegate JassInteger DecUnitAbilityLevelPrototype(JassUnit whichUnit, JassObjectId abilcode);
        private static DecUnitAbilityLevelPrototype _DecUnitAbilityLevel;
        public static JassInteger DecUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives._DecUnitAbilityLevel(whichUnit, abilcode);
        }
        
        //native IncUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        public delegate JassInteger IncUnitAbilityLevelPrototype(JassUnit whichUnit, JassObjectId abilcode);
        private static IncUnitAbilityLevelPrototype _IncUnitAbilityLevel;
        public static JassInteger IncUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives._IncUnitAbilityLevel(whichUnit, abilcode);
        }
        
        //native SetUnitAbilityLevel takes unit whichUnit, integer abilcode, integer level returns integer
        public delegate JassInteger SetUnitAbilityLevelPrototype(JassUnit whichUnit, JassObjectId abilcode, JassInteger level);
        private static SetUnitAbilityLevelPrototype _SetUnitAbilityLevel;
        public static JassInteger SetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode, JassInteger level)
        {
            return Natives._SetUnitAbilityLevel(whichUnit, abilcode, level);
        }
        
        //native ReviveHero takes unit whichHero, real x, real y, boolean doEyecandy returns boolean
        public delegate JassBoolean ReviveHeroPrototype(JassUnit whichHero, JassRealArg x, JassRealArg y, JassBoolean doEyecandy);
        private static ReviveHeroPrototype _ReviveHero;
        public static Boolean ReviveHero(JassUnit whichHero, Single x, Single y, Boolean doEyecandy)
        {
            return Natives._ReviveHero(whichHero, x, y, doEyecandy);
        }
        
        //native ReviveHeroLoc takes unit whichHero, location loc, boolean doEyecandy returns boolean
        public delegate JassBoolean ReviveHeroLocPrototype(JassUnit whichHero, JassLocation loc, JassBoolean doEyecandy);
        private static ReviveHeroLocPrototype _ReviveHeroLoc;
        public static Boolean ReviveHeroLoc(JassUnit whichHero, JassLocation loc, Boolean doEyecandy)
        {
            return Natives._ReviveHeroLoc(whichHero, loc, doEyecandy);
        }
        
        //native SetUnitExploded takes unit whichUnit, boolean exploded returns nothing
        public delegate void SetUnitExplodedPrototype(JassUnit whichUnit, JassBoolean exploded);
        private static SetUnitExplodedPrototype _SetUnitExploded;
        public static void SetUnitExploded(JassUnit whichUnit, Boolean exploded)
        {
            Natives._SetUnitExploded(whichUnit, exploded);
        }
        
        //native SetUnitInvulnerable takes unit whichUnit, boolean flag returns nothing
        public delegate void SetUnitInvulnerablePrototype(JassUnit whichUnit, JassBoolean flag);
        private static SetUnitInvulnerablePrototype _SetUnitInvulnerable;
        public static void SetUnitInvulnerable(JassUnit whichUnit, Boolean flag)
        {
            Natives._SetUnitInvulnerable(whichUnit, flag);
        }
        
        //native PauseUnit takes unit whichUnit, boolean flag returns nothing
        public delegate void PauseUnitPrototype(JassUnit whichUnit, JassBoolean flag);
        private static PauseUnitPrototype _PauseUnit;
        public static void PauseUnit(JassUnit whichUnit, Boolean flag)
        {
            Natives._PauseUnit(whichUnit, flag);
        }
        
        //native IsUnitPaused takes unit whichHero returns boolean
        public delegate JassBoolean IsUnitPausedPrototype(JassUnit whichHero);
        private static IsUnitPausedPrototype _IsUnitPaused;
        public static Boolean IsUnitPaused(JassUnit whichHero)
        {
            return Natives._IsUnitPaused(whichHero);
        }
        
        //native SetUnitPathing takes unit whichUnit, boolean flag returns nothing
        public delegate void SetUnitPathingPrototype(JassUnit whichUnit, JassBoolean flag);
        private static SetUnitPathingPrototype _SetUnitPathing;
        public static void SetUnitPathing(JassUnit whichUnit, Boolean flag)
        {
            Natives._SetUnitPathing(whichUnit, flag);
        }
        
        //native ClearSelection takes nothing returns nothing
        public delegate void ClearSelectionPrototype();
        private static ClearSelectionPrototype _ClearSelection;
        public static void ClearSelection()
        {
            Natives._ClearSelection();
        }
        
        //native SelectUnit takes unit whichUnit, boolean flag returns nothing
        public delegate void SelectUnitPrototype(JassUnit whichUnit, JassBoolean flag);
        private static SelectUnitPrototype _SelectUnit;
        public static void SelectUnit(JassUnit whichUnit, Boolean flag)
        {
            Natives._SelectUnit(whichUnit, flag);
        }
        
        //native GetUnitPointValue takes unit whichUnit returns integer
        public delegate JassInteger GetUnitPointValuePrototype(JassUnit whichUnit);
        private static GetUnitPointValuePrototype _GetUnitPointValue;
        public static JassInteger GetUnitPointValue(JassUnit whichUnit)
        {
            return Natives._GetUnitPointValue(whichUnit);
        }
        
        //native GetUnitPointValueByType takes integer unitType returns integer
        public delegate JassInteger GetUnitPointValueByTypePrototype(JassInteger unitType);
        private static GetUnitPointValueByTypePrototype _GetUnitPointValueByType;
        public static JassInteger GetUnitPointValueByType(JassInteger unitType)
        {
            return Natives._GetUnitPointValueByType(unitType);
        }
        
        //native UnitAddItem takes unit whichUnit, item whichItem returns boolean
        public delegate JassBoolean UnitAddItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private static UnitAddItemPrototype _UnitAddItem;
        public static Boolean UnitAddItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives._UnitAddItem(whichUnit, whichItem);
        }
        
        //native UnitAddItemById takes unit whichUnit, integer itemId returns item
        public delegate JassItem UnitAddItemByIdPrototype(JassUnit whichUnit, JassObjectId itemId);
        private static UnitAddItemByIdPrototype _UnitAddItemById;
        public static JassItem UnitAddItemById(JassUnit whichUnit, JassObjectId itemId)
        {
            return Natives._UnitAddItemById(whichUnit, itemId);
        }
        
        //native UnitAddItemToSlotById takes unit whichUnit, integer itemId, integer itemSlot returns boolean
        public delegate JassBoolean UnitAddItemToSlotByIdPrototype(JassUnit whichUnit, JassObjectId itemId, JassInteger itemSlot);
        private static UnitAddItemToSlotByIdPrototype _UnitAddItemToSlotById;
        public static Boolean UnitAddItemToSlotById(JassUnit whichUnit, JassObjectId itemId, JassInteger itemSlot)
        {
            return Natives._UnitAddItemToSlotById(whichUnit, itemId, itemSlot);
        }
        
        //native UnitRemoveItem takes unit whichUnit, item whichItem returns nothing
        public delegate void UnitRemoveItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private static UnitRemoveItemPrototype _UnitRemoveItem;
        public static void UnitRemoveItem(JassUnit whichUnit, JassItem whichItem)
        {
            Natives._UnitRemoveItem(whichUnit, whichItem);
        }
        
        //native UnitRemoveItemFromSlot takes unit whichUnit, integer itemSlot returns item
        public delegate JassItem UnitRemoveItemFromSlotPrototype(JassUnit whichUnit, JassInteger itemSlot);
        private static UnitRemoveItemFromSlotPrototype _UnitRemoveItemFromSlot;
        public static JassItem UnitRemoveItemFromSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return Natives._UnitRemoveItemFromSlot(whichUnit, itemSlot);
        }
        
        //native UnitHasItem takes unit whichUnit, item whichItem returns boolean
        public delegate JassBoolean UnitHasItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private static UnitHasItemPrototype _UnitHasItem;
        public static Boolean UnitHasItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives._UnitHasItem(whichUnit, whichItem);
        }
        
        //native UnitItemInSlot takes unit whichUnit, integer itemSlot returns item
        public delegate JassItem UnitItemInSlotPrototype(JassUnit whichUnit, JassInteger itemSlot);
        private static UnitItemInSlotPrototype _UnitItemInSlot;
        public static JassItem UnitItemInSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return Natives._UnitItemInSlot(whichUnit, itemSlot);
        }
        
        //native UnitInventorySize takes unit whichUnit returns integer
        public delegate JassInteger UnitInventorySizePrototype(JassUnit whichUnit);
        private static UnitInventorySizePrototype _UnitInventorySize;
        public static JassInteger UnitInventorySize(JassUnit whichUnit)
        {
            return Natives._UnitInventorySize(whichUnit);
        }
        
        //native UnitDropItemPoint takes unit whichUnit, item whichItem, real x, real y returns boolean
        public delegate JassBoolean UnitDropItemPointPrototype(JassUnit whichUnit, JassItem whichItem, JassRealArg x, JassRealArg y);
        private static UnitDropItemPointPrototype _UnitDropItemPoint;
        public static Boolean UnitDropItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return Natives._UnitDropItemPoint(whichUnit, whichItem, x, y);
        }
        
        //native UnitDropItemSlot takes unit whichUnit, item whichItem, integer slot returns boolean
        public delegate JassBoolean UnitDropItemSlotPrototype(JassUnit whichUnit, JassItem whichItem, JassInteger slot);
        private static UnitDropItemSlotPrototype _UnitDropItemSlot;
        public static Boolean UnitDropItemSlot(JassUnit whichUnit, JassItem whichItem, JassInteger slot)
        {
            return Natives._UnitDropItemSlot(whichUnit, whichItem, slot);
        }
        
        //native UnitDropItemTarget takes unit whichUnit, item whichItem, widget target returns boolean
        public delegate JassBoolean UnitDropItemTargetPrototype(JassUnit whichUnit, JassItem whichItem, JassWidget target);
        private static UnitDropItemTargetPrototype _UnitDropItemTarget;
        public static Boolean UnitDropItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return Natives._UnitDropItemTarget(whichUnit, whichItem, target);
        }
        
        //native UnitUseItem takes unit whichUnit, item whichItem returns boolean
        public delegate JassBoolean UnitUseItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private static UnitUseItemPrototype _UnitUseItem;
        public static Boolean UnitUseItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives._UnitUseItem(whichUnit, whichItem);
        }
        
        //native UnitUseItemPoint takes unit whichUnit, item whichItem, real x, real y returns boolean
        public delegate JassBoolean UnitUseItemPointPrototype(JassUnit whichUnit, JassItem whichItem, JassRealArg x, JassRealArg y);
        private static UnitUseItemPointPrototype _UnitUseItemPoint;
        public static Boolean UnitUseItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return Natives._UnitUseItemPoint(whichUnit, whichItem, x, y);
        }
        
        //native UnitUseItemTarget takes unit whichUnit, item whichItem, widget target returns boolean
        public delegate JassBoolean UnitUseItemTargetPrototype(JassUnit whichUnit, JassItem whichItem, JassWidget target);
        private static UnitUseItemTargetPrototype _UnitUseItemTarget;
        public static Boolean UnitUseItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return Natives._UnitUseItemTarget(whichUnit, whichItem, target);
        }
        
        //native GetUnitX takes unit whichUnit returns real
        public delegate JassRealRet GetUnitXPrototype(JassUnit whichUnit);
        private static GetUnitXPrototype _GetUnitX;
        public static Single GetUnitX(JassUnit whichUnit)
        {
            return Natives._GetUnitX(whichUnit);
        }
        
        //native GetUnitY takes unit whichUnit returns real
        public delegate JassRealRet GetUnitYPrototype(JassUnit whichUnit);
        private static GetUnitYPrototype _GetUnitY;
        public static Single GetUnitY(JassUnit whichUnit)
        {
            return Natives._GetUnitY(whichUnit);
        }
        
        //native GetUnitLoc takes unit whichUnit returns location
        public delegate JassLocation GetUnitLocPrototype(JassUnit whichUnit);
        private static GetUnitLocPrototype _GetUnitLoc;
        public static JassLocation GetUnitLoc(JassUnit whichUnit)
        {
            return Natives._GetUnitLoc(whichUnit);
        }
        
        //native GetUnitFacing takes unit whichUnit returns real
        public delegate JassRealRet GetUnitFacingPrototype(JassUnit whichUnit);
        private static GetUnitFacingPrototype _GetUnitFacing;
        public static Single GetUnitFacing(JassUnit whichUnit)
        {
            return Natives._GetUnitFacing(whichUnit);
        }
        
        //native GetUnitMoveSpeed takes unit whichUnit returns real
        public delegate JassRealRet GetUnitMoveSpeedPrototype(JassUnit whichUnit);
        private static GetUnitMoveSpeedPrototype _GetUnitMoveSpeed;
        public static Single GetUnitMoveSpeed(JassUnit whichUnit)
        {
            return Natives._GetUnitMoveSpeed(whichUnit);
        }
        
        //native GetUnitDefaultMoveSpeed takes unit whichUnit returns real
        public delegate JassRealRet GetUnitDefaultMoveSpeedPrototype(JassUnit whichUnit);
        private static GetUnitDefaultMoveSpeedPrototype _GetUnitDefaultMoveSpeed;
        public static Single GetUnitDefaultMoveSpeed(JassUnit whichUnit)
        {
            return Natives._GetUnitDefaultMoveSpeed(whichUnit);
        }
        
        //native GetUnitState takes unit whichUnit, unitstate whichUnitState returns real
        public delegate JassRealRet GetUnitStatePrototype(JassUnit whichUnit, JassUnitState whichUnitState);
        private static GetUnitStatePrototype _GetUnitState;
        public static Single GetUnitState(JassUnit whichUnit, JassUnitState whichUnitState)
        {
            return Natives._GetUnitState(whichUnit, whichUnitState);
        }
        
        //native GetOwningPlayer takes unit whichUnit returns player
        public delegate JassPlayer GetOwningPlayerPrototype(JassUnit whichUnit);
        private static GetOwningPlayerPrototype _GetOwningPlayer;
        public static JassPlayer GetOwningPlayer(JassUnit whichUnit)
        {
            return Natives._GetOwningPlayer(whichUnit);
        }
        
        //native GetUnitTypeId takes unit whichUnit returns integer
        public delegate JassObjectId GetUnitTypeIdPrototype(JassUnit whichUnit);
        private static GetUnitTypeIdPrototype _GetUnitTypeId;
        public static JassObjectId GetUnitTypeId(JassUnit whichUnit)
        {
            return Natives._GetUnitTypeId(whichUnit);
        }
        
        //native GetUnitRace takes unit whichUnit returns race
        public delegate JassRace GetUnitRacePrototype(JassUnit whichUnit);
        private static GetUnitRacePrototype _GetUnitRace;
        public static JassRace GetUnitRace(JassUnit whichUnit)
        {
            return Natives._GetUnitRace(whichUnit);
        }
        
        //native GetUnitName takes unit whichUnit returns string
        public delegate JassStringRet GetUnitNamePrototype(JassUnit whichUnit);
        private static GetUnitNamePrototype _GetUnitName;
        public static String GetUnitName(JassUnit whichUnit)
        {
            return Natives._GetUnitName(whichUnit);
        }
        
        //native GetUnitFoodUsed takes unit whichUnit returns integer
        public delegate JassInteger GetUnitFoodUsedPrototype(JassUnit whichUnit);
        private static GetUnitFoodUsedPrototype _GetUnitFoodUsed;
        public static JassInteger GetUnitFoodUsed(JassUnit whichUnit)
        {
            return Natives._GetUnitFoodUsed(whichUnit);
        }
        
        //native GetUnitFoodMade takes unit whichUnit returns integer
        public delegate JassInteger GetUnitFoodMadePrototype(JassUnit whichUnit);
        private static GetUnitFoodMadePrototype _GetUnitFoodMade;
        public static JassInteger GetUnitFoodMade(JassUnit whichUnit)
        {
            return Natives._GetUnitFoodMade(whichUnit);
        }
        
        //native GetFoodMade takes integer unitId returns integer
        public delegate JassInteger GetFoodMadePrototype(JassObjectId unitId);
        private static GetFoodMadePrototype _GetFoodMade;
        public static JassInteger GetFoodMade(JassObjectId unitId)
        {
            return Natives._GetFoodMade(unitId);
        }
        
        //native GetFoodUsed takes integer unitId returns integer
        public delegate JassInteger GetFoodUsedPrototype(JassObjectId unitId);
        private static GetFoodUsedPrototype _GetFoodUsed;
        public static JassInteger GetFoodUsed(JassObjectId unitId)
        {
            return Natives._GetFoodUsed(unitId);
        }
        
        //native SetUnitUseFood takes unit whichUnit, boolean useFood returns nothing
        public delegate void SetUnitUseFoodPrototype(JassUnit whichUnit, JassBoolean useFood);
        private static SetUnitUseFoodPrototype _SetUnitUseFood;
        public static void SetUnitUseFood(JassUnit whichUnit, Boolean useFood)
        {
            Natives._SetUnitUseFood(whichUnit, useFood);
        }
        
        //native GetUnitRallyPoint takes unit whichUnit returns location
        public delegate JassLocation GetUnitRallyPointPrototype(JassUnit whichUnit);
        private static GetUnitRallyPointPrototype _GetUnitRallyPoint;
        public static JassLocation GetUnitRallyPoint(JassUnit whichUnit)
        {
            return Natives._GetUnitRallyPoint(whichUnit);
        }
        
        //native GetUnitRallyUnit takes unit whichUnit returns unit
        public delegate JassUnit GetUnitRallyUnitPrototype(JassUnit whichUnit);
        private static GetUnitRallyUnitPrototype _GetUnitRallyUnit;
        public static JassUnit GetUnitRallyUnit(JassUnit whichUnit)
        {
            return Natives._GetUnitRallyUnit(whichUnit);
        }
        
        //native GetUnitRallyDestructable takes unit whichUnit returns destructable
        public delegate JassDestructable GetUnitRallyDestructablePrototype(JassUnit whichUnit);
        private static GetUnitRallyDestructablePrototype _GetUnitRallyDestructable;
        public static JassDestructable GetUnitRallyDestructable(JassUnit whichUnit)
        {
            return Natives._GetUnitRallyDestructable(whichUnit);
        }
        
        //native IsUnitInGroup takes unit whichUnit, group whichGroup returns boolean
        public delegate JassBoolean IsUnitInGroupPrototype(JassUnit whichUnit, JassGroup whichGroup);
        private static IsUnitInGroupPrototype _IsUnitInGroup;
        public static Boolean IsUnitInGroup(JassUnit whichUnit, JassGroup whichGroup)
        {
            return Natives._IsUnitInGroup(whichUnit, whichGroup);
        }
        
        //native IsUnitInForce takes unit whichUnit, force whichForce returns boolean
        public delegate JassBoolean IsUnitInForcePrototype(JassUnit whichUnit, JassForce whichForce);
        private static IsUnitInForcePrototype _IsUnitInForce;
        public static Boolean IsUnitInForce(JassUnit whichUnit, JassForce whichForce)
        {
            return Natives._IsUnitInForce(whichUnit, whichForce);
        }
        
        //native IsUnitOwnedByPlayer takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitOwnedByPlayerPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitOwnedByPlayerPrototype _IsUnitOwnedByPlayer;
        public static Boolean IsUnitOwnedByPlayer(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitOwnedByPlayer(whichUnit, whichPlayer);
        }
        
        //native IsUnitAlly takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitAllyPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitAllyPrototype _IsUnitAlly;
        public static Boolean IsUnitAlly(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitAlly(whichUnit, whichPlayer);
        }
        
        //native IsUnitEnemy takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitEnemyPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitEnemyPrototype _IsUnitEnemy;
        public static Boolean IsUnitEnemy(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitEnemy(whichUnit, whichPlayer);
        }
        
        //native IsUnitVisible takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitVisiblePrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitVisiblePrototype _IsUnitVisible;
        public static Boolean IsUnitVisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitVisible(whichUnit, whichPlayer);
        }
        
        //native IsUnitDetected takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitDetectedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitDetectedPrototype _IsUnitDetected;
        public static Boolean IsUnitDetected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitDetected(whichUnit, whichPlayer);
        }
        
        //native IsUnitInvisible takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitInvisiblePrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitInvisiblePrototype _IsUnitInvisible;
        public static Boolean IsUnitInvisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitInvisible(whichUnit, whichPlayer);
        }
        
        //native IsUnitFogged takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitFoggedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitFoggedPrototype _IsUnitFogged;
        public static Boolean IsUnitFogged(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitFogged(whichUnit, whichPlayer);
        }
        
        //native IsUnitMasked takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitMaskedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitMaskedPrototype _IsUnitMasked;
        public static Boolean IsUnitMasked(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitMasked(whichUnit, whichPlayer);
        }
        
        //native IsUnitSelected takes unit whichUnit, player whichPlayer returns boolean
        public delegate JassBoolean IsUnitSelectedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private static IsUnitSelectedPrototype _IsUnitSelected;
        public static Boolean IsUnitSelected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives._IsUnitSelected(whichUnit, whichPlayer);
        }
        
        //native IsUnitRace takes unit whichUnit, race whichRace returns boolean
        public delegate JassBoolean IsUnitRacePrototype(JassUnit whichUnit, JassRace whichRace);
        private static IsUnitRacePrototype _IsUnitRace;
        public static Boolean IsUnitRace(JassUnit whichUnit, JassRace whichRace)
        {
            return Natives._IsUnitRace(whichUnit, whichRace);
        }
        
        //native IsUnitType takes unit whichUnit, unittype whichUnitType returns boolean
        public delegate JassBoolean IsUnitTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private static IsUnitTypePrototype _IsUnitType;
        public static Boolean IsUnitType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives._IsUnitType(whichUnit, whichUnitType);
        }
        
        //native IsUnit takes unit whichUnit, unit whichSpecifiedUnit returns boolean
        public delegate JassBoolean IsUnitPrototype(JassUnit whichUnit, JassUnit whichSpecifiedUnit);
        private static IsUnitPrototype _IsUnit;
        public static Boolean IsUnit(JassUnit whichUnit, JassUnit whichSpecifiedUnit)
        {
            return Natives._IsUnit(whichUnit, whichSpecifiedUnit);
        }
        
        //native IsUnitInRange takes unit whichUnit, unit otherUnit, real distance returns boolean
        public delegate JassBoolean IsUnitInRangePrototype(JassUnit whichUnit, JassUnit otherUnit, JassRealArg distance);
        private static IsUnitInRangePrototype _IsUnitInRange;
        public static Boolean IsUnitInRange(JassUnit whichUnit, JassUnit otherUnit, Single distance)
        {
            return Natives._IsUnitInRange(whichUnit, otherUnit, distance);
        }
        
        //native IsUnitInRangeXY takes unit whichUnit, real x, real y, real distance returns boolean
        public delegate JassBoolean IsUnitInRangeXYPrototype(JassUnit whichUnit, JassRealArg x, JassRealArg y, JassRealArg distance);
        private static IsUnitInRangeXYPrototype _IsUnitInRangeXY;
        public static Boolean IsUnitInRangeXY(JassUnit whichUnit, Single x, Single y, Single distance)
        {
            return Natives._IsUnitInRangeXY(whichUnit, x, y, distance);
        }
        
        //native IsUnitInRangeLoc takes unit whichUnit, location whichLocation, real distance returns boolean
        public delegate JassBoolean IsUnitInRangeLocPrototype(JassUnit whichUnit, JassLocation whichLocation, JassRealArg distance);
        private static IsUnitInRangeLocPrototype _IsUnitInRangeLoc;
        public static Boolean IsUnitInRangeLoc(JassUnit whichUnit, JassLocation whichLocation, Single distance)
        {
            return Natives._IsUnitInRangeLoc(whichUnit, whichLocation, distance);
        }
        
        //native IsUnitHidden takes unit whichUnit returns boolean
        public delegate JassBoolean IsUnitHiddenPrototype(JassUnit whichUnit);
        private static IsUnitHiddenPrototype _IsUnitHidden;
        public static Boolean IsUnitHidden(JassUnit whichUnit)
        {
            return Natives._IsUnitHidden(whichUnit);
        }
        
        //native IsUnitIllusion takes unit whichUnit returns boolean
        public delegate JassBoolean IsUnitIllusionPrototype(JassUnit whichUnit);
        private static IsUnitIllusionPrototype _IsUnitIllusion;
        public static Boolean IsUnitIllusion(JassUnit whichUnit)
        {
            return Natives._IsUnitIllusion(whichUnit);
        }
        
        //native IsUnitInTransport takes unit whichUnit, unit whichTransport returns boolean
        public delegate JassBoolean IsUnitInTransportPrototype(JassUnit whichUnit, JassUnit whichTransport);
        private static IsUnitInTransportPrototype _IsUnitInTransport;
        public static Boolean IsUnitInTransport(JassUnit whichUnit, JassUnit whichTransport)
        {
            return Natives._IsUnitInTransport(whichUnit, whichTransport);
        }
        
        //native IsUnitLoaded takes unit whichUnit returns boolean
        public delegate JassBoolean IsUnitLoadedPrototype(JassUnit whichUnit);
        private static IsUnitLoadedPrototype _IsUnitLoaded;
        public static Boolean IsUnitLoaded(JassUnit whichUnit)
        {
            return Natives._IsUnitLoaded(whichUnit);
        }
        
        //native IsHeroUnitId takes integer unitId returns boolean
        public delegate JassBoolean IsHeroUnitIdPrototype(JassObjectId unitId);
        private static IsHeroUnitIdPrototype _IsHeroUnitId;
        public static Boolean IsHeroUnitId(JassObjectId unitId)
        {
            return Natives._IsHeroUnitId(unitId);
        }
        
        //native IsUnitIdType takes integer unitId, unittype whichUnitType returns boolean
        public delegate JassBoolean IsUnitIdTypePrototype(JassObjectId unitId, JassUnitType whichUnitType);
        private static IsUnitIdTypePrototype _IsUnitIdType;
        public static Boolean IsUnitIdType(JassObjectId unitId, JassUnitType whichUnitType)
        {
            return Natives._IsUnitIdType(unitId, whichUnitType);
        }
        
        //native UnitShareVision takes unit whichUnit, player whichPlayer, boolean share returns nothing
        public delegate void UnitShareVisionPrototype(JassUnit whichUnit, JassPlayer whichPlayer, JassBoolean share);
        private static UnitShareVisionPrototype _UnitShareVision;
        public static void UnitShareVision(JassUnit whichUnit, JassPlayer whichPlayer, Boolean share)
        {
            Natives._UnitShareVision(whichUnit, whichPlayer, share);
        }
        
        //native UnitSuspendDecay takes unit whichUnit, boolean suspend returns nothing
        public delegate void UnitSuspendDecayPrototype(JassUnit whichUnit, JassBoolean suspend);
        private static UnitSuspendDecayPrototype _UnitSuspendDecay;
        public static void UnitSuspendDecay(JassUnit whichUnit, Boolean suspend)
        {
            Natives._UnitSuspendDecay(whichUnit, suspend);
        }
        
        //native UnitAddType takes unit whichUnit, unittype whichUnitType returns boolean
        public delegate JassBoolean UnitAddTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private static UnitAddTypePrototype _UnitAddType;
        public static Boolean UnitAddType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives._UnitAddType(whichUnit, whichUnitType);
        }
        
        //native UnitRemoveType takes unit whichUnit, unittype whichUnitType returns boolean
        public delegate JassBoolean UnitRemoveTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private static UnitRemoveTypePrototype _UnitRemoveType;
        public static Boolean UnitRemoveType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives._UnitRemoveType(whichUnit, whichUnitType);
        }
        
        //native UnitAddAbility takes unit whichUnit, integer abilityId returns boolean
        public delegate JassBoolean UnitAddAbilityPrototype(JassUnit whichUnit, JassInteger abilityId);
        private static UnitAddAbilityPrototype _UnitAddAbility;
        public static Boolean UnitAddAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return Natives._UnitAddAbility(whichUnit, abilityId);
        }
        
        //native UnitRemoveAbility takes unit whichUnit, integer abilityId returns boolean
        public delegate JassBoolean UnitRemoveAbilityPrototype(JassUnit whichUnit, JassInteger abilityId);
        private static UnitRemoveAbilityPrototype _UnitRemoveAbility;
        public static Boolean UnitRemoveAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return Natives._UnitRemoveAbility(whichUnit, abilityId);
        }
        
        //native UnitMakeAbilityPermanent takes unit whichUnit, boolean permanent, integer abilityId returns boolean
        public delegate JassBoolean UnitMakeAbilityPermanentPrototype(JassUnit whichUnit, JassBoolean permanent, JassInteger abilityId);
        private static UnitMakeAbilityPermanentPrototype _UnitMakeAbilityPermanent;
        public static Boolean UnitMakeAbilityPermanent(JassUnit whichUnit, Boolean permanent, JassInteger abilityId)
        {
            return Natives._UnitMakeAbilityPermanent(whichUnit, permanent, abilityId);
        }
        
        //native UnitRemoveBuffs takes unit whichUnit, boolean removePositive, boolean removeNegative returns nothing
        public delegate void UnitRemoveBuffsPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative);
        private static UnitRemoveBuffsPrototype _UnitRemoveBuffs;
        public static void UnitRemoveBuffs(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative)
        {
            Natives._UnitRemoveBuffs(whichUnit, removePositive, removeNegative);
        }
        
        //native UnitRemoveBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns nothing
        public delegate void UnitRemoveBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private static UnitRemoveBuffsExPrototype _UnitRemoveBuffsEx;
        public static void UnitRemoveBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            Natives._UnitRemoveBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        //native UnitHasBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns boolean
        public delegate JassBoolean UnitHasBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private static UnitHasBuffsExPrototype _UnitHasBuffsEx;
        public static Boolean UnitHasBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return Natives._UnitHasBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        //native UnitCountBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns integer
        public delegate JassInteger UnitCountBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private static UnitCountBuffsExPrototype _UnitCountBuffsEx;
        public static JassInteger UnitCountBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return Natives._UnitCountBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        //native UnitAddSleep takes unit whichUnit, boolean add returns nothing
        public delegate void UnitAddSleepPrototype(JassUnit whichUnit, JassBoolean add);
        private static UnitAddSleepPrototype _UnitAddSleep;
        public static void UnitAddSleep(JassUnit whichUnit, Boolean add)
        {
            Natives._UnitAddSleep(whichUnit, add);
        }
        
        //native UnitCanSleep takes unit whichUnit returns boolean
        public delegate JassBoolean UnitCanSleepPrototype(JassUnit whichUnit);
        private static UnitCanSleepPrototype _UnitCanSleep;
        public static Boolean UnitCanSleep(JassUnit whichUnit)
        {
            return Natives._UnitCanSleep(whichUnit);
        }
        
        //native UnitAddSleepPerm takes unit whichUnit, boolean add returns nothing
        public delegate void UnitAddSleepPermPrototype(JassUnit whichUnit, JassBoolean add);
        private static UnitAddSleepPermPrototype _UnitAddSleepPerm;
        public static void UnitAddSleepPerm(JassUnit whichUnit, Boolean add)
        {
            Natives._UnitAddSleepPerm(whichUnit, add);
        }
        
        //native UnitCanSleepPerm takes unit whichUnit returns boolean
        public delegate JassBoolean UnitCanSleepPermPrototype(JassUnit whichUnit);
        private static UnitCanSleepPermPrototype _UnitCanSleepPerm;
        public static Boolean UnitCanSleepPerm(JassUnit whichUnit)
        {
            return Natives._UnitCanSleepPerm(whichUnit);
        }
        
        //native UnitIsSleeping takes unit whichUnit returns boolean
        public delegate JassBoolean UnitIsSleepingPrototype(JassUnit whichUnit);
        private static UnitIsSleepingPrototype _UnitIsSleeping;
        public static Boolean UnitIsSleeping(JassUnit whichUnit)
        {
            return Natives._UnitIsSleeping(whichUnit);
        }
        
        //native UnitWakeUp takes unit whichUnit returns nothing
        public delegate void UnitWakeUpPrototype(JassUnit whichUnit);
        private static UnitWakeUpPrototype _UnitWakeUp;
        public static void UnitWakeUp(JassUnit whichUnit)
        {
            Natives._UnitWakeUp(whichUnit);
        }
        
        //native UnitApplyTimedLife takes unit whichUnit, integer buffId, real duration returns nothing
        public delegate void UnitApplyTimedLifePrototype(JassUnit whichUnit, JassInteger buffId, JassRealArg duration);
        private static UnitApplyTimedLifePrototype _UnitApplyTimedLife;
        public static void UnitApplyTimedLife(JassUnit whichUnit, JassInteger buffId, Single duration)
        {
            Natives._UnitApplyTimedLife(whichUnit, buffId, duration);
        }
        
        //native UnitIgnoreAlarm takes unit whichUnit, boolean flag returns boolean
        public delegate JassBoolean UnitIgnoreAlarmPrototype(JassUnit whichUnit, JassBoolean flag);
        private static UnitIgnoreAlarmPrototype _UnitIgnoreAlarm;
        public static Boolean UnitIgnoreAlarm(JassUnit whichUnit, Boolean flag)
        {
            return Natives._UnitIgnoreAlarm(whichUnit, flag);
        }
        
        //native UnitIgnoreAlarmToggled takes unit whichUnit returns boolean
        public delegate JassBoolean UnitIgnoreAlarmToggledPrototype(JassUnit whichUnit);
        private static UnitIgnoreAlarmToggledPrototype _UnitIgnoreAlarmToggled;
        public static Boolean UnitIgnoreAlarmToggled(JassUnit whichUnit)
        {
            return Natives._UnitIgnoreAlarmToggled(whichUnit);
        }
        
        //native UnitResetCooldown takes unit whichUnit returns nothing
        public delegate void UnitResetCooldownPrototype(JassUnit whichUnit);
        private static UnitResetCooldownPrototype _UnitResetCooldown;
        public static void UnitResetCooldown(JassUnit whichUnit)
        {
            Natives._UnitResetCooldown(whichUnit);
        }
        
        //native UnitSetConstructionProgress takes unit whichUnit, integer constructionPercentage returns nothing
        public delegate void UnitSetConstructionProgressPrototype(JassUnit whichUnit, JassInteger constructionPercentage);
        private static UnitSetConstructionProgressPrototype _UnitSetConstructionProgress;
        public static void UnitSetConstructionProgress(JassUnit whichUnit, JassInteger constructionPercentage)
        {
            Natives._UnitSetConstructionProgress(whichUnit, constructionPercentage);
        }
        
        //native UnitSetUpgradeProgress takes unit whichUnit, integer upgradePercentage returns nothing
        public delegate void UnitSetUpgradeProgressPrototype(JassUnit whichUnit, JassInteger upgradePercentage);
        private static UnitSetUpgradeProgressPrototype _UnitSetUpgradeProgress;
        public static void UnitSetUpgradeProgress(JassUnit whichUnit, JassInteger upgradePercentage)
        {
            Natives._UnitSetUpgradeProgress(whichUnit, upgradePercentage);
        }
        
        //native UnitPauseTimedLife takes unit whichUnit, boolean flag returns nothing
        public delegate void UnitPauseTimedLifePrototype(JassUnit whichUnit, JassBoolean flag);
        private static UnitPauseTimedLifePrototype _UnitPauseTimedLife;
        public static void UnitPauseTimedLife(JassUnit whichUnit, Boolean flag)
        {
            Natives._UnitPauseTimedLife(whichUnit, flag);
        }
        
        //native UnitSetUsesAltIcon takes unit whichUnit, boolean flag returns nothing
        public delegate void UnitSetUsesAltIconPrototype(JassUnit whichUnit, JassBoolean flag);
        private static UnitSetUsesAltIconPrototype _UnitSetUsesAltIcon;
        public static void UnitSetUsesAltIcon(JassUnit whichUnit, Boolean flag)
        {
            Natives._UnitSetUsesAltIcon(whichUnit, flag);
        }
        
        //native UnitDamagePoint takes unit whichUnit, real delay, real radius, real x, real y, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
        public delegate JassBoolean UnitDamagePointPrototype(JassUnit whichUnit, JassRealArg delay, JassRealArg radius, JassRealArg x, JassRealArg y, JassRealArg amount, JassBoolean attack, JassBoolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType);
        private static UnitDamagePointPrototype _UnitDamagePoint;
        public static Boolean UnitDamagePoint(JassUnit whichUnit, Single delay, Single radius, Single x, Single y, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return Natives._UnitDamagePoint(whichUnit, delay, radius, x, y, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        //native UnitDamageTarget takes unit whichUnit, widget target, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
        public delegate JassBoolean UnitDamageTargetPrototype(JassUnit whichUnit, JassWidget target, JassRealArg amount, JassBoolean attack, JassBoolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType);
        private static UnitDamageTargetPrototype _UnitDamageTarget;
        public static Boolean UnitDamageTarget(JassUnit whichUnit, JassWidget target, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return Natives._UnitDamageTarget(whichUnit, target, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        //native IssueImmediateOrder takes unit whichUnit, string order returns boolean
        public delegate JassBoolean IssueImmediateOrderPrototype(JassUnit whichUnit, JassStringArg order);
        private static IssueImmediateOrderPrototype _IssueImmediateOrder;
        public static Boolean IssueImmediateOrder(JassUnit whichUnit, String order)
        {
            return Natives._IssueImmediateOrder(whichUnit, order);
        }
        
        //native IssueImmediateOrderById takes unit whichUnit, integer order returns boolean
        public delegate JassBoolean IssueImmediateOrderByIdPrototype(JassUnit whichUnit, JassOrder order);
        private static IssueImmediateOrderByIdPrototype _IssueImmediateOrderById;
        public static Boolean IssueImmediateOrderById(JassUnit whichUnit, JassOrder order)
        {
            return Natives._IssueImmediateOrderById(whichUnit, order);
        }
        
        //native IssuePointOrder takes unit whichUnit, string order, real x, real y returns boolean
        public delegate JassBoolean IssuePointOrderPrototype(JassUnit whichUnit, JassStringArg order, JassRealArg x, JassRealArg y);
        private static IssuePointOrderPrototype _IssuePointOrder;
        public static Boolean IssuePointOrder(JassUnit whichUnit, String order, Single x, Single y)
        {
            return Natives._IssuePointOrder(whichUnit, order, x, y);
        }
        
        //native IssuePointOrderLoc takes unit whichUnit, string order, location whichLocation returns boolean
        public delegate JassBoolean IssuePointOrderLocPrototype(JassUnit whichUnit, JassStringArg order, JassLocation whichLocation);
        private static IssuePointOrderLocPrototype _IssuePointOrderLoc;
        public static Boolean IssuePointOrderLoc(JassUnit whichUnit, String order, JassLocation whichLocation)
        {
            return Natives._IssuePointOrderLoc(whichUnit, order, whichLocation);
        }
        
        //native IssuePointOrderById takes unit whichUnit, integer order, real x, real y returns boolean
        public delegate JassBoolean IssuePointOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassRealArg x, JassRealArg y);
        private static IssuePointOrderByIdPrototype _IssuePointOrderById;
        public static Boolean IssuePointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y)
        {
            return Natives._IssuePointOrderById(whichUnit, order, x, y);
        }
        
        //native IssuePointOrderByIdLoc takes unit whichUnit, integer order, location whichLocation returns boolean
        public delegate JassBoolean IssuePointOrderByIdLocPrototype(JassUnit whichUnit, JassOrder order, JassLocation whichLocation);
        private static IssuePointOrderByIdLocPrototype _IssuePointOrderByIdLoc;
        public static Boolean IssuePointOrderByIdLoc(JassUnit whichUnit, JassOrder order, JassLocation whichLocation)
        {
            return Natives._IssuePointOrderByIdLoc(whichUnit, order, whichLocation);
        }
        
        //native IssueTargetOrder takes unit whichUnit, string order, widget targetWidget returns boolean
        public delegate JassBoolean IssueTargetOrderPrototype(JassUnit whichUnit, JassStringArg order, JassWidget targetWidget);
        private static IssueTargetOrderPrototype _IssueTargetOrder;
        public static Boolean IssueTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget)
        {
            return Natives._IssueTargetOrder(whichUnit, order, targetWidget);
        }
        
        //native IssueTargetOrderById takes unit whichUnit, integer order, widget targetWidget returns boolean
        public delegate JassBoolean IssueTargetOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassWidget targetWidget);
        private static IssueTargetOrderByIdPrototype _IssueTargetOrderById;
        public static Boolean IssueTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget)
        {
            return Natives._IssueTargetOrderById(whichUnit, order, targetWidget);
        }
        
        //native IssueInstantPointOrder takes unit whichUnit, string order, real x, real y, widget instantTargetWidget returns boolean
        public delegate JassBoolean IssueInstantPointOrderPrototype(JassUnit whichUnit, JassStringArg order, JassRealArg x, JassRealArg y, JassWidget instantTargetWidget);
        private static IssueInstantPointOrderPrototype _IssueInstantPointOrder;
        public static Boolean IssueInstantPointOrder(JassUnit whichUnit, String order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return Natives._IssueInstantPointOrder(whichUnit, order, x, y, instantTargetWidget);
        }
        
        //native IssueInstantPointOrderById takes unit whichUnit, integer order, real x, real y, widget instantTargetWidget returns boolean
        public delegate JassBoolean IssueInstantPointOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassRealArg x, JassRealArg y, JassWidget instantTargetWidget);
        private static IssueInstantPointOrderByIdPrototype _IssueInstantPointOrderById;
        public static Boolean IssueInstantPointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return Natives._IssueInstantPointOrderById(whichUnit, order, x, y, instantTargetWidget);
        }
        
        //native IssueInstantTargetOrder takes unit whichUnit, string order, widget targetWidget, widget instantTargetWidget returns boolean
        public delegate JassBoolean IssueInstantTargetOrderPrototype(JassUnit whichUnit, JassStringArg order, JassWidget targetWidget, JassWidget instantTargetWidget);
        private static IssueInstantTargetOrderPrototype _IssueInstantTargetOrder;
        public static Boolean IssueInstantTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return Natives._IssueInstantTargetOrder(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        //native IssueInstantTargetOrderById takes unit whichUnit, integer order, widget targetWidget, widget instantTargetWidget returns boolean
        public delegate JassBoolean IssueInstantTargetOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget);
        private static IssueInstantTargetOrderByIdPrototype _IssueInstantTargetOrderById;
        public static Boolean IssueInstantTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return Natives._IssueInstantTargetOrderById(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        //native IssueBuildOrder takes unit whichPeon, string unitToBuild, real x, real y returns boolean
        public delegate JassBoolean IssueBuildOrderPrototype(JassUnit whichPeon, JassStringArg unitToBuild, JassRealArg x, JassRealArg y);
        private static IssueBuildOrderPrototype _IssueBuildOrder;
        public static Boolean IssueBuildOrder(JassUnit whichPeon, String unitToBuild, Single x, Single y)
        {
            return Natives._IssueBuildOrder(whichPeon, unitToBuild, x, y);
        }
        
        //native IssueBuildOrderById takes unit whichPeon, integer unitId, real x, real y returns boolean
        public delegate JassBoolean IssueBuildOrderByIdPrototype(JassUnit whichPeon, JassObjectId unitId, JassRealArg x, JassRealArg y);
        private static IssueBuildOrderByIdPrototype _IssueBuildOrderById;
        public static Boolean IssueBuildOrderById(JassUnit whichPeon, JassObjectId unitId, Single x, Single y)
        {
            return Natives._IssueBuildOrderById(whichPeon, unitId, x, y);
        }
        
        //native IssueNeutralImmediateOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild returns boolean
        public delegate JassBoolean IssueNeutralImmediateOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassStringArg unitToBuild);
        private static IssueNeutralImmediateOrderPrototype _IssueNeutralImmediateOrder;
        public static Boolean IssueNeutralImmediateOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild)
        {
            return Natives._IssueNeutralImmediateOrder(forWhichPlayer, neutralStructure, unitToBuild);
        }
        
        //native IssueNeutralImmediateOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId returns boolean
        public delegate JassBoolean IssueNeutralImmediateOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId);
        private static IssueNeutralImmediateOrderByIdPrototype _IssueNeutralImmediateOrderById;
        public static Boolean IssueNeutralImmediateOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId)
        {
            return Natives._IssueNeutralImmediateOrderById(forWhichPlayer, neutralStructure, unitId);
        }
        
        //native IssueNeutralPointOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild, real x, real y returns boolean
        public delegate JassBoolean IssueNeutralPointOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassStringArg unitToBuild, JassRealArg x, JassRealArg y);
        private static IssueNeutralPointOrderPrototype _IssueNeutralPointOrder;
        public static Boolean IssueNeutralPointOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, Single x, Single y)
        {
            return Natives._IssueNeutralPointOrder(forWhichPlayer, neutralStructure, unitToBuild, x, y);
        }
        
        //native IssueNeutralPointOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId, real x, real y returns boolean
        public delegate JassBoolean IssueNeutralPointOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassRealArg x, JassRealArg y);
        private static IssueNeutralPointOrderByIdPrototype _IssueNeutralPointOrderById;
        public static Boolean IssueNeutralPointOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, Single x, Single y)
        {
            return Natives._IssueNeutralPointOrderById(forWhichPlayer, neutralStructure, unitId, x, y);
        }
        
        //native IssueNeutralTargetOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild, widget target returns boolean
        public delegate JassBoolean IssueNeutralTargetOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassStringArg unitToBuild, JassWidget target);
        private static IssueNeutralTargetOrderPrototype _IssueNeutralTargetOrder;
        public static Boolean IssueNeutralTargetOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassWidget target)
        {
            return Natives._IssueNeutralTargetOrder(forWhichPlayer, neutralStructure, unitToBuild, target);
        }
        
        //native IssueNeutralTargetOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId, widget target returns boolean
        public delegate JassBoolean IssueNeutralTargetOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassWidget target);
        private static IssueNeutralTargetOrderByIdPrototype _IssueNeutralTargetOrderById;
        public static Boolean IssueNeutralTargetOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassWidget target)
        {
            return Natives._IssueNeutralTargetOrderById(forWhichPlayer, neutralStructure, unitId, target);
        }
        
        //native GetUnitCurrentOrder takes unit whichUnit returns integer
        public delegate JassInteger GetUnitCurrentOrderPrototype(JassUnit whichUnit);
        private static GetUnitCurrentOrderPrototype _GetUnitCurrentOrder;
        public static JassInteger GetUnitCurrentOrder(JassUnit whichUnit)
        {
            return Natives._GetUnitCurrentOrder(whichUnit);
        }
        
        //native SetResourceAmount takes unit whichUnit, integer amount returns nothing
        public delegate void SetResourceAmountPrototype(JassUnit whichUnit, JassInteger amount);
        private static SetResourceAmountPrototype _SetResourceAmount;
        public static void SetResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            Natives._SetResourceAmount(whichUnit, amount);
        }
        
        //native AddResourceAmount takes unit whichUnit, integer amount returns nothing
        public delegate void AddResourceAmountPrototype(JassUnit whichUnit, JassInteger amount);
        private static AddResourceAmountPrototype _AddResourceAmount;
        public static void AddResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            Natives._AddResourceAmount(whichUnit, amount);
        }
        
        //native GetResourceAmount takes unit whichUnit returns integer
        public delegate JassInteger GetResourceAmountPrototype(JassUnit whichUnit);
        private static GetResourceAmountPrototype _GetResourceAmount;
        public static JassInteger GetResourceAmount(JassUnit whichUnit)
        {
            return Natives._GetResourceAmount(whichUnit);
        }
        
        //native WaygateGetDestinationX takes unit waygate returns real
        public delegate JassRealRet WaygateGetDestinationXPrototype(JassUnit waygate);
        private static WaygateGetDestinationXPrototype _WaygateGetDestinationX;
        public static Single WaygateGetDestinationX(JassUnit waygate)
        {
            return Natives._WaygateGetDestinationX(waygate);
        }
        
        //native WaygateGetDestinationY takes unit waygate returns real
        public delegate JassRealRet WaygateGetDestinationYPrototype(JassUnit waygate);
        private static WaygateGetDestinationYPrototype _WaygateGetDestinationY;
        public static Single WaygateGetDestinationY(JassUnit waygate)
        {
            return Natives._WaygateGetDestinationY(waygate);
        }
        
        //native WaygateSetDestination takes unit waygate, real x, real y returns nothing
        public delegate void WaygateSetDestinationPrototype(JassUnit waygate, JassRealArg x, JassRealArg y);
        private static WaygateSetDestinationPrototype _WaygateSetDestination;
        public static void WaygateSetDestination(JassUnit waygate, Single x, Single y)
        {
            Natives._WaygateSetDestination(waygate, x, y);
        }
        
        //native WaygateActivate takes unit waygate, boolean activate returns nothing
        public delegate void WaygateActivatePrototype(JassUnit waygate, JassBoolean activate);
        private static WaygateActivatePrototype _WaygateActivate;
        public static void WaygateActivate(JassUnit waygate, Boolean activate)
        {
            Natives._WaygateActivate(waygate, activate);
        }
        
        //native WaygateIsActive takes unit waygate returns boolean
        public delegate JassBoolean WaygateIsActivePrototype(JassUnit waygate);
        private static WaygateIsActivePrototype _WaygateIsActive;
        public static Boolean WaygateIsActive(JassUnit waygate)
        {
            return Natives._WaygateIsActive(waygate);
        }
        
        //native AddItemToAllStock takes integer itemId, integer currentStock, integer stockMax returns nothing
        public delegate void AddItemToAllStockPrototype(JassObjectId itemId, JassInteger currentStock, JassInteger stockMax);
        private static AddItemToAllStockPrototype _AddItemToAllStock;
        public static void AddItemToAllStock(JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives._AddItemToAllStock(itemId, currentStock, stockMax);
        }
        
        //native AddItemToStock takes unit whichUnit, integer itemId, integer currentStock, integer stockMax returns nothing
        public delegate void AddItemToStockPrototype(JassUnit whichUnit, JassObjectId itemId, JassInteger currentStock, JassInteger stockMax);
        private static AddItemToStockPrototype _AddItemToStock;
        public static void AddItemToStock(JassUnit whichUnit, JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives._AddItemToStock(whichUnit, itemId, currentStock, stockMax);
        }
        
        //native AddUnitToAllStock takes integer unitId, integer currentStock, integer stockMax returns nothing
        public delegate void AddUnitToAllStockPrototype(JassObjectId unitId, JassInteger currentStock, JassInteger stockMax);
        private static AddUnitToAllStockPrototype _AddUnitToAllStock;
        public static void AddUnitToAllStock(JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives._AddUnitToAllStock(unitId, currentStock, stockMax);
        }
        
        //native AddUnitToStock takes unit whichUnit, integer unitId, integer currentStock, integer stockMax returns nothing
        public delegate void AddUnitToStockPrototype(JassUnit whichUnit, JassObjectId unitId, JassInteger currentStock, JassInteger stockMax);
        private static AddUnitToStockPrototype _AddUnitToStock;
        public static void AddUnitToStock(JassUnit whichUnit, JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives._AddUnitToStock(whichUnit, unitId, currentStock, stockMax);
        }
        
        //native RemoveItemFromAllStock takes integer itemId returns nothing
        public delegate void RemoveItemFromAllStockPrototype(JassObjectId itemId);
        private static RemoveItemFromAllStockPrototype _RemoveItemFromAllStock;
        public static void RemoveItemFromAllStock(JassObjectId itemId)
        {
            Natives._RemoveItemFromAllStock(itemId);
        }
        
        //native RemoveItemFromStock takes unit whichUnit, integer itemId returns nothing
        public delegate void RemoveItemFromStockPrototype(JassUnit whichUnit, JassObjectId itemId);
        private static RemoveItemFromStockPrototype _RemoveItemFromStock;
        public static void RemoveItemFromStock(JassUnit whichUnit, JassObjectId itemId)
        {
            Natives._RemoveItemFromStock(whichUnit, itemId);
        }
        
        //native RemoveUnitFromAllStock takes integer unitId returns nothing
        public delegate void RemoveUnitFromAllStockPrototype(JassObjectId unitId);
        private static RemoveUnitFromAllStockPrototype _RemoveUnitFromAllStock;
        public static void RemoveUnitFromAllStock(JassObjectId unitId)
        {
            Natives._RemoveUnitFromAllStock(unitId);
        }
        
        //native RemoveUnitFromStock takes unit whichUnit, integer unitId returns nothing
        public delegate void RemoveUnitFromStockPrototype(JassUnit whichUnit, JassObjectId unitId);
        private static RemoveUnitFromStockPrototype _RemoveUnitFromStock;
        public static void RemoveUnitFromStock(JassUnit whichUnit, JassObjectId unitId)
        {
            Natives._RemoveUnitFromStock(whichUnit, unitId);
        }
        
        //native SetAllItemTypeSlots takes integer slots returns nothing
        public delegate void SetAllItemTypeSlotsPrototype(JassInteger slots);
        private static SetAllItemTypeSlotsPrototype _SetAllItemTypeSlots;
        public static void SetAllItemTypeSlots(JassInteger slots)
        {
            Natives._SetAllItemTypeSlots(slots);
        }
        
        //native SetAllUnitTypeSlots takes integer slots returns nothing
        public delegate void SetAllUnitTypeSlotsPrototype(JassInteger slots);
        private static SetAllUnitTypeSlotsPrototype _SetAllUnitTypeSlots;
        public static void SetAllUnitTypeSlots(JassInteger slots)
        {
            Natives._SetAllUnitTypeSlots(slots);
        }
        
        //native SetItemTypeSlots takes unit whichUnit, integer slots returns nothing
        public delegate void SetItemTypeSlotsPrototype(JassUnit whichUnit, JassInteger slots);
        private static SetItemTypeSlotsPrototype _SetItemTypeSlots;
        public static void SetItemTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            Natives._SetItemTypeSlots(whichUnit, slots);
        }
        
        //native SetUnitTypeSlots takes unit whichUnit, integer slots returns nothing
        public delegate void SetUnitTypeSlotsPrototype(JassUnit whichUnit, JassInteger slots);
        private static SetUnitTypeSlotsPrototype _SetUnitTypeSlots;
        public static void SetUnitTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            Natives._SetUnitTypeSlots(whichUnit, slots);
        }
        
        //native GetUnitUserData takes unit whichUnit returns integer
        public delegate JassInteger GetUnitUserDataPrototype(JassUnit whichUnit);
        private static GetUnitUserDataPrototype _GetUnitUserData;
        public static JassInteger GetUnitUserData(JassUnit whichUnit)
        {
            return Natives._GetUnitUserData(whichUnit);
        }
        
        //native SetUnitUserData takes unit whichUnit, integer data returns nothing
        public delegate void SetUnitUserDataPrototype(JassUnit whichUnit, JassInteger data);
        private static SetUnitUserDataPrototype _SetUnitUserData;
        public static void SetUnitUserData(JassUnit whichUnit, JassInteger data)
        {
            Natives._SetUnitUserData(whichUnit, data);
        }
        
        //native Player takes integer number returns player
        public delegate JassPlayer PlayerPrototype(JassInteger number);
        private static PlayerPrototype _Player;
        public static JassPlayer Player(JassInteger number)
        {
            return Natives._Player(number);
        }
        
        //native GetLocalPlayer takes nothing returns player
        public delegate JassPlayer GetLocalPlayerPrototype();
        private static GetLocalPlayerPrototype _GetLocalPlayer;
        public static JassPlayer GetLocalPlayer()
        {
            return Natives._GetLocalPlayer();
        }
        
        //native IsPlayerAlly takes player whichPlayer, player otherPlayer returns boolean
        public delegate JassBoolean IsPlayerAllyPrototype(JassPlayer whichPlayer, JassPlayer otherPlayer);
        private static IsPlayerAllyPrototype _IsPlayerAlly;
        public static Boolean IsPlayerAlly(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return Natives._IsPlayerAlly(whichPlayer, otherPlayer);
        }
        
        //native IsPlayerEnemy takes player whichPlayer, player otherPlayer returns boolean
        public delegate JassBoolean IsPlayerEnemyPrototype(JassPlayer whichPlayer, JassPlayer otherPlayer);
        private static IsPlayerEnemyPrototype _IsPlayerEnemy;
        public static Boolean IsPlayerEnemy(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return Natives._IsPlayerEnemy(whichPlayer, otherPlayer);
        }
        
        //native IsPlayerInForce takes player whichPlayer, force whichForce returns boolean
        public delegate JassBoolean IsPlayerInForcePrototype(JassPlayer whichPlayer, JassForce whichForce);
        private static IsPlayerInForcePrototype _IsPlayerInForce;
        public static Boolean IsPlayerInForce(JassPlayer whichPlayer, JassForce whichForce)
        {
            return Natives._IsPlayerInForce(whichPlayer, whichForce);
        }
        
        //native IsPlayerObserver takes player whichPlayer returns boolean
        public delegate JassBoolean IsPlayerObserverPrototype(JassPlayer whichPlayer);
        private static IsPlayerObserverPrototype _IsPlayerObserver;
        public static Boolean IsPlayerObserver(JassPlayer whichPlayer)
        {
            return Natives._IsPlayerObserver(whichPlayer);
        }
        
        //native IsVisibleToPlayer takes real x, real y, player whichPlayer returns boolean
        public delegate JassBoolean IsVisibleToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private static IsVisibleToPlayerPrototype _IsVisibleToPlayer;
        public static Boolean IsVisibleToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives._IsVisibleToPlayer(x, y, whichPlayer);
        }
        
        //native IsLocationVisibleToPlayer takes location whichLocation, player whichPlayer returns boolean
        public delegate JassBoolean IsLocationVisibleToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private static IsLocationVisibleToPlayerPrototype _IsLocationVisibleToPlayer;
        public static Boolean IsLocationVisibleToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives._IsLocationVisibleToPlayer(whichLocation, whichPlayer);
        }
        
        //native IsFoggedToPlayer takes real x, real y, player whichPlayer returns boolean
        public delegate JassBoolean IsFoggedToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private static IsFoggedToPlayerPrototype _IsFoggedToPlayer;
        public static Boolean IsFoggedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives._IsFoggedToPlayer(x, y, whichPlayer);
        }
        
        //native IsLocationFoggedToPlayer takes location whichLocation, player whichPlayer returns boolean
        public delegate JassBoolean IsLocationFoggedToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private static IsLocationFoggedToPlayerPrototype _IsLocationFoggedToPlayer;
        public static Boolean IsLocationFoggedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives._IsLocationFoggedToPlayer(whichLocation, whichPlayer);
        }
        
        //native IsMaskedToPlayer takes real x, real y, player whichPlayer returns boolean
        public delegate JassBoolean IsMaskedToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private static IsMaskedToPlayerPrototype _IsMaskedToPlayer;
        public static Boolean IsMaskedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives._IsMaskedToPlayer(x, y, whichPlayer);
        }
        
        //native IsLocationMaskedToPlayer takes location whichLocation, player whichPlayer returns boolean
        public delegate JassBoolean IsLocationMaskedToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private static IsLocationMaskedToPlayerPrototype _IsLocationMaskedToPlayer;
        public static Boolean IsLocationMaskedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives._IsLocationMaskedToPlayer(whichLocation, whichPlayer);
        }
        
        //native GetPlayerRace takes player whichPlayer returns race
        public delegate JassRace GetPlayerRacePrototype(JassPlayer whichPlayer);
        private static GetPlayerRacePrototype _GetPlayerRace;
        public static JassRace GetPlayerRace(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerRace(whichPlayer);
        }
        
        //native GetPlayerId takes player whichPlayer returns integer
        public delegate JassInteger GetPlayerIdPrototype(JassPlayer whichPlayer);
        private static GetPlayerIdPrototype _GetPlayerId;
        public static JassInteger GetPlayerId(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerId(whichPlayer);
        }
        
        //native GetPlayerUnitCount takes player whichPlayer, boolean includeIncomplete returns integer
        public delegate JassInteger GetPlayerUnitCountPrototype(JassPlayer whichPlayer, JassBoolean includeIncomplete);
        private static GetPlayerUnitCountPrototype _GetPlayerUnitCount;
        public static JassInteger GetPlayerUnitCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return Natives._GetPlayerUnitCount(whichPlayer, includeIncomplete);
        }
        
        //native GetPlayerTypedUnitCount takes player whichPlayer, string unitName, boolean includeIncomplete, boolean includeUpgrades returns integer
        public delegate JassInteger GetPlayerTypedUnitCountPrototype(JassPlayer whichPlayer, JassStringArg unitName, JassBoolean includeIncomplete, JassBoolean includeUpgrades);
        private static GetPlayerTypedUnitCountPrototype _GetPlayerTypedUnitCount;
        public static JassInteger GetPlayerTypedUnitCount(JassPlayer whichPlayer, String unitName, Boolean includeIncomplete, Boolean includeUpgrades)
        {
            return Natives._GetPlayerTypedUnitCount(whichPlayer, unitName, includeIncomplete, includeUpgrades);
        }
        
        //native GetPlayerStructureCount takes player whichPlayer, boolean includeIncomplete returns integer
        public delegate JassInteger GetPlayerStructureCountPrototype(JassPlayer whichPlayer, JassBoolean includeIncomplete);
        private static GetPlayerStructureCountPrototype _GetPlayerStructureCount;
        public static JassInteger GetPlayerStructureCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return Natives._GetPlayerStructureCount(whichPlayer, includeIncomplete);
        }
        
        //native GetPlayerState takes player whichPlayer, playerstate whichPlayerState returns integer
        public delegate JassInteger GetPlayerStatePrototype(JassPlayer whichPlayer, JassPlayerState whichPlayerState);
        private static GetPlayerStatePrototype _GetPlayerState;
        public static JassInteger GetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState)
        {
            return Natives._GetPlayerState(whichPlayer, whichPlayerState);
        }
        
        //native GetPlayerScore takes player whichPlayer, playerscore whichPlayerScore returns integer
        public delegate JassInteger GetPlayerScorePrototype(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore);
        private static GetPlayerScorePrototype _GetPlayerScore;
        public static JassInteger GetPlayerScore(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore)
        {
            return Natives._GetPlayerScore(whichPlayer, whichPlayerScore);
        }
        
        //native GetPlayerAlliance takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting returns boolean
        public delegate JassBoolean GetPlayerAlliancePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting);
        private static GetPlayerAlliancePrototype _GetPlayerAlliance;
        public static Boolean GetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting)
        {
            return Natives._GetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting);
        }
        
        //native GetPlayerHandicap takes player whichPlayer returns real
        public delegate JassRealRet GetPlayerHandicapPrototype(JassPlayer whichPlayer);
        private static GetPlayerHandicapPrototype _GetPlayerHandicap;
        public static Single GetPlayerHandicap(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerHandicap(whichPlayer);
        }
        
        //native GetPlayerHandicapXP takes player whichPlayer returns real
        public delegate JassRealRet GetPlayerHandicapXPPrototype(JassPlayer whichPlayer);
        private static GetPlayerHandicapXPPrototype _GetPlayerHandicapXP;
        public static Single GetPlayerHandicapXP(JassPlayer whichPlayer)
        {
            return Natives._GetPlayerHandicapXP(whichPlayer);
        }
        
        //native SetPlayerHandicap takes player whichPlayer, real handicap returns nothing
        public delegate void SetPlayerHandicapPrototype(JassPlayer whichPlayer, JassRealArg handicap);
        private static SetPlayerHandicapPrototype _SetPlayerHandicap;
        public static void SetPlayerHandicap(JassPlayer whichPlayer, Single handicap)
        {
            Natives._SetPlayerHandicap(whichPlayer, handicap);
        }
        
        //native SetPlayerHandicapXP takes player whichPlayer, real handicap returns nothing
        public delegate void SetPlayerHandicapXPPrototype(JassPlayer whichPlayer, JassRealArg handicap);
        private static SetPlayerHandicapXPPrototype _SetPlayerHandicapXP;
        public static void SetPlayerHandicapXP(JassPlayer whichPlayer, Single handicap)
        {
            Natives._SetPlayerHandicapXP(whichPlayer, handicap);
        }
        
        //native SetPlayerTechMaxAllowed takes player whichPlayer, integer techid, integer maximum returns nothing
        public delegate void SetPlayerTechMaxAllowedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum);
        private static SetPlayerTechMaxAllowedPrototype _SetPlayerTechMaxAllowed;
        public static void SetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum)
        {
            Natives._SetPlayerTechMaxAllowed(whichPlayer, techid, maximum);
        }
        
        //native GetPlayerTechMaxAllowed takes player whichPlayer, integer techid returns integer
        public delegate JassInteger GetPlayerTechMaxAllowedPrototype(JassPlayer whichPlayer, JassInteger techid);
        private static GetPlayerTechMaxAllowedPrototype _GetPlayerTechMaxAllowed;
        public static JassInteger GetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid)
        {
            return Natives._GetPlayerTechMaxAllowed(whichPlayer, techid);
        }
        
        //native AddPlayerTechResearched takes player whichPlayer, integer techid, integer levels returns nothing
        public delegate void AddPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger levels);
        private static AddPlayerTechResearchedPrototype _AddPlayerTechResearched;
        public static void AddPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger levels)
        {
            Natives._AddPlayerTechResearched(whichPlayer, techid, levels);
        }
        
        //native SetPlayerTechResearched takes player whichPlayer, integer techid, integer setToLevel returns nothing
        public delegate void SetPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel);
        private static SetPlayerTechResearchedPrototype _SetPlayerTechResearched;
        public static void SetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel)
        {
            Natives._SetPlayerTechResearched(whichPlayer, techid, setToLevel);
        }
        
        //native GetPlayerTechResearched takes player whichPlayer, integer techid, boolean specificonly returns boolean
        public delegate JassBoolean GetPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassBoolean specificonly);
        private static GetPlayerTechResearchedPrototype _GetPlayerTechResearched;
        public static Boolean GetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return Natives._GetPlayerTechResearched(whichPlayer, techid, specificonly);
        }
        
        //native GetPlayerTechCount takes player whichPlayer, integer techid, boolean specificonly returns integer
        public delegate JassInteger GetPlayerTechCountPrototype(JassPlayer whichPlayer, JassInteger techid, JassBoolean specificonly);
        private static GetPlayerTechCountPrototype _GetPlayerTechCount;
        public static JassInteger GetPlayerTechCount(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return Natives._GetPlayerTechCount(whichPlayer, techid, specificonly);
        }
        
        //native SetPlayerUnitsOwner takes player whichPlayer, integer newOwner returns nothing
        public delegate void SetPlayerUnitsOwnerPrototype(JassPlayer whichPlayer, JassInteger newOwner);
        private static SetPlayerUnitsOwnerPrototype _SetPlayerUnitsOwner;
        public static void SetPlayerUnitsOwner(JassPlayer whichPlayer, JassInteger newOwner)
        {
            Natives._SetPlayerUnitsOwner(whichPlayer, newOwner);
        }
        
        //native CripplePlayer takes player whichPlayer, force toWhichPlayers, boolean flag returns nothing
        public delegate void CripplePlayerPrototype(JassPlayer whichPlayer, JassForce toWhichPlayers, JassBoolean flag);
        private static CripplePlayerPrototype _CripplePlayer;
        public static void CripplePlayer(JassPlayer whichPlayer, JassForce toWhichPlayers, Boolean flag)
        {
            Natives._CripplePlayer(whichPlayer, toWhichPlayers, flag);
        }
        
        //native SetPlayerAbilityAvailable takes player whichPlayer, integer abilid, boolean avail returns nothing
        public delegate void SetPlayerAbilityAvailablePrototype(JassPlayer whichPlayer, JassObjectId abilid, JassBoolean avail);
        private static SetPlayerAbilityAvailablePrototype _SetPlayerAbilityAvailable;
        public static void SetPlayerAbilityAvailable(JassPlayer whichPlayer, JassObjectId abilid, Boolean avail)
        {
            Natives._SetPlayerAbilityAvailable(whichPlayer, abilid, avail);
        }
        
        //native SetPlayerState takes player whichPlayer, playerstate whichPlayerState, integer value returns nothing
        public delegate void SetPlayerStatePrototype(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value);
        private static SetPlayerStatePrototype _SetPlayerState;
        public static void SetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value)
        {
            Natives._SetPlayerState(whichPlayer, whichPlayerState, value);
        }
        
        //native RemovePlayer takes player whichPlayer, playergameresult gameResult returns nothing
        public delegate void RemovePlayerPrototype(JassPlayer whichPlayer, JassPlayerGameResult gameResult);
        private static RemovePlayerPrototype _RemovePlayer;
        public static void RemovePlayer(JassPlayer whichPlayer, JassPlayerGameResult gameResult)
        {
            Natives._RemovePlayer(whichPlayer, gameResult);
        }
        
        //native CachePlayerHeroData takes player whichPlayer returns nothing
        public delegate void CachePlayerHeroDataPrototype(JassPlayer whichPlayer);
        private static CachePlayerHeroDataPrototype _CachePlayerHeroData;
        public static void CachePlayerHeroData(JassPlayer whichPlayer)
        {
            Natives._CachePlayerHeroData(whichPlayer);
        }
        
        //native SetFogStateRect takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision returns nothing
        public delegate void SetFogStateRectPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, JassBoolean useSharedVision);
        private static SetFogStateRectPrototype _SetFogStateRect;
        public static void SetFogStateRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision)
        {
            Natives._SetFogStateRect(forWhichPlayer, whichState, where, useSharedVision);
        }
        
        //native SetFogStateRadius takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision returns nothing
        public delegate void SetFogStateRadiusPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRealArg centerx, JassRealArg centerY, JassRealArg radius, JassBoolean useSharedVision);
        private static SetFogStateRadiusPrototype _SetFogStateRadius;
        public static void SetFogStateRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision)
        {
            Natives._SetFogStateRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision);
        }
        
        //native SetFogStateRadiusLoc takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision returns nothing
        public delegate void SetFogStateRadiusLocPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, JassRealArg radius, JassBoolean useSharedVision);
        private static SetFogStateRadiusLocPrototype _SetFogStateRadiusLoc;
        public static void SetFogStateRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision)
        {
            Natives._SetFogStateRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision);
        }
        
        //native FogMaskEnable takes boolean enable returns nothing
        public delegate void FogMaskEnablePrototype(JassBoolean enable);
        private static FogMaskEnablePrototype _FogMaskEnable;
        public static void FogMaskEnable(Boolean enable)
        {
            Natives._FogMaskEnable(enable);
        }
        
        //native IsFogMaskEnabled takes nothing returns boolean
        public delegate JassBoolean IsFogMaskEnabledPrototype();
        private static IsFogMaskEnabledPrototype _IsFogMaskEnabled;
        public static Boolean IsFogMaskEnabled()
        {
            return Natives._IsFogMaskEnabled();
        }
        
        //native FogEnable takes boolean enable returns nothing
        public delegate void FogEnablePrototype(JassBoolean enable);
        private static FogEnablePrototype _FogEnable;
        public static void FogEnable(Boolean enable)
        {
            Natives._FogEnable(enable);
        }
        
        //native IsFogEnabled takes nothing returns boolean
        public delegate JassBoolean IsFogEnabledPrototype();
        private static IsFogEnabledPrototype _IsFogEnabled;
        public static Boolean IsFogEnabled()
        {
            return Natives._IsFogEnabled();
        }
        
        //native CreateFogModifierRect takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision, boolean afterUnits returns fogmodifier
        public delegate JassFogModifier CreateFogModifierRectPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, JassBoolean useSharedVision, JassBoolean afterUnits);
        private static CreateFogModifierRectPrototype _CreateFogModifierRect;
        public static JassFogModifier CreateFogModifierRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives._CreateFogModifierRect(forWhichPlayer, whichState, where, useSharedVision, afterUnits);
        }
        
        //native CreateFogModifierRadius takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
        public delegate JassFogModifier CreateFogModifierRadiusPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRealArg centerx, JassRealArg centerY, JassRealArg radius, JassBoolean useSharedVision, JassBoolean afterUnits);
        private static CreateFogModifierRadiusPrototype _CreateFogModifierRadius;
        public static JassFogModifier CreateFogModifierRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives._CreateFogModifierRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision, afterUnits);
        }
        
        //native CreateFogModifierRadiusLoc takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
        public delegate JassFogModifier CreateFogModifierRadiusLocPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, JassRealArg radius, JassBoolean useSharedVision, JassBoolean afterUnits);
        private static CreateFogModifierRadiusLocPrototype _CreateFogModifierRadiusLoc;
        public static JassFogModifier CreateFogModifierRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives._CreateFogModifierRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision, afterUnits);
        }
        
        //native DestroyFogModifier takes fogmodifier whichFogModifier returns nothing
        public delegate void DestroyFogModifierPrototype(JassFogModifier whichFogModifier);
        private static DestroyFogModifierPrototype _DestroyFogModifier;
        public static void DestroyFogModifier(JassFogModifier whichFogModifier)
        {
            Natives._DestroyFogModifier(whichFogModifier);
        }
        
        //native FogModifierStart takes fogmodifier whichFogModifier returns nothing
        public delegate void FogModifierStartPrototype(JassFogModifier whichFogModifier);
        private static FogModifierStartPrototype _FogModifierStart;
        public static void FogModifierStart(JassFogModifier whichFogModifier)
        {
            Natives._FogModifierStart(whichFogModifier);
        }
        
        //native FogModifierStop takes fogmodifier whichFogModifier returns nothing
        public delegate void FogModifierStopPrototype(JassFogModifier whichFogModifier);
        private static FogModifierStopPrototype _FogModifierStop;
        public static void FogModifierStop(JassFogModifier whichFogModifier)
        {
            Natives._FogModifierStop(whichFogModifier);
        }
        
        //native VersionGet takes nothing returns version
        public delegate JassVersion VersionGetPrototype();
        private static VersionGetPrototype _VersionGet;
        public static JassVersion VersionGet()
        {
            return Natives._VersionGet();
        }
        
        //native VersionCompatible takes version whichVersion returns boolean
        public delegate JassBoolean VersionCompatiblePrototype(JassVersion whichVersion);
        private static VersionCompatiblePrototype _VersionCompatible;
        public static Boolean VersionCompatible(JassVersion whichVersion)
        {
            return Natives._VersionCompatible(whichVersion);
        }
        
        //native VersionSupported takes version whichVersion returns boolean
        public delegate JassBoolean VersionSupportedPrototype(JassVersion whichVersion);
        private static VersionSupportedPrototype _VersionSupported;
        public static Boolean VersionSupported(JassVersion whichVersion)
        {
            return Natives._VersionSupported(whichVersion);
        }
        
        //native EndGame takes boolean doScoreScreen returns nothing
        public delegate void EndGamePrototype(JassBoolean doScoreScreen);
        private static EndGamePrototype _EndGame;
        public static void EndGame(Boolean doScoreScreen)
        {
            Natives._EndGame(doScoreScreen);
        }
        
        //native ChangeLevel takes string newLevel, boolean doScoreScreen returns nothing
        public delegate void ChangeLevelPrototype(JassStringArg newLevel, JassBoolean doScoreScreen);
        private static ChangeLevelPrototype _ChangeLevel;
        public static void ChangeLevel(String newLevel, Boolean doScoreScreen)
        {
            Natives._ChangeLevel(newLevel, doScoreScreen);
        }
        
        //native RestartGame takes boolean doScoreScreen returns nothing
        public delegate void RestartGamePrototype(JassBoolean doScoreScreen);
        private static RestartGamePrototype _RestartGame;
        public static void RestartGame(Boolean doScoreScreen)
        {
            Natives._RestartGame(doScoreScreen);
        }
        
        //native ReloadGame takes nothing returns nothing
        public delegate void ReloadGamePrototype();
        private static ReloadGamePrototype _ReloadGame;
        public static void ReloadGame()
        {
            Natives._ReloadGame();
        }
        
        //native SetCampaignMenuRace takes race r returns nothing
        public delegate void SetCampaignMenuRacePrototype(JassRace r);
        private static SetCampaignMenuRacePrototype _SetCampaignMenuRace;
        public static void SetCampaignMenuRace(JassRace r)
        {
            Natives._SetCampaignMenuRace(r);
        }
        
        //native SetCampaignMenuRaceEx takes integer campaignIndex returns nothing
        public delegate void SetCampaignMenuRaceExPrototype(JassInteger campaignIndex);
        private static SetCampaignMenuRaceExPrototype _SetCampaignMenuRaceEx;
        public static void SetCampaignMenuRaceEx(JassInteger campaignIndex)
        {
            Natives._SetCampaignMenuRaceEx(campaignIndex);
        }
        
        //native ForceCampaignSelectScreen takes nothing returns nothing
        public delegate void ForceCampaignSelectScreenPrototype();
        private static ForceCampaignSelectScreenPrototype _ForceCampaignSelectScreen;
        public static void ForceCampaignSelectScreen()
        {
            Natives._ForceCampaignSelectScreen();
        }
        
        //native LoadGame takes string saveFileName, boolean doScoreScreen returns nothing
        public delegate void LoadGamePrototype(JassStringArg saveFileName, JassBoolean doScoreScreen);
        private static LoadGamePrototype _LoadGame;
        public static void LoadGame(String saveFileName, Boolean doScoreScreen)
        {
            Natives._LoadGame(saveFileName, doScoreScreen);
        }
        
        //native SaveGame takes string saveFileName returns nothing
        public delegate void SaveGamePrototype(JassStringArg saveFileName);
        private static SaveGamePrototype _SaveGame;
        public static void SaveGame(String saveFileName)
        {
            Natives._SaveGame(saveFileName);
        }
        
        //native RenameSaveDirectory takes string sourceDirName, string destDirName returns boolean
        public delegate JassBoolean RenameSaveDirectoryPrototype(JassStringArg sourceDirName, JassStringArg destDirName);
        private static RenameSaveDirectoryPrototype _RenameSaveDirectory;
        public static Boolean RenameSaveDirectory(String sourceDirName, String destDirName)
        {
            return Natives._RenameSaveDirectory(sourceDirName, destDirName);
        }
        
        //native RemoveSaveDirectory takes string sourceDirName returns boolean
        public delegate JassBoolean RemoveSaveDirectoryPrototype(JassStringArg sourceDirName);
        private static RemoveSaveDirectoryPrototype _RemoveSaveDirectory;
        public static Boolean RemoveSaveDirectory(String sourceDirName)
        {
            return Natives._RemoveSaveDirectory(sourceDirName);
        }
        
        //native CopySaveGame takes string sourceSaveName, string destSaveName returns boolean
        public delegate JassBoolean CopySaveGamePrototype(JassStringArg sourceSaveName, JassStringArg destSaveName);
        private static CopySaveGamePrototype _CopySaveGame;
        public static Boolean CopySaveGame(String sourceSaveName, String destSaveName)
        {
            return Natives._CopySaveGame(sourceSaveName, destSaveName);
        }
        
        //native SaveGameExists takes string saveName returns boolean
        public delegate JassBoolean SaveGameExistsPrototype(JassStringArg saveName);
        private static SaveGameExistsPrototype _SaveGameExists;
        public static Boolean SaveGameExists(String saveName)
        {
            return Natives._SaveGameExists(saveName);
        }
        
        //native SyncSelections takes nothing returns nothing
        public delegate void SyncSelectionsPrototype();
        private static SyncSelectionsPrototype _SyncSelections;
        public static void SyncSelections()
        {
            Natives._SyncSelections();
        }
        
        //native SetFloatGameState takes fgamestate whichFloatGameState, real value returns nothing
        public delegate void SetFloatGameStatePrototype(JassFGameState whichFloatGameState, JassRealArg value);
        private static SetFloatGameStatePrototype _SetFloatGameState;
        public static void SetFloatGameState(JassFGameState whichFloatGameState, Single value)
        {
            Natives._SetFloatGameState(whichFloatGameState, value);
        }
        
        //native GetFloatGameState takes fgamestate whichFloatGameState returns real
        public delegate JassRealRet GetFloatGameStatePrototype(JassFGameState whichFloatGameState);
        private static GetFloatGameStatePrototype _GetFloatGameState;
        public static Single GetFloatGameState(JassFGameState whichFloatGameState)
        {
            return Natives._GetFloatGameState(whichFloatGameState);
        }
        
        //native SetIntegerGameState takes igamestate whichIntegerGameState, integer value returns nothing
        public delegate void SetIntegerGameStatePrototype(JassIGameState whichIntegerGameState, JassInteger value);
        private static SetIntegerGameStatePrototype _SetIntegerGameState;
        public static void SetIntegerGameState(JassIGameState whichIntegerGameState, JassInteger value)
        {
            Natives._SetIntegerGameState(whichIntegerGameState, value);
        }
        
        //native GetIntegerGameState takes igamestate whichIntegerGameState returns integer
        public delegate JassInteger GetIntegerGameStatePrototype(JassIGameState whichIntegerGameState);
        private static GetIntegerGameStatePrototype _GetIntegerGameState;
        public static JassInteger GetIntegerGameState(JassIGameState whichIntegerGameState)
        {
            return Natives._GetIntegerGameState(whichIntegerGameState);
        }
        
        //native SetTutorialCleared takes boolean cleared returns nothing
        public delegate void SetTutorialClearedPrototype(JassBoolean cleared);
        private static SetTutorialClearedPrototype _SetTutorialCleared;
        public static void SetTutorialCleared(Boolean cleared)
        {
            Natives._SetTutorialCleared(cleared);
        }
        
        //native SetMissionAvailable takes integer campaignNumber, integer missionNumber, boolean available returns nothing
        public delegate void SetMissionAvailablePrototype(JassInteger campaignNumber, JassInteger missionNumber, JassBoolean available);
        private static SetMissionAvailablePrototype _SetMissionAvailable;
        public static void SetMissionAvailable(JassInteger campaignNumber, JassInteger missionNumber, Boolean available)
        {
            Natives._SetMissionAvailable(campaignNumber, missionNumber, available);
        }
        
        //native SetCampaignAvailable takes integer campaignNumber, boolean available returns nothing
        public delegate void SetCampaignAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private static SetCampaignAvailablePrototype _SetCampaignAvailable;
        public static void SetCampaignAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives._SetCampaignAvailable(campaignNumber, available);
        }
        
        //native SetOpCinematicAvailable takes integer campaignNumber, boolean available returns nothing
        public delegate void SetOpCinematicAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private static SetOpCinematicAvailablePrototype _SetOpCinematicAvailable;
        public static void SetOpCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives._SetOpCinematicAvailable(campaignNumber, available);
        }
        
        //native SetEdCinematicAvailable takes integer campaignNumber, boolean available returns nothing
        public delegate void SetEdCinematicAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private static SetEdCinematicAvailablePrototype _SetEdCinematicAvailable;
        public static void SetEdCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives._SetEdCinematicAvailable(campaignNumber, available);
        }
        
        //native GetDefaultDifficulty takes nothing returns gamedifficulty
        public delegate JassGameDifficulty GetDefaultDifficultyPrototype();
        private static GetDefaultDifficultyPrototype _GetDefaultDifficulty;
        public static JassGameDifficulty GetDefaultDifficulty()
        {
            return Natives._GetDefaultDifficulty();
        }
        
        //native SetDefaultDifficulty takes gamedifficulty g returns nothing
        public delegate void SetDefaultDifficultyPrototype(JassGameDifficulty g);
        private static SetDefaultDifficultyPrototype _SetDefaultDifficulty;
        public static void SetDefaultDifficulty(JassGameDifficulty g)
        {
            Natives._SetDefaultDifficulty(g);
        }
        
        //native SetCustomCampaignButtonVisible takes integer whichButton, boolean visible returns nothing
        public delegate void SetCustomCampaignButtonVisiblePrototype(JassInteger whichButton, JassBoolean visible);
        private static SetCustomCampaignButtonVisiblePrototype _SetCustomCampaignButtonVisible;
        public static void SetCustomCampaignButtonVisible(JassInteger whichButton, Boolean visible)
        {
            Natives._SetCustomCampaignButtonVisible(whichButton, visible);
        }
        
        //native GetCustomCampaignButtonVisible takes integer whichButton returns boolean
        public delegate JassBoolean GetCustomCampaignButtonVisiblePrototype(JassInteger whichButton);
        private static GetCustomCampaignButtonVisiblePrototype _GetCustomCampaignButtonVisible;
        public static Boolean GetCustomCampaignButtonVisible(JassInteger whichButton)
        {
            return Natives._GetCustomCampaignButtonVisible(whichButton);
        }
        
        //native DoNotSaveReplay takes nothing returns nothing
        public delegate void DoNotSaveReplayPrototype();
        private static DoNotSaveReplayPrototype _DoNotSaveReplay;
        public static void DoNotSaveReplay()
        {
            Natives._DoNotSaveReplay();
        }
        
        //native DialogCreate takes nothing returns dialog
        public delegate JassDialog DialogCreatePrototype();
        private static DialogCreatePrototype _DialogCreate;
        public static JassDialog DialogCreate()
        {
            return Natives._DialogCreate();
        }
        
        //native DialogDestroy takes dialog whichDialog returns nothing
        public delegate void DialogDestroyPrototype(JassDialog whichDialog);
        private static DialogDestroyPrototype _DialogDestroy;
        public static void DialogDestroy(JassDialog whichDialog)
        {
            Natives._DialogDestroy(whichDialog);
        }
        
        //native DialogClear takes dialog whichDialog returns nothing
        public delegate void DialogClearPrototype(JassDialog whichDialog);
        private static DialogClearPrototype _DialogClear;
        public static void DialogClear(JassDialog whichDialog)
        {
            Natives._DialogClear(whichDialog);
        }
        
        //native DialogSetMessage takes dialog whichDialog, string messageText returns nothing
        public delegate void DialogSetMessagePrototype(JassDialog whichDialog, JassStringArg messageText);
        private static DialogSetMessagePrototype _DialogSetMessage;
        public static void DialogSetMessage(JassDialog whichDialog, String messageText)
        {
            Natives._DialogSetMessage(whichDialog, messageText);
        }
        
        //native DialogAddButton takes dialog whichDialog, string buttonText, integer hotkey returns button
        public delegate JassButton DialogAddButtonPrototype(JassDialog whichDialog, JassStringArg buttonText, JassInteger hotkey);
        private static DialogAddButtonPrototype _DialogAddButton;
        public static JassButton DialogAddButton(JassDialog whichDialog, String buttonText, JassInteger hotkey)
        {
            return Natives._DialogAddButton(whichDialog, buttonText, hotkey);
        }
        
        //native DialogAddQuitButton takes dialog whichDialog, boolean doScoreScreen, string buttonText, integer hotkey returns button
        public delegate JassButton DialogAddQuitButtonPrototype(JassDialog whichDialog, JassBoolean doScoreScreen, JassStringArg buttonText, JassInteger hotkey);
        private static DialogAddQuitButtonPrototype _DialogAddQuitButton;
        public static JassButton DialogAddQuitButton(JassDialog whichDialog, Boolean doScoreScreen, String buttonText, JassInteger hotkey)
        {
            return Natives._DialogAddQuitButton(whichDialog, doScoreScreen, buttonText, hotkey);
        }
        
        //native DialogDisplay takes player whichPlayer, dialog whichDialog, boolean flag returns nothing
        public delegate void DialogDisplayPrototype(JassPlayer whichPlayer, JassDialog whichDialog, JassBoolean flag);
        private static DialogDisplayPrototype _DialogDisplay;
        public static void DialogDisplay(JassPlayer whichPlayer, JassDialog whichDialog, Boolean flag)
        {
            Natives._DialogDisplay(whichPlayer, whichDialog, flag);
        }
        
        //native ReloadGameCachesFromDisk takes nothing returns boolean
        public delegate JassBoolean ReloadGameCachesFromDiskPrototype();
        private static ReloadGameCachesFromDiskPrototype _ReloadGameCachesFromDisk;
        public static Boolean ReloadGameCachesFromDisk()
        {
            return Natives._ReloadGameCachesFromDisk();
        }
        
        //native InitGameCache takes string campaignFile returns gamecache
        public delegate JassGameCache InitGameCachePrototype(JassStringArg campaignFile);
        private static InitGameCachePrototype _InitGameCache;
        public static JassGameCache InitGameCache(String campaignFile)
        {
            return Natives._InitGameCache(campaignFile);
        }
        
        //native SaveGameCache takes gamecache whichCache returns boolean
        public delegate JassBoolean SaveGameCachePrototype(JassGameCache whichCache);
        private static SaveGameCachePrototype _SaveGameCache;
        public static Boolean SaveGameCache(JassGameCache whichCache)
        {
            return Natives._SaveGameCache(whichCache);
        }
        
        //native StoreInteger takes gamecache cache, string missionKey, string key, integer value returns nothing
        public delegate void StoreIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassInteger value);
        private static StoreIntegerPrototype _StoreInteger;
        public static void StoreInteger(JassGameCache cache, String missionKey, String key, JassInteger value)
        {
            Natives._StoreInteger(cache, missionKey, key, value);
        }
        
        //native StoreReal takes gamecache cache, string missionKey, string key, real value returns nothing
        public delegate void StoreRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassRealArg value);
        private static StoreRealPrototype _StoreReal;
        public static void StoreReal(JassGameCache cache, String missionKey, String key, Single value)
        {
            Natives._StoreReal(cache, missionKey, key, value);
        }
        
        //native StoreBoolean takes gamecache cache, string missionKey, string key, boolean value returns nothing
        public delegate void StoreBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassBoolean value);
        private static StoreBooleanPrototype _StoreBoolean;
        public static void StoreBoolean(JassGameCache cache, String missionKey, String key, Boolean value)
        {
            Natives._StoreBoolean(cache, missionKey, key, value);
        }
        
        //native StoreUnit takes gamecache cache, string missionKey, string key, unit whichUnit returns boolean
        public delegate JassBoolean StoreUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassUnit whichUnit);
        private static StoreUnitPrototype _StoreUnit;
        public static Boolean StoreUnit(JassGameCache cache, String missionKey, String key, JassUnit whichUnit)
        {
            return Natives._StoreUnit(cache, missionKey, key, whichUnit);
        }
        
        //native StoreString takes gamecache cache, string missionKey, string key, string value returns boolean
        public delegate JassBoolean StoreStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassStringArg value);
        private static StoreStringPrototype _StoreString;
        public static Boolean StoreString(JassGameCache cache, String missionKey, String key, String value)
        {
            return Natives._StoreString(cache, missionKey, key, value);
        }
        
        //native SyncStoredInteger takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static SyncStoredIntegerPrototype _SyncStoredInteger;
        public static void SyncStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            Natives._SyncStoredInteger(cache, missionKey, key);
        }
        
        //native SyncStoredReal takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static SyncStoredRealPrototype _SyncStoredReal;
        public static void SyncStoredReal(JassGameCache cache, String missionKey, String key)
        {
            Natives._SyncStoredReal(cache, missionKey, key);
        }
        
        //native SyncStoredBoolean takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static SyncStoredBooleanPrototype _SyncStoredBoolean;
        public static void SyncStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            Natives._SyncStoredBoolean(cache, missionKey, key);
        }
        
        //native SyncStoredUnit takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static SyncStoredUnitPrototype _SyncStoredUnit;
        public static void SyncStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            Natives._SyncStoredUnit(cache, missionKey, key);
        }
        
        //native SyncStoredString takes gamecache cache, string missionKey, string key returns nothing
        public delegate void SyncStoredStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static SyncStoredStringPrototype _SyncStoredString;
        public static void SyncStoredString(JassGameCache cache, String missionKey, String key)
        {
            Natives._SyncStoredString(cache, missionKey, key);
        }
        
        //native HaveStoredInteger takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static HaveStoredIntegerPrototype _HaveStoredInteger;
        public static Boolean HaveStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return Natives._HaveStoredInteger(cache, missionKey, key);
        }
        
        //native HaveStoredReal takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static HaveStoredRealPrototype _HaveStoredReal;
        public static Boolean HaveStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return Natives._HaveStoredReal(cache, missionKey, key);
        }
        
        //native HaveStoredBoolean takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static HaveStoredBooleanPrototype _HaveStoredBoolean;
        public static Boolean HaveStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return Natives._HaveStoredBoolean(cache, missionKey, key);
        }
        
        //native HaveStoredUnit takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static HaveStoredUnitPrototype _HaveStoredUnit;
        public static Boolean HaveStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            return Natives._HaveStoredUnit(cache, missionKey, key);
        }
        
        //native HaveStoredString takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean HaveStoredStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static HaveStoredStringPrototype _HaveStoredString;
        public static Boolean HaveStoredString(JassGameCache cache, String missionKey, String key)
        {
            return Natives._HaveStoredString(cache, missionKey, key);
        }
        
        //native FlushGameCache takes gamecache cache returns nothing
        public delegate void FlushGameCachePrototype(JassGameCache cache);
        private static FlushGameCachePrototype _FlushGameCache;
        public static void FlushGameCache(JassGameCache cache)
        {
            Natives._FlushGameCache(cache);
        }
        
        //native FlushStoredMission takes gamecache cache, string missionKey returns nothing
        public delegate void FlushStoredMissionPrototype(JassGameCache cache, JassStringArg missionKey);
        private static FlushStoredMissionPrototype _FlushStoredMission;
        public static void FlushStoredMission(JassGameCache cache, String missionKey)
        {
            Natives._FlushStoredMission(cache, missionKey);
        }
        
        //native FlushStoredInteger takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static FlushStoredIntegerPrototype _FlushStoredInteger;
        public static void FlushStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            Natives._FlushStoredInteger(cache, missionKey, key);
        }
        
        //native FlushStoredReal takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static FlushStoredRealPrototype _FlushStoredReal;
        public static void FlushStoredReal(JassGameCache cache, String missionKey, String key)
        {
            Natives._FlushStoredReal(cache, missionKey, key);
        }
        
        //native FlushStoredBoolean takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static FlushStoredBooleanPrototype _FlushStoredBoolean;
        public static void FlushStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            Natives._FlushStoredBoolean(cache, missionKey, key);
        }
        
        //native FlushStoredUnit takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static FlushStoredUnitPrototype _FlushStoredUnit;
        public static void FlushStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            Natives._FlushStoredUnit(cache, missionKey, key);
        }
        
        //native FlushStoredString takes gamecache cache, string missionKey, string key returns nothing
        public delegate void FlushStoredStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static FlushStoredStringPrototype _FlushStoredString;
        public static void FlushStoredString(JassGameCache cache, String missionKey, String key)
        {
            Natives._FlushStoredString(cache, missionKey, key);
        }
        
        //native GetStoredInteger takes gamecache cache, string missionKey, string key returns integer
        public delegate JassInteger GetStoredIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static GetStoredIntegerPrototype _GetStoredInteger;
        public static JassInteger GetStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return Natives._GetStoredInteger(cache, missionKey, key);
        }
        
        //native GetStoredReal takes gamecache cache, string missionKey, string key returns real
        public delegate JassRealRet GetStoredRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static GetStoredRealPrototype _GetStoredReal;
        public static Single GetStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return Natives._GetStoredReal(cache, missionKey, key);
        }
        
        //native GetStoredBoolean takes gamecache cache, string missionKey, string key returns boolean
        public delegate JassBoolean GetStoredBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static GetStoredBooleanPrototype _GetStoredBoolean;
        public static Boolean GetStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return Natives._GetStoredBoolean(cache, missionKey, key);
        }
        
        //native GetStoredString takes gamecache cache, string missionKey, string key returns string
        public delegate JassStringRet GetStoredStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private static GetStoredStringPrototype _GetStoredString;
        public static String GetStoredString(JassGameCache cache, String missionKey, String key)
        {
            return Natives._GetStoredString(cache, missionKey, key);
        }
        
        //native RestoreUnit takes gamecache cache, string missionKey, string key, player forWhichPlayer, real x, real y, real facing returns unit
        public delegate JassUnit RestoreUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassPlayer forWhichPlayer, JassRealArg x, JassRealArg y, JassRealArg facing);
        private static RestoreUnitPrototype _RestoreUnit;
        public static JassUnit RestoreUnit(JassGameCache cache, String missionKey, String key, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return Natives._RestoreUnit(cache, missionKey, key, forWhichPlayer, x, y, facing);
        }
        
        //native InitHashtable takes nothing returns hashtable
        public delegate JassHashTable InitHashtablePrototype();
        private static InitHashtablePrototype _InitHashtable;
        public static JassHashTable InitHashtable()
        {
            return Natives._InitHashtable();
        }
        
        //native SaveInteger takes hashtable table, integer parentKey, integer childKey, integer value returns nothing
        public delegate void SaveIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value);
        private static SaveIntegerPrototype _SaveInteger;
        public static void SaveInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value)
        {
            Natives._SaveInteger(table, parentKey, childKey, value);
        }
        
        //native SaveReal takes hashtable table, integer parentKey, integer childKey, real value returns nothing
        public delegate void SaveRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRealArg value);
        private static SaveRealPrototype _SaveReal;
        public static void SaveReal(JassHashTable table, JassInteger parentKey, JassInteger childKey, Single value)
        {
            Natives._SaveReal(table, parentKey, childKey, value);
        }
        
        //native SaveBoolean takes hashtable table, integer parentKey, integer childKey, boolean value returns nothing
        public delegate void SaveBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBoolean value);
        private static SaveBooleanPrototype _SaveBoolean;
        public static void SaveBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey, Boolean value)
        {
            Natives._SaveBoolean(table, parentKey, childKey, value);
        }
        
        //native SaveStr takes hashtable table, integer parentKey, integer childKey, string value returns boolean
        public delegate JassBoolean SaveStrPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassStringArg value);
        private static SaveStrPrototype _SaveStr;
        public static Boolean SaveStr(JassHashTable table, JassInteger parentKey, JassInteger childKey, String value)
        {
            return Natives._SaveStr(table, parentKey, childKey, value);
        }
        
        //native SavePlayerHandle takes hashtable table, integer parentKey, integer childKey, player whichPlayer returns boolean
        public delegate JassBoolean SavePlayerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer);
        private static SavePlayerHandlePrototype _SavePlayerHandle;
        public static Boolean SavePlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer)
        {
            return Natives._SavePlayerHandle(table, parentKey, childKey, whichPlayer);
        }
        
        //native SaveWidgetHandle takes hashtable table, integer parentKey, integer childKey, widget whichWidget returns boolean
        public delegate JassBoolean SaveWidgetHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget);
        private static SaveWidgetHandlePrototype _SaveWidgetHandle;
        public static Boolean SaveWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget)
        {
            return Natives._SaveWidgetHandle(table, parentKey, childKey, whichWidget);
        }
        
        //native SaveDestructableHandle takes hashtable table, integer parentKey, integer childKey, destructable whichDestructable returns boolean
        public delegate JassBoolean SaveDestructableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable);
        private static SaveDestructableHandlePrototype _SaveDestructableHandle;
        public static Boolean SaveDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable)
        {
            return Natives._SaveDestructableHandle(table, parentKey, childKey, whichDestructable);
        }
        
        //native SaveItemHandle takes hashtable table, integer parentKey, integer childKey, item whichItem returns boolean
        public delegate JassBoolean SaveItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem);
        private static SaveItemHandlePrototype _SaveItemHandle;
        public static Boolean SaveItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem)
        {
            return Natives._SaveItemHandle(table, parentKey, childKey, whichItem);
        }
        
        //native SaveUnitHandle takes hashtable table, integer parentKey, integer childKey, unit whichUnit returns boolean
        public delegate JassBoolean SaveUnitHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit);
        private static SaveUnitHandlePrototype _SaveUnitHandle;
        public static Boolean SaveUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit)
        {
            return Natives._SaveUnitHandle(table, parentKey, childKey, whichUnit);
        }
        
        //native SaveAbilityHandle takes hashtable table, integer parentKey, integer childKey, ability whichAbility returns boolean
        public delegate JassBoolean SaveAbilityHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility);
        private static SaveAbilityHandlePrototype _SaveAbilityHandle;
        public static Boolean SaveAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility)
        {
            return Natives._SaveAbilityHandle(table, parentKey, childKey, whichAbility);
        }
        
        //native SaveTimerHandle takes hashtable table, integer parentKey, integer childKey, timer whichTimer returns boolean
        public delegate JassBoolean SaveTimerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer);
        private static SaveTimerHandlePrototype _SaveTimerHandle;
        public static Boolean SaveTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer)
        {
            return Natives._SaveTimerHandle(table, parentKey, childKey, whichTimer);
        }
        
        //native SaveTriggerHandle takes hashtable table, integer parentKey, integer childKey, trigger whichTrigger returns boolean
        public delegate JassBoolean SaveTriggerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger);
        private static SaveTriggerHandlePrototype _SaveTriggerHandle;
        public static Boolean SaveTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger)
        {
            return Natives._SaveTriggerHandle(table, parentKey, childKey, whichTrigger);
        }
        
        //native SaveTriggerConditionHandle takes hashtable table, integer parentKey, integer childKey, triggercondition whichTriggercondition returns boolean
        public delegate JassBoolean SaveTriggerConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition);
        private static SaveTriggerConditionHandlePrototype _SaveTriggerConditionHandle;
        public static Boolean SaveTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition)
        {
            return Natives._SaveTriggerConditionHandle(table, parentKey, childKey, whichTriggercondition);
        }
        
        //native SaveTriggerActionHandle takes hashtable table, integer parentKey, integer childKey, triggeraction whichTriggeraction returns boolean
        public delegate JassBoolean SaveTriggerActionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction);
        private static SaveTriggerActionHandlePrototype _SaveTriggerActionHandle;
        public static Boolean SaveTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction)
        {
            return Natives._SaveTriggerActionHandle(table, parentKey, childKey, whichTriggeraction);
        }
        
        //native SaveTriggerEventHandle takes hashtable table, integer parentKey, integer childKey, event whichEvent returns boolean
        public delegate JassBoolean SaveTriggerEventHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent);
        private static SaveTriggerEventHandlePrototype _SaveTriggerEventHandle;
        public static Boolean SaveTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent)
        {
            return Natives._SaveTriggerEventHandle(table, parentKey, childKey, whichEvent);
        }
        
        //native SaveForceHandle takes hashtable table, integer parentKey, integer childKey, force whichForce returns boolean
        public delegate JassBoolean SaveForceHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce);
        private static SaveForceHandlePrototype _SaveForceHandle;
        public static Boolean SaveForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce)
        {
            return Natives._SaveForceHandle(table, parentKey, childKey, whichForce);
        }
        
        //native SaveGroupHandle takes hashtable table, integer parentKey, integer childKey, group whichGroup returns boolean
        public delegate JassBoolean SaveGroupHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup);
        private static SaveGroupHandlePrototype _SaveGroupHandle;
        public static Boolean SaveGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup)
        {
            return Natives._SaveGroupHandle(table, parentKey, childKey, whichGroup);
        }
        
        //native SaveLocationHandle takes hashtable table, integer parentKey, integer childKey, location whichLocation returns boolean
        public delegate JassBoolean SaveLocationHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation);
        private static SaveLocationHandlePrototype _SaveLocationHandle;
        public static Boolean SaveLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation)
        {
            return Natives._SaveLocationHandle(table, parentKey, childKey, whichLocation);
        }
        
        //native SaveRectHandle takes hashtable table, integer parentKey, integer childKey, rect whichRect returns boolean
        public delegate JassBoolean SaveRectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect);
        private static SaveRectHandlePrototype _SaveRectHandle;
        public static Boolean SaveRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect)
        {
            return Natives._SaveRectHandle(table, parentKey, childKey, whichRect);
        }
        
        //native SaveBooleanExprHandle takes hashtable table, integer parentKey, integer childKey, boolexpr whichBoolexpr returns boolean
        public delegate JassBoolean SaveBooleanExprHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr);
        private static SaveBooleanExprHandlePrototype _SaveBooleanExprHandle;
        public static Boolean SaveBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr)
        {
            return Natives._SaveBooleanExprHandle(table, parentKey, childKey, whichBoolexpr);
        }
        
        //native SaveSoundHandle takes hashtable table, integer parentKey, integer childKey, sound whichSound returns boolean
        public delegate JassBoolean SaveSoundHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound);
        private static SaveSoundHandlePrototype _SaveSoundHandle;
        public static Boolean SaveSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound)
        {
            return Natives._SaveSoundHandle(table, parentKey, childKey, whichSound);
        }
        
        //native SaveEffectHandle takes hashtable table, integer parentKey, integer childKey, effect whichEffect returns boolean
        public delegate JassBoolean SaveEffectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect);
        private static SaveEffectHandlePrototype _SaveEffectHandle;
        public static Boolean SaveEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect)
        {
            return Natives._SaveEffectHandle(table, parentKey, childKey, whichEffect);
        }
        
        //native SaveUnitPoolHandle takes hashtable table, integer parentKey, integer childKey, unitpool whichUnitpool returns boolean
        public delegate JassBoolean SaveUnitPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool);
        private static SaveUnitPoolHandlePrototype _SaveUnitPoolHandle;
        public static Boolean SaveUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool)
        {
            return Natives._SaveUnitPoolHandle(table, parentKey, childKey, whichUnitpool);
        }
        
        //native SaveItemPoolHandle takes hashtable table, integer parentKey, integer childKey, itempool whichItempool returns boolean
        public delegate JassBoolean SaveItemPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool);
        private static SaveItemPoolHandlePrototype _SaveItemPoolHandle;
        public static Boolean SaveItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool)
        {
            return Natives._SaveItemPoolHandle(table, parentKey, childKey, whichItempool);
        }
        
        //native SaveQuestHandle takes hashtable table, integer parentKey, integer childKey, quest whichQuest returns boolean
        public delegate JassBoolean SaveQuestHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest);
        private static SaveQuestHandlePrototype _SaveQuestHandle;
        public static Boolean SaveQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest)
        {
            return Natives._SaveQuestHandle(table, parentKey, childKey, whichQuest);
        }
        
        //native SaveQuestItemHandle takes hashtable table, integer parentKey, integer childKey, questitem whichQuestitem returns boolean
        public delegate JassBoolean SaveQuestItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem);
        private static SaveQuestItemHandlePrototype _SaveQuestItemHandle;
        public static Boolean SaveQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem)
        {
            return Natives._SaveQuestItemHandle(table, parentKey, childKey, whichQuestitem);
        }
        
        //native SaveDefeatConditionHandle takes hashtable table, integer parentKey, integer childKey, defeatcondition whichDefeatcondition returns boolean
        public delegate JassBoolean SaveDefeatConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition);
        private static SaveDefeatConditionHandlePrototype _SaveDefeatConditionHandle;
        public static Boolean SaveDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition)
        {
            return Natives._SaveDefeatConditionHandle(table, parentKey, childKey, whichDefeatcondition);
        }
        
        //native SaveTimerDialogHandle takes hashtable table, integer parentKey, integer childKey, timerdialog whichTimerdialog returns boolean
        public delegate JassBoolean SaveTimerDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog);
        private static SaveTimerDialogHandlePrototype _SaveTimerDialogHandle;
        public static Boolean SaveTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog)
        {
            return Natives._SaveTimerDialogHandle(table, parentKey, childKey, whichTimerdialog);
        }
        
        //native SaveLeaderboardHandle takes hashtable table, integer parentKey, integer childKey, leaderboard whichLeaderboard returns boolean
        public delegate JassBoolean SaveLeaderboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard);
        private static SaveLeaderboardHandlePrototype _SaveLeaderboardHandle;
        public static Boolean SaveLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard)
        {
            return Natives._SaveLeaderboardHandle(table, parentKey, childKey, whichLeaderboard);
        }
        
        //native SaveMultiboardHandle takes hashtable table, integer parentKey, integer childKey, multiboard whichMultiboard returns boolean
        public delegate JassBoolean SaveMultiboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard);
        private static SaveMultiboardHandlePrototype _SaveMultiboardHandle;
        public static Boolean SaveMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard)
        {
            return Natives._SaveMultiboardHandle(table, parentKey, childKey, whichMultiboard);
        }
        
        //native SaveMultiboardItemHandle takes hashtable table, integer parentKey, integer childKey, multiboarditem whichMultiboarditem returns boolean
        public delegate JassBoolean SaveMultiboardItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem);
        private static SaveMultiboardItemHandlePrototype _SaveMultiboardItemHandle;
        public static Boolean SaveMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem)
        {
            return Natives._SaveMultiboardItemHandle(table, parentKey, childKey, whichMultiboarditem);
        }
        
        //native SaveTrackableHandle takes hashtable table, integer parentKey, integer childKey, trackable whichTrackable returns boolean
        public delegate JassBoolean SaveTrackableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable);
        private static SaveTrackableHandlePrototype _SaveTrackableHandle;
        public static Boolean SaveTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable)
        {
            return Natives._SaveTrackableHandle(table, parentKey, childKey, whichTrackable);
        }
        
        //native SaveDialogHandle takes hashtable table, integer parentKey, integer childKey, dialog whichDialog returns boolean
        public delegate JassBoolean SaveDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog);
        private static SaveDialogHandlePrototype _SaveDialogHandle;
        public static Boolean SaveDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog)
        {
            return Natives._SaveDialogHandle(table, parentKey, childKey, whichDialog);
        }
        
        //native SaveButtonHandle takes hashtable table, integer parentKey, integer childKey, button whichButton returns boolean
        public delegate JassBoolean SaveButtonHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton);
        private static SaveButtonHandlePrototype _SaveButtonHandle;
        public static Boolean SaveButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton)
        {
            return Natives._SaveButtonHandle(table, parentKey, childKey, whichButton);
        }
        
        //native SaveTextTagHandle takes hashtable table, integer parentKey, integer childKey, texttag whichTexttag returns boolean
        public delegate JassBoolean SaveTextTagHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag);
        private static SaveTextTagHandlePrototype _SaveTextTagHandle;
        public static Boolean SaveTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag)
        {
            return Natives._SaveTextTagHandle(table, parentKey, childKey, whichTexttag);
        }
        
        //native SaveLightningHandle takes hashtable table, integer parentKey, integer childKey, lightning whichLightning returns boolean
        public delegate JassBoolean SaveLightningHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning);
        private static SaveLightningHandlePrototype _SaveLightningHandle;
        public static Boolean SaveLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning)
        {
            return Natives._SaveLightningHandle(table, parentKey, childKey, whichLightning);
        }
        
        //native SaveImageHandle takes hashtable table, integer parentKey, integer childKey, image whichImage returns boolean
        public delegate JassBoolean SaveImageHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage);
        private static SaveImageHandlePrototype _SaveImageHandle;
        public static Boolean SaveImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage)
        {
            return Natives._SaveImageHandle(table, parentKey, childKey, whichImage);
        }
        
        //native SaveUbersplatHandle takes hashtable table, integer parentKey, integer childKey, ubersplat whichUbersplat returns boolean
        public delegate JassBoolean SaveUbersplatHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat);
        private static SaveUbersplatHandlePrototype _SaveUbersplatHandle;
        public static Boolean SaveUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat)
        {
            return Natives._SaveUbersplatHandle(table, parentKey, childKey, whichUbersplat);
        }
        
        //native SaveRegionHandle takes hashtable table, integer parentKey, integer childKey, region whichRegion returns boolean
        public delegate JassBoolean SaveRegionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion);
        private static SaveRegionHandlePrototype _SaveRegionHandle;
        public static Boolean SaveRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion)
        {
            return Natives._SaveRegionHandle(table, parentKey, childKey, whichRegion);
        }
        
        //native SaveFogStateHandle takes hashtable table, integer parentKey, integer childKey, fogstate whichFogState returns boolean
        public delegate JassBoolean SaveFogStateHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState);
        private static SaveFogStateHandlePrototype _SaveFogStateHandle;
        public static Boolean SaveFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState)
        {
            return Natives._SaveFogStateHandle(table, parentKey, childKey, whichFogState);
        }
        
        //native SaveFogModifierHandle takes hashtable table, integer parentKey, integer childKey, fogmodifier whichFogModifier returns boolean
        public delegate JassBoolean SaveFogModifierHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier);
        private static SaveFogModifierHandlePrototype _SaveFogModifierHandle;
        public static Boolean SaveFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier)
        {
            return Natives._SaveFogModifierHandle(table, parentKey, childKey, whichFogModifier);
        }
        
        //native SaveAgentHandle takes hashtable table, integer parentKey, integer childKey, agent whichAgent returns boolean
        public delegate JassBoolean SaveAgentHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent);
        private static SaveAgentHandlePrototype _SaveAgentHandle;
        public static Boolean SaveAgentHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent)
        {
            return Natives._SaveAgentHandle(table, parentKey, childKey, whichAgent);
        }
        
        //native SaveHashtableHandle takes hashtable table, integer parentKey, integer childKey, hashtable whichHashtable returns boolean
        public delegate JassBoolean SaveHashtableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable);
        private static SaveHashtableHandlePrototype _SaveHashtableHandle;
        public static Boolean SaveHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable)
        {
            return Natives._SaveHashtableHandle(table, parentKey, childKey, whichHashtable);
        }
        
        //native LoadInteger takes hashtable table, integer parentKey, integer childKey returns integer
        public delegate JassInteger LoadIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadIntegerPrototype _LoadInteger;
        public static JassInteger LoadInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadInteger(table, parentKey, childKey);
        }
        
        //native LoadReal takes hashtable table, integer parentKey, integer childKey returns real
        public delegate JassRealRet LoadRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadRealPrototype _LoadReal;
        public static Single LoadReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadReal(table, parentKey, childKey);
        }
        
        //native LoadBoolean takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean LoadBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadBooleanPrototype _LoadBoolean;
        public static Boolean LoadBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadBoolean(table, parentKey, childKey);
        }
        
        //native LoadStr takes hashtable table, integer parentKey, integer childKey returns string
        public delegate JassStringRet LoadStrPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadStrPrototype _LoadStr;
        public static String LoadStr(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadStr(table, parentKey, childKey);
        }
        
        //native LoadPlayerHandle takes hashtable table, integer parentKey, integer childKey returns player
        public delegate JassPlayer LoadPlayerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadPlayerHandlePrototype _LoadPlayerHandle;
        public static JassPlayer LoadPlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadPlayerHandle(table, parentKey, childKey);
        }
        
        //native LoadWidgetHandle takes hashtable table, integer parentKey, integer childKey returns widget
        public delegate JassWidget LoadWidgetHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadWidgetHandlePrototype _LoadWidgetHandle;
        public static JassWidget LoadWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadWidgetHandle(table, parentKey, childKey);
        }
        
        //native LoadDestructableHandle takes hashtable table, integer parentKey, integer childKey returns destructable
        public delegate JassDestructable LoadDestructableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadDestructableHandlePrototype _LoadDestructableHandle;
        public static JassDestructable LoadDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadDestructableHandle(table, parentKey, childKey);
        }
        
        //native LoadItemHandle takes hashtable table, integer parentKey, integer childKey returns item
        public delegate JassItem LoadItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadItemHandlePrototype _LoadItemHandle;
        public static JassItem LoadItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadItemHandle(table, parentKey, childKey);
        }
        
        //native LoadUnitHandle takes hashtable table, integer parentKey, integer childKey returns unit
        public delegate JassUnit LoadUnitHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadUnitHandlePrototype _LoadUnitHandle;
        public static JassUnit LoadUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadUnitHandle(table, parentKey, childKey);
        }
        
        //native LoadAbilityHandle takes hashtable table, integer parentKey, integer childKey returns ability
        public delegate JassAbility LoadAbilityHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadAbilityHandlePrototype _LoadAbilityHandle;
        public static JassAbility LoadAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadAbilityHandle(table, parentKey, childKey);
        }
        
        //native LoadTimerHandle takes hashtable table, integer parentKey, integer childKey returns timer
        public delegate JassTimer LoadTimerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTimerHandlePrototype _LoadTimerHandle;
        public static JassTimer LoadTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadTimerHandle(table, parentKey, childKey);
        }
        
        //native LoadTriggerHandle takes hashtable table, integer parentKey, integer childKey returns trigger
        public delegate JassTrigger LoadTriggerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTriggerHandlePrototype _LoadTriggerHandle;
        public static JassTrigger LoadTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadTriggerHandle(table, parentKey, childKey);
        }
        
        //native LoadTriggerConditionHandle takes hashtable table, integer parentKey, integer childKey returns triggercondition
        public delegate JassTriggerCondition LoadTriggerConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTriggerConditionHandlePrototype _LoadTriggerConditionHandle;
        public static JassTriggerCondition LoadTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadTriggerConditionHandle(table, parentKey, childKey);
        }
        
        //native LoadTriggerActionHandle takes hashtable table, integer parentKey, integer childKey returns triggeraction
        public delegate JassTriggerAction LoadTriggerActionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTriggerActionHandlePrototype _LoadTriggerActionHandle;
        public static JassTriggerAction LoadTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadTriggerActionHandle(table, parentKey, childKey);
        }
        
        //native LoadTriggerEventHandle takes hashtable table, integer parentKey, integer childKey returns event
        public delegate JassEvent LoadTriggerEventHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTriggerEventHandlePrototype _LoadTriggerEventHandle;
        public static JassEvent LoadTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadTriggerEventHandle(table, parentKey, childKey);
        }
        
        //native LoadForceHandle takes hashtable table, integer parentKey, integer childKey returns force
        public delegate JassForce LoadForceHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadForceHandlePrototype _LoadForceHandle;
        public static JassForce LoadForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadForceHandle(table, parentKey, childKey);
        }
        
        //native LoadGroupHandle takes hashtable table, integer parentKey, integer childKey returns group
        public delegate JassGroup LoadGroupHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadGroupHandlePrototype _LoadGroupHandle;
        public static JassGroup LoadGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadGroupHandle(table, parentKey, childKey);
        }
        
        //native LoadLocationHandle takes hashtable table, integer parentKey, integer childKey returns location
        public delegate JassLocation LoadLocationHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadLocationHandlePrototype _LoadLocationHandle;
        public static JassLocation LoadLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadLocationHandle(table, parentKey, childKey);
        }
        
        //native LoadRectHandle takes hashtable table, integer parentKey, integer childKey returns rect
        public delegate JassRect LoadRectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadRectHandlePrototype _LoadRectHandle;
        public static JassRect LoadRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadRectHandle(table, parentKey, childKey);
        }
        
        //native LoadBooleanExprHandle takes hashtable table, integer parentKey, integer childKey returns boolexpr
        public delegate JassBooleanExpression LoadBooleanExprHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadBooleanExprHandlePrototype _LoadBooleanExprHandle;
        public static JassBooleanExpression LoadBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadBooleanExprHandle(table, parentKey, childKey);
        }
        
        //native LoadSoundHandle takes hashtable table, integer parentKey, integer childKey returns sound
        public delegate JassSound LoadSoundHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadSoundHandlePrototype _LoadSoundHandle;
        public static JassSound LoadSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadSoundHandle(table, parentKey, childKey);
        }
        
        //native LoadEffectHandle takes hashtable table, integer parentKey, integer childKey returns effect
        public delegate JassEffect LoadEffectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadEffectHandlePrototype _LoadEffectHandle;
        public static JassEffect LoadEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadEffectHandle(table, parentKey, childKey);
        }
        
        //native LoadUnitPoolHandle takes hashtable table, integer parentKey, integer childKey returns unitpool
        public delegate JassUnitPool LoadUnitPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadUnitPoolHandlePrototype _LoadUnitPoolHandle;
        public static JassUnitPool LoadUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadUnitPoolHandle(table, parentKey, childKey);
        }
        
        //native LoadItemPoolHandle takes hashtable table, integer parentKey, integer childKey returns itempool
        public delegate JassItemPool LoadItemPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadItemPoolHandlePrototype _LoadItemPoolHandle;
        public static JassItemPool LoadItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadItemPoolHandle(table, parentKey, childKey);
        }
        
        //native LoadQuestHandle takes hashtable table, integer parentKey, integer childKey returns quest
        public delegate JassQuest LoadQuestHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadQuestHandlePrototype _LoadQuestHandle;
        public static JassQuest LoadQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadQuestHandle(table, parentKey, childKey);
        }
        
        //native LoadQuestItemHandle takes hashtable table, integer parentKey, integer childKey returns questitem
        public delegate JassQuestItem LoadQuestItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadQuestItemHandlePrototype _LoadQuestItemHandle;
        public static JassQuestItem LoadQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadQuestItemHandle(table, parentKey, childKey);
        }
        
        //native LoadDefeatConditionHandle takes hashtable table, integer parentKey, integer childKey returns defeatcondition
        public delegate JassDefeatCondition LoadDefeatConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadDefeatConditionHandlePrototype _LoadDefeatConditionHandle;
        public static JassDefeatCondition LoadDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadDefeatConditionHandle(table, parentKey, childKey);
        }
        
        //native LoadTimerDialogHandle takes hashtable table, integer parentKey, integer childKey returns timerdialog
        public delegate JassTimerDialog LoadTimerDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTimerDialogHandlePrototype _LoadTimerDialogHandle;
        public static JassTimerDialog LoadTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadTimerDialogHandle(table, parentKey, childKey);
        }
        
        //native LoadLeaderboardHandle takes hashtable table, integer parentKey, integer childKey returns leaderboard
        public delegate JassLeaderboard LoadLeaderboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadLeaderboardHandlePrototype _LoadLeaderboardHandle;
        public static JassLeaderboard LoadLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadLeaderboardHandle(table, parentKey, childKey);
        }
        
        //native LoadMultiboardHandle takes hashtable table, integer parentKey, integer childKey returns multiboard
        public delegate JassMultiboard LoadMultiboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadMultiboardHandlePrototype _LoadMultiboardHandle;
        public static JassMultiboard LoadMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadMultiboardHandle(table, parentKey, childKey);
        }
        
        //native LoadMultiboardItemHandle takes hashtable table, integer parentKey, integer childKey returns multiboarditem
        public delegate JassMultiboardItem LoadMultiboardItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadMultiboardItemHandlePrototype _LoadMultiboardItemHandle;
        public static JassMultiboardItem LoadMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadMultiboardItemHandle(table, parentKey, childKey);
        }
        
        //native LoadTrackableHandle takes hashtable table, integer parentKey, integer childKey returns trackable
        public delegate JassTrackable LoadTrackableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTrackableHandlePrototype _LoadTrackableHandle;
        public static JassTrackable LoadTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadTrackableHandle(table, parentKey, childKey);
        }
        
        //native LoadDialogHandle takes hashtable table, integer parentKey, integer childKey returns dialog
        public delegate JassDialog LoadDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadDialogHandlePrototype _LoadDialogHandle;
        public static JassDialog LoadDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadDialogHandle(table, parentKey, childKey);
        }
        
        //native LoadButtonHandle takes hashtable table, integer parentKey, integer childKey returns button
        public delegate JassButton LoadButtonHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadButtonHandlePrototype _LoadButtonHandle;
        public static JassButton LoadButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadButtonHandle(table, parentKey, childKey);
        }
        
        //native LoadTextTagHandle takes hashtable table, integer parentKey, integer childKey returns texttag
        public delegate JassTextTag LoadTextTagHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadTextTagHandlePrototype _LoadTextTagHandle;
        public static JassTextTag LoadTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadTextTagHandle(table, parentKey, childKey);
        }
        
        //native LoadLightningHandle takes hashtable table, integer parentKey, integer childKey returns lightning
        public delegate JassLightning LoadLightningHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadLightningHandlePrototype _LoadLightningHandle;
        public static JassLightning LoadLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadLightningHandle(table, parentKey, childKey);
        }
        
        //native LoadImageHandle takes hashtable table, integer parentKey, integer childKey returns image
        public delegate JassImage LoadImageHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadImageHandlePrototype _LoadImageHandle;
        public static JassImage LoadImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadImageHandle(table, parentKey, childKey);
        }
        
        //native LoadUbersplatHandle takes hashtable table, integer parentKey, integer childKey returns ubersplat
        public delegate JassUberSplat LoadUbersplatHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadUbersplatHandlePrototype _LoadUbersplatHandle;
        public static JassUberSplat LoadUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadUbersplatHandle(table, parentKey, childKey);
        }
        
        //native LoadRegionHandle takes hashtable table, integer parentKey, integer childKey returns region
        public delegate JassRegion LoadRegionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadRegionHandlePrototype _LoadRegionHandle;
        public static JassRegion LoadRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadRegionHandle(table, parentKey, childKey);
        }
        
        //native LoadFogStateHandle takes hashtable table, integer parentKey, integer childKey returns fogstate
        public delegate JassFogState LoadFogStateHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadFogStateHandlePrototype _LoadFogStateHandle;
        public static JassFogState LoadFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadFogStateHandle(table, parentKey, childKey);
        }
        
        //native LoadFogModifierHandle takes hashtable table, integer parentKey, integer childKey returns fogmodifier
        public delegate JassFogModifier LoadFogModifierHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadFogModifierHandlePrototype _LoadFogModifierHandle;
        public static JassFogModifier LoadFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadFogModifierHandle(table, parentKey, childKey);
        }
        
        //native LoadHashtableHandle takes hashtable table, integer parentKey, integer childKey returns hashtable
        public delegate JassHashTable LoadHashtableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static LoadHashtableHandlePrototype _LoadHashtableHandle;
        public static JassHashTable LoadHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._LoadHashtableHandle(table, parentKey, childKey);
        }
        
        //native HaveSavedInteger takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedIntegerPrototype _HaveSavedInteger;
        public static Boolean HaveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._HaveSavedInteger(table, parentKey, childKey);
        }
        
        //native HaveSavedReal takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedRealPrototype _HaveSavedReal;
        public static Boolean HaveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._HaveSavedReal(table, parentKey, childKey);
        }
        
        //native HaveSavedBoolean takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedBooleanPrototype _HaveSavedBoolean;
        public static Boolean HaveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._HaveSavedBoolean(table, parentKey, childKey);
        }
        
        //native HaveSavedString takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedStringPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedStringPrototype _HaveSavedString;
        public static Boolean HaveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._HaveSavedString(table, parentKey, childKey);
        }
        
        //native HaveSavedHandle takes hashtable table, integer parentKey, integer childKey returns boolean
        public delegate JassBoolean HaveSavedHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static HaveSavedHandlePrototype _HaveSavedHandle;
        public static Boolean HaveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives._HaveSavedHandle(table, parentKey, childKey);
        }
        
        //native RemoveSavedInteger takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedIntegerPrototype _RemoveSavedInteger;
        public static void RemoveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives._RemoveSavedInteger(table, parentKey, childKey);
        }
        
        //native RemoveSavedReal takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedRealPrototype _RemoveSavedReal;
        public static void RemoveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives._RemoveSavedReal(table, parentKey, childKey);
        }
        
        //native RemoveSavedBoolean takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedBooleanPrototype _RemoveSavedBoolean;
        public static void RemoveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives._RemoveSavedBoolean(table, parentKey, childKey);
        }
        
        //native RemoveSavedString takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedStringPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedStringPrototype _RemoveSavedString;
        public static void RemoveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives._RemoveSavedString(table, parentKey, childKey);
        }
        
        //native RemoveSavedHandle takes hashtable table, integer parentKey, integer childKey returns nothing
        public delegate void RemoveSavedHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private static RemoveSavedHandlePrototype _RemoveSavedHandle;
        public static void RemoveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives._RemoveSavedHandle(table, parentKey, childKey);
        }
        
        //native FlushParentHashtable takes hashtable table returns nothing
        public delegate void FlushParentHashtablePrototype(JassHashTable table);
        private static FlushParentHashtablePrototype _FlushParentHashtable;
        public static void FlushParentHashtable(JassHashTable table)
        {
            Natives._FlushParentHashtable(table);
        }
        
        //native FlushChildHashtable takes hashtable table, integer parentKey returns nothing
        public delegate void FlushChildHashtablePrototype(JassHashTable table, JassInteger parentKey);
        private static FlushChildHashtablePrototype _FlushChildHashtable;
        public static void FlushChildHashtable(JassHashTable table, JassInteger parentKey)
        {
            Natives._FlushChildHashtable(table, parentKey);
        }
        
        //native GetRandomInt takes integer lowBound, integer highBound returns integer
        public delegate JassInteger GetRandomIntPrototype(JassInteger lowBound, JassInteger highBound);
        private static GetRandomIntPrototype _GetRandomInt;
        public static JassInteger GetRandomInt(JassInteger lowBound, JassInteger highBound)
        {
            return Natives._GetRandomInt(lowBound, highBound);
        }
        
        //native GetRandomReal takes real lowBound, real highBound returns real
        public delegate JassRealRet GetRandomRealPrototype(JassRealArg lowBound, JassRealArg highBound);
        private static GetRandomRealPrototype _GetRandomReal;
        public static Single GetRandomReal(Single lowBound, Single highBound)
        {
            return Natives._GetRandomReal(lowBound, highBound);
        }
        
        //native CreateUnitPool takes nothing returns unitpool
        public delegate JassUnitPool CreateUnitPoolPrototype();
        private static CreateUnitPoolPrototype _CreateUnitPool;
        public static JassUnitPool CreateUnitPool()
        {
            return Natives._CreateUnitPool();
        }
        
        //native DestroyUnitPool takes unitpool whichPool returns nothing
        public delegate void DestroyUnitPoolPrototype(JassUnitPool whichPool);
        private static DestroyUnitPoolPrototype _DestroyUnitPool;
        public static void DestroyUnitPool(JassUnitPool whichPool)
        {
            Natives._DestroyUnitPool(whichPool);
        }
        
        //native UnitPoolAddUnitType takes unitpool whichPool, integer unitId, real weight returns nothing
        public delegate void UnitPoolAddUnitTypePrototype(JassUnitPool whichPool, JassObjectId unitId, JassRealArg weight);
        private static UnitPoolAddUnitTypePrototype _UnitPoolAddUnitType;
        public static void UnitPoolAddUnitType(JassUnitPool whichPool, JassObjectId unitId, Single weight)
        {
            Natives._UnitPoolAddUnitType(whichPool, unitId, weight);
        }
        
        //native UnitPoolRemoveUnitType takes unitpool whichPool, integer unitId returns nothing
        public delegate void UnitPoolRemoveUnitTypePrototype(JassUnitPool whichPool, JassObjectId unitId);
        private static UnitPoolRemoveUnitTypePrototype _UnitPoolRemoveUnitType;
        public static void UnitPoolRemoveUnitType(JassUnitPool whichPool, JassObjectId unitId)
        {
            Natives._UnitPoolRemoveUnitType(whichPool, unitId);
        }
        
        //native PlaceRandomUnit takes unitpool whichPool, player forWhichPlayer, real x, real y, real facing returns unit
        public delegate JassUnit PlaceRandomUnitPrototype(JassUnitPool whichPool, JassPlayer forWhichPlayer, JassRealArg x, JassRealArg y, JassRealArg facing);
        private static PlaceRandomUnitPrototype _PlaceRandomUnit;
        public static JassUnit PlaceRandomUnit(JassUnitPool whichPool, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return Natives._PlaceRandomUnit(whichPool, forWhichPlayer, x, y, facing);
        }
        
        //native CreateItemPool takes nothing returns itempool
        public delegate JassItemPool CreateItemPoolPrototype();
        private static CreateItemPoolPrototype _CreateItemPool;
        public static JassItemPool CreateItemPool()
        {
            return Natives._CreateItemPool();
        }
        
        //native DestroyItemPool takes itempool whichItemPool returns nothing
        public delegate void DestroyItemPoolPrototype(JassItemPool whichItemPool);
        private static DestroyItemPoolPrototype _DestroyItemPool;
        public static void DestroyItemPool(JassItemPool whichItemPool)
        {
            Natives._DestroyItemPool(whichItemPool);
        }
        
        //native ItemPoolAddItemType takes itempool whichItemPool, integer itemId, real weight returns nothing
        public delegate void ItemPoolAddItemTypePrototype(JassItemPool whichItemPool, JassObjectId itemId, JassRealArg weight);
        private static ItemPoolAddItemTypePrototype _ItemPoolAddItemType;
        public static void ItemPoolAddItemType(JassItemPool whichItemPool, JassObjectId itemId, Single weight)
        {
            Natives._ItemPoolAddItemType(whichItemPool, itemId, weight);
        }
        
        //native ItemPoolRemoveItemType takes itempool whichItemPool, integer itemId returns nothing
        public delegate void ItemPoolRemoveItemTypePrototype(JassItemPool whichItemPool, JassObjectId itemId);
        private static ItemPoolRemoveItemTypePrototype _ItemPoolRemoveItemType;
        public static void ItemPoolRemoveItemType(JassItemPool whichItemPool, JassObjectId itemId)
        {
            Natives._ItemPoolRemoveItemType(whichItemPool, itemId);
        }
        
        //native PlaceRandomItem takes itempool whichItemPool, real x, real y returns item
        public delegate JassItem PlaceRandomItemPrototype(JassItemPool whichItemPool, JassRealArg x, JassRealArg y);
        private static PlaceRandomItemPrototype _PlaceRandomItem;
        public static JassItem PlaceRandomItem(JassItemPool whichItemPool, Single x, Single y)
        {
            return Natives._PlaceRandomItem(whichItemPool, x, y);
        }
        
        //native ChooseRandomCreep takes integer level returns integer
        public delegate JassInteger ChooseRandomCreepPrototype(JassInteger level);
        private static ChooseRandomCreepPrototype _ChooseRandomCreep;
        public static JassInteger ChooseRandomCreep(JassInteger level)
        {
            return Natives._ChooseRandomCreep(level);
        }
        
        //native ChooseRandomNPBuilding takes nothing returns integer
        public delegate JassInteger ChooseRandomNPBuildingPrototype();
        private static ChooseRandomNPBuildingPrototype _ChooseRandomNPBuilding;
        public static JassInteger ChooseRandomNPBuilding()
        {
            return Natives._ChooseRandomNPBuilding();
        }
        
        //native ChooseRandomItem takes integer level returns integer
        public delegate JassInteger ChooseRandomItemPrototype(JassInteger level);
        private static ChooseRandomItemPrototype _ChooseRandomItem;
        public static JassInteger ChooseRandomItem(JassInteger level)
        {
            return Natives._ChooseRandomItem(level);
        }
        
        //native ChooseRandomItemEx takes itemtype whichType, integer level returns integer
        public delegate JassInteger ChooseRandomItemExPrototype(JassItemType whichType, JassInteger level);
        private static ChooseRandomItemExPrototype _ChooseRandomItemEx;
        public static JassInteger ChooseRandomItemEx(JassItemType whichType, JassInteger level)
        {
            return Natives._ChooseRandomItemEx(whichType, level);
        }
        
        //native SetRandomSeed takes integer seed returns nothing
        public delegate void SetRandomSeedPrototype(JassInteger seed);
        private static SetRandomSeedPrototype _SetRandomSeed;
        public static void SetRandomSeed(JassInteger seed)
        {
            Natives._SetRandomSeed(seed);
        }
        
        //native SetTerrainFog takes real a, real b, real c, real d, real e returns nothing
        public delegate void SetTerrainFogPrototype(JassRealArg a, JassRealArg b, JassRealArg c, JassRealArg d, JassRealArg e);
        private static SetTerrainFogPrototype _SetTerrainFog;
        public static void SetTerrainFog(Single a, Single b, Single c, Single d, Single e)
        {
            Natives._SetTerrainFog(a, b, c, d, e);
        }
        
        //native ResetTerrainFog takes nothing returns nothing
        public delegate void ResetTerrainFogPrototype();
        private static ResetTerrainFogPrototype _ResetTerrainFog;
        public static void ResetTerrainFog()
        {
            Natives._ResetTerrainFog();
        }
        
        //native SetUnitFog takes real a, real b, real c, real d, real e returns nothing
        public delegate void SetUnitFogPrototype(JassRealArg a, JassRealArg b, JassRealArg c, JassRealArg d, JassRealArg e);
        private static SetUnitFogPrototype _SetUnitFog;
        public static void SetUnitFog(Single a, Single b, Single c, Single d, Single e)
        {
            Natives._SetUnitFog(a, b, c, d, e);
        }
        
        //native SetTerrainFogEx takes integer style, real zstart, real zend, real density, real red, real green, real blue returns nothing
        public delegate void SetTerrainFogExPrototype(JassInteger style, JassRealArg zstart, JassRealArg zend, JassRealArg density, JassRealArg red, JassRealArg green, JassRealArg blue);
        private static SetTerrainFogExPrototype _SetTerrainFogEx;
        public static void SetTerrainFogEx(JassInteger style, Single zstart, Single zend, Single density, Single red, Single green, Single blue)
        {
            Natives._SetTerrainFogEx(style, zstart, zend, density, red, green, blue);
        }
        
        //native DisplayTextToPlayer takes player toPlayer, real x, real y, string message returns nothing
        public delegate void DisplayTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassStringArg message);
        private static DisplayTextToPlayerPrototype _DisplayTextToPlayer;
        public static void DisplayTextToPlayer(JassPlayer toPlayer, Single x, Single y, String message)
        {
            Natives._DisplayTextToPlayer(toPlayer, x, y, message);
        }
        
        //native DisplayTimedTextToPlayer takes player toPlayer, real x, real y, real duration, string message returns nothing
        public delegate void DisplayTimedTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassRealArg duration, JassStringArg message);
        private static DisplayTimedTextToPlayerPrototype _DisplayTimedTextToPlayer;
        public static void DisplayTimedTextToPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            Natives._DisplayTimedTextToPlayer(toPlayer, x, y, duration, message);
        }
        
        //native DisplayTimedTextFromPlayer takes player toPlayer, real x, real y, real duration, string message returns nothing
        public delegate void DisplayTimedTextFromPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassRealArg duration, JassStringArg message);
        private static DisplayTimedTextFromPlayerPrototype _DisplayTimedTextFromPlayer;
        public static void DisplayTimedTextFromPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            Natives._DisplayTimedTextFromPlayer(toPlayer, x, y, duration, message);
        }
        
        //native ClearTextMessages takes nothing returns nothing
        public delegate void ClearTextMessagesPrototype();
        private static ClearTextMessagesPrototype _ClearTextMessages;
        public static void ClearTextMessages()
        {
            Natives._ClearTextMessages();
        }
        
        //native SetDayNightModels takes string terrainDNCFile, string unitDNCFile returns nothing
        public delegate void SetDayNightModelsPrototype(JassStringArg terrainDNCFile, JassStringArg unitDNCFile);
        private static SetDayNightModelsPrototype _SetDayNightModels;
        public static void SetDayNightModels(String terrainDNCFile, String unitDNCFile)
        {
            Natives._SetDayNightModels(terrainDNCFile, unitDNCFile);
        }
        
        //native SetSkyModel takes string skyModelFile returns nothing
        public delegate void SetSkyModelPrototype(JassStringArg skyModelFile);
        private static SetSkyModelPrototype _SetSkyModel;
        public static void SetSkyModel(String skyModelFile)
        {
            Natives._SetSkyModel(skyModelFile);
        }
        
        //native EnableUserControl takes boolean b returns nothing
        public delegate void EnableUserControlPrototype(JassBoolean b);
        private static EnableUserControlPrototype _EnableUserControl;
        public static void EnableUserControl(Boolean b)
        {
            Natives._EnableUserControl(b);
        }
        
        //native EnableUserUI takes boolean b returns nothing
        public delegate void EnableUserUIPrototype(JassBoolean b);
        private static EnableUserUIPrototype _EnableUserUI;
        public static void EnableUserUI(Boolean b)
        {
            Natives._EnableUserUI(b);
        }
        
        //native SuspendTimeOfDay takes boolean b returns nothing
        public delegate void SuspendTimeOfDayPrototype(JassBoolean b);
        private static SuspendTimeOfDayPrototype _SuspendTimeOfDay;
        public static void SuspendTimeOfDay(Boolean b)
        {
            Natives._SuspendTimeOfDay(b);
        }
        
        //native SetTimeOfDayScale takes real r returns nothing
        public delegate void SetTimeOfDayScalePrototype(JassRealArg r);
        private static SetTimeOfDayScalePrototype _SetTimeOfDayScale;
        public static void SetTimeOfDayScale(Single r)
        {
            Natives._SetTimeOfDayScale(r);
        }
        
        //native GetTimeOfDayScale takes nothing returns real
        public delegate JassRealRet GetTimeOfDayScalePrototype();
        private static GetTimeOfDayScalePrototype _GetTimeOfDayScale;
        public static Single GetTimeOfDayScale()
        {
            return Natives._GetTimeOfDayScale();
        }
        
        //native ShowInterface takes boolean flag, real fadeDuration returns nothing
        public delegate void ShowInterfacePrototype(JassBoolean flag, JassRealArg fadeDuration);
        private static ShowInterfacePrototype _ShowInterface;
        public static void ShowInterface(Boolean flag, Single fadeDuration)
        {
            Natives._ShowInterface(flag, fadeDuration);
        }
        
        //native PauseGame takes boolean flag returns nothing
        public delegate void PauseGamePrototype(JassBoolean flag);
        private static PauseGamePrototype _PauseGame;
        public static void PauseGame(Boolean flag)
        {
            Natives._PauseGame(flag);
        }
        
        //native UnitAddIndicator takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void UnitAddIndicatorPrototype(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static UnitAddIndicatorPrototype _UnitAddIndicator;
        public static void UnitAddIndicator(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._UnitAddIndicator(whichUnit, red, green, blue, alpha);
        }
        
        //native AddIndicator takes widget whichWidget, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void AddIndicatorPrototype(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static AddIndicatorPrototype _AddIndicator;
        public static void AddIndicator(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._AddIndicator(whichWidget, red, green, blue, alpha);
        }
        
        //native PingMinimap takes real x, real y, real duration returns nothing
        public delegate void PingMinimapPrototype(JassRealArg x, JassRealArg y, JassRealArg duration);
        private static PingMinimapPrototype _PingMinimap;
        public static void PingMinimap(Single x, Single y, Single duration)
        {
            Natives._PingMinimap(x, y, duration);
        }
        
        //native PingMinimapEx takes real x, real y, real duration, integer red, integer green, integer blue, boolean extraEffects returns nothing
        public delegate void PingMinimapExPrototype(JassRealArg x, JassRealArg y, JassRealArg duration, JassInteger red, JassInteger green, JassInteger blue, JassBoolean extraEffects);
        private static PingMinimapExPrototype _PingMinimapEx;
        public static void PingMinimapEx(Single x, Single y, Single duration, JassInteger red, JassInteger green, JassInteger blue, Boolean extraEffects)
        {
            Natives._PingMinimapEx(x, y, duration, red, green, blue, extraEffects);
        }
        
        //native EnableOcclusion takes boolean flag returns nothing
        public delegate void EnableOcclusionPrototype(JassBoolean flag);
        private static EnableOcclusionPrototype _EnableOcclusion;
        public static void EnableOcclusion(Boolean flag)
        {
            Natives._EnableOcclusion(flag);
        }
        
        //native SetIntroShotText takes string introText returns nothing
        public delegate void SetIntroShotTextPrototype(JassStringArg introText);
        private static SetIntroShotTextPrototype _SetIntroShotText;
        public static void SetIntroShotText(String introText)
        {
            Natives._SetIntroShotText(introText);
        }
        
        //native SetIntroShotModel takes string introModelPath returns nothing
        public delegate void SetIntroShotModelPrototype(JassStringArg introModelPath);
        private static SetIntroShotModelPrototype _SetIntroShotModel;
        public static void SetIntroShotModel(String introModelPath)
        {
            Natives._SetIntroShotModel(introModelPath);
        }
        
        //native EnableWorldFogBoundary takes boolean b returns nothing
        public delegate void EnableWorldFogBoundaryPrototype(JassBoolean b);
        private static EnableWorldFogBoundaryPrototype _EnableWorldFogBoundary;
        public static void EnableWorldFogBoundary(Boolean b)
        {
            Natives._EnableWorldFogBoundary(b);
        }
        
        //native PlayModelCinematic takes string modelName returns nothing
        public delegate void PlayModelCinematicPrototype(JassStringArg modelName);
        private static PlayModelCinematicPrototype _PlayModelCinematic;
        public static void PlayModelCinematic(String modelName)
        {
            Natives._PlayModelCinematic(modelName);
        }
        
        //native PlayCinematic takes string movieName returns nothing
        public delegate void PlayCinematicPrototype(JassStringArg movieName);
        private static PlayCinematicPrototype _PlayCinematic;
        public static void PlayCinematic(String movieName)
        {
            Natives._PlayCinematic(movieName);
        }
        
        //native ForceUIKey takes string key returns nothing
        public delegate void ForceUIKeyPrototype(JassStringArg key);
        private static ForceUIKeyPrototype _ForceUIKey;
        public static void ForceUIKey(String key)
        {
            Natives._ForceUIKey(key);
        }
        
        //native ForceUICancel takes nothing returns nothing
        public delegate void ForceUICancelPrototype();
        private static ForceUICancelPrototype _ForceUICancel;
        public static void ForceUICancel()
        {
            Natives._ForceUICancel();
        }
        
        //native DisplayLoadDialog takes nothing returns nothing
        public delegate void DisplayLoadDialogPrototype();
        private static DisplayLoadDialogPrototype _DisplayLoadDialog;
        public static void DisplayLoadDialog()
        {
            Natives._DisplayLoadDialog();
        }
        
        //native SetAltMinimapIcon takes string iconPath returns nothing
        public delegate void SetAltMinimapIconPrototype(JassStringArg iconPath);
        private static SetAltMinimapIconPrototype _SetAltMinimapIcon;
        public static void SetAltMinimapIcon(String iconPath)
        {
            Natives._SetAltMinimapIcon(iconPath);
        }
        
        //native DisableRestartMission takes boolean flag returns nothing
        public delegate void DisableRestartMissionPrototype(JassBoolean flag);
        private static DisableRestartMissionPrototype _DisableRestartMission;
        public static void DisableRestartMission(Boolean flag)
        {
            Natives._DisableRestartMission(flag);
        }
        
        //native CreateTextTag takes nothing returns texttag
        public delegate JassTextTag CreateTextTagPrototype();
        private static CreateTextTagPrototype _CreateTextTag;
        public static JassTextTag CreateTextTag()
        {
            return Natives._CreateTextTag();
        }
        
        //native DestroyTextTag takes texttag t returns nothing
        public delegate void DestroyTextTagPrototype(JassTextTag t);
        private static DestroyTextTagPrototype _DestroyTextTag;
        public static void DestroyTextTag(JassTextTag t)
        {
            Natives._DestroyTextTag(t);
        }
        
        //native SetTextTagText takes texttag t, string s, real height returns nothing
        public delegate void SetTextTagTextPrototype(JassTextTag t, JassStringArg s, JassRealArg height);
        private static SetTextTagTextPrototype _SetTextTagText;
        public static void SetTextTagText(JassTextTag t, String s, Single height)
        {
            Natives._SetTextTagText(t, s, height);
        }
        
        //native SetTextTagPos takes texttag t, real x, real y, real heightOffset returns nothing
        public delegate void SetTextTagPosPrototype(JassTextTag t, JassRealArg x, JassRealArg y, JassRealArg heightOffset);
        private static SetTextTagPosPrototype _SetTextTagPos;
        public static void SetTextTagPos(JassTextTag t, Single x, Single y, Single heightOffset)
        {
            Natives._SetTextTagPos(t, x, y, heightOffset);
        }
        
        //native SetTextTagPosUnit takes texttag t, unit whichUnit, real heightOffset returns nothing
        public delegate void SetTextTagPosUnitPrototype(JassTextTag t, JassUnit whichUnit, JassRealArg heightOffset);
        private static SetTextTagPosUnitPrototype _SetTextTagPosUnit;
        public static void SetTextTagPosUnit(JassTextTag t, JassUnit whichUnit, Single heightOffset)
        {
            Natives._SetTextTagPosUnit(t, whichUnit, heightOffset);
        }
        
        //native SetTextTagColor takes texttag t, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetTextTagColorPrototype(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetTextTagColorPrototype _SetTextTagColor;
        public static void SetTextTagColor(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._SetTextTagColor(t, red, green, blue, alpha);
        }
        
        //native SetTextTagVelocity takes texttag t, real xvel, real yvel returns nothing
        public delegate void SetTextTagVelocityPrototype(JassTextTag t, JassRealArg xvel, JassRealArg yvel);
        private static SetTextTagVelocityPrototype _SetTextTagVelocity;
        public static void SetTextTagVelocity(JassTextTag t, Single xvel, Single yvel)
        {
            Natives._SetTextTagVelocity(t, xvel, yvel);
        }
        
        //native SetTextTagVisibility takes texttag t, boolean flag returns nothing
        public delegate void SetTextTagVisibilityPrototype(JassTextTag t, JassBoolean flag);
        private static SetTextTagVisibilityPrototype _SetTextTagVisibility;
        public static void SetTextTagVisibility(JassTextTag t, Boolean flag)
        {
            Natives._SetTextTagVisibility(t, flag);
        }
        
        //native SetTextTagSuspended takes texttag t, boolean flag returns nothing
        public delegate void SetTextTagSuspendedPrototype(JassTextTag t, JassBoolean flag);
        private static SetTextTagSuspendedPrototype _SetTextTagSuspended;
        public static void SetTextTagSuspended(JassTextTag t, Boolean flag)
        {
            Natives._SetTextTagSuspended(t, flag);
        }
        
        //native SetTextTagPermanent takes texttag t, boolean flag returns nothing
        public delegate void SetTextTagPermanentPrototype(JassTextTag t, JassBoolean flag);
        private static SetTextTagPermanentPrototype _SetTextTagPermanent;
        public static void SetTextTagPermanent(JassTextTag t, Boolean flag)
        {
            Natives._SetTextTagPermanent(t, flag);
        }
        
        //native SetTextTagAge takes texttag t, real age returns nothing
        public delegate void SetTextTagAgePrototype(JassTextTag t, JassRealArg age);
        private static SetTextTagAgePrototype _SetTextTagAge;
        public static void SetTextTagAge(JassTextTag t, Single age)
        {
            Natives._SetTextTagAge(t, age);
        }
        
        //native SetTextTagLifespan takes texttag t, real lifespan returns nothing
        public delegate void SetTextTagLifespanPrototype(JassTextTag t, JassRealArg lifespan);
        private static SetTextTagLifespanPrototype _SetTextTagLifespan;
        public static void SetTextTagLifespan(JassTextTag t, Single lifespan)
        {
            Natives._SetTextTagLifespan(t, lifespan);
        }
        
        //native SetTextTagFadepoint takes texttag t, real fadepoint returns nothing
        public delegate void SetTextTagFadepointPrototype(JassTextTag t, JassRealArg fadepoint);
        private static SetTextTagFadepointPrototype _SetTextTagFadepoint;
        public static void SetTextTagFadepoint(JassTextTag t, Single fadepoint)
        {
            Natives._SetTextTagFadepoint(t, fadepoint);
        }
        
        //native SetReservedLocalHeroButtons takes integer reserved returns nothing
        public delegate void SetReservedLocalHeroButtonsPrototype(JassInteger reserved);
        private static SetReservedLocalHeroButtonsPrototype _SetReservedLocalHeroButtons;
        public static void SetReservedLocalHeroButtons(JassInteger reserved)
        {
            Natives._SetReservedLocalHeroButtons(reserved);
        }
        
        //native GetAllyColorFilterState takes nothing returns integer
        public delegate JassInteger GetAllyColorFilterStatePrototype();
        private static GetAllyColorFilterStatePrototype _GetAllyColorFilterState;
        public static JassInteger GetAllyColorFilterState()
        {
            return Natives._GetAllyColorFilterState();
        }
        
        //native SetAllyColorFilterState takes integer state returns nothing
        public delegate void SetAllyColorFilterStatePrototype(JassInteger state);
        private static SetAllyColorFilterStatePrototype _SetAllyColorFilterState;
        public static void SetAllyColorFilterState(JassInteger state)
        {
            Natives._SetAllyColorFilterState(state);
        }
        
        //native GetCreepCampFilterState takes nothing returns boolean
        public delegate JassBoolean GetCreepCampFilterStatePrototype();
        private static GetCreepCampFilterStatePrototype _GetCreepCampFilterState;
        public static Boolean GetCreepCampFilterState()
        {
            return Natives._GetCreepCampFilterState();
        }
        
        //native SetCreepCampFilterState takes boolean state returns nothing
        public delegate void SetCreepCampFilterStatePrototype(JassBoolean state);
        private static SetCreepCampFilterStatePrototype _SetCreepCampFilterState;
        public static void SetCreepCampFilterState(Boolean state)
        {
            Natives._SetCreepCampFilterState(state);
        }
        
        //native EnableMinimapFilterButtons takes boolean enableAlly, boolean enableCreep returns nothing
        public delegate void EnableMinimapFilterButtonsPrototype(JassBoolean enableAlly, JassBoolean enableCreep);
        private static EnableMinimapFilterButtonsPrototype _EnableMinimapFilterButtons;
        public static void EnableMinimapFilterButtons(Boolean enableAlly, Boolean enableCreep)
        {
            Natives._EnableMinimapFilterButtons(enableAlly, enableCreep);
        }
        
        //native EnableDragSelect takes boolean state, boolean ui returns nothing
        public delegate void EnableDragSelectPrototype(JassBoolean state, JassBoolean ui);
        private static EnableDragSelectPrototype _EnableDragSelect;
        public static void EnableDragSelect(Boolean state, Boolean ui)
        {
            Natives._EnableDragSelect(state, ui);
        }
        
        //native EnablePreSelect takes boolean state, boolean ui returns nothing
        public delegate void EnablePreSelectPrototype(JassBoolean state, JassBoolean ui);
        private static EnablePreSelectPrototype _EnablePreSelect;
        public static void EnablePreSelect(Boolean state, Boolean ui)
        {
            Natives._EnablePreSelect(state, ui);
        }
        
        //native EnableSelect takes boolean state, boolean ui returns nothing
        public delegate void EnableSelectPrototype(JassBoolean state, JassBoolean ui);
        private static EnableSelectPrototype _EnableSelect;
        public static void EnableSelect(Boolean state, Boolean ui)
        {
            Natives._EnableSelect(state, ui);
        }
        
        //native CreateTrackable takes string trackableModelPath, real x, real y, real facing returns trackable
        public delegate JassTrackable CreateTrackablePrototype(JassStringArg trackableModelPath, JassRealArg x, JassRealArg y, JassRealArg facing);
        private static CreateTrackablePrototype _CreateTrackable;
        public static JassTrackable CreateTrackable(String trackableModelPath, Single x, Single y, Single facing)
        {
            return Natives._CreateTrackable(trackableModelPath, x, y, facing);
        }
        
        //native CreateQuest takes nothing returns quest
        public delegate JassQuest CreateQuestPrototype();
        private static CreateQuestPrototype _CreateQuest;
        public static JassQuest CreateQuest()
        {
            return Natives._CreateQuest();
        }
        
        //native DestroyQuest takes quest whichQuest returns nothing
        public delegate void DestroyQuestPrototype(JassQuest whichQuest);
        private static DestroyQuestPrototype _DestroyQuest;
        public static void DestroyQuest(JassQuest whichQuest)
        {
            Natives._DestroyQuest(whichQuest);
        }
        
        //native QuestSetTitle takes quest whichQuest, string title returns nothing
        public delegate void QuestSetTitlePrototype(JassQuest whichQuest, JassStringArg title);
        private static QuestSetTitlePrototype _QuestSetTitle;
        public static void QuestSetTitle(JassQuest whichQuest, String title)
        {
            Natives._QuestSetTitle(whichQuest, title);
        }
        
        //native QuestSetDescription takes quest whichQuest, string description returns nothing
        public delegate void QuestSetDescriptionPrototype(JassQuest whichQuest, JassStringArg description);
        private static QuestSetDescriptionPrototype _QuestSetDescription;
        public static void QuestSetDescription(JassQuest whichQuest, String description)
        {
            Natives._QuestSetDescription(whichQuest, description);
        }
        
        //native QuestSetIconPath takes quest whichQuest, string iconPath returns nothing
        public delegate void QuestSetIconPathPrototype(JassQuest whichQuest, JassStringArg iconPath);
        private static QuestSetIconPathPrototype _QuestSetIconPath;
        public static void QuestSetIconPath(JassQuest whichQuest, String iconPath)
        {
            Natives._QuestSetIconPath(whichQuest, iconPath);
        }
        
        //native QuestSetRequired takes quest whichQuest, boolean required returns nothing
        public delegate void QuestSetRequiredPrototype(JassQuest whichQuest, JassBoolean required);
        private static QuestSetRequiredPrototype _QuestSetRequired;
        public static void QuestSetRequired(JassQuest whichQuest, Boolean required)
        {
            Natives._QuestSetRequired(whichQuest, required);
        }
        
        //native QuestSetCompleted takes quest whichQuest, boolean completed returns nothing
        public delegate void QuestSetCompletedPrototype(JassQuest whichQuest, JassBoolean completed);
        private static QuestSetCompletedPrototype _QuestSetCompleted;
        public static void QuestSetCompleted(JassQuest whichQuest, Boolean completed)
        {
            Natives._QuestSetCompleted(whichQuest, completed);
        }
        
        //native QuestSetDiscovered takes quest whichQuest, boolean discovered returns nothing
        public delegate void QuestSetDiscoveredPrototype(JassQuest whichQuest, JassBoolean discovered);
        private static QuestSetDiscoveredPrototype _QuestSetDiscovered;
        public static void QuestSetDiscovered(JassQuest whichQuest, Boolean discovered)
        {
            Natives._QuestSetDiscovered(whichQuest, discovered);
        }
        
        //native QuestSetFailed takes quest whichQuest, boolean failed returns nothing
        public delegate void QuestSetFailedPrototype(JassQuest whichQuest, JassBoolean failed);
        private static QuestSetFailedPrototype _QuestSetFailed;
        public static void QuestSetFailed(JassQuest whichQuest, Boolean failed)
        {
            Natives._QuestSetFailed(whichQuest, failed);
        }
        
        //native QuestSetEnabled takes quest whichQuest, boolean enabled returns nothing
        public delegate void QuestSetEnabledPrototype(JassQuest whichQuest, JassBoolean enabled);
        private static QuestSetEnabledPrototype _QuestSetEnabled;
        public static void QuestSetEnabled(JassQuest whichQuest, Boolean enabled)
        {
            Natives._QuestSetEnabled(whichQuest, enabled);
        }
        
        //native IsQuestRequired takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestRequiredPrototype(JassQuest whichQuest);
        private static IsQuestRequiredPrototype _IsQuestRequired;
        public static Boolean IsQuestRequired(JassQuest whichQuest)
        {
            return Natives._IsQuestRequired(whichQuest);
        }
        
        //native IsQuestCompleted takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestCompletedPrototype(JassQuest whichQuest);
        private static IsQuestCompletedPrototype _IsQuestCompleted;
        public static Boolean IsQuestCompleted(JassQuest whichQuest)
        {
            return Natives._IsQuestCompleted(whichQuest);
        }
        
        //native IsQuestDiscovered takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestDiscoveredPrototype(JassQuest whichQuest);
        private static IsQuestDiscoveredPrototype _IsQuestDiscovered;
        public static Boolean IsQuestDiscovered(JassQuest whichQuest)
        {
            return Natives._IsQuestDiscovered(whichQuest);
        }
        
        //native IsQuestFailed takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestFailedPrototype(JassQuest whichQuest);
        private static IsQuestFailedPrototype _IsQuestFailed;
        public static Boolean IsQuestFailed(JassQuest whichQuest)
        {
            return Natives._IsQuestFailed(whichQuest);
        }
        
        //native IsQuestEnabled takes quest whichQuest returns boolean
        public delegate JassBoolean IsQuestEnabledPrototype(JassQuest whichQuest);
        private static IsQuestEnabledPrototype _IsQuestEnabled;
        public static Boolean IsQuestEnabled(JassQuest whichQuest)
        {
            return Natives._IsQuestEnabled(whichQuest);
        }
        
        //native QuestCreateItem takes quest whichQuest returns questitem
        public delegate JassQuestItem QuestCreateItemPrototype(JassQuest whichQuest);
        private static QuestCreateItemPrototype _QuestCreateItem;
        public static JassQuestItem QuestCreateItem(JassQuest whichQuest)
        {
            return Natives._QuestCreateItem(whichQuest);
        }
        
        //native QuestItemSetDescription takes questitem whichQuestItem, string description returns nothing
        public delegate void QuestItemSetDescriptionPrototype(JassQuestItem whichQuestItem, JassStringArg description);
        private static QuestItemSetDescriptionPrototype _QuestItemSetDescription;
        public static void QuestItemSetDescription(JassQuestItem whichQuestItem, String description)
        {
            Natives._QuestItemSetDescription(whichQuestItem, description);
        }
        
        //native QuestItemSetCompleted takes questitem whichQuestItem, boolean completed returns nothing
        public delegate void QuestItemSetCompletedPrototype(JassQuestItem whichQuestItem, JassBoolean completed);
        private static QuestItemSetCompletedPrototype _QuestItemSetCompleted;
        public static void QuestItemSetCompleted(JassQuestItem whichQuestItem, Boolean completed)
        {
            Natives._QuestItemSetCompleted(whichQuestItem, completed);
        }
        
        //native IsQuestItemCompleted takes questitem whichQuestItem returns boolean
        public delegate JassBoolean IsQuestItemCompletedPrototype(JassQuestItem whichQuestItem);
        private static IsQuestItemCompletedPrototype _IsQuestItemCompleted;
        public static Boolean IsQuestItemCompleted(JassQuestItem whichQuestItem)
        {
            return Natives._IsQuestItemCompleted(whichQuestItem);
        }
        
        //native CreateDefeatCondition takes nothing returns defeatcondition
        public delegate JassDefeatCondition CreateDefeatConditionPrototype();
        private static CreateDefeatConditionPrototype _CreateDefeatCondition;
        public static JassDefeatCondition CreateDefeatCondition()
        {
            return Natives._CreateDefeatCondition();
        }
        
        //native DestroyDefeatCondition takes defeatcondition whichCondition returns nothing
        public delegate void DestroyDefeatConditionPrototype(JassDefeatCondition whichCondition);
        private static DestroyDefeatConditionPrototype _DestroyDefeatCondition;
        public static void DestroyDefeatCondition(JassDefeatCondition whichCondition)
        {
            Natives._DestroyDefeatCondition(whichCondition);
        }
        
        //native DefeatConditionSetDescription takes defeatcondition whichCondition, string description returns nothing
        public delegate void DefeatConditionSetDescriptionPrototype(JassDefeatCondition whichCondition, JassStringArg description);
        private static DefeatConditionSetDescriptionPrototype _DefeatConditionSetDescription;
        public static void DefeatConditionSetDescription(JassDefeatCondition whichCondition, String description)
        {
            Natives._DefeatConditionSetDescription(whichCondition, description);
        }
        
        //native FlashQuestDialogButton takes nothing returns nothing
        public delegate void FlashQuestDialogButtonPrototype();
        private static FlashQuestDialogButtonPrototype _FlashQuestDialogButton;
        public static void FlashQuestDialogButton()
        {
            Natives._FlashQuestDialogButton();
        }
        
        //native ForceQuestDialogUpdate takes nothing returns nothing
        public delegate void ForceQuestDialogUpdatePrototype();
        private static ForceQuestDialogUpdatePrototype _ForceQuestDialogUpdate;
        public static void ForceQuestDialogUpdate()
        {
            Natives._ForceQuestDialogUpdate();
        }
        
        //native CreateTimerDialog takes timer t returns timerdialog
        public delegate JassTimerDialog CreateTimerDialogPrototype(JassTimer t);
        private static CreateTimerDialogPrototype _CreateTimerDialog;
        public static JassTimerDialog CreateTimerDialog(JassTimer t)
        {
            return Natives._CreateTimerDialog(t);
        }
        
        //native DestroyTimerDialog takes timerdialog whichDialog returns nothing
        public delegate void DestroyTimerDialogPrototype(JassTimerDialog whichDialog);
        private static DestroyTimerDialogPrototype _DestroyTimerDialog;
        public static void DestroyTimerDialog(JassTimerDialog whichDialog)
        {
            Natives._DestroyTimerDialog(whichDialog);
        }
        
        //native TimerDialogSetTitle takes timerdialog whichDialog, string title returns nothing
        public delegate void TimerDialogSetTitlePrototype(JassTimerDialog whichDialog, JassStringArg title);
        private static TimerDialogSetTitlePrototype _TimerDialogSetTitle;
        public static void TimerDialogSetTitle(JassTimerDialog whichDialog, String title)
        {
            Natives._TimerDialogSetTitle(whichDialog, title);
        }
        
        //native TimerDialogSetTitleColor takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void TimerDialogSetTitleColorPrototype(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static TimerDialogSetTitleColorPrototype _TimerDialogSetTitleColor;
        public static void TimerDialogSetTitleColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._TimerDialogSetTitleColor(whichDialog, red, green, blue, alpha);
        }
        
        //native TimerDialogSetTimeColor takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void TimerDialogSetTimeColorPrototype(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static TimerDialogSetTimeColorPrototype _TimerDialogSetTimeColor;
        public static void TimerDialogSetTimeColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._TimerDialogSetTimeColor(whichDialog, red, green, blue, alpha);
        }
        
        //native TimerDialogSetSpeed takes timerdialog whichDialog, real speedMultFactor returns nothing
        public delegate void TimerDialogSetSpeedPrototype(JassTimerDialog whichDialog, JassRealArg speedMultFactor);
        private static TimerDialogSetSpeedPrototype _TimerDialogSetSpeed;
        public static void TimerDialogSetSpeed(JassTimerDialog whichDialog, Single speedMultFactor)
        {
            Natives._TimerDialogSetSpeed(whichDialog, speedMultFactor);
        }
        
        //native TimerDialogDisplay takes timerdialog whichDialog, boolean display returns nothing
        public delegate void TimerDialogDisplayPrototype(JassTimerDialog whichDialog, JassBoolean display);
        private static TimerDialogDisplayPrototype _TimerDialogDisplay;
        public static void TimerDialogDisplay(JassTimerDialog whichDialog, Boolean display)
        {
            Natives._TimerDialogDisplay(whichDialog, display);
        }
        
        //native IsTimerDialogDisplayed takes timerdialog whichDialog returns boolean
        public delegate JassBoolean IsTimerDialogDisplayedPrototype(JassTimerDialog whichDialog);
        private static IsTimerDialogDisplayedPrototype _IsTimerDialogDisplayed;
        public static Boolean IsTimerDialogDisplayed(JassTimerDialog whichDialog)
        {
            return Natives._IsTimerDialogDisplayed(whichDialog);
        }
        
        //native TimerDialogSetRealTimeRemaining takes timerdialog whichDialog, real timeRemaining returns nothing
        public delegate void TimerDialogSetRealTimeRemainingPrototype(JassTimerDialog whichDialog, JassRealArg timeRemaining);
        private static TimerDialogSetRealTimeRemainingPrototype _TimerDialogSetRealTimeRemaining;
        public static void TimerDialogSetRealTimeRemaining(JassTimerDialog whichDialog, Single timeRemaining)
        {
            Natives._TimerDialogSetRealTimeRemaining(whichDialog, timeRemaining);
        }
        
        //native CreateLeaderboard takes nothing returns leaderboard
        public delegate JassLeaderboard CreateLeaderboardPrototype();
        private static CreateLeaderboardPrototype _CreateLeaderboard;
        public static JassLeaderboard CreateLeaderboard()
        {
            return Natives._CreateLeaderboard();
        }
        
        //native DestroyLeaderboard takes leaderboard lb returns nothing
        public delegate void DestroyLeaderboardPrototype(JassLeaderboard lb);
        private static DestroyLeaderboardPrototype _DestroyLeaderboard;
        public static void DestroyLeaderboard(JassLeaderboard lb)
        {
            Natives._DestroyLeaderboard(lb);
        }
        
        //native LeaderboardDisplay takes leaderboard lb, boolean show returns nothing
        public delegate void LeaderboardDisplayPrototype(JassLeaderboard lb, JassBoolean show);
        private static LeaderboardDisplayPrototype _LeaderboardDisplay;
        public static void LeaderboardDisplay(JassLeaderboard lb, Boolean show)
        {
            Natives._LeaderboardDisplay(lb, show);
        }
        
        //native IsLeaderboardDisplayed takes leaderboard lb returns boolean
        public delegate JassBoolean IsLeaderboardDisplayedPrototype(JassLeaderboard lb);
        private static IsLeaderboardDisplayedPrototype _IsLeaderboardDisplayed;
        public static Boolean IsLeaderboardDisplayed(JassLeaderboard lb)
        {
            return Natives._IsLeaderboardDisplayed(lb);
        }
        
        //native LeaderboardGetItemCount takes leaderboard lb returns integer
        public delegate JassInteger LeaderboardGetItemCountPrototype(JassLeaderboard lb);
        private static LeaderboardGetItemCountPrototype _LeaderboardGetItemCount;
        public static JassInteger LeaderboardGetItemCount(JassLeaderboard lb)
        {
            return Natives._LeaderboardGetItemCount(lb);
        }
        
        //native LeaderboardSetSizeByItemCount takes leaderboard lb, integer count returns nothing
        public delegate void LeaderboardSetSizeByItemCountPrototype(JassLeaderboard lb, JassInteger count);
        private static LeaderboardSetSizeByItemCountPrototype _LeaderboardSetSizeByItemCount;
        public static void LeaderboardSetSizeByItemCount(JassLeaderboard lb, JassInteger count)
        {
            Natives._LeaderboardSetSizeByItemCount(lb, count);
        }
        
        //native LeaderboardAddItem takes leaderboard lb, string label, integer value, player p returns nothing
        public delegate void LeaderboardAddItemPrototype(JassLeaderboard lb, JassStringArg label, JassInteger value, JassPlayer p);
        private static LeaderboardAddItemPrototype _LeaderboardAddItem;
        public static void LeaderboardAddItem(JassLeaderboard lb, String label, JassInteger value, JassPlayer p)
        {
            Natives._LeaderboardAddItem(lb, label, value, p);
        }
        
        //native LeaderboardRemoveItem takes leaderboard lb, integer index returns nothing
        public delegate void LeaderboardRemoveItemPrototype(JassLeaderboard lb, JassInteger index);
        private static LeaderboardRemoveItemPrototype _LeaderboardRemoveItem;
        public static void LeaderboardRemoveItem(JassLeaderboard lb, JassInteger index)
        {
            Natives._LeaderboardRemoveItem(lb, index);
        }
        
        //native LeaderboardRemovePlayerItem takes leaderboard lb, player p returns nothing
        public delegate void LeaderboardRemovePlayerItemPrototype(JassLeaderboard lb, JassPlayer p);
        private static LeaderboardRemovePlayerItemPrototype _LeaderboardRemovePlayerItem;
        public static void LeaderboardRemovePlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            Natives._LeaderboardRemovePlayerItem(lb, p);
        }
        
        //native LeaderboardClear takes leaderboard lb returns nothing
        public delegate void LeaderboardClearPrototype(JassLeaderboard lb);
        private static LeaderboardClearPrototype _LeaderboardClear;
        public static void LeaderboardClear(JassLeaderboard lb)
        {
            Natives._LeaderboardClear(lb);
        }
        
        //native LeaderboardSortItemsByValue takes leaderboard lb, boolean ascending returns nothing
        public delegate void LeaderboardSortItemsByValuePrototype(JassLeaderboard lb, JassBoolean ascending);
        private static LeaderboardSortItemsByValuePrototype _LeaderboardSortItemsByValue;
        public static void LeaderboardSortItemsByValue(JassLeaderboard lb, Boolean ascending)
        {
            Natives._LeaderboardSortItemsByValue(lb, ascending);
        }
        
        //native LeaderboardSortItemsByPlayer takes leaderboard lb, boolean ascending returns nothing
        public delegate void LeaderboardSortItemsByPlayerPrototype(JassLeaderboard lb, JassBoolean ascending);
        private static LeaderboardSortItemsByPlayerPrototype _LeaderboardSortItemsByPlayer;
        public static void LeaderboardSortItemsByPlayer(JassLeaderboard lb, Boolean ascending)
        {
            Natives._LeaderboardSortItemsByPlayer(lb, ascending);
        }
        
        //native LeaderboardSortItemsByLabel takes leaderboard lb, boolean ascending returns nothing
        public delegate void LeaderboardSortItemsByLabelPrototype(JassLeaderboard lb, JassBoolean ascending);
        private static LeaderboardSortItemsByLabelPrototype _LeaderboardSortItemsByLabel;
        public static void LeaderboardSortItemsByLabel(JassLeaderboard lb, Boolean ascending)
        {
            Natives._LeaderboardSortItemsByLabel(lb, ascending);
        }
        
        //native LeaderboardHasPlayerItem takes leaderboard lb, player p returns boolean
        public delegate JassBoolean LeaderboardHasPlayerItemPrototype(JassLeaderboard lb, JassPlayer p);
        private static LeaderboardHasPlayerItemPrototype _LeaderboardHasPlayerItem;
        public static Boolean LeaderboardHasPlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            return Natives._LeaderboardHasPlayerItem(lb, p);
        }
        
        //native LeaderboardGetPlayerIndex takes leaderboard lb, player p returns integer
        public delegate JassInteger LeaderboardGetPlayerIndexPrototype(JassLeaderboard lb, JassPlayer p);
        private static LeaderboardGetPlayerIndexPrototype _LeaderboardGetPlayerIndex;
        public static JassInteger LeaderboardGetPlayerIndex(JassLeaderboard lb, JassPlayer p)
        {
            return Natives._LeaderboardGetPlayerIndex(lb, p);
        }
        
        //native LeaderboardSetLabel takes leaderboard lb, string label returns nothing
        public delegate void LeaderboardSetLabelPrototype(JassLeaderboard lb, JassStringArg label);
        private static LeaderboardSetLabelPrototype _LeaderboardSetLabel;
        public static void LeaderboardSetLabel(JassLeaderboard lb, String label)
        {
            Natives._LeaderboardSetLabel(lb, label);
        }
        
        //native LeaderboardGetLabelText takes leaderboard lb returns string
        public delegate JassStringRet LeaderboardGetLabelTextPrototype(JassLeaderboard lb);
        private static LeaderboardGetLabelTextPrototype _LeaderboardGetLabelText;
        public static String LeaderboardGetLabelText(JassLeaderboard lb)
        {
            return Natives._LeaderboardGetLabelText(lb);
        }
        
        //native PlayerSetLeaderboard takes player toPlayer, leaderboard lb returns nothing
        public delegate void PlayerSetLeaderboardPrototype(JassPlayer toPlayer, JassLeaderboard lb);
        private static PlayerSetLeaderboardPrototype _PlayerSetLeaderboard;
        public static void PlayerSetLeaderboard(JassPlayer toPlayer, JassLeaderboard lb)
        {
            Natives._PlayerSetLeaderboard(toPlayer, lb);
        }
        
        //native PlayerGetLeaderboard takes player toPlayer returns leaderboard
        public delegate JassLeaderboard PlayerGetLeaderboardPrototype(JassPlayer toPlayer);
        private static PlayerGetLeaderboardPrototype _PlayerGetLeaderboard;
        public static JassLeaderboard PlayerGetLeaderboard(JassPlayer toPlayer)
        {
            return Natives._PlayerGetLeaderboard(toPlayer);
        }
        
        //native LeaderboardSetLabelColor takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void LeaderboardSetLabelColorPrototype(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static LeaderboardSetLabelColorPrototype _LeaderboardSetLabelColor;
        public static void LeaderboardSetLabelColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._LeaderboardSetLabelColor(lb, red, green, blue, alpha);
        }
        
        //native LeaderboardSetValueColor takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void LeaderboardSetValueColorPrototype(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static LeaderboardSetValueColorPrototype _LeaderboardSetValueColor;
        public static void LeaderboardSetValueColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._LeaderboardSetValueColor(lb, red, green, blue, alpha);
        }
        
        //native LeaderboardSetStyle takes leaderboard lb, boolean showLabel, boolean showNames, boolean showValues, boolean showIcons returns nothing
        public delegate void LeaderboardSetStylePrototype(JassLeaderboard lb, JassBoolean showLabel, JassBoolean showNames, JassBoolean showValues, JassBoolean showIcons);
        private static LeaderboardSetStylePrototype _LeaderboardSetStyle;
        public static void LeaderboardSetStyle(JassLeaderboard lb, Boolean showLabel, Boolean showNames, Boolean showValues, Boolean showIcons)
        {
            Natives._LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);
        }
        
        //native LeaderboardSetItemValue takes leaderboard lb, integer whichItem, integer val returns nothing
        public delegate void LeaderboardSetItemValuePrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger val);
        private static LeaderboardSetItemValuePrototype _LeaderboardSetItemValue;
        public static void LeaderboardSetItemValue(JassLeaderboard lb, JassInteger whichItem, JassInteger val)
        {
            Natives._LeaderboardSetItemValue(lb, whichItem, val);
        }
        
        //native LeaderboardSetItemLabel takes leaderboard lb, integer whichItem, string val returns nothing
        public delegate void LeaderboardSetItemLabelPrototype(JassLeaderboard lb, JassInteger whichItem, JassStringArg val);
        private static LeaderboardSetItemLabelPrototype _LeaderboardSetItemLabel;
        public static void LeaderboardSetItemLabel(JassLeaderboard lb, JassInteger whichItem, String val)
        {
            Natives._LeaderboardSetItemLabel(lb, whichItem, val);
        }
        
        //native LeaderboardSetItemStyle takes leaderboard lb, integer whichItem, boolean showLabel, boolean showValue, boolean showIcon returns nothing
        public delegate void LeaderboardSetItemStylePrototype(JassLeaderboard lb, JassInteger whichItem, JassBoolean showLabel, JassBoolean showValue, JassBoolean showIcon);
        private static LeaderboardSetItemStylePrototype _LeaderboardSetItemStyle;
        public static void LeaderboardSetItemStyle(JassLeaderboard lb, JassInteger whichItem, Boolean showLabel, Boolean showValue, Boolean showIcon)
        {
            Natives._LeaderboardSetItemStyle(lb, whichItem, showLabel, showValue, showIcon);
        }
        
        //native LeaderboardSetItemLabelColor takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void LeaderboardSetItemLabelColorPrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static LeaderboardSetItemLabelColorPrototype _LeaderboardSetItemLabelColor;
        public static void LeaderboardSetItemLabelColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._LeaderboardSetItemLabelColor(lb, whichItem, red, green, blue, alpha);
        }
        
        //native LeaderboardSetItemValueColor takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void LeaderboardSetItemValueColorPrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static LeaderboardSetItemValueColorPrototype _LeaderboardSetItemValueColor;
        public static void LeaderboardSetItemValueColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._LeaderboardSetItemValueColor(lb, whichItem, red, green, blue, alpha);
        }
        
        //native CreateMultiboard takes nothing returns multiboard
        public delegate JassMultiboard CreateMultiboardPrototype();
        private static CreateMultiboardPrototype _CreateMultiboard;
        public static JassMultiboard CreateMultiboard()
        {
            return Natives._CreateMultiboard();
        }
        
        //native DestroyMultiboard takes multiboard lb returns nothing
        public delegate void DestroyMultiboardPrototype(JassMultiboard lb);
        private static DestroyMultiboardPrototype _DestroyMultiboard;
        public static void DestroyMultiboard(JassMultiboard lb)
        {
            Natives._DestroyMultiboard(lb);
        }
        
        //native MultiboardDisplay takes multiboard lb, boolean show returns nothing
        public delegate void MultiboardDisplayPrototype(JassMultiboard lb, JassBoolean show);
        private static MultiboardDisplayPrototype _MultiboardDisplay;
        public static void MultiboardDisplay(JassMultiboard lb, Boolean show)
        {
            Natives._MultiboardDisplay(lb, show);
        }
        
        //native IsMultiboardDisplayed takes multiboard lb returns boolean
        public delegate JassBoolean IsMultiboardDisplayedPrototype(JassMultiboard lb);
        private static IsMultiboardDisplayedPrototype _IsMultiboardDisplayed;
        public static Boolean IsMultiboardDisplayed(JassMultiboard lb)
        {
            return Natives._IsMultiboardDisplayed(lb);
        }
        
        //native MultiboardMinimize takes multiboard lb, boolean minimize returns nothing
        public delegate void MultiboardMinimizePrototype(JassMultiboard lb, JassBoolean minimize);
        private static MultiboardMinimizePrototype _MultiboardMinimize;
        public static void MultiboardMinimize(JassMultiboard lb, Boolean minimize)
        {
            Natives._MultiboardMinimize(lb, minimize);
        }
        
        //native IsMultiboardMinimized takes multiboard lb returns boolean
        public delegate JassBoolean IsMultiboardMinimizedPrototype(JassMultiboard lb);
        private static IsMultiboardMinimizedPrototype _IsMultiboardMinimized;
        public static Boolean IsMultiboardMinimized(JassMultiboard lb)
        {
            return Natives._IsMultiboardMinimized(lb);
        }
        
        //native MultiboardClear takes multiboard lb returns nothing
        public delegate void MultiboardClearPrototype(JassMultiboard lb);
        private static MultiboardClearPrototype _MultiboardClear;
        public static void MultiboardClear(JassMultiboard lb)
        {
            Natives._MultiboardClear(lb);
        }
        
        //native MultiboardSetTitleText takes multiboard lb, string label returns nothing
        public delegate void MultiboardSetTitleTextPrototype(JassMultiboard lb, JassStringArg label);
        private static MultiboardSetTitleTextPrototype _MultiboardSetTitleText;
        public static void MultiboardSetTitleText(JassMultiboard lb, String label)
        {
            Natives._MultiboardSetTitleText(lb, label);
        }
        
        //native MultiboardGetTitleText takes multiboard lb returns string
        public delegate JassStringRet MultiboardGetTitleTextPrototype(JassMultiboard lb);
        private static MultiboardGetTitleTextPrototype _MultiboardGetTitleText;
        public static String MultiboardGetTitleText(JassMultiboard lb)
        {
            return Natives._MultiboardGetTitleText(lb);
        }
        
        //native MultiboardSetTitleTextColor takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void MultiboardSetTitleTextColorPrototype(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static MultiboardSetTitleTextColorPrototype _MultiboardSetTitleTextColor;
        public static void MultiboardSetTitleTextColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._MultiboardSetTitleTextColor(lb, red, green, blue, alpha);
        }
        
        //native MultiboardGetRowCount takes multiboard lb returns integer
        public delegate JassInteger MultiboardGetRowCountPrototype(JassMultiboard lb);
        private static MultiboardGetRowCountPrototype _MultiboardGetRowCount;
        public static JassInteger MultiboardGetRowCount(JassMultiboard lb)
        {
            return Natives._MultiboardGetRowCount(lb);
        }
        
        //native MultiboardGetColumnCount takes multiboard lb returns integer
        public delegate JassInteger MultiboardGetColumnCountPrototype(JassMultiboard lb);
        private static MultiboardGetColumnCountPrototype _MultiboardGetColumnCount;
        public static JassInteger MultiboardGetColumnCount(JassMultiboard lb)
        {
            return Natives._MultiboardGetColumnCount(lb);
        }
        
        //native MultiboardSetColumnCount takes multiboard lb, integer count returns nothing
        public delegate void MultiboardSetColumnCountPrototype(JassMultiboard lb, JassInteger count);
        private static MultiboardSetColumnCountPrototype _MultiboardSetColumnCount;
        public static void MultiboardSetColumnCount(JassMultiboard lb, JassInteger count)
        {
            Natives._MultiboardSetColumnCount(lb, count);
        }
        
        //native MultiboardSetRowCount takes multiboard lb, integer count returns nothing
        public delegate void MultiboardSetRowCountPrototype(JassMultiboard lb, JassInteger count);
        private static MultiboardSetRowCountPrototype _MultiboardSetRowCount;
        public static void MultiboardSetRowCount(JassMultiboard lb, JassInteger count)
        {
            Natives._MultiboardSetRowCount(lb, count);
        }
        
        //native MultiboardSetItemsStyle takes multiboard lb, boolean showValues, boolean showIcons returns nothing
        public delegate void MultiboardSetItemsStylePrototype(JassMultiboard lb, JassBoolean showValues, JassBoolean showIcons);
        private static MultiboardSetItemsStylePrototype _MultiboardSetItemsStyle;
        public static void MultiboardSetItemsStyle(JassMultiboard lb, Boolean showValues, Boolean showIcons)
        {
            Natives._MultiboardSetItemsStyle(lb, showValues, showIcons);
        }
        
        //native MultiboardSetItemsValue takes multiboard lb, string value returns nothing
        public delegate void MultiboardSetItemsValuePrototype(JassMultiboard lb, JassStringArg value);
        private static MultiboardSetItemsValuePrototype _MultiboardSetItemsValue;
        public static void MultiboardSetItemsValue(JassMultiboard lb, String value)
        {
            Natives._MultiboardSetItemsValue(lb, value);
        }
        
        //native MultiboardSetItemsValueColor takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void MultiboardSetItemsValueColorPrototype(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static MultiboardSetItemsValueColorPrototype _MultiboardSetItemsValueColor;
        public static void MultiboardSetItemsValueColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._MultiboardSetItemsValueColor(lb, red, green, blue, alpha);
        }
        
        //native MultiboardSetItemsWidth takes multiboard lb, real width returns nothing
        public delegate void MultiboardSetItemsWidthPrototype(JassMultiboard lb, JassRealArg width);
        private static MultiboardSetItemsWidthPrototype _MultiboardSetItemsWidth;
        public static void MultiboardSetItemsWidth(JassMultiboard lb, Single width)
        {
            Natives._MultiboardSetItemsWidth(lb, width);
        }
        
        //native MultiboardSetItemsIcon takes multiboard lb, string iconPath returns nothing
        public delegate void MultiboardSetItemsIconPrototype(JassMultiboard lb, JassStringArg iconPath);
        private static MultiboardSetItemsIconPrototype _MultiboardSetItemsIcon;
        public static void MultiboardSetItemsIcon(JassMultiboard lb, String iconPath)
        {
            Natives._MultiboardSetItemsIcon(lb, iconPath);
        }
        
        //native MultiboardGetItem takes multiboard lb, integer row, integer column returns multiboarditem
        public delegate JassMultiboardItem MultiboardGetItemPrototype(JassMultiboard lb, JassInteger row, JassInteger column);
        private static MultiboardGetItemPrototype _MultiboardGetItem;
        public static JassMultiboardItem MultiboardGetItem(JassMultiboard lb, JassInteger row, JassInteger column)
        {
            return Natives._MultiboardGetItem(lb, row, column);
        }
        
        //native MultiboardReleaseItem takes multiboarditem mbi returns nothing
        public delegate void MultiboardReleaseItemPrototype(JassMultiboardItem mbi);
        private static MultiboardReleaseItemPrototype _MultiboardReleaseItem;
        public static void MultiboardReleaseItem(JassMultiboardItem mbi)
        {
            Natives._MultiboardReleaseItem(mbi);
        }
        
        //native MultiboardSetItemStyle takes multiboarditem mbi, boolean showValue, boolean showIcon returns nothing
        public delegate void MultiboardSetItemStylePrototype(JassMultiboardItem mbi, JassBoolean showValue, JassBoolean showIcon);
        private static MultiboardSetItemStylePrototype _MultiboardSetItemStyle;
        public static void MultiboardSetItemStyle(JassMultiboardItem mbi, Boolean showValue, Boolean showIcon)
        {
            Natives._MultiboardSetItemStyle(mbi, showValue, showIcon);
        }
        
        //native MultiboardSetItemValue takes multiboarditem mbi, string val returns nothing
        public delegate void MultiboardSetItemValuePrototype(JassMultiboardItem mbi, JassStringArg val);
        private static MultiboardSetItemValuePrototype _MultiboardSetItemValue;
        public static void MultiboardSetItemValue(JassMultiboardItem mbi, String val)
        {
            Natives._MultiboardSetItemValue(mbi, val);
        }
        
        //native MultiboardSetItemValueColor takes multiboarditem mbi, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void MultiboardSetItemValueColorPrototype(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static MultiboardSetItemValueColorPrototype _MultiboardSetItemValueColor;
        public static void MultiboardSetItemValueColor(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._MultiboardSetItemValueColor(mbi, red, green, blue, alpha);
        }
        
        //native MultiboardSetItemWidth takes multiboarditem mbi, real width returns nothing
        public delegate void MultiboardSetItemWidthPrototype(JassMultiboardItem mbi, JassRealArg width);
        private static MultiboardSetItemWidthPrototype _MultiboardSetItemWidth;
        public static void MultiboardSetItemWidth(JassMultiboardItem mbi, Single width)
        {
            Natives._MultiboardSetItemWidth(mbi, width);
        }
        
        //native MultiboardSetItemIcon takes multiboarditem mbi, string iconFileName returns nothing
        public delegate void MultiboardSetItemIconPrototype(JassMultiboardItem mbi, JassStringArg iconFileName);
        private static MultiboardSetItemIconPrototype _MultiboardSetItemIcon;
        public static void MultiboardSetItemIcon(JassMultiboardItem mbi, String iconFileName)
        {
            Natives._MultiboardSetItemIcon(mbi, iconFileName);
        }
        
        //native MultiboardSuppressDisplay takes boolean flag returns nothing
        public delegate void MultiboardSuppressDisplayPrototype(JassBoolean flag);
        private static MultiboardSuppressDisplayPrototype _MultiboardSuppressDisplay;
        public static void MultiboardSuppressDisplay(Boolean flag)
        {
            Natives._MultiboardSuppressDisplay(flag);
        }
        
        //native SetCameraPosition takes real x, real y returns nothing
        public delegate void SetCameraPositionPrototype(JassRealArg x, JassRealArg y);
        private static SetCameraPositionPrototype _SetCameraPosition;
        public static void SetCameraPosition(Single x, Single y)
        {
            Natives._SetCameraPosition(x, y);
        }
        
        //native SetCameraQuickPosition takes real x, real y returns nothing
        public delegate void SetCameraQuickPositionPrototype(JassRealArg x, JassRealArg y);
        private static SetCameraQuickPositionPrototype _SetCameraQuickPosition;
        public static void SetCameraQuickPosition(Single x, Single y)
        {
            Natives._SetCameraQuickPosition(x, y);
        }
        
        //native SetCameraBounds takes real x1, real y1, real x2, real y2, real x3, real y3, real x4, real y4 returns nothing
        public delegate void SetCameraBoundsPrototype(JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2, JassRealArg x3, JassRealArg y3, JassRealArg x4, JassRealArg y4);
        private static SetCameraBoundsPrototype _SetCameraBounds;
        public static void SetCameraBounds(Single x1, Single y1, Single x2, Single y2, Single x3, Single y3, Single x4, Single y4)
        {
            Natives._SetCameraBounds(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        
        //native StopCamera takes nothing returns nothing
        public delegate void StopCameraPrototype();
        private static StopCameraPrototype _StopCamera;
        public static void StopCamera()
        {
            Natives._StopCamera();
        }
        
        //native ResetToGameCamera takes real duration returns nothing
        public delegate void ResetToGameCameraPrototype(JassRealArg duration);
        private static ResetToGameCameraPrototype _ResetToGameCamera;
        public static void ResetToGameCamera(Single duration)
        {
            Natives._ResetToGameCamera(duration);
        }
        
        //native PanCameraTo takes real x, real y returns nothing
        public delegate void PanCameraToPrototype(JassRealArg x, JassRealArg y);
        private static PanCameraToPrototype _PanCameraTo;
        public static void PanCameraTo(Single x, Single y)
        {
            Natives._PanCameraTo(x, y);
        }
        
        //native PanCameraToTimed takes real x, real y, real duration returns nothing
        public delegate void PanCameraToTimedPrototype(JassRealArg x, JassRealArg y, JassRealArg duration);
        private static PanCameraToTimedPrototype _PanCameraToTimed;
        public static void PanCameraToTimed(Single x, Single y, Single duration)
        {
            Natives._PanCameraToTimed(x, y, duration);
        }
        
        //native PanCameraToWithZ takes real x, real y, real zOffsetDest returns nothing
        public delegate void PanCameraToWithZPrototype(JassRealArg x, JassRealArg y, JassRealArg zOffsetDest);
        private static PanCameraToWithZPrototype _PanCameraToWithZ;
        public static void PanCameraToWithZ(Single x, Single y, Single zOffsetDest)
        {
            Natives._PanCameraToWithZ(x, y, zOffsetDest);
        }
        
        //native PanCameraToTimedWithZ takes real x, real y, real zOffsetDest, real duration returns nothing
        public delegate void PanCameraToTimedWithZPrototype(JassRealArg x, JassRealArg y, JassRealArg zOffsetDest, JassRealArg duration);
        private static PanCameraToTimedWithZPrototype _PanCameraToTimedWithZ;
        public static void PanCameraToTimedWithZ(Single x, Single y, Single zOffsetDest, Single duration)
        {
            Natives._PanCameraToTimedWithZ(x, y, zOffsetDest, duration);
        }
        
        //native SetCinematicCamera takes string cameraModelFile returns nothing
        public delegate void SetCinematicCameraPrototype(JassStringArg cameraModelFile);
        private static SetCinematicCameraPrototype _SetCinematicCamera;
        public static void SetCinematicCamera(String cameraModelFile)
        {
            Natives._SetCinematicCamera(cameraModelFile);
        }
        
        //native SetCameraRotateMode takes real x, real y, real radiansToSweep, real duration returns nothing
        public delegate void SetCameraRotateModePrototype(JassRealArg x, JassRealArg y, JassRealArg radiansToSweep, JassRealArg duration);
        private static SetCameraRotateModePrototype _SetCameraRotateMode;
        public static void SetCameraRotateMode(Single x, Single y, Single radiansToSweep, Single duration)
        {
            Natives._SetCameraRotateMode(x, y, radiansToSweep, duration);
        }
        
        //native SetCameraField takes camerafield whichField, real value, real duration returns nothing
        public delegate void SetCameraFieldPrototype(JassCameraField whichField, JassRealArg value, JassRealArg duration);
        private static SetCameraFieldPrototype _SetCameraField;
        public static void SetCameraField(JassCameraField whichField, Single value, Single duration)
        {
            Natives._SetCameraField(whichField, value, duration);
        }
        
        //native AdjustCameraField takes camerafield whichField, real offset, real duration returns nothing
        public delegate void AdjustCameraFieldPrototype(JassCameraField whichField, JassRealArg offset, JassRealArg duration);
        private static AdjustCameraFieldPrototype _AdjustCameraField;
        public static void AdjustCameraField(JassCameraField whichField, Single offset, Single duration)
        {
            Natives._AdjustCameraField(whichField, offset, duration);
        }
        
        //native SetCameraTargetController takes unit whichUnit, real xoffset, real yoffset, boolean inheritOrientation returns nothing
        public delegate void SetCameraTargetControllerPrototype(JassUnit whichUnit, JassRealArg xoffset, JassRealArg yoffset, JassBoolean inheritOrientation);
        private static SetCameraTargetControllerPrototype _SetCameraTargetController;
        public static void SetCameraTargetController(JassUnit whichUnit, Single xoffset, Single yoffset, Boolean inheritOrientation)
        {
            Natives._SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);
        }
        
        //native SetCameraOrientController takes unit whichUnit, real xoffset, real yoffset returns nothing
        public delegate void SetCameraOrientControllerPrototype(JassUnit whichUnit, JassRealArg xoffset, JassRealArg yoffset);
        private static SetCameraOrientControllerPrototype _SetCameraOrientController;
        public static void SetCameraOrientController(JassUnit whichUnit, Single xoffset, Single yoffset)
        {
            Natives._SetCameraOrientController(whichUnit, xoffset, yoffset);
        }
        
        //native CreateCameraSetup takes nothing returns camerasetup
        public delegate JassCameraSetup CreateCameraSetupPrototype();
        private static CreateCameraSetupPrototype _CreateCameraSetup;
        public static JassCameraSetup CreateCameraSetup()
        {
            return Natives._CreateCameraSetup();
        }
        
        //native CameraSetupSetField takes camerasetup whichSetup, camerafield whichField, real value, real duration returns nothing
        public delegate void CameraSetupSetFieldPrototype(JassCameraSetup whichSetup, JassCameraField whichField, JassRealArg value, JassRealArg duration);
        private static CameraSetupSetFieldPrototype _CameraSetupSetField;
        public static void CameraSetupSetField(JassCameraSetup whichSetup, JassCameraField whichField, Single value, Single duration)
        {
            Natives._CameraSetupSetField(whichSetup, whichField, value, duration);
        }
        
        //native CameraSetupGetField takes camerasetup whichSetup, camerafield whichField returns real
        public delegate JassRealRet CameraSetupGetFieldPrototype(JassCameraSetup whichSetup, JassCameraField whichField);
        private static CameraSetupGetFieldPrototype _CameraSetupGetField;
        public static Single CameraSetupGetField(JassCameraSetup whichSetup, JassCameraField whichField)
        {
            return Natives._CameraSetupGetField(whichSetup, whichField);
        }
        
        //native CameraSetupSetDestPosition takes camerasetup whichSetup, real x, real y, real duration returns nothing
        public delegate void CameraSetupSetDestPositionPrototype(JassCameraSetup whichSetup, JassRealArg x, JassRealArg y, JassRealArg duration);
        private static CameraSetupSetDestPositionPrototype _CameraSetupSetDestPosition;
        public static void CameraSetupSetDestPosition(JassCameraSetup whichSetup, Single x, Single y, Single duration)
        {
            Natives._CameraSetupSetDestPosition(whichSetup, x, y, duration);
        }
        
        //native CameraSetupGetDestPositionLoc takes camerasetup whichSetup returns location
        public delegate JassLocation CameraSetupGetDestPositionLocPrototype(JassCameraSetup whichSetup);
        private static CameraSetupGetDestPositionLocPrototype _CameraSetupGetDestPositionLoc;
        public static JassLocation CameraSetupGetDestPositionLoc(JassCameraSetup whichSetup)
        {
            return Natives._CameraSetupGetDestPositionLoc(whichSetup);
        }
        
        //native CameraSetupGetDestPositionX takes camerasetup whichSetup returns real
        public delegate JassRealRet CameraSetupGetDestPositionXPrototype(JassCameraSetup whichSetup);
        private static CameraSetupGetDestPositionXPrototype _CameraSetupGetDestPositionX;
        public static Single CameraSetupGetDestPositionX(JassCameraSetup whichSetup)
        {
            return Natives._CameraSetupGetDestPositionX(whichSetup);
        }
        
        //native CameraSetupGetDestPositionY takes camerasetup whichSetup returns real
        public delegate JassRealRet CameraSetupGetDestPositionYPrototype(JassCameraSetup whichSetup);
        private static CameraSetupGetDestPositionYPrototype _CameraSetupGetDestPositionY;
        public static Single CameraSetupGetDestPositionY(JassCameraSetup whichSetup)
        {
            return Natives._CameraSetupGetDestPositionY(whichSetup);
        }
        
        //native CameraSetupApply takes camerasetup whichSetup, boolean doPan, boolean panTimed returns nothing
        public delegate void CameraSetupApplyPrototype(JassCameraSetup whichSetup, JassBoolean doPan, JassBoolean panTimed);
        private static CameraSetupApplyPrototype _CameraSetupApply;
        public static void CameraSetupApply(JassCameraSetup whichSetup, Boolean doPan, Boolean panTimed)
        {
            Natives._CameraSetupApply(whichSetup, doPan, panTimed);
        }
        
        //native CameraSetupApplyWithZ takes camerasetup whichSetup, real zDestOffset returns nothing
        public delegate void CameraSetupApplyWithZPrototype(JassCameraSetup whichSetup, JassRealArg zDestOffset);
        private static CameraSetupApplyWithZPrototype _CameraSetupApplyWithZ;
        public static void CameraSetupApplyWithZ(JassCameraSetup whichSetup, Single zDestOffset)
        {
            Natives._CameraSetupApplyWithZ(whichSetup, zDestOffset);
        }
        
        //native CameraSetupApplyForceDuration takes camerasetup whichSetup, boolean doPan, real forceDuration returns nothing
        public delegate void CameraSetupApplyForceDurationPrototype(JassCameraSetup whichSetup, JassBoolean doPan, JassRealArg forceDuration);
        private static CameraSetupApplyForceDurationPrototype _CameraSetupApplyForceDuration;
        public static void CameraSetupApplyForceDuration(JassCameraSetup whichSetup, Boolean doPan, Single forceDuration)
        {
            Natives._CameraSetupApplyForceDuration(whichSetup, doPan, forceDuration);
        }
        
        //native CameraSetupApplyForceDurationWithZ takes camerasetup whichSetup, real zDestOffset, real forceDuration returns nothing
        public delegate void CameraSetupApplyForceDurationWithZPrototype(JassCameraSetup whichSetup, JassRealArg zDestOffset, JassRealArg forceDuration);
        private static CameraSetupApplyForceDurationWithZPrototype _CameraSetupApplyForceDurationWithZ;
        public static void CameraSetupApplyForceDurationWithZ(JassCameraSetup whichSetup, Single zDestOffset, Single forceDuration)
        {
            Natives._CameraSetupApplyForceDurationWithZ(whichSetup, zDestOffset, forceDuration);
        }
        
        //native CameraSetTargetNoise takes real mag, real velocity returns nothing
        public delegate void CameraSetTargetNoisePrototype(JassRealArg mag, JassRealArg velocity);
        private static CameraSetTargetNoisePrototype _CameraSetTargetNoise;
        public static void CameraSetTargetNoise(Single mag, Single velocity)
        {
            Natives._CameraSetTargetNoise(mag, velocity);
        }
        
        //native CameraSetSourceNoise takes real mag, real velocity returns nothing
        public delegate void CameraSetSourceNoisePrototype(JassRealArg mag, JassRealArg velocity);
        private static CameraSetSourceNoisePrototype _CameraSetSourceNoise;
        public static void CameraSetSourceNoise(Single mag, Single velocity)
        {
            Natives._CameraSetSourceNoise(mag, velocity);
        }
        
        //native CameraSetTargetNoiseEx takes real mag, real velocity, boolean vertOnly returns nothing
        public delegate void CameraSetTargetNoiseExPrototype(JassRealArg mag, JassRealArg velocity, JassBoolean vertOnly);
        private static CameraSetTargetNoiseExPrototype _CameraSetTargetNoiseEx;
        public static void CameraSetTargetNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            Natives._CameraSetTargetNoiseEx(mag, velocity, vertOnly);
        }
        
        //native CameraSetSourceNoiseEx takes real mag, real velocity, boolean vertOnly returns nothing
        public delegate void CameraSetSourceNoiseExPrototype(JassRealArg mag, JassRealArg velocity, JassBoolean vertOnly);
        private static CameraSetSourceNoiseExPrototype _CameraSetSourceNoiseEx;
        public static void CameraSetSourceNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            Natives._CameraSetSourceNoiseEx(mag, velocity, vertOnly);
        }
        
        //native CameraSetSmoothingFactor takes real factor returns nothing
        public delegate void CameraSetSmoothingFactorPrototype(JassRealArg factor);
        private static CameraSetSmoothingFactorPrototype _CameraSetSmoothingFactor;
        public static void CameraSetSmoothingFactor(Single factor)
        {
            Natives._CameraSetSmoothingFactor(factor);
        }
        
        //native SetCineFilterTexture takes string filename returns nothing
        public delegate void SetCineFilterTexturePrototype(JassStringArg filename);
        private static SetCineFilterTexturePrototype _SetCineFilterTexture;
        public static void SetCineFilterTexture(String filename)
        {
            Natives._SetCineFilterTexture(filename);
        }
        
        //native SetCineFilterBlendMode takes blendmode whichMode returns nothing
        public delegate void SetCineFilterBlendModePrototype(JassBlendMode whichMode);
        private static SetCineFilterBlendModePrototype _SetCineFilterBlendMode;
        public static void SetCineFilterBlendMode(JassBlendMode whichMode)
        {
            Natives._SetCineFilterBlendMode(whichMode);
        }
        
        //native SetCineFilterTexMapFlags takes texmapflags whichFlags returns nothing
        public delegate void SetCineFilterTexMapFlagsPrototype(JassTextureMapFlags whichFlags);
        private static SetCineFilterTexMapFlagsPrototype _SetCineFilterTexMapFlags;
        public static void SetCineFilterTexMapFlags(JassTextureMapFlags whichFlags)
        {
            Natives._SetCineFilterTexMapFlags(whichFlags);
        }
        
        //native SetCineFilterStartUV takes real minu, real minv, real maxu, real maxv returns nothing
        public delegate void SetCineFilterStartUVPrototype(JassRealArg minu, JassRealArg minv, JassRealArg maxu, JassRealArg maxv);
        private static SetCineFilterStartUVPrototype _SetCineFilterStartUV;
        public static void SetCineFilterStartUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            Natives._SetCineFilterStartUV(minu, minv, maxu, maxv);
        }
        
        //native SetCineFilterEndUV takes real minu, real minv, real maxu, real maxv returns nothing
        public delegate void SetCineFilterEndUVPrototype(JassRealArg minu, JassRealArg minv, JassRealArg maxu, JassRealArg maxv);
        private static SetCineFilterEndUVPrototype _SetCineFilterEndUV;
        public static void SetCineFilterEndUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            Natives._SetCineFilterEndUV(minu, minv, maxu, maxv);
        }
        
        //native SetCineFilterStartColor takes integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetCineFilterStartColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetCineFilterStartColorPrototype _SetCineFilterStartColor;
        public static void SetCineFilterStartColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._SetCineFilterStartColor(red, green, blue, alpha);
        }
        
        //native SetCineFilterEndColor takes integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetCineFilterEndColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetCineFilterEndColorPrototype _SetCineFilterEndColor;
        public static void SetCineFilterEndColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._SetCineFilterEndColor(red, green, blue, alpha);
        }
        
        //native SetCineFilterDuration takes real duration returns nothing
        public delegate void SetCineFilterDurationPrototype(JassRealArg duration);
        private static SetCineFilterDurationPrototype _SetCineFilterDuration;
        public static void SetCineFilterDuration(Single duration)
        {
            Natives._SetCineFilterDuration(duration);
        }
        
        //native DisplayCineFilter takes boolean flag returns nothing
        public delegate void DisplayCineFilterPrototype(JassBoolean flag);
        private static DisplayCineFilterPrototype _DisplayCineFilter;
        public static void DisplayCineFilter(Boolean flag)
        {
            Natives._DisplayCineFilter(flag);
        }
        
        //native IsCineFilterDisplayed takes nothing returns boolean
        public delegate JassBoolean IsCineFilterDisplayedPrototype();
        private static IsCineFilterDisplayedPrototype _IsCineFilterDisplayed;
        public static Boolean IsCineFilterDisplayed()
        {
            return Natives._IsCineFilterDisplayed();
        }
        
        //native SetCinematicScene takes integer portraitUnitId, playercolor color, string speakerTitle, string text, real sceneDuration, real voiceoverDuration returns nothing
        public delegate void SetCinematicScenePrototype(JassInteger portraitUnitId, JassPlayerColor color, JassStringArg speakerTitle, JassStringArg text, JassRealArg sceneDuration, JassRealArg voiceoverDuration);
        private static SetCinematicScenePrototype _SetCinematicScene;
        public static void SetCinematicScene(JassInteger portraitUnitId, JassPlayerColor color, String speakerTitle, String text, Single sceneDuration, Single voiceoverDuration)
        {
            Natives._SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);
        }
        
        //native EndCinematicScene takes nothing returns nothing
        public delegate void EndCinematicScenePrototype();
        private static EndCinematicScenePrototype _EndCinematicScene;
        public static void EndCinematicScene()
        {
            Natives._EndCinematicScene();
        }
        
        //native ForceCinematicSubtitles takes boolean flag returns nothing
        public delegate void ForceCinematicSubtitlesPrototype(JassBoolean flag);
        private static ForceCinematicSubtitlesPrototype _ForceCinematicSubtitles;
        public static void ForceCinematicSubtitles(Boolean flag)
        {
            Natives._ForceCinematicSubtitles(flag);
        }
        
        //native GetCameraMargin takes integer whichMargin returns real
        public delegate JassRealRet GetCameraMarginPrototype(JassInteger whichMargin);
        private static GetCameraMarginPrototype _GetCameraMargin;
        public static Single GetCameraMargin(JassInteger whichMargin)
        {
            return Natives._GetCameraMargin(whichMargin);
        }
        
        //native GetCameraBoundMinX takes nothing returns real
        public delegate JassRealRet GetCameraBoundMinXPrototype();
        private static GetCameraBoundMinXPrototype _GetCameraBoundMinX;
        public static Single GetCameraBoundMinX()
        {
            return Natives._GetCameraBoundMinX();
        }
        
        //native GetCameraBoundMinY takes nothing returns real
        public delegate JassRealRet GetCameraBoundMinYPrototype();
        private static GetCameraBoundMinYPrototype _GetCameraBoundMinY;
        public static Single GetCameraBoundMinY()
        {
            return Natives._GetCameraBoundMinY();
        }
        
        //native GetCameraBoundMaxX takes nothing returns real
        public delegate JassRealRet GetCameraBoundMaxXPrototype();
        private static GetCameraBoundMaxXPrototype _GetCameraBoundMaxX;
        public static Single GetCameraBoundMaxX()
        {
            return Natives._GetCameraBoundMaxX();
        }
        
        //native GetCameraBoundMaxY takes nothing returns real
        public delegate JassRealRet GetCameraBoundMaxYPrototype();
        private static GetCameraBoundMaxYPrototype _GetCameraBoundMaxY;
        public static Single GetCameraBoundMaxY()
        {
            return Natives._GetCameraBoundMaxY();
        }
        
        //native GetCameraField takes camerafield whichField returns real
        public delegate JassRealRet GetCameraFieldPrototype(JassCameraField whichField);
        private static GetCameraFieldPrototype _GetCameraField;
        public static Single GetCameraField(JassCameraField whichField)
        {
            return Natives._GetCameraField(whichField);
        }
        
        //native GetCameraTargetPositionX takes nothing returns real
        public delegate JassRealRet GetCameraTargetPositionXPrototype();
        private static GetCameraTargetPositionXPrototype _GetCameraTargetPositionX;
        public static Single GetCameraTargetPositionX()
        {
            return Natives._GetCameraTargetPositionX();
        }
        
        //native GetCameraTargetPositionY takes nothing returns real
        public delegate JassRealRet GetCameraTargetPositionYPrototype();
        private static GetCameraTargetPositionYPrototype _GetCameraTargetPositionY;
        public static Single GetCameraTargetPositionY()
        {
            return Natives._GetCameraTargetPositionY();
        }
        
        //native GetCameraTargetPositionZ takes nothing returns real
        public delegate JassRealRet GetCameraTargetPositionZPrototype();
        private static GetCameraTargetPositionZPrototype _GetCameraTargetPositionZ;
        public static Single GetCameraTargetPositionZ()
        {
            return Natives._GetCameraTargetPositionZ();
        }
        
        //native GetCameraTargetPositionLoc takes nothing returns location
        public delegate JassLocation GetCameraTargetPositionLocPrototype();
        private static GetCameraTargetPositionLocPrototype _GetCameraTargetPositionLoc;
        public static JassLocation GetCameraTargetPositionLoc()
        {
            return Natives._GetCameraTargetPositionLoc();
        }
        
        //native GetCameraEyePositionX takes nothing returns real
        public delegate JassRealRet GetCameraEyePositionXPrototype();
        private static GetCameraEyePositionXPrototype _GetCameraEyePositionX;
        public static Single GetCameraEyePositionX()
        {
            return Natives._GetCameraEyePositionX();
        }
        
        //native GetCameraEyePositionY takes nothing returns real
        public delegate JassRealRet GetCameraEyePositionYPrototype();
        private static GetCameraEyePositionYPrototype _GetCameraEyePositionY;
        public static Single GetCameraEyePositionY()
        {
            return Natives._GetCameraEyePositionY();
        }
        
        //native GetCameraEyePositionZ takes nothing returns real
        public delegate JassRealRet GetCameraEyePositionZPrototype();
        private static GetCameraEyePositionZPrototype _GetCameraEyePositionZ;
        public static Single GetCameraEyePositionZ()
        {
            return Natives._GetCameraEyePositionZ();
        }
        
        //native GetCameraEyePositionLoc takes nothing returns location
        public delegate JassLocation GetCameraEyePositionLocPrototype();
        private static GetCameraEyePositionLocPrototype _GetCameraEyePositionLoc;
        public static JassLocation GetCameraEyePositionLoc()
        {
            return Natives._GetCameraEyePositionLoc();
        }
        
        //native NewSoundEnvironment takes string environmentName returns nothing
        public delegate void NewSoundEnvironmentPrototype(JassStringArg environmentName);
        private static NewSoundEnvironmentPrototype _NewSoundEnvironment;
        public static void NewSoundEnvironment(String environmentName)
        {
            Natives._NewSoundEnvironment(environmentName);
        }
        
        //native CreateSound takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string eaxSetting returns sound
        public delegate JassSound CreateSoundPrototype(JassStringArg fileName, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, JassStringArg eaxSetting);
        private static CreateSoundPrototype _CreateSound;
        public static JassSound CreateSound(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String eaxSetting)
        {
            return Natives._CreateSound(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, eaxSetting);
        }
        
        //native CreateSoundFilenameWithLabel takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string SLKEntryName returns sound
        public delegate JassSound CreateSoundFilenameWithLabelPrototype(JassStringArg fileName, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, JassStringArg SLKEntryName);
        private static CreateSoundFilenameWithLabelPrototype _CreateSoundFilenameWithLabel;
        public static JassSound CreateSoundFilenameWithLabel(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String SLKEntryName)
        {
            return Natives._CreateSoundFilenameWithLabel(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, SLKEntryName);
        }
        
        //native CreateSoundFromLabel takes string soundLabel, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate returns sound
        public delegate JassSound CreateSoundFromLabelPrototype(JassStringArg soundLabel, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate);
        private static CreateSoundFromLabelPrototype _CreateSoundFromLabel;
        public static JassSound CreateSoundFromLabel(String soundLabel, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return Natives._CreateSoundFromLabel(soundLabel, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate);
        }
        
        //native CreateMIDISound takes string soundLabel, integer fadeInRate, integer fadeOutRate returns sound
        public delegate JassSound CreateMIDISoundPrototype(JassStringArg soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate);
        private static CreateMIDISoundPrototype _CreateMIDISound;
        public static JassSound CreateMIDISound(String soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return Natives._CreateMIDISound(soundLabel, fadeInRate, fadeOutRate);
        }
        
        //native SetSoundParamsFromLabel takes sound soundHandle, string soundLabel returns nothing
        public delegate void SetSoundParamsFromLabelPrototype(JassSound soundHandle, JassStringArg soundLabel);
        private static SetSoundParamsFromLabelPrototype _SetSoundParamsFromLabel;
        public static void SetSoundParamsFromLabel(JassSound soundHandle, String soundLabel)
        {
            Natives._SetSoundParamsFromLabel(soundHandle, soundLabel);
        }
        
        //native SetSoundDistanceCutoff takes sound soundHandle, real cutoff returns nothing
        public delegate void SetSoundDistanceCutoffPrototype(JassSound soundHandle, JassRealArg cutoff);
        private static SetSoundDistanceCutoffPrototype _SetSoundDistanceCutoff;
        public static void SetSoundDistanceCutoff(JassSound soundHandle, Single cutoff)
        {
            Natives._SetSoundDistanceCutoff(soundHandle, cutoff);
        }
        
        //native SetSoundChannel takes sound soundHandle, integer channel returns nothing
        public delegate void SetSoundChannelPrototype(JassSound soundHandle, JassInteger channel);
        private static SetSoundChannelPrototype _SetSoundChannel;
        public static void SetSoundChannel(JassSound soundHandle, JassInteger channel)
        {
            Natives._SetSoundChannel(soundHandle, channel);
        }
        
        //native SetSoundVolume takes sound soundHandle, integer volume returns nothing
        public delegate void SetSoundVolumePrototype(JassSound soundHandle, JassInteger volume);
        private static SetSoundVolumePrototype _SetSoundVolume;
        public static void SetSoundVolume(JassSound soundHandle, JassInteger volume)
        {
            Natives._SetSoundVolume(soundHandle, volume);
        }
        
        //native SetSoundPitch takes sound soundHandle, real pitch returns nothing
        public delegate void SetSoundPitchPrototype(JassSound soundHandle, JassRealArg pitch);
        private static SetSoundPitchPrototype _SetSoundPitch;
        public static void SetSoundPitch(JassSound soundHandle, Single pitch)
        {
            Natives._SetSoundPitch(soundHandle, pitch);
        }
        
        //native SetSoundPlayPosition takes sound soundHandle, integer millisecs returns nothing
        public delegate void SetSoundPlayPositionPrototype(JassSound soundHandle, JassInteger millisecs);
        private static SetSoundPlayPositionPrototype _SetSoundPlayPosition;
        public static void SetSoundPlayPosition(JassSound soundHandle, JassInteger millisecs)
        {
            Natives._SetSoundPlayPosition(soundHandle, millisecs);
        }
        
        //native SetSoundDistances takes sound soundHandle, real minDist, real maxDist returns nothing
        public delegate void SetSoundDistancesPrototype(JassSound soundHandle, JassRealArg minDist, JassRealArg maxDist);
        private static SetSoundDistancesPrototype _SetSoundDistances;
        public static void SetSoundDistances(JassSound soundHandle, Single minDist, Single maxDist)
        {
            Natives._SetSoundDistances(soundHandle, minDist, maxDist);
        }
        
        //native SetSoundConeAngles takes sound soundHandle, real inside, real outside, integer outsideVolume returns nothing
        public delegate void SetSoundConeAnglesPrototype(JassSound soundHandle, JassRealArg inside, JassRealArg outside, JassInteger outsideVolume);
        private static SetSoundConeAnglesPrototype _SetSoundConeAngles;
        public static void SetSoundConeAngles(JassSound soundHandle, Single inside, Single outside, JassInteger outsideVolume)
        {
            Natives._SetSoundConeAngles(soundHandle, inside, outside, outsideVolume);
        }
        
        //native SetSoundConeOrientation takes sound soundHandle, real x, real y, real z returns nothing
        public delegate void SetSoundConeOrientationPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private static SetSoundConeOrientationPrototype _SetSoundConeOrientation;
        public static void SetSoundConeOrientation(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives._SetSoundConeOrientation(soundHandle, x, y, z);
        }
        
        //native SetSoundPosition takes sound soundHandle, real x, real y, real z returns nothing
        public delegate void SetSoundPositionPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private static SetSoundPositionPrototype _SetSoundPosition;
        public static void SetSoundPosition(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives._SetSoundPosition(soundHandle, x, y, z);
        }
        
        //native SetSoundVelocity takes sound soundHandle, real x, real y, real z returns nothing
        public delegate void SetSoundVelocityPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private static SetSoundVelocityPrototype _SetSoundVelocity;
        public static void SetSoundVelocity(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives._SetSoundVelocity(soundHandle, x, y, z);
        }
        
        //native AttachSoundToUnit takes sound soundHandle, unit whichUnit returns nothing
        public delegate void AttachSoundToUnitPrototype(JassSound soundHandle, JassUnit whichUnit);
        private static AttachSoundToUnitPrototype _AttachSoundToUnit;
        public static void AttachSoundToUnit(JassSound soundHandle, JassUnit whichUnit)
        {
            Natives._AttachSoundToUnit(soundHandle, whichUnit);
        }
        
        //native StartSound takes sound soundHandle returns nothing
        public delegate void StartSoundPrototype(JassSound soundHandle);
        private static StartSoundPrototype _StartSound;
        public static void StartSound(JassSound soundHandle)
        {
            Natives._StartSound(soundHandle);
        }
        
        //native StopSound takes sound soundHandle, boolean killWhenDone, boolean fadeOut returns nothing
        public delegate void StopSoundPrototype(JassSound soundHandle, JassBoolean killWhenDone, JassBoolean fadeOut);
        private static StopSoundPrototype _StopSound;
        public static void StopSound(JassSound soundHandle, Boolean killWhenDone, Boolean fadeOut)
        {
            Natives._StopSound(soundHandle, killWhenDone, fadeOut);
        }
        
        //native KillSoundWhenDone takes sound soundHandle returns nothing
        public delegate void KillSoundWhenDonePrototype(JassSound soundHandle);
        private static KillSoundWhenDonePrototype _KillSoundWhenDone;
        public static void KillSoundWhenDone(JassSound soundHandle)
        {
            Natives._KillSoundWhenDone(soundHandle);
        }
        
        //native SetMapMusic takes string musicName, boolean random, integer index returns nothing
        public delegate void SetMapMusicPrototype(JassStringArg musicName, JassBoolean random, JassInteger index);
        private static SetMapMusicPrototype _SetMapMusic;
        public static void SetMapMusic(String musicName, Boolean random, JassInteger index)
        {
            Natives._SetMapMusic(musicName, random, index);
        }
        
        //native ClearMapMusic takes nothing returns nothing
        public delegate void ClearMapMusicPrototype();
        private static ClearMapMusicPrototype _ClearMapMusic;
        public static void ClearMapMusic()
        {
            Natives._ClearMapMusic();
        }
        
        //native PlayMusic takes string musicName returns nothing
        public delegate void PlayMusicPrototype(JassStringArg musicName);
        private static PlayMusicPrototype _PlayMusic;
        public static void PlayMusic(String musicName)
        {
            Natives._PlayMusic(musicName);
        }
        
        //native PlayMusicEx takes string musicName, integer frommsecs, integer fadeinmsecs returns nothing
        public delegate void PlayMusicExPrototype(JassStringArg musicName, JassInteger frommsecs, JassInteger fadeinmsecs);
        private static PlayMusicExPrototype _PlayMusicEx;
        public static void PlayMusicEx(String musicName, JassInteger frommsecs, JassInteger fadeinmsecs)
        {
            Natives._PlayMusicEx(musicName, frommsecs, fadeinmsecs);
        }
        
        //native StopMusic takes boolean fadeOut returns nothing
        public delegate void StopMusicPrototype(JassBoolean fadeOut);
        private static StopMusicPrototype _StopMusic;
        public static void StopMusic(Boolean fadeOut)
        {
            Natives._StopMusic(fadeOut);
        }
        
        //native ResumeMusic takes nothing returns nothing
        public delegate void ResumeMusicPrototype();
        private static ResumeMusicPrototype _ResumeMusic;
        public static void ResumeMusic()
        {
            Natives._ResumeMusic();
        }
        
        //native PlayThematicMusic takes string musicFileName returns nothing
        public delegate void PlayThematicMusicPrototype(JassStringArg musicFileName);
        private static PlayThematicMusicPrototype _PlayThematicMusic;
        public static void PlayThematicMusic(String musicFileName)
        {
            Natives._PlayThematicMusic(musicFileName);
        }
        
        //native PlayThematicMusicEx takes string musicFileName, integer frommsecs returns nothing
        public delegate void PlayThematicMusicExPrototype(JassStringArg musicFileName, JassInteger frommsecs);
        private static PlayThematicMusicExPrototype _PlayThematicMusicEx;
        public static void PlayThematicMusicEx(String musicFileName, JassInteger frommsecs)
        {
            Natives._PlayThematicMusicEx(musicFileName, frommsecs);
        }
        
        //native EndThematicMusic takes nothing returns nothing
        public delegate void EndThematicMusicPrototype();
        private static EndThematicMusicPrototype _EndThematicMusic;
        public static void EndThematicMusic()
        {
            Natives._EndThematicMusic();
        }
        
        //native SetMusicVolume takes integer volume returns nothing
        public delegate void SetMusicVolumePrototype(JassInteger volume);
        private static SetMusicVolumePrototype _SetMusicVolume;
        public static void SetMusicVolume(JassInteger volume)
        {
            Natives._SetMusicVolume(volume);
        }
        
        //native SetMusicPlayPosition takes integer millisecs returns nothing
        public delegate void SetMusicPlayPositionPrototype(JassInteger millisecs);
        private static SetMusicPlayPositionPrototype _SetMusicPlayPosition;
        public static void SetMusicPlayPosition(JassInteger millisecs)
        {
            Natives._SetMusicPlayPosition(millisecs);
        }
        
        //native SetThematicMusicPlayPosition takes integer millisecs returns nothing
        public delegate void SetThematicMusicPlayPositionPrototype(JassInteger millisecs);
        private static SetThematicMusicPlayPositionPrototype _SetThematicMusicPlayPosition;
        public static void SetThematicMusicPlayPosition(JassInteger millisecs)
        {
            Natives._SetThematicMusicPlayPosition(millisecs);
        }
        
        //native SetSoundDuration takes sound soundHandle, integer duration returns nothing
        public delegate void SetSoundDurationPrototype(JassSound soundHandle, JassInteger duration);
        private static SetSoundDurationPrototype _SetSoundDuration;
        public static void SetSoundDuration(JassSound soundHandle, JassInteger duration)
        {
            Natives._SetSoundDuration(soundHandle, duration);
        }
        
        //native GetSoundDuration takes sound soundHandle returns integer
        public delegate JassInteger GetSoundDurationPrototype(JassSound soundHandle);
        private static GetSoundDurationPrototype _GetSoundDuration;
        public static JassInteger GetSoundDuration(JassSound soundHandle)
        {
            return Natives._GetSoundDuration(soundHandle);
        }
        
        //native GetSoundFileDuration takes string musicFileName returns integer
        public delegate JassInteger GetSoundFileDurationPrototype(JassStringArg musicFileName);
        private static GetSoundFileDurationPrototype _GetSoundFileDuration;
        public static JassInteger GetSoundFileDuration(String musicFileName)
        {
            return Natives._GetSoundFileDuration(musicFileName);
        }
        
        //native VolumeGroupSetVolume takes volumegroup vgroup, real scale returns nothing
        public delegate void VolumeGroupSetVolumePrototype(JassVolumeGroup vgroup, JassRealArg scale);
        private static VolumeGroupSetVolumePrototype _VolumeGroupSetVolume;
        public static void VolumeGroupSetVolume(JassVolumeGroup vgroup, Single scale)
        {
            Natives._VolumeGroupSetVolume(vgroup, scale);
        }
        
        //native VolumeGroupReset takes nothing returns nothing
        public delegate void VolumeGroupResetPrototype();
        private static VolumeGroupResetPrototype _VolumeGroupReset;
        public static void VolumeGroupReset()
        {
            Natives._VolumeGroupReset();
        }
        
        //native GetSoundIsPlaying takes sound soundHandle returns boolean
        public delegate JassBoolean GetSoundIsPlayingPrototype(JassSound soundHandle);
        private static GetSoundIsPlayingPrototype _GetSoundIsPlaying;
        public static Boolean GetSoundIsPlaying(JassSound soundHandle)
        {
            return Natives._GetSoundIsPlaying(soundHandle);
        }
        
        //native GetSoundIsLoading takes sound soundHandle returns boolean
        public delegate JassBoolean GetSoundIsLoadingPrototype(JassSound soundHandle);
        private static GetSoundIsLoadingPrototype _GetSoundIsLoading;
        public static Boolean GetSoundIsLoading(JassSound soundHandle)
        {
            return Natives._GetSoundIsLoading(soundHandle);
        }
        
        //native RegisterStackedSound takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
        public delegate void RegisterStackedSoundPrototype(JassSound soundHandle, JassBoolean byPosition, JassRealArg rectwidth, JassRealArg rectheight);
        private static RegisterStackedSoundPrototype _RegisterStackedSound;
        public static void RegisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            Natives._RegisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        //native UnregisterStackedSound takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
        public delegate void UnregisterStackedSoundPrototype(JassSound soundHandle, JassBoolean byPosition, JassRealArg rectwidth, JassRealArg rectheight);
        private static UnregisterStackedSoundPrototype _UnregisterStackedSound;
        public static void UnregisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            Natives._UnregisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        //native AddWeatherEffect takes rect where, integer effectID returns weathereffect
        public delegate JassWeatherEffect AddWeatherEffectPrototype(JassRect where, JassInteger effectID);
        private static AddWeatherEffectPrototype _AddWeatherEffect;
        public static JassWeatherEffect AddWeatherEffect(JassRect where, JassInteger effectID)
        {
            return Natives._AddWeatherEffect(where, effectID);
        }
        
        //native RemoveWeatherEffect takes weathereffect whichEffect returns nothing
        public delegate void RemoveWeatherEffectPrototype(JassWeatherEffect whichEffect);
        private static RemoveWeatherEffectPrototype _RemoveWeatherEffect;
        public static void RemoveWeatherEffect(JassWeatherEffect whichEffect)
        {
            Natives._RemoveWeatherEffect(whichEffect);
        }
        
        //native EnableWeatherEffect takes weathereffect whichEffect, boolean enable returns nothing
        public delegate void EnableWeatherEffectPrototype(JassWeatherEffect whichEffect, JassBoolean enable);
        private static EnableWeatherEffectPrototype _EnableWeatherEffect;
        public static void EnableWeatherEffect(JassWeatherEffect whichEffect, Boolean enable)
        {
            Natives._EnableWeatherEffect(whichEffect, enable);
        }
        
        //native TerrainDeformCrater takes real x, real y, real radius, real depth, integer duration, boolean permanent returns terraindeformation
        public delegate JassTerrainDeformation TerrainDeformCraterPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg depth, JassInteger duration, JassBoolean permanent);
        private static TerrainDeformCraterPrototype _TerrainDeformCrater;
        public static JassTerrainDeformation TerrainDeformCrater(Single x, Single y, Single radius, Single depth, JassInteger duration, Boolean permanent)
        {
            return Natives._TerrainDeformCrater(x, y, radius, depth, duration, permanent);
        }
        
        //native TerrainDeformRipple takes real x, real y, real radius, real depth, integer duration, integer count, real spaceWaves, real timeWaves, real radiusStartPct, boolean limitNeg returns terraindeformation
        public delegate JassTerrainDeformation TerrainDeformRipplePrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg depth, JassInteger duration, JassInteger count, JassRealArg spaceWaves, JassRealArg timeWaves, JassRealArg radiusStartPct, JassBoolean limitNeg);
        private static TerrainDeformRipplePrototype _TerrainDeformRipple;
        public static JassTerrainDeformation TerrainDeformRipple(Single x, Single y, Single radius, Single depth, JassInteger duration, JassInteger count, Single spaceWaves, Single timeWaves, Single radiusStartPct, Boolean limitNeg)
        {
            return Natives._TerrainDeformRipple(x, y, radius, depth, duration, count, spaceWaves, timeWaves, radiusStartPct, limitNeg);
        }
        
        //native TerrainDeformWave takes real x, real y, real dirX, real dirY, real distance, real speed, real radius, real depth, integer trailTime, integer count returns terraindeformation
        public delegate JassTerrainDeformation TerrainDeformWavePrototype(JassRealArg x, JassRealArg y, JassRealArg dirX, JassRealArg dirY, JassRealArg distance, JassRealArg speed, JassRealArg radius, JassRealArg depth, JassInteger trailTime, JassInteger count);
        private static TerrainDeformWavePrototype _TerrainDeformWave;
        public static JassTerrainDeformation TerrainDeformWave(Single x, Single y, Single dirX, Single dirY, Single distance, Single speed, Single radius, Single depth, JassInteger trailTime, JassInteger count)
        {
            return Natives._TerrainDeformWave(x, y, dirX, dirY, distance, speed, radius, depth, trailTime, count);
        }
        
        //native TerrainDeformRandom takes real x, real y, real radius, real minDelta, real maxDelta, integer duration, integer updateInterval returns terraindeformation
        public delegate JassTerrainDeformation TerrainDeformRandomPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg minDelta, JassRealArg maxDelta, JassInteger duration, JassInteger updateInterval);
        private static TerrainDeformRandomPrototype _TerrainDeformRandom;
        public static JassTerrainDeformation TerrainDeformRandom(Single x, Single y, Single radius, Single minDelta, Single maxDelta, JassInteger duration, JassInteger updateInterval)
        {
            return Natives._TerrainDeformRandom(x, y, radius, minDelta, maxDelta, duration, updateInterval);
        }
        
        //native TerrainDeformStop takes terraindeformation deformation, integer duration returns nothing
        public delegate void TerrainDeformStopPrototype(JassTerrainDeformation deformation, JassInteger duration);
        private static TerrainDeformStopPrototype _TerrainDeformStop;
        public static void TerrainDeformStop(JassTerrainDeformation deformation, JassInteger duration)
        {
            Natives._TerrainDeformStop(deformation, duration);
        }
        
        //native TerrainDeformStopAll takes nothing returns nothing
        public delegate void TerrainDeformStopAllPrototype();
        private static TerrainDeformStopAllPrototype _TerrainDeformStopAll;
        public static void TerrainDeformStopAll()
        {
            Natives._TerrainDeformStopAll();
        }
        
        //native AddSpecialEffect takes string modelName, real x, real y returns effect
        public delegate JassEffect AddSpecialEffectPrototype(JassStringArg modelName, JassRealArg x, JassRealArg y);
        private static AddSpecialEffectPrototype _AddSpecialEffect;
        public static JassEffect AddSpecialEffect(String modelName, Single x, Single y)
        {
            return Natives._AddSpecialEffect(modelName, x, y);
        }
        
        //native AddSpecialEffectLoc takes string modelName, location where returns effect
        public delegate JassEffect AddSpecialEffectLocPrototype(JassStringArg modelName, JassLocation where);
        private static AddSpecialEffectLocPrototype _AddSpecialEffectLoc;
        public static JassEffect AddSpecialEffectLoc(String modelName, JassLocation where)
        {
            return Natives._AddSpecialEffectLoc(modelName, where);
        }
        
        //native AddSpecialEffectTarget takes string modelName, widget targetWidget, string attachPointName returns effect
        public delegate JassEffect AddSpecialEffectTargetPrototype(JassStringArg modelName, JassWidget targetWidget, JassStringArg attachPointName);
        private static AddSpecialEffectTargetPrototype _AddSpecialEffectTarget;
        public static JassEffect AddSpecialEffectTarget(String modelName, JassWidget targetWidget, String attachPointName)
        {
            return Natives._AddSpecialEffectTarget(modelName, targetWidget, attachPointName);
        }
        
        //native DestroyEffect takes effect whichEffect returns nothing
        public delegate void DestroyEffectPrototype(JassEffect whichEffect);
        private static DestroyEffectPrototype _DestroyEffect;
        public static void DestroyEffect(JassEffect whichEffect)
        {
            Natives._DestroyEffect(whichEffect);
        }
        
        //native AddSpellEffect takes string abilityString, effecttype t, real x, real y returns effect
        public delegate JassEffect AddSpellEffectPrototype(JassStringArg abilityString, JassEffectType t, JassRealArg x, JassRealArg y);
        private static AddSpellEffectPrototype _AddSpellEffect;
        public static JassEffect AddSpellEffect(String abilityString, JassEffectType t, Single x, Single y)
        {
            return Natives._AddSpellEffect(abilityString, t, x, y);
        }
        
        //native AddSpellEffectLoc takes string abilityString, effecttype t, location where returns effect
        public delegate JassEffect AddSpellEffectLocPrototype(JassStringArg abilityString, JassEffectType t, JassLocation where);
        private static AddSpellEffectLocPrototype _AddSpellEffectLoc;
        public static JassEffect AddSpellEffectLoc(String abilityString, JassEffectType t, JassLocation where)
        {
            return Natives._AddSpellEffectLoc(abilityString, t, where);
        }
        
        //native AddSpellEffectById takes integer abilityId, effecttype t, real x, real y returns effect
        public delegate JassEffect AddSpellEffectByIdPrototype(JassInteger abilityId, JassEffectType t, JassRealArg x, JassRealArg y);
        private static AddSpellEffectByIdPrototype _AddSpellEffectById;
        public static JassEffect AddSpellEffectById(JassInteger abilityId, JassEffectType t, Single x, Single y)
        {
            return Natives._AddSpellEffectById(abilityId, t, x, y);
        }
        
        //native AddSpellEffectByIdLoc takes integer abilityId, effecttype t, location where returns effect
        public delegate JassEffect AddSpellEffectByIdLocPrototype(JassInteger abilityId, JassEffectType t, JassLocation where);
        private static AddSpellEffectByIdLocPrototype _AddSpellEffectByIdLoc;
        public static JassEffect AddSpellEffectByIdLoc(JassInteger abilityId, JassEffectType t, JassLocation where)
        {
            return Natives._AddSpellEffectByIdLoc(abilityId, t, where);
        }
        
        //native AddSpellEffectTarget takes string modelName, effecttype t, widget targetWidget, string attachPoint returns effect
        public delegate JassEffect AddSpellEffectTargetPrototype(JassStringArg modelName, JassEffectType t, JassWidget targetWidget, JassStringArg attachPoint);
        private static AddSpellEffectTargetPrototype _AddSpellEffectTarget;
        public static JassEffect AddSpellEffectTarget(String modelName, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return Natives._AddSpellEffectTarget(modelName, t, targetWidget, attachPoint);
        }
        
        //native AddSpellEffectTargetById takes integer abilityId, effecttype t, widget targetWidget, string attachPoint returns effect
        public delegate JassEffect AddSpellEffectTargetByIdPrototype(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, JassStringArg attachPoint);
        private static AddSpellEffectTargetByIdPrototype _AddSpellEffectTargetById;
        public static JassEffect AddSpellEffectTargetById(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return Natives._AddSpellEffectTargetById(abilityId, t, targetWidget, attachPoint);
        }
        
        //native AddLightning takes string codeName, boolean checkVisibility, real x1, real y1, real x2, real y2 returns lightning
        public delegate JassLightning AddLightningPrototype(JassStringArg codeName, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2);
        private static AddLightningPrototype _AddLightning;
        public static JassLightning AddLightning(String codeName, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return Natives._AddLightning(codeName, checkVisibility, x1, y1, x2, y2);
        }
        
        //native AddLightningEx takes string codeName, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns lightning
        public delegate JassLightning AddLightningExPrototype(JassStringArg codeName, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg z1, JassRealArg x2, JassRealArg y2, JassRealArg z2);
        private static AddLightningExPrototype _AddLightningEx;
        public static JassLightning AddLightningEx(String codeName, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return Natives._AddLightningEx(codeName, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        //native DestroyLightning takes lightning whichBolt returns boolean
        public delegate JassBoolean DestroyLightningPrototype(JassLightning whichBolt);
        private static DestroyLightningPrototype _DestroyLightning;
        public static Boolean DestroyLightning(JassLightning whichBolt)
        {
            return Natives._DestroyLightning(whichBolt);
        }
        
        //native MoveLightning takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real x2, real y2 returns boolean
        public delegate JassBoolean MoveLightningPrototype(JassLightning whichBolt, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2);
        private static MoveLightningPrototype _MoveLightning;
        public static Boolean MoveLightning(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return Natives._MoveLightning(whichBolt, checkVisibility, x1, y1, x2, y2);
        }
        
        //native MoveLightningEx takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns boolean
        public delegate JassBoolean MoveLightningExPrototype(JassLightning whichBolt, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg z1, JassRealArg x2, JassRealArg y2, JassRealArg z2);
        private static MoveLightningExPrototype _MoveLightningEx;
        public static Boolean MoveLightningEx(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return Natives._MoveLightningEx(whichBolt, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        //native GetLightningColorA takes lightning whichBolt returns real
        public delegate JassRealRet GetLightningColorAPrototype(JassLightning whichBolt);
        private static GetLightningColorAPrototype _GetLightningColorA;
        public static Single GetLightningColorA(JassLightning whichBolt)
        {
            return Natives._GetLightningColorA(whichBolt);
        }
        
        //native GetLightningColorR takes lightning whichBolt returns real
        public delegate JassRealRet GetLightningColorRPrototype(JassLightning whichBolt);
        private static GetLightningColorRPrototype _GetLightningColorR;
        public static Single GetLightningColorR(JassLightning whichBolt)
        {
            return Natives._GetLightningColorR(whichBolt);
        }
        
        //native GetLightningColorG takes lightning whichBolt returns real
        public delegate JassRealRet GetLightningColorGPrototype(JassLightning whichBolt);
        private static GetLightningColorGPrototype _GetLightningColorG;
        public static Single GetLightningColorG(JassLightning whichBolt)
        {
            return Natives._GetLightningColorG(whichBolt);
        }
        
        //native GetLightningColorB takes lightning whichBolt returns real
        public delegate JassRealRet GetLightningColorBPrototype(JassLightning whichBolt);
        private static GetLightningColorBPrototype _GetLightningColorB;
        public static Single GetLightningColorB(JassLightning whichBolt)
        {
            return Natives._GetLightningColorB(whichBolt);
        }
        
        //native SetLightningColor takes lightning whichBolt, real r, real g, real b, real a returns boolean
        public delegate JassBoolean SetLightningColorPrototype(JassLightning whichBolt, JassRealArg r, JassRealArg g, JassRealArg b, JassRealArg a);
        private static SetLightningColorPrototype _SetLightningColor;
        public static Boolean SetLightningColor(JassLightning whichBolt, Single r, Single g, Single b, Single a)
        {
            return Natives._SetLightningColor(whichBolt, r, g, b, a);
        }
        
        //native GetAbilityEffect takes string abilityString, effecttype t, integer index returns string
        public delegate JassStringRet GetAbilityEffectPrototype(JassStringArg abilityString, JassEffectType t, JassInteger index);
        private static GetAbilityEffectPrototype _GetAbilityEffect;
        public static String GetAbilityEffect(String abilityString, JassEffectType t, JassInteger index)
        {
            return Natives._GetAbilityEffect(abilityString, t, index);
        }
        
        //native GetAbilityEffectById takes integer abilityId, effecttype t, integer index returns string
        public delegate JassStringRet GetAbilityEffectByIdPrototype(JassInteger abilityId, JassEffectType t, JassInteger index);
        private static GetAbilityEffectByIdPrototype _GetAbilityEffectById;
        public static String GetAbilityEffectById(JassInteger abilityId, JassEffectType t, JassInteger index)
        {
            return Natives._GetAbilityEffectById(abilityId, t, index);
        }
        
        //native GetAbilitySound takes string abilityString, soundtype t returns string
        public delegate JassStringRet GetAbilitySoundPrototype(JassStringArg abilityString, JassSoundType t);
        private static GetAbilitySoundPrototype _GetAbilitySound;
        public static String GetAbilitySound(String abilityString, JassSoundType t)
        {
            return Natives._GetAbilitySound(abilityString, t);
        }
        
        //native GetAbilitySoundById takes integer abilityId, soundtype t returns string
        public delegate JassStringRet GetAbilitySoundByIdPrototype(JassInteger abilityId, JassSoundType t);
        private static GetAbilitySoundByIdPrototype _GetAbilitySoundById;
        public static String GetAbilitySoundById(JassInteger abilityId, JassSoundType t)
        {
            return Natives._GetAbilitySoundById(abilityId, t);
        }
        
        //native GetTerrainCliffLevel takes real x, real y returns integer
        public delegate JassInteger GetTerrainCliffLevelPrototype(JassRealArg x, JassRealArg y);
        private static GetTerrainCliffLevelPrototype _GetTerrainCliffLevel;
        public static JassInteger GetTerrainCliffLevel(Single x, Single y)
        {
            return Natives._GetTerrainCliffLevel(x, y);
        }
        
        //native SetWaterBaseColor takes integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetWaterBaseColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetWaterBaseColorPrototype _SetWaterBaseColor;
        public static void SetWaterBaseColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._SetWaterBaseColor(red, green, blue, alpha);
        }
        
        //native SetWaterDeforms takes boolean val returns nothing
        public delegate void SetWaterDeformsPrototype(JassBoolean val);
        private static SetWaterDeformsPrototype _SetWaterDeforms;
        public static void SetWaterDeforms(Boolean val)
        {
            Natives._SetWaterDeforms(val);
        }
        
        //native GetTerrainType takes real x, real y returns integer
        public delegate JassInteger GetTerrainTypePrototype(JassRealArg x, JassRealArg y);
        private static GetTerrainTypePrototype _GetTerrainType;
        public static JassInteger GetTerrainType(Single x, Single y)
        {
            return Natives._GetTerrainType(x, y);
        }
        
        //native GetTerrainVariance takes real x, real y returns integer
        public delegate JassInteger GetTerrainVariancePrototype(JassRealArg x, JassRealArg y);
        private static GetTerrainVariancePrototype _GetTerrainVariance;
        public static JassInteger GetTerrainVariance(Single x, Single y)
        {
            return Natives._GetTerrainVariance(x, y);
        }
        
        //native SetTerrainType takes real x, real y, integer terrainType, integer variation, integer area, integer shape returns nothing
        public delegate void SetTerrainTypePrototype(JassRealArg x, JassRealArg y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape);
        private static SetTerrainTypePrototype _SetTerrainType;
        public static void SetTerrainType(Single x, Single y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape)
        {
            Natives._SetTerrainType(x, y, terrainType, variation, area, shape);
        }
        
        //native IsTerrainPathable takes real x, real y, pathingtype t returns boolean
        public delegate JassBoolean IsTerrainPathablePrototype(JassRealArg x, JassRealArg y, JassPathingType t);
        private static IsTerrainPathablePrototype _IsTerrainPathable;
        public static Boolean IsTerrainPathable(Single x, Single y, JassPathingType t)
        {
            return Natives._IsTerrainPathable(x, y, t);
        }
        
        //native SetTerrainPathable takes real x, real y, pathingtype t, boolean flag returns nothing
        public delegate void SetTerrainPathablePrototype(JassRealArg x, JassRealArg y, JassPathingType t, JassBoolean flag);
        private static SetTerrainPathablePrototype _SetTerrainPathable;
        public static void SetTerrainPathable(Single x, Single y, JassPathingType t, Boolean flag)
        {
            Natives._SetTerrainPathable(x, y, t, flag);
        }
        
        //native CreateImage takes string file, real sizeX, real sizeY, real sizeZ, real posX, real posY, real posZ, real originX, real originY, real originZ, integer imageType returns image
        public delegate JassImage CreateImagePrototype(JassStringArg file, JassRealArg sizeX, JassRealArg sizeY, JassRealArg sizeZ, JassRealArg posX, JassRealArg posY, JassRealArg posZ, JassRealArg originX, JassRealArg originY, JassRealArg originZ, JassInteger imageType);
        private static CreateImagePrototype _CreateImage;
        public static JassImage CreateImage(String file, Single sizeX, Single sizeY, Single sizeZ, Single posX, Single posY, Single posZ, Single originX, Single originY, Single originZ, JassInteger imageType)
        {
            return Natives._CreateImage(file, sizeX, sizeY, sizeZ, posX, posY, posZ, originX, originY, originZ, imageType);
        }
        
        //native DestroyImage takes image whichImage returns nothing
        public delegate void DestroyImagePrototype(JassImage whichImage);
        private static DestroyImagePrototype _DestroyImage;
        public static void DestroyImage(JassImage whichImage)
        {
            Natives._DestroyImage(whichImage);
        }
        
        //native ShowImage takes image whichImage, boolean flag returns nothing
        public delegate void ShowImagePrototype(JassImage whichImage, JassBoolean flag);
        private static ShowImagePrototype _ShowImage;
        public static void ShowImage(JassImage whichImage, Boolean flag)
        {
            Natives._ShowImage(whichImage, flag);
        }
        
        //native SetImageConstantHeight takes image whichImage, boolean flag, real height returns nothing
        public delegate void SetImageConstantHeightPrototype(JassImage whichImage, JassBoolean flag, JassRealArg height);
        private static SetImageConstantHeightPrototype _SetImageConstantHeight;
        public static void SetImageConstantHeight(JassImage whichImage, Boolean flag, Single height)
        {
            Natives._SetImageConstantHeight(whichImage, flag, height);
        }
        
        //native SetImagePosition takes image whichImage, real x, real y, real z returns nothing
        public delegate void SetImagePositionPrototype(JassImage whichImage, JassRealArg x, JassRealArg y, JassRealArg z);
        private static SetImagePositionPrototype _SetImagePosition;
        public static void SetImagePosition(JassImage whichImage, Single x, Single y, Single z)
        {
            Natives._SetImagePosition(whichImage, x, y, z);
        }
        
        //native SetImageColor takes image whichImage, integer red, integer green, integer blue, integer alpha returns nothing
        public delegate void SetImageColorPrototype(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private static SetImageColorPrototype _SetImageColor;
        public static void SetImageColor(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives._SetImageColor(whichImage, red, green, blue, alpha);
        }
        
        //native SetImageRender takes image whichImage, boolean flag returns nothing
        public delegate void SetImageRenderPrototype(JassImage whichImage, JassBoolean flag);
        private static SetImageRenderPrototype _SetImageRender;
        public static void SetImageRender(JassImage whichImage, Boolean flag)
        {
            Natives._SetImageRender(whichImage, flag);
        }
        
        //native SetImageRenderAlways takes image whichImage, boolean flag returns nothing
        public delegate void SetImageRenderAlwaysPrototype(JassImage whichImage, JassBoolean flag);
        private static SetImageRenderAlwaysPrototype _SetImageRenderAlways;
        public static void SetImageRenderAlways(JassImage whichImage, Boolean flag)
        {
            Natives._SetImageRenderAlways(whichImage, flag);
        }
        
        //native SetImageAboveWater takes image whichImage, boolean flag, boolean useWaterAlpha returns nothing
        public delegate void SetImageAboveWaterPrototype(JassImage whichImage, JassBoolean flag, JassBoolean useWaterAlpha);
        private static SetImageAboveWaterPrototype _SetImageAboveWater;
        public static void SetImageAboveWater(JassImage whichImage, Boolean flag, Boolean useWaterAlpha)
        {
            Natives._SetImageAboveWater(whichImage, flag, useWaterAlpha);
        }
        
        //native SetImageType takes image whichImage, integer imageType returns nothing
        public delegate void SetImageTypePrototype(JassImage whichImage, JassInteger imageType);
        private static SetImageTypePrototype _SetImageType;
        public static void SetImageType(JassImage whichImage, JassInteger imageType)
        {
            Natives._SetImageType(whichImage, imageType);
        }
        
        //native CreateUbersplat takes real x, real y, string name, integer red, integer green, integer blue, integer alpha, boolean forcePaused, boolean noBirthTime returns ubersplat
        public delegate JassUberSplat CreateUbersplatPrototype(JassRealArg x, JassRealArg y, JassStringArg name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, JassBoolean forcePaused, JassBoolean noBirthTime);
        private static CreateUbersplatPrototype _CreateUbersplat;
        public static JassUberSplat CreateUbersplat(Single x, Single y, String name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, Boolean forcePaused, Boolean noBirthTime)
        {
            return Natives._CreateUbersplat(x, y, name, red, green, blue, alpha, forcePaused, noBirthTime);
        }
        
        //native DestroyUbersplat takes ubersplat whichSplat returns nothing
        public delegate void DestroyUbersplatPrototype(JassUberSplat whichSplat);
        private static DestroyUbersplatPrototype _DestroyUbersplat;
        public static void DestroyUbersplat(JassUberSplat whichSplat)
        {
            Natives._DestroyUbersplat(whichSplat);
        }
        
        //native ResetUbersplat takes ubersplat whichSplat returns nothing
        public delegate void ResetUbersplatPrototype(JassUberSplat whichSplat);
        private static ResetUbersplatPrototype _ResetUbersplat;
        public static void ResetUbersplat(JassUberSplat whichSplat)
        {
            Natives._ResetUbersplat(whichSplat);
        }
        
        //native FinishUbersplat takes ubersplat whichSplat returns nothing
        public delegate void FinishUbersplatPrototype(JassUberSplat whichSplat);
        private static FinishUbersplatPrototype _FinishUbersplat;
        public static void FinishUbersplat(JassUberSplat whichSplat)
        {
            Natives._FinishUbersplat(whichSplat);
        }
        
        //native ShowUbersplat takes ubersplat whichSplat, boolean flag returns nothing
        public delegate void ShowUbersplatPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private static ShowUbersplatPrototype _ShowUbersplat;
        public static void ShowUbersplat(JassUberSplat whichSplat, Boolean flag)
        {
            Natives._ShowUbersplat(whichSplat, flag);
        }
        
        //native SetUbersplatRender takes ubersplat whichSplat, boolean flag returns nothing
        public delegate void SetUbersplatRenderPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private static SetUbersplatRenderPrototype _SetUbersplatRender;
        public static void SetUbersplatRender(JassUberSplat whichSplat, Boolean flag)
        {
            Natives._SetUbersplatRender(whichSplat, flag);
        }
        
        //native SetUbersplatRenderAlways takes ubersplat whichSplat, boolean flag returns nothing
        public delegate void SetUbersplatRenderAlwaysPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private static SetUbersplatRenderAlwaysPrototype _SetUbersplatRenderAlways;
        public static void SetUbersplatRenderAlways(JassUberSplat whichSplat, Boolean flag)
        {
            Natives._SetUbersplatRenderAlways(whichSplat, flag);
        }
        
        //native SetBlight takes player whichPlayer, real x, real y, real radius, boolean addBlight returns nothing
        public delegate void SetBlightPrototype(JassPlayer whichPlayer, JassRealArg x, JassRealArg y, JassRealArg radius, JassBoolean addBlight);
        private static SetBlightPrototype _SetBlight;
        public static void SetBlight(JassPlayer whichPlayer, Single x, Single y, Single radius, Boolean addBlight)
        {
            Natives._SetBlight(whichPlayer, x, y, radius, addBlight);
        }
        
        //native SetBlightRect takes player whichPlayer, rect r, boolean addBlight returns nothing
        public delegate void SetBlightRectPrototype(JassPlayer whichPlayer, JassRect r, JassBoolean addBlight);
        private static SetBlightRectPrototype _SetBlightRect;
        public static void SetBlightRect(JassPlayer whichPlayer, JassRect r, Boolean addBlight)
        {
            Natives._SetBlightRect(whichPlayer, r, addBlight);
        }
        
        //native SetBlightPoint takes player whichPlayer, real x, real y, boolean addBlight returns nothing
        public delegate void SetBlightPointPrototype(JassPlayer whichPlayer, JassRealArg x, JassRealArg y, JassBoolean addBlight);
        private static SetBlightPointPrototype _SetBlightPoint;
        public static void SetBlightPoint(JassPlayer whichPlayer, Single x, Single y, Boolean addBlight)
        {
            Natives._SetBlightPoint(whichPlayer, x, y, addBlight);
        }
        
        //native SetBlightLoc takes player whichPlayer, location whichLocation, real radius, boolean addBlight returns nothing
        public delegate void SetBlightLocPrototype(JassPlayer whichPlayer, JassLocation whichLocation, JassRealArg radius, JassBoolean addBlight);
        private static SetBlightLocPrototype _SetBlightLoc;
        public static void SetBlightLoc(JassPlayer whichPlayer, JassLocation whichLocation, Single radius, Boolean addBlight)
        {
            Natives._SetBlightLoc(whichPlayer, whichLocation, radius, addBlight);
        }
        
        //native CreateBlightedGoldmine takes player id, real x, real y, real face returns unit
        public delegate JassUnit CreateBlightedGoldminePrototype(JassPlayer id, JassRealArg x, JassRealArg y, JassRealArg face);
        private static CreateBlightedGoldminePrototype _CreateBlightedGoldmine;
        public static JassUnit CreateBlightedGoldmine(JassPlayer id, Single x, Single y, Single face)
        {
            return Natives._CreateBlightedGoldmine(id, x, y, face);
        }
        
        //native IsPointBlighted takes real x, real y returns boolean
        public delegate JassBoolean IsPointBlightedPrototype(JassRealArg x, JassRealArg y);
        private static IsPointBlightedPrototype _IsPointBlighted;
        public static Boolean IsPointBlighted(Single x, Single y)
        {
            return Natives._IsPointBlighted(x, y);
        }
        
        //native SetDoodadAnimation takes real x, real y, real radius, integer doodadID, boolean nearestOnly, string animName, boolean animRandom returns nothing
        public delegate void SetDoodadAnimationPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassObjectId doodadID, JassBoolean nearestOnly, JassStringArg animName, JassBoolean animRandom);
        private static SetDoodadAnimationPrototype _SetDoodadAnimation;
        public static void SetDoodadAnimation(Single x, Single y, Single radius, JassObjectId doodadID, Boolean nearestOnly, String animName, Boolean animRandom)
        {
            Natives._SetDoodadAnimation(x, y, radius, doodadID, nearestOnly, animName, animRandom);
        }
        
        //native SetDoodadAnimationRect takes rect r, integer doodadID, string animName, boolean animRandom returns nothing
        public delegate void SetDoodadAnimationRectPrototype(JassRect r, JassObjectId doodadID, JassStringArg animName, JassBoolean animRandom);
        private static SetDoodadAnimationRectPrototype _SetDoodadAnimationRect;
        public static void SetDoodadAnimationRect(JassRect r, JassObjectId doodadID, String animName, Boolean animRandom)
        {
            Natives._SetDoodadAnimationRect(r, doodadID, animName, animRandom);
        }
        
        //native StartMeleeAI takes player num, string script returns nothing
        public delegate void StartMeleeAIPrototype(JassPlayer num, JassStringArg script);
        private static StartMeleeAIPrototype _StartMeleeAI;
        public static void StartMeleeAI(JassPlayer num, String script)
        {
            Natives._StartMeleeAI(num, script);
        }
        
        //native StartCampaignAI takes player num, string script returns nothing
        public delegate void StartCampaignAIPrototype(JassPlayer num, JassStringArg script);
        private static StartCampaignAIPrototype _StartCampaignAI;
        public static void StartCampaignAI(JassPlayer num, String script)
        {
            Natives._StartCampaignAI(num, script);
        }
        
        //native CommandAI takes player num, integer command, integer data returns nothing
        public delegate void CommandAIPrototype(JassPlayer num, JassInteger command, JassInteger data);
        private static CommandAIPrototype _CommandAI;
        public static void CommandAI(JassPlayer num, JassInteger command, JassInteger data)
        {
            Natives._CommandAI(num, command, data);
        }
        
        //native PauseCompAI takes player p, boolean pause returns nothing
        public delegate void PauseCompAIPrototype(JassPlayer p, JassBoolean pause);
        private static PauseCompAIPrototype _PauseCompAI;
        public static void PauseCompAI(JassPlayer p, Boolean pause)
        {
            Natives._PauseCompAI(p, pause);
        }
        
        //native GetAIDifficulty takes player num returns aidifficulty
        public delegate JassAIDifficulty GetAIDifficultyPrototype(JassPlayer num);
        private static GetAIDifficultyPrototype _GetAIDifficulty;
        public static JassAIDifficulty GetAIDifficulty(JassPlayer num)
        {
            return Natives._GetAIDifficulty(num);
        }
        
        //native RemoveGuardPosition takes unit hUnit returns nothing
        public delegate void RemoveGuardPositionPrototype(JassUnit hUnit);
        private static RemoveGuardPositionPrototype _RemoveGuardPosition;
        public static void RemoveGuardPosition(JassUnit hUnit)
        {
            Natives._RemoveGuardPosition(hUnit);
        }
        
        //native RecycleGuardPosition takes unit hUnit returns nothing
        public delegate void RecycleGuardPositionPrototype(JassUnit hUnit);
        private static RecycleGuardPositionPrototype _RecycleGuardPosition;
        public static void RecycleGuardPosition(JassUnit hUnit)
        {
            Natives._RecycleGuardPosition(hUnit);
        }
        
        //native RemoveAllGuardPositions takes player num returns nothing
        public delegate void RemoveAllGuardPositionsPrototype(JassPlayer num);
        private static RemoveAllGuardPositionsPrototype _RemoveAllGuardPositions;
        public static void RemoveAllGuardPositions(JassPlayer num)
        {
            Natives._RemoveAllGuardPositions(num);
        }
        
        //native Cheat takes string cheatStr returns nothing
        public delegate void CheatPrototype(JassStringArg cheatStr);
        private static CheatPrototype _Cheat;
        public static void Cheat(String cheatStr)
        {
            Natives._Cheat(cheatStr);
        }
        
        //native IsNoVictoryCheat takes nothing returns boolean
        public delegate JassBoolean IsNoVictoryCheatPrototype();
        private static IsNoVictoryCheatPrototype _IsNoVictoryCheat;
        public static Boolean IsNoVictoryCheat()
        {
            return Natives._IsNoVictoryCheat();
        }
        
        //native IsNoDefeatCheat takes nothing returns boolean
        public delegate JassBoolean IsNoDefeatCheatPrototype();
        private static IsNoDefeatCheatPrototype _IsNoDefeatCheat;
        public static Boolean IsNoDefeatCheat()
        {
            return Natives._IsNoDefeatCheat();
        }
        
        //native Preload takes string filename returns nothing
        public delegate void PreloadPrototype(JassStringArg filename);
        private static PreloadPrototype _Preload;
        public static void Preload(String filename)
        {
            Natives._Preload(filename);
        }
        
        //native PreloadEnd takes real timeout returns nothing
        public delegate void PreloadEndPrototype(JassRealArg timeout);
        private static PreloadEndPrototype _PreloadEnd;
        public static void PreloadEnd(Single timeout)
        {
            Natives._PreloadEnd(timeout);
        }
        
        //native PreloadStart takes nothing returns nothing
        public delegate void PreloadStartPrototype();
        private static PreloadStartPrototype _PreloadStart;
        public static void PreloadStart()
        {
            Natives._PreloadStart();
        }
        
        //native PreloadRefresh takes nothing returns nothing
        public delegate void PreloadRefreshPrototype();
        private static PreloadRefreshPrototype _PreloadRefresh;
        public static void PreloadRefresh()
        {
            Natives._PreloadRefresh();
        }
        
        //native PreloadEndEx takes nothing returns nothing
        public delegate void PreloadEndExPrototype();
        private static PreloadEndExPrototype _PreloadEndEx;
        public static void PreloadEndEx()
        {
            Natives._PreloadEndEx();
        }
        
        //native PreloadGenClear takes nothing returns nothing
        public delegate void PreloadGenClearPrototype();
        private static PreloadGenClearPrototype _PreloadGenClear;
        public static void PreloadGenClear()
        {
            Natives._PreloadGenClear();
        }
        
        //native PreloadGenStart takes nothing returns nothing
        public delegate void PreloadGenStartPrototype();
        private static PreloadGenStartPrototype _PreloadGenStart;
        public static void PreloadGenStart()
        {
            Natives._PreloadGenStart();
        }
        
        //native PreloadGenEnd takes string filename returns nothing
        public delegate void PreloadGenEndPrototype(JassStringArg filename);
        private static PreloadGenEndPrototype _PreloadGenEnd;
        public static void PreloadGenEnd(String filename)
        {
            Natives._PreloadGenEnd(filename);
        }
        
        //native Preloader takes string filename returns nothing
        public delegate void PreloaderPrototype(JassStringArg filename);
        private static PreloaderPrototype _Preloader;
        public static void Preloader(String filename)
        {
            Natives._Preloader(filename);
        }
        
        private static void GetVanillaNatives()
        {
            Natives._ConvertRace = Natives.Get("ConvertRace").ToDelegate<ConvertRacePrototype>();
            Natives._ConvertAllianceType = Natives.Get("ConvertAllianceType").ToDelegate<ConvertAllianceTypePrototype>();
            Natives._ConvertRacePref = Natives.Get("ConvertRacePref").ToDelegate<ConvertRacePrefPrototype>();
            Natives._ConvertIGameState = Natives.Get("ConvertIGameState").ToDelegate<ConvertIGameStatePrototype>();
            Natives._ConvertFGameState = Natives.Get("ConvertFGameState").ToDelegate<ConvertFGameStatePrototype>();
            Natives._ConvertPlayerState = Natives.Get("ConvertPlayerState").ToDelegate<ConvertPlayerStatePrototype>();
            Natives._ConvertPlayerScore = Natives.Get("ConvertPlayerScore").ToDelegate<ConvertPlayerScorePrototype>();
            Natives._ConvertPlayerGameResult = Natives.Get("ConvertPlayerGameResult").ToDelegate<ConvertPlayerGameResultPrototype>();
            Natives._ConvertUnitState = Natives.Get("ConvertUnitState").ToDelegate<ConvertUnitStatePrototype>();
            Natives._ConvertAIDifficulty = Natives.Get("ConvertAIDifficulty").ToDelegate<ConvertAIDifficultyPrototype>();
            Natives._ConvertGameEvent = Natives.Get("ConvertGameEvent").ToDelegate<ConvertGameEventPrototype>();
            Natives._ConvertPlayerEvent = Natives.Get("ConvertPlayerEvent").ToDelegate<ConvertPlayerEventPrototype>();
            Natives._ConvertPlayerUnitEvent = Natives.Get("ConvertPlayerUnitEvent").ToDelegate<ConvertPlayerUnitEventPrototype>();
            Natives._ConvertWidgetEvent = Natives.Get("ConvertWidgetEvent").ToDelegate<ConvertWidgetEventPrototype>();
            Natives._ConvertDialogEvent = Natives.Get("ConvertDialogEvent").ToDelegate<ConvertDialogEventPrototype>();
            Natives._ConvertUnitEvent = Natives.Get("ConvertUnitEvent").ToDelegate<ConvertUnitEventPrototype>();
            Natives._ConvertLimitOp = Natives.Get("ConvertLimitOp").ToDelegate<ConvertLimitOpPrototype>();
            Natives._ConvertUnitType = Natives.Get("ConvertUnitType").ToDelegate<ConvertUnitTypePrototype>();
            Natives._ConvertGameSpeed = Natives.Get("ConvertGameSpeed").ToDelegate<ConvertGameSpeedPrototype>();
            Natives._ConvertPlacement = Natives.Get("ConvertPlacement").ToDelegate<ConvertPlacementPrototype>();
            Natives._ConvertStartLocPrio = Natives.Get("ConvertStartLocPrio").ToDelegate<ConvertStartLocPrioPrototype>();
            Natives._ConvertGameDifficulty = Natives.Get("ConvertGameDifficulty").ToDelegate<ConvertGameDifficultyPrototype>();
            Natives._ConvertGameType = Natives.Get("ConvertGameType").ToDelegate<ConvertGameTypePrototype>();
            Natives._ConvertMapFlag = Natives.Get("ConvertMapFlag").ToDelegate<ConvertMapFlagPrototype>();
            Natives._ConvertMapVisibility = Natives.Get("ConvertMapVisibility").ToDelegate<ConvertMapVisibilityPrototype>();
            Natives._ConvertMapSetting = Natives.Get("ConvertMapSetting").ToDelegate<ConvertMapSettingPrototype>();
            Natives._ConvertMapDensity = Natives.Get("ConvertMapDensity").ToDelegate<ConvertMapDensityPrototype>();
            Natives._ConvertMapControl = Natives.Get("ConvertMapControl").ToDelegate<ConvertMapControlPrototype>();
            Natives._ConvertPlayerColor = Natives.Get("ConvertPlayerColor").ToDelegate<ConvertPlayerColorPrototype>();
            Natives._ConvertPlayerSlotState = Natives.Get("ConvertPlayerSlotState").ToDelegate<ConvertPlayerSlotStatePrototype>();
            Natives._ConvertVolumeGroup = Natives.Get("ConvertVolumeGroup").ToDelegate<ConvertVolumeGroupPrototype>();
            Natives._ConvertCameraField = Natives.Get("ConvertCameraField").ToDelegate<ConvertCameraFieldPrototype>();
            Natives._ConvertBlendMode = Natives.Get("ConvertBlendMode").ToDelegate<ConvertBlendModePrototype>();
            Natives._ConvertRarityControl = Natives.Get("ConvertRarityControl").ToDelegate<ConvertRarityControlPrototype>();
            Natives._ConvertTexMapFlags = Natives.Get("ConvertTexMapFlags").ToDelegate<ConvertTexMapFlagsPrototype>();
            Natives._ConvertFogState = Natives.Get("ConvertFogState").ToDelegate<ConvertFogStatePrototype>();
            Natives._ConvertEffectType = Natives.Get("ConvertEffectType").ToDelegate<ConvertEffectTypePrototype>();
            Natives._ConvertVersion = Natives.Get("ConvertVersion").ToDelegate<ConvertVersionPrototype>();
            Natives._ConvertItemType = Natives.Get("ConvertItemType").ToDelegate<ConvertItemTypePrototype>();
            Natives._ConvertAttackType = Natives.Get("ConvertAttackType").ToDelegate<ConvertAttackTypePrototype>();
            Natives._ConvertDamageType = Natives.Get("ConvertDamageType").ToDelegate<ConvertDamageTypePrototype>();
            Natives._ConvertWeaponType = Natives.Get("ConvertWeaponType").ToDelegate<ConvertWeaponTypePrototype>();
            Natives._ConvertSoundType = Natives.Get("ConvertSoundType").ToDelegate<ConvertSoundTypePrototype>();
            Natives._ConvertPathingType = Natives.Get("ConvertPathingType").ToDelegate<ConvertPathingTypePrototype>();
            Natives._OrderId = Natives.Get("OrderId").ToDelegate<OrderIdPrototype>();
            Natives._OrderId2String = Natives.Get("OrderId2String").ToDelegate<OrderId2StringPrototype>();
            Natives._UnitId = Natives.Get("UnitId").ToDelegate<UnitIdPrototype>();
            Natives._UnitId2String = Natives.Get("UnitId2String").ToDelegate<UnitId2StringPrototype>();
            Natives._AbilityId = Natives.Get("AbilityId").ToDelegate<AbilityIdPrototype>();
            Natives._AbilityId2String = Natives.Get("AbilityId2String").ToDelegate<AbilityId2StringPrototype>();
            Natives._GetObjectName = Natives.Get("GetObjectName").ToDelegate<GetObjectNamePrototype>();
            Natives._Deg2Rad = Natives.Get("Deg2Rad").ToDelegate<Deg2RadPrototype>();
            Natives._Rad2Deg = Natives.Get("Rad2Deg").ToDelegate<Rad2DegPrototype>();
            Natives._Sin = Natives.Get("Sin").ToDelegate<SinPrototype>();
            Natives._Cos = Natives.Get("Cos").ToDelegate<CosPrototype>();
            Natives._Tan = Natives.Get("Tan").ToDelegate<TanPrototype>();
            Natives._Asin = Natives.Get("Asin").ToDelegate<AsinPrototype>();
            Natives._Acos = Natives.Get("Acos").ToDelegate<AcosPrototype>();
            Natives._Atan = Natives.Get("Atan").ToDelegate<AtanPrototype>();
            Natives._Atan2 = Natives.Get("Atan2").ToDelegate<Atan2Prototype>();
            Natives._SquareRoot = Natives.Get("SquareRoot").ToDelegate<SquareRootPrototype>();
            Natives._Pow = Natives.Get("Pow").ToDelegate<PowPrototype>();
            Natives._I2R = Natives.Get("I2R").ToDelegate<I2RPrototype>();
            Natives._R2I = Natives.Get("R2I").ToDelegate<R2IPrototype>();
            Natives._I2S = Natives.Get("I2S").ToDelegate<I2SPrototype>();
            Natives._R2S = Natives.Get("R2S").ToDelegate<R2SPrototype>();
            Natives._R2SW = Natives.Get("R2SW").ToDelegate<R2SWPrototype>();
            Natives._S2I = Natives.Get("S2I").ToDelegate<S2IPrototype>();
            Natives._S2R = Natives.Get("S2R").ToDelegate<S2RPrototype>();
            Natives._GetHandleId = Natives.Get("GetHandleId").ToDelegate<GetHandleIdPrototype>();
            Natives._SubString = Natives.Get("SubString").ToDelegate<SubStringPrototype>();
            Natives._StringLength = Natives.Get("StringLength").ToDelegate<StringLengthPrototype>();
            Natives._StringCase = Natives.Get("StringCase").ToDelegate<StringCasePrototype>();
            Natives._StringHash = Natives.Get("StringHash").ToDelegate<StringHashPrototype>();
            Natives._GetLocalizedString = Natives.Get("GetLocalizedString").ToDelegate<GetLocalizedStringPrototype>();
            Natives._GetLocalizedHotkey = Natives.Get("GetLocalizedHotkey").ToDelegate<GetLocalizedHotkeyPrototype>();
            Natives._SetMapName = Natives.Get("SetMapName").ToDelegate<SetMapNamePrototype>();
            Natives._SetMapDescription = Natives.Get("SetMapDescription").ToDelegate<SetMapDescriptionPrototype>();
            Natives._SetTeams = Natives.Get("SetTeams").ToDelegate<SetTeamsPrototype>();
            Natives._SetPlayers = Natives.Get("SetPlayers").ToDelegate<SetPlayersPrototype>();
            Natives._DefineStartLocation = Natives.Get("DefineStartLocation").ToDelegate<DefineStartLocationPrototype>();
            Natives._DefineStartLocationLoc = Natives.Get("DefineStartLocationLoc").ToDelegate<DefineStartLocationLocPrototype>();
            Natives._SetStartLocPrioCount = Natives.Get("SetStartLocPrioCount").ToDelegate<SetStartLocPrioCountPrototype>();
            Natives._SetStartLocPrio = Natives.Get("SetStartLocPrio").ToDelegate<SetStartLocPrioPrototype>();
            Natives._GetStartLocPrioSlot = Natives.Get("GetStartLocPrioSlot").ToDelegate<GetStartLocPrioSlotPrototype>();
            Natives._GetStartLocPrio = Natives.Get("GetStartLocPrio").ToDelegate<GetStartLocPrioPrototype>();
            Natives._SetGameTypeSupported = Natives.Get("SetGameTypeSupported").ToDelegate<SetGameTypeSupportedPrototype>();
            Natives._SetMapFlag = Natives.Get("SetMapFlag").ToDelegate<SetMapFlagPrototype>();
            Natives._SetGamePlacement = Natives.Get("SetGamePlacement").ToDelegate<SetGamePlacementPrototype>();
            Natives._SetGameSpeed = Natives.Get("SetGameSpeed").ToDelegate<SetGameSpeedPrototype>();
            Natives._SetGameDifficulty = Natives.Get("SetGameDifficulty").ToDelegate<SetGameDifficultyPrototype>();
            Natives._SetResourceDensity = Natives.Get("SetResourceDensity").ToDelegate<SetResourceDensityPrototype>();
            Natives._SetCreatureDensity = Natives.Get("SetCreatureDensity").ToDelegate<SetCreatureDensityPrototype>();
            Natives._GetTeams = Natives.Get("GetTeams").ToDelegate<GetTeamsPrototype>();
            Natives._GetPlayers = Natives.Get("GetPlayers").ToDelegate<GetPlayersPrototype>();
            Natives._IsGameTypeSupported = Natives.Get("IsGameTypeSupported").ToDelegate<IsGameTypeSupportedPrototype>();
            Natives._GetGameTypeSelected = Natives.Get("GetGameTypeSelected").ToDelegate<GetGameTypeSelectedPrototype>();
            Natives._IsMapFlagSet = Natives.Get("IsMapFlagSet").ToDelegate<IsMapFlagSetPrototype>();
            Natives._GetGamePlacement = Natives.Get("GetGamePlacement").ToDelegate<GetGamePlacementPrototype>();
            Natives._GetGameSpeed = Natives.Get("GetGameSpeed").ToDelegate<GetGameSpeedPrototype>();
            Natives._GetGameDifficulty = Natives.Get("GetGameDifficulty").ToDelegate<GetGameDifficultyPrototype>();
            Natives._GetResourceDensity = Natives.Get("GetResourceDensity").ToDelegate<GetResourceDensityPrototype>();
            Natives._GetCreatureDensity = Natives.Get("GetCreatureDensity").ToDelegate<GetCreatureDensityPrototype>();
            Natives._GetStartLocationX = Natives.Get("GetStartLocationX").ToDelegate<GetStartLocationXPrototype>();
            Natives._GetStartLocationY = Natives.Get("GetStartLocationY").ToDelegate<GetStartLocationYPrototype>();
            Natives._GetStartLocationLoc = Natives.Get("GetStartLocationLoc").ToDelegate<GetStartLocationLocPrototype>();
            Natives._SetPlayerTeam = Natives.Get("SetPlayerTeam").ToDelegate<SetPlayerTeamPrototype>();
            Natives._SetPlayerStartLocation = Natives.Get("SetPlayerStartLocation").ToDelegate<SetPlayerStartLocationPrototype>();
            Natives._ForcePlayerStartLocation = Natives.Get("ForcePlayerStartLocation").ToDelegate<ForcePlayerStartLocationPrototype>();
            Natives._SetPlayerColor = Natives.Get("SetPlayerColor").ToDelegate<SetPlayerColorPrototype>();
            Natives._SetPlayerAlliance = Natives.Get("SetPlayerAlliance").ToDelegate<SetPlayerAlliancePrototype>();
            Natives._SetPlayerTaxRate = Natives.Get("SetPlayerTaxRate").ToDelegate<SetPlayerTaxRatePrototype>();
            Natives._SetPlayerRacePreference = Natives.Get("SetPlayerRacePreference").ToDelegate<SetPlayerRacePreferencePrototype>();
            Natives._SetPlayerRaceSelectable = Natives.Get("SetPlayerRaceSelectable").ToDelegate<SetPlayerRaceSelectablePrototype>();
            Natives._SetPlayerController = Natives.Get("SetPlayerController").ToDelegate<SetPlayerControllerPrototype>();
            Natives._SetPlayerName = Natives.Get("SetPlayerName").ToDelegate<SetPlayerNamePrototype>();
            Natives._SetPlayerOnScoreScreen = Natives.Get("SetPlayerOnScoreScreen").ToDelegate<SetPlayerOnScoreScreenPrototype>();
            Natives._GetPlayerTeam = Natives.Get("GetPlayerTeam").ToDelegate<GetPlayerTeamPrototype>();
            Natives._GetPlayerStartLocation = Natives.Get("GetPlayerStartLocation").ToDelegate<GetPlayerStartLocationPrototype>();
            Natives._GetPlayerColor = Natives.Get("GetPlayerColor").ToDelegate<GetPlayerColorPrototype>();
            Natives._GetPlayerSelectable = Natives.Get("GetPlayerSelectable").ToDelegate<GetPlayerSelectablePrototype>();
            Natives._GetPlayerController = Natives.Get("GetPlayerController").ToDelegate<GetPlayerControllerPrototype>();
            Natives._GetPlayerSlotState = Natives.Get("GetPlayerSlotState").ToDelegate<GetPlayerSlotStatePrototype>();
            Natives._GetPlayerTaxRate = Natives.Get("GetPlayerTaxRate").ToDelegate<GetPlayerTaxRatePrototype>();
            Natives._IsPlayerRacePrefSet = Natives.Get("IsPlayerRacePrefSet").ToDelegate<IsPlayerRacePrefSetPrototype>();
            Natives._GetPlayerName = Natives.Get("GetPlayerName").ToDelegate<GetPlayerNamePrototype>();
            Natives._CreateTimer = Natives.Get("CreateTimer").ToDelegate<CreateTimerPrototype>();
            Natives._DestroyTimer = Natives.Get("DestroyTimer").ToDelegate<DestroyTimerPrototype>();
            Natives._TimerStart = Natives.Get("TimerStart").ToDelegate<TimerStartPrototype>();
            Natives._TimerGetElapsed = Natives.Get("TimerGetElapsed").ToDelegate<TimerGetElapsedPrototype>();
            Natives._TimerGetRemaining = Natives.Get("TimerGetRemaining").ToDelegate<TimerGetRemainingPrototype>();
            Natives._TimerGetTimeout = Natives.Get("TimerGetTimeout").ToDelegate<TimerGetTimeoutPrototype>();
            Natives._PauseTimer = Natives.Get("PauseTimer").ToDelegate<PauseTimerPrototype>();
            Natives._ResumeTimer = Natives.Get("ResumeTimer").ToDelegate<ResumeTimerPrototype>();
            Natives._GetExpiredTimer = Natives.Get("GetExpiredTimer").ToDelegate<GetExpiredTimerPrototype>();
            Natives._CreateGroup = Natives.Get("CreateGroup").ToDelegate<CreateGroupPrototype>();
            Natives._DestroyGroup = Natives.Get("DestroyGroup").ToDelegate<DestroyGroupPrototype>();
            Natives._GroupAddUnit = Natives.Get("GroupAddUnit").ToDelegate<GroupAddUnitPrototype>();
            Natives._GroupRemoveUnit = Natives.Get("GroupRemoveUnit").ToDelegate<GroupRemoveUnitPrototype>();
            Natives._GroupClear = Natives.Get("GroupClear").ToDelegate<GroupClearPrototype>();
            Natives._GroupEnumUnitsOfType = Natives.Get("GroupEnumUnitsOfType").ToDelegate<GroupEnumUnitsOfTypePrototype>();
            Natives._GroupEnumUnitsOfPlayer = Natives.Get("GroupEnumUnitsOfPlayer").ToDelegate<GroupEnumUnitsOfPlayerPrototype>();
            Natives._GroupEnumUnitsOfTypeCounted = Natives.Get("GroupEnumUnitsOfTypeCounted").ToDelegate<GroupEnumUnitsOfTypeCountedPrototype>();
            Natives._GroupEnumUnitsInRect = Natives.Get("GroupEnumUnitsInRect").ToDelegate<GroupEnumUnitsInRectPrototype>();
            Natives._GroupEnumUnitsInRectCounted = Natives.Get("GroupEnumUnitsInRectCounted").ToDelegate<GroupEnumUnitsInRectCountedPrototype>();
            Natives._GroupEnumUnitsInRange = Natives.Get("GroupEnumUnitsInRange").ToDelegate<GroupEnumUnitsInRangePrototype>();
            Natives._GroupEnumUnitsInRangeOfLoc = Natives.Get("GroupEnumUnitsInRangeOfLoc").ToDelegate<GroupEnumUnitsInRangeOfLocPrototype>();
            Natives._GroupEnumUnitsInRangeCounted = Natives.Get("GroupEnumUnitsInRangeCounted").ToDelegate<GroupEnumUnitsInRangeCountedPrototype>();
            Natives._GroupEnumUnitsInRangeOfLocCounted = Natives.Get("GroupEnumUnitsInRangeOfLocCounted").ToDelegate<GroupEnumUnitsInRangeOfLocCountedPrototype>();
            Natives._GroupEnumUnitsSelected = Natives.Get("GroupEnumUnitsSelected").ToDelegate<GroupEnumUnitsSelectedPrototype>();
            Natives._GroupImmediateOrder = Natives.Get("GroupImmediateOrder").ToDelegate<GroupImmediateOrderPrototype>();
            Natives._GroupImmediateOrderById = Natives.Get("GroupImmediateOrderById").ToDelegate<GroupImmediateOrderByIdPrototype>();
            Natives._GroupPointOrder = Natives.Get("GroupPointOrder").ToDelegate<GroupPointOrderPrototype>();
            Natives._GroupPointOrderLoc = Natives.Get("GroupPointOrderLoc").ToDelegate<GroupPointOrderLocPrototype>();
            Natives._GroupPointOrderById = Natives.Get("GroupPointOrderById").ToDelegate<GroupPointOrderByIdPrototype>();
            Natives._GroupPointOrderByIdLoc = Natives.Get("GroupPointOrderByIdLoc").ToDelegate<GroupPointOrderByIdLocPrototype>();
            Natives._GroupTargetOrder = Natives.Get("GroupTargetOrder").ToDelegate<GroupTargetOrderPrototype>();
            Natives._GroupTargetOrderById = Natives.Get("GroupTargetOrderById").ToDelegate<GroupTargetOrderByIdPrototype>();
            Natives._ForGroup = Natives.Get("ForGroup").ToDelegate<ForGroupPrototype>();
            Natives._FirstOfGroup = Natives.Get("FirstOfGroup").ToDelegate<FirstOfGroupPrototype>();
            Natives._CreateForce = Natives.Get("CreateForce").ToDelegate<CreateForcePrototype>();
            Natives._DestroyForce = Natives.Get("DestroyForce").ToDelegate<DestroyForcePrototype>();
            Natives._ForceAddPlayer = Natives.Get("ForceAddPlayer").ToDelegate<ForceAddPlayerPrototype>();
            Natives._ForceRemovePlayer = Natives.Get("ForceRemovePlayer").ToDelegate<ForceRemovePlayerPrototype>();
            Natives._ForceClear = Natives.Get("ForceClear").ToDelegate<ForceClearPrototype>();
            Natives._ForceEnumPlayers = Natives.Get("ForceEnumPlayers").ToDelegate<ForceEnumPlayersPrototype>();
            Natives._ForceEnumPlayersCounted = Natives.Get("ForceEnumPlayersCounted").ToDelegate<ForceEnumPlayersCountedPrototype>();
            Natives._ForceEnumAllies = Natives.Get("ForceEnumAllies").ToDelegate<ForceEnumAlliesPrototype>();
            Natives._ForceEnumEnemies = Natives.Get("ForceEnumEnemies").ToDelegate<ForceEnumEnemiesPrototype>();
            Natives._ForForce = Natives.Get("ForForce").ToDelegate<ForForcePrototype>();
            Natives._Rect = Natives.Get("Rect").ToDelegate<RectPrototype>();
            Natives._RectFromLoc = Natives.Get("RectFromLoc").ToDelegate<RectFromLocPrototype>();
            Natives._RemoveRect = Natives.Get("RemoveRect").ToDelegate<RemoveRectPrototype>();
            Natives._SetRect = Natives.Get("SetRect").ToDelegate<SetRectPrototype>();
            Natives._SetRectFromLoc = Natives.Get("SetRectFromLoc").ToDelegate<SetRectFromLocPrototype>();
            Natives._MoveRectTo = Natives.Get("MoveRectTo").ToDelegate<MoveRectToPrototype>();
            Natives._MoveRectToLoc = Natives.Get("MoveRectToLoc").ToDelegate<MoveRectToLocPrototype>();
            Natives._GetRectCenterX = Natives.Get("GetRectCenterX").ToDelegate<GetRectCenterXPrototype>();
            Natives._GetRectCenterY = Natives.Get("GetRectCenterY").ToDelegate<GetRectCenterYPrototype>();
            Natives._GetRectMinX = Natives.Get("GetRectMinX").ToDelegate<GetRectMinXPrototype>();
            Natives._GetRectMinY = Natives.Get("GetRectMinY").ToDelegate<GetRectMinYPrototype>();
            Natives._GetRectMaxX = Natives.Get("GetRectMaxX").ToDelegate<GetRectMaxXPrototype>();
            Natives._GetRectMaxY = Natives.Get("GetRectMaxY").ToDelegate<GetRectMaxYPrototype>();
            Natives._CreateRegion = Natives.Get("CreateRegion").ToDelegate<CreateRegionPrototype>();
            Natives._RemoveRegion = Natives.Get("RemoveRegion").ToDelegate<RemoveRegionPrototype>();
            Natives._RegionAddRect = Natives.Get("RegionAddRect").ToDelegate<RegionAddRectPrototype>();
            Natives._RegionClearRect = Natives.Get("RegionClearRect").ToDelegate<RegionClearRectPrototype>();
            Natives._RegionAddCell = Natives.Get("RegionAddCell").ToDelegate<RegionAddCellPrototype>();
            Natives._RegionAddCellAtLoc = Natives.Get("RegionAddCellAtLoc").ToDelegate<RegionAddCellAtLocPrototype>();
            Natives._RegionClearCell = Natives.Get("RegionClearCell").ToDelegate<RegionClearCellPrototype>();
            Natives._RegionClearCellAtLoc = Natives.Get("RegionClearCellAtLoc").ToDelegate<RegionClearCellAtLocPrototype>();
            Natives._Location = Natives.Get("Location").ToDelegate<LocationPrototype>();
            Natives._RemoveLocation = Natives.Get("RemoveLocation").ToDelegate<RemoveLocationPrototype>();
            Natives._MoveLocation = Natives.Get("MoveLocation").ToDelegate<MoveLocationPrototype>();
            Natives._GetLocationX = Natives.Get("GetLocationX").ToDelegate<GetLocationXPrototype>();
            Natives._GetLocationY = Natives.Get("GetLocationY").ToDelegate<GetLocationYPrototype>();
            Natives._GetLocationZ = Natives.Get("GetLocationZ").ToDelegate<GetLocationZPrototype>();
            Natives._IsUnitInRegion = Natives.Get("IsUnitInRegion").ToDelegate<IsUnitInRegionPrototype>();
            Natives._IsPointInRegion = Natives.Get("IsPointInRegion").ToDelegate<IsPointInRegionPrototype>();
            Natives._IsLocationInRegion = Natives.Get("IsLocationInRegion").ToDelegate<IsLocationInRegionPrototype>();
            Natives._GetWorldBounds = Natives.Get("GetWorldBounds").ToDelegate<GetWorldBoundsPrototype>();
            Natives._CreateTrigger = Natives.Get("CreateTrigger").ToDelegate<CreateTriggerPrototype>();
            Natives._DestroyTrigger = Natives.Get("DestroyTrigger").ToDelegate<DestroyTriggerPrototype>();
            Natives._ResetTrigger = Natives.Get("ResetTrigger").ToDelegate<ResetTriggerPrototype>();
            Natives._EnableTrigger = Natives.Get("EnableTrigger").ToDelegate<EnableTriggerPrototype>();
            Natives._DisableTrigger = Natives.Get("DisableTrigger").ToDelegate<DisableTriggerPrototype>();
            Natives._IsTriggerEnabled = Natives.Get("IsTriggerEnabled").ToDelegate<IsTriggerEnabledPrototype>();
            Natives._TriggerWaitOnSleeps = Natives.Get("TriggerWaitOnSleeps").ToDelegate<TriggerWaitOnSleepsPrototype>();
            Natives._IsTriggerWaitOnSleeps = Natives.Get("IsTriggerWaitOnSleeps").ToDelegate<IsTriggerWaitOnSleepsPrototype>();
            Natives._GetFilterUnit = Natives.Get("GetFilterUnit").ToDelegate<GetFilterUnitPrototype>();
            Natives._GetEnumUnit = Natives.Get("GetEnumUnit").ToDelegate<GetEnumUnitPrototype>();
            Natives._GetFilterDestructable = Natives.Get("GetFilterDestructable").ToDelegate<GetFilterDestructablePrototype>();
            Natives._GetEnumDestructable = Natives.Get("GetEnumDestructable").ToDelegate<GetEnumDestructablePrototype>();
            Natives._GetFilterItem = Natives.Get("GetFilterItem").ToDelegate<GetFilterItemPrototype>();
            Natives._GetEnumItem = Natives.Get("GetEnumItem").ToDelegate<GetEnumItemPrototype>();
            Natives._GetFilterPlayer = Natives.Get("GetFilterPlayer").ToDelegate<GetFilterPlayerPrototype>();
            Natives._GetEnumPlayer = Natives.Get("GetEnumPlayer").ToDelegate<GetEnumPlayerPrototype>();
            Natives._GetTriggeringTrigger = Natives.Get("GetTriggeringTrigger").ToDelegate<GetTriggeringTriggerPrototype>();
            Natives._GetTriggerEventId = Natives.Get("GetTriggerEventId").ToDelegate<GetTriggerEventIdPrototype>();
            Natives._GetTriggerEvalCount = Natives.Get("GetTriggerEvalCount").ToDelegate<GetTriggerEvalCountPrototype>();
            Natives._GetTriggerExecCount = Natives.Get("GetTriggerExecCount").ToDelegate<GetTriggerExecCountPrototype>();
            Natives._ExecuteFunc = Natives.Get("ExecuteFunc").ToDelegate<ExecuteFuncPrototype>();
            Natives._And = Natives.Get("And").ToDelegate<AndPrototype>();
            Natives._Or = Natives.Get("Or").ToDelegate<OrPrototype>();
            Natives._Not = Natives.Get("Not").ToDelegate<NotPrototype>();
            Natives._Condition = Natives.Get("Condition").ToDelegate<ConditionPrototype>();
            Natives._DestroyCondition = Natives.Get("DestroyCondition").ToDelegate<DestroyConditionPrototype>();
            Natives._Filter = Natives.Get("Filter").ToDelegate<FilterPrototype>();
            Natives._DestroyFilter = Natives.Get("DestroyFilter").ToDelegate<DestroyFilterPrototype>();
            Natives._DestroyBoolExpr = Natives.Get("DestroyBoolExpr").ToDelegate<DestroyBoolExprPrototype>();
            Natives._TriggerRegisterVariableEvent = Natives.Get("TriggerRegisterVariableEvent").ToDelegate<TriggerRegisterVariableEventPrototype>();
            Natives._TriggerRegisterTimerEvent = Natives.Get("TriggerRegisterTimerEvent").ToDelegate<TriggerRegisterTimerEventPrototype>();
            Natives._TriggerRegisterTimerExpireEvent = Natives.Get("TriggerRegisterTimerExpireEvent").ToDelegate<TriggerRegisterTimerExpireEventPrototype>();
            Natives._TriggerRegisterGameStateEvent = Natives.Get("TriggerRegisterGameStateEvent").ToDelegate<TriggerRegisterGameStateEventPrototype>();
            Natives._TriggerRegisterDialogEvent = Natives.Get("TriggerRegisterDialogEvent").ToDelegate<TriggerRegisterDialogEventPrototype>();
            Natives._TriggerRegisterDialogButtonEvent = Natives.Get("TriggerRegisterDialogButtonEvent").ToDelegate<TriggerRegisterDialogButtonEventPrototype>();
            Natives._GetEventGameState = Natives.Get("GetEventGameState").ToDelegate<GetEventGameStatePrototype>();
            Natives._TriggerRegisterGameEvent = Natives.Get("TriggerRegisterGameEvent").ToDelegate<TriggerRegisterGameEventPrototype>();
            Natives._GetWinningPlayer = Natives.Get("GetWinningPlayer").ToDelegate<GetWinningPlayerPrototype>();
            Natives._TriggerRegisterEnterRegion = Natives.Get("TriggerRegisterEnterRegion").ToDelegate<TriggerRegisterEnterRegionPrototype>();
            Natives._GetTriggeringRegion = Natives.Get("GetTriggeringRegion").ToDelegate<GetTriggeringRegionPrototype>();
            Natives._GetEnteringUnit = Natives.Get("GetEnteringUnit").ToDelegate<GetEnteringUnitPrototype>();
            Natives._TriggerRegisterLeaveRegion = Natives.Get("TriggerRegisterLeaveRegion").ToDelegate<TriggerRegisterLeaveRegionPrototype>();
            Natives._GetLeavingUnit = Natives.Get("GetLeavingUnit").ToDelegate<GetLeavingUnitPrototype>();
            Natives._TriggerRegisterTrackableHitEvent = Natives.Get("TriggerRegisterTrackableHitEvent").ToDelegate<TriggerRegisterTrackableHitEventPrototype>();
            Natives._TriggerRegisterTrackableTrackEvent = Natives.Get("TriggerRegisterTrackableTrackEvent").ToDelegate<TriggerRegisterTrackableTrackEventPrototype>();
            Natives._GetTriggeringTrackable = Natives.Get("GetTriggeringTrackable").ToDelegate<GetTriggeringTrackablePrototype>();
            Natives._GetClickedButton = Natives.Get("GetClickedButton").ToDelegate<GetClickedButtonPrototype>();
            Natives._GetClickedDialog = Natives.Get("GetClickedDialog").ToDelegate<GetClickedDialogPrototype>();
            Natives._GetTournamentFinishSoonTimeRemaining = Natives.Get("GetTournamentFinishSoonTimeRemaining").ToDelegate<GetTournamentFinishSoonTimeRemainingPrototype>();
            Natives._GetTournamentFinishNowRule = Natives.Get("GetTournamentFinishNowRule").ToDelegate<GetTournamentFinishNowRulePrototype>();
            Natives._GetTournamentFinishNowPlayer = Natives.Get("GetTournamentFinishNowPlayer").ToDelegate<GetTournamentFinishNowPlayerPrototype>();
            Natives._GetTournamentScore = Natives.Get("GetTournamentScore").ToDelegate<GetTournamentScorePrototype>();
            Natives._GetSaveBasicFilename = Natives.Get("GetSaveBasicFilename").ToDelegate<GetSaveBasicFilenamePrototype>();
            Natives._TriggerRegisterPlayerEvent = Natives.Get("TriggerRegisterPlayerEvent").ToDelegate<TriggerRegisterPlayerEventPrototype>();
            Natives._GetTriggerPlayer = Natives.Get("GetTriggerPlayer").ToDelegate<GetTriggerPlayerPrototype>();
            Natives._TriggerRegisterPlayerUnitEvent = Natives.Get("TriggerRegisterPlayerUnitEvent").ToDelegate<TriggerRegisterPlayerUnitEventPrototype>();
            Natives._GetLevelingUnit = Natives.Get("GetLevelingUnit").ToDelegate<GetLevelingUnitPrototype>();
            Natives._GetLearningUnit = Natives.Get("GetLearningUnit").ToDelegate<GetLearningUnitPrototype>();
            Natives._GetLearnedSkill = Natives.Get("GetLearnedSkill").ToDelegate<GetLearnedSkillPrototype>();
            Natives._GetLearnedSkillLevel = Natives.Get("GetLearnedSkillLevel").ToDelegate<GetLearnedSkillLevelPrototype>();
            Natives._GetRevivableUnit = Natives.Get("GetRevivableUnit").ToDelegate<GetRevivableUnitPrototype>();
            Natives._GetRevivingUnit = Natives.Get("GetRevivingUnit").ToDelegate<GetRevivingUnitPrototype>();
            Natives._GetAttacker = Natives.Get("GetAttacker").ToDelegate<GetAttackerPrototype>();
            Natives._GetRescuer = Natives.Get("GetRescuer").ToDelegate<GetRescuerPrototype>();
            Natives._GetDyingUnit = Natives.Get("GetDyingUnit").ToDelegate<GetDyingUnitPrototype>();
            Natives._GetKillingUnit = Natives.Get("GetKillingUnit").ToDelegate<GetKillingUnitPrototype>();
            Natives._GetDecayingUnit = Natives.Get("GetDecayingUnit").ToDelegate<GetDecayingUnitPrototype>();
            Natives._GetConstructingStructure = Natives.Get("GetConstructingStructure").ToDelegate<GetConstructingStructurePrototype>();
            Natives._GetCancelledStructure = Natives.Get("GetCancelledStructure").ToDelegate<GetCancelledStructurePrototype>();
            Natives._GetConstructedStructure = Natives.Get("GetConstructedStructure").ToDelegate<GetConstructedStructurePrototype>();
            Natives._GetResearchingUnit = Natives.Get("GetResearchingUnit").ToDelegate<GetResearchingUnitPrototype>();
            Natives._GetResearched = Natives.Get("GetResearched").ToDelegate<GetResearchedPrototype>();
            Natives._GetTrainedUnitType = Natives.Get("GetTrainedUnitType").ToDelegate<GetTrainedUnitTypePrototype>();
            Natives._GetTrainedUnit = Natives.Get("GetTrainedUnit").ToDelegate<GetTrainedUnitPrototype>();
            Natives._GetDetectedUnit = Natives.Get("GetDetectedUnit").ToDelegate<GetDetectedUnitPrototype>();
            Natives._GetSummoningUnit = Natives.Get("GetSummoningUnit").ToDelegate<GetSummoningUnitPrototype>();
            Natives._GetSummonedUnit = Natives.Get("GetSummonedUnit").ToDelegate<GetSummonedUnitPrototype>();
            Natives._GetTransportUnit = Natives.Get("GetTransportUnit").ToDelegate<GetTransportUnitPrototype>();
            Natives._GetLoadedUnit = Natives.Get("GetLoadedUnit").ToDelegate<GetLoadedUnitPrototype>();
            Natives._GetSellingUnit = Natives.Get("GetSellingUnit").ToDelegate<GetSellingUnitPrototype>();
            Natives._GetSoldUnit = Natives.Get("GetSoldUnit").ToDelegate<GetSoldUnitPrototype>();
            Natives._GetBuyingUnit = Natives.Get("GetBuyingUnit").ToDelegate<GetBuyingUnitPrototype>();
            Natives._GetSoldItem = Natives.Get("GetSoldItem").ToDelegate<GetSoldItemPrototype>();
            Natives._GetChangingUnit = Natives.Get("GetChangingUnit").ToDelegate<GetChangingUnitPrototype>();
            Natives._GetChangingUnitPrevOwner = Natives.Get("GetChangingUnitPrevOwner").ToDelegate<GetChangingUnitPrevOwnerPrototype>();
            Natives._GetManipulatingUnit = Natives.Get("GetManipulatingUnit").ToDelegate<GetManipulatingUnitPrototype>();
            Natives._GetManipulatedItem = Natives.Get("GetManipulatedItem").ToDelegate<GetManipulatedItemPrototype>();
            Natives._GetOrderedUnit = Natives.Get("GetOrderedUnit").ToDelegate<GetOrderedUnitPrototype>();
            Natives._GetIssuedOrderId = Natives.Get("GetIssuedOrderId").ToDelegate<GetIssuedOrderIdPrototype>();
            Natives._GetOrderPointX = Natives.Get("GetOrderPointX").ToDelegate<GetOrderPointXPrototype>();
            Natives._GetOrderPointY = Natives.Get("GetOrderPointY").ToDelegate<GetOrderPointYPrototype>();
            Natives._GetOrderPointLoc = Natives.Get("GetOrderPointLoc").ToDelegate<GetOrderPointLocPrototype>();
            Natives._GetOrderTarget = Natives.Get("GetOrderTarget").ToDelegate<GetOrderTargetPrototype>();
            Natives._GetOrderTargetDestructable = Natives.Get("GetOrderTargetDestructable").ToDelegate<GetOrderTargetDestructablePrototype>();
            Natives._GetOrderTargetItem = Natives.Get("GetOrderTargetItem").ToDelegate<GetOrderTargetItemPrototype>();
            Natives._GetOrderTargetUnit = Natives.Get("GetOrderTargetUnit").ToDelegate<GetOrderTargetUnitPrototype>();
            Natives._GetSpellAbilityUnit = Natives.Get("GetSpellAbilityUnit").ToDelegate<GetSpellAbilityUnitPrototype>();
            Natives._GetSpellAbilityId = Natives.Get("GetSpellAbilityId").ToDelegate<GetSpellAbilityIdPrototype>();
            Natives._GetSpellAbility = Natives.Get("GetSpellAbility").ToDelegate<GetSpellAbilityPrototype>();
            Natives._GetSpellTargetLoc = Natives.Get("GetSpellTargetLoc").ToDelegate<GetSpellTargetLocPrototype>();
            Natives._GetSpellTargetX = Natives.Get("GetSpellTargetX").ToDelegate<GetSpellTargetXPrototype>();
            Natives._GetSpellTargetY = Natives.Get("GetSpellTargetY").ToDelegate<GetSpellTargetYPrototype>();
            Natives._GetSpellTargetDestructable = Natives.Get("GetSpellTargetDestructable").ToDelegate<GetSpellTargetDestructablePrototype>();
            Natives._GetSpellTargetItem = Natives.Get("GetSpellTargetItem").ToDelegate<GetSpellTargetItemPrototype>();
            Natives._GetSpellTargetUnit = Natives.Get("GetSpellTargetUnit").ToDelegate<GetSpellTargetUnitPrototype>();
            Natives._TriggerRegisterPlayerAllianceChange = Natives.Get("TriggerRegisterPlayerAllianceChange").ToDelegate<TriggerRegisterPlayerAllianceChangePrototype>();
            Natives._TriggerRegisterPlayerStateEvent = Natives.Get("TriggerRegisterPlayerStateEvent").ToDelegate<TriggerRegisterPlayerStateEventPrototype>();
            Natives._GetEventPlayerState = Natives.Get("GetEventPlayerState").ToDelegate<GetEventPlayerStatePrototype>();
            Natives._TriggerRegisterPlayerChatEvent = Natives.Get("TriggerRegisterPlayerChatEvent").ToDelegate<TriggerRegisterPlayerChatEventPrototype>();
            Natives._GetEventPlayerChatString = Natives.Get("GetEventPlayerChatString").ToDelegate<GetEventPlayerChatStringPrototype>();
            Natives._GetEventPlayerChatStringMatched = Natives.Get("GetEventPlayerChatStringMatched").ToDelegate<GetEventPlayerChatStringMatchedPrototype>();
            Natives._TriggerRegisterDeathEvent = Natives.Get("TriggerRegisterDeathEvent").ToDelegate<TriggerRegisterDeathEventPrototype>();
            Natives._GetTriggerUnit = Natives.Get("GetTriggerUnit").ToDelegate<GetTriggerUnitPrototype>();
            Natives._TriggerRegisterUnitStateEvent = Natives.Get("TriggerRegisterUnitStateEvent").ToDelegate<TriggerRegisterUnitStateEventPrototype>();
            Natives._GetEventUnitState = Natives.Get("GetEventUnitState").ToDelegate<GetEventUnitStatePrototype>();
            Natives._TriggerRegisterUnitEvent = Natives.Get("TriggerRegisterUnitEvent").ToDelegate<TriggerRegisterUnitEventPrototype>();
            Natives._GetEventDamage = Natives.Get("GetEventDamage").ToDelegate<GetEventDamagePrototype>();
            Natives._GetEventDamageSource = Natives.Get("GetEventDamageSource").ToDelegate<GetEventDamageSourcePrototype>();
            Natives._GetEventDetectingPlayer = Natives.Get("GetEventDetectingPlayer").ToDelegate<GetEventDetectingPlayerPrototype>();
            Natives._TriggerRegisterFilterUnitEvent = Natives.Get("TriggerRegisterFilterUnitEvent").ToDelegate<TriggerRegisterFilterUnitEventPrototype>();
            Natives._GetEventTargetUnit = Natives.Get("GetEventTargetUnit").ToDelegate<GetEventTargetUnitPrototype>();
            Natives._TriggerRegisterUnitInRange = Natives.Get("TriggerRegisterUnitInRange").ToDelegate<TriggerRegisterUnitInRangePrototype>();
            Natives._TriggerAddCondition = Natives.Get("TriggerAddCondition").ToDelegate<TriggerAddConditionPrototype>();
            Natives._TriggerRemoveCondition = Natives.Get("TriggerRemoveCondition").ToDelegate<TriggerRemoveConditionPrototype>();
            Natives._TriggerClearConditions = Natives.Get("TriggerClearConditions").ToDelegate<TriggerClearConditionsPrototype>();
            Natives._TriggerAddAction = Natives.Get("TriggerAddAction").ToDelegate<TriggerAddActionPrototype>();
            Natives._TriggerRemoveAction = Natives.Get("TriggerRemoveAction").ToDelegate<TriggerRemoveActionPrototype>();
            Natives._TriggerClearActions = Natives.Get("TriggerClearActions").ToDelegate<TriggerClearActionsPrototype>();
            Natives._TriggerSleepAction = Natives.Get("TriggerSleepAction").ToDelegate<TriggerSleepActionPrototype>();
            Natives._TriggerWaitForSound = Natives.Get("TriggerWaitForSound").ToDelegate<TriggerWaitForSoundPrototype>();
            Natives._TriggerEvaluate = Natives.Get("TriggerEvaluate").ToDelegate<TriggerEvaluatePrototype>();
            Natives._TriggerExecute = Natives.Get("TriggerExecute").ToDelegate<TriggerExecutePrototype>();
            Natives._TriggerExecuteWait = Natives.Get("TriggerExecuteWait").ToDelegate<TriggerExecuteWaitPrototype>();
            Natives._TriggerSyncStart = Natives.Get("TriggerSyncStart").ToDelegate<TriggerSyncStartPrototype>();
            Natives._TriggerSyncReady = Natives.Get("TriggerSyncReady").ToDelegate<TriggerSyncReadyPrototype>();
            Natives._GetWidgetLife = Natives.Get("GetWidgetLife").ToDelegate<GetWidgetLifePrototype>();
            Natives._SetWidgetLife = Natives.Get("SetWidgetLife").ToDelegate<SetWidgetLifePrototype>();
            Natives._GetWidgetX = Natives.Get("GetWidgetX").ToDelegate<GetWidgetXPrototype>();
            Natives._GetWidgetY = Natives.Get("GetWidgetY").ToDelegate<GetWidgetYPrototype>();
            Natives._GetTriggerWidget = Natives.Get("GetTriggerWidget").ToDelegate<GetTriggerWidgetPrototype>();
            Natives._CreateDestructable = Natives.Get("CreateDestructable").ToDelegate<CreateDestructablePrototype>();
            Natives._CreateDestructableZ = Natives.Get("CreateDestructableZ").ToDelegate<CreateDestructableZPrototype>();
            Natives._CreateDeadDestructable = Natives.Get("CreateDeadDestructable").ToDelegate<CreateDeadDestructablePrototype>();
            Natives._CreateDeadDestructableZ = Natives.Get("CreateDeadDestructableZ").ToDelegate<CreateDeadDestructableZPrototype>();
            Natives._RemoveDestructable = Natives.Get("RemoveDestructable").ToDelegate<RemoveDestructablePrototype>();
            Natives._KillDestructable = Natives.Get("KillDestructable").ToDelegate<KillDestructablePrototype>();
            Natives._SetDestructableInvulnerable = Natives.Get("SetDestructableInvulnerable").ToDelegate<SetDestructableInvulnerablePrototype>();
            Natives._IsDestructableInvulnerable = Natives.Get("IsDestructableInvulnerable").ToDelegate<IsDestructableInvulnerablePrototype>();
            Natives._EnumDestructablesInRect = Natives.Get("EnumDestructablesInRect").ToDelegate<EnumDestructablesInRectPrototype>();
            Natives._GetDestructableTypeId = Natives.Get("GetDestructableTypeId").ToDelegate<GetDestructableTypeIdPrototype>();
            Natives._GetDestructableX = Natives.Get("GetDestructableX").ToDelegate<GetDestructableXPrototype>();
            Natives._GetDestructableY = Natives.Get("GetDestructableY").ToDelegate<GetDestructableYPrototype>();
            Natives._SetDestructableLife = Natives.Get("SetDestructableLife").ToDelegate<SetDestructableLifePrototype>();
            Natives._GetDestructableLife = Natives.Get("GetDestructableLife").ToDelegate<GetDestructableLifePrototype>();
            Natives._SetDestructableMaxLife = Natives.Get("SetDestructableMaxLife").ToDelegate<SetDestructableMaxLifePrototype>();
            Natives._GetDestructableMaxLife = Natives.Get("GetDestructableMaxLife").ToDelegate<GetDestructableMaxLifePrototype>();
            Natives._DestructableRestoreLife = Natives.Get("DestructableRestoreLife").ToDelegate<DestructableRestoreLifePrototype>();
            Natives._QueueDestructableAnimation = Natives.Get("QueueDestructableAnimation").ToDelegate<QueueDestructableAnimationPrototype>();
            Natives._SetDestructableAnimation = Natives.Get("SetDestructableAnimation").ToDelegate<SetDestructableAnimationPrototype>();
            Natives._SetDestructableAnimationSpeed = Natives.Get("SetDestructableAnimationSpeed").ToDelegate<SetDestructableAnimationSpeedPrototype>();
            Natives._ShowDestructable = Natives.Get("ShowDestructable").ToDelegate<ShowDestructablePrototype>();
            Natives._GetDestructableOccluderHeight = Natives.Get("GetDestructableOccluderHeight").ToDelegate<GetDestructableOccluderHeightPrototype>();
            Natives._SetDestructableOccluderHeight = Natives.Get("SetDestructableOccluderHeight").ToDelegate<SetDestructableOccluderHeightPrototype>();
            Natives._GetDestructableName = Natives.Get("GetDestructableName").ToDelegate<GetDestructableNamePrototype>();
            Natives._GetTriggerDestructable = Natives.Get("GetTriggerDestructable").ToDelegate<GetTriggerDestructablePrototype>();
            Natives._CreateItem = Natives.Get("CreateItem").ToDelegate<CreateItemPrototype>();
            Natives._RemoveItem = Natives.Get("RemoveItem").ToDelegate<RemoveItemPrototype>();
            Natives._GetItemPlayer = Natives.Get("GetItemPlayer").ToDelegate<GetItemPlayerPrototype>();
            Natives._GetItemTypeId = Natives.Get("GetItemTypeId").ToDelegate<GetItemTypeIdPrototype>();
            Natives._GetItemX = Natives.Get("GetItemX").ToDelegate<GetItemXPrototype>();
            Natives._GetItemY = Natives.Get("GetItemY").ToDelegate<GetItemYPrototype>();
            Natives._SetItemPosition = Natives.Get("SetItemPosition").ToDelegate<SetItemPositionPrototype>();
            Natives._SetItemDropOnDeath = Natives.Get("SetItemDropOnDeath").ToDelegate<SetItemDropOnDeathPrototype>();
            Natives._SetItemDroppable = Natives.Get("SetItemDroppable").ToDelegate<SetItemDroppablePrototype>();
            Natives._SetItemPawnable = Natives.Get("SetItemPawnable").ToDelegate<SetItemPawnablePrototype>();
            Natives._SetItemPlayer = Natives.Get("SetItemPlayer").ToDelegate<SetItemPlayerPrototype>();
            Natives._SetItemInvulnerable = Natives.Get("SetItemInvulnerable").ToDelegate<SetItemInvulnerablePrototype>();
            Natives._IsItemInvulnerable = Natives.Get("IsItemInvulnerable").ToDelegate<IsItemInvulnerablePrototype>();
            Natives._SetItemVisible = Natives.Get("SetItemVisible").ToDelegate<SetItemVisiblePrototype>();
            Natives._IsItemVisible = Natives.Get("IsItemVisible").ToDelegate<IsItemVisiblePrototype>();
            Natives._IsItemOwned = Natives.Get("IsItemOwned").ToDelegate<IsItemOwnedPrototype>();
            Natives._IsItemPowerup = Natives.Get("IsItemPowerup").ToDelegate<IsItemPowerupPrototype>();
            Natives._IsItemSellable = Natives.Get("IsItemSellable").ToDelegate<IsItemSellablePrototype>();
            Natives._IsItemPawnable = Natives.Get("IsItemPawnable").ToDelegate<IsItemPawnablePrototype>();
            Natives._IsItemIdPowerup = Natives.Get("IsItemIdPowerup").ToDelegate<IsItemIdPowerupPrototype>();
            Natives._IsItemIdSellable = Natives.Get("IsItemIdSellable").ToDelegate<IsItemIdSellablePrototype>();
            Natives._IsItemIdPawnable = Natives.Get("IsItemIdPawnable").ToDelegate<IsItemIdPawnablePrototype>();
            Natives._EnumItemsInRect = Natives.Get("EnumItemsInRect").ToDelegate<EnumItemsInRectPrototype>();
            Natives._GetItemLevel = Natives.Get("GetItemLevel").ToDelegate<GetItemLevelPrototype>();
            Natives._GetItemType = Natives.Get("GetItemType").ToDelegate<GetItemTypePrototype>();
            Natives._SetItemDropID = Natives.Get("SetItemDropID").ToDelegate<SetItemDropIDPrototype>();
            Natives._GetItemName = Natives.Get("GetItemName").ToDelegate<GetItemNamePrototype>();
            Natives._GetItemCharges = Natives.Get("GetItemCharges").ToDelegate<GetItemChargesPrototype>();
            Natives._SetItemCharges = Natives.Get("SetItemCharges").ToDelegate<SetItemChargesPrototype>();
            Natives._GetItemUserData = Natives.Get("GetItemUserData").ToDelegate<GetItemUserDataPrototype>();
            Natives._SetItemUserData = Natives.Get("SetItemUserData").ToDelegate<SetItemUserDataPrototype>();
            Natives._CreateUnit = Natives.Get("CreateUnit").ToDelegate<CreateUnitPrototype>();
            Natives._CreateUnitByName = Natives.Get("CreateUnitByName").ToDelegate<CreateUnitByNamePrototype>();
            Natives._CreateUnitAtLoc = Natives.Get("CreateUnitAtLoc").ToDelegate<CreateUnitAtLocPrototype>();
            Natives._CreateUnitAtLocByName = Natives.Get("CreateUnitAtLocByName").ToDelegate<CreateUnitAtLocByNamePrototype>();
            Natives._CreateCorpse = Natives.Get("CreateCorpse").ToDelegate<CreateCorpsePrototype>();
            Natives._KillUnit = Natives.Get("KillUnit").ToDelegate<KillUnitPrototype>();
            Natives._RemoveUnit = Natives.Get("RemoveUnit").ToDelegate<RemoveUnitPrototype>();
            Natives._ShowUnit = Natives.Get("ShowUnit").ToDelegate<ShowUnitPrototype>();
            Natives._SetUnitState = Natives.Get("SetUnitState").ToDelegate<SetUnitStatePrototype>();
            Natives._SetUnitX = Natives.Get("SetUnitX").ToDelegate<SetUnitXPrototype>();
            Natives._SetUnitY = Natives.Get("SetUnitY").ToDelegate<SetUnitYPrototype>();
            Natives._SetUnitPosition = Natives.Get("SetUnitPosition").ToDelegate<SetUnitPositionPrototype>();
            Natives._SetUnitPositionLoc = Natives.Get("SetUnitPositionLoc").ToDelegate<SetUnitPositionLocPrototype>();
            Natives._SetUnitFacing = Natives.Get("SetUnitFacing").ToDelegate<SetUnitFacingPrototype>();
            Natives._SetUnitFacingTimed = Natives.Get("SetUnitFacingTimed").ToDelegate<SetUnitFacingTimedPrototype>();
            Natives._SetUnitMoveSpeed = Natives.Get("SetUnitMoveSpeed").ToDelegate<SetUnitMoveSpeedPrototype>();
            Natives._SetUnitFlyHeight = Natives.Get("SetUnitFlyHeight").ToDelegate<SetUnitFlyHeightPrototype>();
            Natives._SetUnitTurnSpeed = Natives.Get("SetUnitTurnSpeed").ToDelegate<SetUnitTurnSpeedPrototype>();
            Natives._SetUnitPropWindow = Natives.Get("SetUnitPropWindow").ToDelegate<SetUnitPropWindowPrototype>();
            Natives._SetUnitAcquireRange = Natives.Get("SetUnitAcquireRange").ToDelegate<SetUnitAcquireRangePrototype>();
            Natives._SetUnitCreepGuard = Natives.Get("SetUnitCreepGuard").ToDelegate<SetUnitCreepGuardPrototype>();
            Natives._GetUnitAcquireRange = Natives.Get("GetUnitAcquireRange").ToDelegate<GetUnitAcquireRangePrototype>();
            Natives._GetUnitTurnSpeed = Natives.Get("GetUnitTurnSpeed").ToDelegate<GetUnitTurnSpeedPrototype>();
            Natives._GetUnitPropWindow = Natives.Get("GetUnitPropWindow").ToDelegate<GetUnitPropWindowPrototype>();
            Natives._GetUnitFlyHeight = Natives.Get("GetUnitFlyHeight").ToDelegate<GetUnitFlyHeightPrototype>();
            Natives._GetUnitDefaultAcquireRange = Natives.Get("GetUnitDefaultAcquireRange").ToDelegate<GetUnitDefaultAcquireRangePrototype>();
            Natives._GetUnitDefaultTurnSpeed = Natives.Get("GetUnitDefaultTurnSpeed").ToDelegate<GetUnitDefaultTurnSpeedPrototype>();
            Natives._GetUnitDefaultPropWindow = Natives.Get("GetUnitDefaultPropWindow").ToDelegate<GetUnitDefaultPropWindowPrototype>();
            Natives._GetUnitDefaultFlyHeight = Natives.Get("GetUnitDefaultFlyHeight").ToDelegate<GetUnitDefaultFlyHeightPrototype>();
            Natives._SetUnitOwner = Natives.Get("SetUnitOwner").ToDelegate<SetUnitOwnerPrototype>();
            Natives._SetUnitColor = Natives.Get("SetUnitColor").ToDelegate<SetUnitColorPrototype>();
            Natives._SetUnitScale = Natives.Get("SetUnitScale").ToDelegate<SetUnitScalePrototype>();
            Natives._SetUnitTimeScale = Natives.Get("SetUnitTimeScale").ToDelegate<SetUnitTimeScalePrototype>();
            Natives._SetUnitBlendTime = Natives.Get("SetUnitBlendTime").ToDelegate<SetUnitBlendTimePrototype>();
            Natives._SetUnitVertexColor = Natives.Get("SetUnitVertexColor").ToDelegate<SetUnitVertexColorPrototype>();
            Natives._QueueUnitAnimation = Natives.Get("QueueUnitAnimation").ToDelegate<QueueUnitAnimationPrototype>();
            Natives._SetUnitAnimation = Natives.Get("SetUnitAnimation").ToDelegate<SetUnitAnimationPrototype>();
            Natives._SetUnitAnimationByIndex = Natives.Get("SetUnitAnimationByIndex").ToDelegate<SetUnitAnimationByIndexPrototype>();
            Natives._SetUnitAnimationWithRarity = Natives.Get("SetUnitAnimationWithRarity").ToDelegate<SetUnitAnimationWithRarityPrototype>();
            Natives._AddUnitAnimationProperties = Natives.Get("AddUnitAnimationProperties").ToDelegate<AddUnitAnimationPropertiesPrototype>();
            Natives._SetUnitLookAt = Natives.Get("SetUnitLookAt").ToDelegate<SetUnitLookAtPrototype>();
            Natives._ResetUnitLookAt = Natives.Get("ResetUnitLookAt").ToDelegate<ResetUnitLookAtPrototype>();
            Natives._SetUnitRescuable = Natives.Get("SetUnitRescuable").ToDelegate<SetUnitRescuablePrototype>();
            Natives._SetUnitRescueRange = Natives.Get("SetUnitRescueRange").ToDelegate<SetUnitRescueRangePrototype>();
            Natives._SetHeroStr = Natives.Get("SetHeroStr").ToDelegate<SetHeroStrPrototype>();
            Natives._SetHeroAgi = Natives.Get("SetHeroAgi").ToDelegate<SetHeroAgiPrototype>();
            Natives._SetHeroInt = Natives.Get("SetHeroInt").ToDelegate<SetHeroIntPrototype>();
            Natives._GetHeroStr = Natives.Get("GetHeroStr").ToDelegate<GetHeroStrPrototype>();
            Natives._GetHeroAgi = Natives.Get("GetHeroAgi").ToDelegate<GetHeroAgiPrototype>();
            Natives._GetHeroInt = Natives.Get("GetHeroInt").ToDelegate<GetHeroIntPrototype>();
            Natives._UnitStripHeroLevel = Natives.Get("UnitStripHeroLevel").ToDelegate<UnitStripHeroLevelPrototype>();
            Natives._GetHeroXP = Natives.Get("GetHeroXP").ToDelegate<GetHeroXPPrototype>();
            Natives._SetHeroXP = Natives.Get("SetHeroXP").ToDelegate<SetHeroXPPrototype>();
            Natives._GetHeroSkillPoints = Natives.Get("GetHeroSkillPoints").ToDelegate<GetHeroSkillPointsPrototype>();
            Natives._UnitModifySkillPoints = Natives.Get("UnitModifySkillPoints").ToDelegate<UnitModifySkillPointsPrototype>();
            Natives._AddHeroXP = Natives.Get("AddHeroXP").ToDelegate<AddHeroXPPrototype>();
            Natives._SetHeroLevel = Natives.Get("SetHeroLevel").ToDelegate<SetHeroLevelPrototype>();
            Natives._GetHeroLevel = Natives.Get("GetHeroLevel").ToDelegate<GetHeroLevelPrototype>();
            Natives._GetUnitLevel = Natives.Get("GetUnitLevel").ToDelegate<GetUnitLevelPrototype>();
            Natives._GetHeroProperName = Natives.Get("GetHeroProperName").ToDelegate<GetHeroProperNamePrototype>();
            Natives._SuspendHeroXP = Natives.Get("SuspendHeroXP").ToDelegate<SuspendHeroXPPrototype>();
            Natives._IsSuspendedXP = Natives.Get("IsSuspendedXP").ToDelegate<IsSuspendedXPPrototype>();
            Natives._SelectHeroSkill = Natives.Get("SelectHeroSkill").ToDelegate<SelectHeroSkillPrototype>();
            Natives._GetUnitAbilityLevel = Natives.Get("GetUnitAbilityLevel").ToDelegate<GetUnitAbilityLevelPrototype>();
            Natives._DecUnitAbilityLevel = Natives.Get("DecUnitAbilityLevel").ToDelegate<DecUnitAbilityLevelPrototype>();
            Natives._IncUnitAbilityLevel = Natives.Get("IncUnitAbilityLevel").ToDelegate<IncUnitAbilityLevelPrototype>();
            Natives._SetUnitAbilityLevel = Natives.Get("SetUnitAbilityLevel").ToDelegate<SetUnitAbilityLevelPrototype>();
            Natives._ReviveHero = Natives.Get("ReviveHero").ToDelegate<ReviveHeroPrototype>();
            Natives._ReviveHeroLoc = Natives.Get("ReviveHeroLoc").ToDelegate<ReviveHeroLocPrototype>();
            Natives._SetUnitExploded = Natives.Get("SetUnitExploded").ToDelegate<SetUnitExplodedPrototype>();
            Natives._SetUnitInvulnerable = Natives.Get("SetUnitInvulnerable").ToDelegate<SetUnitInvulnerablePrototype>();
            Natives._PauseUnit = Natives.Get("PauseUnit").ToDelegate<PauseUnitPrototype>();
            Natives._IsUnitPaused = Natives.Get("IsUnitPaused").ToDelegate<IsUnitPausedPrototype>();
            Natives._SetUnitPathing = Natives.Get("SetUnitPathing").ToDelegate<SetUnitPathingPrototype>();
            Natives._ClearSelection = Natives.Get("ClearSelection").ToDelegate<ClearSelectionPrototype>();
            Natives._SelectUnit = Natives.Get("SelectUnit").ToDelegate<SelectUnitPrototype>();
            Natives._GetUnitPointValue = Natives.Get("GetUnitPointValue").ToDelegate<GetUnitPointValuePrototype>();
            Natives._GetUnitPointValueByType = Natives.Get("GetUnitPointValueByType").ToDelegate<GetUnitPointValueByTypePrototype>();
            Natives._UnitAddItem = Natives.Get("UnitAddItem").ToDelegate<UnitAddItemPrototype>();
            Natives._UnitAddItemById = Natives.Get("UnitAddItemById").ToDelegate<UnitAddItemByIdPrototype>();
            Natives._UnitAddItemToSlotById = Natives.Get("UnitAddItemToSlotById").ToDelegate<UnitAddItemToSlotByIdPrototype>();
            Natives._UnitRemoveItem = Natives.Get("UnitRemoveItem").ToDelegate<UnitRemoveItemPrototype>();
            Natives._UnitRemoveItemFromSlot = Natives.Get("UnitRemoveItemFromSlot").ToDelegate<UnitRemoveItemFromSlotPrototype>();
            Natives._UnitHasItem = Natives.Get("UnitHasItem").ToDelegate<UnitHasItemPrototype>();
            Natives._UnitItemInSlot = Natives.Get("UnitItemInSlot").ToDelegate<UnitItemInSlotPrototype>();
            Natives._UnitInventorySize = Natives.Get("UnitInventorySize").ToDelegate<UnitInventorySizePrototype>();
            Natives._UnitDropItemPoint = Natives.Get("UnitDropItemPoint").ToDelegate<UnitDropItemPointPrototype>();
            Natives._UnitDropItemSlot = Natives.Get("UnitDropItemSlot").ToDelegate<UnitDropItemSlotPrototype>();
            Natives._UnitDropItemTarget = Natives.Get("UnitDropItemTarget").ToDelegate<UnitDropItemTargetPrototype>();
            Natives._UnitUseItem = Natives.Get("UnitUseItem").ToDelegate<UnitUseItemPrototype>();
            Natives._UnitUseItemPoint = Natives.Get("UnitUseItemPoint").ToDelegate<UnitUseItemPointPrototype>();
            Natives._UnitUseItemTarget = Natives.Get("UnitUseItemTarget").ToDelegate<UnitUseItemTargetPrototype>();
            Natives._GetUnitX = Natives.Get("GetUnitX").ToDelegate<GetUnitXPrototype>();
            Natives._GetUnitY = Natives.Get("GetUnitY").ToDelegate<GetUnitYPrototype>();
            Natives._GetUnitLoc = Natives.Get("GetUnitLoc").ToDelegate<GetUnitLocPrototype>();
            Natives._GetUnitFacing = Natives.Get("GetUnitFacing").ToDelegate<GetUnitFacingPrototype>();
            Natives._GetUnitMoveSpeed = Natives.Get("GetUnitMoveSpeed").ToDelegate<GetUnitMoveSpeedPrototype>();
            Natives._GetUnitDefaultMoveSpeed = Natives.Get("GetUnitDefaultMoveSpeed").ToDelegate<GetUnitDefaultMoveSpeedPrototype>();
            Natives._GetUnitState = Natives.Get("GetUnitState").ToDelegate<GetUnitStatePrototype>();
            Natives._GetOwningPlayer = Natives.Get("GetOwningPlayer").ToDelegate<GetOwningPlayerPrototype>();
            Natives._GetUnitTypeId = Natives.Get("GetUnitTypeId").ToDelegate<GetUnitTypeIdPrototype>();
            Natives._GetUnitRace = Natives.Get("GetUnitRace").ToDelegate<GetUnitRacePrototype>();
            Natives._GetUnitName = Natives.Get("GetUnitName").ToDelegate<GetUnitNamePrototype>();
            Natives._GetUnitFoodUsed = Natives.Get("GetUnitFoodUsed").ToDelegate<GetUnitFoodUsedPrototype>();
            Natives._GetUnitFoodMade = Natives.Get("GetUnitFoodMade").ToDelegate<GetUnitFoodMadePrototype>();
            Natives._GetFoodMade = Natives.Get("GetFoodMade").ToDelegate<GetFoodMadePrototype>();
            Natives._GetFoodUsed = Natives.Get("GetFoodUsed").ToDelegate<GetFoodUsedPrototype>();
            Natives._SetUnitUseFood = Natives.Get("SetUnitUseFood").ToDelegate<SetUnitUseFoodPrototype>();
            Natives._GetUnitRallyPoint = Natives.Get("GetUnitRallyPoint").ToDelegate<GetUnitRallyPointPrototype>();
            Natives._GetUnitRallyUnit = Natives.Get("GetUnitRallyUnit").ToDelegate<GetUnitRallyUnitPrototype>();
            Natives._GetUnitRallyDestructable = Natives.Get("GetUnitRallyDestructable").ToDelegate<GetUnitRallyDestructablePrototype>();
            Natives._IsUnitInGroup = Natives.Get("IsUnitInGroup").ToDelegate<IsUnitInGroupPrototype>();
            Natives._IsUnitInForce = Natives.Get("IsUnitInForce").ToDelegate<IsUnitInForcePrototype>();
            Natives._IsUnitOwnedByPlayer = Natives.Get("IsUnitOwnedByPlayer").ToDelegate<IsUnitOwnedByPlayerPrototype>();
            Natives._IsUnitAlly = Natives.Get("IsUnitAlly").ToDelegate<IsUnitAllyPrototype>();
            Natives._IsUnitEnemy = Natives.Get("IsUnitEnemy").ToDelegate<IsUnitEnemyPrototype>();
            Natives._IsUnitVisible = Natives.Get("IsUnitVisible").ToDelegate<IsUnitVisiblePrototype>();
            Natives._IsUnitDetected = Natives.Get("IsUnitDetected").ToDelegate<IsUnitDetectedPrototype>();
            Natives._IsUnitInvisible = Natives.Get("IsUnitInvisible").ToDelegate<IsUnitInvisiblePrototype>();
            Natives._IsUnitFogged = Natives.Get("IsUnitFogged").ToDelegate<IsUnitFoggedPrototype>();
            Natives._IsUnitMasked = Natives.Get("IsUnitMasked").ToDelegate<IsUnitMaskedPrototype>();
            Natives._IsUnitSelected = Natives.Get("IsUnitSelected").ToDelegate<IsUnitSelectedPrototype>();
            Natives._IsUnitRace = Natives.Get("IsUnitRace").ToDelegate<IsUnitRacePrototype>();
            Natives._IsUnitType = Natives.Get("IsUnitType").ToDelegate<IsUnitTypePrototype>();
            Natives._IsUnit = Natives.Get("IsUnit").ToDelegate<IsUnitPrototype>();
            Natives._IsUnitInRange = Natives.Get("IsUnitInRange").ToDelegate<IsUnitInRangePrototype>();
            Natives._IsUnitInRangeXY = Natives.Get("IsUnitInRangeXY").ToDelegate<IsUnitInRangeXYPrototype>();
            Natives._IsUnitInRangeLoc = Natives.Get("IsUnitInRangeLoc").ToDelegate<IsUnitInRangeLocPrototype>();
            Natives._IsUnitHidden = Natives.Get("IsUnitHidden").ToDelegate<IsUnitHiddenPrototype>();
            Natives._IsUnitIllusion = Natives.Get("IsUnitIllusion").ToDelegate<IsUnitIllusionPrototype>();
            Natives._IsUnitInTransport = Natives.Get("IsUnitInTransport").ToDelegate<IsUnitInTransportPrototype>();
            Natives._IsUnitLoaded = Natives.Get("IsUnitLoaded").ToDelegate<IsUnitLoadedPrototype>();
            Natives._IsHeroUnitId = Natives.Get("IsHeroUnitId").ToDelegate<IsHeroUnitIdPrototype>();
            Natives._IsUnitIdType = Natives.Get("IsUnitIdType").ToDelegate<IsUnitIdTypePrototype>();
            Natives._UnitShareVision = Natives.Get("UnitShareVision").ToDelegate<UnitShareVisionPrototype>();
            Natives._UnitSuspendDecay = Natives.Get("UnitSuspendDecay").ToDelegate<UnitSuspendDecayPrototype>();
            Natives._UnitAddType = Natives.Get("UnitAddType").ToDelegate<UnitAddTypePrototype>();
            Natives._UnitRemoveType = Natives.Get("UnitRemoveType").ToDelegate<UnitRemoveTypePrototype>();
            Natives._UnitAddAbility = Natives.Get("UnitAddAbility").ToDelegate<UnitAddAbilityPrototype>();
            Natives._UnitRemoveAbility = Natives.Get("UnitRemoveAbility").ToDelegate<UnitRemoveAbilityPrototype>();
            Natives._UnitMakeAbilityPermanent = Natives.Get("UnitMakeAbilityPermanent").ToDelegate<UnitMakeAbilityPermanentPrototype>();
            Natives._UnitRemoveBuffs = Natives.Get("UnitRemoveBuffs").ToDelegate<UnitRemoveBuffsPrototype>();
            Natives._UnitRemoveBuffsEx = Natives.Get("UnitRemoveBuffsEx").ToDelegate<UnitRemoveBuffsExPrototype>();
            Natives._UnitHasBuffsEx = Natives.Get("UnitHasBuffsEx").ToDelegate<UnitHasBuffsExPrototype>();
            Natives._UnitCountBuffsEx = Natives.Get("UnitCountBuffsEx").ToDelegate<UnitCountBuffsExPrototype>();
            Natives._UnitAddSleep = Natives.Get("UnitAddSleep").ToDelegate<UnitAddSleepPrototype>();
            Natives._UnitCanSleep = Natives.Get("UnitCanSleep").ToDelegate<UnitCanSleepPrototype>();
            Natives._UnitAddSleepPerm = Natives.Get("UnitAddSleepPerm").ToDelegate<UnitAddSleepPermPrototype>();
            Natives._UnitCanSleepPerm = Natives.Get("UnitCanSleepPerm").ToDelegate<UnitCanSleepPermPrototype>();
            Natives._UnitIsSleeping = Natives.Get("UnitIsSleeping").ToDelegate<UnitIsSleepingPrototype>();
            Natives._UnitWakeUp = Natives.Get("UnitWakeUp").ToDelegate<UnitWakeUpPrototype>();
            Natives._UnitApplyTimedLife = Natives.Get("UnitApplyTimedLife").ToDelegate<UnitApplyTimedLifePrototype>();
            Natives._UnitIgnoreAlarm = Natives.Get("UnitIgnoreAlarm").ToDelegate<UnitIgnoreAlarmPrototype>();
            Natives._UnitIgnoreAlarmToggled = Natives.Get("UnitIgnoreAlarmToggled").ToDelegate<UnitIgnoreAlarmToggledPrototype>();
            Natives._UnitResetCooldown = Natives.Get("UnitResetCooldown").ToDelegate<UnitResetCooldownPrototype>();
            Natives._UnitSetConstructionProgress = Natives.Get("UnitSetConstructionProgress").ToDelegate<UnitSetConstructionProgressPrototype>();
            Natives._UnitSetUpgradeProgress = Natives.Get("UnitSetUpgradeProgress").ToDelegate<UnitSetUpgradeProgressPrototype>();
            Natives._UnitPauseTimedLife = Natives.Get("UnitPauseTimedLife").ToDelegate<UnitPauseTimedLifePrototype>();
            Natives._UnitSetUsesAltIcon = Natives.Get("UnitSetUsesAltIcon").ToDelegate<UnitSetUsesAltIconPrototype>();
            Natives._UnitDamagePoint = Natives.Get("UnitDamagePoint").ToDelegate<UnitDamagePointPrototype>();
            Natives._UnitDamageTarget = Natives.Get("UnitDamageTarget").ToDelegate<UnitDamageTargetPrototype>();
            Natives._IssueImmediateOrder = Natives.Get("IssueImmediateOrder").ToDelegate<IssueImmediateOrderPrototype>();
            Natives._IssueImmediateOrderById = Natives.Get("IssueImmediateOrderById").ToDelegate<IssueImmediateOrderByIdPrototype>();
            Natives._IssuePointOrder = Natives.Get("IssuePointOrder").ToDelegate<IssuePointOrderPrototype>();
            Natives._IssuePointOrderLoc = Natives.Get("IssuePointOrderLoc").ToDelegate<IssuePointOrderLocPrototype>();
            Natives._IssuePointOrderById = Natives.Get("IssuePointOrderById").ToDelegate<IssuePointOrderByIdPrototype>();
            Natives._IssuePointOrderByIdLoc = Natives.Get("IssuePointOrderByIdLoc").ToDelegate<IssuePointOrderByIdLocPrototype>();
            Natives._IssueTargetOrder = Natives.Get("IssueTargetOrder").ToDelegate<IssueTargetOrderPrototype>();
            Natives._IssueTargetOrderById = Natives.Get("IssueTargetOrderById").ToDelegate<IssueTargetOrderByIdPrototype>();
            Natives._IssueInstantPointOrder = Natives.Get("IssueInstantPointOrder").ToDelegate<IssueInstantPointOrderPrototype>();
            Natives._IssueInstantPointOrderById = Natives.Get("IssueInstantPointOrderById").ToDelegate<IssueInstantPointOrderByIdPrototype>();
            Natives._IssueInstantTargetOrder = Natives.Get("IssueInstantTargetOrder").ToDelegate<IssueInstantTargetOrderPrototype>();
            Natives._IssueInstantTargetOrderById = Natives.Get("IssueInstantTargetOrderById").ToDelegate<IssueInstantTargetOrderByIdPrototype>();
            Natives._IssueBuildOrder = Natives.Get("IssueBuildOrder").ToDelegate<IssueBuildOrderPrototype>();
            Natives._IssueBuildOrderById = Natives.Get("IssueBuildOrderById").ToDelegate<IssueBuildOrderByIdPrototype>();
            Natives._IssueNeutralImmediateOrder = Natives.Get("IssueNeutralImmediateOrder").ToDelegate<IssueNeutralImmediateOrderPrototype>();
            Natives._IssueNeutralImmediateOrderById = Natives.Get("IssueNeutralImmediateOrderById").ToDelegate<IssueNeutralImmediateOrderByIdPrototype>();
            Natives._IssueNeutralPointOrder = Natives.Get("IssueNeutralPointOrder").ToDelegate<IssueNeutralPointOrderPrototype>();
            Natives._IssueNeutralPointOrderById = Natives.Get("IssueNeutralPointOrderById").ToDelegate<IssueNeutralPointOrderByIdPrototype>();
            Natives._IssueNeutralTargetOrder = Natives.Get("IssueNeutralTargetOrder").ToDelegate<IssueNeutralTargetOrderPrototype>();
            Natives._IssueNeutralTargetOrderById = Natives.Get("IssueNeutralTargetOrderById").ToDelegate<IssueNeutralTargetOrderByIdPrototype>();
            Natives._GetUnitCurrentOrder = Natives.Get("GetUnitCurrentOrder").ToDelegate<GetUnitCurrentOrderPrototype>();
            Natives._SetResourceAmount = Natives.Get("SetResourceAmount").ToDelegate<SetResourceAmountPrototype>();
            Natives._AddResourceAmount = Natives.Get("AddResourceAmount").ToDelegate<AddResourceAmountPrototype>();
            Natives._GetResourceAmount = Natives.Get("GetResourceAmount").ToDelegate<GetResourceAmountPrototype>();
            Natives._WaygateGetDestinationX = Natives.Get("WaygateGetDestinationX").ToDelegate<WaygateGetDestinationXPrototype>();
            Natives._WaygateGetDestinationY = Natives.Get("WaygateGetDestinationY").ToDelegate<WaygateGetDestinationYPrototype>();
            Natives._WaygateSetDestination = Natives.Get("WaygateSetDestination").ToDelegate<WaygateSetDestinationPrototype>();
            Natives._WaygateActivate = Natives.Get("WaygateActivate").ToDelegate<WaygateActivatePrototype>();
            Natives._WaygateIsActive = Natives.Get("WaygateIsActive").ToDelegate<WaygateIsActivePrototype>();
            Natives._AddItemToAllStock = Natives.Get("AddItemToAllStock").ToDelegate<AddItemToAllStockPrototype>();
            Natives._AddItemToStock = Natives.Get("AddItemToStock").ToDelegate<AddItemToStockPrototype>();
            Natives._AddUnitToAllStock = Natives.Get("AddUnitToAllStock").ToDelegate<AddUnitToAllStockPrototype>();
            Natives._AddUnitToStock = Natives.Get("AddUnitToStock").ToDelegate<AddUnitToStockPrototype>();
            Natives._RemoveItemFromAllStock = Natives.Get("RemoveItemFromAllStock").ToDelegate<RemoveItemFromAllStockPrototype>();
            Natives._RemoveItemFromStock = Natives.Get("RemoveItemFromStock").ToDelegate<RemoveItemFromStockPrototype>();
            Natives._RemoveUnitFromAllStock = Natives.Get("RemoveUnitFromAllStock").ToDelegate<RemoveUnitFromAllStockPrototype>();
            Natives._RemoveUnitFromStock = Natives.Get("RemoveUnitFromStock").ToDelegate<RemoveUnitFromStockPrototype>();
            Natives._SetAllItemTypeSlots = Natives.Get("SetAllItemTypeSlots").ToDelegate<SetAllItemTypeSlotsPrototype>();
            Natives._SetAllUnitTypeSlots = Natives.Get("SetAllUnitTypeSlots").ToDelegate<SetAllUnitTypeSlotsPrototype>();
            Natives._SetItemTypeSlots = Natives.Get("SetItemTypeSlots").ToDelegate<SetItemTypeSlotsPrototype>();
            Natives._SetUnitTypeSlots = Natives.Get("SetUnitTypeSlots").ToDelegate<SetUnitTypeSlotsPrototype>();
            Natives._GetUnitUserData = Natives.Get("GetUnitUserData").ToDelegate<GetUnitUserDataPrototype>();
            Natives._SetUnitUserData = Natives.Get("SetUnitUserData").ToDelegate<SetUnitUserDataPrototype>();
            Natives._Player = Natives.Get("Player").ToDelegate<PlayerPrototype>();
            Natives._GetLocalPlayer = Natives.Get("GetLocalPlayer").ToDelegate<GetLocalPlayerPrototype>();
            Natives._IsPlayerAlly = Natives.Get("IsPlayerAlly").ToDelegate<IsPlayerAllyPrototype>();
            Natives._IsPlayerEnemy = Natives.Get("IsPlayerEnemy").ToDelegate<IsPlayerEnemyPrototype>();
            Natives._IsPlayerInForce = Natives.Get("IsPlayerInForce").ToDelegate<IsPlayerInForcePrototype>();
            Natives._IsPlayerObserver = Natives.Get("IsPlayerObserver").ToDelegate<IsPlayerObserverPrototype>();
            Natives._IsVisibleToPlayer = Natives.Get("IsVisibleToPlayer").ToDelegate<IsVisibleToPlayerPrototype>();
            Natives._IsLocationVisibleToPlayer = Natives.Get("IsLocationVisibleToPlayer").ToDelegate<IsLocationVisibleToPlayerPrototype>();
            Natives._IsFoggedToPlayer = Natives.Get("IsFoggedToPlayer").ToDelegate<IsFoggedToPlayerPrototype>();
            Natives._IsLocationFoggedToPlayer = Natives.Get("IsLocationFoggedToPlayer").ToDelegate<IsLocationFoggedToPlayerPrototype>();
            Natives._IsMaskedToPlayer = Natives.Get("IsMaskedToPlayer").ToDelegate<IsMaskedToPlayerPrototype>();
            Natives._IsLocationMaskedToPlayer = Natives.Get("IsLocationMaskedToPlayer").ToDelegate<IsLocationMaskedToPlayerPrototype>();
            Natives._GetPlayerRace = Natives.Get("GetPlayerRace").ToDelegate<GetPlayerRacePrototype>();
            Natives._GetPlayerId = Natives.Get("GetPlayerId").ToDelegate<GetPlayerIdPrototype>();
            Natives._GetPlayerUnitCount = Natives.Get("GetPlayerUnitCount").ToDelegate<GetPlayerUnitCountPrototype>();
            Natives._GetPlayerTypedUnitCount = Natives.Get("GetPlayerTypedUnitCount").ToDelegate<GetPlayerTypedUnitCountPrototype>();
            Natives._GetPlayerStructureCount = Natives.Get("GetPlayerStructureCount").ToDelegate<GetPlayerStructureCountPrototype>();
            Natives._GetPlayerState = Natives.Get("GetPlayerState").ToDelegate<GetPlayerStatePrototype>();
            Natives._GetPlayerScore = Natives.Get("GetPlayerScore").ToDelegate<GetPlayerScorePrototype>();
            Natives._GetPlayerAlliance = Natives.Get("GetPlayerAlliance").ToDelegate<GetPlayerAlliancePrototype>();
            Natives._GetPlayerHandicap = Natives.Get("GetPlayerHandicap").ToDelegate<GetPlayerHandicapPrototype>();
            Natives._GetPlayerHandicapXP = Natives.Get("GetPlayerHandicapXP").ToDelegate<GetPlayerHandicapXPPrototype>();
            Natives._SetPlayerHandicap = Natives.Get("SetPlayerHandicap").ToDelegate<SetPlayerHandicapPrototype>();
            Natives._SetPlayerHandicapXP = Natives.Get("SetPlayerHandicapXP").ToDelegate<SetPlayerHandicapXPPrototype>();
            Natives._SetPlayerTechMaxAllowed = Natives.Get("SetPlayerTechMaxAllowed").ToDelegate<SetPlayerTechMaxAllowedPrototype>();
            Natives._GetPlayerTechMaxAllowed = Natives.Get("GetPlayerTechMaxAllowed").ToDelegate<GetPlayerTechMaxAllowedPrototype>();
            Natives._AddPlayerTechResearched = Natives.Get("AddPlayerTechResearched").ToDelegate<AddPlayerTechResearchedPrototype>();
            Natives._SetPlayerTechResearched = Natives.Get("SetPlayerTechResearched").ToDelegate<SetPlayerTechResearchedPrototype>();
            Natives._GetPlayerTechResearched = Natives.Get("GetPlayerTechResearched").ToDelegate<GetPlayerTechResearchedPrototype>();
            Natives._GetPlayerTechCount = Natives.Get("GetPlayerTechCount").ToDelegate<GetPlayerTechCountPrototype>();
            Natives._SetPlayerUnitsOwner = Natives.Get("SetPlayerUnitsOwner").ToDelegate<SetPlayerUnitsOwnerPrototype>();
            Natives._CripplePlayer = Natives.Get("CripplePlayer").ToDelegate<CripplePlayerPrototype>();
            Natives._SetPlayerAbilityAvailable = Natives.Get("SetPlayerAbilityAvailable").ToDelegate<SetPlayerAbilityAvailablePrototype>();
            Natives._SetPlayerState = Natives.Get("SetPlayerState").ToDelegate<SetPlayerStatePrototype>();
            Natives._RemovePlayer = Natives.Get("RemovePlayer").ToDelegate<RemovePlayerPrototype>();
            Natives._CachePlayerHeroData = Natives.Get("CachePlayerHeroData").ToDelegate<CachePlayerHeroDataPrototype>();
            Natives._SetFogStateRect = Natives.Get("SetFogStateRect").ToDelegate<SetFogStateRectPrototype>();
            Natives._SetFogStateRadius = Natives.Get("SetFogStateRadius").ToDelegate<SetFogStateRadiusPrototype>();
            Natives._SetFogStateRadiusLoc = Natives.Get("SetFogStateRadiusLoc").ToDelegate<SetFogStateRadiusLocPrototype>();
            Natives._FogMaskEnable = Natives.Get("FogMaskEnable").ToDelegate<FogMaskEnablePrototype>();
            Natives._IsFogMaskEnabled = Natives.Get("IsFogMaskEnabled").ToDelegate<IsFogMaskEnabledPrototype>();
            Natives._FogEnable = Natives.Get("FogEnable").ToDelegate<FogEnablePrototype>();
            Natives._IsFogEnabled = Natives.Get("IsFogEnabled").ToDelegate<IsFogEnabledPrototype>();
            Natives._CreateFogModifierRect = Natives.Get("CreateFogModifierRect").ToDelegate<CreateFogModifierRectPrototype>();
            Natives._CreateFogModifierRadius = Natives.Get("CreateFogModifierRadius").ToDelegate<CreateFogModifierRadiusPrototype>();
            Natives._CreateFogModifierRadiusLoc = Natives.Get("CreateFogModifierRadiusLoc").ToDelegate<CreateFogModifierRadiusLocPrototype>();
            Natives._DestroyFogModifier = Natives.Get("DestroyFogModifier").ToDelegate<DestroyFogModifierPrototype>();
            Natives._FogModifierStart = Natives.Get("FogModifierStart").ToDelegate<FogModifierStartPrototype>();
            Natives._FogModifierStop = Natives.Get("FogModifierStop").ToDelegate<FogModifierStopPrototype>();
            Natives._VersionGet = Natives.Get("VersionGet").ToDelegate<VersionGetPrototype>();
            Natives._VersionCompatible = Natives.Get("VersionCompatible").ToDelegate<VersionCompatiblePrototype>();
            Natives._VersionSupported = Natives.Get("VersionSupported").ToDelegate<VersionSupportedPrototype>();
            Natives._EndGame = Natives.Get("EndGame").ToDelegate<EndGamePrototype>();
            Natives._ChangeLevel = Natives.Get("ChangeLevel").ToDelegate<ChangeLevelPrototype>();
            Natives._RestartGame = Natives.Get("RestartGame").ToDelegate<RestartGamePrototype>();
            Natives._ReloadGame = Natives.Get("ReloadGame").ToDelegate<ReloadGamePrototype>();
            Natives._SetCampaignMenuRace = Natives.Get("SetCampaignMenuRace").ToDelegate<SetCampaignMenuRacePrototype>();
            Natives._SetCampaignMenuRaceEx = Natives.Get("SetCampaignMenuRaceEx").ToDelegate<SetCampaignMenuRaceExPrototype>();
            Natives._ForceCampaignSelectScreen = Natives.Get("ForceCampaignSelectScreen").ToDelegate<ForceCampaignSelectScreenPrototype>();
            Natives._LoadGame = Natives.Get("LoadGame").ToDelegate<LoadGamePrototype>();
            Natives._SaveGame = Natives.Get("SaveGame").ToDelegate<SaveGamePrototype>();
            Natives._RenameSaveDirectory = Natives.Get("RenameSaveDirectory").ToDelegate<RenameSaveDirectoryPrototype>();
            Natives._RemoveSaveDirectory = Natives.Get("RemoveSaveDirectory").ToDelegate<RemoveSaveDirectoryPrototype>();
            Natives._CopySaveGame = Natives.Get("CopySaveGame").ToDelegate<CopySaveGamePrototype>();
            Natives._SaveGameExists = Natives.Get("SaveGameExists").ToDelegate<SaveGameExistsPrototype>();
            Natives._SyncSelections = Natives.Get("SyncSelections").ToDelegate<SyncSelectionsPrototype>();
            Natives._SetFloatGameState = Natives.Get("SetFloatGameState").ToDelegate<SetFloatGameStatePrototype>();
            Natives._GetFloatGameState = Natives.Get("GetFloatGameState").ToDelegate<GetFloatGameStatePrototype>();
            Natives._SetIntegerGameState = Natives.Get("SetIntegerGameState").ToDelegate<SetIntegerGameStatePrototype>();
            Natives._GetIntegerGameState = Natives.Get("GetIntegerGameState").ToDelegate<GetIntegerGameStatePrototype>();
            Natives._SetTutorialCleared = Natives.Get("SetTutorialCleared").ToDelegate<SetTutorialClearedPrototype>();
            Natives._SetMissionAvailable = Natives.Get("SetMissionAvailable").ToDelegate<SetMissionAvailablePrototype>();
            Natives._SetCampaignAvailable = Natives.Get("SetCampaignAvailable").ToDelegate<SetCampaignAvailablePrototype>();
            Natives._SetOpCinematicAvailable = Natives.Get("SetOpCinematicAvailable").ToDelegate<SetOpCinematicAvailablePrototype>();
            Natives._SetEdCinematicAvailable = Natives.Get("SetEdCinematicAvailable").ToDelegate<SetEdCinematicAvailablePrototype>();
            Natives._GetDefaultDifficulty = Natives.Get("GetDefaultDifficulty").ToDelegate<GetDefaultDifficultyPrototype>();
            Natives._SetDefaultDifficulty = Natives.Get("SetDefaultDifficulty").ToDelegate<SetDefaultDifficultyPrototype>();
            Natives._SetCustomCampaignButtonVisible = Natives.Get("SetCustomCampaignButtonVisible").ToDelegate<SetCustomCampaignButtonVisiblePrototype>();
            Natives._GetCustomCampaignButtonVisible = Natives.Get("GetCustomCampaignButtonVisible").ToDelegate<GetCustomCampaignButtonVisiblePrototype>();
            Natives._DoNotSaveReplay = Natives.Get("DoNotSaveReplay").ToDelegate<DoNotSaveReplayPrototype>();
            Natives._DialogCreate = Natives.Get("DialogCreate").ToDelegate<DialogCreatePrototype>();
            Natives._DialogDestroy = Natives.Get("DialogDestroy").ToDelegate<DialogDestroyPrototype>();
            Natives._DialogClear = Natives.Get("DialogClear").ToDelegate<DialogClearPrototype>();
            Natives._DialogSetMessage = Natives.Get("DialogSetMessage").ToDelegate<DialogSetMessagePrototype>();
            Natives._DialogAddButton = Natives.Get("DialogAddButton").ToDelegate<DialogAddButtonPrototype>();
            Natives._DialogAddQuitButton = Natives.Get("DialogAddQuitButton").ToDelegate<DialogAddQuitButtonPrototype>();
            Natives._DialogDisplay = Natives.Get("DialogDisplay").ToDelegate<DialogDisplayPrototype>();
            Natives._ReloadGameCachesFromDisk = Natives.Get("ReloadGameCachesFromDisk").ToDelegate<ReloadGameCachesFromDiskPrototype>();
            Natives._InitGameCache = Natives.Get("InitGameCache").ToDelegate<InitGameCachePrototype>();
            Natives._SaveGameCache = Natives.Get("SaveGameCache").ToDelegate<SaveGameCachePrototype>();
            Natives._StoreInteger = Natives.Get("StoreInteger").ToDelegate<StoreIntegerPrototype>();
            Natives._StoreReal = Natives.Get("StoreReal").ToDelegate<StoreRealPrototype>();
            Natives._StoreBoolean = Natives.Get("StoreBoolean").ToDelegate<StoreBooleanPrototype>();
            Natives._StoreUnit = Natives.Get("StoreUnit").ToDelegate<StoreUnitPrototype>();
            Natives._StoreString = Natives.Get("StoreString").ToDelegate<StoreStringPrototype>();
            Natives._SyncStoredInteger = Natives.Get("SyncStoredInteger").ToDelegate<SyncStoredIntegerPrototype>();
            Natives._SyncStoredReal = Natives.Get("SyncStoredReal").ToDelegate<SyncStoredRealPrototype>();
            Natives._SyncStoredBoolean = Natives.Get("SyncStoredBoolean").ToDelegate<SyncStoredBooleanPrototype>();
            Natives._SyncStoredUnit = Natives.Get("SyncStoredUnit").ToDelegate<SyncStoredUnitPrototype>();
            Natives._SyncStoredString = Natives.Get("SyncStoredString").ToDelegate<SyncStoredStringPrototype>();
            Natives._HaveStoredInteger = Natives.Get("HaveStoredInteger").ToDelegate<HaveStoredIntegerPrototype>();
            Natives._HaveStoredReal = Natives.Get("HaveStoredReal").ToDelegate<HaveStoredRealPrototype>();
            Natives._HaveStoredBoolean = Natives.Get("HaveStoredBoolean").ToDelegate<HaveStoredBooleanPrototype>();
            Natives._HaveStoredUnit = Natives.Get("HaveStoredUnit").ToDelegate<HaveStoredUnitPrototype>();
            Natives._HaveStoredString = Natives.Get("HaveStoredString").ToDelegate<HaveStoredStringPrototype>();
            Natives._FlushGameCache = Natives.Get("FlushGameCache").ToDelegate<FlushGameCachePrototype>();
            Natives._FlushStoredMission = Natives.Get("FlushStoredMission").ToDelegate<FlushStoredMissionPrototype>();
            Natives._FlushStoredInteger = Natives.Get("FlushStoredInteger").ToDelegate<FlushStoredIntegerPrototype>();
            Natives._FlushStoredReal = Natives.Get("FlushStoredReal").ToDelegate<FlushStoredRealPrototype>();
            Natives._FlushStoredBoolean = Natives.Get("FlushStoredBoolean").ToDelegate<FlushStoredBooleanPrototype>();
            Natives._FlushStoredUnit = Natives.Get("FlushStoredUnit").ToDelegate<FlushStoredUnitPrototype>();
            Natives._FlushStoredString = Natives.Get("FlushStoredString").ToDelegate<FlushStoredStringPrototype>();
            Natives._GetStoredInteger = Natives.Get("GetStoredInteger").ToDelegate<GetStoredIntegerPrototype>();
            Natives._GetStoredReal = Natives.Get("GetStoredReal").ToDelegate<GetStoredRealPrototype>();
            Natives._GetStoredBoolean = Natives.Get("GetStoredBoolean").ToDelegate<GetStoredBooleanPrototype>();
            Natives._GetStoredString = Natives.Get("GetStoredString").ToDelegate<GetStoredStringPrototype>();
            Natives._RestoreUnit = Natives.Get("RestoreUnit").ToDelegate<RestoreUnitPrototype>();
            Natives._InitHashtable = Natives.Get("InitHashtable").ToDelegate<InitHashtablePrototype>();
            Natives._SaveInteger = Natives.Get("SaveInteger").ToDelegate<SaveIntegerPrototype>();
            Natives._SaveReal = Natives.Get("SaveReal").ToDelegate<SaveRealPrototype>();
            Natives._SaveBoolean = Natives.Get("SaveBoolean").ToDelegate<SaveBooleanPrototype>();
            Natives._SaveStr = Natives.Get("SaveStr").ToDelegate<SaveStrPrototype>();
            Natives._SavePlayerHandle = Natives.Get("SavePlayerHandle").ToDelegate<SavePlayerHandlePrototype>();
            Natives._SaveWidgetHandle = Natives.Get("SaveWidgetHandle").ToDelegate<SaveWidgetHandlePrototype>();
            Natives._SaveDestructableHandle = Natives.Get("SaveDestructableHandle").ToDelegate<SaveDestructableHandlePrototype>();
            Natives._SaveItemHandle = Natives.Get("SaveItemHandle").ToDelegate<SaveItemHandlePrototype>();
            Natives._SaveUnitHandle = Natives.Get("SaveUnitHandle").ToDelegate<SaveUnitHandlePrototype>();
            Natives._SaveAbilityHandle = Natives.Get("SaveAbilityHandle").ToDelegate<SaveAbilityHandlePrototype>();
            Natives._SaveTimerHandle = Natives.Get("SaveTimerHandle").ToDelegate<SaveTimerHandlePrototype>();
            Natives._SaveTriggerHandle = Natives.Get("SaveTriggerHandle").ToDelegate<SaveTriggerHandlePrototype>();
            Natives._SaveTriggerConditionHandle = Natives.Get("SaveTriggerConditionHandle").ToDelegate<SaveTriggerConditionHandlePrototype>();
            Natives._SaveTriggerActionHandle = Natives.Get("SaveTriggerActionHandle").ToDelegate<SaveTriggerActionHandlePrototype>();
            Natives._SaveTriggerEventHandle = Natives.Get("SaveTriggerEventHandle").ToDelegate<SaveTriggerEventHandlePrototype>();
            Natives._SaveForceHandle = Natives.Get("SaveForceHandle").ToDelegate<SaveForceHandlePrototype>();
            Natives._SaveGroupHandle = Natives.Get("SaveGroupHandle").ToDelegate<SaveGroupHandlePrototype>();
            Natives._SaveLocationHandle = Natives.Get("SaveLocationHandle").ToDelegate<SaveLocationHandlePrototype>();
            Natives._SaveRectHandle = Natives.Get("SaveRectHandle").ToDelegate<SaveRectHandlePrototype>();
            Natives._SaveBooleanExprHandle = Natives.Get("SaveBooleanExprHandle").ToDelegate<SaveBooleanExprHandlePrototype>();
            Natives._SaveSoundHandle = Natives.Get("SaveSoundHandle").ToDelegate<SaveSoundHandlePrototype>();
            Natives._SaveEffectHandle = Natives.Get("SaveEffectHandle").ToDelegate<SaveEffectHandlePrototype>();
            Natives._SaveUnitPoolHandle = Natives.Get("SaveUnitPoolHandle").ToDelegate<SaveUnitPoolHandlePrototype>();
            Natives._SaveItemPoolHandle = Natives.Get("SaveItemPoolHandle").ToDelegate<SaveItemPoolHandlePrototype>();
            Natives._SaveQuestHandle = Natives.Get("SaveQuestHandle").ToDelegate<SaveQuestHandlePrototype>();
            Natives._SaveQuestItemHandle = Natives.Get("SaveQuestItemHandle").ToDelegate<SaveQuestItemHandlePrototype>();
            Natives._SaveDefeatConditionHandle = Natives.Get("SaveDefeatConditionHandle").ToDelegate<SaveDefeatConditionHandlePrototype>();
            Natives._SaveTimerDialogHandle = Natives.Get("SaveTimerDialogHandle").ToDelegate<SaveTimerDialogHandlePrototype>();
            Natives._SaveLeaderboardHandle = Natives.Get("SaveLeaderboardHandle").ToDelegate<SaveLeaderboardHandlePrototype>();
            Natives._SaveMultiboardHandle = Natives.Get("SaveMultiboardHandle").ToDelegate<SaveMultiboardHandlePrototype>();
            Natives._SaveMultiboardItemHandle = Natives.Get("SaveMultiboardItemHandle").ToDelegate<SaveMultiboardItemHandlePrototype>();
            Natives._SaveTrackableHandle = Natives.Get("SaveTrackableHandle").ToDelegate<SaveTrackableHandlePrototype>();
            Natives._SaveDialogHandle = Natives.Get("SaveDialogHandle").ToDelegate<SaveDialogHandlePrototype>();
            Natives._SaveButtonHandle = Natives.Get("SaveButtonHandle").ToDelegate<SaveButtonHandlePrototype>();
            Natives._SaveTextTagHandle = Natives.Get("SaveTextTagHandle").ToDelegate<SaveTextTagHandlePrototype>();
            Natives._SaveLightningHandle = Natives.Get("SaveLightningHandle").ToDelegate<SaveLightningHandlePrototype>();
            Natives._SaveImageHandle = Natives.Get("SaveImageHandle").ToDelegate<SaveImageHandlePrototype>();
            Natives._SaveUbersplatHandle = Natives.Get("SaveUbersplatHandle").ToDelegate<SaveUbersplatHandlePrototype>();
            Natives._SaveRegionHandle = Natives.Get("SaveRegionHandle").ToDelegate<SaveRegionHandlePrototype>();
            Natives._SaveFogStateHandle = Natives.Get("SaveFogStateHandle").ToDelegate<SaveFogStateHandlePrototype>();
            Natives._SaveFogModifierHandle = Natives.Get("SaveFogModifierHandle").ToDelegate<SaveFogModifierHandlePrototype>();
            Natives._SaveAgentHandle = Natives.Get("SaveAgentHandle").ToDelegate<SaveAgentHandlePrototype>();
            Natives._SaveHashtableHandle = Natives.Get("SaveHashtableHandle").ToDelegate<SaveHashtableHandlePrototype>();
            Natives._LoadInteger = Natives.Get("LoadInteger").ToDelegate<LoadIntegerPrototype>();
            Natives._LoadReal = Natives.Get("LoadReal").ToDelegate<LoadRealPrototype>();
            Natives._LoadBoolean = Natives.Get("LoadBoolean").ToDelegate<LoadBooleanPrototype>();
            Natives._LoadStr = Natives.Get("LoadStr").ToDelegate<LoadStrPrototype>();
            Natives._LoadPlayerHandle = Natives.Get("LoadPlayerHandle").ToDelegate<LoadPlayerHandlePrototype>();
            Natives._LoadWidgetHandle = Natives.Get("LoadWidgetHandle").ToDelegate<LoadWidgetHandlePrototype>();
            Natives._LoadDestructableHandle = Natives.Get("LoadDestructableHandle").ToDelegate<LoadDestructableHandlePrototype>();
            Natives._LoadItemHandle = Natives.Get("LoadItemHandle").ToDelegate<LoadItemHandlePrototype>();
            Natives._LoadUnitHandle = Natives.Get("LoadUnitHandle").ToDelegate<LoadUnitHandlePrototype>();
            Natives._LoadAbilityHandle = Natives.Get("LoadAbilityHandle").ToDelegate<LoadAbilityHandlePrototype>();
            Natives._LoadTimerHandle = Natives.Get("LoadTimerHandle").ToDelegate<LoadTimerHandlePrototype>();
            Natives._LoadTriggerHandle = Natives.Get("LoadTriggerHandle").ToDelegate<LoadTriggerHandlePrototype>();
            Natives._LoadTriggerConditionHandle = Natives.Get("LoadTriggerConditionHandle").ToDelegate<LoadTriggerConditionHandlePrototype>();
            Natives._LoadTriggerActionHandle = Natives.Get("LoadTriggerActionHandle").ToDelegate<LoadTriggerActionHandlePrototype>();
            Natives._LoadTriggerEventHandle = Natives.Get("LoadTriggerEventHandle").ToDelegate<LoadTriggerEventHandlePrototype>();
            Natives._LoadForceHandle = Natives.Get("LoadForceHandle").ToDelegate<LoadForceHandlePrototype>();
            Natives._LoadGroupHandle = Natives.Get("LoadGroupHandle").ToDelegate<LoadGroupHandlePrototype>();
            Natives._LoadLocationHandle = Natives.Get("LoadLocationHandle").ToDelegate<LoadLocationHandlePrototype>();
            Natives._LoadRectHandle = Natives.Get("LoadRectHandle").ToDelegate<LoadRectHandlePrototype>();
            Natives._LoadBooleanExprHandle = Natives.Get("LoadBooleanExprHandle").ToDelegate<LoadBooleanExprHandlePrototype>();
            Natives._LoadSoundHandle = Natives.Get("LoadSoundHandle").ToDelegate<LoadSoundHandlePrototype>();
            Natives._LoadEffectHandle = Natives.Get("LoadEffectHandle").ToDelegate<LoadEffectHandlePrototype>();
            Natives._LoadUnitPoolHandle = Natives.Get("LoadUnitPoolHandle").ToDelegate<LoadUnitPoolHandlePrototype>();
            Natives._LoadItemPoolHandle = Natives.Get("LoadItemPoolHandle").ToDelegate<LoadItemPoolHandlePrototype>();
            Natives._LoadQuestHandle = Natives.Get("LoadQuestHandle").ToDelegate<LoadQuestHandlePrototype>();
            Natives._LoadQuestItemHandle = Natives.Get("LoadQuestItemHandle").ToDelegate<LoadQuestItemHandlePrototype>();
            Natives._LoadDefeatConditionHandle = Natives.Get("LoadDefeatConditionHandle").ToDelegate<LoadDefeatConditionHandlePrototype>();
            Natives._LoadTimerDialogHandle = Natives.Get("LoadTimerDialogHandle").ToDelegate<LoadTimerDialogHandlePrototype>();
            Natives._LoadLeaderboardHandle = Natives.Get("LoadLeaderboardHandle").ToDelegate<LoadLeaderboardHandlePrototype>();
            Natives._LoadMultiboardHandle = Natives.Get("LoadMultiboardHandle").ToDelegate<LoadMultiboardHandlePrototype>();
            Natives._LoadMultiboardItemHandle = Natives.Get("LoadMultiboardItemHandle").ToDelegate<LoadMultiboardItemHandlePrototype>();
            Natives._LoadTrackableHandle = Natives.Get("LoadTrackableHandle").ToDelegate<LoadTrackableHandlePrototype>();
            Natives._LoadDialogHandle = Natives.Get("LoadDialogHandle").ToDelegate<LoadDialogHandlePrototype>();
            Natives._LoadButtonHandle = Natives.Get("LoadButtonHandle").ToDelegate<LoadButtonHandlePrototype>();
            Natives._LoadTextTagHandle = Natives.Get("LoadTextTagHandle").ToDelegate<LoadTextTagHandlePrototype>();
            Natives._LoadLightningHandle = Natives.Get("LoadLightningHandle").ToDelegate<LoadLightningHandlePrototype>();
            Natives._LoadImageHandle = Natives.Get("LoadImageHandle").ToDelegate<LoadImageHandlePrototype>();
            Natives._LoadUbersplatHandle = Natives.Get("LoadUbersplatHandle").ToDelegate<LoadUbersplatHandlePrototype>();
            Natives._LoadRegionHandle = Natives.Get("LoadRegionHandle").ToDelegate<LoadRegionHandlePrototype>();
            Natives._LoadFogStateHandle = Natives.Get("LoadFogStateHandle").ToDelegate<LoadFogStateHandlePrototype>();
            Natives._LoadFogModifierHandle = Natives.Get("LoadFogModifierHandle").ToDelegate<LoadFogModifierHandlePrototype>();
            Natives._LoadHashtableHandle = Natives.Get("LoadHashtableHandle").ToDelegate<LoadHashtableHandlePrototype>();
            Natives._HaveSavedInteger = Natives.Get("HaveSavedInteger").ToDelegate<HaveSavedIntegerPrototype>();
            Natives._HaveSavedReal = Natives.Get("HaveSavedReal").ToDelegate<HaveSavedRealPrototype>();
            Natives._HaveSavedBoolean = Natives.Get("HaveSavedBoolean").ToDelegate<HaveSavedBooleanPrototype>();
            Natives._HaveSavedString = Natives.Get("HaveSavedString").ToDelegate<HaveSavedStringPrototype>();
            Natives._HaveSavedHandle = Natives.Get("HaveSavedHandle").ToDelegate<HaveSavedHandlePrototype>();
            Natives._RemoveSavedInteger = Natives.Get("RemoveSavedInteger").ToDelegate<RemoveSavedIntegerPrototype>();
            Natives._RemoveSavedReal = Natives.Get("RemoveSavedReal").ToDelegate<RemoveSavedRealPrototype>();
            Natives._RemoveSavedBoolean = Natives.Get("RemoveSavedBoolean").ToDelegate<RemoveSavedBooleanPrototype>();
            Natives._RemoveSavedString = Natives.Get("RemoveSavedString").ToDelegate<RemoveSavedStringPrototype>();
            Natives._RemoveSavedHandle = Natives.Get("RemoveSavedHandle").ToDelegate<RemoveSavedHandlePrototype>();
            Natives._FlushParentHashtable = Natives.Get("FlushParentHashtable").ToDelegate<FlushParentHashtablePrototype>();
            Natives._FlushChildHashtable = Natives.Get("FlushChildHashtable").ToDelegate<FlushChildHashtablePrototype>();
            Natives._GetRandomInt = Natives.Get("GetRandomInt").ToDelegate<GetRandomIntPrototype>();
            Natives._GetRandomReal = Natives.Get("GetRandomReal").ToDelegate<GetRandomRealPrototype>();
            Natives._CreateUnitPool = Natives.Get("CreateUnitPool").ToDelegate<CreateUnitPoolPrototype>();
            Natives._DestroyUnitPool = Natives.Get("DestroyUnitPool").ToDelegate<DestroyUnitPoolPrototype>();
            Natives._UnitPoolAddUnitType = Natives.Get("UnitPoolAddUnitType").ToDelegate<UnitPoolAddUnitTypePrototype>();
            Natives._UnitPoolRemoveUnitType = Natives.Get("UnitPoolRemoveUnitType").ToDelegate<UnitPoolRemoveUnitTypePrototype>();
            Natives._PlaceRandomUnit = Natives.Get("PlaceRandomUnit").ToDelegate<PlaceRandomUnitPrototype>();
            Natives._CreateItemPool = Natives.Get("CreateItemPool").ToDelegate<CreateItemPoolPrototype>();
            Natives._DestroyItemPool = Natives.Get("DestroyItemPool").ToDelegate<DestroyItemPoolPrototype>();
            Natives._ItemPoolAddItemType = Natives.Get("ItemPoolAddItemType").ToDelegate<ItemPoolAddItemTypePrototype>();
            Natives._ItemPoolRemoveItemType = Natives.Get("ItemPoolRemoveItemType").ToDelegate<ItemPoolRemoveItemTypePrototype>();
            Natives._PlaceRandomItem = Natives.Get("PlaceRandomItem").ToDelegate<PlaceRandomItemPrototype>();
            Natives._ChooseRandomCreep = Natives.Get("ChooseRandomCreep").ToDelegate<ChooseRandomCreepPrototype>();
            Natives._ChooseRandomNPBuilding = Natives.Get("ChooseRandomNPBuilding").ToDelegate<ChooseRandomNPBuildingPrototype>();
            Natives._ChooseRandomItem = Natives.Get("ChooseRandomItem").ToDelegate<ChooseRandomItemPrototype>();
            Natives._ChooseRandomItemEx = Natives.Get("ChooseRandomItemEx").ToDelegate<ChooseRandomItemExPrototype>();
            Natives._SetRandomSeed = Natives.Get("SetRandomSeed").ToDelegate<SetRandomSeedPrototype>();
            Natives._SetTerrainFog = Natives.Get("SetTerrainFog").ToDelegate<SetTerrainFogPrototype>();
            Natives._ResetTerrainFog = Natives.Get("ResetTerrainFog").ToDelegate<ResetTerrainFogPrototype>();
            Natives._SetUnitFog = Natives.Get("SetUnitFog").ToDelegate<SetUnitFogPrototype>();
            Natives._SetTerrainFogEx = Natives.Get("SetTerrainFogEx").ToDelegate<SetTerrainFogExPrototype>();
            Natives._DisplayTextToPlayer = Natives.Get("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>();
            Natives._DisplayTimedTextToPlayer = Natives.Get("DisplayTimedTextToPlayer").ToDelegate<DisplayTimedTextToPlayerPrototype>();
            Natives._DisplayTimedTextFromPlayer = Natives.Get("DisplayTimedTextFromPlayer").ToDelegate<DisplayTimedTextFromPlayerPrototype>();
            Natives._ClearTextMessages = Natives.Get("ClearTextMessages").ToDelegate<ClearTextMessagesPrototype>();
            Natives._SetDayNightModels = Natives.Get("SetDayNightModels").ToDelegate<SetDayNightModelsPrototype>();
            Natives._SetSkyModel = Natives.Get("SetSkyModel").ToDelegate<SetSkyModelPrototype>();
            Natives._EnableUserControl = Natives.Get("EnableUserControl").ToDelegate<EnableUserControlPrototype>();
            Natives._EnableUserUI = Natives.Get("EnableUserUI").ToDelegate<EnableUserUIPrototype>();
            Natives._SuspendTimeOfDay = Natives.Get("SuspendTimeOfDay").ToDelegate<SuspendTimeOfDayPrototype>();
            Natives._SetTimeOfDayScale = Natives.Get("SetTimeOfDayScale").ToDelegate<SetTimeOfDayScalePrototype>();
            Natives._GetTimeOfDayScale = Natives.Get("GetTimeOfDayScale").ToDelegate<GetTimeOfDayScalePrototype>();
            Natives._ShowInterface = Natives.Get("ShowInterface").ToDelegate<ShowInterfacePrototype>();
            Natives._PauseGame = Natives.Get("PauseGame").ToDelegate<PauseGamePrototype>();
            Natives._UnitAddIndicator = Natives.Get("UnitAddIndicator").ToDelegate<UnitAddIndicatorPrototype>();
            Natives._AddIndicator = Natives.Get("AddIndicator").ToDelegate<AddIndicatorPrototype>();
            Natives._PingMinimap = Natives.Get("PingMinimap").ToDelegate<PingMinimapPrototype>();
            Natives._PingMinimapEx = Natives.Get("PingMinimapEx").ToDelegate<PingMinimapExPrototype>();
            Natives._EnableOcclusion = Natives.Get("EnableOcclusion").ToDelegate<EnableOcclusionPrototype>();
            Natives._SetIntroShotText = Natives.Get("SetIntroShotText").ToDelegate<SetIntroShotTextPrototype>();
            Natives._SetIntroShotModel = Natives.Get("SetIntroShotModel").ToDelegate<SetIntroShotModelPrototype>();
            Natives._EnableWorldFogBoundary = Natives.Get("EnableWorldFogBoundary").ToDelegate<EnableWorldFogBoundaryPrototype>();
            Natives._PlayModelCinematic = Natives.Get("PlayModelCinematic").ToDelegate<PlayModelCinematicPrototype>();
            Natives._PlayCinematic = Natives.Get("PlayCinematic").ToDelegate<PlayCinematicPrototype>();
            Natives._ForceUIKey = Natives.Get("ForceUIKey").ToDelegate<ForceUIKeyPrototype>();
            Natives._ForceUICancel = Natives.Get("ForceUICancel").ToDelegate<ForceUICancelPrototype>();
            Natives._DisplayLoadDialog = Natives.Get("DisplayLoadDialog").ToDelegate<DisplayLoadDialogPrototype>();
            Natives._SetAltMinimapIcon = Natives.Get("SetAltMinimapIcon").ToDelegate<SetAltMinimapIconPrototype>();
            Natives._DisableRestartMission = Natives.Get("DisableRestartMission").ToDelegate<DisableRestartMissionPrototype>();
            Natives._CreateTextTag = Natives.Get("CreateTextTag").ToDelegate<CreateTextTagPrototype>();
            Natives._DestroyTextTag = Natives.Get("DestroyTextTag").ToDelegate<DestroyTextTagPrototype>();
            Natives._SetTextTagText = Natives.Get("SetTextTagText").ToDelegate<SetTextTagTextPrototype>();
            Natives._SetTextTagPos = Natives.Get("SetTextTagPos").ToDelegate<SetTextTagPosPrototype>();
            Natives._SetTextTagPosUnit = Natives.Get("SetTextTagPosUnit").ToDelegate<SetTextTagPosUnitPrototype>();
            Natives._SetTextTagColor = Natives.Get("SetTextTagColor").ToDelegate<SetTextTagColorPrototype>();
            Natives._SetTextTagVelocity = Natives.Get("SetTextTagVelocity").ToDelegate<SetTextTagVelocityPrototype>();
            Natives._SetTextTagVisibility = Natives.Get("SetTextTagVisibility").ToDelegate<SetTextTagVisibilityPrototype>();
            Natives._SetTextTagSuspended = Natives.Get("SetTextTagSuspended").ToDelegate<SetTextTagSuspendedPrototype>();
            Natives._SetTextTagPermanent = Natives.Get("SetTextTagPermanent").ToDelegate<SetTextTagPermanentPrototype>();
            Natives._SetTextTagAge = Natives.Get("SetTextTagAge").ToDelegate<SetTextTagAgePrototype>();
            Natives._SetTextTagLifespan = Natives.Get("SetTextTagLifespan").ToDelegate<SetTextTagLifespanPrototype>();
            Natives._SetTextTagFadepoint = Natives.Get("SetTextTagFadepoint").ToDelegate<SetTextTagFadepointPrototype>();
            Natives._SetReservedLocalHeroButtons = Natives.Get("SetReservedLocalHeroButtons").ToDelegate<SetReservedLocalHeroButtonsPrototype>();
            Natives._GetAllyColorFilterState = Natives.Get("GetAllyColorFilterState").ToDelegate<GetAllyColorFilterStatePrototype>();
            Natives._SetAllyColorFilterState = Natives.Get("SetAllyColorFilterState").ToDelegate<SetAllyColorFilterStatePrototype>();
            Natives._GetCreepCampFilterState = Natives.Get("GetCreepCampFilterState").ToDelegate<GetCreepCampFilterStatePrototype>();
            Natives._SetCreepCampFilterState = Natives.Get("SetCreepCampFilterState").ToDelegate<SetCreepCampFilterStatePrototype>();
            Natives._EnableMinimapFilterButtons = Natives.Get("EnableMinimapFilterButtons").ToDelegate<EnableMinimapFilterButtonsPrototype>();
            Natives._EnableDragSelect = Natives.Get("EnableDragSelect").ToDelegate<EnableDragSelectPrototype>();
            Natives._EnablePreSelect = Natives.Get("EnablePreSelect").ToDelegate<EnablePreSelectPrototype>();
            Natives._EnableSelect = Natives.Get("EnableSelect").ToDelegate<EnableSelectPrototype>();
            Natives._CreateTrackable = Natives.Get("CreateTrackable").ToDelegate<CreateTrackablePrototype>();
            Natives._CreateQuest = Natives.Get("CreateQuest").ToDelegate<CreateQuestPrototype>();
            Natives._DestroyQuest = Natives.Get("DestroyQuest").ToDelegate<DestroyQuestPrototype>();
            Natives._QuestSetTitle = Natives.Get("QuestSetTitle").ToDelegate<QuestSetTitlePrototype>();
            Natives._QuestSetDescription = Natives.Get("QuestSetDescription").ToDelegate<QuestSetDescriptionPrototype>();
            Natives._QuestSetIconPath = Natives.Get("QuestSetIconPath").ToDelegate<QuestSetIconPathPrototype>();
            Natives._QuestSetRequired = Natives.Get("QuestSetRequired").ToDelegate<QuestSetRequiredPrototype>();
            Natives._QuestSetCompleted = Natives.Get("QuestSetCompleted").ToDelegate<QuestSetCompletedPrototype>();
            Natives._QuestSetDiscovered = Natives.Get("QuestSetDiscovered").ToDelegate<QuestSetDiscoveredPrototype>();
            Natives._QuestSetFailed = Natives.Get("QuestSetFailed").ToDelegate<QuestSetFailedPrototype>();
            Natives._QuestSetEnabled = Natives.Get("QuestSetEnabled").ToDelegate<QuestSetEnabledPrototype>();
            Natives._IsQuestRequired = Natives.Get("IsQuestRequired").ToDelegate<IsQuestRequiredPrototype>();
            Natives._IsQuestCompleted = Natives.Get("IsQuestCompleted").ToDelegate<IsQuestCompletedPrototype>();
            Natives._IsQuestDiscovered = Natives.Get("IsQuestDiscovered").ToDelegate<IsQuestDiscoveredPrototype>();
            Natives._IsQuestFailed = Natives.Get("IsQuestFailed").ToDelegate<IsQuestFailedPrototype>();
            Natives._IsQuestEnabled = Natives.Get("IsQuestEnabled").ToDelegate<IsQuestEnabledPrototype>();
            Natives._QuestCreateItem = Natives.Get("QuestCreateItem").ToDelegate<QuestCreateItemPrototype>();
            Natives._QuestItemSetDescription = Natives.Get("QuestItemSetDescription").ToDelegate<QuestItemSetDescriptionPrototype>();
            Natives._QuestItemSetCompleted = Natives.Get("QuestItemSetCompleted").ToDelegate<QuestItemSetCompletedPrototype>();
            Natives._IsQuestItemCompleted = Natives.Get("IsQuestItemCompleted").ToDelegate<IsQuestItemCompletedPrototype>();
            Natives._CreateDefeatCondition = Natives.Get("CreateDefeatCondition").ToDelegate<CreateDefeatConditionPrototype>();
            Natives._DestroyDefeatCondition = Natives.Get("DestroyDefeatCondition").ToDelegate<DestroyDefeatConditionPrototype>();
            Natives._DefeatConditionSetDescription = Natives.Get("DefeatConditionSetDescription").ToDelegate<DefeatConditionSetDescriptionPrototype>();
            Natives._FlashQuestDialogButton = Natives.Get("FlashQuestDialogButton").ToDelegate<FlashQuestDialogButtonPrototype>();
            Natives._ForceQuestDialogUpdate = Natives.Get("ForceQuestDialogUpdate").ToDelegate<ForceQuestDialogUpdatePrototype>();
            Natives._CreateTimerDialog = Natives.Get("CreateTimerDialog").ToDelegate<CreateTimerDialogPrototype>();
            Natives._DestroyTimerDialog = Natives.Get("DestroyTimerDialog").ToDelegate<DestroyTimerDialogPrototype>();
            Natives._TimerDialogSetTitle = Natives.Get("TimerDialogSetTitle").ToDelegate<TimerDialogSetTitlePrototype>();
            Natives._TimerDialogSetTitleColor = Natives.Get("TimerDialogSetTitleColor").ToDelegate<TimerDialogSetTitleColorPrototype>();
            Natives._TimerDialogSetTimeColor = Natives.Get("TimerDialogSetTimeColor").ToDelegate<TimerDialogSetTimeColorPrototype>();
            Natives._TimerDialogSetSpeed = Natives.Get("TimerDialogSetSpeed").ToDelegate<TimerDialogSetSpeedPrototype>();
            Natives._TimerDialogDisplay = Natives.Get("TimerDialogDisplay").ToDelegate<TimerDialogDisplayPrototype>();
            Natives._IsTimerDialogDisplayed = Natives.Get("IsTimerDialogDisplayed").ToDelegate<IsTimerDialogDisplayedPrototype>();
            Natives._TimerDialogSetRealTimeRemaining = Natives.Get("TimerDialogSetRealTimeRemaining").ToDelegate<TimerDialogSetRealTimeRemainingPrototype>();
            Natives._CreateLeaderboard = Natives.Get("CreateLeaderboard").ToDelegate<CreateLeaderboardPrototype>();
            Natives._DestroyLeaderboard = Natives.Get("DestroyLeaderboard").ToDelegate<DestroyLeaderboardPrototype>();
            Natives._LeaderboardDisplay = Natives.Get("LeaderboardDisplay").ToDelegate<LeaderboardDisplayPrototype>();
            Natives._IsLeaderboardDisplayed = Natives.Get("IsLeaderboardDisplayed").ToDelegate<IsLeaderboardDisplayedPrototype>();
            Natives._LeaderboardGetItemCount = Natives.Get("LeaderboardGetItemCount").ToDelegate<LeaderboardGetItemCountPrototype>();
            Natives._LeaderboardSetSizeByItemCount = Natives.Get("LeaderboardSetSizeByItemCount").ToDelegate<LeaderboardSetSizeByItemCountPrototype>();
            Natives._LeaderboardAddItem = Natives.Get("LeaderboardAddItem").ToDelegate<LeaderboardAddItemPrototype>();
            Natives._LeaderboardRemoveItem = Natives.Get("LeaderboardRemoveItem").ToDelegate<LeaderboardRemoveItemPrototype>();
            Natives._LeaderboardRemovePlayerItem = Natives.Get("LeaderboardRemovePlayerItem").ToDelegate<LeaderboardRemovePlayerItemPrototype>();
            Natives._LeaderboardClear = Natives.Get("LeaderboardClear").ToDelegate<LeaderboardClearPrototype>();
            Natives._LeaderboardSortItemsByValue = Natives.Get("LeaderboardSortItemsByValue").ToDelegate<LeaderboardSortItemsByValuePrototype>();
            Natives._LeaderboardSortItemsByPlayer = Natives.Get("LeaderboardSortItemsByPlayer").ToDelegate<LeaderboardSortItemsByPlayerPrototype>();
            Natives._LeaderboardSortItemsByLabel = Natives.Get("LeaderboardSortItemsByLabel").ToDelegate<LeaderboardSortItemsByLabelPrototype>();
            Natives._LeaderboardHasPlayerItem = Natives.Get("LeaderboardHasPlayerItem").ToDelegate<LeaderboardHasPlayerItemPrototype>();
            Natives._LeaderboardGetPlayerIndex = Natives.Get("LeaderboardGetPlayerIndex").ToDelegate<LeaderboardGetPlayerIndexPrototype>();
            Natives._LeaderboardSetLabel = Natives.Get("LeaderboardSetLabel").ToDelegate<LeaderboardSetLabelPrototype>();
            Natives._LeaderboardGetLabelText = Natives.Get("LeaderboardGetLabelText").ToDelegate<LeaderboardGetLabelTextPrototype>();
            Natives._PlayerSetLeaderboard = Natives.Get("PlayerSetLeaderboard").ToDelegate<PlayerSetLeaderboardPrototype>();
            Natives._PlayerGetLeaderboard = Natives.Get("PlayerGetLeaderboard").ToDelegate<PlayerGetLeaderboardPrototype>();
            Natives._LeaderboardSetLabelColor = Natives.Get("LeaderboardSetLabelColor").ToDelegate<LeaderboardSetLabelColorPrototype>();
            Natives._LeaderboardSetValueColor = Natives.Get("LeaderboardSetValueColor").ToDelegate<LeaderboardSetValueColorPrototype>();
            Natives._LeaderboardSetStyle = Natives.Get("LeaderboardSetStyle").ToDelegate<LeaderboardSetStylePrototype>();
            Natives._LeaderboardSetItemValue = Natives.Get("LeaderboardSetItemValue").ToDelegate<LeaderboardSetItemValuePrototype>();
            Natives._LeaderboardSetItemLabel = Natives.Get("LeaderboardSetItemLabel").ToDelegate<LeaderboardSetItemLabelPrototype>();
            Natives._LeaderboardSetItemStyle = Natives.Get("LeaderboardSetItemStyle").ToDelegate<LeaderboardSetItemStylePrototype>();
            Natives._LeaderboardSetItemLabelColor = Natives.Get("LeaderboardSetItemLabelColor").ToDelegate<LeaderboardSetItemLabelColorPrototype>();
            Natives._LeaderboardSetItemValueColor = Natives.Get("LeaderboardSetItemValueColor").ToDelegate<LeaderboardSetItemValueColorPrototype>();
            Natives._CreateMultiboard = Natives.Get("CreateMultiboard").ToDelegate<CreateMultiboardPrototype>();
            Natives._DestroyMultiboard = Natives.Get("DestroyMultiboard").ToDelegate<DestroyMultiboardPrototype>();
            Natives._MultiboardDisplay = Natives.Get("MultiboardDisplay").ToDelegate<MultiboardDisplayPrototype>();
            Natives._IsMultiboardDisplayed = Natives.Get("IsMultiboardDisplayed").ToDelegate<IsMultiboardDisplayedPrototype>();
            Natives._MultiboardMinimize = Natives.Get("MultiboardMinimize").ToDelegate<MultiboardMinimizePrototype>();
            Natives._IsMultiboardMinimized = Natives.Get("IsMultiboardMinimized").ToDelegate<IsMultiboardMinimizedPrototype>();
            Natives._MultiboardClear = Natives.Get("MultiboardClear").ToDelegate<MultiboardClearPrototype>();
            Natives._MultiboardSetTitleText = Natives.Get("MultiboardSetTitleText").ToDelegate<MultiboardSetTitleTextPrototype>();
            Natives._MultiboardGetTitleText = Natives.Get("MultiboardGetTitleText").ToDelegate<MultiboardGetTitleTextPrototype>();
            Natives._MultiboardSetTitleTextColor = Natives.Get("MultiboardSetTitleTextColor").ToDelegate<MultiboardSetTitleTextColorPrototype>();
            Natives._MultiboardGetRowCount = Natives.Get("MultiboardGetRowCount").ToDelegate<MultiboardGetRowCountPrototype>();
            Natives._MultiboardGetColumnCount = Natives.Get("MultiboardGetColumnCount").ToDelegate<MultiboardGetColumnCountPrototype>();
            Natives._MultiboardSetColumnCount = Natives.Get("MultiboardSetColumnCount").ToDelegate<MultiboardSetColumnCountPrototype>();
            Natives._MultiboardSetRowCount = Natives.Get("MultiboardSetRowCount").ToDelegate<MultiboardSetRowCountPrototype>();
            Natives._MultiboardSetItemsStyle = Natives.Get("MultiboardSetItemsStyle").ToDelegate<MultiboardSetItemsStylePrototype>();
            Natives._MultiboardSetItemsValue = Natives.Get("MultiboardSetItemsValue").ToDelegate<MultiboardSetItemsValuePrototype>();
            Natives._MultiboardSetItemsValueColor = Natives.Get("MultiboardSetItemsValueColor").ToDelegate<MultiboardSetItemsValueColorPrototype>();
            Natives._MultiboardSetItemsWidth = Natives.Get("MultiboardSetItemsWidth").ToDelegate<MultiboardSetItemsWidthPrototype>();
            Natives._MultiboardSetItemsIcon = Natives.Get("MultiboardSetItemsIcon").ToDelegate<MultiboardSetItemsIconPrototype>();
            Natives._MultiboardGetItem = Natives.Get("MultiboardGetItem").ToDelegate<MultiboardGetItemPrototype>();
            Natives._MultiboardReleaseItem = Natives.Get("MultiboardReleaseItem").ToDelegate<MultiboardReleaseItemPrototype>();
            Natives._MultiboardSetItemStyle = Natives.Get("MultiboardSetItemStyle").ToDelegate<MultiboardSetItemStylePrototype>();
            Natives._MultiboardSetItemValue = Natives.Get("MultiboardSetItemValue").ToDelegate<MultiboardSetItemValuePrototype>();
            Natives._MultiboardSetItemValueColor = Natives.Get("MultiboardSetItemValueColor").ToDelegate<MultiboardSetItemValueColorPrototype>();
            Natives._MultiboardSetItemWidth = Natives.Get("MultiboardSetItemWidth").ToDelegate<MultiboardSetItemWidthPrototype>();
            Natives._MultiboardSetItemIcon = Natives.Get("MultiboardSetItemIcon").ToDelegate<MultiboardSetItemIconPrototype>();
            Natives._MultiboardSuppressDisplay = Natives.Get("MultiboardSuppressDisplay").ToDelegate<MultiboardSuppressDisplayPrototype>();
            Natives._SetCameraPosition = Natives.Get("SetCameraPosition").ToDelegate<SetCameraPositionPrototype>();
            Natives._SetCameraQuickPosition = Natives.Get("SetCameraQuickPosition").ToDelegate<SetCameraQuickPositionPrototype>();
            Natives._SetCameraBounds = Natives.Get("SetCameraBounds").ToDelegate<SetCameraBoundsPrototype>();
            Natives._StopCamera = Natives.Get("StopCamera").ToDelegate<StopCameraPrototype>();
            Natives._ResetToGameCamera = Natives.Get("ResetToGameCamera").ToDelegate<ResetToGameCameraPrototype>();
            Natives._PanCameraTo = Natives.Get("PanCameraTo").ToDelegate<PanCameraToPrototype>();
            Natives._PanCameraToTimed = Natives.Get("PanCameraToTimed").ToDelegate<PanCameraToTimedPrototype>();
            Natives._PanCameraToWithZ = Natives.Get("PanCameraToWithZ").ToDelegate<PanCameraToWithZPrototype>();
            Natives._PanCameraToTimedWithZ = Natives.Get("PanCameraToTimedWithZ").ToDelegate<PanCameraToTimedWithZPrototype>();
            Natives._SetCinematicCamera = Natives.Get("SetCinematicCamera").ToDelegate<SetCinematicCameraPrototype>();
            Natives._SetCameraRotateMode = Natives.Get("SetCameraRotateMode").ToDelegate<SetCameraRotateModePrototype>();
            Natives._SetCameraField = Natives.Get("SetCameraField").ToDelegate<SetCameraFieldPrototype>();
            Natives._AdjustCameraField = Natives.Get("AdjustCameraField").ToDelegate<AdjustCameraFieldPrototype>();
            Natives._SetCameraTargetController = Natives.Get("SetCameraTargetController").ToDelegate<SetCameraTargetControllerPrototype>();
            Natives._SetCameraOrientController = Natives.Get("SetCameraOrientController").ToDelegate<SetCameraOrientControllerPrototype>();
            Natives._CreateCameraSetup = Natives.Get("CreateCameraSetup").ToDelegate<CreateCameraSetupPrototype>();
            Natives._CameraSetupSetField = Natives.Get("CameraSetupSetField").ToDelegate<CameraSetupSetFieldPrototype>();
            Natives._CameraSetupGetField = Natives.Get("CameraSetupGetField").ToDelegate<CameraSetupGetFieldPrototype>();
            Natives._CameraSetupSetDestPosition = Natives.Get("CameraSetupSetDestPosition").ToDelegate<CameraSetupSetDestPositionPrototype>();
            Natives._CameraSetupGetDestPositionLoc = Natives.Get("CameraSetupGetDestPositionLoc").ToDelegate<CameraSetupGetDestPositionLocPrototype>();
            Natives._CameraSetupGetDestPositionX = Natives.Get("CameraSetupGetDestPositionX").ToDelegate<CameraSetupGetDestPositionXPrototype>();
            Natives._CameraSetupGetDestPositionY = Natives.Get("CameraSetupGetDestPositionY").ToDelegate<CameraSetupGetDestPositionYPrototype>();
            Natives._CameraSetupApply = Natives.Get("CameraSetupApply").ToDelegate<CameraSetupApplyPrototype>();
            Natives._CameraSetupApplyWithZ = Natives.Get("CameraSetupApplyWithZ").ToDelegate<CameraSetupApplyWithZPrototype>();
            Natives._CameraSetupApplyForceDuration = Natives.Get("CameraSetupApplyForceDuration").ToDelegate<CameraSetupApplyForceDurationPrototype>();
            Natives._CameraSetupApplyForceDurationWithZ = Natives.Get("CameraSetupApplyForceDurationWithZ").ToDelegate<CameraSetupApplyForceDurationWithZPrototype>();
            Natives._CameraSetTargetNoise = Natives.Get("CameraSetTargetNoise").ToDelegate<CameraSetTargetNoisePrototype>();
            Natives._CameraSetSourceNoise = Natives.Get("CameraSetSourceNoise").ToDelegate<CameraSetSourceNoisePrototype>();
            Natives._CameraSetTargetNoiseEx = Natives.Get("CameraSetTargetNoiseEx").ToDelegate<CameraSetTargetNoiseExPrototype>();
            Natives._CameraSetSourceNoiseEx = Natives.Get("CameraSetSourceNoiseEx").ToDelegate<CameraSetSourceNoiseExPrototype>();
            Natives._CameraSetSmoothingFactor = Natives.Get("CameraSetSmoothingFactor").ToDelegate<CameraSetSmoothingFactorPrototype>();
            Natives._SetCineFilterTexture = Natives.Get("SetCineFilterTexture").ToDelegate<SetCineFilterTexturePrototype>();
            Natives._SetCineFilterBlendMode = Natives.Get("SetCineFilterBlendMode").ToDelegate<SetCineFilterBlendModePrototype>();
            Natives._SetCineFilterTexMapFlags = Natives.Get("SetCineFilterTexMapFlags").ToDelegate<SetCineFilterTexMapFlagsPrototype>();
            Natives._SetCineFilterStartUV = Natives.Get("SetCineFilterStartUV").ToDelegate<SetCineFilterStartUVPrototype>();
            Natives._SetCineFilterEndUV = Natives.Get("SetCineFilterEndUV").ToDelegate<SetCineFilterEndUVPrototype>();
            Natives._SetCineFilterStartColor = Natives.Get("SetCineFilterStartColor").ToDelegate<SetCineFilterStartColorPrototype>();
            Natives._SetCineFilterEndColor = Natives.Get("SetCineFilterEndColor").ToDelegate<SetCineFilterEndColorPrototype>();
            Natives._SetCineFilterDuration = Natives.Get("SetCineFilterDuration").ToDelegate<SetCineFilterDurationPrototype>();
            Natives._DisplayCineFilter = Natives.Get("DisplayCineFilter").ToDelegate<DisplayCineFilterPrototype>();
            Natives._IsCineFilterDisplayed = Natives.Get("IsCineFilterDisplayed").ToDelegate<IsCineFilterDisplayedPrototype>();
            Natives._SetCinematicScene = Natives.Get("SetCinematicScene").ToDelegate<SetCinematicScenePrototype>();
            Natives._EndCinematicScene = Natives.Get("EndCinematicScene").ToDelegate<EndCinematicScenePrototype>();
            Natives._ForceCinematicSubtitles = Natives.Get("ForceCinematicSubtitles").ToDelegate<ForceCinematicSubtitlesPrototype>();
            Natives._GetCameraMargin = Natives.Get("GetCameraMargin").ToDelegate<GetCameraMarginPrototype>();
            Natives._GetCameraBoundMinX = Natives.Get("GetCameraBoundMinX").ToDelegate<GetCameraBoundMinXPrototype>();
            Natives._GetCameraBoundMinY = Natives.Get("GetCameraBoundMinY").ToDelegate<GetCameraBoundMinYPrototype>();
            Natives._GetCameraBoundMaxX = Natives.Get("GetCameraBoundMaxX").ToDelegate<GetCameraBoundMaxXPrototype>();
            Natives._GetCameraBoundMaxY = Natives.Get("GetCameraBoundMaxY").ToDelegate<GetCameraBoundMaxYPrototype>();
            Natives._GetCameraField = Natives.Get("GetCameraField").ToDelegate<GetCameraFieldPrototype>();
            Natives._GetCameraTargetPositionX = Natives.Get("GetCameraTargetPositionX").ToDelegate<GetCameraTargetPositionXPrototype>();
            Natives._GetCameraTargetPositionY = Natives.Get("GetCameraTargetPositionY").ToDelegate<GetCameraTargetPositionYPrototype>();
            Natives._GetCameraTargetPositionZ = Natives.Get("GetCameraTargetPositionZ").ToDelegate<GetCameraTargetPositionZPrototype>();
            Natives._GetCameraTargetPositionLoc = Natives.Get("GetCameraTargetPositionLoc").ToDelegate<GetCameraTargetPositionLocPrototype>();
            Natives._GetCameraEyePositionX = Natives.Get("GetCameraEyePositionX").ToDelegate<GetCameraEyePositionXPrototype>();
            Natives._GetCameraEyePositionY = Natives.Get("GetCameraEyePositionY").ToDelegate<GetCameraEyePositionYPrototype>();
            Natives._GetCameraEyePositionZ = Natives.Get("GetCameraEyePositionZ").ToDelegate<GetCameraEyePositionZPrototype>();
            Natives._GetCameraEyePositionLoc = Natives.Get("GetCameraEyePositionLoc").ToDelegate<GetCameraEyePositionLocPrototype>();
            Natives._NewSoundEnvironment = Natives.Get("NewSoundEnvironment").ToDelegate<NewSoundEnvironmentPrototype>();
            Natives._CreateSound = Natives.Get("CreateSound").ToDelegate<CreateSoundPrototype>();
            Natives._CreateSoundFilenameWithLabel = Natives.Get("CreateSoundFilenameWithLabel").ToDelegate<CreateSoundFilenameWithLabelPrototype>();
            Natives._CreateSoundFromLabel = Natives.Get("CreateSoundFromLabel").ToDelegate<CreateSoundFromLabelPrototype>();
            Natives._CreateMIDISound = Natives.Get("CreateMIDISound").ToDelegate<CreateMIDISoundPrototype>();
            Natives._SetSoundParamsFromLabel = Natives.Get("SetSoundParamsFromLabel").ToDelegate<SetSoundParamsFromLabelPrototype>();
            Natives._SetSoundDistanceCutoff = Natives.Get("SetSoundDistanceCutoff").ToDelegate<SetSoundDistanceCutoffPrototype>();
            Natives._SetSoundChannel = Natives.Get("SetSoundChannel").ToDelegate<SetSoundChannelPrototype>();
            Natives._SetSoundVolume = Natives.Get("SetSoundVolume").ToDelegate<SetSoundVolumePrototype>();
            Natives._SetSoundPitch = Natives.Get("SetSoundPitch").ToDelegate<SetSoundPitchPrototype>();
            Natives._SetSoundPlayPosition = Natives.Get("SetSoundPlayPosition").ToDelegate<SetSoundPlayPositionPrototype>();
            Natives._SetSoundDistances = Natives.Get("SetSoundDistances").ToDelegate<SetSoundDistancesPrototype>();
            Natives._SetSoundConeAngles = Natives.Get("SetSoundConeAngles").ToDelegate<SetSoundConeAnglesPrototype>();
            Natives._SetSoundConeOrientation = Natives.Get("SetSoundConeOrientation").ToDelegate<SetSoundConeOrientationPrototype>();
            Natives._SetSoundPosition = Natives.Get("SetSoundPosition").ToDelegate<SetSoundPositionPrototype>();
            Natives._SetSoundVelocity = Natives.Get("SetSoundVelocity").ToDelegate<SetSoundVelocityPrototype>();
            Natives._AttachSoundToUnit = Natives.Get("AttachSoundToUnit").ToDelegate<AttachSoundToUnitPrototype>();
            Natives._StartSound = Natives.Get("StartSound").ToDelegate<StartSoundPrototype>();
            Natives._StopSound = Natives.Get("StopSound").ToDelegate<StopSoundPrototype>();
            Natives._KillSoundWhenDone = Natives.Get("KillSoundWhenDone").ToDelegate<KillSoundWhenDonePrototype>();
            Natives._SetMapMusic = Natives.Get("SetMapMusic").ToDelegate<SetMapMusicPrototype>();
            Natives._ClearMapMusic = Natives.Get("ClearMapMusic").ToDelegate<ClearMapMusicPrototype>();
            Natives._PlayMusic = Natives.Get("PlayMusic").ToDelegate<PlayMusicPrototype>();
            Natives._PlayMusicEx = Natives.Get("PlayMusicEx").ToDelegate<PlayMusicExPrototype>();
            Natives._StopMusic = Natives.Get("StopMusic").ToDelegate<StopMusicPrototype>();
            Natives._ResumeMusic = Natives.Get("ResumeMusic").ToDelegate<ResumeMusicPrototype>();
            Natives._PlayThematicMusic = Natives.Get("PlayThematicMusic").ToDelegate<PlayThematicMusicPrototype>();
            Natives._PlayThematicMusicEx = Natives.Get("PlayThematicMusicEx").ToDelegate<PlayThematicMusicExPrototype>();
            Natives._EndThematicMusic = Natives.Get("EndThematicMusic").ToDelegate<EndThematicMusicPrototype>();
            Natives._SetMusicVolume = Natives.Get("SetMusicVolume").ToDelegate<SetMusicVolumePrototype>();
            Natives._SetMusicPlayPosition = Natives.Get("SetMusicPlayPosition").ToDelegate<SetMusicPlayPositionPrototype>();
            Natives._SetThematicMusicPlayPosition = Natives.Get("SetThematicMusicPlayPosition").ToDelegate<SetThematicMusicPlayPositionPrototype>();
            Natives._SetSoundDuration = Natives.Get("SetSoundDuration").ToDelegate<SetSoundDurationPrototype>();
            Natives._GetSoundDuration = Natives.Get("GetSoundDuration").ToDelegate<GetSoundDurationPrototype>();
            Natives._GetSoundFileDuration = Natives.Get("GetSoundFileDuration").ToDelegate<GetSoundFileDurationPrototype>();
            Natives._VolumeGroupSetVolume = Natives.Get("VolumeGroupSetVolume").ToDelegate<VolumeGroupSetVolumePrototype>();
            Natives._VolumeGroupReset = Natives.Get("VolumeGroupReset").ToDelegate<VolumeGroupResetPrototype>();
            Natives._GetSoundIsPlaying = Natives.Get("GetSoundIsPlaying").ToDelegate<GetSoundIsPlayingPrototype>();
            Natives._GetSoundIsLoading = Natives.Get("GetSoundIsLoading").ToDelegate<GetSoundIsLoadingPrototype>();
            Natives._RegisterStackedSound = Natives.Get("RegisterStackedSound").ToDelegate<RegisterStackedSoundPrototype>();
            Natives._UnregisterStackedSound = Natives.Get("UnregisterStackedSound").ToDelegate<UnregisterStackedSoundPrototype>();
            Natives._AddWeatherEffect = Natives.Get("AddWeatherEffect").ToDelegate<AddWeatherEffectPrototype>();
            Natives._RemoveWeatherEffect = Natives.Get("RemoveWeatherEffect").ToDelegate<RemoveWeatherEffectPrototype>();
            Natives._EnableWeatherEffect = Natives.Get("EnableWeatherEffect").ToDelegate<EnableWeatherEffectPrototype>();
            Natives._TerrainDeformCrater = Natives.Get("TerrainDeformCrater").ToDelegate<TerrainDeformCraterPrototype>();
            Natives._TerrainDeformRipple = Natives.Get("TerrainDeformRipple").ToDelegate<TerrainDeformRipplePrototype>();
            Natives._TerrainDeformWave = Natives.Get("TerrainDeformWave").ToDelegate<TerrainDeformWavePrototype>();
            Natives._TerrainDeformRandom = Natives.Get("TerrainDeformRandom").ToDelegate<TerrainDeformRandomPrototype>();
            Natives._TerrainDeformStop = Natives.Get("TerrainDeformStop").ToDelegate<TerrainDeformStopPrototype>();
            Natives._TerrainDeformStopAll = Natives.Get("TerrainDeformStopAll").ToDelegate<TerrainDeformStopAllPrototype>();
            Natives._AddSpecialEffect = Natives.Get("AddSpecialEffect").ToDelegate<AddSpecialEffectPrototype>();
            Natives._AddSpecialEffectLoc = Natives.Get("AddSpecialEffectLoc").ToDelegate<AddSpecialEffectLocPrototype>();
            Natives._AddSpecialEffectTarget = Natives.Get("AddSpecialEffectTarget").ToDelegate<AddSpecialEffectTargetPrototype>();
            Natives._DestroyEffect = Natives.Get("DestroyEffect").ToDelegate<DestroyEffectPrototype>();
            Natives._AddSpellEffect = Natives.Get("AddSpellEffect").ToDelegate<AddSpellEffectPrototype>();
            Natives._AddSpellEffectLoc = Natives.Get("AddSpellEffectLoc").ToDelegate<AddSpellEffectLocPrototype>();
            Natives._AddSpellEffectById = Natives.Get("AddSpellEffectById").ToDelegate<AddSpellEffectByIdPrototype>();
            Natives._AddSpellEffectByIdLoc = Natives.Get("AddSpellEffectByIdLoc").ToDelegate<AddSpellEffectByIdLocPrototype>();
            Natives._AddSpellEffectTarget = Natives.Get("AddSpellEffectTarget").ToDelegate<AddSpellEffectTargetPrototype>();
            Natives._AddSpellEffectTargetById = Natives.Get("AddSpellEffectTargetById").ToDelegate<AddSpellEffectTargetByIdPrototype>();
            Natives._AddLightning = Natives.Get("AddLightning").ToDelegate<AddLightningPrototype>();
            Natives._AddLightningEx = Natives.Get("AddLightningEx").ToDelegate<AddLightningExPrototype>();
            Natives._DestroyLightning = Natives.Get("DestroyLightning").ToDelegate<DestroyLightningPrototype>();
            Natives._MoveLightning = Natives.Get("MoveLightning").ToDelegate<MoveLightningPrototype>();
            Natives._MoveLightningEx = Natives.Get("MoveLightningEx").ToDelegate<MoveLightningExPrototype>();
            Natives._GetLightningColorA = Natives.Get("GetLightningColorA").ToDelegate<GetLightningColorAPrototype>();
            Natives._GetLightningColorR = Natives.Get("GetLightningColorR").ToDelegate<GetLightningColorRPrototype>();
            Natives._GetLightningColorG = Natives.Get("GetLightningColorG").ToDelegate<GetLightningColorGPrototype>();
            Natives._GetLightningColorB = Natives.Get("GetLightningColorB").ToDelegate<GetLightningColorBPrototype>();
            Natives._SetLightningColor = Natives.Get("SetLightningColor").ToDelegate<SetLightningColorPrototype>();
            Natives._GetAbilityEffect = Natives.Get("GetAbilityEffect").ToDelegate<GetAbilityEffectPrototype>();
            Natives._GetAbilityEffectById = Natives.Get("GetAbilityEffectById").ToDelegate<GetAbilityEffectByIdPrototype>();
            Natives._GetAbilitySound = Natives.Get("GetAbilitySound").ToDelegate<GetAbilitySoundPrototype>();
            Natives._GetAbilitySoundById = Natives.Get("GetAbilitySoundById").ToDelegate<GetAbilitySoundByIdPrototype>();
            Natives._GetTerrainCliffLevel = Natives.Get("GetTerrainCliffLevel").ToDelegate<GetTerrainCliffLevelPrototype>();
            Natives._SetWaterBaseColor = Natives.Get("SetWaterBaseColor").ToDelegate<SetWaterBaseColorPrototype>();
            Natives._SetWaterDeforms = Natives.Get("SetWaterDeforms").ToDelegate<SetWaterDeformsPrototype>();
            Natives._GetTerrainType = Natives.Get("GetTerrainType").ToDelegate<GetTerrainTypePrototype>();
            Natives._GetTerrainVariance = Natives.Get("GetTerrainVariance").ToDelegate<GetTerrainVariancePrototype>();
            Natives._SetTerrainType = Natives.Get("SetTerrainType").ToDelegate<SetTerrainTypePrototype>();
            Natives._IsTerrainPathable = Natives.Get("IsTerrainPathable").ToDelegate<IsTerrainPathablePrototype>();
            Natives._SetTerrainPathable = Natives.Get("SetTerrainPathable").ToDelegate<SetTerrainPathablePrototype>();
            Natives._CreateImage = Natives.Get("CreateImage").ToDelegate<CreateImagePrototype>();
            Natives._DestroyImage = Natives.Get("DestroyImage").ToDelegate<DestroyImagePrototype>();
            Natives._ShowImage = Natives.Get("ShowImage").ToDelegate<ShowImagePrototype>();
            Natives._SetImageConstantHeight = Natives.Get("SetImageConstantHeight").ToDelegate<SetImageConstantHeightPrototype>();
            Natives._SetImagePosition = Natives.Get("SetImagePosition").ToDelegate<SetImagePositionPrototype>();
            Natives._SetImageColor = Natives.Get("SetImageColor").ToDelegate<SetImageColorPrototype>();
            Natives._SetImageRender = Natives.Get("SetImageRender").ToDelegate<SetImageRenderPrototype>();
            Natives._SetImageRenderAlways = Natives.Get("SetImageRenderAlways").ToDelegate<SetImageRenderAlwaysPrototype>();
            Natives._SetImageAboveWater = Natives.Get("SetImageAboveWater").ToDelegate<SetImageAboveWaterPrototype>();
            Natives._SetImageType = Natives.Get("SetImageType").ToDelegate<SetImageTypePrototype>();
            Natives._CreateUbersplat = Natives.Get("CreateUbersplat").ToDelegate<CreateUbersplatPrototype>();
            Natives._DestroyUbersplat = Natives.Get("DestroyUbersplat").ToDelegate<DestroyUbersplatPrototype>();
            Natives._ResetUbersplat = Natives.Get("ResetUbersplat").ToDelegate<ResetUbersplatPrototype>();
            Natives._FinishUbersplat = Natives.Get("FinishUbersplat").ToDelegate<FinishUbersplatPrototype>();
            Natives._ShowUbersplat = Natives.Get("ShowUbersplat").ToDelegate<ShowUbersplatPrototype>();
            Natives._SetUbersplatRender = Natives.Get("SetUbersplatRender").ToDelegate<SetUbersplatRenderPrototype>();
            Natives._SetUbersplatRenderAlways = Natives.Get("SetUbersplatRenderAlways").ToDelegate<SetUbersplatRenderAlwaysPrototype>();
            Natives._SetBlight = Natives.Get("SetBlight").ToDelegate<SetBlightPrototype>();
            Natives._SetBlightRect = Natives.Get("SetBlightRect").ToDelegate<SetBlightRectPrototype>();
            Natives._SetBlightPoint = Natives.Get("SetBlightPoint").ToDelegate<SetBlightPointPrototype>();
            Natives._SetBlightLoc = Natives.Get("SetBlightLoc").ToDelegate<SetBlightLocPrototype>();
            Natives._CreateBlightedGoldmine = Natives.Get("CreateBlightedGoldmine").ToDelegate<CreateBlightedGoldminePrototype>();
            Natives._IsPointBlighted = Natives.Get("IsPointBlighted").ToDelegate<IsPointBlightedPrototype>();
            Natives._SetDoodadAnimation = Natives.Get("SetDoodadAnimation").ToDelegate<SetDoodadAnimationPrototype>();
            Natives._SetDoodadAnimationRect = Natives.Get("SetDoodadAnimationRect").ToDelegate<SetDoodadAnimationRectPrototype>();
            Natives._StartMeleeAI = Natives.Get("StartMeleeAI").ToDelegate<StartMeleeAIPrototype>();
            Natives._StartCampaignAI = Natives.Get("StartCampaignAI").ToDelegate<StartCampaignAIPrototype>();
            Natives._CommandAI = Natives.Get("CommandAI").ToDelegate<CommandAIPrototype>();
            Natives._PauseCompAI = Natives.Get("PauseCompAI").ToDelegate<PauseCompAIPrototype>();
            Natives._GetAIDifficulty = Natives.Get("GetAIDifficulty").ToDelegate<GetAIDifficultyPrototype>();
            Natives._RemoveGuardPosition = Natives.Get("RemoveGuardPosition").ToDelegate<RemoveGuardPositionPrototype>();
            Natives._RecycleGuardPosition = Natives.Get("RecycleGuardPosition").ToDelegate<RecycleGuardPositionPrototype>();
            Natives._RemoveAllGuardPositions = Natives.Get("RemoveAllGuardPositions").ToDelegate<RemoveAllGuardPositionsPrototype>();
            Natives._Cheat = Natives.Get("Cheat").ToDelegate<CheatPrototype>();
            Natives._IsNoVictoryCheat = Natives.Get("IsNoVictoryCheat").ToDelegate<IsNoVictoryCheatPrototype>();
            Natives._IsNoDefeatCheat = Natives.Get("IsNoDefeatCheat").ToDelegate<IsNoDefeatCheatPrototype>();
            Natives._Preload = Natives.Get("Preload").ToDelegate<PreloadPrototype>();
            Natives._PreloadEnd = Natives.Get("PreloadEnd").ToDelegate<PreloadEndPrototype>();
            Natives._PreloadStart = Natives.Get("PreloadStart").ToDelegate<PreloadStartPrototype>();
            Natives._PreloadRefresh = Natives.Get("PreloadRefresh").ToDelegate<PreloadRefreshPrototype>();
            Natives._PreloadEndEx = Natives.Get("PreloadEndEx").ToDelegate<PreloadEndExPrototype>();
            Natives._PreloadGenClear = Natives.Get("PreloadGenClear").ToDelegate<PreloadGenClearPrototype>();
            Natives._PreloadGenStart = Natives.Get("PreloadGenStart").ToDelegate<PreloadGenStartPrototype>();
            Natives._PreloadGenEnd = Natives.Get("PreloadGenEnd").ToDelegate<PreloadGenEndPrototype>();
            Natives._Preloader = Natives.Get("Preloader").ToDelegate<PreloaderPrototype>();
        }
    }
}
