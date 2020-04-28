using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(910)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopPlayerSell
    {
//Íæ¼ÒROLEID
        [Order(0)] public int RoleId { get; set; }

//µêÖ÷ROLEID
        [Order(1)] public int Master { get; set; }

        [Order(2)] public int ItemId { get; set; }

        [Order(3)] public int ItemPos { get; set; }

        [Order(4)] public int ItemCount { get; set; }

        [Order(5)] public uint ItemPrice { get; set; }

//ÎïÆ·ÔÚ°ü¹üµÄÎ»ÖÃ
        [Order(6)] public int InvPos { get; set; }

        [Order(7)] public byte[] SyncData { get; set; }
    }
}
