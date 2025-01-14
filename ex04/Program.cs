
// tipos de dados
//  string variavel tipo texto

//variável de texto
string neme = "Antonio ";
Console.WriteLine($"o nome do usuario é:{neme}");

//variável de número inteiro
int idade = 38;
Console.WriteLine("a idade do usuário é:" + idade + "anos");

//variável de números com vírgula (F ao final, identificando o tipo de dado)
float carteira = 2.64F;

//variável de carácteres
char classificacao = 'A';
Console.WriteLine($"o cliente é do tipo {classificacao}");

//variavél de verdadeiro flaso/ classificação
bool dinheironaconta = true;
Console.WriteLine(dinheironaconta);

// variável de números com vírgula, com uma precisão maior que o float
double limitecredito = 2000.45;
Console.WriteLine($"limite de crédito: {limitecredito}");

string sobrenome = "Romeu";
Console.WriteLine($"bem-vindo senhor(A){sobrenome}");

string nomecompleto = (neme + sobrenome);
Console.WriteLine(nomecompleto);

double valornaconta = 54.78;
Console.WriteLine($"saldo em conta:{valornaconta}");

double limitetotal = valornaconta + limitecredito;
Console.WriteLine($"saldo e limite total: {limitetotal}");
