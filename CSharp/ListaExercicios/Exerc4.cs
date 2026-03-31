using static System.Console; 

namespace ListaExercicios
{
    class Exerc4 
    {
        public void Metodo()
        {
 
            int escolha = 0;
            DateTime agora = DateTime.Now;

            Console.WriteLine("Bem vindo!\nFormatos disponíveis:");
            Console.WriteLine($"1- Utilizar configuração do sistema: {agora} \n2- Formato simples: {agora.ToString("dd-MM-yy")}\n3- Formato longo: {agora.ToString("dddd, d 'de' MMMM 'de' yyyy")}");
            Console.Write($"4- Formato longo personalizado: {agora.ToString("dd-MM-yyyy HH:mm:ss")}\n5- Formato RFC1123 pattern: {DateTime.UtcNow.ToString("R")}\nEscolha a opção desejada: ");
            escolha = int.Parse(Console.ReadLine());

            while (escolha < 1 || escolha > 5) 
            {
                Console.Write("Opção indisponível. Selecione entre 1 e 5.\nOpção desejada: ");
                escolha = int.Parse(Console.ReadLine());
            }


            
 
 
 
 
 
 
        }
    }
}