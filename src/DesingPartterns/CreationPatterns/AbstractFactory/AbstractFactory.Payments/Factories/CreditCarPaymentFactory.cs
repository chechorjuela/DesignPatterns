using AbstractFactory.Payments.Payments;

namespace AbstractFactory.Payments.Factories {
    public class CreditCardPaymentFactory : IPaymentFactory
    {
        public IPaymentMethod CreatePaymenMethod()
        {
            return new CreditCardPayment();
        }
    }
}