using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8127)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleStatusUpdate
    {
        [Order(0)] public long RoleId { get; set; }

        [Order(1)] public RoleStatusBean Status { get; set; }

        [Order(2)] public List<long> Friends { get; set; }

        [Order(3)] public FactionIDBean[] Factions { get; set; }
    }
}
