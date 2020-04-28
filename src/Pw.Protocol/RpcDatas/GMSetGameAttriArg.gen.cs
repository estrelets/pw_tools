using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GMSetGameAttriArg
    {
        [Order(0)] public int GmRoleId { get; set; }

        [Order(1)] public uint LocalsId { get; set; }

        [Order(2)] public byte Attribute { get; set; }

        [Order(3)] public byte[] Value { get; set; }
    }
}
