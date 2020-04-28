using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class OnlineAnnounce
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int RemainTime { get; set; }

        [Order(3)] public char ZoneId { get; set; }

        [Order(4)] public int FreeTimeLeft { get; set; }

        [Order(5)] public int FreeTimeEnd { get; set; }

        [Order(6)] public int Creatime { get; set; }

//0 auÒÑ¾­Ìá¹©ÍÆ¹ãid 1 auÃ»ÓÐÌá¹©ÍÆ¹ãid
        [Order(7)] public char ReferrerFlag { get; set; }

//bit0:ÃÜÂëÌ«¾ÃÎ´¸ü»» bit1:ÃÜ±£¿¨Ì«¾ÃÎ´¸ü»»
        [Order(8)] public char PasswdFlag { get; set; }

        [Order(9)] public char Usbbind { get; set; }

//bit0:ÐèÒª²¹ÌîÉí·ÝÖ¤ºÍÐÕÃû bit1:ÐèÒª²¹ÌîÕËºÅÃÜÂëÓÊÏä
        [Order(10)] public char AccountinfoFlag { get; set; }
    }
}
