using ScreenSound.Banco;
using ScreenSound.Menus;
using ScreenSound.Models;

try
{
    var artistDAL = new ArtistDAL();
    /*    artistaDAL.Adicionar(new Artista("Foo Fighters", "Foo Fighters é uma banda de rock alternativo americana formada por Dave Grohl em 1995."));*/

    var artistPitty = new Artist("Pitty", "Priscilla Novaes Leone, mais conhecida como Pitty, é uma cantora, compositora, produtora, escritora e multi-instrumentista brasileira.") { Id = 1003 };

    artistDAL.Add(artistPitty);
    var listArtists = artistDAL.Show();

    foreach (var artist in listArtists)
    {
        Console.WriteLine(artist);
    }
}
catch (Exception ex)
{

    Console.WriteLine(ex.Message);
}

return;

Artist ira = new Artist("Ira!", "Banda Ira!");
Artist beatles = new Artist("The Beatles", "Banda The Beatles");

Dictionary<string, Artist> registeredArtists = new();
registeredArtists.Add(ira.Name, ira);
registeredArtists.Add(beatles.Name, beatles);

Dictionary<int, Menu> opcoes = new();
opcoes.Add(1, new MenuRegisterArtist());
opcoes.Add(2, new MenuRegisterMusic());
opcoes.Add(3, new MenuArtists());
opcoes.Add(4, new MenuMusics());
opcoes.Add(-1, new MenuExit());

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
    Console.WriteLine("Digite -1 para sair");

    Console.Write("\nDigite a sua opção: ");
    int optionChosen = int.Parse(Console.ReadLine()!);

    if (opcoes.ContainsKey(optionChosen))
    {
        Menu menuASerExibido = opcoes[optionChosen];
        menuASerExibido.Execute(registeredArtists);
        if (optionChosen > 0) ShowOptionsMenu();
    }
    else
    {
        Console.WriteLine("Opção inválida");
    }
}

ShowOptionsMenu();