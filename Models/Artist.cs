using ScreenSound.Modelos;

namespace ScreenSound.Models;

internal class Artist
{
    private List<Music> musics = new List<Music>();

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

    public void AdicionarMusica(Music music)
    {
        musics.Add(music);
    }

    public void ShowDiscography()
    {
        Console.WriteLine($"Discografia do artista {Name}");
        foreach (var music in musics)
        {
            Console.WriteLine($"Música: {music.Name}");
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