using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleInfo
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public byte Gender { get; set; }

        [Order(2)] public byte Race { get; set; }

        [Order(3)] public byte Occupation { get; set; }

        [Order(4)] public int Level { get; set; }

        [Order(5)] public int Level2 { get; set; }

        [Order(6)] public byte[] Name { get; set; }

        [Order(7)] public byte[] CustomData { get; set; }

        [Order(8)] public GRoleInventory[] Equipment { get; set; }

        //whether the role is ready to delete 
        [Order(9)] public char Status { get; set; }

        [Order(10)] public int DeleteTime { get; set; }

        [Order(11)] public int CreateTime { get; set; }

        [Order(12)] public int LastloginTime { get; set; }

        [Order(13)] public float Posx { get; set; }

        [Order(14)] public float Posy { get; set; }

        [Order(15)] public float Posz { get; set; }

        [Order(16)] public int Worldtag { get; set; }

        [Order(17)] public byte[] CustomStatus { get; set; }

        [Order(18)] public byte[] Charactermode { get; set; }

        [Order(19)] public int ReferrerRole { get; set; }

        [Order(20)] public int CashAdd { get; set; }

        [Order(21)] public byte[] ReincarnationData { get; set; }

        [Order(22)] public byte[] RealmData { get; set; }
    }
}
