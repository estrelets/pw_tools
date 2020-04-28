using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4326)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class WebTradeRolePrePost
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int RoleId { get; set; }

//¼Û¸ñ£¬´óÓÚ0±íÊ¾¼ÄÊÛÍ¬Ê±ÉÏ¼Ü
        [Order(2)] public int Price { get; set; }

//ÉÏ¼ÜÊ±¼ä£¬ÉèÖÃÁËÉÏ¼Ü²ÅÉúÐ§
        [Order(3)] public int Sellperiod { get; set; }

//Âò¼Òid£¬ÈçÉè¶¨ÔòÖ»ÔÊÐí¸ÃÂò¼Ò¹ºÂò
        [Order(4)] public int BuyerRoleId { get; set; }

        [Order(5)] public uint LocalsId { get; set; }
    }
}
