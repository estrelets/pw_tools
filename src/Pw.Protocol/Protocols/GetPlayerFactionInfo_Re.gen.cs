using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4817)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetPlayerFactionInfo_Re
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public GUserFaction FactionInfo { get; set; }
    }
}
