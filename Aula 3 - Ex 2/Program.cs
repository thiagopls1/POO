using Aula3Ex2;
int turno = 0;

Status arqueiroStatus = new Status();
arqueiroStatus.forca = 20;
arqueiroStatus.defesa = 10;
arqueiroStatus.sorte = 80;
arqueiroStatus.vida = 75;

Heroi heroi = new Heroi();
heroi.nome = "Jorge Silva";
heroi.tipo = "Arqueiro";
heroi.status = arqueiroStatus;

Status goblinStatus = new Status();
goblinStatus.forca = 15;
goblinStatus.defesa = 15;
goblinStatus.sorte = 25;
goblinStatus.vida = 50;

Monstro monstro = new Monstro();
monstro.nome = "Goblin Bolado";
monstro.tipo = "Goblin";
monstro.status = goblinStatus;

Console.WriteLine($"Herói");
Console.WriteLine($"Nome: {heroi.nome}");
Console.WriteLine($"Tipo: {heroi.tipo}\n");

Console.WriteLine($"Monstro");
Console.WriteLine($"Nome: {monstro.nome}");
Console.WriteLine($"Tipo: {monstro.tipo}\n");

while(monstro.status.vida > 0 || heroi.status.vida > heroi.Ataca(monstro))
monstro.Ataca(heroi);
}

if (monstro.status.vida <= 0)
{
    Console.WriteLine($"\n{heroi.nome} ganhou a batalha!");
}else if (heroi.status.vida <= 0)
{
    Console.WriteLine($"\n{monstro.nome} ganhou a batalha!");
}

