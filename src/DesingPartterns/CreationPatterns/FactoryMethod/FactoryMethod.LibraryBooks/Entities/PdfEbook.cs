namespace FactoryMethod.LibraryBooks.Entities
{
    public class PdfEbook : Ebook
    {
        public override void Open()
        {
            Console.WriteLine("Open the file PdfEbook....");
        }

        public override void Close()
        {
            Console.WriteLine("Close the file PdfEbook....");
        }

        public override void Read()
        {
            Console.WriteLine("Read the file PdfEbook....");
        }

        public override void Download()
        {
            Console.WriteLine("Download the file PdfEbook.....");
        }
    }
}