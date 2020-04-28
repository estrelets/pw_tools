using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBWebTradeSoldArg
    {
        [Order(0)] public long Sn { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int BuyerRoleId { get; set; }

        //Èç¹ûÂò¼ÒroleidÓëÂò¼Òuserid²»Æ¥ÅäÔòÒÔuseridÎª×¼
        [Order(3)] public int BuyerUserId { get; set; }
    }
}
