using Microsoft.Data.SqlClient;
using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Banco;
internal class ArtistDAL
{
    public IEnumerable<Artist> Show()
    {
        var list = new List<Artist>();
        using var connection = new Connection().GetConnection();
        connection.Open();

        string sql = "SELECT * FROM Artists";
        SqlCommand command = new SqlCommand(sql, connection);
        using SqlDataReader dataReader = command.ExecuteReader();

        while (dataReader.Read())
        {
            string nameArtist = Convert.ToString(dataReader["Name"]);
            string bioArtist = Convert.ToString(dataReader["Bio"]);
            int idArtist = Convert.ToInt32(dataReader["Id"]);
            Artist artist = new(nameArtist, bioArtist) { Id = idArtist };

            list.Add(artist);
        }
        return list;
    }

    public void Add(Artist artist)
    {
        using var connection = new Connection().GetConnection();
        connection.Open();

        string sql = "INSERT INTO Artists (Name, PicturePerfil, Bio) VALUES (@name, @perfilStandart, @bio)";
        SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@name", artist.Name);
        command.Parameters.AddWithValue("@perfilStandart", artist.PicturePerfil);
        command.Parameters.AddWithValue("@bio", artist.Bio);

        int retorno = command.ExecuteNonQuery();
        Console.WriteLine($"Linhas afetadas: {retorno}");
    }

    public void Update(Artist artist)
    {
        using var connection = new Connection().GetConnection();
        connection.Open();

        string sql = $"UPDATE Artists SET Name = @name, Bio = @bio WHERE Id = @id";
        SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@name", artist.Name);
        command.Parameters.AddWithValue("@bio", artist.Bio);
        command.Parameters.AddWithValue("@id", artist.Id);

        int reply = command.ExecuteNonQuery();

        Console.WriteLine($"Linhas afetadas: {reply}");
    }

    public void Delete(Artist artist)
    {
        using var connection = new Connection().GetConnection();
        connection.Open();

        string sql = $"DELETE FROM Artists WHERE Id = @id";
        SqlCommand command = new SqlCommand(sql, connection);

        command.Parameters.AddWithValue("@id", artist.Id);

        int reply = command.ExecuteNonQuery();

        Console.WriteLine($"Linhas afetadas: {reply}");
    }
}
