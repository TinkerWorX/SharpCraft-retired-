using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.FullAPI
{
    public partial class Natives
    {
        public static JassRace ConvertRace(JassInteger i)
        {
            return InternalNatives.ConvertRace(i);
        }
        
        public static JassAllianceType ConvertAllianceType(JassInteger i)
        {
            return InternalNatives.ConvertAllianceType(i);
        }
        
        public static JassRacePreference ConvertRacePref(JassInteger i)
        {
            return InternalNatives.ConvertRacePref(i);
        }
        
        public static JassIGameState ConvertIGameState(JassInteger i)
        {
            return InternalNatives.ConvertIGameState(i);
        }
        
        public static JassFGameState ConvertFGameState(JassInteger i)
        {
            return InternalNatives.ConvertFGameState(i);
        }
        
        public static JassPlayerState ConvertPlayerState(JassInteger i)
        {
            return InternalNatives.ConvertPlayerState(i);
        }
        
        public static JassPlayerScore ConvertPlayerScore(JassInteger i)
        {
            return InternalNatives.ConvertPlayerScore(i);
        }
        
        public static JassPlayerGameResult ConvertPlayerGameResult(JassInteger i)
        {
            return InternalNatives.ConvertPlayerGameResult(i);
        }
        
        public static JassUnitState ConvertUnitState(JassInteger i)
        {
            return InternalNatives.ConvertUnitState(i);
        }
        
        public static JassAIDifficulty ConvertAIDifficulty(JassInteger i)
        {
            return InternalNatives.ConvertAIDifficulty(i);
        }
        
        public static JassGameEvent ConvertGameEvent(JassInteger i)
        {
            return InternalNatives.ConvertGameEvent(i);
        }
        
        public static JassPlayerEvent ConvertPlayerEvent(JassInteger i)
        {
            return InternalNatives.ConvertPlayerEvent(i);
        }
        
        public static JassPlayerUnitEvent ConvertPlayerUnitEvent(JassInteger i)
        {
            return InternalNatives.ConvertPlayerUnitEvent(i);
        }
        
        public static JassWidgetEvent ConvertWidgetEvent(JassInteger i)
        {
            return InternalNatives.ConvertWidgetEvent(i);
        }
        
        public static JassDialogEvent ConvertDialogEvent(JassInteger i)
        {
            return InternalNatives.ConvertDialogEvent(i);
        }
        
        public static JassUnitEvent ConvertUnitEvent(JassInteger i)
        {
            return InternalNatives.ConvertUnitEvent(i);
        }
        
        public static JassLimitOp ConvertLimitOp(JassInteger i)
        {
            return InternalNatives.ConvertLimitOp(i);
        }
        
        public static JassUnitType ConvertUnitType(JassInteger i)
        {
            return InternalNatives.ConvertUnitType(i);
        }
        
        public static JassGameSpeed ConvertGameSpeed(JassInteger i)
        {
            return InternalNatives.ConvertGameSpeed(i);
        }
        
        public static JassPlacement ConvertPlacement(JassInteger i)
        {
            return InternalNatives.ConvertPlacement(i);
        }
        
        public static JassStartLocationPriority ConvertStartLocPrio(JassInteger i)
        {
            return InternalNatives.ConvertStartLocPrio(i);
        }
        
        public static JassGameDifficulty ConvertGameDifficulty(JassInteger i)
        {
            return InternalNatives.ConvertGameDifficulty(i);
        }
        
        public static JassGameType ConvertGameType(JassInteger i)
        {
            return InternalNatives.ConvertGameType(i);
        }
        
        public static JassMapFlag ConvertMapFlag(JassInteger i)
        {
            return InternalNatives.ConvertMapFlag(i);
        }
        
        public static JassMapVisibility ConvertMapVisibility(JassInteger i)
        {
            return InternalNatives.ConvertMapVisibility(i);
        }
        
        public static JassMapSetting ConvertMapSetting(JassInteger i)
        {
            return InternalNatives.ConvertMapSetting(i);
        }
        
        public static JassMapDensity ConvertMapDensity(JassInteger i)
        {
            return InternalNatives.ConvertMapDensity(i);
        }
        
        public static JassMapControl ConvertMapControl(JassInteger i)
        {
            return InternalNatives.ConvertMapControl(i);
        }
        
        public static JassPlayerColor ConvertPlayerColor(JassInteger i)
        {
            return InternalNatives.ConvertPlayerColor(i);
        }
        
        public static JassPlayerSlotState ConvertPlayerSlotState(JassInteger i)
        {
            return InternalNatives.ConvertPlayerSlotState(i);
        }
        
        public static JassVolumeGroup ConvertVolumeGroup(JassInteger i)
        {
            return InternalNatives.ConvertVolumeGroup(i);
        }
        
        public static JassCameraField ConvertCameraField(JassInteger i)
        {
            return InternalNatives.ConvertCameraField(i);
        }
        
        public static JassBlendMode ConvertBlendMode(JassInteger i)
        {
            return InternalNatives.ConvertBlendMode(i);
        }
        
        public static JassRarityControl ConvertRarityControl(JassInteger i)
        {
            return InternalNatives.ConvertRarityControl(i);
        }
        
        public static JassTextureMapFlags ConvertTexMapFlags(JassInteger i)
        {
            return InternalNatives.ConvertTexMapFlags(i);
        }
        
        public static JassFogState ConvertFogState(JassInteger i)
        {
            return InternalNatives.ConvertFogState(i);
        }
        
        public static JassEffectType ConvertEffectType(JassInteger i)
        {
            return InternalNatives.ConvertEffectType(i);
        }
        
        public static JassVersion ConvertVersion(JassInteger i)
        {
            return InternalNatives.ConvertVersion(i);
        }
        
        public static JassItemType ConvertItemType(JassInteger i)
        {
            return InternalNatives.ConvertItemType(i);
        }
        
        public static JassAttackType ConvertAttackType(JassInteger i)
        {
            return InternalNatives.ConvertAttackType(i);
        }
        
        public static JassDamageType ConvertDamageType(JassInteger i)
        {
            return InternalNatives.ConvertDamageType(i);
        }
        
        public static JassWeaponType ConvertWeaponType(JassInteger i)
        {
            return InternalNatives.ConvertWeaponType(i);
        }
        
        public static JassSoundType ConvertSoundType(JassInteger i)
        {
            return InternalNatives.ConvertSoundType(i);
        }
        
        public static JassPathingType ConvertPathingType(JassInteger i)
        {
            return InternalNatives.ConvertPathingType(i);
        }
        
        public static JassOrder OrderId(String orderIdString)
        {
            return InternalNatives.OrderId(orderIdString);
        }
        
        public static String OrderId2String(JassOrder orderId)
        {
            return InternalNatives.OrderId2String(orderId);
        }
        
        public static JassObjectId UnitId(String unitIdString)
        {
            return InternalNatives.UnitId(unitIdString);
        }
        
        public static String UnitId2String(JassObjectId unitId)
        {
            return InternalNatives.UnitId2String(unitId);
        }
        
        public static JassObjectId AbilityId(String abilityIdString)
        {
            return InternalNatives.AbilityId(abilityIdString);
        }
        
        public static String AbilityId2String(JassInteger abilityId)
        {
            return InternalNatives.AbilityId2String(abilityId);
        }
        
        public static String GetObjectName(JassObjectId objectId)
        {
            return InternalNatives.GetObjectName(objectId);
        }
        
        public static Single Deg2Rad(Single degrees)
        {
            return InternalNatives.Deg2Rad(degrees);
        }
        
        public static Single Rad2Deg(Single radians)
        {
            return InternalNatives.Rad2Deg(radians);
        }
        
        public static Single Sin(Single radians)
        {
            return InternalNatives.Sin(radians);
        }
        
        public static Single Cos(Single radians)
        {
            return InternalNatives.Cos(radians);
        }
        
        public static Single Tan(Single radians)
        {
            return InternalNatives.Tan(radians);
        }
        
        public static Single Asin(Single y)
        {
            return InternalNatives.Asin(y);
        }
        
        public static Single Acos(Single x)
        {
            return InternalNatives.Acos(x);
        }
        
        public static Single Atan(Single x)
        {
            return InternalNatives.Atan(x);
        }
        
        public static Single Atan2(Single y, Single x)
        {
            return InternalNatives.Atan2(y, x);
        }
        
        public static Single SquareRoot(Single x)
        {
            return InternalNatives.SquareRoot(x);
        }
        
        public static Single Pow(Single x, Single power)
        {
            return InternalNatives.Pow(x, power);
        }
        
        public static Single I2R(JassInteger i)
        {
            return InternalNatives.I2R(i);
        }
        
        public static JassInteger R2I(Single r)
        {
            return InternalNatives.R2I(r);
        }
        
        public static String I2S(JassInteger i)
        {
            return InternalNatives.I2S(i);
        }
        
        public static String R2S(Single r)
        {
            return InternalNatives.R2S(r);
        }
        
        public static String R2SW(Single r, JassInteger width, JassInteger precision)
        {
            return InternalNatives.R2SW(r, width, precision);
        }
        
        public static JassInteger S2I(String s)
        {
            return InternalNatives.S2I(s);
        }
        
        public static Single S2R(String s)
        {
            return InternalNatives.S2R(s);
        }
        
        public static JassInteger GetHandleId(JassHandle h)
        {
            return InternalNatives.GetHandleId(h);
        }
        
        public static String SubString(String source, JassInteger start, JassInteger end)
        {
            return InternalNatives.SubString(source, start, end);
        }
        
        public static JassInteger StringLength(String s)
        {
            return InternalNatives.StringLength(s);
        }
        
        public static String StringCase(String source, Boolean upper)
        {
            return InternalNatives.StringCase(source, upper);
        }
        
        public static JassInteger StringHash(String s)
        {
            return InternalNatives.StringHash(s);
        }
        
        public static String GetLocalizedString(String source)
        {
            return InternalNatives.GetLocalizedString(source);
        }
        
        public static JassInteger GetLocalizedHotkey(String source)
        {
            return InternalNatives.GetLocalizedHotkey(source);
        }
        
        public static void SetMapName(String name)
        {
            InternalNatives.SetMapName(name);
        }
        
        public static void SetMapDescription(String description)
        {
            InternalNatives.SetMapDescription(description);
        }
        
        public static void SetTeams(JassInteger teamcount)
        {
            InternalNatives.SetTeams(teamcount);
        }
        
        public static void SetPlayers(JassInteger playercount)
        {
            InternalNatives.SetPlayers(playercount);
        }
        
        public static void DefineStartLocation(JassInteger whichStartLoc, Single x, Single y)
        {
            InternalNatives.DefineStartLocation(whichStartLoc, x, y);
        }
        
        public static void DefineStartLocationLoc(JassInteger whichStartLoc, JassLocation whichLocation)
        {
            InternalNatives.DefineStartLocationLoc(whichStartLoc, whichLocation);
        }
        
        public static void SetStartLocPrioCount(JassInteger whichStartLoc, JassInteger prioSlotCount)
        {
            InternalNatives.SetStartLocPrioCount(whichStartLoc, prioSlotCount);
        }
        
        public static void SetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority)
        {
            InternalNatives.SetStartLocPrio(whichStartLoc, prioSlotIndex, otherStartLocIndex, priority);
        }
        
        public static JassInteger GetStartLocPrioSlot(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return InternalNatives.GetStartLocPrioSlot(whichStartLoc, prioSlotIndex);
        }
        
        public static JassStartLocationPriority GetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return InternalNatives.GetStartLocPrio(whichStartLoc, prioSlotIndex);
        }
        
        public static void SetGameTypeSupported(JassGameType whichGameType, Boolean value)
        {
            InternalNatives.SetGameTypeSupported(whichGameType, value);
        }
        
        public static void SetMapFlag(JassMapFlag whichMapFlag, Boolean value)
        {
            InternalNatives.SetMapFlag(whichMapFlag, value);
        }
        
        public static void SetGamePlacement(JassPlacement whichPlacementType)
        {
            InternalNatives.SetGamePlacement(whichPlacementType);
        }
        
        public static void SetGameSpeed(JassGameSpeed whichspeed)
        {
            InternalNatives.SetGameSpeed(whichspeed);
        }
        
        public static void SetGameDifficulty(JassGameDifficulty whichdifficulty)
        {
            InternalNatives.SetGameDifficulty(whichdifficulty);
        }
        
        public static void SetResourceDensity(JassMapDensity whichdensity)
        {
            InternalNatives.SetResourceDensity(whichdensity);
        }
        
        public static void SetCreatureDensity(JassMapDensity whichdensity)
        {
            InternalNatives.SetCreatureDensity(whichdensity);
        }
        
        public static JassInteger GetTeams()
        {
            return InternalNatives.GetTeams();
        }
        
        public static JassInteger GetPlayers()
        {
            return InternalNatives.GetPlayers();
        }
        
        public static Boolean IsGameTypeSupported(JassGameType whichGameType)
        {
            return InternalNatives.IsGameTypeSupported(whichGameType);
        }
        
        public static JassGameType GetGameTypeSelected()
        {
            return InternalNatives.GetGameTypeSelected();
        }
        
        public static Boolean IsMapFlagSet(JassMapFlag whichMapFlag)
        {
            return InternalNatives.IsMapFlagSet(whichMapFlag);
        }
        
        public static JassPlacement GetGamePlacement()
        {
            return InternalNatives.GetGamePlacement();
        }
        
        public static JassGameSpeed GetGameSpeed()
        {
            return InternalNatives.GetGameSpeed();
        }
        
        public static JassGameDifficulty GetGameDifficulty()
        {
            return InternalNatives.GetGameDifficulty();
        }
        
        public static JassMapDensity GetResourceDensity()
        {
            return InternalNatives.GetResourceDensity();
        }
        
        public static JassMapDensity GetCreatureDensity()
        {
            return InternalNatives.GetCreatureDensity();
        }
        
        public static Single GetStartLocationX(JassInteger whichStartLocation)
        {
            return InternalNatives.GetStartLocationX(whichStartLocation);
        }
        
        public static Single GetStartLocationY(JassInteger whichStartLocation)
        {
            return InternalNatives.GetStartLocationY(whichStartLocation);
        }
        
        public static JassLocation GetStartLocationLoc(JassInteger whichStartLocation)
        {
            return InternalNatives.GetStartLocationLoc(whichStartLocation);
        }
        
        public static void SetPlayerTeam(JassPlayer whichPlayer, JassInteger whichTeam)
        {
            InternalNatives.SetPlayerTeam(whichPlayer, whichTeam);
        }
        
        public static void SetPlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            InternalNatives.SetPlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        public static void ForcePlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            InternalNatives.ForcePlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        public static void SetPlayerColor(JassPlayer whichPlayer, JassPlayerColor color)
        {
            InternalNatives.SetPlayerColor(whichPlayer, color);
        }
        
        public static void SetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, Boolean value)
        {
            InternalNatives.SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);
        }
        
        public static void SetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate)
        {
            InternalNatives.SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);
        }
        
        public static void SetPlayerRacePreference(JassPlayer whichPlayer, JassRacePreference whichRacePreference)
        {
            InternalNatives.SetPlayerRacePreference(whichPlayer, whichRacePreference);
        }
        
        public static void SetPlayerRaceSelectable(JassPlayer whichPlayer, Boolean value)
        {
            InternalNatives.SetPlayerRaceSelectable(whichPlayer, value);
        }
        
        public static void SetPlayerController(JassPlayer whichPlayer, JassMapControl controlType)
        {
            InternalNatives.SetPlayerController(whichPlayer, controlType);
        }
        
        public static void SetPlayerName(JassPlayer whichPlayer, String name)
        {
            InternalNatives.SetPlayerName(whichPlayer, name);
        }
        
        public static void SetPlayerOnScoreScreen(JassPlayer whichPlayer, Boolean flag)
        {
            InternalNatives.SetPlayerOnScoreScreen(whichPlayer, flag);
        }
        
        public static JassInteger GetPlayerTeam(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerTeam(whichPlayer);
        }
        
        public static JassInteger GetPlayerStartLocation(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerStartLocation(whichPlayer);
        }
        
        public static JassPlayerColor GetPlayerColor(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerColor(whichPlayer);
        }
        
        public static Boolean GetPlayerSelectable(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerSelectable(whichPlayer);
        }
        
        public static JassMapControl GetPlayerController(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerController(whichPlayer);
        }
        
        public static JassPlayerSlotState GetPlayerSlotState(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerSlotState(whichPlayer);
        }
        
        public static JassInteger GetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource)
        {
            return InternalNatives.GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);
        }
        
        public static Boolean IsPlayerRacePrefSet(JassPlayer whichPlayer, JassRacePreference pref)
        {
            return InternalNatives.IsPlayerRacePrefSet(whichPlayer, pref);
        }
        
        public static String GetPlayerName(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerName(whichPlayer);
        }
        
        public static JassTimer CreateTimer()
        {
            return InternalNatives.CreateTimer();
        }
        
        public static void DestroyTimer(JassTimer whichTimer)
        {
            InternalNatives.DestroyTimer(whichTimer);
        }
        
        public static void TimerStart(JassTimer whichTimer, Single timeout, Boolean periodic, JassCode handlerFunc)
        {
            InternalNatives.TimerStart(whichTimer, timeout, periodic, handlerFunc);
        }
        
        public static Single TimerGetElapsed(JassTimer whichTimer)
        {
            return InternalNatives.TimerGetElapsed(whichTimer);
        }
        
        public static Single TimerGetRemaining(JassTimer whichTimer)
        {
            return InternalNatives.TimerGetRemaining(whichTimer);
        }
        
        public static Single TimerGetTimeout(JassTimer whichTimer)
        {
            return InternalNatives.TimerGetTimeout(whichTimer);
        }
        
        public static void PauseTimer(JassTimer whichTimer)
        {
            InternalNatives.PauseTimer(whichTimer);
        }
        
        public static void ResumeTimer(JassTimer whichTimer)
        {
            InternalNatives.ResumeTimer(whichTimer);
        }
        
        public static JassTimer GetExpiredTimer()
        {
            return InternalNatives.GetExpiredTimer();
        }
        
        public static JassGroup CreateGroup()
        {
            return InternalNatives.CreateGroup();
        }
        
        public static void DestroyGroup(JassGroup whichGroup)
        {
            InternalNatives.DestroyGroup(whichGroup);
        }
        
        public static void GroupAddUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            InternalNatives.GroupAddUnit(whichGroup, whichUnit);
        }
        
        public static void GroupRemoveUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            InternalNatives.GroupRemoveUnit(whichGroup, whichUnit);
        }
        
        public static void GroupClear(JassGroup whichGroup)
        {
            InternalNatives.GroupClear(whichGroup);
        }
        
        public static void GroupEnumUnitsOfType(JassGroup whichGroup, String unitname, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsOfType(whichGroup, unitname, filter);
        }
        
        public static void GroupEnumUnitsOfPlayer(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsOfPlayer(whichGroup, whichPlayer, filter);
        }
        
        public static void GroupEnumUnitsOfTypeCounted(JassGroup whichGroup, String unitname, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.GroupEnumUnitsOfTypeCounted(whichGroup, unitname, filter, countLimit);
        }
        
        public static void GroupEnumUnitsInRect(JassGroup whichGroup, JassRect r, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsInRect(whichGroup, r, filter);
        }
        
        public static void GroupEnumUnitsInRectCounted(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.GroupEnumUnitsInRectCounted(whichGroup, r, filter, countLimit);
        }
        
        public static void GroupEnumUnitsInRange(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsInRange(whichGroup, x, y, radius, filter);
        }
        
        public static void GroupEnumUnitsInRangeOfLoc(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsInRangeOfLoc(whichGroup, whichLocation, radius, filter);
        }
        
        public static void GroupEnumUnitsInRangeCounted(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.GroupEnumUnitsInRangeCounted(whichGroup, x, y, radius, filter, countLimit);
        }
        
        public static void GroupEnumUnitsInRangeOfLocCounted(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.GroupEnumUnitsInRangeOfLocCounted(whichGroup, whichLocation, radius, filter, countLimit);
        }
        
        public static void GroupEnumUnitsSelected(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsSelected(whichGroup, whichPlayer, filter);
        }
        
        public static Boolean GroupImmediateOrder(JassGroup whichGroup, String order)
        {
            return InternalNatives.GroupImmediateOrder(whichGroup, order);
        }
        
        public static Boolean GroupImmediateOrderById(JassGroup whichGroup, JassOrder order)
        {
            return InternalNatives.GroupImmediateOrderById(whichGroup, order);
        }
        
        public static Boolean GroupPointOrder(JassGroup whichGroup, String order, Single x, Single y)
        {
            return InternalNatives.GroupPointOrder(whichGroup, order, x, y);
        }
        
        public static Boolean GroupPointOrderLoc(JassGroup whichGroup, String order, JassLocation whichLocation)
        {
            return InternalNatives.GroupPointOrderLoc(whichGroup, order, whichLocation);
        }
        
        public static Boolean GroupPointOrderById(JassGroup whichGroup, JassOrder order, Single x, Single y)
        {
            return InternalNatives.GroupPointOrderById(whichGroup, order, x, y);
        }
        
        public static Boolean GroupPointOrderByIdLoc(JassGroup whichGroup, JassOrder order, JassLocation whichLocation)
        {
            return InternalNatives.GroupPointOrderByIdLoc(whichGroup, order, whichLocation);
        }
        
        public static Boolean GroupTargetOrder(JassGroup whichGroup, String order, JassWidget targetWidget)
        {
            return InternalNatives.GroupTargetOrder(whichGroup, order, targetWidget);
        }
        
        public static Boolean GroupTargetOrderById(JassGroup whichGroup, JassOrder order, JassWidget targetWidget)
        {
            return InternalNatives.GroupTargetOrderById(whichGroup, order, targetWidget);
        }
        
        public static void ForGroup(JassGroup whichGroup, JassCode callback)
        {
            InternalNatives.ForGroup(whichGroup, callback);
        }
        
        public static JassUnit FirstOfGroup(JassGroup whichGroup)
        {
            return InternalNatives.FirstOfGroup(whichGroup);
        }
        
        public static JassForce CreateForce()
        {
            return InternalNatives.CreateForce();
        }
        
        public static void DestroyForce(JassForce whichForce)
        {
            InternalNatives.DestroyForce(whichForce);
        }
        
        public static void ForceAddPlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            InternalNatives.ForceAddPlayer(whichForce, whichPlayer);
        }
        
        public static void ForceRemovePlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            InternalNatives.ForceRemovePlayer(whichForce, whichPlayer);
        }
        
        public static void ForceClear(JassForce whichForce)
        {
            InternalNatives.ForceClear(whichForce);
        }
        
        public static void ForceEnumPlayers(JassForce whichForce, JassBooleanExpression filter)
        {
            InternalNatives.ForceEnumPlayers(whichForce, filter);
        }
        
        public static void ForceEnumPlayersCounted(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.ForceEnumPlayersCounted(whichForce, filter, countLimit);
        }
        
        public static void ForceEnumAllies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives.ForceEnumAllies(whichForce, whichPlayer, filter);
        }
        
        public static void ForceEnumEnemies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives.ForceEnumEnemies(whichForce, whichPlayer, filter);
        }
        
        public static void ForForce(JassForce whichForce, JassCode callback)
        {
            InternalNatives.ForForce(whichForce, callback);
        }
        
        public static JassRect Rect(Single minx, Single miny, Single maxx, Single maxy)
        {
            return InternalNatives.Rect(minx, miny, maxx, maxy);
        }
        
        public static JassRect RectFromLoc(JassLocation min, JassLocation max)
        {
            return InternalNatives.RectFromLoc(min, max);
        }
        
        public static void RemoveRect(JassRect whichRect)
        {
            InternalNatives.RemoveRect(whichRect);
        }
        
        public static void SetRect(JassRect whichRect, Single minx, Single miny, Single maxx, Single maxy)
        {
            InternalNatives.SetRect(whichRect, minx, miny, maxx, maxy);
        }
        
        public static void SetRectFromLoc(JassRect whichRect, JassLocation min, JassLocation max)
        {
            InternalNatives.SetRectFromLoc(whichRect, min, max);
        }
        
        public static void MoveRectTo(JassRect whichRect, Single newCenterX, Single newCenterY)
        {
            InternalNatives.MoveRectTo(whichRect, newCenterX, newCenterY);
        }
        
        public static void MoveRectToLoc(JassRect whichRect, JassLocation newCenterLoc)
        {
            InternalNatives.MoveRectToLoc(whichRect, newCenterLoc);
        }
        
        public static Single GetRectCenterX(JassRect whichRect)
        {
            return InternalNatives.GetRectCenterX(whichRect);
        }
        
        public static Single GetRectCenterY(JassRect whichRect)
        {
            return InternalNatives.GetRectCenterY(whichRect);
        }
        
        public static Single GetRectMinX(JassRect whichRect)
        {
            return InternalNatives.GetRectMinX(whichRect);
        }
        
        public static Single GetRectMinY(JassRect whichRect)
        {
            return InternalNatives.GetRectMinY(whichRect);
        }
        
        public static Single GetRectMaxX(JassRect whichRect)
        {
            return InternalNatives.GetRectMaxX(whichRect);
        }
        
        public static Single GetRectMaxY(JassRect whichRect)
        {
            return InternalNatives.GetRectMaxY(whichRect);
        }
        
        public static JassRegion CreateRegion()
        {
            return InternalNatives.CreateRegion();
        }
        
        public static void RemoveRegion(JassRegion whichRegion)
        {
            InternalNatives.RemoveRegion(whichRegion);
        }
        
        public static void RegionAddRect(JassRegion whichRegion, JassRect r)
        {
            InternalNatives.RegionAddRect(whichRegion, r);
        }
        
        public static void RegionClearRect(JassRegion whichRegion, JassRect r)
        {
            InternalNatives.RegionClearRect(whichRegion, r);
        }
        
        public static void RegionAddCell(JassRegion whichRegion, Single x, Single y)
        {
            InternalNatives.RegionAddCell(whichRegion, x, y);
        }
        
        public static void RegionAddCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            InternalNatives.RegionAddCellAtLoc(whichRegion, whichLocation);
        }
        
        public static void RegionClearCell(JassRegion whichRegion, Single x, Single y)
        {
            InternalNatives.RegionClearCell(whichRegion, x, y);
        }
        
        public static void RegionClearCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            InternalNatives.RegionClearCellAtLoc(whichRegion, whichLocation);
        }
        
        public static JassLocation Location(Single x, Single y)
        {
            return InternalNatives.Location(x, y);
        }
        
        public static void RemoveLocation(JassLocation whichLocation)
        {
            InternalNatives.RemoveLocation(whichLocation);
        }
        
        public static void MoveLocation(JassLocation whichLocation, Single newX, Single newY)
        {
            InternalNatives.MoveLocation(whichLocation, newX, newY);
        }
        
        public static Single GetLocationX(JassLocation whichLocation)
        {
            return InternalNatives.GetLocationX(whichLocation);
        }
        
        public static Single GetLocationY(JassLocation whichLocation)
        {
            return InternalNatives.GetLocationY(whichLocation);
        }
        
        public static Single GetLocationZ(JassLocation whichLocation)
        {
            return InternalNatives.GetLocationZ(whichLocation);
        }
        
        public static Boolean IsUnitInRegion(JassRegion whichRegion, JassUnit whichUnit)
        {
            return InternalNatives.IsUnitInRegion(whichRegion, whichUnit);
        }
        
        public static Boolean IsPointInRegion(JassRegion whichRegion, Single x, Single y)
        {
            return InternalNatives.IsPointInRegion(whichRegion, x, y);
        }
        
        public static Boolean IsLocationInRegion(JassRegion whichRegion, JassLocation whichLocation)
        {
            return InternalNatives.IsLocationInRegion(whichRegion, whichLocation);
        }
        
        public static JassRect GetWorldBounds()
        {
            return InternalNatives.GetWorldBounds();
        }
        
        public static JassTrigger CreateTrigger()
        {
            return InternalNatives.CreateTrigger();
        }
        
        public static void DestroyTrigger(JassTrigger whichTrigger)
        {
            InternalNatives.DestroyTrigger(whichTrigger);
        }
        
        public static void ResetTrigger(JassTrigger whichTrigger)
        {
            InternalNatives.ResetTrigger(whichTrigger);
        }
        
        public static void EnableTrigger(JassTrigger whichTrigger)
        {
            InternalNatives.EnableTrigger(whichTrigger);
        }
        
        public static void DisableTrigger(JassTrigger whichTrigger)
        {
            InternalNatives.DisableTrigger(whichTrigger);
        }
        
        public static Boolean IsTriggerEnabled(JassTrigger whichTrigger)
        {
            return InternalNatives.IsTriggerEnabled(whichTrigger);
        }
        
        public static void TriggerWaitOnSleeps(JassTrigger whichTrigger, Boolean flag)
        {
            InternalNatives.TriggerWaitOnSleeps(whichTrigger, flag);
        }
        
        public static Boolean IsTriggerWaitOnSleeps(JassTrigger whichTrigger)
        {
            return InternalNatives.IsTriggerWaitOnSleeps(whichTrigger);
        }
        
        public static JassUnit GetFilterUnit()
        {
            return InternalNatives.GetFilterUnit();
        }
        
        public static JassUnit GetEnumUnit()
        {
            return InternalNatives.GetEnumUnit();
        }
        
        public static JassDestructable GetFilterDestructable()
        {
            return InternalNatives.GetFilterDestructable();
        }
        
        public static JassDestructable GetEnumDestructable()
        {
            return InternalNatives.GetEnumDestructable();
        }
        
        public static JassItem GetFilterItem()
        {
            return InternalNatives.GetFilterItem();
        }
        
        public static JassItem GetEnumItem()
        {
            return InternalNatives.GetEnumItem();
        }
        
        public static JassPlayer GetFilterPlayer()
        {
            return InternalNatives.GetFilterPlayer();
        }
        
        public static JassPlayer GetEnumPlayer()
        {
            return InternalNatives.GetEnumPlayer();
        }
        
        public static JassTrigger GetTriggeringTrigger()
        {
            return InternalNatives.GetTriggeringTrigger();
        }
        
        public static JassEventIndex GetTriggerEventId()
        {
            return InternalNatives.GetTriggerEventId();
        }
        
        public static JassInteger GetTriggerEvalCount(JassTrigger whichTrigger)
        {
            return InternalNatives.GetTriggerEvalCount(whichTrigger);
        }
        
        public static JassInteger GetTriggerExecCount(JassTrigger whichTrigger)
        {
            return InternalNatives.GetTriggerExecCount(whichTrigger);
        }
        
        public static void ExecuteFunc(String funcName)
        {
            InternalNatives.ExecuteFunc(funcName);
        }
        
        public static JassBooleanExpression And(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return InternalNatives.And(operandA, operandB);
        }
        
        public static JassBooleanExpression Or(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return InternalNatives.Or(operandA, operandB);
        }
        
        public static JassBooleanExpression Not(JassBooleanExpression operand)
        {
            return InternalNatives.Not(operand);
        }
        
        public static JassConditionFunction Condition(JassCode func)
        {
            return InternalNatives.Condition(func);
        }
        
        public static void DestroyCondition(JassConditionFunction c)
        {
            InternalNatives.DestroyCondition(c);
        }
        
        public static JassFilterFunction Filter(JassCode func)
        {
            return InternalNatives.Filter(func);
        }
        
        public static void DestroyFilter(JassFilterFunction f)
        {
            InternalNatives.DestroyFilter(f);
        }
        
        public static void DestroyBoolExpr(JassBooleanExpression e)
        {
            InternalNatives.DestroyBoolExpr(e);
        }
        
        public static JassEvent TriggerRegisterVariableEvent(JassTrigger whichTrigger, String varName, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives.TriggerRegisterVariableEvent(whichTrigger, varName, opcode, limitval);
        }
        
        public static JassEvent TriggerRegisterTimerEvent(JassTrigger whichTrigger, Single timeout, Boolean periodic)
        {
            return InternalNatives.TriggerRegisterTimerEvent(whichTrigger, timeout, periodic);
        }
        
        public static JassEvent TriggerRegisterTimerExpireEvent(JassTrigger whichTrigger, JassTimer t)
        {
            return InternalNatives.TriggerRegisterTimerExpireEvent(whichTrigger, t);
        }
        
        public static JassEvent TriggerRegisterGameStateEvent(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives.TriggerRegisterGameStateEvent(whichTrigger, whichState, opcode, limitval);
        }
        
        public static JassEvent TriggerRegisterDialogEvent(JassTrigger whichTrigger, JassDialog whichDialog)
        {
            return InternalNatives.TriggerRegisterDialogEvent(whichTrigger, whichDialog);
        }
        
        public static JassEvent TriggerRegisterDialogButtonEvent(JassTrigger whichTrigger, JassButton whichButton)
        {
            return InternalNatives.TriggerRegisterDialogButtonEvent(whichTrigger, whichButton);
        }
        
        public static JassGameState GetEventGameState()
        {
            return InternalNatives.GetEventGameState();
        }
        
        public static JassEvent TriggerRegisterGameEvent(JassTrigger whichTrigger, JassGameEvent whichGameEvent)
        {
            return InternalNatives.TriggerRegisterGameEvent(whichTrigger, whichGameEvent);
        }
        
        public static JassPlayer GetWinningPlayer()
        {
            return InternalNatives.GetWinningPlayer();
        }
        
        public static JassEvent TriggerRegisterEnterRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterEnterRegion(whichTrigger, whichRegion, filter);
        }
        
        public static JassRegion GetTriggeringRegion()
        {
            return InternalNatives.GetTriggeringRegion();
        }
        
        public static JassUnit GetEnteringUnit()
        {
            return InternalNatives.GetEnteringUnit();
        }
        
        public static JassEvent TriggerRegisterLeaveRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterLeaveRegion(whichTrigger, whichRegion, filter);
        }
        
        public static JassUnit GetLeavingUnit()
        {
            return InternalNatives.GetLeavingUnit();
        }
        
        public static JassEvent TriggerRegisterTrackableHitEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return InternalNatives.TriggerRegisterTrackableHitEvent(whichTrigger, t);
        }
        
        public static JassEvent TriggerRegisterTrackableTrackEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return InternalNatives.TriggerRegisterTrackableTrackEvent(whichTrigger, t);
        }
        
        public static JassTrackable GetTriggeringTrackable()
        {
            return InternalNatives.GetTriggeringTrackable();
        }
        
        public static JassButton GetClickedButton()
        {
            return InternalNatives.GetClickedButton();
        }
        
        public static JassDialog GetClickedDialog()
        {
            return InternalNatives.GetClickedDialog();
        }
        
        public static Single GetTournamentFinishSoonTimeRemaining()
        {
            return InternalNatives.GetTournamentFinishSoonTimeRemaining();
        }
        
        public static JassInteger GetTournamentFinishNowRule()
        {
            return InternalNatives.GetTournamentFinishNowRule();
        }
        
        public static JassPlayer GetTournamentFinishNowPlayer()
        {
            return InternalNatives.GetTournamentFinishNowPlayer();
        }
        
        public static JassInteger GetTournamentScore(JassPlayer whichPlayer)
        {
            return InternalNatives.GetTournamentScore(whichPlayer);
        }
        
        public static String GetSaveBasicFilename()
        {
            return InternalNatives.GetSaveBasicFilename();
        }
        
        public static JassEvent TriggerRegisterPlayerEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent)
        {
            return InternalNatives.TriggerRegisterPlayerEvent(whichTrigger, whichPlayer, whichPlayerEvent);
        }
        
        public static JassPlayer GetTriggerPlayer()
        {
            return InternalNatives.GetTriggerPlayer();
        }
        
        public static JassEvent TriggerRegisterPlayerUnitEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterPlayerUnitEvent(whichTrigger, whichPlayer, whichPlayerUnitEvent, filter);
        }
        
        public static JassUnit GetLevelingUnit()
        {
            return InternalNatives.GetLevelingUnit();
        }
        
        public static JassUnit GetLearningUnit()
        {
            return InternalNatives.GetLearningUnit();
        }
        
        public static JassInteger GetLearnedSkill()
        {
            return InternalNatives.GetLearnedSkill();
        }
        
        public static JassInteger GetLearnedSkillLevel()
        {
            return InternalNatives.GetLearnedSkillLevel();
        }
        
        public static JassUnit GetRevivableUnit()
        {
            return InternalNatives.GetRevivableUnit();
        }
        
        public static JassUnit GetRevivingUnit()
        {
            return InternalNatives.GetRevivingUnit();
        }
        
        public static JassUnit GetAttacker()
        {
            return InternalNatives.GetAttacker();
        }
        
        public static JassUnit GetRescuer()
        {
            return InternalNatives.GetRescuer();
        }
        
        public static JassUnit GetDyingUnit()
        {
            return InternalNatives.GetDyingUnit();
        }
        
        public static JassUnit GetKillingUnit()
        {
            return InternalNatives.GetKillingUnit();
        }
        
        public static JassUnit GetDecayingUnit()
        {
            return InternalNatives.GetDecayingUnit();
        }
        
        public static JassUnit GetConstructingStructure()
        {
            return InternalNatives.GetConstructingStructure();
        }
        
        public static JassUnit GetCancelledStructure()
        {
            return InternalNatives.GetCancelledStructure();
        }
        
        public static JassUnit GetConstructedStructure()
        {
            return InternalNatives.GetConstructedStructure();
        }
        
        public static JassUnit GetResearchingUnit()
        {
            return InternalNatives.GetResearchingUnit();
        }
        
        public static JassInteger GetResearched()
        {
            return InternalNatives.GetResearched();
        }
        
        public static JassInteger GetTrainedUnitType()
        {
            return InternalNatives.GetTrainedUnitType();
        }
        
        public static JassUnit GetTrainedUnit()
        {
            return InternalNatives.GetTrainedUnit();
        }
        
        public static JassUnit GetDetectedUnit()
        {
            return InternalNatives.GetDetectedUnit();
        }
        
        public static JassUnit GetSummoningUnit()
        {
            return InternalNatives.GetSummoningUnit();
        }
        
        public static JassUnit GetSummonedUnit()
        {
            return InternalNatives.GetSummonedUnit();
        }
        
        public static JassUnit GetTransportUnit()
        {
            return InternalNatives.GetTransportUnit();
        }
        
        public static JassUnit GetLoadedUnit()
        {
            return InternalNatives.GetLoadedUnit();
        }
        
        public static JassUnit GetSellingUnit()
        {
            return InternalNatives.GetSellingUnit();
        }
        
        public static JassUnit GetSoldUnit()
        {
            return InternalNatives.GetSoldUnit();
        }
        
        public static JassUnit GetBuyingUnit()
        {
            return InternalNatives.GetBuyingUnit();
        }
        
        public static JassItem GetSoldItem()
        {
            return InternalNatives.GetSoldItem();
        }
        
        public static JassUnit GetChangingUnit()
        {
            return InternalNatives.GetChangingUnit();
        }
        
        public static JassPlayer GetChangingUnitPrevOwner()
        {
            return InternalNatives.GetChangingUnitPrevOwner();
        }
        
        public static JassUnit GetManipulatingUnit()
        {
            return InternalNatives.GetManipulatingUnit();
        }
        
        public static JassItem GetManipulatedItem()
        {
            return InternalNatives.GetManipulatedItem();
        }
        
        public static JassUnit GetOrderedUnit()
        {
            return InternalNatives.GetOrderedUnit();
        }
        
        public static JassOrder GetIssuedOrderId()
        {
            return InternalNatives.GetIssuedOrderId();
        }
        
        public static Single GetOrderPointX()
        {
            return InternalNatives.GetOrderPointX();
        }
        
        public static Single GetOrderPointY()
        {
            return InternalNatives.GetOrderPointY();
        }
        
        public static JassLocation GetOrderPointLoc()
        {
            return InternalNatives.GetOrderPointLoc();
        }
        
        public static JassWidget GetOrderTarget()
        {
            return InternalNatives.GetOrderTarget();
        }
        
        public static JassDestructable GetOrderTargetDestructable()
        {
            return InternalNatives.GetOrderTargetDestructable();
        }
        
        public static JassItem GetOrderTargetItem()
        {
            return InternalNatives.GetOrderTargetItem();
        }
        
        public static JassUnit GetOrderTargetUnit()
        {
            return InternalNatives.GetOrderTargetUnit();
        }
        
        public static JassUnit GetSpellAbilityUnit()
        {
            return InternalNatives.GetSpellAbilityUnit();
        }
        
        public static JassObjectId GetSpellAbilityId()
        {
            return InternalNatives.GetSpellAbilityId();
        }
        
        public static JassAbility GetSpellAbility()
        {
            return InternalNatives.GetSpellAbility();
        }
        
        public static JassLocation GetSpellTargetLoc()
        {
            return InternalNatives.GetSpellTargetLoc();
        }
        
        public static Single GetSpellTargetX()
        {
            return InternalNatives.GetSpellTargetX();
        }
        
        public static Single GetSpellTargetY()
        {
            return InternalNatives.GetSpellTargetY();
        }
        
        public static JassDestructable GetSpellTargetDestructable()
        {
            return InternalNatives.GetSpellTargetDestructable();
        }
        
        public static JassItem GetSpellTargetItem()
        {
            return InternalNatives.GetSpellTargetItem();
        }
        
        public static JassUnit GetSpellTargetUnit()
        {
            return InternalNatives.GetSpellTargetUnit();
        }
        
        public static JassEvent TriggerRegisterPlayerAllianceChange(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance)
        {
            return InternalNatives.TriggerRegisterPlayerAllianceChange(whichTrigger, whichPlayer, whichAlliance);
        }
        
        public static JassEvent TriggerRegisterPlayerStateEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives.TriggerRegisterPlayerStateEvent(whichTrigger, whichPlayer, whichState, opcode, limitval);
        }
        
        public static JassPlayerState GetEventPlayerState()
        {
            return InternalNatives.GetEventPlayerState();
        }
        
        public static JassEvent TriggerRegisterPlayerChatEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, String chatMessageToDetect, Boolean exactMatchOnly)
        {
            return InternalNatives.TriggerRegisterPlayerChatEvent(whichTrigger, whichPlayer, chatMessageToDetect, exactMatchOnly);
        }
        
        public static String GetEventPlayerChatString()
        {
            return InternalNatives.GetEventPlayerChatString();
        }
        
        public static String GetEventPlayerChatStringMatched()
        {
            return InternalNatives.GetEventPlayerChatStringMatched();
        }
        
        public static JassEvent TriggerRegisterDeathEvent(JassTrigger whichTrigger, JassWidget whichWidget)
        {
            return InternalNatives.TriggerRegisterDeathEvent(whichTrigger, whichWidget);
        }
        
        public static JassUnit GetTriggerUnit()
        {
            return InternalNatives.GetTriggerUnit();
        }
        
        public static JassEvent TriggerRegisterUnitStateEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives.TriggerRegisterUnitStateEvent(whichTrigger, whichUnit, whichState, opcode, limitval);
        }
        
        public static JassUnitState GetEventUnitState()
        {
            return InternalNatives.GetEventUnitState();
        }
        
        public static JassEvent TriggerRegisterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent)
        {
            return InternalNatives.TriggerRegisterUnitEvent(whichTrigger, whichUnit, whichEvent);
        }
        
        public static Single GetEventDamage()
        {
            return InternalNatives.GetEventDamage();
        }
        
        public static JassUnit GetEventDamageSource()
        {
            return InternalNatives.GetEventDamageSource();
        }
        
        public static JassPlayer GetEventDetectingPlayer()
        {
            return InternalNatives.GetEventDetectingPlayer();
        }
        
        public static JassEvent TriggerRegisterFilterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterFilterUnitEvent(whichTrigger, whichUnit, whichEvent, filter);
        }
        
        public static JassUnit GetEventTargetUnit()
        {
            return InternalNatives.GetEventTargetUnit();
        }
        
        public static JassEvent TriggerRegisterUnitInRange(JassTrigger whichTrigger, JassUnit whichUnit, Single range, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterUnitInRange(whichTrigger, whichUnit, range, filter);
        }
        
        public static JassTriggerCondition TriggerAddCondition(JassTrigger whichTrigger, JassBooleanExpression condition)
        {
            return InternalNatives.TriggerAddCondition(whichTrigger, condition);
        }
        
        public static void TriggerRemoveCondition(JassTrigger whichTrigger, JassTriggerCondition whichCondition)
        {
            InternalNatives.TriggerRemoveCondition(whichTrigger, whichCondition);
        }
        
        public static void TriggerClearConditions(JassTrigger whichTrigger)
        {
            InternalNatives.TriggerClearConditions(whichTrigger);
        }
        
        public static JassTriggerAction TriggerAddAction(JassTrigger whichTrigger, JassCode actionFunc)
        {
            return InternalNatives.TriggerAddAction(whichTrigger, actionFunc);
        }
        
        public static void TriggerRemoveAction(JassTrigger whichTrigger, JassTriggerAction whichAction)
        {
            InternalNatives.TriggerRemoveAction(whichTrigger, whichAction);
        }
        
        public static void TriggerClearActions(JassTrigger whichTrigger)
        {
            InternalNatives.TriggerClearActions(whichTrigger);
        }
        
        public static void TriggerSleepAction(Single timeout)
        {
            InternalNatives.TriggerSleepAction(timeout);
        }
        
        public static void TriggerWaitForSound(JassSound s, Single offset)
        {
            InternalNatives.TriggerWaitForSound(s, offset);
        }
        
        public static Boolean TriggerEvaluate(JassTrigger whichTrigger)
        {
            return InternalNatives.TriggerEvaluate(whichTrigger);
        }
        
        public static void TriggerExecute(JassTrigger whichTrigger)
        {
            InternalNatives.TriggerExecute(whichTrigger);
        }
        
        public static void TriggerExecuteWait(JassTrigger whichTrigger)
        {
            InternalNatives.TriggerExecuteWait(whichTrigger);
        }
        
        public static void TriggerSyncStart()
        {
            InternalNatives.TriggerSyncStart();
        }
        
        public static void TriggerSyncReady()
        {
            InternalNatives.TriggerSyncReady();
        }
        
        public static Single GetWidgetLife(JassWidget whichWidget)
        {
            return InternalNatives.GetWidgetLife(whichWidget);
        }
        
        public static void SetWidgetLife(JassWidget whichWidget, Single newLife)
        {
            InternalNatives.SetWidgetLife(whichWidget, newLife);
        }
        
        public static Single GetWidgetX(JassWidget whichWidget)
        {
            return InternalNatives.GetWidgetX(whichWidget);
        }
        
        public static Single GetWidgetY(JassWidget whichWidget)
        {
            return InternalNatives.GetWidgetY(whichWidget);
        }
        
        public static JassWidget GetTriggerWidget()
        {
            return InternalNatives.GetTriggerWidget();
        }
        
        public static JassDestructable CreateDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives.CreateDestructable(objectid, x, y, face, scale, variation);
        }
        
        public static JassDestructable CreateDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives.CreateDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        public static JassDestructable CreateDeadDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives.CreateDeadDestructable(objectid, x, y, face, scale, variation);
        }
        
        public static JassDestructable CreateDeadDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives.CreateDeadDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        public static void RemoveDestructable(JassDestructable d)
        {
            InternalNatives.RemoveDestructable(d);
        }
        
        public static void KillDestructable(JassDestructable d)
        {
            InternalNatives.KillDestructable(d);
        }
        
        public static void SetDestructableInvulnerable(JassDestructable d, Boolean flag)
        {
            InternalNatives.SetDestructableInvulnerable(d, flag);
        }
        
        public static Boolean IsDestructableInvulnerable(JassDestructable d)
        {
            return InternalNatives.IsDestructableInvulnerable(d);
        }
        
        public static void EnumDestructablesInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            InternalNatives.EnumDestructablesInRect(r, filter, actionFunc);
        }
        
        public static JassObjectId GetDestructableTypeId(JassDestructable d)
        {
            return InternalNatives.GetDestructableTypeId(d);
        }
        
        public static Single GetDestructableX(JassDestructable d)
        {
            return InternalNatives.GetDestructableX(d);
        }
        
        public static Single GetDestructableY(JassDestructable d)
        {
            return InternalNatives.GetDestructableY(d);
        }
        
        public static void SetDestructableLife(JassDestructable d, Single life)
        {
            InternalNatives.SetDestructableLife(d, life);
        }
        
        public static Single GetDestructableLife(JassDestructable d)
        {
            return InternalNatives.GetDestructableLife(d);
        }
        
        public static void SetDestructableMaxLife(JassDestructable d, Single max)
        {
            InternalNatives.SetDestructableMaxLife(d, max);
        }
        
        public static Single GetDestructableMaxLife(JassDestructable d)
        {
            return InternalNatives.GetDestructableMaxLife(d);
        }
        
        public static void DestructableRestoreLife(JassDestructable d, Single life, Boolean birth)
        {
            InternalNatives.DestructableRestoreLife(d, life, birth);
        }
        
        public static void QueueDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            InternalNatives.QueueDestructableAnimation(d, whichAnimation);
        }
        
        public static void SetDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            InternalNatives.SetDestructableAnimation(d, whichAnimation);
        }
        
        public static void SetDestructableAnimationSpeed(JassDestructable d, Single speedFactor)
        {
            InternalNatives.SetDestructableAnimationSpeed(d, speedFactor);
        }
        
        public static void ShowDestructable(JassDestructable d, Boolean flag)
        {
            InternalNatives.ShowDestructable(d, flag);
        }
        
        public static Single GetDestructableOccluderHeight(JassDestructable d)
        {
            return InternalNatives.GetDestructableOccluderHeight(d);
        }
        
        public static void SetDestructableOccluderHeight(JassDestructable d, Single height)
        {
            InternalNatives.SetDestructableOccluderHeight(d, height);
        }
        
        public static String GetDestructableName(JassDestructable d)
        {
            return InternalNatives.GetDestructableName(d);
        }
        
        public static JassDestructable GetTriggerDestructable()
        {
            return InternalNatives.GetTriggerDestructable();
        }
        
        public static JassItem CreateItem(JassObjectId itemid, Single x, Single y)
        {
            return InternalNatives.CreateItem(itemid, x, y);
        }
        
        public static void RemoveItem(JassItem whichItem)
        {
            InternalNatives.RemoveItem(whichItem);
        }
        
        public static JassPlayer GetItemPlayer(JassItem whichItem)
        {
            return InternalNatives.GetItemPlayer(whichItem);
        }
        
        public static JassObjectId GetItemTypeId(JassItem i)
        {
            return InternalNatives.GetItemTypeId(i);
        }
        
        public static Single GetItemX(JassItem i)
        {
            return InternalNatives.GetItemX(i);
        }
        
        public static Single GetItemY(JassItem i)
        {
            return InternalNatives.GetItemY(i);
        }
        
        public static void SetItemPosition(JassItem i, Single x, Single y)
        {
            InternalNatives.SetItemPosition(i, x, y);
        }
        
        public static void SetItemDropOnDeath(JassItem whichItem, Boolean flag)
        {
            InternalNatives.SetItemDropOnDeath(whichItem, flag);
        }
        
        public static void SetItemDroppable(JassItem i, Boolean flag)
        {
            InternalNatives.SetItemDroppable(i, flag);
        }
        
        public static void SetItemPawnable(JassItem i, Boolean flag)
        {
            InternalNatives.SetItemPawnable(i, flag);
        }
        
        public static void SetItemPlayer(JassItem whichItem, JassPlayer whichPlayer, Boolean changeColor)
        {
            InternalNatives.SetItemPlayer(whichItem, whichPlayer, changeColor);
        }
        
        public static void SetItemInvulnerable(JassItem whichItem, Boolean flag)
        {
            InternalNatives.SetItemInvulnerable(whichItem, flag);
        }
        
        public static Boolean IsItemInvulnerable(JassItem whichItem)
        {
            return InternalNatives.IsItemInvulnerable(whichItem);
        }
        
        public static void SetItemVisible(JassItem whichItem, Boolean show)
        {
            InternalNatives.SetItemVisible(whichItem, show);
        }
        
        public static Boolean IsItemVisible(JassItem whichItem)
        {
            return InternalNatives.IsItemVisible(whichItem);
        }
        
        public static Boolean IsItemOwned(JassItem whichItem)
        {
            return InternalNatives.IsItemOwned(whichItem);
        }
        
        public static Boolean IsItemPowerup(JassItem whichItem)
        {
            return InternalNatives.IsItemPowerup(whichItem);
        }
        
        public static Boolean IsItemSellable(JassItem whichItem)
        {
            return InternalNatives.IsItemSellable(whichItem);
        }
        
        public static Boolean IsItemPawnable(JassItem whichItem)
        {
            return InternalNatives.IsItemPawnable(whichItem);
        }
        
        public static Boolean IsItemIdPowerup(JassObjectId itemId)
        {
            return InternalNatives.IsItemIdPowerup(itemId);
        }
        
        public static Boolean IsItemIdSellable(JassObjectId itemId)
        {
            return InternalNatives.IsItemIdSellable(itemId);
        }
        
        public static Boolean IsItemIdPawnable(JassObjectId itemId)
        {
            return InternalNatives.IsItemIdPawnable(itemId);
        }
        
        public static void EnumItemsInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            InternalNatives.EnumItemsInRect(r, filter, actionFunc);
        }
        
        public static JassInteger GetItemLevel(JassItem whichItem)
        {
            return InternalNatives.GetItemLevel(whichItem);
        }
        
        public static JassItemType GetItemType(JassItem whichItem)
        {
            return InternalNatives.GetItemType(whichItem);
        }
        
        public static void SetItemDropID(JassItem whichItem, JassObjectId unitId)
        {
            InternalNatives.SetItemDropID(whichItem, unitId);
        }
        
        public static String GetItemName(JassItem whichItem)
        {
            return InternalNatives.GetItemName(whichItem);
        }
        
        public static JassInteger GetItemCharges(JassItem whichItem)
        {
            return InternalNatives.GetItemCharges(whichItem);
        }
        
        public static void SetItemCharges(JassItem whichItem, JassInteger charges)
        {
            InternalNatives.SetItemCharges(whichItem, charges);
        }
        
        public static JassInteger GetItemUserData(JassItem whichItem)
        {
            return InternalNatives.GetItemUserData(whichItem);
        }
        
        public static void SetItemUserData(JassItem whichItem, JassInteger data)
        {
            InternalNatives.SetItemUserData(whichItem, data);
        }
        
        public static JassUnit CreateUnit(JassPlayer id, JassObjectId unitid, Single x, Single y, Single face)
        {
            return InternalNatives.CreateUnit(id, unitid, x, y, face);
        }
        
        public static JassUnit CreateUnitByName(JassPlayer whichPlayer, String unitname, Single x, Single y, Single face)
        {
            return InternalNatives.CreateUnitByName(whichPlayer, unitname, x, y, face);
        }
        
        public static JassUnit CreateUnitAtLoc(JassPlayer id, JassObjectId unitid, JassLocation whichLocation, Single face)
        {
            return InternalNatives.CreateUnitAtLoc(id, unitid, whichLocation, face);
        }
        
        public static JassUnit CreateUnitAtLocByName(JassPlayer id, String unitname, JassLocation whichLocation, Single face)
        {
            return InternalNatives.CreateUnitAtLocByName(id, unitname, whichLocation, face);
        }
        
        public static JassUnit CreateCorpse(JassPlayer whichPlayer, JassObjectId unitid, Single x, Single y, Single face)
        {
            return InternalNatives.CreateCorpse(whichPlayer, unitid, x, y, face);
        }
        
        public static void KillUnit(JassUnit whichUnit)
        {
            InternalNatives.KillUnit(whichUnit);
        }
        
        public static void RemoveUnit(JassUnit whichUnit)
        {
            InternalNatives.RemoveUnit(whichUnit);
        }
        
        public static void ShowUnit(JassUnit whichUnit, Boolean show)
        {
            InternalNatives.ShowUnit(whichUnit, show);
        }
        
        public static void SetUnitState(JassUnit whichUnit, JassUnitState whichUnitState, Single newVal)
        {
            InternalNatives.SetUnitState(whichUnit, whichUnitState, newVal);
        }
        
        public static void SetUnitX(JassUnit whichUnit, Single newX)
        {
            InternalNatives.SetUnitX(whichUnit, newX);
        }
        
        public static void SetUnitY(JassUnit whichUnit, Single newY)
        {
            InternalNatives.SetUnitY(whichUnit, newY);
        }
        
        public static void SetUnitPosition(JassUnit whichUnit, Single newX, Single newY)
        {
            InternalNatives.SetUnitPosition(whichUnit, newX, newY);
        }
        
        public static void SetUnitPositionLoc(JassUnit whichUnit, JassLocation whichLocation)
        {
            InternalNatives.SetUnitPositionLoc(whichUnit, whichLocation);
        }
        
        public static void SetUnitFacing(JassUnit whichUnit, Single facingAngle)
        {
            InternalNatives.SetUnitFacing(whichUnit, facingAngle);
        }
        
        public static void SetUnitFacingTimed(JassUnit whichUnit, Single facingAngle, Single duration)
        {
            InternalNatives.SetUnitFacingTimed(whichUnit, facingAngle, duration);
        }
        
        public static void SetUnitMoveSpeed(JassUnit whichUnit, Single newSpeed)
        {
            InternalNatives.SetUnitMoveSpeed(whichUnit, newSpeed);
        }
        
        public static void SetUnitFlyHeight(JassUnit whichUnit, Single newHeight, Single rate)
        {
            InternalNatives.SetUnitFlyHeight(whichUnit, newHeight, rate);
        }
        
        public static void SetUnitTurnSpeed(JassUnit whichUnit, Single newTurnSpeed)
        {
            InternalNatives.SetUnitTurnSpeed(whichUnit, newTurnSpeed);
        }
        
        public static void SetUnitPropWindow(JassUnit whichUnit, Single newPropWindowAngle)
        {
            InternalNatives.SetUnitPropWindow(whichUnit, newPropWindowAngle);
        }
        
        public static void SetUnitAcquireRange(JassUnit whichUnit, Single newAcquireRange)
        {
            InternalNatives.SetUnitAcquireRange(whichUnit, newAcquireRange);
        }
        
        public static void SetUnitCreepGuard(JassUnit whichUnit, Boolean creepGuard)
        {
            InternalNatives.SetUnitCreepGuard(whichUnit, creepGuard);
        }
        
        public static Single GetUnitAcquireRange(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitAcquireRange(whichUnit);
        }
        
        public static Single GetUnitTurnSpeed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitTurnSpeed(whichUnit);
        }
        
        public static Single GetUnitPropWindow(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitPropWindow(whichUnit);
        }
        
        public static Single GetUnitFlyHeight(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitFlyHeight(whichUnit);
        }
        
        public static Single GetUnitDefaultAcquireRange(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultAcquireRange(whichUnit);
        }
        
        public static Single GetUnitDefaultTurnSpeed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultTurnSpeed(whichUnit);
        }
        
        public static Single GetUnitDefaultPropWindow(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultPropWindow(whichUnit);
        }
        
        public static Single GetUnitDefaultFlyHeight(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultFlyHeight(whichUnit);
        }
        
        public static void SetUnitOwner(JassUnit whichUnit, JassPlayer whichPlayer, Boolean changeColor)
        {
            InternalNatives.SetUnitOwner(whichUnit, whichPlayer, changeColor);
        }
        
        public static void SetUnitColor(JassUnit whichUnit, JassPlayerColor whichColor)
        {
            InternalNatives.SetUnitColor(whichUnit, whichColor);
        }
        
        public static void SetUnitScale(JassUnit whichUnit, Single scaleX, Single scaleY, Single scaleZ)
        {
            InternalNatives.SetUnitScale(whichUnit, scaleX, scaleY, scaleZ);
        }
        
        public static void SetUnitTimeScale(JassUnit whichUnit, Single timeScale)
        {
            InternalNatives.SetUnitTimeScale(whichUnit, timeScale);
        }
        
        public static void SetUnitBlendTime(JassUnit whichUnit, Single blendTime)
        {
            InternalNatives.SetUnitBlendTime(whichUnit, blendTime);
        }
        
        public static void SetUnitVertexColor(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetUnitVertexColor(whichUnit, red, green, blue, alpha);
        }
        
        public static void QueueUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            InternalNatives.QueueUnitAnimation(whichUnit, whichAnimation);
        }
        
        public static void SetUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            InternalNatives.SetUnitAnimation(whichUnit, whichAnimation);
        }
        
        public static void SetUnitAnimationByIndex(JassUnit whichUnit, JassInteger whichAnimation)
        {
            InternalNatives.SetUnitAnimationByIndex(whichUnit, whichAnimation);
        }
        
        public static void SetUnitAnimationWithRarity(JassUnit whichUnit, String whichAnimation, JassRarityControl rarity)
        {
            InternalNatives.SetUnitAnimationWithRarity(whichUnit, whichAnimation, rarity);
        }
        
        public static void AddUnitAnimationProperties(JassUnit whichUnit, String animProperties, Boolean add)
        {
            InternalNatives.AddUnitAnimationProperties(whichUnit, animProperties, add);
        }
        
        public static void SetUnitLookAt(JassUnit whichUnit, String whichBone, JassUnit lookAtTarget, Single offsetX, Single offsetY, Single offsetZ)
        {
            InternalNatives.SetUnitLookAt(whichUnit, whichBone, lookAtTarget, offsetX, offsetY, offsetZ);
        }
        
        public static void ResetUnitLookAt(JassUnit whichUnit)
        {
            InternalNatives.ResetUnitLookAt(whichUnit);
        }
        
        public static void SetUnitRescuable(JassUnit whichUnit, JassPlayer byWhichPlayer, Boolean flag)
        {
            InternalNatives.SetUnitRescuable(whichUnit, byWhichPlayer, flag);
        }
        
        public static void SetUnitRescueRange(JassUnit whichUnit, Single range)
        {
            InternalNatives.SetUnitRescueRange(whichUnit, range);
        }
        
        public static void SetHeroStr(JassUnit whichHero, JassInteger newStr, Boolean permanent)
        {
            InternalNatives.SetHeroStr(whichHero, newStr, permanent);
        }
        
        public static void SetHeroAgi(JassUnit whichHero, JassInteger newAgi, Boolean permanent)
        {
            InternalNatives.SetHeroAgi(whichHero, newAgi, permanent);
        }
        
        public static void SetHeroInt(JassUnit whichHero, JassInteger newInt, Boolean permanent)
        {
            InternalNatives.SetHeroInt(whichHero, newInt, permanent);
        }
        
        public static JassInteger GetHeroStr(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives.GetHeroStr(whichHero, includeBonuses);
        }
        
        public static JassInteger GetHeroAgi(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives.GetHeroAgi(whichHero, includeBonuses);
        }
        
        public static JassInteger GetHeroInt(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives.GetHeroInt(whichHero, includeBonuses);
        }
        
        public static Boolean UnitStripHeroLevel(JassUnit whichHero, JassInteger howManyLevels)
        {
            return InternalNatives.UnitStripHeroLevel(whichHero, howManyLevels);
        }
        
        public static JassInteger GetHeroXP(JassUnit whichHero)
        {
            return InternalNatives.GetHeroXP(whichHero);
        }
        
        public static void SetHeroXP(JassUnit whichHero, JassInteger newXpVal, Boolean showEyeCandy)
        {
            InternalNatives.SetHeroXP(whichHero, newXpVal, showEyeCandy);
        }
        
        public static JassInteger GetHeroSkillPoints(JassUnit whichHero)
        {
            return InternalNatives.GetHeroSkillPoints(whichHero);
        }
        
        public static Boolean UnitModifySkillPoints(JassUnit whichHero, JassInteger skillPointDelta)
        {
            return InternalNatives.UnitModifySkillPoints(whichHero, skillPointDelta);
        }
        
        public static void AddHeroXP(JassUnit whichHero, JassInteger xpToAdd, Boolean showEyeCandy)
        {
            InternalNatives.AddHeroXP(whichHero, xpToAdd, showEyeCandy);
        }
        
        public static void SetHeroLevel(JassUnit whichHero, JassInteger level, Boolean showEyeCandy)
        {
            InternalNatives.SetHeroLevel(whichHero, level, showEyeCandy);
        }
        
        public static JassInteger GetHeroLevel(JassUnit whichHero)
        {
            return InternalNatives.GetHeroLevel(whichHero);
        }
        
        public static JassInteger GetUnitLevel(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitLevel(whichUnit);
        }
        
        public static String GetHeroProperName(JassUnit whichHero)
        {
            return InternalNatives.GetHeroProperName(whichHero);
        }
        
        public static void SuspendHeroXP(JassUnit whichHero, Boolean flag)
        {
            InternalNatives.SuspendHeroXP(whichHero, flag);
        }
        
        public static Boolean IsSuspendedXP(JassUnit whichHero)
        {
            return InternalNatives.IsSuspendedXP(whichHero);
        }
        
        public static void SelectHeroSkill(JassUnit whichHero, JassObjectId abilcode)
        {
            InternalNatives.SelectHeroSkill(whichHero, abilcode);
        }
        
        public static JassInteger GetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives.GetUnitAbilityLevel(whichUnit, abilcode);
        }
        
        public static JassInteger DecUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives.DecUnitAbilityLevel(whichUnit, abilcode);
        }
        
        public static JassInteger IncUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives.IncUnitAbilityLevel(whichUnit, abilcode);
        }
        
        public static JassInteger SetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode, JassInteger level)
        {
            return InternalNatives.SetUnitAbilityLevel(whichUnit, abilcode, level);
        }
        
        public static Boolean ReviveHero(JassUnit whichHero, Single x, Single y, Boolean doEyecandy)
        {
            return InternalNatives.ReviveHero(whichHero, x, y, doEyecandy);
        }
        
        public static Boolean ReviveHeroLoc(JassUnit whichHero, JassLocation loc, Boolean doEyecandy)
        {
            return InternalNatives.ReviveHeroLoc(whichHero, loc, doEyecandy);
        }
        
        public static void SetUnitExploded(JassUnit whichUnit, Boolean exploded)
        {
            InternalNatives.SetUnitExploded(whichUnit, exploded);
        }
        
        public static void SetUnitInvulnerable(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.SetUnitInvulnerable(whichUnit, flag);
        }
        
        public static void PauseUnit(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.PauseUnit(whichUnit, flag);
        }
        
        public static Boolean IsUnitPaused(JassUnit whichHero)
        {
            return InternalNatives.IsUnitPaused(whichHero);
        }
        
        public static void SetUnitPathing(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.SetUnitPathing(whichUnit, flag);
        }
        
        public static void ClearSelection()
        {
            InternalNatives.ClearSelection();
        }
        
        public static void SelectUnit(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.SelectUnit(whichUnit, flag);
        }
        
        public static JassInteger GetUnitPointValue(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitPointValue(whichUnit);
        }
        
        public static JassInteger GetUnitPointValueByType(JassInteger unitType)
        {
            return InternalNatives.GetUnitPointValueByType(unitType);
        }
        
        public static Boolean UnitAddItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives.UnitAddItem(whichUnit, whichItem);
        }
        
        public static JassItem UnitAddItemById(JassUnit whichUnit, JassObjectId itemId)
        {
            return InternalNatives.UnitAddItemById(whichUnit, itemId);
        }
        
        public static Boolean UnitAddItemToSlotById(JassUnit whichUnit, JassObjectId itemId, JassInteger itemSlot)
        {
            return InternalNatives.UnitAddItemToSlotById(whichUnit, itemId, itemSlot);
        }
        
        public static void UnitRemoveItem(JassUnit whichUnit, JassItem whichItem)
        {
            InternalNatives.UnitRemoveItem(whichUnit, whichItem);
        }
        
        public static JassItem UnitRemoveItemFromSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return InternalNatives.UnitRemoveItemFromSlot(whichUnit, itemSlot);
        }
        
        public static Boolean UnitHasItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives.UnitHasItem(whichUnit, whichItem);
        }
        
        public static JassItem UnitItemInSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return InternalNatives.UnitItemInSlot(whichUnit, itemSlot);
        }
        
        public static JassInteger UnitInventorySize(JassUnit whichUnit)
        {
            return InternalNatives.UnitInventorySize(whichUnit);
        }
        
        public static Boolean UnitDropItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return InternalNatives.UnitDropItemPoint(whichUnit, whichItem, x, y);
        }
        
        public static Boolean UnitDropItemSlot(JassUnit whichUnit, JassItem whichItem, JassInteger slot)
        {
            return InternalNatives.UnitDropItemSlot(whichUnit, whichItem, slot);
        }
        
        public static Boolean UnitDropItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return InternalNatives.UnitDropItemTarget(whichUnit, whichItem, target);
        }
        
        public static Boolean UnitUseItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives.UnitUseItem(whichUnit, whichItem);
        }
        
        public static Boolean UnitUseItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return InternalNatives.UnitUseItemPoint(whichUnit, whichItem, x, y);
        }
        
        public static Boolean UnitUseItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return InternalNatives.UnitUseItemTarget(whichUnit, whichItem, target);
        }
        
        public static Single GetUnitX(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitX(whichUnit);
        }
        
        public static Single GetUnitY(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitY(whichUnit);
        }
        
        public static JassLocation GetUnitLoc(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitLoc(whichUnit);
        }
        
        public static Single GetUnitFacing(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitFacing(whichUnit);
        }
        
        public static Single GetUnitMoveSpeed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitMoveSpeed(whichUnit);
        }
        
        public static Single GetUnitDefaultMoveSpeed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultMoveSpeed(whichUnit);
        }
        
        public static Single GetUnitState(JassUnit whichUnit, JassUnitState whichUnitState)
        {
            return InternalNatives.GetUnitState(whichUnit, whichUnitState);
        }
        
        public static JassPlayer GetOwningPlayer(JassUnit whichUnit)
        {
            return InternalNatives.GetOwningPlayer(whichUnit);
        }
        
        public static JassObjectId GetUnitTypeId(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitTypeId(whichUnit);
        }
        
        public static JassRace GetUnitRace(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitRace(whichUnit);
        }
        
        public static String GetUnitName(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitName(whichUnit);
        }
        
        public static JassInteger GetUnitFoodUsed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitFoodUsed(whichUnit);
        }
        
        public static JassInteger GetUnitFoodMade(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitFoodMade(whichUnit);
        }
        
        public static JassInteger GetFoodMade(JassObjectId unitId)
        {
            return InternalNatives.GetFoodMade(unitId);
        }
        
        public static JassInteger GetFoodUsed(JassObjectId unitId)
        {
            return InternalNatives.GetFoodUsed(unitId);
        }
        
        public static void SetUnitUseFood(JassUnit whichUnit, Boolean useFood)
        {
            InternalNatives.SetUnitUseFood(whichUnit, useFood);
        }
        
        public static JassLocation GetUnitRallyPoint(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitRallyPoint(whichUnit);
        }
        
        public static JassUnit GetUnitRallyUnit(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitRallyUnit(whichUnit);
        }
        
        public static JassDestructable GetUnitRallyDestructable(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitRallyDestructable(whichUnit);
        }
        
        public static Boolean IsUnitInGroup(JassUnit whichUnit, JassGroup whichGroup)
        {
            return InternalNatives.IsUnitInGroup(whichUnit, whichGroup);
        }
        
        public static Boolean IsUnitInForce(JassUnit whichUnit, JassForce whichForce)
        {
            return InternalNatives.IsUnitInForce(whichUnit, whichForce);
        }
        
        public static Boolean IsUnitOwnedByPlayer(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitOwnedByPlayer(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitAlly(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitAlly(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitEnemy(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitEnemy(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitVisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitVisible(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitDetected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitDetected(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitInvisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitInvisible(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitFogged(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitFogged(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitMasked(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitMasked(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitSelected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitSelected(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitRace(JassUnit whichUnit, JassRace whichRace)
        {
            return InternalNatives.IsUnitRace(whichUnit, whichRace);
        }
        
        public static Boolean IsUnitType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives.IsUnitType(whichUnit, whichUnitType);
        }
        
        public static Boolean IsUnit(JassUnit whichUnit, JassUnit whichSpecifiedUnit)
        {
            return InternalNatives.IsUnit(whichUnit, whichSpecifiedUnit);
        }
        
        public static Boolean IsUnitInRange(JassUnit whichUnit, JassUnit otherUnit, Single distance)
        {
            return InternalNatives.IsUnitInRange(whichUnit, otherUnit, distance);
        }
        
        public static Boolean IsUnitInRangeXY(JassUnit whichUnit, Single x, Single y, Single distance)
        {
            return InternalNatives.IsUnitInRangeXY(whichUnit, x, y, distance);
        }
        
        public static Boolean IsUnitInRangeLoc(JassUnit whichUnit, JassLocation whichLocation, Single distance)
        {
            return InternalNatives.IsUnitInRangeLoc(whichUnit, whichLocation, distance);
        }
        
        public static Boolean IsUnitHidden(JassUnit whichUnit)
        {
            return InternalNatives.IsUnitHidden(whichUnit);
        }
        
        public static Boolean IsUnitIllusion(JassUnit whichUnit)
        {
            return InternalNatives.IsUnitIllusion(whichUnit);
        }
        
        public static Boolean IsUnitInTransport(JassUnit whichUnit, JassUnit whichTransport)
        {
            return InternalNatives.IsUnitInTransport(whichUnit, whichTransport);
        }
        
        public static Boolean IsUnitLoaded(JassUnit whichUnit)
        {
            return InternalNatives.IsUnitLoaded(whichUnit);
        }
        
        public static Boolean IsHeroUnitId(JassObjectId unitId)
        {
            return InternalNatives.IsHeroUnitId(unitId);
        }
        
        public static Boolean IsUnitIdType(JassObjectId unitId, JassUnitType whichUnitType)
        {
            return InternalNatives.IsUnitIdType(unitId, whichUnitType);
        }
        
        public static void UnitShareVision(JassUnit whichUnit, JassPlayer whichPlayer, Boolean share)
        {
            InternalNatives.UnitShareVision(whichUnit, whichPlayer, share);
        }
        
        public static void UnitSuspendDecay(JassUnit whichUnit, Boolean suspend)
        {
            InternalNatives.UnitSuspendDecay(whichUnit, suspend);
        }
        
        public static Boolean UnitAddType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives.UnitAddType(whichUnit, whichUnitType);
        }
        
        public static Boolean UnitRemoveType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives.UnitRemoveType(whichUnit, whichUnitType);
        }
        
        public static Boolean UnitAddAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return InternalNatives.UnitAddAbility(whichUnit, abilityId);
        }
        
        public static Boolean UnitRemoveAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return InternalNatives.UnitRemoveAbility(whichUnit, abilityId);
        }
        
        public static Boolean UnitMakeAbilityPermanent(JassUnit whichUnit, Boolean permanent, JassInteger abilityId)
        {
            return InternalNatives.UnitMakeAbilityPermanent(whichUnit, permanent, abilityId);
        }
        
        public static void UnitRemoveBuffs(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative)
        {
            InternalNatives.UnitRemoveBuffs(whichUnit, removePositive, removeNegative);
        }
        
        public static void UnitRemoveBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            InternalNatives.UnitRemoveBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        public static Boolean UnitHasBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return InternalNatives.UnitHasBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        public static JassInteger UnitCountBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return InternalNatives.UnitCountBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        public static void UnitAddSleep(JassUnit whichUnit, Boolean add)
        {
            InternalNatives.UnitAddSleep(whichUnit, add);
        }
        
        public static Boolean UnitCanSleep(JassUnit whichUnit)
        {
            return InternalNatives.UnitCanSleep(whichUnit);
        }
        
        public static void UnitAddSleepPerm(JassUnit whichUnit, Boolean add)
        {
            InternalNatives.UnitAddSleepPerm(whichUnit, add);
        }
        
        public static Boolean UnitCanSleepPerm(JassUnit whichUnit)
        {
            return InternalNatives.UnitCanSleepPerm(whichUnit);
        }
        
        public static Boolean UnitIsSleeping(JassUnit whichUnit)
        {
            return InternalNatives.UnitIsSleeping(whichUnit);
        }
        
        public static void UnitWakeUp(JassUnit whichUnit)
        {
            InternalNatives.UnitWakeUp(whichUnit);
        }
        
        public static void UnitApplyTimedLife(JassUnit whichUnit, JassInteger buffId, Single duration)
        {
            InternalNatives.UnitApplyTimedLife(whichUnit, buffId, duration);
        }
        
        public static Boolean UnitIgnoreAlarm(JassUnit whichUnit, Boolean flag)
        {
            return InternalNatives.UnitIgnoreAlarm(whichUnit, flag);
        }
        
        public static Boolean UnitIgnoreAlarmToggled(JassUnit whichUnit)
        {
            return InternalNatives.UnitIgnoreAlarmToggled(whichUnit);
        }
        
        public static void UnitResetCooldown(JassUnit whichUnit)
        {
            InternalNatives.UnitResetCooldown(whichUnit);
        }
        
        public static void UnitSetConstructionProgress(JassUnit whichUnit, JassInteger constructionPercentage)
        {
            InternalNatives.UnitSetConstructionProgress(whichUnit, constructionPercentage);
        }
        
        public static void UnitSetUpgradeProgress(JassUnit whichUnit, JassInteger upgradePercentage)
        {
            InternalNatives.UnitSetUpgradeProgress(whichUnit, upgradePercentage);
        }
        
        public static void UnitPauseTimedLife(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.UnitPauseTimedLife(whichUnit, flag);
        }
        
        public static void UnitSetUsesAltIcon(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.UnitSetUsesAltIcon(whichUnit, flag);
        }
        
        public static Boolean UnitDamagePoint(JassUnit whichUnit, Single delay, Single radius, Single x, Single y, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return InternalNatives.UnitDamagePoint(whichUnit, delay, radius, x, y, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        public static Boolean UnitDamageTarget(JassUnit whichUnit, JassWidget target, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return InternalNatives.UnitDamageTarget(whichUnit, target, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        public static Boolean IssueImmediateOrder(JassUnit whichUnit, String order)
        {
            return InternalNatives.IssueImmediateOrder(whichUnit, order);
        }
        
        public static Boolean IssueImmediateOrderById(JassUnit whichUnit, JassOrder order)
        {
            return InternalNatives.IssueImmediateOrderById(whichUnit, order);
        }
        
        public static Boolean IssuePointOrder(JassUnit whichUnit, String order, Single x, Single y)
        {
            return InternalNatives.IssuePointOrder(whichUnit, order, x, y);
        }
        
        public static Boolean IssuePointOrderLoc(JassUnit whichUnit, String order, JassLocation whichLocation)
        {
            return InternalNatives.IssuePointOrderLoc(whichUnit, order, whichLocation);
        }
        
        public static Boolean IssuePointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y)
        {
            return InternalNatives.IssuePointOrderById(whichUnit, order, x, y);
        }
        
        public static Boolean IssuePointOrderByIdLoc(JassUnit whichUnit, JassOrder order, JassLocation whichLocation)
        {
            return InternalNatives.IssuePointOrderByIdLoc(whichUnit, order, whichLocation);
        }
        
        public static Boolean IssueTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget)
        {
            return InternalNatives.IssueTargetOrder(whichUnit, order, targetWidget);
        }
        
        public static Boolean IssueTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget)
        {
            return InternalNatives.IssueTargetOrderById(whichUnit, order, targetWidget);
        }
        
        public static Boolean IssueInstantPointOrder(JassUnit whichUnit, String order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return InternalNatives.IssueInstantPointOrder(whichUnit, order, x, y, instantTargetWidget);
        }
        
        public static Boolean IssueInstantPointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return InternalNatives.IssueInstantPointOrderById(whichUnit, order, x, y, instantTargetWidget);
        }
        
        public static Boolean IssueInstantTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return InternalNatives.IssueInstantTargetOrder(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        public static Boolean IssueInstantTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return InternalNatives.IssueInstantTargetOrderById(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        public static Boolean IssueBuildOrder(JassUnit whichPeon, String unitToBuild, Single x, Single y)
        {
            return InternalNatives.IssueBuildOrder(whichPeon, unitToBuild, x, y);
        }
        
        public static Boolean IssueBuildOrderById(JassUnit whichPeon, JassObjectId unitId, Single x, Single y)
        {
            return InternalNatives.IssueBuildOrderById(whichPeon, unitId, x, y);
        }
        
        public static Boolean IssueNeutralImmediateOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild)
        {
            return InternalNatives.IssueNeutralImmediateOrder(forWhichPlayer, neutralStructure, unitToBuild);
        }
        
        public static Boolean IssueNeutralImmediateOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId)
        {
            return InternalNatives.IssueNeutralImmediateOrderById(forWhichPlayer, neutralStructure, unitId);
        }
        
        public static Boolean IssueNeutralPointOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, Single x, Single y)
        {
            return InternalNatives.IssueNeutralPointOrder(forWhichPlayer, neutralStructure, unitToBuild, x, y);
        }
        
        public static Boolean IssueNeutralPointOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, Single x, Single y)
        {
            return InternalNatives.IssueNeutralPointOrderById(forWhichPlayer, neutralStructure, unitId, x, y);
        }
        
        public static Boolean IssueNeutralTargetOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassWidget target)
        {
            return InternalNatives.IssueNeutralTargetOrder(forWhichPlayer, neutralStructure, unitToBuild, target);
        }
        
        public static Boolean IssueNeutralTargetOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassWidget target)
        {
            return InternalNatives.IssueNeutralTargetOrderById(forWhichPlayer, neutralStructure, unitId, target);
        }
        
        public static JassInteger GetUnitCurrentOrder(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitCurrentOrder(whichUnit);
        }
        
        public static void SetResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            InternalNatives.SetResourceAmount(whichUnit, amount);
        }
        
        public static void AddResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            InternalNatives.AddResourceAmount(whichUnit, amount);
        }
        
        public static JassInteger GetResourceAmount(JassUnit whichUnit)
        {
            return InternalNatives.GetResourceAmount(whichUnit);
        }
        
        public static Single WaygateGetDestinationX(JassUnit waygate)
        {
            return InternalNatives.WaygateGetDestinationX(waygate);
        }
        
        public static Single WaygateGetDestinationY(JassUnit waygate)
        {
            return InternalNatives.WaygateGetDestinationY(waygate);
        }
        
        public static void WaygateSetDestination(JassUnit waygate, Single x, Single y)
        {
            InternalNatives.WaygateSetDestination(waygate, x, y);
        }
        
        public static void WaygateActivate(JassUnit waygate, Boolean activate)
        {
            InternalNatives.WaygateActivate(waygate, activate);
        }
        
        public static Boolean WaygateIsActive(JassUnit waygate)
        {
            return InternalNatives.WaygateIsActive(waygate);
        }
        
        public static void AddItemToAllStock(JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives.AddItemToAllStock(itemId, currentStock, stockMax);
        }
        
        public static void AddItemToStock(JassUnit whichUnit, JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives.AddItemToStock(whichUnit, itemId, currentStock, stockMax);
        }
        
        public static void AddUnitToAllStock(JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives.AddUnitToAllStock(unitId, currentStock, stockMax);
        }
        
        public static void AddUnitToStock(JassUnit whichUnit, JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives.AddUnitToStock(whichUnit, unitId, currentStock, stockMax);
        }
        
        public static void RemoveItemFromAllStock(JassObjectId itemId)
        {
            InternalNatives.RemoveItemFromAllStock(itemId);
        }
        
        public static void RemoveItemFromStock(JassUnit whichUnit, JassObjectId itemId)
        {
            InternalNatives.RemoveItemFromStock(whichUnit, itemId);
        }
        
        public static void RemoveUnitFromAllStock(JassObjectId unitId)
        {
            InternalNatives.RemoveUnitFromAllStock(unitId);
        }
        
        public static void RemoveUnitFromStock(JassUnit whichUnit, JassObjectId unitId)
        {
            InternalNatives.RemoveUnitFromStock(whichUnit, unitId);
        }
        
        public static void SetAllItemTypeSlots(JassInteger slots)
        {
            InternalNatives.SetAllItemTypeSlots(slots);
        }
        
        public static void SetAllUnitTypeSlots(JassInteger slots)
        {
            InternalNatives.SetAllUnitTypeSlots(slots);
        }
        
        public static void SetItemTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            InternalNatives.SetItemTypeSlots(whichUnit, slots);
        }
        
        public static void SetUnitTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            InternalNatives.SetUnitTypeSlots(whichUnit, slots);
        }
        
        public static JassInteger GetUnitUserData(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitUserData(whichUnit);
        }
        
        public static void SetUnitUserData(JassUnit whichUnit, JassInteger data)
        {
            InternalNatives.SetUnitUserData(whichUnit, data);
        }
        
        public static JassPlayer Player(JassInteger number)
        {
            return InternalNatives.Player(number);
        }
        
        public static JassPlayer GetLocalPlayer()
        {
            return InternalNatives.GetLocalPlayer();
        }
        
        public static Boolean IsPlayerAlly(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return InternalNatives.IsPlayerAlly(whichPlayer, otherPlayer);
        }
        
        public static Boolean IsPlayerEnemy(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return InternalNatives.IsPlayerEnemy(whichPlayer, otherPlayer);
        }
        
        public static Boolean IsPlayerInForce(JassPlayer whichPlayer, JassForce whichForce)
        {
            return InternalNatives.IsPlayerInForce(whichPlayer, whichForce);
        }
        
        public static Boolean IsPlayerObserver(JassPlayer whichPlayer)
        {
            return InternalNatives.IsPlayerObserver(whichPlayer);
        }
        
        public static Boolean IsVisibleToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives.IsVisibleToPlayer(x, y, whichPlayer);
        }
        
        public static Boolean IsLocationVisibleToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives.IsLocationVisibleToPlayer(whichLocation, whichPlayer);
        }
        
        public static Boolean IsFoggedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives.IsFoggedToPlayer(x, y, whichPlayer);
        }
        
        public static Boolean IsLocationFoggedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives.IsLocationFoggedToPlayer(whichLocation, whichPlayer);
        }
        
        public static Boolean IsMaskedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives.IsMaskedToPlayer(x, y, whichPlayer);
        }
        
        public static Boolean IsLocationMaskedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives.IsLocationMaskedToPlayer(whichLocation, whichPlayer);
        }
        
        public static JassRace GetPlayerRace(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerRace(whichPlayer);
        }
        
        public static JassInteger GetPlayerId(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerId(whichPlayer);
        }
        
        public static JassInteger GetPlayerUnitCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return InternalNatives.GetPlayerUnitCount(whichPlayer, includeIncomplete);
        }
        
        public static JassInteger GetPlayerTypedUnitCount(JassPlayer whichPlayer, String unitName, Boolean includeIncomplete, Boolean includeUpgrades)
        {
            return InternalNatives.GetPlayerTypedUnitCount(whichPlayer, unitName, includeIncomplete, includeUpgrades);
        }
        
        public static JassInteger GetPlayerStructureCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return InternalNatives.GetPlayerStructureCount(whichPlayer, includeIncomplete);
        }
        
        public static JassInteger GetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState)
        {
            return InternalNatives.GetPlayerState(whichPlayer, whichPlayerState);
        }
        
        public static JassInteger GetPlayerScore(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore)
        {
            return InternalNatives.GetPlayerScore(whichPlayer, whichPlayerScore);
        }
        
        public static Boolean GetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting)
        {
            return InternalNatives.GetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting);
        }
        
        public static Single GetPlayerHandicap(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerHandicap(whichPlayer);
        }
        
        public static Single GetPlayerHandicapXP(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerHandicapXP(whichPlayer);
        }
        
        public static void SetPlayerHandicap(JassPlayer whichPlayer, Single handicap)
        {
            InternalNatives.SetPlayerHandicap(whichPlayer, handicap);
        }
        
        public static void SetPlayerHandicapXP(JassPlayer whichPlayer, Single handicap)
        {
            InternalNatives.SetPlayerHandicapXP(whichPlayer, handicap);
        }
        
        public static void SetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum)
        {
            InternalNatives.SetPlayerTechMaxAllowed(whichPlayer, techid, maximum);
        }
        
        public static JassInteger GetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid)
        {
            return InternalNatives.GetPlayerTechMaxAllowed(whichPlayer, techid);
        }
        
        public static void AddPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger levels)
        {
            InternalNatives.AddPlayerTechResearched(whichPlayer, techid, levels);
        }
        
        public static void SetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel)
        {
            InternalNatives.SetPlayerTechResearched(whichPlayer, techid, setToLevel);
        }
        
        public static Boolean GetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return InternalNatives.GetPlayerTechResearched(whichPlayer, techid, specificonly);
        }
        
        public static JassInteger GetPlayerTechCount(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return InternalNatives.GetPlayerTechCount(whichPlayer, techid, specificonly);
        }
        
        public static void SetPlayerUnitsOwner(JassPlayer whichPlayer, JassInteger newOwner)
        {
            InternalNatives.SetPlayerUnitsOwner(whichPlayer, newOwner);
        }
        
        public static void CripplePlayer(JassPlayer whichPlayer, JassForce toWhichPlayers, Boolean flag)
        {
            InternalNatives.CripplePlayer(whichPlayer, toWhichPlayers, flag);
        }
        
        public static void SetPlayerAbilityAvailable(JassPlayer whichPlayer, JassObjectId abilid, Boolean avail)
        {
            InternalNatives.SetPlayerAbilityAvailable(whichPlayer, abilid, avail);
        }
        
        public static void SetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value)
        {
            InternalNatives.SetPlayerState(whichPlayer, whichPlayerState, value);
        }
        
        public static void RemovePlayer(JassPlayer whichPlayer, JassPlayerGameResult gameResult)
        {
            InternalNatives.RemovePlayer(whichPlayer, gameResult);
        }
        
        public static void CachePlayerHeroData(JassPlayer whichPlayer)
        {
            InternalNatives.CachePlayerHeroData(whichPlayer);
        }
        
        public static void SetFogStateRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision)
        {
            InternalNatives.SetFogStateRect(forWhichPlayer, whichState, where, useSharedVision);
        }
        
        public static void SetFogStateRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision)
        {
            InternalNatives.SetFogStateRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision);
        }
        
        public static void SetFogStateRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision)
        {
            InternalNatives.SetFogStateRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision);
        }
        
        public static void FogMaskEnable(Boolean enable)
        {
            InternalNatives.FogMaskEnable(enable);
        }
        
        public static Boolean IsFogMaskEnabled()
        {
            return InternalNatives.IsFogMaskEnabled();
        }
        
        public static void FogEnable(Boolean enable)
        {
            InternalNatives.FogEnable(enable);
        }
        
        public static Boolean IsFogEnabled()
        {
            return InternalNatives.IsFogEnabled();
        }
        
        public static JassFogModifier CreateFogModifierRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives.CreateFogModifierRect(forWhichPlayer, whichState, where, useSharedVision, afterUnits);
        }
        
        public static JassFogModifier CreateFogModifierRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives.CreateFogModifierRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision, afterUnits);
        }
        
        public static JassFogModifier CreateFogModifierRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives.CreateFogModifierRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision, afterUnits);
        }
        
        public static void DestroyFogModifier(JassFogModifier whichFogModifier)
        {
            InternalNatives.DestroyFogModifier(whichFogModifier);
        }
        
        public static void FogModifierStart(JassFogModifier whichFogModifier)
        {
            InternalNatives.FogModifierStart(whichFogModifier);
        }
        
        public static void FogModifierStop(JassFogModifier whichFogModifier)
        {
            InternalNatives.FogModifierStop(whichFogModifier);
        }
        
        public static JassVersion VersionGet()
        {
            return InternalNatives.VersionGet();
        }
        
        public static Boolean VersionCompatible(JassVersion whichVersion)
        {
            return InternalNatives.VersionCompatible(whichVersion);
        }
        
        public static Boolean VersionSupported(JassVersion whichVersion)
        {
            return InternalNatives.VersionSupported(whichVersion);
        }
        
        public static void EndGame(Boolean doScoreScreen)
        {
            InternalNatives.EndGame(doScoreScreen);
        }
        
        public static void ChangeLevel(String newLevel, Boolean doScoreScreen)
        {
            InternalNatives.ChangeLevel(newLevel, doScoreScreen);
        }
        
        public static void RestartGame(Boolean doScoreScreen)
        {
            InternalNatives.RestartGame(doScoreScreen);
        }
        
        public static void ReloadGame()
        {
            InternalNatives.ReloadGame();
        }
        
        public static void SetCampaignMenuRace(JassRace r)
        {
            InternalNatives.SetCampaignMenuRace(r);
        }
        
        public static void SetCampaignMenuRaceEx(JassInteger campaignIndex)
        {
            InternalNatives.SetCampaignMenuRaceEx(campaignIndex);
        }
        
        public static void ForceCampaignSelectScreen()
        {
            InternalNatives.ForceCampaignSelectScreen();
        }
        
        public static void LoadGame(String saveFileName, Boolean doScoreScreen)
        {
            InternalNatives.LoadGame(saveFileName, doScoreScreen);
        }
        
        public static void SaveGame(String saveFileName)
        {
            InternalNatives.SaveGame(saveFileName);
        }
        
        public static Boolean RenameSaveDirectory(String sourceDirName, String destDirName)
        {
            return InternalNatives.RenameSaveDirectory(sourceDirName, destDirName);
        }
        
        public static Boolean RemoveSaveDirectory(String sourceDirName)
        {
            return InternalNatives.RemoveSaveDirectory(sourceDirName);
        }
        
        public static Boolean CopySaveGame(String sourceSaveName, String destSaveName)
        {
            return InternalNatives.CopySaveGame(sourceSaveName, destSaveName);
        }
        
        public static Boolean SaveGameExists(String saveName)
        {
            return InternalNatives.SaveGameExists(saveName);
        }
        
        public static void SyncSelections()
        {
            InternalNatives.SyncSelections();
        }
        
        public static void SetFloatGameState(JassFGameState whichFloatGameState, Single value)
        {
            InternalNatives.SetFloatGameState(whichFloatGameState, value);
        }
        
        public static Single GetFloatGameState(JassFGameState whichFloatGameState)
        {
            return InternalNatives.GetFloatGameState(whichFloatGameState);
        }
        
        public static void SetIntegerGameState(JassIGameState whichIntegerGameState, JassInteger value)
        {
            InternalNatives.SetIntegerGameState(whichIntegerGameState, value);
        }
        
        public static JassInteger GetIntegerGameState(JassIGameState whichIntegerGameState)
        {
            return InternalNatives.GetIntegerGameState(whichIntegerGameState);
        }
        
        public static void SetTutorialCleared(Boolean cleared)
        {
            InternalNatives.SetTutorialCleared(cleared);
        }
        
        public static void SetMissionAvailable(JassInteger campaignNumber, JassInteger missionNumber, Boolean available)
        {
            InternalNatives.SetMissionAvailable(campaignNumber, missionNumber, available);
        }
        
        public static void SetCampaignAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives.SetCampaignAvailable(campaignNumber, available);
        }
        
        public static void SetOpCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives.SetOpCinematicAvailable(campaignNumber, available);
        }
        
        public static void SetEdCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives.SetEdCinematicAvailable(campaignNumber, available);
        }
        
        public static JassGameDifficulty GetDefaultDifficulty()
        {
            return InternalNatives.GetDefaultDifficulty();
        }
        
        public static void SetDefaultDifficulty(JassGameDifficulty g)
        {
            InternalNatives.SetDefaultDifficulty(g);
        }
        
        public static void SetCustomCampaignButtonVisible(JassInteger whichButton, Boolean visible)
        {
            InternalNatives.SetCustomCampaignButtonVisible(whichButton, visible);
        }
        
        public static Boolean GetCustomCampaignButtonVisible(JassInteger whichButton)
        {
            return InternalNatives.GetCustomCampaignButtonVisible(whichButton);
        }
        
        public static void DoNotSaveReplay()
        {
            InternalNatives.DoNotSaveReplay();
        }
        
        public static JassDialog DialogCreate()
        {
            return InternalNatives.DialogCreate();
        }
        
        public static void DialogDestroy(JassDialog whichDialog)
        {
            InternalNatives.DialogDestroy(whichDialog);
        }
        
        public static void DialogClear(JassDialog whichDialog)
        {
            InternalNatives.DialogClear(whichDialog);
        }
        
        public static void DialogSetMessage(JassDialog whichDialog, String messageText)
        {
            InternalNatives.DialogSetMessage(whichDialog, messageText);
        }
        
        public static JassButton DialogAddButton(JassDialog whichDialog, String buttonText, JassInteger hotkey)
        {
            return InternalNatives.DialogAddButton(whichDialog, buttonText, hotkey);
        }
        
        public static JassButton DialogAddQuitButton(JassDialog whichDialog, Boolean doScoreScreen, String buttonText, JassInteger hotkey)
        {
            return InternalNatives.DialogAddQuitButton(whichDialog, doScoreScreen, buttonText, hotkey);
        }
        
        public static void DialogDisplay(JassPlayer whichPlayer, JassDialog whichDialog, Boolean flag)
        {
            InternalNatives.DialogDisplay(whichPlayer, whichDialog, flag);
        }
        
        public static Boolean ReloadGameCachesFromDisk()
        {
            return InternalNatives.ReloadGameCachesFromDisk();
        }
        
        public static JassGameCache InitGameCache(String campaignFile)
        {
            return InternalNatives.InitGameCache(campaignFile);
        }
        
        public static Boolean SaveGameCache(JassGameCache whichCache)
        {
            return InternalNatives.SaveGameCache(whichCache);
        }
        
        public static void StoreInteger(JassGameCache cache, String missionKey, String key, JassInteger value)
        {
            InternalNatives.StoreInteger(cache, missionKey, key, value);
        }
        
        public static void StoreReal(JassGameCache cache, String missionKey, String key, Single value)
        {
            InternalNatives.StoreReal(cache, missionKey, key, value);
        }
        
        public static void StoreBoolean(JassGameCache cache, String missionKey, String key, Boolean value)
        {
            InternalNatives.StoreBoolean(cache, missionKey, key, value);
        }
        
        public static Boolean StoreUnit(JassGameCache cache, String missionKey, String key, JassUnit whichUnit)
        {
            return InternalNatives.StoreUnit(cache, missionKey, key, whichUnit);
        }
        
        public static Boolean StoreString(JassGameCache cache, String missionKey, String key, String value)
        {
            return InternalNatives.StoreString(cache, missionKey, key, value);
        }
        
        public static void SyncStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredInteger(cache, missionKey, key);
        }
        
        public static void SyncStoredReal(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredReal(cache, missionKey, key);
        }
        
        public static void SyncStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredBoolean(cache, missionKey, key);
        }
        
        public static void SyncStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredUnit(cache, missionKey, key);
        }
        
        public static void SyncStoredString(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredString(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredInteger(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredReal(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredBoolean(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredUnit(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredString(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredString(cache, missionKey, key);
        }
        
        public static void FlushGameCache(JassGameCache cache)
        {
            InternalNatives.FlushGameCache(cache);
        }
        
        public static void FlushStoredMission(JassGameCache cache, String missionKey)
        {
            InternalNatives.FlushStoredMission(cache, missionKey);
        }
        
        public static void FlushStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredInteger(cache, missionKey, key);
        }
        
        public static void FlushStoredReal(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredReal(cache, missionKey, key);
        }
        
        public static void FlushStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredBoolean(cache, missionKey, key);
        }
        
        public static void FlushStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredUnit(cache, missionKey, key);
        }
        
        public static void FlushStoredString(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredString(cache, missionKey, key);
        }
        
        public static JassInteger GetStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.GetStoredInteger(cache, missionKey, key);
        }
        
        public static Single GetStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.GetStoredReal(cache, missionKey, key);
        }
        
        public static Boolean GetStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.GetStoredBoolean(cache, missionKey, key);
        }
        
        public static String GetStoredString(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.GetStoredString(cache, missionKey, key);
        }
        
        public static JassUnit RestoreUnit(JassGameCache cache, String missionKey, String key, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return InternalNatives.RestoreUnit(cache, missionKey, key, forWhichPlayer, x, y, facing);
        }
        
        public static JassHashTable InitHashtable()
        {
            return InternalNatives.InitHashtable();
        }
        
        public static void SaveInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value)
        {
            InternalNatives.SaveInteger(table, parentKey, childKey, value);
        }
        
        public static void SaveReal(JassHashTable table, JassInteger parentKey, JassInteger childKey, Single value)
        {
            InternalNatives.SaveReal(table, parentKey, childKey, value);
        }
        
        public static void SaveBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey, Boolean value)
        {
            InternalNatives.SaveBoolean(table, parentKey, childKey, value);
        }
        
        public static Boolean SaveStr(JassHashTable table, JassInteger parentKey, JassInteger childKey, String value)
        {
            return InternalNatives.SaveStr(table, parentKey, childKey, value);
        }
        
        public static Boolean SavePlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer)
        {
            return InternalNatives.SavePlayerHandle(table, parentKey, childKey, whichPlayer);
        }
        
        public static Boolean SaveWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget)
        {
            return InternalNatives.SaveWidgetHandle(table, parentKey, childKey, whichWidget);
        }
        
        public static Boolean SaveDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable)
        {
            return InternalNatives.SaveDestructableHandle(table, parentKey, childKey, whichDestructable);
        }
        
        public static Boolean SaveItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem)
        {
            return InternalNatives.SaveItemHandle(table, parentKey, childKey, whichItem);
        }
        
        public static Boolean SaveUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit)
        {
            return InternalNatives.SaveUnitHandle(table, parentKey, childKey, whichUnit);
        }
        
        public static Boolean SaveAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility)
        {
            return InternalNatives.SaveAbilityHandle(table, parentKey, childKey, whichAbility);
        }
        
        public static Boolean SaveTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer)
        {
            return InternalNatives.SaveTimerHandle(table, parentKey, childKey, whichTimer);
        }
        
        public static Boolean SaveTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger)
        {
            return InternalNatives.SaveTriggerHandle(table, parentKey, childKey, whichTrigger);
        }
        
        public static Boolean SaveTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition)
        {
            return InternalNatives.SaveTriggerConditionHandle(table, parentKey, childKey, whichTriggercondition);
        }
        
        public static Boolean SaveTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction)
        {
            return InternalNatives.SaveTriggerActionHandle(table, parentKey, childKey, whichTriggeraction);
        }
        
        public static Boolean SaveTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent)
        {
            return InternalNatives.SaveTriggerEventHandle(table, parentKey, childKey, whichEvent);
        }
        
        public static Boolean SaveForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce)
        {
            return InternalNatives.SaveForceHandle(table, parentKey, childKey, whichForce);
        }
        
        public static Boolean SaveGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup)
        {
            return InternalNatives.SaveGroupHandle(table, parentKey, childKey, whichGroup);
        }
        
        public static Boolean SaveLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation)
        {
            return InternalNatives.SaveLocationHandle(table, parentKey, childKey, whichLocation);
        }
        
        public static Boolean SaveRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect)
        {
            return InternalNatives.SaveRectHandle(table, parentKey, childKey, whichRect);
        }
        
        public static Boolean SaveBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr)
        {
            return InternalNatives.SaveBooleanExprHandle(table, parentKey, childKey, whichBoolexpr);
        }
        
        public static Boolean SaveSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound)
        {
            return InternalNatives.SaveSoundHandle(table, parentKey, childKey, whichSound);
        }
        
        public static Boolean SaveEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect)
        {
            return InternalNatives.SaveEffectHandle(table, parentKey, childKey, whichEffect);
        }
        
        public static Boolean SaveUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool)
        {
            return InternalNatives.SaveUnitPoolHandle(table, parentKey, childKey, whichUnitpool);
        }
        
        public static Boolean SaveItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool)
        {
            return InternalNatives.SaveItemPoolHandle(table, parentKey, childKey, whichItempool);
        }
        
        public static Boolean SaveQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest)
        {
            return InternalNatives.SaveQuestHandle(table, parentKey, childKey, whichQuest);
        }
        
        public static Boolean SaveQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem)
        {
            return InternalNatives.SaveQuestItemHandle(table, parentKey, childKey, whichQuestitem);
        }
        
        public static Boolean SaveDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition)
        {
            return InternalNatives.SaveDefeatConditionHandle(table, parentKey, childKey, whichDefeatcondition);
        }
        
        public static Boolean SaveTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog)
        {
            return InternalNatives.SaveTimerDialogHandle(table, parentKey, childKey, whichTimerdialog);
        }
        
        public static Boolean SaveLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard)
        {
            return InternalNatives.SaveLeaderboardHandle(table, parentKey, childKey, whichLeaderboard);
        }
        
        public static Boolean SaveMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard)
        {
            return InternalNatives.SaveMultiboardHandle(table, parentKey, childKey, whichMultiboard);
        }
        
        public static Boolean SaveMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem)
        {
            return InternalNatives.SaveMultiboardItemHandle(table, parentKey, childKey, whichMultiboarditem);
        }
        
        public static Boolean SaveTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable)
        {
            return InternalNatives.SaveTrackableHandle(table, parentKey, childKey, whichTrackable);
        }
        
        public static Boolean SaveDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog)
        {
            return InternalNatives.SaveDialogHandle(table, parentKey, childKey, whichDialog);
        }
        
        public static Boolean SaveButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton)
        {
            return InternalNatives.SaveButtonHandle(table, parentKey, childKey, whichButton);
        }
        
        public static Boolean SaveTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag)
        {
            return InternalNatives.SaveTextTagHandle(table, parentKey, childKey, whichTexttag);
        }
        
        public static Boolean SaveLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning)
        {
            return InternalNatives.SaveLightningHandle(table, parentKey, childKey, whichLightning);
        }
        
        public static Boolean SaveImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage)
        {
            return InternalNatives.SaveImageHandle(table, parentKey, childKey, whichImage);
        }
        
        public static Boolean SaveUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat)
        {
            return InternalNatives.SaveUbersplatHandle(table, parentKey, childKey, whichUbersplat);
        }
        
        public static Boolean SaveRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion)
        {
            return InternalNatives.SaveRegionHandle(table, parentKey, childKey, whichRegion);
        }
        
        public static Boolean SaveFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState)
        {
            return InternalNatives.SaveFogStateHandle(table, parentKey, childKey, whichFogState);
        }
        
        public static Boolean SaveFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier)
        {
            return InternalNatives.SaveFogModifierHandle(table, parentKey, childKey, whichFogModifier);
        }
        
        public static Boolean SaveAgentHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent)
        {
            return InternalNatives.SaveAgentHandle(table, parentKey, childKey, whichAgent);
        }
        
        public static Boolean SaveHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable)
        {
            return InternalNatives.SaveHashtableHandle(table, parentKey, childKey, whichHashtable);
        }
        
        public static JassInteger LoadInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadInteger(table, parentKey, childKey);
        }
        
        public static Single LoadReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadReal(table, parentKey, childKey);
        }
        
        public static Boolean LoadBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadBoolean(table, parentKey, childKey);
        }
        
        public static String LoadStr(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadStr(table, parentKey, childKey);
        }
        
        public static JassPlayer LoadPlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadPlayerHandle(table, parentKey, childKey);
        }
        
        public static JassWidget LoadWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadWidgetHandle(table, parentKey, childKey);
        }
        
        public static JassDestructable LoadDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadDestructableHandle(table, parentKey, childKey);
        }
        
        public static JassItem LoadItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadItemHandle(table, parentKey, childKey);
        }
        
        public static JassUnit LoadUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadUnitHandle(table, parentKey, childKey);
        }
        
        public static JassAbility LoadAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadAbilityHandle(table, parentKey, childKey);
        }
        
        public static JassTimer LoadTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTimerHandle(table, parentKey, childKey);
        }
        
        public static JassTrigger LoadTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTriggerHandle(table, parentKey, childKey);
        }
        
        public static JassTriggerCondition LoadTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTriggerConditionHandle(table, parentKey, childKey);
        }
        
        public static JassTriggerAction LoadTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTriggerActionHandle(table, parentKey, childKey);
        }
        
        public static JassEvent LoadTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTriggerEventHandle(table, parentKey, childKey);
        }
        
        public static JassForce LoadForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadForceHandle(table, parentKey, childKey);
        }
        
        public static JassGroup LoadGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadGroupHandle(table, parentKey, childKey);
        }
        
        public static JassLocation LoadLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadLocationHandle(table, parentKey, childKey);
        }
        
        public static JassRect LoadRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadRectHandle(table, parentKey, childKey);
        }
        
        public static JassBooleanExpression LoadBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadBooleanExprHandle(table, parentKey, childKey);
        }
        
        public static JassSound LoadSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadSoundHandle(table, parentKey, childKey);
        }
        
        public static JassEffect LoadEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadEffectHandle(table, parentKey, childKey);
        }
        
        public static JassUnitPool LoadUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadUnitPoolHandle(table, parentKey, childKey);
        }
        
        public static JassItemPool LoadItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadItemPoolHandle(table, parentKey, childKey);
        }
        
        public static JassQuest LoadQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadQuestHandle(table, parentKey, childKey);
        }
        
        public static JassQuestItem LoadQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadQuestItemHandle(table, parentKey, childKey);
        }
        
        public static JassDefeatCondition LoadDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadDefeatConditionHandle(table, parentKey, childKey);
        }
        
        public static JassTimerDialog LoadTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTimerDialogHandle(table, parentKey, childKey);
        }
        
        public static JassLeaderboard LoadLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadLeaderboardHandle(table, parentKey, childKey);
        }
        
        public static JassMultiboard LoadMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadMultiboardHandle(table, parentKey, childKey);
        }
        
        public static JassMultiboardItem LoadMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadMultiboardItemHandle(table, parentKey, childKey);
        }
        
        public static JassTrackable LoadTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTrackableHandle(table, parentKey, childKey);
        }
        
        public static JassDialog LoadDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadDialogHandle(table, parentKey, childKey);
        }
        
        public static JassButton LoadButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadButtonHandle(table, parentKey, childKey);
        }
        
        public static JassTextTag LoadTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTextTagHandle(table, parentKey, childKey);
        }
        
        public static JassLightning LoadLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadLightningHandle(table, parentKey, childKey);
        }
        
        public static JassImage LoadImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadImageHandle(table, parentKey, childKey);
        }
        
        public static JassUberSplat LoadUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadUbersplatHandle(table, parentKey, childKey);
        }
        
        public static JassRegion LoadRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadRegionHandle(table, parentKey, childKey);
        }
        
        public static JassFogState LoadFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadFogStateHandle(table, parentKey, childKey);
        }
        
        public static JassFogModifier LoadFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadFogModifierHandle(table, parentKey, childKey);
        }
        
        public static JassHashTable LoadHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadHashtableHandle(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedInteger(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedReal(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedBoolean(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedString(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedHandle(table, parentKey, childKey);
        }
        
        public static void RemoveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedInteger(table, parentKey, childKey);
        }
        
        public static void RemoveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedReal(table, parentKey, childKey);
        }
        
        public static void RemoveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedBoolean(table, parentKey, childKey);
        }
        
        public static void RemoveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedString(table, parentKey, childKey);
        }
        
        public static void RemoveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedHandle(table, parentKey, childKey);
        }
        
        public static void FlushParentHashtable(JassHashTable table)
        {
            InternalNatives.FlushParentHashtable(table);
        }
        
        public static void FlushChildHashtable(JassHashTable table, JassInteger parentKey)
        {
            InternalNatives.FlushChildHashtable(table, parentKey);
        }
        
        public static JassInteger GetRandomInt(JassInteger lowBound, JassInteger highBound)
        {
            return InternalNatives.GetRandomInt(lowBound, highBound);
        }
        
        public static Single GetRandomReal(Single lowBound, Single highBound)
        {
            return InternalNatives.GetRandomReal(lowBound, highBound);
        }
        
        public static JassUnitPool CreateUnitPool()
        {
            return InternalNatives.CreateUnitPool();
        }
        
        public static void DestroyUnitPool(JassUnitPool whichPool)
        {
            InternalNatives.DestroyUnitPool(whichPool);
        }
        
        public static void UnitPoolAddUnitType(JassUnitPool whichPool, JassObjectId unitId, Single weight)
        {
            InternalNatives.UnitPoolAddUnitType(whichPool, unitId, weight);
        }
        
        public static void UnitPoolRemoveUnitType(JassUnitPool whichPool, JassObjectId unitId)
        {
            InternalNatives.UnitPoolRemoveUnitType(whichPool, unitId);
        }
        
        public static JassUnit PlaceRandomUnit(JassUnitPool whichPool, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return InternalNatives.PlaceRandomUnit(whichPool, forWhichPlayer, x, y, facing);
        }
        
        public static JassItemPool CreateItemPool()
        {
            return InternalNatives.CreateItemPool();
        }
        
        public static void DestroyItemPool(JassItemPool whichItemPool)
        {
            InternalNatives.DestroyItemPool(whichItemPool);
        }
        
        public static void ItemPoolAddItemType(JassItemPool whichItemPool, JassObjectId itemId, Single weight)
        {
            InternalNatives.ItemPoolAddItemType(whichItemPool, itemId, weight);
        }
        
        public static void ItemPoolRemoveItemType(JassItemPool whichItemPool, JassObjectId itemId)
        {
            InternalNatives.ItemPoolRemoveItemType(whichItemPool, itemId);
        }
        
        public static JassItem PlaceRandomItem(JassItemPool whichItemPool, Single x, Single y)
        {
            return InternalNatives.PlaceRandomItem(whichItemPool, x, y);
        }
        
        public static JassInteger ChooseRandomCreep(JassInteger level)
        {
            return InternalNatives.ChooseRandomCreep(level);
        }
        
        public static JassInteger ChooseRandomNPBuilding()
        {
            return InternalNatives.ChooseRandomNPBuilding();
        }
        
        public static JassInteger ChooseRandomItem(JassInteger level)
        {
            return InternalNatives.ChooseRandomItem(level);
        }
        
        public static JassInteger ChooseRandomItemEx(JassItemType whichType, JassInteger level)
        {
            return InternalNatives.ChooseRandomItemEx(whichType, level);
        }
        
        public static void SetRandomSeed(JassInteger seed)
        {
            InternalNatives.SetRandomSeed(seed);
        }
        
        public static void SetTerrainFog(Single a, Single b, Single c, Single d, Single e)
        {
            InternalNatives.SetTerrainFog(a, b, c, d, e);
        }
        
        public static void ResetTerrainFog()
        {
            InternalNatives.ResetTerrainFog();
        }
        
        public static void SetUnitFog(Single a, Single b, Single c, Single d, Single e)
        {
            InternalNatives.SetUnitFog(a, b, c, d, e);
        }
        
        public static void SetTerrainFogEx(JassInteger style, Single zstart, Single zend, Single density, Single red, Single green, Single blue)
        {
            InternalNatives.SetTerrainFogEx(style, zstart, zend, density, red, green, blue);
        }
        
        public static void DisplayTextToPlayer(JassPlayer toPlayer, Single x, Single y, String message)
        {
            InternalNatives.DisplayTextToPlayer(toPlayer, x, y, message);
        }
        
        public static void DisplayTimedTextToPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            InternalNatives.DisplayTimedTextToPlayer(toPlayer, x, y, duration, message);
        }
        
        public static void DisplayTimedTextFromPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            InternalNatives.DisplayTimedTextFromPlayer(toPlayer, x, y, duration, message);
        }
        
        public static void ClearTextMessages()
        {
            InternalNatives.ClearTextMessages();
        }
        
        public static void SetDayNightModels(String terrainDNCFile, String unitDNCFile)
        {
            InternalNatives.SetDayNightModels(terrainDNCFile, unitDNCFile);
        }
        
        public static void SetSkyModel(String skyModelFile)
        {
            InternalNatives.SetSkyModel(skyModelFile);
        }
        
        public static void EnableUserControl(Boolean b)
        {
            InternalNatives.EnableUserControl(b);
        }
        
        public static void EnableUserUI(Boolean b)
        {
            InternalNatives.EnableUserUI(b);
        }
        
        public static void SuspendTimeOfDay(Boolean b)
        {
            InternalNatives.SuspendTimeOfDay(b);
        }
        
        public static void SetTimeOfDayScale(Single r)
        {
            InternalNatives.SetTimeOfDayScale(r);
        }
        
        public static Single GetTimeOfDayScale()
        {
            return InternalNatives.GetTimeOfDayScale();
        }
        
        public static void ShowInterface(Boolean flag, Single fadeDuration)
        {
            InternalNatives.ShowInterface(flag, fadeDuration);
        }
        
        public static void PauseGame(Boolean flag)
        {
            InternalNatives.PauseGame(flag);
        }
        
        public static void UnitAddIndicator(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.UnitAddIndicator(whichUnit, red, green, blue, alpha);
        }
        
        public static void AddIndicator(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.AddIndicator(whichWidget, red, green, blue, alpha);
        }
        
        public static void PingMinimap(Single x, Single y, Single duration)
        {
            InternalNatives.PingMinimap(x, y, duration);
        }
        
        public static void PingMinimapEx(Single x, Single y, Single duration, JassInteger red, JassInteger green, JassInteger blue, Boolean extraEffects)
        {
            InternalNatives.PingMinimapEx(x, y, duration, red, green, blue, extraEffects);
        }
        
        public static void EnableOcclusion(Boolean flag)
        {
            InternalNatives.EnableOcclusion(flag);
        }
        
        public static void SetIntroShotText(String introText)
        {
            InternalNatives.SetIntroShotText(introText);
        }
        
        public static void SetIntroShotModel(String introModelPath)
        {
            InternalNatives.SetIntroShotModel(introModelPath);
        }
        
        public static void EnableWorldFogBoundary(Boolean b)
        {
            InternalNatives.EnableWorldFogBoundary(b);
        }
        
        public static void PlayModelCinematic(String modelName)
        {
            InternalNatives.PlayModelCinematic(modelName);
        }
        
        public static void PlayCinematic(String movieName)
        {
            InternalNatives.PlayCinematic(movieName);
        }
        
        public static void ForceUIKey(String key)
        {
            InternalNatives.ForceUIKey(key);
        }
        
        public static void ForceUICancel()
        {
            InternalNatives.ForceUICancel();
        }
        
        public static void DisplayLoadDialog()
        {
            InternalNatives.DisplayLoadDialog();
        }
        
        public static void SetAltMinimapIcon(String iconPath)
        {
            InternalNatives.SetAltMinimapIcon(iconPath);
        }
        
        public static void DisableRestartMission(Boolean flag)
        {
            InternalNatives.DisableRestartMission(flag);
        }
        
        public static JassTextTag CreateTextTag()
        {
            return InternalNatives.CreateTextTag();
        }
        
        public static void DestroyTextTag(JassTextTag t)
        {
            InternalNatives.DestroyTextTag(t);
        }
        
        public static void SetTextTagText(JassTextTag t, String s, Single height)
        {
            InternalNatives.SetTextTagText(t, s, height);
        }
        
        public static void SetTextTagPos(JassTextTag t, Single x, Single y, Single heightOffset)
        {
            InternalNatives.SetTextTagPos(t, x, y, heightOffset);
        }
        
        public static void SetTextTagPosUnit(JassTextTag t, JassUnit whichUnit, Single heightOffset)
        {
            InternalNatives.SetTextTagPosUnit(t, whichUnit, heightOffset);
        }
        
        public static void SetTextTagColor(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetTextTagColor(t, red, green, blue, alpha);
        }
        
        public static void SetTextTagVelocity(JassTextTag t, Single xvel, Single yvel)
        {
            InternalNatives.SetTextTagVelocity(t, xvel, yvel);
        }
        
        public static void SetTextTagVisibility(JassTextTag t, Boolean flag)
        {
            InternalNatives.SetTextTagVisibility(t, flag);
        }
        
        public static void SetTextTagSuspended(JassTextTag t, Boolean flag)
        {
            InternalNatives.SetTextTagSuspended(t, flag);
        }
        
        public static void SetTextTagPermanent(JassTextTag t, Boolean flag)
        {
            InternalNatives.SetTextTagPermanent(t, flag);
        }
        
        public static void SetTextTagAge(JassTextTag t, Single age)
        {
            InternalNatives.SetTextTagAge(t, age);
        }
        
        public static void SetTextTagLifespan(JassTextTag t, Single lifespan)
        {
            InternalNatives.SetTextTagLifespan(t, lifespan);
        }
        
        public static void SetTextTagFadepoint(JassTextTag t, Single fadepoint)
        {
            InternalNatives.SetTextTagFadepoint(t, fadepoint);
        }
        
        public static void SetReservedLocalHeroButtons(JassInteger reserved)
        {
            InternalNatives.SetReservedLocalHeroButtons(reserved);
        }
        
        public static JassInteger GetAllyColorFilterState()
        {
            return InternalNatives.GetAllyColorFilterState();
        }
        
        public static void SetAllyColorFilterState(JassInteger state)
        {
            InternalNatives.SetAllyColorFilterState(state);
        }
        
        public static Boolean GetCreepCampFilterState()
        {
            return InternalNatives.GetCreepCampFilterState();
        }
        
        public static void SetCreepCampFilterState(Boolean state)
        {
            InternalNatives.SetCreepCampFilterState(state);
        }
        
        public static void EnableMinimapFilterButtons(Boolean enableAlly, Boolean enableCreep)
        {
            InternalNatives.EnableMinimapFilterButtons(enableAlly, enableCreep);
        }
        
        public static void EnableDragSelect(Boolean state, Boolean ui)
        {
            InternalNatives.EnableDragSelect(state, ui);
        }
        
        public static void EnablePreSelect(Boolean state, Boolean ui)
        {
            InternalNatives.EnablePreSelect(state, ui);
        }
        
        public static void EnableSelect(Boolean state, Boolean ui)
        {
            InternalNatives.EnableSelect(state, ui);
        }
        
        public static JassTrackable CreateTrackable(String trackableModelPath, Single x, Single y, Single facing)
        {
            return InternalNatives.CreateTrackable(trackableModelPath, x, y, facing);
        }
        
        public static JassQuest CreateQuest()
        {
            return InternalNatives.CreateQuest();
        }
        
        public static void DestroyQuest(JassQuest whichQuest)
        {
            InternalNatives.DestroyQuest(whichQuest);
        }
        
        public static void QuestSetTitle(JassQuest whichQuest, String title)
        {
            InternalNatives.QuestSetTitle(whichQuest, title);
        }
        
        public static void QuestSetDescription(JassQuest whichQuest, String description)
        {
            InternalNatives.QuestSetDescription(whichQuest, description);
        }
        
        public static void QuestSetIconPath(JassQuest whichQuest, String iconPath)
        {
            InternalNatives.QuestSetIconPath(whichQuest, iconPath);
        }
        
        public static void QuestSetRequired(JassQuest whichQuest, Boolean required)
        {
            InternalNatives.QuestSetRequired(whichQuest, required);
        }
        
        public static void QuestSetCompleted(JassQuest whichQuest, Boolean completed)
        {
            InternalNatives.QuestSetCompleted(whichQuest, completed);
        }
        
        public static void QuestSetDiscovered(JassQuest whichQuest, Boolean discovered)
        {
            InternalNatives.QuestSetDiscovered(whichQuest, discovered);
        }
        
        public static void QuestSetFailed(JassQuest whichQuest, Boolean failed)
        {
            InternalNatives.QuestSetFailed(whichQuest, failed);
        }
        
        public static void QuestSetEnabled(JassQuest whichQuest, Boolean enabled)
        {
            InternalNatives.QuestSetEnabled(whichQuest, enabled);
        }
        
        public static Boolean IsQuestRequired(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestRequired(whichQuest);
        }
        
        public static Boolean IsQuestCompleted(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestCompleted(whichQuest);
        }
        
        public static Boolean IsQuestDiscovered(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestDiscovered(whichQuest);
        }
        
        public static Boolean IsQuestFailed(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestFailed(whichQuest);
        }
        
        public static Boolean IsQuestEnabled(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestEnabled(whichQuest);
        }
        
        public static JassQuestItem QuestCreateItem(JassQuest whichQuest)
        {
            return InternalNatives.QuestCreateItem(whichQuest);
        }
        
        public static void QuestItemSetDescription(JassQuestItem whichQuestItem, String description)
        {
            InternalNatives.QuestItemSetDescription(whichQuestItem, description);
        }
        
        public static void QuestItemSetCompleted(JassQuestItem whichQuestItem, Boolean completed)
        {
            InternalNatives.QuestItemSetCompleted(whichQuestItem, completed);
        }
        
        public static Boolean IsQuestItemCompleted(JassQuestItem whichQuestItem)
        {
            return InternalNatives.IsQuestItemCompleted(whichQuestItem);
        }
        
        public static JassDefeatCondition CreateDefeatCondition()
        {
            return InternalNatives.CreateDefeatCondition();
        }
        
        public static void DestroyDefeatCondition(JassDefeatCondition whichCondition)
        {
            InternalNatives.DestroyDefeatCondition(whichCondition);
        }
        
        public static void DefeatConditionSetDescription(JassDefeatCondition whichCondition, String description)
        {
            InternalNatives.DefeatConditionSetDescription(whichCondition, description);
        }
        
        public static void FlashQuestDialogButton()
        {
            InternalNatives.FlashQuestDialogButton();
        }
        
        public static void ForceQuestDialogUpdate()
        {
            InternalNatives.ForceQuestDialogUpdate();
        }
        
        public static JassTimerDialog CreateTimerDialog(JassTimer t)
        {
            return InternalNatives.CreateTimerDialog(t);
        }
        
        public static void DestroyTimerDialog(JassTimerDialog whichDialog)
        {
            InternalNatives.DestroyTimerDialog(whichDialog);
        }
        
        public static void TimerDialogSetTitle(JassTimerDialog whichDialog, String title)
        {
            InternalNatives.TimerDialogSetTitle(whichDialog, title);
        }
        
        public static void TimerDialogSetTitleColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.TimerDialogSetTitleColor(whichDialog, red, green, blue, alpha);
        }
        
        public static void TimerDialogSetTimeColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.TimerDialogSetTimeColor(whichDialog, red, green, blue, alpha);
        }
        
        public static void TimerDialogSetSpeed(JassTimerDialog whichDialog, Single speedMultFactor)
        {
            InternalNatives.TimerDialogSetSpeed(whichDialog, speedMultFactor);
        }
        
        public static void TimerDialogDisplay(JassTimerDialog whichDialog, Boolean display)
        {
            InternalNatives.TimerDialogDisplay(whichDialog, display);
        }
        
        public static Boolean IsTimerDialogDisplayed(JassTimerDialog whichDialog)
        {
            return InternalNatives.IsTimerDialogDisplayed(whichDialog);
        }
        
        public static void TimerDialogSetRealTimeRemaining(JassTimerDialog whichDialog, Single timeRemaining)
        {
            InternalNatives.TimerDialogSetRealTimeRemaining(whichDialog, timeRemaining);
        }
        
        public static JassLeaderboard CreateLeaderboard()
        {
            return InternalNatives.CreateLeaderboard();
        }
        
        public static void DestroyLeaderboard(JassLeaderboard lb)
        {
            InternalNatives.DestroyLeaderboard(lb);
        }
        
        public static void LeaderboardDisplay(JassLeaderboard lb, Boolean show)
        {
            InternalNatives.LeaderboardDisplay(lb, show);
        }
        
        public static Boolean IsLeaderboardDisplayed(JassLeaderboard lb)
        {
            return InternalNatives.IsLeaderboardDisplayed(lb);
        }
        
        public static JassInteger LeaderboardGetItemCount(JassLeaderboard lb)
        {
            return InternalNatives.LeaderboardGetItemCount(lb);
        }
        
        public static void LeaderboardSetSizeByItemCount(JassLeaderboard lb, JassInteger count)
        {
            InternalNatives.LeaderboardSetSizeByItemCount(lb, count);
        }
        
        public static void LeaderboardAddItem(JassLeaderboard lb, String label, JassInteger value, JassPlayer p)
        {
            InternalNatives.LeaderboardAddItem(lb, label, value, p);
        }
        
        public static void LeaderboardRemoveItem(JassLeaderboard lb, JassInteger index)
        {
            InternalNatives.LeaderboardRemoveItem(lb, index);
        }
        
        public static void LeaderboardRemovePlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            InternalNatives.LeaderboardRemovePlayerItem(lb, p);
        }
        
        public static void LeaderboardClear(JassLeaderboard lb)
        {
            InternalNatives.LeaderboardClear(lb);
        }
        
        public static void LeaderboardSortItemsByValue(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives.LeaderboardSortItemsByValue(lb, ascending);
        }
        
        public static void LeaderboardSortItemsByPlayer(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives.LeaderboardSortItemsByPlayer(lb, ascending);
        }
        
        public static void LeaderboardSortItemsByLabel(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives.LeaderboardSortItemsByLabel(lb, ascending);
        }
        
        public static Boolean LeaderboardHasPlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            return InternalNatives.LeaderboardHasPlayerItem(lb, p);
        }
        
        public static JassInteger LeaderboardGetPlayerIndex(JassLeaderboard lb, JassPlayer p)
        {
            return InternalNatives.LeaderboardGetPlayerIndex(lb, p);
        }
        
        public static void LeaderboardSetLabel(JassLeaderboard lb, String label)
        {
            InternalNatives.LeaderboardSetLabel(lb, label);
        }
        
        public static String LeaderboardGetLabelText(JassLeaderboard lb)
        {
            return InternalNatives.LeaderboardGetLabelText(lb);
        }
        
        public static void PlayerSetLeaderboard(JassPlayer toPlayer, JassLeaderboard lb)
        {
            InternalNatives.PlayerSetLeaderboard(toPlayer, lb);
        }
        
        public static JassLeaderboard PlayerGetLeaderboard(JassPlayer toPlayer)
        {
            return InternalNatives.PlayerGetLeaderboard(toPlayer);
        }
        
        public static void LeaderboardSetLabelColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.LeaderboardSetLabelColor(lb, red, green, blue, alpha);
        }
        
        public static void LeaderboardSetValueColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.LeaderboardSetValueColor(lb, red, green, blue, alpha);
        }
        
        public static void LeaderboardSetStyle(JassLeaderboard lb, Boolean showLabel, Boolean showNames, Boolean showValues, Boolean showIcons)
        {
            InternalNatives.LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);
        }
        
        public static void LeaderboardSetItemValue(JassLeaderboard lb, JassInteger whichItem, JassInteger val)
        {
            InternalNatives.LeaderboardSetItemValue(lb, whichItem, val);
        }
        
        public static void LeaderboardSetItemLabel(JassLeaderboard lb, JassInteger whichItem, String val)
        {
            InternalNatives.LeaderboardSetItemLabel(lb, whichItem, val);
        }
        
        public static void LeaderboardSetItemStyle(JassLeaderboard lb, JassInteger whichItem, Boolean showLabel, Boolean showValue, Boolean showIcon)
        {
            InternalNatives.LeaderboardSetItemStyle(lb, whichItem, showLabel, showValue, showIcon);
        }
        
        public static void LeaderboardSetItemLabelColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.LeaderboardSetItemLabelColor(lb, whichItem, red, green, blue, alpha);
        }
        
        public static void LeaderboardSetItemValueColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.LeaderboardSetItemValueColor(lb, whichItem, red, green, blue, alpha);
        }
        
        public static JassMultiboard CreateMultiboard()
        {
            return InternalNatives.CreateMultiboard();
        }
        
        public static void DestroyMultiboard(JassMultiboard lb)
        {
            InternalNatives.DestroyMultiboard(lb);
        }
        
        public static void MultiboardDisplay(JassMultiboard lb, Boolean show)
        {
            InternalNatives.MultiboardDisplay(lb, show);
        }
        
        public static Boolean IsMultiboardDisplayed(JassMultiboard lb)
        {
            return InternalNatives.IsMultiboardDisplayed(lb);
        }
        
        public static void MultiboardMinimize(JassMultiboard lb, Boolean minimize)
        {
            InternalNatives.MultiboardMinimize(lb, minimize);
        }
        
        public static Boolean IsMultiboardMinimized(JassMultiboard lb)
        {
            return InternalNatives.IsMultiboardMinimized(lb);
        }
        
        public static void MultiboardClear(JassMultiboard lb)
        {
            InternalNatives.MultiboardClear(lb);
        }
        
        public static void MultiboardSetTitleText(JassMultiboard lb, String label)
        {
            InternalNatives.MultiboardSetTitleText(lb, label);
        }
        
        public static String MultiboardGetTitleText(JassMultiboard lb)
        {
            return InternalNatives.MultiboardGetTitleText(lb);
        }
        
        public static void MultiboardSetTitleTextColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.MultiboardSetTitleTextColor(lb, red, green, blue, alpha);
        }
        
        public static JassInteger MultiboardGetRowCount(JassMultiboard lb)
        {
            return InternalNatives.MultiboardGetRowCount(lb);
        }
        
        public static JassInteger MultiboardGetColumnCount(JassMultiboard lb)
        {
            return InternalNatives.MultiboardGetColumnCount(lb);
        }
        
        public static void MultiboardSetColumnCount(JassMultiboard lb, JassInteger count)
        {
            InternalNatives.MultiboardSetColumnCount(lb, count);
        }
        
        public static void MultiboardSetRowCount(JassMultiboard lb, JassInteger count)
        {
            InternalNatives.MultiboardSetRowCount(lb, count);
        }
        
        public static void MultiboardSetItemsStyle(JassMultiboard lb, Boolean showValues, Boolean showIcons)
        {
            InternalNatives.MultiboardSetItemsStyle(lb, showValues, showIcons);
        }
        
        public static void MultiboardSetItemsValue(JassMultiboard lb, String value)
        {
            InternalNatives.MultiboardSetItemsValue(lb, value);
        }
        
        public static void MultiboardSetItemsValueColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.MultiboardSetItemsValueColor(lb, red, green, blue, alpha);
        }
        
        public static void MultiboardSetItemsWidth(JassMultiboard lb, Single width)
        {
            InternalNatives.MultiboardSetItemsWidth(lb, width);
        }
        
        public static void MultiboardSetItemsIcon(JassMultiboard lb, String iconPath)
        {
            InternalNatives.MultiboardSetItemsIcon(lb, iconPath);
        }
        
        public static JassMultiboardItem MultiboardGetItem(JassMultiboard lb, JassInteger row, JassInteger column)
        {
            return InternalNatives.MultiboardGetItem(lb, row, column);
        }
        
        public static void MultiboardReleaseItem(JassMultiboardItem mbi)
        {
            InternalNatives.MultiboardReleaseItem(mbi);
        }
        
        public static void MultiboardSetItemStyle(JassMultiboardItem mbi, Boolean showValue, Boolean showIcon)
        {
            InternalNatives.MultiboardSetItemStyle(mbi, showValue, showIcon);
        }
        
        public static void MultiboardSetItemValue(JassMultiboardItem mbi, String val)
        {
            InternalNatives.MultiboardSetItemValue(mbi, val);
        }
        
        public static void MultiboardSetItemValueColor(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.MultiboardSetItemValueColor(mbi, red, green, blue, alpha);
        }
        
        public static void MultiboardSetItemWidth(JassMultiboardItem mbi, Single width)
        {
            InternalNatives.MultiboardSetItemWidth(mbi, width);
        }
        
        public static void MultiboardSetItemIcon(JassMultiboardItem mbi, String iconFileName)
        {
            InternalNatives.MultiboardSetItemIcon(mbi, iconFileName);
        }
        
        public static void MultiboardSuppressDisplay(Boolean flag)
        {
            InternalNatives.MultiboardSuppressDisplay(flag);
        }
        
        public static void SetCameraPosition(Single x, Single y)
        {
            InternalNatives.SetCameraPosition(x, y);
        }
        
        public static void SetCameraQuickPosition(Single x, Single y)
        {
            InternalNatives.SetCameraQuickPosition(x, y);
        }
        
        public static void SetCameraBounds(Single x1, Single y1, Single x2, Single y2, Single x3, Single y3, Single x4, Single y4)
        {
            InternalNatives.SetCameraBounds(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        
        public static void StopCamera()
        {
            InternalNatives.StopCamera();
        }
        
        public static void ResetToGameCamera(Single duration)
        {
            InternalNatives.ResetToGameCamera(duration);
        }
        
        public static void PanCameraTo(Single x, Single y)
        {
            InternalNatives.PanCameraTo(x, y);
        }
        
        public static void PanCameraToTimed(Single x, Single y, Single duration)
        {
            InternalNatives.PanCameraToTimed(x, y, duration);
        }
        
        public static void PanCameraToWithZ(Single x, Single y, Single zOffsetDest)
        {
            InternalNatives.PanCameraToWithZ(x, y, zOffsetDest);
        }
        
        public static void PanCameraToTimedWithZ(Single x, Single y, Single zOffsetDest, Single duration)
        {
            InternalNatives.PanCameraToTimedWithZ(x, y, zOffsetDest, duration);
        }
        
        public static void SetCinematicCamera(String cameraModelFile)
        {
            InternalNatives.SetCinematicCamera(cameraModelFile);
        }
        
        public static void SetCameraRotateMode(Single x, Single y, Single radiansToSweep, Single duration)
        {
            InternalNatives.SetCameraRotateMode(x, y, radiansToSweep, duration);
        }
        
        public static void SetCameraField(JassCameraField whichField, Single value, Single duration)
        {
            InternalNatives.SetCameraField(whichField, value, duration);
        }
        
        public static void AdjustCameraField(JassCameraField whichField, Single offset, Single duration)
        {
            InternalNatives.AdjustCameraField(whichField, offset, duration);
        }
        
        public static void SetCameraTargetController(JassUnit whichUnit, Single xoffset, Single yoffset, Boolean inheritOrientation)
        {
            InternalNatives.SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);
        }
        
        public static void SetCameraOrientController(JassUnit whichUnit, Single xoffset, Single yoffset)
        {
            InternalNatives.SetCameraOrientController(whichUnit, xoffset, yoffset);
        }
        
        public static JassCameraSetup CreateCameraSetup()
        {
            return InternalNatives.CreateCameraSetup();
        }
        
        public static void CameraSetupSetField(JassCameraSetup whichSetup, JassCameraField whichField, Single value, Single duration)
        {
            InternalNatives.CameraSetupSetField(whichSetup, whichField, value, duration);
        }
        
        public static Single CameraSetupGetField(JassCameraSetup whichSetup, JassCameraField whichField)
        {
            return InternalNatives.CameraSetupGetField(whichSetup, whichField);
        }
        
        public static void CameraSetupSetDestPosition(JassCameraSetup whichSetup, Single x, Single y, Single duration)
        {
            InternalNatives.CameraSetupSetDestPosition(whichSetup, x, y, duration);
        }
        
        public static JassLocation CameraSetupGetDestPositionLoc(JassCameraSetup whichSetup)
        {
            return InternalNatives.CameraSetupGetDestPositionLoc(whichSetup);
        }
        
        public static Single CameraSetupGetDestPositionX(JassCameraSetup whichSetup)
        {
            return InternalNatives.CameraSetupGetDestPositionX(whichSetup);
        }
        
        public static Single CameraSetupGetDestPositionY(JassCameraSetup whichSetup)
        {
            return InternalNatives.CameraSetupGetDestPositionY(whichSetup);
        }
        
        public static void CameraSetupApply(JassCameraSetup whichSetup, Boolean doPan, Boolean panTimed)
        {
            InternalNatives.CameraSetupApply(whichSetup, doPan, panTimed);
        }
        
        public static void CameraSetupApplyWithZ(JassCameraSetup whichSetup, Single zDestOffset)
        {
            InternalNatives.CameraSetupApplyWithZ(whichSetup, zDestOffset);
        }
        
        public static void CameraSetupApplyForceDuration(JassCameraSetup whichSetup, Boolean doPan, Single forceDuration)
        {
            InternalNatives.CameraSetupApplyForceDuration(whichSetup, doPan, forceDuration);
        }
        
        public static void CameraSetupApplyForceDurationWithZ(JassCameraSetup whichSetup, Single zDestOffset, Single forceDuration)
        {
            InternalNatives.CameraSetupApplyForceDurationWithZ(whichSetup, zDestOffset, forceDuration);
        }
        
        public static void CameraSetTargetNoise(Single mag, Single velocity)
        {
            InternalNatives.CameraSetTargetNoise(mag, velocity);
        }
        
        public static void CameraSetSourceNoise(Single mag, Single velocity)
        {
            InternalNatives.CameraSetSourceNoise(mag, velocity);
        }
        
        public static void CameraSetTargetNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            InternalNatives.CameraSetTargetNoiseEx(mag, velocity, vertOnly);
        }
        
        public static void CameraSetSourceNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            InternalNatives.CameraSetSourceNoiseEx(mag, velocity, vertOnly);
        }
        
        public static void CameraSetSmoothingFactor(Single factor)
        {
            InternalNatives.CameraSetSmoothingFactor(factor);
        }
        
        public static void SetCineFilterTexture(String filename)
        {
            InternalNatives.SetCineFilterTexture(filename);
        }
        
        public static void SetCineFilterBlendMode(JassBlendMode whichMode)
        {
            InternalNatives.SetCineFilterBlendMode(whichMode);
        }
        
        public static void SetCineFilterTexMapFlags(JassTextureMapFlags whichFlags)
        {
            InternalNatives.SetCineFilterTexMapFlags(whichFlags);
        }
        
        public static void SetCineFilterStartUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            InternalNatives.SetCineFilterStartUV(minu, minv, maxu, maxv);
        }
        
        public static void SetCineFilterEndUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            InternalNatives.SetCineFilterEndUV(minu, minv, maxu, maxv);
        }
        
        public static void SetCineFilterStartColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetCineFilterStartColor(red, green, blue, alpha);
        }
        
        public static void SetCineFilterEndColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetCineFilterEndColor(red, green, blue, alpha);
        }
        
        public static void SetCineFilterDuration(Single duration)
        {
            InternalNatives.SetCineFilterDuration(duration);
        }
        
        public static void DisplayCineFilter(Boolean flag)
        {
            InternalNatives.DisplayCineFilter(flag);
        }
        
        public static Boolean IsCineFilterDisplayed()
        {
            return InternalNatives.IsCineFilterDisplayed();
        }
        
        public static void SetCinematicScene(JassInteger portraitUnitId, JassPlayerColor color, String speakerTitle, String text, Single sceneDuration, Single voiceoverDuration)
        {
            InternalNatives.SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);
        }
        
        public static void EndCinematicScene()
        {
            InternalNatives.EndCinematicScene();
        }
        
        public static void ForceCinematicSubtitles(Boolean flag)
        {
            InternalNatives.ForceCinematicSubtitles(flag);
        }
        
        public static Single GetCameraMargin(JassInteger whichMargin)
        {
            return InternalNatives.GetCameraMargin(whichMargin);
        }
        
        public static Single GetCameraBoundMinX()
        {
            return InternalNatives.GetCameraBoundMinX();
        }
        
        public static Single GetCameraBoundMinY()
        {
            return InternalNatives.GetCameraBoundMinY();
        }
        
        public static Single GetCameraBoundMaxX()
        {
            return InternalNatives.GetCameraBoundMaxX();
        }
        
        public static Single GetCameraBoundMaxY()
        {
            return InternalNatives.GetCameraBoundMaxY();
        }
        
        public static Single GetCameraField(JassCameraField whichField)
        {
            return InternalNatives.GetCameraField(whichField);
        }
        
        public static Single GetCameraTargetPositionX()
        {
            return InternalNatives.GetCameraTargetPositionX();
        }
        
        public static Single GetCameraTargetPositionY()
        {
            return InternalNatives.GetCameraTargetPositionY();
        }
        
        public static Single GetCameraTargetPositionZ()
        {
            return InternalNatives.GetCameraTargetPositionZ();
        }
        
        public static JassLocation GetCameraTargetPositionLoc()
        {
            return InternalNatives.GetCameraTargetPositionLoc();
        }
        
        public static Single GetCameraEyePositionX()
        {
            return InternalNatives.GetCameraEyePositionX();
        }
        
        public static Single GetCameraEyePositionY()
        {
            return InternalNatives.GetCameraEyePositionY();
        }
        
        public static Single GetCameraEyePositionZ()
        {
            return InternalNatives.GetCameraEyePositionZ();
        }
        
        public static JassLocation GetCameraEyePositionLoc()
        {
            return InternalNatives.GetCameraEyePositionLoc();
        }
        
        public static void NewSoundEnvironment(String environmentName)
        {
            InternalNatives.NewSoundEnvironment(environmentName);
        }
        
        public static JassSound CreateSound(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String eaxSetting)
        {
            return InternalNatives.CreateSound(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, eaxSetting);
        }
        
        public static JassSound CreateSoundFilenameWithLabel(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String SLKEntryName)
        {
            return InternalNatives.CreateSoundFilenameWithLabel(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, SLKEntryName);
        }
        
        public static JassSound CreateSoundFromLabel(String soundLabel, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return InternalNatives.CreateSoundFromLabel(soundLabel, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate);
        }
        
        public static JassSound CreateMIDISound(String soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return InternalNatives.CreateMIDISound(soundLabel, fadeInRate, fadeOutRate);
        }
        
        public static void SetSoundParamsFromLabel(JassSound soundHandle, String soundLabel)
        {
            InternalNatives.SetSoundParamsFromLabel(soundHandle, soundLabel);
        }
        
        public static void SetSoundDistanceCutoff(JassSound soundHandle, Single cutoff)
        {
            InternalNatives.SetSoundDistanceCutoff(soundHandle, cutoff);
        }
        
        public static void SetSoundChannel(JassSound soundHandle, JassInteger channel)
        {
            InternalNatives.SetSoundChannel(soundHandle, channel);
        }
        
        public static void SetSoundVolume(JassSound soundHandle, JassInteger volume)
        {
            InternalNatives.SetSoundVolume(soundHandle, volume);
        }
        
        public static void SetSoundPitch(JassSound soundHandle, Single pitch)
        {
            InternalNatives.SetSoundPitch(soundHandle, pitch);
        }
        
        public static void SetSoundPlayPosition(JassSound soundHandle, JassInteger millisecs)
        {
            InternalNatives.SetSoundPlayPosition(soundHandle, millisecs);
        }
        
        public static void SetSoundDistances(JassSound soundHandle, Single minDist, Single maxDist)
        {
            InternalNatives.SetSoundDistances(soundHandle, minDist, maxDist);
        }
        
        public static void SetSoundConeAngles(JassSound soundHandle, Single inside, Single outside, JassInteger outsideVolume)
        {
            InternalNatives.SetSoundConeAngles(soundHandle, inside, outside, outsideVolume);
        }
        
        public static void SetSoundConeOrientation(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives.SetSoundConeOrientation(soundHandle, x, y, z);
        }
        
        public static void SetSoundPosition(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives.SetSoundPosition(soundHandle, x, y, z);
        }
        
        public static void SetSoundVelocity(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives.SetSoundVelocity(soundHandle, x, y, z);
        }
        
        public static void AttachSoundToUnit(JassSound soundHandle, JassUnit whichUnit)
        {
            InternalNatives.AttachSoundToUnit(soundHandle, whichUnit);
        }
        
        public static void StartSound(JassSound soundHandle)
        {
            InternalNatives.StartSound(soundHandle);
        }
        
        public static void StopSound(JassSound soundHandle, Boolean killWhenDone, Boolean fadeOut)
        {
            InternalNatives.StopSound(soundHandle, killWhenDone, fadeOut);
        }
        
        public static void KillSoundWhenDone(JassSound soundHandle)
        {
            InternalNatives.KillSoundWhenDone(soundHandle);
        }
        
        public static void SetMapMusic(String musicName, Boolean random, JassInteger index)
        {
            InternalNatives.SetMapMusic(musicName, random, index);
        }
        
        public static void ClearMapMusic()
        {
            InternalNatives.ClearMapMusic();
        }
        
        public static void PlayMusic(String musicName)
        {
            InternalNatives.PlayMusic(musicName);
        }
        
        public static void PlayMusicEx(String musicName, JassInteger frommsecs, JassInteger fadeinmsecs)
        {
            InternalNatives.PlayMusicEx(musicName, frommsecs, fadeinmsecs);
        }
        
        public static void StopMusic(Boolean fadeOut)
        {
            InternalNatives.StopMusic(fadeOut);
        }
        
        public static void ResumeMusic()
        {
            InternalNatives.ResumeMusic();
        }
        
        public static void PlayThematicMusic(String musicFileName)
        {
            InternalNatives.PlayThematicMusic(musicFileName);
        }
        
        public static void PlayThematicMusicEx(String musicFileName, JassInteger frommsecs)
        {
            InternalNatives.PlayThematicMusicEx(musicFileName, frommsecs);
        }
        
        public static void EndThematicMusic()
        {
            InternalNatives.EndThematicMusic();
        }
        
        public static void SetMusicVolume(JassInteger volume)
        {
            InternalNatives.SetMusicVolume(volume);
        }
        
        public static void SetMusicPlayPosition(JassInteger millisecs)
        {
            InternalNatives.SetMusicPlayPosition(millisecs);
        }
        
        public static void SetThematicMusicPlayPosition(JassInteger millisecs)
        {
            InternalNatives.SetThematicMusicPlayPosition(millisecs);
        }
        
        public static void SetSoundDuration(JassSound soundHandle, JassInteger duration)
        {
            InternalNatives.SetSoundDuration(soundHandle, duration);
        }
        
        public static JassInteger GetSoundDuration(JassSound soundHandle)
        {
            return InternalNatives.GetSoundDuration(soundHandle);
        }
        
        public static JassInteger GetSoundFileDuration(String musicFileName)
        {
            return InternalNatives.GetSoundFileDuration(musicFileName);
        }
        
        public static void VolumeGroupSetVolume(JassVolumeGroup vgroup, Single scale)
        {
            InternalNatives.VolumeGroupSetVolume(vgroup, scale);
        }
        
        public static void VolumeGroupReset()
        {
            InternalNatives.VolumeGroupReset();
        }
        
        public static Boolean GetSoundIsPlaying(JassSound soundHandle)
        {
            return InternalNatives.GetSoundIsPlaying(soundHandle);
        }
        
        public static Boolean GetSoundIsLoading(JassSound soundHandle)
        {
            return InternalNatives.GetSoundIsLoading(soundHandle);
        }
        
        public static void RegisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            InternalNatives.RegisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        public static void UnregisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            InternalNatives.UnregisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        public static JassWeatherEffect AddWeatherEffect(JassRect where, JassInteger effectID)
        {
            return InternalNatives.AddWeatherEffect(where, effectID);
        }
        
        public static void RemoveWeatherEffect(JassWeatherEffect whichEffect)
        {
            InternalNatives.RemoveWeatherEffect(whichEffect);
        }
        
        public static void EnableWeatherEffect(JassWeatherEffect whichEffect, Boolean enable)
        {
            InternalNatives.EnableWeatherEffect(whichEffect, enable);
        }
        
        public static JassTerrainDeformation TerrainDeformCrater(Single x, Single y, Single radius, Single depth, JassInteger duration, Boolean permanent)
        {
            return InternalNatives.TerrainDeformCrater(x, y, radius, depth, duration, permanent);
        }
        
        public static JassTerrainDeformation TerrainDeformRipple(Single x, Single y, Single radius, Single depth, JassInteger duration, JassInteger count, Single spaceWaves, Single timeWaves, Single radiusStartPct, Boolean limitNeg)
        {
            return InternalNatives.TerrainDeformRipple(x, y, radius, depth, duration, count, spaceWaves, timeWaves, radiusStartPct, limitNeg);
        }
        
        public static JassTerrainDeformation TerrainDeformWave(Single x, Single y, Single dirX, Single dirY, Single distance, Single speed, Single radius, Single depth, JassInteger trailTime, JassInteger count)
        {
            return InternalNatives.TerrainDeformWave(x, y, dirX, dirY, distance, speed, radius, depth, trailTime, count);
        }
        
        public static JassTerrainDeformation TerrainDeformRandom(Single x, Single y, Single radius, Single minDelta, Single maxDelta, JassInteger duration, JassInteger updateInterval)
        {
            return InternalNatives.TerrainDeformRandom(x, y, radius, minDelta, maxDelta, duration, updateInterval);
        }
        
        public static void TerrainDeformStop(JassTerrainDeformation deformation, JassInteger duration)
        {
            InternalNatives.TerrainDeformStop(deformation, duration);
        }
        
        public static void TerrainDeformStopAll()
        {
            InternalNatives.TerrainDeformStopAll();
        }
        
        public static JassEffect AddSpecialEffect(String modelName, Single x, Single y)
        {
            return InternalNatives.AddSpecialEffect(modelName, x, y);
        }
        
        public static JassEffect AddSpecialEffectLoc(String modelName, JassLocation where)
        {
            return InternalNatives.AddSpecialEffectLoc(modelName, where);
        }
        
        public static JassEffect AddSpecialEffectTarget(String modelName, JassWidget targetWidget, String attachPointName)
        {
            return InternalNatives.AddSpecialEffectTarget(modelName, targetWidget, attachPointName);
        }
        
        public static void DestroyEffect(JassEffect whichEffect)
        {
            InternalNatives.DestroyEffect(whichEffect);
        }
        
        public static JassEffect AddSpellEffect(String abilityString, JassEffectType t, Single x, Single y)
        {
            return InternalNatives.AddSpellEffect(abilityString, t, x, y);
        }
        
        public static JassEffect AddSpellEffectLoc(String abilityString, JassEffectType t, JassLocation where)
        {
            return InternalNatives.AddSpellEffectLoc(abilityString, t, where);
        }
        
        public static JassEffect AddSpellEffectById(JassInteger abilityId, JassEffectType t, Single x, Single y)
        {
            return InternalNatives.AddSpellEffectById(abilityId, t, x, y);
        }
        
        public static JassEffect AddSpellEffectByIdLoc(JassInteger abilityId, JassEffectType t, JassLocation where)
        {
            return InternalNatives.AddSpellEffectByIdLoc(abilityId, t, where);
        }
        
        public static JassEffect AddSpellEffectTarget(String modelName, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return InternalNatives.AddSpellEffectTarget(modelName, t, targetWidget, attachPoint);
        }
        
        public static JassEffect AddSpellEffectTargetById(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return InternalNatives.AddSpellEffectTargetById(abilityId, t, targetWidget, attachPoint);
        }
        
        public static JassLightning AddLightning(String codeName, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return InternalNatives.AddLightning(codeName, checkVisibility, x1, y1, x2, y2);
        }
        
        public static JassLightning AddLightningEx(String codeName, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return InternalNatives.AddLightningEx(codeName, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        public static Boolean DestroyLightning(JassLightning whichBolt)
        {
            return InternalNatives.DestroyLightning(whichBolt);
        }
        
        public static Boolean MoveLightning(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return InternalNatives.MoveLightning(whichBolt, checkVisibility, x1, y1, x2, y2);
        }
        
        public static Boolean MoveLightningEx(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return InternalNatives.MoveLightningEx(whichBolt, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        public static Single GetLightningColorA(JassLightning whichBolt)
        {
            return InternalNatives.GetLightningColorA(whichBolt);
        }
        
        public static Single GetLightningColorR(JassLightning whichBolt)
        {
            return InternalNatives.GetLightningColorR(whichBolt);
        }
        
        public static Single GetLightningColorG(JassLightning whichBolt)
        {
            return InternalNatives.GetLightningColorG(whichBolt);
        }
        
        public static Single GetLightningColorB(JassLightning whichBolt)
        {
            return InternalNatives.GetLightningColorB(whichBolt);
        }
        
        public static Boolean SetLightningColor(JassLightning whichBolt, Single r, Single g, Single b, Single a)
        {
            return InternalNatives.SetLightningColor(whichBolt, r, g, b, a);
        }
        
        public static String GetAbilityEffect(String abilityString, JassEffectType t, JassInteger index)
        {
            return InternalNatives.GetAbilityEffect(abilityString, t, index);
        }
        
        public static String GetAbilityEffectById(JassInteger abilityId, JassEffectType t, JassInteger index)
        {
            return InternalNatives.GetAbilityEffectById(abilityId, t, index);
        }
        
        public static String GetAbilitySound(String abilityString, JassSoundType t)
        {
            return InternalNatives.GetAbilitySound(abilityString, t);
        }
        
        public static String GetAbilitySoundById(JassInteger abilityId, JassSoundType t)
        {
            return InternalNatives.GetAbilitySoundById(abilityId, t);
        }
        
        public static JassInteger GetTerrainCliffLevel(Single x, Single y)
        {
            return InternalNatives.GetTerrainCliffLevel(x, y);
        }
        
        public static void SetWaterBaseColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetWaterBaseColor(red, green, blue, alpha);
        }
        
        public static void SetWaterDeforms(Boolean val)
        {
            InternalNatives.SetWaterDeforms(val);
        }
        
        public static JassInteger GetTerrainType(Single x, Single y)
        {
            return InternalNatives.GetTerrainType(x, y);
        }
        
        public static JassInteger GetTerrainVariance(Single x, Single y)
        {
            return InternalNatives.GetTerrainVariance(x, y);
        }
        
        public static void SetTerrainType(Single x, Single y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape)
        {
            InternalNatives.SetTerrainType(x, y, terrainType, variation, area, shape);
        }
        
        public static Boolean IsTerrainPathable(Single x, Single y, JassPathingType t)
        {
            return InternalNatives.IsTerrainPathable(x, y, t);
        }
        
        public static void SetTerrainPathable(Single x, Single y, JassPathingType t, Boolean flag)
        {
            InternalNatives.SetTerrainPathable(x, y, t, flag);
        }
        
        public static JassImage CreateImage(String file, Single sizeX, Single sizeY, Single sizeZ, Single posX, Single posY, Single posZ, Single originX, Single originY, Single originZ, JassInteger imageType)
        {
            return InternalNatives.CreateImage(file, sizeX, sizeY, sizeZ, posX, posY, posZ, originX, originY, originZ, imageType);
        }
        
        public static void DestroyImage(JassImage whichImage)
        {
            InternalNatives.DestroyImage(whichImage);
        }
        
        public static void ShowImage(JassImage whichImage, Boolean flag)
        {
            InternalNatives.ShowImage(whichImage, flag);
        }
        
        public static void SetImageConstantHeight(JassImage whichImage, Boolean flag, Single height)
        {
            InternalNatives.SetImageConstantHeight(whichImage, flag, height);
        }
        
        public static void SetImagePosition(JassImage whichImage, Single x, Single y, Single z)
        {
            InternalNatives.SetImagePosition(whichImage, x, y, z);
        }
        
        public static void SetImageColor(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetImageColor(whichImage, red, green, blue, alpha);
        }
        
        public static void SetImageRender(JassImage whichImage, Boolean flag)
        {
            InternalNatives.SetImageRender(whichImage, flag);
        }
        
        public static void SetImageRenderAlways(JassImage whichImage, Boolean flag)
        {
            InternalNatives.SetImageRenderAlways(whichImage, flag);
        }
        
        public static void SetImageAboveWater(JassImage whichImage, Boolean flag, Boolean useWaterAlpha)
        {
            InternalNatives.SetImageAboveWater(whichImage, flag, useWaterAlpha);
        }
        
        public static void SetImageType(JassImage whichImage, JassInteger imageType)
        {
            InternalNatives.SetImageType(whichImage, imageType);
        }
        
        public static JassUberSplat CreateUbersplat(Single x, Single y, String name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, Boolean forcePaused, Boolean noBirthTime)
        {
            return InternalNatives.CreateUbersplat(x, y, name, red, green, blue, alpha, forcePaused, noBirthTime);
        }
        
        public static void DestroyUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives.DestroyUbersplat(whichSplat);
        }
        
        public static void ResetUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives.ResetUbersplat(whichSplat);
        }
        
        public static void FinishUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives.FinishUbersplat(whichSplat);
        }
        
        public static void ShowUbersplat(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives.ShowUbersplat(whichSplat, flag);
        }
        
        public static void SetUbersplatRender(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives.SetUbersplatRender(whichSplat, flag);
        }
        
        public static void SetUbersplatRenderAlways(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives.SetUbersplatRenderAlways(whichSplat, flag);
        }
        
        public static void SetBlight(JassPlayer whichPlayer, Single x, Single y, Single radius, Boolean addBlight)
        {
            InternalNatives.SetBlight(whichPlayer, x, y, radius, addBlight);
        }
        
        public static void SetBlightRect(JassPlayer whichPlayer, JassRect r, Boolean addBlight)
        {
            InternalNatives.SetBlightRect(whichPlayer, r, addBlight);
        }
        
        public static void SetBlightPoint(JassPlayer whichPlayer, Single x, Single y, Boolean addBlight)
        {
            InternalNatives.SetBlightPoint(whichPlayer, x, y, addBlight);
        }
        
        public static void SetBlightLoc(JassPlayer whichPlayer, JassLocation whichLocation, Single radius, Boolean addBlight)
        {
            InternalNatives.SetBlightLoc(whichPlayer, whichLocation, radius, addBlight);
        }
        
        public static JassUnit CreateBlightedGoldmine(JassPlayer id, Single x, Single y, Single face)
        {
            return InternalNatives.CreateBlightedGoldmine(id, x, y, face);
        }
        
        public static Boolean IsPointBlighted(Single x, Single y)
        {
            return InternalNatives.IsPointBlighted(x, y);
        }
        
        public static void SetDoodadAnimation(Single x, Single y, Single radius, JassObjectId doodadID, Boolean nearestOnly, String animName, Boolean animRandom)
        {
            InternalNatives.SetDoodadAnimation(x, y, radius, doodadID, nearestOnly, animName, animRandom);
        }
        
        public static void SetDoodadAnimationRect(JassRect r, JassObjectId doodadID, String animName, Boolean animRandom)
        {
            InternalNatives.SetDoodadAnimationRect(r, doodadID, animName, animRandom);
        }
        
        public static void StartMeleeAI(JassPlayer num, String script)
        {
            InternalNatives.StartMeleeAI(num, script);
        }
        
        public static void StartCampaignAI(JassPlayer num, String script)
        {
            InternalNatives.StartCampaignAI(num, script);
        }
        
        public static void CommandAI(JassPlayer num, JassInteger command, JassInteger data)
        {
            InternalNatives.CommandAI(num, command, data);
        }
        
        public static void PauseCompAI(JassPlayer p, Boolean pause)
        {
            InternalNatives.PauseCompAI(p, pause);
        }
        
        public static JassAIDifficulty GetAIDifficulty(JassPlayer num)
        {
            return InternalNatives.GetAIDifficulty(num);
        }
        
        public static void RemoveGuardPosition(JassUnit hUnit)
        {
            InternalNatives.RemoveGuardPosition(hUnit);
        }
        
        public static void RecycleGuardPosition(JassUnit hUnit)
        {
            InternalNatives.RecycleGuardPosition(hUnit);
        }
        
        public static void RemoveAllGuardPositions(JassPlayer num)
        {
            InternalNatives.RemoveAllGuardPositions(num);
        }
        
        public static void Cheat(String cheatStr)
        {
            InternalNatives.Cheat(cheatStr);
        }
        
        public static Boolean IsNoVictoryCheat()
        {
            return InternalNatives.IsNoVictoryCheat();
        }
        
        public static Boolean IsNoDefeatCheat()
        {
            return InternalNatives.IsNoDefeatCheat();
        }
        
        public static void Preload(String filename)
        {
            InternalNatives.Preload(filename);
        }
        
        public static void PreloadEnd(Single timeout)
        {
            InternalNatives.PreloadEnd(timeout);
        }
        
        public static void PreloadStart()
        {
            InternalNatives.PreloadStart();
        }
        
        public static void PreloadRefresh()
        {
            InternalNatives.PreloadRefresh();
        }
        
        public static void PreloadEndEx()
        {
            InternalNatives.PreloadEndEx();
        }
        
        public static void PreloadGenClear()
        {
            InternalNatives.PreloadGenClear();
        }
        
        public static void PreloadGenStart()
        {
            InternalNatives.PreloadGenStart();
        }
        
        public static void PreloadGenEnd(String filename)
        {
            InternalNatives.PreloadGenEnd(filename);
        }
        
        public static void Preloader(String filename)
        {
            InternalNatives.Preloader(filename);
        }
        
    }
}
