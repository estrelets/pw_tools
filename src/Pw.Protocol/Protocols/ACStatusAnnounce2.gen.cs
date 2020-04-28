using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5034)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACStatusAnnounce2
    {
        [Order(0)] public int Status { get; set; }

        [Order(1)] public List<ACOnlineStatus2> InfoList { get; set; }
    }
}
