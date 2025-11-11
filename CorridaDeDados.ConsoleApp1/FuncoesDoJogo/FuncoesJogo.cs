using CorridaDeDados.ConsoleApp1.Telas;
using System;
using System.Threading;

namespace CorridaDeDados.ConsoleApp1.FuncoesDoJogo
{
    public class FuncoesJogo
    {
        public bool Turnos()
        {
            int jogador = 0;
            int computador = 0;
            int linhaDeChegada = 30;
            Random random = new Random();
            Telas.Telas tela = new Telas.Telas();

            Console.Clear();
            Console.WriteLine("Corrida iniciada! 🏁\n");

            while (jogador < linhaDeChegada && computador < linhaDeChegada)
            {
                // --- TURNO DO JOGADOR ---
                Console.WriteLine("\nSeu turno! Pressione ENTER para rolar o dado...");
                Console.ReadKey();

                int dadoJogador = random.Next(1, 7);
                Console.WriteLine($"🎲 Você rolou {dadoJogador}!");
                jogador += dadoJogador;

                // Evento: rodada extra se tirar 6
                if (dadoJogador == 6)
                {
                    Console.WriteLine("✨ Você tirou 6! Ganhou uma rodada extra!");
                    int dadoExtra = random.Next(1, 7);
                    Console.WriteLine($"🎲 Rodada extra: você rolou {dadoExtra}!");
                    jogador += dadoExtra;
                }

                // Eventos especiais
                jogador = AplicarEventosEspeciais("Jogador", jogador);
                if (jogador > linhaDeChegada) jogador = linhaDeChegada;

                // Atualiza pista
                tela.ExibirPista(jogador, computador, linhaDeChegada, dadoJogador, null);

                Thread.Sleep(1000);

                if (jogador >= linhaDeChegada) break;

                // --- TURNO DO COMPUTADOR ---
                Console.WriteLine("\nTurno do computador...");
                Thread.Sleep(800);

                int dadoComputador = random.Next(1, 7);
                Console.WriteLine($"💻 Computador rolou {dadoComputador}!");
                computador += dadoComputador;

                // Evento: rodada extra se tirar 6
                if (dadoComputador == 6)
                {
                    Console.WriteLine("💻 Computador tirou 6! Ganhou uma rodada extra!");
                    int dadoExtraComp = random.Next(1, 7);
                    Console.WriteLine($"🎲 Rodada extra: computador rolou {dadoExtraComp}!");
                    computador += dadoExtraComp;
                }

                // Eventos especiais
                computador = AplicarEventosEspeciais("Computador", computador);
                if (computador > linhaDeChegada) computador = linhaDeChegada;

                tela.ExibirPista(jogador, computador, linhaDeChegada, dadoJogador, dadoComputador);
                Thread.Sleep(1000);
            }

            // --- RESULTADO FINAL ---
            Console.WriteLine("\n=== RESULTADO FINAL ===");
            if (jogador >= linhaDeChegada && computador >= linhaDeChegada)
            {
                Console.WriteLine("🤝 Empate!");
                return false;
            }
            else if (jogador >= linhaDeChegada)
            {
                tela.TelaVitoriaJogador();
                return true;
            }
            else
            {
                Console.WriteLine("💻 O computador venceu a corrida de dados. Tente novamente!");
                return false;
            }
        }

        private int AplicarEventosEspeciais(string nome, int posicao)
        {
            // Avanço extra
            if (posicao == 5 || posicao == 10 || posicao == 15)
            {
                Console.WriteLine($"🚀 {nome} ganhou avanço extra de +3 casas!");
                posicao += 3;
            }
            // Recuo
            else if (posicao == 7 || posicao == 13 || posicao == 20)
            {
                Console.WriteLine($"⚠️ {nome} caiu em uma armadilha e recuou 2 casas!");
                posicao -= 2;
                if (posicao < 0) posicao = 0;
            }

            return posicao;
        }
    }
}
