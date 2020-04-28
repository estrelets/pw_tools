using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TradeStartRqstArg
    {
        //roleid who will receive the request
        [Order(0)] public int RoleId { get; set; }

        //roleid who will receive the request
        [Order(1)] public uint LocalsId { get; set; }

        //roleid who start the transaction
        [Order(2)] public int StartRoleId { get; set; }
    }
}
