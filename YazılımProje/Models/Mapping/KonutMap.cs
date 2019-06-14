using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace YazılımProje.Models.Mapping
{
    public class KonutMap : EntityTypeConfiguration<Konut>
    {
        public KonutMap()
        {
            // Primary Key
            this.HasKey(t => t.KonutId);

            // Properties
            this.Property(t => t.adres)
                .HasMaxLength(300);

            this.Property(t => t.baslik)
                .HasMaxLength(100);

            this.Property(t => t.kucukResim)
                .HasMaxLength(100);

            // Table & Column Mappings
            this.ToTable("Konut");
            this.Property(t => t.KonutId).HasColumnName("KonutId");
            this.Property(t => t.kategori).HasColumnName("kategori");
            this.Property(t => t.sahipId).HasColumnName("sahipId");
            this.Property(t => t.metrekare).HasColumnName("metrekare");
            this.Property(t => t.fiyat).HasColumnName("fiyat");
            this.Property(t => t.depozito).HasColumnName("depozito");
            this.Property(t => t.il).HasColumnName("il");
            this.Property(t => t.ilce).HasColumnName("ilce");
            this.Property(t => t.adres).HasColumnName("adres");
            this.Property(t => t.yasi).HasColumnName("yasi");
            this.Property(t => t.isitmaTuru).HasColumnName("isitmaTuru");
            this.Property(t => t.katSayisi).HasColumnName("katSayisi");
            this.Property(t => t.bulunduguKat).HasColumnName("bulunduguKat");
            this.Property(t => t.konutTuru).HasColumnName("konutTuru");
            this.Property(t => t.odaSayisi).HasColumnName("odaSayisi");
            this.Property(t => t.ilanTarihi).HasColumnName("ilanTarihi");
            this.Property(t => t.aktif).HasColumnName("aktif");
            this.Property(t => t.baslik).HasColumnName("baslik");
            this.Property(t => t.esyaDurumu).HasColumnName("esyaDurumu");
            this.Property(t => t.aciklama).HasColumnName("aciklama");
            this.Property(t => t.kucukResim).HasColumnName("kucukResim");

            // Relationships
            this.HasOptional(t => t.bulunduguKat1)
                .WithMany(t => t.Konuts)
                .HasForeignKey(d => d.bulunduguKat);
            this.HasOptional(t => t.ilceler)
                .WithMany(t => t.Konuts)
                .HasForeignKey(d => d.ilce);
            this.HasOptional(t => t.iller)
                .WithMany(t => t.Konuts)
                .HasForeignKey(d => d.il);
            this.HasOptional(t => t.isitmaTuru1)
                .WithMany(t => t.Konuts)
                .HasForeignKey(d => d.isitmaTuru);
            this.HasOptional(t => t.KonutTuru1)
                .WithMany(t => t.Konuts)
                .HasForeignKey(d => d.konutTuru);
            this.HasOptional(t => t.Kullanici)
                .WithMany(t => t.Konuts)
                .HasForeignKey(d => d.sahipId);
            this.HasOptional(t => t.odaSayisi1)
                .WithMany(t => t.Konuts)
                .HasForeignKey(d => d.odaSayisi);

        }
    }
}
