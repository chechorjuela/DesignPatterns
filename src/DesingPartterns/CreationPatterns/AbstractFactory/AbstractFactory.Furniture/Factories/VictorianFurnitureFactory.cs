using AbstractFactory.Furniture.Factories;
using AbstractFactory.Furniture.Furniture;

public class VictorianFurnitureFactory : IFurnitureFactory
{
    public IChair CreateChair()
    {
        return new VictorianChair();
    }

    public ITable CreateTable()
    {
        return new VictorianTable();
    }
}