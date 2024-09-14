using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Models;

namespace ScreenSound.Menus;

internal class MenuRegisterMusic : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        base.Execute(artistDAL);
        ShowTitlesOption("Registro de músicas");
        Console.Write("Digite o artista cuja música deseja registrar: ");
        string nameOfArtist = Console.ReadLine()!;
        var artistRecovered = artistDAL.RecoveryBy(a => a.Name.Equals(nameOfArtist));
        if (artistRecovered is not null)
        {
            Console.Write("Agora digite o título da música: ");
            string titleOfMusic = Console.ReadLine()!;
            Console.Write("Agora digite o ano de lançamento da música: ");
            string yearRelease = Console.ReadLine()!;
            artistRecovered.AddMusic(new Music(titleOfMusic) 
            {YearRelease = Convert.ToInt32(yearRelease)});
            Console.WriteLine($"A música {titleOfMusic} de {nameOfArtist} foi registrada com sucesso!");
            artistDAL.UpdateContent(artistRecovered);
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