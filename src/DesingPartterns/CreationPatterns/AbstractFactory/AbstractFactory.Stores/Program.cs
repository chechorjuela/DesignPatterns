// See https://aka.ms/new-console-template for more information
// Crear fábrica de productos de Samsung
using AbstractFactory.Stores.Devices;
using AbstractFactory.Stores.Factories;

IElectronicProductFactory samsungFactory = new SamsungFactory();

// Crear teléfono móvil y computadora portátil de Samsung
IPhone samsungPhone = samsungFactory.CreatePhone();
ILaptop samsungLaptop = samsungFactory.CreateLaptop();

// Mostrar información de los productos de Samsung
Console.WriteLine("Samsung Products:");
samsungPhone.DisplayInfo();
samsungLaptop.DisplayInfo();

// Crear fábrica de productos de Apple
IElectronicProductFactory appleFactory = new AppleFactory();

// Crear teléfono móvil y computadora portátil de Apple
IPhone iPhone = appleFactory.CreatePhone();
ILaptop macBook = appleFactory.CreateLaptop();

// Mostrar información de los productos de Apple
Console.WriteLine("\nApple Products:");
iPhone.DisplayInfo();
macBook.DisplayInfo();