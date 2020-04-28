using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(209)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SetGroupName_Re
    {
        [Order(0)] public char RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public char GId { get; set; }

        [Order(3)] public byte[] Name { get; set; }

        [Order(4)] public uint LocalsId { get; set; }
    }
}
