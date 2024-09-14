using Microsoft.Extensions.Options;
using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Models;

var context = new ScreenSoundContext();
var artistDAL = new DAL<Artist>(context);

Dictionary<int, Menu> option = new();
option.Add(1, new MenuRegisterArtist());
option.Add(2, new MenuRegisterMusic());
option.Add(3, new MenuShowArtists());
option.Add(4, new MenuShowMusics());
option.Add(5, new MenuShowByYear());
option.Add(-1, new MenuExit());

void ExibirLogo()
{
    Console.WriteLine(@"

░██████╗░█████╗░██████╗░███████╗███████╗███╗░░██╗  ░██████╗░█████╗░██╗░░░██╗███╗░░██╗██████╗░
██╔════╝██╔══██╗██╔══██╗██╔════╝██╔════╝████╗░██║  ██╔════╝██╔══██╗██║░░░██║████╗░██║██╔══██╗
╚█████╗░██║░░╚═╝██████╔╝█████╗░░█████╗░░██╔██╗██║  ╚█████╗░██║░░██║██║░░░██║██╔██╗██║██║░░██║
░╚═══██╗██║░░██╗██╔══██╗██╔══╝░░██╔══╝░░██║╚████║  ░╚═══██╗██║░░██║██║░░░██║██║╚████║██║░░██║
██████╔╝╚█████╔╝██║░░██║███████╗███████╗██║░╚███║  ██████╔╝╚█████╔╝╚██████╔╝██║░╚███║██████╔╝
╚═════╝░░╚════╝░╚═╝░░╚═╝╚══════╝╚══════╝╚═╝░░╚══╝  ╚═════╝░░╚════╝░░╚═════╝░╚═╝░░╚══╝╚═════╝░
");
    Console.WriteLine("Boas vindas ao Screen Sound 3.0!");
}

void ShowOptionsMenu()
{
    ExibirLogo();
    Console.WriteLine("\nDigite 1 para registrar um artista");
    Console.WriteLine("Digite 2 para registrar a música de um artista");
    Console.WriteLine("Digite 3 para mostrar todos os artistas");
    Console.WriteLine("Digite 4 para exibir todas as músicas de um artista");
    Console.WriteLine("Digite 5 para exibir as músicas por ano de lançamento");
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int optionChosen = int.Parse(Console.ReadLine()!);

    if (option.ContainsKey(optionChosen))
    {
        Menu menuASerExibido = option[optionChosen];
        menuASerExibido.Execute(artistDAL);
        if (optionChosen > 0) ShowOptionsMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ShowOptionsMenu();