using System.Data.Entity.ModelConfiguration;
using DynamicSite.Entidades;

namespace DynamicSite.Infra.Configuration
{
    public class CategoriaConfigurarion : EntityTypeConfiguration<Categoria>
    {
        public CategoriaConfigurarion()
        {
            ToTable("Categoria");
            HasKey<long>(p => p.Id);

            Property(p => p.Id).HasColumnName("IdCategoria").IsRequired();

            Property(p => p.Nome).HasColumnName("Nome").HasColumnType("VarChar").HasMaxLength(50).IsRequired();

            Property(p => p.Ordem).HasColumnName("Ordem").HasColumnType("int").IsOptional();
         
            Property(p => p.UrlAmigavel).HasMaxLength(100).HasColumnType("VarChar").HasColumnName("URL_Amigavel").IsRequired();

            HasMany<Categoria>(p => p.SubCategorias)
                .WithOptional()
                .HasForeignKey(p => p.IdCategoriaPai);

        }
    }
}
