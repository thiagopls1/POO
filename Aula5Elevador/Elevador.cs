using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5Elevador
{
    public class Elevador
    {
        public int andarAtual;
        public int totalAndares;
        public int pesoMax;
        public bool portaAberta;
        public List<Pessoa> pessoas = new List<Pessoa>();
        public int pesoTotal; 

        public void abrirPorta()
        {
            portaAberta = true;
            Console.WriteLine("O elevador abriu a porta.");
        }
        public void fecharPorta()
        {
            portaAberta = false;
        }
        public void movimento(int andar)
        {
            if (andar <= totalAndares && andar >= 0 && pesoTotal < pesoMax)
            {
                fecharPorta();
                andarAtual = andar;
                Console.WriteLine($"Andar atual: {andarAtual}");
                abrirPorta();
            }
            else
            {
                if (pesoTotal > pesoMax)
                {
                    Console.WriteLine("Erro: Peso máximo excedido!");
                }
                if (andar > totalAndares || andar < 0)
                {
                    Console.WriteLine("Erro: O andar não existe!");
                }
            }
        }
        
        public Elevador(int andarAtual, int totalAndares, int pesoMax, bool portaAberta, int pesoTotal)
        {
            this.andarAtual = andarAtual;
            this.totalAndares = totalAndares;
            this.pesoMax = pesoMax;
            this.portaAberta = portaAberta;
            this.pesoTotal = pesoTotal;
        }
    }
}
