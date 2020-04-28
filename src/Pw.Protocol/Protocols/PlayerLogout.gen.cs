using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(69)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerLogout
    {
        [Order(0)] public int Result { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int ProviderLinkId { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
