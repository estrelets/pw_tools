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
    public class PlayerConsumeInfo
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public int Level { get; set; }
        [Order(2)]
        public int LoginIp { get; set; }
        [Order(3)]
        public uint CashAdd { get; set; }
        [Order(4)]
        public uint MallConsumption { get; set; }
        [Order(5)]
        public uint AvgOnlineTime { get; set; }
    }
}
