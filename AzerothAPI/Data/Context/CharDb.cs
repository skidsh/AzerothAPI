using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AzerothAPI.Data.Models.Char;

namespace AzerothAPI.Data.Context
{
    public partial class CharDb : DbContext
    {
        public CharDb()
        {
        }

        public CharDb(DbContextOptions<CharDb> options)
            : base(options)
        {
        }

        public virtual DbSet<AccountDatum> AccountData { get; set; } = null!;
        public virtual DbSet<AccountInstanceTime> AccountInstanceTimes { get; set; } = null!;
        public virtual DbSet<AccountTutorial> AccountTutorials { get; set; } = null!;
        public virtual DbSet<Addon> Addons { get; set; } = null!;
        public virtual DbSet<ArenaTeam> ArenaTeams { get; set; } = null!;
        public virtual DbSet<ArenaTeamMember> ArenaTeamMembers { get; set; } = null!;
        public virtual DbSet<Auctionhouse> Auctionhouses { get; set; } = null!;
        public virtual DbSet<BannedAddon> BannedAddons { get; set; } = null!;
        public virtual DbSet<BattlegroundDeserter> BattlegroundDeserters { get; set; } = null!;
        public virtual DbSet<Bugreport> Bugreports { get; set; } = null!;
        public virtual DbSet<CalendarEvent> CalendarEvents { get; set; } = null!;
        public virtual DbSet<CalendarInvite> CalendarInvites { get; set; } = null!;
        public virtual DbSet<Channel> Channels { get; set; } = null!;
        public virtual DbSet<ChannelsBan> ChannelsBans { get; set; } = null!;
        public virtual DbSet<ChannelsRight> ChannelsRights { get; set; } = null!;
        public virtual DbSet<Character> Characters { get; set; } = null!;
        public virtual DbSet<CharacterAccountDatum> CharacterAccountData { get; set; } = null!;
        public virtual DbSet<CharacterAchievement> CharacterAchievements { get; set; } = null!;
        public virtual DbSet<CharacterAchievementProgress> CharacterAchievementProgresses { get; set; } = null!;
        public virtual DbSet<CharacterAction> CharacterActions { get; set; } = null!;
        public virtual DbSet<CharacterArenaStat> CharacterArenaStats { get; set; } = null!;
        public virtual DbSet<CharacterAura> CharacterAuras { get; set; } = null!;
        public virtual DbSet<CharacterBanned> CharacterBanneds { get; set; } = null!;
        public virtual DbSet<CharacterBattlegroundRandom> CharacterBattlegroundRandoms { get; set; } = null!;
        public virtual DbSet<CharacterBrewOfTheMonth> CharacterBrewOfTheMonths { get; set; } = null!;
        public virtual DbSet<CharacterDeclinedname> CharacterDeclinednames { get; set; } = null!;
        public virtual DbSet<CharacterEntryPoint> CharacterEntryPoints { get; set; } = null!;
        public virtual DbSet<CharacterEquipmentset> CharacterEquipmentsets { get; set; } = null!;
        public virtual DbSet<CharacterGift> CharacterGifts { get; set; } = null!;
        public virtual DbSet<CharacterGlyph> CharacterGlyphs { get; set; } = null!;
        public virtual DbSet<CharacterHomebind> CharacterHomebinds { get; set; } = null!;
        public virtual DbSet<CharacterInstance> CharacterInstances { get; set; } = null!;
        public virtual DbSet<CharacterInventory> CharacterInventories { get; set; } = null!;
        public virtual DbSet<CharacterPet> CharacterPets { get; set; } = null!;
        public virtual DbSet<CharacterPetDeclinedname> CharacterPetDeclinednames { get; set; } = null!;
        public virtual DbSet<CharacterQueststatus> CharacterQueststatuses { get; set; } = null!;
        public virtual DbSet<CharacterQueststatusDaily> CharacterQueststatusDailies { get; set; } = null!;
        public virtual DbSet<CharacterQueststatusMonthly> CharacterQueststatusMonthlies { get; set; } = null!;
        public virtual DbSet<CharacterQueststatusRewarded> CharacterQueststatusRewardeds { get; set; } = null!;
        public virtual DbSet<CharacterQueststatusSeasonal> CharacterQueststatusSeasonals { get; set; } = null!;
        public virtual DbSet<CharacterQueststatusWeekly> CharacterQueststatusWeeklies { get; set; } = null!;
        public virtual DbSet<CharacterReputation> CharacterReputations { get; set; } = null!;
        public virtual DbSet<CharacterSkill> CharacterSkills { get; set; } = null!;
        public virtual DbSet<CharacterSocial> CharacterSocials { get; set; } = null!;
        public virtual DbSet<CharacterSpell> CharacterSpells { get; set; } = null!;
        public virtual DbSet<CharacterSpellCooldown> CharacterSpellCooldowns { get; set; } = null!;
        public virtual DbSet<CharacterStat> CharacterStats { get; set; } = null!;
        public virtual DbSet<CharacterTalent> CharacterTalents { get; set; } = null!;
        public virtual DbSet<Corpse> Corpses { get; set; } = null!;
        public virtual DbSet<CreatureRespawn> CreatureRespawns { get; set; } = null!;
        public virtual DbSet<GameEventConditionSave> GameEventConditionSaves { get; set; } = null!;
        public virtual DbSet<GameEventSave> GameEventSaves { get; set; } = null!;
        public virtual DbSet<GameobjectRespawn> GameobjectRespawns { get; set; } = null!;
        public virtual DbSet<GmSubsurvey> GmSubsurveys { get; set; } = null!;
        public virtual DbSet<GmSurvey> GmSurveys { get; set; } = null!;
        public virtual DbSet<GmTicket> GmTickets { get; set; } = null!;
        public virtual DbSet<Group> Groups { get; set; } = null!;
        public virtual DbSet<GroupMember> GroupMembers { get; set; } = null!;
        public virtual DbSet<Guild> Guilds { get; set; } = null!;
        public virtual DbSet<GuildBankEventlog> GuildBankEventlogs { get; set; } = null!;
        public virtual DbSet<GuildBankItem> GuildBankItems { get; set; } = null!;
        public virtual DbSet<GuildBankRight> GuildBankRights { get; set; } = null!;
        public virtual DbSet<GuildBankTab> GuildBankTabs { get; set; } = null!;
        public virtual DbSet<GuildEventlog> GuildEventlogs { get; set; } = null!;
        public virtual DbSet<GuildMember> GuildMembers { get; set; } = null!;
        public virtual DbSet<GuildMemberWithdraw> GuildMemberWithdraws { get; set; } = null!;
        public virtual DbSet<GuildRank> GuildRanks { get; set; } = null!;
        public virtual DbSet<Instance> Instances { get; set; } = null!;
        public virtual DbSet<InstanceReset> InstanceResets { get; set; } = null!;
        public virtual DbSet<ItemInstance> ItemInstances { get; set; } = null!;
        public virtual DbSet<ItemLootStorage> ItemLootStorages { get; set; } = null!;
        public virtual DbSet<ItemRefundInstance> ItemRefundInstances { get; set; } = null!;
        public virtual DbSet<ItemSoulboundTradeDatum> ItemSoulboundTradeData { get; set; } = null!;
        public virtual DbSet<LagReport> LagReports { get; set; } = null!;
        public virtual DbSet<LfgDatum> LfgData { get; set; } = null!;
        public virtual DbSet<LogArenaFight> LogArenaFights { get; set; } = null!;
        public virtual DbSet<LogArenaMemberstat> LogArenaMemberstats { get; set; } = null!;
        public virtual DbSet<LogEncounter> LogEncounters { get; set; } = null!;
        public virtual DbSet<LogMoney> LogMoneys { get; set; } = null!;
        public virtual DbSet<Mail> Mail { get; set; } = null!;
        public virtual DbSet<MailItem> MailItems { get; set; } = null!;
        public virtual DbSet<PetAura> PetAuras { get; set; } = null!;
        public virtual DbSet<PetSpell> PetSpells { get; set; } = null!;
        public virtual DbSet<PetSpellCooldown> PetSpellCooldowns { get; set; } = null!;
        public virtual DbSet<Petition> Petitions { get; set; } = null!;
        public virtual DbSet<PetitionSign> PetitionSigns { get; set; } = null!;
        public virtual DbSet<PoolQuestSave> PoolQuestSaves { get; set; } = null!;
        public virtual DbSet<PvpstatsBattleground> PvpstatsBattlegrounds { get; set; } = null!;
        public virtual DbSet<PvpstatsPlayer> PvpstatsPlayers { get; set; } = null!;
        public virtual DbSet<QuestTracker> QuestTrackers { get; set; } = null!;
        public virtual DbSet<RecoveryItem> RecoveryItems { get; set; } = null!;
        public virtual DbSet<ReservedName> ReservedNames { get; set; } = null!;
        public virtual DbSet<TemplateNpcAlliance> TemplateNpcAlliances { get; set; } = null!;
        public virtual DbSet<TemplateNpcGlyph> TemplateNpcGlyphs { get; set; } = null!;
        public virtual DbSet<TemplateNpcHorde> TemplateNpcHordes { get; set; } = null!;
        public virtual DbSet<TemplateNpcHuman> TemplateNpcHumans { get; set; } = null!;
        public virtual DbSet<TemplateNpcTalent> TemplateNpcTalents { get; set; } = null!;
        public virtual DbSet<Update> Updates { get; set; } = null!;
        public virtual DbSet<UpdatesInclude> UpdatesIncludes { get; set; } = null!;
        public virtual DbSet<VersionDbCharacter> VersionDbCharacters { get; set; } = null!;
        public virtual DbSet<WardenAction> WardenActions { get; set; } = null!;
        public virtual DbSet<Worldstate> Worldstates { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=ConnectionStrings:char_database", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.4-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");

            modelBuilder.Entity<AccountDatum>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account_data");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("accountId")
                    .HasComment("Account Identifier");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Data)
                    .HasColumnType("blob")
                    .HasColumnName("data");

                entity.Property(e => e.Time)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<AccountInstanceTime>(entity =>
            {
                entity.HasKey(e => new { e.AccountId, e.InstanceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account_instance_times");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("accountId");

                entity.Property(e => e.InstanceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("instanceId");

                entity.Property(e => e.ReleaseTime)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("releaseTime");
            });

            modelBuilder.Entity<AccountTutorial>(entity =>
            {
                entity.HasKey(e => e.AccountId)
                    .HasName("PRIMARY");

                entity.ToTable("account_tutorial");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("accountId")
                    .HasComment("Account Identifier");

                entity.Property(e => e.Tut0)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tut0");

                entity.Property(e => e.Tut1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tut1");

                entity.Property(e => e.Tut2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tut2");

                entity.Property(e => e.Tut3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tut3");

                entity.Property(e => e.Tut4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tut4");

                entity.Property(e => e.Tut5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tut5");

                entity.Property(e => e.Tut6)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tut6");

                entity.Property(e => e.Tut7)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tut7");
            });

            modelBuilder.Entity<Addon>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("addons");

                entity.HasComment("Addons")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Name)
                    .HasMaxLength(120)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Crc)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("crc");
            });

            modelBuilder.Entity<ArenaTeam>(entity =>
            {
                entity.ToTable("arena_team");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ArenaTeamId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("arenaTeamId");

                entity.Property(e => e.BackgroundColor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("backgroundColor");

                entity.Property(e => e.BorderColor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("borderColor");

                entity.Property(e => e.BorderStyle)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("borderStyle");

                entity.Property(e => e.CaptainGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("captainGuid");

                entity.Property(e => e.EmblemColor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("emblemColor");

                entity.Property(e => e.EmblemStyle)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("emblemStyle");

                entity.Property(e => e.Name)
                    .HasMaxLength(24)
                    .HasColumnName("name");

                entity.Property(e => e.Rank)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rank");

                entity.Property(e => e.Rating)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("rating");

                entity.Property(e => e.SeasonGames)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("seasonGames");

                entity.Property(e => e.SeasonWins)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("seasonWins");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.WeekGames)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("weekGames");

                entity.Property(e => e.WeekWins)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("weekWins");
            });

            modelBuilder.Entity<ArenaTeamMember>(entity =>
            {
                entity.HasKey(e => new { e.ArenaTeamId, e.Guid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("arena_team_member");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ArenaTeamId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("arenaTeamId");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.PersonalRating)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("personalRating");

                entity.Property(e => e.SeasonGames)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("seasonGames");

                entity.Property(e => e.SeasonWins)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("seasonWins");

                entity.Property(e => e.WeekGames)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("weekGames");

                entity.Property(e => e.WeekWins)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("weekWins");
            });

            modelBuilder.Entity<Auctionhouse>(entity =>
            {
                entity.ToTable("auctionhouse");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Itemguid, "item_guid")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Buyguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buyguid");

                entity.Property(e => e.Buyoutprice)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("buyoutprice");

                entity.Property(e => e.Deposit)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deposit");

                entity.Property(e => e.Houseid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("houseid")
                    .HasDefaultValueSql("'7'");

                entity.Property(e => e.Itemguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("itemguid");

                entity.Property(e => e.Itemowner)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("itemowner");

                entity.Property(e => e.Lastbid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lastbid");

                entity.Property(e => e.Startbid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("startbid");

                entity.Property(e => e.Time)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<BannedAddon>(entity =>
            {
                entity.ToTable("banned_addons");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Name, e.Version }, "idx_name_ver")
                    .IsUnique();

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Timestamp)
                    .HasColumnType("timestamp")
                    .ValueGeneratedOnAddOrUpdate()
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.Version).HasDefaultValueSql("''");
            });

            modelBuilder.Entity<BattlegroundDeserter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("battleground_deserters");

                entity.Property(e => e.Datetime)
                    .HasColumnType("datetime")
                    .HasColumnName("datetime")
                    .HasComment("datetime of the desertion");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("characters.guid");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type")
                    .HasComment("type of the desertion");
            });

            modelBuilder.Entity<Bugreport>(entity =>
            {
                entity.ToTable("bugreport");

                entity.HasComment("Debug System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id")
                    .HasComment("Identifier");

                entity.Property(e => e.Content).HasColumnName("content");

                entity.Property(e => e.Type).HasColumnName("type");
            });

            modelBuilder.Entity<CalendarEvent>(entity =>
            {
                entity.ToTable("calendar_events");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Creator)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creator");

                entity.Property(e => e.Description)
                    .HasMaxLength(255)
                    .HasColumnName("description")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dungeon)
                    .HasColumnType("int(11)")
                    .HasColumnName("dungeon")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Eventtime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("eventtime");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Time2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time2");

                entity.Property(e => e.Title)
                    .HasMaxLength(255)
                    .HasColumnName("title")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type")
                    .HasDefaultValueSql("'4'");
            });

            modelBuilder.Entity<CalendarInvite>(entity =>
            {
                entity.ToTable("calendar_invites");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Event)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("event");

                entity.Property(e => e.Invitee)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("invitee");

                entity.Property(e => e.Rank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank");

                entity.Property(e => e.Sender)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sender");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("status");

                entity.Property(e => e.Statustime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("statustime");

                entity.Property(e => e.Text)
                    .HasMaxLength(255)
                    .HasColumnName("text")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Channel>(entity =>
            {
                entity.ToTable("channels");

                entity.HasComment("Channel System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ChannelId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("channelId");

                entity.Property(e => e.Announce)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("announce")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.LastUsed)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lastUsed");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Ownership)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("ownership")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Password)
                    .HasMaxLength(32)
                    .HasColumnName("password");

                entity.Property(e => e.Team)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("team");
            });

            modelBuilder.Entity<ChannelsBan>(entity =>
            {
                entity.HasKey(e => new { e.ChannelId, e.PlayerGuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("channels_bans");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ChannelId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("channelId");

                entity.Property(e => e.PlayerGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("playerGUID");

                entity.Property(e => e.BanTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("banTime");
            });

            modelBuilder.Entity<ChannelsRight>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("channels_rights");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Name)
                    .HasMaxLength(128)
                    .HasColumnName("name");

                entity.Property(e => e.Delaymessage)
                    .HasMaxLength(255)
                    .HasColumnName("delaymessage")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Joinmessage)
                    .HasMaxLength(255)
                    .HasColumnName("joinmessage")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Moderators)
                    .HasColumnType("text")
                    .HasColumnName("moderators");

                entity.Property(e => e.Speakdelay)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("speakdelay");
            });

            modelBuilder.Entity<Character>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("characters");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Account, "idx_account");

                entity.HasIndex(e => e.Name, "idx_name");

                entity.HasIndex(e => e.Online, "idx_online");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Account)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("account")
                    .HasComment("Account Identifier");

                entity.Property(e => e.ActionBars)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("actionBars");

                entity.Property(e => e.ActiveTalentGroup)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("activeTalentGroup");

                entity.Property(e => e.AmmoId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ammoId");

                entity.Property(e => e.ArenaPoints)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("arenaPoints");

                entity.Property(e => e.AtLogin)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("at_login");

                entity.Property(e => e.BankSlots)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("bankSlots");

                entity.Property(e => e.ChosenTitle)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("chosenTitle");

                entity.Property(e => e.Cinematic)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("cinematic");

                entity.Property(e => e.Class)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("class");

                entity.Property(e => e.CreationDate)
                    .HasColumnType("timestamp")
                    .HasColumnName("creation_date")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.DeathExpireTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("death_expire_time");

                entity.Property(e => e.DeleteDate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleteDate");

                entity.Property(e => e.DeleteInfosAccount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deleteInfos_Account");

                entity.Property(e => e.DeleteInfosName)
                    .HasMaxLength(12)
                    .HasColumnName("deleteInfos_Name");

                entity.Property(e => e.Drunk)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("drunk");

                entity.Property(e => e.EquipmentCache).HasColumnName("equipmentCache");

                entity.Property(e => e.ExploredZones).HasColumnName("exploredZones");

                entity.Property(e => e.ExtraFlags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("extra_flags");

                entity.Property(e => e.Face)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("face");

                entity.Property(e => e.FacialStyle)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("facialStyle");

                entity.Property(e => e.Gender)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gender");

                entity.Property(e => e.GrantableLevels)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("grantableLevels");

                entity.Property(e => e.HairColor)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("hairColor");

                entity.Property(e => e.HairStyle)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("hairStyle");

                entity.Property(e => e.Health)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("health");

                entity.Property(e => e.InnTriggerId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("innTriggerId");

                entity.Property(e => e.InstanceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("instance_id");

                entity.Property(e => e.InstanceModeMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("instance_mode_mask");

                entity.Property(e => e.IsLogoutResting)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("is_logout_resting");

                entity.Property(e => e.KnownCurrencies)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("knownCurrencies");

                entity.Property(e => e.KnownTitles).HasColumnName("knownTitles");

                entity.Property(e => e.Latency)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("latency")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Leveltime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("leveltime");

                entity.Property(e => e.LogoutTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("logout_time");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("money");

                entity.Property(e => e.Name)
                    .HasMaxLength(12)
                    .HasColumnName("name")
                    .UseCollation("utf8mb4_bin");

                entity.Property(e => e.Online)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("online");

                entity.Property(e => e.Order)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("order");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PlayerFlags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("playerFlags");

                entity.Property(e => e.PositionX).HasColumnName("position_x");

                entity.Property(e => e.PositionY).HasColumnName("position_y");

                entity.Property(e => e.PositionZ).HasColumnName("position_z");

                entity.Property(e => e.Power1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power1");

                entity.Property(e => e.Power2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power2");

                entity.Property(e => e.Power3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power3");

                entity.Property(e => e.Power4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power4");

                entity.Property(e => e.Power5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power5");

                entity.Property(e => e.Power6)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power6");

                entity.Property(e => e.Power7)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("power7");

                entity.Property(e => e.Race)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("race");

                entity.Property(e => e.ResettalentsCost)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resettalents_cost");

                entity.Property(e => e.ResettalentsTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resettalents_time");

                entity.Property(e => e.RestBonus).HasColumnName("rest_bonus");

                entity.Property(e => e.RestState)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("restState");

                entity.Property(e => e.Skin)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("skin");

                entity.Property(e => e.StableSlots)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stable_slots");

                entity.Property(e => e.TalentGroupsCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("talentGroupsCount")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.TaxiPath)
                    .HasColumnType("text")
                    .HasColumnName("taxi_path");

                entity.Property(e => e.Taximask)
                    .HasColumnType("text")
                    .HasColumnName("taximask");

                entity.Property(e => e.TodayHonorPoints)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("todayHonorPoints");

                entity.Property(e => e.TodayKills)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("todayKills");

                entity.Property(e => e.TotalHonorPoints)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("totalHonorPoints");

                entity.Property(e => e.TotalKills)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("totalKills");

                entity.Property(e => e.Totaltime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("totaltime");

                entity.Property(e => e.TransO).HasColumnName("trans_o");

                entity.Property(e => e.TransX).HasColumnName("trans_x");

                entity.Property(e => e.TransY).HasColumnName("trans_y");

                entity.Property(e => e.TransZ).HasColumnName("trans_z");

                entity.Property(e => e.Transguid)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("transguid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.WatchedFaction)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("watchedFaction");

                entity.Property(e => e.Xp)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("xp");

                entity.Property(e => e.YesterdayHonorPoints)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("yesterdayHonorPoints");

                entity.Property(e => e.YesterdayKills)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("yesterdayKills");

                entity.Property(e => e.Zone)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("zone");
            });

            modelBuilder.Entity<CharacterAccountDatum>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_account_data");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Data)
                    .HasColumnType("blob")
                    .HasColumnName("data");

                entity.Property(e => e.Time)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<CharacterAchievement>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Achievement })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_achievement");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Achievement)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("achievement");

                entity.Property(e => e.Date)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("date");
            });

            modelBuilder.Entity<CharacterAchievementProgress>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Criteria })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_achievement_progress");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Criteria)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("criteria");

                entity.Property(e => e.Counter)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("counter");

                entity.Property(e => e.Date)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("date");
            });

            modelBuilder.Entity<CharacterAction>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spec, e.Button })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("character_action");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Spec)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("spec");

                entity.Property(e => e.Button)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("button");

                entity.Property(e => e.Action)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("action");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<CharacterArenaStat>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Slot })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_arena_stats");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Slot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("slot");

                entity.Property(e => e.MatchMakerRating)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("matchMakerRating");

                entity.Property(e => e.MaxMmr)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("maxMMR");
            });

            modelBuilder.Entity<CharacterAura>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.CasterGuid, e.ItemGuid, e.Spell, e.EffectMask })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0, 0 });

                entity.ToTable("character_aura");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.CasterGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("casterGuid")
                    .HasComment("Full Global Unique Identifier");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("itemGuid");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EffectMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("effectMask");

                entity.Property(e => e.Amount0)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount0");

                entity.Property(e => e.Amount1)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount1");

                entity.Property(e => e.Amount2)
                    .HasColumnType("int(11)")
                    .HasColumnName("amount2");

                entity.Property(e => e.BaseAmount0)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_amount0");

                entity.Property(e => e.BaseAmount1)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_amount1");

                entity.Property(e => e.BaseAmount2)
                    .HasColumnType("int(11)")
                    .HasColumnName("base_amount2");

                entity.Property(e => e.MaxDuration)
                    .HasColumnType("int(11)")
                    .HasColumnName("maxDuration");

                entity.Property(e => e.RecalculateMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("recalculateMask");

                entity.Property(e => e.RemainCharges)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("remainCharges");

                entity.Property(e => e.RemainTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("remainTime");

                entity.Property(e => e.StackCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stackCount")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CharacterBanned>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Bandate })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_banned");

                entity.HasComment("Ban List")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Bandate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bandate");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Bannedby)
                    .HasMaxLength(50)
                    .HasColumnName("bannedby");

                entity.Property(e => e.Banreason)
                    .HasMaxLength(255)
                    .HasColumnName("banreason");

                entity.Property(e => e.Unbandate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("unbandate");
            });

            modelBuilder.Entity<CharacterBattlegroundRandom>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_battleground_random");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");
            });

            modelBuilder.Entity<CharacterBrewOfTheMonth>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_brew_of_the_month");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.LastEventId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lastEventId");
            });

            modelBuilder.Entity<CharacterDeclinedname>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_declinedname");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Accusative)
                    .HasMaxLength(15)
                    .HasColumnName("accusative")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dative)
                    .HasMaxLength(15)
                    .HasColumnName("dative")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Genitive)
                    .HasMaxLength(15)
                    .HasColumnName("genitive")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Instrumental)
                    .HasMaxLength(15)
                    .HasColumnName("instrumental")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Prepositional)
                    .HasMaxLength(15)
                    .HasColumnName("prepositional")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CharacterEntryPoint>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_entry_point");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.JoinMapId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("joinMapId")
                    .HasComment("Map Identifier");

                entity.Property(e => e.JoinO).HasColumnName("joinO");

                entity.Property(e => e.JoinX).HasColumnName("joinX");

                entity.Property(e => e.JoinY).HasColumnName("joinY");

                entity.Property(e => e.JoinZ).HasColumnName("joinZ");

                entity.Property(e => e.MountSpell)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mountSpell");

                entity.Property(e => e.TaxiPath)
                    .HasColumnType("text")
                    .HasColumnName("taxiPath");
            });

            modelBuilder.Entity<CharacterEquipmentset>(entity =>
            {
                entity.HasKey(e => e.Setguid)
                    .HasName("PRIMARY");

                entity.ToTable("character_equipmentsets");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Setindex, "Idx_setindex");

                entity.HasIndex(e => new { e.Guid, e.Setguid, e.Setindex }, "idx_set")
                    .IsUnique();

                entity.Property(e => e.Setguid)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("setguid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(11)")
                    .HasColumnName("guid");

                entity.Property(e => e.Iconname)
                    .HasMaxLength(100)
                    .HasColumnName("iconname");

                entity.Property(e => e.IgnoreMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ignore_mask");

                entity.Property(e => e.Item0)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item0");

                entity.Property(e => e.Item1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item1");

                entity.Property(e => e.Item10)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item10");

                entity.Property(e => e.Item11)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item11");

                entity.Property(e => e.Item12)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item12");

                entity.Property(e => e.Item13)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item13");

                entity.Property(e => e.Item14)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item14");

                entity.Property(e => e.Item15)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item15");

                entity.Property(e => e.Item16)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item16");

                entity.Property(e => e.Item17)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item17");

                entity.Property(e => e.Item18)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item18");

                entity.Property(e => e.Item2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item2");

                entity.Property(e => e.Item3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item3");

                entity.Property(e => e.Item4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item4");

                entity.Property(e => e.Item5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item5");

                entity.Property(e => e.Item6)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item6");

                entity.Property(e => e.Item7)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item7");

                entity.Property(e => e.Item8)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item8");

                entity.Property(e => e.Item9)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item9");

                entity.Property(e => e.Name)
                    .HasMaxLength(31)
                    .HasColumnName("name");

                entity.Property(e => e.Setindex)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("setindex");
            });

            modelBuilder.Entity<CharacterGift>(entity =>
            {
                entity.HasKey(e => e.ItemGuid)
                    .HasName("PRIMARY");

                entity.ToTable("character_gifts");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("item_guid");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.Flags)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");
            });

            modelBuilder.Entity<CharacterGlyph>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.TalentGroup })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_glyphs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.TalentGroup)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("talentGroup");

                entity.Property(e => e.Glyph1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("glyph1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Glyph2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("glyph2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Glyph3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("glyph3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Glyph4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("glyph4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Glyph5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("glyph5")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Glyph6)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("glyph6")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<CharacterHomebind>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_homebind");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.MapId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mapId")
                    .HasComment("Map Identifier");

                entity.Property(e => e.PosX).HasColumnName("posX");

                entity.Property(e => e.PosY).HasColumnName("posY");

                entity.Property(e => e.PosZ).HasColumnName("posZ");

                entity.Property(e => e.ZoneId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("zoneId")
                    .HasComment("Zone Identifier");
            });

            modelBuilder.Entity<CharacterInstance>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Instance })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_instance");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Instance, "instance");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Instance)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("instance");

                entity.Property(e => e.Extended)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("extended");

                entity.Property(e => e.Permanent)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("permanent");
            });

            modelBuilder.Entity<CharacterInventory>(entity =>
            {
                entity.HasKey(e => e.Item)
                    .HasName("PRIMARY");

                entity.ToTable("character_inventory");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Guid, e.Bag, e.Slot }, "guid")
                    .IsUnique();

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Item)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("item")
                    .HasComment("Item Global Unique Identifier");

                entity.Property(e => e.Bag)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bag");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Slot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("slot");
            });

            modelBuilder.Entity<CharacterPet>(entity =>
            {
                entity.ToTable("character_pet");

                entity.HasComment("Pet System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Slot, "idx_slot");

                entity.HasIndex(e => e.Owner, "owner");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Abdata)
                    .HasColumnType("text")
                    .HasColumnName("abdata");

                entity.Property(e => e.CreatedBySpell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Curhappiness)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("curhappiness");

                entity.Property(e => e.Curhealth)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("curhealth")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Curmana)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("curmana");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("entry");

                entity.Property(e => e.Exp)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("exp");

                entity.Property(e => e.Level)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("level")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Modelid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("modelid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(21)
                    .HasColumnName("name")
                    .HasDefaultValueSql("'Pet'");

                entity.Property(e => e.Owner)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("owner");

                entity.Property(e => e.PetType).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Reactstate).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Renamed)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("renamed");

                entity.Property(e => e.Savetime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("savetime");

                entity.Property(e => e.Slot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("slot");
            });

            modelBuilder.Entity<CharacterPetDeclinedname>(entity =>
            {
                entity.ToTable("character_pet_declinedname");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Owner, "owner_key");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Accusative)
                    .HasMaxLength(12)
                    .HasColumnName("accusative")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Dative)
                    .HasMaxLength(12)
                    .HasColumnName("dative")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Genitive)
                    .HasMaxLength(12)
                    .HasColumnName("genitive")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Instrumental)
                    .HasMaxLength(12)
                    .HasColumnName("instrumental")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Owner)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("owner");

                entity.Property(e => e.Prepositional)
                    .HasMaxLength(12)
                    .HasColumnName("prepositional")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<CharacterQueststatus>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");

                entity.Property(e => e.Explored)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("explored");

                entity.Property(e => e.Itemcount1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("itemcount1");

                entity.Property(e => e.Itemcount2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("itemcount2");

                entity.Property(e => e.Itemcount3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("itemcount3");

                entity.Property(e => e.Itemcount4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("itemcount4");

                entity.Property(e => e.Itemcount5)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("itemcount5");

                entity.Property(e => e.Itemcount6)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("itemcount6");

                entity.Property(e => e.Mobcount1)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mobcount1");

                entity.Property(e => e.Mobcount2)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mobcount2");

                entity.Property(e => e.Mobcount3)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mobcount3");

                entity.Property(e => e.Mobcount4)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mobcount4");

                entity.Property(e => e.Playercount)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("playercount");

                entity.Property(e => e.Status)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("status");

                entity.Property(e => e.Timer)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("timer");
            });

            modelBuilder.Entity<CharacterQueststatusDaily>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus_daily");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");

                entity.Property(e => e.Time)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<CharacterQueststatusMonthly>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus_monthly");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CharacterQueststatusRewarded>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus_rewarded");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("active")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CharacterQueststatusSeasonal>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus_seasonal");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");

                entity.Property(e => e.Event)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("event")
                    .HasComment("Event Identifier");
            });

            modelBuilder.Entity<CharacterQueststatusWeekly>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Quest })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_queststatus_weekly");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Quest)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("quest")
                    .HasComment("Quest Identifier");
            });

            modelBuilder.Entity<CharacterReputation>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Faction })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_reputation");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Faction)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("faction");

                entity.Property(e => e.Flags)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.Standing)
                    .HasColumnType("int(11)")
                    .HasColumnName("standing");
            });

            modelBuilder.Entity<CharacterSkill>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Skill })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_skills");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Skill)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("skill");

                entity.Property(e => e.Max)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("max");

                entity.Property(e => e.Value)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("value");
            });

            modelBuilder.Entity<CharacterSocial>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Friend, e.Flags })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("character_social");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Friend, "friend");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Character Global Unique Identifier");

                entity.Property(e => e.Friend)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("friend")
                    .HasComment("Friend Global Unique Identifier");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("flags")
                    .HasComment("Friend Flags");

                entity.Property(e => e.Note)
                    .HasMaxLength(48)
                    .HasColumnName("note")
                    .HasDefaultValueSql("''")
                    .HasComment("Friend Note");
            });

            modelBuilder.Entity<CharacterSpell>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_spell");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Spell Identifier");

                entity.Property(e => e.SpecMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("specMask")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<CharacterSpellCooldown>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_spell_cooldown");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier, Low part");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Spell Identifier");

                entity.Property(e => e.Category)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("category")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Item)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item")
                    .HasComment("Item Identifier");

                entity.Property(e => e.NeedSend)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("needSend")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Time)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<CharacterStat>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("character_stats");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier, Low part");

                entity.Property(e => e.Agility)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("agility");

                entity.Property(e => e.Armor)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("armor");

                entity.Property(e => e.AttackPower)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("attackPower");

                entity.Property(e => e.BlockPct).HasColumnName("blockPct");

                entity.Property(e => e.CritPct).HasColumnName("critPct");

                entity.Property(e => e.DodgePct).HasColumnName("dodgePct");

                entity.Property(e => e.Intellect)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("intellect");

                entity.Property(e => e.Maxhealth)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxhealth");

                entity.Property(e => e.Maxpower1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower1");

                entity.Property(e => e.Maxpower2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower2");

                entity.Property(e => e.Maxpower3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower3");

                entity.Property(e => e.Maxpower4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower4");

                entity.Property(e => e.Maxpower5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower5");

                entity.Property(e => e.Maxpower6)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower6");

                entity.Property(e => e.Maxpower7)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("maxpower7");

                entity.Property(e => e.ParryPct).HasColumnName("parryPct");

                entity.Property(e => e.RangedAttackPower)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("rangedAttackPower");

                entity.Property(e => e.RangedCritPct).HasColumnName("rangedCritPct");

                entity.Property(e => e.ResArcane)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resArcane");

                entity.Property(e => e.ResFire)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resFire");

                entity.Property(e => e.ResFrost)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resFrost");

                entity.Property(e => e.ResHoly)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resHoly");

                entity.Property(e => e.ResNature)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resNature");

                entity.Property(e => e.ResShadow)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resShadow");

                entity.Property(e => e.Resilience)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resilience");

                entity.Property(e => e.SpellCritPct).HasColumnName("spellCritPct");

                entity.Property(e => e.SpellPower)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spellPower");

                entity.Property(e => e.Spirit)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("spirit");

                entity.Property(e => e.Stamina)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("stamina");

                entity.Property(e => e.Strength)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("strength");
            });

            modelBuilder.Entity<CharacterTalent>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("character_talent");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell");

                entity.Property(e => e.SpecMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("specMask");
            });

            modelBuilder.Entity<Corpse>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("corpse");

                entity.HasComment("Death System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.InstanceId, "idx_instance");

                entity.HasIndex(e => e.Time, "idx_time");

                entity.HasIndex(e => e.CorpseType, "idx_type");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Character Global Unique Identifier");

                entity.Property(e => e.Bytes1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bytes1");

                entity.Property(e => e.Bytes2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bytes2");

                entity.Property(e => e.CorpseType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("corpseType");

                entity.Property(e => e.DisplayId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("displayId");

                entity.Property(e => e.DynFlags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("dynFlags");

                entity.Property(e => e.Flags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("flags");

                entity.Property(e => e.GuildId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guildId");

                entity.Property(e => e.InstanceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("instanceId")
                    .HasComment("Instance Identifier");

                entity.Property(e => e.ItemCache)
                    .HasColumnType("text")
                    .HasColumnName("itemCache");

                entity.Property(e => e.MapId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mapId")
                    .HasComment("Map Identifier");

                entity.Property(e => e.Orientation).HasColumnName("orientation");

                entity.Property(e => e.PhaseMask)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("phaseMask")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.PosX).HasColumnName("posX");

                entity.Property(e => e.PosY).HasColumnName("posY");

                entity.Property(e => e.PosZ).HasColumnName("posZ");

                entity.Property(e => e.Time)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<CreatureRespawn>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.InstanceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("creature_respawn");

                entity.HasComment("Grid Loading System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.InstanceId, "idx_instance");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.InstanceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("instanceId")
                    .HasComment("Instance Identifier");

                entity.Property(e => e.MapId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mapId");

                entity.Property(e => e.RespawnTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("respawnTime");
            });

            modelBuilder.Entity<GameEventConditionSave>(entity =>
            {
                entity.HasKey(e => new { e.EventEntry, e.ConditionId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("game_event_condition_save");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry");

                entity.Property(e => e.ConditionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("condition_id");

                entity.Property(e => e.Done)
                    .HasColumnName("done")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<GameEventSave>(entity =>
            {
                entity.HasKey(e => e.EventEntry)
                    .HasName("PRIMARY");

                entity.ToTable("game_event_save");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.EventEntry)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("eventEntry");

                entity.Property(e => e.NextStart)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("next_start");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("state")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<GameobjectRespawn>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.InstanceId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gameobject_respawn");

                entity.HasComment("Grid Loading System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.InstanceId, "idx_instance");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.InstanceId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("instanceId")
                    .HasComment("Instance Identifier");

                entity.Property(e => e.MapId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mapId");

                entity.Property(e => e.RespawnTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("respawnTime");
            });

            modelBuilder.Entity<GmSubsurvey>(entity =>
            {
                entity.HasKey(e => new { e.SurveyId, e.QuestionId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("gm_subsurvey");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SurveyId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("surveyId");

                entity.Property(e => e.QuestionId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("questionId");

                entity.Property(e => e.Answer)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("answer");

                entity.Property(e => e.AnswerComment)
                    .HasColumnType("text")
                    .HasColumnName("answerComment");
            });

            modelBuilder.Entity<GmSurvey>(entity =>
            {
                entity.HasKey(e => e.SurveyId)
                    .HasName("PRIMARY");

                entity.ToTable("gm_survey");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.SurveyId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("surveyId");

                entity.Property(e => e.Comment).HasColumnName("comment");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("createTime");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.MainSurvey)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mainSurvey");

                entity.Property(e => e.MaxMmr)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("maxMMR");
            });

            modelBuilder.Entity<GmTicket>(entity =>
            {
                entity.ToTable("gm_ticket");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.AssignedTo)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("assignedTo")
                    .HasComment("GUID of admin to whom ticket is assigned");

                entity.Property(e => e.ClosedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("closedBy")
                    .HasComment("-1 Closed by Console, >0 GUID of GM");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment");

                entity.Property(e => e.Completed)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("completed");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("createTime");

                entity.Property(e => e.Description)
                    .HasColumnType("text")
                    .HasColumnName("description");

                entity.Property(e => e.Escalated)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("escalated");

                entity.Property(e => e.LastModifiedTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("lastModifiedTime");

                entity.Property(e => e.MapId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mapId");

                entity.Property(e => e.Name)
                    .HasMaxLength(12)
                    .HasColumnName("name")
                    .HasComment("Name of ticket creator");

                entity.Property(e => e.NeedMoreHelp)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("needMoreHelp");

                entity.Property(e => e.PlayerGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("playerGuid")
                    .HasComment("Global Unique Identifier of ticket creator");

                entity.Property(e => e.PosX).HasColumnName("posX");

                entity.Property(e => e.PosY).HasColumnName("posY");

                entity.Property(e => e.PosZ).HasColumnName("posZ");

                entity.Property(e => e.ResolvedBy)
                    .HasColumnType("int(11)")
                    .HasColumnName("resolvedBy")
                    .HasComment("-1 Resolved by Console, >0 GUID of GM");

                entity.Property(e => e.Response)
                    .HasColumnType("text")
                    .HasColumnName("response");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type")
                    .HasComment("0 open, 1 closed, 2 character deleted");

                entity.Property(e => e.Viewed)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("viewed");
            });

            modelBuilder.Entity<Group>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("groups");

                entity.HasComment("Groups")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LeaderGuid, "leaderGuid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("difficulty");

                entity.Property(e => e.GroupType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("groupType");

                entity.Property(e => e.Icon1)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("icon1");

                entity.Property(e => e.Icon2)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("icon2");

                entity.Property(e => e.Icon3)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("icon3");

                entity.Property(e => e.Icon4)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("icon4");

                entity.Property(e => e.Icon5)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("icon5");

                entity.Property(e => e.Icon6)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("icon6");

                entity.Property(e => e.Icon7)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("icon7");

                entity.Property(e => e.Icon8)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("icon8");

                entity.Property(e => e.LeaderGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("leaderGuid");

                entity.Property(e => e.LootMethod)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lootMethod");

                entity.Property(e => e.LootThreshold)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lootThreshold");

                entity.Property(e => e.LooterGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("looterGuid");

                entity.Property(e => e.MasterLooterGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("masterLooterGuid");

                entity.Property(e => e.RaidDifficulty)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("raidDifficulty");
            });

            modelBuilder.Entity<GroupMember>(entity =>
            {
                entity.HasKey(e => e.MemberGuid)
                    .HasName("PRIMARY");

                entity.ToTable("group_member");

                entity.HasComment("Groups")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.MemberGuid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("memberGuid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.MemberFlags)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("memberFlags");

                entity.Property(e => e.Roles)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("roles");

                entity.Property(e => e.Subgroup)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("subgroup");
            });

            modelBuilder.Entity<Guild>(entity =>
            {
                entity.ToTable("guild");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guildid");

                entity.Property(e => e.BackgroundColor).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BankMoney).HasColumnType("bigint(20) unsigned");

                entity.Property(e => e.BorderColor).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.BorderStyle).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Createdate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("createdate");

                entity.Property(e => e.EmblemColor).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.EmblemStyle).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Info)
                    .HasMaxLength(500)
                    .HasColumnName("info")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Leaderguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("leaderguid");

                entity.Property(e => e.Motd)
                    .HasMaxLength(128)
                    .HasColumnName("motd")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Name)
                    .HasMaxLength(24)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<GuildBankEventlog>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.LogGuid, e.TabId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("guild_bank_eventlog");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LogGuid, "Idx_LogGuid");

                entity.HasIndex(e => e.PlayerGuid, "Idx_PlayerGuid");

                entity.HasIndex(e => e.Guildid, "guildid_key");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guildid")
                    .HasComment("Guild Identificator");

                entity.Property(e => e.LogGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Log record identificator - auxiliary column");

                entity.Property(e => e.TabId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Guild bank TabId");

                entity.Property(e => e.DestTabId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Destination Tab Id");

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Event type");

                entity.Property(e => e.ItemOrMoney).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemStackCount).HasColumnType("smallint(5) unsigned");

                entity.Property(e => e.PlayerGuid).HasColumnType("int(10) unsigned");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Event UNIX time");
            });

            modelBuilder.Entity<GuildBankItem>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId, e.SlotId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("guild_bank_item");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.ItemGuid, "Idx_item_guid");

                entity.HasIndex(e => e.Guildid, "guildid_key");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.TabId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.SlotId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item_guid");
            });

            modelBuilder.Entity<GuildBankRight>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId, e.Rid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0 });

                entity.ToTable("guild_bank_right");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guildid, "guildid_key");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.TabId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.Rid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rid");

                entity.Property(e => e.Gbright)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gbright");

                entity.Property(e => e.SlotPerDay).HasColumnType("int(10) unsigned");
            });

            modelBuilder.Entity<GuildBankTab>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.TabId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("guild_bank_tab");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guildid, "guildid_key");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.TabId).HasColumnType("tinyint(3) unsigned");

                entity.Property(e => e.TabIcon)
                    .HasMaxLength(100)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TabName)
                    .HasMaxLength(16)
                    .HasDefaultValueSql("''");

                entity.Property(e => e.TabText).HasMaxLength(500);
            });

            modelBuilder.Entity<GuildEventlog>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.LogGuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("guild_eventlog");

                entity.HasComment("Guild Eventlog")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.LogGuid, "Idx_LogGuid");

                entity.HasIndex(e => e.PlayerGuid1, "Idx_PlayerGuid1");

                entity.HasIndex(e => e.PlayerGuid2, "Idx_PlayerGuid2");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guildid")
                    .HasComment("Guild Identificator");

                entity.Property(e => e.LogGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Log record identificator - auxiliary column");

                entity.Property(e => e.EventType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("Event type");

                entity.Property(e => e.NewRank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasComment("New rank(in case promotion/demotion)");

                entity.Property(e => e.PlayerGuid1)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Player 1");

                entity.Property(e => e.PlayerGuid2)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Player 2");

                entity.Property(e => e.TimeStamp)
                    .HasColumnType("int(10) unsigned")
                    .HasComment("Event UNIX time");
            });

            modelBuilder.Entity<GuildMember>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("guild_member");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "guid_key")
                    .IsUnique();

                entity.HasIndex(e => e.Guildid, "guildid_key");

                entity.HasIndex(e => new { e.Guildid, e.Rank }, "guildid_rank_key");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guildid")
                    .HasComment("Guild Identificator");

                entity.Property(e => e.Offnote)
                    .HasMaxLength(31)
                    .HasColumnName("offnote")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Pnote)
                    .HasMaxLength(31)
                    .HasColumnName("pnote")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Rank)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rank");
            });

            modelBuilder.Entity<GuildMemberWithdraw>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("guild_member_withdraw");

                entity.HasComment("Guild Member Daily Withdraws")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("money");

                entity.Property(e => e.Tab0)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tab0");

                entity.Property(e => e.Tab1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tab1");

                entity.Property(e => e.Tab2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tab2");

                entity.Property(e => e.Tab3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tab3");

                entity.Property(e => e.Tab4)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tab4");

                entity.Property(e => e.Tab5)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("tab5");
            });

            modelBuilder.Entity<GuildRank>(entity =>
            {
                entity.HasKey(e => new { e.Guildid, e.Rid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("guild_rank");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Rid, "Idx_rid");

                entity.Property(e => e.Guildid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guildid");

                entity.Property(e => e.Rid)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("rid");

                entity.Property(e => e.BankMoneyPerDay).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Rights)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("rights")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Rname)
                    .HasMaxLength(20)
                    .HasColumnName("rname")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<Instance>(entity =>
            {
                entity.ToTable("instance");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Difficulty, "difficulty");

                entity.HasIndex(e => e.Map, "map");

                entity.HasIndex(e => e.Resettime, "resettime");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.CompletedEncounters)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("completedEncounters");

                entity.Property(e => e.Data)
                    .HasColumnType("text")
                    .HasColumnName("data");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("difficulty");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.Resettime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resettime");
            });

            modelBuilder.Entity<InstanceReset>(entity =>
            {
                entity.HasKey(e => new { e.Mapid, e.Difficulty })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("instance_reset");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Difficulty, "difficulty");

                entity.Property(e => e.Mapid)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mapid");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("difficulty");

                entity.Property(e => e.Resettime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("resettime");
            });

            modelBuilder.Entity<ItemInstance>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("item_instance");

                entity.HasComment("Item System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.OwnerGuid, "idx_owner_guid");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid");

                entity.Property(e => e.Charges)
                    .HasColumnType("tinytext")
                    .HasColumnName("charges");

                entity.Property(e => e.Count)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("count")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.CreatorGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creatorGuid");

                entity.Property(e => e.Durability)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("durability");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(11)")
                    .HasColumnName("duration");

                entity.Property(e => e.Enchantments)
                    .HasColumnType("text")
                    .HasColumnName("enchantments");

                entity.Property(e => e.Flags)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("flags")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.GiftCreatorGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("giftCreatorGuid");

                entity.Property(e => e.ItemEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("itemEntry")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.OwnerGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("owner_guid");

                entity.Property(e => e.PlayedTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("playedTime");

                entity.Property(e => e.RandomPropertyId)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("randomPropertyId");

                entity.Property(e => e.Text)
                    .HasColumnType("text")
                    .HasColumnName("text");

                entity.Property(e => e.Transmog)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("transmog");
            });

            modelBuilder.Entity<ItemLootStorage>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("item_loot_storage");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ConditionLootId)
                    .HasColumnType("int(11)")
                    .HasColumnName("conditionLootId");

                entity.Property(e => e.ContainerGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("containerGUID");

                entity.Property(e => e.Count)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("count");

                entity.Property(e => e.FollowLootRules)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("follow_loot_rules");

                entity.Property(e => e.Freeforall)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("freeforall");

                entity.Property(e => e.IsBlocked)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("is_blocked");

                entity.Property(e => e.IsCounted)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("is_counted");

                entity.Property(e => e.IsUnderthreshold)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("is_underthreshold");

                entity.Property(e => e.ItemIndex)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item_index");

                entity.Property(e => e.Itemid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("itemid");

                entity.Property(e => e.NeedsQuest)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("needs_quest");

                entity.Property(e => e.RandomPropertyId)
                    .HasColumnType("int(11)")
                    .HasColumnName("randomPropertyId");

                entity.Property(e => e.RandomSuffix)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("randomSuffix");
            });

            modelBuilder.Entity<ItemRefundInstance>(entity =>
            {
                entity.HasKey(e => new { e.ItemGuid, e.PlayerGuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("item_refund_instance");

                entity.HasComment("Item Refund System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("item_guid")
                    .HasComment("Item GUID");

                entity.Property(e => e.PlayerGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("player_guid")
                    .HasComment("Player GUID");

                entity.Property(e => e.PaidExtendedCost)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("paidExtendedCost");

                entity.Property(e => e.PaidMoney)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("paidMoney");
            });

            modelBuilder.Entity<ItemSoulboundTradeDatum>(entity =>
            {
                entity.HasKey(e => e.ItemGuid)
                    .HasName("PRIMARY");

                entity.ToTable("item_soulbound_trade_data");

                entity.HasComment("Item Refund System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("itemGuid")
                    .HasComment("Item GUID");

                entity.Property(e => e.AllowedPlayers)
                    .HasColumnType("text")
                    .HasColumnName("allowedPlayers")
                    .HasComment("Space separated GUID list of players who can receive this item in trade");
            });

            modelBuilder.Entity<LagReport>(entity =>
            {
                entity.HasKey(e => e.ReportId)
                    .HasName("PRIMARY");

                entity.ToTable("lag_reports");

                entity.HasComment("Player System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.ReportId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("reportId");

                entity.Property(e => e.CreateTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("createTime");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.LagType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("lagType");

                entity.Property(e => e.Latency)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("latency");

                entity.Property(e => e.MapId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mapId");

                entity.Property(e => e.PosX).HasColumnName("posX");

                entity.Property(e => e.PosY).HasColumnName("posY");

                entity.Property(e => e.PosZ).HasColumnName("posZ");
            });

            modelBuilder.Entity<LfgDatum>(entity =>
            {
                entity.HasKey(e => e.Guid)
                    .HasName("PRIMARY");

                entity.ToTable("lfg_data");

                entity.HasComment("LFG Data")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Dungeon)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("dungeon");

                entity.Property(e => e.State)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("state");
            });

            modelBuilder.Entity<LogArenaFight>(entity =>
            {
                entity.HasKey(e => e.FightId)
                    .HasName("PRIMARY");

                entity.ToTable("log_arena_fights");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FightId)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("fight_id");

                entity.Property(e => e.CurrOnline)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("currOnline");

                entity.Property(e => e.Duration)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("duration");

                entity.Property(e => e.Loser)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("loser");

                entity.Property(e => e.LoserMmr)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("loser_mmr");

                entity.Property(e => e.LoserTr)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("loser_tr");

                entity.Property(e => e.LoserTrChange)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("loser_tr_change");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Winner)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("winner");

                entity.Property(e => e.WinnerMmr)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("winner_mmr");

                entity.Property(e => e.WinnerTr)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("winner_tr");

                entity.Property(e => e.WinnerTrChange)
                    .HasColumnType("smallint(6)")
                    .HasColumnName("winner_tr_change");
            });

            modelBuilder.Entity<LogArenaMemberstat>(entity =>
            {
                entity.HasKey(e => new { e.FightId, e.MemberId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("log_arena_memberstats");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.FightId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("fight_id");

                entity.Property(e => e.MemberId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("member_id");

                entity.Property(e => e.Account)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("account");

                entity.Property(e => e.Damage)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("damage");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid");

                entity.Property(e => e.Heal)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("heal");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("ip")
                    .IsFixedLength();

                entity.Property(e => e.Kblows)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("kblows");

                entity.Property(e => e.Name)
                    .HasMaxLength(20)
                    .HasColumnName("name")
                    .IsFixedLength();

                entity.Property(e => e.Team)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("team");
            });

            modelBuilder.Entity<LogEncounter>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log_encounter");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.CreditEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("creditEntry");

                entity.Property(e => e.CreditType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("creditType");

                entity.Property(e => e.Difficulty)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("difficulty");

                entity.Property(e => e.Map)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("map");

                entity.Property(e => e.PlayersInfo)
                    .HasColumnType("text")
                    .HasColumnName("playersInfo");

                entity.Property(e => e.Time)
                    .HasColumnType("datetime")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<LogMoney>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("log_money");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Money)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("money");

                entity.Property(e => e.ReceiverAcc)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("receiver_acc");

                entity.Property(e => e.ReceiverName)
                    .HasMaxLength(32)
                    .HasColumnName("receiver_name")
                    .IsFixedLength()
                    .UseCollation("utf8mb4_unicode_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.SenderAcc)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sender_acc");

                entity.Property(e => e.SenderGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sender_guid");

                entity.Property(e => e.SenderIp)
                    .HasMaxLength(32)
                    .HasColumnName("sender_ip")
                    .IsFixedLength()
                    .UseCollation("utf8mb4_unicode_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.SenderName)
                    .HasMaxLength(32)
                    .HasColumnName("sender_name")
                    .IsFixedLength()
                    .UseCollation("utf8mb4_unicode_ci")
                    .HasCharSet("utf8mb4");

                entity.Property(e => e.Topic)
                    .HasMaxLength(255)
                    .HasColumnName("topic")
                    .IsFixedLength()
                    .UseCollation("utf8mb4_unicode_ci")
                    .HasCharSet("utf8mb4");
            });

            modelBuilder.Entity<Mail>(entity =>
            {
                entity.ToTable("mail");

                entity.HasComment("Mail System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Receiver, "idx_receiver");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id")
                    .HasComment("Identifier");

                entity.Property(e => e.AuctionId)
                    .HasColumnType("int(11)")
                    .HasColumnName("auctionId");

                entity.Property(e => e.Body).HasColumnName("body");

                entity.Property(e => e.Checked)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("checked");

                entity.Property(e => e.Cod)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("cod");

                entity.Property(e => e.DeliverTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("deliver_time");

                entity.Property(e => e.ExpireTime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("expire_time");

                entity.Property(e => e.HasItems)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("has_items");

                entity.Property(e => e.MailTemplateId)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("mailTemplateId");

                entity.Property(e => e.MessageType)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("messageType");

                entity.Property(e => e.Money)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("money");

                entity.Property(e => e.Receiver)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("receiver")
                    .HasComment("Character Global Unique Identifier");

                entity.Property(e => e.Sender)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("sender")
                    .HasComment("Character Global Unique Identifier");

                entity.Property(e => e.Stationery)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("stationery")
                    .HasDefaultValueSql("'41'");

                entity.Property(e => e.Subject).HasColumnName("subject");
            });

            modelBuilder.Entity<MailItem>(entity =>
            {
                entity.HasKey(e => e.ItemGuid)
                    .HasName("PRIMARY");

                entity.ToTable("mail_items");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.MailId, "idx_mail_id");

                entity.HasIndex(e => e.Receiver, "idx_receiver");

                entity.Property(e => e.ItemGuid)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("item_guid");

                entity.Property(e => e.MailId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mail_id");

                entity.Property(e => e.Receiver)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("receiver")
                    .HasComment("Character Global Unique Identifier");
            });

            modelBuilder.Entity<PetAura>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.CasterGuid, e.Spell, e.EffectMask })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0, 0, 0 });

                entity.ToTable("pet_aura");

                entity.HasComment("Pet System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.CasterGuid)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("casterGuid")
                    .HasComment("Full Global Unique Identifier");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.EffectMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("effectMask");

                entity.Property(e => e.Amount0)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("amount0");

                entity.Property(e => e.Amount1)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("amount1");

                entity.Property(e => e.Amount2)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("amount2");

                entity.Property(e => e.BaseAmount0)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("base_amount0");

                entity.Property(e => e.BaseAmount1)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("base_amount1");

                entity.Property(e => e.BaseAmount2)
                    .HasColumnType("mediumint(9)")
                    .HasColumnName("base_amount2");

                entity.Property(e => e.MaxDuration)
                    .HasColumnType("int(11)")
                    .HasColumnName("maxDuration");

                entity.Property(e => e.RecalculateMask)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("recalculateMask");

                entity.Property(e => e.RemainCharges)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("remainCharges");

                entity.Property(e => e.RemainTime)
                    .HasColumnType("int(11)")
                    .HasColumnName("remainTime");

                entity.Property(e => e.StackCount)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("stackCount")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<PetSpell>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pet_spell");

                entity.HasComment("Pet System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Spell Identifier");

                entity.Property(e => e.Active)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("active");
            });

            modelBuilder.Entity<PetSpellCooldown>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Spell })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pet_spell_cooldown");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier, Low part");

                entity.Property(e => e.Spell)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("spell")
                    .HasDefaultValueSql("'0'")
                    .HasComment("Spell Identifier");

                entity.Property(e => e.Category)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("category")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Time)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time");
            });

            modelBuilder.Entity<Petition>(entity =>
            {
                entity.HasKey(e => new { e.Ownerguid, e.Type })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("petition");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => new { e.Ownerguid, e.Petitionguid }, "index_ownerguid_petitionguid")
                    .IsUnique();

                entity.Property(e => e.Ownerguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ownerguid");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Name)
                    .HasMaxLength(24)
                    .HasColumnName("name");

                entity.Property(e => e.Petitionguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("petitionguid")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<PetitionSign>(entity =>
            {
                entity.HasKey(e => new { e.Petitionguid, e.Playerguid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("petition_sign");

                entity.HasComment("Guild System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Ownerguid, "Idx_ownerguid");

                entity.HasIndex(e => e.Playerguid, "Idx_playerguid");

                entity.Property(e => e.Petitionguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("petitionguid");

                entity.Property(e => e.Playerguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("playerguid");

                entity.Property(e => e.Ownerguid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("ownerguid");

                entity.Property(e => e.PlayerAccount)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("player_account");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");
            });

            modelBuilder.Entity<PoolQuestSave>(entity =>
            {
                entity.HasKey(e => new { e.PoolId, e.QuestId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pool_quest_save");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.PoolId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pool_id");

                entity.Property(e => e.QuestId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("quest_id");
            });

            modelBuilder.Entity<PvpstatsBattleground>(entity =>
            {
                entity.ToTable("pvpstats_battlegrounds");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.BracketId)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("bracket_id");

                entity.Property(e => e.Date)
                    .HasColumnType("datetime")
                    .HasColumnName("date");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.WinnerFaction)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("winner_faction");
            });

            modelBuilder.Entity<PvpstatsPlayer>(entity =>
            {
                entity.HasKey(e => new { e.BattlegroundId, e.CharacterGuid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("pvpstats_players");

                entity.Property(e => e.BattlegroundId)
                    .HasColumnType("bigint(20) unsigned")
                    .HasColumnName("battleground_id");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("character_guid");

                entity.Property(e => e.Attr1)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_1")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attr2)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_2")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attr3)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_3")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attr4)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_4")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Attr5)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("attr_5")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.ScoreBonusHonor)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_bonus_honor");

                entity.Property(e => e.ScoreDamageDone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_damage_done");

                entity.Property(e => e.ScoreDeaths)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_deaths");

                entity.Property(e => e.ScoreHealingDone)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_healing_done");

                entity.Property(e => e.ScoreHonorableKills)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_honorable_kills");

                entity.Property(e => e.ScoreKillingBlows)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("score_killing_blows");

                entity.Property(e => e.Winner)
                    .HasColumnType("bit(1)")
                    .HasColumnName("winner");
            });

            modelBuilder.Entity<QuestTracker>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("quest_tracker");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("character_guid");

                entity.Property(e => e.CompletedByGm)
                    .HasColumnType("tinyint(4)")
                    .HasColumnName("completed_by_gm");

                entity.Property(e => e.CoreHash)
                    .HasMaxLength(120)
                    .HasColumnName("core_hash")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.CoreRevision)
                    .HasMaxLength(120)
                    .HasColumnName("core_revision")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Id)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasColumnName("id")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.QuestAbandonTime)
                    .HasColumnType("datetime")
                    .HasColumnName("quest_abandon_time");

                entity.Property(e => e.QuestAcceptTime)
                    .HasColumnType("datetime")
                    .HasColumnName("quest_accept_time");

                entity.Property(e => e.QuestCompleteTime)
                    .HasColumnType("datetime")
                    .HasColumnName("quest_complete_time");
            });

            modelBuilder.Entity<RecoveryItem>(entity =>
            {
                entity.ToTable("recovery_item");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Guid, "idx_guid");

                entity.Property(e => e.Id).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Count).HasColumnType("int(10) unsigned");

                entity.Property(e => e.Guid).HasColumnType("int(10) unsigned");

                entity.Property(e => e.ItemEntry)
                    .HasColumnType("mediumint(8) unsigned")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<ReservedName>(entity =>
            {
                entity.HasKey(e => e.Name)
                    .HasName("PRIMARY");

                entity.ToTable("reserved_name");

                entity.HasComment("Player Reserved Names")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Name)
                    .HasMaxLength(12)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");
            });

            modelBuilder.Entity<TemplateNpcAlliance>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("template_npc_alliance");

                entity.HasComment("Templates")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BonusEnchant)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bonusEnchant");

                entity.Property(e => e.Enchant)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("enchant");

                entity.Property(e => e.ItemEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("itemEntry");

                entity.Property(e => e.PlayerClass)
                    .HasMaxLength(50)
                    .HasColumnName("playerClass");

                entity.Property(e => e.PlayerSpec)
                    .HasMaxLength(50)
                    .HasColumnName("playerSpec");

                entity.Property(e => e.Pos)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pos");

                entity.Property(e => e.PrismaticEnchant)
                    .HasColumnType("int(10)")
                    .HasColumnName("prismaticEnchant");

                entity.Property(e => e.Socket1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket1");

                entity.Property(e => e.Socket2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket2");

                entity.Property(e => e.Socket3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket3");
            });

            modelBuilder.Entity<TemplateNpcGlyph>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("template_npc_glyphs");

                entity.HasComment("Templates")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Glyph)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("glyph");

                entity.Property(e => e.PlayerClass)
                    .HasMaxLength(50)
                    .HasColumnName("playerClass");

                entity.Property(e => e.PlayerSpec)
                    .HasMaxLength(50)
                    .HasColumnName("playerSpec");

                entity.Property(e => e.Slot)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("slot");
            });

            modelBuilder.Entity<TemplateNpcHorde>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("template_npc_horde");

                entity.HasComment("Templates")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BonusEnchant)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bonusEnchant");

                entity.Property(e => e.Enchant)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("enchant");

                entity.Property(e => e.ItemEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("itemEntry");

                entity.Property(e => e.PlayerClass)
                    .HasMaxLength(50)
                    .HasColumnName("playerClass");

                entity.Property(e => e.PlayerSpec)
                    .HasMaxLength(50)
                    .HasColumnName("playerSpec");

                entity.Property(e => e.Pos)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pos");

                entity.Property(e => e.PrismaticEnchant)
                    .HasColumnType("int(10)")
                    .HasColumnName("prismaticEnchant");

                entity.Property(e => e.Socket1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket1");

                entity.Property(e => e.Socket2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket2");

                entity.Property(e => e.Socket3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket3");
            });

            modelBuilder.Entity<TemplateNpcHuman>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("template_npc_human");

                entity.HasComment("Templates")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.BonusEnchant)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bonusEnchant");

                entity.Property(e => e.Enchant)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("enchant");

                entity.Property(e => e.ItemEntry)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("itemEntry");

                entity.Property(e => e.PlayerClass)
                    .HasMaxLength(50)
                    .HasColumnName("playerClass");

                entity.Property(e => e.PlayerSpec)
                    .HasMaxLength(50)
                    .HasColumnName("playerSpec");

                entity.Property(e => e.Pos)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("pos");

                entity.Property(e => e.PrismaticEnchant)
                    .HasColumnType("int(10)")
                    .HasColumnName("prismaticEnchant");

                entity.Property(e => e.Socket1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket1");

                entity.Property(e => e.Socket2)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket2");

                entity.Property(e => e.Socket3)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("socket3");
            });

            modelBuilder.Entity<TemplateNpcTalent>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("template_npc_talents");

                entity.HasComment("Templates")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.PlayerClass)
                    .HasMaxLength(50)
                    .HasColumnName("playerClass");

                entity.Property(e => e.PlayerSpec)
                    .HasMaxLength(50)
                    .HasColumnName("playerSpec");

                entity.Property(e => e.TalentId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("talentId");
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
                    .HasColumnType("enum('RELEASED','ARCHIVED','CUSTOM')")
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

            modelBuilder.Entity<VersionDbCharacter>(entity =>
            {
                entity.HasKey(e => e.SqlRev)
                    .HasName("PRIMARY");

                entity.ToTable("version_db_characters");

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

                entity.Property(e => e._2021101400)
                    .HasColumnType("bit(1)")
                    .HasColumnName("2021_10_14_00");

                entity.HasOne(d => d.RequiredRevNavigation)
                    .WithMany(p => p.InverseRequiredRevNavigation)
                    .HasForeignKey(d => d.RequiredRev)
                    .HasConstraintName("required");
            });

            modelBuilder.Entity<WardenAction>(entity =>
            {
                entity.HasKey(e => e.WardenId)
                    .HasName("PRIMARY");

                entity.ToTable("warden_action");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.WardenId)
                    .HasColumnType("smallint(5) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("wardenId");

                entity.Property(e => e.Action)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("action");
            });

            modelBuilder.Entity<Worldstate>(entity =>
            {
                entity.HasKey(e => e.Entry)
                    .HasName("PRIMARY");

                entity.ToTable("worldstates");

                entity.HasComment("Variable Saves")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Entry)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("entry");

                entity.Property(e => e.Comment)
                    .HasColumnType("tinytext")
                    .HasColumnName("comment");

                entity.Property(e => e.Value)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("value");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
