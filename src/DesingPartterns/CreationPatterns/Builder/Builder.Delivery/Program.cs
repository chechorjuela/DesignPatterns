// Crear un director y un constructor específico para un tipo de pedido
using Builder.Delivery.Builders;
using Builder.Delivery.Directors;

var director = new Director();
var builder = new PedidoBurgerBuilder();
builder.AddAcompanamiento("Chocolatina");
builder.AddAcompanamiento("Popote");
// Construir el pedido utilizando el director y el constructor específico
director.ConstruirPedido(builder);

// Obtener el pedido construido
var pedido = builder.GetPedido();

// Mostrar el detalle del pedido
pedido.MostrarDetalle();