using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace Pw.ProtocolImporter.Tests
{
    [TestClass]
    public class TypeNameParsersTests
    {
        [TestMethod]
        [DataRow("char")]
        [DataRow("ACQ")]
        [DataRow("ACUserCodeResVector")]
        [DataRow("ACLogInfoVector")]
        [DataRow("ACMouseInfoVector")]
        [DataRow("ACStackPatternVector")]
        [DataRow("ACPlatformInfoVector")]
        [DataRow("ACCPUInfoVector")]
        [DataRow("ACMemInfoVector")]
        [DataRow("ACAdapterInfoVector")]
        [DataRow("ACProtocolStatVector")]
        [DataRow("IntDataVector")]
        [DataRow("ACThreadTime")]
        [DataRow("ACThreadTimeVector")]
        [DataRow("IntOctetsVector")]
        [DataRow("OctetsVector")]
        [DataRow("GFriendInfo")]
        [DataRow("GRoleForbid")]
        [DataRow("ByteVector")]
        [DataRow("unsigned char")]
        [DataRow("float")]
        [DataRow("unsigned short")]
        [DataRow("GAuctionItem")]
        [DataRow("GRoleInventoryVector")]
        [DataRow("GAuctionDetail")]
        [DataRow("short")]
        [DataRow("PlayerVector")]
        [DataRow("GRoomDetail")]
        [DataRow("GChatRoomVector")]
        [DataRow("GCountryCapitalVector")]
        [DataRow("GFactionFortressBriefInfo")]
        [DataRow("RoleInfo")]
        [DataRow("GFriendExtInfoVector")]
        [DataRow("IntVector")]
        [DataRow("MerchantDiscountVector")]
        [DataRow("FactionOPSyncInfo")]
        [DataRow("FactionIDBean")]
        [DataRow("FactionInfoBean")]
        [DataRow("FactionTitleBeanVector")]
        [DataRow("FMemberInfoVector")]
        [DataRow("GFactionAllianceVector")]
        [DataRow("GFactionHostileVector")]
        [DataRow("GFactionRelationApplyVector")]
        [DataRow("RoleBeanVector")]
        [DataRow("RoleMsgBean")]
        [DataRow("GSendAUMailRecordVector")]
        [DataRow("GFactionBaseInfo")]
        [DataRow("GGroupInfoVector")]
        [DataRow("GFriendInfoVector")]
        [DataRow("CharVector")]
        [DataRow("GMailHeaderVector")]
        [DataRow("GMail")]
        [DataRow("PlayerBriefInfoVector")]
        [DataRow("GUserFaction")]
        [DataRow("GRoleInfo")]
        [DataRow("RewardItemVector")]
        [DataRow("MessageVector")]
        [DataRow("GMailSyncData")]
        [DataRow("GMControlGameResVector")]
        [DataRow("PlayerConsumeInfoVector")]
        [DataRow("GMPlayerInfoVector")]
        [DataRow("KEKing")]
        [DataRow("KECandidateVector")]
        [DataRow("GFactionFortressInfo2")]
        [DataRow("GRoleBase")]
        [DataRow("PFactionInfoVector")]
        [DataRow("PlayerProfileData")]
        [DataRow("OnlinePlayerStatusVector")]
        [DataRow("TraderInfo")]
        [DataRow("TimeInfo")]
        [DataRow("PostInfo")]
        [DataRow("PShopItem")]
        [DataRow("GRoleInventory")]
        [DataRow("PShopItemVector")]
        [DataRow("PShopItemEntryVector")]
        [DataRow("PShopEntryVector")]
        [DataRow("PShopBase")]
        [DataRow("PShopDetail")]
        [DataRow("QPDiscountInfoVector")]
        [DataRow("GameAttrVector")]
        [DataRow("GRoleForbidVector")]
        [DataRow("RoleInfoBean")]
        [DataRow("RoleBean")]
        [DataRow("RoleDetailBeanVector")]
        [DataRow("RoleInfoVector")]
        [DataRow("RoleMsgBeanVector")]
        [DataRow("FactionIDBeanVector")]
        [DataRow("RoleGroupBeanVector")]
        [DataRow("RoleInfoBeanVector")]
        [DataRow("RoleStatusBean")]
        [DataRow("SellPointInfo")]
        [DataRow("CrossPlayerData")]
        [DataRow("SNSRoleBrief")]
        [DataRow("SNSRoleSkills")]
        [DataRow("SNSRoleEquipment")]
        [DataRow("SNSRolePetCorral")]
        [DataRow("SSOUser")]
        [DataRow("TeamBeanVector")]
        [DataRow("GSysAuctionItem")]
        [DataRow("MailGoodsInventory")]
        [DataRow("TankBattlePlayerScoreInfo")]
        [DataRow("TankBattlePlayerScoreInfoVector")]
        [DataRow("TeamBean")]
        [DataRow("TransID")]
        [DataRow("SellID")]
        [DataRow("GUniqueDataElemNodeVector")]
        [DataRow("bool")]
        [DataRow("GWebTradeDetail")]
        [DataRow("GWebTradeItem")]
        [DataRow("std::vector")]
        public void ParseSimpleVariableType(string typeString)
        {
            var result = new TypeNameParsers().ParseType(typeString);


            Assert.AreEqual(typeString, result.ToString());
        }

        [TestMethod]
        public void ParseGeneric()
        {
            var genericTypeString = "std::vector<ACOnlineStatus, int>";


            var result = new TypeNameParsers().ParseType(genericTypeString) as GenericType;


            Assert.IsNotNull(result);
            Assert.AreEqual("std::vector", result.Generic.Name);
            Assert.AreEqual("ACOnlineStatus", result.Parameters[0].ToString());
            Assert.AreEqual("int", result.Parameters[1].ToString());
        }

        [TestMethod]
        public void ParseRecursiveGeneric()
        {
            var genericTypeString = "std::map<int, std::vector<std::pair<int, std::pair<int, time_t>>>>";


            var result = new TypeNameParsers().ParseType(genericTypeString) as GenericType;
            var intTimePair =
                (GenericType)
                ((GenericType) ((GenericType) result?.Parameters[1])?.Parameters[0])?.Parameters[1];


            Assert.IsNotNull(result);
            Assert.AreEqual("std::map", result.Generic.Name);
            Assert.AreEqual("int", result.Parameters[0].ToString());

            Assert.IsNotNull(intTimePair);
            Assert.AreEqual("int", intTimePair.Parameters[0].ToString());
            Assert.AreEqual("time_t", intTimePair.Parameters[1].ToString());
        }

        [TestMethod]
        public void GenericWithSpace()
        {
            var genericTypeString = "std::vector< int >";
            var result = new TypeNameParsers().ParseType(genericTypeString);
            var generic = result as GenericType;


            Assert.IsNotNull(generic);
            Assert.AreEqual(1, generic.Parameters.Length);
        }
    }
}
