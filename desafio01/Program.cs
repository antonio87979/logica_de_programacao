//escreva um programa que solicite o primeiro nome do usuário em seguida solicite o sobrenome do usuário. O programa deve apresentar uma mensagem de boas vindas e o nome completo do usuário.

Console.WriteLine("Digite seu nome");
string name = Console.ReadLine();

Console.WriteLine("Digite seu sobrenome:");
string name2 = Console.ReadLine();

Console.Clear();

Console.WriteLine($"Seja bem-vindo {name} {name2}");


