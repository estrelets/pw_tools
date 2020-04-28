using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(782)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AutolockSet
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int UserId { get; set; }

        [Order(2)] public int Timeout { get; set; }

        [Order(3)] public int LocalsId { get; set; }
    }
}
