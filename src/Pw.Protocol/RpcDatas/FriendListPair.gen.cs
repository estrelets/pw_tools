using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.Protocols;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FriendListPair
    {
        [Order(0)]
        public RoleId Key { get; set; }
        [Order(1)]
        public GFriendList Value { get; set; }
        [Order(2)]
        public GFriendExtInfo[] ExtraInfo { get; set; }
        [Order(3)]
        public GSendAUMailRecord[] SendmailInfo { get; set; }
    }
}
