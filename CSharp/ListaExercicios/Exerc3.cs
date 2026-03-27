using static System.Console; 

namespace ListaExercicios
{
    class Exerc3 
    { 
        public void Metodo() { 

            int rodadas = 0;

            Console.WriteLine("Bem vindo ao Jogo!");
            Console.Write("Escolha a quantidade de rodadas (1 a 5): ");
            rodadas = Console.ReadLine();

            while(rodadas < 1 || rodadas > 5) //nao deixa o numero de rodadas ser menor que 1 nem maior que 5
            {
                Console.Write("Quantidade de rodadas inválidas. Escolha um número entre 1 a 5: ");
                rodadas = Console.ReadLine();
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

            Random random = new Random(); //cria o objeto randomico para conseguirmos os numeros aleatorios
            int rodadaAtual = 1;
            int numJogador1 = 0;
            int numJogador2 = 0;

            while(rodadaAtual <= rodadas)
            {
                Console.WriteLine("Rodada " + rodadaAtual);
                numJogador1 = random.Next(1, 11);
                numJogador2 = random.Next(1, 11);
                
                if(numJogador1 > numJogador2)
                {

                }

                //na ultima rodada se empatar, cria-se mais uma | if(numJogador1 for igual a numJogador2 E rodadaAtual = rodadas {})

            }

            


        }
    }
}