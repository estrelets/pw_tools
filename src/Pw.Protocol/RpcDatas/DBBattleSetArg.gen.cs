using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBBattleSetArg
    {
        [Order(0)] public short Reason { get; set; }

        [Order(1)] public List<GTerritoryDetail> Cities { get; set; }
    }
}
