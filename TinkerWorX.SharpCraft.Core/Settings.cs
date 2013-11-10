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
        public IntPtr InitNatives { get { return (IntPtr)Int32.Parse(this.InitNativesValue, NumberStyles.HexNumber); } }

        [XmlElement("bind_native")]
        public String BindNativeValue = "00455110";
        public IntPtr BindNative { get { return (IntPtr)Int32.Parse(this.BindNativeValue, NumberStyles.HexNumber); } }

        [XmlElement("string_to_jass_string_index")]
        public String StringToJassStringIndexValue = "003BAA20";
        public IntPtr StringToJassStringIndex { get { return (IntPtr)Int32.Parse(this.StringToJassStringIndexValue, NumberStyles.HexNumber); } }

        [XmlElement("jass_string_handle_to_string")]
        public String JassStringHandleToStringValue = "004C4630";
        public IntPtr JassStringHandleToString { get { return (IntPtr)Int32.Parse(this.JassStringHandleToStringValue, NumberStyles.HexNumber); } }

        [XmlElement("jass_constructor")]
        public String JassConstructorValue = "00453930";
        public IntPtr JassConstructor { get { return (IntPtr)Int32.Parse(this.JassConstructorValue, NumberStyles.HexNumber); } }

        [XmlElement("game_state")]
        public String GameStateValue = "003A2EC0";
        public IntPtr GameState { get { return (IntPtr)Int32.Parse(this.GameStateValue, NumberStyles.HexNumber); } }
    }
}
