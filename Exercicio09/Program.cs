using System;
using System.Runtime.InteropServices;

namespace Exercicio09{
    class Program{
        static void Main(string[] args)
        {

            Random rnd = new Random();

            int numSecreto = rnd.Next(1, 101);

            int tentativa = 0;
            int palpite = 0;

            Console.WriteLine("Tente adivinhar o numero entre 1 e 100.");

            while (palpite != numSecreto) {
                Console.Write("Digite seu Palpite: ");
                palpite = int.Parse(Console.ReadLine());
                tentativa++;

                if (palpite < numSecreto)
                {
                    Console.WriteLine("Numero e maior.");
                }
                else if (palpite > numSecreto)
                {
                    Console.WriteLine("Numero eh menor.");
                }
            }

                Console.WriteLine($"Parabens!!!! Voce acertou em {tentativa} tentativa(s)");
            }
        }
    }

