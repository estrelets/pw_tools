using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4792)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleDestroyInstance
    {
        [Order(0)] public int DomainId { get; set; }

        [Order(1)] public int WorldTag { get; set; }
    }
}
