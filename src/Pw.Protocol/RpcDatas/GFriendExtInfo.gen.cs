using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GFriendExtInfo
    {
        [Order(0)] public int UId { get; set; }

        [Order(1)] public int RId { get; set; }

        [Order(2)] public int Level { get; set; }

        [Order(3)] public int LastLogintime { get; set; }

        [Order(4)] public int UpdateTime { get; set; }

        [Order(5)] public byte ReincarnationTimes { get; set; }

        [Order(6)] public char Reserved0 { get; set; }

        [Order(7)] public short Reserved1 { get; set; }

        [Order(8)] public int Reserved2 { get; set; }

        [Order(9)] public int Reserved3 { get; set; }
    }
}
