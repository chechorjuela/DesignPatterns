using Builder.Delivery.Models;

namespace Builder.Delivery.Builders
{
    public interface IPedidoBuilder
    {
        void SetPlatoPrincipal(string platoPrincipal);
        void AddAcompanamiento(string acompanamiento);
        void SetBebida(string bebida);
        void SetPostre(string postre);
        Pedido GetPedido();
    }
}