using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(146)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SynMutaData
    {
        [Order(0)] public uint Synmask { get; set; }

        [Order(1)] public uint RoleId { get; set; }

        [Order(2)] public int Level { get; set; }

        [Order(3)] public int ReincarnationTimes { get; set; }
    }
}
