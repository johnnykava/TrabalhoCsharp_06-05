# Atividade Avaliativa

Integrantes:
 - Johnny Luis Kava
 - Carlos Eduardo Bittencourt da Costa
 - Eversom Soares Fragozo Junior

# Exercicio 01:

Este programa em C# verifica se uma senha digitada pelo usuário é considerada forte.
Para isso, ele checa os seguintes critérios:

- A senha deve conter pelo menos 8 caracteres;

- Deve possuir letras maiúsculas;

- Deve possuir letras minúsculas;

- Deve possuir números;

- Deve conter ao menos um caractere especial (como @, #, !, %, etc).

O programa utiliza expressões regulares para validar cada um desses critérios e, ao final, informa se a senha é forte ou não é forte.

# Exercicio 02:

Este programa em C# solicita ao usuário que digite um número inteiro e, em seguida, exibe a tabuada desse número de 0 a 10.

O funcionamento é o seguinte:

- O número digitado é lido como uma string e convertido para inteiro com int.Parse();

- Um laço for percorre os valores de 0 até 10;

- A cada iteração, é exibida a multiplicação do número digitado pelo valor atual do índice, no formato:
“número x índice = resultado”.

# Exercicio 03:

Este programa em C# solicita ao usuário que digite um número inteiro positivo e, em seguida, calcula o fatorial desse número.

O funcionamento é o seguinte:

- Lê o número digitado como string e converte para inteiro usando int.Parse();

- Utiliza um laço for que vai de 1 até o número digitado;

- A cada iteração, multiplica o valor atual da variável fatorial pelo índice do laço;

- Ao final, exibe o resultado do fatorial.

# Exercicio 04:

Este programa em C# apresenta um menu interativo onde o usuário pode escolher entre:

- Converter Celsius para Fahrenheit

- Converter Fahrenheit para Celsius

- Sair do programa

O funcionamento é o seguinte:

- O programa usa um laço do-while para manter o menu ativo até que o usuário escolha a opção de sair;

- O switch trata as três opções possíveis:

    -  Opção 1: Lê a temperatura em Celsius e converte para Fahrenheit usando a fórmula:
       F = (C × 9/5) + 32

    -  Opção 2: Lê a temperatura em Fahrenheit e converte para Celsius usando a fórmula:
       C = (F - 32) × 5/9

    -  Opção 3: Finaliza o programa com uma mensagem de despedida;

    -  Caso o usuário digite uma opção inválida, o programa exibe uma mensagem de erro e repete o menu.

# Exercicio 05:

Este programa em C# verifica se a palavra digitada pelo usuário é um palíndromo, ou seja, se ela é lida da mesma forma de frente para trás e de trás para frente.

O programa:

- Lê uma palavra do usuário;

- Converte todos os caracteres para minúsculo (ignorando letras maiúsculas);

- Inverte a palavra armazenando os caracteres num novo array;

- Compara a palavra original com a invertida, letra por letra;

- Exibe se a palavra é ou não um palíndromo.


# Exercicio 06:
Este programa em C# cadastra três produtos com nome, preço e quantidade, e depois exibe um resumo com o valor total de cada produto.

O funcionamento é o seguinte:
- Cria um array de objetos Produto com tamanho 3;
- Para cada produto, solicita ao usuário o nome, o preço unitário e a quantidade;
- Usa o método totalProduto() da classe Produto para calcular o valor total (preço × quantidade);
- Ao final, exibe um resumo listando o nome de cada produto, sua quantidade e o valor total calculado com duas casas decimais.


# Exercicio 07:
Este programa em C# solicita ao usuário que digite 10 números inteiros e soma apenas os que forem pares.

O funcionamento é o seguinte:
- Cria um array de 10 posições para armazenar os números;
- Em um laço for, lê cada número digitado;
- Verifica se o número é par usando o operador módulo (% 2 == 0);
- Se for par, adiciona à variável soma;
- Ao final, exibe a soma total dos números pares digitados.


# Exercicio 08:
Este programa em C# calcula o IMC (Índice de Massa Corporal) do usuário com base em seu peso e altura, e exibe a classificação correspondente.

O funcionamento é o seguinte:
- Solicita que o usuário informe seu peso (em kg) e altura (em metros);
- Calcula o IMC usando a fórmula: IMC = peso / (altura × altura);
- Exibe o IMC com duas casas decimais;
- Usa estrutura if-else para classificar o resultado em:
  - Abaixo do peso (IMC < 18.5)
  - Peso normal (18.5 ≤ IMC < 25)
  - Sobrepeso (25 ≤ IMC < 30)
  - Obesidade (IMC ≥ 30)


# Exercicio 09:
Este programa em C# é um jogo de adivinhação onde o usuário tenta descobrir um número secreto entre 1 e 100.

O funcionamento é o seguinte:
- Gera um número aleatório entre 1 e 100 usando Random.Next();
- O programa entra em um laço while onde o usuário digita um palpite;
- Após cada tentativa, o programa informa se o número secreto é maior ou menor que o palpite;
- O laço continua até que o palpite esteja correto;
- Ao final, exibe uma mensagem de parabéns e o número de tentativas feitas até acertar.

# Exercicio 10:
Este programa em C# é um gerenciador simples de tarefas no console. Ele permite ao usuário adicionar tarefas, marcar tarefas como concluídas, listar tanto tarefas pendentes quanto concluídas, e encerrar o programa. O fluxo de funcionamento é o seguinte:

- O programa exibe um menu com quatro opções:
   -  Adicionar tarefa — O usuário insere a descrição de uma nova tarefa, que é adicionada à lista de tarefas pendentes.

   -  Completar tarefa — O programa lista as tarefas pendentes e permite ao usuário selecionar uma para marcar como concluída (a tarefa é movida para a lista de tarefas concluídas).

   -  Listar tarefas — Mostra tanto as tarefas pendentes quanto as concluídas.

   -  Sair — Encerra o programa.

- O programa continua em um loop (while) até o usuário escolher a opção de sair. Também há validações básicas para evitar entradas inválidas (como selecionar um número de tarefa inexistente).
