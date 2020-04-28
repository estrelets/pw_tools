using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8035)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class WebGetRoleList_Re
    {
        [Order(0)] public int AId { get; set; }

        [Order(1)] public int UserId { get; set; }

        [Order(2)] public int RetCode { get; set; }

        [Order(3)] public List<WebRole> Rolelist { get; set; }

        [Order(4)] public long MessageId { get; set; }

        [Order(5)] public int Reserved1 { get; set; }

        [Order(6)] public int Reserved2 { get; set; }
    }
}
