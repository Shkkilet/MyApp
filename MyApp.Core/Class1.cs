namespace MyApp.Core;

public class ProductCatalog
{
    private readonly List<string> _products = new();

    public void Add(string name)
    {
        _products.Add(name);
    }

    public void Remove(string name)
    {
        _products.Remove(name);
    }

    public IEnumerable<string> GetAll()
    {
        return _products;
    }

    public string? Find(string name)
    {
        return _products.FirstOrDefault(x => x == name);
    }

    public string? Find(int index)
    {
        if (index < 0 || index >= _products.Count)
            return null;

        return _products[index];
    }
}