using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(517)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class UseCash
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int ZoneId { get; set; }

        [Order(2)] public int AId { get; set; }

        [Order(3)] public int Point { get; set; }

        [Order(4)] public int Cash { get; set; }
    }
}
