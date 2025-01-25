namespace SOLID.SRP.Solution
{
  public class ClienteService
  {
    public string AdicionarCliente(Client cliente)
    {
      if (!cliente.Validar())
        return "Dados inválidos";

      var repo = new ClienteRepository();
      repo.AdicionarCliente(cliente);

      EmailService.Enviar("empresa@empresa.com", cliente.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

      return "Cliente cadastrado com sucesso";
    }
  }
}