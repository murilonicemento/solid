
using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution;
public class ClientService : IClientService
{
  private readonly IClientRepository _clientRepository;
  private readonly IEmailService _emailService;

  public ClientService(IEmailService emailService, IClientRepository clientRepository)
  {
    _emailService = emailService;
    _clientRepository = clientRepository;
  }

  public string AddClient(Client client)
  {
    if (!client.Validar())
      return "Dados inválidos";

    _clientRepository.AddClient(client);

    _emailService.Send("empresa@empresa.com", client.Email.Address, "Bem Vindo", "Parabéns está Cadastrado");

    return "Cliente cadastrado com sucesso";
  }
}

public class TesteDip
{
  public TesteDip()
  {
    var cliService = new ClientService(new EmailService(), new ClientRepository());
  }
}
