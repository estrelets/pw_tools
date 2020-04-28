using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(918)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PShopDrawItem
    {
        [Order(0)] public int RoleId { get; set; }

//ÎïÆ·ÔÚµêÆÌ²Ö¿âµÄÎ»ÖÃ
        [Order(1)] public int ItemPos { get; set; }

        [Order(2)] public byte[] SyncData { get; set; }
    }
}
