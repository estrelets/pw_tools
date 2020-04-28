using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBDeleteRoleArg
    {
        [Order(0)] public int RoleId { get; set; }

        //whether need to response result to client 
        [Order(1)] public char CreateRollback { get; set; }
    }
}
