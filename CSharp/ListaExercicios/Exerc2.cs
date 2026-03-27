using static System.Console; 
using System.Globalization; //codigo nao ta aceitando numero com ".", então usamos isso pra forçar ele a ler o ponto

namespace ListaExercicios
{
    class Exerc2 
        { 
            public void Metodo() { 

                int verificarQtd = 0;
                int qtdNumeros = 0;

                Console.Write("Quantos numeros quer? Escolha entre 3 e 10:   ");
                verificarQtd = int.Parse(Console.ReadLine());

                while (verificarQtd < 3 || verificarQtd > 10) {
                    Console.WriteLine("Número inválido! Digite um numero entre 3 e 10");
                    verificarQtd = int.Parse(Console.ReadLine());
                }

                qtdNumeros = verificarQtd;

                double[] numeros = new double[qtdNumeros];
                
                for(int i = 0; i < qtdNumeros; i++)
                {
                    Console.Write($"Digite o {i+1}° numero: ");
                    numeros[i] = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture); //culture obriga ele a aceitar "."
                }

                double soma = numeros.Sum(); //.Sum() substitui o foreach pra somar os numeros dentro do array
                double media = numeros.Average(); //.Average ja faz a media de todos os numeros, não precisando somar eles antes!!

                /*
                foreach(double numero in numeros) //percorre todos os numeros da array
                {
                    soma += numero; //soma todos eles
                }

                double media = soma / qtdNumeros;
                */

                Console.WriteLine($"A soma dos numeros digitados é de: {soma:F2}, e a média deles é de {media:F2}"); //vai aparecer apenas 2 casas apos a virgula

            } 
        } 
}