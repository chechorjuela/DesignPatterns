using System.Data;
using AbstractFactory.Furniture.Furniture;

namespace AbstractFactory.Furniture.Factories
{
    public interface IFurnitureFactory
    {
        IChair CreateChair();
        ITable CreateTable();
    }

}