using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula5Elevador
{
    public class Pessoa
    {
        public string nome;
        public int peso;
        public int andarAtual;
        public int andarDesejado;

        public void chamarElevador(Elevador elevador)
        {
            Console.WriteLine($"{nome} chamou o elevador no andar {andarAtual}");
            elevador.movimento(andarAtual);
            elevador.abrirPorta();
        }
        public void Sair(Elevador elevador)
        {
            if (!elevador.pessoas.Contains(this))
            {
                Console.WriteLine($"{nome} não está no elevador!");
            }
            else
            {
                if (elevador.portaAberta)
                {
                    elevador.pessoas.Remove(this);
                    elevador.pesoTotal -= this.peso;
                    andarAtual = elevador.andarAtual;
                    Console.WriteLine($"{this.nome} saiu do elevador. \nPeso total do elevador: {elevador.pesoTotal}");
                }
                else
                {
                    Console.WriteLine($"Não foi possível sair do elevador, a porta está fechada!");
                }
            }
        }
        public void Entrar(Elevador elevador)
        {
            if (elevador.portaAberta)
            {
                elevador.pessoas.Add(this);
                elevador.pesoTotal += this.peso;
                Console.WriteLine($"{this.nome} entrou no elevador. \nPeso total do elevador: {elevador.pesoTotal}");
            }
            else
            {
                Console.WriteLine($"Não foi possível sair do elevador, a porta está fechada!");
            }
        }
        public Pessoa(string nome, int peso, int andarAtual, int andarDesejado)
        {
            this.nome = nome;
            this.peso = peso;
            this.andarAtual = andarAtual;
            this.andarDesejado = andarDesejado;
        }
    }
}
