using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GroupBean
    {
        [Order(0)] public int Gtype { get; set; }

        [Order(1)] public long GroupId { get; set; }

        [Order(2)] public byte[] GroupName { get; set; }

        [Order(3)] public List<long> Friendlist { get; set; }
    }
}
