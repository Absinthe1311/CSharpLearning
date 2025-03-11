using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Cache;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Chapter06
{
    class Cat
    {
        public int Age { get; set; }
        public String Name { get; set; }
    }
    class Test
    {
        public static void Main()
        {
            Cat cat = new Cat { Name = "Maomi", Age = 3 };
            Console.WriteLine(cat.Name);
            Console.WriteLine(cat.Age);
        }
    }
}
