using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(924)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopPlayerGet
    {
        [Order(0)] public int RoleId { get; set; }

//µêÖ÷ROLEID
        [Order(1)] public int Master { get; set; }
    }
}
