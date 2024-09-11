using ScreenSound.Modelos;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterMusic : Menu
{
    public override void Execute(Dictionary<string, Artist> registeredArtists)
    {
        base.Execute(registeredArtists);
        ShowTitlesOption("Registro de músicas");
        Console.Write("Digite o artista cuja música deseja registrar: ");
        string nameOfArtist = Console.ReadLine()!;
        if (registeredArtists.ContainsKey(nameOfArtist))
        {
            Console.Write("Agora digite o título da música: ");
            string titleOfMusic = Console.ReadLine()!;
            Artist artist = registeredArtists[nameOfArtist];
            artist.AdicionarMusica(new Music(titleOfMusic));
            Console.WriteLine($"A música {titleOfMusic} de {nameOfArtist} foi registrada com sucesso!");
            Thread.Sleep(4000);
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