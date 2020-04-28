using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(212)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DelFriend
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int FriendId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }
    }
}
