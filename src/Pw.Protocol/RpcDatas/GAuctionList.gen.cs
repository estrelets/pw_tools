using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GAuctionList
    {
        [Order(0)] public ushort Category { get; set; }

        [Order(1)] public List<GAuctionDetail> List { get; set; }
    }
}
