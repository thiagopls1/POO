using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Rpg
{
    public class Monstro
    {
        public string nome { get; private set; }
        public Status status;
        public void Defender(int defesa)
        {

        }
        public Monstro(string nome, Status status)
        {
            this.nome = nome;
            this.status = status;
        }
    }
}
