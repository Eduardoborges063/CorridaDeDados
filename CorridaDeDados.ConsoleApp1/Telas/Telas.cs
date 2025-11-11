using System;

namespace CorridaDeDados.ConsoleApp1.Telas
{
    public class Telas
    {
        public void MenuInicial()
        {
            Console.Clear();
            Console.WriteLine("==============================");
            Console.WriteLine("🏁 Corrida de Dados 🏎️");
            Console.WriteLine("==============================");
            Console.WriteLine("1. Iniciar Jogo");
            Console.WriteLine("2. Histórico de Vitórias");
            Console.WriteLine("3. Sair");
            Console.Write("Escolha uma opção: ");
        }

        public void ExibirPista(int posJogador, int posComputador, int tamanho, int? dadoJogador, int? dadoComputador)
        {
            Console.Clear();

            Console.WriteLine("🏁 Corrida de Dados\n");
            Console.WriteLine(ConstruirLinha("🏎️", posJogador, tamanho));
            Console.WriteLine(ConstruirLinha("🚗", posComputador, tamanho));

            Console.WriteLine("\n📊 Posições Atuais:");
            Console.WriteLine($"🏎️ Jogador: {posJogador}");
            Console.WriteLine($"💻 Computador: {posComputador}");

            if (dadoJogador.HasValue)
                Console.WriteLine($"🎲 Jogador tirou: {dadoJogador}");

            if (dadoComputador.HasValue)
                Console.WriteLine($"🎲 Computador tirou: {dadoComputador}");
        }

        private string ConstruirLinha(string simbolo, int posicao, int tamanho)
        {
            // Garante que o símbolo não ultrapasse a linha
            if (posicao > tamanho) posicao = tamanho;

            string linha = "|";

            for (int i = 0; i < tamanho; i++)
            {
                if (i == posicao)
                    linha += simbolo;
                else
                    linha += "-";
            }

            linha += "|🏁";
            return linha;
        }

        public void TelaVitoriaJogador()
        {
            Console.WriteLine("==========================================");
            Console.WriteLine("🏆 Parabéns! Você venceu a corrida de dados!");
            Console.WriteLine("==========================================");

            Console.WriteLine("Quer continuar?");
            string resposta = Console.ReadLine().ToLower();
            if (resposta == "sim" || resposta == "s")
            {
                Console.WriteLine("Reiniciando o jogo...");
            }
            else
            {
                Console.WriteLine("Obrigado por jogar! Até a próxima!");
                Environment.Exit(0);
            }
        }

        public void HistoriaVitorias(int vitoriasJogador, int vitoriasComputador, int pontosTC, int pontosTJ)
        {
            Console.Clear();
            Console.WriteLine("===================================");
            Console.WriteLine("📜 Histórico de Vitórias:");
            Console.WriteLine($"Jogador: {vitoriasJogador} vitórias | Pontos: {pontosTJ}");
            Console.WriteLine($"Computador: {vitoriasComputador} vitórias | Pontos: {pontosTC}");
            Console.WriteLine("===================================");
        }
    }
}
