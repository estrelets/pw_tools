using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBCreateFactionFortressArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public byte[] ItemCost { get; set; }

        [Order(2)] public GFactionFortressDetail Detail { get; set; }

        [Order(3)] public GMailSyncData SyncData { get; set; }
    }
}
