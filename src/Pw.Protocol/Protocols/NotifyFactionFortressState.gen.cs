using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4410)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class NotifyFactionFortressState
    {
        [Order(0)] public int FactionId { get; set; }

// 0 ¹Ø±Õ 1 ¿ªÆô 
        [Order(1)] public int State { get; set; }
    }
}
