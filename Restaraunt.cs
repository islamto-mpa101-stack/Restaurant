public class Restaurant
{
    public string Name { get; private set; }
    public string Address { get; set; }
    public Dish[] Menu { get; private set; } = new Dish[0];
    public Order[] Orders { get; private set; } = new Order[0];

    public Restaurant(string name, string address)
    {
        if (string.IsNullOrWhiteSpace(name)) throw new ArgumentException("Restaurant Name boş ola bilməz.");
        Name = name;
        Address = address;
    }

    
    public void AddDishToMenu(Dish dish)
    {
        if (dish == null) return;

        Dish[] newArray = new Dish[Menu.Length + 1];
        for (int i = 0; i < Menu.Length; i++)
            newArray[i] = Menu[i];
        newArray[newArray.Length - 1] = dish;
        Menu = newArray;
    }

    public void PlaceOrder(Order order)
    {
        if (order == null) return;

        Order[] newArray = new Order[Orders.Length + 1];
        for (int i = 0; i < Orders.Length; i++)
            newArray[i] = Orders[i];
        newArray[newArray.Length - 1] = order;
        Orders = newArray;
    }

 
    public Order GetOrderById(int orderId)
    {
        foreach (var order in Orders)
        {
            if (order.Id == orderId)
                return order;
        }
        return null;
    }
}