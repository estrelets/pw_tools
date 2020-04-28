using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8008)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACForbidCheater
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int Time { get; set; }

        [Order(2)] public char Operation { get; set; }

        [Order(3)] public byte[] Reason { get; set; }
    }
}
