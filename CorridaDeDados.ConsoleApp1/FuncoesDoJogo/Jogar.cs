using CorridaDeDados.ConsoleApp1.Telas;
using System;

namespace CorridaDeDados.ConsoleApp1.FuncoesDoJogo
{
    public class Jogar
    {
        FuncoesJogo funcoesJogo = new FuncoesJogo();
        Telas.Telas tela = new Telas.Telas();

        int vitoriasJogador = 0;
        int vitoriasComputador = 0;
        int pontosTotaisJogador = 0;
        int pontosTotaisComputador = 0;

        public void IniciarJogo()
        {
            while (true)
            {
                tela.MenuInicial();
                string opcao = Console.ReadLine();

                if (opcao == "1")
                {
                    bool jogadorVenceu = funcoesJogo.Turnos();

                    if (jogadorVenceu == true)
                    {
                        vitoriasJogador++;
                        pontosTotaisJogador += 30;
                    }
                    else if (jogadorVenceu == false)
                    {
                        vitoriasComputador++;
                        pontosTotaisComputador += 30;
                    }
                }
                else if (opcao == "2")
                {
                    tela.HistoriaVitorias(vitoriasJogador, vitoriasComputador, pontosTotaisComputador, pontosTotaisJogador);
                }
                else if (opcao == "3")
                {
                    Console.WriteLine("Saindo do jogo...");
                    break;
                }
                else
                {
                    Console.WriteLine("Opção inválida. Tente novamente!");
                }

                Console.WriteLine("\nPressione qualquer tecla para continuar...");
                Console.ReadKey();
                Console.Clear();
            }
        }
    }
}
