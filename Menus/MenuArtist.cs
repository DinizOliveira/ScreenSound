using ScreenSound.Modelos;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuArtists : Menu
{
    public override void Execute(Dictionary<string, Artist> musicsRegistered)
    {
        base.Execute(musicsRegistered);
        ShowTitlesOption("Exibindo todos os artistas registradas na nossa aplicação");

        foreach (string artist in musicsRegistered.Keys)
        {
            Console.WriteLine($"Artista: {artist}");
        }

        Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
        Console.ReadKey();
        Console.Clear();
    }
}