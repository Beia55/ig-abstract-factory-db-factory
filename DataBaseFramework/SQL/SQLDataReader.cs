using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.SQL
{
    class SQLDataReader : DB
    {
        public SQLDataReader() : base(DBTypes.Oracle)
        { }

        protected override void AddSpecifics()
        {
            Specifics = "";
        }
    }
}
