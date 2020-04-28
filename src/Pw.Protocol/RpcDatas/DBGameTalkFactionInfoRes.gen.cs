using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBGameTalkFactionInfoRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public byte[] Name { get; set; }

        [Order(2)] public byte[] Announce { get; set; }

        [Order(3)] public byte[] Exinfo { get; set; }

        [Order(4)] public DBFactionMember[] Members { get; set; }
    }
}
