using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading;

namespace projeto2.Models
{
  class Pessoa
  {
    public string Nome { get; set; }
    public int Idade { get; set; }

    public void apresentar()
    {
      Console.WriteLine($"Olá, meu nome é {Nome}, e tenho {Idade} anos");
    }
  }
}
