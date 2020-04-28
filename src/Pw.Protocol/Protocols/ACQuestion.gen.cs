using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5031)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQuestion
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Qtype { get; set; }

        [Order(2)] public int Seq { get; set; }

        [Order(3)] public int Reserved { get; set; }

        [Order(4)] public List<byte[]> Question { get; set; }
    }
}
