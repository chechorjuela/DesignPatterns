namespace Builder.Delivery.Models
{
    public class Pedido
    {
        public string PlatoPrincipal { get; set; }
        public List<string> Acompanamientos { get; set; }
        public string Bebida { get; set; }
        public string Postre { get; set; }

        public Pedido()
        {
            Acompanamientos = new List<string>();
        }

        public void MostrarDetalle()
        {
            Console.WriteLine("Detalle del Pedido:");
            Console.WriteLine($"Plato Principal: {PlatoPrincipal}");
            Console.WriteLine("Acompañamientos:");
            foreach (var acompanamiento in Acompanamientos)
            {
                Console.WriteLine($"- {acompanamiento}");
            }
            Console.WriteLine($"Bebida: {Bebida}");
            Console.WriteLine($"Postre: {Postre}");
        }
    }
}