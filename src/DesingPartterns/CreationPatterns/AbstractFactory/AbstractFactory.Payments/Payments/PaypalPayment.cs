namespace AbstractFactory.Payments.Payments
{
    public class PaypalPayment : IPaymentMethod
    {
        public void ProcessPayment(double amount)
        {
            Console.WriteLine($"Processing paypal payment for ${amount}...");
        }
    }
}