using System;
using System.Globalization;
using System.IO;
using System.Security;
using System.Xml.Serialization;

namespace TinkerWorX.SharpCraft.Core
{
    [XmlRoot(ElementName = "sharpcraft", IsNullable = false)]
    public class Settings
    {
        public static Settings Current { get; private set; }

        public static void Load(String path)
        {
            if (!File.Exists(path))
            {
                Settings.Current = new Settings();
            }
            else
            {
                var serializer = new XmlSerializer(typeof(Settings));
                using (var stream = File.Open(path, FileMode.Open, FileAccess.Read, FileShare.Read))
                {
                    Settings.Current = (Settings)serializer.Deserialize(stream);
                }
            }
        }

        public static void Save(String path)
        {
            using (var stream = File.Open(path, FileMode.Create, FileAccess.ReadWrite, FileShare.ReadWrite))
            {
                var serializer = new XmlSerializer(typeof(Settings));
                serializer.Serialize(stream, Settings.Current);
            }
        }

        [XmlAttribute("version")]
        public String VersionValue = new Version(1, 26, 0, 6401).ToString();
        public Version Version { get { return new Version(this.VersionValue); } }

        [XmlAttribute("debug")]
        public Boolean IsDebugging = false;

        [XmlAttribute("security_zone")]
        public SecurityZone SecurityZone = SecurityZone.Untrusted;

        [XmlElement("addresses")]
        public SettingsAddresses Addresses = new SettingsAddresses();
    }

    public class SettingsAddresses
    {
        [XmlElement("init_natives")]
        public String InitNativesValue = "003D4020";
        public Int32 InitNatives { get { return Int32.Parse(this.InitNativesValue, NumberStyles.HexNumber); } }

        [XmlElement("bind_native")]
        public String BindNativeValue = "00455110";
        public Int32 BindNative { get { return Int32.Parse(this.BindNativeValue, NumberStyles.HexNumber); } }

        [XmlElement("string_to_jass_string_index")]
        public String StringToJassStringIndexValue = "003BAA20";
        public Int32 StringToJassStringIndex { get { return Int32.Parse(this.StringToJassStringIndexValue, NumberStyles.HexNumber); } }

        [XmlElement("jass_string_handle_to_string")]
        public String JassStringHandleToStringValue = "004C4630";
        public Int32 JassStringHandleToString { get { return Int32.Parse(this.JassStringHandleToStringValue, NumberStyles.HexNumber); } }

        [XmlElement("jass_constructor")]
        public String JassConstructorValue = "00453930";
        public Int32 JassConstructor { get { return Int32.Parse(this.JassConstructorValue, NumberStyles.HexNumber); } }

        [XmlElement("game_state")]
        public String GameStateValue = "003A2EC0";
        public Int32 GameState { get { return Int32.Parse(this.GameStateValue, NumberStyles.HexNumber); } }

        [XmlElement("mouse")]
        public String MouseValue = "00398EA0";
        public Int32 Mouse { get { return Int32.Parse(this.MouseValue, NumberStyles.HexNumber); } }

        [XmlElement("wndproc")]
        public String WndProcValue = "0052C9C0";
        public Int32 WndProc { get { return Int32.Parse(this.WndProcValue, NumberStyles.HexNumber); } }

        [XmlElement("call_function")]
        public String CallFunctionValue = "0045F8B0";
        public Int32 CallFunction { get { return Int32.Parse(this.CallFunctionValue, NumberStyles.HexNumber); } }

        [XmlElement("c_world_frame__write_line")]
        public String CWorldFrame__WriteLineValue = "006049B0";
        public Int32 CWorldFrame__WriteLine { get { return Int32.Parse(this.CWorldFrame__WriteLineValue, NumberStyles.HexNumber); } }

        [XmlElement("c_game_ui__constructor")]
        public String CGameUI__ConstructorValue = "002FE9F0";
        public Int32 CGameUI__Constructor { get { return Int32.Parse(this.CGameUI__ConstructorValue, NumberStyles.HexNumber); } }

        [XmlElement("c_game_ui__display_chat_message")]
        public String CGameUI__DisplayChatMessageValue = "002FB480";
        public Int32 CGameUI__DisplayChatMessage { get { return Int32.Parse(this.CGameUI__DisplayChatMessageValue, NumberStyles.HexNumber); } }

        [XmlElement("fps")]
        public String FPSValue = "00A88BD0";
        public Int32 FPS { get { return Int32.Parse(this.FPSValue, NumberStyles.HexNumber); } }
    }
}
