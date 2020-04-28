using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(203)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AddFriend_Re
    {
        [Order(0)] public char RetCode { get; set; }

        [Order(1)] public GFriendInfo Info { get; set; }

        [Order(2)] public uint SrclsId { get; set; }
    }
}
