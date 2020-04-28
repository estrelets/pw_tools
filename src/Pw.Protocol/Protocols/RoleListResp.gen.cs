using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8122)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleListResp
    {
        [Order(0)] public long UserId { get; set; }

        [Order(1)] public RoleDetailBean[] Roles { get; set; }
    }
}
