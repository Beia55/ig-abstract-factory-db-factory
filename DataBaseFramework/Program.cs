using System;

namespace DataBaseFramework
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

            IDBFactory iDBFactory = new MongoDB.MongoDBFactory();
            Console.WriteLine(iDBFactory.CreateCommandWrapper().ToString());
            Console.WriteLine(iDBFactory.CreateConnectionManager().ToString());
            Console.WriteLine(iDBFactory.CreateDataReader().ToString());

            iDBFactory = new Oracle.OracleFactory();
            Console.WriteLine(iDBFactory.CreateCommandWrapper().ToString());
            Console.WriteLine(iDBFactory.CreateConnectionManager().ToString());
            Console.WriteLine(iDBFactory.CreateDataReader().ToString());

            iDBFactory = new SQL.SQLFactory();
            Console.WriteLine(iDBFactory.CreateCommandWrapper().ToString());
            Console.WriteLine(iDBFactory.CreateConnectionManager().ToString());
            Console.WriteLine(iDBFactory.CreateDataReader().ToString());

        }
    }
}
