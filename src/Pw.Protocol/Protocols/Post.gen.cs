using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8020)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class Post
    {
        [Order(0)] public int AId { get; set; }

        [Order(1)] public int ZoneId { get; set; }

// Âô¼ÒÐÅÏ¢  
        [Order(2)] public TraderInfo Seller { get; set; }

// Âò¼ÒÐÅÏ¢£¨Ö¸¶¨Âò¼ÒÊ±¸³Öµ£© 
        [Order(3)] public TraderInfo Buyer { get; set; }

// Á÷Ë®ºÅ 
        [Order(4)] public long Sn { get; set; }

// ÊÛ¼Û£¨ÓÎÏ·ÄÚ¼ÄÊÛ²¢ÉÏ¼ÜÊ±¸³Öµ£©  
        [Order(5)] public int Price { get; set; }

// Ö»¼ÄÊÛÔòÎª0£¬¼ÄÊÛ²¢ÉÏ¼ÜÔòÎª1 
        [Order(6)] public byte Shelf { get; set; }

// ¼ÄÊÛÀàÐÍ£¬1-ÓÎÏ·±Ò£¬2-ÆÕÍ¨ÎïÆ·£¬3-³èÎï£¬4-½ÇÉ« 
        [Order(7)] public int Posttype { get; set; }

// ³ýÁË¿É¶ÑµþÎïÆ·£¬ÆäËû¾ùÎª1 
        [Order(8)] public int Num { get; set; }

// Íæ¼Òip£¬ÓÃÓÚÍ³¼Æ¼°¼à²â¹¤×÷ÊÒµÈ 
        [Order(9)] public int Loginip { get; set; }

// ¼ÄÊÛÏà¹ØÊ±¼ä 
        [Order(10)] public TimeInfo Time { get; set; }

// ¼ÄÊÛÎïÆ·µÄÐÅÏ¢ 
        [Order(11)] public PostInfo Info { get; set; }

// ÎïÆ·ÍêÕûÐÅÏ¢£¬ÓÃÓÚ²¹ÎïÆ· 
        [Order(12)] public byte[] Backup { get; set; }

// ±êÊ¶Ð­ÒéµÄÊ±¼ä´Á£¬²»Ò»¶¨ÊÇÊ±¼ä 
        [Order(13)] public long Timestamp { get; set; }

// ±£Áô×Ö¶Î 
        [Order(14)] public int Reserved1 { get; set; }

// ±£Áô×Ö¶Î 
        [Order(15)] public int Reserved2 { get; set; }
    }
}
