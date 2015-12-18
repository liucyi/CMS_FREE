using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using DynamicSite.Entidades;


namespace DynamicSite.Infra.Configuration
{
    public class MenuConfiguration : EntityTypeConfiguration<Menu>
    {
        public MenuConfiguration()
        {
            ToTable("Menu");
            HasKey<long>(p => p.Id);


            Property(p => p.Id).HasColumnName("IdMenu").IsRequired();

            Property(p => p.Nome).HasColumnName("Nome").HasColumnType("VarChar").HasMaxLength(100).IsRequired();

            Property(p => p.Ordem).HasColumnName("Ordem").HasColumnType("int").IsOptional();

            Property(p=> p.UrlAmigavel).HasColumnName("URL_Amigavel").HasColumnType("VarChar").HasMaxLength(50).IsRequired();

            Property(p => p.IdMenuPai).HasColumnName("IdMenuPai").HasColumnType("bigint").IsOptional();

            HasMany<Menu>(p => p.SubMenus)
                .WithOptional()
                .HasForeignKey(p => p.IdMenuPai);

        }

    }
}
