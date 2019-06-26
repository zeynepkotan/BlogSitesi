namespace proje.Models
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class Makalee : DbContext
    {
        public Makalee()
            : base("name=Makalee")
        {
        }

        public virtual DbSet<kategori> kategori { get; set; }
        public virtual DbSet<makale> makale { get; set; }
        public virtual DbSet<yazar> yazar { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Entity<kategori>()
                .Property(e => e.ad)
                .IsUnicode(false);

            modelBuilder.Entity<makale>()
                .Property(e => e.baslik)
                .IsUnicode(false);

            modelBuilder.Entity<makale>()
                .Property(e => e.metin)
                .IsUnicode(false);

            modelBuilder.Entity<makale>()
                .Property(e => e.resimAdres)
                .IsUnicode(false);

            modelBuilder.Entity<makale>()
                .Property(e => e.eklendigiIp)
                .IsUnicode(false);

            modelBuilder.Entity<yazar>()
                .Property(e => e.ad)
                .IsUnicode(false);

            modelBuilder.Entity<yazar>()
                .Property(e => e.soyad)
                .IsUnicode(false);

            modelBuilder.Entity<yazar>()
                .Property(e => e.cinsiyet)
                .IsUnicode(false);
        }
    }
}
