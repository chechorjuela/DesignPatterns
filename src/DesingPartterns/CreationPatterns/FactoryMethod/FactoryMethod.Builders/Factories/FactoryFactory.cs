
using FactoryMethod.Builders.Builders;
using FactoryMethod.Builders.Builders.Base;

namespace FactoryMethod.Builders.Factories{
    public class FactoryFactory : IBuildingFactory
    {
        public Building CreateBuilding()
        {
            return new Factory();
        }
    }
}