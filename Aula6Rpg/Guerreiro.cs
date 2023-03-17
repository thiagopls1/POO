using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Rpg
{
    public class Guerreiro : Heroi
    {
        public void Atacar(Monstro monstro)
        {
            monstro.Defender(monstro.status.defesa); 
        }
        public Guerreiro(string nome, Status status) : base(nome, status)
        {

        }
    }
}
