using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(4704)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class NotifyPlayerJoinOrLeaveForce
    {
        [Order(0)] public int ForceId { get; set; }

        [Order(1)] public char IsJoin { get; set; }
    }
}
