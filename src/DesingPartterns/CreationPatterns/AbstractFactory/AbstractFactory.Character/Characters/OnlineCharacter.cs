using AbstractFactorty.Characters.Weapons;

namespace AbstractFactorty.Characters.Characters
{
    public class OnlineCharacter : Character
    {
        public override void Attack(IWeapon weapon)
        {
            Console.WriteLine("Online character attacks...");
            weapon.Use();
        }

        public override void Defend()
        {
            Console.WriteLine("Online character defends...");
        }
    }
}
