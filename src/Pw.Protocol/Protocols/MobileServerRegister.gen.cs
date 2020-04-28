using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(159)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class MobileServerRegister
    {
        [Order(0)] public int ServerId { get; set; }

        [Order(1)] public int WorldTag { get; set; }
    }
}
