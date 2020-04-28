using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PostCreateRoleArg
    {
        [Order(0)] public char Success { get; set; }

        [Order(1)] public int UserId { get; set; }

        [Order(2)] public int ZoneId { get; set; }

        [Order(3)] public int RoleId { get; set; }

        [Order(4)] public byte[] RoleName { get; set; }
    }
}
