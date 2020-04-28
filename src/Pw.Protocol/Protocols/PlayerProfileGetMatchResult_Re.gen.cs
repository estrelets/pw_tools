using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(955)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerProfileGetMatchResult_Re
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public List<ProfileMatchResult> Result { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
