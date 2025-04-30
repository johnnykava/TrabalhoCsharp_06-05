using System;

namespace Exercicio03{
    class Program{
        static void Main(string[] args){
            int numero, fatorial = 1;

            Console.WriteLine("Digite um número inteiro positivo: ");
            numero = int.Parse(Console.ReadLine());

            for(int i = 1; i < numero; i++){
                fatorial += i * fatorial;
            }

            Console.WriteLine($"O fatorial do número {numero} é {fatorial}");
        }
    }
}