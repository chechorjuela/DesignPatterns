namespace FactoryMethod.Builders.Builders.Base{
    public abstract class Building : IBuilder
    {
        public virtual void CloseDoor()
        {
            throw new NotImplementedException();
        }

        public virtual void CloseWindow()
        {
            throw new NotImplementedException();
        }

        public virtual void OpenDoor()
        {
            throw new NotImplementedException();
        }

        public virtual void OpenWindow()
        {
            throw new NotImplementedException();
        }
    }
}