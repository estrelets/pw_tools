using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SellPointInfo
    {
        [Order(0)] public int SellId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int Point { get; set; }

        [Order(3)] public int Price { get; set; }

        [Order(4)] public int Ctime { get; set; }

        [Order(5)] public int Etime { get; set; }

        [Order(6)] public char Status { get; set; }
    }
}
