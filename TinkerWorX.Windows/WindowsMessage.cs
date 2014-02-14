using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.Windows
{
    public enum WindowsMessage : uint
    {
        KeyDown = 0x0100,
        KeyUp = 0x0101,
        Char = 0x0102,

        MouseMove = 0x0200,

        LeftButtonDown = 0x0201,
        LeftButtonUp = 0x0202,
        LeftButtonDoubleClick = 0x0203,

        RightButtonDown = 0x0204,
        RightButtonUp = 0x0205,
        RightButtonDoubleClick = 0x0206,

        MiddleButtonDown = 0x0207,
        MiddleButtonUp = 0x0208,
        MiddleButtonDoubleClick = 0x0209,

        MouseWheel = 0x020A,

        ExtraButtonDown = 0x020B,
        ExtraButtonUp = 0x020C,
        ExtraButtonDoubleClick = 0x020D
    }
}
