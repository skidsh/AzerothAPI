using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AzerothAPI.Data.Models.World;

namespace AzerothAPI.Data.Context
{
    public partial class WorldDb : DbContext
    {
        public WorldDb()
        {
        }

        public WorldDb(DbContextOptions<WorldDb> options)
            : base(options)
        {
        }

        public virtual DbSet<AchievementCategoryDbc> AchievementCategoryDbcs { get; set; } = null!;
        public virtual DbSet<AchievementCriteriaDatum> AchievementCriteriaData { get; set; } = null!;
        public virtual DbSet<AchievementCriteriaDbc> AchievementCriteriaDbcs { get; set; } = null!;
        public virtual DbSet<AchievementDbc> AchievementDbcs { get; set; } = null!;
        public virtual DbSet<AchievementReward> AchievementRewards { get; set; } = null!;
        public virtual DbSet<AchievementRewardLocale> AchievementRewardLocales { get; set; } = null!;
        public virtual DbSet<AcoreString> AcoreStrings { get; set; } = null!;
        public virtual DbSet<AreagroupDbc> AreagroupDbcs { get; set; } = null!;
        public virtual DbSet<AreapoiDbc> AreapoiDbcs { get; set; } = null!;
        public virtual DbSet<AreatableDbc> AreatableDbcs { get; set; } = null!;
        public virtual DbSet<Areatrigger> Areatriggers { get; set; } = null!;
        public virtual DbSet<AreatriggerInvolvedrelation> AreatriggerInvolvedrelations { get; set; } = null!;
        public virtual DbSet<AreatriggerScript> AreatriggerScripts { get; set; } = null!;
        public virtual DbSet<AreatriggerTavern> AreatriggerTaverns { get; set; } = null!;
        public virtual DbSet<AreatriggerTeleport> AreatriggerTeleports { get; set; } = null!;
        public virtual DbSet<AuctionhouseDbc> AuctionhouseDbcs { get; set; } = null!;
        public virtual DbSet<BankbagslotpricesDbc> BankbagslotpricesDbcs { get; set; } = null!;
        public virtual DbSet<BarbershopstyleDbc> BarbershopstyleDbcs { get; set; } = null!;
        public virtual DbSet<BattlegroundTemplate> BattlegroundTemplates { get; set; } = null!;
        public virtual DbSet<BattlemasterEntry> BattlemasterEntries { get; set; } = null!;
        public virtual DbSet<BattlemasterlistDbc> BattlemasterlistDbcs { get; set; } = null!;
        public virtual DbSet<BroadcastText> BroadcastTexts { get; set; } = null!;
        public virtual DbSet<BroadcastTextLocale> BroadcastTextLocales { get; set; } = null!;
        public virtual DbSet<CharstartoutfitDbc> CharstartoutfitDbcs { get; set; } = null!;
        public virtual DbSet<ChartitlesDbc> ChartitlesDbcs { get; set; } = null!;
        public virtual DbSet<ChatchannelsDbc> ChatchannelsDbcs { get; set; } = null!;
        public virtual DbSet<ChrclassesDbc> ChrclassesDbcs { get; set; } = null!;
        public virtual DbSet<ChrracesDbc> ChrracesDbcs { get; set; } = null!;
        public virtual DbSet<CinematiccameraDbc> CinematiccameraDbcs { get; set; } = null!;
        public virtual DbSet<CinematicsequencesDbc> CinematicsequencesDbcs { get; set; } = null!;
        public virtual DbSet<Command> Commands { get; set; } = null!;
        public virtual DbSet<Condition> Conditions { get; set; } = null!;
        public virtual DbSet<Creature> Creatures { get; set; } = null!;
        public virtual DbSet<CreatureAddon> CreatureAddons { get; set; } = null!;
        public virtual DbSet<CreatureClasslevelstat> CreatureClasslevelstats { get; set; } = null!;
        public virtual DbSet<CreatureEquipTemplate> CreatureEquipTemplates { get; set; } = null!;
        public virtual DbSet<CreatureFormation> CreatureFormations { get; set; } = null!;
        public virtual DbSet<CreatureLootTemplate> CreatureLootTemplates { get; set; } = null!;
        public virtual DbSet<CreatureModelInfo> CreatureModelInfos { get; set; } = null!;
        public virtual DbSet<CreatureOnkillReputation> CreatureOnkillReputations { get; set; } = null!;
        public virtual DbSet<CreatureQuestender> CreatureQuestenders { get; set; } = null!;
        public virtual DbSet<CreatureQuestitem> CreatureQuestitems { get; set; } = null!;
        public virtual DbSet<CreatureQueststarter> CreatureQueststarters { get; set; } = null!;
        public virtual DbSet<CreatureSummonGroup> CreatureSummonGroups { get; set; } = null!;
        public virtual DbSet<CreatureTemplate> CreatureTemplates { get; set; } = null!;
        public virtual DbSet<CreatureTemplateAddon> CreatureTemplateAddons { get; set; } = null!;
        public virtual DbSet<CreatureTemplateLocale> CreatureTemplateLocales { get; set; } = null!;
        public virtual DbSet<CreatureTemplateResistance> CreatureTemplateResistances { get; set; } = null!;
        public virtual DbSet<CreatureTemplateSpell> CreatureTemplateSpells { get; set; } = null!;
        public virtual DbSet<CreatureText> CreatureTexts { get; set; } = null!;
        public virtual DbSet<CreatureTextLocale> CreatureTextLocales { get; set; } = null!;
        public virtual DbSet<CreaturedisplayinfoDbc> CreaturedisplayinfoDbcs { get; set; } = null!;
        public virtual DbSet<CreaturefamilyDbc> CreaturefamilyDbcs { get; set; } = null!;
        public virtual DbSet<CreaturemodeldataDbc> CreaturemodeldataDbcs { get; set; } = null!;
        public virtual DbSet<CreaturespelldataDbc> CreaturespelldataDbcs { get; set; } = null!;
        public virtual DbSet<CreaturetypeDbc> CreaturetypeDbcs { get; set; } = null!;
        public virtual DbSet<CurrencytypesDbc> CurrencytypesDbcs { get; set; } = null!;
        public virtual DbSet<DestructiblemodeldataDbc> DestructiblemodeldataDbcs { get; set; } = null!;
        public virtual DbSet<Disable> Disables { get; set; } = null!;
        public virtual DbSet<DisenchantLootTemplate> DisenchantLootTemplates { get; set; } = null!;
        public virtual DbSet<DungeonAccessRequirement> DungeonAccessRequirements { get; set; } = null!;
        public virtual DbSet<DungeonAccessTemplate> DungeonAccessTemplates { get; set; } = null!;
        public virtual DbSet<DungeonencounterDbc> DungeonencounterDbcs { get; set; } = null!;
        public virtual DbSet<DurabilitycostsDbc> DurabilitycostsDbcs { get; set; } = null!;
        public virtual DbSet<DurabilityqualityDbc> DurabilityqualityDbcs { get; set; } = null!;
        public virtual DbSet<EmotesDbc> EmotesDbcs { get; set; } = null!;
        public virtual DbSet<EmotestextDbc> EmotestextDbcs { get; set; } = null!;
        public virtual DbSet<EventScript> EventScripts { get; set; } = null!;
        public virtual DbSet<ExplorationBasexp> ExplorationBasexps { get; set; } = null!;
        public virtual DbSet<FactionDbc> FactionDbcs { get; set; } = null!;
        public virtual DbSet<FactiontemplateDbc> FactiontemplateDbcs { get; set; } = null!;
        public virtual DbSet<FishingLootTemplate> FishingLootTemplates { get; set; } = null!;
        public virtual DbSet<GameEvent> GameEvents { get; set; } = null!;
        public virtual DbSet<GameEventArenaSeason> GameEventArenaSeasons { get; set; } = null!;
        public virtual DbSet<GameEventBattlegroundHoliday> GameEventBattlegroundHolidays { get; set; } = null!;
        public virtual DbSet<GameEventCondition> GameEventConditions { get; set; } = null!;
        public virtual DbSet<GameEventCreature> GameEventCreatures { get; set; } = null!;
        public virtual DbSet<GameEventCreatureQuest> GameEventCreatureQuests { get; set; } = null!;
        public virtual DbSet<GameEventGameobject> GameEventGameobjects { get; set; } = null!;
        public virtual DbSet<GameEventGameobjectQuest> GameEventGameobjectQuests { get; set; } = null!;
        public virtual DbSet<GameEventModelEquip> GameEventModelEquips { get; set; } = null!;
        public virtual DbSet<GameEventNpcVendor> GameEventNpcVendors { get; set; } = null!;
        public virtual DbSet<GameEventNpcflag> GameEventNpcflags { get; set; } = null!;
        public virtual DbSet<GameEventPool> GameEventPools { get; set; } = null!;
        public virtual DbSet<GameEventPrerequisite> GameEventPrerequisites { get; set; } = null!;
        public virtual DbSet<GameEventQuestCondition> GameEventQuestConditions { get; set; } = null!;
        public virtual DbSet<GameEventSeasonalQuestrelation> GameEventSeasonalQuestrelations { get; set; } = null!;
        public virtual DbSet<GameGraveyard> GameGraveyards { get; set; } = null!;
        public virtual DbSet<GameTele> GameTeles { get; set; } = null!;
        public virtual DbSet<GameWeather> GameWeathers { get; set; } = null!;
        public virtual DbSet<Gameobject> Gameobjects { get; set; } = null!;
        public virtual DbSet<GameobjectAddon> GameobjectAddons { get; set; } = null!;
        public virtual DbSet<GameobjectLootTemplate> GameobjectLootTemplates { get; set; } = null!;
        public virtual DbSet<GameobjectQuestender> GameobjectQuestenders { get; set; } = null!;
        public virtual DbSet<GameobjectQuestitem> GameobjectQuestitems { get; set; } = null!;
        public virtual DbSet<GameobjectQueststarter> GameobjectQueststarters { get; set; } = null!;
        public virtual DbSet<GameobjectTemplate> GameobjectTemplates { get; set; } = null!;
        public virtual DbSet<GameobjectTemplateAddon> GameobjectTemplateAddons { get; set; } = null!;
        public virtual DbSet<GameobjectTemplateLocale> GameobjectTemplateLocales { get; set; } = null!;
        public virtual DbSet<GameobjectdisplayinfoDbc> GameobjectdisplayinfoDbcs { get; set; } = null!;
        public virtual DbSet<GempropertiesDbc> GempropertiesDbcs { get; set; } = null!;
        public virtual DbSet<GlyphpropertiesDbc> GlyphpropertiesDbcs { get; set; } = null!;
        public virtual DbSet<GlyphslotDbc> GlyphslotDbcs { get; set; } = null!;
        public virtual DbSet<GossipMenu> GossipMenus { get; set; } = null!;
        public virtual DbSet<GossipMenuOption> GossipMenuOptions { get; set; } = null!;
        public virtual DbSet<GossipMenuOptionLocale> GossipMenuOptionLocales { get; set; } = null!;
        public virtual DbSet<GraveyardZone> GraveyardZones { get; set; } = null!;
        public virtual DbSet<GtbarbershopcostbaseDbc> GtbarbershopcostbaseDbcs { get; set; } = null!;
        public virtual DbSet<GtchancetomeleecritDbc> GtchancetomeleecritDbcs { get; set; } = null!;
        public virtual DbSet<GtchancetomeleecritbaseDbc> GtchancetomeleecritbaseDbcs { get; set; } = null!;
        public virtual DbSet<GtchancetospellcritDbc> GtchancetospellcritDbcs { get; set; } = null!;
        public virtual DbSet<GtchancetospellcritbaseDbc> GtchancetospellcritbaseDbcs { get; set; } = null!;
        public virtual DbSet<GtcombatratingsDbc> GtcombatratingsDbcs { get; set; } = null!;
        public virtual DbSet<GtnpcmanacostscalerDbc> GtnpcmanacostscalerDbcs { get; set; } = null!;
        public virtual DbSet<GtoctclasscombatratingscalarDbc> GtoctclasscombatratingscalarDbcs { get; set; } = null!;
        public virtual DbSet<GtoctregenhpDbc> GtoctregenhpDbcs { get; set; } = null!;
        public virtual DbSet<GtregenhppersptDbc> GtregenhppersptDbcs { get; set; } = null!;
        public virtual DbSet<GtregenmppersptDbc> GtregenmppersptDbcs { get; set; } = null!;
        public virtual DbSet<HolidayDate> HolidayDates { get; set; } = null!;
        public virtual DbSet<HolidaysDbc> HolidaysDbcs { get; set; } = null!;
        public virtual DbSet<InstanceEncounter> InstanceEncounters { get; set; } = null!;
        public virtual DbSet<InstanceTemplate> InstanceTemplates { get; set; } = null!;
        public virtual DbSet<ItemEnchantmentTemplate> ItemEnchantmentTemplates { get; set; } = null!;
        public virtual DbSet<ItemLootTemplate> ItemLootTemplates { get; set; } = null!;
        public virtual DbSet<ItemSetName> ItemSetNames { get; set; } = null!;
        public virtual DbSet<ItemSetNamesLocale> ItemSetNamesLocales { get; set; } = null!;
        public virtual DbSet<ItemTemplate> ItemTemplates { get; set; } = null!;
        public virtual DbSet<ItemTemplateLocale> ItemTemplateLocales { get; set; } = null!;
        public virtual DbSet<ItembagfamilyDbc> ItembagfamilyDbcs { get; set; } = null!;
        public virtual DbSet<ItemdisplayinfoDbc> ItemdisplayinfoDbcs { get; set; } = null!;
        public virtual DbSet<ItemextendedcostDbc> ItemextendedcostDbcs { get; set; } = null!;
        public virtual DbSet<ItemlimitcategoryDbc> ItemlimitcategoryDbcs { get; set; } = null!;
        public virtual DbSet<ItemrandompropertiesDbc> ItemrandompropertiesDbcs { get; set; } = null!;
        public virtual DbSet<ItemrandomsuffixDbc> ItemrandomsuffixDbcs { get; set; } = null!;
        public virtual DbSet<ItemsetDbc> ItemsetDbcs { get; set; } = null!;
        public virtual DbSet<LfgDungeonReward> LfgDungeonRewards { get; set; } = null!;
        public virtual DbSet<LfgDungeonTemplate> LfgDungeonTemplates { get; set; } = null!;
        public virtual DbSet<LfgdungeonsDbc> LfgdungeonsDbcs { get; set; } = null!;
        public virtual DbSet<LightDbc> LightDbcs { get; set; } = null!;
        public virtual DbSet<LinkedRespawn> LinkedRespawns { get; set; } = null!;
        public virtual DbSet<LiquidtypeDbc> LiquidtypeDbcs { get; set; } = null!;
        public virtual DbSet<LockDbc> LockDbcs { get; set; } = null!;
        public virtual DbSet<MailLevelReward> MailLevelRewards { get; set; } = null!;
        public virtual DbSet<MailLootTemplate> MailLootTemplates { get; set; } = null!;
        public virtual DbSet<MailtemplateDbc> MailtemplateDbcs { get; set; } = null!;
        public virtual DbSet<MapDbc> MapDbcs { get; set; } = null!;
        public virtual DbSet<MapdifficultyDbc> MapdifficultyDbcs { get; set; } = null!;
        public virtual DbSet<MillingLootTemplate> MillingLootTemplates { get; set; } = null!;
        public virtual DbSet<MovieDbc> MovieDbcs { get; set; } = null!;
        public virtual DbSet<NpcSpellclickSpell> NpcSpellclickSpells { get; set; } = null!;
        public virtual DbSet<NpcText> NpcTexts { get; set; } = null!;
        public virtual DbSet<NpcTextLocale> NpcTextLocales { get; set; } = null!;
        public virtual DbSet<NpcTrainer> NpcTrainers { get; set; } = null!;
        public virtual DbSet<NpcVendor> NpcVendors { get; set; } = null!;
        public virtual DbSet<OutdoorpvpTemplate> OutdoorpvpTemplates { get; set; } = null!;
        public virtual DbSet<OverridespelldataDbc> OverridespelldataDbcs { get; set; } = null!;
        public virtual DbSet<PageText> PageTexts { get; set; } = null!;
        public virtual DbSet<PageTextLocale> PageTextLocales { get; set; } = null!;
        public virtual DbSet<PetLevelstat> PetLevelstats { get; set; } = null!;
        public virtual DbSet<PetNameGeneration> PetNameGenerations { get; set; } = null!;
        public virtual DbSet<PickpocketingLootTemplate> PickpocketingLootTemplates { get; set; } = null!;
        public virtual DbSet<PlayerClasslevelstat> PlayerClasslevelstats { get; set; } = null!;
        public virtual DbSet<PlayerFactionchangeAchievement> PlayerFactionchangeAchievements { get; set; } = null!;
        public virtual DbSet<PlayerFactionchangeItem> PlayerFactionchangeItems { get; set; } = null!;
        public virtual DbSet<PlayerFactionchangeQuest> PlayerFactionchangeQuests { get; set; } = null!;
        public virtual DbSet<PlayerFactionchangeReputation> PlayerFactionchangeReputations { get; set; } = null!;
        public virtual DbSet<PlayerFactionchangeSpell> PlayerFactionchangeSpells { get; set; } = null!;
        public virtual DbSet<PlayerFactionchangeTitle> PlayerFactionchangeTitles { get; set; } = null!;
        public virtual DbSet<PlayerLevelstat> PlayerLevelstats { get; set; } = null!;
        public virtual DbSet<PlayerLootTemplate> PlayerLootTemplates { get; set; } = null!;
        public virtual DbSet<PlayerXpForLevel> PlayerXpForLevels { get; set; } = null!;
        public virtual DbSet<Playercreateinfo> Playercreateinfos { get; set; } = null!;
        public virtual DbSet<PlayercreateinfoAction> PlayercreateinfoActions { get; set; } = null!;
        public virtual DbSet<PlayercreateinfoItem> PlayercreateinfoItems { get; set; } = null!;
        public virtual DbSet<PlayercreateinfoSkill> PlayercreateinfoSkills { get; set; } = null!;
        public virtual DbSet<PlayercreateinfoSpellCustom> PlayercreateinfoSpellCustoms { get; set; } = null!;
        public virtual DbSet<PointsOfInterest> PointsOfInterests { get; set; } = null!;
        public virtual DbSet<PointsOfInterestLocale> PointsOfInterestLocales { get; set; } = null!;
        public virtual DbSet<PoolCreature> PoolCreatures { get; set; } = null!;
        public virtual DbSet<PoolGameobject> PoolGameobjects { get; set; } = null!;
        public virtual DbSet<PoolPool> PoolPools { get; set; } = null!;
        public virtual DbSet<PoolQuest> PoolQuests { get; set; } = null!;
        public virtual DbSet<PoolTemplate> PoolTemplates { get; set; } = null!;
        public virtual DbSet<PowerdisplayDbc> PowerdisplayDbcs { get; set; } = null!;
        public virtual DbSet<ProspectingLootTemplate> ProspectingLootTemplates { get; set; } = null!;
        public virtual DbSet<PvpdifficultyDbc> PvpdifficultyDbcs { get; set; } = null!;
        public virtual DbSet<QuestDetail> QuestDetails { get; set; } = null!;
        public virtual DbSet<QuestMailSender> QuestMailSenders { get; set; } = null!;
        public virtual DbSet<QuestMoneyReward> QuestMoneyRewards { get; set; } = null!;
        public virtual DbSet<QuestOfferReward> QuestOfferRewards { get; set; } = null!;
        public virtual DbSet<QuestOfferRewardLocale> QuestOfferRewardLocales { get; set; } = null!;
        public virtual DbSet<QuestPoi> QuestPois { get; set; } = null!;
        public virtual DbSet<QuestPoiPoint> QuestPoiPoints { get; set; } = null!;
        public virtual DbSet<QuestRequestItem> QuestRequestItems { get; set; } = null!;
        public virtual DbSet<QuestRequestItemsLocale> QuestRequestItemsLocales { get; set; } = null!;
        public virtual DbSet<QuestTemplate> QuestTemplates { get; set; } = null!;
        public virtual DbSet<QuestTemplateAddon> QuestTemplateAddons { get; set; } = null!;
        public virtual DbSet<QuestTemplateLocale> QuestTemplateLocales { get; set; } = null!;
        public virtual DbSet<QuestfactionrewardDbc> QuestfactionrewardDbcs { get; set; } = null!;
        public virtual DbSet<QuestsortDbc> QuestsortDbcs { get; set; } = null!;
        public virtual DbSet<QuestxpDbc> QuestxpDbcs { get; set; } = null!;
        public virtual DbSet<RandproppointsDbc> RandproppointsDbcs { get; set; } = null!;
        public virtual DbSet<ReferenceLootTemplate> ReferenceLootTemplates { get; set; } = null!;
        public virtual DbSet<ReputationRewardRate> ReputationRewardRates { get; set; } = null!;
        public virtual DbSet<ReputationSpilloverTemplate> ReputationSpilloverTemplates { get; set; } = null!;
        public virtual DbSet<ScalingstatdistributionDbc> ScalingstatdistributionDbcs { get; set; } = null!;
        public virtual DbSet<ScalingstatvaluesDbc> ScalingstatvaluesDbcs { get; set; } = null!;
        public virtual DbSet<ScriptWaypoint> ScriptWaypoints { get; set; } = null!;
        public virtual DbSet<SkillDiscoveryTemplate> SkillDiscoveryTemplates { get; set; } = null!;
        public virtual DbSet<SkillExtraItemTemplate> SkillExtraItemTemplates { get; set; } = null!;
        public virtual DbSet<SkillFishingBaseLevel> SkillFishingBaseLevels { get; set; } = null!;
        public virtual DbSet<SkillPerfectItemTemplate> SkillPerfectItemTemplates { get; set; } = null!;
        public virtual DbSet<SkilllineDbc> SkilllineDbcs { get; set; } = null!;
        public virtual DbSet<SkilllineabilityDbc> SkilllineabilityDbcs { get; set; } = null!;
        public virtual DbSet<SkillraceclassinfoDbc> SkillraceclassinfoDbcs { get; set; } = null!;
        public virtual DbSet<SkilltiersDbc> SkilltiersDbcs { get; set; } = null!;
        public virtual DbSet<SkinningLootTemplate> SkinningLootTemplates { get; set; } = null!;
        public virtual DbSet<SmartScript> SmartScripts { get; set; } = null!;
        public virtual DbSet<SoundentriesDbc> SoundentriesDbcs { get; set; } = null!;
        public virtual DbSet<SpellArea> SpellAreas { get; set; } = null!;
        public virtual DbSet<SpellBonusDatum> SpellBonusData { get; set; } = null!;
        public virtual DbSet<SpellCustomAttr> SpellCustomAttrs { get; set; } = null!;
        public virtual DbSet<SpellDbc> SpellDbcs { get; set; } = null!;
        public virtual DbSet<SpellEnchantProcDatum> SpellEnchantProcData { get; set; } = null!;
        public virtual DbSet<SpellGroup> SpellGroups { get; set; } = null!;
        public virtual DbSet<SpellGroupStackRule> SpellGroupStackRules { get; set; } = null!;
        public virtual DbSet<SpellLinkedSpell> SpellLinkedSpells { get; set; } = null!;
        public virtual DbSet<SpellLootTemplate> SpellLootTemplates { get; set; } = null!;
        public virtual DbSet<SpellMixology> SpellMixologies { get; set; } = null!;
        public virtual DbSet<SpellPetAura> SpellPetAuras { get; set; } = null!;
        public virtual DbSet<SpellProc> SpellProcs { get; set; } = null!;
        public virtual DbSet<SpellProcEvent> SpellProcEvents { get; set; } = null!;
        public virtual DbSet<SpellRank> SpellRanks { get; set; } = null!;
        public virtual DbSet<SpellRequired> SpellRequireds { get; set; } = null!;
        public virtual DbSet<SpellScript> SpellScripts { get; set; } = null!;
        public virtual DbSet<SpellScriptName> SpellScriptNames { get; set; } = null!;
        public virtual DbSet<SpellTargetPosition> SpellTargetPositions { get; set; } = null!;
        public virtual DbSet<SpellThreat> SpellThreats { get; set; } = null!;
        public virtual DbSet<SpellcasttimesDbc> SpellcasttimesDbcs { get; set; } = null!;
        public virtual DbSet<SpellcategoryDbc> SpellcategoryDbcs { get; set; } = null!;
        public virtual DbSet<SpelldifficultyDbc> SpelldifficultyDbcs { get; set; } = null!;
        public virtual DbSet<SpelldurationDbc> SpelldurationDbcs { get; set; } = null!;
        public virtual DbSet<SpellfocusobjectDbc> SpellfocusobjectDbcs { get; set; } = null!;
        public virtual DbSet<SpellitemenchantmentDbc> SpellitemenchantmentDbcs { get; set; } = null!;
        public virtual DbSet<SpellitemenchantmentconditionDbc> SpellitemenchantmentconditionDbcs { get; set; } = null!;
        public virtual DbSet<SpellradiusDbc> SpellradiusDbcs { get; set; } = null!;
        public virtual DbSet<SpellrangeDbc> SpellrangeDbcs { get; set; } = null!;
        public virtual DbSet<SpellrunecostDbc> SpellrunecostDbcs { get; set; } = null!;
        public virtual DbSet<SpellshapeshiftformDbc> SpellshapeshiftformDbcs { get; set; } = null!;
        public virtual DbSet<SpellvisualDbc> SpellvisualDbcs { get; set; } = null!;
        public virtual DbSet<StableslotpricesDbc> StableslotpricesDbcs { get; set; } = null!;
        public virtual DbSet<SummonpropertiesDbc> SummonpropertiesDbcs { get; set; } = null!;
        public virtual DbSet<TalentDbc> TalentDbcs { get; set; } = null!;
        public virtual DbSet<TalenttabDbc> TalenttabDbcs { get; set; } = null!;
        public virtual DbSet<TaxinodesDbc> TaxinodesDbcs { get; set; } = null!;
        public virtual DbSet<TaxipathDbc> TaxipathDbcs { get; set; } = null!;
        public virtual DbSet<TaxipathnodeDbc> TaxipathnodeDbcs { get; set; } = null!;
        public virtual DbSet<TeamcontributionpointsDbc> TeamcontributionpointsDbcs { get; set; } = null!;
        public virtual DbSet<TotemcategoryDbc> TotemcategoryDbcs { get; set; } = null!;
        public virtual DbSet<Transport> Transports { get; set; } = null!;
        public virtual DbSet<TransportanimationDbc> TransportanimationDbcs { get; set; } = null!;
        public virtual DbSet<TransportrotationDbc> TransportrotationDbcs { get; set; } = null!;
        public virtual DbSet<Update> Updates { get; set; } = null!;
        public virtual DbSet<UpdatesInclude> UpdatesIncludes { get; set; } = null!;
        public virtual DbSet<VehicleAccessory> VehicleAccessories { get; set; } = null!;
        public virtual DbSet<VehicleDbc> VehicleDbcs { get; set; } = null!;
        public virtual DbSet<VehicleTemplateAccessory> VehicleTemplateAccessories { get; set; } = null!;
        public virtual DbSet<VehicleseatDbc> VehicleseatDbcs { get; set; } = null!;
        public virtual DbSet<Models.World.Version> Versions { get; set; } = null!;
        public virtual DbSet<VersionDbWorld> VersionDbWorlds { get; set; } = null!;
        public virtual DbSet<WardenCheck> WardenChecks { get; set; } = null!;
        public virtual DbSet<Waypoint> Waypoints { get; set; } = null!;
        public virtual DbSet<WaypointDatum> WaypointData { get; set; } = null!;
        public virtual DbSet<WaypointScript> WaypointScripts { get; set; } = null!;
        public virtual DbSet<WmoareatableDbc> WmoareatableDbcs { get; set; } = null!;
        public virtual DbSet<WorldmapareaDbc> WorldmapareaDbcs { get; set; } = null!;
        public virtual DbSet<WorldmapoverlayDbc> WorldmapoverlayDbcs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=ConnectionStrings:world_database", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.4-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("utf8mb3_general_ci")
                .HasCharSet("utf8mb3");

            modelBuilder.Entity<AchievementCategoryDbc>(entity =>
            {
                entity.ToTable("achievement_category_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.Parent).HasColumnType("int(11)");

                entity.Property(e => e.UiOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("Ui_Order");
            });

            modelBuilder.Entity<AchievementCriteriaDatum>(entity =>
            {
                entity.HasKey(e => new { e.CriteriaId, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("achievement_criteria_data");

                entity.HasComment("Achievment system")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CriteriaId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("criteria_id");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Value1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("value1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Value2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("value2")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AchievementCriteriaDbc>(entity =>
            {
                entity.ToTable("achievement_criteria_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AchievementId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Achievement_Id");

                entity.Property(e => e.AssetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Asset_Id");

                entity.Property(e => e.DescriptionLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_deDE");

                entity.Property(e => e.DescriptionLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enCN");

                entity.Property(e => e.DescriptionLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enGB");

                entity.Property(e => e.DescriptionLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enTW");

                entity.Property(e => e.DescriptionLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enUS");

                entity.Property(e => e.DescriptionLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_esES");

                entity.Property(e => e.DescriptionLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_esMX");

                entity.Property(e => e.DescriptionLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_frFR");

                entity.Property(e => e.DescriptionLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_itIT");

                entity.Property(e => e.DescriptionLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_koKR");

                entity.Property(e => e.DescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Description_Lang_Mask");

                entity.Property(e => e.DescriptionLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ptBR");

                entity.Property(e => e.DescriptionLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ptPT");

                entity.Property(e => e.DescriptionLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ruRU");

                entity.Property(e => e.DescriptionLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_Unk");

                entity.Property(e => e.DescriptionLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_zhCN");

                entity.Property(e => e.DescriptionLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_zhTW");

                entity.Property(e => e.FailAsset)
                    .HasColumnType("int(11)")
                    .HasColumnName("Fail_Asset");

                entity.Property(e => e.FailEvent)
                    .HasColumnType("int(11)")
                    .HasColumnName("Fail_Event");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");

                entity.Property(e => e.StartAsset)
                    .HasColumnType("int(11)")
                    .HasColumnName("Start_Asset");

                entity.Property(e => e.StartEvent)
                    .HasColumnType("int(11)")
                    .HasColumnName("Start_Event");

                entity.Property(e => e.TimerAssetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Timer_Asset_Id");

                entity.Property(e => e.TimerStartEvent)
                    .HasColumnType("int(11)")
                    .HasColumnName("Timer_Start_Event");

                entity.Property(e => e.TimerTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("Timer_Time");

                entity.Property(e => e.Type).HasColumnType("int(11)");

                entity.Property(e => e.UiOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("Ui_Order");
            });

            modelBuilder.Entity<AchievementDbc>(entity =>
            {
                entity.ToTable("achievement_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Category).HasColumnType("int(11)");

                entity.Property(e => e.DescriptionLangDeDe)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_deDE");

                entity.Property(e => e.DescriptionLangEnCn)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_enCN");

                entity.Property(e => e.DescriptionLangEnGb)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_enGB");

                entity.Property(e => e.DescriptionLangEnTw)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_enTW");

                entity.Property(e => e.DescriptionLangEnUs)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_enUS");

                entity.Property(e => e.DescriptionLangEsEs)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_esES");

                entity.Property(e => e.DescriptionLangEsMx)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_esMX");

                entity.Property(e => e.DescriptionLangFrFr)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_frFR");

                entity.Property(e => e.DescriptionLangItIt)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_itIT");

                entity.Property(e => e.DescriptionLangKoKr)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_koKR");

                entity.Property(e => e.DescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Description_Lang_Mask");

                entity.Property(e => e.DescriptionLangPtBr)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_ptBR");

                entity.Property(e => e.DescriptionLangPtPt)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_ptPT");

                entity.Property(e => e.DescriptionLangRuRu)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_ruRU");

                entity.Property(e => e.DescriptionLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_Unk");

                entity.Property(e => e.DescriptionLangZhCn)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_zhCN");

                entity.Property(e => e.DescriptionLangZhTw)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_zhTW");

                entity.Property(e => e.Faction).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.IconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("IconID");

                entity.Property(e => e.InstanceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Instance_Id");

                entity.Property(e => e.MinimumCriteria)
                    .HasColumnType("int(11)")
                    .HasColumnName("Minimum_Criteria");

                entity.Property(e => e.Points).HasColumnType("int(11)");

                entity.Property(e => e.RewardLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_deDE");

                entity.Property(e => e.RewardLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_enCN");

                entity.Property(e => e.RewardLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_enGB");

                entity.Property(e => e.RewardLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_enTW");

                entity.Property(e => e.RewardLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_enUS");

                entity.Property(e => e.RewardLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_esES");

                entity.Property(e => e.RewardLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_esMX");

                entity.Property(e => e.RewardLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_frFR");

                entity.Property(e => e.RewardLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_itIT");

                entity.Property(e => e.RewardLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_koKR");

                entity.Property(e => e.RewardLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Reward_Lang_Mask");

                entity.Property(e => e.RewardLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_ptBR");

                entity.Property(e => e.RewardLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_ptPT");

                entity.Property(e => e.RewardLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_ruRU");

                entity.Property(e => e.RewardLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_Unk");

                entity.Property(e => e.RewardLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_zhCN");

                entity.Property(e => e.RewardLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Reward_Lang_zhTW");

                entity.Property(e => e.SharesCriteria)
                    .HasColumnType("int(11)")
                    .HasColumnName("Shares_Criteria");

                entity.Property(e => e.Supercedes).HasColumnType("int(11)");

                entity.Property(e => e.TitleLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_deDE");

                entity.Property(e => e.TitleLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_enCN");

                entity.Property(e => e.TitleLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_enGB");

                entity.Property(e => e.TitleLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_enTW");

                entity.Property(e => e.TitleLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_enUS");

                entity.Property(e => e.TitleLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_esES");

                entity.Property(e => e.TitleLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_esMX");

                entity.Property(e => e.TitleLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_frFR");

                entity.Property(e => e.TitleLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_itIT");

                entity.Property(e => e.TitleLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_koKR");

                entity.Property(e => e.TitleLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Title_Lang_Mask");

                entity.Property(e => e.TitleLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_ptBR");

                entity.Property(e => e.TitleLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_ptPT");

                entity.Property(e => e.TitleLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_ruRU");

                entity.Property(e => e.TitleLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_Unk");

                entity.Property(e => e.TitleLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_zhCN");

                entity.Property(e => e.TitleLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Title_Lang_zhTW");

                entity.Property(e => e.UiOrder)
                    .HasColumnType("int(11)")
                    .HasColumnName("Ui_Order");
            });

            modelBuilder.Entity<AchievementReward>(entity =>
            {
                entity.ToTable("achievement_reward");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Body).HasColumnType("text");

                entity.Property(e => e.ItemId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ItemID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("MailTemplateID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Sender)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Subject).HasMaxLength(255);

                entity.Property(e => e.TitleA)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TitleH)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AchievementRewardLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("achievement_reward_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale).HasMaxLength(4);

                entity.Property(e => e.Subject).HasColumnType("text");

                entity.Property(e => e.Text).HasColumnType("text");
            });

            modelBuilder.Entity<AcoreString>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("acore_string");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ContentDefault)
                    .HasColumnType("text")
                    .HasColumnName("content_default");

                entity.Property(e => e.LocaleDeDe)
                    .HasColumnType("text")
                    .HasColumnName("locale_deDE");

                entity.Property(e => e.LocaleEsEs)
                    .HasColumnType("text")
                    .HasColumnName("locale_esES");

                entity.Property(e => e.LocaleEsMx)
                    .HasColumnType("text")
                    .HasColumnName("locale_esMX");

                entity.Property(e => e.LocaleFrFr)
                    .HasColumnType("text")
                    .HasColumnName("locale_frFR");

                entity.Property(e => e.LocaleKoKr)
                    .HasColumnType("text")
                    .HasColumnName("locale_koKR");

                entity.Property(e => e.LocaleRuRu)
                    .HasColumnType("text")
                    .HasColumnName("locale_ruRU");

                entity.Property(e => e.LocaleZhCn)
                    .HasColumnType("text")
                    .HasColumnName("locale_zhCN");

                entity.Property(e => e.LocaleZhTw)
                    .HasColumnType("text")
                    .HasColumnName("locale_zhTW");
            });

            modelBuilder.Entity<AreagroupDbc>(entity =>
            {
                entity.ToTable("areagroup_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_1");

                entity.Property(e => e.AreaId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_2");

                entity.Property(e => e.AreaId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_3");

                entity.Property(e => e.AreaId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_4");

                entity.Property(e => e.AreaId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_5");

                entity.Property(e => e.AreaId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_6");

                entity.Property(e => e.NextAreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NextAreaID");
            });

            modelBuilder.Entity<AreapoiDbc>(entity =>
            {
                entity.ToTable("areapoi_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID");

                entity.Property(e => e.ContinentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContinentID");

                entity.Property(e => e.DescriptionLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_deDE");

                entity.Property(e => e.DescriptionLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enCN");

                entity.Property(e => e.DescriptionLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enGB");

                entity.Property(e => e.DescriptionLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enTW");

                entity.Property(e => e.DescriptionLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enUS");

                entity.Property(e => e.DescriptionLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_esES");

                entity.Property(e => e.DescriptionLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_esMX");

                entity.Property(e => e.DescriptionLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_frFR");

                entity.Property(e => e.DescriptionLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_itIT");

                entity.Property(e => e.DescriptionLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_koKR");

                entity.Property(e => e.DescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Description_Lang_Mask");

                entity.Property(e => e.DescriptionLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ptBR");

                entity.Property(e => e.DescriptionLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ptPT");

                entity.Property(e => e.DescriptionLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ruRU");

                entity.Property(e => e.DescriptionLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_Unk");

                entity.Property(e => e.DescriptionLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_zhCN");

                entity.Property(e => e.DescriptionLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_zhTW");

                entity.Property(e => e.FactionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FactionID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Icon1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_1");

                entity.Property(e => e.Icon2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_2");

                entity.Property(e => e.Icon3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_3");

                entity.Property(e => e.Icon4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_4");

                entity.Property(e => e.Icon5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_5");

                entity.Property(e => e.Icon6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_6");

                entity.Property(e => e.Icon7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_7");

                entity.Property(e => e.Icon8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_8");

                entity.Property(e => e.Icon9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Icon_9");

                entity.Property(e => e.Importance).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.WorldMapLink).HasColumnType("int(11)");

                entity.Property(e => e.WorldStateId)
                    .HasColumnType("int(11)")
                    .HasColumnName("WorldStateID");
            });

            modelBuilder.Entity<AreatableDbc>(entity =>
            {
                entity.ToTable("areatable_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AmbienceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AmbienceID");

                entity.Property(e => e.AmbientMultiplier).HasColumnName("Ambient_Multiplier");

                entity.Property(e => e.AreaBit).HasColumnType("int(11)");

                entity.Property(e => e.AreaNameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_deDE");

                entity.Property(e => e.AreaNameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_enCN");

                entity.Property(e => e.AreaNameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_enGB");

                entity.Property(e => e.AreaNameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_enTW");

                entity.Property(e => e.AreaNameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_enUS");

                entity.Property(e => e.AreaNameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_esES");

                entity.Property(e => e.AreaNameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_esMX");

                entity.Property(e => e.AreaNameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_frFR");

                entity.Property(e => e.AreaNameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_itIT");

                entity.Property(e => e.AreaNameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_koKR");

                entity.Property(e => e.AreaNameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("AreaName_Lang_Mask");

                entity.Property(e => e.AreaNameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_ptBR");

                entity.Property(e => e.AreaNameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_ptPT");

                entity.Property(e => e.AreaNameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_ruRU");

                entity.Property(e => e.AreaNameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_Unk");

                entity.Property(e => e.AreaNameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_zhCN");

                entity.Property(e => e.AreaNameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_zhTW");

                entity.Property(e => e.ContinentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContinentID");

                entity.Property(e => e.ExplorationLevel).HasColumnType("int(11)");

                entity.Property(e => e.FactionGroupMask).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.IntroSound).HasColumnType("int(11)");

                entity.Property(e => e.Lightid).HasColumnType("int(11)");

                entity.Property(e => e.LiquidTypeId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("LiquidTypeID_1");

                entity.Property(e => e.LiquidTypeId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("LiquidTypeID_2");

                entity.Property(e => e.LiquidTypeId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("LiquidTypeID_3");

                entity.Property(e => e.LiquidTypeId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("LiquidTypeID_4");

                entity.Property(e => e.ParentAreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParentAreaID");

                entity.Property(e => e.SoundProviderPref).HasColumnType("int(11)");

                entity.Property(e => e.SoundProviderPrefUnderwater).HasColumnType("int(11)");

                entity.Property(e => e.ZoneMusic).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Areatrigger>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("areatrigger");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.Height)
                    .HasColumnName("height")
                    .HasComment("Most commonly used when size is 0, but not always");

                entity.Property(e => e.Length)
                    .HasColumnName("length")
                    .HasComment("Most commonly used when size is 0, but not always");

                entity.Property(e => e.Map)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.Orientation)
                    .HasColumnName("orientation")
                    .HasComment("Most commonly used when size is 0, but not always");

                entity.Property(e => e.Radius)
                    .HasColumnName("radius")
                    .HasComment("Seems to be a box of size yards with center at x,y,z");

                entity.Property(e => e.Width)
                    .HasColumnName("width")
                    .HasComment("Most commonly used when size is 0, but not always");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<AreatriggerInvolvedrelation>(entity =>
            {
                entity.ToTable("areatrigger_involvedrelation");

                entity.HasComment("Trigger System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<AreatriggerScript>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("areatrigger_scripts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(9)")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .IsFixedLength();
            });

            modelBuilder.Entity<AreatriggerTavern>(entity =>
            {
                entity.ToTable("areatrigger_tavern");

                entity.HasComment("Trigger System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");
            });

            modelBuilder.Entity<AreatriggerTeleport>(entity =>
            {
                entity.ToTable("areatrigger_teleport");

                entity.HasComment("Trigger System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Name, "name")
                    .HasAnnotation("MySql:FullTextIndex", true);

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.TargetMap)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("target_map");

                entity.Property(e => e.TargetOrientation).HasColumnName("target_orientation");

                entity.Property(e => e.TargetPositionX).HasColumnName("target_position_x");

                entity.Property(e => e.TargetPositionY).HasColumnName("target_position_y");

                entity.Property(e => e.TargetPositionZ).HasColumnName("target_position_z");
            });

            modelBuilder.Entity<AuctionhouseDbc>(entity =>
            {
                entity.ToTable("auctionhouse_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ConsignmentRate).HasColumnType("int(11)");

                entity.Property(e => e.DepositRate).HasColumnType("int(11)");

                entity.Property(e => e.FactionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FactionID");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<BankbagslotpricesDbc>(entity =>
            {
                entity.ToTable("bankbagslotprices_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Cost).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BarbershopstyleDbc>(entity =>
            {
                entity.ToTable("barbershopstyle_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CostModifier).HasColumnName("Cost_Modifier");

                entity.Property(e => e.Data).HasColumnType("int(11)");

                entity.Property(e => e.DescriptionLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_deDE");

                entity.Property(e => e.DescriptionLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enCN");

                entity.Property(e => e.DescriptionLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enGB");

                entity.Property(e => e.DescriptionLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enTW");

                entity.Property(e => e.DescriptionLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_enUS");

                entity.Property(e => e.DescriptionLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_esES");

                entity.Property(e => e.DescriptionLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_esMX");

                entity.Property(e => e.DescriptionLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_frFR");

                entity.Property(e => e.DescriptionLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_itIT");

                entity.Property(e => e.DescriptionLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_koKR");

                entity.Property(e => e.DescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Description_Lang_Mask");

                entity.Property(e => e.DescriptionLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ptBR");

                entity.Property(e => e.DescriptionLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ptPT");

                entity.Property(e => e.DescriptionLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_ruRU");

                entity.Property(e => e.DescriptionLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_Unk");

                entity.Property(e => e.DescriptionLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_zhCN");

                entity.Property(e => e.DescriptionLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_zhTW");

                entity.Property(e => e.DisplayNameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_deDE");

                entity.Property(e => e.DisplayNameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_enCN");

                entity.Property(e => e.DisplayNameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_enGB");

                entity.Property(e => e.DisplayNameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_enTW");

                entity.Property(e => e.DisplayNameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_enUS");

                entity.Property(e => e.DisplayNameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_esES");

                entity.Property(e => e.DisplayNameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_esMX");

                entity.Property(e => e.DisplayNameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_frFR");

                entity.Property(e => e.DisplayNameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_itIT");

                entity.Property(e => e.DisplayNameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_koKR");

                entity.Property(e => e.DisplayNameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("DisplayName_Lang_Mask");

                entity.Property(e => e.DisplayNameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_ptBR");

                entity.Property(e => e.DisplayNameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_ptPT");

                entity.Property(e => e.DisplayNameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_ruRU");

                entity.Property(e => e.DisplayNameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_Unk");

                entity.Property(e => e.DisplayNameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_zhCN");

                entity.Property(e => e.DisplayNameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_zhTW");

                entity.Property(e => e.Race).HasColumnType("int(11)");

                entity.Property(e => e.Sex).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<BattlegroundTemplate>(entity =>
            {
                entity.ToTable("battleground_template");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AllianceStartLoc).HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.Comment)
                    .HasMaxLength(38)
                    .IsFixedLength();

                entity.Property(e => e.HordeStartLoc).HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.MaxLvl).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MaxPlayersPerTeam).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.MinLvl).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MinPlayersPerTeam).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Weight)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<BattlemasterEntry>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("battlemaster_entry");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Entry of a creature");

                entity.Property(e => e.BgTemplate)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("bg_template")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Battleground template id");
            });

            modelBuilder.Entity<BattlemasterlistDbc>(entity =>
            {
                entity.ToTable("battlemasterlist_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GroupsAllowed).HasColumnType("int(11)");

                entity.Property(e => e.HolidayWorldState).HasColumnType("int(11)");

                entity.Property(e => e.InstanceType).HasColumnType("int(11)");

                entity.Property(e => e.MapId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID_1");

                entity.Property(e => e.MapId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID_2");

                entity.Property(e => e.MapId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID_3");

                entity.Property(e => e.MapId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID_4");

                entity.Property(e => e.MapId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID_5");

                entity.Property(e => e.MapId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID_6");

                entity.Property(e => e.MapId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID_7");

                entity.Property(e => e.MapId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID_8");

                entity.Property(e => e.MaxGroupSize).HasColumnType("int(11)");

                entity.Property(e => e.Maxlevel).HasColumnType("int(11)");

                entity.Property(e => e.Minlevel).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<BroadcastText>(entity =>
            {
                entity.ToTable("broadcast_text");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmoteDelay0)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmoteDelay1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmoteDelay2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmoteId0)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("EmoteID0")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmoteId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("EmoteID1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EmoteId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("EmoteID2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Language)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SoundId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Unk1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Unk2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<BroadcastTextLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("broadcast_text_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.FemaleText).HasColumnType("text");

                entity.Property(e => e.MaleText).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CharstartoutfitDbc>(entity =>
            {
                entity.ToTable("charstartoutfit_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClassId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("ClassID");

                entity.Property(e => e.DisplayItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_1");

                entity.Property(e => e.DisplayItemId10)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_10");

                entity.Property(e => e.DisplayItemId11)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_11");

                entity.Property(e => e.DisplayItemId12)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_12");

                entity.Property(e => e.DisplayItemId13)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_13");

                entity.Property(e => e.DisplayItemId14)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_14");

                entity.Property(e => e.DisplayItemId15)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_15");

                entity.Property(e => e.DisplayItemId16)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_16");

                entity.Property(e => e.DisplayItemId17)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_17");

                entity.Property(e => e.DisplayItemId18)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_18");

                entity.Property(e => e.DisplayItemId19)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_19");

                entity.Property(e => e.DisplayItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_2");

                entity.Property(e => e.DisplayItemId20)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_20");

                entity.Property(e => e.DisplayItemId21)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_21");

                entity.Property(e => e.DisplayItemId22)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_22");

                entity.Property(e => e.DisplayItemId23)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_23");

                entity.Property(e => e.DisplayItemId24)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_24");

                entity.Property(e => e.DisplayItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_3");

                entity.Property(e => e.DisplayItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_4");

                entity.Property(e => e.DisplayItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_5");

                entity.Property(e => e.DisplayItemId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_6");

                entity.Property(e => e.DisplayItemId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_7");

                entity.Property(e => e.DisplayItemId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_8");

                entity.Property(e => e.DisplayItemId9)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayItemID_9");

                entity.Property(e => e.InventoryType1)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_1");

                entity.Property(e => e.InventoryType10)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_10");

                entity.Property(e => e.InventoryType11)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_11");

                entity.Property(e => e.InventoryType12)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_12");

                entity.Property(e => e.InventoryType13)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_13");

                entity.Property(e => e.InventoryType14)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_14");

                entity.Property(e => e.InventoryType15)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_15");

                entity.Property(e => e.InventoryType16)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_16");

                entity.Property(e => e.InventoryType17)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_17");

                entity.Property(e => e.InventoryType18)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_18");

                entity.Property(e => e.InventoryType19)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_19");

                entity.Property(e => e.InventoryType2)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_2");

                entity.Property(e => e.InventoryType20)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_20");

                entity.Property(e => e.InventoryType21)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_21");

                entity.Property(e => e.InventoryType22)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_22");

                entity.Property(e => e.InventoryType23)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_23");

                entity.Property(e => e.InventoryType24)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_24");

                entity.Property(e => e.InventoryType3)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_3");

                entity.Property(e => e.InventoryType4)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_4");

                entity.Property(e => e.InventoryType5)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_5");

                entity.Property(e => e.InventoryType6)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_6");

                entity.Property(e => e.InventoryType7)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_7");

                entity.Property(e => e.InventoryType8)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_8");

                entity.Property(e => e.InventoryType9)
                    .HasColumnType("int(11)")
                    .HasColumnName("InventoryType_9");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_1");

                entity.Property(e => e.ItemId10)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_10");

                entity.Property(e => e.ItemId11)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_11");

                entity.Property(e => e.ItemId12)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_12");

                entity.Property(e => e.ItemId13)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_13");

                entity.Property(e => e.ItemId14)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_14");

                entity.Property(e => e.ItemId15)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_15");

                entity.Property(e => e.ItemId16)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_16");

                entity.Property(e => e.ItemId17)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_17");

                entity.Property(e => e.ItemId18)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_18");

                entity.Property(e => e.ItemId19)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_19");

                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_2");

                entity.Property(e => e.ItemId20)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_20");

                entity.Property(e => e.ItemId21)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_21");

                entity.Property(e => e.ItemId22)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_22");

                entity.Property(e => e.ItemId23)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_23");

                entity.Property(e => e.ItemId24)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_24");

                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_3");

                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_4");

                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_5");

                entity.Property(e => e.ItemId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_6");

                entity.Property(e => e.ItemId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_7");

                entity.Property(e => e.ItemId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_8");

                entity.Property(e => e.ItemId9)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_9");

                entity.Property(e => e.OutfitId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("OutfitID");

                entity.Property(e => e.RaceId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("RaceID");

                entity.Property(e => e.SexId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("SexID");
            });

            modelBuilder.Entity<ChartitlesDbc>(entity =>
            {
                entity.ToTable("chartitles_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Condition_ID");

                entity.Property(e => e.MaskId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Mask_ID");

                entity.Property(e => e.Name1LangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_deDE");

                entity.Property(e => e.Name1LangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_enCN");

                entity.Property(e => e.Name1LangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_enGB");

                entity.Property(e => e.Name1LangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_enTW");

                entity.Property(e => e.Name1LangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_enUS");

                entity.Property(e => e.Name1LangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_esES");

                entity.Property(e => e.Name1LangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_esMX");

                entity.Property(e => e.Name1LangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_frFR");

                entity.Property(e => e.Name1LangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_itIT");

                entity.Property(e => e.Name1LangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_koKR");

                entity.Property(e => e.Name1LangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name1_Lang_Mask");

                entity.Property(e => e.Name1LangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_ptBR");

                entity.Property(e => e.Name1LangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_ptPT");

                entity.Property(e => e.Name1LangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_ruRU");

                entity.Property(e => e.Name1LangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_Unk");

                entity.Property(e => e.Name1LangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_zhCN");

                entity.Property(e => e.Name1LangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name1_Lang_zhTW");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<ChatchannelsDbc>(entity =>
            {
                entity.ToTable("chatchannels_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.FactionGroup).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.ShortcutLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_deDE");

                entity.Property(e => e.ShortcutLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_enCN");

                entity.Property(e => e.ShortcutLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_enGB");

                entity.Property(e => e.ShortcutLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_enTW");

                entity.Property(e => e.ShortcutLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_enUS");

                entity.Property(e => e.ShortcutLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_esES");

                entity.Property(e => e.ShortcutLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_esMX");

                entity.Property(e => e.ShortcutLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_frFR");

                entity.Property(e => e.ShortcutLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_itIT");

                entity.Property(e => e.ShortcutLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_koKR");

                entity.Property(e => e.ShortcutLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Shortcut_Lang_Mask");

                entity.Property(e => e.ShortcutLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_ptBR");

                entity.Property(e => e.ShortcutLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_ptPT");

                entity.Property(e => e.ShortcutLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_ruRU");

                entity.Property(e => e.ShortcutLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_Unk");

                entity.Property(e => e.ShortcutLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_zhCN");

                entity.Property(e => e.ShortcutLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Shortcut_Lang_zhTW");
            });

            modelBuilder.Entity<ChrclassesDbc>(entity =>
            {
                entity.ToTable("chrclasses_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CinematicSequenceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CinematicSequenceID");

                entity.Property(e => e.DisplayPower).HasColumnType("int(11)");

                entity.Property(e => e.Field01).HasColumnType("int(11)");

                entity.Property(e => e.Filename).HasMaxLength(100);

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.NameFemaleLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_deDE");

                entity.Property(e => e.NameFemaleLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_enCN");

                entity.Property(e => e.NameFemaleLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_enGB");

                entity.Property(e => e.NameFemaleLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_enTW");

                entity.Property(e => e.NameFemaleLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_enUS");

                entity.Property(e => e.NameFemaleLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_esES");

                entity.Property(e => e.NameFemaleLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_esMX");

                entity.Property(e => e.NameFemaleLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_frFR");

                entity.Property(e => e.NameFemaleLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_itIT");

                entity.Property(e => e.NameFemaleLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_koKR");

                entity.Property(e => e.NameFemaleLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Female_Lang_Mask");

                entity.Property(e => e.NameFemaleLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_ptBR");

                entity.Property(e => e.NameFemaleLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_ptPT");

                entity.Property(e => e.NameFemaleLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_ruRU");

                entity.Property(e => e.NameFemaleLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_Unk");

                entity.Property(e => e.NameFemaleLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_zhCN");

                entity.Property(e => e.NameFemaleLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_zhTW");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.NameMaleLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_deDE");

                entity.Property(e => e.NameMaleLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_enCN");

                entity.Property(e => e.NameMaleLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_enGB");

                entity.Property(e => e.NameMaleLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_enTW");

                entity.Property(e => e.NameMaleLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_enUS");

                entity.Property(e => e.NameMaleLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_esES");

                entity.Property(e => e.NameMaleLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_esMX");

                entity.Property(e => e.NameMaleLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_frFR");

                entity.Property(e => e.NameMaleLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_itIT");

                entity.Property(e => e.NameMaleLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_koKR");

                entity.Property(e => e.NameMaleLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Male_Lang_Mask");

                entity.Property(e => e.NameMaleLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_ptBR");

                entity.Property(e => e.NameMaleLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_ptPT");

                entity.Property(e => e.NameMaleLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_ruRU");

                entity.Property(e => e.NameMaleLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_Unk");

                entity.Property(e => e.NameMaleLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_zhCN");

                entity.Property(e => e.NameMaleLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_zhTW");

                entity.Property(e => e.PetNameToken).HasColumnType("int(11)");

                entity.Property(e => e.RequiredExpansion)
                    .HasColumnType("int(11)")
                    .HasColumnName("Required_Expansion");

                entity.Property(e => e.SpellClassSet).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ChrracesDbc>(entity =>
            {
                entity.ToTable("chrraces_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Alliance).HasColumnType("int(11)");

                entity.Property(e => e.BaseLanguage).HasColumnType("int(11)");

                entity.Property(e => e.CinematicSequenceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CinematicSequenceID");

                entity.Property(e => e.ClientFilestring).HasMaxLength(100);

                entity.Property(e => e.ClientPrefix).HasMaxLength(100);

                entity.Property(e => e.CreatureType).HasColumnType("int(11)");

                entity.Property(e => e.ExplorationSoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ExplorationSoundID");

                entity.Property(e => e.FacialHairCustomization1)
                    .HasMaxLength(100)
                    .HasColumnName("FacialHairCustomization_1");

                entity.Property(e => e.FacialHairCustomization2)
                    .HasMaxLength(100)
                    .HasColumnName("FacialHairCustomization_2");

                entity.Property(e => e.FactionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FactionID");

                entity.Property(e => e.FemaleDisplayId).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.HairCustomization).HasMaxLength(100);

                entity.Property(e => e.MaleDisplayId).HasColumnType("int(11)");

                entity.Property(e => e.NameFemaleLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_deDE");

                entity.Property(e => e.NameFemaleLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_enCN");

                entity.Property(e => e.NameFemaleLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_enGB");

                entity.Property(e => e.NameFemaleLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_enTW");

                entity.Property(e => e.NameFemaleLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_enUS");

                entity.Property(e => e.NameFemaleLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_esES");

                entity.Property(e => e.NameFemaleLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_esMX");

                entity.Property(e => e.NameFemaleLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_frFR");

                entity.Property(e => e.NameFemaleLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_itIT");

                entity.Property(e => e.NameFemaleLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_koKR");

                entity.Property(e => e.NameFemaleLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Female_Lang_Mask");

                entity.Property(e => e.NameFemaleLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_ptBR");

                entity.Property(e => e.NameFemaleLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_ptPT");

                entity.Property(e => e.NameFemaleLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_ruRU");

                entity.Property(e => e.NameFemaleLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_Unk");

                entity.Property(e => e.NameFemaleLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_zhCN");

                entity.Property(e => e.NameFemaleLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Female_Lang_zhTW");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.NameMaleLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_deDE");

                entity.Property(e => e.NameMaleLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_enCN");

                entity.Property(e => e.NameMaleLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_enGB");

                entity.Property(e => e.NameMaleLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_enTW");

                entity.Property(e => e.NameMaleLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_enUS");

                entity.Property(e => e.NameMaleLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_esES");

                entity.Property(e => e.NameMaleLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_esMX");

                entity.Property(e => e.NameMaleLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_frFR");

                entity.Property(e => e.NameMaleLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_itIT");

                entity.Property(e => e.NameMaleLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_koKR");

                entity.Property(e => e.NameMaleLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Male_Lang_Mask");

                entity.Property(e => e.NameMaleLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_ptBR");

                entity.Property(e => e.NameMaleLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_ptPT");

                entity.Property(e => e.NameMaleLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_ruRU");

                entity.Property(e => e.NameMaleLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_Unk");

                entity.Property(e => e.NameMaleLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_zhCN");

                entity.Property(e => e.NameMaleLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Male_Lang_zhTW");

                entity.Property(e => e.RequiredExpansion)
                    .HasColumnType("int(11)")
                    .HasColumnName("Required_Expansion");

                entity.Property(e => e.ResSicknessSpellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ResSicknessSpellID");

                entity.Property(e => e.SplashSoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SplashSoundID");
            });

            modelBuilder.Entity<CinematiccameraDbc>(entity =>
            {
                entity.ToTable("cinematiccamera_dbc");

                entity.HasComment("Cinematic camera DBC")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.LocationX).HasColumnName("locationX");

                entity.Property(e => e.LocationY).HasColumnName("locationY");

                entity.Property(e => e.LocationZ).HasColumnName("locationZ");

                entity.Property(e => e.Model)
                    .HasMaxLength(100)
                    .HasColumnName("model");

                entity.Property(e => e.Rotation).HasColumnName("rotation");

                entity.Property(e => e.SoundEntry)
                    .HasColumnType("int(11)")
                    .HasColumnName("soundEntry");
            });

            modelBuilder.Entity<CinematicsequencesDbc>(entity =>
            {
                entity.ToTable("cinematicsequences_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Camera1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Camera_1");

                entity.Property(e => e.Camera2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Camera_2");

                entity.Property(e => e.Camera3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Camera_3");

                entity.Property(e => e.Camera4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Camera_4");

                entity.Property(e => e.Camera5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Camera_5");

                entity.Property(e => e.Camera6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Camera_6");

                entity.Property(e => e.Camera7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Camera_7");

                entity.Property(e => e.Camera8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Camera_8");

                entity.Property(e => e.SoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SoundID");
            });

            modelBuilder.Entity<Command>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("command");

                entity.HasComment("Chat System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Name)
                    .HasMaxLength(50)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Help).HasColumnName("help");

                entity.Property(e => e.Security)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("security");
            });

            modelBuilder.Entity<Condition>(entity =>
            {
                entity.HasKey(e => new { e.SourceTypeOrReferenceId, e.SourceGroup, e.SourceEntry, e.SourceId, e.ElseGroup, e.ConditionTypeOrReference, e.ConditionTarget, e.ConditionValue1, e.ConditionValue2, e.ConditionValue3 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 });

                entity.ToTable("conditions");

                entity.HasComment("Condition System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SourceTypeOrReferenceId)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SourceGroup)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SourceEntry)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SourceId).HasColumnType("int(11)");

                entity.Property(e => e.ElseGroup)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionTypeOrReference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionTarget).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ConditionValue1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionValue2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionValue3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.ErrorTextId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ErrorType)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NegativeCondition).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<Creature>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Id, "idx_id");

                entity.HasIndex(e => e.Map, "idx_map");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.AreaId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("areaId")
                    .HasComment("Area Identifier");

                entity.Property(e => e.Curhealth)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("curhealth")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Curmana)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("curmana");

                entity.Property(e => e.Currentwaypoint)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("currentwaypoint")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dynamicflags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("dynamicflags");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("equipment_id");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Creature Identifier");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Modelid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MovementType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Npcflag)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("npcflag");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PhaseMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("phaseMask")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.SpawnMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spawnMask")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Spawntimesecs)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spawntimesecs")
                    .HasDefaultValueSql("'120'");

                entity.Property(e => e.UnitFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("unit_flags");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WanderDistance).HasColumnName("wander_distance");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("zoneId")
                    .HasComment("Zone Identifier");
            });

            modelBuilder.Entity<CreatureAddon>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_addon");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Auras)
                    .HasColumnType("text")
                    .HasColumnName("auras");

                entity.Property(e => e.Bytes1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bytes1");

                entity.Property(e => e.Bytes2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bytes2");

                entity.Property(e => e.Emote)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("emote");

                entity.Property(e => e.Mount)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mount")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PathId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("path_id");

                entity.Property(e => e.VisibilityDistanceType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("visibilityDistanceType");
            });

            modelBuilder.Entity<CreatureClasslevelstat>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.Class })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_classlevelstats");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Attackpower)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("attackpower");

                entity.Property(e => e.Basearmor)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basearmor")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Basehp0)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basehp0")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Basehp1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basehp1")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Basehp2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basehp2")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Basemana)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basemana");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.DamageBase).HasColumnName("damage_base");

                entity.Property(e => e.DamageExp1).HasColumnName("damage_exp1");

                entity.Property(e => e.DamageExp2).HasColumnName("damage_exp2");

                entity.Property(e => e.Rangedattackpower)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("rangedattackpower");
            });

            modelBuilder.Entity<CreatureEquipTemplate>(entity =>
            {
                entity.HasKey(e => new { e.CreatureId, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_equip_template");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("CreatureID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ItemID1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ItemID2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemId3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ItemID3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureFormation>(entity =>
            {
                entity.HasKey(e => e.MemberGuid)
                    .HasName("PRIMARY");

                entity.ToTable("creature_formations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MemberGuid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("memberGUID");

                entity.Property(e => e.Angle).HasColumnName("angle");

                entity.Property(e => e.Dist).HasColumnName("dist");

                entity.Property(e => e.GroupAi)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("groupAI");

                entity.Property(e => e.LeaderGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("leaderGUID");

                entity.Property(e => e.Point1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("point_1");

                entity.Property(e => e.Point2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("point_2");
            });

            modelBuilder.Entity<CreatureLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureModelInfo>(entity =>
            {
                entity.HasKey(e => e.DisplayId)
                    .HasName("PRIMARY");

                entity.ToTable("creature_model_info");

                entity.HasComment("Creature System (Model related info)")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DisplayId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("DisplayID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DisplayIdOtherGender)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("DisplayID_Other_Gender")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");
            });

            modelBuilder.Entity<CreatureOnkillReputation>(entity =>
            {
                entity.HasKey(e => e.CreatureId)
                    .HasName("PRIMARY");

                entity.ToTable("creature_onkill_reputation");

                entity.HasComment("Creature OnKill Reputation gain")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("creature_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Creature Identifier");

                entity.Property(e => e.IsTeamAward1).HasColumnType("tinyint(4)");

                entity.Property(e => e.IsTeamAward2).HasColumnType("tinyint(4)");

                entity.Property(e => e.MaxStanding1).HasColumnType("tinyint(4)");

                entity.Property(e => e.MaxStanding2).HasColumnType("tinyint(4)");

                entity.Property(e => e.RewOnKillRepFaction1).HasColumnType("smallint(6)");

                entity.Property(e => e.RewOnKillRepFaction2).HasColumnType("smallint(6)");

                entity.Property(e => e.RewOnKillRepValue1)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewOnKillRepValue2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TeamDependent).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<CreatureQuestender>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_questender");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CreatureQuestitem>(entity =>
            {
                entity.HasKey(e => new { e.CreatureEntry, e.Idx })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_questitem");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatureEntry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<CreatureQueststarter>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_queststarter");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CreatureSummonGroup>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("creature_summon_groups");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupId");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.SummonTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("summonTime");

                entity.Property(e => e.SummonType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summonType");

                entity.Property(e => e.SummonerId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("summonerId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SummonerType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summonerType");
            });

            modelBuilder.Entity<CreatureTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_template");

                entity.HasComment("Creature System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Name, "idx_name");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ainame)
                    .HasMaxLength(64)
                    .HasColumnName("AIName")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.ArmorModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.BaseAttackTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.BaseVariance).HasDefaultValueSql("'1'");

                entity.Property(e => e.DamageModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.DetectionRange)
                    .HasColumnName("detection_range")
                    .HasDefaultValueSql("'20'");

                entity.Property(e => e.DifficultyEntry1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("difficulty_entry_1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DifficultyEntry2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("difficulty_entry_2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DifficultyEntry3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("difficulty_entry_3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dmgschool)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("dmgschool");

                entity.Property(e => e.Dynamicflags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("dynamicflags");

                entity.Property(e => e.Exp)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("exp");

                entity.Property(e => e.ExperienceModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.Faction)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction");

                entity.Property(e => e.Family)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("family");

                entity.Property(e => e.FlagsExtra)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("flags_extra");

                entity.Property(e => e.GossipMenuId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("gossip_menu_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HealthModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.HoverHeight).HasDefaultValueSql("'1'");

                entity.Property(e => e.IconName)
                    .HasMaxLength(100)
                    .IsFixedLength();

                entity.Property(e => e.InhabitType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'3'");

                entity.Property(e => e.KillCredit1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.KillCredit2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Lootid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("lootid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ManaModifier).HasDefaultValueSql("'1'");

                entity.Property(e => e.Maxgold)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("maxgold")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Maxlevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxlevel")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MechanicImmuneMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mechanic_immune_mask");

                entity.Property(e => e.Mingold)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mingold")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Minlevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("minlevel")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Modelid1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Modelid2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Modelid3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Modelid4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MovementId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("movementId");

                entity.Property(e => e.MovementType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'0'")
                    .IsFixedLength();

                entity.Property(e => e.Npcflag)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("npcflag");

                entity.Property(e => e.PetSpellDataId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pickpocketloot)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pickpocketloot")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RacialLeader).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RangeAttackTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RangeVariance).HasDefaultValueSql("'1'");

                entity.Property(e => e.Rank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank");

                entity.Property(e => e.RegenHealth)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Scale)
                    .HasColumnName("scale")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.Skinloot)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("skinloot")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpeedRun)
                    .HasColumnName("speed_run")
                    .HasDefaultValueSql("'1.14286'")
                    .HasComment("Result of 8.0/7.0, most common value");

                entity.Property(e => e.SpeedWalk)
                    .HasColumnName("speed_walk")
                    .HasDefaultValueSql("'1'")
                    .HasComment("Result of 2.5/2.5, most common value");

                entity.Property(e => e.SpellSchoolImmuneMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spell_school_immune_mask");

                entity.Property(e => e.Subname)
                    .HasMaxLength(100)
                    .HasColumnName("subname")
                    .IsFixedLength();

                entity.Property(e => e.TrainerClass)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("trainer_class");

                entity.Property(e => e.TrainerRace)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("trainer_race");

                entity.Property(e => e.TrainerSpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("trainer_spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TrainerType)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("trainer_type");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.TypeFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("type_flags");

                entity.Property(e => e.UnitClass)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("unit_class");

                entity.Property(e => e.UnitFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("unit_flags");

                entity.Property(e => e.UnitFlags2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("unit_flags2");

                entity.Property(e => e.VehicleId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureTemplateAddon>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("creature_template_addon");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Auras)
                    .HasColumnType("text")
                    .HasColumnName("auras");

                entity.Property(e => e.Bytes1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bytes1");

                entity.Property(e => e.Bytes2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bytes2");

                entity.Property(e => e.Emote)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("emote")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mount)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mount")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PathId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("path_id");

                entity.Property(e => e.VisibilityDistanceType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("visibilityDistanceType");
            });

            modelBuilder.Entity<CreatureTemplateLocale>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_template_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.Title).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureTemplateResistance>(entity =>
            {
                entity.HasKey(e => new { e.CreatureId, e.School })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_template_resistance");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("CreatureID");

                entity.Property(e => e.School).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Resistance).HasColumnType("smallint(6)");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureTemplateSpell>(entity =>
            {
                entity.HasKey(e => new { e.CreatureId, e.Index })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_template_spell");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("CreatureID");

                entity.Property(e => e.Index).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Spell).HasColumnType("mediumint(8) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CreatureText>(entity =>
            {
                entity.HasKey(e => new { e.CreatureId, e.GroupId, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("creature_text");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("CreatureID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("GroupID");

                entity.Property(e => e.Id)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.BroadcastTextId)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Duration)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Emote)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Language).HasColumnType("tinyint(4)");

                entity.Property(e => e.Sound)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.TextRange).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Type).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<CreatureTextLocale>(entity =>
            {
                entity.HasKey(e => new { e.CreatureId, e.GroupId, e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("creature_text_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatureId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("CreatureID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GroupId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("GroupID");

                entity.Property(e => e.Id)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Locale).HasMaxLength(4);

                entity.Property(e => e.Text).HasColumnType("text");
            });

            modelBuilder.Entity<CreaturedisplayinfoDbc>(entity =>
            {
                entity.ToTable("creaturedisplayinfo_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BloodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("BloodID");

                entity.Property(e => e.BloodLevel).HasColumnType("int(11)");

                entity.Property(e => e.CreatureGeosetData).HasColumnType("int(11)");

                entity.Property(e => e.CreatureModelAlpha).HasColumnType("int(11)");

                entity.Property(e => e.ExtendedDisplayInfoId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ExtendedDisplayInfoID");

                entity.Property(e => e.ModelId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ModelID");

                entity.Property(e => e.NpcsoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NPCSoundID");

                entity.Property(e => e.ObjectEffectPackageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ObjectEffectPackageID");

                entity.Property(e => e.ParticleColorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParticleColorID");

                entity.Property(e => e.PortraitTextureName).HasMaxLength(100);

                entity.Property(e => e.SoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SoundID");

                entity.Property(e => e.TextureVariation1)
                    .HasMaxLength(100)
                    .HasColumnName("TextureVariation_1");

                entity.Property(e => e.TextureVariation2)
                    .HasMaxLength(100)
                    .HasColumnName("TextureVariation_2");

                entity.Property(e => e.TextureVariation3)
                    .HasMaxLength(100)
                    .HasColumnName("TextureVariation_3");
            });

            modelBuilder.Entity<CreaturefamilyDbc>(entity =>
            {
                entity.ToTable("creaturefamily_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryEnumId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryEnumID");

                entity.Property(e => e.IconFile).HasMaxLength(100);

                entity.Property(e => e.MaxScaleLevel).HasColumnType("int(11)");

                entity.Property(e => e.MinScaleLevel).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.PetFoodMask).HasColumnType("int(11)");

                entity.Property(e => e.PetTalentType).HasColumnType("int(11)");

                entity.Property(e => e.SkillLine1)
                    .HasColumnType("int(11)")
                    .HasColumnName("SkillLine_1");

                entity.Property(e => e.SkillLine2)
                    .HasColumnType("int(11)")
                    .HasColumnName("SkillLine_2");
            });

            modelBuilder.Entity<CreaturemodeldataDbc>(entity =>
            {
                entity.ToTable("creaturemodeldata_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BloodId)
                    .HasColumnType("int(11)")
                    .HasColumnName("BloodID");

                entity.Property(e => e.DeathThudShakeSize).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.FoleyMaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FoleyMaterialID");

                entity.Property(e => e.FootprintTextureId)
                    .HasColumnType("int(11)")
                    .HasColumnName("FootprintTextureID");

                entity.Property(e => e.FootstepShakeSize).HasColumnType("int(11)");

                entity.Property(e => e.ModelName).HasMaxLength(100);

                entity.Property(e => e.SizeClass).HasColumnType("int(11)");

                entity.Property(e => e.SoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SoundID");
            });

            modelBuilder.Entity<CreaturespelldataDbc>(entity =>
            {
                entity.ToTable("creaturespelldata_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Availability1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Availability_1");

                entity.Property(e => e.Availability2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Availability_2");

                entity.Property(e => e.Availability3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Availability_3");

                entity.Property(e => e.Availability4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Availability_4");

                entity.Property(e => e.Spells1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_1");

                entity.Property(e => e.Spells2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_2");

                entity.Property(e => e.Spells3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_3");

                entity.Property(e => e.Spells4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_4");
            });

            modelBuilder.Entity<CreaturetypeDbc>(entity =>
            {
                entity.ToTable("creaturetype_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<CurrencytypesDbc>(entity =>
            {
                entity.ToTable("currencytypes_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BitIndex).HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryID");

                entity.Property(e => e.ItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID");
            });

            modelBuilder.Entity<DestructiblemodeldataDbc>(entity =>
            {
                entity.ToTable("destructiblemodeldata_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Field17).HasColumnType("int(11)");

                entity.Property(e => e.Field18).HasColumnType("int(11)");

                entity.Property(e => e.State0AmbientDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State0DestructionDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State0ImpactEffectDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State0Wmo).HasColumnType("int(11)");

                entity.Property(e => e.State1AmbientDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State1DestructionDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State1ImpactEffectDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State1Wmo).HasColumnType("int(11)");

                entity.Property(e => e.State2AmbientDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State2DestructionDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State2ImpactEffectDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State2Wmo).HasColumnType("int(11)");

                entity.Property(e => e.State3AmbientDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State3DestructionDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State3ImpactEffectDoodadSet).HasColumnType("int(11)");

                entity.Property(e => e.State3Wmo).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Disable>(entity =>
            {
                entity.HasKey(e => new { e.SourceType, e.Entry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("disables");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SourceType)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sourceType");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Params0)
                    .HasMaxLength(255)
                    .HasColumnName("params_0")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Params1)
                    .HasMaxLength(255)
                    .HasColumnName("params_1")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<DisenchantLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("disenchant_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<DungeonAccessRequirement>(entity =>
            {
                entity.HasKey(e => new { e.DungeonAccessId, e.RequirementType, e.RequirementId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("dungeon_access_requirements");

                entity.HasComment("Add (multiple) requirements before being able to enter a dungeon/raid")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.DungeonAccessId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dungeon_access_id")
                    .HasComment("ID from dungeon_access_template");

                entity.Property(e => e.RequirementType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("requirement_type")
                    .HasComment("0 = achiev, 1 = quest, 2 = item");

                entity.Property(e => e.RequirementId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("requirement_id")
                    .HasComment("Achiev/quest/item ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment");

                entity.Property(e => e.Faction)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("faction")
                    .HasDefaultValueSql("'2'")
                    .HasComment("0 = Alliance, 1 = Horde, 2 = Both factions");

                entity.Property(e => e.LeaderOnly)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("leader_only")
                    .HasComment("0 = check the requirement for the player trying to enter, 1 = check the requirement for the party leader");

                entity.Property(e => e.Priority)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("priority")
                    .HasComment("Priority order for the requirement, sorted by type. 0 is the highest priority");

                entity.Property(e => e.RequirementNote)
                    .HasMaxLength(255)
                    .HasColumnName("requirement_note")
                    .HasComment("Optional msg shown ingame to player if he cannot enter. You can add extra info");
            });

            modelBuilder.Entity<DungeonAccessTemplate>(entity =>
            {
                entity.ToTable("dungeon_access_template");

                entity.HasComment("Dungeon/raid access template and single requirements")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.MapId, "FK_dungeon_access_template__instance_template");

                entity.Property(e => e.Id)
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id")
                    .HasComment("The dungeon template ID");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasComment("Dungeon Name 5/10/25/40 man - Normal/Heroic")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("difficulty")
                    .HasComment("5 man: 0 = normal, 1 = heroic, 2 = epic (not implemented) | 10 man: 0 = normal, 2 = heroic | 25 man: 1 = normal, 3 = heroic");

                entity.Property(e => e.MapId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("map_id")
                    .HasComment("Map ID from instance_template");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("max_level");

                entity.Property(e => e.MinAvgItemLevel)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("min_avg_item_level")
                    .HasComment("Min average ilvl required to enter");

                entity.Property(e => e.MinLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("min_level");
            });

            modelBuilder.Entity<DungeonencounterDbc>(entity =>
            {
                entity.ToTable("dungeonencounter_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Bit).HasColumnType("int(11)");

                entity.Property(e => e.Difficulty).HasColumnType("int(11)");

                entity.Property(e => e.MapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.OrderIndex).HasColumnType("int(11)");

                entity.Property(e => e.SpellIconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellIconID");
            });

            modelBuilder.Entity<DurabilitycostsDbc>(entity =>
            {
                entity.ToTable("durabilitycosts_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArmorSubClassCost1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArmorSubClassCost_1");

                entity.Property(e => e.ArmorSubClassCost2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArmorSubClassCost_2");

                entity.Property(e => e.ArmorSubClassCost3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArmorSubClassCost_3");

                entity.Property(e => e.ArmorSubClassCost4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArmorSubClassCost_4");

                entity.Property(e => e.ArmorSubClassCost5)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArmorSubClassCost_5");

                entity.Property(e => e.ArmorSubClassCost6)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArmorSubClassCost_6");

                entity.Property(e => e.ArmorSubClassCost7)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArmorSubClassCost_7");

                entity.Property(e => e.ArmorSubClassCost8)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArmorSubClassCost_8");

                entity.Property(e => e.WeaponSubClassCost1)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_1");

                entity.Property(e => e.WeaponSubClassCost10)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_10");

                entity.Property(e => e.WeaponSubClassCost11)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_11");

                entity.Property(e => e.WeaponSubClassCost12)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_12");

                entity.Property(e => e.WeaponSubClassCost13)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_13");

                entity.Property(e => e.WeaponSubClassCost14)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_14");

                entity.Property(e => e.WeaponSubClassCost15)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_15");

                entity.Property(e => e.WeaponSubClassCost16)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_16");

                entity.Property(e => e.WeaponSubClassCost17)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_17");

                entity.Property(e => e.WeaponSubClassCost18)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_18");

                entity.Property(e => e.WeaponSubClassCost19)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_19");

                entity.Property(e => e.WeaponSubClassCost2)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_2");

                entity.Property(e => e.WeaponSubClassCost20)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_20");

                entity.Property(e => e.WeaponSubClassCost21)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_21");

                entity.Property(e => e.WeaponSubClassCost3)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_3");

                entity.Property(e => e.WeaponSubClassCost4)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_4");

                entity.Property(e => e.WeaponSubClassCost5)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_5");

                entity.Property(e => e.WeaponSubClassCost6)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_6");

                entity.Property(e => e.WeaponSubClassCost7)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_7");

                entity.Property(e => e.WeaponSubClassCost8)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_8");

                entity.Property(e => e.WeaponSubClassCost9)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponSubClassCost_9");
            });

            modelBuilder.Entity<DurabilityqualityDbc>(entity =>
            {
                entity.ToTable("durabilityquality_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<EmotesDbc>(entity =>
            {
                entity.ToTable("emotes_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AnimId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AnimID");

                entity.Property(e => e.EmoteFlags).HasColumnType("int(11)");

                entity.Property(e => e.EmoteSlashCommand).HasMaxLength(100);

                entity.Property(e => e.EmoteSpecProc).HasColumnType("int(11)");

                entity.Property(e => e.EmoteSpecProcParam).HasColumnType("int(11)");

                entity.Property(e => e.EventSoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EventSoundID");
            });

            modelBuilder.Entity<EmotestextDbc>(entity =>
            {
                entity.ToTable("emotestext_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EmoteId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteID");

                entity.Property(e => e.EmoteText1)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_1");

                entity.Property(e => e.EmoteText10)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_10");

                entity.Property(e => e.EmoteText11)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_11");

                entity.Property(e => e.EmoteText12)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_12");

                entity.Property(e => e.EmoteText13)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_13");

                entity.Property(e => e.EmoteText14)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_14");

                entity.Property(e => e.EmoteText15)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_15");

                entity.Property(e => e.EmoteText16)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_16");

                entity.Property(e => e.EmoteText2)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_2");

                entity.Property(e => e.EmoteText3)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_3");

                entity.Property(e => e.EmoteText4)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_4");

                entity.Property(e => e.EmoteText5)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_5");

                entity.Property(e => e.EmoteText6)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_6");

                entity.Property(e => e.EmoteText7)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_7");

                entity.Property(e => e.EmoteText8)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_8");

                entity.Property(e => e.EmoteText9)
                    .HasColumnType("int(11)")
                    .HasColumnName("EmoteText_9");

                entity.Property(e => e.Name).HasMaxLength(100);
            });

            modelBuilder.Entity<EventScript>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("event_scripts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Datalong)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("datalong")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<ExplorationBasexp>(entity =>
            {
                entity.HasKey(e => e.Level)
                    .HasName("PRIMARY");

                entity.ToTable("exploration_basexp");

                entity.HasComment("Exploration System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Basexp)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("basexp")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<FactionDbc>(entity =>
            {
                entity.ToTable("faction_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DescriptionLangDeDe)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_deDE");

                entity.Property(e => e.DescriptionLangEnCn)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_enCN");

                entity.Property(e => e.DescriptionLangEnGb)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_enGB");

                entity.Property(e => e.DescriptionLangEnTw)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_enTW");

                entity.Property(e => e.DescriptionLangEnUs)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_enUS");

                entity.Property(e => e.DescriptionLangEsEs)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_esES");

                entity.Property(e => e.DescriptionLangEsMx)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_esMX");

                entity.Property(e => e.DescriptionLangFrFr)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_frFR");

                entity.Property(e => e.DescriptionLangItIt)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_itIT");

                entity.Property(e => e.DescriptionLangKoKr)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_koKR");

                entity.Property(e => e.DescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Description_Lang_Mask");

                entity.Property(e => e.DescriptionLangPtBr)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_ptBR");

                entity.Property(e => e.DescriptionLangPtPt)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_ptPT");

                entity.Property(e => e.DescriptionLangRuRu)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_ruRU");

                entity.Property(e => e.DescriptionLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_Unk");

                entity.Property(e => e.DescriptionLangZhCn)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_zhCN");

                entity.Property(e => e.DescriptionLangZhTw)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_zhTW");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.ParentFactionCap1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParentFactionCap_1");

                entity.Property(e => e.ParentFactionCap2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParentFactionCap_2");

                entity.Property(e => e.ParentFactionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParentFactionID");

                entity.Property(e => e.ParentFactionMod1).HasColumnName("ParentFactionMod_1");

                entity.Property(e => e.ParentFactionMod2).HasColumnName("ParentFactionMod_2");

                entity.Property(e => e.ReputationBase1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationBase_1");

                entity.Property(e => e.ReputationBase2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationBase_2");

                entity.Property(e => e.ReputationBase3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationBase_3");

                entity.Property(e => e.ReputationBase4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationBase_4");

                entity.Property(e => e.ReputationClassMask1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationClassMask_1");

                entity.Property(e => e.ReputationClassMask2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationClassMask_2");

                entity.Property(e => e.ReputationClassMask3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationClassMask_3");

                entity.Property(e => e.ReputationClassMask4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationClassMask_4");

                entity.Property(e => e.ReputationFlags1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationFlags_1");

                entity.Property(e => e.ReputationFlags2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationFlags_2");

                entity.Property(e => e.ReputationFlags3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationFlags_3");

                entity.Property(e => e.ReputationFlags4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationFlags_4");

                entity.Property(e => e.ReputationIndex).HasColumnType("int(11)");

                entity.Property(e => e.ReputationRaceMask1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationRaceMask_1");

                entity.Property(e => e.ReputationRaceMask2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationRaceMask_2");

                entity.Property(e => e.ReputationRaceMask3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationRaceMask_3");

                entity.Property(e => e.ReputationRaceMask4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReputationRaceMask_4");
            });

            modelBuilder.Entity<FactiontemplateDbc>(entity =>
            {
                entity.ToTable("factiontemplate_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Enemies1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enemies_1");

                entity.Property(e => e.Enemies2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enemies_2");

                entity.Property(e => e.Enemies3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enemies_3");

                entity.Property(e => e.Enemies4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enemies_4");

                entity.Property(e => e.EnemyGroup).HasColumnType("int(11)");

                entity.Property(e => e.Faction).HasColumnType("int(11)");

                entity.Property(e => e.FactionGroup).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Friend1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Friend_1");

                entity.Property(e => e.Friend2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Friend_2");

                entity.Property(e => e.Friend3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Friend_3");

                entity.Property(e => e.Friend4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Friend_4");

                entity.Property(e => e.FriendGroup).HasColumnType("int(11)");
            });

            modelBuilder.Entity<FishingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("fishing_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEvent>(entity =>
            {
                entity.HasKey(e => e.EventEntry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Announce)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("announce")
                    .HasDefaultValueSql("'2'")
                    .HasComment("0 dont announce, 1 announce, 2 value from config");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description")
                    .HasComment("Description of the event displayed in console");

                entity.Property(e => e.EndTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("end_time")
                    .HasDefaultValueSql("'2000-01-01 02:00:00'")
                    .HasComment("Absolute end date, the event will never start after");

                entity.Property(e => e.Holiday)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("holiday")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Client side holiday id");

                entity.Property(e => e.HolidayStage)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("holidayStage");

                entity.Property(e => e.Length)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("length")
                    .HasDefaultValueSql("'2592000'")
                    .HasComment("Length in minutes of the event");

                entity.Property(e => e.Occurence)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("occurence")
                    .HasDefaultValueSql("'5184000'")
                    .HasComment("Delay in minutes between occurences of the event");

                entity.Property(e => e.StartTime)
                    .HasColumnType("timestamp")
                    .HasColumnName("start_time")
                    .HasDefaultValueSql("'2000-01-01 02:00:00'")
                    .HasComment("Absolute start date, the event will never start before");

                entity.Property(e => e.WorldEvent)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("world_event")
                    .HasComment("0 if normal event, 1 if world event");
            });

            modelBuilder.Entity<GameEventArenaSeason>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("game_event_arena_seasons");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Season, e.EventEntry }, "season")
                    .IsUnique();

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Season)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("season")
                    .HasComment("Arena season number");
            });

            modelBuilder.Entity<GameEventBattlegroundHoliday>(entity =>
            {
                entity.HasKey(e => e.EventEntry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_battleground_holiday");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Bgflag)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bgflag");
            });

            modelBuilder.Entity<GameEventCondition>(entity =>
            {
                entity.HasKey(e => new { e.EventEntry, e.ConditionId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_condition");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasMaxLength(25)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DoneWorldStateField)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("done_world_state_field");

                entity.Property(e => e.MaxWorldStateField)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("max_world_state_field");

                entity.Property(e => e.ReqNum)
                    .HasColumnName("req_num")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventCreature>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_creature");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event. Put negative entry to remove during event.");
            });

            modelBuilder.Entity<GameEventCreatureQuest>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_creature_quest");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event.");
            });

            modelBuilder.Entity<GameEventGameobject>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_gameobject");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event. Put negative entry to remove during event.");
            });

            modelBuilder.Entity<GameEventGameobjectQuest>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("game_event_gameobject_quest");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event");
            });

            modelBuilder.Entity<GameEventModelEquip>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_model_equip");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.EquipmentId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("equipment_id");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event.");

                entity.Property(e => e.Modelid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("modelid")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventNpcVendor>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_npc_vendor");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Slot, "slot");

                entity.Property(e => e.Guid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("guid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event.");

                entity.Property(e => e.ExtendedCost)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Incrtime)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("incrtime")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("maxcount")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Slot)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("slot");
            });

            modelBuilder.Entity<GameEventNpcflag>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_npcflag");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("guid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.Npcflag)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("npcflag");
            });

            modelBuilder.Entity<GameEventPool>(entity =>
            {
                entity.HasKey(e => e.PoolEntry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_pool");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PoolEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Id of the pool");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event. Put negative entry to remove during event.");
            });

            modelBuilder.Entity<GameEventPrerequisite>(entity =>
            {
                entity.HasKey(e => new { e.EventEntry, e.PrerequisiteEvent })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_prerequisite");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event");

                entity.Property(e => e.PrerequisiteEvent)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("prerequisite_event");
            });

            modelBuilder.Entity<GameEventQuestCondition>(entity =>
            {
                entity.HasKey(e => e.Quest)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_quest_condition");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("condition_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry")
                    .HasComment("Entry of the game event.");

                entity.Property(e => e.Num)
                    .HasColumnName("num")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventSeasonalQuestrelation>(entity =>
            {
                entity.HasKey(e => new { e.QuestId, e.EventEntry })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_seasonal_questrelation");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.QuestId, "idx_quest");

                entity.Property(e => e.QuestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("questId")
                    .HasComment("Quest Identifier");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("eventEntry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Entry of the game event");
            });

            modelBuilder.Entity<GameGraveyard>(entity =>
            {
                entity.ToTable("game_graveyard");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.Map).HasColumnType("int(11)");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<GameTele>(entity =>
            {
                entity.ToTable("game_tele");

                entity.HasComment("Tele Command")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");
            });

            modelBuilder.Entity<GameWeather>(entity =>
            {
                entity.HasKey(e => e.Zone)
                    .HasName("PRIMARY");

                entity.ToTable("game_weather");

                entity.HasComment("Weather System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Zone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("zone")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.FallRainChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("fall_rain_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.FallSnowChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("fall_snow_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.FallStormChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("fall_storm_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.SpringRainChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spring_rain_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SpringSnowChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spring_snow_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SpringStormChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spring_storm_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerRainChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summer_rain_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerSnowChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summer_snow_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.SummerStormChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summer_storm_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterRainChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("winter_rain_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterSnowChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("winter_snow_chance")
                    .HasDefaultValueSql("'25'");

                entity.Property(e => e.WinterStormChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("winter_storm_chance")
                    .HasDefaultValueSql("'25'");
            });

            modelBuilder.Entity<Gameobject>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject");

                entity.HasComment("Gameobject System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Animprogress)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("animprogress");

                entity.Property(e => e.AreaId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("areaId")
                    .HasComment("Area Identifier");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Gameobject Identifier");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PhaseMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("phaseMask")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Rotation0).HasColumnName("rotation0");

                entity.Property(e => e.Rotation1).HasColumnName("rotation1");

                entity.Property(e => e.Rotation2).HasColumnName("rotation2");

                entity.Property(e => e.Rotation3).HasColumnName("rotation3");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.SpawnMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spawnMask")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Spawntimesecs)
                    .HasColumnType("int(11)")
                    .HasColumnName("spawntimesecs");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("state");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("zoneId")
                    .HasComment("Zone Identifier");
            });

            modelBuilder.Entity<GameobjectAddon>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_addon");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.InvisibilityType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("invisibilityType");

                entity.Property(e => e.InvisibilityValue)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("invisibilityValue");
            });

            modelBuilder.Entity<GameobjectLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameobjectQuestender>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_questender");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<GameobjectQuestitem>(entity =>
            {
                entity.HasKey(e => new { e.GameObjectEntry, e.Idx })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_questitem");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.GameObjectEntry).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<GameobjectQueststarter>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_queststarter");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<GameobjectTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_template");

                entity.HasComment("Gameobject System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Name, "idx_name");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ainame)
                    .HasMaxLength(64)
                    .HasColumnName("AIName")
                    .HasDefaultValueSql("''")
                    .IsFixedLength();

                entity.Property(e => e.CastBarCaption)
                    .HasMaxLength(100)
                    .HasColumnName("castBarCaption")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Data0).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data1).HasColumnType("int(11)");

                entity.Property(e => e.Data10).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data11).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data12).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data13).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data14).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data15).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data16).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data17).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data18).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data19).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data20).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data21).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data22).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data23).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data5).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data6).HasColumnType("int(11)");

                entity.Property(e => e.Data7).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data8).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Data9).HasColumnType("int(10) unsigned");

                entity.Property(e => e.DisplayId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("displayId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.IconName)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasMaxLength(100)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Size)
                    .HasColumnName("size")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Unk1)
                    .HasMaxLength(100)
                    .HasColumnName("unk1")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameobjectTemplateAddon>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("gameobject_template_addon");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Faction)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Maxgold)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("maxgold")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Mingold)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mingold")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameobjectTemplateLocale>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_template_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.CastBarCaption)
                    .HasColumnType("text")
                    .HasColumnName("castBarCaption");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameobjectdisplayinfoDbc>(entity =>
            {
                entity.ToTable("gameobjectdisplayinfo_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ModelName).HasMaxLength(200);

                entity.Property(e => e.ObjectEffectPackageId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ObjectEffectPackageID");

                entity.Property(e => e.Sound1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_1");

                entity.Property(e => e.Sound10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_10");

                entity.Property(e => e.Sound2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_2");

                entity.Property(e => e.Sound3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_3");

                entity.Property(e => e.Sound4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_4");

                entity.Property(e => e.Sound5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_5");

                entity.Property(e => e.Sound6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_6");

                entity.Property(e => e.Sound7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_7");

                entity.Property(e => e.Sound8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_8");

                entity.Property(e => e.Sound9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Sound_9");
            });

            modelBuilder.Entity<GempropertiesDbc>(entity =>
            {
                entity.ToTable("gemproperties_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.EnchantId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchant_Id");

                entity.Property(e => e.MaxcountInv)
                    .HasColumnType("int(11)")
                    .HasColumnName("Maxcount_Inv");

                entity.Property(e => e.MaxcountItem)
                    .HasColumnType("int(11)")
                    .HasColumnName("Maxcount_Item");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GlyphpropertiesDbc>(entity =>
            {
                entity.ToTable("glyphproperties_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GlyphSlotFlags).HasColumnType("int(11)");

                entity.Property(e => e.SpellIconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellIconID");

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellID");
            });

            modelBuilder.Entity<GlyphslotDbc>(entity =>
            {
                entity.ToTable("glyphslot_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Tooltip).HasColumnType("int(11)");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<GossipMenu>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.TextId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MenuId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("MenuID");

                entity.Property(e => e.TextId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("TextID")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GossipMenuOption>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.OptionId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gossip_menu_option");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MenuId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("MenuID");

                entity.Property(e => e.OptionId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("OptionID");

                entity.Property(e => e.ActionMenuId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ActionMenuID");

                entity.Property(e => e.ActionPoiId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ActionPoiID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BoxBroadcastTextId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BoxBroadcastTextID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BoxCoded).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BoxMoney).HasColumnType("int(10) unsigned");

                entity.Property(e => e.BoxText).HasColumnType("text");

                entity.Property(e => e.OptionBroadcastTextId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("OptionBroadcastTextID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OptionIcon)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OptionNpcFlag).HasColumnType("int(10) unsigned");

                entity.Property(e => e.OptionText).HasColumnType("text");

                entity.Property(e => e.OptionType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<GossipMenuOptionLocale>(entity =>
            {
                entity.HasKey(e => new { e.MenuId, e.OptionId, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("gossip_menu_option_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MenuId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("MenuID");

                entity.Property(e => e.OptionId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("OptionID");

                entity.Property(e => e.Locale).HasMaxLength(4);

                entity.Property(e => e.BoxText).HasColumnType("text");

                entity.Property(e => e.OptionText).HasColumnType("text");
            });

            modelBuilder.Entity<GraveyardZone>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.GhostZone })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("graveyard_zone");

                entity.HasComment("Trigger System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GhostZone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.Faction).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<GtbarbershopcostbaseDbc>(entity =>
            {
                entity.ToTable("gtbarbershopcostbase_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtchancetomeleecritDbc>(entity =>
            {
                entity.ToTable("gtchancetomeleecrit_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtchancetomeleecritbaseDbc>(entity =>
            {
                entity.ToTable("gtchancetomeleecritbase_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtchancetospellcritDbc>(entity =>
            {
                entity.ToTable("gtchancetospellcrit_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtchancetospellcritbaseDbc>(entity =>
            {
                entity.ToTable("gtchancetospellcritbase_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtcombatratingsDbc>(entity =>
            {
                entity.ToTable("gtcombatratings_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtnpcmanacostscalerDbc>(entity =>
            {
                entity.ToTable("gtnpcmanacostscaler_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtoctclasscombatratingscalarDbc>(entity =>
            {
                entity.ToTable("gtoctclasscombatratingscalar_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtoctregenhpDbc>(entity =>
            {
                entity.ToTable("gtoctregenhp_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtregenhppersptDbc>(entity =>
            {
                entity.ToTable("gtregenhpperspt_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<GtregenmppersptDbc>(entity =>
            {
                entity.ToTable("gtregenmpperspt_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<HolidayDate>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.DateId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("holiday_dates");

                entity.HasCharSet("latin1")
                    .UseCollation("latin1_swedish_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.DateId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("date_id");

                entity.Property(e => e.DateValue)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("date_value");

                entity.Property(e => e.HolidayDuration)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("holiday_duration");
            });

            modelBuilder.Entity<HolidaysDbc>(entity =>
            {
                entity.ToTable("holidays_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CalendarFilterType).HasColumnType("int(11)");

                entity.Property(e => e.CalendarFlags1)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_1");

                entity.Property(e => e.CalendarFlags10)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_10");

                entity.Property(e => e.CalendarFlags2)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_2");

                entity.Property(e => e.CalendarFlags3)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_3");

                entity.Property(e => e.CalendarFlags4)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_4");

                entity.Property(e => e.CalendarFlags5)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_5");

                entity.Property(e => e.CalendarFlags6)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_6");

                entity.Property(e => e.CalendarFlags7)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_7");

                entity.Property(e => e.CalendarFlags8)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_8");

                entity.Property(e => e.CalendarFlags9)
                    .HasColumnType("int(11)")
                    .HasColumnName("CalendarFlags_9");

                entity.Property(e => e.Date1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_1");

                entity.Property(e => e.Date10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_10");

                entity.Property(e => e.Date11)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_11");

                entity.Property(e => e.Date12)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_12");

                entity.Property(e => e.Date13)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_13");

                entity.Property(e => e.Date14)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_14");

                entity.Property(e => e.Date15)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_15");

                entity.Property(e => e.Date16)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_16");

                entity.Property(e => e.Date17)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_17");

                entity.Property(e => e.Date18)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_18");

                entity.Property(e => e.Date19)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_19");

                entity.Property(e => e.Date2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_2");

                entity.Property(e => e.Date20)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_20");

                entity.Property(e => e.Date21)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_21");

                entity.Property(e => e.Date22)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_22");

                entity.Property(e => e.Date23)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_23");

                entity.Property(e => e.Date24)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_24");

                entity.Property(e => e.Date25)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_25");

                entity.Property(e => e.Date26)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_26");

                entity.Property(e => e.Date3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_3");

                entity.Property(e => e.Date4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_4");

                entity.Property(e => e.Date5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_5");

                entity.Property(e => e.Date6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_6");

                entity.Property(e => e.Date7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_7");

                entity.Property(e => e.Date8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_8");

                entity.Property(e => e.Date9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Date_9");

                entity.Property(e => e.Duration1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_1");

                entity.Property(e => e.Duration10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_10");

                entity.Property(e => e.Duration2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_2");

                entity.Property(e => e.Duration3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_3");

                entity.Property(e => e.Duration4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_4");

                entity.Property(e => e.Duration5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_5");

                entity.Property(e => e.Duration6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_6");

                entity.Property(e => e.Duration7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_7");

                entity.Property(e => e.Duration8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_8");

                entity.Property(e => e.Duration9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Duration_9");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.HolidayDescriptionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("HolidayDescriptionID");

                entity.Property(e => e.HolidayNameId)
                    .HasColumnType("int(11)")
                    .HasColumnName("HolidayNameID");

                entity.Property(e => e.Looping).HasColumnType("int(11)");

                entity.Property(e => e.Priority).HasColumnType("int(11)");

                entity.Property(e => e.Region).HasColumnType("int(11)");

                entity.Property(e => e.TextureFilename).HasMaxLength(100);
            });

            modelBuilder.Entity<InstanceEncounter>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("instance_encounters");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry")
                    .HasComment("Unique entry from DungeonEncounter.dbc");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.CreditEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creditEntry");

                entity.Property(e => e.CreditType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("creditType");

                entity.Property(e => e.LastEncounterDungeon)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("lastEncounterDungeon")
                    .HasComment("If not 0, LfgDungeon.dbc entry for the instance it is last encounter in");
            });

            modelBuilder.Entity<InstanceTemplate>(entity =>
            {
                entity.HasKey(e => e.Map)
                    .HasName("PRIMARY");

                entity.ToTable("instance_template");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("map");

                entity.Property(e => e.AllowMount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("allowMount");

                entity.Property(e => e.Parent)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("parent");

                entity.Property(e => e.Script)
                    .HasMaxLength(128)
                    .HasColumnName("script")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<ItemEnchantmentTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Ench })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_enchantment_template");

                entity.HasComment("Item Random Enchantment System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Ench)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ench")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasColumnName("chance");
            });

            modelBuilder.Entity<ItemLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ItemSetName>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("item_set_names");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.InventoryType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ItemSetNamesLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_set_names_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ItemTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("item_template");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Name, "idx_name")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 250 });

                entity.HasIndex(e => e.Class, "items_index");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AllowableClass)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.AllowableRace)
                    .HasColumnType("int(11)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.AmmoType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("ammo_type");

                entity.Property(e => e.ArcaneRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("arcane_res");

                entity.Property(e => e.Area)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("area")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Armor)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("armor");

                entity.Property(e => e.BagFamily)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Block)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("block")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Bonding)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("bonding");

                entity.Property(e => e.BuyCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.BuyPrice).HasColumnType("bigint(20)");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.ContainerSlots).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Delay)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("delay")
                    .HasDefaultValueSql("'1000'");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.DisenchantId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("DisenchantID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Displayid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("displayid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.DmgMax1).HasColumnName("dmg_max1");

                entity.Property(e => e.DmgMax2).HasColumnName("dmg_max2");

                entity.Property(e => e.DmgMin1).HasColumnName("dmg_min1");

                entity.Property(e => e.DmgMin2).HasColumnName("dmg_min2");

                entity.Property(e => e.DmgType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dmg_type1");

                entity.Property(e => e.DmgType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dmg_type2");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("duration");

                entity.Property(e => e.FireRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("fire_res");

                entity.Property(e => e.Flags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.FlagsCustom)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("flagsCustom");

                entity.Property(e => e.FlagsExtra).HasColumnType("int(10) unsigned");

                entity.Property(e => e.FoodType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.FrostRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("frost_res");

                entity.Property(e => e.GemProperties)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.HolidayId).HasColumnType("int(10) unsigned");

                entity.Property(e => e.HolyRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("holy_res");

                entity.Property(e => e.InventoryType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ItemLevel).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ItemLimitCategory).HasColumnType("smallint(6)");

                entity.Property(e => e.Itemset)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("itemset")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LanguageId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("LanguageID");

                entity.Property(e => e.Lockid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("lockid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Map).HasColumnType("smallint(6)");

                entity.Property(e => e.Material).HasColumnType("tinyint(4)");

                entity.Property(e => e.MaxDurability).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.MaxMoneyLoot)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxMoneyLoot");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("int(11)")
                    .HasColumnName("maxcount");

                entity.Property(e => e.MinMoneyLoot)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("minMoneyLoot");

                entity.Property(e => e.Name)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.NatureRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("nature_res");

                entity.Property(e => e.PageMaterial).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.PageText)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Quality).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RandomProperty)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RandomSuffix)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredCityRank)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredDisenchantSkill)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.RequiredLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RequiredReputationFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredReputationRank).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredSkill).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredSkillRank).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Requiredhonorrank)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("requiredhonorrank")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Requiredspell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("requiredspell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ScalingStatDistribution).HasColumnType("smallint(6)");

                entity.Property(e => e.ScalingStatValue).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.SellPrice).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ShadowRes)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("shadow_res");

                entity.Property(e => e.Sheath)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("sheath");

                entity.Property(e => e.SocketBonus)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("socketBonus")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SocketColor1)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("socketColor_1");

                entity.Property(e => e.SocketColor2)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("socketColor_2");

                entity.Property(e => e.SocketColor3)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("socketColor_3");

                entity.Property(e => e.SocketContent1)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("socketContent_1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SocketContent2)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("socketContent_2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SocketContent3)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("socketContent_3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SoundOverrideSubclass)
                    .HasColumnType("tinyint(4)")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategory1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_1");

                entity.Property(e => e.Spellcategory2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_2");

                entity.Property(e => e.Spellcategory3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_3");

                entity.Property(e => e.Spellcategory4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_4");

                entity.Property(e => e.Spellcategory5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellcategory_5");

                entity.Property(e => e.Spellcategorycooldown1)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_1")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategorycooldown2)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_2")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategorycooldown3)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_3")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategorycooldown4)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_4")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcategorycooldown5)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcategorycooldown_5")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcharges1)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("spellcharges_1");

                entity.Property(e => e.Spellcharges2)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("spellcharges_2");

                entity.Property(e => e.Spellcharges3)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("spellcharges_3");

                entity.Property(e => e.Spellcharges4)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("spellcharges_4");

                entity.Property(e => e.Spellcharges5)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("spellcharges_5");

                entity.Property(e => e.Spellcooldown1)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_1")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcooldown2)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_2")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcooldown3)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_3")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcooldown4)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_4")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellcooldown5)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellcooldown_5")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Spellid1)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spellid_1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellid2)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spellid_2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellid3)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spellid_3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellid4)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spellid_4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Spellid5)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spellid_5")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpellppmRate1).HasColumnName("spellppmRate_1");

                entity.Property(e => e.SpellppmRate2).HasColumnName("spellppmRate_2");

                entity.Property(e => e.SpellppmRate3).HasColumnName("spellppmRate_3");

                entity.Property(e => e.SpellppmRate4).HasColumnName("spellppmRate_4");

                entity.Property(e => e.SpellppmRate5).HasColumnName("spellppmRate_5");

                entity.Property(e => e.Spelltrigger1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_1");

                entity.Property(e => e.Spelltrigger2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_2");

                entity.Property(e => e.Spelltrigger3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_3");

                entity.Property(e => e.Spelltrigger4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_4");

                entity.Property(e => e.Spelltrigger5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spelltrigger_5");

                entity.Property(e => e.Stackable)
                    .HasColumnType("int(11)")
                    .HasColumnName("stackable")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Startquest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("startquest")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.StatType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type1");

                entity.Property(e => e.StatType10)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type10");

                entity.Property(e => e.StatType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type2");

                entity.Property(e => e.StatType3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type3");

                entity.Property(e => e.StatType4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type4");

                entity.Property(e => e.StatType5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type5");

                entity.Property(e => e.StatType6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type6");

                entity.Property(e => e.StatType7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type7");

                entity.Property(e => e.StatType8)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type8");

                entity.Property(e => e.StatType9)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stat_type9");

                entity.Property(e => e.StatValue1)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value1");

                entity.Property(e => e.StatValue10)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value10");

                entity.Property(e => e.StatValue2)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value2");

                entity.Property(e => e.StatValue3)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value3");

                entity.Property(e => e.StatValue4)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value4");

                entity.Property(e => e.StatValue5)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value5");

                entity.Property(e => e.StatValue6)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value6");

                entity.Property(e => e.StatValue7)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value7");

                entity.Property(e => e.StatValue8)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value8");

                entity.Property(e => e.StatValue9)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("stat_value9");

                entity.Property(e => e.StatsCount).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Subclass)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("subclass");

                entity.Property(e => e.TotemCategory)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ItemTemplateLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_template_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.Description).HasColumnType("text");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ItembagfamilyDbc>(entity =>
            {
                entity.ToTable("itembagfamily_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<ItemdisplayinfoDbc>(entity =>
            {
                entity.ToTable("itemdisplayinfo_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.GeosetGroup1)
                    .HasColumnType("int(11)")
                    .HasColumnName("GeosetGroup_1");

                entity.Property(e => e.GeosetGroup2)
                    .HasColumnType("int(11)")
                    .HasColumnName("GeosetGroup_2");

                entity.Property(e => e.GeosetGroup3)
                    .HasColumnType("int(11)")
                    .HasColumnName("GeosetGroup_3");

                entity.Property(e => e.GroupSoundIndex).HasColumnType("int(11)");

                entity.Property(e => e.HelmetGeosetVis1)
                    .HasColumnType("int(11)")
                    .HasColumnName("HelmetGeosetVis_1");

                entity.Property(e => e.HelmetGeosetVis2)
                    .HasColumnType("int(11)")
                    .HasColumnName("HelmetGeosetVis_2");

                entity.Property(e => e.InventoryIcon1)
                    .HasMaxLength(100)
                    .HasColumnName("InventoryIcon_1");

                entity.Property(e => e.InventoryIcon2)
                    .HasMaxLength(100)
                    .HasColumnName("InventoryIcon_2");

                entity.Property(e => e.ItemVisual).HasColumnType("int(11)");

                entity.Property(e => e.ModelName1)
                    .HasMaxLength(100)
                    .HasColumnName("ModelName_1");

                entity.Property(e => e.ModelName2)
                    .HasMaxLength(100)
                    .HasColumnName("ModelName_2");

                entity.Property(e => e.ModelTexture1)
                    .HasMaxLength(100)
                    .HasColumnName("ModelTexture_1");

                entity.Property(e => e.ModelTexture2)
                    .HasMaxLength(100)
                    .HasColumnName("ModelTexture_2");

                entity.Property(e => e.ParticleColorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParticleColorID");

                entity.Property(e => e.SpellVisualId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellVisualID");

                entity.Property(e => e.Texture1)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_1");

                entity.Property(e => e.Texture2)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_2");

                entity.Property(e => e.Texture3)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_3");

                entity.Property(e => e.Texture4)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_4");

                entity.Property(e => e.Texture5)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_5");

                entity.Property(e => e.Texture6)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_6");

                entity.Property(e => e.Texture7)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_7");

                entity.Property(e => e.Texture8)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_8");
            });

            modelBuilder.Entity<ItemextendedcostDbc>(entity =>
            {
                entity.ToTable("itemextendedcost_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArenaBracket).HasColumnType("int(11)");

                entity.Property(e => e.ArenaPoints).HasColumnType("int(11)");

                entity.Property(e => e.HonorPoints).HasColumnType("int(11)");

                entity.Property(e => e.ItemCount1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemCount_1");

                entity.Property(e => e.ItemCount2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemCount_2");

                entity.Property(e => e.ItemCount3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemCount_3");

                entity.Property(e => e.ItemCount4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemCount_4");

                entity.Property(e => e.ItemCount5)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemCount_5");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_1");

                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_2");

                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_3");

                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_4");

                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_5");

                entity.Property(e => e.ItemPurchaseGroup).HasColumnType("int(11)");

                entity.Property(e => e.RequiredArenaRating).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ItemlimitcategoryDbc>(entity =>
            {
                entity.ToTable("itemlimitcategory_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.Quantity).HasColumnType("int(11)");
            });

            modelBuilder.Entity<ItemrandompropertiesDbc>(entity =>
            {
                entity.ToTable("itemrandomproperties_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Enchantment1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_1");

                entity.Property(e => e.Enchantment2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_2");

                entity.Property(e => e.Enchantment3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_3");

                entity.Property(e => e.Enchantment4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_4");

                entity.Property(e => e.Enchantment5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_5");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<ItemrandomsuffixDbc>(entity =>
            {
                entity.ToTable("itemrandomsuffix_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AllocationPct1)
                    .HasColumnType("int(11)")
                    .HasColumnName("AllocationPct_1");

                entity.Property(e => e.AllocationPct2)
                    .HasColumnType("int(11)")
                    .HasColumnName("AllocationPct_2");

                entity.Property(e => e.AllocationPct3)
                    .HasColumnType("int(11)")
                    .HasColumnName("AllocationPct_3");

                entity.Property(e => e.AllocationPct4)
                    .HasColumnType("int(11)")
                    .HasColumnName("AllocationPct_4");

                entity.Property(e => e.AllocationPct5)
                    .HasColumnType("int(11)")
                    .HasColumnName("AllocationPct_5");

                entity.Property(e => e.Enchantment1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_1");

                entity.Property(e => e.Enchantment2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_2");

                entity.Property(e => e.Enchantment3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_3");

                entity.Property(e => e.Enchantment4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_4");

                entity.Property(e => e.Enchantment5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Enchantment_5");

                entity.Property(e => e.InternalName).HasMaxLength(100);

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<ItemsetDbc>(entity =>
            {
                entity.ToTable("itemset_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ItemId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_1");

                entity.Property(e => e.ItemId10)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_10");

                entity.Property(e => e.ItemId11)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_11");

                entity.Property(e => e.ItemId12)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_12");

                entity.Property(e => e.ItemId13)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_13");

                entity.Property(e => e.ItemId14)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_14");

                entity.Property(e => e.ItemId15)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_15");

                entity.Property(e => e.ItemId16)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_16");

                entity.Property(e => e.ItemId17)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_17");

                entity.Property(e => e.ItemId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_2");

                entity.Property(e => e.ItemId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_3");

                entity.Property(e => e.ItemId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_4");

                entity.Property(e => e.ItemId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_5");

                entity.Property(e => e.ItemId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_6");

                entity.Property(e => e.ItemId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_7");

                entity.Property(e => e.ItemId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_8");

                entity.Property(e => e.ItemId9)
                    .HasColumnType("int(11)")
                    .HasColumnName("ItemID_9");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.RequiredSkill).HasColumnType("int(11)");

                entity.Property(e => e.RequiredSkillRank).HasColumnType("int(11)");

                entity.Property(e => e.SetSpellId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetSpellID_1");

                entity.Property(e => e.SetSpellId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetSpellID_2");

                entity.Property(e => e.SetSpellId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetSpellID_3");

                entity.Property(e => e.SetSpellId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetSpellID_4");

                entity.Property(e => e.SetSpellId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetSpellID_5");

                entity.Property(e => e.SetSpellId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetSpellID_6");

                entity.Property(e => e.SetSpellId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetSpellID_7");

                entity.Property(e => e.SetSpellId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetSpellID_8");

                entity.Property(e => e.SetThreshold1)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetThreshold_1");

                entity.Property(e => e.SetThreshold2)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetThreshold_2");

                entity.Property(e => e.SetThreshold3)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetThreshold_3");

                entity.Property(e => e.SetThreshold4)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetThreshold_4");

                entity.Property(e => e.SetThreshold5)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetThreshold_5");

                entity.Property(e => e.SetThreshold6)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetThreshold_6");

                entity.Property(e => e.SetThreshold7)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetThreshold_7");

                entity.Property(e => e.SetThreshold8)
                    .HasColumnType("int(11)")
                    .HasColumnName("SetThreshold_8");
            });

            modelBuilder.Entity<LfgDungeonReward>(entity =>
            {
                entity.HasKey(e => new { e.DungeonId, e.MaxLevel })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("lfg_dungeon_rewards");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DungeonId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("dungeonId")
                    .HasComment("Dungeon entry from dbc");

                entity.Property(e => e.MaxLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxLevel")
                    .HasComment("Max level at which this reward is rewarded");

                entity.Property(e => e.FirstQuestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("firstQuestId")
                    .HasComment("Quest id with rewards for first dungeon this day");

                entity.Property(e => e.OtherQuestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("otherQuestId")
                    .HasComment("Quest id with rewards for Nth dungeon this day");
            });

            modelBuilder.Entity<LfgDungeonTemplate>(entity =>
            {
                entity.HasKey(e => e.DungeonId)
                    .HasName("PRIMARY");

                entity.ToTable("lfg_dungeon_template");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.DungeonId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("dungeonId")
                    .HasComment("Unique id from LFGDungeons.dbc");

                entity.Property(e => e.Name)
                    .HasMaxLength(255)
                    .HasColumnName("name")
                    .UseCollation("latin1_swedish_ci")
                    .HasCharSet("latin1");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<LfgdungeonsDbc>(entity =>
            {
                entity.ToTable("lfgdungeons_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DescriptionLangDeDe)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_deDE");

                entity.Property(e => e.DescriptionLangEnCn)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_enCN");

                entity.Property(e => e.DescriptionLangEnGb)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_enGB");

                entity.Property(e => e.DescriptionLangEnTw)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_enTW");

                entity.Property(e => e.DescriptionLangEnUs)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_enUS");

                entity.Property(e => e.DescriptionLangEsEs)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_esES");

                entity.Property(e => e.DescriptionLangEsMx)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_esMX");

                entity.Property(e => e.DescriptionLangFrFr)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_frFR");

                entity.Property(e => e.DescriptionLangItIt)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_itIT");

                entity.Property(e => e.DescriptionLangKoKr)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_koKR");

                entity.Property(e => e.DescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Description_Lang_Mask");

                entity.Property(e => e.DescriptionLangPtBr)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_ptBR");

                entity.Property(e => e.DescriptionLangPtPt)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_ptPT");

                entity.Property(e => e.DescriptionLangRuRu)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_ruRU");

                entity.Property(e => e.DescriptionLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_Unk");

                entity.Property(e => e.DescriptionLangZhCn)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_zhCN");

                entity.Property(e => e.DescriptionLangZhTw)
                    .HasMaxLength(200)
                    .HasColumnName("Description_Lang_zhTW");

                entity.Property(e => e.Difficulty).HasColumnType("int(11)");

                entity.Property(e => e.ExpansionLevel).HasColumnType("int(11)");

                entity.Property(e => e.Faction).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Group_Id");

                entity.Property(e => e.MapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID");

                entity.Property(e => e.MaxLevel).HasColumnType("int(11)");

                entity.Property(e => e.MinLevel).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.OrderIndex)
                    .HasColumnType("int(11)")
                    .HasColumnName("Order_Index");

                entity.Property(e => e.TargetLevel)
                    .HasColumnType("int(11)")
                    .HasColumnName("Target_Level");

                entity.Property(e => e.TargetLevelMax)
                    .HasColumnType("int(11)")
                    .HasColumnName("Target_Level_Max");

                entity.Property(e => e.TargetLevelMin)
                    .HasColumnType("int(11)")
                    .HasColumnName("Target_Level_Min");

                entity.Property(e => e.TextureFilename).HasMaxLength(100);

                entity.Property(e => e.TypeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TypeID");
            });

            modelBuilder.Entity<LightDbc>(entity =>
            {
                entity.ToTable("light_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContinentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContinentID");

                entity.Property(e => e.LightParamsId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightParamsID_1");

                entity.Property(e => e.LightParamsId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightParamsID_2");

                entity.Property(e => e.LightParamsId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightParamsID_3");

                entity.Property(e => e.LightParamsId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightParamsID_4");

                entity.Property(e => e.LightParamsId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightParamsID_5");

                entity.Property(e => e.LightParamsId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightParamsID_6");

                entity.Property(e => e.LightParamsId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightParamsID_7");

                entity.Property(e => e.LightParamsId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightParamsID_8");
            });

            modelBuilder.Entity<LinkedRespawn>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.LinkType })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("linked_respawn");

                entity.HasComment("Creature Respawn Link System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("dependent creature");

                entity.Property(e => e.LinkType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("linkType");

                entity.Property(e => e.LinkedGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("linkedGuid")
                    .HasComment("master creature");
            });

            modelBuilder.Entity<LiquidtypeDbc>(entity =>
            {
                entity.ToTable("liquidtype_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Color1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Color_1");

                entity.Property(e => e.Color2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Color_2");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Float1).HasColumnName("Float_1");

                entity.Property(e => e.Float10).HasColumnName("Float_10");

                entity.Property(e => e.Float11).HasColumnName("Float_11");

                entity.Property(e => e.Float12).HasColumnName("Float_12");

                entity.Property(e => e.Float13).HasColumnName("Float_13");

                entity.Property(e => e.Float14).HasColumnName("Float_14");

                entity.Property(e => e.Float15).HasColumnName("Float_15");

                entity.Property(e => e.Float16).HasColumnName("Float_16");

                entity.Property(e => e.Float17).HasColumnName("Float_17");

                entity.Property(e => e.Float18).HasColumnName("Float_18");

                entity.Property(e => e.Float2).HasColumnName("Float_2");

                entity.Property(e => e.Float3).HasColumnName("Float_3");

                entity.Property(e => e.Float4).HasColumnName("Float_4");

                entity.Property(e => e.Float5).HasColumnName("Float_5");

                entity.Property(e => e.Float6).HasColumnName("Float_6");

                entity.Property(e => e.Float7).HasColumnName("Float_7");

                entity.Property(e => e.Float8).HasColumnName("Float_8");

                entity.Property(e => e.Float9).HasColumnName("Float_9");

                entity.Property(e => e.Int1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Int_1");

                entity.Property(e => e.Int2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Int_2");

                entity.Property(e => e.Int3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Int_3");

                entity.Property(e => e.Int4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Int_4");

                entity.Property(e => e.LightId)
                    .HasColumnType("int(11)")
                    .HasColumnName("LightID");

                entity.Property(e => e.MaterialId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MaterialID");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.ParticleMovement).HasColumnType("int(11)");

                entity.Property(e => e.ParticleTexSlots).HasColumnType("int(11)");

                entity.Property(e => e.SoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SoundID");

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellID");

                entity.Property(e => e.Texture1)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_1");

                entity.Property(e => e.Texture2)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_2");

                entity.Property(e => e.Texture3)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_3");

                entity.Property(e => e.Texture4)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_4");

                entity.Property(e => e.Texture5)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_5");

                entity.Property(e => e.Texture6)
                    .HasMaxLength(100)
                    .HasColumnName("Texture_6");

                entity.Property(e => e.Type).HasColumnType("int(11)");
            });

            modelBuilder.Entity<LockDbc>(entity =>
            {
                entity.ToTable("lock_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Action1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Action_1");

                entity.Property(e => e.Action2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Action_2");

                entity.Property(e => e.Action3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Action_3");

                entity.Property(e => e.Action4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Action_4");

                entity.Property(e => e.Action5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Action_5");

                entity.Property(e => e.Action6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Action_6");

                entity.Property(e => e.Action7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Action_7");

                entity.Property(e => e.Action8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Action_8");

                entity.Property(e => e.Index1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Index_1");

                entity.Property(e => e.Index2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Index_2");

                entity.Property(e => e.Index3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Index_3");

                entity.Property(e => e.Index4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Index_4");

                entity.Property(e => e.Index5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Index_5");

                entity.Property(e => e.Index6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Index_6");

                entity.Property(e => e.Index7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Index_7");

                entity.Property(e => e.Index8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Index_8");

                entity.Property(e => e.Skill1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Skill_1");

                entity.Property(e => e.Skill2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Skill_2");

                entity.Property(e => e.Skill3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Skill_3");

                entity.Property(e => e.Skill4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Skill_4");

                entity.Property(e => e.Skill5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Skill_5");

                entity.Property(e => e.Skill6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Skill_6");

                entity.Property(e => e.Skill7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Skill_7");

                entity.Property(e => e.Skill8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Skill_8");

                entity.Property(e => e.Type1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Type_1");

                entity.Property(e => e.Type2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Type_2");

                entity.Property(e => e.Type3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Type_3");

                entity.Property(e => e.Type4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Type_4");

                entity.Property(e => e.Type5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Type_5");

                entity.Property(e => e.Type6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Type_6");

                entity.Property(e => e.Type7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Type_7");

                entity.Property(e => e.Type8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Type_8");
            });

            modelBuilder.Entity<MailLevelReward>(entity =>
            {
                entity.HasKey(e => new { e.Level, e.RaceMask })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mail_level_reward");

                entity.HasComment("Mail System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("raceMask")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mailTemplateId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SenderEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("senderEntry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MailLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("mail_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MailtemplateDbc>(entity =>
            {
                entity.ToTable("mailtemplate_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BodyLangDeDe)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_deDE");

                entity.Property(e => e.BodyLangEnCn)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_enCN");

                entity.Property(e => e.BodyLangEnGb)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_enGB");

                entity.Property(e => e.BodyLangEnTw)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_enTW");

                entity.Property(e => e.BodyLangEnUs)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_enUS");

                entity.Property(e => e.BodyLangEsEs)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_esES");

                entity.Property(e => e.BodyLangEsMx)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_esMX");

                entity.Property(e => e.BodyLangFrFr)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_frFR");

                entity.Property(e => e.BodyLangItIt)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_itIT");

                entity.Property(e => e.BodyLangKoKr)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_koKR");

                entity.Property(e => e.BodyLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Body_Lang_Mask");

                entity.Property(e => e.BodyLangPtBr)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_ptBR");

                entity.Property(e => e.BodyLangPtPt)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_ptPT");

                entity.Property(e => e.BodyLangRuRu)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_ruRU");

                entity.Property(e => e.BodyLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Body_Lang_Unk");

                entity.Property(e => e.BodyLangZhCn)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_zhCN");

                entity.Property(e => e.BodyLangZhTw)
                    .HasMaxLength(500)
                    .HasColumnName("Body_Lang_zhTW");

                entity.Property(e => e.SubjectLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_deDE");

                entity.Property(e => e.SubjectLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_enCN");

                entity.Property(e => e.SubjectLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_enGB");

                entity.Property(e => e.SubjectLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_enTW");

                entity.Property(e => e.SubjectLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_enUS");

                entity.Property(e => e.SubjectLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_esES");

                entity.Property(e => e.SubjectLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_esMX");

                entity.Property(e => e.SubjectLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_frFR");

                entity.Property(e => e.SubjectLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_itIT");

                entity.Property(e => e.SubjectLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_koKR");

                entity.Property(e => e.SubjectLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Subject_Lang_Mask");

                entity.Property(e => e.SubjectLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_ptBR");

                entity.Property(e => e.SubjectLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_ptPT");

                entity.Property(e => e.SubjectLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_ruRU");

                entity.Property(e => e.SubjectLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_Unk");

                entity.Property(e => e.SubjectLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_zhCN");

                entity.Property(e => e.SubjectLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Subject_Lang_zhTW");
            });

            modelBuilder.Entity<MapDbc>(entity =>
            {
                entity.ToTable("map_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaTableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaTableID");

                entity.Property(e => e.CorpseMapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CorpseMapID");

                entity.Property(e => e.Directory).HasMaxLength(100);

                entity.Property(e => e.ExpansionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ExpansionID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.InstanceType).HasColumnType("int(11)");

                entity.Property(e => e.LoadingScreenId)
                    .HasColumnType("int(11)")
                    .HasColumnName("LoadingScreenID");

                entity.Property(e => e.MapDescription0LangDeDe)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_deDE");

                entity.Property(e => e.MapDescription0LangEnCn)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_enCN");

                entity.Property(e => e.MapDescription0LangEnGb)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_enGB");

                entity.Property(e => e.MapDescription0LangEnTw)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_enTW");

                entity.Property(e => e.MapDescription0LangEnUs)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_enUS");

                entity.Property(e => e.MapDescription0LangEsEs)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_esES");

                entity.Property(e => e.MapDescription0LangEsMx)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_esMX");

                entity.Property(e => e.MapDescription0LangFrFr)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_frFR");

                entity.Property(e => e.MapDescription0LangItIt)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_itIT");

                entity.Property(e => e.MapDescription0LangKoKr)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_koKR");

                entity.Property(e => e.MapDescription0LangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("MapDescription0_Lang_Mask");

                entity.Property(e => e.MapDescription0LangPtBr)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_ptBR");

                entity.Property(e => e.MapDescription0LangPtPt)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_ptPT");

                entity.Property(e => e.MapDescription0LangRuRu)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_ruRU");

                entity.Property(e => e.MapDescription0LangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("MapDescription0_Lang_Unk");

                entity.Property(e => e.MapDescription0LangZhCn)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_zhCN");

                entity.Property(e => e.MapDescription0LangZhTw)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription0_Lang_zhTW");

                entity.Property(e => e.MapDescription1LangDeDe)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_deDE");

                entity.Property(e => e.MapDescription1LangEnCn)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_enCN");

                entity.Property(e => e.MapDescription1LangEnGb)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_enGB");

                entity.Property(e => e.MapDescription1LangEnTw)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_enTW");

                entity.Property(e => e.MapDescription1LangEnUs)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_enUS");

                entity.Property(e => e.MapDescription1LangEsEs)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_esES");

                entity.Property(e => e.MapDescription1LangEsMx)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_esMX");

                entity.Property(e => e.MapDescription1LangFrFr)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_frFR");

                entity.Property(e => e.MapDescription1LangItIt)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_itIT");

                entity.Property(e => e.MapDescription1LangKoKr)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_koKR");

                entity.Property(e => e.MapDescription1LangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("MapDescription1_Lang_Mask");

                entity.Property(e => e.MapDescription1LangPtBr)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_ptBR");

                entity.Property(e => e.MapDescription1LangPtPt)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_ptPT");

                entity.Property(e => e.MapDescription1LangRuRu)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_ruRU");

                entity.Property(e => e.MapDescription1LangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("MapDescription1_Lang_Unk");

                entity.Property(e => e.MapDescription1LangZhCn)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_zhCN");

                entity.Property(e => e.MapDescription1LangZhTw)
                    .HasColumnType("text")
                    .HasColumnName("MapDescription1_Lang_zhTW");

                entity.Property(e => e.MapNameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_deDE");

                entity.Property(e => e.MapNameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_enCN");

                entity.Property(e => e.MapNameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_enGB");

                entity.Property(e => e.MapNameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_enTW");

                entity.Property(e => e.MapNameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_enUS");

                entity.Property(e => e.MapNameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_esES");

                entity.Property(e => e.MapNameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_esMX");

                entity.Property(e => e.MapNameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_frFR");

                entity.Property(e => e.MapNameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_itIT");

                entity.Property(e => e.MapNameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_koKR");

                entity.Property(e => e.MapNameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("MapName_Lang_Mask");

                entity.Property(e => e.MapNameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_ptBR");

                entity.Property(e => e.MapNameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_ptPT");

                entity.Property(e => e.MapNameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_ruRU");

                entity.Property(e => e.MapNameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_Unk");

                entity.Property(e => e.MapNameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_zhCN");

                entity.Property(e => e.MapNameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("MapName_Lang_zhTW");

                entity.Property(e => e.MaxPlayers).HasColumnType("int(11)");

                entity.Property(e => e.Pvp)
                    .HasColumnType("int(11)")
                    .HasColumnName("PVP");

                entity.Property(e => e.RaidOffset).HasColumnType("int(11)");

                entity.Property(e => e.TimeOfDayOverride).HasColumnType("int(11)");
            });

            modelBuilder.Entity<MapdifficultyDbc>(entity =>
            {
                entity.ToTable("mapdifficulty_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Difficulty).HasColumnType("int(11)");

                entity.Property(e => e.Difficultystring).HasMaxLength(100);

                entity.Property(e => e.MapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID");

                entity.Property(e => e.MaxPlayers).HasColumnType("int(11)");

                entity.Property(e => e.MessageLangDeDe)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_deDE");

                entity.Property(e => e.MessageLangEnCn)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_enCN");

                entity.Property(e => e.MessageLangEnGb)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_enGB");

                entity.Property(e => e.MessageLangEnTw)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_enTW");

                entity.Property(e => e.MessageLangEnUs)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_enUS");

                entity.Property(e => e.MessageLangEsEs)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_esES");

                entity.Property(e => e.MessageLangEsMx)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_esMX");

                entity.Property(e => e.MessageLangFrFr)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_frFR");

                entity.Property(e => e.MessageLangItIt)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_itIT");

                entity.Property(e => e.MessageLangKoKr)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_koKR");

                entity.Property(e => e.MessageLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Message_Lang_Mask");

                entity.Property(e => e.MessageLangPtBr)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_ptBR");

                entity.Property(e => e.MessageLangPtPt)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_ptPT");

                entity.Property(e => e.MessageLangRuRu)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_ruRU");

                entity.Property(e => e.MessageLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Message_Lang_Unk");

                entity.Property(e => e.MessageLangZhCn)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_zhCN");

                entity.Property(e => e.MessageLangZhTw)
                    .HasMaxLength(200)
                    .HasColumnName("Message_Lang_zhTW");

                entity.Property(e => e.RaidDuration).HasColumnType("int(11)");
            });

            modelBuilder.Entity<MillingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("milling_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<MovieDbc>(entity =>
            {
                entity.ToTable("movie_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Filename).HasMaxLength(100);

                entity.Property(e => e.Volume).HasColumnType("int(11)");
            });

            modelBuilder.Entity<NpcSpellclickSpell>(entity =>
            {
                entity.HasKey(e => new { e.NpcEntry, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("npc_spellclick_spells");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.NpcEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("npc_entry")
                    .HasComment("reference to creature_template");

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spell_id")
                    .HasComment("spell which should be casted ");

                entity.Property(e => e.CastFlags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("cast_flags")
                    .HasComment("first bit defines caster: 1=player, 0=creature; second bit defines target, same mapping as caster bit");

                entity.Property(e => e.UserType)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("user_type")
                    .HasComment("relation with summoner: 0-no 1-friendly 2-raid 3-party player can click");
            });

            modelBuilder.Entity<NpcText>(entity =>
            {
                entity.ToTable("npc_text");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId0)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BroadcastTextID0")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId1)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BroadcastTextID1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId2)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BroadcastTextID2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId3)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BroadcastTextID3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId4)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BroadcastTextID4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId5)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BroadcastTextID5")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId6)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BroadcastTextID6")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.BroadcastTextId7)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("BroadcastTextID7")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Em00)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_0");

                entity.Property(e => e.Em01)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_1");

                entity.Property(e => e.Em02)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_2");

                entity.Property(e => e.Em03)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_3");

                entity.Property(e => e.Em04)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_4");

                entity.Property(e => e.Em05)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em0_5");

                entity.Property(e => e.Em10)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_0");

                entity.Property(e => e.Em11)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_1");

                entity.Property(e => e.Em12)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_2");

                entity.Property(e => e.Em13)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_3");

                entity.Property(e => e.Em14)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_4");

                entity.Property(e => e.Em15)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em1_5");

                entity.Property(e => e.Em20)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_0");

                entity.Property(e => e.Em21)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_1");

                entity.Property(e => e.Em22)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_2");

                entity.Property(e => e.Em23)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_3");

                entity.Property(e => e.Em24)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_4");

                entity.Property(e => e.Em25)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em2_5");

                entity.Property(e => e.Em30)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_0");

                entity.Property(e => e.Em31)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_1");

                entity.Property(e => e.Em32)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_2");

                entity.Property(e => e.Em33)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_3");

                entity.Property(e => e.Em34)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_4");

                entity.Property(e => e.Em35)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em3_5");

                entity.Property(e => e.Em40)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_0");

                entity.Property(e => e.Em41)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_1");

                entity.Property(e => e.Em42)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_2");

                entity.Property(e => e.Em43)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_3");

                entity.Property(e => e.Em44)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_4");

                entity.Property(e => e.Em45)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em4_5");

                entity.Property(e => e.Em50)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_0");

                entity.Property(e => e.Em51)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_1");

                entity.Property(e => e.Em52)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_2");

                entity.Property(e => e.Em53)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_3");

                entity.Property(e => e.Em54)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_4");

                entity.Property(e => e.Em55)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em5_5");

                entity.Property(e => e.Em60)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_0");

                entity.Property(e => e.Em61)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_1");

                entity.Property(e => e.Em62)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_2");

                entity.Property(e => e.Em63)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_3");

                entity.Property(e => e.Em64)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_4");

                entity.Property(e => e.Em65)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em6_5");

                entity.Property(e => e.Em70)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_0");

                entity.Property(e => e.Em71)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_1");

                entity.Property(e => e.Em72)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_2");

                entity.Property(e => e.Em73)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_3");

                entity.Property(e => e.Em74)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_4");

                entity.Property(e => e.Em75)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("em7_5");

                entity.Property(e => e.Lang0)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang0");

                entity.Property(e => e.Lang1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang1");

                entity.Property(e => e.Lang2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang2");

                entity.Property(e => e.Lang3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang3");

                entity.Property(e => e.Lang4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang4");

                entity.Property(e => e.Lang5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang5");

                entity.Property(e => e.Lang6)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang6");

                entity.Property(e => e.Lang7)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lang7");

                entity.Property(e => e.Text00).HasColumnName("text0_0");

                entity.Property(e => e.Text01).HasColumnName("text0_1");

                entity.Property(e => e.Text10).HasColumnName("text1_0");

                entity.Property(e => e.Text11).HasColumnName("text1_1");

                entity.Property(e => e.Text20).HasColumnName("text2_0");

                entity.Property(e => e.Text21).HasColumnName("text2_1");

                entity.Property(e => e.Text30).HasColumnName("text3_0");

                entity.Property(e => e.Text31).HasColumnName("text3_1");

                entity.Property(e => e.Text40).HasColumnName("text4_0");

                entity.Property(e => e.Text41).HasColumnName("text4_1");

                entity.Property(e => e.Text50).HasColumnName("text5_0");

                entity.Property(e => e.Text51).HasColumnName("text5_1");

                entity.Property(e => e.Text60).HasColumnName("text6_0");

                entity.Property(e => e.Text61).HasColumnName("text6_1");

                entity.Property(e => e.Text70).HasColumnName("text7_0");

                entity.Property(e => e.Text71).HasColumnName("text7_1");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<NpcTextLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("npc_text_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale).HasMaxLength(4);

                entity.Property(e => e.Text00).HasColumnName("Text0_0");

                entity.Property(e => e.Text01).HasColumnName("Text0_1");

                entity.Property(e => e.Text10).HasColumnName("Text1_0");

                entity.Property(e => e.Text11).HasColumnName("Text1_1");

                entity.Property(e => e.Text20).HasColumnName("Text2_0");

                entity.Property(e => e.Text21).HasColumnName("Text2_1");

                entity.Property(e => e.Text30).HasColumnName("Text3_0");

                entity.Property(e => e.Text31).HasColumnName("Text3_1");

                entity.Property(e => e.Text40).HasColumnName("Text4_0");

                entity.Property(e => e.Text41).HasColumnName("Text4_1");

                entity.Property(e => e.Text50).HasColumnName("Text5_0");

                entity.Property(e => e.Text51).HasColumnName("Text5_1");

                entity.Property(e => e.Text60).HasColumnName("Text6_0");

                entity.Property(e => e.Text61).HasColumnName("Text6_1");

                entity.Property(e => e.Text70).HasColumnName("Text7_0");

                entity.Property(e => e.Text71).HasColumnName("Text7_1");
            });

            modelBuilder.Entity<NpcTrainer>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("npc_trainer");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("SpellID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MoneyCost).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ReqLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ReqSkillLine).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ReqSkillRank).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<NpcVendor>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item, e.ExtendedCost })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("npc_vendor");

                entity.HasComment("Npc System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Slot, "slot");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("item")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ExtendedCost)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Incrtime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("incrtime");

                entity.Property(e => e.Maxcount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("maxcount");

                entity.Property(e => e.Slot)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("slot");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<OutdoorpvpTemplate>(entity =>
            {
                entity.HasKey(e => e.TypeId)
                    .HasName("PRIMARY");

                entity.ToTable("outdoorpvp_template");

                entity.HasComment("OutdoorPvP Templates")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.TypeId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<OverridespelldataDbc>(entity =>
            {
                entity.ToTable("overridespelldata_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Spells1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_1");

                entity.Property(e => e.Spells10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_10");

                entity.Property(e => e.Spells2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_2");

                entity.Property(e => e.Spells3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_3");

                entity.Property(e => e.Spells4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_4");

                entity.Property(e => e.Spells5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_5");

                entity.Property(e => e.Spells6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_6");

                entity.Property(e => e.Spells7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_7");

                entity.Property(e => e.Spells8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_8");

                entity.Property(e => e.Spells9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Spells_9");
            });

            modelBuilder.Entity<PageText>(entity =>
            {
                entity.ToTable("page_text");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.NextPageId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("NextPageID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PageTextLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("page_text_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.Text).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PetLevelstat>(entity =>
            {
                entity.HasKey(e => new { e.CreatureEntry, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pet_levelstats");

                entity.HasComment("Stores pet levels stats.")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreatureEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("creature_entry");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Agi)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("agi");

                entity.Property(e => e.Armor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("armor");

                entity.Property(e => e.Hp)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("hp");

                entity.Property(e => e.Inte)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("inte");

                entity.Property(e => e.Mana)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mana");

                entity.Property(e => e.MaxDmg)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("max_dmg");

                entity.Property(e => e.MinDmg)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("min_dmg");

                entity.Property(e => e.Spi)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spi");

                entity.Property(e => e.Sta)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("sta");

                entity.Property(e => e.Str)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("str");
            });

            modelBuilder.Entity<PetNameGeneration>(entity =>
            {
                entity.ToTable("pet_name_generation");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Half)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("half");

                entity.Property(e => e.Word)
                    .HasColumnType("tinytext")
                    .HasColumnName("word");
            });

            modelBuilder.Entity<PickpocketingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pickpocketing_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlayerClasslevelstat>(entity =>
            {
                entity.HasKey(e => new { e.Class, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_classlevelstats");

                entity.HasComment("Stores levels stats.")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Basehp)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basehp");

                entity.Property(e => e.Basemana)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("basemana");
            });

            modelBuilder.Entity<PlayerFactionchangeAchievement>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_achievement");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AllianceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("alliance_id");

                entity.Property(e => e.HordeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("horde_id");
            });

            modelBuilder.Entity<PlayerFactionchangeItem>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_items");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AllianceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("alliance_id");

                entity.Property(e => e.HordeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("horde_id");

                entity.Property(e => e.AllianceComment)
                    .HasColumnType("text")
                    .HasColumnName("alliance_comment");

                entity.Property(e => e.HordeComment)
                    .HasColumnType("text")
                    .HasColumnName("horde_comment");
            });

            modelBuilder.Entity<PlayerFactionchangeQuest>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_quests");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.AllianceId, "alliance_uniq")
                    .IsUnique();

                entity.HasIndex(e => e.HordeId, "horde_uniq")
                    .IsUnique();

                entity.Property(e => e.AllianceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("alliance_id");

                entity.Property(e => e.HordeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("horde_id");
            });

            modelBuilder.Entity<PlayerFactionchangeReputation>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_reputations");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AllianceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("alliance_id");

                entity.Property(e => e.HordeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("horde_id");
            });

            modelBuilder.Entity<PlayerFactionchangeSpell>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_spells");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AllianceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("alliance_id");

                entity.Property(e => e.HordeId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("horde_id");

                entity.Property(e => e.AllianceComment)
                    .HasColumnType("text")
                    .HasColumnName("alliance_comment");

                entity.Property(e => e.HordeComment)
                    .HasColumnType("text")
                    .HasColumnName("horde_comment");
            });

            modelBuilder.Entity<PlayerFactionchangeTitle>(entity =>
            {
                entity.HasKey(e => new { e.AllianceId, e.HordeId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_factionchange_titles");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AllianceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("alliance_id");

                entity.Property(e => e.HordeId)
                    .HasColumnType("int(11)")
                    .HasColumnName("horde_id");

                entity.Property(e => e.AllianceComment)
                    .HasColumnType("text")
                    .HasColumnName("alliance_comment");

                entity.Property(e => e.HordeComment)
                    .HasColumnType("text")
                    .HasColumnName("horde_comment");
            });

            modelBuilder.Entity<PlayerLevelstat>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Level })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("player_levelstats");

                entity.HasComment("Stores levels stats.")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Agi)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("agi");

                entity.Property(e => e.Inte)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("inte");

                entity.Property(e => e.Spi)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spi");

                entity.Property(e => e.Sta)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("sta");

                entity.Property(e => e.Str)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("str");
            });

            modelBuilder.Entity<PlayerLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("player_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasColumnType("text");

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlayerXpForLevel>(entity =>
            {
                entity.HasKey(e => e.Level)
                    .HasName("PRIMARY");

                entity.ToTable("player_xp_for_level");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Level).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Experience).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<Playercreateinfo>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("playercreateinfo");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Zone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("zone")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PlayercreateinfoAction>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Button })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_action");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Button)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("button");

                entity.Property(e => e.Action)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action");

                entity.Property(e => e.Type)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<PlayercreateinfoItem>(entity =>
            {
                entity.HasKey(e => new { e.Race, e.Class, e.Itemid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_item");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Race, e.Class }, "playercreateinfo_race_class_index");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.Itemid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("itemid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Amount)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Note).HasMaxLength(255);
            });

            modelBuilder.Entity<PlayercreateinfoSkill>(entity =>
            {
                entity.HasKey(e => new { e.RaceMask, e.ClassMask, e.Skill })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_skills");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.RaceMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("raceMask");

                entity.Property(e => e.ClassMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("classMask");

                entity.Property(e => e.Skill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("skill");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment");

                entity.Property(e => e.Rank)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("rank");
            });

            modelBuilder.Entity<PlayercreateinfoSpellCustom>(entity =>
            {
                entity.HasKey(e => new { e.Racemask, e.Classmask, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("playercreateinfo_spell_custom");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Racemask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("racemask");

                entity.Property(e => e.Classmask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("classmask");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Note).HasMaxLength(255);
            });

            modelBuilder.Entity<PointsOfInterest>(entity =>
            {
                entity.ToTable("points_of_interest");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Flags)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Icon)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Importance)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name).HasColumnType("text");
            });

            modelBuilder.Entity<PointsOfInterestLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("points_of_interest_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.Name).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolCreature>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("pool_creature");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Chance).HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.PoolEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolGameobject>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("pool_gameobject");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Chance).HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.PoolEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolPool>(entity =>
            {
                entity.HasKey(e => e.PoolId)
                    .HasName("PRIMARY");

                entity.ToTable("pool_pool");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PoolId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasColumnName("chance");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.MotherPool)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("mother_pool")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolQuest>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("pool_quest");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Entry, "idx_guid");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.PoolEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pool_entry")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PoolTemplate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("pool_template");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Pool entry");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description");

                entity.Property(e => e.MaxLimit)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("max_limit")
                    .HasComment("Max number of objects (0) is no limit");
            });

            modelBuilder.Entity<PowerdisplayDbc>(entity =>
            {
                entity.ToTable("powerdisplay_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActualType).HasColumnType("int(11)");

                entity.Property(e => e.Blue).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.GlobalstringBaseTag).HasMaxLength(100);

                entity.Property(e => e.Green).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Red).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<ProspectingLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("prospecting_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PvpdifficultyDbc>(entity =>
            {
                entity.ToTable("pvpdifficulty_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Difficulty).HasColumnType("int(11)");

                entity.Property(e => e.MapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID");

                entity.Property(e => e.MaxLevel).HasColumnType("int(11)");

                entity.Property(e => e.MinLevel).HasColumnType("int(11)");

                entity.Property(e => e.RangeIndex).HasColumnType("int(11)");
            });

            modelBuilder.Entity<QuestDetail>(entity =>
            {
                entity.ToTable("quest_details");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Emote1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.EmoteDelay1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestMailSender>(entity =>
            {
                entity.HasKey(e => e.QuestId)
                    .HasName("PRIMARY");

                entity.ToTable("quest_mail_sender");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.QuestId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever();

                entity.Property(e => e.RewardMailSenderEntry).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<QuestMoneyReward>(entity =>
            {
                entity.HasKey(e => e.Level)
                    .HasName("PRIMARY");

                entity.ToTable("quest_money_reward");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever();

                entity.Property(e => e.Money0).HasColumnType("int(11)");

                entity.Property(e => e.Money1).HasColumnType("int(11)");

                entity.Property(e => e.Money2).HasColumnType("int(11)");

                entity.Property(e => e.Money3).HasColumnType("int(11)");

                entity.Property(e => e.Money4).HasColumnType("int(11)");

                entity.Property(e => e.Money5).HasColumnType("int(11)");

                entity.Property(e => e.Money6).HasColumnType("int(11)");

                entity.Property(e => e.Money7).HasColumnType("int(11)");

                entity.Property(e => e.Money8).HasColumnType("int(11)");

                entity.Property(e => e.Money9).HasColumnType("int(11)");
            });

            modelBuilder.Entity<QuestOfferReward>(entity =>
            {
                entity.ToTable("quest_offer_reward");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Emote1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.Emote4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.EmoteDelay1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.EmoteDelay4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardText).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestOfferRewardLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_offer_reward_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.RewardText).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestPoi>(entity =>
            {
                entity.HasKey(e => new { e.QuestId, e.Id })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_poi");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.QuestId, e.Id }, "idx");

                entity.Property(e => e.QuestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("QuestID");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Flags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Floor).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MapId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("MapID");

                entity.Property(e => e.ObjectiveIndex).HasColumnType("int(11)");

                entity.Property(e => e.Priority).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WorldMapAreaId).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<QuestPoiPoint>(entity =>
            {
                entity.HasKey(e => new { e.QuestId, e.Idx1, e.Idx2 })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("quest_poi_points");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.QuestId, e.Idx1 }, "questId_id");

                entity.Property(e => e.QuestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("QuestID");

                entity.Property(e => e.Idx1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Idx2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.X).HasColumnType("int(11)");

                entity.Property(e => e.Y).HasColumnType("int(11)");
            });

            modelBuilder.Entity<QuestRequestItem>(entity =>
            {
                entity.ToTable("quest_request_items");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CompletionText).HasColumnType("text");

                entity.Property(e => e.EmoteOnComplete).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.EmoteOnIncomplete).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestRequestItemsLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_request_items_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ID");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.CompletionText).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild).HasColumnType("smallint(6)");
            });

            modelBuilder.Entity<QuestTemplate>(entity =>
            {
                entity.ToTable("quest_template");

                entity.HasComment("Quest System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AllowableRaces).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.AreaDescription).HasColumnType("text");

                entity.Property(e => e.Flags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemDrop1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemDrop2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemDrop3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemDrop4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ItemDropQuantity1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ItemDropQuantity2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ItemDropQuantity3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.ItemDropQuantity4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.LogDescription).HasColumnType("text");

                entity.Property(e => e.LogTitle).HasColumnType("text");

                entity.Property(e => e.MinLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ObjectiveText1).HasColumnType("text");

                entity.Property(e => e.ObjectiveText2).HasColumnType("text");

                entity.Property(e => e.ObjectiveText3).HasColumnType("text");

                entity.Property(e => e.ObjectiveText4).HasColumnType("text");

                entity.Property(e => e.Poicontinent)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("POIContinent");

                entity.Property(e => e.Poipriority)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("POIPriority")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Poix).HasColumnName("POIx");

                entity.Property(e => e.Poiy).HasColumnName("POIy");

                entity.Property(e => e.QuestCompletionLog).HasColumnType("text");

                entity.Property(e => e.QuestDescription).HasColumnType("text");

                entity.Property(e => e.QuestInfoId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("QuestInfoID");

                entity.Property(e => e.QuestLevel)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestSortId)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("QuestSortID");

                entity.Property(e => e.QuestType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.RequiredFactionId1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredFactionId2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredFactionValue1)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredFactionValue2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredItemCount1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredItemCount2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredItemCount3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredItemCount4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredItemCount5).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredItemCount6).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredItemId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredItemId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredItemId3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredItemId4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredItemId5)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredItemId6)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredNpcOrGo1)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredNpcOrGo2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredNpcOrGo3)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredNpcOrGo4)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredNpcOrGoCount1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredNpcOrGoCount2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredNpcOrGoCount3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredNpcOrGoCount4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredPlayerKills).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RewardAmount1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardAmount2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardAmount3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardAmount4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardArenaPoints).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardBonusMoney).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardChoiceItemId1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("RewardChoiceItemID1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardChoiceItemId2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("RewardChoiceItemID2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardChoiceItemId3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("RewardChoiceItemID3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardChoiceItemId4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("RewardChoiceItemID4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardChoiceItemId5)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("RewardChoiceItemID5")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardChoiceItemId6)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("RewardChoiceItemID6")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardChoiceItemQuantity1).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity2).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity3).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity4).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity5).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardChoiceItemQuantity6).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardDisplaySpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionId1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("RewardFactionID1")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewardFactionId2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("RewardFactionID2")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewardFactionId3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("RewardFactionID3")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewardFactionId4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("RewardFactionID4")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewardFactionId5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("RewardFactionID5")
                    .HasComment("faction id from Faction.dbc in this case");

                entity.Property(e => e.RewardFactionOverride1)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionOverride2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionOverride3)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionOverride4)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionOverride5)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionValue1)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionValue2)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionValue3)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionValue4)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardFactionValue5)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardHonor).HasColumnType("int(11)");

                entity.Property(e => e.RewardItem1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardItem2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardItem3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardItem4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardMoney).HasColumnType("int(11)");

                entity.Property(e => e.RewardMoneyDifficulty).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardNextQuest)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RewardSpell).HasColumnType("int(11)");

                entity.Property(e => e.RewardTalents).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RewardTitle).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RewardXpdifficulty)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("RewardXPDifficulty");

                entity.Property(e => e.StartItem)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SuggestedGroupNum).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TimeAllowed).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Unknown0).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QuestTemplateAddon>(entity =>
            {
                entity.ToTable("quest_template_addon");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AllowableClasses).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExclusiveGroup)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.MaxLevel).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.NextQuestId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("NextQuestID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.PrevQuestId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("PrevQuestID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ProvidedItemCount).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.RequiredMaxRepFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredMaxRepValue)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredMinRepFaction).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RequiredMinRepValue)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.RequiredSkillId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("RequiredSkillID");

                entity.Property(e => e.RequiredSkillPoints).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.RewardMailDelay).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RewardMailTemplateId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("RewardMailTemplateID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SourceSpellId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("SourceSpellID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpecialFlags).HasColumnType("tinyint(3) unsigned");
            });

            modelBuilder.Entity<QuestTemplateLocale>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Locale })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("quest_template_locale");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Locale)
                    .HasMaxLength(4)
                    .HasColumnName("locale");

                entity.Property(e => e.CompletedText).HasColumnType("text");

                entity.Property(e => e.Details).HasColumnType("text");

                entity.Property(e => e.EndText).HasColumnType("text");

                entity.Property(e => e.ObjectiveText1).HasColumnType("text");

                entity.Property(e => e.ObjectiveText2).HasColumnType("text");

                entity.Property(e => e.ObjectiveText3).HasColumnType("text");

                entity.Property(e => e.ObjectiveText4).HasColumnType("text");

                entity.Property(e => e.Objectives).HasColumnType("text");

                entity.Property(e => e.Title).HasColumnType("text");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<QuestfactionrewardDbc>(entity =>
            {
                entity.ToTable("questfactionreward_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Difficulty1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_1");

                entity.Property(e => e.Difficulty10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_10");

                entity.Property(e => e.Difficulty2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_2");

                entity.Property(e => e.Difficulty3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_3");

                entity.Property(e => e.Difficulty4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_4");

                entity.Property(e => e.Difficulty5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_5");

                entity.Property(e => e.Difficulty6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_6");

                entity.Property(e => e.Difficulty7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_7");

                entity.Property(e => e.Difficulty8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_8");

                entity.Property(e => e.Difficulty9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_9");
            });

            modelBuilder.Entity<QuestsortDbc>(entity =>
            {
                entity.ToTable("questsort_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.SortNameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_deDE");

                entity.Property(e => e.SortNameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_enCN");

                entity.Property(e => e.SortNameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_enGB");

                entity.Property(e => e.SortNameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_enTW");

                entity.Property(e => e.SortNameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_enUS");

                entity.Property(e => e.SortNameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_esES");

                entity.Property(e => e.SortNameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_esMX");

                entity.Property(e => e.SortNameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_frFR");

                entity.Property(e => e.SortNameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_itIT");

                entity.Property(e => e.SortNameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_koKR");

                entity.Property(e => e.SortNameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SortName_Lang_Mask");

                entity.Property(e => e.SortNameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_ptBR");

                entity.Property(e => e.SortNameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_ptPT");

                entity.Property(e => e.SortNameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_ruRU");

                entity.Property(e => e.SortNameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_Unk");

                entity.Property(e => e.SortNameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_zhCN");

                entity.Property(e => e.SortNameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("SortName_Lang_zhTW");
            });

            modelBuilder.Entity<QuestxpDbc>(entity =>
            {
                entity.ToTable("questxp_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Difficulty1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_1");

                entity.Property(e => e.Difficulty10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_10");

                entity.Property(e => e.Difficulty2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_2");

                entity.Property(e => e.Difficulty3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_3");

                entity.Property(e => e.Difficulty4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_4");

                entity.Property(e => e.Difficulty5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_5");

                entity.Property(e => e.Difficulty6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_6");

                entity.Property(e => e.Difficulty7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_7");

                entity.Property(e => e.Difficulty8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_8");

                entity.Property(e => e.Difficulty9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Difficulty_9");
            });

            modelBuilder.Entity<RandproppointsDbc>(entity =>
            {
                entity.ToTable("randproppoints_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Epic1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Epic_1");

                entity.Property(e => e.Epic2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Epic_2");

                entity.Property(e => e.Epic3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Epic_3");

                entity.Property(e => e.Epic4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Epic_4");

                entity.Property(e => e.Epic5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Epic_5");

                entity.Property(e => e.Good1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Good_1");

                entity.Property(e => e.Good2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Good_2");

                entity.Property(e => e.Good3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Good_3");

                entity.Property(e => e.Good4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Good_4");

                entity.Property(e => e.Good5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Good_5");

                entity.Property(e => e.Superior1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Superior_1");

                entity.Property(e => e.Superior2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Superior_2");

                entity.Property(e => e.Superior3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Superior_3");

                entity.Property(e => e.Superior4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Superior_4");

                entity.Property(e => e.Superior5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Superior_5");
            });

            modelBuilder.Entity<ReferenceLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("reference_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ReputationRewardRate>(entity =>
            {
                entity.HasKey(e => e.Faction)
                    .HasName("PRIMARY");

                entity.ToTable("reputation_reward_rate");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Faction)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("faction")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CreatureRate)
                    .HasColumnName("creature_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestDailyRate)
                    .HasColumnName("quest_daily_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestMonthlyRate)
                    .HasColumnName("quest_monthly_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRate)
                    .HasColumnName("quest_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRepeatableRate)
                    .HasColumnName("quest_repeatable_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestWeeklyRate)
                    .HasColumnName("quest_weekly_rate")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.SpellRate)
                    .HasColumnName("spell_rate")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<ReputationSpilloverTemplate>(entity =>
            {
                entity.HasKey(e => e.Faction)
                    .HasName("PRIMARY");

                entity.ToTable("reputation_spillover_template");

                entity.HasComment("Reputation spillover reputation gain")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Faction)
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("faction")
                    .HasComment("faction entry");

                entity.Property(e => e.Faction1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction1")
                    .HasComment("faction to give spillover for");

                entity.Property(e => e.Faction2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction2");

                entity.Property(e => e.Faction3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction3");

                entity.Property(e => e.Faction4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction4");

                entity.Property(e => e.Rank1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank_1")
                    .HasComment("max rank,above this will not give any spillover");

                entity.Property(e => e.Rank2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank_2");

                entity.Property(e => e.Rank3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank_3");

                entity.Property(e => e.Rank4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank_4");

                entity.Property(e => e.Rate1)
                    .HasColumnName("rate_1")
                    .HasComment("the given rep points * rate");

                entity.Property(e => e.Rate2).HasColumnName("rate_2");

                entity.Property(e => e.Rate3).HasColumnName("rate_3");

                entity.Property(e => e.Rate4).HasColumnName("rate_4");
            });

            modelBuilder.Entity<ScalingstatdistributionDbc>(entity =>
            {
                entity.ToTable("scalingstatdistribution_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Bonus1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_1");

                entity.Property(e => e.Bonus10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_10");

                entity.Property(e => e.Bonus2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_2");

                entity.Property(e => e.Bonus3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_3");

                entity.Property(e => e.Bonus4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_4");

                entity.Property(e => e.Bonus5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_5");

                entity.Property(e => e.Bonus6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_6");

                entity.Property(e => e.Bonus7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_7");

                entity.Property(e => e.Bonus8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_8");

                entity.Property(e => e.Bonus9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Bonus_9");

                entity.Property(e => e.Maxlevel).HasColumnType("int(11)");

                entity.Property(e => e.StatId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_1");

                entity.Property(e => e.StatId10)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_10");

                entity.Property(e => e.StatId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_2");

                entity.Property(e => e.StatId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_3");

                entity.Property(e => e.StatId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_4");

                entity.Property(e => e.StatId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_5");

                entity.Property(e => e.StatId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_6");

                entity.Property(e => e.StatId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_7");

                entity.Property(e => e.StatId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_8");

                entity.Property(e => e.StatId9)
                    .HasColumnType("int(11)")
                    .HasColumnName("StatID_9");
            });

            modelBuilder.Entity<ScalingstatvaluesDbc>(entity =>
            {
                entity.ToTable("scalingstatvalues_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Charlevel).HasColumnType("int(11)");

                entity.Property(e => e.ClothChestArmor).HasColumnType("int(11)");

                entity.Property(e => e.ClothCloakArmor).HasColumnType("int(11)");

                entity.Property(e => e.ClothShoulderArmor).HasColumnType("int(11)");

                entity.Property(e => e.LeatherChestArmor).HasColumnType("int(11)");

                entity.Property(e => e.LeatherShoulderArmor).HasColumnType("int(11)");

                entity.Property(e => e.MailChestArmor).HasColumnType("int(11)");

                entity.Property(e => e.MailShoulderArmor).HasColumnType("int(11)");

                entity.Property(e => e.PlateChestArmor).HasColumnType("int(11)");

                entity.Property(e => e.PlateShoulderArmor).HasColumnType("int(11)");

                entity.Property(e => e.PrimaryBudget).HasColumnType("int(11)");

                entity.Property(e => e.RangedBudget).HasColumnType("int(11)");

                entity.Property(e => e.RangedDps)
                    .HasColumnType("int(11)")
                    .HasColumnName("RangedDPS");

                entity.Property(e => e.ShoulderBudget).HasColumnType("int(11)");

                entity.Property(e => e.SpellPower).HasColumnType("int(11)");

                entity.Property(e => e.SpellcasterDps1h)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellcasterDPS1H");

                entity.Property(e => e.SpellcasterDps2h)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellcasterDPS2H");

                entity.Property(e => e.TertiaryBudget).HasColumnType("int(11)");

                entity.Property(e => e.TrinketBudget).HasColumnType("int(11)");

                entity.Property(e => e.WandDps)
                    .HasColumnType("int(11)")
                    .HasColumnName("WandDPS");

                entity.Property(e => e.WeaponBudget1H).HasColumnType("int(11)");

                entity.Property(e => e.WeaponDps1h)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponDPS1H");

                entity.Property(e => e.WeaponDps2h)
                    .HasColumnType("int(11)")
                    .HasColumnName("WeaponDPS2H");
            });

            modelBuilder.Entity<ScriptWaypoint>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Pointid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("script_waypoint");

                entity.HasComment("Script Creature waypoints")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("creature_template entry");

                entity.Property(e => e.Pointid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pointid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.LocationX).HasColumnName("location_x");

                entity.Property(e => e.LocationY).HasColumnName("location_y");

                entity.Property(e => e.LocationZ).HasColumnName("location_z");

                entity.Property(e => e.PointComment)
                    .HasColumnType("text")
                    .HasColumnName("point_comment");

                entity.Property(e => e.Waittime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("waittime")
                    .HasComment("waittime in millisecs");
            });

            modelBuilder.Entity<SkillDiscoveryTemplate>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.ReqSpell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("skill_discovery_template");

                entity.HasComment("Skill Discovery System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellId")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellId of the discoverable spell");

                entity.Property(e => e.ReqSpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("reqSpell")
                    .HasDefaultValueSql("'0'")
                    .HasComment("spell requirement");

                entity.Property(e => e.Chance)
                    .HasColumnName("chance")
                    .HasComment("chance to discover");

                entity.Property(e => e.ReqSkillValue)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("reqSkillValue")
                    .HasComment("skill points requirement");
            });

            modelBuilder.Entity<SkillExtraItemTemplate>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("skill_extra_item_template");

                entity.HasComment("Skill Specialization System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellId")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellId of the item creation spell");

                entity.Property(e => e.AdditionalCreateChance)
                    .HasColumnName("additionalCreateChance")
                    .HasComment("chance to create add");

                entity.Property(e => e.AdditionalMaxNum)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("additionalMaxNum");

                entity.Property(e => e.RequiredSpecialization)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("requiredSpecialization")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Specialization spell id");
            });

            modelBuilder.Entity<SkillFishingBaseLevel>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("skill_fishing_base_level");

                entity.HasComment("Fishing system")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Area identifier");

                entity.Property(e => e.Skill)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("skill")
                    .HasComment("Base skill level requirement");
            });

            modelBuilder.Entity<SkillPerfectItemTemplate>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("skill_perfect_item_template");

                entity.HasComment("Crafting Perfection System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spellId")
                    .HasDefaultValueSql("'0'")
                    .HasComment("SpellId of the item creation spell");

                entity.Property(e => e.PerfectCreateChance)
                    .HasColumnName("perfectCreateChance")
                    .HasComment("chance to create the perfect item instead");

                entity.Property(e => e.PerfectItemType)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("perfectItemType")
                    .HasDefaultValueSql("'0'")
                    .HasComment("perfect item type to create instead");

                entity.Property(e => e.RequiredSpecialization)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("requiredSpecialization")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Specialization spell id");
            });

            modelBuilder.Entity<SkilllineDbc>(entity =>
            {
                entity.ToTable("skillline_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AlternateVerbLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_deDE");

                entity.Property(e => e.AlternateVerbLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_enCN");

                entity.Property(e => e.AlternateVerbLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_enGB");

                entity.Property(e => e.AlternateVerbLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_enTW");

                entity.Property(e => e.AlternateVerbLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_enUS");

                entity.Property(e => e.AlternateVerbLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_esES");

                entity.Property(e => e.AlternateVerbLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_esMX");

                entity.Property(e => e.AlternateVerbLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_frFR");

                entity.Property(e => e.AlternateVerbLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_itIT");

                entity.Property(e => e.AlternateVerbLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_koKR");

                entity.Property(e => e.AlternateVerbLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("AlternateVerb_Lang_Mask");

                entity.Property(e => e.AlternateVerbLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_ptBR");

                entity.Property(e => e.AlternateVerbLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_ptPT");

                entity.Property(e => e.AlternateVerbLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_ruRU");

                entity.Property(e => e.AlternateVerbLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_Unk");

                entity.Property(e => e.AlternateVerbLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_zhCN");

                entity.Property(e => e.AlternateVerbLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("AlternateVerb_Lang_zhTW");

                entity.Property(e => e.CanLink).HasColumnType("int(11)");

                entity.Property(e => e.CategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryID");

                entity.Property(e => e.DescriptionLangDeDe)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_deDE");

                entity.Property(e => e.DescriptionLangEnCn)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_enCN");

                entity.Property(e => e.DescriptionLangEnGb)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_enGB");

                entity.Property(e => e.DescriptionLangEnTw)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_enTW");

                entity.Property(e => e.DescriptionLangEnUs)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_enUS");

                entity.Property(e => e.DescriptionLangEsEs)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_esES");

                entity.Property(e => e.DescriptionLangEsMx)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_esMX");

                entity.Property(e => e.DescriptionLangFrFr)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_frFR");

                entity.Property(e => e.DescriptionLangItIt)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_itIT");

                entity.Property(e => e.DescriptionLangKoKr)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_koKR");

                entity.Property(e => e.DescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Description_Lang_Mask");

                entity.Property(e => e.DescriptionLangPtBr)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_ptBR");

                entity.Property(e => e.DescriptionLangPtPt)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_ptPT");

                entity.Property(e => e.DescriptionLangRuRu)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_ruRU");

                entity.Property(e => e.DescriptionLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Description_Lang_Unk");

                entity.Property(e => e.DescriptionLangZhCn)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_zhCN");

                entity.Property(e => e.DescriptionLangZhTw)
                    .HasMaxLength(300)
                    .HasColumnName("Description_Lang_zhTW");

                entity.Property(e => e.DisplayNameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_deDE");

                entity.Property(e => e.DisplayNameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_enCN");

                entity.Property(e => e.DisplayNameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_enGB");

                entity.Property(e => e.DisplayNameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_enTW");

                entity.Property(e => e.DisplayNameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_enUS");

                entity.Property(e => e.DisplayNameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_esES");

                entity.Property(e => e.DisplayNameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_esMX");

                entity.Property(e => e.DisplayNameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_frFR");

                entity.Property(e => e.DisplayNameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_itIT");

                entity.Property(e => e.DisplayNameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_koKR");

                entity.Property(e => e.DisplayNameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("DisplayName_Lang_Mask");

                entity.Property(e => e.DisplayNameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_ptBR");

                entity.Property(e => e.DisplayNameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_ptPT");

                entity.Property(e => e.DisplayNameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_ruRU");

                entity.Property(e => e.DisplayNameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_Unk");

                entity.Property(e => e.DisplayNameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_zhCN");

                entity.Property(e => e.DisplayNameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("DisplayName_Lang_zhTW");

                entity.Property(e => e.SkillCostsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SkillCostsID");

                entity.Property(e => e.SpellIconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellIconID");
            });

            modelBuilder.Entity<SkilllineabilityDbc>(entity =>
            {
                entity.ToTable("skilllineability_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AcquireMethod).HasColumnType("int(11)");

                entity.Property(e => e.CharacterPoints1)
                    .HasColumnType("int(11)")
                    .HasColumnName("CharacterPoints_1");

                entity.Property(e => e.CharacterPoints2)
                    .HasColumnType("int(11)")
                    .HasColumnName("CharacterPoints_2");

                entity.Property(e => e.ClassMask).HasColumnType("int(11)");

                entity.Property(e => e.MinSkillLineRank).HasColumnType("int(11)");

                entity.Property(e => e.RaceMask).HasColumnType("int(11)");

                entity.Property(e => e.SkillLine).HasColumnType("int(11)");

                entity.Property(e => e.Spell).HasColumnType("int(11)");

                entity.Property(e => e.SupercededBySpell).HasColumnType("int(11)");

                entity.Property(e => e.TradeSkillCategoryId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TradeSkillCategoryID");

                entity.Property(e => e.TrivialSkillLineRankHigh).HasColumnType("int(11)");

                entity.Property(e => e.TrivialSkillLineRankLow).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SkillraceclassinfoDbc>(entity =>
            {
                entity.ToTable("skillraceclassinfo_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ClassMask).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.MinLevel).HasColumnType("int(11)");

                entity.Property(e => e.RaceMask).HasColumnType("int(11)");

                entity.Property(e => e.SkillCostIndex).HasColumnType("int(11)");

                entity.Property(e => e.SkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SkillID");

                entity.Property(e => e.SkillTierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SkillTierID");
            });

            modelBuilder.Entity<SkilltiersDbc>(entity =>
            {
                entity.ToTable("skilltiers_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Cost1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_1");

                entity.Property(e => e.Cost10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_10");

                entity.Property(e => e.Cost11)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_11");

                entity.Property(e => e.Cost12)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_12");

                entity.Property(e => e.Cost13)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_13");

                entity.Property(e => e.Cost14)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_14");

                entity.Property(e => e.Cost15)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_15");

                entity.Property(e => e.Cost16)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_16");

                entity.Property(e => e.Cost2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_2");

                entity.Property(e => e.Cost3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_3");

                entity.Property(e => e.Cost4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_4");

                entity.Property(e => e.Cost5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_5");

                entity.Property(e => e.Cost6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_6");

                entity.Property(e => e.Cost7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_7");

                entity.Property(e => e.Cost8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_8");

                entity.Property(e => e.Cost9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Cost_9");

                entity.Property(e => e.Value1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_1");

                entity.Property(e => e.Value10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_10");

                entity.Property(e => e.Value11)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_11");

                entity.Property(e => e.Value12)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_12");

                entity.Property(e => e.Value13)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_13");

                entity.Property(e => e.Value14)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_14");

                entity.Property(e => e.Value15)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_15");

                entity.Property(e => e.Value16)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_16");

                entity.Property(e => e.Value2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_2");

                entity.Property(e => e.Value3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_3");

                entity.Property(e => e.Value4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_4");

                entity.Property(e => e.Value5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_5");

                entity.Property(e => e.Value6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_6");

                entity.Property(e => e.Value7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_7");

                entity.Property(e => e.Value8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_8");

                entity.Property(e => e.Value9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Value_9");
            });

            modelBuilder.Entity<SkinningLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("skinning_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SmartScript>(entity =>
            {
                entity.HasKey(e => new { e.Entryorguid, e.SourceType, e.Id, e.Link })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("smart_scripts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entryorguid)
                    .HasColumnType("int(11)")
                    .HasColumnName("entryorguid");

                entity.Property(e => e.SourceType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("source_type");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Link)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("link");

                entity.Property(e => e.ActionParam1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_param1");

                entity.Property(e => e.ActionParam2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_param2");

                entity.Property(e => e.ActionParam3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_param3");

                entity.Property(e => e.ActionParam4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_param4");

                entity.Property(e => e.ActionParam5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_param5");

                entity.Property(e => e.ActionParam6)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action_param6");

                entity.Property(e => e.ActionType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("action_type");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasComment("Event Comment");

                entity.Property(e => e.EventChance)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event_chance")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.EventFlags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("event_flags");

                entity.Property(e => e.EventParam1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("event_param1");

                entity.Property(e => e.EventParam2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("event_param2");

                entity.Property(e => e.EventParam3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("event_param3");

                entity.Property(e => e.EventParam4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("event_param4");

                entity.Property(e => e.EventParam5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("event_param5");

                entity.Property(e => e.EventPhaseMask)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("event_phase_mask");

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("event_type");

                entity.Property(e => e.TargetO).HasColumnName("target_o");

                entity.Property(e => e.TargetParam1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("target_param1");

                entity.Property(e => e.TargetParam2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("target_param2");

                entity.Property(e => e.TargetParam3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("target_param3");

                entity.Property(e => e.TargetParam4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("target_param4");

                entity.Property(e => e.TargetType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("target_type");

                entity.Property(e => e.TargetX).HasColumnName("target_x");

                entity.Property(e => e.TargetY).HasColumnName("target_y");

                entity.Property(e => e.TargetZ).HasColumnName("target_z");
            });

            modelBuilder.Entity<SoundentriesDbc>(entity =>
            {
                entity.ToTable("soundentries_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DirectoryBase).HasMaxLength(100);

                entity.Property(e => e.Eaxdef)
                    .HasColumnType("int(11)")
                    .HasColumnName("EAXDef");

                entity.Property(e => e.File1)
                    .HasMaxLength(100)
                    .HasColumnName("File_1");

                entity.Property(e => e.File10)
                    .HasMaxLength(100)
                    .HasColumnName("File_10");

                entity.Property(e => e.File2)
                    .HasMaxLength(100)
                    .HasColumnName("File_2");

                entity.Property(e => e.File3)
                    .HasMaxLength(100)
                    .HasColumnName("File_3");

                entity.Property(e => e.File4)
                    .HasMaxLength(100)
                    .HasColumnName("File_4");

                entity.Property(e => e.File5)
                    .HasMaxLength(100)
                    .HasColumnName("File_5");

                entity.Property(e => e.File6)
                    .HasMaxLength(100)
                    .HasColumnName("File_6");

                entity.Property(e => e.File7)
                    .HasMaxLength(100)
                    .HasColumnName("File_7");

                entity.Property(e => e.File8)
                    .HasMaxLength(100)
                    .HasColumnName("File_8");

                entity.Property(e => e.File9)
                    .HasMaxLength(100)
                    .HasColumnName("File_9");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Freq1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_1");

                entity.Property(e => e.Freq10)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_10");

                entity.Property(e => e.Freq2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_2");

                entity.Property(e => e.Freq3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_3");

                entity.Property(e => e.Freq4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_4");

                entity.Property(e => e.Freq5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_5");

                entity.Property(e => e.Freq6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_6");

                entity.Property(e => e.Freq7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_7");

                entity.Property(e => e.Freq8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_8");

                entity.Property(e => e.Freq9)
                    .HasColumnType("int(11)")
                    .HasColumnName("Freq_9");

                entity.Property(e => e.Name).HasMaxLength(100);

                entity.Property(e => e.SoundEntriesAdvancedId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SoundEntriesAdvancedID");

                entity.Property(e => e.SoundType).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SpellArea>(entity =>
            {
                entity.HasKey(e => new { e.Spell, e.Area, e.QuestStart, e.AuraSpell, e.Racemask, e.Gender })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0, 0 });

                entity.ToTable("spell_area");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Area)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("area")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestStart)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest_start")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AuraSpell)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("aura_spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Racemask)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("racemask")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gender")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Autocast)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("autocast");

                entity.Property(e => e.QuestEnd)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("quest_end")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestEndStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("quest_end_status")
                    .HasDefaultValueSql("'11'");

                entity.Property(e => e.QuestStartStatus)
                    .HasColumnType("int(11)")
                    .HasColumnName("quest_start_status")
                    .HasDefaultValueSql("'64'");
            });

            modelBuilder.Entity<SpellBonusDatum>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_bonus_data");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ApBonus).HasColumnName("ap_bonus");

                entity.Property(e => e.ApDotBonus).HasColumnName("ap_dot_bonus");

                entity.Property(e => e.Comments)
                    .HasMaxLength(255)
                    .HasColumnName("comments");

                entity.Property(e => e.DirectBonus).HasColumnName("direct_bonus");

                entity.Property(e => e.DotBonus).HasColumnName("dot_bonus");
            });

            modelBuilder.Entity<SpellCustomAttr>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("spell_custom_attr");

                entity.HasComment("SpellInfo custom attributes")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell_id")
                    .HasDefaultValueSql("'0'")
                    .HasComment("spell id");

                entity.Property(e => e.Attributes)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("attributes")
                    .HasComment("SpellCustomAttributes");
            });

            modelBuilder.Entity<SpellDbc>(entity =>
            {
                entity.ToTable("spell_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ActiveIconId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ActiveIconID");

                entity.Property(e => e.Attributes).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx3).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx4).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx5).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx6).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AttributesEx7).HasColumnType("int(10) unsigned");

                entity.Property(e => e.AuraDescriptionLangDeDe)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_deDE");

                entity.Property(e => e.AuraDescriptionLangEnCn)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_enCN");

                entity.Property(e => e.AuraDescriptionLangEnGb)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_enGB");

                entity.Property(e => e.AuraDescriptionLangEnTw)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_enTW");

                entity.Property(e => e.AuraDescriptionLangEnUs)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_enUS");

                entity.Property(e => e.AuraDescriptionLangEsEs)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_esES");

                entity.Property(e => e.AuraDescriptionLangEsMx)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_esMX");

                entity.Property(e => e.AuraDescriptionLangFrFr)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_frFR");

                entity.Property(e => e.AuraDescriptionLangItIt)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_itIT");

                entity.Property(e => e.AuraDescriptionLangKoKr)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_koKR");

                entity.Property(e => e.AuraDescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("AuraDescription_Lang_Mask");

                entity.Property(e => e.AuraDescriptionLangPtBr)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_ptBR");

                entity.Property(e => e.AuraDescriptionLangPtPt)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_ptPT");

                entity.Property(e => e.AuraDescriptionLangRuRu)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_ruRU");

                entity.Property(e => e.AuraDescriptionLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("AuraDescription_Lang_Unk");

                entity.Property(e => e.AuraDescriptionLangZhCn)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_zhCN");

                entity.Property(e => e.AuraDescriptionLangZhTw)
                    .HasMaxLength(550)
                    .HasColumnName("AuraDescription_Lang_zhTW");

                entity.Property(e => e.AuraInterruptFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.BaseLevel).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CasterAuraSpell).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CasterAuraState).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CastingTimeIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Category).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CategoryRecoveryTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ChannelInterruptFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.CumulativeAura).HasColumnType("int(10) unsigned");

                entity.Property(e => e.DefenseType).HasColumnType("int(10) unsigned");

                entity.Property(e => e.DescriptionLangDeDe)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_deDE");

                entity.Property(e => e.DescriptionLangEnCn)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_enCN");

                entity.Property(e => e.DescriptionLangEnGb)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_enGB");

                entity.Property(e => e.DescriptionLangEnTw)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_enTW");

                entity.Property(e => e.DescriptionLangEnUs)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_enUS");

                entity.Property(e => e.DescriptionLangEsEs)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_esES");

                entity.Property(e => e.DescriptionLangEsMx)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_esMX");

                entity.Property(e => e.DescriptionLangFrFr)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_frFR");

                entity.Property(e => e.DescriptionLangItIt)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_itIT");

                entity.Property(e => e.DescriptionLangKoKr)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_koKR");

                entity.Property(e => e.DescriptionLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Description_Lang_Mask");

                entity.Property(e => e.DescriptionLangPtBr)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_ptBR");

                entity.Property(e => e.DescriptionLangPtPt)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_ptPT");

                entity.Property(e => e.DescriptionLangRuRu)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_ruRU");

                entity.Property(e => e.DescriptionLangUnk)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_Unk");

                entity.Property(e => e.DescriptionLangZhCn)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_zhCN");

                entity.Property(e => e.DescriptionLangZhTw)
                    .HasColumnType("tinytext")
                    .HasColumnName("Description_Lang_zhTW");

                entity.Property(e => e.DispelType).HasColumnType("int(10) unsigned");

                entity.Property(e => e.DurationIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Effect1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Effect_1");

                entity.Property(e => e.Effect2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Effect_2");

                entity.Property(e => e.Effect3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Effect_3");

                entity.Property(e => e.EffectAura1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectAura_1");

                entity.Property(e => e.EffectAura2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectAura_2");

                entity.Property(e => e.EffectAura3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectAura_3");

                entity.Property(e => e.EffectAuraPeriod1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectAuraPeriod_1");

                entity.Property(e => e.EffectAuraPeriod2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectAuraPeriod_2");

                entity.Property(e => e.EffectAuraPeriod3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectAuraPeriod_3");

                entity.Property(e => e.EffectBasePoints1)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectBasePoints_1");

                entity.Property(e => e.EffectBasePoints2)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectBasePoints_2");

                entity.Property(e => e.EffectBasePoints3)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectBasePoints_3");

                entity.Property(e => e.EffectChainAmplitude1).HasColumnName("EffectChainAmplitude_1");

                entity.Property(e => e.EffectChainAmplitude2).HasColumnName("EffectChainAmplitude_2");

                entity.Property(e => e.EffectChainAmplitude3).HasColumnName("EffectChainAmplitude_3");

                entity.Property(e => e.EffectChainTargets1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectChainTargets_1");

                entity.Property(e => e.EffectChainTargets2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectChainTargets_2");

                entity.Property(e => e.EffectChainTargets3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectChainTargets_3");

                entity.Property(e => e.EffectDieSides1)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectDieSides_1");

                entity.Property(e => e.EffectDieSides2)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectDieSides_2");

                entity.Property(e => e.EffectDieSides3)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectDieSides_3");

                entity.Property(e => e.EffectItemType1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectItemType_1");

                entity.Property(e => e.EffectItemType2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectItemType_2");

                entity.Property(e => e.EffectItemType3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectItemType_3");

                entity.Property(e => e.EffectMechanic1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectMechanic_1");

                entity.Property(e => e.EffectMechanic2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectMechanic_2");

                entity.Property(e => e.EffectMechanic3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectMechanic_3");

                entity.Property(e => e.EffectMiscValue1)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectMiscValue_1");

                entity.Property(e => e.EffectMiscValue2)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectMiscValue_2");

                entity.Property(e => e.EffectMiscValue3)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectMiscValue_3");

                entity.Property(e => e.EffectMiscValueB1)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectMiscValueB_1");

                entity.Property(e => e.EffectMiscValueB2)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectMiscValueB_2");

                entity.Property(e => e.EffectMiscValueB3)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectMiscValueB_3");

                entity.Property(e => e.EffectMultipleValue1).HasColumnName("EffectMultipleValue_1");

                entity.Property(e => e.EffectMultipleValue2).HasColumnName("EffectMultipleValue_2");

                entity.Property(e => e.EffectMultipleValue3).HasColumnName("EffectMultipleValue_3");

                entity.Property(e => e.EffectPointsPerCombo1).HasColumnName("EffectPointsPerCombo_1");

                entity.Property(e => e.EffectPointsPerCombo2).HasColumnName("EffectPointsPerCombo_2");

                entity.Property(e => e.EffectPointsPerCombo3).HasColumnName("EffectPointsPerCombo_3");

                entity.Property(e => e.EffectRadiusIndex1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectRadiusIndex_1");

                entity.Property(e => e.EffectRadiusIndex2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectRadiusIndex_2");

                entity.Property(e => e.EffectRadiusIndex3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectRadiusIndex_3");

                entity.Property(e => e.EffectRealPointsPerLevel1).HasColumnName("EffectRealPointsPerLevel_1");

                entity.Property(e => e.EffectRealPointsPerLevel2).HasColumnName("EffectRealPointsPerLevel_2");

                entity.Property(e => e.EffectRealPointsPerLevel3).HasColumnName("EffectRealPointsPerLevel_3");

                entity.Property(e => e.EffectSpellClassMaskA1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskA_1");

                entity.Property(e => e.EffectSpellClassMaskA2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskA_2");

                entity.Property(e => e.EffectSpellClassMaskA3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskA_3");

                entity.Property(e => e.EffectSpellClassMaskB1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskB_1");

                entity.Property(e => e.EffectSpellClassMaskB2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskB_2");

                entity.Property(e => e.EffectSpellClassMaskB3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskB_3");

                entity.Property(e => e.EffectSpellClassMaskC1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskC_1");

                entity.Property(e => e.EffectSpellClassMaskC2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskC_2");

                entity.Property(e => e.EffectSpellClassMaskC3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectSpellClassMaskC_3");

                entity.Property(e => e.EffectTriggerSpell1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectTriggerSpell_1");

                entity.Property(e => e.EffectTriggerSpell2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectTriggerSpell_2");

                entity.Property(e => e.EffectTriggerSpell3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("EffectTriggerSpell_3");

                entity.Property(e => e.EquippedItemClass).HasColumnType("int(11)");

                entity.Property(e => e.EquippedItemInvTypes).HasColumnType("int(11)");

                entity.Property(e => e.EquippedItemSubclass).HasColumnType("int(11)");

                entity.Property(e => e.ExcludeCasterAuraSpell).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExcludeCasterAuraState).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExcludeTargetAuraSpell).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ExcludeTargetAuraState).HasColumnType("int(10) unsigned");

                entity.Property(e => e.FacingCasterFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ImplicitTargetA1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ImplicitTargetA_1");

                entity.Property(e => e.ImplicitTargetA2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ImplicitTargetA_2");

                entity.Property(e => e.ImplicitTargetA3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ImplicitTargetA_3");

                entity.Property(e => e.ImplicitTargetB1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ImplicitTargetB_1");

                entity.Property(e => e.ImplicitTargetB2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ImplicitTargetB_2");

                entity.Property(e => e.ImplicitTargetB3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ImplicitTargetB_3");

                entity.Property(e => e.InterruptFlags).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ManaCost).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ManaCostPct).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ManaCostPerLevel).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ManaPerSecond).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ManaPerSecondPerLevel).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MaxLevel).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MaxTargetLevel).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MaxTargets).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Mechanic).HasColumnType("int(10) unsigned");

                entity.Property(e => e.MinFactionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("MinFactionID");

                entity.Property(e => e.MinReputation).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ModalNextSpell).HasColumnType("int(10) unsigned");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.NameSubtextLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_deDE");

                entity.Property(e => e.NameSubtextLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_enCN");

                entity.Property(e => e.NameSubtextLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_enGB");

                entity.Property(e => e.NameSubtextLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_enTW");

                entity.Property(e => e.NameSubtextLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_enUS");

                entity.Property(e => e.NameSubtextLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_esES");

                entity.Property(e => e.NameSubtextLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_esMX");

                entity.Property(e => e.NameSubtextLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_frFR");

                entity.Property(e => e.NameSubtextLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_itIT");

                entity.Property(e => e.NameSubtextLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_koKR");

                entity.Property(e => e.NameSubtextLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("NameSubtext_Lang_Mask");

                entity.Property(e => e.NameSubtextLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_ptBR");

                entity.Property(e => e.NameSubtextLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_ptPT");

                entity.Property(e => e.NameSubtextLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_ruRU");

                entity.Property(e => e.NameSubtextLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_Unk");

                entity.Property(e => e.NameSubtextLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_zhCN");

                entity.Property(e => e.NameSubtextLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("NameSubtext_Lang_zhTW");

                entity.Property(e => e.PowerDisplayId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PowerDisplayID");

                entity.Property(e => e.PowerType).HasColumnType("int(11)");

                entity.Property(e => e.PreventionType).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ProcChance).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ProcCharges).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ProcTypeMask).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RangeIndex).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Reagent1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Reagent_1");

                entity.Property(e => e.Reagent2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Reagent_2");

                entity.Property(e => e.Reagent3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Reagent_3");

                entity.Property(e => e.Reagent4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Reagent_4");

                entity.Property(e => e.Reagent5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Reagent_5");

                entity.Property(e => e.Reagent6)
                    .HasColumnType("int(11)")
                    .HasColumnName("Reagent_6");

                entity.Property(e => e.Reagent7)
                    .HasColumnType("int(11)")
                    .HasColumnName("Reagent_7");

                entity.Property(e => e.Reagent8)
                    .HasColumnType("int(11)")
                    .HasColumnName("Reagent_8");

                entity.Property(e => e.ReagentCount1)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReagentCount_1");

                entity.Property(e => e.ReagentCount2)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReagentCount_2");

                entity.Property(e => e.ReagentCount3)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReagentCount_3");

                entity.Property(e => e.ReagentCount4)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReagentCount_4");

                entity.Property(e => e.ReagentCount5)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReagentCount_5");

                entity.Property(e => e.ReagentCount6)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReagentCount_6");

                entity.Property(e => e.ReagentCount7)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReagentCount_7");

                entity.Property(e => e.ReagentCount8)
                    .HasColumnType("int(11)")
                    .HasColumnName("ReagentCount_8");

                entity.Property(e => e.RecoveryTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RequiredAreasId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RequiredAreasID");

                entity.Property(e => e.RequiredAuraVision).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RequiredTotemCategoryId1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("RequiredTotemCategoryID_1");

                entity.Property(e => e.RequiredTotemCategoryId2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("RequiredTotemCategoryID_2");

                entity.Property(e => e.RequiresSpellFocus).HasColumnType("int(10) unsigned");

                entity.Property(e => e.RuneCostId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("RuneCostID");

                entity.Property(e => e.SchoolMask).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ShapeshiftExclude).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.ShapeshiftMask).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.SpellClassMask1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellClassMask_1");

                entity.Property(e => e.SpellClassMask2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellClassMask_2");

                entity.Property(e => e.SpellClassMask3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellClassMask_3");

                entity.Property(e => e.SpellClassSet).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellDescriptionVariableId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellDescriptionVariableID");

                entity.Property(e => e.SpellDifficultyId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellDifficultyID");

                entity.Property(e => e.SpellIconId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellIconID");

                entity.Property(e => e.SpellLevel).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellMissileId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellMissileID");

                entity.Property(e => e.SpellPriority).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellVisualId1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellVisualID_1");

                entity.Property(e => e.SpellVisualId2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("SpellVisualID_2");

                entity.Property(e => e.StanceBarOrder).HasColumnType("int(10) unsigned");

                entity.Property(e => e.StartRecoveryCategory).HasColumnType("int(10) unsigned");

                entity.Property(e => e.StartRecoveryTime).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TargetAuraSpell).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TargetAuraState).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TargetCreatureType).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Targets).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Totem1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Totem_1");

                entity.Property(e => e.Totem2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Totem_2");

                entity.Property(e => e.Unk3202)
                    .HasColumnType("int(11)")
                    .HasColumnName("unk_320_2");

                entity.Property(e => e.Unk3203)
                    .HasColumnType("int(11)")
                    .HasColumnName("unk_320_3");
            });

            modelBuilder.Entity<SpellEnchantProcDatum>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_enchant_proc_data");

                entity.HasComment("Spell enchant proc data")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.CustomChance)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("customChance");

                entity.Property(e => e.Ppmchance).HasColumnName("PPMChance");

                entity.Property(e => e.ProcEx)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("procEx");
            });

            modelBuilder.Entity<SpellGroup>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.SpellId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_group");

                entity.HasComment("Spell System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spell_id");

                entity.Property(e => e.SpecialFlag)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("special_flag");
            });

            modelBuilder.Entity<SpellGroupStackRule>(entity =>
            {
                entity.HasKey(e => e.GroupId)
                    .HasName("PRIMARY");

                entity.ToTable("spell_group_stack_rules");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.GroupId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("group_id");

                entity.Property(e => e.Description)
                    .HasMaxLength(150)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.StackRule)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("stack_rule");
            });

            modelBuilder.Entity<SpellLinkedSpell>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spell_linked_spell");

                entity.HasComment("Spell System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.SpellTrigger, e.SpellEffect, e.Type }, "trigger_effect_type")
                    .IsUnique();

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.SpellEffect)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spell_effect")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SpellTrigger)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spell_trigger");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<SpellLootTemplate>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Item })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_loot_template");

                entity.HasComment("Loot System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Chance).HasDefaultValueSql("'100'");

                entity.Property(e => e.Comment).HasMaxLength(255);

                entity.Property(e => e.GroupId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.LootMode)
                    .HasColumnType("smallint(5) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MaxCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.MinCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.QuestRequired).HasColumnType("tinyint(4)");

                entity.Property(e => e.Reference)
                    .HasColumnType("mediumint(9)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SpellMixology>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_mixology");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.PctMod)
                    .HasColumnName("pctMod")
                    .HasDefaultValueSql("'30'")
                    .HasComment("bonus multiplier");
            });

            modelBuilder.Entity<SpellPetAura>(entity =>
            {
                entity.HasKey(e => new { e.Spell, e.EffectId, e.Pet })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("spell_pet_auras");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasComment("dummy spell id");

                entity.Property(e => e.EffectId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("effectId");

                entity.Property(e => e.Pet)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pet")
                    .HasDefaultValueSql("'0'")
                    .HasComment("pet id; 0 = all");

                entity.Property(e => e.Aura)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("aura")
                    .HasComment("pet aura id");
            });

            modelBuilder.Entity<SpellProc>(entity =>
            {
                entity.HasKey(e => e.SpellId)
                    .HasName("PRIMARY");

                entity.ToTable("spell_proc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spellId")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.AttributesMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("attributesMask");

                entity.Property(e => e.Chance).HasColumnName("chance");

                entity.Property(e => e.Charges)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("charges");

                entity.Property(e => e.Cooldown).HasColumnName("cooldown");

                entity.Property(e => e.HitMask)
                    .HasColumnType("int(11)")
                    .HasColumnName("hitMask");

                entity.Property(e => e.RatePerMinute).HasColumnName("ratePerMinute");

                entity.Property(e => e.SchoolMask)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("schoolMask");

                entity.Property(e => e.SpellFamilyMask0)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spellFamilyMask0");

                entity.Property(e => e.SpellFamilyMask1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spellFamilyMask1");

                entity.Property(e => e.SpellFamilyMask2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spellFamilyMask2");

                entity.Property(e => e.SpellFamilyName)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("spellFamilyName");

                entity.Property(e => e.SpellPhaseMask)
                    .HasColumnType("int(11)")
                    .HasColumnName("spellPhaseMask");

                entity.Property(e => e.SpellTypeMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spellTypeMask");

                entity.Property(e => e.TypeMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("typeMask");
            });

            modelBuilder.Entity<SpellProcEvent>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_proc_event");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Cooldown).HasColumnType("int(10) unsigned");

                entity.Property(e => e.PpmRate).HasColumnName("ppmRate");

                entity.Property(e => e.ProcEx)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("procEx");

                entity.Property(e => e.ProcFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("procFlags");

                entity.Property(e => e.SchoolMask).HasColumnType("tinyint(4)");

                entity.Property(e => e.SpellFamilyMask0).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellFamilyMask1).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellFamilyMask2).HasColumnType("int(10) unsigned");

                entity.Property(e => e.SpellFamilyName).HasColumnType("smallint(5) unsigned");
            });

            modelBuilder.Entity<SpellRank>(entity =>
            {
                entity.HasKey(e => new { e.FirstSpellId, e.Rank })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_ranks");

                entity.HasComment("Spell Rank Data")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.SpellId, "spell_id")
                    .IsUnique();

                entity.Property(e => e.FirstSpellId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("first_spell_id");

                entity.Property(e => e.Rank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank");

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spell_id");
            });

            modelBuilder.Entity<SpellRequired>(entity =>
            {
                entity.HasKey(e => new { e.SpellId, e.ReqSpell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_required");

                entity.HasComment("Spell Additinal Data")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SpellId)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("spell_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ReqSpell)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("req_spell")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SpellScript>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spell_scripts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Command)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("command")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(11)")
                    .HasColumnName("dataint");

                entity.Property(e => e.Datalong)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("datalong")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.EffIndex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("effIndex");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<SpellScriptName>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("spell_script_names");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.SpellId, e.ScriptName }, "spell_id")
                    .IsUnique();

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .IsFixedLength();

                entity.Property(e => e.SpellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("spell_id");
            });

            modelBuilder.Entity<SpellTargetPosition>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.EffectIndex })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("spell_target_position");

                entity.HasComment("Spell System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("ID")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Identifier");

                entity.Property(e => e.EffectIndex).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.MapId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("MapID");

                entity.Property(e => e.VerifiedBuild)
                    .HasColumnType("smallint(6)")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<SpellThreat>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("spell_threat");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.ApPctMod)
                    .HasColumnName("apPctMod")
                    .HasComment("additional threat bonus from attack power");

                entity.Property(e => e.FlatMod)
                    .HasColumnType("int(11)")
                    .HasColumnName("flatMod");

                entity.Property(e => e.PctMod)
                    .HasColumnName("pctMod")
                    .HasDefaultValueSql("'1'")
                    .HasComment("threat multiplier for damage/healing");
            });

            modelBuilder.Entity<SpellcasttimesDbc>(entity =>
            {
                entity.ToTable("spellcasttimes_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Base).HasColumnType("int(11)");

                entity.Property(e => e.Minimum).HasColumnType("int(11)");

                entity.Property(e => e.PerLevel).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SpellcategoryDbc>(entity =>
            {
                entity.ToTable("spellcategory_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SpelldifficultyDbc>(entity =>
            {
                entity.ToTable("spelldifficulty_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DifficultySpellId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("DifficultySpellID_1");

                entity.Property(e => e.DifficultySpellId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("DifficultySpellID_2");

                entity.Property(e => e.DifficultySpellId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("DifficultySpellID_3");

                entity.Property(e => e.DifficultySpellId4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("DifficultySpellID_4");
            });

            modelBuilder.Entity<SpelldurationDbc>(entity =>
            {
                entity.ToTable("spellduration_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Duration).HasColumnType("int(11)");

                entity.Property(e => e.DurationPerLevel).HasColumnType("int(11)");

                entity.Property(e => e.MaxDuration).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SpellfocusobjectDbc>(entity =>
            {
                entity.ToTable("spellfocusobject_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<SpellitemenchantmentDbc>(entity =>
            {
                entity.ToTable("spellitemenchantment_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Charges).HasColumnType("int(11)");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Condition_Id");

                entity.Property(e => e.Effect1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Effect_1");

                entity.Property(e => e.Effect2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Effect_2");

                entity.Property(e => e.Effect3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Effect_3");

                entity.Property(e => e.EffectArg1)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectArg_1");

                entity.Property(e => e.EffectArg2)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectArg_2");

                entity.Property(e => e.EffectArg3)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectArg_3");

                entity.Property(e => e.EffectPointsMax1)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectPointsMax_1");

                entity.Property(e => e.EffectPointsMax2)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectPointsMax_2");

                entity.Property(e => e.EffectPointsMax3)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectPointsMax_3");

                entity.Property(e => e.EffectPointsMin1)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectPointsMin_1");

                entity.Property(e => e.EffectPointsMin2)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectPointsMin_2");

                entity.Property(e => e.EffectPointsMin3)
                    .HasColumnType("int(11)")
                    .HasColumnName("EffectPointsMin_3");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.ItemVisual).HasColumnType("int(11)");

                entity.Property(e => e.MinLevel).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.RequiredSkillId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RequiredSkillID");

                entity.Property(e => e.RequiredSkillRank).HasColumnType("int(11)");

                entity.Property(e => e.SrcItemId)
                    .HasColumnType("int(11)")
                    .HasColumnName("Src_ItemID");
            });

            modelBuilder.Entity<SpellitemenchantmentconditionDbc>(entity =>
            {
                entity.ToTable("spellitemenchantmentcondition_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Logic1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Logic_1");

                entity.Property(e => e.Logic2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Logic_2");

                entity.Property(e => e.Logic3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Logic_3");

                entity.Property(e => e.Logic4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Logic_4");

                entity.Property(e => e.Logic5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Logic_5");

                entity.Property(e => e.LtOperand1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Lt_Operand_1");

                entity.Property(e => e.LtOperand2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Lt_Operand_2");

                entity.Property(e => e.LtOperand3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Lt_Operand_3");

                entity.Property(e => e.LtOperand4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Lt_Operand_4");

                entity.Property(e => e.LtOperand5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Lt_Operand_5");

                entity.Property(e => e.LtOperandType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Lt_OperandType_1");

                entity.Property(e => e.LtOperandType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Lt_OperandType_2");

                entity.Property(e => e.LtOperandType3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Lt_OperandType_3");

                entity.Property(e => e.LtOperandType4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Lt_OperandType_4");

                entity.Property(e => e.LtOperandType5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Lt_OperandType_5");

                entity.Property(e => e.Operator1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Operator_1");

                entity.Property(e => e.Operator2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Operator_2");

                entity.Property(e => e.Operator3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Operator_3");

                entity.Property(e => e.Operator4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Operator_4");

                entity.Property(e => e.Operator5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Operator_5");

                entity.Property(e => e.RtOperand1)
                    .HasColumnType("int(11)")
                    .HasColumnName("Rt_Operand_1");

                entity.Property(e => e.RtOperand2)
                    .HasColumnType("int(11)")
                    .HasColumnName("Rt_Operand_2");

                entity.Property(e => e.RtOperand3)
                    .HasColumnType("int(11)")
                    .HasColumnName("Rt_Operand_3");

                entity.Property(e => e.RtOperand4)
                    .HasColumnType("int(11)")
                    .HasColumnName("Rt_Operand_4");

                entity.Property(e => e.RtOperand5)
                    .HasColumnType("int(11)")
                    .HasColumnName("Rt_Operand_5");

                entity.Property(e => e.RtOperandType1)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Rt_OperandType_1");

                entity.Property(e => e.RtOperandType2)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Rt_OperandType_2");

                entity.Property(e => e.RtOperandType3)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Rt_OperandType_3");

                entity.Property(e => e.RtOperandType4)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Rt_OperandType_4");

                entity.Property(e => e.RtOperandType5)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("Rt_OperandType_5");
            });

            modelBuilder.Entity<SpellradiusDbc>(entity =>
            {
                entity.ToTable("spellradius_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<SpellrangeDbc>(entity =>
            {
                entity.ToTable("spellrange_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.DisplayNameLangDeDe)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_deDE");

                entity.Property(e => e.DisplayNameLangEnCn)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_enCN");

                entity.Property(e => e.DisplayNameLangEnGb)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_enGB");

                entity.Property(e => e.DisplayNameLangEnTw)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_enTW");

                entity.Property(e => e.DisplayNameLangEnUs)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_enUS");

                entity.Property(e => e.DisplayNameLangEsEs)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_esES");

                entity.Property(e => e.DisplayNameLangEsMx)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_esMX");

                entity.Property(e => e.DisplayNameLangFrFr)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_frFR");

                entity.Property(e => e.DisplayNameLangItIt)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_itIT");

                entity.Property(e => e.DisplayNameLangKoKr)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_koKR");

                entity.Property(e => e.DisplayNameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("DisplayName_Lang_Mask");

                entity.Property(e => e.DisplayNameLangPtBr)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_ptBR");

                entity.Property(e => e.DisplayNameLangPtPt)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_ptPT");

                entity.Property(e => e.DisplayNameLangRuRu)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_ruRU");

                entity.Property(e => e.DisplayNameLangUnk)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_Unk");

                entity.Property(e => e.DisplayNameLangZhCn)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_zhCN");

                entity.Property(e => e.DisplayNameLangZhTw)
                    .HasColumnType("text")
                    .HasColumnName("DisplayName_Lang_zhTW");

                entity.Property(e => e.DisplayNameShortLangDeDe)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_deDE");

                entity.Property(e => e.DisplayNameShortLangEnCn)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_enCN");

                entity.Property(e => e.DisplayNameShortLangEnGb)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_enGB");

                entity.Property(e => e.DisplayNameShortLangEnTw)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_enTW");

                entity.Property(e => e.DisplayNameShortLangEnUs)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_enUS");

                entity.Property(e => e.DisplayNameShortLangEsEs)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_esES");

                entity.Property(e => e.DisplayNameShortLangEsMx)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_esMX");

                entity.Property(e => e.DisplayNameShortLangFrFr)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_frFR");

                entity.Property(e => e.DisplayNameShortLangItIt)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_itIT");

                entity.Property(e => e.DisplayNameShortLangKoKr)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_koKR");

                entity.Property(e => e.DisplayNameShortLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("DisplayNameShort_Lang_Mask");

                entity.Property(e => e.DisplayNameShortLangPtBr)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_ptBR");

                entity.Property(e => e.DisplayNameShortLangPtPt)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_ptPT");

                entity.Property(e => e.DisplayNameShortLangRuRu)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_ruRU");

                entity.Property(e => e.DisplayNameShortLangUnk)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_Unk");

                entity.Property(e => e.DisplayNameShortLangZhCn)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_zhCN");

                entity.Property(e => e.DisplayNameShortLangZhTw)
                    .HasColumnType("text")
                    .HasColumnName("DisplayNameShort_Lang_zhTW");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.RangeMax1).HasColumnName("RangeMax_1");

                entity.Property(e => e.RangeMax2).HasColumnName("RangeMax_2");

                entity.Property(e => e.RangeMin1).HasColumnName("RangeMin_1");

                entity.Property(e => e.RangeMin2).HasColumnName("RangeMin_2");
            });

            modelBuilder.Entity<SpellrunecostDbc>(entity =>
            {
                entity.ToTable("spellrunecost_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Blood).HasColumnType("int(11)");

                entity.Property(e => e.Frost).HasColumnType("int(11)");

                entity.Property(e => e.RunicPower).HasColumnType("int(11)");

                entity.Property(e => e.Unholy).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SpellshapeshiftformDbc>(entity =>
            {
                entity.ToTable("spellshapeshiftform_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AttackIconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AttackIconID");

                entity.Property(e => e.BonusActionBar).HasColumnType("int(11)");

                entity.Property(e => e.CombatRoundTime).HasColumnType("int(11)");

                entity.Property(e => e.CreatureDisplayId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatureDisplayID_1");

                entity.Property(e => e.CreatureDisplayId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatureDisplayID_2");

                entity.Property(e => e.CreatureDisplayId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatureDisplayID_3");

                entity.Property(e => e.CreatureDisplayId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("CreatureDisplayID_4");

                entity.Property(e => e.CreatureType).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.PresetSpellId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("PresetSpellID_1");

                entity.Property(e => e.PresetSpellId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("PresetSpellID_2");

                entity.Property(e => e.PresetSpellId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("PresetSpellID_3");

                entity.Property(e => e.PresetSpellId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("PresetSpellID_4");

                entity.Property(e => e.PresetSpellId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("PresetSpellID_5");

                entity.Property(e => e.PresetSpellId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("PresetSpellID_6");

                entity.Property(e => e.PresetSpellId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("PresetSpellID_7");

                entity.Property(e => e.PresetSpellId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("PresetSpellID_8");
            });

            modelBuilder.Entity<SpellvisualDbc>(entity =>
            {
                entity.ToTable("spellvisual_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AnimEventSoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AnimEventSoundID");

                entity.Property(e => e.CastKit).HasColumnType("int(11)");

                entity.Property(e => e.CasterImpactKit).HasColumnType("int(11)");

                entity.Property(e => e.ChannelKit).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.HasMissile).HasColumnType("int(11)");

                entity.Property(e => e.ImpactAreaKit).HasColumnType("int(11)");

                entity.Property(e => e.ImpactKit).HasColumnType("int(11)");

                entity.Property(e => e.InstantAreaKit).HasColumnType("int(11)");

                entity.Property(e => e.MissileAttachment).HasColumnType("int(11)");

                entity.Property(e => e.MissileDestinationAttachment).HasColumnType("int(11)");

                entity.Property(e => e.MissileFollowGroundApproach).HasColumnType("int(11)");

                entity.Property(e => e.MissileFollowGroundDropSpeed).HasColumnType("int(11)");

                entity.Property(e => e.MissileFollowGroundFlags).HasColumnType("int(11)");

                entity.Property(e => e.MissileFollowGroundHeight).HasColumnType("int(11)");

                entity.Property(e => e.MissileModel).HasColumnType("int(11)");

                entity.Property(e => e.MissileMotion).HasColumnType("int(11)");

                entity.Property(e => e.MissilePathType).HasColumnType("int(11)");

                entity.Property(e => e.MissileSound).HasColumnType("int(11)");

                entity.Property(e => e.MissileTargetingKit).HasColumnType("int(11)");

                entity.Property(e => e.PersistentAreaKit).HasColumnType("int(11)");

                entity.Property(e => e.PrecastKit).HasColumnType("int(11)");

                entity.Property(e => e.StateDoneKit).HasColumnType("int(11)");

                entity.Property(e => e.StateKit).HasColumnType("int(11)");

                entity.Property(e => e.TargetImpactKit).HasColumnType("int(11)");
            });

            modelBuilder.Entity<StableslotpricesDbc>(entity =>
            {
                entity.ToTable("stableslotprices_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Cost).HasColumnType("int(11)");
            });

            modelBuilder.Entity<SummonpropertiesDbc>(entity =>
            {
                entity.ToTable("summonproperties_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Control).HasColumnType("int(11)");

                entity.Property(e => e.Faction).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.Slot).HasColumnType("int(11)");

                entity.Property(e => e.Title).HasColumnType("int(11)");
            });

            modelBuilder.Entity<TalentDbc>(entity =>
            {
                entity.ToTable("talent_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.CategoryMask1)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryMask_1");

                entity.Property(e => e.CategoryMask2)
                    .HasColumnType("int(11)")
                    .HasColumnName("CategoryMask_2");

                entity.Property(e => e.ColumnIndex).HasColumnType("int(11)");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.PrereqRank1)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrereqRank_1");

                entity.Property(e => e.PrereqRank2)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrereqRank_2");

                entity.Property(e => e.PrereqRank3)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrereqRank_3");

                entity.Property(e => e.PrereqTalent1)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrereqTalent_1");

                entity.Property(e => e.PrereqTalent2)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrereqTalent_2");

                entity.Property(e => e.PrereqTalent3)
                    .HasColumnType("int(11)")
                    .HasColumnName("PrereqTalent_3");

                entity.Property(e => e.RequiredSpellId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RequiredSpellID");

                entity.Property(e => e.SpellRank1)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_1");

                entity.Property(e => e.SpellRank2)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_2");

                entity.Property(e => e.SpellRank3)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_3");

                entity.Property(e => e.SpellRank4)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_4");

                entity.Property(e => e.SpellRank5)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_5");

                entity.Property(e => e.SpellRank6)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_6");

                entity.Property(e => e.SpellRank7)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_7");

                entity.Property(e => e.SpellRank8)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_8");

                entity.Property(e => e.SpellRank9)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellRank_9");

                entity.Property(e => e.TabId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TabID");

                entity.Property(e => e.TierId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TierID");
            });

            modelBuilder.Entity<TalenttabDbc>(entity =>
            {
                entity.ToTable("talenttab_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.BackgroundFile).HasMaxLength(100);

                entity.Property(e => e.ClassMask).HasColumnType("int(11)");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.OrderIndex).HasColumnType("int(11)");

                entity.Property(e => e.PetTalentMask).HasColumnType("int(11)");

                entity.Property(e => e.RaceMask).HasColumnType("int(11)");

                entity.Property(e => e.SpellIconId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SpellIconID");
            });

            modelBuilder.Entity<TaxinodesDbc>(entity =>
            {
                entity.ToTable("taxinodes_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ContinentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContinentID");

                entity.Property(e => e.MountCreatureId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("MountCreatureID_1");

                entity.Property(e => e.MountCreatureId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("MountCreatureID_2");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");
            });

            modelBuilder.Entity<TaxipathDbc>(entity =>
            {
                entity.ToTable("taxipath_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Cost).HasColumnType("int(11)");

                entity.Property(e => e.FromTaxiNode).HasColumnType("int(11)");

                entity.Property(e => e.ToTaxiNode).HasColumnType("int(11)");
            });

            modelBuilder.Entity<TaxipathnodeDbc>(entity =>
            {
                entity.ToTable("taxipathnode_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.ArrivalEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ArrivalEventID");

                entity.Property(e => e.ContinentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ContinentID");

                entity.Property(e => e.Delay).HasColumnType("int(11)");

                entity.Property(e => e.DepartureEventId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DepartureEventID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.NodeIndex).HasColumnType("int(11)");

                entity.Property(e => e.PathId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PathID");
            });

            modelBuilder.Entity<TeamcontributionpointsDbc>(entity =>
            {
                entity.ToTable("teamcontributionpoints_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");
            });

            modelBuilder.Entity<TotemcategoryDbc>(entity =>
            {
                entity.ToTable("totemcategory_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.NameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_deDE");

                entity.Property(e => e.NameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enCN");

                entity.Property(e => e.NameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enGB");

                entity.Property(e => e.NameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enTW");

                entity.Property(e => e.NameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_enUS");

                entity.Property(e => e.NameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esES");

                entity.Property(e => e.NameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_esMX");

                entity.Property(e => e.NameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_frFR");

                entity.Property(e => e.NameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_itIT");

                entity.Property(e => e.NameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_koKR");

                entity.Property(e => e.NameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("Name_Lang_Mask");

                entity.Property(e => e.NameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptBR");

                entity.Property(e => e.NameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ptPT");

                entity.Property(e => e.NameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_ruRU");

                entity.Property(e => e.NameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_Unk");

                entity.Property(e => e.NameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhCN");

                entity.Property(e => e.NameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("Name_Lang_zhTW");

                entity.Property(e => e.TotemCategoryMask).HasColumnType("int(11)");

                entity.Property(e => e.TotemCategoryType).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Transport>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("transports");

                entity.HasComment("Transports")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Entry, "idx_entry")
                    .IsUnique();

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasColumnType("text")
                    .HasColumnName("name");

                entity.Property(e => e.ScriptName)
                    .HasMaxLength(64)
                    .HasDefaultValueSql("''")
                    .IsFixedLength();
            });

            modelBuilder.Entity<TransportanimationDbc>(entity =>
            {
                entity.ToTable("transportanimation_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.SequenceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("SequenceID");

                entity.Property(e => e.TimeIndex).HasColumnType("int(11)");

                entity.Property(e => e.TransportId)
                    .HasColumnType("int(11)")
                    .HasColumnName("TransportID");
            });

            modelBuilder.Entity<TransportrotationDbc>(entity =>
            {
                entity.ToTable("transportrotation_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.GameObjectsId)
                    .HasColumnType("int(11)")
                    .HasColumnName("GameObjectsID");

                entity.Property(e => e.TimeIndex).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Update>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("updates");

                entity.HasComment("List of all applied updates in this database.")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.Name)
                    .HasMaxLength(200)
                    .HasColumnName("name")
                    .HasComment("filename with extension of the update.");

                entity.Property(e => e.Hash)
                    .HasMaxLength(40)
                    .HasColumnName("hash")
                    .HasDefaultValueSql("''")
                    .IsFixedLength()
                    .HasComment("sha1 hash of the sql file.");

                entity.Property(e => e.Speed)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("speed")
                    .HasComment("time the query takes to apply in ms.");

                entity.Property(e => e.State)
                    .HasColumnType("enum('RELEASED','CUSTOM','MODULE','ARCHIVED')")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'RELEASED'")
                    .HasComment("defines if an update is released or archived.");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("timestamp")
                    .HasColumnName("timestamp")
                    .HasDefaultValueSql("current_timestamp()")
                    .HasComment("timestamp when the query was applied.");
            });

            modelBuilder.Entity<UpdatesInclude>(entity =>
            {
                entity.HasKey(e => e.Path)
                    .HasName("PRIMARY");

                entity.ToTable("updates_include");

                entity.HasComment("List of directories where we want to include sql updates.")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.Path)
                    .HasMaxLength(200)
                    .HasColumnName("path")
                    .HasComment("directory to include. $ means relative to the source directory.");

                entity.Property(e => e.State)
                    .HasColumnType("enum('RELEASED','ARCHIVED','CUSTOM')")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'RELEASED'")
                    .HasComment("defines if the directory contains released or archived updates.");
            });

            modelBuilder.Entity<VehicleAccessory>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.SeatId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("vehicle_accessory");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("guid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SeatId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("seat_id");

                entity.Property(e => e.AccessoryEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("accessory_entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Minion)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("minion");

                entity.Property(e => e.Summontimer)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("summontimer")
                    .HasDefaultValueSql("'30000'")
                    .HasComment("timer, only relevant for certain summontypes");

                entity.Property(e => e.Summontype)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summontype")
                    .HasDefaultValueSql("'6'")
                    .HasComment("see enum TempSummonType");
            });

            modelBuilder.Entity<VehicleDbc>(entity =>
            {
                entity.ToTable("vehicle_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.MsslTrgtArcTexture).HasMaxLength(100);

                entity.Property(e => e.MsslTrgtImpactModel1)
                    .HasMaxLength(100)
                    .HasColumnName("MsslTrgtImpactModel_1");

                entity.Property(e => e.MsslTrgtImpactModel2)
                    .HasMaxLength(100)
                    .HasColumnName("MsslTrgtImpactModel_2");

                entity.Property(e => e.MsslTrgtImpactRadius1).HasColumnName("MsslTrgtImpactRadius_1");

                entity.Property(e => e.MsslTrgtImpactRadius2).HasColumnName("MsslTrgtImpactRadius_2");

                entity.Property(e => e.MsslTrgtImpactTexture).HasMaxLength(100);

                entity.Property(e => e.PowerDisplayId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("PowerDisplayID_1");

                entity.Property(e => e.PowerDisplayId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("PowerDisplayID_2");

                entity.Property(e => e.PowerDisplayId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("PowerDisplayID_3");

                entity.Property(e => e.SeatId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("SeatID_1");

                entity.Property(e => e.SeatId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("SeatID_2");

                entity.Property(e => e.SeatId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("SeatID_3");

                entity.Property(e => e.SeatId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("SeatID_4");

                entity.Property(e => e.SeatId5)
                    .HasColumnType("int(11)")
                    .HasColumnName("SeatID_5");

                entity.Property(e => e.SeatId6)
                    .HasColumnType("int(11)")
                    .HasColumnName("SeatID_6");

                entity.Property(e => e.SeatId7)
                    .HasColumnType("int(11)")
                    .HasColumnName("SeatID_7");

                entity.Property(e => e.SeatId8)
                    .HasColumnType("int(11)")
                    .HasColumnName("SeatID_8");

                entity.Property(e => e.UilocomotionType).HasColumnType("int(11)");

                entity.Property(e => e.VehicleUiindicatorId)
                    .HasColumnType("int(11)")
                    .HasColumnName("VehicleUIIndicatorID");
            });

            modelBuilder.Entity<VehicleTemplateAccessory>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.SeatId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("vehicle_template_accessory");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.SeatId)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("seat_id");

                entity.Property(e => e.AccessoryEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("accessory_entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Minion)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("minion");

                entity.Property(e => e.Summontimer)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("summontimer")
                    .HasDefaultValueSql("'30000'")
                    .HasComment("timer, only relevant for certain summontypes");

                entity.Property(e => e.Summontype)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("summontype")
                    .HasDefaultValueSql("'6'")
                    .HasComment("see enum TempSummonType");
            });

            modelBuilder.Entity<VehicleseatDbc>(entity =>
            {
                entity.ToTable("vehicleseat_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AttachmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AttachmentID");

                entity.Property(e => e.EnterAnimLoop).HasColumnType("int(11)");

                entity.Property(e => e.EnterAnimStart).HasColumnType("int(11)");

                entity.Property(e => e.EnterUisoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("EnterUISoundID");

                entity.Property(e => e.ExitAnimEnd).HasColumnType("int(11)");

                entity.Property(e => e.ExitAnimLoop).HasColumnType("int(11)");

                entity.Property(e => e.ExitAnimStart).HasColumnType("int(11)");

                entity.Property(e => e.ExitUisoundId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ExitUISoundID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.FlagsB).HasColumnType("int(11)");

                entity.Property(e => e.PassengerAttachmentId)
                    .HasColumnType("int(11)")
                    .HasColumnName("PassengerAttachmentID");

                entity.Property(e => e.RideAnimLoop).HasColumnType("int(11)");

                entity.Property(e => e.RideAnimStart).HasColumnType("int(11)");

                entity.Property(e => e.RideUpperAnimLoop).HasColumnType("int(11)");

                entity.Property(e => e.RideUpperAnimStart).HasColumnType("int(11)");

                entity.Property(e => e.UiSkin).HasColumnType("int(11)");

                entity.Property(e => e.VehicleAbilityDisplay).HasColumnType("int(11)");

                entity.Property(e => e.VehicleEnterAnim).HasColumnType("int(11)");

                entity.Property(e => e.VehicleEnterAnimBone).HasColumnType("int(11)");

                entity.Property(e => e.VehicleExitAnim).HasColumnType("int(11)");

                entity.Property(e => e.VehicleExitAnimBone).HasColumnType("int(11)");

                entity.Property(e => e.VehicleRideAnimLoop).HasColumnType("int(11)");

                entity.Property(e => e.VehicleRideAnimLoopBone).HasColumnType("int(11)");
            });

            modelBuilder.Entity<Models.World.Version>(entity =>
            {
                entity.HasKey(e => e.CoreVersion)
                    .HasName("PRIMARY");

                entity.ToTable("version");

                entity.HasComment("Version Notes")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CoreVersion)
                    .HasColumnName("core_version")
                    .HasDefaultValueSql("''")
                    .HasComment("Core revision dumped at startup.");

                entity.Property(e => e.CacheId)
                    .HasColumnType("int(11)")
                    .HasColumnName("cache_id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoreRevision)
                    .HasMaxLength(120)
                    .HasColumnName("core_revision");

                entity.Property(e => e.DbVersion)
                    .HasMaxLength(120)
                    .HasColumnName("db_version")
                    .HasComment("Version of world DB.");
            });

            modelBuilder.Entity<VersionDbWorld>(entity =>
            {
                entity.HasKey(e => e.SqlRev)
                    .HasName("PRIMARY");

                entity.ToTable("version_db_world");

                entity.HasComment("Last applied sql update to DB")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.RequiredRev, "required");

                entity.Property(e => e.SqlRev)
                    .HasMaxLength(100)
                    .HasColumnName("sql_rev");

                entity.Property(e => e.Date)
                    .HasMaxLength(50)
                    .HasColumnName("date")
                    .UseCollation("utf8mb4_general_ci");

                entity.Property(e => e.RequiredRev)
                    .HasMaxLength(100)
                    .HasColumnName("required_rev");

                entity.Property(e => e._2021112802)
                    .HasColumnType("bit(1)")
                    .HasColumnName("2021_11_28_02");

                entity.HasOne(d => d.RequiredRevNavigation)
                    .WithMany(p => p.InverseRequiredRevNavigation)
                    .HasForeignKey(d => d.RequiredRev)
                    .HasConstraintName("required");
            });

            modelBuilder.Entity<WardenCheck>(entity =>
            {
                entity.ToTable("warden_checks");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("address");

                entity.Property(e => e.Comment)
                    .HasMaxLength(50)
                    .HasColumnName("comment");

                entity.Property(e => e.Data)
                    .HasMaxLength(48)
                    .HasColumnName("data");

                entity.Property(e => e.Length)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("length");

                entity.Property(e => e.Result)
                    .HasMaxLength(24)
                    .HasColumnName("result");

                entity.Property(e => e.Str)
                    .HasMaxLength(170)
                    .HasColumnName("str");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<Waypoint>(entity =>
            {
                entity.HasKey(e => new { e.Entry, e.Pointid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("waypoints");

                entity.HasComment("Creature waypoints")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("entry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Pointid)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("pointid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PointComment)
                    .HasColumnType("text")
                    .HasColumnName("point_comment");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");
            });

            modelBuilder.Entity<WaypointDatum>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Point })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("waypoint_data");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id")
                    .HasComment("Creature GUID");

                entity.Property(e => e.Point)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("point")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Action)
                    .HasColumnType("int(11)")
                    .HasColumnName("action");

                entity.Property(e => e.ActionChance)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("action_chance")
                    .HasDefaultValueSql("'100'");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.MoveType)
                    .HasColumnType("int(11)")
                    .HasColumnName("move_type");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Wpguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("wpguid");
            });

            modelBuilder.Entity<WaypointScript>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("waypoint_scripts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Command)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("command");

                entity.Property(e => e.Dataint)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("dataint");

                entity.Property(e => e.Datalong)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong");

                entity.Property(e => e.Datalong2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("datalong2");

                entity.Property(e => e.Delay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("delay");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.O).HasColumnName("o");

                entity.Property(e => e.X).HasColumnName("x");

                entity.Property(e => e.Y).HasColumnName("y");

                entity.Property(e => e.Z).HasColumnName("z");
            });

            modelBuilder.Entity<WmoareatableDbc>(entity =>
            {
                entity.ToTable("wmoareatable_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AmbienceId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AmbienceID");

                entity.Property(e => e.AreaNameLangDeDe)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_deDE");

                entity.Property(e => e.AreaNameLangEnCn)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_enCN");

                entity.Property(e => e.AreaNameLangEnGb)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_enGB");

                entity.Property(e => e.AreaNameLangEnTw)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_enTW");

                entity.Property(e => e.AreaNameLangEnUs)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_enUS");

                entity.Property(e => e.AreaNameLangEsEs)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_esES");

                entity.Property(e => e.AreaNameLangEsMx)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_esMX");

                entity.Property(e => e.AreaNameLangFrFr)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_frFR");

                entity.Property(e => e.AreaNameLangItIt)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_itIT");

                entity.Property(e => e.AreaNameLangKoKr)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_koKR");

                entity.Property(e => e.AreaNameLangMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("AreaName_Lang_Mask");

                entity.Property(e => e.AreaNameLangPtBr)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_ptBR");

                entity.Property(e => e.AreaNameLangPtPt)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_ptPT");

                entity.Property(e => e.AreaNameLangRuRu)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_ruRU");

                entity.Property(e => e.AreaNameLangUnk)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_Unk");

                entity.Property(e => e.AreaNameLangZhCn)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_zhCN");

                entity.Property(e => e.AreaNameLangZhTw)
                    .HasMaxLength(100)
                    .HasColumnName("AreaName_Lang_zhTW");

                entity.Property(e => e.AreaTableId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaTableID");

                entity.Property(e => e.Flags).HasColumnType("int(11)");

                entity.Property(e => e.IntroSound).HasColumnType("int(11)");

                entity.Property(e => e.NameSetId)
                    .HasColumnType("int(11)")
                    .HasColumnName("NameSetID");

                entity.Property(e => e.SoundProviderPref).HasColumnType("int(11)");

                entity.Property(e => e.SoundProviderPrefUnderwater).HasColumnType("int(11)");

                entity.Property(e => e.WmogroupId)
                    .HasColumnType("int(11)")
                    .HasColumnName("WMOGroupID");

                entity.Property(e => e.Wmoid)
                    .HasColumnType("int(11)")
                    .HasColumnName("WMOID");

                entity.Property(e => e.ZoneMusic).HasColumnType("int(11)");
            });

            modelBuilder.Entity<WorldmapareaDbc>(entity =>
            {
                entity.ToTable("worldmaparea_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID");

                entity.Property(e => e.AreaName).HasMaxLength(100);

                entity.Property(e => e.DefaultDungeonFloor).HasColumnType("int(11)");

                entity.Property(e => e.DisplayMapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("DisplayMapID");

                entity.Property(e => e.MapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapID");

                entity.Property(e => e.ParentWorldMapId)
                    .HasColumnType("int(11)")
                    .HasColumnName("ParentWorldMapID");
            });

            modelBuilder.Entity<WorldmapoverlayDbc>(entity =>
            {
                entity.ToTable("worldmapoverlay_dbc");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.AreaId1)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_1");

                entity.Property(e => e.AreaId2)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_2");

                entity.Property(e => e.AreaId3)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_3");

                entity.Property(e => e.AreaId4)
                    .HasColumnType("int(11)")
                    .HasColumnName("AreaID_4");

                entity.Property(e => e.HitRectBottom).HasColumnType("int(11)");

                entity.Property(e => e.HitRectLeft).HasColumnType("int(11)");

                entity.Property(e => e.HitRectRight).HasColumnType("int(11)");

                entity.Property(e => e.HitRectTop).HasColumnType("int(11)");

                entity.Property(e => e.MapAreaId)
                    .HasColumnType("int(11)")
                    .HasColumnName("MapAreaID");

                entity.Property(e => e.MapPointX).HasColumnType("int(11)");

                entity.Property(e => e.MapPointY).HasColumnType("int(11)");

                entity.Property(e => e.OffsetX).HasColumnType("int(11)");

                entity.Property(e => e.OffsetY).HasColumnType("int(11)");

                entity.Property(e => e.TextureHeight).HasColumnType("int(11)");

                entity.Property(e => e.TextureName).HasMaxLength(100);

                entity.Property(e => e.TextureWidth).HasColumnType("int(11)");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
