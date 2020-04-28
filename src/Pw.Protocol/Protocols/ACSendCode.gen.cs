using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5011)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACSendCode
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public string CodeName { get; set; }

        [Order(2)] public string Param { get; set; }
    }
}
