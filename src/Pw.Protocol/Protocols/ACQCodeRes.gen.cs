using System.CodeDom.Compiler;
using Pw.RpcDatas;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(5012)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class ACQCodeRes
    {
        [Order(0)] public ACQ Acq { get; set; }

        [Order(1)] public ACUserCodeRes[] Res { get; set; }
    }
}
