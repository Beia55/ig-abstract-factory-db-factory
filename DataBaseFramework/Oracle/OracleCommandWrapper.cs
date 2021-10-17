using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.Oracle
{
    class OracleCommandWrapper : DB
    {
        public OracleCommandWrapper() : base(DBTypes.Oracle)
        { }

        protected override void AddSpecifics()
        {
            Specifics = "";
        }
    }
}
