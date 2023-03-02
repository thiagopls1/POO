Random random = new Random();
int dia = random.Next(10);

Console.WriteLine($"Dias restantes: {dia}");

if(dia >= 6 && dia <= 10)
{
    Console.WriteLine("Sua licença está terminando!");
}
if(dia >= 2 && dia <= 5)
{
    Console.WriteLine("Sua licença está terminando! Você tem 10% de desconto.");
}
if(dia == 1)
{
    Console.WriteLine("Falta 1 dia para sua licença terminar! Você tem 20% de desconto.");
}
if (dia == 0)
{
    Console.WriteLine("Sua assinatura acabou.");
}

Console.WriteLine("Pressione qualquer tecla para sair...");
Console.ReadLine();


