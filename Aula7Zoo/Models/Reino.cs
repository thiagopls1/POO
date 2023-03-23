using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7Zoo.Models
{

    public class Mamifero : Animal
    {
        public string corDoPelo { get; set; }

        public Mamifero(string nome, int idade, float peso, string corDoPelo) : base(nome, idade, peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.corDoPelo = corDoPelo;
        }   
    }

    public class Ave : Animal
    {
        public string corDasPenas { get; set; }

        public Ave(string nome, int idade, float peso, string corDasPenas) : base(nome, idade, peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.corDasPenas = corDasPenas;
        }
    }

    public class Reptil : Animal
    {
        public string tipoDeEscama { get; set; }

        public Reptil(string nome, int idade, float peso, string tipoDeEscama) : base(nome, idade, peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
            this.tipoDeEscama = tipoDeEscama;
        }
    }

}
