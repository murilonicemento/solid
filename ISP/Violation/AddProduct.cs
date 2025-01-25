
namespace SOLID.ISP.Violation;
public class AddProduct : IRegister
{
  public void ValidateData()
  {
    // Validar valor
  }

  public void SaveBank()
  {
    // Insert tabela Produto
  }

  public void SendEmail()
  {
    // Produto não tem e-mail, o que eu faço agora???
    throw new NotImplementedException("Esse método não serve pra nada");
  }
}