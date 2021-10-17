using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.SQL
{
    class SQLFactory : IDBFactory
    {
        public DB CreateCommandWrapper()
        {
            return new SQLCommandWrapper();
        }

        public DB CreateConnectionManager()
        {
            return new SQLCommandWrapper();
        }

        public DB CreateDataReader()
        {
            return new SQLDataReader();
        }
    }
}
