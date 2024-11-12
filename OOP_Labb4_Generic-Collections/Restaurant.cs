namespace OOP_Labb4_Generic_Collections
{
    internal class Restaurant
    {
        // Skapar meny i form av listade menyobjekt samt ordrar som staplas på varandra
        private List<MenuItem> _menu = new List<MenuItem>();
        private Queue<Order> _orders = new Queue<Order>();

        // Lägger till rätter i menyn samt loggar detta
        public void AddToMenu(MenuItem menuItem)
        {
            _menu.Add(menuItem);
            Console.WriteLine($"Added to menu: {menuItem}");
        }

        // Visar menyn
        public void ShowMenu()
        {
            Console.WriteLine("Menu:");
            foreach (var item in _menu)
            {
                Console.WriteLine(item);
            }
        }

        // Skapar en order och lägger den högst upp på listan samt loggar detta
        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order);
            Console.WriteLine($"NEW ORDER: {order}");
        }

        // Hanterar (tar bort) order som är först i kön och loggar detta
        public void HandleOrder()
        {
            var order = _orders.Dequeue();
            Console.WriteLine($"Handled order: {order}");
        }

        // Skriv ut alla ordrar i kön
        public void ShowOrders()
        {
            Console.WriteLine("List of current orders:");
            foreach (var order in _orders)
            {
                Console.WriteLine(order);
            }
        }

        // Skriv ut order som är näst i kön
        public void ShowNextOrder()
        {
            var order = _orders.Peek();
            Console.WriteLine($"Next order: {order}");
        }

        // Skriv ut antal ordrar i kön
        public void ShowOrderCount()
        {
            if (_orders.Count == 1)
            {
                Console.WriteLine($"Det är {_orders.Count} order i kön.");
            }
            else if (_orders.Count > 1)
            {
                Console.WriteLine($"Det är {_orders.Count} ordrar i kön.");
            }
            else if (_orders.Count == 0)
            {
                Console.WriteLine("Det finns inga ordrar i kön.");
            }
            
        }


    }
}
