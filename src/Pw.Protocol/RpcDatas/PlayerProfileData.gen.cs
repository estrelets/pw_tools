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
    public class PlayerProfileData
    {
        [Order(0)]
        public ushort GameTimeMask { get; set; }
        [Order(1)]
        public ushort GameInterestMask { get; set; }
        [Order(2)]
        public ushort PersonalInterestMask { get; set; }
        [Order(3)]
        public byte Age { get; set; }
        [Order(4)]
        public byte Zodiac { get; set; }
        [Order(5)]
        public ushort MatchOptionMask { get; set; }
    }
}
