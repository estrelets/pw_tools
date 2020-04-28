using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4526)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionDelayExpelAnnounce
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public char OptType { get; set; }

// the role who do this operation 
        [Order(2)] public int Operater { get; set; }

        [Order(3)] public int ExpelRoleId { get; set; }

        [Order(4)] public int Time { get; set; }

        [Order(5)] public uint LocalsId { get; set; }
    }
}
