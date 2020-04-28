using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(383)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMGetPlayerConsumeInfo_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int GmRoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public PlayerConsumeInfo[] Playerlist { get; set; }

        [Order(4)] public byte Reason { get; set; }
    }
}
