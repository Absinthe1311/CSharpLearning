//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace CSharpBook.Chapter07
//{
//    class Test
//    {
//        static void F(params int[] args)
//        {
//            Console.WriteLine("数组包含{0}个元素:", args.Length);
//            foreach (int i in args) Console.Write(" {0}", i);
//            Console.WriteLine();
//        }
//        static void Main()
//        {
//            int[] arr = { 1, 2, 3 };F(arr);F(10, 20, 30);F();
//            Console.ReadKey();
//        }
//    }
//}
