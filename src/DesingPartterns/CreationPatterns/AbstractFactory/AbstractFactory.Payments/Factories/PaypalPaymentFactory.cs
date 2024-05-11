using AbstractFactory.Payments.Payments;

namespace AbstractFactory.Payments.Factories{
    public class PaypalPaymentFactory : IPaymentFactory
    {
        public IPaymentMethod CreatePaymenMethod()
        {
            return new PaypalPayment();
        }
    }
}