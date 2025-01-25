namespace SOLID.DIP.Violation;
public class ClientService
{
  public string AddClient(Client client)
  {
    if (!client.Validar())
      return "Dados inválidos";

    var repo = new ClientRepository();
    repo.AddClient(client);

    EmailService.Send("empresa@empresa.com", client.Email.Endereco, "Bem Vindo", "Parabéns está Cadastrado");

    return "Cliente cadastrado com sucesso";
  }
}