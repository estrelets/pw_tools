using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4909)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RefGetReferenceCode_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int Level { get; set; }

        [Order(3)] public int Reputation { get; set; }

        [Order(4)] public byte[] RefCode { get; set; }

        [Order(5)] public int LocalsId { get; set; }
    }
}
