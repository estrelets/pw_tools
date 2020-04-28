using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TimeInfo
    {
        // ¶¯×÷·¢ÆðÊ±¼äµã,msÎªµ¥Î» 
        [Order(0)] public long Actiontime { get; set; }

        // ¹«Ê¾ÆÚÊ±³¤£mminÎªµ¥Î»
        [Order(1)] public int Showperiod { get; set; }

        // ³öÊÛÊ±³¤£mminÎªµ¥Î» 
        [Order(2)] public int Sellperiod { get; set; }

        // ¼ÄÊÛÊ±³¤£mminÎªµ¥Î» 
        [Order(3)] public int Postperiod { get; set; }
    }
}
