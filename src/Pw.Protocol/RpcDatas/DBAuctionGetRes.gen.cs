using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBAuctionGetRes
    {
        [Order(0)] public byte RetCode { get; set; }

        [Order(1)] public GAuctionDetail Item { get; set; }
    }
}
