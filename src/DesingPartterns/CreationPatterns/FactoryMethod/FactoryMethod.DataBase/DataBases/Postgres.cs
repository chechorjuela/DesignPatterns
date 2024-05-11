using FactoryMethod.DataBase.DataBase.Base;

namespace FactoryMethod.DataBase.DataBase
{
    public class Postgres : DataBaseConnection
    {
        public override void ConnectDataBase()
        {
            Console.WriteLine("Connect to Postgresql");
        }
    }
}