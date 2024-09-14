using ScreenSound.Banco;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterArtist : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        base.Execute(artistDAL);
        ShowTitlesOption("Registro dos Artistas");
        Console.Write("Digite o nome do artista que deseja registrar: ");
        string nameOfArtist = Console.ReadLine()!;
        Console.Write("Digite a bio do artista que deseja registrar: ");
        string bioOfArtist = Console.ReadLine()!;
        Artist artist = new Artist(nameOfArtist, bioOfArtist);
        artistDAL.AddContent(artist);
        Console.WriteLine($"O artista {nameOfArtist} foi registrado com sucesso!");
        Thread.Sleep(4000);
        Console.Clear();
    }
}