using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4821)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetPlayerFactionRelation
    {
        [Order(0)] public int FactionId { get; set; }

        [Order(1)] public int RoleId { get; set; }
    }
}
