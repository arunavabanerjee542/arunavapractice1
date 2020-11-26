using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CollectionAndGeneric
{
    class Collect
    {
        static void Main(string[] args)
        {

            Employee a = new Employee( 1, "arunava", 33333);
            Employee b = new Employee(2, "Ravi", 321225);
            Employee c = new Employee(3, "Tom", 33111);

         List<Employee> ar = new List<Employee>();

            ar.Add(a);
            ar.Add(b);
            ar.Add(c);

            Console.WriteLine(ar);



        }

    }
}
