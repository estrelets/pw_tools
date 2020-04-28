using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8068)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SysSendMail3
    {
// ¶©µ¥ºÅ 
        [Order(0)] public long OrderId { get; set; }

        [Order(1)] public int UserId { get; set; }

// ÊÕÓÊ¼þµÄ½ÇÉ«id 
        [Order(2)] public long RoleId { get; set; }

// ÊÕÓÊ¼þµÄ½ÇÉ«Ãû 
        [Order(3)] public byte[] RoleName { get; set; }

// ÓÊ¼þ±êÌâ 
        [Order(4)] public byte[] MailTitle { get; set; }

// ÓÊ¼þÄÚÈÝ 
        [Order(5)] public byte[] MailContext { get; set; }

// ÓÊ¼þ¸½´øµÄ½ð±Ò 
        [Order(6)] public uint AttachMoney { get; set; }

// ÓÊ¼þ¸½´øÎïÆ· 
        [Order(7)] public MailGoodsInventory AttachGoods { get; set; }
    }
}
