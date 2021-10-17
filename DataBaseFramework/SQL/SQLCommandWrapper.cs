using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.SQL
{
    class SQLCommandWrapper: DB
    {
        public SQLCommandWrapper() : base(DBTypes.Oracle)
        { }

        protected override void AddSpecifics()
        {
            Specifics = "";
        }
    }
}
