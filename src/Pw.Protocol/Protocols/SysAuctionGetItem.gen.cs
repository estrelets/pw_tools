using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4353)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SysAuctionGetItem
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public List<uint> Ids { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
