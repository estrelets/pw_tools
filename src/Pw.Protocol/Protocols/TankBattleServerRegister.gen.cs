using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4871)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TankBattleServerRegister
    {
        [Order(0)] public int ServerId { get; set; }

        [Order(1)] public int WorldTag { get; set; }
    }
}
