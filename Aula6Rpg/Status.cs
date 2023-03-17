using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Rpg
{
    public class Status
    {
        public int forca { get; private set; }
        public int defesa { get; private set; }
        public int vida { get; private set; }
        public int mana { get; private set; }
        public Status(int forca, int defesa, int vida, int mana)
        {
            this.forca = forca;
            this.defesa = defesa; 
            this.vida = vida;
            this.mana = mana;
        }
    }

}
