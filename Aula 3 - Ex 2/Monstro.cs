using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Aula3Ex2
{
    internal class Monstro
    {
        public string nome;
        public string tipo;
        public Status status;

        public void Ataca(Heroi heroi)
        {
            Random prob = new Random();

            if(prob.Next(0,100) < this.status.sorte)
            {
                heroi.status.vida -= ((this.status.forca * 2) - heroi.status.defesa);
                Console.WriteLine($"{this.nome} deu um ataque crítico em {heroi.nome}, tirando {this.status.forca * 2 - heroi.status.defesa} de vida!");
            }
            else
            {
                heroi.status.vida -= (this.status.forca - heroi.status.defesa);
                Console.WriteLine($"{this.nome} deu um ataque em {heroi.nome}, tirando {this.status.forca - heroi.status.defesa} de vida!");
            }
        }
    }
}
