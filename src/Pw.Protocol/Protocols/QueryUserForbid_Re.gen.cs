using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(509)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class QueryUserForbid_Re
    {
        [Order(0)] public int UserId { get; set; }

//0:forbid list at login,1:reply of forbid
        [Order(1)] public int ListType { get; set; }

        [Order(2)] public GRoleForbid[] ForbId { get; set; }
    }
}
