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