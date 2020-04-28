using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4775)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleGetScore_Re
    {
        [Order(0)] public int PlayerScore { get; set; }

        [Order(1)] public List<int> CountryScore { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
