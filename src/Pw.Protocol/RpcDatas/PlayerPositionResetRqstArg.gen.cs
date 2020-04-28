using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerPositionResetRqstArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public int Worldtag { get; set; }

        // 1 ¸±±¾´ïÉÏÏÞ 2 ÈËÊý´ïÉÏÏÞ	
        [Order(4)] public int Reason { get; set; }

        [Order(5)] public float PosX { get; set; }

        [Order(6)] public float PosY { get; set; }

        [Order(7)] public float PosZ { get; set; }
    }
}
