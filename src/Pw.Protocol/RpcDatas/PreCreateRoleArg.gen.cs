using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PreCreateRoleArg
    {
        [Order(0)] public int ZoneId { get; set; }

        [Order(1)] public int UserId { get; set; }

        [Order(2)] public int Uselogic { get; set; }

        [Order(3)] public byte[] RoleName { get; set; }
    }
}
