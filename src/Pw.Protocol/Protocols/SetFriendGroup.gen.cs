using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(210)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SetFriendGroup
    {
        [Order(0)] public char GId { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public int FriendId { get; set; }

        [Order(3)] public uint LocalsId { get; set; }
    }
}
