using System;
using System.Globalization;
using System.IO;
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
    }
}
