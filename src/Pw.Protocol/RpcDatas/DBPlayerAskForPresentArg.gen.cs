using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPlayerAskForPresentArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int TargetRoleId { get; set; }

        [Order(2)] public int GoodsId { get; set; }

        [Order(3)] public int GoodsIndex { get; set; }

        [Order(4)] public int GoodsSlot { get; set; }

        [Order(5)] public byte[] RoleName { get; set; }
    }
}
