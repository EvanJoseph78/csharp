
namespace projeto4.Models

{
  public class Curso
  {
    public string Nome { get; set; }

    public List<Pessoa> Alunos { get; set; }


    public Curso()
    {
      Alunos = new List<Pessoa>();
    }

    public void adicionarAluno(Pessoa aluno)
    {
      Alunos.Add(aluno);
    }

    public void removerAluno(Pessoa aluno)
    {
      Alunos.Remove(aluno);
    }

    public int obterQuantidadeDeAlunos()
    {
      return Alunos.Count;
    }


    public void listarAlunosMatriculados()
    {
      Console.Write("Course Name: " + this.Nome + " - [");
      foreach (Pessoa aluno in Alunos)
      {
        Console.Write(aluno.NomeCompleto + " ");
      }
      Console.WriteLine("]");
    }
  }

}

