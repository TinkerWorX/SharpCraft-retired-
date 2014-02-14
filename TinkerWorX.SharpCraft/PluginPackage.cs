using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Xml.Serialization;
using Ionic.Zip;

namespace TinkerWorX.SharpCraft
{
    public class PluginPackage
    {
        public static PluginPackage FromArchive(ZipFile archive)
        {
            var package = (PluginPackage)null;

            var contentsEntry = archive.FirstOrDefault(file => file.FileName == "contents.xml");
            if (contentsEntry == null)
                throw new FileNotFoundException("'contents.xml' is missing!", "contents.xml");

            using (var stream = contentsEntry.ToStream())
            {
                var contents = PluginPackageContentsXml.FromStream(stream);

                package = new PluginPackage(contents.Id, contents.Name, contents.Version, contents.Target, contents.Type);

                foreach (var file in contents.Files)
                {
                    var entry = archive.FirstOrDefault(a => a.FileName == file.Name);
                    if (entry == null)
                        throw new FileNotFoundException("The package file '" + file.Name + "' is missing!", file.Name);
                    package.files.Add(new PluginPackageFile(file.Name, entry.ToBytes()));
                }

                foreach (var reference in contents.References)
                {
                    package.references.Add(new PluginPackageReference(reference.Id, reference.Version));
                }
            }

            return package;
        }

        public static PluginPackage FromDirectory(String directory)
        {
            var package = (PluginPackage)null;

            if (!File.Exists(Path.Combine(directory, "contents.xml")))
                throw new FileNotFoundException("'contents.xml' is missing!", "contents.xml");

            using (var stream = File.Open(Path.Combine(directory, "contents.xml"), FileMode.Open, FileAccess.Read, FileShare.Read))
            {
                var contents = PluginPackageContentsXml.FromStream(stream);

                package = new PluginPackage(contents.Id, contents.Name, contents.Version, contents.Target, contents.Type);
                foreach (var file in contents.Files)
                {
                    var path = Path.Combine(directory, file.Name);
                    if (!File.Exists(path))
                        throw new FileNotFoundException("The package file '" + file.Name + "' is missing!", file.Name);
                    package.files.Add(new PluginPackageFile(file.Name, File.ReadAllBytes(path)));
                }

                foreach (var reference in contents.References)
                {
                    package.references.Add(new PluginPackageReference(reference.Id, reference.Version));
                }
            }

            return package;
        }

        public static PluginPackage FromArchive(String file)
        {
            return PluginPackage.FromArchive(ZipFile.Read(file));
        }

        private List<PluginPackageFile> files = new List<PluginPackageFile>();

        private List<PluginPackageReference> references = new List<PluginPackageReference>();

        public PluginPackage(String id, String name, Version version, Version target, PluginPackageType type)
        {
            this.Id = id;
            this.Name = name;
            this.Version = version;
            this.Target = target;
            this.Type = type;
        }

        public String Id { get; private set; }

        public String Name { get; private set; }

        public PluginPackageType Type { get; private set; }

        public Version Version { get; private set; }

        public Version Target { get; private set; }

        public ReadOnlyCollection<PluginPackageFile> Files { get { return this.files.AsReadOnly(); } }

        public ReadOnlyCollection<PluginPackageReference> References { get { return this.references.AsReadOnly(); } }
    }

    public class PluginPackageReference
    {
        public PluginPackageReference(String id, Version version)
        {
            this.Id = id;
            this.Version = version;
        }

        public String Id { get; private set; }

        public Version Version { get; private set; }
    }

    public class PluginPackageFile
    {
        public PluginPackageFile(String name, Byte[] data)
        {
            this.Name = name;
            this.Data = data;
        }

        public String Name { get; private set; }

        public Byte[] Data { get; private set; }
    }

    [XmlRoot("plugin_package", IsNullable = false)]
    public class PluginPackageContentsXml
    {
        public static PluginPackageContentsXml FromStream(Stream stream)
        {
            var serializer = new XmlSerializer(typeof(PluginPackageContentsXml));
            return (PluginPackageContentsXml)serializer.Deserialize(stream);
        }

        [XmlAttribute("id")]
        public String Id;

        [XmlAttribute("version")]
        public String VersionValue = new Version(0, 0, 0, 0).ToString();
        public Version Version { get { return new Version(this.VersionValue); } }

        [XmlAttribute("name")]
        public String Name;

        [XmlAttribute("type")]
        public String TypeValue = PluginPackageType.Safe.ToString();
        public PluginPackageType Type { get { return (PluginPackageType)Enum.Parse(typeof(PluginPackageType), this.TypeValue, true); } }

        [XmlAttribute("target")]
        public String TargetValue = new Version(0, 0, 0, 0).ToString();
        public Version Target
        {
            get
            {
                if (this.TargetValue.ToLower() == "agnostic")
                    return null;
                return new Version(this.TargetValue);
            }
        }

        [XmlElement("reference")]
        public List<PluginPackageReferenceXml> References = new List<PluginPackageReferenceXml>();

        [XmlElement("file")]
        public List<PluginPackageFileXml> Files = new List<PluginPackageFileXml>();
    }

    public enum PluginPackageType
    {
        Safe,
        Full
    }

    public class PluginPackageReferenceXml
    {
        [XmlAttribute("id")]
        public String Id;

        [XmlAttribute("version")]
        public String VersionValue = new Version(0, 0, 0, 0).ToString();
        public Version Version { get { return new Version(this.VersionValue); } }
    }

    public class PluginPackageFileXml
    {
        [XmlAttribute("name")]
        public String Name;
    }
}
