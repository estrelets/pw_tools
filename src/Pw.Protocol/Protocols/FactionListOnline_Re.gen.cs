using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4820)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionListOnline_Re
    {
        [Order(0)] public List<uint> FidList { get; set; }

        [Order(1)] public uint LocalsId { get; set; }
    }
}
