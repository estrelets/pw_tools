using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(72)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class EnterWorld
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int ProviderLinkId { get; set; }

        [Order(2)] public int Locktime { get; set; }

        [Order(3)] public int Timeout { get; set; }

        [Order(4)] public int Settime { get; set; }

        [Order(5)] public uint LocalsId { get; set; }
    }
}
