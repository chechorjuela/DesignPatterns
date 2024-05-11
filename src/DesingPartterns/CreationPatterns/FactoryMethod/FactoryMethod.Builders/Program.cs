// Crear una fábrica para construir casas
using FactoryMethod.Builders.Builders.Base;
using FactoryMethod.Builders.Factories;

IBuildingFactory houseFactory = new HouseFactory();

// Construir una casa
Building house = houseFactory.CreateBuilding();
house.OpenDoor();