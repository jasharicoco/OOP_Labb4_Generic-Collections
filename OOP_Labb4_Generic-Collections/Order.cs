namespace OOP_Labb4_Generic_Collections
{
    internal class Order
    {
        // I denna klass använder vi i stället private fields
        public static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public int OrderId { get { return _orderId; } }
        public int TableNumber { get { return _tableNumber; } }

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        // Lägger till rätter i beställningen (listan)
        public void AddItem(MenuItem item)
        {
            _orderItems.Add(item);
        }

        public override string ToString()
        {
            // Vid beställning av flera rätter sammanfogas dessa till en sträng
            string items = string.Join("\n", _orderItems.Select(item => $"1 st {item.Name}"));
            // Spara totalen i en decimal
            decimal totalCost = _orderItems.Sum(item => item.Price);

            return $"Order {_orderId}:\n{items}\nTotal: {totalCost.ToString("C")}\nTo table number {_tableNumber}\n";
        }


    }
}
