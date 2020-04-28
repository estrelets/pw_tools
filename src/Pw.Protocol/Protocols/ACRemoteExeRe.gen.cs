using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5028)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACRemoteExeRe
    {
        [Order(0)] public int ResCode { get; set; }
    }
}
