using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBFactionRelationApplyTimeoutArg
    {
        [Order(0)] public int Type { get; set; }

        [Order(1)] public int Fid1 { get; set; }

        [Order(2)] public int Fid2 { get; set; }

        [Order(3)] public int EndTime { get; set; }
    }
}
