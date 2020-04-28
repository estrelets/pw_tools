using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMailSyncData
    {
        [Order(0)] public int DataMask { get; set; }

        [Order(1)] public int CashTotal { get; set; }

        [Order(2)] public uint CashUsed { get; set; }

        [Order(3)] public int CashSerial { get; set; }

        [Order(4)] public GRolePocket Inventory { get; set; }

        [Order(5)] public GRoleStorehouse Storehouse { get; set; }

        [Order(6)] public GRoleInventory[] Equipment { get; set; }

        [Order(7)] public List<GShopLog> Logs { get; set; }
    }
}
