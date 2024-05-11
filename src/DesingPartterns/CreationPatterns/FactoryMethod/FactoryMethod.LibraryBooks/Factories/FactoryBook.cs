using FactoryMethod.LibraryBooks.Entities;

namespace FactoryMethod.LibraryBooks.Factory
{
    public static class EbookFactory
    {
        public static Ebook CreateEbook(string format)
        {
            switch (format.ToLower())
            {
                case "pdf":
                    return new PdfEbook();
                case "epub":
                    return new EpubEbook();
                case "mobi":
                    return new MobiEbook();
                default:
                    return new PdfEbook();
            }
        }
    }
}