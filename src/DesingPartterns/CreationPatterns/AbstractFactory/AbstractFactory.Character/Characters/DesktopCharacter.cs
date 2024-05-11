using AbstractFactorty.Characters.Weapons;

namespace AbstractFactorty.Characters.Characters
{
    public class DesktopCharacter : Character
    {
        public override void Attack(IWeapon weapon)
        {
            Console.WriteLine("Desktop character attacks...");
            weapon.Use();
        }

        public override void Defend()
        {
            Console.WriteLine("Desktop character defends...");
        }
    }
}