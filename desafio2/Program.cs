//adapte o prgrama abaxio para solicitar a idade do usuário. Se o usuário maior de 18 exibir a mensagem maior de idade, se menor, exibir a mensagem menor de idade


/*Console.WriteLine("Digite seu nome");
string name = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");
string name2 = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Seja bem-vindo {name} {name2}");
*/


Console.WriteLine("Digite sua idade:");
int idade = int.Parse(Console.ReadLine());

Console.Clear();

if (idade >= 18)
{
    Console.WriteLine("Você é maior de idade");
}
else
{
    Console.WriteLine("Você é menor de idade");
}

