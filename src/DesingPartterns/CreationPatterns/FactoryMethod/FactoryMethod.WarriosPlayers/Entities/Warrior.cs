namespace FactoryMethod.WarriorPlayer.Entities
{
    public class Warrior : Character
    {
        public override void Atack()
        {
             Console.WriteLine("El Guerrero se ataca con su espada.");
        }
        public override void Defend()
        {
             Console.WriteLine("El Guerrero se protege con su espada.");
        }

        public override void Walk()
        {
             Console.WriteLine("El Guerrero se camina con su espada.");
        }
    }
}