using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(10)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class KickoutUser
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public byte Cause { get; set; }
    }
}
