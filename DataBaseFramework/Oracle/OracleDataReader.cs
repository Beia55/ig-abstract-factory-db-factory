using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.Oracle
{
    class OracleDataReader : DB
    {
        public OracleDataReader() : base(DBTypes.Oracle)
        { }

        protected override void AddSpecifics()
        {
            Specifics = "";
        }
    }
}
