using System;

namespace TinkerWorX.SharpCraft.Game.Jass
{
    public class Natives : INatives
    {
        //native ConvertRace takes integer i returns race
        private delegate JassRace ConvertRacePrototype(JassInteger i);
        private ConvertRacePrototype _ConvertRace = WarcraftIII.Jass.GetNative("ConvertRace").ToDelegate<ConvertRacePrototype>();
        public JassRace ConvertRace(JassInteger i)
        {
            return _ConvertRace(i);
        }

        //native ConvertAllianceType takes integer i returns alliancetype
        private delegate JassAllianceType ConvertAllianceTypePrototype(JassInteger i);
        private ConvertAllianceTypePrototype _ConvertAllianceType = WarcraftIII.Jass.GetNative("ConvertAllianceType").ToDelegate<ConvertAllianceTypePrototype>();
        public JassAllianceType ConvertAllianceType(JassInteger i)
        {
            return _ConvertAllianceType(i);
        }

        //native ConvertRacePref takes integer i returns racepreference
        private delegate JassRacePreference ConvertRacePrefPrototype(JassInteger i);
        private ConvertRacePrefPrototype _ConvertRacePref = WarcraftIII.Jass.GetNative("ConvertRacePref").ToDelegate<ConvertRacePrefPrototype>();
        public JassRacePreference ConvertRacePref(JassInteger i)
        {
            return _ConvertRacePref(i);
        }

        //native ConvertIGameState takes integer i returns igamestate
        private delegate JassIGameState ConvertIGameStatePrototype(JassInteger i);
        private ConvertIGameStatePrototype _ConvertIGameState = WarcraftIII.Jass.GetNative("ConvertIGameState").ToDelegate<ConvertIGameStatePrototype>();
        public JassIGameState ConvertIGameState(JassInteger i)
        {
            return _ConvertIGameState(i);
        }

        //native ConvertFGameState takes integer i returns fgamestate
        private delegate JassFGameState ConvertFGameStatePrototype(JassInteger i);
        private ConvertFGameStatePrototype _ConvertFGameState = WarcraftIII.Jass.GetNative("ConvertFGameState").ToDelegate<ConvertFGameStatePrototype>();
        public JassFGameState ConvertFGameState(JassInteger i)
        {
            return _ConvertFGameState(i);
        }

        //native ConvertPlayerState takes integer i returns playerstate
        private delegate JassPlayerState ConvertPlayerStatePrototype(JassInteger i);
        private ConvertPlayerStatePrototype _ConvertPlayerState = WarcraftIII.Jass.GetNative("ConvertPlayerState").ToDelegate<ConvertPlayerStatePrototype>();
        public JassPlayerState ConvertPlayerState(JassInteger i)
        {
            return _ConvertPlayerState(i);
        }

        //native ConvertPlayerScore takes integer i returns playerscore
        private delegate JassPlayerScore ConvertPlayerScorePrototype(JassInteger i);
        private ConvertPlayerScorePrototype _ConvertPlayerScore = WarcraftIII.Jass.GetNative("ConvertPlayerScore").ToDelegate<ConvertPlayerScorePrototype>();
        public JassPlayerScore ConvertPlayerScore(JassInteger i)
        {
            return _ConvertPlayerScore(i);
        }

        //native ConvertPlayerGameResult takes integer i returns playergameresult
        private delegate JassPlayerGameResult ConvertPlayerGameResultPrototype(JassInteger i);
        private ConvertPlayerGameResultPrototype _ConvertPlayerGameResult = WarcraftIII.Jass.GetNative("ConvertPlayerGameResult").ToDelegate<ConvertPlayerGameResultPrototype>();
        public JassPlayerGameResult ConvertPlayerGameResult(JassInteger i)
        {
            return _ConvertPlayerGameResult(i);
        }

        //native ConvertUnitState takes integer i returns unitstate
        private delegate JassUnitState ConvertUnitStatePrototype(JassInteger i);
        private ConvertUnitStatePrototype _ConvertUnitState = WarcraftIII.Jass.GetNative("ConvertUnitState").ToDelegate<ConvertUnitStatePrototype>();
        public JassUnitState ConvertUnitState(JassInteger i)
        {
            return _ConvertUnitState(i);
        }

        //native ConvertAIDifficulty takes integer i returns aidifficulty
        private delegate JassAIDifficulty ConvertAIDifficultyPrototype(JassInteger i);
        private ConvertAIDifficultyPrototype _ConvertAIDifficulty = WarcraftIII.Jass.GetNative("ConvertAIDifficulty").ToDelegate<ConvertAIDifficultyPrototype>();
        public JassAIDifficulty ConvertAIDifficulty(JassInteger i)
        {
            return _ConvertAIDifficulty(i);
        }

        //native ConvertGameEvent takes integer i returns gameevent
        private delegate JassGameEvent ConvertGameEventPrototype(JassInteger i);
        private ConvertGameEventPrototype _ConvertGameEvent = WarcraftIII.Jass.GetNative("ConvertGameEvent").ToDelegate<ConvertGameEventPrototype>();
        public JassGameEvent ConvertGameEvent(JassInteger i)
        {
            return _ConvertGameEvent(i);
        }

        //native ConvertPlayerEvent takes integer i returns playerevent
        private delegate JassPlayerEvent ConvertPlayerEventPrototype(JassInteger i);
        private ConvertPlayerEventPrototype _ConvertPlayerEvent = WarcraftIII.Jass.GetNative("ConvertPlayerEvent").ToDelegate<ConvertPlayerEventPrototype>();
        public JassPlayerEvent ConvertPlayerEvent(JassInteger i)
        {
            return _ConvertPlayerEvent(i);
        }

        //native ConvertPlayerUnitEvent takes integer i returns playerunitevent
        private delegate JassPlayerUnitEvent ConvertPlayerUnitEventPrototype(JassInteger i);
        private ConvertPlayerUnitEventPrototype _ConvertPlayerUnitEvent = WarcraftIII.Jass.GetNative("ConvertPlayerUnitEvent").ToDelegate<ConvertPlayerUnitEventPrototype>();
        public JassPlayerUnitEvent ConvertPlayerUnitEvent(JassInteger i)
        {
            return _ConvertPlayerUnitEvent(i);
        }

        //native ConvertWidgetEvent takes integer i returns widgetevent
        private delegate JassWidgetEvent ConvertWidgetEventPrototype(JassInteger i);
        private ConvertWidgetEventPrototype _ConvertWidgetEvent = WarcraftIII.Jass.GetNative("ConvertWidgetEvent").ToDelegate<ConvertWidgetEventPrototype>();
        public JassWidgetEvent ConvertWidgetEvent(JassInteger i)
        {
            return _ConvertWidgetEvent(i);
        }

        //native ConvertDialogEvent takes integer i returns dialogevent
        private delegate JassDialogEvent ConvertDialogEventPrototype(JassInteger i);
        private ConvertDialogEventPrototype _ConvertDialogEvent = WarcraftIII.Jass.GetNative("ConvertDialogEvent").ToDelegate<ConvertDialogEventPrototype>();
        public JassDialogEvent ConvertDialogEvent(JassInteger i)
        {
            return _ConvertDialogEvent(i);
        }

        //native ConvertUnitEvent takes integer i returns unitevent
        private delegate JassUnitEvent ConvertUnitEventPrototype(JassInteger i);
        private ConvertUnitEventPrototype _ConvertUnitEvent = WarcraftIII.Jass.GetNative("ConvertUnitEvent").ToDelegate<ConvertUnitEventPrototype>();
        public JassUnitEvent ConvertUnitEvent(JassInteger i)
        {
            return _ConvertUnitEvent(i);
        }

        //native ConvertLimitOp takes integer i returns limitop
        private delegate JassLimitOp ConvertLimitOpPrototype(JassInteger i);
        private ConvertLimitOpPrototype _ConvertLimitOp = WarcraftIII.Jass.GetNative("ConvertLimitOp").ToDelegate<ConvertLimitOpPrototype>();
        public JassLimitOp ConvertLimitOp(JassInteger i)
        {
            return _ConvertLimitOp(i);
        }

        //native ConvertUnitType takes integer i returns unittype
        private delegate JassUnitType ConvertUnitTypePrototype(JassInteger i);
        private ConvertUnitTypePrototype _ConvertUnitType = WarcraftIII.Jass.GetNative("ConvertUnitType").ToDelegate<ConvertUnitTypePrototype>();
        public JassUnitType ConvertUnitType(JassInteger i)
        {
            return _ConvertUnitType(i);
        }

        //native ConvertGameSpeed takes integer i returns gamespeed
        private delegate JassGameSpeed ConvertGameSpeedPrototype(JassInteger i);
        private ConvertGameSpeedPrototype _ConvertGameSpeed = WarcraftIII.Jass.GetNative("ConvertGameSpeed").ToDelegate<ConvertGameSpeedPrototype>();
        public JassGameSpeed ConvertGameSpeed(JassInteger i)
        {
            return _ConvertGameSpeed(i);
        }

        //native ConvertPlacement takes integer i returns placement
        private delegate JassPlacement ConvertPlacementPrototype(JassInteger i);
        private ConvertPlacementPrototype _ConvertPlacement = WarcraftIII.Jass.GetNative("ConvertPlacement").ToDelegate<ConvertPlacementPrototype>();
        public JassPlacement ConvertPlacement(JassInteger i)
        {
            return _ConvertPlacement(i);
        }

        //native ConvertStartLocPrio takes integer i returns startlocprio
        private delegate JassStartLocationPriority ConvertStartLocPrioPrototype(JassInteger i);
        private ConvertStartLocPrioPrototype _ConvertStartLocPrio = WarcraftIII.Jass.GetNative("ConvertStartLocPrio").ToDelegate<ConvertStartLocPrioPrototype>();
        public JassStartLocationPriority ConvertStartLocPrio(JassInteger i)
        {
            return _ConvertStartLocPrio(i);
        }

        //native ConvertGameDifficulty takes integer i returns gamedifficulty
        private delegate JassGameDifficulty ConvertGameDifficultyPrototype(JassInteger i);
        private ConvertGameDifficultyPrototype _ConvertGameDifficulty = WarcraftIII.Jass.GetNative("ConvertGameDifficulty").ToDelegate<ConvertGameDifficultyPrototype>();
        public JassGameDifficulty ConvertGameDifficulty(JassInteger i)
        {
            return _ConvertGameDifficulty(i);
        }

        //native ConvertGameType takes integer i returns gametype
        private delegate JassGameType ConvertGameTypePrototype(JassInteger i);
        private ConvertGameTypePrototype _ConvertGameType = WarcraftIII.Jass.GetNative("ConvertGameType").ToDelegate<ConvertGameTypePrototype>();
        public JassGameType ConvertGameType(JassInteger i)
        {
            return _ConvertGameType(i);
        }

        //native ConvertMapFlag takes integer i returns mapflag
        private delegate JassMapFlag ConvertMapFlagPrototype(JassInteger i);
        private ConvertMapFlagPrototype _ConvertMapFlag = WarcraftIII.Jass.GetNative("ConvertMapFlag").ToDelegate<ConvertMapFlagPrototype>();
        public JassMapFlag ConvertMapFlag(JassInteger i)
        {
            return _ConvertMapFlag(i);
        }

        //native ConvertMapVisibility takes integer i returns mapvisibility
        private delegate JassMapVisibility ConvertMapVisibilityPrototype(JassInteger i);
        private ConvertMapVisibilityPrototype _ConvertMapVisibility = WarcraftIII.Jass.GetNative("ConvertMapVisibility").ToDelegate<ConvertMapVisibilityPrototype>();
        public JassMapVisibility ConvertMapVisibility(JassInteger i)
        {
            return _ConvertMapVisibility(i);
        }

        //native ConvertMapSetting takes integer i returns mapsetting
        private delegate JassMapSetting ConvertMapSettingPrototype(JassInteger i);
        private ConvertMapSettingPrototype _ConvertMapSetting = WarcraftIII.Jass.GetNative("ConvertMapSetting").ToDelegate<ConvertMapSettingPrototype>();
        public JassMapSetting ConvertMapSetting(JassInteger i)
        {
            return _ConvertMapSetting(i);
        }

        //native ConvertMapDensity takes integer i returns mapdensity
        private delegate JassMapDensity ConvertMapDensityPrototype(JassInteger i);
        private ConvertMapDensityPrototype _ConvertMapDensity = WarcraftIII.Jass.GetNative("ConvertMapDensity").ToDelegate<ConvertMapDensityPrototype>();
        public JassMapDensity ConvertMapDensity(JassInteger i)
        {
            return _ConvertMapDensity(i);
        }

        //native ConvertMapControl takes integer i returns mapcontrol
        private delegate JassMapControl ConvertMapControlPrototype(JassInteger i);
        private ConvertMapControlPrototype _ConvertMapControl = WarcraftIII.Jass.GetNative("ConvertMapControl").ToDelegate<ConvertMapControlPrototype>();
        public JassMapControl ConvertMapControl(JassInteger i)
        {
            return _ConvertMapControl(i);
        }

        //native ConvertPlayerColor takes integer i returns playercolor
        private delegate JassPlayerColor ConvertPlayerColorPrototype(JassInteger i);
        private ConvertPlayerColorPrototype _ConvertPlayerColor = WarcraftIII.Jass.GetNative("ConvertPlayerColor").ToDelegate<ConvertPlayerColorPrototype>();
        public JassPlayerColor ConvertPlayerColor(JassInteger i)
        {
            return _ConvertPlayerColor(i);
        }

        //native ConvertPlayerSlotState takes integer i returns playerslotstate
        private delegate JassPlayerSlotState ConvertPlayerSlotStatePrototype(JassInteger i);
        private ConvertPlayerSlotStatePrototype _ConvertPlayerSlotState = WarcraftIII.Jass.GetNative("ConvertPlayerSlotState").ToDelegate<ConvertPlayerSlotStatePrototype>();
        public JassPlayerSlotState ConvertPlayerSlotState(JassInteger i)
        {
            return _ConvertPlayerSlotState(i);
        }

        //native ConvertVolumeGroup takes integer i returns volumegroup
        private delegate JassVolumeGroup ConvertVolumeGroupPrototype(JassInteger i);
        private ConvertVolumeGroupPrototype _ConvertVolumeGroup = WarcraftIII.Jass.GetNative("ConvertVolumeGroup").ToDelegate<ConvertVolumeGroupPrototype>();
        public JassVolumeGroup ConvertVolumeGroup(JassInteger i)
        {
            return _ConvertVolumeGroup(i);
        }

        //native ConvertCameraField takes integer i returns camerafield
        private delegate JassCameraField ConvertCameraFieldPrototype(JassInteger i);
        private ConvertCameraFieldPrototype _ConvertCameraField = WarcraftIII.Jass.GetNative("ConvertCameraField").ToDelegate<ConvertCameraFieldPrototype>();
        public JassCameraField ConvertCameraField(JassInteger i)
        {
            return _ConvertCameraField(i);
        }

        //native ConvertBlendMode takes integer i returns blendmode
        private delegate JassBlendMode ConvertBlendModePrototype(JassInteger i);
        private ConvertBlendModePrototype _ConvertBlendMode = WarcraftIII.Jass.GetNative("ConvertBlendMode").ToDelegate<ConvertBlendModePrototype>();
        public JassBlendMode ConvertBlendMode(JassInteger i)
        {
            return _ConvertBlendMode(i);
        }

        //native ConvertRarityControl takes integer i returns raritycontrol
        private delegate JassRarityControl ConvertRarityControlPrototype(JassInteger i);
        private ConvertRarityControlPrototype _ConvertRarityControl = WarcraftIII.Jass.GetNative("ConvertRarityControl").ToDelegate<ConvertRarityControlPrototype>();
        public JassRarityControl ConvertRarityControl(JassInteger i)
        {
            return _ConvertRarityControl(i);
        }

        //native ConvertTexMapFlags takes integer i returns texmapflags
        private delegate JassTextureMapFlags ConvertTexMapFlagsPrototype(JassInteger i);
        private ConvertTexMapFlagsPrototype _ConvertTexMapFlags = WarcraftIII.Jass.GetNative("ConvertTexMapFlags").ToDelegate<ConvertTexMapFlagsPrototype>();
        public JassTextureMapFlags ConvertTexMapFlags(JassInteger i)
        {
            return _ConvertTexMapFlags(i);
        }

        //native ConvertFogState takes integer i returns fogstate
        private delegate JassFogState ConvertFogStatePrototype(JassInteger i);
        private ConvertFogStatePrototype _ConvertFogState = WarcraftIII.Jass.GetNative("ConvertFogState").ToDelegate<ConvertFogStatePrototype>();
        public JassFogState ConvertFogState(JassInteger i)
        {
            return _ConvertFogState(i);
        }

        //native ConvertEffectType takes integer i returns effecttype
        private delegate JassEffectType ConvertEffectTypePrototype(JassInteger i);
        private ConvertEffectTypePrototype _ConvertEffectType = WarcraftIII.Jass.GetNative("ConvertEffectType").ToDelegate<ConvertEffectTypePrototype>();
        public JassEffectType ConvertEffectType(JassInteger i)
        {
            return _ConvertEffectType(i);
        }

        //native ConvertVersion takes integer i returns version
        private delegate JassVersion ConvertVersionPrototype(JassInteger i);
        private ConvertVersionPrototype _ConvertVersion = WarcraftIII.Jass.GetNative("ConvertVersion").ToDelegate<ConvertVersionPrototype>();
        public JassVersion ConvertVersion(JassInteger i)
        {
            return _ConvertVersion(i);
        }

        //native ConvertItemType takes integer i returns itemtype
        private delegate JassItemType ConvertItemTypePrototype(JassInteger i);
        private ConvertItemTypePrototype _ConvertItemType = WarcraftIII.Jass.GetNative("ConvertItemType").ToDelegate<ConvertItemTypePrototype>();
        public JassItemType ConvertItemType(JassInteger i)
        {
            return _ConvertItemType(i);
        }

        //native ConvertAttackType takes integer i returns attacktype
        private delegate JassAttackType ConvertAttackTypePrototype(JassInteger i);
        private ConvertAttackTypePrototype _ConvertAttackType = WarcraftIII.Jass.GetNative("ConvertAttackType").ToDelegate<ConvertAttackTypePrototype>();
        public JassAttackType ConvertAttackType(JassInteger i)
        {
            return _ConvertAttackType(i);
        }

        //native ConvertDamageType takes integer i returns damagetype
        private delegate JassDamageType ConvertDamageTypePrototype(JassInteger i);
        private ConvertDamageTypePrototype _ConvertDamageType = WarcraftIII.Jass.GetNative("ConvertDamageType").ToDelegate<ConvertDamageTypePrototype>();
        public JassDamageType ConvertDamageType(JassInteger i)
        {
            return _ConvertDamageType(i);
        }

        //native ConvertWeaponType takes integer i returns weapontype
        private delegate JassWeaponType ConvertWeaponTypePrototype(JassInteger i);
        private ConvertWeaponTypePrototype _ConvertWeaponType = WarcraftIII.Jass.GetNative("ConvertWeaponType").ToDelegate<ConvertWeaponTypePrototype>();
        public JassWeaponType ConvertWeaponType(JassInteger i)
        {
            return _ConvertWeaponType(i);
        }

        //native ConvertSoundType takes integer i returns soundtype
        private delegate JassSoundType ConvertSoundTypePrototype(JassInteger i);
        private ConvertSoundTypePrototype _ConvertSoundType = WarcraftIII.Jass.GetNative("ConvertSoundType").ToDelegate<ConvertSoundTypePrototype>();
        public JassSoundType ConvertSoundType(JassInteger i)
        {
            return _ConvertSoundType(i);
        }

        //native ConvertPathingType takes integer i returns pathingtype
        private delegate JassPathingType ConvertPathingTypePrototype(JassInteger i);
        private ConvertPathingTypePrototype _ConvertPathingType = WarcraftIII.Jass.GetNative("ConvertPathingType").ToDelegate<ConvertPathingTypePrototype>();
        public JassPathingType ConvertPathingType(JassInteger i)
        {
            return _ConvertPathingType(i);
        }

        //native OrderId takes string orderIdString returns integer
        private delegate JassOrder OrderIdPrototype(JassStringArg orderIdString);
        private OrderIdPrototype _OrderId = WarcraftIII.Jass.GetNative("OrderId").ToDelegate<OrderIdPrototype>();
        public JassOrder OrderId(String orderIdString)
        {
            return _OrderId(orderIdString);
        }

        //native OrderId2String takes integer orderId returns string
        private delegate JassStringRet OrderId2StringPrototype(JassOrder orderId);
        private OrderId2StringPrototype _OrderId2String = WarcraftIII.Jass.GetNative("OrderId2String").ToDelegate<OrderId2StringPrototype>();
        public String OrderId2String(JassOrder orderId)
        {
            return _OrderId2String(orderId);
        }

        //native UnitId takes string unitIdString returns integer
        private delegate JassUnitId UnitIdPrototype(JassStringArg unitIdString);
        private UnitIdPrototype _UnitId = WarcraftIII.Jass.GetNative("UnitId").ToDelegate<UnitIdPrototype>();
        public JassUnitId UnitId(String unitIdString)
        {
            return _UnitId(unitIdString);
        }

        //native UnitId2String takes integer unitId returns string
        private delegate JassStringRet UnitId2StringPrototype(JassUnitId unitId);
        private UnitId2StringPrototype _UnitId2String = WarcraftIII.Jass.GetNative("UnitId2String").ToDelegate<UnitId2StringPrototype>();
        public String UnitId2String(JassUnitId unitId)
        {
            return _UnitId2String(unitId);
        }

        //native AbilityId takes string abilityIdString returns integer
        private delegate JassInteger AbilityIdPrototype(JassStringArg abilityIdString);
        private AbilityIdPrototype _AbilityId = WarcraftIII.Jass.GetNative("AbilityId").ToDelegate<AbilityIdPrototype>();
        public JassInteger AbilityId(String abilityIdString)
        {
            return _AbilityId(abilityIdString);
        }

        //native AbilityId2String takes integer abilityId returns string
        private delegate JassStringRet AbilityId2StringPrototype(JassInteger abilityId);
        private AbilityId2StringPrototype _AbilityId2String = WarcraftIII.Jass.GetNative("AbilityId2String").ToDelegate<AbilityId2StringPrototype>();
        public String AbilityId2String(JassInteger abilityId)
        {
            return _AbilityId2String(abilityId);
        }

        //native GetObjectName takes integer objectId returns string
        private delegate JassStringRet GetObjectNamePrototype(JassInteger objectId);
        private GetObjectNamePrototype _GetObjectName = WarcraftIII.Jass.GetNative("GetObjectName").ToDelegate<GetObjectNamePrototype>();
        public String GetObjectName(JassInteger objectId)
        {
            return _GetObjectName(objectId);
        }

        //native Deg2Rad takes real degrees returns real
        private delegate JassRealRet Deg2RadPrototype(JassRealArg degrees);
        private Deg2RadPrototype _Deg2Rad = WarcraftIII.Jass.GetNative("Deg2Rad").ToDelegate<Deg2RadPrototype>();
        public Single Deg2Rad(Single degrees)
        {
            return _Deg2Rad(degrees);
        }

        //native Rad2Deg takes real radians returns real
        private delegate JassRealRet Rad2DegPrototype(JassRealArg radians);
        private Rad2DegPrototype _Rad2Deg = WarcraftIII.Jass.GetNative("Rad2Deg").ToDelegate<Rad2DegPrototype>();
        public Single Rad2Deg(Single radians)
        {
            return _Rad2Deg(radians);
        }

        //native Sin takes real radians returns real
        private delegate JassRealRet SinPrototype(JassRealArg radians);
        private SinPrototype _Sin = WarcraftIII.Jass.GetNative("Sin").ToDelegate<SinPrototype>();
        public Single Sin(Single radians)
        {
            return _Sin(radians);
        }

        //native Cos takes real radians returns real
        private delegate JassRealRet CosPrototype(JassRealArg radians);
        private CosPrototype _Cos = WarcraftIII.Jass.GetNative("Cos").ToDelegate<CosPrototype>();
        public Single Cos(Single radians)
        {
            return _Cos(radians);
        }

        //native Tan takes real radians returns real
        private delegate JassRealRet TanPrototype(JassRealArg radians);
        private TanPrototype _Tan = WarcraftIII.Jass.GetNative("Tan").ToDelegate<TanPrototype>();
        public Single Tan(Single radians)
        {
            return _Tan(radians);
        }

        //native Asin takes real y returns real
        private delegate JassRealRet AsinPrototype(JassRealArg y);
        private AsinPrototype _Asin = WarcraftIII.Jass.GetNative("Asin").ToDelegate<AsinPrototype>();
        public Single Asin(Single y)
        {
            return _Asin(y);
        }

        //native Acos takes real x returns real
        private delegate JassRealRet AcosPrototype(JassRealArg x);
        private AcosPrototype _Acos = WarcraftIII.Jass.GetNative("Acos").ToDelegate<AcosPrototype>();
        public Single Acos(Single x)
        {
            return _Acos(x);
        }

        //native Atan takes real x returns real
        private delegate JassRealRet AtanPrototype(JassRealArg x);
        private AtanPrototype _Atan = WarcraftIII.Jass.GetNative("Atan").ToDelegate<AtanPrototype>();
        public Single Atan(Single x)
        {
            return _Atan(x);
        }

        //native Atan2 takes real y, real x returns real
        private delegate JassRealRet Atan2Prototype(JassRealArg y, JassRealArg x);
        private Atan2Prototype _Atan2 = WarcraftIII.Jass.GetNative("Atan2").ToDelegate<Atan2Prototype>();
        public Single Atan2(Single y, Single x)
        {
            return _Atan2(y, x);
        }

        //native SquareRoot takes real x returns real
        private delegate JassRealRet SquareRootPrototype(JassRealArg x);
        private SquareRootPrototype _SquareRoot = WarcraftIII.Jass.GetNative("SquareRoot").ToDelegate<SquareRootPrototype>();
        public Single SquareRoot(Single x)
        {
            return _SquareRoot(x);
        }

        //native Pow takes real x, real power returns real
        private delegate JassRealRet PowPrototype(JassRealArg x, JassRealArg power);
        private PowPrototype _Pow = WarcraftIII.Jass.GetNative("Pow").ToDelegate<PowPrototype>();
        public Single Pow(Single x, Single power)
        {
            return _Pow(x, power);
        }

        //native I2R takes integer i returns real
        private delegate JassRealRet I2RPrototype(JassInteger i);
        private I2RPrototype _I2R = WarcraftIII.Jass.GetNative("I2R").ToDelegate<I2RPrototype>();
        public Single I2R(JassInteger i)
        {
            return _I2R(i);
        }

        //native R2I takes real r returns integer
        private delegate JassInteger R2IPrototype(JassRealArg r);
        private R2IPrototype _R2I = WarcraftIII.Jass.GetNative("R2I").ToDelegate<R2IPrototype>();
        public JassInteger R2I(Single r)
        {
            return _R2I(r);
        }

        //native I2S takes integer i returns string
        private delegate JassStringRet I2SPrototype(JassInteger i);
        private I2SPrototype _I2S = WarcraftIII.Jass.GetNative("I2S").ToDelegate<I2SPrototype>();
        public String I2S(JassInteger i)
        {
            return _I2S(i);
        }

        //native R2S takes real r returns string
        private delegate JassStringRet R2SPrototype(JassRealArg r);
        private R2SPrototype _R2S = WarcraftIII.Jass.GetNative("R2S").ToDelegate<R2SPrototype>();
        public String R2S(Single r)
        {
            return _R2S(r);
        }

        //native R2SW takes real r, integer width, integer precision returns string
        private delegate JassStringRet R2SWPrototype(JassRealArg r, JassInteger width, JassInteger precision);
        private R2SWPrototype _R2SW = WarcraftIII.Jass.GetNative("R2SW").ToDelegate<R2SWPrototype>();
        public String R2SW(Single r, JassInteger width, JassInteger precision)
        {
            return _R2SW(r, width, precision);
        }

        //native S2I takes string s returns integer
        private delegate JassInteger S2IPrototype(JassStringArg s);
        private S2IPrototype _S2I = WarcraftIII.Jass.GetNative("S2I").ToDelegate<S2IPrototype>();
        public JassInteger S2I(String s)
        {
            return _S2I(s);
        }

        //native S2R takes string s returns real
        private delegate JassRealRet S2RPrototype(JassStringArg s);
        private S2RPrototype _S2R = WarcraftIII.Jass.GetNative("S2R").ToDelegate<S2RPrototype>();
        public Single S2R(String s)
        {
            return _S2R(s);
        }

        //native GetHandleId takes handle h returns integer
        private delegate JassInteger GetHandleIdPrototype(JassHandle h);
        private GetHandleIdPrototype _GetHandleId = WarcraftIII.Jass.GetNative("GetHandleId").ToDelegate<GetHandleIdPrototype>();
        public JassInteger GetHandleId(JassHandle h)
        {
            return _GetHandleId(h);
        }

        //native SubString takes string source, integer start, integer end returns string
        private delegate JassStringRet SubStringPrototype(JassStringArg source, JassInteger start, JassInteger end);
        private SubStringPrototype _SubString = WarcraftIII.Jass.GetNative("SubString").ToDelegate<SubStringPrototype>();
        public String SubString(String source, JassInteger start, JassInteger end)
        {
            return _SubString(source, start, end);
        }

        //native StringLength takes string s returns integer
        private delegate JassInteger StringLengthPrototype(JassStringArg s);
        private StringLengthPrototype _StringLength = WarcraftIII.Jass.GetNative("StringLength").ToDelegate<StringLengthPrototype>();
        public JassInteger StringLength(String s)
        {
            return _StringLength(s);
        }

        //native StringCase takes string source, boolean upper returns string
        private delegate JassStringRet StringCasePrototype(JassStringArg source, JassBoolean upper);
        private StringCasePrototype _StringCase = WarcraftIII.Jass.GetNative("StringCase").ToDelegate<StringCasePrototype>();
        public String StringCase(String source, Boolean upper)
        {
            return _StringCase(source, upper);
        }

        //native StringHash takes string s returns integer
        private delegate JassInteger StringHashPrototype(JassStringArg s);
        private StringHashPrototype _StringHash = WarcraftIII.Jass.GetNative("StringHash").ToDelegate<StringHashPrototype>();
        public JassInteger StringHash(String s)
        {
            return _StringHash(s);
        }

        //native GetLocalizedString takes string source returns string
        private delegate JassStringRet GetLocalizedStringPrototype(JassStringArg source);
        private GetLocalizedStringPrototype _GetLocalizedString = WarcraftIII.Jass.GetNative("GetLocalizedString").ToDelegate<GetLocalizedStringPrototype>();
        public String GetLocalizedString(String source)
        {
            return _GetLocalizedString(source);
        }

        //native GetLocalizedHotkey takes string source returns integer
        private delegate JassInteger GetLocalizedHotkeyPrototype(JassStringArg source);
        private GetLocalizedHotkeyPrototype _GetLocalizedHotkey = WarcraftIII.Jass.GetNative("GetLocalizedHotkey").ToDelegate<GetLocalizedHotkeyPrototype>();
        public JassInteger GetLocalizedHotkey(String source)
        {
            return _GetLocalizedHotkey(source);
        }

        //native SetMapName takes string name returns nothing
        private delegate void SetMapNamePrototype(JassStringArg name);
        private SetMapNamePrototype _SetMapName = WarcraftIII.Jass.GetNative("SetMapName").ToDelegate<SetMapNamePrototype>();
        public void SetMapName(String name)
        {
            _SetMapName(name);
        }

        //native SetMapDescription takes string description returns nothing
        private delegate void SetMapDescriptionPrototype(JassStringArg description);
        private SetMapDescriptionPrototype _SetMapDescription = WarcraftIII.Jass.GetNative("SetMapDescription").ToDelegate<SetMapDescriptionPrototype>();
        public void SetMapDescription(String description)
        {
            _SetMapDescription(description);
        }

        //native SetTeams takes integer teamcount returns nothing
        private delegate void SetTeamsPrototype(JassInteger teamcount);
        private SetTeamsPrototype _SetTeams = WarcraftIII.Jass.GetNative("SetTeams").ToDelegate<SetTeamsPrototype>();
        public void SetTeams(JassInteger teamcount)
        {
            _SetTeams(teamcount);
        }

        //native SetPlayers takes integer playercount returns nothing
        private delegate void SetPlayersPrototype(JassInteger playercount);
        private SetPlayersPrototype _SetPlayers = WarcraftIII.Jass.GetNative("SetPlayers").ToDelegate<SetPlayersPrototype>();
        public void SetPlayers(JassInteger playercount)
        {
            _SetPlayers(playercount);
        }

        //native DefineStartLocation takes integer whichStartLoc, real x, real y returns nothing
        private delegate void DefineStartLocationPrototype(JassInteger whichStartLoc, JassRealArg x, JassRealArg y);
        private DefineStartLocationPrototype _DefineStartLocation = WarcraftIII.Jass.GetNative("DefineStartLocation").ToDelegate<DefineStartLocationPrototype>();
        public void DefineStartLocation(JassInteger whichStartLoc, Single x, Single y)
        {
            _DefineStartLocation(whichStartLoc, x, y);
        }

        //native DefineStartLocationLoc takes integer whichStartLoc, location whichLocation returns nothing
        private delegate void DefineStartLocationLocPrototype(JassInteger whichStartLoc, JassLocation whichLocation);
        private DefineStartLocationLocPrototype _DefineStartLocationLoc = WarcraftIII.Jass.GetNative("DefineStartLocationLoc").ToDelegate<DefineStartLocationLocPrototype>();
        public void DefineStartLocationLoc(JassInteger whichStartLoc, JassLocation whichLocation)
        {
            _DefineStartLocationLoc(whichStartLoc, whichLocation);
        }

        //native SetStartLocPrioCount takes integer whichStartLoc, integer prioSlotCount returns nothing
        private delegate void SetStartLocPrioCountPrototype(JassInteger whichStartLoc, JassInteger prioSlotCount);
        private SetStartLocPrioCountPrototype _SetStartLocPrioCount = WarcraftIII.Jass.GetNative("SetStartLocPrioCount").ToDelegate<SetStartLocPrioCountPrototype>();
        public void SetStartLocPrioCount(JassInteger whichStartLoc, JassInteger prioSlotCount)
        {
            _SetStartLocPrioCount(whichStartLoc, prioSlotCount);
        }

        //native SetStartLocPrio takes integer whichStartLoc, integer prioSlotIndex, integer otherStartLocIndex, startlocprio priority returns nothing
        private delegate void SetStartLocPrioPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority);
        private SetStartLocPrioPrototype _SetStartLocPrio = WarcraftIII.Jass.GetNative("SetStartLocPrio").ToDelegate<SetStartLocPrioPrototype>();
        public void SetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority)
        {
            _SetStartLocPrio(whichStartLoc, prioSlotIndex, otherStartLocIndex, priority);
        }

        //native GetStartLocPrioSlot takes integer whichStartLoc, integer prioSlotIndex returns integer
        private delegate JassInteger GetStartLocPrioSlotPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex);
        private GetStartLocPrioSlotPrototype _GetStartLocPrioSlot = WarcraftIII.Jass.GetNative("GetStartLocPrioSlot").ToDelegate<GetStartLocPrioSlotPrototype>();
        public JassInteger GetStartLocPrioSlot(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return _GetStartLocPrioSlot(whichStartLoc, prioSlotIndex);
        }

        //native GetStartLocPrio takes integer whichStartLoc, integer prioSlotIndex returns startlocprio
        private delegate JassStartLocationPriority GetStartLocPrioPrototype(JassInteger whichStartLoc, JassInteger prioSlotIndex);
        private GetStartLocPrioPrototype _GetStartLocPrio = WarcraftIII.Jass.GetNative("GetStartLocPrio").ToDelegate<GetStartLocPrioPrototype>();
        public JassStartLocationPriority GetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return _GetStartLocPrio(whichStartLoc, prioSlotIndex);
        }

        //native SetGameTypeSupported takes gametype whichGameType, boolean value returns nothing
        private delegate void SetGameTypeSupportedPrototype(JassGameType whichGameType, JassBoolean value);
        private SetGameTypeSupportedPrototype _SetGameTypeSupported = WarcraftIII.Jass.GetNative("SetGameTypeSupported").ToDelegate<SetGameTypeSupportedPrototype>();
        public void SetGameTypeSupported(JassGameType whichGameType, Boolean value)
        {
            _SetGameTypeSupported(whichGameType, value);
        }

        //native SetMapFlag takes mapflag whichMapFlag, boolean value returns nothing
        private delegate void SetMapFlagPrototype(JassMapFlag whichMapFlag, JassBoolean value);
        private SetMapFlagPrototype _SetMapFlag = WarcraftIII.Jass.GetNative("SetMapFlag").ToDelegate<SetMapFlagPrototype>();
        public void SetMapFlag(JassMapFlag whichMapFlag, Boolean value)
        {
            _SetMapFlag(whichMapFlag, value);
        }

        //native SetGamePlacement takes placement whichPlacementType returns nothing
        private delegate void SetGamePlacementPrototype(JassPlacement whichPlacementType);
        private SetGamePlacementPrototype _SetGamePlacement = WarcraftIII.Jass.GetNative("SetGamePlacement").ToDelegate<SetGamePlacementPrototype>();
        public void SetGamePlacement(JassPlacement whichPlacementType)
        {
            _SetGamePlacement(whichPlacementType);
        }

        //native SetGameSpeed takes gamespeed whichspeed returns nothing
        private delegate void SetGameSpeedPrototype(JassGameSpeed whichspeed);
        private SetGameSpeedPrototype _SetGameSpeed = WarcraftIII.Jass.GetNative("SetGameSpeed").ToDelegate<SetGameSpeedPrototype>();
        public void SetGameSpeed(JassGameSpeed whichspeed)
        {
            _SetGameSpeed(whichspeed);
        }

        //native SetGameDifficulty takes gamedifficulty whichdifficulty returns nothing
        private delegate void SetGameDifficultyPrototype(JassGameDifficulty whichdifficulty);
        private SetGameDifficultyPrototype _SetGameDifficulty = WarcraftIII.Jass.GetNative("SetGameDifficulty").ToDelegate<SetGameDifficultyPrototype>();
        public void SetGameDifficulty(JassGameDifficulty whichdifficulty)
        {
            _SetGameDifficulty(whichdifficulty);
        }

        //native SetResourceDensity takes mapdensity whichdensity returns nothing
        private delegate void SetResourceDensityPrototype(JassMapDensity whichdensity);
        private SetResourceDensityPrototype _SetResourceDensity = WarcraftIII.Jass.GetNative("SetResourceDensity").ToDelegate<SetResourceDensityPrototype>();
        public void SetResourceDensity(JassMapDensity whichdensity)
        {
            _SetResourceDensity(whichdensity);
        }

        //native SetCreatureDensity takes mapdensity whichdensity returns nothing
        private delegate void SetCreatureDensityPrototype(JassMapDensity whichdensity);
        private SetCreatureDensityPrototype _SetCreatureDensity = WarcraftIII.Jass.GetNative("SetCreatureDensity").ToDelegate<SetCreatureDensityPrototype>();
        public void SetCreatureDensity(JassMapDensity whichdensity)
        {
            _SetCreatureDensity(whichdensity);
        }

        //native GetTeams takes nothing returns integer
        private delegate JassInteger GetTeamsPrototype();
        private GetTeamsPrototype _GetTeams = WarcraftIII.Jass.GetNative("GetTeams").ToDelegate<GetTeamsPrototype>();
        public JassInteger GetTeams()
        {
            return _GetTeams();
        }

        //native GetPlayers takes nothing returns integer
        private delegate JassInteger GetPlayersPrototype();
        private GetPlayersPrototype _GetPlayers = WarcraftIII.Jass.GetNative("GetPlayers").ToDelegate<GetPlayersPrototype>();
        public JassInteger GetPlayers()
        {
            return _GetPlayers();
        }

        //native IsGameTypeSupported takes gametype whichGameType returns boolean
        private delegate JassBoolean IsGameTypeSupportedPrototype(JassGameType whichGameType);
        private IsGameTypeSupportedPrototype _IsGameTypeSupported = WarcraftIII.Jass.GetNative("IsGameTypeSupported").ToDelegate<IsGameTypeSupportedPrototype>();
        public Boolean IsGameTypeSupported(JassGameType whichGameType)
        {
            return _IsGameTypeSupported(whichGameType);
        }

        //native GetGameTypeSelected takes nothing returns gametype
        private delegate JassGameType GetGameTypeSelectedPrototype();
        private GetGameTypeSelectedPrototype _GetGameTypeSelected = WarcraftIII.Jass.GetNative("GetGameTypeSelected").ToDelegate<GetGameTypeSelectedPrototype>();
        public JassGameType GetGameTypeSelected()
        {
            return _GetGameTypeSelected();
        }

        //native IsMapFlagSet takes mapflag whichMapFlag returns boolean
        private delegate JassBoolean IsMapFlagSetPrototype(JassMapFlag whichMapFlag);
        private IsMapFlagSetPrototype _IsMapFlagSet = WarcraftIII.Jass.GetNative("IsMapFlagSet").ToDelegate<IsMapFlagSetPrototype>();
        public Boolean IsMapFlagSet(JassMapFlag whichMapFlag)
        {
            return _IsMapFlagSet(whichMapFlag);
        }

        //native GetGamePlacement takes nothing returns placement
        private delegate JassPlacement GetGamePlacementPrototype();
        private GetGamePlacementPrototype _GetGamePlacement = WarcraftIII.Jass.GetNative("GetGamePlacement").ToDelegate<GetGamePlacementPrototype>();
        public JassPlacement GetGamePlacement()
        {
            return _GetGamePlacement();
        }

        //native GetGameSpeed takes nothing returns gamespeed
        private delegate JassGameSpeed GetGameSpeedPrototype();
        private GetGameSpeedPrototype _GetGameSpeed = WarcraftIII.Jass.GetNative("GetGameSpeed").ToDelegate<GetGameSpeedPrototype>();
        public JassGameSpeed GetGameSpeed()
        {
            return _GetGameSpeed();
        }

        //native GetGameDifficulty takes nothing returns gamedifficulty
        private delegate JassGameDifficulty GetGameDifficultyPrototype();
        private GetGameDifficultyPrototype _GetGameDifficulty = WarcraftIII.Jass.GetNative("GetGameDifficulty").ToDelegate<GetGameDifficultyPrototype>();
        public JassGameDifficulty GetGameDifficulty()
        {
            return _GetGameDifficulty();
        }

        //native GetResourceDensity takes nothing returns mapdensity
        private delegate JassMapDensity GetResourceDensityPrototype();
        private GetResourceDensityPrototype _GetResourceDensity = WarcraftIII.Jass.GetNative("GetResourceDensity").ToDelegate<GetResourceDensityPrototype>();
        public JassMapDensity GetResourceDensity()
        {
            return _GetResourceDensity();
        }

        //native GetCreatureDensity takes nothing returns mapdensity
        private delegate JassMapDensity GetCreatureDensityPrototype();
        private GetCreatureDensityPrototype _GetCreatureDensity = WarcraftIII.Jass.GetNative("GetCreatureDensity").ToDelegate<GetCreatureDensityPrototype>();
        public JassMapDensity GetCreatureDensity()
        {
            return _GetCreatureDensity();
        }

        //native GetStartLocationX takes integer whichStartLocation returns real
        private delegate JassRealRet GetStartLocationXPrototype(JassInteger whichStartLocation);
        private GetStartLocationXPrototype _GetStartLocationX = WarcraftIII.Jass.GetNative("GetStartLocationX").ToDelegate<GetStartLocationXPrototype>();
        public Single GetStartLocationX(JassInteger whichStartLocation)
        {
            return _GetStartLocationX(whichStartLocation);
        }

        //native GetStartLocationY takes integer whichStartLocation returns real
        private delegate JassRealRet GetStartLocationYPrototype(JassInteger whichStartLocation);
        private GetStartLocationYPrototype _GetStartLocationY = WarcraftIII.Jass.GetNative("GetStartLocationY").ToDelegate<GetStartLocationYPrototype>();
        public Single GetStartLocationY(JassInteger whichStartLocation)
        {
            return _GetStartLocationY(whichStartLocation);
        }

        //native GetStartLocationLoc takes integer whichStartLocation returns location
        private delegate JassLocation GetStartLocationLocPrototype(JassInteger whichStartLocation);
        private GetStartLocationLocPrototype _GetStartLocationLoc = WarcraftIII.Jass.GetNative("GetStartLocationLoc").ToDelegate<GetStartLocationLocPrototype>();
        public JassLocation GetStartLocationLoc(JassInteger whichStartLocation)
        {
            return _GetStartLocationLoc(whichStartLocation);
        }

        //native SetPlayerTeam takes player whichPlayer, integer whichTeam returns nothing
        private delegate void SetPlayerTeamPrototype(JassPlayer whichPlayer, JassInteger whichTeam);
        private SetPlayerTeamPrototype _SetPlayerTeam = WarcraftIII.Jass.GetNative("SetPlayerTeam").ToDelegate<SetPlayerTeamPrototype>();
        public void SetPlayerTeam(JassPlayer whichPlayer, JassInteger whichTeam)
        {
            _SetPlayerTeam(whichPlayer, whichTeam);
        }

        //native SetPlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
        private delegate void SetPlayerStartLocationPrototype(JassPlayer whichPlayer, JassInteger startLocIndex);
        private SetPlayerStartLocationPrototype _SetPlayerStartLocation = WarcraftIII.Jass.GetNative("SetPlayerStartLocation").ToDelegate<SetPlayerStartLocationPrototype>();
        public void SetPlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            _SetPlayerStartLocation(whichPlayer, startLocIndex);
        }

        //native ForcePlayerStartLocation takes player whichPlayer, integer startLocIndex returns nothing
        private delegate void ForcePlayerStartLocationPrototype(JassPlayer whichPlayer, JassInteger startLocIndex);
        private ForcePlayerStartLocationPrototype _ForcePlayerStartLocation = WarcraftIII.Jass.GetNative("ForcePlayerStartLocation").ToDelegate<ForcePlayerStartLocationPrototype>();
        public void ForcePlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            _ForcePlayerStartLocation(whichPlayer, startLocIndex);
        }

        //native SetPlayerColor takes player whichPlayer, playercolor color returns nothing
        private delegate void SetPlayerColorPrototype(JassPlayer whichPlayer, JassPlayerColor color);
        private SetPlayerColorPrototype _SetPlayerColor = WarcraftIII.Jass.GetNative("SetPlayerColor").ToDelegate<SetPlayerColorPrototype>();
        public void SetPlayerColor(JassPlayer whichPlayer, JassPlayerColor color)
        {
            _SetPlayerColor(whichPlayer, color);
        }

        //native SetPlayerAlliance takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting, boolean value returns nothing
        private delegate void SetPlayerAlliancePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, JassBoolean value);
        private SetPlayerAlliancePrototype _SetPlayerAlliance = WarcraftIII.Jass.GetNative("SetPlayerAlliance").ToDelegate<SetPlayerAlliancePrototype>();
        public void SetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, Boolean value)
        {
            _SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);
        }

        //native SetPlayerTaxRate takes player sourcePlayer, player otherPlayer, playerstate whichResource, integer rate returns nothing
        private delegate void SetPlayerTaxRatePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate);
        private SetPlayerTaxRatePrototype _SetPlayerTaxRate = WarcraftIII.Jass.GetNative("SetPlayerTaxRate").ToDelegate<SetPlayerTaxRatePrototype>();
        public void SetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate)
        {
            _SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);
        }

        //native SetPlayerRacePreference takes player whichPlayer, racepreference whichRacePreference returns nothing
        private delegate void SetPlayerRacePreferencePrototype(JassPlayer whichPlayer, JassRacePreference whichRacePreference);
        private SetPlayerRacePreferencePrototype _SetPlayerRacePreference = WarcraftIII.Jass.GetNative("SetPlayerRacePreference").ToDelegate<SetPlayerRacePreferencePrototype>();
        public void SetPlayerRacePreference(JassPlayer whichPlayer, JassRacePreference whichRacePreference)
        {
            _SetPlayerRacePreference(whichPlayer, whichRacePreference);
        }

        //native SetPlayerRaceSelectable takes player whichPlayer, boolean value returns nothing
        private delegate void SetPlayerRaceSelectablePrototype(JassPlayer whichPlayer, JassBoolean value);
        private SetPlayerRaceSelectablePrototype _SetPlayerRaceSelectable = WarcraftIII.Jass.GetNative("SetPlayerRaceSelectable").ToDelegate<SetPlayerRaceSelectablePrototype>();
        public void SetPlayerRaceSelectable(JassPlayer whichPlayer, Boolean value)
        {
            _SetPlayerRaceSelectable(whichPlayer, value);
        }

        //native SetPlayerController takes player whichPlayer, mapcontrol controlType returns nothing
        private delegate void SetPlayerControllerPrototype(JassPlayer whichPlayer, JassMapControl controlType);
        private SetPlayerControllerPrototype _SetPlayerController = WarcraftIII.Jass.GetNative("SetPlayerController").ToDelegate<SetPlayerControllerPrototype>();
        public void SetPlayerController(JassPlayer whichPlayer, JassMapControl controlType)
        {
            _SetPlayerController(whichPlayer, controlType);
        }

        //native SetPlayerName takes player whichPlayer, string name returns nothing
        private delegate void SetPlayerNamePrototype(JassPlayer whichPlayer, JassStringArg name);
        private SetPlayerNamePrototype _SetPlayerName = WarcraftIII.Jass.GetNative("SetPlayerName").ToDelegate<SetPlayerNamePrototype>();
        public void SetPlayerName(JassPlayer whichPlayer, String name)
        {
            _SetPlayerName(whichPlayer, name);
        }

        //native SetPlayerOnScoreScreen takes player whichPlayer, boolean flag returns nothing
        private delegate void SetPlayerOnScoreScreenPrototype(JassPlayer whichPlayer, JassBoolean flag);
        private SetPlayerOnScoreScreenPrototype _SetPlayerOnScoreScreen = WarcraftIII.Jass.GetNative("SetPlayerOnScoreScreen").ToDelegate<SetPlayerOnScoreScreenPrototype>();
        public void SetPlayerOnScoreScreen(JassPlayer whichPlayer, Boolean flag)
        {
            _SetPlayerOnScoreScreen(whichPlayer, flag);
        }

        //native GetPlayerTeam takes player whichPlayer returns integer
        private delegate JassInteger GetPlayerTeamPrototype(JassPlayer whichPlayer);
        private GetPlayerTeamPrototype _GetPlayerTeam = WarcraftIII.Jass.GetNative("GetPlayerTeam").ToDelegate<GetPlayerTeamPrototype>();
        public JassInteger GetPlayerTeam(JassPlayer whichPlayer)
        {
            return _GetPlayerTeam(whichPlayer);
        }

        //native GetPlayerStartLocation takes player whichPlayer returns integer
        private delegate JassInteger GetPlayerStartLocationPrototype(JassPlayer whichPlayer);
        private GetPlayerStartLocationPrototype _GetPlayerStartLocation = WarcraftIII.Jass.GetNative("GetPlayerStartLocation").ToDelegate<GetPlayerStartLocationPrototype>();
        public JassInteger GetPlayerStartLocation(JassPlayer whichPlayer)
        {
            return _GetPlayerStartLocation(whichPlayer);
        }

        //native GetPlayerColor takes player whichPlayer returns playercolor
        private delegate JassPlayerColor GetPlayerColorPrototype(JassPlayer whichPlayer);
        private GetPlayerColorPrototype _GetPlayerColor = WarcraftIII.Jass.GetNative("GetPlayerColor").ToDelegate<GetPlayerColorPrototype>();
        public JassPlayerColor GetPlayerColor(JassPlayer whichPlayer)
        {
            return _GetPlayerColor(whichPlayer);
        }

        //native GetPlayerSelectable takes player whichPlayer returns boolean
        private delegate JassBoolean GetPlayerSelectablePrototype(JassPlayer whichPlayer);
        private GetPlayerSelectablePrototype _GetPlayerSelectable = WarcraftIII.Jass.GetNative("GetPlayerSelectable").ToDelegate<GetPlayerSelectablePrototype>();
        public Boolean GetPlayerSelectable(JassPlayer whichPlayer)
        {
            return _GetPlayerSelectable(whichPlayer);
        }

        //native GetPlayerController takes player whichPlayer returns mapcontrol
        private delegate JassMapControl GetPlayerControllerPrototype(JassPlayer whichPlayer);
        private GetPlayerControllerPrototype _GetPlayerController = WarcraftIII.Jass.GetNative("GetPlayerController").ToDelegate<GetPlayerControllerPrototype>();
        public JassMapControl GetPlayerController(JassPlayer whichPlayer)
        {
            return _GetPlayerController(whichPlayer);
        }

        //native GetPlayerSlotState takes player whichPlayer returns playerslotstate
        private delegate JassPlayerSlotState GetPlayerSlotStatePrototype(JassPlayer whichPlayer);
        private GetPlayerSlotStatePrototype _GetPlayerSlotState = WarcraftIII.Jass.GetNative("GetPlayerSlotState").ToDelegate<GetPlayerSlotStatePrototype>();
        public JassPlayerSlotState GetPlayerSlotState(JassPlayer whichPlayer)
        {
            return _GetPlayerSlotState(whichPlayer);
        }

        //native GetPlayerTaxRate takes player sourcePlayer, player otherPlayer, playerstate whichResource returns integer
        private delegate JassInteger GetPlayerTaxRatePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource);
        private GetPlayerTaxRatePrototype _GetPlayerTaxRate = WarcraftIII.Jass.GetNative("GetPlayerTaxRate").ToDelegate<GetPlayerTaxRatePrototype>();
        public JassInteger GetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource)
        {
            return _GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);
        }

        //native IsPlayerRacePrefSet takes player whichPlayer, racepreference pref returns boolean
        private delegate JassBoolean IsPlayerRacePrefSetPrototype(JassPlayer whichPlayer, JassRacePreference pref);
        private IsPlayerRacePrefSetPrototype _IsPlayerRacePrefSet = WarcraftIII.Jass.GetNative("IsPlayerRacePrefSet").ToDelegate<IsPlayerRacePrefSetPrototype>();
        public Boolean IsPlayerRacePrefSet(JassPlayer whichPlayer, JassRacePreference pref)
        {
            return _IsPlayerRacePrefSet(whichPlayer, pref);
        }

        //native GetPlayerName takes player whichPlayer returns string
        private delegate JassStringRet GetPlayerNamePrototype(JassPlayer whichPlayer);
        private GetPlayerNamePrototype _GetPlayerName = WarcraftIII.Jass.GetNative("GetPlayerName").ToDelegate<GetPlayerNamePrototype>();
        public String GetPlayerName(JassPlayer whichPlayer)
        {
            return _GetPlayerName(whichPlayer);
        }

        //native CreateTimer takes nothing returns timer
        private delegate JassTimer CreateTimerPrototype();
        private CreateTimerPrototype _CreateTimer = WarcraftIII.Jass.GetNative("CreateTimer").ToDelegate<CreateTimerPrototype>();
        public JassTimer CreateTimer()
        {
            return _CreateTimer();
        }

        //native DestroyTimer takes timer whichTimer returns nothing
        private delegate void DestroyTimerPrototype(JassTimer whichTimer);
        private DestroyTimerPrototype _DestroyTimer = WarcraftIII.Jass.GetNative("DestroyTimer").ToDelegate<DestroyTimerPrototype>();
        public void DestroyTimer(JassTimer whichTimer)
        {
            _DestroyTimer(whichTimer);
        }

        //native TimerStart takes timer whichTimer, real timeout, boolean periodic, code handlerFunc returns nothing
        private delegate void TimerStartPrototype(JassTimer whichTimer, JassRealArg timeout, JassBoolean periodic, JassCode handlerFunc);
        private TimerStartPrototype _TimerStart = WarcraftIII.Jass.GetNative("TimerStart").ToDelegate<TimerStartPrototype>();
        public void TimerStart(JassTimer whichTimer, Single timeout, Boolean periodic, JassCode handlerFunc)
        {
            _TimerStart(whichTimer, timeout, periodic, handlerFunc);
        }

        //native TimerGetElapsed takes timer whichTimer returns real
        private delegate JassRealRet TimerGetElapsedPrototype(JassTimer whichTimer);
        private TimerGetElapsedPrototype _TimerGetElapsed = WarcraftIII.Jass.GetNative("TimerGetElapsed").ToDelegate<TimerGetElapsedPrototype>();
        public Single TimerGetElapsed(JassTimer whichTimer)
        {
            return _TimerGetElapsed(whichTimer);
        }

        //native TimerGetRemaining takes timer whichTimer returns real
        private delegate JassRealRet TimerGetRemainingPrototype(JassTimer whichTimer);
        private TimerGetRemainingPrototype _TimerGetRemaining = WarcraftIII.Jass.GetNative("TimerGetRemaining").ToDelegate<TimerGetRemainingPrototype>();
        public Single TimerGetRemaining(JassTimer whichTimer)
        {
            return _TimerGetRemaining(whichTimer);
        }

        //native TimerGetTimeout takes timer whichTimer returns real
        private delegate JassRealRet TimerGetTimeoutPrototype(JassTimer whichTimer);
        private TimerGetTimeoutPrototype _TimerGetTimeout = WarcraftIII.Jass.GetNative("TimerGetTimeout").ToDelegate<TimerGetTimeoutPrototype>();
        public Single TimerGetTimeout(JassTimer whichTimer)
        {
            return _TimerGetTimeout(whichTimer);
        }

        //native PauseTimer takes timer whichTimer returns nothing
        private delegate void PauseTimerPrototype(JassTimer whichTimer);
        private PauseTimerPrototype _PauseTimer = WarcraftIII.Jass.GetNative("PauseTimer").ToDelegate<PauseTimerPrototype>();
        public void PauseTimer(JassTimer whichTimer)
        {
            _PauseTimer(whichTimer);
        }

        //native ResumeTimer takes timer whichTimer returns nothing
        private delegate void ResumeTimerPrototype(JassTimer whichTimer);
        private ResumeTimerPrototype _ResumeTimer = WarcraftIII.Jass.GetNative("ResumeTimer").ToDelegate<ResumeTimerPrototype>();
        public void ResumeTimer(JassTimer whichTimer)
        {
            _ResumeTimer(whichTimer);
        }

        //native GetExpiredTimer takes nothing returns timer
        private delegate JassTimer GetExpiredTimerPrototype();
        private GetExpiredTimerPrototype _GetExpiredTimer = WarcraftIII.Jass.GetNative("GetExpiredTimer").ToDelegate<GetExpiredTimerPrototype>();
        public JassTimer GetExpiredTimer()
        {
            return _GetExpiredTimer();
        }

        //native CreateGroup takes nothing returns group
        private delegate JassGroup CreateGroupPrototype();
        private CreateGroupPrototype _CreateGroup = WarcraftIII.Jass.GetNative("CreateGroup").ToDelegate<CreateGroupPrototype>();
        public JassGroup CreateGroup()
        {
            return _CreateGroup();
        }

        //native DestroyGroup takes group whichGroup returns nothing
        private delegate void DestroyGroupPrototype(JassGroup whichGroup);
        private DestroyGroupPrototype _DestroyGroup = WarcraftIII.Jass.GetNative("DestroyGroup").ToDelegate<DestroyGroupPrototype>();
        public void DestroyGroup(JassGroup whichGroup)
        {
            _DestroyGroup(whichGroup);
        }

        //native GroupAddUnit takes group whichGroup, unit whichUnit returns nothing
        private delegate void GroupAddUnitPrototype(JassGroup whichGroup, JassUnit whichUnit);
        private GroupAddUnitPrototype _GroupAddUnit = WarcraftIII.Jass.GetNative("GroupAddUnit").ToDelegate<GroupAddUnitPrototype>();
        public void GroupAddUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            _GroupAddUnit(whichGroup, whichUnit);
        }

        //native GroupRemoveUnit takes group whichGroup, unit whichUnit returns nothing
        private delegate void GroupRemoveUnitPrototype(JassGroup whichGroup, JassUnit whichUnit);
        private GroupRemoveUnitPrototype _GroupRemoveUnit = WarcraftIII.Jass.GetNative("GroupRemoveUnit").ToDelegate<GroupRemoveUnitPrototype>();
        public void GroupRemoveUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            _GroupRemoveUnit(whichGroup, whichUnit);
        }

        //native GroupClear takes group whichGroup returns nothing
        private delegate void GroupClearPrototype(JassGroup whichGroup);
        private GroupClearPrototype _GroupClear = WarcraftIII.Jass.GetNative("GroupClear").ToDelegate<GroupClearPrototype>();
        public void GroupClear(JassGroup whichGroup)
        {
            _GroupClear(whichGroup);
        }

        //native GroupEnumUnitsOfType takes group whichGroup, string unitname, boolexpr filter returns nothing
        private delegate void GroupEnumUnitsOfTypePrototype(JassGroup whichGroup, JassStringArg unitname, JassBooleanExpression filter);
        private GroupEnumUnitsOfTypePrototype _GroupEnumUnitsOfType = WarcraftIII.Jass.GetNative("GroupEnumUnitsOfType").ToDelegate<GroupEnumUnitsOfTypePrototype>();
        public void GroupEnumUnitsOfType(JassGroup whichGroup, String unitname, JassBooleanExpression filter)
        {
            _GroupEnumUnitsOfType(whichGroup, unitname, filter);
        }

        //native GroupEnumUnitsOfPlayer takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
        private delegate void GroupEnumUnitsOfPlayerPrototype(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter);
        private GroupEnumUnitsOfPlayerPrototype _GroupEnumUnitsOfPlayer = WarcraftIII.Jass.GetNative("GroupEnumUnitsOfPlayer").ToDelegate<GroupEnumUnitsOfPlayerPrototype>();
        public void GroupEnumUnitsOfPlayer(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            _GroupEnumUnitsOfPlayer(whichGroup, whichPlayer, filter);
        }

        //native GroupEnumUnitsOfTypeCounted takes group whichGroup, string unitname, boolexpr filter, integer countLimit returns nothing
        private delegate void GroupEnumUnitsOfTypeCountedPrototype(JassGroup whichGroup, JassStringArg unitname, JassBooleanExpression filter, JassInteger countLimit);
        private GroupEnumUnitsOfTypeCountedPrototype _GroupEnumUnitsOfTypeCounted = WarcraftIII.Jass.GetNative("GroupEnumUnitsOfTypeCounted").ToDelegate<GroupEnumUnitsOfTypeCountedPrototype>();
        public void GroupEnumUnitsOfTypeCounted(JassGroup whichGroup, String unitname, JassBooleanExpression filter, JassInteger countLimit)
        {
            _GroupEnumUnitsOfTypeCounted(whichGroup, unitname, filter, countLimit);
        }

        //native GroupEnumUnitsInRect takes group whichGroup, rect r, boolexpr filter returns nothing
        private delegate void GroupEnumUnitsInRectPrototype(JassGroup whichGroup, JassRect r, JassBooleanExpression filter);
        private GroupEnumUnitsInRectPrototype _GroupEnumUnitsInRect = WarcraftIII.Jass.GetNative("GroupEnumUnitsInRect").ToDelegate<GroupEnumUnitsInRectPrototype>();
        public void GroupEnumUnitsInRect(JassGroup whichGroup, JassRect r, JassBooleanExpression filter)
        {
            _GroupEnumUnitsInRect(whichGroup, r, filter);
        }

        //native GroupEnumUnitsInRectCounted takes group whichGroup, rect r, boolexpr filter, integer countLimit returns nothing
        private delegate void GroupEnumUnitsInRectCountedPrototype(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit);
        private GroupEnumUnitsInRectCountedPrototype _GroupEnumUnitsInRectCounted = WarcraftIII.Jass.GetNative("GroupEnumUnitsInRectCounted").ToDelegate<GroupEnumUnitsInRectCountedPrototype>();
        public void GroupEnumUnitsInRectCounted(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit)
        {
            _GroupEnumUnitsInRectCounted(whichGroup, r, filter, countLimit);
        }

        //native GroupEnumUnitsInRange takes group whichGroup, real x, real y, real radius, boolexpr filter returns nothing
        private delegate void GroupEnumUnitsInRangePrototype(JassGroup whichGroup, JassRealArg x, JassRealArg y, JassRealArg radius, JassBooleanExpression filter);
        private GroupEnumUnitsInRangePrototype _GroupEnumUnitsInRange = WarcraftIII.Jass.GetNative("GroupEnumUnitsInRange").ToDelegate<GroupEnumUnitsInRangePrototype>();
        public void GroupEnumUnitsInRange(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter)
        {
            _GroupEnumUnitsInRange(whichGroup, x, y, radius, filter);
        }

        //native GroupEnumUnitsInRangeOfLoc takes group whichGroup, location whichLocation, real radius, boolexpr filter returns nothing
        private delegate void GroupEnumUnitsInRangeOfLocPrototype(JassGroup whichGroup, JassLocation whichLocation, JassRealArg radius, JassBooleanExpression filter);
        private GroupEnumUnitsInRangeOfLocPrototype _GroupEnumUnitsInRangeOfLoc = WarcraftIII.Jass.GetNative("GroupEnumUnitsInRangeOfLoc").ToDelegate<GroupEnumUnitsInRangeOfLocPrototype>();
        public void GroupEnumUnitsInRangeOfLoc(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter)
        {
            _GroupEnumUnitsInRangeOfLoc(whichGroup, whichLocation, radius, filter);
        }

        //native GroupEnumUnitsInRangeCounted takes group whichGroup, real x, real y, real radius, boolexpr filter, integer countLimit returns nothing
        private delegate void GroupEnumUnitsInRangeCountedPrototype(JassGroup whichGroup, JassRealArg x, JassRealArg y, JassRealArg radius, JassBooleanExpression filter, JassInteger countLimit);
        private GroupEnumUnitsInRangeCountedPrototype _GroupEnumUnitsInRangeCounted = WarcraftIII.Jass.GetNative("GroupEnumUnitsInRangeCounted").ToDelegate<GroupEnumUnitsInRangeCountedPrototype>();
        public void GroupEnumUnitsInRangeCounted(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            _GroupEnumUnitsInRangeCounted(whichGroup, x, y, radius, filter, countLimit);
        }

        //native GroupEnumUnitsInRangeOfLocCounted takes group whichGroup, location whichLocation, real radius, boolexpr filter, integer countLimit returns nothing
        private delegate void GroupEnumUnitsInRangeOfLocCountedPrototype(JassGroup whichGroup, JassLocation whichLocation, JassRealArg radius, JassBooleanExpression filter, JassInteger countLimit);
        private GroupEnumUnitsInRangeOfLocCountedPrototype _GroupEnumUnitsInRangeOfLocCounted = WarcraftIII.Jass.GetNative("GroupEnumUnitsInRangeOfLocCounted").ToDelegate<GroupEnumUnitsInRangeOfLocCountedPrototype>();
        public void GroupEnumUnitsInRangeOfLocCounted(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            _GroupEnumUnitsInRangeOfLocCounted(whichGroup, whichLocation, radius, filter, countLimit);
        }

        //native GroupEnumUnitsSelected takes group whichGroup, player whichPlayer, boolexpr filter returns nothing
        private delegate void GroupEnumUnitsSelectedPrototype(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter);
        private GroupEnumUnitsSelectedPrototype _GroupEnumUnitsSelected = WarcraftIII.Jass.GetNative("GroupEnumUnitsSelected").ToDelegate<GroupEnumUnitsSelectedPrototype>();
        public void GroupEnumUnitsSelected(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            _GroupEnumUnitsSelected(whichGroup, whichPlayer, filter);
        }

        //native GroupImmediateOrder takes group whichGroup, string order returns boolean
        private delegate JassBoolean GroupImmediateOrderPrototype(JassGroup whichGroup, JassStringArg order);
        private GroupImmediateOrderPrototype _GroupImmediateOrder = WarcraftIII.Jass.GetNative("GroupImmediateOrder").ToDelegate<GroupImmediateOrderPrototype>();
        public Boolean GroupImmediateOrder(JassGroup whichGroup, String order)
        {
            return _GroupImmediateOrder(whichGroup, order);
        }

        //native GroupImmediateOrderById takes group whichGroup, integer order returns boolean
        private delegate JassBoolean GroupImmediateOrderByIdPrototype(JassGroup whichGroup, JassOrder order);
        private GroupImmediateOrderByIdPrototype _GroupImmediateOrderById = WarcraftIII.Jass.GetNative("GroupImmediateOrderById").ToDelegate<GroupImmediateOrderByIdPrototype>();
        public Boolean GroupImmediateOrderById(JassGroup whichGroup, JassOrder order)
        {
            return _GroupImmediateOrderById(whichGroup, order);
        }

        //native GroupPointOrder takes group whichGroup, string order, real x, real y returns boolean
        private delegate JassBoolean GroupPointOrderPrototype(JassGroup whichGroup, JassStringArg order, JassRealArg x, JassRealArg y);
        private GroupPointOrderPrototype _GroupPointOrder = WarcraftIII.Jass.GetNative("GroupPointOrder").ToDelegate<GroupPointOrderPrototype>();
        public Boolean GroupPointOrder(JassGroup whichGroup, String order, Single x, Single y)
        {
            return _GroupPointOrder(whichGroup, order, x, y);
        }

        //native GroupPointOrderLoc takes group whichGroup, string order, location whichLocation returns boolean
        private delegate JassBoolean GroupPointOrderLocPrototype(JassGroup whichGroup, JassStringArg order, JassLocation whichLocation);
        private GroupPointOrderLocPrototype _GroupPointOrderLoc = WarcraftIII.Jass.GetNative("GroupPointOrderLoc").ToDelegate<GroupPointOrderLocPrototype>();
        public Boolean GroupPointOrderLoc(JassGroup whichGroup, String order, JassLocation whichLocation)
        {
            return _GroupPointOrderLoc(whichGroup, order, whichLocation);
        }

        //native GroupPointOrderById takes group whichGroup, integer order, real x, real y returns boolean
        private delegate JassBoolean GroupPointOrderByIdPrototype(JassGroup whichGroup, JassOrder order, JassRealArg x, JassRealArg y);
        private GroupPointOrderByIdPrototype _GroupPointOrderById = WarcraftIII.Jass.GetNative("GroupPointOrderById").ToDelegate<GroupPointOrderByIdPrototype>();
        public Boolean GroupPointOrderById(JassGroup whichGroup, JassOrder order, Single x, Single y)
        {
            return _GroupPointOrderById(whichGroup, order, x, y);
        }

        //native GroupPointOrderByIdLoc takes group whichGroup, integer order, location whichLocation returns boolean
        private delegate JassBoolean GroupPointOrderByIdLocPrototype(JassGroup whichGroup, JassOrder order, JassLocation whichLocation);
        private GroupPointOrderByIdLocPrototype _GroupPointOrderByIdLoc = WarcraftIII.Jass.GetNative("GroupPointOrderByIdLoc").ToDelegate<GroupPointOrderByIdLocPrototype>();
        public Boolean GroupPointOrderByIdLoc(JassGroup whichGroup, JassOrder order, JassLocation whichLocation)
        {
            return _GroupPointOrderByIdLoc(whichGroup, order, whichLocation);
        }

        //native GroupTargetOrder takes group whichGroup, string order, widget targetWidget returns boolean
        private delegate JassBoolean GroupTargetOrderPrototype(JassGroup whichGroup, JassStringArg order, JassWidget targetWidget);
        private GroupTargetOrderPrototype _GroupTargetOrder = WarcraftIII.Jass.GetNative("GroupTargetOrder").ToDelegate<GroupTargetOrderPrototype>();
        public Boolean GroupTargetOrder(JassGroup whichGroup, String order, JassWidget targetWidget)
        {
            return _GroupTargetOrder(whichGroup, order, targetWidget);
        }

        //native GroupTargetOrderById takes group whichGroup, integer order, widget targetWidget returns boolean
        private delegate JassBoolean GroupTargetOrderByIdPrototype(JassGroup whichGroup, JassOrder order, JassWidget targetWidget);
        private GroupTargetOrderByIdPrototype _GroupTargetOrderById = WarcraftIII.Jass.GetNative("GroupTargetOrderById").ToDelegate<GroupTargetOrderByIdPrototype>();
        public Boolean GroupTargetOrderById(JassGroup whichGroup, JassOrder order, JassWidget targetWidget)
        {
            return _GroupTargetOrderById(whichGroup, order, targetWidget);
        }

        //native ForGroup takes group whichGroup, code callback returns nothing
        private delegate void ForGroupPrototype(JassGroup whichGroup, JassCode callback);
        private ForGroupPrototype _ForGroup = WarcraftIII.Jass.GetNative("ForGroup").ToDelegate<ForGroupPrototype>();
        public void ForGroup(JassGroup whichGroup, JassCode callback)
        {
            _ForGroup(whichGroup, callback);
        }

        //native FirstOfGroup takes group whichGroup returns unit
        private delegate JassUnit FirstOfGroupPrototype(JassGroup whichGroup);
        private FirstOfGroupPrototype _FirstOfGroup = WarcraftIII.Jass.GetNative("FirstOfGroup").ToDelegate<FirstOfGroupPrototype>();
        public JassUnit FirstOfGroup(JassGroup whichGroup)
        {
            return _FirstOfGroup(whichGroup);
        }

        //native CreateForce takes nothing returns force
        private delegate JassForce CreateForcePrototype();
        private CreateForcePrototype _CreateForce = WarcraftIII.Jass.GetNative("CreateForce").ToDelegate<CreateForcePrototype>();
        public JassForce CreateForce()
        {
            return _CreateForce();
        }

        //native DestroyForce takes force whichForce returns nothing
        private delegate void DestroyForcePrototype(JassForce whichForce);
        private DestroyForcePrototype _DestroyForce = WarcraftIII.Jass.GetNative("DestroyForce").ToDelegate<DestroyForcePrototype>();
        public void DestroyForce(JassForce whichForce)
        {
            _DestroyForce(whichForce);
        }

        //native ForceAddPlayer takes force whichForce, player whichPlayer returns nothing
        private delegate void ForceAddPlayerPrototype(JassForce whichForce, JassPlayer whichPlayer);
        private ForceAddPlayerPrototype _ForceAddPlayer = WarcraftIII.Jass.GetNative("ForceAddPlayer").ToDelegate<ForceAddPlayerPrototype>();
        public void ForceAddPlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            _ForceAddPlayer(whichForce, whichPlayer);
        }

        //native ForceRemovePlayer takes force whichForce, player whichPlayer returns nothing
        private delegate void ForceRemovePlayerPrototype(JassForce whichForce, JassPlayer whichPlayer);
        private ForceRemovePlayerPrototype _ForceRemovePlayer = WarcraftIII.Jass.GetNative("ForceRemovePlayer").ToDelegate<ForceRemovePlayerPrototype>();
        public void ForceRemovePlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            _ForceRemovePlayer(whichForce, whichPlayer);
        }

        //native ForceClear takes force whichForce returns nothing
        private delegate void ForceClearPrototype(JassForce whichForce);
        private ForceClearPrototype _ForceClear = WarcraftIII.Jass.GetNative("ForceClear").ToDelegate<ForceClearPrototype>();
        public void ForceClear(JassForce whichForce)
        {
            _ForceClear(whichForce);
        }

        //native ForceEnumPlayers takes force whichForce, boolexpr filter returns nothing
        private delegate void ForceEnumPlayersPrototype(JassForce whichForce, JassBooleanExpression filter);
        private ForceEnumPlayersPrototype _ForceEnumPlayers = WarcraftIII.Jass.GetNative("ForceEnumPlayers").ToDelegate<ForceEnumPlayersPrototype>();
        public void ForceEnumPlayers(JassForce whichForce, JassBooleanExpression filter)
        {
            _ForceEnumPlayers(whichForce, filter);
        }

        //native ForceEnumPlayersCounted takes force whichForce, boolexpr filter, integer countLimit returns nothing
        private delegate void ForceEnumPlayersCountedPrototype(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit);
        private ForceEnumPlayersCountedPrototype _ForceEnumPlayersCounted = WarcraftIII.Jass.GetNative("ForceEnumPlayersCounted").ToDelegate<ForceEnumPlayersCountedPrototype>();
        public void ForceEnumPlayersCounted(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit)
        {
            _ForceEnumPlayersCounted(whichForce, filter, countLimit);
        }

        //native ForceEnumAllies takes force whichForce, player whichPlayer, boolexpr filter returns nothing
        private delegate void ForceEnumAlliesPrototype(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter);
        private ForceEnumAlliesPrototype _ForceEnumAllies = WarcraftIII.Jass.GetNative("ForceEnumAllies").ToDelegate<ForceEnumAlliesPrototype>();
        public void ForceEnumAllies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            _ForceEnumAllies(whichForce, whichPlayer, filter);
        }

        //native ForceEnumEnemies takes force whichForce, player whichPlayer, boolexpr filter returns nothing
        private delegate void ForceEnumEnemiesPrototype(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter);
        private ForceEnumEnemiesPrototype _ForceEnumEnemies = WarcraftIII.Jass.GetNative("ForceEnumEnemies").ToDelegate<ForceEnumEnemiesPrototype>();
        public void ForceEnumEnemies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            _ForceEnumEnemies(whichForce, whichPlayer, filter);
        }

        //native ForForce takes force whichForce, code callback returns nothing
        private delegate void ForForcePrototype(JassForce whichForce, JassCode callback);
        private ForForcePrototype _ForForce = WarcraftIII.Jass.GetNative("ForForce").ToDelegate<ForForcePrototype>();
        public void ForForce(JassForce whichForce, JassCode callback)
        {
            _ForForce(whichForce, callback);
        }

        //native Rect takes real minx, real miny, real maxx, real maxy returns rect
        private delegate JassRect RectPrototype(JassRealArg minx, JassRealArg miny, JassRealArg maxx, JassRealArg maxy);
        private RectPrototype _Rect = WarcraftIII.Jass.GetNative("Rect").ToDelegate<RectPrototype>();
        public JassRect Rect(Single minx, Single miny, Single maxx, Single maxy)
        {
            return _Rect(minx, miny, maxx, maxy);
        }

        //native RectFromLoc takes location min, location max returns rect
        private delegate JassRect RectFromLocPrototype(JassLocation min, JassLocation max);
        private RectFromLocPrototype _RectFromLoc = WarcraftIII.Jass.GetNative("RectFromLoc").ToDelegate<RectFromLocPrototype>();
        public JassRect RectFromLoc(JassLocation min, JassLocation max)
        {
            return _RectFromLoc(min, max);
        }

        //native RemoveRect takes rect whichRect returns nothing
        private delegate void RemoveRectPrototype(JassRect whichRect);
        private RemoveRectPrototype _RemoveRect = WarcraftIII.Jass.GetNative("RemoveRect").ToDelegate<RemoveRectPrototype>();
        public void RemoveRect(JassRect whichRect)
        {
            _RemoveRect(whichRect);
        }

        //native SetRect takes rect whichRect, real minx, real miny, real maxx, real maxy returns nothing
        private delegate void SetRectPrototype(JassRect whichRect, JassRealArg minx, JassRealArg miny, JassRealArg maxx, JassRealArg maxy);
        private SetRectPrototype _SetRect = WarcraftIII.Jass.GetNative("SetRect").ToDelegate<SetRectPrototype>();
        public void SetRect(JassRect whichRect, Single minx, Single miny, Single maxx, Single maxy)
        {
            _SetRect(whichRect, minx, miny, maxx, maxy);
        }

        //native SetRectFromLoc takes rect whichRect, location min, location max returns nothing
        private delegate void SetRectFromLocPrototype(JassRect whichRect, JassLocation min, JassLocation max);
        private SetRectFromLocPrototype _SetRectFromLoc = WarcraftIII.Jass.GetNative("SetRectFromLoc").ToDelegate<SetRectFromLocPrototype>();
        public void SetRectFromLoc(JassRect whichRect, JassLocation min, JassLocation max)
        {
            _SetRectFromLoc(whichRect, min, max);
        }

        //native MoveRectTo takes rect whichRect, real newCenterX, real newCenterY returns nothing
        private delegate void MoveRectToPrototype(JassRect whichRect, JassRealArg newCenterX, JassRealArg newCenterY);
        private MoveRectToPrototype _MoveRectTo = WarcraftIII.Jass.GetNative("MoveRectTo").ToDelegate<MoveRectToPrototype>();
        public void MoveRectTo(JassRect whichRect, Single newCenterX, Single newCenterY)
        {
            _MoveRectTo(whichRect, newCenterX, newCenterY);
        }

        //native MoveRectToLoc takes rect whichRect, location newCenterLoc returns nothing
        private delegate void MoveRectToLocPrototype(JassRect whichRect, JassLocation newCenterLoc);
        private MoveRectToLocPrototype _MoveRectToLoc = WarcraftIII.Jass.GetNative("MoveRectToLoc").ToDelegate<MoveRectToLocPrototype>();
        public void MoveRectToLoc(JassRect whichRect, JassLocation newCenterLoc)
        {
            _MoveRectToLoc(whichRect, newCenterLoc);
        }

        //native GetRectCenterX takes rect whichRect returns real
        private delegate JassRealRet GetRectCenterXPrototype(JassRect whichRect);
        private GetRectCenterXPrototype _GetRectCenterX = WarcraftIII.Jass.GetNative("GetRectCenterX").ToDelegate<GetRectCenterXPrototype>();
        public Single GetRectCenterX(JassRect whichRect)
        {
            return _GetRectCenterX(whichRect);
        }

        //native GetRectCenterY takes rect whichRect returns real
        private delegate JassRealRet GetRectCenterYPrototype(JassRect whichRect);
        private GetRectCenterYPrototype _GetRectCenterY = WarcraftIII.Jass.GetNative("GetRectCenterY").ToDelegate<GetRectCenterYPrototype>();
        public Single GetRectCenterY(JassRect whichRect)
        {
            return _GetRectCenterY(whichRect);
        }

        //native GetRectMinX takes rect whichRect returns real
        private delegate JassRealRet GetRectMinXPrototype(JassRect whichRect);
        private GetRectMinXPrototype _GetRectMinX = WarcraftIII.Jass.GetNative("GetRectMinX").ToDelegate<GetRectMinXPrototype>();
        public Single GetRectMinX(JassRect whichRect)
        {
            return _GetRectMinX(whichRect);
        }

        //native GetRectMinY takes rect whichRect returns real
        private delegate JassRealRet GetRectMinYPrototype(JassRect whichRect);
        private GetRectMinYPrototype _GetRectMinY = WarcraftIII.Jass.GetNative("GetRectMinY").ToDelegate<GetRectMinYPrototype>();
        public Single GetRectMinY(JassRect whichRect)
        {
            return _GetRectMinY(whichRect);
        }

        //native GetRectMaxX takes rect whichRect returns real
        private delegate JassRealRet GetRectMaxXPrototype(JassRect whichRect);
        private GetRectMaxXPrototype _GetRectMaxX = WarcraftIII.Jass.GetNative("GetRectMaxX").ToDelegate<GetRectMaxXPrototype>();
        public Single GetRectMaxX(JassRect whichRect)
        {
            return _GetRectMaxX(whichRect);
        }

        //native GetRectMaxY takes rect whichRect returns real
        private delegate JassRealRet GetRectMaxYPrototype(JassRect whichRect);
        private GetRectMaxYPrototype _GetRectMaxY = WarcraftIII.Jass.GetNative("GetRectMaxY").ToDelegate<GetRectMaxYPrototype>();
        public Single GetRectMaxY(JassRect whichRect)
        {
            return _GetRectMaxY(whichRect);
        }

        //native CreateRegion takes nothing returns region
        private delegate JassRegion CreateRegionPrototype();
        private CreateRegionPrototype _CreateRegion = WarcraftIII.Jass.GetNative("CreateRegion").ToDelegate<CreateRegionPrototype>();
        public JassRegion CreateRegion()
        {
            return _CreateRegion();
        }

        //native RemoveRegion takes region whichRegion returns nothing
        private delegate void RemoveRegionPrototype(JassRegion whichRegion);
        private RemoveRegionPrototype _RemoveRegion = WarcraftIII.Jass.GetNative("RemoveRegion").ToDelegate<RemoveRegionPrototype>();
        public void RemoveRegion(JassRegion whichRegion)
        {
            _RemoveRegion(whichRegion);
        }

        //native RegionAddRect takes region whichRegion, rect r returns nothing
        private delegate void RegionAddRectPrototype(JassRegion whichRegion, JassRect r);
        private RegionAddRectPrototype _RegionAddRect = WarcraftIII.Jass.GetNative("RegionAddRect").ToDelegate<RegionAddRectPrototype>();
        public void RegionAddRect(JassRegion whichRegion, JassRect r)
        {
            _RegionAddRect(whichRegion, r);
        }

        //native RegionClearRect takes region whichRegion, rect r returns nothing
        private delegate void RegionClearRectPrototype(JassRegion whichRegion, JassRect r);
        private RegionClearRectPrototype _RegionClearRect = WarcraftIII.Jass.GetNative("RegionClearRect").ToDelegate<RegionClearRectPrototype>();
        public void RegionClearRect(JassRegion whichRegion, JassRect r)
        {
            _RegionClearRect(whichRegion, r);
        }

        //native RegionAddCell takes region whichRegion, real x, real y returns nothing
        private delegate void RegionAddCellPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private RegionAddCellPrototype _RegionAddCell = WarcraftIII.Jass.GetNative("RegionAddCell").ToDelegate<RegionAddCellPrototype>();
        public void RegionAddCell(JassRegion whichRegion, Single x, Single y)
        {
            _RegionAddCell(whichRegion, x, y);
        }

        //native RegionAddCellAtLoc takes region whichRegion, location whichLocation returns nothing
        private delegate void RegionAddCellAtLocPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private RegionAddCellAtLocPrototype _RegionAddCellAtLoc = WarcraftIII.Jass.GetNative("RegionAddCellAtLoc").ToDelegate<RegionAddCellAtLocPrototype>();
        public void RegionAddCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            _RegionAddCellAtLoc(whichRegion, whichLocation);
        }

        //native RegionClearCell takes region whichRegion, real x, real y returns nothing
        private delegate void RegionClearCellPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private RegionClearCellPrototype _RegionClearCell = WarcraftIII.Jass.GetNative("RegionClearCell").ToDelegate<RegionClearCellPrototype>();
        public void RegionClearCell(JassRegion whichRegion, Single x, Single y)
        {
            _RegionClearCell(whichRegion, x, y);
        }

        //native RegionClearCellAtLoc takes region whichRegion, location whichLocation returns nothing
        private delegate void RegionClearCellAtLocPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private RegionClearCellAtLocPrototype _RegionClearCellAtLoc = WarcraftIII.Jass.GetNative("RegionClearCellAtLoc").ToDelegate<RegionClearCellAtLocPrototype>();
        public void RegionClearCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            _RegionClearCellAtLoc(whichRegion, whichLocation);
        }

        //native Location takes real x, real y returns location
        private delegate JassLocation LocationPrototype(JassRealArg x, JassRealArg y);
        private LocationPrototype _Location = WarcraftIII.Jass.GetNative("Location").ToDelegate<LocationPrototype>();
        public JassLocation Location(Single x, Single y)
        {
            return _Location(x, y);
        }

        //native RemoveLocation takes location whichLocation returns nothing
        private delegate void RemoveLocationPrototype(JassLocation whichLocation);
        private RemoveLocationPrototype _RemoveLocation = WarcraftIII.Jass.GetNative("RemoveLocation").ToDelegate<RemoveLocationPrototype>();
        public void RemoveLocation(JassLocation whichLocation)
        {
            _RemoveLocation(whichLocation);
        }

        //native MoveLocation takes location whichLocation, real newX, real newY returns nothing
        private delegate void MoveLocationPrototype(JassLocation whichLocation, JassRealArg newX, JassRealArg newY);
        private MoveLocationPrototype _MoveLocation = WarcraftIII.Jass.GetNative("MoveLocation").ToDelegate<MoveLocationPrototype>();
        public void MoveLocation(JassLocation whichLocation, Single newX, Single newY)
        {
            _MoveLocation(whichLocation, newX, newY);
        }

        //native GetLocationX takes location whichLocation returns real
        private delegate JassRealRet GetLocationXPrototype(JassLocation whichLocation);
        private GetLocationXPrototype _GetLocationX = WarcraftIII.Jass.GetNative("GetLocationX").ToDelegate<GetLocationXPrototype>();
        public Single GetLocationX(JassLocation whichLocation)
        {
            return _GetLocationX(whichLocation);
        }

        //native GetLocationY takes location whichLocation returns real
        private delegate JassRealRet GetLocationYPrototype(JassLocation whichLocation);
        private GetLocationYPrototype _GetLocationY = WarcraftIII.Jass.GetNative("GetLocationY").ToDelegate<GetLocationYPrototype>();
        public Single GetLocationY(JassLocation whichLocation)
        {
            return _GetLocationY(whichLocation);
        }

        //native GetLocationZ takes location whichLocation returns real
        private delegate JassRealRet GetLocationZPrototype(JassLocation whichLocation);
        private GetLocationZPrototype _GetLocationZ = WarcraftIII.Jass.GetNative("GetLocationZ").ToDelegate<GetLocationZPrototype>();
        public Single GetLocationZ(JassLocation whichLocation)
        {
            return _GetLocationZ(whichLocation);
        }

        //native IsUnitInRegion takes region whichRegion, unit whichUnit returns boolean
        private delegate JassBoolean IsUnitInRegionPrototype(JassRegion whichRegion, JassUnit whichUnit);
        private IsUnitInRegionPrototype _IsUnitInRegion = WarcraftIII.Jass.GetNative("IsUnitInRegion").ToDelegate<IsUnitInRegionPrototype>();
        public Boolean IsUnitInRegion(JassRegion whichRegion, JassUnit whichUnit)
        {
            return _IsUnitInRegion(whichRegion, whichUnit);
        }

        //native IsPointInRegion takes region whichRegion, real x, real y returns boolean
        private delegate JassBoolean IsPointInRegionPrototype(JassRegion whichRegion, JassRealArg x, JassRealArg y);
        private IsPointInRegionPrototype _IsPointInRegion = WarcraftIII.Jass.GetNative("IsPointInRegion").ToDelegate<IsPointInRegionPrototype>();
        public Boolean IsPointInRegion(JassRegion whichRegion, Single x, Single y)
        {
            return _IsPointInRegion(whichRegion, x, y);
        }

        //native IsLocationInRegion takes region whichRegion, location whichLocation returns boolean
        private delegate JassBoolean IsLocationInRegionPrototype(JassRegion whichRegion, JassLocation whichLocation);
        private IsLocationInRegionPrototype _IsLocationInRegion = WarcraftIII.Jass.GetNative("IsLocationInRegion").ToDelegate<IsLocationInRegionPrototype>();
        public Boolean IsLocationInRegion(JassRegion whichRegion, JassLocation whichLocation)
        {
            return _IsLocationInRegion(whichRegion, whichLocation);
        }

        //native GetWorldBounds takes nothing returns rect
        private delegate JassRect GetWorldBoundsPrototype();
        private GetWorldBoundsPrototype _GetWorldBounds = WarcraftIII.Jass.GetNative("GetWorldBounds").ToDelegate<GetWorldBoundsPrototype>();
        public JassRect GetWorldBounds()
        {
            return _GetWorldBounds();
        }

        //native CreateTrigger takes nothing returns trigger
        private delegate JassTrigger CreateTriggerPrototype();
        private CreateTriggerPrototype _CreateTrigger = WarcraftIII.Jass.GetNative("CreateTrigger").ToDelegate<CreateTriggerPrototype>();
        public JassTrigger CreateTrigger()
        {
            return _CreateTrigger();
        }

        //native DestroyTrigger takes trigger whichTrigger returns nothing
        private delegate void DestroyTriggerPrototype(JassTrigger whichTrigger);
        private DestroyTriggerPrototype _DestroyTrigger = WarcraftIII.Jass.GetNative("DestroyTrigger").ToDelegate<DestroyTriggerPrototype>();
        public void DestroyTrigger(JassTrigger whichTrigger)
        {
            _DestroyTrigger(whichTrigger);
        }

        //native ResetTrigger takes trigger whichTrigger returns nothing
        private delegate void ResetTriggerPrototype(JassTrigger whichTrigger);
        private ResetTriggerPrototype _ResetTrigger = WarcraftIII.Jass.GetNative("ResetTrigger").ToDelegate<ResetTriggerPrototype>();
        public void ResetTrigger(JassTrigger whichTrigger)
        {
            _ResetTrigger(whichTrigger);
        }

        //native EnableTrigger takes trigger whichTrigger returns nothing
        private delegate void EnableTriggerPrototype(JassTrigger whichTrigger);
        private EnableTriggerPrototype _EnableTrigger = WarcraftIII.Jass.GetNative("EnableTrigger").ToDelegate<EnableTriggerPrototype>();
        public void EnableTrigger(JassTrigger whichTrigger)
        {
            _EnableTrigger(whichTrigger);
        }

        //native DisableTrigger takes trigger whichTrigger returns nothing
        private delegate void DisableTriggerPrototype(JassTrigger whichTrigger);
        private DisableTriggerPrototype _DisableTrigger = WarcraftIII.Jass.GetNative("DisableTrigger").ToDelegate<DisableTriggerPrototype>();
        public void DisableTrigger(JassTrigger whichTrigger)
        {
            _DisableTrigger(whichTrigger);
        }

        //native IsTriggerEnabled takes trigger whichTrigger returns boolean
        private delegate JassBoolean IsTriggerEnabledPrototype(JassTrigger whichTrigger);
        private IsTriggerEnabledPrototype _IsTriggerEnabled = WarcraftIII.Jass.GetNative("IsTriggerEnabled").ToDelegate<IsTriggerEnabledPrototype>();
        public Boolean IsTriggerEnabled(JassTrigger whichTrigger)
        {
            return _IsTriggerEnabled(whichTrigger);
        }

        //native TriggerWaitOnSleeps takes trigger whichTrigger, boolean flag returns nothing
        private delegate void TriggerWaitOnSleepsPrototype(JassTrigger whichTrigger, JassBoolean flag);
        private TriggerWaitOnSleepsPrototype _TriggerWaitOnSleeps = WarcraftIII.Jass.GetNative("TriggerWaitOnSleeps").ToDelegate<TriggerWaitOnSleepsPrototype>();
        public void TriggerWaitOnSleeps(JassTrigger whichTrigger, Boolean flag)
        {
            _TriggerWaitOnSleeps(whichTrigger, flag);
        }

        //native IsTriggerWaitOnSleeps takes trigger whichTrigger returns boolean
        private delegate JassBoolean IsTriggerWaitOnSleepsPrototype(JassTrigger whichTrigger);
        private IsTriggerWaitOnSleepsPrototype _IsTriggerWaitOnSleeps = WarcraftIII.Jass.GetNative("IsTriggerWaitOnSleeps").ToDelegate<IsTriggerWaitOnSleepsPrototype>();
        public Boolean IsTriggerWaitOnSleeps(JassTrigger whichTrigger)
        {
            return _IsTriggerWaitOnSleeps(whichTrigger);
        }

        //native GetFilterUnit takes nothing returns unit
        private delegate JassUnit GetFilterUnitPrototype();
        private GetFilterUnitPrototype _GetFilterUnit = WarcraftIII.Jass.GetNative("GetFilterUnit").ToDelegate<GetFilterUnitPrototype>();
        public JassUnit GetFilterUnit()
        {
            return _GetFilterUnit();
        }

        //native GetEnumUnit takes nothing returns unit
        private delegate JassUnit GetEnumUnitPrototype();
        private GetEnumUnitPrototype _GetEnumUnit = WarcraftIII.Jass.GetNative("GetEnumUnit").ToDelegate<GetEnumUnitPrototype>();
        public JassUnit GetEnumUnit()
        {
            return _GetEnumUnit();
        }

        //native GetFilterDestructable takes nothing returns destructable
        private delegate JassDestructable GetFilterDestructablePrototype();
        private GetFilterDestructablePrototype _GetFilterDestructable = WarcraftIII.Jass.GetNative("GetFilterDestructable").ToDelegate<GetFilterDestructablePrototype>();
        public JassDestructable GetFilterDestructable()
        {
            return _GetFilterDestructable();
        }

        //native GetEnumDestructable takes nothing returns destructable
        private delegate JassDestructable GetEnumDestructablePrototype();
        private GetEnumDestructablePrototype _GetEnumDestructable = WarcraftIII.Jass.GetNative("GetEnumDestructable").ToDelegate<GetEnumDestructablePrototype>();
        public JassDestructable GetEnumDestructable()
        {
            return _GetEnumDestructable();
        }

        //native GetFilterItem takes nothing returns item
        private delegate JassItem GetFilterItemPrototype();
        private GetFilterItemPrototype _GetFilterItem = WarcraftIII.Jass.GetNative("GetFilterItem").ToDelegate<GetFilterItemPrototype>();
        public JassItem GetFilterItem()
        {
            return _GetFilterItem();
        }

        //native GetEnumItem takes nothing returns item
        private delegate JassItem GetEnumItemPrototype();
        private GetEnumItemPrototype _GetEnumItem = WarcraftIII.Jass.GetNative("GetEnumItem").ToDelegate<GetEnumItemPrototype>();
        public JassItem GetEnumItem()
        {
            return _GetEnumItem();
        }

        //native GetFilterPlayer takes nothing returns player
        private delegate JassPlayer GetFilterPlayerPrototype();
        private GetFilterPlayerPrototype _GetFilterPlayer = WarcraftIII.Jass.GetNative("GetFilterPlayer").ToDelegate<GetFilterPlayerPrototype>();
        public JassPlayer GetFilterPlayer()
        {
            return _GetFilterPlayer();
        }

        //native GetEnumPlayer takes nothing returns player
        private delegate JassPlayer GetEnumPlayerPrototype();
        private GetEnumPlayerPrototype _GetEnumPlayer = WarcraftIII.Jass.GetNative("GetEnumPlayer").ToDelegate<GetEnumPlayerPrototype>();
        public JassPlayer GetEnumPlayer()
        {
            return _GetEnumPlayer();
        }

        //native GetTriggeringTrigger takes nothing returns trigger
        private delegate JassTrigger GetTriggeringTriggerPrototype();
        private GetTriggeringTriggerPrototype _GetTriggeringTrigger = WarcraftIII.Jass.GetNative("GetTriggeringTrigger").ToDelegate<GetTriggeringTriggerPrototype>();
        public JassTrigger GetTriggeringTrigger()
        {
            return _GetTriggeringTrigger();
        }

        //native GetTriggerEventId takes nothing returns eventid
        private delegate JassEventIndex GetTriggerEventIdPrototype();
        private GetTriggerEventIdPrototype _GetTriggerEventId = WarcraftIII.Jass.GetNative("GetTriggerEventId").ToDelegate<GetTriggerEventIdPrototype>();
        public JassEventIndex GetTriggerEventId()
        {
            return _GetTriggerEventId();
        }

        //native GetTriggerEvalCount takes trigger whichTrigger returns integer
        private delegate JassInteger GetTriggerEvalCountPrototype(JassTrigger whichTrigger);
        private GetTriggerEvalCountPrototype _GetTriggerEvalCount = WarcraftIII.Jass.GetNative("GetTriggerEvalCount").ToDelegate<GetTriggerEvalCountPrototype>();
        public JassInteger GetTriggerEvalCount(JassTrigger whichTrigger)
        {
            return _GetTriggerEvalCount(whichTrigger);
        }

        //native GetTriggerExecCount takes trigger whichTrigger returns integer
        private delegate JassInteger GetTriggerExecCountPrototype(JassTrigger whichTrigger);
        private GetTriggerExecCountPrototype _GetTriggerExecCount = WarcraftIII.Jass.GetNative("GetTriggerExecCount").ToDelegate<GetTriggerExecCountPrototype>();
        public JassInteger GetTriggerExecCount(JassTrigger whichTrigger)
        {
            return _GetTriggerExecCount(whichTrigger);
        }

        //native ExecuteFunc takes string funcName returns nothing
        private delegate void ExecuteFuncPrototype(JassStringArg funcName);
        private ExecuteFuncPrototype _ExecuteFunc = WarcraftIII.Jass.GetNative("ExecuteFunc").ToDelegate<ExecuteFuncPrototype>();
        public void ExecuteFunc(String funcName)
        {
            _ExecuteFunc(funcName);
        }

        //native And takes boolexpr operandA, boolexpr operandB returns boolexpr
        private delegate JassBooleanExpression AndPrototype(JassBooleanExpression operandA, JassBooleanExpression operandB);
        private AndPrototype _And = WarcraftIII.Jass.GetNative("And").ToDelegate<AndPrototype>();
        public JassBooleanExpression And(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return _And(operandA, operandB);
        }

        //native Or takes boolexpr operandA, boolexpr operandB returns boolexpr
        private delegate JassBooleanExpression OrPrototype(JassBooleanExpression operandA, JassBooleanExpression operandB);
        private OrPrototype _Or = WarcraftIII.Jass.GetNative("Or").ToDelegate<OrPrototype>();
        public JassBooleanExpression Or(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return _Or(operandA, operandB);
        }

        //native Not takes boolexpr operand returns boolexpr
        private delegate JassBooleanExpression NotPrototype(JassBooleanExpression operand);
        private NotPrototype _Not = WarcraftIII.Jass.GetNative("Not").ToDelegate<NotPrototype>();
        public JassBooleanExpression Not(JassBooleanExpression operand)
        {
            return _Not(operand);
        }

        //native Condition takes code func returns conditionfunc
        private delegate JassConditionFunction ConditionPrototype(JassCode func);
        private ConditionPrototype _Condition = WarcraftIII.Jass.GetNative("Condition").ToDelegate<ConditionPrototype>();
        public JassConditionFunction Condition(JassCode func)
        {
            return _Condition(func);
        }

        //native DestroyCondition takes conditionfunc c returns nothing
        private delegate void DestroyConditionPrototype(JassConditionFunction c);
        private DestroyConditionPrototype _DestroyCondition = WarcraftIII.Jass.GetNative("DestroyCondition").ToDelegate<DestroyConditionPrototype>();
        public void DestroyCondition(JassConditionFunction c)
        {
            _DestroyCondition(c);
        }

        //native Filter takes code func returns filterfunc
        private delegate JassFilterFunction FilterPrototype(JassCode func);
        private FilterPrototype _Filter = WarcraftIII.Jass.GetNative("Filter").ToDelegate<FilterPrototype>();
        public JassFilterFunction Filter(JassCode func)
        {
            return _Filter(func);
        }

        //native DestroyFilter takes filterfunc f returns nothing
        private delegate void DestroyFilterPrototype(JassFilterFunction f);
        private DestroyFilterPrototype _DestroyFilter = WarcraftIII.Jass.GetNative("DestroyFilter").ToDelegate<DestroyFilterPrototype>();
        public void DestroyFilter(JassFilterFunction f)
        {
            _DestroyFilter(f);
        }

        //native DestroyBoolExpr takes boolexpr e returns nothing
        private delegate void DestroyBoolExprPrototype(JassBooleanExpression e);
        private DestroyBoolExprPrototype _DestroyBoolExpr = WarcraftIII.Jass.GetNative("DestroyBoolExpr").ToDelegate<DestroyBoolExprPrototype>();
        public void DestroyBoolExpr(JassBooleanExpression e)
        {
            _DestroyBoolExpr(e);
        }

        //native TriggerRegisterVariableEvent takes trigger whichTrigger, string varName, limitop opcode, real limitval returns event
        private delegate JassEvent TriggerRegisterVariableEventPrototype(JassTrigger whichTrigger, JassStringArg varName, JassLimitOp opcode, JassRealArg limitval);
        private TriggerRegisterVariableEventPrototype _TriggerRegisterVariableEvent = WarcraftIII.Jass.GetNative("TriggerRegisterVariableEvent").ToDelegate<TriggerRegisterVariableEventPrototype>();
        public JassEvent TriggerRegisterVariableEvent(JassTrigger whichTrigger, String varName, JassLimitOp opcode, Single limitval)
        {
            return _TriggerRegisterVariableEvent(whichTrigger, varName, opcode, limitval);
        }

        //native TriggerRegisterTimerEvent takes trigger whichTrigger, real timeout, boolean periodic returns event
        private delegate JassEvent TriggerRegisterTimerEventPrototype(JassTrigger whichTrigger, JassRealArg timeout, JassBoolean periodic);
        private TriggerRegisterTimerEventPrototype _TriggerRegisterTimerEvent = WarcraftIII.Jass.GetNative("TriggerRegisterTimerEvent").ToDelegate<TriggerRegisterTimerEventPrototype>();
        public JassEvent TriggerRegisterTimerEvent(JassTrigger whichTrigger, Single timeout, Boolean periodic)
        {
            return _TriggerRegisterTimerEvent(whichTrigger, timeout, periodic);
        }

        //native TriggerRegisterTimerExpireEvent takes trigger whichTrigger, timer t returns event
        private delegate JassEvent TriggerRegisterTimerExpireEventPrototype(JassTrigger whichTrigger, JassTimer t);
        private TriggerRegisterTimerExpireEventPrototype _TriggerRegisterTimerExpireEvent = WarcraftIII.Jass.GetNative("TriggerRegisterTimerExpireEvent").ToDelegate<TriggerRegisterTimerExpireEventPrototype>();
        public JassEvent TriggerRegisterTimerExpireEvent(JassTrigger whichTrigger, JassTimer t)
        {
            return _TriggerRegisterTimerExpireEvent(whichTrigger, t);
        }

        //native TriggerRegisterGameStateEvent takes trigger whichTrigger, gamestate whichState, limitop opcode, real limitval returns event
        private delegate JassEvent TriggerRegisterGameStateEventPrototype(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, JassRealArg limitval);
        private TriggerRegisterGameStateEventPrototype _TriggerRegisterGameStateEvent = WarcraftIII.Jass.GetNative("TriggerRegisterGameStateEvent").ToDelegate<TriggerRegisterGameStateEventPrototype>();
        public JassEvent TriggerRegisterGameStateEvent(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, Single limitval)
        {
            return _TriggerRegisterGameStateEvent(whichTrigger, whichState, opcode, limitval);
        }

        //native TriggerRegisterDialogEvent takes trigger whichTrigger, dialog whichDialog returns event
        private delegate JassEvent TriggerRegisterDialogEventPrototype(JassTrigger whichTrigger, JassDialog whichDialog);
        private TriggerRegisterDialogEventPrototype _TriggerRegisterDialogEvent = WarcraftIII.Jass.GetNative("TriggerRegisterDialogEvent").ToDelegate<TriggerRegisterDialogEventPrototype>();
        public JassEvent TriggerRegisterDialogEvent(JassTrigger whichTrigger, JassDialog whichDialog)
        {
            return _TriggerRegisterDialogEvent(whichTrigger, whichDialog);
        }

        //native TriggerRegisterDialogButtonEvent takes trigger whichTrigger, button whichButton returns event
        private delegate JassEvent TriggerRegisterDialogButtonEventPrototype(JassTrigger whichTrigger, JassButton whichButton);
        private TriggerRegisterDialogButtonEventPrototype _TriggerRegisterDialogButtonEvent = WarcraftIII.Jass.GetNative("TriggerRegisterDialogButtonEvent").ToDelegate<TriggerRegisterDialogButtonEventPrototype>();
        public JassEvent TriggerRegisterDialogButtonEvent(JassTrigger whichTrigger, JassButton whichButton)
        {
            return _TriggerRegisterDialogButtonEvent(whichTrigger, whichButton);
        }

        //native GetEventGameState takes nothing returns gamestate
        private delegate JassGameState GetEventGameStatePrototype();
        private GetEventGameStatePrototype _GetEventGameState = WarcraftIII.Jass.GetNative("GetEventGameState").ToDelegate<GetEventGameStatePrototype>();
        public JassGameState GetEventGameState()
        {
            return _GetEventGameState();
        }

        //native TriggerRegisterGameEvent takes trigger whichTrigger, gameevent whichGameEvent returns event
        private delegate JassEvent TriggerRegisterGameEventPrototype(JassTrigger whichTrigger, JassGameEvent whichGameEvent);
        private TriggerRegisterGameEventPrototype _TriggerRegisterGameEvent = WarcraftIII.Jass.GetNative("TriggerRegisterGameEvent").ToDelegate<TriggerRegisterGameEventPrototype>();
        public JassEvent TriggerRegisterGameEvent(JassTrigger whichTrigger, JassGameEvent whichGameEvent)
        {
            return _TriggerRegisterGameEvent(whichTrigger, whichGameEvent);
        }

        //native GetWinningPlayer takes nothing returns player
        private delegate JassPlayer GetWinningPlayerPrototype();
        private GetWinningPlayerPrototype _GetWinningPlayer = WarcraftIII.Jass.GetNative("GetWinningPlayer").ToDelegate<GetWinningPlayerPrototype>();
        public JassPlayer GetWinningPlayer()
        {
            return _GetWinningPlayer();
        }

        //native TriggerRegisterEnterRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
        private delegate JassEvent TriggerRegisterEnterRegionPrototype(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter);
        private TriggerRegisterEnterRegionPrototype _TriggerRegisterEnterRegion = WarcraftIII.Jass.GetNative("TriggerRegisterEnterRegion").ToDelegate<TriggerRegisterEnterRegionPrototype>();
        public JassEvent TriggerRegisterEnterRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return _TriggerRegisterEnterRegion(whichTrigger, whichRegion, filter);
        }

        //native GetTriggeringRegion takes nothing returns region
        private delegate JassRegion GetTriggeringRegionPrototype();
        private GetTriggeringRegionPrototype _GetTriggeringRegion = WarcraftIII.Jass.GetNative("GetTriggeringRegion").ToDelegate<GetTriggeringRegionPrototype>();
        public JassRegion GetTriggeringRegion()
        {
            return _GetTriggeringRegion();
        }

        //native GetEnteringUnit takes nothing returns unit
        private delegate JassUnit GetEnteringUnitPrototype();
        private GetEnteringUnitPrototype _GetEnteringUnit = WarcraftIII.Jass.GetNative("GetEnteringUnit").ToDelegate<GetEnteringUnitPrototype>();
        public JassUnit GetEnteringUnit()
        {
            return _GetEnteringUnit();
        }

        //native TriggerRegisterLeaveRegion takes trigger whichTrigger, region whichRegion, boolexpr filter returns event
        private delegate JassEvent TriggerRegisterLeaveRegionPrototype(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter);
        private TriggerRegisterLeaveRegionPrototype _TriggerRegisterLeaveRegion = WarcraftIII.Jass.GetNative("TriggerRegisterLeaveRegion").ToDelegate<TriggerRegisterLeaveRegionPrototype>();
        public JassEvent TriggerRegisterLeaveRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return _TriggerRegisterLeaveRegion(whichTrigger, whichRegion, filter);
        }

        //native GetLeavingUnit takes nothing returns unit
        private delegate JassUnit GetLeavingUnitPrototype();
        private GetLeavingUnitPrototype _GetLeavingUnit = WarcraftIII.Jass.GetNative("GetLeavingUnit").ToDelegate<GetLeavingUnitPrototype>();
        public JassUnit GetLeavingUnit()
        {
            return _GetLeavingUnit();
        }

        //native TriggerRegisterTrackableHitEvent takes trigger whichTrigger, trackable t returns event
        private delegate JassEvent TriggerRegisterTrackableHitEventPrototype(JassTrigger whichTrigger, JassTrackable t);
        private TriggerRegisterTrackableHitEventPrototype _TriggerRegisterTrackableHitEvent = WarcraftIII.Jass.GetNative("TriggerRegisterTrackableHitEvent").ToDelegate<TriggerRegisterTrackableHitEventPrototype>();
        public JassEvent TriggerRegisterTrackableHitEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return _TriggerRegisterTrackableHitEvent(whichTrigger, t);
        }

        //native TriggerRegisterTrackableTrackEvent takes trigger whichTrigger, trackable t returns event
        private delegate JassEvent TriggerRegisterTrackableTrackEventPrototype(JassTrigger whichTrigger, JassTrackable t);
        private TriggerRegisterTrackableTrackEventPrototype _TriggerRegisterTrackableTrackEvent = WarcraftIII.Jass.GetNative("TriggerRegisterTrackableTrackEvent").ToDelegate<TriggerRegisterTrackableTrackEventPrototype>();
        public JassEvent TriggerRegisterTrackableTrackEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return _TriggerRegisterTrackableTrackEvent(whichTrigger, t);
        }

        //native GetTriggeringTrackable takes nothing returns trackable
        private delegate JassTrackable GetTriggeringTrackablePrototype();
        private GetTriggeringTrackablePrototype _GetTriggeringTrackable = WarcraftIII.Jass.GetNative("GetTriggeringTrackable").ToDelegate<GetTriggeringTrackablePrototype>();
        public JassTrackable GetTriggeringTrackable()
        {
            return _GetTriggeringTrackable();
        }

        //native GetClickedButton takes nothing returns button
        private delegate JassButton GetClickedButtonPrototype();
        private GetClickedButtonPrototype _GetClickedButton = WarcraftIII.Jass.GetNative("GetClickedButton").ToDelegate<GetClickedButtonPrototype>();
        public JassButton GetClickedButton()
        {
            return _GetClickedButton();
        }

        //native GetClickedDialog takes nothing returns dialog
        private delegate JassDialog GetClickedDialogPrototype();
        private GetClickedDialogPrototype _GetClickedDialog = WarcraftIII.Jass.GetNative("GetClickedDialog").ToDelegate<GetClickedDialogPrototype>();
        public JassDialog GetClickedDialog()
        {
            return _GetClickedDialog();
        }

        //native GetTournamentFinishSoonTimeRemaining takes nothing returns real
        private delegate JassRealRet GetTournamentFinishSoonTimeRemainingPrototype();
        private GetTournamentFinishSoonTimeRemainingPrototype _GetTournamentFinishSoonTimeRemaining = WarcraftIII.Jass.GetNative("GetTournamentFinishSoonTimeRemaining").ToDelegate<GetTournamentFinishSoonTimeRemainingPrototype>();
        public Single GetTournamentFinishSoonTimeRemaining()
        {
            return _GetTournamentFinishSoonTimeRemaining();
        }

        //native GetTournamentFinishNowRule takes nothing returns integer
        private delegate JassInteger GetTournamentFinishNowRulePrototype();
        private GetTournamentFinishNowRulePrototype _GetTournamentFinishNowRule = WarcraftIII.Jass.GetNative("GetTournamentFinishNowRule").ToDelegate<GetTournamentFinishNowRulePrototype>();
        public JassInteger GetTournamentFinishNowRule()
        {
            return _GetTournamentFinishNowRule();
        }

        //native GetTournamentFinishNowPlayer takes nothing returns player
        private delegate JassPlayer GetTournamentFinishNowPlayerPrototype();
        private GetTournamentFinishNowPlayerPrototype _GetTournamentFinishNowPlayer = WarcraftIII.Jass.GetNative("GetTournamentFinishNowPlayer").ToDelegate<GetTournamentFinishNowPlayerPrototype>();
        public JassPlayer GetTournamentFinishNowPlayer()
        {
            return _GetTournamentFinishNowPlayer();
        }

        //native GetTournamentScore takes player whichPlayer returns integer
        private delegate JassInteger GetTournamentScorePrototype(JassPlayer whichPlayer);
        private GetTournamentScorePrototype _GetTournamentScore = WarcraftIII.Jass.GetNative("GetTournamentScore").ToDelegate<GetTournamentScorePrototype>();
        public JassInteger GetTournamentScore(JassPlayer whichPlayer)
        {
            return _GetTournamentScore(whichPlayer);
        }

        //native GetSaveBasicFilename takes nothing returns string
        private delegate JassStringRet GetSaveBasicFilenamePrototype();
        private GetSaveBasicFilenamePrototype _GetSaveBasicFilename = WarcraftIII.Jass.GetNative("GetSaveBasicFilename").ToDelegate<GetSaveBasicFilenamePrototype>();
        public String GetSaveBasicFilename()
        {
            return _GetSaveBasicFilename();
        }

        //native TriggerRegisterPlayerEvent takes trigger whichTrigger, player whichPlayer, playerevent whichPlayerEvent returns event
        private delegate JassEvent TriggerRegisterPlayerEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent);
        private TriggerRegisterPlayerEventPrototype _TriggerRegisterPlayerEvent = WarcraftIII.Jass.GetNative("TriggerRegisterPlayerEvent").ToDelegate<TriggerRegisterPlayerEventPrototype>();
        public JassEvent TriggerRegisterPlayerEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent)
        {
            return _TriggerRegisterPlayerEvent(whichTrigger, whichPlayer, whichPlayerEvent);
        }

        //native GetTriggerPlayer takes nothing returns player
        private delegate JassPlayer GetTriggerPlayerPrototype();
        private GetTriggerPlayerPrototype _GetTriggerPlayer = WarcraftIII.Jass.GetNative("GetTriggerPlayer").ToDelegate<GetTriggerPlayerPrototype>();
        public JassPlayer GetTriggerPlayer()
        {
            return _GetTriggerPlayer();
        }

        //native TriggerRegisterPlayerUnitEvent takes trigger whichTrigger, player whichPlayer, playerunitevent whichPlayerUnitEvent, boolexpr filter returns event
        private delegate JassEvent TriggerRegisterPlayerUnitEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter);
        private TriggerRegisterPlayerUnitEventPrototype _TriggerRegisterPlayerUnitEvent = WarcraftIII.Jass.GetNative("TriggerRegisterPlayerUnitEvent").ToDelegate<TriggerRegisterPlayerUnitEventPrototype>();
        public JassEvent TriggerRegisterPlayerUnitEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter)
        {
            return _TriggerRegisterPlayerUnitEvent(whichTrigger, whichPlayer, whichPlayerUnitEvent, filter);
        }

        //native GetLevelingUnit takes nothing returns unit
        private delegate JassUnit GetLevelingUnitPrototype();
        private GetLevelingUnitPrototype _GetLevelingUnit = WarcraftIII.Jass.GetNative("GetLevelingUnit").ToDelegate<GetLevelingUnitPrototype>();
        public JassUnit GetLevelingUnit()
        {
            return _GetLevelingUnit();
        }

        //native GetLearningUnit takes nothing returns unit
        private delegate JassUnit GetLearningUnitPrototype();
        private GetLearningUnitPrototype _GetLearningUnit = WarcraftIII.Jass.GetNative("GetLearningUnit").ToDelegate<GetLearningUnitPrototype>();
        public JassUnit GetLearningUnit()
        {
            return _GetLearningUnit();
        }

        //native GetLearnedSkill takes nothing returns integer
        private delegate JassInteger GetLearnedSkillPrototype();
        private GetLearnedSkillPrototype _GetLearnedSkill = WarcraftIII.Jass.GetNative("GetLearnedSkill").ToDelegate<GetLearnedSkillPrototype>();
        public JassInteger GetLearnedSkill()
        {
            return _GetLearnedSkill();
        }

        //native GetLearnedSkillLevel takes nothing returns integer
        private delegate JassInteger GetLearnedSkillLevelPrototype();
        private GetLearnedSkillLevelPrototype _GetLearnedSkillLevel = WarcraftIII.Jass.GetNative("GetLearnedSkillLevel").ToDelegate<GetLearnedSkillLevelPrototype>();
        public JassInteger GetLearnedSkillLevel()
        {
            return _GetLearnedSkillLevel();
        }

        //native GetRevivableUnit takes nothing returns unit
        private delegate JassUnit GetRevivableUnitPrototype();
        private GetRevivableUnitPrototype _GetRevivableUnit = WarcraftIII.Jass.GetNative("GetRevivableUnit").ToDelegate<GetRevivableUnitPrototype>();
        public JassUnit GetRevivableUnit()
        {
            return _GetRevivableUnit();
        }

        //native GetRevivingUnit takes nothing returns unit
        private delegate JassUnit GetRevivingUnitPrototype();
        private GetRevivingUnitPrototype _GetRevivingUnit = WarcraftIII.Jass.GetNative("GetRevivingUnit").ToDelegate<GetRevivingUnitPrototype>();
        public JassUnit GetRevivingUnit()
        {
            return _GetRevivingUnit();
        }

        //native GetAttacker takes nothing returns unit
        private delegate JassUnit GetAttackerPrototype();
        private GetAttackerPrototype _GetAttacker = WarcraftIII.Jass.GetNative("GetAttacker").ToDelegate<GetAttackerPrototype>();
        public JassUnit GetAttacker()
        {
            return _GetAttacker();
        }

        //native GetRescuer takes nothing returns unit
        private delegate JassUnit GetRescuerPrototype();
        private GetRescuerPrototype _GetRescuer = WarcraftIII.Jass.GetNative("GetRescuer").ToDelegate<GetRescuerPrototype>();
        public JassUnit GetRescuer()
        {
            return _GetRescuer();
        }

        //native GetDyingUnit takes nothing returns unit
        private delegate JassUnit GetDyingUnitPrototype();
        private GetDyingUnitPrototype _GetDyingUnit = WarcraftIII.Jass.GetNative("GetDyingUnit").ToDelegate<GetDyingUnitPrototype>();
        public JassUnit GetDyingUnit()
        {
            return _GetDyingUnit();
        }

        //native GetKillingUnit takes nothing returns unit
        private delegate JassUnit GetKillingUnitPrototype();
        private GetKillingUnitPrototype _GetKillingUnit = WarcraftIII.Jass.GetNative("GetKillingUnit").ToDelegate<GetKillingUnitPrototype>();
        public JassUnit GetKillingUnit()
        {
            return _GetKillingUnit();
        }

        //native GetDecayingUnit takes nothing returns unit
        private delegate JassUnit GetDecayingUnitPrototype();
        private GetDecayingUnitPrototype _GetDecayingUnit = WarcraftIII.Jass.GetNative("GetDecayingUnit").ToDelegate<GetDecayingUnitPrototype>();
        public JassUnit GetDecayingUnit()
        {
            return _GetDecayingUnit();
        }

        //native GetConstructingStructure takes nothing returns unit
        private delegate JassUnit GetConstructingStructurePrototype();
        private GetConstructingStructurePrototype _GetConstructingStructure = WarcraftIII.Jass.GetNative("GetConstructingStructure").ToDelegate<GetConstructingStructurePrototype>();
        public JassUnit GetConstructingStructure()
        {
            return _GetConstructingStructure();
        }

        //native GetCancelledStructure takes nothing returns unit
        private delegate JassUnit GetCancelledStructurePrototype();
        private GetCancelledStructurePrototype _GetCancelledStructure = WarcraftIII.Jass.GetNative("GetCancelledStructure").ToDelegate<GetCancelledStructurePrototype>();
        public JassUnit GetCancelledStructure()
        {
            return _GetCancelledStructure();
        }

        //native GetConstructedStructure takes nothing returns unit
        private delegate JassUnit GetConstructedStructurePrototype();
        private GetConstructedStructurePrototype _GetConstructedStructure = WarcraftIII.Jass.GetNative("GetConstructedStructure").ToDelegate<GetConstructedStructurePrototype>();
        public JassUnit GetConstructedStructure()
        {
            return _GetConstructedStructure();
        }

        //native GetResearchingUnit takes nothing returns unit
        private delegate JassUnit GetResearchingUnitPrototype();
        private GetResearchingUnitPrototype _GetResearchingUnit = WarcraftIII.Jass.GetNative("GetResearchingUnit").ToDelegate<GetResearchingUnitPrototype>();
        public JassUnit GetResearchingUnit()
        {
            return _GetResearchingUnit();
        }

        //native GetResearched takes nothing returns integer
        private delegate JassInteger GetResearchedPrototype();
        private GetResearchedPrototype _GetResearched = WarcraftIII.Jass.GetNative("GetResearched").ToDelegate<GetResearchedPrototype>();
        public JassInteger GetResearched()
        {
            return _GetResearched();
        }

        //native GetTrainedUnitType takes nothing returns integer
        private delegate JassInteger GetTrainedUnitTypePrototype();
        private GetTrainedUnitTypePrototype _GetTrainedUnitType = WarcraftIII.Jass.GetNative("GetTrainedUnitType").ToDelegate<GetTrainedUnitTypePrototype>();
        public JassInteger GetTrainedUnitType()
        {
            return _GetTrainedUnitType();
        }

        //native GetTrainedUnit takes nothing returns unit
        private delegate JassUnit GetTrainedUnitPrototype();
        private GetTrainedUnitPrototype _GetTrainedUnit = WarcraftIII.Jass.GetNative("GetTrainedUnit").ToDelegate<GetTrainedUnitPrototype>();
        public JassUnit GetTrainedUnit()
        {
            return _GetTrainedUnit();
        }

        //native GetDetectedUnit takes nothing returns unit
        private delegate JassUnit GetDetectedUnitPrototype();
        private GetDetectedUnitPrototype _GetDetectedUnit = WarcraftIII.Jass.GetNative("GetDetectedUnit").ToDelegate<GetDetectedUnitPrototype>();
        public JassUnit GetDetectedUnit()
        {
            return _GetDetectedUnit();
        }

        //native GetSummoningUnit takes nothing returns unit
        private delegate JassUnit GetSummoningUnitPrototype();
        private GetSummoningUnitPrototype _GetSummoningUnit = WarcraftIII.Jass.GetNative("GetSummoningUnit").ToDelegate<GetSummoningUnitPrototype>();
        public JassUnit GetSummoningUnit()
        {
            return _GetSummoningUnit();
        }

        //native GetSummonedUnit takes nothing returns unit
        private delegate JassUnit GetSummonedUnitPrototype();
        private GetSummonedUnitPrototype _GetSummonedUnit = WarcraftIII.Jass.GetNative("GetSummonedUnit").ToDelegate<GetSummonedUnitPrototype>();
        public JassUnit GetSummonedUnit()
        {
            return _GetSummonedUnit();
        }

        //native GetTransportUnit takes nothing returns unit
        private delegate JassUnit GetTransportUnitPrototype();
        private GetTransportUnitPrototype _GetTransportUnit = WarcraftIII.Jass.GetNative("GetTransportUnit").ToDelegate<GetTransportUnitPrototype>();
        public JassUnit GetTransportUnit()
        {
            return _GetTransportUnit();
        }

        //native GetLoadedUnit takes nothing returns unit
        private delegate JassUnit GetLoadedUnitPrototype();
        private GetLoadedUnitPrototype _GetLoadedUnit = WarcraftIII.Jass.GetNative("GetLoadedUnit").ToDelegate<GetLoadedUnitPrototype>();
        public JassUnit GetLoadedUnit()
        {
            return _GetLoadedUnit();
        }

        //native GetSellingUnit takes nothing returns unit
        private delegate JassUnit GetSellingUnitPrototype();
        private GetSellingUnitPrototype _GetSellingUnit = WarcraftIII.Jass.GetNative("GetSellingUnit").ToDelegate<GetSellingUnitPrototype>();
        public JassUnit GetSellingUnit()
        {
            return _GetSellingUnit();
        }

        //native GetSoldUnit takes nothing returns unit
        private delegate JassUnit GetSoldUnitPrototype();
        private GetSoldUnitPrototype _GetSoldUnit = WarcraftIII.Jass.GetNative("GetSoldUnit").ToDelegate<GetSoldUnitPrototype>();
        public JassUnit GetSoldUnit()
        {
            return _GetSoldUnit();
        }

        //native GetBuyingUnit takes nothing returns unit
        private delegate JassUnit GetBuyingUnitPrototype();
        private GetBuyingUnitPrototype _GetBuyingUnit = WarcraftIII.Jass.GetNative("GetBuyingUnit").ToDelegate<GetBuyingUnitPrototype>();
        public JassUnit GetBuyingUnit()
        {
            return _GetBuyingUnit();
        }

        //native GetSoldItem takes nothing returns item
        private delegate JassItem GetSoldItemPrototype();
        private GetSoldItemPrototype _GetSoldItem = WarcraftIII.Jass.GetNative("GetSoldItem").ToDelegate<GetSoldItemPrototype>();
        public JassItem GetSoldItem()
        {
            return _GetSoldItem();
        }

        //native GetChangingUnit takes nothing returns unit
        private delegate JassUnit GetChangingUnitPrototype();
        private GetChangingUnitPrototype _GetChangingUnit = WarcraftIII.Jass.GetNative("GetChangingUnit").ToDelegate<GetChangingUnitPrototype>();
        public JassUnit GetChangingUnit()
        {
            return _GetChangingUnit();
        }

        //native GetChangingUnitPrevOwner takes nothing returns player
        private delegate JassPlayer GetChangingUnitPrevOwnerPrototype();
        private GetChangingUnitPrevOwnerPrototype _GetChangingUnitPrevOwner = WarcraftIII.Jass.GetNative("GetChangingUnitPrevOwner").ToDelegate<GetChangingUnitPrevOwnerPrototype>();
        public JassPlayer GetChangingUnitPrevOwner()
        {
            return _GetChangingUnitPrevOwner();
        }

        //native GetManipulatingUnit takes nothing returns unit
        private delegate JassUnit GetManipulatingUnitPrototype();
        private GetManipulatingUnitPrototype _GetManipulatingUnit = WarcraftIII.Jass.GetNative("GetManipulatingUnit").ToDelegate<GetManipulatingUnitPrototype>();
        public JassUnit GetManipulatingUnit()
        {
            return _GetManipulatingUnit();
        }

        //native GetManipulatedItem takes nothing returns item
        private delegate JassItem GetManipulatedItemPrototype();
        private GetManipulatedItemPrototype _GetManipulatedItem = WarcraftIII.Jass.GetNative("GetManipulatedItem").ToDelegate<GetManipulatedItemPrototype>();
        public JassItem GetManipulatedItem()
        {
            return _GetManipulatedItem();
        }

        //native GetOrderedUnit takes nothing returns unit
        private delegate JassUnit GetOrderedUnitPrototype();
        private GetOrderedUnitPrototype _GetOrderedUnit = WarcraftIII.Jass.GetNative("GetOrderedUnit").ToDelegate<GetOrderedUnitPrototype>();
        public JassUnit GetOrderedUnit()
        {
            return _GetOrderedUnit();
        }

        //native GetIssuedOrderId takes nothing returns integer
        private delegate JassOrder GetIssuedOrderIdPrototype();
        private GetIssuedOrderIdPrototype _GetIssuedOrderId = WarcraftIII.Jass.GetNative("GetIssuedOrderId").ToDelegate<GetIssuedOrderIdPrototype>();
        public JassOrder GetIssuedOrderId()
        {
            return _GetIssuedOrderId();
        }

        //native GetOrderPointX takes nothing returns real
        private delegate JassRealRet GetOrderPointXPrototype();
        private GetOrderPointXPrototype _GetOrderPointX = WarcraftIII.Jass.GetNative("GetOrderPointX").ToDelegate<GetOrderPointXPrototype>();
        public Single GetOrderPointX()
        {
            return _GetOrderPointX();
        }

        //native GetOrderPointY takes nothing returns real
        private delegate JassRealRet GetOrderPointYPrototype();
        private GetOrderPointYPrototype _GetOrderPointY = WarcraftIII.Jass.GetNative("GetOrderPointY").ToDelegate<GetOrderPointYPrototype>();
        public Single GetOrderPointY()
        {
            return _GetOrderPointY();
        }

        //native GetOrderPointLoc takes nothing returns location
        private delegate JassLocation GetOrderPointLocPrototype();
        private GetOrderPointLocPrototype _GetOrderPointLoc = WarcraftIII.Jass.GetNative("GetOrderPointLoc").ToDelegate<GetOrderPointLocPrototype>();
        public JassLocation GetOrderPointLoc()
        {
            return _GetOrderPointLoc();
        }

        //native GetOrderTarget takes nothing returns widget
        private delegate JassWidget GetOrderTargetPrototype();
        private GetOrderTargetPrototype _GetOrderTarget = WarcraftIII.Jass.GetNative("GetOrderTarget").ToDelegate<GetOrderTargetPrototype>();
        public JassWidget GetOrderTarget()
        {
            return _GetOrderTarget();
        }

        //native GetOrderTargetDestructable takes nothing returns destructable
        private delegate JassDestructable GetOrderTargetDestructablePrototype();
        private GetOrderTargetDestructablePrototype _GetOrderTargetDestructable = WarcraftIII.Jass.GetNative("GetOrderTargetDestructable").ToDelegate<GetOrderTargetDestructablePrototype>();
        public JassDestructable GetOrderTargetDestructable()
        {
            return _GetOrderTargetDestructable();
        }

        //native GetOrderTargetItem takes nothing returns item
        private delegate JassItem GetOrderTargetItemPrototype();
        private GetOrderTargetItemPrototype _GetOrderTargetItem = WarcraftIII.Jass.GetNative("GetOrderTargetItem").ToDelegate<GetOrderTargetItemPrototype>();
        public JassItem GetOrderTargetItem()
        {
            return _GetOrderTargetItem();
        }

        //native GetOrderTargetUnit takes nothing returns unit
        private delegate JassUnit GetOrderTargetUnitPrototype();
        private GetOrderTargetUnitPrototype _GetOrderTargetUnit = WarcraftIII.Jass.GetNative("GetOrderTargetUnit").ToDelegate<GetOrderTargetUnitPrototype>();
        public JassUnit GetOrderTargetUnit()
        {
            return _GetOrderTargetUnit();
        }

        //native GetSpellAbilityUnit takes nothing returns unit
        private delegate JassUnit GetSpellAbilityUnitPrototype();
        private GetSpellAbilityUnitPrototype _GetSpellAbilityUnit = WarcraftIII.Jass.GetNative("GetSpellAbilityUnit").ToDelegate<GetSpellAbilityUnitPrototype>();
        public JassUnit GetSpellAbilityUnit()
        {
            return _GetSpellAbilityUnit();
        }

        //native GetSpellAbilityId takes nothing returns integer
        private delegate JassInteger GetSpellAbilityIdPrototype();
        private GetSpellAbilityIdPrototype _GetSpellAbilityId = WarcraftIII.Jass.GetNative("GetSpellAbilityId").ToDelegate<GetSpellAbilityIdPrototype>();
        public JassInteger GetSpellAbilityId()
        {
            return _GetSpellAbilityId();
        }

        //native GetSpellAbility takes nothing returns ability
        private delegate JassAbility GetSpellAbilityPrototype();
        private GetSpellAbilityPrototype _GetSpellAbility = WarcraftIII.Jass.GetNative("GetSpellAbility").ToDelegate<GetSpellAbilityPrototype>();
        public JassAbility GetSpellAbility()
        {
            return _GetSpellAbility();
        }

        //native GetSpellTargetLoc takes nothing returns location
        private delegate JassLocation GetSpellTargetLocPrototype();
        private GetSpellTargetLocPrototype _GetSpellTargetLoc = WarcraftIII.Jass.GetNative("GetSpellTargetLoc").ToDelegate<GetSpellTargetLocPrototype>();
        public JassLocation GetSpellTargetLoc()
        {
            return _GetSpellTargetLoc();
        }

        //native GetSpellTargetX takes nothing returns real
        private delegate JassRealRet GetSpellTargetXPrototype();
        private GetSpellTargetXPrototype _GetSpellTargetX = WarcraftIII.Jass.GetNative("GetSpellTargetX").ToDelegate<GetSpellTargetXPrototype>();
        public Single GetSpellTargetX()
        {
            return _GetSpellTargetX();
        }

        //native GetSpellTargetY takes nothing returns real
        private delegate JassRealRet GetSpellTargetYPrototype();
        private GetSpellTargetYPrototype _GetSpellTargetY = WarcraftIII.Jass.GetNative("GetSpellTargetY").ToDelegate<GetSpellTargetYPrototype>();
        public Single GetSpellTargetY()
        {
            return _GetSpellTargetY();
        }

        //native GetSpellTargetDestructable takes nothing returns destructable
        private delegate JassDestructable GetSpellTargetDestructablePrototype();
        private GetSpellTargetDestructablePrototype _GetSpellTargetDestructable = WarcraftIII.Jass.GetNative("GetSpellTargetDestructable").ToDelegate<GetSpellTargetDestructablePrototype>();
        public JassDestructable GetSpellTargetDestructable()
        {
            return _GetSpellTargetDestructable();
        }

        //native GetSpellTargetItem takes nothing returns item
        private delegate JassItem GetSpellTargetItemPrototype();
        private GetSpellTargetItemPrototype _GetSpellTargetItem = WarcraftIII.Jass.GetNative("GetSpellTargetItem").ToDelegate<GetSpellTargetItemPrototype>();
        public JassItem GetSpellTargetItem()
        {
            return _GetSpellTargetItem();
        }

        //native GetSpellTargetUnit takes nothing returns unit
        private delegate JassUnit GetSpellTargetUnitPrototype();
        private GetSpellTargetUnitPrototype _GetSpellTargetUnit = WarcraftIII.Jass.GetNative("GetSpellTargetUnit").ToDelegate<GetSpellTargetUnitPrototype>();
        public JassUnit GetSpellTargetUnit()
        {
            return _GetSpellTargetUnit();
        }

        //native TriggerRegisterPlayerAllianceChange takes trigger whichTrigger, player whichPlayer, alliancetype whichAlliance returns event
        private delegate JassEvent TriggerRegisterPlayerAllianceChangePrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance);
        private TriggerRegisterPlayerAllianceChangePrototype _TriggerRegisterPlayerAllianceChange = WarcraftIII.Jass.GetNative("TriggerRegisterPlayerAllianceChange").ToDelegate<TriggerRegisterPlayerAllianceChangePrototype>();
        public JassEvent TriggerRegisterPlayerAllianceChange(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance)
        {
            return _TriggerRegisterPlayerAllianceChange(whichTrigger, whichPlayer, whichAlliance);
        }

        //native TriggerRegisterPlayerStateEvent takes trigger whichTrigger, player whichPlayer, playerstate whichState, limitop opcode, real limitval returns event
        private delegate JassEvent TriggerRegisterPlayerStateEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, JassRealArg limitval);
        private TriggerRegisterPlayerStateEventPrototype _TriggerRegisterPlayerStateEvent = WarcraftIII.Jass.GetNative("TriggerRegisterPlayerStateEvent").ToDelegate<TriggerRegisterPlayerStateEventPrototype>();
        public JassEvent TriggerRegisterPlayerStateEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, Single limitval)
        {
            return _TriggerRegisterPlayerStateEvent(whichTrigger, whichPlayer, whichState, opcode, limitval);
        }

        //native GetEventPlayerState takes nothing returns playerstate
        private delegate JassPlayerState GetEventPlayerStatePrototype();
        private GetEventPlayerStatePrototype _GetEventPlayerState = WarcraftIII.Jass.GetNative("GetEventPlayerState").ToDelegate<GetEventPlayerStatePrototype>();
        public JassPlayerState GetEventPlayerState()
        {
            return _GetEventPlayerState();
        }

        //native TriggerRegisterPlayerChatEvent takes trigger whichTrigger, player whichPlayer, string chatMessageToDetect, boolean exactMatchOnly returns event
        private delegate JassEvent TriggerRegisterPlayerChatEventPrototype(JassTrigger whichTrigger, JassPlayer whichPlayer, JassStringArg chatMessageToDetect, JassBoolean exactMatchOnly);
        private TriggerRegisterPlayerChatEventPrototype _TriggerRegisterPlayerChatEvent = WarcraftIII.Jass.GetNative("TriggerRegisterPlayerChatEvent").ToDelegate<TriggerRegisterPlayerChatEventPrototype>();
        public JassEvent TriggerRegisterPlayerChatEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, String chatMessageToDetect, Boolean exactMatchOnly)
        {
            return _TriggerRegisterPlayerChatEvent(whichTrigger, whichPlayer, chatMessageToDetect, exactMatchOnly);
        }

        //native GetEventPlayerChatString takes nothing returns string
        private delegate JassStringRet GetEventPlayerChatStringPrototype();
        private GetEventPlayerChatStringPrototype _GetEventPlayerChatString = WarcraftIII.Jass.GetNative("GetEventPlayerChatString").ToDelegate<GetEventPlayerChatStringPrototype>();
        public String GetEventPlayerChatString()
        {
            return _GetEventPlayerChatString();
        }

        //native GetEventPlayerChatStringMatched takes nothing returns string
        private delegate JassStringRet GetEventPlayerChatStringMatchedPrototype();
        private GetEventPlayerChatStringMatchedPrototype _GetEventPlayerChatStringMatched = WarcraftIII.Jass.GetNative("GetEventPlayerChatStringMatched").ToDelegate<GetEventPlayerChatStringMatchedPrototype>();
        public String GetEventPlayerChatStringMatched()
        {
            return _GetEventPlayerChatStringMatched();
        }

        //native TriggerRegisterDeathEvent takes trigger whichTrigger, widget whichWidget returns event
        private delegate JassEvent TriggerRegisterDeathEventPrototype(JassTrigger whichTrigger, JassWidget whichWidget);
        private TriggerRegisterDeathEventPrototype _TriggerRegisterDeathEvent = WarcraftIII.Jass.GetNative("TriggerRegisterDeathEvent").ToDelegate<TriggerRegisterDeathEventPrototype>();
        public JassEvent TriggerRegisterDeathEvent(JassTrigger whichTrigger, JassWidget whichWidget)
        {
            return _TriggerRegisterDeathEvent(whichTrigger, whichWidget);
        }

        //native GetTriggerUnit takes nothing returns unit
        private delegate JassUnit GetTriggerUnitPrototype();
        private GetTriggerUnitPrototype _GetTriggerUnit = WarcraftIII.Jass.GetNative("GetTriggerUnit").ToDelegate<GetTriggerUnitPrototype>();
        public JassUnit GetTriggerUnit()
        {
            return _GetTriggerUnit();
        }

        //native TriggerRegisterUnitStateEvent takes trigger whichTrigger, unit whichUnit, unitstate whichState, limitop opcode, real limitval returns event
        private delegate JassEvent TriggerRegisterUnitStateEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, JassRealArg limitval);
        private TriggerRegisterUnitStateEventPrototype _TriggerRegisterUnitStateEvent = WarcraftIII.Jass.GetNative("TriggerRegisterUnitStateEvent").ToDelegate<TriggerRegisterUnitStateEventPrototype>();
        public JassEvent TriggerRegisterUnitStateEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, Single limitval)
        {
            return _TriggerRegisterUnitStateEvent(whichTrigger, whichUnit, whichState, opcode, limitval);
        }

        //native GetEventUnitState takes nothing returns unitstate
        private delegate JassUnitState GetEventUnitStatePrototype();
        private GetEventUnitStatePrototype _GetEventUnitState = WarcraftIII.Jass.GetNative("GetEventUnitState").ToDelegate<GetEventUnitStatePrototype>();
        public JassUnitState GetEventUnitState()
        {
            return _GetEventUnitState();
        }

        //native TriggerRegisterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent returns event
        private delegate JassEvent TriggerRegisterUnitEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent);
        private TriggerRegisterUnitEventPrototype _TriggerRegisterUnitEvent = WarcraftIII.Jass.GetNative("TriggerRegisterUnitEvent").ToDelegate<TriggerRegisterUnitEventPrototype>();
        public JassEvent TriggerRegisterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent)
        {
            return _TriggerRegisterUnitEvent(whichTrigger, whichUnit, whichEvent);
        }

        //native GetEventDamage takes nothing returns real
        private delegate JassRealRet GetEventDamagePrototype();
        private GetEventDamagePrototype _GetEventDamage = WarcraftIII.Jass.GetNative("GetEventDamage").ToDelegate<GetEventDamagePrototype>();
        public Single GetEventDamage()
        {
            return _GetEventDamage();
        }

        //native GetEventDamageSource takes nothing returns unit
        private delegate JassUnit GetEventDamageSourcePrototype();
        private GetEventDamageSourcePrototype _GetEventDamageSource = WarcraftIII.Jass.GetNative("GetEventDamageSource").ToDelegate<GetEventDamageSourcePrototype>();
        public JassUnit GetEventDamageSource()
        {
            return _GetEventDamageSource();
        }

        //native GetEventDetectingPlayer takes nothing returns player
        private delegate JassPlayer GetEventDetectingPlayerPrototype();
        private GetEventDetectingPlayerPrototype _GetEventDetectingPlayer = WarcraftIII.Jass.GetNative("GetEventDetectingPlayer").ToDelegate<GetEventDetectingPlayerPrototype>();
        public JassPlayer GetEventDetectingPlayer()
        {
            return _GetEventDetectingPlayer();
        }

        //native TriggerRegisterFilterUnitEvent takes trigger whichTrigger, unit whichUnit, unitevent whichEvent, boolexpr filter returns event
        private delegate JassEvent TriggerRegisterFilterUnitEventPrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter);
        private TriggerRegisterFilterUnitEventPrototype _TriggerRegisterFilterUnitEvent = WarcraftIII.Jass.GetNative("TriggerRegisterFilterUnitEvent").ToDelegate<TriggerRegisterFilterUnitEventPrototype>();
        public JassEvent TriggerRegisterFilterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter)
        {
            return _TriggerRegisterFilterUnitEvent(whichTrigger, whichUnit, whichEvent, filter);
        }

        //native GetEventTargetUnit takes nothing returns unit
        private delegate JassUnit GetEventTargetUnitPrototype();
        private GetEventTargetUnitPrototype _GetEventTargetUnit = WarcraftIII.Jass.GetNative("GetEventTargetUnit").ToDelegate<GetEventTargetUnitPrototype>();
        public JassUnit GetEventTargetUnit()
        {
            return _GetEventTargetUnit();
        }

        //native TriggerRegisterUnitInRange takes trigger whichTrigger, unit whichUnit, real range, boolexpr filter returns event
        private delegate JassEvent TriggerRegisterUnitInRangePrototype(JassTrigger whichTrigger, JassUnit whichUnit, JassRealArg range, JassBooleanExpression filter);
        private TriggerRegisterUnitInRangePrototype _TriggerRegisterUnitInRange = WarcraftIII.Jass.GetNative("TriggerRegisterUnitInRange").ToDelegate<TriggerRegisterUnitInRangePrototype>();
        public JassEvent TriggerRegisterUnitInRange(JassTrigger whichTrigger, JassUnit whichUnit, Single range, JassBooleanExpression filter)
        {
            return _TriggerRegisterUnitInRange(whichTrigger, whichUnit, range, filter);
        }

        //native TriggerAddCondition takes trigger whichTrigger, boolexpr condition returns triggercondition
        private delegate JassTriggerCondition TriggerAddConditionPrototype(JassTrigger whichTrigger, JassBooleanExpression condition);
        private TriggerAddConditionPrototype _TriggerAddCondition = WarcraftIII.Jass.GetNative("TriggerAddCondition").ToDelegate<TriggerAddConditionPrototype>();
        public JassTriggerCondition TriggerAddCondition(JassTrigger whichTrigger, JassBooleanExpression condition)
        {
            return _TriggerAddCondition(whichTrigger, condition);
        }

        //native TriggerRemoveCondition takes trigger whichTrigger, triggercondition whichCondition returns nothing
        private delegate void TriggerRemoveConditionPrototype(JassTrigger whichTrigger, JassTriggerCondition whichCondition);
        private TriggerRemoveConditionPrototype _TriggerRemoveCondition = WarcraftIII.Jass.GetNative("TriggerRemoveCondition").ToDelegate<TriggerRemoveConditionPrototype>();
        public void TriggerRemoveCondition(JassTrigger whichTrigger, JassTriggerCondition whichCondition)
        {
            _TriggerRemoveCondition(whichTrigger, whichCondition);
        }

        //native TriggerClearConditions takes trigger whichTrigger returns nothing
        private delegate void TriggerClearConditionsPrototype(JassTrigger whichTrigger);
        private TriggerClearConditionsPrototype _TriggerClearConditions = WarcraftIII.Jass.GetNative("TriggerClearConditions").ToDelegate<TriggerClearConditionsPrototype>();
        public void TriggerClearConditions(JassTrigger whichTrigger)
        {
            _TriggerClearConditions(whichTrigger);
        }

        //native TriggerAddAction takes trigger whichTrigger, code actionFunc returns triggeraction
        private delegate JassTriggerAction TriggerAddActionPrototype(JassTrigger whichTrigger, JassCode actionFunc);
        private TriggerAddActionPrototype _TriggerAddAction = WarcraftIII.Jass.GetNative("TriggerAddAction").ToDelegate<TriggerAddActionPrototype>();
        public JassTriggerAction TriggerAddAction(JassTrigger whichTrigger, JassCode actionFunc)
        {
            return _TriggerAddAction(whichTrigger, actionFunc);
        }

        //native TriggerRemoveAction takes trigger whichTrigger, triggeraction whichAction returns nothing
        private delegate void TriggerRemoveActionPrototype(JassTrigger whichTrigger, JassTriggerAction whichAction);
        private TriggerRemoveActionPrototype _TriggerRemoveAction = WarcraftIII.Jass.GetNative("TriggerRemoveAction").ToDelegate<TriggerRemoveActionPrototype>();
        public void TriggerRemoveAction(JassTrigger whichTrigger, JassTriggerAction whichAction)
        {
            _TriggerRemoveAction(whichTrigger, whichAction);
        }

        //native TriggerClearActions takes trigger whichTrigger returns nothing
        private delegate void TriggerClearActionsPrototype(JassTrigger whichTrigger);
        private TriggerClearActionsPrototype _TriggerClearActions = WarcraftIII.Jass.GetNative("TriggerClearActions").ToDelegate<TriggerClearActionsPrototype>();
        public void TriggerClearActions(JassTrigger whichTrigger)
        {
            _TriggerClearActions(whichTrigger);
        }

        //native TriggerSleepAction takes real timeout returns nothing
        private delegate void TriggerSleepActionPrototype(JassRealArg timeout);
        private TriggerSleepActionPrototype _TriggerSleepAction = WarcraftIII.Jass.GetNative("TriggerSleepAction").ToDelegate<TriggerSleepActionPrototype>();
        public void TriggerSleepAction(Single timeout)
        {
            _TriggerSleepAction(timeout);
        }

        //native TriggerWaitForSound takes sound s, real offset returns nothing
        private delegate void TriggerWaitForSoundPrototype(JassSound s, JassRealArg offset);
        private TriggerWaitForSoundPrototype _TriggerWaitForSound = WarcraftIII.Jass.GetNative("TriggerWaitForSound").ToDelegate<TriggerWaitForSoundPrototype>();
        public void TriggerWaitForSound(JassSound s, Single offset)
        {
            _TriggerWaitForSound(s, offset);
        }

        //native TriggerEvaluate takes trigger whichTrigger returns boolean
        private delegate JassBoolean TriggerEvaluatePrototype(JassTrigger whichTrigger);
        private TriggerEvaluatePrototype _TriggerEvaluate = WarcraftIII.Jass.GetNative("TriggerEvaluate").ToDelegate<TriggerEvaluatePrototype>();
        public Boolean TriggerEvaluate(JassTrigger whichTrigger)
        {
            return _TriggerEvaluate(whichTrigger);
        }

        //native TriggerExecute takes trigger whichTrigger returns nothing
        private delegate void TriggerExecutePrototype(JassTrigger whichTrigger);
        private TriggerExecutePrototype _TriggerExecute = WarcraftIII.Jass.GetNative("TriggerExecute").ToDelegate<TriggerExecutePrototype>();
        public void TriggerExecute(JassTrigger whichTrigger)
        {
            _TriggerExecute(whichTrigger);
        }

        //native TriggerExecuteWait takes trigger whichTrigger returns nothing
        private delegate void TriggerExecuteWaitPrototype(JassTrigger whichTrigger);
        private TriggerExecuteWaitPrototype _TriggerExecuteWait = WarcraftIII.Jass.GetNative("TriggerExecuteWait").ToDelegate<TriggerExecuteWaitPrototype>();
        public void TriggerExecuteWait(JassTrigger whichTrigger)
        {
            _TriggerExecuteWait(whichTrigger);
        }

        //native TriggerSyncStart takes nothing returns nothing
        private delegate void TriggerSyncStartPrototype();
        private TriggerSyncStartPrototype _TriggerSyncStart = WarcraftIII.Jass.GetNative("TriggerSyncStart").ToDelegate<TriggerSyncStartPrototype>();
        public void TriggerSyncStart()
        {
            _TriggerSyncStart();
        }

        //native TriggerSyncReady takes nothing returns nothing
        private delegate void TriggerSyncReadyPrototype();
        private TriggerSyncReadyPrototype _TriggerSyncReady = WarcraftIII.Jass.GetNative("TriggerSyncReady").ToDelegate<TriggerSyncReadyPrototype>();
        public void TriggerSyncReady()
        {
            _TriggerSyncReady();
        }

        //native GetWidgetLife takes widget whichWidget returns real
        private delegate JassRealRet GetWidgetLifePrototype(JassWidget whichWidget);
        private GetWidgetLifePrototype _GetWidgetLife = WarcraftIII.Jass.GetNative("GetWidgetLife").ToDelegate<GetWidgetLifePrototype>();
        public Single GetWidgetLife(JassWidget whichWidget)
        {
            return _GetWidgetLife(whichWidget);
        }

        //native SetWidgetLife takes widget whichWidget, real newLife returns nothing
        private delegate void SetWidgetLifePrototype(JassWidget whichWidget, JassRealArg newLife);
        private SetWidgetLifePrototype _SetWidgetLife = WarcraftIII.Jass.GetNative("SetWidgetLife").ToDelegate<SetWidgetLifePrototype>();
        public void SetWidgetLife(JassWidget whichWidget, Single newLife)
        {
            _SetWidgetLife(whichWidget, newLife);
        }

        //native GetWidgetX takes widget whichWidget returns real
        private delegate JassRealRet GetWidgetXPrototype(JassWidget whichWidget);
        private GetWidgetXPrototype _GetWidgetX = WarcraftIII.Jass.GetNative("GetWidgetX").ToDelegate<GetWidgetXPrototype>();
        public Single GetWidgetX(JassWidget whichWidget)
        {
            return _GetWidgetX(whichWidget);
        }

        //native GetWidgetY takes widget whichWidget returns real
        private delegate JassRealRet GetWidgetYPrototype(JassWidget whichWidget);
        private GetWidgetYPrototype _GetWidgetY = WarcraftIII.Jass.GetNative("GetWidgetY").ToDelegate<GetWidgetYPrototype>();
        public Single GetWidgetY(JassWidget whichWidget)
        {
            return _GetWidgetY(whichWidget);
        }

        //native GetTriggerWidget takes nothing returns widget
        private delegate JassWidget GetTriggerWidgetPrototype();
        private GetTriggerWidgetPrototype _GetTriggerWidget = WarcraftIII.Jass.GetNative("GetTriggerWidget").ToDelegate<GetTriggerWidgetPrototype>();
        public JassWidget GetTriggerWidget()
        {
            return _GetTriggerWidget();
        }

        //native CreateDestructable takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
        private delegate JassDestructable CreateDestructablePrototype(JassInteger objectid, JassRealArg x, JassRealArg y, JassRealArg face, JassRealArg scale, JassInteger variation);
        private CreateDestructablePrototype _CreateDestructable = WarcraftIII.Jass.GetNative("CreateDestructable").ToDelegate<CreateDestructablePrototype>();
        public JassDestructable CreateDestructable(JassInteger objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return _CreateDestructable(objectid, x, y, face, scale, variation);
        }

        //native CreateDestructableZ takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
        private delegate JassDestructable CreateDestructableZPrototype(JassInteger objectid, JassRealArg x, JassRealArg y, JassRealArg z, JassRealArg face, JassRealArg scale, JassInteger variation);
        private CreateDestructableZPrototype _CreateDestructableZ = WarcraftIII.Jass.GetNative("CreateDestructableZ").ToDelegate<CreateDestructableZPrototype>();
        public JassDestructable CreateDestructableZ(JassInteger objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return _CreateDestructableZ(objectid, x, y, z, face, scale, variation);
        }

        //native CreateDeadDestructable takes integer objectid, real x, real y, real face, real scale, integer variation returns destructable
        private delegate JassDestructable CreateDeadDestructablePrototype(JassInteger objectid, JassRealArg x, JassRealArg y, JassRealArg face, JassRealArg scale, JassInteger variation);
        private CreateDeadDestructablePrototype _CreateDeadDestructable = WarcraftIII.Jass.GetNative("CreateDeadDestructable").ToDelegate<CreateDeadDestructablePrototype>();
        public JassDestructable CreateDeadDestructable(JassInteger objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return _CreateDeadDestructable(objectid, x, y, face, scale, variation);
        }

        //native CreateDeadDestructableZ takes integer objectid, real x, real y, real z, real face, real scale, integer variation returns destructable
        private delegate JassDestructable CreateDeadDestructableZPrototype(JassInteger objectid, JassRealArg x, JassRealArg y, JassRealArg z, JassRealArg face, JassRealArg scale, JassInteger variation);
        private CreateDeadDestructableZPrototype _CreateDeadDestructableZ = WarcraftIII.Jass.GetNative("CreateDeadDestructableZ").ToDelegate<CreateDeadDestructableZPrototype>();
        public JassDestructable CreateDeadDestructableZ(JassInteger objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return _CreateDeadDestructableZ(objectid, x, y, z, face, scale, variation);
        }

        //native RemoveDestructable takes destructable d returns nothing
        private delegate void RemoveDestructablePrototype(JassDestructable d);
        private RemoveDestructablePrototype _RemoveDestructable = WarcraftIII.Jass.GetNative("RemoveDestructable").ToDelegate<RemoveDestructablePrototype>();
        public void RemoveDestructable(JassDestructable d)
        {
            _RemoveDestructable(d);
        }

        //native KillDestructable takes destructable d returns nothing
        private delegate void KillDestructablePrototype(JassDestructable d);
        private KillDestructablePrototype _KillDestructable = WarcraftIII.Jass.GetNative("KillDestructable").ToDelegate<KillDestructablePrototype>();
        public void KillDestructable(JassDestructable d)
        {
            _KillDestructable(d);
        }

        //native SetDestructableInvulnerable takes destructable d, boolean flag returns nothing
        private delegate void SetDestructableInvulnerablePrototype(JassDestructable d, JassBoolean flag);
        private SetDestructableInvulnerablePrototype _SetDestructableInvulnerable = WarcraftIII.Jass.GetNative("SetDestructableInvulnerable").ToDelegate<SetDestructableInvulnerablePrototype>();
        public void SetDestructableInvulnerable(JassDestructable d, Boolean flag)
        {
            _SetDestructableInvulnerable(d, flag);
        }

        //native IsDestructableInvulnerable takes destructable d returns boolean
        private delegate JassBoolean IsDestructableInvulnerablePrototype(JassDestructable d);
        private IsDestructableInvulnerablePrototype _IsDestructableInvulnerable = WarcraftIII.Jass.GetNative("IsDestructableInvulnerable").ToDelegate<IsDestructableInvulnerablePrototype>();
        public Boolean IsDestructableInvulnerable(JassDestructable d)
        {
            return _IsDestructableInvulnerable(d);
        }

        //native EnumDestructablesInRect takes rect r, boolexpr filter, code actionFunc returns nothing
        private delegate void EnumDestructablesInRectPrototype(JassRect r, JassBooleanExpression filter, JassCode actionFunc);
        private EnumDestructablesInRectPrototype _EnumDestructablesInRect = WarcraftIII.Jass.GetNative("EnumDestructablesInRect").ToDelegate<EnumDestructablesInRectPrototype>();
        public void EnumDestructablesInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            _EnumDestructablesInRect(r, filter, actionFunc);
        }

        //native GetDestructableTypeId takes destructable d returns integer
        private delegate JassInteger GetDestructableTypeIdPrototype(JassDestructable d);
        private GetDestructableTypeIdPrototype _GetDestructableTypeId = WarcraftIII.Jass.GetNative("GetDestructableTypeId").ToDelegate<GetDestructableTypeIdPrototype>();
        public JassInteger GetDestructableTypeId(JassDestructable d)
        {
            return _GetDestructableTypeId(d);
        }

        //native GetDestructableX takes destructable d returns real
        private delegate JassRealRet GetDestructableXPrototype(JassDestructable d);
        private GetDestructableXPrototype _GetDestructableX = WarcraftIII.Jass.GetNative("GetDestructableX").ToDelegate<GetDestructableXPrototype>();
        public Single GetDestructableX(JassDestructable d)
        {
            return _GetDestructableX(d);
        }

        //native GetDestructableY takes destructable d returns real
        private delegate JassRealRet GetDestructableYPrototype(JassDestructable d);
        private GetDestructableYPrototype _GetDestructableY = WarcraftIII.Jass.GetNative("GetDestructableY").ToDelegate<GetDestructableYPrototype>();
        public Single GetDestructableY(JassDestructable d)
        {
            return _GetDestructableY(d);
        }

        //native SetDestructableLife takes destructable d, real life returns nothing
        private delegate void SetDestructableLifePrototype(JassDestructable d, JassRealArg life);
        private SetDestructableLifePrototype _SetDestructableLife = WarcraftIII.Jass.GetNative("SetDestructableLife").ToDelegate<SetDestructableLifePrototype>();
        public void SetDestructableLife(JassDestructable d, Single life)
        {
            _SetDestructableLife(d, life);
        }

        //native GetDestructableLife takes destructable d returns real
        private delegate JassRealRet GetDestructableLifePrototype(JassDestructable d);
        private GetDestructableLifePrototype _GetDestructableLife = WarcraftIII.Jass.GetNative("GetDestructableLife").ToDelegate<GetDestructableLifePrototype>();
        public Single GetDestructableLife(JassDestructable d)
        {
            return _GetDestructableLife(d);
        }

        //native SetDestructableMaxLife takes destructable d, real max returns nothing
        private delegate void SetDestructableMaxLifePrototype(JassDestructable d, JassRealArg max);
        private SetDestructableMaxLifePrototype _SetDestructableMaxLife = WarcraftIII.Jass.GetNative("SetDestructableMaxLife").ToDelegate<SetDestructableMaxLifePrototype>();
        public void SetDestructableMaxLife(JassDestructable d, Single max)
        {
            _SetDestructableMaxLife(d, max);
        }

        //native GetDestructableMaxLife takes destructable d returns real
        private delegate JassRealRet GetDestructableMaxLifePrototype(JassDestructable d);
        private GetDestructableMaxLifePrototype _GetDestructableMaxLife = WarcraftIII.Jass.GetNative("GetDestructableMaxLife").ToDelegate<GetDestructableMaxLifePrototype>();
        public Single GetDestructableMaxLife(JassDestructable d)
        {
            return _GetDestructableMaxLife(d);
        }

        //native DestructableRestoreLife takes destructable d, real life, boolean birth returns nothing
        private delegate void DestructableRestoreLifePrototype(JassDestructable d, JassRealArg life, JassBoolean birth);
        private DestructableRestoreLifePrototype _DestructableRestoreLife = WarcraftIII.Jass.GetNative("DestructableRestoreLife").ToDelegate<DestructableRestoreLifePrototype>();
        public void DestructableRestoreLife(JassDestructable d, Single life, Boolean birth)
        {
            _DestructableRestoreLife(d, life, birth);
        }

        //native QueueDestructableAnimation takes destructable d, string whichAnimation returns nothing
        private delegate void QueueDestructableAnimationPrototype(JassDestructable d, JassStringArg whichAnimation);
        private QueueDestructableAnimationPrototype _QueueDestructableAnimation = WarcraftIII.Jass.GetNative("QueueDestructableAnimation").ToDelegate<QueueDestructableAnimationPrototype>();
        public void QueueDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            _QueueDestructableAnimation(d, whichAnimation);
        }

        //native SetDestructableAnimation takes destructable d, string whichAnimation returns nothing
        private delegate void SetDestructableAnimationPrototype(JassDestructable d, JassStringArg whichAnimation);
        private SetDestructableAnimationPrototype _SetDestructableAnimation = WarcraftIII.Jass.GetNative("SetDestructableAnimation").ToDelegate<SetDestructableAnimationPrototype>();
        public void SetDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            _SetDestructableAnimation(d, whichAnimation);
        }

        //native SetDestructableAnimationSpeed takes destructable d, real speedFactor returns nothing
        private delegate void SetDestructableAnimationSpeedPrototype(JassDestructable d, JassRealArg speedFactor);
        private SetDestructableAnimationSpeedPrototype _SetDestructableAnimationSpeed = WarcraftIII.Jass.GetNative("SetDestructableAnimationSpeed").ToDelegate<SetDestructableAnimationSpeedPrototype>();
        public void SetDestructableAnimationSpeed(JassDestructable d, Single speedFactor)
        {
            _SetDestructableAnimationSpeed(d, speedFactor);
        }

        //native ShowDestructable takes destructable d, boolean flag returns nothing
        private delegate void ShowDestructablePrototype(JassDestructable d, JassBoolean flag);
        private ShowDestructablePrototype _ShowDestructable = WarcraftIII.Jass.GetNative("ShowDestructable").ToDelegate<ShowDestructablePrototype>();
        public void ShowDestructable(JassDestructable d, Boolean flag)
        {
            _ShowDestructable(d, flag);
        }

        //native GetDestructableOccluderHeight takes destructable d returns real
        private delegate JassRealRet GetDestructableOccluderHeightPrototype(JassDestructable d);
        private GetDestructableOccluderHeightPrototype _GetDestructableOccluderHeight = WarcraftIII.Jass.GetNative("GetDestructableOccluderHeight").ToDelegate<GetDestructableOccluderHeightPrototype>();
        public Single GetDestructableOccluderHeight(JassDestructable d)
        {
            return _GetDestructableOccluderHeight(d);
        }

        //native SetDestructableOccluderHeight takes destructable d, real height returns nothing
        private delegate void SetDestructableOccluderHeightPrototype(JassDestructable d, JassRealArg height);
        private SetDestructableOccluderHeightPrototype _SetDestructableOccluderHeight = WarcraftIII.Jass.GetNative("SetDestructableOccluderHeight").ToDelegate<SetDestructableOccluderHeightPrototype>();
        public void SetDestructableOccluderHeight(JassDestructable d, Single height)
        {
            _SetDestructableOccluderHeight(d, height);
        }

        //native GetDestructableName takes destructable d returns string
        private delegate JassStringRet GetDestructableNamePrototype(JassDestructable d);
        private GetDestructableNamePrototype _GetDestructableName = WarcraftIII.Jass.GetNative("GetDestructableName").ToDelegate<GetDestructableNamePrototype>();
        public String GetDestructableName(JassDestructable d)
        {
            return _GetDestructableName(d);
        }

        //native GetTriggerDestructable takes nothing returns destructable
        private delegate JassDestructable GetTriggerDestructablePrototype();
        private GetTriggerDestructablePrototype _GetTriggerDestructable = WarcraftIII.Jass.GetNative("GetTriggerDestructable").ToDelegate<GetTriggerDestructablePrototype>();
        public JassDestructable GetTriggerDestructable()
        {
            return _GetTriggerDestructable();
        }

        //native CreateItem takes integer itemid, real x, real y returns item
        private delegate JassItem CreateItemPrototype(JassInteger itemid, JassRealArg x, JassRealArg y);
        private CreateItemPrototype _CreateItem = WarcraftIII.Jass.GetNative("CreateItem").ToDelegate<CreateItemPrototype>();
        public JassItem CreateItem(JassInteger itemid, Single x, Single y)
        {
            return _CreateItem(itemid, x, y);
        }

        //native RemoveItem takes item whichItem returns nothing
        private delegate void RemoveItemPrototype(JassItem whichItem);
        private RemoveItemPrototype _RemoveItem = WarcraftIII.Jass.GetNative("RemoveItem").ToDelegate<RemoveItemPrototype>();
        public void RemoveItem(JassItem whichItem)
        {
            _RemoveItem(whichItem);
        }

        //native GetItemPlayer takes item whichItem returns player
        private delegate JassPlayer GetItemPlayerPrototype(JassItem whichItem);
        private GetItemPlayerPrototype _GetItemPlayer = WarcraftIII.Jass.GetNative("GetItemPlayer").ToDelegate<GetItemPlayerPrototype>();
        public JassPlayer GetItemPlayer(JassItem whichItem)
        {
            return _GetItemPlayer(whichItem);
        }

        //native GetItemTypeId takes item i returns integer
        private delegate JassInteger GetItemTypeIdPrototype(JassItem i);
        private GetItemTypeIdPrototype _GetItemTypeId = WarcraftIII.Jass.GetNative("GetItemTypeId").ToDelegate<GetItemTypeIdPrototype>();
        public JassInteger GetItemTypeId(JassItem i)
        {
            return _GetItemTypeId(i);
        }

        //native GetItemX takes item i returns real
        private delegate JassRealRet GetItemXPrototype(JassItem i);
        private GetItemXPrototype _GetItemX = WarcraftIII.Jass.GetNative("GetItemX").ToDelegate<GetItemXPrototype>();
        public Single GetItemX(JassItem i)
        {
            return _GetItemX(i);
        }

        //native GetItemY takes item i returns real
        private delegate JassRealRet GetItemYPrototype(JassItem i);
        private GetItemYPrototype _GetItemY = WarcraftIII.Jass.GetNative("GetItemY").ToDelegate<GetItemYPrototype>();
        public Single GetItemY(JassItem i)
        {
            return _GetItemY(i);
        }

        //native SetItemPosition takes item i, real x, real y returns nothing
        private delegate void SetItemPositionPrototype(JassItem i, JassRealArg x, JassRealArg y);
        private SetItemPositionPrototype _SetItemPosition = WarcraftIII.Jass.GetNative("SetItemPosition").ToDelegate<SetItemPositionPrototype>();
        public void SetItemPosition(JassItem i, Single x, Single y)
        {
            _SetItemPosition(i, x, y);
        }

        //native SetItemDropOnDeath takes item whichItem, boolean flag returns nothing
        private delegate void SetItemDropOnDeathPrototype(JassItem whichItem, JassBoolean flag);
        private SetItemDropOnDeathPrototype _SetItemDropOnDeath = WarcraftIII.Jass.GetNative("SetItemDropOnDeath").ToDelegate<SetItemDropOnDeathPrototype>();
        public void SetItemDropOnDeath(JassItem whichItem, Boolean flag)
        {
            _SetItemDropOnDeath(whichItem, flag);
        }

        //native SetItemDroppable takes item i, boolean flag returns nothing
        private delegate void SetItemDroppablePrototype(JassItem i, JassBoolean flag);
        private SetItemDroppablePrototype _SetItemDroppable = WarcraftIII.Jass.GetNative("SetItemDroppable").ToDelegate<SetItemDroppablePrototype>();
        public void SetItemDroppable(JassItem i, Boolean flag)
        {
            _SetItemDroppable(i, flag);
        }

        //native SetItemPawnable takes item i, boolean flag returns nothing
        private delegate void SetItemPawnablePrototype(JassItem i, JassBoolean flag);
        private SetItemPawnablePrototype _SetItemPawnable = WarcraftIII.Jass.GetNative("SetItemPawnable").ToDelegate<SetItemPawnablePrototype>();
        public void SetItemPawnable(JassItem i, Boolean flag)
        {
            _SetItemPawnable(i, flag);
        }

        //native SetItemPlayer takes item whichItem, player whichPlayer, boolean changeColor returns nothing
        private delegate void SetItemPlayerPrototype(JassItem whichItem, JassPlayer whichPlayer, JassBoolean changeColor);
        private SetItemPlayerPrototype _SetItemPlayer = WarcraftIII.Jass.GetNative("SetItemPlayer").ToDelegate<SetItemPlayerPrototype>();
        public void SetItemPlayer(JassItem whichItem, JassPlayer whichPlayer, Boolean changeColor)
        {
            _SetItemPlayer(whichItem, whichPlayer, changeColor);
        }

        //native SetItemInvulnerable takes item whichItem, boolean flag returns nothing
        private delegate void SetItemInvulnerablePrototype(JassItem whichItem, JassBoolean flag);
        private SetItemInvulnerablePrototype _SetItemInvulnerable = WarcraftIII.Jass.GetNative("SetItemInvulnerable").ToDelegate<SetItemInvulnerablePrototype>();
        public void SetItemInvulnerable(JassItem whichItem, Boolean flag)
        {
            _SetItemInvulnerable(whichItem, flag);
        }

        //native IsItemInvulnerable takes item whichItem returns boolean
        private delegate JassBoolean IsItemInvulnerablePrototype(JassItem whichItem);
        private IsItemInvulnerablePrototype _IsItemInvulnerable = WarcraftIII.Jass.GetNative("IsItemInvulnerable").ToDelegate<IsItemInvulnerablePrototype>();
        public Boolean IsItemInvulnerable(JassItem whichItem)
        {
            return _IsItemInvulnerable(whichItem);
        }

        //native SetItemVisible takes item whichItem, boolean show returns nothing
        private delegate void SetItemVisiblePrototype(JassItem whichItem, JassBoolean show);
        private SetItemVisiblePrototype _SetItemVisible = WarcraftIII.Jass.GetNative("SetItemVisible").ToDelegate<SetItemVisiblePrototype>();
        public void SetItemVisible(JassItem whichItem, Boolean show)
        {
            _SetItemVisible(whichItem, show);
        }

        //native IsItemVisible takes item whichItem returns boolean
        private delegate JassBoolean IsItemVisiblePrototype(JassItem whichItem);
        private IsItemVisiblePrototype _IsItemVisible = WarcraftIII.Jass.GetNative("IsItemVisible").ToDelegate<IsItemVisiblePrototype>();
        public Boolean IsItemVisible(JassItem whichItem)
        {
            return _IsItemVisible(whichItem);
        }

        //native IsItemOwned takes item whichItem returns boolean
        private delegate JassBoolean IsItemOwnedPrototype(JassItem whichItem);
        private IsItemOwnedPrototype _IsItemOwned = WarcraftIII.Jass.GetNative("IsItemOwned").ToDelegate<IsItemOwnedPrototype>();
        public Boolean IsItemOwned(JassItem whichItem)
        {
            return _IsItemOwned(whichItem);
        }

        //native IsItemPowerup takes item whichItem returns boolean
        private delegate JassBoolean IsItemPowerupPrototype(JassItem whichItem);
        private IsItemPowerupPrototype _IsItemPowerup = WarcraftIII.Jass.GetNative("IsItemPowerup").ToDelegate<IsItemPowerupPrototype>();
        public Boolean IsItemPowerup(JassItem whichItem)
        {
            return _IsItemPowerup(whichItem);
        }

        //native IsItemSellable takes item whichItem returns boolean
        private delegate JassBoolean IsItemSellablePrototype(JassItem whichItem);
        private IsItemSellablePrototype _IsItemSellable = WarcraftIII.Jass.GetNative("IsItemSellable").ToDelegate<IsItemSellablePrototype>();
        public Boolean IsItemSellable(JassItem whichItem)
        {
            return _IsItemSellable(whichItem);
        }

        //native IsItemPawnable takes item whichItem returns boolean
        private delegate JassBoolean IsItemPawnablePrototype(JassItem whichItem);
        private IsItemPawnablePrototype _IsItemPawnable = WarcraftIII.Jass.GetNative("IsItemPawnable").ToDelegate<IsItemPawnablePrototype>();
        public Boolean IsItemPawnable(JassItem whichItem)
        {
            return _IsItemPawnable(whichItem);
        }

        //native IsItemIdPowerup takes integer itemId returns boolean
        private delegate JassBoolean IsItemIdPowerupPrototype(JassInteger itemId);
        private IsItemIdPowerupPrototype _IsItemIdPowerup = WarcraftIII.Jass.GetNative("IsItemIdPowerup").ToDelegate<IsItemIdPowerupPrototype>();
        public Boolean IsItemIdPowerup(JassInteger itemId)
        {
            return _IsItemIdPowerup(itemId);
        }

        //native IsItemIdSellable takes integer itemId returns boolean
        private delegate JassBoolean IsItemIdSellablePrototype(JassInteger itemId);
        private IsItemIdSellablePrototype _IsItemIdSellable = WarcraftIII.Jass.GetNative("IsItemIdSellable").ToDelegate<IsItemIdSellablePrototype>();
        public Boolean IsItemIdSellable(JassInteger itemId)
        {
            return _IsItemIdSellable(itemId);
        }

        //native IsItemIdPawnable takes integer itemId returns boolean
        private delegate JassBoolean IsItemIdPawnablePrototype(JassInteger itemId);
        private IsItemIdPawnablePrototype _IsItemIdPawnable = WarcraftIII.Jass.GetNative("IsItemIdPawnable").ToDelegate<IsItemIdPawnablePrototype>();
        public Boolean IsItemIdPawnable(JassInteger itemId)
        {
            return _IsItemIdPawnable(itemId);
        }

        //native EnumItemsInRect takes rect r, boolexpr filter, code actionFunc returns nothing
        private delegate void EnumItemsInRectPrototype(JassRect r, JassBooleanExpression filter, JassCode actionFunc);
        private EnumItemsInRectPrototype _EnumItemsInRect = WarcraftIII.Jass.GetNative("EnumItemsInRect").ToDelegate<EnumItemsInRectPrototype>();
        public void EnumItemsInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            _EnumItemsInRect(r, filter, actionFunc);
        }

        //native GetItemLevel takes item whichItem returns integer
        private delegate JassInteger GetItemLevelPrototype(JassItem whichItem);
        private GetItemLevelPrototype _GetItemLevel = WarcraftIII.Jass.GetNative("GetItemLevel").ToDelegate<GetItemLevelPrototype>();
        public JassInteger GetItemLevel(JassItem whichItem)
        {
            return _GetItemLevel(whichItem);
        }

        //native GetItemType takes item whichItem returns itemtype
        private delegate JassItemType GetItemTypePrototype(JassItem whichItem);
        private GetItemTypePrototype _GetItemType = WarcraftIII.Jass.GetNative("GetItemType").ToDelegate<GetItemTypePrototype>();
        public JassItemType GetItemType(JassItem whichItem)
        {
            return _GetItemType(whichItem);
        }

        //native SetItemDropID takes item whichItem, integer unitId returns nothing
        private delegate void SetItemDropIDPrototype(JassItem whichItem, JassUnitId unitId);
        private SetItemDropIDPrototype _SetItemDropID = WarcraftIII.Jass.GetNative("SetItemDropID").ToDelegate<SetItemDropIDPrototype>();
        public void SetItemDropID(JassItem whichItem, JassUnitId unitId)
        {
            _SetItemDropID(whichItem, unitId);
        }

        //native GetItemName takes item whichItem returns string
        private delegate JassStringRet GetItemNamePrototype(JassItem whichItem);
        private GetItemNamePrototype _GetItemName = WarcraftIII.Jass.GetNative("GetItemName").ToDelegate<GetItemNamePrototype>();
        public String GetItemName(JassItem whichItem)
        {
            return _GetItemName(whichItem);
        }

        //native GetItemCharges takes item whichItem returns integer
        private delegate JassInteger GetItemChargesPrototype(JassItem whichItem);
        private GetItemChargesPrototype _GetItemCharges = WarcraftIII.Jass.GetNative("GetItemCharges").ToDelegate<GetItemChargesPrototype>();
        public JassInteger GetItemCharges(JassItem whichItem)
        {
            return _GetItemCharges(whichItem);
        }

        //native SetItemCharges takes item whichItem, integer charges returns nothing
        private delegate void SetItemChargesPrototype(JassItem whichItem, JassInteger charges);
        private SetItemChargesPrototype _SetItemCharges = WarcraftIII.Jass.GetNative("SetItemCharges").ToDelegate<SetItemChargesPrototype>();
        public void SetItemCharges(JassItem whichItem, JassInteger charges)
        {
            _SetItemCharges(whichItem, charges);
        }

        //native GetItemUserData takes item whichItem returns integer
        private delegate JassInteger GetItemUserDataPrototype(JassItem whichItem);
        private GetItemUserDataPrototype _GetItemUserData = WarcraftIII.Jass.GetNative("GetItemUserData").ToDelegate<GetItemUserDataPrototype>();
        public JassInteger GetItemUserData(JassItem whichItem)
        {
            return _GetItemUserData(whichItem);
        }

        //native SetItemUserData takes item whichItem, integer data returns nothing
        private delegate void SetItemUserDataPrototype(JassItem whichItem, JassInteger data);
        private SetItemUserDataPrototype _SetItemUserData = WarcraftIII.Jass.GetNative("SetItemUserData").ToDelegate<SetItemUserDataPrototype>();
        public void SetItemUserData(JassItem whichItem, JassInteger data)
        {
            _SetItemUserData(whichItem, data);
        }

        //native CreateUnit takes player id, integer unitid, real x, real y, real face returns unit
        private delegate JassUnit CreateUnitPrototype(JassPlayer id, JassUnitId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private CreateUnitPrototype _CreateUnit = WarcraftIII.Jass.GetNative("CreateUnit").ToDelegate<CreateUnitPrototype>();
        public JassUnit CreateUnit(JassPlayer id, JassUnitId unitid, Single x, Single y, Single face)
        {
            return _CreateUnit(id, unitid, x, y, face);
        }

        //native CreateUnitByName takes player whichPlayer, string unitname, real x, real y, real face returns unit
        private delegate JassUnit CreateUnitByNamePrototype(JassPlayer whichPlayer, JassStringArg unitname, JassRealArg x, JassRealArg y, JassRealArg face);
        private CreateUnitByNamePrototype _CreateUnitByName = WarcraftIII.Jass.GetNative("CreateUnitByName").ToDelegate<CreateUnitByNamePrototype>();
        public JassUnit CreateUnitByName(JassPlayer whichPlayer, String unitname, Single x, Single y, Single face)
        {
            return _CreateUnitByName(whichPlayer, unitname, x, y, face);
        }

        //native CreateUnitAtLoc takes player id, integer unitid, location whichLocation, real face returns unit
        private delegate JassUnit CreateUnitAtLocPrototype(JassPlayer id, JassUnitId unitid, JassLocation whichLocation, JassRealArg face);
        private CreateUnitAtLocPrototype _CreateUnitAtLoc = WarcraftIII.Jass.GetNative("CreateUnitAtLoc").ToDelegate<CreateUnitAtLocPrototype>();
        public JassUnit CreateUnitAtLoc(JassPlayer id, JassUnitId unitid, JassLocation whichLocation, Single face)
        {
            return _CreateUnitAtLoc(id, unitid, whichLocation, face);
        }

        //native CreateUnitAtLocByName takes player id, string unitname, location whichLocation, real face returns unit
        private delegate JassUnit CreateUnitAtLocByNamePrototype(JassPlayer id, JassStringArg unitname, JassLocation whichLocation, JassRealArg face);
        private CreateUnitAtLocByNamePrototype _CreateUnitAtLocByName = WarcraftIII.Jass.GetNative("CreateUnitAtLocByName").ToDelegate<CreateUnitAtLocByNamePrototype>();
        public JassUnit CreateUnitAtLocByName(JassPlayer id, String unitname, JassLocation whichLocation, Single face)
        {
            return _CreateUnitAtLocByName(id, unitname, whichLocation, face);
        }

        //native CreateCorpse takes player whichPlayer, integer unitid, real x, real y, real face returns unit
        private delegate JassUnit CreateCorpsePrototype(JassPlayer whichPlayer, JassUnitId unitid, JassRealArg x, JassRealArg y, JassRealArg face);
        private CreateCorpsePrototype _CreateCorpse = WarcraftIII.Jass.GetNative("CreateCorpse").ToDelegate<CreateCorpsePrototype>();
        public JassUnit CreateCorpse(JassPlayer whichPlayer, JassUnitId unitid, Single x, Single y, Single face)
        {
            return _CreateCorpse(whichPlayer, unitid, x, y, face);
        }

        //native KillUnit takes unit whichUnit returns nothing
        private delegate void KillUnitPrototype(JassUnit whichUnit);
        private KillUnitPrototype _KillUnit = WarcraftIII.Jass.GetNative("KillUnit").ToDelegate<KillUnitPrototype>();
        public void KillUnit(JassUnit whichUnit)
        {
            _KillUnit(whichUnit);
        }

        //native RemoveUnit takes unit whichUnit returns nothing
        private delegate void RemoveUnitPrototype(JassUnit whichUnit);
        private RemoveUnitPrototype _RemoveUnit = WarcraftIII.Jass.GetNative("RemoveUnit").ToDelegate<RemoveUnitPrototype>();
        public void RemoveUnit(JassUnit whichUnit)
        {
            _RemoveUnit(whichUnit);
        }

        //native ShowUnit takes unit whichUnit, boolean show returns nothing
        private delegate void ShowUnitPrototype(JassUnit whichUnit, JassBoolean show);
        private ShowUnitPrototype _ShowUnit = WarcraftIII.Jass.GetNative("ShowUnit").ToDelegate<ShowUnitPrototype>();
        public void ShowUnit(JassUnit whichUnit, Boolean show)
        {
            _ShowUnit(whichUnit, show);
        }

        //native SetUnitState takes unit whichUnit, unitstate whichUnitState, real newVal returns nothing
        private delegate void SetUnitStatePrototype(JassUnit whichUnit, JassUnitState whichUnitState, JassRealArg newVal);
        private SetUnitStatePrototype _SetUnitState = WarcraftIII.Jass.GetNative("SetUnitState").ToDelegate<SetUnitStatePrototype>();
        public void SetUnitState(JassUnit whichUnit, JassUnitState whichUnitState, Single newVal)
        {
            _SetUnitState(whichUnit, whichUnitState, newVal);
        }

        //native SetUnitX takes unit whichUnit, real newX returns nothing
        private delegate void SetUnitXPrototype(JassUnit whichUnit, JassRealArg newX);
        private SetUnitXPrototype _SetUnitX = WarcraftIII.Jass.GetNative("SetUnitX").ToDelegate<SetUnitXPrototype>();
        public void SetUnitX(JassUnit whichUnit, Single newX)
        {
            _SetUnitX(whichUnit, newX);
        }

        //native SetUnitY takes unit whichUnit, real newY returns nothing
        private delegate void SetUnitYPrototype(JassUnit whichUnit, JassRealArg newY);
        private SetUnitYPrototype _SetUnitY = WarcraftIII.Jass.GetNative("SetUnitY").ToDelegate<SetUnitYPrototype>();
        public void SetUnitY(JassUnit whichUnit, Single newY)
        {
            _SetUnitY(whichUnit, newY);
        }

        //native SetUnitPosition takes unit whichUnit, real newX, real newY returns nothing
        private delegate void SetUnitPositionPrototype(JassUnit whichUnit, JassRealArg newX, JassRealArg newY);
        private SetUnitPositionPrototype _SetUnitPosition = WarcraftIII.Jass.GetNative("SetUnitPosition").ToDelegate<SetUnitPositionPrototype>();
        public void SetUnitPosition(JassUnit whichUnit, Single newX, Single newY)
        {
            _SetUnitPosition(whichUnit, newX, newY);
        }

        //native SetUnitPositionLoc takes unit whichUnit, location whichLocation returns nothing
        private delegate void SetUnitPositionLocPrototype(JassUnit whichUnit, JassLocation whichLocation);
        private SetUnitPositionLocPrototype _SetUnitPositionLoc = WarcraftIII.Jass.GetNative("SetUnitPositionLoc").ToDelegate<SetUnitPositionLocPrototype>();
        public void SetUnitPositionLoc(JassUnit whichUnit, JassLocation whichLocation)
        {
            _SetUnitPositionLoc(whichUnit, whichLocation);
        }

        //native SetUnitFacing takes unit whichUnit, real facingAngle returns nothing
        private delegate void SetUnitFacingPrototype(JassUnit whichUnit, JassRealArg facingAngle);
        private SetUnitFacingPrototype _SetUnitFacing = WarcraftIII.Jass.GetNative("SetUnitFacing").ToDelegate<SetUnitFacingPrototype>();
        public void SetUnitFacing(JassUnit whichUnit, Single facingAngle)
        {
            _SetUnitFacing(whichUnit, facingAngle);
        }

        //native SetUnitFacingTimed takes unit whichUnit, real facingAngle, real duration returns nothing
        private delegate void SetUnitFacingTimedPrototype(JassUnit whichUnit, JassRealArg facingAngle, JassRealArg duration);
        private SetUnitFacingTimedPrototype _SetUnitFacingTimed = WarcraftIII.Jass.GetNative("SetUnitFacingTimed").ToDelegate<SetUnitFacingTimedPrototype>();
        public void SetUnitFacingTimed(JassUnit whichUnit, Single facingAngle, Single duration)
        {
            _SetUnitFacingTimed(whichUnit, facingAngle, duration);
        }

        //native SetUnitMoveSpeed takes unit whichUnit, real newSpeed returns nothing
        private delegate void SetUnitMoveSpeedPrototype(JassUnit whichUnit, JassRealArg newSpeed);
        private SetUnitMoveSpeedPrototype _SetUnitMoveSpeed = WarcraftIII.Jass.GetNative("SetUnitMoveSpeed").ToDelegate<SetUnitMoveSpeedPrototype>();
        public void SetUnitMoveSpeed(JassUnit whichUnit, Single newSpeed)
        {
            _SetUnitMoveSpeed(whichUnit, newSpeed);
        }

        //native SetUnitFlyHeight takes unit whichUnit, real newHeight, real rate returns nothing
        private delegate void SetUnitFlyHeightPrototype(JassUnit whichUnit, JassRealArg newHeight, JassRealArg rate);
        private SetUnitFlyHeightPrototype _SetUnitFlyHeight = WarcraftIII.Jass.GetNative("SetUnitFlyHeight").ToDelegate<SetUnitFlyHeightPrototype>();
        public void SetUnitFlyHeight(JassUnit whichUnit, Single newHeight, Single rate)
        {
            _SetUnitFlyHeight(whichUnit, newHeight, rate);
        }

        //native SetUnitTurnSpeed takes unit whichUnit, real newTurnSpeed returns nothing
        private delegate void SetUnitTurnSpeedPrototype(JassUnit whichUnit, JassRealArg newTurnSpeed);
        private SetUnitTurnSpeedPrototype _SetUnitTurnSpeed = WarcraftIII.Jass.GetNative("SetUnitTurnSpeed").ToDelegate<SetUnitTurnSpeedPrototype>();
        public void SetUnitTurnSpeed(JassUnit whichUnit, Single newTurnSpeed)
        {
            _SetUnitTurnSpeed(whichUnit, newTurnSpeed);
        }

        //native SetUnitPropWindow takes unit whichUnit, real newPropWindowAngle returns nothing
        private delegate void SetUnitPropWindowPrototype(JassUnit whichUnit, JassRealArg newPropWindowAngle);
        private SetUnitPropWindowPrototype _SetUnitPropWindow = WarcraftIII.Jass.GetNative("SetUnitPropWindow").ToDelegate<SetUnitPropWindowPrototype>();
        public void SetUnitPropWindow(JassUnit whichUnit, Single newPropWindowAngle)
        {
            _SetUnitPropWindow(whichUnit, newPropWindowAngle);
        }

        //native SetUnitAcquireRange takes unit whichUnit, real newAcquireRange returns nothing
        private delegate void SetUnitAcquireRangePrototype(JassUnit whichUnit, JassRealArg newAcquireRange);
        private SetUnitAcquireRangePrototype _SetUnitAcquireRange = WarcraftIII.Jass.GetNative("SetUnitAcquireRange").ToDelegate<SetUnitAcquireRangePrototype>();
        public void SetUnitAcquireRange(JassUnit whichUnit, Single newAcquireRange)
        {
            _SetUnitAcquireRange(whichUnit, newAcquireRange);
        }

        //native SetUnitCreepGuard takes unit whichUnit, boolean creepGuard returns nothing
        private delegate void SetUnitCreepGuardPrototype(JassUnit whichUnit, JassBoolean creepGuard);
        private SetUnitCreepGuardPrototype _SetUnitCreepGuard = WarcraftIII.Jass.GetNative("SetUnitCreepGuard").ToDelegate<SetUnitCreepGuardPrototype>();
        public void SetUnitCreepGuard(JassUnit whichUnit, Boolean creepGuard)
        {
            _SetUnitCreepGuard(whichUnit, creepGuard);
        }

        //native GetUnitAcquireRange takes unit whichUnit returns real
        private delegate JassRealRet GetUnitAcquireRangePrototype(JassUnit whichUnit);
        private GetUnitAcquireRangePrototype _GetUnitAcquireRange = WarcraftIII.Jass.GetNative("GetUnitAcquireRange").ToDelegate<GetUnitAcquireRangePrototype>();
        public Single GetUnitAcquireRange(JassUnit whichUnit)
        {
            return _GetUnitAcquireRange(whichUnit);
        }

        //native GetUnitTurnSpeed takes unit whichUnit returns real
        private delegate JassRealRet GetUnitTurnSpeedPrototype(JassUnit whichUnit);
        private GetUnitTurnSpeedPrototype _GetUnitTurnSpeed = WarcraftIII.Jass.GetNative("GetUnitTurnSpeed").ToDelegate<GetUnitTurnSpeedPrototype>();
        public Single GetUnitTurnSpeed(JassUnit whichUnit)
        {
            return _GetUnitTurnSpeed(whichUnit);
        }

        //native GetUnitPropWindow takes unit whichUnit returns real
        private delegate JassRealRet GetUnitPropWindowPrototype(JassUnit whichUnit);
        private GetUnitPropWindowPrototype _GetUnitPropWindow = WarcraftIII.Jass.GetNative("GetUnitPropWindow").ToDelegate<GetUnitPropWindowPrototype>();
        public Single GetUnitPropWindow(JassUnit whichUnit)
        {
            return _GetUnitPropWindow(whichUnit);
        }

        //native GetUnitFlyHeight takes unit whichUnit returns real
        private delegate JassRealRet GetUnitFlyHeightPrototype(JassUnit whichUnit);
        private GetUnitFlyHeightPrototype _GetUnitFlyHeight = WarcraftIII.Jass.GetNative("GetUnitFlyHeight").ToDelegate<GetUnitFlyHeightPrototype>();
        public Single GetUnitFlyHeight(JassUnit whichUnit)
        {
            return _GetUnitFlyHeight(whichUnit);
        }

        //native GetUnitDefaultAcquireRange takes unit whichUnit returns real
        private delegate JassRealRet GetUnitDefaultAcquireRangePrototype(JassUnit whichUnit);
        private GetUnitDefaultAcquireRangePrototype _GetUnitDefaultAcquireRange = WarcraftIII.Jass.GetNative("GetUnitDefaultAcquireRange").ToDelegate<GetUnitDefaultAcquireRangePrototype>();
        public Single GetUnitDefaultAcquireRange(JassUnit whichUnit)
        {
            return _GetUnitDefaultAcquireRange(whichUnit);
        }

        //native GetUnitDefaultTurnSpeed takes unit whichUnit returns real
        private delegate JassRealRet GetUnitDefaultTurnSpeedPrototype(JassUnit whichUnit);
        private GetUnitDefaultTurnSpeedPrototype _GetUnitDefaultTurnSpeed = WarcraftIII.Jass.GetNative("GetUnitDefaultTurnSpeed").ToDelegate<GetUnitDefaultTurnSpeedPrototype>();
        public Single GetUnitDefaultTurnSpeed(JassUnit whichUnit)
        {
            return _GetUnitDefaultTurnSpeed(whichUnit);
        }

        //native GetUnitDefaultPropWindow takes unit whichUnit returns real
        private delegate JassRealRet GetUnitDefaultPropWindowPrototype(JassUnit whichUnit);
        private GetUnitDefaultPropWindowPrototype _GetUnitDefaultPropWindow = WarcraftIII.Jass.GetNative("GetUnitDefaultPropWindow").ToDelegate<GetUnitDefaultPropWindowPrototype>();
        public Single GetUnitDefaultPropWindow(JassUnit whichUnit)
        {
            return _GetUnitDefaultPropWindow(whichUnit);
        }

        //native GetUnitDefaultFlyHeight takes unit whichUnit returns real
        private delegate JassRealRet GetUnitDefaultFlyHeightPrototype(JassUnit whichUnit);
        private GetUnitDefaultFlyHeightPrototype _GetUnitDefaultFlyHeight = WarcraftIII.Jass.GetNative("GetUnitDefaultFlyHeight").ToDelegate<GetUnitDefaultFlyHeightPrototype>();
        public Single GetUnitDefaultFlyHeight(JassUnit whichUnit)
        {
            return _GetUnitDefaultFlyHeight(whichUnit);
        }

        //native SetUnitOwner takes unit whichUnit, player whichPlayer, boolean changeColor returns nothing
        private delegate void SetUnitOwnerPrototype(JassUnit whichUnit, JassPlayer whichPlayer, JassBoolean changeColor);
        private SetUnitOwnerPrototype _SetUnitOwner = WarcraftIII.Jass.GetNative("SetUnitOwner").ToDelegate<SetUnitOwnerPrototype>();
        public void SetUnitOwner(JassUnit whichUnit, JassPlayer whichPlayer, Boolean changeColor)
        {
            _SetUnitOwner(whichUnit, whichPlayer, changeColor);
        }

        //native SetUnitColor takes unit whichUnit, playercolor whichColor returns nothing
        private delegate void SetUnitColorPrototype(JassUnit whichUnit, JassPlayerColor whichColor);
        private SetUnitColorPrototype _SetUnitColor = WarcraftIII.Jass.GetNative("SetUnitColor").ToDelegate<SetUnitColorPrototype>();
        public void SetUnitColor(JassUnit whichUnit, JassPlayerColor whichColor)
        {
            _SetUnitColor(whichUnit, whichColor);
        }

        //native SetUnitScale takes unit whichUnit, real scaleX, real scaleY, real scaleZ returns nothing
        private delegate void SetUnitScalePrototype(JassUnit whichUnit, JassRealArg scaleX, JassRealArg scaleY, JassRealArg scaleZ);
        private SetUnitScalePrototype _SetUnitScale = WarcraftIII.Jass.GetNative("SetUnitScale").ToDelegate<SetUnitScalePrototype>();
        public void SetUnitScale(JassUnit whichUnit, Single scaleX, Single scaleY, Single scaleZ)
        {
            _SetUnitScale(whichUnit, scaleX, scaleY, scaleZ);
        }

        //native SetUnitTimeScale takes unit whichUnit, real timeScale returns nothing
        private delegate void SetUnitTimeScalePrototype(JassUnit whichUnit, JassRealArg timeScale);
        private SetUnitTimeScalePrototype _SetUnitTimeScale = WarcraftIII.Jass.GetNative("SetUnitTimeScale").ToDelegate<SetUnitTimeScalePrototype>();
        public void SetUnitTimeScale(JassUnit whichUnit, Single timeScale)
        {
            _SetUnitTimeScale(whichUnit, timeScale);
        }

        //native SetUnitBlendTime takes unit whichUnit, real blendTime returns nothing
        private delegate void SetUnitBlendTimePrototype(JassUnit whichUnit, JassRealArg blendTime);
        private SetUnitBlendTimePrototype _SetUnitBlendTime = WarcraftIII.Jass.GetNative("SetUnitBlendTime").ToDelegate<SetUnitBlendTimePrototype>();
        public void SetUnitBlendTime(JassUnit whichUnit, Single blendTime)
        {
            _SetUnitBlendTime(whichUnit, blendTime);
        }

        //native SetUnitVertexColor takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void SetUnitVertexColorPrototype(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private SetUnitVertexColorPrototype _SetUnitVertexColor = WarcraftIII.Jass.GetNative("SetUnitVertexColor").ToDelegate<SetUnitVertexColorPrototype>();
        public void SetUnitVertexColor(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _SetUnitVertexColor(whichUnit, red, green, blue, alpha);
        }

        //native QueueUnitAnimation takes unit whichUnit, string whichAnimation returns nothing
        private delegate void QueueUnitAnimationPrototype(JassUnit whichUnit, JassStringArg whichAnimation);
        private QueueUnitAnimationPrototype _QueueUnitAnimation = WarcraftIII.Jass.GetNative("QueueUnitAnimation").ToDelegate<QueueUnitAnimationPrototype>();
        public void QueueUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            _QueueUnitAnimation(whichUnit, whichAnimation);
        }

        //native SetUnitAnimation takes unit whichUnit, string whichAnimation returns nothing
        private delegate void SetUnitAnimationPrototype(JassUnit whichUnit, JassStringArg whichAnimation);
        private SetUnitAnimationPrototype _SetUnitAnimation = WarcraftIII.Jass.GetNative("SetUnitAnimation").ToDelegate<SetUnitAnimationPrototype>();
        public void SetUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            _SetUnitAnimation(whichUnit, whichAnimation);
        }

        //native SetUnitAnimationByIndex takes unit whichUnit, integer whichAnimation returns nothing
        private delegate void SetUnitAnimationByIndexPrototype(JassUnit whichUnit, JassInteger whichAnimation);
        private SetUnitAnimationByIndexPrototype _SetUnitAnimationByIndex = WarcraftIII.Jass.GetNative("SetUnitAnimationByIndex").ToDelegate<SetUnitAnimationByIndexPrototype>();
        public void SetUnitAnimationByIndex(JassUnit whichUnit, JassInteger whichAnimation)
        {
            _SetUnitAnimationByIndex(whichUnit, whichAnimation);
        }

        //native SetUnitAnimationWithRarity takes unit whichUnit, string whichAnimation, raritycontrol rarity returns nothing
        private delegate void SetUnitAnimationWithRarityPrototype(JassUnit whichUnit, JassStringArg whichAnimation, JassRarityControl rarity);
        private SetUnitAnimationWithRarityPrototype _SetUnitAnimationWithRarity = WarcraftIII.Jass.GetNative("SetUnitAnimationWithRarity").ToDelegate<SetUnitAnimationWithRarityPrototype>();
        public void SetUnitAnimationWithRarity(JassUnit whichUnit, String whichAnimation, JassRarityControl rarity)
        {
            _SetUnitAnimationWithRarity(whichUnit, whichAnimation, rarity);
        }

        //native AddUnitAnimationProperties takes unit whichUnit, string animProperties, boolean add returns nothing
        private delegate void AddUnitAnimationPropertiesPrototype(JassUnit whichUnit, JassStringArg animProperties, JassBoolean add);
        private AddUnitAnimationPropertiesPrototype _AddUnitAnimationProperties = WarcraftIII.Jass.GetNative("AddUnitAnimationProperties").ToDelegate<AddUnitAnimationPropertiesPrototype>();
        public void AddUnitAnimationProperties(JassUnit whichUnit, String animProperties, Boolean add)
        {
            _AddUnitAnimationProperties(whichUnit, animProperties, add);
        }

        //native SetUnitLookAt takes unit whichUnit, string whichBone, unit lookAtTarget, real offsetX, real offsetY, real offsetZ returns nothing
        private delegate void SetUnitLookAtPrototype(JassUnit whichUnit, JassStringArg whichBone, JassUnit lookAtTarget, JassRealArg offsetX, JassRealArg offsetY, JassRealArg offsetZ);
        private SetUnitLookAtPrototype _SetUnitLookAt = WarcraftIII.Jass.GetNative("SetUnitLookAt").ToDelegate<SetUnitLookAtPrototype>();
        public void SetUnitLookAt(JassUnit whichUnit, String whichBone, JassUnit lookAtTarget, Single offsetX, Single offsetY, Single offsetZ)
        {
            _SetUnitLookAt(whichUnit, whichBone, lookAtTarget, offsetX, offsetY, offsetZ);
        }

        //native ResetUnitLookAt takes unit whichUnit returns nothing
        private delegate void ResetUnitLookAtPrototype(JassUnit whichUnit);
        private ResetUnitLookAtPrototype _ResetUnitLookAt = WarcraftIII.Jass.GetNative("ResetUnitLookAt").ToDelegate<ResetUnitLookAtPrototype>();
        public void ResetUnitLookAt(JassUnit whichUnit)
        {
            _ResetUnitLookAt(whichUnit);
        }

        //native SetUnitRescuable takes unit whichUnit, player byWhichPlayer, boolean flag returns nothing
        private delegate void SetUnitRescuablePrototype(JassUnit whichUnit, JassPlayer byWhichPlayer, JassBoolean flag);
        private SetUnitRescuablePrototype _SetUnitRescuable = WarcraftIII.Jass.GetNative("SetUnitRescuable").ToDelegate<SetUnitRescuablePrototype>();
        public void SetUnitRescuable(JassUnit whichUnit, JassPlayer byWhichPlayer, Boolean flag)
        {
            _SetUnitRescuable(whichUnit, byWhichPlayer, flag);
        }

        //native SetUnitRescueRange takes unit whichUnit, real range returns nothing
        private delegate void SetUnitRescueRangePrototype(JassUnit whichUnit, JassRealArg range);
        private SetUnitRescueRangePrototype _SetUnitRescueRange = WarcraftIII.Jass.GetNative("SetUnitRescueRange").ToDelegate<SetUnitRescueRangePrototype>();
        public void SetUnitRescueRange(JassUnit whichUnit, Single range)
        {
            _SetUnitRescueRange(whichUnit, range);
        }

        //native SetHeroStr takes unit whichHero, integer newStr, boolean permanent returns nothing
        private delegate void SetHeroStrPrototype(JassUnit whichHero, JassInteger newStr, JassBoolean permanent);
        private SetHeroStrPrototype _SetHeroStr = WarcraftIII.Jass.GetNative("SetHeroStr").ToDelegate<SetHeroStrPrototype>();
        public void SetHeroStr(JassUnit whichHero, JassInteger newStr, Boolean permanent)
        {
            _SetHeroStr(whichHero, newStr, permanent);
        }

        //native SetHeroAgi takes unit whichHero, integer newAgi, boolean permanent returns nothing
        private delegate void SetHeroAgiPrototype(JassUnit whichHero, JassInteger newAgi, JassBoolean permanent);
        private SetHeroAgiPrototype _SetHeroAgi = WarcraftIII.Jass.GetNative("SetHeroAgi").ToDelegate<SetHeroAgiPrototype>();
        public void SetHeroAgi(JassUnit whichHero, JassInteger newAgi, Boolean permanent)
        {
            _SetHeroAgi(whichHero, newAgi, permanent);
        }

        //native SetHeroInt takes unit whichHero, integer newInt, boolean permanent returns nothing
        private delegate void SetHeroIntPrototype(JassUnit whichHero, JassInteger newInt, JassBoolean permanent);
        private SetHeroIntPrototype _SetHeroInt = WarcraftIII.Jass.GetNative("SetHeroInt").ToDelegate<SetHeroIntPrototype>();
        public void SetHeroInt(JassUnit whichHero, JassInteger newInt, Boolean permanent)
        {
            _SetHeroInt(whichHero, newInt, permanent);
        }

        //native GetHeroStr takes unit whichHero, boolean includeBonuses returns integer
        private delegate JassInteger GetHeroStrPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private GetHeroStrPrototype _GetHeroStr = WarcraftIII.Jass.GetNative("GetHeroStr").ToDelegate<GetHeroStrPrototype>();
        public JassInteger GetHeroStr(JassUnit whichHero, Boolean includeBonuses)
        {
            return _GetHeroStr(whichHero, includeBonuses);
        }

        //native GetHeroAgi takes unit whichHero, boolean includeBonuses returns integer
        private delegate JassInteger GetHeroAgiPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private GetHeroAgiPrototype _GetHeroAgi = WarcraftIII.Jass.GetNative("GetHeroAgi").ToDelegate<GetHeroAgiPrototype>();
        public JassInteger GetHeroAgi(JassUnit whichHero, Boolean includeBonuses)
        {
            return _GetHeroAgi(whichHero, includeBonuses);
        }

        //native GetHeroInt takes unit whichHero, boolean includeBonuses returns integer
        private delegate JassInteger GetHeroIntPrototype(JassUnit whichHero, JassBoolean includeBonuses);
        private GetHeroIntPrototype _GetHeroInt = WarcraftIII.Jass.GetNative("GetHeroInt").ToDelegate<GetHeroIntPrototype>();
        public JassInteger GetHeroInt(JassUnit whichHero, Boolean includeBonuses)
        {
            return _GetHeroInt(whichHero, includeBonuses);
        }

        //native UnitStripHeroLevel takes unit whichHero, integer howManyLevels returns boolean
        private delegate JassBoolean UnitStripHeroLevelPrototype(JassUnit whichHero, JassInteger howManyLevels);
        private UnitStripHeroLevelPrototype _UnitStripHeroLevel = WarcraftIII.Jass.GetNative("UnitStripHeroLevel").ToDelegate<UnitStripHeroLevelPrototype>();
        public Boolean UnitStripHeroLevel(JassUnit whichHero, JassInteger howManyLevels)
        {
            return _UnitStripHeroLevel(whichHero, howManyLevels);
        }

        //native GetHeroXP takes unit whichHero returns integer
        private delegate JassInteger GetHeroXPPrototype(JassUnit whichHero);
        private GetHeroXPPrototype _GetHeroXP = WarcraftIII.Jass.GetNative("GetHeroXP").ToDelegate<GetHeroXPPrototype>();
        public JassInteger GetHeroXP(JassUnit whichHero)
        {
            return _GetHeroXP(whichHero);
        }

        //native SetHeroXP takes unit whichHero, integer newXpVal, boolean showEyeCandy returns nothing
        private delegate void SetHeroXPPrototype(JassUnit whichHero, JassInteger newXpVal, JassBoolean showEyeCandy);
        private SetHeroXPPrototype _SetHeroXP = WarcraftIII.Jass.GetNative("SetHeroXP").ToDelegate<SetHeroXPPrototype>();
        public void SetHeroXP(JassUnit whichHero, JassInteger newXpVal, Boolean showEyeCandy)
        {
            _SetHeroXP(whichHero, newXpVal, showEyeCandy);
        }

        //native GetHeroSkillPoints takes unit whichHero returns integer
        private delegate JassInteger GetHeroSkillPointsPrototype(JassUnit whichHero);
        private GetHeroSkillPointsPrototype _GetHeroSkillPoints = WarcraftIII.Jass.GetNative("GetHeroSkillPoints").ToDelegate<GetHeroSkillPointsPrototype>();
        public JassInteger GetHeroSkillPoints(JassUnit whichHero)
        {
            return _GetHeroSkillPoints(whichHero);
        }

        //native UnitModifySkillPoints takes unit whichHero, integer skillPointDelta returns boolean
        private delegate JassBoolean UnitModifySkillPointsPrototype(JassUnit whichHero, JassInteger skillPointDelta);
        private UnitModifySkillPointsPrototype _UnitModifySkillPoints = WarcraftIII.Jass.GetNative("UnitModifySkillPoints").ToDelegate<UnitModifySkillPointsPrototype>();
        public Boolean UnitModifySkillPoints(JassUnit whichHero, JassInteger skillPointDelta)
        {
            return _UnitModifySkillPoints(whichHero, skillPointDelta);
        }

        //native AddHeroXP takes unit whichHero, integer xpToAdd, boolean showEyeCandy returns nothing
        private delegate void AddHeroXPPrototype(JassUnit whichHero, JassInteger xpToAdd, JassBoolean showEyeCandy);
        private AddHeroXPPrototype _AddHeroXP = WarcraftIII.Jass.GetNative("AddHeroXP").ToDelegate<AddHeroXPPrototype>();
        public void AddHeroXP(JassUnit whichHero, JassInteger xpToAdd, Boolean showEyeCandy)
        {
            _AddHeroXP(whichHero, xpToAdd, showEyeCandy);
        }

        //native SetHeroLevel takes unit whichHero, integer level, boolean showEyeCandy returns nothing
        private delegate void SetHeroLevelPrototype(JassUnit whichHero, JassInteger level, JassBoolean showEyeCandy);
        private SetHeroLevelPrototype _SetHeroLevel = WarcraftIII.Jass.GetNative("SetHeroLevel").ToDelegate<SetHeroLevelPrototype>();
        public void SetHeroLevel(JassUnit whichHero, JassInteger level, Boolean showEyeCandy)
        {
            _SetHeroLevel(whichHero, level, showEyeCandy);
        }

        //native GetHeroLevel takes unit whichHero returns integer
        private delegate JassInteger GetHeroLevelPrototype(JassUnit whichHero);
        private GetHeroLevelPrototype _GetHeroLevel = WarcraftIII.Jass.GetNative("GetHeroLevel").ToDelegate<GetHeroLevelPrototype>();
        public JassInteger GetHeroLevel(JassUnit whichHero)
        {
            return _GetHeroLevel(whichHero);
        }

        //native GetUnitLevel takes unit whichUnit returns integer
        private delegate JassInteger GetUnitLevelPrototype(JassUnit whichUnit);
        private GetUnitLevelPrototype _GetUnitLevel = WarcraftIII.Jass.GetNative("GetUnitLevel").ToDelegate<GetUnitLevelPrototype>();
        public JassInteger GetUnitLevel(JassUnit whichUnit)
        {
            return _GetUnitLevel(whichUnit);
        }

        //native GetHeroProperName takes unit whichHero returns string
        private delegate JassStringRet GetHeroProperNamePrototype(JassUnit whichHero);
        private GetHeroProperNamePrototype _GetHeroProperName = WarcraftIII.Jass.GetNative("GetHeroProperName").ToDelegate<GetHeroProperNamePrototype>();
        public String GetHeroProperName(JassUnit whichHero)
        {
            return _GetHeroProperName(whichHero);
        }

        //native SuspendHeroXP takes unit whichHero, boolean flag returns nothing
        private delegate void SuspendHeroXPPrototype(JassUnit whichHero, JassBoolean flag);
        private SuspendHeroXPPrototype _SuspendHeroXP = WarcraftIII.Jass.GetNative("SuspendHeroXP").ToDelegate<SuspendHeroXPPrototype>();
        public void SuspendHeroXP(JassUnit whichHero, Boolean flag)
        {
            _SuspendHeroXP(whichHero, flag);
        }

        //native IsSuspendedXP takes unit whichHero returns boolean
        private delegate JassBoolean IsSuspendedXPPrototype(JassUnit whichHero);
        private IsSuspendedXPPrototype _IsSuspendedXP = WarcraftIII.Jass.GetNative("IsSuspendedXP").ToDelegate<IsSuspendedXPPrototype>();
        public Boolean IsSuspendedXP(JassUnit whichHero)
        {
            return _IsSuspendedXP(whichHero);
        }

        //native SelectHeroSkill takes unit whichHero, integer abilcode returns nothing
        private delegate void SelectHeroSkillPrototype(JassUnit whichHero, JassInteger abilcode);
        private SelectHeroSkillPrototype _SelectHeroSkill = WarcraftIII.Jass.GetNative("SelectHeroSkill").ToDelegate<SelectHeroSkillPrototype>();
        public void SelectHeroSkill(JassUnit whichHero, JassInteger abilcode)
        {
            _SelectHeroSkill(whichHero, abilcode);
        }

        //native GetUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        private delegate JassInteger GetUnitAbilityLevelPrototype(JassUnit whichUnit, JassInteger abilcode);
        private GetUnitAbilityLevelPrototype _GetUnitAbilityLevel = WarcraftIII.Jass.GetNative("GetUnitAbilityLevel").ToDelegate<GetUnitAbilityLevelPrototype>();
        public JassInteger GetUnitAbilityLevel(JassUnit whichUnit, JassInteger abilcode)
        {
            return _GetUnitAbilityLevel(whichUnit, abilcode);
        }

        //native DecUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        private delegate JassInteger DecUnitAbilityLevelPrototype(JassUnit whichUnit, JassInteger abilcode);
        private DecUnitAbilityLevelPrototype _DecUnitAbilityLevel = WarcraftIII.Jass.GetNative("DecUnitAbilityLevel").ToDelegate<DecUnitAbilityLevelPrototype>();
        public JassInteger DecUnitAbilityLevel(JassUnit whichUnit, JassInteger abilcode)
        {
            return _DecUnitAbilityLevel(whichUnit, abilcode);
        }

        //native IncUnitAbilityLevel takes unit whichUnit, integer abilcode returns integer
        private delegate JassInteger IncUnitAbilityLevelPrototype(JassUnit whichUnit, JassInteger abilcode);
        private IncUnitAbilityLevelPrototype _IncUnitAbilityLevel = WarcraftIII.Jass.GetNative("IncUnitAbilityLevel").ToDelegate<IncUnitAbilityLevelPrototype>();
        public JassInteger IncUnitAbilityLevel(JassUnit whichUnit, JassInteger abilcode)
        {
            return _IncUnitAbilityLevel(whichUnit, abilcode);
        }

        //native SetUnitAbilityLevel takes unit whichUnit, integer abilcode, integer level returns integer
        private delegate JassInteger SetUnitAbilityLevelPrototype(JassUnit whichUnit, JassInteger abilcode, JassInteger level);
        private SetUnitAbilityLevelPrototype _SetUnitAbilityLevel = WarcraftIII.Jass.GetNative("SetUnitAbilityLevel").ToDelegate<SetUnitAbilityLevelPrototype>();
        public JassInteger SetUnitAbilityLevel(JassUnit whichUnit, JassInteger abilcode, JassInteger level)
        {
            return _SetUnitAbilityLevel(whichUnit, abilcode, level);
        }

        //native ReviveHero takes unit whichHero, real x, real y, boolean doEyecandy returns boolean
        private delegate JassBoolean ReviveHeroPrototype(JassUnit whichHero, JassRealArg x, JassRealArg y, JassBoolean doEyecandy);
        private ReviveHeroPrototype _ReviveHero = WarcraftIII.Jass.GetNative("ReviveHero").ToDelegate<ReviveHeroPrototype>();
        public Boolean ReviveHero(JassUnit whichHero, Single x, Single y, Boolean doEyecandy)
        {
            return _ReviveHero(whichHero, x, y, doEyecandy);
        }

        //native ReviveHeroLoc takes unit whichHero, location loc, boolean doEyecandy returns boolean
        private delegate JassBoolean ReviveHeroLocPrototype(JassUnit whichHero, JassLocation loc, JassBoolean doEyecandy);
        private ReviveHeroLocPrototype _ReviveHeroLoc = WarcraftIII.Jass.GetNative("ReviveHeroLoc").ToDelegate<ReviveHeroLocPrototype>();
        public Boolean ReviveHeroLoc(JassUnit whichHero, JassLocation loc, Boolean doEyecandy)
        {
            return _ReviveHeroLoc(whichHero, loc, doEyecandy);
        }

        //native SetUnitExploded takes unit whichUnit, boolean exploded returns nothing
        private delegate void SetUnitExplodedPrototype(JassUnit whichUnit, JassBoolean exploded);
        private SetUnitExplodedPrototype _SetUnitExploded = WarcraftIII.Jass.GetNative("SetUnitExploded").ToDelegate<SetUnitExplodedPrototype>();
        public void SetUnitExploded(JassUnit whichUnit, Boolean exploded)
        {
            _SetUnitExploded(whichUnit, exploded);
        }

        //native SetUnitInvulnerable takes unit whichUnit, boolean flag returns nothing
        private delegate void SetUnitInvulnerablePrototype(JassUnit whichUnit, JassBoolean flag);
        private SetUnitInvulnerablePrototype _SetUnitInvulnerable = WarcraftIII.Jass.GetNative("SetUnitInvulnerable").ToDelegate<SetUnitInvulnerablePrototype>();
        public void SetUnitInvulnerable(JassUnit whichUnit, Boolean flag)
        {
            _SetUnitInvulnerable(whichUnit, flag);
        }

        //native PauseUnit takes unit whichUnit, boolean flag returns nothing
        private delegate void PauseUnitPrototype(JassUnit whichUnit, JassBoolean flag);
        private PauseUnitPrototype _PauseUnit = WarcraftIII.Jass.GetNative("PauseUnit").ToDelegate<PauseUnitPrototype>();
        public void PauseUnit(JassUnit whichUnit, Boolean flag)
        {
            _PauseUnit(whichUnit, flag);
        }

        //native IsUnitPaused takes unit whichHero returns boolean
        private delegate JassBoolean IsUnitPausedPrototype(JassUnit whichHero);
        private IsUnitPausedPrototype _IsUnitPaused = WarcraftIII.Jass.GetNative("IsUnitPaused").ToDelegate<IsUnitPausedPrototype>();
        public Boolean IsUnitPaused(JassUnit whichHero)
        {
            return _IsUnitPaused(whichHero);
        }

        //native SetUnitPathing takes unit whichUnit, boolean flag returns nothing
        private delegate void SetUnitPathingPrototype(JassUnit whichUnit, JassBoolean flag);
        private SetUnitPathingPrototype _SetUnitPathing = WarcraftIII.Jass.GetNative("SetUnitPathing").ToDelegate<SetUnitPathingPrototype>();
        public void SetUnitPathing(JassUnit whichUnit, Boolean flag)
        {
            _SetUnitPathing(whichUnit, flag);
        }

        //native ClearSelection takes nothing returns nothing
        private delegate void ClearSelectionPrototype();
        private ClearSelectionPrototype _ClearSelection = WarcraftIII.Jass.GetNative("ClearSelection").ToDelegate<ClearSelectionPrototype>();
        public void ClearSelection()
        {
            _ClearSelection();
        }

        //native SelectUnit takes unit whichUnit, boolean flag returns nothing
        private delegate void SelectUnitPrototype(JassUnit whichUnit, JassBoolean flag);
        private SelectUnitPrototype _SelectUnit = WarcraftIII.Jass.GetNative("SelectUnit").ToDelegate<SelectUnitPrototype>();
        public void SelectUnit(JassUnit whichUnit, Boolean flag)
        {
            _SelectUnit(whichUnit, flag);
        }

        //native GetUnitPointValue takes unit whichUnit returns integer
        private delegate JassInteger GetUnitPointValuePrototype(JassUnit whichUnit);
        private GetUnitPointValuePrototype _GetUnitPointValue = WarcraftIII.Jass.GetNative("GetUnitPointValue").ToDelegate<GetUnitPointValuePrototype>();
        public JassInteger GetUnitPointValue(JassUnit whichUnit)
        {
            return _GetUnitPointValue(whichUnit);
        }

        //native GetUnitPointValueByType takes integer unitType returns integer
        private delegate JassInteger GetUnitPointValueByTypePrototype(JassInteger unitType);
        private GetUnitPointValueByTypePrototype _GetUnitPointValueByType = WarcraftIII.Jass.GetNative("GetUnitPointValueByType").ToDelegate<GetUnitPointValueByTypePrototype>();
        public JassInteger GetUnitPointValueByType(JassInteger unitType)
        {
            return _GetUnitPointValueByType(unitType);
        }

        //native UnitAddItem takes unit whichUnit, item whichItem returns boolean
        private delegate JassBoolean UnitAddItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private UnitAddItemPrototype _UnitAddItem = WarcraftIII.Jass.GetNative("UnitAddItem").ToDelegate<UnitAddItemPrototype>();
        public Boolean UnitAddItem(JassUnit whichUnit, JassItem whichItem)
        {
            return _UnitAddItem(whichUnit, whichItem);
        }

        //native UnitAddItemById takes unit whichUnit, integer itemId returns item
        private delegate JassItem UnitAddItemByIdPrototype(JassUnit whichUnit, JassInteger itemId);
        private UnitAddItemByIdPrototype _UnitAddItemById = WarcraftIII.Jass.GetNative("UnitAddItemById").ToDelegate<UnitAddItemByIdPrototype>();
        public JassItem UnitAddItemById(JassUnit whichUnit, JassInteger itemId)
        {
            return _UnitAddItemById(whichUnit, itemId);
        }

        //native UnitAddItemToSlotById takes unit whichUnit, integer itemId, integer itemSlot returns boolean
        private delegate JassBoolean UnitAddItemToSlotByIdPrototype(JassUnit whichUnit, JassInteger itemId, JassInteger itemSlot);
        private UnitAddItemToSlotByIdPrototype _UnitAddItemToSlotById = WarcraftIII.Jass.GetNative("UnitAddItemToSlotById").ToDelegate<UnitAddItemToSlotByIdPrototype>();
        public Boolean UnitAddItemToSlotById(JassUnit whichUnit, JassInteger itemId, JassInteger itemSlot)
        {
            return _UnitAddItemToSlotById(whichUnit, itemId, itemSlot);
        }

        //native UnitRemoveItem takes unit whichUnit, item whichItem returns nothing
        private delegate void UnitRemoveItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private UnitRemoveItemPrototype _UnitRemoveItem = WarcraftIII.Jass.GetNative("UnitRemoveItem").ToDelegate<UnitRemoveItemPrototype>();
        public void UnitRemoveItem(JassUnit whichUnit, JassItem whichItem)
        {
            _UnitRemoveItem(whichUnit, whichItem);
        }

        //native UnitRemoveItemFromSlot takes unit whichUnit, integer itemSlot returns item
        private delegate JassItem UnitRemoveItemFromSlotPrototype(JassUnit whichUnit, JassInteger itemSlot);
        private UnitRemoveItemFromSlotPrototype _UnitRemoveItemFromSlot = WarcraftIII.Jass.GetNative("UnitRemoveItemFromSlot").ToDelegate<UnitRemoveItemFromSlotPrototype>();
        public JassItem UnitRemoveItemFromSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return _UnitRemoveItemFromSlot(whichUnit, itemSlot);
        }

        //native UnitHasItem takes unit whichUnit, item whichItem returns boolean
        private delegate JassBoolean UnitHasItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private UnitHasItemPrototype _UnitHasItem = WarcraftIII.Jass.GetNative("UnitHasItem").ToDelegate<UnitHasItemPrototype>();
        public Boolean UnitHasItem(JassUnit whichUnit, JassItem whichItem)
        {
            return _UnitHasItem(whichUnit, whichItem);
        }

        //native UnitItemInSlot takes unit whichUnit, integer itemSlot returns item
        private delegate JassItem UnitItemInSlotPrototype(JassUnit whichUnit, JassInteger itemSlot);
        private UnitItemInSlotPrototype _UnitItemInSlot = WarcraftIII.Jass.GetNative("UnitItemInSlot").ToDelegate<UnitItemInSlotPrototype>();
        public JassItem UnitItemInSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return _UnitItemInSlot(whichUnit, itemSlot);
        }

        //native UnitInventorySize takes unit whichUnit returns integer
        private delegate JassInteger UnitInventorySizePrototype(JassUnit whichUnit);
        private UnitInventorySizePrototype _UnitInventorySize = WarcraftIII.Jass.GetNative("UnitInventorySize").ToDelegate<UnitInventorySizePrototype>();
        public JassInteger UnitInventorySize(JassUnit whichUnit)
        {
            return _UnitInventorySize(whichUnit);
        }

        //native UnitDropItemPoint takes unit whichUnit, item whichItem, real x, real y returns boolean
        private delegate JassBoolean UnitDropItemPointPrototype(JassUnit whichUnit, JassItem whichItem, JassRealArg x, JassRealArg y);
        private UnitDropItemPointPrototype _UnitDropItemPoint = WarcraftIII.Jass.GetNative("UnitDropItemPoint").ToDelegate<UnitDropItemPointPrototype>();
        public Boolean UnitDropItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return _UnitDropItemPoint(whichUnit, whichItem, x, y);
        }

        //native UnitDropItemSlot takes unit whichUnit, item whichItem, integer slot returns boolean
        private delegate JassBoolean UnitDropItemSlotPrototype(JassUnit whichUnit, JassItem whichItem, JassInteger slot);
        private UnitDropItemSlotPrototype _UnitDropItemSlot = WarcraftIII.Jass.GetNative("UnitDropItemSlot").ToDelegate<UnitDropItemSlotPrototype>();
        public Boolean UnitDropItemSlot(JassUnit whichUnit, JassItem whichItem, JassInteger slot)
        {
            return _UnitDropItemSlot(whichUnit, whichItem, slot);
        }

        //native UnitDropItemTarget takes unit whichUnit, item whichItem, widget target returns boolean
        private delegate JassBoolean UnitDropItemTargetPrototype(JassUnit whichUnit, JassItem whichItem, JassWidget target);
        private UnitDropItemTargetPrototype _UnitDropItemTarget = WarcraftIII.Jass.GetNative("UnitDropItemTarget").ToDelegate<UnitDropItemTargetPrototype>();
        public Boolean UnitDropItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return _UnitDropItemTarget(whichUnit, whichItem, target);
        }

        //native UnitUseItem takes unit whichUnit, item whichItem returns boolean
        private delegate JassBoolean UnitUseItemPrototype(JassUnit whichUnit, JassItem whichItem);
        private UnitUseItemPrototype _UnitUseItem = WarcraftIII.Jass.GetNative("UnitUseItem").ToDelegate<UnitUseItemPrototype>();
        public Boolean UnitUseItem(JassUnit whichUnit, JassItem whichItem)
        {
            return _UnitUseItem(whichUnit, whichItem);
        }

        //native UnitUseItemPoint takes unit whichUnit, item whichItem, real x, real y returns boolean
        private delegate JassBoolean UnitUseItemPointPrototype(JassUnit whichUnit, JassItem whichItem, JassRealArg x, JassRealArg y);
        private UnitUseItemPointPrototype _UnitUseItemPoint = WarcraftIII.Jass.GetNative("UnitUseItemPoint").ToDelegate<UnitUseItemPointPrototype>();
        public Boolean UnitUseItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return _UnitUseItemPoint(whichUnit, whichItem, x, y);
        }

        //native UnitUseItemTarget takes unit whichUnit, item whichItem, widget target returns boolean
        private delegate JassBoolean UnitUseItemTargetPrototype(JassUnit whichUnit, JassItem whichItem, JassWidget target);
        private UnitUseItemTargetPrototype _UnitUseItemTarget = WarcraftIII.Jass.GetNative("UnitUseItemTarget").ToDelegate<UnitUseItemTargetPrototype>();
        public Boolean UnitUseItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return _UnitUseItemTarget(whichUnit, whichItem, target);
        }

        //native GetUnitX takes unit whichUnit returns real
        private delegate JassRealRet GetUnitXPrototype(JassUnit whichUnit);
        private GetUnitXPrototype _GetUnitX = WarcraftIII.Jass.GetNative("GetUnitX").ToDelegate<GetUnitXPrototype>();
        public Single GetUnitX(JassUnit whichUnit)
        {
            return _GetUnitX(whichUnit);
        }

        //native GetUnitY takes unit whichUnit returns real
        private delegate JassRealRet GetUnitYPrototype(JassUnit whichUnit);
        private GetUnitYPrototype _GetUnitY = WarcraftIII.Jass.GetNative("GetUnitY").ToDelegate<GetUnitYPrototype>();
        public Single GetUnitY(JassUnit whichUnit)
        {
            return _GetUnitY(whichUnit);
        }

        //native GetUnitLoc takes unit whichUnit returns location
        private delegate JassLocation GetUnitLocPrototype(JassUnit whichUnit);
        private GetUnitLocPrototype _GetUnitLoc = WarcraftIII.Jass.GetNative("GetUnitLoc").ToDelegate<GetUnitLocPrototype>();
        public JassLocation GetUnitLoc(JassUnit whichUnit)
        {
            return _GetUnitLoc(whichUnit);
        }

        //native GetUnitFacing takes unit whichUnit returns real
        private delegate JassRealRet GetUnitFacingPrototype(JassUnit whichUnit);
        private GetUnitFacingPrototype _GetUnitFacing = WarcraftIII.Jass.GetNative("GetUnitFacing").ToDelegate<GetUnitFacingPrototype>();
        public Single GetUnitFacing(JassUnit whichUnit)
        {
            return _GetUnitFacing(whichUnit);
        }

        //native GetUnitMoveSpeed takes unit whichUnit returns real
        private delegate JassRealRet GetUnitMoveSpeedPrototype(JassUnit whichUnit);
        private GetUnitMoveSpeedPrototype _GetUnitMoveSpeed = WarcraftIII.Jass.GetNative("GetUnitMoveSpeed").ToDelegate<GetUnitMoveSpeedPrototype>();
        public Single GetUnitMoveSpeed(JassUnit whichUnit)
        {
            return _GetUnitMoveSpeed(whichUnit);
        }

        //native GetUnitDefaultMoveSpeed takes unit whichUnit returns real
        private delegate JassRealRet GetUnitDefaultMoveSpeedPrototype(JassUnit whichUnit);
        private GetUnitDefaultMoveSpeedPrototype _GetUnitDefaultMoveSpeed = WarcraftIII.Jass.GetNative("GetUnitDefaultMoveSpeed").ToDelegate<GetUnitDefaultMoveSpeedPrototype>();
        public Single GetUnitDefaultMoveSpeed(JassUnit whichUnit)
        {
            return _GetUnitDefaultMoveSpeed(whichUnit);
        }

        //native GetUnitState takes unit whichUnit, unitstate whichUnitState returns real
        private delegate JassRealRet GetUnitStatePrototype(JassUnit whichUnit, JassUnitState whichUnitState);
        private GetUnitStatePrototype _GetUnitState = WarcraftIII.Jass.GetNative("GetUnitState").ToDelegate<GetUnitStatePrototype>();
        public Single GetUnitState(JassUnit whichUnit, JassUnitState whichUnitState)
        {
            return _GetUnitState(whichUnit, whichUnitState);
        }

        //native GetOwningPlayer takes unit whichUnit returns player
        private delegate JassPlayer GetOwningPlayerPrototype(JassUnit whichUnit);
        private GetOwningPlayerPrototype _GetOwningPlayer = WarcraftIII.Jass.GetNative("GetOwningPlayer").ToDelegate<GetOwningPlayerPrototype>();
        public JassPlayer GetOwningPlayer(JassUnit whichUnit)
        {
            return _GetOwningPlayer(whichUnit);
        }

        //native GetUnitTypeId takes unit whichUnit returns integer
        private delegate JassInteger GetUnitTypeIdPrototype(JassUnit whichUnit);
        private GetUnitTypeIdPrototype _GetUnitTypeId = WarcraftIII.Jass.GetNative("GetUnitTypeId").ToDelegate<GetUnitTypeIdPrototype>();
        public JassInteger GetUnitTypeId(JassUnit whichUnit)
        {
            return _GetUnitTypeId(whichUnit);
        }

        //native GetUnitRace takes unit whichUnit returns race
        private delegate JassRace GetUnitRacePrototype(JassUnit whichUnit);
        private GetUnitRacePrototype _GetUnitRace = WarcraftIII.Jass.GetNative("GetUnitRace").ToDelegate<GetUnitRacePrototype>();
        public JassRace GetUnitRace(JassUnit whichUnit)
        {
            return _GetUnitRace(whichUnit);
        }

        //native GetUnitName takes unit whichUnit returns string
        private delegate JassStringRet GetUnitNamePrototype(JassUnit whichUnit);
        private GetUnitNamePrototype _GetUnitName = WarcraftIII.Jass.GetNative("GetUnitName").ToDelegate<GetUnitNamePrototype>();
        public String GetUnitName(JassUnit whichUnit)
        {
            return _GetUnitName(whichUnit);
        }

        //native GetUnitFoodUsed takes unit whichUnit returns integer
        private delegate JassInteger GetUnitFoodUsedPrototype(JassUnit whichUnit);
        private GetUnitFoodUsedPrototype _GetUnitFoodUsed = WarcraftIII.Jass.GetNative("GetUnitFoodUsed").ToDelegate<GetUnitFoodUsedPrototype>();
        public JassInteger GetUnitFoodUsed(JassUnit whichUnit)
        {
            return _GetUnitFoodUsed(whichUnit);
        }

        //native GetUnitFoodMade takes unit whichUnit returns integer
        private delegate JassInteger GetUnitFoodMadePrototype(JassUnit whichUnit);
        private GetUnitFoodMadePrototype _GetUnitFoodMade = WarcraftIII.Jass.GetNative("GetUnitFoodMade").ToDelegate<GetUnitFoodMadePrototype>();
        public JassInteger GetUnitFoodMade(JassUnit whichUnit)
        {
            return _GetUnitFoodMade(whichUnit);
        }

        //native GetFoodMade takes integer unitId returns integer
        private delegate JassInteger GetFoodMadePrototype(JassUnitId unitId);
        private GetFoodMadePrototype _GetFoodMade = WarcraftIII.Jass.GetNative("GetFoodMade").ToDelegate<GetFoodMadePrototype>();
        public JassInteger GetFoodMade(JassUnitId unitId)
        {
            return _GetFoodMade(unitId);
        }

        //native GetFoodUsed takes integer unitId returns integer
        private delegate JassInteger GetFoodUsedPrototype(JassUnitId unitId);
        private GetFoodUsedPrototype _GetFoodUsed = WarcraftIII.Jass.GetNative("GetFoodUsed").ToDelegate<GetFoodUsedPrototype>();
        public JassInteger GetFoodUsed(JassUnitId unitId)
        {
            return _GetFoodUsed(unitId);
        }

        //native SetUnitUseFood takes unit whichUnit, boolean useFood returns nothing
        private delegate void SetUnitUseFoodPrototype(JassUnit whichUnit, JassBoolean useFood);
        private SetUnitUseFoodPrototype _SetUnitUseFood = WarcraftIII.Jass.GetNative("SetUnitUseFood").ToDelegate<SetUnitUseFoodPrototype>();
        public void SetUnitUseFood(JassUnit whichUnit, Boolean useFood)
        {
            _SetUnitUseFood(whichUnit, useFood);
        }

        //native GetUnitRallyPoint takes unit whichUnit returns location
        private delegate JassLocation GetUnitRallyPointPrototype(JassUnit whichUnit);
        private GetUnitRallyPointPrototype _GetUnitRallyPoint = WarcraftIII.Jass.GetNative("GetUnitRallyPoint").ToDelegate<GetUnitRallyPointPrototype>();
        public JassLocation GetUnitRallyPoint(JassUnit whichUnit)
        {
            return _GetUnitRallyPoint(whichUnit);
        }

        //native GetUnitRallyUnit takes unit whichUnit returns unit
        private delegate JassUnit GetUnitRallyUnitPrototype(JassUnit whichUnit);
        private GetUnitRallyUnitPrototype _GetUnitRallyUnit = WarcraftIII.Jass.GetNative("GetUnitRallyUnit").ToDelegate<GetUnitRallyUnitPrototype>();
        public JassUnit GetUnitRallyUnit(JassUnit whichUnit)
        {
            return _GetUnitRallyUnit(whichUnit);
        }

        //native GetUnitRallyDestructable takes unit whichUnit returns destructable
        private delegate JassDestructable GetUnitRallyDestructablePrototype(JassUnit whichUnit);
        private GetUnitRallyDestructablePrototype _GetUnitRallyDestructable = WarcraftIII.Jass.GetNative("GetUnitRallyDestructable").ToDelegate<GetUnitRallyDestructablePrototype>();
        public JassDestructable GetUnitRallyDestructable(JassUnit whichUnit)
        {
            return _GetUnitRallyDestructable(whichUnit);
        }

        //native IsUnitInGroup takes unit whichUnit, group whichGroup returns boolean
        private delegate JassBoolean IsUnitInGroupPrototype(JassUnit whichUnit, JassGroup whichGroup);
        private IsUnitInGroupPrototype _IsUnitInGroup = WarcraftIII.Jass.GetNative("IsUnitInGroup").ToDelegate<IsUnitInGroupPrototype>();
        public Boolean IsUnitInGroup(JassUnit whichUnit, JassGroup whichGroup)
        {
            return _IsUnitInGroup(whichUnit, whichGroup);
        }

        //native IsUnitInForce takes unit whichUnit, force whichForce returns boolean
        private delegate JassBoolean IsUnitInForcePrototype(JassUnit whichUnit, JassForce whichForce);
        private IsUnitInForcePrototype _IsUnitInForce = WarcraftIII.Jass.GetNative("IsUnitInForce").ToDelegate<IsUnitInForcePrototype>();
        public Boolean IsUnitInForce(JassUnit whichUnit, JassForce whichForce)
        {
            return _IsUnitInForce(whichUnit, whichForce);
        }

        //native IsUnitOwnedByPlayer takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitOwnedByPlayerPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitOwnedByPlayerPrototype _IsUnitOwnedByPlayer = WarcraftIII.Jass.GetNative("IsUnitOwnedByPlayer").ToDelegate<IsUnitOwnedByPlayerPrototype>();
        public Boolean IsUnitOwnedByPlayer(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitOwnedByPlayer(whichUnit, whichPlayer);
        }

        //native IsUnitAlly takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitAllyPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitAllyPrototype _IsUnitAlly = WarcraftIII.Jass.GetNative("IsUnitAlly").ToDelegate<IsUnitAllyPrototype>();
        public Boolean IsUnitAlly(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitAlly(whichUnit, whichPlayer);
        }

        //native IsUnitEnemy takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitEnemyPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitEnemyPrototype _IsUnitEnemy = WarcraftIII.Jass.GetNative("IsUnitEnemy").ToDelegate<IsUnitEnemyPrototype>();
        public Boolean IsUnitEnemy(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitEnemy(whichUnit, whichPlayer);
        }

        //native IsUnitVisible takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitVisiblePrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitVisiblePrototype _IsUnitVisible = WarcraftIII.Jass.GetNative("IsUnitVisible").ToDelegate<IsUnitVisiblePrototype>();
        public Boolean IsUnitVisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitVisible(whichUnit, whichPlayer);
        }

        //native IsUnitDetected takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitDetectedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitDetectedPrototype _IsUnitDetected = WarcraftIII.Jass.GetNative("IsUnitDetected").ToDelegate<IsUnitDetectedPrototype>();
        public Boolean IsUnitDetected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitDetected(whichUnit, whichPlayer);
        }

        //native IsUnitInvisible takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitInvisiblePrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitInvisiblePrototype _IsUnitInvisible = WarcraftIII.Jass.GetNative("IsUnitInvisible").ToDelegate<IsUnitInvisiblePrototype>();
        public Boolean IsUnitInvisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitInvisible(whichUnit, whichPlayer);
        }

        //native IsUnitFogged takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitFoggedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitFoggedPrototype _IsUnitFogged = WarcraftIII.Jass.GetNative("IsUnitFogged").ToDelegate<IsUnitFoggedPrototype>();
        public Boolean IsUnitFogged(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitFogged(whichUnit, whichPlayer);
        }

        //native IsUnitMasked takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitMaskedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitMaskedPrototype _IsUnitMasked = WarcraftIII.Jass.GetNative("IsUnitMasked").ToDelegate<IsUnitMaskedPrototype>();
        public Boolean IsUnitMasked(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitMasked(whichUnit, whichPlayer);
        }

        //native IsUnitSelected takes unit whichUnit, player whichPlayer returns boolean
        private delegate JassBoolean IsUnitSelectedPrototype(JassUnit whichUnit, JassPlayer whichPlayer);
        private IsUnitSelectedPrototype _IsUnitSelected = WarcraftIII.Jass.GetNative("IsUnitSelected").ToDelegate<IsUnitSelectedPrototype>();
        public Boolean IsUnitSelected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return _IsUnitSelected(whichUnit, whichPlayer);
        }

        //native IsUnitRace takes unit whichUnit, race whichRace returns boolean
        private delegate JassBoolean IsUnitRacePrototype(JassUnit whichUnit, JassRace whichRace);
        private IsUnitRacePrototype _IsUnitRace = WarcraftIII.Jass.GetNative("IsUnitRace").ToDelegate<IsUnitRacePrototype>();
        public Boolean IsUnitRace(JassUnit whichUnit, JassRace whichRace)
        {
            return _IsUnitRace(whichUnit, whichRace);
        }

        //native IsUnitType takes unit whichUnit, unittype whichUnitType returns boolean
        private delegate JassBoolean IsUnitTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private IsUnitTypePrototype _IsUnitType = WarcraftIII.Jass.GetNative("IsUnitType").ToDelegate<IsUnitTypePrototype>();
        public Boolean IsUnitType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return _IsUnitType(whichUnit, whichUnitType);
        }

        //native IsUnit takes unit whichUnit, unit whichSpecifiedUnit returns boolean
        private delegate JassBoolean IsUnitPrototype(JassUnit whichUnit, JassUnit whichSpecifiedUnit);
        private IsUnitPrototype _IsUnit = WarcraftIII.Jass.GetNative("IsUnit").ToDelegate<IsUnitPrototype>();
        public Boolean IsUnit(JassUnit whichUnit, JassUnit whichSpecifiedUnit)
        {
            return _IsUnit(whichUnit, whichSpecifiedUnit);
        }

        //native IsUnitInRange takes unit whichUnit, unit otherUnit, real distance returns boolean
        private delegate JassBoolean IsUnitInRangePrototype(JassUnit whichUnit, JassUnit otherUnit, JassRealArg distance);
        private IsUnitInRangePrototype _IsUnitInRange = WarcraftIII.Jass.GetNative("IsUnitInRange").ToDelegate<IsUnitInRangePrototype>();
        public Boolean IsUnitInRange(JassUnit whichUnit, JassUnit otherUnit, Single distance)
        {
            return _IsUnitInRange(whichUnit, otherUnit, distance);
        }

        //native IsUnitInRangeXY takes unit whichUnit, real x, real y, real distance returns boolean
        private delegate JassBoolean IsUnitInRangeXYPrototype(JassUnit whichUnit, JassRealArg x, JassRealArg y, JassRealArg distance);
        private IsUnitInRangeXYPrototype _IsUnitInRangeXY = WarcraftIII.Jass.GetNative("IsUnitInRangeXY").ToDelegate<IsUnitInRangeXYPrototype>();
        public Boolean IsUnitInRangeXY(JassUnit whichUnit, Single x, Single y, Single distance)
        {
            return _IsUnitInRangeXY(whichUnit, x, y, distance);
        }

        //native IsUnitInRangeLoc takes unit whichUnit, location whichLocation, real distance returns boolean
        private delegate JassBoolean IsUnitInRangeLocPrototype(JassUnit whichUnit, JassLocation whichLocation, JassRealArg distance);
        private IsUnitInRangeLocPrototype _IsUnitInRangeLoc = WarcraftIII.Jass.GetNative("IsUnitInRangeLoc").ToDelegate<IsUnitInRangeLocPrototype>();
        public Boolean IsUnitInRangeLoc(JassUnit whichUnit, JassLocation whichLocation, Single distance)
        {
            return _IsUnitInRangeLoc(whichUnit, whichLocation, distance);
        }

        //native IsUnitHidden takes unit whichUnit returns boolean
        private delegate JassBoolean IsUnitHiddenPrototype(JassUnit whichUnit);
        private IsUnitHiddenPrototype _IsUnitHidden = WarcraftIII.Jass.GetNative("IsUnitHidden").ToDelegate<IsUnitHiddenPrototype>();
        public Boolean IsUnitHidden(JassUnit whichUnit)
        {
            return _IsUnitHidden(whichUnit);
        }

        //native IsUnitIllusion takes unit whichUnit returns boolean
        private delegate JassBoolean IsUnitIllusionPrototype(JassUnit whichUnit);
        private IsUnitIllusionPrototype _IsUnitIllusion = WarcraftIII.Jass.GetNative("IsUnitIllusion").ToDelegate<IsUnitIllusionPrototype>();
        public Boolean IsUnitIllusion(JassUnit whichUnit)
        {
            return _IsUnitIllusion(whichUnit);
        }

        //native IsUnitInTransport takes unit whichUnit, unit whichTransport returns boolean
        private delegate JassBoolean IsUnitInTransportPrototype(JassUnit whichUnit, JassUnit whichTransport);
        private IsUnitInTransportPrototype _IsUnitInTransport = WarcraftIII.Jass.GetNative("IsUnitInTransport").ToDelegate<IsUnitInTransportPrototype>();
        public Boolean IsUnitInTransport(JassUnit whichUnit, JassUnit whichTransport)
        {
            return _IsUnitInTransport(whichUnit, whichTransport);
        }

        //native IsUnitLoaded takes unit whichUnit returns boolean
        private delegate JassBoolean IsUnitLoadedPrototype(JassUnit whichUnit);
        private IsUnitLoadedPrototype _IsUnitLoaded = WarcraftIII.Jass.GetNative("IsUnitLoaded").ToDelegate<IsUnitLoadedPrototype>();
        public Boolean IsUnitLoaded(JassUnit whichUnit)
        {
            return _IsUnitLoaded(whichUnit);
        }

        //native IsHeroUnitId takes integer unitId returns boolean
        private delegate JassBoolean IsHeroUnitIdPrototype(JassUnitId unitId);
        private IsHeroUnitIdPrototype _IsHeroUnitId = WarcraftIII.Jass.GetNative("IsHeroUnitId").ToDelegate<IsHeroUnitIdPrototype>();
        public Boolean IsHeroUnitId(JassUnitId unitId)
        {
            return _IsHeroUnitId(unitId);
        }

        //native IsUnitIdType takes integer unitId, unittype whichUnitType returns boolean
        private delegate JassBoolean IsUnitIdTypePrototype(JassUnitId unitId, JassUnitType whichUnitType);
        private IsUnitIdTypePrototype _IsUnitIdType = WarcraftIII.Jass.GetNative("IsUnitIdType").ToDelegate<IsUnitIdTypePrototype>();
        public Boolean IsUnitIdType(JassUnitId unitId, JassUnitType whichUnitType)
        {
            return _IsUnitIdType(unitId, whichUnitType);
        }

        //native UnitShareVision takes unit whichUnit, player whichPlayer, boolean share returns nothing
        private delegate void UnitShareVisionPrototype(JassUnit whichUnit, JassPlayer whichPlayer, JassBoolean share);
        private UnitShareVisionPrototype _UnitShareVision = WarcraftIII.Jass.GetNative("UnitShareVision").ToDelegate<UnitShareVisionPrototype>();
        public void UnitShareVision(JassUnit whichUnit, JassPlayer whichPlayer, Boolean share)
        {
            _UnitShareVision(whichUnit, whichPlayer, share);
        }

        //native UnitSuspendDecay takes unit whichUnit, boolean suspend returns nothing
        private delegate void UnitSuspendDecayPrototype(JassUnit whichUnit, JassBoolean suspend);
        private UnitSuspendDecayPrototype _UnitSuspendDecay = WarcraftIII.Jass.GetNative("UnitSuspendDecay").ToDelegate<UnitSuspendDecayPrototype>();
        public void UnitSuspendDecay(JassUnit whichUnit, Boolean suspend)
        {
            _UnitSuspendDecay(whichUnit, suspend);
        }

        //native UnitAddType takes unit whichUnit, unittype whichUnitType returns boolean
        private delegate JassBoolean UnitAddTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private UnitAddTypePrototype _UnitAddType = WarcraftIII.Jass.GetNative("UnitAddType").ToDelegate<UnitAddTypePrototype>();
        public Boolean UnitAddType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return _UnitAddType(whichUnit, whichUnitType);
        }

        //native UnitRemoveType takes unit whichUnit, unittype whichUnitType returns boolean
        private delegate JassBoolean UnitRemoveTypePrototype(JassUnit whichUnit, JassUnitType whichUnitType);
        private UnitRemoveTypePrototype _UnitRemoveType = WarcraftIII.Jass.GetNative("UnitRemoveType").ToDelegate<UnitRemoveTypePrototype>();
        public Boolean UnitRemoveType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return _UnitRemoveType(whichUnit, whichUnitType);
        }

        //native UnitAddAbility takes unit whichUnit, integer abilityId returns boolean
        private delegate JassBoolean UnitAddAbilityPrototype(JassUnit whichUnit, JassInteger abilityId);
        private UnitAddAbilityPrototype _UnitAddAbility = WarcraftIII.Jass.GetNative("UnitAddAbility").ToDelegate<UnitAddAbilityPrototype>();
        public Boolean UnitAddAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return _UnitAddAbility(whichUnit, abilityId);
        }

        //native UnitRemoveAbility takes unit whichUnit, integer abilityId returns boolean
        private delegate JassBoolean UnitRemoveAbilityPrototype(JassUnit whichUnit, JassInteger abilityId);
        private UnitRemoveAbilityPrototype _UnitRemoveAbility = WarcraftIII.Jass.GetNative("UnitRemoveAbility").ToDelegate<UnitRemoveAbilityPrototype>();
        public Boolean UnitRemoveAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return _UnitRemoveAbility(whichUnit, abilityId);
        }

        //native UnitMakeAbilityPermanent takes unit whichUnit, boolean permanent, integer abilityId returns boolean
        private delegate JassBoolean UnitMakeAbilityPermanentPrototype(JassUnit whichUnit, JassBoolean permanent, JassInteger abilityId);
        private UnitMakeAbilityPermanentPrototype _UnitMakeAbilityPermanent = WarcraftIII.Jass.GetNative("UnitMakeAbilityPermanent").ToDelegate<UnitMakeAbilityPermanentPrototype>();
        public Boolean UnitMakeAbilityPermanent(JassUnit whichUnit, Boolean permanent, JassInteger abilityId)
        {
            return _UnitMakeAbilityPermanent(whichUnit, permanent, abilityId);
        }

        //native UnitRemoveBuffs takes unit whichUnit, boolean removePositive, boolean removeNegative returns nothing
        private delegate void UnitRemoveBuffsPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative);
        private UnitRemoveBuffsPrototype _UnitRemoveBuffs = WarcraftIII.Jass.GetNative("UnitRemoveBuffs").ToDelegate<UnitRemoveBuffsPrototype>();
        public void UnitRemoveBuffs(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative)
        {
            _UnitRemoveBuffs(whichUnit, removePositive, removeNegative);
        }

        //native UnitRemoveBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns nothing
        private delegate void UnitRemoveBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private UnitRemoveBuffsExPrototype _UnitRemoveBuffsEx = WarcraftIII.Jass.GetNative("UnitRemoveBuffsEx").ToDelegate<UnitRemoveBuffsExPrototype>();
        public void UnitRemoveBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            _UnitRemoveBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }

        //native UnitHasBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns boolean
        private delegate JassBoolean UnitHasBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private UnitHasBuffsExPrototype _UnitHasBuffsEx = WarcraftIII.Jass.GetNative("UnitHasBuffsEx").ToDelegate<UnitHasBuffsExPrototype>();
        public Boolean UnitHasBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return _UnitHasBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }

        //native UnitCountBuffsEx takes unit whichUnit, boolean removePositive, boolean removeNegative, boolean magic, boolean physical, boolean timedLife, boolean aura, boolean autoDispel returns integer
        private delegate JassInteger UnitCountBuffsExPrototype(JassUnit whichUnit, JassBoolean removePositive, JassBoolean removeNegative, JassBoolean magic, JassBoolean physical, JassBoolean timedLife, JassBoolean aura, JassBoolean autoDispel);
        private UnitCountBuffsExPrototype _UnitCountBuffsEx = WarcraftIII.Jass.GetNative("UnitCountBuffsEx").ToDelegate<UnitCountBuffsExPrototype>();
        public JassInteger UnitCountBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return _UnitCountBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }

        //native UnitAddSleep takes unit whichUnit, boolean add returns nothing
        private delegate void UnitAddSleepPrototype(JassUnit whichUnit, JassBoolean add);
        private UnitAddSleepPrototype _UnitAddSleep = WarcraftIII.Jass.GetNative("UnitAddSleep").ToDelegate<UnitAddSleepPrototype>();
        public void UnitAddSleep(JassUnit whichUnit, Boolean add)
        {
            _UnitAddSleep(whichUnit, add);
        }

        //native UnitCanSleep takes unit whichUnit returns boolean
        private delegate JassBoolean UnitCanSleepPrototype(JassUnit whichUnit);
        private UnitCanSleepPrototype _UnitCanSleep = WarcraftIII.Jass.GetNative("UnitCanSleep").ToDelegate<UnitCanSleepPrototype>();
        public Boolean UnitCanSleep(JassUnit whichUnit)
        {
            return _UnitCanSleep(whichUnit);
        }

        //native UnitAddSleepPerm takes unit whichUnit, boolean add returns nothing
        private delegate void UnitAddSleepPermPrototype(JassUnit whichUnit, JassBoolean add);
        private UnitAddSleepPermPrototype _UnitAddSleepPerm = WarcraftIII.Jass.GetNative("UnitAddSleepPerm").ToDelegate<UnitAddSleepPermPrototype>();
        public void UnitAddSleepPerm(JassUnit whichUnit, Boolean add)
        {
            _UnitAddSleepPerm(whichUnit, add);
        }

        //native UnitCanSleepPerm takes unit whichUnit returns boolean
        private delegate JassBoolean UnitCanSleepPermPrototype(JassUnit whichUnit);
        private UnitCanSleepPermPrototype _UnitCanSleepPerm = WarcraftIII.Jass.GetNative("UnitCanSleepPerm").ToDelegate<UnitCanSleepPermPrototype>();
        public Boolean UnitCanSleepPerm(JassUnit whichUnit)
        {
            return _UnitCanSleepPerm(whichUnit);
        }

        //native UnitIsSleeping takes unit whichUnit returns boolean
        private delegate JassBoolean UnitIsSleepingPrototype(JassUnit whichUnit);
        private UnitIsSleepingPrototype _UnitIsSleeping = WarcraftIII.Jass.GetNative("UnitIsSleeping").ToDelegate<UnitIsSleepingPrototype>();
        public Boolean UnitIsSleeping(JassUnit whichUnit)
        {
            return _UnitIsSleeping(whichUnit);
        }

        //native UnitWakeUp takes unit whichUnit returns nothing
        private delegate void UnitWakeUpPrototype(JassUnit whichUnit);
        private UnitWakeUpPrototype _UnitWakeUp = WarcraftIII.Jass.GetNative("UnitWakeUp").ToDelegate<UnitWakeUpPrototype>();
        public void UnitWakeUp(JassUnit whichUnit)
        {
            _UnitWakeUp(whichUnit);
        }

        //native UnitApplyTimedLife takes unit whichUnit, integer buffId, real duration returns nothing
        private delegate void UnitApplyTimedLifePrototype(JassUnit whichUnit, JassInteger buffId, JassRealArg duration);
        private UnitApplyTimedLifePrototype _UnitApplyTimedLife = WarcraftIII.Jass.GetNative("UnitApplyTimedLife").ToDelegate<UnitApplyTimedLifePrototype>();
        public void UnitApplyTimedLife(JassUnit whichUnit, JassInteger buffId, Single duration)
        {
            _UnitApplyTimedLife(whichUnit, buffId, duration);
        }

        //native UnitIgnoreAlarm takes unit whichUnit, boolean flag returns boolean
        private delegate JassBoolean UnitIgnoreAlarmPrototype(JassUnit whichUnit, JassBoolean flag);
        private UnitIgnoreAlarmPrototype _UnitIgnoreAlarm = WarcraftIII.Jass.GetNative("UnitIgnoreAlarm").ToDelegate<UnitIgnoreAlarmPrototype>();
        public Boolean UnitIgnoreAlarm(JassUnit whichUnit, Boolean flag)
        {
            return _UnitIgnoreAlarm(whichUnit, flag);
        }

        //native UnitIgnoreAlarmToggled takes unit whichUnit returns boolean
        private delegate JassBoolean UnitIgnoreAlarmToggledPrototype(JassUnit whichUnit);
        private UnitIgnoreAlarmToggledPrototype _UnitIgnoreAlarmToggled = WarcraftIII.Jass.GetNative("UnitIgnoreAlarmToggled").ToDelegate<UnitIgnoreAlarmToggledPrototype>();
        public Boolean UnitIgnoreAlarmToggled(JassUnit whichUnit)
        {
            return _UnitIgnoreAlarmToggled(whichUnit);
        }

        //native UnitResetCooldown takes unit whichUnit returns nothing
        private delegate void UnitResetCooldownPrototype(JassUnit whichUnit);
        private UnitResetCooldownPrototype _UnitResetCooldown = WarcraftIII.Jass.GetNative("UnitResetCooldown").ToDelegate<UnitResetCooldownPrototype>();
        public void UnitResetCooldown(JassUnit whichUnit)
        {
            _UnitResetCooldown(whichUnit);
        }

        //native UnitSetConstructionProgress takes unit whichUnit, integer constructionPercentage returns nothing
        private delegate void UnitSetConstructionProgressPrototype(JassUnit whichUnit, JassInteger constructionPercentage);
        private UnitSetConstructionProgressPrototype _UnitSetConstructionProgress = WarcraftIII.Jass.GetNative("UnitSetConstructionProgress").ToDelegate<UnitSetConstructionProgressPrototype>();
        public void UnitSetConstructionProgress(JassUnit whichUnit, JassInteger constructionPercentage)
        {
            _UnitSetConstructionProgress(whichUnit, constructionPercentage);
        }

        //native UnitSetUpgradeProgress takes unit whichUnit, integer upgradePercentage returns nothing
        private delegate void UnitSetUpgradeProgressPrototype(JassUnit whichUnit, JassInteger upgradePercentage);
        private UnitSetUpgradeProgressPrototype _UnitSetUpgradeProgress = WarcraftIII.Jass.GetNative("UnitSetUpgradeProgress").ToDelegate<UnitSetUpgradeProgressPrototype>();
        public void UnitSetUpgradeProgress(JassUnit whichUnit, JassInteger upgradePercentage)
        {
            _UnitSetUpgradeProgress(whichUnit, upgradePercentage);
        }

        //native UnitPauseTimedLife takes unit whichUnit, boolean flag returns nothing
        private delegate void UnitPauseTimedLifePrototype(JassUnit whichUnit, JassBoolean flag);
        private UnitPauseTimedLifePrototype _UnitPauseTimedLife = WarcraftIII.Jass.GetNative("UnitPauseTimedLife").ToDelegate<UnitPauseTimedLifePrototype>();
        public void UnitPauseTimedLife(JassUnit whichUnit, Boolean flag)
        {
            _UnitPauseTimedLife(whichUnit, flag);
        }

        //native UnitSetUsesAltIcon takes unit whichUnit, boolean flag returns nothing
        private delegate void UnitSetUsesAltIconPrototype(JassUnit whichUnit, JassBoolean flag);
        private UnitSetUsesAltIconPrototype _UnitSetUsesAltIcon = WarcraftIII.Jass.GetNative("UnitSetUsesAltIcon").ToDelegate<UnitSetUsesAltIconPrototype>();
        public void UnitSetUsesAltIcon(JassUnit whichUnit, Boolean flag)
        {
            _UnitSetUsesAltIcon(whichUnit, flag);
        }

        //native UnitDamagePoint takes unit whichUnit, real delay, real radius, real x, real y, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
        private delegate JassBoolean UnitDamagePointPrototype(JassUnit whichUnit, JassRealArg delay, JassRealArg radius, JassRealArg x, JassRealArg y, JassRealArg amount, JassBoolean attack, JassBoolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType);
        private UnitDamagePointPrototype _UnitDamagePoint = WarcraftIII.Jass.GetNative("UnitDamagePoint").ToDelegate<UnitDamagePointPrototype>();
        public Boolean UnitDamagePoint(JassUnit whichUnit, Single delay, Single radius, Single x, Single y, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return _UnitDamagePoint(whichUnit, delay, radius, x, y, amount, attack, ranged, attackType, damageType, weaponType);
        }

        //native UnitDamageTarget takes unit whichUnit, widget target, real amount, boolean attack, boolean ranged, attacktype attackType, damagetype damageType, weapontype weaponType returns boolean
        private delegate JassBoolean UnitDamageTargetPrototype(JassUnit whichUnit, JassWidget target, JassRealArg amount, JassBoolean attack, JassBoolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType);
        private UnitDamageTargetPrototype _UnitDamageTarget = WarcraftIII.Jass.GetNative("UnitDamageTarget").ToDelegate<UnitDamageTargetPrototype>();
        public Boolean UnitDamageTarget(JassUnit whichUnit, JassWidget target, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return _UnitDamageTarget(whichUnit, target, amount, attack, ranged, attackType, damageType, weaponType);
        }

        //native IssueImmediateOrder takes unit whichUnit, string order returns boolean
        private delegate JassBoolean IssueImmediateOrderPrototype(JassUnit whichUnit, JassStringArg order);
        private IssueImmediateOrderPrototype _IssueImmediateOrder = WarcraftIII.Jass.GetNative("IssueImmediateOrder").ToDelegate<IssueImmediateOrderPrototype>();
        public Boolean IssueImmediateOrder(JassUnit whichUnit, String order)
        {
            return _IssueImmediateOrder(whichUnit, order);
        }

        //native IssueImmediateOrderById takes unit whichUnit, integer order returns boolean
        private delegate JassBoolean IssueImmediateOrderByIdPrototype(JassUnit whichUnit, JassOrder order);
        private IssueImmediateOrderByIdPrototype _IssueImmediateOrderById = WarcraftIII.Jass.GetNative("IssueImmediateOrderById").ToDelegate<IssueImmediateOrderByIdPrototype>();
        public Boolean IssueImmediateOrderById(JassUnit whichUnit, JassOrder order)
        {
            return _IssueImmediateOrderById(whichUnit, order);
        }

        //native IssuePointOrder takes unit whichUnit, string order, real x, real y returns boolean
        private delegate JassBoolean IssuePointOrderPrototype(JassUnit whichUnit, JassStringArg order, JassRealArg x, JassRealArg y);
        private IssuePointOrderPrototype _IssuePointOrder = WarcraftIII.Jass.GetNative("IssuePointOrder").ToDelegate<IssuePointOrderPrototype>();
        public Boolean IssuePointOrder(JassUnit whichUnit, String order, Single x, Single y)
        {
            return _IssuePointOrder(whichUnit, order, x, y);
        }

        //native IssuePointOrderLoc takes unit whichUnit, string order, location whichLocation returns boolean
        private delegate JassBoolean IssuePointOrderLocPrototype(JassUnit whichUnit, JassStringArg order, JassLocation whichLocation);
        private IssuePointOrderLocPrototype _IssuePointOrderLoc = WarcraftIII.Jass.GetNative("IssuePointOrderLoc").ToDelegate<IssuePointOrderLocPrototype>();
        public Boolean IssuePointOrderLoc(JassUnit whichUnit, String order, JassLocation whichLocation)
        {
            return _IssuePointOrderLoc(whichUnit, order, whichLocation);
        }

        //native IssuePointOrderById takes unit whichUnit, integer order, real x, real y returns boolean
        private delegate JassBoolean IssuePointOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassRealArg x, JassRealArg y);
        private IssuePointOrderByIdPrototype _IssuePointOrderById = WarcraftIII.Jass.GetNative("IssuePointOrderById").ToDelegate<IssuePointOrderByIdPrototype>();
        public Boolean IssuePointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y)
        {
            return _IssuePointOrderById(whichUnit, order, x, y);
        }

        //native IssuePointOrderByIdLoc takes unit whichUnit, integer order, location whichLocation returns boolean
        private delegate JassBoolean IssuePointOrderByIdLocPrototype(JassUnit whichUnit, JassOrder order, JassLocation whichLocation);
        private IssuePointOrderByIdLocPrototype _IssuePointOrderByIdLoc = WarcraftIII.Jass.GetNative("IssuePointOrderByIdLoc").ToDelegate<IssuePointOrderByIdLocPrototype>();
        public Boolean IssuePointOrderByIdLoc(JassUnit whichUnit, JassOrder order, JassLocation whichLocation)
        {
            return _IssuePointOrderByIdLoc(whichUnit, order, whichLocation);
        }

        //native IssueTargetOrder takes unit whichUnit, string order, widget targetWidget returns boolean
        private delegate JassBoolean IssueTargetOrderPrototype(JassUnit whichUnit, JassStringArg order, JassWidget targetWidget);
        private IssueTargetOrderPrototype _IssueTargetOrder = WarcraftIII.Jass.GetNative("IssueTargetOrder").ToDelegate<IssueTargetOrderPrototype>();
        public Boolean IssueTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget)
        {
            return _IssueTargetOrder(whichUnit, order, targetWidget);
        }

        //native IssueTargetOrderById takes unit whichUnit, integer order, widget targetWidget returns boolean
        private delegate JassBoolean IssueTargetOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassWidget targetWidget);
        private IssueTargetOrderByIdPrototype _IssueTargetOrderById = WarcraftIII.Jass.GetNative("IssueTargetOrderById").ToDelegate<IssueTargetOrderByIdPrototype>();
        public Boolean IssueTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget)
        {
            return _IssueTargetOrderById(whichUnit, order, targetWidget);
        }

        //native IssueInstantPointOrder takes unit whichUnit, string order, real x, real y, widget instantTargetWidget returns boolean
        private delegate JassBoolean IssueInstantPointOrderPrototype(JassUnit whichUnit, JassStringArg order, JassRealArg x, JassRealArg y, JassWidget instantTargetWidget);
        private IssueInstantPointOrderPrototype _IssueInstantPointOrder = WarcraftIII.Jass.GetNative("IssueInstantPointOrder").ToDelegate<IssueInstantPointOrderPrototype>();
        public Boolean IssueInstantPointOrder(JassUnit whichUnit, String order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return _IssueInstantPointOrder(whichUnit, order, x, y, instantTargetWidget);
        }

        //native IssueInstantPointOrderById takes unit whichUnit, integer order, real x, real y, widget instantTargetWidget returns boolean
        private delegate JassBoolean IssueInstantPointOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassRealArg x, JassRealArg y, JassWidget instantTargetWidget);
        private IssueInstantPointOrderByIdPrototype _IssueInstantPointOrderById = WarcraftIII.Jass.GetNative("IssueInstantPointOrderById").ToDelegate<IssueInstantPointOrderByIdPrototype>();
        public Boolean IssueInstantPointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return _IssueInstantPointOrderById(whichUnit, order, x, y, instantTargetWidget);
        }

        //native IssueInstantTargetOrder takes unit whichUnit, string order, widget targetWidget, widget instantTargetWidget returns boolean
        private delegate JassBoolean IssueInstantTargetOrderPrototype(JassUnit whichUnit, JassStringArg order, JassWidget targetWidget, JassWidget instantTargetWidget);
        private IssueInstantTargetOrderPrototype _IssueInstantTargetOrder = WarcraftIII.Jass.GetNative("IssueInstantTargetOrder").ToDelegate<IssueInstantTargetOrderPrototype>();
        public Boolean IssueInstantTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return _IssueInstantTargetOrder(whichUnit, order, targetWidget, instantTargetWidget);
        }

        //native IssueInstantTargetOrderById takes unit whichUnit, integer order, widget targetWidget, widget instantTargetWidget returns boolean
        private delegate JassBoolean IssueInstantTargetOrderByIdPrototype(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget);
        private IssueInstantTargetOrderByIdPrototype _IssueInstantTargetOrderById = WarcraftIII.Jass.GetNative("IssueInstantTargetOrderById").ToDelegate<IssueInstantTargetOrderByIdPrototype>();
        public Boolean IssueInstantTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return _IssueInstantTargetOrderById(whichUnit, order, targetWidget, instantTargetWidget);
        }

        //native IssueBuildOrder takes unit whichPeon, string unitToBuild, real x, real y returns boolean
        private delegate JassBoolean IssueBuildOrderPrototype(JassUnit whichPeon, JassStringArg unitToBuild, JassRealArg x, JassRealArg y);
        private IssueBuildOrderPrototype _IssueBuildOrder = WarcraftIII.Jass.GetNative("IssueBuildOrder").ToDelegate<IssueBuildOrderPrototype>();
        public Boolean IssueBuildOrder(JassUnit whichPeon, String unitToBuild, Single x, Single y)
        {
            return _IssueBuildOrder(whichPeon, unitToBuild, x, y);
        }

        //native IssueBuildOrderById takes unit whichPeon, integer unitId, real x, real y returns boolean
        private delegate JassBoolean IssueBuildOrderByIdPrototype(JassUnit whichPeon, JassUnitId unitId, JassRealArg x, JassRealArg y);
        private IssueBuildOrderByIdPrototype _IssueBuildOrderById = WarcraftIII.Jass.GetNative("IssueBuildOrderById").ToDelegate<IssueBuildOrderByIdPrototype>();
        public Boolean IssueBuildOrderById(JassUnit whichPeon, JassUnitId unitId, Single x, Single y)
        {
            return _IssueBuildOrderById(whichPeon, unitId, x, y);
        }

        //native IssueNeutralImmediateOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild returns boolean
        private delegate JassBoolean IssueNeutralImmediateOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassStringArg unitToBuild);
        private IssueNeutralImmediateOrderPrototype _IssueNeutralImmediateOrder = WarcraftIII.Jass.GetNative("IssueNeutralImmediateOrder").ToDelegate<IssueNeutralImmediateOrderPrototype>();
        public Boolean IssueNeutralImmediateOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild)
        {
            return _IssueNeutralImmediateOrder(forWhichPlayer, neutralStructure, unitToBuild);
        }

        //native IssueNeutralImmediateOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId returns boolean
        private delegate JassBoolean IssueNeutralImmediateOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassUnitId unitId);
        private IssueNeutralImmediateOrderByIdPrototype _IssueNeutralImmediateOrderById = WarcraftIII.Jass.GetNative("IssueNeutralImmediateOrderById").ToDelegate<IssueNeutralImmediateOrderByIdPrototype>();
        public Boolean IssueNeutralImmediateOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassUnitId unitId)
        {
            return _IssueNeutralImmediateOrderById(forWhichPlayer, neutralStructure, unitId);
        }

        //native IssueNeutralPointOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild, real x, real y returns boolean
        private delegate JassBoolean IssueNeutralPointOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassStringArg unitToBuild, JassRealArg x, JassRealArg y);
        private IssueNeutralPointOrderPrototype _IssueNeutralPointOrder = WarcraftIII.Jass.GetNative("IssueNeutralPointOrder").ToDelegate<IssueNeutralPointOrderPrototype>();
        public Boolean IssueNeutralPointOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, Single x, Single y)
        {
            return _IssueNeutralPointOrder(forWhichPlayer, neutralStructure, unitToBuild, x, y);
        }

        //native IssueNeutralPointOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId, real x, real y returns boolean
        private delegate JassBoolean IssueNeutralPointOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassUnitId unitId, JassRealArg x, JassRealArg y);
        private IssueNeutralPointOrderByIdPrototype _IssueNeutralPointOrderById = WarcraftIII.Jass.GetNative("IssueNeutralPointOrderById").ToDelegate<IssueNeutralPointOrderByIdPrototype>();
        public Boolean IssueNeutralPointOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassUnitId unitId, Single x, Single y)
        {
            return _IssueNeutralPointOrderById(forWhichPlayer, neutralStructure, unitId, x, y);
        }

        //native IssueNeutralTargetOrder takes player forWhichPlayer, unit neutralStructure, string unitToBuild, widget target returns boolean
        private delegate JassBoolean IssueNeutralTargetOrderPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassStringArg unitToBuild, JassWidget target);
        private IssueNeutralTargetOrderPrototype _IssueNeutralTargetOrder = WarcraftIII.Jass.GetNative("IssueNeutralTargetOrder").ToDelegate<IssueNeutralTargetOrderPrototype>();
        public Boolean IssueNeutralTargetOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassWidget target)
        {
            return _IssueNeutralTargetOrder(forWhichPlayer, neutralStructure, unitToBuild, target);
        }

        //native IssueNeutralTargetOrderById takes player forWhichPlayer, unit neutralStructure, integer unitId, widget target returns boolean
        private delegate JassBoolean IssueNeutralTargetOrderByIdPrototype(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassUnitId unitId, JassWidget target);
        private IssueNeutralTargetOrderByIdPrototype _IssueNeutralTargetOrderById = WarcraftIII.Jass.GetNative("IssueNeutralTargetOrderById").ToDelegate<IssueNeutralTargetOrderByIdPrototype>();
        public Boolean IssueNeutralTargetOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassUnitId unitId, JassWidget target)
        {
            return _IssueNeutralTargetOrderById(forWhichPlayer, neutralStructure, unitId, target);
        }

        //native GetUnitCurrentOrder takes unit whichUnit returns integer
        private delegate JassInteger GetUnitCurrentOrderPrototype(JassUnit whichUnit);
        private GetUnitCurrentOrderPrototype _GetUnitCurrentOrder = WarcraftIII.Jass.GetNative("GetUnitCurrentOrder").ToDelegate<GetUnitCurrentOrderPrototype>();
        public JassInteger GetUnitCurrentOrder(JassUnit whichUnit)
        {
            return _GetUnitCurrentOrder(whichUnit);
        }

        //native SetResourceAmount takes unit whichUnit, integer amount returns nothing
        private delegate void SetResourceAmountPrototype(JassUnit whichUnit, JassInteger amount);
        private SetResourceAmountPrototype _SetResourceAmount = WarcraftIII.Jass.GetNative("SetResourceAmount").ToDelegate<SetResourceAmountPrototype>();
        public void SetResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            _SetResourceAmount(whichUnit, amount);
        }

        //native AddResourceAmount takes unit whichUnit, integer amount returns nothing
        private delegate void AddResourceAmountPrototype(JassUnit whichUnit, JassInteger amount);
        private AddResourceAmountPrototype _AddResourceAmount = WarcraftIII.Jass.GetNative("AddResourceAmount").ToDelegate<AddResourceAmountPrototype>();
        public void AddResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            _AddResourceAmount(whichUnit, amount);
        }

        //native GetResourceAmount takes unit whichUnit returns integer
        private delegate JassInteger GetResourceAmountPrototype(JassUnit whichUnit);
        private GetResourceAmountPrototype _GetResourceAmount = WarcraftIII.Jass.GetNative("GetResourceAmount").ToDelegate<GetResourceAmountPrototype>();
        public JassInteger GetResourceAmount(JassUnit whichUnit)
        {
            return _GetResourceAmount(whichUnit);
        }

        //native WaygateGetDestinationX takes unit waygate returns real
        private delegate JassRealRet WaygateGetDestinationXPrototype(JassUnit waygate);
        private WaygateGetDestinationXPrototype _WaygateGetDestinationX = WarcraftIII.Jass.GetNative("WaygateGetDestinationX").ToDelegate<WaygateGetDestinationXPrototype>();
        public Single WaygateGetDestinationX(JassUnit waygate)
        {
            return _WaygateGetDestinationX(waygate);
        }

        //native WaygateGetDestinationY takes unit waygate returns real
        private delegate JassRealRet WaygateGetDestinationYPrototype(JassUnit waygate);
        private WaygateGetDestinationYPrototype _WaygateGetDestinationY = WarcraftIII.Jass.GetNative("WaygateGetDestinationY").ToDelegate<WaygateGetDestinationYPrototype>();
        public Single WaygateGetDestinationY(JassUnit waygate)
        {
            return _WaygateGetDestinationY(waygate);
        }

        //native WaygateSetDestination takes unit waygate, real x, real y returns nothing
        private delegate void WaygateSetDestinationPrototype(JassUnit waygate, JassRealArg x, JassRealArg y);
        private WaygateSetDestinationPrototype _WaygateSetDestination = WarcraftIII.Jass.GetNative("WaygateSetDestination").ToDelegate<WaygateSetDestinationPrototype>();
        public void WaygateSetDestination(JassUnit waygate, Single x, Single y)
        {
            _WaygateSetDestination(waygate, x, y);
        }

        //native WaygateActivate takes unit waygate, boolean activate returns nothing
        private delegate void WaygateActivatePrototype(JassUnit waygate, JassBoolean activate);
        private WaygateActivatePrototype _WaygateActivate = WarcraftIII.Jass.GetNative("WaygateActivate").ToDelegate<WaygateActivatePrototype>();
        public void WaygateActivate(JassUnit waygate, Boolean activate)
        {
            _WaygateActivate(waygate, activate);
        }

        //native WaygateIsActive takes unit waygate returns boolean
        private delegate JassBoolean WaygateIsActivePrototype(JassUnit waygate);
        private WaygateIsActivePrototype _WaygateIsActive = WarcraftIII.Jass.GetNative("WaygateIsActive").ToDelegate<WaygateIsActivePrototype>();
        public Boolean WaygateIsActive(JassUnit waygate)
        {
            return _WaygateIsActive(waygate);
        }

        //native AddItemToAllStock takes integer itemId, integer currentStock, integer stockMax returns nothing
        private delegate void AddItemToAllStockPrototype(JassInteger itemId, JassInteger currentStock, JassInteger stockMax);
        private AddItemToAllStockPrototype _AddItemToAllStock = WarcraftIII.Jass.GetNative("AddItemToAllStock").ToDelegate<AddItemToAllStockPrototype>();
        public void AddItemToAllStock(JassInteger itemId, JassInteger currentStock, JassInteger stockMax)
        {
            _AddItemToAllStock(itemId, currentStock, stockMax);
        }

        //native AddItemToStock takes unit whichUnit, integer itemId, integer currentStock, integer stockMax returns nothing
        private delegate void AddItemToStockPrototype(JassUnit whichUnit, JassInteger itemId, JassInteger currentStock, JassInteger stockMax);
        private AddItemToStockPrototype _AddItemToStock = WarcraftIII.Jass.GetNative("AddItemToStock").ToDelegate<AddItemToStockPrototype>();
        public void AddItemToStock(JassUnit whichUnit, JassInteger itemId, JassInteger currentStock, JassInteger stockMax)
        {
            _AddItemToStock(whichUnit, itemId, currentStock, stockMax);
        }

        //native AddUnitToAllStock takes integer unitId, integer currentStock, integer stockMax returns nothing
        private delegate void AddUnitToAllStockPrototype(JassUnitId unitId, JassInteger currentStock, JassInteger stockMax);
        private AddUnitToAllStockPrototype _AddUnitToAllStock = WarcraftIII.Jass.GetNative("AddUnitToAllStock").ToDelegate<AddUnitToAllStockPrototype>();
        public void AddUnitToAllStock(JassUnitId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            _AddUnitToAllStock(unitId, currentStock, stockMax);
        }

        //native AddUnitToStock takes unit whichUnit, integer unitId, integer currentStock, integer stockMax returns nothing
        private delegate void AddUnitToStockPrototype(JassUnit whichUnit, JassUnitId unitId, JassInteger currentStock, JassInteger stockMax);
        private AddUnitToStockPrototype _AddUnitToStock = WarcraftIII.Jass.GetNative("AddUnitToStock").ToDelegate<AddUnitToStockPrototype>();
        public void AddUnitToStock(JassUnit whichUnit, JassUnitId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            _AddUnitToStock(whichUnit, unitId, currentStock, stockMax);
        }

        //native RemoveItemFromAllStock takes integer itemId returns nothing
        private delegate void RemoveItemFromAllStockPrototype(JassInteger itemId);
        private RemoveItemFromAllStockPrototype _RemoveItemFromAllStock = WarcraftIII.Jass.GetNative("RemoveItemFromAllStock").ToDelegate<RemoveItemFromAllStockPrototype>();
        public void RemoveItemFromAllStock(JassInteger itemId)
        {
            _RemoveItemFromAllStock(itemId);
        }

        //native RemoveItemFromStock takes unit whichUnit, integer itemId returns nothing
        private delegate void RemoveItemFromStockPrototype(JassUnit whichUnit, JassInteger itemId);
        private RemoveItemFromStockPrototype _RemoveItemFromStock = WarcraftIII.Jass.GetNative("RemoveItemFromStock").ToDelegate<RemoveItemFromStockPrototype>();
        public void RemoveItemFromStock(JassUnit whichUnit, JassInteger itemId)
        {
            _RemoveItemFromStock(whichUnit, itemId);
        }

        //native RemoveUnitFromAllStock takes integer unitId returns nothing
        private delegate void RemoveUnitFromAllStockPrototype(JassUnitId unitId);
        private RemoveUnitFromAllStockPrototype _RemoveUnitFromAllStock = WarcraftIII.Jass.GetNative("RemoveUnitFromAllStock").ToDelegate<RemoveUnitFromAllStockPrototype>();
        public void RemoveUnitFromAllStock(JassUnitId unitId)
        {
            _RemoveUnitFromAllStock(unitId);
        }

        //native RemoveUnitFromStock takes unit whichUnit, integer unitId returns nothing
        private delegate void RemoveUnitFromStockPrototype(JassUnit whichUnit, JassUnitId unitId);
        private RemoveUnitFromStockPrototype _RemoveUnitFromStock = WarcraftIII.Jass.GetNative("RemoveUnitFromStock").ToDelegate<RemoveUnitFromStockPrototype>();
        public void RemoveUnitFromStock(JassUnit whichUnit, JassUnitId unitId)
        {
            _RemoveUnitFromStock(whichUnit, unitId);
        }

        //native SetAllItemTypeSlots takes integer slots returns nothing
        private delegate void SetAllItemTypeSlotsPrototype(JassInteger slots);
        private SetAllItemTypeSlotsPrototype _SetAllItemTypeSlots = WarcraftIII.Jass.GetNative("SetAllItemTypeSlots").ToDelegate<SetAllItemTypeSlotsPrototype>();
        public void SetAllItemTypeSlots(JassInteger slots)
        {
            _SetAllItemTypeSlots(slots);
        }

        //native SetAllUnitTypeSlots takes integer slots returns nothing
        private delegate void SetAllUnitTypeSlotsPrototype(JassInteger slots);
        private SetAllUnitTypeSlotsPrototype _SetAllUnitTypeSlots = WarcraftIII.Jass.GetNative("SetAllUnitTypeSlots").ToDelegate<SetAllUnitTypeSlotsPrototype>();
        public void SetAllUnitTypeSlots(JassInteger slots)
        {
            _SetAllUnitTypeSlots(slots);
        }

        //native SetItemTypeSlots takes unit whichUnit, integer slots returns nothing
        private delegate void SetItemTypeSlotsPrototype(JassUnit whichUnit, JassInteger slots);
        private SetItemTypeSlotsPrototype _SetItemTypeSlots = WarcraftIII.Jass.GetNative("SetItemTypeSlots").ToDelegate<SetItemTypeSlotsPrototype>();
        public void SetItemTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            _SetItemTypeSlots(whichUnit, slots);
        }

        //native SetUnitTypeSlots takes unit whichUnit, integer slots returns nothing
        private delegate void SetUnitTypeSlotsPrototype(JassUnit whichUnit, JassInteger slots);
        private SetUnitTypeSlotsPrototype _SetUnitTypeSlots = WarcraftIII.Jass.GetNative("SetUnitTypeSlots").ToDelegate<SetUnitTypeSlotsPrototype>();
        public void SetUnitTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            _SetUnitTypeSlots(whichUnit, slots);
        }

        //native GetUnitUserData takes unit whichUnit returns integer
        private delegate JassInteger GetUnitUserDataPrototype(JassUnit whichUnit);
        private GetUnitUserDataPrototype _GetUnitUserData = WarcraftIII.Jass.GetNative("GetUnitUserData").ToDelegate<GetUnitUserDataPrototype>();
        public JassInteger GetUnitUserData(JassUnit whichUnit)
        {
            return _GetUnitUserData(whichUnit);
        }

        //native SetUnitUserData takes unit whichUnit, integer data returns nothing
        private delegate void SetUnitUserDataPrototype(JassUnit whichUnit, JassInteger data);
        private SetUnitUserDataPrototype _SetUnitUserData = WarcraftIII.Jass.GetNative("SetUnitUserData").ToDelegate<SetUnitUserDataPrototype>();
        public void SetUnitUserData(JassUnit whichUnit, JassInteger data)
        {
            _SetUnitUserData(whichUnit, data);
        }

        //native Player takes integer number returns player
        private delegate JassPlayer PlayerPrototype(JassInteger number);
        private PlayerPrototype _Player = WarcraftIII.Jass.GetNative("Player").ToDelegate<PlayerPrototype>();
        public JassPlayer Player(JassInteger number)
        {
            return _Player(number);
        }

        //native GetLocalPlayer takes nothing returns player
        private delegate JassPlayer GetLocalPlayerPrototype();
        private GetLocalPlayerPrototype _GetLocalPlayer = WarcraftIII.Jass.GetNative("GetLocalPlayer").ToDelegate<GetLocalPlayerPrototype>();
        public JassPlayer GetLocalPlayer()
        {
            return _GetLocalPlayer();
        }

        //native IsPlayerAlly takes player whichPlayer, player otherPlayer returns boolean
        private delegate JassBoolean IsPlayerAllyPrototype(JassPlayer whichPlayer, JassPlayer otherPlayer);
        private IsPlayerAllyPrototype _IsPlayerAlly = WarcraftIII.Jass.GetNative("IsPlayerAlly").ToDelegate<IsPlayerAllyPrototype>();
        public Boolean IsPlayerAlly(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return _IsPlayerAlly(whichPlayer, otherPlayer);
        }

        //native IsPlayerEnemy takes player whichPlayer, player otherPlayer returns boolean
        private delegate JassBoolean IsPlayerEnemyPrototype(JassPlayer whichPlayer, JassPlayer otherPlayer);
        private IsPlayerEnemyPrototype _IsPlayerEnemy = WarcraftIII.Jass.GetNative("IsPlayerEnemy").ToDelegate<IsPlayerEnemyPrototype>();
        public Boolean IsPlayerEnemy(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return _IsPlayerEnemy(whichPlayer, otherPlayer);
        }

        //native IsPlayerInForce takes player whichPlayer, force whichForce returns boolean
        private delegate JassBoolean IsPlayerInForcePrototype(JassPlayer whichPlayer, JassForce whichForce);
        private IsPlayerInForcePrototype _IsPlayerInForce = WarcraftIII.Jass.GetNative("IsPlayerInForce").ToDelegate<IsPlayerInForcePrototype>();
        public Boolean IsPlayerInForce(JassPlayer whichPlayer, JassForce whichForce)
        {
            return _IsPlayerInForce(whichPlayer, whichForce);
        }

        //native IsPlayerObserver takes player whichPlayer returns boolean
        private delegate JassBoolean IsPlayerObserverPrototype(JassPlayer whichPlayer);
        private IsPlayerObserverPrototype _IsPlayerObserver = WarcraftIII.Jass.GetNative("IsPlayerObserver").ToDelegate<IsPlayerObserverPrototype>();
        public Boolean IsPlayerObserver(JassPlayer whichPlayer)
        {
            return _IsPlayerObserver(whichPlayer);
        }

        //native IsVisibleToPlayer takes real x, real y, player whichPlayer returns boolean
        private delegate JassBoolean IsVisibleToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private IsVisibleToPlayerPrototype _IsVisibleToPlayer = WarcraftIII.Jass.GetNative("IsVisibleToPlayer").ToDelegate<IsVisibleToPlayerPrototype>();
        public Boolean IsVisibleToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return _IsVisibleToPlayer(x, y, whichPlayer);
        }

        //native IsLocationVisibleToPlayer takes location whichLocation, player whichPlayer returns boolean
        private delegate JassBoolean IsLocationVisibleToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private IsLocationVisibleToPlayerPrototype _IsLocationVisibleToPlayer = WarcraftIII.Jass.GetNative("IsLocationVisibleToPlayer").ToDelegate<IsLocationVisibleToPlayerPrototype>();
        public Boolean IsLocationVisibleToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return _IsLocationVisibleToPlayer(whichLocation, whichPlayer);
        }

        //native IsFoggedToPlayer takes real x, real y, player whichPlayer returns boolean
        private delegate JassBoolean IsFoggedToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private IsFoggedToPlayerPrototype _IsFoggedToPlayer = WarcraftIII.Jass.GetNative("IsFoggedToPlayer").ToDelegate<IsFoggedToPlayerPrototype>();
        public Boolean IsFoggedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return _IsFoggedToPlayer(x, y, whichPlayer);
        }

        //native IsLocationFoggedToPlayer takes location whichLocation, player whichPlayer returns boolean
        private delegate JassBoolean IsLocationFoggedToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private IsLocationFoggedToPlayerPrototype _IsLocationFoggedToPlayer = WarcraftIII.Jass.GetNative("IsLocationFoggedToPlayer").ToDelegate<IsLocationFoggedToPlayerPrototype>();
        public Boolean IsLocationFoggedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return _IsLocationFoggedToPlayer(whichLocation, whichPlayer);
        }

        //native IsMaskedToPlayer takes real x, real y, player whichPlayer returns boolean
        private delegate JassBoolean IsMaskedToPlayerPrototype(JassRealArg x, JassRealArg y, JassPlayer whichPlayer);
        private IsMaskedToPlayerPrototype _IsMaskedToPlayer = WarcraftIII.Jass.GetNative("IsMaskedToPlayer").ToDelegate<IsMaskedToPlayerPrototype>();
        public Boolean IsMaskedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return _IsMaskedToPlayer(x, y, whichPlayer);
        }

        //native IsLocationMaskedToPlayer takes location whichLocation, player whichPlayer returns boolean
        private delegate JassBoolean IsLocationMaskedToPlayerPrototype(JassLocation whichLocation, JassPlayer whichPlayer);
        private IsLocationMaskedToPlayerPrototype _IsLocationMaskedToPlayer = WarcraftIII.Jass.GetNative("IsLocationMaskedToPlayer").ToDelegate<IsLocationMaskedToPlayerPrototype>();
        public Boolean IsLocationMaskedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return _IsLocationMaskedToPlayer(whichLocation, whichPlayer);
        }

        //native GetPlayerRace takes player whichPlayer returns race
        private delegate JassRace GetPlayerRacePrototype(JassPlayer whichPlayer);
        private GetPlayerRacePrototype _GetPlayerRace = WarcraftIII.Jass.GetNative("GetPlayerRace").ToDelegate<GetPlayerRacePrototype>();
        public JassRace GetPlayerRace(JassPlayer whichPlayer)
        {
            return _GetPlayerRace(whichPlayer);
        }

        //native GetPlayerId takes player whichPlayer returns integer
        private delegate JassInteger GetPlayerIdPrototype(JassPlayer whichPlayer);
        private GetPlayerIdPrototype _GetPlayerId = WarcraftIII.Jass.GetNative("GetPlayerId").ToDelegate<GetPlayerIdPrototype>();
        public JassInteger GetPlayerId(JassPlayer whichPlayer)
        {
            return _GetPlayerId(whichPlayer);
        }

        //native GetPlayerUnitCount takes player whichPlayer, boolean includeIncomplete returns integer
        private delegate JassInteger GetPlayerUnitCountPrototype(JassPlayer whichPlayer, JassBoolean includeIncomplete);
        private GetPlayerUnitCountPrototype _GetPlayerUnitCount = WarcraftIII.Jass.GetNative("GetPlayerUnitCount").ToDelegate<GetPlayerUnitCountPrototype>();
        public JassInteger GetPlayerUnitCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return _GetPlayerUnitCount(whichPlayer, includeIncomplete);
        }

        //native GetPlayerTypedUnitCount takes player whichPlayer, string unitName, boolean includeIncomplete, boolean includeUpgrades returns integer
        private delegate JassInteger GetPlayerTypedUnitCountPrototype(JassPlayer whichPlayer, JassStringArg unitName, JassBoolean includeIncomplete, JassBoolean includeUpgrades);
        private GetPlayerTypedUnitCountPrototype _GetPlayerTypedUnitCount = WarcraftIII.Jass.GetNative("GetPlayerTypedUnitCount").ToDelegate<GetPlayerTypedUnitCountPrototype>();
        public JassInteger GetPlayerTypedUnitCount(JassPlayer whichPlayer, String unitName, Boolean includeIncomplete, Boolean includeUpgrades)
        {
            return _GetPlayerTypedUnitCount(whichPlayer, unitName, includeIncomplete, includeUpgrades);
        }

        //native GetPlayerStructureCount takes player whichPlayer, boolean includeIncomplete returns integer
        private delegate JassInteger GetPlayerStructureCountPrototype(JassPlayer whichPlayer, JassBoolean includeIncomplete);
        private GetPlayerStructureCountPrototype _GetPlayerStructureCount = WarcraftIII.Jass.GetNative("GetPlayerStructureCount").ToDelegate<GetPlayerStructureCountPrototype>();
        public JassInteger GetPlayerStructureCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return _GetPlayerStructureCount(whichPlayer, includeIncomplete);
        }

        //native GetPlayerState takes player whichPlayer, playerstate whichPlayerState returns integer
        private delegate JassInteger GetPlayerStatePrototype(JassPlayer whichPlayer, JassPlayerState whichPlayerState);
        private GetPlayerStatePrototype _GetPlayerState = WarcraftIII.Jass.GetNative("GetPlayerState").ToDelegate<GetPlayerStatePrototype>();
        public JassInteger GetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState)
        {
            return _GetPlayerState(whichPlayer, whichPlayerState);
        }

        //native GetPlayerScore takes player whichPlayer, playerscore whichPlayerScore returns integer
        private delegate JassInteger GetPlayerScorePrototype(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore);
        private GetPlayerScorePrototype _GetPlayerScore = WarcraftIII.Jass.GetNative("GetPlayerScore").ToDelegate<GetPlayerScorePrototype>();
        public JassInteger GetPlayerScore(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore)
        {
            return _GetPlayerScore(whichPlayer, whichPlayerScore);
        }

        //native GetPlayerAlliance takes player sourcePlayer, player otherPlayer, alliancetype whichAllianceSetting returns boolean
        private delegate JassBoolean GetPlayerAlliancePrototype(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting);
        private GetPlayerAlliancePrototype _GetPlayerAlliance = WarcraftIII.Jass.GetNative("GetPlayerAlliance").ToDelegate<GetPlayerAlliancePrototype>();
        public Boolean GetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting)
        {
            return _GetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting);
        }

        //native GetPlayerHandicap takes player whichPlayer returns real
        private delegate JassRealRet GetPlayerHandicapPrototype(JassPlayer whichPlayer);
        private GetPlayerHandicapPrototype _GetPlayerHandicap = WarcraftIII.Jass.GetNative("GetPlayerHandicap").ToDelegate<GetPlayerHandicapPrototype>();
        public Single GetPlayerHandicap(JassPlayer whichPlayer)
        {
            return _GetPlayerHandicap(whichPlayer);
        }

        //native GetPlayerHandicapXP takes player whichPlayer returns real
        private delegate JassRealRet GetPlayerHandicapXPPrototype(JassPlayer whichPlayer);
        private GetPlayerHandicapXPPrototype _GetPlayerHandicapXP = WarcraftIII.Jass.GetNative("GetPlayerHandicapXP").ToDelegate<GetPlayerHandicapXPPrototype>();
        public Single GetPlayerHandicapXP(JassPlayer whichPlayer)
        {
            return _GetPlayerHandicapXP(whichPlayer);
        }

        //native SetPlayerHandicap takes player whichPlayer, real handicap returns nothing
        private delegate void SetPlayerHandicapPrototype(JassPlayer whichPlayer, JassRealArg handicap);
        private SetPlayerHandicapPrototype _SetPlayerHandicap = WarcraftIII.Jass.GetNative("SetPlayerHandicap").ToDelegate<SetPlayerHandicapPrototype>();
        public void SetPlayerHandicap(JassPlayer whichPlayer, Single handicap)
        {
            _SetPlayerHandicap(whichPlayer, handicap);
        }

        //native SetPlayerHandicapXP takes player whichPlayer, real handicap returns nothing
        private delegate void SetPlayerHandicapXPPrototype(JassPlayer whichPlayer, JassRealArg handicap);
        private SetPlayerHandicapXPPrototype _SetPlayerHandicapXP = WarcraftIII.Jass.GetNative("SetPlayerHandicapXP").ToDelegate<SetPlayerHandicapXPPrototype>();
        public void SetPlayerHandicapXP(JassPlayer whichPlayer, Single handicap)
        {
            _SetPlayerHandicapXP(whichPlayer, handicap);
        }

        //native SetPlayerTechMaxAllowed takes player whichPlayer, integer techid, integer maximum returns nothing
        private delegate void SetPlayerTechMaxAllowedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum);
        private SetPlayerTechMaxAllowedPrototype _SetPlayerTechMaxAllowed = WarcraftIII.Jass.GetNative("SetPlayerTechMaxAllowed").ToDelegate<SetPlayerTechMaxAllowedPrototype>();
        public void SetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum)
        {
            _SetPlayerTechMaxAllowed(whichPlayer, techid, maximum);
        }

        //native GetPlayerTechMaxAllowed takes player whichPlayer, integer techid returns integer
        private delegate JassInteger GetPlayerTechMaxAllowedPrototype(JassPlayer whichPlayer, JassInteger techid);
        private GetPlayerTechMaxAllowedPrototype _GetPlayerTechMaxAllowed = WarcraftIII.Jass.GetNative("GetPlayerTechMaxAllowed").ToDelegate<GetPlayerTechMaxAllowedPrototype>();
        public JassInteger GetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid)
        {
            return _GetPlayerTechMaxAllowed(whichPlayer, techid);
        }

        //native AddPlayerTechResearched takes player whichPlayer, integer techid, integer levels returns nothing
        private delegate void AddPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger levels);
        private AddPlayerTechResearchedPrototype _AddPlayerTechResearched = WarcraftIII.Jass.GetNative("AddPlayerTechResearched").ToDelegate<AddPlayerTechResearchedPrototype>();
        public void AddPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger levels)
        {
            _AddPlayerTechResearched(whichPlayer, techid, levels);
        }

        //native SetPlayerTechResearched takes player whichPlayer, integer techid, integer setToLevel returns nothing
        private delegate void SetPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel);
        private SetPlayerTechResearchedPrototype _SetPlayerTechResearched = WarcraftIII.Jass.GetNative("SetPlayerTechResearched").ToDelegate<SetPlayerTechResearchedPrototype>();
        public void SetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel)
        {
            _SetPlayerTechResearched(whichPlayer, techid, setToLevel);
        }

        //native GetPlayerTechResearched takes player whichPlayer, integer techid, boolean specificonly returns boolean
        private delegate JassBoolean GetPlayerTechResearchedPrototype(JassPlayer whichPlayer, JassInteger techid, JassBoolean specificonly);
        private GetPlayerTechResearchedPrototype _GetPlayerTechResearched = WarcraftIII.Jass.GetNative("GetPlayerTechResearched").ToDelegate<GetPlayerTechResearchedPrototype>();
        public Boolean GetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return _GetPlayerTechResearched(whichPlayer, techid, specificonly);
        }

        //native GetPlayerTechCount takes player whichPlayer, integer techid, boolean specificonly returns integer
        private delegate JassInteger GetPlayerTechCountPrototype(JassPlayer whichPlayer, JassInteger techid, JassBoolean specificonly);
        private GetPlayerTechCountPrototype _GetPlayerTechCount = WarcraftIII.Jass.GetNative("GetPlayerTechCount").ToDelegate<GetPlayerTechCountPrototype>();
        public JassInteger GetPlayerTechCount(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return _GetPlayerTechCount(whichPlayer, techid, specificonly);
        }

        //native SetPlayerUnitsOwner takes player whichPlayer, integer newOwner returns nothing
        private delegate void SetPlayerUnitsOwnerPrototype(JassPlayer whichPlayer, JassInteger newOwner);
        private SetPlayerUnitsOwnerPrototype _SetPlayerUnitsOwner = WarcraftIII.Jass.GetNative("SetPlayerUnitsOwner").ToDelegate<SetPlayerUnitsOwnerPrototype>();
        public void SetPlayerUnitsOwner(JassPlayer whichPlayer, JassInteger newOwner)
        {
            _SetPlayerUnitsOwner(whichPlayer, newOwner);
        }

        //native CripplePlayer takes player whichPlayer, force toWhichPlayers, boolean flag returns nothing
        private delegate void CripplePlayerPrototype(JassPlayer whichPlayer, JassForce toWhichPlayers, JassBoolean flag);
        private CripplePlayerPrototype _CripplePlayer = WarcraftIII.Jass.GetNative("CripplePlayer").ToDelegate<CripplePlayerPrototype>();
        public void CripplePlayer(JassPlayer whichPlayer, JassForce toWhichPlayers, Boolean flag)
        {
            _CripplePlayer(whichPlayer, toWhichPlayers, flag);
        }

        //native SetPlayerAbilityAvailable takes player whichPlayer, integer abilid, boolean avail returns nothing
        private delegate void SetPlayerAbilityAvailablePrototype(JassPlayer whichPlayer, JassInteger abilid, JassBoolean avail);
        private SetPlayerAbilityAvailablePrototype _SetPlayerAbilityAvailable = WarcraftIII.Jass.GetNative("SetPlayerAbilityAvailable").ToDelegate<SetPlayerAbilityAvailablePrototype>();
        public void SetPlayerAbilityAvailable(JassPlayer whichPlayer, JassInteger abilid, Boolean avail)
        {
            _SetPlayerAbilityAvailable(whichPlayer, abilid, avail);
        }

        //native SetPlayerState takes player whichPlayer, playerstate whichPlayerState, integer value returns nothing
        private delegate void SetPlayerStatePrototype(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value);
        private SetPlayerStatePrototype _SetPlayerState = WarcraftIII.Jass.GetNative("SetPlayerState").ToDelegate<SetPlayerStatePrototype>();
        public void SetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value)
        {
            _SetPlayerState(whichPlayer, whichPlayerState, value);
        }

        //native RemovePlayer takes player whichPlayer, playergameresult gameResult returns nothing
        private delegate void RemovePlayerPrototype(JassPlayer whichPlayer, JassPlayerGameResult gameResult);
        private RemovePlayerPrototype _RemovePlayer = WarcraftIII.Jass.GetNative("RemovePlayer").ToDelegate<RemovePlayerPrototype>();
        public void RemovePlayer(JassPlayer whichPlayer, JassPlayerGameResult gameResult)
        {
            _RemovePlayer(whichPlayer, gameResult);
        }

        //native CachePlayerHeroData takes player whichPlayer returns nothing
        private delegate void CachePlayerHeroDataPrototype(JassPlayer whichPlayer);
        private CachePlayerHeroDataPrototype _CachePlayerHeroData = WarcraftIII.Jass.GetNative("CachePlayerHeroData").ToDelegate<CachePlayerHeroDataPrototype>();
        public void CachePlayerHeroData(JassPlayer whichPlayer)
        {
            _CachePlayerHeroData(whichPlayer);
        }

        //native SetFogStateRect takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision returns nothing
        private delegate void SetFogStateRectPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, JassBoolean useSharedVision);
        private SetFogStateRectPrototype _SetFogStateRect = WarcraftIII.Jass.GetNative("SetFogStateRect").ToDelegate<SetFogStateRectPrototype>();
        public void SetFogStateRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision)
        {
            _SetFogStateRect(forWhichPlayer, whichState, where, useSharedVision);
        }

        //native SetFogStateRadius takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision returns nothing
        private delegate void SetFogStateRadiusPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRealArg centerx, JassRealArg centerY, JassRealArg radius, JassBoolean useSharedVision);
        private SetFogStateRadiusPrototype _SetFogStateRadius = WarcraftIII.Jass.GetNative("SetFogStateRadius").ToDelegate<SetFogStateRadiusPrototype>();
        public void SetFogStateRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision)
        {
            _SetFogStateRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision);
        }

        //native SetFogStateRadiusLoc takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision returns nothing
        private delegate void SetFogStateRadiusLocPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, JassRealArg radius, JassBoolean useSharedVision);
        private SetFogStateRadiusLocPrototype _SetFogStateRadiusLoc = WarcraftIII.Jass.GetNative("SetFogStateRadiusLoc").ToDelegate<SetFogStateRadiusLocPrototype>();
        public void SetFogStateRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision)
        {
            _SetFogStateRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision);
        }

        //native FogMaskEnable takes boolean enable returns nothing
        private delegate void FogMaskEnablePrototype(JassBoolean enable);
        private FogMaskEnablePrototype _FogMaskEnable = WarcraftIII.Jass.GetNative("FogMaskEnable").ToDelegate<FogMaskEnablePrototype>();
        public void FogMaskEnable(Boolean enable)
        {
            _FogMaskEnable(enable);
        }

        //native IsFogMaskEnabled takes nothing returns boolean
        private delegate JassBoolean IsFogMaskEnabledPrototype();
        private IsFogMaskEnabledPrototype _IsFogMaskEnabled = WarcraftIII.Jass.GetNative("IsFogMaskEnabled").ToDelegate<IsFogMaskEnabledPrototype>();
        public Boolean IsFogMaskEnabled()
        {
            return _IsFogMaskEnabled();
        }

        //native FogEnable takes boolean enable returns nothing
        private delegate void FogEnablePrototype(JassBoolean enable);
        private FogEnablePrototype _FogEnable = WarcraftIII.Jass.GetNative("FogEnable").ToDelegate<FogEnablePrototype>();
        public void FogEnable(Boolean enable)
        {
            _FogEnable(enable);
        }

        //native IsFogEnabled takes nothing returns boolean
        private delegate JassBoolean IsFogEnabledPrototype();
        private IsFogEnabledPrototype _IsFogEnabled = WarcraftIII.Jass.GetNative("IsFogEnabled").ToDelegate<IsFogEnabledPrototype>();
        public Boolean IsFogEnabled()
        {
            return _IsFogEnabled();
        }

        //native CreateFogModifierRect takes player forWhichPlayer, fogstate whichState, rect where, boolean useSharedVision, boolean afterUnits returns fogmodifier
        private delegate JassFogModifier CreateFogModifierRectPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, JassBoolean useSharedVision, JassBoolean afterUnits);
        private CreateFogModifierRectPrototype _CreateFogModifierRect = WarcraftIII.Jass.GetNative("CreateFogModifierRect").ToDelegate<CreateFogModifierRectPrototype>();
        public JassFogModifier CreateFogModifierRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision, Boolean afterUnits)
        {
            return _CreateFogModifierRect(forWhichPlayer, whichState, where, useSharedVision, afterUnits);
        }

        //native CreateFogModifierRadius takes player forWhichPlayer, fogstate whichState, real centerx, real centerY, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
        private delegate JassFogModifier CreateFogModifierRadiusPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassRealArg centerx, JassRealArg centerY, JassRealArg radius, JassBoolean useSharedVision, JassBoolean afterUnits);
        private CreateFogModifierRadiusPrototype _CreateFogModifierRadius = WarcraftIII.Jass.GetNative("CreateFogModifierRadius").ToDelegate<CreateFogModifierRadiusPrototype>();
        public JassFogModifier CreateFogModifierRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return _CreateFogModifierRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision, afterUnits);
        }

        //native CreateFogModifierRadiusLoc takes player forWhichPlayer, fogstate whichState, location center, real radius, boolean useSharedVision, boolean afterUnits returns fogmodifier
        private delegate JassFogModifier CreateFogModifierRadiusLocPrototype(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, JassRealArg radius, JassBoolean useSharedVision, JassBoolean afterUnits);
        private CreateFogModifierRadiusLocPrototype _CreateFogModifierRadiusLoc = WarcraftIII.Jass.GetNative("CreateFogModifierRadiusLoc").ToDelegate<CreateFogModifierRadiusLocPrototype>();
        public JassFogModifier CreateFogModifierRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return _CreateFogModifierRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision, afterUnits);
        }

        //native DestroyFogModifier takes fogmodifier whichFogModifier returns nothing
        private delegate void DestroyFogModifierPrototype(JassFogModifier whichFogModifier);
        private DestroyFogModifierPrototype _DestroyFogModifier = WarcraftIII.Jass.GetNative("DestroyFogModifier").ToDelegate<DestroyFogModifierPrototype>();
        public void DestroyFogModifier(JassFogModifier whichFogModifier)
        {
            _DestroyFogModifier(whichFogModifier);
        }

        //native FogModifierStart takes fogmodifier whichFogModifier returns nothing
        private delegate void FogModifierStartPrototype(JassFogModifier whichFogModifier);
        private FogModifierStartPrototype _FogModifierStart = WarcraftIII.Jass.GetNative("FogModifierStart").ToDelegate<FogModifierStartPrototype>();
        public void FogModifierStart(JassFogModifier whichFogModifier)
        {
            _FogModifierStart(whichFogModifier);
        }

        //native FogModifierStop takes fogmodifier whichFogModifier returns nothing
        private delegate void FogModifierStopPrototype(JassFogModifier whichFogModifier);
        private FogModifierStopPrototype _FogModifierStop = WarcraftIII.Jass.GetNative("FogModifierStop").ToDelegate<FogModifierStopPrototype>();
        public void FogModifierStop(JassFogModifier whichFogModifier)
        {
            _FogModifierStop(whichFogModifier);
        }

        //native VersionGet takes nothing returns version
        private delegate JassVersion VersionGetPrototype();
        private VersionGetPrototype _VersionGet = WarcraftIII.Jass.GetNative("VersionGet").ToDelegate<VersionGetPrototype>();
        public JassVersion VersionGet()
        {
            return _VersionGet();
        }

        //native VersionCompatible takes version whichVersion returns boolean
        private delegate JassBoolean VersionCompatiblePrototype(JassVersion whichVersion);
        private VersionCompatiblePrototype _VersionCompatible = WarcraftIII.Jass.GetNative("VersionCompatible").ToDelegate<VersionCompatiblePrototype>();
        public Boolean VersionCompatible(JassVersion whichVersion)
        {
            return _VersionCompatible(whichVersion);
        }

        //native VersionSupported takes version whichVersion returns boolean
        private delegate JassBoolean VersionSupportedPrototype(JassVersion whichVersion);
        private VersionSupportedPrototype _VersionSupported = WarcraftIII.Jass.GetNative("VersionSupported").ToDelegate<VersionSupportedPrototype>();
        public Boolean VersionSupported(JassVersion whichVersion)
        {
            return _VersionSupported(whichVersion);
        }

        //native EndGame takes boolean doScoreScreen returns nothing
        private delegate void EndGamePrototype(JassBoolean doScoreScreen);
        private EndGamePrototype _EndGame = WarcraftIII.Jass.GetNative("EndGame").ToDelegate<EndGamePrototype>();
        public void EndGame(Boolean doScoreScreen)
        {
            _EndGame(doScoreScreen);
        }

        //native ChangeLevel takes string newLevel, boolean doScoreScreen returns nothing
        private delegate void ChangeLevelPrototype(JassStringArg newLevel, JassBoolean doScoreScreen);
        private ChangeLevelPrototype _ChangeLevel = WarcraftIII.Jass.GetNative("ChangeLevel").ToDelegate<ChangeLevelPrototype>();
        public void ChangeLevel(String newLevel, Boolean doScoreScreen)
        {
            _ChangeLevel(newLevel, doScoreScreen);
        }

        //native RestartGame takes boolean doScoreScreen returns nothing
        private delegate void RestartGamePrototype(JassBoolean doScoreScreen);
        private RestartGamePrototype _RestartGame = WarcraftIII.Jass.GetNative("RestartGame").ToDelegate<RestartGamePrototype>();
        public void RestartGame(Boolean doScoreScreen)
        {
            _RestartGame(doScoreScreen);
        }

        //native ReloadGame takes nothing returns nothing
        private delegate void ReloadGamePrototype();
        private ReloadGamePrototype _ReloadGame = WarcraftIII.Jass.GetNative("ReloadGame").ToDelegate<ReloadGamePrototype>();
        public void ReloadGame()
        {
            _ReloadGame();
        }

        //native SetCampaignMenuRace takes race r returns nothing
        private delegate void SetCampaignMenuRacePrototype(JassRace r);
        private SetCampaignMenuRacePrototype _SetCampaignMenuRace = WarcraftIII.Jass.GetNative("SetCampaignMenuRace").ToDelegate<SetCampaignMenuRacePrototype>();
        public void SetCampaignMenuRace(JassRace r)
        {
            _SetCampaignMenuRace(r);
        }

        //native SetCampaignMenuRaceEx takes integer campaignIndex returns nothing
        private delegate void SetCampaignMenuRaceExPrototype(JassInteger campaignIndex);
        private SetCampaignMenuRaceExPrototype _SetCampaignMenuRaceEx = WarcraftIII.Jass.GetNative("SetCampaignMenuRaceEx").ToDelegate<SetCampaignMenuRaceExPrototype>();
        public void SetCampaignMenuRaceEx(JassInteger campaignIndex)
        {
            _SetCampaignMenuRaceEx(campaignIndex);
        }

        //native ForceCampaignSelectScreen takes nothing returns nothing
        private delegate void ForceCampaignSelectScreenPrototype();
        private ForceCampaignSelectScreenPrototype _ForceCampaignSelectScreen = WarcraftIII.Jass.GetNative("ForceCampaignSelectScreen").ToDelegate<ForceCampaignSelectScreenPrototype>();
        public void ForceCampaignSelectScreen()
        {
            _ForceCampaignSelectScreen();
        }

        //native LoadGame takes string saveFileName, boolean doScoreScreen returns nothing
        private delegate void LoadGamePrototype(JassStringArg saveFileName, JassBoolean doScoreScreen);
        private LoadGamePrototype _LoadGame = WarcraftIII.Jass.GetNative("LoadGame").ToDelegate<LoadGamePrototype>();
        public void LoadGame(String saveFileName, Boolean doScoreScreen)
        {
            _LoadGame(saveFileName, doScoreScreen);
        }

        //native SaveGame takes string saveFileName returns nothing
        private delegate void SaveGamePrototype(JassStringArg saveFileName);
        private SaveGamePrototype _SaveGame = WarcraftIII.Jass.GetNative("SaveGame").ToDelegate<SaveGamePrototype>();
        public void SaveGame(String saveFileName)
        {
            _SaveGame(saveFileName);
        }

        //native RenameSaveDirectory takes string sourceDirName, string destDirName returns boolean
        private delegate JassBoolean RenameSaveDirectoryPrototype(JassStringArg sourceDirName, JassStringArg destDirName);
        private RenameSaveDirectoryPrototype _RenameSaveDirectory = WarcraftIII.Jass.GetNative("RenameSaveDirectory").ToDelegate<RenameSaveDirectoryPrototype>();
        public Boolean RenameSaveDirectory(String sourceDirName, String destDirName)
        {
            return _RenameSaveDirectory(sourceDirName, destDirName);
        }

        //native RemoveSaveDirectory takes string sourceDirName returns boolean
        private delegate JassBoolean RemoveSaveDirectoryPrototype(JassStringArg sourceDirName);
        private RemoveSaveDirectoryPrototype _RemoveSaveDirectory = WarcraftIII.Jass.GetNative("RemoveSaveDirectory").ToDelegate<RemoveSaveDirectoryPrototype>();
        public Boolean RemoveSaveDirectory(String sourceDirName)
        {
            return _RemoveSaveDirectory(sourceDirName);
        }

        //native CopySaveGame takes string sourceSaveName, string destSaveName returns boolean
        private delegate JassBoolean CopySaveGamePrototype(JassStringArg sourceSaveName, JassStringArg destSaveName);
        private CopySaveGamePrototype _CopySaveGame = WarcraftIII.Jass.GetNative("CopySaveGame").ToDelegate<CopySaveGamePrototype>();
        public Boolean CopySaveGame(String sourceSaveName, String destSaveName)
        {
            return _CopySaveGame(sourceSaveName, destSaveName);
        }

        //native SaveGameExists takes string saveName returns boolean
        private delegate JassBoolean SaveGameExistsPrototype(JassStringArg saveName);
        private SaveGameExistsPrototype _SaveGameExists = WarcraftIII.Jass.GetNative("SaveGameExists").ToDelegate<SaveGameExistsPrototype>();
        public Boolean SaveGameExists(String saveName)
        {
            return _SaveGameExists(saveName);
        }

        //native SyncSelections takes nothing returns nothing
        private delegate void SyncSelectionsPrototype();
        private SyncSelectionsPrototype _SyncSelections = WarcraftIII.Jass.GetNative("SyncSelections").ToDelegate<SyncSelectionsPrototype>();
        public void SyncSelections()
        {
            _SyncSelections();
        }

        //native SetFloatGameState takes fgamestate whichFloatGameState, real value returns nothing
        private delegate void SetFloatGameStatePrototype(JassFGameState whichFloatGameState, JassRealArg value);
        private SetFloatGameStatePrototype _SetFloatGameState = WarcraftIII.Jass.GetNative("SetFloatGameState").ToDelegate<SetFloatGameStatePrototype>();
        public void SetFloatGameState(JassFGameState whichFloatGameState, Single value)
        {
            _SetFloatGameState(whichFloatGameState, value);
        }

        //native GetFloatGameState takes fgamestate whichFloatGameState returns real
        private delegate JassRealRet GetFloatGameStatePrototype(JassFGameState whichFloatGameState);
        private GetFloatGameStatePrototype _GetFloatGameState = WarcraftIII.Jass.GetNative("GetFloatGameState").ToDelegate<GetFloatGameStatePrototype>();
        public Single GetFloatGameState(JassFGameState whichFloatGameState)
        {
            return _GetFloatGameState(whichFloatGameState);
        }

        //native SetIntegerGameState takes igamestate whichIntegerGameState, integer value returns nothing
        private delegate void SetIntegerGameStatePrototype(JassIGameState whichIntegerGameState, JassInteger value);
        private SetIntegerGameStatePrototype _SetIntegerGameState = WarcraftIII.Jass.GetNative("SetIntegerGameState").ToDelegate<SetIntegerGameStatePrototype>();
        public void SetIntegerGameState(JassIGameState whichIntegerGameState, JassInteger value)
        {
            _SetIntegerGameState(whichIntegerGameState, value);
        }

        //native GetIntegerGameState takes igamestate whichIntegerGameState returns integer
        private delegate JassInteger GetIntegerGameStatePrototype(JassIGameState whichIntegerGameState);
        private GetIntegerGameStatePrototype _GetIntegerGameState = WarcraftIII.Jass.GetNative("GetIntegerGameState").ToDelegate<GetIntegerGameStatePrototype>();
        public JassInteger GetIntegerGameState(JassIGameState whichIntegerGameState)
        {
            return _GetIntegerGameState(whichIntegerGameState);
        }

        //native SetTutorialCleared takes boolean cleared returns nothing
        private delegate void SetTutorialClearedPrototype(JassBoolean cleared);
        private SetTutorialClearedPrototype _SetTutorialCleared = WarcraftIII.Jass.GetNative("SetTutorialCleared").ToDelegate<SetTutorialClearedPrototype>();
        public void SetTutorialCleared(Boolean cleared)
        {
            _SetTutorialCleared(cleared);
        }

        //native SetMissionAvailable takes integer campaignNumber, integer missionNumber, boolean available returns nothing
        private delegate void SetMissionAvailablePrototype(JassInteger campaignNumber, JassInteger missionNumber, JassBoolean available);
        private SetMissionAvailablePrototype _SetMissionAvailable = WarcraftIII.Jass.GetNative("SetMissionAvailable").ToDelegate<SetMissionAvailablePrototype>();
        public void SetMissionAvailable(JassInteger campaignNumber, JassInteger missionNumber, Boolean available)
        {
            _SetMissionAvailable(campaignNumber, missionNumber, available);
        }

        //native SetCampaignAvailable takes integer campaignNumber, boolean available returns nothing
        private delegate void SetCampaignAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private SetCampaignAvailablePrototype _SetCampaignAvailable = WarcraftIII.Jass.GetNative("SetCampaignAvailable").ToDelegate<SetCampaignAvailablePrototype>();
        public void SetCampaignAvailable(JassInteger campaignNumber, Boolean available)
        {
            _SetCampaignAvailable(campaignNumber, available);
        }

        //native SetOpCinematicAvailable takes integer campaignNumber, boolean available returns nothing
        private delegate void SetOpCinematicAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private SetOpCinematicAvailablePrototype _SetOpCinematicAvailable = WarcraftIII.Jass.GetNative("SetOpCinematicAvailable").ToDelegate<SetOpCinematicAvailablePrototype>();
        public void SetOpCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            _SetOpCinematicAvailable(campaignNumber, available);
        }

        //native SetEdCinematicAvailable takes integer campaignNumber, boolean available returns nothing
        private delegate void SetEdCinematicAvailablePrototype(JassInteger campaignNumber, JassBoolean available);
        private SetEdCinematicAvailablePrototype _SetEdCinematicAvailable = WarcraftIII.Jass.GetNative("SetEdCinematicAvailable").ToDelegate<SetEdCinematicAvailablePrototype>();
        public void SetEdCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            _SetEdCinematicAvailable(campaignNumber, available);
        }

        //native GetDefaultDifficulty takes nothing returns gamedifficulty
        private delegate JassGameDifficulty GetDefaultDifficultyPrototype();
        private GetDefaultDifficultyPrototype _GetDefaultDifficulty = WarcraftIII.Jass.GetNative("GetDefaultDifficulty").ToDelegate<GetDefaultDifficultyPrototype>();
        public JassGameDifficulty GetDefaultDifficulty()
        {
            return _GetDefaultDifficulty();
        }

        //native SetDefaultDifficulty takes gamedifficulty g returns nothing
        private delegate void SetDefaultDifficultyPrototype(JassGameDifficulty g);
        private SetDefaultDifficultyPrototype _SetDefaultDifficulty = WarcraftIII.Jass.GetNative("SetDefaultDifficulty").ToDelegate<SetDefaultDifficultyPrototype>();
        public void SetDefaultDifficulty(JassGameDifficulty g)
        {
            _SetDefaultDifficulty(g);
        }

        //native SetCustomCampaignButtonVisible takes integer whichButton, boolean visible returns nothing
        private delegate void SetCustomCampaignButtonVisiblePrototype(JassInteger whichButton, JassBoolean visible);
        private SetCustomCampaignButtonVisiblePrototype _SetCustomCampaignButtonVisible = WarcraftIII.Jass.GetNative("SetCustomCampaignButtonVisible").ToDelegate<SetCustomCampaignButtonVisiblePrototype>();
        public void SetCustomCampaignButtonVisible(JassInteger whichButton, Boolean visible)
        {
            _SetCustomCampaignButtonVisible(whichButton, visible);
        }

        //native GetCustomCampaignButtonVisible takes integer whichButton returns boolean
        private delegate JassBoolean GetCustomCampaignButtonVisiblePrototype(JassInteger whichButton);
        private GetCustomCampaignButtonVisiblePrototype _GetCustomCampaignButtonVisible = WarcraftIII.Jass.GetNative("GetCustomCampaignButtonVisible").ToDelegate<GetCustomCampaignButtonVisiblePrototype>();
        public Boolean GetCustomCampaignButtonVisible(JassInteger whichButton)
        {
            return _GetCustomCampaignButtonVisible(whichButton);
        }

        //native DoNotSaveReplay takes nothing returns nothing
        private delegate void DoNotSaveReplayPrototype();
        private DoNotSaveReplayPrototype _DoNotSaveReplay = WarcraftIII.Jass.GetNative("DoNotSaveReplay").ToDelegate<DoNotSaveReplayPrototype>();
        public void DoNotSaveReplay()
        {
            _DoNotSaveReplay();
        }

        //native DialogCreate takes nothing returns dialog
        private delegate JassDialog DialogCreatePrototype();
        private DialogCreatePrototype _DialogCreate = WarcraftIII.Jass.GetNative("DialogCreate").ToDelegate<DialogCreatePrototype>();
        public JassDialog DialogCreate()
        {
            return _DialogCreate();
        }

        //native DialogDestroy takes dialog whichDialog returns nothing
        private delegate void DialogDestroyPrototype(JassDialog whichDialog);
        private DialogDestroyPrototype _DialogDestroy = WarcraftIII.Jass.GetNative("DialogDestroy").ToDelegate<DialogDestroyPrototype>();
        public void DialogDestroy(JassDialog whichDialog)
        {
            _DialogDestroy(whichDialog);
        }

        //native DialogClear takes dialog whichDialog returns nothing
        private delegate void DialogClearPrototype(JassDialog whichDialog);
        private DialogClearPrototype _DialogClear = WarcraftIII.Jass.GetNative("DialogClear").ToDelegate<DialogClearPrototype>();
        public void DialogClear(JassDialog whichDialog)
        {
            _DialogClear(whichDialog);
        }

        //native DialogSetMessage takes dialog whichDialog, string messageText returns nothing
        private delegate void DialogSetMessagePrototype(JassDialog whichDialog, JassStringArg messageText);
        private DialogSetMessagePrototype _DialogSetMessage = WarcraftIII.Jass.GetNative("DialogSetMessage").ToDelegate<DialogSetMessagePrototype>();
        public void DialogSetMessage(JassDialog whichDialog, String messageText)
        {
            _DialogSetMessage(whichDialog, messageText);
        }

        //native DialogAddButton takes dialog whichDialog, string buttonText, integer hotkey returns button
        private delegate JassButton DialogAddButtonPrototype(JassDialog whichDialog, JassStringArg buttonText, JassInteger hotkey);
        private DialogAddButtonPrototype _DialogAddButton = WarcraftIII.Jass.GetNative("DialogAddButton").ToDelegate<DialogAddButtonPrototype>();
        public JassButton DialogAddButton(JassDialog whichDialog, String buttonText, JassInteger hotkey)
        {
            return _DialogAddButton(whichDialog, buttonText, hotkey);
        }

        //native DialogAddQuitButton takes dialog whichDialog, boolean doScoreScreen, string buttonText, integer hotkey returns button
        private delegate JassButton DialogAddQuitButtonPrototype(JassDialog whichDialog, JassBoolean doScoreScreen, JassStringArg buttonText, JassInteger hotkey);
        private DialogAddQuitButtonPrototype _DialogAddQuitButton = WarcraftIII.Jass.GetNative("DialogAddQuitButton").ToDelegate<DialogAddQuitButtonPrototype>();
        public JassButton DialogAddQuitButton(JassDialog whichDialog, Boolean doScoreScreen, String buttonText, JassInteger hotkey)
        {
            return _DialogAddQuitButton(whichDialog, doScoreScreen, buttonText, hotkey);
        }

        //native DialogDisplay takes player whichPlayer, dialog whichDialog, boolean flag returns nothing
        private delegate void DialogDisplayPrototype(JassPlayer whichPlayer, JassDialog whichDialog, JassBoolean flag);
        private DialogDisplayPrototype _DialogDisplay = WarcraftIII.Jass.GetNative("DialogDisplay").ToDelegate<DialogDisplayPrototype>();
        public void DialogDisplay(JassPlayer whichPlayer, JassDialog whichDialog, Boolean flag)
        {
            _DialogDisplay(whichPlayer, whichDialog, flag);
        }

        //native ReloadGameCachesFromDisk takes nothing returns boolean
        private delegate JassBoolean ReloadGameCachesFromDiskPrototype();
        private ReloadGameCachesFromDiskPrototype _ReloadGameCachesFromDisk = WarcraftIII.Jass.GetNative("ReloadGameCachesFromDisk").ToDelegate<ReloadGameCachesFromDiskPrototype>();
        public Boolean ReloadGameCachesFromDisk()
        {
            return _ReloadGameCachesFromDisk();
        }

        //native InitGameCache takes string campaignFile returns gamecache
        private delegate JassGameCache InitGameCachePrototype(JassStringArg campaignFile);
        private InitGameCachePrototype _InitGameCache = WarcraftIII.Jass.GetNative("InitGameCache").ToDelegate<InitGameCachePrototype>();
        public JassGameCache InitGameCache(String campaignFile)
        {
            return _InitGameCache(campaignFile);
        }

        //native SaveGameCache takes gamecache whichCache returns boolean
        private delegate JassBoolean SaveGameCachePrototype(JassGameCache whichCache);
        private SaveGameCachePrototype _SaveGameCache = WarcraftIII.Jass.GetNative("SaveGameCache").ToDelegate<SaveGameCachePrototype>();
        public Boolean SaveGameCache(JassGameCache whichCache)
        {
            return _SaveGameCache(whichCache);
        }

        //native StoreInteger takes gamecache cache, string missionKey, string key, integer value returns nothing
        private delegate void StoreIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassInteger value);
        private StoreIntegerPrototype _StoreInteger = WarcraftIII.Jass.GetNative("StoreInteger").ToDelegate<StoreIntegerPrototype>();
        public void StoreInteger(JassGameCache cache, String missionKey, String key, JassInteger value)
        {
            _StoreInteger(cache, missionKey, key, value);
        }

        //native StoreReal takes gamecache cache, string missionKey, string key, real value returns nothing
        private delegate void StoreRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassRealArg value);
        private StoreRealPrototype _StoreReal = WarcraftIII.Jass.GetNative("StoreReal").ToDelegate<StoreRealPrototype>();
        public void StoreReal(JassGameCache cache, String missionKey, String key, Single value)
        {
            _StoreReal(cache, missionKey, key, value);
        }

        //native StoreBoolean takes gamecache cache, string missionKey, string key, boolean value returns nothing
        private delegate void StoreBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassBoolean value);
        private StoreBooleanPrototype _StoreBoolean = WarcraftIII.Jass.GetNative("StoreBoolean").ToDelegate<StoreBooleanPrototype>();
        public void StoreBoolean(JassGameCache cache, String missionKey, String key, Boolean value)
        {
            _StoreBoolean(cache, missionKey, key, value);
        }

        //native StoreUnit takes gamecache cache, string missionKey, string key, unit whichUnit returns boolean
        private delegate JassBoolean StoreUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassUnit whichUnit);
        private StoreUnitPrototype _StoreUnit = WarcraftIII.Jass.GetNative("StoreUnit").ToDelegate<StoreUnitPrototype>();
        public Boolean StoreUnit(JassGameCache cache, String missionKey, String key, JassUnit whichUnit)
        {
            return _StoreUnit(cache, missionKey, key, whichUnit);
        }

        //native StoreString takes gamecache cache, string missionKey, string key, string value returns boolean
        private delegate JassBoolean StoreStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassStringArg value);
        private StoreStringPrototype _StoreString = WarcraftIII.Jass.GetNative("StoreString").ToDelegate<StoreStringPrototype>();
        public Boolean StoreString(JassGameCache cache, String missionKey, String key, String value)
        {
            return _StoreString(cache, missionKey, key, value);
        }

        //native SyncStoredInteger takes gamecache cache, string missionKey, string key returns nothing
        private delegate void SyncStoredIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private SyncStoredIntegerPrototype _SyncStoredInteger = WarcraftIII.Jass.GetNative("SyncStoredInteger").ToDelegate<SyncStoredIntegerPrototype>();
        public void SyncStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            _SyncStoredInteger(cache, missionKey, key);
        }

        //native SyncStoredReal takes gamecache cache, string missionKey, string key returns nothing
        private delegate void SyncStoredRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private SyncStoredRealPrototype _SyncStoredReal = WarcraftIII.Jass.GetNative("SyncStoredReal").ToDelegate<SyncStoredRealPrototype>();
        public void SyncStoredReal(JassGameCache cache, String missionKey, String key)
        {
            _SyncStoredReal(cache, missionKey, key);
        }

        //native SyncStoredBoolean takes gamecache cache, string missionKey, string key returns nothing
        private delegate void SyncStoredBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private SyncStoredBooleanPrototype _SyncStoredBoolean = WarcraftIII.Jass.GetNative("SyncStoredBoolean").ToDelegate<SyncStoredBooleanPrototype>();
        public void SyncStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            _SyncStoredBoolean(cache, missionKey, key);
        }

        //native SyncStoredUnit takes gamecache cache, string missionKey, string key returns nothing
        private delegate void SyncStoredUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private SyncStoredUnitPrototype _SyncStoredUnit = WarcraftIII.Jass.GetNative("SyncStoredUnit").ToDelegate<SyncStoredUnitPrototype>();
        public void SyncStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            _SyncStoredUnit(cache, missionKey, key);
        }

        //native SyncStoredString takes gamecache cache, string missionKey, string key returns nothing
        private delegate void SyncStoredStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private SyncStoredStringPrototype _SyncStoredString = WarcraftIII.Jass.GetNative("SyncStoredString").ToDelegate<SyncStoredStringPrototype>();
        public void SyncStoredString(JassGameCache cache, String missionKey, String key)
        {
            _SyncStoredString(cache, missionKey, key);
        }

        //native HaveStoredInteger takes gamecache cache, string missionKey, string key returns boolean
        private delegate JassBoolean HaveStoredIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private HaveStoredIntegerPrototype _HaveStoredInteger = WarcraftIII.Jass.GetNative("HaveStoredInteger").ToDelegate<HaveStoredIntegerPrototype>();
        public Boolean HaveStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return _HaveStoredInteger(cache, missionKey, key);
        }

        //native HaveStoredReal takes gamecache cache, string missionKey, string key returns boolean
        private delegate JassBoolean HaveStoredRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private HaveStoredRealPrototype _HaveStoredReal = WarcraftIII.Jass.GetNative("HaveStoredReal").ToDelegate<HaveStoredRealPrototype>();
        public Boolean HaveStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return _HaveStoredReal(cache, missionKey, key);
        }

        //native HaveStoredBoolean takes gamecache cache, string missionKey, string key returns boolean
        private delegate JassBoolean HaveStoredBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private HaveStoredBooleanPrototype _HaveStoredBoolean = WarcraftIII.Jass.GetNative("HaveStoredBoolean").ToDelegate<HaveStoredBooleanPrototype>();
        public Boolean HaveStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return _HaveStoredBoolean(cache, missionKey, key);
        }

        //native HaveStoredUnit takes gamecache cache, string missionKey, string key returns boolean
        private delegate JassBoolean HaveStoredUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private HaveStoredUnitPrototype _HaveStoredUnit = WarcraftIII.Jass.GetNative("HaveStoredUnit").ToDelegate<HaveStoredUnitPrototype>();
        public Boolean HaveStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            return _HaveStoredUnit(cache, missionKey, key);
        }

        //native HaveStoredString takes gamecache cache, string missionKey, string key returns boolean
        private delegate JassBoolean HaveStoredStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private HaveStoredStringPrototype _HaveStoredString = WarcraftIII.Jass.GetNative("HaveStoredString").ToDelegate<HaveStoredStringPrototype>();
        public Boolean HaveStoredString(JassGameCache cache, String missionKey, String key)
        {
            return _HaveStoredString(cache, missionKey, key);
        }

        //native FlushGameCache takes gamecache cache returns nothing
        private delegate void FlushGameCachePrototype(JassGameCache cache);
        private FlushGameCachePrototype _FlushGameCache = WarcraftIII.Jass.GetNative("FlushGameCache").ToDelegate<FlushGameCachePrototype>();
        public void FlushGameCache(JassGameCache cache)
        {
            _FlushGameCache(cache);
        }

        //native FlushStoredMission takes gamecache cache, string missionKey returns nothing
        private delegate void FlushStoredMissionPrototype(JassGameCache cache, JassStringArg missionKey);
        private FlushStoredMissionPrototype _FlushStoredMission = WarcraftIII.Jass.GetNative("FlushStoredMission").ToDelegate<FlushStoredMissionPrototype>();
        public void FlushStoredMission(JassGameCache cache, String missionKey)
        {
            _FlushStoredMission(cache, missionKey);
        }

        //native FlushStoredInteger takes gamecache cache, string missionKey, string key returns nothing
        private delegate void FlushStoredIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private FlushStoredIntegerPrototype _FlushStoredInteger = WarcraftIII.Jass.GetNative("FlushStoredInteger").ToDelegate<FlushStoredIntegerPrototype>();
        public void FlushStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            _FlushStoredInteger(cache, missionKey, key);
        }

        //native FlushStoredReal takes gamecache cache, string missionKey, string key returns nothing
        private delegate void FlushStoredRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private FlushStoredRealPrototype _FlushStoredReal = WarcraftIII.Jass.GetNative("FlushStoredReal").ToDelegate<FlushStoredRealPrototype>();
        public void FlushStoredReal(JassGameCache cache, String missionKey, String key)
        {
            _FlushStoredReal(cache, missionKey, key);
        }

        //native FlushStoredBoolean takes gamecache cache, string missionKey, string key returns nothing
        private delegate void FlushStoredBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private FlushStoredBooleanPrototype _FlushStoredBoolean = WarcraftIII.Jass.GetNative("FlushStoredBoolean").ToDelegate<FlushStoredBooleanPrototype>();
        public void FlushStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            _FlushStoredBoolean(cache, missionKey, key);
        }

        //native FlushStoredUnit takes gamecache cache, string missionKey, string key returns nothing
        private delegate void FlushStoredUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private FlushStoredUnitPrototype _FlushStoredUnit = WarcraftIII.Jass.GetNative("FlushStoredUnit").ToDelegate<FlushStoredUnitPrototype>();
        public void FlushStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            _FlushStoredUnit(cache, missionKey, key);
        }

        //native FlushStoredString takes gamecache cache, string missionKey, string key returns nothing
        private delegate void FlushStoredStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private FlushStoredStringPrototype _FlushStoredString = WarcraftIII.Jass.GetNative("FlushStoredString").ToDelegate<FlushStoredStringPrototype>();
        public void FlushStoredString(JassGameCache cache, String missionKey, String key)
        {
            _FlushStoredString(cache, missionKey, key);
        }

        //native GetStoredInteger takes gamecache cache, string missionKey, string key returns integer
        private delegate JassInteger GetStoredIntegerPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private GetStoredIntegerPrototype _GetStoredInteger = WarcraftIII.Jass.GetNative("GetStoredInteger").ToDelegate<GetStoredIntegerPrototype>();
        public JassInteger GetStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return _GetStoredInteger(cache, missionKey, key);
        }

        //native GetStoredReal takes gamecache cache, string missionKey, string key returns real
        private delegate JassRealRet GetStoredRealPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private GetStoredRealPrototype _GetStoredReal = WarcraftIII.Jass.GetNative("GetStoredReal").ToDelegate<GetStoredRealPrototype>();
        public Single GetStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return _GetStoredReal(cache, missionKey, key);
        }

        //native GetStoredBoolean takes gamecache cache, string missionKey, string key returns boolean
        private delegate JassBoolean GetStoredBooleanPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private GetStoredBooleanPrototype _GetStoredBoolean = WarcraftIII.Jass.GetNative("GetStoredBoolean").ToDelegate<GetStoredBooleanPrototype>();
        public Boolean GetStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return _GetStoredBoolean(cache, missionKey, key);
        }

        //native GetStoredString takes gamecache cache, string missionKey, string key returns string
        private delegate JassStringRet GetStoredStringPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key);
        private GetStoredStringPrototype _GetStoredString = WarcraftIII.Jass.GetNative("GetStoredString").ToDelegate<GetStoredStringPrototype>();
        public String GetStoredString(JassGameCache cache, String missionKey, String key)
        {
            return _GetStoredString(cache, missionKey, key);
        }

        //native RestoreUnit takes gamecache cache, string missionKey, string key, player forWhichPlayer, real x, real y, real facing returns unit
        private delegate JassUnit RestoreUnitPrototype(JassGameCache cache, JassStringArg missionKey, JassStringArg key, JassPlayer forWhichPlayer, JassRealArg x, JassRealArg y, JassRealArg facing);
        private RestoreUnitPrototype _RestoreUnit = WarcraftIII.Jass.GetNative("RestoreUnit").ToDelegate<RestoreUnitPrototype>();
        public JassUnit RestoreUnit(JassGameCache cache, String missionKey, String key, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return _RestoreUnit(cache, missionKey, key, forWhichPlayer, x, y, facing);
        }

        //native InitHashtable takes nothing returns hashtable
        private delegate JassHashTable InitHashtablePrototype();
        private InitHashtablePrototype _InitHashtable = WarcraftIII.Jass.GetNative("InitHashtable").ToDelegate<InitHashtablePrototype>();
        public JassHashTable InitHashtable()
        {
            return _InitHashtable();
        }

        //native SaveInteger takes hashtable table, integer parentKey, integer childKey, integer value returns nothing
        private delegate void SaveIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value);
        private SaveIntegerPrototype _SaveInteger = WarcraftIII.Jass.GetNative("SaveInteger").ToDelegate<SaveIntegerPrototype>();
        public void SaveInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value)
        {
            _SaveInteger(table, parentKey, childKey, value);
        }

        //native SaveReal takes hashtable table, integer parentKey, integer childKey, real value returns nothing
        private delegate void SaveRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRealArg value);
        private SaveRealPrototype _SaveReal = WarcraftIII.Jass.GetNative("SaveReal").ToDelegate<SaveRealPrototype>();
        public void SaveReal(JassHashTable table, JassInteger parentKey, JassInteger childKey, Single value)
        {
            _SaveReal(table, parentKey, childKey, value);
        }

        //native SaveBoolean takes hashtable table, integer parentKey, integer childKey, boolean value returns nothing
        private delegate void SaveBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBoolean value);
        private SaveBooleanPrototype _SaveBoolean = WarcraftIII.Jass.GetNative("SaveBoolean").ToDelegate<SaveBooleanPrototype>();
        public void SaveBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey, Boolean value)
        {
            _SaveBoolean(table, parentKey, childKey, value);
        }

        //native SaveStr takes hashtable table, integer parentKey, integer childKey, string value returns boolean
        private delegate JassBoolean SaveStrPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassStringArg value);
        private SaveStrPrototype _SaveStr = WarcraftIII.Jass.GetNative("SaveStr").ToDelegate<SaveStrPrototype>();
        public Boolean SaveStr(JassHashTable table, JassInteger parentKey, JassInteger childKey, String value)
        {
            return _SaveStr(table, parentKey, childKey, value);
        }

        //native SavePlayerHandle takes hashtable table, integer parentKey, integer childKey, player whichPlayer returns boolean
        private delegate JassBoolean SavePlayerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer);
        private SavePlayerHandlePrototype _SavePlayerHandle = WarcraftIII.Jass.GetNative("SavePlayerHandle").ToDelegate<SavePlayerHandlePrototype>();
        public Boolean SavePlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer)
        {
            return _SavePlayerHandle(table, parentKey, childKey, whichPlayer);
        }

        //native SaveWidgetHandle takes hashtable table, integer parentKey, integer childKey, widget whichWidget returns boolean
        private delegate JassBoolean SaveWidgetHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget);
        private SaveWidgetHandlePrototype _SaveWidgetHandle = WarcraftIII.Jass.GetNative("SaveWidgetHandle").ToDelegate<SaveWidgetHandlePrototype>();
        public Boolean SaveWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget)
        {
            return _SaveWidgetHandle(table, parentKey, childKey, whichWidget);
        }

        //native SaveDestructableHandle takes hashtable table, integer parentKey, integer childKey, destructable whichDestructable returns boolean
        private delegate JassBoolean SaveDestructableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable);
        private SaveDestructableHandlePrototype _SaveDestructableHandle = WarcraftIII.Jass.GetNative("SaveDestructableHandle").ToDelegate<SaveDestructableHandlePrototype>();
        public Boolean SaveDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable)
        {
            return _SaveDestructableHandle(table, parentKey, childKey, whichDestructable);
        }

        //native SaveItemHandle takes hashtable table, integer parentKey, integer childKey, item whichItem returns boolean
        private delegate JassBoolean SaveItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem);
        private SaveItemHandlePrototype _SaveItemHandle = WarcraftIII.Jass.GetNative("SaveItemHandle").ToDelegate<SaveItemHandlePrototype>();
        public Boolean SaveItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem)
        {
            return _SaveItemHandle(table, parentKey, childKey, whichItem);
        }

        //native SaveUnitHandle takes hashtable table, integer parentKey, integer childKey, unit whichUnit returns boolean
        private delegate JassBoolean SaveUnitHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit);
        private SaveUnitHandlePrototype _SaveUnitHandle = WarcraftIII.Jass.GetNative("SaveUnitHandle").ToDelegate<SaveUnitHandlePrototype>();
        public Boolean SaveUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit)
        {
            return _SaveUnitHandle(table, parentKey, childKey, whichUnit);
        }

        //native SaveAbilityHandle takes hashtable table, integer parentKey, integer childKey, ability whichAbility returns boolean
        private delegate JassBoolean SaveAbilityHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility);
        private SaveAbilityHandlePrototype _SaveAbilityHandle = WarcraftIII.Jass.GetNative("SaveAbilityHandle").ToDelegate<SaveAbilityHandlePrototype>();
        public Boolean SaveAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility)
        {
            return _SaveAbilityHandle(table, parentKey, childKey, whichAbility);
        }

        //native SaveTimerHandle takes hashtable table, integer parentKey, integer childKey, timer whichTimer returns boolean
        private delegate JassBoolean SaveTimerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer);
        private SaveTimerHandlePrototype _SaveTimerHandle = WarcraftIII.Jass.GetNative("SaveTimerHandle").ToDelegate<SaveTimerHandlePrototype>();
        public Boolean SaveTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer)
        {
            return _SaveTimerHandle(table, parentKey, childKey, whichTimer);
        }

        //native SaveTriggerHandle takes hashtable table, integer parentKey, integer childKey, trigger whichTrigger returns boolean
        private delegate JassBoolean SaveTriggerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger);
        private SaveTriggerHandlePrototype _SaveTriggerHandle = WarcraftIII.Jass.GetNative("SaveTriggerHandle").ToDelegate<SaveTriggerHandlePrototype>();
        public Boolean SaveTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger)
        {
            return _SaveTriggerHandle(table, parentKey, childKey, whichTrigger);
        }

        //native SaveTriggerConditionHandle takes hashtable table, integer parentKey, integer childKey, triggercondition whichTriggercondition returns boolean
        private delegate JassBoolean SaveTriggerConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition);
        private SaveTriggerConditionHandlePrototype _SaveTriggerConditionHandle = WarcraftIII.Jass.GetNative("SaveTriggerConditionHandle").ToDelegate<SaveTriggerConditionHandlePrototype>();
        public Boolean SaveTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition)
        {
            return _SaveTriggerConditionHandle(table, parentKey, childKey, whichTriggercondition);
        }

        //native SaveTriggerActionHandle takes hashtable table, integer parentKey, integer childKey, triggeraction whichTriggeraction returns boolean
        private delegate JassBoolean SaveTriggerActionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction);
        private SaveTriggerActionHandlePrototype _SaveTriggerActionHandle = WarcraftIII.Jass.GetNative("SaveTriggerActionHandle").ToDelegate<SaveTriggerActionHandlePrototype>();
        public Boolean SaveTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction)
        {
            return _SaveTriggerActionHandle(table, parentKey, childKey, whichTriggeraction);
        }

        //native SaveTriggerEventHandle takes hashtable table, integer parentKey, integer childKey, event whichEvent returns boolean
        private delegate JassBoolean SaveTriggerEventHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent);
        private SaveTriggerEventHandlePrototype _SaveTriggerEventHandle = WarcraftIII.Jass.GetNative("SaveTriggerEventHandle").ToDelegate<SaveTriggerEventHandlePrototype>();
        public Boolean SaveTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent)
        {
            return _SaveTriggerEventHandle(table, parentKey, childKey, whichEvent);
        }

        //native SaveForceHandle takes hashtable table, integer parentKey, integer childKey, force whichForce returns boolean
        private delegate JassBoolean SaveForceHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce);
        private SaveForceHandlePrototype _SaveForceHandle = WarcraftIII.Jass.GetNative("SaveForceHandle").ToDelegate<SaveForceHandlePrototype>();
        public Boolean SaveForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce)
        {
            return _SaveForceHandle(table, parentKey, childKey, whichForce);
        }

        //native SaveGroupHandle takes hashtable table, integer parentKey, integer childKey, group whichGroup returns boolean
        private delegate JassBoolean SaveGroupHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup);
        private SaveGroupHandlePrototype _SaveGroupHandle = WarcraftIII.Jass.GetNative("SaveGroupHandle").ToDelegate<SaveGroupHandlePrototype>();
        public Boolean SaveGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup)
        {
            return _SaveGroupHandle(table, parentKey, childKey, whichGroup);
        }

        //native SaveLocationHandle takes hashtable table, integer parentKey, integer childKey, location whichLocation returns boolean
        private delegate JassBoolean SaveLocationHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation);
        private SaveLocationHandlePrototype _SaveLocationHandle = WarcraftIII.Jass.GetNative("SaveLocationHandle").ToDelegate<SaveLocationHandlePrototype>();
        public Boolean SaveLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation)
        {
            return _SaveLocationHandle(table, parentKey, childKey, whichLocation);
        }

        //native SaveRectHandle takes hashtable table, integer parentKey, integer childKey, rect whichRect returns boolean
        private delegate JassBoolean SaveRectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect);
        private SaveRectHandlePrototype _SaveRectHandle = WarcraftIII.Jass.GetNative("SaveRectHandle").ToDelegate<SaveRectHandlePrototype>();
        public Boolean SaveRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect)
        {
            return _SaveRectHandle(table, parentKey, childKey, whichRect);
        }

        //native SaveBooleanExprHandle takes hashtable table, integer parentKey, integer childKey, boolexpr whichBoolexpr returns boolean
        private delegate JassBoolean SaveBooleanExprHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr);
        private SaveBooleanExprHandlePrototype _SaveBooleanExprHandle = WarcraftIII.Jass.GetNative("SaveBooleanExprHandle").ToDelegate<SaveBooleanExprHandlePrototype>();
        public Boolean SaveBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr)
        {
            return _SaveBooleanExprHandle(table, parentKey, childKey, whichBoolexpr);
        }

        //native SaveSoundHandle takes hashtable table, integer parentKey, integer childKey, sound whichSound returns boolean
        private delegate JassBoolean SaveSoundHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound);
        private SaveSoundHandlePrototype _SaveSoundHandle = WarcraftIII.Jass.GetNative("SaveSoundHandle").ToDelegate<SaveSoundHandlePrototype>();
        public Boolean SaveSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound)
        {
            return _SaveSoundHandle(table, parentKey, childKey, whichSound);
        }

        //native SaveEffectHandle takes hashtable table, integer parentKey, integer childKey, effect whichEffect returns boolean
        private delegate JassBoolean SaveEffectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect);
        private SaveEffectHandlePrototype _SaveEffectHandle = WarcraftIII.Jass.GetNative("SaveEffectHandle").ToDelegate<SaveEffectHandlePrototype>();
        public Boolean SaveEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect)
        {
            return _SaveEffectHandle(table, parentKey, childKey, whichEffect);
        }

        //native SaveUnitPoolHandle takes hashtable table, integer parentKey, integer childKey, unitpool whichUnitpool returns boolean
        private delegate JassBoolean SaveUnitPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool);
        private SaveUnitPoolHandlePrototype _SaveUnitPoolHandle = WarcraftIII.Jass.GetNative("SaveUnitPoolHandle").ToDelegate<SaveUnitPoolHandlePrototype>();
        public Boolean SaveUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool)
        {
            return _SaveUnitPoolHandle(table, parentKey, childKey, whichUnitpool);
        }

        //native SaveItemPoolHandle takes hashtable table, integer parentKey, integer childKey, itempool whichItempool returns boolean
        private delegate JassBoolean SaveItemPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool);
        private SaveItemPoolHandlePrototype _SaveItemPoolHandle = WarcraftIII.Jass.GetNative("SaveItemPoolHandle").ToDelegate<SaveItemPoolHandlePrototype>();
        public Boolean SaveItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool)
        {
            return _SaveItemPoolHandle(table, parentKey, childKey, whichItempool);
        }

        //native SaveQuestHandle takes hashtable table, integer parentKey, integer childKey, quest whichQuest returns boolean
        private delegate JassBoolean SaveQuestHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest);
        private SaveQuestHandlePrototype _SaveQuestHandle = WarcraftIII.Jass.GetNative("SaveQuestHandle").ToDelegate<SaveQuestHandlePrototype>();
        public Boolean SaveQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest)
        {
            return _SaveQuestHandle(table, parentKey, childKey, whichQuest);
        }

        //native SaveQuestItemHandle takes hashtable table, integer parentKey, integer childKey, questitem whichQuestitem returns boolean
        private delegate JassBoolean SaveQuestItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem);
        private SaveQuestItemHandlePrototype _SaveQuestItemHandle = WarcraftIII.Jass.GetNative("SaveQuestItemHandle").ToDelegate<SaveQuestItemHandlePrototype>();
        public Boolean SaveQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem)
        {
            return _SaveQuestItemHandle(table, parentKey, childKey, whichQuestitem);
        }

        //native SaveDefeatConditionHandle takes hashtable table, integer parentKey, integer childKey, defeatcondition whichDefeatcondition returns boolean
        private delegate JassBoolean SaveDefeatConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition);
        private SaveDefeatConditionHandlePrototype _SaveDefeatConditionHandle = WarcraftIII.Jass.GetNative("SaveDefeatConditionHandle").ToDelegate<SaveDefeatConditionHandlePrototype>();
        public Boolean SaveDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition)
        {
            return _SaveDefeatConditionHandle(table, parentKey, childKey, whichDefeatcondition);
        }

        //native SaveTimerDialogHandle takes hashtable table, integer parentKey, integer childKey, timerdialog whichTimerdialog returns boolean
        private delegate JassBoolean SaveTimerDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog);
        private SaveTimerDialogHandlePrototype _SaveTimerDialogHandle = WarcraftIII.Jass.GetNative("SaveTimerDialogHandle").ToDelegate<SaveTimerDialogHandlePrototype>();
        public Boolean SaveTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog)
        {
            return _SaveTimerDialogHandle(table, parentKey, childKey, whichTimerdialog);
        }

        //native SaveLeaderboardHandle takes hashtable table, integer parentKey, integer childKey, leaderboard whichLeaderboard returns boolean
        private delegate JassBoolean SaveLeaderboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard);
        private SaveLeaderboardHandlePrototype _SaveLeaderboardHandle = WarcraftIII.Jass.GetNative("SaveLeaderboardHandle").ToDelegate<SaveLeaderboardHandlePrototype>();
        public Boolean SaveLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard)
        {
            return _SaveLeaderboardHandle(table, parentKey, childKey, whichLeaderboard);
        }

        //native SaveMultiboardHandle takes hashtable table, integer parentKey, integer childKey, multiboard whichMultiboard returns boolean
        private delegate JassBoolean SaveMultiboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard);
        private SaveMultiboardHandlePrototype _SaveMultiboardHandle = WarcraftIII.Jass.GetNative("SaveMultiboardHandle").ToDelegate<SaveMultiboardHandlePrototype>();
        public Boolean SaveMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard)
        {
            return _SaveMultiboardHandle(table, parentKey, childKey, whichMultiboard);
        }

        //native SaveMultiboardItemHandle takes hashtable table, integer parentKey, integer childKey, multiboarditem whichMultiboarditem returns boolean
        private delegate JassBoolean SaveMultiboardItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem);
        private SaveMultiboardItemHandlePrototype _SaveMultiboardItemHandle = WarcraftIII.Jass.GetNative("SaveMultiboardItemHandle").ToDelegate<SaveMultiboardItemHandlePrototype>();
        public Boolean SaveMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem)
        {
            return _SaveMultiboardItemHandle(table, parentKey, childKey, whichMultiboarditem);
        }

        //native SaveTrackableHandle takes hashtable table, integer parentKey, integer childKey, trackable whichTrackable returns boolean
        private delegate JassBoolean SaveTrackableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable);
        private SaveTrackableHandlePrototype _SaveTrackableHandle = WarcraftIII.Jass.GetNative("SaveTrackableHandle").ToDelegate<SaveTrackableHandlePrototype>();
        public Boolean SaveTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable)
        {
            return _SaveTrackableHandle(table, parentKey, childKey, whichTrackable);
        }

        //native SaveDialogHandle takes hashtable table, integer parentKey, integer childKey, dialog whichDialog returns boolean
        private delegate JassBoolean SaveDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog);
        private SaveDialogHandlePrototype _SaveDialogHandle = WarcraftIII.Jass.GetNative("SaveDialogHandle").ToDelegate<SaveDialogHandlePrototype>();
        public Boolean SaveDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog)
        {
            return _SaveDialogHandle(table, parentKey, childKey, whichDialog);
        }

        //native SaveButtonHandle takes hashtable table, integer parentKey, integer childKey, button whichButton returns boolean
        private delegate JassBoolean SaveButtonHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton);
        private SaveButtonHandlePrototype _SaveButtonHandle = WarcraftIII.Jass.GetNative("SaveButtonHandle").ToDelegate<SaveButtonHandlePrototype>();
        public Boolean SaveButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton)
        {
            return _SaveButtonHandle(table, parentKey, childKey, whichButton);
        }

        //native SaveTextTagHandle takes hashtable table, integer parentKey, integer childKey, texttag whichTexttag returns boolean
        private delegate JassBoolean SaveTextTagHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag);
        private SaveTextTagHandlePrototype _SaveTextTagHandle = WarcraftIII.Jass.GetNative("SaveTextTagHandle").ToDelegate<SaveTextTagHandlePrototype>();
        public Boolean SaveTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag)
        {
            return _SaveTextTagHandle(table, parentKey, childKey, whichTexttag);
        }

        //native SaveLightningHandle takes hashtable table, integer parentKey, integer childKey, lightning whichLightning returns boolean
        private delegate JassBoolean SaveLightningHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning);
        private SaveLightningHandlePrototype _SaveLightningHandle = WarcraftIII.Jass.GetNative("SaveLightningHandle").ToDelegate<SaveLightningHandlePrototype>();
        public Boolean SaveLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning)
        {
            return _SaveLightningHandle(table, parentKey, childKey, whichLightning);
        }

        //native SaveImageHandle takes hashtable table, integer parentKey, integer childKey, image whichImage returns boolean
        private delegate JassBoolean SaveImageHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage);
        private SaveImageHandlePrototype _SaveImageHandle = WarcraftIII.Jass.GetNative("SaveImageHandle").ToDelegate<SaveImageHandlePrototype>();
        public Boolean SaveImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage)
        {
            return _SaveImageHandle(table, parentKey, childKey, whichImage);
        }

        //native SaveUbersplatHandle takes hashtable table, integer parentKey, integer childKey, ubersplat whichUbersplat returns boolean
        private delegate JassBoolean SaveUbersplatHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat);
        private SaveUbersplatHandlePrototype _SaveUbersplatHandle = WarcraftIII.Jass.GetNative("SaveUbersplatHandle").ToDelegate<SaveUbersplatHandlePrototype>();
        public Boolean SaveUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat)
        {
            return _SaveUbersplatHandle(table, parentKey, childKey, whichUbersplat);
        }

        //native SaveRegionHandle takes hashtable table, integer parentKey, integer childKey, region whichRegion returns boolean
        private delegate JassBoolean SaveRegionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion);
        private SaveRegionHandlePrototype _SaveRegionHandle = WarcraftIII.Jass.GetNative("SaveRegionHandle").ToDelegate<SaveRegionHandlePrototype>();
        public Boolean SaveRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion)
        {
            return _SaveRegionHandle(table, parentKey, childKey, whichRegion);
        }

        //native SaveFogStateHandle takes hashtable table, integer parentKey, integer childKey, fogstate whichFogState returns boolean
        private delegate JassBoolean SaveFogStateHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState);
        private SaveFogStateHandlePrototype _SaveFogStateHandle = WarcraftIII.Jass.GetNative("SaveFogStateHandle").ToDelegate<SaveFogStateHandlePrototype>();
        public Boolean SaveFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState)
        {
            return _SaveFogStateHandle(table, parentKey, childKey, whichFogState);
        }

        //native SaveFogModifierHandle takes hashtable table, integer parentKey, integer childKey, fogmodifier whichFogModifier returns boolean
        private delegate JassBoolean SaveFogModifierHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier);
        private SaveFogModifierHandlePrototype _SaveFogModifierHandle = WarcraftIII.Jass.GetNative("SaveFogModifierHandle").ToDelegate<SaveFogModifierHandlePrototype>();
        public Boolean SaveFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier)
        {
            return _SaveFogModifierHandle(table, parentKey, childKey, whichFogModifier);
        }

        //native SaveAgentHandle takes hashtable table, integer parentKey, integer childKey, agent whichAgent returns boolean
        private delegate JassBoolean SaveAgentHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent);
        private SaveAgentHandlePrototype _SaveAgentHandle = WarcraftIII.Jass.GetNative("SaveAgentHandle").ToDelegate<SaveAgentHandlePrototype>();
        public Boolean SaveAgentHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent)
        {
            return _SaveAgentHandle(table, parentKey, childKey, whichAgent);
        }

        //native SaveHashtableHandle takes hashtable table, integer parentKey, integer childKey, hashtable whichHashtable returns boolean
        private delegate JassBoolean SaveHashtableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable);
        private SaveHashtableHandlePrototype _SaveHashtableHandle = WarcraftIII.Jass.GetNative("SaveHashtableHandle").ToDelegate<SaveHashtableHandlePrototype>();
        public Boolean SaveHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable)
        {
            return _SaveHashtableHandle(table, parentKey, childKey, whichHashtable);
        }

        //native LoadInteger takes hashtable table, integer parentKey, integer childKey returns integer
        private delegate JassInteger LoadIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadIntegerPrototype _LoadInteger = WarcraftIII.Jass.GetNative("LoadInteger").ToDelegate<LoadIntegerPrototype>();
        public JassInteger LoadInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadInteger(table, parentKey, childKey);
        }

        //native LoadReal takes hashtable table, integer parentKey, integer childKey returns real
        private delegate JassRealRet LoadRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadRealPrototype _LoadReal = WarcraftIII.Jass.GetNative("LoadReal").ToDelegate<LoadRealPrototype>();
        public Single LoadReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadReal(table, parentKey, childKey);
        }

        //native LoadBoolean takes hashtable table, integer parentKey, integer childKey returns boolean
        private delegate JassBoolean LoadBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadBooleanPrototype _LoadBoolean = WarcraftIII.Jass.GetNative("LoadBoolean").ToDelegate<LoadBooleanPrototype>();
        public Boolean LoadBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadBoolean(table, parentKey, childKey);
        }

        //native LoadStr takes hashtable table, integer parentKey, integer childKey returns string
        private delegate JassStringRet LoadStrPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadStrPrototype _LoadStr = WarcraftIII.Jass.GetNative("LoadStr").ToDelegate<LoadStrPrototype>();
        public String LoadStr(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadStr(table, parentKey, childKey);
        }

        //native LoadPlayerHandle takes hashtable table, integer parentKey, integer childKey returns player
        private delegate JassPlayer LoadPlayerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadPlayerHandlePrototype _LoadPlayerHandle = WarcraftIII.Jass.GetNative("LoadPlayerHandle").ToDelegate<LoadPlayerHandlePrototype>();
        public JassPlayer LoadPlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadPlayerHandle(table, parentKey, childKey);
        }

        //native LoadWidgetHandle takes hashtable table, integer parentKey, integer childKey returns widget
        private delegate JassWidget LoadWidgetHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadWidgetHandlePrototype _LoadWidgetHandle = WarcraftIII.Jass.GetNative("LoadWidgetHandle").ToDelegate<LoadWidgetHandlePrototype>();
        public JassWidget LoadWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadWidgetHandle(table, parentKey, childKey);
        }

        //native LoadDestructableHandle takes hashtable table, integer parentKey, integer childKey returns destructable
        private delegate JassDestructable LoadDestructableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadDestructableHandlePrototype _LoadDestructableHandle = WarcraftIII.Jass.GetNative("LoadDestructableHandle").ToDelegate<LoadDestructableHandlePrototype>();
        public JassDestructable LoadDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadDestructableHandle(table, parentKey, childKey);
        }

        //native LoadItemHandle takes hashtable table, integer parentKey, integer childKey returns item
        private delegate JassItem LoadItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadItemHandlePrototype _LoadItemHandle = WarcraftIII.Jass.GetNative("LoadItemHandle").ToDelegate<LoadItemHandlePrototype>();
        public JassItem LoadItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadItemHandle(table, parentKey, childKey);
        }

        //native LoadUnitHandle takes hashtable table, integer parentKey, integer childKey returns unit
        private delegate JassUnit LoadUnitHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadUnitHandlePrototype _LoadUnitHandle = WarcraftIII.Jass.GetNative("LoadUnitHandle").ToDelegate<LoadUnitHandlePrototype>();
        public JassUnit LoadUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadUnitHandle(table, parentKey, childKey);
        }

        //native LoadAbilityHandle takes hashtable table, integer parentKey, integer childKey returns ability
        private delegate JassAbility LoadAbilityHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadAbilityHandlePrototype _LoadAbilityHandle = WarcraftIII.Jass.GetNative("LoadAbilityHandle").ToDelegate<LoadAbilityHandlePrototype>();
        public JassAbility LoadAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadAbilityHandle(table, parentKey, childKey);
        }

        //native LoadTimerHandle takes hashtable table, integer parentKey, integer childKey returns timer
        private delegate JassTimer LoadTimerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadTimerHandlePrototype _LoadTimerHandle = WarcraftIII.Jass.GetNative("LoadTimerHandle").ToDelegate<LoadTimerHandlePrototype>();
        public JassTimer LoadTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadTimerHandle(table, parentKey, childKey);
        }

        //native LoadTriggerHandle takes hashtable table, integer parentKey, integer childKey returns trigger
        private delegate JassTrigger LoadTriggerHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadTriggerHandlePrototype _LoadTriggerHandle = WarcraftIII.Jass.GetNative("LoadTriggerHandle").ToDelegate<LoadTriggerHandlePrototype>();
        public JassTrigger LoadTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadTriggerHandle(table, parentKey, childKey);
        }

        //native LoadTriggerConditionHandle takes hashtable table, integer parentKey, integer childKey returns triggercondition
        private delegate JassTriggerCondition LoadTriggerConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadTriggerConditionHandlePrototype _LoadTriggerConditionHandle = WarcraftIII.Jass.GetNative("LoadTriggerConditionHandle").ToDelegate<LoadTriggerConditionHandlePrototype>();
        public JassTriggerCondition LoadTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadTriggerConditionHandle(table, parentKey, childKey);
        }

        //native LoadTriggerActionHandle takes hashtable table, integer parentKey, integer childKey returns triggeraction
        private delegate JassTriggerAction LoadTriggerActionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadTriggerActionHandlePrototype _LoadTriggerActionHandle = WarcraftIII.Jass.GetNative("LoadTriggerActionHandle").ToDelegate<LoadTriggerActionHandlePrototype>();
        public JassTriggerAction LoadTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadTriggerActionHandle(table, parentKey, childKey);
        }

        //native LoadTriggerEventHandle takes hashtable table, integer parentKey, integer childKey returns event
        private delegate JassEvent LoadTriggerEventHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadTriggerEventHandlePrototype _LoadTriggerEventHandle = WarcraftIII.Jass.GetNative("LoadTriggerEventHandle").ToDelegate<LoadTriggerEventHandlePrototype>();
        public JassEvent LoadTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadTriggerEventHandle(table, parentKey, childKey);
        }

        //native LoadForceHandle takes hashtable table, integer parentKey, integer childKey returns force
        private delegate JassForce LoadForceHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadForceHandlePrototype _LoadForceHandle = WarcraftIII.Jass.GetNative("LoadForceHandle").ToDelegate<LoadForceHandlePrototype>();
        public JassForce LoadForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadForceHandle(table, parentKey, childKey);
        }

        //native LoadGroupHandle takes hashtable table, integer parentKey, integer childKey returns group
        private delegate JassGroup LoadGroupHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadGroupHandlePrototype _LoadGroupHandle = WarcraftIII.Jass.GetNative("LoadGroupHandle").ToDelegate<LoadGroupHandlePrototype>();
        public JassGroup LoadGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadGroupHandle(table, parentKey, childKey);
        }

        //native LoadLocationHandle takes hashtable table, integer parentKey, integer childKey returns location
        private delegate JassLocation LoadLocationHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadLocationHandlePrototype _LoadLocationHandle = WarcraftIII.Jass.GetNative("LoadLocationHandle").ToDelegate<LoadLocationHandlePrototype>();
        public JassLocation LoadLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadLocationHandle(table, parentKey, childKey);
        }

        //native LoadRectHandle takes hashtable table, integer parentKey, integer childKey returns rect
        private delegate JassRect LoadRectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadRectHandlePrototype _LoadRectHandle = WarcraftIII.Jass.GetNative("LoadRectHandle").ToDelegate<LoadRectHandlePrototype>();
        public JassRect LoadRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadRectHandle(table, parentKey, childKey);
        }

        //native LoadBooleanExprHandle takes hashtable table, integer parentKey, integer childKey returns boolexpr
        private delegate JassBooleanExpression LoadBooleanExprHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadBooleanExprHandlePrototype _LoadBooleanExprHandle = WarcraftIII.Jass.GetNative("LoadBooleanExprHandle").ToDelegate<LoadBooleanExprHandlePrototype>();
        public JassBooleanExpression LoadBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadBooleanExprHandle(table, parentKey, childKey);
        }

        //native LoadSoundHandle takes hashtable table, integer parentKey, integer childKey returns sound
        private delegate JassSound LoadSoundHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadSoundHandlePrototype _LoadSoundHandle = WarcraftIII.Jass.GetNative("LoadSoundHandle").ToDelegate<LoadSoundHandlePrototype>();
        public JassSound LoadSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadSoundHandle(table, parentKey, childKey);
        }

        //native LoadEffectHandle takes hashtable table, integer parentKey, integer childKey returns effect
        private delegate JassEffect LoadEffectHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadEffectHandlePrototype _LoadEffectHandle = WarcraftIII.Jass.GetNative("LoadEffectHandle").ToDelegate<LoadEffectHandlePrototype>();
        public JassEffect LoadEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadEffectHandle(table, parentKey, childKey);
        }

        //native LoadUnitPoolHandle takes hashtable table, integer parentKey, integer childKey returns unitpool
        private delegate JassUnitPool LoadUnitPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadUnitPoolHandlePrototype _LoadUnitPoolHandle = WarcraftIII.Jass.GetNative("LoadUnitPoolHandle").ToDelegate<LoadUnitPoolHandlePrototype>();
        public JassUnitPool LoadUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadUnitPoolHandle(table, parentKey, childKey);
        }

        //native LoadItemPoolHandle takes hashtable table, integer parentKey, integer childKey returns itempool
        private delegate JassItemPool LoadItemPoolHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadItemPoolHandlePrototype _LoadItemPoolHandle = WarcraftIII.Jass.GetNative("LoadItemPoolHandle").ToDelegate<LoadItemPoolHandlePrototype>();
        public JassItemPool LoadItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadItemPoolHandle(table, parentKey, childKey);
        }

        //native LoadQuestHandle takes hashtable table, integer parentKey, integer childKey returns quest
        private delegate JassQuest LoadQuestHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadQuestHandlePrototype _LoadQuestHandle = WarcraftIII.Jass.GetNative("LoadQuestHandle").ToDelegate<LoadQuestHandlePrototype>();
        public JassQuest LoadQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadQuestHandle(table, parentKey, childKey);
        }

        //native LoadQuestItemHandle takes hashtable table, integer parentKey, integer childKey returns questitem
        private delegate JassQuestItem LoadQuestItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadQuestItemHandlePrototype _LoadQuestItemHandle = WarcraftIII.Jass.GetNative("LoadQuestItemHandle").ToDelegate<LoadQuestItemHandlePrototype>();
        public JassQuestItem LoadQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadQuestItemHandle(table, parentKey, childKey);
        }

        //native LoadDefeatConditionHandle takes hashtable table, integer parentKey, integer childKey returns defeatcondition
        private delegate JassDefeatCondition LoadDefeatConditionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadDefeatConditionHandlePrototype _LoadDefeatConditionHandle = WarcraftIII.Jass.GetNative("LoadDefeatConditionHandle").ToDelegate<LoadDefeatConditionHandlePrototype>();
        public JassDefeatCondition LoadDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadDefeatConditionHandle(table, parentKey, childKey);
        }

        //native LoadTimerDialogHandle takes hashtable table, integer parentKey, integer childKey returns timerdialog
        private delegate JassTimerDialog LoadTimerDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadTimerDialogHandlePrototype _LoadTimerDialogHandle = WarcraftIII.Jass.GetNative("LoadTimerDialogHandle").ToDelegate<LoadTimerDialogHandlePrototype>();
        public JassTimerDialog LoadTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadTimerDialogHandle(table, parentKey, childKey);
        }

        //native LoadLeaderboardHandle takes hashtable table, integer parentKey, integer childKey returns leaderboard
        private delegate JassLeaderboard LoadLeaderboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadLeaderboardHandlePrototype _LoadLeaderboardHandle = WarcraftIII.Jass.GetNative("LoadLeaderboardHandle").ToDelegate<LoadLeaderboardHandlePrototype>();
        public JassLeaderboard LoadLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadLeaderboardHandle(table, parentKey, childKey);
        }

        //native LoadMultiboardHandle takes hashtable table, integer parentKey, integer childKey returns multiboard
        private delegate JassMultiboard LoadMultiboardHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadMultiboardHandlePrototype _LoadMultiboardHandle = WarcraftIII.Jass.GetNative("LoadMultiboardHandle").ToDelegate<LoadMultiboardHandlePrototype>();
        public JassMultiboard LoadMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadMultiboardHandle(table, parentKey, childKey);
        }

        //native LoadMultiboardItemHandle takes hashtable table, integer parentKey, integer childKey returns multiboarditem
        private delegate JassMultiboardItem LoadMultiboardItemHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadMultiboardItemHandlePrototype _LoadMultiboardItemHandle = WarcraftIII.Jass.GetNative("LoadMultiboardItemHandle").ToDelegate<LoadMultiboardItemHandlePrototype>();
        public JassMultiboardItem LoadMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadMultiboardItemHandle(table, parentKey, childKey);
        }

        //native LoadTrackableHandle takes hashtable table, integer parentKey, integer childKey returns trackable
        private delegate JassTrackable LoadTrackableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadTrackableHandlePrototype _LoadTrackableHandle = WarcraftIII.Jass.GetNative("LoadTrackableHandle").ToDelegate<LoadTrackableHandlePrototype>();
        public JassTrackable LoadTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadTrackableHandle(table, parentKey, childKey);
        }

        //native LoadDialogHandle takes hashtable table, integer parentKey, integer childKey returns dialog
        private delegate JassDialog LoadDialogHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadDialogHandlePrototype _LoadDialogHandle = WarcraftIII.Jass.GetNative("LoadDialogHandle").ToDelegate<LoadDialogHandlePrototype>();
        public JassDialog LoadDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadDialogHandle(table, parentKey, childKey);
        }

        //native LoadButtonHandle takes hashtable table, integer parentKey, integer childKey returns button
        private delegate JassButton LoadButtonHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadButtonHandlePrototype _LoadButtonHandle = WarcraftIII.Jass.GetNative("LoadButtonHandle").ToDelegate<LoadButtonHandlePrototype>();
        public JassButton LoadButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadButtonHandle(table, parentKey, childKey);
        }

        //native LoadTextTagHandle takes hashtable table, integer parentKey, integer childKey returns texttag
        private delegate JassTextTag LoadTextTagHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadTextTagHandlePrototype _LoadTextTagHandle = WarcraftIII.Jass.GetNative("LoadTextTagHandle").ToDelegate<LoadTextTagHandlePrototype>();
        public JassTextTag LoadTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadTextTagHandle(table, parentKey, childKey);
        }

        //native LoadLightningHandle takes hashtable table, integer parentKey, integer childKey returns lightning
        private delegate JassLightning LoadLightningHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadLightningHandlePrototype _LoadLightningHandle = WarcraftIII.Jass.GetNative("LoadLightningHandle").ToDelegate<LoadLightningHandlePrototype>();
        public JassLightning LoadLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadLightningHandle(table, parentKey, childKey);
        }

        //native LoadImageHandle takes hashtable table, integer parentKey, integer childKey returns image
        private delegate JassImage LoadImageHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadImageHandlePrototype _LoadImageHandle = WarcraftIII.Jass.GetNative("LoadImageHandle").ToDelegate<LoadImageHandlePrototype>();
        public JassImage LoadImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadImageHandle(table, parentKey, childKey);
        }

        //native LoadUbersplatHandle takes hashtable table, integer parentKey, integer childKey returns ubersplat
        private delegate JassUberSplat LoadUbersplatHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadUbersplatHandlePrototype _LoadUbersplatHandle = WarcraftIII.Jass.GetNative("LoadUbersplatHandle").ToDelegate<LoadUbersplatHandlePrototype>();
        public JassUberSplat LoadUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadUbersplatHandle(table, parentKey, childKey);
        }

        //native LoadRegionHandle takes hashtable table, integer parentKey, integer childKey returns region
        private delegate JassRegion LoadRegionHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadRegionHandlePrototype _LoadRegionHandle = WarcraftIII.Jass.GetNative("LoadRegionHandle").ToDelegate<LoadRegionHandlePrototype>();
        public JassRegion LoadRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadRegionHandle(table, parentKey, childKey);
        }

        //native LoadFogStateHandle takes hashtable table, integer parentKey, integer childKey returns fogstate
        private delegate JassFogState LoadFogStateHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadFogStateHandlePrototype _LoadFogStateHandle = WarcraftIII.Jass.GetNative("LoadFogStateHandle").ToDelegate<LoadFogStateHandlePrototype>();
        public JassFogState LoadFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadFogStateHandle(table, parentKey, childKey);
        }

        //native LoadFogModifierHandle takes hashtable table, integer parentKey, integer childKey returns fogmodifier
        private delegate JassFogModifier LoadFogModifierHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadFogModifierHandlePrototype _LoadFogModifierHandle = WarcraftIII.Jass.GetNative("LoadFogModifierHandle").ToDelegate<LoadFogModifierHandlePrototype>();
        public JassFogModifier LoadFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadFogModifierHandle(table, parentKey, childKey);
        }

        //native LoadHashtableHandle takes hashtable table, integer parentKey, integer childKey returns hashtable
        private delegate JassHashTable LoadHashtableHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private LoadHashtableHandlePrototype _LoadHashtableHandle = WarcraftIII.Jass.GetNative("LoadHashtableHandle").ToDelegate<LoadHashtableHandlePrototype>();
        public JassHashTable LoadHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _LoadHashtableHandle(table, parentKey, childKey);
        }

        //native HaveSavedInteger takes hashtable table, integer parentKey, integer childKey returns boolean
        private delegate JassBoolean HaveSavedIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private HaveSavedIntegerPrototype _HaveSavedInteger = WarcraftIII.Jass.GetNative("HaveSavedInteger").ToDelegate<HaveSavedIntegerPrototype>();
        public Boolean HaveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _HaveSavedInteger(table, parentKey, childKey);
        }

        //native HaveSavedReal takes hashtable table, integer parentKey, integer childKey returns boolean
        private delegate JassBoolean HaveSavedRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private HaveSavedRealPrototype _HaveSavedReal = WarcraftIII.Jass.GetNative("HaveSavedReal").ToDelegate<HaveSavedRealPrototype>();
        public Boolean HaveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _HaveSavedReal(table, parentKey, childKey);
        }

        //native HaveSavedBoolean takes hashtable table, integer parentKey, integer childKey returns boolean
        private delegate JassBoolean HaveSavedBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private HaveSavedBooleanPrototype _HaveSavedBoolean = WarcraftIII.Jass.GetNative("HaveSavedBoolean").ToDelegate<HaveSavedBooleanPrototype>();
        public Boolean HaveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _HaveSavedBoolean(table, parentKey, childKey);
        }

        //native HaveSavedString takes hashtable table, integer parentKey, integer childKey returns boolean
        private delegate JassBoolean HaveSavedStringPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private HaveSavedStringPrototype _HaveSavedString = WarcraftIII.Jass.GetNative("HaveSavedString").ToDelegate<HaveSavedStringPrototype>();
        public Boolean HaveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _HaveSavedString(table, parentKey, childKey);
        }

        //native HaveSavedHandle takes hashtable table, integer parentKey, integer childKey returns boolean
        private delegate JassBoolean HaveSavedHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private HaveSavedHandlePrototype _HaveSavedHandle = WarcraftIII.Jass.GetNative("HaveSavedHandle").ToDelegate<HaveSavedHandlePrototype>();
        public Boolean HaveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return _HaveSavedHandle(table, parentKey, childKey);
        }

        //native RemoveSavedInteger takes hashtable table, integer parentKey, integer childKey returns nothing
        private delegate void RemoveSavedIntegerPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private RemoveSavedIntegerPrototype _RemoveSavedInteger = WarcraftIII.Jass.GetNative("RemoveSavedInteger").ToDelegate<RemoveSavedIntegerPrototype>();
        public void RemoveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            _RemoveSavedInteger(table, parentKey, childKey);
        }

        //native RemoveSavedReal takes hashtable table, integer parentKey, integer childKey returns nothing
        private delegate void RemoveSavedRealPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private RemoveSavedRealPrototype _RemoveSavedReal = WarcraftIII.Jass.GetNative("RemoveSavedReal").ToDelegate<RemoveSavedRealPrototype>();
        public void RemoveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            _RemoveSavedReal(table, parentKey, childKey);
        }

        //native RemoveSavedBoolean takes hashtable table, integer parentKey, integer childKey returns nothing
        private delegate void RemoveSavedBooleanPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private RemoveSavedBooleanPrototype _RemoveSavedBoolean = WarcraftIII.Jass.GetNative("RemoveSavedBoolean").ToDelegate<RemoveSavedBooleanPrototype>();
        public void RemoveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            _RemoveSavedBoolean(table, parentKey, childKey);
        }

        //native RemoveSavedString takes hashtable table, integer parentKey, integer childKey returns nothing
        private delegate void RemoveSavedStringPrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private RemoveSavedStringPrototype _RemoveSavedString = WarcraftIII.Jass.GetNative("RemoveSavedString").ToDelegate<RemoveSavedStringPrototype>();
        public void RemoveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            _RemoveSavedString(table, parentKey, childKey);
        }

        //native RemoveSavedHandle takes hashtable table, integer parentKey, integer childKey returns nothing
        private delegate void RemoveSavedHandlePrototype(JassHashTable table, JassInteger parentKey, JassInteger childKey);
        private RemoveSavedHandlePrototype _RemoveSavedHandle = WarcraftIII.Jass.GetNative("RemoveSavedHandle").ToDelegate<RemoveSavedHandlePrototype>();
        public void RemoveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            _RemoveSavedHandle(table, parentKey, childKey);
        }

        //native FlushParentHashtable takes hashtable table returns nothing
        private delegate void FlushParentHashtablePrototype(JassHashTable table);
        private FlushParentHashtablePrototype _FlushParentHashtable = WarcraftIII.Jass.GetNative("FlushParentHashtable").ToDelegate<FlushParentHashtablePrototype>();
        public void FlushParentHashtable(JassHashTable table)
        {
            _FlushParentHashtable(table);
        }

        //native FlushChildHashtable takes hashtable table, integer parentKey returns nothing
        private delegate void FlushChildHashtablePrototype(JassHashTable table, JassInteger parentKey);
        private FlushChildHashtablePrototype _FlushChildHashtable = WarcraftIII.Jass.GetNative("FlushChildHashtable").ToDelegate<FlushChildHashtablePrototype>();
        public void FlushChildHashtable(JassHashTable table, JassInteger parentKey)
        {
            _FlushChildHashtable(table, parentKey);
        }

        //native GetRandomInt takes integer lowBound, integer highBound returns integer
        private delegate JassInteger GetRandomIntPrototype(JassInteger lowBound, JassInteger highBound);
        private GetRandomIntPrototype _GetRandomInt = WarcraftIII.Jass.GetNative("GetRandomInt").ToDelegate<GetRandomIntPrototype>();
        public JassInteger GetRandomInt(JassInteger lowBound, JassInteger highBound)
        {
            return _GetRandomInt(lowBound, highBound);
        }

        //native GetRandomReal takes real lowBound, real highBound returns real
        private delegate JassRealRet GetRandomRealPrototype(JassRealArg lowBound, JassRealArg highBound);
        private GetRandomRealPrototype _GetRandomReal = WarcraftIII.Jass.GetNative("GetRandomReal").ToDelegate<GetRandomRealPrototype>();
        public Single GetRandomReal(Single lowBound, Single highBound)
        {
            return _GetRandomReal(lowBound, highBound);
        }

        //native CreateUnitPool takes nothing returns unitpool
        private delegate JassUnitPool CreateUnitPoolPrototype();
        private CreateUnitPoolPrototype _CreateUnitPool = WarcraftIII.Jass.GetNative("CreateUnitPool").ToDelegate<CreateUnitPoolPrototype>();
        public JassUnitPool CreateUnitPool()
        {
            return _CreateUnitPool();
        }

        //native DestroyUnitPool takes unitpool whichPool returns nothing
        private delegate void DestroyUnitPoolPrototype(JassUnitPool whichPool);
        private DestroyUnitPoolPrototype _DestroyUnitPool = WarcraftIII.Jass.GetNative("DestroyUnitPool").ToDelegate<DestroyUnitPoolPrototype>();
        public void DestroyUnitPool(JassUnitPool whichPool)
        {
            _DestroyUnitPool(whichPool);
        }

        //native UnitPoolAddUnitType takes unitpool whichPool, integer unitId, real weight returns nothing
        private delegate void UnitPoolAddUnitTypePrototype(JassUnitPool whichPool, JassUnitId unitId, JassRealArg weight);
        private UnitPoolAddUnitTypePrototype _UnitPoolAddUnitType = WarcraftIII.Jass.GetNative("UnitPoolAddUnitType").ToDelegate<UnitPoolAddUnitTypePrototype>();
        public void UnitPoolAddUnitType(JassUnitPool whichPool, JassUnitId unitId, Single weight)
        {
            _UnitPoolAddUnitType(whichPool, unitId, weight);
        }

        //native UnitPoolRemoveUnitType takes unitpool whichPool, integer unitId returns nothing
        private delegate void UnitPoolRemoveUnitTypePrototype(JassUnitPool whichPool, JassUnitId unitId);
        private UnitPoolRemoveUnitTypePrototype _UnitPoolRemoveUnitType = WarcraftIII.Jass.GetNative("UnitPoolRemoveUnitType").ToDelegate<UnitPoolRemoveUnitTypePrototype>();
        public void UnitPoolRemoveUnitType(JassUnitPool whichPool, JassUnitId unitId)
        {
            _UnitPoolRemoveUnitType(whichPool, unitId);
        }

        //native PlaceRandomUnit takes unitpool whichPool, player forWhichPlayer, real x, real y, real facing returns unit
        private delegate JassUnit PlaceRandomUnitPrototype(JassUnitPool whichPool, JassPlayer forWhichPlayer, JassRealArg x, JassRealArg y, JassRealArg facing);
        private PlaceRandomUnitPrototype _PlaceRandomUnit = WarcraftIII.Jass.GetNative("PlaceRandomUnit").ToDelegate<PlaceRandomUnitPrototype>();
        public JassUnit PlaceRandomUnit(JassUnitPool whichPool, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return _PlaceRandomUnit(whichPool, forWhichPlayer, x, y, facing);
        }

        //native CreateItemPool takes nothing returns itempool
        private delegate JassItemPool CreateItemPoolPrototype();
        private CreateItemPoolPrototype _CreateItemPool = WarcraftIII.Jass.GetNative("CreateItemPool").ToDelegate<CreateItemPoolPrototype>();
        public JassItemPool CreateItemPool()
        {
            return _CreateItemPool();
        }

        //native DestroyItemPool takes itempool whichItemPool returns nothing
        private delegate void DestroyItemPoolPrototype(JassItemPool whichItemPool);
        private DestroyItemPoolPrototype _DestroyItemPool = WarcraftIII.Jass.GetNative("DestroyItemPool").ToDelegate<DestroyItemPoolPrototype>();
        public void DestroyItemPool(JassItemPool whichItemPool)
        {
            _DestroyItemPool(whichItemPool);
        }

        //native ItemPoolAddItemType takes itempool whichItemPool, integer itemId, real weight returns nothing
        private delegate void ItemPoolAddItemTypePrototype(JassItemPool whichItemPool, JassInteger itemId, JassRealArg weight);
        private ItemPoolAddItemTypePrototype _ItemPoolAddItemType = WarcraftIII.Jass.GetNative("ItemPoolAddItemType").ToDelegate<ItemPoolAddItemTypePrototype>();
        public void ItemPoolAddItemType(JassItemPool whichItemPool, JassInteger itemId, Single weight)
        {
            _ItemPoolAddItemType(whichItemPool, itemId, weight);
        }

        //native ItemPoolRemoveItemType takes itempool whichItemPool, integer itemId returns nothing
        private delegate void ItemPoolRemoveItemTypePrototype(JassItemPool whichItemPool, JassInteger itemId);
        private ItemPoolRemoveItemTypePrototype _ItemPoolRemoveItemType = WarcraftIII.Jass.GetNative("ItemPoolRemoveItemType").ToDelegate<ItemPoolRemoveItemTypePrototype>();
        public void ItemPoolRemoveItemType(JassItemPool whichItemPool, JassInteger itemId)
        {
            _ItemPoolRemoveItemType(whichItemPool, itemId);
        }

        //native PlaceRandomItem takes itempool whichItemPool, real x, real y returns item
        private delegate JassItem PlaceRandomItemPrototype(JassItemPool whichItemPool, JassRealArg x, JassRealArg y);
        private PlaceRandomItemPrototype _PlaceRandomItem = WarcraftIII.Jass.GetNative("PlaceRandomItem").ToDelegate<PlaceRandomItemPrototype>();
        public JassItem PlaceRandomItem(JassItemPool whichItemPool, Single x, Single y)
        {
            return _PlaceRandomItem(whichItemPool, x, y);
        }

        //native ChooseRandomCreep takes integer level returns integer
        private delegate JassInteger ChooseRandomCreepPrototype(JassInteger level);
        private ChooseRandomCreepPrototype _ChooseRandomCreep = WarcraftIII.Jass.GetNative("ChooseRandomCreep").ToDelegate<ChooseRandomCreepPrototype>();
        public JassInteger ChooseRandomCreep(JassInteger level)
        {
            return _ChooseRandomCreep(level);
        }

        //native ChooseRandomNPBuilding takes nothing returns integer
        private delegate JassInteger ChooseRandomNPBuildingPrototype();
        private ChooseRandomNPBuildingPrototype _ChooseRandomNPBuilding = WarcraftIII.Jass.GetNative("ChooseRandomNPBuilding").ToDelegate<ChooseRandomNPBuildingPrototype>();
        public JassInteger ChooseRandomNPBuilding()
        {
            return _ChooseRandomNPBuilding();
        }

        //native ChooseRandomItem takes integer level returns integer
        private delegate JassInteger ChooseRandomItemPrototype(JassInteger level);
        private ChooseRandomItemPrototype _ChooseRandomItem = WarcraftIII.Jass.GetNative("ChooseRandomItem").ToDelegate<ChooseRandomItemPrototype>();
        public JassInteger ChooseRandomItem(JassInteger level)
        {
            return _ChooseRandomItem(level);
        }

        //native ChooseRandomItemEx takes itemtype whichType, integer level returns integer
        private delegate JassInteger ChooseRandomItemExPrototype(JassItemType whichType, JassInteger level);
        private ChooseRandomItemExPrototype _ChooseRandomItemEx = WarcraftIII.Jass.GetNative("ChooseRandomItemEx").ToDelegate<ChooseRandomItemExPrototype>();
        public JassInteger ChooseRandomItemEx(JassItemType whichType, JassInteger level)
        {
            return _ChooseRandomItemEx(whichType, level);
        }

        //native SetRandomSeed takes integer seed returns nothing
        private delegate void SetRandomSeedPrototype(JassInteger seed);
        private SetRandomSeedPrototype _SetRandomSeed = WarcraftIII.Jass.GetNative("SetRandomSeed").ToDelegate<SetRandomSeedPrototype>();
        public void SetRandomSeed(JassInteger seed)
        {
            _SetRandomSeed(seed);
        }

        //native SetTerrainFog takes real a, real b, real c, real d, real e returns nothing
        private delegate void SetTerrainFogPrototype(JassRealArg a, JassRealArg b, JassRealArg c, JassRealArg d, JassRealArg e);
        private SetTerrainFogPrototype _SetTerrainFog = WarcraftIII.Jass.GetNative("SetTerrainFog").ToDelegate<SetTerrainFogPrototype>();
        public void SetTerrainFog(Single a, Single b, Single c, Single d, Single e)
        {
            _SetTerrainFog(a, b, c, d, e);
        }

        //native ResetTerrainFog takes nothing returns nothing
        private delegate void ResetTerrainFogPrototype();
        private ResetTerrainFogPrototype _ResetTerrainFog = WarcraftIII.Jass.GetNative("ResetTerrainFog").ToDelegate<ResetTerrainFogPrototype>();
        public void ResetTerrainFog()
        {
            _ResetTerrainFog();
        }

        //native SetUnitFog takes real a, real b, real c, real d, real e returns nothing
        private delegate void SetUnitFogPrototype(JassRealArg a, JassRealArg b, JassRealArg c, JassRealArg d, JassRealArg e);
        private SetUnitFogPrototype _SetUnitFog = WarcraftIII.Jass.GetNative("SetUnitFog").ToDelegate<SetUnitFogPrototype>();
        public void SetUnitFog(Single a, Single b, Single c, Single d, Single e)
        {
            _SetUnitFog(a, b, c, d, e);
        }

        //native SetTerrainFogEx takes integer style, real zstart, real zend, real density, real red, real green, real blue returns nothing
        private delegate void SetTerrainFogExPrototype(JassInteger style, JassRealArg zstart, JassRealArg zend, JassRealArg density, JassRealArg red, JassRealArg green, JassRealArg blue);
        private SetTerrainFogExPrototype _SetTerrainFogEx = WarcraftIII.Jass.GetNative("SetTerrainFogEx").ToDelegate<SetTerrainFogExPrototype>();
        public void SetTerrainFogEx(JassInteger style, Single zstart, Single zend, Single density, Single red, Single green, Single blue)
        {
            _SetTerrainFogEx(style, zstart, zend, density, red, green, blue);
        }

        //native DisplayTextToPlayer takes player toPlayer, real x, real y, string message returns nothing
        private delegate void DisplayTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassStringArg message);
        private DisplayTextToPlayerPrototype _DisplayTextToPlayer = WarcraftIII.Jass.GetNative("DisplayTextToPlayer").ToDelegate<DisplayTextToPlayerPrototype>();
        public void DisplayTextToPlayer(JassPlayer toPlayer, Single x, Single y, String message)
        {
            _DisplayTextToPlayer(toPlayer, x, y, message);
        }

        //native DisplayTimedTextToPlayer takes player toPlayer, real x, real y, real duration, string message returns nothing
        private delegate void DisplayTimedTextToPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassRealArg duration, JassStringArg message);
        private DisplayTimedTextToPlayerPrototype _DisplayTimedTextToPlayer = WarcraftIII.Jass.GetNative("DisplayTimedTextToPlayer").ToDelegate<DisplayTimedTextToPlayerPrototype>();
        public void DisplayTimedTextToPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            _DisplayTimedTextToPlayer(toPlayer, x, y, duration, message);
        }

        //native DisplayTimedTextFromPlayer takes player toPlayer, real x, real y, real duration, string message returns nothing
        private delegate void DisplayTimedTextFromPlayerPrototype(JassPlayer toPlayer, JassRealArg x, JassRealArg y, JassRealArg duration, JassStringArg message);
        private DisplayTimedTextFromPlayerPrototype _DisplayTimedTextFromPlayer = WarcraftIII.Jass.GetNative("DisplayTimedTextFromPlayer").ToDelegate<DisplayTimedTextFromPlayerPrototype>();
        public void DisplayTimedTextFromPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            _DisplayTimedTextFromPlayer(toPlayer, x, y, duration, message);
        }

        //native ClearTextMessages takes nothing returns nothing
        private delegate void ClearTextMessagesPrototype();
        private ClearTextMessagesPrototype _ClearTextMessages = WarcraftIII.Jass.GetNative("ClearTextMessages").ToDelegate<ClearTextMessagesPrototype>();
        public void ClearTextMessages()
        {
            _ClearTextMessages();
        }

        //native SetDayNightModels takes string terrainDNCFile, string unitDNCFile returns nothing
        private delegate void SetDayNightModelsPrototype(JassStringArg terrainDNCFile, JassStringArg unitDNCFile);
        private SetDayNightModelsPrototype _SetDayNightModels = WarcraftIII.Jass.GetNative("SetDayNightModels").ToDelegate<SetDayNightModelsPrototype>();
        public void SetDayNightModels(String terrainDNCFile, String unitDNCFile)
        {
            _SetDayNightModels(terrainDNCFile, unitDNCFile);
        }

        //native SetSkyModel takes string skyModelFile returns nothing
        private delegate void SetSkyModelPrototype(JassStringArg skyModelFile);
        private SetSkyModelPrototype _SetSkyModel = WarcraftIII.Jass.GetNative("SetSkyModel").ToDelegate<SetSkyModelPrototype>();
        public void SetSkyModel(String skyModelFile)
        {
            _SetSkyModel(skyModelFile);
        }

        //native EnableUserControl takes boolean b returns nothing
        private delegate void EnableUserControlPrototype(JassBoolean b);
        private EnableUserControlPrototype _EnableUserControl = WarcraftIII.Jass.GetNative("EnableUserControl").ToDelegate<EnableUserControlPrototype>();
        public void EnableUserControl(Boolean b)
        {
            _EnableUserControl(b);
        }

        //native EnableUserUI takes boolean b returns nothing
        private delegate void EnableUserUIPrototype(JassBoolean b);
        private EnableUserUIPrototype _EnableUserUI = WarcraftIII.Jass.GetNative("EnableUserUI").ToDelegate<EnableUserUIPrototype>();
        public void EnableUserUI(Boolean b)
        {
            _EnableUserUI(b);
        }

        //native SuspendTimeOfDay takes boolean b returns nothing
        private delegate void SuspendTimeOfDayPrototype(JassBoolean b);
        private SuspendTimeOfDayPrototype _SuspendTimeOfDay = WarcraftIII.Jass.GetNative("SuspendTimeOfDay").ToDelegate<SuspendTimeOfDayPrototype>();
        public void SuspendTimeOfDay(Boolean b)
        {
            _SuspendTimeOfDay(b);
        }

        //native SetTimeOfDayScale takes real r returns nothing
        private delegate void SetTimeOfDayScalePrototype(JassRealArg r);
        private SetTimeOfDayScalePrototype _SetTimeOfDayScale = WarcraftIII.Jass.GetNative("SetTimeOfDayScale").ToDelegate<SetTimeOfDayScalePrototype>();
        public void SetTimeOfDayScale(Single r)
        {
            _SetTimeOfDayScale(r);
        }

        //native GetTimeOfDayScale takes nothing returns real
        private delegate JassRealRet GetTimeOfDayScalePrototype();
        private GetTimeOfDayScalePrototype _GetTimeOfDayScale = WarcraftIII.Jass.GetNative("GetTimeOfDayScale").ToDelegate<GetTimeOfDayScalePrototype>();
        public Single GetTimeOfDayScale()
        {
            return _GetTimeOfDayScale();
        }

        //native ShowInterface takes boolean flag, real fadeDuration returns nothing
        private delegate void ShowInterfacePrototype(JassBoolean flag, JassRealArg fadeDuration);
        private ShowInterfacePrototype _ShowInterface = WarcraftIII.Jass.GetNative("ShowInterface").ToDelegate<ShowInterfacePrototype>();
        public void ShowInterface(Boolean flag, Single fadeDuration)
        {
            _ShowInterface(flag, fadeDuration);
        }

        //native PauseGame takes boolean flag returns nothing
        private delegate void PauseGamePrototype(JassBoolean flag);
        private PauseGamePrototype _PauseGame = WarcraftIII.Jass.GetNative("PauseGame").ToDelegate<PauseGamePrototype>();
        public void PauseGame(Boolean flag)
        {
            _PauseGame(flag);
        }

        //native UnitAddIndicator takes unit whichUnit, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void UnitAddIndicatorPrototype(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private UnitAddIndicatorPrototype _UnitAddIndicator = WarcraftIII.Jass.GetNative("UnitAddIndicator").ToDelegate<UnitAddIndicatorPrototype>();
        public void UnitAddIndicator(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _UnitAddIndicator(whichUnit, red, green, blue, alpha);
        }

        //native AddIndicator takes widget whichWidget, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void AddIndicatorPrototype(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private AddIndicatorPrototype _AddIndicator = WarcraftIII.Jass.GetNative("AddIndicator").ToDelegate<AddIndicatorPrototype>();
        public void AddIndicator(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _AddIndicator(whichWidget, red, green, blue, alpha);
        }

        //native PingMinimap takes real x, real y, real duration returns nothing
        private delegate void PingMinimapPrototype(JassRealArg x, JassRealArg y, JassRealArg duration);
        private PingMinimapPrototype _PingMinimap = WarcraftIII.Jass.GetNative("PingMinimap").ToDelegate<PingMinimapPrototype>();
        public void PingMinimap(Single x, Single y, Single duration)
        {
            _PingMinimap(x, y, duration);
        }

        //native PingMinimapEx takes real x, real y, real duration, integer red, integer green, integer blue, boolean extraEffects returns nothing
        private delegate void PingMinimapExPrototype(JassRealArg x, JassRealArg y, JassRealArg duration, JassInteger red, JassInteger green, JassInteger blue, JassBoolean extraEffects);
        private PingMinimapExPrototype _PingMinimapEx = WarcraftIII.Jass.GetNative("PingMinimapEx").ToDelegate<PingMinimapExPrototype>();
        public void PingMinimapEx(Single x, Single y, Single duration, JassInteger red, JassInteger green, JassInteger blue, Boolean extraEffects)
        {
            _PingMinimapEx(x, y, duration, red, green, blue, extraEffects);
        }

        //native EnableOcclusion takes boolean flag returns nothing
        private delegate void EnableOcclusionPrototype(JassBoolean flag);
        private EnableOcclusionPrototype _EnableOcclusion = WarcraftIII.Jass.GetNative("EnableOcclusion").ToDelegate<EnableOcclusionPrototype>();
        public void EnableOcclusion(Boolean flag)
        {
            _EnableOcclusion(flag);
        }

        //native SetIntroShotText takes string introText returns nothing
        private delegate void SetIntroShotTextPrototype(JassStringArg introText);
        private SetIntroShotTextPrototype _SetIntroShotText = WarcraftIII.Jass.GetNative("SetIntroShotText").ToDelegate<SetIntroShotTextPrototype>();
        public void SetIntroShotText(String introText)
        {
            _SetIntroShotText(introText);
        }

        //native SetIntroShotModel takes string introModelPath returns nothing
        private delegate void SetIntroShotModelPrototype(JassStringArg introModelPath);
        private SetIntroShotModelPrototype _SetIntroShotModel = WarcraftIII.Jass.GetNative("SetIntroShotModel").ToDelegate<SetIntroShotModelPrototype>();
        public void SetIntroShotModel(String introModelPath)
        {
            _SetIntroShotModel(introModelPath);
        }

        //native EnableWorldFogBoundary takes boolean b returns nothing
        private delegate void EnableWorldFogBoundaryPrototype(JassBoolean b);
        private EnableWorldFogBoundaryPrototype _EnableWorldFogBoundary = WarcraftIII.Jass.GetNative("EnableWorldFogBoundary").ToDelegate<EnableWorldFogBoundaryPrototype>();
        public void EnableWorldFogBoundary(Boolean b)
        {
            _EnableWorldFogBoundary(b);
        }

        //native PlayModelCinematic takes string modelName returns nothing
        private delegate void PlayModelCinematicPrototype(JassStringArg modelName);
        private PlayModelCinematicPrototype _PlayModelCinematic = WarcraftIII.Jass.GetNative("PlayModelCinematic").ToDelegate<PlayModelCinematicPrototype>();
        public void PlayModelCinematic(String modelName)
        {
            _PlayModelCinematic(modelName);
        }

        //native PlayCinematic takes string movieName returns nothing
        private delegate void PlayCinematicPrototype(JassStringArg movieName);
        private PlayCinematicPrototype _PlayCinematic = WarcraftIII.Jass.GetNative("PlayCinematic").ToDelegate<PlayCinematicPrototype>();
        public void PlayCinematic(String movieName)
        {
            _PlayCinematic(movieName);
        }

        //native ForceUIKey takes string key returns nothing
        private delegate void ForceUIKeyPrototype(JassStringArg key);
        private ForceUIKeyPrototype _ForceUIKey = WarcraftIII.Jass.GetNative("ForceUIKey").ToDelegate<ForceUIKeyPrototype>();
        public void ForceUIKey(String key)
        {
            _ForceUIKey(key);
        }

        //native ForceUICancel takes nothing returns nothing
        private delegate void ForceUICancelPrototype();
        private ForceUICancelPrototype _ForceUICancel = WarcraftIII.Jass.GetNative("ForceUICancel").ToDelegate<ForceUICancelPrototype>();
        public void ForceUICancel()
        {
            _ForceUICancel();
        }

        //native DisplayLoadDialog takes nothing returns nothing
        private delegate void DisplayLoadDialogPrototype();
        private DisplayLoadDialogPrototype _DisplayLoadDialog = WarcraftIII.Jass.GetNative("DisplayLoadDialog").ToDelegate<DisplayLoadDialogPrototype>();
        public void DisplayLoadDialog()
        {
            _DisplayLoadDialog();
        }

        //native SetAltMinimapIcon takes string iconPath returns nothing
        private delegate void SetAltMinimapIconPrototype(JassStringArg iconPath);
        private SetAltMinimapIconPrototype _SetAltMinimapIcon = WarcraftIII.Jass.GetNative("SetAltMinimapIcon").ToDelegate<SetAltMinimapIconPrototype>();
        public void SetAltMinimapIcon(String iconPath)
        {
            _SetAltMinimapIcon(iconPath);
        }

        //native DisableRestartMission takes boolean flag returns nothing
        private delegate void DisableRestartMissionPrototype(JassBoolean flag);
        private DisableRestartMissionPrototype _DisableRestartMission = WarcraftIII.Jass.GetNative("DisableRestartMission").ToDelegate<DisableRestartMissionPrototype>();
        public void DisableRestartMission(Boolean flag)
        {
            _DisableRestartMission(flag);
        }

        //native CreateTextTag takes nothing returns texttag
        private delegate JassTextTag CreateTextTagPrototype();
        private CreateTextTagPrototype _CreateTextTag = WarcraftIII.Jass.GetNative("CreateTextTag").ToDelegate<CreateTextTagPrototype>();
        public JassTextTag CreateTextTag()
        {
            return _CreateTextTag();
        }

        //native DestroyTextTag takes texttag t returns nothing
        private delegate void DestroyTextTagPrototype(JassTextTag t);
        private DestroyTextTagPrototype _DestroyTextTag = WarcraftIII.Jass.GetNative("DestroyTextTag").ToDelegate<DestroyTextTagPrototype>();
        public void DestroyTextTag(JassTextTag t)
        {
            _DestroyTextTag(t);
        }

        //native SetTextTagText takes texttag t, string s, real height returns nothing
        private delegate void SetTextTagTextPrototype(JassTextTag t, JassStringArg s, JassRealArg height);
        private SetTextTagTextPrototype _SetTextTagText = WarcraftIII.Jass.GetNative("SetTextTagText").ToDelegate<SetTextTagTextPrototype>();
        public void SetTextTagText(JassTextTag t, String s, Single height)
        {
            _SetTextTagText(t, s, height);
        }

        //native SetTextTagPos takes texttag t, real x, real y, real heightOffset returns nothing
        private delegate void SetTextTagPosPrototype(JassTextTag t, JassRealArg x, JassRealArg y, JassRealArg heightOffset);
        private SetTextTagPosPrototype _SetTextTagPos = WarcraftIII.Jass.GetNative("SetTextTagPos").ToDelegate<SetTextTagPosPrototype>();
        public void SetTextTagPos(JassTextTag t, Single x, Single y, Single heightOffset)
        {
            _SetTextTagPos(t, x, y, heightOffset);
        }

        //native SetTextTagPosUnit takes texttag t, unit whichUnit, real heightOffset returns nothing
        private delegate void SetTextTagPosUnitPrototype(JassTextTag t, JassUnit whichUnit, JassRealArg heightOffset);
        private SetTextTagPosUnitPrototype _SetTextTagPosUnit = WarcraftIII.Jass.GetNative("SetTextTagPosUnit").ToDelegate<SetTextTagPosUnitPrototype>();
        public void SetTextTagPosUnit(JassTextTag t, JassUnit whichUnit, Single heightOffset)
        {
            _SetTextTagPosUnit(t, whichUnit, heightOffset);
        }

        //native SetTextTagColor takes texttag t, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void SetTextTagColorPrototype(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private SetTextTagColorPrototype _SetTextTagColor = WarcraftIII.Jass.GetNative("SetTextTagColor").ToDelegate<SetTextTagColorPrototype>();
        public void SetTextTagColor(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _SetTextTagColor(t, red, green, blue, alpha);
        }

        //native SetTextTagVelocity takes texttag t, real xvel, real yvel returns nothing
        private delegate void SetTextTagVelocityPrototype(JassTextTag t, JassRealArg xvel, JassRealArg yvel);
        private SetTextTagVelocityPrototype _SetTextTagVelocity = WarcraftIII.Jass.GetNative("SetTextTagVelocity").ToDelegate<SetTextTagVelocityPrototype>();
        public void SetTextTagVelocity(JassTextTag t, Single xvel, Single yvel)
        {
            _SetTextTagVelocity(t, xvel, yvel);
        }

        //native SetTextTagVisibility takes texttag t, boolean flag returns nothing
        private delegate void SetTextTagVisibilityPrototype(JassTextTag t, JassBoolean flag);
        private SetTextTagVisibilityPrototype _SetTextTagVisibility = WarcraftIII.Jass.GetNative("SetTextTagVisibility").ToDelegate<SetTextTagVisibilityPrototype>();
        public void SetTextTagVisibility(JassTextTag t, Boolean flag)
        {
            _SetTextTagVisibility(t, flag);
        }

        //native SetTextTagSuspended takes texttag t, boolean flag returns nothing
        private delegate void SetTextTagSuspendedPrototype(JassTextTag t, JassBoolean flag);
        private SetTextTagSuspendedPrototype _SetTextTagSuspended = WarcraftIII.Jass.GetNative("SetTextTagSuspended").ToDelegate<SetTextTagSuspendedPrototype>();
        public void SetTextTagSuspended(JassTextTag t, Boolean flag)
        {
            _SetTextTagSuspended(t, flag);
        }

        //native SetTextTagPermanent takes texttag t, boolean flag returns nothing
        private delegate void SetTextTagPermanentPrototype(JassTextTag t, JassBoolean flag);
        private SetTextTagPermanentPrototype _SetTextTagPermanent = WarcraftIII.Jass.GetNative("SetTextTagPermanent").ToDelegate<SetTextTagPermanentPrototype>();
        public void SetTextTagPermanent(JassTextTag t, Boolean flag)
        {
            _SetTextTagPermanent(t, flag);
        }

        //native SetTextTagAge takes texttag t, real age returns nothing
        private delegate void SetTextTagAgePrototype(JassTextTag t, JassRealArg age);
        private SetTextTagAgePrototype _SetTextTagAge = WarcraftIII.Jass.GetNative("SetTextTagAge").ToDelegate<SetTextTagAgePrototype>();
        public void SetTextTagAge(JassTextTag t, Single age)
        {
            _SetTextTagAge(t, age);
        }

        //native SetTextTagLifespan takes texttag t, real lifespan returns nothing
        private delegate void SetTextTagLifespanPrototype(JassTextTag t, JassRealArg lifespan);
        private SetTextTagLifespanPrototype _SetTextTagLifespan = WarcraftIII.Jass.GetNative("SetTextTagLifespan").ToDelegate<SetTextTagLifespanPrototype>();
        public void SetTextTagLifespan(JassTextTag t, Single lifespan)
        {
            _SetTextTagLifespan(t, lifespan);
        }

        //native SetTextTagFadepoint takes texttag t, real fadepoint returns nothing
        private delegate void SetTextTagFadepointPrototype(JassTextTag t, JassRealArg fadepoint);
        private SetTextTagFadepointPrototype _SetTextTagFadepoint = WarcraftIII.Jass.GetNative("SetTextTagFadepoint").ToDelegate<SetTextTagFadepointPrototype>();
        public void SetTextTagFadepoint(JassTextTag t, Single fadepoint)
        {
            _SetTextTagFadepoint(t, fadepoint);
        }

        //native SetReservedLocalHeroButtons takes integer reserved returns nothing
        private delegate void SetReservedLocalHeroButtonsPrototype(JassInteger reserved);
        private SetReservedLocalHeroButtonsPrototype _SetReservedLocalHeroButtons = WarcraftIII.Jass.GetNative("SetReservedLocalHeroButtons").ToDelegate<SetReservedLocalHeroButtonsPrototype>();
        public void SetReservedLocalHeroButtons(JassInteger reserved)
        {
            _SetReservedLocalHeroButtons(reserved);
        }

        //native GetAllyColorFilterState takes nothing returns integer
        private delegate JassInteger GetAllyColorFilterStatePrototype();
        private GetAllyColorFilterStatePrototype _GetAllyColorFilterState = WarcraftIII.Jass.GetNative("GetAllyColorFilterState").ToDelegate<GetAllyColorFilterStatePrototype>();
        public JassInteger GetAllyColorFilterState()
        {
            return _GetAllyColorFilterState();
        }

        //native SetAllyColorFilterState takes integer state returns nothing
        private delegate void SetAllyColorFilterStatePrototype(JassInteger state);
        private SetAllyColorFilterStatePrototype _SetAllyColorFilterState = WarcraftIII.Jass.GetNative("SetAllyColorFilterState").ToDelegate<SetAllyColorFilterStatePrototype>();
        public void SetAllyColorFilterState(JassInteger state)
        {
            _SetAllyColorFilterState(state);
        }

        //native GetCreepCampFilterState takes nothing returns boolean
        private delegate JassBoolean GetCreepCampFilterStatePrototype();
        private GetCreepCampFilterStatePrototype _GetCreepCampFilterState = WarcraftIII.Jass.GetNative("GetCreepCampFilterState").ToDelegate<GetCreepCampFilterStatePrototype>();
        public Boolean GetCreepCampFilterState()
        {
            return _GetCreepCampFilterState();
        }

        //native SetCreepCampFilterState takes boolean state returns nothing
        private delegate void SetCreepCampFilterStatePrototype(JassBoolean state);
        private SetCreepCampFilterStatePrototype _SetCreepCampFilterState = WarcraftIII.Jass.GetNative("SetCreepCampFilterState").ToDelegate<SetCreepCampFilterStatePrototype>();
        public void SetCreepCampFilterState(Boolean state)
        {
            _SetCreepCampFilterState(state);
        }

        //native EnableMinimapFilterButtons takes boolean enableAlly, boolean enableCreep returns nothing
        private delegate void EnableMinimapFilterButtonsPrototype(JassBoolean enableAlly, JassBoolean enableCreep);
        private EnableMinimapFilterButtonsPrototype _EnableMinimapFilterButtons = WarcraftIII.Jass.GetNative("EnableMinimapFilterButtons").ToDelegate<EnableMinimapFilterButtonsPrototype>();
        public void EnableMinimapFilterButtons(Boolean enableAlly, Boolean enableCreep)
        {
            _EnableMinimapFilterButtons(enableAlly, enableCreep);
        }

        //native EnableDragSelect takes boolean state, boolean ui returns nothing
        private delegate void EnableDragSelectPrototype(JassBoolean state, JassBoolean ui);
        private EnableDragSelectPrototype _EnableDragSelect = WarcraftIII.Jass.GetNative("EnableDragSelect").ToDelegate<EnableDragSelectPrototype>();
        public void EnableDragSelect(Boolean state, Boolean ui)
        {
            _EnableDragSelect(state, ui);
        }

        //native EnablePreSelect takes boolean state, boolean ui returns nothing
        private delegate void EnablePreSelectPrototype(JassBoolean state, JassBoolean ui);
        private EnablePreSelectPrototype _EnablePreSelect = WarcraftIII.Jass.GetNative("EnablePreSelect").ToDelegate<EnablePreSelectPrototype>();
        public void EnablePreSelect(Boolean state, Boolean ui)
        {
            _EnablePreSelect(state, ui);
        }

        //native EnableSelect takes boolean state, boolean ui returns nothing
        private delegate void EnableSelectPrototype(JassBoolean state, JassBoolean ui);
        private EnableSelectPrototype _EnableSelect = WarcraftIII.Jass.GetNative("EnableSelect").ToDelegate<EnableSelectPrototype>();
        public void EnableSelect(Boolean state, Boolean ui)
        {
            _EnableSelect(state, ui);
        }

        //native CreateTrackable takes string trackableModelPath, real x, real y, real facing returns trackable
        private delegate JassTrackable CreateTrackablePrototype(JassStringArg trackableModelPath, JassRealArg x, JassRealArg y, JassRealArg facing);
        private CreateTrackablePrototype _CreateTrackable = WarcraftIII.Jass.GetNative("CreateTrackable").ToDelegate<CreateTrackablePrototype>();
        public JassTrackable CreateTrackable(String trackableModelPath, Single x, Single y, Single facing)
        {
            return _CreateTrackable(trackableModelPath, x, y, facing);
        }

        //native CreateQuest takes nothing returns quest
        private delegate JassQuest CreateQuestPrototype();
        private CreateQuestPrototype _CreateQuest = WarcraftIII.Jass.GetNative("CreateQuest").ToDelegate<CreateQuestPrototype>();
        public JassQuest CreateQuest()
        {
            return _CreateQuest();
        }

        //native DestroyQuest takes quest whichQuest returns nothing
        private delegate void DestroyQuestPrototype(JassQuest whichQuest);
        private DestroyQuestPrototype _DestroyQuest = WarcraftIII.Jass.GetNative("DestroyQuest").ToDelegate<DestroyQuestPrototype>();
        public void DestroyQuest(JassQuest whichQuest)
        {
            _DestroyQuest(whichQuest);
        }

        //native QuestSetTitle takes quest whichQuest, string title returns nothing
        private delegate void QuestSetTitlePrototype(JassQuest whichQuest, JassStringArg title);
        private QuestSetTitlePrototype _QuestSetTitle = WarcraftIII.Jass.GetNative("QuestSetTitle").ToDelegate<QuestSetTitlePrototype>();
        public void QuestSetTitle(JassQuest whichQuest, String title)
        {
            _QuestSetTitle(whichQuest, title);
        }

        //native QuestSetDescription takes quest whichQuest, string description returns nothing
        private delegate void QuestSetDescriptionPrototype(JassQuest whichQuest, JassStringArg description);
        private QuestSetDescriptionPrototype _QuestSetDescription = WarcraftIII.Jass.GetNative("QuestSetDescription").ToDelegate<QuestSetDescriptionPrototype>();
        public void QuestSetDescription(JassQuest whichQuest, String description)
        {
            _QuestSetDescription(whichQuest, description);
        }

        //native QuestSetIconPath takes quest whichQuest, string iconPath returns nothing
        private delegate void QuestSetIconPathPrototype(JassQuest whichQuest, JassStringArg iconPath);
        private QuestSetIconPathPrototype _QuestSetIconPath = WarcraftIII.Jass.GetNative("QuestSetIconPath").ToDelegate<QuestSetIconPathPrototype>();
        public void QuestSetIconPath(JassQuest whichQuest, String iconPath)
        {
            _QuestSetIconPath(whichQuest, iconPath);
        }

        //native QuestSetRequired takes quest whichQuest, boolean required returns nothing
        private delegate void QuestSetRequiredPrototype(JassQuest whichQuest, JassBoolean required);
        private QuestSetRequiredPrototype _QuestSetRequired = WarcraftIII.Jass.GetNative("QuestSetRequired").ToDelegate<QuestSetRequiredPrototype>();
        public void QuestSetRequired(JassQuest whichQuest, Boolean required)
        {
            _QuestSetRequired(whichQuest, required);
        }

        //native QuestSetCompleted takes quest whichQuest, boolean completed returns nothing
        private delegate void QuestSetCompletedPrototype(JassQuest whichQuest, JassBoolean completed);
        private QuestSetCompletedPrototype _QuestSetCompleted = WarcraftIII.Jass.GetNative("QuestSetCompleted").ToDelegate<QuestSetCompletedPrototype>();
        public void QuestSetCompleted(JassQuest whichQuest, Boolean completed)
        {
            _QuestSetCompleted(whichQuest, completed);
        }

        //native QuestSetDiscovered takes quest whichQuest, boolean discovered returns nothing
        private delegate void QuestSetDiscoveredPrototype(JassQuest whichQuest, JassBoolean discovered);
        private QuestSetDiscoveredPrototype _QuestSetDiscovered = WarcraftIII.Jass.GetNative("QuestSetDiscovered").ToDelegate<QuestSetDiscoveredPrototype>();
        public void QuestSetDiscovered(JassQuest whichQuest, Boolean discovered)
        {
            _QuestSetDiscovered(whichQuest, discovered);
        }

        //native QuestSetFailed takes quest whichQuest, boolean failed returns nothing
        private delegate void QuestSetFailedPrototype(JassQuest whichQuest, JassBoolean failed);
        private QuestSetFailedPrototype _QuestSetFailed = WarcraftIII.Jass.GetNative("QuestSetFailed").ToDelegate<QuestSetFailedPrototype>();
        public void QuestSetFailed(JassQuest whichQuest, Boolean failed)
        {
            _QuestSetFailed(whichQuest, failed);
        }

        //native QuestSetEnabled takes quest whichQuest, boolean enabled returns nothing
        private delegate void QuestSetEnabledPrototype(JassQuest whichQuest, JassBoolean enabled);
        private QuestSetEnabledPrototype _QuestSetEnabled = WarcraftIII.Jass.GetNative("QuestSetEnabled").ToDelegate<QuestSetEnabledPrototype>();
        public void QuestSetEnabled(JassQuest whichQuest, Boolean enabled)
        {
            _QuestSetEnabled(whichQuest, enabled);
        }

        //native IsQuestRequired takes quest whichQuest returns boolean
        private delegate JassBoolean IsQuestRequiredPrototype(JassQuest whichQuest);
        private IsQuestRequiredPrototype _IsQuestRequired = WarcraftIII.Jass.GetNative("IsQuestRequired").ToDelegate<IsQuestRequiredPrototype>();
        public Boolean IsQuestRequired(JassQuest whichQuest)
        {
            return _IsQuestRequired(whichQuest);
        }

        //native IsQuestCompleted takes quest whichQuest returns boolean
        private delegate JassBoolean IsQuestCompletedPrototype(JassQuest whichQuest);
        private IsQuestCompletedPrototype _IsQuestCompleted = WarcraftIII.Jass.GetNative("IsQuestCompleted").ToDelegate<IsQuestCompletedPrototype>();
        public Boolean IsQuestCompleted(JassQuest whichQuest)
        {
            return _IsQuestCompleted(whichQuest);
        }

        //native IsQuestDiscovered takes quest whichQuest returns boolean
        private delegate JassBoolean IsQuestDiscoveredPrototype(JassQuest whichQuest);
        private IsQuestDiscoveredPrototype _IsQuestDiscovered = WarcraftIII.Jass.GetNative("IsQuestDiscovered").ToDelegate<IsQuestDiscoveredPrototype>();
        public Boolean IsQuestDiscovered(JassQuest whichQuest)
        {
            return _IsQuestDiscovered(whichQuest);
        }

        //native IsQuestFailed takes quest whichQuest returns boolean
        private delegate JassBoolean IsQuestFailedPrototype(JassQuest whichQuest);
        private IsQuestFailedPrototype _IsQuestFailed = WarcraftIII.Jass.GetNative("IsQuestFailed").ToDelegate<IsQuestFailedPrototype>();
        public Boolean IsQuestFailed(JassQuest whichQuest)
        {
            return _IsQuestFailed(whichQuest);
        }

        //native IsQuestEnabled takes quest whichQuest returns boolean
        private delegate JassBoolean IsQuestEnabledPrototype(JassQuest whichQuest);
        private IsQuestEnabledPrototype _IsQuestEnabled = WarcraftIII.Jass.GetNative("IsQuestEnabled").ToDelegate<IsQuestEnabledPrototype>();
        public Boolean IsQuestEnabled(JassQuest whichQuest)
        {
            return _IsQuestEnabled(whichQuest);
        }

        //native QuestCreateItem takes quest whichQuest returns questitem
        private delegate JassQuestItem QuestCreateItemPrototype(JassQuest whichQuest);
        private QuestCreateItemPrototype _QuestCreateItem = WarcraftIII.Jass.GetNative("QuestCreateItem").ToDelegate<QuestCreateItemPrototype>();
        public JassQuestItem QuestCreateItem(JassQuest whichQuest)
        {
            return _QuestCreateItem(whichQuest);
        }

        //native QuestItemSetDescription takes questitem whichQuestItem, string description returns nothing
        private delegate void QuestItemSetDescriptionPrototype(JassQuestItem whichQuestItem, JassStringArg description);
        private QuestItemSetDescriptionPrototype _QuestItemSetDescription = WarcraftIII.Jass.GetNative("QuestItemSetDescription").ToDelegate<QuestItemSetDescriptionPrototype>();
        public void QuestItemSetDescription(JassQuestItem whichQuestItem, String description)
        {
            _QuestItemSetDescription(whichQuestItem, description);
        }

        //native QuestItemSetCompleted takes questitem whichQuestItem, boolean completed returns nothing
        private delegate void QuestItemSetCompletedPrototype(JassQuestItem whichQuestItem, JassBoolean completed);
        private QuestItemSetCompletedPrototype _QuestItemSetCompleted = WarcraftIII.Jass.GetNative("QuestItemSetCompleted").ToDelegate<QuestItemSetCompletedPrototype>();
        public void QuestItemSetCompleted(JassQuestItem whichQuestItem, Boolean completed)
        {
            _QuestItemSetCompleted(whichQuestItem, completed);
        }

        //native IsQuestItemCompleted takes questitem whichQuestItem returns boolean
        private delegate JassBoolean IsQuestItemCompletedPrototype(JassQuestItem whichQuestItem);
        private IsQuestItemCompletedPrototype _IsQuestItemCompleted = WarcraftIII.Jass.GetNative("IsQuestItemCompleted").ToDelegate<IsQuestItemCompletedPrototype>();
        public Boolean IsQuestItemCompleted(JassQuestItem whichQuestItem)
        {
            return _IsQuestItemCompleted(whichQuestItem);
        }

        //native CreateDefeatCondition takes nothing returns defeatcondition
        private delegate JassDefeatCondition CreateDefeatConditionPrototype();
        private CreateDefeatConditionPrototype _CreateDefeatCondition = WarcraftIII.Jass.GetNative("CreateDefeatCondition").ToDelegate<CreateDefeatConditionPrototype>();
        public JassDefeatCondition CreateDefeatCondition()
        {
            return _CreateDefeatCondition();
        }

        //native DestroyDefeatCondition takes defeatcondition whichCondition returns nothing
        private delegate void DestroyDefeatConditionPrototype(JassDefeatCondition whichCondition);
        private DestroyDefeatConditionPrototype _DestroyDefeatCondition = WarcraftIII.Jass.GetNative("DestroyDefeatCondition").ToDelegate<DestroyDefeatConditionPrototype>();
        public void DestroyDefeatCondition(JassDefeatCondition whichCondition)
        {
            _DestroyDefeatCondition(whichCondition);
        }

        //native DefeatConditionSetDescription takes defeatcondition whichCondition, string description returns nothing
        private delegate void DefeatConditionSetDescriptionPrototype(JassDefeatCondition whichCondition, JassStringArg description);
        private DefeatConditionSetDescriptionPrototype _DefeatConditionSetDescription = WarcraftIII.Jass.GetNative("DefeatConditionSetDescription").ToDelegate<DefeatConditionSetDescriptionPrototype>();
        public void DefeatConditionSetDescription(JassDefeatCondition whichCondition, String description)
        {
            _DefeatConditionSetDescription(whichCondition, description);
        }

        //native FlashQuestDialogButton takes nothing returns nothing
        private delegate void FlashQuestDialogButtonPrototype();
        private FlashQuestDialogButtonPrototype _FlashQuestDialogButton = WarcraftIII.Jass.GetNative("FlashQuestDialogButton").ToDelegate<FlashQuestDialogButtonPrototype>();
        public void FlashQuestDialogButton()
        {
            _FlashQuestDialogButton();
        }

        //native ForceQuestDialogUpdate takes nothing returns nothing
        private delegate void ForceQuestDialogUpdatePrototype();
        private ForceQuestDialogUpdatePrototype _ForceQuestDialogUpdate = WarcraftIII.Jass.GetNative("ForceQuestDialogUpdate").ToDelegate<ForceQuestDialogUpdatePrototype>();
        public void ForceQuestDialogUpdate()
        {
            _ForceQuestDialogUpdate();
        }

        //native CreateTimerDialog takes timer t returns timerdialog
        private delegate JassTimerDialog CreateTimerDialogPrototype(JassTimer t);
        private CreateTimerDialogPrototype _CreateTimerDialog = WarcraftIII.Jass.GetNative("CreateTimerDialog").ToDelegate<CreateTimerDialogPrototype>();
        public JassTimerDialog CreateTimerDialog(JassTimer t)
        {
            return _CreateTimerDialog(t);
        }

        //native DestroyTimerDialog takes timerdialog whichDialog returns nothing
        private delegate void DestroyTimerDialogPrototype(JassTimerDialog whichDialog);
        private DestroyTimerDialogPrototype _DestroyTimerDialog = WarcraftIII.Jass.GetNative("DestroyTimerDialog").ToDelegate<DestroyTimerDialogPrototype>();
        public void DestroyTimerDialog(JassTimerDialog whichDialog)
        {
            _DestroyTimerDialog(whichDialog);
        }

        //native TimerDialogSetTitle takes timerdialog whichDialog, string title returns nothing
        private delegate void TimerDialogSetTitlePrototype(JassTimerDialog whichDialog, JassStringArg title);
        private TimerDialogSetTitlePrototype _TimerDialogSetTitle = WarcraftIII.Jass.GetNative("TimerDialogSetTitle").ToDelegate<TimerDialogSetTitlePrototype>();
        public void TimerDialogSetTitle(JassTimerDialog whichDialog, String title)
        {
            _TimerDialogSetTitle(whichDialog, title);
        }

        //native TimerDialogSetTitleColor takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void TimerDialogSetTitleColorPrototype(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private TimerDialogSetTitleColorPrototype _TimerDialogSetTitleColor = WarcraftIII.Jass.GetNative("TimerDialogSetTitleColor").ToDelegate<TimerDialogSetTitleColorPrototype>();
        public void TimerDialogSetTitleColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _TimerDialogSetTitleColor(whichDialog, red, green, blue, alpha);
        }

        //native TimerDialogSetTimeColor takes timerdialog whichDialog, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void TimerDialogSetTimeColorPrototype(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private TimerDialogSetTimeColorPrototype _TimerDialogSetTimeColor = WarcraftIII.Jass.GetNative("TimerDialogSetTimeColor").ToDelegate<TimerDialogSetTimeColorPrototype>();
        public void TimerDialogSetTimeColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _TimerDialogSetTimeColor(whichDialog, red, green, blue, alpha);
        }

        //native TimerDialogSetSpeed takes timerdialog whichDialog, real speedMultFactor returns nothing
        private delegate void TimerDialogSetSpeedPrototype(JassTimerDialog whichDialog, JassRealArg speedMultFactor);
        private TimerDialogSetSpeedPrototype _TimerDialogSetSpeed = WarcraftIII.Jass.GetNative("TimerDialogSetSpeed").ToDelegate<TimerDialogSetSpeedPrototype>();
        public void TimerDialogSetSpeed(JassTimerDialog whichDialog, Single speedMultFactor)
        {
            _TimerDialogSetSpeed(whichDialog, speedMultFactor);
        }

        //native TimerDialogDisplay takes timerdialog whichDialog, boolean display returns nothing
        private delegate void TimerDialogDisplayPrototype(JassTimerDialog whichDialog, JassBoolean display);
        private TimerDialogDisplayPrototype _TimerDialogDisplay = WarcraftIII.Jass.GetNative("TimerDialogDisplay").ToDelegate<TimerDialogDisplayPrototype>();
        public void TimerDialogDisplay(JassTimerDialog whichDialog, Boolean display)
        {
            _TimerDialogDisplay(whichDialog, display);
        }

        //native IsTimerDialogDisplayed takes timerdialog whichDialog returns boolean
        private delegate JassBoolean IsTimerDialogDisplayedPrototype(JassTimerDialog whichDialog);
        private IsTimerDialogDisplayedPrototype _IsTimerDialogDisplayed = WarcraftIII.Jass.GetNative("IsTimerDialogDisplayed").ToDelegate<IsTimerDialogDisplayedPrototype>();
        public Boolean IsTimerDialogDisplayed(JassTimerDialog whichDialog)
        {
            return _IsTimerDialogDisplayed(whichDialog);
        }

        //native TimerDialogSetRealTimeRemaining takes timerdialog whichDialog, real timeRemaining returns nothing
        private delegate void TimerDialogSetRealTimeRemainingPrototype(JassTimerDialog whichDialog, JassRealArg timeRemaining);
        private TimerDialogSetRealTimeRemainingPrototype _TimerDialogSetRealTimeRemaining = WarcraftIII.Jass.GetNative("TimerDialogSetRealTimeRemaining").ToDelegate<TimerDialogSetRealTimeRemainingPrototype>();
        public void TimerDialogSetRealTimeRemaining(JassTimerDialog whichDialog, Single timeRemaining)
        {
            _TimerDialogSetRealTimeRemaining(whichDialog, timeRemaining);
        }

        //native CreateLeaderboard takes nothing returns leaderboard
        private delegate JassLeaderboard CreateLeaderboardPrototype();
        private CreateLeaderboardPrototype _CreateLeaderboard = WarcraftIII.Jass.GetNative("CreateLeaderboard").ToDelegate<CreateLeaderboardPrototype>();
        public JassLeaderboard CreateLeaderboard()
        {
            return _CreateLeaderboard();
        }

        //native DestroyLeaderboard takes leaderboard lb returns nothing
        private delegate void DestroyLeaderboardPrototype(JassLeaderboard lb);
        private DestroyLeaderboardPrototype _DestroyLeaderboard = WarcraftIII.Jass.GetNative("DestroyLeaderboard").ToDelegate<DestroyLeaderboardPrototype>();
        public void DestroyLeaderboard(JassLeaderboard lb)
        {
            _DestroyLeaderboard(lb);
        }

        //native LeaderboardDisplay takes leaderboard lb, boolean show returns nothing
        private delegate void LeaderboardDisplayPrototype(JassLeaderboard lb, JassBoolean show);
        private LeaderboardDisplayPrototype _LeaderboardDisplay = WarcraftIII.Jass.GetNative("LeaderboardDisplay").ToDelegate<LeaderboardDisplayPrototype>();
        public void LeaderboardDisplay(JassLeaderboard lb, Boolean show)
        {
            _LeaderboardDisplay(lb, show);
        }

        //native IsLeaderboardDisplayed takes leaderboard lb returns boolean
        private delegate JassBoolean IsLeaderboardDisplayedPrototype(JassLeaderboard lb);
        private IsLeaderboardDisplayedPrototype _IsLeaderboardDisplayed = WarcraftIII.Jass.GetNative("IsLeaderboardDisplayed").ToDelegate<IsLeaderboardDisplayedPrototype>();
        public Boolean IsLeaderboardDisplayed(JassLeaderboard lb)
        {
            return _IsLeaderboardDisplayed(lb);
        }

        //native LeaderboardGetItemCount takes leaderboard lb returns integer
        private delegate JassInteger LeaderboardGetItemCountPrototype(JassLeaderboard lb);
        private LeaderboardGetItemCountPrototype _LeaderboardGetItemCount = WarcraftIII.Jass.GetNative("LeaderboardGetItemCount").ToDelegate<LeaderboardGetItemCountPrototype>();
        public JassInteger LeaderboardGetItemCount(JassLeaderboard lb)
        {
            return _LeaderboardGetItemCount(lb);
        }

        //native LeaderboardSetSizeByItemCount takes leaderboard lb, integer count returns nothing
        private delegate void LeaderboardSetSizeByItemCountPrototype(JassLeaderboard lb, JassInteger count);
        private LeaderboardSetSizeByItemCountPrototype _LeaderboardSetSizeByItemCount = WarcraftIII.Jass.GetNative("LeaderboardSetSizeByItemCount").ToDelegate<LeaderboardSetSizeByItemCountPrototype>();
        public void LeaderboardSetSizeByItemCount(JassLeaderboard lb, JassInteger count)
        {
            _LeaderboardSetSizeByItemCount(lb, count);
        }

        //native LeaderboardAddItem takes leaderboard lb, string label, integer value, player p returns nothing
        private delegate void LeaderboardAddItemPrototype(JassLeaderboard lb, JassStringArg label, JassInteger value, JassPlayer p);
        private LeaderboardAddItemPrototype _LeaderboardAddItem = WarcraftIII.Jass.GetNative("LeaderboardAddItem").ToDelegate<LeaderboardAddItemPrototype>();
        public void LeaderboardAddItem(JassLeaderboard lb, String label, JassInteger value, JassPlayer p)
        {
            _LeaderboardAddItem(lb, label, value, p);
        }

        //native LeaderboardRemoveItem takes leaderboard lb, integer index returns nothing
        private delegate void LeaderboardRemoveItemPrototype(JassLeaderboard lb, JassInteger index);
        private LeaderboardRemoveItemPrototype _LeaderboardRemoveItem = WarcraftIII.Jass.GetNative("LeaderboardRemoveItem").ToDelegate<LeaderboardRemoveItemPrototype>();
        public void LeaderboardRemoveItem(JassLeaderboard lb, JassInteger index)
        {
            _LeaderboardRemoveItem(lb, index);
        }

        //native LeaderboardRemovePlayerItem takes leaderboard lb, player p returns nothing
        private delegate void LeaderboardRemovePlayerItemPrototype(JassLeaderboard lb, JassPlayer p);
        private LeaderboardRemovePlayerItemPrototype _LeaderboardRemovePlayerItem = WarcraftIII.Jass.GetNative("LeaderboardRemovePlayerItem").ToDelegate<LeaderboardRemovePlayerItemPrototype>();
        public void LeaderboardRemovePlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            _LeaderboardRemovePlayerItem(lb, p);
        }

        //native LeaderboardClear takes leaderboard lb returns nothing
        private delegate void LeaderboardClearPrototype(JassLeaderboard lb);
        private LeaderboardClearPrototype _LeaderboardClear = WarcraftIII.Jass.GetNative("LeaderboardClear").ToDelegate<LeaderboardClearPrototype>();
        public void LeaderboardClear(JassLeaderboard lb)
        {
            _LeaderboardClear(lb);
        }

        //native LeaderboardSortItemsByValue takes leaderboard lb, boolean ascending returns nothing
        private delegate void LeaderboardSortItemsByValuePrototype(JassLeaderboard lb, JassBoolean ascending);
        private LeaderboardSortItemsByValuePrototype _LeaderboardSortItemsByValue = WarcraftIII.Jass.GetNative("LeaderboardSortItemsByValue").ToDelegate<LeaderboardSortItemsByValuePrototype>();
        public void LeaderboardSortItemsByValue(JassLeaderboard lb, Boolean ascending)
        {
            _LeaderboardSortItemsByValue(lb, ascending);
        }

        //native LeaderboardSortItemsByPlayer takes leaderboard lb, boolean ascending returns nothing
        private delegate void LeaderboardSortItemsByPlayerPrototype(JassLeaderboard lb, JassBoolean ascending);
        private LeaderboardSortItemsByPlayerPrototype _LeaderboardSortItemsByPlayer = WarcraftIII.Jass.GetNative("LeaderboardSortItemsByPlayer").ToDelegate<LeaderboardSortItemsByPlayerPrototype>();
        public void LeaderboardSortItemsByPlayer(JassLeaderboard lb, Boolean ascending)
        {
            _LeaderboardSortItemsByPlayer(lb, ascending);
        }

        //native LeaderboardSortItemsByLabel takes leaderboard lb, boolean ascending returns nothing
        private delegate void LeaderboardSortItemsByLabelPrototype(JassLeaderboard lb, JassBoolean ascending);
        private LeaderboardSortItemsByLabelPrototype _LeaderboardSortItemsByLabel = WarcraftIII.Jass.GetNative("LeaderboardSortItemsByLabel").ToDelegate<LeaderboardSortItemsByLabelPrototype>();
        public void LeaderboardSortItemsByLabel(JassLeaderboard lb, Boolean ascending)
        {
            _LeaderboardSortItemsByLabel(lb, ascending);
        }

        //native LeaderboardHasPlayerItem takes leaderboard lb, player p returns boolean
        private delegate JassBoolean LeaderboardHasPlayerItemPrototype(JassLeaderboard lb, JassPlayer p);
        private LeaderboardHasPlayerItemPrototype _LeaderboardHasPlayerItem = WarcraftIII.Jass.GetNative("LeaderboardHasPlayerItem").ToDelegate<LeaderboardHasPlayerItemPrototype>();
        public Boolean LeaderboardHasPlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            return _LeaderboardHasPlayerItem(lb, p);
        }

        //native LeaderboardGetPlayerIndex takes leaderboard lb, player p returns integer
        private delegate JassInteger LeaderboardGetPlayerIndexPrototype(JassLeaderboard lb, JassPlayer p);
        private LeaderboardGetPlayerIndexPrototype _LeaderboardGetPlayerIndex = WarcraftIII.Jass.GetNative("LeaderboardGetPlayerIndex").ToDelegate<LeaderboardGetPlayerIndexPrototype>();
        public JassInteger LeaderboardGetPlayerIndex(JassLeaderboard lb, JassPlayer p)
        {
            return _LeaderboardGetPlayerIndex(lb, p);
        }

        //native LeaderboardSetLabel takes leaderboard lb, string label returns nothing
        private delegate void LeaderboardSetLabelPrototype(JassLeaderboard lb, JassStringArg label);
        private LeaderboardSetLabelPrototype _LeaderboardSetLabel = WarcraftIII.Jass.GetNative("LeaderboardSetLabel").ToDelegate<LeaderboardSetLabelPrototype>();
        public void LeaderboardSetLabel(JassLeaderboard lb, String label)
        {
            _LeaderboardSetLabel(lb, label);
        }

        //native LeaderboardGetLabelText takes leaderboard lb returns string
        private delegate JassStringRet LeaderboardGetLabelTextPrototype(JassLeaderboard lb);
        private LeaderboardGetLabelTextPrototype _LeaderboardGetLabelText = WarcraftIII.Jass.GetNative("LeaderboardGetLabelText").ToDelegate<LeaderboardGetLabelTextPrototype>();
        public String LeaderboardGetLabelText(JassLeaderboard lb)
        {
            return _LeaderboardGetLabelText(lb);
        }

        //native PlayerSetLeaderboard takes player toPlayer, leaderboard lb returns nothing
        private delegate void PlayerSetLeaderboardPrototype(JassPlayer toPlayer, JassLeaderboard lb);
        private PlayerSetLeaderboardPrototype _PlayerSetLeaderboard = WarcraftIII.Jass.GetNative("PlayerSetLeaderboard").ToDelegate<PlayerSetLeaderboardPrototype>();
        public void PlayerSetLeaderboard(JassPlayer toPlayer, JassLeaderboard lb)
        {
            _PlayerSetLeaderboard(toPlayer, lb);
        }

        //native PlayerGetLeaderboard takes player toPlayer returns leaderboard
        private delegate JassLeaderboard PlayerGetLeaderboardPrototype(JassPlayer toPlayer);
        private PlayerGetLeaderboardPrototype _PlayerGetLeaderboard = WarcraftIII.Jass.GetNative("PlayerGetLeaderboard").ToDelegate<PlayerGetLeaderboardPrototype>();
        public JassLeaderboard PlayerGetLeaderboard(JassPlayer toPlayer)
        {
            return _PlayerGetLeaderboard(toPlayer);
        }

        //native LeaderboardSetLabelColor takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void LeaderboardSetLabelColorPrototype(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private LeaderboardSetLabelColorPrototype _LeaderboardSetLabelColor = WarcraftIII.Jass.GetNative("LeaderboardSetLabelColor").ToDelegate<LeaderboardSetLabelColorPrototype>();
        public void LeaderboardSetLabelColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _LeaderboardSetLabelColor(lb, red, green, blue, alpha);
        }

        //native LeaderboardSetValueColor takes leaderboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void LeaderboardSetValueColorPrototype(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private LeaderboardSetValueColorPrototype _LeaderboardSetValueColor = WarcraftIII.Jass.GetNative("LeaderboardSetValueColor").ToDelegate<LeaderboardSetValueColorPrototype>();
        public void LeaderboardSetValueColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _LeaderboardSetValueColor(lb, red, green, blue, alpha);
        }

        //native LeaderboardSetStyle takes leaderboard lb, boolean showLabel, boolean showNames, boolean showValues, boolean showIcons returns nothing
        private delegate void LeaderboardSetStylePrototype(JassLeaderboard lb, JassBoolean showLabel, JassBoolean showNames, JassBoolean showValues, JassBoolean showIcons);
        private LeaderboardSetStylePrototype _LeaderboardSetStyle = WarcraftIII.Jass.GetNative("LeaderboardSetStyle").ToDelegate<LeaderboardSetStylePrototype>();
        public void LeaderboardSetStyle(JassLeaderboard lb, Boolean showLabel, Boolean showNames, Boolean showValues, Boolean showIcons)
        {
            _LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);
        }

        //native LeaderboardSetItemValue takes leaderboard lb, integer whichItem, integer val returns nothing
        private delegate void LeaderboardSetItemValuePrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger val);
        private LeaderboardSetItemValuePrototype _LeaderboardSetItemValue = WarcraftIII.Jass.GetNative("LeaderboardSetItemValue").ToDelegate<LeaderboardSetItemValuePrototype>();
        public void LeaderboardSetItemValue(JassLeaderboard lb, JassInteger whichItem, JassInteger val)
        {
            _LeaderboardSetItemValue(lb, whichItem, val);
        }

        //native LeaderboardSetItemLabel takes leaderboard lb, integer whichItem, string val returns nothing
        private delegate void LeaderboardSetItemLabelPrototype(JassLeaderboard lb, JassInteger whichItem, JassStringArg val);
        private LeaderboardSetItemLabelPrototype _LeaderboardSetItemLabel = WarcraftIII.Jass.GetNative("LeaderboardSetItemLabel").ToDelegate<LeaderboardSetItemLabelPrototype>();
        public void LeaderboardSetItemLabel(JassLeaderboard lb, JassInteger whichItem, String val)
        {
            _LeaderboardSetItemLabel(lb, whichItem, val);
        }

        //native LeaderboardSetItemStyle takes leaderboard lb, integer whichItem, boolean showLabel, boolean showValue, boolean showIcon returns nothing
        private delegate void LeaderboardSetItemStylePrototype(JassLeaderboard lb, JassInteger whichItem, JassBoolean showLabel, JassBoolean showValue, JassBoolean showIcon);
        private LeaderboardSetItemStylePrototype _LeaderboardSetItemStyle = WarcraftIII.Jass.GetNative("LeaderboardSetItemStyle").ToDelegate<LeaderboardSetItemStylePrototype>();
        public void LeaderboardSetItemStyle(JassLeaderboard lb, JassInteger whichItem, Boolean showLabel, Boolean showValue, Boolean showIcon)
        {
            _LeaderboardSetItemStyle(lb, whichItem, showLabel, showValue, showIcon);
        }

        //native LeaderboardSetItemLabelColor takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void LeaderboardSetItemLabelColorPrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private LeaderboardSetItemLabelColorPrototype _LeaderboardSetItemLabelColor = WarcraftIII.Jass.GetNative("LeaderboardSetItemLabelColor").ToDelegate<LeaderboardSetItemLabelColorPrototype>();
        public void LeaderboardSetItemLabelColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _LeaderboardSetItemLabelColor(lb, whichItem, red, green, blue, alpha);
        }

        //native LeaderboardSetItemValueColor takes leaderboard lb, integer whichItem, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void LeaderboardSetItemValueColorPrototype(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private LeaderboardSetItemValueColorPrototype _LeaderboardSetItemValueColor = WarcraftIII.Jass.GetNative("LeaderboardSetItemValueColor").ToDelegate<LeaderboardSetItemValueColorPrototype>();
        public void LeaderboardSetItemValueColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _LeaderboardSetItemValueColor(lb, whichItem, red, green, blue, alpha);
        }

        //native CreateMultiboard takes nothing returns multiboard
        private delegate JassMultiboard CreateMultiboardPrototype();
        private CreateMultiboardPrototype _CreateMultiboard = WarcraftIII.Jass.GetNative("CreateMultiboard").ToDelegate<CreateMultiboardPrototype>();
        public JassMultiboard CreateMultiboard()
        {
            return _CreateMultiboard();
        }

        //native DestroyMultiboard takes multiboard lb returns nothing
        private delegate void DestroyMultiboardPrototype(JassMultiboard lb);
        private DestroyMultiboardPrototype _DestroyMultiboard = WarcraftIII.Jass.GetNative("DestroyMultiboard").ToDelegate<DestroyMultiboardPrototype>();
        public void DestroyMultiboard(JassMultiboard lb)
        {
            _DestroyMultiboard(lb);
        }

        //native MultiboardDisplay takes multiboard lb, boolean show returns nothing
        private delegate void MultiboardDisplayPrototype(JassMultiboard lb, JassBoolean show);
        private MultiboardDisplayPrototype _MultiboardDisplay = WarcraftIII.Jass.GetNative("MultiboardDisplay").ToDelegate<MultiboardDisplayPrototype>();
        public void MultiboardDisplay(JassMultiboard lb, Boolean show)
        {
            _MultiboardDisplay(lb, show);
        }

        //native IsMultiboardDisplayed takes multiboard lb returns boolean
        private delegate JassBoolean IsMultiboardDisplayedPrototype(JassMultiboard lb);
        private IsMultiboardDisplayedPrototype _IsMultiboardDisplayed = WarcraftIII.Jass.GetNative("IsMultiboardDisplayed").ToDelegate<IsMultiboardDisplayedPrototype>();
        public Boolean IsMultiboardDisplayed(JassMultiboard lb)
        {
            return _IsMultiboardDisplayed(lb);
        }

        //native MultiboardMinimize takes multiboard lb, boolean minimize returns nothing
        private delegate void MultiboardMinimizePrototype(JassMultiboard lb, JassBoolean minimize);
        private MultiboardMinimizePrototype _MultiboardMinimize = WarcraftIII.Jass.GetNative("MultiboardMinimize").ToDelegate<MultiboardMinimizePrototype>();
        public void MultiboardMinimize(JassMultiboard lb, Boolean minimize)
        {
            _MultiboardMinimize(lb, minimize);
        }

        //native IsMultiboardMinimized takes multiboard lb returns boolean
        private delegate JassBoolean IsMultiboardMinimizedPrototype(JassMultiboard lb);
        private IsMultiboardMinimizedPrototype _IsMultiboardMinimized = WarcraftIII.Jass.GetNative("IsMultiboardMinimized").ToDelegate<IsMultiboardMinimizedPrototype>();
        public Boolean IsMultiboardMinimized(JassMultiboard lb)
        {
            return _IsMultiboardMinimized(lb);
        }

        //native MultiboardClear takes multiboard lb returns nothing
        private delegate void MultiboardClearPrototype(JassMultiboard lb);
        private MultiboardClearPrototype _MultiboardClear = WarcraftIII.Jass.GetNative("MultiboardClear").ToDelegate<MultiboardClearPrototype>();
        public void MultiboardClear(JassMultiboard lb)
        {
            _MultiboardClear(lb);
        }

        //native MultiboardSetTitleText takes multiboard lb, string label returns nothing
        private delegate void MultiboardSetTitleTextPrototype(JassMultiboard lb, JassStringArg label);
        private MultiboardSetTitleTextPrototype _MultiboardSetTitleText = WarcraftIII.Jass.GetNative("MultiboardSetTitleText").ToDelegate<MultiboardSetTitleTextPrototype>();
        public void MultiboardSetTitleText(JassMultiboard lb, String label)
        {
            _MultiboardSetTitleText(lb, label);
        }

        //native MultiboardGetTitleText takes multiboard lb returns string
        private delegate JassStringRet MultiboardGetTitleTextPrototype(JassMultiboard lb);
        private MultiboardGetTitleTextPrototype _MultiboardGetTitleText = WarcraftIII.Jass.GetNative("MultiboardGetTitleText").ToDelegate<MultiboardGetTitleTextPrototype>();
        public String MultiboardGetTitleText(JassMultiboard lb)
        {
            return _MultiboardGetTitleText(lb);
        }

        //native MultiboardSetTitleTextColor takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void MultiboardSetTitleTextColorPrototype(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private MultiboardSetTitleTextColorPrototype _MultiboardSetTitleTextColor = WarcraftIII.Jass.GetNative("MultiboardSetTitleTextColor").ToDelegate<MultiboardSetTitleTextColorPrototype>();
        public void MultiboardSetTitleTextColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _MultiboardSetTitleTextColor(lb, red, green, blue, alpha);
        }

        //native MultiboardGetRowCount takes multiboard lb returns integer
        private delegate JassInteger MultiboardGetRowCountPrototype(JassMultiboard lb);
        private MultiboardGetRowCountPrototype _MultiboardGetRowCount = WarcraftIII.Jass.GetNative("MultiboardGetRowCount").ToDelegate<MultiboardGetRowCountPrototype>();
        public JassInteger MultiboardGetRowCount(JassMultiboard lb)
        {
            return _MultiboardGetRowCount(lb);
        }

        //native MultiboardGetColumnCount takes multiboard lb returns integer
        private delegate JassInteger MultiboardGetColumnCountPrototype(JassMultiboard lb);
        private MultiboardGetColumnCountPrototype _MultiboardGetColumnCount = WarcraftIII.Jass.GetNative("MultiboardGetColumnCount").ToDelegate<MultiboardGetColumnCountPrototype>();
        public JassInteger MultiboardGetColumnCount(JassMultiboard lb)
        {
            return _MultiboardGetColumnCount(lb);
        }

        //native MultiboardSetColumnCount takes multiboard lb, integer count returns nothing
        private delegate void MultiboardSetColumnCountPrototype(JassMultiboard lb, JassInteger count);
        private MultiboardSetColumnCountPrototype _MultiboardSetColumnCount = WarcraftIII.Jass.GetNative("MultiboardSetColumnCount").ToDelegate<MultiboardSetColumnCountPrototype>();
        public void MultiboardSetColumnCount(JassMultiboard lb, JassInteger count)
        {
            _MultiboardSetColumnCount(lb, count);
        }

        //native MultiboardSetRowCount takes multiboard lb, integer count returns nothing
        private delegate void MultiboardSetRowCountPrototype(JassMultiboard lb, JassInteger count);
        private MultiboardSetRowCountPrototype _MultiboardSetRowCount = WarcraftIII.Jass.GetNative("MultiboardSetRowCount").ToDelegate<MultiboardSetRowCountPrototype>();
        public void MultiboardSetRowCount(JassMultiboard lb, JassInteger count)
        {
            _MultiboardSetRowCount(lb, count);
        }

        //native MultiboardSetItemsStyle takes multiboard lb, boolean showValues, boolean showIcons returns nothing
        private delegate void MultiboardSetItemsStylePrototype(JassMultiboard lb, JassBoolean showValues, JassBoolean showIcons);
        private MultiboardSetItemsStylePrototype _MultiboardSetItemsStyle = WarcraftIII.Jass.GetNative("MultiboardSetItemsStyle").ToDelegate<MultiboardSetItemsStylePrototype>();
        public void MultiboardSetItemsStyle(JassMultiboard lb, Boolean showValues, Boolean showIcons)
        {
            _MultiboardSetItemsStyle(lb, showValues, showIcons);
        }

        //native MultiboardSetItemsValue takes multiboard lb, string value returns nothing
        private delegate void MultiboardSetItemsValuePrototype(JassMultiboard lb, JassStringArg value);
        private MultiboardSetItemsValuePrototype _MultiboardSetItemsValue = WarcraftIII.Jass.GetNative("MultiboardSetItemsValue").ToDelegate<MultiboardSetItemsValuePrototype>();
        public void MultiboardSetItemsValue(JassMultiboard lb, String value)
        {
            _MultiboardSetItemsValue(lb, value);
        }

        //native MultiboardSetItemsValueColor takes multiboard lb, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void MultiboardSetItemsValueColorPrototype(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private MultiboardSetItemsValueColorPrototype _MultiboardSetItemsValueColor = WarcraftIII.Jass.GetNative("MultiboardSetItemsValueColor").ToDelegate<MultiboardSetItemsValueColorPrototype>();
        public void MultiboardSetItemsValueColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _MultiboardSetItemsValueColor(lb, red, green, blue, alpha);
        }

        //native MultiboardSetItemsWidth takes multiboard lb, real width returns nothing
        private delegate void MultiboardSetItemsWidthPrototype(JassMultiboard lb, JassRealArg width);
        private MultiboardSetItemsWidthPrototype _MultiboardSetItemsWidth = WarcraftIII.Jass.GetNative("MultiboardSetItemsWidth").ToDelegate<MultiboardSetItemsWidthPrototype>();
        public void MultiboardSetItemsWidth(JassMultiboard lb, Single width)
        {
            _MultiboardSetItemsWidth(lb, width);
        }

        //native MultiboardSetItemsIcon takes multiboard lb, string iconPath returns nothing
        private delegate void MultiboardSetItemsIconPrototype(JassMultiboard lb, JassStringArg iconPath);
        private MultiboardSetItemsIconPrototype _MultiboardSetItemsIcon = WarcraftIII.Jass.GetNative("MultiboardSetItemsIcon").ToDelegate<MultiboardSetItemsIconPrototype>();
        public void MultiboardSetItemsIcon(JassMultiboard lb, String iconPath)
        {
            _MultiboardSetItemsIcon(lb, iconPath);
        }

        //native MultiboardGetItem takes multiboard lb, integer row, integer column returns multiboarditem
        private delegate JassMultiboardItem MultiboardGetItemPrototype(JassMultiboard lb, JassInteger row, JassInteger column);
        private MultiboardGetItemPrototype _MultiboardGetItem = WarcraftIII.Jass.GetNative("MultiboardGetItem").ToDelegate<MultiboardGetItemPrototype>();
        public JassMultiboardItem MultiboardGetItem(JassMultiboard lb, JassInteger row, JassInteger column)
        {
            return _MultiboardGetItem(lb, row, column);
        }

        //native MultiboardReleaseItem takes multiboarditem mbi returns nothing
        private delegate void MultiboardReleaseItemPrototype(JassMultiboardItem mbi);
        private MultiboardReleaseItemPrototype _MultiboardReleaseItem = WarcraftIII.Jass.GetNative("MultiboardReleaseItem").ToDelegate<MultiboardReleaseItemPrototype>();
        public void MultiboardReleaseItem(JassMultiboardItem mbi)
        {
            _MultiboardReleaseItem(mbi);
        }

        //native MultiboardSetItemStyle takes multiboarditem mbi, boolean showValue, boolean showIcon returns nothing
        private delegate void MultiboardSetItemStylePrototype(JassMultiboardItem mbi, JassBoolean showValue, JassBoolean showIcon);
        private MultiboardSetItemStylePrototype _MultiboardSetItemStyle = WarcraftIII.Jass.GetNative("MultiboardSetItemStyle").ToDelegate<MultiboardSetItemStylePrototype>();
        public void MultiboardSetItemStyle(JassMultiboardItem mbi, Boolean showValue, Boolean showIcon)
        {
            _MultiboardSetItemStyle(mbi, showValue, showIcon);
        }

        //native MultiboardSetItemValue takes multiboarditem mbi, string val returns nothing
        private delegate void MultiboardSetItemValuePrototype(JassMultiboardItem mbi, JassStringArg val);
        private MultiboardSetItemValuePrototype _MultiboardSetItemValue = WarcraftIII.Jass.GetNative("MultiboardSetItemValue").ToDelegate<MultiboardSetItemValuePrototype>();
        public void MultiboardSetItemValue(JassMultiboardItem mbi, String val)
        {
            _MultiboardSetItemValue(mbi, val);
        }

        //native MultiboardSetItemValueColor takes multiboarditem mbi, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void MultiboardSetItemValueColorPrototype(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private MultiboardSetItemValueColorPrototype _MultiboardSetItemValueColor = WarcraftIII.Jass.GetNative("MultiboardSetItemValueColor").ToDelegate<MultiboardSetItemValueColorPrototype>();
        public void MultiboardSetItemValueColor(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _MultiboardSetItemValueColor(mbi, red, green, blue, alpha);
        }

        //native MultiboardSetItemWidth takes multiboarditem mbi, real width returns nothing
        private delegate void MultiboardSetItemWidthPrototype(JassMultiboardItem mbi, JassRealArg width);
        private MultiboardSetItemWidthPrototype _MultiboardSetItemWidth = WarcraftIII.Jass.GetNative("MultiboardSetItemWidth").ToDelegate<MultiboardSetItemWidthPrototype>();
        public void MultiboardSetItemWidth(JassMultiboardItem mbi, Single width)
        {
            _MultiboardSetItemWidth(mbi, width);
        }

        //native MultiboardSetItemIcon takes multiboarditem mbi, string iconFileName returns nothing
        private delegate void MultiboardSetItemIconPrototype(JassMultiboardItem mbi, JassStringArg iconFileName);
        private MultiboardSetItemIconPrototype _MultiboardSetItemIcon = WarcraftIII.Jass.GetNative("MultiboardSetItemIcon").ToDelegate<MultiboardSetItemIconPrototype>();
        public void MultiboardSetItemIcon(JassMultiboardItem mbi, String iconFileName)
        {
            _MultiboardSetItemIcon(mbi, iconFileName);
        }

        //native MultiboardSuppressDisplay takes boolean flag returns nothing
        private delegate void MultiboardSuppressDisplayPrototype(JassBoolean flag);
        private MultiboardSuppressDisplayPrototype _MultiboardSuppressDisplay = WarcraftIII.Jass.GetNative("MultiboardSuppressDisplay").ToDelegate<MultiboardSuppressDisplayPrototype>();
        public void MultiboardSuppressDisplay(Boolean flag)
        {
            _MultiboardSuppressDisplay(flag);
        }

        //native SetCameraPosition takes real x, real y returns nothing
        private delegate void SetCameraPositionPrototype(JassRealArg x, JassRealArg y);
        private SetCameraPositionPrototype _SetCameraPosition = WarcraftIII.Jass.GetNative("SetCameraPosition").ToDelegate<SetCameraPositionPrototype>();
        public void SetCameraPosition(Single x, Single y)
        {
            _SetCameraPosition(x, y);
        }

        //native SetCameraQuickPosition takes real x, real y returns nothing
        private delegate void SetCameraQuickPositionPrototype(JassRealArg x, JassRealArg y);
        private SetCameraQuickPositionPrototype _SetCameraQuickPosition = WarcraftIII.Jass.GetNative("SetCameraQuickPosition").ToDelegate<SetCameraQuickPositionPrototype>();
        public void SetCameraQuickPosition(Single x, Single y)
        {
            _SetCameraQuickPosition(x, y);
        }

        //native SetCameraBounds takes real x1, real y1, real x2, real y2, real x3, real y3, real x4, real y4 returns nothing
        private delegate void SetCameraBoundsPrototype(JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2, JassRealArg x3, JassRealArg y3, JassRealArg x4, JassRealArg y4);
        private SetCameraBoundsPrototype _SetCameraBounds = WarcraftIII.Jass.GetNative("SetCameraBounds").ToDelegate<SetCameraBoundsPrototype>();
        public void SetCameraBounds(Single x1, Single y1, Single x2, Single y2, Single x3, Single y3, Single x4, Single y4)
        {
            _SetCameraBounds(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        //native StopCamera takes nothing returns nothing
        private delegate void StopCameraPrototype();
        private StopCameraPrototype _StopCamera = WarcraftIII.Jass.GetNative("StopCamera").ToDelegate<StopCameraPrototype>();
        public void StopCamera()
        {
            _StopCamera();
        }

        //native ResetToGameCamera takes real duration returns nothing
        private delegate void ResetToGameCameraPrototype(JassRealArg duration);
        private ResetToGameCameraPrototype _ResetToGameCamera = WarcraftIII.Jass.GetNative("ResetToGameCamera").ToDelegate<ResetToGameCameraPrototype>();
        public void ResetToGameCamera(Single duration)
        {
            _ResetToGameCamera(duration);
        }

        //native PanCameraTo takes real x, real y returns nothing
        private delegate void PanCameraToPrototype(JassRealArg x, JassRealArg y);
        private PanCameraToPrototype _PanCameraTo = WarcraftIII.Jass.GetNative("PanCameraTo").ToDelegate<PanCameraToPrototype>();
        public void PanCameraTo(Single x, Single y)
        {
            _PanCameraTo(x, y);
        }

        //native PanCameraToTimed takes real x, real y, real duration returns nothing
        private delegate void PanCameraToTimedPrototype(JassRealArg x, JassRealArg y, JassRealArg duration);
        private PanCameraToTimedPrototype _PanCameraToTimed = WarcraftIII.Jass.GetNative("PanCameraToTimed").ToDelegate<PanCameraToTimedPrototype>();
        public void PanCameraToTimed(Single x, Single y, Single duration)
        {
            _PanCameraToTimed(x, y, duration);
        }

        //native PanCameraToWithZ takes real x, real y, real zOffsetDest returns nothing
        private delegate void PanCameraToWithZPrototype(JassRealArg x, JassRealArg y, JassRealArg zOffsetDest);
        private PanCameraToWithZPrototype _PanCameraToWithZ = WarcraftIII.Jass.GetNative("PanCameraToWithZ").ToDelegate<PanCameraToWithZPrototype>();
        public void PanCameraToWithZ(Single x, Single y, Single zOffsetDest)
        {
            _PanCameraToWithZ(x, y, zOffsetDest);
        }

        //native PanCameraToTimedWithZ takes real x, real y, real zOffsetDest, real duration returns nothing
        private delegate void PanCameraToTimedWithZPrototype(JassRealArg x, JassRealArg y, JassRealArg zOffsetDest, JassRealArg duration);
        private PanCameraToTimedWithZPrototype _PanCameraToTimedWithZ = WarcraftIII.Jass.GetNative("PanCameraToTimedWithZ").ToDelegate<PanCameraToTimedWithZPrototype>();
        public void PanCameraToTimedWithZ(Single x, Single y, Single zOffsetDest, Single duration)
        {
            _PanCameraToTimedWithZ(x, y, zOffsetDest, duration);
        }

        //native SetCinematicCamera takes string cameraModelFile returns nothing
        private delegate void SetCinematicCameraPrototype(JassStringArg cameraModelFile);
        private SetCinematicCameraPrototype _SetCinematicCamera = WarcraftIII.Jass.GetNative("SetCinematicCamera").ToDelegate<SetCinematicCameraPrototype>();
        public void SetCinematicCamera(String cameraModelFile)
        {
            _SetCinematicCamera(cameraModelFile);
        }

        //native SetCameraRotateMode takes real x, real y, real radiansToSweep, real duration returns nothing
        private delegate void SetCameraRotateModePrototype(JassRealArg x, JassRealArg y, JassRealArg radiansToSweep, JassRealArg duration);
        private SetCameraRotateModePrototype _SetCameraRotateMode = WarcraftIII.Jass.GetNative("SetCameraRotateMode").ToDelegate<SetCameraRotateModePrototype>();
        public void SetCameraRotateMode(Single x, Single y, Single radiansToSweep, Single duration)
        {
            _SetCameraRotateMode(x, y, radiansToSweep, duration);
        }

        //native SetCameraField takes camerafield whichField, real value, real duration returns nothing
        private delegate void SetCameraFieldPrototype(JassCameraField whichField, JassRealArg value, JassRealArg duration);
        private SetCameraFieldPrototype _SetCameraField = WarcraftIII.Jass.GetNative("SetCameraField").ToDelegate<SetCameraFieldPrototype>();
        public void SetCameraField(JassCameraField whichField, Single value, Single duration)
        {
            _SetCameraField(whichField, value, duration);
        }

        //native AdjustCameraField takes camerafield whichField, real offset, real duration returns nothing
        private delegate void AdjustCameraFieldPrototype(JassCameraField whichField, JassRealArg offset, JassRealArg duration);
        private AdjustCameraFieldPrototype _AdjustCameraField = WarcraftIII.Jass.GetNative("AdjustCameraField").ToDelegate<AdjustCameraFieldPrototype>();
        public void AdjustCameraField(JassCameraField whichField, Single offset, Single duration)
        {
            _AdjustCameraField(whichField, offset, duration);
        }

        //native SetCameraTargetController takes unit whichUnit, real xoffset, real yoffset, boolean inheritOrientation returns nothing
        private delegate void SetCameraTargetControllerPrototype(JassUnit whichUnit, JassRealArg xoffset, JassRealArg yoffset, JassBoolean inheritOrientation);
        private SetCameraTargetControllerPrototype _SetCameraTargetController = WarcraftIII.Jass.GetNative("SetCameraTargetController").ToDelegate<SetCameraTargetControllerPrototype>();
        public void SetCameraTargetController(JassUnit whichUnit, Single xoffset, Single yoffset, Boolean inheritOrientation)
        {
            _SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);
        }

        //native SetCameraOrientController takes unit whichUnit, real xoffset, real yoffset returns nothing
        private delegate void SetCameraOrientControllerPrototype(JassUnit whichUnit, JassRealArg xoffset, JassRealArg yoffset);
        private SetCameraOrientControllerPrototype _SetCameraOrientController = WarcraftIII.Jass.GetNative("SetCameraOrientController").ToDelegate<SetCameraOrientControllerPrototype>();
        public void SetCameraOrientController(JassUnit whichUnit, Single xoffset, Single yoffset)
        {
            _SetCameraOrientController(whichUnit, xoffset, yoffset);
        }

        //native CreateCameraSetup takes nothing returns camerasetup
        private delegate JassCameraSetup CreateCameraSetupPrototype();
        private CreateCameraSetupPrototype _CreateCameraSetup = WarcraftIII.Jass.GetNative("CreateCameraSetup").ToDelegate<CreateCameraSetupPrototype>();
        public JassCameraSetup CreateCameraSetup()
        {
            return _CreateCameraSetup();
        }

        //native CameraSetupSetField takes camerasetup whichSetup, camerafield whichField, real value, real duration returns nothing
        private delegate void CameraSetupSetFieldPrototype(JassCameraSetup whichSetup, JassCameraField whichField, JassRealArg value, JassRealArg duration);
        private CameraSetupSetFieldPrototype _CameraSetupSetField = WarcraftIII.Jass.GetNative("CameraSetupSetField").ToDelegate<CameraSetupSetFieldPrototype>();
        public void CameraSetupSetField(JassCameraSetup whichSetup, JassCameraField whichField, Single value, Single duration)
        {
            _CameraSetupSetField(whichSetup, whichField, value, duration);
        }

        //native CameraSetupGetField takes camerasetup whichSetup, camerafield whichField returns real
        private delegate JassRealRet CameraSetupGetFieldPrototype(JassCameraSetup whichSetup, JassCameraField whichField);
        private CameraSetupGetFieldPrototype _CameraSetupGetField = WarcraftIII.Jass.GetNative("CameraSetupGetField").ToDelegate<CameraSetupGetFieldPrototype>();
        public Single CameraSetupGetField(JassCameraSetup whichSetup, JassCameraField whichField)
        {
            return _CameraSetupGetField(whichSetup, whichField);
        }

        //native CameraSetupSetDestPosition takes camerasetup whichSetup, real x, real y, real duration returns nothing
        private delegate void CameraSetupSetDestPositionPrototype(JassCameraSetup whichSetup, JassRealArg x, JassRealArg y, JassRealArg duration);
        private CameraSetupSetDestPositionPrototype _CameraSetupSetDestPosition = WarcraftIII.Jass.GetNative("CameraSetupSetDestPosition").ToDelegate<CameraSetupSetDestPositionPrototype>();
        public void CameraSetupSetDestPosition(JassCameraSetup whichSetup, Single x, Single y, Single duration)
        {
            _CameraSetupSetDestPosition(whichSetup, x, y, duration);
        }

        //native CameraSetupGetDestPositionLoc takes camerasetup whichSetup returns location
        private delegate JassLocation CameraSetupGetDestPositionLocPrototype(JassCameraSetup whichSetup);
        private CameraSetupGetDestPositionLocPrototype _CameraSetupGetDestPositionLoc = WarcraftIII.Jass.GetNative("CameraSetupGetDestPositionLoc").ToDelegate<CameraSetupGetDestPositionLocPrototype>();
        public JassLocation CameraSetupGetDestPositionLoc(JassCameraSetup whichSetup)
        {
            return _CameraSetupGetDestPositionLoc(whichSetup);
        }

        //native CameraSetupGetDestPositionX takes camerasetup whichSetup returns real
        private delegate JassRealRet CameraSetupGetDestPositionXPrototype(JassCameraSetup whichSetup);
        private CameraSetupGetDestPositionXPrototype _CameraSetupGetDestPositionX = WarcraftIII.Jass.GetNative("CameraSetupGetDestPositionX").ToDelegate<CameraSetupGetDestPositionXPrototype>();
        public Single CameraSetupGetDestPositionX(JassCameraSetup whichSetup)
        {
            return _CameraSetupGetDestPositionX(whichSetup);
        }

        //native CameraSetupGetDestPositionY takes camerasetup whichSetup returns real
        private delegate JassRealRet CameraSetupGetDestPositionYPrototype(JassCameraSetup whichSetup);
        private CameraSetupGetDestPositionYPrototype _CameraSetupGetDestPositionY = WarcraftIII.Jass.GetNative("CameraSetupGetDestPositionY").ToDelegate<CameraSetupGetDestPositionYPrototype>();
        public Single CameraSetupGetDestPositionY(JassCameraSetup whichSetup)
        {
            return _CameraSetupGetDestPositionY(whichSetup);
        }

        //native CameraSetupApply takes camerasetup whichSetup, boolean doPan, boolean panTimed returns nothing
        private delegate void CameraSetupApplyPrototype(JassCameraSetup whichSetup, JassBoolean doPan, JassBoolean panTimed);
        private CameraSetupApplyPrototype _CameraSetupApply = WarcraftIII.Jass.GetNative("CameraSetupApply").ToDelegate<CameraSetupApplyPrototype>();
        public void CameraSetupApply(JassCameraSetup whichSetup, Boolean doPan, Boolean panTimed)
        {
            _CameraSetupApply(whichSetup, doPan, panTimed);
        }

        //native CameraSetupApplyWithZ takes camerasetup whichSetup, real zDestOffset returns nothing
        private delegate void CameraSetupApplyWithZPrototype(JassCameraSetup whichSetup, JassRealArg zDestOffset);
        private CameraSetupApplyWithZPrototype _CameraSetupApplyWithZ = WarcraftIII.Jass.GetNative("CameraSetupApplyWithZ").ToDelegate<CameraSetupApplyWithZPrototype>();
        public void CameraSetupApplyWithZ(JassCameraSetup whichSetup, Single zDestOffset)
        {
            _CameraSetupApplyWithZ(whichSetup, zDestOffset);
        }

        //native CameraSetupApplyForceDuration takes camerasetup whichSetup, boolean doPan, real forceDuration returns nothing
        private delegate void CameraSetupApplyForceDurationPrototype(JassCameraSetup whichSetup, JassBoolean doPan, JassRealArg forceDuration);
        private CameraSetupApplyForceDurationPrototype _CameraSetupApplyForceDuration = WarcraftIII.Jass.GetNative("CameraSetupApplyForceDuration").ToDelegate<CameraSetupApplyForceDurationPrototype>();
        public void CameraSetupApplyForceDuration(JassCameraSetup whichSetup, Boolean doPan, Single forceDuration)
        {
            _CameraSetupApplyForceDuration(whichSetup, doPan, forceDuration);
        }

        //native CameraSetupApplyForceDurationWithZ takes camerasetup whichSetup, real zDestOffset, real forceDuration returns nothing
        private delegate void CameraSetupApplyForceDurationWithZPrototype(JassCameraSetup whichSetup, JassRealArg zDestOffset, JassRealArg forceDuration);
        private CameraSetupApplyForceDurationWithZPrototype _CameraSetupApplyForceDurationWithZ = WarcraftIII.Jass.GetNative("CameraSetupApplyForceDurationWithZ").ToDelegate<CameraSetupApplyForceDurationWithZPrototype>();
        public void CameraSetupApplyForceDurationWithZ(JassCameraSetup whichSetup, Single zDestOffset, Single forceDuration)
        {
            _CameraSetupApplyForceDurationWithZ(whichSetup, zDestOffset, forceDuration);
        }

        //native CameraSetTargetNoise takes real mag, real velocity returns nothing
        private delegate void CameraSetTargetNoisePrototype(JassRealArg mag, JassRealArg velocity);
        private CameraSetTargetNoisePrototype _CameraSetTargetNoise = WarcraftIII.Jass.GetNative("CameraSetTargetNoise").ToDelegate<CameraSetTargetNoisePrototype>();
        public void CameraSetTargetNoise(Single mag, Single velocity)
        {
            _CameraSetTargetNoise(mag, velocity);
        }

        //native CameraSetSourceNoise takes real mag, real velocity returns nothing
        private delegate void CameraSetSourceNoisePrototype(JassRealArg mag, JassRealArg velocity);
        private CameraSetSourceNoisePrototype _CameraSetSourceNoise = WarcraftIII.Jass.GetNative("CameraSetSourceNoise").ToDelegate<CameraSetSourceNoisePrototype>();
        public void CameraSetSourceNoise(Single mag, Single velocity)
        {
            _CameraSetSourceNoise(mag, velocity);
        }

        //native CameraSetTargetNoiseEx takes real mag, real velocity, boolean vertOnly returns nothing
        private delegate void CameraSetTargetNoiseExPrototype(JassRealArg mag, JassRealArg velocity, JassBoolean vertOnly);
        private CameraSetTargetNoiseExPrototype _CameraSetTargetNoiseEx = WarcraftIII.Jass.GetNative("CameraSetTargetNoiseEx").ToDelegate<CameraSetTargetNoiseExPrototype>();
        public void CameraSetTargetNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            _CameraSetTargetNoiseEx(mag, velocity, vertOnly);
        }

        //native CameraSetSourceNoiseEx takes real mag, real velocity, boolean vertOnly returns nothing
        private delegate void CameraSetSourceNoiseExPrototype(JassRealArg mag, JassRealArg velocity, JassBoolean vertOnly);
        private CameraSetSourceNoiseExPrototype _CameraSetSourceNoiseEx = WarcraftIII.Jass.GetNative("CameraSetSourceNoiseEx").ToDelegate<CameraSetSourceNoiseExPrototype>();
        public void CameraSetSourceNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            _CameraSetSourceNoiseEx(mag, velocity, vertOnly);
        }

        //native CameraSetSmoothingFactor takes real factor returns nothing
        private delegate void CameraSetSmoothingFactorPrototype(JassRealArg factor);
        private CameraSetSmoothingFactorPrototype _CameraSetSmoothingFactor = WarcraftIII.Jass.GetNative("CameraSetSmoothingFactor").ToDelegate<CameraSetSmoothingFactorPrototype>();
        public void CameraSetSmoothingFactor(Single factor)
        {
            _CameraSetSmoothingFactor(factor);
        }

        //native SetCineFilterTexture takes string filename returns nothing
        private delegate void SetCineFilterTexturePrototype(JassStringArg filename);
        private SetCineFilterTexturePrototype _SetCineFilterTexture = WarcraftIII.Jass.GetNative("SetCineFilterTexture").ToDelegate<SetCineFilterTexturePrototype>();
        public void SetCineFilterTexture(String filename)
        {
            _SetCineFilterTexture(filename);
        }

        //native SetCineFilterBlendMode takes blendmode whichMode returns nothing
        private delegate void SetCineFilterBlendModePrototype(JassBlendMode whichMode);
        private SetCineFilterBlendModePrototype _SetCineFilterBlendMode = WarcraftIII.Jass.GetNative("SetCineFilterBlendMode").ToDelegate<SetCineFilterBlendModePrototype>();
        public void SetCineFilterBlendMode(JassBlendMode whichMode)
        {
            _SetCineFilterBlendMode(whichMode);
        }

        //native SetCineFilterTexMapFlags takes texmapflags whichFlags returns nothing
        private delegate void SetCineFilterTexMapFlagsPrototype(JassTextureMapFlags whichFlags);
        private SetCineFilterTexMapFlagsPrototype _SetCineFilterTexMapFlags = WarcraftIII.Jass.GetNative("SetCineFilterTexMapFlags").ToDelegate<SetCineFilterTexMapFlagsPrototype>();
        public void SetCineFilterTexMapFlags(JassTextureMapFlags whichFlags)
        {
            _SetCineFilterTexMapFlags(whichFlags);
        }

        //native SetCineFilterStartUV takes real minu, real minv, real maxu, real maxv returns nothing
        private delegate void SetCineFilterStartUVPrototype(JassRealArg minu, JassRealArg minv, JassRealArg maxu, JassRealArg maxv);
        private SetCineFilterStartUVPrototype _SetCineFilterStartUV = WarcraftIII.Jass.GetNative("SetCineFilterStartUV").ToDelegate<SetCineFilterStartUVPrototype>();
        public void SetCineFilterStartUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            _SetCineFilterStartUV(minu, minv, maxu, maxv);
        }

        //native SetCineFilterEndUV takes real minu, real minv, real maxu, real maxv returns nothing
        private delegate void SetCineFilterEndUVPrototype(JassRealArg minu, JassRealArg minv, JassRealArg maxu, JassRealArg maxv);
        private SetCineFilterEndUVPrototype _SetCineFilterEndUV = WarcraftIII.Jass.GetNative("SetCineFilterEndUV").ToDelegate<SetCineFilterEndUVPrototype>();
        public void SetCineFilterEndUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            _SetCineFilterEndUV(minu, minv, maxu, maxv);
        }

        //native SetCineFilterStartColor takes integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void SetCineFilterStartColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private SetCineFilterStartColorPrototype _SetCineFilterStartColor = WarcraftIII.Jass.GetNative("SetCineFilterStartColor").ToDelegate<SetCineFilterStartColorPrototype>();
        public void SetCineFilterStartColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _SetCineFilterStartColor(red, green, blue, alpha);
        }

        //native SetCineFilterEndColor takes integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void SetCineFilterEndColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private SetCineFilterEndColorPrototype _SetCineFilterEndColor = WarcraftIII.Jass.GetNative("SetCineFilterEndColor").ToDelegate<SetCineFilterEndColorPrototype>();
        public void SetCineFilterEndColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _SetCineFilterEndColor(red, green, blue, alpha);
        }

        //native SetCineFilterDuration takes real duration returns nothing
        private delegate void SetCineFilterDurationPrototype(JassRealArg duration);
        private SetCineFilterDurationPrototype _SetCineFilterDuration = WarcraftIII.Jass.GetNative("SetCineFilterDuration").ToDelegate<SetCineFilterDurationPrototype>();
        public void SetCineFilterDuration(Single duration)
        {
            _SetCineFilterDuration(duration);
        }

        //native DisplayCineFilter takes boolean flag returns nothing
        private delegate void DisplayCineFilterPrototype(JassBoolean flag);
        private DisplayCineFilterPrototype _DisplayCineFilter = WarcraftIII.Jass.GetNative("DisplayCineFilter").ToDelegate<DisplayCineFilterPrototype>();
        public void DisplayCineFilter(Boolean flag)
        {
            _DisplayCineFilter(flag);
        }

        //native IsCineFilterDisplayed takes nothing returns boolean
        private delegate JassBoolean IsCineFilterDisplayedPrototype();
        private IsCineFilterDisplayedPrototype _IsCineFilterDisplayed = WarcraftIII.Jass.GetNative("IsCineFilterDisplayed").ToDelegate<IsCineFilterDisplayedPrototype>();
        public Boolean IsCineFilterDisplayed()
        {
            return _IsCineFilterDisplayed();
        }

        //native SetCinematicScene takes integer portraitUnitId, playercolor color, string speakerTitle, string text, real sceneDuration, real voiceoverDuration returns nothing
        private delegate void SetCinematicScenePrototype(JassInteger portraitUnitId, JassPlayerColor color, JassStringArg speakerTitle, JassStringArg text, JassRealArg sceneDuration, JassRealArg voiceoverDuration);
        private SetCinematicScenePrototype _SetCinematicScene = WarcraftIII.Jass.GetNative("SetCinematicScene").ToDelegate<SetCinematicScenePrototype>();
        public void SetCinematicScene(JassInteger portraitUnitId, JassPlayerColor color, String speakerTitle, String text, Single sceneDuration, Single voiceoverDuration)
        {
            _SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);
        }

        //native EndCinematicScene takes nothing returns nothing
        private delegate void EndCinematicScenePrototype();
        private EndCinematicScenePrototype _EndCinematicScene = WarcraftIII.Jass.GetNative("EndCinematicScene").ToDelegate<EndCinematicScenePrototype>();
        public void EndCinematicScene()
        {
            _EndCinematicScene();
        }

        //native ForceCinematicSubtitles takes boolean flag returns nothing
        private delegate void ForceCinematicSubtitlesPrototype(JassBoolean flag);
        private ForceCinematicSubtitlesPrototype _ForceCinematicSubtitles = WarcraftIII.Jass.GetNative("ForceCinematicSubtitles").ToDelegate<ForceCinematicSubtitlesPrototype>();
        public void ForceCinematicSubtitles(Boolean flag)
        {
            _ForceCinematicSubtitles(flag);
        }

        //native GetCameraMargin takes integer whichMargin returns real
        private delegate JassRealRet GetCameraMarginPrototype(JassInteger whichMargin);
        private GetCameraMarginPrototype _GetCameraMargin = WarcraftIII.Jass.GetNative("GetCameraMargin").ToDelegate<GetCameraMarginPrototype>();
        public Single GetCameraMargin(JassInteger whichMargin)
        {
            return _GetCameraMargin(whichMargin);
        }

        //native GetCameraBoundMinX takes nothing returns real
        private delegate JassRealRet GetCameraBoundMinXPrototype();
        private GetCameraBoundMinXPrototype _GetCameraBoundMinX = WarcraftIII.Jass.GetNative("GetCameraBoundMinX").ToDelegate<GetCameraBoundMinXPrototype>();
        public Single GetCameraBoundMinX()
        {
            return _GetCameraBoundMinX();
        }

        //native GetCameraBoundMinY takes nothing returns real
        private delegate JassRealRet GetCameraBoundMinYPrototype();
        private GetCameraBoundMinYPrototype _GetCameraBoundMinY = WarcraftIII.Jass.GetNative("GetCameraBoundMinY").ToDelegate<GetCameraBoundMinYPrototype>();
        public Single GetCameraBoundMinY()
        {
            return _GetCameraBoundMinY();
        }

        //native GetCameraBoundMaxX takes nothing returns real
        private delegate JassRealRet GetCameraBoundMaxXPrototype();
        private GetCameraBoundMaxXPrototype _GetCameraBoundMaxX = WarcraftIII.Jass.GetNative("GetCameraBoundMaxX").ToDelegate<GetCameraBoundMaxXPrototype>();
        public Single GetCameraBoundMaxX()
        {
            return _GetCameraBoundMaxX();
        }

        //native GetCameraBoundMaxY takes nothing returns real
        private delegate JassRealRet GetCameraBoundMaxYPrototype();
        private GetCameraBoundMaxYPrototype _GetCameraBoundMaxY = WarcraftIII.Jass.GetNative("GetCameraBoundMaxY").ToDelegate<GetCameraBoundMaxYPrototype>();
        public Single GetCameraBoundMaxY()
        {
            return _GetCameraBoundMaxY();
        }

        //native GetCameraField takes camerafield whichField returns real
        private delegate JassRealRet GetCameraFieldPrototype(JassCameraField whichField);
        private GetCameraFieldPrototype _GetCameraField = WarcraftIII.Jass.GetNative("GetCameraField").ToDelegate<GetCameraFieldPrototype>();
        public Single GetCameraField(JassCameraField whichField)
        {
            return _GetCameraField(whichField);
        }

        //native GetCameraTargetPositionX takes nothing returns real
        private delegate JassRealRet GetCameraTargetPositionXPrototype();
        private GetCameraTargetPositionXPrototype _GetCameraTargetPositionX = WarcraftIII.Jass.GetNative("GetCameraTargetPositionX").ToDelegate<GetCameraTargetPositionXPrototype>();
        public Single GetCameraTargetPositionX()
        {
            return _GetCameraTargetPositionX();
        }

        //native GetCameraTargetPositionY takes nothing returns real
        private delegate JassRealRet GetCameraTargetPositionYPrototype();
        private GetCameraTargetPositionYPrototype _GetCameraTargetPositionY = WarcraftIII.Jass.GetNative("GetCameraTargetPositionY").ToDelegate<GetCameraTargetPositionYPrototype>();
        public Single GetCameraTargetPositionY()
        {
            return _GetCameraTargetPositionY();
        }

        //native GetCameraTargetPositionZ takes nothing returns real
        private delegate JassRealRet GetCameraTargetPositionZPrototype();
        private GetCameraTargetPositionZPrototype _GetCameraTargetPositionZ = WarcraftIII.Jass.GetNative("GetCameraTargetPositionZ").ToDelegate<GetCameraTargetPositionZPrototype>();
        public Single GetCameraTargetPositionZ()
        {
            return _GetCameraTargetPositionZ();
        }

        //native GetCameraTargetPositionLoc takes nothing returns location
        private delegate JassLocation GetCameraTargetPositionLocPrototype();
        private GetCameraTargetPositionLocPrototype _GetCameraTargetPositionLoc = WarcraftIII.Jass.GetNative("GetCameraTargetPositionLoc").ToDelegate<GetCameraTargetPositionLocPrototype>();
        public JassLocation GetCameraTargetPositionLoc()
        {
            return _GetCameraTargetPositionLoc();
        }

        //native GetCameraEyePositionX takes nothing returns real
        private delegate JassRealRet GetCameraEyePositionXPrototype();
        private GetCameraEyePositionXPrototype _GetCameraEyePositionX = WarcraftIII.Jass.GetNative("GetCameraEyePositionX").ToDelegate<GetCameraEyePositionXPrototype>();
        public Single GetCameraEyePositionX()
        {
            return _GetCameraEyePositionX();
        }

        //native GetCameraEyePositionY takes nothing returns real
        private delegate JassRealRet GetCameraEyePositionYPrototype();
        private GetCameraEyePositionYPrototype _GetCameraEyePositionY = WarcraftIII.Jass.GetNative("GetCameraEyePositionY").ToDelegate<GetCameraEyePositionYPrototype>();
        public Single GetCameraEyePositionY()
        {
            return _GetCameraEyePositionY();
        }

        //native GetCameraEyePositionZ takes nothing returns real
        private delegate JassRealRet GetCameraEyePositionZPrototype();
        private GetCameraEyePositionZPrototype _GetCameraEyePositionZ = WarcraftIII.Jass.GetNative("GetCameraEyePositionZ").ToDelegate<GetCameraEyePositionZPrototype>();
        public Single GetCameraEyePositionZ()
        {
            return _GetCameraEyePositionZ();
        }

        //native GetCameraEyePositionLoc takes nothing returns location
        private delegate JassLocation GetCameraEyePositionLocPrototype();
        private GetCameraEyePositionLocPrototype _GetCameraEyePositionLoc = WarcraftIII.Jass.GetNative("GetCameraEyePositionLoc").ToDelegate<GetCameraEyePositionLocPrototype>();
        public JassLocation GetCameraEyePositionLoc()
        {
            return _GetCameraEyePositionLoc();
        }

        //native NewSoundEnvironment takes string environmentName returns nothing
        private delegate void NewSoundEnvironmentPrototype(JassStringArg environmentName);
        private NewSoundEnvironmentPrototype _NewSoundEnvironment = WarcraftIII.Jass.GetNative("NewSoundEnvironment").ToDelegate<NewSoundEnvironmentPrototype>();
        public void NewSoundEnvironment(String environmentName)
        {
            _NewSoundEnvironment(environmentName);
        }

        //native CreateSound takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string eaxSetting returns sound
        private delegate JassSound CreateSoundPrototype(JassStringArg fileName, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, JassStringArg eaxSetting);
        private CreateSoundPrototype _CreateSound = WarcraftIII.Jass.GetNative("CreateSound").ToDelegate<CreateSoundPrototype>();
        public JassSound CreateSound(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String eaxSetting)
        {
            return _CreateSound(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, eaxSetting);
        }

        //native CreateSoundFilenameWithLabel takes string fileName, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate, string SLKEntryName returns sound
        private delegate JassSound CreateSoundFilenameWithLabelPrototype(JassStringArg fileName, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, JassStringArg SLKEntryName);
        private CreateSoundFilenameWithLabelPrototype _CreateSoundFilenameWithLabel = WarcraftIII.Jass.GetNative("CreateSoundFilenameWithLabel").ToDelegate<CreateSoundFilenameWithLabelPrototype>();
        public JassSound CreateSoundFilenameWithLabel(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String SLKEntryName)
        {
            return _CreateSoundFilenameWithLabel(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, SLKEntryName);
        }

        //native CreateSoundFromLabel takes string soundLabel, boolean looping, boolean is3D, boolean stopwhenoutofrange, integer fadeInRate, integer fadeOutRate returns sound
        private delegate JassSound CreateSoundFromLabelPrototype(JassStringArg soundLabel, JassBoolean looping, JassBoolean is3D, JassBoolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate);
        private CreateSoundFromLabelPrototype _CreateSoundFromLabel = WarcraftIII.Jass.GetNative("CreateSoundFromLabel").ToDelegate<CreateSoundFromLabelPrototype>();
        public JassSound CreateSoundFromLabel(String soundLabel, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return _CreateSoundFromLabel(soundLabel, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate);
        }

        //native CreateMIDISound takes string soundLabel, integer fadeInRate, integer fadeOutRate returns sound
        private delegate JassSound CreateMIDISoundPrototype(JassStringArg soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate);
        private CreateMIDISoundPrototype _CreateMIDISound = WarcraftIII.Jass.GetNative("CreateMIDISound").ToDelegate<CreateMIDISoundPrototype>();
        public JassSound CreateMIDISound(String soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return _CreateMIDISound(soundLabel, fadeInRate, fadeOutRate);
        }

        //native SetSoundParamsFromLabel takes sound soundHandle, string soundLabel returns nothing
        private delegate void SetSoundParamsFromLabelPrototype(JassSound soundHandle, JassStringArg soundLabel);
        private SetSoundParamsFromLabelPrototype _SetSoundParamsFromLabel = WarcraftIII.Jass.GetNative("SetSoundParamsFromLabel").ToDelegate<SetSoundParamsFromLabelPrototype>();
        public void SetSoundParamsFromLabel(JassSound soundHandle, String soundLabel)
        {
            _SetSoundParamsFromLabel(soundHandle, soundLabel);
        }

        //native SetSoundDistanceCutoff takes sound soundHandle, real cutoff returns nothing
        private delegate void SetSoundDistanceCutoffPrototype(JassSound soundHandle, JassRealArg cutoff);
        private SetSoundDistanceCutoffPrototype _SetSoundDistanceCutoff = WarcraftIII.Jass.GetNative("SetSoundDistanceCutoff").ToDelegate<SetSoundDistanceCutoffPrototype>();
        public void SetSoundDistanceCutoff(JassSound soundHandle, Single cutoff)
        {
            _SetSoundDistanceCutoff(soundHandle, cutoff);
        }

        //native SetSoundChannel takes sound soundHandle, integer channel returns nothing
        private delegate void SetSoundChannelPrototype(JassSound soundHandle, JassInteger channel);
        private SetSoundChannelPrototype _SetSoundChannel = WarcraftIII.Jass.GetNative("SetSoundChannel").ToDelegate<SetSoundChannelPrototype>();
        public void SetSoundChannel(JassSound soundHandle, JassInteger channel)
        {
            _SetSoundChannel(soundHandle, channel);
        }

        //native SetSoundVolume takes sound soundHandle, integer volume returns nothing
        private delegate void SetSoundVolumePrototype(JassSound soundHandle, JassInteger volume);
        private SetSoundVolumePrototype _SetSoundVolume = WarcraftIII.Jass.GetNative("SetSoundVolume").ToDelegate<SetSoundVolumePrototype>();
        public void SetSoundVolume(JassSound soundHandle, JassInteger volume)
        {
            _SetSoundVolume(soundHandle, volume);
        }

        //native SetSoundPitch takes sound soundHandle, real pitch returns nothing
        private delegate void SetSoundPitchPrototype(JassSound soundHandle, JassRealArg pitch);
        private SetSoundPitchPrototype _SetSoundPitch = WarcraftIII.Jass.GetNative("SetSoundPitch").ToDelegate<SetSoundPitchPrototype>();
        public void SetSoundPitch(JassSound soundHandle, Single pitch)
        {
            _SetSoundPitch(soundHandle, pitch);
        }

        //native SetSoundPlayPosition takes sound soundHandle, integer millisecs returns nothing
        private delegate void SetSoundPlayPositionPrototype(JassSound soundHandle, JassInteger millisecs);
        private SetSoundPlayPositionPrototype _SetSoundPlayPosition = WarcraftIII.Jass.GetNative("SetSoundPlayPosition").ToDelegate<SetSoundPlayPositionPrototype>();
        public void SetSoundPlayPosition(JassSound soundHandle, JassInteger millisecs)
        {
            _SetSoundPlayPosition(soundHandle, millisecs);
        }

        //native SetSoundDistances takes sound soundHandle, real minDist, real maxDist returns nothing
        private delegate void SetSoundDistancesPrototype(JassSound soundHandle, JassRealArg minDist, JassRealArg maxDist);
        private SetSoundDistancesPrototype _SetSoundDistances = WarcraftIII.Jass.GetNative("SetSoundDistances").ToDelegate<SetSoundDistancesPrototype>();
        public void SetSoundDistances(JassSound soundHandle, Single minDist, Single maxDist)
        {
            _SetSoundDistances(soundHandle, minDist, maxDist);
        }

        //native SetSoundConeAngles takes sound soundHandle, real inside, real outside, integer outsideVolume returns nothing
        private delegate void SetSoundConeAnglesPrototype(JassSound soundHandle, JassRealArg inside, JassRealArg outside, JassInteger outsideVolume);
        private SetSoundConeAnglesPrototype _SetSoundConeAngles = WarcraftIII.Jass.GetNative("SetSoundConeAngles").ToDelegate<SetSoundConeAnglesPrototype>();
        public void SetSoundConeAngles(JassSound soundHandle, Single inside, Single outside, JassInteger outsideVolume)
        {
            _SetSoundConeAngles(soundHandle, inside, outside, outsideVolume);
        }

        //native SetSoundConeOrientation takes sound soundHandle, real x, real y, real z returns nothing
        private delegate void SetSoundConeOrientationPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private SetSoundConeOrientationPrototype _SetSoundConeOrientation = WarcraftIII.Jass.GetNative("SetSoundConeOrientation").ToDelegate<SetSoundConeOrientationPrototype>();
        public void SetSoundConeOrientation(JassSound soundHandle, Single x, Single y, Single z)
        {
            _SetSoundConeOrientation(soundHandle, x, y, z);
        }

        //native SetSoundPosition takes sound soundHandle, real x, real y, real z returns nothing
        private delegate void SetSoundPositionPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private SetSoundPositionPrototype _SetSoundPosition = WarcraftIII.Jass.GetNative("SetSoundPosition").ToDelegate<SetSoundPositionPrototype>();
        public void SetSoundPosition(JassSound soundHandle, Single x, Single y, Single z)
        {
            _SetSoundPosition(soundHandle, x, y, z);
        }

        //native SetSoundVelocity takes sound soundHandle, real x, real y, real z returns nothing
        private delegate void SetSoundVelocityPrototype(JassSound soundHandle, JassRealArg x, JassRealArg y, JassRealArg z);
        private SetSoundVelocityPrototype _SetSoundVelocity = WarcraftIII.Jass.GetNative("SetSoundVelocity").ToDelegate<SetSoundVelocityPrototype>();
        public void SetSoundVelocity(JassSound soundHandle, Single x, Single y, Single z)
        {
            _SetSoundVelocity(soundHandle, x, y, z);
        }

        //native AttachSoundToUnit takes sound soundHandle, unit whichUnit returns nothing
        private delegate void AttachSoundToUnitPrototype(JassSound soundHandle, JassUnit whichUnit);
        private AttachSoundToUnitPrototype _AttachSoundToUnit = WarcraftIII.Jass.GetNative("AttachSoundToUnit").ToDelegate<AttachSoundToUnitPrototype>();
        public void AttachSoundToUnit(JassSound soundHandle, JassUnit whichUnit)
        {
            _AttachSoundToUnit(soundHandle, whichUnit);
        }

        //native StartSound takes sound soundHandle returns nothing
        private delegate void StartSoundPrototype(JassSound soundHandle);
        private StartSoundPrototype _StartSound = WarcraftIII.Jass.GetNative("StartSound").ToDelegate<StartSoundPrototype>();
        public void StartSound(JassSound soundHandle)
        {
            _StartSound(soundHandle);
        }

        //native StopSound takes sound soundHandle, boolean killWhenDone, boolean fadeOut returns nothing
        private delegate void StopSoundPrototype(JassSound soundHandle, JassBoolean killWhenDone, JassBoolean fadeOut);
        private StopSoundPrototype _StopSound = WarcraftIII.Jass.GetNative("StopSound").ToDelegate<StopSoundPrototype>();
        public void StopSound(JassSound soundHandle, Boolean killWhenDone, Boolean fadeOut)
        {
            _StopSound(soundHandle, killWhenDone, fadeOut);
        }

        //native KillSoundWhenDone takes sound soundHandle returns nothing
        private delegate void KillSoundWhenDonePrototype(JassSound soundHandle);
        private KillSoundWhenDonePrototype _KillSoundWhenDone = WarcraftIII.Jass.GetNative("KillSoundWhenDone").ToDelegate<KillSoundWhenDonePrototype>();
        public void KillSoundWhenDone(JassSound soundHandle)
        {
            _KillSoundWhenDone(soundHandle);
        }

        //native SetMapMusic takes string musicName, boolean random, integer index returns nothing
        private delegate void SetMapMusicPrototype(JassStringArg musicName, JassBoolean random, JassInteger index);
        private SetMapMusicPrototype _SetMapMusic = WarcraftIII.Jass.GetNative("SetMapMusic").ToDelegate<SetMapMusicPrototype>();
        public void SetMapMusic(String musicName, Boolean random, JassInteger index)
        {
            _SetMapMusic(musicName, random, index);
        }

        //native ClearMapMusic takes nothing returns nothing
        private delegate void ClearMapMusicPrototype();
        private ClearMapMusicPrototype _ClearMapMusic = WarcraftIII.Jass.GetNative("ClearMapMusic").ToDelegate<ClearMapMusicPrototype>();
        public void ClearMapMusic()
        {
            _ClearMapMusic();
        }

        //native PlayMusic takes string musicName returns nothing
        private delegate void PlayMusicPrototype(JassStringArg musicName);
        private PlayMusicPrototype _PlayMusic = WarcraftIII.Jass.GetNative("PlayMusic").ToDelegate<PlayMusicPrototype>();
        public void PlayMusic(String musicName)
        {
            _PlayMusic(musicName);
        }

        //native PlayMusicEx takes string musicName, integer frommsecs, integer fadeinmsecs returns nothing
        private delegate void PlayMusicExPrototype(JassStringArg musicName, JassInteger frommsecs, JassInteger fadeinmsecs);
        private PlayMusicExPrototype _PlayMusicEx = WarcraftIII.Jass.GetNative("PlayMusicEx").ToDelegate<PlayMusicExPrototype>();
        public void PlayMusicEx(String musicName, JassInteger frommsecs, JassInteger fadeinmsecs)
        {
            _PlayMusicEx(musicName, frommsecs, fadeinmsecs);
        }

        //native StopMusic takes boolean fadeOut returns nothing
        private delegate void StopMusicPrototype(JassBoolean fadeOut);
        private StopMusicPrototype _StopMusic = WarcraftIII.Jass.GetNative("StopMusic").ToDelegate<StopMusicPrototype>();
        public void StopMusic(Boolean fadeOut)
        {
            _StopMusic(fadeOut);
        }

        //native ResumeMusic takes nothing returns nothing
        private delegate void ResumeMusicPrototype();
        private ResumeMusicPrototype _ResumeMusic = WarcraftIII.Jass.GetNative("ResumeMusic").ToDelegate<ResumeMusicPrototype>();
        public void ResumeMusic()
        {
            _ResumeMusic();
        }

        //native PlayThematicMusic takes string musicFileName returns nothing
        private delegate void PlayThematicMusicPrototype(JassStringArg musicFileName);
        private PlayThematicMusicPrototype _PlayThematicMusic = WarcraftIII.Jass.GetNative("PlayThematicMusic").ToDelegate<PlayThematicMusicPrototype>();
        public void PlayThematicMusic(String musicFileName)
        {
            _PlayThematicMusic(musicFileName);
        }

        //native PlayThematicMusicEx takes string musicFileName, integer frommsecs returns nothing
        private delegate void PlayThematicMusicExPrototype(JassStringArg musicFileName, JassInteger frommsecs);
        private PlayThematicMusicExPrototype _PlayThematicMusicEx = WarcraftIII.Jass.GetNative("PlayThematicMusicEx").ToDelegate<PlayThematicMusicExPrototype>();
        public void PlayThematicMusicEx(String musicFileName, JassInteger frommsecs)
        {
            _PlayThematicMusicEx(musicFileName, frommsecs);
        }

        //native EndThematicMusic takes nothing returns nothing
        private delegate void EndThematicMusicPrototype();
        private EndThematicMusicPrototype _EndThematicMusic = WarcraftIII.Jass.GetNative("EndThematicMusic").ToDelegate<EndThematicMusicPrototype>();
        public void EndThematicMusic()
        {
            _EndThematicMusic();
        }

        //native SetMusicVolume takes integer volume returns nothing
        private delegate void SetMusicVolumePrototype(JassInteger volume);
        private SetMusicVolumePrototype _SetMusicVolume = WarcraftIII.Jass.GetNative("SetMusicVolume").ToDelegate<SetMusicVolumePrototype>();
        public void SetMusicVolume(JassInteger volume)
        {
            _SetMusicVolume(volume);
        }

        //native SetMusicPlayPosition takes integer millisecs returns nothing
        private delegate void SetMusicPlayPositionPrototype(JassInteger millisecs);
        private SetMusicPlayPositionPrototype _SetMusicPlayPosition = WarcraftIII.Jass.GetNative("SetMusicPlayPosition").ToDelegate<SetMusicPlayPositionPrototype>();
        public void SetMusicPlayPosition(JassInteger millisecs)
        {
            _SetMusicPlayPosition(millisecs);
        }

        //native SetThematicMusicPlayPosition takes integer millisecs returns nothing
        private delegate void SetThematicMusicPlayPositionPrototype(JassInteger millisecs);
        private SetThematicMusicPlayPositionPrototype _SetThematicMusicPlayPosition = WarcraftIII.Jass.GetNative("SetThematicMusicPlayPosition").ToDelegate<SetThematicMusicPlayPositionPrototype>();
        public void SetThematicMusicPlayPosition(JassInteger millisecs)
        {
            _SetThematicMusicPlayPosition(millisecs);
        }

        //native SetSoundDuration takes sound soundHandle, integer duration returns nothing
        private delegate void SetSoundDurationPrototype(JassSound soundHandle, JassInteger duration);
        private SetSoundDurationPrototype _SetSoundDuration = WarcraftIII.Jass.GetNative("SetSoundDuration").ToDelegate<SetSoundDurationPrototype>();
        public void SetSoundDuration(JassSound soundHandle, JassInteger duration)
        {
            _SetSoundDuration(soundHandle, duration);
        }

        //native GetSoundDuration takes sound soundHandle returns integer
        private delegate JassInteger GetSoundDurationPrototype(JassSound soundHandle);
        private GetSoundDurationPrototype _GetSoundDuration = WarcraftIII.Jass.GetNative("GetSoundDuration").ToDelegate<GetSoundDurationPrototype>();
        public JassInteger GetSoundDuration(JassSound soundHandle)
        {
            return _GetSoundDuration(soundHandle);
        }

        //native GetSoundFileDuration takes string musicFileName returns integer
        private delegate JassInteger GetSoundFileDurationPrototype(JassStringArg musicFileName);
        private GetSoundFileDurationPrototype _GetSoundFileDuration = WarcraftIII.Jass.GetNative("GetSoundFileDuration").ToDelegate<GetSoundFileDurationPrototype>();
        public JassInteger GetSoundFileDuration(String musicFileName)
        {
            return _GetSoundFileDuration(musicFileName);
        }

        //native VolumeGroupSetVolume takes volumegroup vgroup, real scale returns nothing
        private delegate void VolumeGroupSetVolumePrototype(JassVolumeGroup vgroup, JassRealArg scale);
        private VolumeGroupSetVolumePrototype _VolumeGroupSetVolume = WarcraftIII.Jass.GetNative("VolumeGroupSetVolume").ToDelegate<VolumeGroupSetVolumePrototype>();
        public void VolumeGroupSetVolume(JassVolumeGroup vgroup, Single scale)
        {
            _VolumeGroupSetVolume(vgroup, scale);
        }

        //native VolumeGroupReset takes nothing returns nothing
        private delegate void VolumeGroupResetPrototype();
        private VolumeGroupResetPrototype _VolumeGroupReset = WarcraftIII.Jass.GetNative("VolumeGroupReset").ToDelegate<VolumeGroupResetPrototype>();
        public void VolumeGroupReset()
        {
            _VolumeGroupReset();
        }

        //native GetSoundIsPlaying takes sound soundHandle returns boolean
        private delegate JassBoolean GetSoundIsPlayingPrototype(JassSound soundHandle);
        private GetSoundIsPlayingPrototype _GetSoundIsPlaying = WarcraftIII.Jass.GetNative("GetSoundIsPlaying").ToDelegate<GetSoundIsPlayingPrototype>();
        public Boolean GetSoundIsPlaying(JassSound soundHandle)
        {
            return _GetSoundIsPlaying(soundHandle);
        }

        //native GetSoundIsLoading takes sound soundHandle returns boolean
        private delegate JassBoolean GetSoundIsLoadingPrototype(JassSound soundHandle);
        private GetSoundIsLoadingPrototype _GetSoundIsLoading = WarcraftIII.Jass.GetNative("GetSoundIsLoading").ToDelegate<GetSoundIsLoadingPrototype>();
        public Boolean GetSoundIsLoading(JassSound soundHandle)
        {
            return _GetSoundIsLoading(soundHandle);
        }

        //native RegisterStackedSound takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
        private delegate void RegisterStackedSoundPrototype(JassSound soundHandle, JassBoolean byPosition, JassRealArg rectwidth, JassRealArg rectheight);
        private RegisterStackedSoundPrototype _RegisterStackedSound = WarcraftIII.Jass.GetNative("RegisterStackedSound").ToDelegate<RegisterStackedSoundPrototype>();
        public void RegisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            _RegisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }

        //native UnregisterStackedSound takes sound soundHandle, boolean byPosition, real rectwidth, real rectheight returns nothing
        private delegate void UnregisterStackedSoundPrototype(JassSound soundHandle, JassBoolean byPosition, JassRealArg rectwidth, JassRealArg rectheight);
        private UnregisterStackedSoundPrototype _UnregisterStackedSound = WarcraftIII.Jass.GetNative("UnregisterStackedSound").ToDelegate<UnregisterStackedSoundPrototype>();
        public void UnregisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            _UnregisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }

        //native AddWeatherEffect takes rect where, integer effectID returns weathereffect
        private delegate JassWeatherEffect AddWeatherEffectPrototype(JassRect where, JassInteger effectID);
        private AddWeatherEffectPrototype _AddWeatherEffect = WarcraftIII.Jass.GetNative("AddWeatherEffect").ToDelegate<AddWeatherEffectPrototype>();
        public JassWeatherEffect AddWeatherEffect(JassRect where, JassInteger effectID)
        {
            return _AddWeatherEffect(where, effectID);
        }

        //native RemoveWeatherEffect takes weathereffect whichEffect returns nothing
        private delegate void RemoveWeatherEffectPrototype(JassWeatherEffect whichEffect);
        private RemoveWeatherEffectPrototype _RemoveWeatherEffect = WarcraftIII.Jass.GetNative("RemoveWeatherEffect").ToDelegate<RemoveWeatherEffectPrototype>();
        public void RemoveWeatherEffect(JassWeatherEffect whichEffect)
        {
            _RemoveWeatherEffect(whichEffect);
        }

        //native EnableWeatherEffect takes weathereffect whichEffect, boolean enable returns nothing
        private delegate void EnableWeatherEffectPrototype(JassWeatherEffect whichEffect, JassBoolean enable);
        private EnableWeatherEffectPrototype _EnableWeatherEffect = WarcraftIII.Jass.GetNative("EnableWeatherEffect").ToDelegate<EnableWeatherEffectPrototype>();
        public void EnableWeatherEffect(JassWeatherEffect whichEffect, Boolean enable)
        {
            _EnableWeatherEffect(whichEffect, enable);
        }

        //native TerrainDeformCrater takes real x, real y, real radius, real depth, integer duration, boolean permanent returns terraindeformation
        private delegate JassTerrainDeformation TerrainDeformCraterPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg depth, JassInteger duration, JassBoolean permanent);
        private TerrainDeformCraterPrototype _TerrainDeformCrater = WarcraftIII.Jass.GetNative("TerrainDeformCrater").ToDelegate<TerrainDeformCraterPrototype>();
        public JassTerrainDeformation TerrainDeformCrater(Single x, Single y, Single radius, Single depth, JassInteger duration, Boolean permanent)
        {
            return _TerrainDeformCrater(x, y, radius, depth, duration, permanent);
        }

        //native TerrainDeformRipple takes real x, real y, real radius, real depth, integer duration, integer count, real spaceWaves, real timeWaves, real radiusStartPct, boolean limitNeg returns terraindeformation
        private delegate JassTerrainDeformation TerrainDeformRipplePrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg depth, JassInteger duration, JassInteger count, JassRealArg spaceWaves, JassRealArg timeWaves, JassRealArg radiusStartPct, JassBoolean limitNeg);
        private TerrainDeformRipplePrototype _TerrainDeformRipple = WarcraftIII.Jass.GetNative("TerrainDeformRipple").ToDelegate<TerrainDeformRipplePrototype>();
        public JassTerrainDeformation TerrainDeformRipple(Single x, Single y, Single radius, Single depth, JassInteger duration, JassInteger count, Single spaceWaves, Single timeWaves, Single radiusStartPct, Boolean limitNeg)
        {
            return _TerrainDeformRipple(x, y, radius, depth, duration, count, spaceWaves, timeWaves, radiusStartPct, limitNeg);
        }

        //native TerrainDeformWave takes real x, real y, real dirX, real dirY, real distance, real speed, real radius, real depth, integer trailTime, integer count returns terraindeformation
        private delegate JassTerrainDeformation TerrainDeformWavePrototype(JassRealArg x, JassRealArg y, JassRealArg dirX, JassRealArg dirY, JassRealArg distance, JassRealArg speed, JassRealArg radius, JassRealArg depth, JassInteger trailTime, JassInteger count);
        private TerrainDeformWavePrototype _TerrainDeformWave = WarcraftIII.Jass.GetNative("TerrainDeformWave").ToDelegate<TerrainDeformWavePrototype>();
        public JassTerrainDeformation TerrainDeformWave(Single x, Single y, Single dirX, Single dirY, Single distance, Single speed, Single radius, Single depth, JassInteger trailTime, JassInteger count)
        {
            return _TerrainDeformWave(x, y, dirX, dirY, distance, speed, radius, depth, trailTime, count);
        }

        //native TerrainDeformRandom takes real x, real y, real radius, real minDelta, real maxDelta, integer duration, integer updateInterval returns terraindeformation
        private delegate JassTerrainDeformation TerrainDeformRandomPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassRealArg minDelta, JassRealArg maxDelta, JassInteger duration, JassInteger updateInterval);
        private TerrainDeformRandomPrototype _TerrainDeformRandom = WarcraftIII.Jass.GetNative("TerrainDeformRandom").ToDelegate<TerrainDeformRandomPrototype>();
        public JassTerrainDeformation TerrainDeformRandom(Single x, Single y, Single radius, Single minDelta, Single maxDelta, JassInteger duration, JassInteger updateInterval)
        {
            return _TerrainDeformRandom(x, y, radius, minDelta, maxDelta, duration, updateInterval);
        }

        //native TerrainDeformStop takes terraindeformation deformation, integer duration returns nothing
        private delegate void TerrainDeformStopPrototype(JassTerrainDeformation deformation, JassInteger duration);
        private TerrainDeformStopPrototype _TerrainDeformStop = WarcraftIII.Jass.GetNative("TerrainDeformStop").ToDelegate<TerrainDeformStopPrototype>();
        public void TerrainDeformStop(JassTerrainDeformation deformation, JassInteger duration)
        {
            _TerrainDeformStop(deformation, duration);
        }

        //native TerrainDeformStopAll takes nothing returns nothing
        private delegate void TerrainDeformStopAllPrototype();
        private TerrainDeformStopAllPrototype _TerrainDeformStopAll = WarcraftIII.Jass.GetNative("TerrainDeformStopAll").ToDelegate<TerrainDeformStopAllPrototype>();
        public void TerrainDeformStopAll()
        {
            _TerrainDeformStopAll();
        }

        //native AddSpecialEffect takes string modelName, real x, real y returns effect
        private delegate JassEffect AddSpecialEffectPrototype(JassStringArg modelName, JassRealArg x, JassRealArg y);
        private AddSpecialEffectPrototype _AddSpecialEffect = WarcraftIII.Jass.GetNative("AddSpecialEffect").ToDelegate<AddSpecialEffectPrototype>();
        public JassEffect AddSpecialEffect(String modelName, Single x, Single y)
        {
            return _AddSpecialEffect(modelName, x, y);
        }

        //native AddSpecialEffectLoc takes string modelName, location where returns effect
        private delegate JassEffect AddSpecialEffectLocPrototype(JassStringArg modelName, JassLocation where);
        private AddSpecialEffectLocPrototype _AddSpecialEffectLoc = WarcraftIII.Jass.GetNative("AddSpecialEffectLoc").ToDelegate<AddSpecialEffectLocPrototype>();
        public JassEffect AddSpecialEffectLoc(String modelName, JassLocation where)
        {
            return _AddSpecialEffectLoc(modelName, where);
        }

        //native AddSpecialEffectTarget takes string modelName, widget targetWidget, string attachPointName returns effect
        private delegate JassEffect AddSpecialEffectTargetPrototype(JassStringArg modelName, JassWidget targetWidget, JassStringArg attachPointName);
        private AddSpecialEffectTargetPrototype _AddSpecialEffectTarget = WarcraftIII.Jass.GetNative("AddSpecialEffectTarget").ToDelegate<AddSpecialEffectTargetPrototype>();
        public JassEffect AddSpecialEffectTarget(String modelName, JassWidget targetWidget, String attachPointName)
        {
            return _AddSpecialEffectTarget(modelName, targetWidget, attachPointName);
        }

        //native DestroyEffect takes effect whichEffect returns nothing
        private delegate void DestroyEffectPrototype(JassEffect whichEffect);
        private DestroyEffectPrototype _DestroyEffect = WarcraftIII.Jass.GetNative("DestroyEffect").ToDelegate<DestroyEffectPrototype>();
        public void DestroyEffect(JassEffect whichEffect)
        {
            _DestroyEffect(whichEffect);
        }

        //native AddSpellEffect takes string abilityString, effecttype t, real x, real y returns effect
        private delegate JassEffect AddSpellEffectPrototype(JassStringArg abilityString, JassEffectType t, JassRealArg x, JassRealArg y);
        private AddSpellEffectPrototype _AddSpellEffect = WarcraftIII.Jass.GetNative("AddSpellEffect").ToDelegate<AddSpellEffectPrototype>();
        public JassEffect AddSpellEffect(String abilityString, JassEffectType t, Single x, Single y)
        {
            return _AddSpellEffect(abilityString, t, x, y);
        }

        //native AddSpellEffectLoc takes string abilityString, effecttype t, location where returns effect
        private delegate JassEffect AddSpellEffectLocPrototype(JassStringArg abilityString, JassEffectType t, JassLocation where);
        private AddSpellEffectLocPrototype _AddSpellEffectLoc = WarcraftIII.Jass.GetNative("AddSpellEffectLoc").ToDelegate<AddSpellEffectLocPrototype>();
        public JassEffect AddSpellEffectLoc(String abilityString, JassEffectType t, JassLocation where)
        {
            return _AddSpellEffectLoc(abilityString, t, where);
        }

        //native AddSpellEffectById takes integer abilityId, effecttype t, real x, real y returns effect
        private delegate JassEffect AddSpellEffectByIdPrototype(JassInteger abilityId, JassEffectType t, JassRealArg x, JassRealArg y);
        private AddSpellEffectByIdPrototype _AddSpellEffectById = WarcraftIII.Jass.GetNative("AddSpellEffectById").ToDelegate<AddSpellEffectByIdPrototype>();
        public JassEffect AddSpellEffectById(JassInteger abilityId, JassEffectType t, Single x, Single y)
        {
            return _AddSpellEffectById(abilityId, t, x, y);
        }

        //native AddSpellEffectByIdLoc takes integer abilityId, effecttype t, location where returns effect
        private delegate JassEffect AddSpellEffectByIdLocPrototype(JassInteger abilityId, JassEffectType t, JassLocation where);
        private AddSpellEffectByIdLocPrototype _AddSpellEffectByIdLoc = WarcraftIII.Jass.GetNative("AddSpellEffectByIdLoc").ToDelegate<AddSpellEffectByIdLocPrototype>();
        public JassEffect AddSpellEffectByIdLoc(JassInteger abilityId, JassEffectType t, JassLocation where)
        {
            return _AddSpellEffectByIdLoc(abilityId, t, where);
        }

        //native AddSpellEffectTarget takes string modelName, effecttype t, widget targetWidget, string attachPoint returns effect
        private delegate JassEffect AddSpellEffectTargetPrototype(JassStringArg modelName, JassEffectType t, JassWidget targetWidget, JassStringArg attachPoint);
        private AddSpellEffectTargetPrototype _AddSpellEffectTarget = WarcraftIII.Jass.GetNative("AddSpellEffectTarget").ToDelegate<AddSpellEffectTargetPrototype>();
        public JassEffect AddSpellEffectTarget(String modelName, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return _AddSpellEffectTarget(modelName, t, targetWidget, attachPoint);
        }

        //native AddSpellEffectTargetById takes integer abilityId, effecttype t, widget targetWidget, string attachPoint returns effect
        private delegate JassEffect AddSpellEffectTargetByIdPrototype(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, JassStringArg attachPoint);
        private AddSpellEffectTargetByIdPrototype _AddSpellEffectTargetById = WarcraftIII.Jass.GetNative("AddSpellEffectTargetById").ToDelegate<AddSpellEffectTargetByIdPrototype>();
        public JassEffect AddSpellEffectTargetById(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return _AddSpellEffectTargetById(abilityId, t, targetWidget, attachPoint);
        }

        //native AddLightning takes string codeName, boolean checkVisibility, real x1, real y1, real x2, real y2 returns lightning
        private delegate JassLightning AddLightningPrototype(JassStringArg codeName, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2);
        private AddLightningPrototype _AddLightning = WarcraftIII.Jass.GetNative("AddLightning").ToDelegate<AddLightningPrototype>();
        public JassLightning AddLightning(String codeName, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return _AddLightning(codeName, checkVisibility, x1, y1, x2, y2);
        }

        //native AddLightningEx takes string codeName, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns lightning
        private delegate JassLightning AddLightningExPrototype(JassStringArg codeName, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg z1, JassRealArg x2, JassRealArg y2, JassRealArg z2);
        private AddLightningExPrototype _AddLightningEx = WarcraftIII.Jass.GetNative("AddLightningEx").ToDelegate<AddLightningExPrototype>();
        public JassLightning AddLightningEx(String codeName, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return _AddLightningEx(codeName, checkVisibility, x1, y1, z1, x2, y2, z2);
        }

        //native DestroyLightning takes lightning whichBolt returns boolean
        private delegate JassBoolean DestroyLightningPrototype(JassLightning whichBolt);
        private DestroyLightningPrototype _DestroyLightning = WarcraftIII.Jass.GetNative("DestroyLightning").ToDelegate<DestroyLightningPrototype>();
        public Boolean DestroyLightning(JassLightning whichBolt)
        {
            return _DestroyLightning(whichBolt);
        }

        //native MoveLightning takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real x2, real y2 returns boolean
        private delegate JassBoolean MoveLightningPrototype(JassLightning whichBolt, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg x2, JassRealArg y2);
        private MoveLightningPrototype _MoveLightning = WarcraftIII.Jass.GetNative("MoveLightning").ToDelegate<MoveLightningPrototype>();
        public Boolean MoveLightning(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return _MoveLightning(whichBolt, checkVisibility, x1, y1, x2, y2);
        }

        //native MoveLightningEx takes lightning whichBolt, boolean checkVisibility, real x1, real y1, real z1, real x2, real y2, real z2 returns boolean
        private delegate JassBoolean MoveLightningExPrototype(JassLightning whichBolt, JassBoolean checkVisibility, JassRealArg x1, JassRealArg y1, JassRealArg z1, JassRealArg x2, JassRealArg y2, JassRealArg z2);
        private MoveLightningExPrototype _MoveLightningEx = WarcraftIII.Jass.GetNative("MoveLightningEx").ToDelegate<MoveLightningExPrototype>();
        public Boolean MoveLightningEx(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return _MoveLightningEx(whichBolt, checkVisibility, x1, y1, z1, x2, y2, z2);
        }

        //native GetLightningColorA takes lightning whichBolt returns real
        private delegate JassRealRet GetLightningColorAPrototype(JassLightning whichBolt);
        private GetLightningColorAPrototype _GetLightningColorA = WarcraftIII.Jass.GetNative("GetLightningColorA").ToDelegate<GetLightningColorAPrototype>();
        public Single GetLightningColorA(JassLightning whichBolt)
        {
            return _GetLightningColorA(whichBolt);
        }

        //native GetLightningColorR takes lightning whichBolt returns real
        private delegate JassRealRet GetLightningColorRPrototype(JassLightning whichBolt);
        private GetLightningColorRPrototype _GetLightningColorR = WarcraftIII.Jass.GetNative("GetLightningColorR").ToDelegate<GetLightningColorRPrototype>();
        public Single GetLightningColorR(JassLightning whichBolt)
        {
            return _GetLightningColorR(whichBolt);
        }

        //native GetLightningColorG takes lightning whichBolt returns real
        private delegate JassRealRet GetLightningColorGPrototype(JassLightning whichBolt);
        private GetLightningColorGPrototype _GetLightningColorG = WarcraftIII.Jass.GetNative("GetLightningColorG").ToDelegate<GetLightningColorGPrototype>();
        public Single GetLightningColorG(JassLightning whichBolt)
        {
            return _GetLightningColorG(whichBolt);
        }

        //native GetLightningColorB takes lightning whichBolt returns real
        private delegate JassRealRet GetLightningColorBPrototype(JassLightning whichBolt);
        private GetLightningColorBPrototype _GetLightningColorB = WarcraftIII.Jass.GetNative("GetLightningColorB").ToDelegate<GetLightningColorBPrototype>();
        public Single GetLightningColorB(JassLightning whichBolt)
        {
            return _GetLightningColorB(whichBolt);
        }

        //native SetLightningColor takes lightning whichBolt, real r, real g, real b, real a returns boolean
        private delegate JassBoolean SetLightningColorPrototype(JassLightning whichBolt, JassRealArg r, JassRealArg g, JassRealArg b, JassRealArg a);
        private SetLightningColorPrototype _SetLightningColor = WarcraftIII.Jass.GetNative("SetLightningColor").ToDelegate<SetLightningColorPrototype>();
        public Boolean SetLightningColor(JassLightning whichBolt, Single r, Single g, Single b, Single a)
        {
            return _SetLightningColor(whichBolt, r, g, b, a);
        }

        //native GetAbilityEffect takes string abilityString, effecttype t, integer index returns string
        private delegate JassStringRet GetAbilityEffectPrototype(JassStringArg abilityString, JassEffectType t, JassInteger index);
        private GetAbilityEffectPrototype _GetAbilityEffect = WarcraftIII.Jass.GetNative("GetAbilityEffect").ToDelegate<GetAbilityEffectPrototype>();
        public String GetAbilityEffect(String abilityString, JassEffectType t, JassInteger index)
        {
            return _GetAbilityEffect(abilityString, t, index);
        }

        //native GetAbilityEffectById takes integer abilityId, effecttype t, integer index returns string
        private delegate JassStringRet GetAbilityEffectByIdPrototype(JassInteger abilityId, JassEffectType t, JassInteger index);
        private GetAbilityEffectByIdPrototype _GetAbilityEffectById = WarcraftIII.Jass.GetNative("GetAbilityEffectById").ToDelegate<GetAbilityEffectByIdPrototype>();
        public String GetAbilityEffectById(JassInteger abilityId, JassEffectType t, JassInteger index)
        {
            return _GetAbilityEffectById(abilityId, t, index);
        }

        //native GetAbilitySound takes string abilityString, soundtype t returns string
        private delegate JassStringRet GetAbilitySoundPrototype(JassStringArg abilityString, JassSoundType t);
        private GetAbilitySoundPrototype _GetAbilitySound = WarcraftIII.Jass.GetNative("GetAbilitySound").ToDelegate<GetAbilitySoundPrototype>();
        public String GetAbilitySound(String abilityString, JassSoundType t)
        {
            return _GetAbilitySound(abilityString, t);
        }

        //native GetAbilitySoundById takes integer abilityId, soundtype t returns string
        private delegate JassStringRet GetAbilitySoundByIdPrototype(JassInteger abilityId, JassSoundType t);
        private GetAbilitySoundByIdPrototype _GetAbilitySoundById = WarcraftIII.Jass.GetNative("GetAbilitySoundById").ToDelegate<GetAbilitySoundByIdPrototype>();
        public String GetAbilitySoundById(JassInteger abilityId, JassSoundType t)
        {
            return _GetAbilitySoundById(abilityId, t);
        }

        //native GetTerrainCliffLevel takes real x, real y returns integer
        private delegate JassInteger GetTerrainCliffLevelPrototype(JassRealArg x, JassRealArg y);
        private GetTerrainCliffLevelPrototype _GetTerrainCliffLevel = WarcraftIII.Jass.GetNative("GetTerrainCliffLevel").ToDelegate<GetTerrainCliffLevelPrototype>();
        public JassInteger GetTerrainCliffLevel(Single x, Single y)
        {
            return _GetTerrainCliffLevel(x, y);
        }

        //native SetWaterBaseColor takes integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void SetWaterBaseColorPrototype(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private SetWaterBaseColorPrototype _SetWaterBaseColor = WarcraftIII.Jass.GetNative("SetWaterBaseColor").ToDelegate<SetWaterBaseColorPrototype>();
        public void SetWaterBaseColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _SetWaterBaseColor(red, green, blue, alpha);
        }

        //native SetWaterDeforms takes boolean val returns nothing
        private delegate void SetWaterDeformsPrototype(JassBoolean val);
        private SetWaterDeformsPrototype _SetWaterDeforms = WarcraftIII.Jass.GetNative("SetWaterDeforms").ToDelegate<SetWaterDeformsPrototype>();
        public void SetWaterDeforms(Boolean val)
        {
            _SetWaterDeforms(val);
        }

        //native GetTerrainType takes real x, real y returns integer
        private delegate JassInteger GetTerrainTypePrototype(JassRealArg x, JassRealArg y);
        private GetTerrainTypePrototype _GetTerrainType = WarcraftIII.Jass.GetNative("GetTerrainType").ToDelegate<GetTerrainTypePrototype>();
        public JassInteger GetTerrainType(Single x, Single y)
        {
            return _GetTerrainType(x, y);
        }

        //native GetTerrainVariance takes real x, real y returns integer
        private delegate JassInteger GetTerrainVariancePrototype(JassRealArg x, JassRealArg y);
        private GetTerrainVariancePrototype _GetTerrainVariance = WarcraftIII.Jass.GetNative("GetTerrainVariance").ToDelegate<GetTerrainVariancePrototype>();
        public JassInteger GetTerrainVariance(Single x, Single y)
        {
            return _GetTerrainVariance(x, y);
        }

        //native SetTerrainType takes real x, real y, integer terrainType, integer variation, integer area, integer shape returns nothing
        private delegate void SetTerrainTypePrototype(JassRealArg x, JassRealArg y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape);
        private SetTerrainTypePrototype _SetTerrainType = WarcraftIII.Jass.GetNative("SetTerrainType").ToDelegate<SetTerrainTypePrototype>();
        public void SetTerrainType(Single x, Single y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape)
        {
            _SetTerrainType(x, y, terrainType, variation, area, shape);
        }

        //native IsTerrainPathable takes real x, real y, pathingtype t returns boolean
        private delegate JassBoolean IsTerrainPathablePrototype(JassRealArg x, JassRealArg y, JassPathingType t);
        private IsTerrainPathablePrototype _IsTerrainPathable = WarcraftIII.Jass.GetNative("IsTerrainPathable").ToDelegate<IsTerrainPathablePrototype>();
        public Boolean IsTerrainPathable(Single x, Single y, JassPathingType t)
        {
            return _IsTerrainPathable(x, y, t);
        }

        //native SetTerrainPathable takes real x, real y, pathingtype t, boolean flag returns nothing
        private delegate void SetTerrainPathablePrototype(JassRealArg x, JassRealArg y, JassPathingType t, JassBoolean flag);
        private SetTerrainPathablePrototype _SetTerrainPathable = WarcraftIII.Jass.GetNative("SetTerrainPathable").ToDelegate<SetTerrainPathablePrototype>();
        public void SetTerrainPathable(Single x, Single y, JassPathingType t, Boolean flag)
        {
            _SetTerrainPathable(x, y, t, flag);
        }

        //native CreateImage takes string file, real sizeX, real sizeY, real sizeZ, real posX, real posY, real posZ, real originX, real originY, real originZ, integer imageType returns image
        private delegate JassImage CreateImagePrototype(JassStringArg file, JassRealArg sizeX, JassRealArg sizeY, JassRealArg sizeZ, JassRealArg posX, JassRealArg posY, JassRealArg posZ, JassRealArg originX, JassRealArg originY, JassRealArg originZ, JassInteger imageType);
        private CreateImagePrototype _CreateImage = WarcraftIII.Jass.GetNative("CreateImage").ToDelegate<CreateImagePrototype>();
        public JassImage CreateImage(String file, Single sizeX, Single sizeY, Single sizeZ, Single posX, Single posY, Single posZ, Single originX, Single originY, Single originZ, JassInteger imageType)
        {
            return _CreateImage(file, sizeX, sizeY, sizeZ, posX, posY, posZ, originX, originY, originZ, imageType);
        }

        //native DestroyImage takes image whichImage returns nothing
        private delegate void DestroyImagePrototype(JassImage whichImage);
        private DestroyImagePrototype _DestroyImage = WarcraftIII.Jass.GetNative("DestroyImage").ToDelegate<DestroyImagePrototype>();
        public void DestroyImage(JassImage whichImage)
        {
            _DestroyImage(whichImage);
        }

        //native ShowImage takes image whichImage, boolean flag returns nothing
        private delegate void ShowImagePrototype(JassImage whichImage, JassBoolean flag);
        private ShowImagePrototype _ShowImage = WarcraftIII.Jass.GetNative("ShowImage").ToDelegate<ShowImagePrototype>();
        public void ShowImage(JassImage whichImage, Boolean flag)
        {
            _ShowImage(whichImage, flag);
        }

        //native SetImageConstantHeight takes image whichImage, boolean flag, real height returns nothing
        private delegate void SetImageConstantHeightPrototype(JassImage whichImage, JassBoolean flag, JassRealArg height);
        private SetImageConstantHeightPrototype _SetImageConstantHeight = WarcraftIII.Jass.GetNative("SetImageConstantHeight").ToDelegate<SetImageConstantHeightPrototype>();
        public void SetImageConstantHeight(JassImage whichImage, Boolean flag, Single height)
        {
            _SetImageConstantHeight(whichImage, flag, height);
        }

        //native SetImagePosition takes image whichImage, real x, real y, real z returns nothing
        private delegate void SetImagePositionPrototype(JassImage whichImage, JassRealArg x, JassRealArg y, JassRealArg z);
        private SetImagePositionPrototype _SetImagePosition = WarcraftIII.Jass.GetNative("SetImagePosition").ToDelegate<SetImagePositionPrototype>();
        public void SetImagePosition(JassImage whichImage, Single x, Single y, Single z)
        {
            _SetImagePosition(whichImage, x, y, z);
        }

        //native SetImageColor takes image whichImage, integer red, integer green, integer blue, integer alpha returns nothing
        private delegate void SetImageColorPrototype(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha);
        private SetImageColorPrototype _SetImageColor = WarcraftIII.Jass.GetNative("SetImageColor").ToDelegate<SetImageColorPrototype>();
        public void SetImageColor(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            _SetImageColor(whichImage, red, green, blue, alpha);
        }

        //native SetImageRender takes image whichImage, boolean flag returns nothing
        private delegate void SetImageRenderPrototype(JassImage whichImage, JassBoolean flag);
        private SetImageRenderPrototype _SetImageRender = WarcraftIII.Jass.GetNative("SetImageRender").ToDelegate<SetImageRenderPrototype>();
        public void SetImageRender(JassImage whichImage, Boolean flag)
        {
            _SetImageRender(whichImage, flag);
        }

        //native SetImageRenderAlways takes image whichImage, boolean flag returns nothing
        private delegate void SetImageRenderAlwaysPrototype(JassImage whichImage, JassBoolean flag);
        private SetImageRenderAlwaysPrototype _SetImageRenderAlways = WarcraftIII.Jass.GetNative("SetImageRenderAlways").ToDelegate<SetImageRenderAlwaysPrototype>();
        public void SetImageRenderAlways(JassImage whichImage, Boolean flag)
        {
            _SetImageRenderAlways(whichImage, flag);
        }

        //native SetImageAboveWater takes image whichImage, boolean flag, boolean useWaterAlpha returns nothing
        private delegate void SetImageAboveWaterPrototype(JassImage whichImage, JassBoolean flag, JassBoolean useWaterAlpha);
        private SetImageAboveWaterPrototype _SetImageAboveWater = WarcraftIII.Jass.GetNative("SetImageAboveWater").ToDelegate<SetImageAboveWaterPrototype>();
        public void SetImageAboveWater(JassImage whichImage, Boolean flag, Boolean useWaterAlpha)
        {
            _SetImageAboveWater(whichImage, flag, useWaterAlpha);
        }

        //native SetImageType takes image whichImage, integer imageType returns nothing
        private delegate void SetImageTypePrototype(JassImage whichImage, JassInteger imageType);
        private SetImageTypePrototype _SetImageType = WarcraftIII.Jass.GetNative("SetImageType").ToDelegate<SetImageTypePrototype>();
        public void SetImageType(JassImage whichImage, JassInteger imageType)
        {
            _SetImageType(whichImage, imageType);
        }

        //native CreateUbersplat takes real x, real y, string name, integer red, integer green, integer blue, integer alpha, boolean forcePaused, boolean noBirthTime returns ubersplat
        private delegate JassUberSplat CreateUbersplatPrototype(JassRealArg x, JassRealArg y, JassStringArg name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, JassBoolean forcePaused, JassBoolean noBirthTime);
        private CreateUbersplatPrototype _CreateUbersplat = WarcraftIII.Jass.GetNative("CreateUbersplat").ToDelegate<CreateUbersplatPrototype>();
        public JassUberSplat CreateUbersplat(Single x, Single y, String name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, Boolean forcePaused, Boolean noBirthTime)
        {
            return _CreateUbersplat(x, y, name, red, green, blue, alpha, forcePaused, noBirthTime);
        }

        //native DestroyUbersplat takes ubersplat whichSplat returns nothing
        private delegate void DestroyUbersplatPrototype(JassUberSplat whichSplat);
        private DestroyUbersplatPrototype _DestroyUbersplat = WarcraftIII.Jass.GetNative("DestroyUbersplat").ToDelegate<DestroyUbersplatPrototype>();
        public void DestroyUbersplat(JassUberSplat whichSplat)
        {
            _DestroyUbersplat(whichSplat);
        }

        //native ResetUbersplat takes ubersplat whichSplat returns nothing
        private delegate void ResetUbersplatPrototype(JassUberSplat whichSplat);
        private ResetUbersplatPrototype _ResetUbersplat = WarcraftIII.Jass.GetNative("ResetUbersplat").ToDelegate<ResetUbersplatPrototype>();
        public void ResetUbersplat(JassUberSplat whichSplat)
        {
            _ResetUbersplat(whichSplat);
        }

        //native FinishUbersplat takes ubersplat whichSplat returns nothing
        private delegate void FinishUbersplatPrototype(JassUberSplat whichSplat);
        private FinishUbersplatPrototype _FinishUbersplat = WarcraftIII.Jass.GetNative("FinishUbersplat").ToDelegate<FinishUbersplatPrototype>();
        public void FinishUbersplat(JassUberSplat whichSplat)
        {
            _FinishUbersplat(whichSplat);
        }

        //native ShowUbersplat takes ubersplat whichSplat, boolean flag returns nothing
        private delegate void ShowUbersplatPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private ShowUbersplatPrototype _ShowUbersplat = WarcraftIII.Jass.GetNative("ShowUbersplat").ToDelegate<ShowUbersplatPrototype>();
        public void ShowUbersplat(JassUberSplat whichSplat, Boolean flag)
        {
            _ShowUbersplat(whichSplat, flag);
        }

        //native SetUbersplatRender takes ubersplat whichSplat, boolean flag returns nothing
        private delegate void SetUbersplatRenderPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private SetUbersplatRenderPrototype _SetUbersplatRender = WarcraftIII.Jass.GetNative("SetUbersplatRender").ToDelegate<SetUbersplatRenderPrototype>();
        public void SetUbersplatRender(JassUberSplat whichSplat, Boolean flag)
        {
            _SetUbersplatRender(whichSplat, flag);
        }

        //native SetUbersplatRenderAlways takes ubersplat whichSplat, boolean flag returns nothing
        private delegate void SetUbersplatRenderAlwaysPrototype(JassUberSplat whichSplat, JassBoolean flag);
        private SetUbersplatRenderAlwaysPrototype _SetUbersplatRenderAlways = WarcraftIII.Jass.GetNative("SetUbersplatRenderAlways").ToDelegate<SetUbersplatRenderAlwaysPrototype>();
        public void SetUbersplatRenderAlways(JassUberSplat whichSplat, Boolean flag)
        {
            _SetUbersplatRenderAlways(whichSplat, flag);
        }

        //native SetBlight takes player whichPlayer, real x, real y, real radius, boolean addBlight returns nothing
        private delegate void SetBlightPrototype(JassPlayer whichPlayer, JassRealArg x, JassRealArg y, JassRealArg radius, JassBoolean addBlight);
        private SetBlightPrototype _SetBlight = WarcraftIII.Jass.GetNative("SetBlight").ToDelegate<SetBlightPrototype>();
        public void SetBlight(JassPlayer whichPlayer, Single x, Single y, Single radius, Boolean addBlight)
        {
            _SetBlight(whichPlayer, x, y, radius, addBlight);
        }

        //native SetBlightRect takes player whichPlayer, rect r, boolean addBlight returns nothing
        private delegate void SetBlightRectPrototype(JassPlayer whichPlayer, JassRect r, JassBoolean addBlight);
        private SetBlightRectPrototype _SetBlightRect = WarcraftIII.Jass.GetNative("SetBlightRect").ToDelegate<SetBlightRectPrototype>();
        public void SetBlightRect(JassPlayer whichPlayer, JassRect r, Boolean addBlight)
        {
            _SetBlightRect(whichPlayer, r, addBlight);
        }

        //native SetBlightPoint takes player whichPlayer, real x, real y, boolean addBlight returns nothing
        private delegate void SetBlightPointPrototype(JassPlayer whichPlayer, JassRealArg x, JassRealArg y, JassBoolean addBlight);
        private SetBlightPointPrototype _SetBlightPoint = WarcraftIII.Jass.GetNative("SetBlightPoint").ToDelegate<SetBlightPointPrototype>();
        public void SetBlightPoint(JassPlayer whichPlayer, Single x, Single y, Boolean addBlight)
        {
            _SetBlightPoint(whichPlayer, x, y, addBlight);
        }

        //native SetBlightLoc takes player whichPlayer, location whichLocation, real radius, boolean addBlight returns nothing
        private delegate void SetBlightLocPrototype(JassPlayer whichPlayer, JassLocation whichLocation, JassRealArg radius, JassBoolean addBlight);
        private SetBlightLocPrototype _SetBlightLoc = WarcraftIII.Jass.GetNative("SetBlightLoc").ToDelegate<SetBlightLocPrototype>();
        public void SetBlightLoc(JassPlayer whichPlayer, JassLocation whichLocation, Single radius, Boolean addBlight)
        {
            _SetBlightLoc(whichPlayer, whichLocation, radius, addBlight);
        }

        //native CreateBlightedGoldmine takes player id, real x, real y, real face returns unit
        private delegate JassUnit CreateBlightedGoldminePrototype(JassPlayer id, JassRealArg x, JassRealArg y, JassRealArg face);
        private CreateBlightedGoldminePrototype _CreateBlightedGoldmine = WarcraftIII.Jass.GetNative("CreateBlightedGoldmine").ToDelegate<CreateBlightedGoldminePrototype>();
        public JassUnit CreateBlightedGoldmine(JassPlayer id, Single x, Single y, Single face)
        {
            return _CreateBlightedGoldmine(id, x, y, face);
        }

        //native IsPointBlighted takes real x, real y returns boolean
        private delegate JassBoolean IsPointBlightedPrototype(JassRealArg x, JassRealArg y);
        private IsPointBlightedPrototype _IsPointBlighted = WarcraftIII.Jass.GetNative("IsPointBlighted").ToDelegate<IsPointBlightedPrototype>();
        public Boolean IsPointBlighted(Single x, Single y)
        {
            return _IsPointBlighted(x, y);
        }

        //native SetDoodadAnimation takes real x, real y, real radius, integer doodadID, boolean nearestOnly, string animName, boolean animRandom returns nothing
        private delegate void SetDoodadAnimationPrototype(JassRealArg x, JassRealArg y, JassRealArg radius, JassInteger doodadID, JassBoolean nearestOnly, JassStringArg animName, JassBoolean animRandom);
        private SetDoodadAnimationPrototype _SetDoodadAnimation = WarcraftIII.Jass.GetNative("SetDoodadAnimation").ToDelegate<SetDoodadAnimationPrototype>();
        public void SetDoodadAnimation(Single x, Single y, Single radius, JassInteger doodadID, Boolean nearestOnly, String animName, Boolean animRandom)
        {
            _SetDoodadAnimation(x, y, radius, doodadID, nearestOnly, animName, animRandom);
        }

        //native SetDoodadAnimationRect takes rect r, integer doodadID, string animName, boolean animRandom returns nothing
        private delegate void SetDoodadAnimationRectPrototype(JassRect r, JassInteger doodadID, JassStringArg animName, JassBoolean animRandom);
        private SetDoodadAnimationRectPrototype _SetDoodadAnimationRect = WarcraftIII.Jass.GetNative("SetDoodadAnimationRect").ToDelegate<SetDoodadAnimationRectPrototype>();
        public void SetDoodadAnimationRect(JassRect r, JassInteger doodadID, String animName, Boolean animRandom)
        {
            _SetDoodadAnimationRect(r, doodadID, animName, animRandom);
        }

        //native StartMeleeAI takes player num, string script returns nothing
        private delegate void StartMeleeAIPrototype(JassPlayer num, JassStringArg script);
        private StartMeleeAIPrototype _StartMeleeAI = WarcraftIII.Jass.GetNative("StartMeleeAI").ToDelegate<StartMeleeAIPrototype>();
        public void StartMeleeAI(JassPlayer num, String script)
        {
            _StartMeleeAI(num, script);
        }

        //native StartCampaignAI takes player num, string script returns nothing
        private delegate void StartCampaignAIPrototype(JassPlayer num, JassStringArg script);
        private StartCampaignAIPrototype _StartCampaignAI = WarcraftIII.Jass.GetNative("StartCampaignAI").ToDelegate<StartCampaignAIPrototype>();
        public void StartCampaignAI(JassPlayer num, String script)
        {
            _StartCampaignAI(num, script);
        }

        //native CommandAI takes player num, integer command, integer data returns nothing
        private delegate void CommandAIPrototype(JassPlayer num, JassInteger command, JassInteger data);
        private CommandAIPrototype _CommandAI = WarcraftIII.Jass.GetNative("CommandAI").ToDelegate<CommandAIPrototype>();
        public void CommandAI(JassPlayer num, JassInteger command, JassInteger data)
        {
            _CommandAI(num, command, data);
        }

        //native PauseCompAI takes player p, boolean pause returns nothing
        private delegate void PauseCompAIPrototype(JassPlayer p, JassBoolean pause);
        private PauseCompAIPrototype _PauseCompAI = WarcraftIII.Jass.GetNative("PauseCompAI").ToDelegate<PauseCompAIPrototype>();
        public void PauseCompAI(JassPlayer p, Boolean pause)
        {
            _PauseCompAI(p, pause);
        }

        //native GetAIDifficulty takes player num returns aidifficulty
        private delegate JassAIDifficulty GetAIDifficultyPrototype(JassPlayer num);
        private GetAIDifficultyPrototype _GetAIDifficulty = WarcraftIII.Jass.GetNative("GetAIDifficulty").ToDelegate<GetAIDifficultyPrototype>();
        public JassAIDifficulty GetAIDifficulty(JassPlayer num)
        {
            return _GetAIDifficulty(num);
        }

        //native RemoveGuardPosition takes unit hUnit returns nothing
        private delegate void RemoveGuardPositionPrototype(JassUnit hUnit);
        private RemoveGuardPositionPrototype _RemoveGuardPosition = WarcraftIII.Jass.GetNative("RemoveGuardPosition").ToDelegate<RemoveGuardPositionPrototype>();
        public void RemoveGuardPosition(JassUnit hUnit)
        {
            _RemoveGuardPosition(hUnit);
        }

        //native RecycleGuardPosition takes unit hUnit returns nothing
        private delegate void RecycleGuardPositionPrototype(JassUnit hUnit);
        private RecycleGuardPositionPrototype _RecycleGuardPosition = WarcraftIII.Jass.GetNative("RecycleGuardPosition").ToDelegate<RecycleGuardPositionPrototype>();
        public void RecycleGuardPosition(JassUnit hUnit)
        {
            _RecycleGuardPosition(hUnit);
        }

        //native RemoveAllGuardPositions takes player num returns nothing
        private delegate void RemoveAllGuardPositionsPrototype(JassPlayer num);
        private RemoveAllGuardPositionsPrototype _RemoveAllGuardPositions = WarcraftIII.Jass.GetNative("RemoveAllGuardPositions").ToDelegate<RemoveAllGuardPositionsPrototype>();
        public void RemoveAllGuardPositions(JassPlayer num)
        {
            _RemoveAllGuardPositions(num);
        }

        //native Cheat takes string cheatStr returns nothing
        private delegate void CheatPrototype(JassStringArg cheatStr);
        private CheatPrototype _Cheat = WarcraftIII.Jass.GetNative("Cheat").ToDelegate<CheatPrototype>();
        public void Cheat(String cheatStr)
        {
            _Cheat(cheatStr);
        }

        //native IsNoVictoryCheat takes nothing returns boolean
        private delegate JassBoolean IsNoVictoryCheatPrototype();
        private IsNoVictoryCheatPrototype _IsNoVictoryCheat = WarcraftIII.Jass.GetNative("IsNoVictoryCheat").ToDelegate<IsNoVictoryCheatPrototype>();
        public Boolean IsNoVictoryCheat()
        {
            return _IsNoVictoryCheat();
        }

        //native IsNoDefeatCheat takes nothing returns boolean
        private delegate JassBoolean IsNoDefeatCheatPrototype();
        private IsNoDefeatCheatPrototype _IsNoDefeatCheat = WarcraftIII.Jass.GetNative("IsNoDefeatCheat").ToDelegate<IsNoDefeatCheatPrototype>();
        public Boolean IsNoDefeatCheat()
        {
            return _IsNoDefeatCheat();
        }

        //native Preload takes string filename returns nothing
        private delegate void PreloadPrototype(JassStringArg filename);
        private PreloadPrototype _Preload = WarcraftIII.Jass.GetNative("Preload").ToDelegate<PreloadPrototype>();
        public void Preload(String filename)
        {
            _Preload(filename);
        }

        //native PreloadEnd takes real timeout returns nothing
        private delegate void PreloadEndPrototype(JassRealArg timeout);
        private PreloadEndPrototype _PreloadEnd = WarcraftIII.Jass.GetNative("PreloadEnd").ToDelegate<PreloadEndPrototype>();
        public void PreloadEnd(Single timeout)
        {
            _PreloadEnd(timeout);
        }

        //native PreloadStart takes nothing returns nothing
        private delegate void PreloadStartPrototype();
        private PreloadStartPrototype _PreloadStart = WarcraftIII.Jass.GetNative("PreloadStart").ToDelegate<PreloadStartPrototype>();
        public void PreloadStart()
        {
            _PreloadStart();
        }

        //native PreloadRefresh takes nothing returns nothing
        private delegate void PreloadRefreshPrototype();
        private PreloadRefreshPrototype _PreloadRefresh = WarcraftIII.Jass.GetNative("PreloadRefresh").ToDelegate<PreloadRefreshPrototype>();
        public void PreloadRefresh()
        {
            _PreloadRefresh();
        }

        //native PreloadEndEx takes nothing returns nothing
        private delegate void PreloadEndExPrototype();
        private PreloadEndExPrototype _PreloadEndEx = WarcraftIII.Jass.GetNative("PreloadEndEx").ToDelegate<PreloadEndExPrototype>();
        public void PreloadEndEx()
        {
            _PreloadEndEx();
        }

        //native PreloadGenClear takes nothing returns nothing
        private delegate void PreloadGenClearPrototype();
        private PreloadGenClearPrototype _PreloadGenClear = WarcraftIII.Jass.GetNative("PreloadGenClear").ToDelegate<PreloadGenClearPrototype>();
        public void PreloadGenClear()
        {
            _PreloadGenClear();
        }

        //native PreloadGenStart takes nothing returns nothing
        private delegate void PreloadGenStartPrototype();
        private PreloadGenStartPrototype _PreloadGenStart = WarcraftIII.Jass.GetNative("PreloadGenStart").ToDelegate<PreloadGenStartPrototype>();
        public void PreloadGenStart()
        {
            _PreloadGenStart();
        }

        //native PreloadGenEnd takes string filename returns nothing
        private delegate void PreloadGenEndPrototype(JassStringArg filename);
        private PreloadGenEndPrototype _PreloadGenEnd = WarcraftIII.Jass.GetNative("PreloadGenEnd").ToDelegate<PreloadGenEndPrototype>();
        public void PreloadGenEnd(String filename)
        {
            _PreloadGenEnd(filename);
        }

        //native Preloader takes string filename returns nothing
        private delegate void PreloaderPrototype(JassStringArg filename);
        private PreloaderPrototype _Preloader = WarcraftIII.Jass.GetNative("Preloader").ToDelegate<PreloaderPrototype>();
        public void Preloader(String filename)
        {
            _Preloader(filename);
        }

    }
}
