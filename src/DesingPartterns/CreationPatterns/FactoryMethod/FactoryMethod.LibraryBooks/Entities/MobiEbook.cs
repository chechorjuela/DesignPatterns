namespace FactoryMethod.LibraryBooks.Entities{
    public class MobiEbook : Ebook{
        public override void Open()
        {
            Console.WriteLine("Open the file MobiEbook....");
        }

        public override void Close()
        {
            Console.WriteLine("Close the file MobiEbook....");
        }

        public override void Read()
        {
            Console.WriteLine("Read the file MobiEbook....");
        }

        public override void Download()
        {
            Console.WriteLine("Download the file MobiEbook.....");
        }
    }
}