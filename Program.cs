using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayList_Homework
{
    class Program
    {
        static void Main(string[] args)
        {
            //ArrayList ArL = new ArrayList(); //testing some ArrayList functions
            


            MyArrayList MArL = new MyArrayList(5);
            MArL.Add("a");
            MArL.Add("b");
            MArL.Add("c");
            MArL.Add("d");
            MArL.Add("e");

            Console.WriteLine("---------------");
            MArL.Get(0);
            MArL.Get(1);
            MArL.Get(2);
            MArL.Get(3);
            MArL.Get(4);
            MArL.Get(5);
            MArL.Get(6);
            Console.WriteLine("---------------");

            Console.WriteLine("object count is: " + MArL.Count());
            Console.WriteLine("array capacity is: " + MArL.Capacity());

            MArL.RemoveAt(3);

            Console.WriteLine("---------------");
            Console.WriteLine("removing at index 3:");
            MArL.Get(0);
            MArL.Get(1);
            MArL.Get(2);
            MArL.Get(3);
            MArL.Get(4);
            MArL.Get(5);
            MArL.Get(6);
            Console.WriteLine("---------------");

            Console.WriteLine("object count is: " + MArL.Count());
            Console.WriteLine("array capacity is: " + MArL.Capacity());

            MArL.Insert(2, "George");
            MArL.Insert(3, "Toby");

            Console.WriteLine("---------------");
            Console.WriteLine("inserting George and Toby at index 2 and 3: ");
            MArL.Get(0);
            MArL.Get(1);
            MArL.Get(2);
            MArL.Get(3);
            MArL.Get(4);
            MArL.Get(5);
            MArL.Get(6);
            Console.WriteLine("---------------");

            Console.WriteLine("object count is: " + MArL.Count());
            Console.WriteLine("array capacity is: " + MArL.Capacity());
        }
    }
}
