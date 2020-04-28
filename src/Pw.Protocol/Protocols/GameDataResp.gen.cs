using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8104)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GameDataResp
    {
        [Order(0)] public int Dtype { get; set; }

        [Order(1)] public long Id { get; set; }

        [Order(2)] public char RetCode { get; set; }

        [Order(3)] public byte[] Data { get; set; }
    }
}
