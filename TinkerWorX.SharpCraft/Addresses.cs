using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TinkerWorX.SharpCraft
{
    internal static class Addresses
    {
        // === INSTRUCTIONS, FROM AN OLDER VERSION, STILL VALID ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: ".?AUAgent2HandleReg@@". This should return one
        //     result, looking similar to this:
        //     .data:6FA7951C a_?auagent2hand db '.?AUAgent2HandleReg@@',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .data:6FA7951C a_?auagent2hand db '.?AUAgent2HandleReg@@',0
        //                    ^^^^^^^^^^^^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you several results. Four of them are functions.
        // 5. One of the functions will look like this (first one likely):
        // ->  .text:6F3A465F                 call    sub_6F3A3AD0
        //     .text:6F3A4664                 push    1
        //     .text:6F3A4666                 push    0FFFFFFFEh
        //     .text:6F3A4668                 push    offset a_?auagent2hand ; ".?AUAgent2HandleReg@@"
        // 6. Double click sub_6F3A3AD0.
        // 7. You are now in a function that looks like this:
        //     .text:6F3A3AD0 sub_6F3A3AD0    proc near
        //     .text:6F3A3AD0
        //     .text:6F3A3AD0
        //     .text:6F3A3AD0 arg_0           = dword ptr  4
        //     .text:6F3A3AD0 arg_4           = dword ptr  8
        //     .text:6F3A3AD0
        //     .text:6F3A3AD0                 push    ebx
        //     .text:6F3A3AD1                 push    edi
        //     .text:6F3A3AD2                 mov     edi, edx
        //     .text:6F3A3AD4                 mov     ebx, ecx
        //     .text:6F3A3AD6                 call    sub_6F442670
        //     .text:6F3A3ADB                 mov     ecx, 0Dh
        //     .text:6F3A3AE0                 call    sub_6F4C34D0
        //     .text:6F3A3AE5                 mov     eax, [eax+10h]
        //     .text:6F3A3AE8                 mov     ecx, [eax+18h]
        //     .text:6F3A3AEB                 test    ecx, ecx
        //     .text:6F3A3AED                 jz      short loc_6F3A3AFE
        //     .text:6F3A3AEF                 mov     edx, [esp+8+arg_4]
        //     .text:6F3A3AF3                 mov     eax, [esp+8+arg_0]
        //     .text:6F3A3AF7                 push    edx
        //     .text:6F3A3AF8                 push    eax
        // ->  .text:6F3A3AF9                 call    sub_6F3A2EC0
        // 8. sub_6F3A2EC0 is the game_state function.
        // 7. Using the image base, you rebase this address like this:
        //     6F3A2EC0 - 6F000000 = 003A2EC0
        public const Int32 Unknown__SetStateOffset = 0x1C1F20;
    }
}
