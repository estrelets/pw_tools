using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4703)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SyncForceGlobalData
    {
        [Order(0)] public List<GForceGlobalDataBrief> List { get; set; }
    }
}
