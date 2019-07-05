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
    public class SSOExtraInfo1
    {
        [Order(0)]
        public int RoleId { get; set; }
        [Order(1)]
        public byte[] RoleName { get; set; }
        [Order(2)]
        public int Level { get; set; }
        [Order(3)]
        public int SecLevel { get; set; }
        [Order(4)]
        public int Reputation { get; set; }
        [Order(5)]
        public int CreateTime { get; set; }
        [Order(6)]
        public int FactionId { get; set; }
        [Order(7)]
        public List<KeyValuePair<int, int>> Item { get; set; }
    }
}
