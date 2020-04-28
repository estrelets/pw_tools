using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4048)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class OnDivorce
    {
        [Order(0)] public int Rid1 { get; set; }

        [Order(1)] public int Rid2 { get; set; }
    }
}
