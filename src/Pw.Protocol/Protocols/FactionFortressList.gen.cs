using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4414)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionFortressList
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint Begin { get; set; }
    }
}
