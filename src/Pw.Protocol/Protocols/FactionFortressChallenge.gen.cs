using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4416)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionFortressChallenge
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int FactionId { get; set; }

// below parameter is provide by gameserver
        [Order(2)] public int TargetFactionId { get; set; }

        [Order(3)] public byte[] SyncData { get; set; }
    }
}
