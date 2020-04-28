using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(77)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class S2CMulticast
    {
        [Order(0)] public byte[] Data { get; set; }

        [Order(1)] public Player[] Playerlist { get; set; }
    }
}
