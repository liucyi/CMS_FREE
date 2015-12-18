namespace DynamicSite.Infra.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class firstMigration2 : DbMigration
    {
        public override void Up()
        {
            DropIndex("dbo.SubCategoria", new[] { "CategoriaBase_Id" });
            DropColumn("dbo.SubCategoria", "IdCategoria");
            RenameColumn(table: "dbo.Categoria", name: "Id", newName: "IdCategoria");
            RenameColumn(table: "dbo.Categoria", name: "UrlAmigavel", newName: "URL_Amigavel");
            RenameColumn(table: "dbo.SubCategoria", name: "Id", newName: "IdSubCategoria");
            RenameColumn(table: "dbo.SubCategoria", name: "UrlAmigavel", newName: "URL_Amigavel");
            RenameColumn(table: "dbo.SubCategoria", name: "CategoriaBase_Id", newName: "IdCategoria");
            AlterColumn("dbo.Categoria", "Nome", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.Categoria", "Ordem", c => c.Int());
            AlterColumn("dbo.Categoria", "URL_Amigavel", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.SubCategoria", "Nome", c => c.String(nullable: false, maxLength: 50, unicode: false));
            AlterColumn("dbo.SubCategoria", "Ordem", c => c.Int());
            AlterColumn("dbo.SubCategoria", "URL_Amigavel", c => c.String(nullable: false, maxLength: 100, unicode: false));
            AlterColumn("dbo.SubCategoria", "IdCategoria", c => c.Long(nullable: false));
            CreateIndex("dbo.SubCategoria", "IdCategoria");
        }
        
        public override void Down()
        {
            DropIndex("dbo.SubCategoria", new[] { "IdCategoria" });
            AlterColumn("dbo.SubCategoria", "IdCategoria", c => c.Long());
            AlterColumn("dbo.SubCategoria", "URL_Amigavel", c => c.String());
            AlterColumn("dbo.SubCategoria", "Ordem", c => c.Int(nullable: false));
            AlterColumn("dbo.SubCategoria", "Nome", c => c.String());
            AlterColumn("dbo.Categoria", "URL_Amigavel", c => c.String());
            AlterColumn("dbo.Categoria", "Ordem", c => c.Int(nullable: false));
            AlterColumn("dbo.Categoria", "Nome", c => c.String());
            RenameColumn(table: "dbo.SubCategoria", name: "IdCategoria", newName: "CategoriaBase_Id");
            RenameColumn(table: "dbo.SubCategoria", name: "URL_Amigavel", newName: "UrlAmigavel");
            RenameColumn(table: "dbo.SubCategoria", name: "IdSubCategoria", newName: "Id");
            RenameColumn(table: "dbo.Categoria", name: "URL_Amigavel", newName: "UrlAmigavel");
            RenameColumn(table: "dbo.Categoria", name: "IdCategoria", newName: "Id");
            AddColumn("dbo.SubCategoria", "IdCategoria", c => c.Long(nullable: false));
            CreateIndex("dbo.SubCategoria", "CategoriaBase_Id");
        }
    }
}
