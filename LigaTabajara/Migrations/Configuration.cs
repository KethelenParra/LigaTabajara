namespace LigaTabajara.Migrations
{
    using LigaTabajara.Models;
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;

    internal sealed class Configuration : DbMigrationsConfiguration<LigaTabajara.DAL.LigaTabajaraContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(LigaTabajara.DAL.LigaTabajaraContext context)
        {
            context.Times.AddOrUpdate(t => t.Nome,
               new Time { Nome = "Flamengo", Cidade = "Rio de Janeiro", Estado = "RJ", DataFundacao = DateTime.Parse("1895-11-15"), Estadio = "Maracanã", CapacidadeEstadio = 78838, CorUniformePrimario = "Vermelho", CorUniformeSecuntario = "Preto" },
               new Time { Nome = "Palmeiras", Cidade = "São Paulo", Estado = "SP", DataFundacao = DateTime.Parse("1914-08-26"), Estadio = "Allianz Parque", CapacidadeEstadio = 43003, CorUniformePrimario = "Verde", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Atlético Mineiro", Cidade = "Belo Horizonte", Estado = "MG", DataFundacao = DateTime.Parse("1908-03-25"), Estadio = "Mineirão", CapacidadeEstadio = 62000, CorUniformePrimario = "Preto", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Fluminense", Cidade = "Rio de Janeiro", Estado = "RJ", DataFundacao = DateTime.Parse("1902-07-21"), Estadio = "Maracanã", CapacidadeEstadio = 78838, CorUniformePrimario = "Verde", CorUniformeSecuntario = "Bordô" },
               new Time { Nome = "Corinthians", Cidade = "São Paulo", Estado = "SP", DataFundacao = DateTime.Parse("1910-09-01"), Estadio = "Neo Química Arena", CapacidadeEstadio = 49231, CorUniformePrimario = "Branco", CorUniformeSecuntario = "Preto" },
               new Time { Nome = "São Paulo", Cidade = "São Paulo", Estado = "SP", DataFundacao = DateTime.Parse("1930-01-25"), Estadio = "Morumbi", CapacidadeEstadio = 67000, CorUniformePrimario = "Branco", CorUniformeSecuntario = "Vermelho" },
               new Time { Nome = "Botafogo", Cidade = "Rio de Janeiro", Estado = "RJ", DataFundacao = DateTime.Parse("1904-08-12"), Estadio = "Nilton Santos", CapacidadeEstadio = 46000, CorUniformePrimario = "Preto", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Internacional", Cidade = "Porto Alegre", Estado = "RS", DataFundacao = DateTime.Parse("1909-04-04"), Estadio = "Beira-Rio", CapacidadeEstadio = 50000, CorUniformePrimario = "Vermelho", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Cruzeiro", Cidade = "Belo Horizonte", Estado = "MG", DataFundacao = DateTime.Parse("1921-01-02"), Estadio = "Mineirão", CapacidadeEstadio = 62000, CorUniformePrimario = "Azul", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Grêmio", Cidade = "Porto Alegre", Estado = "RS", DataFundacao = DateTime.Parse("1903-09-15"), Estadio = "Arena do Grêmio", CapacidadeEstadio = 55000, CorUniformePrimario = "Azul", CorUniformeSecuntario = "Preto" },
               new Time { Nome = "Santos", Cidade = "Santos", Estado = "SP", DataFundacao = DateTime.Parse("1912-04-14"), Estadio = "Vila Belmiro", CapacidadeEstadio = 16000, CorUniformePrimario = "Branco", CorUniformeSecuntario = "Preto" },
               new Time { Nome = "Athletico-PR", Cidade = "Curitiba", Estado = "PR", DataFundacao = DateTime.Parse("1924-03-26"), Estadio = "Arena da Baixada", CapacidadeEstadio = 42800, CorUniformePrimario = "Vermelho", CorUniformeSecuntario = "Preto" },
               new Time { Nome = "Fortaleza", Cidade = "Fortaleza", Estado = "CE", DataFundacao = DateTime.Parse("1918-10-18"), Estadio = "Castelão", CapacidadeEstadio = 63000, CorUniformePrimario = "Azul", CorUniformeSecuntario = "Vermelho" },
               new Time { Nome = "Bahia", Cidade = "Salvador", Estado = "BA", DataFundacao = DateTime.Parse("1931-01-01"), Estadio = "Fonte Nova", CapacidadeEstadio = 50000, CorUniformePrimario = "Azul", CorUniformeSecuntario = "Vermelho" },
               new Time { Nome = "Coritiba", Cidade = "Curitiba", Estado = "PR", DataFundacao = DateTime.Parse("1909-10-12"), Estadio = "Couto Pereira", CapacidadeEstadio = 40400, CorUniformePrimario = "Verde", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Goiás", Cidade = "Goiânia", Estado = "GO", DataFundacao = DateTime.Parse("1943-04-06"), Estadio = "Serra Dourada", CapacidadeEstadio = 50000, CorUniformePrimario = "Verde", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Ceará", Cidade = "Fortaleza", Estado = "CE", DataFundacao = DateTime.Parse("1914-06-02"), Estadio = "Castelão", CapacidadeEstadio = 63000, CorUniformePrimario = "Preto", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Vasco", Cidade = "Rio de Janeiro", Estado = "RJ", DataFundacao = DateTime.Parse("1898-08-21"), Estadio = "São Januário", CapacidadeEstadio = 21044, CorUniformePrimario = "Preto", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "América-MG", Cidade = "Belo Horizonte", Estado = "MG", DataFundacao = DateTime.Parse("1912-04-30"), Estadio = "Independência", CapacidadeEstadio = 23000, CorUniformePrimario = "Verde", CorUniformeSecuntario = "Branco" },
               new Time { Nome = "Sport", Cidade = "Recife", Estado = "PE", DataFundacao = DateTime.Parse("1905-05-13"), Estadio = "Itaipava Arena Pernambuco", CapacidadeEstadio = 46000, CorUniformePrimario = "Vermelho", CorUniformeSecuntario = "Preto" }
            );
            context.SaveChanges();

            // 2) CARREGA OS TIMES SALVOS
            var times = context.Times.ToDictionary(t => t.Nome, t => t.Id);

            context.Jogadores.AddOrUpdate(j => new { j.Name, j.TimeId, j.NumCamisa },
                // Flamengo
                new Jogador { Name = "Diego Alves", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1985-11-24"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.88f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "César", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1985-04-02"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Hugo Souza", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("2001-09-27"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.89f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                new Jogador { Name = "Matheuzinho", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1999-05-10"), Nacionalidade = "Brasileiro", NumCamisa = 38, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Ramon", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1996-06-04"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },
                new Jogador { Name = "Filipe Luís", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1985-08-09"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },

                new Jogador { Name = "Léo Pereira", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-08-07"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.86f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Pablo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-12-20"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.88f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Thuler", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2000-06-18"), Nacionalidade = "Brasileiro", NumCamisa = 24, Altura = 1.91f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Rodrigo Caio", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-08-17"), Nacionalidade = "Brasileiro", NumCamisa = 13, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Fabrício Bruno", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-08-26"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.90f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Ayrton Lucas", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1997-04-03"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },

                new Jogador { Name = "Victor Hugo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2004-12-22"), Nacionalidade = "Brasileiro", NumCamisa = 35, Altura = 1.80f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "João Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2001-01-13"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.90f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Willian Arão", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-09-24"), Nacionalidade = "Brasileiro", NumCamisa = 33, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                new Jogador { Name = "Gerson", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-05-20"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.80f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Everton Ribeiro", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-10-10"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.68f, Peso = 58f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Arrascaeta", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-12-01"), Nacionalidade = "Uruguaio", NumCamisa = 14, Altura = 1.80f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Vitinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-10-09"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.71f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Diego Ribas", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1985-02-28"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.69f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Michael", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-02-12"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.69f, Peso = 62f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                new Jogador { Name = "Bruno Henrique", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-06-30"), Nacionalidade = "Brasileiro", NumCamisa = 27, Altura = 1.78f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Gabriel Barbosa", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-08-30"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.75f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Pedro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-06-20"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.94f, Peso = 91f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Marinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-12-29"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.70f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Lázaro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-10-25"), Nacionalidade = "Brasileiro", NumCamisa = 39, Altura = 1.77f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                new Jogador { Name = "Bukayo Saka", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2001-09-05"), Nacionalidade = "Inglês", NumCamisa = 7, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },
                new Jogador { Name = "Granit Xhaka", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-09-27"), Nacionalidade = "Suíço", NumCamisa = 34, Altura = 1.85f, Peso = 78f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },
                new Jogador { Name = "Kieran Tierney", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1997-06-05"), Nacionalidade = "Escocês", NumCamisa = 3, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Flamengo"] },
                new Jogador { Name = "Gabriel Martinelli", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-06-18"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.75f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Flamengo"] },

                // Palmeiras
                new Jogador { Name = "Weverton", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1987-11-13"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.86f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Jaílson", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1991-05-15"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.89f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Vinícius Silvestre", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1999-01-07"), Nacionalidade = "Brasileiro", NumCamisa = 34, Altura = 1.85f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },

                new Jogador { Name = "Rocha", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-12-24"), Nacionalidade = "Brasileiro", NumCamisa = 33, Altura = 1.85f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Empereur", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-01-04"), Nacionalidade = "Brasileiro", NumCamisa = 46, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Gustavo Gómez", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-05-06"), Nacionalidade = "Paraguaio", NumCamisa = 15, Altura = 1.90f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Murilo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-03-18"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.84f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Jaílson (zagueiro)", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-03-30"), Nacionalidade = "Brasileiro", NumCamisa = 34, Altura = 1.88f, Peso = 83f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Mayke", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1992-05-10"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Kim", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("2000-06-09"), Nacionalidade = "Coreano", NumCamisa = 40, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Piquerez", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("2001-06-15"), Nacionalidade = "Uruguaio", NumCamisa = 6, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Matías Viña", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1997-03-31"), Nacionalidade = "Uruguaio", NumCamisa = 7, Altura = 1.73f, Peso = 65f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },

                new Jogador { Name = "Dudu", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-05-07"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.69f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Raphael Veiga", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-01-19"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.75f, Peso = 75f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Zé Rafael", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-06-24"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Eduard Atuesta", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-01-15"), Nacionalidade = "Colombiano", NumCamisa = 5, Altura = 1.75f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Gabriel Menino", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2000-10-29"), Nacionalidade = "Brasileiro", NumCamisa = 25, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Patrick de Paula", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-07-15"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Danilo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-03-15"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Gustavo Scarpa", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-01-05"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Matheus Fernandes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2000-09-02"), Nacionalidade = "Brasileiro", NumCamisa = 35, Altura = 1.80f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Lucas Trevisol", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-04-10"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Palmeiras"] },

                new Jogador { Name = "Rony", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-05-11"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Luiz Adriano", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1987-04-12"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.94f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Deyverson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-06-08"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.81f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Rafael Navarro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-01-31"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.85f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Gabriel Veron", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-05-03"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.73f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Wesley", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-07-09"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.87f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Miguel Borja", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-12-26"), Nacionalidade = "Colombiano", NumCamisa = 17, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },
                new Jogador { Name = "Wesley Moraes", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-01-10"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.90f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Palmeiras"] },

                // Atlético Mineiro
                new Jogador { Name = "Everson", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1993-03-17"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Rafael", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1996-02-05"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "João Ricardo", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-12-04"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.87f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Name = "Mariano", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1986-02-23"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Igor Rabello", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-11-12"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Natan", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1999-03-24"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.93f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Gabriel Silva", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1998-05-12"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Alan Franco", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1999-10-15"), Nacionalidade = "Ecuadoriano", NumCamisa = 33, Altura = 1.83f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Guilherme Arana", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1993-06-14"), Nacionalidade = "Brasileiro", NumCamisa = 13, Altura = 1.73f, Peso = 69f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Júnior Alonso", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-08-31"), Nacionalidade = "Paraguaio", NumCamisa = 2, Altura = 1.84f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Name = "Allan", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-01-16"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Jair", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-01-05"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.83f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Nacho Fernández", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1990-05-12"), Nacionalidade = "Argentino", NumCamisa = 11, Altura = 1.70f, Peso = 71f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Matías Zaracho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-02-10"), Nacionalidade = "Argentino", NumCamisa = 30, Altura = 1.75f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Savinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-03-21"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.76f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Diego Costa", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1988-10-07"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.69f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Name = "Ademir", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-10-27"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.83f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Eduardo Vargas", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-11-20"), Nacionalidade = "Chileno", NumCamisa = 7, Altura = 1.75f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Keno", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-05-10"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.74f, Peso = 71f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Yimmi Chará", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-01-23"), Nacionalidade = "Colombiano", NumCamisa = 27, Altura = 1.82f, Peso = 79f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Eduardo Sasha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-05-27"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.78f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Name = "Rafael Carioca", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1989-03-31"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Tchê Tchê", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-06-08"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.75f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Borré", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-07-15"), Nacionalidade = "Colombiano", NumCamisa = 10, Altura = 1.75f, Peso = 69f, PePreferido = PePreferido.Esquerdo, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Diego Tardelli", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-05-19"), Nacionalidade = "Brasileiro", NumCamisa = 27, Altura = 1.71f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Otávio", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-08-13"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                new Jogador { Name = "Matheus Fernandes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-07-30"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.81f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Alan Kardec", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-03-12"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.88f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Alerrandro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2000-06-29"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },
                new Jogador { Name = "Giovanni", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-08-25"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Atlético Mineiro"] },

                // Fluminense
                new Jogador { Name = "Marcos Felipe", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1996-06-18"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.89f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Gabriel Batista", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1997-08-02"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.92f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Fábio", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1990-07-02"), Nacionalidade = "Brasileiro", NumCamisa = 32, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },

                new Jogador { Name = "Nino", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-06-10"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.87f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Luccas Claro", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-01-30"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Digão", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-11-11"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.95f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Samuel Xavier", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1990-02-22"), Nacionalidade = "Brasileiro", NumCamisa = 24, Altura = 1.77f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Igor Julião", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1994-10-13"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Marlon", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-03-23"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.92f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Manoel", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1989-04-20"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.87f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Calegari", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("2000-01-02"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.83f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Wellington Silva", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1988-05-06"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.80f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },

                new Jogador { Name = "André", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-02-17"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Nenê", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1981-05-12"), Nacionalidade = "Brasileiro", NumCamisa = 77, Altura = 1.71f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Danielzinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-04-30"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fluminense"] },
                new Jogador { Name = "Cazares", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-02-03"), Nacionalidade = "Equatoriano", NumCamisa = 10, Altura = 1.69f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Wellington", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-06-05"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Yago", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1997-09-26"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "André Trindade", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2002-09-09"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Gabriel Teixeira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2001-04-01"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.74f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Crispim", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-08-24"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.83f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Ganso", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-10-12"), Nacionalidade = "Brasileiro", NumCamisa = 25, Altura = 1.84f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Marquinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-07-29"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "João Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2001-10-13"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.74f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },

                new Jogador { Name = "Fred", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-03-03"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Yony González", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-08-19"), Nacionalidade = "Colombiano", NumCamisa = 19, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Evanilson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-06-02"), Nacionalidade = "Brasileiro", NumCamisa = 27, Altura = 1.83f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Luciano", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-08-15"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },
                new Jogador { Name = "Pedrinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-11-17"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fluminense"] },
                new Jogador { Name = "Jhon Arias", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-10-07"), Nacionalidade = "Colombiano", NumCamisa = 28, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Fluminense"] },

                // Corinthians
                new Jogador { Name = "Cássio", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("06/12/1987"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.90f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Matheus Donelli", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("28/05/2003"), Nacionalidade = "Brasileiro", NumCamisa = 31, Altura = 1.90f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Walter", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("13/08/1987"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },

                new Jogador { Name = "Fagner", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("11/06/1985"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.74f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Raul Gustavo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("25/02/1999"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Jemerson", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("20/12/1992"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.91f, Peso = 92f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Gil", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("12/07/1987"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.90f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "João Victor", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("15/06/2002"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.87f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Bruno Méndez", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("27/11/1998"), Nacionalidade = "Uruguaio", NumCamisa = 13, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Lucas Piton", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("22/02/1999"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Corinthians"] },
                new Jogador { Name = "Rafael Ramos", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("29/06/1995"), Nacionalidade = "Portugalês", NumCamisa = 5, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },

                new Jogador { Name = "Maycon", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("15/09/1997"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Giuliano", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("31/05/1987"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.79f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Renato Augusto", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("08/02/1988"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.73f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Gustavo Mantuan", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("27/04/2001"), Nacionalidade = "Brasileiro", NumCamisa = 47, Altura = 1.76f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Adson", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("05/11/2001"), Nacionalidade = "Brasileiro", NumCamisa = 37, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Ramiro", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("03/11/1993"), Nacionalidade = "Brasileiro", NumCamisa = 48, Altura = 1.85f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Paulinho", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("25/07/1988"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.83f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Du Queiroz", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("06/03/2002"), Nacionalidade = "Brasileiro", NumCamisa = 41, Altura = 1.82f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Gabriel Pereira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("09/12/2001"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.85f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Ángelo Araos", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("23/06/1997"), Nacionalidade = "Chileno", NumCamisa = 21, Altura = 1.73f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },

                new Jogador { Name = "Jô", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("27/03/1987"), Nacionalidade = "Brasileiro", NumCamisa = 77, Altura = 1.84f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Roger Guedes", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("22/02/1996"), Nacionalidade = "Brasileiro", NumCamisa = 123, Altura = 1.79f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Léo Natel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("07/11/1997"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.84f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Gustavo Mosquito", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("02/07/1999"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.84f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Mateus Vital", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("29/05/1998"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.79f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Ángel Romero", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("04/07/1992"), Nacionalidade = "Paraguaio", NumCamisa = 11, Altura = 1.77f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },
                new Jogador { Name = "Clayson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("07/08/1995"), Nacionalidade = "Brasileiro", NumCamisa = 27, Altura = 1.70f, Peso = 64f, PePreferido = PePreferido.Esquerdo, TimeId = times["Corinthians"] },
                new Jogador { Name = "Roni", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("07/07/2004"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Corinthians"] },
                new Jogador { Name = "Yuri Alberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("18/03/2002"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.86f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Corinthians"] },

                // São Paulo
                new Jogador { Name = "Tiago Volpi", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-12-19"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Lucas Perri", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1997-04-01"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.89f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Marcelo Carné", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1991-01-10"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.90f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },

                new Jogador { Name = "Miranda", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1984-09-07"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Éder Militão", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1998-01-18"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Rodrigo Caio", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-08-17"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Bruno Alves", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1981-11-27"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.83f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Arboleda", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-09-24"), Nacionalidade = "Equatoriano", NumCamisa = 6, Altura = 1.87f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },

                new Jogador { Name = "Daniel Alves", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1983-05-06"), Nacionalidade = "Brasileiro", NumCamisa = 13, Altura = 1.72f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Léo", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1982-12-02"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.81f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },

                new Jogador { Name = "Jucilei", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1981-09-16"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.74f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Thiago Mendes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-03-15"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Tonny Anderson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-03-24"), Nacionalidade = "Brasileiro", NumCamisa = 39, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Liziero", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-03-07"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.79f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Tchê Tchê", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-03-31"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.85f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Hernanes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1985-05-29"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Igor Gomes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1999-02-21"), Nacionalidade = "Brasileiro", NumCamisa = 35, Altura = 1.83f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Hudson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1988-06-18"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["São Paulo"] },

                new Jogador { Name = "Antony", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2000-02-24"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.72f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Pablo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-09-02"), Nacionalidade = "Argentino", NumCamisa = 9, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Everton", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-06-03"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.78f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["São Paulo"] },
                new Jogador { Name = "Luciano", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1986-08-15"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.77f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Diego Souza", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-02-17"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Calleri", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-02-14"), Nacionalidade = "Argentino", NumCamisa = 9, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Esquerdo, TimeId = times["São Paulo"] },
                new Jogador { Name = "Breno Lopes", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-08-27"), Nacionalidade = "Brasileiro", NumCamisa = 13, Altura = 1.78f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Rogério Ceni", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1973-09-22"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Cafu", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1970-06-07"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Raí", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1965-05-15"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Müller", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1957-12-31"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["São Paulo"] },
                new Jogador { Name = "Careca", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1960-10-05"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.73f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["São Paulo"] },

                // Botafogo
                new Jogador { Name = "Gatito Fernández", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-04-03"), Nacionalidade = "Paraguaio", NumCamisa = 1, Altura = 1.95f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Diego Cavalieri", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1982-03-20"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Helton Leite", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-04-12"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                new Jogador { Name = "Joel Carli", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1986-04-05"), Nacionalidade = "Argentino", NumCamisa = 4, Altura = 1.92f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Kanu", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1989-01-21"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Marcelo Benevenuto", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-09-04"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Bruno Silva", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1999-03-23"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.81f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                new Jogador { Name = "Luiz Otávio", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-08-16"), Nacionalidade = "Brasileiro", NumCamisa = 35, Altura = 1.87f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Bruno Nazário", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-02-23"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },
                new Jogador { Name = "Victor Sá", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-11-06"), Nacionalidade = "Angolano", NumCamisa = 16, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Olívio", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-02-13"), Nacionalidade = "Brasileiro", NumCamisa = 24, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },

                new Jogador { Name = "Cícero", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-06-06"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.83f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Chay", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-09-12"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.77f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "André Luís", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-12-07"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                new Jogador { Name = "Edson", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-10-14"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },
                new Jogador { Name = "Felipe Ferreira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-11-02"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.82f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Marcelotes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-01-15"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.76f, Peso = 71f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },

                new Jogador { Name = "Pedro Raul", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-01-25"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Tiquinho Soares", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-06-04"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.89f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "De Freitas", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-03-16"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.84f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Lucas Fernandes", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-06-29"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },
                new Jogador { Name = "Mateus Vital", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-09-06"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Rafael Navarro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-10-22"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                new Jogador { Name = "Nilton Santos", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1925-05-16"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Botafogo"] },
                new Jogador { Name = "Garrincha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1933-10-28"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.69f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Jairzinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1944-12-25"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Túlio Maravilha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1969-05-02"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.73f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Paulo Valentim", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1933-01-15"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Cláudio Adão", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1955-09-02"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },
                new Jogador { Name = "Cantarele", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1951-07-22"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Botafogo"] },

                // Internacional
                new Jogador { Name = "Marcelo Lomba", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1986-10-18"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Daniel", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1993-03-17"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.85f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },

                new Jogador { Name = "Víctor Cuesta", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1988-10-05"), Nacionalidade = "Argentino", NumCamisa = 4, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Bruno Méndez", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1998-04-17"), Nacionalidade = "Uruguaio", NumCamisa = 2, Altura = 1.84f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Lucas Ribeiro", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1998-05-14"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Rodrigo Moledo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1986-08-09"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Emerson Santos", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-02-06"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Paulo Henrique", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-06-10"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Vitão", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2000-02-06"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Heitor", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1989-12-15"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Iago", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1998-11-29"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.73f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Internacional"] },

                new Jogador { Name = "Edenilson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-08-01"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Rodrigo Dourado", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-01-17"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Gabriel Boschilia", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-02-05"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Nonato", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-09-30"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.63f, Peso = 62f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Praxedes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2003-02-14"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.85f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Alan Patrick", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-01-15"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.70f, Peso = 60f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Marcos Guilherme", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-03-10"), Nacionalidade = "Brasileiro", NumCamisa = 77, Altura = 1.76f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Kevin", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-12-27"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.79f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Bruno Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2000-06-01"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Andrés D'Alessandro", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1977-10-15"), Nacionalidade = "Argentino", NumCamisa = 15, Altura = 1.70f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },

                new Jogador { Name = "Yuri Alberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-03-18"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.86f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Wanderson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-07-07"), Nacionalidade = "Brasileiro", NumCamisa = 27, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "William Pottker", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-03-12"), Nacionalidade = "Brasileiro", NumCamisa = 77, Altura = 1.85f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Nico López", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-06-02"), Nacionalidade = "Uruguaio", NumCamisa = 10, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Caio Vidal", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-08-23"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.76f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Tiquinho Soares", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-06-04"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.87f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Paolo Guerrero", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-01-01"), Nacionalidade = "Peruano", NumCamisa = 9, Altura = 1.84f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Leandro Damião", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-03-22"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },
                new Jogador { Name = "Eduardo Sasha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-06-30"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.78f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Internacional"] },

                // Cruzeiro
                new Jogador { Name = "Fábio Jose", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1977-04-30"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.84f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Rafael Cabral", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1990-04-12"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.93f, Peso = 92f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Miguel Dias", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1999-09-10"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },

                new Jogador { Name = "Murilo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-07-06"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Lucas Romero", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-06-07"), Nacionalidade = "Paraguaio", NumCamisa = 4, Altura = 1.80f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Breno", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1999-12-15"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.89f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Cacá", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2001-08-24"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Léo Ortiz", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-08-04"), Nacionalidade = "Brasileiro", NumCamisa = 25, Altura = 1.86f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },

                new Jogador { Name = "Ronald", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("2000-05-30"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Ezequiel", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1999-04-10"), Nacionalidade = "Argentino", NumCamisa = 22, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Dirceu", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("2002-09-12"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.76f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Willian Oliveira", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1993-02-17"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },

                new Jogador { Name = "Pepê", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-01-24"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.82f, Peso = 77f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Aírton", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2003-02-22"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.85f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Yago", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-04-29"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },

                new Jogador { Name = "Ariel Cabral", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1988-11-14"), Nacionalidade = "Argentino", NumCamisa = 7, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Aylon", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-08-16"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.81f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Aloísio", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-10-02"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },

                new Jogador { Name = "Gabriel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-08-30"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Edu", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-12-10"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Aloísio", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-01-12"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },

                new Jogador { Name = "Raniel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-05-25"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.81f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Marcinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-12-10"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "David", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-10-02"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.79f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Tostão", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1947-01-25"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.73f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Wilson Piazza", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1943-04-25"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.85f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Raul Plassmann", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1944-07-27"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Nelinho", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1950-07-26"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.79f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Palhinha", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1950-11-04"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Cruzeiro"] },
                new Jogador { Name = "Dirceu Lopes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1946-02-02"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Cruzeiro"] },

                // Grêmio
                new Jogador { Name = "Paulo Victor", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-03-01"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Brenno", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1999-02-02"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Gabriel Chapecó", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("2001-07-10"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },

                new Jogador { Name = "Pedro", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-12-22"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Kannemann", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1990-12-06"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "David Braz", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1987-10-22"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.86f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Ruan", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1998-01-02"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Vanderson", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("2001-05-05"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Rafinha", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1985-07-07"), Nacionalidade = "Brasileiro", NumCamisa = 13, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Bruno Cortez", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1989-12-22"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.71f, Peso = 65f, PePreferido = PePreferido.Esquerdo, TimeId = times["Grêmio"] },
                new Jogador { Name = "Diogo Barbosa", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1990-05-09"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Geromel", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-12-22"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Madson", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1991-01-16"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.77f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },

                new Jogador { Name = "Matheus Henrique", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-11-19"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.83f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Lucas Leiva", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1987-01-09"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.75f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Jean Pyerre", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-05-07"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Alisson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-04-26"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.78f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Darlan", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-04-19"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.77f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Bitello", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2001-08-22"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.74f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Palhinha", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-05-03"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.84f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Lucas Silva", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-10-16"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Thaciano", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-03-16"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Matheus Sarará", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-08-08"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.80f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },

                new Jogador { Name = "Diego Souza", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-03-03"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "André", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-02-03"), Nacionalidade = "Brasileiro", NumCamisa = 35, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Kaio Jorge", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-01-24"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.86f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Robinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-01-23"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.72f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Ferreira", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-08-18"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Lucca", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-05-29"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.81f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },
                new Jogador { Name = "Everton Cebolinha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-11-06"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Grêmio"] },

                // Santos
                new Jogador { Name = "John", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1994-03-15"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.90f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Vanderlei", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1984-04-01"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.88f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Name = "Lucas Veríssimo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-06-10"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Gustavo Henrique", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-12-10"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Victor", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-09-24"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.89f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Felipe Aguilar", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-04-26"), Nacionalidade = "Paraguaio", NumCamisa = 5, Altura = 1.93f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Luan Peres", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-03-19"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Nathan", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-03-15"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Name = "Madson", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1988-07-26"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Marcos Leonardo", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("2000-05-03"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Santos"] },

                new Jogador { Name = "Gabigol", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-08-13"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.75f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Jobson", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-03-29"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.73f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Rodrygo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2001-01-09"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.74f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Alison", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2003-11-06"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.78f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Name = "Diego Tardelli", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1985-05-10"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.79f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Copete", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1987-07-09"), Nacionalidade = "Colombiano", NumCamisa = 33, Altura = 1.81f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Jean Mota", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-10-15"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Santos"] },
                new Jogador { Name = "Everson Silva", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-08-17"), Nacionalidade = "Brasileiro", NumCamisa = 38, Altura = 1.79f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Name = "Marinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-12-12"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.65f, Peso = 63f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Kaio Jorge", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-01-24"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.89f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Carlos Sánchez", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-12-01"), Nacionalidade = "Uruguaio", NumCamisa = 14, Altura = 1.63f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Santos"] },
                new Jogador { Name = "Marcelinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-08-13"), Nacionalidade = "Brasileiro", NumCamisa = 24, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Marlon Freitas", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-05-18"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                new Jogador { Name = "Pelé", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1940-10-23"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.73f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Pagão", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1934-06-14"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.72f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Pepe", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1935-02-16"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.76f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Clodoaldo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1949-09-23"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.68f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Carlos Alberto Torres", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1944-07-17"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.72f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Giovanni", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1972-07-04"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },
                new Jogador { Name = "Robinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1984-01-25"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Santos"] },

                // Athletico-PR
                new Jogador { Name = "Santos", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1993-01-26"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.90f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "João Victor", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-07-26"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.88f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },

                new Jogador { Name = "Neto", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1990-07-09"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.90f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Thiago Heleno", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1988-12-25"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.84f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Abner", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2000-12-28"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.87f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },

                new Jogador { Name = "Fabrício Bruno", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-07-21"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.90f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Khellven", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("2000-02-18"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.76f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Abner Vinícius", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("2000-03-10"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },

                new Jogador { Name = "Christian", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1998-07-20"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Richard", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-12-10"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Matheus Galdezani", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-10-10"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.83f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },

                new Jogador { Name = "Filipe Machado", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-11-07"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.79f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Deivid", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1999-09-01"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Nikão", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-04-10"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.70f, Peso = 62f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Léo Cittadini", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-06-28"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Hugo Moura", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-11-03"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Renan Lodi", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1998-04-08"), Nacionalidade = "Brasileiro", NumCamisa = 24, Altura = 1.73f, Peso = 69f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },

                new Jogador { Name = "Niklas", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2003-05-12"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.82f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Vitor Roque", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2005-11-28"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.82f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Kadu", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-01-15"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.85f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },

                new Jogador { Name = "Christian", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1998-07-20"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Matheus Babi", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-08-03"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Pablo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-03-17"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Alex Mineiro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1975-07-13"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.77f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Paulo Baier", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1974-05-03"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Dagoberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1983-03-22"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Kléber", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1982-02-03"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Ferreira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-06-11"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.74f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Rodrigo Gral", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1977-05-18"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.68f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Athletico-PR"] },
                new Jogador { Name = "Éder Sciola", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1985-05-12"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Athletico-PR"] },

                // Fortaleza
                new Jogador { Name = "Marcelo Boeck", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1984-04-12"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.85f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Felipe Alves", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1990-06-15"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.84f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                new Jogador { Name = "Bruno Melo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1991-08-24"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Marcelo Benevenuto", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-02-25"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.85f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "William Alves", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1988-05-30"), Nacionalidade = "Brasileiro", NumCamisa = 33, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Juan Quintero", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-11-12"), Nacionalidade = "Colombiano", NumCamisa = 15, Altura = 1.86f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Gustavo Henrique", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-09-05"), Nacionalidade = "Brasileiro", NumCamisa = 25, Altura = 1.89f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Delfim", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-03-17"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.84f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Eduardo Brock", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-07-20"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.91f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                new Jogador { Name = "Airton", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-06-14"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.79f, Peso = 77f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Yago Pikachu", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-03-29"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.82f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Pablo Dyego", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-08-20"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Gabriel Dias", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-05-28"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Edson Cariús", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1988-02-20"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Grampola", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-09-10"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.81f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                new Jogador { Name = "Lucas Crispim", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-02-08"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Felipe Silva", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-12-12"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Marcinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-06-02"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Yago", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-04-17"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.78f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Edinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1987-11-27"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Erick", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-04-11"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.74f, Peso = 70f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Nathan Lima", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-05-16"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.76f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Moleiro", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-08-09"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.73f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                new Jogador { Name = "Quintero", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1986-07-23"), Nacionalidade = "Colombiano", NumCamisa = 11, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Sassá", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1994-08-26"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Jô Santos", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-05-30"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.84f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Tomas Pochettino", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1994-02-14"), Nacionalidade = "Argentino", NumCamisa = 17, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Emanuel Cecilio", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-03-09"), Nacionalidade = "Paraguaio", NumCamisa = 21, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "José Gonçalves", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1975-05-05"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },
                new Jogador { Name = "Carlos Eduardo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-06-04"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.81f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Fortaleza"] },

                // Bahia
                new Jogador { Name = "Matheus Teixeira", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-06-07"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.92f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Douglas Friedrich", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-09-15"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Name = "Lucas Fonseca", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-02-17"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Wesley Matos", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1990-03-23"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.84f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "João Victor", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-11-12"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.88f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Name = "Vinícius Machado", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1998-04-05"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Bahia"] },
                new Jogador { Name = "Régis", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1989-01-03"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.72f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Patrick de Lucca", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-08-31"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Anderson Talisca", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-02-01"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.92f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Rodriguinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1990-02-07"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.72f, Peso = 67f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Name = "Thiago", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-07-25"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.75f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Gregor", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-12-12"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.78f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Everton Ribeiro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1989-04-10"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.71f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Gilberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1980-02-13"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.82f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Lucas Mugni", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-10-30"), Nacionalidade = "Argentino", NumCamisa = 11, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Name = "Allan", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-10-11"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Pires", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-01-30"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Wesley", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1988-05-12"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Bahia"] },
                new Jogador { Name = "Matheus Sales", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1997-01-04"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                new Jogador { Name = "Renê", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1992-04-08"), Nacionalidade = "Brasileiro", NumCamisa = 25, Altura = 1.74f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Bahia"] },
                new Jogador { Name = "Elias Manoel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-10-17"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Kayser", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2000-12-07"), Nacionalidade = "Brasileiro", NumCamisa = 33, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Bobô", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1962-09-04"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.72f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Charles Fabian", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1961-12-23"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.67f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Marcelo Ramos", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1973-12-15"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Fahel", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1981-05-17"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Zé Carlos", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1962-08-07"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Marco Antônio", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1960-04-12"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "Almir", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1953-10-26"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },
                new Jogador { Name = "André Bahia", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1983-02-08"), Nacionalidade = "Brasileiro", NumCamisa = 33, Altura = 1.90f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Bahia"] },

                // Coritiba
                new Jogador { Name = "Wilson", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1989-05-28"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.93f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Rafael", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-01-19"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.88f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Name = "Jordi Becker", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-02-02"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Sabino", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-07-31"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.86f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Henrique Petry", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-11-22"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Bruno Silva", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-08-16"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.84f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Name = "Luiz Henrique", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1997-09-30"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.76f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Lucas Bocão", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1998-03-18"), Nacionalidade = "Brasileiro", NumCamisa = 31, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Igor", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1999-04-01"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Coritiba"] },
                new Jogador { Name = "Yuri", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1995-02-23"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.73f, Peso = 69f, PePreferido = PePreferido.Esquerdo, TimeId = times["Coritiba"] },

                new Jogador { Name = "Fellipe Bastos", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-01-02"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Matheus Galdezani", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1994-07-19"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Patrick Breyer", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1997-03-10"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.79f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Nathan", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1997-05-05"), Nacionalidade = "Brasileiro", NumCamisa = 25, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Willian Farias", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1989-04-29"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Name = "Thomas", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-05-15"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.72f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Matheus Oliveira", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-02-02"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Pavez", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1988-06-11"), Nacionalidade = "Chileno", NumCamisa = 30, Altura = 1.76f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Coritiba"] },
                new Jogador { Name = "Matheus França", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2003-12-01"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.70f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Iago Silva", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-04-01"), Nacionalidade = "Brasileiro", NumCamisa = 24, Altura = 1.91f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Name = "Elias Manoel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-09-14"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Robson", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-07-03"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.82f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Vitinho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1999-09-12"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.69f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Léo Gamalho", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1986-06-16"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Igor Paixão", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2000-10-08"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Washington", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-12-08"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                new Jogador { Name = "Dirceu Krüger", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1945-09-18"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.70f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Jairo", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1946-11-06"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Narciso", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1953-12-12"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },
                new Jogador { Name = "Paulo Rink", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1965-06-28"), Nacionalidade = "Alemão", NumCamisa = 7, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Coritiba"] },

                // Goiás
                new Jogador { Name = "Tadeu", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1987-02-02"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Ricardo", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1991-06-15"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Ramon", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-09-16"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Gabriel Paulista", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1989-11-10"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.95f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Ernandes", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1990-03-24"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.79f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Name = "Patrick", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-05-21"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.83f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Moisés", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1988-07-14"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Name = "Luiz Fernando", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-02-14"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.76f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Hyoran", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-09-02"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Bruno Rodrigues", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-12-01"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.78f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Alef Manga", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-05-08"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.82f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Fabrício Daniel", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2000-02-16"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Name = "Pedro Raul", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-07-18"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.87f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },

                new Jogador { Name = "Dayverson", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("2000-08-12"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.75f, Peso = 69f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Caio Vinicius", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1998-01-20"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.80f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Name = "Marlon", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-04-17"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Marcão", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1990-06-15"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.89f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Ricardo Nascimento", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1999-03-10"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Goiás"] },
                new Jogador { Name = "Vinícius Lopes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2001-11-30"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.74f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },

                new Jogador { Name = "Messias", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-08-22"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.83f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Luiz Fernando", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-12-04"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Rhodolfo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1986-01-14"), Nacionalidade = "Brasileiro", NumCamisa = 34, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Felipe Gedoz", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-06-10"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Paulo Baier", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1974-04-03"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Euller", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1964-10-15"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.75f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Edson Bastos", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1977-07-29"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Mauro Ovelha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1957-05-17"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Bruno Mineiro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1983-08-13"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Lúcio Flávio", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1975-02-05"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.72f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },
                new Jogador { Name = "Jonas", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1983-04-06"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.84f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Goiás"] },

                // Ceará
                new Jogador { Name = "Fernando Henrique", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1990-02-15"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.88f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Jefferson Silva", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1992-05-03"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "João Vitor", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-08-20"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Igor Freitas", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-11-10"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Pedro Henrique", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-07-18"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.87f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Lucas Lima", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1996-01-25"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Gustavo Souza", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1997-04-12"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.79f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Matheus Pereira", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-09-05"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.82f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Felipe Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-12-30"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.80f, Peso = 78f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Diego Costa", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-06-02"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.74f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Rafael Santos", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-03-17"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.76f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "André Felipe", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-10-22"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.81f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Bruno Menezes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-01-30"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.73f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Vitor Hugo", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1990-11-05"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.84f, Peso = 83f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Gabriel Silva", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-02-14"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.83f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Samuel Lima", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-07-21"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.75f, Peso = 73f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Carlos Alberto", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-09-15"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.79f, Peso = 89f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Luiz Henrique", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-05-27"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.77f, Peso = 74f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Rafael Moura", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1987-08-14"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Diego Alves", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-11-25"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.82f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Marcelo Rick", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-04-08"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.85f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Antonio Marcos", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-10-10"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.80f, Peso = 76f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Thiago Rodrigues", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1994-12-05"), Nacionalidade = "Brasileiro", NumCamisa = 24, Altura = 1.88f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Vinicius Oliveira", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1995-03-23"), Nacionalidade = "Brasileiro", NumCamisa = 25, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Ricardo Nunes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1990-06-11"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.79f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Felipe Martins", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-09-19"), Nacionalidade = "Brasileiro", NumCamisa = 27, Altura = 1.78f, Peso = 78f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Marcelo Henrique", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-07-02"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.81f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Wallace Pereira", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-01-14"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.86f, Peso = 87f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },
                new Jogador { Name = "Pedro Lucas", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-05-09"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.81f, Peso = 81f, PePreferido = PePreferido.Esquerdo, TimeId = times["Ceará"] },
                new Jogador { Name = "Rafael Lima", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-02-28"), Nacionalidade = "Brasileiro", NumCamisa = 31, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Ceará"] },

                // Vasco
                new Jogador { Name = "Fernando Miguel", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1985-11-24"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.88f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Jordy Gaspar", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1992-02-16"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Paulo Victor", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1988-03-15"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.88f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },

                new Jogador { Name = "Leandro Castán", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1985-01-27"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.83f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Ricardo Graça", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-10-25"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.89f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Sabino", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-03-02"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.88f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Luiz Gustavo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1995-05-20"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Marcos Felipe", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-06-18"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.87f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Nino", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-06-10"), Nacionalidade = "Brasileiro", NumCamisa = 27, Altura = 1.87f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Zeca", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-09-14"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },

                new Jogador { Name = "Andrey Santos", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2004-02-04"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.77f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Bruno Gomes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2001-10-02"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.76f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Jean Lucas", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-02-28"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Germán ", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-07-02"), Nacionalidade = "Argentino", NumCamisa = 14, Altura = 1.72f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Marquinhos", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-02-22"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.70f, Peso = 66f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Edimar", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1986-06-14"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.74f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },
                new Jogador { Name = "Calebe", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("2000-01-13"), Nacionalidade = "Brasileiro", NumCamisa = 48, Altura = 1.80f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Filipe", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1993-10-31"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Diego Pituca", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-10-29"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.76f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Andersinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1989-05-30"), Nacionalidade = "Paraguaio", NumCamisa = 22, Altura = 1.72f, Peso = 66f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },
                new Jogador { Name = "Matías Galarza", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("2002-11-19"), Nacionalidade = "Argentino", NumCamisa = 23, Altura = 1.77f, Peso = 71f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },

                new Jogador { Name = "Talles Magno", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-06-26"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.76f, Peso = 66f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },
                new Jogador { Name = "Gerundio", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1988-07-02"), Nacionalidade = "Argentino", NumCamisa = 14, Altura = 1.72f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Ribamar", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-10-09"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.77f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Gabriel Pec", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-03-09"), Nacionalidade = "Brasileiro", NumCamisa = 13, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Vasco"] },
                new Jogador { Name = "Vinícius", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2001-07-16"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.82f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Anderson Conceição", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("2002-06-05"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Roberto Dinamite", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1954-04-13"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.63f, Peso = 59f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Romário", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1966-01-29"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.67f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },
                new Jogador { Name = "Edmundo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1971-04-02"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.81f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Vasco"] },

                // América-MG
                new Jogador { Name = "Matheus Cavichioli", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1986-04-04"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.90f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Gabriel Mesquita", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-07-09"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.88f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "João Ricardo", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1986-09-29"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.89f, Peso = 83f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },

                new Jogador { Name = "Cacá", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("2001-05-03"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Marlon", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1994-09-02"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Jemerson", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-12-08"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.87f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Gabriel Paulista", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1987-11-26"), Nacionalidade = "Brasileiro", NumCamisa = 26, Altura = 1.90f, Peso = 86f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Diego Cardoso", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-02-19"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.84f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },

                new Jogador { Name = "Patrick", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1993-04-21"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.76f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Lucas Kal", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("2000-10-14"), Nacionalidade = "Brasileiro", NumCamisa = 13, Altura = 1.78f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },
                new Jogador { Name = "Nino Paraíba", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1986-02-17"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.75f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },

                new Jogador { Name = "Juninho Valoura", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1986-02-26"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Alan Franco", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1996-04-25"), Nacionalidade = "Equatoriano", NumCamisa = 16, Altura = 1.72f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Cazares", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1992-08-03"), Nacionalidade = "Equatoriano", NumCamisa = 8, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },

                new Jogador { Name = "Ademir", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-06-05"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Nathan Silva", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1997-04-27"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.78f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Rodrigo Pinho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1991-08-27"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.79f, Peso = 75f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },

                new Jogador { Name = "Jonathan Cafú", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1991-01-16"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.70f, Peso = 68f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Edigar Junio", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1987-01-01"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.73f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },
                new Jogador { Name = "Valdívia", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-04-14"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.81f, Peso = 73f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Cicero", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1979-06-18"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.78f, Peso = 79f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Bruno Nazário", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1995-01-19"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.80f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Anderson Conceição", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1989-11-14"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.88f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Dadá Maravilha", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1943-01-19"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.74f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Reinaldo", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1954-01-11"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.75f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Éder Aleixo", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1957-05-15"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.72f, Peso = 72f, PePreferido = PePreferido.Esquerdo, TimeId = times["América-MG"] },
                new Jogador { Name = "Washington Coração Valente", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1975-01-01"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.78f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Dicá", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1953-05-05"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.68f, Peso = 65f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Cláudio Taffarel", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1966-05-08"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.80f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },
                new Jogador { Name = "Toninho Cerezo", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1955-04-21"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.74f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["América-MG"] },

                // Sport
                new Jogador { Name = "Ivan Silva", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1995-10-03"), Nacionalidade = "Brasileiro", NumCamisa = 1, Altura = 1.88f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Saulo Santos", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1992-05-16"), Nacionalidade = "Brasileiro", NumCamisa = 12, Altura = 1.90f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Felipe Costa", Posicao = Posicao.Goleiro, DataNascimento = DateTime.Parse("1998-07-22"), Nacionalidade = "Brasileiro", NumCamisa = 22, Altura = 1.85f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },

                // Defensores
                new Jogador { Name = "Patric Souza", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1990-12-30"), Nacionalidade = "Brasileiro", NumCamisa = 2, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Natan Oliveira", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1997-11-10"), Nacionalidade = "Brasileiro", NumCamisa = 3, Altura = 1.90f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Derlan Ferreira", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1992-03-15"), Nacionalidade = "Brasileiro", NumCamisa = 4, Altura = 1.84f, Peso = 82f, PePreferido = PePreferido.Esquerdo, TimeId = times["Sport"] },
                new Jogador { Name = "Michel Macedo", Posicao = Posicao.LateralDireta, DataNascimento = DateTime.Parse("1990-04-21"), Nacionalidade = "Brasileiro", NumCamisa = 13, Altura = 1.80f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Ronaldo Lima", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1988-09-05"), Nacionalidade = "Brasileiro", NumCamisa = 5, Altura = 1.92f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Jefferson Ramos", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1993-02-14"), Nacionalidade = "Brasileiro", NumCamisa = 6, Altura = 1.87f, Peso = 85f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Jonathan Alves", Posicao = Posicao.LateralEsquerda, DataNascimento = DateTime.Parse("1994-08-19"), Nacionalidade = "Brasileiro", NumCamisa = 16, Altura = 1.84f, Peso = 83f, PePreferido = PePreferido.Esquerdo, TimeId = times["Sport"] },
                new Jogador { Name = "Carlos Eduardo", Posicao = Posicao.Zagueiro, DataNascimento = DateTime.Parse("1996-06-11"), Nacionalidade = "Brasileiro", NumCamisa = 14, Altura = 1.86f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },

                // Meio-campistas
                new Jogador { Name = "André Cruz", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1991-07-07"), Nacionalidade = "Brasileiro", NumCamisa = 8, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Lucas Gomes", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1998-12-01"), Nacionalidade = "Brasileiro", NumCamisa = 20, Altura = 1.82f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Guilherme Santos", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1994-03-20"), Nacionalidade = "Brasileiro", NumCamisa = 10, Altura = 1.76f, Peso = 70f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Diego Souza", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1985-03-03"), Nacionalidade = "Brasileiro", NumCamisa = 30, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Matheus Oliveira", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1997-05-14"), Nacionalidade = "Brasileiro", NumCamisa = 15, Altura = 1.78f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Fernando Henrique", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1990-10-30"), Nacionalidade = "Brasileiro", NumCamisa = 18, Altura = 1.80f, Peso = 81f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Rafael Andrade", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1995-09-12"), Nacionalidade = "Brasileiro", NumCamisa = 17, Altura = 1.79f, Peso = 74f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Thiago Carvalho", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1996-04-22"), Nacionalidade = "Brasileiro", NumCamisa = 19, Altura = 1.81f, Peso = 77f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Bruno Silva", Posicao = Posicao.Meia, DataNascimento = DateTime.Parse("1992-08-25"), Nacionalidade = "Brasileiro", NumCamisa = 23, Altura = 1.74f, Peso = 68f, PePreferido = PePreferido.Esquerdo, TimeId = times["Sport"] },
                new Jogador { Name = "Gustavo Mendes", Posicao = Posicao.Volante, DataNascimento = DateTime.Parse("1993-02-05"), Nacionalidade = "Brasileiro", NumCamisa = 27, Altura = 1.77f, Peso = 78f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },

                // Atacantes
                new Jogador { Name = "Hernane Brocador", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1985-05-18"), Nacionalidade = "Brasileiro", NumCamisa = 9, Altura = 1.86f, Peso = 84f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Mikael Santos", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1995-03-26"), Nacionalidade = "Brasileiro", NumCamisa = 11, Altura = 1.82f, Peso = 76f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Rodrigo Ribeiro", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1994-11-11"), Nacionalidade = "Brasileiro", NumCamisa = 21, Altura = 1.85f, Peso = 82f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Lucas Lima", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1998-08-12"), Nacionalidade = "Brasileiro", NumCamisa = 29, Altura = 1.68f, Peso = 65f, PePreferido = PePreferido.Esquerdo, TimeId = times["Sport"] },
                new Jogador { Name = "André Lima", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1992-06-30"), Nacionalidade = "Brasileiro", NumCamisa = 7, Altura = 1.75f, Peso = 72f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Rafael Martins", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1990-12-15"), Nacionalidade = "Brasileiro", NumCamisa = 33, Altura = 1.89f, Peso = 88f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Joelinton Silva", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1996-01-03"), Nacionalidade = "Brasileiro", NumCamisa = 24, Altura = 1.88f, Peso = 90f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Eduardo Souza", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1993-07-17"), Nacionalidade = "Brasileiro", NumCamisa = 28, Altura = 1.80f, Peso = 80f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] },
                new Jogador { Name = "Vinícius Pereira", Posicao = Posicao.Atacante, DataNascimento = DateTime.Parse("1997-09-28"), Nacionalidade = "Brasileiro", NumCamisa = 31, Altura = 1.78f, Peso = 75f, PePreferido = PePreferido.Direito, TimeId = times["Sport"] }
            );
            context.SaveChanges();

            context.ComissoesTecnicas.AddOrUpdate(c => new { c.Nome, c.TimeId },
                // Flamengo 
                new ComissaoTecnica { Nome = "Renato Gaúcho", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-02-13"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Cleber Xavier", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1974-04-20"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Carlos Fortes", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1970-06-15"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Jorge Santos", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1975-09-05"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Mariana Silva", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1980-03-22"), TimeId = times["Flamengo"] },
                new ComissaoTecnica { Nome = "Patrícia Souza", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-07-18"), TimeId = times["Flamengo"] },

                // Palmeiras 
                new ComissaoTecnica { Nome = "Abel Ferreira", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1974-02-22"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "Flávio Luiz", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1970-05-10"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "Ricardo Mical", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-08-15"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "Sérgio Valentim", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1975-03-05"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "Carolina Lima", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-30"), TimeId = times["Palmeiras"] },
                new ComissaoTecnica { Nome = "João Oliveira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-07-12"), TimeId = times["Palmeiras"] },

                // Atlético Mineiro
                new ComissaoTecnica { Nome = "Cuca", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1963-06-07"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Eudes Pedro", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1970-01-15"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Wesley Oliveira", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-02-20"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Rogério Contreira", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1978-11-10"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Marina Ribacero", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1982-08-05"), TimeId = times["Atlético Mineiro"] },
                new ComissaoTecnica { Nome = "Ricardo Silva", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1980-03-22"), TimeId = times["Atlético Mineiro"] },

                // Fluminense
                new ComissaoTecnica { Nome = "Fernando Diniz", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1976-05-30"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Marcelo Oliveira", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1972-11-10"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Rafael Andrade", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1981-08-15"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Paulo Souza", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1979-03-22"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Isabela Costa", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1983-07-12"), TimeId = times["Fluminense"] },
                new ComissaoTecnica { Nome = "Carla Mendes", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1980-09-05"), TimeId = times["Fluminense"] },

               // Corinthians
                new ComissaoTecnica { Nome = "Vagner Mancini", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1966-09-14"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Diego Silva", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1975-02-28"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Leandro Castro", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1978-06-01"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Gustavo Ramos", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1982-12-10"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Mariana Teixeira", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-30"), TimeId = times["Corinthians"] },
                new ComissaoTecnica { Nome = "Renata Santos", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1981-04-20"), TimeId = times["Corinthians"] },

                // São Paulo
                new ComissaoTecnica { Nome = "Dorival Júnior", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-10-26"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Cícero Souza", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1974-07-03"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Rafael Santana", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-04-30"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Rogério Schumann", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1969-08-05"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Juliana Paiva", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1986-02-14"), TimeId = times["São Paulo"] },
                new ComissaoTecnica { Nome = "Marcos Oliveira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1978-11-22"), TimeId = times["São Paulo"] },

                // Botafogo
                new ComissaoTecnica { Nome = "Abel Braga", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1952-02-01"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Flávio Tenius", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1965-05-20"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Márcio Tropari", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-08-12"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Rafael Tyça", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1980-03-15"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Camila Fisiola", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1982-11-30"), TimeId = times["Botafogo"] },
                new ComissaoTecnica { Nome = "Pedro Fisioter", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1978-07-12"), TimeId = times["Botafogo"] },

                // Internacional
                new ComissaoTecnica { Nome = "Mano Menezes", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-07-07"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Wesley Carvalho", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1975-09-12"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Alex Oliveira", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-03-20"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Ivan Medina", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1978-11-05"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Camila Souza", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-06-15"), TimeId = times["Internacional"] },
                new ComissaoTecnica { Nome = "Juliana Castro", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-02-28"), TimeId = times["Internacional"] },

                // Cruzeiro
                new ComissaoTecnica { Nome = "Dorival Belaparte", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1957-02-25"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Fábio Braz", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1974-07-14"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Eduardo Ferreira", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-11-02"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Rafael Freitas", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1978-05-30"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Juliana Santos", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-09-18"), TimeId = times["Cruzeiro"] },
                new ComissaoTecnica { Nome = "Marcos Lima", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-03-11"), TimeId = times["Cruzeiro"] },

                // Grêmio
                new ComissaoTecnica { Nome = "Renato Portaluppi", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-02-13"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Paulo Turqueza", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1973-01-19"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Cláudio Mix", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1970-09-15"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Anderson Martins", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1975-11-11"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Juliana Rocha", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1988-07-22"), TimeId = times["Grêmio"] },
                new ComissaoTecnica { Nome = "Roberto Souza", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1982-12-05"), TimeId = times["Grêmio"] },

                // Santos
                new ComissaoTecnica { Nome = "Paulo Turra", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1972-12-01"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Ricardo Abraham", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1978-04-10"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Bruno Barra", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1982-09-05"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Rafael Freire", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1979-02-20"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Jerundia Santos", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1986-07-15"), TimeId = times["Santos"] },
                new ComissaoTecnica { Nome = "Pedro Carvalho", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1983-11-03"), TimeId = times["Santos"] },

                // Athletico-PR
                new ComissaoTecnica { Nome = "Luiz Felipe Scolari", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1948-11-09"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "Guilherme Macuglia", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1963-05-28"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "Fernando Raposo", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-02-14"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "João Pegoraro", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1972-08-16"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "Renata Silva", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1980-06-05"), TimeId = times["Athletico-PR"] },
                new ComissaoTecnica { Nome = "Carlos Meira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1984-09-20"), TimeId = times["Athletico-PR"] },

                // Fortaleza
                new ComissaoTecnica { Nome = "Leandro Zago", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1981-03-30"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Diogo Ygor", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1978-07-15"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Jose Costa", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-05-12"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Fábio Moura", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1980-12-01"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Gabriela Lima", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1984-10-25"), TimeId = times["Fortaleza"] },
                new ComissaoTecnica { Nome = "Rafael Borges", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1979-06-08"), TimeId = times["Fortaleza"] },

                // Bahia
                new ComissaoTecnica { Nome = "Enderson Moreira", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1966-04-17"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Alberto Carlos", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1972-09-14"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Roberto Silva", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-02-28"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Fabio Santos", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1978-07-03"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Carolina Mendes", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-12"), TimeId = times["Bahia"] },
                new ComissaoTecnica { Nome = "Juliana Souza", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1983-08-24"), TimeId = times["Bahia"] },

                 // Coritiba
                 new ComissaoTecnica { Nome = "Gustavo Bonaparte", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1979-09-07"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "João Paulo", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1981-11-12"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "Marcos Souza", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1978-04-22"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "Felipe Gomes", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1983-02-15"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "Ana Beatriz", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1987-06-30"), TimeId = times["Coritiba"] },
                new ComissaoTecnica { Nome = "Rafael Lima", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1985-12-05"), TimeId = times["Coritiba"] },

                // Goiás
                new ComissaoTecnica { Nome = "Gustavo Morínigo", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1977-08-20"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Carlos Eduardo", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1980-04-15"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Gustas Santos", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-12-10"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Maurício Gomes", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1982-03-05"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Beatriz Oliveira", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-11-30"), TimeId = times["Goiás"] },
                new ComissaoTecnica { Nome = "Lucas Ferreira", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1988-07-12"), TimeId = times["Goiás"] },

                // Ceará
                new ComissaoTecnica { Nome = "Júnior Camargo", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1962-04-25"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Marcos Valadares", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1972-03-15"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Bruno Quintella", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-07-08"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Rafael Santos", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1978-12-10"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Carla Gomes", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1983-05-21"), TimeId = times["Ceará"] },
                new ComissaoTecnica { Nome = "Paulo Henrique Barros", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1980-09-01"), TimeId = times["Ceará"] },

                // Vasco
                new ComissaoTecnica { Nome = "Jorge Jesus", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1954-07-24"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Zé Teodoro", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1963-09-16"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Andrey Lopes", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-02-12"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Helton Leite", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1988-08-17"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Fernanda Rocha", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1982-11-05"), TimeId = times["Vasco"] },
                new ComissaoTecnica { Nome = "Ricardo Santos", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1979-04-20"), TimeId = times["Vasco"] },

                // América-MG
                new ComissaoTecnica { Nome = "Paulo Henrique Costa", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1970-05-10"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Marcelo Girafales", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1975-08-12"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Eduardo Santos", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1980-03-20"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Jefferson Ribeiro", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1982-11-30"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Aline Ferreira", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1985-07-15"), TimeId = times["América-MG"] },
                new ComissaoTecnica { Nome = "Rodrigo Lima", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1978-02-28"), TimeId = times["América-MG"] },

                // Sport
                new ComissaoTecnica { Nome = "Vanderlei Luxemburgo", Cargo = Cargo.Treinador, DataNascimento = DateTime.Parse("1952-05-10"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Ailton Silva", Cargo = Cargo.Auxiliar, DataNascimento = DateTime.Parse("1968-04-01"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Tiago Santos", Cargo = Cargo.PreparadorFisico, DataNascimento = DateTime.Parse("1975-07-20"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Bruno Santos", Cargo = Cargo.TreinadorGoleiro, DataNascimento = DateTime.Parse("1978-06-15"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Marina Sousa", Cargo = Cargo.Fisiologista, DataNascimento = DateTime.Parse("1982-09-10"), TimeId = times["Sport"] },
                new ComissaoTecnica { Nome = "Rafael Cardoso", Cargo = Cargo.Fisioterapeuta, DataNascimento = DateTime.Parse("1987-12-05"), TimeId = times["Sport"] }
            );
            context.SaveChanges();
        }
    }
}
