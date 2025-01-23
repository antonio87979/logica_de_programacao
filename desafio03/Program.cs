//adicionar uma mensagem para quando o usuário possuir 16 anos, pode entrar com autorização


Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

Console.Clear();

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade");
}
else if (idade >= 16)
{
    Console.WriteLine("Você pode entrar com autorização");
}
else
{
    Console.WriteLine("você é menor de idade");
}
