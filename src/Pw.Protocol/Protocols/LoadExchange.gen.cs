using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1109)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class LoadExchange
    {
        [Order(0)] public int ZoneId { get; set; }

        [Order(1)] public uint Version { get; set; }

        [Order(2)] public byte[] Edition { get; set; }

        [Order(3)] public int ServerLimit { get; set; }

        [Order(4)] public int ServerCount { get; set; }
    }
}
