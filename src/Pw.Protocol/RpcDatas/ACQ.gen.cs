using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQ
    {
        [Order(0)] public int QueryType { get; set; }

        [Order(1)] public int ZoneId { get; set; }

        [Order(2)] public int RoleId { get; set; }

        [Order(3)] public int XId { get; set; }

        [Order(4)] public int Timeout { get; set; }
    }
}
