namespace FactoryMethod.WarriorPlayer.Entities
{
    public class Mage : Character
    {
        public override void Atack()
        {
            Console.WriteLine("El mago lanza una bola de fuego.");
        }
        public override void Defend()
        {
            Console.WriteLine("El mago crea un escudo mágico.");
        }

        public override void Walk()
        {
            Console.WriteLine("El mago camina sobre el aire.");
        }
    }
}