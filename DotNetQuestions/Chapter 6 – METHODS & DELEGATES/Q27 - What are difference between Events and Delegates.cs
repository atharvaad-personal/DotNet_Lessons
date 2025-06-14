namespace Chapter_6___METHODS___DELEGATES
{
    // Step 1: Define a delegate
    public delegate void OrderPlacedHandler(string orderId);

    // Step 2: Publisher class
    public class OrderProcessor
    {
        // Step 3: Declare the event using the delegate
        public event OrderPlacedHandler OrderPlaced;

        public void PlaceOrder(string orderId)
        {
            Console.WriteLine($"Order {orderId} has been placed.");

            // Step 4: Raise the event
            //OrderPlaced?.Invoke(orderId);

            //OR

            if (OrderPlaced != null)
            {
                OrderPlaced(orderId);
            }
        }
    }

    // Step 5: Subscriber 1 - Billing
    public class BillingService
    {
        public void OnOrderPlaced(string orderId)
        {
            Console.WriteLine($"BillingService: Creating invoice for order {orderId}");
        }
    }

    // Step 6: Subscriber 2 - Shipping
    public class ShippingService
    {
        public void OnOrderPlaced(string orderId)
        {
            Console.WriteLine($"ShippingService: Preparing shipment for order {orderId}");
        }
    }

    // Step 7: Main program to wire everything
    class Program
    {
        //static void Main()
        //{
        //    var processor = new OrderProcessor();
        //    var billing = new BillingService();
        //    var shipping = new ShippingService();

        //    // Subscribe to the event
        //    processor.OrderPlaced += billing.OnOrderPlaced;
        //    processor.OrderPlaced += shipping.OnOrderPlaced;

        //    // Place an order
        //    processor.PlaceOrder("ORD123");
        //}
    }

}
