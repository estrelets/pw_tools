using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8039)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class Game2AU
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int Qtype { get; set; }

        [Order(2)] public byte[] Info { get; set; }

        [Order(3)] public int Reserved { get; set; }
    }
}
