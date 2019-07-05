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
    public class DBPShopDrawItemArg
    {
        [Order(0)]
        public int RoleId { get; set; }
        //ÎïÆ·ÔÚµêÆÌ²Ö¿âµÄÎ»ÖÃ
        [Order(1)]
        public int ItemPos { get; set; }
        [Order(2)]
        public GMailSyncData SyncData { get; set; }
    }
}
