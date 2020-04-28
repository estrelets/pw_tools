using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GWebTradeDetail
    {
        [Order(0)] public GWebTradeItem Info { get; set; }

        [Order(1)] public GRoleInventory Item { get; set; }

        //¼ÄÊÛÊ±¼äµã msÎªµ¥Î»
        [Order(2)] public long PostTime { get; set; }

        [Order(3)] public uint Deposit { get; set; }

        [Order(4)] public int Loginip { get; set; }

        //GWebTradeRoleBrief
        [Order(5)] public byte[] Rolebrief { get; set; }

        [Order(6)] public char Reserved10 { get; set; }

        [Order(7)] public short Reserved11 { get; set; }

        [Order(8)] public int Reserved2 { get; set; }

        [Order(9)] public int Reserved3 { get; set; }

        [Order(10)] public int Reserved4 { get; set; }

        [Order(11)] public int Reserved5 { get; set; }
    }
}
