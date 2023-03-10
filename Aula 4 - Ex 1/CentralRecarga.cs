using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula_4___Ex_1
{
    public class CentralRecarga
    {
        public int id;
        public string nome;

        public CentralRecarga(string nome)
        {
            this.nome = nome;
        }
        public void Recarregar(BilheteUnico bilhete, float valor, string tipoRecarga)
        {
            if(tipoRecarga == "empresarial")
            {
                bilhete.saldo.empresarial += valor;
            }else if(tipoRecarga == "estudante")
            {
                bilhete.saldo.estudante += valor;
            }else if(tipoRecarga == "comum")
            {
                bilhete.saldo.comum += valor;
            }
            else
            {
                Console.WriteLine("Tipo de saldo não encontrado! (estudante, empresarial, comum)");
            }
        }
    }
}
