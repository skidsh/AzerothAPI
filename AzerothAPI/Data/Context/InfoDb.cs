using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using AzerothAPI.Data.Models.dbc;

namespace AzerothAPI.Data.Context
{
    public partial class InfoDb : DbContext
    {
        public InfoDb()
        {
        }

        public InfoDb(DbContextOptions<InfoDb> options)
            : base(options)
        {
        }

        public virtual DbSet<TalentDbc> TalentDbcs { get; set; } = null!;
        public virtual DbSet<TalenttabDbc> TalenttabDbcs { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseMySql("name=info_database", Microsoft.EntityFrameworkCore.ServerVersion.Parse("10.6.4-mariadb"));
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.UseCollation("latin1_swedish_ci")
                .HasCharSet("latin1");

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

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
