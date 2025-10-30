public class Order
{
    public int Id { get; private set; }
    public Dish[] Dishes { get; private set; } = new Dish[0];
    public decimal TotalAmount
    {
        get
        {
            decimal sum = 0;
            foreach (var d in Dishes)
                sum += d.Price;
            return sum;
        }
    }

    public Order(int id)
    {
        if (id <= 0) throw new ArgumentException("Order Id düzgün deyil.");
        Id = id;
    }

    public void AddDish(Dish dish)
    {
        if (dish == null) return;

        Dish[] newArray = new Dish[Dishes.Length + 1];
        for (int i = 0; i < Dishes.Length; i++)
            newArray[i] = Dishes[i];
        newArray[newArray.Length - 1] = dish;
        Dishes = newArray;
    }
}
    