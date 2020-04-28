using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBTransPointDealRes
    {
        [Order(0)] public int RetCode { get; set; }

        // which sell should be removed from delivery 
        [Order(1)] public int[] Delsell { get; set; }

        [Order(2)] public int Getmoney { get; set; }
    }
}
