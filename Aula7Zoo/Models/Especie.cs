using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7Zoo.Models
{
    public class Cachorro : Mamifero
    {
        public override void emitirSom()
        {
            Console.WriteLine($"{nome}: Au Au");
        }

        public Cachorro(string nome, int idade, float peso, string corDoPelo) : base(nome, idade, peso, corDoPelo) { }
    }

    public class Gato : Mamifero
    {
        public override void emitirSom()
        {
            Console.WriteLine($"{nome}: MIAAAAAAAAAAAAAU");
        }

        public Gato(string nome, int idade, float peso, string corDoPelo) : base(nome, idade, peso, corDoPelo) { }
    }

    public class Papagaio : Ave
    {
        public override void emitirSom()
        {
            Console.WriteLine($"{nome}: Ó os homi!");
        }

        public Papagaio(string nome, int idade, float peso, string corDasPenas) : base(nome, idade, peso, corDasPenas) { }
    }
    public class Pomba : Ave
    {
        public override void emitirSom()
        {
            Console.WriteLine($"{nome}: Pru");
        }

        public Pomba(string nome, int idade, float peso, string corDasPenas) : base(nome, idade, peso, corDasPenas) { }
    }
    public class Cobra : Reptil
    {

        public override void emitirSom()
        {
            Console.WriteLine($"{nome}: Ssssssssssssssssssssssss");
        }

        public Cobra(string nome, int idade, float peso, string tipoDeEscama) : base(nome, idade, peso, tipoDeEscama) { }
    }
    public class Tartaruga : Reptil
    {
        public override void emitirSom()
        {
            Console.WriteLine($"{nome}: Aennn");
        }

        public Tartaruga(string nome, int idade, float peso, string tipoDeEscama) : base(nome, idade, peso, tipoDeEscama) { }
    }
}
