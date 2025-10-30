public class Dish
{
    public int Id { get; private set; }
    public string Name { get; private set; }
    public decimal Price { get; private set; }
    public Category Category { get; private set; }

    public Dish(int id, string name, decimal price, Category category)
    {
        if (id <= 0) throw new ArgumentException("Dish Id düzgün deyil.");
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Dish Name boş ola bilməz.");
        if (price <= 0) throw new ArgumentException("Price sıfırdan böyük olmalıdır.");
        if (category == null) throw new ArgumentNullException(nameof(category));

        Id = id;
        Name = name;
        Price = price;
        Category = category;
    }

    
    public static Dish[] FindDishesByCategory(Dish[] allDishes, Category category)
    {
        int count = 0;
        foreach (var d in allDishes)
        {
            if (d.Category.Id == category.Id)
                count++;
        }

        Dish[] result = new Dish[count];
        int index = 0;

        foreach (var d in allDishes)
        {
            if (d.Category.Id == category.Id)
                result[index++] = d;
        }

        return result;
    }

   
    public static Dish[] FindDishesByCategoryId(Dish[] allDishes, int categoryId)
    {
        int count = 0;
        foreach (var d in allDishes)
        {
            if (d.Category.Id == categoryId)
                count++;
        }

        Dish[] result = new Dish[count];
        int index = 0;

        foreach (var d in allDishes)
        {
            if (d.Category.Id == categoryId)
                result[index++] = d;
        }

        return result;
    }
}