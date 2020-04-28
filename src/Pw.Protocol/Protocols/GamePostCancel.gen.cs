using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8022)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GamePostCancel
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public long RoleId { get; set; }

        [Order(2)] public long Sn { get; set; }

        [Order(3)] public long Timestamp { get; set; }

        [Order(4)] public int Reserved1 { get; set; }

        [Order(5)] public int Reserved2 { get; set; }
    }
}
