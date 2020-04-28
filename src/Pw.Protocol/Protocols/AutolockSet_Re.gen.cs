using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(783)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AutolockSet_Re
    {
        [Order(0)] public int Result { get; set; }

        [Order(1)] public int Timeout { get; set; }

        [Order(2)] public int LocalsId { get; set; }
    }
}
