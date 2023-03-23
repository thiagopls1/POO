using Aula7Zoo.Models;

Zoologico zoo = new Zoologico();

zoo.animais.Add(new Pomba("Pedro", 2, 3.5f, "Cinza"));
zoo.animais.Add(new Gato("Garfield", 5, 13.1f, "Preto"));
zoo.animais.Add(new Papagaio("Paraguaio", 54, 5.3f, "Verde"));


zoo.chamada();
zoo.barulho();