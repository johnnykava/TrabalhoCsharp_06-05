using System;

namespace Exercicio05{
    class Program{
        static void Main(string[] args){
            string palavra;
            bool polindromo = true;
            int p = 0;

            Console.WriteLine("Digite um palavra que deseja verificar se é polindromo: ");
            palavra = Console.ReadLine();

            palavra = palavra.ToLower();

            char[] palavraInversa = new char[palavra.Length];

            for(int i = palavra.Length - 1; i >= 0; i--){
                palavraInversa[p] = palavra[i];
                p++;
            }

            for(int i = 0; i < palavra.Length; i++){
                if(palavra[i] != palavraInversa[i]){
                    polindromo = false;
                    break;
                }
            }

            if(polindromo == true){
                Console.WriteLine("Essa palavra é um polindromo!");
            }
            else{
                Console.WriteLine("Essa palavra NÃO é um polindromo!");
            }
        }
    }
}