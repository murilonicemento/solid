using SOLID.ISP.Solution.Interfaces;

namespace SOLID.ISP.Solution;
public class AddClient : IAddClient
{
  public void ValidateData()
  {
    // Validar CPF, Email
  }

  public void SaveBank()
  {
    // Insert na tabela Cliente
  }

  public void SendEmail()
  {
    // Enviar e-mail para o cliente
  }
}