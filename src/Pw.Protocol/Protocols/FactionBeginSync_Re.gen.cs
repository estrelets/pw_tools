using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4809)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionBeginSync_Re
    {
        [Order(0)] public int RetCode { get; set; }

// transaction id
        [Order(1)] public uint TId { get; set; }

// role that is in the transcation
        [Order(2)] public int RoleId { get; set; }

// data that is nessessary and need sync
        [Order(3)] public FactionOPSyncInfo SyncData { get; set; }
    }
}
