using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(117)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetCustomData_Re
    {
        [Order(0)] public int RetCode { get; set; }

//roleid of destination's owner 
        [Order(1)] public int RoleId { get; set; }

// localsid of the player who request the data 
        [Order(2)] public uint LocalsId { get; set; }

// roleid of customdata's owner 
        [Order(3)] public uint CusRoleId { get; set; }

        [Order(4)] public byte[] CustomData { get; set; }
    }
}
