using System.Collections.Generic;
using System.Data.Entity;
using System.Configuration;
using System.Data.Entity.ModelConfiguration.Conventions;
using DynamicSite.Entidades;

namespace DynamicSite.Infra.Context
{
    public class MyDbContext : DbContext
    {

        public MyDbContext() : base(ConfigurationManager.ConnectionStrings["defaultConnection"].ConnectionString) { }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Configurations.Add(new Configuration.MenuConfiguration());
            modelBuilder.Configurations.Add(new Configuration.CategoriaConfigurarion());
            
            modelBuilder.Conventions.Remove<OneToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<ManyToManyCascadeDeleteConvention>();
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();           
        }


        public DbSet<Menu> Menus { get; set; }

        public DbSet<Categoria> Categorias { get; set; }

    }

}
