using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4359)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SysAuctionCashTransfer
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public char Withdraw { get; set; }

        [Order(2)] public uint Cash { get; set; }

        [Order(3)] public uint LocalsId { get; set; }

        [Order(4)] public byte[] SyncData { get; set; }
    }
}
