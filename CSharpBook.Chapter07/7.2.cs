//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBook.Chapter07
//{
//    public class ThisTest
//    {
//        public int i1 = 123;
//        public String s1 = "abc";
//        public ThisTest(int i1, string s1)
//        {
//            //两个无效赋值
//            //i1 = i1;
//            //s1 = s1;
//            this.i1 = i1;
//            this.s1 = s1;
//        }
//        public void printInfo()
//        {
//            int i1 = 456;
//            String s1 = "def";
//            Console.WriteLine(i1 + " " + s1);
//            Console.WriteLine(this.i1 + " " + this.s1);
//        }
//        public static void Main()
//        {
//            ThisTest obj1 = new ThisTest(999, "zzz");
//            obj1.printInfo();
//            Console.ReadKey();
//        }
//    }
//}
