using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8130)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleBlacklistUpdate
    {
        [Order(0)] public long RoleId { get; set; }

        [Order(1)] public RoleInfoBean Target { get; set; }

        [Order(2)] public char Operation { get; set; }
    }
}
