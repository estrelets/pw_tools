using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8038)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AU2Game
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int Qtype { get; set; }

        [Order(2)] public byte[] Info { get; set; }

        [Order(3)] public int RetCode { get; set; }

        [Order(4)] public int Reserved { get; set; }
    }
}
