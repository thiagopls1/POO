string nome = "Thiago";
char sala = 'B';
int idade = 18;
decimal salarioHora = 10.50m; // Precisa do M
float tamanho = 1.95f;
bool dp = false;

// Precisa dos parenteses para fazer soma, para não concatenar
Console.WriteLine(nome + " " + "(" + sala + ") - " + idade + " - Salario: R$" + (salarioHora + 50) + " - DP: " + dp);

string mensagem = "Apagar";
// $ = Variável sem concatenar
// @ = Imprimir o texto exato
Console.WriteLine($@"C:\Arquivos de Programa(X86)\dotnet {mensagem}");

int valor1 = 1;
int valor2 = 2;

Console.WriteLine("Soma:"+ valor1+valor2);