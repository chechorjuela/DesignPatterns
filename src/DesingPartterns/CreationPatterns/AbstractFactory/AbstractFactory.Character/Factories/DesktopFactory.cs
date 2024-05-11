using AbstractFactorty.Characters.Characters;
using AbstractFactorty.Characters.Weapons;

namespace AbstractFactorty.Characters.Factories
{
    public class DesktopFactory : ICharacterFactory
    {
        public ICharacter CreateCharacter()
        {
            return new DesktopCharacter();
        }

        public IWeapon CreateWeapon()
        {
            return new DesktopWeapon();
        }


    }
}
