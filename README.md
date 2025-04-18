# Projeto Liga Tabajara

## Índice

- [Visão Geral](#visão-geral)  
- [Instalação e Configuração](#instalação-e-configuração)  
- [Funcionalidades e Telas](#funcionalidades-e-telas)  
  - [Home (Dashboard)](#home-dashboard)  
  - [Times](#times)  
  - [Jogadores](#jogadores)  
  - [Comissão Técnica](#comissão-técnica)  
  - [Partidas](#partidas)  
- [Geração de Calendário](#geração-de-calendário)  
  - [Automática](#automática)  
  - [Manual / Alimentação em Massa via SQL](#manual--alimentação-em-massa-via-sql)  
- [Recalcular Estatísticas](#recalcular-estatísticas)  
- [Validações de Negócio](#validações-de-negócio)  
- [Tecnologias](#tecnologias)
- [Licença](#licença)  

---

## Visão Geral

O **Projeto Liga Tabajara** é um sistema web ASP.NET MVC para gerenciar um campeonato de futebol de 20 times. Ele cobre:

- Cadastro e validação de **Times**, **Jogadores** e **Comissão Técnica**  
- Geração de calendário de partidas (turno e returno)  
- Registro de resultados e distribuição automática de estatísticas de gols por jogador  
- Classificação com cores indicativas de qualificação, pré-Libertadores, Sul‑Americana e rebaixamento  
- Página inicial com tabela de classificação, agenda de partidas, celebração do campeão e resumo estatístico  

---

## Instalação e Configuração

1. Clone este repositório e abra no Visual Studio.  
2. Configure sua connection string em `Web.config` para apontar para seu banco SQL Server.  
3. Execute o _Entity Framework Migrations_ ou deixe o EF criar o schema automaticamente.  
4. Publique / rode localmente.  

---

## Funcionalidades e Telas

### Home (Dashboard)

- **Classificação**  
  - Exibe posição, jogos, vitórias, empates, derrotas, pontos, saldo de gols e status de aptidão.  
  - Bordas coloridas na coluna “#” indicam:  
    - Azul (1–4): Libertadores fase de grupos  
    - Laranja (5): Pré‑Libertadores  
    - Verde (6–12): Sul‑Americana  
    - Vermelho (17–20): Rebaixamento  
  - Ícones circulares mostram os últimos 5 resultados (✔ vitória, – empate, ✖ derrota, ○ não jogou).  
- **Agenda**  
  - Navegação por rodada, filtros por time e estádio.  
- **Celebração do Campeão**  
  - Ao finalizar todas as 38 rodadas com todos os resultados lançados, exibe banner comemorativo com nome do campeão e troféu.  
- **Resumo do Campeonato**  
  - Rodadas disputadas, partidas, gols totais, média de gols/partida  
  - Artilheiro (jogador com mais gols)  
  - Time com mais vitórias, empates e derrotas  

### Times

- Listagem completa com colunas: nome, cidade, estado, fundação, estádio, capacidade, cores de uniforme.  
- Ações: **Editar**, **Detalhes**, **Excluir**.  
- Possui caixas expansíveis (boxlists) para exibir **Jogadores** e **Comissão Técnica** de cada time diretamente na tabela.  

### Jogadores

- Listagem com filtros: nome, posição, pé preferido.  
- Cadastro / Edição com validação:
  - Não permite dois jogadores com mesmo **nome**, **data de nascimento**, **número de camisa** **e** **time**.
- Exclusão de jogador.  

### Comissão Técnica

- Listagem com filtro por cargo (Ex.: Técnico, Auxiliar, Preparador físico…).  
- Cadastro / Edição com validação:
  - Não permite duplicar **nome + data de nascimento + cargo**.
  - Um time só pode ter **um** profissional por cargo.
  - Limite máximo de **6** membros (um por cargo).  

### Partidas

- Listagem por rodada, com filtros por mandante/visitante e estádio.  
- Ações:
  - **Gerar Calendário** (automático)  
  - **Recalcular Estatísticas**  
  - **Limpar Calendário**  
  - **Novo Jogo** (manual)  
  - **Editar Resultado**  
- Validações na criação/edição:
  - Não permite mandante e visitante iguais.  
  - Não permite cadastrar ou gerar partida se algum dos dois times não estiver **apto** (mínimo 30 jogadores e 6 comissões).  
  - Não permite editar uma partida de rodada N se **alguma** partida da rodada N‑1 ainda não tiver resultado registrado.  

---

## Geração de Calendário

### Automática

1. Clique em **Ações ➔ Gerar Calendário** na tela de Partidas.  
2. O sistema:
   - Valida existência de **exatamente 20 times**.  
   - Embaralha aleatoriamente a lista de times.  
   - Gera **38 rodadas** (19 de ida + 19 de volta) usando algoritmo “círculo” de round‑robin.  
   - Datas são distribuídas começando na próxima segunda‑feira, a cada semana.  

### Manual  
1. Clique em **Ações ➔ Novo Jogo** na tela de Partidas.
   - Assim terá que cadastrar partida por partida.
     
### Alimentação em Massa via SQL

Depois que gera o calendário automaticamente, se preferir lançar resultados direto no banco:

1. **Execute um UPDATE** :

   ```sql
      UPDATE dbo.Partidas
      SET 
          GolsMandante  = ABS(CHECKSUM(NEWID())) % 6,   -- gera 0..5
          GolsVisitante = ABS(CHECKSUM(NEWID())) % 6
      WHERE GolsMandante IS NULL 
        AND GolsVisitante IS NULL;
  - Se for querer lançar os resultados manual, na tela de Partidas clicar em **Registrar placar** e vai de partida em partida, registrando o placar.
  - Da forma manual a estatística já vai sendo calculada automaticamente. 
  - Se preferir lançar os resultados pelo banco, é preciso seguir o seguinte passo a passo:
    - Navegue até **Partidas → Ações → Recalcular Estatísticas**.
---

## Recalcular Estatísticas

O recurso **Recalcular Estatísticas** foi pensado para os casos em que você alimenta os resultados das partidas diretamente no banco de dados (por exemplo, via scripts SQL) e precisa distribuir automaticamente os gols entre os jogadores e gerar todas as estatísticas de cada partida.

### Fluxo de uso

1. **Injete os resultados no banco**  
   - Execute `UPDATE` ou `INSERT` nas colunas `GolsMandante` e `GolsVisitante` da tabela `Partidas` para todas as rodadas desejadas.  
   - Exemplo para a 1ª rodada:  
     ```sql
     UPDATE Partidas
     SET GolsMandante = 2, GolsVisitante = 1
     WHERE Round = 1;
     ```
   - Repita conforme necessário para as demais rodadas (2, 3, …, 38).
   - Ou faça conforme mostrado no SQL da **Alimentação Em Massa Via SQL**

2. **Abra a tela de Partidas**  
   - Navegue até **Partidas → Ações → Recalcular Estatísticas**.

3. **Dispare o recálculo**  
   - O sistema irá:
     1. **Apagar** todos os registros existentes em `EstatisticasJogos`.
     2. **Percorrer** cada partida com placar preenchido em `Partidas`.
     3. **Distribuir** os gols entre os jogadores de linha de cada time (de forma aleatória) e **inserir** um novo registro em `EstatisticasJogos` para cada jogador que marcou.

## Validações de Negócio

| Entidade             | Regra                                                                                                     |
| -------------------- | --------------------------------------------------------------------------------------------------------- |
| **Time**             | • Máximo de 20 times cadastrados.<br>• Nome único.                                                        |
| **Jogador**          | • Cada time precisa ter no mínimo 30 jogadores.                                                           |
| **Comissão Técnica** | • Máximo de 6 membros (um por cargo).<br>• Todos os 6 cargos preenchidos → time “apto”.                   |
| **Partida**          | • Mandante ≠ Visitante.<br>• Só criar/editar se todos os times estiverem “aptos”.<br>• Só editar rodada N após todos os jogos da rodada N−1 estarem lançados. |

---

## Tecnologias

- **ASP.NET MVC 5**  
- **Entity Framework 6**  
- **Bootstrap 5** + **Bootstrap Icons**  
- **SQL Server**  

---

## Licença

Este projeto está licenciado sob a **MIT License**.  

   
