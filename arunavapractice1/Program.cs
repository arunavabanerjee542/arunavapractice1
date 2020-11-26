using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace arunavapractice1
{

    public enum Employee
    {
        arun =1,
        ravi=2,
        raj=5
    }

    class Program
    {
        static void Main(string[] args)
        {
            // static meyhods

            Console.WriteLine("dcghvjch");

            int x =Person.add(1, 3);
            int y = Person.add(5, 8);

            
            Console.WriteLine(x);
           Console.WriteLine(y);
         


            // playing with enum

            var xx = Employee.raj;

            Console.WriteLine((int)xx);

            int yy = 5;

            Console.WriteLine((Employee)yy);


            // REFERENCE AND VALUE TYPES


            int a = 10;
            int b = a;
            b++;

            Console.WriteLine(a);


            var ar = new int[3] { 1, 2, 3 };

            var arr = ar;

            arr[0] = -1;

            Console.WriteLine(ar[0]); // we see that 0th index if ar has changed








        }
    }




}
