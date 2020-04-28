using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4213)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerSendMail_Re
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int RoleId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public int Receiver { get; set; }

        [Order(4)] public int AttachObjNum { get; set; }

        [Order(5)] public int AttachObjPos { get; set; }

        [Order(6)] public uint AttachMoney { get; set; }
    }
}
