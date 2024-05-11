using AbstractFactory.Payments.Payments;

namespace AbstractFactory.Payments.Factories
{
    public interface IPaymentFactory
    {
        IPaymentMethod CreatePaymenMethod();
    }
}