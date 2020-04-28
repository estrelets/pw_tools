using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4523)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionListRelation_Re
    {
        [Order(0)] public int LastOpTime { get; set; }

        [Order(1)] public GFactionAlliance[] Alliance { get; set; }

        [Order(2)] public GFactionHostile[] Hostile { get; set; }

        [Order(3)] public GFactionRelationApply[] Apply { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
