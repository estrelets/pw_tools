using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AddMemberRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public byte[] Name { get; set; }

        [Order(2)] public char Cls { get; set; }

        [Order(3)] public int Level { get; set; }

        [Order(4)] public int Reputation { get; set; }

        [Order(5)] public byte ReincarnTimes { get; set; }

        [Order(6)] public byte Gender { get; set; }
    }
}
