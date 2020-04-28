using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(8069)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SysSendMail3_Re
    {
// ¶©µ¥ºÅ 
        [Order(0)] public long OrderId { get; set; }

        [Order(1)] public int RetCode { get; set; }

        [Order(2)] public long RoleId { get; set; }
    }
}
