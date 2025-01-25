namespace SOLID.OCP.Solution
{
  public abstract class DebitCount
  {
    public string TransactionNumber { get; set; }
    public abstract string Debit(decimal valor, string conta);

    public string FormatTransaction()
    {
      const string chars = "ABCasDEFGHIJKLMNOPQRSTUVWXYZ0123456789";
      var random = new Random();

      TransactionNumber = new string(Enumerable.Repeat(chars, 15)
        .Select(s => s[random.Next(s.Length)]).ToArray());

      // Numero de transacao formatado
      return TransactionNumber;
    }
  }
}