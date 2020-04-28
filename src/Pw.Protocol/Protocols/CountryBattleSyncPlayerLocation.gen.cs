using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4762)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CountryBattleSyncPlayerLocation
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int DomainId { get; set; }

        [Order(2)] public int Reason { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
