using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBAutolockSetArg
    {
        [Order(0)] public int UserId { get; set; }

        [Order(1)] public List<GPair> Autolock { get; set; }
    }
}
