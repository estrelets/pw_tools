using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(36)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class UpdateRemainTime
    {
        [Order(0)] public int UserId { get; set; }

// for au, this is aid 
        [Order(1)] public int LocalsId { get; set; }

        [Order(2)] public int RemainTime { get; set; }

        [Order(3)] public int FreeTimeLeft { get; set; }

        [Order(4)] public int FreeTimeEnd { get; set; }
    }
}
