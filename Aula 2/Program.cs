Random dado = new Random();

int valor1 = dado.Next(1,6);
int valor2 = dado.Next(1,6);
int valor3 = dado.Next(1,6);
int pontos = valor1 + valor2 + valor3;

Console.Write($"{valor1} ");
Console.Write($"{valor2} ");
Console.WriteLine($"{valor3} ");

if(valor1 == valor2 && valor2 == valor3)
{
    pontos += 6;
    Console.WriteLine("3 dados iguais! +6 Pontos");
} else if(valor1 == valor2 || valor2 == valor3 || valor3 == valor1 )
{
    pontos += 2;
    Console.WriteLine("2 dados iguais! +2 Pontos");
}

Console.WriteLine($"Pontos: {pontos}");

if (pontos < 12)
{
    Console.WriteLine("Você perdeu =(");
}
if (pontos <= 15 && pontos >= 12)
{
    Console.WriteLine("Empate!");
}if (pontos > 15)
{
    Console.WriteLine("Você ganhou!");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadLine();


