using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(151)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class QPGetActivatedServices_Re
    {
        [Order(0)] public int LocalsId { get; set; }

        [Order(1)] public List<int> Merchants { get; set; }

        [Order(2)] public int RetCode { get; set; }
    }
}
