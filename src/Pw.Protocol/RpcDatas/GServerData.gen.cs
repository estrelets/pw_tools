using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GServerData
    {
        [Order(0)] public int WorldTag { get; set; }

        [Order(1)] public byte[] WeddingData { get; set; }

        [Order(2)] public byte[] DpsrankData { get; set; }

        [Order(3)] public char Reserved11 { get; set; }

        [Order(4)] public short Reserved12 { get; set; }

        [Order(5)] public int Reserved2 { get; set; }

        [Order(6)] public int Reserved3 { get; set; }

        [Order(7)] public int Reserved4 { get; set; }

        [Order(8)] public int Reserved5 { get; set; }
    }
}
