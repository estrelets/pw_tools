using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4768)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleGetMap_Re
    {
        [Order(0)] public int RetCode { get; set; }

//Ò»¸öGCountryBattleDomainµÄ´óÐ¡Îª29£¬ÉèÖÃmaxsizeÎª32768¿ÉÒÔÖ§³Ö1000¿éµØÍ¼
        [Order(1)] public List<GCountryBattleDomain> Domains { get; set; }

        [Order(2)] public List<int> Kings { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
