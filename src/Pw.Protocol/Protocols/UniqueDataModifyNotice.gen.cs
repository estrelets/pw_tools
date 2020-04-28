using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(3116)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class UniqueDataModifyNotice
    {
        [Order(0)] public int Worldtag { get; set; }

        [Order(1)] public int Key { get; set; }

        [Order(2)] public int Vtype { get; set; }

        [Order(3)] public byte[] Value { get; set; }

        [Order(4)] public byte[] Oldvalue { get; set; }

        [Order(5)] public bool Exclusive { get; set; }

        [Order(6)] public int RetCode { get; set; }

        [Order(7)] public int Version { get; set; }
    }
}
