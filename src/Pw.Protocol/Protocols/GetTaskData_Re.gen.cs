using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(112)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GetTaskData_Re
    {
        [Order(0)] public int TaskId { get; set; }

        [Order(1)] public int PlayerId { get; set; }

        [Order(2)] public byte[] Env { get; set; }

        [Order(3)] public int RetCode { get; set; }

        [Order(4)] public byte[] TaskData { get; set; }
    }
}
