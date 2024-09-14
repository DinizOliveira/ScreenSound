using ScreenSound.Banco;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class Menu
{
    public void ShowTitlesOption(string title)
    {
        int numberOfLetters = title.Length;
        string asterisks = string.Empty.PadLeft(numberOfLetters, '*');
        Console.WriteLine(asterisks);
        Console.WriteLine(title);
        Console.WriteLine(asterisks + "\n");
    }
    public virtual void Execute(DAL<Artist> artistDAL)
    {
        Console.Clear();
    }
}