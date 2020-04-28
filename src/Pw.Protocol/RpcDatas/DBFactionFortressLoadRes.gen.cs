using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBFactionFortressLoadRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public List<GFactionFortressDetail> List { get; set; }

        [Order(2)] public byte[] Handle { get; set; }
    }
}
