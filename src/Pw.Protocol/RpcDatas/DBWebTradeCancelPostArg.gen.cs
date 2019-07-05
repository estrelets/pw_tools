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
    public class DBWebTradeCancelPostArg
    {
        [Order(0)]
        public long Sn { get; set; }
        [Order(1)]
        public int RoleId { get; set; }
        // 1:¼ÄÊÛÊ§°Ü 0:Íæ¼ÒÈ¡Ïû
        [Order(2)]
        public char Reason { get; set; }
    }
}
