using System;

namespace Exercicio07{
    class Program{
        static void Main(string[] args) {

            int[] numeros = new int[10];
            int soma = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"Numero {i + 1}:");
                numeros[i] = int.Parse(Console.ReadLine());
                if (numeros[i] % 2 == 0) {
                    soma += numeros[i];
                }
            }

            Console.WriteLine($"Soma dos PARES: {soma}");
            }
        }
    }

