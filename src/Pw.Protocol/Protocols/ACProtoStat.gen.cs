using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5024)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACProtoStat
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Keepalive { get; set; }

        [Order(2)] public int Gamedatasend { get; set; }

        [Order(3)] public int Publicchat { get; set; }
    }
}
