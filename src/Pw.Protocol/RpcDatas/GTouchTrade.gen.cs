using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GTouchTrade
    {
        [Order(0)] public long Sn { get; set; }

        [Order(1)] public char State { get; set; }

        [Order(2)] public uint Cost { get; set; }

        [Order(3)] public uint ItemId { get; set; }

        [Order(4)] public uint Count { get; set; }

        [Order(5)] public uint Lots { get; set; }

        [Order(6)] public int Expiretime { get; set; }
    }
}
