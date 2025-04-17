namespace LigaTabajara.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class NomeDaMigration : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Times", "Nome", c => c.String(nullable: false));
            AlterColumn("dbo.Times", "Cidade", c => c.String(nullable: false));
            AlterColumn("dbo.Times", "Estado", c => c.String(nullable: false));
            AlterColumn("dbo.Times", "Estadio", c => c.String(nullable: false));
            AlterColumn("dbo.Jogadors", "Name", c => c.String(nullable: false));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Jogadors", "Name", c => c.String());
            AlterColumn("dbo.Times", "Estadio", c => c.String());
            AlterColumn("dbo.Times", "Estado", c => c.String());
            AlterColumn("dbo.Times", "Cidade", c => c.String());
            AlterColumn("dbo.Times", "Nome", c => c.String());
        }
    }
}
