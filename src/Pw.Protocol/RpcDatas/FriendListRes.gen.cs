using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FriendListRes
    {
        [Order(0)] public char RetCode { get; set; }

        [Order(1)] public GFriendList Value { get; set; }

        [Order(2)] public GFriendExtInfo[] ExtraInfo { get; set; }

        [Order(3)] public GSendAUMailRecord[] SendmailInfo { get; set; }
    }
}
