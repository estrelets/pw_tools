using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4406)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class CreateFactionFortress
    {
        [Order(0)] public int RoleId { get; set; }

// below parameter is provide by gameserver
        [Order(1)] public int FactionId { get; set; }

        [Order(2)] public byte[] ItemCost { get; set; }

        [Order(3)] public byte[] FortressInfo { get; set; }

        [Order(4)] public byte[] SyncData { get; set; }
    }
}
