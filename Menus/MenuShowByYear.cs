using ScreenSound.Banco;
using ScreenSound.Modelos;
using ScreenSound.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ScreenSound.Menus;
internal class MenuShowByYear : Menu
{
    public override void Execute(DAL<Artist> artistDAL)
    {
        base.Execute(artistDAL);
        ShowTitlesOption("Mostrar musicas por ano de lançamento");
        Console.Write("Digite o ano para consultar músicas:");
        string yearRelease = Console.ReadLine()!;
        var musicDal = new DAL<Music>(new ScreenSoundContext());
        var listYearRelease = musicDal.ListBy(a => a.YearRelease == Convert.ToInt32(yearRelease));
        if (listYearRelease.Any())
        {
            Console.WriteLine($"\nMusicas do Ano {yearRelease}:");
            foreach (var musica in listYearRelease)
            {
                musica.ShowRecord();
            }
            Console.WriteLine("\nDigite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
        else
        {
            Console.WriteLine($"\nO ano {yearRelease} não foi encontrado!");
            Console.WriteLine("Digite uma tecla para voltar ao menu principal");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
