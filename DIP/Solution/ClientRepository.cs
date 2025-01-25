using System.Data;
using System.Data.SqlClient;
using SOLID.DIP.Solution.Interfaces;

namespace SOLID.DIP.Solution;
public class ClientRepository : IClientRepository
{
  public void AddClient(Client client)
  {

    using (var cn = new SqlConnection())
    {
      var cmd = new SqlCommand();

      cn.ConnectionString = "MinhaConnectionString";
      cmd.Connection = cn;
      cmd.CommandType = CommandType.Text;
      cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

      cmd.Parameters.AddWithValue("nome", client.Name);
      cmd.Parameters.AddWithValue("email", client.Email);
      cmd.Parameters.AddWithValue("cpf", client.Cpf);
      cmd.Parameters.AddWithValue("dataCad", client.RegisterDate);

      cn.Open();
      cmd.ExecuteNonQuery();
    }

  }
}