 class Program
    {
        static void Main()
        {
            Category pizzaCat = new Category(1, "Pizza", "İtalyan pizzaları");
            Category dessertCat = new Category(2, "Dessert", "Şirinlər");

            Dish dish1 = new Dish(1, "Margarita", 12.5m, pizzaCat);
            Dish dish2 = new Dish(2, "Tiramisu", 6m, dessertCat);
            Dish dish3 = new Dish(3, "Pepperoni", 13m, pizzaCat);

            Dish[] allDishes = { dish1, dish2, dish3 };

            Restaurant rest = new Restaurant("Bella Italia", "Bakı, Nizami küçəsi 12");

            rest.AddDishToMenu(dish1);
            rest.AddDishToMenu(dish2);
            rest.AddDishToMenu(dish3);

            Order order1 = new Order(1);
            order1.AddDish(dish1);
            order1.AddDish(dish2);

            rest.PlaceOrder(order1);

            Console.WriteLine($"Sifarişin ümumi məbləği: {order1.TotalAmount} AZN");

            var found = Dish.FindDishesByCategory(allDishes, pizzaCat);
            Console.WriteLine("\nPizza kateqoriyasına aid yeməklər:");
            foreach (var d in found)
                Console.WriteLine($"- {d.Name}");
        }
    }
