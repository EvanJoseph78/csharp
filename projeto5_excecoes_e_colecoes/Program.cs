// See https://aka.ms/new-console-template for more information
// Console.WriteLine("Hello, World!");
//

try
{
  string[] linhas = File.ReadAllLines("Arquivos/arquivo_Leitura.txt");

  foreach (string linha in linhas)
  {
    Console.WriteLine(linha);
  }
}
catch (Exception ex)
{
  Console.WriteLine($"Ocorreu uma exceção genérica. {ex.Message}");
}
