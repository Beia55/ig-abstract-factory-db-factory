using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataBaseFramework
{
    public abstract class DB
    {
        public DBTypes Type { get; }
        public DateTime CreationDate { get; private set; }

        public string Specifics { get; protected set; }

        public DB(DBTypes type) 
        {
            Type = type;
            CreateDB();
            AddSpecifics();
        }

        private void CreateDB()
        {
            CreationDate = DateTime.Now.AddYears(3);
        }

        protected abstract void AddSpecifics();

        public override string ToString()
        {
            return $"The {GetType()} {Type} db was created in {CreationDate.ToShortDateString()}.  \r Specifics included: {Specifics}.";
        }
    }
}
