using static System.Console; 

namespace ListaExercicios
{
    class Program 
        { 
            public static void Main(string[] args) { 

                int exercicio = 0;
                Console.Write("Qual exercício deseja aplicar?  ");
                exercicio = int.Parse(Console.ReadLine());

                switch (exercicio)
                {
                    case 1:
                        Exerc1 ex1 = new Exerc1();
                        ex1.Metodo();
                    break;

                    case 2:
                        Exerc2 ex2 = new Exerc2();
                        ex2.Metodo();
                    break;

                    case 3:
                        Exerc3 ex3 = new Exerc3();
                        ex3.Metodo();
                    break;

                    default:
                    return;
                }  
            } 
        } 
}
