using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AzerothAPI.Data.Models.Auth;

namespace AzerothAPI.Data.Context
{
    public partial class AuthDb : DbContext
    {
        public AuthDb()
        {
        }

        public AuthDb(DbContextOptions<AuthDb> options)
            : base(options)
        {
        }

        public virtual DbSet<Account> Accounts { get; set; } = null!;
        public virtual DbSet<AccountAccess> AccountAccesses { get; set; } = null!;
        public virtual DbSet<AccountBanned> AccountBanneds { get; set; } = null!;
        public virtual DbSet<AccountInformation> AccountInformations { get; set; } = null!;
        public virtual DbSet<AccountMuted> AccountMuteds { get; set; } = null!;
        public virtual DbSet<AccountPassword> AccountPasswords { get; set; } = null!;
        public virtual DbSet<Autobroadcast> Autobroadcasts { get; set; } = null!;
        public virtual DbSet<BuildInfo> BuildInfos { get; set; } = null!;
        public virtual DbSet<IpBanned> IpBanneds { get; set; } = null!;
        public virtual DbSet<Log> Logs { get; set; } = null!;
        public virtual DbSet<LogsIpAction> LogsIpActions { get; set; } = null!;
        public virtual DbSet<Realmcharacter> Realmcharacters { get; set; } = null!;
        public virtual DbSet<Realmlist> Realmlists { get; set; } = null!;
        public virtual DbSet<SecretDigest> SecretDigests { get; set; } = null!;
        public virtual DbSet<Update> Updates { get; set; } = null!;
        public virtual DbSet<UpdatesInclude> UpdatesIncludes { get; set; } = null!;
        public virtual DbSet<Uptime> Uptimes { get; set; } = null!;
        public virtual DbSet<VersionDbAuth> VersionDbAuths { get; set; } = null!;
        public virtual DbSet<Vote> Votes { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=ConnectionStrings:auth_database", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.4-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");

            modelBuilder.Entity<Account>(entity =>
            {
                entity.ToTable("account");

                entity.HasComment("Account System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Username, "idx_username")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id")
                    .HasComment("Identifier");

                entity.Property(e => e.Email)
                    .HasMaxLength(255)
                    .HasColumnName("email")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Expansion)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("expansion")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.FailedLogins)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("failed_logins");

                entity.Property(e => e.Joindate)
                    .HasColumnType("timestamp")
                    .HasColumnName("joindate")
                    .HasDefaultValueSql("current_timestamp()");

                entity.Property(e => e.LastAttemptIp)
                    .HasMaxLength(15)
                    .HasColumnName("last_attempt_ip")
                    .HasDefaultValueSql("'127.0.0.1'");

                entity.Property(e => e.LastIp)
                    .HasMaxLength(15)
                    .HasColumnName("last_ip")
                    .HasDefaultValueSql("'127.0.0.1'");

                entity.Property(e => e.LastLogin)
                    .HasColumnType("timestamp")
                    .HasColumnName("last_login");

                entity.Property(e => e.Locale)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("locale");

                entity.Property(e => e.LockCountry)
                    .HasMaxLength(2)
                    .HasColumnName("lock_country")
                    .HasDefaultValueSql("'00'");

                entity.Property(e => e.Locked)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("locked");

                entity.Property(e => e.Muteby)
                    .HasMaxLength(50)
                    .HasColumnName("muteby")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Mutereason)
                    .HasMaxLength(255)
                    .HasColumnName("mutereason")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Mutetime)
                    .HasColumnType("bigint(20)")
                    .HasColumnName("mutetime");

                entity.Property(e => e.Online)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("online");

                entity.Property(e => e.Os)
                    .HasMaxLength(3)
                    .HasColumnName("os")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Recruiter)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("recruiter");

                entity.Property(e => e.RegMail)
                    .HasMaxLength(255)
                    .HasColumnName("reg_mail")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.RestoreKey)
                    .HasMaxLength(255)
                    .HasColumnName("restore_key")
                    .HasDefaultValueSql("'1'");

                entity.Property(e => e.Salt)
                    .HasMaxLength(32)
                    .HasColumnName("salt")
                    .IsFixedLength();

                entity.Property(e => e.SessionKey)
                    .HasMaxLength(40)
                    .HasColumnName("session_key")
                    .IsFixedLength();

                entity.Property(e => e.Totaltime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("totaltime");

                entity.Property(e => e.TotpSecret)
                    .HasMaxLength(128)
                    .HasColumnName("totp_secret");

                entity.Property(e => e.Username)
                    .HasMaxLength(32)
                    .HasColumnName("username")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Verifier)
                    .HasMaxLength(32)
                    .HasColumnName("verifier")
                    .IsFixedLength();

                entity.Property(e => e.VotePoints)
                    .HasMaxLength(255)
                    .HasColumnName("votePoints")
                    .HasDefaultValueSql("'0'");
            });

            modelBuilder.Entity<AccountAccess>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.RealmId })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account_access");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.RealmId)
                    .HasColumnType("int(11)")
                    .HasColumnName("RealmID")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Comment)
                    .HasMaxLength(255)
                    .HasColumnName("comment")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Gmlevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("gmlevel");
            });

            modelBuilder.Entity<AccountBanned>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Bandate })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account_banned");

                entity.HasComment("Ban List")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id")
                    .HasComment("Account id");

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

            modelBuilder.Entity<AccountInformation>(entity =>
            {
                entity.ToTable("account_information");

                entity.HasIndex(e => e.Phone, "IDX_19b31e1188eece5a17213c09f5")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Coins)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("coins");

                entity.Property(e => e.FirstName)
                    .HasMaxLength(50)
                    .HasColumnName("first_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.LastName)
                    .HasMaxLength(50)
                    .HasColumnName("last_name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Phone)
                    .HasMaxLength(25)
                    .HasColumnName("phone")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Points)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("points");
            });

            modelBuilder.Entity<AccountMuted>(entity =>
            {
                entity.HasKey(e => new { e.Guid, e.Mutedate })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("account_muted");

                entity.HasComment("mute List")
                    .HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Guid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("guid")
                    .HasComment("Global Unique Identifier");

                entity.Property(e => e.Mutedate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mutedate");

                entity.Property(e => e.Mutedby)
                    .HasMaxLength(50)
                    .HasColumnName("mutedby");

                entity.Property(e => e.Mutereason)
                    .HasMaxLength(255)
                    .HasColumnName("mutereason");

                entity.Property(e => e.Mutetime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("mutetime");
            });

            modelBuilder.Entity<AccountPassword>(entity =>
            {
                entity.ToTable("account_password");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.PasswordChangedAt)
                    .HasColumnType("timestamp")
                    .HasColumnName("password_changed_at");

                entity.Property(e => e.PasswordResetExpires)
                    .HasColumnType("timestamp")
                    .HasColumnName("password_reset_expires");

                entity.Property(e => e.PasswordResetToken)
                    .HasMaxLength(255)
                    .HasColumnName("password_reset_token")
                    .UseCollation("utf8mb3_general_ci")
                    .HasCharSet("utf8mb3");
            });

            modelBuilder.Entity<Autobroadcast>(entity =>
            {
                entity.HasKey(e => new { e.Id, e.Realmid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("autobroadcast");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("tinyint(3) unsigned")
                    .ValueGeneratedOnAdd()
                    .HasColumnName("id");

                entity.Property(e => e.Realmid)
                    .HasColumnType("int(11)")
                    .HasColumnName("realmid")
                    .HasDefaultValueSql("-1");

                entity.Property(e => e.Text).HasColumnName("text");

                entity.Property(e => e.Weight)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("weight")
                    .HasDefaultValueSql("'1'");
            });

            modelBuilder.Entity<BuildInfo>(entity =>
            {
                entity.HasKey(e => e.Build)
                    .HasName("PRIMARY");

                entity.ToTable("build_info");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Build)
                    .HasColumnType("int(11)")
                    .ValueGeneratedNever()
                    .HasColumnName("build");

                entity.Property(e => e.BugfixVersion)
                    .HasColumnType("int(11)")
                    .HasColumnName("bugfixVersion");

                entity.Property(e => e.HotfixVersion)
                    .HasMaxLength(3)
                    .HasColumnName("hotfixVersion")
                    .IsFixedLength();

                entity.Property(e => e.Mac64AuthSeed)
                    .HasMaxLength(32)
                    .HasColumnName("mac64AuthSeed");

                entity.Property(e => e.MacChecksumSeed)
                    .HasMaxLength(40)
                    .HasColumnName("macChecksumSeed");

                entity.Property(e => e.MajorVersion)
                    .HasColumnType("int(11)")
                    .HasColumnName("majorVersion");

                entity.Property(e => e.MinorVersion)
                    .HasColumnType("int(11)")
                    .HasColumnName("minorVersion");

                entity.Property(e => e.Win64AuthSeed)
                    .HasMaxLength(32)
                    .HasColumnName("win64AuthSeed");

                entity.Property(e => e.WinAuthSeed)
                    .HasMaxLength(32)
                    .HasColumnName("winAuthSeed");

                entity.Property(e => e.WinChecksumSeed)
                    .HasMaxLength(40)
                    .HasColumnName("winChecksumSeed");
            });

            modelBuilder.Entity<IpBanned>(entity =>
            {
                entity.HasKey(e => new { e.Ip, e.Bandate })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("ip_banned");

                entity.HasComment("Banned IPs")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("ip")
                    .HasDefaultValueSql("'127.0.0.1'");

                entity.Property(e => e.Bandate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("bandate");

                entity.Property(e => e.Bannedby)
                    .HasMaxLength(50)
                    .HasColumnName("bannedby")
                    .HasDefaultValueSql("'[Console]'");

                entity.Property(e => e.Banreason)
                    .HasMaxLength(255)
                    .HasColumnName("banreason")
                    .HasDefaultValueSql("'no reason'");

                entity.Property(e => e.Unbandate)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("unbandate");
            });

            modelBuilder.Entity<Log>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("logs");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Level)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("level");

                entity.Property(e => e.Realm)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("realm");

                entity.Property(e => e.String)
                    .HasColumnType("text")
                    .HasColumnName("string");

                entity.Property(e => e.Time)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("time");

                entity.Property(e => e.Type)
                    .HasMaxLength(250)
                    .HasColumnName("type");
            });

            modelBuilder.Entity<LogsIpAction>(entity =>
            {
                entity.ToTable("logs_ip_actions");

                entity.HasComment("Used to log ips of individual actions")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id")
                    .HasComment("Unique Identifier");

                entity.Property(e => e.AccountId)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("account_id")
                    .HasComment("Account ID");

                entity.Property(e => e.CharacterGuid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("character_guid")
                    .HasComment("Character Guid");

                entity.Property(e => e.Comment)
                    .HasColumnType("text")
                    .HasColumnName("comment")
                    .HasComment("Allows users to add a comment");

                entity.Property(e => e.Ip)
                    .HasMaxLength(15)
                    .HasColumnName("ip")
                    .HasDefaultValueSql("'127.0.0.1'");

                entity.Property(e => e.Systemnote)
                    .HasColumnType("text")
                    .HasColumnName("systemnote")
                    .HasComment("Notes inserted by system");

                entity.Property(e => e.Time)
                    .HasColumnType("timestamp")
                    .HasColumnName("time")
                    .HasDefaultValueSql("current_timestamp()")
                    .HasComment("Timestamp");

                entity.Property(e => e.Type)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("type");

                entity.Property(e => e.Unixtime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("unixtime")
                    .HasComment("Unixtime");
            });

            modelBuilder.Entity<Realmcharacter>(entity =>
            {
                entity.HasKey(e => new { e.Realmid, e.Acctid })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("realmcharacters");

                entity.HasComment("Realm Character Tracker")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Acctid, "acctid");

                entity.Property(e => e.Realmid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("realmid");

                entity.Property(e => e.Acctid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("acctid");

                entity.Property(e => e.Numchars)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("numchars");
            });

            modelBuilder.Entity<Realmlist>(entity =>
            {
                entity.ToTable("realmlist");

                entity.HasComment("Realm System")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.HasIndex(e => e.Name, "idx_name")
                    .IsUnique();

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("id");

                entity.Property(e => e.Address)
                    .HasMaxLength(255)
                    .HasColumnName("address")
                    .HasDefaultValueSql("'127.0.0.1'");

                entity.Property(e => e.AllowedSecurityLevel)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("allowedSecurityLevel");

                entity.Property(e => e.Flag)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("flag")
                    .HasDefaultValueSql("'2'");

                entity.Property(e => e.Gamebuild)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("gamebuild")
                    .HasDefaultValueSql("'12340'");

                entity.Property(e => e.Icon)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("icon");

                entity.Property(e => e.LocalAddress)
                    .HasMaxLength(255)
                    .HasColumnName("localAddress")
                    .HasDefaultValueSql("'127.0.0.1'");

                entity.Property(e => e.LocalSubnetMask)
                    .HasMaxLength(255)
                    .HasColumnName("localSubnetMask")
                    .HasDefaultValueSql("'255.255.255.0'");

                entity.Property(e => e.Name)
                    .HasMaxLength(32)
                    .HasColumnName("name")
                    .HasDefaultValueSql("''");

                entity.Property(e => e.Population).HasColumnName("population");

                entity.Property(e => e.Port)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("port")
                    .HasDefaultValueSql("'8085'");

                entity.Property(e => e.Timezone)
                    .HasColumnType("tinyint(3) unsigned")
                    .HasColumnName("timezone");
            });

            modelBuilder.Entity<SecretDigest>(entity =>
            {
                entity.ToTable("secret_digest");

                entity.HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("int(10) unsigned")
                    .ValueGeneratedNever()
                    .HasColumnName("id");

                entity.Property(e => e.Digest)
                    .HasMaxLength(100)
                    .HasColumnName("digest");
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

            modelBuilder.Entity<Uptime>(entity =>
            {
                entity.HasKey(e => new { e.Realmid, e.Starttime })
                    .HasName("PRIMARY")
                    .HasAnnotation("MySql:IndexPrefixLength", new[] { 0, 0 });

                entity.ToTable("uptime");

                entity.HasComment("Uptime system")
                    .HasCharSet("utf8mb4")
                    .UseCollation("utf8mb4_unicode_ci");

                entity.Property(e => e.Realmid)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("realmid");

                entity.Property(e => e.Starttime)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("starttime");

                entity.Property(e => e.Maxplayers)
                    .HasColumnType("smallint(5) unsigned")
                    .HasColumnName("maxplayers");

                entity.Property(e => e.Revision)
                    .HasMaxLength(255)
                    .HasColumnName("revision")
                    .HasDefaultValueSql("'AzerothCore'");

                entity.Property(e => e.Uptime1)
                    .HasColumnType("int(10) unsigned")
                    .HasColumnName("uptime");
            });

            modelBuilder.Entity<VersionDbAuth>(entity =>
            {
                entity.HasKey(e => e.SqlRev)
                    .HasName("PRIMARY");

                entity.ToTable("version_db_auth");

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

            modelBuilder.Entity<Vote>(entity =>
            {
                entity.ToTable("votes");

                entity.HasCharSet("utf8mb3")
                    .UseCollation("utf8mb3_general_ci");

                entity.Property(e => e.Id)
                    .HasColumnType("bigint(255)")
                    .HasColumnName("id");

                entity.Property(e => e.Accountid)
                    .HasColumnType("bigint(255)")
                    .HasColumnName("accountid")
                    .HasDefaultValueSql("'0'");

                entity.Property(e => e.Done)
                    .HasColumnType("int(10)")
                    .HasColumnName("done");

                entity.Property(e => e.Ip)
                    .HasMaxLength(255)
                    .HasColumnName("ip");

                entity.Property(e => e.VoteSite)
                    .HasMaxLength(255)
                    .HasColumnName("vote_site");

                entity.Property(e => e.Votedate)
                    .HasColumnType("timestamp")
                    .HasColumnName("votedate")
                    .HasDefaultValueSql("current_timestamp()");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
