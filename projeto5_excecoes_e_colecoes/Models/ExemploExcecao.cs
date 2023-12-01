namespace ExemploExplorando.Models
{
  public class ExemploExcessao
  {
    public void Metodo1()
    {
      Metodo2();
    }

    public void Metodo2()
    {
      Metodo3();
    }

    public void Metodo3()
    {
      Metodo4();
    }

    public void Metodo4()
    {
      throw new Exception("Ocoreu uma exceção");
    }
  }
}
