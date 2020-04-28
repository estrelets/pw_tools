using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(136)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class AnnounceChallengeAlgo
    {
        [Order(0)] public char ChallengeAlgo { get; set; }
    }
}
