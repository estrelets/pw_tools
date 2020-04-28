using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(1102)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerChangeDS
    {
        [Order(0)] public int RoleId { get; set; }

//0:Õý³£µÇÂ½Âß¼­ 1:Ô­·þµ½¿ç·þ 2:¿ç·þµ½Ô­·þ 3:Ö±½ÓµÇÂ¼¿ç·þ·þÎñÆ÷
        [Order(1)] public char Flag { get; set; }
    }
}
