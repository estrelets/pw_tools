using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4804)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionOPRequest
    {
// operation type 
        [Order(0)] public int Optype { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public byte[] Params { get; set; }
    }
}
