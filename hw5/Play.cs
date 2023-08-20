class Play : IDisposable
{
    public string Name { get; set; }
    public string Author { get; set; }
    public string Genre { get; set; }
    public int Year { get; set; }

    public Play(string name, string author, string genre, int year)
    {
        Name = name;
        Author = author;
        Genre = genre;
        Year = year;
    }

    public void Dispose()
    {
        Console.WriteLine($"П'єса {Name} видалена.");
    }

    ~Play()
    {
        Console.WriteLine($"П'єса {Name} видалена.");
    }
}