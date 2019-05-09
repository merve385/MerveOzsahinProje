namespace SaglikUrunleri.DAL.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.AltKategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        AltKategoriAd = c.String(nullable: false, maxLength: 50),
                        kategoriId = c.Int(nullable: false),
                        Aciklama = c.String(),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Kategoriler", t => t.kategoriId)
                .Index(t => t.kategoriId);
            
            CreateTable(
                "dbo.Kategoriler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        KategoriAd = c.String(),
                        Aciklama = c.String(),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Urunler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        urunKodu = c.String(nullable: false, maxLength: 20),
                        urunAd = c.String(nullable: false, maxLength: 50),
                        kategoriId = c.Int(nullable: false),
                        altkategoriId = c.Int(nullable: false),
                        miktar = c.Int(nullable: false),
                        kritikSeviye = c.Int(nullable: false),
                        urunFiyat = c.Decimal(nullable: false, storeType: "money"),
                        urunBilgisi = c.String(),
                        urunResimYolu1 = c.String(maxLength: 100),
                        urunResimYolu2 = c.String(maxLength: 100),
                        indirim = c.Boolean(nullable: false),
                        indirimOrani = c.Int(nullable: false),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AltKategoriler", t => t.altkategoriId)
                .ForeignKey("dbo.Kategoriler", t => t.kategoriId)
                .Index(t => t.kategoriId)
                .Index(t => t.altkategoriId);
            
            CreateTable(
                "dbo.SatisDetaylar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        satisId = c.Int(nullable: false),
                        urunId = c.Int(nullable: false),
                        adet = c.Int(nullable: false),
                        birimFiyat = c.Decimal(nullable: false, storeType: "money"),
                        tutar = c.Decimal(nullable: false, storeType: "money"),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Satislar", t => t.satisId)
                .ForeignKey("dbo.Urunler", t => t.urunId)
                .Index(t => t.satisId)
                .Index(t => t.urunId);
            
            CreateTable(
                "dbo.Satislar",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Tarih = c.DateTime(nullable: false),
                        uyeId = c.Int(nullable: false),
                        toplamMiktar = c.Int(nullable: false),
                        toplamTutar = c.Decimal(nullable: false, storeType: "money"),
                        teslimTarihi = c.DateTime(nullable: false),
                        durumu = c.Byte(nullable: false),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Uyeler", t => t.uyeId)
                .Index(t => t.uyeId);
            
            CreateTable(
                "dbo.Uyeler",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        ad = c.String(nullable: false, maxLength: 30),
                        soyad = c.String(nullable: false, maxLength: 30),
                        tckno = c.String(nullable: false, maxLength: 11),
                        adres = c.String(),
                        ilce = c.String(maxLength: 30),
                        il = c.String(maxLength: 30),
                        UserId = c.String(),
                        Silindi = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.AspNetRoles",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Name = c.String(nullable: false, maxLength: 256),
                        Description = c.String(maxLength: 200),
                        Discriminator = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.Name, unique: true, name: "RoleNameIndex");
            
            CreateTable(
                "dbo.AspNetUserRoles",
                c => new
                    {
                        UserId = c.String(nullable: false, maxLength: 128),
                        RoleId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.UserId, t.RoleId })
                .ForeignKey("dbo.AspNetRoles", t => t.RoleId, cascadeDelete: true)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId)
                .Index(t => t.RoleId);
            
            CreateTable(
                "dbo.AspNetUsers",
                c => new
                    {
                        Id = c.String(nullable: false, maxLength: 128),
                        Tarih = c.DateTime(nullable: false),
                        Email = c.String(maxLength: 256),
                        EmailConfirmed = c.Boolean(nullable: false),
                        PasswordHash = c.String(),
                        SecurityStamp = c.String(),
                        PhoneNumber = c.String(),
                        PhoneNumberConfirmed = c.Boolean(nullable: false),
                        TwoFactorEnabled = c.Boolean(nullable: false),
                        LockoutEndDateUtc = c.DateTime(),
                        LockoutEnabled = c.Boolean(nullable: false),
                        AccessFailedCount = c.Int(nullable: false),
                        UserName = c.String(nullable: false, maxLength: 256),
                    })
                .PrimaryKey(t => t.Id)
                .Index(t => t.UserName, unique: true, name: "UserNameIndex");
            
            CreateTable(
                "dbo.AspNetUserClaims",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        UserId = c.String(nullable: false, maxLength: 128),
                        ClaimType = c.String(),
                        ClaimValue = c.String(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
            CreateTable(
                "dbo.AspNetUserLogins",
                c => new
                    {
                        LoginProvider = c.String(nullable: false, maxLength: 128),
                        ProviderKey = c.String(nullable: false, maxLength: 128),
                        UserId = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.LoginProvider, t.ProviderKey, t.UserId })
                .ForeignKey("dbo.AspNetUsers", t => t.UserId, cascadeDelete: true)
                .Index(t => t.UserId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.AspNetUserRoles", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserLogins", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserClaims", "UserId", "dbo.AspNetUsers");
            DropForeignKey("dbo.AspNetUserRoles", "RoleId", "dbo.AspNetRoles");
            DropForeignKey("dbo.AltKategoriler", "kategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.SatisDetaylar", "urunId", "dbo.Urunler");
            DropForeignKey("dbo.SatisDetaylar", "satisId", "dbo.Satislar");
            DropForeignKey("dbo.Satislar", "uyeId", "dbo.Uyeler");
            DropForeignKey("dbo.Urunler", "kategoriId", "dbo.Kategoriler");
            DropForeignKey("dbo.Urunler", "altkategoriId", "dbo.AltKategoriler");
            DropIndex("dbo.AspNetUserLogins", new[] { "UserId" });
            DropIndex("dbo.AspNetUserClaims", new[] { "UserId" });
            DropIndex("dbo.AspNetUsers", "UserNameIndex");
            DropIndex("dbo.AspNetUserRoles", new[] { "RoleId" });
            DropIndex("dbo.AspNetUserRoles", new[] { "UserId" });
            DropIndex("dbo.AspNetRoles", "RoleNameIndex");
            DropIndex("dbo.Satislar", new[] { "uyeId" });
            DropIndex("dbo.SatisDetaylar", new[] { "urunId" });
            DropIndex("dbo.SatisDetaylar", new[] { "satisId" });
            DropIndex("dbo.Urunler", new[] { "altkategoriId" });
            DropIndex("dbo.Urunler", new[] { "kategoriId" });
            DropIndex("dbo.AltKategoriler", new[] { "kategoriId" });
            DropTable("dbo.AspNetUserLogins");
            DropTable("dbo.AspNetUserClaims");
            DropTable("dbo.AspNetUsers");
            DropTable("dbo.AspNetUserRoles");
            DropTable("dbo.AspNetRoles");
            DropTable("dbo.Uyeler");
            DropTable("dbo.Satislar");
            DropTable("dbo.SatisDetaylar");
            DropTable("dbo.Urunler");
            DropTable("dbo.Kategoriler");
            DropTable("dbo.AltKategoriler");
        }
    }
}
