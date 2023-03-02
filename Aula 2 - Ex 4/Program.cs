//decimal[] precos = new decimal[] { 10.50m, 1.50m, 55.20m, 10.20m, 2.00m };
List<decimal> listProducts = new List<decimal>() { 10.50m, 1.50m, 55.20m, 10.20m, 2.00m };
decimal total = 0;

listProducts.Sort();
listProducts.Reverse();

Console.WriteLine("Produtos:");
foreach(decimal p in listProducts)
{
    Console.WriteLine($"R$ {p}");
    total += p;
}
Console.WriteLine($"Total: {total}");
