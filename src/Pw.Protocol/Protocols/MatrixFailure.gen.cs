using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(553)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class MatrixFailure
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int Loginip { get; set; }

        [Order(2)] public int Weight { get; set; }
    }
}
