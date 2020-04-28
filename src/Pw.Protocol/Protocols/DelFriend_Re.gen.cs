using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(213)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DelFriend_Re
    {
        [Order(0)] public char RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int FriendId { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
