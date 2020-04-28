using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8017)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SSOGetTicketRep
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public SSOUser User { get; set; }

        [Order(2)] public byte[] Ticket { get; set; }

        [Order(3)] public byte[] LocalContext { get; set; }

        [Order(4)] public byte[] Reserved { get; set; }
    }
}
