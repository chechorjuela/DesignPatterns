using Builder.Delivery.Builders;

namespace Builder.Delivery.Directors
{
    public class Director
    {
        public void ConstruirPedido(IPedidoBuilder builder)
        {
            builder.SetPlatoPrincipal("Hamburguesa");
            builder.AddAcompanamiento("Papas Fritas");
            builder.SetBebida("Refresco");
            builder.SetPostre("Helado");
        }
    }
}