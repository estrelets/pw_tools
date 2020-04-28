using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SellPointArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        // 1 point = 1 second 
        [Order(2)] public int Point { get; set; }

        [Order(3)] public int Price { get; set; }

        [Order(4)] public int Timestamp { get; set; }

        [Order(5)] public int Money { get; set; }
    }
}
