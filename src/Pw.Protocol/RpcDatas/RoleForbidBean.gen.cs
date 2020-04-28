using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class RoleForbidBean
    {
        [Order(0)] public Dictionary<int, long> Endtime { get; set; }

        [Order(1)] public byte[] Extinfo { get; set; }
    }
}
