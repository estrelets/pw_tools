using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(385)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMSetTimelessAutoLock
    {
        [Order(0)] public int GmRoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int DstRoleId { get; set; }

        [Order(3)] public char Enable { get; set; }
    }
}
