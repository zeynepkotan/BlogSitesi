namespace api.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Blog : DbContext
    {
        public Blog()
            : base("name=Blog")
        {
        }

        public virtual DbSet<etiket> etiket { get; set; }
        public virtual DbSet<kategori> kategori { get; set; }
        public virtual DbSet<makale> makale { get; set; }
        public virtual DbSet<uye> uye { get; set; }
        public virtual DbSet<yetki> yetki { get; set; }
        public virtual DbSet<yorum> yorum { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<etiket>()
                .Property(e => e.EtiketAdi)
                .IsUnicode(false);

            modelBuilder.Entity<kategori>()
                .Property(e => e.KategoriAdi)
                .IsUnicode(false);

            modelBuilder.Entity<makale>()
                .Property(e => e.Baslik)
                .IsUnicode(false);

            modelBuilder.Entity<makale>()
                .Property(e => e.Icerik)
                .IsUnicode(false);

            modelBuilder.Entity<makale>()
                .Property(e => e.Foto)
                .IsUnicode(false);

            modelBuilder.Entity<uye>()
                .Property(e => e.KullaniciAdi)
                .IsUnicode(false);

            modelBuilder.Entity<uye>()
                .Property(e => e.Email)
                .IsUnicode(false);

            modelBuilder.Entity<uye>()
                .Property(e => e.Sifre)
                .IsUnicode(false);

            modelBuilder.Entity<uye>()
                .Property(e => e.AdSoyad)
                .IsUnicode(false);

            modelBuilder.Entity<uye>()
                .Property(e => e.Foto)
                .IsUnicode(false);

            modelBuilder.Entity<yetki>()
                .Property(e => e.Yetki1)
                .IsUnicode(false);

            modelBuilder.Entity<yorum>()
                .Property(e => e.Icerik)
                .IsUnicode(false);
        }
    }
}
