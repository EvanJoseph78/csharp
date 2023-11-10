// See https://aka.ms/new-console-template for more information
using projeto4.Models;

Pessoa p1 = new Pessoa();
Pessoa p2 = new Pessoa();
p1.Nome = "Evandro";
p1.Sobrenome = "Mariano";
p1.Idade = 25;
p2.Nome = "Ednaldo";
p2.Sobrenome = "Pereira";
p2.Idade = 88;
// p1.apresentar();
// p2.apresentar();

Curso c1 = new Curso();
c1.Nome = "Inglês";
c1.adicionarAluno(p1);
c1.adicionarAluno(p2);
Console.WriteLine(c1.obterQuantidadeDeAlunos());
c1.listarAlunosMatriculados();
c1.removerAluno(p2);
c1.listarAlunosMatriculados();


