using ScreenSound.Modelos;

namespace ScreenSound.Models;

public class Artist
{
    public virtual ICollection<Music> Musics { get; set; } = new List<Music>();

    public Artist(string name, string bio)
    {
        Name = name;
        Bio = bio;
        PicturePerfil = "https://cdn.pixabay.com/photo/2016/08/08/09/17/avatar-1577909_1280.png";
    }

    public string Name { get; set; }
    public string PicturePerfil { get; set; }
    public string Bio { get; set; }
    public int Id { get; set; }

    public void AddMusic(Music music)
    {
        Musics.Add(music);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discografia do artista {Name}");
        foreach (var music in Musics)
        {
            Console.WriteLine($"Música: {music.Name} - Ano de lançamento: {music.YearRelease}");
        }
    }

    public override string ToString()
    {
        return $@"Id: {Id}
            Nome: {Name}
            Foto de Perfil: {PicturePerfil}
            Bio: {Bio}";
    }
}