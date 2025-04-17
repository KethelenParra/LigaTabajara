using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using LigaTabajara.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace LigaTabajara.DAL
{
	public class LigaTabajaraContext : DbContext
    {
        public LigaTabajaraContext() : base("LigaTabajaraContext")
        {
        }
        public DbSet<Jogador> Jogadores { get; set; }
        public DbSet<ComissaoTecnica> ComissoesTecnicas { get; set; }
        public DbSet<Partida> Partidas { get; set; }
        public DbSet<EstatisticaJogo> EstatisticasJogos { get; set; }
        public DbSet<Time> Times { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            // Configurar a relação para TimeMandante e desabilitar cascade delete
            modelBuilder.Entity<Partida>()
                .HasRequired(p => p.TimeMandante)
                .WithMany(t => t.PartidasMandantes) 
                .HasForeignKey(p => p.TimeMandanteId)
                .WillCascadeOnDelete(false);

            // Configurar a relação para TimeVisitante e desabilitar cascade delete
            modelBuilder.Entity<Partida>()
                .HasRequired(p => p.TimeVisitante)
                .WithMany(t => t.PartidasVisitantes) 
                .HasForeignKey(p => p.TimeVisitanteId)
                .WillCascadeOnDelete(false);

            base.OnModelCreating(modelBuilder);
        }
    }
}
