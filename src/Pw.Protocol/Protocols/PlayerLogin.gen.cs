using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.Protocols
{
    [OpCode(65)]
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class PlayerLogin
    {
        [Order(0)] public int RoleId { get; set; }

        [Order(1)] public int ProviderLinkId { get; set; }

        [Order(2)] public uint LocalsId { get; set; }

        [Order(3)] public byte[] Auth { get; set; }

        [Order(4)] public char Usbbind { get; set; }

//0:Õý³£µÇÂ½Âß¼­ 1:Ô­·þµ½¿ç·þ 2:¿ç·þµ½Ô­·þ 3:Ö±½ÓµÇÂ¼¿ç·þ·þÎñÆ÷
        [Order(5)] public char Flag { get; set; }
    }
}
