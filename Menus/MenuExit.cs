using ScreenSound.Banco;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuExit : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        Console.WriteLine("Tchau tchau :)");
    }
}