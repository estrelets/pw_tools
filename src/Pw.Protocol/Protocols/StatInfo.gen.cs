using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(60)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class StatInfo
    {
        [Order(0)] public int Priority { get; set; }

        [Order(1)] public string Msg { get; set; }

        [Order(2)] public string HostName { get; set; }

        [Order(3)] public string ServiceName { get; set; }
    }
}
