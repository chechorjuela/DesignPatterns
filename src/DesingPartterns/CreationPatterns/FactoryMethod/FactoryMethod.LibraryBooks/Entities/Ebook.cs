namespace FactoryMethod.LibraryBooks.Entities{
    public abstract class Ebook : IEbook
    {
        public virtual void Open()
        {
            throw new NotImplementedException();
        }

        public virtual void Close()
        {
            throw new NotImplementedException();
        }

        public virtual void Read()
        {
            throw new NotImplementedException();
        }
         public virtual void Download()
        {
            throw new NotImplementedException();
        }
    }
}