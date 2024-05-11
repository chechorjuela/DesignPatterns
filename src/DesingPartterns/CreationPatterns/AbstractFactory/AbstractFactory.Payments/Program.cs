using AbstractFactory.Payments.Factories;
using AbstractFactory.Payments.Payments;

// Crear fábrica de pagos

IPaymentFactory paymentFactory = new PaypalPaymentFactory();
// Crear un pago con paypal
IPaymentMethod paymentPaypal = paymentFactory.CreatePaymenMethod();
// Pagar con paypal
paymentPaypal.ProcessPayment(2.5);

IPaymentFactory paymentCredictCardFactory = new CreditCardPaymentFactory();

IPaymentMethod paymentCredictCard = paymentCredictCardFactory.CreatePaymenMethod();
paymentCredictCard.ProcessPayment(5.45);

