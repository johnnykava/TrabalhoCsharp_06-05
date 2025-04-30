using System;
using System.Reflection.Metadata;

namespace Exercicio02{
    class Program{
        static void Main(string[] args){
            int numero;

            Console.WriteLine("Digite um número que deseja a tabuada: ");
            numero = int.Parse(Console.ReadLine());

            for(int i = 0; i <= 10; i++){
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}