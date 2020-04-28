using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8138)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleInfoResp
    {
        [Order(0)] public long LocaluId { get; set; }

        [Order(1)] public RoleInfoBean Roleinfo { get; set; }
    }
}
