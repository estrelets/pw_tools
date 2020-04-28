using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBModifyRoleDataArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint Mask { get; set; }

        [Order(2)] public int Level { get; set; }

        [Order(3)] public long Exp { get; set; }

        [Order(4)] public uint PocketMoney { get; set; }

        [Order(5)] public uint StoreMoney { get; set; }

        [Order(6)] public int Pkvalue { get; set; }

        [Order(7)] public int Reputation { get; set; }

        [Order(8)] public int Potential { get; set; }

        [Order(9)] public int Occupation { get; set; }
    }
}
