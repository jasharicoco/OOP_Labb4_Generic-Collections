namespace OOP_Labb4_Generic_Collections
{
    internal class Order
    {
        // I denna klass använder vi i stället private fields
        static int orderIdCounter = 1;
        private int _orderId;
        private List<MenuItem> _orderItems;
        private int _tableNumber;

        public Order(List<MenuItem> orderItems, int tableNumber)
        {
            // Automatiskt skapande av id
            _orderId = orderIdCounter;
            orderIdCounter++;
            _orderItems = orderItems;
            _tableNumber = tableNumber;
        }

        public override string ToString()
        {
            // Vid beställning av flera 'items' sammanfogas dessa till en sträng
            string items = string.Join(", ", _orderItems);
            return $"Order ID: {_orderId}, Table: {_tableNumber}, Items: {items}";
        }


    }
}
