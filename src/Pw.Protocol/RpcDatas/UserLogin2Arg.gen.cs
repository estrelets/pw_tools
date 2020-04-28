using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class UserLogin2Arg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public char Blkickuser { get; set; }

        [Order(3)] public int Freecreatime { get; set; }

        //±¾´ÎµÇÂ½Ê¹ÓÃµÄ¶þ´úÉñ¶Üµç×ÓÂë
        [Order(4)] public byte[] UsedElecNumber { get; set; }

        [Order(5)] public int Reserved1 { get; set; }

        [Order(6)] public byte[] Reserved2 { get; set; }

        [Order(7)] public int Loginip { get; set; }

        [Order(8)] public byte[] Account { get; set; }

        [Order(9)] public byte[] Iseckey { get; set; }

        [Order(10)] public byte[] Oseckey { get; set; }
    }
}
