using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.Oracle
{
    class OracleConnectionManager : DB
    {
        public OracleConnectionManager() : base(DBTypes.Oracle)
        { }

        protected override void AddSpecifics()
        {
            Specifics = "";
        }
    }
}
