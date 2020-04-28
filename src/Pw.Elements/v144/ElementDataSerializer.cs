using System;
using System.IO;
using System.Linq;
using Pw.Serializer;

namespace Pw.Elements.v144
{
    public class ElementDataSerializer : IElementDataSerializer
    {
        public IElementData Deserialize(Stream stream)
        {
            var reader = new BinaryReader(stream);
            var serializer = new ElementsSerializer();

            var elements = new ElementData();

            elements.ElementMetadata = new ElementMetadata();
            elements.ElementMetadata.ReadVersion(reader);

            if (elements.ElementMetadata.Version != 60)
            {
                throw new ApplicationException($"Not supported version {elements.ElementMetadata.Version}");
            }

            elements.ElementMetadata.ReadHeader(reader);

            elements.EquipmentAddons = ReadList<EquipmentAddon>();
            elements.WeaponMajorTypes = ReadList<WeaponMajorType>();
            elements.WeaponSubTypes = ReadList<WeaponSubType>();
            elements.WeaponEssences = ReadList<WeaponEssence>();
            elements.ArmorMajorTypes = ReadList<ArmorMajorType>();
            elements.ArmorSubTypes = ReadList<ArmorSubType>();
            elements.ArmorEssences = ReadList<ArmorEssence>();
            elements.DecorationMajorTypes = ReadList<DecorationMajorType>();
            elements.DecorationSubTypes = ReadList<DecorationSubType>();
            elements.DecorationEssences = ReadList<DecorationEssence>();
            elements.MedicineMajorTypes = ReadList<MedicineMajorType>();
            elements.MedicineSubTypes = ReadList<MedicineSubType>();
            elements.MedicineEssences = ReadList<MedicineEssence>();
            elements.MaterialMajorTypes = ReadList<MaterialMajorType>();
            elements.MaterialSubTypes = ReadList<MaterialSubType>();
            elements.MaterialEssences = ReadList<MaterialEssence>();
            elements.DamageruneSubTypes = ReadList<DamageruneSubType>();
            elements.DamageruneEssences = ReadList<DamageruneEssence>();
            elements.ArmorruneSubTypes = ReadList<ArmorruneSubType>();
            elements.ArmorruneEssences = ReadList<ArmorruneEssence>();

            elements.ElementMetadata.ReadFirstMetadata(reader);

            elements.SkilltomeSubTypes = ReadList<SkilltomeSubType>();
            elements.SkilltomeEssences = ReadList<SkilltomeEssence>();
            elements.FlyswordEssences = ReadList<FlyswordEssence>();
            elements.WingmanwingEssences = ReadList<WingmanwingEssence>();
            elements.TownscrollEssences = ReadList<TownscrollEssence>();
            elements.UnionscrollEssences = ReadList<UnionscrollEssence>();
            elements.RevivescrollEssences = ReadList<RevivescrollEssence>();
            elements.ElementEssences = ReadList<ElementEssence>();
            elements.TaskmatterEssences = ReadList<TaskmatterEssence>();
            elements.TossmatterEssences = ReadList<TossmatterEssence>();
            elements.ProjectileTypes = ReadList<ProjectileType>();
            elements.ProjectileEssences = ReadList<ProjectileEssence>();
            elements.QuiverSubTypes = ReadList<QuiverSubType>();
            elements.QuiverEssences = ReadList<QuiverEssence>();
            elements.StoneSubTypes = ReadList<StoneSubType>();
            elements.StoneEssences = ReadList<StoneEssence>();
            elements.MonsterAddons = ReadList<MonsterAddon>();
            elements.MonsterTypes = ReadList<MonsterType>();
            elements.MonsterEssences = ReadList<MonsterEssence>();
            elements.NpcTalkServices = ReadList<NpcTalkService>();
            elements.NpcSellServices = ReadList<NpcSellService>();
            elements.NpcBuyServices = ReadList<NpcBuyService>();
            elements.NpcRepairServices = ReadList<NpcRepairService>();
            elements.NpcInstallServices = ReadList<NpcInstallService>();
            elements.NpcUninstallServices = ReadList<NpcUninstallService>();
            elements.NpcTaskInServices = ReadList<NpcTaskInService>();
            elements.NpcTaskOutServices = ReadList<NpcTaskOutService>();
            elements.NpcTaskMatterServices = ReadList<NpcTaskMatterService>();
            elements.NpcSkillServices = ReadList<NpcSkillService>();
            elements.NpcHealServices = ReadList<NpcHealService>();
            elements.NpcTransmitServices = ReadList<NpcTransmitService>();
            elements.NpcTransportServices = ReadList<NpcTransportService>();
            elements.NpcProxyServices = ReadList<NpcProxyService>();
            elements.NpcStorageServices = ReadList<NpcStorageService>();
            elements.NpcMakeServices = ReadList<NpcMakeService>();
            elements.NpcDecomposeServices = ReadList<NpcDecomposeService>();
            elements.NpcTypes = ReadList<NpcType>();
            elements.NpcEssences = ReadList<NpcEssence>();
            elements.TalkProcs = ReadList<TalkProc>();
            elements.FaceTextureEssences = ReadList<FaceTextureEssence>();
            elements.FaceShapeEssences = ReadList<FaceShapeEssence>();
            elements.FaceEmotionTypes = ReadList<FaceEmotionType>();
            elements.FaceExpressionEssences = ReadList<FaceExpressionEssence>();
            elements.FaceHairEssences = ReadList<FaceHairEssence>();
            elements.FaceMoustacheEssences = ReadList<FaceMoustacheEssence>();
            elements.ColorpickerEssences = ReadList<ColorpickerEssence>();
            elements.CustomizedataEssences = ReadList<CustomizedataEssence>();
            elements.RecipeMajorTypes = ReadList<RecipeMajorType>();
            elements.RecipeSubTypes = ReadList<RecipeSubType>();
            elements.RecipeEssences = ReadList<RecipeEssence>();
            elements.EnemyFactionConfigs = ReadList<EnemyFactionConfig>();
            elements.CharracterClassConfigs = ReadList<CharracterClassConfig>();
            elements.ParamAdjustConfigs = ReadList<ParamAdjustConfig>();
            elements.PlayerActionInfoConfigs = ReadList<PlayerActionInfoConfig>();
            elements.TaskdiceEssences = ReadList<TaskdiceEssence>();
            elements.TasknormalmatterEssences = ReadList<TasknormalmatterEssence>();
            elements.FaceFalingEssences = ReadList<FaceFalingEssence>();
            elements.PlayerLevelexpConfigs = ReadList<PlayerLevelexpConfig>();
            elements.MineTypes = ReadList<MineType>();
            elements.MineEssences = ReadList<MineEssence>();
            elements.NpcIdentifyServices = ReadList<NpcIdentifyService>();
            elements.FashionMajorTypes = ReadList<FashionMajorType>();
            elements.FashionSubTypes = ReadList<FashionSubType>();
            elements.FashionEssences = ReadList<FashionEssence>();
            elements.FaceticketMajorTypes = ReadList<FaceticketMajorType>();
            elements.FaceticketSubTypes = ReadList<FaceticketSubType>();
            elements.FaceticketEssences = ReadList<FaceticketEssence>();
            elements.FacepillMajorTypes = ReadList<FacepillMajorType>();
            elements.FacepillSubTypes = ReadList<FacepillSubType>();
            elements.FacepillEssences = ReadList<FacepillEssence>();
            elements.SuiteEssences = ReadList<SuiteEssence>();
            elements.GmGeneratorTypes = ReadList<GmGeneratorType>();
            elements.GmGeneratorEssences = ReadList<GmGeneratorEssence>();
            elements.PetTypes = ReadList<PetType>();
            elements.PetEssences = ReadList<PetEssence>();
            elements.PetEggEssences = ReadList<PetEggEssence>();
            elements.PetFoodEssences = ReadList<PetFoodEssence>();
            elements.PetFaceticketEssences = ReadList<PetFaceticketEssence>();
            elements.FireworksEssences = ReadList<FireworksEssence>();
            elements.WarTankcallinEssences = ReadList<WarTankcallinEssence>();

            elements.ElementMetadata.ReadSecondMetadata(reader);

            elements.NpcWarTowerbuildServices = ReadList<NpcWarTowerbuildService>();
            elements.PlayerSecondlevelConfigs = ReadList<PlayerSecondlevelConfig>();
            elements.NpcResetpropServices = ReadList<NpcResetpropService>();
            elements.NpcPetnameServices = ReadList<NpcPetnameService>();
            elements.NpcPetlearnskillServices = ReadList<NpcPetlearnskillService>();
            elements.NpcPetforgetskillServices = ReadList<NpcPetforgetskillService>();
            elements.SkillmatterEssences = ReadList<SkillmatterEssence>();
            elements.RefineTicketEssences = ReadList<RefineTicketEssence>();
            elements.DestroyingEssences = ReadList<DestroyingEssence>();
            elements.NpcEquipbindServices = ReadList<NpcEquipbindService>();
            elements.NpcEquipdestroyServices = ReadList<NpcEquipdestroyService>();
            elements.NpcEquipundestroyServices = ReadList<NpcEquipundestroyService>();
            elements.BibleEssences = ReadList<BibleEssence>();
            elements.SpeakerEssences = ReadList<SpeakerEssence>();
            elements.AutohpEssences = ReadList<AutohpEssence>();
            elements.AutompEssences = ReadList<AutompEssence>();
            elements.DoubleExpEssences = ReadList<DoubleExpEssence>();
            elements.TransmitscrollEssences = ReadList<TransmitscrollEssence>();
            elements.DyeTicketEssences = ReadList<DyeTicketEssence>();
            elements.GoblinEssences = ReadList<GoblinEssence>();
            elements.GoblinEquipTypes = ReadList<GoblinEquipType>();
            elements.GoblinEquipEssences = ReadList<GoblinEquipEssence>();
            elements.GoblinExppillEssences = ReadList<GoblinExppillEssence>();
            elements.SellCertificateEssences = ReadList<SellCertificateEssence>();
            elements.TargetItemEssences = ReadList<TargetItemEssence>();
            elements.LookInfoEssences = ReadList<LookInfoEssence>();
            elements.UpgradeProductionConfigs = ReadList<UpgradeProductionConfig>();
            elements.AccStorageBlacklistConfigs = ReadList<AccStorageBlacklistConfig>();
            elements.FaceHairTextureMaps = ReadList<FaceHairTextureMap>();
            elements.MultiExpConfigs = ReadList<MultiExpConfig>();
            elements.IncSkillAbilityEssences = ReadList<IncSkillAbilityEssence>();
            elements.GodEvilConvertConfigs = ReadList<GodEvilConvertConfig>();
            elements.WeddingConfigs = ReadList<WeddingConfig>();
            elements.WeddingBookcardEssences = ReadList<WeddingBookcardEssence>();
            elements.WeddingInvitecardEssences = ReadList<WeddingInvitecardEssence>();
            elements.SharpenerEssences = ReadList<SharpenerEssence>();
            elements.FaceThirdeyeEssences = ReadList<FaceThirdeyeEssence>();
            elements.FactionFortressConfigs = ReadList<FactionFortressConfig>();
            elements.FactionBuildingSubTypes = ReadList<FactionBuildingSubType>();
            elements.FactionBuildingEssences = ReadList<FactionBuildingEssence>();
            elements.FactionMaterialEssences = ReadList<FactionMaterialEssence>();
            elements.CongregateEssences = ReadList<CongregateEssence>();
            elements.EngraveMajorTypes = ReadList<EngraveMajorType>();
            elements.EngraveSubTypes = ReadList<EngraveSubType>();
            elements.EngraveEssences = ReadList<EngraveEssence>();
            elements.NpcEngraveServices = ReadList<NpcEngraveService>();
            elements.NpcRandpropServices = ReadList<NpcRandpropService>();
            elements.RandpropTypes = ReadList<RandpropType>();
            elements.RandpropEssences = ReadList<RandpropEssence>();
            elements.WikiTabooConfigs = ReadList<WikiTabooConfig>();

            return elements;

            T[] ReadList<T>() where T : IElement
            {
                int count = reader.ReadInt32();

                var list = Enumerable
                    .Range(0, count)
                    .Select(_ => serializer.DeSerialize<T>(stream))
                    .ToArray();

                elements.Lists.Add(list.Cast<IElement>().ToArray());
                return list;
            }
        }


        public void Serialize(Stream stream, IElementData elementsData)
        {
            var elements = elementsData as ElementData;

            if (elements == null)
            {
                throw new ArgumentException("Is not v144 element data.", nameof(elementsData));
            }

            var serilizer = new ElementsSerializer();
            var writer = new BinaryWriter(stream);

            elements.ElementMetadata.WriteVersion(writer);
            elements.ElementMetadata.WriteHeader(writer);

            WriteList(elements.EquipmentAddons);
            WriteList(elements.WeaponMajorTypes);
            WriteList(elements.WeaponSubTypes);
            WriteList(elements.WeaponEssences);
            WriteList(elements.ArmorMajorTypes);
            WriteList(elements.ArmorSubTypes);
            WriteList(elements.ArmorEssences);
            WriteList(elements.DecorationMajorTypes);
            WriteList(elements.DecorationSubTypes);
            WriteList(elements.DecorationEssences);
            WriteList(elements.MedicineMajorTypes);
            WriteList(elements.MedicineSubTypes);
            WriteList(elements.MedicineEssences);
            WriteList(elements.MaterialMajorTypes);
            WriteList(elements.MaterialSubTypes);
            WriteList(elements.MaterialEssences);
            WriteList(elements.DamageruneSubTypes);
            WriteList(elements.DamageruneEssences);
            WriteList(elements.ArmorruneSubTypes);
            WriteList(elements.ArmorruneEssences);

            elements.ElementMetadata.WriteFirstMetadata(writer);

            WriteList(elements.SkilltomeSubTypes);
            WriteList(elements.SkilltomeEssences);
            WriteList(elements.FlyswordEssences);
            WriteList(elements.WingmanwingEssences);
            WriteList(elements.TownscrollEssences);
            WriteList(elements.UnionscrollEssences);
            WriteList(elements.RevivescrollEssences);
            WriteList(elements.ElementEssences);
            WriteList(elements.TaskmatterEssences);
            WriteList(elements.TossmatterEssences);
            WriteList(elements.ProjectileTypes);
            WriteList(elements.ProjectileEssences);
            WriteList(elements.QuiverSubTypes);
            WriteList(elements.QuiverEssences);
            WriteList(elements.StoneSubTypes);
            WriteList(elements.StoneEssences);
            WriteList(elements.MonsterAddons);
            WriteList(elements.MonsterTypes);
            WriteList(elements.MonsterEssences);
            WriteList(elements.NpcTalkServices);
            WriteList(elements.NpcSellServices);
            WriteList(elements.NpcBuyServices);
            WriteList(elements.NpcRepairServices);
            WriteList(elements.NpcInstallServices);
            WriteList(elements.NpcUninstallServices);
            WriteList(elements.NpcTaskInServices);
            WriteList(elements.NpcTaskOutServices);
            WriteList(elements.NpcTaskMatterServices);
            WriteList(elements.NpcSkillServices);
            WriteList(elements.NpcHealServices);
            WriteList(elements.NpcTransmitServices);
            WriteList(elements.NpcTransportServices);
            WriteList(elements.NpcProxyServices);
            WriteList(elements.NpcStorageServices);
            WriteList(elements.NpcMakeServices);
            WriteList(elements.NpcDecomposeServices);
            WriteList(elements.NpcTypes);
            WriteList(elements.NpcEssences);
            WriteList(elements.TalkProcs);
            WriteList(elements.FaceTextureEssences);
            WriteList(elements.FaceShapeEssences);
            WriteList(elements.FaceEmotionTypes);
            WriteList(elements.FaceExpressionEssences);
            WriteList(elements.FaceHairEssences);
            WriteList(elements.FaceMoustacheEssences);
            WriteList(elements.ColorpickerEssences);
            WriteList(elements.CustomizedataEssences);
            WriteList(elements.RecipeMajorTypes);
            WriteList(elements.RecipeSubTypes);
            WriteList(elements.RecipeEssences);
            WriteList(elements.EnemyFactionConfigs);
            WriteList(elements.CharracterClassConfigs);
            WriteList(elements.ParamAdjustConfigs);
            WriteList(elements.PlayerActionInfoConfigs);
            WriteList(elements.TaskdiceEssences);
            WriteList(elements.TasknormalmatterEssences);
            WriteList(elements.FaceFalingEssences);
            WriteList(elements.PlayerLevelexpConfigs);
            WriteList(elements.MineTypes);
            WriteList(elements.MineEssences);
            WriteList(elements.NpcIdentifyServices);
            WriteList(elements.FashionMajorTypes);
            WriteList(elements.FashionSubTypes);
            WriteList(elements.FashionEssences);
            WriteList(elements.FaceticketMajorTypes);
            WriteList(elements.FaceticketSubTypes);
            WriteList(elements.FaceticketEssences);
            WriteList(elements.FacepillMajorTypes);
            WriteList(elements.FacepillSubTypes);
            WriteList(elements.FacepillEssences);
            WriteList(elements.SuiteEssences);
            WriteList(elements.GmGeneratorTypes);
            WriteList(elements.GmGeneratorEssences);
            WriteList(elements.PetTypes);
            WriteList(elements.PetEssences);
            WriteList(elements.PetEggEssences);
            WriteList(elements.PetFoodEssences);
            WriteList(elements.PetFaceticketEssences);
            WriteList(elements.FireworksEssences);
            WriteList(elements.WarTankcallinEssences);

            elements.ElementMetadata.WriteSecondMetadata(writer);

            WriteList(elements.NpcWarTowerbuildServices);
            WriteList(elements.PlayerSecondlevelConfigs);
            WriteList(elements.NpcResetpropServices);
            WriteList(elements.NpcPetnameServices);
            WriteList(elements.NpcPetlearnskillServices);
            WriteList(elements.NpcPetforgetskillServices);
            WriteList(elements.SkillmatterEssences);
            WriteList(elements.RefineTicketEssences);
            WriteList(elements.DestroyingEssences);
            WriteList(elements.NpcEquipbindServices);
            WriteList(elements.NpcEquipdestroyServices);
            WriteList(elements.NpcEquipundestroyServices);
            WriteList(elements.BibleEssences);
            WriteList(elements.SpeakerEssences);
            WriteList(elements.AutohpEssences);
            WriteList(elements.AutompEssences);
            WriteList(elements.DoubleExpEssences);
            WriteList(elements.TransmitscrollEssences);
            WriteList(elements.DyeTicketEssences);
            WriteList(elements.GoblinEssences);
            WriteList(elements.GoblinEquipTypes);
            WriteList(elements.GoblinEquipEssences);
            WriteList(elements.GoblinExppillEssences);
            WriteList(elements.SellCertificateEssences);
            WriteList(elements.TargetItemEssences);
            WriteList(elements.LookInfoEssences);
            WriteList(elements.UpgradeProductionConfigs);
            WriteList(elements.AccStorageBlacklistConfigs);
            WriteList(elements.FaceHairTextureMaps);
            WriteList(elements.MultiExpConfigs);
            WriteList(elements.IncSkillAbilityEssences);
            WriteList(elements.GodEvilConvertConfigs);
            WriteList(elements.WeddingConfigs);
            WriteList(elements.WeddingBookcardEssences);
            WriteList(elements.WeddingInvitecardEssences);
            WriteList(elements.SharpenerEssences);
            WriteList(elements.FaceThirdeyeEssences);
            WriteList(elements.FactionFortressConfigs);
            WriteList(elements.FactionBuildingSubTypes);
            WriteList(elements.FactionBuildingEssences);
            WriteList(elements.FactionMaterialEssences);
            WriteList(elements.CongregateEssences);
            WriteList(elements.EngraveMajorTypes);
            WriteList(elements.EngraveSubTypes);
            WriteList(elements.EngraveEssences);
            WriteList(elements.NpcEngraveServices);
            WriteList(elements.NpcRandpropServices);
            WriteList(elements.RandpropTypes);
            WriteList(elements.RandpropEssences);
            WriteList(elements.WikiTabooConfigs);

            void WriteList<T>(T[] list) where T : IElement
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
