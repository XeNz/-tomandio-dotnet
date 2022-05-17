namespace TomAndIO.Models.Entities;

public class Category
{
    public Category(string name)
    {
        Name = name;
    }

    public long Id { get; set; }

    public string Name { get; set; }
}