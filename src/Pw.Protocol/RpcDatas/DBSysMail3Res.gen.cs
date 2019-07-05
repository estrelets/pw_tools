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
    public class DBSysMail3Res
    {
        [Order(0)]
        public int RetCode { get; set; }
        [Order(1)]
        public byte MailId { get; set; }
        [Order(2)]
        public long RoleId { get; set; }
    }
}
