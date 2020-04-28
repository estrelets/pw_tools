using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4791)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetRemoteCNetServerConfig_Re
    {
        [Order(0)] public IntOctets[] Result { get; set; }

        [Order(1)] public uint LinksId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
