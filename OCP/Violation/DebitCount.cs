namespace SOLID.OCP.Violation;

public enum CountType { Checking, Savings }
public class DebitCount
{
  public void Debitar(decimal valor, string conta, CountType tipoConta)
  {
    if (tipoConta == CountType.Checking)
    {
      // Debita Conta Corrente
    }

    if (tipoConta == CountType.Savings)
    {
      // Valida Aniversário da Conta
      // Debita Conta Poupança
    }
  }
}
