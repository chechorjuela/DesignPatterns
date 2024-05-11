using FactoryMethod.DataBase.DataBase.Base;

namespace FactoryMethod.DataBase.DataBase
{
    public class SqlServer : DataBaseConnection
    {
        public override void ConnectDataBase()
        {
            Console.WriteLine("Connect to SqlServer");
        }
    }
}