using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMailHeader
    {
        [Order(0)] public byte Id { get; set; }

        [Order(1)] public int Sender { get; set; }

        // Is sender a NPC,bidding-sys,Player 
        [Order(2)] public byte SndrType { get; set; }

        [Order(3)] public int Receiver { get; set; }

        [Order(4)] public byte[] Title { get; set; }

        [Order(5)] public int SendTime { get; set; }

        // read/unread, attachment/or not, preserver/or not 
        [Order(6)] public byte Attribute { get; set; }

        [Order(7)] public byte[] SenderName { get; set; }
    }
}
