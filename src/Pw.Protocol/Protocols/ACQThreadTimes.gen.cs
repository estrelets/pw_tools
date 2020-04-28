using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5023)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQThreadTimes
    {
        [Order(0)] public ACQ Acq { get; set; }

        [Order(1)] public ACThreadTime ProcessTime { get; set; }

        [Order(2)] public ACThreadTime[] ThreadTimes { get; set; }
    }
}
