namespace SOLID.DIP.Solution.Interfaces;
public interface IEmailService
{
  void Send(string to, string emailFor, string subject, string message);
}