using System.Collections.Generic;
using System.IO;
using System.Linq;
using Pw.ElementsSerializer;

namespace Pw.Elements
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


        private void Load(Stream stream)
        {
            var reader = new BinaryReader(stream);
            var serializer = new Serializer();
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
            AutohpEssences = ReadList<AutohpEssence>();
            AutompEssences = ReadList<AutompEssence>();
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
            var serilizer = new Serializer();
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
            WriteList(AutohpEssences);
            WriteList(AutompEssences);
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
