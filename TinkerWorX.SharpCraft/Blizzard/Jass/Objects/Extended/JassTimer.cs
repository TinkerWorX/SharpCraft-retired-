using System;
using SafeNatives = TinkerWorX.SharpCraft.Blizzard.GameModule.SafeAPI.Natives;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule.Jass
{
    public partial struct JassTimer
    {
        public static JassTimer GetExpired()
        {
            return SafeNatives.GetExpiredTimer();
        }

        public static JassTimer Create()
        {
            return SafeNatives.CreateTimer();
        }

        public void Destroy()
        {
            SafeNatives.DestroyTimer(this);
        }

        public void Start(Single timeout, Boolean periodic, JassCode function)
        {
            SafeNatives.TimerStart(this, timeout, periodic, function);
        }

        public void Start(Single timeout, Boolean periodic)
        {
            SafeNatives.TimerStart(this, timeout, periodic, new JassCode(IntPtr.Zero));
        }

        public void Pause()
        {
            SafeNatives.PauseTimer(this);
        }

        public void Resume()
        {
            SafeNatives.ResumeTimer(this);
        }


        public Single GetElapsed()
        {
            return SafeNatives.TimerGetElapsed(this);
        }

        public Single Elapsed
        {
            get { return this.GetElapsed(); }
        }


        public Single GetRemaining()
        {
            return SafeNatives.TimerGetRemaining(this);
        }

        public Single Remaining
        {
            get { return this.GetRemaining(); }
        }


        public Single GetTimeout()
        {
            return SafeNatives.TimerGetTimeout(this);
        }

        public Single Timeout
        {
            get { return this.GetTimeout(); }
        }
    }
}
