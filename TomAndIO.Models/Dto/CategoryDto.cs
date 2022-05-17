namespace TomAndIO.Models.Dto;

public class CategoryDto
{
    public CategoryDto(long id, string name)
    {
        Id = id;
        Name = name;
    }

    public long Id { get; set; }

    public string Name { get; set; }
}