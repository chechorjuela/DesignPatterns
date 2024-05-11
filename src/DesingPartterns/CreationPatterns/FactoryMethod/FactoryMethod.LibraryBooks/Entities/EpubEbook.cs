namespace FactoryMethod.LibraryBooks.Entities{
    public class EpubEbook : Ebook {
         public override void Open()
        {
            Console.WriteLine("Open the file EpubEbook....");
        }

        public override void Close()
        {
            Console.WriteLine("Close the file EpubEbook....");
        }

        public override void Read()
        {
            Console.WriteLine("Read the file EpubEbook....");
        }

        public override void Download()
        {
            Console.WriteLine("Download the file EpubEbook.....");
        }
    }
}