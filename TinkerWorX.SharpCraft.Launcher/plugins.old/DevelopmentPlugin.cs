using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using TinkerWorX.Blizzard;
using TinkerWorX.Blizzard.GameModule.Types;
using TinkerWorX.Blizzard.Types;
using TinkerWorX.SharpCraft.Plugins;
using TinkerWorX.Utilities;

namespace TinkerWorX.SharpCraft.plugins
{
    unsafe public class DevelopmentPlugin : FullPluginBase
    {
        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate IntPtr sub_6F001F70Delegate(CAgentPtr @this);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)]
        private delegate IntPtr sub_6F62A9A0Delegate(CAgentPtr @this, Int32 a2, Int32 a3, Int32 a4);

        [UnmanagedFunctionPointer(CallingConvention.ThisCall)] // __fastcall
        private delegate UInt32 sub_6F4C8520Delegate(ObjectIdL* objectId);

        private sub_6F001F70Delegate sub_6F001F70;
        private sub_6F4C8520Delegate sub_6F4C8520;
        private sub_6F62A9A0Delegate sub_6F62A9A0;

        public override String Name
        {
            get { return "Development Plugin"; }
        }

        public override Version Version
        {
            get { return new Version(); }
        }

        public override void Initialize()
        {
            try
            {
                sub_6F001F70 = Memory.InstallHook(Game.Base + 0x001F70, new sub_6F001F70Delegate(this.sub_6F001F70Hook), true, false);
                //sub_6F4C8520 = Memory.InstallHook(Game.Base + 0x4C8520, new sub_6F4C8520Delegate(this.sub_6F4C8520Hook), true, false);
                //sub_6F62A9A0 = Memory.InstallHook(Game.Base + 0x62A9A0, new sub_6F62A9A0Delegate(this.sub_6F62A9A0Hook), true, false);
            }
            catch (Exception e)
            {
                Console.WriteLine(e.ToString());
            }
        }

        public override void OnCheat(String cheat)
        {
            const String prefix = "mindworx.example: ";
            if (!cheat.StartsWith(prefix)) return;
            cheat = cheat.Remove(0, prefix.Length);

            switch (cheat)
            {
                case "esc": this.ESC(); break;
            }
        }

        private void ESC()
        {
            /*foreach (var kv in this.typeHash)
            {
                Console.WriteLine(kv.Key + ":" + kv.Value.ToString("X8"));
            }*/
        }

        private IntPtr sub_6F001F70Hook(CAgentPtr @this)
        {
            //var thus = @this.AsUnsafe();
            //Console.WriteLine("Deallocating an instance(" + @this.AsIntPtr().ToString("X8") + ") of " + thus->GetClassName());

            var result = sub_6F001F70(@this);

            // Trying to fetch the classname or classid after the function call will result in a crash.
            // This indicates the types has likely been deallocated by now, or at the very least means the vtable has changed.

            return result;
        }

        private UInt32 sub_6F4C8520Hook(ObjectIdL* objectId)
        {
            var result = sub_6F4C8520(objectId);

            //if (objectId.ToString() == "+w3u")
            //Console.WriteLine("sub_6F4C8520Hook('{0}') = {1}", objectId->ToString(), result);

            return result;
        }

        private Dictionary<IntPtr, String> vtables = new Dictionary<IntPtr, String>
        {
            { (IntPtr)0x6F9707C4, "CInputObserver" },
            { (IntPtr)0x6F96F6FC, "<Multiple>" },   // FrameDef, CGameUI, CMapPreferenceBoxItem, CGlueButtonWar3, CCampaignListBox
                                                    // CPopupMenu, CGlueTextButtonWar3, CTextButtonFrame, CSlider
            { (IntPtr)0x6F95A00C, "CGlueTextButtonWar3" },
            { (IntPtr)0x6F95C92C, "<Multiple>" },   // CGlueButtonWar3, CCampaignListBox
            { (IntPtr)0x6F96FCE4, "<Multiple>" },   // FrameDef, CTextArea, CListBox, CChatDisplay
            { (IntPtr)0x6F95CCFC, "<Multiple>" },   // CLeaderBoard, CQuestDialog, CMultiBoard, CMapList, CMapPreferenceBox, 
                                                    // CCampaignListBox, CPlayerSlot, CBattleNetProfileListBox, CBattleNetFriendsListBox
                                                    // CBattleNetClanMateListBox, CBattleNetNewsBox, CBattleNetUserListBox, 
                                                    // CCheckListBox, CListBoxWar3, CBattleNetChatActionMenu
            { (IntPtr)0x6F96ECEC, "<Multiple>" },   // CSlashChatBox, CChatEditBar, CBattleNetChatPanel, CEditBox, CChatDisplay
            { (IntPtr)0x6F95CEA4, "CMapList" },
            { (IntPtr)0x6F96E6FC, "<Multiple>" },   // FrameDef, CGlueCheckBoxWar3, CCheckListBoxItem
            { (IntPtr)0x6F96F114, "<Multiple>" },   // CGlueTextButtonWar3, CTextButtonFrame
            { (IntPtr)0x6F96E85C, "<Multiple>" },   // FrameDef, CPopupMenu
            { (IntPtr)0x6F96EB7C, "<Multiple>" },   // FrameDef, CGluePopupMenuWar3
            { (IntPtr)0x6F96FF94, "<Multiple>" },   // FrameDef, CMenu, CListBox
            { (IntPtr)0x6F959E84, "CGluePopupMenuWar3" },
            { (IntPtr)0x6F970780, "<Unknown>" },
            { (IntPtr)0x6F969A4C, "NetGlue" },
            { (IntPtr)0x6F95D0B4, "CMapList" },
            { (IntPtr)0x6F94C59C, "CTimerWar3" },
            { (IntPtr)0x6F94CA0C, "CGroup" },
            { (IntPtr)0x6F94E9D4, "CPlayerWar3" },
        };

        private String GuessClassNameFromVTable(IntPtr vtable)
        {
            var className = String.Empty;
            if (this.vtables.TryGetValue(vtable, out className))
                return className;
            return "0x" + vtable.ToString("X8");
        }

        private IntPtr sub_6F62A9A0Hook(CAgentPtr @this, Int32 a2, Int32 a3, Int32 a4)
        {
            var result = sub_6F62A9A0(@this, a2, a3, a4);
            var thisVTable = new IntPtr(@this.AsUnsafe()->Virtual);
            var thisClassName = this.GuessClassNameFromVTable(thisVTable);

            var a4VClass = new CAgentPtr(new IntPtr(a4));
            var a4VTable = new IntPtr(a4VClass.AsUnsafe()->Virtual);
            var a4ClassName = this.GuessClassNameFromVTable(thisVTable);

            Console.WriteLine("sub_6F62A9A0Hook({0}, ..., {3}) = {4}", thisClassName + "(" + @this.AsIntPtr().ToString("X8") + ")", "0x" + a2.ToString("X8"), "0x" + a3.ToString("X8"), a4ClassName + "(" + a4VClass.AsIntPtr().ToString("X8") + ")", "0x" + result.ToString("X8"));
            return result;
        }
    }
}
