// See https://aka.ms/new-console-template for more information
using FactoryMethod.LibraryBooks.Entities;
using FactoryMethod.LibraryBooks.Factory;

Console.WriteLine("Enter the type of ebook (PDF, EPUB, MOBI):");
string typeFile = Console.ReadLine();
try
{
    IEbook ebook = EbookFactory.CreateEbook(typeFile);
    ebook.Open();
    ebook.Read();
    ebook.Download();
    ebook.Close();
}
catch (Exception exp)
{
    Console.WriteLine(exp.Message);
}
Console.WriteLine("Press any key to exit app...");
Console.ReadKey();