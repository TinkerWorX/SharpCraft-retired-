using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using TinkerWorX.Windows;

namespace TinkerWorX.SharpCraft.Blizzard.GameModule
{
    internal static class GameAddresses
    {
        public static Boolean IsReady { get; private set; }

        public static event Action Ready;

        public static void Initialize()
        {
            if (Kernel32.GetModuleHandle("game.dll") == IntPtr.Zero)
                throw new Exception("Attempted to initialize " + typeof(GameAddresses).Name + " before 'game.dll' has been loaded.");

            var @base = Kernel32.GetModuleHandle("game.dll");
            Trace.WriteLine("Base: 0x" + @base.ToString("X8"));
            GameAddresses.CUnit__GetAbility = @base + GameAddresses.CUnit__GetAbilityOffset;
            GameAddresses.GetAbilDataCacheNodeFromId = @base + GameAddresses.GetAbilDataCacheNodeFromIdOffset;
            GameAddresses.CGameUI__Constructor = @base + GameAddresses.CGameUI__ConstructorOffset;
            GameAddresses.CGameUI__DisplayChatMessage = @base + GameAddresses.CGameUI__DisplayChatMessageOffset;
            GameAddresses.Unknown__UpdateMouse = @base + GameAddresses.Unknown__UpdateMouseOffset;
            GameAddresses.Unknown__SetState = @base + GameAddresses.Unknown__SetStateOffset;
            GameAddresses.GetUnitFromHandle = @base + GameAddresses.GetUnitFromHandleOffset;
            GameAddresses.GetTriggerFromHandle = @base + GameAddresses.GetTriggerFromHandleOffset;
            GameAddresses.GetDestructableFromHandle = @base + GameAddresses.GetDestructableFromHandleOffset;
            GameAddresses.GetItemFromHandle = @base + GameAddresses.GetItemFromHandleOffset;
            GameAddresses.StringToJassStringIndex = @base + GameAddresses.StringToJassStringIndexOffset;
            GameAddresses.CTriggerWar3__Execute = @base + GameAddresses.CTriggerWar3__ExecuteOffset;
            GameAddresses.InitNatives = @base + GameAddresses.InitNativesOffset;
            GameAddresses.BindNative = @base + GameAddresses.BindNativeOffset;
            GameAddresses.Jass__Constructor = @base + GameAddresses.Jass__ConstructorOffset;
            GameAddresses.VirtualMachine__RunCode = @base + GameAddresses.VirtualMachine__RunCodeOffset;
            GameAddresses.VirtualMachine__RunFunction = @base + GameAddresses.VirtualMachine__RunFunctionOffset;
            GameAddresses.GetThreadLocalStorage = @base + GameAddresses.GetThreadLocalStorageOffset;
            GameAddresses.JassStringHandleToString = @base + GameAddresses.JassStringHandleToStringOffset;
            GameAddresses.sub_6F4786B0 = @base + GameAddresses.sub_6F4786B0Offset;
            GameAddresses.WndProc = @base + GameAddresses.WndProcOffset;
            GameAddresses.CSimpleMessageFrame__WriteLine = @base + GameAddresses.CSimpleMessageFrame__WriteLineOffset;
            GameAddresses.ValueFPS = @base + GameAddresses.ValueFPSOffset;

            GameAddresses.IsReady = true;
            GameAddresses.OnReady();
        }

        private static void OnReady()
        {
            if (GameAddresses.Ready != null)
                GameAddresses.Ready();
        }

        // === READ FIRST ===
        // First thing you need is to get the image base, and
        // note it down. This can be found by scrolling to the
        // top in an IDA View tab, usually the fifth line
        // looking like this:
        // .text:6F001000 ; Imagebase   : 6F000000
        // We need this, since all addresses must be rebased, which
        // basically means, we need the position relative to the
        // dll base, rather than the absolute memory position.

        #region Addresses

        // === INSTRUCTIONS ===
        // The second function called in UnitAddAbility
        // CAbility* __thiscall sub_6F0787D0(CUnit* this, ObjectIdL ability, Boolean a3, Boolean a4, Boolean a5, Boolean a6)
        public static IntPtr CUnit__GetAbility;
        private const Int32 CUnit__GetAbilityOffset = 0x0787D0;

        // === INSTRUCTIONS ===
        // TODO: Needs instructions.
        // xref "CacheAbilityData" and find the only function it's used in
        // xref that function and find the only function it's called in
        // this is the function we need.
        // int __fastcall sub_6F265ED0(int a1)
        public static IntPtr GetAbilDataCacheNodeFromId;
        private const Int32 GetAbilDataCacheNodeFromIdOffset = 0x265ED0;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes and the zero: "SimpleConsole" 0.
        //     This should return one result, looking similar to this:
        //     .rdata:6F936240 aSimpleconsole  db 'SimpleConsole',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .rdata:6F936240 aSimpleconsole  db 'SimpleConsole',0
        //                     ^^^^^^^^^^^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you one result.
        // 5. This is the function you're looking for. Scroll to the
        //     top to get the address.
        // 6. Using the image base, you rebase this address like this:
        //     6F2FE9F0 - 6F000000 = 002FE9F0
        public static IntPtr CGameUI__Constructor;
        private const Int32 CGameUI__ConstructorOffset = 0x2FE9F0;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: "CHAT_RECIPIENT_ALL".
        //     This should return one result, looking similar to this:
        //     .rdata:6F936090 aChat_recipie_3 db 'CHAT_RECIPIENT_ALL',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .rdata:6F936090 aChat_recipie_3 db 'CHAT_RECIPIENT_ALL',0
        //                     ^^^^^^^^^^^^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you twp results. You'll likely need the first.
        // 5. This is the c_game_ui__display_chat_message function.
        // 6. Using the image base, you rebase this address like this:
        //     6F2FB480 - 6F000000 = 002FB480
        // int CGameUI__DisplayChatMessagePrototype(CUnit* this, int sender, char* message, int recipients, float duration)
        public static IntPtr CGameUI__DisplayChatMessage;
        private const Int32 CGameUI__DisplayChatMessageOffset = 0x2FB480;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: ".\CBuildFrame.cpp". This should return one
        //     result, looking similar to this:
        //     .rdata:6F9418A0 a_Cbuildframe_c db '.\CBuildFrame.cpp',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .rdata:6F9418A0 a_Cbuildframe_c db '.\CBuildFrame.cpp',0
        //                     ^^^^^^^^^^^^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you one result.
        // 5. Now the next part can be a bit tricky, but first you head to the
        //     start of the function. It'll look something like this:
        //     .text:6F39D5E0 sub_6F39D5E0    proc near
        //     .text:6F39D5E0
        //     .text:6F39D5E0 var_58          = dword ptr -58h
        //     .text:6F39D5E0 var_54          = dword ptr -54h
        //     .text:6F39D5E0 var_50          = dword ptr -50h
        //     .text:6F39D5E0 var_4C          = dword ptr -4Ch
        //     .text:6F39D5E0 var_34          = dword ptr -34h
        //     .text:6F39D5E0 var_30          = dword ptr -30h
        //     .text:6F39D5E0 var_2C          = dword ptr -2Ch
        //     .text:6F39D5E0 var_28          = dword ptr -28h
        //     .text:6F39D5E0 var_24          = dword ptr -24h
        //     .text:6F39D5E0 var_20          = dword ptr -20h
        //     .text:6F39D5E0 var_1C          = dword ptr -1Ch
        //     .text:6F39D5E0 var_18          = dword ptr -18h
        //     .text:6F39D5E0 var_14          = dword ptr -14h
        //     .text:6F39D5E0 var_10          = dword ptr -10h
        //     .text:6F39D5E0 var_C           = dword ptr -0Ch
        //     .text:6F39D5E0 var_4           = dword ptr -4
        //     .text:6F39D5E0 arg_0           = dword ptr  4
        //     .text:6F39D5E0 arg_4           = dword ptr  8
        //     .text:6F39D5E0 arg_8           = dword ptr  0Ch
        //     .text:6F39D5E0 arg_C           = dword ptr  10h
        // 6. Next you scroll down until you find the first loc identifier.
        //     It'll look something like this.
        // ->  .text:6F39D6BD                 call    sub_6F398EA0
        //     .text:6F39D6C2                 test    eax, eax
        //     .text:6F39D6C4                 jz      loc_6F39D898
        //     .text:6F39D6CA
        //     .text:6F39D6CA loc_6F39D6CA:
        //     .text:6F39D6CA                 mov     eax, [esp+48h+var_28]
        //     .text:6F39D6CE                 mov     ecx, [esp+48h+var_24]
        //     .text:6F39D6D2                 mov     edx, [esp+48h+var_20]
        // 7. sub_6F3A2EC0 is the mouse function.
        // 8. Using the image base, you rebase this address like this:
        //     6F3A2EC0 - 6F000000 = 00398EA0
        public static IntPtr Unknown__UpdateMouse;
        private const Int32 Unknown__UpdateMouseOffset = 0x398EA0;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: ".?AUAgent2HandleReg@@". This should return one
        //     result, looking similar to this:
        //     .data:6FA7951C a_?auagent2hand db '.?AUAgent2HandleReg@@',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .data:6FA7951C a_?auagent2hand db '.?AUAgent2HandleReg@@',0
        //                 ^^^^^^^^^^^^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you several results. Four of them are functions.
        // 5. One of the functions will look like this:
        // -> .text:6F3A465F                 call    sub_6F3A3AD0
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
        // -> .text:6F3A3AF9                 call    sub_6F3A2EC0
        // 8. sub_6F3A2EC0 is the game_state function.
        // 7. Using the image base, you rebase this address like this:
        //     6F3A2EC0 - 6F000000 = 003A2EC0
        public static IntPtr Unknown__SetState;
        private const Int32 Unknown__SetStateOffset = 0x3A2EC0;

        // === INSTRUCTIONS ===
        // The first function called in GetUnitX and GetUnitY.
        // CUnit* __fastcall sub_6F3BDCB0(int unit_jass_handle)
        public static IntPtr GetUnitFromHandle;
        private const Int32 GetUnitFromHandleOffset = 0x3BDCB0;

        // === INSTRUCTIONS ===
        // The first function called in DestroyTrigger and ResetTrigger.
        // CTriggerWar3* __fastcall sub_6F3BDEF0(int trigger_handle)
        public static IntPtr GetTriggerFromHandle;
        private const Int32 GetTriggerFromHandleOffset = 0x3BDEF0;

        // === INSTRUCTIONS ===
        // The first function called in GetDestructableX and GetDestructableY.
        // CDestructable* __fastcall sub_6F3BE010(int destructable_jass_handle)
        public static IntPtr GetDestructableFromHandle;
        private const Int32 GetDestructableFromHandleOffset = 0x3BE010;

        // === INSTRUCTIONS ===
        // The first function called in GetItemX and GetItemY.
        // CItem* __fastcall sub_6F3BEB50(int item_jass_handle)
        public static IntPtr GetItemFromHandle;
        private const Int32 GetItemFromHandleOffset = 0x3BEB50;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: "I2S". This should return one
        //     result, looking similar to this:
        //     .rdata:6F94B76C  db 'I2S',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .rdata:6F94B76C aI2s            db 'I2S',0
        //                     ^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you two results. Double-click the first.
        // 5. You are now in a function that looks like this:
        //     .text:6F3D4129                 push    offset aIS      ; "(I)S"
        //     .text:6F3D412E                 mov     edx, offset aI2s ; "I2S"
        // -> .text:6F3D4133                 mov     ecx, offset sub_6F3BAAA0
        //     .text:6F3D4138                 call    sub_6F455110
        // 6. sub_6F3BAAA0 is the I2S function, double-click it, and you'll
        //     see something like the following:
        //     .text:6F3BAAA0 sub_6F3BAAA0    proc near               ; DATA XREF: sub_6F3D4020+113o
        //     .text:6F3BAAA0
        //     .text:6F3BAAA0 var_104         = byte ptr -104h
        //     .text:6F3BAAA0 var_4           = dword ptr -4
        //     .text:6F3BAAA0 arg_0           = dword ptr  4
        //     .text:6F3BAAA0
        //     .text:6F3BAAA0                 sub     esp, 104h
        //     .text:6F3BAAA6                 mov     eax, dword_6FAAE140
        //     .text:6F3BAAAB                 xor     eax, esp
        //     .text:6F3BAAAD                 mov     [esp+104h+var_4], eax
        //     .text:6F3BAAB4                 mov     eax, [esp+104h+arg_0]
        //     .text:6F3BAABB                 push    eax
        //     .text:6F3BAABC                 push    offset aD_0     ; "%d"
        //     .text:6F3BAAC1                 lea     ecx, [esp+10Ch+var_104]
        //     .text:6F3BAAC5                 push    100h
        //     .text:6F3BAACA                 push    ecx
        //     .text:6F3BAACB                 call    Storm_578
        //     .text:6F3BAAD0                 add     esp, 10h
        //     .text:6F3BAAD3                 lea     ecx, [esp+104h+var_104]
        // -> .text:6F3BAAD6                 call    sub_6F3BAA20
        //     .text:6F3BAADB                 mov     ecx, [esp+104h+var_4]
        //     .text:6F3BAAE2                 xor     ecx, esp
        //     .text:6F3BAAE4                 call    sub_6F7E1059
        //     .text:6F3BAAE9                 add     esp, 104h
        //     .text:6F3BAAEF                 retn
        //     .text:6F3BAAEF sub_6F3BAAA0    endp
        // 7. sub_6F3BAA20 is the string_to_jass_string_index function.
        // 8. Using the image base, you rebase this address like this:
        //       6F3BAA20 - 6F000000 = 003BAA20
        public static IntPtr StringToJassStringIndex;
        private const Int32 StringToJassStringIndexOffset = 0x3BAA20;

        // === INSTRUCTIONS ===
        // TODO: Needs instructions.
        // void __thiscall sub_6F4481A0(CTriggerWar3 *this, bool wait)
        public static IntPtr CTriggerWar3__Execute;
        private const Int32 CTriggerWar3__ExecuteOffset = 0x4481A0;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: "Deg2Rad". This should return one
        //     result, looking similar to this:
        //     .rdata:6F94B7DC  db 'Deg2Rad',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .rdata:6F94B7DC aDeg2rad        db 'Deg2Rad',0
        //                     ^^^^^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you two results. Double-click the first.
        // 5. You are now in a function that looks like this:
        // -> .text:6F3D4020 sub_6F3D4020    proc near               ; CODE XREF: .text:6F0085DAp
        //     .text:6F3D4020                                         ; sub_6F3A2EC0+27Ep ...
        //     .text:6F3D4020                 call    sub_6F453C00
        //     .text:6F3D4025                 push    offset aRR      ; "(R)R"
        //     .text:6F3D402A                 mov     edx, offset aDeg2rad ; "Deg2Rad"
        //     .text:6F3D402F                 mov     ecx, offset loc_6F3B29D0
        // -> .text:6F3D4034                 call    sub_6F455110
        // 6. sub_6F3D4020 is the init_natives function.
        // 7. Using the image base, you rebase this address like this:
        //     6F3D4020 - 6F000000 = 003D4020
        // 8. sub_6F455110 is the bind_native function.
        // 9. Using the image base, you rebase this address like this:
        //     6F455110 - 6F000000 = 00455110
        public static IntPtr InitNatives;
        private const Int32 InitNativesOffset = 0x3D4020;
        public static IntPtr BindNative;
        private const Int32 BindNativeOffset = 0x455110;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: ".\Jass.cpp". This should return one
        //     result, looking similar to this:
        //     .rdata:6F950EAC  db '.\Jass.cpp',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .rdata:6F950EAC a_Jass_cpp      db '.\Jass.cpp',0
        //                     ^^^^^^^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you seven results. Double-click the first.
        // 5. You are now in a function that looks like this:
        //     .text:6F453C00 sub_6F453C00    proc near               ; CODE XREF: sub_6F3D4020p
        //     .text:6F453C00                 mov     ecx, 5
        //     .text:6F453C05                 call    sub_6F4C34D0
        //     .text:6F453C0A                 test    eax, eax
        //     .text:6F453C0C                 jnz     short locret_6F453C46
        //     .text:6F453C0E                 push    eax
        //     .text:6F453C0F                 push    29Ch
        //     .text:6F453C14                 push    offset a_Jass_cpp ; ".\\Jass.cpp"
        //     .text:6F453C19                 push    0B0h
        //     .text:6F453C1E                 call    Storm_401
        //     .text:6F453C23                 test    eax, eax
        //     .text:6F453C25                 jz      short loc_6F453C3A
        //     .text:6F453C27                 mov     ecx, eax
        // -> .text:6F453C29                 call    sub_6F453930
        //     .text:6F453C2E                 mov     edx, eax
        //     .text:6F453C30                 mov     ecx, 5
        //     .text:6F453C35                 jmp     sub_6F4C34F0
        //     .text:6F453C3A
        //     .text:6F453C3A loc_6F453C3A:                           ; CODE XREF: sub_6F453C00+25j
        //     .text:6F453C3A                 xor     eax, eax
        //     .text:6F453C3C                 mov     edx, eax
        //     .text:6F453C3E                 lea     ecx, [eax+5]
        //     .text:6F453C41                 jmp     sub_6F4C34F0
        //     .text:6F453C46
        //     .text:6F453C46 locret_6F453C46:                        ; CODE XREF: sub_6F453C00+Cj
        //     .text:6F453C46                 retn
        //     .text:6F453C46 sub_6F453C00    endp
        // 6. sub_6F453930 is the jass_constructor function.
        // 7. Using the image base, you rebase this address like this:
        //     6F453930 - 6F000000 = 00453930
        public static IntPtr Jass__Constructor;
        private const Int32 Jass__ConstructorOffset = 0x453930;

        // === INSTRUCTIONS ===
        // TODO: Needs instructions.
        public static IntPtr VirtualMachine__RunCode;
        private const Int32 VirtualMachine__RunCodeOffset = 0x45E9D0;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes, and the zero afterwards: "config" 0.
        //     This should return one result, looking similar to this:
        //     .rdata:6F94297C aConfig         db 'config',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .rdata:6F94297C aConfig         db 'config',0
        //                     ^^^^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you one result.
        // 5. The function should have a part that looks like this:
        //     .text:6F3B5483                 push    1
        //     .text:6F3B5485                 push    1
        //     .text:6F3B5487                 push    0
        //     .text:6F3B5489                 mov     edx, offset aConfig ; "config"
        //     .text:6F3B548E                 mov     ecx, esi
        // ->.text:6F3B5490                 call    sub_6F44B640
        //     .text:6F3B5495                 sub     eax, 1
        // 6. Double-click the part that says "sub_6F44B640"
        // 7. You're now in a new function. Scroll to the bottom and
        //     find something that looks like this:
        //     .text:6F44B66F                 push    edx
        //     .text:6F44B670                 push    eax
        //     .text:6F44B671                 push    esi
        // ->.text:6F44B672                 call    sub_6F45F8B0
        //     .text:6F44B677                 pop     esi
        //     .text:6F44B678                 retn    10h
        //     .text:6F44B678 sub_6F44B640    endp
        // 8. sub_6F45F8B0 is the call_function function.
        // 7. Using the image base, you rebase this address like this:
        //     6F45F8B0 - 6F000000 = 0045F8B0
        public static IntPtr VirtualMachine__RunFunction;
        private const Int32 VirtualMachine__RunFunctionOffset = 0x45F8B0;

        // === INSTRUCTIONS ===
        // Find the global symbol: dwTlsIndex
        // Find the function that returns immediately using dwTlsIndex as a parameter.
        public static IntPtr GetThreadLocalStorage;
        private const Int32 GetThreadLocalStorageOffset = 0x4C34C0;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: "S2I". This should return one
        //     result, looking similar to this:
        //     .rdata:6F94B744  db 'S2I',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Place the cursor in the following part of the line:
        //     .rdata:6F94B744 aS2i            db 'S2I',0
        //                     ^^^^
        // 4. Press "x", to cross reference the string.
        //     This should give you two results. Double-click the first.
        // 5. You are now in a function that looks like this:
        //     .text:6F3D4165                 push    offset aSI      ; "(S)I"
        //     .text:6F3D416A                 mov     edx, offset aS2i ; "S2I"
        // -> .text:6F3D416F                 mov     ecx, offset sub_6F3B2D10
        //     .text:6F3D4174                 call    sub_6F455110
        // 6. sub_6F3B2D10 is the S2I function, double-click it, and you'll
        //     see something like the following:
        //     .text:6F3B2D10 sub_6F3B2D10    proc near               ; DATA XREF: sub_6F3D4020+14Fo
        //     .text:6F3B2D10
        //     .text:6F3B2D10 arg_0           = dword ptr  4
        //     .text:6F3B2D10
        //     .text:6F3B2D10                 mov     ecx, [esp+arg_0]
        // -> .text:6F3B2D14                 call    sub_6F4C4630
        //     .text:6F3B2D19                 test    eax, eax
        //     .text:6F3B2D1B                 jz      short loc_6F3B2D2C
        //     .text:6F3B2D1D                 cmp     byte ptr [eax], 0
        //     .text:6F3B2D20                 jz      short loc_6F3B2D2C
        //     .text:6F3B2D22                 mov     [esp+arg_0], eax
        //     .text:6F3B2D26                 jmp     ds:atoi
        //     .text:6F3B2D2C
        //     .text:6F3B2D2C loc_6F3B2D2C:                           ; CODE XREF: sub_6F3B2D10+Bj
        //     .text:6F3B2D2C                                         ; sub_6F3B2D10+10j
        //     .text:6F3B2D2C                 xor     eax, eax
        //     .text:6F3B2D2E                 retn
        //     .text:6F3B2D2E sub_6F3B2D10    endp
        // 7. sub_6F4C4630 is the jass_string_handle_to_string function.
        // 8. Using the image base, you rebase this address like this:
        //     6F4C4630 - 6F000000 = 004C4630
        public static IntPtr JassStringHandleToString;
        private const Int32 JassStringHandleToStringOffset = 0x4C4630;

        // === INSTRUCTIONS ===
        // TODO: Needs instructions.
        // int __fastcall sub_6F4786B0(int* a1)
        public static IntPtr sub_6F4786B0;
        private const Int32 sub_6F4786B0Offset = 0x4786B0;

        // === INSTRUCTIONS ===
        // 1. Hit "Ctrl + L" and locate the function "SetWindowLongA", 
        // 2. Double click the function.
        // 3. Place the cursor in the following part of the line:
        // .idata:6F86D83C ; LONG __stdcall SetWindowLongA(HWND hWnd, int nIndex, LONG dwNewLong)
        //                                     ^^^^^^^^^^^^^^
        // 4. Press "x", to cross reference the function.
        //     This should give you lots of results.
        // 5. You need to check them one by one from the top until you find one with a push 0FFFFFFFCh right above.
        //     In 1.26.0.6401 it was the third result from the top.
        //     .text:6F52D08E                 call    ds:SetFocus
        //     .text:6F52D094                 mov     eax, [esi+574h]
        //     .text:6F52D09A                 push    0FFFFFFFCh      ; nIndex
        //     .text:6F52D09C                 push    eax             ; hWnd
        //     .text:6F52D09D                 call    ds:GetWindowLongA
        //     .text:6F52D0A3                 mov     ecx, [esi+574h]
        // ->  .text:6F52D0A9                 push    offset sub_6F52C9C0 ; dwNewLong
        //     .text:6F52D0AE                 push    0FFFFFFFCh      ; nIndex
        //     .text:6F52D0B0                 push    ecx             ; hWnd
        //     .text:6F52D0B1                 mov     lpPrevWndFunc, eax
        //     .text:6F52D0B6                 call    ds:SetWindowLongA
        //     .text:6F52D0BC                 xor     ecx, ecx
        //     .text:6F52D0BE                 call    sub_6F6CE230
        //     .text:6F52D0C3                 pop     edi
        //     .text:6F52D0C4                 mov     eax, 1
        //     .text:6F52D0C9                 pop     esi
        //     .text:6F52D0CA                 add     esp, 34h
        //     .text:6F52D0CD                 retn    4
        //     .text:6F52D0CD sub_6F52D000    endp
        // 6. sub_6F52C9C0 is the wndproc function.
        // 7. Using the image base, you rebase this address like this:
        //     6F52C9C0 - 6F000000 = 0052C9C0
        public static IntPtr WndProc;
        private const Int32 WndProcOffset = 0x52C9C0;

        // === INSTRUCTIONS ===
        // TODO: Consider using this as a VTable offset function.
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: ".\CSimpleMessageFrame.cpp".
        //     This should return one result, looking similar to this:
        //     .rdata:6F96DD18 a_Csimplemessag db '.\CSimpleMessageFrame.cpp',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        //     .rdata:6F96DD18 a_Csimplemessag db '.\CSimpleMessageFrame.cpp',0
        //     .rdata:6F96DD18
        //     .rdata:6F96DD18
        //     .rdata:6F96DD32                 align 8
        //     .rdata:6F96DD38 aEDrive1Temp_43 db 'e:\drive1\temp\buildwar3x\engine\source\frame\CSimpleMessageFrame'
        //     .rdata:6F96DD38
        //     .rdata:6F96DD38                 db '.h',0
        //     .rdata:6F96DD7C                 align 10h
        //     .rdata:6F96DD80                 dd offset unk_6F9ED754
        //     .rdata:6F96DD84 off_6F96DD84    dd offset sub_6F6049F0
        //     .rdata:6F96DD84
        //     .rdata:6F96DD88                 dd offset sub_6F6058F0
        //     .rdata:6F96DD8C                 dd offset sub_6F604DD0
        //     .rdata:6F96DD90                 dd offset sub_6F6054A0
        //     .rdata:6F96DD94                 dd offset sub_6F604F70
        //     .rdata:6F96DD98                 dd offset sub_6F609A20
        //     .rdata:6F96DD9C                 dd offset sub_6F604FB0
        //     .rdata:6F96DDA0                 dd offset sub_6F604FA0
        //     .rdata:6F96DDA4                 dd offset sub_6F30C210
        //     .rdata:6F96DDA8                 dd offset sub_6F30C220
        //     .rdata:6F96DDAC                 dd offset sub_6F608970
        //     .rdata:6F96DDB0                 dd offset nullsub_390
        //     .rdata:6F96DDB4                 dd offset nullsub_391
        //     .rdata:6F96DDB8                 dd offset sub_6F604C10
        //     .rdata:6F96DDBC                 dd offset sub_6F6089A0
        //     .rdata:6F96DDC0                 dd offset sub_6F609C00
        //     .rdata:6F96DDC4                 dd offset sub_6F30C260
        //     .rdata:6F96DDC8                 dd offset sub_6F30C270
        //     .rdata:6F96DDCC                 dd offset sub_6F30C280
        //     .rdata:6F96DDD0                 dd offset sub_6F30C290
        //     .rdata:6F96DDD4                 dd offset sub_6F30C2A0
        //     .rdata:6F96DDD8                 dd offset sub_6F30C2B0
        //     .rdata:6F96DDDC                 dd offset sub_6F30C2C0
        //     .rdata:6F96DDE0                 dd offset sub_6F30C2D0
        //     .rdata:6F96DDE4                 dd offset sub_6F30C300
        //     .rdata:6F96DDE8                 dd offset sub_6F609AD0
        //     .rdata:6F96DDEC                 dd offset sub_6F609B50
        // ->  .rdata:6F96DDF0                 dd offset sub_6F6049B0
        //     .rdata:6F96DDF4 unk_6F96DDF4    db    1
        // 3. sub_6F6049B0 is the function for c_game_ui__display_chat_message.
        // 4. Using the image base, you rebase this address like this:
        //     6F6049B0 - 6F000000 = 006049B0
        public static IntPtr CSimpleMessageFrame__WriteLine;
        private const Int32 CSimpleMessageFrame__WriteLineOffset = 0x6049B0;

        // === INSTRUCTIONS ===
        // 1. Hit "Alt + B" to search for the following byte sequence, 
        //     including the quotes: ".?AVCGxMesh@@".
        //     This should return one result, looking similar to this:
        //     .data:6FA88C10 a_?avcgxmesh@@  db '.?AVCGxMesh@@',0
        // 2. Double click the result. (Only in IDAPro 5.5)
        // 3. Scroll up until you see something like this:
        // ->  .data:6FA88BD0 flt_6FA88BD0    dd 0.0
        //     .data:6FA88BD0
        //     .data:6FA88BD4                 align 8
        //     .data:6FA88BD8 qword_6FA88BD8  dq 0
        //     .data:6FA88BD8
        //     .data:6FA88BE0 flt_6FA88BE0    dd 0.0
        //     .data:6FA88BE0 
        //     .data:6FA88BE4                 align 8
        //     .data:6FA88BE8 qword_6FA88BE8  dq 0
        //     .data:6FA88BE8
        //     .data:6FA88BF0 flt_6FA88BF0    dd 0.0
        //     .data:6FA88BF0
        //     .data:6FA88BF4                 align 8
        //     .data:6FA88BF8 qword_6FA88BF8  dq 0
        //     .data:6FA88BF8
        //     .data:6FA88C00 flt_6FA88C00    dd 0.0
        //     .data:6FA88C00
        //     .data:6FA88C04                 align 8
        //     .data:6FA88C08 off_6FA88C08    dd offset off_6F98BC0C
        //     .data:6FA88C08
        //     .data:6FA88C0C                 align 10h
        //     .data:6FA88C10 a_?avcgxmesh@@  db '.?AVCGxMesh@@',0
        //     .data:6FA88C1E                 align 10h
        // 4. flt_6FA88BD0 is the variable holding the FPS
        // 5. Using the image base, you rebase this address like this:
        //     6FA88BD0 - 6F000000 = 00A88BD0
        public static IntPtr ValueFPS;
        private const Int32 ValueFPSOffset = 0xA88BD0;

        #endregion Addresses
    }
}
