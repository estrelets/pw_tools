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
    public class UserLoginRes
    {
        [Order(0)]
        public char RetCode { get; set; }
        [Order(1)]
        public int RemainPlaytime { get; set; }
        [Order(2)]
        public int Func { get; set; }
        [Order(3)]
        public int Funcparm { get; set; }
        [Order(4)]
        public char Blisgm { get; set; }
        [Order(5)]
        public int FreeTimeLeft { get; set; }
        [Order(6)]
        public int FreeTimeEnd { get; set; }
        [Order(7)]
        public int Creatime { get; set; }
        [Order(8)]
        public int Adduppoint { get; set; }
        [Order(9)]
        public int Soldpoint { get; set; }
    }
}
