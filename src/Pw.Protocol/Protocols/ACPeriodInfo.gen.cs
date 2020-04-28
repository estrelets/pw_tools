using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5019)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACPeriodInfo
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int IsValId { get; set; }

        [Order(2)] public List<List<int>> ProcessTimes { get; set; }

        [Order(3)] public List<List<int>> ThreadsTimes { get; set; }

        [Order(4)] public List<KeyValuePair<float, List<int>>> Mouse { get; set; }
    }
}
