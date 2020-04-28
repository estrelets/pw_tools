using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GRoleBase
    {
        [Order(0)] public char Version { get; set; }

        [Order(1)] public uint Id { get; set; }

        [Order(2)] public byte[] Name { get; set; }

        [Order(3)] public int Race { get; set; }

        [Order(4)] public int Cls { get; set; }

        [Order(5)] public byte Gender { get; set; }

        [Order(6)] public byte[] CustomData { get; set; }

        [Order(7)] public byte[] ConfigData { get; set; }

        [Order(8)] public uint CustomStamp { get; set; }

        //whether the role is ready to delete 
        [Order(9)] public byte Status { get; set; }

        //delete time
        [Order(10)] public int DeleteTime { get; set; }

        [Order(11)] public int CreateTime { get; set; }

        [Order(12)] public int LastloginTime { get; set; }

        [Order(13)] public GRoleForbid[] ForbId { get; set; }

        [Order(14)] public byte[] HelpStates { get; set; }

        [Order(15)] public uint Spouse { get; set; }

        [Order(16)] public uint UserId { get; set; }

        [Order(17)] public byte[] CrossData { get; set; }

        [Order(18)] public byte Reserved2 { get; set; }

        [Order(19)] public byte Reserved3 { get; set; }

        [Order(20)] public byte Reserved4 { get; set; }
    }
}
