﻿using System.Collections.Generic;

// ReSharper disable UnusedMember.Global
// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable IdentifierTypo
// ReSharper disable UnusedType.Global

namespace Pw.Elements.v144
{
    public class ElementData : IElementData
    {
        public List<IElement[]> Lists { get; set; } = new List<IElement[]>();
        public ElementMetadata ElementMetadata { get; set; }
        public EquipmentAddon[] EquipmentAddons { get; set; }
        public WeaponMajorType[] WeaponMajorTypes { get; set; }
        public WeaponSubType[] WeaponSubTypes { get; set; }
        public WeaponEssence[] WeaponEssences { get; set; }
        public ArmorMajorType[] ArmorMajorTypes { get; set; }
        public ArmorSubType[] ArmorSubTypes { get; set; }
        public ArmorEssence[] ArmorEssences { get; set; }
        public DecorationMajorType[] DecorationMajorTypes { get; set; }
        public DecorationSubType[] DecorationSubTypes { get; set; }
        public DecorationEssence[] DecorationEssences { get; set; }
        public MedicineMajorType[] MedicineMajorTypes { get; set; }
        public MedicineSubType[] MedicineSubTypes { get; set; }
        public MedicineEssence[] MedicineEssences { get; set; }
        public MaterialMajorType[] MaterialMajorTypes { get; set; }
        public MaterialSubType[] MaterialSubTypes { get; set; }
        public MaterialEssence[] MaterialEssences { get; set; }
        public DamageruneSubType[] DamageruneSubTypes { get; set; }
        public DamageruneEssence[] DamageruneEssences { get; set; }
        public ArmorruneSubType[] ArmorruneSubTypes { get; set; }
        public ArmorruneEssence[] ArmorruneEssences { get; set; }
        public SkilltomeSubType[] SkilltomeSubTypes { get; set; }
        public SkilltomeEssence[] SkilltomeEssences { get; set; }
        public FlyswordEssence[] FlyswordEssences { get; set; }
        public WingmanwingEssence[] WingmanwingEssences { get; set; }
        public TownscrollEssence[] TownscrollEssences { get; set; }
        public UnionscrollEssence[] UnionscrollEssences { get; set; }
        public RevivescrollEssence[] RevivescrollEssences { get; set; }
        public ElementEssence[] ElementEssences { get; set; }
        public TaskmatterEssence[] TaskmatterEssences { get; set; }
        public TossmatterEssence[] TossmatterEssences { get; set; }
        public ProjectileType[] ProjectileTypes { get; set; }
        public ProjectileEssence[] ProjectileEssences { get; set; }
        public QuiverSubType[] QuiverSubTypes { get; set; }
        public QuiverEssence[] QuiverEssences { get; set; }
        public StoneSubType[] StoneSubTypes { get; set; }
        public StoneEssence[] StoneEssences { get; set; }
        public MonsterAddon[] MonsterAddons { get; set; }
        public MonsterType[] MonsterTypes { get; set; }
        public MonsterEssence[] MonsterEssences { get; set; }
        public NpcTalkService[] NpcTalkServices { get; set; }
        public NpcSellService[] NpcSellServices { get; set; }
        public NpcBuyService[] NpcBuyServices { get; set; }
        public NpcRepairService[] NpcRepairServices { get; set; }
        public NpcInstallService[] NpcInstallServices { get; set; }
        public NpcUninstallService[] NpcUninstallServices { get; set; }
        public NpcTaskInService[] NpcTaskInServices { get; set; }
        public NpcTaskOutService[] NpcTaskOutServices { get; set; }
        public NpcTaskMatterService[] NpcTaskMatterServices { get; set; }
        public NpcSkillService[] NpcSkillServices { get; set; }
        public NpcHealService[] NpcHealServices { get; set; }
        public NpcTransmitService[] NpcTransmitServices { get; set; }
        public NpcTransportService[] NpcTransportServices { get; set; }
        public NpcProxyService[] NpcProxyServices { get; set; }
        public NpcStorageService[] NpcStorageServices { get; set; }
        public NpcMakeService[] NpcMakeServices { get; set; }
        public NpcDecomposeService[] NpcDecomposeServices { get; set; }
        public NpcType[] NpcTypes { get; set; }
        public NpcEssence[] NpcEssences { get; set; }
        public TalkProc[] TalkProcs { get; set; }
        public FaceTextureEssence[] FaceTextureEssences { get; set; }
        public FaceShapeEssence[] FaceShapeEssences { get; set; }
        public FaceEmotionType[] FaceEmotionTypes { get; set; }
        public FaceExpressionEssence[] FaceExpressionEssences { get; set; }
        public FaceHairEssence[] FaceHairEssences { get; set; }
        public FaceMoustacheEssence[] FaceMoustacheEssences { get; set; }
        public ColorpickerEssence[] ColorpickerEssences { get; set; }
        public CustomizedataEssence[] CustomizedataEssences { get; set; }
        public RecipeMajorType[] RecipeMajorTypes { get; set; }
        public RecipeSubType[] RecipeSubTypes { get; set; }
        public RecipeEssence[] RecipeEssences { get; set; }
        public EnemyFactionConfig[] EnemyFactionConfigs { get; set; }
        public CharracterClassConfig[] CharracterClassConfigs { get; set; }
        public ParamAdjustConfig[] ParamAdjustConfigs { get; set; }
        public PlayerActionInfoConfig[] PlayerActionInfoConfigs { get; set; }
        public TaskdiceEssence[] TaskdiceEssences { get; set; }
        public TasknormalmatterEssence[] TasknormalmatterEssences { get; set; }
        public FaceFalingEssence[] FaceFalingEssences { get; set; }
        public PlayerLevelexpConfig[] PlayerLevelexpConfigs { get; set; }
        public MineType[] MineTypes { get; set; }
        public MineEssence[] MineEssences { get; set; }
        public NpcIdentifyService[] NpcIdentifyServices { get; set; }
        public FashionMajorType[] FashionMajorTypes { get; set; }
        public FashionSubType[] FashionSubTypes { get; set; }
        public FashionEssence[] FashionEssences { get; set; }
        public FaceticketMajorType[] FaceticketMajorTypes { get; set; }
        public FaceticketSubType[] FaceticketSubTypes { get; set; }
        public FaceticketEssence[] FaceticketEssences { get; set; }
        public FacepillMajorType[] FacepillMajorTypes { get; set; }
        public FacepillSubType[] FacepillSubTypes { get; set; }
        public FacepillEssence[] FacepillEssences { get; set; }
        public SuiteEssence[] SuiteEssences { get; set; }
        public GmGeneratorType[] GmGeneratorTypes { get; set; }
        public GmGeneratorEssence[] GmGeneratorEssences { get; set; }
        public PetType[] PetTypes { get; set; }
        public PetEssence[] PetEssences { get; set; }
        public PetEggEssence[] PetEggEssences { get; set; }
        public PetFoodEssence[] PetFoodEssences { get; set; }
        public PetFaceticketEssence[] PetFaceticketEssences { get; set; }
        public FireworksEssence[] FireworksEssences { get; set; }
        public WarTankcallinEssence[] WarTankcallinEssences { get; set; }
        public NpcWarTowerbuildService[] NpcWarTowerbuildServices { get; set; }
        public PlayerSecondlevelConfig[] PlayerSecondlevelConfigs { get; set; }
        public NpcResetpropService[] NpcResetpropServices { get; set; }
        public NpcPetnameService[] NpcPetnameServices { get; set; }
        public NpcPetlearnskillService[] NpcPetlearnskillServices { get; set; }
        public NpcPetforgetskillService[] NpcPetforgetskillServices { get; set; }
        public SkillmatterEssence[] SkillmatterEssences { get; set; }
        public RefineTicketEssence[] RefineTicketEssences { get; set; }
        public DestroyingEssence[] DestroyingEssences { get; set; }
        public NpcEquipbindService[] NpcEquipbindServices { get; set; }
        public NpcEquipdestroyService[] NpcEquipdestroyServices { get; set; }
        public NpcEquipundestroyService[] NpcEquipundestroyServices { get; set; }
        public BibleEssence[] BibleEssences { get; set; }
        public SpeakerEssence[] SpeakerEssences { get; set; }
        public AutohpEssence[] AutohpEssences { get; set; }
        public AutompEssence[] AutompEssences { get; set; }
        public DoubleExpEssence[] DoubleExpEssences { get; set; }
        public TransmitscrollEssence[] TransmitscrollEssences { get; set; }
        public DyeTicketEssence[] DyeTicketEssences { get; set; }
        public GoblinEssence[] GoblinEssences { get; set; }
        public GoblinEquipType[] GoblinEquipTypes { get; set; }
        public GoblinEquipEssence[] GoblinEquipEssences { get; set; }
        public GoblinExppillEssence[] GoblinExppillEssences { get; set; }
        public SellCertificateEssence[] SellCertificateEssences { get; set; }
        public TargetItemEssence[] TargetItemEssences { get; set; }
        public LookInfoEssence[] LookInfoEssences { get; set; }
        public UpgradeProductionConfig[] UpgradeProductionConfigs { get; set; }
        public AccStorageBlacklistConfig[] AccStorageBlacklistConfigs { get; set; }
        public FaceHairTextureMap[] FaceHairTextureMaps { get; set; }
        public MultiExpConfig[] MultiExpConfigs { get; set; }
        public IncSkillAbilityEssence[] IncSkillAbilityEssences { get; set; }
        public GodEvilConvertConfig[] GodEvilConvertConfigs { get; set; }
        public WeddingConfig[] WeddingConfigs { get; set; }
        public WeddingBookcardEssence[] WeddingBookcardEssences { get; set; }
        public WeddingInvitecardEssence[] WeddingInvitecardEssences { get; set; }
        public SharpenerEssence[] SharpenerEssences { get; set; }
        public FaceThirdeyeEssence[] FaceThirdeyeEssences { get; set; }
        public FactionFortressConfig[] FactionFortressConfigs { get; set; }
        public FactionBuildingSubType[] FactionBuildingSubTypes { get; set; }
        public FactionBuildingEssence[] FactionBuildingEssences { get; set; }
        public FactionMaterialEssence[] FactionMaterialEssences { get; set; }
        public CongregateEssence[] CongregateEssences { get; set; }
        public EngraveMajorType[] EngraveMajorTypes { get; set; }
        public EngraveSubType[] EngraveSubTypes { get; set; }
        public EngraveEssence[] EngraveEssences { get; set; }
        public NpcEngraveService[] NpcEngraveServices { get; set; }
        public NpcRandpropService[] NpcRandpropServices { get; set; }
        public RandpropType[] RandpropTypes { get; set; }
        public RandpropEssence[] RandpropEssences { get; set; }
        public WikiTabooConfig[] WikiTabooConfigs { get; set; }
    }
}
