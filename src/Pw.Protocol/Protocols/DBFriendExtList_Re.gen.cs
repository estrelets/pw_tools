using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(232)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBFriendExtList_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RId { get; set; }

        [Order(2)] public GFriendExtInfo[] Friendext { get; set; }
    }
}
