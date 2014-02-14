using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.Windows
{
    public enum WindowsHookId
    {
        MessageFilter = -1,
        JournalRecord = 0,
        JournalPlayback = 1,
        Keyboard = 2,
        GetMessage = 3,
        CallWindowsProc = 4,
        ComputerBasedTraining = 5,
        SystemMessageFilter = 6,
        Mouse = 7,
        Debug = 9,
        Shell = 10,
        ForegroundIdle = 11,
        CallWindowsProcReturn = 12,
        KeyboardLowLevel = 13,
        MouseLowLevel = 14,
    }
}
