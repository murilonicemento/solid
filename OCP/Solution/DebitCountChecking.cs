namespace SOLID.OCP.Solution;
public class DebitCountChecking : DebitCount
{
  public override string Debit(decimal valor, string conta)
  {
    // Debita Conta Corrente
    return FormatTransaction();
  }
}