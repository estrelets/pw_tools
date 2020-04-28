using System;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using Pw.Elements.v155;

namespace Pw.ElementsYamlConverter
{
    public class YamlImporter
    {
        private readonly YamlSerializer _yamlSerializer;

        public YamlImporter(YamlSerializer yamlSerializer)
        {
            _yamlSerializer = yamlSerializer;
        }

        public ElementsData Import(string directory)
        {
            var elements = new ElementsData();

            elements.ElementsDataFileInfo = ImportElementsDataFileInfo();
            elements.EquipmentAddons = ImportList<EquipmentAddon>();
            elements.WeaponMajorTypes = ImportList<WeaponMajorType>();
            elements.WeaponSubTypes = ImportList<WeaponSubType>();
            elements.WeaponEssences = ImportList<WeaponEssence>();
            elements.ArmorMajorTypes = ImportList<ArmorMajorType>();
            elements.ArmorSubTypes = ImportList<ArmorSubType>();
            elements.ArmorEssences = ImportList<ArmorEssence>();
            elements.DecorationMajorTypes = ImportList<DecorationMajorType>();
            elements.DecorationSubTypes = ImportList<DecorationSubType>();
            elements.DecorationEssences = ImportList<DecorationEssence>();
            elements.MedicineMajorTypes = ImportList<MedicineMajorType>();
            elements.MedicineSubTypes = ImportList<MedicineSubType>();
            elements.MedicineEssences = ImportList<MedicineEssence>();
            elements.MaterialMajorTypes = ImportList<MaterialMajorType>();
            elements.MaterialSubTypes = ImportList<MaterialSubType>();
            elements.MaterialEssences = ImportList<MaterialEssence>();
            elements.DamageruneSubTypes = ImportList<DamageruneSubType>();
            elements.DamageruneEssences = ImportList<DamageruneEssence>();
            elements.ArmorruneSubTypes = ImportList<ArmorruneSubType>();
            elements.ArmorruneEssences = ImportList<ArmorruneEssence>();
            elements.SkilltomeSubTypes = ImportList<SkilltomeSubType>();
            elements.SkilltomeEssences = ImportList<SkilltomeEssence>();
            elements.FlyswordEssences = ImportList<FlyswordEssence>();
            elements.WingmanwingEssences = ImportList<WingmanwingEssence>();
            elements.TownscrollEssences = ImportList<TownscrollEssence>();
            elements.UnionscrollEssences = ImportList<UnionscrollEssence>();
            elements.RevivescrollEssences = ImportList<RevivescrollEssence>();
            elements.ElementEssences = ImportList<ElementEssence>();
            elements.TaskmatterEssences = ImportList<TaskmatterEssence>();
            elements.TossmatterEssences = ImportList<TossmatterEssence>();
            elements.ProjectileTypes = ImportList<ProjectileType>();
            elements.ProjectileEssences = ImportList<ProjectileEssence>();
            elements.QuiverSubTypes = ImportList<QuiverSubType>();
            elements.QuiverEssences = ImportList<QuiverEssence>();
            elements.StoneSubTypes = ImportList<StoneSubType>();
            elements.StoneEssences = ImportList<StoneEssence>();
            elements.MonsterAddons = ImportList<MonsterAddon>();
            elements.MonsterTypes = ImportList<MonsterType>();
            elements.MonsterEssences = ImportList<MonsterEssence>();
            elements.NpcTalkServices = ImportList<NpcTalkService>();
            elements.NpcSellServices = ImportList<NpcSellService>();
            elements.NpcBuyServices = ImportList<NpcBuyService>();
            elements.NpcRepairServices = ImportList<NpcRepairService>();
            elements.NpcInstallServices = ImportList<NpcInstallService>();
            elements.NpcUninstallServices = ImportList<NpcUninstallService>();
            elements.NpcTaskInServices = ImportList<NpcTaskInService>();
            elements.NpcTaskOutServices = ImportList<NpcTaskOutService>();
            elements.NpcTaskMatterServices = ImportList<NpcTaskMatterService>();
            elements.NpcSkillServices = ImportList<NpcSkillService>();
            elements.NpcHealServices = ImportList<NpcHealService>();
            elements.NpcTransmitServices = ImportList<NpcTransmitService>();
            elements.NpcTransportServices = ImportList<NpcTransportService>();
            elements.NpcProxyServices = ImportList<NpcProxyService>();
            elements.NpcStorageServices = ImportList<NpcStorageService>();
            elements.NpcMakeServices = ImportList<NpcMakeService>();
            elements.NpcDecomposeServices = ImportList<NpcDecomposeService>();
            elements.NpcTypes = ImportList<NpcType>();
            elements.NpcEssences = ImportList<NpcEssence>();
            elements.TalkProcs = ImportList<Elements.TalkProc>();
            elements.FaceTextureEssences = ImportList<FaceTextureEssence>();
            elements.FaceShapeEssences = ImportList<FaceShapeEssence>();
            elements.FaceEmotionTypes = ImportList<FaceEmotionType>();
            elements.FaceExpressionEssences = ImportList<FaceExpressionEssence>();
            elements.FaceHairEssences = ImportList<FaceHairEssence>();
            elements.FaceMoustacheEssences = ImportList<FaceMoustacheEssence>();
            elements.ColorpickerEssences = ImportList<ColorpickerEssence>();
            elements.CustomizedataEssences = ImportList<CustomizedataEssence>();
            elements.RecipeMajorTypes = ImportList<RecipeMajorType>();
            elements.RecipeSubTypes = ImportList<RecipeSubType>();
            elements.RecipeEssences = ImportList<RecipeEssence>();
            elements.EnemyFactionConfigs = ImportList<EnemyFactionConfig>();
            elements.CharracterClassConfigs = ImportList<CharracterClassConfig>();
            elements.ParamAdjustConfigs = ImportList<ParamAdjustConfig>();
            elements.PlayerActionInfoConfigs = ImportList<PlayerActionInfoConfig>();
            elements.TaskdiceEssences = ImportList<TaskdiceEssence>();
            elements.TasknormalmatterEssences = ImportList<TasknormalmatterEssence>();
            elements.FaceFalingEssences = ImportList<FaceFalingEssence>();
            elements.PlayerLevelexpConfigs = ImportList<PlayerLevelexpConfig>();
            elements.MineTypes = ImportList<MineType>();
            elements.MineEssences = ImportList<MineEssence>();
            elements.NpcIdentifyServices = ImportList<NpcIdentifyService>();
            elements.FashionMajorTypes = ImportList<FashionMajorType>();
            elements.FashionSubTypes = ImportList<FashionSubType>();
            elements.FashionEssences = ImportList<FashionEssence>();
            elements.FaceticketMajorTypes = ImportList<FaceticketMajorType>();
            elements.FaceticketSubTypes = ImportList<FaceticketSubType>();
            elements.FaceticketEssences = ImportList<FaceticketEssence>();
            elements.FacepillMajorTypes = ImportList<FacepillMajorType>();
            elements.FacepillSubTypes = ImportList<FacepillSubType>();
            elements.FacepillEssences = ImportList<FacepillEssence>();
            elements.SuiteEssences = ImportList<SuiteEssence>();
            elements.GmGeneratorTypes = ImportList<GmGeneratorType>();
            elements.GmGeneratorEssences = ImportList<GmGeneratorEssence>();
            elements.PetTypes = ImportList<PetType>();
            elements.PetEssences = ImportList<PetEssence>();
            elements.PetEggEssences = ImportList<PetEggEssence>();
            elements.PetFoodEssences = ImportList<PetFoodEssence>();
            elements.PetFaceticketEssences = ImportList<PetFaceticketEssence>();
            elements.FireworksEssences = ImportList<FireworksEssence>();
            elements.Fireworks2Essences = ImportList<Fireworks2Essence>();
            elements.FixPositionTransmitEssences = ImportList<FixPositionTransmitEssence>();
            elements.WarTankcallinEssences = ImportList<WarTankcallinEssence>();
            elements.NpcWarTowerbuildServices = ImportList<NpcWarTowerbuildService>();
            elements.PlayerSecondlevelConfigs = ImportList<PlayerSecondlevelConfig>();
            elements.NpcResetpropServices = ImportList<NpcResetpropService>();
            elements.NpcPetnameServices = ImportList<NpcPetnameService>();
            elements.NpcPetlearnskillServices = ImportList<NpcPetlearnskillService>();
            elements.NpcPetforgetskillServices = ImportList<NpcPetforgetskillService>();
            elements.SkillmatterEssences = ImportList<SkillmatterEssence>();
            elements.RefineTicketEssences = ImportList<RefineTicketEssence>();
            elements.DestroyingEssences = ImportList<DestroyingEssence>();
            elements.NpcEquipbindServices = ImportList<NpcEquipbindService>();
            elements.NpcEquipdestroyServices = ImportList<NpcEquipdestroyService>();
            elements.NpcEquipundestroyServices = ImportList<NpcEquipundestroyService>();
            elements.BibleEssences = ImportList<BibleEssence>();
            elements.SpeakerEssences = ImportList<SpeakerEssence>();
            elements.AutompEssences = ImportList<AutompEssence>();
            elements.AutohpEssences = ImportList<AutohpEssence>();
            elements.DoubleExpEssences = ImportList<DoubleExpEssence>();
            elements.TransmitscrollEssences = ImportList<TransmitscrollEssence>();
            elements.DyeTicketEssences = ImportList<DyeTicketEssence>();
            elements.GoblinEssences = ImportList<GoblinEssence>();
            elements.GoblinEquipTypes = ImportList<GoblinEquipType>();
            elements.GoblinEquipEssences = ImportList<GoblinEquipEssence>();
            elements.GoblinExppillEssences = ImportList<GoblinExppillEssence>();
            elements.SellCertificateEssences = ImportList<SellCertificateEssence>();
            elements.TargetItemEssences = ImportList<TargetItemEssence>();
            elements.LookInfoEssences = ImportList<LookInfoEssence>();
            elements.UpgradeProductionConfigs = ImportList<UpgradeProductionConfig>();
            elements.AccStorageBlacklistConfigs = ImportList<AccStorageBlacklistConfig>();
            elements.FaceHairTextureMaps = ImportList<FaceHairTextureMap>();
            elements.MultiExpConfigs = ImportList<MultiExpConfig>();
            elements.IncSkillAbilityEssences = ImportList<IncSkillAbilityEssence>();
            elements.GodEvilConvertConfigs = ImportList<GodEvilConvertConfig>();
            elements.WeddingConfigs = ImportList<WeddingConfig>();
            elements.WeddingBookcardEssences = ImportList<WeddingBookcardEssence>();
            elements.WeddingInvitecardEssences = ImportList<WeddingInvitecardEssence>();
            elements.SharpenerEssences = ImportList<SharpenerEssence>();
            elements.FaceThirdeyeEssences = ImportList<FaceThirdeyeEssence>();
            elements.FactionFortressConfigs = ImportList<FactionFortressConfig>();
            elements.FactionBuildingSubTypes = ImportList<FactionBuildingSubType>();
            elements.FactionBuildingEssences = ImportList<FactionBuildingEssence>();
            elements.FactionMaterialEssences = ImportList<FactionMaterialEssence>();
            elements.CongregateEssences = ImportList<CongregateEssence>();
            elements.EngraveMajorTypes = ImportList<EngraveMajorType>();
            elements.EngraveSubTypes = ImportList<EngraveSubType>();
            elements.EngraveEssences = ImportList<EngraveEssence>();
            elements.NpcEngraveServices = ImportList<NpcEngraveService>();
            elements.NpcRandpropServices = ImportList<NpcRandpropService>();
            elements.RandpropTypes = ImportList<RandpropType>();
            elements.RandpropEssences = ImportList<RandpropEssence>();
            elements.WikiTabooConfigs = ImportList<WikiTabooConfig>();
            elements.ForceConfigs = ImportList<ForceConfig>();
            elements.ForceTokenEssences = ImportList<ForceTokenEssence>();
            elements.NpcForceServices = ImportList<NpcForceService>();
            elements.PlayerDeathDropConfigs = ImportList<PlayerDeathDropConfig>();
            elements.DynskillequipEssences = ImportList<DynskillequipEssence>();
            elements.ConsumePointsConfigs = ImportList<ConsumePointsConfig>();
            elements.OnlineAwardsConfigs = ImportList<OnlineAwardsConfig>();
            elements.CountryConfigs = ImportList<CountryConfig>();
            elements.GmActivityConfigs = ImportList<GmActivityConfig>();
            elements.FashionWeaponConfigs = ImportList<FashionWeaponConfig>();
            elements.PetEvolveConfigs = ImportList<PetEvolveConfig>();
            elements.PetEvolvedSkillConfigs = ImportList<PetEvolvedSkillConfig>();
            elements.MoneyConvertibleEssences = ImportList<MoneyConvertibleEssence>();
            elements.StoneChangeRecipeTypes = ImportList<StoneChangeRecipeType>();
            elements.StoneChangeRecipes = ImportList<StoneChangeRecipe>();
            elements.MeridianConfigs = ImportList<MeridianConfig>();
            elements.PetEvolvedSkillRandConfigs = ImportList<PetEvolvedSkillRandConfig>();
            elements.AutotaskDisplayConfigs = ImportList<AutotaskDisplayConfig>();
            elements.TouchShopConfigs = ImportList<TouchShopConfig>();
            elements.TitleConfigs = ImportList<TitleConfig>();
            elements.ComplexTitleConfigs = ImportList<ComplexTitleConfig>();
            elements.MonsterSpiritEssences = ImportList<MonsterSpiritEssence>();
            elements.PlayerSpiritConfigs = ImportList<PlayerSpiritConfig>();
            elements.PlayerReincarnationConfigs = ImportList<PlayerReincarnationConfig>();
            elements.HistoryStageConfigs = ImportList<HistoryStageConfig>();
            elements.HistoryAdvanceConfigs = ImportList<HistoryAdvanceConfig>();
            elements.AutoteamConfigs = ImportList<AutoteamConfig>();
            elements.PlayerRealmConfigs = ImportList<PlayerRealmConfig>();
            elements.ChariotConfigs = ImportList<ChariotConfig>();
            elements.ChariotWarConfigs = ImportList<ChariotWarConfig>();
            elements.PokerLevelexpConfigs = ImportList<PokerLevelexpConfig>();
            elements.PokerSuiteEssences = ImportList<PokerSuiteEssence>();
            elements.PokerDiceEssences = ImportList<PokerDiceEssence>();
            elements.PokerSubTypes = ImportList<PokerSubType>();
            elements.PokerEssences = ImportList<PokerEssence>();
            elements.TokenShopConfigs = ImportList<TokenShopConfig>();
            elements.ShopTokenEssences = ImportList<ShopTokenEssence>();
            elements.GtConfigs = ImportList<GtConfig>();
            elements.RandShopConfigs = ImportList<RandShopConfig>();
            elements.ProfitTimeConfigs = ImportList<ProfitTimeConfig>();
            elements.FactionPvpConfigs = ImportList<FactionPvpConfig>();
            elements.UniversalTokenEssences = ImportList<UniversalTokenEssence>();
            elements.TaskListConfigs = ImportList<TaskListConfig>();
            elements.TaskDiceByWeightConfigs = ImportList<TaskDiceByWeightConfig>();
            elements.FashionSuiteEssences = ImportList<FashionSuiteEssence>();
            elements.FashionBestColorConfigs = ImportList<FashionBestColorConfig>();
            elements.SignAwardConfigs = ImportList<SignAwardConfig>();
            elements.AstrolabeEssences = ImportList<AstrolabeEssence>();
            elements.AstrolabeRandomAddonEssences = ImportList<AstrolabeRandomAddonEssence>();
            elements.AstrolabeIncInnerPointValueEssences = ImportList<AstrolabeIncInnerPointValueEssence>();
            elements.AstrolabeIncExpEssences = ImportList<AstrolabeIncExpEssence>();
            elements.ItemPackageByProfessionEssences = ImportList<ItemPackageByProfessionEssence>();
            elements.AstrolabeLevelexpConfigs = ImportList<AstrolabeLevelexpConfig>();
            elements.AstrolabeAddonRandomConfigs = ImportList<AstrolabeAddonRandomConfig>();
            elements.AstrolabeAppearanceConfigs = ImportList<AstrolabeAppearanceConfig>();
            elements.EquipMakeHoleConfigs = ImportList<EquipMakeHoleConfig>();
            elements.SoloTowerChallengeLevelConfigs = ImportList<SoloTowerChallengeLevelConfig>();
            elements.SoloTowerChallengeAwardPageConfigs = ImportList<SoloTowerChallengeAwardPageConfig>();
            elements.SoloTowerChallengeAwardListConfigs = ImportList<SoloTowerChallengeAwardListConfig>();
            elements.SoloTowerChallengeScoreCostConfigs = ImportList<SoloTowerChallengeScoreCostConfig>();
            elements.MnfactionWarConfigs = ImportList<MnfactionWarConfig>();
            elements.NpcCrossServerServices = ImportList<NpcCrossServerService>();
            elements.HomeConfigs = ImportList<HomeConfig>();
            elements.HomeProductsConfigs = ImportList<HomeProductsConfig>();
            elements.HomeResourceProduceConfigs = ImportList<HomeResourceProduceConfig>();
            elements.HomeFormulasProduceRecipes = ImportList<HomeFormulasProduceRecipe>();
            elements.HomeFormulasItemEssences = ImportList<HomeFormulasItemEssence>();
            elements.HomeProduceServiceConfigs = ImportList<HomeProduceServiceConfig>();
            elements.HomeFactoryConfigs = ImportList<HomeFactoryConfig>();
            elements.HomeItemMajorTypes = ImportList<HomeItemMajorType>();
            elements.HomeItemSubTypes = ImportList<HomeItemSubType>();
            elements.HomeItemEntities = ImportList<HomeItemEntity>();
            elements.HomeFormulasProduceMajorTypes = ImportList<HomeFormulasProduceMajorType>();
            elements.HomeFormulasProduceSubTypes = ImportList<HomeFormulasProduceSubType>();
            elements.HomeFormulasItemMajorTypes = ImportList<HomeFormulasItemMajorType>();
            elements.HomeFormulasItemSubTypes = ImportList<HomeFormulasItemSubType>();
            elements.HomeStorageTaskConfigs = ImportList<HomeStorageTaskConfig>();
            elements.WishTributeEssences = ImportList<WishTributeEssence>();
            elements.RedPacketPaperEssences = ImportList<RedPacketPaperEssence>();


            return elements;

            T[] ImportList<T>() where T : Elements.IElementsType
            {
                var path = TypeToPath<T>();
                var list = Deserialize<T[]>(path);
                elements.Lists.Add(typeof(T).Name, list.Cast<Elements.IElementsType>().ToArray());
                return list;
            }

            Elements.ElementsDataFileInfo ImportElementsDataFileInfo()
            {
                var path = TypeToPath<Elements.ElementsDataFileInfo>();
                return Deserialize<Elements.ElementsDataFileInfo>(path);
            }

            T Deserialize<T>(string path)
            {
                var file = File.ReadAllBytes(path);
                using var stream = new MemoryStream(file);
                return _yamlSerializer.DeSerialize<T>(stream);
            }

            string TypeToPath<T>()
            {
                var listName = typeof(T).Name;
                var path = Path.Combine(directory, $"{listName}.yaml");
                return path;
            }
        }
    }
}
