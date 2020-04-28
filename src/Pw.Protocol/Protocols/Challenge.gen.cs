using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class Challenge
    {
        [Order(0)] public byte[] Nonce { get; set; }

        [Order(1)] public uint Version { get; set; }

        [Order(2)] public char Algo { get; set; }

        [Order(3)] public byte[] Edition { get; set; }

        [Order(4)] public byte ExpRate { get; set; }
    }
}
