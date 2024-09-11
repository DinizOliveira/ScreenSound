using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterArtist : Menu
{
    public override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        base.Execute(registeredArtists);
        ShowTitlesOption("Registro dos Artistas");
        Console.Write("Digite o nome do artista que deseja registrar: ");
        string nameOfArtist = Console.ReadLine()!;
        Console.Write("Digite a bio do artista que deseja registrar: ");
        string bioOfArtist = Console.ReadLine()!;
        Artist artist = new Artist(nameOfArtist, bioOfArtist);
        registeredArtists.Add(nameOfArtist, artist);
        Console.WriteLine($"O artista {nameOfArtist} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}