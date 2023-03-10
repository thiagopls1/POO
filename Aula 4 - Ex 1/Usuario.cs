using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Ex_1
{
    public class Usuario
    {
        public int id;
        public string nome;
        public string cpf;
        public List<BilheteUnico> bilhetes = new List<BilheteUnico>();

        public Usuario(string nome, string cpf)
        {
            this.nome = nome;
            this.cpf = cpf;
        }
    }
}
