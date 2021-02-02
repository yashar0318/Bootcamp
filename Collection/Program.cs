using System;
using System.Collections.Generic;

namespace Collection
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] names = new string[] { "Yashar", "Eli", "Azer", "Sabir" };
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);
            //Console.WriteLine(names[2]);
            //Console.WriteLine(names[3]);

            //names = new string[5];
            //names[4] = "Samir";                         // ctrl k ctrl c // ctrl k ctrl u command uncommand
            //Console.WriteLine(names[4]);
            //Console.WriteLine(names[0]);
            //Console.WriteLine(names[1]);


            List<string> names2 = new List<string> { "Yashar", "Eli", "Azer", "Sabir" };
            Console.WriteLine(names2[0]);
            Console.WriteLine(names2[1]);
            Console.WriteLine(names2[2]);
            Console.WriteLine(names2[3]);
            names2.Add("Samir");
            Console.WriteLine(names2[4]);
            Console.WriteLine(names2[0]);
        }
    }
}
