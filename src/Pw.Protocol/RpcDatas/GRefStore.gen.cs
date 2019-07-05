using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.Protocols;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GRefStore
    {
        //×öÎªÉÏÏß´ÓËùÓÐÏÂÏßËùÌáÈ¡µÄºìÀûÀÛ¼ÆÖµ
        [Order(0)]
        public int BonusAdd { get; set; }
        //×öÎªÉÏÏßÔÚºìÀûÉÌ³ÇµÄÏû·ÑÀÛ¼ÆÖµ
        [Order(1)]
        public int BonusUsed { get; set; }
        //×öÎªÏÂÏßËûËù¶ÔÓ¦µÄÉÏÏßµÄuserid
        [Order(2)]
        public int Referrer { get; set; }
        //ÉÏÏßµÄroleid
        [Order(3)]
        public int ReferrerRoleId { get; set; }
        //×öÎªÏÂÏßÒòÎª×Ô¼ºÏû·ÑÔª±¦¶ø¿É¹©ÉÏÏßÌáÈ¡µÄºìÀûÀÛ¼ÆÖµ
        [Order(4)]
        public int BonusTotal1 { get; set; }
        //×öÎªÏÂÏßÒòÎª×Ô¼º´ÓÏÂÏßÌáÈ¡ºìÀû¶ø¿É¹©×Ô¼ºµÄÉÏÏßÌáÈ¡µÄºìÀûÀÛ¼ÆÖµ
        [Order(5)]
        public int BonusTotal2 { get; set; }
        //×÷ÎªÏÂÏßÒÑ±»ÉÏÏßÌáÈ¡µÄºìÀû ÀÛ¼ÆÖµ
        [Order(6)]
        public int BonusWithdraw { get; set; }
        //×öÎªÏÂÏß½ñÈÕ±»ÉÏÏßÌáÈ¡µÄºìÀûÀÛ¼ÆÖµ
        [Order(7)]
        public int BonusWithdrawToday { get; set; }
        //×öÎªÏÂÏß±¾ÕËºÅÏÂÏû·Ñ¹ýÔª±¦µÄ½ÇÉ«ÖÐµÈ¼¶×î¸ßµÄ½ÇÉ«µÄµÈ¼¶Êý-ÓÃÒÔÏÞÖÆÃ¿ÈÕ¿É¹©ÉÏÏßËùÌáÈ¡µÄºìÀûÊý
        [Order(8)]
        public int MaxRoleLevel { get; set; }
        [Order(9)]
        public List<byte[]> Rolenames { get; set; }
        [Order(10)]
        public int Reserved1 { get; set; }
        [Order(11)]
        public int Reserved2 { get; set; }
        [Order(12)]
        public int Reserved3 { get; set; }
        [Order(13)]
        public int Reserved4 { get; set; }
        [Order(14)]
        public int Reserved5 { get; set; }
        [Order(15)]
        public int Reserved6 { get; set; }
    }
}
