using System.Data.Entity;
using CG.StarSystem.Data.Models.Mapping;

namespace CG.StarSystem.Data.Models
{
    public partial class StarSystemContext : DbContext
    {
        static StarSystemContext()
        {
            Database.SetInitializer<StarSystemContext>(null);
        }

        public StarSystemContext()
            : base("Name=StarSystemContext")
        {
        }

        public DbSet<SpectralClassesSubType> SpectralClassesSubTypes { get; set; }
        public DbSet<StarDesc> StarDescs { get; set; }
        public DbSet<StarTypeByLuminosityClass> StarTypeByLuminosityClasses { get; set; }
        public DbSet<StarTypeBySpectralClass> StarTypeBySpectralClasses { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new SpectralClassesSubTypeMap());
            modelBuilder.Configurations.Add(new StarDescMap());
            modelBuilder.Configurations.Add(new StarTypeByLuminosityClassMap());
            modelBuilder.Configurations.Add(new StarTypeBySpectralClassMap());
        }
    }
}
