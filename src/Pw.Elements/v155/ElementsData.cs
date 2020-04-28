using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using Pw.Conventions;
using Pw.Serializer;
using YamlDotNet.Core;
using YamlDotNet.Serialization;

// ReSharper disable MemberCanBePrivate.Global
// ReSharper disable CollectionNeverQueried.Global
// ReSharper disable IdentifierTypo
// ReSharper disable UnusedType.Global

namespace Pw.Elements.v155
{
    public class ElementsData
    {
        public ElementsData()
        {
            Lists = new Dictionary<string, IElementsType[]>();
        }

        public ElementsData(Stream stream) : this()
        {
            Load(stream);
        }

        public Dictionary<string, IElementsType[]> Lists { get; }

        public ElementsDataFileInfo ElementsDataFileInfo { get; set; }

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

        private void Load(Stream stream)
        {
            var reader = new BinaryReader(stream);
            var serializer = new ElementsSerializer();
            ElementsDataFileInfo = new ElementsDataFileInfo();

            ElementsDataFileInfo.ReadVersion(reader);
            ElementsDataFileInfo.ReadHeader(reader);
            EquipmentAddons = ReadList<EquipmentAddon>();
            WeaponMajorTypes = ReadList<WeaponMajorType>();
            WeaponSubTypes = ReadList<WeaponSubType>();
            WeaponEssences = ReadList<WeaponEssence>();
            ArmorMajorTypes = ReadList<ArmorMajorType>();
            ArmorSubTypes = ReadList<ArmorSubType>();
            ArmorEssences = ReadList<ArmorEssence>();
            DecorationMajorTypes = ReadList<DecorationMajorType>();
            DecorationSubTypes = ReadList<DecorationSubType>();
            DecorationEssences = ReadList<DecorationEssence>();
            MedicineMajorTypes = ReadList<MedicineMajorType>();
            MedicineSubTypes = ReadList<MedicineSubType>();
            MedicineEssences = ReadList<MedicineEssence>();
            MaterialMajorTypes = ReadList<MaterialMajorType>();
            MaterialSubTypes = ReadList<MaterialSubType>();
            MaterialEssences = ReadList<MaterialEssence>();
            DamageruneSubTypes = ReadList<DamageruneSubType>();
            DamageruneEssences = ReadList<DamageruneEssence>();
            ArmorruneSubTypes = ReadList<ArmorruneSubType>();
            ArmorruneEssences = ReadList<ArmorruneEssence>();

            ElementsDataFileInfo.ReadFirstMetadata(reader);

            SkilltomeSubTypes = ReadList<SkilltomeSubType>();
            SkilltomeEssences = ReadList<SkilltomeEssence>();
            FlyswordEssences = ReadList<FlyswordEssence>();
            WingmanwingEssences = ReadList<WingmanwingEssence>();
            TownscrollEssences = ReadList<TownscrollEssence>();
            UnionscrollEssences = ReadList<UnionscrollEssence>();
            RevivescrollEssences = ReadList<RevivescrollEssence>();
            ElementEssences = ReadList<ElementEssence>();
            TaskmatterEssences = ReadList<TaskmatterEssence>();
            TossmatterEssences = ReadList<TossmatterEssence>();
            ProjectileTypes = ReadList<ProjectileType>();
            ProjectileEssences = ReadList<ProjectileEssence>();
            QuiverSubTypes = ReadList<QuiverSubType>();
            QuiverEssences = ReadList<QuiverEssence>();
            StoneSubTypes = ReadList<StoneSubType>();
            StoneEssences = ReadList<StoneEssence>();
            MonsterAddons = ReadList<MonsterAddon>();
            MonsterTypes = ReadList<MonsterType>();
            MonsterEssences = ReadList<MonsterEssence>();
            NpcTalkServices = ReadList<NpcTalkService>();
            NpcSellServices = ReadList<NpcSellService>();
            NpcBuyServices = ReadList<NpcBuyService>();
            NpcRepairServices = ReadList<NpcRepairService>();
            NpcInstallServices = ReadList<NpcInstallService>();
            NpcUninstallServices = ReadList<NpcUninstallService>();
            NpcTaskInServices = ReadList<NpcTaskInService>();
            NpcTaskOutServices = ReadList<NpcTaskOutService>();
            NpcTaskMatterServices = ReadList<NpcTaskMatterService>();
            NpcSkillServices = ReadList<NpcSkillService>();
            NpcHealServices = ReadList<NpcHealService>();
            NpcTransmitServices = ReadList<NpcTransmitService>();
            NpcTransportServices = ReadList<NpcTransportService>();
            NpcProxyServices = ReadList<NpcProxyService>();
            NpcStorageServices = ReadList<NpcStorageService>();
            NpcMakeServices = ReadList<NpcMakeService>();
            NpcDecomposeServices = ReadList<NpcDecomposeService>();
            NpcTypes = ReadList<NpcType>();
            NpcEssences = ReadList<NpcEssence>();
            TalkProcs = ReadList<TalkProc>();
            FaceTextureEssences = ReadList<FaceTextureEssence>();
            FaceShapeEssences = ReadList<FaceShapeEssence>();
            FaceEmotionTypes = ReadList<FaceEmotionType>();
            FaceExpressionEssences = ReadList<FaceExpressionEssence>();
            FaceHairEssences = ReadList<FaceHairEssence>();
            FaceMoustacheEssences = ReadList<FaceMoustacheEssence>();
            ColorpickerEssences = ReadList<ColorpickerEssence>();
            CustomizedataEssences = ReadList<CustomizedataEssence>();
            RecipeMajorTypes = ReadList<RecipeMajorType>();
            RecipeSubTypes = ReadList<RecipeSubType>();
            RecipeEssences = ReadList<RecipeEssence>();
            EnemyFactionConfigs = ReadList<EnemyFactionConfig>();
            CharracterClassConfigs = ReadList<CharracterClassConfig>();
            ParamAdjustConfigs = ReadList<ParamAdjustConfig>();
            PlayerActionInfoConfigs = ReadList<PlayerActionInfoConfig>();
            TaskdiceEssences = ReadList<TaskdiceEssence>();
            TasknormalmatterEssences = ReadList<TasknormalmatterEssence>();
            FaceFalingEssences = ReadList<FaceFalingEssence>();
            PlayerLevelexpConfigs = ReadList<PlayerLevelexpConfig>();
            MineTypes = ReadList<MineType>();
            MineEssences = ReadList<MineEssence>();
            NpcIdentifyServices = ReadList<NpcIdentifyService>();
            FashionMajorTypes = ReadList<FashionMajorType>();
            FashionSubTypes = ReadList<FashionSubType>();
            FashionEssences = ReadList<FashionEssence>();
            FaceticketMajorTypes = ReadList<FaceticketMajorType>();
            FaceticketSubTypes = ReadList<FaceticketSubType>();
            FaceticketEssences = ReadList<FaceticketEssence>();
            FacepillMajorTypes = ReadList<FacepillMajorType>();
            FacepillSubTypes = ReadList<FacepillSubType>();
            FacepillEssences = ReadList<FacepillEssence>();
            SuiteEssences = ReadList<SuiteEssence>();
            GmGeneratorTypes = ReadList<GmGeneratorType>();
            GmGeneratorEssences = ReadList<GmGeneratorEssence>();
            PetTypes = ReadList<PetType>();
            PetEssences = ReadList<PetEssence>();
            PetEggEssences = ReadList<PetEggEssence>();
            PetFoodEssences = ReadList<PetFoodEssence>();
            PetFaceticketEssences = ReadList<PetFaceticketEssence>();
            FireworksEssences = ReadList<FireworksEssence>();
            WarTankcallinEssences = ReadList<WarTankcallinEssence>();

            ElementsDataFileInfo.ReadSecondMetadata(reader);

            NpcWarTowerbuildServices = ReadList<NpcWarTowerbuildService>();
            PlayerSecondlevelConfigs = ReadList<PlayerSecondlevelConfig>();
            NpcResetpropServices = ReadList<NpcResetpropService>();
            NpcPetnameServices = ReadList<NpcPetnameService>();
            NpcPetlearnskillServices = ReadList<NpcPetlearnskillService>();
            NpcPetforgetskillServices = ReadList<NpcPetforgetskillService>();
            SkillmatterEssences = ReadList<SkillmatterEssence>();
            RefineTicketEssences = ReadList<RefineTicketEssence>();
            DestroyingEssences = ReadList<DestroyingEssence>();
            NpcEquipbindServices = ReadList<NpcEquipbindService>();
            NpcEquipdestroyServices = ReadList<NpcEquipdestroyService>();
            NpcEquipundestroyServices = ReadList<NpcEquipundestroyService>();
            BibleEssences = ReadList<BibleEssence>();
            SpeakerEssences = ReadList<SpeakerEssence>();
            AutompEssences = ReadList<AutompEssence>();
            AutohpEssences = ReadList<AutohpEssence>();
            DoubleExpEssences = ReadList<DoubleExpEssence>();
            TransmitscrollEssences = ReadList<TransmitscrollEssence>();
            DyeTicketEssences = ReadList<DyeTicketEssence>();
            GoblinEssences = ReadList<GoblinEssence>();
            GoblinEquipTypes = ReadList<GoblinEquipType>();
            GoblinEquipEssences = ReadList<GoblinEquipEssence>();
            GoblinExppillEssences = ReadList<GoblinExppillEssence>();
            SellCertificateEssences = ReadList<SellCertificateEssence>();
            TargetItemEssences = ReadList<TargetItemEssence>();
            LookInfoEssences = ReadList<LookInfoEssence>();
            UpgradeProductionConfigs = ReadList<UpgradeProductionConfig>();
            AccStorageBlacklistConfigs = ReadList<AccStorageBlacklistConfig>();
            FaceHairTextureMaps = ReadList<FaceHairTextureMap>();
            MultiExpConfigs = ReadList<MultiExpConfig>();
            IncSkillAbilityEssences = ReadList<IncSkillAbilityEssence>();
            GodEvilConvertConfigs = ReadList<GodEvilConvertConfig>();
            WeddingConfigs = ReadList<WeddingConfig>();
            WeddingBookcardEssences = ReadList<WeddingBookcardEssence>();
            WeddingInvitecardEssences = ReadList<WeddingInvitecardEssence>();
            SharpenerEssences = ReadList<SharpenerEssence>();
            FaceThirdeyeEssences = ReadList<FaceThirdeyeEssence>();
            FactionFortressConfigs = ReadList<FactionFortressConfig>();
            FactionBuildingSubTypes = ReadList<FactionBuildingSubType>();
            FactionBuildingEssences = ReadList<FactionBuildingEssence>();
            FactionMaterialEssences = ReadList<FactionMaterialEssence>();
            CongregateEssences = ReadList<CongregateEssence>();
            EngraveMajorTypes = ReadList<EngraveMajorType>();
            EngraveSubTypes = ReadList<EngraveSubType>();
            EngraveEssences = ReadList<EngraveEssence>();
            NpcEngraveServices = ReadList<NpcEngraveService>();
            NpcRandpropServices = ReadList<NpcRandpropService>();
            RandpropTypes = ReadList<RandpropType>();
            RandpropEssences = ReadList<RandpropEssence>();
            WikiTabooConfigs = ReadList<WikiTabooConfig>();
            ForceConfigs = ReadList<ForceConfig>();
            ForceTokenEssences = ReadList<ForceTokenEssence>();
            NpcForceServices = ReadList<NpcForceService>();
            PlayerDeathDropConfigs = ReadList<PlayerDeathDropConfig>();
            DynskillequipEssences = ReadList<DynskillequipEssence>();
            ConsumePointsConfigs = ReadList<ConsumePointsConfig>();
            OnlineAwardsConfigs = ReadList<OnlineAwardsConfig>();
            CountryConfigs = ReadList<CountryConfig>();
            GmActivityConfigs = ReadList<GmActivityConfig>();
            FashionWeaponConfigs = ReadList<FashionWeaponConfig>();
            PetEvolveConfigs = ReadList<PetEvolveConfig>();
            PetEvolvedSkillConfigs = ReadList<PetEvolvedSkillConfig>();
            MoneyConvertibleEssences = ReadList<MoneyConvertibleEssence>();
            StoneChangeRecipeTypes = ReadList<StoneChangeRecipeType>();
            StoneChangeRecipes = ReadList<StoneChangeRecipe>();
            MeridianConfigs = ReadList<MeridianConfig>();
            PetEvolvedSkillRandConfigs = ReadList<PetEvolvedSkillRandConfig>();
            AutotaskDisplayConfigs = ReadList<AutotaskDisplayConfig>();
            TouchShopConfigs = ReadList<TouchShopConfig>();
            TitleConfigs = ReadList<TitleConfig>();
            ComplexTitleConfigs = ReadList<ComplexTitleConfig>();
            MonsterSpiritEssences = ReadList<MonsterSpiritEssence>();
            PlayerSpiritConfigs = ReadList<PlayerSpiritConfig>();
            PlayerReincarnationConfigs = ReadList<PlayerReincarnationConfig>();
            HistoryStageConfigs = ReadList<HistoryStageConfig>();
            HistoryAdvanceConfigs = ReadList<HistoryAdvanceConfig>();
            AutoteamConfigs = ReadList<AutoteamConfig>();
            PlayerRealmConfigs = ReadList<PlayerRealmConfig>();
            ChariotConfigs = ReadList<ChariotConfig>();
            ChariotWarConfigs = ReadList<ChariotWarConfig>();
            PokerLevelexpConfigs = ReadList<PokerLevelexpConfig>();
            PokerSuiteEssences = ReadList<PokerSuiteEssence>();
            PokerDiceEssences = ReadList<PokerDiceEssence>();
            PokerSubTypes = ReadList<PokerSubType>();
            PokerEssences = ReadList<PokerEssence>();
            TokenShopConfigs = ReadList<TokenShopConfig>();
            ShopTokenEssences = ReadList<ShopTokenEssence>();
            GtConfigs = ReadList<GtConfig>();
            RandShopConfigs = ReadList<RandShopConfig>();
            ProfitTimeConfigs = ReadList<ProfitTimeConfig>();
            FactionPvpConfigs = ReadList<FactionPvpConfig>();
            UniversalTokenEssences = ReadList<UniversalTokenEssence>();
            TaskListConfigs = ReadList<TaskListConfig>();
            TaskDiceByWeightConfigs = ReadList<TaskDiceByWeightConfig>();
            FashionSuiteEssences = ReadList<FashionSuiteEssence>();
            FashionBestColorConfigs = ReadList<FashionBestColorConfig>();
            SignAwardConfigs = ReadList<SignAwardConfig>();
            AstrolabeEssences = ReadList<AstrolabeEssence>();
            AstrolabeRandomAddonEssences = ReadList<AstrolabeRandomAddonEssence>();
            AstrolabeIncInnerPointValueEssences = ReadList<AstrolabeIncInnerPointValueEssence>();
            AstrolabeIncExpEssences = ReadList<AstrolabeIncExpEssence>();
            ItemPackageByProfessionEssences = ReadList<ItemPackageByProfessionEssence>();
            AstrolabeLevelexpConfigs = ReadList<AstrolabeLevelexpConfig>();
            AstrolabeAddonRandomConfigs = ReadList<AstrolabeAddonRandomConfig>();
            AstrolabeAppearanceConfigs = ReadList<AstrolabeAppearanceConfig>();
            EquipMakeHoleConfigs = ReadList<EquipMakeHoleConfig>();
            SoloTowerChallengeLevelConfigs = ReadList<SoloTowerChallengeLevelConfig>();
            SoloTowerChallengeAwardPageConfigs = ReadList<SoloTowerChallengeAwardPageConfig>();
            SoloTowerChallengeAwardListConfigs = ReadList<SoloTowerChallengeAwardListConfig>();
            SoloTowerChallengeScoreCostConfigs = ReadList<SoloTowerChallengeScoreCostConfig>();
            MnfactionWarConfigs = ReadList<MnfactionWarConfig>();
            NpcCrossServerServices = ReadList<NpcCrossServerService>();
            Fireworks2Essences = ReadList<Fireworks2Essence>();
            FixPositionTransmitEssences = ReadList<FixPositionTransmitEssence>();
            HomeConfigs = ReadList<HomeConfig>();
            HomeProductsConfigs = ReadList<HomeProductsConfig>();
            HomeResourceProduceConfigs = ReadList<HomeResourceProduceConfig>();
            HomeFormulasProduceRecipes = ReadList<HomeFormulasProduceRecipe>();
            HomeFormulasItemEssences = ReadList<HomeFormulasItemEssence>();
            HomeProduceServiceConfigs = ReadList<HomeProduceServiceConfig>();
            HomeFactoryConfigs = ReadList<HomeFactoryConfig>();
            HomeItemMajorTypes = ReadList<HomeItemMajorType>();
            HomeItemSubTypes = ReadList<HomeItemSubType>();
            HomeItemEntities = ReadList<HomeItemEntity>();
            HomeFormulasProduceMajorTypes = ReadList<HomeFormulasProduceMajorType>();
            HomeFormulasProduceSubTypes = ReadList<HomeFormulasProduceSubType>();
            HomeFormulasItemMajorTypes = ReadList<HomeFormulasItemMajorType>();
            HomeFormulasItemSubTypes = ReadList<HomeFormulasItemSubType>();
            HomeStorageTaskConfigs = ReadList<HomeStorageTaskConfig>();
            WishTributeEssences = ReadList<WishTributeEssence>();
            RedPacketPaperEssences = ReadList<RedPacketPaperEssence>();

            T[] ReadList<T>() where T : IElementsType
            {
                int count = reader.ReadInt32();

                var list = Enumerable
                    .Range(0, count)
                    .Select(_ => serializer.DeSerialize<T>(stream))
                    .ToArray();

                Lists.Add(typeof(T).Name, list.Cast<IElementsType>().ToArray());
                return list;
            }
        }

        public void Save(Stream stream)
        {
            var serilizer = new ElementsSerializer();
            var writer = new BinaryWriter(stream);

            ElementsDataFileInfo.WriteVersion(writer);
            ElementsDataFileInfo.WriteHeader(writer);

            WriteList(EquipmentAddons);
            WriteList(WeaponMajorTypes);
            WriteList(WeaponSubTypes);
            WriteList(WeaponEssences);
            WriteList(ArmorMajorTypes);
            WriteList(ArmorSubTypes);
            WriteList(ArmorEssences);
            WriteList(DecorationMajorTypes);
            WriteList(DecorationSubTypes);
            WriteList(DecorationEssences);
            WriteList(MedicineMajorTypes);
            WriteList(MedicineSubTypes);
            WriteList(MedicineEssences);
            WriteList(MaterialMajorTypes);
            WriteList(MaterialSubTypes);
            WriteList(MaterialEssences);
            WriteList(DamageruneSubTypes);
            WriteList(DamageruneEssences);
            WriteList(ArmorruneSubTypes);
            WriteList(ArmorruneEssences);

            ElementsDataFileInfo.WriteFirstMetadata(writer);

            WriteList(SkilltomeSubTypes);
            WriteList(SkilltomeEssences);
            WriteList(FlyswordEssences);
            WriteList(WingmanwingEssences);
            WriteList(TownscrollEssences);
            WriteList(UnionscrollEssences);
            WriteList(RevivescrollEssences);
            WriteList(ElementEssences);
            WriteList(TaskmatterEssences);
            WriteList(TossmatterEssences);
            WriteList(ProjectileTypes);
            WriteList(ProjectileEssences);
            WriteList(QuiverSubTypes);
            WriteList(QuiverEssences);
            WriteList(StoneSubTypes);
            WriteList(StoneEssences);
            WriteList(MonsterAddons);
            WriteList(MonsterTypes);
            WriteList(MonsterEssences);
            WriteList(NpcTalkServices);
            WriteList(NpcSellServices);
            WriteList(NpcBuyServices);
            WriteList(NpcRepairServices);
            WriteList(NpcInstallServices);
            WriteList(NpcUninstallServices);
            WriteList(NpcTaskInServices);
            WriteList(NpcTaskOutServices);
            WriteList(NpcTaskMatterServices);
            WriteList(NpcSkillServices);
            WriteList(NpcHealServices);
            WriteList(NpcTransmitServices);
            WriteList(NpcTransportServices);
            WriteList(NpcProxyServices);
            WriteList(NpcStorageServices);
            WriteList(NpcMakeServices);
            WriteList(NpcDecomposeServices);
            WriteList(NpcTypes);
            WriteList(NpcEssences);
            WriteList(TalkProcs);
            WriteList(FaceTextureEssences);
            WriteList(FaceShapeEssences);
            WriteList(FaceEmotionTypes);
            WriteList(FaceExpressionEssences);
            WriteList(FaceHairEssences);
            WriteList(FaceMoustacheEssences);
            WriteList(ColorpickerEssences);
            WriteList(CustomizedataEssences);
            WriteList(RecipeMajorTypes);
            WriteList(RecipeSubTypes);
            WriteList(RecipeEssences);
            WriteList(EnemyFactionConfigs);
            WriteList(CharracterClassConfigs);
            WriteList(ParamAdjustConfigs);
            WriteList(PlayerActionInfoConfigs);
            WriteList(TaskdiceEssences);
            WriteList(TasknormalmatterEssences);
            WriteList(FaceFalingEssences);
            WriteList(PlayerLevelexpConfigs);
            WriteList(MineTypes);
            WriteList(MineEssences);
            WriteList(NpcIdentifyServices);
            WriteList(FashionMajorTypes);
            WriteList(FashionSubTypes);
            WriteList(FashionEssences);
            WriteList(FaceticketMajorTypes);
            WriteList(FaceticketSubTypes);
            WriteList(FaceticketEssences);
            WriteList(FacepillMajorTypes);
            WriteList(FacepillSubTypes);
            WriteList(FacepillEssences);
            WriteList(SuiteEssences);
            WriteList(GmGeneratorTypes);
            WriteList(GmGeneratorEssences);
            WriteList(PetTypes);
            WriteList(PetEssences);
            WriteList(PetEggEssences);
            WriteList(PetFoodEssences);
            WriteList(PetFaceticketEssences);
            WriteList(FireworksEssences);
            WriteList(WarTankcallinEssences);

            ElementsDataFileInfo.WriteSecondMetadata(writer);

            WriteList(NpcWarTowerbuildServices);
            WriteList(PlayerSecondlevelConfigs);
            WriteList(NpcResetpropServices);
            WriteList(NpcPetnameServices);
            WriteList(NpcPetlearnskillServices);
            WriteList(NpcPetforgetskillServices);
            WriteList(SkillmatterEssences);
            WriteList(RefineTicketEssences);
            WriteList(DestroyingEssences);
            WriteList(NpcEquipbindServices);
            WriteList(NpcEquipdestroyServices);
            WriteList(NpcEquipundestroyServices);
            WriteList(BibleEssences);
            WriteList(SpeakerEssences);
            WriteList(AutompEssences);
            WriteList(AutohpEssences);
            WriteList(DoubleExpEssences);
            WriteList(TransmitscrollEssences);
            WriteList(DyeTicketEssences);
            WriteList(GoblinEssences);
            WriteList(GoblinEquipTypes);
            WriteList(GoblinEquipEssences);
            WriteList(GoblinExppillEssences);
            WriteList(SellCertificateEssences);
            WriteList(TargetItemEssences);
            WriteList(LookInfoEssences);
            WriteList(UpgradeProductionConfigs);
            WriteList(AccStorageBlacklistConfigs);
            WriteList(FaceHairTextureMaps);
            WriteList(MultiExpConfigs);
            WriteList(IncSkillAbilityEssences);
            WriteList(GodEvilConvertConfigs);
            WriteList(WeddingConfigs);
            WriteList(WeddingBookcardEssences);
            WriteList(WeddingInvitecardEssences);
            WriteList(SharpenerEssences);
            WriteList(FaceThirdeyeEssences);
            WriteList(FactionFortressConfigs);
            WriteList(FactionBuildingSubTypes);
            WriteList(FactionBuildingEssences);
            WriteList(FactionMaterialEssences);
            WriteList(CongregateEssences);
            WriteList(EngraveMajorTypes);
            WriteList(EngraveSubTypes);
            WriteList(EngraveEssences);
            WriteList(NpcEngraveServices);
            WriteList(NpcRandpropServices);
            WriteList(RandpropTypes);
            WriteList(RandpropEssences);
            WriteList(WikiTabooConfigs);
            WriteList(ForceConfigs);
            WriteList(ForceTokenEssences);
            WriteList(NpcForceServices);
            WriteList(PlayerDeathDropConfigs);
            WriteList(DynskillequipEssences);
            WriteList(ConsumePointsConfigs);
            WriteList(OnlineAwardsConfigs);
            WriteList(CountryConfigs);
            WriteList(GmActivityConfigs);
            WriteList(FashionWeaponConfigs);
            WriteList(PetEvolveConfigs);
            WriteList(PetEvolvedSkillConfigs);
            WriteList(MoneyConvertibleEssences);
            WriteList(StoneChangeRecipeTypes);
            WriteList(StoneChangeRecipes);
            WriteList(MeridianConfigs);
            WriteList(PetEvolvedSkillRandConfigs);
            WriteList(AutotaskDisplayConfigs);
            WriteList(TouchShopConfigs);
            WriteList(TitleConfigs);
            WriteList(ComplexTitleConfigs);
            WriteList(MonsterSpiritEssences);
            WriteList(PlayerSpiritConfigs);
            WriteList(PlayerReincarnationConfigs);
            WriteList(HistoryStageConfigs);
            WriteList(HistoryAdvanceConfigs);
            WriteList(AutoteamConfigs);
            WriteList(PlayerRealmConfigs);
            WriteList(ChariotConfigs);
            WriteList(ChariotWarConfigs);
            WriteList(PokerLevelexpConfigs);
            WriteList(PokerSuiteEssences);
            WriteList(PokerDiceEssences);
            WriteList(PokerSubTypes);
            WriteList(PokerEssences);
            WriteList(TokenShopConfigs);
            WriteList(ShopTokenEssences);
            WriteList(GtConfigs);
            WriteList(RandShopConfigs);
            WriteList(ProfitTimeConfigs);
            WriteList(FactionPvpConfigs);
            WriteList(UniversalTokenEssences);
            WriteList(TaskListConfigs);
            WriteList(TaskDiceByWeightConfigs);
            WriteList(FashionSuiteEssences);
            WriteList(FashionBestColorConfigs);
            WriteList(SignAwardConfigs);
            WriteList(AstrolabeEssences);
            WriteList(AstrolabeRandomAddonEssences);
            WriteList(AstrolabeIncInnerPointValueEssences);
            WriteList(AstrolabeIncExpEssences);
            WriteList(ItemPackageByProfessionEssences);
            WriteList(AstrolabeLevelexpConfigs);
            WriteList(AstrolabeAddonRandomConfigs);
            WriteList(AstrolabeAppearanceConfigs);
            WriteList(EquipMakeHoleConfigs);
            WriteList(SoloTowerChallengeLevelConfigs);
            WriteList(SoloTowerChallengeAwardPageConfigs);
            WriteList(SoloTowerChallengeAwardListConfigs);
            WriteList(SoloTowerChallengeScoreCostConfigs);
            WriteList(MnfactionWarConfigs);
            WriteList(NpcCrossServerServices);
            WriteList(Fireworks2Essences);
            WriteList(FixPositionTransmitEssences);
            WriteList(HomeConfigs);
            WriteList(HomeProductsConfigs);
            WriteList(HomeResourceProduceConfigs);
            WriteList(HomeFormulasProduceRecipes);
            WriteList(HomeFormulasItemEssences);
            WriteList(HomeProduceServiceConfigs);
            WriteList(HomeFactoryConfigs);
            WriteList(HomeItemMajorTypes);
            WriteList(HomeItemSubTypes);
            WriteList(HomeItemEntities);
            WriteList(HomeFormulasProduceMajorTypes);
            WriteList(HomeFormulasProduceSubTypes);
            WriteList(HomeFormulasItemMajorTypes);
            WriteList(HomeFormulasItemSubTypes);
            WriteList(HomeStorageTaskConfigs);
            WriteList(WishTributeEssences);
            WriteList(RedPacketPaperEssences);

            void WriteList<T>(T[] list) where T : IElementsType
            {
                writer.Write(list.Length);

                foreach (var item in list)
                {
                    serilizer.Serialize(item, writer.BaseStream);
                }
            }
        }
    }
}
