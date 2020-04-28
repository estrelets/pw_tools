using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(852)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class BattleChallenge
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public short Id { get; set; }

        [Order(2)] public uint FactionId { get; set; }

        [Order(3)] public uint Deposit { get; set; }

        [Order(4)] public int Authentication { get; set; }

        [Order(5)] public uint LocalsId { get; set; }
    }
}
