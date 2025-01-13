// escrever um programa que solicite dois números inteiros para o usuário e exiba a soma dos números

//int.parse transfrma em numero inteiro
//numerar as variaveis
// int = variável usada para preencher caixas de texto com números interios

Console.WriteLine("digite oprimeiro numero");
int numero1 =int.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo número");
int numero = int.Parse(Console.ReadLine());

Console.WriteLine("digite o segundo número");
int numero3 = int.Parse(Console.ReadLine());

Console.WriteLine("a soma é:" + (numero1 + numero + numero3));

//Console.WriteLine($"a soma é: {numero1 + numero + numero3}");  (com $ e {}, não é necessário o uso do sinal de adição)