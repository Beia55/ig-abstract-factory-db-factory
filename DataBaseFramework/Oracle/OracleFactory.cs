﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.Oracle
{
    class OracleFactory : IDBFactory
    {
        public DB CreateCommandWrapper()
        {
            return new OracleCommandWrapper();
        }

        public DB CreateConnectionManager()
        {
            return new OracleCommandWrapper();
        }

        public DB CreateDataReader()
        {
            return new OracleDataReader();
        }
    }
}
