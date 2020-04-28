using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4302)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class WebTradePrePost
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Posttype { get; set; }

        [Order(2)] public uint Money { get; set; }

        [Order(3)] public uint ItemId { get; set; }

        [Order(4)] public int ItemPos { get; set; }

        [Order(5)] public int ItemNum { get; set; }

//¼Û¸ñ£¬´óÓÚ0±íÊ¾¼ÄÊÛÍ¬Ê±ÉÏ¼Ü
        [Order(6)] public int Price { get; set; }

//ÉÏ¼ÜÊ±¼ä£¬ÉèÖÃÁËÉÏ¼Ü²ÅÉúÐ§
        [Order(7)] public int Sellperiod { get; set; }

// below parameter is provide by gameserver  
        [Order(8)] public int BuyerRoleId { get; set; }

        [Order(9)] public uint LocalsId { get; set; }

        [Order(10)] public byte[] SyncData { get; set; }
    }
}
