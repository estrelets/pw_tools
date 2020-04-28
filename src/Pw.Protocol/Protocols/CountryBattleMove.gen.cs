using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4760)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleMove
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Dest { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
