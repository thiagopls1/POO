using Aula3;

Random random = new Random();

Piloto marcos = new Piloto();
marcos.nome = "Marcos Silva Santos";
marcos.habilidade = 85;
marcos.numero = 4;

Piloto cleyton = new Piloto();
cleyton.nome = "Cleyton Hasta";
cleyton.habilidade = 99;
cleyton.numero = 24;

Carro hb20 = new Carro();
hb20.aceleracao = 5;
hb20.velocidadeMax = 180;
hb20.velocidadeAtual = 0;

Carro celta = new Carro();
celta.aceleracao = 7;
celta.velocidadeMax = 150;
celta.velocidadeAtual = 0;

marcos.EscolherCarro(hb20);
cleyton.EscolherCarro(celta);

Console.WriteLine($"Piloto do HB20: {hb20.piloto.nome}");
Console.WriteLine($"Piloto do Celta: {celta.piloto.nome}");

for (int i = 0; i < 50; i++)
{
    hb20.Acelerar();
    celta.Acelerar();

    if (random.Next(1, 100) < celta.piloto.ChanceErro())
    {
        celta.Acidente(hb20);
        Console.WriteLine("O Celta bateu no HB20!");
    }
    if (random.Next(1, 100) < hb20.piloto.ChanceErro())
    {
        hb20.Acidente(celta);
        Console.WriteLine("O HB20 bateu no Celta!");
    }
}

Console.WriteLine($"HB20: {hb20.kmAtual} ");
Console.WriteLine($"Celta: {celta.kmAtual}\n");

celta.Acidente(hb20);

if (hb20.kmAtual > celta.kmAtual)
{
    Console.WriteLine("O HB20 ganhou!");
}
if (celta.kmAtual > hb20.kmAtual)
{
    Console.WriteLine("O Celta ganhou!");
}

