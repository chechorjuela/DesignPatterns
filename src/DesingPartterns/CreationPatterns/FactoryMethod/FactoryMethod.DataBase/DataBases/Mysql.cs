using FactoryMethod.DataBase.DataBase.Base;

namespace FactoryMethod.DataBase.DataBase
{
    public class Mysql : DataBaseConnection
    {
        public override void ConnectDataBase()
        {
            Console.WriteLine("Connect to Mysql");
        }
    }
}