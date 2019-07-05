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
    public class DBBattleBonusArg
    {
        [Order(0)]
        public uint FactionId { get; set; }
        [Order(1)]
        public short CityId { get; set; }
        [Order(2)]
        public uint Money { get; set; }
        [Order(3)]
        public GRoleInventory Item { get; set; }
        [Order(4)]
        public short Isspecialbonus { get; set; }
    }
}
