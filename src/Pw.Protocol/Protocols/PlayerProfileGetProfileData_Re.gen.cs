using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(952)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerProfileGetProfileData_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public PlayerProfileData Data { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
