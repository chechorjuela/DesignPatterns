// Crear fábrica de coches eléctricos
using AbstractFactory.Vehicles.Factories;
using AbstractFactory.Vehicles.Vehicles;

ICarFactory electricCarFactory = new ElectricCarFactory();
// Crear un coche eléctrico
ICar electricCar = electricCarFactory.CreateCar();
// Conducir el coche eléctrico
electricCar.Drive();

// Crear fábrica de coches de gasolina
ICarFactory gasolineCarFactory = new GasolineCarFactory();
// Crear un coche de gasolina
ICar gasolineCar = gasolineCarFactory.CreateCar();
// Conducir el coche de gasolina
gasolineCar.Drive();