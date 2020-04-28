using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(381)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMControlGame_Re
    {
        [Order(0)] public int XId { get; set; }

        [Order(1)] public int RetCode { get; set; }

        [Order(2)] public GMControlGameRes[] Resvector { get; set; }
    }
}
