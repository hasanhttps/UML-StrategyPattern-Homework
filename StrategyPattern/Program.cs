namespace StrategyPattern
{
    public class Program
    {
        static void Main(string[] args)
        {
            ShoppingCart regularCart = new ShoppingCart(new RegularCustomerDiscount());
            ShoppingCart premiumCart = new ShoppingCart(new PremiumCustomerDiscount());
            ShoppingCart newCustomerCart = new ShoppingCart(new NewCustomerDiscount());

            double amount = 100.0;

            Console.WriteLine("Regular Customer Total Price: " + regularCart.CalculateTotalPrice(amount));
            Console.WriteLine("Premium Customer Total Price: " + premiumCart.CalculateTotalPrice(amount));
            Console.WriteLine("New Customer Total Price: " + newCustomerCart.CalculateTotalPrice(amount));
        }
    }
}