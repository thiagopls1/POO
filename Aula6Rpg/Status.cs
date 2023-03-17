using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula6Rpg
{
    public class Status
    {
        public int forca;
        public int defesa;
        public int vida;
        public int mana;
        public Status(int forca, int defesa, int vida, int mana)
        {
            this.forca = forca;
            this.defesa = defesa; 
            this.vida = vida;
            this.mana = mana;
        }
    }

}
