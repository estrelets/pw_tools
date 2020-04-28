using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPlayerRenameArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int ItemId { get; set; }

        [Order(2)] public int ItemNum { get; set; }

        [Order(3)] public int ItemPos { get; set; }

        // below parameter is provide by gameserver
        [Order(4)] public byte[] NewName { get; set; }

        [Order(5)] public GMailSyncData SyncData { get; set; }
    }
}
