using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(350)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMOnlineNum
    {
        [Order(0)] public int GmRoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }
    }
}
