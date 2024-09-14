using ScreenSound.Banco;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuShowMusics : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        base.Execute(artistDAL);
        ShowTitlesOption("Exibir detalhes do artista");
        Console.Write("Digite o nome do artista que deseja conhecer melhor: ");
        string nameOfArtist = Console.ReadLine()!;
        var artistRecovered = artistDAL.RecoveryBy(a => a.Name.Equals(nameOfArtist));
        if (artistRecovered is not null)
        {
            Console.WriteLine("\nDiscografia:");
            artistRecovered.ShowDiscography();
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO artista {nameOfArtist} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}