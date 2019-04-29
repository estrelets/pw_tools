using Pw.ElementsSerializer;

namespace Pw.Elements
{
    [Order(0)]
    public class EquipmentAddon : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int NumParams { get; set; }

        [Order(3)]
        public int Param1 { get; set; }

        [Order(4)]
        public int Param2 { get; set; }

        [Order(5)]
        public int Param3 { get; set; }
    }

    [Order(1)]
    public class WeaponMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(2)]
    public class WeaponSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileHitgfx { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileHitsfx { get; set; }

        [Order(4)]
        public float ProbabilityFastest { get; set; }

        [Order(5)]
        public float ProbabilityFast { get; set; }

        [Order(6)]
        public float ProbabilityNormal { get; set; }

        [Order(7)]
        public float ProbabilitySlow { get; set; }

        [Order(8)]
        public float ProbabilitySlowest { get; set; }

        [Order(9)]
        public float AttackSpeed { get; set; }

        [Order(10)]
        public float AttackShortRange { get; set; }

        [Order(11)]
        public uint ActionType { get; set; }
    }

    [Order(3)]
    public class WeaponEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        public uint RequireProjectile { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileModelRight { get; set; }

        [Order(6)]
        [Size(128)]
        public string FileModelLeft { get; set; }

        [Order(7)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(8)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(9)]
        public int RequireStrength { get; set; }

        [Order(10)]
        public int RequireAgility { get; set; }

        [Order(11)]
        public int RequireEnergy { get; set; }

        [Order(12)]
        public int RequireTili { get; set; }

        [Order(13)]
        public uint CharacterComboId { get; set; }

        [Order(14)]
        public int RequireLevel { get; set; }

        [Order(15)]
        public int RequireReputation { get; set; }

        [Order(16)]
        public int Level { get; set; }

        [Order(17)]
        public int FixedProps { get; set; }

        [Order(18)]
        public int DamageLow { get; set; }

        [Order(19)]
        public int DamageHighMin { get; set; }

        [Order(20)]
        public int DamageHighMax { get; set; }

        [Order(21)]
        public int MagicDamageLow { get; set; }

        [Order(22)]
        public int MagicDamageHighMin { get; set; }

        [Order(23)]
        public int MagicDamageHighMax { get; set; }

        [Order(24)]
        public float AttackRange { get; set; }

        [Order(25)]
        public uint ShortRangeMode { get; set; }

        [Order(26)]
        public int DurabilityMin { get; set; }

        [Order(27)]
        public int DurabilityMax { get; set; }

        [Order(28)]
        public int LevelupAddon { get; set; }

        [Order(29)]
        public int MaterialNeed { get; set; }

        [Order(30)]
        public int Price { get; set; }

        [Order(31)]
        public int ShopPrice { get; set; }

        [Order(32)]
        public int Repairfee { get; set; }

        [Order(33)]
        public float DropProbabilitySocket0 { get; set; }

        [Order(34)]
        public float DropProbabilitySocket1 { get; set; }

        [Order(35)]
        public float DropProbabilitySocket2 { get; set; }

        [Order(36)]
        public float MakeProbabilitySocket0 { get; set; }

        [Order(37)]
        public float MakeProbabilitySocket1 { get; set; }

        [Order(38)]
        public float MakeProbabilitySocket2 { get; set; }

        [Order(39)]
        public float ProbabilityAddonNum0 { get; set; }

        [Order(40)]
        public float ProbabilityAddonNum1 { get; set; }

        [Order(41)]
        public float ProbabilityAddonNum2 { get; set; }

        [Order(42)]
        public float ProbabilityAddonNum3 { get; set; }

        [Order(43)]
        public float ProbabilityAddonNum4 { get; set; }

        [Order(44)]
        public float ProbabilityUnique { get; set; }

        [Order(45)]
        [Size(32)]
        public Probability[] Addons { get; set; }

        [Order(46)]
        [Size(32)]
        public Probability[] Rands { get; set; }

        [Order(47)]
        [Size(16)]
        public Probability[] Uniques { get; set; }

        [Order(48)]
        public int DurabilityDropMin { get; set; }

        [Order(49)]
        public int DurabilityDropMax { get; set; }

        [Order(50)]
        public int DecomposePrice { get; set; }

        [Order(51)]
        public int DecomposeTime { get; set; }

        [Order(52)]
        public uint ElementId { get; set; }

        [Order(53)]
        public int ElementNum { get; set; }

        [Order(54)]
        public uint IdDropAfterDamaged { get; set; }

        [Order(55)]
        public int NumDropAfterDamaged { get; set; }

        [Order(56)]
        public int PileNumMax { get; set; }

        [Order(57)]
        public uint HasGuid { get; set; }

        [Order(58)]
        public uint ProcType { get; set; }
    }

    [Order(4)]
    public class ArmorMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(5)]
    public class ArmorSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint EquipMask { get; set; }
    }

    [Order(6)]
    public class ArmorEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        [Size(32)]
        public string Realname { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(6)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(7)]
        public uint EquipLocation { get; set; }

        [Order(8)]
        public int Level { get; set; }

        [Order(9)]
        public int RequireStrength { get; set; }

        [Order(10)]
        public int RequireAgility { get; set; }

        [Order(11)]
        public int RequireEnergy { get; set; }

        [Order(12)]
        public int RequireTili { get; set; }

        [Order(13)]
        public uint CharacterComboId { get; set; }

        [Order(14)]
        public int RequireLevel { get; set; }

        [Order(15)]
        public int RequireReputation { get; set; }

        [Order(16)]
        public int FixedProps { get; set; }

        [Order(17)]
        public int DefenceLow { get; set; }

        [Order(18)]
        public int DefenceHigh { get; set; }

        [Order(19)]
        [Size(5)]
        public (int Low, int High)[] MagicDefences { get; set; }

        [Order(20)]
        public int MpEnhanceLow { get; set; }

        [Order(21)]
        public int MpEnhanceHigh { get; set; }

        [Order(22)]
        public int HpEnhanceLow { get; set; }

        [Order(23)]
        public int HpEnhanceHigh { get; set; }

        [Order(24)]
        public int ArmorEnhanceLow { get; set; }

        [Order(25)]
        public int ArmorEnhanceHigh { get; set; }

        [Order(26)]
        public int DurabilityMin { get; set; }

        [Order(27)]
        public int DurabilityMax { get; set; }

        [Order(28)]
        public int LevelupAddon { get; set; }

        [Order(29)]
        public int MaterialNeed { get; set; }

        [Order(30)]
        public int Price { get; set; }

        [Order(31)]
        public int ShopPrice { get; set; }

        [Order(32)]
        public int Repairfee { get; set; }

        [Order(33)]
        public float DropProbabilitySocket0 { get; set; }

        [Order(34)]
        public float DropProbabilitySocket1 { get; set; }

        [Order(35)]
        public float DropProbabilitySocket2 { get; set; }

        [Order(36)]
        public float DropProbabilitySocket3 { get; set; }

        [Order(37)]
        public float DropProbabilitySocket4 { get; set; }

        [Order(38)]
        public float MakeProbabilitySocket0 { get; set; }

        [Order(39)]
        public float MakeProbabilitySocket1 { get; set; }

        [Order(40)]
        public float MakeProbabilitySocket2 { get; set; }

        [Order(41)]
        public float MakeProbabilitySocket3 { get; set; }

        [Order(42)]
        public float MakeProbabilitySocket4 { get; set; }

        [Order(43)]
        public float ProbabilityAddonNum0 { get; set; }

        [Order(44)]
        public float ProbabilityAddonNum1 { get; set; }

        [Order(45)]
        public float ProbabilityAddonNum2 { get; set; }

        [Order(46)]
        public float ProbabilityAddonNum3 { get; set; }

        [Order(47)]
        [Size(32)]
        public Probability[] Addons { get; set; }

        [Order(48)]
        [Size(32)]
        public Probability[] Rands { get; set; }

        [Order(49)]
        public int DurabilityDropMin { get; set; }

        [Order(50)]
        public int DurabilityDropMax { get; set; }

        [Order(51)]
        public int DecomposePrice { get; set; }

        [Order(52)]
        public int DecomposeTime { get; set; }

        [Order(53)]
        public uint ElementId { get; set; }

        [Order(54)]
        public int ElementNum { get; set; }

        [Order(55)]
        public uint IdDropAfterDamaged { get; set; }

        [Order(56)]
        public int NumDropAfterDamaged { get; set; }

        [Order(57)]
        public uint IdHair { get; set; }

        [Order(58)]
        public uint IdHairTexture { get; set; }

        [Order(59)]
        public int PileNumMax { get; set; }

        [Order(60)]
        public uint HasGuid { get; set; }

        [Order(61)]
        public uint ProcType { get; set; }

        [Order(62)]
        public uint ForceAllMagicDefences { get; set; }
    }

    [Order(7)]
    public class DecorationMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(8)]
    public class DecorationSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint EquipMask { get; set; }
    }

    [Order(9)]
    public class DecorationEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(6)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(7)]
        public int Level { get; set; }

        [Order(8)]
        public int RequireStrength { get; set; }

        [Order(9)]
        public int RequireAgility { get; set; }

        [Order(10)]
        public int RequireEnergy { get; set; }

        [Order(11)]
        public int RequireTili { get; set; }

        [Order(12)]
        public uint CharacterComboId { get; set; }

        [Order(13)]
        public int RequireLevel { get; set; }

        [Order(14)]
        public int RequireReputation { get; set; }

        [Order(15)]
        public int FixedProps { get; set; }

        [Order(16)]
        public int DamageLow { get; set; }

        [Order(17)]
        public int DamageHigh { get; set; }

        [Order(18)]
        public int MagicDamageLow { get; set; }

        [Order(19)]
        public int MagicDamageHigh { get; set; }

        [Order(20)]
        public int DefenceLow { get; set; }

        [Order(21)]
        public int DefenceHigh { get; set; }

        [Order(22)]
        [Size(5)]
        public (int Low, int High)[] MagicDefences { get; set; }

        [Order(23)]
        public int ArmorEnhanceLow { get; set; }

        [Order(24)]
        public int ArmorEnhanceHigh { get; set; }

        [Order(25)]
        public int DurabilityMin { get; set; }

        [Order(26)]
        public int DurabilityMax { get; set; }

        [Order(27)]
        public int LevelupAddon { get; set; }

        [Order(28)]
        public int MaterialNeed { get; set; }

        [Order(29)]
        public int Price { get; set; }

        [Order(30)]
        public int ShopPrice { get; set; }

        [Order(31)]
        public int Repairfee { get; set; }

        [Order(32)]
        public float ProbabilityAddonNum0 { get; set; }

        [Order(33)]
        public float ProbabilityAddonNum1 { get; set; }

        [Order(34)]
        public float ProbabilityAddonNum2 { get; set; }

        [Order(35)]
        public float ProbabilityAddonNum3 { get; set; }

        [Order(36)]
        [Size(32)]
        public Probability[] Addons { get; set; }

        [Order(37)]
        [Size(32)]
        public Probability[] Rands { get; set; }

        [Order(38)]
        public int DurabilityDropMin { get; set; }

        [Order(39)]
        public int DurabilityDropMax { get; set; }

        [Order(40)]
        public int DecomposePrice { get; set; }

        [Order(41)]
        public int DecomposeTime { get; set; }

        [Order(42)]
        public uint ElementId { get; set; }

        [Order(43)]
        public int ElementNum { get; set; }

        [Order(44)]
        public uint IdDropAfterDamaged { get; set; }

        [Order(45)]
        public int NumDropAfterDamaged { get; set; }

        [Order(46)]
        public int PileNumMax { get; set; }

        [Order(47)]
        public uint HasGuid { get; set; }

        [Order(48)]
        public uint ProcType { get; set; }
    }

    [Order(10)]
    public class MedicineMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(11)]
    public class MedicineSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(12)]
    public class MedicineEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(6)]
        public int RequireLevel { get; set; }

        [Order(7)]
        public int CoolTime { get; set; }

        [Order(8)]
        public int HpAddTotal { get; set; }

        [Order(9)]
        public int HpAddTime { get; set; }

        [Order(10)]
        public int MpAddTotal { get; set; }

        [Order(11)]
        public int MpAddTime { get; set; }

        [Order(12)]
        public int Price { get; set; }

        [Order(13)]
        public int ShopPrice { get; set; }

        [Order(14)]
        public int PileNumMax { get; set; }

        [Order(15)]
        public uint HasGuid { get; set; }

        [Order(16)]
        public uint ProcType { get; set; }
    }

    [Order(13)]
    public class MaterialMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(14)]
    public class MaterialSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(15)]
    public class MaterialEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(6)]
        public int Price { get; set; }

        [Order(7)]
        public int ShopPrice { get; set; }

        [Order(8)]
        public int DecomposePrice { get; set; }

        [Order(9)]
        public int DecomposeTime { get; set; }

        [Order(10)]
        public uint ElementId { get; set; }

        [Order(11)]
        public int ElementNum { get; set; }

        [Order(12)]
        public int PileNumMax { get; set; }

        [Order(13)]
        public uint HasGuid { get; set; }

        [Order(14)]
        public uint ProcType { get; set; }
    }

    [Order(16)]
    public class DamageruneSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(17)]
    public class DamageruneEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public uint DamageType { get; set; }

        [Order(6)]
        public int Price { get; set; }

        [Order(7)]
        public int ShopPrice { get; set; }

        [Order(8)]
        public int RequireWeaponLevelMin { get; set; }

        [Order(9)]
        public int RequireWeaponLevelMax { get; set; }

        [Order(10)]
        public int DamageIncreased { get; set; }

        [Order(11)]
        public int PileNumMax { get; set; }

        [Order(12)]
        public uint HasGuid { get; set; }

        [Order(13)]
        public uint ProcType { get; set; }
    }

    [Order(18)]
    public class ArmorruneSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(19)]
    public class ArmorruneEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileGfx { get; set; }

        [Order(6)]
        [Size(128)]
        public string FileSfx { get; set; }

        [Order(7)]
        public uint DamageType { get; set; }

        [Order(8)]
        public int Price { get; set; }

        [Order(9)]
        public int ShopPrice { get; set; }

        [Order(10)]
        public int RequirePlayerLevelMin { get; set; }

        [Order(11)]
        public int RequirePlayerLevelMax { get; set; }

        [Order(12)]
        public float DamageReducePercent { get; set; }

        [Order(13)]
        public int DamageReduceTime { get; set; }

        [Order(14)]
        public int PileNumMax { get; set; }

        [Order(15)]
        public uint HasGuid { get; set; }

        [Order(16)]
        public uint ProcType { get; set; }
    }

    [Order(20)]
    public class SkilltomeSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(21)]
    public class SkilltomeEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int PileNumMax { get; set; }

        [Order(8)]
        public uint HasGuid { get; set; }

        [Order(9)]
        public uint ProcType { get; set; }
    }

    [Order(22)]
    public class FlyswordEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int Level { get; set; }

        [Order(8)]
        public int RequirePlayerLevelMin { get; set; }

        [Order(9)]
        public float SpeedIncreaseMin { get; set; }

        [Order(10)]
        public float SpeedIncreaseMax { get; set; }

        [Order(11)]
        public float SpeedRushIncreaseMin { get; set; }

        [Order(12)]
        public float SpeedRushIncreaseMax { get; set; }

        [Order(13)]
        public float TimeMaxMin { get; set; }

        [Order(14)]
        public float TimeMaxMax { get; set; }

        [Order(15)]
        public float TimeIncreasePerElement { get; set; }

        [Order(16)]
        public uint FlyMode { get; set; }

        [Order(17)]
        public uint CharacterComboId { get; set; }

        [Order(18)]
        public uint IdDropAfterDamaged { get; set; }

        [Order(19)]
        public int NumDropAfterDamaged { get; set; }

        [Order(20)]
        public int PileNumMax { get; set; }

        [Order(21)]
        public uint HasGuid { get; set; }

        [Order(22)]
        public uint ProcType { get; set; }
    }

    [Order(23)]
    public class WingmanwingEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int RequirePlayerLevelMin { get; set; }

        [Order(8)]
        public float SpeedIncrease { get; set; }

        [Order(9)]
        public int MpLaunch { get; set; }

        [Order(10)]
        public int MpPerSecond { get; set; }

        [Order(11)]
        public int PileNumMax { get; set; }

        [Order(12)]
        public uint HasGuid { get; set; }

        [Order(13)]
        public uint ProcType { get; set; }
    }

    [Order(24)]
    public class TownscrollEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public float UseTime { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int PileNumMax { get; set; }

        [Order(8)]
        public uint HasGuid { get; set; }

        [Order(9)]
        public uint ProcType { get; set; }
    }

    [Order(25)]
    public class UnionscrollEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public float UseTime { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int PileNumMax { get; set; }

        [Order(8)]
        public uint HasGuid { get; set; }

        [Order(9)]
        public uint ProcType { get; set; }
    }

    [Order(26)]
    public class RevivescrollEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public float UseTime { get; set; }

        [Order(5)]
        public int CoolTime { get; set; }

        [Order(6)]
        public int Price { get; set; }

        [Order(7)]
        public int ShopPrice { get; set; }

        [Order(8)]
        public int PileNumMax { get; set; }

        [Order(9)]
        public uint HasGuid { get; set; }

        [Order(10)]
        public uint ProcType { get; set; }
    }

    [Order(27)]
    public class ElementEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Level { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int PileNumMax { get; set; }

        [Order(8)]
        public uint HasGuid { get; set; }

        [Order(9)]
        public uint ProcType { get; set; }
    }

    [Order(28)]
    public class TaskmatterEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(3)]
        public int PileNumMax { get; set; }

        [Order(4)]
        public uint HasGuid { get; set; }

        [Order(5)]
        public uint ProcType { get; set; }
    }

    [Order(29)]
    public class TossmatterEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileFiregfx { get; set; }

        [Order(6)]
        [Size(128)]
        public string FileHitgfx { get; set; }

        [Order(7)]
        [Size(128)]
        public string FileHitsfx { get; set; }

        [Order(8)]
        public int RequireStrength { get; set; }

        [Order(9)]
        public int RequireAgility { get; set; }

        [Order(10)]
        public int RequireLevel { get; set; }

        [Order(11)]
        public int DamageLow { get; set; }

        [Order(12)]
        public int DamageHighMin { get; set; }

        [Order(13)]
        public int DamageHighMax { get; set; }

        [Order(14)]
        public float UseTime { get; set; }

        [Order(15)]
        public float AttackRange { get; set; }

        [Order(16)]
        public int Price { get; set; }

        [Order(17)]
        public int ShopPrice { get; set; }

        [Order(18)]
        public int PileNumMax { get; set; }

        [Order(19)]
        public uint HasGuid { get; set; }

        [Order(20)]
        public uint ProcType { get; set; }
    }

    [Order(30)]
    public class ProjectileType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(31)]
    public class ProjectileEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint Type { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(6)]
        [Size(128)]
        public string FileFiregfx { get; set; }

        [Order(7)]
        [Size(128)]
        public string FileHitgfx { get; set; }

        [Order(8)]
        [Size(128)]
        public string FileHitsfx { get; set; }

        [Order(9)]
        public int RequireWeaponLevelMin { get; set; }

        [Order(10)]
        public int RequireWeaponLevelMax { get; set; }

        [Order(11)]
        public int DamageEnhance { get; set; }

        [Order(12)]
        public int DamageScaleEnhance { get; set; }

        [Order(13)]
        public int Price { get; set; }

        [Order(14)]
        public int ShopPrice { get; set; }

        [Order(15)]
        public uint IdAddon0 { get; set; }

        [Order(16)]
        public uint IdAddon1 { get; set; }

        [Order(17)]
        public uint IdAddon2 { get; set; }

        [Order(18)]
        public uint IdAddon3 { get; set; }

        [Order(19)]
        public int PileNumMax { get; set; }

        [Order(20)]
        public uint HasGuid { get; set; }

        [Order(21)]
        public uint ProcType { get; set; }
    }

    [Order(32)]
    public class QuiverSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(33)]
    public class QuiverEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public uint IdProjectile { get; set; }

        [Order(6)]
        public int NumMin { get; set; }

        [Order(7)]
        public int NumMax { get; set; }
    }

    [Order(34)]
    public class StoneSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(35)]
    public class StoneEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public int Level { get; set; }

        [Order(6)]
        public int Color { get; set; }

        [Order(7)]
        public int Price { get; set; }

        [Order(8)]
        public int ShopPrice { get; set; }

        [Order(9)]
        public int InstallPrice { get; set; }

        [Order(10)]
        public int UninstallPrice { get; set; }

        [Order(11)]
        public uint IdAddonDamage { get; set; }

        [Order(12)]
        public uint IdAddonDefence { get; set; }

        [Order(13)]
        [Size(16)]
        [NameString]
        public string WeaponDesc { get; set; }

        [Order(14)]
        [Size(16)]
        [NameString]
        public string ArmorDesc { get; set; }

        [Order(15)]
        public int PileNumMax { get; set; }

        [Order(16)]
        public uint HasGuid { get; set; }

        [Order(17)]
        public uint ProcType { get; set; }
    }

    [Order(36)]
    public class MonsterAddon : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int NumParams { get; set; }

        [Order(3)]
        public int Param1 { get; set; }

        [Order(4)]
        public int Param2 { get; set; }

        [Order(5)]
        public int Param3 { get; set; }
    }

    [Order(37)]
    public class MonsterType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(16)]
        public Probability[] Addons { get; set; }
    }

    [Order(38)]
    public class MonsterEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdType { get; set; }

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

        [Order(5)]
        public uint Faction { get; set; }

        [Order(6)]
        public uint MonsterFaction { get; set; }

        [Order(7)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(8)]
        [Size(128)]
        public string FileGfxShort { get; set; }

        [Order(9)]
        [Size(128)]
        public string FileGfxShortHit { get; set; }

        [Order(10)]
        public float Size { get; set; }

        [Order(11)]
        public float DamageDelay { get; set; }

        [Order(12)]
        public uint IdStrategy { get; set; }

        [Order(13)]
        public uint RoleInWar { get; set; }

        [Order(14)]
        public int Level { get; set; }

        [Order(15)]
        public int ShowLevel { get; set; }

        [Order(16)]
        public uint IdPetEggCaptured { get; set; }

        [Order(17)]
        public int Life { get; set; }

        [Order(18)]
        public int Defence { get; set; }

        [Order(19)]
        [Size(5)]
        public int[] MagicDefences { get; set; }

        [Order(20)]
        public uint ImmuneType { get; set; }

        [Order(21)]
        public int Exp { get; set; }

        [Order(22)]
        public int Skillpoint { get; set; }

        [Order(23)]
        public int MoneyAverage { get; set; }

        [Order(24)]
        public int MoneyVar { get; set; }

        [Order(25)]
        public uint ShortRangeMode { get; set; }

        [Order(26)]
        public int SightRange { get; set; }

        [Order(27)]
        public int Attack { get; set; }

        [Order(28)]
        public int Armor { get; set; }

        [Order(29)]
        public int DamageMin { get; set; }

        [Order(30)]
        public int DamageMax { get; set; }

        [Order(31)]
        [Size(5)]
        public (int DamageMin, int DamageMax)[] MagicDamagesExt { get; set; }

        [Order(32)]
        public float AttackRange { get; set; }

        [Order(33)]
        public float AttackSpeed { get; set; }

        [Order(34)]
        public int MagicDamageMin { get; set; }

        [Order(35)]
        public int MagicDamageMax { get; set; }

        [Order(36)]
        public uint IdSkill { get; set; }

        [Order(37)]
        public int SkillLevel { get; set; }

        [Order(38)]
        public int HpRegenerate { get; set; }

        [Order(39)]
        public uint AggressiveMode { get; set; }

        [Order(40)]
        public uint MonsterFactionAskHelp { get; set; }

        [Order(41)]
        public uint MonsterFactionCanHelp { get; set; }

        [Order(42)]
        public float AggroRange { get; set; }

        [Order(43)]
        public float AggroTime { get; set; }

        [Order(44)]
        public uint InhabitType { get; set; }

        [Order(45)]
        public uint PatrollMode { get; set; }

        [Order(46)]
        public uint StandMode { get; set; }

        [Order(47)]
        public float WalkSpeed { get; set; }

        [Order(48)]
        public float RunSpeed { get; set; }

        [Order(49)]
        public float FlySpeed { get; set; }

        [Order(50)]
        public float SwimSpeed { get; set; }

        [Order(51)]
        public int AttackDegree { get; set; }

        [Order(52)]
        public int DefendDegree { get; set; }

        [Order(53)]
        public uint CommonStrategy { get; set; }

        [Order(54)]
        [Size(4)]
        public Probability[] AggroStrategy { get; set; }

        [Order(55)]
        [Size(5)]
        public (uint IdSkill, int Level, float Probability)[] SkillHp75 { get; set; }

        [Order(56)]
        [Size(5)]
        public (uint IdSkill, int Level, float Probability)[] SkillHp50 { get; set; }

        [Order(57)]
        [Size(5)]
        public (uint IdSkill, int Level, float Probability)[] SkillHp25 { get; set; }

        [Order(58)]
        public uint AfterDeath { get; set; }

        [Order(59)]
        [Size(32)]
        public (uint IdSkill, int Level)[] Skills { get; set; }

        [Order(60)]
        public float ProbabilityDropNum0 { get; set; }

        [Order(61)]
        public float ProbabilityDropNum1 { get; set; }

        [Order(62)]
        public float ProbabilityDropNum2 { get; set; }

        [Order(63)]
        public float ProbabilityDropNum3 { get; set; }

        [Order(64)]
        public int DropTimes { get; set; }

        [Order(65)]
        public int DropProtected { get; set; }

        [Order(66)]
        [Size(32)]
        public Probability[] DropMatters { get; set; }

        [Order(67)]
        public uint HighestFrequency { get; set; }

        [Order(68)]
        public int NoAcceptPlayerBuff { get; set; }

        [Order(69)]
        public int InvisibleLvl { get; set; }

        [Order(70)]
        public int UninvisibleLvl { get; set; }

        [Order(71)]
        public int NoAutoFight { get; set; }

        [Order(72)]
        public int FixedDirection { get; set; }

        [Order(73)]
        public uint IdBuilding { get; set; }

        [Order(74)]
        public uint CombinedSwitch { get; set; }

        [Order(75)]
        public int HpAdjustCommonValue { get; set; }

        [Order(76)]
        public int DefenceAdjustCommonValue { get; set; }

        [Order(77)]
        public int AttackAdjustCommonValue { get; set; }
    }

    [Order(39)]
    public class NpcTalkService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint IdDialog { get; set; }
    }

    [Order(40)]
    public class NpcSellService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(8)]
        public PagesClass[] Pages { get; set; }

        [Order(3)]
        public uint IdDialog { get; set; }

        public class PagesClass
        {
            [Order(0)]
            [Size(8)]
            [NameString]
            public string PageTitle { get; set; }

            [Order(1)]
            public int RequireContrib { get; set; }

            [Order(2)]
            [Size(32)]
            public (uint Id, int ContribCost)[] Goods { get; set; }
        }

    }

    [Order(41)]
    public class NpcBuyService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint IdDialog { get; set; }
    }

    [Order(42)]
    public class NpcRepairService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint IdDialog { get; set; }
    }

    [Order(43)]
    public class NpcInstallService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(32)]
        public uint[] IdGoods { get; set; }

        [Order(3)]
        public uint IdDialog { get; set; }
    }

    [Order(44)]
    public class NpcUninstallService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(32)]
        public uint[] IdGoods { get; set; }

        [Order(3)]
        public uint IdDialog { get; set; }
    }

    [Order(45)]
    public class NpcTaskInService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(256)]
        public uint[] IdTasks { get; set; }
    }

    [Order(46)]
    public class NpcTaskOutService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint StorageId { get; set; }

        [Order(3)]
        public uint StorageOpenItem { get; set; }

        [Order(4)]
        public uint StorageRefreshItem { get; set; }

        [Order(5)]
        public int StorageRefreshPerDay { get; set; }

        [Order(6)]
        public int StorageRefreshCountMin { get; set; }

        [Order(7)]
        public int StorageRefreshCountMax { get; set; }

        [Order(8)]
        [Size(256)]
        public uint[] IdTasks { get; set; }
    }

    [Order(47)]
    public class NpcTaskMatterService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(16)]
        public TasksClass[] Tasks { get; set; }

        public class TasksClass
        {
            [Order(0)]
            public uint IdTask { get; set; }

            [Order(1)]
            [Size(4)]
            public (uint IdMatter, int NumMatter)[] TaksMatters { get; set; }
        }

    }

    [Order(48)]
    public class NpcSkillService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public uint[] IdSkills { get; set; }

        [Order(3)]
        public uint IdDialog { get; set; }
    }

    [Order(49)]
    public class NpcHealService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint IdDialog { get; set; }
    }

    [Order(50)]
    public class NpcTransmitService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int NumTargets { get; set; }

        [Order(3)]
        [Size(32)]
        public (int Idtarget, int Fee, int RequiredLevel)[] Targets { get; set; }

        [Order(4)]
        public uint IdDialog { get; set; }
    }

    [Order(51)]
    public class NpcTransportService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(32)]
        public (uint Id, uint Fee)[] Routes { get; set; }

        [Order(3)]
        public uint IdDialog { get; set; }
    }

    [Order(52)]
    public class NpcProxyService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint IdDialog { get; set; }
    }

    [Order(53)]
    public class NpcStorageService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(54)]
    public class NpcMakeService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint IdMakeSkill { get; set; }

        [Order(3)]
        public int ProduceType { get; set; }

        [Order(4)]
        [Size(8)]
        public PagesClass[] Pages { get; set; }

        public class PagesClass
        {
            [Order(0)]
            [Size(8)]
            [NameString]
            public string PageTitle { get; set; }

            [Order(1)]
            [Size(32)]
            public uint[] IdGoods { get; set; }
        }

    }

    [Order(55)]
    public class NpcDecomposeService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint IdDecomposeSkill { get; set; }
    }

    [Order(56)]
    public class NpcType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(57)]
    public class NpcEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint IdType { get; set; }

        [Order(3)]
        public float RefreshTime { get; set; }

        [Order(4)]
        public uint AttackRule { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(6)]
        public float TaxRate { get; set; }

        [Order(7)]
        public uint IdSrcMonster { get; set; }

        [Order(8)]
        [Size(256)]
        [NameString]
        public string HelloMsg { get; set; }

        [Order(9)]
        public uint IdToDiscover { get; set; }

        [Order(10)]
        public uint DomainRelated { get; set; }

        [Order(11)]
        public uint IdTalkService { get; set; }

        [Order(12)]
        public uint IdSellService { get; set; }

        [Order(13)]
        public uint IdBuyService { get; set; }

        [Order(14)]
        public uint IdRepairService { get; set; }

        [Order(15)]
        public uint IdInstallService { get; set; }

        [Order(16)]
        public uint IdUninstallService { get; set; }

        [Order(17)]
        public uint IdTaskOutService { get; set; }

        [Order(18)]
        public uint IdTaskInService { get; set; }

        [Order(19)]
        public uint IdTaskMatterService { get; set; }

        [Order(20)]
        public uint IdSkillService { get; set; }

        [Order(21)]
        public uint IdHealService { get; set; }

        [Order(22)]
        public uint IdTransmitService { get; set; }

        [Order(23)]
        public uint IdTransportService { get; set; }

        [Order(24)]
        public uint IdProxyService { get; set; }

        [Order(25)]
        public uint IdStorageService { get; set; }

        [Order(26)]
        public uint IdMakeService { get; set; }

        [Order(27)]
        public uint IdDecomposeService { get; set; }

        [Order(28)]
        public uint IdIdentifyService { get; set; }

        [Order(29)]
        public uint IdWarTowerbuildService { get; set; }

        [Order(30)]
        public uint IdResetpropService { get; set; }

        [Order(31)]
        public uint IdPetnameService { get; set; }

        [Order(32)]
        public uint IdPetlearnskillService { get; set; }

        [Order(33)]
        public uint IdPetforgetskillService { get; set; }

        [Order(34)]
        public uint IdEquipbindService { get; set; }

        [Order(35)]
        public uint IdEquipdestroyService { get; set; }

        [Order(36)]
        public uint IdEquipundestroyService { get; set; }

        [Order(37)]
        public uint IdGoblinSkillService { get; set; }

        [Order(38)]
        public uint CombinedServices { get; set; }

        [Order(39)]
        public uint IdMine { get; set; }

        [Order(40)]
        public uint NoCollision { get; set; }

        [Order(41)]
        public uint IdEngraveService { get; set; }

        [Order(42)]
        public uint IdRandpropService { get; set; }
    }

    [Order(58)]
    public class FaceTextureEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileBaseTex { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileHighTex { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public uint TexPartId { get; set; }

        [Order(6)]
        public uint CharacterComboId { get; set; }

        [Order(7)]
        public uint GenderId { get; set; }

        [Order(8)]
        public uint VisualizeId { get; set; }

        [Order(9)]
        public uint UserData { get; set; }

        [Order(10)]
        public uint FacepillOnly { get; set; }

        [Order(11)]
        public uint FashionHeadOnly { get; set; }
    }

    [Order(59)]
    public class FaceShapeEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileShape { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public uint ShapePartId { get; set; }

        [Order(5)]
        public uint CharacterComboId { get; set; }

        [Order(6)]
        public uint GenderId { get; set; }

        [Order(7)]
        public uint VisualizeId { get; set; }

        [Order(8)]
        public uint UserData { get; set; }

        [Order(9)]
        public uint FacepillOnly { get; set; }
    }

    [Order(60)]
    public class FaceEmotionType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileIcon { get; set; }
    }

    [Order(61)]
    public class FaceExpressionEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileExpression { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public uint CharacterComboId { get; set; }

        [Order(5)]
        public uint GenderId { get; set; }

        [Order(6)]
        public uint EmotionId { get; set; }
    }

    [Order(62)]
    public class FaceHairEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileHairSkin { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileHairModel { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public uint CharacterComboId { get; set; }

        [Order(6)]
        public uint GenderId { get; set; }

        [Order(7)]
        public uint VisualizeId { get; set; }

        [Order(8)]
        public uint FacepillOnly { get; set; }

        [Order(9)]
        public uint FashionHeadOnly { get; set; }
    }

    [Order(63)]
    public class FaceMoustacheEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMoustacheSkin { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public uint CharacterComboId { get; set; }

        [Order(5)]
        public uint GenderId { get; set; }

        [Order(6)]
        public uint VisualizeId { get; set; }

        [Order(7)]
        public uint FacepillOnly { get; set; }
    }

    [Order(64)]
    public class ColorpickerEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileColorpicker { get; set; }

        [Order(3)]
        public uint ColorPartId { get; set; }

        [Order(4)]
        public uint CharacterComboId { get; set; }

        [Order(5)]
        public uint GenderId { get; set; }
    }

    [Order(65)]
    public class CustomizedataEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileData { get; set; }

        [Order(3)]
        public uint CharacterComboId { get; set; }

        [Order(4)]
        public uint GenderId { get; set; }
    }

    [Order(66)]
    public class RecipeMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(67)]
    public class RecipeSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(68)]
    public class RecipeEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        public int RecipeLevel { get; set; }

        [Order(5)]
        public uint IdSkill { get; set; }

        [Order(6)]
        public int SkillLevel { get; set; }

        [Order(7)]
        public int BindType { get; set; }

        [Order(8)]
        [Size(4)]
        public Probability[] Targets { get; set; }

        [Order(9)]
        public float FailProbability { get; set; }

        [Order(10)]
        public int NumToMake { get; set; }

        [Order(11)]
        public int Price { get; set; }

        [Order(12)]
        public float Duration { get; set; }

        [Order(13)]
        public int Exp { get; set; }

        [Order(14)]
        public int Skillpoint { get; set; }

        [Order(15)]
        [Size(32)]
        public (uint Id, int Num)[] Materials { get; set; }

        [Order(16)]
        public uint IdUpgradeEquip { get; set; }

        [Order(17)]
        public float UpgradeRate { get; set; }

        [Order(18)]
        public uint ProcType { get; set; }
    }

    [Order(69)]
    public class EnemyFactionConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(32)]
        public uint[] EnemyFactions { get; set; }
    }

    [Order(70)]
    public class CharracterClassConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint CharacterClassId { get; set; }

        [Order(3)]
        public uint Faction { get; set; }

        [Order(4)]
        public uint EnemyFaction { get; set; }

        [Order(5)]
        public float AttackSpeed { get; set; }

        [Order(6)]
        public float AttackRange { get; set; }

        [Order(7)]
        public int HpGen { get; set; }

        [Order(8)]
        public int MpGen { get; set; }

        [Order(9)]
        public float WalkSpeed { get; set; }

        [Order(10)]
        public float RunSpeed { get; set; }

        [Order(11)]
        public float SwimSpeed { get; set; }

        [Order(12)]
        public float FlySpeed { get; set; }

        [Order(13)]
        public int CritRate { get; set; }

        [Order(14)]
        public int VitHp { get; set; }

        [Order(15)]
        public int EngMp { get; set; }

        [Order(16)]
        public int AgiAttack { get; set; }

        [Order(17)]
        public int AgiArmor { get; set; }

        [Order(18)]
        public int LvlupHp { get; set; }

        [Order(19)]
        public int LvlupMp { get; set; }

        [Order(20)]
        public float LvlupDmg { get; set; }

        [Order(21)]
        public float LvlupMagic { get; set; }

        [Order(22)]
        public float LvlupDefense { get; set; }

        [Order(23)]
        public float LvlupMagicdefence { get; set; }

        [Order(24)]
        public int AngroIncrease { get; set; }
    }

    [Order(71)]
    public class ParamAdjustConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(16)]
        public LevelDiffAdjustClass[] LevelDiffAdjust { get; set; }

        [Order(3)]
        [Size(11)]
        public (float AdjustExp, float AdjustSp)[] TeamAdjust { get; set; }

        [Order(4)]
        [Size(11)]
        public (float AdjustExp, float AdjustSp)[] TeamProfessionAdjust { get; set; }

        public class LevelDiffAdjustClass
        {
            [Order(0)]
            public int LevelDiff { get; set; }

            [Order(1)]
            public float AdjustExp { get; set; }

            [Order(2)]
            public float AdjustSp { get; set; }

            [Order(3)]
            public float AdjustMoney { get; set; }

            [Order(4)]
            public float AdjustMatter { get; set; }

            [Order(5)]
            public float AdjustAttack { get; set; }
        }

    }

    [Order(72)]
    public class PlayerActionInfoConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(32)]
        public string ActionName { get; set; }

        [Order(3)]
        [Size(32)]
        public string ActionPrefix { get; set; }

        [Order(4)]
        [Size(13)]
        public ActionWeaponSuffixClass[] ActionWeaponSuffix { get; set; }

        [Order(5)]
        public uint HideWeapon { get; set; }

        public class ActionWeaponSuffixClass
        {
            [Order(0)]
            [Size(32)]
            public string Suffix { get; set; }
        }

    }

    [Order(73)]
    public class TaskdiceEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        [Size(8)]
        public Probability[] TaskLists { get; set; }

        [Order(5)]
        public uint UseOnPick { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(74)]
    public class TasknormalmatterEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Price { get; set; }

        [Order(5)]
        public int ShopPrice { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(75)]
    public class FaceFalingEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileFalingSkin { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public uint CharacterComboId { get; set; }

        [Order(5)]
        public uint GenderId { get; set; }

        [Order(6)]
        public uint VisualizeId { get; set; }

        [Order(7)]
        public uint FacepillOnly { get; set; }
    }

    [Order(76)]
    public class PlayerLevelexpConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(150)]
        public int[] Exp { get; set; }
    }

    [Order(77)]
    public class MineType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(78)]
    public class MineEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        public uint Level { get; set; }

        [Order(4)]
        public uint LevelRequired { get; set; }

        [Order(5)]
        public uint IdEquipmentRequired { get; set; }

        [Order(6)]
        public uint EliminateTool { get; set; }

        [Order(7)]
        public uint TimeMin { get; set; }

        [Order(8)]
        public uint TimeMax { get; set; }

        [Order(9)]
        public int Exp { get; set; }

        [Order(10)]
        public int Skillpoint { get; set; }

        [Order(11)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(12)]
        [Size(16)]
        public Probability[] Materials { get; set; }

        [Order(13)]
        public int Num1 { get; set; }

        [Order(14)]
        public float Probability1 { get; set; }

        [Order(15)]
        public int Num2 { get; set; }

        [Order(16)]
        public float Probability2 { get; set; }

        [Order(17)]
        public uint TaskIn { get; set; }

        [Order(18)]
        public uint TaskOut { get; set; }

        [Order(19)]
        public uint Uninterruptable { get; set; }

        [Order(20)]
        [Size(4)]
        public (uint IdMonster, int Num, float Radius)[] Npcgen { get; set; }

        [Order(21)]
        [Size(1)]
        public (uint MonsterFaction, float Radius, int Num)[] Aggros { get; set; }

        [Order(22)]
        public uint Permenent { get; set; }
    }

    [Order(79)]
    public class NpcIdentifyService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int Fee { get; set; }
    }

    [Order(80)]
    public class FashionMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(81)]
    public class FashionSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public uint EquipFashionMask { get; set; }
    }

    [Order(82)]
    public class FashionEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        [Size(32)]
        public string Realname { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(6)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(7)]
        public uint EquipLocation { get; set; }

        [Order(8)]
        public int Level { get; set; }

        [Order(9)]
        public int RequireLevel { get; set; }

        [Order(10)]
        public int RequireDyeCount { get; set; }

        [Order(11)]
        public int Price { get; set; }

        [Order(12)]
        public int ShopPrice { get; set; }

        [Order(13)]
        public int Gender { get; set; }

        [Order(14)]
        public uint IdHair { get; set; }

        [Order(15)]
        public uint IdHairTexture { get; set; }

        [Order(16)]
        public int PileNumMax { get; set; }

        [Order(17)]
        public uint HasGuid { get; set; }

        [Order(18)]
        public uint ProcType { get; set; }

        [Order(19)]
        [Size(32)]
        public string WearAction { get; set; }
    }

    [Order(83)]
    public class FaceticketMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(84)]
    public class FaceticketSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(85)]
    public class FaceticketEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(6)]
        public int RequireLevel { get; set; }

        [Order(7)]
        [Size(128)]
        public string BoundFile { get; set; }

        [Order(8)]
        public uint Unsymmetrical { get; set; }

        [Order(9)]
        public int Price { get; set; }

        [Order(10)]
        public int ShopPrice { get; set; }

        [Order(11)]
        public int PileNumMax { get; set; }

        [Order(12)]
        public uint HasGuid { get; set; }

        [Order(13)]
        public uint ProcType { get; set; }
    }

    [Order(86)]
    public class FacepillMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(87)]
    public class FacepillSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(88)]
    public class FacepillEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(6)]
        public int Duration { get; set; }

        [Order(7)]
        public float CameraScale { get; set; }

        [Order(8)]
        public uint CharacterComboId { get; set; }

        [Order(9)]
        [Size(20)]
        public PllfilesClass[] Pllfiles { get; set; }

        [Order(10)]
        public int Price { get; set; }

        [Order(11)]
        public int ShopPrice { get; set; }

        [Order(12)]
        public int PileNumMax { get; set; }

        [Order(13)]
        public uint HasGuid { get; set; }

        [Order(14)]
        public uint ProcType { get; set; }

        public class PllfilesClass
        {
            [Order(0)]
            [Size(128)]
            public string File { get; set; }
        }

    }

    [Order(89)]
    public class SuiteEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int MaxEquips { get; set; }

        [Order(3)]
        [Size(12)]
        public uint[] Equipments { get; set; }

        [Order(4)]
        [Size(11)]
        public uint[] Addons { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileGfx { get; set; }
    }

    [Order(90)]
    public class GmGeneratorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(91)]
    public class GmGeneratorEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public uint IdObject { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(92)]
    public class PetType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(93)]
    public class PetEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public uint CharacterComboId { get; set; }

        [Order(6)]
        public int LevelMax { get; set; }

        [Order(7)]
        public int LevelRequire { get; set; }

        [Order(8)]
        public uint PetSndType { get; set; }

        [Order(9)]
        public float HpA { get; set; }

        [Order(10)]
        public float HpB { get; set; }

        [Order(11)]
        public float HpC { get; set; }

        [Order(12)]
        public float HpGenA { get; set; }

        [Order(13)]
        public float HpGenB { get; set; }

        [Order(14)]
        public float HpGenC { get; set; }

        [Order(15)]
        public float DamageA { get; set; }

        [Order(16)]
        public float DamageB { get; set; }

        [Order(17)]
        public float DamageC { get; set; }

        [Order(18)]
        public float DamageD { get; set; }

        [Order(19)]
        public float SpeedA { get; set; }

        [Order(20)]
        public float SpeedB { get; set; }

        [Order(21)]
        public float AttackA { get; set; }

        [Order(22)]
        public float AttackB { get; set; }

        [Order(23)]
        public float AttackC { get; set; }

        [Order(24)]
        public float ArmorA { get; set; }

        [Order(25)]
        public float ArmorB { get; set; }

        [Order(26)]
        public float ArmorC { get; set; }

        [Order(27)]
        public float PhysicDefenceA { get; set; }

        [Order(28)]
        public float PhysicDefenceB { get; set; }

        [Order(29)]
        public float PhysicDefenceC { get; set; }

        [Order(30)]
        public float PhysicDefenceD { get; set; }

        [Order(31)]
        public float MagicDefenceA { get; set; }

        [Order(32)]
        public float MagicDefenceB { get; set; }

        [Order(33)]
        public float MagicDefenceC { get; set; }

        [Order(34)]
        public float MagicDefenceD { get; set; }

        [Order(35)]
        public float MpA { get; set; }

        [Order(36)]
        public float MpGenA { get; set; }

        [Order(37)]
        public float AttackDegreeA { get; set; }

        [Order(38)]
        public float DefenceDegreeA { get; set; }

        [Order(39)]
        public float Size { get; set; }

        [Order(40)]
        public float DamageDelay { get; set; }

        [Order(41)]
        public float AttackRange { get; set; }

        [Order(42)]
        public float AttackSpeed { get; set; }

        [Order(43)]
        public int SightRange { get; set; }

        [Order(44)]
        public uint FoodMask { get; set; }

        [Order(45)]
        public uint InhabitType { get; set; }

        [Order(46)]
        public uint StandMode { get; set; }

        [Order(47)]
        public uint PlantGroup { get; set; }

        [Order(48)]
        public int GroupLimit { get; set; }

        [Order(49)]
        public uint ImmuneType { get; set; }

        [Order(50)]
        public int PlayerGainSkill { get; set; }

        [Order(51)]
        public int RequireDyeCount { get; set; }
    }

    [Order(94)]
    public class PetEggEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int IdPet { get; set; }

        [Order(5)]
        public int MoneyHatched { get; set; }

        [Order(6)]
        public int MoneyRestored { get; set; }

        [Order(7)]
        public int HonorPoint { get; set; }

        [Order(8)]
        public int Level { get; set; }

        [Order(9)]
        public int Exp { get; set; }

        [Order(10)]
        public int SkillPoint { get; set; }

        [Order(11)]
        [Size(32)]
        public (int IdSkill, int Level)[] Skills { get; set; }

        [Order(12)]
        public int Price { get; set; }

        [Order(13)]
        public int ShopPrice { get; set; }

        [Order(14)]
        public int PileNumMax { get; set; }

        [Order(15)]
        public uint HasGuid { get; set; }

        [Order(16)]
        public uint ProcType { get; set; }
    }

    [Order(95)]
    public class PetFoodEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Level { get; set; }

        [Order(5)]
        public int Hornor { get; set; }

        [Order(6)]
        public int Exp { get; set; }

        [Order(7)]
        public int FoodType { get; set; }

        [Order(8)]
        public int Price { get; set; }

        [Order(9)]
        public int ShopPrice { get; set; }

        [Order(10)]
        public int PileNumMax { get; set; }

        [Order(11)]
        public uint HasGuid { get; set; }

        [Order(12)]
        public uint ProcType { get; set; }
    }

    [Order(96)]
    public class PetFaceticketEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Price { get; set; }

        [Order(5)]
        public int ShopPrice { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(97)]
    public class FireworksEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileFw { get; set; }

        [Order(5)]
        public int Level { get; set; }

        [Order(6)]
        public int TimeToFire { get; set; }

        [Order(7)]
        public int Price { get; set; }

        [Order(8)]
        public int ShopPrice { get; set; }

        [Order(9)]
        public int PileNumMax { get; set; }

        [Order(10)]
        public uint HasGuid { get; set; }

        [Order(11)]
        public uint ProcType { get; set; }
    }

    [Order(98)]
    public class WarTankcallinEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Price { get; set; }

        [Order(5)]
        public int ShopPrice { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(99)]
    public class NpcWarTowerbuildService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(4)]
        public BuildInfoClass[] BuildInfo { get; set; }

        public class BuildInfoClass
        {
            [Order(0)]
            public int IdInBuild { get; set; }

            [Order(1)]
            public int IdBuildup { get; set; }

            [Order(2)]
            public int IdObjectNeed { get; set; }

            [Order(3)]
            public int TimeUse { get; set; }

            [Order(4)]
            public int Fee { get; set; }
        }

    }

    [Order(100)]
    public class PlayerSecondlevelConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(256)]
        public float[] ExpLost { get; set; }
    }

    [Order(101)]
    public class NpcResetpropService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(15)]
        public PropEntryClass[] PropEntry { get; set; }

        public class PropEntryClass
        {
            [Order(0)]
            public int IdObjectNeed { get; set; }

            [Order(1)]
            public int StrengthDelta { get; set; }

            [Order(2)]
            public int AgilityDelta { get; set; }

            [Order(3)]
            public int VitalDelta { get; set; }

            [Order(4)]
            public int EnergyDelta { get; set; }
        }

    }

    [Order(102)]
    public class NpcPetnameService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int IdObjectNeed { get; set; }

        [Order(3)]
        public int Price { get; set; }
    }

    [Order(103)]
    public class NpcPetlearnskillService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public uint[] IdSkills { get; set; }

        [Order(3)]
        public uint IdDialog { get; set; }
    }

    [Order(104)]
    public class NpcPetforgetskillService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int IdObjectNeed { get; set; }

        [Order(3)]
        public int Price { get; set; }
    }

    [Order(105)]
    public class SkillmatterEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int LevelRequired { get; set; }

        [Order(5)]
        public int IdSkill { get; set; }

        [Order(6)]
        public int LevelSkill { get; set; }

        [Order(7)]
        public int Price { get; set; }

        [Order(8)]
        public int ShopPrice { get; set; }

        [Order(9)]
        public int PileNumMax { get; set; }

        [Order(10)]
        public uint HasGuid { get; set; }

        [Order(11)]
        public uint ProcType { get; set; }
    }

    [Order(106)]
    public class RefineTicketEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        [Size(16)]
        [NameString]
        public string Desc { get; set; }

        [Order(5)]
        public float ExtReservedProb { get; set; }

        [Order(6)]
        public float ExtSucceedProb { get; set; }

        [Order(7)]
        public uint FailReserveLevel { get; set; }

        [Order(8)]
        [Size(12)]
        public float[] FailExtSucceedProb { get; set; }

        [Order(9)]
        public int Price { get; set; }

        [Order(10)]
        public int ShopPrice { get; set; }

        [Order(11)]
        public int PileNumMax { get; set; }

        [Order(12)]
        public uint HasGuid { get; set; }

        [Order(13)]
        public uint ProcType { get; set; }
    }

    [Order(107)]
    public class DestroyingEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Price { get; set; }

        [Order(5)]
        public int ShopPrice { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(108)]
    public class NpcEquipbindService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int IdObjectNeed { get; set; }

        [Order(3)]
        public int Price { get; set; }

        [Order(4)]
        public uint BindType { get; set; }
    }

    [Order(109)]
    public class NpcEquipdestroyService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int IdObjectNeed { get; set; }

        [Order(3)]
        public int Price { get; set; }
    }

    [Order(110)]
    public class NpcEquipundestroyService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int IdObjectNeed { get; set; }

        [Order(3)]
        public int Price { get; set; }
    }

    [Order(111)]
    public class BibleEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        [Size(10)]
        public uint[] IdAddons { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public uint IdDropAfterDamaged { get; set; }

        [Order(8)]
        public int NumDropAfterDamaged { get; set; }

        [Order(9)]
        public int PileNumMax { get; set; }

        [Order(10)]
        public uint HasGuid { get; set; }

        [Order(11)]
        public uint ProcType { get; set; }
    }

    [Order(112)]
    public class SpeakerEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int IdIconSet { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int PileNumMax { get; set; }

        [Order(8)]
        public uint HasGuid { get; set; }

        [Order(9)]
        public uint ProcType { get; set; }
    }

    [Order(113)]
    public class AutohpEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int TotalHp { get; set; }

        [Order(5)]
        public float TriggerAmount { get; set; }

        [Order(6)]
        public int CoolTime { get; set; }

        [Order(7)]
        public int Price { get; set; }

        [Order(8)]
        public int ShopPrice { get; set; }

        [Order(9)]
        public int PileNumMax { get; set; }

        [Order(10)]
        public uint HasGuid { get; set; }

        [Order(11)]
        public uint ProcType { get; set; }
    }

    [Order(114)]
    public class AutompEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int TotalMp { get; set; }

        [Order(5)]
        public float TriggerAmount { get; set; }

        [Order(6)]
        public int CoolTime { get; set; }

        [Order(7)]
        public int Price { get; set; }

        [Order(8)]
        public int ShopPrice { get; set; }

        [Order(9)]
        public int PileNumMax { get; set; }

        [Order(10)]
        public uint HasGuid { get; set; }

        [Order(11)]
        public uint ProcType { get; set; }
    }

    [Order(115)]
    public class DoubleExpEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int DoubleExpTime { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int PileNumMax { get; set; }

        [Order(8)]
        public uint HasGuid { get; set; }

        [Order(9)]
        public uint ProcType { get; set; }
    }

    [Order(116)]
    public class TransmitscrollEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Price { get; set; }

        [Order(5)]
        public int ShopPrice { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(117)]
    public class DyeTicketEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public float HMin { get; set; }

        [Order(5)]
        public float HMax { get; set; }

        [Order(6)]
        public float SMin { get; set; }

        [Order(7)]
        public float SMax { get; set; }

        [Order(8)]
        public float VMin { get; set; }

        [Order(9)]
        public float VMax { get; set; }

        [Order(10)]
        public int Price { get; set; }

        [Order(11)]
        public int ShopPrice { get; set; }

        [Order(12)]
        public int PileNumMax { get; set; }

        [Order(13)]
        public uint HasGuid { get; set; }

        [Order(14)]
        public uint ProcType { get; set; }
    }

    [Order(118)]
    public class GoblinEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileModel1 { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileModel2 { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileModel3 { get; set; }

        [Order(5)]
        [Size(128)]
        public string FileModel4 { get; set; }

        [Order(6)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(7)]
        [Size(128)]
        public string FileIcon1 { get; set; }

        [Order(8)]
        [Size(128)]
        public string FileIcon2 { get; set; }

        [Order(9)]
        [Size(128)]
        public string FileIcon3 { get; set; }

        [Order(10)]
        [Size(128)]
        public string FileIcon4 { get; set; }

        [Order(11)]
        public float ExpFactor { get; set; }

        [Order(12)]
        public int InitStrength { get; set; }

        [Order(13)]
        public int InitAgility { get; set; }

        [Order(14)]
        public int InitEnergy { get; set; }

        [Order(15)]
        public int InitTili { get; set; }

        [Order(16)]
        public int MaxRefineLvl { get; set; }

        [Order(17)]
        public int Price { get; set; }

        [Order(18)]
        public int ShopPrice { get; set; }

        [Order(19)]
        public int DefaultSkill1 { get; set; }

        [Order(20)]
        public int DefaultSkill2 { get; set; }

        [Order(21)]
        public int DefaultSkill3 { get; set; }

        [Order(22)]
        [Size(10)]
        public (int RandNum, float RandRate)[] RandProp { get; set; }

        [Order(23)]
        public int PileNumMax { get; set; }

        [Order(24)]
        public uint HasGuid { get; set; }

        [Order(25)]
        public uint ProcType { get; set; }
    }

    [Order(119)]
    public class GoblinEquipType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(120)]
    public class GoblinEquipEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileModel { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public int EquipType { get; set; }

        [Order(6)]
        public int ReqGoblinLevel { get; set; }

        [Order(7)]
        public int Strength { get; set; }

        [Order(8)]
        public int Agility { get; set; }

        [Order(9)]
        public int Energy { get; set; }

        [Order(10)]
        public int Tili { get; set; }

        [Order(11)]
        [Size(5)]
        public int[] Magic { get; set; }

        [Order(12)]
        public int Price { get; set; }

        [Order(13)]
        public int ShopPrice { get; set; }

        [Order(14)]
        public int PileNumMax { get; set; }

        [Order(15)]
        public uint HasGuid { get; set; }

        [Order(16)]
        public uint ProcType { get; set; }
    }

    [Order(121)]
    public class GoblinExppillEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public uint Exp { get; set; }

        [Order(5)]
        public int Level { get; set; }

        [Order(6)]
        public int Price { get; set; }

        [Order(7)]
        public int ShopPrice { get; set; }

        [Order(8)]
        public int PileNumMax { get; set; }

        [Order(9)]
        public uint HasGuid { get; set; }

        [Order(10)]
        public uint ProcType { get; set; }
    }

    [Order(122)]
    public class SellCertificateEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string ShowModel { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public uint NumSellItem { get; set; }

        [Order(6)]
        public uint NumBuyItem { get; set; }

        [Order(7)]
        public uint MaxNameLength { get; set; }

        [Order(8)]
        public int Price { get; set; }

        [Order(9)]
        public int ShopPrice { get; set; }

        [Order(10)]
        public int PileNumMax { get; set; }

        [Order(11)]
        public uint HasGuid { get; set; }

        [Order(12)]
        public uint ProcType { get; set; }
    }

    [Order(123)]
    public class TargetItemEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int NumUsePertime { get; set; }

        [Order(5)]
        public int NumArea { get; set; }

        [Order(6)]
        [Size(10)]
        public int[] AreaId { get; set; }

        [Order(7)]
        public uint IdSkill { get; set; }

        [Order(8)]
        public int SkillLevel { get; set; }

        [Order(9)]
        public int UseInCombat { get; set; }

        [Order(10)]
        public int Price { get; set; }

        [Order(11)]
        public int ShopPrice { get; set; }

        [Order(12)]
        public int PileNumMax { get; set; }

        [Order(13)]
        public uint HasGuid { get; set; }

        [Order(14)]
        public uint ProcType { get; set; }
    }

    [Order(124)]
    public class LookInfoEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Price { get; set; }

        [Order(5)]
        public int ShopPrice { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(125)]
    public class UpgradeProductionConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(12)]
        public int[] NumRefine { get; set; }

        [Order(3)]
        [Size(40)]
        public int[] NumWeapon { get; set; }

        [Order(4)]
        [Size(80)]
        public int[] NumArmor { get; set; }

        [Order(5)]
        [Size(20)]
        public int[] NumStone { get; set; }
    }

    [Order(126)]
    public class AccStorageBlacklistConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(512)]
        public uint[] Blacklist { get; set; }
    }

    [Order(127)]
    public class FaceHairTextureMap : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public (int ModelId, int TextureId)[] HairTextureMap { get; set; }
    }

    [Order(128)]
    public class MultiExpConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(20)]
        public ChoiceClass[] Choice { get; set; }

        public class ChoiceClass
        {
            [Order(0)]
            public int MultiTime { get; set; }

            [Order(1)]
            public float Rate { get; set; }

            [Order(2)]
            public int ItemCount { get; set; }

            [Order(3)]
            public int DemultiWaitTime { get; set; }

            [Order(4)]
            public int DemultiTime { get; set; }
        }

    }

    [Order(129)]
    public class IncSkillAbilityEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int IdSkill { get; set; }

        [Order(5)]
        public int LevelRequired { get; set; }

        [Order(6)]
        public float IncRatio { get; set; }

        [Order(7)]
        public int Price { get; set; }

        [Order(8)]
        public int ShopPrice { get; set; }

        [Order(9)]
        public int PileNumMax { get; set; }

        [Order(10)]
        public uint HasGuid { get; set; }

        [Order(11)]
        public uint ProcType { get; set; }
    }

    [Order(130)]
    public class GodEvilConvertConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(256)]
        public int[] SkillMap { get; set; }
    }

    [Order(131)]
    public class WeddingConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(10)]
        public WeddingSessionClass[] WeddingSession { get; set; }

        [Order(3)]
        [Size(20)]
        public (int Year, int Month, int Day)[] ReservedDay { get; set; }

        [Order(4)]
        [Size(10)]
        public WeddingSceneClass[] WeddingScene { get; set; }

        public class WeddingSessionClass
        {
            [Order(0)]
            public int StartHour { get; set; }

            [Order(1)]
            public int StartMin { get; set; }

            [Order(2)]
            public int EndHour { get; set; }

            [Order(3)]
            public int EndMin { get; set; }
        }
        public class WeddingSceneClass
        {
            [Order(0)]
            [Size(16)]
            [NameString]
            public string Name { get; set; }

            [Order(1)]
            [Size(3)]
            public float[] Pos { get; set; }
        }

    }

    [Order(132)]
    public class WeddingBookcardEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Year { get; set; }

        [Order(5)]
        public int Month { get; set; }

        [Order(6)]
        public int Day { get; set; }

        [Order(7)]
        public int Price { get; set; }

        [Order(8)]
        public int ShopPrice { get; set; }

        [Order(9)]
        public int PileNumMax { get; set; }

        [Order(10)]
        public uint HasGuid { get; set; }

        [Order(11)]
        public uint ProcType { get; set; }
    }

    [Order(133)]
    public class WeddingInvitecardEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Price { get; set; }

        [Order(5)]
        public int ShopPrice { get; set; }

        [Order(6)]
        public int PileNumMax { get; set; }

        [Order(7)]
        public uint HasGuid { get; set; }

        [Order(8)]
        public uint ProcType { get; set; }
    }

    [Order(134)]
    public class SharpenerEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Level { get; set; }

        [Order(5)]
        public uint EquipMask { get; set; }

        [Order(6)]
        [Size(3)]
        public int[] Addon { get; set; }

        [Order(7)]
        public int AddonTime { get; set; }

        [Order(8)]
        public int GfxIndex { get; set; }

        [Order(9)]
        public int Price { get; set; }

        [Order(10)]
        public int ShopPrice { get; set; }

        [Order(11)]
        public int PileNumMax { get; set; }

        [Order(12)]
        public uint HasGuid { get; set; }

        [Order(13)]
        public uint ProcType { get; set; }
    }

    [Order(135)]
    public class FaceThirdeyeEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileGfx { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public uint CharacterComboId { get; set; }

        [Order(5)]
        public uint GenderId { get; set; }

        [Order(6)]
        public uint FacepillOnly { get; set; }
    }

    [Order(136)]
    public class FactionFortressConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        public int RequireLevel { get; set; }

        [Order(3)]
        [Size(8)]
        public (int Id, int Count)[] RequireItem { get; set; }

        [Order(4)]
        [Size(50)]
        public (int Exp, int TechPoint)[] Level { get; set; }

        [Order(5)]
        [Size(35)]
        public int[] TechPointCost { get; set; }

        [Order(6)]
        [Size(20)]
        public int[] InitBuilding { get; set; }

        [Order(7)]
        [Size(100)]
        public int[] ControllerId { get; set; }

        [Order(8)]
        [Size(100)]
        public (int Id, int Value)[] CommonValue { get; set; }
    }

    [Order(137)]
    public class FactionBuildingSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(138)]
    public class FactionBuildingEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdSubType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public int Level { get; set; }

        [Order(5)]
        public int RequireLevel { get; set; }

        [Order(6)]
        [Size(5)]
        public int[] Technology { get; set; }

        [Order(7)]
        public int Money { get; set; }

        [Order(8)]
        [Size(8)]
        public int[] Material { get; set; }

        [Order(9)]
        public int BaseTime { get; set; }

        [Order(10)]
        public int DeltaTime { get; set; }

        [Order(11)]
        public int ControllerId0 { get; set; }

        [Order(12)]
        public int ControllerId1 { get; set; }
    }

    [Order(139)]
    public class FactionMaterialEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        [Size(8)]
        public int[] MaterialCount { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int PileNumMax { get; set; }

        [Order(8)]
        public uint HasGuid { get; set; }

        [Order(9)]
        public uint ProcType { get; set; }
    }

    [Order(140)]
    public class CongregateEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(128)]
        public string FileMatter { get; set; }

        [Order(3)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(4)]
        public uint CongregateType { get; set; }

        [Order(5)]
        public int Price { get; set; }

        [Order(6)]
        public int ShopPrice { get; set; }

        [Order(7)]
        public int PileNumMax { get; set; }

        [Order(8)]
        public uint HasGuid { get; set; }

        [Order(9)]
        public uint ProcType { get; set; }
    }

    [Order(141)]
    public class EngraveMajorType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(142)]
    public class EngraveSubType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(143)]
    public class EngraveEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdMajorType { get; set; }

        [Order(2)]
        public uint IdSubType { get; set; }

        [Order(3)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(4)]
        [Size(128)]
        public string FileIcon { get; set; }

        [Order(5)]
        public int Level { get; set; }

        [Order(6)]
        public uint EquipMask { get; set; }

        [Order(7)]
        public int RequireLevelMin { get; set; }

        [Order(8)]
        public int RequireLevelMax { get; set; }

        [Order(9)]
        public int Duration { get; set; }

        [Order(10)]
        [Size(8)]
        public (uint Id, int Num)[] Materials { get; set; }

        [Order(11)]
        [Size(4)]
        public float[] ProbabilityAddonNum { get; set; }

        [Order(12)]
        [Size(32)]
        public Probability[] Addons { get; set; }
    }

    [Order(144)]
    public class NpcEngraveService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(16)]
        public uint[] IdEngrave { get; set; }
    }

    [Order(145)]
    public class NpcRandpropService : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(8)]
        public PagesClass[] Pages { get; set; }

        public class PagesClass
        {
            [Order(0)]
            [Size(8)]
            [NameString]
            public string PageTitle { get; set; }

            [Order(1)]
            public uint IdRecipe { get; set; }
        }

    }

    [Order(146)]
    public class RandpropType : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }
    }

    [Order(147)]
    public class RandpropEssence : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        public uint IdType { get; set; }

        [Order(2)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(3)]
        public uint IdSkill { get; set; }

        [Order(4)]
        public int SkillLevel { get; set; }

        [Order(5)]
        public int Money { get; set; }

        [Order(6)]
        public int Duration { get; set; }

        [Order(7)]
        [Size(32)]
        public uint[] EquipId { get; set; }

        [Order(8)]
        [Size(8)]
        public (uint Id, int Num)[] Materials { get; set; }
    }

    [Order(148)]
    public class WikiTabooConfig : IElementsType
    {
        [Order(0)]
        public uint Id { get; set; }

        [Order(1)]
        [Size(32)]
        [NameString]
        public string Name { get; set; }

        [Order(2)]
        [Size(512)]
        public uint[] Essence { get; set; }

        [Order(3)]
        [Size(128)]
        public uint[] Recipe { get; set; }

        [Order(4)]
        [Size(512)]
        public uint[] Task { get; set; }

        [Order(5)]
        [Size(128)]
        public uint[] Skill { get; set; }
    }

}
