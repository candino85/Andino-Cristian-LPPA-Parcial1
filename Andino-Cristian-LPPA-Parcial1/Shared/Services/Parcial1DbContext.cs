using Andino_Cristian_LPPA_Parcial1.Shared.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Andino_Cristian_LPPA_Parcial1.Shared.Services
{
    public class Parcial1DbContext : DbContext
    {
        public DbSet<Afiliados> Afiliados { get; set; }

        public Parcial1DbContext() : base("DefaultConnection")
        {
        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }
    }
}