class Shop : IDisposable
{
    public string Name { get; set; }
    public string Address { get; set; }
    public ShopTypes ShopType { get; set; }

    public Shop(string name, string address, ShopTypes shopType)
    {
        Name = name;
        Address = address;
        ShopType = shopType;
    }

    public void Dispose()
    {
        Console.WriteLine($"Магазин {Name} видалено.");
    }

    ~Shop()
    {
        Console.WriteLine($"Магазин {Name} видалено.");
    }
}