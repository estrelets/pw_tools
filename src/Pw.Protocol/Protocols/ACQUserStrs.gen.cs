using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5010)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQUserStrs
    {
        [Order(0)] public ACQ Acq { get; set; }

        [Order(1)] public IntOctets[] Windows { get; set; }

        [Order(2)] public IntOctets[] Modules { get; set; }

        [Order(3)] public IntOctets[] Processes { get; set; }
    }
}
