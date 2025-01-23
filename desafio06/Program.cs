//se totakmporlitro for maior que 9 exibir mensage: carro econômico, se consumo medio entre 6, 5 e 9 exibir a mensagem: "carro com consumo mediano", abaixo de 6,5 exibir a mensagem: "carro com consumo alto". Você não deve apagar nenhuma linha escrita até entã. exceto se for melhorar o exercício.

Console.WriteLine("Quantidade em litros abastecidos");
double litrosAbastecidos = double.Parse(Console.ReadLine());

Console.WriteLine("Quantidade de quilômetros percorridos");
double quilometros = double.Parse(Console.ReadLine());


double totalKmPorLitro = quilometros / litrosAbastecidos;
Console.WriteLine("voce faz " + totalKmPorLitro + " quilometros por litro");

if (totalKmPorLitro > 9 )
{
    Console.WriteLine("Carro econômico");
}
else if (totalKmPorLitro >= 6.5 &&  totalKmPorLitro < 9 )
{

}