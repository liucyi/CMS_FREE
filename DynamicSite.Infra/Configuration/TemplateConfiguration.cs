using System.Data.Entity.ModelConfiguration;
using DynamicSite.Entidades;

namespace DynamicSite.Infra.Configuration
{
    public class TemplateConfiguration : EntityTypeConfiguration<Template>
    {
        public TemplateConfiguration()
        {
            ToTable("TemplateSMS");
            HasKey<long>(p => p.Id);
            Property(p => p.Id).HasColumnName("IdTemplate").IsRequired();
            Property(p => p.Nome).HasColumnType("VarChar").HasMaxLength(50).IsRequired();
            Property(p => p.PadraoSite).HasColumnName("DefaultTemplate").IsOptional();
            Property(p => p.Versao).HasPrecision(18, 10).IsOptional();
            Property(p => p.Autor).HasMaxLength(100).IsRequired();
            Property(p => p.DataCriacao).HasColumnType("DateTime").IsRequired();


        }
    }
}
