using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(116)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetCustomData
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public int[] Playerlist { get; set; }
    }
}
