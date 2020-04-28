using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(368)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class Report2GM
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public byte[] RoleName { get; set; }

        [Order(3)] public int ZoneId { get; set; }

        [Order(4)] public byte[] Mapzone { get; set; }

        [Order(5)] public float Posx { get; set; }

        [Order(6)] public float Posy { get; set; }

        [Order(7)] public float Posz { get; set; }

        [Order(8)] public byte[] Content { get; set; }

        [Order(9)] public int AId { get; set; }

        [Order(10)] public byte[] Line { get; set; }

        [Order(11)] public int ComRoleId { get; set; }

        [Order(12)] public byte[] ComRoleName { get; set; }
    }
}
