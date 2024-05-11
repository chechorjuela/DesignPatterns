using FactoryMethod.WarriorPlayer.Entities;

namespace FactoryMethod.WarriorPlayer.Factory
{
    public static class CharacterFactory
    {
        public static Character CreateEbook(string format)
        {
            switch (format.ToLower())
            {
                case "mage":
                    return new Mage();
                case "warrior":
                    return new Warrior();
                default:
                    return new Archer();
            }
        }
    }
}