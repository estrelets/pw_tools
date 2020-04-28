using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5025)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQProtocolStats
    {
        [Order(0)] public ACQ Acq { get; set; }

        [Order(1)] public ACProtocolStat[] ProtoStats { get; set; }
    }
}
