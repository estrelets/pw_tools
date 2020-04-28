using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GForceGlobalData
    {
        [Order(0)] public int ForceId { get; set; }

        [Order(1)] public int PlayerCount { get; set; }

        [Order(2)] public int Development { get; set; }

        [Order(3)] public int Construction { get; set; }

        [Order(4)] public int Activity { get; set; }

        [Order(5)] public int ActivityLevel { get; set; }

        [Order(6)] public int Reserved1 { get; set; }

        [Order(7)] public int Reserved2 { get; set; }

        [Order(8)] public int Reserved3 { get; set; }

        [Order(9)] public int Reserved4 { get; set; }

        [Order(10)] public int Reserved5 { get; set; }

        [Order(11)] public int Reserved6 { get; set; }

        [Order(12)] public int Reserved7 { get; set; }

        [Order(13)] public int Reserved8 { get; set; }
    }
}
