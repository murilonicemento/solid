namespace SOLID.DIP.Violation;

public class Client
{
  public int ClienteId { get; set; }
  public string Nome { get; set; }
  public Email Email { get; set; }
  public CPF Cpf { get; set; }
  public DateTime DataCadastro { get; set; }

  public bool Validar()
  {
    return Email.Validate() && Cpf.Validate();
  }
}
