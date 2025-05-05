using System;
using System.Reflection.Metadata;

namespace Exercicio02{
    class Program{
        static void Main(string[] args){
            int numero;

            //Pede para o usuario digitar um numero
            Console.WriteLine("Digite um número que deseja a tabuada: ");
            //Convertemos esse numero que veio em string para um inteiro com o Parse()
            numero = int.Parse(Console.ReadLine());

            //Itera de 0 ate 10 e mostra o numero digitado, o indice do for e o resultado da multiplicação do numero digitado vezes o indice do for
            for(int i = 0; i <= 10; i++){
                Console.WriteLine($"{numero} x {i} = {numero * i}");
            }
        }
    }
}