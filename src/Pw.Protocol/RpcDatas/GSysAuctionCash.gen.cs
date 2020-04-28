using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GSysAuctionCash
    {
        [Order(0)] public uint Cash2 { get; set; }

        [Order(1)] public uint CashUsed2 { get; set; }
    }
}
