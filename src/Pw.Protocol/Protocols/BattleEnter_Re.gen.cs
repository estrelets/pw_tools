using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(861)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class BattleEnter_Re
    {
        [Order(0)] public ushort RetCode { get; set; }

        [Order(1)] public uint LocalsId { get; set; }
    }
}
