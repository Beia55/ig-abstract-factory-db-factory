using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.MongoDB
{
    class MongoDBConnectionManager: DB
    {
        public MongoDBConnectionManager() : base(DBTypes.MongoDB)
        { }

        protected override void AddSpecifics()
        {
            Specifics = "";
        }
    }
}
