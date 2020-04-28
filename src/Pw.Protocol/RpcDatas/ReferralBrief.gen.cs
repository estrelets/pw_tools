using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ReferralBrief
    {
        [Order(0)] public List<byte[]> Rolenames { get; set; }

        [Order(1)] public int MaxLevel { get; set; }

        //ÓÉÓÚ±¾ÈËÏûºÄÔª±¦¶ÔÉÏÏßµÄÀúÊ·×Ü¹±Ï×ºèÀûÖµ
        [Order(2)] public int BonusTotal1 { get; set; }

        //ÓÉÓÚ±¾ÈËÏÂÏßÏûºÄÔª±¦¶Ô±¾ÈËÉÏÏßµÄÀúÊ·×Ü¹±Ï×ºèÀûÖµ
        [Order(3)] public int BonusTotal2 { get; set; }

        //Ê£ÓàÁ¿
        [Order(4)] public int BonusLeft { get; set; }

        //¿ÉÌáÈ¡Á¿
        [Order(5)] public int BonusAvail { get; set; }
    }
}
