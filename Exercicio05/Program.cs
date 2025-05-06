using System;
using System.Globalization;
using System.Text;

namespace Exercicio05{
    class Program{
        static void Main(string[] args){
            string palavra;
            bool palindromo = true;
            int p = 0;

            //Pede para o usuario digitar uma string
            Console.WriteLine("Digite um palavra que deseja verificar se é palindromo: ");
            palavra = Console.ReadLine();

            //Tranforma toda a palavra em minuscula
            palavra = palavra.ToLower();

            //Remove os espaços da frase
            palavra = palavra.Replace(" ", "");

            //Usa a função de remover acentos
            palavra = RemoverAcentos(palavra);

            //Cria um array de caracteres que tem o tamanho da palavra digitada
            char[] palavraInversa = new char[palavra.Length];

            //Itera sobre todos os caracteres da palavra digitada
            for(int i = palavra.Length - 1; i >= 0; i--){
                //Adiciona no array "palavraInversa" os caracteres do indice do for
                //Como o for começa da ultima palavra é criando um novo indice para o array palavraInversa o indice "p" que começa em 0
                //Assim fazendo o array ter a palavra escrita pelo usuario de forma inversa
                palavraInversa[p] = palavra[i];
                p++;
            }

            //Itera sobre todos os caracteres da palavra digitada
            for(int i = 0; i < palavra.Length; i++){
                //Verifica se os caracteres não são iguais
                if(palavra[i] != palavraInversa[i]){
                    //Se não for, muda a variavel palindromo para false
                    palindromo = false;
                    //Finaliza o loop
                    break;
                }
            }

            //Se a variavel palindromo for verdadeira
            if(palindromo == true){
                //A palavra digitada pelo usario é um palindromo (Igual de tras para frente)
                Console.WriteLine("Essa palavra é um palindromo!");
            }
            //Se a variavel palindromo não for verdadeira
            else{
                //A palavra digitada pelo usuario não é um palindromo
                Console.WriteLine("Essa palavra NÃO é um palindromo!");
            }
        }

        static string RemoverAcentos(string texto){
            //Normaliza os caracteres da string para a forma FormD
            //Isso separa os caracteres acentuados em letra + acento
            var textoNormalizado = texto.Normalize(NormalizationForm.FormD);

            //Cria um StringBuilder (classe eficiente para manipular strings)
            var stringBuilder = new StringBuilder();

            //Percorre cada caractere da string normalizada
            foreach (char c in textoNormalizado){
                //Verifica a categoria Unicode do caractere
                var unicodeCategory = CharUnicodeInfo.GetUnicodeCategory(c);

                //Se o caractere não for um acento (NonSpacingMark), adiciona ele ao StringBuilder
                if (unicodeCategory != UnicodeCategory.NonSpacingMark){
                    stringBuilder.Append(c);
                }
            }

            //Retorna a nova string sem acentos e normaliza ela novamente para a forma C
            return stringBuilder.ToString().Normalize(NormalizationForm.FormC);
        }
    }
}