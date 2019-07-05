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
    public class UserLoginArg
    {
        [Order(0)]
        public int UserId { get; set; }
        [Order(1)]
        public uint LocalsId { get; set; }
        [Order(2)]
        public char Blkickuser { get; set; }
        [Order(3)]
        public int Freecreatime { get; set; }
        [Order(4)]
        public int Loginip { get; set; }
        [Order(5)]
        public byte[] Account { get; set; }
        [Order(6)]
        public byte[] Iseckey { get; set; }
        //au set maxsize=128 
        [Order(7)]
        public byte[] Oseckey { get; set; }
    }
}
