namespace AbstractFactory.Payments.Payments
{
    public interface IPaymentMethod
    {
        void ProcessPayment(double amount);
    }
}