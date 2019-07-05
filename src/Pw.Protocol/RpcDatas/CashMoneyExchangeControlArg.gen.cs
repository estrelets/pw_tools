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
    public class CashMoneyExchangeControlArg
    {
        // 1 ÉèÖÃ±ÈÂÊ 2 ¿ªÆô¹Ø±Õ¶Ò»»
        [Order(0)]
        public char Oper { get; set; }
        // oper==1 ±íÊ¾±ÈÂÊ oper==2 (1¿ª0¹Ø)
        [Order(1)]
        public int Param { get; set; }
    }
}
