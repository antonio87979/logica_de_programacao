
//escreva um programa que solicite ao usuário a quantidade em litros abastecidos em um automóvel.
//em seguida, o programa deve solicitar que o usuário informe a quantidade de kilometros percorridos até o término do tanque.
// o programa deve exibir a quantidade de kilometros por litro

Console.WriteLine("Quantidade em litros abastecidos");
int litrosAbastecidos = int.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de quilômetros percorridos");
int quilometros = int.Parse(Console.ReadLine());

int totalkm = quilometros / litrosAbastecidos;

Console.Clear();    

Console.WriteLine($"Você percorreu {totalkm}Km pot litro");

