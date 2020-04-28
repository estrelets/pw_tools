using System.CodeDom.Compiler;
using System.Collections.Generic;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GGlobalControlData
    {
        [Order(0)] public char CashMoneyExchangeOpen { get; set; }

        [Order(1)] public int CashMoneyExchangeRate { get; set; }

        [Order(2)] public List<int> ForbidCtrlList { get; set; }

        [Order(3)] public List<int> ForbidItemList { get; set; }

        [Order(4)] public List<int> ForbidServiceList { get; set; }

        [Order(5)] public List<int> ForbidTaskList { get; set; }

        [Order(6)] public List<int> ForbidSkillList { get; set; }

        [Order(7)] public List<int> TriggerCtrlList { get; set; }

        [Order(8)] public char Reserved12 { get; set; }

        [Order(9)] public char Reserved13 { get; set; }

        [Order(10)] public int Reserved3 { get; set; }

        [Order(11)] public int Reserved4 { get; set; }

        [Order(12)] public int Reserved5 { get; set; }

        [Order(13)] public int Reserved6 { get; set; }

        [Order(14)] public int Reserved7 { get; set; }

        [Order(15)] public int Reserved8 { get; set; }

        [Order(16)] public int Reserved9 { get; set; }

        [Order(17)] public int Reserved10 { get; set; }
    }
}
