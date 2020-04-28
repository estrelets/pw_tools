using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(3059)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerRename
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int AttachObjId { get; set; }

        [Order(2)] public int AttachObjNum { get; set; }

        [Order(3)] public int AttachObjPos { get; set; }

// below parameter is provide by gameserver
        [Order(4)] public byte[] NewName { get; set; }

        [Order(5)] public byte[] SyncData { get; set; }
    }
}
