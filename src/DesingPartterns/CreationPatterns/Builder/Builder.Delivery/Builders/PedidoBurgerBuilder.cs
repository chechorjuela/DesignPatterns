using Builder.Delivery.Models;

namespace Builder.Delivery.Builders
{
    public class PedidoBurgerBuilder : IPedidoBuilder
    {
        private Pedido _pedido = new Pedido();
        public void AddAcompanamiento(string acompanamiento)
        {
            _pedido.Acompanamientos.Add(acompanamiento);
        }

        public Pedido GetPedido()
        {
             return _pedido;
        }

        public void SetBebida(string bebida)
        {
            _pedido.Bebida = bebida;
        }

        public void SetPlatoPrincipal(string platoPrincipal)
        {
            _pedido.PlatoPrincipal = platoPrincipal;
        }

        public void SetPostre(string postre)
        {
            _pedido.Postre = postre;
        }
    }
}