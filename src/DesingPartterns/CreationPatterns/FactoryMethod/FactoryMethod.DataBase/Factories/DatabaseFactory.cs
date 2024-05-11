using FactoryMethod.DataBase.DataBase;
using FactoryMethod.DataBase.DataBase.Base;

namespace FactoryMethod.DataBase.Factiries
{
    public class DataBaseFactory
    {
        public static IDataBase GenerateConnection(string typeConnection)
        {
            switch (typeConnection.ToLower())
            {
                case "mysql":
                    return new Mysql();
                    break;
                case "sqlserver":
                    return new SqlServer();
                    break;
                case "postgres":
                    return new Postgres();
                    break;
                default:
                    throw new ArgumentException("Connection undefined");
            }
        }
    }
}