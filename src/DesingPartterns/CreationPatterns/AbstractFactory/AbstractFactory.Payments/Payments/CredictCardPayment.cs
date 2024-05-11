namespace AbstractFactory.Payments.Payments
{
    public class CreditCardPayment : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing credit card payment for ${amount}...");
        }
    }
}