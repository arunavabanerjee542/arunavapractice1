using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arunavapractice1
{
    class Emp
    {

        int id;
        string name;
        int sal;

        public Emp(int id, string name, int sal)
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
