public class Category
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public string Description { get; set; }
    public Dish[] Dishes { get; set; } = new Dish[0];

    public Category(int id, string name, string description = "")
    {
        if (id <= 0) throw new ArgumentException("Category Id düzgün deyil.");
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Category Name boş ola bilməz.");

        Id = id;
        Name = name;
        Description = description;
    }
}