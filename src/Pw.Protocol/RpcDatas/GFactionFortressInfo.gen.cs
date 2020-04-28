using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GFactionFortressInfo
    {
        [Order(0)] public int Level { get; set; }

        [Order(1)] public int Exp { get; set; }

        [Order(2)] public int ExpToday { get; set; }

        [Order(3)] public int ExpTodayTime { get; set; }

        [Order(4)] public int TechPoint { get; set; }

        //¹Ì¶¨5¸öint
        [Order(5)] public byte[] Technology { get; set; }

        //¹Ì¶¨8¸öint
        [Order(6)] public byte[] Material { get; set; }

        //ÉÏÏÞ20¸öint*2
        [Order(7)] public byte[] Building { get; set; }

        //ÉÏÏÞ100¸öint*2
        [Order(8)] public byte[] CommonValue { get; set; }

        //ÉÏÏÞ100¸öint
        [Order(9)] public byte[] ActivedSpawner { get; set; }

        [Order(10)] public char Reserved11 { get; set; }

        [Order(11)] public short Reserved12 { get; set; }

        [Order(12)] public int Reserved2 { get; set; }

        [Order(13)] public int Reserved3 { get; set; }
    }
}
