﻿using Microsoft.AspNet.Identity.EntityFramework;
using SaglikUrunleri.Entity.Identity;
using SaglikUrunleri.Entity.Entity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

namespace SaglikUrunleri.DAL.Context
{
    public class SaglikContext : IdentityDbContext<ApplicationUser>
    {
        public SaglikContext() : base("SaglikContext")
        {
            Database.SetInitializer(new MigrateDatabaseToLatestVersion<SaglikContext, Migrations.Configuration>("SaglikContext"));
        }
        public virtual DbSet<Kategori> Kategoriler { get; set; }
        public virtual DbSet<AltKategori> AltKategoriler { get; set; }
        public virtual DbSet<Urun> Urunler { get; set; }
        public virtual DbSet<Satis> Satislar { get; set; }
        public virtual DbSet<SatisDetay> SatisDetaylar { get; set; }
        public virtual DbSet<Uye> Uyeler { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<AltKategori>()
                .HasRequired<Kategori>(x => x.Kategori)
                .WithMany(x => x.AltKategoriler)
                .HasForeignKey(x => x.kategoriId)
                .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
               .HasRequired<Kategori>(x => x.Kategori)
               .WithMany(x => x.Urunler)
               .HasForeignKey(x => x.kategoriId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Urun>()
               .HasRequired<AltKategori>(x => x.AltKategori)
               .WithMany(x => x.Urunler)
               .HasForeignKey(x => x.altkategoriId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<SatisDetay>()
               .HasRequired<Satis>(x => x.Satis)
               .WithMany(x => x.SatisDetaylar)
               .HasForeignKey(x => x.satisId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<SatisDetay>()
               .HasRequired<Urun>(x => x.Urun)
               .WithMany(x => x.SatisDetaylar)
               .HasForeignKey(x => x.urunId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Satis>()
               .HasRequired<Uye>(x => x.Uye)
               .WithMany(x => x.Satislar)
               .HasForeignKey(x => x.uyeId)
               .WillCascadeOnDelete(false);

            modelBuilder.Entity<Uye>()
              .Property(x => x.UserId)
              .IsOptional();

            base.OnModelCreating(modelBuilder);
        }
    }
}
