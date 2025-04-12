namespace LigaTabajara.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class Initial : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.ComissaoTecnicas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cargo = c.Int(nullable: false),
                        DataNascimento = c.DateTime(nullable: false),
                        TimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeId, cascadeDelete: true)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Times",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Nome = c.String(),
                        Cidade = c.String(),
                        Estado = c.String(),
                        DataFundacao = c.DateTime(nullable: false),
                        Estadio = c.String(),
                        CapacidadeEstadio = c.Int(nullable: false),
                        CorUniformePrimario = c.String(),
                        CorUniformeSecuntario = c.String(),
                        StatusTime = c.Int(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.EstatisticaJogoes",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        PartidaId = c.Int(nullable: false),
                        JogadorId = c.Int(nullable: false),
                        Gols = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Jogadors", t => t.JogadorId, cascadeDelete: true)
                .ForeignKey("dbo.Partidas", t => t.PartidaId, cascadeDelete: true)
                .Index(t => t.PartidaId)
                .Index(t => t.JogadorId);
            
            CreateTable(
                "dbo.Jogadors",
                c => new
                    {
                        ID = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                        DataNascimento = c.DateTime(nullable: false),
                        Nacionalidade = c.String(),
                        Posicao = c.Int(nullable: false),
                        NumCamisa = c.Int(nullable: false),
                        Altura = c.Single(nullable: false),
                        Peso = c.Single(nullable: false),
                        PePreferido = c.Int(nullable: false),
                        TimeId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.ID)
                .ForeignKey("dbo.Times", t => t.TimeId, cascadeDelete: true)
                .Index(t => t.TimeId);
            
            CreateTable(
                "dbo.Partidas",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        DataPartida = c.DateTime(nullable: false),
                        TimeMandanteId = c.Int(nullable: false),
                        TimeVisitanteId = c.Int(nullable: false),
                        GolsMandante = c.Int(),
                        GolsVisitante = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Times", t => t.TimeMandanteId)
                .ForeignKey("dbo.Times", t => t.TimeVisitanteId)
                .Index(t => t.TimeMandanteId)
                .Index(t => t.TimeVisitanteId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Partidas", "TimeVisitanteId", "dbo.Times");
            DropForeignKey("dbo.Partidas", "TimeMandanteId", "dbo.Times");
            DropForeignKey("dbo.EstatisticaJogoes", "PartidaId", "dbo.Partidas");
            DropForeignKey("dbo.EstatisticaJogoes", "JogadorId", "dbo.Jogadors");
            DropForeignKey("dbo.Jogadors", "TimeId", "dbo.Times");
            DropForeignKey("dbo.ComissaoTecnicas", "TimeId", "dbo.Times");
            DropIndex("dbo.Partidas", new[] { "TimeVisitanteId" });
            DropIndex("dbo.Partidas", new[] { "TimeMandanteId" });
            DropIndex("dbo.Jogadors", new[] { "TimeId" });
            DropIndex("dbo.EstatisticaJogoes", new[] { "JogadorId" });
            DropIndex("dbo.EstatisticaJogoes", new[] { "PartidaId" });
            DropIndex("dbo.ComissaoTecnicas", new[] { "TimeId" });
            DropTable("dbo.Partidas");
            DropTable("dbo.Jogadors");
            DropTable("dbo.EstatisticaJogoes");
            DropTable("dbo.Times");
            DropTable("dbo.ComissaoTecnicas");
        }
    }
}
