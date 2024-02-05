using Microsoft.Data.SqlClient;
using ScreenSound.Modelos;

namespace ScreenSound.Data;

internal class ArtistaDAL
{

    public IEnumerable<Artista> ObterTodosOsArtistas()
    {
        var list = new List<Artista>();

        using var connection = new Connection().ObterConeccao();
        connection.Open();

        string sql = "SELECT * FROM Artistas";
        SqlCommand command = new SqlCommand(sql, connection);
        using SqlDataReader reader = command.ExecuteReader();

        while (reader.Read())
        {
            int idArtista = Convert.ToInt32(reader["Id"]);
            string nomeArtista = Convert.ToString(reader["Nome"]);
            string bioArtista = reader["Bio"].ToString();
            Artista artista = new(nomeArtista, bioArtista)
            {
                Id = idArtista
            };

            list.Add(artista);
        }

        return list;
    }

    public void AdicionarArtista(Artista artista)
    {
        using var connection = new Connection().ObterConeccao();
        connection.Open();

        string sql = "INSERT INTO Artistas (Nome, FotoPerfil, Bio) VALUES (@Nome, @FotoPerfil, @Bio)";
        SqlCommand command = new SqlCommand(sql, connection);
        command.Parameters.AddWithValue("@Nome", artista.Nome);
        command.Parameters.AddWithValue("@FotoPerfil", artista.FotoPerfil);
        command.Parameters.AddWithValue("@Bio", artista.Bio);
        var res = command.ExecuteNonQuery();

        Console.WriteLine($"Linhas afetadas {res}" );
    }
}
