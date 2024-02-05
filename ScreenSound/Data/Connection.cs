using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Data;

internal class Connection
{
    private string connectionString = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=ScreenSound;Integrated Security=True;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";

    public SqlConnection ObterConeccao()
    {
        return new SqlConnection(connectionString);
    }

}
