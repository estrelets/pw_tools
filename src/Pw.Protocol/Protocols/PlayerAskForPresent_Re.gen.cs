using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(3069)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerAskForPresent_Re
    {
        [Order(0)] public int LocalsId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int RetCode { get; set; }
    }
}
