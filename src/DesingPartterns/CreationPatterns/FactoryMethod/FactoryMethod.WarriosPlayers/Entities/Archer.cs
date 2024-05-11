namespace FactoryMethod.WarriorPlayer.Entities
{
    public class Archer : Character
    {
        public override void Atack()
        {
             Console.WriteLine("El arquero dispara una flecha.");
        }
        public override void Defend()
        {
            Console.WriteLine("El arquero se protege con su arco.");

        }

        public override void Walk()
        {
             Console.WriteLine("El arquero camina un el arco.");
        }
    }
}