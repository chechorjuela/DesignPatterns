using AbstractFactorty.Characters.Weapons;

namespace AbstractFactorty.Characters.Characters
{
    public abstract class Character : ICharacter
    {
        public abstract void Attack(IWeapon weapon);
        public abstract void Defend();
    }

}