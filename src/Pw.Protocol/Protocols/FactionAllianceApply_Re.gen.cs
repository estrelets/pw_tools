using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4517)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionAllianceApply_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int DstFId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
