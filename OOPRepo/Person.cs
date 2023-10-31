using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OOPRepo
{
    public static class Person
    {
        //Person person = new Person();
        static int son = 12;
        public static string FirstName { get; set; }
        public static string LastName { get; set; }
        public static int Age { get; set; }

        public static void GetInfo()
        {
            Console.WriteLine("Ma'lumot berildi");
        }


    }
}
