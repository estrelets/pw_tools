using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1123)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetRemoteRoleInfo_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int RemoteRoleId { get; set; }

        [Order(3)] public int UserId { get; set; }

        [Order(4)] public GRoleInfo Value { get; set; }
    }
}
