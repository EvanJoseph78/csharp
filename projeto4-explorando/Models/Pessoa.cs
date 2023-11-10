namespace projeto4.Models
{
  public class Pessoa
  {
    private string _nome;
    private int _idade;

    public string Nome
    {
      get
      {
        return _nome.ToUpper();
      }
      set
      {
        if (value == "")
        {
          throw new ArgumentException("O nome não pode ser vazio");
        }
        _nome = value;
      }
    }
    public int Idade
    {
      get => _idade;
      set
      {
        if (value < 0)
        {
          throw new ArgumentException("A idade não pode ser menor que zero");
        }
        _idade = value;

      }
    }

    public string Sobrenome { get; set; }
    public string NomeCompleto => $"{Nome} {Sobrenome}".ToUpper();

    public void apresentar()
    {
      // Console.WriteLine($"Nome: {Nome}, Sobrenome: {Sobrenome}, Idade: {Idade}");
      Console.WriteLine($"Nome: {NomeCompleto}, Idade: {Idade}");
    }
  }
}
