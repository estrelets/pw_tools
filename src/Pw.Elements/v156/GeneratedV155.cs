using Pw.Serializer;

// ReSharper disable IdentifierTypo
// ReSharper disable UnusedMember.Global
// ReSharper disable UnusedType.Global
// ReSharper disable ClassNeverInstantiated.Global

namespace Pw.Elements.v156
{
    [Order(0)]
    public class EquipmentAddon : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int NumParams { get; set; }

        [Order(3)] public int Param1 { get; set; }

        [Order(4)] public int Param2 { get; set; }

        [Order(5)] public int Param3 { get; set; }
    }

    [Order(1)]
    public class WeaponMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(2)]
    public class WeaponSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileHitgfx { get; set; }

        [Order(3)] [Size(128)] public string FileHitsfx { get; set; }

        [Order(4)] public float ProbabilityFastest { get; set; }

        [Order(5)] public float ProbabilityFast { get; set; }

        [Order(6)] public float ProbabilityNormal { get; set; }

        [Order(7)] public float ProbabilitySlow { get; set; }

        [Order(8)] public float ProbabilitySlowest { get; set; }

        [Order(9)] public float AttackSpeed { get; set; }

        [Order(10)] public float AttackShortRange { get; set; }

        [Order(11)] public uint ActionType { get; set; }
    }

    [Order(3)]
    public class WeaponEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] public uint RequireProjectile { get; set; }

        [Order(5)] [Size(128)] public string FileModelRight { get; set; }

        [Order(6)] [Size(128)] public string FileModelLeft { get; set; }

        [Order(7)] [Size(128)] public string FileMatter { get; set; }

        [Order(8)] [Size(128)] public string FileIcon { get; set; }

        [Order(9)] public int RequireStrength { get; set; }

        [Order(10)] public int RequireAgility { get; set; }

        [Order(11)] public int RequireEnergy { get; set; }

        [Order(12)] public int RequireTili { get; set; }

        [Order(13)] public uint CharacterComboId { get; set; }

        [Order(14)] public int RequireLevel { get; set; }

        [Order(15)] public int RequireReputation { get; set; }

        [Order(16)] public int Level { get; set; }

        [Order(17)] public int FixedProps { get; set; }

        [Order(18)] public float ProbabilityHide { get; set; }

        [Order(19)] public int DamageLow { get; set; }

        [Order(20)] public int DamageHighMin { get; set; }

        [Order(21)] public int DamageHighMax { get; set; }

        [Order(22)] public int MagicDamageLow { get; set; }

        [Order(23)] public int MagicDamageHighMin { get; set; }

        [Order(24)] public int MagicDamageHighMax { get; set; }

        [Order(25)] public float AttackRange { get; set; }

        [Order(26)] public uint ShortRangeMode { get; set; }

        [Order(27)] public int DurabilityMin { get; set; }

        [Order(28)] public int DurabilityMax { get; set; }

        [Order(29)] public int LevelupAddon { get; set; }

        [Order(30)] public int MaterialNeed { get; set; }

        [Order(31)] public int Price { get; set; }

        [Order(32)] public int ShopPrice { get; set; }

        [Order(33)] public int Repairfee { get; set; }

        [Order(34)] public float DropProbabilitySocket0 { get; set; }

        [Order(35)] public float DropProbabilitySocket1 { get; set; }

        [Order(36)] public float DropProbabilitySocket2 { get; set; }

        [Order(37)] public float MakeProbabilitySocket0 { get; set; }

        [Order(38)] public float MakeProbabilitySocket1 { get; set; }

        [Order(39)] public float MakeProbabilitySocket2 { get; set; }

        [Order(40)] public float ProbabilityAddonNum0 { get; set; }

        [Order(41)] public float ProbabilityAddonNum1 { get; set; }

        [Order(42)] public float ProbabilityAddonNum2 { get; set; }

        [Order(43)] public float ProbabilityAddonNum3 { get; set; }

        [Order(44)] public float ProbabilityAddonNum4 { get; set; }

        [Order(45)] public float ProbabilityAddonNum5 { get; set; }

        [Order(46)] public float ProbabilityUnique { get; set; }

        [Order(47)] [Size(32)] public Probability[] Addons { get; set; }

        [Order(48)] [Size(32)] public Probability[] Rands { get; set; }

        [Order(49)] [Size(16)] public Probability[] Uniques { get; set; }

        [Order(50)] [Size(16)] public Probability[] Hides { get; set; }

        [Order(51)] public int DurabilityDropMin { get; set; }

        [Order(52)] public int DurabilityDropMax { get; set; }

        [Order(53)] public int DecomposePrice { get; set; }

        [Order(54)] public int DecomposeTime { get; set; }

        [Order(55)] public uint ElementId { get; set; }

        [Order(56)] public int ElementNum { get; set; }

        [Order(57)] public uint IdDropAfterDamaged { get; set; }

        [Order(58)] public int NumDropAfterDamaged { get; set; }

        [Order(59)] public int PileNumMax { get; set; }

        [Order(60)] public uint HasGuid { get; set; }

        [Order(61)] public uint ProcType { get; set; }
    }

    [Order(4)]
    public class ArmorMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(5)]
    public class ArmorSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint EquipMask { get; set; }
    }

    [Order(6)]
    public class ArmorEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(32)] public string Realname { get; set; }

        [Order(5)] [Size(128)] public string FileMatter { get; set; }

        [Order(6)] [Size(128)] public string FileIcon { get; set; }

        [Order(7)] public uint EquipLocation { get; set; }

        [Order(8)] public int Level { get; set; }

        [Order(9)] public int RequireStrength { get; set; }

        [Order(10)] public int RequireAgility { get; set; }

        [Order(11)] public int RequireEnergy { get; set; }

        [Order(12)] public int RequireTili { get; set; }

        [Order(13)] public uint CharacterComboId { get; set; }

        [Order(14)] public int RequireLevel { get; set; }

        [Order(15)] public int RequireReputation { get; set; }

        [Order(16)] public int FixedProps { get; set; }

        [Order(17)] public int DefenceLow { get; set; }

        [Order(18)] public int DefenceHigh { get; set; }

        [Order(19)] [Size(5)] public MagicDefences[] MagicDefences { get; set; }

        [Order(20)] public int MpEnhanceLow { get; set; }

        [Order(21)] public int MpEnhanceHigh { get; set; }

        [Order(22)] public int HpEnhanceLow { get; set; }

        [Order(23)] public int HpEnhanceHigh { get; set; }

        [Order(24)] public int ArmorEnhanceLow { get; set; }

        [Order(25)] public int ArmorEnhanceHigh { get; set; }

        [Order(26)] public int DurabilityMin { get; set; }

        [Order(27)] public int DurabilityMax { get; set; }

        [Order(28)] public int LevelupAddon { get; set; }

        [Order(29)] public int MaterialNeed { get; set; }

        [Order(30)] public int Price { get; set; }

        [Order(31)] public int ShopPrice { get; set; }

        [Order(32)] public int Repairfee { get; set; }

        [Order(33)] public float DropProbabilitySocket0 { get; set; }

        [Order(34)] public float DropProbabilitySocket1 { get; set; }

        [Order(35)] public float DropProbabilitySocket2 { get; set; }

        [Order(36)] public float DropProbabilitySocket3 { get; set; }

        [Order(37)] public float DropProbabilitySocket4 { get; set; }

        [Order(38)] public float MakeProbabilitySocket0 { get; set; }

        [Order(39)] public float MakeProbabilitySocket1 { get; set; }

        [Order(40)] public float MakeProbabilitySocket2 { get; set; }

        [Order(41)] public float MakeProbabilitySocket3 { get; set; }

        [Order(42)] public float MakeProbabilitySocket4 { get; set; }

        [Order(43)] public float ProbabilityAddonNum0 { get; set; }

        [Order(44)] public float ProbabilityAddonNum1 { get; set; }

        [Order(45)] public float ProbabilityAddonNum2 { get; set; }

        [Order(46)] public float ProbabilityAddonNum3 { get; set; }

        [Order(47)] public float ProbabilityAddonNum4 { get; set; }

        [Order(48)] [Size(32)] public Probability[] Addons { get; set; }

        [Order(49)] [Size(32)] public Probability[] Rands { get; set; }

        [Order(50)] public int DurabilityDropMin { get; set; }

        [Order(51)] public int DurabilityDropMax { get; set; }

        [Order(52)] public int DecomposePrice { get; set; }

        [Order(53)] public int DecomposeTime { get; set; }

        [Order(54)] public uint ElementId { get; set; }

        [Order(55)] public int ElementNum { get; set; }

        [Order(56)] public uint IdDropAfterDamaged { get; set; }

        [Order(57)] public int NumDropAfterDamaged { get; set; }

        [Order(58)] public uint IdHair { get; set; }

        [Order(59)] public uint IdHairTexture { get; set; }

        [Order(60)] public int PileNumMax { get; set; }

        [Order(61)] public uint HasGuid { get; set; }

        [Order(62)] public uint ProcType { get; set; }

        [Order(63)] public uint ForceAllMagicDefences { get; set; }
    }

    [Order(7)]
    public class DecorationMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(8)]
    public class DecorationSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint EquipMask { get; set; }
    }

    [Order(9)]
    public class DecorationEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(128)] public string FileModel { get; set; }

        [Order(5)] [Size(128)] public string FileMatter { get; set; }

        [Order(6)] [Size(128)] public string FileIcon { get; set; }

        [Order(7)] public int Level { get; set; }

        [Order(8)] public int RequireStrength { get; set; }

        [Order(9)] public int RequireAgility { get; set; }

        [Order(10)] public int RequireEnergy { get; set; }

        [Order(11)] public int RequireTili { get; set; }

        [Order(12)] public uint CharacterComboId { get; set; }

        [Order(13)] public int RequireLevel { get; set; }

        [Order(14)] public int RequireReputation { get; set; }

        [Order(15)] public int FixedProps { get; set; }

        [Order(16)] public int DamageLow { get; set; }

        [Order(17)] public int DamageHigh { get; set; }

        [Order(18)] public int MagicDamageLow { get; set; }

        [Order(19)] public int MagicDamageHigh { get; set; }

        [Order(20)] public int DefenceLow { get; set; }

        [Order(21)] public int DefenceHigh { get; set; }

        [Order(22)] [Size(5)] public MagicDefences[] MagicDefences { get; set; }

        [Order(23)] public int ArmorEnhanceLow { get; set; }

        [Order(24)] public int ArmorEnhanceHigh { get; set; }

        [Order(25)] public int DurabilityMin { get; set; }

        [Order(26)] public int DurabilityMax { get; set; }

        [Order(27)] public int LevelupAddon { get; set; }

        [Order(28)] public int MaterialNeed { get; set; }

        [Order(29)] public int Price { get; set; }

        [Order(30)] public int ShopPrice { get; set; }

        [Order(31)] public int Repairfee { get; set; }

        [Order(32)] public float ProbabilityAddonNum0 { get; set; }

        [Order(33)] public float ProbabilityAddonNum1 { get; set; }

        [Order(34)] public float ProbabilityAddonNum2 { get; set; }

        [Order(35)] public float ProbabilityAddonNum3 { get; set; }

        [Order(36)] public float ProbabilityAddonNum4 { get; set; }

        [Order(37)] [Size(32)] public Probability[] Addons { get; set; }

        [Order(38)] [Size(32)] public Probability[] Rands { get; set; }

        [Order(39)] public int DurabilityDropMin { get; set; }

        [Order(40)] public int DurabilityDropMax { get; set; }

        [Order(41)] public int DecomposePrice { get; set; }

        [Order(42)] public int DecomposeTime { get; set; }

        [Order(43)] public uint ElementId { get; set; }

        [Order(44)] public int ElementNum { get; set; }

        [Order(45)] public uint IdDropAfterDamaged { get; set; }

        [Order(46)] public int NumDropAfterDamaged { get; set; }

        [Order(47)] public int PileNumMax { get; set; }

        [Order(48)] public uint HasGuid { get; set; }

        [Order(49)] public uint ProcType { get; set; }
    }

    [Order(10)]
    public class MedicineMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(11)]
    public class MedicineSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(12)]
    public class MedicineEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(128)] public string FileMatter { get; set; }

        [Order(5)] [Size(128)] public string FileIcon { get; set; }

        [Order(6)] public int RequireLevel { get; set; }

        [Order(7)] public int CoolTime { get; set; }

        [Order(8)] public int HpAddTotal { get; set; }

        [Order(9)] public int HpAddTime { get; set; }

        [Order(10)] public int MpAddTotal { get; set; }

        [Order(11)] public int MpAddTime { get; set; }

        [Order(12)] public int Price { get; set; }

        [Order(13)] public int ShopPrice { get; set; }

        [Order(14)] public int PileNumMax { get; set; }

        [Order(15)] public uint HasGuid { get; set; }

        [Order(16)] public uint ProcType { get; set; }
    }

    [Order(13)]
    public class MaterialMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(14)]
    public class MaterialSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(15)]
    public class MaterialEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(128)] public string FileMatter { get; set; }

        [Order(5)] [Size(128)] public string FileIcon { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int DecomposePrice { get; set; }

        [Order(9)] public int DecomposeTime { get; set; }

        [Order(10)] public uint ElementId { get; set; }

        [Order(11)] public int ElementNum { get; set; }

        [Order(12)] public int PileNumMax { get; set; }

        [Order(13)] public uint HasGuid { get; set; }

        [Order(14)] public uint ProcType { get; set; }
    }

    [Order(16)]
    public class DamageruneSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(17)]
    public class DamageruneEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public uint DamageType { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int RequireWeaponLevelMin { get; set; }

        [Order(9)] public int RequireWeaponLevelMax { get; set; }

        [Order(10)] public int DamageIncreased { get; set; }

        [Order(11)] public int PileNumMax { get; set; }

        [Order(12)] public uint HasGuid { get; set; }

        [Order(13)] public uint ProcType { get; set; }
    }

    [Order(18)]
    public class ArmorruneSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(19)]
    public class ArmorruneEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] [Size(128)] public string FileGfx { get; set; }

        [Order(6)] [Size(128)] public string FileSfx { get; set; }

        [Order(7)] public uint DamageType { get; set; }

        [Order(8)] public int Price { get; set; }

        [Order(9)] public int ShopPrice { get; set; }

        [Order(10)] public int RequirePlayerLevelMin { get; set; }

        [Order(11)] public int RequirePlayerLevelMax { get; set; }

        [Order(12)] public float DamageReducePercent { get; set; }

        [Order(13)] public int DamageReduceTime { get; set; }

        [Order(14)] public int PileNumMax { get; set; }

        [Order(15)] public uint HasGuid { get; set; }

        [Order(16)] public uint ProcType { get; set; }
    }

    [Order(20)]
    public class SkilltomeSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(21)]
    public class SkilltomeEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(22)]
    public class FlyswordEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileModel { get; set; }

        [Order(3)] [Size(128)] public string FileModel2 { get; set; }

        [Order(4)] [Size(128)] public string FileMatter { get; set; }

        [Order(5)] [Size(128)] public string FileIcon { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int Level { get; set; }

        [Order(9)] public int RequirePlayerLevelMin { get; set; }

        [Order(10)] public float SpeedIncreaseMin { get; set; }

        [Order(11)] public float SpeedIncreaseMax { get; set; }

        [Order(12)] public float SpeedRushIncreaseMin { get; set; }

        [Order(13)] public float SpeedRushIncreaseMax { get; set; }

        [Order(14)] public float TimeMaxMin { get; set; }

        [Order(15)] public float TimeMaxMax { get; set; }

        [Order(16)] public float TimeIncreasePerElement { get; set; }

        [Order(17)] public uint FlyMode { get; set; }

        [Order(18)] public uint CharacterComboId { get; set; }

        [Order(19)] public uint IdDropAfterDamaged { get; set; }

        [Order(20)] public int NumDropAfterDamaged { get; set; }

        [Order(21)] public int MaxImproveLevel { get; set; }

        [Order(22)] [Size(10)] public ImproveConfigClass[] ImproveConfig { get; set; }

        [Order(23)] public int PileNumMax { get; set; }

        [Order(24)] public uint HasGuid { get; set; }

        [Order(25)] public uint ProcType { get; set; }

        public class ImproveConfigClass
        {
            [Order(0)] public uint RequireItemNum { get; set; }

            [Order(1)] public float SpeedIncrease { get; set; }

            [Order(2)] public float SpeedRushIncrease { get; set; }
        }
    }

    [Order(23)]
    public class WingmanwingEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileModel { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int RequirePlayerLevelMin { get; set; }

        [Order(8)] public float SpeedIncrease { get; set; }

        [Order(9)] public int MpLaunch { get; set; }

        [Order(10)] public int MpPerSecond { get; set; }

        [Order(11)] public int PileNumMax { get; set; }

        [Order(12)] public uint HasGuid { get; set; }

        [Order(13)] public uint ProcType { get; set; }
    }

    [Order(24)]
    public class TownscrollEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public float UseTime { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(25)]
    public class UnionscrollEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public float UseTime { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(26)]
    public class RevivescrollEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public float UseTime { get; set; }

        [Order(5)] public int CoolTime { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int PileNumMax { get; set; }

        [Order(9)] public uint HasGuid { get; set; }

        [Order(10)] public uint ProcType { get; set; }
    }

    [Order(27)]
    public class ElementEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Level { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(28)]
    public class TaskmatterEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileIcon { get; set; }

        [Order(3)] public int PileNumMax { get; set; }

        [Order(4)] public uint HasGuid { get; set; }

        [Order(5)] public uint ProcType { get; set; }
    }

    [Order(29)]
    public class TossmatterEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileModel { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] [Size(128)] public string FileFiregfx { get; set; }

        [Order(6)] [Size(128)] public string FileHitgfx { get; set; }

        [Order(7)] [Size(128)] public string FileHitsfx { get; set; }

        [Order(8)] public int RequireStrength { get; set; }

        [Order(9)] public int RequireAgility { get; set; }

        [Order(10)] public int RequireLevel { get; set; }

        [Order(11)] public int DamageLow { get; set; }

        [Order(12)] public int DamageHighMin { get; set; }

        [Order(13)] public int DamageHighMax { get; set; }

        [Order(14)] public float UseTime { get; set; }

        [Order(15)] public float AttackRange { get; set; }

        [Order(16)] public int Price { get; set; }

        [Order(17)] public int ShopPrice { get; set; }

        [Order(18)] public int PileNumMax { get; set; }

        [Order(19)] public uint HasGuid { get; set; }

        [Order(20)] public uint ProcType { get; set; }
    }

    [Order(30)]
    public class ProjectileType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(31)]
    public class ProjectileEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint Type { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileModel { get; set; }

        [Order(4)] [Size(128)] public string FileMatter { get; set; }

        [Order(5)] [Size(128)] public string FileIcon { get; set; }

        [Order(6)] [Size(128)] public string FileFiregfx { get; set; }

        [Order(7)] [Size(128)] public string FileHitgfx { get; set; }

        [Order(8)] [Size(128)] public string FileHitsfx { get; set; }

        [Order(9)] public int RequireWeaponLevelMin { get; set; }

        [Order(10)] public int RequireWeaponLevelMax { get; set; }

        [Order(11)] public int DamageEnhance { get; set; }

        [Order(12)] public int DamageScaleEnhance { get; set; }

        [Order(13)] public int Price { get; set; }

        [Order(14)] public int ShopPrice { get; set; }

        [Order(15)] public uint IdAddon0 { get; set; }

        [Order(16)] public uint IdAddon1 { get; set; }

        [Order(17)] public uint IdAddon2 { get; set; }

        [Order(18)] public uint IdAddon3 { get; set; }

        [Order(19)] public int PileNumMax { get; set; }

        [Order(20)] public uint HasGuid { get; set; }

        [Order(21)] public uint ProcType { get; set; }
    }

    [Order(32)]
    public class QuiverSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(33)]
    public class QuiverEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public uint IdProjectile { get; set; }

        [Order(6)] public int NumMin { get; set; }

        [Order(7)] public int NumMax { get; set; }
    }

    [Order(34)]
    public class StoneSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(35)]
    public class StoneEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public int Level { get; set; }

        [Order(6)] public int Color { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int InstallPrice { get; set; }

        [Order(10)] public int UninstallPrice { get; set; }

        [Order(11)] public uint IdAddonDamage { get; set; }

        [Order(12)] public uint IdAddonDefence { get; set; }

        [Order(13)]
        [Size(16)]
        [NameString]
        public string WeaponDesc { get; set; }

        [Order(14)]
        [Size(16)]
        [NameString]
        public string ArmorDesc { get; set; }

        [Order(15)] public int PileNumMax { get; set; }

        [Order(16)] public uint HasGuid { get; set; }

        [Order(17)] public uint ProcType { get; set; }

        [Order(18)] public uint CombinedSwitch { get; set; }

        [Order(19)] public uint IdAddonDecoration { get; set; }

        [Order(20)]
        [Size(16)]
        [NameString]
        public string DecorationDesc { get; set; }
    }

    [Order(36)]
    public class MonsterAddon : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int NumParams { get; set; }

        [Order(3)] public int Param1 { get; set; }

        [Order(4)] public int Param2 { get; set; }

        [Order(5)] public int Param3 { get; set; }
    }

    [Order(37)]
    public class MonsterType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(16)] public Probability[] Addons { get; set; }
    }

    [Order(38)]
    public class MonsterEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(16)]
        [NameString]
        public string Prop { get; set; }

        [Order(4)]
        [Size(16)]
        [NameString]
        public string Desc { get; set; }

        [Order(5)] public uint Faction { get; set; }

        [Order(6)] public uint MonsterFaction { get; set; }

        [Order(7)] [Size(128)] public string FileModel { get; set; }

        [Order(8)] [Size(128)] public string FileGfxShort { get; set; }

        [Order(9)] [Size(128)] public string FileGfxShortHit { get; set; }

        [Order(10)] public float Size { get; set; }

        [Order(11)] public float DamageDelay { get; set; }

        [Order(12)] public uint IdStrategy { get; set; }

        [Order(13)] public uint RoleInWar { get; set; }

        [Order(14)] public int Level { get; set; }

        [Order(15)] public int ShowLevel { get; set; }

        [Order(16)] public uint IdPetEggCaptured { get; set; }

        [Order(17)] public int Life { get; set; }

        [Order(18)] public int Defence { get; set; }

        [Order(19)] [Size(5)] public int[] MagicDefences { get; set; }

        [Order(20)] public uint ImmuneType { get; set; }

        [Order(21)] public int Exp { get; set; }

        [Order(22)] public int Skillpoint { get; set; }

        [Order(23)] public int MoneyAverage { get; set; }

        [Order(24)] public int MoneyVar { get; set; }

        [Order(25)] public uint ShortRangeMode { get; set; }

        [Order(26)] public int SightRange { get; set; }

        [Order(27)] public int Attack { get; set; }

        [Order(28)] public int Armor { get; set; }

        [Order(29)] public int DamageMin { get; set; }

        [Order(30)] public int DamageMax { get; set; }

        [Order(31)] [Size(5)] public MagicDamagesExtClass[] MagicDamagesExt { get; set; }

        [Order(32)] public float AttackRange { get; set; }

        [Order(33)] public float AttackSpeed { get; set; }

        [Order(34)] public int MagicDamageMin { get; set; }

        [Order(35)] public int MagicDamageMax { get; set; }

        [Order(36)] public uint IdSkill { get; set; }

        [Order(37)] public int SkillLevel { get; set; }

        [Order(38)] public int HpRegenerate { get; set; }

        [Order(39)] public uint AggressiveMode { get; set; }

        [Order(40)] public uint MonsterFactionAskHelp { get; set; }

        [Order(41)] public uint MonsterFactionCanHelp { get; set; }

        [Order(42)] public float AggroRange { get; set; }

        [Order(43)] public float AggroTime { get; set; }

        [Order(44)] public uint InhabitType { get; set; }

        [Order(45)] public uint PatrollMode { get; set; }

        [Order(46)] public uint StandMode { get; set; }

        [Order(47)] public float WalkSpeed { get; set; }

        [Order(48)] public float RunSpeed { get; set; }

        [Order(49)] public float FlySpeed { get; set; }

        [Order(50)] public float SwimSpeed { get; set; }

        [Order(51)] public int AttackDegree { get; set; }

        [Order(52)] public int DefendDegree { get; set; }

        [Order(53)] public uint CommonStrategy { get; set; }

        [Order(54)] [Size(4)] public Probability[] AggroStrategy { get; set; }

        [Order(55)] [Size(5)] public SkillHp25Class[] SkillHp75 { get; set; }

        [Order(56)] [Size(5)] public SkillHp25Class[] SkillHp50 { get; set; }

        [Order(57)] [Size(5)] public SkillHp25Class[] SkillHp25 { get; set; }

        [Order(58)] public uint AfterDeath { get; set; }

        [Order(59)] [Size(32)] public Skill[] Skills { get; set; }

        [Order(60)] public float ProbabilityDropNum0 { get; set; }

        [Order(61)] public float ProbabilityDropNum1 { get; set; }

        [Order(62)] public float ProbabilityDropNum2 { get; set; }

        [Order(63)] public float ProbabilityDropNum3 { get; set; }

        [Order(64)] public int DropTimes { get; set; }

        [Order(65)] public int DropProtected { get; set; }

        [Order(66)] [Size(32)] public Probability[] DropMatters { get; set; }

        [Order(67)] public uint HighestFrequency { get; set; }

        [Order(68)] public int NoAcceptPlayerBuff { get; set; }

        [Order(69)] public int InvisibleLvl { get; set; }

        [Order(70)] public int UninvisibleLvl { get; set; }

        [Order(71)] public int NoAutoFight { get; set; }

        [Order(72)] public int FixedDirection { get; set; }

        [Order(73)] public uint IdBuilding { get; set; }

        [Order(74)] public uint CombinedSwitch { get; set; }

        [Order(75)] public int HpAdjustCommonValue { get; set; }

        [Order(76)] public int DefenceAdjustCommonValue { get; set; }

        [Order(77)] public int AttackAdjustCommonValue { get; set; }

        [Order(78)] public float MaxMoveRange { get; set; }

        [Order(79)] public uint DropForNoProfitTime { get; set; }

        [Order(80)] public int DropMineConditionFlag { get; set; }

        [Order(81)] public float DropMineProbability { get; set; }

        [Order(82)] [Size(4)] public DropMinesClass[] DropMines { get; set; }

        [Order(83)]
        [Size(16)]
        [NameString]
        public string Label { get; set; }

        [Order(84)] public uint DomainRelated { get; set; }

        [Order(85)] [Size(3)] public int[] LocalVar { get; set; }

        public class MagicDamagesExtClass
        {
            [Order(0)] public int DamageMin { get; set; }

            [Order(1)] public int DamageMax { get; set; }
        }

        public class SkillHp75Class
        {
            [Order(0)] public uint IdSkill { get; set; }

            [Order(1)] public int Level { get; set; }

            [Order(2)] public float Probability { get; set; }
        }

        public class SkillHp50Class
        {
            [Order(0)] public uint IdSkill { get; set; }

            [Order(1)] public int Level { get; set; }

            [Order(2)] public float Probability { get; set; }
        }

        public class SkillHp25Class
        {
            [Order(0)] public uint IdSkill { get; set; }

            [Order(1)] public int Level { get; set; }

            [Order(2)] public float Probability { get; set; }
        }

        public class DropMinesClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public float Probability { get; set; }

            [Order(2)] public int Life { get; set; }
        }
    }

    [Order(39)]
    public class NpcTalkService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint IdDialog { get; set; }
    }

    [Order(40)]
    public class NpcSellService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(8)] public PagesClass[] Pages { get; set; }

        [Order(3)] public uint IdDialog { get; set; }

        public class PagesClass
        {
            [Order(0)]
            [Size(8)]
            [NameString]
            public string PageTitle { get; set; }

            [Order(1)] public int RequireContrib { get; set; }

            [Order(2)] public uint RequireForce { get; set; }

            [Order(3)] public int RequireForceReputation { get; set; }

            [Order(4)] [Size(32)] public GoodsClass[] Goods { get; set; }

            public class GoodsClass
            {
                [Order(0)] public uint Id { get; set; }

                [Order(1)] public int ContribCost { get; set; }

                [Order(2)] public int ForceContributionCost { get; set; }

                [Order(3)] public int SoloTowerChallengeScoreCost { get; set; }
            }
        }
    }

    [Order(41)]
    public class NpcBuyService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint IdDialog { get; set; }
    }

    [Order(42)]
    public class NpcRepairService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint IdDialog { get; set; }
    }

    [Order(43)]
    public class NpcInstallService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(32)] public uint[] IdGoods { get; set; }

        [Order(3)] public uint IdDialog { get; set; }
    }

    [Order(44)]
    public class NpcUninstallService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(32)] public uint[] IdGoods { get; set; }

        [Order(3)] public uint IdDialog { get; set; }
    }

    [Order(45)]
    public class NpcTaskInService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(256)] public uint[] IdTasks { get; set; }
    }

    [Order(46)]
    public class NpcTaskOutService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint StorageId { get; set; }

        [Order(3)] public uint StorageOpenItem { get; set; }

        [Order(4)] public uint StorageRefreshItem { get; set; }

        [Order(5)] public int StorageRefreshPerDay { get; set; }

        [Order(6)] public int StorageRefreshCountMin { get; set; }

        [Order(7)] public int StorageRefreshCountMax { get; set; }

        [Order(8)] public int StorageDeliverPerDay { get; set; }

        [Order(9)] [Size(256)] public uint[] IdTasks { get; set; }

        [Order(10)] public uint StorageRefreshOnCrossserver { get; set; }
    }

    [Order(47)]
    public class NpcTaskMatterService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(16)] public TasksClass[] Tasks { get; set; }

        public class TasksClass
        {
            [Order(0)] public uint IdTask { get; set; }

            [Order(1)] [Size(4)] public TaksMattersClass[] TaksMatters { get; set; }

            public class TaksMattersClass
            {
                [Order(0)] public uint IdMatter { get; set; }

                [Order(1)] public int NumMatter { get; set; }
            }
        }
    }

    [Order(48)]
    public class NpcSkillService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(256)] public uint[] IdSkills { get; set; }

        [Order(3)] public uint IdDialog { get; set; }
    }

    [Order(49)]
    public class NpcHealService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint IdDialog { get; set; }
    }

    [Order(50)]
    public class NpcTransmitService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int NumTargets { get; set; }

        [Order(3)] [Size(32)] public TargetsClass[] Targets { get; set; }

        [Order(4)] public uint IdDialog { get; set; }

        public class TargetsClass
        {
            [Order(0)] public int Idtarget { get; set; }

            [Order(1)] public int Fee { get; set; }

            [Order(2)] public int RequiredLevel { get; set; }
        }
    }

    [Order(51)]
    public class NpcTransportService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(32)] public RoutesClass[] Routes { get; set; }

        [Order(3)] public uint IdDialog { get; set; }

        public class RoutesClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public uint Fee { get; set; }
        }
    }

    [Order(52)]
    public class NpcProxyService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint IdDialog { get; set; }
    }

    [Order(53)]
    public class NpcStorageService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(54)]
    public class NpcMakeService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint IdMakeSkill { get; set; }

        [Order(3)] public int ProduceType { get; set; }

        [Order(4)] [Size(8)] public PagesClass[] Pages { get; set; }

        public class PagesClass
        {
            [Order(0)]
            [Size(8)]
            [NameString]
            public string PageTitle { get; set; }

            [Order(1)] [Size(32)] public uint[] IdGoods { get; set; }
        }
    }

    [Order(55)]
    public class NpcDecomposeService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint IdDecomposeSkill { get; set; }
    }

    [Order(56)]
    public class NpcType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(57)]
    public class NpcEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint IdType { get; set; }

        [Order(3)] public float RefreshTime { get; set; }

        [Order(4)] public uint AttackRule { get; set; }

        [Order(5)] [Size(128)] public string FileModel { get; set; }

        [Order(6)] public float TaxRate { get; set; }

        [Order(7)] public uint IdSrcMonster { get; set; }

        [Order(8)]
        [Size(256)]
        [NameString]
        public string HelloMsg { get; set; }

        [Order(9)] public uint IdToDiscover { get; set; }

        [Order(10)] public uint DomainRelated { get; set; }

        [Order(11)] public uint IdTalkService { get; set; }

        [Order(12)] public uint IdSellService { get; set; }

        [Order(13)] public uint IdBuyService { get; set; }

        [Order(14)] public uint IdRepairService { get; set; }

        [Order(15)] public uint IdInstallService { get; set; }

        [Order(16)] public uint IdUninstallService { get; set; }

        [Order(17)] public uint IdTaskOutService { get; set; }

        [Order(18)] public uint IdTaskInService { get; set; }

        [Order(19)] public uint IdTaskMatterService { get; set; }

        [Order(20)] public uint IdSkillService { get; set; }

        [Order(21)] public uint IdHealService { get; set; }

        [Order(22)] public uint IdTransmitService { get; set; }

        [Order(23)] public uint IdTransportService { get; set; }

        [Order(24)] public uint IdProxyService { get; set; }

        [Order(25)] public uint IdStorageService { get; set; }

        [Order(26)] public uint IdMakeService { get; set; }

        [Order(27)] public uint IdDecomposeService { get; set; }

        [Order(28)] public uint IdIdentifyService { get; set; }

        [Order(29)] public uint IdWarTowerbuildService { get; set; }

        [Order(30)] public uint IdResetpropService { get; set; }

        [Order(31)] public uint IdPetnameService { get; set; }

        [Order(32)] public uint IdPetlearnskillService { get; set; }

        [Order(33)] public uint IdPetforgetskillService { get; set; }

        [Order(34)] public uint IdEquipbindService { get; set; }

        [Order(35)] public uint IdEquipdestroyService { get; set; }

        [Order(36)] public uint IdEquipundestroyService { get; set; }

        [Order(37)] public uint IdGoblinSkillService { get; set; }

        [Order(38)] public uint IdCrossServerService { get; set; }

        [Order(39)] public uint CombinedServices { get; set; }

        [Order(40)] public uint IdMine { get; set; }

        [Order(41)] public uint NoCollision { get; set; }

        [Order(42)] public uint IdEngraveService { get; set; }

        [Order(43)] public uint IdRandpropService { get; set; }

        [Order(44)] public uint CombinedServices2 { get; set; }

        [Order(45)] public uint IdForceService { get; set; }

        [Order(46)] public uint CombinedSwitch { get; set; }
    }

    [Order(58)]
    public class FaceTextureEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileBaseTex { get; set; }

        [Order(3)] [Size(128)] public string FileHighTex { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public uint TexPartId { get; set; }

        [Order(6)] public uint CharacterComboId { get; set; }

        [Order(7)] public uint GenderId { get; set; }

        [Order(8)] public uint VisualizeId { get; set; }

        [Order(9)] public uint UserData { get; set; }

        [Order(10)] public uint FacepillOnly { get; set; }

        [Order(11)] public uint FashionHeadOnly { get; set; }
    }

    [Order(59)]
    public class FaceShapeEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileShape { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint ShapePartId { get; set; }

        [Order(5)] public uint CharacterComboId { get; set; }

        [Order(6)] public uint GenderId { get; set; }

        [Order(7)] public uint VisualizeId { get; set; }

        [Order(8)] public uint UserData { get; set; }

        [Order(9)] public uint FacepillOnly { get; set; }
    }

    [Order(60)]
    public class FaceEmotionType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileIcon { get; set; }
    }

    [Order(61)]
    public class FaceExpressionEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileExpression { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint CharacterComboId { get; set; }

        [Order(5)] public uint GenderId { get; set; }

        [Order(6)] public uint EmotionId { get; set; }
    }

    [Order(62)]
    public class FaceHairEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileHairSkin { get; set; }

        [Order(3)] [Size(128)] public string FileHairModel { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public uint CharacterComboId { get; set; }

        [Order(6)] public uint GenderId { get; set; }

        [Order(7)] public uint VisualizeId { get; set; }

        [Order(8)] public uint FacepillOnly { get; set; }

        [Order(9)] public uint FashionHeadOnly { get; set; }
    }

    [Order(63)]
    public class FaceMoustacheEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMoustacheSkin { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint CharacterComboId { get; set; }

        [Order(5)] public uint GenderId { get; set; }

        [Order(6)] public uint VisualizeId { get; set; }

        [Order(7)] public uint FacepillOnly { get; set; }
    }

    [Order(64)]
    public class ColorpickerEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileColorpicker { get; set; }

        [Order(3)] public uint ColorPartId { get; set; }

        [Order(4)] public uint CharacterComboId { get; set; }

        [Order(5)] public uint GenderId { get; set; }
    }

    [Order(65)]
    public class CustomizedataEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileData { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint CharacterComboId { get; set; }

        [Order(5)] public uint GenderId { get; set; }
    }

    [Order(66)]
    public class RecipeMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(67)]
    public class RecipeSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(68)]
    public class RecipeEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] public int RecipeLevel { get; set; }

        [Order(5)] public uint IdSkill { get; set; }

        [Order(6)] public int SkillLevel { get; set; }

        [Order(7)] public int BindType { get; set; }

        [Order(8)] [Size(4)] public Probability[] Targets { get; set; }

        [Order(9)] public float FailProbability { get; set; }

        [Order(10)] public int NumToMake { get; set; }

        [Order(11)] public int Price { get; set; }

        [Order(12)] public float Duration { get; set; }

        [Order(13)] public int Exp { get; set; }

        [Order(14)] public int Skillpoint { get; set; }

        [Order(15)] [Size(32)] public MaterialsClass[] Materials { get; set; }

        [Order(16)] public uint IdUpgradeEquip { get; set; }

        [Order(17)] public float UpgradeRate { get; set; }

        [Order(18)] public uint ProcType { get; set; }

        [Order(19)] public uint CharacterComboId { get; set; }

        [Order(20)] public float EngraveUpgradeRate { get; set; }

        [Order(21)] public float AddonInheritFeeRate { get; set; }

        public class MaterialsClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public int Num { get; set; }
        }
    }

    [Order(69)]
    public class EnemyFactionConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(32)] public uint[] EnemyFactions { get; set; }
    }

    [Order(70)]
    public class CharracterClassConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint CharacterClassId { get; set; }

        [Order(3)] public uint Faction { get; set; }

        [Order(4)] public uint EnemyFaction { get; set; }

        [Order(5)] public float AttackSpeed { get; set; }

        [Order(6)] public float AttackRange { get; set; }

        [Order(7)] public int HpGen { get; set; }

        [Order(8)] public int MpGen { get; set; }

        [Order(9)] public float WalkSpeed { get; set; }

        [Order(10)] public float RunSpeed { get; set; }

        [Order(11)] public float SwimSpeed { get; set; }

        [Order(12)] public float FlySpeed { get; set; }

        [Order(13)] public int CritRate { get; set; }

        [Order(14)] public int VitHp { get; set; }

        [Order(15)] public int EngMp { get; set; }

        [Order(16)] public int AgiAttack { get; set; }

        [Order(17)] public int AgiArmor { get; set; }

        [Order(18)] public int LvlupHp { get; set; }

        [Order(19)] public int LvlupMp { get; set; }

        [Order(20)] public float LvlupDmg { get; set; }

        [Order(21)] public float LvlupMagic { get; set; }

        [Order(22)] public float LvlupDefense { get; set; }

        [Order(23)] public float LvlupMagicdefence { get; set; }

        [Order(24)] public int AngroIncrease { get; set; }

        [Order(25)] [Size(6)] public float[] SpiritAdjust { get; set; }

        [Order(26)] [Size(6)] public float[] PokerAdjust { get; set; }
    }

    [Order(71)]
    public class ParamAdjustConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(16)] public LevelDiffAdjustClass[] LevelDiffAdjust { get; set; }

        [Order(3)] [Size(11)] public TeamProfessionAdjustClass[] TeamAdjust { get; set; }

        [Order(4)] [Size(11)] public TeamProfessionAdjustClass[] TeamProfessionAdjust { get; set; }

        [Order(5)] public float DmgAdjToSpecAtkSpeed { get; set; }

        [Order(6)] public float AtkRateAdjToSpecAtkSpeed { get; set; }

        [Order(7)] [Size(10)] public float[] UseMonsterSpiritAdjust { get; set; }

        public class LevelDiffAdjustClass
        {
            [Order(0)] public int LevelDiff { get; set; }

            [Order(1)] public float AdjustExp { get; set; }

            [Order(2)] public float AdjustSp { get; set; }

            [Order(3)] public float AdjustMoney { get; set; }

            [Order(4)] public float AdjustMatter { get; set; }

            [Order(5)] public float AdjustAttack { get; set; }
        }

        public class TeamAdjustClass
        {
            [Order(0)] public float AdjustExp { get; set; }

            [Order(1)] public float AdjustSp { get; set; }
        }

        public class TeamProfessionAdjustClass
        {
            [Order(0)] public float AdjustExp { get; set; }

            [Order(1)] public float AdjustSp { get; set; }
        }
    }

    [Order(72)]
    public class PlayerActionInfoConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(32)] public string ActionName { get; set; }

        [Order(3)] [Size(32)] public string ActionPrefix { get; set; }

        [Order(4)] [Size(15)] public ActionWeaponSuffixClass[] ActionWeaponSuffix { get; set; }

        [Order(5)] public uint HideWeapon { get; set; }

        public class ActionWeaponSuffixClass
        {
            [Order(0)] [Size(32)] public string Suffix { get; set; }
        }
    }

    [Order(73)]
    public class TaskdiceEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] [Size(20)] public Probability[] TaskLists { get; set; }

        [Order(5)] public uint UseOnPick { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int PileNumMax { get; set; }

        [Order(9)] public uint HasGuid { get; set; }

        [Order(10)] public uint ProcType { get; set; }

        [Order(11)] public int NoUseInCombat { get; set; }
    }

    [Order(74)]
    public class TasknormalmatterEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int ShopPrice { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(75)]
    public class FaceFalingEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileFalingSkin { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint CharacterComboId { get; set; }

        [Order(5)] public uint GenderId { get; set; }

        [Order(6)] public uint VisualizeId { get; set; }

        [Order(7)] public uint FacepillOnly { get; set; }
    }

    [Order(76)]
    public class PlayerLevelexpConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(150)] public int[] Exp { get; set; }
    }

    [Order(77)]
    public class MineType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(78)]
    public class MineEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] public uint Level { get; set; }

        [Order(4)] public uint LevelRequired { get; set; }

        [Order(5)] public uint IdEquipmentRequired { get; set; }

        [Order(6)] public uint EliminateTool { get; set; }

        [Order(7)] public uint TimeMin { get; set; }

        [Order(8)] public uint TimeMax { get; set; }

        [Order(9)] public int Exp { get; set; }

        [Order(10)] public int Skillpoint { get; set; }

        [Order(11)] [Size(128)] public string FileModel { get; set; }

        [Order(12)] [Size(16)] public MaterialsClass[] Materials { get; set; }

        [Order(13)] public int Num1 { get; set; }

        [Order(14)] public float Probability1 { get; set; }

        [Order(15)] public int Num2 { get; set; }

        [Order(16)] public float Probability2 { get; set; }

        [Order(17)] public uint TaskIn { get; set; }

        [Order(18)] public uint TaskOut { get; set; }

        [Order(19)] public uint Uninterruptable { get; set; }

        [Order(20)] [Size(4)] public NpcgenClass[] Npcgen { get; set; }

        [Order(21)] [Size(1)] public AggrosClass[] Aggros { get; set; }

        [Order(22)] public uint Permenent { get; set; }

        [Order(23)] public uint CombinedSwitch { get; set; }

        [Order(24)] public int MaxGatherer { get; set; }

        [Order(25)] public int MineType { get; set; }

        [Order(26)] public float GatherDist { get; set; }

        [Order(27)] public float MaterialGainRatio { get; set; }

        [Order(28)] public uint GatherStartActionConfig { get; set; }

        [Order(29)] public uint GatherLoopActionConfig { get; set; }

        public class MaterialsClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public float Probability { get; set; }

            [Order(2)] public int Life { get; set; }
        }

        public class NpcgenClass
        {
            [Order(0)] public uint IdMonster { get; set; }

            [Order(1)] public int Num { get; set; }

            [Order(2)] public float Radius { get; set; }

            [Order(3)] public int LifeTime { get; set; }
        }

        public class AggrosClass
        {
            [Order(0)] public uint MonsterFaction { get; set; }

            [Order(1)] public float Radius { get; set; }

            [Order(2)] public int Num { get; set; }
        }
    }

    [Order(79)]
    public class NpcIdentifyService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int Fee { get; set; }
    }

    [Order(80)]
    public class FashionMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(81)]
    public class FashionSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint EquipFashionMask { get; set; }
    }

    [Order(82)]
    public class FashionEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(32)] public string Realname { get; set; }

        [Order(5)] [Size(128)] public string FileMatter { get; set; }

        [Order(6)] [Size(128)] public string FileIcon { get; set; }

        [Order(7)] public uint EquipLocation { get; set; }

        [Order(8)] public int Level { get; set; }

        [Order(9)] public int RequireLevel { get; set; }

        [Order(10)] public int RequireDyeCount { get; set; }

        [Order(11)] public int Price { get; set; }

        [Order(12)] public int ShopPrice { get; set; }

        [Order(13)] public int Gender { get; set; }

        [Order(14)] public uint IdHair { get; set; }

        [Order(15)] public uint IdHairTexture { get; set; }

        [Order(16)] public int PileNumMax { get; set; }

        [Order(17)] public uint HasGuid { get; set; }

        [Order(18)] public uint ProcType { get; set; }

        [Order(19)] [Size(32)] public string WearAction { get; set; }

        [Order(20)] [Size(128)] public string FileModelRight { get; set; }

        [Order(21)] [Size(128)] public string FileModelLeft { get; set; }

        [Order(22)] public uint CharacterComboId { get; set; }

        [Order(23)] public uint ActionType { get; set; }

        [Order(24)] public uint CombinedSwitch { get; set; }

        [Order(25)] public float HMin { get; set; }

        [Order(26)] public float HMax { get; set; }

        [Order(27)] public float SMin { get; set; }

        [Order(28)] public float SMax { get; set; }

        [Order(29)] public float VMin { get; set; }

        [Order(30)] public float VMax { get; set; }
    }

    [Order(83)]
    public class FaceticketMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(84)]
    public class FaceticketSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(85)]
    public class FaceticketEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(128)] public string FileMatter { get; set; }

        [Order(5)] [Size(128)] public string FileIcon { get; set; }

        [Order(6)] public int RequireLevel { get; set; }

        [Order(7)] [Size(128)] public string BoundFile { get; set; }

        [Order(8)] public uint Unsymmetrical { get; set; }

        [Order(9)] public int Price { get; set; }

        [Order(10)] public int ShopPrice { get; set; }

        [Order(11)] public int PileNumMax { get; set; }

        [Order(12)] public uint HasGuid { get; set; }

        [Order(13)] public uint ProcType { get; set; }
    }

    [Order(86)]
    public class FacepillMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(87)]
    public class FacepillSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(88)]
    public class FacepillEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(128)] public string FileMatter { get; set; }

        [Order(5)] [Size(128)] public string FileIcon { get; set; }

        [Order(6)] public int Duration { get; set; }

        [Order(7)] public float CameraScale { get; set; }

        [Order(8)] public uint CharacterComboId { get; set; }

        [Order(9)] [Size(24)] public PllfilesClass[] Pllfiles { get; set; }

        [Order(10)] public int Price { get; set; }

        [Order(11)] public int ShopPrice { get; set; }

        [Order(12)] public int PileNumMax { get; set; }

        [Order(13)] public uint HasGuid { get; set; }

        [Order(14)] public uint ProcType { get; set; }

        public class PllfilesClass
        {
            [Order(0)] [Size(128)] public string File { get; set; }
        }
    }

    [Order(89)]
    public class SuiteEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int MaxEquips { get; set; }

        [Order(3)] [Size(12)] public uint[] Equipments { get; set; }

        [Order(4)] [Size(11)] public uint[] Addons { get; set; }

        [Order(5)] [Size(128)] public string FileGfx { get; set; }

        public class EquipmentsClass
        {
            [Order(0)] public uint Id { get; set; }
        }

        public class AddonsClass
        {
            [Order(0)] public uint Id { get; set; }
        }
    }

    [Order(90)]
    public class GmGeneratorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(91)]
    public class GmGeneratorEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public uint IdObject { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(92)]
    public class PetType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(93)]
    public class PetEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileModel { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public uint CharacterComboId { get; set; }

        [Order(6)] public int LevelMax { get; set; }

        [Order(7)] public int LevelRequire { get; set; }

        [Order(8)] public uint PetSndType { get; set; }

        [Order(9)] public float HpA { get; set; }

        [Order(10)] public float HpB { get; set; }

        [Order(11)] public float HpC { get; set; }

        [Order(12)] public float HpGenA { get; set; }

        [Order(13)] public float HpGenB { get; set; }

        [Order(14)] public float HpGenC { get; set; }

        [Order(15)] public float DamageA { get; set; }

        [Order(16)] public float DamageB { get; set; }

        [Order(17)] public float DamageC { get; set; }

        [Order(18)] public float DamageD { get; set; }

        [Order(19)] public float SpeedA { get; set; }

        [Order(20)] public float SpeedB { get; set; }

        [Order(21)] public float AttackA { get; set; }

        [Order(22)] public float AttackB { get; set; }

        [Order(23)] public float AttackC { get; set; }

        [Order(24)] public float ArmorA { get; set; }

        [Order(25)] public float ArmorB { get; set; }

        [Order(26)] public float ArmorC { get; set; }

        [Order(27)] public float PhysicDefenceA { get; set; }

        [Order(28)] public float PhysicDefenceB { get; set; }

        [Order(29)] public float PhysicDefenceC { get; set; }

        [Order(30)] public float PhysicDefenceD { get; set; }

        [Order(31)] public float MagicDefenceA { get; set; }

        [Order(32)] public float MagicDefenceB { get; set; }

        [Order(33)] public float MagicDefenceC { get; set; }

        [Order(34)] public float MagicDefenceD { get; set; }

        [Order(35)] public float MpA { get; set; }

        [Order(36)] public float MpGenA { get; set; }

        [Order(37)] public float AttackDegreeA { get; set; }

        [Order(38)] public float DefenceDegreeA { get; set; }

        [Order(39)] public float Size { get; set; }

        [Order(40)] public float DamageDelay { get; set; }

        [Order(41)] public float AttackRange { get; set; }

        [Order(42)] public float AttackSpeed { get; set; }

        [Order(43)] public int SightRange { get; set; }

        [Order(44)] public uint FoodMask { get; set; }

        [Order(45)] public uint InhabitType { get; set; }

        [Order(46)] public uint StandMode { get; set; }

        [Order(47)] public uint PlantGroup { get; set; }

        [Order(48)] public int GroupLimit { get; set; }

        [Order(49)] public uint ImmuneType { get; set; }

        [Order(50)] public int PlayerGainSkill { get; set; }

        [Order(51)] public int RequireDyeCount { get; set; }

        [Order(52)] public uint IdPetEggEvolved { get; set; }

        [Order(53)] public int CostIndex { get; set; }

        [Order(54)] public int HpInheritMaxRate { get; set; }

        [Order(55)] public int AttackInheritMaxRate { get; set; }

        [Order(56)] public int DefenceInheritMaxRate { get; set; }

        [Order(57)] public int AttackLevelInheritMaxRate { get; set; }

        [Order(58)] public int DefenceLevelInheritMaxRate { get; set; }

        [Order(59)] public int SpecificSkill { get; set; }

        [Order(60)] [Size(128)] public string FileGfxShort { get; set; }

        [Order(61)] public uint IdEvolvedSkillRand { get; set; }

        [Order(62)] public uint CombinedSwitch { get; set; }
    }

    [Order(94)]
    public class PetEggEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int IdPet { get; set; }

        [Order(5)] public int MoneyHatched { get; set; }

        [Order(6)] public int MoneyRestored { get; set; }

        [Order(7)] public int HonorPoint { get; set; }

        [Order(8)] public int Level { get; set; }

        [Order(9)] public int Exp { get; set; }

        [Order(10)] public int SkillPoint { get; set; }

        [Order(11)] [Size(32)] public Skill[] Skills { get; set; }

        [Order(12)] public int Price { get; set; }

        [Order(13)] public int ShopPrice { get; set; }

        [Order(14)] public int PileNumMax { get; set; }

        [Order(15)] public uint HasGuid { get; set; }

        [Order(16)] public uint ProcType { get; set; }
    }

    [Order(95)]
    public class PetFoodEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Level { get; set; }

        [Order(5)] public int Hornor { get; set; }

        [Order(6)] public int Exp { get; set; }

        [Order(7)] public int FoodType { get; set; }

        [Order(8)] public int Price { get; set; }

        [Order(9)] public int ShopPrice { get; set; }

        [Order(10)] public int PileNumMax { get; set; }

        [Order(11)] public uint HasGuid { get; set; }

        [Order(12)] public uint ProcType { get; set; }
    }

    [Order(96)]
    public class PetFaceticketEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int ShopPrice { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(97)]
    public class FireworksEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] [Size(128)] public string FileFw { get; set; }

        [Order(5)] public int Level { get; set; }

        [Order(6)] public int TimeToFire { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(98)]
    public class Fireworks2Essence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Level { get; set; }

        [Order(5)] public int TimeToFire { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int MaleMineId { get; set; }

        [Order(9)] public int FemaleMineId { get; set; }

        [Order(10)] [Size(32)] public string CastAction { get; set; }

        [Order(11)]
        [Size(256)]
        [NameString]
        public string CasterWord { get; set; }

        [Order(12)]
        [Size(256)]
        [NameString]
        public string ReceiverWord { get; set; }

        [Order(13)] public int PileNumMax { get; set; }

        [Order(14)] public uint HasGuid { get; set; }

        [Order(15)] public uint ProcType { get; set; }
    }

    [Order(99)]
    public class FixPositionTransmitEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Energy { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(100)]
    public class WarTankcallinEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int ShopPrice { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(101)]
    public class NpcWarTowerbuildService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(4)] public BuildInfoClass[] BuildInfo { get; set; }

        public class BuildInfoClass
        {
            [Order(0)] public int IdInBuild { get; set; }

            [Order(1)] public int IdBuildup { get; set; }

            [Order(2)] public int IdObjectNeed { get; set; }

            [Order(3)] public int TimeUse { get; set; }

            [Order(4)] public int Fee { get; set; }
        }
    }

    [Order(102)]
    public class PlayerSecondlevelConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(256)] public float[] ExpLost { get; set; }
    }

    [Order(103)]
    public class NpcResetpropService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(15)] public PropEntryClass[] PropEntry { get; set; }

        public class PropEntryClass
        {
            [Order(0)] public int IdObjectNeed { get; set; }

            [Order(1)] public int StrengthDelta { get; set; }

            [Order(2)] public int AgilityDelta { get; set; }

            [Order(3)] public int VitalDelta { get; set; }

            [Order(4)] public int EnergyDelta { get; set; }
        }
    }

    [Order(104)]
    public class NpcPetnameService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int IdObjectNeed { get; set; }

        [Order(3)] public int Price { get; set; }
    }

    [Order(105)]
    public class NpcPetlearnskillService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public uint[] IdSkills { get; set; }

        [Order(3)] public uint IdDialog { get; set; }
    }

    [Order(106)]
    public class NpcPetforgetskillService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int IdObjectNeed { get; set; }

        [Order(3)] public int Price { get; set; }
    }

    [Order(107)]
    public class SkillmatterEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int LevelRequired { get; set; }

        [Order(5)] public int IdSkill { get; set; }

        [Order(6)] public int LevelSkill { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(108)]
    public class RefineTicketEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)]
        [Size(16)]
        [NameString]
        public string Desc { get; set; }

        [Order(5)] public float ExtReservedProb { get; set; }

        [Order(6)] public float ExtSucceedProb { get; set; }

        [Order(7)] public uint FailReserveLevel { get; set; }

        [Order(8)] [Size(12)] public float[] FailExtSucceedProb { get; set; }

        [Order(9)] public uint BindingOnly { get; set; }

        [Order(10)] public int RequireLevelMax { get; set; }

        [Order(11)] public int Price { get; set; }

        [Order(12)] public int ShopPrice { get; set; }

        [Order(13)] public int PileNumMax { get; set; }

        [Order(14)] public uint HasGuid { get; set; }

        [Order(15)] public uint ProcType { get; set; }
    }

    [Order(109)]
    public class DestroyingEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int ShopPrice { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(110)]
    public class NpcEquipbindService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(4)] public int[] IdObjectNeed { get; set; }

        [Order(3)] public int Price { get; set; }

        [Order(4)] public uint BindType { get; set; }
    }

    [Order(111)]
    public class NpcEquipdestroyService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int IdObjectNeed { get; set; }

        [Order(3)] public int Price { get; set; }
    }

    [Order(112)]
    public class NpcEquipundestroyService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int IdObjectNeed { get; set; }

        [Order(3)] public int Price { get; set; }
    }

    [Order(113)]
    public class BibleEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] [Size(10)] public uint[] IdAddons { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public uint IdDropAfterDamaged { get; set; }

        [Order(8)] public int NumDropAfterDamaged { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(114)]
    public class SpeakerEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int IdIconSet { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(115)]
    public class AutompEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int TotalMp { get; set; }

        [Order(5)] public float TriggerAmount { get; set; }

        [Order(6)] public int CoolTime { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(116)]
    public class AutohpEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int TotalHp { get; set; }

        [Order(5)] public float TriggerAmount { get; set; }

        [Order(6)] public int CoolTime { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(117)]
    public class DoubleExpEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int DoubleExpTime { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(118)]
    public class TransmitscrollEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int ShopPrice { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(119)]
    public class DyeTicketEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public float HMin { get; set; }

        [Order(5)] public float HMax { get; set; }

        [Order(6)] public float SMin { get; set; }

        [Order(7)] public float SMax { get; set; }

        [Order(8)] public float VMin { get; set; }

        [Order(9)] public float VMax { get; set; }

        [Order(10)] public int Price { get; set; }

        [Order(11)] public int ShopPrice { get; set; }

        [Order(12)] public int PileNumMax { get; set; }

        [Order(13)] public uint HasGuid { get; set; }

        [Order(14)] public uint ProcType { get; set; }

        [Order(15)] public uint Usage { get; set; }
    }

    [Order(120)]
    public class GoblinEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileModel1 { get; set; }

        [Order(3)] [Size(128)] public string FileModel2 { get; set; }

        [Order(4)] [Size(128)] public string FileModel3 { get; set; }

        [Order(5)] [Size(128)] public string FileModel4 { get; set; }

        [Order(6)] [Size(128)] public string FileMatter { get; set; }

        [Order(7)] [Size(128)] public string FileIcon1 { get; set; }

        [Order(8)] [Size(128)] public string FileIcon2 { get; set; }

        [Order(9)] [Size(128)] public string FileIcon3 { get; set; }

        [Order(10)] [Size(128)] public string FileIcon4 { get; set; }

        [Order(11)] public float ExpFactor { get; set; }

        [Order(12)] public int InitStrength { get; set; }

        [Order(13)] public int InitAgility { get; set; }

        [Order(14)] public int InitEnergy { get; set; }

        [Order(15)] public int InitTili { get; set; }

        [Order(16)] public int MaxRefineLvl { get; set; }

        [Order(17)] public int Price { get; set; }

        [Order(18)] public int ShopPrice { get; set; }

        [Order(19)] public int DefaultSkill1 { get; set; }

        [Order(20)] public int DefaultSkill2 { get; set; }

        [Order(21)] public int DefaultSkill3 { get; set; }

        [Order(22)] [Size(10)] public RandPropClass[] RandProp { get; set; }

        [Order(23)] public int PileNumMax { get; set; }

        [Order(24)] public uint HasGuid { get; set; }

        [Order(25)] public uint ProcType { get; set; }

        public class RandPropClass
        {
            [Order(0)] public int RandNum { get; set; }

            [Order(1)] public float RandRate { get; set; }
        }
    }

    [Order(121)]
    public class GoblinEquipType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(122)]
    public class GoblinEquipEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileModel { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public int EquipType { get; set; }

        [Order(6)] public int ReqGoblinLevel { get; set; }

        [Order(7)] public int Strength { get; set; }

        [Order(8)] public int Agility { get; set; }

        [Order(9)] public int Energy { get; set; }

        [Order(10)] public int Tili { get; set; }

        [Order(11)] [Size(5)] public int[] Magic { get; set; }

        [Order(12)] public int Price { get; set; }

        [Order(13)] public int ShopPrice { get; set; }

        [Order(14)] public int PileNumMax { get; set; }

        [Order(15)] public uint HasGuid { get; set; }

        [Order(16)] public uint ProcType { get; set; }
    }

    [Order(123)]
    public class GoblinExppillEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint Exp { get; set; }

        [Order(5)] public int Level { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int PileNumMax { get; set; }

        [Order(9)] public uint HasGuid { get; set; }

        [Order(10)] public uint ProcType { get; set; }
    }

    [Order(124)]
    public class SellCertificateEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string ShowModel { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public uint NumSellItem { get; set; }

        [Order(6)] public uint NumBuyItem { get; set; }

        [Order(7)] public uint MaxNameLength { get; set; }

        [Order(8)] public int Price { get; set; }

        [Order(9)] public int ShopPrice { get; set; }

        [Order(10)] public int PileNumMax { get; set; }

        [Order(11)] public uint HasGuid { get; set; }

        [Order(12)] public uint ProcType { get; set; }

        [Order(13)] [Size(128)] public string NameImage { get; set; }
    }

    [Order(125)]
    public class TargetItemEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int NumUsePertime { get; set; }

        [Order(5)] public int NumArea { get; set; }

        [Order(6)] [Size(10)] public int[] AreaId { get; set; }

        [Order(7)] public uint IdSkill { get; set; }

        [Order(8)] public int SkillLevel { get; set; }

        [Order(9)] public int UseInCombat { get; set; }

        [Order(10)] public int Price { get; set; }

        [Order(11)] public int ShopPrice { get; set; }

        [Order(12)] public int PileNumMax { get; set; }

        [Order(13)] public uint HasGuid { get; set; }

        [Order(14)] public uint ProcType { get; set; }

        [Order(15)] public uint UseInSanctuaryOnly { get; set; }

        [Order(16)] public uint CombinedSwitch { get; set; }

        [Order(17)] [Size(32)] public int[] TargetIdForPop { get; set; }

        [Order(18)] public uint TargetFaction { get; set; }

        [Order(19)] public int RequireLevel { get; set; }
    }

    [Order(126)]
    public class LookInfoEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int ShopPrice { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(127)]
    public class UpgradeProductionConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(12)] public int[] NumRefine { get; set; }

        [Order(3)] [Size(40)] public int[] NumWeapon { get; set; }

        [Order(4)] [Size(80)] public int[] NumArmor { get; set; }

        [Order(5)] [Size(20)] public int[] NumStone { get; set; }

        [Order(6)] [Size(3)] public int[] NumEngrave { get; set; }

        [Order(7)] [Size(5)] public int[] NumAddon { get; set; }

        [Order(8)] [Size(80)] public int[] NumDecoration { get; set; }
    }

    [Order(128)]
    public class AccStorageBlacklistConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(512)] public uint[] Blacklist { get; set; }
    }

    [Order(129)]
    public class FaceHairTextureMap : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public HairTextureMapClass[] HairTextureMap { get; set; }

        public class HairTextureMapClass
        {
            [Order(0)] public int ModelId { get; set; }

            [Order(1)] public int TextureId { get; set; }
        }
    }

    [Order(130)]
    public class MultiExpConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(20)] public ChoiceClass[] Choice { get; set; }

        public class ChoiceClass
        {
            [Order(0)] public int MultiTime { get; set; }

            [Order(1)] public float Rate { get; set; }

            [Order(2)] public int ItemCount { get; set; }

            [Order(3)] public int DemultiWaitTime { get; set; }

            [Order(4)] public int DemultiTime { get; set; }
        }
    }

    [Order(131)]
    public class IncSkillAbilityEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int IdSkill { get; set; }

        [Order(5)] public int LevelRequired { get; set; }

        [Order(6)] public float IncRatio { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(132)]
    public class GodEvilConvertConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(256)] public int[] SkillMap { get; set; }
    }

    [Order(133)]
    public class WeddingConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(10)] public WeddingSessionClass[] WeddingSession { get; set; }

        [Order(3)] [Size(20)] public ReservedDayClass[] ReservedDay { get; set; }

        [Order(4)] [Size(10)] public WeddingSceneClass[] WeddingScene { get; set; }

        public class WeddingSessionClass
        {
            [Order(0)] public int StartHour { get; set; }

            [Order(1)] public int StartMin { get; set; }

            [Order(2)] public int EndHour { get; set; }

            [Order(3)] public int EndMin { get; set; }
        }

        public class ReservedDayClass
        {
            [Order(0)] public int Year { get; set; }

            [Order(1)] public int Month { get; set; }

            [Order(2)] public int Day { get; set; }
        }

        public class WeddingSceneClass
        {
            [Order(0)]
            [Size(16)]
            [NameString]
            public string Name { get; set; }

            [Order(1)] [Size(3)] public float[] Pos { get; set; }
        }
    }

    [Order(134)]
    public class WeddingBookcardEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Year { get; set; }

        [Order(5)] public int Month { get; set; }

        [Order(6)] public int Day { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(135)]
    public class WeddingInvitecardEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int ShopPrice { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(136)]
    public class SharpenerEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Level { get; set; }

        [Order(5)] public uint EquipMask { get; set; }

        [Order(6)] [Size(3)] public int[] Addon { get; set; }

        [Order(7)] public int AddonTime { get; set; }

        [Order(8)] public int GfxIndex { get; set; }

        [Order(9)] public int Price { get; set; }

        [Order(10)] public int ShopPrice { get; set; }

        [Order(11)] public int PileNumMax { get; set; }

        [Order(12)] public uint HasGuid { get; set; }

        [Order(13)] public uint ProcType { get; set; }
    }

    [Order(137)]
    public class FaceThirdeyeEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileGfx { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint CharacterComboId { get; set; }

        [Order(5)] public uint GenderId { get; set; }

        [Order(6)] public uint FacepillOnly { get; set; }
    }

    [Order(138)]
    public class FactionFortressConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int RequireLevel { get; set; }

        [Order(3)] [Size(8)] public RequireItemClass[] RequireItem { get; set; }

        [Order(4)] [Size(50)] public LevelClass[] Level { get; set; }

        [Order(5)] [Size(35)] public int[] TechPointCost { get; set; }

        [Order(6)] [Size(20)] public int[] InitBuilding { get; set; }

        [Order(7)] [Size(100)] public int[] ControllerId { get; set; }

        [Order(8)] [Size(100)] public CommonValueClass[] CommonValue { get; set; }

        public class RequireItemClass
        {
            [Order(0)] public int Id { get; set; }

            [Order(1)] public int Count { get; set; }
        }

        public class LevelClass
        {
            [Order(0)] public int Exp { get; set; }

            [Order(1)] public int TechPoint { get; set; }
        }

        public class CommonValueClass
        {
            [Order(0)] public int Id { get; set; }

            [Order(1)] public int Value { get; set; }
        }
    }

    [Order(139)]
    public class FactionBuildingSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(140)]
    public class FactionBuildingEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Level { get; set; }

        [Order(5)] public int RequireLevel { get; set; }

        [Order(6)] [Size(5)] public int[] Technology { get; set; }

        [Order(7)] public int Money { get; set; }

        [Order(8)] [Size(8)] public int[] Material { get; set; }

        [Order(9)] public int BaseTime { get; set; }

        [Order(10)] public int DeltaTime { get; set; }

        [Order(11)] public int ControllerId0 { get; set; }

        [Order(12)] public int ControllerId1 { get; set; }
    }

    [Order(141)]
    public class FactionMaterialEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] [Size(8)] public int[] MaterialCount { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(142)]
    public class CongregateEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint CongregateType { get; set; }

        [Order(5)] [Size(8)] public AreaClass[] Area { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int PileNumMax { get; set; }

        [Order(9)] public uint HasGuid { get; set; }

        [Order(10)] public uint ProcType { get; set; }

        public class AreaClass
        {
            [Order(0)] public int Id { get; set; }

            [Order(1)] public int RequireLevel { get; set; }

            [Order(2)] public int RequireReplyLevel { get; set; }

            [Order(3)] public int RequireReplyLevel2 { get; set; }

            [Order(4)] public int RequireReplyReincarnationTimes { get; set; }
        }
    }

    [Order(143)]
    public class EngraveMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(144)]
    public class EngraveSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(145)]
    public class EngraveEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] public int Level { get; set; }

        [Order(6)] public uint EquipMask { get; set; }

        [Order(7)] public int RequireLevelMin { get; set; }

        [Order(8)] public int RequireLevelMax { get; set; }

        [Order(9)] public int Duration { get; set; }

        [Order(10)] [Size(8)] public MaterialsClass[] Materials { get; set; }

        [Order(11)] [Size(4)] public float[] ProbabilityAddonNum { get; set; }

        [Order(12)] [Size(32)] public Probability[] Addons { get; set; }

        public class MaterialsClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public int Num { get; set; }
        }
    }

    [Order(146)]
    public class NpcEngraveService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(16)] public uint[] IdEngrave { get; set; }
    }

    [Order(147)]
    public class NpcRandpropService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(8)] public PagesClass[] Pages { get; set; }

        public class PagesClass
        {
            [Order(0)]
            [Size(8)]
            [NameString]
            public string PageTitle { get; set; }

            [Order(1)] public uint IdRecipe { get; set; }
        }
    }

    [Order(148)]
    public class RandpropType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(149)]
    public class RandpropEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] public uint IdSkill { get; set; }

        [Order(4)] public int SkillLevel { get; set; }

        [Order(5)] public int Money { get; set; }

        [Order(6)] public int Duration { get; set; }

        [Order(7)] [Size(32)] public uint[] EquipId { get; set; }

        [Order(8)] [Size(8)] public MaterialsClass[] Materials { get; set; }

        public class MaterialsClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public int Num { get; set; }
        }
    }

    [Order(150)]
    public class WikiTabooConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(512)] public uint[] Essence { get; set; }

        [Order(3)] [Size(128)] public uint[] Recipe { get; set; }

        [Order(4)] [Size(512)] public uint[] Task { get; set; }

        [Order(5)] [Size(128)] public uint[] Skill { get; set; }
    }

    [Order(151)]
    public class ForceConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileIcon { get; set; }

        [Order(3)] public uint Color { get; set; }

        [Order(4)]
        [Size(256)]
        [NameString]
        public string Desc { get; set; }

        [Order(5)] public int ReputationMax { get; set; }

        [Order(6)] public int ContributionMax { get; set; }

        [Order(7)] public int JoinMoneyCost { get; set; }

        [Order(8)] public int JoinItemCost { get; set; }

        [Order(9)] public int QuitReputionCost { get; set; }

        [Order(10)] public int QuitContributionCost { get; set; }
    }

    [Order(153)]
    public class ForceTokenEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint RequireForce { get; set; }

        [Order(5)] public int ReputationAdd { get; set; }

        [Order(6)] public int ReputationIncreaseRatio { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(154)]
    public class NpcForceService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint ForceId { get; set; }
    }

    [Order(155)]
    public class PlayerDeathDropConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(256)] public uint[] Itemlist { get; set; }
    }

    [Order(156)]
    public class DynskillequipEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] [Size(4)] public int[] IdSkill { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(157)]
    public class ConsumePointsConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(1024)] public ListClass[] List { get; set; }

        public class ListClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public int Point { get; set; }
        }
    }

    [Order(158)]
    public class OnlineAwardsConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int MaxTime { get; set; }

        [Order(3)] [Size(4)] public ChoiceClass[] Choice { get; set; }

        public class ChoiceClass
        {
            [Order(0)] public int Time { get; set; }

            [Order(1)] public int Interval { get; set; }

            [Order(2)] [Size(8)] public uint[] Ids { get; set; }

            [Order(3)] [Size(150)] public int[] Exp { get; set; }
        }
    }

    [Order(159)]
    public class CountryConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(4)] public CountryClass[] Country { get; set; }

        [Order(3)] [Size(3)] public int[] FlagControllerId { get; set; }

        [Order(4)] public uint FlagMineId { get; set; }

        [Order(5)] [Size(3)] public float[] AttackFlagGoal { get; set; }

        [Order(6)] public float AttackFlagGoalRadius { get; set; }

        [Order(7)] [Size(3)] public float[] DefenceFlagGoal { get; set; }

        [Order(8)] public float DefenceFlagGoalRadius { get; set; }

        [Order(9)] [Size(9)] public DefenceTowerClass[] AttackTower { get; set; }

        [Order(10)] [Size(9)] public DefenceTowerClass[] DefenceTower { get; set; }

        [Order(11)] [Size(8)] public StrongholdClass[] Stronghold { get; set; }

        public class CountryClass
        {
            [Order(0)]
            [Size(32)]
            [NameString]
            public string Name { get; set; }

            [Order(1)] [Size(128)] public string FileIcon { get; set; }

            [Order(2)] public uint Color { get; set; }
        }

        public class AttackTowerClass
        {
            [Order(0)] public int ControllerId { get; set; }

            [Order(1)] public uint Id { get; set; }

            [Order(2)] public int Group { get; set; }
        }

        public class DefenceTowerClass
        {
            [Order(0)] public int ControllerId { get; set; }

            [Order(1)] public uint Id { get; set; }

            [Order(2)] public int Group { get; set; }
        }

        public class StrongholdClass
        {
            [Order(0)] [Size(5)] public StateClass[] State { get; set; }

            [Order(1)] [Size(3)] public float[] Pos { get; set; }

            [Order(2)] public float Radius { get; set; }

            [Order(3)] [Size(3)] public float[] MinePos { get; set; }

            public class StateClass
            {
                [Order(0)] public int ControllerId { get; set; }

                [Order(1)] public uint MineId { get; set; }
            }
        }
    }

    [Order(160)]
    public class GmActivityConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(8)] public int[] Openlist { get; set; }

        [Order(3)] [Size(8)] public int[] Closelist { get; set; }

        [Order(4)] public uint Disabled { get; set; }
    }

    [Order(161)]
    public class FashionWeaponConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(15)] public uint[] ActionMask { get; set; }
    }

    [Order(162)]
    public class PetEvolveConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(5)] public CostClass[] Cost { get; set; }

        public class CostClass
        {
            [Order(0)] [Size(6)] public int[] NumEvolve { get; set; }

            [Order(1)] [Size(6)] public int[] NumInherit { get; set; }

            [Order(2)] [Size(6)] public int[] NumRandSkill { get; set; }
        }
    }

    [Order(163)]
    public class PetEvolvedSkillConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(2)] public Skill[] Skills { get; set; }
    }

    [Order(164)]
    public class MoneyConvertibleEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] public int ShopPrice { get; set; }

        [Order(6)] public int PileNumMax { get; set; }

        [Order(7)] public uint HasGuid { get; set; }

        [Order(8)] public uint ProcType { get; set; }
    }

    [Order(165)]
    public class StoneChangeRecipeType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(166)]
    public class StoneChangeRecipe : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] public uint IdOldStone { get; set; }

        [Order(4)] public uint IdNewStone { get; set; }

        [Order(5)] public int Money { get; set; }

        [Order(6)] [Size(8)] public MaterialsClass[] Materials { get; set; }

        public class MaterialsClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public int Num { get; set; }
        }
    }

    [Order(167)]
    public class MeridianConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(12)] public ProfParaClass[] ProfPara { get; set; }

        public class ProfParaClass
        {
            [Order(0)] public int Hp { get; set; }

            [Order(1)] public int PhyDamage { get; set; }

            [Order(2)] public int MagicDamage { get; set; }

            [Order(3)] public int PhyDefence { get; set; }

            [Order(4)] public int MagicDefence { get; set; }
        }
    }

    [Order(168)]
    public class PetEvolvedSkillRandConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(3)] public RandSkillGroupClass[] RandSkillGroup { get; set; }

        public class RandSkillGroupClass
        {
            [Order(0)] public float Probability { get; set; }

            [Order(1)] [Size(30)] public uint[] List { get; set; }
        }
    }

    [Order(169)]
    public class AutotaskDisplayConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(16)] public ListClass[] List { get; set; }

        public class ListClass
        {
            [Order(0)] public int TaskId { get; set; }

            [Order(1)] [Size(128)] public string FileIcon { get; set; }

            [Order(2)] [Size(128)] public string FileGfx { get; set; }

            [Order(3)] public uint Color { get; set; }
        }
    }

    [Order(170)]
    public class TouchShopConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(8)] public PageClass[] Page { get; set; }

        public class PageClass
        {
            [Order(0)]
            [Size(8)]
            [NameString]
            public string Title { get; set; }

            [Order(1)] [Size(16)] public ItemClass[] Item { get; set; }

            public class ItemClass
            {
                [Order(0)] public uint Id { get; set; }

                [Order(1)] public uint Num { get; set; }

                [Order(2)] public uint Price { get; set; }

                [Order(3)] public int ExpireTimelength { get; set; }
            }
        }
    }

    [Order(171)]
    public class TitleConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(256)]
        [NameString]
        public string Desc { get; set; }

        [Order(3)]
        [Size(256)]
        [NameString]
        public string Condition { get; set; }

        [Order(4)] public uint Color { get; set; }

        [Order(5)] public uint AfterName { get; set; }

        [Order(6)] public int PhyDamage { get; set; }

        [Order(7)] public int MagicDamage { get; set; }

        [Order(8)] public int PhyDefence { get; set; }

        [Order(9)] public int MagicDefence { get; set; }

        [Order(10)] public int Attack { get; set; }

        [Order(11)] public int Armor { get; set; }

        [Order(12)] public uint Broadcast { get; set; }
    }

    [Order(172)]
    public class ComplexTitleConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(256)]
        [NameString]
        public string Desc { get; set; }

        [Order(3)]
        [Size(256)]
        [NameString]
        public string Condition { get; set; }

        [Order(4)] public uint Color { get; set; }

        [Order(5)] public uint AfterName { get; set; }

        [Order(6)] public int PhyDamage { get; set; }

        [Order(7)] public int MagicDamage { get; set; }

        [Order(8)] public int PhyDefence { get; set; }

        [Order(9)] public int MagicDefence { get; set; }

        [Order(10)] public int Attack { get; set; }

        [Order(11)] public int Armor { get; set; }

        [Order(12)] public uint Broadcast { get; set; }

        [Order(13)] [Size(9)] public uint[] SubTitles { get; set; }
    }

    [Order(173)]
    public class MonsterSpiritEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int Type { get; set; }

        [Order(5)] public int Level { get; set; }

        [Order(6)] public int Power { get; set; }

        [Order(7)] public int Price { get; set; }

        [Order(8)] public int ShopPrice { get; set; }

        [Order(9)] public int PileNumMax { get; set; }

        [Order(10)] public uint HasGuid { get; set; }

        [Order(11)] public uint ProcType { get; set; }
    }

    [Order(174)]
    public class PlayerSpiritConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int Type { get; set; }

        [Order(3)] public int Hp { get; set; }

        [Order(4)] public int Damage { get; set; }

        [Order(5)] public int MagicDamage { get; set; }

        [Order(6)] public int Defence { get; set; }

        [Order(7)] [Size(5)] public int[] MagicDefence { get; set; }

        [Order(8)] public int Vigour { get; set; }

        [Order(9)] [Size(10)] public ListClass[] List { get; set; }

        public class ListClass
        {
            [Order(0)] public int RequireLevel { get; set; }

            [Order(1)] public int RequirePower { get; set; }

            [Order(2)] public float GainRatio { get; set; }
        }
    }

    [Order(175)]
    public class PlayerReincarnationConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(10)] public LevelClass[] Level { get; set; }

        public class LevelClass
        {
            [Order(0)] public int RequireItem { get; set; }

            [Order(1)] public float ExpPremote { get; set; }
        }
    }

    [Order(176)]
    public class HistoryStageConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(256)]
        [NameString]
        public string Desc { get; set; }

        [Order(3)] public int ProgressValueId { get; set; }

        [Order(4)] public int ProgressValueGoal { get; set; }
    }

    [Order(177)]
    public class HistoryAdvanceConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(32)] public int[] HistoryStageId { get; set; }
    }

    [Order(178)]
    public class AutoteamConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileIcon { get; set; }

        [Order(3)]
        [Size(256)]
        [NameString]
        public string Desc { get; set; }

        [Order(4)] public uint Type { get; set; }

        [Order(5)] [Size(2)] public int[] RequireLevel { get; set; }

        [Order(6)] [Size(2)] public int[] RequireMaxlevel { get; set; }

        [Order(7)] public int RequireGender { get; set; }

        [Order(8)] [Size(2)] public int[] RequireNum { get; set; }

        [Order(9)] [Size(12)] public int[] NumProf { get; set; }

        [Order(10)] public int RequireLevel2 { get; set; }

        [Order(11)] [Size(2)] public int[] RequireReincarnationTimes { get; set; }

        [Order(12)] [Size(2)] public int[] RequireRealmLevel { get; set; }

        [Order(13)] public int RequireSoulPower { get; set; }

        [Order(14)] public int Worldtag { get; set; }

        [Order(15)] [Size(3)] public float[] TransPos { get; set; }

        [Order(16)] [Size(32)] public int[] WorldtagFrom { get; set; }

        [Order(17)] public uint CombinedSwitch { get; set; }

        [Order(18)] public int TimeType { get; set; }

        [Order(19)] public uint Week { get; set; }

        [Order(20)] [Size(6)] public int[] Day { get; set; }

        [Order(21)] [Size(4)] public int[] Daytime { get; set; }

        [Order(22)] [Size(3)] public int[] Award { get; set; }

        [Order(23)] [Size(32)] public uint[] Task { get; set; }
    }

    [Order(179)]
    public class PlayerRealmConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(10)] public ListClass[] List { get; set; }

        public class ListClass
        {
            [Order(0)] [Size(10)] public LevelClass[] Level { get; set; }

            public class LevelClass
            {
                [Order(0)] public int RequireExp { get; set; }

                [Order(1)] public int Vigour { get; set; }
            }
        }
    }

    [Order(180)]
    public class ChariotConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileIcon { get; set; }

        [Order(3)]
        [Size(256)]
        [NameString]
        public string Desc { get; set; }

        [Order(4)] public int Level { get; set; }

        [Order(5)] public int Shape { get; set; }

        [Order(6)] public int Hp { get; set; }

        [Order(7)] public float HpIncRatio { get; set; }

        [Order(8)] public int Defence { get; set; }

        [Order(9)] [Size(5)] public int[] MagicDefences { get; set; }

        [Order(10)] public int Damage { get; set; }

        [Order(11)] public int MagicDamage { get; set; }

        [Order(12)] public float Speed { get; set; }

        [Order(13)] [Size(4)] public int[] Skill { get; set; }

        [Order(14)] public int PreChariot { get; set; }

        [Order(15)] public int UpgradeCost { get; set; }
    }

    [Order(181)]
    public class ChariotWarConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(3)] public MinesClass[] Mines { get; set; }

        public class MinesClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public int Power { get; set; }
        }
    }

    [Order(182)]
    public class PokerLevelexpConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(100)] public int[] Exp { get; set; }

        [Order(3)] [Size(5)] public float[] ExpAdjust { get; set; }
    }

    [Order(183)]
    public class PokerSuiteEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public float PromoteRatio { get; set; }

        [Order(3)] [Size(6)] public uint[] List { get; set; }
    }

    [Order(184)]
    public class PokerDiceEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int SwallowExp { get; set; }

        [Order(5)] [Size(256)] public Probability[] List { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int PileNumMax { get; set; }

        [Order(9)] public uint HasGuid { get; set; }

        [Order(10)] public uint ProcType { get; set; }
    }

    [Order(185)]
    public class PokerSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int Type { get; set; }

        [Order(3)] public ulong EquipMask { get; set; }
    }

    [Order(187)]
    public class PokerEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)] [Size(128)] public string FileMatter { get; set; }

        [Order(4)] [Size(128)] public string FileIcon { get; set; }

        [Order(5)] [Size(128)] public string FileImg { get; set; }

        [Order(6)] [Size(128)] public string FileGfx { get; set; }

        [Order(7)] public int RequireLevel { get; set; }

        [Order(8)] [Size(2)] public int[] RequireControlPoint { get; set; }

        [Order(9)] public int Rank { get; set; }

        [Order(10)] public int MaxLevel { get; set; }

        [Order(11)] public int Hp { get; set; }

        [Order(12)] public int Damage { get; set; }

        [Order(13)] public int MagicDamage { get; set; }

        [Order(14)] public int Defence { get; set; }

        [Order(15)] [Size(5)] public int[] MagicDefence { get; set; }

        [Order(16)] public int Vigour { get; set; }

        [Order(17)] public int IncHp { get; set; }

        [Order(18)] public int IncDamage { get; set; }

        [Order(19)] public int IncMagicDamage { get; set; }

        [Order(20)] public int IncDefence { get; set; }

        [Order(21)] [Size(5)] public int[] IncMagicDefence { get; set; }

        [Order(22)] public int IncVigour { get; set; }

        [Order(23)] public int SwallowExp { get; set; }

        [Order(24)] [Size(4)] public int[] Addon { get; set; }

        [Order(25)] public int ShowOrder { get; set; }

        [Order(26)] public int Price { get; set; }

        [Order(27)] public int ShopPrice { get; set; }

        [Order(28)] public int PileNumMax { get; set; }

        [Order(29)] public uint HasGuid { get; set; }

        [Order(30)] public uint ProcType { get; set; }
    }

    [Order(188)]
    public class TokenShopConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(64)] public uint[] Item { get; set; }
    }

    [Order(189)]
    public class ShopTokenEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint IdTokenShop { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(190)]
    public class GtConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int IncAttackDegree { get; set; }

        [Order(3)] public int IncDefendDegree { get; set; }
    }

    [Order(191)]
    public class RandShopConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int FirstBuyPrice { get; set; }

        [Order(3)] public int FirstBuyRange { get; set; }

        [Order(4)] public int Price { get; set; }

        [Order(5)] [Size(256)] public Probability[] List { get; set; }
    }

    [Order(192)]
    public class ProfitTimeConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int UpperLimit { get; set; }
    }

    [Order(193)]
    public class FactionPvpConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(8)] public ListClass[] List { get; set; }

        [Order(3)] [Size(52)] public int[] ControllerId { get; set; }

        public class ListClass
        {
            [Order(0)] public int DomainCount { get; set; }

            [Order(1)] public int MinebaseGenCount { get; set; }

            [Order(2)] public int PointsPerGenMinecar { get; set; }

            [Order(3)] public int BasePoints { get; set; }

            [Order(4)] public int MinecarCountCanRob { get; set; }

            [Order(5)] public int MinebaseCountCanRob { get; set; }
        }
    }

    [Order(194)]
    public class UniversalTokenEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint CombinedSwitch { get; set; }

        [Order(5)] [Size(32)] public int[] ConfigId { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int PileNumMax { get; set; }

        [Order(9)] public uint HasGuid { get; set; }

        [Order(10)] public uint ProcType { get; set; }
    }

    [Order(195)]
    public class TaskListConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(256)] public uint[] IdTasks { get; set; }
    }

    [Order(196)]
    public class TaskDiceByWeightConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint StorageId { get; set; }

        [Order(3)] public int MaxWeight { get; set; }

        [Order(4)] [Size(10)] public UniformWeightListClass[] UniformWeightList { get; set; }

        [Order(5)] public uint OtherTaskListConfigId { get; set; }

        [Order(6)] public uint StorageRefreshOnCrossserver { get; set; }

        public class UniformWeightListClass
        {
            [Order(0)] public float Probability { get; set; }

            [Order(1)] public int Weight { get; set; }

            [Order(2)] public uint TaskListConfigId { get; set; }
        }
    }

    [Order(197)]
    public class FashionSuiteEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileIcon { get; set; }

        [Order(3)] [Size(6)] public uint[] List { get; set; }

        [Order(4)] public int ShowOrder { get; set; }
    }

    [Order(198)]
    public class FashionBestColorConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(64)] public ListClass[] List { get; set; }

        public class ListClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public uint Color { get; set; }
        }
    }

    [Order(199)]
    public class SignAwardConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(31)] public ListClass[] List { get; set; }

        public class ListClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public int Num { get; set; }
        }
    }

    [Order(200)]
    public class AstrolabeEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public uint CharacterComboId { get; set; }

        [Order(5)] public int RequireLevel { get; set; }

        [Order(6)] public int MinInnerPointValue { get; set; }

        [Order(7)] public int MaxInnerPointValue { get; set; }

        [Order(8)] public int MaxInitInnerPointValue { get; set; }

        [Order(9)] public int InitAllInnerPointValue { get; set; }

        [Order(10)] public int MaxAllInnerPointValue { get; set; }

        [Order(11)] [Size(32)] public RandsClass[] Rands { get; set; }

        [Order(12)] public uint IdRandWhenFail { get; set; }

        [Order(13)] public int BaseSwallowExp { get; set; }

        [Order(14)] public int Price { get; set; }

        [Order(15)] public int ShopPrice { get; set; }

        [Order(16)] public int PileNumMax { get; set; }

        [Order(17)] public uint HasGuid { get; set; }

        [Order(18)] public uint ProcType { get; set; }

        public class RandsClass
        {
            [Order(0)] public uint IdRand { get; set; }

            [Order(1)] public float ProbabilityRand { get; set; }

            [Order(2)] public int MaxAppearTimesRand { get; set; }
        }
    }

    [Order(201)]
    public class AstrolabeRandomAddonEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int AddonRandomExpGained { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(202)]
    public class AstrolabeIncInnerPointValueEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int IncreaseBase { get; set; }

        [Order(5)] [Size(10)] public float[] IncreaseProbability { get; set; }

        [Order(6)] public int RequireMinAllInnerPointValue { get; set; }

        [Order(7)] public int RequireMaxAllInnerPointValue { get; set; }

        [Order(8)] public int Price { get; set; }

        [Order(9)] public int ShopPrice { get; set; }

        [Order(10)] public int PileNumMax { get; set; }

        [Order(11)] public uint HasGuid { get; set; }

        [Order(12)] public uint ProcType { get; set; }
    }

    [Order(203)]
    public class AstrolabeIncExpEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int SwallowExp { get; set; }

        [Order(5)] public int Price { get; set; }

        [Order(6)] public int ShopPrice { get; set; }

        [Order(7)] public int PileNumMax { get; set; }

        [Order(8)] public uint HasGuid { get; set; }

        [Order(9)] public uint ProcType { get; set; }
    }

    [Order(204)]
    public class ItemPackageByProfessionEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] [Size(12)] public ProfListClass[] ProfList { get; set; }

        [Order(5)] public int ItemExpireTimelength { get; set; }

        [Order(6)] public int Price { get; set; }

        [Order(7)] public int ShopPrice { get; set; }

        [Order(8)] public int PileNumMax { get; set; }

        [Order(9)] public uint HasGuid { get; set; }

        [Order(10)] public uint ProcType { get; set; }

        public class ProfListClass
        {
            [Order(0)] [Size(2)] public uint[] GenderList { get; set; }

            public class GenderListClass
            {
                [Order(0)] public uint ItemId { get; set; }
            }
        }
    }

    [Order(205)]
    public class AstrolabeLevelexpConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(100)] public int[] Exp { get; set; }
    }

    [Order(206)]
    public class AstrolabeAddonRandomConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(10)] public int[] LevelupExp { get; set; }

        [Order(3)] [Size(100)] public float[] RandProbability { get; set; }
    }

    [Order(207)]
    public class AstrolabeAppearanceConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(10)] public ListClass[] List { get; set; }

        public class ListClass
        {
            [Order(0)] public uint NameColor { get; set; }

            [Order(1)] [Size(128)] public string FileGfx { get; set; }
        }
    }

    [Order(208)]
    public class EquipMakeHoleConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(20)] public LevelListClass[] LevelList { get; set; }

        public class LevelListClass
        {
            [Order(0)] [Size(4)] public HoleListClass[] HoleList { get; set; }

            public class HoleListClass
            {
                [Order(0)] public uint RequireItemId { get; set; }

                [Order(1)] public int RequireItemCount { get; set; }

                [Order(2)] public int Fee { get; set; }
            }
        }
    }

    [Order(209)]
    public class SoloTowerChallengeLevelConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(6)] public RoomClass[] Room { get; set; }

        [Order(3)] [Size(256)] public int[] ControllerIdToDeactivate { get; set; }

        [Order(4)] [Size(12)] public StepsClass[] Steps { get; set; }

        public class RoomClass
        {
            [Order(0)] [Size(3)] public float[] TransPos { get; set; }

            [Order(1)] [Size(8)] public int[] ControllerIdToActivate { get; set; }
        }

        public class StepsClass
        {
            [Order(0)] [Size(32)] public uint[] PlayingMethodController { get; set; }

            [Order(1)] public int PlayingMethodBossController { get; set; }
        }
    }

    [Order(210)]
    public class SoloTowerChallengeAwardPageConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(20)] public ListClass[] List { get; set; }

        public class ListClass
        {
            [Order(0)] public uint Id { get; set; }

            [Order(1)] public uint Count { get; set; }

            [Order(2)] public float Probability { get; set; }
        }
    }

    [Order(211)]
    public class SoloTowerChallengeAwardListConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(108)] public LevelClass[] Level { get; set; }

        public class LevelClass
        {
            [Order(0)] public uint AwardPageConfigId { get; set; }

            [Order(1)] public uint DrawAwardTimes { get; set; }

            [Order(2)] public int AwardScore { get; set; }
        }
    }

    [Order(212)]
    public class SoloTowerChallengeScoreCostConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(16)] public ScoreBuffListClass[] ScoreBuffList { get; set; }

        public class ScoreBuffListClass
        {
            [Order(0)] public uint ScoreCost { get; set; }

            [Order(1)] public uint CooldownId { get; set; }

            [Order(2)] public uint CooldownTime { get; set; }

            [Order(3)] [Size(5)] public float[] Param { get; set; }

            [Order(4)]
            [Size(256)]
            [NameString]
            public string ParamComment { get; set; }
        }
    }

    [Order(213)]
    public class MnfactionWarConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint SignUpMoneyCost { get; set; }

        [Order(3)] public int ResourcePoint { get; set; }

        [Order(4)] public int ResourceTowerDestroyReducePoint { get; set; }

        [Order(5)] public int AttackerBossTid { get; set; }

        [Order(6)] public int DefenderBossTid { get; set; }

        [Order(7)] public int AttackerSmallBossTid { get; set; }

        [Order(8)] public int DefenderSmallBossTid { get; set; }

        [Order(9)] public int SmallBossDeathReducePoint { get; set; }

        [Order(10)] public int AttackerSmallBossControllerId { get; set; }

        [Order(11)] public int DefenderSmallBossControllerId { get; set; }

        [Order(12)] public int SmallBossAppearTime { get; set; }

        [Order(13)] public int DebuffAppearTime { get; set; }

        [Order(14)] public int DebuffInitRatio { get; set; }

        [Order(15)] public int DebuffEnhanceRatioPerMinute { get; set; }

        [Order(16)] [Size(4)] public DefenderResourceTowerClass[] AttackerResourceTower { get; set; }

        [Order(17)] [Size(4)] public DefenderResourceTowerClass[] DefenderResourceTower { get; set; }

        [Order(18)] [Size(4)] public NeutralTowerClass[] NeutralTower { get; set; }

        [Order(19)] public DomainClass Domain { get; set; }

        public class AttackerResourceTowerClass
        {
            [Order(0)] [Size(3)] public int[] ControllerId { get; set; }

            [Order(1)] public int GuardControllerId { get; set; }

            [Order(2)] public uint MatterId { get; set; }
        }

        public class DefenderResourceTowerClass
        {
            [Order(0)] [Size(3)] public int[] ControllerId { get; set; }

            [Order(1)] public int GuardControllerId { get; set; }

            [Order(2)] public uint MatterId { get; set; }
        }

        public class NeutralTowerClass
        {
            [Order(0)] [Size(5)] public int[] ControllerId { get; set; }

            [Order(1)] public uint MatterId { get; set; }
        }

        public class DomainClass
        {
            [Order(0)] [Size(3)] public float[] AttackerIncomingPos { get; set; }

            [Order(1)] [Size(3)] public float[] DefenderIncomingPos { get; set; }

            [Order(2)] [Size(3)] public float[] AttackerTransmitPos { get; set; }

            [Order(3)] [Size(3)] public float[] DefenderTransmitPos { get; set; }

            [Order(4)] [Size(6)] public float[] ResurrectPos { get; set; }

            [Order(5)] public float ResurrectPosRange { get; set; }

            [Order(6)] public float ResourcePointRange { get; set; }

            [Order(7)] [Size(6)] public float[] ResoursePointPos { get; set; }

            [Order(8)] [Size(5)] public TransmitPosClass[] TransmitPos { get; set; }

            [Order(9)] public int DegreeTotal { get; set; }

            [Order(10)] public int DegreePerPersonSecond { get; set; }

            [Order(11)] public int GainResourcePointPerSecond { get; set; }

            [Order(12)] public int GainResourcePointInterval { get; set; }

            [Order(13)] public int ReduceResourcePointOnDeath { get; set; }

            public class ResurrectPosClass
            {
                [Order(0)] [Size(6)] public float[] ResurrectPos { get; set; }
            }

            public class ResoursePointPosClass
            {
                [Order(0)] [Size(6)] public float[] ResoursePointPos { get; set; }
            }

            public class TransmitPosClass
            {
                [Order(0)] [Size(5)] public int[] ControllerId { get; set; }

                [Order(1)] public int MatterId { get; set; }

                [Order(2)] [Size(3)] public float[] TransmitPos { get; set; }
            }
        }
    }

    [Order(214)]
    public class NpcCrossServerService : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int ActivityType { get; set; }

        [Order(3)] public int PlayerCountLimit { get; set; }

        [Order(4)] public int TimeOut { get; set; }

        [Order(5)] public int NeedItemTid { get; set; }

        [Order(6)] public int NeedItemCount { get; set; }

        [Order(7)] public uint CostItem { get; set; }

        [Order(8)] public int HistoryMaxLevelRequire { get; set; }

        [Order(9)] public int TaoistRankRequire { get; set; }

        [Order(10)] public int RealmLevelRequire { get; set; }
    }

    [Order(215)]
    public class HomeConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(32)] public UpgradeClass[] Upgrade { get; set; }

        [Order(3)] [Size(32)] public LevelClass[] Level { get; set; }

        [Order(4)] [Size(16)] public MapUnlockClass[] MapUnlock { get; set; }

        public class UpgradeClass
        {
            [Order(0)] public uint NeedExp { get; set; }

            [Order(1)] public uint NeedHistoryMaxLevel { get; set; }

            [Order(2)] public uint NeedReincarnationTimes { get; set; }

            [Order(3)] public uint NeedRealmlevel { get; set; }
        }

        public class LevelClass
        {
            [Order(0)] public uint Energy { get; set; }

            [Order(1)] public uint Prosperous { get; set; }

            [Order(2)] public uint Clean { get; set; }

            [Order(3)] public uint MaxGrainCapacity { get; set; }

            [Order(4)] public uint MaxResourceCapacity { get; set; }
        }

        public class MapUnlockClass
        {
            [Order(0)] public uint HomeLevel { get; set; }

            [Order(1)] public uint NeedItemId { get; set; }

            [Order(2)] public uint NeedItemCount { get; set; }
        }
    }

    [Order(216)]
    public class HomeProductsConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int ProduceType { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int IsHaveSurfaceDisplay { get; set; }

        [Order(5)] public int Time { get; set; }

        [Order(6)] public int BuildingLevelMin { get; set; }

        [Order(7)] public int BuildingLevelMax { get; set; }

        [Order(8)] [Size(128)] public string FileMatterPrimary { get; set; }

        [Order(9)] [Size(128)] public string FileMatterGrowUp { get; set; }

        [Order(10)] [Size(128)] public string FileMatterRipe { get; set; }

        [Order(11)] public uint Output { get; set; }

        [Order(12)] public uint Exp { get; set; }

        [Order(13)] public int CostGrainCount { get; set; }

        [Order(14)] public int CostItemId { get; set; }

        [Order(15)] public int CostItemCount { get; set; }

        [Order(16)] public int SubType { get; set; }
    }

    [Order(217)]
    public class HomeResourceProduceConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int ProduceType { get; set; }

        [Order(3)] public float ProsperousEffectRatio { get; set; }

        [Order(4)] [Size(16)] public LevelClass[] Level { get; set; }

        public class LevelClass
        {
            [Order(0)] public uint MaxCapacity { get; set; }

            [Order(1)] public uint MaxAddEnergyTime { get; set; }

            [Order(2)] public float ProduceMultiple { get; set; }

            [Order(3)] public uint UpgradeNeedHomeLevel { get; set; }

            [Order(4)] public uint UpgradeConsumeStoneNum { get; set; }

            [Order(5)] public uint UpgradeConsumeWoodNum { get; set; }

            [Order(6)] public uint UpgradeConsumeIronNum { get; set; }

            [Order(7)] public uint UpgradeConsumeClothNum { get; set; }

            [Order(8)] public uint UpgradeConsumeGrainNum { get; set; }

            [Order(9)] public uint UpgradeConsumeMoney { get; set; }
        }
    }

    [Order(218)]
    public class HomeFormulasProduceRecipe : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] public int ServiceType { get; set; }

        [Order(5)] public int IsBaseFormulas { get; set; }

        [Order(6)] public int Type { get; set; }

        [Order(7)] public int LevelNeed { get; set; }

        [Order(8)] public uint HomeItemId { get; set; }

        [Order(9)] public float SuccessProbility { get; set; }

        [Order(10)] public uint Count { get; set; }

        [Order(11)] public uint TimeUse { get; set; }

        [Order(12)] public uint EnergyConsume { get; set; }

        [Order(13)] public uint HomeExpGain { get; set; }

        [Order(14)] public uint ProduceConsumeStoneNum { get; set; }

        [Order(15)] public uint ProduceConsumeWoodNum { get; set; }

        [Order(16)] public uint ProduceConsumeIronNum { get; set; }

        [Order(17)] public uint ProduceConsumeClothNum { get; set; }

        [Order(18)] public uint ProduceConsumeMoney { get; set; }

        [Order(19)] [Size(8)] public MaterialClass[] Material { get; set; }

        public class MaterialClass
        {
            [Order(0)] public uint HomeItemId { get; set; }

            [Order(1)] public uint NormalItemId { get; set; }

            [Order(2)] public uint ItemCount { get; set; }
        }
    }

    [Order(219)]
    public class HomeFormulasItemEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] [Size(128)] public string FileMatter { get; set; }

        [Order(5)] [Size(128)] public string FileIcon { get; set; }

        [Order(6)] public uint FormulasId { get; set; }

        [Order(7)] public uint ProduceTimes { get; set; }

        [Order(8)] public int Price { get; set; }

        [Order(9)] public int ShopPrice { get; set; }

        [Order(10)] public int PileNumMax { get; set; }

        [Order(11)] public uint HasGuid { get; set; }

        [Order(12)] public uint ProcType { get; set; }
    }

    [Order(220)]
    public class HomeProduceServiceConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public ProduceListClass[] ProduceList { get; set; }

        public class ProduceListClass
        {
            [Order(0)] public uint FormulasId { get; set; }

            [Order(1)] public uint Level { get; set; }
        }
    }

    [Order(221)]
    public class HomeFactoryConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public int FactoryType { get; set; }

        [Order(3)] [Size(16)] public LevelClass[] Level { get; set; }

        public class LevelClass
        {
            [Order(0)] public uint UpgradeConsumeStoneNum { get; set; }

            [Order(1)] public uint UpgradeConsumeWoodNum { get; set; }

            [Order(2)] public uint UpgradeConsumeIronNum { get; set; }

            [Order(3)] public uint UpgradeConsumeClothNum { get; set; }

            [Order(4)] public uint UpgradeConsumeGrainNum { get; set; }

            [Order(5)] public uint UpgradeConsumeMoney { get; set; }

            [Order(6)] public uint UpgradeNeedHomeLevel { get; set; }
        }
    }

    [Order(222)]
    public class HomeItemMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(223)]
    public class HomeItemSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(224)]
    public class HomeItemEntity : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)] public uint IdMajorType { get; set; }

        [Order(2)] public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)] public int Rank { get; set; }

        [Order(5)]
        [Size(256)]
        [NameString]
        public string Desc { get; set; }

        [Order(6)] [Size(128)] public string FileModel { get; set; }

        [Order(7)] [Size(128)] public string FileIcon { get; set; }

        [Order(8)] public int MinGeneralProsperous { get; set; }

        [Order(9)] public int MaxGeneralProsperous { get; set; }

        [Order(10)] public int MinFineProsperous { get; set; }

        [Order(11)] public int MaxFineProsperous { get; set; }

        [Order(12)] public float FineRandProbability { get; set; }

        [Order(13)] public int Clean { get; set; }

        [Order(14)] public int MaxPlacedNum { get; set; }

        [Order(15)] public int IsPermitOutside { get; set; }

        [Order(16)] public int HangType { get; set; }

        [Order(17)] public int IsDisplay { get; set; }

        [Order(18)] public uint FactoryConfig { get; set; }

        [Order(19)] public uint ResourceConfig { get; set; }

        [Order(20)] public int ShowPriority { get; set; }

        [Order(21)] public int ForbidEquip { get; set; }
    }

    [Order(225)]
    public class HomeFormulasProduceMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(226)]
    public class HomeFormulasProduceSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(227)]
    public class HomeFormulasItemMajorType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(228)]
    public class HomeFormulasItemSubType : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(229)]
    public class HomeStorageTaskConfig : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] public uint RefreshTaskCountMin { get; set; }

        [Order(3)] public uint RefreshTaskCountMax { get; set; }

        [Order(4)] public uint RefreshTimes { get; set; }

        [Order(5)] public uint RefreshCostGrain { get; set; }

        [Order(6)] public uint DeliverTaskMax { get; set; }

        [Order(7)] [Size(16)] public TaskStorageClass[] TaskStorage { get; set; }

        public class TaskStorageClass
        {
            [Order(0)] public uint TaskOutServiceId { get; set; }

            [Order(1)] public uint FlourishMin { get; set; }

            [Order(2)] public uint FlourishMax { get; set; }

            [Order(3)] public uint RandomWeight { get; set; }
        }
    }

    [Order(230)]
    public class WishTributeEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int UniqueId { get; set; }

        [Order(5)] public int ValueAdd { get; set; }

        [Order(6)] public int SkillId { get; set; }

        [Order(7)] public int SkillLevel { get; set; }

        [Order(8)] public int ItemId { get; set; }

        [Order(9)] public int ItemCount { get; set; }

        [Order(10)] public int Price { get; set; }

        [Order(11)] public int ShopPrice { get; set; }

        [Order(12)] public int PileNumMax { get; set; }

        [Order(13)] public uint HasGuid { get; set; }

        [Order(14)] public uint ProcType { get; set; }
    }

    [Order(231)]
    public class RedPacketPaperEssence : IElement
    {
        [Order(0)] public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)] [Size(128)] public string FileMatter { get; set; }

        [Order(3)] [Size(128)] public string FileIcon { get; set; }

        [Order(4)] public int TimeLimit { get; set; }

        [Order(5)] public int MoneyMin { get; set; }

        [Order(6)] public int MoneyMax { get; set; }

        [Order(7)] public int CashMin { get; set; }

        [Order(8)] public int CashMax { get; set; }

        [Order(9)] public int DeliverCountMin { get; set; }

        [Order(10)] public int DeliverCountMax { get; set; }

        [Order(11)] public int SpecialItemId { get; set; }

        [Order(12)] [Size(32)] public float[] SpecialItemCountRand { get; set; }

        [Order(13)] public int Price { get; set; }

        [Order(14)] public int ShopPrice { get; set; }

        [Order(15)] public int PileNumMax { get; set; }

        [Order(16)] public uint HasGuid { get; set; }

        [Order(17)] public uint ProcType { get; set; }
    }
}
