using Aula5Elevador;

Pessoa jorge = new Pessoa("Jorginho do Grau", 50, 2, 8);
Pessoa cleitin = new Pessoa("Cleitin do Mengão", 90, 8, 0);
Pessoa rosnei = new Pessoa("Rosnei Latino", 90, 8, 30);

Elevador elevador = new Elevador(0, 30, 350, true, 0);

jorge.chamarElevador(elevador);
jorge.Entrar(elevador);
elevador.movimento(cleitin.andarAtual);
cleitin.Entrar(elevador);
elevador.movimento(cleitin.andarDesejado);
rosnei.chamarElevador(elevador);
jorge.Sair(elevador);
cleitin.Sair(elevador);
rosnei.Entrar(elevador);
elevador.movimento(rosnei.andarDesejado);
