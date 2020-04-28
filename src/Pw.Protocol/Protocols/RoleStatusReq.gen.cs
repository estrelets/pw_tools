using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8125)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleStatusReq
    {
        [Order(0)] public long LocalrId { get; set; }

        [Order(1)] public List<long> Rolelist { get; set; }
    }
}
