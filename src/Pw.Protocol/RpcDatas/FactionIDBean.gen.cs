using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionIDBean
    {
        [Order(0)] public int Ftype { get; set; }

        [Order(1)] public long FactionId { get; set; }
    }
}
