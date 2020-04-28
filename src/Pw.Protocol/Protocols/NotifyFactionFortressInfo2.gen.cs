using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4411)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class NotifyFactionFortressInfo2
    {
        [Order(0)] public int FactionId { get; set; }

        [Order(1)] public GFactionFortressInfo2 Info2 { get; set; }
    }
}
