using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class MatrixPasswd2Res
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int UserId { get; set; }

        [Order(2)] public int Algorithm { get; set; }

        [Order(3)] public byte[] Response { get; set; }

        [Order(4)] public byte[] Matrix { get; set; }

        //seed pin rtime(AUÊ±¼ä)ÓÃÓÚ¶þ´úÉñ¶ÜµÇÂ½ÑéÖ¤
        [Order(5)] public byte[] Seed { get; set; }

        [Order(6)] public byte[] Pin { get; set; }

        [Order(7)] public int Rtime { get; set; }

        //AUµ±Ç°Ê±¼ä£¬ÓÃÓÚ¶ÔrtimeµÄµ÷Õû
        [Order(8)] public int AuCurtime { get; set; }

        [Order(9)] public GRoleForbid[] ForbId { get; set; }

        //ÉÏ´ÎµÇÂ½Ê¹ÓÃµÄ¶þ´úÉñ¶Üµç×ÓÂë
        [Order(10)] public byte[] LastUsedElecNumber { get; set; }
    }
}
