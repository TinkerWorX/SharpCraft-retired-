using System;
using TinkerWorX.SharpCraft.Blizzard.GameModule.Types;
using TinkerWorX.SharpCraft.Blizzard.Types;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassTrigger
    {
        public CTriggerWar3Ptr ToCTrigger()
        {
            return GameFunctions.GetTriggerFromHandle(this);
        }

        public static JassTrigger Create()
        {
            return SafeNatives.CreateTrigger();
        }

        public void AddAction(JassCode action)
        {
            SafeNatives.TriggerAddAction(this, action);
        }

        public void AddAction(ManagedAction action)
        {
            SafeNatives.TriggerAddAction(this, action);
        }

        public JassEvent RegisterVariableEvent(String variableName, JassLimitOp opcode, Single value)
        {
            return SafeNatives.TriggerRegisterVariableEvent(this, variableName, opcode, value);
        }

        public JassEvent RegisterTimerEvent(Single timeout, Boolean periodic)
        {
            return SafeNatives.TriggerRegisterTimerEvent(this, timeout, periodic);
        }

        public JassEvent RegisterTimerExpireEvent(JassTimer timer)
        {
            return SafeNatives.TriggerRegisterTimerExpireEvent(this, timer);
        }

        public JassEvent RegisterGameStateEvent(JassGameState state, JassLimitOp opcode, Single value)
        {
            return SafeNatives.TriggerRegisterGameStateEvent(this, state, opcode, value);
        }

        public JassEvent RegisterDialogEvent(JassDialog dialog)
        {
            return SafeNatives.TriggerRegisterDialogEvent(this, dialog);
        }

        public JassEvent RegisterDialogButtonEvent(JassButton button)
        {
            return SafeNatives.TriggerRegisterDialogButtonEvent(this, button);
        }

        public JassEvent RegisterGameEvent(JassGameEvent gameEvent)
        {
            return SafeNatives.TriggerRegisterGameEvent(this, gameEvent);
        }

        public JassEvent RegisterEnterRegion(JassRegion region, JassBooleanExpression filter)
        {
            return SafeNatives.TriggerRegisterEnterRegion(this, region, filter);
        }

        public JassEvent RegisterLeaveRegion(JassRegion region, JassBooleanExpression filter)
        {
            return SafeNatives.TriggerRegisterLeaveRegion(this, region, filter);
        }

        public JassEvent RegisterTrackableHitEvent(JassTrackable trackable)
        {
            return SafeNatives.TriggerRegisterTrackableHitEvent(this, trackable);
        }

        public JassEvent RegisterTrackableTrackEvent(JassTrackable trackable)
        {
            return SafeNatives.TriggerRegisterTrackableTrackEvent(this, trackable);
        }

        public JassEvent RegisterPlayerEvent(JassPlayer player, JassPlayerEvent playerEvent)
        {
            return SafeNatives.TriggerRegisterPlayerEvent(this, player, playerEvent);
        }

        public JassEvent RegisterPlayerUnitEvent(JassPlayer player, JassPlayerUnitEvent playerUnitEvent, JassBooleanExpression filter)
        {
            return SafeNatives.TriggerRegisterPlayerUnitEvent(this, player, playerUnitEvent, filter);
        }

        public JassEvent RegisterPlayerAllianceChange(JassPlayer player, JassAllianceType allianceType)
        {
            return SafeNatives.TriggerRegisterPlayerAllianceChange(this, player, allianceType);
        }

        public JassEvent RegisterPlayerStateEvent(JassPlayer player, JassPlayerState state, JassLimitOp opcode, Single value)
        {
            return SafeNatives.TriggerRegisterPlayerStateEvent(this, player, state, opcode, value);
        }

        public JassEvent RegisterPlayerChatEvent(JassPlayer player, String message, Boolean exactMatchOnly)
        {
            return SafeNatives.TriggerRegisterPlayerChatEvent(this, player, message, exactMatchOnly);
        }

        public JassEvent RegisterDeathEvent(JassWidget widget)
        {
            return SafeNatives.TriggerRegisterDeathEvent(this, widget);
        }

        public JassEvent RegisterUnitStateEvent(JassUnit unit, JassUnitState state, JassLimitOp opcode, Single value)
        {
            return SafeNatives.TriggerRegisterUnitStateEvent(this, unit, state, opcode, value);
        }

        public JassEvent RegisterUnitEvent(JassUnit unit, JassUnitEvent unitEvent)
        {
            return SafeNatives.TriggerRegisterUnitEvent(this, unit, unitEvent);
        }

        public JassEvent RegisterFilterUnitEvent(JassUnit unit, JassUnitEvent unitEvent, JassBooleanExpression filter)
        {
            return SafeNatives.TriggerRegisterFilterUnitEvent(this, unit, unitEvent, filter);
        }

        public JassEvent RegisterUnitInRange(JassUnit unit, Single range, JassBooleanExpression filter)
        {
            return SafeNatives.TriggerRegisterUnitInRange(this, unit, range, filter);
        }

        public JassBoolean Evaluate()
        {
            return SafeNatives.TriggerEvaluate(this);
        }

        public void Execute()
        {
            SafeNatives.TriggerExecute(this);
        }

        public void Destroy()
        {
            SafeNatives.DestroyTrigger(this);
        }

        public void Reset()
        {
            SafeNatives.ResetTrigger(this);
        }


        public Boolean GetEnabled()
        {
            return SafeNatives.IsTriggerEnabled(this);
        }

        public void SetEnabled(Boolean value)
        {
            if (value)
                SafeNatives.EnableTrigger(this);
            else
                SafeNatives.DisableTrigger(this);
        }

        public Boolean Enabled
        {
            get { return this.GetEnabled(); }
            set { this.SetEnabled(value); }
        }
    }
}
