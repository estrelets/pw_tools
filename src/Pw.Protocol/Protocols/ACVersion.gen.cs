using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5020)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACVersion
    {
        [Order(0)] public string Version { get; set; }
    }
}
