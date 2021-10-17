using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework.MongoDB
{
    class MongoDBDataReader : DB
    {
        public MongoDBDataReader() : base(DBTypes.MongoDB)
        { }

        protected override void AddSpecifics()
        {
            Specifics = "";
        }
    }
}
