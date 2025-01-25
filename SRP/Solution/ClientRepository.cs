using System.Data;

namespace SOLID.SRP.Solution
{
  public class ClientRepository
  {
    public void AddClient(Client client)
    {
      using (var cn = new SqlConnection())
      {
        var cmd = new SqlCommand();

        cn.ConnectionString = "MyConnectionString";
        cmd.Connection = cn;
        cmd.CommandType = CommandType.Text;
        cmd.CommandText = "INSERT INTO CLIENTE (NOME, EMAIL CPF, DATACADASTRO) VALUES (@nome, @email, @cpf, @dataCad))";

        cmd.Parameters.AddWithValue("nome", client.Nome);
        cmd.Parameters.AddWithValue("email", client.Email);
        cmd.Parameters.AddWithValue("cpf", client.Cpf);
        cmd.Parameters.AddWithValue("dataCad", client.DataCadastro);

        cn.Open();
        cmd.ExecuteNonQuery();
      }
    }
  }
}