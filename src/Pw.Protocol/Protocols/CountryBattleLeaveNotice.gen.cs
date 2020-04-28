using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4754)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleLeaveNotice
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int CountryId { get; set; }

        [Order(2)] public int MajorStrength { get; set; }

        [Order(3)] public int MinorStrength { get; set; }
    }
}
