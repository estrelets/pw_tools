using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(84)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CreateRole
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public RoleInfo Roleinfo { get; set; }

        [Order(3)] public byte[] ReferId { get; set; }
    }
}
