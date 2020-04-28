using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8129)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleFriendUpdate
    {
        [Order(0)] public long RoleId { get; set; }

        [Order(1)] public RoleBean Rolefriend { get; set; }

        [Order(2)] public int Gtype { get; set; }

        [Order(3)] public long GroupId { get; set; }

        [Order(4)] public char Operation { get; set; }
    }
}
