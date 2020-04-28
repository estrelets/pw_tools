using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4522)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionRemoveRelationReply_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int DstFId { get; set; }

        [Order(2)] public char Agree { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
