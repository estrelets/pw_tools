using System.Collections.Generic;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable IdentifierTypo
// ReSharper disable UnusedType.Global

namespace Pw.Elements.v156
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
        public Fireworks2Essence[] Fireworks2Essences { get; set; }
        public FixPositionTransmitEssence[] FixPositionTransmitEssences { get; set; }
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
        public AutompEssence[] AutompEssences { get; set; }
        public AutohpEssence[] AutohpEssences { get; set; }
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
        public ForceConfig[] ForceConfigs { get; set; }
        public ForceTokenEssence[] ForceTokenEssences { get; set; }
        public NpcForceService[] NpcForceServices { get; set; }
        public PlayerDeathDropConfig[] PlayerDeathDropConfigs { get; set; }
        public DynskillequipEssence[] DynskillequipEssences { get; set; }
        public ConsumePointsConfig[] ConsumePointsConfigs { get; set; }
        public OnlineAwardsConfig[] OnlineAwardsConfigs { get; set; }
        public CountryConfig[] CountryConfigs { get; set; }
        public GmActivityConfig[] GmActivityConfigs { get; set; }
        public FashionWeaponConfig[] FashionWeaponConfigs { get; set; }
        public PetEvolveConfig[] PetEvolveConfigs { get; set; }
        public PetEvolvedSkillConfig[] PetEvolvedSkillConfigs { get; set; }
        public MoneyConvertibleEssence[] MoneyConvertibleEssences { get; set; }
        public StoneChangeRecipeType[] StoneChangeRecipeTypes { get; set; }
        public StoneChangeRecipe[] StoneChangeRecipes { get; set; }
        public MeridianConfig[] MeridianConfigs { get; set; }
        public PetEvolvedSkillRandConfig[] PetEvolvedSkillRandConfigs { get; set; }
        public AutotaskDisplayConfig[] AutotaskDisplayConfigs { get; set; }
        public TouchShopConfig[] TouchShopConfigs { get; set; }
        public TitleConfig[] TitleConfigs { get; set; }
        public ComplexTitleConfig[] ComplexTitleConfigs { get; set; }
        public MonsterSpiritEssence[] MonsterSpiritEssences { get; set; }
        public PlayerSpiritConfig[] PlayerSpiritConfigs { get; set; }
        public PlayerReincarnationConfig[] PlayerReincarnationConfigs { get; set; }
        public HistoryStageConfig[] HistoryStageConfigs { get; set; }
        public HistoryAdvanceConfig[] HistoryAdvanceConfigs { get; set; }
        public AutoteamConfig[] AutoteamConfigs { get; set; }
        public PlayerRealmConfig[] PlayerRealmConfigs { get; set; }
        public ChariotConfig[] ChariotConfigs { get; set; }
        public ChariotWarConfig[] ChariotWarConfigs { get; set; }
        public PokerLevelexpConfig[] PokerLevelexpConfigs { get; set; }
        public PokerSuiteEssence[] PokerSuiteEssences { get; set; }
        public PokerDiceEssence[] PokerDiceEssences { get; set; }
        public PokerSubType[] PokerSubTypes { get; set; }
        public PokerEssence[] PokerEssences { get; set; }
        public TokenShopConfig[] TokenShopConfigs { get; set; }
        public ShopTokenEssence[] ShopTokenEssences { get; set; }
        public GtConfig[] GtConfigs { get; set; }
        public RandShopConfig[] RandShopConfigs { get; set; }
        public ProfitTimeConfig[] ProfitTimeConfigs { get; set; }
        public FactionPvpConfig[] FactionPvpConfigs { get; set; }
        public UniversalTokenEssence[] UniversalTokenEssences { get; set; }
        public TaskListConfig[] TaskListConfigs { get; set; }
        public TaskDiceByWeightConfig[] TaskDiceByWeightConfigs { get; set; }
        public FashionSuiteEssence[] FashionSuiteEssences { get; set; }
        public FashionBestColorConfig[] FashionBestColorConfigs { get; set; }
        public SignAwardConfig[] SignAwardConfigs { get; set; }
        public AstrolabeEssence[] AstrolabeEssences { get; set; }
        public AstrolabeRandomAddonEssence[] AstrolabeRandomAddonEssences { get; set; }
        public AstrolabeIncInnerPointValueEssence[] AstrolabeIncInnerPointValueEssences { get; set; }
        public AstrolabeIncExpEssence[] AstrolabeIncExpEssences { get; set; }
        public ItemPackageByProfessionEssence[] ItemPackageByProfessionEssences { get; set; }
        public AstrolabeLevelexpConfig[] AstrolabeLevelexpConfigs { get; set; }
        public AstrolabeAddonRandomConfig[] AstrolabeAddonRandomConfigs { get; set; }
        public AstrolabeAppearanceConfig[] AstrolabeAppearanceConfigs { get; set; }
        public EquipMakeHoleConfig[] EquipMakeHoleConfigs { get; set; }
        public SoloTowerChallengeLevelConfig[] SoloTowerChallengeLevelConfigs { get; set; }
        public SoloTowerChallengeAwardPageConfig[] SoloTowerChallengeAwardPageConfigs { get; set; }
        public SoloTowerChallengeAwardListConfig[] SoloTowerChallengeAwardListConfigs { get; set; }
        public SoloTowerChallengeScoreCostConfig[] SoloTowerChallengeScoreCostConfigs { get; set; }
        public MnfactionWarConfig[] MnfactionWarConfigs { get; set; }
        public NpcCrossServerService[] NpcCrossServerServices { get; set; }
        public HomeConfig[] HomeConfigs { get; set; }
        public HomeProductsConfig[] HomeProductsConfigs { get; set; }
        public HomeResourceProduceConfig[] HomeResourceProduceConfigs { get; set; }
        public HomeFormulasProduceRecipe[] HomeFormulasProduceRecipes { get; set; }
        public HomeFormulasItemEssence[] HomeFormulasItemEssences { get; set; }
        public HomeProduceServiceConfig[] HomeProduceServiceConfigs { get; set; }
        public HomeFactoryConfig[] HomeFactoryConfigs { get; set; }
        public HomeItemMajorType[] HomeItemMajorTypes { get; set; }
        public HomeItemSubType[] HomeItemSubTypes { get; set; }
        public HomeItemEntity[] HomeItemEntities { get; set; }
        public HomeFormulasProduceMajorType[] HomeFormulasProduceMajorTypes { get; set; }
        public HomeFormulasProduceSubType[] HomeFormulasProduceSubTypes { get; set; }
        public HomeFormulasItemMajorType[] HomeFormulasItemMajorTypes { get; set; }
        public HomeFormulasItemSubType[] HomeFormulasItemSubTypes { get; set; }
        public HomeStorageTaskConfig[] HomeStorageTaskConfigs { get; set; }
        public WishTributeEssence[] WishTributeEssences { get; set; }
        public RedPacketPaperEssence[] RedPacketPaperEssences { get; set; }

    }
}
