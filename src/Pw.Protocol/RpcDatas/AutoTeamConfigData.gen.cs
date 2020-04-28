using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AutoTeamConfigData
    {
        [Order(0)] public int GoalId { get; set; }

        [Order(1)] public byte NeedPlayerCnt { get; set; }

        [Order(2)] public List<KeyValuePair<char, char>> OccupationInfo { get; set; }
    }
}
