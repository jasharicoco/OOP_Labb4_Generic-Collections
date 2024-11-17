namespace OOP_Labb4_Generic_Collections
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Skapar en restaurang som heter Ziggi
            Restaurant Ziggi = new Restaurant();

            // Skapar några rätter
            MenuItem Carbonara = new MenuItem(1, "Carbonara", 110m);
            MenuItem FishnChips = new MenuItem(2, "Fish n' Chips", 110m);
            MenuItem ButterChickenCurry = new MenuItem(3, "Butter Chicken Curry", 110m);
            MenuItem NaanBread = new MenuItem(4, "Naan Bread", 45m);
            MenuItem BanhMi = new MenuItem(5, "Banh mi", 85m);
            MenuItem PapayaSalad = new MenuItem(6, "Papaya Salad", 85m);
            MenuItem PineapplePizza = new MenuItem(7, "Pineapple Pizza", 10000m);
            MenuItem SourdoughGarlicSlices = new MenuItem(8, "Sourdough Garlic slices", 40m);
            MenuItem SoftDrinks = new MenuItem(9, "Soft drinks", 35m);

            // Lägger till rätterna i restaurang Ziggis meny
            Ziggi.AddToMenu(Carbonara);
            Ziggi.AddToMenu(FishnChips);
            Ziggi.AddToMenu(ButterChickenCurry);
            Ziggi.AddToMenu(NaanBread);
            Ziggi.AddToMenu(BanhMi);
            Ziggi.AddToMenu(PapayaSalad);
            Ziggi.AddToMenu(PineapplePizza);
            Ziggi.AddToMenu(SourdoughGarlicSlices);
            Ziggi.AddToMenu(SoftDrinks);
            Ziggi.EmptyRow(); // Tom rad

            // Skriver ut menyn
            Ziggi.ShowMenu();
            Ziggi.Lines(); // Separations-streck

            // Skapar nya ordrar, lägger till dem i kön samt loggar detta
            Order order1 = new Order(new List<MenuItem>(), 4);
            order1.AddItem(Carbonara);
            order1.AddItem(PapayaSalad);
            order1.AddItem(SoftDrinks);
            Ziggi.CreateOrder(order1);

            Order order2 = new Order(new List<MenuItem>(), 12);
            order2.AddItem(ButterChickenCurry);
            order2.AddItem(NaanBread);
            order1.AddItem(SoftDrinks);
            Ziggi.CreateOrder(order2);

            Order order3 = new Order(new List<MenuItem>(), 7);
            order3.AddItem(BanhMi);
            order3.AddItem(PineapplePizza);
            order3.AddItem(SoftDrinks);
            Ziggi.CreateOrder(order3);

            Ziggi.Lines(); // Separations-streck
            Ziggi.ShowOrders();
            Ziggi.Lines(); // Separations-streck
            Ziggi.ShowOrderCount();
            Ziggi.EmptyRow(); // Tom rad
            Ziggi.ShowNextOrder();
            Ziggi.HandleOrder();
            Console.WriteLine();
            Ziggi.ShowOrderCount();
            Ziggi.Lines(); // Separations-streck

            Order order4 = new Order(new List<MenuItem>(), 2);
            order4.AddItem(SourdoughGarlicSlices);
            order4.AddItem(SoftDrinks);
            order4.AddItem(SoftDrinks);
            Ziggi.CreateOrder(order4);

            Ziggi.EmptyRow(); // Tom rad
            Ziggi.ShowOrderCount();
            Ziggi.EmptyRow(); // Tom rad
            Ziggi.HandleOrder();
            Ziggi.HandleOrder();
            Ziggi.EmptyRow(); // Tom rad
            Ziggi.ShowOrderCount();
            Ziggi.Lines(); // Separations-streck
            Ziggi.ShowNextOrder();
            Ziggi.HandleOrder();
            Ziggi.EmptyRow(); // Tom rad
            Ziggi.ShowOrderCount();

            Console.ReadKey();


        }
    }
}
