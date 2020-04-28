using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(95)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerStatusSync
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int ProviderLinkId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public int Status { get; set; }

        [Order(4)] public int GsId { get; set; }
    }
}
