using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.MongoDB
{
    class MongoDBFactory : IDBFactory
    {
        public DB CreateCommandWrapper()
        {
            return new MongoDBCommandWrapper();
        }

        public DB CreateConnectionManager()
        {
            return new MongoDBConnectionManager();
        }

        public DB CreateDataReader()
        {
            return new MongoDBDataReader();
        }
    }
}
