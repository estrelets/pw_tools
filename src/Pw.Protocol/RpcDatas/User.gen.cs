using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class User
    {
        [Order(0)] public uint LogicuId { get; set; }

        [Order(1)] public uint Rolelist { get; set; }

        [Order(2)] public int Cash { get; set; }

        [Order(3)] public int Money { get; set; }

        [Order(4)] public uint CashAdd { get; set; }

        [Order(5)] public uint CashBuy { get; set; }

        [Order(6)] public uint CashSell { get; set; }

        [Order(7)] public uint CashUsed { get; set; }

        [Order(8)] public int AddSerial { get; set; }

        [Order(9)] public int UseSerial { get; set; }

        [Order(10)] public List<StockLog> ExgLog { get; set; }

        [Order(11)] public byte[] Addiction { get; set; }

        [Order(12)] public byte[] CashPassword { get; set; }

        [Order(13)] public List<GPair> Autolock { get; set; }

        [Order(14)] public char Status { get; set; }

        [Order(15)] public GRoleForbid[] ForbId { get; set; }

        //ÏÂÏßÏµÍ³µÄÊý¾Ý´æ´¢ 
        [Order(16)] public byte[] Reference { get; set; }

        //Ïû·Ñ·µºèÀû
        [Order(17)] public byte[] ConsumeReward { get; set; }

        //¼ÇÂ¼ÕËºÅÍê³ÉÈÎÎñµÄ´ÎÊý
        [Order(18)] public byte[] Taskcounter { get; set; }

        [Order(19)] public byte[] CashSysauction { get; set; }

        [Order(20)] public byte[] LoginRecord { get; set; }

        [Order(21)] public byte[] MallConsumption { get; set; }

        [Order(22)] public short Reserved32 { get; set; }
    }
}
