using System;

namespace Exercicio08{
    class Program{
        static void Main(string[] args)
        {

            Console.Write("Digite seu peso (Kg): ");
            double peso = double.Parse(Console.ReadLine());

            Console.Write("Digite seua Altura (M): ");
            double altura = double.Parse(Console.ReadLine());

            double imc = peso / (altura * altura);
            Console.WriteLine($"Seu IMC é: {imc:F2}");

            if (imc < 18.5) {
                Console.WriteLine("Abaixo do Peso");
            }
            else if (imc < 25) {
                Console.WriteLine("Peso Normal");
            }
            else if (imc < 30) {
                Console.WriteLine("Sobrepeso");
            }
            else {
                Console.WriteLine("Obesidade");
            }
            }
        }
    }

