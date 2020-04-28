using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8163)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionMemberUpdate
    {
        [Order(0)] public FactionIDBean FactionId { get; set; }

        [Order(1)] public RoleBean[] Roles { get; set; }

        [Order(2)] public int TitleId { get; set; }

        [Order(3)] public char Operation { get; set; }
    }
}
