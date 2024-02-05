using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Курсова.Model
{
    internal class Employee
    {
        Employee(string _name, DateTime _birthday, int _id, float _rate)
        {
            this.name = _name;
            this.birthday = _birthday;
            this.id = _id;
            this.rate = _rate;
        }

        protected string name;
        protected DateTime birthday;
        protected int id;
        protected float rate;


        public string Name
        {
            get { return name; }
            protected set { name = value; }
        }
        public DateTime Birthday
        {
            get { return birthday; }
            protected set { birthday = value; }
        }
        public int ID
        {
            get { return id; }
            protected set { id = value; }
        }
        public float Rate
        {
            get { return rate; }
            protected set
            {
                if (value < 0)
                    rate = 0;
                rate = value;
            }
        }



    }
}
