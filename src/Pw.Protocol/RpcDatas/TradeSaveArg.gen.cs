using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class TradeSaveArg
    {
        [Order(0)] public uint Roleid1 { get; set; }

        [Order(1)] public uint Roleid2 { get; set; }

        [Order(2)] public uint Money1 { get; set; }

        [Order(3)] public uint Money2 { get; set; }

        [Order(4)] public List<GRoleInventory> Goods1 { get; set; }

        [Order(5)] public List<GRoleInventory> Goods2 { get; set; }
    }
}
