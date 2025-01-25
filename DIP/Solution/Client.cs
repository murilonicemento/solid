using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution;
public class Client
{
  public int Id { get; set; }
  public string Name { get; set; }
  public Email Email { get; set; }
  public CPF Cpf { get; set; }
  public DateTime RegisterDate { get; set; }

  public bool Validar()
  {
    return Email.Validate() && Cpf.Validate();
  }
}