using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Ex_1
{
    public class BilheteUnico
    {
        public int id;
        public string tipoCartao;
        public Saldo saldo;
        public DateTime? integracao;
        public DateTime validade;
        public Usuario usuario;

        public BilheteUnico(string tipoCartao, Usuario usuario)
        {
            this.saldo = new Saldo();
            this.tipoCartao = tipoCartao;
            this.integracao = null;
            this.usuario = usuario;
            this.usuario.bilhetes.Add(this);
        }
    }
}
