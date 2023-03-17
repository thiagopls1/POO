using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Rpg
{
    public class Heroi
    {
        public string nome;
        public Status status;

        public Heroi(string nome, Status status) 
        {
            this.nome = nome;
            this.status = status;
        }
    }
}
