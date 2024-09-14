using ScreenSound.Models;

namespace ScreenSound.Modelos;

public class Music
{
    public Music(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Id { get; set; }
    public int? YearRelease { get; set; }
    public virtual Artist? Artist { get; set; }

    public void ShowRecord()
    {
        Console.WriteLine($"Nome: {Name}");

    }

    public override string ToString()
    {
        return @$"Id: {Id}
        Nome: {Name}";
    }
}