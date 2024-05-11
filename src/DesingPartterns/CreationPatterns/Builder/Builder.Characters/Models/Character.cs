namespace Builder.Characters.Models
{
    public class Character
    {
        public string Name { get; set; }
        public string Race { get; set; }
        public string Class { get; set; }
        public List<string> Abilities { get; set; }

        public void Display()
        {
            Console.WriteLine($"Nombre: {Name}");
            Console.WriteLine($"Raza: {Race}");
            Console.WriteLine($"Clase: {Class}");
            Console.WriteLine("Habilidades:");
            foreach (var ability in Abilities)
            {
                Console.WriteLine($"- {ability}");
            }
        }
    }
}