using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuMusics : Menu
{
    public override void Execute(Dictionary<string, Artist> RegisteredArtists)
    {
        base.Execute(RegisteredArtists);
        ShowTitlesOption("Exibir detalhes do artista");
        Console.Write("Digite o nome do artista que deseja conhecer melhor: ");
        string nameOfArtist = Console.ReadLine()!;
        if (RegisteredArtists.ContainsKey(nameOfArtist))
        {
            Artist artist = RegisteredArtists[nameOfArtist];
            Console.WriteLine("\nDiscografia:");
            artist.ShowDiscography();
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