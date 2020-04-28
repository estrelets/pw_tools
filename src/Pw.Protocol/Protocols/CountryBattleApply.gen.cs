using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4751)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleApply
    {
        [Order(0)] public List<CountryBattleApplyEntry> List { get; set; }
    }
}
