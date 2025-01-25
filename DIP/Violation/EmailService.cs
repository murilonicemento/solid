namespace SOLID.DIP.Violation;

public static class EmailService
{
  public static void Send(string to, string address, string title, string message)
  {
    var foo = to + address + title + message;
  }
}