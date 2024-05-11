namespace FactoryMethod.LibraryBooks.Entities{
    public interface IEbook {
        void Open();
        void Close();
        void Read();
        void Download();
    }
}