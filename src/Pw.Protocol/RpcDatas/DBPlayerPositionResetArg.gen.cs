using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBPlayerPositionResetArg
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Worldtag { get; set; }

        [Order(2)] public float PosX { get; set; }

        [Order(3)] public float PosY { get; set; }

        [Order(4)] public float PosZ { get; set; }
    }
}
