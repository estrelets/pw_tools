using System.CodeDom.Compiler;
using Pw.Serializer;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class SNSRoleBrief
    {
        [Order(0)] public int Level { get; set; }

        [Order(1)] public int Exp { get; set; }

        [Order(2)] public int Sp { get; set; }

        [Order(3)] public int Level2 { get; set; }

        [Order(4)] public int Reputation { get; set; }

        [Order(5)] public int Pp { get; set; }

        [Order(6)] public int Vitality { get; set; }

        [Order(7)] public int Energy { get; set; }

        [Order(8)] public int Strength { get; set; }

        [Order(9)] public int Agility { get; set; }

        [Order(10)] public int MaxHp { get; set; }

        [Order(11)] public int MaxMp { get; set; }

        [Order(12)] public float RunSpeed { get; set; }

        [Order(13)] public int Attack { get; set; }

        [Order(14)] public int DamageLow { get; set; }

        [Order(15)] public int DamageHigh { get; set; }

        [Order(16)] public int AttackSpeed { get; set; }

        [Order(17)] public float AttackRange { get; set; }

        [Order(18)] public int DamageMagicLow { get; set; }

        [Order(19)] public int DamageMagicHigh { get; set; }

        [Order(20)] public int Resistance0 { get; set; }

        [Order(21)] public int Resistance1 { get; set; }

        [Order(22)] public int Resistance2 { get; set; }

        [Order(23)] public int Resistance3 { get; set; }

        [Order(24)] public int Resistance4 { get; set; }

        [Order(25)] public int Defense { get; set; }

        [Order(26)] public int Armor { get; set; }

        [Order(27)] public int CritRate { get; set; }

        [Order(28)] public int CritDamage { get; set; }

        [Order(29)] public int AttackDegree { get; set; }

        [Order(30)] public int DefendDegree { get; set; }

        [Order(31)] public int InvisibleDegree { get; set; }

        [Order(32)] public int AntiInvisibleDegree { get; set; }

        [Order(33)] public int SoulPower { get; set; }

        [Order(34)] public uint SkillsCrc { get; set; }

        [Order(35)] public uint EquipmentCrc { get; set; }

        [Order(36)] public uint PetcorralCrc { get; set; }

        [Order(37)] public int Spouse { get; set; }

        [Order(38)] public int FactionId { get; set; }
    }
}
