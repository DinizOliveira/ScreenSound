using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuShowArtists : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        base.Execute(artistDAL);
        ShowTitlesOption("Exibindo todos os artistas registradas na nossa aplicação");

        foreach (var artist in artistDAL.ListContent())
        {
            Console.WriteLine($"Artista: {artist}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}