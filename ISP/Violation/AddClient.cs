namespace SOLID.ISP.Violation;

public class AddClient : IRegister
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
