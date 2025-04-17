namespace LigaTabajara.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRodadaPorPartida : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Partidas", "Round", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Partidas", "Round");
        }
    }
}
