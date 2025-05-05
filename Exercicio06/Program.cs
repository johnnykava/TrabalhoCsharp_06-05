using System;

namespace Exercicio06{
    class Program{
        static void Main(string[] args){

            Produto [] produtos = new Produto[3];

            for (int i = 0; i < produtos.Length; i++) {
                produtos[i] = new Produto();
                    Console.WriteLine($"Produto {i + 1}:");
                    Console.WriteLine("Nome: ");
                    produtos[i].nome = Console.ReadLine();

                    Console.WriteLine("Preco: R$");
                    produtos[i].preco = double.Parse(Console.ReadLine());

                    Console.WriteLine("Quantidade: ");
                    produtos[i].quantidade = int.Parse(Console.ReadLine());

                    Console.WriteLine();
                } 

                Console.WriteLine("Resumo dos Produtos: ");
            Console.WriteLine();
            for (int i = 0; i < produtos.Length; i++)
            {

                Produto p = produtos[i];
                Console.WriteLine($"{p.nome} - {p.quantidade} unidades - Total: R$ {p.totalProduto():F2}");
                Console.WriteLine();
            }
                    
            }
        }
    }

    class Produto {

        public string nome;
        public double preco;
        public int quantidade;

        public double totalProduto () {
            return preco * quantidade;
        }
    }