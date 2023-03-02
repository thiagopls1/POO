string[] alunos = new string[] { "Thyago Quintas", "Thiago Claro", "Eduardo Takeo" };
decimal[] salarios = new decimal[] { 15000.01m, 20000.50m, 800000.10m };

foreach(string aluno in alunos)
{
    Console.WriteLine(aluno);
}
foreach(decimal salario in salarios)
{
    Console.WriteLine($"R$ {salario}");
}

// for(int i = 0; i < aluno.Length; i++)
// {
//     Console.WriteLine(aluno[i]);
// }



