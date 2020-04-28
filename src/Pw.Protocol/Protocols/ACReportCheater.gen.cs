using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5029)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACReportCheater
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int Cheattype { get; set; }

        [Order(2)] public byte[] Cheatinfo { get; set; }
    }
}
