using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(162)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerAccuse_Re
    {
        [Order(0)] public uint LocalsId { get; set; }

        [Order(1)] public int DstRoleId { get; set; }

        [Order(2)] public int ReCode { get; set; }
    }
}
