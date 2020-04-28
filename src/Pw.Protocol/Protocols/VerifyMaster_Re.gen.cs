using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(520)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class VerifyMaster_Re
    {
        [Order(0)] public byte[] RoleName { get; set; }

        [Order(1)] public int Ret { get; set; }
    }
}
