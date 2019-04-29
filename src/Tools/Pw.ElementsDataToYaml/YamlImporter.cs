using System.IO;
using System.Linq;
using Pw.Elements;

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
            elements.TalkProcs = ImportList<TalkProc>();
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
            elements.AutohpEssences = ImportList<AutohpEssence>();
            elements.AutompEssences = ImportList<AutompEssence>();
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

            return elements;

            T[] ImportList<T>() where T : IElementsType
            {
                var path = TypeToPath<T>();
                var list = Deserialize<T[]>(path);
                elements.Lists.Add(typeof(T).Name, list.Cast<IElementsType>().ToArray());
                return list;
            }

            ElementsDataFileInfo ImportElementsDataFileInfo()
            {
                var path = TypeToPath<ElementsDataFileInfo>();
                return Deserialize<ElementsDataFileInfo>(path);
            }

            T Deserialize<T>(string path)
            {
                using (var stream = File.OpenRead(path))
                {
                    return _yamlSerializer.DeSerialize<T>(stream);
                }
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
