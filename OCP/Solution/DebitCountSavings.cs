namespace SOLID.OCP.Solution;
public class DebitCountSavings : DebitCount
{
  public override string Debit(decimal valor, string conta)
  {
    // Valida Aniversário da Conta
    // Debita Conta Corrente
    return FormatTransaction();
  }
}