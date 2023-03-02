using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula3
{
    class Carro
    {
        public int velocidadeMax;
        public int velocidadeAtual;
        public int aceleracao;
        public int kmAtual = 0;
        public Piloto piloto;
        public int Acelerar()
        {
            // O C# tira a necessidade de colocar "this" em todos os atributos do objeto
            kmAtual += velocidadeAtual;
            if(velocidadeMax > velocidadeAtual + aceleracao)
            {
                velocidadeAtual += aceleracao;
            }
            return velocidadeAtual;
        }
        public void Acidente(Carro carro)
        {
            carro.velocidadeAtual -= 5;
            velocidadeAtual -= 2;
        }
    }
}
