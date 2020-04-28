using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(551)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class MatrixChallenge
    {
        [Order(0)] public int Algorithm { get; set; }

        [Order(1)] public uint Nonce { get; set; }
    }
}
