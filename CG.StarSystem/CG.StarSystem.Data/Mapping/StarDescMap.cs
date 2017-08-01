using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace CG.StarSystem.Data.Models.Mapping
{
    public class StarDescMap : EntityTypeConfiguration<StarDesc>
    {
        public StarDescMap()
        {
            // Primary Key
            this.HasKey(t => t.Id);

            // Properties
            this.Property(t => t.Id)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.StarName)
                .HasMaxLength(150);

            this.Property(t => t.StarSize)
                .HasMaxLength(50);

            this.Property(t => t.StarDistanceFromSun)
                .HasMaxLength(50);

            this.Property(t => t.StarGalaxyName)
                .HasMaxLength(50);

            this.Property(t => t.StarBrightness)
                .HasMaxLength(50);

            this.Property(t => t.SpectralType)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("StarDesc");
            this.Property(t => t.Id).HasColumnName("Id");
            this.Property(t => t.StarName).HasColumnName("StarName");
            this.Property(t => t.StarSize).HasColumnName("StarSize");
            this.Property(t => t.StarDistanceFromSun).HasColumnName("StarDistanceFromSun");
            this.Property(t => t.StarGalaxyName).HasColumnName("StarGalaxyName");
            this.Property(t => t.StarBrightness).HasColumnName("StarBrightness");
            this.Property(t => t.SpectralType).HasColumnName("SpectralType");
        }
    }
}
