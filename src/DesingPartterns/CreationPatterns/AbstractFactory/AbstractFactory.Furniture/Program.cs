using AbstractFactory.Furniture.Factories;
using AbstractFactory.Furniture.Furniture;

IFurnitureFactory modernFactory = new ModernFurnitureFactory();

// Crear silla y mesa modernas
IChair modernChair = modernFactory.CreateChair();
ITable modernTable = modernFactory.CreateTable();

// Utilizar los muebles modernos
modernChair.Sit();
modernTable.Place();

// Crear una fábrica de muebles victorianos
IFurnitureFactory victorianFactory = new VictorianFurnitureFactory();

// Crear silla y mesa victorianas
IChair victorianChair = victorianFactory.CreateChair();
ITable victorianTable = victorianFactory.CreateTable();

// Utilizar los muebles victorianos
victorianChair.Sit();
victorianTable.Place();