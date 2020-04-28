using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(163)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ServerTriggerNotify
    {
        [Order(0)] public List<int> TriggerCtrlList { get; set; }
    }
}
