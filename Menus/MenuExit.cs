using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExit : Menu
{
    public override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}