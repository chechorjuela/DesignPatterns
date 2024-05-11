using AbstractFactorty.Characters.Weapons;

namespace AbstractFactorty.Characters.Characters
{
    public interface ICharacter
    {
        void Attack(IWeapon weapon);
        void Defend();
    }

}