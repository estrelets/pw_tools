using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACCPUInfo
    {
        [Order(0)] public short Arch { get; set; }

        [Order(1)] public short Level { get; set; }

        [Order(2)] public int Ct { get; set; }

        [Order(3)] public int Count { get; set; }
    }
}
