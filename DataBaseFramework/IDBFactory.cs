using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework
{
    public interface IDBFactory
    {
        DB CreateConnectionManager();
        DB CreateDataReader();
        DB CreateCommandWrapper();
    }
}
