using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class DBRoleNameListRes
    {
        [Order(0)] public int RetCode { get; set; }

        [Order(1)] public int Handle { get; set; }

        [Order(2)] public char Finish { get; set; }

        [Order(3)] public List<GRoleIDandName> Rolenamelist { get; set; }
    }
}
