using AbstractFactorty.Characters.Characters;
using AbstractFactorty.Characters.Weapons;

namespace AbstractFactorty.Characters.Factories
{
    public interface ICharacterFactory
    {
        ICharacter CreateCharacter();
        IWeapon CreateWeapon();
    }
}