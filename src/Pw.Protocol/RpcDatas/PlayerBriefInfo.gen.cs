using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerBriefInfo
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public byte Occupation { get; set; }

        [Order(2)] public byte[] Name { get; set; }

        [Order(3)] public char Gender { get; set; }
    }
}
