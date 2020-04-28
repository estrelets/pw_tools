using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8135)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleInfoUpdate
    {
        [Order(0)] public RoleInfoBean Roleinfo { get; set; }

        [Order(1)] public int Updateflag { get; set; }
    }
}
