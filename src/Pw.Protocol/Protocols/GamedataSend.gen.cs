using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(34)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GamedataSend
    {
        [Order(0)] public byte[] Data { get; set; }
    }
}
