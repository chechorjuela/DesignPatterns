using AbstractFactorty.Characters.Characters;
using AbstractFactorty.Characters.Weapons;

namespace AbstractFactorty.Characters.Factories
{
    public class OnlineFactory : ICharacterFactory
    {
        public ICharacter CreateCharacter()
        {
            return new OnlineCharacter();
        }

        public IWeapon CreateWeapon()
        {
            return new OnlineWeapon();
        }
    }
}