using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBCountryBattleBonusRes
    {
        [Order(0)] public short RetCode { get; set; }

        [Order(1)] public GMailHeader InformPlayer { get; set; }
    }
}
