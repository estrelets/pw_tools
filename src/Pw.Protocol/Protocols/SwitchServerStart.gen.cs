using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4101)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SwitchServerStart
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int LinkId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public int SrcGsId { get; set; }

        [Order(4)] public int DstGsId { get; set; }

        [Order(5)] public byte[] Key { get; set; }
    }
}
