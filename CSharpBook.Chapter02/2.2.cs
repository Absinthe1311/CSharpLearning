//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBook.Chapter02
//{
//    class TestVariableScope
//    {
//        static int j = 99;
//        public static void Main(string[] args)
//        {
//            //string[] args = "abc";
//            for(int i = 0; i < 2; i++)
//            {
//                int k = 10;
//                Console.WriteLine(k + " * " + i + " = " + k * i);
//            }
//            //System.out.println(i);
//            int j = 20;
//            Console.WriteLine("Class j=" + TestVariableScope.j);
//            Console.WriteLine("Local j=" + j);
//            for(int i = 0; i< 2;i++)
//            {
//                int k = 20;
//                //int j = 20;
//                Console.WriteLine(k + "*" + i + " = " + k * i);
//            }
//            int x = 3;
//            ref int x1 = ref x;
//            x1 = 2;
//            Console.WriteLine($"改变后的变量 {nameof(x)} 值为: {x}");
//        }
//    }
//}
