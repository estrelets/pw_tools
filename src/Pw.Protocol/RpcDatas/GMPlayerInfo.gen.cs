using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMPlayerInfo
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int LinkId { get; set; }

        [Order(3)] public uint LocalsId { get; set; }

        [Order(4)] public int GsId { get; set; }

        [Order(5)] public char Status { get; set; }

        [Order(6)] public byte[] Name { get; set; }
    }
}
