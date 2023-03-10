using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3Ex2
{
    internal class Heroi
    {
        public string nome;
        public string tipo;
        public Status status;

        public void Ataca(Monstro monstro)
        {
            Random prob = new Random();
            if (prob.Next(0, 100) < this.status.sorte)
            {
                monstro.status.vida = monstro.status.vida - ((this.status.forca * 2) - monstro.status.defesa);
                Console.WriteLine($"{this.nome} deu um ataque crítico em {monstro.nome}, tirando {this.status.forca * 2 - monstro.status.defesa} de vida!");
            }
            else
            {
                monstro.status.vida = monstro.status.vida - (this.status.forca - monstro.status.defesa);
                Console.WriteLine($"{this.nome} deu um ataque em {monstro.nome}, tirando {this.status.forca - monstro.status.defesa} de vida!");
            }
        }
    }
}
