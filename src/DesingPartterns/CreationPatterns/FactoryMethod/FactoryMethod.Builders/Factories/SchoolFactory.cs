
using FactoryMethod.Builders.Builders;
using FactoryMethod.Builders.Builders.Base;

namespace FactoryMethod.Builders.Factories{
    public class SchoolFactory : IBuildingFactory
    {
        public Building CreateBuilding()
        {
            return new School();
        }
    }
}