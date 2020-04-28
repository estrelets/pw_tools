using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4758)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleServerRegister
    {
//0 Ê×¶¼³¡¾° 1 ¹úÕ½Õ½³¡
        [Order(0)] public int ServerType { get; set; }

        [Order(1)] public int WarType { get; set; }

        [Order(2)] public int ServerId { get; set; }

        [Order(3)] public int WorldTag { get; set; }
    }
}
