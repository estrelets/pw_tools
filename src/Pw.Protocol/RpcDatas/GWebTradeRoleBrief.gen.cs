using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GWebTradeRoleBrief
    {
        //Ö°Òµ
        [Order(0)] public int Cls { get; set; }

        //ÐÔ±ð
        [Order(1)] public byte Gender { get; set; }

        //µÈ¼¶
        [Order(2)] public int Level { get; set; }

        //ÐÞÕæµÈ¼¶
        [Order(3)] public int Level2 { get; set; }

        //¾­Ñé
        [Order(4)] public int Exp { get; set; }

        //ÔªÉñ
        [Order(5)] public int Sp { get; set; }

        //Ê£ÓàÊôÐÔµã
        [Order(6)] public int Pp { get; set; }

        //ÉùÍû
        [Order(7)] public int Reputation { get; set; }

        //³èÎïÀ¸
        [Order(8)] public byte[] Petcorral { get; set; }

        //ÈËÎïÊôÐÔ
        [Order(9)] public byte[] Property { get; set; }

        //¼¼ÄÜ
        [Order(10)] public byte[] Skills { get; set; }

        //°ü¹üÀ¸
        [Order(11)] public GRolePocket Inventory { get; set; }

        //×°±¸À¸
        [Order(12)] public GRoleEquipment Equipment { get; set; }

        //²Ö¿â
        [Order(13)] public GRoleStorehouse Storehouse { get; set; }

        [Order(14)] public byte[] ForceData { get; set; }

        [Order(15)] public byte[] ReincarnationData { get; set; }

        [Order(16)] public byte[] RealmData { get; set; }

        [Order(17)] public byte[] ExtendData { get; set; }
    }
}
