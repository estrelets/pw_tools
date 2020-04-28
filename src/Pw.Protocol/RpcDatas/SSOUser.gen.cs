using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SSOUser
    {
        [Order(0)] public char Isagent { get; set; }

        [Order(1)] public long UserId { get; set; }

        [Order(2)] public byte[] Account { get; set; }

        [Order(3)] public byte[] AgentName { get; set; }

        [Order(4)] public byte[] Agentaccount { get; set; }
    }
}
