using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4801)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerFactionInfo
    {
        [Order(0)] public int[] Rolelist { get; set; }
    }
}
