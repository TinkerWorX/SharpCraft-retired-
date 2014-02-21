using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI
{
    public partial class Natives
    {
        private JassRace convertRace(JassInteger i)
        {
            return InternalNatives.ConvertRace(i);
        }
        
        private JassAllianceType convertAllianceType(JassInteger i)
        {
            return InternalNatives.ConvertAllianceType(i);
        }
        
        private JassRacePreference convertRacePref(JassInteger i)
        {
            return InternalNatives.ConvertRacePref(i);
        }
        
        private JassIGameState convertIGameState(JassInteger i)
        {
            return InternalNatives.ConvertIGameState(i);
        }
        
        private JassFGameState convertFGameState(JassInteger i)
        {
            return InternalNatives.ConvertFGameState(i);
        }
        
        private JassPlayerState convertPlayerState(JassInteger i)
        {
            return InternalNatives.ConvertPlayerState(i);
        }
        
        private JassPlayerScore convertPlayerScore(JassInteger i)
        {
            return InternalNatives.ConvertPlayerScore(i);
        }
        
        private JassPlayerGameResult convertPlayerGameResult(JassInteger i)
        {
            return InternalNatives.ConvertPlayerGameResult(i);
        }
        
        private JassUnitState convertUnitState(JassInteger i)
        {
            return InternalNatives.ConvertUnitState(i);
        }
        
        private JassAIDifficulty convertAIDifficulty(JassInteger i)
        {
            return InternalNatives.ConvertAIDifficulty(i);
        }
        
        private JassGameEvent convertGameEvent(JassInteger i)
        {
            return InternalNatives.ConvertGameEvent(i);
        }
        
        private JassPlayerEvent convertPlayerEvent(JassInteger i)
        {
            return InternalNatives.ConvertPlayerEvent(i);
        }
        
        private JassPlayerUnitEvent convertPlayerUnitEvent(JassInteger i)
        {
            return InternalNatives.ConvertPlayerUnitEvent(i);
        }
        
        private JassWidgetEvent convertWidgetEvent(JassInteger i)
        {
            return InternalNatives.ConvertWidgetEvent(i);
        }
        
        private JassDialogEvent convertDialogEvent(JassInteger i)
        {
            return InternalNatives.ConvertDialogEvent(i);
        }
        
        private JassUnitEvent convertUnitEvent(JassInteger i)
        {
            return InternalNatives.ConvertUnitEvent(i);
        }
        
        private JassLimitOp convertLimitOp(JassInteger i)
        {
            return InternalNatives.ConvertLimitOp(i);
        }
        
        private JassUnitType convertUnitType(JassInteger i)
        {
            return InternalNatives.ConvertUnitType(i);
        }
        
        private JassGameSpeed convertGameSpeed(JassInteger i)
        {
            return InternalNatives.ConvertGameSpeed(i);
        }
        
        private JassPlacement convertPlacement(JassInteger i)
        {
            return InternalNatives.ConvertPlacement(i);
        }
        
        private JassStartLocationPriority convertStartLocPrio(JassInteger i)
        {
            return InternalNatives.ConvertStartLocPrio(i);
        }
        
        private JassGameDifficulty convertGameDifficulty(JassInteger i)
        {
            return InternalNatives.ConvertGameDifficulty(i);
        }
        
        private JassGameType convertGameType(JassInteger i)
        {
            return InternalNatives.ConvertGameType(i);
        }
        
        private JassMapFlag convertMapFlag(JassInteger i)
        {
            return InternalNatives.ConvertMapFlag(i);
        }
        
        private JassMapVisibility convertMapVisibility(JassInteger i)
        {
            return InternalNatives.ConvertMapVisibility(i);
        }
        
        private JassMapSetting convertMapSetting(JassInteger i)
        {
            return InternalNatives.ConvertMapSetting(i);
        }
        
        private JassMapDensity convertMapDensity(JassInteger i)
        {
            return InternalNatives.ConvertMapDensity(i);
        }
        
        private JassMapControl convertMapControl(JassInteger i)
        {
            return InternalNatives.ConvertMapControl(i);
        }
        
        private JassPlayerColor convertPlayerColor(JassInteger i)
        {
            return InternalNatives.ConvertPlayerColor(i);
        }
        
        private JassPlayerSlotState convertPlayerSlotState(JassInteger i)
        {
            return InternalNatives.ConvertPlayerSlotState(i);
        }
        
        private JassVolumeGroup convertVolumeGroup(JassInteger i)
        {
            return InternalNatives.ConvertVolumeGroup(i);
        }
        
        private JassCameraField convertCameraField(JassInteger i)
        {
            return InternalNatives.ConvertCameraField(i);
        }
        
        private JassBlendMode convertBlendMode(JassInteger i)
        {
            return InternalNatives.ConvertBlendMode(i);
        }
        
        private JassRarityControl convertRarityControl(JassInteger i)
        {
            return InternalNatives.ConvertRarityControl(i);
        }
        
        private JassTextureMapFlags convertTexMapFlags(JassInteger i)
        {
            return InternalNatives.ConvertTexMapFlags(i);
        }
        
        private JassFogState convertFogState(JassInteger i)
        {
            return InternalNatives.ConvertFogState(i);
        }
        
        private JassEffectType convertEffectType(JassInteger i)
        {
            return InternalNatives.ConvertEffectType(i);
        }
        
        private JassVersion convertVersion(JassInteger i)
        {
            return InternalNatives.ConvertVersion(i);
        }
        
        private JassItemType convertItemType(JassInteger i)
        {
            return InternalNatives.ConvertItemType(i);
        }
        
        private JassAttackType convertAttackType(JassInteger i)
        {
            return InternalNatives.ConvertAttackType(i);
        }
        
        private JassDamageType convertDamageType(JassInteger i)
        {
            return InternalNatives.ConvertDamageType(i);
        }
        
        private JassWeaponType convertWeaponType(JassInteger i)
        {
            return InternalNatives.ConvertWeaponType(i);
        }
        
        private JassSoundType convertSoundType(JassInteger i)
        {
            return InternalNatives.ConvertSoundType(i);
        }
        
        private JassPathingType convertPathingType(JassInteger i)
        {
            return InternalNatives.ConvertPathingType(i);
        }
        
        private JassOrder orderId(String orderIdString)
        {
            return InternalNatives.OrderId(orderIdString);
        }
        
        private String orderId2String(JassOrder orderId)
        {
            return InternalNatives.OrderId2String(orderId);
        }
        
        private JassObjectId unitId(String unitIdString)
        {
            return InternalNatives.UnitId(unitIdString);
        }
        
        private String unitId2String(JassObjectId unitId)
        {
            return InternalNatives.UnitId2String(unitId);
        }
        
        private JassObjectId abilityId(String abilityIdString)
        {
            return InternalNatives.AbilityId(abilityIdString);
        }
        
        private String abilityId2String(JassInteger abilityId)
        {
            return InternalNatives.AbilityId2String(abilityId);
        }
        
        private String getObjectName(JassObjectId objectId)
        {
            return InternalNatives.GetObjectName(objectId);
        }
        
        private Single deg2Rad(Single degrees)
        {
            return InternalNatives.Deg2Rad(degrees);
        }
        
        private Single rad2Deg(Single radians)
        {
            return InternalNatives.Rad2Deg(radians);
        }
        
        private Single sin(Single radians)
        {
            return InternalNatives.Sin(radians);
        }
        
        private Single cos(Single radians)
        {
            return InternalNatives.Cos(radians);
        }
        
        private Single tan(Single radians)
        {
            return InternalNatives.Tan(radians);
        }
        
        private Single asin(Single y)
        {
            return InternalNatives.Asin(y);
        }
        
        private Single acos(Single x)
        {
            return InternalNatives.Acos(x);
        }
        
        private Single atan(Single x)
        {
            return InternalNatives.Atan(x);
        }
        
        private Single atan2(Single y, Single x)
        {
            return InternalNatives.Atan2(y, x);
        }
        
        private Single squareRoot(Single x)
        {
            return InternalNatives.SquareRoot(x);
        }
        
        private Single pow(Single x, Single power)
        {
            return InternalNatives.Pow(x, power);
        }
        
        private Single i2R(JassInteger i)
        {
            return InternalNatives.I2R(i);
        }
        
        private JassInteger r2I(Single r)
        {
            return InternalNatives.R2I(r);
        }
        
        private String i2S(JassInteger i)
        {
            return InternalNatives.I2S(i);
        }
        
        private String r2S(Single r)
        {
            return InternalNatives.R2S(r);
        }
        
        private String r2SW(Single r, JassInteger width, JassInteger precision)
        {
            return InternalNatives.R2SW(r, width, precision);
        }
        
        private JassInteger s2I(String s)
        {
            return InternalNatives.S2I(s);
        }
        
        private Single s2R(String s)
        {
            return InternalNatives.S2R(s);
        }
        
        private JassInteger getHandleId(JassHandle h)
        {
            return InternalNatives.GetHandleId(h);
        }
        
        private String subString(String source, JassInteger start, JassInteger end)
        {
            return InternalNatives.SubString(source, start, end);
        }
        
        private JassInteger stringLength(String s)
        {
            return InternalNatives.StringLength(s);
        }
        
        private String stringCase(String source, Boolean upper)
        {
            return InternalNatives.StringCase(source, upper);
        }
        
        private JassInteger stringHash(String s)
        {
            return InternalNatives.StringHash(s);
        }
        
        private String getLocalizedString(String source)
        {
            return InternalNatives.GetLocalizedString(source);
        }
        
        private JassInteger getLocalizedHotkey(String source)
        {
            return InternalNatives.GetLocalizedHotkey(source);
        }
        
        private void setMapName(String name)
        {
            InternalNatives.SetMapName(name);
        }
        
        private void setMapDescription(String description)
        {
            InternalNatives.SetMapDescription(description);
        }
        
        private void setTeams(JassInteger teamcount)
        {
            InternalNatives.SetTeams(teamcount);
        }
        
        private void setPlayers(JassInteger playercount)
        {
            InternalNatives.SetPlayers(playercount);
        }
        
        private void defineStartLocation(JassInteger whichStartLoc, Single x, Single y)
        {
            InternalNatives.DefineStartLocation(whichStartLoc, x, y);
        }
        
        private void defineStartLocationLoc(JassInteger whichStartLoc, JassLocation whichLocation)
        {
            InternalNatives.DefineStartLocationLoc(whichStartLoc, whichLocation);
        }
        
        private void setStartLocPrioCount(JassInteger whichStartLoc, JassInteger prioSlotCount)
        {
            InternalNatives.SetStartLocPrioCount(whichStartLoc, prioSlotCount);
        }
        
        private void setStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority)
        {
            InternalNatives.SetStartLocPrio(whichStartLoc, prioSlotIndex, otherStartLocIndex, priority);
        }
        
        private JassInteger getStartLocPrioSlot(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return InternalNatives.GetStartLocPrioSlot(whichStartLoc, prioSlotIndex);
        }
        
        private JassStartLocationPriority getStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return InternalNatives.GetStartLocPrio(whichStartLoc, prioSlotIndex);
        }
        
        private void setGameTypeSupported(JassGameType whichGameType, Boolean value)
        {
            InternalNatives.SetGameTypeSupported(whichGameType, value);
        }
        
        private void setMapFlag(JassMapFlag whichMapFlag, Boolean value)
        {
            InternalNatives.SetMapFlag(whichMapFlag, value);
        }
        
        private void setGamePlacement(JassPlacement whichPlacementType)
        {
            InternalNatives.SetGamePlacement(whichPlacementType);
        }
        
        private void setGameSpeed(JassGameSpeed whichspeed)
        {
            InternalNatives.SetGameSpeed(whichspeed);
        }
        
        private void setGameDifficulty(JassGameDifficulty whichdifficulty)
        {
            InternalNatives.SetGameDifficulty(whichdifficulty);
        }
        
        private void setResourceDensity(JassMapDensity whichdensity)
        {
            InternalNatives.SetResourceDensity(whichdensity);
        }
        
        private void setCreatureDensity(JassMapDensity whichdensity)
        {
            InternalNatives.SetCreatureDensity(whichdensity);
        }
        
        private JassInteger getTeams()
        {
            return InternalNatives.GetTeams();
        }
        
        private JassInteger getPlayers()
        {
            return InternalNatives.GetPlayers();
        }
        
        private Boolean isGameTypeSupported(JassGameType whichGameType)
        {
            return InternalNatives.IsGameTypeSupported(whichGameType);
        }
        
        private JassGameType getGameTypeSelected()
        {
            return InternalNatives.GetGameTypeSelected();
        }
        
        private Boolean isMapFlagSet(JassMapFlag whichMapFlag)
        {
            return InternalNatives.IsMapFlagSet(whichMapFlag);
        }
        
        private JassPlacement getGamePlacement()
        {
            return InternalNatives.GetGamePlacement();
        }
        
        private JassGameSpeed getGameSpeed()
        {
            return InternalNatives.GetGameSpeed();
        }
        
        private JassGameDifficulty getGameDifficulty()
        {
            return InternalNatives.GetGameDifficulty();
        }
        
        private JassMapDensity getResourceDensity()
        {
            return InternalNatives.GetResourceDensity();
        }
        
        private JassMapDensity getCreatureDensity()
        {
            return InternalNatives.GetCreatureDensity();
        }
        
        private Single getStartLocationX(JassInteger whichStartLocation)
        {
            return InternalNatives.GetStartLocationX(whichStartLocation);
        }
        
        private Single getStartLocationY(JassInteger whichStartLocation)
        {
            return InternalNatives.GetStartLocationY(whichStartLocation);
        }
        
        private JassLocation getStartLocationLoc(JassInteger whichStartLocation)
        {
            return InternalNatives.GetStartLocationLoc(whichStartLocation);
        }
        
        private void setPlayerTeam(JassPlayer whichPlayer, JassInteger whichTeam)
        {
            InternalNatives.SetPlayerTeam(whichPlayer, whichTeam);
        }
        
        private void setPlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            InternalNatives.SetPlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        private void forcePlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            InternalNatives.ForcePlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        private void setPlayerColor(JassPlayer whichPlayer, JassPlayerColor color)
        {
            InternalNatives.SetPlayerColor(whichPlayer, color);
        }
        
        private void setPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, Boolean value)
        {
            InternalNatives.SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);
        }
        
        private void setPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate)
        {
            InternalNatives.SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);
        }
        
        private void setPlayerRacePreference(JassPlayer whichPlayer, JassRacePreference whichRacePreference)
        {
            InternalNatives.SetPlayerRacePreference(whichPlayer, whichRacePreference);
        }
        
        private void setPlayerRaceSelectable(JassPlayer whichPlayer, Boolean value)
        {
            InternalNatives.SetPlayerRaceSelectable(whichPlayer, value);
        }
        
        private void setPlayerController(JassPlayer whichPlayer, JassMapControl controlType)
        {
            InternalNatives.SetPlayerController(whichPlayer, controlType);
        }
        
        private void setPlayerName(JassPlayer whichPlayer, String name)
        {
            InternalNatives.SetPlayerName(whichPlayer, name);
        }
        
        private void setPlayerOnScoreScreen(JassPlayer whichPlayer, Boolean flag)
        {
            InternalNatives.SetPlayerOnScoreScreen(whichPlayer, flag);
        }
        
        private JassInteger getPlayerTeam(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerTeam(whichPlayer);
        }
        
        private JassInteger getPlayerStartLocation(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerStartLocation(whichPlayer);
        }
        
        private JassPlayerColor getPlayerColor(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerColor(whichPlayer);
        }
        
        private Boolean getPlayerSelectable(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerSelectable(whichPlayer);
        }
        
        private JassMapControl getPlayerController(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerController(whichPlayer);
        }
        
        private JassPlayerSlotState getPlayerSlotState(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerSlotState(whichPlayer);
        }
        
        private JassInteger getPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource)
        {
            return InternalNatives.GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);
        }
        
        private Boolean isPlayerRacePrefSet(JassPlayer whichPlayer, JassRacePreference pref)
        {
            return InternalNatives.IsPlayerRacePrefSet(whichPlayer, pref);
        }
        
        private String getPlayerName(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerName(whichPlayer);
        }
        
        private JassTimer createTimer()
        {
            return InternalNatives.CreateTimer();
        }
        
        private void destroyTimer(JassTimer whichTimer)
        {
            InternalNatives.DestroyTimer(whichTimer);
        }
        
        private void timerStart(JassTimer whichTimer, Single timeout, Boolean periodic, JassCode handlerFunc)
        {
            InternalNatives.TimerStart(whichTimer, timeout, periodic, handlerFunc);
        }
        
        private Single timerGetElapsed(JassTimer whichTimer)
        {
            return InternalNatives.TimerGetElapsed(whichTimer);
        }
        
        private Single timerGetRemaining(JassTimer whichTimer)
        {
            return InternalNatives.TimerGetRemaining(whichTimer);
        }
        
        private Single timerGetTimeout(JassTimer whichTimer)
        {
            return InternalNatives.TimerGetTimeout(whichTimer);
        }
        
        private void pauseTimer(JassTimer whichTimer)
        {
            InternalNatives.PauseTimer(whichTimer);
        }
        
        private void resumeTimer(JassTimer whichTimer)
        {
            InternalNatives.ResumeTimer(whichTimer);
        }
        
        private JassTimer getExpiredTimer()
        {
            return InternalNatives.GetExpiredTimer();
        }
        
        private JassGroup createGroup()
        {
            return InternalNatives.CreateGroup();
        }
        
        private void destroyGroup(JassGroup whichGroup)
        {
            InternalNatives.DestroyGroup(whichGroup);
        }
        
        private void groupAddUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            InternalNatives.GroupAddUnit(whichGroup, whichUnit);
        }
        
        private void groupRemoveUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            InternalNatives.GroupRemoveUnit(whichGroup, whichUnit);
        }
        
        private void groupClear(JassGroup whichGroup)
        {
            InternalNatives.GroupClear(whichGroup);
        }
        
        private void groupEnumUnitsOfType(JassGroup whichGroup, String unitname, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsOfType(whichGroup, unitname, filter);
        }
        
        private void groupEnumUnitsOfPlayer(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsOfPlayer(whichGroup, whichPlayer, filter);
        }
        
        private void groupEnumUnitsOfTypeCounted(JassGroup whichGroup, String unitname, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.GroupEnumUnitsOfTypeCounted(whichGroup, unitname, filter, countLimit);
        }
        
        private void groupEnumUnitsInRect(JassGroup whichGroup, JassRect r, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsInRect(whichGroup, r, filter);
        }
        
        private void groupEnumUnitsInRectCounted(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.GroupEnumUnitsInRectCounted(whichGroup, r, filter, countLimit);
        }
        
        private void groupEnumUnitsInRange(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsInRange(whichGroup, x, y, radius, filter);
        }
        
        private void groupEnumUnitsInRangeOfLoc(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsInRangeOfLoc(whichGroup, whichLocation, radius, filter);
        }
        
        private void groupEnumUnitsInRangeCounted(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.GroupEnumUnitsInRangeCounted(whichGroup, x, y, radius, filter, countLimit);
        }
        
        private void groupEnumUnitsInRangeOfLocCounted(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.GroupEnumUnitsInRangeOfLocCounted(whichGroup, whichLocation, radius, filter, countLimit);
        }
        
        private void groupEnumUnitsSelected(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives.GroupEnumUnitsSelected(whichGroup, whichPlayer, filter);
        }
        
        private Boolean groupImmediateOrder(JassGroup whichGroup, String order)
        {
            return InternalNatives.GroupImmediateOrder(whichGroup, order);
        }
        
        private Boolean groupImmediateOrderById(JassGroup whichGroup, JassOrder order)
        {
            return InternalNatives.GroupImmediateOrderById(whichGroup, order);
        }
        
        private Boolean groupPointOrder(JassGroup whichGroup, String order, Single x, Single y)
        {
            return InternalNatives.GroupPointOrder(whichGroup, order, x, y);
        }
        
        private Boolean groupPointOrderLoc(JassGroup whichGroup, String order, JassLocation whichLocation)
        {
            return InternalNatives.GroupPointOrderLoc(whichGroup, order, whichLocation);
        }
        
        private Boolean groupPointOrderById(JassGroup whichGroup, JassOrder order, Single x, Single y)
        {
            return InternalNatives.GroupPointOrderById(whichGroup, order, x, y);
        }
        
        private Boolean groupPointOrderByIdLoc(JassGroup whichGroup, JassOrder order, JassLocation whichLocation)
        {
            return InternalNatives.GroupPointOrderByIdLoc(whichGroup, order, whichLocation);
        }
        
        private Boolean groupTargetOrder(JassGroup whichGroup, String order, JassWidget targetWidget)
        {
            return InternalNatives.GroupTargetOrder(whichGroup, order, targetWidget);
        }
        
        private Boolean groupTargetOrderById(JassGroup whichGroup, JassOrder order, JassWidget targetWidget)
        {
            return InternalNatives.GroupTargetOrderById(whichGroup, order, targetWidget);
        }
        
        private void forGroup(JassGroup whichGroup, JassCode callback)
        {
            InternalNatives.ForGroup(whichGroup, callback);
        }
        
        private JassUnit firstOfGroup(JassGroup whichGroup)
        {
            return InternalNatives.FirstOfGroup(whichGroup);
        }
        
        private JassForce createForce()
        {
            return InternalNatives.CreateForce();
        }
        
        private void destroyForce(JassForce whichForce)
        {
            InternalNatives.DestroyForce(whichForce);
        }
        
        private void forceAddPlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            InternalNatives.ForceAddPlayer(whichForce, whichPlayer);
        }
        
        private void forceRemovePlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            InternalNatives.ForceRemovePlayer(whichForce, whichPlayer);
        }
        
        private void forceClear(JassForce whichForce)
        {
            InternalNatives.ForceClear(whichForce);
        }
        
        private void forceEnumPlayers(JassForce whichForce, JassBooleanExpression filter)
        {
            InternalNatives.ForceEnumPlayers(whichForce, filter);
        }
        
        private void forceEnumPlayersCounted(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit)
        {
            InternalNatives.ForceEnumPlayersCounted(whichForce, filter, countLimit);
        }
        
        private void forceEnumAllies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives.ForceEnumAllies(whichForce, whichPlayer, filter);
        }
        
        private void forceEnumEnemies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            InternalNatives.ForceEnumEnemies(whichForce, whichPlayer, filter);
        }
        
        private void forForce(JassForce whichForce, JassCode callback)
        {
            InternalNatives.ForForce(whichForce, callback);
        }
        
        private JassRect rect(Single minx, Single miny, Single maxx, Single maxy)
        {
            return InternalNatives.Rect(minx, miny, maxx, maxy);
        }
        
        private JassRect rectFromLoc(JassLocation min, JassLocation max)
        {
            return InternalNatives.RectFromLoc(min, max);
        }
        
        private void removeRect(JassRect whichRect)
        {
            InternalNatives.RemoveRect(whichRect);
        }
        
        private void setRect(JassRect whichRect, Single minx, Single miny, Single maxx, Single maxy)
        {
            InternalNatives.SetRect(whichRect, minx, miny, maxx, maxy);
        }
        
        private void setRectFromLoc(JassRect whichRect, JassLocation min, JassLocation max)
        {
            InternalNatives.SetRectFromLoc(whichRect, min, max);
        }
        
        private void moveRectTo(JassRect whichRect, Single newCenterX, Single newCenterY)
        {
            InternalNatives.MoveRectTo(whichRect, newCenterX, newCenterY);
        }
        
        private void moveRectToLoc(JassRect whichRect, JassLocation newCenterLoc)
        {
            InternalNatives.MoveRectToLoc(whichRect, newCenterLoc);
        }
        
        private Single getRectCenterX(JassRect whichRect)
        {
            return InternalNatives.GetRectCenterX(whichRect);
        }
        
        private Single getRectCenterY(JassRect whichRect)
        {
            return InternalNatives.GetRectCenterY(whichRect);
        }
        
        private Single getRectMinX(JassRect whichRect)
        {
            return InternalNatives.GetRectMinX(whichRect);
        }
        
        private Single getRectMinY(JassRect whichRect)
        {
            return InternalNatives.GetRectMinY(whichRect);
        }
        
        private Single getRectMaxX(JassRect whichRect)
        {
            return InternalNatives.GetRectMaxX(whichRect);
        }
        
        private Single getRectMaxY(JassRect whichRect)
        {
            return InternalNatives.GetRectMaxY(whichRect);
        }
        
        private JassRegion createRegion()
        {
            return InternalNatives.CreateRegion();
        }
        
        private void removeRegion(JassRegion whichRegion)
        {
            InternalNatives.RemoveRegion(whichRegion);
        }
        
        private void regionAddRect(JassRegion whichRegion, JassRect r)
        {
            InternalNatives.RegionAddRect(whichRegion, r);
        }
        
        private void regionClearRect(JassRegion whichRegion, JassRect r)
        {
            InternalNatives.RegionClearRect(whichRegion, r);
        }
        
        private void regionAddCell(JassRegion whichRegion, Single x, Single y)
        {
            InternalNatives.RegionAddCell(whichRegion, x, y);
        }
        
        private void regionAddCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            InternalNatives.RegionAddCellAtLoc(whichRegion, whichLocation);
        }
        
        private void regionClearCell(JassRegion whichRegion, Single x, Single y)
        {
            InternalNatives.RegionClearCell(whichRegion, x, y);
        }
        
        private void regionClearCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            InternalNatives.RegionClearCellAtLoc(whichRegion, whichLocation);
        }
        
        private JassLocation location(Single x, Single y)
        {
            return InternalNatives.Location(x, y);
        }
        
        private void removeLocation(JassLocation whichLocation)
        {
            InternalNatives.RemoveLocation(whichLocation);
        }
        
        private void moveLocation(JassLocation whichLocation, Single newX, Single newY)
        {
            InternalNatives.MoveLocation(whichLocation, newX, newY);
        }
        
        private Single getLocationX(JassLocation whichLocation)
        {
            return InternalNatives.GetLocationX(whichLocation);
        }
        
        private Single getLocationY(JassLocation whichLocation)
        {
            return InternalNatives.GetLocationY(whichLocation);
        }
        
        private Single getLocationZ(JassLocation whichLocation)
        {
            return InternalNatives.GetLocationZ(whichLocation);
        }
        
        private Boolean isUnitInRegion(JassRegion whichRegion, JassUnit whichUnit)
        {
            return InternalNatives.IsUnitInRegion(whichRegion, whichUnit);
        }
        
        private Boolean isPointInRegion(JassRegion whichRegion, Single x, Single y)
        {
            return InternalNatives.IsPointInRegion(whichRegion, x, y);
        }
        
        private Boolean isLocationInRegion(JassRegion whichRegion, JassLocation whichLocation)
        {
            return InternalNatives.IsLocationInRegion(whichRegion, whichLocation);
        }
        
        private JassRect getWorldBounds()
        {
            return InternalNatives.GetWorldBounds();
        }
        
        private JassTrigger createTrigger()
        {
            return InternalNatives.CreateTrigger();
        }
        
        private void destroyTrigger(JassTrigger whichTrigger)
        {
            InternalNatives.DestroyTrigger(whichTrigger);
        }
        
        private void resetTrigger(JassTrigger whichTrigger)
        {
            InternalNatives.ResetTrigger(whichTrigger);
        }
        
        private void enableTrigger(JassTrigger whichTrigger)
        {
            InternalNatives.EnableTrigger(whichTrigger);
        }
        
        private void disableTrigger(JassTrigger whichTrigger)
        {
            InternalNatives.DisableTrigger(whichTrigger);
        }
        
        private Boolean isTriggerEnabled(JassTrigger whichTrigger)
        {
            return InternalNatives.IsTriggerEnabled(whichTrigger);
        }
        
        private void triggerWaitOnSleeps(JassTrigger whichTrigger, Boolean flag)
        {
            InternalNatives.TriggerWaitOnSleeps(whichTrigger, flag);
        }
        
        private Boolean isTriggerWaitOnSleeps(JassTrigger whichTrigger)
        {
            return InternalNatives.IsTriggerWaitOnSleeps(whichTrigger);
        }
        
        private JassUnit getFilterUnit()
        {
            return InternalNatives.GetFilterUnit();
        }
        
        private JassUnit getEnumUnit()
        {
            return InternalNatives.GetEnumUnit();
        }
        
        private JassDestructable getFilterDestructable()
        {
            return InternalNatives.GetFilterDestructable();
        }
        
        private JassDestructable getEnumDestructable()
        {
            return InternalNatives.GetEnumDestructable();
        }
        
        private JassItem getFilterItem()
        {
            return InternalNatives.GetFilterItem();
        }
        
        private JassItem getEnumItem()
        {
            return InternalNatives.GetEnumItem();
        }
        
        private JassPlayer getFilterPlayer()
        {
            return InternalNatives.GetFilterPlayer();
        }
        
        private JassPlayer getEnumPlayer()
        {
            return InternalNatives.GetEnumPlayer();
        }
        
        private JassTrigger getTriggeringTrigger()
        {
            return InternalNatives.GetTriggeringTrigger();
        }
        
        private JassEventIndex getTriggerEventId()
        {
            return InternalNatives.GetTriggerEventId();
        }
        
        private JassInteger getTriggerEvalCount(JassTrigger whichTrigger)
        {
            return InternalNatives.GetTriggerEvalCount(whichTrigger);
        }
        
        private JassInteger getTriggerExecCount(JassTrigger whichTrigger)
        {
            return InternalNatives.GetTriggerExecCount(whichTrigger);
        }
        
        private void executeFunc(String funcName)
        {
            InternalNatives.ExecuteFunc(funcName);
        }
        
        private JassBooleanExpression and(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return InternalNatives.And(operandA, operandB);
        }
        
        private JassBooleanExpression or(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return InternalNatives.Or(operandA, operandB);
        }
        
        private JassBooleanExpression not(JassBooleanExpression operand)
        {
            return InternalNatives.Not(operand);
        }
        
        private JassConditionFunction condition(JassCode func)
        {
            return InternalNatives.Condition(func);
        }
        
        private void destroyCondition(JassConditionFunction c)
        {
            InternalNatives.DestroyCondition(c);
        }
        
        private JassFilterFunction filter(JassCode func)
        {
            return InternalNatives.Filter(func);
        }
        
        private void destroyFilter(JassFilterFunction f)
        {
            InternalNatives.DestroyFilter(f);
        }
        
        private void destroyBoolExpr(JassBooleanExpression e)
        {
            InternalNatives.DestroyBoolExpr(e);
        }
        
        private JassEvent triggerRegisterVariableEvent(JassTrigger whichTrigger, String varName, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives.TriggerRegisterVariableEvent(whichTrigger, varName, opcode, limitval);
        }
        
        private JassEvent triggerRegisterTimerEvent(JassTrigger whichTrigger, Single timeout, Boolean periodic)
        {
            return InternalNatives.TriggerRegisterTimerEvent(whichTrigger, timeout, periodic);
        }
        
        private JassEvent triggerRegisterTimerExpireEvent(JassTrigger whichTrigger, JassTimer t)
        {
            return InternalNatives.TriggerRegisterTimerExpireEvent(whichTrigger, t);
        }
        
        private JassEvent triggerRegisterGameStateEvent(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives.TriggerRegisterGameStateEvent(whichTrigger, whichState, opcode, limitval);
        }
        
        private JassEvent triggerRegisterDialogEvent(JassTrigger whichTrigger, JassDialog whichDialog)
        {
            return InternalNatives.TriggerRegisterDialogEvent(whichTrigger, whichDialog);
        }
        
        private JassEvent triggerRegisterDialogButtonEvent(JassTrigger whichTrigger, JassButton whichButton)
        {
            return InternalNatives.TriggerRegisterDialogButtonEvent(whichTrigger, whichButton);
        }
        
        private JassGameState getEventGameState()
        {
            return InternalNatives.GetEventGameState();
        }
        
        private JassEvent triggerRegisterGameEvent(JassTrigger whichTrigger, JassGameEvent whichGameEvent)
        {
            return InternalNatives.TriggerRegisterGameEvent(whichTrigger, whichGameEvent);
        }
        
        private JassPlayer getWinningPlayer()
        {
            return InternalNatives.GetWinningPlayer();
        }
        
        private JassEvent triggerRegisterEnterRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterEnterRegion(whichTrigger, whichRegion, filter);
        }
        
        private JassRegion getTriggeringRegion()
        {
            return InternalNatives.GetTriggeringRegion();
        }
        
        private JassUnit getEnteringUnit()
        {
            return InternalNatives.GetEnteringUnit();
        }
        
        private JassEvent triggerRegisterLeaveRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterLeaveRegion(whichTrigger, whichRegion, filter);
        }
        
        private JassUnit getLeavingUnit()
        {
            return InternalNatives.GetLeavingUnit();
        }
        
        private JassEvent triggerRegisterTrackableHitEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return InternalNatives.TriggerRegisterTrackableHitEvent(whichTrigger, t);
        }
        
        private JassEvent triggerRegisterTrackableTrackEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return InternalNatives.TriggerRegisterTrackableTrackEvent(whichTrigger, t);
        }
        
        private JassTrackable getTriggeringTrackable()
        {
            return InternalNatives.GetTriggeringTrackable();
        }
        
        private JassButton getClickedButton()
        {
            return InternalNatives.GetClickedButton();
        }
        
        private JassDialog getClickedDialog()
        {
            return InternalNatives.GetClickedDialog();
        }
        
        private Single getTournamentFinishSoonTimeRemaining()
        {
            return InternalNatives.GetTournamentFinishSoonTimeRemaining();
        }
        
        private JassInteger getTournamentFinishNowRule()
        {
            return InternalNatives.GetTournamentFinishNowRule();
        }
        
        private JassPlayer getTournamentFinishNowPlayer()
        {
            return InternalNatives.GetTournamentFinishNowPlayer();
        }
        
        private JassInteger getTournamentScore(JassPlayer whichPlayer)
        {
            return InternalNatives.GetTournamentScore(whichPlayer);
        }
        
        private String getSaveBasicFilename()
        {
            return InternalNatives.GetSaveBasicFilename();
        }
        
        private JassEvent triggerRegisterPlayerEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent)
        {
            return InternalNatives.TriggerRegisterPlayerEvent(whichTrigger, whichPlayer, whichPlayerEvent);
        }
        
        private JassPlayer getTriggerPlayer()
        {
            return InternalNatives.GetTriggerPlayer();
        }
        
        private JassEvent triggerRegisterPlayerUnitEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterPlayerUnitEvent(whichTrigger, whichPlayer, whichPlayerUnitEvent, filter);
        }
        
        private JassUnit getLevelingUnit()
        {
            return InternalNatives.GetLevelingUnit();
        }
        
        private JassUnit getLearningUnit()
        {
            return InternalNatives.GetLearningUnit();
        }
        
        private JassInteger getLearnedSkill()
        {
            return InternalNatives.GetLearnedSkill();
        }
        
        private JassInteger getLearnedSkillLevel()
        {
            return InternalNatives.GetLearnedSkillLevel();
        }
        
        private JassUnit getRevivableUnit()
        {
            return InternalNatives.GetRevivableUnit();
        }
        
        private JassUnit getRevivingUnit()
        {
            return InternalNatives.GetRevivingUnit();
        }
        
        private JassUnit getAttacker()
        {
            return InternalNatives.GetAttacker();
        }
        
        private JassUnit getRescuer()
        {
            return InternalNatives.GetRescuer();
        }
        
        private JassUnit getDyingUnit()
        {
            return InternalNatives.GetDyingUnit();
        }
        
        private JassUnit getKillingUnit()
        {
            return InternalNatives.GetKillingUnit();
        }
        
        private JassUnit getDecayingUnit()
        {
            return InternalNatives.GetDecayingUnit();
        }
        
        private JassUnit getConstructingStructure()
        {
            return InternalNatives.GetConstructingStructure();
        }
        
        private JassUnit getCancelledStructure()
        {
            return InternalNatives.GetCancelledStructure();
        }
        
        private JassUnit getConstructedStructure()
        {
            return InternalNatives.GetConstructedStructure();
        }
        
        private JassUnit getResearchingUnit()
        {
            return InternalNatives.GetResearchingUnit();
        }
        
        private JassInteger getResearched()
        {
            return InternalNatives.GetResearched();
        }
        
        private JassInteger getTrainedUnitType()
        {
            return InternalNatives.GetTrainedUnitType();
        }
        
        private JassUnit getTrainedUnit()
        {
            return InternalNatives.GetTrainedUnit();
        }
        
        private JassUnit getDetectedUnit()
        {
            return InternalNatives.GetDetectedUnit();
        }
        
        private JassUnit getSummoningUnit()
        {
            return InternalNatives.GetSummoningUnit();
        }
        
        private JassUnit getSummonedUnit()
        {
            return InternalNatives.GetSummonedUnit();
        }
        
        private JassUnit getTransportUnit()
        {
            return InternalNatives.GetTransportUnit();
        }
        
        private JassUnit getLoadedUnit()
        {
            return InternalNatives.GetLoadedUnit();
        }
        
        private JassUnit getSellingUnit()
        {
            return InternalNatives.GetSellingUnit();
        }
        
        private JassUnit getSoldUnit()
        {
            return InternalNatives.GetSoldUnit();
        }
        
        private JassUnit getBuyingUnit()
        {
            return InternalNatives.GetBuyingUnit();
        }
        
        private JassItem getSoldItem()
        {
            return InternalNatives.GetSoldItem();
        }
        
        private JassUnit getChangingUnit()
        {
            return InternalNatives.GetChangingUnit();
        }
        
        private JassPlayer getChangingUnitPrevOwner()
        {
            return InternalNatives.GetChangingUnitPrevOwner();
        }
        
        private JassUnit getManipulatingUnit()
        {
            return InternalNatives.GetManipulatingUnit();
        }
        
        private JassItem getManipulatedItem()
        {
            return InternalNatives.GetManipulatedItem();
        }
        
        private JassUnit getOrderedUnit()
        {
            return InternalNatives.GetOrderedUnit();
        }
        
        private JassOrder getIssuedOrderId()
        {
            return InternalNatives.GetIssuedOrderId();
        }
        
        private Single getOrderPointX()
        {
            return InternalNatives.GetOrderPointX();
        }
        
        private Single getOrderPointY()
        {
            return InternalNatives.GetOrderPointY();
        }
        
        private JassLocation getOrderPointLoc()
        {
            return InternalNatives.GetOrderPointLoc();
        }
        
        private JassWidget getOrderTarget()
        {
            return InternalNatives.GetOrderTarget();
        }
        
        private JassDestructable getOrderTargetDestructable()
        {
            return InternalNatives.GetOrderTargetDestructable();
        }
        
        private JassItem getOrderTargetItem()
        {
            return InternalNatives.GetOrderTargetItem();
        }
        
        private JassUnit getOrderTargetUnit()
        {
            return InternalNatives.GetOrderTargetUnit();
        }
        
        private JassUnit getSpellAbilityUnit()
        {
            return InternalNatives.GetSpellAbilityUnit();
        }
        
        private JassObjectId getSpellAbilityId()
        {
            return InternalNatives.GetSpellAbilityId();
        }
        
        private JassAbility getSpellAbility()
        {
            return InternalNatives.GetSpellAbility();
        }
        
        private JassLocation getSpellTargetLoc()
        {
            return InternalNatives.GetSpellTargetLoc();
        }
        
        private Single getSpellTargetX()
        {
            return InternalNatives.GetSpellTargetX();
        }
        
        private Single getSpellTargetY()
        {
            return InternalNatives.GetSpellTargetY();
        }
        
        private JassDestructable getSpellTargetDestructable()
        {
            return InternalNatives.GetSpellTargetDestructable();
        }
        
        private JassItem getSpellTargetItem()
        {
            return InternalNatives.GetSpellTargetItem();
        }
        
        private JassUnit getSpellTargetUnit()
        {
            return InternalNatives.GetSpellTargetUnit();
        }
        
        private JassEvent triggerRegisterPlayerAllianceChange(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance)
        {
            return InternalNatives.TriggerRegisterPlayerAllianceChange(whichTrigger, whichPlayer, whichAlliance);
        }
        
        private JassEvent triggerRegisterPlayerStateEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives.TriggerRegisterPlayerStateEvent(whichTrigger, whichPlayer, whichState, opcode, limitval);
        }
        
        private JassPlayerState getEventPlayerState()
        {
            return InternalNatives.GetEventPlayerState();
        }
        
        private JassEvent triggerRegisterPlayerChatEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, String chatMessageToDetect, Boolean exactMatchOnly)
        {
            return InternalNatives.TriggerRegisterPlayerChatEvent(whichTrigger, whichPlayer, chatMessageToDetect, exactMatchOnly);
        }
        
        private String getEventPlayerChatString()
        {
            return InternalNatives.GetEventPlayerChatString();
        }
        
        private String getEventPlayerChatStringMatched()
        {
            return InternalNatives.GetEventPlayerChatStringMatched();
        }
        
        private JassEvent triggerRegisterDeathEvent(JassTrigger whichTrigger, JassWidget whichWidget)
        {
            return InternalNatives.TriggerRegisterDeathEvent(whichTrigger, whichWidget);
        }
        
        private JassUnit getTriggerUnit()
        {
            return InternalNatives.GetTriggerUnit();
        }
        
        private JassEvent triggerRegisterUnitStateEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, Single limitval)
        {
            return InternalNatives.TriggerRegisterUnitStateEvent(whichTrigger, whichUnit, whichState, opcode, limitval);
        }
        
        private JassUnitState getEventUnitState()
        {
            return InternalNatives.GetEventUnitState();
        }
        
        private JassEvent triggerRegisterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent)
        {
            return InternalNatives.TriggerRegisterUnitEvent(whichTrigger, whichUnit, whichEvent);
        }
        
        private Single getEventDamage()
        {
            return InternalNatives.GetEventDamage();
        }
        
        private JassUnit getEventDamageSource()
        {
            return InternalNatives.GetEventDamageSource();
        }
        
        private JassPlayer getEventDetectingPlayer()
        {
            return InternalNatives.GetEventDetectingPlayer();
        }
        
        private JassEvent triggerRegisterFilterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterFilterUnitEvent(whichTrigger, whichUnit, whichEvent, filter);
        }
        
        private JassUnit getEventTargetUnit()
        {
            return InternalNatives.GetEventTargetUnit();
        }
        
        private JassEvent triggerRegisterUnitInRange(JassTrigger whichTrigger, JassUnit whichUnit, Single range, JassBooleanExpression filter)
        {
            return InternalNatives.TriggerRegisterUnitInRange(whichTrigger, whichUnit, range, filter);
        }
        
        private JassTriggerCondition triggerAddCondition(JassTrigger whichTrigger, JassBooleanExpression condition)
        {
            return InternalNatives.TriggerAddCondition(whichTrigger, condition);
        }
        
        private void triggerRemoveCondition(JassTrigger whichTrigger, JassTriggerCondition whichCondition)
        {
            InternalNatives.TriggerRemoveCondition(whichTrigger, whichCondition);
        }
        
        private void triggerClearConditions(JassTrigger whichTrigger)
        {
            InternalNatives.TriggerClearConditions(whichTrigger);
        }
        
        private JassTriggerAction triggerAddAction(JassTrigger whichTrigger, JassCode actionFunc)
        {
            return InternalNatives.TriggerAddAction(whichTrigger, actionFunc);
        }
        
        private void triggerRemoveAction(JassTrigger whichTrigger, JassTriggerAction whichAction)
        {
            InternalNatives.TriggerRemoveAction(whichTrigger, whichAction);
        }
        
        private void triggerClearActions(JassTrigger whichTrigger)
        {
            InternalNatives.TriggerClearActions(whichTrigger);
        }
        
        private void triggerSleepAction(Single timeout)
        {
            InternalNatives.TriggerSleepAction(timeout);
        }
        
        private void triggerWaitForSound(JassSound s, Single offset)
        {
            InternalNatives.TriggerWaitForSound(s, offset);
        }
        
        private Boolean triggerEvaluate(JassTrigger whichTrigger)
        {
            return InternalNatives.TriggerEvaluate(whichTrigger);
        }
        
        private void triggerExecute(JassTrigger whichTrigger)
        {
            InternalNatives.TriggerExecute(whichTrigger);
        }
        
        private void triggerExecuteWait(JassTrigger whichTrigger)
        {
            InternalNatives.TriggerExecuteWait(whichTrigger);
        }
        
        private void triggerSyncStart()
        {
            InternalNatives.TriggerSyncStart();
        }
        
        private void triggerSyncReady()
        {
            InternalNatives.TriggerSyncReady();
        }
        
        private Single getWidgetLife(JassWidget whichWidget)
        {
            return InternalNatives.GetWidgetLife(whichWidget);
        }
        
        private void setWidgetLife(JassWidget whichWidget, Single newLife)
        {
            InternalNatives.SetWidgetLife(whichWidget, newLife);
        }
        
        private Single getWidgetX(JassWidget whichWidget)
        {
            return InternalNatives.GetWidgetX(whichWidget);
        }
        
        private Single getWidgetY(JassWidget whichWidget)
        {
            return InternalNatives.GetWidgetY(whichWidget);
        }
        
        private JassWidget getTriggerWidget()
        {
            return InternalNatives.GetTriggerWidget();
        }
        
        private JassDestructable createDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives.CreateDestructable(objectid, x, y, face, scale, variation);
        }
        
        private JassDestructable createDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives.CreateDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        private JassDestructable createDeadDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives.CreateDeadDestructable(objectid, x, y, face, scale, variation);
        }
        
        private JassDestructable createDeadDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return InternalNatives.CreateDeadDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        private void removeDestructable(JassDestructable d)
        {
            InternalNatives.RemoveDestructable(d);
        }
        
        private void killDestructable(JassDestructable d)
        {
            InternalNatives.KillDestructable(d);
        }
        
        private void setDestructableInvulnerable(JassDestructable d, Boolean flag)
        {
            InternalNatives.SetDestructableInvulnerable(d, flag);
        }
        
        private Boolean isDestructableInvulnerable(JassDestructable d)
        {
            return InternalNatives.IsDestructableInvulnerable(d);
        }
        
        private void enumDestructablesInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            InternalNatives.EnumDestructablesInRect(r, filter, actionFunc);
        }
        
        private JassObjectId getDestructableTypeId(JassDestructable d)
        {
            return InternalNatives.GetDestructableTypeId(d);
        }
        
        private Single getDestructableX(JassDestructable d)
        {
            return InternalNatives.GetDestructableX(d);
        }
        
        private Single getDestructableY(JassDestructable d)
        {
            return InternalNatives.GetDestructableY(d);
        }
        
        private void setDestructableLife(JassDestructable d, Single life)
        {
            InternalNatives.SetDestructableLife(d, life);
        }
        
        private Single getDestructableLife(JassDestructable d)
        {
            return InternalNatives.GetDestructableLife(d);
        }
        
        private void setDestructableMaxLife(JassDestructable d, Single max)
        {
            InternalNatives.SetDestructableMaxLife(d, max);
        }
        
        private Single getDestructableMaxLife(JassDestructable d)
        {
            return InternalNatives.GetDestructableMaxLife(d);
        }
        
        private void destructableRestoreLife(JassDestructable d, Single life, Boolean birth)
        {
            InternalNatives.DestructableRestoreLife(d, life, birth);
        }
        
        private void queueDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            InternalNatives.QueueDestructableAnimation(d, whichAnimation);
        }
        
        private void setDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            InternalNatives.SetDestructableAnimation(d, whichAnimation);
        }
        
        private void setDestructableAnimationSpeed(JassDestructable d, Single speedFactor)
        {
            InternalNatives.SetDestructableAnimationSpeed(d, speedFactor);
        }
        
        private void showDestructable(JassDestructable d, Boolean flag)
        {
            InternalNatives.ShowDestructable(d, flag);
        }
        
        private Single getDestructableOccluderHeight(JassDestructable d)
        {
            return InternalNatives.GetDestructableOccluderHeight(d);
        }
        
        private void setDestructableOccluderHeight(JassDestructable d, Single height)
        {
            InternalNatives.SetDestructableOccluderHeight(d, height);
        }
        
        private String getDestructableName(JassDestructable d)
        {
            return InternalNatives.GetDestructableName(d);
        }
        
        private JassDestructable getTriggerDestructable()
        {
            return InternalNatives.GetTriggerDestructable();
        }
        
        private JassItem createItem(JassObjectId itemid, Single x, Single y)
        {
            return InternalNatives.CreateItem(itemid, x, y);
        }
        
        private void removeItem(JassItem whichItem)
        {
            InternalNatives.RemoveItem(whichItem);
        }
        
        private JassPlayer getItemPlayer(JassItem whichItem)
        {
            return InternalNatives.GetItemPlayer(whichItem);
        }
        
        private JassObjectId getItemTypeId(JassItem i)
        {
            return InternalNatives.GetItemTypeId(i);
        }
        
        private Single getItemX(JassItem i)
        {
            return InternalNatives.GetItemX(i);
        }
        
        private Single getItemY(JassItem i)
        {
            return InternalNatives.GetItemY(i);
        }
        
        private void setItemPosition(JassItem i, Single x, Single y)
        {
            InternalNatives.SetItemPosition(i, x, y);
        }
        
        private void setItemDropOnDeath(JassItem whichItem, Boolean flag)
        {
            InternalNatives.SetItemDropOnDeath(whichItem, flag);
        }
        
        private void setItemDroppable(JassItem i, Boolean flag)
        {
            InternalNatives.SetItemDroppable(i, flag);
        }
        
        private void setItemPawnable(JassItem i, Boolean flag)
        {
            InternalNatives.SetItemPawnable(i, flag);
        }
        
        private void setItemPlayer(JassItem whichItem, JassPlayer whichPlayer, Boolean changeColor)
        {
            InternalNatives.SetItemPlayer(whichItem, whichPlayer, changeColor);
        }
        
        private void setItemInvulnerable(JassItem whichItem, Boolean flag)
        {
            InternalNatives.SetItemInvulnerable(whichItem, flag);
        }
        
        private Boolean isItemInvulnerable(JassItem whichItem)
        {
            return InternalNatives.IsItemInvulnerable(whichItem);
        }
        
        private void setItemVisible(JassItem whichItem, Boolean show)
        {
            InternalNatives.SetItemVisible(whichItem, show);
        }
        
        private Boolean isItemVisible(JassItem whichItem)
        {
            return InternalNatives.IsItemVisible(whichItem);
        }
        
        private Boolean isItemOwned(JassItem whichItem)
        {
            return InternalNatives.IsItemOwned(whichItem);
        }
        
        private Boolean isItemPowerup(JassItem whichItem)
        {
            return InternalNatives.IsItemPowerup(whichItem);
        }
        
        private Boolean isItemSellable(JassItem whichItem)
        {
            return InternalNatives.IsItemSellable(whichItem);
        }
        
        private Boolean isItemPawnable(JassItem whichItem)
        {
            return InternalNatives.IsItemPawnable(whichItem);
        }
        
        private Boolean isItemIdPowerup(JassObjectId itemId)
        {
            return InternalNatives.IsItemIdPowerup(itemId);
        }
        
        private Boolean isItemIdSellable(JassObjectId itemId)
        {
            return InternalNatives.IsItemIdSellable(itemId);
        }
        
        private Boolean isItemIdPawnable(JassObjectId itemId)
        {
            return InternalNatives.IsItemIdPawnable(itemId);
        }
        
        private void enumItemsInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            InternalNatives.EnumItemsInRect(r, filter, actionFunc);
        }
        
        private JassInteger getItemLevel(JassItem whichItem)
        {
            return InternalNatives.GetItemLevel(whichItem);
        }
        
        private JassItemType getItemType(JassItem whichItem)
        {
            return InternalNatives.GetItemType(whichItem);
        }
        
        private void setItemDropID(JassItem whichItem, JassObjectId unitId)
        {
            InternalNatives.SetItemDropID(whichItem, unitId);
        }
        
        private String getItemName(JassItem whichItem)
        {
            return InternalNatives.GetItemName(whichItem);
        }
        
        private JassInteger getItemCharges(JassItem whichItem)
        {
            return InternalNatives.GetItemCharges(whichItem);
        }
        
        private void setItemCharges(JassItem whichItem, JassInteger charges)
        {
            InternalNatives.SetItemCharges(whichItem, charges);
        }
        
        private JassInteger getItemUserData(JassItem whichItem)
        {
            return InternalNatives.GetItemUserData(whichItem);
        }
        
        private void setItemUserData(JassItem whichItem, JassInteger data)
        {
            InternalNatives.SetItemUserData(whichItem, data);
        }
        
        private JassUnit createUnit(JassPlayer id, JassObjectId unitid, Single x, Single y, Single face)
        {
            return InternalNatives.CreateUnit(id, unitid, x, y, face);
        }
        
        private JassUnit createUnitByName(JassPlayer whichPlayer, String unitname, Single x, Single y, Single face)
        {
            return InternalNatives.CreateUnitByName(whichPlayer, unitname, x, y, face);
        }
        
        private JassUnit createUnitAtLoc(JassPlayer id, JassObjectId unitid, JassLocation whichLocation, Single face)
        {
            return InternalNatives.CreateUnitAtLoc(id, unitid, whichLocation, face);
        }
        
        private JassUnit createUnitAtLocByName(JassPlayer id, String unitname, JassLocation whichLocation, Single face)
        {
            return InternalNatives.CreateUnitAtLocByName(id, unitname, whichLocation, face);
        }
        
        private JassUnit createCorpse(JassPlayer whichPlayer, JassObjectId unitid, Single x, Single y, Single face)
        {
            return InternalNatives.CreateCorpse(whichPlayer, unitid, x, y, face);
        }
        
        private void killUnit(JassUnit whichUnit)
        {
            InternalNatives.KillUnit(whichUnit);
        }
        
        private void removeUnit(JassUnit whichUnit)
        {
            InternalNatives.RemoveUnit(whichUnit);
        }
        
        private void showUnit(JassUnit whichUnit, Boolean show)
        {
            InternalNatives.ShowUnit(whichUnit, show);
        }
        
        private void setUnitState(JassUnit whichUnit, JassUnitState whichUnitState, Single newVal)
        {
            InternalNatives.SetUnitState(whichUnit, whichUnitState, newVal);
        }
        
        private void setUnitX(JassUnit whichUnit, Single newX)
        {
            InternalNatives.SetUnitX(whichUnit, newX);
        }
        
        private void setUnitY(JassUnit whichUnit, Single newY)
        {
            InternalNatives.SetUnitY(whichUnit, newY);
        }
        
        private void setUnitPosition(JassUnit whichUnit, Single newX, Single newY)
        {
            InternalNatives.SetUnitPosition(whichUnit, newX, newY);
        }
        
        private void setUnitPositionLoc(JassUnit whichUnit, JassLocation whichLocation)
        {
            InternalNatives.SetUnitPositionLoc(whichUnit, whichLocation);
        }
        
        private void setUnitFacing(JassUnit whichUnit, Single facingAngle)
        {
            InternalNatives.SetUnitFacing(whichUnit, facingAngle);
        }
        
        private void setUnitFacingTimed(JassUnit whichUnit, Single facingAngle, Single duration)
        {
            InternalNatives.SetUnitFacingTimed(whichUnit, facingAngle, duration);
        }
        
        private void setUnitMoveSpeed(JassUnit whichUnit, Single newSpeed)
        {
            InternalNatives.SetUnitMoveSpeed(whichUnit, newSpeed);
        }
        
        private void setUnitFlyHeight(JassUnit whichUnit, Single newHeight, Single rate)
        {
            InternalNatives.SetUnitFlyHeight(whichUnit, newHeight, rate);
        }
        
        private void setUnitTurnSpeed(JassUnit whichUnit, Single newTurnSpeed)
        {
            InternalNatives.SetUnitTurnSpeed(whichUnit, newTurnSpeed);
        }
        
        private void setUnitPropWindow(JassUnit whichUnit, Single newPropWindowAngle)
        {
            InternalNatives.SetUnitPropWindow(whichUnit, newPropWindowAngle);
        }
        
        private void setUnitAcquireRange(JassUnit whichUnit, Single newAcquireRange)
        {
            InternalNatives.SetUnitAcquireRange(whichUnit, newAcquireRange);
        }
        
        private void setUnitCreepGuard(JassUnit whichUnit, Boolean creepGuard)
        {
            InternalNatives.SetUnitCreepGuard(whichUnit, creepGuard);
        }
        
        private Single getUnitAcquireRange(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitAcquireRange(whichUnit);
        }
        
        private Single getUnitTurnSpeed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitTurnSpeed(whichUnit);
        }
        
        private Single getUnitPropWindow(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitPropWindow(whichUnit);
        }
        
        private Single getUnitFlyHeight(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitFlyHeight(whichUnit);
        }
        
        private Single getUnitDefaultAcquireRange(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultAcquireRange(whichUnit);
        }
        
        private Single getUnitDefaultTurnSpeed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultTurnSpeed(whichUnit);
        }
        
        private Single getUnitDefaultPropWindow(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultPropWindow(whichUnit);
        }
        
        private Single getUnitDefaultFlyHeight(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultFlyHeight(whichUnit);
        }
        
        private void setUnitOwner(JassUnit whichUnit, JassPlayer whichPlayer, Boolean changeColor)
        {
            InternalNatives.SetUnitOwner(whichUnit, whichPlayer, changeColor);
        }
        
        private void setUnitColor(JassUnit whichUnit, JassPlayerColor whichColor)
        {
            InternalNatives.SetUnitColor(whichUnit, whichColor);
        }
        
        private void setUnitScale(JassUnit whichUnit, Single scaleX, Single scaleY, Single scaleZ)
        {
            InternalNatives.SetUnitScale(whichUnit, scaleX, scaleY, scaleZ);
        }
        
        private void setUnitTimeScale(JassUnit whichUnit, Single timeScale)
        {
            InternalNatives.SetUnitTimeScale(whichUnit, timeScale);
        }
        
        private void setUnitBlendTime(JassUnit whichUnit, Single blendTime)
        {
            InternalNatives.SetUnitBlendTime(whichUnit, blendTime);
        }
        
        private void setUnitVertexColor(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetUnitVertexColor(whichUnit, red, green, blue, alpha);
        }
        
        private void queueUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            InternalNatives.QueueUnitAnimation(whichUnit, whichAnimation);
        }
        
        private void setUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            InternalNatives.SetUnitAnimation(whichUnit, whichAnimation);
        }
        
        private void setUnitAnimationByIndex(JassUnit whichUnit, JassInteger whichAnimation)
        {
            InternalNatives.SetUnitAnimationByIndex(whichUnit, whichAnimation);
        }
        
        private void setUnitAnimationWithRarity(JassUnit whichUnit, String whichAnimation, JassRarityControl rarity)
        {
            InternalNatives.SetUnitAnimationWithRarity(whichUnit, whichAnimation, rarity);
        }
        
        private void addUnitAnimationProperties(JassUnit whichUnit, String animProperties, Boolean add)
        {
            InternalNatives.AddUnitAnimationProperties(whichUnit, animProperties, add);
        }
        
        private void setUnitLookAt(JassUnit whichUnit, String whichBone, JassUnit lookAtTarget, Single offsetX, Single offsetY, Single offsetZ)
        {
            InternalNatives.SetUnitLookAt(whichUnit, whichBone, lookAtTarget, offsetX, offsetY, offsetZ);
        }
        
        private void resetUnitLookAt(JassUnit whichUnit)
        {
            InternalNatives.ResetUnitLookAt(whichUnit);
        }
        
        private void setUnitRescuable(JassUnit whichUnit, JassPlayer byWhichPlayer, Boolean flag)
        {
            InternalNatives.SetUnitRescuable(whichUnit, byWhichPlayer, flag);
        }
        
        private void setUnitRescueRange(JassUnit whichUnit, Single range)
        {
            InternalNatives.SetUnitRescueRange(whichUnit, range);
        }
        
        private void setHeroStr(JassUnit whichHero, JassInteger newStr, Boolean permanent)
        {
            InternalNatives.SetHeroStr(whichHero, newStr, permanent);
        }
        
        private void setHeroAgi(JassUnit whichHero, JassInteger newAgi, Boolean permanent)
        {
            InternalNatives.SetHeroAgi(whichHero, newAgi, permanent);
        }
        
        private void setHeroInt(JassUnit whichHero, JassInteger newInt, Boolean permanent)
        {
            InternalNatives.SetHeroInt(whichHero, newInt, permanent);
        }
        
        private JassInteger getHeroStr(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives.GetHeroStr(whichHero, includeBonuses);
        }
        
        private JassInteger getHeroAgi(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives.GetHeroAgi(whichHero, includeBonuses);
        }
        
        private JassInteger getHeroInt(JassUnit whichHero, Boolean includeBonuses)
        {
            return InternalNatives.GetHeroInt(whichHero, includeBonuses);
        }
        
        private Boolean unitStripHeroLevel(JassUnit whichHero, JassInteger howManyLevels)
        {
            return InternalNatives.UnitStripHeroLevel(whichHero, howManyLevels);
        }
        
        private JassInteger getHeroXP(JassUnit whichHero)
        {
            return InternalNatives.GetHeroXP(whichHero);
        }
        
        private void setHeroXP(JassUnit whichHero, JassInteger newXpVal, Boolean showEyeCandy)
        {
            InternalNatives.SetHeroXP(whichHero, newXpVal, showEyeCandy);
        }
        
        private JassInteger getHeroSkillPoints(JassUnit whichHero)
        {
            return InternalNatives.GetHeroSkillPoints(whichHero);
        }
        
        private Boolean unitModifySkillPoints(JassUnit whichHero, JassInteger skillPointDelta)
        {
            return InternalNatives.UnitModifySkillPoints(whichHero, skillPointDelta);
        }
        
        private void addHeroXP(JassUnit whichHero, JassInteger xpToAdd, Boolean showEyeCandy)
        {
            InternalNatives.AddHeroXP(whichHero, xpToAdd, showEyeCandy);
        }
        
        private void setHeroLevel(JassUnit whichHero, JassInteger level, Boolean showEyeCandy)
        {
            InternalNatives.SetHeroLevel(whichHero, level, showEyeCandy);
        }
        
        private JassInteger getHeroLevel(JassUnit whichHero)
        {
            return InternalNatives.GetHeroLevel(whichHero);
        }
        
        private JassInteger getUnitLevel(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitLevel(whichUnit);
        }
        
        private String getHeroProperName(JassUnit whichHero)
        {
            return InternalNatives.GetHeroProperName(whichHero);
        }
        
        private void suspendHeroXP(JassUnit whichHero, Boolean flag)
        {
            InternalNatives.SuspendHeroXP(whichHero, flag);
        }
        
        private Boolean isSuspendedXP(JassUnit whichHero)
        {
            return InternalNatives.IsSuspendedXP(whichHero);
        }
        
        private void selectHeroSkill(JassUnit whichHero, JassObjectId abilcode)
        {
            InternalNatives.SelectHeroSkill(whichHero, abilcode);
        }
        
        private JassInteger getUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives.GetUnitAbilityLevel(whichUnit, abilcode);
        }
        
        private JassInteger decUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives.DecUnitAbilityLevel(whichUnit, abilcode);
        }
        
        private JassInteger incUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return InternalNatives.IncUnitAbilityLevel(whichUnit, abilcode);
        }
        
        private JassInteger setUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode, JassInteger level)
        {
            return InternalNatives.SetUnitAbilityLevel(whichUnit, abilcode, level);
        }
        
        private Boolean reviveHero(JassUnit whichHero, Single x, Single y, Boolean doEyecandy)
        {
            return InternalNatives.ReviveHero(whichHero, x, y, doEyecandy);
        }
        
        private Boolean reviveHeroLoc(JassUnit whichHero, JassLocation loc, Boolean doEyecandy)
        {
            return InternalNatives.ReviveHeroLoc(whichHero, loc, doEyecandy);
        }
        
        private void setUnitExploded(JassUnit whichUnit, Boolean exploded)
        {
            InternalNatives.SetUnitExploded(whichUnit, exploded);
        }
        
        private void setUnitInvulnerable(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.SetUnitInvulnerable(whichUnit, flag);
        }
        
        private void pauseUnit(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.PauseUnit(whichUnit, flag);
        }
        
        private Boolean isUnitPaused(JassUnit whichHero)
        {
            return InternalNatives.IsUnitPaused(whichHero);
        }
        
        private void setUnitPathing(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.SetUnitPathing(whichUnit, flag);
        }
        
        private void clearSelection()
        {
            InternalNatives.ClearSelection();
        }
        
        private void selectUnit(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.SelectUnit(whichUnit, flag);
        }
        
        private JassInteger getUnitPointValue(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitPointValue(whichUnit);
        }
        
        private JassInteger getUnitPointValueByType(JassInteger unitType)
        {
            return InternalNatives.GetUnitPointValueByType(unitType);
        }
        
        private Boolean unitAddItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives.UnitAddItem(whichUnit, whichItem);
        }
        
        private JassItem unitAddItemById(JassUnit whichUnit, JassObjectId itemId)
        {
            return InternalNatives.UnitAddItemById(whichUnit, itemId);
        }
        
        private Boolean unitAddItemToSlotById(JassUnit whichUnit, JassObjectId itemId, JassInteger itemSlot)
        {
            return InternalNatives.UnitAddItemToSlotById(whichUnit, itemId, itemSlot);
        }
        
        private void unitRemoveItem(JassUnit whichUnit, JassItem whichItem)
        {
            InternalNatives.UnitRemoveItem(whichUnit, whichItem);
        }
        
        private JassItem unitRemoveItemFromSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return InternalNatives.UnitRemoveItemFromSlot(whichUnit, itemSlot);
        }
        
        private Boolean unitHasItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives.UnitHasItem(whichUnit, whichItem);
        }
        
        private JassItem unitItemInSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return InternalNatives.UnitItemInSlot(whichUnit, itemSlot);
        }
        
        private JassInteger unitInventorySize(JassUnit whichUnit)
        {
            return InternalNatives.UnitInventorySize(whichUnit);
        }
        
        private Boolean unitDropItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return InternalNatives.UnitDropItemPoint(whichUnit, whichItem, x, y);
        }
        
        private Boolean unitDropItemSlot(JassUnit whichUnit, JassItem whichItem, JassInteger slot)
        {
            return InternalNatives.UnitDropItemSlot(whichUnit, whichItem, slot);
        }
        
        private Boolean unitDropItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return InternalNatives.UnitDropItemTarget(whichUnit, whichItem, target);
        }
        
        private Boolean unitUseItem(JassUnit whichUnit, JassItem whichItem)
        {
            return InternalNatives.UnitUseItem(whichUnit, whichItem);
        }
        
        private Boolean unitUseItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return InternalNatives.UnitUseItemPoint(whichUnit, whichItem, x, y);
        }
        
        private Boolean unitUseItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return InternalNatives.UnitUseItemTarget(whichUnit, whichItem, target);
        }
        
        private Single getUnitX(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitX(whichUnit);
        }
        
        private Single getUnitY(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitY(whichUnit);
        }
        
        private JassLocation getUnitLoc(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitLoc(whichUnit);
        }
        
        private Single getUnitFacing(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitFacing(whichUnit);
        }
        
        private Single getUnitMoveSpeed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitMoveSpeed(whichUnit);
        }
        
        private Single getUnitDefaultMoveSpeed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitDefaultMoveSpeed(whichUnit);
        }
        
        private Single getUnitState(JassUnit whichUnit, JassUnitState whichUnitState)
        {
            return InternalNatives.GetUnitState(whichUnit, whichUnitState);
        }
        
        private JassPlayer getOwningPlayer(JassUnit whichUnit)
        {
            return InternalNatives.GetOwningPlayer(whichUnit);
        }
        
        private JassObjectId getUnitTypeId(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitTypeId(whichUnit);
        }
        
        private JassRace getUnitRace(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitRace(whichUnit);
        }
        
        private String getUnitName(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitName(whichUnit);
        }
        
        private JassInteger getUnitFoodUsed(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitFoodUsed(whichUnit);
        }
        
        private JassInteger getUnitFoodMade(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitFoodMade(whichUnit);
        }
        
        private JassInteger getFoodMade(JassObjectId unitId)
        {
            return InternalNatives.GetFoodMade(unitId);
        }
        
        private JassInteger getFoodUsed(JassObjectId unitId)
        {
            return InternalNatives.GetFoodUsed(unitId);
        }
        
        private void setUnitUseFood(JassUnit whichUnit, Boolean useFood)
        {
            InternalNatives.SetUnitUseFood(whichUnit, useFood);
        }
        
        private JassLocation getUnitRallyPoint(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitRallyPoint(whichUnit);
        }
        
        private JassUnit getUnitRallyUnit(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitRallyUnit(whichUnit);
        }
        
        private JassDestructable getUnitRallyDestructable(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitRallyDestructable(whichUnit);
        }
        
        private Boolean isUnitInGroup(JassUnit whichUnit, JassGroup whichGroup)
        {
            return InternalNatives.IsUnitInGroup(whichUnit, whichGroup);
        }
        
        private Boolean isUnitInForce(JassUnit whichUnit, JassForce whichForce)
        {
            return InternalNatives.IsUnitInForce(whichUnit, whichForce);
        }
        
        private Boolean isUnitOwnedByPlayer(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitOwnedByPlayer(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitAlly(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitAlly(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitEnemy(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitEnemy(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitVisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitVisible(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitDetected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitDetected(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitInvisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitInvisible(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitFogged(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitFogged(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitMasked(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitMasked(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitSelected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return InternalNatives.IsUnitSelected(whichUnit, whichPlayer);
        }
        
        private Boolean isUnitRace(JassUnit whichUnit, JassRace whichRace)
        {
            return InternalNatives.IsUnitRace(whichUnit, whichRace);
        }
        
        private Boolean isUnitType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives.IsUnitType(whichUnit, whichUnitType);
        }
        
        private Boolean isUnit(JassUnit whichUnit, JassUnit whichSpecifiedUnit)
        {
            return InternalNatives.IsUnit(whichUnit, whichSpecifiedUnit);
        }
        
        private Boolean isUnitInRange(JassUnit whichUnit, JassUnit otherUnit, Single distance)
        {
            return InternalNatives.IsUnitInRange(whichUnit, otherUnit, distance);
        }
        
        private Boolean isUnitInRangeXY(JassUnit whichUnit, Single x, Single y, Single distance)
        {
            return InternalNatives.IsUnitInRangeXY(whichUnit, x, y, distance);
        }
        
        private Boolean isUnitInRangeLoc(JassUnit whichUnit, JassLocation whichLocation, Single distance)
        {
            return InternalNatives.IsUnitInRangeLoc(whichUnit, whichLocation, distance);
        }
        
        private Boolean isUnitHidden(JassUnit whichUnit)
        {
            return InternalNatives.IsUnitHidden(whichUnit);
        }
        
        private Boolean isUnitIllusion(JassUnit whichUnit)
        {
            return InternalNatives.IsUnitIllusion(whichUnit);
        }
        
        private Boolean isUnitInTransport(JassUnit whichUnit, JassUnit whichTransport)
        {
            return InternalNatives.IsUnitInTransport(whichUnit, whichTransport);
        }
        
        private Boolean isUnitLoaded(JassUnit whichUnit)
        {
            return InternalNatives.IsUnitLoaded(whichUnit);
        }
        
        private Boolean isHeroUnitId(JassObjectId unitId)
        {
            return InternalNatives.IsHeroUnitId(unitId);
        }
        
        private Boolean isUnitIdType(JassObjectId unitId, JassUnitType whichUnitType)
        {
            return InternalNatives.IsUnitIdType(unitId, whichUnitType);
        }
        
        private void unitShareVision(JassUnit whichUnit, JassPlayer whichPlayer, Boolean share)
        {
            InternalNatives.UnitShareVision(whichUnit, whichPlayer, share);
        }
        
        private void unitSuspendDecay(JassUnit whichUnit, Boolean suspend)
        {
            InternalNatives.UnitSuspendDecay(whichUnit, suspend);
        }
        
        private Boolean unitAddType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives.UnitAddType(whichUnit, whichUnitType);
        }
        
        private Boolean unitRemoveType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return InternalNatives.UnitRemoveType(whichUnit, whichUnitType);
        }
        
        private Boolean unitAddAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return InternalNatives.UnitAddAbility(whichUnit, abilityId);
        }
        
        private Boolean unitRemoveAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return InternalNatives.UnitRemoveAbility(whichUnit, abilityId);
        }
        
        private Boolean unitMakeAbilityPermanent(JassUnit whichUnit, Boolean permanent, JassInteger abilityId)
        {
            return InternalNatives.UnitMakeAbilityPermanent(whichUnit, permanent, abilityId);
        }
        
        private void unitRemoveBuffs(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative)
        {
            InternalNatives.UnitRemoveBuffs(whichUnit, removePositive, removeNegative);
        }
        
        private void unitRemoveBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            InternalNatives.UnitRemoveBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        private Boolean unitHasBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return InternalNatives.UnitHasBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        private JassInteger unitCountBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return InternalNatives.UnitCountBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        private void unitAddSleep(JassUnit whichUnit, Boolean add)
        {
            InternalNatives.UnitAddSleep(whichUnit, add);
        }
        
        private Boolean unitCanSleep(JassUnit whichUnit)
        {
            return InternalNatives.UnitCanSleep(whichUnit);
        }
        
        private void unitAddSleepPerm(JassUnit whichUnit, Boolean add)
        {
            InternalNatives.UnitAddSleepPerm(whichUnit, add);
        }
        
        private Boolean unitCanSleepPerm(JassUnit whichUnit)
        {
            return InternalNatives.UnitCanSleepPerm(whichUnit);
        }
        
        private Boolean unitIsSleeping(JassUnit whichUnit)
        {
            return InternalNatives.UnitIsSleeping(whichUnit);
        }
        
        private void unitWakeUp(JassUnit whichUnit)
        {
            InternalNatives.UnitWakeUp(whichUnit);
        }
        
        private void unitApplyTimedLife(JassUnit whichUnit, JassInteger buffId, Single duration)
        {
            InternalNatives.UnitApplyTimedLife(whichUnit, buffId, duration);
        }
        
        private Boolean unitIgnoreAlarm(JassUnit whichUnit, Boolean flag)
        {
            return InternalNatives.UnitIgnoreAlarm(whichUnit, flag);
        }
        
        private Boolean unitIgnoreAlarmToggled(JassUnit whichUnit)
        {
            return InternalNatives.UnitIgnoreAlarmToggled(whichUnit);
        }
        
        private void unitResetCooldown(JassUnit whichUnit)
        {
            InternalNatives.UnitResetCooldown(whichUnit);
        }
        
        private void unitSetConstructionProgress(JassUnit whichUnit, JassInteger constructionPercentage)
        {
            InternalNatives.UnitSetConstructionProgress(whichUnit, constructionPercentage);
        }
        
        private void unitSetUpgradeProgress(JassUnit whichUnit, JassInteger upgradePercentage)
        {
            InternalNatives.UnitSetUpgradeProgress(whichUnit, upgradePercentage);
        }
        
        private void unitPauseTimedLife(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.UnitPauseTimedLife(whichUnit, flag);
        }
        
        private void unitSetUsesAltIcon(JassUnit whichUnit, Boolean flag)
        {
            InternalNatives.UnitSetUsesAltIcon(whichUnit, flag);
        }
        
        private Boolean unitDamagePoint(JassUnit whichUnit, Single delay, Single radius, Single x, Single y, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return InternalNatives.UnitDamagePoint(whichUnit, delay, radius, x, y, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        private Boolean unitDamageTarget(JassUnit whichUnit, JassWidget target, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return InternalNatives.UnitDamageTarget(whichUnit, target, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        private Boolean issueImmediateOrder(JassUnit whichUnit, String order)
        {
            return InternalNatives.IssueImmediateOrder(whichUnit, order);
        }
        
        private Boolean issueImmediateOrderById(JassUnit whichUnit, JassOrder order)
        {
            return InternalNatives.IssueImmediateOrderById(whichUnit, order);
        }
        
        private Boolean issuePointOrder(JassUnit whichUnit, String order, Single x, Single y)
        {
            return InternalNatives.IssuePointOrder(whichUnit, order, x, y);
        }
        
        private Boolean issuePointOrderLoc(JassUnit whichUnit, String order, JassLocation whichLocation)
        {
            return InternalNatives.IssuePointOrderLoc(whichUnit, order, whichLocation);
        }
        
        private Boolean issuePointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y)
        {
            return InternalNatives.IssuePointOrderById(whichUnit, order, x, y);
        }
        
        private Boolean issuePointOrderByIdLoc(JassUnit whichUnit, JassOrder order, JassLocation whichLocation)
        {
            return InternalNatives.IssuePointOrderByIdLoc(whichUnit, order, whichLocation);
        }
        
        private Boolean issueTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget)
        {
            return InternalNatives.IssueTargetOrder(whichUnit, order, targetWidget);
        }
        
        private Boolean issueTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget)
        {
            return InternalNatives.IssueTargetOrderById(whichUnit, order, targetWidget);
        }
        
        private Boolean issueInstantPointOrder(JassUnit whichUnit, String order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return InternalNatives.IssueInstantPointOrder(whichUnit, order, x, y, instantTargetWidget);
        }
        
        private Boolean issueInstantPointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return InternalNatives.IssueInstantPointOrderById(whichUnit, order, x, y, instantTargetWidget);
        }
        
        private Boolean issueInstantTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return InternalNatives.IssueInstantTargetOrder(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        private Boolean issueInstantTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return InternalNatives.IssueInstantTargetOrderById(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        private Boolean issueBuildOrder(JassUnit whichPeon, String unitToBuild, Single x, Single y)
        {
            return InternalNatives.IssueBuildOrder(whichPeon, unitToBuild, x, y);
        }
        
        private Boolean issueBuildOrderById(JassUnit whichPeon, JassObjectId unitId, Single x, Single y)
        {
            return InternalNatives.IssueBuildOrderById(whichPeon, unitId, x, y);
        }
        
        private Boolean issueNeutralImmediateOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild)
        {
            return InternalNatives.IssueNeutralImmediateOrder(forWhichPlayer, neutralStructure, unitToBuild);
        }
        
        private Boolean issueNeutralImmediateOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId)
        {
            return InternalNatives.IssueNeutralImmediateOrderById(forWhichPlayer, neutralStructure, unitId);
        }
        
        private Boolean issueNeutralPointOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, Single x, Single y)
        {
            return InternalNatives.IssueNeutralPointOrder(forWhichPlayer, neutralStructure, unitToBuild, x, y);
        }
        
        private Boolean issueNeutralPointOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, Single x, Single y)
        {
            return InternalNatives.IssueNeutralPointOrderById(forWhichPlayer, neutralStructure, unitId, x, y);
        }
        
        private Boolean issueNeutralTargetOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassWidget target)
        {
            return InternalNatives.IssueNeutralTargetOrder(forWhichPlayer, neutralStructure, unitToBuild, target);
        }
        
        private Boolean issueNeutralTargetOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassWidget target)
        {
            return InternalNatives.IssueNeutralTargetOrderById(forWhichPlayer, neutralStructure, unitId, target);
        }
        
        private JassInteger getUnitCurrentOrder(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitCurrentOrder(whichUnit);
        }
        
        private void setResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            InternalNatives.SetResourceAmount(whichUnit, amount);
        }
        
        private void addResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            InternalNatives.AddResourceAmount(whichUnit, amount);
        }
        
        private JassInteger getResourceAmount(JassUnit whichUnit)
        {
            return InternalNatives.GetResourceAmount(whichUnit);
        }
        
        private Single waygateGetDestinationX(JassUnit waygate)
        {
            return InternalNatives.WaygateGetDestinationX(waygate);
        }
        
        private Single waygateGetDestinationY(JassUnit waygate)
        {
            return InternalNatives.WaygateGetDestinationY(waygate);
        }
        
        private void waygateSetDestination(JassUnit waygate, Single x, Single y)
        {
            InternalNatives.WaygateSetDestination(waygate, x, y);
        }
        
        private void waygateActivate(JassUnit waygate, Boolean activate)
        {
            InternalNatives.WaygateActivate(waygate, activate);
        }
        
        private Boolean waygateIsActive(JassUnit waygate)
        {
            return InternalNatives.WaygateIsActive(waygate);
        }
        
        private void addItemToAllStock(JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives.AddItemToAllStock(itemId, currentStock, stockMax);
        }
        
        private void addItemToStock(JassUnit whichUnit, JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives.AddItemToStock(whichUnit, itemId, currentStock, stockMax);
        }
        
        private void addUnitToAllStock(JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives.AddUnitToAllStock(unitId, currentStock, stockMax);
        }
        
        private void addUnitToStock(JassUnit whichUnit, JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            InternalNatives.AddUnitToStock(whichUnit, unitId, currentStock, stockMax);
        }
        
        private void removeItemFromAllStock(JassObjectId itemId)
        {
            InternalNatives.RemoveItemFromAllStock(itemId);
        }
        
        private void removeItemFromStock(JassUnit whichUnit, JassObjectId itemId)
        {
            InternalNatives.RemoveItemFromStock(whichUnit, itemId);
        }
        
        private void removeUnitFromAllStock(JassObjectId unitId)
        {
            InternalNatives.RemoveUnitFromAllStock(unitId);
        }
        
        private void removeUnitFromStock(JassUnit whichUnit, JassObjectId unitId)
        {
            InternalNatives.RemoveUnitFromStock(whichUnit, unitId);
        }
        
        private void setAllItemTypeSlots(JassInteger slots)
        {
            InternalNatives.SetAllItemTypeSlots(slots);
        }
        
        private void setAllUnitTypeSlots(JassInteger slots)
        {
            InternalNatives.SetAllUnitTypeSlots(slots);
        }
        
        private void setItemTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            InternalNatives.SetItemTypeSlots(whichUnit, slots);
        }
        
        private void setUnitTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            InternalNatives.SetUnitTypeSlots(whichUnit, slots);
        }
        
        private JassInteger getUnitUserData(JassUnit whichUnit)
        {
            return InternalNatives.GetUnitUserData(whichUnit);
        }
        
        private void setUnitUserData(JassUnit whichUnit, JassInteger data)
        {
            InternalNatives.SetUnitUserData(whichUnit, data);
        }
        
        private JassPlayer player(JassInteger number)
        {
            return InternalNatives.Player(number);
        }
        
        private JassPlayer getLocalPlayer()
        {
            return InternalNatives.GetLocalPlayer();
        }
        
        private Boolean isPlayerAlly(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return InternalNatives.IsPlayerAlly(whichPlayer, otherPlayer);
        }
        
        private Boolean isPlayerEnemy(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return InternalNatives.IsPlayerEnemy(whichPlayer, otherPlayer);
        }
        
        private Boolean isPlayerInForce(JassPlayer whichPlayer, JassForce whichForce)
        {
            return InternalNatives.IsPlayerInForce(whichPlayer, whichForce);
        }
        
        private Boolean isPlayerObserver(JassPlayer whichPlayer)
        {
            return InternalNatives.IsPlayerObserver(whichPlayer);
        }
        
        private Boolean isVisibleToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives.IsVisibleToPlayer(x, y, whichPlayer);
        }
        
        private Boolean isLocationVisibleToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives.IsLocationVisibleToPlayer(whichLocation, whichPlayer);
        }
        
        private Boolean isFoggedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives.IsFoggedToPlayer(x, y, whichPlayer);
        }
        
        private Boolean isLocationFoggedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives.IsLocationFoggedToPlayer(whichLocation, whichPlayer);
        }
        
        private Boolean isMaskedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return InternalNatives.IsMaskedToPlayer(x, y, whichPlayer);
        }
        
        private Boolean isLocationMaskedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return InternalNatives.IsLocationMaskedToPlayer(whichLocation, whichPlayer);
        }
        
        private JassRace getPlayerRace(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerRace(whichPlayer);
        }
        
        private JassInteger getPlayerId(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerId(whichPlayer);
        }
        
        private JassInteger getPlayerUnitCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return InternalNatives.GetPlayerUnitCount(whichPlayer, includeIncomplete);
        }
        
        private JassInteger getPlayerTypedUnitCount(JassPlayer whichPlayer, String unitName, Boolean includeIncomplete, Boolean includeUpgrades)
        {
            return InternalNatives.GetPlayerTypedUnitCount(whichPlayer, unitName, includeIncomplete, includeUpgrades);
        }
        
        private JassInteger getPlayerStructureCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return InternalNatives.GetPlayerStructureCount(whichPlayer, includeIncomplete);
        }
        
        private JassInteger getPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState)
        {
            return InternalNatives.GetPlayerState(whichPlayer, whichPlayerState);
        }
        
        private JassInteger getPlayerScore(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore)
        {
            return InternalNatives.GetPlayerScore(whichPlayer, whichPlayerScore);
        }
        
        private Boolean getPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting)
        {
            return InternalNatives.GetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting);
        }
        
        private Single getPlayerHandicap(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerHandicap(whichPlayer);
        }
        
        private Single getPlayerHandicapXP(JassPlayer whichPlayer)
        {
            return InternalNatives.GetPlayerHandicapXP(whichPlayer);
        }
        
        private void setPlayerHandicap(JassPlayer whichPlayer, Single handicap)
        {
            InternalNatives.SetPlayerHandicap(whichPlayer, handicap);
        }
        
        private void setPlayerHandicapXP(JassPlayer whichPlayer, Single handicap)
        {
            InternalNatives.SetPlayerHandicapXP(whichPlayer, handicap);
        }
        
        private void setPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum)
        {
            InternalNatives.SetPlayerTechMaxAllowed(whichPlayer, techid, maximum);
        }
        
        private JassInteger getPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid)
        {
            return InternalNatives.GetPlayerTechMaxAllowed(whichPlayer, techid);
        }
        
        private void addPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger levels)
        {
            InternalNatives.AddPlayerTechResearched(whichPlayer, techid, levels);
        }
        
        private void setPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel)
        {
            InternalNatives.SetPlayerTechResearched(whichPlayer, techid, setToLevel);
        }
        
        private Boolean getPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return InternalNatives.GetPlayerTechResearched(whichPlayer, techid, specificonly);
        }
        
        private JassInteger getPlayerTechCount(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return InternalNatives.GetPlayerTechCount(whichPlayer, techid, specificonly);
        }
        
        private void setPlayerUnitsOwner(JassPlayer whichPlayer, JassInteger newOwner)
        {
            InternalNatives.SetPlayerUnitsOwner(whichPlayer, newOwner);
        }
        
        private void cripplePlayer(JassPlayer whichPlayer, JassForce toWhichPlayers, Boolean flag)
        {
            InternalNatives.CripplePlayer(whichPlayer, toWhichPlayers, flag);
        }
        
        private void setPlayerAbilityAvailable(JassPlayer whichPlayer, JassObjectId abilid, Boolean avail)
        {
            InternalNatives.SetPlayerAbilityAvailable(whichPlayer, abilid, avail);
        }
        
        private void setPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value)
        {
            InternalNatives.SetPlayerState(whichPlayer, whichPlayerState, value);
        }
        
        private void removePlayer(JassPlayer whichPlayer, JassPlayerGameResult gameResult)
        {
            InternalNatives.RemovePlayer(whichPlayer, gameResult);
        }
        
        private void cachePlayerHeroData(JassPlayer whichPlayer)
        {
            InternalNatives.CachePlayerHeroData(whichPlayer);
        }
        
        private void setFogStateRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision)
        {
            InternalNatives.SetFogStateRect(forWhichPlayer, whichState, where, useSharedVision);
        }
        
        private void setFogStateRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision)
        {
            InternalNatives.SetFogStateRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision);
        }
        
        private void setFogStateRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision)
        {
            InternalNatives.SetFogStateRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision);
        }
        
        private void fogMaskEnable(Boolean enable)
        {
            InternalNatives.FogMaskEnable(enable);
        }
        
        private Boolean isFogMaskEnabled()
        {
            return InternalNatives.IsFogMaskEnabled();
        }
        
        private void fogEnable(Boolean enable)
        {
            InternalNatives.FogEnable(enable);
        }
        
        private Boolean isFogEnabled()
        {
            return InternalNatives.IsFogEnabled();
        }
        
        private JassFogModifier createFogModifierRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives.CreateFogModifierRect(forWhichPlayer, whichState, where, useSharedVision, afterUnits);
        }
        
        private JassFogModifier createFogModifierRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives.CreateFogModifierRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision, afterUnits);
        }
        
        private JassFogModifier createFogModifierRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return InternalNatives.CreateFogModifierRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision, afterUnits);
        }
        
        private void destroyFogModifier(JassFogModifier whichFogModifier)
        {
            InternalNatives.DestroyFogModifier(whichFogModifier);
        }
        
        private void fogModifierStart(JassFogModifier whichFogModifier)
        {
            InternalNatives.FogModifierStart(whichFogModifier);
        }
        
        private void fogModifierStop(JassFogModifier whichFogModifier)
        {
            InternalNatives.FogModifierStop(whichFogModifier);
        }
        
        private JassVersion versionGet()
        {
            return InternalNatives.VersionGet();
        }
        
        private Boolean versionCompatible(JassVersion whichVersion)
        {
            return InternalNatives.VersionCompatible(whichVersion);
        }
        
        private Boolean versionSupported(JassVersion whichVersion)
        {
            return InternalNatives.VersionSupported(whichVersion);
        }
        
        private void endGame(Boolean doScoreScreen)
        {
            InternalNatives.EndGame(doScoreScreen);
        }
        
        private void changeLevel(String newLevel, Boolean doScoreScreen)
        {
            InternalNatives.ChangeLevel(newLevel, doScoreScreen);
        }
        
        private void restartGame(Boolean doScoreScreen)
        {
            InternalNatives.RestartGame(doScoreScreen);
        }
        
        private void reloadGame()
        {
            InternalNatives.ReloadGame();
        }
        
        private void setCampaignMenuRace(JassRace r)
        {
            InternalNatives.SetCampaignMenuRace(r);
        }
        
        private void setCampaignMenuRaceEx(JassInteger campaignIndex)
        {
            InternalNatives.SetCampaignMenuRaceEx(campaignIndex);
        }
        
        private void forceCampaignSelectScreen()
        {
            InternalNatives.ForceCampaignSelectScreen();
        }
        
        private void loadGame(String saveFileName, Boolean doScoreScreen)
        {
            InternalNatives.LoadGame(saveFileName, doScoreScreen);
        }
        
        private void saveGame(String saveFileName)
        {
            InternalNatives.SaveGame(saveFileName);
        }
        
        private Boolean renameSaveDirectory(String sourceDirName, String destDirName)
        {
            return InternalNatives.RenameSaveDirectory(sourceDirName, destDirName);
        }
        
        private Boolean removeSaveDirectory(String sourceDirName)
        {
            return InternalNatives.RemoveSaveDirectory(sourceDirName);
        }
        
        private Boolean copySaveGame(String sourceSaveName, String destSaveName)
        {
            return InternalNatives.CopySaveGame(sourceSaveName, destSaveName);
        }
        
        private Boolean saveGameExists(String saveName)
        {
            return InternalNatives.SaveGameExists(saveName);
        }
        
        private void syncSelections()
        {
            InternalNatives.SyncSelections();
        }
        
        private void setFloatGameState(JassFGameState whichFloatGameState, Single value)
        {
            InternalNatives.SetFloatGameState(whichFloatGameState, value);
        }
        
        private Single getFloatGameState(JassFGameState whichFloatGameState)
        {
            return InternalNatives.GetFloatGameState(whichFloatGameState);
        }
        
        private void setIntegerGameState(JassIGameState whichIntegerGameState, JassInteger value)
        {
            InternalNatives.SetIntegerGameState(whichIntegerGameState, value);
        }
        
        private JassInteger getIntegerGameState(JassIGameState whichIntegerGameState)
        {
            return InternalNatives.GetIntegerGameState(whichIntegerGameState);
        }
        
        private void setTutorialCleared(Boolean cleared)
        {
            InternalNatives.SetTutorialCleared(cleared);
        }
        
        private void setMissionAvailable(JassInteger campaignNumber, JassInteger missionNumber, Boolean available)
        {
            InternalNatives.SetMissionAvailable(campaignNumber, missionNumber, available);
        }
        
        private void setCampaignAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives.SetCampaignAvailable(campaignNumber, available);
        }
        
        private void setOpCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives.SetOpCinematicAvailable(campaignNumber, available);
        }
        
        private void setEdCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            InternalNatives.SetEdCinematicAvailable(campaignNumber, available);
        }
        
        private JassGameDifficulty getDefaultDifficulty()
        {
            return InternalNatives.GetDefaultDifficulty();
        }
        
        private void setDefaultDifficulty(JassGameDifficulty g)
        {
            InternalNatives.SetDefaultDifficulty(g);
        }
        
        private void setCustomCampaignButtonVisible(JassInteger whichButton, Boolean visible)
        {
            InternalNatives.SetCustomCampaignButtonVisible(whichButton, visible);
        }
        
        private Boolean getCustomCampaignButtonVisible(JassInteger whichButton)
        {
            return InternalNatives.GetCustomCampaignButtonVisible(whichButton);
        }
        
        private void doNotSaveReplay()
        {
            InternalNatives.DoNotSaveReplay();
        }
        
        private JassDialog dialogCreate()
        {
            return InternalNatives.DialogCreate();
        }
        
        private void dialogDestroy(JassDialog whichDialog)
        {
            InternalNatives.DialogDestroy(whichDialog);
        }
        
        private void dialogClear(JassDialog whichDialog)
        {
            InternalNatives.DialogClear(whichDialog);
        }
        
        private void dialogSetMessage(JassDialog whichDialog, String messageText)
        {
            InternalNatives.DialogSetMessage(whichDialog, messageText);
        }
        
        private JassButton dialogAddButton(JassDialog whichDialog, String buttonText, JassInteger hotkey)
        {
            return InternalNatives.DialogAddButton(whichDialog, buttonText, hotkey);
        }
        
        private JassButton dialogAddQuitButton(JassDialog whichDialog, Boolean doScoreScreen, String buttonText, JassInteger hotkey)
        {
            return InternalNatives.DialogAddQuitButton(whichDialog, doScoreScreen, buttonText, hotkey);
        }
        
        private void dialogDisplay(JassPlayer whichPlayer, JassDialog whichDialog, Boolean flag)
        {
            InternalNatives.DialogDisplay(whichPlayer, whichDialog, flag);
        }
        
        private Boolean reloadGameCachesFromDisk()
        {
            return InternalNatives.ReloadGameCachesFromDisk();
        }
        
        private JassGameCache initGameCache(String campaignFile)
        {
            return InternalNatives.InitGameCache(campaignFile);
        }
        
        private Boolean saveGameCache(JassGameCache whichCache)
        {
            return InternalNatives.SaveGameCache(whichCache);
        }
        
        private void storeInteger(JassGameCache cache, String missionKey, String key, JassInteger value)
        {
            InternalNatives.StoreInteger(cache, missionKey, key, value);
        }
        
        private void storeReal(JassGameCache cache, String missionKey, String key, Single value)
        {
            InternalNatives.StoreReal(cache, missionKey, key, value);
        }
        
        private void storeBoolean(JassGameCache cache, String missionKey, String key, Boolean value)
        {
            InternalNatives.StoreBoolean(cache, missionKey, key, value);
        }
        
        private Boolean storeUnit(JassGameCache cache, String missionKey, String key, JassUnit whichUnit)
        {
            return InternalNatives.StoreUnit(cache, missionKey, key, whichUnit);
        }
        
        private Boolean storeString(JassGameCache cache, String missionKey, String key, String value)
        {
            return InternalNatives.StoreString(cache, missionKey, key, value);
        }
        
        private void syncStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredInteger(cache, missionKey, key);
        }
        
        private void syncStoredReal(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredReal(cache, missionKey, key);
        }
        
        private void syncStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredBoolean(cache, missionKey, key);
        }
        
        private void syncStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredUnit(cache, missionKey, key);
        }
        
        private void syncStoredString(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.SyncStoredString(cache, missionKey, key);
        }
        
        private Boolean haveStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredInteger(cache, missionKey, key);
        }
        
        private Boolean haveStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredReal(cache, missionKey, key);
        }
        
        private Boolean haveStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredBoolean(cache, missionKey, key);
        }
        
        private Boolean haveStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredUnit(cache, missionKey, key);
        }
        
        private Boolean haveStoredString(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.HaveStoredString(cache, missionKey, key);
        }
        
        private void flushGameCache(JassGameCache cache)
        {
            InternalNatives.FlushGameCache(cache);
        }
        
        private void flushStoredMission(JassGameCache cache, String missionKey)
        {
            InternalNatives.FlushStoredMission(cache, missionKey);
        }
        
        private void flushStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredInteger(cache, missionKey, key);
        }
        
        private void flushStoredReal(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredReal(cache, missionKey, key);
        }
        
        private void flushStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredBoolean(cache, missionKey, key);
        }
        
        private void flushStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredUnit(cache, missionKey, key);
        }
        
        private void flushStoredString(JassGameCache cache, String missionKey, String key)
        {
            InternalNatives.FlushStoredString(cache, missionKey, key);
        }
        
        private JassInteger getStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.GetStoredInteger(cache, missionKey, key);
        }
        
        private Single getStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.GetStoredReal(cache, missionKey, key);
        }
        
        private Boolean getStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.GetStoredBoolean(cache, missionKey, key);
        }
        
        private String getStoredString(JassGameCache cache, String missionKey, String key)
        {
            return InternalNatives.GetStoredString(cache, missionKey, key);
        }
        
        private JassUnit restoreUnit(JassGameCache cache, String missionKey, String key, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return InternalNatives.RestoreUnit(cache, missionKey, key, forWhichPlayer, x, y, facing);
        }
        
        private JassHashTable initHashtable()
        {
            return InternalNatives.InitHashtable();
        }
        
        private void saveInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value)
        {
            InternalNatives.SaveInteger(table, parentKey, childKey, value);
        }
        
        private void saveReal(JassHashTable table, JassInteger parentKey, JassInteger childKey, Single value)
        {
            InternalNatives.SaveReal(table, parentKey, childKey, value);
        }
        
        private void saveBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey, Boolean value)
        {
            InternalNatives.SaveBoolean(table, parentKey, childKey, value);
        }
        
        private Boolean saveStr(JassHashTable table, JassInteger parentKey, JassInteger childKey, String value)
        {
            return InternalNatives.SaveStr(table, parentKey, childKey, value);
        }
        
        private Boolean savePlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer)
        {
            return InternalNatives.SavePlayerHandle(table, parentKey, childKey, whichPlayer);
        }
        
        private Boolean saveWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget)
        {
            return InternalNatives.SaveWidgetHandle(table, parentKey, childKey, whichWidget);
        }
        
        private Boolean saveDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable)
        {
            return InternalNatives.SaveDestructableHandle(table, parentKey, childKey, whichDestructable);
        }
        
        private Boolean saveItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem)
        {
            return InternalNatives.SaveItemHandle(table, parentKey, childKey, whichItem);
        }
        
        private Boolean saveUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit)
        {
            return InternalNatives.SaveUnitHandle(table, parentKey, childKey, whichUnit);
        }
        
        private Boolean saveAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility)
        {
            return InternalNatives.SaveAbilityHandle(table, parentKey, childKey, whichAbility);
        }
        
        private Boolean saveTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer)
        {
            return InternalNatives.SaveTimerHandle(table, parentKey, childKey, whichTimer);
        }
        
        private Boolean saveTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger)
        {
            return InternalNatives.SaveTriggerHandle(table, parentKey, childKey, whichTrigger);
        }
        
        private Boolean saveTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition)
        {
            return InternalNatives.SaveTriggerConditionHandle(table, parentKey, childKey, whichTriggercondition);
        }
        
        private Boolean saveTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction)
        {
            return InternalNatives.SaveTriggerActionHandle(table, parentKey, childKey, whichTriggeraction);
        }
        
        private Boolean saveTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent)
        {
            return InternalNatives.SaveTriggerEventHandle(table, parentKey, childKey, whichEvent);
        }
        
        private Boolean saveForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce)
        {
            return InternalNatives.SaveForceHandle(table, parentKey, childKey, whichForce);
        }
        
        private Boolean saveGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup)
        {
            return InternalNatives.SaveGroupHandle(table, parentKey, childKey, whichGroup);
        }
        
        private Boolean saveLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation)
        {
            return InternalNatives.SaveLocationHandle(table, parentKey, childKey, whichLocation);
        }
        
        private Boolean saveRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect)
        {
            return InternalNatives.SaveRectHandle(table, parentKey, childKey, whichRect);
        }
        
        private Boolean saveBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr)
        {
            return InternalNatives.SaveBooleanExprHandle(table, parentKey, childKey, whichBoolexpr);
        }
        
        private Boolean saveSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound)
        {
            return InternalNatives.SaveSoundHandle(table, parentKey, childKey, whichSound);
        }
        
        private Boolean saveEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect)
        {
            return InternalNatives.SaveEffectHandle(table, parentKey, childKey, whichEffect);
        }
        
        private Boolean saveUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool)
        {
            return InternalNatives.SaveUnitPoolHandle(table, parentKey, childKey, whichUnitpool);
        }
        
        private Boolean saveItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool)
        {
            return InternalNatives.SaveItemPoolHandle(table, parentKey, childKey, whichItempool);
        }
        
        private Boolean saveQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest)
        {
            return InternalNatives.SaveQuestHandle(table, parentKey, childKey, whichQuest);
        }
        
        private Boolean saveQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem)
        {
            return InternalNatives.SaveQuestItemHandle(table, parentKey, childKey, whichQuestitem);
        }
        
        private Boolean saveDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition)
        {
            return InternalNatives.SaveDefeatConditionHandle(table, parentKey, childKey, whichDefeatcondition);
        }
        
        private Boolean saveTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog)
        {
            return InternalNatives.SaveTimerDialogHandle(table, parentKey, childKey, whichTimerdialog);
        }
        
        private Boolean saveLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard)
        {
            return InternalNatives.SaveLeaderboardHandle(table, parentKey, childKey, whichLeaderboard);
        }
        
        private Boolean saveMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard)
        {
            return InternalNatives.SaveMultiboardHandle(table, parentKey, childKey, whichMultiboard);
        }
        
        private Boolean saveMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem)
        {
            return InternalNatives.SaveMultiboardItemHandle(table, parentKey, childKey, whichMultiboarditem);
        }
        
        private Boolean saveTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable)
        {
            return InternalNatives.SaveTrackableHandle(table, parentKey, childKey, whichTrackable);
        }
        
        private Boolean saveDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog)
        {
            return InternalNatives.SaveDialogHandle(table, parentKey, childKey, whichDialog);
        }
        
        private Boolean saveButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton)
        {
            return InternalNatives.SaveButtonHandle(table, parentKey, childKey, whichButton);
        }
        
        private Boolean saveTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag)
        {
            return InternalNatives.SaveTextTagHandle(table, parentKey, childKey, whichTexttag);
        }
        
        private Boolean saveLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning)
        {
            return InternalNatives.SaveLightningHandle(table, parentKey, childKey, whichLightning);
        }
        
        private Boolean saveImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage)
        {
            return InternalNatives.SaveImageHandle(table, parentKey, childKey, whichImage);
        }
        
        private Boolean saveUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat)
        {
            return InternalNatives.SaveUbersplatHandle(table, parentKey, childKey, whichUbersplat);
        }
        
        private Boolean saveRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion)
        {
            return InternalNatives.SaveRegionHandle(table, parentKey, childKey, whichRegion);
        }
        
        private Boolean saveFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState)
        {
            return InternalNatives.SaveFogStateHandle(table, parentKey, childKey, whichFogState);
        }
        
        private Boolean saveFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier)
        {
            return InternalNatives.SaveFogModifierHandle(table, parentKey, childKey, whichFogModifier);
        }
        
        private Boolean saveAgentHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent)
        {
            return InternalNatives.SaveAgentHandle(table, parentKey, childKey, whichAgent);
        }
        
        private Boolean saveHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable)
        {
            return InternalNatives.SaveHashtableHandle(table, parentKey, childKey, whichHashtable);
        }
        
        private JassInteger loadInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadInteger(table, parentKey, childKey);
        }
        
        private Single loadReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadReal(table, parentKey, childKey);
        }
        
        private Boolean loadBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadBoolean(table, parentKey, childKey);
        }
        
        private String loadStr(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadStr(table, parentKey, childKey);
        }
        
        private JassPlayer loadPlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadPlayerHandle(table, parentKey, childKey);
        }
        
        private JassWidget loadWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadWidgetHandle(table, parentKey, childKey);
        }
        
        private JassDestructable loadDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadDestructableHandle(table, parentKey, childKey);
        }
        
        private JassItem loadItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadItemHandle(table, parentKey, childKey);
        }
        
        private JassUnit loadUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadUnitHandle(table, parentKey, childKey);
        }
        
        private JassAbility loadAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadAbilityHandle(table, parentKey, childKey);
        }
        
        private JassTimer loadTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTimerHandle(table, parentKey, childKey);
        }
        
        private JassTrigger loadTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTriggerHandle(table, parentKey, childKey);
        }
        
        private JassTriggerCondition loadTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTriggerConditionHandle(table, parentKey, childKey);
        }
        
        private JassTriggerAction loadTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTriggerActionHandle(table, parentKey, childKey);
        }
        
        private JassEvent loadTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTriggerEventHandle(table, parentKey, childKey);
        }
        
        private JassForce loadForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadForceHandle(table, parentKey, childKey);
        }
        
        private JassGroup loadGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadGroupHandle(table, parentKey, childKey);
        }
        
        private JassLocation loadLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadLocationHandle(table, parentKey, childKey);
        }
        
        private JassRect loadRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadRectHandle(table, parentKey, childKey);
        }
        
        private JassBooleanExpression loadBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadBooleanExprHandle(table, parentKey, childKey);
        }
        
        private JassSound loadSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadSoundHandle(table, parentKey, childKey);
        }
        
        private JassEffect loadEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadEffectHandle(table, parentKey, childKey);
        }
        
        private JassUnitPool loadUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadUnitPoolHandle(table, parentKey, childKey);
        }
        
        private JassItemPool loadItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadItemPoolHandle(table, parentKey, childKey);
        }
        
        private JassQuest loadQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadQuestHandle(table, parentKey, childKey);
        }
        
        private JassQuestItem loadQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadQuestItemHandle(table, parentKey, childKey);
        }
        
        private JassDefeatCondition loadDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadDefeatConditionHandle(table, parentKey, childKey);
        }
        
        private JassTimerDialog loadTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTimerDialogHandle(table, parentKey, childKey);
        }
        
        private JassLeaderboard loadLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadLeaderboardHandle(table, parentKey, childKey);
        }
        
        private JassMultiboard loadMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadMultiboardHandle(table, parentKey, childKey);
        }
        
        private JassMultiboardItem loadMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadMultiboardItemHandle(table, parentKey, childKey);
        }
        
        private JassTrackable loadTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTrackableHandle(table, parentKey, childKey);
        }
        
        private JassDialog loadDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadDialogHandle(table, parentKey, childKey);
        }
        
        private JassButton loadButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadButtonHandle(table, parentKey, childKey);
        }
        
        private JassTextTag loadTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadTextTagHandle(table, parentKey, childKey);
        }
        
        private JassLightning loadLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadLightningHandle(table, parentKey, childKey);
        }
        
        private JassImage loadImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadImageHandle(table, parentKey, childKey);
        }
        
        private JassUberSplat loadUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadUbersplatHandle(table, parentKey, childKey);
        }
        
        private JassRegion loadRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadRegionHandle(table, parentKey, childKey);
        }
        
        private JassFogState loadFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadFogStateHandle(table, parentKey, childKey);
        }
        
        private JassFogModifier loadFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadFogModifierHandle(table, parentKey, childKey);
        }
        
        private JassHashTable loadHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.LoadHashtableHandle(table, parentKey, childKey);
        }
        
        private Boolean haveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedInteger(table, parentKey, childKey);
        }
        
        private Boolean haveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedReal(table, parentKey, childKey);
        }
        
        private Boolean haveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedBoolean(table, parentKey, childKey);
        }
        
        private Boolean haveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedString(table, parentKey, childKey);
        }
        
        private Boolean haveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return InternalNatives.HaveSavedHandle(table, parentKey, childKey);
        }
        
        private void removeSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedInteger(table, parentKey, childKey);
        }
        
        private void removeSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedReal(table, parentKey, childKey);
        }
        
        private void removeSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedBoolean(table, parentKey, childKey);
        }
        
        private void removeSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedString(table, parentKey, childKey);
        }
        
        private void removeSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            InternalNatives.RemoveSavedHandle(table, parentKey, childKey);
        }
        
        private void flushParentHashtable(JassHashTable table)
        {
            InternalNatives.FlushParentHashtable(table);
        }
        
        private void flushChildHashtable(JassHashTable table, JassInteger parentKey)
        {
            InternalNatives.FlushChildHashtable(table, parentKey);
        }
        
        private JassInteger getRandomInt(JassInteger lowBound, JassInteger highBound)
        {
            return InternalNatives.GetRandomInt(lowBound, highBound);
        }
        
        private Single getRandomReal(Single lowBound, Single highBound)
        {
            return InternalNatives.GetRandomReal(lowBound, highBound);
        }
        
        private JassUnitPool createUnitPool()
        {
            return InternalNatives.CreateUnitPool();
        }
        
        private void destroyUnitPool(JassUnitPool whichPool)
        {
            InternalNatives.DestroyUnitPool(whichPool);
        }
        
        private void unitPoolAddUnitType(JassUnitPool whichPool, JassObjectId unitId, Single weight)
        {
            InternalNatives.UnitPoolAddUnitType(whichPool, unitId, weight);
        }
        
        private void unitPoolRemoveUnitType(JassUnitPool whichPool, JassObjectId unitId)
        {
            InternalNatives.UnitPoolRemoveUnitType(whichPool, unitId);
        }
        
        private JassUnit placeRandomUnit(JassUnitPool whichPool, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return InternalNatives.PlaceRandomUnit(whichPool, forWhichPlayer, x, y, facing);
        }
        
        private JassItemPool createItemPool()
        {
            return InternalNatives.CreateItemPool();
        }
        
        private void destroyItemPool(JassItemPool whichItemPool)
        {
            InternalNatives.DestroyItemPool(whichItemPool);
        }
        
        private void itemPoolAddItemType(JassItemPool whichItemPool, JassObjectId itemId, Single weight)
        {
            InternalNatives.ItemPoolAddItemType(whichItemPool, itemId, weight);
        }
        
        private void itemPoolRemoveItemType(JassItemPool whichItemPool, JassObjectId itemId)
        {
            InternalNatives.ItemPoolRemoveItemType(whichItemPool, itemId);
        }
        
        private JassItem placeRandomItem(JassItemPool whichItemPool, Single x, Single y)
        {
            return InternalNatives.PlaceRandomItem(whichItemPool, x, y);
        }
        
        private JassInteger chooseRandomCreep(JassInteger level)
        {
            return InternalNatives.ChooseRandomCreep(level);
        }
        
        private JassInteger chooseRandomNPBuilding()
        {
            return InternalNatives.ChooseRandomNPBuilding();
        }
        
        private JassInteger chooseRandomItem(JassInteger level)
        {
            return InternalNatives.ChooseRandomItem(level);
        }
        
        private JassInteger chooseRandomItemEx(JassItemType whichType, JassInteger level)
        {
            return InternalNatives.ChooseRandomItemEx(whichType, level);
        }
        
        private void setRandomSeed(JassInteger seed)
        {
            InternalNatives.SetRandomSeed(seed);
        }
        
        private void setTerrainFog(Single a, Single b, Single c, Single d, Single e)
        {
            InternalNatives.SetTerrainFog(a, b, c, d, e);
        }
        
        private void resetTerrainFog()
        {
            InternalNatives.ResetTerrainFog();
        }
        
        private void setUnitFog(Single a, Single b, Single c, Single d, Single e)
        {
            InternalNatives.SetUnitFog(a, b, c, d, e);
        }
        
        private void setTerrainFogEx(JassInteger style, Single zstart, Single zend, Single density, Single red, Single green, Single blue)
        {
            InternalNatives.SetTerrainFogEx(style, zstart, zend, density, red, green, blue);
        }
        
        private void displayTextToPlayer(JassPlayer toPlayer, Single x, Single y, String message)
        {
            InternalNatives.DisplayTextToPlayer(toPlayer, x, y, message);
        }
        
        private void displayTimedTextToPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            InternalNatives.DisplayTimedTextToPlayer(toPlayer, x, y, duration, message);
        }
        
        private void displayTimedTextFromPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            InternalNatives.DisplayTimedTextFromPlayer(toPlayer, x, y, duration, message);
        }
        
        private void clearTextMessages()
        {
            InternalNatives.ClearTextMessages();
        }
        
        private void setDayNightModels(String terrainDNCFile, String unitDNCFile)
        {
            InternalNatives.SetDayNightModels(terrainDNCFile, unitDNCFile);
        }
        
        private void setSkyModel(String skyModelFile)
        {
            InternalNatives.SetSkyModel(skyModelFile);
        }
        
        private void enableUserControl(Boolean b)
        {
            InternalNatives.EnableUserControl(b);
        }
        
        private void enableUserUI(Boolean b)
        {
            InternalNatives.EnableUserUI(b);
        }
        
        private void suspendTimeOfDay(Boolean b)
        {
            InternalNatives.SuspendTimeOfDay(b);
        }
        
        private void setTimeOfDayScale(Single r)
        {
            InternalNatives.SetTimeOfDayScale(r);
        }
        
        private Single getTimeOfDayScale()
        {
            return InternalNatives.GetTimeOfDayScale();
        }
        
        private void showInterface(Boolean flag, Single fadeDuration)
        {
            InternalNatives.ShowInterface(flag, fadeDuration);
        }
        
        private void pauseGame(Boolean flag)
        {
            InternalNatives.PauseGame(flag);
        }
        
        private void unitAddIndicator(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.UnitAddIndicator(whichUnit, red, green, blue, alpha);
        }
        
        private void addIndicator(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.AddIndicator(whichWidget, red, green, blue, alpha);
        }
        
        private void pingMinimap(Single x, Single y, Single duration)
        {
            InternalNatives.PingMinimap(x, y, duration);
        }
        
        private void pingMinimapEx(Single x, Single y, Single duration, JassInteger red, JassInteger green, JassInteger blue, Boolean extraEffects)
        {
            InternalNatives.PingMinimapEx(x, y, duration, red, green, blue, extraEffects);
        }
        
        private void enableOcclusion(Boolean flag)
        {
            InternalNatives.EnableOcclusion(flag);
        }
        
        private void setIntroShotText(String introText)
        {
            InternalNatives.SetIntroShotText(introText);
        }
        
        private void setIntroShotModel(String introModelPath)
        {
            InternalNatives.SetIntroShotModel(introModelPath);
        }
        
        private void enableWorldFogBoundary(Boolean b)
        {
            InternalNatives.EnableWorldFogBoundary(b);
        }
        
        private void playModelCinematic(String modelName)
        {
            InternalNatives.PlayModelCinematic(modelName);
        }
        
        private void playCinematic(String movieName)
        {
            InternalNatives.PlayCinematic(movieName);
        }
        
        private void forceUIKey(String key)
        {
            InternalNatives.ForceUIKey(key);
        }
        
        private void forceUICancel()
        {
            InternalNatives.ForceUICancel();
        }
        
        private void displayLoadDialog()
        {
            InternalNatives.DisplayLoadDialog();
        }
        
        private void setAltMinimapIcon(String iconPath)
        {
            InternalNatives.SetAltMinimapIcon(iconPath);
        }
        
        private void disableRestartMission(Boolean flag)
        {
            InternalNatives.DisableRestartMission(flag);
        }
        
        private JassTextTag createTextTag()
        {
            return InternalNatives.CreateTextTag();
        }
        
        private void destroyTextTag(JassTextTag t)
        {
            InternalNatives.DestroyTextTag(t);
        }
        
        private void setTextTagText(JassTextTag t, String s, Single height)
        {
            InternalNatives.SetTextTagText(t, s, height);
        }
        
        private void setTextTagPos(JassTextTag t, Single x, Single y, Single heightOffset)
        {
            InternalNatives.SetTextTagPos(t, x, y, heightOffset);
        }
        
        private void setTextTagPosUnit(JassTextTag t, JassUnit whichUnit, Single heightOffset)
        {
            InternalNatives.SetTextTagPosUnit(t, whichUnit, heightOffset);
        }
        
        private void setTextTagColor(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetTextTagColor(t, red, green, blue, alpha);
        }
        
        private void setTextTagVelocity(JassTextTag t, Single xvel, Single yvel)
        {
            InternalNatives.SetTextTagVelocity(t, xvel, yvel);
        }
        
        private void setTextTagVisibility(JassTextTag t, Boolean flag)
        {
            InternalNatives.SetTextTagVisibility(t, flag);
        }
        
        private void setTextTagSuspended(JassTextTag t, Boolean flag)
        {
            InternalNatives.SetTextTagSuspended(t, flag);
        }
        
        private void setTextTagPermanent(JassTextTag t, Boolean flag)
        {
            InternalNatives.SetTextTagPermanent(t, flag);
        }
        
        private void setTextTagAge(JassTextTag t, Single age)
        {
            InternalNatives.SetTextTagAge(t, age);
        }
        
        private void setTextTagLifespan(JassTextTag t, Single lifespan)
        {
            InternalNatives.SetTextTagLifespan(t, lifespan);
        }
        
        private void setTextTagFadepoint(JassTextTag t, Single fadepoint)
        {
            InternalNatives.SetTextTagFadepoint(t, fadepoint);
        }
        
        private void setReservedLocalHeroButtons(JassInteger reserved)
        {
            InternalNatives.SetReservedLocalHeroButtons(reserved);
        }
        
        private JassInteger getAllyColorFilterState()
        {
            return InternalNatives.GetAllyColorFilterState();
        }
        
        private void setAllyColorFilterState(JassInteger state)
        {
            InternalNatives.SetAllyColorFilterState(state);
        }
        
        private Boolean getCreepCampFilterState()
        {
            return InternalNatives.GetCreepCampFilterState();
        }
        
        private void setCreepCampFilterState(Boolean state)
        {
            InternalNatives.SetCreepCampFilterState(state);
        }
        
        private void enableMinimapFilterButtons(Boolean enableAlly, Boolean enableCreep)
        {
            InternalNatives.EnableMinimapFilterButtons(enableAlly, enableCreep);
        }
        
        private void enableDragSelect(Boolean state, Boolean ui)
        {
            InternalNatives.EnableDragSelect(state, ui);
        }
        
        private void enablePreSelect(Boolean state, Boolean ui)
        {
            InternalNatives.EnablePreSelect(state, ui);
        }
        
        private void enableSelect(Boolean state, Boolean ui)
        {
            InternalNatives.EnableSelect(state, ui);
        }
        
        private JassTrackable createTrackable(String trackableModelPath, Single x, Single y, Single facing)
        {
            return InternalNatives.CreateTrackable(trackableModelPath, x, y, facing);
        }
        
        private JassQuest createQuest()
        {
            return InternalNatives.CreateQuest();
        }
        
        private void destroyQuest(JassQuest whichQuest)
        {
            InternalNatives.DestroyQuest(whichQuest);
        }
        
        private void questSetTitle(JassQuest whichQuest, String title)
        {
            InternalNatives.QuestSetTitle(whichQuest, title);
        }
        
        private void questSetDescription(JassQuest whichQuest, String description)
        {
            InternalNatives.QuestSetDescription(whichQuest, description);
        }
        
        private void questSetIconPath(JassQuest whichQuest, String iconPath)
        {
            InternalNatives.QuestSetIconPath(whichQuest, iconPath);
        }
        
        private void questSetRequired(JassQuest whichQuest, Boolean required)
        {
            InternalNatives.QuestSetRequired(whichQuest, required);
        }
        
        private void questSetCompleted(JassQuest whichQuest, Boolean completed)
        {
            InternalNatives.QuestSetCompleted(whichQuest, completed);
        }
        
        private void questSetDiscovered(JassQuest whichQuest, Boolean discovered)
        {
            InternalNatives.QuestSetDiscovered(whichQuest, discovered);
        }
        
        private void questSetFailed(JassQuest whichQuest, Boolean failed)
        {
            InternalNatives.QuestSetFailed(whichQuest, failed);
        }
        
        private void questSetEnabled(JassQuest whichQuest, Boolean enabled)
        {
            InternalNatives.QuestSetEnabled(whichQuest, enabled);
        }
        
        private Boolean isQuestRequired(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestRequired(whichQuest);
        }
        
        private Boolean isQuestCompleted(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestCompleted(whichQuest);
        }
        
        private Boolean isQuestDiscovered(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestDiscovered(whichQuest);
        }
        
        private Boolean isQuestFailed(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestFailed(whichQuest);
        }
        
        private Boolean isQuestEnabled(JassQuest whichQuest)
        {
            return InternalNatives.IsQuestEnabled(whichQuest);
        }
        
        private JassQuestItem questCreateItem(JassQuest whichQuest)
        {
            return InternalNatives.QuestCreateItem(whichQuest);
        }
        
        private void questItemSetDescription(JassQuestItem whichQuestItem, String description)
        {
            InternalNatives.QuestItemSetDescription(whichQuestItem, description);
        }
        
        private void questItemSetCompleted(JassQuestItem whichQuestItem, Boolean completed)
        {
            InternalNatives.QuestItemSetCompleted(whichQuestItem, completed);
        }
        
        private Boolean isQuestItemCompleted(JassQuestItem whichQuestItem)
        {
            return InternalNatives.IsQuestItemCompleted(whichQuestItem);
        }
        
        private JassDefeatCondition createDefeatCondition()
        {
            return InternalNatives.CreateDefeatCondition();
        }
        
        private void destroyDefeatCondition(JassDefeatCondition whichCondition)
        {
            InternalNatives.DestroyDefeatCondition(whichCondition);
        }
        
        private void defeatConditionSetDescription(JassDefeatCondition whichCondition, String description)
        {
            InternalNatives.DefeatConditionSetDescription(whichCondition, description);
        }
        
        private void flashQuestDialogButton()
        {
            InternalNatives.FlashQuestDialogButton();
        }
        
        private void forceQuestDialogUpdate()
        {
            InternalNatives.ForceQuestDialogUpdate();
        }
        
        private JassTimerDialog createTimerDialog(JassTimer t)
        {
            return InternalNatives.CreateTimerDialog(t);
        }
        
        private void destroyTimerDialog(JassTimerDialog whichDialog)
        {
            InternalNatives.DestroyTimerDialog(whichDialog);
        }
        
        private void timerDialogSetTitle(JassTimerDialog whichDialog, String title)
        {
            InternalNatives.TimerDialogSetTitle(whichDialog, title);
        }
        
        private void timerDialogSetTitleColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.TimerDialogSetTitleColor(whichDialog, red, green, blue, alpha);
        }
        
        private void timerDialogSetTimeColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.TimerDialogSetTimeColor(whichDialog, red, green, blue, alpha);
        }
        
        private void timerDialogSetSpeed(JassTimerDialog whichDialog, Single speedMultFactor)
        {
            InternalNatives.TimerDialogSetSpeed(whichDialog, speedMultFactor);
        }
        
        private void timerDialogDisplay(JassTimerDialog whichDialog, Boolean display)
        {
            InternalNatives.TimerDialogDisplay(whichDialog, display);
        }
        
        private Boolean isTimerDialogDisplayed(JassTimerDialog whichDialog)
        {
            return InternalNatives.IsTimerDialogDisplayed(whichDialog);
        }
        
        private void timerDialogSetRealTimeRemaining(JassTimerDialog whichDialog, Single timeRemaining)
        {
            InternalNatives.TimerDialogSetRealTimeRemaining(whichDialog, timeRemaining);
        }
        
        private JassLeaderboard createLeaderboard()
        {
            return InternalNatives.CreateLeaderboard();
        }
        
        private void destroyLeaderboard(JassLeaderboard lb)
        {
            InternalNatives.DestroyLeaderboard(lb);
        }
        
        private void leaderboardDisplay(JassLeaderboard lb, Boolean show)
        {
            InternalNatives.LeaderboardDisplay(lb, show);
        }
        
        private Boolean isLeaderboardDisplayed(JassLeaderboard lb)
        {
            return InternalNatives.IsLeaderboardDisplayed(lb);
        }
        
        private JassInteger leaderboardGetItemCount(JassLeaderboard lb)
        {
            return InternalNatives.LeaderboardGetItemCount(lb);
        }
        
        private void leaderboardSetSizeByItemCount(JassLeaderboard lb, JassInteger count)
        {
            InternalNatives.LeaderboardSetSizeByItemCount(lb, count);
        }
        
        private void leaderboardAddItem(JassLeaderboard lb, String label, JassInteger value, JassPlayer p)
        {
            InternalNatives.LeaderboardAddItem(lb, label, value, p);
        }
        
        private void leaderboardRemoveItem(JassLeaderboard lb, JassInteger index)
        {
            InternalNatives.LeaderboardRemoveItem(lb, index);
        }
        
        private void leaderboardRemovePlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            InternalNatives.LeaderboardRemovePlayerItem(lb, p);
        }
        
        private void leaderboardClear(JassLeaderboard lb)
        {
            InternalNatives.LeaderboardClear(lb);
        }
        
        private void leaderboardSortItemsByValue(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives.LeaderboardSortItemsByValue(lb, ascending);
        }
        
        private void leaderboardSortItemsByPlayer(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives.LeaderboardSortItemsByPlayer(lb, ascending);
        }
        
        private void leaderboardSortItemsByLabel(JassLeaderboard lb, Boolean ascending)
        {
            InternalNatives.LeaderboardSortItemsByLabel(lb, ascending);
        }
        
        private Boolean leaderboardHasPlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            return InternalNatives.LeaderboardHasPlayerItem(lb, p);
        }
        
        private JassInteger leaderboardGetPlayerIndex(JassLeaderboard lb, JassPlayer p)
        {
            return InternalNatives.LeaderboardGetPlayerIndex(lb, p);
        }
        
        private void leaderboardSetLabel(JassLeaderboard lb, String label)
        {
            InternalNatives.LeaderboardSetLabel(lb, label);
        }
        
        private String leaderboardGetLabelText(JassLeaderboard lb)
        {
            return InternalNatives.LeaderboardGetLabelText(lb);
        }
        
        private void playerSetLeaderboard(JassPlayer toPlayer, JassLeaderboard lb)
        {
            InternalNatives.PlayerSetLeaderboard(toPlayer, lb);
        }
        
        private JassLeaderboard playerGetLeaderboard(JassPlayer toPlayer)
        {
            return InternalNatives.PlayerGetLeaderboard(toPlayer);
        }
        
        private void leaderboardSetLabelColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.LeaderboardSetLabelColor(lb, red, green, blue, alpha);
        }
        
        private void leaderboardSetValueColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.LeaderboardSetValueColor(lb, red, green, blue, alpha);
        }
        
        private void leaderboardSetStyle(JassLeaderboard lb, Boolean showLabel, Boolean showNames, Boolean showValues, Boolean showIcons)
        {
            InternalNatives.LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);
        }
        
        private void leaderboardSetItemValue(JassLeaderboard lb, JassInteger whichItem, JassInteger val)
        {
            InternalNatives.LeaderboardSetItemValue(lb, whichItem, val);
        }
        
        private void leaderboardSetItemLabel(JassLeaderboard lb, JassInteger whichItem, String val)
        {
            InternalNatives.LeaderboardSetItemLabel(lb, whichItem, val);
        }
        
        private void leaderboardSetItemStyle(JassLeaderboard lb, JassInteger whichItem, Boolean showLabel, Boolean showValue, Boolean showIcon)
        {
            InternalNatives.LeaderboardSetItemStyle(lb, whichItem, showLabel, showValue, showIcon);
        }
        
        private void leaderboardSetItemLabelColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.LeaderboardSetItemLabelColor(lb, whichItem, red, green, blue, alpha);
        }
        
        private void leaderboardSetItemValueColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.LeaderboardSetItemValueColor(lb, whichItem, red, green, blue, alpha);
        }
        
        private JassMultiboard createMultiboard()
        {
            return InternalNatives.CreateMultiboard();
        }
        
        private void destroyMultiboard(JassMultiboard lb)
        {
            InternalNatives.DestroyMultiboard(lb);
        }
        
        private void multiboardDisplay(JassMultiboard lb, Boolean show)
        {
            InternalNatives.MultiboardDisplay(lb, show);
        }
        
        private Boolean isMultiboardDisplayed(JassMultiboard lb)
        {
            return InternalNatives.IsMultiboardDisplayed(lb);
        }
        
        private void multiboardMinimize(JassMultiboard lb, Boolean minimize)
        {
            InternalNatives.MultiboardMinimize(lb, minimize);
        }
        
        private Boolean isMultiboardMinimized(JassMultiboard lb)
        {
            return InternalNatives.IsMultiboardMinimized(lb);
        }
        
        private void multiboardClear(JassMultiboard lb)
        {
            InternalNatives.MultiboardClear(lb);
        }
        
        private void multiboardSetTitleText(JassMultiboard lb, String label)
        {
            InternalNatives.MultiboardSetTitleText(lb, label);
        }
        
        private String multiboardGetTitleText(JassMultiboard lb)
        {
            return InternalNatives.MultiboardGetTitleText(lb);
        }
        
        private void multiboardSetTitleTextColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.MultiboardSetTitleTextColor(lb, red, green, blue, alpha);
        }
        
        private JassInteger multiboardGetRowCount(JassMultiboard lb)
        {
            return InternalNatives.MultiboardGetRowCount(lb);
        }
        
        private JassInteger multiboardGetColumnCount(JassMultiboard lb)
        {
            return InternalNatives.MultiboardGetColumnCount(lb);
        }
        
        private void multiboardSetColumnCount(JassMultiboard lb, JassInteger count)
        {
            InternalNatives.MultiboardSetColumnCount(lb, count);
        }
        
        private void multiboardSetRowCount(JassMultiboard lb, JassInteger count)
        {
            InternalNatives.MultiboardSetRowCount(lb, count);
        }
        
        private void multiboardSetItemsStyle(JassMultiboard lb, Boolean showValues, Boolean showIcons)
        {
            InternalNatives.MultiboardSetItemsStyle(lb, showValues, showIcons);
        }
        
        private void multiboardSetItemsValue(JassMultiboard lb, String value)
        {
            InternalNatives.MultiboardSetItemsValue(lb, value);
        }
        
        private void multiboardSetItemsValueColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.MultiboardSetItemsValueColor(lb, red, green, blue, alpha);
        }
        
        private void multiboardSetItemsWidth(JassMultiboard lb, Single width)
        {
            InternalNatives.MultiboardSetItemsWidth(lb, width);
        }
        
        private void multiboardSetItemsIcon(JassMultiboard lb, String iconPath)
        {
            InternalNatives.MultiboardSetItemsIcon(lb, iconPath);
        }
        
        private JassMultiboardItem multiboardGetItem(JassMultiboard lb, JassInteger row, JassInteger column)
        {
            return InternalNatives.MultiboardGetItem(lb, row, column);
        }
        
        private void multiboardReleaseItem(JassMultiboardItem mbi)
        {
            InternalNatives.MultiboardReleaseItem(mbi);
        }
        
        private void multiboardSetItemStyle(JassMultiboardItem mbi, Boolean showValue, Boolean showIcon)
        {
            InternalNatives.MultiboardSetItemStyle(mbi, showValue, showIcon);
        }
        
        private void multiboardSetItemValue(JassMultiboardItem mbi, String val)
        {
            InternalNatives.MultiboardSetItemValue(mbi, val);
        }
        
        private void multiboardSetItemValueColor(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.MultiboardSetItemValueColor(mbi, red, green, blue, alpha);
        }
        
        private void multiboardSetItemWidth(JassMultiboardItem mbi, Single width)
        {
            InternalNatives.MultiboardSetItemWidth(mbi, width);
        }
        
        private void multiboardSetItemIcon(JassMultiboardItem mbi, String iconFileName)
        {
            InternalNatives.MultiboardSetItemIcon(mbi, iconFileName);
        }
        
        private void multiboardSuppressDisplay(Boolean flag)
        {
            InternalNatives.MultiboardSuppressDisplay(flag);
        }
        
        private void setCameraPosition(Single x, Single y)
        {
            InternalNatives.SetCameraPosition(x, y);
        }
        
        private void setCameraQuickPosition(Single x, Single y)
        {
            InternalNatives.SetCameraQuickPosition(x, y);
        }
        
        private void setCameraBounds(Single x1, Single y1, Single x2, Single y2, Single x3, Single y3, Single x4, Single y4)
        {
            InternalNatives.SetCameraBounds(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        
        private void stopCamera()
        {
            InternalNatives.StopCamera();
        }
        
        private void resetToGameCamera(Single duration)
        {
            InternalNatives.ResetToGameCamera(duration);
        }
        
        private void panCameraTo(Single x, Single y)
        {
            InternalNatives.PanCameraTo(x, y);
        }
        
        private void panCameraToTimed(Single x, Single y, Single duration)
        {
            InternalNatives.PanCameraToTimed(x, y, duration);
        }
        
        private void panCameraToWithZ(Single x, Single y, Single zOffsetDest)
        {
            InternalNatives.PanCameraToWithZ(x, y, zOffsetDest);
        }
        
        private void panCameraToTimedWithZ(Single x, Single y, Single zOffsetDest, Single duration)
        {
            InternalNatives.PanCameraToTimedWithZ(x, y, zOffsetDest, duration);
        }
        
        private void setCinematicCamera(String cameraModelFile)
        {
            InternalNatives.SetCinematicCamera(cameraModelFile);
        }
        
        private void setCameraRotateMode(Single x, Single y, Single radiansToSweep, Single duration)
        {
            InternalNatives.SetCameraRotateMode(x, y, radiansToSweep, duration);
        }
        
        private void setCameraField(JassCameraField whichField, Single value, Single duration)
        {
            InternalNatives.SetCameraField(whichField, value, duration);
        }
        
        private void adjustCameraField(JassCameraField whichField, Single offset, Single duration)
        {
            InternalNatives.AdjustCameraField(whichField, offset, duration);
        }
        
        private void setCameraTargetController(JassUnit whichUnit, Single xoffset, Single yoffset, Boolean inheritOrientation)
        {
            InternalNatives.SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);
        }
        
        private void setCameraOrientController(JassUnit whichUnit, Single xoffset, Single yoffset)
        {
            InternalNatives.SetCameraOrientController(whichUnit, xoffset, yoffset);
        }
        
        private JassCameraSetup createCameraSetup()
        {
            return InternalNatives.CreateCameraSetup();
        }
        
        private void cameraSetupSetField(JassCameraSetup whichSetup, JassCameraField whichField, Single value, Single duration)
        {
            InternalNatives.CameraSetupSetField(whichSetup, whichField, value, duration);
        }
        
        private Single cameraSetupGetField(JassCameraSetup whichSetup, JassCameraField whichField)
        {
            return InternalNatives.CameraSetupGetField(whichSetup, whichField);
        }
        
        private void cameraSetupSetDestPosition(JassCameraSetup whichSetup, Single x, Single y, Single duration)
        {
            InternalNatives.CameraSetupSetDestPosition(whichSetup, x, y, duration);
        }
        
        private JassLocation cameraSetupGetDestPositionLoc(JassCameraSetup whichSetup)
        {
            return InternalNatives.CameraSetupGetDestPositionLoc(whichSetup);
        }
        
        private Single cameraSetupGetDestPositionX(JassCameraSetup whichSetup)
        {
            return InternalNatives.CameraSetupGetDestPositionX(whichSetup);
        }
        
        private Single cameraSetupGetDestPositionY(JassCameraSetup whichSetup)
        {
            return InternalNatives.CameraSetupGetDestPositionY(whichSetup);
        }
        
        private void cameraSetupApply(JassCameraSetup whichSetup, Boolean doPan, Boolean panTimed)
        {
            InternalNatives.CameraSetupApply(whichSetup, doPan, panTimed);
        }
        
        private void cameraSetupApplyWithZ(JassCameraSetup whichSetup, Single zDestOffset)
        {
            InternalNatives.CameraSetupApplyWithZ(whichSetup, zDestOffset);
        }
        
        private void cameraSetupApplyForceDuration(JassCameraSetup whichSetup, Boolean doPan, Single forceDuration)
        {
            InternalNatives.CameraSetupApplyForceDuration(whichSetup, doPan, forceDuration);
        }
        
        private void cameraSetupApplyForceDurationWithZ(JassCameraSetup whichSetup, Single zDestOffset, Single forceDuration)
        {
            InternalNatives.CameraSetupApplyForceDurationWithZ(whichSetup, zDestOffset, forceDuration);
        }
        
        private void cameraSetTargetNoise(Single mag, Single velocity)
        {
            InternalNatives.CameraSetTargetNoise(mag, velocity);
        }
        
        private void cameraSetSourceNoise(Single mag, Single velocity)
        {
            InternalNatives.CameraSetSourceNoise(mag, velocity);
        }
        
        private void cameraSetTargetNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            InternalNatives.CameraSetTargetNoiseEx(mag, velocity, vertOnly);
        }
        
        private void cameraSetSourceNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            InternalNatives.CameraSetSourceNoiseEx(mag, velocity, vertOnly);
        }
        
        private void cameraSetSmoothingFactor(Single factor)
        {
            InternalNatives.CameraSetSmoothingFactor(factor);
        }
        
        private void setCineFilterTexture(String filename)
        {
            InternalNatives.SetCineFilterTexture(filename);
        }
        
        private void setCineFilterBlendMode(JassBlendMode whichMode)
        {
            InternalNatives.SetCineFilterBlendMode(whichMode);
        }
        
        private void setCineFilterTexMapFlags(JassTextureMapFlags whichFlags)
        {
            InternalNatives.SetCineFilterTexMapFlags(whichFlags);
        }
        
        private void setCineFilterStartUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            InternalNatives.SetCineFilterStartUV(minu, minv, maxu, maxv);
        }
        
        private void setCineFilterEndUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            InternalNatives.SetCineFilterEndUV(minu, minv, maxu, maxv);
        }
        
        private void setCineFilterStartColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetCineFilterStartColor(red, green, blue, alpha);
        }
        
        private void setCineFilterEndColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetCineFilterEndColor(red, green, blue, alpha);
        }
        
        private void setCineFilterDuration(Single duration)
        {
            InternalNatives.SetCineFilterDuration(duration);
        }
        
        private void displayCineFilter(Boolean flag)
        {
            InternalNatives.DisplayCineFilter(flag);
        }
        
        private Boolean isCineFilterDisplayed()
        {
            return InternalNatives.IsCineFilterDisplayed();
        }
        
        private void setCinematicScene(JassInteger portraitUnitId, JassPlayerColor color, String speakerTitle, String text, Single sceneDuration, Single voiceoverDuration)
        {
            InternalNatives.SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);
        }
        
        private void endCinematicScene()
        {
            InternalNatives.EndCinematicScene();
        }
        
        private void forceCinematicSubtitles(Boolean flag)
        {
            InternalNatives.ForceCinematicSubtitles(flag);
        }
        
        private Single getCameraMargin(JassInteger whichMargin)
        {
            return InternalNatives.GetCameraMargin(whichMargin);
        }
        
        private Single getCameraBoundMinX()
        {
            return InternalNatives.GetCameraBoundMinX();
        }
        
        private Single getCameraBoundMinY()
        {
            return InternalNatives.GetCameraBoundMinY();
        }
        
        private Single getCameraBoundMaxX()
        {
            return InternalNatives.GetCameraBoundMaxX();
        }
        
        private Single getCameraBoundMaxY()
        {
            return InternalNatives.GetCameraBoundMaxY();
        }
        
        private Single getCameraField(JassCameraField whichField)
        {
            return InternalNatives.GetCameraField(whichField);
        }
        
        private Single getCameraTargetPositionX()
        {
            return InternalNatives.GetCameraTargetPositionX();
        }
        
        private Single getCameraTargetPositionY()
        {
            return InternalNatives.GetCameraTargetPositionY();
        }
        
        private Single getCameraTargetPositionZ()
        {
            return InternalNatives.GetCameraTargetPositionZ();
        }
        
        private JassLocation getCameraTargetPositionLoc()
        {
            return InternalNatives.GetCameraTargetPositionLoc();
        }
        
        private Single getCameraEyePositionX()
        {
            return InternalNatives.GetCameraEyePositionX();
        }
        
        private Single getCameraEyePositionY()
        {
            return InternalNatives.GetCameraEyePositionY();
        }
        
        private Single getCameraEyePositionZ()
        {
            return InternalNatives.GetCameraEyePositionZ();
        }
        
        private JassLocation getCameraEyePositionLoc()
        {
            return InternalNatives.GetCameraEyePositionLoc();
        }
        
        private void newSoundEnvironment(String environmentName)
        {
            InternalNatives.NewSoundEnvironment(environmentName);
        }
        
        private JassSound createSound(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String eaxSetting)
        {
            return InternalNatives.CreateSound(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, eaxSetting);
        }
        
        private JassSound createSoundFilenameWithLabel(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String SLKEntryName)
        {
            return InternalNatives.CreateSoundFilenameWithLabel(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, SLKEntryName);
        }
        
        private JassSound createSoundFromLabel(String soundLabel, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return InternalNatives.CreateSoundFromLabel(soundLabel, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate);
        }
        
        private JassSound createMIDISound(String soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return InternalNatives.CreateMIDISound(soundLabel, fadeInRate, fadeOutRate);
        }
        
        private void setSoundParamsFromLabel(JassSound soundHandle, String soundLabel)
        {
            InternalNatives.SetSoundParamsFromLabel(soundHandle, soundLabel);
        }
        
        private void setSoundDistanceCutoff(JassSound soundHandle, Single cutoff)
        {
            InternalNatives.SetSoundDistanceCutoff(soundHandle, cutoff);
        }
        
        private void setSoundChannel(JassSound soundHandle, JassInteger channel)
        {
            InternalNatives.SetSoundChannel(soundHandle, channel);
        }
        
        private void setSoundVolume(JassSound soundHandle, JassInteger volume)
        {
            InternalNatives.SetSoundVolume(soundHandle, volume);
        }
        
        private void setSoundPitch(JassSound soundHandle, Single pitch)
        {
            InternalNatives.SetSoundPitch(soundHandle, pitch);
        }
        
        private void setSoundPlayPosition(JassSound soundHandle, JassInteger millisecs)
        {
            InternalNatives.SetSoundPlayPosition(soundHandle, millisecs);
        }
        
        private void setSoundDistances(JassSound soundHandle, Single minDist, Single maxDist)
        {
            InternalNatives.SetSoundDistances(soundHandle, minDist, maxDist);
        }
        
        private void setSoundConeAngles(JassSound soundHandle, Single inside, Single outside, JassInteger outsideVolume)
        {
            InternalNatives.SetSoundConeAngles(soundHandle, inside, outside, outsideVolume);
        }
        
        private void setSoundConeOrientation(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives.SetSoundConeOrientation(soundHandle, x, y, z);
        }
        
        private void setSoundPosition(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives.SetSoundPosition(soundHandle, x, y, z);
        }
        
        private void setSoundVelocity(JassSound soundHandle, Single x, Single y, Single z)
        {
            InternalNatives.SetSoundVelocity(soundHandle, x, y, z);
        }
        
        private void attachSoundToUnit(JassSound soundHandle, JassUnit whichUnit)
        {
            InternalNatives.AttachSoundToUnit(soundHandle, whichUnit);
        }
        
        private void startSound(JassSound soundHandle)
        {
            InternalNatives.StartSound(soundHandle);
        }
        
        private void stopSound(JassSound soundHandle, Boolean killWhenDone, Boolean fadeOut)
        {
            InternalNatives.StopSound(soundHandle, killWhenDone, fadeOut);
        }
        
        private void killSoundWhenDone(JassSound soundHandle)
        {
            InternalNatives.KillSoundWhenDone(soundHandle);
        }
        
        private void setMapMusic(String musicName, Boolean random, JassInteger index)
        {
            InternalNatives.SetMapMusic(musicName, random, index);
        }
        
        private void clearMapMusic()
        {
            InternalNatives.ClearMapMusic();
        }
        
        private void playMusic(String musicName)
        {
            InternalNatives.PlayMusic(musicName);
        }
        
        private void playMusicEx(String musicName, JassInteger frommsecs, JassInteger fadeinmsecs)
        {
            InternalNatives.PlayMusicEx(musicName, frommsecs, fadeinmsecs);
        }
        
        private void stopMusic(Boolean fadeOut)
        {
            InternalNatives.StopMusic(fadeOut);
        }
        
        private void resumeMusic()
        {
            InternalNatives.ResumeMusic();
        }
        
        private void playThematicMusic(String musicFileName)
        {
            InternalNatives.PlayThematicMusic(musicFileName);
        }
        
        private void playThematicMusicEx(String musicFileName, JassInteger frommsecs)
        {
            InternalNatives.PlayThematicMusicEx(musicFileName, frommsecs);
        }
        
        private void endThematicMusic()
        {
            InternalNatives.EndThematicMusic();
        }
        
        private void setMusicVolume(JassInteger volume)
        {
            InternalNatives.SetMusicVolume(volume);
        }
        
        private void setMusicPlayPosition(JassInteger millisecs)
        {
            InternalNatives.SetMusicPlayPosition(millisecs);
        }
        
        private void setThematicMusicPlayPosition(JassInteger millisecs)
        {
            InternalNatives.SetThematicMusicPlayPosition(millisecs);
        }
        
        private void setSoundDuration(JassSound soundHandle, JassInteger duration)
        {
            InternalNatives.SetSoundDuration(soundHandle, duration);
        }
        
        private JassInteger getSoundDuration(JassSound soundHandle)
        {
            return InternalNatives.GetSoundDuration(soundHandle);
        }
        
        private JassInteger getSoundFileDuration(String musicFileName)
        {
            return InternalNatives.GetSoundFileDuration(musicFileName);
        }
        
        private void volumeGroupSetVolume(JassVolumeGroup vgroup, Single scale)
        {
            InternalNatives.VolumeGroupSetVolume(vgroup, scale);
        }
        
        private void volumeGroupReset()
        {
            InternalNatives.VolumeGroupReset();
        }
        
        private Boolean getSoundIsPlaying(JassSound soundHandle)
        {
            return InternalNatives.GetSoundIsPlaying(soundHandle);
        }
        
        private Boolean getSoundIsLoading(JassSound soundHandle)
        {
            return InternalNatives.GetSoundIsLoading(soundHandle);
        }
        
        private void registerStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            InternalNatives.RegisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        private void unregisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            InternalNatives.UnregisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        private JassWeatherEffect addWeatherEffect(JassRect where, JassInteger effectID)
        {
            return InternalNatives.AddWeatherEffect(where, effectID);
        }
        
        private void removeWeatherEffect(JassWeatherEffect whichEffect)
        {
            InternalNatives.RemoveWeatherEffect(whichEffect);
        }
        
        private void enableWeatherEffect(JassWeatherEffect whichEffect, Boolean enable)
        {
            InternalNatives.EnableWeatherEffect(whichEffect, enable);
        }
        
        private JassTerrainDeformation terrainDeformCrater(Single x, Single y, Single radius, Single depth, JassInteger duration, Boolean permanent)
        {
            return InternalNatives.TerrainDeformCrater(x, y, radius, depth, duration, permanent);
        }
        
        private JassTerrainDeformation terrainDeformRipple(Single x, Single y, Single radius, Single depth, JassInteger duration, JassInteger count, Single spaceWaves, Single timeWaves, Single radiusStartPct, Boolean limitNeg)
        {
            return InternalNatives.TerrainDeformRipple(x, y, radius, depth, duration, count, spaceWaves, timeWaves, radiusStartPct, limitNeg);
        }
        
        private JassTerrainDeformation terrainDeformWave(Single x, Single y, Single dirX, Single dirY, Single distance, Single speed, Single radius, Single depth, JassInteger trailTime, JassInteger count)
        {
            return InternalNatives.TerrainDeformWave(x, y, dirX, dirY, distance, speed, radius, depth, trailTime, count);
        }
        
        private JassTerrainDeformation terrainDeformRandom(Single x, Single y, Single radius, Single minDelta, Single maxDelta, JassInteger duration, JassInteger updateInterval)
        {
            return InternalNatives.TerrainDeformRandom(x, y, radius, minDelta, maxDelta, duration, updateInterval);
        }
        
        private void terrainDeformStop(JassTerrainDeformation deformation, JassInteger duration)
        {
            InternalNatives.TerrainDeformStop(deformation, duration);
        }
        
        private void terrainDeformStopAll()
        {
            InternalNatives.TerrainDeformStopAll();
        }
        
        private JassEffect addSpecialEffect(String modelName, Single x, Single y)
        {
            return InternalNatives.AddSpecialEffect(modelName, x, y);
        }
        
        private JassEffect addSpecialEffectLoc(String modelName, JassLocation where)
        {
            return InternalNatives.AddSpecialEffectLoc(modelName, where);
        }
        
        private JassEffect addSpecialEffectTarget(String modelName, JassWidget targetWidget, String attachPointName)
        {
            return InternalNatives.AddSpecialEffectTarget(modelName, targetWidget, attachPointName);
        }
        
        private void destroyEffect(JassEffect whichEffect)
        {
            InternalNatives.DestroyEffect(whichEffect);
        }
        
        private JassEffect addSpellEffect(String abilityString, JassEffectType t, Single x, Single y)
        {
            return InternalNatives.AddSpellEffect(abilityString, t, x, y);
        }
        
        private JassEffect addSpellEffectLoc(String abilityString, JassEffectType t, JassLocation where)
        {
            return InternalNatives.AddSpellEffectLoc(abilityString, t, where);
        }
        
        private JassEffect addSpellEffectById(JassInteger abilityId, JassEffectType t, Single x, Single y)
        {
            return InternalNatives.AddSpellEffectById(abilityId, t, x, y);
        }
        
        private JassEffect addSpellEffectByIdLoc(JassInteger abilityId, JassEffectType t, JassLocation where)
        {
            return InternalNatives.AddSpellEffectByIdLoc(abilityId, t, where);
        }
        
        private JassEffect addSpellEffectTarget(String modelName, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return InternalNatives.AddSpellEffectTarget(modelName, t, targetWidget, attachPoint);
        }
        
        private JassEffect addSpellEffectTargetById(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return InternalNatives.AddSpellEffectTargetById(abilityId, t, targetWidget, attachPoint);
        }
        
        private JassLightning addLightning(String codeName, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return InternalNatives.AddLightning(codeName, checkVisibility, x1, y1, x2, y2);
        }
        
        private JassLightning addLightningEx(String codeName, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return InternalNatives.AddLightningEx(codeName, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        private Boolean destroyLightning(JassLightning whichBolt)
        {
            return InternalNatives.DestroyLightning(whichBolt);
        }
        
        private Boolean moveLightning(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return InternalNatives.MoveLightning(whichBolt, checkVisibility, x1, y1, x2, y2);
        }
        
        private Boolean moveLightningEx(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return InternalNatives.MoveLightningEx(whichBolt, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        private Single getLightningColorA(JassLightning whichBolt)
        {
            return InternalNatives.GetLightningColorA(whichBolt);
        }
        
        private Single getLightningColorR(JassLightning whichBolt)
        {
            return InternalNatives.GetLightningColorR(whichBolt);
        }
        
        private Single getLightningColorG(JassLightning whichBolt)
        {
            return InternalNatives.GetLightningColorG(whichBolt);
        }
        
        private Single getLightningColorB(JassLightning whichBolt)
        {
            return InternalNatives.GetLightningColorB(whichBolt);
        }
        
        private Boolean setLightningColor(JassLightning whichBolt, Single r, Single g, Single b, Single a)
        {
            return InternalNatives.SetLightningColor(whichBolt, r, g, b, a);
        }
        
        private String getAbilityEffect(String abilityString, JassEffectType t, JassInteger index)
        {
            return InternalNatives.GetAbilityEffect(abilityString, t, index);
        }
        
        private String getAbilityEffectById(JassInteger abilityId, JassEffectType t, JassInteger index)
        {
            return InternalNatives.GetAbilityEffectById(abilityId, t, index);
        }
        
        private String getAbilitySound(String abilityString, JassSoundType t)
        {
            return InternalNatives.GetAbilitySound(abilityString, t);
        }
        
        private String getAbilitySoundById(JassInteger abilityId, JassSoundType t)
        {
            return InternalNatives.GetAbilitySoundById(abilityId, t);
        }
        
        private JassInteger getTerrainCliffLevel(Single x, Single y)
        {
            return InternalNatives.GetTerrainCliffLevel(x, y);
        }
        
        private void setWaterBaseColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetWaterBaseColor(red, green, blue, alpha);
        }
        
        private void setWaterDeforms(Boolean val)
        {
            InternalNatives.SetWaterDeforms(val);
        }
        
        private JassInteger getTerrainType(Single x, Single y)
        {
            return InternalNatives.GetTerrainType(x, y);
        }
        
        private JassInteger getTerrainVariance(Single x, Single y)
        {
            return InternalNatives.GetTerrainVariance(x, y);
        }
        
        private void setTerrainType(Single x, Single y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape)
        {
            InternalNatives.SetTerrainType(x, y, terrainType, variation, area, shape);
        }
        
        private Boolean isTerrainPathable(Single x, Single y, JassPathingType t)
        {
            return InternalNatives.IsTerrainPathable(x, y, t);
        }
        
        private void setTerrainPathable(Single x, Single y, JassPathingType t, Boolean flag)
        {
            InternalNatives.SetTerrainPathable(x, y, t, flag);
        }
        
        private JassImage createImage(String file, Single sizeX, Single sizeY, Single sizeZ, Single posX, Single posY, Single posZ, Single originX, Single originY, Single originZ, JassInteger imageType)
        {
            return InternalNatives.CreateImage(file, sizeX, sizeY, sizeZ, posX, posY, posZ, originX, originY, originZ, imageType);
        }
        
        private void destroyImage(JassImage whichImage)
        {
            InternalNatives.DestroyImage(whichImage);
        }
        
        private void showImage(JassImage whichImage, Boolean flag)
        {
            InternalNatives.ShowImage(whichImage, flag);
        }
        
        private void setImageConstantHeight(JassImage whichImage, Boolean flag, Single height)
        {
            InternalNatives.SetImageConstantHeight(whichImage, flag, height);
        }
        
        private void setImagePosition(JassImage whichImage, Single x, Single y, Single z)
        {
            InternalNatives.SetImagePosition(whichImage, x, y, z);
        }
        
        private void setImageColor(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            InternalNatives.SetImageColor(whichImage, red, green, blue, alpha);
        }
        
        private void setImageRender(JassImage whichImage, Boolean flag)
        {
            InternalNatives.SetImageRender(whichImage, flag);
        }
        
        private void setImageRenderAlways(JassImage whichImage, Boolean flag)
        {
            InternalNatives.SetImageRenderAlways(whichImage, flag);
        }
        
        private void setImageAboveWater(JassImage whichImage, Boolean flag, Boolean useWaterAlpha)
        {
            InternalNatives.SetImageAboveWater(whichImage, flag, useWaterAlpha);
        }
        
        private void setImageType(JassImage whichImage, JassInteger imageType)
        {
            InternalNatives.SetImageType(whichImage, imageType);
        }
        
        private JassUberSplat createUbersplat(Single x, Single y, String name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, Boolean forcePaused, Boolean noBirthTime)
        {
            return InternalNatives.CreateUbersplat(x, y, name, red, green, blue, alpha, forcePaused, noBirthTime);
        }
        
        private void destroyUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives.DestroyUbersplat(whichSplat);
        }
        
        private void resetUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives.ResetUbersplat(whichSplat);
        }
        
        private void finishUbersplat(JassUberSplat whichSplat)
        {
            InternalNatives.FinishUbersplat(whichSplat);
        }
        
        private void showUbersplat(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives.ShowUbersplat(whichSplat, flag);
        }
        
        private void setUbersplatRender(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives.SetUbersplatRender(whichSplat, flag);
        }
        
        private void setUbersplatRenderAlways(JassUberSplat whichSplat, Boolean flag)
        {
            InternalNatives.SetUbersplatRenderAlways(whichSplat, flag);
        }
        
        private void setBlight(JassPlayer whichPlayer, Single x, Single y, Single radius, Boolean addBlight)
        {
            InternalNatives.SetBlight(whichPlayer, x, y, radius, addBlight);
        }
        
        private void setBlightRect(JassPlayer whichPlayer, JassRect r, Boolean addBlight)
        {
            InternalNatives.SetBlightRect(whichPlayer, r, addBlight);
        }
        
        private void setBlightPoint(JassPlayer whichPlayer, Single x, Single y, Boolean addBlight)
        {
            InternalNatives.SetBlightPoint(whichPlayer, x, y, addBlight);
        }
        
        private void setBlightLoc(JassPlayer whichPlayer, JassLocation whichLocation, Single radius, Boolean addBlight)
        {
            InternalNatives.SetBlightLoc(whichPlayer, whichLocation, radius, addBlight);
        }
        
        private JassUnit createBlightedGoldmine(JassPlayer id, Single x, Single y, Single face)
        {
            return InternalNatives.CreateBlightedGoldmine(id, x, y, face);
        }
        
        private Boolean isPointBlighted(Single x, Single y)
        {
            return InternalNatives.IsPointBlighted(x, y);
        }
        
        private void setDoodadAnimation(Single x, Single y, Single radius, JassObjectId doodadID, Boolean nearestOnly, String animName, Boolean animRandom)
        {
            InternalNatives.SetDoodadAnimation(x, y, radius, doodadID, nearestOnly, animName, animRandom);
        }
        
        private void setDoodadAnimationRect(JassRect r, JassObjectId doodadID, String animName, Boolean animRandom)
        {
            InternalNatives.SetDoodadAnimationRect(r, doodadID, animName, animRandom);
        }
        
        private void startMeleeAI(JassPlayer num, String script)
        {
            InternalNatives.StartMeleeAI(num, script);
        }
        
        private void startCampaignAI(JassPlayer num, String script)
        {
            InternalNatives.StartCampaignAI(num, script);
        }
        
        private void commandAI(JassPlayer num, JassInteger command, JassInteger data)
        {
            InternalNatives.CommandAI(num, command, data);
        }
        
        private void pauseCompAI(JassPlayer p, Boolean pause)
        {
            InternalNatives.PauseCompAI(p, pause);
        }
        
        private JassAIDifficulty getAIDifficulty(JassPlayer num)
        {
            return InternalNatives.GetAIDifficulty(num);
        }
        
        private void removeGuardPosition(JassUnit hUnit)
        {
            InternalNatives.RemoveGuardPosition(hUnit);
        }
        
        private void recycleGuardPosition(JassUnit hUnit)
        {
            InternalNatives.RecycleGuardPosition(hUnit);
        }
        
        private void removeAllGuardPositions(JassPlayer num)
        {
            InternalNatives.RemoveAllGuardPositions(num);
        }
        
        private void cheat(String cheatStr)
        {
            InternalNatives.Cheat(cheatStr);
        }
        
        private Boolean isNoVictoryCheat()
        {
            return InternalNatives.IsNoVictoryCheat();
        }
        
        private Boolean isNoDefeatCheat()
        {
            return InternalNatives.IsNoDefeatCheat();
        }
        
        private void preload(String filename)
        {
            InternalNatives.Preload(filename);
        }
        
        private void preloadEnd(Single timeout)
        {
            InternalNatives.PreloadEnd(timeout);
        }
        
        private void preloadStart()
        {
            InternalNatives.PreloadStart();
        }
        
        private void preloadRefresh()
        {
            InternalNatives.PreloadRefresh();
        }
        
        private void preloadEndEx()
        {
            InternalNatives.PreloadEndEx();
        }
        
        private void preloadGenClear()
        {
            InternalNatives.PreloadGenClear();
        }
        
        private void preloadGenStart()
        {
            InternalNatives.PreloadGenStart();
        }
        
        private void preloadGenEnd(String filename)
        {
            InternalNatives.PreloadGenEnd(filename);
        }
        
        private void preloader(String filename)
        {
            InternalNatives.Preloader(filename);
        }
        
        public static JassRace ConvertRace(JassInteger i)
        {
            return Natives.instance.convertRace(i);
        }
        
        public static JassAllianceType ConvertAllianceType(JassInteger i)
        {
            return Natives.instance.convertAllianceType(i);
        }
        
        public static JassRacePreference ConvertRacePref(JassInteger i)
        {
            return Natives.instance.convertRacePref(i);
        }
        
        public static JassIGameState ConvertIGameState(JassInteger i)
        {
            return Natives.instance.convertIGameState(i);
        }
        
        public static JassFGameState ConvertFGameState(JassInteger i)
        {
            return Natives.instance.convertFGameState(i);
        }
        
        public static JassPlayerState ConvertPlayerState(JassInteger i)
        {
            return Natives.instance.convertPlayerState(i);
        }
        
        public static JassPlayerScore ConvertPlayerScore(JassInteger i)
        {
            return Natives.instance.convertPlayerScore(i);
        }
        
        public static JassPlayerGameResult ConvertPlayerGameResult(JassInteger i)
        {
            return Natives.instance.convertPlayerGameResult(i);
        }
        
        public static JassUnitState ConvertUnitState(JassInteger i)
        {
            return Natives.instance.convertUnitState(i);
        }
        
        public static JassAIDifficulty ConvertAIDifficulty(JassInteger i)
        {
            return Natives.instance.convertAIDifficulty(i);
        }
        
        public static JassGameEvent ConvertGameEvent(JassInteger i)
        {
            return Natives.instance.convertGameEvent(i);
        }
        
        public static JassPlayerEvent ConvertPlayerEvent(JassInteger i)
        {
            return Natives.instance.convertPlayerEvent(i);
        }
        
        public static JassPlayerUnitEvent ConvertPlayerUnitEvent(JassInteger i)
        {
            return Natives.instance.convertPlayerUnitEvent(i);
        }
        
        public static JassWidgetEvent ConvertWidgetEvent(JassInteger i)
        {
            return Natives.instance.convertWidgetEvent(i);
        }
        
        public static JassDialogEvent ConvertDialogEvent(JassInteger i)
        {
            return Natives.instance.convertDialogEvent(i);
        }
        
        public static JassUnitEvent ConvertUnitEvent(JassInteger i)
        {
            return Natives.instance.convertUnitEvent(i);
        }
        
        public static JassLimitOp ConvertLimitOp(JassInteger i)
        {
            return Natives.instance.convertLimitOp(i);
        }
        
        public static JassUnitType ConvertUnitType(JassInteger i)
        {
            return Natives.instance.convertUnitType(i);
        }
        
        public static JassGameSpeed ConvertGameSpeed(JassInteger i)
        {
            return Natives.instance.convertGameSpeed(i);
        }
        
        public static JassPlacement ConvertPlacement(JassInteger i)
        {
            return Natives.instance.convertPlacement(i);
        }
        
        public static JassStartLocationPriority ConvertStartLocPrio(JassInteger i)
        {
            return Natives.instance.convertStartLocPrio(i);
        }
        
        public static JassGameDifficulty ConvertGameDifficulty(JassInteger i)
        {
            return Natives.instance.convertGameDifficulty(i);
        }
        
        public static JassGameType ConvertGameType(JassInteger i)
        {
            return Natives.instance.convertGameType(i);
        }
        
        public static JassMapFlag ConvertMapFlag(JassInteger i)
        {
            return Natives.instance.convertMapFlag(i);
        }
        
        public static JassMapVisibility ConvertMapVisibility(JassInteger i)
        {
            return Natives.instance.convertMapVisibility(i);
        }
        
        public static JassMapSetting ConvertMapSetting(JassInteger i)
        {
            return Natives.instance.convertMapSetting(i);
        }
        
        public static JassMapDensity ConvertMapDensity(JassInteger i)
        {
            return Natives.instance.convertMapDensity(i);
        }
        
        public static JassMapControl ConvertMapControl(JassInteger i)
        {
            return Natives.instance.convertMapControl(i);
        }
        
        public static JassPlayerColor ConvertPlayerColor(JassInteger i)
        {
            return Natives.instance.convertPlayerColor(i);
        }
        
        public static JassPlayerSlotState ConvertPlayerSlotState(JassInteger i)
        {
            return Natives.instance.convertPlayerSlotState(i);
        }
        
        public static JassVolumeGroup ConvertVolumeGroup(JassInteger i)
        {
            return Natives.instance.convertVolumeGroup(i);
        }
        
        public static JassCameraField ConvertCameraField(JassInteger i)
        {
            return Natives.instance.convertCameraField(i);
        }
        
        public static JassBlendMode ConvertBlendMode(JassInteger i)
        {
            return Natives.instance.convertBlendMode(i);
        }
        
        public static JassRarityControl ConvertRarityControl(JassInteger i)
        {
            return Natives.instance.convertRarityControl(i);
        }
        
        public static JassTextureMapFlags ConvertTexMapFlags(JassInteger i)
        {
            return Natives.instance.convertTexMapFlags(i);
        }
        
        public static JassFogState ConvertFogState(JassInteger i)
        {
            return Natives.instance.convertFogState(i);
        }
        
        public static JassEffectType ConvertEffectType(JassInteger i)
        {
            return Natives.instance.convertEffectType(i);
        }
        
        public static JassVersion ConvertVersion(JassInteger i)
        {
            return Natives.instance.convertVersion(i);
        }
        
        public static JassItemType ConvertItemType(JassInteger i)
        {
            return Natives.instance.convertItemType(i);
        }
        
        public static JassAttackType ConvertAttackType(JassInteger i)
        {
            return Natives.instance.convertAttackType(i);
        }
        
        public static JassDamageType ConvertDamageType(JassInteger i)
        {
            return Natives.instance.convertDamageType(i);
        }
        
        public static JassWeaponType ConvertWeaponType(JassInteger i)
        {
            return Natives.instance.convertWeaponType(i);
        }
        
        public static JassSoundType ConvertSoundType(JassInteger i)
        {
            return Natives.instance.convertSoundType(i);
        }
        
        public static JassPathingType ConvertPathingType(JassInteger i)
        {
            return Natives.instance.convertPathingType(i);
        }
        
        public static JassOrder OrderId(String orderIdString)
        {
            return Natives.instance.orderId(orderIdString);
        }
        
        public static String OrderId2String(JassOrder orderId)
        {
            return Natives.instance.orderId2String(orderId);
        }
        
        public static JassObjectId UnitId(String unitIdString)
        {
            return Natives.instance.unitId(unitIdString);
        }
        
        public static String UnitId2String(JassObjectId unitId)
        {
            return Natives.instance.unitId2String(unitId);
        }
        
        public static JassObjectId AbilityId(String abilityIdString)
        {
            return Natives.instance.abilityId(abilityIdString);
        }
        
        public static String AbilityId2String(JassInteger abilityId)
        {
            return Natives.instance.abilityId2String(abilityId);
        }
        
        public static String GetObjectName(JassObjectId objectId)
        {
            return Natives.instance.getObjectName(objectId);
        }
        
        public static Single Deg2Rad(Single degrees)
        {
            return Natives.instance.deg2Rad(degrees);
        }
        
        public static Single Rad2Deg(Single radians)
        {
            return Natives.instance.rad2Deg(radians);
        }
        
        public static Single Sin(Single radians)
        {
            return Natives.instance.sin(radians);
        }
        
        public static Single Cos(Single radians)
        {
            return Natives.instance.cos(radians);
        }
        
        public static Single Tan(Single radians)
        {
            return Natives.instance.tan(radians);
        }
        
        public static Single Asin(Single y)
        {
            return Natives.instance.asin(y);
        }
        
        public static Single Acos(Single x)
        {
            return Natives.instance.acos(x);
        }
        
        public static Single Atan(Single x)
        {
            return Natives.instance.atan(x);
        }
        
        public static Single Atan2(Single y, Single x)
        {
            return Natives.instance.atan2(y, x);
        }
        
        public static Single SquareRoot(Single x)
        {
            return Natives.instance.squareRoot(x);
        }
        
        public static Single Pow(Single x, Single power)
        {
            return Natives.instance.pow(x, power);
        }
        
        public static Single I2R(JassInteger i)
        {
            return Natives.instance.i2R(i);
        }
        
        public static JassInteger R2I(Single r)
        {
            return Natives.instance.r2I(r);
        }
        
        public static String I2S(JassInteger i)
        {
            return Natives.instance.i2S(i);
        }
        
        public static String R2S(Single r)
        {
            return Natives.instance.r2S(r);
        }
        
        public static String R2SW(Single r, JassInteger width, JassInteger precision)
        {
            return Natives.instance.r2SW(r, width, precision);
        }
        
        public static JassInteger S2I(String s)
        {
            return Natives.instance.s2I(s);
        }
        
        public static Single S2R(String s)
        {
            return Natives.instance.s2R(s);
        }
        
        public static JassInteger GetHandleId(JassHandle h)
        {
            return Natives.instance.getHandleId(h);
        }
        
        public static String SubString(String source, JassInteger start, JassInteger end)
        {
            return Natives.instance.subString(source, start, end);
        }
        
        public static JassInteger StringLength(String s)
        {
            return Natives.instance.stringLength(s);
        }
        
        public static String StringCase(String source, Boolean upper)
        {
            return Natives.instance.stringCase(source, upper);
        }
        
        public static JassInteger StringHash(String s)
        {
            return Natives.instance.stringHash(s);
        }
        
        public static String GetLocalizedString(String source)
        {
            return Natives.instance.getLocalizedString(source);
        }
        
        public static JassInteger GetLocalizedHotkey(String source)
        {
            return Natives.instance.getLocalizedHotkey(source);
        }
        
        public static void SetMapName(String name)
        {
            Natives.instance.setMapName(name);
        }
        
        public static void SetMapDescription(String description)
        {
            Natives.instance.setMapDescription(description);
        }
        
        public static void SetTeams(JassInteger teamcount)
        {
            Natives.instance.setTeams(teamcount);
        }
        
        public static void SetPlayers(JassInteger playercount)
        {
            Natives.instance.setPlayers(playercount);
        }
        
        public static void DefineStartLocation(JassInteger whichStartLoc, Single x, Single y)
        {
            Natives.instance.defineStartLocation(whichStartLoc, x, y);
        }
        
        public static void DefineStartLocationLoc(JassInteger whichStartLoc, JassLocation whichLocation)
        {
            Natives.instance.defineStartLocationLoc(whichStartLoc, whichLocation);
        }
        
        public static void SetStartLocPrioCount(JassInteger whichStartLoc, JassInteger prioSlotCount)
        {
            Natives.instance.setStartLocPrioCount(whichStartLoc, prioSlotCount);
        }
        
        public static void SetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority)
        {
            Natives.instance.setStartLocPrio(whichStartLoc, prioSlotIndex, otherStartLocIndex, priority);
        }
        
        public static JassInteger GetStartLocPrioSlot(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return Natives.instance.getStartLocPrioSlot(whichStartLoc, prioSlotIndex);
        }
        
        public static JassStartLocationPriority GetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return Natives.instance.getStartLocPrio(whichStartLoc, prioSlotIndex);
        }
        
        public static void SetGameTypeSupported(JassGameType whichGameType, Boolean value)
        {
            Natives.instance.setGameTypeSupported(whichGameType, value);
        }
        
        public static void SetMapFlag(JassMapFlag whichMapFlag, Boolean value)
        {
            Natives.instance.setMapFlag(whichMapFlag, value);
        }
        
        public static void SetGamePlacement(JassPlacement whichPlacementType)
        {
            Natives.instance.setGamePlacement(whichPlacementType);
        }
        
        public static void SetGameSpeed(JassGameSpeed whichspeed)
        {
            Natives.instance.setGameSpeed(whichspeed);
        }
        
        public static void SetGameDifficulty(JassGameDifficulty whichdifficulty)
        {
            Natives.instance.setGameDifficulty(whichdifficulty);
        }
        
        public static void SetResourceDensity(JassMapDensity whichdensity)
        {
            Natives.instance.setResourceDensity(whichdensity);
        }
        
        public static void SetCreatureDensity(JassMapDensity whichdensity)
        {
            Natives.instance.setCreatureDensity(whichdensity);
        }
        
        public static JassInteger GetTeams()
        {
            return Natives.instance.getTeams();
        }
        
        public static JassInteger GetPlayers()
        {
            return Natives.instance.getPlayers();
        }
        
        public static Boolean IsGameTypeSupported(JassGameType whichGameType)
        {
            return Natives.instance.isGameTypeSupported(whichGameType);
        }
        
        public static JassGameType GetGameTypeSelected()
        {
            return Natives.instance.getGameTypeSelected();
        }
        
        public static Boolean IsMapFlagSet(JassMapFlag whichMapFlag)
        {
            return Natives.instance.isMapFlagSet(whichMapFlag);
        }
        
        public static JassPlacement GetGamePlacement()
        {
            return Natives.instance.getGamePlacement();
        }
        
        public static JassGameSpeed GetGameSpeed()
        {
            return Natives.instance.getGameSpeed();
        }
        
        public static JassGameDifficulty GetGameDifficulty()
        {
            return Natives.instance.getGameDifficulty();
        }
        
        public static JassMapDensity GetResourceDensity()
        {
            return Natives.instance.getResourceDensity();
        }
        
        public static JassMapDensity GetCreatureDensity()
        {
            return Natives.instance.getCreatureDensity();
        }
        
        public static Single GetStartLocationX(JassInteger whichStartLocation)
        {
            return Natives.instance.getStartLocationX(whichStartLocation);
        }
        
        public static Single GetStartLocationY(JassInteger whichStartLocation)
        {
            return Natives.instance.getStartLocationY(whichStartLocation);
        }
        
        public static JassLocation GetStartLocationLoc(JassInteger whichStartLocation)
        {
            return Natives.instance.getStartLocationLoc(whichStartLocation);
        }
        
        public static void SetPlayerTeam(JassPlayer whichPlayer, JassInteger whichTeam)
        {
            Natives.instance.setPlayerTeam(whichPlayer, whichTeam);
        }
        
        public static void SetPlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            Natives.instance.setPlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        public static void ForcePlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            Natives.instance.forcePlayerStartLocation(whichPlayer, startLocIndex);
        }
        
        public static void SetPlayerColor(JassPlayer whichPlayer, JassPlayerColor color)
        {
            Natives.instance.setPlayerColor(whichPlayer, color);
        }
        
        public static void SetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, Boolean value)
        {
            Natives.instance.setPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);
        }
        
        public static void SetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate)
        {
            Natives.instance.setPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);
        }
        
        public static void SetPlayerRacePreference(JassPlayer whichPlayer, JassRacePreference whichRacePreference)
        {
            Natives.instance.setPlayerRacePreference(whichPlayer, whichRacePreference);
        }
        
        public static void SetPlayerRaceSelectable(JassPlayer whichPlayer, Boolean value)
        {
            Natives.instance.setPlayerRaceSelectable(whichPlayer, value);
        }
        
        public static void SetPlayerController(JassPlayer whichPlayer, JassMapControl controlType)
        {
            Natives.instance.setPlayerController(whichPlayer, controlType);
        }
        
        public static void SetPlayerName(JassPlayer whichPlayer, String name)
        {
            Natives.instance.setPlayerName(whichPlayer, name);
        }
        
        public static void SetPlayerOnScoreScreen(JassPlayer whichPlayer, Boolean flag)
        {
            Natives.instance.setPlayerOnScoreScreen(whichPlayer, flag);
        }
        
        public static JassInteger GetPlayerTeam(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerTeam(whichPlayer);
        }
        
        public static JassInteger GetPlayerStartLocation(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerStartLocation(whichPlayer);
        }
        
        public static JassPlayerColor GetPlayerColor(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerColor(whichPlayer);
        }
        
        public static Boolean GetPlayerSelectable(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerSelectable(whichPlayer);
        }
        
        public static JassMapControl GetPlayerController(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerController(whichPlayer);
        }
        
        public static JassPlayerSlotState GetPlayerSlotState(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerSlotState(whichPlayer);
        }
        
        public static JassInteger GetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource)
        {
            return Natives.instance.getPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);
        }
        
        public static Boolean IsPlayerRacePrefSet(JassPlayer whichPlayer, JassRacePreference pref)
        {
            return Natives.instance.isPlayerRacePrefSet(whichPlayer, pref);
        }
        
        public static String GetPlayerName(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerName(whichPlayer);
        }
        
        public static JassTimer CreateTimer()
        {
            return Natives.instance.createTimer();
        }
        
        public static void DestroyTimer(JassTimer whichTimer)
        {
            Natives.instance.destroyTimer(whichTimer);
        }
        
        public static void TimerStart(JassTimer whichTimer, Single timeout, Boolean periodic, JassCode handlerFunc)
        {
            Natives.instance.timerStart(whichTimer, timeout, periodic, handlerFunc);
        }
        
        public static Single TimerGetElapsed(JassTimer whichTimer)
        {
            return Natives.instance.timerGetElapsed(whichTimer);
        }
        
        public static Single TimerGetRemaining(JassTimer whichTimer)
        {
            return Natives.instance.timerGetRemaining(whichTimer);
        }
        
        public static Single TimerGetTimeout(JassTimer whichTimer)
        {
            return Natives.instance.timerGetTimeout(whichTimer);
        }
        
        public static void PauseTimer(JassTimer whichTimer)
        {
            Natives.instance.pauseTimer(whichTimer);
        }
        
        public static void ResumeTimer(JassTimer whichTimer)
        {
            Natives.instance.resumeTimer(whichTimer);
        }
        
        public static JassTimer GetExpiredTimer()
        {
            return Natives.instance.getExpiredTimer();
        }
        
        public static JassGroup CreateGroup()
        {
            return Natives.instance.createGroup();
        }
        
        public static void DestroyGroup(JassGroup whichGroup)
        {
            Natives.instance.destroyGroup(whichGroup);
        }
        
        public static void GroupAddUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            Natives.instance.groupAddUnit(whichGroup, whichUnit);
        }
        
        public static void GroupRemoveUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            Natives.instance.groupRemoveUnit(whichGroup, whichUnit);
        }
        
        public static void GroupClear(JassGroup whichGroup)
        {
            Natives.instance.groupClear(whichGroup);
        }
        
        public static void GroupEnumUnitsOfType(JassGroup whichGroup, String unitname, JassBooleanExpression filter)
        {
            Natives.instance.groupEnumUnitsOfType(whichGroup, unitname, filter);
        }
        
        public static void GroupEnumUnitsOfPlayer(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives.instance.groupEnumUnitsOfPlayer(whichGroup, whichPlayer, filter);
        }
        
        public static void GroupEnumUnitsOfTypeCounted(JassGroup whichGroup, String unitname, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.instance.groupEnumUnitsOfTypeCounted(whichGroup, unitname, filter, countLimit);
        }
        
        public static void GroupEnumUnitsInRect(JassGroup whichGroup, JassRect r, JassBooleanExpression filter)
        {
            Natives.instance.groupEnumUnitsInRect(whichGroup, r, filter);
        }
        
        public static void GroupEnumUnitsInRectCounted(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.instance.groupEnumUnitsInRectCounted(whichGroup, r, filter, countLimit);
        }
        
        public static void GroupEnumUnitsInRange(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter)
        {
            Natives.instance.groupEnumUnitsInRange(whichGroup, x, y, radius, filter);
        }
        
        public static void GroupEnumUnitsInRangeOfLoc(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter)
        {
            Natives.instance.groupEnumUnitsInRangeOfLoc(whichGroup, whichLocation, radius, filter);
        }
        
        public static void GroupEnumUnitsInRangeCounted(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.instance.groupEnumUnitsInRangeCounted(whichGroup, x, y, radius, filter, countLimit);
        }
        
        public static void GroupEnumUnitsInRangeOfLocCounted(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.instance.groupEnumUnitsInRangeOfLocCounted(whichGroup, whichLocation, radius, filter, countLimit);
        }
        
        public static void GroupEnumUnitsSelected(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives.instance.groupEnumUnitsSelected(whichGroup, whichPlayer, filter);
        }
        
        public static Boolean GroupImmediateOrder(JassGroup whichGroup, String order)
        {
            return Natives.instance.groupImmediateOrder(whichGroup, order);
        }
        
        public static Boolean GroupImmediateOrderById(JassGroup whichGroup, JassOrder order)
        {
            return Natives.instance.groupImmediateOrderById(whichGroup, order);
        }
        
        public static Boolean GroupPointOrder(JassGroup whichGroup, String order, Single x, Single y)
        {
            return Natives.instance.groupPointOrder(whichGroup, order, x, y);
        }
        
        public static Boolean GroupPointOrderLoc(JassGroup whichGroup, String order, JassLocation whichLocation)
        {
            return Natives.instance.groupPointOrderLoc(whichGroup, order, whichLocation);
        }
        
        public static Boolean GroupPointOrderById(JassGroup whichGroup, JassOrder order, Single x, Single y)
        {
            return Natives.instance.groupPointOrderById(whichGroup, order, x, y);
        }
        
        public static Boolean GroupPointOrderByIdLoc(JassGroup whichGroup, JassOrder order, JassLocation whichLocation)
        {
            return Natives.instance.groupPointOrderByIdLoc(whichGroup, order, whichLocation);
        }
        
        public static Boolean GroupTargetOrder(JassGroup whichGroup, String order, JassWidget targetWidget)
        {
            return Natives.instance.groupTargetOrder(whichGroup, order, targetWidget);
        }
        
        public static Boolean GroupTargetOrderById(JassGroup whichGroup, JassOrder order, JassWidget targetWidget)
        {
            return Natives.instance.groupTargetOrderById(whichGroup, order, targetWidget);
        }
        
        public static void ForGroup(JassGroup whichGroup, JassCode callback)
        {
            Natives.instance.forGroup(whichGroup, callback);
        }
        
        public static JassUnit FirstOfGroup(JassGroup whichGroup)
        {
            return Natives.instance.firstOfGroup(whichGroup);
        }
        
        public static JassForce CreateForce()
        {
            return Natives.instance.createForce();
        }
        
        public static void DestroyForce(JassForce whichForce)
        {
            Natives.instance.destroyForce(whichForce);
        }
        
        public static void ForceAddPlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            Natives.instance.forceAddPlayer(whichForce, whichPlayer);
        }
        
        public static void ForceRemovePlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            Natives.instance.forceRemovePlayer(whichForce, whichPlayer);
        }
        
        public static void ForceClear(JassForce whichForce)
        {
            Natives.instance.forceClear(whichForce);
        }
        
        public static void ForceEnumPlayers(JassForce whichForce, JassBooleanExpression filter)
        {
            Natives.instance.forceEnumPlayers(whichForce, filter);
        }
        
        public static void ForceEnumPlayersCounted(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.instance.forceEnumPlayersCounted(whichForce, filter, countLimit);
        }
        
        public static void ForceEnumAllies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives.instance.forceEnumAllies(whichForce, whichPlayer, filter);
        }
        
        public static void ForceEnumEnemies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives.instance.forceEnumEnemies(whichForce, whichPlayer, filter);
        }
        
        public static void ForForce(JassForce whichForce, JassCode callback)
        {
            Natives.instance.forForce(whichForce, callback);
        }
        
        public static JassRect Rect(Single minx, Single miny, Single maxx, Single maxy)
        {
            return Natives.instance.rect(minx, miny, maxx, maxy);
        }
        
        public static JassRect RectFromLoc(JassLocation min, JassLocation max)
        {
            return Natives.instance.rectFromLoc(min, max);
        }
        
        public static void RemoveRect(JassRect whichRect)
        {
            Natives.instance.removeRect(whichRect);
        }
        
        public static void SetRect(JassRect whichRect, Single minx, Single miny, Single maxx, Single maxy)
        {
            Natives.instance.setRect(whichRect, minx, miny, maxx, maxy);
        }
        
        public static void SetRectFromLoc(JassRect whichRect, JassLocation min, JassLocation max)
        {
            Natives.instance.setRectFromLoc(whichRect, min, max);
        }
        
        public static void MoveRectTo(JassRect whichRect, Single newCenterX, Single newCenterY)
        {
            Natives.instance.moveRectTo(whichRect, newCenterX, newCenterY);
        }
        
        public static void MoveRectToLoc(JassRect whichRect, JassLocation newCenterLoc)
        {
            Natives.instance.moveRectToLoc(whichRect, newCenterLoc);
        }
        
        public static Single GetRectCenterX(JassRect whichRect)
        {
            return Natives.instance.getRectCenterX(whichRect);
        }
        
        public static Single GetRectCenterY(JassRect whichRect)
        {
            return Natives.instance.getRectCenterY(whichRect);
        }
        
        public static Single GetRectMinX(JassRect whichRect)
        {
            return Natives.instance.getRectMinX(whichRect);
        }
        
        public static Single GetRectMinY(JassRect whichRect)
        {
            return Natives.instance.getRectMinY(whichRect);
        }
        
        public static Single GetRectMaxX(JassRect whichRect)
        {
            return Natives.instance.getRectMaxX(whichRect);
        }
        
        public static Single GetRectMaxY(JassRect whichRect)
        {
            return Natives.instance.getRectMaxY(whichRect);
        }
        
        public static JassRegion CreateRegion()
        {
            return Natives.instance.createRegion();
        }
        
        public static void RemoveRegion(JassRegion whichRegion)
        {
            Natives.instance.removeRegion(whichRegion);
        }
        
        public static void RegionAddRect(JassRegion whichRegion, JassRect r)
        {
            Natives.instance.regionAddRect(whichRegion, r);
        }
        
        public static void RegionClearRect(JassRegion whichRegion, JassRect r)
        {
            Natives.instance.regionClearRect(whichRegion, r);
        }
        
        public static void RegionAddCell(JassRegion whichRegion, Single x, Single y)
        {
            Natives.instance.regionAddCell(whichRegion, x, y);
        }
        
        public static void RegionAddCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            Natives.instance.regionAddCellAtLoc(whichRegion, whichLocation);
        }
        
        public static void RegionClearCell(JassRegion whichRegion, Single x, Single y)
        {
            Natives.instance.regionClearCell(whichRegion, x, y);
        }
        
        public static void RegionClearCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            Natives.instance.regionClearCellAtLoc(whichRegion, whichLocation);
        }
        
        public static JassLocation Location(Single x, Single y)
        {
            return Natives.instance.location(x, y);
        }
        
        public static void RemoveLocation(JassLocation whichLocation)
        {
            Natives.instance.removeLocation(whichLocation);
        }
        
        public static void MoveLocation(JassLocation whichLocation, Single newX, Single newY)
        {
            Natives.instance.moveLocation(whichLocation, newX, newY);
        }
        
        public static Single GetLocationX(JassLocation whichLocation)
        {
            return Natives.instance.getLocationX(whichLocation);
        }
        
        public static Single GetLocationY(JassLocation whichLocation)
        {
            return Natives.instance.getLocationY(whichLocation);
        }
        
        public static Single GetLocationZ(JassLocation whichLocation)
        {
            return Natives.instance.getLocationZ(whichLocation);
        }
        
        public static Boolean IsUnitInRegion(JassRegion whichRegion, JassUnit whichUnit)
        {
            return Natives.instance.isUnitInRegion(whichRegion, whichUnit);
        }
        
        public static Boolean IsPointInRegion(JassRegion whichRegion, Single x, Single y)
        {
            return Natives.instance.isPointInRegion(whichRegion, x, y);
        }
        
        public static Boolean IsLocationInRegion(JassRegion whichRegion, JassLocation whichLocation)
        {
            return Natives.instance.isLocationInRegion(whichRegion, whichLocation);
        }
        
        public static JassRect GetWorldBounds()
        {
            return Natives.instance.getWorldBounds();
        }
        
        public static JassTrigger CreateTrigger()
        {
            return Natives.instance.createTrigger();
        }
        
        public static void DestroyTrigger(JassTrigger whichTrigger)
        {
            Natives.instance.destroyTrigger(whichTrigger);
        }
        
        public static void ResetTrigger(JassTrigger whichTrigger)
        {
            Natives.instance.resetTrigger(whichTrigger);
        }
        
        public static void EnableTrigger(JassTrigger whichTrigger)
        {
            Natives.instance.enableTrigger(whichTrigger);
        }
        
        public static void DisableTrigger(JassTrigger whichTrigger)
        {
            Natives.instance.disableTrigger(whichTrigger);
        }
        
        public static Boolean IsTriggerEnabled(JassTrigger whichTrigger)
        {
            return Natives.instance.isTriggerEnabled(whichTrigger);
        }
        
        public static void TriggerWaitOnSleeps(JassTrigger whichTrigger, Boolean flag)
        {
            Natives.instance.triggerWaitOnSleeps(whichTrigger, flag);
        }
        
        public static Boolean IsTriggerWaitOnSleeps(JassTrigger whichTrigger)
        {
            return Natives.instance.isTriggerWaitOnSleeps(whichTrigger);
        }
        
        public static JassUnit GetFilterUnit()
        {
            return Natives.instance.getFilterUnit();
        }
        
        public static JassUnit GetEnumUnit()
        {
            return Natives.instance.getEnumUnit();
        }
        
        public static JassDestructable GetFilterDestructable()
        {
            return Natives.instance.getFilterDestructable();
        }
        
        public static JassDestructable GetEnumDestructable()
        {
            return Natives.instance.getEnumDestructable();
        }
        
        public static JassItem GetFilterItem()
        {
            return Natives.instance.getFilterItem();
        }
        
        public static JassItem GetEnumItem()
        {
            return Natives.instance.getEnumItem();
        }
        
        public static JassPlayer GetFilterPlayer()
        {
            return Natives.instance.getFilterPlayer();
        }
        
        public static JassPlayer GetEnumPlayer()
        {
            return Natives.instance.getEnumPlayer();
        }
        
        public static JassTrigger GetTriggeringTrigger()
        {
            return Natives.instance.getTriggeringTrigger();
        }
        
        public static JassEventIndex GetTriggerEventId()
        {
            return Natives.instance.getTriggerEventId();
        }
        
        public static JassInteger GetTriggerEvalCount(JassTrigger whichTrigger)
        {
            return Natives.instance.getTriggerEvalCount(whichTrigger);
        }
        
        public static JassInteger GetTriggerExecCount(JassTrigger whichTrigger)
        {
            return Natives.instance.getTriggerExecCount(whichTrigger);
        }
        
        public static void ExecuteFunc(String funcName)
        {
            Natives.instance.executeFunc(funcName);
        }
        
        public static JassBooleanExpression And(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return Natives.instance.and(operandA, operandB);
        }
        
        public static JassBooleanExpression Or(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return Natives.instance.or(operandA, operandB);
        }
        
        public static JassBooleanExpression Not(JassBooleanExpression operand)
        {
            return Natives.instance.not(operand);
        }
        
        public static JassConditionFunction Condition(JassCode func)
        {
            return Natives.instance.condition(func);
        }
        
        public static void DestroyCondition(JassConditionFunction c)
        {
            Natives.instance.destroyCondition(c);
        }
        
        public static JassFilterFunction Filter(JassCode func)
        {
            return Natives.instance.filter(func);
        }
        
        public static void DestroyFilter(JassFilterFunction f)
        {
            Natives.instance.destroyFilter(f);
        }
        
        public static void DestroyBoolExpr(JassBooleanExpression e)
        {
            Natives.instance.destroyBoolExpr(e);
        }
        
        public static JassEvent TriggerRegisterVariableEvent(JassTrigger whichTrigger, String varName, JassLimitOp opcode, Single limitval)
        {
            return Natives.instance.triggerRegisterVariableEvent(whichTrigger, varName, opcode, limitval);
        }
        
        public static JassEvent TriggerRegisterTimerEvent(JassTrigger whichTrigger, Single timeout, Boolean periodic)
        {
            return Natives.instance.triggerRegisterTimerEvent(whichTrigger, timeout, periodic);
        }
        
        public static JassEvent TriggerRegisterTimerExpireEvent(JassTrigger whichTrigger, JassTimer t)
        {
            return Natives.instance.triggerRegisterTimerExpireEvent(whichTrigger, t);
        }
        
        public static JassEvent TriggerRegisterGameStateEvent(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives.instance.triggerRegisterGameStateEvent(whichTrigger, whichState, opcode, limitval);
        }
        
        public static JassEvent TriggerRegisterDialogEvent(JassTrigger whichTrigger, JassDialog whichDialog)
        {
            return Natives.instance.triggerRegisterDialogEvent(whichTrigger, whichDialog);
        }
        
        public static JassEvent TriggerRegisterDialogButtonEvent(JassTrigger whichTrigger, JassButton whichButton)
        {
            return Natives.instance.triggerRegisterDialogButtonEvent(whichTrigger, whichButton);
        }
        
        public static JassGameState GetEventGameState()
        {
            return Natives.instance.getEventGameState();
        }
        
        public static JassEvent TriggerRegisterGameEvent(JassTrigger whichTrigger, JassGameEvent whichGameEvent)
        {
            return Natives.instance.triggerRegisterGameEvent(whichTrigger, whichGameEvent);
        }
        
        public static JassPlayer GetWinningPlayer()
        {
            return Natives.instance.getWinningPlayer();
        }
        
        public static JassEvent TriggerRegisterEnterRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return Natives.instance.triggerRegisterEnterRegion(whichTrigger, whichRegion, filter);
        }
        
        public static JassRegion GetTriggeringRegion()
        {
            return Natives.instance.getTriggeringRegion();
        }
        
        public static JassUnit GetEnteringUnit()
        {
            return Natives.instance.getEnteringUnit();
        }
        
        public static JassEvent TriggerRegisterLeaveRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return Natives.instance.triggerRegisterLeaveRegion(whichTrigger, whichRegion, filter);
        }
        
        public static JassUnit GetLeavingUnit()
        {
            return Natives.instance.getLeavingUnit();
        }
        
        public static JassEvent TriggerRegisterTrackableHitEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return Natives.instance.triggerRegisterTrackableHitEvent(whichTrigger, t);
        }
        
        public static JassEvent TriggerRegisterTrackableTrackEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return Natives.instance.triggerRegisterTrackableTrackEvent(whichTrigger, t);
        }
        
        public static JassTrackable GetTriggeringTrackable()
        {
            return Natives.instance.getTriggeringTrackable();
        }
        
        public static JassButton GetClickedButton()
        {
            return Natives.instance.getClickedButton();
        }
        
        public static JassDialog GetClickedDialog()
        {
            return Natives.instance.getClickedDialog();
        }
        
        public static Single GetTournamentFinishSoonTimeRemaining()
        {
            return Natives.instance.getTournamentFinishSoonTimeRemaining();
        }
        
        public static JassInteger GetTournamentFinishNowRule()
        {
            return Natives.instance.getTournamentFinishNowRule();
        }
        
        public static JassPlayer GetTournamentFinishNowPlayer()
        {
            return Natives.instance.getTournamentFinishNowPlayer();
        }
        
        public static JassInteger GetTournamentScore(JassPlayer whichPlayer)
        {
            return Natives.instance.getTournamentScore(whichPlayer);
        }
        
        public static String GetSaveBasicFilename()
        {
            return Natives.instance.getSaveBasicFilename();
        }
        
        public static JassEvent TriggerRegisterPlayerEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent)
        {
            return Natives.instance.triggerRegisterPlayerEvent(whichTrigger, whichPlayer, whichPlayerEvent);
        }
        
        public static JassPlayer GetTriggerPlayer()
        {
            return Natives.instance.getTriggerPlayer();
        }
        
        public static JassEvent TriggerRegisterPlayerUnitEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter)
        {
            return Natives.instance.triggerRegisterPlayerUnitEvent(whichTrigger, whichPlayer, whichPlayerUnitEvent, filter);
        }
        
        public static JassUnit GetLevelingUnit()
        {
            return Natives.instance.getLevelingUnit();
        }
        
        public static JassUnit GetLearningUnit()
        {
            return Natives.instance.getLearningUnit();
        }
        
        public static JassInteger GetLearnedSkill()
        {
            return Natives.instance.getLearnedSkill();
        }
        
        public static JassInteger GetLearnedSkillLevel()
        {
            return Natives.instance.getLearnedSkillLevel();
        }
        
        public static JassUnit GetRevivableUnit()
        {
            return Natives.instance.getRevivableUnit();
        }
        
        public static JassUnit GetRevivingUnit()
        {
            return Natives.instance.getRevivingUnit();
        }
        
        public static JassUnit GetAttacker()
        {
            return Natives.instance.getAttacker();
        }
        
        public static JassUnit GetRescuer()
        {
            return Natives.instance.getRescuer();
        }
        
        public static JassUnit GetDyingUnit()
        {
            return Natives.instance.getDyingUnit();
        }
        
        public static JassUnit GetKillingUnit()
        {
            return Natives.instance.getKillingUnit();
        }
        
        public static JassUnit GetDecayingUnit()
        {
            return Natives.instance.getDecayingUnit();
        }
        
        public static JassUnit GetConstructingStructure()
        {
            return Natives.instance.getConstructingStructure();
        }
        
        public static JassUnit GetCancelledStructure()
        {
            return Natives.instance.getCancelledStructure();
        }
        
        public static JassUnit GetConstructedStructure()
        {
            return Natives.instance.getConstructedStructure();
        }
        
        public static JassUnit GetResearchingUnit()
        {
            return Natives.instance.getResearchingUnit();
        }
        
        public static JassInteger GetResearched()
        {
            return Natives.instance.getResearched();
        }
        
        public static JassInteger GetTrainedUnitType()
        {
            return Natives.instance.getTrainedUnitType();
        }
        
        public static JassUnit GetTrainedUnit()
        {
            return Natives.instance.getTrainedUnit();
        }
        
        public static JassUnit GetDetectedUnit()
        {
            return Natives.instance.getDetectedUnit();
        }
        
        public static JassUnit GetSummoningUnit()
        {
            return Natives.instance.getSummoningUnit();
        }
        
        public static JassUnit GetSummonedUnit()
        {
            return Natives.instance.getSummonedUnit();
        }
        
        public static JassUnit GetTransportUnit()
        {
            return Natives.instance.getTransportUnit();
        }
        
        public static JassUnit GetLoadedUnit()
        {
            return Natives.instance.getLoadedUnit();
        }
        
        public static JassUnit GetSellingUnit()
        {
            return Natives.instance.getSellingUnit();
        }
        
        public static JassUnit GetSoldUnit()
        {
            return Natives.instance.getSoldUnit();
        }
        
        public static JassUnit GetBuyingUnit()
        {
            return Natives.instance.getBuyingUnit();
        }
        
        public static JassItem GetSoldItem()
        {
            return Natives.instance.getSoldItem();
        }
        
        public static JassUnit GetChangingUnit()
        {
            return Natives.instance.getChangingUnit();
        }
        
        public static JassPlayer GetChangingUnitPrevOwner()
        {
            return Natives.instance.getChangingUnitPrevOwner();
        }
        
        public static JassUnit GetManipulatingUnit()
        {
            return Natives.instance.getManipulatingUnit();
        }
        
        public static JassItem GetManipulatedItem()
        {
            return Natives.instance.getManipulatedItem();
        }
        
        public static JassUnit GetOrderedUnit()
        {
            return Natives.instance.getOrderedUnit();
        }
        
        public static JassOrder GetIssuedOrderId()
        {
            return Natives.instance.getIssuedOrderId();
        }
        
        public static Single GetOrderPointX()
        {
            return Natives.instance.getOrderPointX();
        }
        
        public static Single GetOrderPointY()
        {
            return Natives.instance.getOrderPointY();
        }
        
        public static JassLocation GetOrderPointLoc()
        {
            return Natives.instance.getOrderPointLoc();
        }
        
        public static JassWidget GetOrderTarget()
        {
            return Natives.instance.getOrderTarget();
        }
        
        public static JassDestructable GetOrderTargetDestructable()
        {
            return Natives.instance.getOrderTargetDestructable();
        }
        
        public static JassItem GetOrderTargetItem()
        {
            return Natives.instance.getOrderTargetItem();
        }
        
        public static JassUnit GetOrderTargetUnit()
        {
            return Natives.instance.getOrderTargetUnit();
        }
        
        public static JassUnit GetSpellAbilityUnit()
        {
            return Natives.instance.getSpellAbilityUnit();
        }
        
        public static JassObjectId GetSpellAbilityId()
        {
            return Natives.instance.getSpellAbilityId();
        }
        
        public static JassAbility GetSpellAbility()
        {
            return Natives.instance.getSpellAbility();
        }
        
        public static JassLocation GetSpellTargetLoc()
        {
            return Natives.instance.getSpellTargetLoc();
        }
        
        public static Single GetSpellTargetX()
        {
            return Natives.instance.getSpellTargetX();
        }
        
        public static Single GetSpellTargetY()
        {
            return Natives.instance.getSpellTargetY();
        }
        
        public static JassDestructable GetSpellTargetDestructable()
        {
            return Natives.instance.getSpellTargetDestructable();
        }
        
        public static JassItem GetSpellTargetItem()
        {
            return Natives.instance.getSpellTargetItem();
        }
        
        public static JassUnit GetSpellTargetUnit()
        {
            return Natives.instance.getSpellTargetUnit();
        }
        
        public static JassEvent TriggerRegisterPlayerAllianceChange(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance)
        {
            return Natives.instance.triggerRegisterPlayerAllianceChange(whichTrigger, whichPlayer, whichAlliance);
        }
        
        public static JassEvent TriggerRegisterPlayerStateEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives.instance.triggerRegisterPlayerStateEvent(whichTrigger, whichPlayer, whichState, opcode, limitval);
        }
        
        public static JassPlayerState GetEventPlayerState()
        {
            return Natives.instance.getEventPlayerState();
        }
        
        public static JassEvent TriggerRegisterPlayerChatEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, String chatMessageToDetect, Boolean exactMatchOnly)
        {
            return Natives.instance.triggerRegisterPlayerChatEvent(whichTrigger, whichPlayer, chatMessageToDetect, exactMatchOnly);
        }
        
        public static String GetEventPlayerChatString()
        {
            return Natives.instance.getEventPlayerChatString();
        }
        
        public static String GetEventPlayerChatStringMatched()
        {
            return Natives.instance.getEventPlayerChatStringMatched();
        }
        
        public static JassEvent TriggerRegisterDeathEvent(JassTrigger whichTrigger, JassWidget whichWidget)
        {
            return Natives.instance.triggerRegisterDeathEvent(whichTrigger, whichWidget);
        }
        
        public static JassUnit GetTriggerUnit()
        {
            return Natives.instance.getTriggerUnit();
        }
        
        public static JassEvent TriggerRegisterUnitStateEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives.instance.triggerRegisterUnitStateEvent(whichTrigger, whichUnit, whichState, opcode, limitval);
        }
        
        public static JassUnitState GetEventUnitState()
        {
            return Natives.instance.getEventUnitState();
        }
        
        public static JassEvent TriggerRegisterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent)
        {
            return Natives.instance.triggerRegisterUnitEvent(whichTrigger, whichUnit, whichEvent);
        }
        
        public static Single GetEventDamage()
        {
            return Natives.instance.getEventDamage();
        }
        
        public static JassUnit GetEventDamageSource()
        {
            return Natives.instance.getEventDamageSource();
        }
        
        public static JassPlayer GetEventDetectingPlayer()
        {
            return Natives.instance.getEventDetectingPlayer();
        }
        
        public static JassEvent TriggerRegisterFilterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter)
        {
            return Natives.instance.triggerRegisterFilterUnitEvent(whichTrigger, whichUnit, whichEvent, filter);
        }
        
        public static JassUnit GetEventTargetUnit()
        {
            return Natives.instance.getEventTargetUnit();
        }
        
        public static JassEvent TriggerRegisterUnitInRange(JassTrigger whichTrigger, JassUnit whichUnit, Single range, JassBooleanExpression filter)
        {
            return Natives.instance.triggerRegisterUnitInRange(whichTrigger, whichUnit, range, filter);
        }
        
        public static JassTriggerCondition TriggerAddCondition(JassTrigger whichTrigger, JassBooleanExpression condition)
        {
            return Natives.instance.triggerAddCondition(whichTrigger, condition);
        }
        
        public static void TriggerRemoveCondition(JassTrigger whichTrigger, JassTriggerCondition whichCondition)
        {
            Natives.instance.triggerRemoveCondition(whichTrigger, whichCondition);
        }
        
        public static void TriggerClearConditions(JassTrigger whichTrigger)
        {
            Natives.instance.triggerClearConditions(whichTrigger);
        }
        
        public static JassTriggerAction TriggerAddAction(JassTrigger whichTrigger, JassCode actionFunc)
        {
            return Natives.instance.triggerAddAction(whichTrigger, actionFunc);
        }
        
        public static void TriggerRemoveAction(JassTrigger whichTrigger, JassTriggerAction whichAction)
        {
            Natives.instance.triggerRemoveAction(whichTrigger, whichAction);
        }
        
        public static void TriggerClearActions(JassTrigger whichTrigger)
        {
            Natives.instance.triggerClearActions(whichTrigger);
        }
        
        public static void TriggerSleepAction(Single timeout)
        {
            Natives.instance.triggerSleepAction(timeout);
        }
        
        public static void TriggerWaitForSound(JassSound s, Single offset)
        {
            Natives.instance.triggerWaitForSound(s, offset);
        }
        
        public static Boolean TriggerEvaluate(JassTrigger whichTrigger)
        {
            return Natives.instance.triggerEvaluate(whichTrigger);
        }
        
        public static void TriggerExecute(JassTrigger whichTrigger)
        {
            Natives.instance.triggerExecute(whichTrigger);
        }
        
        public static void TriggerExecuteWait(JassTrigger whichTrigger)
        {
            Natives.instance.triggerExecuteWait(whichTrigger);
        }
        
        public static void TriggerSyncStart()
        {
            Natives.instance.triggerSyncStart();
        }
        
        public static void TriggerSyncReady()
        {
            Natives.instance.triggerSyncReady();
        }
        
        public static Single GetWidgetLife(JassWidget whichWidget)
        {
            return Natives.instance.getWidgetLife(whichWidget);
        }
        
        public static void SetWidgetLife(JassWidget whichWidget, Single newLife)
        {
            Natives.instance.setWidgetLife(whichWidget, newLife);
        }
        
        public static Single GetWidgetX(JassWidget whichWidget)
        {
            return Natives.instance.getWidgetX(whichWidget);
        }
        
        public static Single GetWidgetY(JassWidget whichWidget)
        {
            return Natives.instance.getWidgetY(whichWidget);
        }
        
        public static JassWidget GetTriggerWidget()
        {
            return Natives.instance.getTriggerWidget();
        }
        
        public static JassDestructable CreateDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return Natives.instance.createDestructable(objectid, x, y, face, scale, variation);
        }
        
        public static JassDestructable CreateDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return Natives.instance.createDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        public static JassDestructable CreateDeadDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return Natives.instance.createDeadDestructable(objectid, x, y, face, scale, variation);
        }
        
        public static JassDestructable CreateDeadDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return Natives.instance.createDeadDestructableZ(objectid, x, y, z, face, scale, variation);
        }
        
        public static void RemoveDestructable(JassDestructable d)
        {
            Natives.instance.removeDestructable(d);
        }
        
        public static void KillDestructable(JassDestructable d)
        {
            Natives.instance.killDestructable(d);
        }
        
        public static void SetDestructableInvulnerable(JassDestructable d, Boolean flag)
        {
            Natives.instance.setDestructableInvulnerable(d, flag);
        }
        
        public static Boolean IsDestructableInvulnerable(JassDestructable d)
        {
            return Natives.instance.isDestructableInvulnerable(d);
        }
        
        public static void EnumDestructablesInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            Natives.instance.enumDestructablesInRect(r, filter, actionFunc);
        }
        
        public static JassObjectId GetDestructableTypeId(JassDestructable d)
        {
            return Natives.instance.getDestructableTypeId(d);
        }
        
        public static Single GetDestructableX(JassDestructable d)
        {
            return Natives.instance.getDestructableX(d);
        }
        
        public static Single GetDestructableY(JassDestructable d)
        {
            return Natives.instance.getDestructableY(d);
        }
        
        public static void SetDestructableLife(JassDestructable d, Single life)
        {
            Natives.instance.setDestructableLife(d, life);
        }
        
        public static Single GetDestructableLife(JassDestructable d)
        {
            return Natives.instance.getDestructableLife(d);
        }
        
        public static void SetDestructableMaxLife(JassDestructable d, Single max)
        {
            Natives.instance.setDestructableMaxLife(d, max);
        }
        
        public static Single GetDestructableMaxLife(JassDestructable d)
        {
            return Natives.instance.getDestructableMaxLife(d);
        }
        
        public static void DestructableRestoreLife(JassDestructable d, Single life, Boolean birth)
        {
            Natives.instance.destructableRestoreLife(d, life, birth);
        }
        
        public static void QueueDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            Natives.instance.queueDestructableAnimation(d, whichAnimation);
        }
        
        public static void SetDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            Natives.instance.setDestructableAnimation(d, whichAnimation);
        }
        
        public static void SetDestructableAnimationSpeed(JassDestructable d, Single speedFactor)
        {
            Natives.instance.setDestructableAnimationSpeed(d, speedFactor);
        }
        
        public static void ShowDestructable(JassDestructable d, Boolean flag)
        {
            Natives.instance.showDestructable(d, flag);
        }
        
        public static Single GetDestructableOccluderHeight(JassDestructable d)
        {
            return Natives.instance.getDestructableOccluderHeight(d);
        }
        
        public static void SetDestructableOccluderHeight(JassDestructable d, Single height)
        {
            Natives.instance.setDestructableOccluderHeight(d, height);
        }
        
        public static String GetDestructableName(JassDestructable d)
        {
            return Natives.instance.getDestructableName(d);
        }
        
        public static JassDestructable GetTriggerDestructable()
        {
            return Natives.instance.getTriggerDestructable();
        }
        
        public static JassItem CreateItem(JassObjectId itemid, Single x, Single y)
        {
            return Natives.instance.createItem(itemid, x, y);
        }
        
        public static void RemoveItem(JassItem whichItem)
        {
            Natives.instance.removeItem(whichItem);
        }
        
        public static JassPlayer GetItemPlayer(JassItem whichItem)
        {
            return Natives.instance.getItemPlayer(whichItem);
        }
        
        public static JassObjectId GetItemTypeId(JassItem i)
        {
            return Natives.instance.getItemTypeId(i);
        }
        
        public static Single GetItemX(JassItem i)
        {
            return Natives.instance.getItemX(i);
        }
        
        public static Single GetItemY(JassItem i)
        {
            return Natives.instance.getItemY(i);
        }
        
        public static void SetItemPosition(JassItem i, Single x, Single y)
        {
            Natives.instance.setItemPosition(i, x, y);
        }
        
        public static void SetItemDropOnDeath(JassItem whichItem, Boolean flag)
        {
            Natives.instance.setItemDropOnDeath(whichItem, flag);
        }
        
        public static void SetItemDroppable(JassItem i, Boolean flag)
        {
            Natives.instance.setItemDroppable(i, flag);
        }
        
        public static void SetItemPawnable(JassItem i, Boolean flag)
        {
            Natives.instance.setItemPawnable(i, flag);
        }
        
        public static void SetItemPlayer(JassItem whichItem, JassPlayer whichPlayer, Boolean changeColor)
        {
            Natives.instance.setItemPlayer(whichItem, whichPlayer, changeColor);
        }
        
        public static void SetItemInvulnerable(JassItem whichItem, Boolean flag)
        {
            Natives.instance.setItemInvulnerable(whichItem, flag);
        }
        
        public static Boolean IsItemInvulnerable(JassItem whichItem)
        {
            return Natives.instance.isItemInvulnerable(whichItem);
        }
        
        public static void SetItemVisible(JassItem whichItem, Boolean show)
        {
            Natives.instance.setItemVisible(whichItem, show);
        }
        
        public static Boolean IsItemVisible(JassItem whichItem)
        {
            return Natives.instance.isItemVisible(whichItem);
        }
        
        public static Boolean IsItemOwned(JassItem whichItem)
        {
            return Natives.instance.isItemOwned(whichItem);
        }
        
        public static Boolean IsItemPowerup(JassItem whichItem)
        {
            return Natives.instance.isItemPowerup(whichItem);
        }
        
        public static Boolean IsItemSellable(JassItem whichItem)
        {
            return Natives.instance.isItemSellable(whichItem);
        }
        
        public static Boolean IsItemPawnable(JassItem whichItem)
        {
            return Natives.instance.isItemPawnable(whichItem);
        }
        
        public static Boolean IsItemIdPowerup(JassObjectId itemId)
        {
            return Natives.instance.isItemIdPowerup(itemId);
        }
        
        public static Boolean IsItemIdSellable(JassObjectId itemId)
        {
            return Natives.instance.isItemIdSellable(itemId);
        }
        
        public static Boolean IsItemIdPawnable(JassObjectId itemId)
        {
            return Natives.instance.isItemIdPawnable(itemId);
        }
        
        public static void EnumItemsInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            Natives.instance.enumItemsInRect(r, filter, actionFunc);
        }
        
        public static JassInteger GetItemLevel(JassItem whichItem)
        {
            return Natives.instance.getItemLevel(whichItem);
        }
        
        public static JassItemType GetItemType(JassItem whichItem)
        {
            return Natives.instance.getItemType(whichItem);
        }
        
        public static void SetItemDropID(JassItem whichItem, JassObjectId unitId)
        {
            Natives.instance.setItemDropID(whichItem, unitId);
        }
        
        public static String GetItemName(JassItem whichItem)
        {
            return Natives.instance.getItemName(whichItem);
        }
        
        public static JassInteger GetItemCharges(JassItem whichItem)
        {
            return Natives.instance.getItemCharges(whichItem);
        }
        
        public static void SetItemCharges(JassItem whichItem, JassInteger charges)
        {
            Natives.instance.setItemCharges(whichItem, charges);
        }
        
        public static JassInteger GetItemUserData(JassItem whichItem)
        {
            return Natives.instance.getItemUserData(whichItem);
        }
        
        public static void SetItemUserData(JassItem whichItem, JassInteger data)
        {
            Natives.instance.setItemUserData(whichItem, data);
        }
        
        public static JassUnit CreateUnit(JassPlayer id, JassObjectId unitid, Single x, Single y, Single face)
        {
            return Natives.instance.createUnit(id, unitid, x, y, face);
        }
        
        public static JassUnit CreateUnitByName(JassPlayer whichPlayer, String unitname, Single x, Single y, Single face)
        {
            return Natives.instance.createUnitByName(whichPlayer, unitname, x, y, face);
        }
        
        public static JassUnit CreateUnitAtLoc(JassPlayer id, JassObjectId unitid, JassLocation whichLocation, Single face)
        {
            return Natives.instance.createUnitAtLoc(id, unitid, whichLocation, face);
        }
        
        public static JassUnit CreateUnitAtLocByName(JassPlayer id, String unitname, JassLocation whichLocation, Single face)
        {
            return Natives.instance.createUnitAtLocByName(id, unitname, whichLocation, face);
        }
        
        public static JassUnit CreateCorpse(JassPlayer whichPlayer, JassObjectId unitid, Single x, Single y, Single face)
        {
            return Natives.instance.createCorpse(whichPlayer, unitid, x, y, face);
        }
        
        public static void KillUnit(JassUnit whichUnit)
        {
            Natives.instance.killUnit(whichUnit);
        }
        
        public static void RemoveUnit(JassUnit whichUnit)
        {
            Natives.instance.removeUnit(whichUnit);
        }
        
        public static void ShowUnit(JassUnit whichUnit, Boolean show)
        {
            Natives.instance.showUnit(whichUnit, show);
        }
        
        public static void SetUnitState(JassUnit whichUnit, JassUnitState whichUnitState, Single newVal)
        {
            Natives.instance.setUnitState(whichUnit, whichUnitState, newVal);
        }
        
        public static void SetUnitX(JassUnit whichUnit, Single newX)
        {
            Natives.instance.setUnitX(whichUnit, newX);
        }
        
        public static void SetUnitY(JassUnit whichUnit, Single newY)
        {
            Natives.instance.setUnitY(whichUnit, newY);
        }
        
        public static void SetUnitPosition(JassUnit whichUnit, Single newX, Single newY)
        {
            Natives.instance.setUnitPosition(whichUnit, newX, newY);
        }
        
        public static void SetUnitPositionLoc(JassUnit whichUnit, JassLocation whichLocation)
        {
            Natives.instance.setUnitPositionLoc(whichUnit, whichLocation);
        }
        
        public static void SetUnitFacing(JassUnit whichUnit, Single facingAngle)
        {
            Natives.instance.setUnitFacing(whichUnit, facingAngle);
        }
        
        public static void SetUnitFacingTimed(JassUnit whichUnit, Single facingAngle, Single duration)
        {
            Natives.instance.setUnitFacingTimed(whichUnit, facingAngle, duration);
        }
        
        public static void SetUnitMoveSpeed(JassUnit whichUnit, Single newSpeed)
        {
            Natives.instance.setUnitMoveSpeed(whichUnit, newSpeed);
        }
        
        public static void SetUnitFlyHeight(JassUnit whichUnit, Single newHeight, Single rate)
        {
            Natives.instance.setUnitFlyHeight(whichUnit, newHeight, rate);
        }
        
        public static void SetUnitTurnSpeed(JassUnit whichUnit, Single newTurnSpeed)
        {
            Natives.instance.setUnitTurnSpeed(whichUnit, newTurnSpeed);
        }
        
        public static void SetUnitPropWindow(JassUnit whichUnit, Single newPropWindowAngle)
        {
            Natives.instance.setUnitPropWindow(whichUnit, newPropWindowAngle);
        }
        
        public static void SetUnitAcquireRange(JassUnit whichUnit, Single newAcquireRange)
        {
            Natives.instance.setUnitAcquireRange(whichUnit, newAcquireRange);
        }
        
        public static void SetUnitCreepGuard(JassUnit whichUnit, Boolean creepGuard)
        {
            Natives.instance.setUnitCreepGuard(whichUnit, creepGuard);
        }
        
        public static Single GetUnitAcquireRange(JassUnit whichUnit)
        {
            return Natives.instance.getUnitAcquireRange(whichUnit);
        }
        
        public static Single GetUnitTurnSpeed(JassUnit whichUnit)
        {
            return Natives.instance.getUnitTurnSpeed(whichUnit);
        }
        
        public static Single GetUnitPropWindow(JassUnit whichUnit)
        {
            return Natives.instance.getUnitPropWindow(whichUnit);
        }
        
        public static Single GetUnitFlyHeight(JassUnit whichUnit)
        {
            return Natives.instance.getUnitFlyHeight(whichUnit);
        }
        
        public static Single GetUnitDefaultAcquireRange(JassUnit whichUnit)
        {
            return Natives.instance.getUnitDefaultAcquireRange(whichUnit);
        }
        
        public static Single GetUnitDefaultTurnSpeed(JassUnit whichUnit)
        {
            return Natives.instance.getUnitDefaultTurnSpeed(whichUnit);
        }
        
        public static Single GetUnitDefaultPropWindow(JassUnit whichUnit)
        {
            return Natives.instance.getUnitDefaultPropWindow(whichUnit);
        }
        
        public static Single GetUnitDefaultFlyHeight(JassUnit whichUnit)
        {
            return Natives.instance.getUnitDefaultFlyHeight(whichUnit);
        }
        
        public static void SetUnitOwner(JassUnit whichUnit, JassPlayer whichPlayer, Boolean changeColor)
        {
            Natives.instance.setUnitOwner(whichUnit, whichPlayer, changeColor);
        }
        
        public static void SetUnitColor(JassUnit whichUnit, JassPlayerColor whichColor)
        {
            Natives.instance.setUnitColor(whichUnit, whichColor);
        }
        
        public static void SetUnitScale(JassUnit whichUnit, Single scaleX, Single scaleY, Single scaleZ)
        {
            Natives.instance.setUnitScale(whichUnit, scaleX, scaleY, scaleZ);
        }
        
        public static void SetUnitTimeScale(JassUnit whichUnit, Single timeScale)
        {
            Natives.instance.setUnitTimeScale(whichUnit, timeScale);
        }
        
        public static void SetUnitBlendTime(JassUnit whichUnit, Single blendTime)
        {
            Natives.instance.setUnitBlendTime(whichUnit, blendTime);
        }
        
        public static void SetUnitVertexColor(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.setUnitVertexColor(whichUnit, red, green, blue, alpha);
        }
        
        public static void QueueUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            Natives.instance.queueUnitAnimation(whichUnit, whichAnimation);
        }
        
        public static void SetUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            Natives.instance.setUnitAnimation(whichUnit, whichAnimation);
        }
        
        public static void SetUnitAnimationByIndex(JassUnit whichUnit, JassInteger whichAnimation)
        {
            Natives.instance.setUnitAnimationByIndex(whichUnit, whichAnimation);
        }
        
        public static void SetUnitAnimationWithRarity(JassUnit whichUnit, String whichAnimation, JassRarityControl rarity)
        {
            Natives.instance.setUnitAnimationWithRarity(whichUnit, whichAnimation, rarity);
        }
        
        public static void AddUnitAnimationProperties(JassUnit whichUnit, String animProperties, Boolean add)
        {
            Natives.instance.addUnitAnimationProperties(whichUnit, animProperties, add);
        }
        
        public static void SetUnitLookAt(JassUnit whichUnit, String whichBone, JassUnit lookAtTarget, Single offsetX, Single offsetY, Single offsetZ)
        {
            Natives.instance.setUnitLookAt(whichUnit, whichBone, lookAtTarget, offsetX, offsetY, offsetZ);
        }
        
        public static void ResetUnitLookAt(JassUnit whichUnit)
        {
            Natives.instance.resetUnitLookAt(whichUnit);
        }
        
        public static void SetUnitRescuable(JassUnit whichUnit, JassPlayer byWhichPlayer, Boolean flag)
        {
            Natives.instance.setUnitRescuable(whichUnit, byWhichPlayer, flag);
        }
        
        public static void SetUnitRescueRange(JassUnit whichUnit, Single range)
        {
            Natives.instance.setUnitRescueRange(whichUnit, range);
        }
        
        public static void SetHeroStr(JassUnit whichHero, JassInteger newStr, Boolean permanent)
        {
            Natives.instance.setHeroStr(whichHero, newStr, permanent);
        }
        
        public static void SetHeroAgi(JassUnit whichHero, JassInteger newAgi, Boolean permanent)
        {
            Natives.instance.setHeroAgi(whichHero, newAgi, permanent);
        }
        
        public static void SetHeroInt(JassUnit whichHero, JassInteger newInt, Boolean permanent)
        {
            Natives.instance.setHeroInt(whichHero, newInt, permanent);
        }
        
        public static JassInteger GetHeroStr(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives.instance.getHeroStr(whichHero, includeBonuses);
        }
        
        public static JassInteger GetHeroAgi(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives.instance.getHeroAgi(whichHero, includeBonuses);
        }
        
        public static JassInteger GetHeroInt(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives.instance.getHeroInt(whichHero, includeBonuses);
        }
        
        public static Boolean UnitStripHeroLevel(JassUnit whichHero, JassInteger howManyLevels)
        {
            return Natives.instance.unitStripHeroLevel(whichHero, howManyLevels);
        }
        
        public static JassInteger GetHeroXP(JassUnit whichHero)
        {
            return Natives.instance.getHeroXP(whichHero);
        }
        
        public static void SetHeroXP(JassUnit whichHero, JassInteger newXpVal, Boolean showEyeCandy)
        {
            Natives.instance.setHeroXP(whichHero, newXpVal, showEyeCandy);
        }
        
        public static JassInteger GetHeroSkillPoints(JassUnit whichHero)
        {
            return Natives.instance.getHeroSkillPoints(whichHero);
        }
        
        public static Boolean UnitModifySkillPoints(JassUnit whichHero, JassInteger skillPointDelta)
        {
            return Natives.instance.unitModifySkillPoints(whichHero, skillPointDelta);
        }
        
        public static void AddHeroXP(JassUnit whichHero, JassInteger xpToAdd, Boolean showEyeCandy)
        {
            Natives.instance.addHeroXP(whichHero, xpToAdd, showEyeCandy);
        }
        
        public static void SetHeroLevel(JassUnit whichHero, JassInteger level, Boolean showEyeCandy)
        {
            Natives.instance.setHeroLevel(whichHero, level, showEyeCandy);
        }
        
        public static JassInteger GetHeroLevel(JassUnit whichHero)
        {
            return Natives.instance.getHeroLevel(whichHero);
        }
        
        public static JassInteger GetUnitLevel(JassUnit whichUnit)
        {
            return Natives.instance.getUnitLevel(whichUnit);
        }
        
        public static String GetHeroProperName(JassUnit whichHero)
        {
            return Natives.instance.getHeroProperName(whichHero);
        }
        
        public static void SuspendHeroXP(JassUnit whichHero, Boolean flag)
        {
            Natives.instance.suspendHeroXP(whichHero, flag);
        }
        
        public static Boolean IsSuspendedXP(JassUnit whichHero)
        {
            return Natives.instance.isSuspendedXP(whichHero);
        }
        
        public static void SelectHeroSkill(JassUnit whichHero, JassObjectId abilcode)
        {
            Natives.instance.selectHeroSkill(whichHero, abilcode);
        }
        
        public static JassInteger GetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives.instance.getUnitAbilityLevel(whichUnit, abilcode);
        }
        
        public static JassInteger DecUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives.instance.decUnitAbilityLevel(whichUnit, abilcode);
        }
        
        public static JassInteger IncUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives.instance.incUnitAbilityLevel(whichUnit, abilcode);
        }
        
        public static JassInteger SetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode, JassInteger level)
        {
            return Natives.instance.setUnitAbilityLevel(whichUnit, abilcode, level);
        }
        
        public static Boolean ReviveHero(JassUnit whichHero, Single x, Single y, Boolean doEyecandy)
        {
            return Natives.instance.reviveHero(whichHero, x, y, doEyecandy);
        }
        
        public static Boolean ReviveHeroLoc(JassUnit whichHero, JassLocation loc, Boolean doEyecandy)
        {
            return Natives.instance.reviveHeroLoc(whichHero, loc, doEyecandy);
        }
        
        public static void SetUnitExploded(JassUnit whichUnit, Boolean exploded)
        {
            Natives.instance.setUnitExploded(whichUnit, exploded);
        }
        
        public static void SetUnitInvulnerable(JassUnit whichUnit, Boolean flag)
        {
            Natives.instance.setUnitInvulnerable(whichUnit, flag);
        }
        
        public static void PauseUnit(JassUnit whichUnit, Boolean flag)
        {
            Natives.instance.pauseUnit(whichUnit, flag);
        }
        
        public static Boolean IsUnitPaused(JassUnit whichHero)
        {
            return Natives.instance.isUnitPaused(whichHero);
        }
        
        public static void SetUnitPathing(JassUnit whichUnit, Boolean flag)
        {
            Natives.instance.setUnitPathing(whichUnit, flag);
        }
        
        public static void ClearSelection()
        {
            Natives.instance.clearSelection();
        }
        
        public static void SelectUnit(JassUnit whichUnit, Boolean flag)
        {
            Natives.instance.selectUnit(whichUnit, flag);
        }
        
        public static JassInteger GetUnitPointValue(JassUnit whichUnit)
        {
            return Natives.instance.getUnitPointValue(whichUnit);
        }
        
        public static JassInteger GetUnitPointValueByType(JassInteger unitType)
        {
            return Natives.instance.getUnitPointValueByType(unitType);
        }
        
        public static Boolean UnitAddItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives.instance.unitAddItem(whichUnit, whichItem);
        }
        
        public static JassItem UnitAddItemById(JassUnit whichUnit, JassObjectId itemId)
        {
            return Natives.instance.unitAddItemById(whichUnit, itemId);
        }
        
        public static Boolean UnitAddItemToSlotById(JassUnit whichUnit, JassObjectId itemId, JassInteger itemSlot)
        {
            return Natives.instance.unitAddItemToSlotById(whichUnit, itemId, itemSlot);
        }
        
        public static void UnitRemoveItem(JassUnit whichUnit, JassItem whichItem)
        {
            Natives.instance.unitRemoveItem(whichUnit, whichItem);
        }
        
        public static JassItem UnitRemoveItemFromSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return Natives.instance.unitRemoveItemFromSlot(whichUnit, itemSlot);
        }
        
        public static Boolean UnitHasItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives.instance.unitHasItem(whichUnit, whichItem);
        }
        
        public static JassItem UnitItemInSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return Natives.instance.unitItemInSlot(whichUnit, itemSlot);
        }
        
        public static JassInteger UnitInventorySize(JassUnit whichUnit)
        {
            return Natives.instance.unitInventorySize(whichUnit);
        }
        
        public static Boolean UnitDropItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return Natives.instance.unitDropItemPoint(whichUnit, whichItem, x, y);
        }
        
        public static Boolean UnitDropItemSlot(JassUnit whichUnit, JassItem whichItem, JassInteger slot)
        {
            return Natives.instance.unitDropItemSlot(whichUnit, whichItem, slot);
        }
        
        public static Boolean UnitDropItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return Natives.instance.unitDropItemTarget(whichUnit, whichItem, target);
        }
        
        public static Boolean UnitUseItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives.instance.unitUseItem(whichUnit, whichItem);
        }
        
        public static Boolean UnitUseItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return Natives.instance.unitUseItemPoint(whichUnit, whichItem, x, y);
        }
        
        public static Boolean UnitUseItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return Natives.instance.unitUseItemTarget(whichUnit, whichItem, target);
        }
        
        public static Single GetUnitX(JassUnit whichUnit)
        {
            return Natives.instance.getUnitX(whichUnit);
        }
        
        public static Single GetUnitY(JassUnit whichUnit)
        {
            return Natives.instance.getUnitY(whichUnit);
        }
        
        public static JassLocation GetUnitLoc(JassUnit whichUnit)
        {
            return Natives.instance.getUnitLoc(whichUnit);
        }
        
        public static Single GetUnitFacing(JassUnit whichUnit)
        {
            return Natives.instance.getUnitFacing(whichUnit);
        }
        
        public static Single GetUnitMoveSpeed(JassUnit whichUnit)
        {
            return Natives.instance.getUnitMoveSpeed(whichUnit);
        }
        
        public static Single GetUnitDefaultMoveSpeed(JassUnit whichUnit)
        {
            return Natives.instance.getUnitDefaultMoveSpeed(whichUnit);
        }
        
        public static Single GetUnitState(JassUnit whichUnit, JassUnitState whichUnitState)
        {
            return Natives.instance.getUnitState(whichUnit, whichUnitState);
        }
        
        public static JassPlayer GetOwningPlayer(JassUnit whichUnit)
        {
            return Natives.instance.getOwningPlayer(whichUnit);
        }
        
        public static JassObjectId GetUnitTypeId(JassUnit whichUnit)
        {
            return Natives.instance.getUnitTypeId(whichUnit);
        }
        
        public static JassRace GetUnitRace(JassUnit whichUnit)
        {
            return Natives.instance.getUnitRace(whichUnit);
        }
        
        public static String GetUnitName(JassUnit whichUnit)
        {
            return Natives.instance.getUnitName(whichUnit);
        }
        
        public static JassInteger GetUnitFoodUsed(JassUnit whichUnit)
        {
            return Natives.instance.getUnitFoodUsed(whichUnit);
        }
        
        public static JassInteger GetUnitFoodMade(JassUnit whichUnit)
        {
            return Natives.instance.getUnitFoodMade(whichUnit);
        }
        
        public static JassInteger GetFoodMade(JassObjectId unitId)
        {
            return Natives.instance.getFoodMade(unitId);
        }
        
        public static JassInteger GetFoodUsed(JassObjectId unitId)
        {
            return Natives.instance.getFoodUsed(unitId);
        }
        
        public static void SetUnitUseFood(JassUnit whichUnit, Boolean useFood)
        {
            Natives.instance.setUnitUseFood(whichUnit, useFood);
        }
        
        public static JassLocation GetUnitRallyPoint(JassUnit whichUnit)
        {
            return Natives.instance.getUnitRallyPoint(whichUnit);
        }
        
        public static JassUnit GetUnitRallyUnit(JassUnit whichUnit)
        {
            return Natives.instance.getUnitRallyUnit(whichUnit);
        }
        
        public static JassDestructable GetUnitRallyDestructable(JassUnit whichUnit)
        {
            return Natives.instance.getUnitRallyDestructable(whichUnit);
        }
        
        public static Boolean IsUnitInGroup(JassUnit whichUnit, JassGroup whichGroup)
        {
            return Natives.instance.isUnitInGroup(whichUnit, whichGroup);
        }
        
        public static Boolean IsUnitInForce(JassUnit whichUnit, JassForce whichForce)
        {
            return Natives.instance.isUnitInForce(whichUnit, whichForce);
        }
        
        public static Boolean IsUnitOwnedByPlayer(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitOwnedByPlayer(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitAlly(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitAlly(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitEnemy(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitEnemy(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitVisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitVisible(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitDetected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitDetected(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitInvisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitInvisible(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitFogged(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitFogged(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitMasked(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitMasked(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitSelected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.instance.isUnitSelected(whichUnit, whichPlayer);
        }
        
        public static Boolean IsUnitRace(JassUnit whichUnit, JassRace whichRace)
        {
            return Natives.instance.isUnitRace(whichUnit, whichRace);
        }
        
        public static Boolean IsUnitType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives.instance.isUnitType(whichUnit, whichUnitType);
        }
        
        public static Boolean IsUnit(JassUnit whichUnit, JassUnit whichSpecifiedUnit)
        {
            return Natives.instance.isUnit(whichUnit, whichSpecifiedUnit);
        }
        
        public static Boolean IsUnitInRange(JassUnit whichUnit, JassUnit otherUnit, Single distance)
        {
            return Natives.instance.isUnitInRange(whichUnit, otherUnit, distance);
        }
        
        public static Boolean IsUnitInRangeXY(JassUnit whichUnit, Single x, Single y, Single distance)
        {
            return Natives.instance.isUnitInRangeXY(whichUnit, x, y, distance);
        }
        
        public static Boolean IsUnitInRangeLoc(JassUnit whichUnit, JassLocation whichLocation, Single distance)
        {
            return Natives.instance.isUnitInRangeLoc(whichUnit, whichLocation, distance);
        }
        
        public static Boolean IsUnitHidden(JassUnit whichUnit)
        {
            return Natives.instance.isUnitHidden(whichUnit);
        }
        
        public static Boolean IsUnitIllusion(JassUnit whichUnit)
        {
            return Natives.instance.isUnitIllusion(whichUnit);
        }
        
        public static Boolean IsUnitInTransport(JassUnit whichUnit, JassUnit whichTransport)
        {
            return Natives.instance.isUnitInTransport(whichUnit, whichTransport);
        }
        
        public static Boolean IsUnitLoaded(JassUnit whichUnit)
        {
            return Natives.instance.isUnitLoaded(whichUnit);
        }
        
        public static Boolean IsHeroUnitId(JassObjectId unitId)
        {
            return Natives.instance.isHeroUnitId(unitId);
        }
        
        public static Boolean IsUnitIdType(JassObjectId unitId, JassUnitType whichUnitType)
        {
            return Natives.instance.isUnitIdType(unitId, whichUnitType);
        }
        
        public static void UnitShareVision(JassUnit whichUnit, JassPlayer whichPlayer, Boolean share)
        {
            Natives.instance.unitShareVision(whichUnit, whichPlayer, share);
        }
        
        public static void UnitSuspendDecay(JassUnit whichUnit, Boolean suspend)
        {
            Natives.instance.unitSuspendDecay(whichUnit, suspend);
        }
        
        public static Boolean UnitAddType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives.instance.unitAddType(whichUnit, whichUnitType);
        }
        
        public static Boolean UnitRemoveType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives.instance.unitRemoveType(whichUnit, whichUnitType);
        }
        
        public static Boolean UnitAddAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return Natives.instance.unitAddAbility(whichUnit, abilityId);
        }
        
        public static Boolean UnitRemoveAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return Natives.instance.unitRemoveAbility(whichUnit, abilityId);
        }
        
        public static Boolean UnitMakeAbilityPermanent(JassUnit whichUnit, Boolean permanent, JassInteger abilityId)
        {
            return Natives.instance.unitMakeAbilityPermanent(whichUnit, permanent, abilityId);
        }
        
        public static void UnitRemoveBuffs(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative)
        {
            Natives.instance.unitRemoveBuffs(whichUnit, removePositive, removeNegative);
        }
        
        public static void UnitRemoveBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            Natives.instance.unitRemoveBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        public static Boolean UnitHasBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return Natives.instance.unitHasBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        public static JassInteger UnitCountBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return Natives.instance.unitCountBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }
        
        public static void UnitAddSleep(JassUnit whichUnit, Boolean add)
        {
            Natives.instance.unitAddSleep(whichUnit, add);
        }
        
        public static Boolean UnitCanSleep(JassUnit whichUnit)
        {
            return Natives.instance.unitCanSleep(whichUnit);
        }
        
        public static void UnitAddSleepPerm(JassUnit whichUnit, Boolean add)
        {
            Natives.instance.unitAddSleepPerm(whichUnit, add);
        }
        
        public static Boolean UnitCanSleepPerm(JassUnit whichUnit)
        {
            return Natives.instance.unitCanSleepPerm(whichUnit);
        }
        
        public static Boolean UnitIsSleeping(JassUnit whichUnit)
        {
            return Natives.instance.unitIsSleeping(whichUnit);
        }
        
        public static void UnitWakeUp(JassUnit whichUnit)
        {
            Natives.instance.unitWakeUp(whichUnit);
        }
        
        public static void UnitApplyTimedLife(JassUnit whichUnit, JassInteger buffId, Single duration)
        {
            Natives.instance.unitApplyTimedLife(whichUnit, buffId, duration);
        }
        
        public static Boolean UnitIgnoreAlarm(JassUnit whichUnit, Boolean flag)
        {
            return Natives.instance.unitIgnoreAlarm(whichUnit, flag);
        }
        
        public static Boolean UnitIgnoreAlarmToggled(JassUnit whichUnit)
        {
            return Natives.instance.unitIgnoreAlarmToggled(whichUnit);
        }
        
        public static void UnitResetCooldown(JassUnit whichUnit)
        {
            Natives.instance.unitResetCooldown(whichUnit);
        }
        
        public static void UnitSetConstructionProgress(JassUnit whichUnit, JassInteger constructionPercentage)
        {
            Natives.instance.unitSetConstructionProgress(whichUnit, constructionPercentage);
        }
        
        public static void UnitSetUpgradeProgress(JassUnit whichUnit, JassInteger upgradePercentage)
        {
            Natives.instance.unitSetUpgradeProgress(whichUnit, upgradePercentage);
        }
        
        public static void UnitPauseTimedLife(JassUnit whichUnit, Boolean flag)
        {
            Natives.instance.unitPauseTimedLife(whichUnit, flag);
        }
        
        public static void UnitSetUsesAltIcon(JassUnit whichUnit, Boolean flag)
        {
            Natives.instance.unitSetUsesAltIcon(whichUnit, flag);
        }
        
        public static Boolean UnitDamagePoint(JassUnit whichUnit, Single delay, Single radius, Single x, Single y, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return Natives.instance.unitDamagePoint(whichUnit, delay, radius, x, y, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        public static Boolean UnitDamageTarget(JassUnit whichUnit, JassWidget target, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return Natives.instance.unitDamageTarget(whichUnit, target, amount, attack, ranged, attackType, damageType, weaponType);
        }
        
        public static Boolean IssueImmediateOrder(JassUnit whichUnit, String order)
        {
            return Natives.instance.issueImmediateOrder(whichUnit, order);
        }
        
        public static Boolean IssueImmediateOrderById(JassUnit whichUnit, JassOrder order)
        {
            return Natives.instance.issueImmediateOrderById(whichUnit, order);
        }
        
        public static Boolean IssuePointOrder(JassUnit whichUnit, String order, Single x, Single y)
        {
            return Natives.instance.issuePointOrder(whichUnit, order, x, y);
        }
        
        public static Boolean IssuePointOrderLoc(JassUnit whichUnit, String order, JassLocation whichLocation)
        {
            return Natives.instance.issuePointOrderLoc(whichUnit, order, whichLocation);
        }
        
        public static Boolean IssuePointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y)
        {
            return Natives.instance.issuePointOrderById(whichUnit, order, x, y);
        }
        
        public static Boolean IssuePointOrderByIdLoc(JassUnit whichUnit, JassOrder order, JassLocation whichLocation)
        {
            return Natives.instance.issuePointOrderByIdLoc(whichUnit, order, whichLocation);
        }
        
        public static Boolean IssueTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget)
        {
            return Natives.instance.issueTargetOrder(whichUnit, order, targetWidget);
        }
        
        public static Boolean IssueTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget)
        {
            return Natives.instance.issueTargetOrderById(whichUnit, order, targetWidget);
        }
        
        public static Boolean IssueInstantPointOrder(JassUnit whichUnit, String order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return Natives.instance.issueInstantPointOrder(whichUnit, order, x, y, instantTargetWidget);
        }
        
        public static Boolean IssueInstantPointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return Natives.instance.issueInstantPointOrderById(whichUnit, order, x, y, instantTargetWidget);
        }
        
        public static Boolean IssueInstantTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return Natives.instance.issueInstantTargetOrder(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        public static Boolean IssueInstantTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return Natives.instance.issueInstantTargetOrderById(whichUnit, order, targetWidget, instantTargetWidget);
        }
        
        public static Boolean IssueBuildOrder(JassUnit whichPeon, String unitToBuild, Single x, Single y)
        {
            return Natives.instance.issueBuildOrder(whichPeon, unitToBuild, x, y);
        }
        
        public static Boolean IssueBuildOrderById(JassUnit whichPeon, JassObjectId unitId, Single x, Single y)
        {
            return Natives.instance.issueBuildOrderById(whichPeon, unitId, x, y);
        }
        
        public static Boolean IssueNeutralImmediateOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild)
        {
            return Natives.instance.issueNeutralImmediateOrder(forWhichPlayer, neutralStructure, unitToBuild);
        }
        
        public static Boolean IssueNeutralImmediateOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId)
        {
            return Natives.instance.issueNeutralImmediateOrderById(forWhichPlayer, neutralStructure, unitId);
        }
        
        public static Boolean IssueNeutralPointOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, Single x, Single y)
        {
            return Natives.instance.issueNeutralPointOrder(forWhichPlayer, neutralStructure, unitToBuild, x, y);
        }
        
        public static Boolean IssueNeutralPointOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, Single x, Single y)
        {
            return Natives.instance.issueNeutralPointOrderById(forWhichPlayer, neutralStructure, unitId, x, y);
        }
        
        public static Boolean IssueNeutralTargetOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassWidget target)
        {
            return Natives.instance.issueNeutralTargetOrder(forWhichPlayer, neutralStructure, unitToBuild, target);
        }
        
        public static Boolean IssueNeutralTargetOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassWidget target)
        {
            return Natives.instance.issueNeutralTargetOrderById(forWhichPlayer, neutralStructure, unitId, target);
        }
        
        public static JassInteger GetUnitCurrentOrder(JassUnit whichUnit)
        {
            return Natives.instance.getUnitCurrentOrder(whichUnit);
        }
        
        public static void SetResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            Natives.instance.setResourceAmount(whichUnit, amount);
        }
        
        public static void AddResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            Natives.instance.addResourceAmount(whichUnit, amount);
        }
        
        public static JassInteger GetResourceAmount(JassUnit whichUnit)
        {
            return Natives.instance.getResourceAmount(whichUnit);
        }
        
        public static Single WaygateGetDestinationX(JassUnit waygate)
        {
            return Natives.instance.waygateGetDestinationX(waygate);
        }
        
        public static Single WaygateGetDestinationY(JassUnit waygate)
        {
            return Natives.instance.waygateGetDestinationY(waygate);
        }
        
        public static void WaygateSetDestination(JassUnit waygate, Single x, Single y)
        {
            Natives.instance.waygateSetDestination(waygate, x, y);
        }
        
        public static void WaygateActivate(JassUnit waygate, Boolean activate)
        {
            Natives.instance.waygateActivate(waygate, activate);
        }
        
        public static Boolean WaygateIsActive(JassUnit waygate)
        {
            return Natives.instance.waygateIsActive(waygate);
        }
        
        public static void AddItemToAllStock(JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives.instance.addItemToAllStock(itemId, currentStock, stockMax);
        }
        
        public static void AddItemToStock(JassUnit whichUnit, JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives.instance.addItemToStock(whichUnit, itemId, currentStock, stockMax);
        }
        
        public static void AddUnitToAllStock(JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives.instance.addUnitToAllStock(unitId, currentStock, stockMax);
        }
        
        public static void AddUnitToStock(JassUnit whichUnit, JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives.instance.addUnitToStock(whichUnit, unitId, currentStock, stockMax);
        }
        
        public static void RemoveItemFromAllStock(JassObjectId itemId)
        {
            Natives.instance.removeItemFromAllStock(itemId);
        }
        
        public static void RemoveItemFromStock(JassUnit whichUnit, JassObjectId itemId)
        {
            Natives.instance.removeItemFromStock(whichUnit, itemId);
        }
        
        public static void RemoveUnitFromAllStock(JassObjectId unitId)
        {
            Natives.instance.removeUnitFromAllStock(unitId);
        }
        
        public static void RemoveUnitFromStock(JassUnit whichUnit, JassObjectId unitId)
        {
            Natives.instance.removeUnitFromStock(whichUnit, unitId);
        }
        
        public static void SetAllItemTypeSlots(JassInteger slots)
        {
            Natives.instance.setAllItemTypeSlots(slots);
        }
        
        public static void SetAllUnitTypeSlots(JassInteger slots)
        {
            Natives.instance.setAllUnitTypeSlots(slots);
        }
        
        public static void SetItemTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            Natives.instance.setItemTypeSlots(whichUnit, slots);
        }
        
        public static void SetUnitTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            Natives.instance.setUnitTypeSlots(whichUnit, slots);
        }
        
        public static JassInteger GetUnitUserData(JassUnit whichUnit)
        {
            return Natives.instance.getUnitUserData(whichUnit);
        }
        
        public static void SetUnitUserData(JassUnit whichUnit, JassInteger data)
        {
            Natives.instance.setUnitUserData(whichUnit, data);
        }
        
        public static JassPlayer Player(JassInteger number)
        {
            return Natives.instance.player(number);
        }
        
        public static JassPlayer GetLocalPlayer()
        {
            return Natives.instance.getLocalPlayer();
        }
        
        public static Boolean IsPlayerAlly(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return Natives.instance.isPlayerAlly(whichPlayer, otherPlayer);
        }
        
        public static Boolean IsPlayerEnemy(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return Natives.instance.isPlayerEnemy(whichPlayer, otherPlayer);
        }
        
        public static Boolean IsPlayerInForce(JassPlayer whichPlayer, JassForce whichForce)
        {
            return Natives.instance.isPlayerInForce(whichPlayer, whichForce);
        }
        
        public static Boolean IsPlayerObserver(JassPlayer whichPlayer)
        {
            return Natives.instance.isPlayerObserver(whichPlayer);
        }
        
        public static Boolean IsVisibleToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives.instance.isVisibleToPlayer(x, y, whichPlayer);
        }
        
        public static Boolean IsLocationVisibleToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives.instance.isLocationVisibleToPlayer(whichLocation, whichPlayer);
        }
        
        public static Boolean IsFoggedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives.instance.isFoggedToPlayer(x, y, whichPlayer);
        }
        
        public static Boolean IsLocationFoggedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives.instance.isLocationFoggedToPlayer(whichLocation, whichPlayer);
        }
        
        public static Boolean IsMaskedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives.instance.isMaskedToPlayer(x, y, whichPlayer);
        }
        
        public static Boolean IsLocationMaskedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives.instance.isLocationMaskedToPlayer(whichLocation, whichPlayer);
        }
        
        public static JassRace GetPlayerRace(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerRace(whichPlayer);
        }
        
        public static JassInteger GetPlayerId(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerId(whichPlayer);
        }
        
        public static JassInteger GetPlayerUnitCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return Natives.instance.getPlayerUnitCount(whichPlayer, includeIncomplete);
        }
        
        public static JassInteger GetPlayerTypedUnitCount(JassPlayer whichPlayer, String unitName, Boolean includeIncomplete, Boolean includeUpgrades)
        {
            return Natives.instance.getPlayerTypedUnitCount(whichPlayer, unitName, includeIncomplete, includeUpgrades);
        }
        
        public static JassInteger GetPlayerStructureCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return Natives.instance.getPlayerStructureCount(whichPlayer, includeIncomplete);
        }
        
        public static JassInteger GetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState)
        {
            return Natives.instance.getPlayerState(whichPlayer, whichPlayerState);
        }
        
        public static JassInteger GetPlayerScore(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore)
        {
            return Natives.instance.getPlayerScore(whichPlayer, whichPlayerScore);
        }
        
        public static Boolean GetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting)
        {
            return Natives.instance.getPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting);
        }
        
        public static Single GetPlayerHandicap(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerHandicap(whichPlayer);
        }
        
        public static Single GetPlayerHandicapXP(JassPlayer whichPlayer)
        {
            return Natives.instance.getPlayerHandicapXP(whichPlayer);
        }
        
        public static void SetPlayerHandicap(JassPlayer whichPlayer, Single handicap)
        {
            Natives.instance.setPlayerHandicap(whichPlayer, handicap);
        }
        
        public static void SetPlayerHandicapXP(JassPlayer whichPlayer, Single handicap)
        {
            Natives.instance.setPlayerHandicapXP(whichPlayer, handicap);
        }
        
        public static void SetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum)
        {
            Natives.instance.setPlayerTechMaxAllowed(whichPlayer, techid, maximum);
        }
        
        public static JassInteger GetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid)
        {
            return Natives.instance.getPlayerTechMaxAllowed(whichPlayer, techid);
        }
        
        public static void AddPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger levels)
        {
            Natives.instance.addPlayerTechResearched(whichPlayer, techid, levels);
        }
        
        public static void SetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel)
        {
            Natives.instance.setPlayerTechResearched(whichPlayer, techid, setToLevel);
        }
        
        public static Boolean GetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return Natives.instance.getPlayerTechResearched(whichPlayer, techid, specificonly);
        }
        
        public static JassInteger GetPlayerTechCount(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return Natives.instance.getPlayerTechCount(whichPlayer, techid, specificonly);
        }
        
        public static void SetPlayerUnitsOwner(JassPlayer whichPlayer, JassInteger newOwner)
        {
            Natives.instance.setPlayerUnitsOwner(whichPlayer, newOwner);
        }
        
        public static void CripplePlayer(JassPlayer whichPlayer, JassForce toWhichPlayers, Boolean flag)
        {
            Natives.instance.cripplePlayer(whichPlayer, toWhichPlayers, flag);
        }
        
        public static void SetPlayerAbilityAvailable(JassPlayer whichPlayer, JassObjectId abilid, Boolean avail)
        {
            Natives.instance.setPlayerAbilityAvailable(whichPlayer, abilid, avail);
        }
        
        public static void SetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value)
        {
            Natives.instance.setPlayerState(whichPlayer, whichPlayerState, value);
        }
        
        public static void RemovePlayer(JassPlayer whichPlayer, JassPlayerGameResult gameResult)
        {
            Natives.instance.removePlayer(whichPlayer, gameResult);
        }
        
        public static void CachePlayerHeroData(JassPlayer whichPlayer)
        {
            Natives.instance.cachePlayerHeroData(whichPlayer);
        }
        
        public static void SetFogStateRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision)
        {
            Natives.instance.setFogStateRect(forWhichPlayer, whichState, where, useSharedVision);
        }
        
        public static void SetFogStateRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision)
        {
            Natives.instance.setFogStateRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision);
        }
        
        public static void SetFogStateRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision)
        {
            Natives.instance.setFogStateRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision);
        }
        
        public static void FogMaskEnable(Boolean enable)
        {
            Natives.instance.fogMaskEnable(enable);
        }
        
        public static Boolean IsFogMaskEnabled()
        {
            return Natives.instance.isFogMaskEnabled();
        }
        
        public static void FogEnable(Boolean enable)
        {
            Natives.instance.fogEnable(enable);
        }
        
        public static Boolean IsFogEnabled()
        {
            return Natives.instance.isFogEnabled();
        }
        
        public static JassFogModifier CreateFogModifierRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives.instance.createFogModifierRect(forWhichPlayer, whichState, where, useSharedVision, afterUnits);
        }
        
        public static JassFogModifier CreateFogModifierRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives.instance.createFogModifierRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision, afterUnits);
        }
        
        public static JassFogModifier CreateFogModifierRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives.instance.createFogModifierRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision, afterUnits);
        }
        
        public static void DestroyFogModifier(JassFogModifier whichFogModifier)
        {
            Natives.instance.destroyFogModifier(whichFogModifier);
        }
        
        public static void FogModifierStart(JassFogModifier whichFogModifier)
        {
            Natives.instance.fogModifierStart(whichFogModifier);
        }
        
        public static void FogModifierStop(JassFogModifier whichFogModifier)
        {
            Natives.instance.fogModifierStop(whichFogModifier);
        }
        
        public static JassVersion VersionGet()
        {
            return Natives.instance.versionGet();
        }
        
        public static Boolean VersionCompatible(JassVersion whichVersion)
        {
            return Natives.instance.versionCompatible(whichVersion);
        }
        
        public static Boolean VersionSupported(JassVersion whichVersion)
        {
            return Natives.instance.versionSupported(whichVersion);
        }
        
        public static void EndGame(Boolean doScoreScreen)
        {
            Natives.instance.endGame(doScoreScreen);
        }
        
        public static void ChangeLevel(String newLevel, Boolean doScoreScreen)
        {
            Natives.instance.changeLevel(newLevel, doScoreScreen);
        }
        
        public static void RestartGame(Boolean doScoreScreen)
        {
            Natives.instance.restartGame(doScoreScreen);
        }
        
        public static void ReloadGame()
        {
            Natives.instance.reloadGame();
        }
        
        public static void SetCampaignMenuRace(JassRace r)
        {
            Natives.instance.setCampaignMenuRace(r);
        }
        
        public static void SetCampaignMenuRaceEx(JassInteger campaignIndex)
        {
            Natives.instance.setCampaignMenuRaceEx(campaignIndex);
        }
        
        public static void ForceCampaignSelectScreen()
        {
            Natives.instance.forceCampaignSelectScreen();
        }
        
        public static void LoadGame(String saveFileName, Boolean doScoreScreen)
        {
            Natives.instance.loadGame(saveFileName, doScoreScreen);
        }
        
        public static void SaveGame(String saveFileName)
        {
            Natives.instance.saveGame(saveFileName);
        }
        
        public static Boolean RenameSaveDirectory(String sourceDirName, String destDirName)
        {
            return Natives.instance.renameSaveDirectory(sourceDirName, destDirName);
        }
        
        public static Boolean RemoveSaveDirectory(String sourceDirName)
        {
            return Natives.instance.removeSaveDirectory(sourceDirName);
        }
        
        public static Boolean CopySaveGame(String sourceSaveName, String destSaveName)
        {
            return Natives.instance.copySaveGame(sourceSaveName, destSaveName);
        }
        
        public static Boolean SaveGameExists(String saveName)
        {
            return Natives.instance.saveGameExists(saveName);
        }
        
        public static void SyncSelections()
        {
            Natives.instance.syncSelections();
        }
        
        public static void SetFloatGameState(JassFGameState whichFloatGameState, Single value)
        {
            Natives.instance.setFloatGameState(whichFloatGameState, value);
        }
        
        public static Single GetFloatGameState(JassFGameState whichFloatGameState)
        {
            return Natives.instance.getFloatGameState(whichFloatGameState);
        }
        
        public static void SetIntegerGameState(JassIGameState whichIntegerGameState, JassInteger value)
        {
            Natives.instance.setIntegerGameState(whichIntegerGameState, value);
        }
        
        public static JassInteger GetIntegerGameState(JassIGameState whichIntegerGameState)
        {
            return Natives.instance.getIntegerGameState(whichIntegerGameState);
        }
        
        public static void SetTutorialCleared(Boolean cleared)
        {
            Natives.instance.setTutorialCleared(cleared);
        }
        
        public static void SetMissionAvailable(JassInteger campaignNumber, JassInteger missionNumber, Boolean available)
        {
            Natives.instance.setMissionAvailable(campaignNumber, missionNumber, available);
        }
        
        public static void SetCampaignAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives.instance.setCampaignAvailable(campaignNumber, available);
        }
        
        public static void SetOpCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives.instance.setOpCinematicAvailable(campaignNumber, available);
        }
        
        public static void SetEdCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives.instance.setEdCinematicAvailable(campaignNumber, available);
        }
        
        public static JassGameDifficulty GetDefaultDifficulty()
        {
            return Natives.instance.getDefaultDifficulty();
        }
        
        public static void SetDefaultDifficulty(JassGameDifficulty g)
        {
            Natives.instance.setDefaultDifficulty(g);
        }
        
        public static void SetCustomCampaignButtonVisible(JassInteger whichButton, Boolean visible)
        {
            Natives.instance.setCustomCampaignButtonVisible(whichButton, visible);
        }
        
        public static Boolean GetCustomCampaignButtonVisible(JassInteger whichButton)
        {
            return Natives.instance.getCustomCampaignButtonVisible(whichButton);
        }
        
        public static void DoNotSaveReplay()
        {
            Natives.instance.doNotSaveReplay();
        }
        
        public static JassDialog DialogCreate()
        {
            return Natives.instance.dialogCreate();
        }
        
        public static void DialogDestroy(JassDialog whichDialog)
        {
            Natives.instance.dialogDestroy(whichDialog);
        }
        
        public static void DialogClear(JassDialog whichDialog)
        {
            Natives.instance.dialogClear(whichDialog);
        }
        
        public static void DialogSetMessage(JassDialog whichDialog, String messageText)
        {
            Natives.instance.dialogSetMessage(whichDialog, messageText);
        }
        
        public static JassButton DialogAddButton(JassDialog whichDialog, String buttonText, JassInteger hotkey)
        {
            return Natives.instance.dialogAddButton(whichDialog, buttonText, hotkey);
        }
        
        public static JassButton DialogAddQuitButton(JassDialog whichDialog, Boolean doScoreScreen, String buttonText, JassInteger hotkey)
        {
            return Natives.instance.dialogAddQuitButton(whichDialog, doScoreScreen, buttonText, hotkey);
        }
        
        public static void DialogDisplay(JassPlayer whichPlayer, JassDialog whichDialog, Boolean flag)
        {
            Natives.instance.dialogDisplay(whichPlayer, whichDialog, flag);
        }
        
        public static Boolean ReloadGameCachesFromDisk()
        {
            return Natives.instance.reloadGameCachesFromDisk();
        }
        
        public static JassGameCache InitGameCache(String campaignFile)
        {
            return Natives.instance.initGameCache(campaignFile);
        }
        
        public static Boolean SaveGameCache(JassGameCache whichCache)
        {
            return Natives.instance.saveGameCache(whichCache);
        }
        
        public static void StoreInteger(JassGameCache cache, String missionKey, String key, JassInteger value)
        {
            Natives.instance.storeInteger(cache, missionKey, key, value);
        }
        
        public static void StoreReal(JassGameCache cache, String missionKey, String key, Single value)
        {
            Natives.instance.storeReal(cache, missionKey, key, value);
        }
        
        public static void StoreBoolean(JassGameCache cache, String missionKey, String key, Boolean value)
        {
            Natives.instance.storeBoolean(cache, missionKey, key, value);
        }
        
        public static Boolean StoreUnit(JassGameCache cache, String missionKey, String key, JassUnit whichUnit)
        {
            return Natives.instance.storeUnit(cache, missionKey, key, whichUnit);
        }
        
        public static Boolean StoreString(JassGameCache cache, String missionKey, String key, String value)
        {
            return Natives.instance.storeString(cache, missionKey, key, value);
        }
        
        public static void SyncStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.syncStoredInteger(cache, missionKey, key);
        }
        
        public static void SyncStoredReal(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.syncStoredReal(cache, missionKey, key);
        }
        
        public static void SyncStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.syncStoredBoolean(cache, missionKey, key);
        }
        
        public static void SyncStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.syncStoredUnit(cache, missionKey, key);
        }
        
        public static void SyncStoredString(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.syncStoredString(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.haveStoredInteger(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.haveStoredReal(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.haveStoredBoolean(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.haveStoredUnit(cache, missionKey, key);
        }
        
        public static Boolean HaveStoredString(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.haveStoredString(cache, missionKey, key);
        }
        
        public static void FlushGameCache(JassGameCache cache)
        {
            Natives.instance.flushGameCache(cache);
        }
        
        public static void FlushStoredMission(JassGameCache cache, String missionKey)
        {
            Natives.instance.flushStoredMission(cache, missionKey);
        }
        
        public static void FlushStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.flushStoredInteger(cache, missionKey, key);
        }
        
        public static void FlushStoredReal(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.flushStoredReal(cache, missionKey, key);
        }
        
        public static void FlushStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.flushStoredBoolean(cache, missionKey, key);
        }
        
        public static void FlushStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.flushStoredUnit(cache, missionKey, key);
        }
        
        public static void FlushStoredString(JassGameCache cache, String missionKey, String key)
        {
            Natives.instance.flushStoredString(cache, missionKey, key);
        }
        
        public static JassInteger GetStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.getStoredInteger(cache, missionKey, key);
        }
        
        public static Single GetStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.getStoredReal(cache, missionKey, key);
        }
        
        public static Boolean GetStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.getStoredBoolean(cache, missionKey, key);
        }
        
        public static String GetStoredString(JassGameCache cache, String missionKey, String key)
        {
            return Natives.instance.getStoredString(cache, missionKey, key);
        }
        
        public static JassUnit RestoreUnit(JassGameCache cache, String missionKey, String key, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return Natives.instance.restoreUnit(cache, missionKey, key, forWhichPlayer, x, y, facing);
        }
        
        public static JassHashTable InitHashtable()
        {
            return Natives.instance.initHashtable();
        }
        
        public static void SaveInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value)
        {
            Natives.instance.saveInteger(table, parentKey, childKey, value);
        }
        
        public static void SaveReal(JassHashTable table, JassInteger parentKey, JassInteger childKey, Single value)
        {
            Natives.instance.saveReal(table, parentKey, childKey, value);
        }
        
        public static void SaveBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey, Boolean value)
        {
            Natives.instance.saveBoolean(table, parentKey, childKey, value);
        }
        
        public static Boolean SaveStr(JassHashTable table, JassInteger parentKey, JassInteger childKey, String value)
        {
            return Natives.instance.saveStr(table, parentKey, childKey, value);
        }
        
        public static Boolean SavePlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer)
        {
            return Natives.instance.savePlayerHandle(table, parentKey, childKey, whichPlayer);
        }
        
        public static Boolean SaveWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget)
        {
            return Natives.instance.saveWidgetHandle(table, parentKey, childKey, whichWidget);
        }
        
        public static Boolean SaveDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable)
        {
            return Natives.instance.saveDestructableHandle(table, parentKey, childKey, whichDestructable);
        }
        
        public static Boolean SaveItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem)
        {
            return Natives.instance.saveItemHandle(table, parentKey, childKey, whichItem);
        }
        
        public static Boolean SaveUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit)
        {
            return Natives.instance.saveUnitHandle(table, parentKey, childKey, whichUnit);
        }
        
        public static Boolean SaveAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility)
        {
            return Natives.instance.saveAbilityHandle(table, parentKey, childKey, whichAbility);
        }
        
        public static Boolean SaveTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer)
        {
            return Natives.instance.saveTimerHandle(table, parentKey, childKey, whichTimer);
        }
        
        public static Boolean SaveTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger)
        {
            return Natives.instance.saveTriggerHandle(table, parentKey, childKey, whichTrigger);
        }
        
        public static Boolean SaveTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition)
        {
            return Natives.instance.saveTriggerConditionHandle(table, parentKey, childKey, whichTriggercondition);
        }
        
        public static Boolean SaveTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction)
        {
            return Natives.instance.saveTriggerActionHandle(table, parentKey, childKey, whichTriggeraction);
        }
        
        public static Boolean SaveTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent)
        {
            return Natives.instance.saveTriggerEventHandle(table, parentKey, childKey, whichEvent);
        }
        
        public static Boolean SaveForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce)
        {
            return Natives.instance.saveForceHandle(table, parentKey, childKey, whichForce);
        }
        
        public static Boolean SaveGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup)
        {
            return Natives.instance.saveGroupHandle(table, parentKey, childKey, whichGroup);
        }
        
        public static Boolean SaveLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation)
        {
            return Natives.instance.saveLocationHandle(table, parentKey, childKey, whichLocation);
        }
        
        public static Boolean SaveRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect)
        {
            return Natives.instance.saveRectHandle(table, parentKey, childKey, whichRect);
        }
        
        public static Boolean SaveBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr)
        {
            return Natives.instance.saveBooleanExprHandle(table, parentKey, childKey, whichBoolexpr);
        }
        
        public static Boolean SaveSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound)
        {
            return Natives.instance.saveSoundHandle(table, parentKey, childKey, whichSound);
        }
        
        public static Boolean SaveEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect)
        {
            return Natives.instance.saveEffectHandle(table, parentKey, childKey, whichEffect);
        }
        
        public static Boolean SaveUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool)
        {
            return Natives.instance.saveUnitPoolHandle(table, parentKey, childKey, whichUnitpool);
        }
        
        public static Boolean SaveItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool)
        {
            return Natives.instance.saveItemPoolHandle(table, parentKey, childKey, whichItempool);
        }
        
        public static Boolean SaveQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest)
        {
            return Natives.instance.saveQuestHandle(table, parentKey, childKey, whichQuest);
        }
        
        public static Boolean SaveQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem)
        {
            return Natives.instance.saveQuestItemHandle(table, parentKey, childKey, whichQuestitem);
        }
        
        public static Boolean SaveDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition)
        {
            return Natives.instance.saveDefeatConditionHandle(table, parentKey, childKey, whichDefeatcondition);
        }
        
        public static Boolean SaveTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog)
        {
            return Natives.instance.saveTimerDialogHandle(table, parentKey, childKey, whichTimerdialog);
        }
        
        public static Boolean SaveLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard)
        {
            return Natives.instance.saveLeaderboardHandle(table, parentKey, childKey, whichLeaderboard);
        }
        
        public static Boolean SaveMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard)
        {
            return Natives.instance.saveMultiboardHandle(table, parentKey, childKey, whichMultiboard);
        }
        
        public static Boolean SaveMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem)
        {
            return Natives.instance.saveMultiboardItemHandle(table, parentKey, childKey, whichMultiboarditem);
        }
        
        public static Boolean SaveTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable)
        {
            return Natives.instance.saveTrackableHandle(table, parentKey, childKey, whichTrackable);
        }
        
        public static Boolean SaveDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog)
        {
            return Natives.instance.saveDialogHandle(table, parentKey, childKey, whichDialog);
        }
        
        public static Boolean SaveButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton)
        {
            return Natives.instance.saveButtonHandle(table, parentKey, childKey, whichButton);
        }
        
        public static Boolean SaveTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag)
        {
            return Natives.instance.saveTextTagHandle(table, parentKey, childKey, whichTexttag);
        }
        
        public static Boolean SaveLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning)
        {
            return Natives.instance.saveLightningHandle(table, parentKey, childKey, whichLightning);
        }
        
        public static Boolean SaveImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage)
        {
            return Natives.instance.saveImageHandle(table, parentKey, childKey, whichImage);
        }
        
        public static Boolean SaveUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat)
        {
            return Natives.instance.saveUbersplatHandle(table, parentKey, childKey, whichUbersplat);
        }
        
        public static Boolean SaveRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion)
        {
            return Natives.instance.saveRegionHandle(table, parentKey, childKey, whichRegion);
        }
        
        public static Boolean SaveFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState)
        {
            return Natives.instance.saveFogStateHandle(table, parentKey, childKey, whichFogState);
        }
        
        public static Boolean SaveFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier)
        {
            return Natives.instance.saveFogModifierHandle(table, parentKey, childKey, whichFogModifier);
        }
        
        public static Boolean SaveAgentHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent)
        {
            return Natives.instance.saveAgentHandle(table, parentKey, childKey, whichAgent);
        }
        
        public static Boolean SaveHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable)
        {
            return Natives.instance.saveHashtableHandle(table, parentKey, childKey, whichHashtable);
        }
        
        public static JassInteger LoadInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadInteger(table, parentKey, childKey);
        }
        
        public static Single LoadReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadReal(table, parentKey, childKey);
        }
        
        public static Boolean LoadBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadBoolean(table, parentKey, childKey);
        }
        
        public static String LoadStr(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadStr(table, parentKey, childKey);
        }
        
        public static JassPlayer LoadPlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadPlayerHandle(table, parentKey, childKey);
        }
        
        public static JassWidget LoadWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadWidgetHandle(table, parentKey, childKey);
        }
        
        public static JassDestructable LoadDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadDestructableHandle(table, parentKey, childKey);
        }
        
        public static JassItem LoadItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadItemHandle(table, parentKey, childKey);
        }
        
        public static JassUnit LoadUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadUnitHandle(table, parentKey, childKey);
        }
        
        public static JassAbility LoadAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadAbilityHandle(table, parentKey, childKey);
        }
        
        public static JassTimer LoadTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadTimerHandle(table, parentKey, childKey);
        }
        
        public static JassTrigger LoadTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadTriggerHandle(table, parentKey, childKey);
        }
        
        public static JassTriggerCondition LoadTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadTriggerConditionHandle(table, parentKey, childKey);
        }
        
        public static JassTriggerAction LoadTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadTriggerActionHandle(table, parentKey, childKey);
        }
        
        public static JassEvent LoadTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadTriggerEventHandle(table, parentKey, childKey);
        }
        
        public static JassForce LoadForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadForceHandle(table, parentKey, childKey);
        }
        
        public static JassGroup LoadGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadGroupHandle(table, parentKey, childKey);
        }
        
        public static JassLocation LoadLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadLocationHandle(table, parentKey, childKey);
        }
        
        public static JassRect LoadRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadRectHandle(table, parentKey, childKey);
        }
        
        public static JassBooleanExpression LoadBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadBooleanExprHandle(table, parentKey, childKey);
        }
        
        public static JassSound LoadSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadSoundHandle(table, parentKey, childKey);
        }
        
        public static JassEffect LoadEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadEffectHandle(table, parentKey, childKey);
        }
        
        public static JassUnitPool LoadUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadUnitPoolHandle(table, parentKey, childKey);
        }
        
        public static JassItemPool LoadItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadItemPoolHandle(table, parentKey, childKey);
        }
        
        public static JassQuest LoadQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadQuestHandle(table, parentKey, childKey);
        }
        
        public static JassQuestItem LoadQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadQuestItemHandle(table, parentKey, childKey);
        }
        
        public static JassDefeatCondition LoadDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadDefeatConditionHandle(table, parentKey, childKey);
        }
        
        public static JassTimerDialog LoadTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadTimerDialogHandle(table, parentKey, childKey);
        }
        
        public static JassLeaderboard LoadLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadLeaderboardHandle(table, parentKey, childKey);
        }
        
        public static JassMultiboard LoadMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadMultiboardHandle(table, parentKey, childKey);
        }
        
        public static JassMultiboardItem LoadMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadMultiboardItemHandle(table, parentKey, childKey);
        }
        
        public static JassTrackable LoadTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadTrackableHandle(table, parentKey, childKey);
        }
        
        public static JassDialog LoadDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadDialogHandle(table, parentKey, childKey);
        }
        
        public static JassButton LoadButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadButtonHandle(table, parentKey, childKey);
        }
        
        public static JassTextTag LoadTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadTextTagHandle(table, parentKey, childKey);
        }
        
        public static JassLightning LoadLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadLightningHandle(table, parentKey, childKey);
        }
        
        public static JassImage LoadImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadImageHandle(table, parentKey, childKey);
        }
        
        public static JassUberSplat LoadUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadUbersplatHandle(table, parentKey, childKey);
        }
        
        public static JassRegion LoadRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadRegionHandle(table, parentKey, childKey);
        }
        
        public static JassFogState LoadFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadFogStateHandle(table, parentKey, childKey);
        }
        
        public static JassFogModifier LoadFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadFogModifierHandle(table, parentKey, childKey);
        }
        
        public static JassHashTable LoadHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.loadHashtableHandle(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.haveSavedInteger(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.haveSavedReal(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.haveSavedBoolean(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.haveSavedString(table, parentKey, childKey);
        }
        
        public static Boolean HaveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.instance.haveSavedHandle(table, parentKey, childKey);
        }
        
        public static void RemoveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.instance.removeSavedInteger(table, parentKey, childKey);
        }
        
        public static void RemoveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.instance.removeSavedReal(table, parentKey, childKey);
        }
        
        public static void RemoveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.instance.removeSavedBoolean(table, parentKey, childKey);
        }
        
        public static void RemoveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.instance.removeSavedString(table, parentKey, childKey);
        }
        
        public static void RemoveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.instance.removeSavedHandle(table, parentKey, childKey);
        }
        
        public static void FlushParentHashtable(JassHashTable table)
        {
            Natives.instance.flushParentHashtable(table);
        }
        
        public static void FlushChildHashtable(JassHashTable table, JassInteger parentKey)
        {
            Natives.instance.flushChildHashtable(table, parentKey);
        }
        
        public static JassInteger GetRandomInt(JassInteger lowBound, JassInteger highBound)
        {
            return Natives.instance.getRandomInt(lowBound, highBound);
        }
        
        public static Single GetRandomReal(Single lowBound, Single highBound)
        {
            return Natives.instance.getRandomReal(lowBound, highBound);
        }
        
        public static JassUnitPool CreateUnitPool()
        {
            return Natives.instance.createUnitPool();
        }
        
        public static void DestroyUnitPool(JassUnitPool whichPool)
        {
            Natives.instance.destroyUnitPool(whichPool);
        }
        
        public static void UnitPoolAddUnitType(JassUnitPool whichPool, JassObjectId unitId, Single weight)
        {
            Natives.instance.unitPoolAddUnitType(whichPool, unitId, weight);
        }
        
        public static void UnitPoolRemoveUnitType(JassUnitPool whichPool, JassObjectId unitId)
        {
            Natives.instance.unitPoolRemoveUnitType(whichPool, unitId);
        }
        
        public static JassUnit PlaceRandomUnit(JassUnitPool whichPool, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return Natives.instance.placeRandomUnit(whichPool, forWhichPlayer, x, y, facing);
        }
        
        public static JassItemPool CreateItemPool()
        {
            return Natives.instance.createItemPool();
        }
        
        public static void DestroyItemPool(JassItemPool whichItemPool)
        {
            Natives.instance.destroyItemPool(whichItemPool);
        }
        
        public static void ItemPoolAddItemType(JassItemPool whichItemPool, JassObjectId itemId, Single weight)
        {
            Natives.instance.itemPoolAddItemType(whichItemPool, itemId, weight);
        }
        
        public static void ItemPoolRemoveItemType(JassItemPool whichItemPool, JassObjectId itemId)
        {
            Natives.instance.itemPoolRemoveItemType(whichItemPool, itemId);
        }
        
        public static JassItem PlaceRandomItem(JassItemPool whichItemPool, Single x, Single y)
        {
            return Natives.instance.placeRandomItem(whichItemPool, x, y);
        }
        
        public static JassInteger ChooseRandomCreep(JassInteger level)
        {
            return Natives.instance.chooseRandomCreep(level);
        }
        
        public static JassInteger ChooseRandomNPBuilding()
        {
            return Natives.instance.chooseRandomNPBuilding();
        }
        
        public static JassInteger ChooseRandomItem(JassInteger level)
        {
            return Natives.instance.chooseRandomItem(level);
        }
        
        public static JassInteger ChooseRandomItemEx(JassItemType whichType, JassInteger level)
        {
            return Natives.instance.chooseRandomItemEx(whichType, level);
        }
        
        public static void SetRandomSeed(JassInteger seed)
        {
            Natives.instance.setRandomSeed(seed);
        }
        
        public static void SetTerrainFog(Single a, Single b, Single c, Single d, Single e)
        {
            Natives.instance.setTerrainFog(a, b, c, d, e);
        }
        
        public static void ResetTerrainFog()
        {
            Natives.instance.resetTerrainFog();
        }
        
        public static void SetUnitFog(Single a, Single b, Single c, Single d, Single e)
        {
            Natives.instance.setUnitFog(a, b, c, d, e);
        }
        
        public static void SetTerrainFogEx(JassInteger style, Single zstart, Single zend, Single density, Single red, Single green, Single blue)
        {
            Natives.instance.setTerrainFogEx(style, zstart, zend, density, red, green, blue);
        }
        
        public static void DisplayTextToPlayer(JassPlayer toPlayer, Single x, Single y, String message)
        {
            Natives.instance.displayTextToPlayer(toPlayer, x, y, message);
        }
        
        public static void DisplayTimedTextToPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            Natives.instance.displayTimedTextToPlayer(toPlayer, x, y, duration, message);
        }
        
        public static void DisplayTimedTextFromPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            Natives.instance.displayTimedTextFromPlayer(toPlayer, x, y, duration, message);
        }
        
        public static void ClearTextMessages()
        {
            Natives.instance.clearTextMessages();
        }
        
        public static void SetDayNightModels(String terrainDNCFile, String unitDNCFile)
        {
            Natives.instance.setDayNightModels(terrainDNCFile, unitDNCFile);
        }
        
        public static void SetSkyModel(String skyModelFile)
        {
            Natives.instance.setSkyModel(skyModelFile);
        }
        
        public static void EnableUserControl(Boolean b)
        {
            Natives.instance.enableUserControl(b);
        }
        
        public static void EnableUserUI(Boolean b)
        {
            Natives.instance.enableUserUI(b);
        }
        
        public static void SuspendTimeOfDay(Boolean b)
        {
            Natives.instance.suspendTimeOfDay(b);
        }
        
        public static void SetTimeOfDayScale(Single r)
        {
            Natives.instance.setTimeOfDayScale(r);
        }
        
        public static Single GetTimeOfDayScale()
        {
            return Natives.instance.getTimeOfDayScale();
        }
        
        public static void ShowInterface(Boolean flag, Single fadeDuration)
        {
            Natives.instance.showInterface(flag, fadeDuration);
        }
        
        public static void PauseGame(Boolean flag)
        {
            Natives.instance.pauseGame(flag);
        }
        
        public static void UnitAddIndicator(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.unitAddIndicator(whichUnit, red, green, blue, alpha);
        }
        
        public static void AddIndicator(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.addIndicator(whichWidget, red, green, blue, alpha);
        }
        
        public static void PingMinimap(Single x, Single y, Single duration)
        {
            Natives.instance.pingMinimap(x, y, duration);
        }
        
        public static void PingMinimapEx(Single x, Single y, Single duration, JassInteger red, JassInteger green, JassInteger blue, Boolean extraEffects)
        {
            Natives.instance.pingMinimapEx(x, y, duration, red, green, blue, extraEffects);
        }
        
        public static void EnableOcclusion(Boolean flag)
        {
            Natives.instance.enableOcclusion(flag);
        }
        
        public static void SetIntroShotText(String introText)
        {
            Natives.instance.setIntroShotText(introText);
        }
        
        public static void SetIntroShotModel(String introModelPath)
        {
            Natives.instance.setIntroShotModel(introModelPath);
        }
        
        public static void EnableWorldFogBoundary(Boolean b)
        {
            Natives.instance.enableWorldFogBoundary(b);
        }
        
        public static void PlayModelCinematic(String modelName)
        {
            Natives.instance.playModelCinematic(modelName);
        }
        
        public static void PlayCinematic(String movieName)
        {
            Natives.instance.playCinematic(movieName);
        }
        
        public static void ForceUIKey(String key)
        {
            Natives.instance.forceUIKey(key);
        }
        
        public static void ForceUICancel()
        {
            Natives.instance.forceUICancel();
        }
        
        public static void DisplayLoadDialog()
        {
            Natives.instance.displayLoadDialog();
        }
        
        public static void SetAltMinimapIcon(String iconPath)
        {
            Natives.instance.setAltMinimapIcon(iconPath);
        }
        
        public static void DisableRestartMission(Boolean flag)
        {
            Natives.instance.disableRestartMission(flag);
        }
        
        public static JassTextTag CreateTextTag()
        {
            return Natives.instance.createTextTag();
        }
        
        public static void DestroyTextTag(JassTextTag t)
        {
            Natives.instance.destroyTextTag(t);
        }
        
        public static void SetTextTagText(JassTextTag t, String s, Single height)
        {
            Natives.instance.setTextTagText(t, s, height);
        }
        
        public static void SetTextTagPos(JassTextTag t, Single x, Single y, Single heightOffset)
        {
            Natives.instance.setTextTagPos(t, x, y, heightOffset);
        }
        
        public static void SetTextTagPosUnit(JassTextTag t, JassUnit whichUnit, Single heightOffset)
        {
            Natives.instance.setTextTagPosUnit(t, whichUnit, heightOffset);
        }
        
        public static void SetTextTagColor(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.setTextTagColor(t, red, green, blue, alpha);
        }
        
        public static void SetTextTagVelocity(JassTextTag t, Single xvel, Single yvel)
        {
            Natives.instance.setTextTagVelocity(t, xvel, yvel);
        }
        
        public static void SetTextTagVisibility(JassTextTag t, Boolean flag)
        {
            Natives.instance.setTextTagVisibility(t, flag);
        }
        
        public static void SetTextTagSuspended(JassTextTag t, Boolean flag)
        {
            Natives.instance.setTextTagSuspended(t, flag);
        }
        
        public static void SetTextTagPermanent(JassTextTag t, Boolean flag)
        {
            Natives.instance.setTextTagPermanent(t, flag);
        }
        
        public static void SetTextTagAge(JassTextTag t, Single age)
        {
            Natives.instance.setTextTagAge(t, age);
        }
        
        public static void SetTextTagLifespan(JassTextTag t, Single lifespan)
        {
            Natives.instance.setTextTagLifespan(t, lifespan);
        }
        
        public static void SetTextTagFadepoint(JassTextTag t, Single fadepoint)
        {
            Natives.instance.setTextTagFadepoint(t, fadepoint);
        }
        
        public static void SetReservedLocalHeroButtons(JassInteger reserved)
        {
            Natives.instance.setReservedLocalHeroButtons(reserved);
        }
        
        public static JassInteger GetAllyColorFilterState()
        {
            return Natives.instance.getAllyColorFilterState();
        }
        
        public static void SetAllyColorFilterState(JassInteger state)
        {
            Natives.instance.setAllyColorFilterState(state);
        }
        
        public static Boolean GetCreepCampFilterState()
        {
            return Natives.instance.getCreepCampFilterState();
        }
        
        public static void SetCreepCampFilterState(Boolean state)
        {
            Natives.instance.setCreepCampFilterState(state);
        }
        
        public static void EnableMinimapFilterButtons(Boolean enableAlly, Boolean enableCreep)
        {
            Natives.instance.enableMinimapFilterButtons(enableAlly, enableCreep);
        }
        
        public static void EnableDragSelect(Boolean state, Boolean ui)
        {
            Natives.instance.enableDragSelect(state, ui);
        }
        
        public static void EnablePreSelect(Boolean state, Boolean ui)
        {
            Natives.instance.enablePreSelect(state, ui);
        }
        
        public static void EnableSelect(Boolean state, Boolean ui)
        {
            Natives.instance.enableSelect(state, ui);
        }
        
        public static JassTrackable CreateTrackable(String trackableModelPath, Single x, Single y, Single facing)
        {
            return Natives.instance.createTrackable(trackableModelPath, x, y, facing);
        }
        
        public static JassQuest CreateQuest()
        {
            return Natives.instance.createQuest();
        }
        
        public static void DestroyQuest(JassQuest whichQuest)
        {
            Natives.instance.destroyQuest(whichQuest);
        }
        
        public static void QuestSetTitle(JassQuest whichQuest, String title)
        {
            Natives.instance.questSetTitle(whichQuest, title);
        }
        
        public static void QuestSetDescription(JassQuest whichQuest, String description)
        {
            Natives.instance.questSetDescription(whichQuest, description);
        }
        
        public static void QuestSetIconPath(JassQuest whichQuest, String iconPath)
        {
            Natives.instance.questSetIconPath(whichQuest, iconPath);
        }
        
        public static void QuestSetRequired(JassQuest whichQuest, Boolean required)
        {
            Natives.instance.questSetRequired(whichQuest, required);
        }
        
        public static void QuestSetCompleted(JassQuest whichQuest, Boolean completed)
        {
            Natives.instance.questSetCompleted(whichQuest, completed);
        }
        
        public static void QuestSetDiscovered(JassQuest whichQuest, Boolean discovered)
        {
            Natives.instance.questSetDiscovered(whichQuest, discovered);
        }
        
        public static void QuestSetFailed(JassQuest whichQuest, Boolean failed)
        {
            Natives.instance.questSetFailed(whichQuest, failed);
        }
        
        public static void QuestSetEnabled(JassQuest whichQuest, Boolean enabled)
        {
            Natives.instance.questSetEnabled(whichQuest, enabled);
        }
        
        public static Boolean IsQuestRequired(JassQuest whichQuest)
        {
            return Natives.instance.isQuestRequired(whichQuest);
        }
        
        public static Boolean IsQuestCompleted(JassQuest whichQuest)
        {
            return Natives.instance.isQuestCompleted(whichQuest);
        }
        
        public static Boolean IsQuestDiscovered(JassQuest whichQuest)
        {
            return Natives.instance.isQuestDiscovered(whichQuest);
        }
        
        public static Boolean IsQuestFailed(JassQuest whichQuest)
        {
            return Natives.instance.isQuestFailed(whichQuest);
        }
        
        public static Boolean IsQuestEnabled(JassQuest whichQuest)
        {
            return Natives.instance.isQuestEnabled(whichQuest);
        }
        
        public static JassQuestItem QuestCreateItem(JassQuest whichQuest)
        {
            return Natives.instance.questCreateItem(whichQuest);
        }
        
        public static void QuestItemSetDescription(JassQuestItem whichQuestItem, String description)
        {
            Natives.instance.questItemSetDescription(whichQuestItem, description);
        }
        
        public static void QuestItemSetCompleted(JassQuestItem whichQuestItem, Boolean completed)
        {
            Natives.instance.questItemSetCompleted(whichQuestItem, completed);
        }
        
        public static Boolean IsQuestItemCompleted(JassQuestItem whichQuestItem)
        {
            return Natives.instance.isQuestItemCompleted(whichQuestItem);
        }
        
        public static JassDefeatCondition CreateDefeatCondition()
        {
            return Natives.instance.createDefeatCondition();
        }
        
        public static void DestroyDefeatCondition(JassDefeatCondition whichCondition)
        {
            Natives.instance.destroyDefeatCondition(whichCondition);
        }
        
        public static void DefeatConditionSetDescription(JassDefeatCondition whichCondition, String description)
        {
            Natives.instance.defeatConditionSetDescription(whichCondition, description);
        }
        
        public static void FlashQuestDialogButton()
        {
            Natives.instance.flashQuestDialogButton();
        }
        
        public static void ForceQuestDialogUpdate()
        {
            Natives.instance.forceQuestDialogUpdate();
        }
        
        public static JassTimerDialog CreateTimerDialog(JassTimer t)
        {
            return Natives.instance.createTimerDialog(t);
        }
        
        public static void DestroyTimerDialog(JassTimerDialog whichDialog)
        {
            Natives.instance.destroyTimerDialog(whichDialog);
        }
        
        public static void TimerDialogSetTitle(JassTimerDialog whichDialog, String title)
        {
            Natives.instance.timerDialogSetTitle(whichDialog, title);
        }
        
        public static void TimerDialogSetTitleColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.timerDialogSetTitleColor(whichDialog, red, green, blue, alpha);
        }
        
        public static void TimerDialogSetTimeColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.timerDialogSetTimeColor(whichDialog, red, green, blue, alpha);
        }
        
        public static void TimerDialogSetSpeed(JassTimerDialog whichDialog, Single speedMultFactor)
        {
            Natives.instance.timerDialogSetSpeed(whichDialog, speedMultFactor);
        }
        
        public static void TimerDialogDisplay(JassTimerDialog whichDialog, Boolean display)
        {
            Natives.instance.timerDialogDisplay(whichDialog, display);
        }
        
        public static Boolean IsTimerDialogDisplayed(JassTimerDialog whichDialog)
        {
            return Natives.instance.isTimerDialogDisplayed(whichDialog);
        }
        
        public static void TimerDialogSetRealTimeRemaining(JassTimerDialog whichDialog, Single timeRemaining)
        {
            Natives.instance.timerDialogSetRealTimeRemaining(whichDialog, timeRemaining);
        }
        
        public static JassLeaderboard CreateLeaderboard()
        {
            return Natives.instance.createLeaderboard();
        }
        
        public static void DestroyLeaderboard(JassLeaderboard lb)
        {
            Natives.instance.destroyLeaderboard(lb);
        }
        
        public static void LeaderboardDisplay(JassLeaderboard lb, Boolean show)
        {
            Natives.instance.leaderboardDisplay(lb, show);
        }
        
        public static Boolean IsLeaderboardDisplayed(JassLeaderboard lb)
        {
            return Natives.instance.isLeaderboardDisplayed(lb);
        }
        
        public static JassInteger LeaderboardGetItemCount(JassLeaderboard lb)
        {
            return Natives.instance.leaderboardGetItemCount(lb);
        }
        
        public static void LeaderboardSetSizeByItemCount(JassLeaderboard lb, JassInteger count)
        {
            Natives.instance.leaderboardSetSizeByItemCount(lb, count);
        }
        
        public static void LeaderboardAddItem(JassLeaderboard lb, String label, JassInteger value, JassPlayer p)
        {
            Natives.instance.leaderboardAddItem(lb, label, value, p);
        }
        
        public static void LeaderboardRemoveItem(JassLeaderboard lb, JassInteger index)
        {
            Natives.instance.leaderboardRemoveItem(lb, index);
        }
        
        public static void LeaderboardRemovePlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            Natives.instance.leaderboardRemovePlayerItem(lb, p);
        }
        
        public static void LeaderboardClear(JassLeaderboard lb)
        {
            Natives.instance.leaderboardClear(lb);
        }
        
        public static void LeaderboardSortItemsByValue(JassLeaderboard lb, Boolean ascending)
        {
            Natives.instance.leaderboardSortItemsByValue(lb, ascending);
        }
        
        public static void LeaderboardSortItemsByPlayer(JassLeaderboard lb, Boolean ascending)
        {
            Natives.instance.leaderboardSortItemsByPlayer(lb, ascending);
        }
        
        public static void LeaderboardSortItemsByLabel(JassLeaderboard lb, Boolean ascending)
        {
            Natives.instance.leaderboardSortItemsByLabel(lb, ascending);
        }
        
        public static Boolean LeaderboardHasPlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            return Natives.instance.leaderboardHasPlayerItem(lb, p);
        }
        
        public static JassInteger LeaderboardGetPlayerIndex(JassLeaderboard lb, JassPlayer p)
        {
            return Natives.instance.leaderboardGetPlayerIndex(lb, p);
        }
        
        public static void LeaderboardSetLabel(JassLeaderboard lb, String label)
        {
            Natives.instance.leaderboardSetLabel(lb, label);
        }
        
        public static String LeaderboardGetLabelText(JassLeaderboard lb)
        {
            return Natives.instance.leaderboardGetLabelText(lb);
        }
        
        public static void PlayerSetLeaderboard(JassPlayer toPlayer, JassLeaderboard lb)
        {
            Natives.instance.playerSetLeaderboard(toPlayer, lb);
        }
        
        public static JassLeaderboard PlayerGetLeaderboard(JassPlayer toPlayer)
        {
            return Natives.instance.playerGetLeaderboard(toPlayer);
        }
        
        public static void LeaderboardSetLabelColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.leaderboardSetLabelColor(lb, red, green, blue, alpha);
        }
        
        public static void LeaderboardSetValueColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.leaderboardSetValueColor(lb, red, green, blue, alpha);
        }
        
        public static void LeaderboardSetStyle(JassLeaderboard lb, Boolean showLabel, Boolean showNames, Boolean showValues, Boolean showIcons)
        {
            Natives.instance.leaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);
        }
        
        public static void LeaderboardSetItemValue(JassLeaderboard lb, JassInteger whichItem, JassInteger val)
        {
            Natives.instance.leaderboardSetItemValue(lb, whichItem, val);
        }
        
        public static void LeaderboardSetItemLabel(JassLeaderboard lb, JassInteger whichItem, String val)
        {
            Natives.instance.leaderboardSetItemLabel(lb, whichItem, val);
        }
        
        public static void LeaderboardSetItemStyle(JassLeaderboard lb, JassInteger whichItem, Boolean showLabel, Boolean showValue, Boolean showIcon)
        {
            Natives.instance.leaderboardSetItemStyle(lb, whichItem, showLabel, showValue, showIcon);
        }
        
        public static void LeaderboardSetItemLabelColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.leaderboardSetItemLabelColor(lb, whichItem, red, green, blue, alpha);
        }
        
        public static void LeaderboardSetItemValueColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.leaderboardSetItemValueColor(lb, whichItem, red, green, blue, alpha);
        }
        
        public static JassMultiboard CreateMultiboard()
        {
            return Natives.instance.createMultiboard();
        }
        
        public static void DestroyMultiboard(JassMultiboard lb)
        {
            Natives.instance.destroyMultiboard(lb);
        }
        
        public static void MultiboardDisplay(JassMultiboard lb, Boolean show)
        {
            Natives.instance.multiboardDisplay(lb, show);
        }
        
        public static Boolean IsMultiboardDisplayed(JassMultiboard lb)
        {
            return Natives.instance.isMultiboardDisplayed(lb);
        }
        
        public static void MultiboardMinimize(JassMultiboard lb, Boolean minimize)
        {
            Natives.instance.multiboardMinimize(lb, minimize);
        }
        
        public static Boolean IsMultiboardMinimized(JassMultiboard lb)
        {
            return Natives.instance.isMultiboardMinimized(lb);
        }
        
        public static void MultiboardClear(JassMultiboard lb)
        {
            Natives.instance.multiboardClear(lb);
        }
        
        public static void MultiboardSetTitleText(JassMultiboard lb, String label)
        {
            Natives.instance.multiboardSetTitleText(lb, label);
        }
        
        public static String MultiboardGetTitleText(JassMultiboard lb)
        {
            return Natives.instance.multiboardGetTitleText(lb);
        }
        
        public static void MultiboardSetTitleTextColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.multiboardSetTitleTextColor(lb, red, green, blue, alpha);
        }
        
        public static JassInteger MultiboardGetRowCount(JassMultiboard lb)
        {
            return Natives.instance.multiboardGetRowCount(lb);
        }
        
        public static JassInteger MultiboardGetColumnCount(JassMultiboard lb)
        {
            return Natives.instance.multiboardGetColumnCount(lb);
        }
        
        public static void MultiboardSetColumnCount(JassMultiboard lb, JassInteger count)
        {
            Natives.instance.multiboardSetColumnCount(lb, count);
        }
        
        public static void MultiboardSetRowCount(JassMultiboard lb, JassInteger count)
        {
            Natives.instance.multiboardSetRowCount(lb, count);
        }
        
        public static void MultiboardSetItemsStyle(JassMultiboard lb, Boolean showValues, Boolean showIcons)
        {
            Natives.instance.multiboardSetItemsStyle(lb, showValues, showIcons);
        }
        
        public static void MultiboardSetItemsValue(JassMultiboard lb, String value)
        {
            Natives.instance.multiboardSetItemsValue(lb, value);
        }
        
        public static void MultiboardSetItemsValueColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.multiboardSetItemsValueColor(lb, red, green, blue, alpha);
        }
        
        public static void MultiboardSetItemsWidth(JassMultiboard lb, Single width)
        {
            Natives.instance.multiboardSetItemsWidth(lb, width);
        }
        
        public static void MultiboardSetItemsIcon(JassMultiboard lb, String iconPath)
        {
            Natives.instance.multiboardSetItemsIcon(lb, iconPath);
        }
        
        public static JassMultiboardItem MultiboardGetItem(JassMultiboard lb, JassInteger row, JassInteger column)
        {
            return Natives.instance.multiboardGetItem(lb, row, column);
        }
        
        public static void MultiboardReleaseItem(JassMultiboardItem mbi)
        {
            Natives.instance.multiboardReleaseItem(mbi);
        }
        
        public static void MultiboardSetItemStyle(JassMultiboardItem mbi, Boolean showValue, Boolean showIcon)
        {
            Natives.instance.multiboardSetItemStyle(mbi, showValue, showIcon);
        }
        
        public static void MultiboardSetItemValue(JassMultiboardItem mbi, String val)
        {
            Natives.instance.multiboardSetItemValue(mbi, val);
        }
        
        public static void MultiboardSetItemValueColor(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.multiboardSetItemValueColor(mbi, red, green, blue, alpha);
        }
        
        public static void MultiboardSetItemWidth(JassMultiboardItem mbi, Single width)
        {
            Natives.instance.multiboardSetItemWidth(mbi, width);
        }
        
        public static void MultiboardSetItemIcon(JassMultiboardItem mbi, String iconFileName)
        {
            Natives.instance.multiboardSetItemIcon(mbi, iconFileName);
        }
        
        public static void MultiboardSuppressDisplay(Boolean flag)
        {
            Natives.instance.multiboardSuppressDisplay(flag);
        }
        
        public static void SetCameraPosition(Single x, Single y)
        {
            Natives.instance.setCameraPosition(x, y);
        }
        
        public static void SetCameraQuickPosition(Single x, Single y)
        {
            Natives.instance.setCameraQuickPosition(x, y);
        }
        
        public static void SetCameraBounds(Single x1, Single y1, Single x2, Single y2, Single x3, Single y3, Single x4, Single y4)
        {
            Natives.instance.setCameraBounds(x1, y1, x2, y2, x3, y3, x4, y4);
        }
        
        public static void StopCamera()
        {
            Natives.instance.stopCamera();
        }
        
        public static void ResetToGameCamera(Single duration)
        {
            Natives.instance.resetToGameCamera(duration);
        }
        
        public static void PanCameraTo(Single x, Single y)
        {
            Natives.instance.panCameraTo(x, y);
        }
        
        public static void PanCameraToTimed(Single x, Single y, Single duration)
        {
            Natives.instance.panCameraToTimed(x, y, duration);
        }
        
        public static void PanCameraToWithZ(Single x, Single y, Single zOffsetDest)
        {
            Natives.instance.panCameraToWithZ(x, y, zOffsetDest);
        }
        
        public static void PanCameraToTimedWithZ(Single x, Single y, Single zOffsetDest, Single duration)
        {
            Natives.instance.panCameraToTimedWithZ(x, y, zOffsetDest, duration);
        }
        
        public static void SetCinematicCamera(String cameraModelFile)
        {
            Natives.instance.setCinematicCamera(cameraModelFile);
        }
        
        public static void SetCameraRotateMode(Single x, Single y, Single radiansToSweep, Single duration)
        {
            Natives.instance.setCameraRotateMode(x, y, radiansToSweep, duration);
        }
        
        public static void SetCameraField(JassCameraField whichField, Single value, Single duration)
        {
            Natives.instance.setCameraField(whichField, value, duration);
        }
        
        public static void AdjustCameraField(JassCameraField whichField, Single offset, Single duration)
        {
            Natives.instance.adjustCameraField(whichField, offset, duration);
        }
        
        public static void SetCameraTargetController(JassUnit whichUnit, Single xoffset, Single yoffset, Boolean inheritOrientation)
        {
            Natives.instance.setCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);
        }
        
        public static void SetCameraOrientController(JassUnit whichUnit, Single xoffset, Single yoffset)
        {
            Natives.instance.setCameraOrientController(whichUnit, xoffset, yoffset);
        }
        
        public static JassCameraSetup CreateCameraSetup()
        {
            return Natives.instance.createCameraSetup();
        }
        
        public static void CameraSetupSetField(JassCameraSetup whichSetup, JassCameraField whichField, Single value, Single duration)
        {
            Natives.instance.cameraSetupSetField(whichSetup, whichField, value, duration);
        }
        
        public static Single CameraSetupGetField(JassCameraSetup whichSetup, JassCameraField whichField)
        {
            return Natives.instance.cameraSetupGetField(whichSetup, whichField);
        }
        
        public static void CameraSetupSetDestPosition(JassCameraSetup whichSetup, Single x, Single y, Single duration)
        {
            Natives.instance.cameraSetupSetDestPosition(whichSetup, x, y, duration);
        }
        
        public static JassLocation CameraSetupGetDestPositionLoc(JassCameraSetup whichSetup)
        {
            return Natives.instance.cameraSetupGetDestPositionLoc(whichSetup);
        }
        
        public static Single CameraSetupGetDestPositionX(JassCameraSetup whichSetup)
        {
            return Natives.instance.cameraSetupGetDestPositionX(whichSetup);
        }
        
        public static Single CameraSetupGetDestPositionY(JassCameraSetup whichSetup)
        {
            return Natives.instance.cameraSetupGetDestPositionY(whichSetup);
        }
        
        public static void CameraSetupApply(JassCameraSetup whichSetup, Boolean doPan, Boolean panTimed)
        {
            Natives.instance.cameraSetupApply(whichSetup, doPan, panTimed);
        }
        
        public static void CameraSetupApplyWithZ(JassCameraSetup whichSetup, Single zDestOffset)
        {
            Natives.instance.cameraSetupApplyWithZ(whichSetup, zDestOffset);
        }
        
        public static void CameraSetupApplyForceDuration(JassCameraSetup whichSetup, Boolean doPan, Single forceDuration)
        {
            Natives.instance.cameraSetupApplyForceDuration(whichSetup, doPan, forceDuration);
        }
        
        public static void CameraSetupApplyForceDurationWithZ(JassCameraSetup whichSetup, Single zDestOffset, Single forceDuration)
        {
            Natives.instance.cameraSetupApplyForceDurationWithZ(whichSetup, zDestOffset, forceDuration);
        }
        
        public static void CameraSetTargetNoise(Single mag, Single velocity)
        {
            Natives.instance.cameraSetTargetNoise(mag, velocity);
        }
        
        public static void CameraSetSourceNoise(Single mag, Single velocity)
        {
            Natives.instance.cameraSetSourceNoise(mag, velocity);
        }
        
        public static void CameraSetTargetNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            Natives.instance.cameraSetTargetNoiseEx(mag, velocity, vertOnly);
        }
        
        public static void CameraSetSourceNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            Natives.instance.cameraSetSourceNoiseEx(mag, velocity, vertOnly);
        }
        
        public static void CameraSetSmoothingFactor(Single factor)
        {
            Natives.instance.cameraSetSmoothingFactor(factor);
        }
        
        public static void SetCineFilterTexture(String filename)
        {
            Natives.instance.setCineFilterTexture(filename);
        }
        
        public static void SetCineFilterBlendMode(JassBlendMode whichMode)
        {
            Natives.instance.setCineFilterBlendMode(whichMode);
        }
        
        public static void SetCineFilterTexMapFlags(JassTextureMapFlags whichFlags)
        {
            Natives.instance.setCineFilterTexMapFlags(whichFlags);
        }
        
        public static void SetCineFilterStartUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            Natives.instance.setCineFilterStartUV(minu, minv, maxu, maxv);
        }
        
        public static void SetCineFilterEndUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            Natives.instance.setCineFilterEndUV(minu, minv, maxu, maxv);
        }
        
        public static void SetCineFilterStartColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.setCineFilterStartColor(red, green, blue, alpha);
        }
        
        public static void SetCineFilterEndColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.setCineFilterEndColor(red, green, blue, alpha);
        }
        
        public static void SetCineFilterDuration(Single duration)
        {
            Natives.instance.setCineFilterDuration(duration);
        }
        
        public static void DisplayCineFilter(Boolean flag)
        {
            Natives.instance.displayCineFilter(flag);
        }
        
        public static Boolean IsCineFilterDisplayed()
        {
            return Natives.instance.isCineFilterDisplayed();
        }
        
        public static void SetCinematicScene(JassInteger portraitUnitId, JassPlayerColor color, String speakerTitle, String text, Single sceneDuration, Single voiceoverDuration)
        {
            Natives.instance.setCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);
        }
        
        public static void EndCinematicScene()
        {
            Natives.instance.endCinematicScene();
        }
        
        public static void ForceCinematicSubtitles(Boolean flag)
        {
            Natives.instance.forceCinematicSubtitles(flag);
        }
        
        public static Single GetCameraMargin(JassInteger whichMargin)
        {
            return Natives.instance.getCameraMargin(whichMargin);
        }
        
        public static Single GetCameraBoundMinX()
        {
            return Natives.instance.getCameraBoundMinX();
        }
        
        public static Single GetCameraBoundMinY()
        {
            return Natives.instance.getCameraBoundMinY();
        }
        
        public static Single GetCameraBoundMaxX()
        {
            return Natives.instance.getCameraBoundMaxX();
        }
        
        public static Single GetCameraBoundMaxY()
        {
            return Natives.instance.getCameraBoundMaxY();
        }
        
        public static Single GetCameraField(JassCameraField whichField)
        {
            return Natives.instance.getCameraField(whichField);
        }
        
        public static Single GetCameraTargetPositionX()
        {
            return Natives.instance.getCameraTargetPositionX();
        }
        
        public static Single GetCameraTargetPositionY()
        {
            return Natives.instance.getCameraTargetPositionY();
        }
        
        public static Single GetCameraTargetPositionZ()
        {
            return Natives.instance.getCameraTargetPositionZ();
        }
        
        public static JassLocation GetCameraTargetPositionLoc()
        {
            return Natives.instance.getCameraTargetPositionLoc();
        }
        
        public static Single GetCameraEyePositionX()
        {
            return Natives.instance.getCameraEyePositionX();
        }
        
        public static Single GetCameraEyePositionY()
        {
            return Natives.instance.getCameraEyePositionY();
        }
        
        public static Single GetCameraEyePositionZ()
        {
            return Natives.instance.getCameraEyePositionZ();
        }
        
        public static JassLocation GetCameraEyePositionLoc()
        {
            return Natives.instance.getCameraEyePositionLoc();
        }
        
        public static void NewSoundEnvironment(String environmentName)
        {
            Natives.instance.newSoundEnvironment(environmentName);
        }
        
        public static JassSound CreateSound(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String eaxSetting)
        {
            return Natives.instance.createSound(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, eaxSetting);
        }
        
        public static JassSound CreateSoundFilenameWithLabel(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String SLKEntryName)
        {
            return Natives.instance.createSoundFilenameWithLabel(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, SLKEntryName);
        }
        
        public static JassSound CreateSoundFromLabel(String soundLabel, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return Natives.instance.createSoundFromLabel(soundLabel, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate);
        }
        
        public static JassSound CreateMIDISound(String soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return Natives.instance.createMIDISound(soundLabel, fadeInRate, fadeOutRate);
        }
        
        public static void SetSoundParamsFromLabel(JassSound soundHandle, String soundLabel)
        {
            Natives.instance.setSoundParamsFromLabel(soundHandle, soundLabel);
        }
        
        public static void SetSoundDistanceCutoff(JassSound soundHandle, Single cutoff)
        {
            Natives.instance.setSoundDistanceCutoff(soundHandle, cutoff);
        }
        
        public static void SetSoundChannel(JassSound soundHandle, JassInteger channel)
        {
            Natives.instance.setSoundChannel(soundHandle, channel);
        }
        
        public static void SetSoundVolume(JassSound soundHandle, JassInteger volume)
        {
            Natives.instance.setSoundVolume(soundHandle, volume);
        }
        
        public static void SetSoundPitch(JassSound soundHandle, Single pitch)
        {
            Natives.instance.setSoundPitch(soundHandle, pitch);
        }
        
        public static void SetSoundPlayPosition(JassSound soundHandle, JassInteger millisecs)
        {
            Natives.instance.setSoundPlayPosition(soundHandle, millisecs);
        }
        
        public static void SetSoundDistances(JassSound soundHandle, Single minDist, Single maxDist)
        {
            Natives.instance.setSoundDistances(soundHandle, minDist, maxDist);
        }
        
        public static void SetSoundConeAngles(JassSound soundHandle, Single inside, Single outside, JassInteger outsideVolume)
        {
            Natives.instance.setSoundConeAngles(soundHandle, inside, outside, outsideVolume);
        }
        
        public static void SetSoundConeOrientation(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives.instance.setSoundConeOrientation(soundHandle, x, y, z);
        }
        
        public static void SetSoundPosition(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives.instance.setSoundPosition(soundHandle, x, y, z);
        }
        
        public static void SetSoundVelocity(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives.instance.setSoundVelocity(soundHandle, x, y, z);
        }
        
        public static void AttachSoundToUnit(JassSound soundHandle, JassUnit whichUnit)
        {
            Natives.instance.attachSoundToUnit(soundHandle, whichUnit);
        }
        
        public static void StartSound(JassSound soundHandle)
        {
            Natives.instance.startSound(soundHandle);
        }
        
        public static void StopSound(JassSound soundHandle, Boolean killWhenDone, Boolean fadeOut)
        {
            Natives.instance.stopSound(soundHandle, killWhenDone, fadeOut);
        }
        
        public static void KillSoundWhenDone(JassSound soundHandle)
        {
            Natives.instance.killSoundWhenDone(soundHandle);
        }
        
        public static void SetMapMusic(String musicName, Boolean random, JassInteger index)
        {
            Natives.instance.setMapMusic(musicName, random, index);
        }
        
        public static void ClearMapMusic()
        {
            Natives.instance.clearMapMusic();
        }
        
        public static void PlayMusic(String musicName)
        {
            Natives.instance.playMusic(musicName);
        }
        
        public static void PlayMusicEx(String musicName, JassInteger frommsecs, JassInteger fadeinmsecs)
        {
            Natives.instance.playMusicEx(musicName, frommsecs, fadeinmsecs);
        }
        
        public static void StopMusic(Boolean fadeOut)
        {
            Natives.instance.stopMusic(fadeOut);
        }
        
        public static void ResumeMusic()
        {
            Natives.instance.resumeMusic();
        }
        
        public static void PlayThematicMusic(String musicFileName)
        {
            Natives.instance.playThematicMusic(musicFileName);
        }
        
        public static void PlayThematicMusicEx(String musicFileName, JassInteger frommsecs)
        {
            Natives.instance.playThematicMusicEx(musicFileName, frommsecs);
        }
        
        public static void EndThematicMusic()
        {
            Natives.instance.endThematicMusic();
        }
        
        public static void SetMusicVolume(JassInteger volume)
        {
            Natives.instance.setMusicVolume(volume);
        }
        
        public static void SetMusicPlayPosition(JassInteger millisecs)
        {
            Natives.instance.setMusicPlayPosition(millisecs);
        }
        
        public static void SetThematicMusicPlayPosition(JassInteger millisecs)
        {
            Natives.instance.setThematicMusicPlayPosition(millisecs);
        }
        
        public static void SetSoundDuration(JassSound soundHandle, JassInteger duration)
        {
            Natives.instance.setSoundDuration(soundHandle, duration);
        }
        
        public static JassInteger GetSoundDuration(JassSound soundHandle)
        {
            return Natives.instance.getSoundDuration(soundHandle);
        }
        
        public static JassInteger GetSoundFileDuration(String musicFileName)
        {
            return Natives.instance.getSoundFileDuration(musicFileName);
        }
        
        public static void VolumeGroupSetVolume(JassVolumeGroup vgroup, Single scale)
        {
            Natives.instance.volumeGroupSetVolume(vgroup, scale);
        }
        
        public static void VolumeGroupReset()
        {
            Natives.instance.volumeGroupReset();
        }
        
        public static Boolean GetSoundIsPlaying(JassSound soundHandle)
        {
            return Natives.instance.getSoundIsPlaying(soundHandle);
        }
        
        public static Boolean GetSoundIsLoading(JassSound soundHandle)
        {
            return Natives.instance.getSoundIsLoading(soundHandle);
        }
        
        public static void RegisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            Natives.instance.registerStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        public static void UnregisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            Natives.instance.unregisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }
        
        public static JassWeatherEffect AddWeatherEffect(JassRect where, JassInteger effectID)
        {
            return Natives.instance.addWeatherEffect(where, effectID);
        }
        
        public static void RemoveWeatherEffect(JassWeatherEffect whichEffect)
        {
            Natives.instance.removeWeatherEffect(whichEffect);
        }
        
        public static void EnableWeatherEffect(JassWeatherEffect whichEffect, Boolean enable)
        {
            Natives.instance.enableWeatherEffect(whichEffect, enable);
        }
        
        public static JassTerrainDeformation TerrainDeformCrater(Single x, Single y, Single radius, Single depth, JassInteger duration, Boolean permanent)
        {
            return Natives.instance.terrainDeformCrater(x, y, radius, depth, duration, permanent);
        }
        
        public static JassTerrainDeformation TerrainDeformRipple(Single x, Single y, Single radius, Single depth, JassInteger duration, JassInteger count, Single spaceWaves, Single timeWaves, Single radiusStartPct, Boolean limitNeg)
        {
            return Natives.instance.terrainDeformRipple(x, y, radius, depth, duration, count, spaceWaves, timeWaves, radiusStartPct, limitNeg);
        }
        
        public static JassTerrainDeformation TerrainDeformWave(Single x, Single y, Single dirX, Single dirY, Single distance, Single speed, Single radius, Single depth, JassInteger trailTime, JassInteger count)
        {
            return Natives.instance.terrainDeformWave(x, y, dirX, dirY, distance, speed, radius, depth, trailTime, count);
        }
        
        public static JassTerrainDeformation TerrainDeformRandom(Single x, Single y, Single radius, Single minDelta, Single maxDelta, JassInteger duration, JassInteger updateInterval)
        {
            return Natives.instance.terrainDeformRandom(x, y, radius, minDelta, maxDelta, duration, updateInterval);
        }
        
        public static void TerrainDeformStop(JassTerrainDeformation deformation, JassInteger duration)
        {
            Natives.instance.terrainDeformStop(deformation, duration);
        }
        
        public static void TerrainDeformStopAll()
        {
            Natives.instance.terrainDeformStopAll();
        }
        
        public static JassEffect AddSpecialEffect(String modelName, Single x, Single y)
        {
            return Natives.instance.addSpecialEffect(modelName, x, y);
        }
        
        public static JassEffect AddSpecialEffectLoc(String modelName, JassLocation where)
        {
            return Natives.instance.addSpecialEffectLoc(modelName, where);
        }
        
        public static JassEffect AddSpecialEffectTarget(String modelName, JassWidget targetWidget, String attachPointName)
        {
            return Natives.instance.addSpecialEffectTarget(modelName, targetWidget, attachPointName);
        }
        
        public static void DestroyEffect(JassEffect whichEffect)
        {
            Natives.instance.destroyEffect(whichEffect);
        }
        
        public static JassEffect AddSpellEffect(String abilityString, JassEffectType t, Single x, Single y)
        {
            return Natives.instance.addSpellEffect(abilityString, t, x, y);
        }
        
        public static JassEffect AddSpellEffectLoc(String abilityString, JassEffectType t, JassLocation where)
        {
            return Natives.instance.addSpellEffectLoc(abilityString, t, where);
        }
        
        public static JassEffect AddSpellEffectById(JassInteger abilityId, JassEffectType t, Single x, Single y)
        {
            return Natives.instance.addSpellEffectById(abilityId, t, x, y);
        }
        
        public static JassEffect AddSpellEffectByIdLoc(JassInteger abilityId, JassEffectType t, JassLocation where)
        {
            return Natives.instance.addSpellEffectByIdLoc(abilityId, t, where);
        }
        
        public static JassEffect AddSpellEffectTarget(String modelName, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return Natives.instance.addSpellEffectTarget(modelName, t, targetWidget, attachPoint);
        }
        
        public static JassEffect AddSpellEffectTargetById(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return Natives.instance.addSpellEffectTargetById(abilityId, t, targetWidget, attachPoint);
        }
        
        public static JassLightning AddLightning(String codeName, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return Natives.instance.addLightning(codeName, checkVisibility, x1, y1, x2, y2);
        }
        
        public static JassLightning AddLightningEx(String codeName, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return Natives.instance.addLightningEx(codeName, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        public static Boolean DestroyLightning(JassLightning whichBolt)
        {
            return Natives.instance.destroyLightning(whichBolt);
        }
        
        public static Boolean MoveLightning(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return Natives.instance.moveLightning(whichBolt, checkVisibility, x1, y1, x2, y2);
        }
        
        public static Boolean MoveLightningEx(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return Natives.instance.moveLightningEx(whichBolt, checkVisibility, x1, y1, z1, x2, y2, z2);
        }
        
        public static Single GetLightningColorA(JassLightning whichBolt)
        {
            return Natives.instance.getLightningColorA(whichBolt);
        }
        
        public static Single GetLightningColorR(JassLightning whichBolt)
        {
            return Natives.instance.getLightningColorR(whichBolt);
        }
        
        public static Single GetLightningColorG(JassLightning whichBolt)
        {
            return Natives.instance.getLightningColorG(whichBolt);
        }
        
        public static Single GetLightningColorB(JassLightning whichBolt)
        {
            return Natives.instance.getLightningColorB(whichBolt);
        }
        
        public static Boolean SetLightningColor(JassLightning whichBolt, Single r, Single g, Single b, Single a)
        {
            return Natives.instance.setLightningColor(whichBolt, r, g, b, a);
        }
        
        public static String GetAbilityEffect(String abilityString, JassEffectType t, JassInteger index)
        {
            return Natives.instance.getAbilityEffect(abilityString, t, index);
        }
        
        public static String GetAbilityEffectById(JassInteger abilityId, JassEffectType t, JassInteger index)
        {
            return Natives.instance.getAbilityEffectById(abilityId, t, index);
        }
        
        public static String GetAbilitySound(String abilityString, JassSoundType t)
        {
            return Natives.instance.getAbilitySound(abilityString, t);
        }
        
        public static String GetAbilitySoundById(JassInteger abilityId, JassSoundType t)
        {
            return Natives.instance.getAbilitySoundById(abilityId, t);
        }
        
        public static JassInteger GetTerrainCliffLevel(Single x, Single y)
        {
            return Natives.instance.getTerrainCliffLevel(x, y);
        }
        
        public static void SetWaterBaseColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.setWaterBaseColor(red, green, blue, alpha);
        }
        
        public static void SetWaterDeforms(Boolean val)
        {
            Natives.instance.setWaterDeforms(val);
        }
        
        public static JassInteger GetTerrainType(Single x, Single y)
        {
            return Natives.instance.getTerrainType(x, y);
        }
        
        public static JassInteger GetTerrainVariance(Single x, Single y)
        {
            return Natives.instance.getTerrainVariance(x, y);
        }
        
        public static void SetTerrainType(Single x, Single y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape)
        {
            Natives.instance.setTerrainType(x, y, terrainType, variation, area, shape);
        }
        
        public static Boolean IsTerrainPathable(Single x, Single y, JassPathingType t)
        {
            return Natives.instance.isTerrainPathable(x, y, t);
        }
        
        public static void SetTerrainPathable(Single x, Single y, JassPathingType t, Boolean flag)
        {
            Natives.instance.setTerrainPathable(x, y, t, flag);
        }
        
        public static JassImage CreateImage(String file, Single sizeX, Single sizeY, Single sizeZ, Single posX, Single posY, Single posZ, Single originX, Single originY, Single originZ, JassInteger imageType)
        {
            return Natives.instance.createImage(file, sizeX, sizeY, sizeZ, posX, posY, posZ, originX, originY, originZ, imageType);
        }
        
        public static void DestroyImage(JassImage whichImage)
        {
            Natives.instance.destroyImage(whichImage);
        }
        
        public static void ShowImage(JassImage whichImage, Boolean flag)
        {
            Natives.instance.showImage(whichImage, flag);
        }
        
        public static void SetImageConstantHeight(JassImage whichImage, Boolean flag, Single height)
        {
            Natives.instance.setImageConstantHeight(whichImage, flag, height);
        }
        
        public static void SetImagePosition(JassImage whichImage, Single x, Single y, Single z)
        {
            Natives.instance.setImagePosition(whichImage, x, y, z);
        }
        
        public static void SetImageColor(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.instance.setImageColor(whichImage, red, green, blue, alpha);
        }
        
        public static void SetImageRender(JassImage whichImage, Boolean flag)
        {
            Natives.instance.setImageRender(whichImage, flag);
        }
        
        public static void SetImageRenderAlways(JassImage whichImage, Boolean flag)
        {
            Natives.instance.setImageRenderAlways(whichImage, flag);
        }
        
        public static void SetImageAboveWater(JassImage whichImage, Boolean flag, Boolean useWaterAlpha)
        {
            Natives.instance.setImageAboveWater(whichImage, flag, useWaterAlpha);
        }
        
        public static void SetImageType(JassImage whichImage, JassInteger imageType)
        {
            Natives.instance.setImageType(whichImage, imageType);
        }
        
        public static JassUberSplat CreateUbersplat(Single x, Single y, String name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, Boolean forcePaused, Boolean noBirthTime)
        {
            return Natives.instance.createUbersplat(x, y, name, red, green, blue, alpha, forcePaused, noBirthTime);
        }
        
        public static void DestroyUbersplat(JassUberSplat whichSplat)
        {
            Natives.instance.destroyUbersplat(whichSplat);
        }
        
        public static void ResetUbersplat(JassUberSplat whichSplat)
        {
            Natives.instance.resetUbersplat(whichSplat);
        }
        
        public static void FinishUbersplat(JassUberSplat whichSplat)
        {
            Natives.instance.finishUbersplat(whichSplat);
        }
        
        public static void ShowUbersplat(JassUberSplat whichSplat, Boolean flag)
        {
            Natives.instance.showUbersplat(whichSplat, flag);
        }
        
        public static void SetUbersplatRender(JassUberSplat whichSplat, Boolean flag)
        {
            Natives.instance.setUbersplatRender(whichSplat, flag);
        }
        
        public static void SetUbersplatRenderAlways(JassUberSplat whichSplat, Boolean flag)
        {
            Natives.instance.setUbersplatRenderAlways(whichSplat, flag);
        }
        
        public static void SetBlight(JassPlayer whichPlayer, Single x, Single y, Single radius, Boolean addBlight)
        {
            Natives.instance.setBlight(whichPlayer, x, y, radius, addBlight);
        }
        
        public static void SetBlightRect(JassPlayer whichPlayer, JassRect r, Boolean addBlight)
        {
            Natives.instance.setBlightRect(whichPlayer, r, addBlight);
        }
        
        public static void SetBlightPoint(JassPlayer whichPlayer, Single x, Single y, Boolean addBlight)
        {
            Natives.instance.setBlightPoint(whichPlayer, x, y, addBlight);
        }
        
        public static void SetBlightLoc(JassPlayer whichPlayer, JassLocation whichLocation, Single radius, Boolean addBlight)
        {
            Natives.instance.setBlightLoc(whichPlayer, whichLocation, radius, addBlight);
        }
        
        public static JassUnit CreateBlightedGoldmine(JassPlayer id, Single x, Single y, Single face)
        {
            return Natives.instance.createBlightedGoldmine(id, x, y, face);
        }
        
        public static Boolean IsPointBlighted(Single x, Single y)
        {
            return Natives.instance.isPointBlighted(x, y);
        }
        
        public static void SetDoodadAnimation(Single x, Single y, Single radius, JassObjectId doodadID, Boolean nearestOnly, String animName, Boolean animRandom)
        {
            Natives.instance.setDoodadAnimation(x, y, radius, doodadID, nearestOnly, animName, animRandom);
        }
        
        public static void SetDoodadAnimationRect(JassRect r, JassObjectId doodadID, String animName, Boolean animRandom)
        {
            Natives.instance.setDoodadAnimationRect(r, doodadID, animName, animRandom);
        }
        
        public static void StartMeleeAI(JassPlayer num, String script)
        {
            Natives.instance.startMeleeAI(num, script);
        }
        
        public static void StartCampaignAI(JassPlayer num, String script)
        {
            Natives.instance.startCampaignAI(num, script);
        }
        
        public static void CommandAI(JassPlayer num, JassInteger command, JassInteger data)
        {
            Natives.instance.commandAI(num, command, data);
        }
        
        public static void PauseCompAI(JassPlayer p, Boolean pause)
        {
            Natives.instance.pauseCompAI(p, pause);
        }
        
        public static JassAIDifficulty GetAIDifficulty(JassPlayer num)
        {
            return Natives.instance.getAIDifficulty(num);
        }
        
        public static void RemoveGuardPosition(JassUnit hUnit)
        {
            Natives.instance.removeGuardPosition(hUnit);
        }
        
        public static void RecycleGuardPosition(JassUnit hUnit)
        {
            Natives.instance.recycleGuardPosition(hUnit);
        }
        
        public static void RemoveAllGuardPositions(JassPlayer num)
        {
            Natives.instance.removeAllGuardPositions(num);
        }
        
        public static void Cheat(String cheatStr)
        {
            Natives.instance.cheat(cheatStr);
        }
        
        public static Boolean IsNoVictoryCheat()
        {
            return Natives.instance.isNoVictoryCheat();
        }
        
        public static Boolean IsNoDefeatCheat()
        {
            return Natives.instance.isNoDefeatCheat();
        }
        
        public static void Preload(String filename)
        {
            Natives.instance.preload(filename);
        }
        
        public static void PreloadEnd(Single timeout)
        {
            Natives.instance.preloadEnd(timeout);
        }
        
        public static void PreloadStart()
        {
            Natives.instance.preloadStart();
        }
        
        public static void PreloadRefresh()
        {
            Natives.instance.preloadRefresh();
        }
        
        public static void PreloadEndEx()
        {
            Natives.instance.preloadEndEx();
        }
        
        public static void PreloadGenClear()
        {
            Natives.instance.preloadGenClear();
        }
        
        public static void PreloadGenStart()
        {
            Natives.instance.preloadGenStart();
        }
        
        public static void PreloadGenEnd(String filename)
        {
            Natives.instance.preloadGenEnd(filename);
        }
        
        public static void Preloader(String filename)
        {
            Natives.instance.preloader(filename);
        }
        
    }
}
