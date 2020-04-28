using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBSendMassMailArg
    {
        [Order(0)] public char MassType { get; set; }

        [Order(1)] public GMail Mail { get; set; }

        [Order(2)] public int CostObjId { get; set; }

        [Order(3)] public int CostObjNum { get; set; }

        [Order(4)] public int CostObjPos { get; set; }

        [Order(5)] public uint CostMoney { get; set; }

        [Order(6)] public List<int> ReceiverList { get; set; }

        [Order(7)] public GMailSyncData SyncData { get; set; }
    }
}
