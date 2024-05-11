namespace FactoryMethod.DataBase.DataBase.Base
{
    public abstract class DataBaseConnection : IDataBase
    {
        public abstract void ConnectDataBase();
    }
}