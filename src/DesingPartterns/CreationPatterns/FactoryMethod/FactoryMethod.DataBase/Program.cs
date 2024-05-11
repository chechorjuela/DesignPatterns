using FactoryMethod.DataBase.DataBase.Base;
using FactoryMethod.DataBase.Factiries;

IDataBase mysqlDataBase = DataBaseFactory.GenerateConnection("mysql");
mysqlDataBase.ConnectDataBase();

IDataBase postgresDb = DataBaseFactory.GenerateConnection("postgres");
postgresDb.ConnectDataBase();

IDataBase sqlserverDb = DataBaseFactory.GenerateConnection("sqlserver");
sqlserverDb.ConnectDataBase();