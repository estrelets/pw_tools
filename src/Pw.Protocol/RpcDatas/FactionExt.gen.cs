using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class FactionExt
    {
        [Order(0)] public int Level { get; set; }

        [Order(1)] public int Exp { get; set; }

        [Order(2)] public int FortressLvl { get; set; }

        [Order(3)] public int Health { get; set; }
    }
}
