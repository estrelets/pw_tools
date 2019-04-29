using System.IO;

namespace Pw.Elements
{
    public class ElementsDataFileInfo
    {
        public byte Version { get; set; }
        public byte[] Header { get; set; }

        public int Data1 { get; set; }
        public int Data2 { get; set; }
        public byte[] Buffer1 { get; set; }

        public int Data3 { get; set; }
        public byte[] Buffer2 { get; set; }

        public void ReadHeader(BinaryReader reader)
        {
            Header = reader.ReadBytes(7);
        }

        public void ReadFirstMetadata(BinaryReader reader)
        {
            Data1 = reader.ReadInt32();
            var len = reader.ReadInt32();
            Data2 = reader.ReadInt32();
            Buffer1 = reader.ReadBytes(len);
        }

        public void ReadSecondMetadata(BinaryReader reader)
        {
            Data3 = reader.ReadInt32();
            var len = reader.ReadInt32();
            Buffer2 = reader.ReadBytes(len);
        }

        public void WriteHeader(BinaryWriter writer)
        {
            writer.Write(Header);
        }

        public void WriteFirstMetadata(BinaryWriter writer)
        {
            writer.Write(Data1);
            writer.Write(Buffer1.Length);
            writer.Write(Data2);
            writer.Write(Buffer1);
        }

        public void WriteSecondMetadata(BinaryWriter writer)
        {
            writer.Write(Data3);
            writer.Write(Buffer2.Length);
            writer.Write(Buffer2);
        }

        public void ReadVersion(BinaryReader reader)
        {
            Version = reader.ReadByte();
        }

        public void WriteVersion(BinaryWriter writer)
        {
            writer.Write(Version);
        }
    }
}
