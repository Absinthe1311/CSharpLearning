using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpBook.Chapter02
{
    class String
    {
        static void Main()
        {
            string str1 = "Hello ";
            string str2 = "World!";
            string str3 = str1 + str2;  //字符串拼接 Hello World
            char char1 = str3[1];  //获取字符串str3的第二个字符e
            string str4 = "\"C:\\C#\\\"";  //转义字符
            Console.WriteLine(str3);
            Console.WriteLine(str4);
            Console.ReadLine();
        }
    }
    
}
