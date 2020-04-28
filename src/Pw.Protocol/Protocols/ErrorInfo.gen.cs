using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ErrorInfo
    {
        [Order(0)] public int ErrCode { get; set; }

        [Order(1)] public byte[] Info { get; set; }
    }
}
