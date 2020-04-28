using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1126)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class KickoutUser2
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int Cause { get; set; }
    }
}
