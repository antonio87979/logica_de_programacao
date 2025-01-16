

Console.WriteLine("digite um número"); 
    
int num = int.Parse(Console.ReadLine());
//contador
int contador = 10;

do
{
    Console.WriteLine(contador);
    contador -= 5; //decrementa o contador em 2
}
while (num <= contador);
{
    
}

// Exercício 6: Crie um programa que solicite ao usuário um número e imprima todos os números de 1 até o número informado usando um laço `while`.

Console.Write("Digite um número: ");

int numero = int.Parse(Console.ReadLine());
int contador = 1;

while (contador <= numero)
{
    Console.WriteLine(contador);
    contador++;
}