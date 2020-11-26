using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndGeneric
{
    public class Employee
    {
        int id;
        string name;
        int sal;

        public Employee(int id,string name,int sal)
        {
            this.id = id;
            this.name = name;
            this.sal = sal;

        }

        public override string ToString()
        {
            return id + " " + name + " " + sal;
        }

    }
}
