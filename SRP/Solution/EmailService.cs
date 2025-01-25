namespace SOLID.SRP.Solution;

public static class EmailService
{
  public static void Enviar(string to, string address, string title, string message)
  {
    var foo = to + address + title + message;
  }
}