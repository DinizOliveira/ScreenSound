namespace ScreenSound.Modelos;

internal class Music
{
    public Music(string name)
    {
        Name = name;
    }

    public string Name { get; set; }
    public int Id { get; set; }

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