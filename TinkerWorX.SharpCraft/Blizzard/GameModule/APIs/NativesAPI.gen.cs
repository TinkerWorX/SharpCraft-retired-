using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Jass;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.APIs
{
    internal partial class NativesAPI
    {
        public JassRace ConvertRace(JassInteger i)
        {
            return Natives.ConvertRace(i);
        }

        public JassAllianceType ConvertAllianceType(JassInteger i)
        {
            return Natives.ConvertAllianceType(i);
        }

        public JassRacePreference ConvertRacePref(JassInteger i)
        {
            return Natives.ConvertRacePref(i);
        }

        public JassIGameState ConvertIGameState(JassInteger i)
        {
            return Natives.ConvertIGameState(i);
        }

        public JassFGameState ConvertFGameState(JassInteger i)
        {
            return Natives.ConvertFGameState(i);
        }

        public JassPlayerState ConvertPlayerState(JassInteger i)
        {
            return Natives.ConvertPlayerState(i);
        }

        public JassPlayerScore ConvertPlayerScore(JassInteger i)
        {
            return Natives.ConvertPlayerScore(i);
        }

        public JassPlayerGameResult ConvertPlayerGameResult(JassInteger i)
        {
            return Natives.ConvertPlayerGameResult(i);
        }

        public JassUnitState ConvertUnitState(JassInteger i)
        {
            return Natives.ConvertUnitState(i);
        }

        public JassAIDifficulty ConvertAIDifficulty(JassInteger i)
        {
            return Natives.ConvertAIDifficulty(i);
        }

        public JassGameEvent ConvertGameEvent(JassInteger i)
        {
            return Natives.ConvertGameEvent(i);
        }

        public JassPlayerEvent ConvertPlayerEvent(JassInteger i)
        {
            return Natives.ConvertPlayerEvent(i);
        }

        public JassPlayerUnitEvent ConvertPlayerUnitEvent(JassInteger i)
        {
            return Natives.ConvertPlayerUnitEvent(i);
        }

        public JassWidgetEvent ConvertWidgetEvent(JassInteger i)
        {
            return Natives.ConvertWidgetEvent(i);
        }

        public JassDialogEvent ConvertDialogEvent(JassInteger i)
        {
            return Natives.ConvertDialogEvent(i);
        }

        public JassUnitEvent ConvertUnitEvent(JassInteger i)
        {
            return Natives.ConvertUnitEvent(i);
        }

        public JassLimitOp ConvertLimitOp(JassInteger i)
        {
            return Natives.ConvertLimitOp(i);
        }

        public JassUnitType ConvertUnitType(JassInteger i)
        {
            return Natives.ConvertUnitType(i);
        }

        public JassGameSpeed ConvertGameSpeed(JassInteger i)
        {
            return Natives.ConvertGameSpeed(i);
        }

        public JassPlacement ConvertPlacement(JassInteger i)
        {
            return Natives.ConvertPlacement(i);
        }

        public JassStartLocationPriority ConvertStartLocPrio(JassInteger i)
        {
            return Natives.ConvertStartLocPrio(i);
        }

        public JassGameDifficulty ConvertGameDifficulty(JassInteger i)
        {
            return Natives.ConvertGameDifficulty(i);
        }

        public JassGameType ConvertGameType(JassInteger i)
        {
            return Natives.ConvertGameType(i);
        }

        public JassMapFlag ConvertMapFlag(JassInteger i)
        {
            return Natives.ConvertMapFlag(i);
        }

        public JassMapVisibility ConvertMapVisibility(JassInteger i)
        {
            return Natives.ConvertMapVisibility(i);
        }

        public JassMapSetting ConvertMapSetting(JassInteger i)
        {
            return Natives.ConvertMapSetting(i);
        }

        public JassMapDensity ConvertMapDensity(JassInteger i)
        {
            return Natives.ConvertMapDensity(i);
        }

        public JassMapControl ConvertMapControl(JassInteger i)
        {
            return Natives.ConvertMapControl(i);
        }

        public JassPlayerColor ConvertPlayerColor(JassInteger i)
        {
            return Natives.ConvertPlayerColor(i);
        }

        public JassPlayerSlotState ConvertPlayerSlotState(JassInteger i)
        {
            return Natives.ConvertPlayerSlotState(i);
        }

        public JassVolumeGroup ConvertVolumeGroup(JassInteger i)
        {
            return Natives.ConvertVolumeGroup(i);
        }

        public JassCameraField ConvertCameraField(JassInteger i)
        {
            return Natives.ConvertCameraField(i);
        }

        public JassBlendMode ConvertBlendMode(JassInteger i)
        {
            return Natives.ConvertBlendMode(i);
        }

        public JassRarityControl ConvertRarityControl(JassInteger i)
        {
            return Natives.ConvertRarityControl(i);
        }

        public JassTextureMapFlags ConvertTexMapFlags(JassInteger i)
        {
            return Natives.ConvertTexMapFlags(i);
        }

        public JassFogState ConvertFogState(JassInteger i)
        {
            return Natives.ConvertFogState(i);
        }

        public JassEffectType ConvertEffectType(JassInteger i)
        {
            return Natives.ConvertEffectType(i);
        }

        public JassVersion ConvertVersion(JassInteger i)
        {
            return Natives.ConvertVersion(i);
        }

        public JassItemType ConvertItemType(JassInteger i)
        {
            return Natives.ConvertItemType(i);
        }

        public JassAttackType ConvertAttackType(JassInteger i)
        {
            return Natives.ConvertAttackType(i);
        }

        public JassDamageType ConvertDamageType(JassInteger i)
        {
            return Natives.ConvertDamageType(i);
        }

        public JassWeaponType ConvertWeaponType(JassInteger i)
        {
            return Natives.ConvertWeaponType(i);
        }

        public JassSoundType ConvertSoundType(JassInteger i)
        {
            return Natives.ConvertSoundType(i);
        }

        public JassPathingType ConvertPathingType(JassInteger i)
        {
            return Natives.ConvertPathingType(i);
        }

        public JassOrder OrderId(String orderIdString)
        {
            return Natives.OrderId(orderIdString);
        }

        public String OrderId2String(JassOrder orderId)
        {
            return Natives.OrderId2String(orderId);
        }

        public JassObjectId UnitId(String unitIdString)
        {
            return Natives.UnitId(unitIdString);
        }

        public String UnitId2String(JassObjectId unitId)
        {
            return Natives.UnitId2String(unitId);
        }

        public JassObjectId AbilityId(String abilityIdString)
        {
            return Natives.AbilityId(abilityIdString);
        }

        public String AbilityId2String(JassInteger abilityId)
        {
            return Natives.AbilityId2String(abilityId);
        }

        public String GetObjectName(JassObjectId objectId)
        {
            return Natives.GetObjectName(objectId);
        }

        public Single Deg2Rad(Single degrees)
        {
            return Natives.Deg2Rad(degrees);
        }

        public Single Rad2Deg(Single radians)
        {
            return Natives.Rad2Deg(radians);
        }

        public Single Sin(Single radians)
        {
            return Natives.Sin(radians);
        }

        public Single Cos(Single radians)
        {
            return Natives.Cos(radians);
        }

        public Single Tan(Single radians)
        {
            return Natives.Tan(radians);
        }

        public Single Asin(Single y)
        {
            return Natives.Asin(y);
        }

        public Single Acos(Single x)
        {
            return Natives.Acos(x);
        }

        public Single Atan(Single x)
        {
            return Natives.Atan(x);
        }

        public Single Atan2(Single y, Single x)
        {
            return Natives.Atan2(y, x);
        }

        public Single SquareRoot(Single x)
        {
            return Natives.SquareRoot(x);
        }

        public Single Pow(Single x, Single power)
        {
            return Natives.Pow(x, power);
        }

        public Single I2R(JassInteger i)
        {
            return Natives.I2R(i);
        }

        public JassInteger R2I(Single r)
        {
            return Natives.R2I(r);
        }

        public String I2S(JassInteger i)
        {
            return Natives.I2S(i);
        }

        public String R2S(Single r)
        {
            return Natives.R2S(r);
        }

        public String R2SW(Single r, JassInteger width, JassInteger precision)
        {
            return Natives.R2SW(r, width, precision);
        }

        public JassInteger S2I(String s)
        {
            return Natives.S2I(s);
        }

        public Single S2R(String s)
        {
            return Natives.S2R(s);
        }

        public JassInteger GetHandleId(JassHandle h)
        {
            return Natives.GetHandleId(h);
        }

        public String SubString(String source, JassInteger start, JassInteger end)
        {
            return Natives.SubString(source, start, end);
        }

        public JassInteger StringLength(String s)
        {
            return Natives.StringLength(s);
        }

        public String StringCase(String source, Boolean upper)
        {
            return Natives.StringCase(source, upper);
        }

        public JassInteger StringHash(String s)
        {
            return Natives.StringHash(s);
        }

        public String GetLocalizedString(String source)
        {
            return Natives.GetLocalizedString(source);
        }

        public JassInteger GetLocalizedHotkey(String source)
        {
            return Natives.GetLocalizedHotkey(source);
        }

        public void SetMapName(String name)
        {
            Natives.SetMapName(name);
        }

        public void SetMapDescription(String description)
        {
            Natives.SetMapDescription(description);
        }

        public void SetTeams(JassInteger teamcount)
        {
            Natives.SetTeams(teamcount);
        }

        public void SetPlayers(JassInteger playercount)
        {
            Natives.SetPlayers(playercount);
        }

        public void DefineStartLocation(JassInteger whichStartLoc, Single x, Single y)
        {
            Natives.DefineStartLocation(whichStartLoc, x, y);
        }

        public void DefineStartLocationLoc(JassInteger whichStartLoc, JassLocation whichLocation)
        {
            Natives.DefineStartLocationLoc(whichStartLoc, whichLocation);
        }

        public void SetStartLocPrioCount(JassInteger whichStartLoc, JassInteger prioSlotCount)
        {
            Natives.SetStartLocPrioCount(whichStartLoc, prioSlotCount);
        }

        public void SetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex, JassInteger otherStartLocIndex, JassStartLocationPriority priority)
        {
            Natives.SetStartLocPrio(whichStartLoc, prioSlotIndex, otherStartLocIndex, priority);
        }

        public JassInteger GetStartLocPrioSlot(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return Natives.GetStartLocPrioSlot(whichStartLoc, prioSlotIndex);
        }

        public JassStartLocationPriority GetStartLocPrio(JassInteger whichStartLoc, JassInteger prioSlotIndex)
        {
            return Natives.GetStartLocPrio(whichStartLoc, prioSlotIndex);
        }

        public void SetGameTypeSupported(JassGameType whichGameType, Boolean value)
        {
            Natives.SetGameTypeSupported(whichGameType, value);
        }

        public void SetMapFlag(JassMapFlag whichMapFlag, Boolean value)
        {
            Natives.SetMapFlag(whichMapFlag, value);
        }

        public void SetGamePlacement(JassPlacement whichPlacementType)
        {
            Natives.SetGamePlacement(whichPlacementType);
        }

        public void SetGameSpeed(JassGameSpeed whichspeed)
        {
            Natives.SetGameSpeed(whichspeed);
        }

        public void SetGameDifficulty(JassGameDifficulty whichdifficulty)
        {
            Natives.SetGameDifficulty(whichdifficulty);
        }

        public void SetResourceDensity(JassMapDensity whichdensity)
        {
            Natives.SetResourceDensity(whichdensity);
        }

        public void SetCreatureDensity(JassMapDensity whichdensity)
        {
            Natives.SetCreatureDensity(whichdensity);
        }

        public JassInteger GetTeams()
        {
            return Natives.GetTeams();
        }

        public JassInteger GetPlayers()
        {
            return Natives.GetPlayers();
        }

        public Boolean IsGameTypeSupported(JassGameType whichGameType)
        {
            return Natives.IsGameTypeSupported(whichGameType);
        }

        public JassGameType GetGameTypeSelected()
        {
            return Natives.GetGameTypeSelected();
        }

        public Boolean IsMapFlagSet(JassMapFlag whichMapFlag)
        {
            return Natives.IsMapFlagSet(whichMapFlag);
        }

        public JassPlacement GetGamePlacement()
        {
            return Natives.GetGamePlacement();
        }

        public JassGameSpeed GetGameSpeed()
        {
            return Natives.GetGameSpeed();
        }

        public JassGameDifficulty GetGameDifficulty()
        {
            return Natives.GetGameDifficulty();
        }

        public JassMapDensity GetResourceDensity()
        {
            return Natives.GetResourceDensity();
        }

        public JassMapDensity GetCreatureDensity()
        {
            return Natives.GetCreatureDensity();
        }

        public Single GetStartLocationX(JassInteger whichStartLocation)
        {
            return Natives.GetStartLocationX(whichStartLocation);
        }

        public Single GetStartLocationY(JassInteger whichStartLocation)
        {
            return Natives.GetStartLocationY(whichStartLocation);
        }

        public JassLocation GetStartLocationLoc(JassInteger whichStartLocation)
        {
            return Natives.GetStartLocationLoc(whichStartLocation);
        }

        public void SetPlayerTeam(JassPlayer whichPlayer, JassInteger whichTeam)
        {
            Natives.SetPlayerTeam(whichPlayer, whichTeam);
        }

        public void SetPlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            Natives.SetPlayerStartLocation(whichPlayer, startLocIndex);
        }

        public void ForcePlayerStartLocation(JassPlayer whichPlayer, JassInteger startLocIndex)
        {
            Natives.ForcePlayerStartLocation(whichPlayer, startLocIndex);
        }

        public void SetPlayerColor(JassPlayer whichPlayer, JassPlayerColor color)
        {
            Natives.SetPlayerColor(whichPlayer, color);
        }

        public void SetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting, Boolean value)
        {
            Natives.SetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting, value);
        }

        public void SetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource, JassInteger rate)
        {
            Natives.SetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource, rate);
        }

        public void SetPlayerRacePreference(JassPlayer whichPlayer, JassRacePreference whichRacePreference)
        {
            Natives.SetPlayerRacePreference(whichPlayer, whichRacePreference);
        }

        public void SetPlayerRaceSelectable(JassPlayer whichPlayer, Boolean value)
        {
            Natives.SetPlayerRaceSelectable(whichPlayer, value);
        }

        public void SetPlayerController(JassPlayer whichPlayer, JassMapControl controlType)
        {
            Natives.SetPlayerController(whichPlayer, controlType);
        }

        public void SetPlayerName(JassPlayer whichPlayer, String name)
        {
            Natives.SetPlayerName(whichPlayer, name);
        }

        public void SetPlayerOnScoreScreen(JassPlayer whichPlayer, Boolean flag)
        {
            Natives.SetPlayerOnScoreScreen(whichPlayer, flag);
        }

        public JassInteger GetPlayerTeam(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerTeam(whichPlayer);
        }

        public JassInteger GetPlayerStartLocation(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerStartLocation(whichPlayer);
        }

        public JassPlayerColor GetPlayerColor(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerColor(whichPlayer);
        }

        public Boolean GetPlayerSelectable(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerSelectable(whichPlayer);
        }

        public JassMapControl GetPlayerController(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerController(whichPlayer);
        }

        public JassPlayerSlotState GetPlayerSlotState(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerSlotState(whichPlayer);
        }

        public JassInteger GetPlayerTaxRate(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassPlayerState whichResource)
        {
            return Natives.GetPlayerTaxRate(sourcePlayer, otherPlayer, whichResource);
        }

        public Boolean IsPlayerRacePrefSet(JassPlayer whichPlayer, JassRacePreference pref)
        {
            return Natives.IsPlayerRacePrefSet(whichPlayer, pref);
        }

        public String GetPlayerName(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerName(whichPlayer);
        }

        public JassTimer CreateTimer()
        {
            return Natives.CreateTimer();
        }

        public void DestroyTimer(JassTimer whichTimer)
        {
            Natives.DestroyTimer(whichTimer);
        }

        public void TimerStart(JassTimer whichTimer, Single timeout, Boolean periodic, JassCode handlerFunc)
        {
            Natives.TimerStart(whichTimer, timeout, periodic, handlerFunc);
        }

        public Single TimerGetElapsed(JassTimer whichTimer)
        {
            return Natives.TimerGetElapsed(whichTimer);
        }

        public Single TimerGetRemaining(JassTimer whichTimer)
        {
            return Natives.TimerGetRemaining(whichTimer);
        }

        public Single TimerGetTimeout(JassTimer whichTimer)
        {
            return Natives.TimerGetTimeout(whichTimer);
        }

        public void PauseTimer(JassTimer whichTimer)
        {
            Natives.PauseTimer(whichTimer);
        }

        public void ResumeTimer(JassTimer whichTimer)
        {
            Natives.ResumeTimer(whichTimer);
        }

        public JassTimer GetExpiredTimer()
        {
            return Natives.GetExpiredTimer();
        }

        public JassGroup CreateGroup()
        {
            return Natives.CreateGroup();
        }

        public void DestroyGroup(JassGroup whichGroup)
        {
            Natives.DestroyGroup(whichGroup);
        }

        public void GroupAddUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            Natives.GroupAddUnit(whichGroup, whichUnit);
        }

        public void GroupRemoveUnit(JassGroup whichGroup, JassUnit whichUnit)
        {
            Natives.GroupRemoveUnit(whichGroup, whichUnit);
        }

        public void GroupClear(JassGroup whichGroup)
        {
            Natives.GroupClear(whichGroup);
        }

        public void GroupEnumUnitsOfType(JassGroup whichGroup, String unitname, JassBooleanExpression filter)
        {
            Natives.GroupEnumUnitsOfType(whichGroup, unitname, filter);
        }

        public void GroupEnumUnitsOfPlayer(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives.GroupEnumUnitsOfPlayer(whichGroup, whichPlayer, filter);
        }

        public void GroupEnumUnitsOfTypeCounted(JassGroup whichGroup, String unitname, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.GroupEnumUnitsOfTypeCounted(whichGroup, unitname, filter, countLimit);
        }

        public void GroupEnumUnitsInRect(JassGroup whichGroup, JassRect r, JassBooleanExpression filter)
        {
            Natives.GroupEnumUnitsInRect(whichGroup, r, filter);
        }

        public void GroupEnumUnitsInRectCounted(JassGroup whichGroup, JassRect r, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.GroupEnumUnitsInRectCounted(whichGroup, r, filter, countLimit);
        }

        public void GroupEnumUnitsInRange(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter)
        {
            Natives.GroupEnumUnitsInRange(whichGroup, x, y, radius, filter);
        }

        public void GroupEnumUnitsInRangeOfLoc(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter)
        {
            Natives.GroupEnumUnitsInRangeOfLoc(whichGroup, whichLocation, radius, filter);
        }

        public void GroupEnumUnitsInRangeCounted(JassGroup whichGroup, Single x, Single y, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.GroupEnumUnitsInRangeCounted(whichGroup, x, y, radius, filter, countLimit);
        }

        public void GroupEnumUnitsInRangeOfLocCounted(JassGroup whichGroup, JassLocation whichLocation, Single radius, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.GroupEnumUnitsInRangeOfLocCounted(whichGroup, whichLocation, radius, filter, countLimit);
        }

        public void GroupEnumUnitsSelected(JassGroup whichGroup, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives.GroupEnumUnitsSelected(whichGroup, whichPlayer, filter);
        }

        public Boolean GroupImmediateOrder(JassGroup whichGroup, String order)
        {
            return Natives.GroupImmediateOrder(whichGroup, order);
        }

        public Boolean GroupImmediateOrderById(JassGroup whichGroup, JassOrder order)
        {
            return Natives.GroupImmediateOrderById(whichGroup, order);
        }

        public Boolean GroupPointOrder(JassGroup whichGroup, String order, Single x, Single y)
        {
            return Natives.GroupPointOrder(whichGroup, order, x, y);
        }

        public Boolean GroupPointOrderLoc(JassGroup whichGroup, String order, JassLocation whichLocation)
        {
            return Natives.GroupPointOrderLoc(whichGroup, order, whichLocation);
        }

        public Boolean GroupPointOrderById(JassGroup whichGroup, JassOrder order, Single x, Single y)
        {
            return Natives.GroupPointOrderById(whichGroup, order, x, y);
        }

        public Boolean GroupPointOrderByIdLoc(JassGroup whichGroup, JassOrder order, JassLocation whichLocation)
        {
            return Natives.GroupPointOrderByIdLoc(whichGroup, order, whichLocation);
        }

        public Boolean GroupTargetOrder(JassGroup whichGroup, String order, JassWidget targetWidget)
        {
            return Natives.GroupTargetOrder(whichGroup, order, targetWidget);
        }

        public Boolean GroupTargetOrderById(JassGroup whichGroup, JassOrder order, JassWidget targetWidget)
        {
            return Natives.GroupTargetOrderById(whichGroup, order, targetWidget);
        }

        public void ForGroup(JassGroup whichGroup, JassCode callback)
        {
            Natives.ForGroup(whichGroup, callback);
        }

        public JassUnit FirstOfGroup(JassGroup whichGroup)
        {
            return Natives.FirstOfGroup(whichGroup);
        }

        public JassForce CreateForce()
        {
            return Natives.CreateForce();
        }

        public void DestroyForce(JassForce whichForce)
        {
            Natives.DestroyForce(whichForce);
        }

        public void ForceAddPlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            Natives.ForceAddPlayer(whichForce, whichPlayer);
        }

        public void ForceRemovePlayer(JassForce whichForce, JassPlayer whichPlayer)
        {
            Natives.ForceRemovePlayer(whichForce, whichPlayer);
        }

        public void ForceClear(JassForce whichForce)
        {
            Natives.ForceClear(whichForce);
        }

        public void ForceEnumPlayers(JassForce whichForce, JassBooleanExpression filter)
        {
            Natives.ForceEnumPlayers(whichForce, filter);
        }

        public void ForceEnumPlayersCounted(JassForce whichForce, JassBooleanExpression filter, JassInteger countLimit)
        {
            Natives.ForceEnumPlayersCounted(whichForce, filter, countLimit);
        }

        public void ForceEnumAllies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives.ForceEnumAllies(whichForce, whichPlayer, filter);
        }

        public void ForceEnumEnemies(JassForce whichForce, JassPlayer whichPlayer, JassBooleanExpression filter)
        {
            Natives.ForceEnumEnemies(whichForce, whichPlayer, filter);
        }

        public void ForForce(JassForce whichForce, JassCode callback)
        {
            Natives.ForForce(whichForce, callback);
        }

        public JassRect Rect(Single minx, Single miny, Single maxx, Single maxy)
        {
            return Natives.Rect(minx, miny, maxx, maxy);
        }

        public JassRect RectFromLoc(JassLocation min, JassLocation max)
        {
            return Natives.RectFromLoc(min, max);
        }

        public void RemoveRect(JassRect whichRect)
        {
            Natives.RemoveRect(whichRect);
        }

        public void SetRect(JassRect whichRect, Single minx, Single miny, Single maxx, Single maxy)
        {
            Natives.SetRect(whichRect, minx, miny, maxx, maxy);
        }

        public void SetRectFromLoc(JassRect whichRect, JassLocation min, JassLocation max)
        {
            Natives.SetRectFromLoc(whichRect, min, max);
        }

        public void MoveRectTo(JassRect whichRect, Single newCenterX, Single newCenterY)
        {
            Natives.MoveRectTo(whichRect, newCenterX, newCenterY);
        }

        public void MoveRectToLoc(JassRect whichRect, JassLocation newCenterLoc)
        {
            Natives.MoveRectToLoc(whichRect, newCenterLoc);
        }

        public Single GetRectCenterX(JassRect whichRect)
        {
            return Natives.GetRectCenterX(whichRect);
        }

        public Single GetRectCenterY(JassRect whichRect)
        {
            return Natives.GetRectCenterY(whichRect);
        }

        public Single GetRectMinX(JassRect whichRect)
        {
            return Natives.GetRectMinX(whichRect);
        }

        public Single GetRectMinY(JassRect whichRect)
        {
            return Natives.GetRectMinY(whichRect);
        }

        public Single GetRectMaxX(JassRect whichRect)
        {
            return Natives.GetRectMaxX(whichRect);
        }

        public Single GetRectMaxY(JassRect whichRect)
        {
            return Natives.GetRectMaxY(whichRect);
        }

        public JassRegion CreateRegion()
        {
            return Natives.CreateRegion();
        }

        public void RemoveRegion(JassRegion whichRegion)
        {
            Natives.RemoveRegion(whichRegion);
        }

        public void RegionAddRect(JassRegion whichRegion, JassRect r)
        {
            Natives.RegionAddRect(whichRegion, r);
        }

        public void RegionClearRect(JassRegion whichRegion, JassRect r)
        {
            Natives.RegionClearRect(whichRegion, r);
        }

        public void RegionAddCell(JassRegion whichRegion, Single x, Single y)
        {
            Natives.RegionAddCell(whichRegion, x, y);
        }

        public void RegionAddCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            Natives.RegionAddCellAtLoc(whichRegion, whichLocation);
        }

        public void RegionClearCell(JassRegion whichRegion, Single x, Single y)
        {
            Natives.RegionClearCell(whichRegion, x, y);
        }

        public void RegionClearCellAtLoc(JassRegion whichRegion, JassLocation whichLocation)
        {
            Natives.RegionClearCellAtLoc(whichRegion, whichLocation);
        }

        public JassLocation Location(Single x, Single y)
        {
            return Natives.Location(x, y);
        }

        public void RemoveLocation(JassLocation whichLocation)
        {
            Natives.RemoveLocation(whichLocation);
        }

        public void MoveLocation(JassLocation whichLocation, Single newX, Single newY)
        {
            Natives.MoveLocation(whichLocation, newX, newY);
        }

        public Single GetLocationX(JassLocation whichLocation)
        {
            return Natives.GetLocationX(whichLocation);
        }

        public Single GetLocationY(JassLocation whichLocation)
        {
            return Natives.GetLocationY(whichLocation);
        }

        public Single GetLocationZ(JassLocation whichLocation)
        {
            return Natives.GetLocationZ(whichLocation);
        }

        public Boolean IsUnitInRegion(JassRegion whichRegion, JassUnit whichUnit)
        {
            return Natives.IsUnitInRegion(whichRegion, whichUnit);
        }

        public Boolean IsPointInRegion(JassRegion whichRegion, Single x, Single y)
        {
            return Natives.IsPointInRegion(whichRegion, x, y);
        }

        public Boolean IsLocationInRegion(JassRegion whichRegion, JassLocation whichLocation)
        {
            return Natives.IsLocationInRegion(whichRegion, whichLocation);
        }

        public JassRect GetWorldBounds()
        {
            return Natives.GetWorldBounds();
        }

        public JassTrigger CreateTrigger()
        {
            return Natives.CreateTrigger();
        }

        public void DestroyTrigger(JassTrigger whichTrigger)
        {
            Natives.DestroyTrigger(whichTrigger);
        }

        public void ResetTrigger(JassTrigger whichTrigger)
        {
            Natives.ResetTrigger(whichTrigger);
        }

        public void EnableTrigger(JassTrigger whichTrigger)
        {
            Natives.EnableTrigger(whichTrigger);
        }

        public void DisableTrigger(JassTrigger whichTrigger)
        {
            Natives.DisableTrigger(whichTrigger);
        }

        public Boolean IsTriggerEnabled(JassTrigger whichTrigger)
        {
            return Natives.IsTriggerEnabled(whichTrigger);
        }

        public void TriggerWaitOnSleeps(JassTrigger whichTrigger, Boolean flag)
        {
            Natives.TriggerWaitOnSleeps(whichTrigger, flag);
        }

        public Boolean IsTriggerWaitOnSleeps(JassTrigger whichTrigger)
        {
            return Natives.IsTriggerWaitOnSleeps(whichTrigger);
        }

        public JassUnit GetFilterUnit()
        {
            return Natives.GetFilterUnit();
        }

        public JassUnit GetEnumUnit()
        {
            return Natives.GetEnumUnit();
        }

        public JassDestructable GetFilterDestructable()
        {
            return Natives.GetFilterDestructable();
        }

        public JassDestructable GetEnumDestructable()
        {
            return Natives.GetEnumDestructable();
        }

        public JassItem GetFilterItem()
        {
            return Natives.GetFilterItem();
        }

        public JassItem GetEnumItem()
        {
            return Natives.GetEnumItem();
        }

        public JassPlayer GetFilterPlayer()
        {
            return Natives.GetFilterPlayer();
        }

        public JassPlayer GetEnumPlayer()
        {
            return Natives.GetEnumPlayer();
        }

        public JassTrigger GetTriggeringTrigger()
        {
            return Natives.GetTriggeringTrigger();
        }

        public JassEventIndex GetTriggerEventId()
        {
            return Natives.GetTriggerEventId();
        }

        public JassInteger GetTriggerEvalCount(JassTrigger whichTrigger)
        {
            return Natives.GetTriggerEvalCount(whichTrigger);
        }

        public JassInteger GetTriggerExecCount(JassTrigger whichTrigger)
        {
            return Natives.GetTriggerExecCount(whichTrigger);
        }

        public void ExecuteFunc(String funcName)
        {
            Natives.ExecuteFunc(funcName);
        }

        public JassBooleanExpression And(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return Natives.And(operandA, operandB);
        }

        public JassBooleanExpression Or(JassBooleanExpression operandA, JassBooleanExpression operandB)
        {
            return Natives.Or(operandA, operandB);
        }

        public JassBooleanExpression Not(JassBooleanExpression operand)
        {
            return Natives.Not(operand);
        }

        public JassConditionFunction Condition(JassCode func)
        {
            return Natives.Condition(func);
        }

        public void DestroyCondition(JassConditionFunction c)
        {
            Natives.DestroyCondition(c);
        }

        public JassFilterFunction Filter(JassCode func)
        {
            return Natives.Filter(func);
        }

        public void DestroyFilter(JassFilterFunction f)
        {
            Natives.DestroyFilter(f);
        }

        public void DestroyBoolExpr(JassBooleanExpression e)
        {
            Natives.DestroyBoolExpr(e);
        }

        public JassEvent TriggerRegisterVariableEvent(JassTrigger whichTrigger, String varName, JassLimitOp opcode, Single limitval)
        {
            return Natives.TriggerRegisterVariableEvent(whichTrigger, varName, opcode, limitval);
        }

        public JassEvent TriggerRegisterTimerEvent(JassTrigger whichTrigger, Single timeout, Boolean periodic)
        {
            return Natives.TriggerRegisterTimerEvent(whichTrigger, timeout, periodic);
        }

        public JassEvent TriggerRegisterTimerExpireEvent(JassTrigger whichTrigger, JassTimer t)
        {
            return Natives.TriggerRegisterTimerExpireEvent(whichTrigger, t);
        }

        public JassEvent TriggerRegisterGameStateEvent(JassTrigger whichTrigger, JassGameState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives.TriggerRegisterGameStateEvent(whichTrigger, whichState, opcode, limitval);
        }

        public JassEvent TriggerRegisterDialogEvent(JassTrigger whichTrigger, JassDialog whichDialog)
        {
            return Natives.TriggerRegisterDialogEvent(whichTrigger, whichDialog);
        }

        public JassEvent TriggerRegisterDialogButtonEvent(JassTrigger whichTrigger, JassButton whichButton)
        {
            return Natives.TriggerRegisterDialogButtonEvent(whichTrigger, whichButton);
        }

        public JassGameState GetEventGameState()
        {
            return Natives.GetEventGameState();
        }

        public JassEvent TriggerRegisterGameEvent(JassTrigger whichTrigger, JassGameEvent whichGameEvent)
        {
            return Natives.TriggerRegisterGameEvent(whichTrigger, whichGameEvent);
        }

        public JassPlayer GetWinningPlayer()
        {
            return Natives.GetWinningPlayer();
        }

        public JassEvent TriggerRegisterEnterRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return Natives.TriggerRegisterEnterRegion(whichTrigger, whichRegion, filter);
        }

        public JassRegion GetTriggeringRegion()
        {
            return Natives.GetTriggeringRegion();
        }

        public JassUnit GetEnteringUnit()
        {
            return Natives.GetEnteringUnit();
        }

        public JassEvent TriggerRegisterLeaveRegion(JassTrigger whichTrigger, JassRegion whichRegion, JassBooleanExpression filter)
        {
            return Natives.TriggerRegisterLeaveRegion(whichTrigger, whichRegion, filter);
        }

        public JassUnit GetLeavingUnit()
        {
            return Natives.GetLeavingUnit();
        }

        public JassEvent TriggerRegisterTrackableHitEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return Natives.TriggerRegisterTrackableHitEvent(whichTrigger, t);
        }

        public JassEvent TriggerRegisterTrackableTrackEvent(JassTrigger whichTrigger, JassTrackable t)
        {
            return Natives.TriggerRegisterTrackableTrackEvent(whichTrigger, t);
        }

        public JassTrackable GetTriggeringTrackable()
        {
            return Natives.GetTriggeringTrackable();
        }

        public JassButton GetClickedButton()
        {
            return Natives.GetClickedButton();
        }

        public JassDialog GetClickedDialog()
        {
            return Natives.GetClickedDialog();
        }

        public Single GetTournamentFinishSoonTimeRemaining()
        {
            return Natives.GetTournamentFinishSoonTimeRemaining();
        }

        public JassInteger GetTournamentFinishNowRule()
        {
            return Natives.GetTournamentFinishNowRule();
        }

        public JassPlayer GetTournamentFinishNowPlayer()
        {
            return Natives.GetTournamentFinishNowPlayer();
        }

        public JassInteger GetTournamentScore(JassPlayer whichPlayer)
        {
            return Natives.GetTournamentScore(whichPlayer);
        }

        public String GetSaveBasicFilename()
        {
            return Natives.GetSaveBasicFilename();
        }

        public JassEvent TriggerRegisterPlayerEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerEvent whichPlayerEvent)
        {
            return Natives.TriggerRegisterPlayerEvent(whichTrigger, whichPlayer, whichPlayerEvent);
        }

        public JassPlayer GetTriggerPlayer()
        {
            return Natives.GetTriggerPlayer();
        }

        public JassEvent TriggerRegisterPlayerUnitEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerUnitEvent whichPlayerUnitEvent, JassBooleanExpression filter)
        {
            return Natives.TriggerRegisterPlayerUnitEvent(whichTrigger, whichPlayer, whichPlayerUnitEvent, filter);
        }

        public JassUnit GetLevelingUnit()
        {
            return Natives.GetLevelingUnit();
        }

        public JassUnit GetLearningUnit()
        {
            return Natives.GetLearningUnit();
        }

        public JassInteger GetLearnedSkill()
        {
            return Natives.GetLearnedSkill();
        }

        public JassInteger GetLearnedSkillLevel()
        {
            return Natives.GetLearnedSkillLevel();
        }

        public JassUnit GetRevivableUnit()
        {
            return Natives.GetRevivableUnit();
        }

        public JassUnit GetRevivingUnit()
        {
            return Natives.GetRevivingUnit();
        }

        public JassUnit GetAttacker()
        {
            return Natives.GetAttacker();
        }

        public JassUnit GetRescuer()
        {
            return Natives.GetRescuer();
        }

        public JassUnit GetDyingUnit()
        {
            return Natives.GetDyingUnit();
        }

        public JassUnit GetKillingUnit()
        {
            return Natives.GetKillingUnit();
        }

        public JassUnit GetDecayingUnit()
        {
            return Natives.GetDecayingUnit();
        }

        public JassUnit GetConstructingStructure()
        {
            return Natives.GetConstructingStructure();
        }

        public JassUnit GetCancelledStructure()
        {
            return Natives.GetCancelledStructure();
        }

        public JassUnit GetConstructedStructure()
        {
            return Natives.GetConstructedStructure();
        }

        public JassUnit GetResearchingUnit()
        {
            return Natives.GetResearchingUnit();
        }

        public JassInteger GetResearched()
        {
            return Natives.GetResearched();
        }

        public JassInteger GetTrainedUnitType()
        {
            return Natives.GetTrainedUnitType();
        }

        public JassUnit GetTrainedUnit()
        {
            return Natives.GetTrainedUnit();
        }

        public JassUnit GetDetectedUnit()
        {
            return Natives.GetDetectedUnit();
        }

        public JassUnit GetSummoningUnit()
        {
            return Natives.GetSummoningUnit();
        }

        public JassUnit GetSummonedUnit()
        {
            return Natives.GetSummonedUnit();
        }

        public JassUnit GetTransportUnit()
        {
            return Natives.GetTransportUnit();
        }

        public JassUnit GetLoadedUnit()
        {
            return Natives.GetLoadedUnit();
        }

        public JassUnit GetSellingUnit()
        {
            return Natives.GetSellingUnit();
        }

        public JassUnit GetSoldUnit()
        {
            return Natives.GetSoldUnit();
        }

        public JassUnit GetBuyingUnit()
        {
            return Natives.GetBuyingUnit();
        }

        public JassItem GetSoldItem()
        {
            return Natives.GetSoldItem();
        }

        public JassUnit GetChangingUnit()
        {
            return Natives.GetChangingUnit();
        }

        public JassPlayer GetChangingUnitPrevOwner()
        {
            return Natives.GetChangingUnitPrevOwner();
        }

        public JassUnit GetManipulatingUnit()
        {
            return Natives.GetManipulatingUnit();
        }

        public JassItem GetManipulatedItem()
        {
            return Natives.GetManipulatedItem();
        }

        public JassUnit GetOrderedUnit()
        {
            return Natives.GetOrderedUnit();
        }

        public JassOrder GetIssuedOrderId()
        {
            return Natives.GetIssuedOrderId();
        }

        public Single GetOrderPointX()
        {
            return Natives.GetOrderPointX();
        }

        public Single GetOrderPointY()
        {
            return Natives.GetOrderPointY();
        }

        public JassLocation GetOrderPointLoc()
        {
            return Natives.GetOrderPointLoc();
        }

        public JassWidget GetOrderTarget()
        {
            return Natives.GetOrderTarget();
        }

        public JassDestructable GetOrderTargetDestructable()
        {
            return Natives.GetOrderTargetDestructable();
        }

        public JassItem GetOrderTargetItem()
        {
            return Natives.GetOrderTargetItem();
        }

        public JassUnit GetOrderTargetUnit()
        {
            return Natives.GetOrderTargetUnit();
        }

        public JassUnit GetSpellAbilityUnit()
        {
            return Natives.GetSpellAbilityUnit();
        }

        public JassObjectId GetSpellAbilityId()
        {
            return Natives.GetSpellAbilityId();
        }

        public JassAbility GetSpellAbility()
        {
            return Natives.GetSpellAbility();
        }

        public JassLocation GetSpellTargetLoc()
        {
            return Natives.GetSpellTargetLoc();
        }

        public Single GetSpellTargetX()
        {
            return Natives.GetSpellTargetX();
        }

        public Single GetSpellTargetY()
        {
            return Natives.GetSpellTargetY();
        }

        public JassDestructable GetSpellTargetDestructable()
        {
            return Natives.GetSpellTargetDestructable();
        }

        public JassItem GetSpellTargetItem()
        {
            return Natives.GetSpellTargetItem();
        }

        public JassUnit GetSpellTargetUnit()
        {
            return Natives.GetSpellTargetUnit();
        }

        public JassEvent TriggerRegisterPlayerAllianceChange(JassTrigger whichTrigger, JassPlayer whichPlayer, JassAllianceType whichAlliance)
        {
            return Natives.TriggerRegisterPlayerAllianceChange(whichTrigger, whichPlayer, whichAlliance);
        }

        public JassEvent TriggerRegisterPlayerStateEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, JassPlayerState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives.TriggerRegisterPlayerStateEvent(whichTrigger, whichPlayer, whichState, opcode, limitval);
        }

        public JassPlayerState GetEventPlayerState()
        {
            return Natives.GetEventPlayerState();
        }

        public JassEvent TriggerRegisterPlayerChatEvent(JassTrigger whichTrigger, JassPlayer whichPlayer, String chatMessageToDetect, Boolean exactMatchOnly)
        {
            return Natives.TriggerRegisterPlayerChatEvent(whichTrigger, whichPlayer, chatMessageToDetect, exactMatchOnly);
        }

        public String GetEventPlayerChatString()
        {
            return Natives.GetEventPlayerChatString();
        }

        public String GetEventPlayerChatStringMatched()
        {
            return Natives.GetEventPlayerChatStringMatched();
        }

        public JassEvent TriggerRegisterDeathEvent(JassTrigger whichTrigger, JassWidget whichWidget)
        {
            return Natives.TriggerRegisterDeathEvent(whichTrigger, whichWidget);
        }

        public JassUnit GetTriggerUnit()
        {
            return Natives.GetTriggerUnit();
        }

        public JassEvent TriggerRegisterUnitStateEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitState whichState, JassLimitOp opcode, Single limitval)
        {
            return Natives.TriggerRegisterUnitStateEvent(whichTrigger, whichUnit, whichState, opcode, limitval);
        }

        public JassUnitState GetEventUnitState()
        {
            return Natives.GetEventUnitState();
        }

        public JassEvent TriggerRegisterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent)
        {
            return Natives.TriggerRegisterUnitEvent(whichTrigger, whichUnit, whichEvent);
        }

        public Single GetEventDamage()
        {
            return Natives.GetEventDamage();
        }

        public JassUnit GetEventDamageSource()
        {
            return Natives.GetEventDamageSource();
        }

        public JassPlayer GetEventDetectingPlayer()
        {
            return Natives.GetEventDetectingPlayer();
        }

        public JassEvent TriggerRegisterFilterUnitEvent(JassTrigger whichTrigger, JassUnit whichUnit, JassUnitEvent whichEvent, JassBooleanExpression filter)
        {
            return Natives.TriggerRegisterFilterUnitEvent(whichTrigger, whichUnit, whichEvent, filter);
        }

        public JassUnit GetEventTargetUnit()
        {
            return Natives.GetEventTargetUnit();
        }

        public JassEvent TriggerRegisterUnitInRange(JassTrigger whichTrigger, JassUnit whichUnit, Single range, JassBooleanExpression filter)
        {
            return Natives.TriggerRegisterUnitInRange(whichTrigger, whichUnit, range, filter);
        }

        public JassTriggerCondition TriggerAddCondition(JassTrigger whichTrigger, JassBooleanExpression condition)
        {
            return Natives.TriggerAddCondition(whichTrigger, condition);
        }

        public void TriggerRemoveCondition(JassTrigger whichTrigger, JassTriggerCondition whichCondition)
        {
            Natives.TriggerRemoveCondition(whichTrigger, whichCondition);
        }

        public void TriggerClearConditions(JassTrigger whichTrigger)
        {
            Natives.TriggerClearConditions(whichTrigger);
        }

        public JassTriggerAction TriggerAddAction(JassTrigger whichTrigger, JassCode actionFunc)
        {
            return Natives.TriggerAddAction(whichTrigger, actionFunc);
        }

        public void TriggerRemoveAction(JassTrigger whichTrigger, JassTriggerAction whichAction)
        {
            Natives.TriggerRemoveAction(whichTrigger, whichAction);
        }

        public void TriggerClearActions(JassTrigger whichTrigger)
        {
            Natives.TriggerClearActions(whichTrigger);
        }

        public void TriggerSleepAction(Single timeout)
        {
            Natives.TriggerSleepAction(timeout);
        }

        public void TriggerWaitForSound(JassSound s, Single offset)
        {
            Natives.TriggerWaitForSound(s, offset);
        }

        public Boolean TriggerEvaluate(JassTrigger whichTrigger)
        {
            return Natives.TriggerEvaluate(whichTrigger);
        }

        public void TriggerExecute(JassTrigger whichTrigger)
        {
            Natives.TriggerExecute(whichTrigger);
        }

        public void TriggerExecuteWait(JassTrigger whichTrigger)
        {
            Natives.TriggerExecuteWait(whichTrigger);
        }

        public void TriggerSyncStart()
        {
            Natives.TriggerSyncStart();
        }

        public void TriggerSyncReady()
        {
            Natives.TriggerSyncReady();
        }

        public Single GetWidgetLife(JassWidget whichWidget)
        {
            return Natives.GetWidgetLife(whichWidget);
        }

        public void SetWidgetLife(JassWidget whichWidget, Single newLife)
        {
            Natives.SetWidgetLife(whichWidget, newLife);
        }

        public Single GetWidgetX(JassWidget whichWidget)
        {
            return Natives.GetWidgetX(whichWidget);
        }

        public Single GetWidgetY(JassWidget whichWidget)
        {
            return Natives.GetWidgetY(whichWidget);
        }

        public JassWidget GetTriggerWidget()
        {
            return Natives.GetTriggerWidget();
        }

        public JassDestructable CreateDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return Natives.CreateDestructable(objectid, x, y, face, scale, variation);
        }

        public JassDestructable CreateDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return Natives.CreateDestructableZ(objectid, x, y, z, face, scale, variation);
        }

        public JassDestructable CreateDeadDestructable(JassObjectId objectid, Single x, Single y, Single face, Single scale, JassInteger variation)
        {
            return Natives.CreateDeadDestructable(objectid, x, y, face, scale, variation);
        }

        public JassDestructable CreateDeadDestructableZ(JassObjectId objectid, Single x, Single y, Single z, Single face, Single scale, JassInteger variation)
        {
            return Natives.CreateDeadDestructableZ(objectid, x, y, z, face, scale, variation);
        }

        public void RemoveDestructable(JassDestructable d)
        {
            Natives.RemoveDestructable(d);
        }

        public void KillDestructable(JassDestructable d)
        {
            Natives.KillDestructable(d);
        }

        public void SetDestructableInvulnerable(JassDestructable d, Boolean flag)
        {
            Natives.SetDestructableInvulnerable(d, flag);
        }

        public Boolean IsDestructableInvulnerable(JassDestructable d)
        {
            return Natives.IsDestructableInvulnerable(d);
        }

        public void EnumDestructablesInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            Natives.EnumDestructablesInRect(r, filter, actionFunc);
        }

        public JassObjectId GetDestructableTypeId(JassDestructable d)
        {
            return Natives.GetDestructableTypeId(d);
        }

        public Single GetDestructableX(JassDestructable d)
        {
            return Natives.GetDestructableX(d);
        }

        public Single GetDestructableY(JassDestructable d)
        {
            return Natives.GetDestructableY(d);
        }

        public void SetDestructableLife(JassDestructable d, Single life)
        {
            Natives.SetDestructableLife(d, life);
        }

        public Single GetDestructableLife(JassDestructable d)
        {
            return Natives.GetDestructableLife(d);
        }

        public void SetDestructableMaxLife(JassDestructable d, Single max)
        {
            Natives.SetDestructableMaxLife(d, max);
        }

        public Single GetDestructableMaxLife(JassDestructable d)
        {
            return Natives.GetDestructableMaxLife(d);
        }

        public void DestructableRestoreLife(JassDestructable d, Single life, Boolean birth)
        {
            Natives.DestructableRestoreLife(d, life, birth);
        }

        public void QueueDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            Natives.QueueDestructableAnimation(d, whichAnimation);
        }

        public void SetDestructableAnimation(JassDestructable d, String whichAnimation)
        {
            Natives.SetDestructableAnimation(d, whichAnimation);
        }

        public void SetDestructableAnimationSpeed(JassDestructable d, Single speedFactor)
        {
            Natives.SetDestructableAnimationSpeed(d, speedFactor);
        }

        public void ShowDestructable(JassDestructable d, Boolean flag)
        {
            Natives.ShowDestructable(d, flag);
        }

        public Single GetDestructableOccluderHeight(JassDestructable d)
        {
            return Natives.GetDestructableOccluderHeight(d);
        }

        public void SetDestructableOccluderHeight(JassDestructable d, Single height)
        {
            Natives.SetDestructableOccluderHeight(d, height);
        }

        public String GetDestructableName(JassDestructable d)
        {
            return Natives.GetDestructableName(d);
        }

        public JassDestructable GetTriggerDestructable()
        {
            return Natives.GetTriggerDestructable();
        }

        public JassItem CreateItem(JassObjectId itemid, Single x, Single y)
        {
            return Natives.CreateItem(itemid, x, y);
        }

        public void RemoveItem(JassItem whichItem)
        {
            Natives.RemoveItem(whichItem);
        }

        public JassPlayer GetItemPlayer(JassItem whichItem)
        {
            return Natives.GetItemPlayer(whichItem);
        }

        public JassObjectId GetItemTypeId(JassItem i)
        {
            return Natives.GetItemTypeId(i);
        }

        public Single GetItemX(JassItem i)
        {
            return Natives.GetItemX(i);
        }

        public Single GetItemY(JassItem i)
        {
            return Natives.GetItemY(i);
        }

        public void SetItemPosition(JassItem i, Single x, Single y)
        {
            Natives.SetItemPosition(i, x, y);
        }

        public void SetItemDropOnDeath(JassItem whichItem, Boolean flag)
        {
            Natives.SetItemDropOnDeath(whichItem, flag);
        }

        public void SetItemDroppable(JassItem i, Boolean flag)
        {
            Natives.SetItemDroppable(i, flag);
        }

        public void SetItemPawnable(JassItem i, Boolean flag)
        {
            Natives.SetItemPawnable(i, flag);
        }

        public void SetItemPlayer(JassItem whichItem, JassPlayer whichPlayer, Boolean changeColor)
        {
            Natives.SetItemPlayer(whichItem, whichPlayer, changeColor);
        }

        public void SetItemInvulnerable(JassItem whichItem, Boolean flag)
        {
            Natives.SetItemInvulnerable(whichItem, flag);
        }

        public Boolean IsItemInvulnerable(JassItem whichItem)
        {
            return Natives.IsItemInvulnerable(whichItem);
        }

        public void SetItemVisible(JassItem whichItem, Boolean show)
        {
            Natives.SetItemVisible(whichItem, show);
        }

        public Boolean IsItemVisible(JassItem whichItem)
        {
            return Natives.IsItemVisible(whichItem);
        }

        public Boolean IsItemOwned(JassItem whichItem)
        {
            return Natives.IsItemOwned(whichItem);
        }

        public Boolean IsItemPowerup(JassItem whichItem)
        {
            return Natives.IsItemPowerup(whichItem);
        }

        public Boolean IsItemSellable(JassItem whichItem)
        {
            return Natives.IsItemSellable(whichItem);
        }

        public Boolean IsItemPawnable(JassItem whichItem)
        {
            return Natives.IsItemPawnable(whichItem);
        }

        public Boolean IsItemIdPowerup(JassObjectId itemId)
        {
            return Natives.IsItemIdPowerup(itemId);
        }

        public Boolean IsItemIdSellable(JassObjectId itemId)
        {
            return Natives.IsItemIdSellable(itemId);
        }

        public Boolean IsItemIdPawnable(JassObjectId itemId)
        {
            return Natives.IsItemIdPawnable(itemId);
        }

        public void EnumItemsInRect(JassRect r, JassBooleanExpression filter, JassCode actionFunc)
        {
            Natives.EnumItemsInRect(r, filter, actionFunc);
        }

        public JassInteger GetItemLevel(JassItem whichItem)
        {
            return Natives.GetItemLevel(whichItem);
        }

        public JassItemType GetItemType(JassItem whichItem)
        {
            return Natives.GetItemType(whichItem);
        }

        public void SetItemDropID(JassItem whichItem, JassObjectId unitId)
        {
            Natives.SetItemDropID(whichItem, unitId);
        }

        public String GetItemName(JassItem whichItem)
        {
            return Natives.GetItemName(whichItem);
        }

        public JassInteger GetItemCharges(JassItem whichItem)
        {
            return Natives.GetItemCharges(whichItem);
        }

        public void SetItemCharges(JassItem whichItem, JassInteger charges)
        {
            Natives.SetItemCharges(whichItem, charges);
        }

        public JassInteger GetItemUserData(JassItem whichItem)
        {
            return Natives.GetItemUserData(whichItem);
        }

        public void SetItemUserData(JassItem whichItem, JassInteger data)
        {
            Natives.SetItemUserData(whichItem, data);
        }

        public JassUnit CreateUnit(JassPlayer id, JassObjectId unitid, Single x, Single y, Single face)
        {
            return Natives.CreateUnit(id, unitid, x, y, face);
        }

        public JassUnit CreateUnitByName(JassPlayer whichPlayer, String unitname, Single x, Single y, Single face)
        {
            return Natives.CreateUnitByName(whichPlayer, unitname, x, y, face);
        }

        public JassUnit CreateUnitAtLoc(JassPlayer id, JassObjectId unitid, JassLocation whichLocation, Single face)
        {
            return Natives.CreateUnitAtLoc(id, unitid, whichLocation, face);
        }

        public JassUnit CreateUnitAtLocByName(JassPlayer id, String unitname, JassLocation whichLocation, Single face)
        {
            return Natives.CreateUnitAtLocByName(id, unitname, whichLocation, face);
        }

        public JassUnit CreateCorpse(JassPlayer whichPlayer, JassObjectId unitid, Single x, Single y, Single face)
        {
            return Natives.CreateCorpse(whichPlayer, unitid, x, y, face);
        }

        public void KillUnit(JassUnit whichUnit)
        {
            Natives.KillUnit(whichUnit);
        }

        public void RemoveUnit(JassUnit whichUnit)
        {
            Natives.RemoveUnit(whichUnit);
        }

        public void ShowUnit(JassUnit whichUnit, Boolean show)
        {
            Natives.ShowUnit(whichUnit, show);
        }

        public void SetUnitState(JassUnit whichUnit, JassUnitState whichUnitState, Single newVal)
        {
            Natives.SetUnitState(whichUnit, whichUnitState, newVal);
        }

        public void SetUnitX(JassUnit whichUnit, Single newX)
        {
            Natives.SetUnitX(whichUnit, newX);
        }

        public void SetUnitY(JassUnit whichUnit, Single newY)
        {
            Natives.SetUnitY(whichUnit, newY);
        }

        public void SetUnitPosition(JassUnit whichUnit, Single newX, Single newY)
        {
            Natives.SetUnitPosition(whichUnit, newX, newY);
        }

        public void SetUnitPositionLoc(JassUnit whichUnit, JassLocation whichLocation)
        {
            Natives.SetUnitPositionLoc(whichUnit, whichLocation);
        }

        public void SetUnitFacing(JassUnit whichUnit, Single facingAngle)
        {
            Natives.SetUnitFacing(whichUnit, facingAngle);
        }

        public void SetUnitFacingTimed(JassUnit whichUnit, Single facingAngle, Single duration)
        {
            Natives.SetUnitFacingTimed(whichUnit, facingAngle, duration);
        }

        public void SetUnitMoveSpeed(JassUnit whichUnit, Single newSpeed)
        {
            Natives.SetUnitMoveSpeed(whichUnit, newSpeed);
        }

        public void SetUnitFlyHeight(JassUnit whichUnit, Single newHeight, Single rate)
        {
            Natives.SetUnitFlyHeight(whichUnit, newHeight, rate);
        }

        public void SetUnitTurnSpeed(JassUnit whichUnit, Single newTurnSpeed)
        {
            Natives.SetUnitTurnSpeed(whichUnit, newTurnSpeed);
        }

        public void SetUnitPropWindow(JassUnit whichUnit, Single newPropWindowAngle)
        {
            Natives.SetUnitPropWindow(whichUnit, newPropWindowAngle);
        }

        public void SetUnitAcquireRange(JassUnit whichUnit, Single newAcquireRange)
        {
            Natives.SetUnitAcquireRange(whichUnit, newAcquireRange);
        }

        public void SetUnitCreepGuard(JassUnit whichUnit, Boolean creepGuard)
        {
            Natives.SetUnitCreepGuard(whichUnit, creepGuard);
        }

        public Single GetUnitAcquireRange(JassUnit whichUnit)
        {
            return Natives.GetUnitAcquireRange(whichUnit);
        }

        public Single GetUnitTurnSpeed(JassUnit whichUnit)
        {
            return Natives.GetUnitTurnSpeed(whichUnit);
        }

        public Single GetUnitPropWindow(JassUnit whichUnit)
        {
            return Natives.GetUnitPropWindow(whichUnit);
        }

        public Single GetUnitFlyHeight(JassUnit whichUnit)
        {
            return Natives.GetUnitFlyHeight(whichUnit);
        }

        public Single GetUnitDefaultAcquireRange(JassUnit whichUnit)
        {
            return Natives.GetUnitDefaultAcquireRange(whichUnit);
        }

        public Single GetUnitDefaultTurnSpeed(JassUnit whichUnit)
        {
            return Natives.GetUnitDefaultTurnSpeed(whichUnit);
        }

        public Single GetUnitDefaultPropWindow(JassUnit whichUnit)
        {
            return Natives.GetUnitDefaultPropWindow(whichUnit);
        }

        public Single GetUnitDefaultFlyHeight(JassUnit whichUnit)
        {
            return Natives.GetUnitDefaultFlyHeight(whichUnit);
        }

        public void SetUnitOwner(JassUnit whichUnit, JassPlayer whichPlayer, Boolean changeColor)
        {
            Natives.SetUnitOwner(whichUnit, whichPlayer, changeColor);
        }

        public void SetUnitColor(JassUnit whichUnit, JassPlayerColor whichColor)
        {
            Natives.SetUnitColor(whichUnit, whichColor);
        }

        public void SetUnitScale(JassUnit whichUnit, Single scaleX, Single scaleY, Single scaleZ)
        {
            Natives.SetUnitScale(whichUnit, scaleX, scaleY, scaleZ);
        }

        public void SetUnitTimeScale(JassUnit whichUnit, Single timeScale)
        {
            Natives.SetUnitTimeScale(whichUnit, timeScale);
        }

        public void SetUnitBlendTime(JassUnit whichUnit, Single blendTime)
        {
            Natives.SetUnitBlendTime(whichUnit, blendTime);
        }

        public void SetUnitVertexColor(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.SetUnitVertexColor(whichUnit, red, green, blue, alpha);
        }

        public void QueueUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            Natives.QueueUnitAnimation(whichUnit, whichAnimation);
        }

        public void SetUnitAnimation(JassUnit whichUnit, String whichAnimation)
        {
            Natives.SetUnitAnimation(whichUnit, whichAnimation);
        }

        public void SetUnitAnimationByIndex(JassUnit whichUnit, JassInteger whichAnimation)
        {
            Natives.SetUnitAnimationByIndex(whichUnit, whichAnimation);
        }

        public void SetUnitAnimationWithRarity(JassUnit whichUnit, String whichAnimation, JassRarityControl rarity)
        {
            Natives.SetUnitAnimationWithRarity(whichUnit, whichAnimation, rarity);
        }

        public void AddUnitAnimationProperties(JassUnit whichUnit, String animProperties, Boolean add)
        {
            Natives.AddUnitAnimationProperties(whichUnit, animProperties, add);
        }

        public void SetUnitLookAt(JassUnit whichUnit, String whichBone, JassUnit lookAtTarget, Single offsetX, Single offsetY, Single offsetZ)
        {
            Natives.SetUnitLookAt(whichUnit, whichBone, lookAtTarget, offsetX, offsetY, offsetZ);
        }

        public void ResetUnitLookAt(JassUnit whichUnit)
        {
            Natives.ResetUnitLookAt(whichUnit);
        }

        public void SetUnitRescuable(JassUnit whichUnit, JassPlayer byWhichPlayer, Boolean flag)
        {
            Natives.SetUnitRescuable(whichUnit, byWhichPlayer, flag);
        }

        public void SetUnitRescueRange(JassUnit whichUnit, Single range)
        {
            Natives.SetUnitRescueRange(whichUnit, range);
        }

        public void SetHeroStr(JassUnit whichHero, JassInteger newStr, Boolean permanent)
        {
            Natives.SetHeroStr(whichHero, newStr, permanent);
        }

        public void SetHeroAgi(JassUnit whichHero, JassInteger newAgi, Boolean permanent)
        {
            Natives.SetHeroAgi(whichHero, newAgi, permanent);
        }

        public void SetHeroInt(JassUnit whichHero, JassInteger newInt, Boolean permanent)
        {
            Natives.SetHeroInt(whichHero, newInt, permanent);
        }

        public JassInteger GetHeroStr(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives.GetHeroStr(whichHero, includeBonuses);
        }

        public JassInteger GetHeroAgi(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives.GetHeroAgi(whichHero, includeBonuses);
        }

        public JassInteger GetHeroInt(JassUnit whichHero, Boolean includeBonuses)
        {
            return Natives.GetHeroInt(whichHero, includeBonuses);
        }

        public Boolean UnitStripHeroLevel(JassUnit whichHero, JassInteger howManyLevels)
        {
            return Natives.UnitStripHeroLevel(whichHero, howManyLevels);
        }

        public JassInteger GetHeroXP(JassUnit whichHero)
        {
            return Natives.GetHeroXP(whichHero);
        }

        public void SetHeroXP(JassUnit whichHero, JassInteger newXpVal, Boolean showEyeCandy)
        {
            Natives.SetHeroXP(whichHero, newXpVal, showEyeCandy);
        }

        public JassInteger GetHeroSkillPoints(JassUnit whichHero)
        {
            return Natives.GetHeroSkillPoints(whichHero);
        }

        public Boolean UnitModifySkillPoints(JassUnit whichHero, JassInteger skillPointDelta)
        {
            return Natives.UnitModifySkillPoints(whichHero, skillPointDelta);
        }

        public void AddHeroXP(JassUnit whichHero, JassInteger xpToAdd, Boolean showEyeCandy)
        {
            Natives.AddHeroXP(whichHero, xpToAdd, showEyeCandy);
        }

        public void SetHeroLevel(JassUnit whichHero, JassInteger level, Boolean showEyeCandy)
        {
            Natives.SetHeroLevel(whichHero, level, showEyeCandy);
        }

        public JassInteger GetHeroLevel(JassUnit whichHero)
        {
            return Natives.GetHeroLevel(whichHero);
        }

        public JassInteger GetUnitLevel(JassUnit whichUnit)
        {
            return Natives.GetUnitLevel(whichUnit);
        }

        public String GetHeroProperName(JassUnit whichHero)
        {
            return Natives.GetHeroProperName(whichHero);
        }

        public void SuspendHeroXP(JassUnit whichHero, Boolean flag)
        {
            Natives.SuspendHeroXP(whichHero, flag);
        }

        public Boolean IsSuspendedXP(JassUnit whichHero)
        {
            return Natives.IsSuspendedXP(whichHero);
        }

        public void SelectHeroSkill(JassUnit whichHero, JassObjectId abilcode)
        {
            Natives.SelectHeroSkill(whichHero, abilcode);
        }

        public JassInteger GetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives.GetUnitAbilityLevel(whichUnit, abilcode);
        }

        public JassInteger DecUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives.DecUnitAbilityLevel(whichUnit, abilcode);
        }

        public JassInteger IncUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode)
        {
            return Natives.IncUnitAbilityLevel(whichUnit, abilcode);
        }

        public JassInteger SetUnitAbilityLevel(JassUnit whichUnit, JassObjectId abilcode, JassInteger level)
        {
            return Natives.SetUnitAbilityLevel(whichUnit, abilcode, level);
        }

        public Boolean ReviveHero(JassUnit whichHero, Single x, Single y, Boolean doEyecandy)
        {
            return Natives.ReviveHero(whichHero, x, y, doEyecandy);
        }

        public Boolean ReviveHeroLoc(JassUnit whichHero, JassLocation loc, Boolean doEyecandy)
        {
            return Natives.ReviveHeroLoc(whichHero, loc, doEyecandy);
        }

        public void SetUnitExploded(JassUnit whichUnit, Boolean exploded)
        {
            Natives.SetUnitExploded(whichUnit, exploded);
        }

        public void SetUnitInvulnerable(JassUnit whichUnit, Boolean flag)
        {
            Natives.SetUnitInvulnerable(whichUnit, flag);
        }

        public void PauseUnit(JassUnit whichUnit, Boolean flag)
        {
            Natives.PauseUnit(whichUnit, flag);
        }

        public Boolean IsUnitPaused(JassUnit whichHero)
        {
            return Natives.IsUnitPaused(whichHero);
        }

        public void SetUnitPathing(JassUnit whichUnit, Boolean flag)
        {
            Natives.SetUnitPathing(whichUnit, flag);
        }

        public void ClearSelection()
        {
            Natives.ClearSelection();
        }

        public void SelectUnit(JassUnit whichUnit, Boolean flag)
        {
            Natives.SelectUnit(whichUnit, flag);
        }

        public JassInteger GetUnitPointValue(JassUnit whichUnit)
        {
            return Natives.GetUnitPointValue(whichUnit);
        }

        public JassInteger GetUnitPointValueByType(JassInteger unitType)
        {
            return Natives.GetUnitPointValueByType(unitType);
        }

        public Boolean UnitAddItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives.UnitAddItem(whichUnit, whichItem);
        }

        public JassItem UnitAddItemById(JassUnit whichUnit, JassObjectId itemId)
        {
            return Natives.UnitAddItemById(whichUnit, itemId);
        }

        public Boolean UnitAddItemToSlotById(JassUnit whichUnit, JassObjectId itemId, JassInteger itemSlot)
        {
            return Natives.UnitAddItemToSlotById(whichUnit, itemId, itemSlot);
        }

        public void UnitRemoveItem(JassUnit whichUnit, JassItem whichItem)
        {
            Natives.UnitRemoveItem(whichUnit, whichItem);
        }

        public JassItem UnitRemoveItemFromSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return Natives.UnitRemoveItemFromSlot(whichUnit, itemSlot);
        }

        public Boolean UnitHasItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives.UnitHasItem(whichUnit, whichItem);
        }

        public JassItem UnitItemInSlot(JassUnit whichUnit, JassInteger itemSlot)
        {
            return Natives.UnitItemInSlot(whichUnit, itemSlot);
        }

        public JassInteger UnitInventorySize(JassUnit whichUnit)
        {
            return Natives.UnitInventorySize(whichUnit);
        }

        public Boolean UnitDropItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return Natives.UnitDropItemPoint(whichUnit, whichItem, x, y);
        }

        public Boolean UnitDropItemSlot(JassUnit whichUnit, JassItem whichItem, JassInteger slot)
        {
            return Natives.UnitDropItemSlot(whichUnit, whichItem, slot);
        }

        public Boolean UnitDropItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return Natives.UnitDropItemTarget(whichUnit, whichItem, target);
        }

        public Boolean UnitUseItem(JassUnit whichUnit, JassItem whichItem)
        {
            return Natives.UnitUseItem(whichUnit, whichItem);
        }

        public Boolean UnitUseItemPoint(JassUnit whichUnit, JassItem whichItem, Single x, Single y)
        {
            return Natives.UnitUseItemPoint(whichUnit, whichItem, x, y);
        }

        public Boolean UnitUseItemTarget(JassUnit whichUnit, JassItem whichItem, JassWidget target)
        {
            return Natives.UnitUseItemTarget(whichUnit, whichItem, target);
        }

        public Single GetUnitX(JassUnit whichUnit)
        {
            return Natives.GetUnitX(whichUnit);
        }

        public Single GetUnitY(JassUnit whichUnit)
        {
            return Natives.GetUnitY(whichUnit);
        }

        public JassLocation GetUnitLoc(JassUnit whichUnit)
        {
            return Natives.GetUnitLoc(whichUnit);
        }

        public Single GetUnitFacing(JassUnit whichUnit)
        {
            return Natives.GetUnitFacing(whichUnit);
        }

        public Single GetUnitMoveSpeed(JassUnit whichUnit)
        {
            return Natives.GetUnitMoveSpeed(whichUnit);
        }

        public Single GetUnitDefaultMoveSpeed(JassUnit whichUnit)
        {
            return Natives.GetUnitDefaultMoveSpeed(whichUnit);
        }

        public Single GetUnitState(JassUnit whichUnit, JassUnitState whichUnitState)
        {
            return Natives.GetUnitState(whichUnit, whichUnitState);
        }

        public JassPlayer GetOwningPlayer(JassUnit whichUnit)
        {
            return Natives.GetOwningPlayer(whichUnit);
        }

        public JassObjectId GetUnitTypeId(JassUnit whichUnit)
        {
            return Natives.GetUnitTypeId(whichUnit);
        }

        public JassRace GetUnitRace(JassUnit whichUnit)
        {
            return Natives.GetUnitRace(whichUnit);
        }

        public String GetUnitName(JassUnit whichUnit)
        {
            return Natives.GetUnitName(whichUnit);
        }

        public JassInteger GetUnitFoodUsed(JassUnit whichUnit)
        {
            return Natives.GetUnitFoodUsed(whichUnit);
        }

        public JassInteger GetUnitFoodMade(JassUnit whichUnit)
        {
            return Natives.GetUnitFoodMade(whichUnit);
        }

        public JassInteger GetFoodMade(JassObjectId unitId)
        {
            return Natives.GetFoodMade(unitId);
        }

        public JassInteger GetFoodUsed(JassObjectId unitId)
        {
            return Natives.GetFoodUsed(unitId);
        }

        public void SetUnitUseFood(JassUnit whichUnit, Boolean useFood)
        {
            Natives.SetUnitUseFood(whichUnit, useFood);
        }

        public JassLocation GetUnitRallyPoint(JassUnit whichUnit)
        {
            return Natives.GetUnitRallyPoint(whichUnit);
        }

        public JassUnit GetUnitRallyUnit(JassUnit whichUnit)
        {
            return Natives.GetUnitRallyUnit(whichUnit);
        }

        public JassDestructable GetUnitRallyDestructable(JassUnit whichUnit)
        {
            return Natives.GetUnitRallyDestructable(whichUnit);
        }

        public Boolean IsUnitInGroup(JassUnit whichUnit, JassGroup whichGroup)
        {
            return Natives.IsUnitInGroup(whichUnit, whichGroup);
        }

        public Boolean IsUnitInForce(JassUnit whichUnit, JassForce whichForce)
        {
            return Natives.IsUnitInForce(whichUnit, whichForce);
        }

        public Boolean IsUnitOwnedByPlayer(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitOwnedByPlayer(whichUnit, whichPlayer);
        }

        public Boolean IsUnitAlly(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitAlly(whichUnit, whichPlayer);
        }

        public Boolean IsUnitEnemy(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitEnemy(whichUnit, whichPlayer);
        }

        public Boolean IsUnitVisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitVisible(whichUnit, whichPlayer);
        }

        public Boolean IsUnitDetected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitDetected(whichUnit, whichPlayer);
        }

        public Boolean IsUnitInvisible(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitInvisible(whichUnit, whichPlayer);
        }

        public Boolean IsUnitFogged(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitFogged(whichUnit, whichPlayer);
        }

        public Boolean IsUnitMasked(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitMasked(whichUnit, whichPlayer);
        }

        public Boolean IsUnitSelected(JassUnit whichUnit, JassPlayer whichPlayer)
        {
            return Natives.IsUnitSelected(whichUnit, whichPlayer);
        }

        public Boolean IsUnitRace(JassUnit whichUnit, JassRace whichRace)
        {
            return Natives.IsUnitRace(whichUnit, whichRace);
        }

        public Boolean IsUnitType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives.IsUnitType(whichUnit, whichUnitType);
        }

        public Boolean IsUnit(JassUnit whichUnit, JassUnit whichSpecifiedUnit)
        {
            return Natives.IsUnit(whichUnit, whichSpecifiedUnit);
        }

        public Boolean IsUnitInRange(JassUnit whichUnit, JassUnit otherUnit, Single distance)
        {
            return Natives.IsUnitInRange(whichUnit, otherUnit, distance);
        }

        public Boolean IsUnitInRangeXY(JassUnit whichUnit, Single x, Single y, Single distance)
        {
            return Natives.IsUnitInRangeXY(whichUnit, x, y, distance);
        }

        public Boolean IsUnitInRangeLoc(JassUnit whichUnit, JassLocation whichLocation, Single distance)
        {
            return Natives.IsUnitInRangeLoc(whichUnit, whichLocation, distance);
        }

        public Boolean IsUnitHidden(JassUnit whichUnit)
        {
            return Natives.IsUnitHidden(whichUnit);
        }

        public Boolean IsUnitIllusion(JassUnit whichUnit)
        {
            return Natives.IsUnitIllusion(whichUnit);
        }

        public Boolean IsUnitInTransport(JassUnit whichUnit, JassUnit whichTransport)
        {
            return Natives.IsUnitInTransport(whichUnit, whichTransport);
        }

        public Boolean IsUnitLoaded(JassUnit whichUnit)
        {
            return Natives.IsUnitLoaded(whichUnit);
        }

        public Boolean IsHeroUnitId(JassObjectId unitId)
        {
            return Natives.IsHeroUnitId(unitId);
        }

        public Boolean IsUnitIdType(JassObjectId unitId, JassUnitType whichUnitType)
        {
            return Natives.IsUnitIdType(unitId, whichUnitType);
        }

        public void UnitShareVision(JassUnit whichUnit, JassPlayer whichPlayer, Boolean share)
        {
            Natives.UnitShareVision(whichUnit, whichPlayer, share);
        }

        public void UnitSuspendDecay(JassUnit whichUnit, Boolean suspend)
        {
            Natives.UnitSuspendDecay(whichUnit, suspend);
        }

        public Boolean UnitAddType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives.UnitAddType(whichUnit, whichUnitType);
        }

        public Boolean UnitRemoveType(JassUnit whichUnit, JassUnitType whichUnitType)
        {
            return Natives.UnitRemoveType(whichUnit, whichUnitType);
        }

        public Boolean UnitAddAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return Natives.UnitAddAbility(whichUnit, abilityId);
        }

        public Boolean UnitRemoveAbility(JassUnit whichUnit, JassInteger abilityId)
        {
            return Natives.UnitRemoveAbility(whichUnit, abilityId);
        }

        public Boolean UnitMakeAbilityPermanent(JassUnit whichUnit, Boolean permanent, JassInteger abilityId)
        {
            return Natives.UnitMakeAbilityPermanent(whichUnit, permanent, abilityId);
        }

        public void UnitRemoveBuffs(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative)
        {
            Natives.UnitRemoveBuffs(whichUnit, removePositive, removeNegative);
        }

        public void UnitRemoveBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            Natives.UnitRemoveBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }

        public Boolean UnitHasBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return Natives.UnitHasBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }

        public JassInteger UnitCountBuffsEx(JassUnit whichUnit, Boolean removePositive, Boolean removeNegative, Boolean magic, Boolean physical, Boolean timedLife, Boolean aura, Boolean autoDispel)
        {
            return Natives.UnitCountBuffsEx(whichUnit, removePositive, removeNegative, magic, physical, timedLife, aura, autoDispel);
        }

        public void UnitAddSleep(JassUnit whichUnit, Boolean add)
        {
            Natives.UnitAddSleep(whichUnit, add);
        }

        public Boolean UnitCanSleep(JassUnit whichUnit)
        {
            return Natives.UnitCanSleep(whichUnit);
        }

        public void UnitAddSleepPerm(JassUnit whichUnit, Boolean add)
        {
            Natives.UnitAddSleepPerm(whichUnit, add);
        }

        public Boolean UnitCanSleepPerm(JassUnit whichUnit)
        {
            return Natives.UnitCanSleepPerm(whichUnit);
        }

        public Boolean UnitIsSleeping(JassUnit whichUnit)
        {
            return Natives.UnitIsSleeping(whichUnit);
        }

        public void UnitWakeUp(JassUnit whichUnit)
        {
            Natives.UnitWakeUp(whichUnit);
        }

        public void UnitApplyTimedLife(JassUnit whichUnit, JassInteger buffId, Single duration)
        {
            Natives.UnitApplyTimedLife(whichUnit, buffId, duration);
        }

        public Boolean UnitIgnoreAlarm(JassUnit whichUnit, Boolean flag)
        {
            return Natives.UnitIgnoreAlarm(whichUnit, flag);
        }

        public Boolean UnitIgnoreAlarmToggled(JassUnit whichUnit)
        {
            return Natives.UnitIgnoreAlarmToggled(whichUnit);
        }

        public void UnitResetCooldown(JassUnit whichUnit)
        {
            Natives.UnitResetCooldown(whichUnit);
        }

        public void UnitSetConstructionProgress(JassUnit whichUnit, JassInteger constructionPercentage)
        {
            Natives.UnitSetConstructionProgress(whichUnit, constructionPercentage);
        }

        public void UnitSetUpgradeProgress(JassUnit whichUnit, JassInteger upgradePercentage)
        {
            Natives.UnitSetUpgradeProgress(whichUnit, upgradePercentage);
        }

        public void UnitPauseTimedLife(JassUnit whichUnit, Boolean flag)
        {
            Natives.UnitPauseTimedLife(whichUnit, flag);
        }

        public void UnitSetUsesAltIcon(JassUnit whichUnit, Boolean flag)
        {
            Natives.UnitSetUsesAltIcon(whichUnit, flag);
        }

        public Boolean UnitDamagePoint(JassUnit whichUnit, Single delay, Single radius, Single x, Single y, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return Natives.UnitDamagePoint(whichUnit, delay, radius, x, y, amount, attack, ranged, attackType, damageType, weaponType);
        }

        public Boolean UnitDamageTarget(JassUnit whichUnit, JassWidget target, Single amount, Boolean attack, Boolean ranged, JassAttackType attackType, JassDamageType damageType, JassWeaponType weaponType)
        {
            return Natives.UnitDamageTarget(whichUnit, target, amount, attack, ranged, attackType, damageType, weaponType);
        }

        public Boolean IssueImmediateOrder(JassUnit whichUnit, String order)
        {
            return Natives.IssueImmediateOrder(whichUnit, order);
        }

        public Boolean IssueImmediateOrderById(JassUnit whichUnit, JassOrder order)
        {
            return Natives.IssueImmediateOrderById(whichUnit, order);
        }

        public Boolean IssuePointOrder(JassUnit whichUnit, String order, Single x, Single y)
        {
            return Natives.IssuePointOrder(whichUnit, order, x, y);
        }

        public Boolean IssuePointOrderLoc(JassUnit whichUnit, String order, JassLocation whichLocation)
        {
            return Natives.IssuePointOrderLoc(whichUnit, order, whichLocation);
        }

        public Boolean IssuePointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y)
        {
            return Natives.IssuePointOrderById(whichUnit, order, x, y);
        }

        public Boolean IssuePointOrderByIdLoc(JassUnit whichUnit, JassOrder order, JassLocation whichLocation)
        {
            return Natives.IssuePointOrderByIdLoc(whichUnit, order, whichLocation);
        }

        public Boolean IssueTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget)
        {
            return Natives.IssueTargetOrder(whichUnit, order, targetWidget);
        }

        public Boolean IssueTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget)
        {
            return Natives.IssueTargetOrderById(whichUnit, order, targetWidget);
        }

        public Boolean IssueInstantPointOrder(JassUnit whichUnit, String order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return Natives.IssueInstantPointOrder(whichUnit, order, x, y, instantTargetWidget);
        }

        public Boolean IssueInstantPointOrderById(JassUnit whichUnit, JassOrder order, Single x, Single y, JassWidget instantTargetWidget)
        {
            return Natives.IssueInstantPointOrderById(whichUnit, order, x, y, instantTargetWidget);
        }

        public Boolean IssueInstantTargetOrder(JassUnit whichUnit, String order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return Natives.IssueInstantTargetOrder(whichUnit, order, targetWidget, instantTargetWidget);
        }

        public Boolean IssueInstantTargetOrderById(JassUnit whichUnit, JassOrder order, JassWidget targetWidget, JassWidget instantTargetWidget)
        {
            return Natives.IssueInstantTargetOrderById(whichUnit, order, targetWidget, instantTargetWidget);
        }

        public Boolean IssueBuildOrder(JassUnit whichPeon, String unitToBuild, Single x, Single y)
        {
            return Natives.IssueBuildOrder(whichPeon, unitToBuild, x, y);
        }

        public Boolean IssueBuildOrderById(JassUnit whichPeon, JassObjectId unitId, Single x, Single y)
        {
            return Natives.IssueBuildOrderById(whichPeon, unitId, x, y);
        }

        public Boolean IssueNeutralImmediateOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild)
        {
            return Natives.IssueNeutralImmediateOrder(forWhichPlayer, neutralStructure, unitToBuild);
        }

        public Boolean IssueNeutralImmediateOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId)
        {
            return Natives.IssueNeutralImmediateOrderById(forWhichPlayer, neutralStructure, unitId);
        }

        public Boolean IssueNeutralPointOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, Single x, Single y)
        {
            return Natives.IssueNeutralPointOrder(forWhichPlayer, neutralStructure, unitToBuild, x, y);
        }

        public Boolean IssueNeutralPointOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, Single x, Single y)
        {
            return Natives.IssueNeutralPointOrderById(forWhichPlayer, neutralStructure, unitId, x, y);
        }

        public Boolean IssueNeutralTargetOrder(JassPlayer forWhichPlayer, JassUnit neutralStructure, String unitToBuild, JassWidget target)
        {
            return Natives.IssueNeutralTargetOrder(forWhichPlayer, neutralStructure, unitToBuild, target);
        }

        public Boolean IssueNeutralTargetOrderById(JassPlayer forWhichPlayer, JassUnit neutralStructure, JassObjectId unitId, JassWidget target)
        {
            return Natives.IssueNeutralTargetOrderById(forWhichPlayer, neutralStructure, unitId, target);
        }

        public JassInteger GetUnitCurrentOrder(JassUnit whichUnit)
        {
            return Natives.GetUnitCurrentOrder(whichUnit);
        }

        public void SetResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            Natives.SetResourceAmount(whichUnit, amount);
        }

        public void AddResourceAmount(JassUnit whichUnit, JassInteger amount)
        {
            Natives.AddResourceAmount(whichUnit, amount);
        }

        public JassInteger GetResourceAmount(JassUnit whichUnit)
        {
            return Natives.GetResourceAmount(whichUnit);
        }

        public Single WaygateGetDestinationX(JassUnit waygate)
        {
            return Natives.WaygateGetDestinationX(waygate);
        }

        public Single WaygateGetDestinationY(JassUnit waygate)
        {
            return Natives.WaygateGetDestinationY(waygate);
        }

        public void WaygateSetDestination(JassUnit waygate, Single x, Single y)
        {
            Natives.WaygateSetDestination(waygate, x, y);
        }

        public void WaygateActivate(JassUnit waygate, Boolean activate)
        {
            Natives.WaygateActivate(waygate, activate);
        }

        public Boolean WaygateIsActive(JassUnit waygate)
        {
            return Natives.WaygateIsActive(waygate);
        }

        public void AddItemToAllStock(JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives.AddItemToAllStock(itemId, currentStock, stockMax);
        }

        public void AddItemToStock(JassUnit whichUnit, JassObjectId itemId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives.AddItemToStock(whichUnit, itemId, currentStock, stockMax);
        }

        public void AddUnitToAllStock(JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives.AddUnitToAllStock(unitId, currentStock, stockMax);
        }

        public void AddUnitToStock(JassUnit whichUnit, JassObjectId unitId, JassInteger currentStock, JassInteger stockMax)
        {
            Natives.AddUnitToStock(whichUnit, unitId, currentStock, stockMax);
        }

        public void RemoveItemFromAllStock(JassObjectId itemId)
        {
            Natives.RemoveItemFromAllStock(itemId);
        }

        public void RemoveItemFromStock(JassUnit whichUnit, JassObjectId itemId)
        {
            Natives.RemoveItemFromStock(whichUnit, itemId);
        }

        public void RemoveUnitFromAllStock(JassObjectId unitId)
        {
            Natives.RemoveUnitFromAllStock(unitId);
        }

        public void RemoveUnitFromStock(JassUnit whichUnit, JassObjectId unitId)
        {
            Natives.RemoveUnitFromStock(whichUnit, unitId);
        }

        public void SetAllItemTypeSlots(JassInteger slots)
        {
            Natives.SetAllItemTypeSlots(slots);
        }

        public void SetAllUnitTypeSlots(JassInteger slots)
        {
            Natives.SetAllUnitTypeSlots(slots);
        }

        public void SetItemTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            Natives.SetItemTypeSlots(whichUnit, slots);
        }

        public void SetUnitTypeSlots(JassUnit whichUnit, JassInteger slots)
        {
            Natives.SetUnitTypeSlots(whichUnit, slots);
        }

        public JassInteger GetUnitUserData(JassUnit whichUnit)
        {
            return Natives.GetUnitUserData(whichUnit);
        }

        public void SetUnitUserData(JassUnit whichUnit, JassInteger data)
        {
            Natives.SetUnitUserData(whichUnit, data);
        }

        public JassPlayer Player(JassInteger number)
        {
            return Natives.Player(number);
        }

        public JassPlayer GetLocalPlayer()
        {
            return Natives.GetLocalPlayer();
        }

        public Boolean IsPlayerAlly(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return Natives.IsPlayerAlly(whichPlayer, otherPlayer);
        }

        public Boolean IsPlayerEnemy(JassPlayer whichPlayer, JassPlayer otherPlayer)
        {
            return Natives.IsPlayerEnemy(whichPlayer, otherPlayer);
        }

        public Boolean IsPlayerInForce(JassPlayer whichPlayer, JassForce whichForce)
        {
            return Natives.IsPlayerInForce(whichPlayer, whichForce);
        }

        public Boolean IsPlayerObserver(JassPlayer whichPlayer)
        {
            return Natives.IsPlayerObserver(whichPlayer);
        }

        public Boolean IsVisibleToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives.IsVisibleToPlayer(x, y, whichPlayer);
        }

        public Boolean IsLocationVisibleToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives.IsLocationVisibleToPlayer(whichLocation, whichPlayer);
        }

        public Boolean IsFoggedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives.IsFoggedToPlayer(x, y, whichPlayer);
        }

        public Boolean IsLocationFoggedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives.IsLocationFoggedToPlayer(whichLocation, whichPlayer);
        }

        public Boolean IsMaskedToPlayer(Single x, Single y, JassPlayer whichPlayer)
        {
            return Natives.IsMaskedToPlayer(x, y, whichPlayer);
        }

        public Boolean IsLocationMaskedToPlayer(JassLocation whichLocation, JassPlayer whichPlayer)
        {
            return Natives.IsLocationMaskedToPlayer(whichLocation, whichPlayer);
        }

        public JassRace GetPlayerRace(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerRace(whichPlayer);
        }

        public JassInteger GetPlayerId(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerId(whichPlayer);
        }

        public JassInteger GetPlayerUnitCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return Natives.GetPlayerUnitCount(whichPlayer, includeIncomplete);
        }

        public JassInteger GetPlayerTypedUnitCount(JassPlayer whichPlayer, String unitName, Boolean includeIncomplete, Boolean includeUpgrades)
        {
            return Natives.GetPlayerTypedUnitCount(whichPlayer, unitName, includeIncomplete, includeUpgrades);
        }

        public JassInteger GetPlayerStructureCount(JassPlayer whichPlayer, Boolean includeIncomplete)
        {
            return Natives.GetPlayerStructureCount(whichPlayer, includeIncomplete);
        }

        public JassInteger GetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState)
        {
            return Natives.GetPlayerState(whichPlayer, whichPlayerState);
        }

        public JassInteger GetPlayerScore(JassPlayer whichPlayer, JassPlayerScore whichPlayerScore)
        {
            return Natives.GetPlayerScore(whichPlayer, whichPlayerScore);
        }

        public Boolean GetPlayerAlliance(JassPlayer sourcePlayer, JassPlayer otherPlayer, JassAllianceType whichAllianceSetting)
        {
            return Natives.GetPlayerAlliance(sourcePlayer, otherPlayer, whichAllianceSetting);
        }

        public Single GetPlayerHandicap(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerHandicap(whichPlayer);
        }

        public Single GetPlayerHandicapXP(JassPlayer whichPlayer)
        {
            return Natives.GetPlayerHandicapXP(whichPlayer);
        }

        public void SetPlayerHandicap(JassPlayer whichPlayer, Single handicap)
        {
            Natives.SetPlayerHandicap(whichPlayer, handicap);
        }

        public void SetPlayerHandicapXP(JassPlayer whichPlayer, Single handicap)
        {
            Natives.SetPlayerHandicapXP(whichPlayer, handicap);
        }

        public void SetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid, JassInteger maximum)
        {
            Natives.SetPlayerTechMaxAllowed(whichPlayer, techid, maximum);
        }

        public JassInteger GetPlayerTechMaxAllowed(JassPlayer whichPlayer, JassInteger techid)
        {
            return Natives.GetPlayerTechMaxAllowed(whichPlayer, techid);
        }

        public void AddPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger levels)
        {
            Natives.AddPlayerTechResearched(whichPlayer, techid, levels);
        }

        public void SetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, JassInteger setToLevel)
        {
            Natives.SetPlayerTechResearched(whichPlayer, techid, setToLevel);
        }

        public Boolean GetPlayerTechResearched(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return Natives.GetPlayerTechResearched(whichPlayer, techid, specificonly);
        }

        public JassInteger GetPlayerTechCount(JassPlayer whichPlayer, JassInteger techid, Boolean specificonly)
        {
            return Natives.GetPlayerTechCount(whichPlayer, techid, specificonly);
        }

        public void SetPlayerUnitsOwner(JassPlayer whichPlayer, JassInteger newOwner)
        {
            Natives.SetPlayerUnitsOwner(whichPlayer, newOwner);
        }

        public void CripplePlayer(JassPlayer whichPlayer, JassForce toWhichPlayers, Boolean flag)
        {
            Natives.CripplePlayer(whichPlayer, toWhichPlayers, flag);
        }

        public void SetPlayerAbilityAvailable(JassPlayer whichPlayer, JassObjectId abilid, Boolean avail)
        {
            Natives.SetPlayerAbilityAvailable(whichPlayer, abilid, avail);
        }

        public void SetPlayerState(JassPlayer whichPlayer, JassPlayerState whichPlayerState, JassInteger value)
        {
            Natives.SetPlayerState(whichPlayer, whichPlayerState, value);
        }

        public void RemovePlayer(JassPlayer whichPlayer, JassPlayerGameResult gameResult)
        {
            Natives.RemovePlayer(whichPlayer, gameResult);
        }

        public void CachePlayerHeroData(JassPlayer whichPlayer)
        {
            Natives.CachePlayerHeroData(whichPlayer);
        }

        public void SetFogStateRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision)
        {
            Natives.SetFogStateRect(forWhichPlayer, whichState, where, useSharedVision);
        }

        public void SetFogStateRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision)
        {
            Natives.SetFogStateRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision);
        }

        public void SetFogStateRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision)
        {
            Natives.SetFogStateRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision);
        }

        public void FogMaskEnable(Boolean enable)
        {
            Natives.FogMaskEnable(enable);
        }

        public Boolean IsFogMaskEnabled()
        {
            return Natives.IsFogMaskEnabled();
        }

        public void FogEnable(Boolean enable)
        {
            Natives.FogEnable(enable);
        }

        public Boolean IsFogEnabled()
        {
            return Natives.IsFogEnabled();
        }

        public JassFogModifier CreateFogModifierRect(JassPlayer forWhichPlayer, JassFogState whichState, JassRect where, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives.CreateFogModifierRect(forWhichPlayer, whichState, where, useSharedVision, afterUnits);
        }

        public JassFogModifier CreateFogModifierRadius(JassPlayer forWhichPlayer, JassFogState whichState, Single centerx, Single centerY, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives.CreateFogModifierRadius(forWhichPlayer, whichState, centerx, centerY, radius, useSharedVision, afterUnits);
        }

        public JassFogModifier CreateFogModifierRadiusLoc(JassPlayer forWhichPlayer, JassFogState whichState, JassLocation center, Single radius, Boolean useSharedVision, Boolean afterUnits)
        {
            return Natives.CreateFogModifierRadiusLoc(forWhichPlayer, whichState, center, radius, useSharedVision, afterUnits);
        }

        public void DestroyFogModifier(JassFogModifier whichFogModifier)
        {
            Natives.DestroyFogModifier(whichFogModifier);
        }

        public void FogModifierStart(JassFogModifier whichFogModifier)
        {
            Natives.FogModifierStart(whichFogModifier);
        }

        public void FogModifierStop(JassFogModifier whichFogModifier)
        {
            Natives.FogModifierStop(whichFogModifier);
        }

        public JassVersion VersionGet()
        {
            return Natives.VersionGet();
        }

        public Boolean VersionCompatible(JassVersion whichVersion)
        {
            return Natives.VersionCompatible(whichVersion);
        }

        public Boolean VersionSupported(JassVersion whichVersion)
        {
            return Natives.VersionSupported(whichVersion);
        }

        public void EndGame(Boolean doScoreScreen)
        {
            Natives.EndGame(doScoreScreen);
        }

        public void ChangeLevel(String newLevel, Boolean doScoreScreen)
        {
            Natives.ChangeLevel(newLevel, doScoreScreen);
        }

        public void RestartGame(Boolean doScoreScreen)
        {
            Natives.RestartGame(doScoreScreen);
        }

        public void ReloadGame()
        {
            Natives.ReloadGame();
        }

        public void SetCampaignMenuRace(JassRace r)
        {
            Natives.SetCampaignMenuRace(r);
        }

        public void SetCampaignMenuRaceEx(JassInteger campaignIndex)
        {
            Natives.SetCampaignMenuRaceEx(campaignIndex);
        }

        public void ForceCampaignSelectScreen()
        {
            Natives.ForceCampaignSelectScreen();
        }

        public void LoadGame(String saveFileName, Boolean doScoreScreen)
        {
            Natives.LoadGame(saveFileName, doScoreScreen);
        }

        public void SaveGame(String saveFileName)
        {
            Natives.SaveGame(saveFileName);
        }

        public Boolean RenameSaveDirectory(String sourceDirName, String destDirName)
        {
            return Natives.RenameSaveDirectory(sourceDirName, destDirName);
        }

        public Boolean RemoveSaveDirectory(String sourceDirName)
        {
            return Natives.RemoveSaveDirectory(sourceDirName);
        }

        public Boolean CopySaveGame(String sourceSaveName, String destSaveName)
        {
            return Natives.CopySaveGame(sourceSaveName, destSaveName);
        }

        public Boolean SaveGameExists(String saveName)
        {
            return Natives.SaveGameExists(saveName);
        }

        public void SyncSelections()
        {
            Natives.SyncSelections();
        }

        public void SetFloatGameState(JassFGameState whichFloatGameState, Single value)
        {
            Natives.SetFloatGameState(whichFloatGameState, value);
        }

        public Single GetFloatGameState(JassFGameState whichFloatGameState)
        {
            return Natives.GetFloatGameState(whichFloatGameState);
        }

        public void SetIntegerGameState(JassIGameState whichIntegerGameState, JassInteger value)
        {
            Natives.SetIntegerGameState(whichIntegerGameState, value);
        }

        public JassInteger GetIntegerGameState(JassIGameState whichIntegerGameState)
        {
            return Natives.GetIntegerGameState(whichIntegerGameState);
        }

        public void SetTutorialCleared(Boolean cleared)
        {
            Natives.SetTutorialCleared(cleared);
        }

        public void SetMissionAvailable(JassInteger campaignNumber, JassInteger missionNumber, Boolean available)
        {
            Natives.SetMissionAvailable(campaignNumber, missionNumber, available);
        }

        public void SetCampaignAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives.SetCampaignAvailable(campaignNumber, available);
        }

        public void SetOpCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives.SetOpCinematicAvailable(campaignNumber, available);
        }

        public void SetEdCinematicAvailable(JassInteger campaignNumber, Boolean available)
        {
            Natives.SetEdCinematicAvailable(campaignNumber, available);
        }

        public JassGameDifficulty GetDefaultDifficulty()
        {
            return Natives.GetDefaultDifficulty();
        }

        public void SetDefaultDifficulty(JassGameDifficulty g)
        {
            Natives.SetDefaultDifficulty(g);
        }

        public void SetCustomCampaignButtonVisible(JassInteger whichButton, Boolean visible)
        {
            Natives.SetCustomCampaignButtonVisible(whichButton, visible);
        }

        public Boolean GetCustomCampaignButtonVisible(JassInteger whichButton)
        {
            return Natives.GetCustomCampaignButtonVisible(whichButton);
        }

        public void DoNotSaveReplay()
        {
            Natives.DoNotSaveReplay();
        }

        public JassDialog DialogCreate()
        {
            return Natives.DialogCreate();
        }

        public void DialogDestroy(JassDialog whichDialog)
        {
            Natives.DialogDestroy(whichDialog);
        }

        public void DialogClear(JassDialog whichDialog)
        {
            Natives.DialogClear(whichDialog);
        }

        public void DialogSetMessage(JassDialog whichDialog, String messageText)
        {
            Natives.DialogSetMessage(whichDialog, messageText);
        }

        public JassButton DialogAddButton(JassDialog whichDialog, String buttonText, JassInteger hotkey)
        {
            return Natives.DialogAddButton(whichDialog, buttonText, hotkey);
        }

        public JassButton DialogAddQuitButton(JassDialog whichDialog, Boolean doScoreScreen, String buttonText, JassInteger hotkey)
        {
            return Natives.DialogAddQuitButton(whichDialog, doScoreScreen, buttonText, hotkey);
        }

        public void DialogDisplay(JassPlayer whichPlayer, JassDialog whichDialog, Boolean flag)
        {
            Natives.DialogDisplay(whichPlayer, whichDialog, flag);
        }

        public Boolean ReloadGameCachesFromDisk()
        {
            return Natives.ReloadGameCachesFromDisk();
        }

        public JassGameCache InitGameCache(String campaignFile)
        {
            return Natives.InitGameCache(campaignFile);
        }

        public Boolean SaveGameCache(JassGameCache whichCache)
        {
            return Natives.SaveGameCache(whichCache);
        }

        public void StoreInteger(JassGameCache cache, String missionKey, String key, JassInteger value)
        {
            Natives.StoreInteger(cache, missionKey, key, value);
        }

        public void StoreReal(JassGameCache cache, String missionKey, String key, Single value)
        {
            Natives.StoreReal(cache, missionKey, key, value);
        }

        public void StoreBoolean(JassGameCache cache, String missionKey, String key, Boolean value)
        {
            Natives.StoreBoolean(cache, missionKey, key, value);
        }

        public Boolean StoreUnit(JassGameCache cache, String missionKey, String key, JassUnit whichUnit)
        {
            return Natives.StoreUnit(cache, missionKey, key, whichUnit);
        }

        public Boolean StoreString(JassGameCache cache, String missionKey, String key, String value)
        {
            return Natives.StoreString(cache, missionKey, key, value);
        }

        public void SyncStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            Natives.SyncStoredInteger(cache, missionKey, key);
        }

        public void SyncStoredReal(JassGameCache cache, String missionKey, String key)
        {
            Natives.SyncStoredReal(cache, missionKey, key);
        }

        public void SyncStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            Natives.SyncStoredBoolean(cache, missionKey, key);
        }

        public void SyncStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            Natives.SyncStoredUnit(cache, missionKey, key);
        }

        public void SyncStoredString(JassGameCache cache, String missionKey, String key)
        {
            Natives.SyncStoredString(cache, missionKey, key);
        }

        public Boolean HaveStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return Natives.HaveStoredInteger(cache, missionKey, key);
        }

        public Boolean HaveStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return Natives.HaveStoredReal(cache, missionKey, key);
        }

        public Boolean HaveStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return Natives.HaveStoredBoolean(cache, missionKey, key);
        }

        public Boolean HaveStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            return Natives.HaveStoredUnit(cache, missionKey, key);
        }

        public Boolean HaveStoredString(JassGameCache cache, String missionKey, String key)
        {
            return Natives.HaveStoredString(cache, missionKey, key);
        }

        public void FlushGameCache(JassGameCache cache)
        {
            Natives.FlushGameCache(cache);
        }

        public void FlushStoredMission(JassGameCache cache, String missionKey)
        {
            Natives.FlushStoredMission(cache, missionKey);
        }

        public void FlushStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            Natives.FlushStoredInteger(cache, missionKey, key);
        }

        public void FlushStoredReal(JassGameCache cache, String missionKey, String key)
        {
            Natives.FlushStoredReal(cache, missionKey, key);
        }

        public void FlushStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            Natives.FlushStoredBoolean(cache, missionKey, key);
        }

        public void FlushStoredUnit(JassGameCache cache, String missionKey, String key)
        {
            Natives.FlushStoredUnit(cache, missionKey, key);
        }

        public void FlushStoredString(JassGameCache cache, String missionKey, String key)
        {
            Natives.FlushStoredString(cache, missionKey, key);
        }

        public JassInteger GetStoredInteger(JassGameCache cache, String missionKey, String key)
        {
            return Natives.GetStoredInteger(cache, missionKey, key);
        }

        public Single GetStoredReal(JassGameCache cache, String missionKey, String key)
        {
            return Natives.GetStoredReal(cache, missionKey, key);
        }

        public Boolean GetStoredBoolean(JassGameCache cache, String missionKey, String key)
        {
            return Natives.GetStoredBoolean(cache, missionKey, key);
        }

        public String GetStoredString(JassGameCache cache, String missionKey, String key)
        {
            return Natives.GetStoredString(cache, missionKey, key);
        }

        public JassUnit RestoreUnit(JassGameCache cache, String missionKey, String key, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return Natives.RestoreUnit(cache, missionKey, key, forWhichPlayer, x, y, facing);
        }

        public JassHashTable InitHashtable()
        {
            return Natives.InitHashtable();
        }

        public void SaveInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassInteger value)
        {
            Natives.SaveInteger(table, parentKey, childKey, value);
        }

        public void SaveReal(JassHashTable table, JassInteger parentKey, JassInteger childKey, Single value)
        {
            Natives.SaveReal(table, parentKey, childKey, value);
        }

        public void SaveBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey, Boolean value)
        {
            Natives.SaveBoolean(table, parentKey, childKey, value);
        }

        public Boolean SaveStr(JassHashTable table, JassInteger parentKey, JassInteger childKey, String value)
        {
            return Natives.SaveStr(table, parentKey, childKey, value);
        }

        public Boolean SavePlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassPlayer whichPlayer)
        {
            return Natives.SavePlayerHandle(table, parentKey, childKey, whichPlayer);
        }

        public Boolean SaveWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassWidget whichWidget)
        {
            return Natives.SaveWidgetHandle(table, parentKey, childKey, whichWidget);
        }

        public Boolean SaveDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDestructable whichDestructable)
        {
            return Natives.SaveDestructableHandle(table, parentKey, childKey, whichDestructable);
        }

        public Boolean SaveItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItem whichItem)
        {
            return Natives.SaveItemHandle(table, parentKey, childKey, whichItem);
        }

        public Boolean SaveUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnit whichUnit)
        {
            return Natives.SaveUnitHandle(table, parentKey, childKey, whichUnit);
        }

        public Boolean SaveAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAbility whichAbility)
        {
            return Natives.SaveAbilityHandle(table, parentKey, childKey, whichAbility);
        }

        public Boolean SaveTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimer whichTimer)
        {
            return Natives.SaveTimerHandle(table, parentKey, childKey, whichTimer);
        }

        public Boolean SaveTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrigger whichTrigger)
        {
            return Natives.SaveTriggerHandle(table, parentKey, childKey, whichTrigger);
        }

        public Boolean SaveTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerCondition whichTriggercondition)
        {
            return Natives.SaveTriggerConditionHandle(table, parentKey, childKey, whichTriggercondition);
        }

        public Boolean SaveTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTriggerAction whichTriggeraction)
        {
            return Natives.SaveTriggerActionHandle(table, parentKey, childKey, whichTriggeraction);
        }

        public Boolean SaveTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEvent whichEvent)
        {
            return Natives.SaveTriggerEventHandle(table, parentKey, childKey, whichEvent);
        }

        public Boolean SaveForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassForce whichForce)
        {
            return Natives.SaveForceHandle(table, parentKey, childKey, whichForce);
        }

        public Boolean SaveGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassGroup whichGroup)
        {
            return Natives.SaveGroupHandle(table, parentKey, childKey, whichGroup);
        }

        public Boolean SaveLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLocation whichLocation)
        {
            return Natives.SaveLocationHandle(table, parentKey, childKey, whichLocation);
        }

        public Boolean SaveRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRect whichRect)
        {
            return Natives.SaveRectHandle(table, parentKey, childKey, whichRect);
        }

        public Boolean SaveBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassBooleanExpression whichBoolexpr)
        {
            return Natives.SaveBooleanExprHandle(table, parentKey, childKey, whichBoolexpr);
        }

        public Boolean SaveSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassSound whichSound)
        {
            return Natives.SaveSoundHandle(table, parentKey, childKey, whichSound);
        }

        public Boolean SaveEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassEffect whichEffect)
        {
            return Natives.SaveEffectHandle(table, parentKey, childKey, whichEffect);
        }

        public Boolean SaveUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUnitPool whichUnitpool)
        {
            return Natives.SaveUnitPoolHandle(table, parentKey, childKey, whichUnitpool);
        }

        public Boolean SaveItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassItemPool whichItempool)
        {
            return Natives.SaveItemPoolHandle(table, parentKey, childKey, whichItempool);
        }

        public Boolean SaveQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuest whichQuest)
        {
            return Natives.SaveQuestHandle(table, parentKey, childKey, whichQuest);
        }

        public Boolean SaveQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassQuestItem whichQuestitem)
        {
            return Natives.SaveQuestItemHandle(table, parentKey, childKey, whichQuestitem);
        }

        public Boolean SaveDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDefeatCondition whichDefeatcondition)
        {
            return Natives.SaveDefeatConditionHandle(table, parentKey, childKey, whichDefeatcondition);
        }

        public Boolean SaveTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTimerDialog whichTimerdialog)
        {
            return Natives.SaveTimerDialogHandle(table, parentKey, childKey, whichTimerdialog);
        }

        public Boolean SaveLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLeaderboard whichLeaderboard)
        {
            return Natives.SaveLeaderboardHandle(table, parentKey, childKey, whichLeaderboard);
        }

        public Boolean SaveMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboard whichMultiboard)
        {
            return Natives.SaveMultiboardHandle(table, parentKey, childKey, whichMultiboard);
        }

        public Boolean SaveMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassMultiboardItem whichMultiboarditem)
        {
            return Natives.SaveMultiboardItemHandle(table, parentKey, childKey, whichMultiboarditem);
        }

        public Boolean SaveTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTrackable whichTrackable)
        {
            return Natives.SaveTrackableHandle(table, parentKey, childKey, whichTrackable);
        }

        public Boolean SaveDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassDialog whichDialog)
        {
            return Natives.SaveDialogHandle(table, parentKey, childKey, whichDialog);
        }

        public Boolean SaveButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassButton whichButton)
        {
            return Natives.SaveButtonHandle(table, parentKey, childKey, whichButton);
        }

        public Boolean SaveTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassTextTag whichTexttag)
        {
            return Natives.SaveTextTagHandle(table, parentKey, childKey, whichTexttag);
        }

        public Boolean SaveLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassLightning whichLightning)
        {
            return Natives.SaveLightningHandle(table, parentKey, childKey, whichLightning);
        }

        public Boolean SaveImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassImage whichImage)
        {
            return Natives.SaveImageHandle(table, parentKey, childKey, whichImage);
        }

        public Boolean SaveUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassUberSplat whichUbersplat)
        {
            return Natives.SaveUbersplatHandle(table, parentKey, childKey, whichUbersplat);
        }

        public Boolean SaveRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassRegion whichRegion)
        {
            return Natives.SaveRegionHandle(table, parentKey, childKey, whichRegion);
        }

        public Boolean SaveFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogState whichFogState)
        {
            return Natives.SaveFogStateHandle(table, parentKey, childKey, whichFogState);
        }

        public Boolean SaveFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassFogModifier whichFogModifier)
        {
            return Natives.SaveFogModifierHandle(table, parentKey, childKey, whichFogModifier);
        }

        public Boolean SaveAgentHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassAgent whichAgent)
        {
            return Natives.SaveAgentHandle(table, parentKey, childKey, whichAgent);
        }

        public Boolean SaveHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey, JassHashTable whichHashtable)
        {
            return Natives.SaveHashtableHandle(table, parentKey, childKey, whichHashtable);
        }

        public JassInteger LoadInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadInteger(table, parentKey, childKey);
        }

        public Single LoadReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadReal(table, parentKey, childKey);
        }

        public Boolean LoadBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadBoolean(table, parentKey, childKey);
        }

        public String LoadStr(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadStr(table, parentKey, childKey);
        }

        public JassPlayer LoadPlayerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadPlayerHandle(table, parentKey, childKey);
        }

        public JassWidget LoadWidgetHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadWidgetHandle(table, parentKey, childKey);
        }

        public JassDestructable LoadDestructableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadDestructableHandle(table, parentKey, childKey);
        }

        public JassItem LoadItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadItemHandle(table, parentKey, childKey);
        }

        public JassUnit LoadUnitHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadUnitHandle(table, parentKey, childKey);
        }

        public JassAbility LoadAbilityHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadAbilityHandle(table, parentKey, childKey);
        }

        public JassTimer LoadTimerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadTimerHandle(table, parentKey, childKey);
        }

        public JassTrigger LoadTriggerHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadTriggerHandle(table, parentKey, childKey);
        }

        public JassTriggerCondition LoadTriggerConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadTriggerConditionHandle(table, parentKey, childKey);
        }

        public JassTriggerAction LoadTriggerActionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadTriggerActionHandle(table, parentKey, childKey);
        }

        public JassEvent LoadTriggerEventHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadTriggerEventHandle(table, parentKey, childKey);
        }

        public JassForce LoadForceHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadForceHandle(table, parentKey, childKey);
        }

        public JassGroup LoadGroupHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadGroupHandle(table, parentKey, childKey);
        }

        public JassLocation LoadLocationHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadLocationHandle(table, parentKey, childKey);
        }

        public JassRect LoadRectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadRectHandle(table, parentKey, childKey);
        }

        public JassBooleanExpression LoadBooleanExprHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadBooleanExprHandle(table, parentKey, childKey);
        }

        public JassSound LoadSoundHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadSoundHandle(table, parentKey, childKey);
        }

        public JassEffect LoadEffectHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadEffectHandle(table, parentKey, childKey);
        }

        public JassUnitPool LoadUnitPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadUnitPoolHandle(table, parentKey, childKey);
        }

        public JassItemPool LoadItemPoolHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadItemPoolHandle(table, parentKey, childKey);
        }

        public JassQuest LoadQuestHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadQuestHandle(table, parentKey, childKey);
        }

        public JassQuestItem LoadQuestItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadQuestItemHandle(table, parentKey, childKey);
        }

        public JassDefeatCondition LoadDefeatConditionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadDefeatConditionHandle(table, parentKey, childKey);
        }

        public JassTimerDialog LoadTimerDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadTimerDialogHandle(table, parentKey, childKey);
        }

        public JassLeaderboard LoadLeaderboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadLeaderboardHandle(table, parentKey, childKey);
        }

        public JassMultiboard LoadMultiboardHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadMultiboardHandle(table, parentKey, childKey);
        }

        public JassMultiboardItem LoadMultiboardItemHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadMultiboardItemHandle(table, parentKey, childKey);
        }

        public JassTrackable LoadTrackableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadTrackableHandle(table, parentKey, childKey);
        }

        public JassDialog LoadDialogHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadDialogHandle(table, parentKey, childKey);
        }

        public JassButton LoadButtonHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadButtonHandle(table, parentKey, childKey);
        }

        public JassTextTag LoadTextTagHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadTextTagHandle(table, parentKey, childKey);
        }

        public JassLightning LoadLightningHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadLightningHandle(table, parentKey, childKey);
        }

        public JassImage LoadImageHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadImageHandle(table, parentKey, childKey);
        }

        public JassUberSplat LoadUbersplatHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadUbersplatHandle(table, parentKey, childKey);
        }

        public JassRegion LoadRegionHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadRegionHandle(table, parentKey, childKey);
        }

        public JassFogState LoadFogStateHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadFogStateHandle(table, parentKey, childKey);
        }

        public JassFogModifier LoadFogModifierHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadFogModifierHandle(table, parentKey, childKey);
        }

        public JassHashTable LoadHashtableHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.LoadHashtableHandle(table, parentKey, childKey);
        }

        public Boolean HaveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.HaveSavedInteger(table, parentKey, childKey);
        }

        public Boolean HaveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.HaveSavedReal(table, parentKey, childKey);
        }

        public Boolean HaveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.HaveSavedBoolean(table, parentKey, childKey);
        }

        public Boolean HaveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.HaveSavedString(table, parentKey, childKey);
        }

        public Boolean HaveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            return Natives.HaveSavedHandle(table, parentKey, childKey);
        }

        public void RemoveSavedInteger(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.RemoveSavedInteger(table, parentKey, childKey);
        }

        public void RemoveSavedReal(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.RemoveSavedReal(table, parentKey, childKey);
        }

        public void RemoveSavedBoolean(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.RemoveSavedBoolean(table, parentKey, childKey);
        }

        public void RemoveSavedString(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.RemoveSavedString(table, parentKey, childKey);
        }

        public void RemoveSavedHandle(JassHashTable table, JassInteger parentKey, JassInteger childKey)
        {
            Natives.RemoveSavedHandle(table, parentKey, childKey);
        }

        public void FlushParentHashtable(JassHashTable table)
        {
            Natives.FlushParentHashtable(table);
        }

        public void FlushChildHashtable(JassHashTable table, JassInteger parentKey)
        {
            Natives.FlushChildHashtable(table, parentKey);
        }

        public JassInteger GetRandomInt(JassInteger lowBound, JassInteger highBound)
        {
            return Natives.GetRandomInt(lowBound, highBound);
        }

        public Single GetRandomReal(Single lowBound, Single highBound)
        {
            return Natives.GetRandomReal(lowBound, highBound);
        }

        public JassUnitPool CreateUnitPool()
        {
            return Natives.CreateUnitPool();
        }

        public void DestroyUnitPool(JassUnitPool whichPool)
        {
            Natives.DestroyUnitPool(whichPool);
        }

        public void UnitPoolAddUnitType(JassUnitPool whichPool, JassObjectId unitId, Single weight)
        {
            Natives.UnitPoolAddUnitType(whichPool, unitId, weight);
        }

        public void UnitPoolRemoveUnitType(JassUnitPool whichPool, JassObjectId unitId)
        {
            Natives.UnitPoolRemoveUnitType(whichPool, unitId);
        }

        public JassUnit PlaceRandomUnit(JassUnitPool whichPool, JassPlayer forWhichPlayer, Single x, Single y, Single facing)
        {
            return Natives.PlaceRandomUnit(whichPool, forWhichPlayer, x, y, facing);
        }

        public JassItemPool CreateItemPool()
        {
            return Natives.CreateItemPool();
        }

        public void DestroyItemPool(JassItemPool whichItemPool)
        {
            Natives.DestroyItemPool(whichItemPool);
        }

        public void ItemPoolAddItemType(JassItemPool whichItemPool, JassObjectId itemId, Single weight)
        {
            Natives.ItemPoolAddItemType(whichItemPool, itemId, weight);
        }

        public void ItemPoolRemoveItemType(JassItemPool whichItemPool, JassObjectId itemId)
        {
            Natives.ItemPoolRemoveItemType(whichItemPool, itemId);
        }

        public JassItem PlaceRandomItem(JassItemPool whichItemPool, Single x, Single y)
        {
            return Natives.PlaceRandomItem(whichItemPool, x, y);
        }

        public JassInteger ChooseRandomCreep(JassInteger level)
        {
            return Natives.ChooseRandomCreep(level);
        }

        public JassInteger ChooseRandomNPBuilding()
        {
            return Natives.ChooseRandomNPBuilding();
        }

        public JassInteger ChooseRandomItem(JassInteger level)
        {
            return Natives.ChooseRandomItem(level);
        }

        public JassInteger ChooseRandomItemEx(JassItemType whichType, JassInteger level)
        {
            return Natives.ChooseRandomItemEx(whichType, level);
        }

        public void SetRandomSeed(JassInteger seed)
        {
            Natives.SetRandomSeed(seed);
        }

        public void SetTerrainFog(Single a, Single b, Single c, Single d, Single e)
        {
            Natives.SetTerrainFog(a, b, c, d, e);
        }

        public void ResetTerrainFog()
        {
            Natives.ResetTerrainFog();
        }

        public void SetUnitFog(Single a, Single b, Single c, Single d, Single e)
        {
            Natives.SetUnitFog(a, b, c, d, e);
        }

        public void SetTerrainFogEx(JassInteger style, Single zstart, Single zend, Single density, Single red, Single green, Single blue)
        {
            Natives.SetTerrainFogEx(style, zstart, zend, density, red, green, blue);
        }

        public void DisplayTextToPlayer(JassPlayer toPlayer, Single x, Single y, String message)
        {
            Natives.DisplayTextToPlayer(toPlayer, x, y, message);
        }

        public void DisplayTimedTextToPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            Natives.DisplayTimedTextToPlayer(toPlayer, x, y, duration, message);
        }

        public void DisplayTimedTextFromPlayer(JassPlayer toPlayer, Single x, Single y, Single duration, String message)
        {
            Natives.DisplayTimedTextFromPlayer(toPlayer, x, y, duration, message);
        }

        public void ClearTextMessages()
        {
            Natives.ClearTextMessages();
        }

        public void SetDayNightModels(String terrainDNCFile, String unitDNCFile)
        {
            Natives.SetDayNightModels(terrainDNCFile, unitDNCFile);
        }

        public void SetSkyModel(String skyModelFile)
        {
            Natives.SetSkyModel(skyModelFile);
        }

        public void EnableUserControl(Boolean b)
        {
            Natives.EnableUserControl(b);
        }

        public void EnableUserUI(Boolean b)
        {
            Natives.EnableUserUI(b);
        }

        public void SuspendTimeOfDay(Boolean b)
        {
            Natives.SuspendTimeOfDay(b);
        }

        public void SetTimeOfDayScale(Single r)
        {
            Natives.SetTimeOfDayScale(r);
        }

        public Single GetTimeOfDayScale()
        {
            return Natives.GetTimeOfDayScale();
        }

        public void ShowInterface(Boolean flag, Single fadeDuration)
        {
            Natives.ShowInterface(flag, fadeDuration);
        }

        public void PauseGame(Boolean flag)
        {
            Natives.PauseGame(flag);
        }

        public void UnitAddIndicator(JassUnit whichUnit, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.UnitAddIndicator(whichUnit, red, green, blue, alpha);
        }

        public void AddIndicator(JassWidget whichWidget, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.AddIndicator(whichWidget, red, green, blue, alpha);
        }

        public void PingMinimap(Single x, Single y, Single duration)
        {
            Natives.PingMinimap(x, y, duration);
        }

        public void PingMinimapEx(Single x, Single y, Single duration, JassInteger red, JassInteger green, JassInteger blue, Boolean extraEffects)
        {
            Natives.PingMinimapEx(x, y, duration, red, green, blue, extraEffects);
        }

        public void EnableOcclusion(Boolean flag)
        {
            Natives.EnableOcclusion(flag);
        }

        public void SetIntroShotText(String introText)
        {
            Natives.SetIntroShotText(introText);
        }

        public void SetIntroShotModel(String introModelPath)
        {
            Natives.SetIntroShotModel(introModelPath);
        }

        public void EnableWorldFogBoundary(Boolean b)
        {
            Natives.EnableWorldFogBoundary(b);
        }

        public void PlayModelCinematic(String modelName)
        {
            Natives.PlayModelCinematic(modelName);
        }

        public void PlayCinematic(String movieName)
        {
            Natives.PlayCinematic(movieName);
        }

        public void ForceUIKey(String key)
        {
            Natives.ForceUIKey(key);
        }

        public void ForceUICancel()
        {
            Natives.ForceUICancel();
        }

        public void DisplayLoadDialog()
        {
            Natives.DisplayLoadDialog();
        }

        public void SetAltMinimapIcon(String iconPath)
        {
            Natives.SetAltMinimapIcon(iconPath);
        }

        public void DisableRestartMission(Boolean flag)
        {
            Natives.DisableRestartMission(flag);
        }

        public JassTextTag CreateTextTag()
        {
            return Natives.CreateTextTag();
        }

        public void DestroyTextTag(JassTextTag t)
        {
            Natives.DestroyTextTag(t);
        }

        public void SetTextTagText(JassTextTag t, String s, Single height)
        {
            Natives.SetTextTagText(t, s, height);
        }

        public void SetTextTagPos(JassTextTag t, Single x, Single y, Single heightOffset)
        {
            Natives.SetTextTagPos(t, x, y, heightOffset);
        }

        public void SetTextTagPosUnit(JassTextTag t, JassUnit whichUnit, Single heightOffset)
        {
            Natives.SetTextTagPosUnit(t, whichUnit, heightOffset);
        }

        public void SetTextTagColor(JassTextTag t, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.SetTextTagColor(t, red, green, blue, alpha);
        }

        public void SetTextTagVelocity(JassTextTag t, Single xvel, Single yvel)
        {
            Natives.SetTextTagVelocity(t, xvel, yvel);
        }

        public void SetTextTagVisibility(JassTextTag t, Boolean flag)
        {
            Natives.SetTextTagVisibility(t, flag);
        }

        public void SetTextTagSuspended(JassTextTag t, Boolean flag)
        {
            Natives.SetTextTagSuspended(t, flag);
        }

        public void SetTextTagPermanent(JassTextTag t, Boolean flag)
        {
            Natives.SetTextTagPermanent(t, flag);
        }

        public void SetTextTagAge(JassTextTag t, Single age)
        {
            Natives.SetTextTagAge(t, age);
        }

        public void SetTextTagLifespan(JassTextTag t, Single lifespan)
        {
            Natives.SetTextTagLifespan(t, lifespan);
        }

        public void SetTextTagFadepoint(JassTextTag t, Single fadepoint)
        {
            Natives.SetTextTagFadepoint(t, fadepoint);
        }

        public void SetReservedLocalHeroButtons(JassInteger reserved)
        {
            Natives.SetReservedLocalHeroButtons(reserved);
        }

        public JassInteger GetAllyColorFilterState()
        {
            return Natives.GetAllyColorFilterState();
        }

        public void SetAllyColorFilterState(JassInteger state)
        {
            Natives.SetAllyColorFilterState(state);
        }

        public Boolean GetCreepCampFilterState()
        {
            return Natives.GetCreepCampFilterState();
        }

        public void SetCreepCampFilterState(Boolean state)
        {
            Natives.SetCreepCampFilterState(state);
        }

        public void EnableMinimapFilterButtons(Boolean enableAlly, Boolean enableCreep)
        {
            Natives.EnableMinimapFilterButtons(enableAlly, enableCreep);
        }

        public void EnableDragSelect(Boolean state, Boolean ui)
        {
            Natives.EnableDragSelect(state, ui);
        }

        public void EnablePreSelect(Boolean state, Boolean ui)
        {
            Natives.EnablePreSelect(state, ui);
        }

        public void EnableSelect(Boolean state, Boolean ui)
        {
            Natives.EnableSelect(state, ui);
        }

        public JassTrackable CreateTrackable(String trackableModelPath, Single x, Single y, Single facing)
        {
            return Natives.CreateTrackable(trackableModelPath, x, y, facing);
        }

        public JassQuest CreateQuest()
        {
            return Natives.CreateQuest();
        }

        public void DestroyQuest(JassQuest whichQuest)
        {
            Natives.DestroyQuest(whichQuest);
        }

        public void QuestSetTitle(JassQuest whichQuest, String title)
        {
            Natives.QuestSetTitle(whichQuest, title);
        }

        public void QuestSetDescription(JassQuest whichQuest, String description)
        {
            Natives.QuestSetDescription(whichQuest, description);
        }

        public void QuestSetIconPath(JassQuest whichQuest, String iconPath)
        {
            Natives.QuestSetIconPath(whichQuest, iconPath);
        }

        public void QuestSetRequired(JassQuest whichQuest, Boolean required)
        {
            Natives.QuestSetRequired(whichQuest, required);
        }

        public void QuestSetCompleted(JassQuest whichQuest, Boolean completed)
        {
            Natives.QuestSetCompleted(whichQuest, completed);
        }

        public void QuestSetDiscovered(JassQuest whichQuest, Boolean discovered)
        {
            Natives.QuestSetDiscovered(whichQuest, discovered);
        }

        public void QuestSetFailed(JassQuest whichQuest, Boolean failed)
        {
            Natives.QuestSetFailed(whichQuest, failed);
        }

        public void QuestSetEnabled(JassQuest whichQuest, Boolean enabled)
        {
            Natives.QuestSetEnabled(whichQuest, enabled);
        }

        public Boolean IsQuestRequired(JassQuest whichQuest)
        {
            return Natives.IsQuestRequired(whichQuest);
        }

        public Boolean IsQuestCompleted(JassQuest whichQuest)
        {
            return Natives.IsQuestCompleted(whichQuest);
        }

        public Boolean IsQuestDiscovered(JassQuest whichQuest)
        {
            return Natives.IsQuestDiscovered(whichQuest);
        }

        public Boolean IsQuestFailed(JassQuest whichQuest)
        {
            return Natives.IsQuestFailed(whichQuest);
        }

        public Boolean IsQuestEnabled(JassQuest whichQuest)
        {
            return Natives.IsQuestEnabled(whichQuest);
        }

        public JassQuestItem QuestCreateItem(JassQuest whichQuest)
        {
            return Natives.QuestCreateItem(whichQuest);
        }

        public void QuestItemSetDescription(JassQuestItem whichQuestItem, String description)
        {
            Natives.QuestItemSetDescription(whichQuestItem, description);
        }

        public void QuestItemSetCompleted(JassQuestItem whichQuestItem, Boolean completed)
        {
            Natives.QuestItemSetCompleted(whichQuestItem, completed);
        }

        public Boolean IsQuestItemCompleted(JassQuestItem whichQuestItem)
        {
            return Natives.IsQuestItemCompleted(whichQuestItem);
        }

        public JassDefeatCondition CreateDefeatCondition()
        {
            return Natives.CreateDefeatCondition();
        }

        public void DestroyDefeatCondition(JassDefeatCondition whichCondition)
        {
            Natives.DestroyDefeatCondition(whichCondition);
        }

        public void DefeatConditionSetDescription(JassDefeatCondition whichCondition, String description)
        {
            Natives.DefeatConditionSetDescription(whichCondition, description);
        }

        public void FlashQuestDialogButton()
        {
            Natives.FlashQuestDialogButton();
        }

        public void ForceQuestDialogUpdate()
        {
            Natives.ForceQuestDialogUpdate();
        }

        public JassTimerDialog CreateTimerDialog(JassTimer t)
        {
            return Natives.CreateTimerDialog(t);
        }

        public void DestroyTimerDialog(JassTimerDialog whichDialog)
        {
            Natives.DestroyTimerDialog(whichDialog);
        }

        public void TimerDialogSetTitle(JassTimerDialog whichDialog, String title)
        {
            Natives.TimerDialogSetTitle(whichDialog, title);
        }

        public void TimerDialogSetTitleColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.TimerDialogSetTitleColor(whichDialog, red, green, blue, alpha);
        }

        public void TimerDialogSetTimeColor(JassTimerDialog whichDialog, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.TimerDialogSetTimeColor(whichDialog, red, green, blue, alpha);
        }

        public void TimerDialogSetSpeed(JassTimerDialog whichDialog, Single speedMultFactor)
        {
            Natives.TimerDialogSetSpeed(whichDialog, speedMultFactor);
        }

        public void TimerDialogDisplay(JassTimerDialog whichDialog, Boolean display)
        {
            Natives.TimerDialogDisplay(whichDialog, display);
        }

        public Boolean IsTimerDialogDisplayed(JassTimerDialog whichDialog)
        {
            return Natives.IsTimerDialogDisplayed(whichDialog);
        }

        public void TimerDialogSetRealTimeRemaining(JassTimerDialog whichDialog, Single timeRemaining)
        {
            Natives.TimerDialogSetRealTimeRemaining(whichDialog, timeRemaining);
        }

        public JassLeaderboard CreateLeaderboard()
        {
            return Natives.CreateLeaderboard();
        }

        public void DestroyLeaderboard(JassLeaderboard lb)
        {
            Natives.DestroyLeaderboard(lb);
        }

        public void LeaderboardDisplay(JassLeaderboard lb, Boolean show)
        {
            Natives.LeaderboardDisplay(lb, show);
        }

        public Boolean IsLeaderboardDisplayed(JassLeaderboard lb)
        {
            return Natives.IsLeaderboardDisplayed(lb);
        }

        public JassInteger LeaderboardGetItemCount(JassLeaderboard lb)
        {
            return Natives.LeaderboardGetItemCount(lb);
        }

        public void LeaderboardSetSizeByItemCount(JassLeaderboard lb, JassInteger count)
        {
            Natives.LeaderboardSetSizeByItemCount(lb, count);
        }

        public void LeaderboardAddItem(JassLeaderboard lb, String label, JassInteger value, JassPlayer p)
        {
            Natives.LeaderboardAddItem(lb, label, value, p);
        }

        public void LeaderboardRemoveItem(JassLeaderboard lb, JassInteger index)
        {
            Natives.LeaderboardRemoveItem(lb, index);
        }

        public void LeaderboardRemovePlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            Natives.LeaderboardRemovePlayerItem(lb, p);
        }

        public void LeaderboardClear(JassLeaderboard lb)
        {
            Natives.LeaderboardClear(lb);
        }

        public void LeaderboardSortItemsByValue(JassLeaderboard lb, Boolean ascending)
        {
            Natives.LeaderboardSortItemsByValue(lb, ascending);
        }

        public void LeaderboardSortItemsByPlayer(JassLeaderboard lb, Boolean ascending)
        {
            Natives.LeaderboardSortItemsByPlayer(lb, ascending);
        }

        public void LeaderboardSortItemsByLabel(JassLeaderboard lb, Boolean ascending)
        {
            Natives.LeaderboardSortItemsByLabel(lb, ascending);
        }

        public Boolean LeaderboardHasPlayerItem(JassLeaderboard lb, JassPlayer p)
        {
            return Natives.LeaderboardHasPlayerItem(lb, p);
        }

        public JassInteger LeaderboardGetPlayerIndex(JassLeaderboard lb, JassPlayer p)
        {
            return Natives.LeaderboardGetPlayerIndex(lb, p);
        }

        public void LeaderboardSetLabel(JassLeaderboard lb, String label)
        {
            Natives.LeaderboardSetLabel(lb, label);
        }

        public String LeaderboardGetLabelText(JassLeaderboard lb)
        {
            return Natives.LeaderboardGetLabelText(lb);
        }

        public void PlayerSetLeaderboard(JassPlayer toPlayer, JassLeaderboard lb)
        {
            Natives.PlayerSetLeaderboard(toPlayer, lb);
        }

        public JassLeaderboard PlayerGetLeaderboard(JassPlayer toPlayer)
        {
            return Natives.PlayerGetLeaderboard(toPlayer);
        }

        public void LeaderboardSetLabelColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.LeaderboardSetLabelColor(lb, red, green, blue, alpha);
        }

        public void LeaderboardSetValueColor(JassLeaderboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.LeaderboardSetValueColor(lb, red, green, blue, alpha);
        }

        public void LeaderboardSetStyle(JassLeaderboard lb, Boolean showLabel, Boolean showNames, Boolean showValues, Boolean showIcons)
        {
            Natives.LeaderboardSetStyle(lb, showLabel, showNames, showValues, showIcons);
        }

        public void LeaderboardSetItemValue(JassLeaderboard lb, JassInteger whichItem, JassInteger val)
        {
            Natives.LeaderboardSetItemValue(lb, whichItem, val);
        }

        public void LeaderboardSetItemLabel(JassLeaderboard lb, JassInteger whichItem, String val)
        {
            Natives.LeaderboardSetItemLabel(lb, whichItem, val);
        }

        public void LeaderboardSetItemStyle(JassLeaderboard lb, JassInteger whichItem, Boolean showLabel, Boolean showValue, Boolean showIcon)
        {
            Natives.LeaderboardSetItemStyle(lb, whichItem, showLabel, showValue, showIcon);
        }

        public void LeaderboardSetItemLabelColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.LeaderboardSetItemLabelColor(lb, whichItem, red, green, blue, alpha);
        }

        public void LeaderboardSetItemValueColor(JassLeaderboard lb, JassInteger whichItem, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.LeaderboardSetItemValueColor(lb, whichItem, red, green, blue, alpha);
        }

        public JassMultiboard CreateMultiboard()
        {
            return Natives.CreateMultiboard();
        }

        public void DestroyMultiboard(JassMultiboard lb)
        {
            Natives.DestroyMultiboard(lb);
        }

        public void MultiboardDisplay(JassMultiboard lb, Boolean show)
        {
            Natives.MultiboardDisplay(lb, show);
        }

        public Boolean IsMultiboardDisplayed(JassMultiboard lb)
        {
            return Natives.IsMultiboardDisplayed(lb);
        }

        public void MultiboardMinimize(JassMultiboard lb, Boolean minimize)
        {
            Natives.MultiboardMinimize(lb, minimize);
        }

        public Boolean IsMultiboardMinimized(JassMultiboard lb)
        {
            return Natives.IsMultiboardMinimized(lb);
        }

        public void MultiboardClear(JassMultiboard lb)
        {
            Natives.MultiboardClear(lb);
        }

        public void MultiboardSetTitleText(JassMultiboard lb, String label)
        {
            Natives.MultiboardSetTitleText(lb, label);
        }

        public String MultiboardGetTitleText(JassMultiboard lb)
        {
            return Natives.MultiboardGetTitleText(lb);
        }

        public void MultiboardSetTitleTextColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.MultiboardSetTitleTextColor(lb, red, green, blue, alpha);
        }

        public JassInteger MultiboardGetRowCount(JassMultiboard lb)
        {
            return Natives.MultiboardGetRowCount(lb);
        }

        public JassInteger MultiboardGetColumnCount(JassMultiboard lb)
        {
            return Natives.MultiboardGetColumnCount(lb);
        }

        public void MultiboardSetColumnCount(JassMultiboard lb, JassInteger count)
        {
            Natives.MultiboardSetColumnCount(lb, count);
        }

        public void MultiboardSetRowCount(JassMultiboard lb, JassInteger count)
        {
            Natives.MultiboardSetRowCount(lb, count);
        }

        public void MultiboardSetItemsStyle(JassMultiboard lb, Boolean showValues, Boolean showIcons)
        {
            Natives.MultiboardSetItemsStyle(lb, showValues, showIcons);
        }

        public void MultiboardSetItemsValue(JassMultiboard lb, String value)
        {
            Natives.MultiboardSetItemsValue(lb, value);
        }

        public void MultiboardSetItemsValueColor(JassMultiboard lb, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.MultiboardSetItemsValueColor(lb, red, green, blue, alpha);
        }

        public void MultiboardSetItemsWidth(JassMultiboard lb, Single width)
        {
            Natives.MultiboardSetItemsWidth(lb, width);
        }

        public void MultiboardSetItemsIcon(JassMultiboard lb, String iconPath)
        {
            Natives.MultiboardSetItemsIcon(lb, iconPath);
        }

        public JassMultiboardItem MultiboardGetItem(JassMultiboard lb, JassInteger row, JassInteger column)
        {
            return Natives.MultiboardGetItem(lb, row, column);
        }

        public void MultiboardReleaseItem(JassMultiboardItem mbi)
        {
            Natives.MultiboardReleaseItem(mbi);
        }

        public void MultiboardSetItemStyle(JassMultiboardItem mbi, Boolean showValue, Boolean showIcon)
        {
            Natives.MultiboardSetItemStyle(mbi, showValue, showIcon);
        }

        public void MultiboardSetItemValue(JassMultiboardItem mbi, String val)
        {
            Natives.MultiboardSetItemValue(mbi, val);
        }

        public void MultiboardSetItemValueColor(JassMultiboardItem mbi, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.MultiboardSetItemValueColor(mbi, red, green, blue, alpha);
        }

        public void MultiboardSetItemWidth(JassMultiboardItem mbi, Single width)
        {
            Natives.MultiboardSetItemWidth(mbi, width);
        }

        public void MultiboardSetItemIcon(JassMultiboardItem mbi, String iconFileName)
        {
            Natives.MultiboardSetItemIcon(mbi, iconFileName);
        }

        public void MultiboardSuppressDisplay(Boolean flag)
        {
            Natives.MultiboardSuppressDisplay(flag);
        }

        public void SetCameraPosition(Single x, Single y)
        {
            Natives.SetCameraPosition(x, y);
        }

        public void SetCameraQuickPosition(Single x, Single y)
        {
            Natives.SetCameraQuickPosition(x, y);
        }

        public void SetCameraBounds(Single x1, Single y1, Single x2, Single y2, Single x3, Single y3, Single x4, Single y4)
        {
            Natives.SetCameraBounds(x1, y1, x2, y2, x3, y3, x4, y4);
        }

        public void StopCamera()
        {
            Natives.StopCamera();
        }

        public void ResetToGameCamera(Single duration)
        {
            Natives.ResetToGameCamera(duration);
        }

        public void PanCameraTo(Single x, Single y)
        {
            Natives.PanCameraTo(x, y);
        }

        public void PanCameraToTimed(Single x, Single y, Single duration)
        {
            Natives.PanCameraToTimed(x, y, duration);
        }

        public void PanCameraToWithZ(Single x, Single y, Single zOffsetDest)
        {
            Natives.PanCameraToWithZ(x, y, zOffsetDest);
        }

        public void PanCameraToTimedWithZ(Single x, Single y, Single zOffsetDest, Single duration)
        {
            Natives.PanCameraToTimedWithZ(x, y, zOffsetDest, duration);
        }

        public void SetCinematicCamera(String cameraModelFile)
        {
            Natives.SetCinematicCamera(cameraModelFile);
        }

        public void SetCameraRotateMode(Single x, Single y, Single radiansToSweep, Single duration)
        {
            Natives.SetCameraRotateMode(x, y, radiansToSweep, duration);
        }

        public void SetCameraField(JassCameraField whichField, Single value, Single duration)
        {
            Natives.SetCameraField(whichField, value, duration);
        }

        public void AdjustCameraField(JassCameraField whichField, Single offset, Single duration)
        {
            Natives.AdjustCameraField(whichField, offset, duration);
        }

        public void SetCameraTargetController(JassUnit whichUnit, Single xoffset, Single yoffset, Boolean inheritOrientation)
        {
            Natives.SetCameraTargetController(whichUnit, xoffset, yoffset, inheritOrientation);
        }

        public void SetCameraOrientController(JassUnit whichUnit, Single xoffset, Single yoffset)
        {
            Natives.SetCameraOrientController(whichUnit, xoffset, yoffset);
        }

        public JassCameraSetup CreateCameraSetup()
        {
            return Natives.CreateCameraSetup();
        }

        public void CameraSetupSetField(JassCameraSetup whichSetup, JassCameraField whichField, Single value, Single duration)
        {
            Natives.CameraSetupSetField(whichSetup, whichField, value, duration);
        }

        public Single CameraSetupGetField(JassCameraSetup whichSetup, JassCameraField whichField)
        {
            return Natives.CameraSetupGetField(whichSetup, whichField);
        }

        public void CameraSetupSetDestPosition(JassCameraSetup whichSetup, Single x, Single y, Single duration)
        {
            Natives.CameraSetupSetDestPosition(whichSetup, x, y, duration);
        }

        public JassLocation CameraSetupGetDestPositionLoc(JassCameraSetup whichSetup)
        {
            return Natives.CameraSetupGetDestPositionLoc(whichSetup);
        }

        public Single CameraSetupGetDestPositionX(JassCameraSetup whichSetup)
        {
            return Natives.CameraSetupGetDestPositionX(whichSetup);
        }

        public Single CameraSetupGetDestPositionY(JassCameraSetup whichSetup)
        {
            return Natives.CameraSetupGetDestPositionY(whichSetup);
        }

        public void CameraSetupApply(JassCameraSetup whichSetup, Boolean doPan, Boolean panTimed)
        {
            Natives.CameraSetupApply(whichSetup, doPan, panTimed);
        }

        public void CameraSetupApplyWithZ(JassCameraSetup whichSetup, Single zDestOffset)
        {
            Natives.CameraSetupApplyWithZ(whichSetup, zDestOffset);
        }

        public void CameraSetupApplyForceDuration(JassCameraSetup whichSetup, Boolean doPan, Single forceDuration)
        {
            Natives.CameraSetupApplyForceDuration(whichSetup, doPan, forceDuration);
        }

        public void CameraSetupApplyForceDurationWithZ(JassCameraSetup whichSetup, Single zDestOffset, Single forceDuration)
        {
            Natives.CameraSetupApplyForceDurationWithZ(whichSetup, zDestOffset, forceDuration);
        }

        public void CameraSetTargetNoise(Single mag, Single velocity)
        {
            Natives.CameraSetTargetNoise(mag, velocity);
        }

        public void CameraSetSourceNoise(Single mag, Single velocity)
        {
            Natives.CameraSetSourceNoise(mag, velocity);
        }

        public void CameraSetTargetNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            Natives.CameraSetTargetNoiseEx(mag, velocity, vertOnly);
        }

        public void CameraSetSourceNoiseEx(Single mag, Single velocity, Boolean vertOnly)
        {
            Natives.CameraSetSourceNoiseEx(mag, velocity, vertOnly);
        }

        public void CameraSetSmoothingFactor(Single factor)
        {
            Natives.CameraSetSmoothingFactor(factor);
        }

        public void SetCineFilterTexture(String filename)
        {
            Natives.SetCineFilterTexture(filename);
        }

        public void SetCineFilterBlendMode(JassBlendMode whichMode)
        {
            Natives.SetCineFilterBlendMode(whichMode);
        }

        public void SetCineFilterTexMapFlags(JassTextureMapFlags whichFlags)
        {
            Natives.SetCineFilterTexMapFlags(whichFlags);
        }

        public void SetCineFilterStartUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            Natives.SetCineFilterStartUV(minu, minv, maxu, maxv);
        }

        public void SetCineFilterEndUV(Single minu, Single minv, Single maxu, Single maxv)
        {
            Natives.SetCineFilterEndUV(minu, minv, maxu, maxv);
        }

        public void SetCineFilterStartColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.SetCineFilterStartColor(red, green, blue, alpha);
        }

        public void SetCineFilterEndColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.SetCineFilterEndColor(red, green, blue, alpha);
        }

        public void SetCineFilterDuration(Single duration)
        {
            Natives.SetCineFilterDuration(duration);
        }

        public void DisplayCineFilter(Boolean flag)
        {
            Natives.DisplayCineFilter(flag);
        }

        public Boolean IsCineFilterDisplayed()
        {
            return Natives.IsCineFilterDisplayed();
        }

        public void SetCinematicScene(JassInteger portraitUnitId, JassPlayerColor color, String speakerTitle, String text, Single sceneDuration, Single voiceoverDuration)
        {
            Natives.SetCinematicScene(portraitUnitId, color, speakerTitle, text, sceneDuration, voiceoverDuration);
        }

        public void EndCinematicScene()
        {
            Natives.EndCinematicScene();
        }

        public void ForceCinematicSubtitles(Boolean flag)
        {
            Natives.ForceCinematicSubtitles(flag);
        }

        public Single GetCameraMargin(JassInteger whichMargin)
        {
            return Natives.GetCameraMargin(whichMargin);
        }

        public Single GetCameraBoundMinX()
        {
            return Natives.GetCameraBoundMinX();
        }

        public Single GetCameraBoundMinY()
        {
            return Natives.GetCameraBoundMinY();
        }

        public Single GetCameraBoundMaxX()
        {
            return Natives.GetCameraBoundMaxX();
        }

        public Single GetCameraBoundMaxY()
        {
            return Natives.GetCameraBoundMaxY();
        }

        public Single GetCameraField(JassCameraField whichField)
        {
            return Natives.GetCameraField(whichField);
        }

        public Single GetCameraTargetPositionX()
        {
            return Natives.GetCameraTargetPositionX();
        }

        public Single GetCameraTargetPositionY()
        {
            return Natives.GetCameraTargetPositionY();
        }

        public Single GetCameraTargetPositionZ()
        {
            return Natives.GetCameraTargetPositionZ();
        }

        public JassLocation GetCameraTargetPositionLoc()
        {
            return Natives.GetCameraTargetPositionLoc();
        }

        public Single GetCameraEyePositionX()
        {
            return Natives.GetCameraEyePositionX();
        }

        public Single GetCameraEyePositionY()
        {
            return Natives.GetCameraEyePositionY();
        }

        public Single GetCameraEyePositionZ()
        {
            return Natives.GetCameraEyePositionZ();
        }

        public JassLocation GetCameraEyePositionLoc()
        {
            return Natives.GetCameraEyePositionLoc();
        }

        public void NewSoundEnvironment(String environmentName)
        {
            Natives.NewSoundEnvironment(environmentName);
        }

        public JassSound CreateSound(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String eaxSetting)
        {
            return Natives.CreateSound(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, eaxSetting);
        }

        public JassSound CreateSoundFilenameWithLabel(String fileName, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate, String SLKEntryName)
        {
            return Natives.CreateSoundFilenameWithLabel(fileName, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate, SLKEntryName);
        }

        public JassSound CreateSoundFromLabel(String soundLabel, Boolean looping, Boolean is3D, Boolean stopwhenoutofrange, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return Natives.CreateSoundFromLabel(soundLabel, looping, is3D, stopwhenoutofrange, fadeInRate, fadeOutRate);
        }

        public JassSound CreateMIDISound(String soundLabel, JassInteger fadeInRate, JassInteger fadeOutRate)
        {
            return Natives.CreateMIDISound(soundLabel, fadeInRate, fadeOutRate);
        }

        public void SetSoundParamsFromLabel(JassSound soundHandle, String soundLabel)
        {
            Natives.SetSoundParamsFromLabel(soundHandle, soundLabel);
        }

        public void SetSoundDistanceCutoff(JassSound soundHandle, Single cutoff)
        {
            Natives.SetSoundDistanceCutoff(soundHandle, cutoff);
        }

        public void SetSoundChannel(JassSound soundHandle, JassInteger channel)
        {
            Natives.SetSoundChannel(soundHandle, channel);
        }

        public void SetSoundVolume(JassSound soundHandle, JassInteger volume)
        {
            Natives.SetSoundVolume(soundHandle, volume);
        }

        public void SetSoundPitch(JassSound soundHandle, Single pitch)
        {
            Natives.SetSoundPitch(soundHandle, pitch);
        }

        public void SetSoundPlayPosition(JassSound soundHandle, JassInteger millisecs)
        {
            Natives.SetSoundPlayPosition(soundHandle, millisecs);
        }

        public void SetSoundDistances(JassSound soundHandle, Single minDist, Single maxDist)
        {
            Natives.SetSoundDistances(soundHandle, minDist, maxDist);
        }

        public void SetSoundConeAngles(JassSound soundHandle, Single inside, Single outside, JassInteger outsideVolume)
        {
            Natives.SetSoundConeAngles(soundHandle, inside, outside, outsideVolume);
        }

        public void SetSoundConeOrientation(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives.SetSoundConeOrientation(soundHandle, x, y, z);
        }

        public void SetSoundPosition(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives.SetSoundPosition(soundHandle, x, y, z);
        }

        public void SetSoundVelocity(JassSound soundHandle, Single x, Single y, Single z)
        {
            Natives.SetSoundVelocity(soundHandle, x, y, z);
        }

        public void AttachSoundToUnit(JassSound soundHandle, JassUnit whichUnit)
        {
            Natives.AttachSoundToUnit(soundHandle, whichUnit);
        }

        public void StartSound(JassSound soundHandle)
        {
            Natives.StartSound(soundHandle);
        }

        public void StopSound(JassSound soundHandle, Boolean killWhenDone, Boolean fadeOut)
        {
            Natives.StopSound(soundHandle, killWhenDone, fadeOut);
        }

        public void KillSoundWhenDone(JassSound soundHandle)
        {
            Natives.KillSoundWhenDone(soundHandle);
        }

        public void SetMapMusic(String musicName, Boolean random, JassInteger index)
        {
            Natives.SetMapMusic(musicName, random, index);
        }

        public void ClearMapMusic()
        {
            Natives.ClearMapMusic();
        }

        public void PlayMusic(String musicName)
        {
            Natives.PlayMusic(musicName);
        }

        public void PlayMusicEx(String musicName, JassInteger frommsecs, JassInteger fadeinmsecs)
        {
            Natives.PlayMusicEx(musicName, frommsecs, fadeinmsecs);
        }

        public void StopMusic(Boolean fadeOut)
        {
            Natives.StopMusic(fadeOut);
        }

        public void ResumeMusic()
        {
            Natives.ResumeMusic();
        }

        public void PlayThematicMusic(String musicFileName)
        {
            Natives.PlayThematicMusic(musicFileName);
        }

        public void PlayThematicMusicEx(String musicFileName, JassInteger frommsecs)
        {
            Natives.PlayThematicMusicEx(musicFileName, frommsecs);
        }

        public void EndThematicMusic()
        {
            Natives.EndThematicMusic();
        }

        public void SetMusicVolume(JassInteger volume)
        {
            Natives.SetMusicVolume(volume);
        }

        public void SetMusicPlayPosition(JassInteger millisecs)
        {
            Natives.SetMusicPlayPosition(millisecs);
        }

        public void SetThematicMusicPlayPosition(JassInteger millisecs)
        {
            Natives.SetThematicMusicPlayPosition(millisecs);
        }

        public void SetSoundDuration(JassSound soundHandle, JassInteger duration)
        {
            Natives.SetSoundDuration(soundHandle, duration);
        }

        public JassInteger GetSoundDuration(JassSound soundHandle)
        {
            return Natives.GetSoundDuration(soundHandle);
        }

        public JassInteger GetSoundFileDuration(String musicFileName)
        {
            return Natives.GetSoundFileDuration(musicFileName);
        }

        public void VolumeGroupSetVolume(JassVolumeGroup vgroup, Single scale)
        {
            Natives.VolumeGroupSetVolume(vgroup, scale);
        }

        public void VolumeGroupReset()
        {
            Natives.VolumeGroupReset();
        }

        public Boolean GetSoundIsPlaying(JassSound soundHandle)
        {
            return Natives.GetSoundIsPlaying(soundHandle);
        }

        public Boolean GetSoundIsLoading(JassSound soundHandle)
        {
            return Natives.GetSoundIsLoading(soundHandle);
        }

        public void RegisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            Natives.RegisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }

        public void UnregisterStackedSound(JassSound soundHandle, Boolean byPosition, Single rectwidth, Single rectheight)
        {
            Natives.UnregisterStackedSound(soundHandle, byPosition, rectwidth, rectheight);
        }

        public JassWeatherEffect AddWeatherEffect(JassRect where, JassInteger effectID)
        {
            return Natives.AddWeatherEffect(where, effectID);
        }

        public void RemoveWeatherEffect(JassWeatherEffect whichEffect)
        {
            Natives.RemoveWeatherEffect(whichEffect);
        }

        public void EnableWeatherEffect(JassWeatherEffect whichEffect, Boolean enable)
        {
            Natives.EnableWeatherEffect(whichEffect, enable);
        }

        public JassTerrainDeformation TerrainDeformCrater(Single x, Single y, Single radius, Single depth, JassInteger duration, Boolean permanent)
        {
            return Natives.TerrainDeformCrater(x, y, radius, depth, duration, permanent);
        }

        public JassTerrainDeformation TerrainDeformRipple(Single x, Single y, Single radius, Single depth, JassInteger duration, JassInteger count, Single spaceWaves, Single timeWaves, Single radiusStartPct, Boolean limitNeg)
        {
            return Natives.TerrainDeformRipple(x, y, radius, depth, duration, count, spaceWaves, timeWaves, radiusStartPct, limitNeg);
        }

        public JassTerrainDeformation TerrainDeformWave(Single x, Single y, Single dirX, Single dirY, Single distance, Single speed, Single radius, Single depth, JassInteger trailTime, JassInteger count)
        {
            return Natives.TerrainDeformWave(x, y, dirX, dirY, distance, speed, radius, depth, trailTime, count);
        }

        public JassTerrainDeformation TerrainDeformRandom(Single x, Single y, Single radius, Single minDelta, Single maxDelta, JassInteger duration, JassInteger updateInterval)
        {
            return Natives.TerrainDeformRandom(x, y, radius, minDelta, maxDelta, duration, updateInterval);
        }

        public void TerrainDeformStop(JassTerrainDeformation deformation, JassInteger duration)
        {
            Natives.TerrainDeformStop(deformation, duration);
        }

        public void TerrainDeformStopAll()
        {
            Natives.TerrainDeformStopAll();
        }

        public JassEffect AddSpecialEffect(String modelName, Single x, Single y)
        {
            return Natives.AddSpecialEffect(modelName, x, y);
        }

        public JassEffect AddSpecialEffectLoc(String modelName, JassLocation where)
        {
            return Natives.AddSpecialEffectLoc(modelName, where);
        }

        public JassEffect AddSpecialEffectTarget(String modelName, JassWidget targetWidget, String attachPointName)
        {
            return Natives.AddSpecialEffectTarget(modelName, targetWidget, attachPointName);
        }

        public void DestroyEffect(JassEffect whichEffect)
        {
            Natives.DestroyEffect(whichEffect);
        }

        public JassEffect AddSpellEffect(String abilityString, JassEffectType t, Single x, Single y)
        {
            return Natives.AddSpellEffect(abilityString, t, x, y);
        }

        public JassEffect AddSpellEffectLoc(String abilityString, JassEffectType t, JassLocation where)
        {
            return Natives.AddSpellEffectLoc(abilityString, t, where);
        }

        public JassEffect AddSpellEffectById(JassInteger abilityId, JassEffectType t, Single x, Single y)
        {
            return Natives.AddSpellEffectById(abilityId, t, x, y);
        }

        public JassEffect AddSpellEffectByIdLoc(JassInteger abilityId, JassEffectType t, JassLocation where)
        {
            return Natives.AddSpellEffectByIdLoc(abilityId, t, where);
        }

        public JassEffect AddSpellEffectTarget(String modelName, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return Natives.AddSpellEffectTarget(modelName, t, targetWidget, attachPoint);
        }

        public JassEffect AddSpellEffectTargetById(JassInteger abilityId, JassEffectType t, JassWidget targetWidget, String attachPoint)
        {
            return Natives.AddSpellEffectTargetById(abilityId, t, targetWidget, attachPoint);
        }

        public JassLightning AddLightning(String codeName, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return Natives.AddLightning(codeName, checkVisibility, x1, y1, x2, y2);
        }

        public JassLightning AddLightningEx(String codeName, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return Natives.AddLightningEx(codeName, checkVisibility, x1, y1, z1, x2, y2, z2);
        }

        public Boolean DestroyLightning(JassLightning whichBolt)
        {
            return Natives.DestroyLightning(whichBolt);
        }

        public Boolean MoveLightning(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single x2, Single y2)
        {
            return Natives.MoveLightning(whichBolt, checkVisibility, x1, y1, x2, y2);
        }

        public Boolean MoveLightningEx(JassLightning whichBolt, Boolean checkVisibility, Single x1, Single y1, Single z1, Single x2, Single y2, Single z2)
        {
            return Natives.MoveLightningEx(whichBolt, checkVisibility, x1, y1, z1, x2, y2, z2);
        }

        public Single GetLightningColorA(JassLightning whichBolt)
        {
            return Natives.GetLightningColorA(whichBolt);
        }

        public Single GetLightningColorR(JassLightning whichBolt)
        {
            return Natives.GetLightningColorR(whichBolt);
        }

        public Single GetLightningColorG(JassLightning whichBolt)
        {
            return Natives.GetLightningColorG(whichBolt);
        }

        public Single GetLightningColorB(JassLightning whichBolt)
        {
            return Natives.GetLightningColorB(whichBolt);
        }

        public Boolean SetLightningColor(JassLightning whichBolt, Single r, Single g, Single b, Single a)
        {
            return Natives.SetLightningColor(whichBolt, r, g, b, a);
        }

        public String GetAbilityEffect(String abilityString, JassEffectType t, JassInteger index)
        {
            return Natives.GetAbilityEffect(abilityString, t, index);
        }

        public String GetAbilityEffectById(JassInteger abilityId, JassEffectType t, JassInteger index)
        {
            return Natives.GetAbilityEffectById(abilityId, t, index);
        }

        public String GetAbilitySound(String abilityString, JassSoundType t)
        {
            return Natives.GetAbilitySound(abilityString, t);
        }

        public String GetAbilitySoundById(JassInteger abilityId, JassSoundType t)
        {
            return Natives.GetAbilitySoundById(abilityId, t);
        }

        public JassInteger GetTerrainCliffLevel(Single x, Single y)
        {
            return Natives.GetTerrainCliffLevel(x, y);
        }

        public void SetWaterBaseColor(JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.SetWaterBaseColor(red, green, blue, alpha);
        }

        public void SetWaterDeforms(Boolean val)
        {
            Natives.SetWaterDeforms(val);
        }

        public JassInteger GetTerrainType(Single x, Single y)
        {
            return Natives.GetTerrainType(x, y);
        }

        public JassInteger GetTerrainVariance(Single x, Single y)
        {
            return Natives.GetTerrainVariance(x, y);
        }

        public void SetTerrainType(Single x, Single y, JassInteger terrainType, JassInteger variation, JassInteger area, JassInteger shape)
        {
            Natives.SetTerrainType(x, y, terrainType, variation, area, shape);
        }

        public Boolean IsTerrainPathable(Single x, Single y, JassPathingType t)
        {
            return Natives.IsTerrainPathable(x, y, t);
        }

        public void SetTerrainPathable(Single x, Single y, JassPathingType t, Boolean flag)
        {
            Natives.SetTerrainPathable(x, y, t, flag);
        }

        public JassImage CreateImage(String file, Single sizeX, Single sizeY, Single sizeZ, Single posX, Single posY, Single posZ, Single originX, Single originY, Single originZ, JassInteger imageType)
        {
            return Natives.CreateImage(file, sizeX, sizeY, sizeZ, posX, posY, posZ, originX, originY, originZ, imageType);
        }

        public void DestroyImage(JassImage whichImage)
        {
            Natives.DestroyImage(whichImage);
        }

        public void ShowImage(JassImage whichImage, Boolean flag)
        {
            Natives.ShowImage(whichImage, flag);
        }

        public void SetImageConstantHeight(JassImage whichImage, Boolean flag, Single height)
        {
            Natives.SetImageConstantHeight(whichImage, flag, height);
        }

        public void SetImagePosition(JassImage whichImage, Single x, Single y, Single z)
        {
            Natives.SetImagePosition(whichImage, x, y, z);
        }

        public void SetImageColor(JassImage whichImage, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha)
        {
            Natives.SetImageColor(whichImage, red, green, blue, alpha);
        }

        public void SetImageRender(JassImage whichImage, Boolean flag)
        {
            Natives.SetImageRender(whichImage, flag);
        }

        public void SetImageRenderAlways(JassImage whichImage, Boolean flag)
        {
            Natives.SetImageRenderAlways(whichImage, flag);
        }

        public void SetImageAboveWater(JassImage whichImage, Boolean flag, Boolean useWaterAlpha)
        {
            Natives.SetImageAboveWater(whichImage, flag, useWaterAlpha);
        }

        public void SetImageType(JassImage whichImage, JassInteger imageType)
        {
            Natives.SetImageType(whichImage, imageType);
        }

        public JassUberSplat CreateUbersplat(Single x, Single y, String name, JassInteger red, JassInteger green, JassInteger blue, JassInteger alpha, Boolean forcePaused, Boolean noBirthTime)
        {
            return Natives.CreateUbersplat(x, y, name, red, green, blue, alpha, forcePaused, noBirthTime);
        }

        public void DestroyUbersplat(JassUberSplat whichSplat)
        {
            Natives.DestroyUbersplat(whichSplat);
        }

        public void ResetUbersplat(JassUberSplat whichSplat)
        {
            Natives.ResetUbersplat(whichSplat);
        }

        public void FinishUbersplat(JassUberSplat whichSplat)
        {
            Natives.FinishUbersplat(whichSplat);
        }

        public void ShowUbersplat(JassUberSplat whichSplat, Boolean flag)
        {
            Natives.ShowUbersplat(whichSplat, flag);
        }

        public void SetUbersplatRender(JassUberSplat whichSplat, Boolean flag)
        {
            Natives.SetUbersplatRender(whichSplat, flag);
        }

        public void SetUbersplatRenderAlways(JassUberSplat whichSplat, Boolean flag)
        {
            Natives.SetUbersplatRenderAlways(whichSplat, flag);
        }

        public void SetBlight(JassPlayer whichPlayer, Single x, Single y, Single radius, Boolean addBlight)
        {
            Natives.SetBlight(whichPlayer, x, y, radius, addBlight);
        }

        public void SetBlightRect(JassPlayer whichPlayer, JassRect r, Boolean addBlight)
        {
            Natives.SetBlightRect(whichPlayer, r, addBlight);
        }

        public void SetBlightPoint(JassPlayer whichPlayer, Single x, Single y, Boolean addBlight)
        {
            Natives.SetBlightPoint(whichPlayer, x, y, addBlight);
        }

        public void SetBlightLoc(JassPlayer whichPlayer, JassLocation whichLocation, Single radius, Boolean addBlight)
        {
            Natives.SetBlightLoc(whichPlayer, whichLocation, radius, addBlight);
        }

        public JassUnit CreateBlightedGoldmine(JassPlayer id, Single x, Single y, Single face)
        {
            return Natives.CreateBlightedGoldmine(id, x, y, face);
        }

        public Boolean IsPointBlighted(Single x, Single y)
        {
            return Natives.IsPointBlighted(x, y);
        }

        public void SetDoodadAnimation(Single x, Single y, Single radius, JassObjectId doodadID, Boolean nearestOnly, String animName, Boolean animRandom)
        {
            Natives.SetDoodadAnimation(x, y, radius, doodadID, nearestOnly, animName, animRandom);
        }

        public void SetDoodadAnimationRect(JassRect r, JassObjectId doodadID, String animName, Boolean animRandom)
        {
            Natives.SetDoodadAnimationRect(r, doodadID, animName, animRandom);
        }

        public void StartMeleeAI(JassPlayer num, String script)
        {
            Natives.StartMeleeAI(num, script);
        }

        public void StartCampaignAI(JassPlayer num, String script)
        {
            Natives.StartCampaignAI(num, script);
        }

        public void CommandAI(JassPlayer num, JassInteger command, JassInteger data)
        {
            Natives.CommandAI(num, command, data);
        }

        public void PauseCompAI(JassPlayer p, Boolean pause)
        {
            Natives.PauseCompAI(p, pause);
        }

        public JassAIDifficulty GetAIDifficulty(JassPlayer num)
        {
            return Natives.GetAIDifficulty(num);
        }

        public void RemoveGuardPosition(JassUnit hUnit)
        {
            Natives.RemoveGuardPosition(hUnit);
        }

        public void RecycleGuardPosition(JassUnit hUnit)
        {
            Natives.RecycleGuardPosition(hUnit);
        }

        public void RemoveAllGuardPositions(JassPlayer num)
        {
            Natives.RemoveAllGuardPositions(num);
        }

        public void Cheat(String cheatStr)
        {
            Natives.Cheat(cheatStr);
        }

        public Boolean IsNoVictoryCheat()
        {
            return Natives.IsNoVictoryCheat();
        }

        public Boolean IsNoDefeatCheat()
        {
            return Natives.IsNoDefeatCheat();
        }

        public void Preload(String filename)
        {
            Natives.Preload(filename);
        }

        public void PreloadEnd(Single timeout)
        {
            Natives.PreloadEnd(timeout);
        }

        public void PreloadStart()
        {
            Natives.PreloadStart();
        }

        public void PreloadRefresh()
        {
            Natives.PreloadRefresh();
        }

        public void PreloadEndEx()
        {
            Natives.PreloadEndEx();
        }

        public void PreloadGenClear()
        {
            Natives.PreloadGenClear();
        }

        public void PreloadGenStart()
        {
            Natives.PreloadGenStart();
        }

        public void PreloadGenEnd(String filename)
        {
            Natives.PreloadGenEnd(filename);
        }

        public void Preloader(String filename)
        {
            Natives.Preloader(filename);
        }

    }
}
