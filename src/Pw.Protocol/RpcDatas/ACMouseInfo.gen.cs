using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACMouseInfo
    {
        [Order(0)] public int LbuttonFreq { get; set; }

        [Order(1)] public int RbuttonFreq { get; set; }

        [Order(2)] public int MousemoveFreq { get; set; }

        [Order(3)] public float Mousemovevelo { get; set; }

        [Order(4)] public IntData[] GCounts { get; set; }

        [Order(5)] public IntData[] GTimes { get; set; }
    }
}
