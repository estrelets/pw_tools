using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ForbidUserArg
    {
        //0 query, 1 forbid, 2 unforbid 
        [Order(0)] public char Operation { get; set; }

        [Order(1)] public int GmuserId { get; set; }

        [Order(2)] public int Source { get; set; }

        [Order(3)] public int UserId { get; set; }

        [Order(4)] public int Time { get; set; }

        [Order(5)] public byte[] Reason { get; set; }
    }
}
