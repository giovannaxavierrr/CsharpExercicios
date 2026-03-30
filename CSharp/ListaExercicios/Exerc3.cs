using static System.Console; 

namespace ListaExercicios
{
    class Exerc3 
    {
        public void Metodo()
        {

            
            int rodadas = 0;

            Console.WriteLine("Bem vindo ao Jogo!");
            Console.Write("Escolha a quantidade de rodadas (1 a 5): ");
            rodadas = int.Parse(Console.ReadLine());

            while(rodadas < 1 || rodadas > 5) //nao deixa o numero de rodadas ser menor que 1 nem maior que 5
            {
                Console.Write("Quantidade de rodadas inválidas. Escolha um número entre 1 a 5: ");
                rodadas = int.Parse(Console.ReadLine());
            }

            string jogador1 = "";
            string jogador2 = "";

            Console.Write("Digite o nome do jogador 1: ");
            jogador1 = Console.ReadLine();

            Console.Write("Digite o nome do jogador 2: ");
            jogador2 = Console.ReadLine();

            while(jogador1 == jogador2) //não deixa os nomes serem iguais
            {
                Console.Write("Os nomes dos jogadores devem ser diferentes. Digite novamente o nome do jogador 2: ");
                jogador2 = Console.ReadLine();
            }

            IniciarRodadas(1, rodadas, jogador1, jogador2, 0, 0);

            /*
            Random random = new Random(); //cria o objeto randomico para conseguirmos os numeros aleatorios
            int[] pontos1 = new int[rodadas];
            int[] pontos2 = new int[rodadas];
            int pontuacao1 = 0;
            int pontuacao2 = 0;
            int rodadaAtual = 1;

            for (int i = 0; i < rodadas; i++)
            {
                Console.WriteLine("\nRodada " + (i+1));
                pontos1[i] = random.Next(1, 7); //dado de 1 a 6
                pontos2[i] = random.Next(1, 7); 

                Console.WriteLine($"{jogador1} tirou: {pontos1[i]}");
                Console.WriteLine($"{jogador2} tirou: {pontos2[i]}");

                if(pontos1[i] == pontos2[i])
                {
                    pontos1[i] = 0;
                    pontos2[i] = 0;
                    Console.WriteLine("Empate!\nNenhum dos jogadores pontuou");
                }
                else if(pontos1[i] > pontos2[i])
                {
                    Console.WriteLine($"{jogador1} tirou o número {pontos1[i]} e {jogador2} o número {pontos2[i]}. {jogador1} venceu a rodada {(i+1)}!");
                    pontuacao1 += 1;
                }
                else
                {
                    Console.WriteLine($"{jogador2} tirou o número {pontos2[i]} e {jogador1} o número {pontos1[i]}. {jogador2} venceu a rodada {(i+1)}!");
                    pontuacao2 += 1;
                }

                Console.WriteLine($"Placar:     {jogador1}: {pontuacao1}   ||   {jogador2}: {pontuacao2}\n");

                if(pontuacao1 == pontuacao2 && i == (rodadas-1))
                {
                    rodadas += 1;
                }

                rodadaAtual += 1; //um indice de qual rodada está, para usarmos no metodo de recursão

            }

            if(pontuacao1 > pontuacao2)
            {
                Console.WriteLine($"{jogador1} venceu a disputa com {pontuacao1} pontos!!");
            }
            else if(pontuacao2 > pontuacao1)
            {
                Console.WriteLine($"{jogador2} venceu a disputa com {pontuacao2} pontos!!");
            }
            else
            {
                Console.WriteLine($"Houve um empate. Ambos jogadores conseguiram {pontuacao1} pontos.");
            }
            */

        }

        void IniciarRodadas(int rodadaAtual, int rodadas, string jogador1, string jogador2, int pontuacao1, int pontuacao2)
        {
            if(rodadaAtual > rodadas) //caso base (para a recursão)
            {
                Console.WriteLine("\nFim do jogo!");

                if (pontuacao1 > pontuacao2)
                {
                    Console.WriteLine($"{jogador1} venceu a disputa com {pontuacao1} pontos!!");
                }
                else if (pontuacao2 > pontuacao1)
                {
                    Console.WriteLine($"{jogador2} venceu a disputa com {pontuacao2} pontos!!");
                }
                else{
                    Console.WriteLine($"Houve um empate. Ambos jogadores conseguiram {pontuacao1} pontos.");
                }

                return;
            }

            Random random = new Random();
            int pontos1 = random.Next(1, 7); 
            int pontos2 = random.Next(1, 7);

            Console.WriteLine($"\nRodada {rodadaAtual}:");
            Console.WriteLine($"{jogador1} tirou: {pontos1}");
            Console.WriteLine($"{jogador2} tirou: {pontos2}");

            if(pontos1 == pontos2)
            {
                Console.WriteLine("Empate!\nNenhum dos jogadores pontuou");

                //se empatar na ultima rodada, cria mais uma
                if(rodadaAtual == rodadas)
                {
                    rodadas++;
                }

            }
            else if(pontos1 > pontos2)
            {
                Console.WriteLine($"{jogador1} tirou o número {pontos1} e {jogador2} o número {pontos2}. {jogador1} venceu a rodada {rodadaAtual}!");
                pontuacao1++;
            }
            else
            {
                Console.WriteLine($"{jogador2} tirou o número {pontos2} e {jogador1} o número {pontos1}. {jogador2} venceu a rodada {rodadaAtual}!");
                pontuacao2++;
            }

            Console.WriteLine($"Placar:     {jogador1}: {pontuacao1}   ||   {jogador2}: {pontuacao2}\n");

            //essa é a chamada recursiva
            IniciarRodadas(rodadaAtual + 1, rodadas, jogador1, jogador2, pontuacao1, pontuacao2);

        }

    }
}