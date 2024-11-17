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
            PrintMessage($"Added to menu: {menuItem}");
        }

        // Visar menyn
        public void ShowMenu()
        {
            Console.WriteLine("Menu:");
            if (_menu.Count == 0)
            {
                PrintMessage("There is no menu yet.");
            }
            else
            {
                foreach (var item in _menu)
                {
                    PrintMessage($"{item}");
                }
            }
        }

        // Skapar en order och lägger den högst upp på listan samt loggar detta
        public void CreateOrder(Order order)
        {
            _orders.Enqueue(order);
            PrintMessage($"Order number {order.OrderId} added");
        }

        // Hanterar (tar bort) order som är först i kön och loggar detta
        public void HandleOrder()
        {
            if (_orders.Count == 0)
            {
                PrintMessage("There are no orders to handle");
            }
            else
            {
                var order = _orders.Dequeue();
                PrintMessage($"Handled order {order.OrderId} for table {order.TableNumber}");
            }
        }

        // Skriv ut alla ordrar i kön
        public void ShowOrders()
        {
            if (_orders.Count == 0)
            {
                PrintMessage("There are no orders in queue");
            }
            else
            {
                Console.WriteLine("Current orders:");
                foreach (var order in _orders)
                {
                    PrintMessage($"{order}");
                }
            }
        }

        // Skriv ut order som är näst i kön
        public void ShowNextOrder()
        {
            if (_orders.Count == 0)
            {
                PrintMessage("There are no orders in queue");
            }
            else
            {
                var order = _orders.Peek();
                PrintMessage($"Next order in queue:\n{order}");
            }
        }

        // Skriv ut antal ordrar i kön
        public void ShowOrderCount()
        {
            if (_orders.Count == 1)
            {
                PrintMessage($"There is {_orders.Count} order in queue");
            }
            else if (_orders.Count > 1)
            {
                PrintMessage($"There are {_orders.Count} orders in queue");
            }
            else if (_orders.Count == 0)
            {
                PrintMessage("There are no orders in queue");
            }

        }

        public void PrintMessage(string message)
        {
            Console.WriteLine(message);
        }

        public void Lines()
        {
            Console.WriteLine("\n--------------\n");
        }

        public void EmptyRow()
        {
            Console.WriteLine();
        }
    }
}
