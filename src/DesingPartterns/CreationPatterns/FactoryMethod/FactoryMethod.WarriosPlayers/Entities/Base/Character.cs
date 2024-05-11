namespace FactoryMethod.WarriorPlayer.Entities{
    public abstract class Character : ICharacter
    {
        public virtual void Atack()
        {
            throw new NotImplementedException();
        }

        public virtual void Defend()
        {
            throw new NotImplementedException();
        }

        public virtual void Walk()
        {
            throw new NotImplementedException();
        }
    }
}