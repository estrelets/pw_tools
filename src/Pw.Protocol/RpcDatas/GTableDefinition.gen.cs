using System;
using System.Collections.Generic;
using System.CodeDom.Compiler;
using Pw.Serializer;
using Pw.Protocols;

//ReSharper disable InconsistentNaming
//ReSharper disable IdentifierTypo
//ReSharper disable CommentTypo
namespace Pw.RpcDatas
{
    [GeneratedCode("Pw.ProtocolImporter", "1")]
    public class GTableDefinition
    {
        [Order(0)]
        public User User { get; set; }
        [Order(1)]
        public GRoleBase @Base { get; set; }
        [Order(2)]
        public GRoleStatus Status { get; set; }
        [Order(3)]
        public GRoleTask Task { get; set; }
        [Order(4)]
        public GRolePocket Inventory { get; set; }
        [Order(5)]
        public GRoleEquipment Equipment { get; set; }
        [Order(6)]
        public GRoleStorehouse Storehouse { get; set; }
        [Order(7)]
        public GMailBox Mailbox { get; set; }
        [Order(8)]
        public GFriendList Friends { get; set; }
        [Order(9)]
        public Message[] Messages { get; set; }
        [Order(10)]
        public GFactionInfo Factioninfo { get; set; }
        [Order(11)]
        public StockOrder Order { get; set; }
        [Order(12)]
        public GSysLog Syslog { get; set; }
        [Order(13)]
        public byte[] Config { get; set; }
        [Order(14)]
        public int FactionName { get; set; }
        [Order(15)]
        public int Waitdel { get; set; }
        [Order(16)]
        public GRoleTableClsconfig Clsconfig { get; set; }
        [Order(17)]
        public int RoleName { get; set; }
        [Order(18)]
        public char Shoplog { get; set; }
        [Order(19)]
        public GAuctionDetail Auction { get; set; }
        [Order(20)]
        public GUserFaction Userfaction { get; set; }
        [Order(21)]
        public char Sellpoint { get; set; }
        [Order(22)]
        public char Translog { get; set; }
        [Order(23)]
        public GTerritoryStore City { get; set; }
        [Order(24)]
        public byte[] Gtask { get; set; }
        //ÕËºÅ²Ö¿â
        [Order(25)]
        public GUserStorehouse Userstore { get; set; }
        [Order(26)]
        public GWebTradeDetail Webtrade { get; set; }
        [Order(27)]
        public GWebTradeDetail Webtradesold { get; set; }
        [Order(28)]
        public GServerData ServerData { get; set; }
        [Order(29)]
        public GFactionFortressDetail Factionfortress { get; set; }
        [Order(30)]
        public GFactionRelation Factionrelation { get; set; }
        [Order(31)]
        public GForceGlobalDataList Force { get; set; }
        [Order(32)]
        public GFriendExtra Friendext { get; set; }
        [Order(33)]
        public GGlobalControlData Globalcontrol { get; set; }
        [Order(34)]
        public byte[] Rolenamehis { get; set; }
        [Order(35)]
        public KingElectionDetail Kingelection { get; set; }
        [Order(36)]
        public PShopDetail Playershop { get; set; }
        [Order(37)]
        public WebOrderItemDetail Weborderitem { get; set; }
        [Order(38)]
        public PlayerProfileData Playerprofile { get; set; }
        [Order(39)]
        public GUniqueDataElem UniqueData { get; set; }
        [Order(40)]
        public char Recalluser { get; set; }
    }
}
