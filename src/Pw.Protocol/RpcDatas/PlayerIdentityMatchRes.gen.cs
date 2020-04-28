using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerIdentityMatchRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public byte[] Iseckey { get; set; }

        [Order(2)] public byte[] Oseckey { get; set; }

        [Order(3)] public byte[] Account { get; set; }

        [Order(4)] public User User { get; set; }

        [Order(5)] public GRoleInfo Roleinfo { get; set; }

        [Order(6)] public int ZoneId { get; set; }

        [Order(7)] public int DistrictId { get; set; }
    }
}
