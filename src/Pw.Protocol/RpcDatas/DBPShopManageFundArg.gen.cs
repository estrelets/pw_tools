using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPShopManageFundArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Optype { get; set; }

        [Order(2)] public uint Money { get; set; }

        [Order(3)] public uint Yinpiao { get; set; }

        [Order(4)] public GMailSyncData SyncData { get; set; }
    }
}
