using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aula7Zoo.Models
{
    public class Zoologico
    {
        public List<Animal> animais { get; set; } = new List<Animal>();

        public void chamada() 
        {
            Console.WriteLine("Animais no zoológico:");

            foreach(var animal in animais)
            {
                Console.WriteLine($"Nome: {animal.nome}, Idade: {animal.idade}, Peso: {animal.peso}");
            }
        }

        public void barulho()
        {
            foreach(var animal in animais)
            {
                animal.emitirSom();
            }
        }
    }

    public class Animal
    {
        public string nome { get; set; }
        public int idade { get; set; }
        public float peso { get; set; }

        public virtual void emitirSom()
        {
            Console.WriteLine($"{nome}: *barulho*");
        }

        public Animal(string nome, int idade, float peso)
        {
            this.nome = nome;
            this.idade = idade;
            this.peso = peso;
        }
    }
}
