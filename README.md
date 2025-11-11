🏎️ Corrida de Dados

Um jogo de corrida simples e divertido no console, onde você e o computador competem em uma pista virtual rolando dados 🎲.
O primeiro a cruzar a linha de chegada vence!

🎯 Objetivo do Jogo

O jogador e o computador rolam dados virtuais para avançar em uma pista numérica.
Quem alcançar ou ultrapassar primeiro a posição final (ex: 30) vence a corrida.

⚙️ Como Funciona

Cada turno, o jogador e o computador rolam um dado (1 a 6).

O valor obtido é somado à posição atual.

O jogo mostra o progresso visual da corrida com ícones 🏎️ (jogador) e 🚗 (computador).

A corrida continua até que um dos dois cruze a linha de chegada 🏁.

Eventos especiais tornam o jogo mais interessante!

💥 Eventos Especiais
Tipo de Evento	Posições Afetadas	Efeito
Avanço extra	5, 10, 15	+3 casas
Recuo	7, 13, 20	-2 casas
Rodada extra	— (tirar 6)	Joga novamente
💻 Controles

Enter → Rolar o dado

O computador joga automaticamente em seguida

🧠 Conceitos de Programação Usados

Geração de números aleatórios (Random.Next())

Estruturas de repetição (while)

Condicionais (if, else if, else)

Interação com o usuário (Console.ReadKey())

Lógica de turnos e eventos

Exibição visual dinâmica no console

🧩 Estrutura do Projeto
CorridaDeDados/
│
├── FuncoesDoJogo/
│   ├── FuncoesJogo.cs
│   └── Jogar.cs
│
├── Telas/
│   └── Telas.cs
│
└── Program.cs

🆕 Novidades da Última Versão

Pista visual com carros 🏎️ e 🚗 se movendo conforme os pontos

Exibição dos dados 🎲 após cada rodada

Eventos de avanço, recuo e rodada extra

Interface do console mais divertida e dinâmica

Lógica de vitória e empate aprimorada

🚀 Como Executar

Abra o projeto no Visual Studio ou VS Code.

Compile e execute o projeto (Ctrl + F5).

Divirta-se jogando sua Corrida de Dados! 🏁
