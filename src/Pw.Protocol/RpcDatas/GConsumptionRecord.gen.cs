using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GConsumptionRecord
    {
        [Order(0)] public int Consumption { get; set; }

        [Order(1)] public int Reserved { get; set; }

        [Order(2)] public int Reserved2 { get; set; }
    }
}
